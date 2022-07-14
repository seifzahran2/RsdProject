using RsdProject.Models.ViewModel;
using TestRSD.Models.ViewModels;

namespace TestRSD.Services.IServices
{
    public interface IDrugsOperationsServices
    {
        void DrugSell(medicineSallVM medicineSallVM);
        void DrugAccept(AcceptVM acceptanceVM);
    }
}
