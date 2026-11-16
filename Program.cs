using System;

namespace StockApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockService stock = new StockService();

            int choix = -1;

            do
            {
                Console.WriteLine("\n===== GESTION DU STOCK =====");
                Console.WriteLine("1. Ajouter un article");
                Console.WriteLine("2. Afficher les articles");
                Console.WriteLine("3. Rechercher un article");
                Console.WriteLine("4. Supprimer un article");
                Console.WriteLine("0. Quitter");

                Console.Write("Votre choix : ");

                if (!int.TryParse(Console.ReadLine(), out choix))
                {
                    Console.WriteLine("Veuillez entrer un nombre.");
                    continue;
                }

                switch (choix)
                {
                    case 1:
                        Console.Write("Nom de l'article : ");
                        string nom = Console.ReadLine() ?? "";

                        Console.Write("Quantité : ");

                        if (int.TryParse(Console.ReadLine(), out int quantite)
                            && quantite >= 0
                            && !string.IsNullOrWhiteSpace(nom))
                        {
                            stock.AjouterArticle(
                                new StockItem(nom, quantite)
                            );
                        }
                        else
                        {
                            Console.WriteLine("Informations invalides.");
                        }
                        break;

                    case 2:
                        stock.AfficherArticles();
                        break;

                    case 3:
                        Console.Write("Nom à rechercher : ");
                        string recherche = Console.ReadLine() ?? "";

                        StockItem? resultat =
                            stock.RechercherArticle(recherche);

                        if (resultat != null)
                            Console.WriteLine(resultat);
                        else
                            Console.WriteLine("Article introuvable.");
                        break;

                    case 4:
                        Console.Write("Nom à supprimer : ");
                        string suppression = Console.ReadLine() ?? "";

                        stock.SupprimerArticle(suppression);
                        break;

                    case 0:
                        Console.WriteLine("Au revoir !");
                        break;

                    default:
                        Console.WriteLine("Choix invalide.");
                        break;
                }

            } while (choix != 0);
        }
    }
}