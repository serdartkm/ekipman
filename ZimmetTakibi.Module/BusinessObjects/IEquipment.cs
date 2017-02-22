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
    [DefaultClassOptions]
    [XafDefaultProperty("SerialNumber"),XafDisplayName("Ekipman")]
    //[ImageName("BO_Contact")]
    //[XafDefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    // Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
    public interface IEquipment
    {

        
         String SeriNumara { get; set; }
         [ImmediatePostData]
         [RuleRequiredField]
      
         IEquipmentType EquipmentType { get; set; }

         [RuleRequiredField]
         [DataSourceProperty("EquipmentType.Markas"), ImmediatePostData]
         IMarka Marka { get; set; }
         [RuleRequiredField]
         [DataSourceProperty("EquipmentType.Models"), ImmediatePostData]
       
         IModel Model { get; set; }

         String InventarNumara { get; set; }

        [RuleRequiredField]
        String Açýklama { get; set; }

       
    
        IEmployee Çalýþan { get; set; }


        DateTime ZimmetTarihi { get; set; }

        DateTime GeriTeslimTarihi { get; set; }
        // Define more data model properties and business logic contracts (http://documentation.devexpress.com/#Xaf/CustomDocument3261).
        [RuleRequiredField]
        ILocation BulunduguLokasiyon { get; set; }
    }

    [DomainLogic(typeof(IEquipment))]
    public class EquipmentLogic
    {

        public static void OnSaving(IEquipment eq)
        {

            eq.SeriNumara = eq.SeriNumara.ToUpper();
            eq.InventarNumara = eq.InventarNumara.ToUpper();

        }

    }

    // Implement a business logic for a domain component (http://documentation.devexpress.com/#Xaf/CustomDocument3364).
    //[DomainLogic(typeof(IEquipment))]
    //public class IEquipmentLogic {
    //    public static string Get_CalculatedProperty(IEquipment instance) {
    //        // A "Get_" method is executed when getting a target property value. The target property should be readonly.
    //        // Use this method to implement calculated properties.
    //        return "";
    //    }
    //    public static void AfterChange_PersistentProperty(IEquipment instance) {
    //        // An "AfterChange_" method is executed after a target property is changed. The target property should not be readonly. 
    //        // Use this method to refresh dependant property values.
    //    }
    //    public static void AfterConstruction(IEquipment instance) {
    //        // The "AfterConstruction" method is executed only once, after an object is created. 
    //        // Use this method to initialize new objects with default property values.
    //    }
    //    public static int SumMethod(IEquipment instance, int val1, int val2) {
    //        // You can also define custom methods.
    //        return val1 + val2;
    //    }
    //}

    // Register a domain component by overriding the Setup method in a ModuleBase class descendant (http://documentation.devexpress.com/#Xaf/CustomDocument3261):
    //public override void Setup(XafApplication application) {
    //     XafTypesInfo.Instance.RegisterEntity("MyDomainComponent", typeof(IEquipment));
    //     base.Setup(application);
    //}
}
