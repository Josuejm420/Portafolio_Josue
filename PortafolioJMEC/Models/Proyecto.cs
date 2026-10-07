namespace PortafolioJMEC.Models
{
    public class Proyecto
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string ImagenUrl { get; set; } = string.Empty;
        public string VideoUrl { get; set; } = string.Empty;
        public List<string> Tecnologias { get; set; } = new List<string>();
        public string LinkGithub { get; set; } = string.Empty;
        public string LinkDemo { get; set; } = string.Empty;

    }
}
