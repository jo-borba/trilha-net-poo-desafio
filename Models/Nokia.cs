namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string IMei, int memoria) : base(numero, modelo, IMei, memoria)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando App para Nokia. Nome do App: {nomeApp}");
        }
    }
}