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

        public void DrugSell(medicineSallVM medicineSellVM)
        {
            var medicineProps = new medicineSall()
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
    }
}
