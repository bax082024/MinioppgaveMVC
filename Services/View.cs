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
      Console.WriteLine("View Vegetables");
      Console.WriteLine("Add Vegetable");
      Console.WriteLine("Update Vegetable");
      Console.WriteLine("Delete Vegetable");
      
    }
  }

}