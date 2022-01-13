// See https://aka.ms/new-console-template for more information
using VismaTask;


bool exit = false;
int selection = 0;

DB.Load();//duomenu uzkrovimas

while (!exit)
{
    Console.WriteLine("Pasirinkimai:");
    Console.WriteLine("1 - Prideti nauja susitikima");
    Console.WriteLine("2 - Istrinti susitikima");
    Console.WriteLine("3 - Prideti zmogu priessitikimo");
    Console.WriteLine("4 - Isimti zmogu is susitikimo");
    Console.WriteLine("5 - Perziureti visus susitikimus");
    Console.WriteLine("6 - Baigti programa");

    if(!int.TryParse(Console.ReadLine(), out selection)||selection>6||selection<1)//jei nepavyksta ivesti,tuomet spausdinsim errora
    { //
        Console.Clear();
        Console.WriteLine("Netinkamai ivestas pasirinkimas");
        continue; //soks vel nuo pradziu
    }
    switch (selection)
    {
        case 1:MeetingControler.Create();
            break;
        case 2:MeetingControler.Delete();
            break;
        case 3:MeetingControler.AddPerson();
            break;
        case 4:MeetingControler.RemovePerson();
            break;
        case 5: MeetingControler.GetAll();
            break;
        default:
            Console.Clear(); //ivedus 6 isvalo viska, nes selection ivesta nuo 1 iki 6.
            exit=true;
            break;



    }



}