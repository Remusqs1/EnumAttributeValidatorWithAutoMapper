using EnumValidator.Classes.Enums;
using EnumValidator.Utils.Validators;

namespace EnumValidator.Classes
{
    public class PetClassDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Age { get; set; }

        [EnumValidator(ErrorMessage = "Invalid value for EPet", MyEnum = typeof(EPets))]
        public EPets EPet { get; set; }
    }
}