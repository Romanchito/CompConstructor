using CompConstructor.ViewModels;
using System.Windows.Controls;

namespace CompConstructor.Views
{
    /// <summary>
    /// Interaction logic for CaseList.xaml
    /// </summary>
    public partial class CaseList : Page
    {
        public CaseList()
        {
            InitializeComponent();
            DataContext = new CaseListViewModel();
        }
    }
}
