using System;
using System.Linq;
using System.Text;
using System.ComponentModel;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Validation;

namespace ZimmetTakibi.Module.BusinessObjects
{
    [DomainComponent]
    [DefaultClassOptions]
    [XafDefaultProperty("Title"), NavigationItem(false)]
    //[ImageName("BO_Contact")]
    //[XafDefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    // Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
    public interface IMarka
    {
        [RuleRequiredField]
        String Title { get; set; }
        
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[RuleRequiredField(DefaultContexts.Save)]
        //string PersistentProperty { get; set; }
        //string CalculatedProperty { get; }
        //int SumMethod(int val1, int val2);
        // ...
        // Define more data model properties and business logic contracts (http://documentation.devexpress.com/#Xaf/CustomDocument3261).

        IEquipmentType EquipmentType { get; set; }
    }

    [DomainLogic(typeof(IMarka))]
    public class MarkaLogic
    {

        public static void OnSaving(IMarka marka)
        {
            marka.Title = marka.Title.ToUpper();
        }

    }
    // Implement a business logic for a domain component (http://documentation.devexpress.com/#Xaf/CustomDocument3364).
    //[DomainLogic(typeof(IMarka))]
    //public class IMarkaLogic {
    //    public static string Get_CalculatedProperty(IMarka instance) {
    //        // A "Get_" method is executed when getting a target property value. The target property should be readonly.
    //        // Use this method to implement calculated properties.
    //        return "";
    //    }
    //    public static void AfterChange_PersistentProperty(IMarka instance) {
    //        // An "AfterChange_" method is executed after a target property is changed. The target property should not be readonly. 
    //        // Use this method to refresh dependant property values.
    //    }
    //    public static void AfterConstruction(IMarka instance) {
    //        // The "AfterConstruction" method is executed only once, after an object is created. 
    //        // Use this method to initialize new objects with default property values.
    //    }
    //    public static int SumMethod(IMarka instance, int val1, int val2) {
    //        // You can also define custom methods.
    //        return val1 + val2;
    //    }
    //}

    // Register a domain component by overriding the Setup method in a ModuleBase class descendant (http://documentation.devexpress.com/#Xaf/CustomDocument3261):
    //public override void Setup(XafApplication application) {
    //     XafTypesInfo.Instance.RegisterEntity("MyDomainComponent", typeof(IMarka));
    //     base.Setup(application);
    //}
}
