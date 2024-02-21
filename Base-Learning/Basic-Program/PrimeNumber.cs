namespace Base_Learning.Basic_Program
{
    public class PrimeNumber
    {
        public bool PrimeCheck(int num)
        {
            if(num < 2)
            {
                return false;
            }

            for(int i = 2; i<= Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
