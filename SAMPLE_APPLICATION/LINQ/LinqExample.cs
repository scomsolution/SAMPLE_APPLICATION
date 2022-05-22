using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMPLE_APPLICATION.LINQ
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

    class LinqExample
    {
        IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } };

        public void Where()
        {
            var filteredResult = studentList.Where(s => s.Age > 12 && s.Age < 20);

            filteredResult = studentList.Where((s, i) => {
                if (i % 2 == 0) // if it is even element
                    return true;

                return false;
            });

            filteredResult = studentList.Where(s => s.Age > 12).Where(s => s.Age < 20);
        }

        public void OfType() { }
        public void OrderBy() { }
        public void OrderByDescending() { }
        public void ThenBy() { }
        public void ThenByDescending() { }
        public void GroupBy() { }
        public void ToLookup() { }
        public void Join() { }
        public void GroupJoin() { }
        public void Select() { }
        public void SelectMany() { }
        public void All_Any() { }
        public void Contains() { }
        public void Aggregate() { }
        public void Average() { }
        public void Count() { }
        public void LongCount() { }
        public void Max() { }
        public void Min() { }
        public void Sum() { }
        public void ElementAt() { }
        public void ElementAtOrDefault() { }
        public void First() { }
        public void FirstOrDefault() { }
        public void Last() { }
        public void LastOrDefault() { }
        public void Single() { }
        public void SingleOrDefault() { }
        public void SequenceEqual() { }
        public void Concat() { }
        public void DefaultIfEmpty() { }
        public void Empty() { }
        public void Range() { }
        public void Repeat() { }
        public void Distinct() { }
        public void Except() { }
        public void Intersect() { }
        public void Union() { }
        public void Skip() { }
        public void SkipWhile() { }
        public void Take() { }
        public void TakeWhile() { }
        public void AsEnumerable() { }
        public void AsQueryable() { }
        public void Cast() { }
        public void ToArray() { }
        public void ToDictionary() { }
        public void ToList() { }
        public void ToLookup_1() { }
    }
}
