using Entity.Dto;
using Entity.Model.Security;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Interface
{
    public class IModulocontroller
    {
        public Task<ActionResult<IEnumerable<ModuloDto>>> GetAll();
        public Task<ActionResult<ModuloDto>> Save([FromBody] ModuloDto entity);
        public Task<IActionResult> Update(int id, ModuloDto entity);
        public Task<IActionResult> Delete(int id);

    }
}
