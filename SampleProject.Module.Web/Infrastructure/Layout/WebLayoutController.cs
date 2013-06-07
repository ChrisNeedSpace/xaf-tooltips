using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Web.Layout;

namespace SampleProject.Module.Web.Infrastructure
{
    public partial class WebLayoutController : ViewController<DetailView>
    {
        protected override void OnActivated()
        {
            base.OnActivated();
            View.ControlsCreating += new EventHandler(View_ControlsCreating);
        }
        protected override void OnDeactivated()
        {
            View.ControlsCreating -= new EventHandler(View_ControlsCreating);
            base.OnDeactivated();
        }
        private void View_ControlsCreating(object sender, EventArgs e)
        {
            UpdateLayoutManagerTemplates();
        }
        private void UpdateLayoutManagerTemplates()
        {
            WebLayoutManager layoutManager = View.LayoutManager as WebLayoutManager;
            if (layoutManager != null)
            {
                LayoutBaseTemplate itemTemplate = new CustomLayoutItemTemplate();  // new LayoutItemTemplate();
                layoutManager.LayoutItemTemplate = itemTemplate;
            }
        }

    }
}
