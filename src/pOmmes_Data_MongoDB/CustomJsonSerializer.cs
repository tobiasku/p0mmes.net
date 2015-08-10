using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using pOmmes.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace pOmmes.Data
{
    public class CustomJsonSerializer : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JToken t = JToken.FromObject(value);
            JObject jObject = (JObject)t;

            foreach (PropertyInfo prop in GetPropertyInfoByType(value.GetType()))
            {
                if (prop.PropertyType.BaseType == typeof(Base))
                {
                    Base baseObject = prop.GetValue(value) as Base;
                    string id = baseObject._id;

                    jObject[prop.Name] = JToken.FromObject(id);
                }
            }

            jObject.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            List<PropertyInfo> props = GetPropertyInfoByType(objectType);
            var result = Activator.CreateInstance(objectType);

            reader.Read();

            do
            {
                if (reader.TokenType != JsonToken.PropertyName && reader.TokenType != JsonToken.None && reader.TokenType != JsonToken.Null)
                {
                    if (reader.Value != null && !string.IsNullOrEmpty(reader.Path))
                    {
                        PropertyInfo prop = props.FirstOrDefault(x => x.Name == reader.Path);

                        if (prop.PropertyType.BaseType == typeof(Base))
                        {
                            Base baseObject = Activator.CreateInstance(prop.PropertyType) as Base;
                            baseObject._id = reader.Value.ToString();

                            prop.SetValue(result, baseObject);
                        }
                        else
                        {
                            if (reader.Value.GetType() == typeof(Int64))
                            {
                                prop.SetValue(result, Convert.ToInt32(reader.Value));
                            }
                            else
                            {
                                prop.SetValue(result, reader.Value);
                            }
                        }
                    }
                }
            }
            while (reader.Read());

            return result;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.BaseType.IsAssignableFrom(typeof(Base));
        }

        private static List<PropertyInfo> GetPropertyInfoByType(Type type)
        {
            List<PropertyInfo> props = new List<PropertyInfo>();
            if (type != null)
            {
                if (type.BaseType != null)
                {
                    props = type.BaseType.GetProperties().ToList<PropertyInfo>();
                }
                props.AddRange(type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            }
            return props;
        }
    }
}
