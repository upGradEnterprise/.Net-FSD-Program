namespace ConsoleApp39
{

    public delegate void MyEventHandler(object sender, EventArgs e);

    public class Button
    {
        public event MyEventHandler Click;

        public void PressButton()
        {
            Console.WriteLine("Button Pressed...!");
            Click.Invoke(this, EventArgs.Empty);
        }
    }

     
    class Program
    {

        public static void m1(object sender, EventArgs e)
        {
            Console.WriteLine("Logic to validate user id and password");

        }

        public static void m2(object sender, EventArgs e)
        {
            Console.WriteLine("send the notfication to user");

        }

        static void Main(string[] args)
        {
            Button b1 = new Button ();
            b1.Click += m1;
            b1.Click += m2;
            b1.PressButton ();


            Console.ReadLine();
        }
    }
}