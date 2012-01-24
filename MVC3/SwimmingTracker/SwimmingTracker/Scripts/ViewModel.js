/// <reference path="knockout-2.0.0.debug.js" />
/// <reference path="jquery-1.6.2.js" />

function Session(date, duration, sets) {
    var self = this;
    self.date = date;
    self.duration = duration;
    self.sets = sets;

    self.totalDistance = ko.computed(function () {
        var total = 0;
        for (var i = 0; i < self.sets.length; i++) {
            total += sets[i].distance;
        }
        return total;
    });

    self.averagePace = ko.computed(function () {
        var distance = self.totalDistance();
        var durationParts = self.duration.split(":");
        var minutes = parseFloat(durationParts[1]) + (parseFloat(durationParts[2]) / 60);
        var pace = distance / minutes;
        return pace.toFixed(1);
    });

    self.showDetails = function () {
        viewModel.currentSets(self.sets);
        $("#details").css("visibility", "visible");
        $("#details").fadeIn();
    };
}

function Set(distance, style, duration) {
    var self = this;
    self.distance = distance;
    self.style = style;
    if (duration) {
        self.duration = duration;
    }

    self.formattedDuration = ko.computed(function () {
        return duration || "";
    });
}

function SwimmingViewModel() {
    var self = this;

    self.styles = [
                "Butterfly",
                "Backstroke",
                "Breaststroke",
                "Freestyle",
                "Medley",
                "OpenWater",
            ];

    self.currentSets = ko.observable([]);
    self.sessions = ko.observable([]);
    self.totalSessions = ko.observable(0);
}

var viewModel = new SwimmingViewModel();
ko.applyBindings(viewModel);
