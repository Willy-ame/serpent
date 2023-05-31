using System;

class Program
{
    class Pion
    {
        public string Symbole { get; } = "█";
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

        public Pion()
        {
            PositionX = 0;
            PositionY = 0;
        }

        public void Avance()
        {
            //PositionY+=LancerDe() ;
            PositionY++;
        }
    }

    static int LancerDe()
    {
        // Création d'un objet Random pour générer un nombre aléatoire
        Random random = new Random();

        // Génération d'un nombre aléatoire entre 1 et 6 inclus
        int resultat = random.Next(1, 7);

        return resultat;
    }

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

        // Création d'un objet Pion
        Pion pion = new Pion();

        // Placer le pion dans le tableau à la position (0, 0)
        tableau[0, 0] = pion.Symbole;

        // Déplacement du pion vers la droite
        int anciennePositionY = pion.PositionY;
        pion.Avance();
        int nouvellePositionY = pion.PositionY;

        // Restaurer la valeur de la case précédente
        tableau[0, anciennePositionY] = (anciennePositionY + 1).ToString();

        // Mettre à jour la position du pion dans le tableau
        tableau[0, nouvellePositionY] = pion.Symbole;

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

