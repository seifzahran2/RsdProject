using RsdProject.Models;
using RsdProject.Models.ViewModel;
using TestRSD.Data;
using TestRSD.Models.ViewModels;
using TestRSD.Services.IServices;

namespace TestRSD.Services.Services
{

    public class DrugsOperationsServices : IDrugsOperationsServices
    {
        private ApplicationDbContext _App;
        public DrugsOperationsServices(ApplicationDbContext App)
        {
            _App = App;

        }

        public void DeactivateUnit(DeactivateUnitVM disableUnitVM)
        {
            var DeactivateUnit = new DeactivateUnit()
            {
                TReson = disableUnitVM.TReson,
                Explain = disableUnitVM.Explain,
                Date = disableUnitVM.Date,
                Attach = disableUnitVM.Attach,
                Datamatrex = disableUnitVM.Datamatrex,
                NumBand = disableUnitVM.NumBand,
                NumTaslsl = disableUnitVM.NumTaslsl,
                NumDofaa = disableUnitVM.NumDofaa,


            };
            _App.Add(DeactivateUnit);
            _App.SaveChanges();
        }

        public void DeactivationCancel(DeactivationCancelVM deDisableUnitVM)
        {
            var DeactivationCancel = new DeactivationCancel()
            {

                Date = deDisableUnitVM.Date,
                Attach = deDisableUnitVM.Attach,
                Datamatrex = deDisableUnitVM.Datamatrex,
                NumBand = deDisableUnitVM.NumBand,
                NumTaslsl = deDisableUnitVM.NumTaslsl,
                NumDofaa = deDisableUnitVM.NumDofaa,


            };
            _App.Add(DeactivationCancel);
            _App.SaveChanges();
        }

        public void DrugAccept(AcceptVM acceptanceVM)
        {
            var acceptDrug = new Accept()
            {

                Date = acceptanceVM.Date,
                Attach = acceptanceVM.Attach,
                Datamatrex = acceptanceVM.Datamatrex,
                NumBand = acceptanceVM.NumBand,
                NumTaslsl = acceptanceVM.NumTaslsl,
                NumDofaa = acceptanceVM.NumDofaa,
            };
            _App.Add(acceptDrug);
            _App.SaveChanges();
        }

        public void DrugSell(DrugSellVM medicineSellVM)
        {
            var medicineProps = new DrugSell()
            {
                TypeSall = medicineSellVM.TypeSall,
                WasfaNum = medicineSellVM.WasfaNum,
                Date = medicineSellVM.Date,
                Doctor = medicineSellVM.Doctor,
                Pationat = medicineSellVM.Pationat,
                Attach = medicineSellVM.Attach,
                Datamatrex = medicineSellVM.Datamatrex,
                NumBand = medicineSellVM.NumBand,
                NumTaslsl = medicineSellVM.NumTaslsl,
                NumDofaa = medicineSellVM.NumDofaa,
                Date2 = medicineSellVM.Date2,

            };
            _App.Add(medicineProps);
            _App.SaveChanges(); 
        }

        public void DrugsReSall(DrugSellVM medicineReSallVM)
        {
            var DrugsReSall = new DrugSellCancle()
            {
                TypeSall = medicineReSallVM.TypeSall,
                WasfaNum = medicineReSallVM.WasfaNum,
                Attach = medicineReSallVM.Attach,
                Datamatrex = medicineReSallVM.Datamatrex,
                NumBand = medicineReSallVM.NumBand,
                NumTaslsl = medicineReSallVM.NumTaslsl,
                NumDofaa = medicineReSallVM.NumDofaa,
                Date = medicineReSallVM.Date,

            };
            _App.Add(DrugsReSall);
            _App.SaveChanges();
        }

        public void Return(ReturnVM el_ReturnVM)
        {
            var Return = new Return()
            {
                GlobalNum = el_ReturnVM.GlobalNum,
                Date = el_ReturnVM.Date,
                Attach = el_ReturnVM.Attach,
                Datamatrex = el_ReturnVM.Datamatrex,
                NumBand = el_ReturnVM.NumBand,
                NumTaslsl = el_ReturnVM.NumTaslsl,
                NumDofaa = el_ReturnVM.NumDofaa,
            };
            _App.Add(Return);
            _App.SaveChanges();
        }

        public void Transfer(TransferVM transportVM)
        {
            var Transfer = new Transfer()
            {
                GlobalNum = transportVM.GlobalNum,
                Date = transportVM.Date,
                Attach = transportVM.Attach,
                Datamatrex = transportVM.Datamatrex,
                NumBand = transportVM.NumBand,
                NumTaslsl = transportVM.NumTaslsl,
                NumDofaa = transportVM.NumDofaa,


            };
            _App.Add(Transfer);
            _App.SaveChanges();
        }

        public void TransferCancel(TransferCancleVM deTransportVM)
        {
            var TransferCancel = new TransferCancle()
            {

                Date = deTransportVM.Date,
                Attach = deTransportVM.Attach,
                Datamatrex = deTransportVM.Datamatrex,
                NumBand = deTransportVM.NumBand,
                NumTaslsl = deTransportVM.NumTaslsl,
                NumDofaa = deTransportVM.NumDofaa,


            };
            _App.Add(TransferCancel);
            _App.SaveChanges();
        }
    }
}
