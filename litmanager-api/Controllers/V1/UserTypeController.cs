using litmanager_api.Contracts.V1;
using litmanager_api.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using litmanager_api.Contracts.V1.Requests.UserType;
using litmanager_api.Services;
using AutoMapper;
using litmanager_api.Contracts.V1.Responses.UserType;

namespace litmanager_api.Controllers.V1
{
    public class UserTypeController : Controller
    {

        private readonly UserTypeService _userTypeService;
        private readonly IMapper _mapper;
        public UserTypeController(UserTypeService userTypeService, IMapper mapper)
        {
            _userTypeService = userTypeService;
            _mapper = mapper;
        }

        [HttpPost(ApiRoutes.UserType.Create)]
        public async Task<IActionResult> CreateAsync([FromBody]CreateRequest request)
        {
            //Create new userType with Guid
            var userType = _mapper.Map<UserType>(request);
            userType.Id = Guid.NewGuid();

            //Map request to User and add it using service and check if successful
            var result = await _userTypeService.AddAsync(userType);
            if (!result)
            {
                return NoContent();
            }
            //return location and mapped object
            var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUri = baseUrl + "/" + ApiRoutes.UserType.Get.Replace("{userTypeId}", userType.Id.ToString());
            return Created(locationUri, _mapper.Map<GetResponse>(userType));
        }

        [HttpGet(ApiRoutes.UserType.Get)]
        public async Task<IActionResult> GetAsync([FromRoute]Guid userTypeId)
        {
            //Get Usertype from the service and check if its null
            var result = await _userTypeService.GetAsync(userTypeId);
            if (result == null)
            {
                return NotFound();
            }
            //return mapped UserType
            return Ok(_mapper.Map<GetResponse>(result));
        }

        [HttpGet(ApiRoutes.UserType.GetAll)]
        public async Task<IActionResult> GetAllAsync()
        {
            //Get all UserTypes from service if null return noContent
            var result = await _userTypeService.GetAllAsync();
            if (result == null)
            {
                return NotFound();
            }
            //return a mapped list
            return Ok(_mapper.Map<List<GetResponse>>(result));
        }

        [HttpPut(ApiRoutes.UserType.Update)]
        public async Task<IActionResult> UpdateAsync([FromRoute]Guid userTypeId, [FromBody]UpdateRequest request)
        {
            //Map the update request to a UserType
            var userType = _mapper.Map<UserType>(request);

            //Try to update the user and check if its successfull
            var result = await _userTypeService.UpdateAsync(userType);
            if (!result)
            {
                return NotFound();
            }
            //return the updated user
            return await GetAsync(userTypeId);
        }

        [HttpDelete(ApiRoutes.UserType.Delete)]
        public async Task<IActionResult> DeleteAsync([FromRoute]Guid userTypeId)
        {
            //Delete User with service and check if successful
            var result = await _userTypeService.DeleteAsync(userTypeId);
            if (!result)
            {
                return NotFound();
            }
            //return successfull
            return Ok();
        }
    }
}
