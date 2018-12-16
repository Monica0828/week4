using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            var listStudents = new List<Student>();
            var listWorkers = new List<Worker>();
            var mergedList = new List<Human>();
            listStudents.Add(new Student("Maria", "Ioana", 2));
            listStudents.Add(new Student("Petrica", "Vasile", 3));
            listStudents.Add(new Student("Ecaterina", "Danca", 9));
            listStudents.Add(new Student("Monica", "Danca", 10));
            listStudents.Add(new Student("Marinela", "Popescu", 10));
            listStudents.Add(new Student("Marinela", "Vasilescu", 4));
            listStudents.Add(new Student("Stefan", "Ciobanu", 5));
            listStudents.Add(new Student("Gisela", "Farcas", 7));
            listStudents.Add(new Student("Gisela", "Solomon", 8));
            listStudents.Add(new Student("Ingrid", "Colonescu", 4));

            var orderedStudents = listStudents.OrderBy(s => s.Grade);

            foreach (var s in orderedStudents)
            {
                Console.WriteLine(s.Grade);
            }
            listWorkers.Add(new Worker("Ingrid", "Colonescu", 100, 6));
            listWorkers.Add(new Worker("Alexandra", "Tabacariu", 1000, 4));
            listWorkers.Add(new Worker("Vlad", "Tabacariu", 88, 6));
            listWorkers.Add(new Worker("Alina", "Chelariu", 50, 8));
            listWorkers.Add(new Worker("Ciprian", "Chelaru", 15, 10));
            listWorkers.Add(new Worker("Rares", "Rares", 28, 6));
            listWorkers.Add(new Worker("Rares", "Cadar", 78, 7));
            listWorkers.Add(new Worker("Rares", "Ciobanu", 55, 9));
            listWorkers.Add(new Worker("Gabriel", "Ciobanu", 39, 6));
            listWorkers.Add(new Worker("Radu", "Popa", 899, 3));

            var orderedWorkers = listWorkers.OrderByDescending(w => w.MoneyPerHour());

            foreach (var w in orderedWorkers)
            {
                Console.WriteLine(w.MoneyPerHour());
            }
            mergedList.AddRange(listStudents);
            mergedList.AddRange(listWorkers);
            var orderedMergeList = mergedList.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
            foreach (var x in orderedMergeList)
            {
                Console.Write(x.FirstName + " ");
                Console.WriteLine(x.LastName);
            }
            Console.ReadKey();
        }
    }
}
