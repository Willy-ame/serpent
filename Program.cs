using System;

class Program
{
    static void Main()
    {
        // Déclaration et initialisation du tableau 10x10
        string[,] tableau = new string[10, 10];

        // Création d'un objet Random pour générer des nombres aléatoires
        Random random = new Random();

        // Remplissage du tableau avec les nombres de 1 à 100
        for (int i = 1; i <= 100; i++)
        {
            int row = (i - 1) / 10; // Index de ligne calculé à partir du nombre
            int column = (i - 1) % 10; // Index de colonne calculé à partir du nombre
            tableau[row, column] = i.ToString();
        }

        // Ajout des occurrences de la lettre "O" réparties aléatoirement
        int occurrences = 0;
        while (occurrences < 20)
        {
            int row = random.Next(0, tableau.GetLength(0)); // Index de ligne aléatoire
            int column = random.Next(0, tableau.GetLength(1)); // Index de colonne aléatoire
            if (tableau[row, column] != "O")
            {
                tableau[row, column] = "O";
                occurrences++;
            }
        }

        // Remplacer les cases 57, 67 et 77 par la lettre "H"
        tableau[5, 7] = "H";
        tableau[6, 7] = "H";
        tableau[7, 7] = "H";

        // Trouver la longueur maximale parmi tous les éléments du tableau
        int maxLength = 0;
        for (int i = 0; i < tableau.GetLength(0); i++)
        {
            for (int j = 0; j < tableau.GetLength(1); j++)
            {
                int length = tableau[i, j].Length;
                if (length > maxLength)
                {
                    maxLength = length;
                }
            }
        }

        // Affichage du tableau avec les cellules alignées
        for (int i = 0; i < tableau.GetLength(0); i++)
        {
            for (int j = 0; j < tableau.GetLength(1); j++)
            {
                string cell = tableau[i, j];
                int padding = maxLength - cell.Length;
                Console.Write($"[{new string(' ', padding)}{cell}] ");
            }
            Console.WriteLine();
        }

        // Attente de l'appui sur une touche pour fermer la console
        Console.ReadKey();
    }
}

