using System;

namespace Lababa.Frontend.Interfaces
{
    public interface IWizardStep
    {
        event EventHandler GoNext;
        event EventHandler GoBack;
    }
}
