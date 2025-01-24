using AutoMapper;
using Cantek.ArgeProjectNTier.Business.Interfaces;
using Cantek.ArgeProjectNTier.Business.Mappings.AutoMapper;
using Cantek.ArgeProjectNTier.Business.Services;
using Cantek.ArgeProjectNTier.Business.ValidationRules;
using Cantek.ArgeProjectNTier.DataAccess.Contexts;
using Cantek.ArgeProjectNTier.DataAccess.UnitOfWork;
using Cantek.ArgeProjectNTier.Dtos;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BotanicFungiContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("Local"));
            });


            services.AddScoped<IUow, Uow>();

            services.AddTransient<IValidator<RoomCreateDto>, RoomCreateDtoValidator>();
            services.AddTransient<IValidator<RoomUpdateDto>, RoomUpdateDtoValidator>();

            services.AddScoped<IRoomService, RoomService>();

            services.AddTransient<IValidator<ParameterUpdateDto>, ParameterUpdateDtoValidator>();
            services.AddTransient<IValidator<ParameterCreateDto>, ParameterCreateDtoValidator>();

            services.AddScoped<IParameterService, ParameterService>();

            services.AddTransient<IValidator<RoomStatusCreateDto>, RoomStatusCreateDtoValidator>();
            services.AddTransient<IValidator<RoomStatusUpdateDto>, RoomStatusUpdateDtoValidator>();

            services.AddScoped<IRoomStatusService, RoomStatusService>();

            services.AddTransient<IValidator<AppUserCreateDto>, AppUserCreateDtoValidator>();
            services.AddTransient<IValidator<AppUserUpdateDto>, AppUserUpdateDtoValidator>();

            services.AddScoped<IAppUserService, AppUserService>();

            services.AddTransient<IValidator<GenderCreateDto>, GenderCreateDtoValidator>();
            services.AddTransient<IValidator<GenderUpdateDto>, GenderUpdateDtoValidator>();

            services.AddScoped<IGenderService, GenderService>();

            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginDtoValidator>();

            
        }

    }
}
