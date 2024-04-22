using Microsoft.VisualStudio.TestTools.UnitTesting;
using MB_DONNEES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MB_DONNEES.Tests
{
    [TestClass()]
    public class ConnexionTests
    {
        [TestMethod()]
        public void ConnectTest()
        {
            MySqlConnection BDD = Connexion.Connect();

            BDD.Open();
            Assert.AreEqual("Open", BDD.State.ToString());
        }
    }
}