using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveltrekker.Model;

namespace Traveltrekker.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        #region Properties
        private ObservableCollection<TravelPlanModel> packages;

        public ObservableCollection<TravelPlanModel> Packages
        {
            get { return packages; }
            set { packages = value; OnPropertyChanged(nameof(Packages)); }
        }

        #endregion
        #region Constructor
        public MainPageViewModel()
        {
            Initialize();
        }


        #endregion

        #region Functions
        private void Initialize()
        {
            Packages = new ObservableCollection<TravelPlanModel>
            {
                new TravelPlanModel {Image ="langkawi.jpeg", NoOfDays="3N/4D", 
                    Title="Weekend Escape to Langkawi", 
                    Description="3N Langkawi"},
                new TravelPlanModel {Image ="malaysia.jpeg", NoOfDays="6N/7D"
                ,
                    Title="Dazzling Malaysia and Singapore Trip",
                    Description="2N Kuala Lumpur •4N Singapore"},
                new TravelPlanModel {Image ="singapore.jpeg", NoOfDays="7N/8D"
                ,
                    Title="Magical Kuala Lumpur & Singapore Vacay",
                    Description="4N Kuala Lumpur •3N Singapore"},
                new TravelPlanModel {Image ="kualalumpur.jpeg", NoOfDays="5N/6D"
                ,
                    Title="Affordable Kuala Lumpur Holiday",
                    Description="5N Kuala Lumpur"},
                new TravelPlanModel {Image ="kualalumpurlux.jpeg", NoOfDays="5N/6D"
                ,
                    Title="Luxurious Kuala Lumpur Holiday",
                    Description="5N Kuala Lumpur"},
                new TravelPlanModel {Image ="malfun.jpeg", NoOfDays="6N/7D"
                ,
                    Title="Family Fun Fiesta in Malaysia",
                    Description="3N Kuala Lumpur •2N Genting •1N Kuala Lumpur"},
            };
        }
        #endregion

    }
}
