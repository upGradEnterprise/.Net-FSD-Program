

namespace Console43
{
    // Step1: Abstract Product Interfaces
    public interface IButton { void Render(); }
    public interface ICheckbox { void Render(); }


    //Step 2: Concrete Products

    // Concrete Products for Windows OS
    public class WinButton : IButton { public void Render() => Console.WriteLine("Windows Button");  }
    public class WinCheckbox : ICheckbox { public void Render() => Console.WriteLine("Windows CheckBox"); }

    // Concrete Products for Mac OS
    public class MacButton : IButton { public void Render() => Console.WriteLine("Mac Button"); }
    public class MacCheckbox : ICheckbox { public void Render() => Console.WriteLine("Mac CheckBox"); }


    // Step 3: Abstract Factory Interface
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }

    // Step 4: Concrete Factories
    public class WinFactory : IGUIFactory
    {
        public IButton CreateButton() => new WinButton();
        public ICheckbox CreateCheckbox() => new WinCheckbox();
    }

    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }


    // Step 5: Client Code
    public class Application
    {
        private readonly IButton _button;
        private readonly ICheckbox _checkbox;

        public Application(IGUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();
        }

        public void RenderUI()
        {
            _button.Render();
            _checkbox.Render();
        }
    }

    // Step 6: Usage
    public class Program
    {
        static void Main(string[] args)
        {
            // Example: Choose factory based on OS
            IGUIFactory factory;

            string osType = "Mac"; // Could come from config or runtime detection

            if (osType == "Windows")
                factory = new WinFactory();
            else
                factory = new MacFactory();

            var app = new Application(factory);
            app.RenderUI();

            Console.ReadLine();
        }
    }


}