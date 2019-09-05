using Soz.Data.Entities;

namespace Soz.Web.Models
{
    public class RegisterResponseViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public RegisterResponseViewModel(User user)
        {
            Id = user.Id;
            Name = user.UserName;
            Email = user.Email;
        }
    }
}
