﻿using Grand.Framework.Mvc.Models;
using Grand.Framework.Mvc.ModelBinding;

namespace Grand.Web.Areas.Admin.Models.Settings
{
    public partial class SettingFilterModel : BaseGrandModel
    {
        [GrandResourceDisplayName("Admin.Configuration.Settings.Filter.Name")]
        public string SettingFilterName { get; set; }

        [GrandResourceDisplayName("Admin.Configuration.Settings.Filter.Value")]
        public string SettingFilterValue { get; set; }

    }
}