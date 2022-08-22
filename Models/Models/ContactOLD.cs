namespace Models.Models
{
    public class ContactOLD 
    {
        //The class for the contacts
        public int Id { get; set; }
        public string FName { get; set; } = string.Empty;
        public string LName { get; set; } = string.Empty;
        public string? Nickname { get; set; } = string.Empty;
        public string Organization { get; set; } = string.Empty;
        public string? Address { get; set; } = string.Empty;
        public string? City { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? Phone { get; set; } = string.Empty;
        public string? PostalCode { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime UpdatedOn { get; set; } = DateTime.Now;

        public string Combo
        {
            get
            {
                return FName + " " + LName;
            }
        }

        public string Info
        {
            get
            {
                return String.Format("Name: {1} {2}{0}Nickname: {3}{0}" +
                        "Organization: {4}{0}" +
                        "Address: {5} {6}, {7}{0}" +
                        "Postal Code: {10}{0}" +
                        "Phone: {8}{0}" +
                        "Email:{9}",
                        Environment.NewLine,
                        FName,
                        LName,
                        Nickname,
                        Organization,
                        Address,
                        City,
                        Province,
                        Phone,
                        Email,
                        PostalCode);
            }
        }
    }
}
