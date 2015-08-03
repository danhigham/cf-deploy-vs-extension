using Pivotal.CFDeployExtension.Dialogs.DeployWizardSteps;
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
using System.Windows.Shapes;

namespace Pivotal.CFDeployExtension.Dialogs
{
    public class NextStepEventArgs : RoutedEventArgs
    {
        public DeployContext Context { get; set; }
        public NextStepEventArgs(RoutedEvent routedEvent, object source, DeployContext context) : base(routedEvent, source)
        {
            this.Context = context;
        }
    }

    /// <summary>
    /// Interaction logic for DeployDialog.xaml
    /// </summary>
    public partial class DeployDialog : Window
    {
        public List<IDeployWizardStep> Steps;
        private int _currentIndex = -1;
        private DeployContext _context;

        public event RoutedEventHandler NextStep
        {
            add { AddHandler(NextStepEvent, value); }
            remove { RemoveHandler(NextStepEvent, value); }
        }

        public static readonly RoutedEvent NextStepEvent =
        EventManager.RegisterRoutedEvent(
            "NextStep",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(IDeployWizardStep)
        );

        public static readonly DependencyProperty WizardTitleProperty =
          DependencyProperty.Register("WizardTitle", typeof(string), typeof(DeployDialog), new UIPropertyMetadata(string.Empty));

        public string WizardTitle
        {
            get { return (string)this.GetValue(WizardTitleProperty); }
            set { this.SetValue(WizardTitleProperty, value); }
        }

        public static readonly DependencyProperty WizardContentProperty =
          DependencyProperty.Register("WizardContent", typeof(Control), typeof(DeployDialog), new UIPropertyMetadata(null));

        public Control WizardContent
        {
            get { return (Control)this.GetValue(WizardContentProperty); }
            set { this.SetValue(WizardContentProperty, value); }
        }

        public DeployDialog()
        {
            this.Steps = new List<IDeployWizardStep>() { new Credentials(), new OrgAndSpace(), new AppDetails() };
            this._context = new DeployContext() { Endpoint = "api.run.pivotal.io" };

            InitializeComponent();            
        }

        public override void OnApplyTemplate()
        {
            this.next();
            base.OnApplyTemplate();

            this.NextStep += DeployDialog_NextStep;
        }

        private void DeployDialog_NextStep(object sender, RoutedEventArgs e)
        {
            NextStepEventArgs args = (NextStepEventArgs)e;
            _context = args.Context;
            next();
            e.Handled = true;
        }

        private void next()
        {
            if (_currentIndex < (this.Steps.Count - 1))
            {
                _currentIndex++;
                IDeployWizardStep step = this.Steps[_currentIndex];
                step.Context = _context;
                
                this.WizardContent = (UserControl)this.Steps[_currentIndex];
                this.WizardTitle = step.StepTitle;
            }
        }
    }
}
