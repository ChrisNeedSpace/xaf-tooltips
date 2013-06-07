using System;

namespace SampleProject.Module.Infrastructure
{
    /// <summary>
    /// Specifies the tooltip text that will be displayed on the control when the mouse rolls over.
    /// Tooltip can be given in the code attribute or from the model designer (Model.DesignedDiffs.xafml).
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class TooltipAttribute : Attribute
    {
        public static TooltipAttribute Default = new TooltipAttribute(null);
        
        public TooltipAttribute(string value) { Tooltip = value; }
        public string Tooltip { get; set; }
    }
}