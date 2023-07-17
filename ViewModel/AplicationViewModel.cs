using Dapper;
using GalaSoft.MvvmLight.Command;
using PlantsWpfApp.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System;

namespace PlantsWpfApp.ViewModel
{
    public class AplicationViewModel : INotifyPropertyChanged
    {
        private RelayCommand searchCommand;
        private string nameForSearch;
        private ObservableCollection<Plant> Plants { get; set; }
        public ObservableCollection<PlantViewModel> ShowItems { get; set; }

        public string NameForSearch
        {
            get { return nameForSearch; }
            set { nameForSearch = value; OnPropertyChanged("NameForSearch"); }
        }

        public RelayCommand SearchCommand
        {
            get
            {
                if (searchCommand == null) searchCommand = new RelayCommand(SearchPlant);
                return searchCommand;
            }
        }

        private void SearchPlant()
        {
            ShowItems.Clear();
            var filtered = Plants.Where(x => string.IsNullOrEmpty(NameForSearch) ||
            (x.PopName != null && x.PopName.Contains(NameForSearch)) ||
            (x.ScienceName != null && x.ScienceName.Contains(NameForSearch)) ||
            (x.Description != null && x.Description.Contains(NameForSearch)));
            ShowItems.Clear();
            foreach (var item in filtered)
            {
                ShowItems.Add(new PlantViewModel(item));
            }
        }
        public AplicationViewModel()
        {
            Plants = new ObservableCollection<Plant>();
            ShowItems = new ObservableCollection<PlantViewModel>();
            using (SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Plants_db;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                connection.Open();
                var temp = connection.Query<Plant>("SELECT * FROM [Plants]");
                foreach (Plant item in temp)
                {
                    Plants.Add(item);
                    ShowItems.Add(new PlantViewModel(item));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
