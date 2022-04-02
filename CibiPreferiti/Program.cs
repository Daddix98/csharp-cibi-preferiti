// See https://aka.ms/new-console-templae for more information

/*
 * Esercizio di oggi sugli Array: Miei cibi preferiti
Nome repo: csharp-cibi-preferiti
Nome progetto csharp: CibiPreferiti
Create un progetto App Console CibiPreferiti con VS2022.
Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi). 
L’array deve essere già inizializzato nel programma, e i vostri cibi preferiti non vanno chiesti all’utente tramite input.
Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
La lunghezza della classifica
La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
Il vostro cibo top (prima posizione della classifica)
Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
Le modalità di consegna sono le solite: repo GitHub, commit e push
*/

//Stampo a video il titolo della lista

Console.WriteLine(" I miei cibi preferiti \n");

//Creo array contenente la lista "non in ordine" di classifica dei miei cibi preferiti

string[] cibiPreferiti = { " Nutella", " Pasta al ragù", " Pizza", " Lasagna", " Polpettone" };

//Creo un ciclo for per stampare in video l'elenco dell'array soprastante

for (var i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(cibiPreferiti[i]);
}


//Classifico i cibi contenuti nell'array dal + al - buono secondo i miei gusti e li stampo in video

Console.WriteLine("\n Classifica con cinque posizioni \n ");

Console.WriteLine(" 1° Classificato = " + cibiPreferiti[2]);
Console.WriteLine(" 2° Classificato = " + cibiPreferiti[1]);
Console.WriteLine(" 3° Classificato = " + cibiPreferiti[4]);
Console.WriteLine(" 4° Classificato = " + cibiPreferiti[3]);
Console.WriteLine(" 5° Classificato = " + cibiPreferiti[0]);

//Stampo in viedeo il cibo + e - apprezzato secondo classifica 

Console.Write(" \nCIBO PIU' APPREZZATO: " + cibiPreferiti[2] + " \nCIBO MENO APPREZZATO: " + cibiPreferiti[0]);


// BONUS:
/* 
 BONUS
Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana.
Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi dispari. 
In questo caso vanno stampati i 2 elementi in centro alla vostra classifica
*/

// Creo una stringa con i cibi in ordine di classifica per ricavarni successivamente l'elemento miediano 

string[] classifica = { "Pizza", "Pasta al ragù", "Polpettone", "Lasagna", "Nutella" };

// Calcolo i valori centrali (supponendo che l'arrey contenga sempre un totale di elementi disparo)

var cibiMediani = ((classifica.Length - 1) / 2) + 1;

//ANALIZZO VARIE METODICHE PER ESERCITARMI 

// Seleziono l'elemento mediano nella posizione (cibiMediani) appena calcolata sottraendo 1
// sapendo che l'array parte da 0. (1° PROVA "IL PIU LOGICO")


Console.WriteLine($"\nL'ELEMENTO CENTRALE E': {classifica[cibiMediani - 1]}");


// Prova ciclo for (in questo caso è un passaggio in più ) (2° PROVA UTILIZZANDO IL FOR)

/*
for (var i = cibiMediani; i < classifica.Length; i++)
{
    Console.WriteLine($"\nl'elemento centrale è: { classifica[cibiMediani -1] }");
    break;
} 
*/

//Ricavo la posizione tramite un "IF" (3° PROVA )

/*
if(cibiMediani <= classifica.Length)
{
    Console.WriteLine($"\nL'ELEMENTO CENTRALE E': { classifica[cibiMediani -1] }");

}
else
{

}
*/
    

