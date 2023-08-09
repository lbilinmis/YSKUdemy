namespace YSKUdemy.BankApp.Data.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
