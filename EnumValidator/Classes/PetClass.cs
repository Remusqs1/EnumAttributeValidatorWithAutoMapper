using EnumValidator.Classes.Enums;

namespace EnumValidator.Classes
{
    public class PetClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Age { get; set; }
        public EPets EPet { get; set; }
        public EResult Result { get; set; }
    }
}
