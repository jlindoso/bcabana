namespace business.Model.Classes
{
    public class ProdutoComanda: BaseClass
    {
        public Produto Produto { get; set; } = null!;
        public Comanda Comanda { get; set; } = null!;
        public int Quantidade { get; set; } = 1;
        public decimal PrecoUnitario { get; set; }
        public Usuario Garcom { get; set; } = null!;
        public Usuario? Atendente { get; set; } = null;
    }
}