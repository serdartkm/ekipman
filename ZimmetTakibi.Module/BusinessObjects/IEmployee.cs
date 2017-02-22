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
using DevExpress.Persistent.BaseImpl;

namespace ZimmetTakibi.Module.BusinessObjects
{
    [DomainComponent]
    [DefaultClassOptions,XafDisplayName("Çalýþan")]
    [XafDefaultProperty("Fullname")]
    //[ImageName("BO_Contact")]
    //[XafDefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    // Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
    public interface IEmployee
    {
         [RuleRequiredField]
        String Adý { get; set; }

         [RuleRequiredField]
        String Soyadý { get; set; }

         [RuleRequiredField]
        IPosition Görevi { get; set; }

         [RuleRequiredField]
        IDepartment Department { get; set; }


         String KullanýcýBelgisi { get; set; }

         [RuleRequiredField]
         IProject Projesi { get; set; }
         String EmailAdresi { get; set; }

         [RuleRequiredField]
        String SicilNumara { get; set; }

         FileData ZimmetKopiyasi { get; set; }

        String Fullname {get;}
        IList<IEquipment> Equipment { get; }
        // ...
        // Define more data model properties and business logic contracts (http://documentation.devexpress.com/#Xaf/CustomDocument3261).
    }
     [DomainLogic(typeof(IEmployee))]
    public class EmployeeLogic
    {

         public static String Get_Fullname(IEmployee emp)
         {

             if(emp.Adý != null && emp.Soyadý !=null ){


                 return emp.Adý + ' ' + emp.Soyadý;
             }
             else
             {
                 //return null
                 return null;
             }
         }

         public static void OnSaving(IEmployee emp)
         {
            emp.Adý= emp.Adý.ToUpper();
            emp.Soyadý= emp.Soyadý.ToUpper();
         }

    }

    // Implement a business logic for a domain component (http://documentation.devexpress.com/#Xaf/CustomDocument3364).
    //[DomainLogic(typeof(IEmployee))]
    //public class IEmployeeLogic {
    //    public static string Get_CalculatedProperty(IEmployee instance) {
    //        // A "Get_" method is executed when getting a target property value. The target property should be readonly.
    //        // Use this method to implement calculated properties.
    //        return "";
    //    }
    //    public static void AfterChange_PersistentProperty(IEmployee instance) {
    //        // An "AfterChange_" method is executed after a target property is changed. The target property should not be readonly. 
    //        // Use this method to refresh dependant property values.
    //    }
    //    public static void AfterConstruction(IEmployee instance) {
    //        // The "AfterConstruction" method is executed only once, after an object is created. 
    //        // Use this method to initialize new objects with default property values.
    //    }
    //    public static int SumMethod(IEmployee instance, int val1, int val2) {
    //        // You can also define custom methods.
    //        return val1 + val2;
    //    }
    //}

    // Register a domain component by overriding the Setup method in a ModuleBase class descendant (http://documentation.devexpress.com/#Xaf/CustomDocument3261):
    //public override void Setup(XafApplication application) {
    //     XafTypesInfo.Instance.RegisterEntity("MyDomainComponent", typeof(IEmployee));
    //     base.Setup(application);
    //}
}
