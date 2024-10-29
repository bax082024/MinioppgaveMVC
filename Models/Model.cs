namespace Vegetables.Models
{
  public class Vegetable
  {
    public string? Name { get; set; }
    public string? Price { get; set; }

    public string GetInfo()
    {
      return $"Vegetable: {Name}, Price: {Price}";
    }

  }

}