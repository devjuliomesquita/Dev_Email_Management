using AutoMapper;
using Dev_Email_Management.Domain.Entities;
using Dev_Email_Management.Domain.Interfaces;
using Dev_Email_Management.Infrastructure.Repositories;
using Dev_Email_Management.MVC.DTOs.InputModel;
using Dev_Email_Management.MVC.DTOs.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dev_Email_Management.MVC.Controllers
{
    public class BusinessController : Controller
    {
        //Criando o construtor
        private readonly IMapper _mapper;
        private readonly IBusinessRepository _iBusinessRepository;
        public BusinessController(IMapper mapper, IBusinessRepository ibusinessRepository)
        {
            _mapper = mapper;
            _iBusinessRepository = ibusinessRepository;
        }
        // GET: BusinessController
        public ActionResult Index()
        {
            var businessViewModel = _mapper.Map<IEnumerable<Business>, IEnumerable<BusinessViewModel>>(_iBusinessRepository.GetAll());
            return View(businessViewModel);
        }

        // GET: BusinessController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BusinessController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusinessController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddBusinessInputModel model)
        {
            try
            {
                if (!ModelState.IsValid) { return View(model); }
                var businessDomain = _mapper.Map<AddBusinessInputModel, Business>(model);
                _iBusinessRepository.Add(businessDomain);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        // GET: BusinessController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BusinessController/Edit/5
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

        // GET: BusinessController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BusinessController/Delete/5
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
