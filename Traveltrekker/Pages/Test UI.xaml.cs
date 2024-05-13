using System.Collections.ObjectModel;
using Traveltrekker.Model;

namespace Traveltrekker.Pages;

public partial class Test_UI : ContentPage
{
    public ObservableCollection<FairyTale> FairyTales { get; set; }
    public ObservableCollection<FairyTale> FairyTales2 { get; set; }
    public Test_UI()
    {
        InitializeComponent();
        InitializeTales();
        BindingContext = this;
    }

    private void InitializeTales()
    {
        FairyTales = new ObservableCollection<FairyTale>
        {
            new FairyTale(){ Name="Cindrella", ReadTime = new TimeSpan(0,30,0), Image="aj1.jpg"},
            new FairyTale(){ Name="Snow White", ReadTime = new TimeSpan(0,25,0), Image="aj2.jpg"},
            new FairyTale(){ Name="Rapunzel", ReadTime = new TimeSpan(0,20,0), Image="aj3.jpg"},
            new FairyTale(){ Name="Little Red Riding Hood", ReadTime = new TimeSpan(0,15,0), Image="aj4.jpg"},
            new FairyTale(){ Name="Beauty and the Beast", ReadTime = new TimeSpan(0,35,0), Image="aj5.jpg"}
        };

        FairyTales2 = new ObservableCollection<FairyTale>
        {
            new FairyTale(){ Name="Snow White", ReadTime = new TimeSpan(0,25,0), Image="aj2.jpg"},
            new FairyTale(){ Name="Rapunzel", ReadTime = new TimeSpan(0,20,0), Image="aj3.jpg"},
            new FairyTale(){ Name="Little Red Riding Hood", ReadTime = new TimeSpan(0,15,0), Image="aj4.jpg"},
            new FairyTale(){ Name="Beauty and the Beast", ReadTime = new TimeSpan(0,35,0), Image="aj5.jpg"},
            new FairyTale(){ Name="Cindrella", ReadTime = new TimeSpan(0,30,0), Image="aj1.jpg"}
        };
    }
}