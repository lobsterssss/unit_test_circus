
namespace unit_test_circus
{
    using CircusTrein;
    using System.CodeDom;

    [TestClass]
    public sealed class CartTest
    {

        [TestMethod]
        /*ID 1*/
        public void MoveAnimal_ID1_Return2Carts()
        {
            Circus circus = new Circus();
            List<Animal> animals = new List<Animal>();
            List<Cart> train = new List<Cart>();

            for (int i = 0; i < 1; i++)
            {
                animals.Add(new Animal(Animal.ESize.large, isCarnivor: false));
            }

            for (int i = 0; i < 3; i++)
            {
                animals.Add(new Animal(Animal.ESize.medium, isCarnivor: false));
            }

            for (int i = 0; i < 4; i++)
            {
                animals.Add(new Animal(Animal.ESize.small, isCarnivor: false));
            }
            train = circus.moveAnimals(animals);

            Assert.AreEqual(2, train.Count(), $"train building unsuccessfull, ID 1 \n {ShowTrain(train)}");

        }

        /*ID 2*/
        [TestMethod]
        public void MoveAnimal_ID2_Return6Carts()
        {
            Circus circus = new Circus();
            List<Animal> animals = new List<Animal>();
            List<Cart> train = new List<Cart>();


            /* adds herbivores */

            for (int i = 0; i < 3; i++)
            {
                animals.Add(new Animal(Animal.ESize.large, isCarnivor: false));
            }

            for (int i = 0; i < 0; i++)
            {
                animals.Add(new Animal(Animal.ESize.medium, isCarnivor: false));
            }

            for (int i = 0; i < 0; i++)
            {
                animals.Add(new Animal(Animal.ESize.small, isCarnivor: false));
            }

            /* adds carnivores */
            for (int i = 0; i < 2; i++)
            {
                animals.Add(new Animal(Animal.ESize.large, isCarnivor: true));
            }

            for (int i = 0; i < 3; i++)
            {
                animals.Add(new Animal(Animal.ESize.medium, isCarnivor: true));
            }

            for (int i = 0; i < 1; i++)
            {
                animals.Add(new Animal(Animal.ESize.small, isCarnivor: true));
            }
            train = circus.moveAnimals(animals);

            Assert.AreEqual(6, train.Count(), $"train building unsuccessfull, ID 2 \n {ShowTrain(train)}");

        }
        /*ID 3*/
        [TestMethod]
        public void MoveAnimal_ID3_Return8Carts()
        {
            Circus circus = new Circus();
            List<Animal> animals = new List<Animal>();
            List<Cart> train = new List<Cart>();


            /* adds herbivores */

            for (int i = 0; i < 5; i++)
            {
                animals.Add(new Animal(Animal.ESize.large, isCarnivor: false));
            }

            for (int i = 0; i < 5; i++)
            {
                animals.Add(new Animal(Animal.ESize.medium, isCarnivor: false));
            }

            for (int i = 0; i < 5; i++)
            {
                animals.Add(new Animal(Animal.ESize.small, isCarnivor: false));
            }

            /* adds carnivores */
            for (int i = 0; i < 2; i++)
            {
                animals.Add(new Animal(Animal.ESize.large, isCarnivor: true));
            }

            for (int i = 0; i < 2; i++)
            {
                animals.Add(new Animal(Animal.ESize.medium, isCarnivor: true));
            }

            for (int i = 0; i < 2; i++)
            {
                animals.Add(new Animal(Animal.ESize.small, isCarnivor: true));
            }
            train = circus.moveAnimals(animals);

            Assert.AreEqual(8, train.Count(), $"train building unsuccessfull, ID 3 \n {ShowTrain(train)}");

        }

        /*ID 4*/
        [TestMethod]
        public void MoveAnimal_ID4_Return2Carts()
        {
            Circus circus = new Circus();
            List<Animal> animals = new List<Animal>();
            List<Cart> train = new List<Cart>();
            /* adds herbivores */

            for (int i = 0; i < 2; i++)
            {
                animals.Add(new Animal(Animal.ESize.large, isCarnivor: false));
            }

            for (int i = 0; i < 3; i++)
            {
                animals.Add(new Animal(Animal.ESize.medium, isCarnivor: false));
            }

            for (int i = 0; i < 1; i++)
            {
                animals.Add(new Animal(Animal.ESize.small, isCarnivor: false));
            }
            train = circus.moveAnimals(animals);
            Assert.AreEqual(2, train.Count(), $"train building unsuccessfull, ID 4 \n {ShowTrain(train)}");

        }

