﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Utility {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ResourceSatis {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourceSatis() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Utility.ResourceSatis", typeof(ResourceSatis).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Müşteri Seçiniz...
        /// </summary>
        public static string cmbMusteriDefaultValue {
            get {
                return ResourceManager.GetString("cmbMusteriDefaultValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Personel Seçiniz...
        /// </summary>
        public static string cmbPersonelDefaultValue {
            get {
                return ResourceManager.GetString("cmbPersonelDefaultValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ürün Seçiniz...
        /// </summary>
        public static string cmbUrunDefaultValue {
            get {
                return ResourceManager.GetString("cmbUrunDefaultValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM TblSatis WHERE SATISID=@p1.
        /// </summary>
        public static string DeleteSatisSorgu {
            get {
                return ResourceManager.GetString("DeleteSatisSorgu", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @p1.
        /// </summary>
        public static string IdParameter {
            get {
                return ResourceManager.GetString("IdParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO TblSatis(URUN, PERSONEL, MUSTERI, TUTAR) VALUES (@p1, @p2, @p3, @p4).
        /// </summary>
        public static string InsertSatisSorgu {
            get {
                return ResourceManager.GetString("InsertSatisSorgu", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MUSTERI.
        /// </summary>
        public static string MUSTERI {
            get {
                return ResourceManager.GetString("MUSTERI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MUSTERIID.
        /// </summary>
        public static string MUSTERIID {
            get {
                return ResourceManager.GetString("MUSTERIID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @musteriParam.
        /// </summary>
        public static string MusteriParam {
            get {
                return ResourceManager.GetString("MusteriParam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @p1.
        /// </summary>
        public static string Parameter1 {
            get {
                return ResourceManager.GetString("Parameter1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @p2.
        /// </summary>
        public static string Parameter2 {
            get {
                return ResourceManager.GetString("Parameter2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @p3.
        /// </summary>
        public static string Parameter3 {
            get {
                return ResourceManager.GetString("Parameter3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @p4.
        /// </summary>
        public static string Parameter4 {
            get {
                return ResourceManager.GetString("Parameter4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PERID.
        /// </summary>
        public static string PERID {
            get {
                return ResourceManager.GetString("PERID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PERSONEL.
        /// </summary>
        public static string PERSONEL {
            get {
                return ResourceManager.GetString("PERSONEL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @personelParam.
        /// </summary>
        public static string PersonelParam {
            get {
                return ResourceManager.GetString("PersonelParam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Satış eklenemedi! Lütfen tüm bilgileri eksiksiz giriniz..
        /// </summary>
        public static string SatisEkleError {
            get {
                return ResourceManager.GetString("SatisEkleError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Satış güncellenemedi! Lütfen tüm bilgileri eksiksiz giriniz..
        /// </summary>
        public static string SatisGuncelleError {
            get {
                return ResourceManager.GetString("SatisGuncelleError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SATISID.
        /// </summary>
        public static string SATISID {
            get {
                return ResourceManager.GetString("SATISID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Satislar.aspx.
        /// </summary>
        public static string SatislarSayfasi {
            get {
                return ResourceManager.GetString("SatislarSayfasi", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SATISLAR.
        /// </summary>
        public static string spSatislar {
            get {
                return ResourceManager.GetString("spSatislar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SATISLARBYID.
        /// </summary>
        public static string spSatislarById {
            get {
                return ResourceManager.GetString("spSatislarById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TUTAR.
        /// </summary>
        public static string TUTAR {
            get {
                return ResourceManager.GetString("TUTAR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @tutarParam.
        /// </summary>
        public static string TutarParam {
            get {
                return ResourceManager.GetString("TutarParam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE TblSatis SET URUN=@urunParam, PERSONEL=@personelParam, MUSTERI=@musteriParam, TUTAR=@tutarParam WHERE SATISID=@p1.
        /// </summary>
        public static string UpdateSatisSorgu {
            get {
                return ResourceManager.GetString("UpdateSatisSorgu", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to URUNAD.
        /// </summary>
        public static string URUNAD {
            get {
                return ResourceManager.GetString("URUNAD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to URUNID.
        /// </summary>
        public static string URUNID {
            get {
                return ResourceManager.GetString("URUNID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @urunParam.
        /// </summary>
        public static string UrunParam {
            get {
                return ResourceManager.GetString("UrunParam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 0.
        /// </summary>
        public static string Zero {
            get {
                return ResourceManager.GetString("Zero", resourceCulture);
            }
        }
    }
}
