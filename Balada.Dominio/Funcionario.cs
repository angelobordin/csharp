namespace Balada.Dominio;
public class Funcionario
{
    public string Name { get; private set; } 
    public DateTime DateOfBirth { get; private set; }
    public decimal Salary { get; private set; }
    public decimal Wage { get => Salary * 13.3m; }
    public string Role { get; private set; }
    public string Departament { get; private set; }
    public int Age { get
        {
            DateTime now = DateTime.Now;
            int age = now.Year - DateOfBirth.Year;
            if (now.DayOfYear < DateOfBirth.DayOfYear) age--;

            return age;
        }
    }

    public Funcionario(string name, DateTime dateOfBirth, string role,  decimal salary, string departament)
    {
        Name = name;
        DateOfBirth = dateOfBirth;
        Role = role;
        Salary = salary;
        Departament = departament;
    }
}
