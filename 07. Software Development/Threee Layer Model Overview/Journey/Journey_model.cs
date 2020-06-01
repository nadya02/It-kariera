using System;
using System.Collections.Generic;
using System.Text;

namespace Journey.Model
{
    class Journey_model
    {
        private double budget;
        private string season;
        public string Season
        {
            get { return season; }
            set { season = value; }
        }
        public double Budget
        {
            get { return budget; }
            set { budget = value; }
        }
        public Journey_model(double budget, string season)
        {
            this.budget = budget;
            this.season = season;
        }

        public string[] GetJourney()
        {
            string[] journey = new string[3];
            double spentMoney;
            if(budget <= 100)
            {
                journey[0] = "Bulgaria";
                if(season == "summer")
                {
                    spentMoney = budget * 0.3;
                    journey[1] = "Camp";
                    journey[2] = $"{spentMoney:f2}";
                }
                else if(season == "winter")
                {
                    spentMoney = budget * 0.7;
                    journey[1] = "Hotel";
                    journey[2] = $"{spentMoney:f2}";
                }
            }
            else if(budget <= 1000)
            {
                journey[0] = "Balkans";
                if (season == "summer")
                {
                    spentMoney = budget * 0.4;
                    journey[1] = "Camp";
                    journey[2] = $"{spentMoney:f2}";
                }
                else if (season == "winter")
                {
                    spentMoney = budget * 0.8;
                    journey[1] = "Hotel";
                    journey[2] = $"{spentMoney:f2}";
                }
            }
            else
            {
                journey[0] = "Europe";
                spentMoney = budget * 0.9;
                journey[1] = "Hotel";
                journey[2] = $"{spentMoney:f2}";
            }
            return journey;
        }
    }
}
