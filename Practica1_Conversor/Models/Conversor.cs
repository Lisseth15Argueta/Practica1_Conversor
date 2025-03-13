namespace Practica1_Conversor.Models
{
    public class Conversor
    {
        public double Valor { get; set; }
        public string UnidadOrigen { get; set; }
        public string UnidadDestino { get; set; }
        public double Resultado { get; set; }

        public List<string> Unidades { get; set; } = new()
        {
            "Metro", "Kilometro", "Centimetro", "Milimetro", "Micrometro",
            "Nanometro", "Milla", "Yarda", "Pie", "Pulgada", "Milla nautica"
        };

        public void Convertir()
        {
            double valorEnMetros = UnidadOrigen switch
            {
                "Kilometro" => Valor * 1000,
                "Centimetro" => Valor / 100,
                "Milimetro" => Valor / 1000,
                "Micrometro" => Valor / 1_000_000,
                "Nanometro" => Valor / 1_000_000_000,
                "Milla" => Valor * 1609.344,
                "Yarda" => Valor * 0.9144,
                "Pie" => Valor * 0.3048,
                "Pulgada" => Valor * 0.0254,
                "Milla nautica" => Valor * 1852,
                _ => Valor
            };

            Resultado = UnidadDestino switch
            {
                "Kilometro" => valorEnMetros / 1000,
                "Centimetro" => valorEnMetros * 100,
                "Milimetro" => valorEnMetros * 1000,
                "Micrometro" => valorEnMetros * 1_000_000,
                "Nanometro" => valorEnMetros * 1_000_000_000,
                "Milla" => valorEnMetros / 1609.344,
                "Yarda" => valorEnMetros / 0.9144,
                "Pie" => valorEnMetros / 0.3048,
                "Pulgada" => valorEnMetros / 0.0254,
                "Milla nautica" => valorEnMetros / 1852,
                _ => valorEnMetros
            };
        }
    }
}