        /*ID 5*/
        [TestMethod]
        public void MoveAnimal_ID5_Return2Carts()
        {
            Circus circus = new Circus();
            List<Animal> animals = new List<Animal>();
            List<Cart> train = new List<Cart>();

            /* adds herbivores */

            for (int i = 0; i < 2; i++)
            {
                animals.Add(new Animal(Animal.ESize.large, isCarnivor: false));
            }

            for (int i = 0; i < 3; i++)
            {
                animals.Add(new Animal(Animal.ESize.medium, isCarnivor: false));
            }

            for (int i = 0; i < 0; i++)
            {
                animals.Add(new Animal(Animal.ESize.small, isCarnivor: false));
            }

            /* adds carnivores */
            for (int i = 0; i < 0; i++)
            {
                animals.Add(new Animal(Animal.ESize.large, isCarnivor: true));
            }

            for (int i = 0; i < 0; i++)
            {
                animals.Add(new Animal(Animal.ESize.medium, isCarnivor: true));
            }

            for (int i = 0; i < 1; i++)
            {
                animals.Add(new Animal(Animal.ESize.small, isCarnivor: true));
            }
            train = circus.moveAnimals(animals);

            Assert.AreEqual(2, train.Count(), $"train building unsuccessfull, ID 5 \n {ShowTrain(train)}");

        }

        /*ID 6*/
        [TestMethod]
        public void MoveAnimal_ID6_Return2Carts()
        {
            Circus circus = new Circus();
            List<Animal> animals = new List<Animal>();
            List<Cart> train = new List<Cart>();

            /* adds herbivores */

            for (int i = 0; i < 2; i++)
            {
                animals.Add(new Animal(Animal.ESize.large, isCarnivor: false));
            }

            for (int i = 0; i < 2; i++)
            {
                animals.Add(new Animal(Animal.ESize.medium, isCarnivor: false));
            }

            for (int i = 0; i < 0; i++)
            {
                animals.Add(new Animal(Animal.ESize.small, isCarnivor: false));
            }

            /* adds carnivores */
            for (int i = 0; i < 0; i++)
            {
                animals.Add(new Animal(Animal.ESize.large, isCarnivor: true));
            }

            for (int i = 0; i < 0; i++)
            {
                animals.Add(new Animal(Animal.ESize.medium, isCarnivor: true));
            }

            for (int i = 0; i < 2; i++)
            {
                animals.Add(new Animal(Animal.ESize.small, isCarnivor: true));
            }
            train = circus.moveAnimals(animals);

            Assert.AreEqual(2, train.Count(), $"train building unsuccessfull, ID 6 \n {ShowTrain(train)}");

        }

        /*ID 7*/
        [TestMethod]
        public void MoveAnimal_ID7_Return2Carts()
        {
            Circus circus = new Circus();
            List<Animal> animals = new List<Animal>();
            List<Cart> train = new List<Cart>();

            /* adds herbivores */

            for (int i = 0; i < 2; i++)
            {
                animals.Add(new Animal(Animal.ESize.large, isCarnivor: false));
            }

            for (int i = 0; i < 6; i++)
            {
                animals.Add(new Animal(Animal.ESize.medium, isCarnivor: false));
            }

            for (int i = 0; i < 0; i++)
            {
                animals.Add(new Animal(Animal.ESize.small, isCarnivor: false));
            }

            /* adds carnivores */
            for (int i = 0; i < 0; i++)
            {
                animals.Add(new Animal(Animal.ESize.large, isCarnivor: true));
            }

            for (int i = 0; i < 0; i++)
            {
                animals.Add(new Animal(Animal.ESize.medium, isCarnivor: true));
            }

            for (int i = 0; i < 2; i++)
            {
                animals.Add(new Animal(Animal.ESize.small, isCarnivor: true));
            }
            train = circus.moveAnimals(animals);

            Assert.AreEqual(3, train.Count(), $"train building unsuccessfull, ID 7 \n {ShowTrain(train)}");

        }

        private string ShowTrain(List<Cart> train) 
        {
            string show = "";
            foreach (Cart item in train)
            {
                show = show + item.ToString() + "\n";
            }
            return show;
        }

    }
}
