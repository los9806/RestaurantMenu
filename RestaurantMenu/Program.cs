// See https://aka.ms/new-console-template for more information
public class MenuItem
{
    // fields
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public bool IsNew { get; set; }

    // constructor
    public MenuItem(string name, decimal price, string description, string category, bool isNew)
    {

        Name = name;
        Price = price;
        Description = description;
        Category = category;
        IsNew = isNew;

    }

    // method to display the menu item 
    public void DisplayItem() 
    {

        string newItemLabel = IsNew ? "(New)" : "";
        Console.WriteLine($"{Name} {newItemLabel}: {Description} - ${Price} ({Category})");

    }

}


public class Menu 
{ 
    // fields
    public List<MenuItem> MenuItems { get; set; }
    public DateTime LastUpdated { get; private set; }

    // constructor
    public Menu()
    {

        MenuItems = new List<MenuItem>
        {
            new MenuItem("Texas Cheese Fries", 9.99m, "a large serving of steak fries covered with cheddar cheese and bacon bits", "Appetizer", false),
            new MenuItem("Country Fried Steak", 14.79m, "Hand-breaded on Texas toast with country gravy.", "Main Course", false),
            new MenuItem("Molten Chocolate Cake", 9.59m, "Chocolate cake with a molten chocolate center, topped with vanilla ice cream in a chocolate shell with caramel drizzle.", "Dessert", false)
        };
        LastUpdated = DateTime.Now;
    }

    // method to add a new item 
    public void AddItem(MenuItem item) 
    {

        MenuItems.Add(item);
        UpdateLastUpdated();

    }

    // method to display the menu
    public void DisplayMenu() 
    {

        Console.WriteLine("Menu (Last Updated: " + LastUpdated.ToString("g") + ")");
        foreach (var item in MenuItems) 
        { 
            item.DisplayItem();
        }

    }

    // private method to update the last updated time 
    private void UpdateLastUpdated() 
    { 
        LastUpdated = DateTime.Now; 
    }

}

class Program 
{ 
    static void Main(string[] args) 
    { 
    
        Menu restaurantMenu = new Menu();

        // display the current menu
        restaurantMenu.DisplayMenu();

        // add a new item
        MenuItem newDish = new MenuItem("Four-Cheese Mac & Cheese With Honey Pepper Chicken Tenders", 14.99m, "A sweet and savory four-cheese penne mac & cheese topped with Applewood-smoked bacon and crispy chicken tenders tossed in honey pepper sauce. Served with a signature breadstick.", "Main Course", true);
        restaurantMenu.AddItem(newDish);

        // display updated menu
        Console.WriteLine("\nNew Item Added:");
        restaurantMenu.DisplayMenu();

        Console.ReadKey();
    
    }

}  
