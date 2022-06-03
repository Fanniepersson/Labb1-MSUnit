using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Tiger_2._0;
using System.Collections.Generic;
using System;

namespace ProjectTiger2._0.Test
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        [Description("Testar ifall man kan logga in med fel lösenord")]
        public void LoginMenu_Test_If_Customer_Can_Login_To_Bank_With_Wrong_Password_Return_False()
        {
            LoggingIntoBankSystem lg = new LoggingIntoBankSystem()
            {

            };

            //Act
            lg.LoginMenu();

            //Assert
            var expected = false;
            var actual = lg.validPassword;

            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        [Description("Testar ifall man kan lägga till ett konto för att sedan testa att radera det")]
        public void RemoveExistingBankAccount_Add_New_Account_And_Try_To_Remove_It_Return_True()
        {
            Customer cus = new Customer()
            {

            };

            cus.CreateNewBankAccount("TEST", 0, "USD");
            cus.RemoveExistingBankAccount(0);

            //Act
            var expected = false;
            var actual = cus.listOfBankAccounts.Exists(x => x.AccountName == "TEST");


            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void DepositMoneyToAccount()
        {
            Customer cus = new Customer()
            {

            };

            cus.CreateNewBankAccount("TEST2", 0, "SEK");

            cus.DepositMoneyToAccount(0, 100);

            var expected = 100;
            var actual = cus.listOfBankAccounts[0].AccountBalance;

            //Assert
            Assert.AreEqual(expected, actual);
           




        }















    }
}
