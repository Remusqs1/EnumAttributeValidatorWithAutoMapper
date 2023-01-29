using System.ComponentModel.DataAnnotations;

namespace EnumValidator.Utils.Validators
{
    public class EnumValidatorAttribute : ValidationAttribute
    {
        public Type MyEnum { get; set; }

        public override bool IsValid(object value)
        {
            if (value == null || (int)value == 0)
            {
                return false;
            }
            if (!Enum.IsDefined(this.MyEnum, (int)value))
            {
                return false;
            }
            return true;
        }
    }
}