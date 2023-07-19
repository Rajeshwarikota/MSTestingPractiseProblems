using static MSTestingProblem.EnglishCompetation;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SwappingCompetion_ShouldReturnYes()
        {
            // Arrange
            EnglishCompetion ec = new EnglishCompetion();
            string word1 = "part";
            string word2 = "trap";

            // Act
            string result = ec.SwappingCompetion(word1, word2);

            // Assert
            Assert.AreEqual("YES", result);
        }
    }
}