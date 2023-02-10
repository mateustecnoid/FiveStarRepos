using System.Text;
using System.Text.RegularExpressions;

namespace FiveStarRepos.UnitTests.Util
{
    public static class FactoryUtil
    {
        private static readonly Random _random = new();
        public static string RandomString(int tamanho)
        {
            var builder = new StringBuilder(tamanho);
            const int lettersOffset = 26;

            for (var i = 0; i < tamanho; i++)
            {
                var @char = (char)_random.Next(lettersOffset);
                builder.Append(@char);
            }

            return builder.ToString();
        }

        public static string SplitCamelCase(this string str)
        {
            return Regex.Replace(Regex.Replace(str, @"(\P{Ll})(\P{Ll}\p{Ll})", "$1 $2"), @"(\p{Ll})(\P{Ll})", "$1 $2");
        }
    }
}
