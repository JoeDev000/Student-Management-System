using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace FinalProject.Helpers
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            var member = enumValue.GetType().GetMember(enumValue.ToString());
            if (member.Length > 0)
            {
                var displayAttr = member[0].GetCustomAttribute<DisplayAttribute>();
                if (displayAttr != null)
                    return displayAttr.Name;
            }
            return enumValue.ToString(); // fallback if no Display attribute
        }
    }
}
