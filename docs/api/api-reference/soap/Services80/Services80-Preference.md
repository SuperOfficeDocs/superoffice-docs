---
Generated: 1
TOCExclude: 1
title: Services80.PreferenceAgent WSDL
---

# Services80.PreferenceAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfPreferenceService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services80" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services80" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services80" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultPreference">
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
      <xs:element name="CreateDefaultPreferenceResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Preference" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Preference">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Level" type="tns:PreferenceLevel" />
              <xs:element minOccurs="0" name="RawValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Specification" nillable="true" type="tns:PreferenceSpec" />
              <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayTooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayType" type="tns:PrefDescValueType" />
              <xs:element minOccurs="0" name="TabOrder" nillable="true" type="tns:TabOrder" />
              <xs:element minOccurs="0" name="TargetId" type="xs:int" />
              <xs:element minOccurs="0" name="PrefDescId" type="xs:int" />
              <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserPreferenceId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Preference" nillable="true" type="tns:Preference" />
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
      <xs:simpleType name="PreferenceLevel">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Undefined" />
          <xs:enumeration value="HardDefault" />
          <xs:enumeration value="SystemWide" />
          <xs:enumeration value="Database" />
          <xs:enumeration value="Group" />
          <xs:enumeration value="Individual" />
          <xs:enumeration value="PC" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="PreferenceLevel" nillable="true" type="tns:PreferenceLevel" />
      <xs:complexType name="PreferenceSpec">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Section" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Key" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PreferenceSpec" nillable="true" type="tns:PreferenceSpec" />
      <xs:simpleType name="PrefDescValueType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Number" />
          <xs:enumeration value="Text" />
          <xs:enumeration value="Bool" />
          <xs:enumeration value="ListOfValues" />
          <xs:enumeration value="ListTableRef" />
          <xs:enumeration value="TimeList" />
          <xs:enumeration value="ContactID" />
          <xs:enumeration value="PersonID" />
          <xs:enumeration value="ProjectID" />
          <xs:enumeration value="SelectionID" />
          <xs:enumeration value="PosSize" />
          <xs:enumeration value="TimeZone" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="PrefDescValueType" nillable="true" type="tns:PrefDescValueType" />
      <xs:complexType name="TabOrder">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="TabOrderId" type="xs:int" />
              <xs:element minOccurs="0" name="TabName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Order" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TabOrder" nillable="true" type="tns:TabOrder" />
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
      <xs:element name="CreateDefaultPreferenceDescription">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultPreferenceDescriptionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PreferenceDescription" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="PreferenceDescription">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="PrefDescId" type="xs:int" />
              <xs:element minOccurs="0" name="Section" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Key" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ValueType" type="tns:PrefDescValueType" />
              <xs:element minOccurs="0" name="MaxLevel" type="tns:PreferenceLevel" />
              <xs:element minOccurs="0" name="SysMaxLevel" type="tns:PreferenceLevel" />
              <xs:element minOccurs="0" name="AccessFlags" type="tns:PrefDescAccessFlags" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsBuiltin" type="xs:boolean" />
              <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PreferenceDescription" nillable="true" type="tns:PreferenceDescription" />
      <xs:simpleType name="PrefDescAccessFlags">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="WizardMode" />
              <xs:enumeration value="Level0" />
              <xs:enumeration value="adminGUI" />
              <xs:enumeration value="CRMGUI" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="PrefDescAccessFlags" nillable="true" type="tns:PrefDescAccessFlags" />
      <xs:element name="SavePreferenceDescription">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PreferenceDescription" nillable="true" type="tns:PreferenceDescription" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SavePreferenceDescriptionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PreferenceDescription" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultPreferenceDescriptionLine">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultPreferenceDescriptionLineResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PreferenceDescriptionLine" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="PreferenceDescriptionLine">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="PrefDescLineId" type="xs:int" />
              <xs:element minOccurs="0" name="PrefDescId" type="xs:int" />
              <xs:element minOccurs="0" name="PrefValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PrefShowValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsBuiltin" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PreferenceDescriptionLine" nillable="true" type="tns:PreferenceDescriptionLine" />
      <xs:element name="SavePreference">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Preference" nillable="true" type="tns:Preference" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SavePreferenceResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTabOrder">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TabOrder" nillable="true" type="tns:TabOrder" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTabOrderResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTabOrder">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TabName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTabOrderResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TabOrder" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreference">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreferenceResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Preference" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SavePreferenceEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Preference" nillable="true" type="tns:Preference" />
            <xs:element minOccurs="0" name="RemoveLowerLevels" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SavePreferenceEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Preference" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeletePreference">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeletePreferenceResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeletePreferences">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Ids" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeletePreferencesResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreferenceByName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PrefSection" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PrefKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PrefLevel" type="tns:PreferenceLevel" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreferenceByNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Preference" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNetServicesStatusUrl">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNetServicesStatusUrlResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateNetServicesStatus">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="XmlOrJson" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateNetServicesStatusResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreferenceDescription">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PreferenceDescriptionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreferenceDescriptionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PreferenceDescription" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreferenceDescriptionLine">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PreferenceDescriptionLineId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreferenceDescriptionLineResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PreferenceDescriptionLine" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreferenceDescriptionLineFromIdAndValue">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PrefDescId" type="xs:int" />
            <xs:element minOccurs="0" name="PrefValue" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreferenceDescriptionLineFromIdAndValueResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PreferenceDescriptionLine" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreferences">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Specifications" nillable="true" type="tns:ArrayOfPreferenceSpec" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfPreferenceSpec">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="PreferenceSpec" nillable="true" type="tns:PreferenceSpec" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfPreferenceSpec" nillable="true" type="tns:ArrayOfPreferenceSpec" />
      <xs:element name="GetPreferencesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPreference" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfPreference">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Preference" nillable="true" type="tns:Preference" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfPreference" nillable="true" type="tns:ArrayOfPreference" />
      <xs:element name="SavePreferences">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Preferences" nillable="true" type="tns:ArrayOfPreference" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SavePreferencesResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreferencesWithDisplayValues">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Specifications" nillable="true" type="tns:ArrayOfPreferenceSpec" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreferencesWithDisplayValuesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPreference" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTabOrders">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTabOrdersResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTabOrder" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfTabOrder">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TabOrder" nillable="true" type="tns:TabOrder" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTabOrder" nillable="true" type="tns:ArrayOfTabOrder" />
      <xs:element name="SaveTabOrders">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TabOrders" nillable="true" type="tns:ArrayOfTabOrder" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTabOrdersResponse">
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
    <xs:schema elementFormDefault="qualified" targetNamespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:tns="http://schemas.microsoft.com/2003/10/Serialization/Arrays">
      <xs:complexType name="ArrayOfint">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="int" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfint" nillable="true" type="tns:ArrayOfint" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="CreateDefaultPreferenceRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultPreference" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultPreferenceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultPreferenceResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultPreferenceResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultPreferenceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultPreferenceDescriptionRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultPreferenceDescription" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultPreferenceDescriptionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultPreferenceDescriptionResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultPreferenceDescriptionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultPreferenceDescriptionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SavePreferenceDescriptionRequest">
    <wsdl:part name="parameters" element="tns:SavePreferenceDescription" />
  </wsdl:message>
  <wsdl:message name="SavePreferenceDescriptionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SavePreferenceDescriptionResponse">
    <wsdl:part name="parameters" element="tns:SavePreferenceDescriptionResponse" />
  </wsdl:message>
  <wsdl:message name="SavePreferenceDescriptionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultPreferenceDescriptionLineRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultPreferenceDescriptionLine" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultPreferenceDescriptionLineRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultPreferenceDescriptionLineResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultPreferenceDescriptionLineResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultPreferenceDescriptionLineResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SavePreferenceRequest">
    <wsdl:part name="parameters" element="tns:SavePreference" />
  </wsdl:message>
  <wsdl:message name="SavePreferenceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SavePreferenceResponse">
    <wsdl:part name="parameters" element="tns:SavePreferenceResponse" />
  </wsdl:message>
  <wsdl:message name="SavePreferenceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTabOrderRequest">
    <wsdl:part name="parameters" element="tns:SaveTabOrder" />
  </wsdl:message>
  <wsdl:message name="SaveTabOrderRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTabOrderResponse">
    <wsdl:part name="parameters" element="tns:SaveTabOrderResponse" />
  </wsdl:message>
  <wsdl:message name="SaveTabOrderResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTabOrderRequest">
    <wsdl:part name="parameters" element="tns:GetTabOrder" />
  </wsdl:message>
  <wsdl:message name="GetTabOrderRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTabOrderResponse">
    <wsdl:part name="parameters" element="tns:GetTabOrderResponse" />
  </wsdl:message>
  <wsdl:message name="GetTabOrderResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceRequest">
    <wsdl:part name="parameters" element="tns:GetPreference" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceResponse">
    <wsdl:part name="parameters" element="tns:GetPreferenceResponse" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SavePreferenceEntityRequest">
    <wsdl:part name="parameters" element="tns:SavePreferenceEntity" />
  </wsdl:message>
  <wsdl:message name="SavePreferenceEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SavePreferenceEntityResponse">
    <wsdl:part name="parameters" element="tns:SavePreferenceEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SavePreferenceEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeletePreferenceRequest">
    <wsdl:part name="parameters" element="tns:DeletePreference" />
  </wsdl:message>
  <wsdl:message name="DeletePreferenceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeletePreferenceResponse">
    <wsdl:part name="parameters" element="tns:DeletePreferenceResponse" />
  </wsdl:message>
  <wsdl:message name="DeletePreferenceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeletePreferencesRequest">
    <wsdl:part name="parameters" element="tns:DeletePreferences" />
  </wsdl:message>
  <wsdl:message name="DeletePreferencesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeletePreferencesResponse">
    <wsdl:part name="parameters" element="tns:DeletePreferencesResponse" />
  </wsdl:message>
  <wsdl:message name="DeletePreferencesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceByNameRequest">
    <wsdl:part name="parameters" element="tns:GetPreferenceByName" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceByNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceByNameResponse">
    <wsdl:part name="parameters" element="tns:GetPreferenceByNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceByNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNetServicesStatusUrlRequest">
    <wsdl:part name="parameters" element="tns:GetNetServicesStatusUrl" />
  </wsdl:message>
  <wsdl:message name="GetNetServicesStatusUrlRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNetServicesStatusUrlResponse">
    <wsdl:part name="parameters" element="tns:GetNetServicesStatusUrlResponse" />
  </wsdl:message>
  <wsdl:message name="GetNetServicesStatusUrlResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateNetServicesStatusRequest">
    <wsdl:part name="parameters" element="tns:UpdateNetServicesStatus" />
  </wsdl:message>
  <wsdl:message name="UpdateNetServicesStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateNetServicesStatusResponse">
    <wsdl:part name="parameters" element="tns:UpdateNetServicesStatusResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateNetServicesStatusResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceDescriptionRequest">
    <wsdl:part name="parameters" element="tns:GetPreferenceDescription" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceDescriptionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceDescriptionResponse">
    <wsdl:part name="parameters" element="tns:GetPreferenceDescriptionResponse" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceDescriptionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceDescriptionLineRequest">
    <wsdl:part name="parameters" element="tns:GetPreferenceDescriptionLine" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceDescriptionLineRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceDescriptionLineResponse">
    <wsdl:part name="parameters" element="tns:GetPreferenceDescriptionLineResponse" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceDescriptionLineResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceDescriptionLineFromIdAndValueRequest">
    <wsdl:part name="parameters" element="tns:GetPreferenceDescriptionLineFromIdAndValue" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceDescriptionLineFromIdAndValueRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceDescriptionLineFromIdAndValueResponse">
    <wsdl:part name="parameters" element="tns:GetPreferenceDescriptionLineFromIdAndValueResponse" />
  </wsdl:message>
  <wsdl:message name="GetPreferenceDescriptionLineFromIdAndValueResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreferencesRequest">
    <wsdl:part name="parameters" element="tns:GetPreferences" />
  </wsdl:message>
  <wsdl:message name="GetPreferencesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreferencesResponse">
    <wsdl:part name="parameters" element="tns:GetPreferencesResponse" />
  </wsdl:message>
  <wsdl:message name="GetPreferencesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SavePreferencesRequest">
    <wsdl:part name="parameters" element="tns:SavePreferences" />
  </wsdl:message>
  <wsdl:message name="SavePreferencesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SavePreferencesResponse">
    <wsdl:part name="parameters" element="tns:SavePreferencesResponse" />
  </wsdl:message>
  <wsdl:message name="SavePreferencesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreferencesWithDisplayValuesRequest">
    <wsdl:part name="parameters" element="tns:GetPreferencesWithDisplayValues" />
  </wsdl:message>
  <wsdl:message name="GetPreferencesWithDisplayValuesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreferencesWithDisplayValuesResponse">
    <wsdl:part name="parameters" element="tns:GetPreferencesWithDisplayValuesResponse" />
  </wsdl:message>
  <wsdl:message name="GetPreferencesWithDisplayValuesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTabOrdersRequest">
    <wsdl:part name="parameters" element="tns:GetTabOrders" />
  </wsdl:message>
  <wsdl:message name="GetTabOrdersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTabOrdersResponse">
    <wsdl:part name="parameters" element="tns:GetTabOrdersResponse" />
  </wsdl:message>
  <wsdl:message name="GetTabOrdersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTabOrdersRequest">
    <wsdl:part name="parameters" element="tns:SaveTabOrders" />
  </wsdl:message>
  <wsdl:message name="SaveTabOrdersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTabOrdersResponse">
    <wsdl:part name="parameters" element="tns:SaveTabOrdersResponse" />
  </wsdl:message>
  <wsdl:message name="SaveTabOrdersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Preference">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Preference</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultPreference">
      <wsdl:documentation>
        <summary>Loading default values into a new Preference.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/CreateDefaultPreference" name="CreateDefaultPreferenceRequest" message="tns:CreateDefaultPreferenceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/CreateDefaultPreferenceResponse" name="CreateDefaultPreferenceResponse" message="tns:CreateDefaultPreferenceResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultPreferenceDescription">
      <wsdl:documentation>
        <summary>Loading default values into a new PreferenceDescription.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/CreateDefaultPreferenceDescription" name="CreateDefaultPreferenceDescriptionRequest" message="tns:CreateDefaultPreferenceDescriptionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/CreateDefaultPreferenceDescriptionResponse" name="CreateDefaultPreferenceDescriptionResponse" message="tns:CreateDefaultPreferenceDescriptionResponse" />
    </wsdl:operation>
    <wsdl:operation name="SavePreferenceDescription">
      <wsdl:documentation>
        <summary>Updates the existing PreferenceDescription or creates a new PreferenceDescription if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/SavePreferenceDescription" name="SavePreferenceDescriptionRequest" message="tns:SavePreferenceDescriptionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/SavePreferenceDescriptionResponse" name="SavePreferenceDescriptionResponse" message="tns:SavePreferenceDescriptionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultPreferenceDescriptionLine">
      <wsdl:documentation>
        <summary>Loading default values into a new PreferenceDescriptionLine.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/CreateDefaultPreferenceDescriptionLine" name="CreateDefaultPreferenceDescriptionLineRequest" message="tns:CreateDefaultPreferenceDescriptionLineRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/CreateDefaultPreferenceDescriptionLineResponse" name="CreateDefaultPreferenceDescriptionLineResponse" message="tns:CreateDefaultPreferenceDescriptionLineResponse" />
    </wsdl:operation>
    <wsdl:operation name="SavePreference">
      <wsdl:documentation>
        <summary>Save this preference</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/SavePreference" name="SavePreferenceRequest" message="tns:SavePreferenceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/SavePreferenceResponse" name="SavePreferenceResponse" message="tns:SavePreferenceResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveTabOrder">
      <wsdl:documentation>
        <summary>Saves the tab order. The order is saved pr. user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/SaveTabOrder" name="SaveTabOrderRequest" message="tns:SaveTabOrderRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/SaveTabOrderResponse" name="SaveTabOrderResponse" message="tns:SaveTabOrderResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTabOrder">
      <wsdl:documentation>
        <summary>Gets the tab order.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetTabOrder" name="GetTabOrderRequest" message="tns:GetTabOrderRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetTabOrderResponse" name="GetTabOrderResponse" message="tns:GetTabOrderResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPreference">
      <wsdl:documentation>
        <summary>Get a preference by id</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreference" name="GetPreferenceRequest" message="tns:GetPreferenceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferenceResponse" name="GetPreferenceResponse" message="tns:GetPreferenceResponse" />
    </wsdl:operation>
    <wsdl:operation name="SavePreferenceEntity">
      <wsdl:documentation>
        <summary>Saves a complete preference object. Preference administrator rights are required to use this</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/SavePreferenceEntity" name="SavePreferenceEntityRequest" message="tns:SavePreferenceEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/SavePreferenceEntityResponse" name="SavePreferenceEntityResponse" message="tns:SavePreferenceEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeletePreference">
      <wsdl:documentation>
        <summary>Delete a preference by id</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/DeletePreference" name="DeletePreferenceRequest" message="tns:DeletePreferenceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/DeletePreferenceResponse" name="DeletePreferenceResponse" message="tns:DeletePreferenceResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeletePreferences">
      <wsdl:documentation>
        <summary>Delete some preferences by id</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/DeletePreferences" name="DeletePreferencesRequest" message="tns:DeletePreferencesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/DeletePreferencesResponse" name="DeletePreferencesResponse" message="tns:DeletePreferencesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPreferenceByName">
      <wsdl:documentation>
        <summary>Get a preference by name</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferenceByName" name="GetPreferenceByNameRequest" message="tns:GetPreferenceByNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferenceByNameResponse" name="GetPreferenceByNameResponse" message="tns:GetPreferenceByNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNetServicesStatusUrl">
      <wsdl:documentation>
        <summary>Returns URL to status service. e.g. 'https://help.superoffice.com/sodispatcher/v1/status' Returns NULL if status does not need to be checked yet.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetNetServicesStatusUrl" name="GetNetServicesStatusUrlRequest" message="tns:GetNetServicesStatusUrlRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetNetServicesStatusUrlResponse" name="GetNetServicesStatusUrlResponse" message="tns:GetNetServicesStatusUrlResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateNetServicesStatus">
      <wsdl:documentation>
        <summary>Update the NetServices preferences with values contained in the content from the Status URL</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/UpdateNetServicesStatus" name="UpdateNetServicesStatusRequest" message="tns:UpdateNetServicesStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/UpdateNetServicesStatusResponse" name="UpdateNetServicesStatusResponse" message="tns:UpdateNetServicesStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPreferenceDescription">
      <wsdl:documentation>
        <summary>Gets a PreferenceDescription object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferenceDescription" name="GetPreferenceDescriptionRequest" message="tns:GetPreferenceDescriptionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferenceDescriptionResponse" name="GetPreferenceDescriptionResponse" message="tns:GetPreferenceDescriptionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPreferenceDescriptionLine">
      <wsdl:documentation>
        <summary>Gets a PreferenceDescriptionLine object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferenceDescriptionLine" name="GetPreferenceDescriptionLineRequest" message="tns:GetPreferenceDescriptionLineRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferenceDescriptionLineResponse" name="GetPreferenceDescriptionLineResponse" message="tns:GetPreferenceDescriptionLineResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPreferenceDescriptionLineFromIdAndValue">
      <wsdl:documentation>
        <summary>Get a preference description line from a prefDesc_id and a prefValue</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferenceDescriptionLineFromIdAndValue" name="GetPreferenceDescriptionLineFromIdAndValueRequest" message="tns:GetPreferenceDescriptionLineFromIdAndValueRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferenceDescriptionLineFromIdAndValueResponse" name="GetPreferenceDescriptionLineFromIdAndValueResponse" message="tns:GetPreferenceDescriptionLineFromIdAndValueResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPreferences">
      <wsdl:documentation>
        <summary>Get one or more preferences based on a set of specifications.&lt;br/&gt;The prefDisplayvalue and prefDisplaytooltip are blank (faster processing relative to GetPreferencesWithDisplayValues)</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferences" name="GetPreferencesRequest" message="tns:GetPreferencesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferencesResponse" name="GetPreferencesResponse" message="tns:GetPreferencesResponse" />
    </wsdl:operation>
    <wsdl:operation name="SavePreferences">
      <wsdl:documentation>
        <summary>Save this set of preferences all the way to the database.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/SavePreferences" name="SavePreferencesRequest" message="tns:SavePreferencesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/SavePreferencesResponse" name="SavePreferencesResponse" message="tns:SavePreferencesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPreferencesWithDisplayValues">
      <wsdl:documentation>
        <summary>Get one or more preferences based on a set of specifications&lt;br/&gt;The PrefDisplayValue and PrefDisplaytooltip are populated, at some additional processing cost.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferencesWithDisplayValues" name="GetPreferencesWithDisplayValuesRequest" message="tns:GetPreferencesWithDisplayValuesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferencesWithDisplayValuesResponse" name="GetPreferencesWithDisplayValuesResponse" message="tns:GetPreferencesWithDisplayValuesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTabOrders">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetTabOrders" name="GetTabOrdersRequest" message="tns:GetTabOrdersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetTabOrdersResponse" name="GetTabOrdersResponse" message="tns:GetTabOrdersResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveTabOrders">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/SaveTabOrders" name="SaveTabOrdersRequest" message="tns:SaveTabOrdersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/SaveTabOrdersResponse" name="SaveTabOrdersResponse" message="tns:SaveTabOrdersResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Preference" type="tns:Preference">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultPreference">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/CreateDefaultPreference" style="document" />
      <wsdl:input name="CreateDefaultPreferenceRequest">
        <soap:header message="tns:CreateDefaultPreferenceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultPreferenceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultPreferenceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultPreferenceResponse">
        <soap:header message="tns:CreateDefaultPreferenceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultPreferenceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultPreferenceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultPreferenceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultPreferenceDescription">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/CreateDefaultPreferenceDescription" style="document" />
      <wsdl:input name="CreateDefaultPreferenceDescriptionRequest">
        <soap:header message="tns:CreateDefaultPreferenceDescriptionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultPreferenceDescriptionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultPreferenceDescriptionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultPreferenceDescriptionResponse">
        <soap:header message="tns:CreateDefaultPreferenceDescriptionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultPreferenceDescriptionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultPreferenceDescriptionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultPreferenceDescriptionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SavePreferenceDescription">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/SavePreferenceDescription" style="document" />
      <wsdl:input name="SavePreferenceDescriptionRequest">
        <soap:header message="tns:SavePreferenceDescriptionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SavePreferenceDescriptionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SavePreferenceDescriptionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SavePreferenceDescriptionResponse">
        <soap:header message="tns:SavePreferenceDescriptionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SavePreferenceDescriptionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SavePreferenceDescriptionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SavePreferenceDescriptionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultPreferenceDescriptionLine">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/CreateDefaultPreferenceDescriptionLine" style="document" />
      <wsdl:input name="CreateDefaultPreferenceDescriptionLineRequest">
        <soap:header message="tns:CreateDefaultPreferenceDescriptionLineRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultPreferenceDescriptionLineRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultPreferenceDescriptionLineRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultPreferenceDescriptionLineResponse">
        <soap:header message="tns:CreateDefaultPreferenceDescriptionLineResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultPreferenceDescriptionLineResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultPreferenceDescriptionLineResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultPreferenceDescriptionLineResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SavePreference">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/SavePreference" style="document" />
      <wsdl:input name="SavePreferenceRequest">
        <soap:header message="tns:SavePreferenceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SavePreferenceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SavePreferenceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SavePreferenceResponse">
        <soap:header message="tns:SavePreferenceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SavePreferenceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SavePreferenceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SavePreferenceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveTabOrder">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/SaveTabOrder" style="document" />
      <wsdl:input name="SaveTabOrderRequest">
        <soap:header message="tns:SaveTabOrderRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveTabOrderRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveTabOrderRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveTabOrderResponse">
        <soap:header message="tns:SaveTabOrderResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveTabOrderResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveTabOrderResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveTabOrderResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTabOrder">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetTabOrder" style="document" />
      <wsdl:input name="GetTabOrderRequest">
        <soap:header message="tns:GetTabOrderRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTabOrderRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTabOrderRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTabOrderResponse">
        <soap:header message="tns:GetTabOrderResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTabOrderResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTabOrderResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTabOrderResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPreference">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreference" style="document" />
      <wsdl:input name="GetPreferenceRequest">
        <soap:header message="tns:GetPreferenceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPreferenceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPreferenceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPreferenceResponse">
        <soap:header message="tns:GetPreferenceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPreferenceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPreferenceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPreferenceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SavePreferenceEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/SavePreferenceEntity" style="document" />
      <wsdl:input name="SavePreferenceEntityRequest">
        <soap:header message="tns:SavePreferenceEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SavePreferenceEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SavePreferenceEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SavePreferenceEntityResponse">
        <soap:header message="tns:SavePreferenceEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SavePreferenceEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SavePreferenceEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SavePreferenceEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeletePreference">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/DeletePreference" style="document" />
      <wsdl:input name="DeletePreferenceRequest">
        <soap:header message="tns:DeletePreferenceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeletePreferenceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeletePreferenceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeletePreferenceResponse">
        <soap:header message="tns:DeletePreferenceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeletePreferenceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeletePreferenceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeletePreferenceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeletePreferences">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/DeletePreferences" style="document" />
      <wsdl:input name="DeletePreferencesRequest">
        <soap:header message="tns:DeletePreferencesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeletePreferencesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeletePreferencesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeletePreferencesResponse">
        <soap:header message="tns:DeletePreferencesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeletePreferencesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeletePreferencesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeletePreferencesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPreferenceByName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferenceByName" style="document" />
      <wsdl:input name="GetPreferenceByNameRequest">
        <soap:header message="tns:GetPreferenceByNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPreferenceByNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPreferenceByNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPreferenceByNameResponse">
        <soap:header message="tns:GetPreferenceByNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPreferenceByNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPreferenceByNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPreferenceByNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNetServicesStatusUrl">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetNetServicesStatusUrl" style="document" />
      <wsdl:input name="GetNetServicesStatusUrlRequest">
        <soap:header message="tns:GetNetServicesStatusUrlRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNetServicesStatusUrlRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNetServicesStatusUrlRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNetServicesStatusUrlResponse">
        <soap:header message="tns:GetNetServicesStatusUrlResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNetServicesStatusUrlResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNetServicesStatusUrlResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNetServicesStatusUrlResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateNetServicesStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/UpdateNetServicesStatus" style="document" />
      <wsdl:input name="UpdateNetServicesStatusRequest">
        <soap:header message="tns:UpdateNetServicesStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateNetServicesStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateNetServicesStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateNetServicesStatusResponse">
        <soap:header message="tns:UpdateNetServicesStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateNetServicesStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateNetServicesStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateNetServicesStatusResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPreferenceDescription">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferenceDescription" style="document" />
      <wsdl:input name="GetPreferenceDescriptionRequest">
        <soap:header message="tns:GetPreferenceDescriptionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPreferenceDescriptionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPreferenceDescriptionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPreferenceDescriptionResponse">
        <soap:header message="tns:GetPreferenceDescriptionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPreferenceDescriptionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPreferenceDescriptionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPreferenceDescriptionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPreferenceDescriptionLine">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferenceDescriptionLine" style="document" />
      <wsdl:input name="GetPreferenceDescriptionLineRequest">
        <soap:header message="tns:GetPreferenceDescriptionLineRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPreferenceDescriptionLineRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPreferenceDescriptionLineRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPreferenceDescriptionLineResponse">
        <soap:header message="tns:GetPreferenceDescriptionLineResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPreferenceDescriptionLineResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPreferenceDescriptionLineResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPreferenceDescriptionLineResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPreferenceDescriptionLineFromIdAndValue">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferenceDescriptionLineFromIdAndValue" style="document" />
      <wsdl:input name="GetPreferenceDescriptionLineFromIdAndValueRequest">
        <soap:header message="tns:GetPreferenceDescriptionLineFromIdAndValueRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPreferenceDescriptionLineFromIdAndValueRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPreferenceDescriptionLineFromIdAndValueRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPreferenceDescriptionLineFromIdAndValueResponse">
        <soap:header message="tns:GetPreferenceDescriptionLineFromIdAndValueResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPreferenceDescriptionLineFromIdAndValueResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPreferenceDescriptionLineFromIdAndValueResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPreferenceDescriptionLineFromIdAndValueResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPreferences">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferences" style="document" />
      <wsdl:input name="GetPreferencesRequest">
        <soap:header message="tns:GetPreferencesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPreferencesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPreferencesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPreferencesResponse">
        <soap:header message="tns:GetPreferencesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPreferencesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPreferencesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPreferencesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SavePreferences">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/SavePreferences" style="document" />
      <wsdl:input name="SavePreferencesRequest">
        <soap:header message="tns:SavePreferencesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SavePreferencesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SavePreferencesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SavePreferencesResponse">
        <soap:header message="tns:SavePreferencesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SavePreferencesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SavePreferencesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SavePreferencesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPreferencesWithDisplayValues">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetPreferencesWithDisplayValues" style="document" />
      <wsdl:input name="GetPreferencesWithDisplayValuesRequest">
        <soap:header message="tns:GetPreferencesWithDisplayValuesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPreferencesWithDisplayValuesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPreferencesWithDisplayValuesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPreferencesWithDisplayValuesResponse">
        <soap:header message="tns:GetPreferencesWithDisplayValuesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPreferencesWithDisplayValuesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPreferencesWithDisplayValuesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPreferencesWithDisplayValuesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTabOrders">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/GetTabOrders" style="document" />
      <wsdl:input name="GetTabOrdersRequest">
        <soap:header message="tns:GetTabOrdersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTabOrdersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTabOrdersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTabOrdersResponse">
        <soap:header message="tns:GetTabOrdersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTabOrdersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTabOrdersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTabOrdersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveTabOrders">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Preference/SaveTabOrders" style="document" />
      <wsdl:input name="SaveTabOrdersRequest">
        <soap:header message="tns:SaveTabOrdersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveTabOrdersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveTabOrdersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveTabOrdersResponse">
        <soap:header message="tns:SaveTabOrdersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveTabOrdersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveTabOrdersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveTabOrdersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfPreferenceService">
    <wsdl:port name="BasicHttpBinding_Preference" binding="tns:BasicHttpBinding_Preference">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services80/Preference.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

