using System;



namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            //initiats var to store total coin amount
            int totalcoins = 0;
            int number = 0;
            //sets bool for do while statement
            bool remainder1 = true;

            //provides intructions and collect user input
            Console.WriteLine("What number do you want to go to?");
            number = Convert.ToInt32(Console.ReadLine());
            
            int remainder = number;

            do
            {
                //sets a variable for switch statement
                int a;

                //assigns value to switch var
                if(remainder>=5){
                    a = 1;
                }else if(remainder<5 & remainder>=3) {
                    a = 2;
                }else if(remainder>=1){
                    a= 3;
                }else{a= 4;}

                //performs method based on value of remainder
                switch(a)
                {
                    case 1:
                    totalcoins = totalcoins + LargeCoins(remainder);
                    remainder = remainder % 5;
                    if(remainder ==0){remainder1= false;}
                    break;
                    case 2:
                    totalcoins = totalcoins + MedCoins(remainder);
                    remainder = remainder % 3;
                    if(remainder ==0){remainder1= false;}
                    break;
                    case 3:
                    totalcoins = totalcoins+ SmallCoins(remainder);
                    remainder1 = false;
                    if(remainder ==0){remainder1= false;}
                    break;
                    case 4:
                    Console.WriteLine("You entered Zero");
                    remainder1 = false;
                    break;
                }
            }while(remainder1);
            Console.WriteLine("Minimum coins possible to reach {0} is {1}.", number,totalcoins);
        }
        //get the amount large coins needed
        static int LargeCoins(int remainder)
        {
            int coins = 0;
            while(remainder >= 5 )
            {
                coins = coins + 1;
                remainder -= 5 ;
            }
            //Console.WriteLine("Large Coins {0}", coins);
            return coins;
        }
        //gets the amount of medium coins needed
        static int MedCoins(int remainder)
        {
            int coins = 0;
            while(remainder >= 3 )
            {
                coins = coins + 1;
                remainder -= 3 ;
            }
            //Console.WriteLine("Med Coins {0}", coins);
            return coins;
        }
        //gets the amount of small coins needed.
        static int SmallCoins(int remainder)
        {
            int coins = 0;
            while(remainder>=1)
            {          
                coins = coins + 1;
                remainder -= 1 ;
            }
            //Console.WriteLine("Small Coins {0}", coins);
            return coins;
        }
    }
}
