﻿using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _userService.GetAll();
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById(int id)
    {
        var result = _userService.GetById(id);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpPost("add")]
    public IActionResult Add(User user)
    {
        var result = _userService.Add(user);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpPost("delete")]
    public IActionResult Delete(User user)
    {
        var result = _userService.Delete(user);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpPost("update")]
    public IActionResult Update(User user)
    {
        var result = _userService.Update(user);
        return result.Success ? Ok(result) : BadRequest(result);
    }
}