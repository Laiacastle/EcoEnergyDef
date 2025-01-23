using EcoEnergyDef;
using MyUtils;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Solar1()
        {
            //Arrange
            double horesSol = 1;
            SistemaSolar metode = new SistemaSolar(horesSol);
            //Act
            bool result = metode.ConfParametre();
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Solar0()
        {
            //Arrange
            double horesSol = 0;
            SistemaSolar metode = new SistemaSolar(horesSol);
            //Act
            bool result = metode.ConfParametre();
            //Assert
            Assert.False(result);
        }

        [Fact]

        public void Solar2()
        {
            //Arrange
            double horesSol = 2;
            SistemaSolar metode = new SistemaSolar(horesSol);
            //Act
            bool result = metode.ConfParametre();
            //Assert
            Assert.True(result);
        }

        [Fact]

        public void Eolica5()
        {
            //Arrange
            double veloVent = 5;
            SistemaEolica metode = new SistemaEolica(veloVent);
            //Act
            bool result = metode.ConfParametre();
            //Assert
            Assert.True(result);
        }

        [Fact]

        public void Eolica6()
        {
            //arrange
            double veloVent = 6;
            SistemaEolica metode = new SistemaEolica(veloVent);
            //Act
            bool result = metode.ConfParametre();
            //Assert
            Assert.True(result);

        }

        [Fact]

        public void Eolica4()
        {
            //Arrange
            double veloVent = 4;
            SistemaEolica metode = new SistemaEolica(veloVent);
            //Act
            bool result = metode.ConfParametre();
            //Assert
            Assert.False(result);
        }

        [Fact]

        public void Hidro20()
        {
            //arrange
            double cabal = 20;
            SistemaHidroelectrica metode = new SistemaHidroelectrica(cabal);
            //Act
            bool result = metode.ConfParametre();
            //Assert
            Assert.True(result);
        }

        [Fact]

        public void Hidro19()
        {
            //Arrange
            double cabal = 19;
            SistemaHidroelectrica metode = new SistemaHidroelectrica(cabal);
            //Act
            bool result = metode.ConfParametre();
            //Assert
            Assert.False(result);
        }

        [Fact]

        public void Hidro21()
        {
            //Arrange
            double cabal = 21;
            SistemaHidroelectrica metode = new SistemaHidroelectrica(cabal);
            //Act
            bool result = metode.ConfParametre();
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void ComprovaLletra()
        {
            //arrange
            string? num = "abc";
            //Act
            bool result = Utils.ComprovarNum(num);
            //Assert
            Assert.False(result);
        }
        [Fact]
        public void ComprovarNum()
        {
            //Arrange
            string? num = "23";
            //Act
            bool result = Utils.ComprovarNum(num);
            //Assert
            Assert.True(result);
        }
    }
}