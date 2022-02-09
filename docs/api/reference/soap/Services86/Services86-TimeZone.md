---
generated: 1
uid: wsdl-Services86-TimeZone
title: Services86.TimeZoneAgent WSDL
---

# Services86.TimeZoneAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfTimeZoneService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services86" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services86" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services86" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:element name="InitializeTimeZoneData">
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
      <xs:element name="InitializeTimeZoneDataResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTimeZoneData" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfTimeZoneData">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TimeZoneData" nillable="true" type="tns:TimeZoneData" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTimeZoneData" nillable="true" type="tns:ArrayOfTimeZoneData" />
      <xs:complexType name="TimeZoneData">
        <xs:sequence>
          <xs:element minOccurs="0" name="TZLocationID" type="xs:int" />
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="TZLocationCode" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="TZLocationCities" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="IsoNumber" type="xs:int" />
          <xs:element minOccurs="0" name="TimeZoneSTDRules" nillable="true" type="tns:TimeZoneRuleDictionary" />
          <xs:element minOccurs="0" name="TimeZoneDSTRules" nillable="true" type="tns:TimeZoneRuleDictionary" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TimeZoneData" nillable="true" type="tns:TimeZoneData" />
      <xs:complexType name="TimeZoneRuleDictionary">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TimeZoneRuleKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" type="xs:dateTime" />
                <xs:element name="Value" nillable="true" type="tns:TimeZoneRule" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TimeZoneRuleDictionary" nillable="true" type="tns:TimeZoneRuleDictionary" />
      <xs:complexType name="TimeZoneRule">
        <xs:sequence>
          <xs:element minOccurs="0" name="TZOffset" type="xs:int" />
          <xs:element minOccurs="0" name="StartRulePattern" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="EndRulePattern" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="StartDay" type="xs:int" />
          <xs:element minOccurs="0" name="StartMonth" type="xs:int" />
          <xs:element minOccurs="0" name="EndDay" type="xs:int" />
          <xs:element minOccurs="0" name="EndMonth" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TimeZoneRule" nillable="true" type="tns:TimeZoneRule" />
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
      <xs:element name="GetBaseTimeZoneId">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBaseTimeZoneIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateTimeZoneData">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateTimeZoneDataResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CheckNewTimeZoneDataAvailable">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CheckNewTimeZoneDataAvailableResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleActiveTimeZoneRow">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleActiveTimeZoneRowResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetActiveTimeZonesByFilter">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Filter" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Active" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetActiveTimeZonesByFilterResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="TimeOfLastTimeZoneUpdate">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="TimeOfLastTimeZoneUpdateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:dateTime" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetBaseTimeZoneId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TimezoneId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetBaseTimeZoneIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultTimeZonePreference">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultTimeZonePreferenceResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteTimeZones">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteTimeZonesResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetActiveTimeZoneRow">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="Active" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetActiveTimeZoneRowResponse">
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
  <wsdl:message name="InitializeTimeZoneDataRequest">
    <wsdl:part name="parameters" element="tns:InitializeTimeZoneData" />
  </wsdl:message>
  <wsdl:message name="InitializeTimeZoneDataRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="InitializeTimeZoneDataResponse">
    <wsdl:part name="parameters" element="tns:InitializeTimeZoneDataResponse" />
  </wsdl:message>
  <wsdl:message name="InitializeTimeZoneDataResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBaseTimeZoneIdRequest">
    <wsdl:part name="parameters" element="tns:GetBaseTimeZoneId" />
  </wsdl:message>
  <wsdl:message name="GetBaseTimeZoneIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBaseTimeZoneIdResponse">
    <wsdl:part name="parameters" element="tns:GetBaseTimeZoneIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetBaseTimeZoneIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateTimeZoneDataRequest">
    <wsdl:part name="parameters" element="tns:UpdateTimeZoneData" />
  </wsdl:message>
  <wsdl:message name="UpdateTimeZoneDataRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateTimeZoneDataResponse">
    <wsdl:part name="parameters" element="tns:UpdateTimeZoneDataResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateTimeZoneDataResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CheckNewTimeZoneDataAvailableRequest">
    <wsdl:part name="parameters" element="tns:CheckNewTimeZoneDataAvailable" />
  </wsdl:message>
  <wsdl:message name="CheckNewTimeZoneDataAvailableRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CheckNewTimeZoneDataAvailableResponse">
    <wsdl:part name="parameters" element="tns:CheckNewTimeZoneDataAvailableResponse" />
  </wsdl:message>
  <wsdl:message name="CheckNewTimeZoneDataAvailableResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleActiveTimeZoneRowRequest">
    <wsdl:part name="parameters" element="tns:ToggleActiveTimeZoneRow" />
  </wsdl:message>
  <wsdl:message name="ToggleActiveTimeZoneRowRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleActiveTimeZoneRowResponse">
    <wsdl:part name="parameters" element="tns:ToggleActiveTimeZoneRowResponse" />
  </wsdl:message>
  <wsdl:message name="ToggleActiveTimeZoneRowResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetActiveTimeZonesByFilterRequest">
    <wsdl:part name="parameters" element="tns:SetActiveTimeZonesByFilter" />
  </wsdl:message>
  <wsdl:message name="SetActiveTimeZonesByFilterRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetActiveTimeZonesByFilterResponse">
    <wsdl:part name="parameters" element="tns:SetActiveTimeZonesByFilterResponse" />
  </wsdl:message>
  <wsdl:message name="SetActiveTimeZonesByFilterResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TimeOfLastTimeZoneUpdateRequest">
    <wsdl:part name="parameters" element="tns:TimeOfLastTimeZoneUpdate" />
  </wsdl:message>
  <wsdl:message name="TimeOfLastTimeZoneUpdateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TimeOfLastTimeZoneUpdateResponse">
    <wsdl:part name="parameters" element="tns:TimeOfLastTimeZoneUpdateResponse" />
  </wsdl:message>
  <wsdl:message name="TimeOfLastTimeZoneUpdateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetBaseTimeZoneIdRequest">
    <wsdl:part name="parameters" element="tns:SetBaseTimeZoneId" />
  </wsdl:message>
  <wsdl:message name="SetBaseTimeZoneIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetBaseTimeZoneIdResponse">
    <wsdl:part name="parameters" element="tns:SetBaseTimeZoneIdResponse" />
  </wsdl:message>
  <wsdl:message name="SetBaseTimeZoneIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultTimeZonePreferenceRequest">
    <wsdl:part name="parameters" element="tns:GetDefaultTimeZonePreference" />
  </wsdl:message>
  <wsdl:message name="GetDefaultTimeZonePreferenceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultTimeZonePreferenceResponse">
    <wsdl:part name="parameters" element="tns:GetDefaultTimeZonePreferenceResponse" />
  </wsdl:message>
  <wsdl:message name="GetDefaultTimeZonePreferenceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteTimeZonesRequest">
    <wsdl:part name="parameters" element="tns:DeleteTimeZones" />
  </wsdl:message>
  <wsdl:message name="DeleteTimeZonesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteTimeZonesResponse">
    <wsdl:part name="parameters" element="tns:DeleteTimeZonesResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteTimeZonesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetActiveTimeZoneRowRequest">
    <wsdl:part name="parameters" element="tns:SetActiveTimeZoneRow" />
  </wsdl:message>
  <wsdl:message name="SetActiveTimeZoneRowRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetActiveTimeZoneRowResponse">
    <wsdl:part name="parameters" element="tns:SetActiveTimeZoneRowResponse" />
  </wsdl:message>
  <wsdl:message name="SetActiveTimeZoneRowResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="TimeZone">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for TimeZone</summary>
    </wsdl:documentation>
    <wsdl:operation name="InitializeTimeZoneData">
      <wsdl:documentation>
        <summary>Initalizes the TimeZoneData</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/InitializeTimeZoneData" name="InitializeTimeZoneDataRequest" message="tns:InitializeTimeZoneDataRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/InitializeTimeZoneDataResponse" name="InitializeTimeZoneDataResponse" message="tns:InitializeTimeZoneDataResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBaseTimeZoneId">
      <wsdl:documentation>
        <summary>Get the base timezone id.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/GetBaseTimeZoneId" name="GetBaseTimeZoneIdRequest" message="tns:GetBaseTimeZoneIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/GetBaseTimeZoneIdResponse" name="GetBaseTimeZoneIdResponse" message="tns:GetBaseTimeZoneIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateTimeZoneData">
      <wsdl:documentation>
        <summary>Retrieve time zone data from the SuperOffice server and update TimeZone data in the database</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/UpdateTimeZoneData" name="UpdateTimeZoneDataRequest" message="tns:UpdateTimeZoneDataRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/UpdateTimeZoneDataResponse" name="UpdateTimeZoneDataResponse" message="tns:UpdateTimeZoneDataResponse" />
    </wsdl:operation>
    <wsdl:operation name="CheckNewTimeZoneDataAvailable">
      <wsdl:documentation>
        <summary>Check to see if new timezone data is available</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/CheckNewTimeZoneDataAvailable" name="CheckNewTimeZoneDataAvailableRequest" message="tns:CheckNewTimeZoneDataAvailableRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/CheckNewTimeZoneDataAvailableResponse" name="CheckNewTimeZoneDataAvailableResponse" message="tns:CheckNewTimeZoneDataAvailableResponse" />
    </wsdl:operation>
    <wsdl:operation name="ToggleActiveTimeZoneRow">
      <wsdl:documentation>
        <summary>Toggles active state of a single row in the TZLocation table</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/ToggleActiveTimeZoneRow" name="ToggleActiveTimeZoneRowRequest" message="tns:ToggleActiveTimeZoneRowRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/ToggleActiveTimeZoneRowResponse" name="ToggleActiveTimeZoneRowResponse" message="tns:ToggleActiveTimeZoneRowResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetActiveTimeZonesByFilter">
      <wsdl:documentation>
        <summary>Toggles active state of a single row in the TZLocation table</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/SetActiveTimeZonesByFilter" name="SetActiveTimeZonesByFilterRequest" message="tns:SetActiveTimeZonesByFilterRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/SetActiveTimeZonesByFilterResponse" name="SetActiveTimeZonesByFilterResponse" message="tns:SetActiveTimeZonesByFilterResponse" />
    </wsdl:operation>
    <wsdl:operation name="TimeOfLastTimeZoneUpdate">
      <wsdl:documentation>
        <summary>Get the time time zone data was last updated</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/TimeOfLastTimeZoneUpdate" name="TimeOfLastTimeZoneUpdateRequest" message="tns:TimeOfLastTimeZoneUpdateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/TimeOfLastTimeZoneUpdateResponse" name="TimeOfLastTimeZoneUpdateResponse" message="tns:TimeOfLastTimeZoneUpdateResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetBaseTimeZoneId">
      <wsdl:documentation>
        <summary>Set the base timezone id.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/SetBaseTimeZoneId" name="SetBaseTimeZoneIdRequest" message="tns:SetBaseTimeZoneIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/SetBaseTimeZoneIdResponse" name="SetBaseTimeZoneIdResponse" message="tns:SetBaseTimeZoneIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDefaultTimeZonePreference">
      <wsdl:documentation>
        <summary>Returns the id of the default timezone preference with deflevel system wide</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/GetDefaultTimeZonePreference" name="GetDefaultTimeZonePreferenceRequest" message="tns:GetDefaultTimeZonePreferenceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/GetDefaultTimeZonePreferenceResponse" name="GetDefaultTimeZonePreferenceResponse" message="tns:GetDefaultTimeZonePreferenceResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteTimeZones">
      <wsdl:documentation>
        <summary>Deletes all time zone data (locations and rules) from the database</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/DeleteTimeZones" name="DeleteTimeZonesRequest" message="tns:DeleteTimeZonesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/DeleteTimeZonesResponse" name="DeleteTimeZonesResponse" message="tns:DeleteTimeZonesResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetActiveTimeZoneRow">
      <wsdl:documentation>
        <summary>Set active state of singe row in the TZLocation table</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/SetActiveTimeZoneRow" name="SetActiveTimeZoneRowRequest" message="tns:SetActiveTimeZoneRowRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/SetActiveTimeZoneRowResponse" name="SetActiveTimeZoneRowResponse" message="tns:SetActiveTimeZoneRowResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_TimeZone" type="tns:TimeZone">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="InitializeTimeZoneData">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/InitializeTimeZoneData" style="document" />
      <wsdl:input name="InitializeTimeZoneDataRequest">
        <soap:header message="tns:InitializeTimeZoneDataRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:InitializeTimeZoneDataRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:InitializeTimeZoneDataRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="InitializeTimeZoneDataResponse">
        <soap:header message="tns:InitializeTimeZoneDataResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:InitializeTimeZoneDataResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:InitializeTimeZoneDataResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:InitializeTimeZoneDataResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBaseTimeZoneId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/GetBaseTimeZoneId" style="document" />
      <wsdl:input name="GetBaseTimeZoneIdRequest">
        <soap:header message="tns:GetBaseTimeZoneIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBaseTimeZoneIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBaseTimeZoneIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBaseTimeZoneIdResponse">
        <soap:header message="tns:GetBaseTimeZoneIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBaseTimeZoneIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBaseTimeZoneIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBaseTimeZoneIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateTimeZoneData">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/UpdateTimeZoneData" style="document" />
      <wsdl:input name="UpdateTimeZoneDataRequest">
        <soap:header message="tns:UpdateTimeZoneDataRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateTimeZoneDataRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateTimeZoneDataRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateTimeZoneDataResponse">
        <soap:header message="tns:UpdateTimeZoneDataResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateTimeZoneDataResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateTimeZoneDataResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateTimeZoneDataResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CheckNewTimeZoneDataAvailable">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/CheckNewTimeZoneDataAvailable" style="document" />
      <wsdl:input name="CheckNewTimeZoneDataAvailableRequest">
        <soap:header message="tns:CheckNewTimeZoneDataAvailableRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CheckNewTimeZoneDataAvailableRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CheckNewTimeZoneDataAvailableRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CheckNewTimeZoneDataAvailableResponse">
        <soap:header message="tns:CheckNewTimeZoneDataAvailableResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CheckNewTimeZoneDataAvailableResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CheckNewTimeZoneDataAvailableResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CheckNewTimeZoneDataAvailableResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ToggleActiveTimeZoneRow">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/ToggleActiveTimeZoneRow" style="document" />
      <wsdl:input name="ToggleActiveTimeZoneRowRequest">
        <soap:header message="tns:ToggleActiveTimeZoneRowRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ToggleActiveTimeZoneRowRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ToggleActiveTimeZoneRowRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ToggleActiveTimeZoneRowResponse">
        <soap:header message="tns:ToggleActiveTimeZoneRowResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ToggleActiveTimeZoneRowResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ToggleActiveTimeZoneRowResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ToggleActiveTimeZoneRowResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetActiveTimeZonesByFilter">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/SetActiveTimeZonesByFilter" style="document" />
      <wsdl:input name="SetActiveTimeZonesByFilterRequest">
        <soap:header message="tns:SetActiveTimeZonesByFilterRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetActiveTimeZonesByFilterRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetActiveTimeZonesByFilterRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetActiveTimeZonesByFilterResponse">
        <soap:header message="tns:SetActiveTimeZonesByFilterResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetActiveTimeZonesByFilterResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetActiveTimeZonesByFilterResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetActiveTimeZonesByFilterResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="TimeOfLastTimeZoneUpdate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/TimeOfLastTimeZoneUpdate" style="document" />
      <wsdl:input name="TimeOfLastTimeZoneUpdateRequest">
        <soap:header message="tns:TimeOfLastTimeZoneUpdateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TimeOfLastTimeZoneUpdateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TimeOfLastTimeZoneUpdateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TimeOfLastTimeZoneUpdateResponse">
        <soap:header message="tns:TimeOfLastTimeZoneUpdateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TimeOfLastTimeZoneUpdateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TimeOfLastTimeZoneUpdateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TimeOfLastTimeZoneUpdateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetBaseTimeZoneId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/SetBaseTimeZoneId" style="document" />
      <wsdl:input name="SetBaseTimeZoneIdRequest">
        <soap:header message="tns:SetBaseTimeZoneIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetBaseTimeZoneIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetBaseTimeZoneIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetBaseTimeZoneIdResponse">
        <soap:header message="tns:SetBaseTimeZoneIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetBaseTimeZoneIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetBaseTimeZoneIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetBaseTimeZoneIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDefaultTimeZonePreference">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/GetDefaultTimeZonePreference" style="document" />
      <wsdl:input name="GetDefaultTimeZonePreferenceRequest">
        <soap:header message="tns:GetDefaultTimeZonePreferenceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDefaultTimeZonePreferenceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDefaultTimeZonePreferenceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDefaultTimeZonePreferenceResponse">
        <soap:header message="tns:GetDefaultTimeZonePreferenceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDefaultTimeZonePreferenceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDefaultTimeZonePreferenceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDefaultTimeZonePreferenceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteTimeZones">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/DeleteTimeZones" style="document" />
      <wsdl:input name="DeleteTimeZonesRequest">
        <soap:header message="tns:DeleteTimeZonesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteTimeZonesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteTimeZonesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteTimeZonesResponse">
        <soap:header message="tns:DeleteTimeZonesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteTimeZonesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteTimeZonesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteTimeZonesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetActiveTimeZoneRow">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/TimeZone/SetActiveTimeZoneRow" style="document" />
      <wsdl:input name="SetActiveTimeZoneRowRequest">
        <soap:header message="tns:SetActiveTimeZoneRowRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetActiveTimeZoneRowRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetActiveTimeZoneRowRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetActiveTimeZoneRowResponse">
        <soap:header message="tns:SetActiveTimeZoneRowResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetActiveTimeZoneRowResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetActiveTimeZoneRowResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetActiveTimeZoneRowResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfTimeZoneService">
    <wsdl:port name="BasicHttpBinding_TimeZone" binding="tns:BasicHttpBinding_TimeZone">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services86/TimeZone.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

