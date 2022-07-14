using Microsoft.AspNetCore.Mvc;
using RsdProject.Models.ViewModel;
using TestRSD.Models.ViewModels;
using TestRSD.Services.IServices;
using TestRSD.Services.Services;

namespace TestRSD.Controllers
{
    public class MedicineOperationsServicesController : Controller
    {
        private IDrugsOperationsServices _MidOp;
        public MedicineOperationsServicesController(IDrugsOperationsServices MidOp)
        {
            _MidOp = MidOp;

        }
        public IActionResult MedcineSell()
        {
            return View();
        }
        public IActionResult MedcineSell(medicineSallVM medicineSellVM)
        {
            _MidOp.DrugSell(medicineSellVM);
            return View(medicineSellVM);
        }

        public IActionResult Acceptance()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Acceptance(AcceptVM acceptanceVM)
        {
            _MidOp.DrugAccept(acceptanceVM);
            return RedirectToAction("Index", "Home");
        }
    }
}
