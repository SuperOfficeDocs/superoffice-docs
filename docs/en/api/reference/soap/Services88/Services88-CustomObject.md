---
generated: true
uid: wsdl-Services88-CustomObject
title: Services88.CustomObjectAgent WSDL
content_type: reference
---

# Services88.CustomObjectAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfCustomObjectService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:element name="CreateDefaultCustomObjectDefinition">
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
      <xs:element name="CreateDefaultCustomObjectDefinitionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CustomObjectDefinition" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CustomObjectDefinition">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayField" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IconId" type="xs:int" />
              <xs:element minOccurs="0" name="Flags" type="xs:int" />
              <xs:element minOccurs="0" name="Fields" nillable="true" type="tns:ArrayOfCustomObjectField" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CustomObjectDefinition" nillable="true" type="tns:CustomObjectDefinition" />
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
              <xs:enumeration value="R">
                <xs:annotation>
                  <xs:appinfo>
                    <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1</EnumerationValue>
                  </xs:appinfo>
                </xs:annotation>
              </xs:enumeration>
              <xs:enumeration value="F">
                <xs:annotation>
                  <xs:appinfo>
                    <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">16</EnumerationValue>
                  </xs:appinfo>
                </xs:annotation>
              </xs:enumeration>
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
              <xs:enumeration value="Nullable">
                <xs:annotation>
                  <xs:appinfo>
                    <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">32</EnumerationValue>
                  </xs:appinfo>
                </xs:annotation>
              </xs:enumeration>
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="EFieldRight" nillable="true" type="tns:EFieldRight" />
      <xs:complexType name="ArrayOfCustomObjectField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="CustomObjectField" nillable="true" type="tns:CustomObjectField" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCustomObjectField" nillable="true" type="tns:ArrayOfCustomObjectField" />
      <xs:complexType name="CustomObjectField">
        <xs:sequence>
          <xs:element minOccurs="0" name="FieldName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FieldType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="UseDefaultValue" type="xs:boolean" />
          <xs:element minOccurs="0" name="DefaultValue" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Rank" type="xs:int" />
          <xs:element minOccurs="0" name="IsDefault" type="xs:boolean" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="CustomObjectField" nillable="true" type="tns:CustomObjectField" />
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
      <xs:element name="CreateDefaultCustomObject">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DefinitionName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultCustomObjectResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CustomObject" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CustomObject">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="DefinitionName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Values" nillable="true" type="tns:StringDictionary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CustomObject" nillable="true" type="tns:CustomObject" />
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
      <xs:element name="GetCustomObject">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DefinitionName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Id" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCustomObjectResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CustomObject" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCustomObject">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DefinitionName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Row" nillable="true" type="tns:CustomObject" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCustomObjectResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CustomObject" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteCustomObject">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DefinitionName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Id" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteCustomObjectResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCustomObjectDefinition">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DefinitionName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCustomObjectDefinitionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CustomObjectDefinition" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="HasScreenChooser">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DefinitionName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Edit" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="HasScreenChooserResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCustomObjectsMetadata">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCustomObjectsMetadataResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCustomObjectMetadata" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfCustomObjectMetadata">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="CustomObjectMetadata" nillable="true" type="tns:CustomObjectMetadata" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCustomObjectMetadata" nillable="true" type="tns:ArrayOfCustomObjectMetadata" />
      <xs:complexType name="CustomObjectMetadata">
        <xs:sequence>
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="IconHint" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FlagHideId" type="xs:boolean" />
          <xs:element minOccurs="0" name="FlagHidden" type="xs:boolean" />
          <xs:element minOccurs="0" name="FlagShowInFind" type="xs:boolean" />
          <xs:element minOccurs="0" name="FlagShowInNavigator" type="xs:boolean" />
          <xs:element minOccurs="0" name="Relations" nillable="true" type="tns:ArrayOfCustomObjectRelation" />
          <xs:element minOccurs="0" name="HasWebPanels" type="xs:boolean" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="CustomObjectMetadata" nillable="true" type="tns:CustomObjectMetadata" />
      <xs:complexType name="ArrayOfCustomObjectRelation">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="CustomObjectRelation" nillable="true" type="tns:CustomObjectRelation" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCustomObjectRelation" nillable="true" type="tns:ArrayOfCustomObjectRelation" />
      <xs:complexType name="CustomObjectRelation">
        <xs:sequence>
          <xs:element minOccurs="0" name="EntityName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="EntityType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="EntityTitle" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="RelationField" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DisplayField" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="HideFunctions" type="xs:boolean" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="CustomObjectRelation" nillable="true" type="tns:CustomObjectRelation" />
      <xs:element name="GetCustomObjectsIcons">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCustomObjectsIconsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:StringDictionary" />
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
  </wsdl:types>
  <wsdl:message name="CreateDefaultCustomObjectDefinitionRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultCustomObjectDefinition" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCustomObjectDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCustomObjectDefinitionResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultCustomObjectDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCustomObjectDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCustomObjectRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultCustomObject" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCustomObjectRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCustomObjectResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultCustomObjectResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCustomObjectResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomObjectRequest">
    <wsdl:part name="parameters" element="tns:GetCustomObject" />
  </wsdl:message>
  <wsdl:message name="GetCustomObjectRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomObjectResponse">
    <wsdl:part name="parameters" element="tns:GetCustomObjectResponse" />
  </wsdl:message>
  <wsdl:message name="GetCustomObjectResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCustomObjectRequest">
    <wsdl:part name="parameters" element="tns:SaveCustomObject" />
  </wsdl:message>
  <wsdl:message name="SaveCustomObjectRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCustomObjectResponse">
    <wsdl:part name="parameters" element="tns:SaveCustomObjectResponse" />
  </wsdl:message>
  <wsdl:message name="SaveCustomObjectResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteCustomObjectRequest">
    <wsdl:part name="parameters" element="tns:DeleteCustomObject" />
  </wsdl:message>
  <wsdl:message name="DeleteCustomObjectRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteCustomObjectResponse">
    <wsdl:part name="parameters" element="tns:DeleteCustomObjectResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteCustomObjectResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomObjectDefinitionRequest">
    <wsdl:part name="parameters" element="tns:GetCustomObjectDefinition" />
  </wsdl:message>
  <wsdl:message name="GetCustomObjectDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomObjectDefinitionResponse">
    <wsdl:part name="parameters" element="tns:GetCustomObjectDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="GetCustomObjectDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasScreenChooserRequest">
    <wsdl:part name="parameters" element="tns:HasScreenChooser" />
  </wsdl:message>
  <wsdl:message name="HasScreenChooserRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasScreenChooserResponse">
    <wsdl:part name="parameters" element="tns:HasScreenChooserResponse" />
  </wsdl:message>
  <wsdl:message name="HasScreenChooserResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomObjectsMetadataRequest">
    <wsdl:part name="parameters" element="tns:GetCustomObjectsMetadata" />
  </wsdl:message>
  <wsdl:message name="GetCustomObjectsMetadataRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomObjectsMetadataResponse">
    <wsdl:part name="parameters" element="tns:GetCustomObjectsMetadataResponse" />
  </wsdl:message>
  <wsdl:message name="GetCustomObjectsMetadataResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomObjectsIconsRequest">
    <wsdl:part name="parameters" element="tns:GetCustomObjectsIcons" />
  </wsdl:message>
  <wsdl:message name="GetCustomObjectsIconsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomObjectsIconsResponse">
    <wsdl:part name="parameters" element="tns:GetCustomObjectsIconsResponse" />
  </wsdl:message>
  <wsdl:message name="GetCustomObjectsIconsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="CustomObject">
    <wsdl:operation name="CreateDefaultCustomObjectDefinition">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/CreateDefaultCustomObjectDefinition" name="CreateDefaultCustomObjectDefinitionRequest" message="tns:CreateDefaultCustomObjectDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/CreateDefaultCustomObjectDefinitionResponse" name="CreateDefaultCustomObjectDefinitionResponse" message="tns:CreateDefaultCustomObjectDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultCustomObject">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/CreateDefaultCustomObject" name="CreateDefaultCustomObjectRequest" message="tns:CreateDefaultCustomObjectRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/CreateDefaultCustomObjectResponse" name="CreateDefaultCustomObjectResponse" message="tns:CreateDefaultCustomObjectResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCustomObject">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/GetCustomObject" name="GetCustomObjectRequest" message="tns:GetCustomObjectRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/GetCustomObjectResponse" name="GetCustomObjectResponse" message="tns:GetCustomObjectResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveCustomObject">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/SaveCustomObject" name="SaveCustomObjectRequest" message="tns:SaveCustomObjectRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/SaveCustomObjectResponse" name="SaveCustomObjectResponse" message="tns:SaveCustomObjectResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteCustomObject">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/DeleteCustomObject" name="DeleteCustomObjectRequest" message="tns:DeleteCustomObjectRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/DeleteCustomObjectResponse" name="DeleteCustomObjectResponse" message="tns:DeleteCustomObjectResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCustomObjectDefinition">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/GetCustomObjectDefinition" name="GetCustomObjectDefinitionRequest" message="tns:GetCustomObjectDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/GetCustomObjectDefinitionResponse" name="GetCustomObjectDefinitionResponse" message="tns:GetCustomObjectDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="HasScreenChooser">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/HasScreenChooser" name="HasScreenChooserRequest" message="tns:HasScreenChooserRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/HasScreenChooserResponse" name="HasScreenChooserResponse" message="tns:HasScreenChooserResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCustomObjectsMetadata">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/GetCustomObjectsMetadata" name="GetCustomObjectsMetadataRequest" message="tns:GetCustomObjectsMetadataRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/GetCustomObjectsMetadataResponse" name="GetCustomObjectsMetadataResponse" message="tns:GetCustomObjectsMetadataResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCustomObjectsIcons">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/GetCustomObjectsIcons" name="GetCustomObjectsIconsRequest" message="tns:GetCustomObjectsIconsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/GetCustomObjectsIconsResponse" name="GetCustomObjectsIconsResponse" message="tns:GetCustomObjectsIconsResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_CustomObject" type="tns:CustomObject">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultCustomObjectDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/CreateDefaultCustomObjectDefinition" style="document" />
      <wsdl:input name="CreateDefaultCustomObjectDefinitionRequest">
        <soap:header message="tns:CreateDefaultCustomObjectDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultCustomObjectDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultCustomObjectDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultCustomObjectDefinitionResponse">
        <soap:header message="tns:CreateDefaultCustomObjectDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultCustomObjectDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultCustomObjectDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultCustomObjectDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultCustomObject">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/CreateDefaultCustomObject" style="document" />
      <wsdl:input name="CreateDefaultCustomObjectRequest">
        <soap:header message="tns:CreateDefaultCustomObjectRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultCustomObjectRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultCustomObjectRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultCustomObjectResponse">
        <soap:header message="tns:CreateDefaultCustomObjectResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultCustomObjectResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultCustomObjectResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultCustomObjectResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCustomObject">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/GetCustomObject" style="document" />
      <wsdl:input name="GetCustomObjectRequest">
        <soap:header message="tns:GetCustomObjectRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCustomObjectRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCustomObjectRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCustomObjectResponse">
        <soap:header message="tns:GetCustomObjectResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCustomObjectResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCustomObjectResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCustomObjectResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveCustomObject">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/SaveCustomObject" style="document" />
      <wsdl:input name="SaveCustomObjectRequest">
        <soap:header message="tns:SaveCustomObjectRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveCustomObjectRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveCustomObjectRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveCustomObjectResponse">
        <soap:header message="tns:SaveCustomObjectResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveCustomObjectResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveCustomObjectResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveCustomObjectResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteCustomObject">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/DeleteCustomObject" style="document" />
      <wsdl:input name="DeleteCustomObjectRequest">
        <soap:header message="tns:DeleteCustomObjectRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteCustomObjectRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteCustomObjectRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteCustomObjectResponse">
        <soap:header message="tns:DeleteCustomObjectResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteCustomObjectResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteCustomObjectResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteCustomObjectResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCustomObjectDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/GetCustomObjectDefinition" style="document" />
      <wsdl:input name="GetCustomObjectDefinitionRequest">
        <soap:header message="tns:GetCustomObjectDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCustomObjectDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCustomObjectDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCustomObjectDefinitionResponse">
        <soap:header message="tns:GetCustomObjectDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCustomObjectDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCustomObjectDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCustomObjectDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="HasScreenChooser">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/HasScreenChooser" style="document" />
      <wsdl:input name="HasScreenChooserRequest">
        <soap:header message="tns:HasScreenChooserRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:HasScreenChooserRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:HasScreenChooserRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="HasScreenChooserResponse">
        <soap:header message="tns:HasScreenChooserResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:HasScreenChooserResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:HasScreenChooserResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:HasScreenChooserResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCustomObjectsMetadata">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/GetCustomObjectsMetadata" style="document" />
      <wsdl:input name="GetCustomObjectsMetadataRequest">
        <soap:header message="tns:GetCustomObjectsMetadataRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCustomObjectsMetadataRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCustomObjectsMetadataRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCustomObjectsMetadataResponse">
        <soap:header message="tns:GetCustomObjectsMetadataResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCustomObjectsMetadataResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCustomObjectsMetadataResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCustomObjectsMetadataResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCustomObjectsIcons">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomObject/GetCustomObjectsIcons" style="document" />
      <wsdl:input name="GetCustomObjectsIconsRequest">
        <soap:header message="tns:GetCustomObjectsIconsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCustomObjectsIconsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCustomObjectsIconsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCustomObjectsIconsResponse">
        <soap:header message="tns:GetCustomObjectsIconsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCustomObjectsIconsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCustomObjectsIconsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCustomObjectsIconsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfCustomObjectService">
    <wsdl:port name="BasicHttpBinding_CustomObject" binding="tns:BasicHttpBinding_CustomObject">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/CustomObject.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

