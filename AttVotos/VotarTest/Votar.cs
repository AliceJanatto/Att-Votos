using AttVotos;

namespace VotarTest
{
    public class Votar
    {
        [Fact]
        public void NaoPodeVotar()
        {
            int idade = 15;
            string esperado = "Sinto muito, o voto � permitido apenas para maiores de 16 anos.";
            string obtido = Voto.PodeVotar(idade);
            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void VotoJovem()
        {
            int idade = 17;
            string esperado = "Voto facultativo, voc� escolhe se deseja votar ou n�o!";
            string obtido = Voto.PodeVotar(idade);
            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void PodeVotar()
        {
            int idade = 20;
            string esperado = "Voto obrigat�rio! Casos de n�o comparecimento s�o pass�veis de multas!";
            string obtido = Voto.PodeVotar(idade);
            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void VotoIdoso()
        {
            int idade = 75;
            string esperado = "Voto facultativo, voc� escolhe se deseja votar ou n�o!";
            string obtido = Voto.PodeVotar(idade);
            Assert.Equal(esperado, obtido);
        }
    }
}