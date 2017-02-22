using System;
using System.Text;
using System.Linq;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using System.Collections.Generic;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Model.Core;
using DevExpress.ExpressApp.Model.DomainLogics;
using DevExpress.ExpressApp.Model.NodeGenerators;
using ZimmetTakibi.Module.BusinessObjects;

namespace ZimmetTakibi.Module
{
    // For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppModuleBasetopic.
    public sealed partial class ZimmetTakibiModule : ModuleBase
    {
        public ZimmetTakibiModule()
        {
            InitializeComponent();
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB)
        {
            ModuleUpdater updater = new DatabaseUpdate.Updater(objectSpace, versionFromDB);
            return new ModuleUpdater[] { updater };
        }
        public override void Setup(XafApplication application)
        {
            base.Setup(application);
            // Manage various aspects of the application UI and behavior at the module level.

            XafTypesInfo.Instance.RegisterEntity("Employee", typeof(IEmployee));
            XafTypesInfo.Instance.RegisterEntity("Department", typeof(IDepartment));
            XafTypesInfo.Instance.RegisterEntity("Project", typeof(IProject));
            XafTypesInfo.Instance.RegisterEntity("Position", typeof(IPosition));
            XafTypesInfo.Instance.RegisterEntity("Equipment", typeof(IEquipment));
            XafTypesInfo.Instance.RegisterEntity("EquipmentType", typeof(IEquipmentType));
     
            XafTypesInfo.Instance.RegisterEntity("Marka", typeof(IMarka));
            XafTypesInfo.Instance.RegisterEntity("Model", typeof(IModel));

            XafTypesInfo.Instance.RegisterEntity("Location", typeof(ILocation));
        }
    }
}
