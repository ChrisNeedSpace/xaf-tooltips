using System;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace SampleProject.Module.Web
{
    [ToolboxItemFilter("Xaf.Platform.Web")]
    public sealed partial class SampleProjectAspNetModule : ModuleBase
    {
        public SampleProjectAspNetModule()
        {
            InitializeComponent();
        }
    }
}
