using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivotal.CFDeployExtension.Dialogs
{
    public interface IDeployWizardStep
    {
        string StepTitle { get; }
        DeployContext Context { get; set; }
        
    }
}
