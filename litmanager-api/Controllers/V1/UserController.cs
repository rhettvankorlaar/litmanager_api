using AutoMapper;
using litmanager_api.Contracts.V1;
using litmanager_api.Contracts.V1.Requests;
using litmanager_api.Contracts.V1.Requests.User;
using litmanager_api.Contracts.V1.Responses.User;
using litmanager_api.Domain;
using litmanager_api.Mail;
using litmanager_api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUri = baseUrl + "/" + ApiRoutes.User.Get.Replace("{userId}", request.Id);
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
            var result = await _userService.UpdateAsync(userId, user);
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

        [HttpPatch(ApiRoutes.User.PatchEmail)]
        public async Task<IActionResult> PatchEmail([FromRoute]string userId, [FromBody]PatchRequest patch)
        {
            //Check if the User exists
            var user = await _userService.GetAsync(userId);
            if (user == null)
            {
                return NotFound();
            }
            //Update User with patch
            user.Email = patch.Email;

            //Update the User object and check if successful
            if (await UpdateUser(userId, user) == false)
            {
                return BadRequest();
            }
            HandleEmailChange(user);
            //return mapped GetAsync
            return await GetAsync(userId);
        }

        [HttpPatch(ApiRoutes.User.PatchFirstName)]
        public async Task<IActionResult> PatchFirstName([FromRoute]string userId, [FromBody]PatchRequest patch)
        {
            //Check if the User exists
            var user = await _userService.GetAsync(userId);
            if (user == null)
            {
                return NotFound();
            }
            //Update User with patch
            user.FirstName = patch.FirstName;

            //Update the User object and check if successful
            if (await UpdateUser(userId, user) == false)
            {
                return BadRequest();
            }

            //return mapped GetAsync
            return await GetAsync(userId);
        }

        [HttpPatch(ApiRoutes.User.PatchLastName)]
        public async Task<IActionResult> PatchLastName([FromRoute]string userId, [FromBody]PatchRequest patch)
        {
            //Check if the User exists
            var user = await _userService.GetAsync(userId);
            if (user == null)
            {
                return NotFound();
            }
            //Update User with patch
            user.LastName = patch.LastName;

            //Update the User object and check if successful
            if (await UpdateUser(userId, user) == false)
            {
                return BadRequest();
            }

            //return mapped GetAsync
            return await GetAsync(userId);
        }

        [HttpPatch(ApiRoutes.User.PatchUserType)]
        public async Task<IActionResult> PatchUserType([FromRoute]string userId, [FromBody]PatchRequest patch)
        {
            //Check if the User exists
            var user = await _userService.GetAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            //Check if type exists
            var type = await _userTypeService.GetAsync(patch.UserTypeId);
            if (type == null)
            {
                return BadRequest();
            }

            //Update User with patch
            user.UserTypeId = patch.UserTypeId;

            //Update the User object and check if successful
            if (await UpdateUser(userId, user) == false)
            {
                return BadRequest();
            }

            //return mapped GetAsync
            return await GetAsync(userId);
        }

        [HttpPatch(ApiRoutes.User.PatchPassword)]
        public async Task<IActionResult> PatchPassword([FromRoute]string userId, [FromBody]PatchPassword patch)
        {
            var result = await _userService.ChangePasswordAsync(userId, patch.Password);
            if (!result)
            {
                return BadRequest();
            }

            //return mapped GetAsync
            return Ok();
        }

        [HttpPatch(ApiRoutes.User.PatchIsEnabled)]
        public async Task<IActionResult> PatchIsEnabled([FromRoute]string userId, [FromBody]PatchRequest patch)
        {
            //Check if the User exists
            var user = await _userService.GetAsync(userId);
            if (user == null)
            {
                return NotFound();
            }
            //Update User with patch
            user.IsEnabled = patch.IsEnabled;

            //Update the User object and check if successful
            if (await UpdateUser(userId, user) == false)
            {
                return BadRequest();
            }

            //return mapped GetAsync
            return await GetAsync(userId);
        }

        [HttpPatch(ApiRoutes.User.PatchIsAdmin)]
        public async Task<IActionResult> PatchIsAdmin([FromRoute]string userId, [FromBody]PatchRequest patch)
        {
            //Check if the User exists
            var user = await _userService.GetAsync(userId);
            if (user == null)
            {
                return NotFound();
            }
            //Update User with patch
            user.IsAdmin = patch.IsAdmin;

            //Update the User object and check if successful
            if (await UpdateUser(userId, user) == false)
            {
                return BadRequest();
            }

            //return mapped GetAsync
            return await GetAsync(userId);
        }

        private async Task<bool> UpdateUser(string userId, User user)
        {
            //Try to update user
            var result = await _userService.UpdateAsync(userId, user);
            if (!result)
            {
                return false;
            }
            return true;
        }

        private void HandleEmailChange(User user)
        {
            var receiver = new Receiver
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName
            };
            //send mail with verifytoken
            try
            {
                _mail.SendMail(receiver, "EMAIL CHANGED", "content");
            }
            catch
            {
                //Error
            }
        }

    }





}
