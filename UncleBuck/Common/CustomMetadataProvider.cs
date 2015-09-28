using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UncleBuck.Common
{
    using System.Web.Mvc;

    public class CustomMetadataProvider : DataAnnotationsModelMetadataProvider
    {
        protected override ModelMetadata CreateMetadata(
            IEnumerable<Attribute> attributes,
            Type containerType,
            Func<object> modelAccessor,
            Type modelType,
            string propertyName)
        {
            var modelMetadata = base.CreateMetadata(attributes, containerType, modelAccessor, modelType, propertyName);
            if (modelType.IsEnum)
            {
                modelMetadata.TemplateHint = "Enum";
            }
            return modelMetadata;
        }
    }
}
