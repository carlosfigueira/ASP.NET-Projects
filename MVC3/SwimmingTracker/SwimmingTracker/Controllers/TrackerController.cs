using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SwimmingTracker.Models;

namespace SwimmingTracker.Controllers
{
    public class TrackerController : Controller
    {
        public JsonResult GetData(int? top, int? skip)
        {
            var result = new JsonResult();
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            IEnumerable<Session> collection = SessionRepository.GetSessions();
            if (skip.HasValue)
            {
                collection = collection.Skip(skip.Value);
            }

            if (top.HasValue)
            {
                collection = collection.Take(top.Value);
            }

            result.Data = collection;

            Response.CacheControl = "no-cache";

            return result;
        }

    }
}
