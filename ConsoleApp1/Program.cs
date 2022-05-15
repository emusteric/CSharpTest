// See https://aka.ms/new-console-template for more information
// variables
string word = "string";
int num = 66;
double decmal = 66.06;
Console.WriteLine("Chemical Brothers & The Crystal Method!");
Console.WriteLine(word + " " + num + Environment.NewLine + decmal);

//date time
DateTime now = DateTime.Now;
DateTime today = DateTime.Today;
int day = now.Day;
int month = now.Month;
int year = now.Year;
int hours = now.Hour;
int minutes = now.Minute;
int seconds = now.Second;
Console.WriteLine(now);
Console.WriteLine(today);
Console.WriteLine(day);
Console.WriteLine(month);
Console.WriteLine(year);
Console.WriteLine(hours);
Console.WriteLine(minutes);
Console.WriteLine(seconds);
Console.WriteLine("Today is " + today.ToLongDateString());
Console.WriteLine("Tomorrow is " + today.AddDays(1).ToLongDateString());
Console.WriteLine(Environment.UserName);

//boolean
bool sith = true;
bool jedi = false;
Console.WriteLine(sith);
Console.WriteLine(jedi);

//random
Random randomNumbers = new Random();
int number1 = randomNumbers.Next(0, 4);
Console.WriteLine(number1);

string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
Console.WriteLine("Path to Desktop = " + pathToDesktop);

string text = "This is a fun day without smoking";
Console.WriteLine("Original text: " + text);
Console.WriteLine("Number of characters: " + text.Length);
Console.WriteLine("In Uppercase: " + text.ToUpper());
Console.WriteLine("Does is contain the word last: " + text.Contains("last"));

int number = 1234;
string numberAsText = number.ToString();
Console.WriteLine(numberAsText);
