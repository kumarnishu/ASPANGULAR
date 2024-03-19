using Abp.Application.Services.Dto;

namespace ASPANGULAR.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

