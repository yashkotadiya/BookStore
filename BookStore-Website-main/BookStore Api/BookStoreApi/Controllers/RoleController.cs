/*using BookStore.Models.Models;
using BookStore.Repository;
using BookStoreModels.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BookStore.Api.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        RoleRepository _roleRepository = new RoleRepository();

        [HttpGet]
        [Route("Role")]
      //  [ProducesResponseType(typeof(ListResponse<RoleModel>), (int)HttpStatusCode.OK)]
        public IActionResult GetRoles(int pageIndex = 1, int pageSize = 10, string? keyword = "")
        {
    
            var Roles = _roleRepository.GetRoles(pageIndex, pageSize, keyword);
            ListResponse<RoleModel> listResponse = new ListResponse<RoleModel>()
            {
                Records = Roles.Records.Select(c => new RoleModel(c)).ToList(),
                TotalRecords = Roles.TotalRecords,
            };

            return Ok(listResponse);
        }
    }
}*/
