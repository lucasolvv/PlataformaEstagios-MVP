using AutoMapper;
using PlataformaEstagios.Domain.Dtos;
using PlataformaEstagios.Domain.Models;

namespace PlataformaEstagios.Application.Services.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping() { }

        private void RequestToDomain()
        {
            CreateMap<UserDto, User>()
                .ForMember(dest => dest.UserId, opt => opt.Ignore())
                .ForMember(dest => dest.NickName, opt => opt.MapFrom(src => src.Nickname))
                .ForMember(dest => dest.PasswordHash, opt => opt.Ignore())
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.UserType, opt => opt.MapFrom(src => src.TipoUsuario));

            CreateMap<EnterpriseDto, Enterprise>()
                .ForMember(dest => dest.UserId, opt => opt.Ignore())
                .ForMember(dest => dest.EnterpriseName, opt => opt.MapFrom(src => src.NomeFantasia))
                .ForMember(dest => dest.ActivityArea, opt => opt.MapFrom(src => src.AreaAtuacao))
                .ForMember(dest => dest.Cnpj, opt => opt.MapFrom(src => src.Cnpj))
                .ForMember(dest => dest.EnterpriseId, opt => opt.Ignore())
                .ForMember(dest => dest.AddressId, opt => opt.Ignore())
                .ForMember(dest => dest.Address, opt => opt.Ignore())
                .ForMember(dest => dest.Vacancys, opt => opt.Ignore())
                .ForMember(dest => dest.User, opt => opt.Ignore());

            CreateMap<CandidateDto, Candidate>()
              .ForMember(dest => dest.UserId, opt => opt.Ignore())
              .ForMember(dest => dest.User, opt => opt.Ignore())
              .ForMember(dest => dest.CandidateId, opt => opt.Ignore())
              .ForMember(dest => dest.Applications, opt => opt.Ignore())
              .ForMember(dest => dest.Address, opt => opt.Ignore())
              .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.NomeCompleto))
              .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.DataNascimento))
              .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Curso));
        }

        private void DomainToResponse()
        {

        }
    }
}
