Random aleatoire = new Random();

int min = 0;
int max ;
int de = aleatoire.Next(1, 6);
Console.WriteLine(de);
// tableau plateau
// generation case
// for taille max :
// plateau.add(aleatoire(1ou2ou3)) 1 neutre ou 2 bonnus ou 3 malus (4 autres serpent , echelle))

Boolean trouve = true;
while (trouve) { 

traitementde(de);

trouve = false;
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