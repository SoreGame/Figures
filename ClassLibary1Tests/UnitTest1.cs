using Figures;
using NUnit.Framework;
using System;

namespace FiguresTests
{
    public class PolygonTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SqareBasePolygonFromArray() 
        {
            var pol = new Polygon(new double[] { 3, 5, 4 });
            Assert.AreEqual(6, pol.GetSquare());
        }

        [Test]
        public void SqareBasePolygonWithoutConstruct()
        {
            Assert.AreEqual(6, Polygon.GetSquare(3,4,5));
        }

        [Test]
        public void SqareBasePolygonFromVars()
        {
            var pol = new Polygon(3, 4, 5);
            Assert.AreEqual(6, pol.GetSquare());
        }

        [Test]
        public void SqareZeroPolygonWithoutConstruct()
        {
            Assert.AreEqual(-1, Polygon.GetSquare(0, 4, 5));
        }

        [Test]
        public void IsRectangleVarsPolygon()
        {
            var pol = new Polygon(3, 4, 5);
            Assert.AreEqual(true, pol.IsRectangular());
        }

        [Test]
        public void IsRectangleArraysPolygon()
        {
            var pol = new Polygon(new double[] {3, 4, 5});
            Assert.AreEqual(true, pol.IsRectangular());
        }

        [Test]
        public void IsValideArraysPolygon()
        {
            var pol = new Polygon(new double[] {3, 4, 5});
            Assert.AreEqual(true, pol.IsRectangular());
        }

        [Test]
        public void IsValideVarsPolygon()
        {
            var pol = new Polygon(3, 4, 5);
            Assert.AreEqual(true, pol.IsValide());
        }
    }

    public class ElipseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SquareBaseCirleWithoutConstruct()
        {
            Assert.AreEqual(25 * Math.PI, Elipsoid.GetSquare(5));
        }

        [Test]
        public void SquareBaseZerocirCleWithoutConstruct()
        {
            Assert.AreEqual(0 * Math.PI, Elipsoid.GetSquare(0));
        }

        [Test]
        public void SquareBaseCircle()
        {
            Assert.AreEqual(25 * Math.PI, new Elipsoid(5).GetSquare());
        }

        [Test]
        public void SquareBaseZeroCircle()
        {
            Assert.AreEqual(0, new Elipsoid(0).GetSquare());
        }


        [Test]
        public void SquareBaseElipseWithoutConstruct()
        {
            Assert.AreEqual(20 * Math.PI, Elipsoid.GetSquare(5, 4));
        }

        [Test]
        public void SquareBaseZeroElipseWithoutConstruct()
        {
            Assert.AreEqual(0 * Math.PI, Elipsoid.GetSquare(0, 5));
        }

        [Test]
        public void SquareBaseElipse()
        {
            Assert.AreEqual(20 * Math.PI, new Elipsoid(5, 4).GetSquare());
        }

        [Test]
        public void SquareBaseZeroElipse()
        {
            Assert.AreEqual(0, new Elipsoid(0, 0).GetSquare());
        }
    }
}