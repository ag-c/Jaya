﻿using Jaya.Provider.FileSystem.Services;
using Jaya.Shared.Base;
using System.Collections.Generic;

namespace Jaya.Ui.Services
{
    public sealed class ProviderService
    {
        readonly List<ProviderServiceBase> _services;

        public ProviderService(FileSystemService fileSystemService)
        {
            _services = new List<ProviderServiceBase>
            {
                fileSystemService
            };
        }

        public IEnumerable<ProviderServiceBase> Services => _services;
    }
}
