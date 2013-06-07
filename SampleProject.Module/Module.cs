using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Model.Core;
using DevExpress.ExpressApp.Validation;
using SampleProject.Module.Infrastructure;

namespace SampleProject.Module
{
    public sealed partial class SampleProjectModule : ModuleBase
    {
        public SampleProjectModule()
        {
            InitializeComponent();
        }

        public override void AddGeneratorUpdaters(ModelNodesGeneratorUpdaters updaters)
        {
            base.AddGeneratorUpdaters(updaters);
        }

        public override void Setup(ApplicationModulesManager moduleManager)
        {
            base.Setup(moduleManager);
            var registrator = new ValidationRulesRegistrator(moduleManager);

        }

        public override void ExtendModelInterfaces(DevExpress.ExpressApp.Model.ModelInterfaceExtenders extenders)
        {
            base.ExtendModelInterfaces(extenders);

            extenders.Add<IModelLayoutItem, IModelLayoutItemTooltip>();
            extenders.Add<IModelMember, IModelMemberTooltip>();
        }
    }
}
