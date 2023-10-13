namespace zadanie13._10Badowski4c;

public partial class MainPage : ContentPage
{
    Grid grid = new Grid
    {
        RowDefinitions =
            {
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition()
            },
        ColumnDefinitions =
            {
                new ColumnDefinition(),
                new ColumnDefinition(),
                new ColumnDefinition()
            }
    };
    public void Sortuj(object sender, EventArgs e)
    {
        int[] tab;
        tab = new int[9];
        int i = 0;
        foreach (var view in grid.Children)
        {
            if (view is Label label)
            {
                tab[i] = Int32.Parse(label.Text);
                i++;
            }
        }
        Array.Sort(tab);
        i = 0;
        foreach (var view in grid.Children)
        {
            if (view is Label label)
            {
                label.Text = tab[i].ToString();
                i++;
            }
        }
    }

    public void GridAlignmentPage()
    {
        

        // Row 0
        grid.Add(new BoxView
        {
            Color = Colors.AliceBlue
        });
        grid.Add(new Label
        {
            Text = "",
            FontSize = 20,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        });

        grid.Add(new BoxView
        {
            Color = Colors.LightSkyBlue
        }, 1, 0);
        grid.Add(new Label
        {
            Text = "",
            FontSize = 20,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        }, 1, 0);

        grid.Add(new BoxView
        {
            Color = Colors.CadetBlue
        }, 2, 0);
        grid.Add(new Label
        {
            Text = "",
            FontSize = 20,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        }, 2, 0);

        // Row 1
        grid.Add(new BoxView
        {
            Color = Colors.CornflowerBlue
        }, 0, 1);
        grid.Add(new Label
        {
            Text = "",
            FontSize = 20,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        }, 0, 1);

        grid.Add(new BoxView
        {
            Color = Colors.DodgerBlue
        }, 1, 1);
        grid.Add(new Label
        {
            Text = "",
            FontSize = 20,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        }, 1, 1);

        grid.Add(new BoxView
        {
            Color = Colors.DarkSlateBlue
        }, 2, 1);
        grid.Add(new Label
        {
            Text = "",
            FontSize = 20,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        }, 2, 1);

        // Row 2
        grid.Add(new BoxView
        {
            Color = Colors.SteelBlue
        }, 0, 2);
        grid.Add(new Label
        {
            Text = "",
            FontSize = 20,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        }, 0, 2);

        grid.Add(new BoxView
        {
            Color = Colors.LightBlue
        }, 1, 2);
        grid.Add(new Label
        {
            Text = "",
            FontSize = 20,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        }, 1, 2);

        grid.Add(new BoxView
        {
            Color = Colors.BlueViolet
        }, 2, 2);
        grid.Add(new Label
        {
            Text = "",
            FontSize = 20,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        }, 2, 2);
        Button button1 = new Button
        {
            Text = "Sortuj liczby",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
        grid.SetRow(button1,  4);
        grid.SetColumn(button1, 1);
        grid.Add(button1);
        button1.Clicked+=Sortuj;

        Title = "Grid alignment demo";
        Content = grid;
    }

    public void Rand()
    {
        foreach (var view in grid.Children)
        {
            if (view is Label label)
            {
                Random rnd = new Random();
                int num = rnd.Next(1, 9);
                label.Text = num.ToString();
            }
        }
    }

    public MainPage()
    {
        InitializeComponent();
        GridAlignmentPage();
        Rand();
    }

}