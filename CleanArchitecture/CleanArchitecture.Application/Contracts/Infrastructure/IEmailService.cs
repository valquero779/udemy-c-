﻿using CleanArchitecture.Application.Models;

namespace CleanArchitecture.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {

        Task<bool> SendEmail(Email email);
    }
}
