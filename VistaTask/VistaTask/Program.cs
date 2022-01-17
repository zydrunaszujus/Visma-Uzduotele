// See https://aka.ms/new-console-template for more information
using VismaTask;


bool exit = false;
int selection = 0;

DB.Load();//duomenu uzkrovimas
//var variants=new strin[]
var selections = new string[]
{
    "Prideti nauja susitikima",//pagal aprasytus elemenatus ismes uzrasus,
    "Istrinti susitikima",
    "Prideti zmugu prie susitikimo",//atitinka var actions eiliskuma
    "Isimti zmogu is susitikimo",
    "Perziureti susitikimus",
    "Baigti programa"
};

var actions = new Action[] //action aprasymas ir priskirti metodai pagal eiliskumo indeksa
{//ation yr iskviestas UI_Helper
    ()=>MeetingControler.Create(),//1 ()=>lamda metodas-anoniminis metodas,jurio nenorim pernaudot
    ()=>MeetingControler.Delete(),//2
    ()=>MeetingControler.AddPerson(),//3
    ()=>MeetingControler.RemovePerson(),//4
    ()=>MeetingControler.GetAll(),//5
    ()=>{Console.Clear(); exit= true; }//6
    //galima ir be lambda anoniminiu metodo israisku
    //MeetingControler.Create, ir t.t.
};
 //DB.Load();

while (!exit)//priskiriamas prie uiversalaus helperio
{
UI_Helper.UniversalSelectPrompt(selections,actions);//iskviesta klase su objektais

}



//cia pradzia buvo,bet ivedeme funkcija auksciau.
//kiekvieno pasirinkimo dalis,reikalinga pasirinkimui ivygdyti

//while (!exit)
//{

//selection=UI_Helper.AskForSelection(variants)
//    Console.WriteLine("Pasirinkimai:");
//    Console.WriteLine("1 - Prideti nauja susitikima");
//    Console.WriteLine("2 - Istrinti susitikima");
//    Console.WriteLine("3 - Prideti zmogu priessitikimo");
//    Console.WriteLine("4 - Isimti zmogu is susitikimo");
//    Console.WriteLine("5 - Perziureti visus susitikimus");
//    Console.WriteLine("6 - Baigti programa");

//    if(!int.TryParse(Console.ReadLine(), out selection)||selection>6||selection<1)//jei nepavyksta ivesti,tuomet spausdinsim errora
//    { //
//        Console.Clear();
//        Console.WriteLine("Netinkamai ivestas pasirinkimas");
//        continue; //soks vel nuo pradziu
//    }
//    switch (selection)
//    {
//        case 0:MeetingControler.Create();
//            break;
//        case 1:MeetingControler.Delete();
//            break;
//        case 2:MeetingControler.AddPerson();
//            break;
//        case 3:MeetingControler.RemovePerson();
//            break;
//        case 4: MeetingControler.GetAll();
//            break;
//        default:
//            Console.Clear(); //ivedus 6 isvalo viska, nes selection ivesta nuo 1 iki 6.
//            exit=true;
//            break;



//    }



//}
//       jei pasirenki 0,tai vykdo situos veiksmus:
//selection = UI_Helper.AskForSelection(loginVariants);

//switch (selection)
//{
//    case 0:
//        MeetingController.Login();
//        break;
//    default:
//        MeetingController.Register();
//        break;
//}
//