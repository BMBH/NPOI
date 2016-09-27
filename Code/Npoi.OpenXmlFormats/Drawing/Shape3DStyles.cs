// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>NPOI.OpenXmlFormats.Dml</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>True</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------

using System.Xml.Linq;

namespace NPOI.OpenXmlFormats.Dml {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    using NPOI.OpenXml4Net.Util;
    using System.IO;
    using System.Xml;
    
    

    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace="http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace="http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable=true)]
    public class CT_Bevel {
        
        private long wField;
        
        private long hField;
        
        private ST_BevelPresetType prstField;
        public static CT_Bevel Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Bevel ctObj = new CT_Bevel();
            ctObj.w = XmlHelper.ReadLong(node.Attribute("w"));
            ctObj.h = XmlHelper.ReadLong(node.Attribute("h"));
            if (node.Attribute("prst") != null)
                ctObj.prst = (ST_BevelPresetType)Enum.Parse(typeof(ST_BevelPresetType), node.Attribute("prst").Value);
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<a:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "w", this.w);
            XmlHelper.WriteAttribute(sw, "h", this.h);
            XmlHelper.WriteAttribute(sw, "prst", this.prst.ToString());
            sw.Write(">");
            sw.Write(string.Format("</a:{0}>", nodeName));
        }

        public CT_Bevel() {
            this.wField = ((long)(76200));
            this.hField = ((long)(76200));
            this.prstField = ST_BevelPresetType.circle;
        }
        
        [XmlAttribute]
        [DefaultValue(typeof(long), "76200")]
        public long w {
            get {
                return this.wField;
            }
            set {
                this.wField = value;
            }
        }
        
        [XmlAttribute]
        [DefaultValue(typeof(long), "76200")]
        public long h {
            get {
                return this.hField;
            }
            set {
                this.hField = value;
            }
        }
        
        [XmlAttribute]
        [DefaultValue(ST_BevelPresetType.circle)]
        public ST_BevelPresetType prst {
            get {
                return this.prstField;
            }
            set {
                this.prstField = value;
            }
        }
    }
    

    [Serializable]
    [XmlType(Namespace="http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_BevelPresetType {
        
        /// <remarks/>
        relaxedInset,
        
        /// <remarks/>
        circle,
        
        /// <remarks/>
        slope,
        
        /// <remarks/>
        cross,
        
        /// <remarks/>
        angle,
        
        /// <remarks/>
        softRound,
        
        /// <remarks/>
        convex,
        
        /// <remarks/>
        coolSlant,
        
        /// <remarks/>
        divot,
        
        /// <remarks/>
        riblet,
        
        /// <remarks/>
        hardEdge,
        
        /// <remarks/>
        artDeco,
    }
    

    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace="http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace="http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable=true)]
    public class CT_Shape3D {
        
        private CT_Bevel bevelTField;
        
        private CT_Bevel bevelBField;
        
        private CT_Color extrusionClrField;
        
        private CT_Color contourClrField;
        
        private CT_OfficeArtExtensionList extLstField;
        
        private long zField;
        
        private long extrusionHField;
        
        private long contourWField;
        
        private ST_PresetMaterialType prstMaterialField;
        public static CT_Shape3D Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Shape3D ctObj = new CT_Shape3D();
            ctObj.z = XmlHelper.ReadLong(node.Attribute("z"));
            ctObj.extrusionH = XmlHelper.ReadLong(node.Attribute("extrusionH"));
            ctObj.contourW = XmlHelper.ReadLong(node.Attribute("contourW"));
            if (node.Attribute("prstMaterial") != null)
                ctObj.prstMaterial = (ST_PresetMaterialType)Enum.Parse(typeof(ST_PresetMaterialType), node.Attribute("prstMaterial").Value);
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "bevelT")
                    ctObj.bevelT = CT_Bevel.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "bevelB")
                    ctObj.bevelB = CT_Bevel.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "extrusionClr")
                    ctObj.extrusionClr = CT_Color.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "contourClr")
                    ctObj.contourClr = CT_Color.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "extLst")
                    ctObj.extLst = CT_OfficeArtExtensionList.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<a:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "z", this.z);
            XmlHelper.WriteAttribute(sw, "extrusionH", this.extrusionH);
            XmlHelper.WriteAttribute(sw, "contourW", this.contourW);
            XmlHelper.WriteAttribute(sw, "prstMaterial", this.prstMaterial.ToString());
            sw.Write(">");
            if (this.bevelT != null)
                this.bevelT.Write(sw, "bevelT");
            if (this.bevelB != null)
                this.bevelB.Write(sw, "bevelB");
            if (this.extrusionClr != null)
                this.extrusionClr.Write(sw, "extrusionClr");
            if (this.contourClr != null)
                this.contourClr.Write(sw, "contourClr");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</a:{0}>", nodeName));
        }

        public CT_Shape3D() {
            //this.extLstField = new CT_OfficeArtExtensionList();
            //this.contourClrField = new CT_Color();
            //this.extrusionClrField = new CT_Color();
            //this.bevelBField = new CT_Bevel();
            //this.bevelTField = new CT_Bevel();
            this.zField = ((long)(0));
            this.extrusionHField = ((long)(0));
            this.contourWField = ((long)(0));
            this.prstMaterialField = ST_PresetMaterialType.warmMatte;
        }
        
        [XmlElement(Order=0)]
        public CT_Bevel bevelT {
            get {
                return this.bevelTField;
            }
            set {
                this.bevelTField = value;
            }
        }
        
        [XmlElement(Order=1)]
        public CT_Bevel bevelB {
            get {
                return this.bevelBField;
            }
            set {
                this.bevelBField = value;
            }
        }
        
        [XmlElement(Order=2)]
        public CT_Color extrusionClr {
            get {
                return this.extrusionClrField;
            }
            set {
                this.extrusionClrField = value;
            }
        }
        
        [XmlElement(Order=3)]
        public CT_Color contourClr {
            get {
                return this.contourClrField;
            }
            set {
                this.contourClrField = value;
            }
        }
        
        [XmlElement(Order=4)]
        public CT_OfficeArtExtensionList extLst {
            get {
                return this.extLstField;
            }
            set {
                this.extLstField = value;
            }
        }
        
        [XmlAttribute]
        [DefaultValue(typeof(long), "0")]
        public long z {
            get {
                return this.zField;
            }
            set {
                this.zField = value;
            }
        }
        
        [XmlAttribute]
        [DefaultValue(typeof(long), "0")]
        public long extrusionH {
            get {
                return this.extrusionHField;
            }
            set {
                this.extrusionHField = value;
            }
        }
        
        [XmlAttribute]
        [DefaultValue(typeof(long), "0")]
        public long contourW {
            get {
                return this.contourWField;
            }
            set {
                this.contourWField = value;
            }
        }
        
        [XmlAttribute]
        [DefaultValue(ST_PresetMaterialType.warmMatte)]
        public ST_PresetMaterialType prstMaterial {
            get {
                return this.prstMaterialField;
            }
            set {
                this.prstMaterialField = value;
            }
        }
    }

    [Serializable]
    [XmlType(Namespace="http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_PresetMaterialType {
        
        /// <remarks/>
        legacyMatte,
        
        /// <remarks/>
        legacyPlastic,
        
        /// <remarks/>
        legacyMetal,
        
        /// <remarks/>
        legacyWireframe,
        
        /// <remarks/>
        matte,
        
        /// <remarks/>
        plastic,
        
        /// <remarks/>
        metal,
        
        /// <remarks/>
        warmMatte,
        
        /// <remarks/>
        translucentPowder,
        
        /// <remarks/>
        powder,
        
        /// <remarks/>
        dkEdge,
        
        /// <remarks/>
        softEdge,
        
        /// <remarks/>
        clear,
        
        /// <remarks/>
        flat,
        
        /// <remarks/>
        softmetal,
    }
    

    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace="http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace="http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable=true)]
    public class CT_FlatText {
        
        private long zField;
        
        public CT_FlatText() {
            this.zField = ((long)(0));
        }
        public static CT_FlatText Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_FlatText ctObj = new CT_FlatText();
            ctObj.z = XmlHelper.ReadLong(node.Attribute("z"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<a:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "z", this.z);
            sw.Write(">");
            sw.Write(string.Format("</a:{0}>", nodeName));
        }

        [XmlAttribute]
        [DefaultValue(typeof(long), "0")]
        public long z {
            get {
                return this.zField;
            }
            set {
                this.zField = value;
            }
        }
    }
}
