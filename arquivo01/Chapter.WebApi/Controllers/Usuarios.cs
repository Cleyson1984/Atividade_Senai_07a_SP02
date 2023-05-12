using Chapter.WebApi.Models;
using Chapter.WebApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
namespace Chapter.WebApi.Controllers
{
[Produces("application/json")]
[Route("api/[controller]")]
[ApiController]
public class UsuariosController : ControllerBase
{
private readonly UsuarioRepository _usuarioRepository;
public UsuariosController(UsuarioRepository usuarioRepository)
{
_usuarioRepository = usuarioRepository;
}
// get -> /api/usuarios
[Authorize]
[HttpGet]
public IActionResult Listar()
{
return Ok(_usuarioRepository.Listar());
}}}