//Manuel Leyva
//10-20-22
//Resturant Picker
//You have your choice of choosing 3 types style foods to eat, so you the user will
//be able to pick the style of food they wanna eat
//Peer Review:

Console.Clear();
string iChoice = "";

do{
Console.Clear();
Console.WriteLine(" So it seems like you cant decide what to eat, lucky for you I got you ");
Console.WriteLine("1 - Fast Food");
Console.WriteLine("2 - Mexican Food");
Console.WriteLine("3 - Chinese Food");


int option ;
bool mNumber = false;


mNumber = Int32.TryParse(Console.ReadLine(), out option);

while (option != 1 &&  option != 2 && option !=3)
{
    Console.WriteLine("Please enter 1, 2, or 3");
    mNumber = Int32.TryParse(Console.ReadLine(), out option);    
}


if (option == 1){
Console.WriteLine(" So You choose Fast Food ");
 
string[] fFood = {" McDonalds ", " Wendys ", " Taco Bell ", " A&W ", " KFC ", " Dairy Queen ", " Burger King ", " SubWay ", " Popeyes ", " Raise n Canes"};
Random random = new Random();
int rPicker = random.Next(0,11);
Console.WriteLine(" So your Fast Food Spot wiil be " + fFood[rPicker]);
}  


else if(option ==2){
Console.WriteLine(" So You Choose Mexican Food, The Right Choice ");
 
string[] mfood = {" El Foresto ", " Tacos Chapala ", " Pollo Local ", " Don Rafas ", " King Taco ", " Casa Flores ", " la tapitia ", " Nena's ", " Tacos El Pelon ", " Mi Ranchito Cafe "};
Random random = new Random();
int rPicker = random.Next(0,11);
Console.WriteLine(" Your Mexican spot will be  " + mfood[rPicker]);

}

 
else if (option ==3)
{
string[] cfood = {" China Palace ", " Golden Star ", " China Express ", " Louie's Chinese Resturant ", " Sun's Garden ", " Shermans Buffet ", " Panda Express ", " Yen Du Resturant ", " China Work Express ", " Luu's Chicken Bowl "};
Random random = new Random();
int rPicker = random.Next(0,11);
Console.WriteLine(" So your Chinese spot will be " + cfood[rPicker]);
}


do
{
   Console.WriteLine("Bro do you wanna run this program again, Yes or No ");
   iChoice = Console.ReadLine().ToUpper();
   if(iChoice != "Yes" && iChoice != "NO")
   {
       Console.WriteLine(" Dude i said Yes or No, not numbers bro ");
   }
}while (iChoice !="YES" && iChoice != "NO");
}while(iChoice == "YES");