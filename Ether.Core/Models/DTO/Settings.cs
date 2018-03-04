﻿using System;

namespace Ether.Core.Models.DTO
{
    public class Settings : BaseDto
    {
        public override Guid Id
        {
            get => Guid.Parse("a98f9ff6-efac-44ee-abfc-1d78d787d4d9");
        }

        public WorkItems WorkItemsSettings { get; set; }
        public Reports ReportsSettings { get; set; }

        public class WorkItems
        {
            public bool DisableWorkitemsJob { get; set; }

            public TimeSpan KeepLast { get; set; }
        }

        public class Reports
        {
            public TimeSpan KeepLast { get; set; }
        }
    }
}