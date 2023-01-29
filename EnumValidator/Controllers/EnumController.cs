using EnumValidator.Classes;
using EnumValidator.Classes.Enums;
using EnumValidator.Utils;
using Microsoft.AspNetCore.Mvc;

namespace EnumValidator.Controllers
{
    public class EnumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("AuxLang", Name = "EAuxLang_Post")]
        public IActionResult ValidateAuxLang([FromBody] AuxLangClassDTO input)
        {
            if (ModelState.IsValid) {

                AuxLangClass response = Mapping.MapAuxLang(input);
                response.Result = EResult.Success;
                return Ok(response);
            } 
            else return BadRequest(ModelState);
        }

        [HttpPost("Pet", Name = "EPet_Post")]
        public IActionResult ValidatePet([FromBody] PetClassDTO input)
        {
            if (ModelState.IsValid)
            {
                PetClass response = Mapping.MapPet(input);
                response.Result = EResult.Success;
                return Ok(response);
            }
            else return BadRequest(ModelState);
        }

    }
}
