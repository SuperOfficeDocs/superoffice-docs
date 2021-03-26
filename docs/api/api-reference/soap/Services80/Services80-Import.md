---
Generated: 1
TOCExclude: 1
title: Services80.ImportAgent WSDL
---

# Services80.ImportAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfImportService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services80" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services80" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services80" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="PreviewImport">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ImportLines" nillable="true" type="tns:ArrayOfImportLine" />
            <xs:element minOccurs="0" name="ColumnDefinition" nillable="true" type="q1:ArrayOfstring" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Culture" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfImportLine">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ImportLine" nillable="true" type="tns:ImportLine" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfImportLine" nillable="true" type="tns:ArrayOfImportLine" />
      <xs:complexType name="ImportLine">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Values" nillable="true" type="q2:ArrayOfstring" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="Selected" type="xs:boolean" />
              <xs:element minOccurs="0" name="Operation" type="tns:ImportAction" />
              <xs:element minOccurs="0" name="Type" type="tns:ImportEntityType" />
              <xs:element minOccurs="0" name="ExternalKey" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ImportLine" nillable="true" type="tns:ImportLine" />
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
              <xs:enumeration value="Unused1" />
              <xs:enumeration value="Uninitialized" />
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
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="EFieldRight" nillable="true" type="tns:EFieldRight" />
      <xs:simpleType name="ImportAction">
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="PersonAdded" />
              <xs:enumeration value="PersonUpdated" />
              <xs:enumeration value="PersonNoChange" />
              <xs:enumeration value="ContactAdded" />
              <xs:enumeration value="ContactUpdated" />
              <xs:enumeration value="ContactNoChange" />
              <xs:enumeration value="ProductAdded" />
              <xs:enumeration value="ProductUpdated" />
              <xs:enumeration value="ProductNoChange" />
              <xs:enumeration value="Obs" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="ImportAction" nillable="true" type="tns:ImportAction" />
      <xs:simpleType name="ImportEntityType">
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="Person" />
              <xs:enumeration value="Contact" />
              <xs:enumeration value="Product" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="ImportEntityType" nillable="true" type="tns:ImportEntityType" />
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
      <xs:element name="PreviewImportResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfImportLine" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
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
      <xs:element name="SaveImport">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ImportLines" nillable="true" type="tns:ArrayOfImportLine" />
            <xs:element minOccurs="0" name="ColumnDefinition" nillable="true" type="q3:ArrayOfstring" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="CreateSelection" type="xs:boolean" />
            <xs:element minOccurs="0" name="Culture" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveImportResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q4:ArrayOfint" xmlns:q4="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultImportLine">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CountColumns" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultImportLineResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ImportLine" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateErpImportData">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Restriction" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
            <xs:element minOccurs="0" name="Columns" nillable="true" type="q5:ArrayOfstring" xmlns:q5="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="ConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ErpActorType" type="tns:ErpActorType" />
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
          <xs:element minOccurs="0" name="Values" nillable="true" type="q6:ArrayOfstring" xmlns:q6="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="DisplayValues" nillable="true" type="q7:ArrayOfstring" xmlns:q7="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
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
      <xs:simpleType name="ErpActorType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Customer" />
          <xs:enumeration value="Supplier" />
          <xs:enumeration value="Partner" />
          <xs:enumeration value="Person" />
          <xs:enumeration value="Project" />
          <xs:enumeration value="Employee" />
          <xs:enumeration value="Sale" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ErpActorType" nillable="true" type="tns:ErpActorType" />
      <xs:element name="CreateErpImportDataResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ImportErpData" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ImportErpData">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ImportLines" nillable="true" type="tns:ArrayOfImportLine" />
              <xs:element minOccurs="0" name="ColumnInfos" nillable="true" type="tns:ArrayOfImportColumnInfo" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ImportErpData" nillable="true" type="tns:ImportErpData" />
      <xs:complexType name="ArrayOfImportColumnInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ImportColumnInfo" nillable="true" type="tns:ImportColumnInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfImportColumnInfo" nillable="true" type="tns:ArrayOfImportColumnInfo" />
      <xs:complexType name="ImportColumnInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Locked" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ImportColumnInfo" nillable="true" type="tns:ImportColumnInfo" />
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
      <xs:complexType name="ArrayOfint">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="int" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfint" nillable="true" type="tns:ArrayOfint" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="PreviewImportRequest">
    <wsdl:part name="parameters" element="tns:PreviewImport" />
  </wsdl:message>
  <wsdl:message name="PreviewImportRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PreviewImportResponse">
    <wsdl:part name="parameters" element="tns:PreviewImportResponse" />
  </wsdl:message>
  <wsdl:message name="PreviewImportResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveImportRequest">
    <wsdl:part name="parameters" element="tns:SaveImport" />
  </wsdl:message>
  <wsdl:message name="SaveImportRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveImportResponse">
    <wsdl:part name="parameters" element="tns:SaveImportResponse" />
  </wsdl:message>
  <wsdl:message name="SaveImportResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultImportLineRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultImportLine" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultImportLineRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultImportLineResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultImportLineResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultImportLineResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateErpImportDataRequest">
    <wsdl:part name="parameters" element="tns:CreateErpImportData" />
  </wsdl:message>
  <wsdl:message name="CreateErpImportDataRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateErpImportDataResponse">
    <wsdl:part name="parameters" element="tns:CreateErpImportDataResponse" />
  </wsdl:message>
  <wsdl:message name="CreateErpImportDataResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Import">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Import</summary>
    </wsdl:documentation>
    <wsdl:operation name="PreviewImport">
      <wsdl:documentation>
        <summary>Preview the import</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Import/PreviewImport" name="PreviewImportRequest" message="tns:PreviewImportRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Import/PreviewImportResponse" name="PreviewImportResponse" message="tns:PreviewImportResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveImport">
      <wsdl:documentation>
        <summary>Do the actual import</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Import/SaveImport" name="SaveImportRequest" message="tns:SaveImportRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Import/SaveImportResponse" name="SaveImportResponse" message="tns:SaveImportResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultImportLine">
      <wsdl:documentation>
        <summary>Create a new empty import row with x count of values</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Import/CreateDefaultImportLine" name="CreateDefaultImportLineRequest" message="tns:CreateDefaultImportLineRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Import/CreateDefaultImportLineResponse" name="CreateDefaultImportLineResponse" message="tns:CreateDefaultImportLineResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateErpImportData">
      <wsdl:documentation>
        <summary>Populates the ImportLines and columnDefs basedfrom erp system</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Import/CreateErpImportData" name="CreateErpImportDataRequest" message="tns:CreateErpImportDataRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Import/CreateErpImportDataResponse" name="CreateErpImportDataResponse" message="tns:CreateErpImportDataResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Import" type="tns:Import">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="PreviewImport">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Import/PreviewImport" style="document" />
      <wsdl:input name="PreviewImportRequest">
        <soap:header message="tns:PreviewImportRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:PreviewImportRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:PreviewImportRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="PreviewImportResponse">
        <soap:header message="tns:PreviewImportResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:PreviewImportResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:PreviewImportResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:PreviewImportResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveImport">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Import/SaveImport" style="document" />
      <wsdl:input name="SaveImportRequest">
        <soap:header message="tns:SaveImportRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveImportRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveImportRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveImportResponse">
        <soap:header message="tns:SaveImportResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveImportResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveImportResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveImportResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultImportLine">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Import/CreateDefaultImportLine" style="document" />
      <wsdl:input name="CreateDefaultImportLineRequest">
        <soap:header message="tns:CreateDefaultImportLineRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultImportLineRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultImportLineRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultImportLineResponse">
        <soap:header message="tns:CreateDefaultImportLineResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultImportLineResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultImportLineResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultImportLineResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateErpImportData">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Import/CreateErpImportData" style="document" />
      <wsdl:input name="CreateErpImportDataRequest">
        <soap:header message="tns:CreateErpImportDataRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateErpImportDataRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateErpImportDataRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateErpImportDataResponse">
        <soap:header message="tns:CreateErpImportDataResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateErpImportDataResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateErpImportDataResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateErpImportDataResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfImportService">
    <wsdl:port name="BasicHttpBinding_Import" binding="tns:BasicHttpBinding_Import">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services80/Import.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

