using cp6.Entities;

namespace cp6.Services
{
    public class ProdutoService
    {
        private static List<Produto> produtos = new List<Produto>()
        {
            new Produto
            {
                Id = 1,
                Nome = "Vinho Chileno Reserva",
                Tipo = "Tinto Seco",
                Nacionalidade = "Chile",
                Safra = 2020,
                Preco = 89.90m,
                Descricao = "Vinho encorpado com notas de frutas vermelhas e carvalho."
            },
            new Produto
            {
                Id = 2,
                Nome = "Rosé Português Suave",
                Tipo = "Rosé Suave",
                Nacionalidade = "Portugal",
                Safra = 2021,
                Preco = 74.50m,
                Descricao = "Vinho leve, frutado e refrescante, ideal para dias quentes."
            }
        };

        public List<Produto> GetAll() => produtos;

        public Produto? GetById(int id) => produtos.FirstOrDefault(p => p.Id == id);

        public void Add(Produto produto)
        {
            produto.Id = produtos.Any() ? produtos.Max(p => p.Id) + 1 : 1;
            produtos.Add(produto);
        }

        public bool Update(int id, Produto produtoAtualizado)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto == null) return false;

            produto.Nome = produtoAtualizado.Nome;
            produto.Tipo = produtoAtualizado.Tipo;
            produto.Nacionalidade = produtoAtualizado.Nacionalidade;
            produto.Safra = produtoAtualizado.Safra;
            produto.Preco = produtoAtualizado.Preco;
            produto.Descricao = produtoAtualizado.Descricao;
            return true;
        }

        public bool Delete(int id)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto == null) return false;

            produtos.Remove(produto);
            return true;
        }
    }
}
