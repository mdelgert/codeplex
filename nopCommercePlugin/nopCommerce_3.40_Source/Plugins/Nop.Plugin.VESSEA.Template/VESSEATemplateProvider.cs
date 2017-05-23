using System;
using System.Linq;
using System.Web.Routing;
using Nop.Core;
using Nop.Core.Domain.Messages;
using Nop.Core.Plugins;
using Nop.Services.Common;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Logging;
using Nop.Services.Messages;
using Nop.Plugin.VESSEA.Template.Data;

namespace Nop.Plugin.VESSEA.Template
{
    public class VESSEATemplateProvider : BasePlugin, IMiscPlugin
    {
        private readonly VESSEATemplateSettings _vesseaTemplateSettings;
        private readonly ILogger _logger;
        private readonly ISettingService _settingService;
        private readonly IStoreContext _storeContext;
        private readonly VESSEATemplateObjectContext _objectContext;

        public VESSEATemplateProvider(VESSEATemplateSettings vesseaTemplateSettings,
            ILogger logger,
            ISettingService settingService,
            IStoreContext storeContext)
        {
            this._vesseaTemplateSettings = vesseaTemplateSettings;
            this._logger = logger;
            this._settingService = settingService;
            this._storeContext = storeContext;
        }


        /// <summary>
        /// Gets a route for provider configuration
        /// </summary>
        /// <param name="actionName">Action name</param>
        /// <param name="controllerName">Controller name</param>
        /// <param name="routeValues">Route values</param>
        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "VESSEATemplate";
            routeValues = new RouteValueDictionary() { { "Namespaces", "Nop.Plugin.VESSEA.TemplateController.Controllers" }, { "area", null } };
        }

        /// <summary>
        /// Install plugin
        /// </summary>
        public override void Install()
        {

            //data
            _objectContext.Install();


            //settings
            var settings = new VESSEATemplateSettings()
            {
                Test = "HelloWorldFieldName"
            };
            _settingService.SaveSetting(settings);

   

            //locales
            this.AddOrUpdatePluginLocaleResource("Plugins.VESSEA.Template.Fields.Enabled", "Enabled");

            //If forget to add this will receive log errors
            this.AddOrUpdatePluginLocaleResource("Plugins.VESSEA.Template.Fields.Enabled.Hint", "Check to enable this feature.");
            
            this.AddOrUpdatePluginLocaleResource("Plugins.VESSEA.Template.Fields.Name", "HelloWorldFieldName");


            base.Install();
        }

        /// <summary>
        /// Uninstall plugin
        /// </summary>
        public override void Uninstall()
        {

            //settings
            _settingService.DeleteSetting<VESSEATemplateSettings>();

            //data
            _objectContext.Uninstall();

            //locales
            this.DeletePluginLocaleResource("Plugins.VESSEA.Template.Fields.Enabled");
            this.DeletePluginLocaleResource("Plugins.VESSEA.Template.Fields.Enabled.Hint");
            this.DeletePluginLocaleResource("Plugins.VESSEA.Template.Fields.Name");
            base.Uninstall();
        }

    }

}
