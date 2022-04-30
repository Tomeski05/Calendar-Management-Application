using CalendarManagementApplication.Models;
using CalendarManagementApplication.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarManagementApplication.Controllers
{
    [Route("[controller]")]
    public class EventsController : Controller
    {
        private readonly IEventRepository _repository;

        public EventsController(IEventRepository repository)
        {
            _repository = repository;
        }

        // GET: Event/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Event/Create
        [HttpPost]
        public ActionResult CreateSchedulerEvent()
        {
            var model = new SchedulerEvent();
            if (ModelState.IsValid)
            {
                //create the event object
                var events = new SchedulerEvent
                {
                    Start = model.Start,
                    End = model.End,
                    Description = model.Description
                };

                // create the Event
                var result = _repository.CreateEvent(events);

                //If it's successful pop up message, you event is created
                if (result)
                {
                    return RedirectToAction();
                }
                else              //if model state is not valid, the model with error message is returned to the view
                {
                    return View(new ErrorViewModel { });
                }
            }
            return View(model);
        }

        // GET: Event/Update
        public IActionResult Update()
        {
            return View();
        }

        // POST: Event/Create
        [HttpPost]
        public ActionResult Update(int id)
        {
            if (ModelState.IsValid)
            {

                var result = _repository.UpdateEvent(id);

            }
            return View();
        }

        // GET: Event/Delete
        public IActionResult Delete()
        {
            return View();
        }

        // POST: Event/Delete
        [HttpPost]
        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var result = _repository.DeleteEvent(id);

                if(result != null)
                {
                    
                }

            }
            return View();
        }

    }
}