// See https://aka.ms/new-console-template for more information
using System;
using System.Numerics;

Console.WriteLine("Hello, World!");
Console.WriteLine();
Console.WriteLine("objektorientead programmering");
Console.WriteLine("C# är ett objektorienterat språk");
Console.WriteLine("fryra grundlägande principer");

Console.WriteLine("1. inkapsling");
Console.WriteLine("2. arv");
Console.WriteLine("3. polymorfism");
Console.WriteLine("4. abstraktion");

Console.WriteLine();
Console.WriteLine("inkapsling");
Console.WriteLine("att gömma data och metoder i en klass");
Console.WriteLine("för att skydda data från oönskad åtkomst");
Console.WriteLine("exempel: privata fält och publika metoder");

Console.WriteLine();
Console.WriteLine("arv");
Console.WriteLine("en klass kan ärva från en annan klass");
Console.WriteLine("för att återanvända kod och skapa hierarkier");
Console.WriteLine("exempel: en 'Bil' klass kan ärva från en 'Fordon' klass");

Console.WriteLine();
Console.WriteLine("polymorfism");
Console.WriteLine("samma metod kan ha olika beteenden beroende på objektet");
Console.WriteLine("för att öka flexibiliteten och återanvändbarheten");
Console.WriteLine("exempel: en 'Djur' klass kan ha en 'Ljud' metod som beter sig olika för 'Hund' och 'Katt'");

Console.WriteLine();
Console.WriteLine("abstraktion");
Console.WriteLine("att skapa abstrakta klasser och gränssnitt");
Console.WriteLine("för att definiera gemensamma egenskaper och beteenden");
Console.WriteLine("exempel: en 'Form' abstrakt klass kan ha en 'Rita' metod som implementeras av 'Cirkel' och 'Rektangel' klasser");

Console.WriteLine();
Console.WriteLine("sammanfattning");
Console.WriteLine("objektorientead programmering är en kraftfull metodik");
Console.WriteLine("C# är ett objektorienterat språk");
Console.WriteLine("de fyra grundläggande principerna är inkapsling, arv, polymorfism och abstraktion");
Console.WriteLine("genom att använda dessa principer kan vi skapa robusta och underhållbara applikationer");

Console.WriteLine();
// Overloading //
Console.WriteLine("metod överlagring");
Console.WriteLine("samma metodnamn med olika parametrar");
Console.WriteLine("för att öka läsbarheten och användarvänligheten");
Console.WriteLine("exempel: en 'Add' metod som kan ta två heltal eller två flyttal");

Console.WriteLine();
Console.WriteLine("exempel på metod överlagring");
Console.WriteLine("Add(2, 3) = " + Add(2, 3)); // anropar Add metoden med två heltal    
Console.WriteLine("Add(2.5, 3.5) = " + Add2(2.5, 3.5)); // anropar Add metoden med två flyttal
Console.WriteLine("Add(2, 3, 4) = " + Add3(2, 3, 4)); // anropar Add metoden med tre heltal  
Console.WriteLine("Add(2.5, 3.5, 4.5) = " + Add4(2.5, 3.5, 4.5)); // anropar Add metoden med tre flyttal
Console.WriteLine("Add(2, 3.5) = " + Add(2, 3)); // anropar Add metoden med ett heltal och ett flyttal
Console.WriteLine("Add(2.5, 3) = " + Add(2, 3)); // anropar Add metoden med ett flyttal och ett heltal
Console.WriteLine("Add(\"Hello, \", \"World!\") = " + Add7("Hello, ", "World!")); // anropar Add metoden med två strängar

Console.WriteLine();
Console.WriteLine("Operator ovelaoding");
Console.WriteLine("samma operator med olika operandtyper");
Console.WriteLine("för att öka läsbarheten och användarvänligheten");
Console.WriteLine("exempel: en '+' operator som kan användas för att addera heltal, flyttal och strängar");
Console.WriteLine();
// Exempel på operator överlagring
Console.WriteLine("2 + 3 = " + (2 + 3)); // adderar två heltal
Console.WriteLine("2.5 + 3.5 = " + (2.5 + 3.5)); // adderar två flyttal
Console.WriteLine("\"Hello, \" + \"World!\" = " + ("Hello, " + "World!")); // adderar två strängar
Console.WriteLine("new Vector2(2, 3) + new Vector2(4, 5) = " + (new Vector2(2, 3) + new Vector2(4, 5))); // adderar två Vector2 objekt

Console.WriteLine();
// Metod överlagring exempel
static int Add(int a, int b) // metod som adderar två heltal
{
    return a + b;
}
static double Add2(double a, double b) // metod som adderar två flyttal
{
    return a + b;
}
static int Add3(int a, int b, int c) // metod som adderar tre heltal
{
    return a + b + c;
}
static double Add4(double a, double b, double c) // metod som adderar tre flyttal
{
    return a + b + c;
}
static double Add5(int a, double b) // metod som adderar ett heltal och ett flyttal
{
    return a + b;
}
static double Add6(double a, int b) // metod som adderar ett flyttal och ett heltal
{
    return a + b;
}
static string Add7(string a, string b) // metod som adderar två strängar
{
    return a + b;
}






