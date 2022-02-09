---
generated: 1
uid: wsdl-Services87-Webhook
title: Services87.WebhookAgent WSDL
---

# Services87.WebhookAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfWebhookService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultWebhook">
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
      <xs:element name="CreateDefaultWebhookResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Webhook" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Webhook">
        <xs:sequence>
          <xs:element minOccurs="0" name="WebhookId" type="xs:int" />
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Events" nillable="true" type="q1:ArrayOfstring" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="TargetUrl" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Secret" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="State" type="tns:WebhookState" />
          <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Headers" nillable="true" type="tns:StringDictionary" />
          <xs:element minOccurs="0" name="Properties" nillable="true" type="tns:StringObjectDictionary" />
          <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
          <xs:element minOccurs="0" name="RegisteredAssociate" nillable="true" type="tns:Associate" />
          <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
          <xs:element minOccurs="0" name="UpdatedAssociate" nillable="true" type="tns:Associate" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="Webhook" nillable="true" type="tns:Webhook" />
      <xs:simpleType name="WebhookState">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Active" />
          <xs:enumeration value="Stopped" />
          <xs:enumeration value="TooManyErrors" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="WebhookState" nillable="true" type="tns:WebhookState" />
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
      <xs:complexType name="StringObjectDictionary">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="StringObjectKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="xs:anyType" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="StringObjectDictionary" nillable="true" type="tns:StringObjectDictionary" />
      <xs:complexType name="Associate">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Type" type="tns:UserType" />
              <xs:element minOccurs="0" name="GroupIdx" type="xs:int" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="EjUserId" type="xs:int" />
              <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Associate" nillable="true" type="tns:Associate" />
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
      <xs:simpleType name="UserType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="InternalAssociate" />
          <xs:enumeration value="ResourceAssociate" />
          <xs:enumeration value="ExternalAssociate" />
          <xs:enumeration value="AnonymousAssociate" />
          <xs:enumeration value="SystemAssociate" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="UserType" nillable="true" type="tns:UserType" />
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
      <xs:element name="SaveWebhook">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Webhook" nillable="true" type="tns:Webhook" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveWebhookResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Webhook" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteWebhook">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WebhookId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteWebhookResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWebhook">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WebhookId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWebhookResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Webhook" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllWebhooks">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NameFilter" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="EventFilter" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StatusFilter" type="tns:WebhookState" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllWebhooksResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfWebhook" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfWebhook">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Webhook" nillable="true" type="tns:Webhook" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfWebhook" nillable="true" type="tns:ArrayOfWebhook" />
      <xs:element name="TestWebhook">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Webhook" nillable="true" type="tns:Webhook" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TestWebhookResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WebhookResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="WebhookResult">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Success" type="xs:boolean" />
              <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WebhookResult" nillable="true" type="tns:WebhookResult" />
      <xs:element name="SignalEvent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EventName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PrimaryKey" type="xs:int" />
            <xs:element minOccurs="0" name="Data" nillable="true" type="tns:StringObjectDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SignalEventResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLastError">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WebhookId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLastErrorResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
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
  <wsdl:message name="CreateDefaultWebhookRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultWebhook" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWebhookRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWebhookResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultWebhookResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWebhookResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveWebhookRequest">
    <wsdl:part name="parameters" element="tns:SaveWebhook" />
  </wsdl:message>
  <wsdl:message name="SaveWebhookRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveWebhookResponse">
    <wsdl:part name="parameters" element="tns:SaveWebhookResponse" />
  </wsdl:message>
  <wsdl:message name="SaveWebhookResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteWebhookRequest">
    <wsdl:part name="parameters" element="tns:DeleteWebhook" />
  </wsdl:message>
  <wsdl:message name="DeleteWebhookRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteWebhookResponse">
    <wsdl:part name="parameters" element="tns:DeleteWebhookResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteWebhookResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWebhookRequest">
    <wsdl:part name="parameters" element="tns:GetWebhook" />
  </wsdl:message>
  <wsdl:message name="GetWebhookRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWebhookResponse">
    <wsdl:part name="parameters" element="tns:GetWebhookResponse" />
  </wsdl:message>
  <wsdl:message name="GetWebhookResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllWebhooksRequest">
    <wsdl:part name="parameters" element="tns:GetAllWebhooks" />
  </wsdl:message>
  <wsdl:message name="GetAllWebhooksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllWebhooksResponse">
    <wsdl:part name="parameters" element="tns:GetAllWebhooksResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllWebhooksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TestWebhookRequest">
    <wsdl:part name="parameters" element="tns:TestWebhook" />
  </wsdl:message>
  <wsdl:message name="TestWebhookRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TestWebhookResponse">
    <wsdl:part name="parameters" element="tns:TestWebhookResponse" />
  </wsdl:message>
  <wsdl:message name="TestWebhookResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SignalEventRequest">
    <wsdl:part name="parameters" element="tns:SignalEvent" />
  </wsdl:message>
  <wsdl:message name="SignalEventRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SignalEventResponse">
    <wsdl:part name="parameters" element="tns:SignalEventResponse" />
  </wsdl:message>
  <wsdl:message name="SignalEventResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLastErrorRequest">
    <wsdl:part name="parameters" element="tns:GetLastError" />
  </wsdl:message>
  <wsdl:message name="GetLastErrorRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLastErrorResponse">
    <wsdl:part name="parameters" element="tns:GetLastErrorResponse" />
  </wsdl:message>
  <wsdl:message name="GetLastErrorResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Webhook">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Webhook</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultWebhook">
      <wsdl:documentation>
        <summary>Loading default values into a new Webhook.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/CreateDefaultWebhook" name="CreateDefaultWebhookRequest" message="tns:CreateDefaultWebhookRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/CreateDefaultWebhookResponse" name="CreateDefaultWebhookResponse" message="tns:CreateDefaultWebhookResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveWebhook">
      <wsdl:documentation>
        <summary>Updates the existing Webhook or creates a new Webhook if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/SaveWebhook" name="SaveWebhookRequest" message="tns:SaveWebhookRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/SaveWebhookResponse" name="SaveWebhookResponse" message="tns:SaveWebhookResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteWebhook">
      <wsdl:documentation>
        <summary>Deletes the Webhook</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/DeleteWebhook" name="DeleteWebhookRequest" message="tns:DeleteWebhookRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/DeleteWebhookResponse" name="DeleteWebhookResponse" message="tns:DeleteWebhookResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetWebhook">
      <wsdl:documentation>
        <summary>Gets a Webhook object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/GetWebhook" name="GetWebhookRequest" message="tns:GetWebhookRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/GetWebhookResponse" name="GetWebhookResponse" message="tns:GetWebhookResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllWebhooks">
      <wsdl:documentation>
        <summary>Returns all webhooks, according to filter criteria</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/GetAllWebhooks" name="GetAllWebhooksRequest" message="tns:GetAllWebhooksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/GetAllWebhooksResponse" name="GetAllWebhooksResponse" message="tns:GetAllWebhooksResponse" />
    </wsdl:operation>
    <wsdl:operation name="TestWebhook">
      <wsdl:documentation>
        <summary>Pings a webhook with a 'test' event, returns SUCCESS(true) or FAILURE(false) + the response from the webhook target.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/TestWebhook" name="TestWebhookRequest" message="tns:TestWebhookRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/TestWebhookResponse" name="TestWebhookResponse" message="tns:TestWebhookResponse" />
    </wsdl:operation>
    <wsdl:operation name="SignalEvent">
      <wsdl:documentation>
        <summary>Signal webhooks that an event has occurred. All webhooks listening for the event will be notified.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/SignalEvent" name="SignalEventRequest" message="tns:SignalEventRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/SignalEventResponse" name="SignalEventResponse" message="tns:SignalEventResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLastError">
      <wsdl:documentation>
        <summary>Return the most recent error message received when calling this webhook.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/GetLastError" name="GetLastErrorRequest" message="tns:GetLastErrorRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/GetLastErrorResponse" name="GetLastErrorResponse" message="tns:GetLastErrorResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Webhook" type="tns:Webhook">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultWebhook">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/CreateDefaultWebhook" style="document" />
      <wsdl:input name="CreateDefaultWebhookRequest">
        <soap:header message="tns:CreateDefaultWebhookRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultWebhookRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultWebhookRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultWebhookResponse">
        <soap:header message="tns:CreateDefaultWebhookResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWebhookResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWebhookResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultWebhookResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveWebhook">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/SaveWebhook" style="document" />
      <wsdl:input name="SaveWebhookRequest">
        <soap:header message="tns:SaveWebhookRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveWebhookRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveWebhookRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveWebhookResponse">
        <soap:header message="tns:SaveWebhookResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveWebhookResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveWebhookResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveWebhookResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteWebhook">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/DeleteWebhook" style="document" />
      <wsdl:input name="DeleteWebhookRequest">
        <soap:header message="tns:DeleteWebhookRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteWebhookRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteWebhookRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteWebhookResponse">
        <soap:header message="tns:DeleteWebhookResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteWebhookResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteWebhookResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteWebhookResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetWebhook">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/GetWebhook" style="document" />
      <wsdl:input name="GetWebhookRequest">
        <soap:header message="tns:GetWebhookRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetWebhookRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetWebhookRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetWebhookResponse">
        <soap:header message="tns:GetWebhookResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetWebhookResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetWebhookResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetWebhookResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllWebhooks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/GetAllWebhooks" style="document" />
      <wsdl:input name="GetAllWebhooksRequest">
        <soap:header message="tns:GetAllWebhooksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllWebhooksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllWebhooksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllWebhooksResponse">
        <soap:header message="tns:GetAllWebhooksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllWebhooksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllWebhooksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllWebhooksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="TestWebhook">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/TestWebhook" style="document" />
      <wsdl:input name="TestWebhookRequest">
        <soap:header message="tns:TestWebhookRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TestWebhookRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TestWebhookRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TestWebhookResponse">
        <soap:header message="tns:TestWebhookResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TestWebhookResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TestWebhookResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TestWebhookResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SignalEvent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/SignalEvent" style="document" />
      <wsdl:input name="SignalEventRequest">
        <soap:header message="tns:SignalEventRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SignalEventRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SignalEventRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SignalEventResponse">
        <soap:header message="tns:SignalEventResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SignalEventResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SignalEventResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SignalEventResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLastError">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Webhook/GetLastError" style="document" />
      <wsdl:input name="GetLastErrorRequest">
        <soap:header message="tns:GetLastErrorRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLastErrorRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLastErrorRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLastErrorResponse">
        <soap:header message="tns:GetLastErrorResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLastErrorResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLastErrorResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLastErrorResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfWebhookService">
    <wsdl:port name="BasicHttpBinding_Webhook" binding="tns:BasicHttpBinding_Webhook">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services87/Webhook.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

