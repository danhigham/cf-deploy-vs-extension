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
    /// Interaction logic for Credentials.xaml
    /// </summary>
    public partial class Credentials : UserControl, IDeployWizardStep
    {
        private string _stepTitle;
        private DeployContext _context;

        public string StepTitle { get { return _stepTitle; } }
        public DeployContext Context {
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

        public Credentials()
        {
            InitializeComponent();
            _stepTitle = "Credentials";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Check credentials against CF
            _context.Password = cfPassword.Password;
            if (beginCFSession(_context))
            {
                RaiseEvent(new NextStepEventArgs(DeployDialog.NextStepEvent, sender, _context));
            } else
            {
                throw (new NotImplementedException());
            }
        }

        private bool beginCFSession(DeployContext context)
        {
            context.CFClient = new Mono.CFoundry.Client(context.Endpoint, true);
            return context.CFClient.Login(context.Username, context.Password);
        }
    }
}
