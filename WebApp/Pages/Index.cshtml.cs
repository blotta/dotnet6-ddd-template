using Domain.Entities;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IUserService _userService;

    public User User;

    public IndexModel(ILogger<IndexModel> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    public void OnGet()
    {
        User = _userService.GetById(0);
    }
}