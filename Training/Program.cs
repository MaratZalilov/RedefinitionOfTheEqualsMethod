using Training;

Employee employee1 = new ("Иван","Петров","Завод");
Employee employee2 = new ("Иван", "Петров", "Завод");

//if(employee1 == employee2)
//{
//    check = true;  
//}
//else
//{
//    check = false;
//}
Console.WriteLine(employee1.Equals(employee2));
