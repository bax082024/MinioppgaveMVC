using System;
using System.Collections.Generic;
using Vegetables.Views;
using Vegetables.Models;
using System.ComponentModel.DataAnnotations;

namespace Vegetables.Controllers
{
  public class Controller
  {
    private List<Vegetable> _vegetableList;
    private View _view;

    public Controller(View view)
    {
      _vegetableList = new List<Vegetable>();
      _view = view;
    }

    public void Run()
    {
      bool isRunning = true;

      while (isRunning)
      {
        _view.ShowMenu();
        var input = Console.ReadLine();

        switch (input)
        {
          case "1":
            ViewVegetables();
            break;
          case"2":
            AddVegetable();
            break;
          case"3":
            UpdateVegetable();
            break;
          case"4":
            DeleteVegetable();
            break;
          case"5":
            isRunning = false;
            Console.WriteLine("Exiting.");
            break;
          default:
            Console.WriteLine("Invalid choice, try again.");
            break;
        }
      }
    }

    private void ViewVegetables()
    {
      if (_vegetableList.Count == 0)
      {
        _view.Display("No vegetables to display");
    
      }
      else
      {
        foreach (var vegetable in _vegetableList)
        {
          _view.Display(vegetable.GetInfo());
        }
      }
    }


    private void AddVegetable()
    {
      Console.WriteLine("Enter vegetable name:");
    string? name = Console.ReadLine();

    Console.WriteLine("Enter vegetable price:");
    string? price = Console.ReadLine();

    _vegetableList.Add(new Vegetable { Name = name, Price = price });
    _view.Display("Vegetable added successfully!");
    }

    public void UpdateVegetable()
    {
      Console.WriteLine("Enter vegetable name you want to update");
      string? name = Console.ReadLine();

      var vegetable = _vegetableList.Find(v => v.Name?.Equals(name, StringComparison.OrdinalIgnoreCase) == true);

      if (vegetable != null)
      {
        Console.WriteLine("Enter new price");
        vegetable.Price = Console.ReadLine();
        _view.Display("Vegetable updated successfully");
      }
      else
      {
        _view.Display("Vegetable not found");
      }
    }

    private void DeleteVegetable()
    {
      Console.WriteLine("Enter vegetable you want to delete:");
      string? name = Console.ReadLine();

      var vegetable = _vegetableList.Find(v => v.Name?.Equals(name, StringComparison.OrdinalIgnoreCase) == true);

      if (vegetable != null)
      {
          _vegetableList.Remove(vegetable);
          _view.Display("Vegetable deleted successfully.");
      }
      else
      {
          _view.Display("Vegetable not found.");
      }
    }
  }

}