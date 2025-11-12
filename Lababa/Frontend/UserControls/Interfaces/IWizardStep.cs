namespace Lababa.Frontend.UserControls.Interfaces
{
    public interface IWizardStep
    {
        bool ValidateStep();
        void SaveStepData();
    }
}
