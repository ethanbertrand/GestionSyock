namespace StockApp
{
    internal class StockItem
    {
        private string nom;
        private int quantite;

        public StockItem(string unnom, int unequantite)
        {
            this.nom = unnom;
            this.quantite = unequantite;
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }

        public override string ToString()
        {
            return "Nom : " + nom + " | Quantité : " + quantite;
        }
    }
}