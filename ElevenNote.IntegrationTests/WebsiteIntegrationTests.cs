using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using ElevenNote.Models;
using ElevenNote.Web.Controllers;
using ElevenNote.Web.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElevenNote.IntegrationTests
{
    [TestClass]
    public class WebsiteIntegrationTests
    {

        #region Utility

        /// <summary>
        /// Simply runs an annotations-based validator against the passed object.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool ObjectIsValid(object o)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            try
            {
                Validator.TryValidateObject(o, new ValidationContext(o), results);
                return results.Count == 0;
            }
            catch
            {
                // Simply continue.
            }

            return false;
        }

        #endregion

        [TestMethod]
        public void NoteCreateModelRequiresNonEmptyTitle()
        {
            // Arrange.
            var model = new NoteCreateViewModel
            {
                Content = "sample content",
                Title = ""
            };

            // Act.
            var isValid = ObjectIsValid(model);

            // Assert.
            Assert.AreEqual(isValid, false);
        }

        [TestMethod]
        public void UserRegistrationModelShouldFailValidationIfUsernameNotProvided()
        {
            // Arrange.
            var model = new RegisterViewModel
            {
                Email = "",
                Password = "Password",
                ConfirmPassword = "Password"
            };

            // Act.
            var isValid = ObjectIsValid(model);

            // Assert.
            Assert.AreEqual(isValid, false);
        }

        [TestMethod]
        public void NoteEditViewModelShouldRequireTitleAndContent()
        {
            //Arrange
            var model = new NoteEditViewModel
            {
                NoteId = 100,
                Title = null,
                Content = null,
                IsStarred = false
            };
            //Act
            var isValid = ObjectIsValid(model);

            //Assert
            Assert.AreEqual(isValid, false);
        }

        [TestMethod]
        public void UserLoginModelShouldFailValidationIfUsernameNotProvided()
        {
            // Arrange.
            var model = new LoginViewModel
            {
                Email = "",
                Password = "Password"
            };

            // Act.
            var isValid = ObjectIsValid(model);
            
            // Assert.
            Assert.AreEqual(isValid, false);
        }

        [TestMethod]
        public void AboutPageAccessible()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void HomePageAccessible()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void RegisterPageAccessible()
        {
            // Arrange
            var controller = new AccountController();

            // Act
            var result = controller.Register() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LoginPageAccessible()
        {
            // Arrange
            var controller = new AccountController();

            // Act
            var result = controller.Login(null) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageAccountPageNotAccessibleWhenNotLoggedIn()
        {

        }

    }
}
