//SWITCH

string[] week = { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday", "option" };
//string fylld med alternativ

foreach (string day in week)
{

    switch (day) //OM alternativ finns så gör följande!
    {
        case "monday":
            Console.WriteLine("go to work");
            break;

        case "tuesday":
            Console.WriteLine("go home");
            break;

        case "wednesday":
            Console.WriteLine("wednesday");
            break;

        case "thursday":
            Console.WriteLine("thursday");
            break;

        case "friday":
            Console.WriteLine("friday");
            break;

        case "saturday":
            Console.WriteLine("saturday");
            break;

        case "sunday":
            Console.WriteLine("sunday");
            break;

        default:
            Console.WriteLine("Not an option");
            break;


    }
}
Console.WriteLine("------------");

//LIST

List<string> audi_parts = new List<string>(week) //skickar in week in denna list stringen.
{
    "turbo", "koppling"
};

audi_parts.Add(item: "motor"); // kan också adda items i listan såhär


foreach (string part in audi_parts) //för att gå igenom alla "parts" i audi_parts.
{
    Console.WriteLine(part);


}

//DICTIONARY
        //gör sträng till integer
Dictionary<string, int> nameToBrithYear = new Dictionary<string, int>();
nameToBrithYear.Add("manuel", 2000);
nameToBrithYear.Add("benny", 2010);
nameToBrithYear.Add("johan", 2012);
nameToBrithYear.Add("sven", 2015);

Console.WriteLine(nameToBrithYear["benny"]);

nameToBrithYear["benny"] = 2001;

Console.WriteLine(nameToBrithYear["benny"]);

nameToBrithYear.Add("X", 0);
nameToBrithYear.Add("Y", 3);
nameToBrithYear.Add("Z", 6);


Console.WriteLine("------------");


string? choice = Console.ReadLine().ToLower();

if (nameToBrithYear.ContainsKey(choice))
{
    Console.WriteLine(nameToBrithYear[choice]);
}
else
{
    Console.WriteLine("We do not store that information.");
}


switch (nameToBrithYear.ContainsKey(choice)) //OM alternativ finns så gör följande!
{
    case true:
        Console.WriteLine("the birth year is: " + nameToBrithYear[choice]);
        break;

    case false:
        Console.WriteLine("Sorry this wasn't correct.");
        break;

}




