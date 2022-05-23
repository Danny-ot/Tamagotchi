using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
    [TestClass]
    public class ToyClass : IDisposable
    {
        public void Dispose()
        {
            Toy.ClearAll();
        }
        [TestMethod]
        public void PetClass_InstantiatesAnObjectOfPet_Pet()
        {
            // Arrange
            Toy tamagotchi = new Toy("Ella");

            // Assert
            Assert.AreEqual(typeof(Toy) , tamagotchi.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsTheTamagotchiName_String()
        {
            // Arrange
            string tamagot = "Lucy";
            Toy tamagotchi = new Toy(tamagot);

            // Act
            string tamagotchiValue = tamagotchi.Name;

            // Assert
            Assert.AreEqual(tamagot , tamagotchiValue);
        }

        [TestMethod]
        public void GetFood_ReturnsTheAmountOfFoodTamagotchiHas_Int()
        {
            // Arrange
            string tamagot = "Lucy";
            Toy tamagotchi = new Toy(tamagot);

            // Act
            int tamagotchiFood = tamagotchi.FoodAmount;

            // Assert
            Assert.AreEqual(10 , tamagotchiFood);
        }

        [TestMethod]
        public void GetHappiness_ReturnsTheAmountOfHappinessTamagotchiHas_Int()
        {
            // Arrange
            string tamagot = "Lucy";
            Toy tamagotchi = new Toy(tamagot);

            // Act
            int tamagotchiHappiness = tamagotchi.HappinessAmount;

            // Assert
            Assert.AreEqual(10 , tamagotchiHappiness);
        }

        [TestMethod]
        public void GetRest_ReturnsTheAmountOfRestTamagotchiHas_Int()
        {
            // Arrange
            string tamagot = "Lucy";
            Toy tamagotchi = new Toy(tamagot);

            // Act
            int tamagotchiRest = tamagotchi.RestAmount;

            // Assert
            Assert.AreEqual(10 , tamagotchiRest);
        }

        [TestMethod]
        public void FeedTamagotchi_IncreasesTheAmountOfTamagotchiFood_Int()
        {
            // Arrange
            string tamagot = "Lucy";
            Toy tamagotchi = new Toy(tamagot);

            // Act
            tamagotchi.FeedTamagotchi();
            int tamagotchiFood = tamagotchi.FoodAmount;

            // Assert
            Assert.AreEqual(10 , tamagotchiFood);
        }

        [TestMethod]
        public void PlayWithTamagotchi_IncreasesTheAmountOfTamagotchiHappiness_Int()
        {
            // Arrange
            string tamagot = "Lucy";
            Toy tamagotchi = new Toy(tamagot);

            // Act
            tamagotchi.PlayWithTamagotchi();
            int tamagotchiHappiness = tamagotchi.HappinessAmount;

            // Assert
            Assert.AreEqual(10 , tamagotchiHappiness);
        }

        [TestMethod]
        public void RestTamagotchi_IncreasesTheAmountOfTamagotchiRest_Int()
        {
            // Arrange
            string tamagot = "Lucy";
            Toy tamagotchi = new Toy(tamagot);

            // Act
            tamagotchi.RestTamagotchi();
            int tamagotchiRest = tamagotchi.RestAmount;

            // Assert
            Assert.AreEqual(10 , tamagotchiRest);
        }

        [TestMethod]
        public void DecreaseProperties_DecreasesThePropertiesOfTheTamagotchi_Int()
        {
            // Arrange
            string tamagot = "Lucy";
            string tamagot2 = "Kily";
            Toy tamagotchi = new Toy(tamagot);
            Toy tamagotchi2 = new Toy(tamagot2);

            // Act
            Toy.DecreaseProperties();
            int tamagotchiRest = tamagotchi.RestAmount;

            // Assert
            Assert.AreEqual(9 , tamagotchiRest);
        }

        [TestMethod]
        public void IsALive_ReturnsIfTheTamagotchiIsDeadOrAlive_Boolean()
        {
            // Arrange
            string tamagot = "Lucy";
            Toy tamagotchi = new Toy(tamagot);

            // Act
            tamagotchi.FoodAmount = 0;
            bool tamagotLive = tamagotchi.IsAlive();

            // Assert
            Assert.AreEqual(false , tamagotLive);
        }
    }
}