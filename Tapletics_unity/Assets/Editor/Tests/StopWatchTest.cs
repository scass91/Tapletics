using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class StopWatchTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void StopWatchTestSimplePasses()
        {
            // Arrange
            StopWatch stopWatch = new StopWatch();
            // Act

            // Assert
            Console.WriteLine("Hello world");
            Console.ReadLine();
            Assert.AreEqual(stopWatch.milliseconds, "00");
        }
    }
}
