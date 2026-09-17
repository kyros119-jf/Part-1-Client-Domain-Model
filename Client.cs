namespace CompanyManagement.Models
{
    public class Client
    {
        public Guid Id;

        public string Name;

        public string Email;

        public DateTime CreatedOn;

        private bool IsActive;

        // Creates a new client with a unique ID and current date
        public Client(string name, string email)
        {

            Name = name;
            Email = email;
            Id = Guid.NewGuid();
            CreatedOn = DateTime.Now;
            IsActive = true;
        }

        // Used when creating a client with existing information
        public Client(Guid id, string name, string email, DateTime createdOn, bool isActive)
        {
            Id = id;
            Name = name;
            Email = email;
            CreatedOn = createdOn;
            IsActive = isActive;
        }
        public string GetSummary()
        {
            string status;

            if (IsActive)
              status = "Active";
            else
                status = "Inactive";

            return $"Client ID: {Id}\nName: {Name}\nEmail: {Email}\nCreated On: {CreatedOn}\nStatus: {status}";
        }


        // Changes the current client's status without creating a new Client
        public void Deactivate()
        {
            IsActive = false;
        }
    }       
}