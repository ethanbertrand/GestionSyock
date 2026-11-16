using System;
using System.Collections.Generic;

namespace StockApp
{
    internal class StockService
    {
        private List<StockItem> articles;

        public StockService()
        {
            articles = new List<StockItem>();
        }

        public void AjouterArticle(StockItem article)
        {
            articles.Add(article);
            Console.WriteLine("Article ajouté !");
        }

        public void AfficherArticles()
        {
            if (articles.Count == 0)
            {
                Console.WriteLine("Le stock est vide.");
                return;
            }

            foreach (StockItem article in articles)
            {
                Console.WriteLine(article);
            }
        }

        public StockItem? RechercherArticle(string nom)
        {
            return articles.Find(a => a.Nom == nom);
        }

        public void SupprimerArticle(string nom)
        {
            StockItem? article = RechercherArticle(nom);

            if (article != null)
            {
                articles.Remove(article);
                Console.WriteLine("Article supprimé !");
            }
            else
            {
                Console.WriteLine("Article introuvable.");
            }
        }
    }
}