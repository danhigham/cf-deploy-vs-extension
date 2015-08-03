using Pivotal.CFDeployExtension.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pivotal.CFDeployExtension.Dialogs.DeployWizardSteps
{
    /// <summary>
    /// Interaction logic for AppDetails.xaml
    /// </summary>
    public partial class AppDetails : UserControl, IDeployWizardStep
    {
        private string _stepTitle;
        private DeployContext _context;

        public string StepTitle { get { return _stepTitle; } }
        public DeployContext Context
        {
            get
            {
                return _context;
            }
            set
            {
                _context = value;
                this.DataContext = _context;
            }
        }

        public AppDetails()
        {
            
            InitializeComponent();
            _stepTitle = "App Details";
        }

      
    }
}
