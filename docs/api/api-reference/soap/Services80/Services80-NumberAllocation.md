---
Generated: 1
TOCExclude: 1
title: Services80.NumberAllocationAgent WSDL
---

# Services80.NumberAllocationAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfNumberAllocationService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services80" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services80" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services80" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:element name="CreateDefaultRefCountEntity">
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
      <xs:element name="CreateDefaultRefCountEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:RefCountEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="RefCountEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="RefCountsId" type="xs:int" />
              <xs:element minOccurs="0" name="Field" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RecordId" type="xs:int" />
              <xs:element minOccurs="0" name="SuggestedRecords" nillable="true" type="tns:ArrayOfMDOListItem" />
              <xs:element minOccurs="0" name="CurrentValue" type="xs:int" />
              <xs:element minOccurs="0" name="TravelPrefix" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="SatPrefix" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="Allocate" type="xs:boolean" />
              <xs:element minOccurs="0" name="Unique" type="xs:boolean" />
              <xs:element minOccurs="0" name="ReadOnly" type="xs:boolean" />
              <xs:element minOccurs="0" name="AllowBlank" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="RefCountEntity" nillable="true" type="tns:RefCountEntity" />
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
      <xs:complexType name="ArrayOfMDOListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="MDOListItem" nillable="true" type="tns:MDOListItem" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfMDOListItem" nillable="true" type="tns:ArrayOfMDOListItem" />
      <xs:complexType name="MDOListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ToolTip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ChildItems" nillable="true" type="tns:ArrayOfMDOListItem" />
              <xs:element minOccurs="0" name="IconHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ColorBlock" type="xs:int" />
              <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StyleHint" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="MDOListItem" nillable="true" type="tns:MDOListItem" />
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
      <xs:element name="SaveRefCountEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RefCountEntity" nillable="true" type="tns:RefCountEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveRefCountEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:RefCountEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteRefCountEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RefCountEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteRefCountEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRefCountEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RefCountEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRefCountEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:RefCountEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDefaultNumbering">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RefCountEntity" nillable="true" type="tns:RefCountEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDefaultNumberingResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNumberEachTemplate">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNumberEachTemplateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetNumberEachTemplate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SetValue" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetNumberEachTemplateResponse">
        <xs:complexType>
          <xs:sequence />
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
  </wsdl:types>
  <wsdl:message name="CreateDefaultRefCountEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultRefCountEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRefCountEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRefCountEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultRefCountEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRefCountEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRefCountEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveRefCountEntity" />
  </wsdl:message>
  <wsdl:message name="SaveRefCountEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRefCountEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveRefCountEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveRefCountEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteRefCountEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteRefCountEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteRefCountEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteRefCountEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteRefCountEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteRefCountEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRefCountEntityRequest">
    <wsdl:part name="parameters" element="tns:GetRefCountEntity" />
  </wsdl:message>
  <wsdl:message name="GetRefCountEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRefCountEntityResponse">
    <wsdl:part name="parameters" element="tns:GetRefCountEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetRefCountEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDefaultNumberingRequest">
    <wsdl:part name="parameters" element="tns:SaveDefaultNumbering" />
  </wsdl:message>
  <wsdl:message name="SaveDefaultNumberingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDefaultNumberingResponse">
    <wsdl:part name="parameters" element="tns:SaveDefaultNumberingResponse" />
  </wsdl:message>
  <wsdl:message name="SaveDefaultNumberingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNumberEachTemplateRequest">
    <wsdl:part name="parameters" element="tns:GetNumberEachTemplate" />
  </wsdl:message>
  <wsdl:message name="GetNumberEachTemplateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNumberEachTemplateResponse">
    <wsdl:part name="parameters" element="tns:GetNumberEachTemplateResponse" />
  </wsdl:message>
  <wsdl:message name="GetNumberEachTemplateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetNumberEachTemplateRequest">
    <wsdl:part name="parameters" element="tns:SetNumberEachTemplate" />
  </wsdl:message>
  <wsdl:message name="SetNumberEachTemplateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetNumberEachTemplateResponse">
    <wsdl:part name="parameters" element="tns:SetNumberEachTemplateResponse" />
  </wsdl:message>
  <wsdl:message name="SetNumberEachTemplateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="NumberAllocation">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for NumberAllocation</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultRefCountEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new RefCountEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/CreateDefaultRefCountEntity" name="CreateDefaultRefCountEntityRequest" message="tns:CreateDefaultRefCountEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/CreateDefaultRefCountEntityResponse" name="CreateDefaultRefCountEntityResponse" message="tns:CreateDefaultRefCountEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveRefCountEntity">
      <wsdl:documentation>
        <summary>Updates the existing RefCountEntity or creates a new RefCountEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/SaveRefCountEntity" name="SaveRefCountEntityRequest" message="tns:SaveRefCountEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/SaveRefCountEntityResponse" name="SaveRefCountEntityResponse" message="tns:SaveRefCountEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteRefCountEntity">
      <wsdl:documentation>
        <summary>Deletes the RefCountEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/DeleteRefCountEntity" name="DeleteRefCountEntityRequest" message="tns:DeleteRefCountEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/DeleteRefCountEntityResponse" name="DeleteRefCountEntityResponse" message="tns:DeleteRefCountEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetRefCountEntity">
      <wsdl:documentation>
        <summary>Gets a RefCountEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/GetRefCountEntity" name="GetRefCountEntityRequest" message="tns:GetRefCountEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/GetRefCountEntityResponse" name="GetRefCountEntityResponse" message="tns:GetRefCountEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveDefaultNumbering">
      <wsdl:documentation>
        <summary>Saves default numbering values in preferences</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/SaveDefaultNumbering" name="SaveDefaultNumberingRequest" message="tns:SaveDefaultNumberingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/SaveDefaultNumberingResponse" name="SaveDefaultNumberingResponse" message="tns:SaveDefaultNumberingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNumberEachTemplate">
      <wsdl:documentation>
        <summary>Returns true or false if Automatically create new counters for new document templates</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/GetNumberEachTemplate" name="GetNumberEachTemplateRequest" message="tns:GetNumberEachTemplateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/GetNumberEachTemplateResponse" name="GetNumberEachTemplateResponse" message="tns:GetNumberEachTemplateResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetNumberEachTemplate">
      <wsdl:documentation>
        <summary>Saves true or false if Automatically create new counters for new document templates</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/SetNumberEachTemplate" name="SetNumberEachTemplateRequest" message="tns:SetNumberEachTemplateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/SetNumberEachTemplateResponse" name="SetNumberEachTemplateResponse" message="tns:SetNumberEachTemplateResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_NumberAllocation" type="tns:NumberAllocation">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultRefCountEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/CreateDefaultRefCountEntity" style="document" />
      <wsdl:input name="CreateDefaultRefCountEntityRequest">
        <soap:header message="tns:CreateDefaultRefCountEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultRefCountEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultRefCountEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultRefCountEntityResponse">
        <soap:header message="tns:CreateDefaultRefCountEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultRefCountEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultRefCountEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultRefCountEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveRefCountEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/SaveRefCountEntity" style="document" />
      <wsdl:input name="SaveRefCountEntityRequest">
        <soap:header message="tns:SaveRefCountEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveRefCountEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveRefCountEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveRefCountEntityResponse">
        <soap:header message="tns:SaveRefCountEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveRefCountEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveRefCountEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveRefCountEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteRefCountEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/DeleteRefCountEntity" style="document" />
      <wsdl:input name="DeleteRefCountEntityRequest">
        <soap:header message="tns:DeleteRefCountEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteRefCountEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteRefCountEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteRefCountEntityResponse">
        <soap:header message="tns:DeleteRefCountEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteRefCountEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteRefCountEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteRefCountEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetRefCountEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/GetRefCountEntity" style="document" />
      <wsdl:input name="GetRefCountEntityRequest">
        <soap:header message="tns:GetRefCountEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetRefCountEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetRefCountEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetRefCountEntityResponse">
        <soap:header message="tns:GetRefCountEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetRefCountEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetRefCountEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetRefCountEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveDefaultNumbering">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/SaveDefaultNumbering" style="document" />
      <wsdl:input name="SaveDefaultNumberingRequest">
        <soap:header message="tns:SaveDefaultNumberingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveDefaultNumberingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveDefaultNumberingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveDefaultNumberingResponse">
        <soap:header message="tns:SaveDefaultNumberingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveDefaultNumberingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveDefaultNumberingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveDefaultNumberingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNumberEachTemplate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/GetNumberEachTemplate" style="document" />
      <wsdl:input name="GetNumberEachTemplateRequest">
        <soap:header message="tns:GetNumberEachTemplateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNumberEachTemplateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNumberEachTemplateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNumberEachTemplateResponse">
        <soap:header message="tns:GetNumberEachTemplateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNumberEachTemplateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNumberEachTemplateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNumberEachTemplateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetNumberEachTemplate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/NumberAllocation/SetNumberEachTemplate" style="document" />
      <wsdl:input name="SetNumberEachTemplateRequest">
        <soap:header message="tns:SetNumberEachTemplateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetNumberEachTemplateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetNumberEachTemplateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetNumberEachTemplateResponse">
        <soap:header message="tns:SetNumberEachTemplateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetNumberEachTemplateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetNumberEachTemplateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetNumberEachTemplateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfNumberAllocationService">
    <wsdl:port name="BasicHttpBinding_NumberAllocation" binding="tns:BasicHttpBinding_NumberAllocation">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services80/NumberAllocation.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

