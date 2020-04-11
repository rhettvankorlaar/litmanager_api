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
using litmanager_api.Mail;

namespace litmanager_api.Controllers.V1
{
    public class RegistrationsController : Controller
    {
        private readonly RegistrationService _registeredService;
        private readonly UserService _userService;
        private readonly IMapper _mapper;
        private readonly UserTypeService _userTypeService;
        private readonly IMailSender _mail;

        public RegistrationsController(RegistrationService registrationService, UserService userService,  IMapper mapper, UserTypeService userTypeService, IMailSender mail)
        {
            _registeredService = registrationService;
            _userService = userService;
            _mapper = mapper;
            _userTypeService = userTypeService;
            _mail = mail;
        }

        [HttpPost(ApiRoutes.Registration.Create)]
        public async Task<IActionResult> CreateAsync([FromBody]CreateRequest request)
        {
            //Check if type exists
            var type = await _userTypeService.GetAsync(request.UserTypeId);
            if (type == null)
            {
                return BadRequest();
            }
            //check if the user exists in User table
            if(await _userService.UserExists(request.Id,request.Email))
            {
                return BadRequest();
            }

            //Create a Registration using the service and check if successful
            var result = await _registeredService.AddAsync(request);
            if (!result)
            {
                return BadRequest();
            }
            //Get the location of the created object and send it with the mapped object
            var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUri = baseUrl + "/" + ApiRoutes.Registration.Get.Replace("{registrationId}", request.Id);
            var registration = _mapper.Map<GetResponse>(request);

            var receiver = new Receiver
            {
                Email = registration.Email,
                FirstName = registration.FirstName,
                LastName = registration.LastName
            };
            //send registered mail to User
            //TODO Add MailTemplate 
            //Send mail with ability to confirm email.
            SendMail(receiver, "REGISTERED", "content");

            return Created(locationUri, registration);
        }

        [HttpGet(ApiRoutes.Registration.Get)]
        public async Task<IActionResult> GetAsync([FromRoute]string registrationId)
        {
            //Get Registration from the service and check if its null
            var result = await _registeredService.GetAsync(registrationId);
            if(result == null)
            {
                return NotFound();
            }
            //return mapped Registration
            return Ok(_mapper.Map<GetResponse>(result));
        }

        [HttpGet(ApiRoutes.Registration.GetAll)]
        public async Task<IActionResult> GetAllAsync()
        {
            //Get all Registraions from service if null return noContent
            var result = await _registeredService.GetAllAsync();
            if (result == null)
            {
                return NotFound();
            }
            //return a mapped list
            return Ok(_mapper.Map<List<GetResponse>>(result));
        }

        [HttpPut(ApiRoutes.Registration.Update)]
        public async Task<IActionResult> UpdateAsync([FromRoute]string registrationId, [FromBody]UpdateRequest request)
        {
            //Map the update request to a registration
            var registration = _mapper.Map<Registration>(request);
            
            //Try to update the user and check if its successfull
            var result = await _registeredService.UpdateAsync(registration);
            if (!result)
            {
                return NotFound();
            }
            //return the updated user
            return await GetAsync(registrationId);
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

            
            var receiver = new Receiver
            {
                 Email = user.Email,
                 FirstName = user.FirstName,
                 LastName = user.LastName
            };
            //send approved mail to User
            //TODO Add MailTemplate 
            //Send mail with ability to set password.
            SendMail(receiver, "APPROVE","content");

            return Ok();
            
        }

        [HttpGet(ApiRoutes.Registration.Deny)]
        public async Task<IActionResult> DenyAsync([FromRoute]string registrationId)
        {
            //Delete Registration with service and check if successful
            var result = await _registeredService.DeleteAsync(registrationId);
            if (!result)
            {
                return NotFound();
            }
            //return successfull
            return Ok();
        }

        private void SendMail(Receiver receiver, string subject, string content)
        {
            try
            {
                _mail.SendMail(receiver, subject,content);
            }
            catch
            {
                //Error
            }

        }
    }
}
