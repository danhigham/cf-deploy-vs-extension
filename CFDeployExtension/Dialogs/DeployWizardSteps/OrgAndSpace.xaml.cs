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
    /// Interaction logic for OrgAndSpace.xaml
    /// </summary>
    public partial class OrgAndSpace : UserControl, IDeployWizardStep
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
                _context.OrgList = _context.CFClient.GetOrgs()
                    .OrderBy(o => o.Name, StringComparer.OrdinalIgnoreCase)
                    .ToDictionary(o => o.Guid, o => o.Name, StringComparer.OrdinalIgnoreCase);

                this.DataContext = _context;
            }
        }

        public OrgAndSpace()
        {
            InitializeComponent();
            _stepTitle = "App Location";
        }

        private void orgCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _context.SpaceList = _context.CFClient.GetSpaces(_context.Organization)
                .OrderBy(s => s.Name, StringComparer.OrdinalIgnoreCase)
                .ToDictionary(s => s.Guid, s => s.Name, StringComparer.OrdinalIgnoreCase);
        }

        private void spaceCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _context.ApplicationList = _context.CFClient.GetApps(_context.Space)
                .OrderBy(a => a.Name, StringComparer.OrdinalIgnoreCase)
                .ToDictionary(a => a.Guid, a => a.Name, StringComparer.OrdinalIgnoreCase);
        }
    }
}
