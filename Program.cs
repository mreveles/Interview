using System;



namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalcoins = 0;
            Console.WriteLine("What number do you want to go to?");
            int number = Convert.ToInt32(Console.ReadLine());
            int remainder = number;
            bool remainder1 = true;
            do
            {
                int a;
                if(remainder>=5){
                    a = 1;
                }else if(remainder<5 & remainder>=3) {
                    a = 2;
                }else if(remainder>=1){
                    a= 3;
                }else{a= 4;}

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
            Console.WriteLine("Minimum coins possible {0}", totalcoins);
        }
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
