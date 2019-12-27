using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstEFCore.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Courses(CourseName) VALUES ('Math')");
            migrationBuilder.Sql("INSERT INTO Courses(CourseName) VALUES ('History')");
            migrationBuilder.Sql("INSERT INTO Courses(CourseName) VALUES ('Philosophy')");
            migrationBuilder.Sql("INSERT INTO Courses(CourseName) VALUES ('Geography')");
            migrationBuilder.Sql("INSERT INTO Courses(CourseName) VALUES ('Chemistry')");
            migrationBuilder.Sql("INSERT INTO Courses(CourseName) VALUES ('Literature')");

            migrationBuilder.Sql("INSERT INTO Classes(ClassName) VALUES ('1A')");
            migrationBuilder.Sql("INSERT INTO Classes(ClassName) VALUES ('2A')");
            migrationBuilder.Sql("INSERT INTO Classes(ClassName) VALUES ('3A')");
            migrationBuilder.Sql("INSERT INTO Classes(ClassName) VALUES ('4A')");

            migrationBuilder.Sql("INSERT INTO Students(FirstName, LastName, Score, ClassId) VALUES ('Nguyen','Tien',8,(Select Id From Classes where ClassName='1A'))");
            migrationBuilder.Sql("INSERT INTO Students(FirstName, LastName, Score, ClassId) VALUES ('Huynh','Nhu',6,(Select Id From Classes where ClassName='1A'))");
            migrationBuilder.Sql("INSERT INTO Students(FirstName, LastName, Score, ClassId) VALUES ('Nguyen','Trang',4,(Select Id From Classes where ClassName='1A'))");
            migrationBuilder.Sql("INSERT INTO Students(FirstName, LastName, Score, ClassId) VALUES ('Hoang','Thuong',2,(Select Id From Classes where ClassName='2A'))");
            migrationBuilder.Sql("INSERT INTO Students(FirstName, LastName, Score, ClassId) VALUES ('Duong','Trung',5,(Select Id From Classes where ClassName='2A'))");
            migrationBuilder.Sql("INSERT INTO Students(FirstName, LastName, Score, ClassId) VALUES ('Kim','Hoang',9,(Select Id From Classes where ClassName='2A'))");
            migrationBuilder.Sql("INSERT INTO Students(FirstName, LastName, Score, ClassId) VALUES ('Nguyen','Duc',10,(Select Id From Classes where ClassName='3A'))");
            migrationBuilder.Sql("INSERT INTO Students(FirstName, LastName, Score, ClassId) VALUES ('Thien','Tam',3,(Select Id From Classes where ClassName='3A'))");
            migrationBuilder.Sql("INSERT INTO Students(FirstName, LastName, Score, ClassId) VALUES ('Nguyen','Hai',6,(Select Id From Classes where ClassName='3A'))");
            migrationBuilder.Sql("INSERT INTO Students(FirstName, LastName, Score, ClassId) VALUES ('Vuong','Tinh',7,(Select Id From Classes where ClassName='4A'))");
            migrationBuilder.Sql("INSERT INTO Students(FirstName, LastName, Score, ClassId) VALUES ('Phung','Oai',7,(Select Id From Classes where ClassName='4A'))");
            migrationBuilder.Sql("INSERT INTO Students(FirstName, LastName, Score, ClassId) VALUES ('Nhan','Thanh',2,(Select Id From Classes where ClassName='4A'))");

            migrationBuilder.Sql("INSERT INTO Teachers(TeacherName, ClassId) VALUES ('Mr.Joley',(Select Id From Classes where ClassName='1A'))");
            migrationBuilder.Sql("INSERT INTO Teachers(TeacherName, ClassId) VALUES ('Ms.John',(Select Id From Classes where ClassName='2A'))");
            migrationBuilder.Sql("INSERT INTO Teachers(TeacherName, ClassId) VALUES ('Ms.Harley',(Select Id From Classes where ClassName='3A'))");
            migrationBuilder.Sql("INSERT INTO Teachers(TeacherName, ClassId) VALUES ('Mr.Jack',(Select Id From Classes where ClassName='4A'))");

            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Tien'),(Select Id From Courses where CourseName='History'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Tien'),(Select Id From Courses where CourseName='Philosophy'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Nhu'),(Select Id From Courses where CourseName='Math'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Nhu'),(Select Id From Courses where CourseName='Literature'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Trang'),(Select Id From Courses where CourseName='Geography'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Trang'),(Select Id From Courses where CourseName='Chemistry'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Thuong'),(Select Id From Courses where CourseName='Math'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Thuong'),(Select Id From Courses where CourseName='History'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Trung'),(Select Id From Courses where CourseName='Math'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Trung'),(Select Id From Courses where CourseName='Philosophy'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Hoang'),(Select Id From Courses where CourseName='Geography'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Hoang'),(Select Id From Courses where CourseName='Chemistry'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Duc'),(Select Id From Courses where CourseName='Geography'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Duc'),(Select Id From Courses where CourseName='Literature'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Tam'),(Select Id From Courses where CourseName='Math'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Tam'),(Select Id From Courses where CourseName='History'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Hai'),(Select Id From Courses where CourseName='History'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Hai'),(Select Id From Courses where CourseName='Geography'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Tinh'),(Select Id From Courses where CourseName='Math'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Tinh'),(Select Id From Courses where CourseName='Chemistry'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Oai'),(Select Id From Courses where CourseName='Geography'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Oai'),(Select Id From Courses where CourseName='History'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Thanh'),(Select Id From Courses where CourseName='Philosophy'))");
            migrationBuilder.Sql("INSERT INTO StudentCourses(StudentId, CourseId) VALUES ((Select Id From Students where LastName='Thanh'),(Select Id From Courses where CourseName='Math'))");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
