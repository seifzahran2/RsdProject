using RsdProject.Models.ViewModel;
using TestRSD.Models.ViewModels;

namespace TestRSD.Services.IServices
{
    public interface IDrugsOperationsServices
    {
        void DrugSell(DrugSellVM medicineSallVM);
        void DrugsReSall(DrugSellVM medicineReSallVM);
        void DrugAccept(AcceptVM acceptanceVM);
        void Return(ReturnVM el_ReturnVM);
        void Transfer(TransferVM transportVM);
        void TransferCancel(TransferCancleVM deTransportVM);
        void DeactivateUnit(DeactivateUnitVM disableUnitVM);
        void DeactivationCancel(DeactivationCancelVM deDisableUnitVM);
    }
}
