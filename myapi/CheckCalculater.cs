namespace myapi
{
    public class CheckCalculater
    {
        public int Plus(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Minus (int num1, int num2)
        {
            return num1 - num2;
        }
        public double Multiplied (int num1, int num2)
        {
            return num1 * num2;
        }
        public double Divided (int num1, int num2)
        {
            return num1 / num2;
        }
        
        
        public int Withdraw(int paid, int price){
            return paid - price;
        }

        public int[] WithdrawCash(int total)
        {
            int[] cash = new int[9];
            var change = total;
            if (change >= 1000)
            {
                cash[0] = change / 1000;
                change -= cash[0] * 1000;
            }
            if (change >= 500)
            {
                cash[1] = change / 500;
                change -= cash[1] * 500;
            }
            if (change >= 100)
            {
                cash[2] = change / 100;
                change -= cash[2] * 100;
            }
            if (change >= 50)
            {
                cash[3] = change / 50;
                change -= cash[3] * 50;
            }
            if (change >= 20)
            {
                cash[4] = change / 20;
                change -= cash[4] * 20;
            }
            if (change >= 10)
            {
                cash[5] = change / 10;
                change -= cash[5] * 10;
            }
            if (change >= 5)
            {
                cash[6] = change / 5;
                change -= cash[6] * 5;
            }
            if (change >= 2)
            {
                cash[7] = change / 2;
                change -= cash[7] * 2;
            }
            if (change >= 1)
            {
                cash[8] = change / 1;
                change -= cash[8] * 1;
            }
            return cash;
        }
    }
}