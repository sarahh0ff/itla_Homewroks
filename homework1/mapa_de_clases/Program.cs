namespace mapa_de_clases
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudiante estudiante = new Estudiante
            {
                Name = "Sarah",
                LastName = "Figuereo",
                Id = 100745875,
                Role = "Student",
                Email = "SarahFiguereo@gmail.com",
                PhoneNumber = "809-555-5555",
                Age = 19,
                Address = "Calle Falsa 123",
                Major = "Ingeniería",
                Year = 1,
                GPA = 3.7
            };

            estudiante.getFullName();
            estudiante.getDetails();

            ExAlumno exAlumno = new ExAlumno
            {
                Name = "Carlos",
                LastName = "Pérez",
                Id = 100123456,
                Role = "Ex-Student",
                Email = "Carlos@gmail.com",
                PhoneNumber = "809-555-1234",
                Age = 22,
                Address = "Avenida Siempre Viva 456",
                GraduationYear = 2022,
                CurrentEmployer = "TechCorp",
                JobTitle = "Software Engineer"

            };
            Console.WriteLine();
            Console.WriteLine("================================"); 
            Console.WriteLine();
            exAlumno.getFullName();
            exAlumno.getDetails();

            Administrativo administrativo = new Administrativo
            {
                Name = "Luis",
                LastName = "Martínez",
                Id = 100654321,
                Role = "Administrative Staff",
                Email = "hola@gmail.com",
                PhoneNumber = "809-555-4321",
                Age = 28,
                Address = "Calle Secundaria 456",
                Department = "Finance",
                Position = "Accountant",
                Salary = 50000,
                authority_level = "Medium",
                ext_number = 1234,
            };
            Console.WriteLine();    
            Console.WriteLine("================================");
            Console.WriteLine();
            administrativo.getFullName();
            administrativo.getDetails();




            Administrador administrador = new Administrador
            {
                Name = "Ana",
                LastName = "Gómez",
                Id = 100987654,
                Role = "Administrator",
                Email = "Ana@gmail.com",
                PhoneNumber = "809-555-6789",
                Age = 35,
                Address = "Boulevard Central 789",
                Area = "Human Resources",
                YearsOfExperience = 10,
                AcademicTitle = "MBA",
                Department = "IT",
                Position = "IT Manager",
                team_in_charge = 10,
                Salary = 75000,
                office = "Room 101"
                };

            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine();
            administrador.getFullName();
            administrador.getDetails();

            Maestro maestro = new Maestro
            {
                Name = "Marcos",
                LastName = "Encarnacion",
                Id = 100456789,
                Role = "Teacher",
                Email = "Marcos@gmail.com",
                PhoneNumber = "809-555-9876",
                Age = 21,
                Address = "Calle Principal 321",
                Subject = "Mathematics",
                YearsOfExperience = 3,
                AcademicTitle = "MSc in Mathematics",
                Area = "Sciences",
                Department = "Mathematics",
                Position = "Lecturer",
                NumberOfStudents = 30,
                Salary = 55000,
                };
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine();
            maestro.getFullName();
            maestro.getDetails();

        }
    }
}
