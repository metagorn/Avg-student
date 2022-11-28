// See https://aka.ms/new-console-template for more information
using WorkAvg;

Student student1 = new Student();
student1.Name = "P";
student1.weight = 110;

Student student2 = new Student();
student2.Name = "Mine";
student2.weight = 45;

Student student3 = new Student();
student3.Name = "Zack";
student3.weight = 66;

Student student4 = new Student();
student4.Name = "Ger";
student4.weight = 52;

Student student5 = new Student();
student5.Name = "Ice";
student5.weight = 50;






double avgwight = (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight) / 5;
Console.WriteLine("Average weight of 5 friends are : " + avgwight);
Console.WriteLine("Most Weight : " + student1.weight);
Console.WriteLine("Less Weight : " + student2.weight);
