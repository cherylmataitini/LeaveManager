using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LeaveManagement.Contracts;
using LeaveManagement.Data;
using LeaveManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.Controllers
{
    public class LeaveTypesController : Controller
    {
        private readonly ILeaveTypeRepository _repo; // using the interface for DI - NOT the concrete class LeaveTypeRepository
        private readonly IMapper _mapper;

        // DI - repository and the automapper
        public LeaveTypesController(ILeaveTypeRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        // GET: LeaveTypesController
        public ActionResult Index()
        {
            var leaveTypes = _repo.FindAll().ToList(); // remember that this returns data objects (model class)
            // Our view needs to have the ViewModel objects - so we need to map the data class object to the ViewModel class object
            var model = _mapper.Map<List<LeaveType>, List<DetailsLeaveTypeViewModel>>(leaveTypes);

            return View(model); // passing in ViewModel obj
        }

        // GET: LeaveTypesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LeaveTypesController/Create
        public ActionResult Create()
        {
          
            return View();
        }

        // POST: LeaveTypesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateLeaveTypeViewModel data)
        {
            try
            {
                if (!ModelState.IsValid) // ModelState being the model (data) that we get in the POST request - is a CreateLeaveTypeViewModel object in this case
                {
                    return View(data);
                }
                
                var leaveType = _mapper.Map<LeaveType>(data); // mapping object of type CreateLeaveTypeViewModel into the type LeaveType (remember we want to map back to the data class before inserting into the db)
                leaveType.DateCreated = DateTime.Now;
                var isSuccess = _repo.Create(leaveType); // Method of the ILeaveTypeRepository - remember it also calls Save() which returns a boolean
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "Something went wrong...");
                    return View(data);
                }

                return RedirectToAction(nameof(Index));
            } 
            catch
            {
                ModelState.AddModelError("", "Something went wrong...");
                return View();
            }
        }

        // GET: LeaveTypesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LeaveTypesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LeaveTypesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LeaveTypesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
