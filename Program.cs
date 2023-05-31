Random aleatoire = new Random();
Boolean trouve = true;

while (true) { 

Console.WriteLine("Appuyer sur la touche entrer pour Lancer le dé");
String choix = Console.ReadLine();
int de = aleatoire.Next(1, 7);
traitementde(de);


// trouve = false;
};



void traitementde (int aleatoire){
String[] tableau = new String[6] {"[ 1 ]","( 2 )","[ 3 ]","( 4 )","[ 5 ]","( 6 )"};
int controle = 0;
for(int i = 0; i < 40; i++)
{
    Console.Clear();
    Console.WriteLine(tableau[controle]);
    Thread.Sleep(100);
    if(controle == 5){controle =-1;}
    controle++;
}
    Console.Clear();
    Console.WriteLine("[ "+aleatoire+" ]");

}