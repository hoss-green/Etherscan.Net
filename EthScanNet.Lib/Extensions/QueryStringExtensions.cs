using System;
using System.Reflection;
using System.Text;

namespace EthScanNet.Lib.Extensions
{
    internal static class QueryStringExtensions
    {
        public static string ToQueryString(this object item)
        {
            Type itemType = item.GetType();
            PropertyInfo[] properties = itemType.GetProperties();
            StringBuilder stringBuilder = new("?");

            foreach (PropertyInfo propertyInfo in properties)
            {
                if (propertyInfo.GetValue(item) == null)
                {
                    continue;
                }
                
                stringBuilder.Append(propertyInfo.Name.ToLower());
                stringBuilder.Append('=');
                stringBuilder.Append(propertyInfo.GetValue(item));
                stringBuilder.Append('&');
            }

            stringBuilder.Remove(stringBuilder.Length - 1, 1);
            return stringBuilder.ToString();
        }
    }
}