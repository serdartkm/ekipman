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
    [XafDefaultProperty("ProjectTitle"), NavigationItem(false)]
    //[ImageName("BO_Contact")]
    //[XafDefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    // Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
    public interface IProject
    {

         [RuleRequiredField]
        String ProjectTitle { get; set; }

        // ...
        // Define more data model properties and business logic contracts (http://documentation.devexpress.com/#Xaf/CustomDocument3261).
    }

    [DomainLogic(typeof(IProject))]
    public class ProjectLogic
    {

        public static void OnSaving(IProject pr)
        {

            pr.ProjectTitle = pr.ProjectTitle.ToUpper();
        }

    }

    // Implement a business logic for a domain component (http://documentation.devexpress.com/#Xaf/CustomDocument3364).
    //[DomainLogic(typeof(IProject))]
    //public class IProjectLogic {
    //    public static string Get_CalculatedProperty(IProject instance) {
    //        // A "Get_" method is executed when getting a target property value. The target property should be readonly.
    //        // Use this method to implement calculated properties.
    //        return "";
    //    }
    //    public static void AfterChange_PersistentProperty(IProject instance) {
    //        // An "AfterChange_" method is executed after a target property is changed. The target property should not be readonly. 
    //        // Use this method to refresh dependant property values.
    //    }
    //    public static void AfterConstruction(IProject instance) {
    //        // The "AfterConstruction" method is executed only once, after an object is created. 
    //        // Use this method to initialize new objects with default property values.
    //    }
    //    public static int SumMethod(IProject instance, int val1, int val2) {
    //        // You can also define custom methods.
    //        return val1 + val2;
    //    }
    //}

    // Register a domain component by overriding the Setup method in a ModuleBase class descendant (http://documentation.devexpress.com/#Xaf/CustomDocument3261):
    //public override void Setup(XafApplication application) {
    //     XafTypesInfo.Instance.RegisterEntity("MyDomainComponent", typeof(IProject));
    //     base.Setup(application);
    //}
}
