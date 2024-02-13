using intro.Business;
using intro.Entities;

Console.WriteLine("Hello, World!");
string mssg1 = "Krediler Buraya";
int term = 12;
double ammount = 10000;
bool isAuthenticated = false;
Console.WriteLine(mssg1);

/*
if (isAuthenticated)
{   
    Console.WriteLine("Hoşgeldin");
}
else
{
    Console.WriteLine("Giriş Yap!");
}

string[] loans = { "Kredi1", "Kredi2", "Kredi3" };

for(int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}*/

CourseManager courseManager1 = new();
Course[] kurslar = courseManager1.GetAll();

for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i].Name + " / " + kurslar[i].Price);
}

