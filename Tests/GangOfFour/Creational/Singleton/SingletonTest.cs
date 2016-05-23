﻿namespace DesignPatterns.Tests.GangOfFour.Creational.Singleton
{
    using DesignPatterns.GangOfFour.Creational.Singleton;

    using NUnit.Framework;

    [TestFixture]
    public class SingletonTest
    {
        [Test]
        public void TestOnlyOneInstanceIsCreated()
        {
            var instance1 = Singleton.Instance;
            var instance2 = Singleton.Instance;

            Assert.That(instance1, Is.EqualTo(instance2));
        }
    }
}