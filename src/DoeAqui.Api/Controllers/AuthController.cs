using DoeAqui.Api.Configurations;
using DoeAqui.Application.Interfaces;
using DoeAqui.Application.ViewModels.User;
using DoeAqui.Domain.Core.Notifications;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DoeAqui.Api.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class AuthController : BaseController
    {
        private readonly IUserAppService _userAppService;
        private readonly IConfiguration _configuration;

        public AuthController(IDomainNotificationHandler<DomainNotification> notifications, IUserAppService userAppService, IConfiguration configuration)
            : base(notifications)
        {
            _configuration = configuration;
            _userAppService = userAppService;
        }

        [HttpPost]
        public IActionResult Post([FromBody]LoginViewModel vm)
        {
            var response = _userAppService.Authenticate(vm);

            if (!IsValid())
                return Response();

            return Response(response);
        }
    }
}