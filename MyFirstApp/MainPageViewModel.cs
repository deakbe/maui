using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyFirstApp
{
    public partial class MainPageViewModel : INotifyPropertyChanged
    {
        private double _annualPrice;
        private double _monthlyPrice;
        private int _quantity;

        public event PropertyChangedEventHandler? PropertyChanged;

        public double AnnualPrice 
        {
            get { return _annualPrice; }
            set { _annualPrice = value; OnPropertyChanged(); }
        }

        public double MonthlyPrice
        {
            get { return _monthlyPrice; }
            set { _monthlyPrice = value; OnPropertyChanged(); }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; OnPropertyChanged();}
        }

        public MainPageViewModel() 
        {
            _annualPrice = 177900;
            _monthlyPrice = 177900 / 12;
            _quantity = 0;
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name)); 
    }
}
