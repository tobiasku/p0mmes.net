using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using pOmmes.Common;
using pOmmes.Common.Dic;
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
                    else if (prop.PropertyType == typeof(Collection<Vote>))
                    {
                        Collection<Vote> votes = prop.GetValue(value) as Collection<Vote>;

                        Collection<string> result = new Collection<string>();
                        foreach (Vote vote in votes)
                        {
                            result.Add(vote._id);
                        }

                        jObject[prop.Name] = JToken.FromObject(result);
                    }
                    else if (prop.PropertyType == typeof(Collection<Order>))
                    {
                        Collection<Order> orders = prop.GetValue(value) as Collection<Order>;

                        Collection<string> result = new Collection<string>();
                        foreach (Order order in orders)
                        {
                            result.Add(order._id);
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

            reader.Read();

            do
            {
                if (reader.TokenType != JsonToken.PropertyName && reader.TokenType != JsonToken.None && reader.TokenType != JsonToken.Null)
                {
                    if (!string.IsNullOrEmpty(reader.Path))
                    {
                        PropertyInfo prop = props.FirstOrDefault(x => x.Name == reader.Path);

                        if (prop != null)
                        {
                            if (prop.PropertyType.BaseType == typeof(Base))
                            {
                                Base baseObject = Activator.CreateInstance(prop.PropertyType) as Base;
                                if (reader.Value != null)
                                {
                                    switch (prop.PropertyType.Name)
                                    {
                                        case "Article":
                                            baseObject = Dic.Get<IpOmmesDataBL>().Find<Article>(reader.Value.ToString());
                                            break;
                                        case "ArticleToOption":
                                            baseObject = Dic.Get<IpOmmesDataBL>().Find<ArticleToOption>(reader.Value.ToString());
                                            break;
                                        case "ArticleToSize":
                                            baseObject = Dic.Get<IpOmmesDataBL>().Find<ArticleToSize>(reader.Value.ToString());
                                            break;
                                        case "Category":
                                            baseObject = Dic.Get<IpOmmesDataBL>().Find<Category>(reader.Value.ToString());
                                            break;
                                        case "Company":
                                            baseObject = Dic.Get<IpOmmesDataBL>().Find<Company>(reader.Value.ToString());
                                            break;
                                        case "Event":
                                            baseObject = Dic.Get<IpOmmesDataBL>().Find<Event>(reader.Value.ToString());
                                            break;
                                        case "Option":
                                            baseObject = Dic.Get<IpOmmesDataBL>().Find<Option>(reader.Value.ToString());
                                            break;
                                        case "Order":
                                            baseObject = Dic.Get<IpOmmesDataBL>().Find<Order>(reader.Value.ToString());
                                            break;
                                        case "OrderPosition":
                                            baseObject = Dic.Get<IpOmmesDataBL>().Find<OrderPosition>(reader.Value.ToString());
                                            break;
                                        case "Restaurant":
                                            baseObject = Dic.Get<IpOmmesDataBL>().Find<Restaurant>(reader.Value.ToString());
                                            break;
                                        case "Role":
                                            baseObject = Dic.Get<IpOmmesDataBL>().Find<Role>(reader.Value.ToString());
                                            break;
                                        case "Size":
                                            baseObject = Dic.Get<IpOmmesDataBL>().Find<Size>(reader.Value.ToString());
                                            break;
                                        case "User":
                                            baseObject = Dic.Get<IpOmmesDataBL>().Find<User>(reader.Value.ToString());
                                            break;
                                        case "Vote":
                                            baseObject = Dic.Get<IpOmmesDataBL>().Find<Vote>(reader.Value.ToString());
                                            break;
                                    }

                                    prop.SetValue(result, baseObject);
                                }
                            }
                            else if (reader.TokenType == JsonToken.StartArray)
                            {
                                if (reader.Path == "Sizes")
                                {
                                    Collection<ArticleToSize> sizes = new Collection<ArticleToSize>();
                                    reader.Read();

                                    while (reader.TokenType != JsonToken.EndArray)
                                    {
                                        ArticleToSize size = Activator.CreateInstance(typeof(ArticleToSize)) as ArticleToSize;
                                        size = Dic.Get<IpOmmesDataBL>().Find<ArticleToSize>(reader.Value.ToString());
                                        sizes.Add(size);

                                        reader.Read();
                                    }
                                    prop.SetValue(result, sizes);
                                }
                                else if (reader.Path == "Options")
                                {
                                    Collection<ArticleToOption> options = new Collection<ArticleToOption>();
                                    reader.Read();

                                    while (reader.TokenType != JsonToken.EndArray)
                                    {
                                        ArticleToOption option = Activator.CreateInstance(typeof(ArticleToOption)) as ArticleToOption;
                                        option = Dic.Get<IpOmmesDataBL>().Find<ArticleToOption>(reader.Value.ToString());
                                        options.Add(option);

                                        reader.Read();
                                    }

                                    prop.SetValue(result, options);
                                }
                                else if (reader.Path == "Votes")
                                {
                                    Collection<Vote> votes = new Collection<Vote>();
                                    reader.Read();

                                    while (reader.TokenType != JsonToken.EndArray)
                                    {
                                        Vote vote = Activator.CreateInstance(typeof(Vote)) as Vote;
                                        vote = Dic.Get<IpOmmesDataBL>().Find<Vote>(reader.Value.ToString());
                                        votes.Add(vote);

                                        reader.Read();
                                    }

                                    prop.SetValue(result, votes);
                                }
                                else if (reader.Path == "Orders")
                                {
                                    Collection<Order> orders = new Collection<Order>();
                                    reader.Read();

                                    while (reader.TokenType != JsonToken.EndArray)
                                    {
                                        Order order = Activator.CreateInstance(typeof(Order)) as Order;
                                        order = Dic.Get<IpOmmesDataBL>().Find<Order>(reader.Value.ToString());
                                        orders.Add(order);

                                        reader.Read();
                                    }

                                    prop.SetValue(result, orders);
                                }
                            }
                            else if (prop.PropertyType == typeof(Int32))
                            {
                                prop.SetValue(result, Convert.ToInt32(reader.Value));
                            }
                            else if (prop.PropertyType == typeof(EventType))
                            {
                                prop.SetValue(result, (EventType)Convert.ToInt32(reader.Value));
                            }
                            else if (prop.PropertyType == typeof(EventState))
                            {
                                prop.SetValue(result, (EventState)Convert.ToInt32(reader.Value));
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
