// See https://aka.ms/new-console-template for more information


// uued andmetüübid: int ja char
// rakendus küsib sugu (m/f)
// rakendus küsib sisestada perekonnanimi
// lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");
char userGender = Char.Parse(Console.ReadLine()); // chariga loeb konsoolist maha ikka string formaadis
Console.WriteLine("Please enter your last name:");

string userLastName = Console.ReadLine();


if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}

