namespace LibraryManagementSystem.Web.Areas.Administration.Controllers
{
    using LibraryManagementSystem.Common;
    using LibraryManagementSystem.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
