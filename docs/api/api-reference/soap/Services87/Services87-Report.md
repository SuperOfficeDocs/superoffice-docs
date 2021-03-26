---
Generated: 1
TOCExclude: 1
title: Services87.ReportAgent WSDL
---

# Services87.ReportAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfReportService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultReportEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ApplicationToken" nillable="true" type="xs:string" />
      <xs:complexType name="SoCredentials">
        <xs:sequence>
          <xs:element minOccurs="0" name="Ticket" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoCredentials" nillable="true" type="tns:SoCredentials" />
      <xs:element name="Credentials" nillable="true" type="tns:SoCredentials" />
      <xs:complexType name="SoTimeZone">
        <xs:sequence>
          <xs:element minOccurs="0" name="SoTimeZoneId" type="xs:int" />
          <xs:element minOccurs="0" name="SoTimeZoneLocationCode" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoTimeZone" nillable="true" type="tns:SoTimeZone" />
      <xs:element name="TimeZone" nillable="true" type="tns:SoTimeZone" />
      <xs:element name="CreateDefaultReportEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReportEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ReportEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ReportId" type="xs:int" />
              <xs:element minOccurs="0" name="ReportCategory" type="tns:ReportCategory" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ReportLayout" type="tns:ReportLayout" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="TemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="Published" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ReportEntity" nillable="true" type="tns:ReportEntity" />
      <xs:complexType name="Carrier">
        <xs:sequence>
          <xs:element minOccurs="0" name="TableRight" nillable="true" type="tns:TableRight" />
          <xs:element minOccurs="0" name="FieldProperties" nillable="true" type="tns:FieldPropertyDictionary" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="Carrier" nillable="true" type="tns:Carrier" />
      <xs:complexType name="TableRight">
        <xs:sequence>
          <xs:element minOccurs="0" name="Mask" type="tns:ETableRight" />
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TableRight" nillable="true" type="tns:TableRight" />
      <xs:simpleType name="ETableRight">
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="Select" />
              <xs:enumeration value="Update" />
              <xs:enumeration value="Insert" />
              <xs:enumeration value="Delete" />
              <xs:enumeration value="Filtering" />
              <xs:enumeration value="RestrictedUpdate" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="ETableRight" nillable="true" type="tns:ETableRight" />
      <xs:complexType name="FieldPropertyDictionary">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="FieldPropertyDictionaryKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="tns:FieldProperty" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldPropertyDictionary" nillable="true" type="tns:FieldPropertyDictionary" />
      <xs:complexType name="FieldProperty">
        <xs:sequence>
          <xs:element minOccurs="0" name="FieldRight" nillable="true" type="tns:FieldRight" />
          <xs:element minOccurs="0" name="FieldType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FieldLength" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldProperty" nillable="true" type="tns:FieldProperty" />
      <xs:complexType name="FieldRight">
        <xs:sequence>
          <xs:element minOccurs="0" name="Mask" type="tns:EFieldRight" />
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldRight" nillable="true" type="tns:FieldRight" />
      <xs:simpleType name="EFieldRight">
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="Read" />
              <xs:enumeration value="Write" />
              <xs:enumeration value="Unused1" />
              <xs:enumeration value="Unused2" />
              <xs:enumeration value="Unused3" />
              <xs:enumeration value="Unused4" />
              <xs:enumeration value="UIHintMandatory" />
              <xs:enumeration value="UIHintReadOnly" />
              <xs:enumeration value="UndefinedValue256" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="EFieldRight" nillable="true" type="tns:EFieldRight" />
      <xs:simpleType name="ReportCategory">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="All" />
          <xs:enumeration value="Contact" />
          <xs:enumeration value="Project" />
          <xs:enumeration value="Sale" />
          <xs:enumeration value="Appointment" />
          <xs:enumeration value="Selection" />
          <xs:enumeration value="Person" />
          <xs:enumeration value="Diary" />
          <xs:enumeration value="Favorites" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ReportCategory" nillable="true" type="tns:ReportCategory" />
      <xs:simpleType name="ReportLayout">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="List" />
          <xs:enumeration value="Label" />
          <xs:enumeration value="GroupList" />
          <xs:enumeration value="CrossTable" />
          <xs:enumeration value="CalendarWeek5" />
          <xs:enumeration value="CalendarWeek7" />
          <xs:enumeration value="CalendarMonth" />
          <xs:enumeration value="Text" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ReportLayout" nillable="true" type="tns:ReportLayout" />
      <xs:complexType name="SoExceptionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="StackTrace" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FriendlyText" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ExceptionType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="InnerException" nillable="true" type="tns:SoExceptionInfo" />
          <xs:element minOccurs="0" name="Parameters" nillable="true" type="tns:SoExceptionInfoParameters" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExceptionInfo" nillable="true" type="tns:SoExceptionInfo" />
      <xs:complexType name="SoExceptionInfoParameters">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="SoExceptionInfoParametersKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="xs:string" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExceptionInfoParameters" nillable="true" type="tns:SoExceptionInfoParameters" />
      <xs:element name="ExceptionInfo" nillable="true" type="tns:SoExceptionInfo" />
      <xs:complexType name="SoExtraInfo">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ExtraInfoNameValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="xs:string" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExtraInfo" nillable="true" type="tns:SoExtraInfo" />
      <xs:element name="ExtraInfo" nillable="true" type="tns:SoExtraInfo" />
      <xs:element name="Succeeded" type="xs:boolean" />
      <xs:element name="SaveReportEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReportEntity" nillable="true" type="tns:ReportEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveReportEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReportEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultReportLabelLayoutEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultReportLabelLayoutEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReportLabelLayoutEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ReportLabelLayoutEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ReportLabelLayoutId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Orientation" type="tns:ReportPaperOrientation" />
              <xs:element minOccurs="0" name="PaperWidth" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="PaperHeight" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="LeftMargin" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="RightMargin" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="TopMargin" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="BottomMargin" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="CountColumns" type="xs:short" />
              <xs:element minOccurs="0" name="CountRows" type="xs:short" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ReportLabelLayoutEntity" nillable="true" type="tns:ReportLabelLayoutEntity" />
      <xs:simpleType name="ReportPaperOrientation">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Portrait" />
          <xs:enumeration value="Landscape" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ReportPaperOrientation" nillable="true" type="tns:ReportPaperOrientation" />
      <xs:element name="SaveReportLabelLayoutEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReportLabelLayoutEntity" nillable="true" type="tns:ReportLabelLayoutEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveReportLabelLayoutEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReportLabelLayoutEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteReportLabelLayoutEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReportLabelLayoutEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteReportLabelLayoutEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetReportEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReportEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetReportEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReportEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateFavorite">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SourceId" type="xs:int" />
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateFavoriteResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReportEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteFavorite">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReportEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteFavoriteResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateFavorite">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReportEntity" nillable="true" type="tns:ReportEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateFavoriteResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReportEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GenerateReport">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReportId" type="xs:int" />
            <xs:element minOccurs="0" name="LabelLayoutId" type="xs:int" />
            <xs:element minOccurs="0" name="Filename" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Language" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="FileType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfArchiveRestrictionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArchiveRestrictionInfo" nillable="true" type="tns:ArchiveRestrictionInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArchiveRestrictionInfo" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
      <xs:complexType name="ArchiveRestrictionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Operator" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Values" nillable="true" type="q1:ArrayOfstring" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="DisplayValues" nillable="true" type="q2:ArrayOfstring" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="ColumnInfo" nillable="true" type="tns:ArchiveColumnInfo" />
          <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
          <xs:element minOccurs="0" name="SubRestrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
          <xs:element minOccurs="0" name="InterParenthesis" type="xs:int" />
          <xs:element minOccurs="0" name="InterOperator" type="tns:InterRestrictionOperator" />
          <xs:element minOccurs="0" name="UniqueHash" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArchiveRestrictionInfo" nillable="true" type="tns:ArchiveRestrictionInfo" />
      <xs:complexType name="ArchiveColumnInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DisplayTooltip" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DisplayType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="CanOrderBy" type="xs:boolean" />
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="CanRestrictBy" type="xs:boolean" />
          <xs:element minOccurs="0" name="RestrictionType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="RestrictionListName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="IsVisible" type="xs:boolean" />
          <xs:element minOccurs="0" name="Width" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="IconHint" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="HeadingIconHint" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArchiveColumnInfo" nillable="true" type="tns:ArchiveColumnInfo" />
      <xs:simpleType name="InterRestrictionOperator">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="And" />
          <xs:enumeration value="Or" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="InterRestrictionOperator" nillable="true" type="tns:InterRestrictionOperator" />
      <xs:element name="GenerateReportResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ImportReport">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Report" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ImportReportResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteReport">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReportId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteReportResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetReportLabelLayoutEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReportLabelLayoutEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetReportLabelLayoutEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReportLabelLayoutEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:schema>
    <xs:schema attributeFormDefault="qualified" elementFormDefault="qualified" targetNamespace="http://schemas.microsoft.com/2003/10/Serialization/" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:tns="http://schemas.microsoft.com/2003/10/Serialization/">
      <xs:element name="anyType" nillable="true" type="xs:anyType" />
      <xs:element name="anyURI" nillable="true" type="xs:anyURI" />
      <xs:element name="base64Binary" nillable="true" type="xs:base64Binary" />
      <xs:element name="boolean" nillable="true" type="xs:boolean" />
      <xs:element name="byte" nillable="true" type="xs:byte" />
      <xs:element name="dateTime" nillable="true" type="xs:dateTime" />
      <xs:element name="decimal" nillable="true" type="xs:decimal" />
      <xs:element name="double" nillable="true" type="xs:double" />
      <xs:element name="float" nillable="true" type="xs:float" />
      <xs:element name="int" nillable="true" type="xs:int" />
      <xs:element name="long" nillable="true" type="xs:long" />
      <xs:element name="QName" nillable="true" type="xs:QName" />
      <xs:element name="short" nillable="true" type="xs:short" />
      <xs:element name="string" nillable="true" type="xs:string" />
      <xs:element name="unsignedByte" nillable="true" type="xs:unsignedByte" />
      <xs:element name="unsignedInt" nillable="true" type="xs:unsignedInt" />
      <xs:element name="unsignedLong" nillable="true" type="xs:unsignedLong" />
      <xs:element name="unsignedShort" nillable="true" type="xs:unsignedShort" />
      <xs:element name="char" nillable="true" type="tns:char" />
      <xs:simpleType name="char">
        <xs:restriction base="xs:int" />
      </xs:simpleType>
      <xs:element name="duration" nillable="true" type="tns:duration" />
      <xs:simpleType name="duration">
        <xs:restriction base="xs:duration">
          <xs:pattern value="\-?P(\d*D)?(T(\d*H)?(\d*M)?(\d*(\.\d*)?S)?)?" />
          <xs:minInclusive value="-P10675199DT2H48M5.4775808S" />
          <xs:maxInclusive value="P10675199DT2H48M5.4775807S" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="guid" nillable="true" type="tns:guid" />
      <xs:simpleType name="guid">
        <xs:restriction base="xs:string">
          <xs:pattern value="[\da-fA-F]{8}-[\da-fA-F]{4}-[\da-fA-F]{4}-[\da-fA-F]{4}-[\da-fA-F]{12}" />
        </xs:restriction>
      </xs:simpleType>
      <xs:attribute name="FactoryType" type="xs:QName" />
      <xs:attribute name="Id" type="xs:ID" />
      <xs:attribute name="Ref" type="xs:IDREF" />
    </xs:schema>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:tns="http://schemas.microsoft.com/2003/10/Serialization/Arrays">
      <xs:complexType name="ArrayOfstring">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="string" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfstring" nillable="true" type="tns:ArrayOfstring" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="CreateDefaultReportEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultReportEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultReportEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultReportEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultReportEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultReportEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveReportEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveReportEntity" />
  </wsdl:message>
  <wsdl:message name="SaveReportEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveReportEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveReportEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveReportEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultReportLabelLayoutEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultReportLabelLayoutEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultReportLabelLayoutEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultReportLabelLayoutEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultReportLabelLayoutEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultReportLabelLayoutEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveReportLabelLayoutEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveReportLabelLayoutEntity" />
  </wsdl:message>
  <wsdl:message name="SaveReportLabelLayoutEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveReportLabelLayoutEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveReportLabelLayoutEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveReportLabelLayoutEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteReportLabelLayoutEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteReportLabelLayoutEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteReportLabelLayoutEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteReportLabelLayoutEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteReportLabelLayoutEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteReportLabelLayoutEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReportEntityRequest">
    <wsdl:part name="parameters" element="tns:GetReportEntity" />
  </wsdl:message>
  <wsdl:message name="GetReportEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReportEntityResponse">
    <wsdl:part name="parameters" element="tns:GetReportEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetReportEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateFavoriteRequest">
    <wsdl:part name="parameters" element="tns:CreateFavorite" />
  </wsdl:message>
  <wsdl:message name="CreateFavoriteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateFavoriteResponse">
    <wsdl:part name="parameters" element="tns:CreateFavoriteResponse" />
  </wsdl:message>
  <wsdl:message name="CreateFavoriteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteFavoriteRequest">
    <wsdl:part name="parameters" element="tns:DeleteFavorite" />
  </wsdl:message>
  <wsdl:message name="DeleteFavoriteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteFavoriteResponse">
    <wsdl:part name="parameters" element="tns:DeleteFavoriteResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteFavoriteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateFavoriteRequest">
    <wsdl:part name="parameters" element="tns:UpdateFavorite" />
  </wsdl:message>
  <wsdl:message name="UpdateFavoriteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateFavoriteResponse">
    <wsdl:part name="parameters" element="tns:UpdateFavoriteResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateFavoriteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GenerateReportRequest">
    <wsdl:part name="parameters" element="tns:GenerateReport" />
  </wsdl:message>
  <wsdl:message name="GenerateReportRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GenerateReportResponse">
    <wsdl:part name="parameters" element="tns:GenerateReportResponse" />
  </wsdl:message>
  <wsdl:message name="GenerateReportResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ImportReportRequest">
    <wsdl:part name="parameters" element="tns:ImportReport" />
  </wsdl:message>
  <wsdl:message name="ImportReportRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ImportReportResponse">
    <wsdl:part name="parameters" element="tns:ImportReportResponse" />
  </wsdl:message>
  <wsdl:message name="ImportReportResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteReportRequest">
    <wsdl:part name="parameters" element="tns:DeleteReport" />
  </wsdl:message>
  <wsdl:message name="DeleteReportRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteReportResponse">
    <wsdl:part name="parameters" element="tns:DeleteReportResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteReportResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReportLabelLayoutEntityRequest">
    <wsdl:part name="parameters" element="tns:GetReportLabelLayoutEntity" />
  </wsdl:message>
  <wsdl:message name="GetReportLabelLayoutEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReportLabelLayoutEntityResponse">
    <wsdl:part name="parameters" element="tns:GetReportLabelLayoutEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetReportLabelLayoutEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Report">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Report</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultReportEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new ReportEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/CreateDefaultReportEntity" name="CreateDefaultReportEntityRequest" message="tns:CreateDefaultReportEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/CreateDefaultReportEntityResponse" name="CreateDefaultReportEntityResponse" message="tns:CreateDefaultReportEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveReportEntity">
      <wsdl:documentation>
        <summary>Updates the existing ReportEntity or creates a new ReportEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/SaveReportEntity" name="SaveReportEntityRequest" message="tns:SaveReportEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/SaveReportEntityResponse" name="SaveReportEntityResponse" message="tns:SaveReportEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultReportLabelLayoutEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new ReportLabelLayoutEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/CreateDefaultReportLabelLayoutEntity" name="CreateDefaultReportLabelLayoutEntityRequest" message="tns:CreateDefaultReportLabelLayoutEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/CreateDefaultReportLabelLayoutEntityResponse" name="CreateDefaultReportLabelLayoutEntityResponse" message="tns:CreateDefaultReportLabelLayoutEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveReportLabelLayoutEntity">
      <wsdl:documentation>
        <summary>Updates the existing ReportLabelLayoutEntity or creates a new ReportLabelLayoutEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/SaveReportLabelLayoutEntity" name="SaveReportLabelLayoutEntityRequest" message="tns:SaveReportLabelLayoutEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/SaveReportLabelLayoutEntityResponse" name="SaveReportLabelLayoutEntityResponse" message="tns:SaveReportLabelLayoutEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteReportLabelLayoutEntity">
      <wsdl:documentation>
        <summary>Deletes the ReportLabelLayoutEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/DeleteReportLabelLayoutEntity" name="DeleteReportLabelLayoutEntityRequest" message="tns:DeleteReportLabelLayoutEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/DeleteReportLabelLayoutEntityResponse" name="DeleteReportLabelLayoutEntityResponse" message="tns:DeleteReportLabelLayoutEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetReportEntity">
      <wsdl:documentation>
        <summary>Gets a ReportEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/GetReportEntity" name="GetReportEntityRequest" message="tns:GetReportEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/GetReportEntityResponse" name="GetReportEntityResponse" message="tns:GetReportEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateFavorite">
      <wsdl:documentation>
        <summary>Creates the report as favorite. The sourceId is the key to the report that the favorite is based on.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/CreateFavorite" name="CreateFavoriteRequest" message="tns:CreateFavoriteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/CreateFavoriteResponse" name="CreateFavoriteResponse" message="tns:CreateFavoriteResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteFavorite">
      <wsdl:documentation>
        <summary>Deletes the report favorite.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/DeleteFavorite" name="DeleteFavoriteRequest" message="tns:DeleteFavoriteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/DeleteFavoriteResponse" name="DeleteFavoriteResponse" message="tns:DeleteFavoriteResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateFavorite">
      <wsdl:documentation>
        <summary>Updates the favorite.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/UpdateFavorite" name="UpdateFavoriteRequest" message="tns:UpdateFavoriteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/UpdateFavoriteResponse" name="UpdateFavoriteResponse" message="tns:UpdateFavoriteResponse" />
    </wsdl:operation>
    <wsdl:operation name="GenerateReport">
      <wsdl:documentation>
        <summary>Generates the report in PDF format</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/GenerateReport" name="GenerateReportRequest" message="tns:GenerateReportRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/GenerateReportResponse" name="GenerateReportResponse" message="tns:GenerateReportResponse" />
    </wsdl:operation>
    <wsdl:operation name="ImportReport">
      <wsdl:documentation>
        <summary>Takes the input stream and create a report. This stream must be on a valid xml format</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/ImportReport" name="ImportReportRequest" message="tns:ImportReportRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/ImportReportResponse" name="ImportReportResponse" message="tns:ImportReportResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteReport">
      <wsdl:documentation>
        <summary>Delete the report with the given id</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/DeleteReport" name="DeleteReportRequest" message="tns:DeleteReportRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/DeleteReportResponse" name="DeleteReportResponse" message="tns:DeleteReportResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetReportLabelLayoutEntity">
      <wsdl:documentation>
        <summary>Gets a ReportLabelLayoutEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/GetReportLabelLayoutEntity" name="GetReportLabelLayoutEntityRequest" message="tns:GetReportLabelLayoutEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/GetReportLabelLayoutEntityResponse" name="GetReportLabelLayoutEntityResponse" message="tns:GetReportLabelLayoutEntityResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Report" type="tns:Report">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultReportEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/CreateDefaultReportEntity" style="document" />
      <wsdl:input name="CreateDefaultReportEntityRequest">
        <soap:header message="tns:CreateDefaultReportEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultReportEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultReportEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultReportEntityResponse">
        <soap:header message="tns:CreateDefaultReportEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultReportEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultReportEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultReportEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveReportEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/SaveReportEntity" style="document" />
      <wsdl:input name="SaveReportEntityRequest">
        <soap:header message="tns:SaveReportEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveReportEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveReportEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveReportEntityResponse">
        <soap:header message="tns:SaveReportEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveReportEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveReportEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveReportEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultReportLabelLayoutEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/CreateDefaultReportLabelLayoutEntity" style="document" />
      <wsdl:input name="CreateDefaultReportLabelLayoutEntityRequest">
        <soap:header message="tns:CreateDefaultReportLabelLayoutEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultReportLabelLayoutEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultReportLabelLayoutEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultReportLabelLayoutEntityResponse">
        <soap:header message="tns:CreateDefaultReportLabelLayoutEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultReportLabelLayoutEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultReportLabelLayoutEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultReportLabelLayoutEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveReportLabelLayoutEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/SaveReportLabelLayoutEntity" style="document" />
      <wsdl:input name="SaveReportLabelLayoutEntityRequest">
        <soap:header message="tns:SaveReportLabelLayoutEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveReportLabelLayoutEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveReportLabelLayoutEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveReportLabelLayoutEntityResponse">
        <soap:header message="tns:SaveReportLabelLayoutEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveReportLabelLayoutEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveReportLabelLayoutEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveReportLabelLayoutEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteReportLabelLayoutEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/DeleteReportLabelLayoutEntity" style="document" />
      <wsdl:input name="DeleteReportLabelLayoutEntityRequest">
        <soap:header message="tns:DeleteReportLabelLayoutEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteReportLabelLayoutEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteReportLabelLayoutEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteReportLabelLayoutEntityResponse">
        <soap:header message="tns:DeleteReportLabelLayoutEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteReportLabelLayoutEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteReportLabelLayoutEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteReportLabelLayoutEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetReportEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/GetReportEntity" style="document" />
      <wsdl:input name="GetReportEntityRequest">
        <soap:header message="tns:GetReportEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetReportEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetReportEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetReportEntityResponse">
        <soap:header message="tns:GetReportEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetReportEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetReportEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetReportEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateFavorite">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/CreateFavorite" style="document" />
      <wsdl:input name="CreateFavoriteRequest">
        <soap:header message="tns:CreateFavoriteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateFavoriteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateFavoriteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateFavoriteResponse">
        <soap:header message="tns:CreateFavoriteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateFavoriteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateFavoriteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateFavoriteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteFavorite">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/DeleteFavorite" style="document" />
      <wsdl:input name="DeleteFavoriteRequest">
        <soap:header message="tns:DeleteFavoriteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteFavoriteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteFavoriteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteFavoriteResponse">
        <soap:header message="tns:DeleteFavoriteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteFavoriteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteFavoriteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteFavoriteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateFavorite">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/UpdateFavorite" style="document" />
      <wsdl:input name="UpdateFavoriteRequest">
        <soap:header message="tns:UpdateFavoriteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateFavoriteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateFavoriteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateFavoriteResponse">
        <soap:header message="tns:UpdateFavoriteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateFavoriteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateFavoriteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateFavoriteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GenerateReport">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/GenerateReport" style="document" />
      <wsdl:input name="GenerateReportRequest">
        <soap:header message="tns:GenerateReportRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GenerateReportRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GenerateReportRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GenerateReportResponse">
        <soap:header message="tns:GenerateReportResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GenerateReportResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GenerateReportResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GenerateReportResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ImportReport">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/ImportReport" style="document" />
      <wsdl:input name="ImportReportRequest">
        <soap:header message="tns:ImportReportRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ImportReportRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ImportReportRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ImportReportResponse">
        <soap:header message="tns:ImportReportResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ImportReportResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ImportReportResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ImportReportResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteReport">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/DeleteReport" style="document" />
      <wsdl:input name="DeleteReportRequest">
        <soap:header message="tns:DeleteReportRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteReportRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteReportRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteReportResponse">
        <soap:header message="tns:DeleteReportResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteReportResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteReportResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteReportResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetReportLabelLayoutEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Report/GetReportLabelLayoutEntity" style="document" />
      <wsdl:input name="GetReportLabelLayoutEntityRequest">
        <soap:header message="tns:GetReportLabelLayoutEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetReportLabelLayoutEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetReportLabelLayoutEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetReportLabelLayoutEntityResponse">
        <soap:header message="tns:GetReportLabelLayoutEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetReportLabelLayoutEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetReportLabelLayoutEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetReportLabelLayoutEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfReportService">
    <wsdl:port name="BasicHttpBinding_Report" binding="tns:BasicHttpBinding_Report">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services87/Report.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

