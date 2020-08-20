using BusinessLogic.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class JSonConverter : IJsonConverter
    {
        private string ConvertProperties(object model, StringBuilder stringBuilder)
        {
            Type modelType = model.GetType();
            var properties = modelType.GetProperties();
            stringBuilder.Append("{");
            foreach (var property in properties)
            {
                if (!property.IsDefined(typeof(MyIgnoreAttribute), false))
                {
                    stringBuilder.Append($"{property.Name}:{property.GetValue(model)},");                    
                }
            }
            stringBuilder.Append("},");

            return stringBuilder.ToString();
        }
        public string Convert(object model)
        {
            StringBuilder result = new StringBuilder();

            IEnumerable enumerable = model as IEnumerable;
            if (enumerable != null)
            {
                result.Append("[");
                foreach (var item in enumerable)
                {
                    ConvertProperties(item, result);
                }
                result.Append("]");
            }
            else
            {
                result.Append(ConvertProperties(model, result));
            }

            return result.ToString();
        }
    }
}
