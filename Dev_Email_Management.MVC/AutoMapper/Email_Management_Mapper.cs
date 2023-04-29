using AutoMapper;
using Dev_Email_Management.Domain.Entities;
using Dev_Email_Management.MVC.DTOs.InputModel;
using Dev_Email_Management.MVC.DTOs.ViewModel;

namespace Dev_Email_Management.MVC.AutoMapper
{
    public class Email_Management_Mapper : Profile
    {
        public Email_Management_Mapper()
        {
            //Modelos de Criação
            CreateMap<AddBusinessInputModel, Business>();
            CreateMap<AddBusinessCityInputModel, BusinessCity>();
            CreateMap<AddBusinessStateInputModel, BusinessState>();
            CreateMap<AddBusinessEmailInputModel, BusinessEmail>();
            CreateMap<AddBusinessPhoneInputModel, BusinessPhone>();

            //Modelos de Leitura - Completa
            CreateMap<Business, BusinessViewModel>();
            CreateMap<BusinessCity, BusinessCityViewModel>();
            CreateMap<BusinessState, BusinessStateViewModel>();
            CreateMap<BusinessEmail, BusinessEmailViewModel>();
            CreateMap<BusinessPhone, BusinessPhoneViewModel>();

            //Modelos de leitura com restrições
        }
    }
}
