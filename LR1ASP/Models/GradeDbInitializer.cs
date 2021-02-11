using System.Data.Entity;
namespace LR1ASP.Models { 
    public class GradeDbInitializer : DropCreateDatabaseAlways<StudentMarksContext> { 
        protected override void Seed(StudentMarksContext db) { 
            db.Students.Add(new Student { 
                Name = "Дмитро", 
                Surname = "Стрілець", 
                Group = "ІПЗс-19-1",
                Course = 2,
                English = 3,
                Math = 4,
                WebProgramming = 3
            });
            db.Students.Add(new Student {
                Name = "Катерина",
                Surname = "Дрищ",
                Group = "ІПЗс-19-1",
                Course = 2,
                English = 5,
                Math = 5,
                WebProgramming = 5
            }); 
            db.Students.Add(new Student {
                Name = "ГОльга",
                Surname = "Кирилюк",
                Group = "ІПЗс-19-1",
                Course = 2,
                English = 5,
                Math = 5,
                WebProgramming = 5
            }); 
            base.Seed(db); 
        } 
    } 
}