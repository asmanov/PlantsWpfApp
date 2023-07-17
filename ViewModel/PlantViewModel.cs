using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PlantsWpfApp;
using PlantsWpfApp.Model;

namespace PlantsWpfApp.ViewModel
{
    public class PlantViewModel : INotifyPropertyChanged
    {
        public Plant _plant;

        public PlantViewModel()
        {
        }

        public PlantViewModel(Plant plant)
        {
            _plant = plant;
            
        }

        public int Id 
        {
            get { return _plant.Id; } 
            set
            {
                if (_plant.Id != value)
                {
                    _plant.Id = value;
                    OnPropertyChanged("Id");
                }
            }
        }

        public string PopName
        {
            get { return _plant.PopName; }
            set
            {
                if (_plant.PopName != value)
                {
                    _plant.PopName = value;
                    OnPropertyChanged("PopName");
                }
            }
        }

        public string ScienceName
        {
            get { return _plant.ScienceName; }
            set
            {
                if (_plant.ScienceName != value)
                {
                    _plant.ScienceName = value;
                    OnPropertyChanged("ScienceName");
                }
            }
        }

        public string GoodProp
        {
            get { return _plant.GoodProp; }
            set
            {
                if (_plant.GoodProp != value)
                {
                    _plant.GoodProp = value;
                    OnPropertyChanged("GoodProp");
                }
            }
        }

        public string BedProp
        {
            get { return _plant.BedProp; }
            set
            {
                if (_plant.BedProp != value)
                {
                    _plant.BedProp = value;
                    OnPropertyChanged("BedProp");
                }
            }
        }

        public string Description
        {
            get { return _plant.Description; }
            set
            {
                if (_plant.Description != value)
                {
                    _plant.Description = value;
                    OnPropertyChanged("Description");
                }
            }
        }

        public string PlantLocation
        {
            get { return _plant.PlantLocation; }
            set
            {
                if (_plant.PlantLocation != value)
                {
                    _plant.PlantLocation = value;
                    OnPropertyChanged("PlantLocation");
                }
            }
        }

        public string PlantImage
        {
            get { return _plant.PlantImage; }
            set
            {
                if (_plant.PlantImage != value)
                {
                    _plant.PlantImage = value;
                    OnPropertyChanged("PlantImage");
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
