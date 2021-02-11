using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;
using CS321_W2D2_StudentAPI.Controllers;
using CS321_W2D2_StudentAPI.Services;
using CS321_W2D2_StudentAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CS321_W2D2_StudentAPI.Tests
{
    public class StudentsControllerTests
    {
        [Fact]
        public void Post_ShouldReturnBadRequestWhenBirthDateIsInTheFuture()
        {
<<<<<<< HEAD
            Assert.Throws<ApplicationException>(() => TryPost(new Student
=======
            // Ensure that Post() returns BadRequest status code if
            // the given birthdate is in the future

            // act - call Post() with a student with a bad birthdate
            var result = TryPost(new Student
>>>>>>> parent of db1c480... update to netcoreapp3.1
            {
                FirstName = "John",
                LastName = "Doe",
                BirthDate = new DateTime(2999, 1, 1), // in the future
                Email = "test@test.com",
<<<<<<< HEAD
                Phone = "555-555-5555"
            }));
=======
                Phone = "555-555-5555"
            });

            // assert
            Assert.IsType<BadRequestObjectResult>(result);
>>>>>>> parent of db1c480... update to netcoreapp3.1
        }

        [Fact]
        public void Post_ShouldReturnBadRequestWhenBirthDateIsTooEarly()
        {
            Assert.Throws<ApplicationException>(() => TryPost(new Student
            {
                FirstName = "John",
                LastName = "Doe",
                BirthDate = new DateTime(1899, 1, 1), // too old
                Email = "test@test.com",
                Phone = "555-555-5555"
            }));
        }

        [Fact]
        public void Post_ShouldReturnBadRequestWhenEmailIsInvalid()
        {
            Assert.False(IsValid(new Student
            {
                FirstName = "John",
                LastName = "Doe",
                BirthDate = new DateTime(2020, 1, 1),
                Email = "a.bad.email", // bad email
                Phone = "555-555-5555"
            }));
        }

        [Fact]
        public void Post_ShouldReturnBadRequestWhenPhoneIsInvalid()
        {
            Assert.False(IsValid(new Student
            {
                FirstName = "John",
                LastName = "Doe",
                BirthDate = new DateTime(2010, 1, 1),
                Email = "test@test.com",
                Phone = "abc" // bad phone
            }));
        }

        [Fact]
        public void Post_ShouldReturnBadRequestWhenFirstNameIsMissing()
        {
            Assert.False(IsValid(new Student
            {
                // FirstName = "John", // missing
                LastName = "Doe", 
                BirthDate = new DateTime(2010, 1, 1),
                Email = "test@test.com",
                Phone = "555-555-5555"
            }));
        }

        [Fact]
        public void Post_ShouldReturnBadRequestWhenLastNameIsMissing()
        {
            Assert.False(IsValid(new Student
            {
                FirstName = "John",
                // LastName = "Doe", // missing
                BirthDate = new DateTime(2010, 1, 1),
                Email = "test@test.com",
                Phone = "555-555-5555"
            }));
        }

        [Fact]
        public void Post_ShouldReturnOkWhenStudentIsValid()
        {
            Assert.True(IsValid(new Student
            {
                FirstName = "John",
                LastName = "Doe",
                BirthDate = new DateTime(2009, 1, 1),
                Email = "test@test.com",
                Phone = "555-555-5555"
            }));
        }

<<<<<<< HEAD
        private IActionResult TryPost(Student student)
        {
=======
        public IActionResult TryPost(Student student)
        {
>>>>>>> parent of db1c480... update to netcoreapp3.1
            // arrange - create a new controller
            var controller = new StudentsController(new StudentsService());

            // act - call Post() with given student 
<<<<<<< HEAD
            return controller.Post(student);
        }

        private bool IsValid(Student student)
        {
            var context = new ValidationContext(student, null, null);
            var results = new List<ValidationResult>();
            var valid = Validator.TryValidateObject(student, context, results, true);
            return valid;
=======
            return controller.Post(student);
>>>>>>> parent of db1c480... update to netcoreapp3.1
        }
    }
}
