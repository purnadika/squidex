// ==========================================================================
//  SchemaCreated.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using Squidex.Core.Schemas;
using Squidex.Infrastructure;
using Squidex.Infrastructure.CQRS.Events;

namespace Squidex.Events.Schemas
{
    [TypeName("SchemaCreatedEvent")]
    public class SchemaCreated : IEvent
    {
        public string Name { get; set; }

        public SchemaProperties Properties { get; set; }
    }
}
