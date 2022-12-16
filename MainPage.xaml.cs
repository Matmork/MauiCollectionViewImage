namespace MauiCollectionViewImage;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        List<ListGroup> groups = new List<ListGroup>();
        for (int i = 0; i < 5; i++)
        {
            var group = new ListGroup { Title = $"Group{i}" };
            for (int j = 0; j < 10; j++)
            {
                group.Add(new Item
                {
                    Name = j % 2 == 0 ? "True" : "False",
                    ImageUrl = j % 2 == 0 ? $"https://api.lorem.space/image/burger?rnd={i}{j}" : null,
                });
            }

            groups.Add(group);
        }

        ItemCollectionView.ItemsSource = groups;
    }
}

public class ListGroup : List<Item>
{
    public string Title { get; set; }
}

public class Item
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
}