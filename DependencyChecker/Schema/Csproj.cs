﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace Csproj {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Project {
        
        private ProjectPropertyGroup[] propertyGroupField;
        
        private ProjectItemGroup[] itemGroupField;
        
        private string sdkField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertyGroup")]
        public ProjectPropertyGroup[] PropertyGroup {
            get {
                return this.propertyGroupField;
            }
            set {
                this.propertyGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemGroup")]
        public ProjectItemGroup[] ItemGroup {
            get {
                return this.itemGroupField;
            }
            set {
                this.itemGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Sdk {
            get {
                return this.sdkField;
            }
            set {
                this.sdkField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ProjectPropertyGroup {
        
        private string sccProjectNameField;
        
        private string sccProviderField;
        
        private string sccAuxPathField;
        
        private string sccLocalPathField;
        
        private string targetFrameworkField;
        
        private string documentationFileField;
        
        private string generateRuntimeConfigurationFilesField;
        
        private string labelField;
        
        private string conditionField;
        
        /// <remarks/>
        public string SccProjectName {
            get {
                return this.sccProjectNameField;
            }
            set {
                this.sccProjectNameField = value;
            }
        }
        
        /// <remarks/>
        public string SccProvider {
            get {
                return this.sccProviderField;
            }
            set {
                this.sccProviderField = value;
            }
        }
        
        /// <remarks/>
        public string SccAuxPath {
            get {
                return this.sccAuxPathField;
            }
            set {
                this.sccAuxPathField = value;
            }
        }
        
        /// <remarks/>
        public string SccLocalPath {
            get {
                return this.sccLocalPathField;
            }
            set {
                this.sccLocalPathField = value;
            }
        }
        
        /// <remarks/>
        public string TargetFramework {
            get {
                return this.targetFrameworkField;
            }
            set {
                this.targetFrameworkField = value;
            }
        }
        
        /// <remarks/>
        public string DocumentationFile {
            get {
                return this.documentationFileField;
            }
            set {
                this.documentationFileField = value;
            }
        }
        
        /// <remarks/>
        public string GenerateRuntimeConfigurationFiles {
            get {
                return this.generateRuntimeConfigurationFilesField;
            }
            set {
                this.generateRuntimeConfigurationFilesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Condition {
            get {
                return this.conditionField;
            }
            set {
                this.conditionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ProjectItemGroup {
        
        private ProjectItemGroupPackageReference[] packageReferenceField;
        
        private ProjectItemGroupProjectReference projectReferenceField;
        
        private ProjectItemGroupContent[] contentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PackageReference")]
        public ProjectItemGroupPackageReference[] PackageReference {
            get {
                return this.packageReferenceField;
            }
            set {
                this.packageReferenceField = value;
            }
        }
        
        /// <remarks/>
        public ProjectItemGroupProjectReference ProjectReference {
            get {
                return this.projectReferenceField;
            }
            set {
                this.projectReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Content")]
        public ProjectItemGroupContent[] Content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ProjectItemGroupPackageReference {
        
        private string includeField;
        
        private string versionField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Include {
            get {
                return this.includeField;
            }
            set {
                this.includeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ProjectItemGroupProjectReference {
        
        private string includeField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Include {
            get {
                return this.includeField;
            }
            set {
                this.includeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ProjectItemGroupContent {
        
        private string copyToOutputDirectoryField;
        
        private string updateField;
        
        /// <remarks/>
        public string CopyToOutputDirectory {
            get {
                return this.copyToOutputDirectoryField;
            }
            set {
                this.copyToOutputDirectoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Update {
            get {
                return this.updateField;
            }
            set {
                this.updateField = value;
            }
        }
    }
}
