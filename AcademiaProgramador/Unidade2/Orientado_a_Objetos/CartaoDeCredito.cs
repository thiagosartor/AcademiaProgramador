namespace Unidade2.Orientado_a_Objetos
{
    class CartaoDeCredito
    {
        public int numero;
        public string dataDeValidade;
        public Cliente cliente;

        // Adicione o contrutor abaixo

        public CartaoDeCredito(int numero)
        {
            this.numero = numero;
        }

        public CartaoDeCredito()
        {
            // TODO: Complete member initialization
        }
    }
}