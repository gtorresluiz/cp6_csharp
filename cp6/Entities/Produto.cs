namespace cp6.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }             // Ex: "Vinho Tinto Reserva"
        public string Tipo { get; set; }             // Ex: "Suave", "Seco", "Rosé"
        public string Nacionalidade { get; set; }    // Ex: "Chile", "Brasil", "Portugal"
        public int Safra { get; set; }               // Ex: 2020
        public decimal Preco { get; set; }           // Ex: 89.90
        public string Descricao { get; set; }        // Ex: "Aroma intenso e sabor frutado"
    }
}
