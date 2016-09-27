// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>NPOI.OpenXmlFormats.Dml</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------

using System.Xml.Linq;

namespace NPOI.OpenXmlFormats.Dml
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Xml;
    using System.IO;
    using NPOI.OpenXml4Net.Util;


    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_LightRig
    {

        private CT_SphereCoords rotField;

        private ST_LightRigType rigField;

        private ST_LightRigDirection dirField;

        public CT_LightRig()
        {
            //this.rotField = new CT_SphereCoords();
        }
        public static CT_LightRig Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_LightRig ctObj = new CT_LightRig();
            if (node.Attribute("rig") != null)
                ctObj.rig = (ST_LightRigType)Enum.Parse(typeof(ST_LightRigType), node.Attribute("rig").Value);
            if (node.Attribute("dir") != null)
                ctObj.dir = (ST_LightRigDirection)Enum.Parse(typeof(ST_LightRigDirection), node.Attribute("dir").Value);
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "rot")
                    ctObj.rot = CT_SphereCoords.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<a:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "rig", this.rig.ToString());
            XmlHelper.WriteAttribute(sw, "dir", this.dir.ToString());
            sw.Write(">");
            if (this.rot != null)
                this.rot.Write(sw, "rot");
            sw.Write(string.Format("</a:{0}>", nodeName));
        }

        [XmlElement(Order = 0)]
        public CT_SphereCoords rot
        {
            get
            {
                return this.rotField;
            }
            set
            {
                this.rotField = value;
            }
        }

        [XmlAttribute]
        public ST_LightRigType rig
        {
            get
            {
                return this.rigField;
            }
            set
            {
                this.rigField = value;
            }
        }

        [XmlAttribute]
        public ST_LightRigDirection dir
        {
            get
            {
                return this.dirField;
            }
            set
            {
                this.dirField = value;
            }
        }
    }

    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_LightRigType
    {

        /// <remarks/>
        legacyFlat1,

        /// <remarks/>
        legacyFlat2,

        /// <remarks/>
        legacyFlat3,

        /// <remarks/>
        legacyFlat4,

        /// <remarks/>
        legacyNormal1,

        /// <remarks/>
        legacyNormal2,

        /// <remarks/>
        legacyNormal3,

        /// <remarks/>
        legacyNormal4,

        /// <remarks/>
        legacyHarsh1,

        /// <remarks/>
        legacyHarsh2,

        /// <remarks/>
        legacyHarsh3,

        /// <remarks/>
        legacyHarsh4,

        /// <remarks/>
        threePt,

        /// <remarks/>
        balanced,

        /// <remarks/>
        soft,

        /// <remarks/>
        harsh,

        /// <remarks/>
        flood,

        /// <remarks/>
        contrasting,

        /// <remarks/>
        morning,

        /// <remarks/>
        sunrise,

        /// <remarks/>
        sunset,

        /// <remarks/>
        chilly,

        /// <remarks/>
        freezing,

        /// <remarks/>
        flat,

        /// <remarks/>
        twoPt,

        /// <remarks/>
        glow,

        /// <remarks/>
        brightRoom,
    }

    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_LightRigDirection
    {

        /// <remarks/>
        tl,

        /// <remarks/>
        t,

        /// <remarks/>
        tr,

        /// <remarks/>
        l,

        /// <remarks/>
        r,

        /// <remarks/>
        bl,

        /// <remarks/>
        b,

        /// <remarks/>
        br,
    }
}
