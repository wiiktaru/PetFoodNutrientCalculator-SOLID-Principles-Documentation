using PetFoodNutrientCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFoodNutrientCalculatorTests
{
    /// TODO change these test methods to implement best practices
    [TestClass]
    public class PetRepositoryTests
    {
        PetRepository petRepository; 

        [TestInitialize]
        public void TestInitialize()
        {
            petRepository = new PetRepository();
        }

        [TestMethod]
        public void AddPet_ValidInput_AddsPetToList()
        {
            var pet = new Pet { Name = "Kulkuri"};

            petRepository.Pets.Add(pet);

            // Assert
            Assert.AreEqual(1, petRepository.Pets.Count);
        }

        [TestMethod]
        public void GetPetSelection_ValidInput_ReturnsInt()
        {

        }

        [TestMethod]
        public void AddPet_ShouldAddDog_WhenSelectionIs1()
        {
            // Arrange
            var petRepository = new PetRepository();

            // Simulates user input for selecting a dog,
            // naming it "Kulkuri", and setting its weight to 10.0
            var input = new StringReader("1\nKulkuri\n10.0\n");
            Console.SetIn(input);

            // Captures console output for verification
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            petRepository.AddPet();

            // Assert
            Assert.AreEqual(1, petRepository.Pets.Count);
            Assert.IsInstanceOfType(petRepository.Pets[0], typeof(Dog));
            Assert.AreEqual("Kulkuri", petRepository.Pets[0].Name);
            Assert.AreEqual(10.0, petRepository.Pets[0].Weight);
        }

        [TestMethod]
        public void AddPet_ShouldAddCat_WhenSelectionIs2()
        {
            // Arrange
            var petRepository = new PetRepository();

            // Simulates user input for selecting a dog,
            // naming it "Lucifer", and setting its weight to 10.0
            var input = new StringReader("2\nLucifer\n4.5\n");
            Console.SetIn(input);

            // Captures console output for verification
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            petRepository.AddPet();

            // Assert
            Assert.AreEqual(1, petRepository.Pets.Count);
            Assert.IsInstanceOfType(petRepository.Pets[0], typeof(Cat));
            Assert.AreEqual("Lucifer", petRepository.Pets[0].Name);
            Assert.AreEqual(4.5, petRepository.Pets[0].Weight);
        }

        [TestMethod]
        public void ValidatePetSelection_ShouldRestartOnInvalidInput()
        {
            // Arrange
            var petRepository = new PetRepository();

            // Simulates user input for selecting a dog,
            // naming it "Kulkuri", and setting its weight to 10.0
            var input = new StringReader("invalid\n1\nKulkuri\n10.0\n");
            Console.SetIn(input);

            // Captures console output for verification
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            petRepository.AddPet();

            // Assert
            StringAssert.Contains(output.ToString(), "Virheellinen syöte. Valitse kokonaisluku 1 tai 2.");
            Assert.AreEqual(1, petRepository.Pets.Count);
            Assert.IsInstanceOfType(petRepository.Pets[0], typeof(Dog));
        }

        [TestMethod]
        public void ValidatePetName_ShouldRestartOnEmptyName()
        {
            // Arrange
            var petRepository = new PetRepository();

            // Simulates user input for selecting a dog,
            // naming it "Kulkuri", and setting its weight to 10.0
            var input = new StringReader("1\n\nKulkuri\n10.0\n");
            Console.SetIn(input);

            // Captures console output for verification
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            petRepository.AddPet();

            // Assert
            StringAssert.Contains(output.ToString(), "Virheellinen syöte. Nimi ei voi olla tyhjä.");
            Assert.AreEqual(1, petRepository.Pets.Count);
            Assert.IsInstanceOfType(petRepository.Pets[0], typeof(Dog));
        }

        [TestMethod]
        public void ValidatePetWeight_ShouldRestartOnInvalidWeight()
        {
            // Arrange
            var petRepository = new PetRepository();

            // Simulates user input for selecting a dog,
            // naming it "Kulkuri", and setting its weight to 10.0
            var input = new StringReader("1\nKulkuri\ninvalid\n10.0\n");
            Console.SetIn(input);

            // Captures console output for verification
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            petRepository.AddPet();

            // Assert
            StringAssert.Contains(output.ToString(), "Virheellinen syöte. Syötä kelvollinen paino.");
            Assert.AreEqual(1, petRepository.Pets.Count);
            Assert.IsInstanceOfType(petRepository.Pets[0], typeof(Dog));
        }
    }
}
