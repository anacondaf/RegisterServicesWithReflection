// <copyright file="ICustomerService.cs" company="Commerce Control Limited">
// Copyright (c) 2022 All Rights Reserved
// </copyright>
// <author>Tom Fletcher, Software Engineer</author>

using RegisterServicesWithReflection.Models;
using RegisterServicesWithReflection.Services.Base;

namespace RegisterServicesWithReflection.Services.Interfaces;

public interface ICustomerService : IScopedService
{
    Task<Customer> GetCustomer(Guid id);
}