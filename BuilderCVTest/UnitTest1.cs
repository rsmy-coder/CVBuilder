using CVBuilder.Infostructure.Services.Users;

namespace BuilderCVTest
{
    [TestClass]
    public class UserServiceTest
    {
        [TestMethod]
        public void DeleteTest()
        {
            //Arrange
            var user = new UserService();
            //Act
            var result = user.Delete("1c1df47f-fe6a-4355-9ac7-97a585bd1de9");
            //Assert
            Assert.AreNotEqual(result, "1c1df47f-fe6a-4355-9ac7-97a585bd1de9");
        }
        [TestMethod]
        public void CreateTest()
        {
            //Arrange
            var user = new UserService();
            //Act
            var result = user.Get("1c1df47f-fe6a-4355-9ac7-97a585bd1de9");
            //Assert
            Assert.AreNotEqual(result, "1c1df47f-fe6a-4355-9ac7-97a585bd1de9");
        }
    }
}