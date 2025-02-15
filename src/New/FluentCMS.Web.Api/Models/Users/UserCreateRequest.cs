﻿namespace FluentCMS.Web.Api.Models;

public class UserCreateRequest
{
    public string Username { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
    public ICollection<Guid> RoleIds { get; set; } = new List<Guid>();
}
