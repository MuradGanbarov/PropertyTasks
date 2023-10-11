// I USED HELP FROM GOOGLE AND CHAT GPT﻿
//TASK 1
//using System;
//using System.Collections.Generic;

//namespace ConsoleApp3
//{

//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Dog myDog = new Dog("Bobik", "PitBull", "Kisi");

//            Console.WriteLine($"Name: {myDog.Name}");
//            Console.WriteLine($"Breed: {myDog.Breed}");
//            Console.WriteLine($"Gender: {myDog.Gender}");
//            Console.WriteLine($"Birrhdate {myDog.BirthDate}");
//        }
//    }
//    public class Animal
//    {


//        public string Gender { get; }
//        public DateTime BirthDate { get; }

//        public Animal(string gender)
//        {
//            Gender = gender;
//            BirthDate = DateTime.Now;
//        }
//    }

//    public class Dog : Animal
//    {
//        public string Name { get; }
//        public string Breed { get; }

//        public Dog(string name, string breed, string gender) : base(gender)
//        {
//            Name = name;
//            Breed = breed;
//        }
//    }



//}

//TASK 2

//namespace TASK2
//{


//    class Program
//    {
//        static void Main()
//        {


//            Student student1 = new Student("Murad", "Qanbarov", 19, true);
//            Student student2 = new Student("Kamran", "Mustafayev", 20, false);



//            Group group1 = new Group("Group A");
//            group1.Add(student1);
//            group1.Add(student2);



//            group1.GetAll();


//            group1.GetOnlineStudents();
//            group1.GetOfflineStudents();
//        }

//    }


//    public class Person
//    {
//        public string Name { get; }
//        public string Surname { get; }
//        public int Age { get; }

//        public Person(string name, string surname, int age)
//        {
//            Name = name;
//            Surname = surname;
//            Age = age;
//        }
//    }

//    public class Student : Person
//    {
//        public bool IsOnline { get; }

//        public Student(string name, string surname, int age, bool isOnline) : base(name, surname, age)
//        {
//            IsOnline = isOnline;
//        }
//    }

//    public class Group
//    {
//        public string GroupName { get; }
//        private List<Student> Students { get; }

//        public Group(string groupName)
//        {
//            GroupName = groupName;
//            Students = new List<Student>();
//        }

//        public void Add(Student student)
//        {
//            Students.Add(student);
//        }

//        public void GetAll()
//        {
//            Console.WriteLine($"{GroupName} Group Students:");
//            foreach (var student in Students)
//            {
//                Console.WriteLine($"{student.Name} {student.Surname} {student.Age}");
//            }
//        }

//        public void GetOnlineStudents()
//        {
//            Console.WriteLine($"Online Students in {GroupName} Group:");
//            foreach (var student in Students)
//            {
//                if (student.IsOnline)
//                {
//                    Console.WriteLine($"{student.Name} {student.Surname}");
//                }
//            }
//        }

//        public void GetOfflineStudents()
//        {
//            Console.WriteLine($"Offline Students in {GroupName} Group:");
//            foreach (var student in Students)
//            {
//                if (!student.IsOnline)
//                {
//                    Console.WriteLine($"{student.Name} {student.Surname}");
//                }
//            }
//        }
//    }

//}

