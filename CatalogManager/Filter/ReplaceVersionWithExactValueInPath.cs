﻿using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogManager.Filter
{
    public class ReplaceVersionWithExactValueInPath : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            swaggerDoc.Paths = swaggerDoc.Paths
            .ToDictionary(
                path => path.Key.Replace("v{version}", swaggerDoc.Info.Version),
                path => path.Value
            );
        }
    }
}
