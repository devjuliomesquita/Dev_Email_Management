using AutoMapper;

using Dev_Email_Management.Domain.Entities;
using Dev_Email_Management.Domain.Interfaces.Repositories;
using Dev_Email_Management.Domain.Interfaces.Service;
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
        private readonly IBusinessRepository _businessRepository;
        private readonly IBusinessService _businessService;
        
        public BusinessController(IMapper mapper, IBusinessRepository businessRepository, IBusinessService businessService)
        {
            _mapper = mapper;
            _businessRepository = businessRepository;
            _businessService = businessService;
        }
        // GET: BusinessController
        public ActionResult Index()
        {
            var businessViewModel = _mapper.Map<IEnumerable<Business>, IEnumerable<BusinessViewModel>>(_businessRepository.GetAll());
            return View(businessViewModel);
        }

        // GET: BusinessController/Details/5
        public ActionResult Details(int id)
        {
            var business = _businessRepository.GetById(id);
            var businessViewModel = _mapper.Map<Business, BusinessViewModel>(business);
            return View(businessViewModel);
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
                _businessRepository.Add(businessDomain);
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
            var business = _businessRepository.GetById(id);
            var businessViewModel = _mapper.Map<Business, BusinessViewModel>(business);
            return View(businessViewModel);
        }

        // POST: BusinessController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BusinessViewModel businessViewModel)
        {
            if (ModelState.IsValid)
            {
                var businessDomain = _mapper.Map<BusinessViewModel, Business>(businessViewModel);
                _businessRepository.Update(businessDomain);
            }
            return RedirectToAction(nameof(Index));
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
