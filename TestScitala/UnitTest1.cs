using System.Security.Cryptography;
using Op123;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void Encrypt_Decrypt_Should_Return_Original_Plaintext()
        {
            // Arrange
            string plaintext = "Hello, World!";
            Scitala scitala = new Scitala(5);

            // Act
            string ciphertext = scitala.Encrypt(plaintext);
            string decryptedText = scitala.Decrypt(ciphertext);

            // Assert
            Assert.AreEqual(plaintext, decryptedText);
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void GetMessageLength_Should_Return_Length_Of_Plaintext()
        {
            // Arrange
            string plaintext = "Hello, World!";
            Scitala scitala = new Scitala(5);

            // Act
            scitala.Encrypt(plaintext);
            int messageLength = scitala.GetMessageLength();

            // Assert
            Assert.AreEqual(plaintext.Length, messageLength);
        }


    }
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void CheckUser_ReturnsTrue()
        {
            // Arrange
            bool expected = true;
            string textBoxLog = "user1";
            string textBoxPass = "123";
            string dbPath = "C:\\Users\\kizar\\DBBBB.db";
            DBManager DBmanager = new DBManager(dbPath);

            // Act
            bool actual = DBmanager.CheckUser(textBoxLog, textBoxPass);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void CheckUser_ReturnsFalse()
        {
            // Arrange
            bool expected = false;
            string textBoxLog = "user33";
            string textBoxPass = "228";
            string dbPath = "C:\\Users\\kizar\\DBBBB.db";
            DBManager DBmanager = new DBManager(dbPath);

            // Act
            bool actual = DBmanager.CheckUser(textBoxLog, textBoxPass);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}