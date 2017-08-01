using System.Collections.Generic;
using Grand.Core.Plugins;
using Microsoft.AspNetCore.Routing;

namespace Grand.Services.Cms
{
    /// <summary>
    /// Provides an interface for creating widgets
    /// </summary>
    public partial interface IWidgetPlugin : IPlugin
    {
        /// <summary>
        /// Gets widget zones where this widget should be rendered
        /// </summary>
        /// <returns>Widget zones</returns>
        IList<string> GetWidgetZones();

        /// <summary>
        /// Gets a view component for displaying plugin in public store
        /// </summary>
        /// <param name="viewComponentName">View component name</param>
        void GetPublicViewComponent(out string viewComponentName);

    }
}
