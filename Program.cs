using Vegetables.Controllers;
using Vegetables.Views;

namespace MiniOppgaveMVC;

class Program
{
    static void Main(string[] args)
    {
        var view = new View();
        var controller = new Controller(view);
        controller.Run();
    }
}
