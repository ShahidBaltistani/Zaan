namespace Zaan.ViewModel.DTO
{
    public class SignUpDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool RememberMe { get; set; }
        public int RoleId { get; set; }
    }
}
