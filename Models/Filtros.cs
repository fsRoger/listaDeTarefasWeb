namespace listaDeTarefasWeb.Models
{
    public class Filtros
    {
        public Filtros(string filtroString)
        {
            FiltroString = filtroString ?? "todos-todos-todos";
            string[] filtros = filtroString.Split('-');

            if (filtros.Length >= 3)
            {
                CategoriaId = filtros[0];
                Vencimento = filtros[1];
                StatusId = filtros[2];
            }
            else
            {
                // Lógica para lidar com uma divisão inválida, se necessário.
            }
        }

        public string FiltroString { get; set; }
        public string CategoriaId { get; set; }
        public string StatusId { get; set; }
        public string Vencimento { get; set; }

        public bool TemCategoria => !string.IsNullOrEmpty(CategoriaId) && CategoriaId.ToLower() != "todos";
        public bool TemVencimento => !string.IsNullOrEmpty(Vencimento) && Vencimento.ToLower() != "todos";
        public bool TemStatus => !string.IsNullOrEmpty(StatusId) && StatusId.ToLower() != "todos";

        public static Dictionary<string, string> VencimentoValoresFiltro =>
            new Dictionary<string, string>
            {
                {"futuro", "Futuro" },
                {"passado", "Passado" },
                {"hoje", "Hoje" }
            };

        public bool EPassado => !string.IsNullOrEmpty(Vencimento) && Vencimento.ToLower() == "passado";
        public bool EFuturo => !string.IsNullOrEmpty(Vencimento) && Vencimento.ToLower() == "futuro";
        public bool EHoje => !string.IsNullOrEmpty(Vencimento) && Vencimento.ToLower() == "hoje";
    }
}
