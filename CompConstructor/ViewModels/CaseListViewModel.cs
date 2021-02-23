using CompConstructor.Helpers;
using CompConstructor.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CompConstructor.ViewModels
{
    public class CaseListViewModel : INotifyPropertyChanged
    {
        private Case selectedCase;
        public Case SelectedCase
        {
            get { return selectedCase; }
            set
            {
                selectedCase = value;
                OnPropertyChanged("SelectedCase");
            }
        }

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Case _case = new Case();
                      Cases.Insert(0, _case);
                      SelectedCase = _case;
                  }));
            }
        }

        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                    (removeCommand = new RelayCommand(obj =>
                    {
                        Case _case = obj as Case;
                        if (_case != null)
                        {
                            Cases.Remove(_case);
                        }
                    },
                    (obj) => Cases.Count > 0));
            }
        }

        public ObservableCollection<Case> Cases { get; set; }

        public CaseListViewModel()
        {
            Cases = new ObservableCollection<Case>()
            {
                new Case(){Cost = 3700, Format ="ATX", Height = 1100, Length = 530, Name = "Accord JX10" },
                new Case(){Cost = 1200, Format ="microATX", Height = 600, Length = 500, Name = "Asus blade" },
                new Case(){Cost = 3000, Format ="microATX", Height = 600, Length = 400, Name = "AeroCool S10V" },
                new Case(){Cost = 22000, Format ="ATX", Height = 1500, Length = 880, Name = "AeroCool Titan" }
            };
            SelectedCase = Cases.ElementAt(0);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
