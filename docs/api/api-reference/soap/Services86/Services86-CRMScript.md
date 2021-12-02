---
generated: 1
uid: wsdl-Services86-CRMScript
title: Services86.CRMScriptAgent WSDL
---

# Services86.CRMScriptAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfCRMScriptService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services86" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services86" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services86" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:element name="CreateDefaultCRMScriptEntity">
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
      <xs:element name="CreateDefaultCRMScriptEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CRMScriptEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CRMScriptEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="EjscriptId" type="xs:int" />
              <xs:element minOccurs="0" name="UniqueIdentifier" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IncludeId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="HierarchyId" type="xs:int" />
              <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RegisteredAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedAssociateId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CRMScriptEntity" nillable="true" type="tns:CRMScriptEntity" />
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
      <xs:element name="SaveCRMScriptEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CRMScriptEntity" nillable="true" type="tns:CRMScriptEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCRMScriptEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CRMScriptEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteCRMScriptEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CRMScriptEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteCRMScriptEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCRMScriptEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CRMScriptEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCRMScriptEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CRMScriptEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExecuteScript">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CRMScriptId" type="xs:int" />
            <xs:element minOccurs="0" name="Parameters" nillable="true" type="tns:StringDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="StringDictionary">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="StringKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="xs:string" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="StringDictionary" nillable="true" type="tns:StringDictionary" />
      <xs:element name="ExecuteScriptResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExecuteScriptByIncludeId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CRMScriptIncludeId" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Parameters" nillable="true" type="tns:StringDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExecuteScriptByIncludeIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateScript">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CRMScriptId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateScriptResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CRMScriptResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CRMScriptResult">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Valid" type="xs:boolean" />
              <xs:element minOccurs="0" name="ErrorMessage" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CRMScriptResult" nillable="true" type="tns:CRMScriptResult" />
      <xs:element name="ValidateScriptByIncludeId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CRMScriptIncludeId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateScriptByIncludeIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CRMScriptResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCRMScriptByUniqueIdentifier">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UniqueIdentifier" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCRMScriptByUniqueIdentifierResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Script" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Script">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="UniqueIdentifier" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IncludeId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RegisteredBy" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Path" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Script" nillable="true" type="tns:Script" />
      <xs:element name="SaveCRMScriptByUniqueIdentifier">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UniqueIdentifier" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Crmscript" nillable="true" type="tns:Script" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCRMScriptByUniqueIdentifierResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Script" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteCRMScriptByUniqueIdentifier">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UniqueIdentifier" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteCRMScriptByUniqueIdentifierResponse">
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
  <wsdl:message name="CreateDefaultCRMScriptEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultCRMScriptEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCRMScriptEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCRMScriptEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultCRMScriptEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCRMScriptEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCRMScriptEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveCRMScriptEntity" />
  </wsdl:message>
  <wsdl:message name="SaveCRMScriptEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCRMScriptEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveCRMScriptEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveCRMScriptEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteCRMScriptEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteCRMScriptEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteCRMScriptEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteCRMScriptEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteCRMScriptEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteCRMScriptEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCRMScriptEntityRequest">
    <wsdl:part name="parameters" element="tns:GetCRMScriptEntity" />
  </wsdl:message>
  <wsdl:message name="GetCRMScriptEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCRMScriptEntityResponse">
    <wsdl:part name="parameters" element="tns:GetCRMScriptEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetCRMScriptEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExecuteScriptRequest">
    <wsdl:part name="parameters" element="tns:ExecuteScript" />
  </wsdl:message>
  <wsdl:message name="ExecuteScriptRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExecuteScriptResponse">
    <wsdl:part name="parameters" element="tns:ExecuteScriptResponse" />
  </wsdl:message>
  <wsdl:message name="ExecuteScriptResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExecuteScriptByIncludeIdRequest">
    <wsdl:part name="parameters" element="tns:ExecuteScriptByIncludeId" />
  </wsdl:message>
  <wsdl:message name="ExecuteScriptByIncludeIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExecuteScriptByIncludeIdResponse">
    <wsdl:part name="parameters" element="tns:ExecuteScriptByIncludeIdResponse" />
  </wsdl:message>
  <wsdl:message name="ExecuteScriptByIncludeIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateScriptRequest">
    <wsdl:part name="parameters" element="tns:ValidateScript" />
  </wsdl:message>
  <wsdl:message name="ValidateScriptRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateScriptResponse">
    <wsdl:part name="parameters" element="tns:ValidateScriptResponse" />
  </wsdl:message>
  <wsdl:message name="ValidateScriptResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateScriptByIncludeIdRequest">
    <wsdl:part name="parameters" element="tns:ValidateScriptByIncludeId" />
  </wsdl:message>
  <wsdl:message name="ValidateScriptByIncludeIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateScriptByIncludeIdResponse">
    <wsdl:part name="parameters" element="tns:ValidateScriptByIncludeIdResponse" />
  </wsdl:message>
  <wsdl:message name="ValidateScriptByIncludeIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCRMScriptByUniqueIdentifierRequest">
    <wsdl:part name="parameters" element="tns:GetCRMScriptByUniqueIdentifier" />
  </wsdl:message>
  <wsdl:message name="GetCRMScriptByUniqueIdentifierRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCRMScriptByUniqueIdentifierResponse">
    <wsdl:part name="parameters" element="tns:GetCRMScriptByUniqueIdentifierResponse" />
  </wsdl:message>
  <wsdl:message name="GetCRMScriptByUniqueIdentifierResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCRMScriptByUniqueIdentifierRequest">
    <wsdl:part name="parameters" element="tns:SaveCRMScriptByUniqueIdentifier" />
  </wsdl:message>
  <wsdl:message name="SaveCRMScriptByUniqueIdentifierRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCRMScriptByUniqueIdentifierResponse">
    <wsdl:part name="parameters" element="tns:SaveCRMScriptByUniqueIdentifierResponse" />
  </wsdl:message>
  <wsdl:message name="SaveCRMScriptByUniqueIdentifierResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteCRMScriptByUniqueIdentifierRequest">
    <wsdl:part name="parameters" element="tns:DeleteCRMScriptByUniqueIdentifier" />
  </wsdl:message>
  <wsdl:message name="DeleteCRMScriptByUniqueIdentifierRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteCRMScriptByUniqueIdentifierResponse">
    <wsdl:part name="parameters" element="tns:DeleteCRMScriptByUniqueIdentifierResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteCRMScriptByUniqueIdentifierResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="CRMScript">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for CRMScript</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultCRMScriptEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new CRMScriptEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/CreateDefaultCRMScriptEntity" name="CreateDefaultCRMScriptEntityRequest" message="tns:CreateDefaultCRMScriptEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/CreateDefaultCRMScriptEntityResponse" name="CreateDefaultCRMScriptEntityResponse" message="tns:CreateDefaultCRMScriptEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveCRMScriptEntity">
      <wsdl:documentation>
        <summary>Updates the existing CRMScriptEntity or creates a new CRMScriptEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/SaveCRMScriptEntity" name="SaveCRMScriptEntityRequest" message="tns:SaveCRMScriptEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/SaveCRMScriptEntityResponse" name="SaveCRMScriptEntityResponse" message="tns:SaveCRMScriptEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteCRMScriptEntity">
      <wsdl:documentation>
        <summary>Deletes the CRMScriptEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/DeleteCRMScriptEntity" name="DeleteCRMScriptEntityRequest" message="tns:DeleteCRMScriptEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/DeleteCRMScriptEntityResponse" name="DeleteCRMScriptEntityResponse" message="tns:DeleteCRMScriptEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCRMScriptEntity">
      <wsdl:documentation>
        <summary>Gets a CRMScriptEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/GetCRMScriptEntity" name="GetCRMScriptEntityRequest" message="tns:GetCRMScriptEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/GetCRMScriptEntityResponse" name="GetCRMScriptEntityResponse" message="tns:GetCRMScriptEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="ExecuteScript">
      <wsdl:documentation>
        <summary>Execute a CRMScript with parameters</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/ExecuteScript" name="ExecuteScriptRequest" message="tns:ExecuteScriptRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/ExecuteScriptResponse" name="ExecuteScriptResponse" message="tns:ExecuteScriptResponse" />
    </wsdl:operation>
    <wsdl:operation name="ExecuteScriptByIncludeId">
      <wsdl:documentation>
        <summary>Execute a CRMScript with parameters</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/ExecuteScriptByIncludeId" name="ExecuteScriptByIncludeIdRequest" message="tns:ExecuteScriptByIncludeIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/ExecuteScriptByIncludeIdResponse" name="ExecuteScriptByIncludeIdResponse" message="tns:ExecuteScriptByIncludeIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="ValidateScript">
      <wsdl:documentation>
        <summary>Validate a CRMScript. This will check that the syntax is correct</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/ValidateScript" name="ValidateScriptRequest" message="tns:ValidateScriptRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/ValidateScriptResponse" name="ValidateScriptResponse" message="tns:ValidateScriptResponse" />
    </wsdl:operation>
    <wsdl:operation name="ValidateScriptByIncludeId">
      <wsdl:documentation>
        <summary>Validate a CRMScript. This will check that the syntax is correct</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/ValidateScriptByIncludeId" name="ValidateScriptByIncludeIdRequest" message="tns:ValidateScriptByIncludeIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/ValidateScriptByIncludeIdResponse" name="ValidateScriptByIncludeIdResponse" message="tns:ValidateScriptByIncludeIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCRMScriptByUniqueIdentifier">
      <wsdl:documentation>
        <summary>Get information about a script from a unique identifier</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/GetCRMScriptByUniqueIdentifier" name="GetCRMScriptByUniqueIdentifierRequest" message="tns:GetCRMScriptByUniqueIdentifierRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/GetCRMScriptByUniqueIdentifierResponse" name="GetCRMScriptByUniqueIdentifierResponse" message="tns:GetCRMScriptByUniqueIdentifierResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveCRMScriptByUniqueIdentifier">
      <wsdl:documentation>
        <summary>Create or Update the CRMScript information</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/SaveCRMScriptByUniqueIdentifier" name="SaveCRMScriptByUniqueIdentifierRequest" message="tns:SaveCRMScriptByUniqueIdentifierRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/SaveCRMScriptByUniqueIdentifierResponse" name="SaveCRMScriptByUniqueIdentifierResponse" message="tns:SaveCRMScriptByUniqueIdentifierResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteCRMScriptByUniqueIdentifier">
      <wsdl:documentation>
        <summary>Delete the CRMScript</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/DeleteCRMScriptByUniqueIdentifier" name="DeleteCRMScriptByUniqueIdentifierRequest" message="tns:DeleteCRMScriptByUniqueIdentifierRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/DeleteCRMScriptByUniqueIdentifierResponse" name="DeleteCRMScriptByUniqueIdentifierResponse" message="tns:DeleteCRMScriptByUniqueIdentifierResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_CRMScript" type="tns:CRMScript">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultCRMScriptEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/CreateDefaultCRMScriptEntity" style="document" />
      <wsdl:input name="CreateDefaultCRMScriptEntityRequest">
        <soap:header message="tns:CreateDefaultCRMScriptEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultCRMScriptEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultCRMScriptEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultCRMScriptEntityResponse">
        <soap:header message="tns:CreateDefaultCRMScriptEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultCRMScriptEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultCRMScriptEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultCRMScriptEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveCRMScriptEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/SaveCRMScriptEntity" style="document" />
      <wsdl:input name="SaveCRMScriptEntityRequest">
        <soap:header message="tns:SaveCRMScriptEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveCRMScriptEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveCRMScriptEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveCRMScriptEntityResponse">
        <soap:header message="tns:SaveCRMScriptEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveCRMScriptEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveCRMScriptEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveCRMScriptEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteCRMScriptEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/DeleteCRMScriptEntity" style="document" />
      <wsdl:input name="DeleteCRMScriptEntityRequest">
        <soap:header message="tns:DeleteCRMScriptEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteCRMScriptEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteCRMScriptEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteCRMScriptEntityResponse">
        <soap:header message="tns:DeleteCRMScriptEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteCRMScriptEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteCRMScriptEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteCRMScriptEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCRMScriptEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/GetCRMScriptEntity" style="document" />
      <wsdl:input name="GetCRMScriptEntityRequest">
        <soap:header message="tns:GetCRMScriptEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCRMScriptEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCRMScriptEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCRMScriptEntityResponse">
        <soap:header message="tns:GetCRMScriptEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCRMScriptEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCRMScriptEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCRMScriptEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ExecuteScript">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/ExecuteScript" style="document" />
      <wsdl:input name="ExecuteScriptRequest">
        <soap:header message="tns:ExecuteScriptRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ExecuteScriptRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ExecuteScriptRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ExecuteScriptResponse">
        <soap:header message="tns:ExecuteScriptResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ExecuteScriptResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ExecuteScriptResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ExecuteScriptResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ExecuteScriptByIncludeId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/ExecuteScriptByIncludeId" style="document" />
      <wsdl:input name="ExecuteScriptByIncludeIdRequest">
        <soap:header message="tns:ExecuteScriptByIncludeIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ExecuteScriptByIncludeIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ExecuteScriptByIncludeIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ExecuteScriptByIncludeIdResponse">
        <soap:header message="tns:ExecuteScriptByIncludeIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ExecuteScriptByIncludeIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ExecuteScriptByIncludeIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ExecuteScriptByIncludeIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ValidateScript">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/ValidateScript" style="document" />
      <wsdl:input name="ValidateScriptRequest">
        <soap:header message="tns:ValidateScriptRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ValidateScriptRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ValidateScriptRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ValidateScriptResponse">
        <soap:header message="tns:ValidateScriptResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ValidateScriptResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ValidateScriptResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ValidateScriptResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ValidateScriptByIncludeId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/ValidateScriptByIncludeId" style="document" />
      <wsdl:input name="ValidateScriptByIncludeIdRequest">
        <soap:header message="tns:ValidateScriptByIncludeIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ValidateScriptByIncludeIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ValidateScriptByIncludeIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ValidateScriptByIncludeIdResponse">
        <soap:header message="tns:ValidateScriptByIncludeIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ValidateScriptByIncludeIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ValidateScriptByIncludeIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ValidateScriptByIncludeIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCRMScriptByUniqueIdentifier">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/GetCRMScriptByUniqueIdentifier" style="document" />
      <wsdl:input name="GetCRMScriptByUniqueIdentifierRequest">
        <soap:header message="tns:GetCRMScriptByUniqueIdentifierRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCRMScriptByUniqueIdentifierRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCRMScriptByUniqueIdentifierRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCRMScriptByUniqueIdentifierResponse">
        <soap:header message="tns:GetCRMScriptByUniqueIdentifierResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCRMScriptByUniqueIdentifierResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCRMScriptByUniqueIdentifierResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCRMScriptByUniqueIdentifierResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveCRMScriptByUniqueIdentifier">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/SaveCRMScriptByUniqueIdentifier" style="document" />
      <wsdl:input name="SaveCRMScriptByUniqueIdentifierRequest">
        <soap:header message="tns:SaveCRMScriptByUniqueIdentifierRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveCRMScriptByUniqueIdentifierRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveCRMScriptByUniqueIdentifierRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveCRMScriptByUniqueIdentifierResponse">
        <soap:header message="tns:SaveCRMScriptByUniqueIdentifierResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveCRMScriptByUniqueIdentifierResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveCRMScriptByUniqueIdentifierResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveCRMScriptByUniqueIdentifierResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteCRMScriptByUniqueIdentifier">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/CRMScript/DeleteCRMScriptByUniqueIdentifier" style="document" />
      <wsdl:input name="DeleteCRMScriptByUniqueIdentifierRequest">
        <soap:header message="tns:DeleteCRMScriptByUniqueIdentifierRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteCRMScriptByUniqueIdentifierRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteCRMScriptByUniqueIdentifierRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteCRMScriptByUniqueIdentifierResponse">
        <soap:header message="tns:DeleteCRMScriptByUniqueIdentifierResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteCRMScriptByUniqueIdentifierResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteCRMScriptByUniqueIdentifierResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteCRMScriptByUniqueIdentifierResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfCRMScriptService">
    <wsdl:port name="BasicHttpBinding_CRMScript" binding="tns:BasicHttpBinding_CRMScript">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services86/CRMScript.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

