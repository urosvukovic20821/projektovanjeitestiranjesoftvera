using System;

namespace _09InterfaceAssignment2.Extensions
{
    public static class StringExtensions
    {
        public static void ThrowIfEmptyOrNull(this string str, string parameterName)
        {
            str = (str ?? string.Empty).Trim();
            if (str.Length == 0) throw new ArgumentException($"String parameter {parameterName} is empty.");
        }
    }
}