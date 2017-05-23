using System;
using System.Web.Mvc;
using Nop.Core.Plugins;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Web.Framework.Controllers;
using Nop.Plugin.VESSEA.Template;
using Nop.Plugin.VESSEA.Template.Models;

namespace Nop.Plugin.VESSEA.Template.Controllers
{
    
    public class VESSEATemplateController : BasePluginController
    {
        private readonly VESSEATemplateSettings _vesseaTemplateSettings;
        private readonly ISettingService _settingService;
        private readonly IPluginFinder _pluginFinder;
        private readonly ILocalizationService _localizationService;

        public VESSEATemplateController(VESSEATemplateSettings vesseaTemplateSettings,
            ISettingService settingService, IPluginFinder pluginFinder,
            ILocalizationService localizationService)
        {
            this._vesseaTemplateSettings = vesseaTemplateSettings;
            this._settingService = settingService;
        }

        public ActionResult Notes()
        {
            return View("~/Plugins/VESSEA.Template/Views/Notes.cshtml", null);
        }

        
        public ActionResult License()
        {
            return View("~/Plugins/VESSEA.Template/Views/License.cshtml", null);
        }

        [AdminAuthorize]
        [ChildActionOnly]
        public ActionResult Configure()
        {
            var model = new VESSEATemplateModel();
            model.Enabled = _vesseaTemplateSettings.Enabled;
            return View("~/Plugins/VESSEA.Template/Views/Configure.cshtml", model);
        }

        [AdminAuthorize]
        [ChildActionOnly]
        [HttpPost, ActionName("Configure")]
        [FormValueRequired("save")]
        public ActionResult ConfigurePOST(VESSEATemplateModel model)
        {
            if (!ModelState.IsValid)
            {
                return Configure();
            }

            //save settings
            _vesseaTemplateSettings.Enabled = model.Enabled;
            _settingService.SaveSetting(_vesseaTemplateSettings);

            return Configure();
        }

    }

}
