namespace FiveStarRepos.Application.Queries.ListarRepositorios
{
    public class ListarRepositoriosQuery
    {
        public string Termo { get; set; }
        public int Pagina { get; set; } = 1;
        public int TamanhoPagina { get; set; } = 10;
    }
}
