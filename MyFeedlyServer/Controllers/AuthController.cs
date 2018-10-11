﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Contracts.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MyFeedlyServer.Contracts;
using MyFeedlyServer.Entities.Contracts;
using MyFeedlyServer.Entities.Entities;
using MyFeedlyServer.Entities.Extensions;
using MyFeedlyServer.Entities.Models;
using MyFeedlyServer.Extensions;
using MyFeedlyServer.Resources;

namespace MyFeedlyServer.Controllers
{
    [Route("api/auth")]
    public class AuthController : Controller
    {
        private readonly ILoggerManager _logger;
        private readonly IRepositoryWrapper _repository;

        public AuthController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login([FromBody]UserCreateOrUpdateModel userCreateOrUpdateModel)
        {
            if (userCreateOrUpdateModel.IsNull())
            {
                _logger.LogError(string.Format(Resource.LogErrorInvalidModel, nameof(userCreateOrUpdateModel), string.Empty));
                return BadRequest(Resource.Status400BadRequestInvalidModel);
            }

            var user = new UserCreateOrUpdateModel(_repository.User.GetUserByName(userCreateOrUpdateModel.Name));
            if (user.IsNull())
            {
                _logger.LogError(string.Format(Resource.LogErrorGetByIsNull, nameof(user), nameof(userCreateOrUpdateModel.Name), userCreateOrUpdateModel.Name));
                return NotFound();
            }

            if (userCreateOrUpdateModel.Name == user.Name && userCreateOrUpdateModel.Password == user.Password)
                return Ok(new { Token = GetToken(user) });

            return Unauthorized();
        }

        private string GetToken(EntityModel<User> model)
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var tokeOptions = new JwtSecurityToken(
                issuer: "http://localhost:5000",
                audience: "http://localhost:5000",
                claims: new List<Claim> { new Claim(this.GetUserIdTypeName(), model.Id.ToString()) },
                expires: DateTime.Now.AddMinutes(5),
                signingCredentials: signinCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(tokeOptions);
        }
    }
}