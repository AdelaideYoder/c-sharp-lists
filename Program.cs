using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //n Main method, create a list of value tuples that will hold individual transactions for a hardware business. Each tuple will store the product, the total amount of the transaction, and the quantity of the product.
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>(){
            //Add 5, or more, transactions to the list.
            ("Saw", 9.00, 10),
            ("Hammer", 5.55, 25),
            ("Nails", 2.00, 100),
            ("Work Gloves", 4.24, 20),
            ("Screw Driver", 3.00, 16)
        };

            int totalItemsSold = 0;
            double netRevenue = 0;
            //Iterate over the list of tuples and calculate how many total products you sold today, and what your total revenue was.
            foreach ((string product, double amount, int quantity) t in transactions)
            {
                // Logic goes here to look up quantity and amount in each transaction
                totalItemsSold += t.quantity;
                netRevenue += t.quantity * t.amount;
            }
            System.Console.WriteLine($"There were {totalItemsSold} products sold for a total profit of ${netRevenue}");
        }
    }
}