using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using litmanager_api.Domain;
using Microsoft.EntityFrameworkCore.Internal;
using litmanager_api.Services;
using litmanager_api.Contracts.V1;
using litmanager_api.Contracts.V1.Requests.Registration;
using AutoMapper;
using litmanager_api.Contracts.V1.Responses.Registration;
using System.Security.Policy;

namespace litmanager_api.Controllers.V1
{
    public class RegistrationsController : Controller
    {
        private readonly RegistrationService _registeredService;
        private readonly UserService _userService;
        private readonly IMapper _mapper;

        public RegistrationsController(RegistrationService registrationService, UserService userService,  IMapper mapper)
        {
            _registeredService = registrationService;
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost(ApiRoutes.Registration.Create)]
        public async Task<IActionResult> CreateAsync([FromBody]CreateRequest request)
        {
            var result = await _registeredService.AddAsync(request);
            if (!result)
            {
                return NoContent();
            }
            var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUri = baseUrl + "/" + ApiRoutes.Registration.Get.Replace("{registrationId}", request.Id);
            return Created(locationUri, _mapper.Map<GetResponse>(request));
        }

        [HttpGet(ApiRoutes.Registration.Get)]
        public async Task<IActionResult> GetAsync([FromRoute]string registrationId)
        {
            var result = await _registeredService.GetAsync(registrationId);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<GetResponse>(result));
        }

        [HttpGet(ApiRoutes.Registration.GetAll)]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _registeredService.GetAllAsync();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<List<GetResponse>>(result));
        }

        [HttpPut(ApiRoutes.Registration.Update)]
        public async Task<IActionResult> UpdateAsync([FromRoute]string registrationId, [FromBody]UpdateRequest request)
        {
            var registration = _mapper.Map<Registration>(request);
            var result = await _registeredService.UpdateAsync(registrationId, registration);
            if (!result)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<GetResponse>(registration));
        }


        [HttpGet(ApiRoutes.Registration.Approve)]
        public async Task<IActionResult> ApproveAsync([FromRoute]string registrationId)
        {
            //Get the registration to approve
            var registration = await _registeredService.GetAsync(registrationId);
            
            //Map the registration to User
            var user = _mapper.Map<User>(registration); 

            //Add the user to the user table and check if successful
            var result = await _userService.AddAsync(user);

            if (!result)
            {
                return BadRequest();
            }
            //Remove registration from database by denying it
            await DenyAsync(registrationId);
            return Ok();
            
        }

        [HttpGet(ApiRoutes.Registration.Deny)]
        public async Task<IActionResult> DenyAsync([FromRoute]string registrationId)
        {
            var result = await _registeredService.DeleteAsync(registrationId);
            if (!result)
            {
                return NotFound();
            }

            return Ok();
        }

    }
}
