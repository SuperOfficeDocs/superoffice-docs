---
Generated: 1
TOCExclude: 1
title: Services80.MessagingAgent WSDL
---

# Services80.MessagingAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfMessagingService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services80" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services80" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services80" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateMessage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="IncomingMessage" nillable="true" type="tns:IncomingMessage" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="IncomingMessage">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="To" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="From" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Content" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Format" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SessionKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Plugin" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="IncomingMessage" nillable="true" type="tns:IncomingMessage" />
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
      <xs:element name="CreateMessageResponse">
        <xs:complexType>
          <xs:sequence />
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
      <xs:element name="GetDeliveryStatus">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MessagingIds" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDeliveryStatusResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfMessageDeliveryStatus" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfMessageDeliveryStatus">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="MessageDeliveryStatus" nillable="true" type="tns:MessageDeliveryStatus" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfMessageDeliveryStatus" nillable="true" type="tns:ArrayOfMessageDeliveryStatus" />
      <xs:complexType name="MessageDeliveryStatus">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Status" type="xs:int" />
              <xs:element minOccurs="0" name="StatusDescription" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MessagingId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="MessageDeliveryStatus" nillable="true" type="tns:MessageDeliveryStatus" />
      <xs:element name="SetDeliveryStatus">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Plugin" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ExternalMessageId" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Status" type="xs:int" />
            <xs:element minOccurs="0" name="StatusDescription" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDeliveryStatusResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SendMessages">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Plugin" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="OutgoingMessages" nillable="true" type="tns:ArrayOfOutgoingMessage" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfOutgoingMessage">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="OutgoingMessage" nillable="true" type="tns:OutgoingMessage" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfOutgoingMessage" nillable="true" type="tns:ArrayOfOutgoingMessage" />
      <xs:complexType name="OutgoingMessage">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="From" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="To" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Content" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Format" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ParentMessagingId" type="xs:int" />
              <xs:element minOccurs="0" name="SuggestedSessionKey" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="OutgoingMessage" nillable="true" type="tns:OutgoingMessage" />
      <xs:element name="SendMessagesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfMessageDeliveryStatus" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPlugins">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPluginsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfProviderInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfProviderInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ProviderInfo" nillable="true" type="tns:ProviderInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfProviderInfo" nillable="true" type="tns:ArrayOfProviderInfo" />
      <xs:complexType name="ProviderInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SupportedMessagingFormats" nillable="true" type="q2:ArrayOfstring" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ProviderInfo" nillable="true" type="tns:ProviderInfo" />
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
  <wsdl:message name="CreateMessageRequest">
    <wsdl:part name="parameters" element="tns:CreateMessage" />
  </wsdl:message>
  <wsdl:message name="CreateMessageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateMessageResponse">
    <wsdl:part name="parameters" element="tns:CreateMessageResponse" />
  </wsdl:message>
  <wsdl:message name="CreateMessageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryStatusRequest">
    <wsdl:part name="parameters" element="tns:GetDeliveryStatus" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryStatusResponse">
    <wsdl:part name="parameters" element="tns:GetDeliveryStatusResponse" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryStatusResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDeliveryStatusRequest">
    <wsdl:part name="parameters" element="tns:SetDeliveryStatus" />
  </wsdl:message>
  <wsdl:message name="SetDeliveryStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDeliveryStatusResponse">
    <wsdl:part name="parameters" element="tns:SetDeliveryStatusResponse" />
  </wsdl:message>
  <wsdl:message name="SetDeliveryStatusResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendMessagesRequest">
    <wsdl:part name="parameters" element="tns:SendMessages" />
  </wsdl:message>
  <wsdl:message name="SendMessagesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendMessagesResponse">
    <wsdl:part name="parameters" element="tns:SendMessagesResponse" />
  </wsdl:message>
  <wsdl:message name="SendMessagesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPluginsRequest">
    <wsdl:part name="parameters" element="tns:GetPlugins" />
  </wsdl:message>
  <wsdl:message name="GetPluginsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPluginsResponse">
    <wsdl:part name="parameters" element="tns:GetPluginsResponse" />
  </wsdl:message>
  <wsdl:message name="GetPluginsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Messaging">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Messaging</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateMessage">
      <wsdl:documentation>
        <summary>Create a new message and insert it in the message queue. (inbox)</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Messaging/CreateMessage" name="CreateMessageRequest" message="tns:CreateMessageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Messaging/CreateMessageResponse" name="CreateMessageResponse" message="tns:CreateMessageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDeliveryStatus">
      <wsdl:documentation>
        <summary>Get delivery status</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Messaging/GetDeliveryStatus" name="GetDeliveryStatusRequest" message="tns:GetDeliveryStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Messaging/GetDeliveryStatusResponse" name="GetDeliveryStatusResponse" message="tns:GetDeliveryStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetDeliveryStatus">
      <wsdl:documentation>
        <summary>Set or change the delivery status on an outgoing messsage.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Messaging/SetDeliveryStatus" name="SetDeliveryStatusRequest" message="tns:SetDeliveryStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Messaging/SetDeliveryStatusResponse" name="SetDeliveryStatusResponse" message="tns:SetDeliveryStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="SendMessages">
      <wsdl:documentation>
        <summary>Send an array of messages</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Messaging/SendMessages" name="SendMessagesRequest" message="tns:SendMessagesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Messaging/SendMessagesResponse" name="SendMessagesResponse" message="tns:SendMessagesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPlugins">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Messaging/GetPlugins" name="GetPluginsRequest" message="tns:GetPluginsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Messaging/GetPluginsResponse" name="GetPluginsResponse" message="tns:GetPluginsResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Messaging" type="tns:Messaging">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateMessage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Messaging/CreateMessage" style="document" />
      <wsdl:input name="CreateMessageRequest">
        <soap:header message="tns:CreateMessageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateMessageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateMessageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateMessageResponse">
        <soap:header message="tns:CreateMessageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateMessageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateMessageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateMessageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDeliveryStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Messaging/GetDeliveryStatus" style="document" />
      <wsdl:input name="GetDeliveryStatusRequest">
        <soap:header message="tns:GetDeliveryStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDeliveryStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDeliveryStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDeliveryStatusResponse">
        <soap:header message="tns:GetDeliveryStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDeliveryStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDeliveryStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDeliveryStatusResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetDeliveryStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Messaging/SetDeliveryStatus" style="document" />
      <wsdl:input name="SetDeliveryStatusRequest">
        <soap:header message="tns:SetDeliveryStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetDeliveryStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetDeliveryStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetDeliveryStatusResponse">
        <soap:header message="tns:SetDeliveryStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetDeliveryStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetDeliveryStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetDeliveryStatusResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SendMessages">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Messaging/SendMessages" style="document" />
      <wsdl:input name="SendMessagesRequest">
        <soap:header message="tns:SendMessagesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SendMessagesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SendMessagesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SendMessagesResponse">
        <soap:header message="tns:SendMessagesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SendMessagesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SendMessagesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SendMessagesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPlugins">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Messaging/GetPlugins" style="document" />
      <wsdl:input name="GetPluginsRequest">
        <soap:header message="tns:GetPluginsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPluginsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPluginsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPluginsResponse">
        <soap:header message="tns:GetPluginsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPluginsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPluginsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPluginsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfMessagingService">
    <wsdl:port name="BasicHttpBinding_Messaging" binding="tns:BasicHttpBinding_Messaging">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services80/Messaging.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

