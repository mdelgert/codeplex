using Nop.Core.Configuration;

namespace Nop.Plugin.VESSEA.Template
{
    public class VESSEATemplateSettings : ISettings
    {
        /// <summary>
        /// Gets or sets the value indicting whether this VESSEA provider is enabled
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the test
        /// </summary>
        public string Test { get; set; }
    }

}