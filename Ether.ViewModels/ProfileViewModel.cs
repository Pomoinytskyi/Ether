﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Ether.ViewModels
{
    public class ProfileViewModel : ViewModelWithId
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public IEnumerable<Guid> Members { get; set; } = Enumerable.Empty<Guid>();

        public IEnumerable<Guid> Repositories { get; set; } = Enumerable.Empty<Guid>();
    }
}