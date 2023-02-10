using System.Collections.Generic;

namespace FiveStarRepos.Infra.IoC.Configuration
{
    public abstract class ValueSettings
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public IEnumerable<string> Values { get; set; }
    }

    public class HeadersValues : ValueSettings { }
}
