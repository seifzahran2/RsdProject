using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RsdProject.Models.ViewModel;
using TestRSD.Models.ViewModels;
using TestRSD.Services.IServices;
using TestRSD.Services.Services;

namespace TestRSD.Controllers
{
    [Authorize(Roles = "sa7pMasla7a")]
    public class MedicineOperationsServicesController : Controller
    {
        private IDrugsOperationsServices _MidOp;
        public MedicineOperationsServicesController(IDrugsOperationsServices MidOp)
        {
            _MidOp = MidOp;

        }
        public IActionResult DrugsSell()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DrugsSell(DrugSellVM medicineSellVM)
        {
            _MidOp.DrugSell(medicineSellVM);
            return View(medicineSellVM);
        }
        //صفحه استرجاع الدواء
        public IActionResult DrugsSellCancle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DrugsSellCancle(DrugSellVM medicineReSallVM)
        {
            _MidOp.DrugsReSall(medicineReSallVM);
            return View(medicineReSallVM);
        }
        //صفحه القبول 
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
        //صفحه الرجوع 
        public IActionResult Return()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Return(ReturnVM el_ReturnVM)
        {
            _MidOp.Return(el_ReturnVM);
            return RedirectToAction("Index", "Home");
        }
        //صفحه النقل 
        public IActionResult Transfer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Transfer(TransferVM transportVM)
        {
            _MidOp.Transfer(transportVM);
            return RedirectToAction("Index", "Home");
        }
        //صفحه الغاء النقل 
        public IActionResult TransferCancel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TransferCancel(TransferCancleVM deTransportVM)
        {
            _MidOp.TransferCancel(deTransportVM);
            return RedirectToAction("Index", "Home");
        }
        //صفحه تعطيل الوحده 
        public IActionResult DeactivateUnit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeactivateUnit(DeactivateUnitVM disableUnitVM)
        {
            _MidOp.DeactivateUnit(disableUnitVM);
            return RedirectToAction("Index", "Home");
        }
        //صفحه الغاء تعطيل الوحده 
        public IActionResult DeactivationCancel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeactivationCancel(DeactivationCancelVM deDisableUnitVM)
        {
            _MidOp.DeactivationCancel(deDisableUnitVM);
            return RedirectToAction("Index", "Home");
        }
    }
}
