// See https://aka.ms/new-console-template for more information
// variables
string word = "string";
int num = 66;
double decmal = 66.06;
//date time
DateTime now = DateTime.Now;
DateTime today = DateTime.Today;
int day = now.Day;
int month = now.Month;
int year = now.Year;
int hours = now.Hour;
int minutes = now.Minute;
int seconds = now.Second;  

//boolean
bool sith = true;
bool jedi = false;

Console.WriteLine("Chemical Brothers & The Crystal Method!");
Console.WriteLine(word + " " + num + Environment.NewLine + decmal);
Console.WriteLine(sith);
Console.WriteLine(jedi);
Console.WriteLine(now);
Console.WriteLine(today);
Console.WriteLine(day);
Console.WriteLine(month);
Console.WriteLine(year);
Console.WriteLine(hours);
Console.WriteLine(minutes);
Console.WriteLine(seconds);