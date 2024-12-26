﻿using MediatR;

namespace Webshop.Application.Users.Commands.AssignUserRole;
public class AssignUserRoleCommand : IRequest
{
    public string UserEmail { get; set; }
    public string RoleName { get; set; }
}