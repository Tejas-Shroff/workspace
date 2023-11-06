using EMSApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace EMSApi.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : ControllerBase{

        IDept repo;
        public DepartmentController(IDept _repo){
            this.repo=_repo;
        }
        [HttpGet]
        [Route("ListDept")]
        public IActionResult GetDept(){
            var data = repo.GetDepartments();
            return Ok(data);
            
        }
    }
}
