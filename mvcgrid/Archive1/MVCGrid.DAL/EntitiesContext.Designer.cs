﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace MVCGrid.DAL
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class EntitiesContext : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new EntitiesContext object using the connection string found in the 'EntitiesContext' section of the application configuration file.
        /// </summary>
        public EntitiesContext() : base("name=EntitiesContext", "EntitiesContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EntitiesContext object.
        /// </summary>
        public EntitiesContext(string connectionString) : base(connectionString, "EntitiesContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EntitiesContext object.
        /// </summary>
        public EntitiesContext(EntityConnection connection) : base(connection, "EntitiesContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Content> Contents
        {
            get
            {
                if ((_Contents == null))
                {
                    _Contents = base.CreateObjectSet<Content>("Contents");
                }
                return _Contents;
            }
        }
        private ObjectSet<Content> _Contents;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Contents EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToContents(Content content)
        {
            base.AddObject("Contents", content);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MVCGridModel", Name="Content")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Content : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Content object.
        /// </summary>
        /// <param name="contentID">Initial value of the ContentID property.</param>
        /// <param name="createDate">Initial value of the CreateDate property.</param>
        /// <param name="pageName">Initial value of the PageName property.</param>
        /// <param name="contentText">Initial value of the ContentText property.</param>
        public static Content CreateContent(global::System.Int32 contentID, global::System.DateTime createDate, global::System.String pageName, global::System.String contentText)
        {
            Content content = new Content();
            content.ContentID = contentID;
            content.CreateDate = createDate;
            content.PageName = pageName;
            content.ContentText = contentText;
            return content;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ContentID
        {
            get
            {
                return _ContentID;
            }
            set
            {
                if (_ContentID != value)
                {
                    OnContentIDChanging(value);
                    ReportPropertyChanging("ContentID");
                    _ContentID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ContentID");
                    OnContentIDChanged();
                }
            }
        }
        private global::System.Int32 _ContentID;
        partial void OnContentIDChanging(global::System.Int32 value);
        partial void OnContentIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreateDate
        {
            get
            {
                return _CreateDate;
            }
            set
            {
                OnCreateDateChanging(value);
                ReportPropertyChanging("CreateDate");
                _CreateDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CreateDate");
                OnCreateDateChanged();
            }
        }
        private global::System.DateTime _CreateDate;
        partial void OnCreateDateChanging(global::System.DateTime value);
        partial void OnCreateDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PageName
        {
            get
            {
                return _PageName;
            }
            set
            {
                OnPageNameChanging(value);
                ReportPropertyChanging("PageName");
                _PageName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PageName");
                OnPageNameChanged();
            }
        }
        private global::System.String _PageName;
        partial void OnPageNameChanging(global::System.String value);
        partial void OnPageNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ContentText
        {
            get
            {
                return _ContentText;
            }
            set
            {
                OnContentTextChanging(value);
                ReportPropertyChanging("ContentText");
                _ContentText = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ContentText");
                OnContentTextChanged();
            }
        }
        private global::System.String _ContentText;
        partial void OnContentTextChanging(global::System.String value);
        partial void OnContentTextChanged();

        #endregion

    
    }

    #endregion

    
}
