namespace Balada.Dominio;
public class Funcionario
{
    public string Name { get; set; } 
    public DateTime DateOfBirth { get; set; }
    // Salário anual. Mensal = Salario / 13.3
    public decimal Salary { get; set; }
    public string Role { get; set; }
    public string Departament { get; set; }
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
