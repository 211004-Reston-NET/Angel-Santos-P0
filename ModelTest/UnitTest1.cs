using System;
using StoreModels;
using Xunit;

namespace ModelTest 
{//CLI 'dotnet test' to run test cases
    public class UnitTest1 
    {
        /// <summary>
        /// Will test if the city property will set with valid data
        /// valid data - anything with letters only -string
          [Fact] // Fact is a testcase that doesn't have any parameters
          //Runs only once.
        public void NameSetValidData() 
        {
            //Arrange
        Customer _custTest = new Customer();
        string name = "Birdman";
        

            //Act
        _custTest.FirstName = name; 

            //Assert
        Assert.NotNull(_custTest.FirstName);
        Assert.Equal(_custTest.FirstName, name);
        
        }  

        /// <summary>
        /// Will test for exception from Name Property for invalid data
        /// invalid data - not string
        /// </summary>
        [Theory] // Theory creates a parameter test case
        [InlineData("21d")] //InlineData is data passed to parameter of 
                        //test method
        [InlineData("adc")]
        [InlineData("scc")]  //More test methods may be added
        [InlineData("sc")]
        
        
        public void NameShouldFailIfInvalid(string p_input)
        {//Arrange
            Customer _custTest = new Customer();

            //Act & Assert
            //Throws method will only pass if the code you did will
            //give an Exception
            Assert.Throws<Exception>(() => _custTest.FirstName = p_input); 
            // Because the Inline Data are strings - the result is Failed: 4; 
            // None of them returned an exception as the 'Act & Assert' method specified.
            // Their data was valid - so they are Valid Data
        }
    }
}

            