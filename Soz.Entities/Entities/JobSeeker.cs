
namespace Soz.Data.Entities
{
    public class JobSeeker  
    {
        public int Id { get; set; }     
        public string IdentityId { get; set; }   
        public User Identity { get; set; }  // navigation property
        public string Location {get;set;}
    }
}