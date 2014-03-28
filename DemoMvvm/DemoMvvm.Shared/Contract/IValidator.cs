namespace DemoMvvm.Shared.Contract
{
    using DemoMvvm.Shared.ViewModel;

    public interface IValidator
    {
        void RegisterPropertyChangeForValidation(ContactPageViewModel contactPageViewModel);
    }
}