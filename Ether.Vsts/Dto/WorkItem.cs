﻿using System;
using System.Collections.Generic;
using Ether.Contracts.Dto;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;

namespace Ether.Vsts.Dto
{
    [Serializable]
    public class WorkItem : BaseDto
    {
        public int WorkItemId { get; set; }

        [BsonDictionaryOptions(DictionaryRepresentation.ArrayOfDocuments)]
        public Dictionary<string, string> Fields { get; set; }

        public IEnumerable<WorkItemUpdate> Updates { get; set; }
    }
}
