namespace MathUtilityLibrary
{
    public class MathUtility
    {
        public int Sum(int x, int y)
        {
          return  x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Divide(int x, int y)
        {
            if (y == 0) throw new DivideByZeroException(); 

            return x / y;
        }

    }
}
