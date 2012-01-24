/// <reference path="ViewModel.js" />
/// <reference path="jquery-1.6.2.js" />
/// <reference path="jquery-ui-1.8.11.js" />

function hideDetails() {
    $("#details").fadeOut();
}

function toggleFilters() {
    $("#filters").fadeToggle();
}

function updateData() {
    var data = {};
    var useFilters = $("#useFilters").val();

    $.get("Tracker/GetData", data, function (result) {
        viewModel.totalSessions(result.length);
    });

    if (useFilters) {
        var top = $("#rowsToDisplay").val();
        if (top != "All") {
            data["top"] = top;
        }

        var skip = $("#rowsToSkip").val();
        if (skip != "") {
            data["skip"] = skip;
        }
    }

    $.get("Tracker/GetData", data, function (result) {
        var sessions = [];
        for (var i = 0; i < result.length; i++) {
            var serverSession = result[i];
            var sets = [];
            for (var j = 0; j < serverSession.Sets.length; j++) {
                var serverSet = serverSession.Sets[j];
                sets.push(new Set(serverSet.DistanceYards, serverSet.Style, serverSet.Duration));
            }

            var session = new Session(serverSession.DateString, serverSession.Duration, sets);
            sessions.push(session);
        }

        viewModel.sessions(sessions);
    });
}

function initializeData() {
    $("#btnHideDetails").button();
    $("h1").addClass("ui-widget-header");
    $("#sessionsTable").addClass("ui-widget");
    $("#sessionsTable thead").addClass("ui-widget-header");
    $("#sessionsTable tbody").addClass("ui-widget-content");

    var today = new Date();
    var veryEarly = new Date(2006, 0, 1);
    $("#startDate").val($.datepicker.formatDate($.datepicker.ISO_8601, veryEarly));
    $("#endDate").val($.datepicker.formatDate($.datepicker.ISO_8601, today));
    $("#startDate, #endDate").datepicker({
        dateFormat: $.datepicker.ISO_8601
    });

    $("#rowsToDisplay, #rowsToSkip, #timeOfDay, #startDate, #endDate, #useFilters").change(updateData);

    updateData();
}
