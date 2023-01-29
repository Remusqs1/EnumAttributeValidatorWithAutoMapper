using EnumValidator.Classes.Enums;
using EnumValidator.Utils.Validators;

namespace EnumValidator.Classes
{
    public class AuxLangClassDTO
    {
        public string EventName { get; set; }

        [EnumValidator(ErrorMessage = "Invalid value for AuxLang", MyEnum = typeof(EAuxLangs))]
        public EAuxLangs EAuxLang { get; set; }

    }
}