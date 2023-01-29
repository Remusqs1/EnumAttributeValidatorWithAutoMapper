using AutoMapper;
using EnumValidator.Classes;

namespace EnumValidator.Utils
{

    public class Mapping
    {
        private static MapperConfiguration _config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<PetClassDTO, PetClass>();
            cfg.CreateMap<AuxLangClassDTO, AuxLangClass>();
        });

        public static AuxLangClass MapAuxLang(AuxLangClassDTO dto)
        {
            var _mapper = new Mapper(_config);
            
            return _mapper.Map<AuxLangClass>(dto);
        }

        public static PetClass MapPet(PetClassDTO dto)
        {
            var _mapper = new Mapper(_config); 
            return _mapper.Map<PetClass>(dto);
        }

    }
}
