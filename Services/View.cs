using System;

namespace Vegetables.Views
{
  public class View
  {
    public void Display(string content)
    {
      Console.WriteLine(content);
    }

    public void ShowMenu()
    {
      Console.WriteLine("Choose an option:");
      Console.WriteLine("1. View Vegetables");
      Console.WriteLine("2. Add Vegetable");
      Console.WriteLine("3. Update Vegetable");
      Console.WriteLine("4. Delete Vegetable");
      Console.WriteLine("5. Exit");
      
    }
  }

}