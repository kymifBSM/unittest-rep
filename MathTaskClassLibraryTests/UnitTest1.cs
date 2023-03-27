using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            int a = 3;
            int b = 5;
            int expected = 15;

            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CylinderVolume_3and5andPI_235_61944901923448returned()
        {
            double a = 3.0;
            double b = 5.0;
            double expected = 235.61944901923448;
            

            Geometry c = new Geometry();
            double actual = c.CylinderVolume(a, b);

            Assert.AreEqual(expected, actual);
        }

    }
}