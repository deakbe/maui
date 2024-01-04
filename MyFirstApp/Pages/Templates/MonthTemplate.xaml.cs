namespace MyFirstApp.Pages.Templates;

public partial class MonthTemplate : ContentView
{
    public static readonly BindableProperty MonthNameProperty = BindableProperty.Create(nameof(MonthName), typeof(string), typeof(MonthTemplate), string.Empty);
    public string MonthName
    {
        get => (string)GetValue(MonthNameProperty);
        set => SetValue(MonthNameProperty, value);
    }

    public static readonly BindableProperty SumProperty = BindableProperty.Create(nameof(Sum), typeof(int), typeof(MonthTemplate), 0);
    public int Sum
    {
        get => (int)GetValue(SumProperty);
        set => SetValue(SumProperty, value);
    }

    public MonthTemplate()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Sum++;
        if (Sum > 5)
        {
            ((Button)sender).Background = Colors.Red;
        }
        else
        {
            ((Button)sender).Background = Colors.Green;
        }
    }
}