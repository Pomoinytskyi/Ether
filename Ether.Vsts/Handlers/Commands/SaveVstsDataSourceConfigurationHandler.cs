﻿using System;
using System.Threading.Tasks;
using Ether.Contracts.Interfaces;
using Ether.Contracts.Interfaces.CQS;
using Ether.Contracts.Types;
using Ether.Vsts.Commands;
using Ether.Vsts.Dto;

namespace Ether.Vsts.Handlers.Commands
{
    public class SaveVstsDataSourceConfigurationHandler : ICommandHandler<SaveVstsDataSourceConfiguration, UnitType>
    {
        private readonly IRepository _repository;

        public SaveVstsDataSourceConfigurationHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<UnitType> Handle(SaveVstsDataSourceConfiguration input)
        {
            if (input == null || input.Configuration == null)
            {
                throw new ArgumentNullException(nameof(input.Configuration));
            }

            var config = input.Configuration;
            await _repository.CreateOrUpdateIfAsync(i => i.Type == "Vsts", new VstsDataSourceSettings
            {
                Id = config.Id,
                DefaultToken = config.DefaultToken,
                InstanceName = config.InstanceName
            });

            return UnitType.Default;
        }
    }
}