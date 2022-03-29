

var line = System.IO.File.ReadAllLines("Persons.txt");



var persons2 = line.Select(p=> new Person()
{
    Name=Convert.ToString(p.Split(',')[0].Trim()),
    Age = Convert.ToInt32((p.Split(',')[1].Trim())),
    Datetime = Convert.ToDateTime(p.Split(',')[2].Trim()),
    Addreess = Convert.ToString(p.Split(',')[3].Trim()),
    NationalCode = Convert.ToInt32(p.Split(',')[4].Trim()),
    Id = Convert.ToInt32(p.Split(',')[5].Trim())
    

}).ToList();
//a
var persons3 = persons2.Where(p => p.Age>20).ToList();

//b  
var persons4 = persons2.Where(p => p.Datetime> 1/1/1999).ToList();

//c      
var persons5 = persons2.Where(p => p.Datetime == p.Datetime).ToList();

//d 
var persons6 = persons2.OrderBy(p=> p.Id == 4 ).ToList();

//e
var persons7 = persons2.OrderBy(p => p.Id >50 && p.Id<70).ToList();

//f
var persons8 = persons2.Max(p=>p.Age);

//g
var persons9 = persons2.Where(p=>p.NationalCode == p.NationalCode );

//h
Person obj1 = new();
obj1.Addreess = "Tehran"; 
var persons10 = persons2.Contains(obj1);
//i
var persons11 = persons2.Where(p => p.Name == p.Name).Contains(obj1);

//j
var persons12 = persons2.Where(p => p.NationalCode == 123).ToList();

//k
var persons13 = persons2.Where(p => p.Age > 25  ).Select(p => p.NationalCode, p => p.Addreess).ToList() ;







