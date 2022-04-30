using CalendarManagementApplication.Models;
using CalendarManagementApplication.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace CalendarManagementApplication.Controllers
{
    public class SchedulerController : ApiController
    {
        private readonly IEventRepository _repository;

        public SchedulerController(IEventRepository repository)
        {
            _repository = repository;
        }


        // GET: api/scheduler
        //public IEnumerable<WebAPIEvent> Get()
        //{
        //    return Ok();
        //}

        //// GET: api/scheduler/5
        //public WebAPIEvent Get()
        //{
        //    return Ok();
        //}

        // PUT: api/scheduler/5
        [System.Web.Http.HttpPut]
        public IHttpActionResult EditSchedulerEvent()
        {
            return Ok();
        }


        [System.Web.Http.HttpPost]
        public IHttpActionResult CreateSchedulerEvent()
        {
            return Ok();
//            var model = new SchedulerEvent();
//            if (ModelState.IsValid)
//            {
//                create the event object
//                var events = new SchedulerEvent
//                {
//                    Start = model.Start,
//                    End = model.End,
//                    Description = model.Description
//    };

//    create the Event
//   var result = _repository.CreateEvent(events);

//                If it's successful pop up message, you event is created
//                if (result)
//                {
//                    return Ok();
//}
//                else              //if model state is not valid, the model with error message is returned to the view
//{
//    return View(new ErrorViewModel { });
//}
//            }
//            return;

        }


        // POST: api/scheduler/5
        //[System.Web.Http.HttpPost]
        //public IHttpActionResult CreateSchedulerEvent()
        //{
        //    var model = new SchedulerEvent();
        //    //if (ModelState.IsValid)
        //    //{
        //        //create the event object
        //        var events = new SchedulerEvent
        //        {
        //            Start = model.Start,
        //            End = model.End,
        //            Description = model.Description
        //        };

        //        // create the Event
        //        var result = _repository.CreateEvent(events);

        //        //If it's successful pop up message, you event is created
        //        if (result)
        //        {
        //            return Ok(new
        //            {
        //                action = "inserted"
        //            });
        //        }
        //    //else              //if model state is not valid, the model with error message is returned to the view
        //    //{
        //    //    return new ErrorViewModel;
        //    //}
        //    //}
        //    return Ok();
        //}

        // DELETE: api/scheduler/5
        [System.Web.Http.HttpDelete]
        public IHttpActionResult DeleteSchedulerEvent()
        {
            return Ok();
        }

        protected override void Dispose(bool disposing)
        {

        }
    }
}
