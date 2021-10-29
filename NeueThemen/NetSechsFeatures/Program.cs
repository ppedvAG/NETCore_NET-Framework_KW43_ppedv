// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region PrioityQueue
#region Queue
Queue<string> names = new Queue<string>();
names.Enqueue("Alex");
names.Enqueue("Leah");
names.Enqueue("Haley");
names.Enqueue("Harvey");

names.Dequeue(); //Alex
names.Dequeue(); //Leah
names.Dequeue(); //Haley
#endregion

#region PriorityQueue Sample1
PriorityQueue<string, int> priorityWords = new();

priorityWords.Enqueue("Leah", 2);
priorityWords.Enqueue("Harvey", 4);
priorityWords.Enqueue("Haley", 3);
priorityWords.Enqueue("Alex", 1);

Console.WriteLine(priorityWords.Dequeue()); //Alex
Console.WriteLine(priorityWords.Dequeue()); //Leah
Console.WriteLine(priorityWords.Dequeue()); //Haley
Console.WriteLine(priorityWords.Dequeue()); //Harvey
#endregion

#region PriorityQueue Sample 2
public enum ShowRating
{
    Transcendant, //1
    Amazing, //2
    Good, //3
    OK //4
}

var tvShows = new PriorityQueue<string, ShowRating>();

tvShows.Enqueue("Modern Family", ShowRating.Good);
tvShows.Enqueue("Ted Lasso", ShowRating.Amazing);
tvShows.Enqueue("MasterChef", ShowRating.Good);
tvShows.Enqueue("Breaking Bad", ShowRating.Transcendant);
tvShows.Enqueue("Happy Endings", ShowRating.Amazing);
tvShows.Enqueue("Game of Thrones (Seasons 1-6)", ShowRating.Amazing);
tvShows.Enqueue("Game of Thrones (Seasons 7-8)", ShowRating.OK);
tvShows.Enqueue("How to Get Away with Murder", ShowRating.Good);
tvShows.Enqueue("Hell's Kitchen", ShowRating.OK);

Console.WriteLine("What should we watch?");
var currentShow = tvShows.Dequeue();

//The shows will be dequeued in order of the ShowRating value
Console.WriteLine($"Let's try {currentShow}!");

while (tvShows.Count > 0)
{
    Console.WriteLine($"If not, let's try {tvShows.Dequeue()}.");
}
#endregion

#endregion


#region DateTime
var myDate = new DateTime(2021, 9, 23);
var datePart = DateTime.Now.Date;

#endregion


#region NewImplementation

DateOnly sep10th = new DateOnly(2021, 9, 10);
var dec31st = new DateOnly(1999, 12, 31);
DateOnly aug3rd = new(1988, 8, 3);

TimeOnly nineThirtyPM = new TimeOnly(21, 30); //21:30, or 9:30 PM
TimeOnly fourTwentyThreeAM = new(4, 23, 19); //04:23:19, or 4:23:19 AM

#endregion

#region Converting
DateTime dateOnlyExample = new DateTime(2004, 5, 19, 4, 45, 30);
DateOnly date3 = DateOnly.FromDateTime(dateOnlyExample); //May 19th, 2004

DateTime sevenFortyFiveDT = new DateTime(2011, 11, 11, 7, 45, 00);
TimeOnly sevenFortyFive = TimeOnly.FromDateTime(sevenFortyFiveDT); //07:45 AM
#endregion


#region DateOnly Details
DateOnly cultureExample = new DateOnly(2004, 5, 19); //May 19 2004
Console.WriteLine(cultureExample);
//American: 5/19/2004, European: 19/5/2004, Universal: 2004-05-19
#endregion

#region AddDays(), AddMonths(), AddYears()
DateOnly addTimeExample = new DateOnly(2004, 5, 19); //May 19 2004
addTimeExample = addTimeExample.AddYears(2).AddMonths(2).AddDays(5);
//Jul 24th, 2006
#endregion

#region Parsing from Strings
if (DateOnly.TryParse("09/21/2013", out DateOnly result))
    Console.WriteLine(result);
//American: 9/21/2013, European: 21/9/2013, Universal: 2013-09-21
#endregion

#region Stores Value as Integer
DateOnly integerTest = new(2019, 7, 1); //July 1st 2019
int dayNumber = integerTest.DayNumber;
DateOnly integerResult = DateOnly.FromDayNumber(dayNumber); //July 1st 2019
#endregion





#region TimeOnly Details
#region  Stores Value as Ticks from Midnight
TimeOnly sixTen = new TimeOnly(6, 10);
long ticks = sixTen.Ticks;
TimeOnly sixTenAgain = new TimeOnly(ticks);

#endregion

#region Math Operations result in TimeSpans
var afternoon = new TimeOnly(15, 15); //3:15 PM
var morning = new TimeOnly(9, 10); //9:10 AN
TimeSpan difference = afternoon - morning; //6 hours 5 minutes
#endregion


#region Checking for Value in a Range
var now = TimeOnly.FromDateTime(DateTime.Now);
var nineAM = new TimeOnly(9, 0);
var fivePM = new TimeOnly(17, 0);

if (now.IsBetween(nineAM, fivePM))
    Console.WriteLine("Work time!");
else
    Console.WriteLine("Anything other than work time!");
#endregion

#region Checking for Value in a Range Part2
var tenPM = new TimeOnly(22, 0);
var twoAM = new TimeOnly(2, 0);

var midnight = new TimeOnly(0); //0 ticks == midnight

if (midnight.IsBetween(tenPM, twoAM))
    Console.WriteLine("It's getting late...");
#endregion


#endregion