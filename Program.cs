using CompanyManagement.Models;

public class Program
{
    static void Main (string[] args)
    {
        // Create two separate Client objects
        Client myclient1 = new Client("Jeremy", "jeremy.frank@students.snow.edu");
        Client myclient2 = new Client("Anna", "annaisacoolmom@gmail.com");


        // Deactivate only the first client
        myclient1.Deactivate();

        Console.WriteLine(myclient1.GetSummary());

        Console.WriteLine(myclient2.GetSummary());
        
    }  
}
