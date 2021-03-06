﻿namespace Task55Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Task55;

    [TestClass]
    public class SolverTests
    {
        private const string LatinLowercase = "abcdefghijklmnopqrstuvwxyz";

        private const string LatinUppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private const string CyrillicLowercase = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        private const string CyrillicUppercase = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        private void ToUpperTest(string input)
        {
            //arrange
            var expectedResult = input.ToUpper();

            //act
            var result = Solver.ToUpper(input);

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ToUpperTestNonEmptyCyrillic()
        {
            this.ToUpperTest(LatinLowercase + LatinUppercase + CyrillicLowercase + CyrillicUppercase);
        }

        [TestMethod]
        public void ToUpperTestNonEmpty()
        {
            this.ToUpperTest(LatinLowercase + LatinUppercase);
        }

        [TestMethod]
        public void ToUpperTestEmpty()
        {
            this.ToUpperTest("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ToUpperTestNull()
        {
            Solver.ToUpper(null);
        }
    }
}
