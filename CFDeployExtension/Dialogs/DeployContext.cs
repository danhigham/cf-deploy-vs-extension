using System.Collections.Generic;
using System.ComponentModel;

namespace Pivotal.CFDeployExtension.Dialogs
{
    public class DeployContext: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }

        }

        private Dictionary<string, string> _spaces;
        private Dictionary<string, string> _applications;

        public Mono.CFoundry.Client CFClient { get; set; }

        public string Endpoint { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Dictionary<string, string> OrgList { get; set; }
        public Dictionary<string, string> SpaceList
        {
            get
            {
                return _spaces;
            }
            set
            {
                _spaces = value;
                OnPropertyChanged("SpaceList");
            }
        }

        public Dictionary<string, string> ApplicationList
        {
            get
            {
                return _applications;
            }
            set
            {
                _applications = value;
                OnPropertyChanged("ApplicationList");
            }
        }

        public string Organization { get; set; }
        public string Space { get; set; }
        public string Application { get; set; }

    }
}
