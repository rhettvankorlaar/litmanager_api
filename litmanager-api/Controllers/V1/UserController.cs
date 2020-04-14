using AutoMapper;
using litmanager_api.Contracts.V1;
using litmanager_api.Contracts.V1.Requests.User;
using litmanager_api.Contracts.V1.Responses.User;
using litmanager_api.Domain;
using litmanager_api.Mail;
using litmanager_api.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace litmanager_api.Controllers.V1
{
    public class UserController : Controller
    {
        private readonly UserService _userService;
        private readonly IMapper _mapper;
        private readonly UserTypeService _userTypeService;
        private readonly IMailSender _mail;
        public UserController(UserService userService, IMapper mapper, UserTypeService userTypeService, IMailSender mail)
        {
            _userService = userService;
            _mapper = mapper;
            _userTypeService = userTypeService;
            _mail = mail;
        }

        [HttpPost(ApiRoutes.User.Create)]
        public async Task<IActionResult> CreateAsync([FromBody]CreateRequest request)
        {
            //Map request to User and add it using service and check if successful
            var user = _mapper.Map<User>(request);

            //Normalize email
            user.Email = user.Email.ToUpper();

            //User is enabled as default
            user.IsEnabled = true;
            var result = await _userService.AddAsync(user);
            if (!result)
            {
                return NoContent();
            }
            //return location and mapped object
            var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}/";
            var locationUri = baseUrl + ApiRoutes.User.Get.Replace("{userId}", request.Id);
            return Created(locationUri, _mapper.Map<GetResponse>(request));
        }

        [HttpGet(ApiRoutes.User.Get)]
        public async Task<IActionResult> GetAsync([FromRoute]string userId)
        {
            //Get User from the service and check if its null
            var result = await _userService.GetAsync(userId);
            if (result == null)
            {
                return NotFound();
            }
            //return mapped User
            return Ok(_mapper.Map<GetResponse>(result));
        }

        [HttpGet(ApiRoutes.User.GetAll)]
        public async Task<IActionResult> GetAllAsync()
        {
            //Get all User from service if null return noContent
            var result = await _userService.GetAllAsync();
            if (result == null)
            {
                return NotFound();
            }
            //return a mapped list
            var x = _mapper.Map<List<GetResponse>>(result);
            return Ok(x);
        }

        [HttpPut(ApiRoutes.User.Update)]
        public async Task<IActionResult> UpdateAsync([FromRoute]string userId, [FromBody]UpdateRequest request)
        {
            //Map the update request to a User
            var user = _mapper.Map<User>(request);

            //Try to update the user and check if its successfull
            var result = await _userService.UpdateAsync(user);
            if (!result)
            {
                return NotFound();
            }
            //return the updated user
            return await GetAsync(userId);
        }

        [HttpDelete(ApiRoutes.User.Delete)]
        public async Task<IActionResult> DeleteAsync([FromRoute]string userId)
        {
            //Delete User with service and check if successful
            var result = await _userService.DeleteAsync(userId);
            if (!result)
            {
                return NotFound();
            }
            //return successfull
            return Ok();
        }

        [HttpPatch(ApiRoutes.User.Patch)]
        public async Task<IActionResult> PatchUser([FromRoute]string userId, [FromBody]JsonPatchDocument<User> patch)
        {
            var user = await _userService.GetAsync(userId);
            patch.ApplyTo(user, ModelState);

            var updated = await _userService.UpdateAsync(user);

            if (!updated)
            {
                return NotFound();
            }
            return Ok();
        }
    }





}
