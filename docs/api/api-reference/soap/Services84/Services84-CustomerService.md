---
Generated: 1
TOCExclude: 1
title: Services84.CustomerServiceAgent WSDL
---

# Services84.CustomerServiceAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfCustomerServiceService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services84" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services84" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services84" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultSmsConfig">
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
      <xs:element name="CreateDefaultSmsConfigResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SmsConfig" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SmsConfig">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="DefaultSmsCountry" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="NetServerSmsProvider" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="NsPluginSender" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="NsPluginConfig" nillable="true" type="tns:StringDictionary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SmsConfig" nillable="true" type="tns:SmsConfig" />
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
      <xs:element name="SaveSmsConfig">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SmsConfig" nillable="true" type="tns:SmsConfig" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveSmsConfigResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SmsConfig" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateSession">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RemoteIp" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateSessionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CsSessionKey" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CsSessionKey">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Key" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="LoginId" type="xs:int" />
              <xs:element minOccurs="0" name="UserId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CsSessionKey" nillable="true" type="tns:CsSessionKey" />
      <xs:element name="RemoveSession">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LoginId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveSessionResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SessionIsValid">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CsSessionKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SessionIsValidResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="HasChatNotify">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="HasChatNotifyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateFeatureToggles">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FeatureToggles" nillable="true" type="tns:ArrayOfCsFeatureToggle" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfCsFeatureToggle">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="CsFeatureToggle" nillable="true" type="tns:CsFeatureToggle" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCsFeatureToggle" nillable="true" type="tns:ArrayOfCsFeatureToggle" />
      <xs:complexType name="CsFeatureToggle">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="State" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CsFeatureToggle" nillable="true" type="tns:CsFeatureToggle" />
      <xs:element name="UpdateFeatureTogglesResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="EventHandlerExists">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EventHandlerType" type="tns:EventHandlerType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="EventHandlerType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="SalesBeforeSaveAppointment">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1001</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveStakeholder">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1002</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveQuote">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1003</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveDocument">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1004</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveContact">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1005</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSavePerson">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1006</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveRelation">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1007</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveSale">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1008</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveProject">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1009</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveSelection">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1010</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveProjectMember">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1011</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveSelectionMember">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1012</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveAppointment">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1101</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveStakeholder">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1102</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveQuote">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1103</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveDocument">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1104</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveContact">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1105</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSavePerson">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1106</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveRelation">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1107</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveSale">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1108</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveProject">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1109</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveSelection">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1110</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveProjectMember">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1111</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveSelectionMember">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1112</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="EventHandlerType" nillable="true" type="tns:EventHandlerType" />
      <xs:element name="EventHandlerExistsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetStatistics">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Functions" nillable="true" type="tns:ArrayOfStatusScreenPanelType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfStatusScreenPanelType">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="StatusScreenPanelType" type="tns:StatusScreenPanelType" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfStatusScreenPanelType" nillable="true" type="tns:ArrayOfStatusScreenPanelType" />
      <xs:simpleType name="StatusScreenPanelType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="OpenRequestsPerCategory" />
          <xs:enumeration value="OpenRequestsPerTopCategory" />
          <xs:enumeration value="OpenRequestsPerUser" />
          <xs:enumeration value="OpenRequestsPerUserGroup" />
          <xs:enumeration value="OpenRequestsPerPriority" />
          <xs:enumeration value="OpenRequestsPerStatus" />
          <xs:enumeration value="OpenRequestsPerOrigin" />
          <xs:enumeration value="NumberOfCreatedRequestsPerDay">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">11</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="NumberOfCreatedRequestsPerWeek">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">12</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="NumberOfCreatedRequestsPerMonth">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">13</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="UserResponseTimePerDay">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">21</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="UserReponseTimePerWeek">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">22</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="UserResponseTimePerMonth">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">23</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="OwnOpenRequests">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">101</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="UnassignedRequests">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">102</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Hotlist">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">103</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="StatusScreen">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">111</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="StatusScreenPanelType" nillable="true" type="tns:StatusScreenPanelType" />
      <xs:element name="GetStatisticsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfStatisticsDataSet" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfStatisticsDataSet">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="StatisticsDataSet" nillable="true" type="tns:StatisticsDataSet" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfStatisticsDataSet" nillable="true" type="tns:ArrayOfStatisticsDataSet" />
      <xs:complexType name="StatisticsDataSet">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Label" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Values" nillable="true" type="tns:ArrayOfStatisticsDataValue" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="StatisticsDataSet" nillable="true" type="tns:StatisticsDataSet" />
      <xs:complexType name="ArrayOfStatisticsDataValue">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="StatisticsDataValue" nillable="true" type="tns:StatisticsDataValue" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfStatisticsDataValue" nillable="true" type="tns:ArrayOfStatisticsDataValue" />
      <xs:complexType name="StatisticsDataValue">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Label" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Value" type="xs:double" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="StatisticsDataValue" nillable="true" type="tns:StatisticsDataValue" />
      <xs:element name="GetSmsConfig">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSmsConfigResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SmsConfig" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteChatSessions">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Ids" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteChatSessionsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ChatSessionsForUser">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ChatSessionsForUserResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfChatSession" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfChatSession">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ChatSession" nillable="true" type="tns:ChatSession" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfChatSession" nillable="true" type="tns:ArrayOfChatSession" />
      <xs:complexType name="ChatSession">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ChatSessionId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ChatSession" nillable="true" type="tns:ChatSession" />
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
  <wsdl:message name="CreateDefaultSmsConfigRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultSmsConfig" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSmsConfigRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSmsConfigResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultSmsConfigResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSmsConfigResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSmsConfigRequest">
    <wsdl:part name="parameters" element="tns:SaveSmsConfig" />
  </wsdl:message>
  <wsdl:message name="SaveSmsConfigRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSmsConfigResponse">
    <wsdl:part name="parameters" element="tns:SaveSmsConfigResponse" />
  </wsdl:message>
  <wsdl:message name="SaveSmsConfigResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateSessionRequest">
    <wsdl:part name="parameters" element="tns:CreateSession" />
  </wsdl:message>
  <wsdl:message name="CreateSessionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateSessionResponse">
    <wsdl:part name="parameters" element="tns:CreateSessionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateSessionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveSessionRequest">
    <wsdl:part name="parameters" element="tns:RemoveSession" />
  </wsdl:message>
  <wsdl:message name="RemoveSessionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveSessionResponse">
    <wsdl:part name="parameters" element="tns:RemoveSessionResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveSessionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SessionIsValidRequest">
    <wsdl:part name="parameters" element="tns:SessionIsValid" />
  </wsdl:message>
  <wsdl:message name="SessionIsValidRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SessionIsValidResponse">
    <wsdl:part name="parameters" element="tns:SessionIsValidResponse" />
  </wsdl:message>
  <wsdl:message name="SessionIsValidResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasChatNotifyRequest">
    <wsdl:part name="parameters" element="tns:HasChatNotify" />
  </wsdl:message>
  <wsdl:message name="HasChatNotifyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasChatNotifyResponse">
    <wsdl:part name="parameters" element="tns:HasChatNotifyResponse" />
  </wsdl:message>
  <wsdl:message name="HasChatNotifyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateFeatureTogglesRequest">
    <wsdl:part name="parameters" element="tns:UpdateFeatureToggles" />
  </wsdl:message>
  <wsdl:message name="UpdateFeatureTogglesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateFeatureTogglesResponse">
    <wsdl:part name="parameters" element="tns:UpdateFeatureTogglesResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateFeatureTogglesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="EventHandlerExistsRequest">
    <wsdl:part name="parameters" element="tns:EventHandlerExists" />
  </wsdl:message>
  <wsdl:message name="EventHandlerExistsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="EventHandlerExistsResponse">
    <wsdl:part name="parameters" element="tns:EventHandlerExistsResponse" />
  </wsdl:message>
  <wsdl:message name="EventHandlerExistsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetStatisticsRequest">
    <wsdl:part name="parameters" element="tns:GetStatistics" />
  </wsdl:message>
  <wsdl:message name="GetStatisticsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetStatisticsResponse">
    <wsdl:part name="parameters" element="tns:GetStatisticsResponse" />
  </wsdl:message>
  <wsdl:message name="GetStatisticsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSmsConfigRequest">
    <wsdl:part name="parameters" element="tns:GetSmsConfig" />
  </wsdl:message>
  <wsdl:message name="GetSmsConfigRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSmsConfigResponse">
    <wsdl:part name="parameters" element="tns:GetSmsConfigResponse" />
  </wsdl:message>
  <wsdl:message name="GetSmsConfigResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteChatSessionsRequest">
    <wsdl:part name="parameters" element="tns:DeleteChatSessions" />
  </wsdl:message>
  <wsdl:message name="DeleteChatSessionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteChatSessionsResponse">
    <wsdl:part name="parameters" element="tns:DeleteChatSessionsResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteChatSessionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChatSessionsForUserRequest">
    <wsdl:part name="parameters" element="tns:ChatSessionsForUser" />
  </wsdl:message>
  <wsdl:message name="ChatSessionsForUserRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChatSessionsForUserResponse">
    <wsdl:part name="parameters" element="tns:ChatSessionsForUserResponse" />
  </wsdl:message>
  <wsdl:message name="ChatSessionsForUserResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="CustomerService">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for CustomerService</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultSmsConfig">
      <wsdl:documentation>
        <summary>Loading default values into a new SmsConfig.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/CreateDefaultSmsConfig" name="CreateDefaultSmsConfigRequest" message="tns:CreateDefaultSmsConfigRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/CreateDefaultSmsConfigResponse" name="CreateDefaultSmsConfigResponse" message="tns:CreateDefaultSmsConfigResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveSmsConfig">
      <wsdl:documentation>
        <summary>Updates the existing SmsConfig or creates a new SmsConfig if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/SaveSmsConfig" name="SaveSmsConfigRequest" message="tns:SaveSmsConfigRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/SaveSmsConfigResponse" name="SaveSmsConfigResponse" message="tns:SaveSmsConfigResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateSession">
      <wsdl:documentation>
        <summary>Creates a login session for a CS user</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/CreateSession" name="CreateSessionRequest" message="tns:CreateSessionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/CreateSessionResponse" name="CreateSessionResponse" message="tns:CreateSessionResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveSession">
      <wsdl:documentation>
        <summary>Remove a login session for a CS user</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/RemoveSession" name="RemoveSessionRequest" message="tns:RemoveSessionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/RemoveSessionResponse" name="RemoveSessionResponse" message="tns:RemoveSessionResponse" />
    </wsdl:operation>
    <wsdl:operation name="SessionIsValid">
      <wsdl:documentation>
        <summary>Check if a CS session is valid</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/SessionIsValid" name="SessionIsValidRequest" message="tns:SessionIsValidRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/SessionIsValidResponse" name="SessionIsValidResponse" message="tns:SessionIsValidResponse" />
    </wsdl:operation>
    <wsdl:operation name="HasChatNotify">
      <wsdl:documentation>
        <summary>Check if user has any chat notification</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/HasChatNotify" name="HasChatNotifyRequest" message="tns:HasChatNotifyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/HasChatNotifyResponse" name="HasChatNotifyResponse" message="tns:HasChatNotifyResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateFeatureToggles">
      <wsdl:documentation>
        <summary>Update the cached FeatureToggles for CS</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/UpdateFeatureToggles" name="UpdateFeatureTogglesRequest" message="tns:UpdateFeatureTogglesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/UpdateFeatureTogglesResponse" name="UpdateFeatureTogglesResponse" message="tns:UpdateFeatureTogglesResponse" />
    </wsdl:operation>
    <wsdl:operation name="EventHandlerExists">
      <wsdl:documentation>
        <summary>Check if an eventhandler exists for a given enum</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/EventHandlerExists" name="EventHandlerExistsRequest" message="tns:EventHandlerExistsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/EventHandlerExistsResponse" name="EventHandlerExistsResponse" message="tns:EventHandlerExistsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetStatistics">
      <wsdl:documentation>
        <summary>Returns the calculated results for the required statistics for the Customer Service Status Page</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/GetStatistics" name="GetStatisticsRequest" message="tns:GetStatisticsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/GetStatisticsResponse" name="GetStatisticsResponse" message="tns:GetStatisticsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSmsConfig">
      <wsdl:documentation>
        <summary>Get the SmsConfig settings for Customer Service sms providers.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/GetSmsConfig" name="GetSmsConfigRequest" message="tns:GetSmsConfigRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/GetSmsConfigResponse" name="GetSmsConfigResponse" message="tns:GetSmsConfigResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteChatSessions">
      <wsdl:documentation>
        <summary>Deletes the specified chat sessions.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/DeleteChatSessions" name="DeleteChatSessionsRequest" message="tns:DeleteChatSessionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/DeleteChatSessionsResponse" name="DeleteChatSessionsResponse" message="tns:DeleteChatSessionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChatSessionsForUser">
      <wsdl:documentation>
        <summary>Get all chat sessions which this user is a member of. Members means that you have at least one of: Can Respond, Notifications, Listen or Manager</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/ChatSessionsForUser" name="ChatSessionsForUserRequest" message="tns:ChatSessionsForUserRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/ChatSessionsForUserResponse" name="ChatSessionsForUserResponse" message="tns:ChatSessionsForUserResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_CustomerService" type="tns:CustomerService">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultSmsConfig">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/CreateDefaultSmsConfig" style="document" />
      <wsdl:input name="CreateDefaultSmsConfigRequest">
        <soap:header message="tns:CreateDefaultSmsConfigRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultSmsConfigRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultSmsConfigRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultSmsConfigResponse">
        <soap:header message="tns:CreateDefaultSmsConfigResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSmsConfigResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSmsConfigResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultSmsConfigResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveSmsConfig">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/SaveSmsConfig" style="document" />
      <wsdl:input name="SaveSmsConfigRequest">
        <soap:header message="tns:SaveSmsConfigRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveSmsConfigRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveSmsConfigRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveSmsConfigResponse">
        <soap:header message="tns:SaveSmsConfigResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveSmsConfigResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveSmsConfigResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveSmsConfigResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateSession">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/CreateSession" style="document" />
      <wsdl:input name="CreateSessionRequest">
        <soap:header message="tns:CreateSessionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateSessionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateSessionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateSessionResponse">
        <soap:header message="tns:CreateSessionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateSessionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateSessionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateSessionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveSession">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/RemoveSession" style="document" />
      <wsdl:input name="RemoveSessionRequest">
        <soap:header message="tns:RemoveSessionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveSessionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveSessionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveSessionResponse">
        <soap:header message="tns:RemoveSessionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveSessionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveSessionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveSessionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SessionIsValid">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/SessionIsValid" style="document" />
      <wsdl:input name="SessionIsValidRequest">
        <soap:header message="tns:SessionIsValidRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SessionIsValidRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SessionIsValidRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SessionIsValidResponse">
        <soap:header message="tns:SessionIsValidResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SessionIsValidResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SessionIsValidResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SessionIsValidResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="HasChatNotify">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/HasChatNotify" style="document" />
      <wsdl:input name="HasChatNotifyRequest">
        <soap:header message="tns:HasChatNotifyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:HasChatNotifyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:HasChatNotifyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="HasChatNotifyResponse">
        <soap:header message="tns:HasChatNotifyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:HasChatNotifyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:HasChatNotifyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:HasChatNotifyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateFeatureToggles">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/UpdateFeatureToggles" style="document" />
      <wsdl:input name="UpdateFeatureTogglesRequest">
        <soap:header message="tns:UpdateFeatureTogglesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateFeatureTogglesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateFeatureTogglesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateFeatureTogglesResponse">
        <soap:header message="tns:UpdateFeatureTogglesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateFeatureTogglesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateFeatureTogglesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateFeatureTogglesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="EventHandlerExists">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/EventHandlerExists" style="document" />
      <wsdl:input name="EventHandlerExistsRequest">
        <soap:header message="tns:EventHandlerExistsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:EventHandlerExistsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:EventHandlerExistsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="EventHandlerExistsResponse">
        <soap:header message="tns:EventHandlerExistsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:EventHandlerExistsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:EventHandlerExistsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:EventHandlerExistsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetStatistics">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/GetStatistics" style="document" />
      <wsdl:input name="GetStatisticsRequest">
        <soap:header message="tns:GetStatisticsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetStatisticsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetStatisticsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetStatisticsResponse">
        <soap:header message="tns:GetStatisticsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetStatisticsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetStatisticsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetStatisticsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSmsConfig">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/GetSmsConfig" style="document" />
      <wsdl:input name="GetSmsConfigRequest">
        <soap:header message="tns:GetSmsConfigRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSmsConfigRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSmsConfigRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSmsConfigResponse">
        <soap:header message="tns:GetSmsConfigResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSmsConfigResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSmsConfigResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSmsConfigResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteChatSessions">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/DeleteChatSessions" style="document" />
      <wsdl:input name="DeleteChatSessionsRequest">
        <soap:header message="tns:DeleteChatSessionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteChatSessionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteChatSessionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteChatSessionsResponse">
        <soap:header message="tns:DeleteChatSessionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteChatSessionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteChatSessionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteChatSessionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChatSessionsForUser">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/CustomerService/ChatSessionsForUser" style="document" />
      <wsdl:input name="ChatSessionsForUserRequest">
        <soap:header message="tns:ChatSessionsForUserRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChatSessionsForUserRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChatSessionsForUserRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChatSessionsForUserResponse">
        <soap:header message="tns:ChatSessionsForUserResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChatSessionsForUserResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChatSessionsForUserResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChatSessionsForUserResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfCustomerServiceService">
    <wsdl:port name="BasicHttpBinding_CustomerService" binding="tns:BasicHttpBinding_CustomerService">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services84/CustomerService.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

