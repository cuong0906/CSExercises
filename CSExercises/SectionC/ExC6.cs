using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE - get user input, call the function and return the discounted price
            Console.WriteLine("Order TV:");
            string inputTv = Console.ReadLine();
            int tv = Convert.ToInt32(inputTv);
            Console.WriteLine("Order DVD:");
            string inputDvd = Console.ReadLine();
            int dvd = Convert.ToInt32(inputDvd);
            Console.WriteLine("Order MP3:");
            string inputMp3 = Console.ReadLine();
            int mp3 = Convert.ToInt32(inputMp3);

           double total= CalculateTotalPrice(tv, dvd,mp3);
           Console.WriteLine("Total price is {0}",total);


        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            //YOUR CODE HERE
            double discount = tvQty * 900 + dvdQty * 500;
            double price = 0;
            if (discount >= 5000 && discount < 10000) 
            {
                price = (discount * 0.9) + (mp3Qty * 700);
                return price;
            }
            else if (discount >= 10000)
            {
                price = (discount * 0.85) + (mp3Qty * 700);
                return price;
            }
            else 
            {
                price = discount + mp3Qty * 700;
                return price;
            }



        }
    }
}