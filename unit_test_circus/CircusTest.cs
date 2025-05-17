
namespace CircusTrainUnitTests
{
    using CircusTrain;
    using CircusTrain.Carts;
    using System.CodeDom;

    [TestClass]
    public sealed class CartTest
    {
        [TestMethod]
        /*ID 1*/
        public void MoveAnimal_2SmallCarnivores_Return1Carts()
        {
            Circus circus = new Circus();
            Train train = new Train();

            train = circus.MoveAnimals(0, 0, 0, 2, 0, 0);

            Assert.AreEqual(1, train.GetCount(), $"train building unsuccessfull, ID 1 \n {train.ShowTrain()}");
        }

        [TestMethod]
        /*ID 1*/
        public void MoveAnimal_ID1_Return2Carts()
        {
            Circus circus = new Circus();
            Train train = new Train();

            train = circus.MoveAnimals(5, 3, 1, 0, 0, 0);

            Assert.AreEqual(2, train.GetCount(), $"train building unsuccessfull, ID 1 \n {train.ShowTrain()}");

        }

        /*ID 2*/
        [TestMethod]
        public void MoveAnimal_ID2_Return6Carts()
        {
            Circus circus = new Circus();
            Train train = new Train();

            train = circus.MoveAnimals(0, 0, 3, 1, 3, 2);

            Assert.AreEqual(6, train.GetCount(), $"train building unsuccessfull, ID 2 \n {train.ShowTrain()}");

        }
        /*ID 3*/
        [TestMethod]
        public void MoveAnimal_ID3_Return8Carts()
        {
            Circus circus = new Circus();
            Train train = new Train();

            train = circus.MoveAnimals(5, 5, 5, 2, 2, 2);

            Assert.AreEqual(8, train.GetCount(), $"train building unsuccessfull, ID 3 \n {train.ShowTrain()}");

        }

        /*ID 4*/
        [TestMethod]
        public void MoveAnimal_ID4_Return2Carts()
        {
            Circus circus = new Circus();
            Train train = new Train();


           

            train = circus.MoveAnimals(1, 3, 2, 0, 0, 0);
            Assert.AreEqual(2, train.GetCount(), $"train building unsuccessfull, ID 4 \n {train.ShowTrain()}");

        }

        /*ID 5*/
        [TestMethod]
        public void MoveAnimal_ID5_Return2Carts()
        {
            Circus circus = new Circus();
            Train train = new Train();

            train = circus.MoveAnimals(0, 3, 2, 1, 0, 0);

            Assert.AreEqual(2, train.GetCount(), $"train building unsuccessfull, ID 5 \n {train.ShowTrain()}");

        }

        /*ID 6*/
        [TestMethod]
        public void MoveAnimal_ID6_Return2Carts()
        {
            Circus circus = new Circus();
            Train train = new Train();


           

            train = circus.MoveAnimals(0, 2, 2, 2, 0, 0);

            Assert.AreEqual(2, train.GetCount(), $"train building unsuccessfull, ID 6 \n {train.ShowTrain()}");

        }

        /*ID 7*/
        [TestMethod]
        public void MoveAnimal_ID7_Return2Carts()
        {
            Circus circus = new Circus();
            Train train = new Train();

            train = circus.MoveAnimals(0, 6, 2, 2, 0, 0);

            Assert.AreEqual(3, train.GetCount(), $"train building unsuccessfull, ID 7 \n {train.ShowTrain()}");

        }

    }
}
