---
generated: 1
uid: wsdl-Services88-ErpSync
title: Services88.ErpSyncAgent WSDL
---

# Services88.ErpSyncAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfErpSyncService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:ser="http://schemas.microsoft.com/2003/10/Serialization/">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:element name="CreateDefaultErpSyncConnectorEntity">
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
      <xs:element name="SoCredentials" nillable="true" type="q1:SoCredentials" xmlns:q1="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="Credentials" nillable="true" type="q2:SoCredentials" xmlns:q2="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SoTimeZone">
        <xs:sequence>
          <xs:element minOccurs="0" name="SoTimeZoneId" type="xs:int" />
          <xs:element minOccurs="0" name="SoTimeZoneLocationCode" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoTimeZone" nillable="true" type="q3:SoTimeZone" xmlns:q3="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="TimeZone" nillable="true" type="q4:SoTimeZone" xmlns:q4="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="CreateDefaultErpSyncConnectorEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q5:ErpSyncConnectorEntity" xmlns:q5="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ErpSyncConnectorEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q6:Carrier" xmlns:q6="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ErpConnectorId" type="xs:int" />
              <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="URL" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ErpSyncConnectorEntity" nillable="true" type="q7:ErpSyncConnectorEntity" xmlns:q7="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Carrier">
        <xs:sequence>
          <xs:element minOccurs="0" name="TableRight" nillable="true" type="q8:TableRight" xmlns:q8="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="FieldProperties" nillable="true" type="q9:FieldPropertyDictionary" xmlns:q9="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="Carrier" nillable="true" type="q10:Carrier" xmlns:q10="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TableRight">
        <xs:sequence>
          <xs:element minOccurs="0" name="Mask" type="q11:ETableRight" xmlns:q11="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TableRight" nillable="true" type="q12:TableRight" xmlns:q12="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="ETableRight" nillable="true" type="q13:ETableRight" xmlns:q13="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
                <xs:element name="Value" nillable="true" type="q14:FieldProperty" xmlns:q14="http://www.superoffice.net/ws/crm/NetServer/Services88" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldPropertyDictionary" nillable="true" type="q15:FieldPropertyDictionary" xmlns:q15="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="FieldProperty">
        <xs:sequence>
          <xs:element minOccurs="0" name="FieldRight" nillable="true" type="q16:FieldRight" xmlns:q16="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="FieldType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FieldLength" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldProperty" nillable="true" type="q17:FieldProperty" xmlns:q17="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="FieldRight">
        <xs:sequence>
          <xs:element minOccurs="0" name="Mask" type="q18:EFieldRight" xmlns:q18="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldRight" nillable="true" type="q19:FieldRight" xmlns:q19="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="EFieldRight" nillable="true" type="q20:EFieldRight" xmlns:q20="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SoExceptionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="StackTrace" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FriendlyText" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ExceptionType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="InnerException" nillable="true" type="q21:SoExceptionInfo" xmlns:q21="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Parameters" nillable="true" type="q22:SoExceptionInfoParameters" xmlns:q22="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExceptionInfo" nillable="true" type="q23:SoExceptionInfo" xmlns:q23="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="SoExceptionInfoParameters" nillable="true" type="q24:SoExceptionInfoParameters" xmlns:q24="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ExceptionInfo" nillable="true" type="q25:SoExceptionInfo" xmlns:q25="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="SoExtraInfo" nillable="true" type="q26:SoExtraInfo" xmlns:q26="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ExtraInfo" nillable="true" type="q27:SoExtraInfo" xmlns:q27="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="Succeeded" type="xs:boolean" />
      <xs:element name="SaveErpSyncConnectorEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpSyncConnectorEntity" nillable="true" type="q28:ErpSyncConnectorEntity" xmlns:q28="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveErpSyncConnectorEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q29:ErpSyncConnectorEntity" xmlns:q29="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteErpSyncConnectorEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpSyncConnectorEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteErpSyncConnectorEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConnection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConnectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q30:ErpConnection" xmlns:q30="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ErpConnection">
        <xs:complexContent mixed="false">
          <xs:extension base="q31:Carrier" xmlns:q31="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
              <xs:element minOccurs="0" name="ErpConnectorId" type="xs:int" />
              <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayDescription" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Active" type="xs:boolean" />
              <xs:element minOccurs="0" name="ConnectionId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MostRecentTimestamp" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ConfigFields" nillable="true" type="q31:StringDictionary" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="AllAccess" type="xs:boolean" />
              <xs:element minOccurs="0" name="UserGroupAccessIds" nillable="true" type="q32:ArrayOfint" xmlns:q32="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="AssociateAccessIds" nillable="true" type="q33:ArrayOfint" xmlns:q33="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ErpConnection" nillable="true" type="q34:ErpConnection" xmlns:q34="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="StringDictionary" nillable="true" type="q35:StringDictionary" xmlns:q35="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="SaveConnection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Connection" nillable="true" type="q36:ErpConnection" xmlns:q36="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveConnectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q37:ErpConnection" xmlns:q37="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteConnection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteConnectionResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConfigurationFields">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectorId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConfigurationFieldsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q38:ArrayOfFieldMetadata" xmlns:q38="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfFieldMetadata">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="FieldMetadata" nillable="true" type="q39:FieldMetadata" xmlns:q39="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfFieldMetadata" nillable="true" type="q40:ArrayOfFieldMetadata" xmlns:q40="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="FieldMetadata">
        <xs:complexContent mixed="false">
          <xs:extension base="q41:Carrier" xmlns:q41="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="FieldKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayDescription" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FieldType" type="q41:FieldMetadataType" />
              <xs:element minOccurs="0" name="ListName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DefaultValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MaxLength" type="xs:int" />
              <xs:element minOccurs="0" name="Access" type="q41:FieldAccess" />
              <xs:element minOccurs="0" name="ShowInSearch" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="FieldMetadata" nillable="true" type="q42:FieldMetadata" xmlns:q42="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="FieldMetadataType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Checkbox" />
          <xs:enumeration value="Text" />
          <xs:enumeration value="Password" />
          <xs:enumeration value="Integer" />
          <xs:enumeration value="Double" />
          <xs:enumeration value="List" />
          <xs:enumeration value="Date" />
          <xs:enumeration value="Label">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">99</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="FieldMetadataType" nillable="true" type="q43:FieldMetadataType" xmlns:q43="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="FieldAccess">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Normal" />
          <xs:enumeration value="Mandatory" />
          <xs:enumeration value="ReadOnly" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="FieldAccess" nillable="true" type="q44:FieldAccess" xmlns:q44="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetErpConnectionConfigFields">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetErpConnectionConfigFieldsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q45:StringDictionary" xmlns:q45="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleErpConnectionActive">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleErpConnectionActiveResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q46:ArrayOfstring" xmlns:q46="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TestConnectionById">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TestConnectionByIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TestConnectionByConfig">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ConfigFields" nillable="true" type="q47:StringDictionary" xmlns:q47="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TestConnectionByConfigResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveErpConnectionSyncPriorities">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionIds" nillable="true" type="q48:ArrayOfint" xmlns:q48="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveErpConnectionSyncPrioritiesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MoveErpFieldItem">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpFieldId" type="xs:int" />
            <xs:element minOccurs="0" name="Direction" type="xs:int" />
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ErpActorType" type="q49:ErpActorType" xmlns:q49="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
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
      <xs:element name="ErpActorType" nillable="true" type="q50:ErpActorType" xmlns:q50="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="MoveErpFieldItemResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SupportsAdvancedSearch">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ErpActorType" type="q51:ErpActorType" xmlns:q51="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SupportsAdvancedSearchResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConnectionsAndDisplayFields">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CrmActorType" type="q52:CrmActorType" xmlns:q52="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="EntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="CrmActorType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Contact" />
          <xs:enumeration value="Person" />
          <xs:enumeration value="Project" />
          <xs:enumeration value="Sale" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="CrmActorType" nillable="true" type="q53:CrmActorType" xmlns:q53="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetConnectionsAndDisplayFieldsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q54:ArrayOfErpConnectionData" xmlns:q54="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfErpConnectionData">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ErpConnectionData" nillable="true" type="q55:ErpConnectionData" xmlns:q55="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfErpConnectionData" nillable="true" type="q56:ArrayOfErpConnectionData" xmlns:q56="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ErpConnectionData">
        <xs:complexContent mixed="false">
          <xs:extension base="q57:Carrier" xmlns:q57="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
              <xs:element minOccurs="0" name="ConnectionName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Connected" type="xs:boolean" />
              <xs:element minOccurs="0" name="ErpFields" nillable="true" type="q57:ArrayOfFieldMetadata" />
              <xs:element minOccurs="0" name="CrmActorType" type="q57:CrmActorType" />
              <xs:element minOccurs="0" name="ErpActorType" type="q57:ErpActorType" />
              <xs:element minOccurs="0" name="ErpActorTypes" nillable="true" type="q57:ArrayOfErpActorType" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ErpConnectionData" nillable="true" type="q58:ErpConnectionData" xmlns:q58="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfErpActorType">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ErpActorType" type="q59:ErpActorType" xmlns:q59="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfErpActorType" nillable="true" type="q60:ArrayOfErpActorType" xmlns:q60="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetErpFieldValues">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="CrmActorType" type="q61:CrmActorType" xmlns:q61="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="EntityId" type="xs:int" />
            <xs:element minOccurs="0" name="FieldKeys" nillable="true" type="q62:ArrayOfstring" xmlns:q62="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetErpFieldValuesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q63:ArrayOfstring" xmlns:q63="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFieldsForNewErpActor">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ErpActorType" type="q64:ErpActorType" xmlns:q64="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFieldsForNewErpActorResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q65:ArrayOfFieldMetadata" xmlns:q65="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConnectionListMappings">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConnectionListMappingsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q66:ErpConnectionListMappingContainer" xmlns:q66="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ErpConnectionListMappingContainer">
        <xs:complexContent mixed="false">
          <xs:extension base="q67:Carrier" xmlns:q67="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ErpListItemMappings" nillable="true" type="q67:ArrayOfErpConnectionListMapping" />
              <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
              <xs:element minOccurs="0" name="ErpConnectionName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ErpConnectionListMappingContainer" nillable="true" type="q68:ErpConnectionListMappingContainer" xmlns:q68="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfErpConnectionListMapping">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ErpConnectionListMapping" nillable="true" type="q69:ErpConnectionListMapping" xmlns:q69="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfErpConnectionListMapping" nillable="true" type="q70:ArrayOfErpConnectionListMapping" xmlns:q70="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ErpConnectionListMapping">
        <xs:complexContent mixed="false">
          <xs:extension base="q71:Carrier" xmlns:q71="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="CrmList" nillable="true" type="q71:MDOListItem" />
              <xs:element minOccurs="0" name="ErpListName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ErpCrmListItemMappings" nillable="true" type="q71:ArrayOfErpCrmListItemMapping" />
              <xs:element minOccurs="0" name="ErpActorTypeName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ErpFieldId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ErpConnectionListMapping" nillable="true" type="q72:ErpConnectionListMapping" xmlns:q72="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="MDOListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q73:Carrier" xmlns:q73="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ToolTip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ChildItems" nillable="true" type="q73:ArrayOfMDOListItem" />
              <xs:element minOccurs="0" name="IconHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ColorBlock" type="xs:int" />
              <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StyleHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="MDOListItem" nillable="true" type="q74:MDOListItem" xmlns:q74="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfMDOListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="MDOListItem" nillable="true" type="q75:MDOListItem" xmlns:q75="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfMDOListItem" nillable="true" type="q76:ArrayOfMDOListItem" xmlns:q76="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfErpCrmListItemMapping">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ErpCrmListItemMapping" nillable="true" type="q77:ErpCrmListItemMapping" xmlns:q77="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfErpCrmListItemMapping" nillable="true" type="q78:ArrayOfErpCrmListItemMapping" xmlns:q78="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ErpCrmListItemMapping">
        <xs:complexContent mixed="false">
          <xs:extension base="q79:Carrier" xmlns:q79="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ErpListItemId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ErpListItemName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CrmListItem" nillable="true" type="q79:MDOListItem" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ErpCrmListItemMapping" nillable="true" type="q80:ErpCrmListItemMapping" xmlns:q80="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="SaveConnectionListMappings">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ListMapping" nillable="true" type="q81:ErpConnectionListMappingContainer" xmlns:q81="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveConnectionListMappingsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q82:ErpConnectionListMappingContainer" xmlns:q82="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ConnectActor">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="CrmRecordId" type="xs:int" />
            <xs:element minOccurs="0" name="CrmActorType" type="q83:CrmActorType" xmlns:q83="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="ErpKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ErpActorType" type="q84:ErpActorType" xmlns:q84="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="FieldValues" nillable="true" type="q85:ArrayOfErpSyncFieldValue" xmlns:q85="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfErpSyncFieldValue">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ErpSyncFieldValue" nillable="true" type="q86:ErpSyncFieldValue" xmlns:q86="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfErpSyncFieldValue" nillable="true" type="q87:ArrayOfErpSyncFieldValue" xmlns:q87="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ErpSyncFieldValue">
        <xs:complexContent mixed="false">
          <xs:extension base="q88:Carrier" xmlns:q88="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CrmFieldKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SyncToCrm" type="xs:boolean" />
              <xs:element minOccurs="0" name="SyncToErp" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ErpSyncFieldValue" nillable="true" type="q89:ErpSyncFieldValue" xmlns:q89="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ConnectActorResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="TryConnectActor">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="CrmRecordId" type="xs:int" />
            <xs:element minOccurs="0" name="CrmActorType" type="q90:CrmActorType" xmlns:q90="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="ErpKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ErpActorType" type="q91:ErpActorType" xmlns:q91="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="FieldValues" nillable="true" type="q92:ArrayOfErpSyncFieldValue" xmlns:q92="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TryConnectActorResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFieldValuesFromCrm">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RecordId" type="xs:int" />
            <xs:element minOccurs="0" name="ActorTypeCrm" type="q93:CrmActorType" xmlns:q93="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFieldValuesFromCrmResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q94:ArrayOfErpSyncFieldValue" xmlns:q94="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFieldValuesFromErp">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ActorTypeErp" type="q95:ErpActorType" xmlns:q95="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="ErpKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFieldValuesFromErpResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q96:ArrayOfErpSyncFieldValue" xmlns:q96="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetActorTypeMapping">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ActorType" type="q97:ErpActorType" xmlns:q97="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetActorTypeMappingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q98:ErpSyncActorTypeMapping" xmlns:q98="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ErpSyncActorTypeMapping">
        <xs:complexContent mixed="false">
          <xs:extension base="q99:Carrier" xmlns:q99="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
              <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
              <xs:element minOccurs="0" name="FieldMappings" nillable="true" type="q99:ArrayOfErpSyncFieldMapping" />
              <xs:element minOccurs="0" name="ActorTypeErp" type="q99:ErpActorType" />
              <xs:element minOccurs="0" name="ActorTypeCrm" type="q99:CrmActorType" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ErpSyncActorTypeMapping" nillable="true" type="q100:ErpSyncActorTypeMapping" xmlns:q100="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfErpSyncFieldMapping">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ErpSyncFieldMapping" nillable="true" type="q101:ErpSyncFieldMapping" xmlns:q101="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfErpSyncFieldMapping" nillable="true" type="q102:ArrayOfErpSyncFieldMapping" xmlns:q102="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ErpSyncFieldMapping">
        <xs:complexContent mixed="false">
          <xs:extension base="q103:Carrier" xmlns:q103="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ErpFieldId" type="xs:int" />
              <xs:element minOccurs="0" name="CrmFieldKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CrmDisplayName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CrmDisplayTooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ErpFieldKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FieldType" type="q103:FieldMetadataType" />
              <xs:element minOccurs="0" name="ErpDisplayName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ErpDisplayTooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SyncToCrm" type="xs:boolean" />
              <xs:element minOccurs="0" name="SyncToErp" type="xs:boolean" />
              <xs:element minOccurs="0" name="ShowInGui" type="xs:boolean" />
              <xs:element minOccurs="0" name="ShowInSearch" type="xs:boolean" />
              <xs:element minOccurs="0" name="AlreadyMapped" type="xs:boolean" />
              <xs:element minOccurs="0" name="MissingInERP" type="xs:boolean" />
              <xs:element minOccurs="0" name="MissingInCRM" type="xs:boolean" />
              <xs:element minOccurs="0" name="Access" type="q103:FieldAccess" />
              <xs:element minOccurs="0" name="ListReference" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ErpSyncFieldMapping" nillable="true" type="q104:ErpSyncFieldMapping" xmlns:q104="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="CreateActorLink">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="CrmRecordId" type="xs:int" />
            <xs:element minOccurs="0" name="CrmActorType" type="q105:CrmActorType" xmlns:q105="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="ErpKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ErpActorType" type="q106:ErpActorType" xmlns:q106="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateActorLinkResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="BreakActorLink">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="CrmRecordId" type="xs:int" />
            <xs:element minOccurs="0" name="CrmActorType" type="q107:CrmActorType" xmlns:q107="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="BreakActorLinkResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateErpActorFromCrm">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="CrmEntityId" type="xs:int" />
            <xs:element minOccurs="0" name="ErpActorType" type="q108:ErpActorType" xmlns:q108="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="CrmActorType" type="q109:CrmActorType" xmlns:q109="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="ErpFieldKeyValues" nillable="true" type="q110:StringDictionary" xmlns:q110="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateErpActorFromCrmResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveActorTypeMapping">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Mapping" nillable="true" type="q111:ErpSyncActorTypeMapping" xmlns:q111="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveActorTypeMappingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q112:ErpSyncActorTypeMapping" xmlns:q112="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateArchiveColumnConfig">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ListOwner" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateArchiveColumnConfigResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateConnectionFields">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateConnectionFieldsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCrmActorType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ErpActorType" type="q113:ErpActorType" xmlns:q113="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCrmActorTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="q114:CrmActorType" xmlns:q114="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetErpSyncConnectionSummary">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpSyncConnectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetErpSyncConnectionSummaryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q115:ErpSyncConnectionSummary" xmlns:q115="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ErpSyncConnectionSummary">
        <xs:complexContent mixed="false">
          <xs:extension base="q116:Carrier" xmlns:q116="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayDescription" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Active" type="xs:boolean" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="LastSync" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Actors" nillable="true" type="q116:ArrayOfErpSyncActorSummary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ErpSyncConnectionSummary" nillable="true" type="q117:ErpSyncConnectionSummary" xmlns:q117="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfErpSyncActorSummary">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ErpSyncActorSummary" nillable="true" type="q118:ErpSyncActorSummary" xmlns:q118="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfErpSyncActorSummary" nillable="true" type="q119:ArrayOfErpSyncActorSummary" xmlns:q119="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ErpSyncActorSummary">
        <xs:complexContent mixed="false">
          <xs:extension base="q120:Carrier" xmlns:q120="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ActorType" type="q120:ErpActorType" />
              <xs:element minOccurs="0" name="HasMappings" type="xs:boolean" />
              <xs:element minOccurs="0" name="Defaults" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Mappings" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ErpSyncActorSummary" nillable="true" type="q121:ErpSyncActorSummary" xmlns:q121="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetErpSyncConnectorEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpSyncConnectorEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetErpSyncConnectorEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q122:ErpSyncConnectorEntity" xmlns:q122="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CanDeleteErpSyncConnectorEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpSyncConnectorId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CanDeleteErpSyncConnectorEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="q123:ErpSyncResponseCode" xmlns:q123="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="ErpSyncResponseCode">
        <xs:restriction base="xs:string">
          <xs:enumeration value="NoError" />
          <xs:enumeration value="ErrorConnectorHasConnections" />
          <xs:enumeration value="ErrorNotFound" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ErpSyncResponseCode" nillable="true" type="q124:ErpSyncResponseCode" xmlns:q124="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="TestConnectorUrl">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Url" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TestConnectorUrlResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="q125:ErpSyncResponseCode" xmlns:q125="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDefaultValueInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpSyncDefaultValue" nillable="true" type="q126:ErpSyncDefaultValue" xmlns:q126="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ErpSyncDefaultValue">
        <xs:complexContent mixed="false">
          <xs:extension base="q127:Carrier" xmlns:q127="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ErpFieldId" type="xs:int" />
              <xs:element minOccurs="0" name="DefaultValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="HasFirstSyncDefaultValue" type="xs:boolean" />
              <xs:element minOccurs="0" name="FirstSyncDefaultValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PromptUser" type="xs:boolean" />
              <xs:element minOccurs="0" name="Mandatory" type="xs:boolean" />
              <xs:element minOccurs="0" name="ErpFieldKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FieldType" type="q127:FieldMetadataType" />
              <xs:element minOccurs="0" name="ListName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Access" type="q127:FieldAccess" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ErpSyncDefaultValue" nillable="true" type="q128:ErpSyncDefaultValue" xmlns:q128="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="SaveDefaultValueInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q129:ErpSyncDefaultValue" xmlns:q129="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultValueInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpFieldId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultValueInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q130:ErpSyncDefaultValue" xmlns:q130="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SyncAll">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SyncAllResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q131:PluginResponse" xmlns:q131="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="PluginResponse">
        <xs:complexContent mixed="false">
          <xs:extension base="q132:Carrier" xmlns:q132="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="IsOk" type="xs:boolean" />
              <xs:element minOccurs="0" name="UserExplanation" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TechExplanation" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ErrorCode" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Changes" nillable="true" type="q132:ChangedData" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PluginResponse" nillable="true" type="q133:PluginResponse" xmlns:q133="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ChangedData">
        <xs:complexContent mixed="false">
          <xs:extension base="q134:Carrier" xmlns:q134="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="AddedRecords" nillable="true" type="q134:ArrayOfChangedDataItem" />
              <xs:element minOccurs="0" name="UpdatedRecords" nillable="true" type="q134:ArrayOfChangedDataItem" />
              <xs:element minOccurs="0" name="DeletedRecords" nillable="true" type="q134:ArrayOfChangedDataItem" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ChangedData" nillable="true" type="q135:ChangedData" xmlns:q135="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfChangedDataItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ChangedDataItem" nillable="true" type="q136:ChangedDataItem" xmlns:q136="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfChangedDataItem" nillable="true" type="q137:ArrayOfChangedDataItem" xmlns:q137="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ChangedDataItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q138:Carrier" xmlns:q138="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Tablename" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RecordId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ChangedDataItem" nillable="true" type="q139:ChangedDataItem" xmlns:q139="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ForceSyncAll">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ForceSyncAllResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q140:PluginResponse" xmlns:q140="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ForceResync">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="InternalKeyIds" nillable="true" type="q141:ArrayOfint" xmlns:q141="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ForceResyncResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q142:PluginResponse" xmlns:q142="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ForceResyncNoBlankValues">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="InternalKeyIds" nillable="true" type="q143:ArrayOfint" xmlns:q143="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ForceResyncNoBlankValuesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q144:PluginResponse" xmlns:q144="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ForceResyncBatchTask">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="InternalKeyIds" nillable="true" type="q145:ArrayOfint" xmlns:q145="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ForceResyncBatchTaskResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ForceResyncExternal">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ErpActorType" type="q146:ErpActorType" xmlns:q146="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="ExternalKeys" nillable="true" type="q147:ArrayOfstring" xmlns:q147="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ForceResyncExternalResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q148:PluginResponse" xmlns:q148="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ForceResyncExternalNoBlankValues">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ErpActorType" type="q149:ErpActorType" xmlns:q149="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="ExternalKeys" nillable="true" type="q150:ArrayOfstring" xmlns:q150="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ForceResyncExternalNoBlankValuesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q151:PluginResponse" xmlns:q151="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEngineStatus">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEngineStatusResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q152:ErpSyncEngineStatus" xmlns:q152="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ErpSyncEngineStatus">
        <xs:complexContent mixed="false">
          <xs:extension base="q153:Carrier" xmlns:q153="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="IsRunning" type="xs:boolean" />
              <xs:element minOccurs="0" name="StatusMessage" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Interval" type="ser:duration" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ErpSyncEngineStatus" nillable="true" type="q154:ErpSyncEngineStatus" xmlns:q154="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ChangeEngineStatus">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Run" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeEngineStatusResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q155:ErpSyncEngineStatus" xmlns:q155="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeEngineInterval">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Interval" type="ser:duration" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeEngineIntervalResponse">
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
      <xs:complexType name="ArrayOfstring">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="string" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfstring" nillable="true" type="tns:ArrayOfstring" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="CreateDefaultErpSyncConnectorEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultErpSyncConnectorEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultErpSyncConnectorEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultErpSyncConnectorEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultErpSyncConnectorEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultErpSyncConnectorEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveErpSyncConnectorEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveErpSyncConnectorEntity" />
  </wsdl:message>
  <wsdl:message name="SaveErpSyncConnectorEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveErpSyncConnectorEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveErpSyncConnectorEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveErpSyncConnectorEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteErpSyncConnectorEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteErpSyncConnectorEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteErpSyncConnectorEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteErpSyncConnectorEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteErpSyncConnectorEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteErpSyncConnectorEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectionRequest">
    <wsdl:part name="parameters" element="tns:GetConnection" />
  </wsdl:message>
  <wsdl:message name="GetConnectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectionResponse">
    <wsdl:part name="parameters" element="tns:GetConnectionResponse" />
  </wsdl:message>
  <wsdl:message name="GetConnectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveConnectionRequest">
    <wsdl:part name="parameters" element="tns:SaveConnection" />
  </wsdl:message>
  <wsdl:message name="SaveConnectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveConnectionResponse">
    <wsdl:part name="parameters" element="tns:SaveConnectionResponse" />
  </wsdl:message>
  <wsdl:message name="SaveConnectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteConnectionRequest">
    <wsdl:part name="parameters" element="tns:DeleteConnection" />
  </wsdl:message>
  <wsdl:message name="DeleteConnectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteConnectionResponse">
    <wsdl:part name="parameters" element="tns:DeleteConnectionResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteConnectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConfigurationFieldsRequest">
    <wsdl:part name="parameters" element="tns:GetConfigurationFields" />
  </wsdl:message>
  <wsdl:message name="GetConfigurationFieldsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConfigurationFieldsResponse">
    <wsdl:part name="parameters" element="tns:GetConfigurationFieldsResponse" />
  </wsdl:message>
  <wsdl:message name="GetConfigurationFieldsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetErpConnectionConfigFieldsRequest">
    <wsdl:part name="parameters" element="tns:GetErpConnectionConfigFields" />
  </wsdl:message>
  <wsdl:message name="GetErpConnectionConfigFieldsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetErpConnectionConfigFieldsResponse">
    <wsdl:part name="parameters" element="tns:GetErpConnectionConfigFieldsResponse" />
  </wsdl:message>
  <wsdl:message name="GetErpConnectionConfigFieldsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleErpConnectionActiveRequest">
    <wsdl:part name="parameters" element="tns:ToggleErpConnectionActive" />
  </wsdl:message>
  <wsdl:message name="ToggleErpConnectionActiveRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleErpConnectionActiveResponse">
    <wsdl:part name="parameters" element="tns:ToggleErpConnectionActiveResponse" />
  </wsdl:message>
  <wsdl:message name="ToggleErpConnectionActiveResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TestConnectionByIdRequest">
    <wsdl:part name="parameters" element="tns:TestConnectionById" />
  </wsdl:message>
  <wsdl:message name="TestConnectionByIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TestConnectionByIdResponse">
    <wsdl:part name="parameters" element="tns:TestConnectionByIdResponse" />
  </wsdl:message>
  <wsdl:message name="TestConnectionByIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TestConnectionByConfigRequest">
    <wsdl:part name="parameters" element="tns:TestConnectionByConfig" />
  </wsdl:message>
  <wsdl:message name="TestConnectionByConfigRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TestConnectionByConfigResponse">
    <wsdl:part name="parameters" element="tns:TestConnectionByConfigResponse" />
  </wsdl:message>
  <wsdl:message name="TestConnectionByConfigResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveErpConnectionSyncPrioritiesRequest">
    <wsdl:part name="parameters" element="tns:SaveErpConnectionSyncPriorities" />
  </wsdl:message>
  <wsdl:message name="SaveErpConnectionSyncPrioritiesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveErpConnectionSyncPrioritiesResponse">
    <wsdl:part name="parameters" element="tns:SaveErpConnectionSyncPrioritiesResponse" />
  </wsdl:message>
  <wsdl:message name="SaveErpConnectionSyncPrioritiesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveErpFieldItemRequest">
    <wsdl:part name="parameters" element="tns:MoveErpFieldItem" />
  </wsdl:message>
  <wsdl:message name="MoveErpFieldItemRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveErpFieldItemResponse">
    <wsdl:part name="parameters" element="tns:MoveErpFieldItemResponse" />
  </wsdl:message>
  <wsdl:message name="MoveErpFieldItemResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SupportsAdvancedSearchRequest">
    <wsdl:part name="parameters" element="tns:SupportsAdvancedSearch" />
  </wsdl:message>
  <wsdl:message name="SupportsAdvancedSearchRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SupportsAdvancedSearchResponse">
    <wsdl:part name="parameters" element="tns:SupportsAdvancedSearchResponse" />
  </wsdl:message>
  <wsdl:message name="SupportsAdvancedSearchResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectionsAndDisplayFieldsRequest">
    <wsdl:part name="parameters" element="tns:GetConnectionsAndDisplayFields" />
  </wsdl:message>
  <wsdl:message name="GetConnectionsAndDisplayFieldsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectionsAndDisplayFieldsResponse">
    <wsdl:part name="parameters" element="tns:GetConnectionsAndDisplayFieldsResponse" />
  </wsdl:message>
  <wsdl:message name="GetConnectionsAndDisplayFieldsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetErpFieldValuesRequest">
    <wsdl:part name="parameters" element="tns:GetErpFieldValues" />
  </wsdl:message>
  <wsdl:message name="GetErpFieldValuesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetErpFieldValuesResponse">
    <wsdl:part name="parameters" element="tns:GetErpFieldValuesResponse" />
  </wsdl:message>
  <wsdl:message name="GetErpFieldValuesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFieldsForNewErpActorRequest">
    <wsdl:part name="parameters" element="tns:GetFieldsForNewErpActor" />
  </wsdl:message>
  <wsdl:message name="GetFieldsForNewErpActorRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFieldsForNewErpActorResponse">
    <wsdl:part name="parameters" element="tns:GetFieldsForNewErpActorResponse" />
  </wsdl:message>
  <wsdl:message name="GetFieldsForNewErpActorResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectionListMappingsRequest">
    <wsdl:part name="parameters" element="tns:GetConnectionListMappings" />
  </wsdl:message>
  <wsdl:message name="GetConnectionListMappingsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectionListMappingsResponse">
    <wsdl:part name="parameters" element="tns:GetConnectionListMappingsResponse" />
  </wsdl:message>
  <wsdl:message name="GetConnectionListMappingsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveConnectionListMappingsRequest">
    <wsdl:part name="parameters" element="tns:SaveConnectionListMappings" />
  </wsdl:message>
  <wsdl:message name="SaveConnectionListMappingsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveConnectionListMappingsResponse">
    <wsdl:part name="parameters" element="tns:SaveConnectionListMappingsResponse" />
  </wsdl:message>
  <wsdl:message name="SaveConnectionListMappingsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ConnectActorRequest">
    <wsdl:part name="parameters" element="tns:ConnectActor" />
  </wsdl:message>
  <wsdl:message name="ConnectActorRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ConnectActorResponse">
    <wsdl:part name="parameters" element="tns:ConnectActorResponse" />
  </wsdl:message>
  <wsdl:message name="ConnectActorResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TryConnectActorRequest">
    <wsdl:part name="parameters" element="tns:TryConnectActor" />
  </wsdl:message>
  <wsdl:message name="TryConnectActorRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TryConnectActorResponse">
    <wsdl:part name="parameters" element="tns:TryConnectActorResponse" />
  </wsdl:message>
  <wsdl:message name="TryConnectActorResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFieldValuesFromCrmRequest">
    <wsdl:part name="parameters" element="tns:GetFieldValuesFromCrm" />
  </wsdl:message>
  <wsdl:message name="GetFieldValuesFromCrmRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFieldValuesFromCrmResponse">
    <wsdl:part name="parameters" element="tns:GetFieldValuesFromCrmResponse" />
  </wsdl:message>
  <wsdl:message name="GetFieldValuesFromCrmResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFieldValuesFromErpRequest">
    <wsdl:part name="parameters" element="tns:GetFieldValuesFromErp" />
  </wsdl:message>
  <wsdl:message name="GetFieldValuesFromErpRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFieldValuesFromErpResponse">
    <wsdl:part name="parameters" element="tns:GetFieldValuesFromErpResponse" />
  </wsdl:message>
  <wsdl:message name="GetFieldValuesFromErpResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetActorTypeMappingRequest">
    <wsdl:part name="parameters" element="tns:GetActorTypeMapping" />
  </wsdl:message>
  <wsdl:message name="GetActorTypeMappingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetActorTypeMappingResponse">
    <wsdl:part name="parameters" element="tns:GetActorTypeMappingResponse" />
  </wsdl:message>
  <wsdl:message name="GetActorTypeMappingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateActorLinkRequest">
    <wsdl:part name="parameters" element="tns:CreateActorLink" />
  </wsdl:message>
  <wsdl:message name="CreateActorLinkRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateActorLinkResponse">
    <wsdl:part name="parameters" element="tns:CreateActorLinkResponse" />
  </wsdl:message>
  <wsdl:message name="CreateActorLinkResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="BreakActorLinkRequest">
    <wsdl:part name="parameters" element="tns:BreakActorLink" />
  </wsdl:message>
  <wsdl:message name="BreakActorLinkRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="BreakActorLinkResponse">
    <wsdl:part name="parameters" element="tns:BreakActorLinkResponse" />
  </wsdl:message>
  <wsdl:message name="BreakActorLinkResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateErpActorFromCrmRequest">
    <wsdl:part name="parameters" element="tns:CreateErpActorFromCrm" />
  </wsdl:message>
  <wsdl:message name="CreateErpActorFromCrmRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateErpActorFromCrmResponse">
    <wsdl:part name="parameters" element="tns:CreateErpActorFromCrmResponse" />
  </wsdl:message>
  <wsdl:message name="CreateErpActorFromCrmResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveActorTypeMappingRequest">
    <wsdl:part name="parameters" element="tns:SaveActorTypeMapping" />
  </wsdl:message>
  <wsdl:message name="SaveActorTypeMappingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveActorTypeMappingResponse">
    <wsdl:part name="parameters" element="tns:SaveActorTypeMappingResponse" />
  </wsdl:message>
  <wsdl:message name="SaveActorTypeMappingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateArchiveColumnConfigRequest">
    <wsdl:part name="parameters" element="tns:ValidateArchiveColumnConfig" />
  </wsdl:message>
  <wsdl:message name="ValidateArchiveColumnConfigRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateArchiveColumnConfigResponse">
    <wsdl:part name="parameters" element="tns:ValidateArchiveColumnConfigResponse" />
  </wsdl:message>
  <wsdl:message name="ValidateArchiveColumnConfigResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateConnectionFieldsRequest">
    <wsdl:part name="parameters" element="tns:UpdateConnectionFields" />
  </wsdl:message>
  <wsdl:message name="UpdateConnectionFieldsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateConnectionFieldsResponse">
    <wsdl:part name="parameters" element="tns:UpdateConnectionFieldsResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateConnectionFieldsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCrmActorTypeRequest">
    <wsdl:part name="parameters" element="tns:GetCrmActorType" />
  </wsdl:message>
  <wsdl:message name="GetCrmActorTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCrmActorTypeResponse">
    <wsdl:part name="parameters" element="tns:GetCrmActorTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetCrmActorTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetErpSyncConnectionSummaryRequest">
    <wsdl:part name="parameters" element="tns:GetErpSyncConnectionSummary" />
  </wsdl:message>
  <wsdl:message name="GetErpSyncConnectionSummaryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetErpSyncConnectionSummaryResponse">
    <wsdl:part name="parameters" element="tns:GetErpSyncConnectionSummaryResponse" />
  </wsdl:message>
  <wsdl:message name="GetErpSyncConnectionSummaryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetErpSyncConnectorEntityRequest">
    <wsdl:part name="parameters" element="tns:GetErpSyncConnectorEntity" />
  </wsdl:message>
  <wsdl:message name="GetErpSyncConnectorEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetErpSyncConnectorEntityResponse">
    <wsdl:part name="parameters" element="tns:GetErpSyncConnectorEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetErpSyncConnectorEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CanDeleteErpSyncConnectorEntityRequest">
    <wsdl:part name="parameters" element="tns:CanDeleteErpSyncConnectorEntity" />
  </wsdl:message>
  <wsdl:message name="CanDeleteErpSyncConnectorEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CanDeleteErpSyncConnectorEntityResponse">
    <wsdl:part name="parameters" element="tns:CanDeleteErpSyncConnectorEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CanDeleteErpSyncConnectorEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TestConnectorUrlRequest">
    <wsdl:part name="parameters" element="tns:TestConnectorUrl" />
  </wsdl:message>
  <wsdl:message name="TestConnectorUrlRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TestConnectorUrlResponse">
    <wsdl:part name="parameters" element="tns:TestConnectorUrlResponse" />
  </wsdl:message>
  <wsdl:message name="TestConnectorUrlResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDefaultValueInfoRequest">
    <wsdl:part name="parameters" element="tns:SaveDefaultValueInfo" />
  </wsdl:message>
  <wsdl:message name="SaveDefaultValueInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDefaultValueInfoResponse">
    <wsdl:part name="parameters" element="tns:SaveDefaultValueInfoResponse" />
  </wsdl:message>
  <wsdl:message name="SaveDefaultValueInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultValueInfoRequest">
    <wsdl:part name="parameters" element="tns:GetDefaultValueInfo" />
  </wsdl:message>
  <wsdl:message name="GetDefaultValueInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultValueInfoResponse">
    <wsdl:part name="parameters" element="tns:GetDefaultValueInfoResponse" />
  </wsdl:message>
  <wsdl:message name="GetDefaultValueInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SyncAllRequest">
    <wsdl:part name="parameters" element="tns:SyncAll" />
  </wsdl:message>
  <wsdl:message name="SyncAllRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SyncAllResponse">
    <wsdl:part name="parameters" element="tns:SyncAllResponse" />
  </wsdl:message>
  <wsdl:message name="SyncAllResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ForceSyncAllRequest">
    <wsdl:part name="parameters" element="tns:ForceSyncAll" />
  </wsdl:message>
  <wsdl:message name="ForceSyncAllRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ForceSyncAllResponse">
    <wsdl:part name="parameters" element="tns:ForceSyncAllResponse" />
  </wsdl:message>
  <wsdl:message name="ForceSyncAllResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ForceResyncRequest">
    <wsdl:part name="parameters" element="tns:ForceResync" />
  </wsdl:message>
  <wsdl:message name="ForceResyncRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ForceResyncResponse">
    <wsdl:part name="parameters" element="tns:ForceResyncResponse" />
  </wsdl:message>
  <wsdl:message name="ForceResyncResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ForceResyncNoBlankValuesRequest">
    <wsdl:part name="parameters" element="tns:ForceResyncNoBlankValues" />
  </wsdl:message>
  <wsdl:message name="ForceResyncNoBlankValuesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ForceResyncNoBlankValuesResponse">
    <wsdl:part name="parameters" element="tns:ForceResyncNoBlankValuesResponse" />
  </wsdl:message>
  <wsdl:message name="ForceResyncNoBlankValuesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ForceResyncBatchTaskRequest">
    <wsdl:part name="parameters" element="tns:ForceResyncBatchTask" />
  </wsdl:message>
  <wsdl:message name="ForceResyncBatchTaskRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ForceResyncBatchTaskResponse">
    <wsdl:part name="parameters" element="tns:ForceResyncBatchTaskResponse" />
  </wsdl:message>
  <wsdl:message name="ForceResyncBatchTaskResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ForceResyncExternalRequest">
    <wsdl:part name="parameters" element="tns:ForceResyncExternal" />
  </wsdl:message>
  <wsdl:message name="ForceResyncExternalRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ForceResyncExternalResponse">
    <wsdl:part name="parameters" element="tns:ForceResyncExternalResponse" />
  </wsdl:message>
  <wsdl:message name="ForceResyncExternalResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ForceResyncExternalNoBlankValuesRequest">
    <wsdl:part name="parameters" element="tns:ForceResyncExternalNoBlankValues" />
  </wsdl:message>
  <wsdl:message name="ForceResyncExternalNoBlankValuesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ForceResyncExternalNoBlankValuesResponse">
    <wsdl:part name="parameters" element="tns:ForceResyncExternalNoBlankValuesResponse" />
  </wsdl:message>
  <wsdl:message name="ForceResyncExternalNoBlankValuesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEngineStatusRequest">
    <wsdl:part name="parameters" element="tns:GetEngineStatus" />
  </wsdl:message>
  <wsdl:message name="GetEngineStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEngineStatusResponse">
    <wsdl:part name="parameters" element="tns:GetEngineStatusResponse" />
  </wsdl:message>
  <wsdl:message name="GetEngineStatusResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeEngineStatusRequest">
    <wsdl:part name="parameters" element="tns:ChangeEngineStatus" />
  </wsdl:message>
  <wsdl:message name="ChangeEngineStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeEngineStatusResponse">
    <wsdl:part name="parameters" element="tns:ChangeEngineStatusResponse" />
  </wsdl:message>
  <wsdl:message name="ChangeEngineStatusResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeEngineIntervalRequest">
    <wsdl:part name="parameters" element="tns:ChangeEngineInterval" />
  </wsdl:message>
  <wsdl:message name="ChangeEngineIntervalRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeEngineIntervalResponse">
    <wsdl:part name="parameters" element="tns:ChangeEngineIntervalResponse" />
  </wsdl:message>
  <wsdl:message name="ChangeEngineIntervalResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="ErpSync">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for ErpSync</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultErpSyncConnectorEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new ErpSyncConnectorEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/CreateDefaultErpSyncConnectorEntity" name="CreateDefaultErpSyncConnectorEntityRequest" message="tns:CreateDefaultErpSyncConnectorEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/CreateDefaultErpSyncConnectorEntityResponse" name="CreateDefaultErpSyncConnectorEntityResponse" message="tns:CreateDefaultErpSyncConnectorEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveErpSyncConnectorEntity">
      <wsdl:documentation>
        <summary>Updates the existing ErpSyncConnectorEntity or creates a new ErpSyncConnectorEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SaveErpSyncConnectorEntity" name="SaveErpSyncConnectorEntityRequest" message="tns:SaveErpSyncConnectorEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SaveErpSyncConnectorEntityResponse" name="SaveErpSyncConnectorEntityResponse" message="tns:SaveErpSyncConnectorEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteErpSyncConnectorEntity">
      <wsdl:documentation>
        <summary>Deletes the ErpSyncConnectorEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/DeleteErpSyncConnectorEntity" name="DeleteErpSyncConnectorEntityRequest" message="tns:DeleteErpSyncConnectorEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/DeleteErpSyncConnectorEntityResponse" name="DeleteErpSyncConnectorEntityResponse" message="tns:DeleteErpSyncConnectorEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConnection">
      <wsdl:documentation>
        <summary>Returns the specified connection.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetConnection" name="GetConnectionRequest" message="tns:GetConnectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetConnectionResponse" name="GetConnectionResponse" message="tns:GetConnectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveConnection">
      <wsdl:documentation>
        <summary>Saves a connection to the database.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SaveConnection" name="SaveConnectionRequest" message="tns:SaveConnectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SaveConnectionResponse" name="SaveConnectionResponse" message="tns:SaveConnectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteConnection">
      <wsdl:documentation>
        <summary>Deletes a connection from the database.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/DeleteConnection" name="DeleteConnectionRequest" message="tns:DeleteConnectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/DeleteConnectionResponse" name="DeleteConnectionResponse" message="tns:DeleteConnectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConfigurationFields">
      <wsdl:documentation>
        <summary>Returns all fields needed to connect to the given connector</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetConfigurationFields" name="GetConfigurationFieldsRequest" message="tns:GetConfigurationFieldsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetConfigurationFieldsResponse" name="GetConfigurationFieldsResponse" message="tns:GetConfigurationFieldsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetErpConnectionConfigFields">
      <wsdl:documentation>
        <summary>Returns the config fields for the connection.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetErpConnectionConfigFields" name="GetErpConnectionConfigFieldsRequest" message="tns:GetErpConnectionConfigFieldsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetErpConnectionConfigFieldsResponse" name="GetErpConnectionConfigFieldsResponse" message="tns:GetErpConnectionConfigFieldsResponse" />
    </wsdl:operation>
    <wsdl:operation name="ToggleErpConnectionActive">
      <wsdl:documentation>
        <summary>Toggles the Active state of the connection</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ToggleErpConnectionActive" name="ToggleErpConnectionActiveRequest" message="tns:ToggleErpConnectionActiveRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ToggleErpConnectionActiveResponse" name="ToggleErpConnectionActiveResponse" message="tns:ToggleErpConnectionActiveResponse" />
    </wsdl:operation>
    <wsdl:operation name="TestConnectionById">
      <wsdl:documentation>
        <summary>Tests to see if we can establish a connection with the given config fields</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/TestConnectionById" name="TestConnectionByIdRequest" message="tns:TestConnectionByIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/TestConnectionByIdResponse" name="TestConnectionByIdResponse" message="tns:TestConnectionByIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="TestConnectionByConfig">
      <wsdl:documentation>
        <summary>Tests to see if the given connection has a valid connection to its connector</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/TestConnectionByConfig" name="TestConnectionByConfigRequest" message="tns:TestConnectionByConfigRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/TestConnectionByConfigResponse" name="TestConnectionByConfigResponse" message="tns:TestConnectionByConfigResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveErpConnectionSyncPriorities">
      <wsdl:documentation>
        <summary>Takes an array of the ErpConnection ids and saves these as ordered sync priorities</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SaveErpConnectionSyncPriorities" name="SaveErpConnectionSyncPrioritiesRequest" message="tns:SaveErpConnectionSyncPrioritiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SaveErpConnectionSyncPrioritiesResponse" name="SaveErpConnectionSyncPrioritiesResponse" message="tns:SaveErpConnectionSyncPrioritiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="MoveErpFieldItem">
      <wsdl:documentation>
        <summary>Moves the rank of the erp field up or down</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/MoveErpFieldItem" name="MoveErpFieldItemRequest" message="tns:MoveErpFieldItemRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/MoveErpFieldItemResponse" name="MoveErpFieldItemResponse" message="tns:MoveErpFieldItemResponse" />
    </wsdl:operation>
    <wsdl:operation name="SupportsAdvancedSearch">
      <wsdl:documentation>
        <summary>Indicates if the connection supports advanced search for the given erp actor</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SupportsAdvancedSearch" name="SupportsAdvancedSearchRequest" message="tns:SupportsAdvancedSearchRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SupportsAdvancedSearchResponse" name="SupportsAdvancedSearchResponse" message="tns:SupportsAdvancedSearchResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConnectionsAndDisplayFields">
      <wsdl:documentation>
        <summary>Get all connection statuses and fields for a given entity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetConnectionsAndDisplayFields" name="GetConnectionsAndDisplayFieldsRequest" message="tns:GetConnectionsAndDisplayFieldsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetConnectionsAndDisplayFieldsResponse" name="GetConnectionsAndDisplayFieldsResponse" message="tns:GetConnectionsAndDisplayFieldsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetErpFieldValues">
      <wsdl:documentation>
        <summary>Get the values for the specified fields from the ERP connection</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetErpFieldValues" name="GetErpFieldValuesRequest" message="tns:GetErpFieldValuesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetErpFieldValuesResponse" name="GetErpFieldValuesResponse" message="tns:GetErpFieldValuesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFieldsForNewErpActor">
      <wsdl:documentation>
        <summary>Get the fields that must be filled out when creating a new ERP actor</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetFieldsForNewErpActor" name="GetFieldsForNewErpActorRequest" message="tns:GetFieldsForNewErpActorRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetFieldsForNewErpActorResponse" name="GetFieldsForNewErpActorResponse" message="tns:GetFieldsForNewErpActorResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConnectionListMappings">
      <wsdl:documentation>
        <summary>Returns the listmappings for the specified connection.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetConnectionListMappings" name="GetConnectionListMappingsRequest" message="tns:GetConnectionListMappingsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetConnectionListMappingsResponse" name="GetConnectionListMappingsResponse" message="tns:GetConnectionListMappingsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveConnectionListMappings">
      <wsdl:documentation>
        <summary>Saves a connection to the database.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SaveConnectionListMappings" name="SaveConnectionListMappingsRequest" message="tns:SaveConnectionListMappingsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SaveConnectionListMappingsResponse" name="SaveConnectionListMappingsResponse" message="tns:SaveConnectionListMappingsResponse" />
    </wsdl:operation>
    <wsdl:operation name="ConnectActor">
      <wsdl:documentation>
        <summary>Create a link between Erp and Crm and set default values</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ConnectActor" name="ConnectActorRequest" message="tns:ConnectActorRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ConnectActorResponse" name="ConnectActorResponse" message="tns:ConnectActorResponse" />
    </wsdl:operation>
    <wsdl:operation name="TryConnectActor">
      <wsdl:documentation>
        <summary>Create a link between Erp and Crm and set default values</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/TryConnectActor" name="TryConnectActorRequest" message="tns:TryConnectActorRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/TryConnectActorResponse" name="TryConnectActorResponse" message="tns:TryConnectActorResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFieldValuesFromCrm">
      <wsdl:documentation>
        <summary>Get Crm Field values</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetFieldValuesFromCrm" name="GetFieldValuesFromCrmRequest" message="tns:GetFieldValuesFromCrmRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetFieldValuesFromCrmResponse" name="GetFieldValuesFromCrmResponse" message="tns:GetFieldValuesFromCrmResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFieldValuesFromErp">
      <wsdl:documentation>
        <summary>Get Erp Field values</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetFieldValuesFromErp" name="GetFieldValuesFromErpRequest" message="tns:GetFieldValuesFromErpRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetFieldValuesFromErpResponse" name="GetFieldValuesFromErpResponse" message="tns:GetFieldValuesFromErpResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetActorTypeMapping">
      <wsdl:documentation>
        <summary>Get the current mappings for one connection/actor; connection+actor type = unique key</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetActorTypeMapping" name="GetActorTypeMappingRequest" message="tns:GetActorTypeMappingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetActorTypeMappingResponse" name="GetActorTypeMappingResponse" message="tns:GetActorTypeMappingResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateActorLink">
      <wsdl:documentation>
        <summary>Link a crm entity to an erp entity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/CreateActorLink" name="CreateActorLinkRequest" message="tns:CreateActorLinkRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/CreateActorLinkResponse" name="CreateActorLinkResponse" message="tns:CreateActorLinkResponse" />
    </wsdl:operation>
    <wsdl:operation name="BreakActorLink">
      <wsdl:documentation>
        <summary>Remove the link between a CRM entity and an ERP entity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/BreakActorLink" name="BreakActorLinkRequest" message="tns:BreakActorLinkRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/BreakActorLinkResponse" name="BreakActorLinkResponse" message="tns:BreakActorLinkResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateErpActorFromCrm">
      <wsdl:documentation>
        <summary>Create ErpActor from crm entity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/CreateErpActorFromCrm" name="CreateErpActorFromCrmRequest" message="tns:CreateErpActorFromCrmRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/CreateErpActorFromCrmResponse" name="CreateErpActorFromCrmResponse" message="tns:CreateErpActorFromCrmResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveActorTypeMapping">
      <wsdl:documentation>
        <summary>Save mappings for a connection/actor</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SaveActorTypeMapping" name="SaveActorTypeMappingRequest" message="tns:SaveActorTypeMappingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SaveActorTypeMappingResponse" name="SaveActorTypeMappingResponse" message="tns:SaveActorTypeMappingResponse" />
    </wsdl:operation>
    <wsdl:operation name="ValidateArchiveColumnConfig">
      <wsdl:documentation>
        <summary>Clear field info from table SUPERLISTCOLUMNSIZE if field mapping changed on given connection</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ValidateArchiveColumnConfig" name="ValidateArchiveColumnConfigRequest" message="tns:ValidateArchiveColumnConfigRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ValidateArchiveColumnConfigResponse" name="ValidateArchiveColumnConfigResponse" message="tns:ValidateArchiveColumnConfigResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateConnectionFields">
      <wsdl:documentation>
        <summary>Gets all supported actor types, and all fields for each actor type, and save this state to the CRM database</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/UpdateConnectionFields" name="UpdateConnectionFieldsRequest" message="tns:UpdateConnectionFieldsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/UpdateConnectionFieldsResponse" name="UpdateConnectionFieldsResponse" message="tns:UpdateConnectionFieldsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCrmActorType">
      <wsdl:documentation>
        <summary>Retrieves the CrmActorType that are mapped to a specific ErpActorType for this connection</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetCrmActorType" name="GetCrmActorTypeRequest" message="tns:GetCrmActorTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetCrmActorTypeResponse" name="GetCrmActorTypeResponse" message="tns:GetCrmActorTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetErpSyncConnectionSummary">
      <wsdl:documentation>
        <summary>Get a summary of the current ErpSync configuration/setup</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetErpSyncConnectionSummary" name="GetErpSyncConnectionSummaryRequest" message="tns:GetErpSyncConnectionSummaryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetErpSyncConnectionSummaryResponse" name="GetErpSyncConnectionSummaryResponse" message="tns:GetErpSyncConnectionSummaryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetErpSyncConnectorEntity">
      <wsdl:documentation>
        <summary>Gets a ErpSyncConnectorEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetErpSyncConnectorEntity" name="GetErpSyncConnectorEntityRequest" message="tns:GetErpSyncConnectorEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetErpSyncConnectorEntityResponse" name="GetErpSyncConnectorEntityResponse" message="tns:GetErpSyncConnectorEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CanDeleteErpSyncConnectorEntity">
      <wsdl:documentation>
        <summary>Can we delete the connector?</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/CanDeleteErpSyncConnectorEntity" name="CanDeleteErpSyncConnectorEntityRequest" message="tns:CanDeleteErpSyncConnectorEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/CanDeleteErpSyncConnectorEntityResponse" name="CanDeleteErpSyncConnectorEntityResponse" message="tns:CanDeleteErpSyncConnectorEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="TestConnectorUrl">
      <wsdl:documentation>
        <summary>Test if connector urls anwers</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/TestConnectorUrl" name="TestConnectorUrlRequest" message="tns:TestConnectorUrlRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/TestConnectorUrlResponse" name="TestConnectorUrlResponse" message="tns:TestConnectorUrlResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveDefaultValueInfo">
      <wsdl:documentation>
        <summary>Save information about a default value for an ERP field</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SaveDefaultValueInfo" name="SaveDefaultValueInfoRequest" message="tns:SaveDefaultValueInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SaveDefaultValueInfoResponse" name="SaveDefaultValueInfoResponse" message="tns:SaveDefaultValueInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDefaultValueInfo">
      <wsdl:documentation>
        <summary>Get information about default value for an ERP field</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetDefaultValueInfo" name="GetDefaultValueInfoRequest" message="tns:GetDefaultValueInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetDefaultValueInfoResponse" name="GetDefaultValueInfoResponse" message="tns:GetDefaultValueInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="SyncAll">
      <wsdl:documentation>
        <summary>Sync all active connections</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SyncAll" name="SyncAllRequest" message="tns:SyncAllRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SyncAllResponse" name="SyncAllResponse" message="tns:SyncAllResponse" />
    </wsdl:operation>
    <wsdl:operation name="ForceSyncAll">
      <wsdl:documentation>
        <summary>Sync all active connections even when automatic sync is off</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ForceSyncAll" name="ForceSyncAllRequest" message="tns:ForceSyncAllRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ForceSyncAllResponse" name="ForceSyncAllResponse" message="tns:ForceSyncAllResponse" />
    </wsdl:operation>
    <wsdl:operation name="ForceResync">
      <wsdl:documentation>
        <summary>Force resync from CRM or given Erp connection to all other connections</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ForceResync" name="ForceResyncRequest" message="tns:ForceResyncRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ForceResyncResponse" name="ForceResyncResponse" message="tns:ForceResyncResponse" />
    </wsdl:operation>
    <wsdl:operation name="ForceResyncNoBlankValues">
      <wsdl:documentation>
        <summary>Force resync from CRM or given Erp connection to all other connections and tell the sync that you don't want blank values to overwrite non-blank values. Useful on import.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ForceResyncNoBlankValues" name="ForceResyncNoBlankValuesRequest" message="tns:ForceResyncNoBlankValuesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ForceResyncNoBlankValuesResponse" name="ForceResyncNoBlankValuesResponse" message="tns:ForceResyncNoBlankValuesResponse" />
    </wsdl:operation>
    <wsdl:operation name="ForceResyncBatchTask">
      <wsdl:documentation>
        <summary>Start batch task to force resync from CRM or given Erp connection to all other connections</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ForceResyncBatchTask" name="ForceResyncBatchTaskRequest" message="tns:ForceResyncBatchTaskRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ForceResyncBatchTaskResponse" name="ForceResyncBatchTaskResponse" message="tns:ForceResyncBatchTaskResponse" />
    </wsdl:operation>
    <wsdl:operation name="ForceResyncExternal">
      <wsdl:documentation>
        <summary>Force resync from CRM or given Erp connection to all other connections, using external keys</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ForceResyncExternal" name="ForceResyncExternalRequest" message="tns:ForceResyncExternalRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ForceResyncExternalResponse" name="ForceResyncExternalResponse" message="tns:ForceResyncExternalResponse" />
    </wsdl:operation>
    <wsdl:operation name="ForceResyncExternalNoBlankValues">
      <wsdl:documentation>
        <summary>Force resync from CRM or given Erp connection to all other connections, using external keys, and tell the sync that you don't want blank values to overwrite non-blank values. Useful on import.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ForceResyncExternalNoBlankValues" name="ForceResyncExternalNoBlankValuesRequest" message="tns:ForceResyncExternalNoBlankValuesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ForceResyncExternalNoBlankValuesResponse" name="ForceResyncExternalNoBlankValuesResponse" message="tns:ForceResyncExternalNoBlankValuesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEngineStatus">
      <wsdl:documentation>
        <summary>Get the current status of the Sync engine</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetEngineStatus" name="GetEngineStatusRequest" message="tns:GetEngineStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetEngineStatusResponse" name="GetEngineStatusResponse" message="tns:GetEngineStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChangeEngineStatus">
      <wsdl:documentation>
        <summary>Change the current running/stopped status of the Sync engine</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ChangeEngineStatus" name="ChangeEngineStatusRequest" message="tns:ChangeEngineStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ChangeEngineStatusResponse" name="ChangeEngineStatusResponse" message="tns:ChangeEngineStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChangeEngineInterval">
      <wsdl:documentation>
        <summary>Change the interval for each run of the Sync Engine</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ChangeEngineInterval" name="ChangeEngineIntervalRequest" message="tns:ChangeEngineIntervalRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ChangeEngineIntervalResponse" name="ChangeEngineIntervalResponse" message="tns:ChangeEngineIntervalResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_ErpSync" type="tns:ErpSync">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultErpSyncConnectorEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/CreateDefaultErpSyncConnectorEntity" style="document" />
      <wsdl:input name="CreateDefaultErpSyncConnectorEntityRequest">
        <soap:header message="tns:CreateDefaultErpSyncConnectorEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultErpSyncConnectorEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultErpSyncConnectorEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultErpSyncConnectorEntityResponse">
        <soap:header message="tns:CreateDefaultErpSyncConnectorEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultErpSyncConnectorEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultErpSyncConnectorEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultErpSyncConnectorEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveErpSyncConnectorEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SaveErpSyncConnectorEntity" style="document" />
      <wsdl:input name="SaveErpSyncConnectorEntityRequest">
        <soap:header message="tns:SaveErpSyncConnectorEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveErpSyncConnectorEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveErpSyncConnectorEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveErpSyncConnectorEntityResponse">
        <soap:header message="tns:SaveErpSyncConnectorEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveErpSyncConnectorEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveErpSyncConnectorEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveErpSyncConnectorEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteErpSyncConnectorEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/DeleteErpSyncConnectorEntity" style="document" />
      <wsdl:input name="DeleteErpSyncConnectorEntityRequest">
        <soap:header message="tns:DeleteErpSyncConnectorEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteErpSyncConnectorEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteErpSyncConnectorEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteErpSyncConnectorEntityResponse">
        <soap:header message="tns:DeleteErpSyncConnectorEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteErpSyncConnectorEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteErpSyncConnectorEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteErpSyncConnectorEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConnection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetConnection" style="document" />
      <wsdl:input name="GetConnectionRequest">
        <soap:header message="tns:GetConnectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConnectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConnectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConnectionResponse">
        <soap:header message="tns:GetConnectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConnectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConnectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConnectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveConnection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SaveConnection" style="document" />
      <wsdl:input name="SaveConnectionRequest">
        <soap:header message="tns:SaveConnectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveConnectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveConnectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveConnectionResponse">
        <soap:header message="tns:SaveConnectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveConnectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveConnectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveConnectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteConnection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/DeleteConnection" style="document" />
      <wsdl:input name="DeleteConnectionRequest">
        <soap:header message="tns:DeleteConnectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteConnectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteConnectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteConnectionResponse">
        <soap:header message="tns:DeleteConnectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteConnectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteConnectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteConnectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConfigurationFields">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetConfigurationFields" style="document" />
      <wsdl:input name="GetConfigurationFieldsRequest">
        <soap:header message="tns:GetConfigurationFieldsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConfigurationFieldsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConfigurationFieldsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConfigurationFieldsResponse">
        <soap:header message="tns:GetConfigurationFieldsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConfigurationFieldsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConfigurationFieldsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConfigurationFieldsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetErpConnectionConfigFields">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetErpConnectionConfigFields" style="document" />
      <wsdl:input name="GetErpConnectionConfigFieldsRequest">
        <soap:header message="tns:GetErpConnectionConfigFieldsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetErpConnectionConfigFieldsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetErpConnectionConfigFieldsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetErpConnectionConfigFieldsResponse">
        <soap:header message="tns:GetErpConnectionConfigFieldsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetErpConnectionConfigFieldsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetErpConnectionConfigFieldsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetErpConnectionConfigFieldsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ToggleErpConnectionActive">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ToggleErpConnectionActive" style="document" />
      <wsdl:input name="ToggleErpConnectionActiveRequest">
        <soap:header message="tns:ToggleErpConnectionActiveRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ToggleErpConnectionActiveRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ToggleErpConnectionActiveRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ToggleErpConnectionActiveResponse">
        <soap:header message="tns:ToggleErpConnectionActiveResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ToggleErpConnectionActiveResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ToggleErpConnectionActiveResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ToggleErpConnectionActiveResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="TestConnectionById">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/TestConnectionById" style="document" />
      <wsdl:input name="TestConnectionByIdRequest">
        <soap:header message="tns:TestConnectionByIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TestConnectionByIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TestConnectionByIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TestConnectionByIdResponse">
        <soap:header message="tns:TestConnectionByIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TestConnectionByIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TestConnectionByIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TestConnectionByIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="TestConnectionByConfig">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/TestConnectionByConfig" style="document" />
      <wsdl:input name="TestConnectionByConfigRequest">
        <soap:header message="tns:TestConnectionByConfigRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TestConnectionByConfigRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TestConnectionByConfigRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TestConnectionByConfigResponse">
        <soap:header message="tns:TestConnectionByConfigResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TestConnectionByConfigResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TestConnectionByConfigResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TestConnectionByConfigResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveErpConnectionSyncPriorities">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SaveErpConnectionSyncPriorities" style="document" />
      <wsdl:input name="SaveErpConnectionSyncPrioritiesRequest">
        <soap:header message="tns:SaveErpConnectionSyncPrioritiesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveErpConnectionSyncPrioritiesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveErpConnectionSyncPrioritiesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveErpConnectionSyncPrioritiesResponse">
        <soap:header message="tns:SaveErpConnectionSyncPrioritiesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveErpConnectionSyncPrioritiesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveErpConnectionSyncPrioritiesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveErpConnectionSyncPrioritiesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="MoveErpFieldItem">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/MoveErpFieldItem" style="document" />
      <wsdl:input name="MoveErpFieldItemRequest">
        <soap:header message="tns:MoveErpFieldItemRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MoveErpFieldItemRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MoveErpFieldItemRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MoveErpFieldItemResponse">
        <soap:header message="tns:MoveErpFieldItemResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MoveErpFieldItemResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MoveErpFieldItemResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MoveErpFieldItemResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SupportsAdvancedSearch">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SupportsAdvancedSearch" style="document" />
      <wsdl:input name="SupportsAdvancedSearchRequest">
        <soap:header message="tns:SupportsAdvancedSearchRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SupportsAdvancedSearchRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SupportsAdvancedSearchRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SupportsAdvancedSearchResponse">
        <soap:header message="tns:SupportsAdvancedSearchResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SupportsAdvancedSearchResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SupportsAdvancedSearchResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SupportsAdvancedSearchResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConnectionsAndDisplayFields">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetConnectionsAndDisplayFields" style="document" />
      <wsdl:input name="GetConnectionsAndDisplayFieldsRequest">
        <soap:header message="tns:GetConnectionsAndDisplayFieldsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConnectionsAndDisplayFieldsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConnectionsAndDisplayFieldsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConnectionsAndDisplayFieldsResponse">
        <soap:header message="tns:GetConnectionsAndDisplayFieldsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConnectionsAndDisplayFieldsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConnectionsAndDisplayFieldsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConnectionsAndDisplayFieldsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetErpFieldValues">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetErpFieldValues" style="document" />
      <wsdl:input name="GetErpFieldValuesRequest">
        <soap:header message="tns:GetErpFieldValuesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetErpFieldValuesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetErpFieldValuesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetErpFieldValuesResponse">
        <soap:header message="tns:GetErpFieldValuesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetErpFieldValuesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetErpFieldValuesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetErpFieldValuesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFieldsForNewErpActor">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetFieldsForNewErpActor" style="document" />
      <wsdl:input name="GetFieldsForNewErpActorRequest">
        <soap:header message="tns:GetFieldsForNewErpActorRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFieldsForNewErpActorRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFieldsForNewErpActorRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFieldsForNewErpActorResponse">
        <soap:header message="tns:GetFieldsForNewErpActorResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFieldsForNewErpActorResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFieldsForNewErpActorResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFieldsForNewErpActorResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConnectionListMappings">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetConnectionListMappings" style="document" />
      <wsdl:input name="GetConnectionListMappingsRequest">
        <soap:header message="tns:GetConnectionListMappingsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConnectionListMappingsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConnectionListMappingsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConnectionListMappingsResponse">
        <soap:header message="tns:GetConnectionListMappingsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConnectionListMappingsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConnectionListMappingsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConnectionListMappingsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveConnectionListMappings">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SaveConnectionListMappings" style="document" />
      <wsdl:input name="SaveConnectionListMappingsRequest">
        <soap:header message="tns:SaveConnectionListMappingsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveConnectionListMappingsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveConnectionListMappingsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveConnectionListMappingsResponse">
        <soap:header message="tns:SaveConnectionListMappingsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveConnectionListMappingsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveConnectionListMappingsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveConnectionListMappingsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ConnectActor">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ConnectActor" style="document" />
      <wsdl:input name="ConnectActorRequest">
        <soap:header message="tns:ConnectActorRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ConnectActorRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ConnectActorRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ConnectActorResponse">
        <soap:header message="tns:ConnectActorResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ConnectActorResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ConnectActorResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ConnectActorResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="TryConnectActor">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/TryConnectActor" style="document" />
      <wsdl:input name="TryConnectActorRequest">
        <soap:header message="tns:TryConnectActorRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TryConnectActorRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TryConnectActorRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TryConnectActorResponse">
        <soap:header message="tns:TryConnectActorResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TryConnectActorResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TryConnectActorResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TryConnectActorResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFieldValuesFromCrm">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetFieldValuesFromCrm" style="document" />
      <wsdl:input name="GetFieldValuesFromCrmRequest">
        <soap:header message="tns:GetFieldValuesFromCrmRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFieldValuesFromCrmRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFieldValuesFromCrmRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFieldValuesFromCrmResponse">
        <soap:header message="tns:GetFieldValuesFromCrmResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFieldValuesFromCrmResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFieldValuesFromCrmResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFieldValuesFromCrmResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFieldValuesFromErp">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetFieldValuesFromErp" style="document" />
      <wsdl:input name="GetFieldValuesFromErpRequest">
        <soap:header message="tns:GetFieldValuesFromErpRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFieldValuesFromErpRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFieldValuesFromErpRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFieldValuesFromErpResponse">
        <soap:header message="tns:GetFieldValuesFromErpResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFieldValuesFromErpResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFieldValuesFromErpResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFieldValuesFromErpResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetActorTypeMapping">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetActorTypeMapping" style="document" />
      <wsdl:input name="GetActorTypeMappingRequest">
        <soap:header message="tns:GetActorTypeMappingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetActorTypeMappingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetActorTypeMappingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetActorTypeMappingResponse">
        <soap:header message="tns:GetActorTypeMappingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetActorTypeMappingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetActorTypeMappingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetActorTypeMappingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateActorLink">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/CreateActorLink" style="document" />
      <wsdl:input name="CreateActorLinkRequest">
        <soap:header message="tns:CreateActorLinkRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateActorLinkRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateActorLinkRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateActorLinkResponse">
        <soap:header message="tns:CreateActorLinkResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateActorLinkResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateActorLinkResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateActorLinkResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="BreakActorLink">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/BreakActorLink" style="document" />
      <wsdl:input name="BreakActorLinkRequest">
        <soap:header message="tns:BreakActorLinkRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:BreakActorLinkRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:BreakActorLinkRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="BreakActorLinkResponse">
        <soap:header message="tns:BreakActorLinkResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:BreakActorLinkResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:BreakActorLinkResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:BreakActorLinkResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateErpActorFromCrm">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/CreateErpActorFromCrm" style="document" />
      <wsdl:input name="CreateErpActorFromCrmRequest">
        <soap:header message="tns:CreateErpActorFromCrmRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateErpActorFromCrmRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateErpActorFromCrmRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateErpActorFromCrmResponse">
        <soap:header message="tns:CreateErpActorFromCrmResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateErpActorFromCrmResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateErpActorFromCrmResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateErpActorFromCrmResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveActorTypeMapping">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SaveActorTypeMapping" style="document" />
      <wsdl:input name="SaveActorTypeMappingRequest">
        <soap:header message="tns:SaveActorTypeMappingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveActorTypeMappingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveActorTypeMappingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveActorTypeMappingResponse">
        <soap:header message="tns:SaveActorTypeMappingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveActorTypeMappingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveActorTypeMappingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveActorTypeMappingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ValidateArchiveColumnConfig">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ValidateArchiveColumnConfig" style="document" />
      <wsdl:input name="ValidateArchiveColumnConfigRequest">
        <soap:header message="tns:ValidateArchiveColumnConfigRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ValidateArchiveColumnConfigRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ValidateArchiveColumnConfigRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ValidateArchiveColumnConfigResponse">
        <soap:header message="tns:ValidateArchiveColumnConfigResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ValidateArchiveColumnConfigResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ValidateArchiveColumnConfigResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ValidateArchiveColumnConfigResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateConnectionFields">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/UpdateConnectionFields" style="document" />
      <wsdl:input name="UpdateConnectionFieldsRequest">
        <soap:header message="tns:UpdateConnectionFieldsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateConnectionFieldsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateConnectionFieldsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateConnectionFieldsResponse">
        <soap:header message="tns:UpdateConnectionFieldsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateConnectionFieldsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateConnectionFieldsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateConnectionFieldsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCrmActorType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetCrmActorType" style="document" />
      <wsdl:input name="GetCrmActorTypeRequest">
        <soap:header message="tns:GetCrmActorTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCrmActorTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCrmActorTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCrmActorTypeResponse">
        <soap:header message="tns:GetCrmActorTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCrmActorTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCrmActorTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCrmActorTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetErpSyncConnectionSummary">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetErpSyncConnectionSummary" style="document" />
      <wsdl:input name="GetErpSyncConnectionSummaryRequest">
        <soap:header message="tns:GetErpSyncConnectionSummaryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetErpSyncConnectionSummaryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetErpSyncConnectionSummaryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetErpSyncConnectionSummaryResponse">
        <soap:header message="tns:GetErpSyncConnectionSummaryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetErpSyncConnectionSummaryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetErpSyncConnectionSummaryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetErpSyncConnectionSummaryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetErpSyncConnectorEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetErpSyncConnectorEntity" style="document" />
      <wsdl:input name="GetErpSyncConnectorEntityRequest">
        <soap:header message="tns:GetErpSyncConnectorEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetErpSyncConnectorEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetErpSyncConnectorEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetErpSyncConnectorEntityResponse">
        <soap:header message="tns:GetErpSyncConnectorEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetErpSyncConnectorEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetErpSyncConnectorEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetErpSyncConnectorEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CanDeleteErpSyncConnectorEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/CanDeleteErpSyncConnectorEntity" style="document" />
      <wsdl:input name="CanDeleteErpSyncConnectorEntityRequest">
        <soap:header message="tns:CanDeleteErpSyncConnectorEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CanDeleteErpSyncConnectorEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CanDeleteErpSyncConnectorEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CanDeleteErpSyncConnectorEntityResponse">
        <soap:header message="tns:CanDeleteErpSyncConnectorEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CanDeleteErpSyncConnectorEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CanDeleteErpSyncConnectorEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CanDeleteErpSyncConnectorEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="TestConnectorUrl">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/TestConnectorUrl" style="document" />
      <wsdl:input name="TestConnectorUrlRequest">
        <soap:header message="tns:TestConnectorUrlRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TestConnectorUrlRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TestConnectorUrlRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TestConnectorUrlResponse">
        <soap:header message="tns:TestConnectorUrlResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TestConnectorUrlResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TestConnectorUrlResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TestConnectorUrlResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveDefaultValueInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SaveDefaultValueInfo" style="document" />
      <wsdl:input name="SaveDefaultValueInfoRequest">
        <soap:header message="tns:SaveDefaultValueInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveDefaultValueInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveDefaultValueInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveDefaultValueInfoResponse">
        <soap:header message="tns:SaveDefaultValueInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveDefaultValueInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveDefaultValueInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveDefaultValueInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDefaultValueInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetDefaultValueInfo" style="document" />
      <wsdl:input name="GetDefaultValueInfoRequest">
        <soap:header message="tns:GetDefaultValueInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDefaultValueInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDefaultValueInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDefaultValueInfoResponse">
        <soap:header message="tns:GetDefaultValueInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDefaultValueInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDefaultValueInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDefaultValueInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SyncAll">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/SyncAll" style="document" />
      <wsdl:input name="SyncAllRequest">
        <soap:header message="tns:SyncAllRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SyncAllRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SyncAllRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SyncAllResponse">
        <soap:header message="tns:SyncAllResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SyncAllResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SyncAllResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SyncAllResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ForceSyncAll">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ForceSyncAll" style="document" />
      <wsdl:input name="ForceSyncAllRequest">
        <soap:header message="tns:ForceSyncAllRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ForceSyncAllRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ForceSyncAllRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ForceSyncAllResponse">
        <soap:header message="tns:ForceSyncAllResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ForceSyncAllResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ForceSyncAllResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ForceSyncAllResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ForceResync">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ForceResync" style="document" />
      <wsdl:input name="ForceResyncRequest">
        <soap:header message="tns:ForceResyncRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ForceResyncRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ForceResyncRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ForceResyncResponse">
        <soap:header message="tns:ForceResyncResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ForceResyncResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ForceResyncResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ForceResyncResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ForceResyncNoBlankValues">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ForceResyncNoBlankValues" style="document" />
      <wsdl:input name="ForceResyncNoBlankValuesRequest">
        <soap:header message="tns:ForceResyncNoBlankValuesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ForceResyncNoBlankValuesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ForceResyncNoBlankValuesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ForceResyncNoBlankValuesResponse">
        <soap:header message="tns:ForceResyncNoBlankValuesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ForceResyncNoBlankValuesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ForceResyncNoBlankValuesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ForceResyncNoBlankValuesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ForceResyncBatchTask">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ForceResyncBatchTask" style="document" />
      <wsdl:input name="ForceResyncBatchTaskRequest">
        <soap:header message="tns:ForceResyncBatchTaskRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ForceResyncBatchTaskRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ForceResyncBatchTaskRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ForceResyncBatchTaskResponse">
        <soap:header message="tns:ForceResyncBatchTaskResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ForceResyncBatchTaskResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ForceResyncBatchTaskResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ForceResyncBatchTaskResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ForceResyncExternal">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ForceResyncExternal" style="document" />
      <wsdl:input name="ForceResyncExternalRequest">
        <soap:header message="tns:ForceResyncExternalRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ForceResyncExternalRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ForceResyncExternalRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ForceResyncExternalResponse">
        <soap:header message="tns:ForceResyncExternalResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ForceResyncExternalResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ForceResyncExternalResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ForceResyncExternalResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ForceResyncExternalNoBlankValues">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ForceResyncExternalNoBlankValues" style="document" />
      <wsdl:input name="ForceResyncExternalNoBlankValuesRequest">
        <soap:header message="tns:ForceResyncExternalNoBlankValuesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ForceResyncExternalNoBlankValuesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ForceResyncExternalNoBlankValuesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ForceResyncExternalNoBlankValuesResponse">
        <soap:header message="tns:ForceResyncExternalNoBlankValuesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ForceResyncExternalNoBlankValuesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ForceResyncExternalNoBlankValuesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ForceResyncExternalNoBlankValuesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEngineStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/GetEngineStatus" style="document" />
      <wsdl:input name="GetEngineStatusRequest">
        <soap:header message="tns:GetEngineStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEngineStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEngineStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEngineStatusResponse">
        <soap:header message="tns:GetEngineStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEngineStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEngineStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEngineStatusResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChangeEngineStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ChangeEngineStatus" style="document" />
      <wsdl:input name="ChangeEngineStatusRequest">
        <soap:header message="tns:ChangeEngineStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChangeEngineStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChangeEngineStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChangeEngineStatusResponse">
        <soap:header message="tns:ChangeEngineStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChangeEngineStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChangeEngineStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChangeEngineStatusResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChangeEngineInterval">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/ErpSync/ChangeEngineInterval" style="document" />
      <wsdl:input name="ChangeEngineIntervalRequest">
        <soap:header message="tns:ChangeEngineIntervalRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChangeEngineIntervalRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChangeEngineIntervalRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChangeEngineIntervalResponse">
        <soap:header message="tns:ChangeEngineIntervalResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChangeEngineIntervalResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChangeEngineIntervalResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChangeEngineIntervalResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfErpSyncService">
    <wsdl:port name="BasicHttpBinding_ErpSync" binding="tns:BasicHttpBinding_ErpSync">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/ErpSync.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

