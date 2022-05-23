using System.Collections.Generic;

namespace Tamagotchi.Models
{
    public class Toy
    {
        public string Name{get; set;}
        public int FoodAmount{get; set;}
        public int HappinessAmount{get; set;}
        public int RestAmount{get; set;}
        public int Id{get;}

        private static List<Toy> _tamagotchis = new List<Toy>{};
        public Toy(string name)
        {
            Name = name;
            FoodAmount = 10;
            HappinessAmount = 10;
            RestAmount = 10;
            _tamagotchis.Add(this);
            Id = _tamagotchis.Count;
        }

        public void FeedTamagotchi()
        {
            DecreaseProperties();
            FoodAmount ++;
        }

         public void PlayWithTamagotchi()
        {
            DecreaseProperties();
            HappinessAmount ++;
        }

         public void RestTamagotchi()
        {
            DecreaseProperties();
            RestAmount ++;
        }
        
        public static List<Toy> GetAllTamagotchis()
        {
            return _tamagotchis;
        }

        public static void ClearAll()
        {
            _tamagotchis.Clear();
        }

        public  static void DecreaseProperties()
        {
            foreach(Toy tamagotchi in _tamagotchis)
            {
                tamagotchi.FoodAmount --;
                tamagotchi.HappinessAmount --;
                tamagotchi.RestAmount --;
            }
        }

        public bool IsAlive()
        {
            if(FoodAmount <= 0 || HappinessAmount <= 0 || RestAmount <= 0)
            {
                return false;
            }
            return true;
        }

        public static Toy GetToy(int id)
        {
            return _tamagotchis[id - 1];
        }
    }
}