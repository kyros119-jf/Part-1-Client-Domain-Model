using CompanyManagement.Models;
using CompanyManagement.Services;

public class Program
{
    static void Main(string[] args)
    {
        // Create two separate Client objects
        Client myclient1 = new Client("Jeremy", "jeremy.frank@students.snow.edu");
        Client myclient2 = new Client("Anna", "annaisacoolmom@gmail.com");
        ClientRepository clientRepository = new ClientRepository();


        clientRepository.AddClient(myclient1);
        clientRepository.AddClient(myclient2);

        // Deactivate only the first client
        myclient1.Deactivate();

        List<Client> allClients = clientRepository.GetAllClients();
        List<Client> activeClients = clientRepository.GetActiveClients();
        Client? foundClient = clientRepository.GetClientById(myclient2.Id);



        Console.WriteLine("All Clients:");

        foreach (Client client in allClients)
        {
            Console.WriteLine(client.GetSummary());
        }


        Console.WriteLine("\nActive Clients:");

        foreach (Client client in activeClients)
        {
           Console.WriteLine(client.GetSummary());
        }


        Console.WriteLine("\nClient Lookup:");

        if (foundClient != null)
        {
            Console.WriteLine(foundClient.GetSummary());
        }   

        Console.WriteLine(myclient2.GetSummary()); 
    }  
}