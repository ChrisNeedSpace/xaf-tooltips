using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;

namespace SampleProject.Module.Infrastructure
{
    public interface IModelMemberTooltip
    {
        [Category("Behavior")]
        string Tooltip { get; set; }
    }

    public interface IModelLayoutItemTooltip
    {
        [Category("Behavior")]
        string Tooltip { get; set; }
    }

    [DomainLogic(typeof(IModelMemberTooltip))]
    public static class ModelMemberTooltipLogic
    {
        public static string Get_Tooltip(IModelMember modelMember)
        {
            if (modelMember != null && modelMember.MemberInfo != null)
            {
                TooltipAttribute attribute = modelMember.MemberInfo.FindAttribute<TooltipAttribute>();
                if (attribute != null)
                    return attribute.Tooltip;
            }
            return null;
        }
    }
}
