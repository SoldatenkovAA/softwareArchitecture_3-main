﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.SRP
{
    internal class MovieProfit
    {
        public Movie Movie {  get; }
        public double Budget { get; }
        public double BoxOffice { get; }
        public MovieProfit(Movie movie, double budget, double boxOffice)
        {
            Movie = movie;
            Budget = budget;
            BoxOffice = boxOffice;
        }

        public double getProfit()
        {
            return BoxOffice - Budget;
        }

        public void estimateBoxOffice()
        {
            double profit = getProfit();
            if (profit > 0)
            {
                Console.WriteLine(string.Format("Фильм {0} успешен с прибылью {1} рублей.", Movie.Title, profit));
            }
            else Console.WriteLine(string.Format("Фильм {0} провалился в прокате", Movie.Title));
        }
    }
}
