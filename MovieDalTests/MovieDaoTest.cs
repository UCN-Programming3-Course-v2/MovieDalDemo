using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieDal;
using System;

namespace MovieDalTests
{
    [TestClass]
    public class MovieDaoTest
    {
        [TestMethod]
        public void CreateMovieTest()
        {
            // Arrange
            IMovieDao dao = MovieDalFactory.Create<IMovieDao>();

            // Act

            // Assert
            Assert.ThrowsException<NotImplementedException>(() => dao.Create("A New Hope"));
        }
    }
}
