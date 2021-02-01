using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing
{
    public class UserTests
    {
        [Fact]
        private void Test_UserExists()
        {
            // arrange
            var sut = new User();

            // act
            var actual = sut;

            // assert
            Assert.IsType<User>(actual);
            Assert.NotNull(actual);
        }
        [Fact]
        private void Test_User_Name_Exists()
        {
            // arrange
            var sut = new User();

            // act
            sut.Name = "bob";
            var actual = sut.Name;

            // assert
            Assert.IsType<string>(actual);
            
        }
    }
}