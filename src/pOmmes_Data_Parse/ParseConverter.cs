using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Parse;
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
    public static class ParseConverter
    {
        public static ParseObject ConvertObjectToParse(object value)
        {
            ParseObject obj = new ParseObject(value.GetType().Name);

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

                        obj[prop.Name] = id;
                    }
                    else if (prop.PropertyType == typeof(Collection<ArticleToSize>))
                    {
                        Collection<ArticleToSize> sizes = prop.GetValue(value) as Collection<ArticleToSize>;

                        Collection<string> result = new Collection<string>();
                        if (sizes != null)
                        {
                            foreach (ArticleToSize size in sizes)
                            {
                                result.Add(size._id);
                            }
                        }

                        obj[prop.Name] = result;
                    }
                    else if (prop.PropertyType == typeof(Collection<ArticleToOption>))
                    {
                        Collection<ArticleToOption> options = prop.GetValue(value) as Collection<ArticleToOption>;

                        Collection<string> result = new Collection<string>();
                        if (options != null)
                        {
                            foreach (ArticleToOption option in options)
                            {
                                result.Add(option._id);
                            }
                        }

                        obj[prop.Name] = result;
                    }
                    else if (prop.PropertyType == typeof(Collection<Vote>))
                    {
                        Collection<Vote> votes = prop.GetValue(value) as Collection<Vote>;

                        Collection<string> result = new Collection<string>();
                        if (votes != null)
                        {
                            foreach (Vote vote in votes)
                            {
                                result.Add(vote._id);
                            }
                        }

                        obj[prop.Name] = result;
                    }
                    else if (prop.Name == "_id")
                    {
                        if (prop.GetValue(value) != null)
                        {
                            string id = prop.GetValue(value).ToString();
                            if (!string.IsNullOrEmpty(id))
                            {
                                obj.ObjectId = id;
                            }
                        }
                    }
                    else if (prop.PropertyType == typeof(EventType))
                    {
                        obj[prop.Name] = (int)prop.GetValue(value);
                    }
                    else if (prop.PropertyType == typeof(EventState))
                    {
                        obj[prop.Name] = (int)prop.GetValue(value);
                    }
                    else
                    {
                        obj[prop.Name] = prop.GetValue(value);
                    }
                }
            }

            return obj;
        }

        public static object ConvertParseToObject(ParseObject obj, Type type)
        {
            List<PropertyInfo> props = GetPropertyInfoByType(type);
            var result = Activator.CreateInstance(type);

            foreach (PropertyInfo prop in props)
            {
                if (prop != null)
                {
                    if (prop.PropertyType.BaseType == typeof(Base))
                    {
                        var propValue = obj[prop.Name];
                        Base baseObject = Activator.CreateInstance(prop.PropertyType) as Base;
                        if (propValue != null)
                        {
                            switch (prop.PropertyType.Name)
                            {
                                case "Article":
                                    baseObject = Dic.Get<IpOmmesDataBL>().Find<Article>(propValue.ToString());
                                    break;
                                case "ArticleToOption":
                                    baseObject = Dic.Get<IpOmmesDataBL>().Find<ArticleToOption>(propValue.ToString());
                                    break;
                                case "ArticleToSize":
                                    baseObject = Dic.Get<IpOmmesDataBL>().Find<ArticleToSize>(propValue.ToString());
                                    break;
                                case "Category":
                                    baseObject = Dic.Get<IpOmmesDataBL>().Find<Category>(propValue.ToString());
                                    break;
                                case "Company":
                                    baseObject = Dic.Get<IpOmmesDataBL>().Find<Company>(propValue.ToString());
                                    break;
                                case "Event":
                                    baseObject = Dic.Get<IpOmmesDataBL>().Find<Event>(propValue.ToString());
                                    break;
                                case "Option":
                                    baseObject = Dic.Get<IpOmmesDataBL>().Find<Option>(propValue.ToString());
                                    break;
                                case "Order":
                                    baseObject = Dic.Get<IpOmmesDataBL>().Find<Order>(propValue.ToString());
                                    break;
                                case "OrderPosition":
                                    baseObject = Dic.Get<IpOmmesDataBL>().Find<OrderPosition>(propValue.ToString());
                                    break;
                                case "Restaurant":
                                    baseObject = Dic.Get<IpOmmesDataBL>().Find<Restaurant>(propValue.ToString());
                                    break;
                                case "Role":
                                    baseObject = Dic.Get<IpOmmesDataBL>().Find<Role>(propValue.ToString());
                                    break;
                                case "Size":
                                    baseObject = Dic.Get<IpOmmesDataBL>().Find<Size>(propValue.ToString());
                                    break;
                                case "Vote":
                                    baseObject = Dic.Get<IpOmmesDataBL>().Find<Vote>(propValue.ToString());
                                    break;
                            }

                            prop.SetValue(result, baseObject);
                        }
                    }
                    else if (prop.PropertyType == typeof(Collection<ArticleToSize>))
                    {
                        var propValue = obj[prop.Name];
                        Collection<ArticleToSize> sizes = new Collection<ArticleToSize>();

                        //foreach Size in Collection
                        //ArticleToSize size = Activator.CreateInstance(typeof(ArticleToSize)) as ArticleToSize;
                        //size = Dic.Get<IpOmmesDataBL>().Find<ArticleToSize>(reader.Value.ToString());
                        //sizes.Add(size);

                        prop.SetValue(result, sizes);
                    }
                    else if (prop.PropertyType == typeof(Collection<ArticleToOption>))
                    {
                        var propValue = obj[prop.Name];
                        Collection<ArticleToOption> options = new Collection<ArticleToOption>();

                        //foreach Option in Collection
                        //ArticleToOption option = Activator.CreateInstance(typeof(ArticleToOption)) as ArticleToOption;
                        //option = Dic.Get<IpOmmesDataBL>().Find<ArticleToOption>(reader.Value.ToString());
                        //options.Add(option);

                        prop.SetValue(result, options);
                    }
                    else if (prop.PropertyType == typeof(Collection<Vote>))
                    {
                        var propValue = obj[prop.Name];
                        Collection<Vote> votes = new Collection<Vote>();

                        //Vote vote = Activator.CreateInstance(typeof(Vote)) as Vote;
                        //vote = Dic.Get<IpOmmesDataBL>().Find<Vote>(reader.Value.ToString());
                        //votes.Add(vote);

                        prop.SetValue(result, votes);
                    }
                    else if (prop.PropertyType == typeof(Int32))
                    {
                        var propValue = obj[prop.Name];
                        prop.SetValue(result, Convert.ToInt32(propValue));
                    }
                    else if (prop.PropertyType == typeof(EventType))
                    {
                        var propValue = obj[prop.Name];
                        prop.SetValue(result, (EventType)Convert.ToInt32(propValue));
                    }
                    else if (prop.PropertyType == typeof(EventState))
                    {
                        var propValue = obj[prop.Name];
                        prop.SetValue(result, (EventState)Convert.ToInt32(propValue));
                    }
                    else if (prop.Name == "_id")
                    {
                        prop.SetValue(result, obj.ObjectId);
                    }
                    else
                    {
                        var propValue = obj[prop.Name];
                        prop.SetValue(result, propValue);
                    }
                }
            }

            return result;
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
