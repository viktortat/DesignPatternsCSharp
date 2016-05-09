﻿namespace DesignPatterns.Tests.Creational.Builder
{
    using DesignPatterns.Creational.Builder;

    using NUnit.Framework;

    [TestFixture]
    class CarBuilderDirectorTest
    {
        [Test]
        public void TestBuildCar()
        {
            var carBuilderDirector = new CarBuilderDirector(new CarBuilder());
            var car = carBuilderDirector.BuildCar();

            Assert.That(car.Color, Is.EqualTo("Blue"));
            Assert.That(car.EngineCapacity, Is.EqualTo(3000));
            Assert.That(car.Name, Is.EqualTo("Audi A8"));
            Assert.That(car.NumberOfDoors, Is.EqualTo(5));
            Assert.That(car.NumberOfSeats, Is.EqualTo(5));
        }       
    }
}
