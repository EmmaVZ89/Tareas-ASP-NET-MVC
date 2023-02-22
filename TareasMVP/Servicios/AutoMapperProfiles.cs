using AutoMapper;
using TareasMVP.Entidades;
using TareasMVP.Models;

namespace TareasMVP.Servicios
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Tarea, TareaDTO>();
        }
    }
}
