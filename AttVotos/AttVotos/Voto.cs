namespace AttVotos
{
    public class Voto
    {
        public static string PodeVotar(int idade)
        {
            if (idade <= 15)
                return "Sinto muito, o voto é permitido apenas para maiores de 16 anos.";

            if ((idade >= 16 && idade <= 17))
                return "Voto facultativo, você escolhe se deseja votar ou não!";

            if ((idade >= 18 && idade <= 70))
                return "Voto obrigatório! Casos de não comparecimento são passíveis de multas!";

            return "Voto facultativo, você escolhe se deseja votar ou não!";
        }
    }
}
