using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using pOmmes.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                if (prop != null)
                {
                    if (prop.PropertyType.BaseType == typeof(Base))
                    {
                        Base baseObject = prop.GetValue(value) as Base;
                        string id = "";
                        if (baseObject != null)
                        {
                            id = baseObject._id;
                        }

                        jObject[prop.Name] = JToken.FromObject(id);
                    }
                    else if (prop.PropertyType == typeof(Collection<ArticleToSize>))
                    {
                        Collection<ArticleToSize> sizes = prop.GetValue(value) as Collection<ArticleToSize>;

                        Collection<string> result = new Collection<string>();
                        foreach (ArticleToSize size in sizes)
                        {
                            result.Add(size._id);
                        }

                        jObject[prop.Name] = JToken.FromObject(result);
                    }
                    else if (prop.PropertyType == typeof(Collection<ArticleToOption>))
                    {
                        Collection<ArticleToOption> options = prop.GetValue(value) as Collection<ArticleToOption>;

                        Collection<string> result = new Collection<string>();
                        foreach (ArticleToOption option in options)
                        {
                            result.Add(option._id);
                        }

                        jObject[prop.Name] = JToken.FromObject(result);
                    }
                }
            }

            jObject.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            List<PropertyInfo> props = GetPropertyInfoByType(objectType);
            var result = Activator.CreateInstance(objectType);

            while (reader.TokenType != JsonToken.None && reader.TokenType != JsonToken.Null)
            {
                switch (reader.TokenType)
                {
                    case JsonToken.StartObject:
                        existingValue = Activator.CreateInstance(objectType);
                        break;
                    case JsonToken.EndObject:
                        return existingValue;

                        case StartArray
                }

                reader.Read();
            }







            reader.Read();

            do
            {
                if (reader.TokenType != JsonToken.PropertyName && reader.TokenType != JsonToken.None && reader.TokenType != JsonToken.Null)
                {
                    if (reader.Value != null && !string.IsNullOrEmpty(reader.Path))
                    {
                        PropertyInfo prop = props.FirstOrDefault(x => x.Name == reader.Path);

                        if (prop != null)
                        {
                            if (prop.PropertyType.BaseType == typeof(Base))
                            {
                                Base baseObject = Activator.CreateInstance(prop.PropertyType) as Base;
                                baseObject._id = reader.Value.ToString();

                                prop.SetValue(result, baseObject);
                            }
                            else if (prop.PropertyType == typeof(Collection<ArticleToSize>))
                            {
                                Collection<string> idList = (Collection<string>)reader.Value;
                                Collection<ArticleToSize> sizes = new Collection<ArticleToSize>();

                                foreach (string item in idList)
                                {
                                    ArticleToSize size = Activator.CreateInstance(typeof(ArticleToSize)) as ArticleToSize;
                                    size._id = item;
                                    sizes.Add(size);
                                }

                                prop.SetValue(result, sizes);
                            }
                            else if (prop.PropertyType == typeof(Collection<ArticleToOption>))
                            {
                                Collection<string> idList = (Collection<string>)reader.Value;
                                Collection<ArticleToOption> options = new Collection<ArticleToOption>();

                                foreach (string item in idList)
                                {
                                    ArticleToOption option = Activator.CreateInstance(typeof(ArticleToOption)) as ArticleToOption;
                                    option._id = item;
                                    options.Add(option);
                                }

                                prop.SetValue(result, options);
                            }
                            else if (prop.PropertyType == typeof(Int32))
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
