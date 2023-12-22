using AutoMapper;
using LMS.Data;
using LMS.DTO;
using LMS.Entities;
using LMS.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMS.Controllers
{
	public class AccountController : APIBaseController
	{
		private readonly UserManager<AppUser> userManager;
		private readonly ITokenService token;
		private readonly IMapper mapper;
		
		private readonly RoleManager<AppRole> roleManager;
		public AccountController(UserManager<AppUser> userManager,RoleManager<AppRole> roleManager, ITokenService token,IMapper mapper)
		{
			this.userManager = userManager;
			this.token = token;
			this.mapper = mapper;
			this.roleManager = roleManager;
		}

		[HttpPost("register")]
		public async Task<ActionResult<UserDTO>> Register(RegisterDTO userDTO)
		{
			if (await UserExist(userDTO.Username))
				return BadRequest("Username taken");
			
			var user = mapper.Map<AppUser>(userDTO);

			user.UserName = userDTO.Username;

			var result = userManager.CreateAsync(user, userDTO.Password);

			if (!result.IsCompletedSuccessfully) return BadRequest(result.Exception.Message);

			var roleResult = await userManager.AddToRoleAsync(user, "Student");

			if (!roleResult.Succeeded) return BadRequest(roleResult.Errors);

			return new UserDTO
			{
				Username = user.UserName,
				Token = await token.CreateToken(user),
				Email = user.Email
			};
		}
		private async Task<bool> UserExist(string username)
		{
			return await userManager.Users.AnyAsync(u => u.UserName == username.ToLower());
		}

		[HttpPost("login")]
		public async Task<ActionResult<UserDTO>> Login(LoginDTO userDTO)
		{
			var user = await userManager.Users
			.SingleOrDefaultAsync(u => u.UserName == userDTO.Username);

			if (user == null) return Unauthorized();

			var result = await userManager.CheckPasswordAsync(user, userDTO.Password);

			if (!result) return Unauthorized("Invalid Password");

			return new UserDTO
			{
				Username = user.UserName,
				Token = await token.CreateToken(user),
				Email = user.Email
			};
		}

	}
}
