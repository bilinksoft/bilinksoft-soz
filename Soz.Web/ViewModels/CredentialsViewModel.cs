using Soz.Web.ViewModels.Validations;

namespace Soz.Web.ViewModels
{
    //[Validator(typeof(CredentialsViewModelValidator))]
    public class CredentialsViewModel  
    {
        public string UserName { get; set; }
        public string Password { get; set; }        
    }
}