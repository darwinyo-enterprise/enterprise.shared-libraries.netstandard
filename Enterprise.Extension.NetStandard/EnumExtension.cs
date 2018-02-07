using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace Enterprise.Extension.NetStandard
{
    /// <summary>
    /// Enum Extension
    /// </summary>
    public static class EnumExtension
    {
        /// <summary>
        /// Used for Get Enum Description
        /// </summary>
        /// <param name="currentEnum">
        /// Current Enum Instance.
        /// </param>
        /// <returns>
        /// Value Description.
        /// </returns>
        public static string GetDescription(this Enum currentEnum)
        {
            string description = String.Empty;
            DescriptionAttribute da;

            FieldInfo fi = currentEnum.GetType().
                        GetField(currentEnum.ToString());
            da = (DescriptionAttribute)Attribute.GetCustomAttribute(fi,
                        typeof(DescriptionAttribute));
            if (da != null)
                description = da.Description;
            else
                description = currentEnum.ToString();

            return description;
        }
        /// <summary>
        /// Get Enum from Description.
        /// </summary>
        /// <typeparam name="T">
        /// Type Enum
        /// </typeparam>
        /// <param name="description">
        /// description enum
        /// </param>
        /// <returns>
        /// Target Enum.
        /// </returns>
        public static T GetValueFromDescription<T>(string description)
        {
            var type = typeof(T);
            if (!type.IsEnum) throw new InvalidOperationException();
            foreach (var field in type.GetFields())
            {
                var attr = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (attr != null)
                {
                    if (attr.Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException();
        }
    }
}
