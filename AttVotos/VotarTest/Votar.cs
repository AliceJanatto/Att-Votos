using AttVotos;

namespace VotarTest
{
    public class Votar
    {
        [Fact]
        public void NaoPodeVotar()
        {
            int idade = 15;
            string esperado = "Sinto muito, o voto é permitido apenas para maiores de 16 anos.";
            string obtido = Voto.PodeVotar(idade);
            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void VotoJovem()
        {
            int idade = 17;
            string esperado = "Voto facultativo, você escolhe se deseja votar ou não!";
            string obtido = Voto.PodeVotar(idade);
            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void PodeVotar()
        {
            int idade = 20;
            string esperado = "Voto obrigatório! Casos de não comparecimento são passíveis de multas!";
            string obtido = Voto.PodeVotar(idade);
            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void VotoIdoso()
        {
            int idade = 75;
            string esperado = "Voto facultativo, você escolhe se deseja votar ou não!";
            string obtido = Voto.PodeVotar(idade);
            Assert.Equal(esperado, obtido);
        }
    }
}