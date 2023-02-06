using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RunLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RunLib.model.Tests
{
    [TestClass()]
    public class MedlemTests
    {
        private Medlem medlem;

        [TestInitialize]
        public void BeforeEachTest()
        {
            medlem = new Medlem();
        }



        /*
         * Navn
         */
        [TestMethod()]
        [DataRow("123")]
        [DataRow("EtLangtNavn")]
        public void MedlemNavnOkTest(String navn)
        {
            // arrange
            String expectedNavn = navn;

            // act
            medlem.Navn = navn;
            String actualNavn = medlem.Navn;

            // assert
            Assert.AreEqual(expectedNavn, actualNavn);
        }

        [TestMethod()]
        [DataRow("12")]
        public void MedlemNavnFailTest(String navn)
        {
            // arrange -- initialize

            // act

            // assert
            Assert.ThrowsException<ArgumentException>(() => medlem.Navn = navn); 
        }

        [TestMethod()]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("  ")]
        public void MedlemNavnFail2Test(String navn)
        {
            // arrange -- initialize

            // act

            // assert
            Assert.ThrowsException<ArgumentNullException>(() => medlem.Navn = navn);
        }



        /*
         * Mobil
         */
        [TestMethod()]
        [DataRow("12345678")]
        [DataRow("123456789012")]
        public void MedlemMobilOkTest(String mobil)
        {
            // arrange
            String expectedMobil = mobil;

            // act
            medlem.Mobil = mobil;
            String actualMobil = medlem.Mobil;

            // assert
            Assert.AreEqual(expectedMobil, actualMobil);
        }

        [TestMethod()]
        [DataRow("1234567")]
        [DataRow("1234567890123")]
        public void MedlemMobilFailTest(String mobil)
        {
            // arrange -- initialize

            // act

            // assert
            Assert.ThrowsException<ArgumentException>(() => medlem.Mobil = mobil);
        }

        [TestMethod()]
        [DataRow(null)]
        public void MedlemMobilFail2Test(String mobil)
        {
            // arrange -- initialize

            // act

            // assert
            Assert.ThrowsException<ArgumentNullException>(() => medlem.Mobil = mobil);
        }



        /*
         * LøbeHold
         */
        [TestMethod()]
        [DataRow("sort")]
        [DataRow("blå")]
        [DataRow("grøn")]
        [DataRow("gul")]
        [DataRow("orange")]
        [DataRow("rød")]
        public void MedlemLoebOkTest(String løb)
        {
            // arrange
            String expectedLøbeHold = løb;

            // act
            medlem.LøbeHold = løb;
            String actualLøbeHold = medlem.LøbeHold;

            // assert
            Assert.AreEqual(expectedLøbeHold, actualLøbeHold);
        }

        [TestMethod()]
        [DataRow("Sort")]
        [DataRow("lilla")]
        public void MedlemLoebFailTest(String løb)
        {
            // arrange -- initialize

            // act

            // assert
            Assert.ThrowsException<ArgumentException>(() => medlem.LøbeHold = løb);
        }

        [TestMethod()]
        [DataRow(null)]
        [DataRow("")]
        public void MedlemLoebFail2Test(String løb)
        {
            // arrange -- initialize

            // act

            // assert
            Assert.ThrowsException<ArgumentNullException>(() => medlem.LøbeHold = løb);
        }





        /*
         * Pris
         */
        [TestMethod()]
        [DataRow(50)]
        [DataRow(100)]
        public void MedlemPrisOkTest(double pris)
        {
            // arrange
            double expectedPris = pris;

            // act
            medlem.Pris = pris;
            double actualPris = medlem.Pris;

            // assert
            Assert.AreEqual(expectedPris, actualPris);
        }

        [TestMethod()]
        [DataRow(49.99)]
        [DataRow(0)]
        [DataRow(-60)]
        public void MedlemPrisFailTest(double pris)
        {
            // arrange -- initialize

            // act

            // assert
            Assert.ThrowsException<ArgumentException>(() => medlem.Pris = pris);
        }



        /*
         * Konstruktør
         */
        [TestMethod()]
        public void MedlemConstructorOkTest()
        {
            // arrange
            medlem = new Medlem("Peter",22, "22334455", "gul", 55);
            String expectednavn = "Peter";
            int expectedid = 22;
            String expectedmobil = "22334455";
            String expectedløbehold = "gul";
            double expectedpris = 55;


            // act
            String actualnavn = medlem.Navn;
            int actualid = medlem.MedlemsId;
            String actualmobil = medlem.Mobil;
            String actualløbehold = medlem.LøbeHold;
            double actualpris = medlem.Pris;

            // assert
            Assert.AreEqual(expectednavn, actualnavn);
            Assert.AreEqual(expectedid, actualid);
            Assert.AreEqual(expectedmobil, actualmobil);
            Assert.AreEqual(expectedløbehold, actualløbehold);
            Assert.AreEqual(expectedpris, actualpris);
        }

        [TestMethod()]
        public void MedlemConstructorFailTest()
        {
            // arrange
            // act
            // assert

            Assert.ThrowsException<ArgumentException>( ()=> medlem = new Medlem("12", 22, "22334455", "gul", 55));

        }



        }
    }