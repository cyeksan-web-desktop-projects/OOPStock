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
    public class ResourceUrun {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourceUrun() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Utility.ResourceUrun", typeof(ResourceUrun).Assembly);
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
        ///   Looks up a localized string similar to @adetParam.
        /// </summary>
        public static string AdetParam {
            get {
                return ResourceManager.GetString("AdetParam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @adParam.
        /// </summary>
        public static string AdParam {
            get {
                return ResourceManager.GetString("AdParam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM TblSatis WHERE URUN=@p1; DELETE FROM TblUrun WHERE URUNID=@p1.
        /// </summary>
        public static string DeleteUrunSorgu {
            get {
                return ResourceManager.GetString("DeleteUrunSorgu", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @fiyatParam.
        /// </summary>
        public static string FiyatParam {
            get {
                return ResourceManager.GetString("FiyatParam", resourceCulture);
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
        ///   Looks up a localized string similar to INSERT INTO TblUrun(URUNAD, URUNFIYAT, URUNADET) VALUES(@p1, @p2, @p3).
        /// </summary>
        public static string InsertUrunSorgu {
            get {
                return ResourceManager.GetString("InsertUrunSorgu", resourceCulture);
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
        ///   Looks up a localized string similar to SELECT * FROM TblUrun WHERE URUNID=@p1.
        /// </summary>
        public static string SelectUrunByIdSorgu {
            get {
                return ResourceManager.GetString("SelectUrunByIdSorgu", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM TblUrun.
        /// </summary>
        public static string SelectUrunSorgu {
            get {
                return ResourceManager.GetString("SelectUrunSorgu", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE TblUrun SET URUNAD=@adParam, URUNFIYAT=@fiyatParam, URUNADET=@adetParam WHERE URUNID=@p1.
        /// </summary>
        public static string UpdateUrunSorgu {
            get {
                return ResourceManager.GetString("UpdateUrunSorgu", resourceCulture);
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
        ///   Looks up a localized string similar to URUNADET.
        /// </summary>
        public static string URUNADET {
            get {
                return ResourceManager.GetString("URUNADET", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ürün eklenemedi! Lütfen tüm bilgileri eksiksiz giriniz..
        /// </summary>
        public static string UrunEkleError {
            get {
                return ResourceManager.GetString("UrunEkleError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to URUNFIYAT.
        /// </summary>
        public static string URUNFIYAT {
            get {
                return ResourceManager.GetString("URUNFIYAT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ürün güncellenemedi! Lütfen tüm bilgileri eksiksiz giriniz..
        /// </summary>
        public static string UrunGuncelleError {
            get {
                return ResourceManager.GetString("UrunGuncelleError", resourceCulture);
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
        ///   Looks up a localized string similar to Urunler.aspx.
        /// </summary>
        public static string UrunlerSayfasi {
            get {
                return ResourceManager.GetString("UrunlerSayfasi", resourceCulture);
            }
        }
    }
}
