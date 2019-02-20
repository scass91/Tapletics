using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class StopWatchText
    {
        // A Test behaves as an ordinary method
        [Test]
        public void StopWatchTestSimplePasses()
        {
            // Arrange
        
            // Act

            // Assert
            Assert.AreEqual(stopWatchText.milliseconds, "00");
        }
    }
}
