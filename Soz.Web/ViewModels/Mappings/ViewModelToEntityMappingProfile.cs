using AutoMapper;
using Soz.Data.Entities;

namespace Soz.Web.ViewModels.Mappings 
{
    public class ViewModelToEntityMappingProfile : Profile
    {
        public ViewModelToEntityMappingProfile()
        {
              CreateMap<RegistrationViewModel,User>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
        }
    }
}