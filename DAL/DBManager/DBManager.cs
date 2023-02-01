namespace MyWebApi.DAL;
using  MyWebApi.Models;
public class DBManager
{
    public static List<Employee>GetAll()
    {
        List<Employee>employees=new List<Employee>();
        employees.Add(new Employee{Id=1, FirstName="Manav", LastName="Kon", Email="mk@gmail.com",ContactNumber="9834324505"});
       employees.Add(new Employee{Id=2, FirstName="Rakus", LastName="Lanka", Email="rl@gmail.com",ContactNumber="9656546162"});
       employees.Add(new Employee{Id=3, FirstName="Lakhan", LastName="Pandey", Email="lp@gmail.com",ContactNumber="9897969594"});
       return employees;
    }

    public static Employee GetById(int id)
    {
        Employee emp=new Employee{Id=id, FirstName="Manav",
                    LastName="Kon", Email="mk@gmail.com",
                    ContactNumber="9834324505"};
        return emp;
    }

    public static bool DeleteById(int Id)
    {
        bool status=true;
        return status;
    }

     public static bool Update(int Id,Employee emp)
    {
        bool status=true;
        return status;
    }

     public static bool Insert(Employee emp)
    {
        bool status=true;
        Console.WriteLine(emp.FirstName+" "+emp.LastName);
        return status;
    }
    
    
}
