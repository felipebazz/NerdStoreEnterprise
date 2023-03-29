using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NSE.Cliente.API.Data;
using NSE.Clientes.API.Application.Commands;
using NSE.Clientes.API.Application.Events;
using NSE.Clientes.API.Data.Repository;
using NSE.Clientes.API.Models;
using NSE.Clientes.API.Services;
using NSE.Core.MediatR;

namespace NSE.Clientes.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IMediatRHandler, MediatRHandler>();
            services.AddScoped<IRequestHandler<RegistrarClienteCommand, ValidationResult>, RegistrarClienteCommandHandler>();

            services.AddScoped<INotificationHandler<ClienteRegistradoEvent>, ClienteRegistradoEventHandler>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ClientesContext>();
        }
    }
}
