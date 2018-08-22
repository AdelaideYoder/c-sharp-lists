using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

            (string product, double amount, int quantity) hammer = ("Hammer", 19.99, 25);
            (string product, double amount, int quantity) nails = ("Nails", 7.99, 100);
            (string product, double amount, int quantity) nailGun = ("Nail Gun", 189.99, 1);
            (string product, double amount, int quantity) bandaids = ("Bandaids", 6.72, 250);
            (string product, double amount, int quantity) staples = ("Staples", 3.98, 50);

            foreach ((string product, double amount, int quantity) t in transactions)
            {
                // Logic goes here to look up quantity and amount in each transaction
                t.quantity
            }

        }
    }
}
