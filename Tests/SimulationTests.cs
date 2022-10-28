using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class SimulationTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void SimulationTestsSimplePasses()
    {
        float prey = 50;
        float predator = 100;
        Assert.AreNotEqual(prey, predator);
    }

   
}
