using Jcf.AM.Control.Api.Models.TypeBases;

namespace Jcf.AM.Control.Test.UnitTests.Jcf.AM.Control.Api.Models.TypeBases
{
    public class NameTest
    {
        [Fact]
        public void Constructor_ValidName_ShouldCreateInstance()
        {
            // Arrange
            var validName = new string('a', 10);

            // Act
            var name = new Name(validName);

            // Assert
            Assert.Equal(validName, name.Value);
        }

        [Theory]
        [InlineData("Jo")] // menos que 3 caracteres
        [InlineData("")]   // vazio
        [InlineData(null)] // null causará NullReferenceException
        public void Constructor_InvalidNameMinLength_ShouldThrowAggregateException(string invalidName)
        {
            if (invalidName == null)
            {
                Assert.Throws<NullReferenceException>(() => new Name(invalidName));
            }
            else
            {
                var ex = Assert.Throws<AggregateException>(() => new Name(invalidName));
                Assert.Contains("Mínimo de", ex.Message);
            }
        }

        [Fact]
        public void Constructor_InvalidNameMaxLength_ShouldThrowAggregateException()
        {
            // Arrange
            var longName = new string('a', 257); // 1 caractere a mais que o permitido

            // Act & Assert
            var ex = Assert.Throws<AggregateException>(() => new Name(longName));
            Assert.Contains("Máximo de", ex.Message);
        }
    }
}
