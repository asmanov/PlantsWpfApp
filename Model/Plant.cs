using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlantsWpfApp.Model
{
    public class Plant : INotifyPropertyChanged
    {
        private string plantImage;

        public string PlantImage
        {
            get { return plantImage; }
            set { plantImage = value; }
        }

        private string plantLocation;

        public string PlantLocation
        {
            get { return plantLocation; }
            set { plantLocation = value; OnPropertyChanged("PlantLocation"); }
        }

        private string bedProp;

        public string BedProp
        {
            get { return bedProp; }
            set { bedProp = value; }
        }

        private string goodProp;

        public string GoodProp
        {
            get { return goodProp; }
            set { goodProp = value; OnPropertyChanged("GoodProp") }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged("Description") }
        }

        private string scienceName;

        public string ScienceName
        {
            get { return scienceName; }
            set { scienceName = value; OnPropertyChanged("ScienceName"); }
        }

        private string popName;

        public string PopName
        {
            get { return popName; }
            set { popName = value; OnPropertyChanged("PopName"); }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }
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
