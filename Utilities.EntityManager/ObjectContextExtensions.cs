using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace Utilities.EntityManager
{
    public static class ObjectContextExtensions
    {
        public static ObjectContext GetContext(this IEntityWithRelationships entity)
        {
            if (entity == null) return null;
                // throw new ArgumentNullException("entity");

            var relationshipManager = entity.RelationshipManager;

            var relatedEnd = relationshipManager.GetAllRelatedEnds().FirstOrDefault();

            if (relatedEnd == null) return null;
                //throw new Exception("No relationships found");

            var query = relatedEnd.CreateSourceQuery() as ObjectQuery;

            if (query == null) return null;
                //throw new Exception("The Entity is Detached");

            return query.Context;
        }
    }
}
