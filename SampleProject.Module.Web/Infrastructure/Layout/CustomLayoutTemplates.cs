using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Web.Layout;
using SampleProject.Module.Infrastructure;

namespace SampleProject.Module.Web.Infrastructure
{
    public class CustomLayoutItemTemplate : LayoutItemTemplate
    {
        protected override TableCell CreateCaptionCell(LayoutItemTemplateContainer templateContainer)
        {
            //// TODO: uncomment if using CaptionWidth:

            //// INTEGRATION with CaptionWidth mechanism:
            //int captionWidth = 0;
            //if (templateContainer.Model is IModelLayoutCaptionWidth)
            //    captionWidth = (templateContainer.Model as IModelLayoutCaptionWidth).CaptionWidth;
            //if (captionWidth > 0)
            //    templateContainer.CaptionWidth = Unit.Pixel(captionWidth);

            return base.CreateCaptionCell(templateContainer);
        }
        protected override Control CreateCaptionControl(LayoutItemTemplateContainer templateContainer)
        {
            Control baseControl = base.CreateCaptionControl(templateContainer);
            
            string tooltip = GetTooltip(templateContainer);
            if (!string.IsNullOrEmpty(tooltip))
                return CreateTooltipTable(baseControl, tooltip);
            
            return baseControl;
        }

        private static Table CreateTooltipTable(Control baseControl, string tooltip)
        {
            Table table = new Table();
            table.Rows.Add(new TableRow());
            table.Rows[0].Cells.Add(new TableCell());
            table.Rows[0].Cells[0].Controls.Add(baseControl);

            //string title = string.Format("Description for the '{0}' item", templateContainer.ViewItem.Caption);
            Image image = new Image() { ImageUrl = "/Images/questionmark.png", ToolTip = tooltip, BorderWidth = 0, CssClass = "tooltip-image" };
            //    image.Style["margin"] = "5px";
            table.Rows[0].Cells.Add(new TableCell());
            table.Rows[0].Cells[1].Controls.Add(image);
            return table;
        }

        private static string GetTooltip(LayoutItemTemplateContainer templateContainer)
        {
            // tooltip from model (if anything was defined in the designer - that value has a priority)
            IModelLayoutItemTooltip modelLayoutItemTooltip = templateContainer.Model as IModelLayoutItemTooltip;
            if (modelLayoutItemTooltip != null && !string.IsNullOrEmpty(modelLayoutItemTooltip.Tooltip))
            {
                return modelLayoutItemTooltip.Tooltip;
            }

            // tooltip from attribute
            if ((templateContainer.Model as IModelLayoutItem).ViewItem is IModelPropertyEditor)
            {
                IModelMember modelMember = ((templateContainer.Model as IModelLayoutItem).ViewItem as IModelPropertyEditor).ModelMember;
                if (modelMember is IModelMemberTooltip)
                    return ((IModelMemberTooltip)modelMember).Tooltip;
            }
            
            return "";
        }

    }
}
