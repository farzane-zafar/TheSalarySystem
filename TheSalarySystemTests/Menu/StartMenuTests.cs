﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheSalarySystem.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSalarySystem.Interfaces;
using TheSalarySystem.Models;

namespace TheSalarySystem.Menu.Tests
{
    [TestClass()]
    public class StartMenuTests
    {
        
        [TestMethod()]
        [DataRow("samwon", "123abc", "samwon")]
        [DataRow("emmLind", "123abc", null)]
        [DataRow(null, "123abc", null)]
        [DataRow("samwon", null, null)]

        public void LoginTest(string userName, string passWord, string expected)
        {
            var actual = StartMenu.Login(userName, passWord);
            Assert.AreEqual(expected, actual);

        }
    }
}