---
Generated: 1
TOCExclude: 1
title: Services81.ViewStateAgent WSDL
---

# Services81.ViewStateAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfViewStateService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services81" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services81" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services81" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="GetHistory">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="HistoryId" type="xs:int" />
          </xs:sequence>
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
      <xs:element name="GetHistoryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:History" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="History">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="HistoryName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="HistoryId" type="xs:int" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ItemInfo" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="History" nillable="true" type="tns:History" />
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
      <xs:element name="GetCurrent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="HistoryName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCurrentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:History" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCurrent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Current" nillable="true" type="tns:History" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCurrentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:History" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNextCurrent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="HistoryName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Id" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNextCurrentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:History" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreviousCurrent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="HistoryName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Id" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreviousCurrentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:History" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteHistory">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="HistoryName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Id" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteHistoryResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetHistories">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetHistoriesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfHistory" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfHistory">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="History" nillable="true" type="tns:History" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfHistory" nillable="true" type="tns:ArrayOfHistory" />
      <xs:element name="GetHistoriesByName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="HistoryName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetHistoriesByNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfHistory" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetHistoriesByNames">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="HistoryNames" nillable="true" type="q1:ArrayOfstring" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetHistoriesByNamesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfHistory" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveHistories">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="HistoryName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="History" nillable="true" type="tns:ArrayOfHistory" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveHistoriesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfHistory" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetHistoryLengthPrefValue">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetHistoryLengthPrefValueResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetHistoryLengthPrefValue">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Length" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetHistoryLengthPrefValueResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCurrents">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Currents" nillable="true" type="tns:ArrayOfHistory" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCurrentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfHistory" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetHistoriesByNamesAndIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Requests" nillable="true" type="tns:ArrayOfHistoryRequest" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfHistoryRequest">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="HistoryRequest" nillable="true" type="tns:HistoryRequest" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfHistoryRequest" nillable="true" type="tns:ArrayOfHistoryRequest" />
      <xs:complexType name="HistoryRequest">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="EntityName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EntityOrParentId" type="xs:int" />
              <xs:element minOccurs="0" name="RequestForNewRecord" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="HistoryRequest" nillable="true" type="tns:HistoryRequest" />
      <xs:element name="GetHistoriesByNamesAndIdsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfHistory" />
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
  <wsdl:message name="GetHistoryRequest">
    <wsdl:part name="parameters" element="tns:GetHistory" />
  </wsdl:message>
  <wsdl:message name="GetHistoryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHistoryResponse">
    <wsdl:part name="parameters" element="tns:GetHistoryResponse" />
  </wsdl:message>
  <wsdl:message name="GetHistoryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCurrentRequest">
    <wsdl:part name="parameters" element="tns:GetCurrent" />
  </wsdl:message>
  <wsdl:message name="GetCurrentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCurrentResponse">
    <wsdl:part name="parameters" element="tns:GetCurrentResponse" />
  </wsdl:message>
  <wsdl:message name="GetCurrentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCurrentRequest">
    <wsdl:part name="parameters" element="tns:SaveCurrent" />
  </wsdl:message>
  <wsdl:message name="SaveCurrentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCurrentResponse">
    <wsdl:part name="parameters" element="tns:SaveCurrentResponse" />
  </wsdl:message>
  <wsdl:message name="SaveCurrentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextCurrentRequest">
    <wsdl:part name="parameters" element="tns:GetNextCurrent" />
  </wsdl:message>
  <wsdl:message name="GetNextCurrentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextCurrentResponse">
    <wsdl:part name="parameters" element="tns:GetNextCurrentResponse" />
  </wsdl:message>
  <wsdl:message name="GetNextCurrentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreviousCurrentRequest">
    <wsdl:part name="parameters" element="tns:GetPreviousCurrent" />
  </wsdl:message>
  <wsdl:message name="GetPreviousCurrentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreviousCurrentResponse">
    <wsdl:part name="parameters" element="tns:GetPreviousCurrentResponse" />
  </wsdl:message>
  <wsdl:message name="GetPreviousCurrentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteHistoryRequest">
    <wsdl:part name="parameters" element="tns:DeleteHistory" />
  </wsdl:message>
  <wsdl:message name="DeleteHistoryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteHistoryResponse">
    <wsdl:part name="parameters" element="tns:DeleteHistoryResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteHistoryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHistoriesRequest">
    <wsdl:part name="parameters" element="tns:GetHistories" />
  </wsdl:message>
  <wsdl:message name="GetHistoriesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHistoriesResponse">
    <wsdl:part name="parameters" element="tns:GetHistoriesResponse" />
  </wsdl:message>
  <wsdl:message name="GetHistoriesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHistoriesByNameRequest">
    <wsdl:part name="parameters" element="tns:GetHistoriesByName" />
  </wsdl:message>
  <wsdl:message name="GetHistoriesByNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHistoriesByNameResponse">
    <wsdl:part name="parameters" element="tns:GetHistoriesByNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetHistoriesByNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHistoriesByNamesRequest">
    <wsdl:part name="parameters" element="tns:GetHistoriesByNames" />
  </wsdl:message>
  <wsdl:message name="GetHistoriesByNamesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHistoriesByNamesResponse">
    <wsdl:part name="parameters" element="tns:GetHistoriesByNamesResponse" />
  </wsdl:message>
  <wsdl:message name="GetHistoriesByNamesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveHistoriesRequest">
    <wsdl:part name="parameters" element="tns:SaveHistories" />
  </wsdl:message>
  <wsdl:message name="SaveHistoriesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveHistoriesResponse">
    <wsdl:part name="parameters" element="tns:SaveHistoriesResponse" />
  </wsdl:message>
  <wsdl:message name="SaveHistoriesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHistoryLengthPrefValueRequest">
    <wsdl:part name="parameters" element="tns:GetHistoryLengthPrefValue" />
  </wsdl:message>
  <wsdl:message name="GetHistoryLengthPrefValueRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHistoryLengthPrefValueResponse">
    <wsdl:part name="parameters" element="tns:GetHistoryLengthPrefValueResponse" />
  </wsdl:message>
  <wsdl:message name="GetHistoryLengthPrefValueResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetHistoryLengthPrefValueRequest">
    <wsdl:part name="parameters" element="tns:SetHistoryLengthPrefValue" />
  </wsdl:message>
  <wsdl:message name="SetHistoryLengthPrefValueRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetHistoryLengthPrefValueResponse">
    <wsdl:part name="parameters" element="tns:SetHistoryLengthPrefValueResponse" />
  </wsdl:message>
  <wsdl:message name="SetHistoryLengthPrefValueResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCurrentsRequest">
    <wsdl:part name="parameters" element="tns:SaveCurrents" />
  </wsdl:message>
  <wsdl:message name="SaveCurrentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCurrentsResponse">
    <wsdl:part name="parameters" element="tns:SaveCurrentsResponse" />
  </wsdl:message>
  <wsdl:message name="SaveCurrentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHistoriesByNamesAndIdsRequest">
    <wsdl:part name="parameters" element="tns:GetHistoriesByNamesAndIds" />
  </wsdl:message>
  <wsdl:message name="GetHistoriesByNamesAndIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHistoriesByNamesAndIdsResponse">
    <wsdl:part name="parameters" element="tns:GetHistoriesByNamesAndIdsResponse" />
  </wsdl:message>
  <wsdl:message name="GetHistoriesByNamesAndIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="ViewState">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for ViewState</summary>
    </wsdl:documentation>
    <wsdl:operation name="GetHistory">
      <wsdl:documentation>
        <summary>Gets a History object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetHistory" name="GetHistoryRequest" message="tns:GetHistoryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetHistoryResponse" name="GetHistoryResponse" message="tns:GetHistoryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCurrent">
      <wsdl:documentation>
        <summary>Get the current (most recent) value of the history list. This is the item with rank = 1. If no item exists a default value is returned. This is usually the first item in the table representing the history list.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetCurrent" name="GetCurrentRequest" message="tns:GetCurrentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetCurrentResponse" name="GetCurrentResponse" message="tns:GetCurrentResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveCurrent">
      <wsdl:documentation>
        <summary>Saving the current history item. This history item is saved with Rank = 1, and all the remaining elements rank values are shifted one down. The list is maintained with the max lenght of the History list length preference.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/SaveCurrent" name="SaveCurrentRequest" message="tns:SaveCurrentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/SaveCurrentResponse" name="SaveCurrentResponse" message="tns:SaveCurrentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNextCurrent">
      <wsdl:documentation>
        <summary>Returns the next current item. If no item exists a default value is returned. This is usually the first item in the table representing the history list.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetNextCurrent" name="GetNextCurrentRequest" message="tns:GetNextCurrentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetNextCurrentResponse" name="GetNextCurrentResponse" message="tns:GetNextCurrentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPreviousCurrent">
      <wsdl:documentation>
        <summary>Returns the previous current item. If no item exists a default value is returned. This is usually the first item in the table representing the history list.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetPreviousCurrent" name="GetPreviousCurrentRequest" message="tns:GetPreviousCurrentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetPreviousCurrentResponse" name="GetPreviousCurrentResponse" message="tns:GetPreviousCurrentResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteHistory">
      <wsdl:documentation>
        <summary>Deletes the history element</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/DeleteHistory" name="DeleteHistoryRequest" message="tns:DeleteHistoryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/DeleteHistoryResponse" name="DeleteHistoryResponse" message="tns:DeleteHistoryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetHistories">
      <wsdl:documentation>
        <summary>Returns all history items that belong to the currently logged in user</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetHistories" name="GetHistoriesRequest" message="tns:GetHistoriesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetHistoriesResponse" name="GetHistoriesResponse" message="tns:GetHistoriesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetHistoriesByName">
      <wsdl:documentation>
        <summary>Returns the named history list that belong to the currently logged in user</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetHistoriesByName" name="GetHistoriesByNameRequest" message="tns:GetHistoriesByNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetHistoriesByNameResponse" name="GetHistoriesByNameResponse" message="tns:GetHistoriesByNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetHistoriesByNames">
      <wsdl:documentation>
        <summary>Returns the named history lists that belong to the currently logged in user</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetHistoriesByNames" name="GetHistoriesByNamesRequest" message="tns:GetHistoriesByNamesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetHistoriesByNamesResponse" name="GetHistoriesByNamesResponse" message="tns:GetHistoriesByNamesResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveHistories">
      <wsdl:documentation>
        <summary>Replaces the existing history-list for the currently logged in user. All elements must belong to the same history list. If not they are ignored.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/SaveHistories" name="SaveHistoriesRequest" message="tns:SaveHistoriesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/SaveHistoriesResponse" name="SaveHistoriesResponse" message="tns:SaveHistoriesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetHistoryLengthPrefValue">
      <wsdl:documentation>
        <summary>Get the logged on user's preferred history list length. Will return the system preference if no user preferences are available.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetHistoryLengthPrefValue" name="GetHistoryLengthPrefValueRequest" message="tns:GetHistoryLengthPrefValueRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetHistoryLengthPrefValueResponse" name="GetHistoryLengthPrefValueResponse" message="tns:GetHistoryLengthPrefValueResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetHistoryLengthPrefValue">
      <wsdl:documentation>
        <summary>Set the logged on user's preferred history list length.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/SetHistoryLengthPrefValue" name="SetHistoryLengthPrefValueRequest" message="tns:SetHistoryLengthPrefValueRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/SetHistoryLengthPrefValueResponse" name="SetHistoryLengthPrefValueResponse" message="tns:SetHistoryLengthPrefValueResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveCurrents">
      <wsdl:documentation>
        <summary>Saves the history elements as the current value for their respective lists. If more than one item is submitted for the same list, they are added sequently, meaning that the last one is the most current.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/SaveCurrents" name="SaveCurrentsRequest" message="tns:SaveCurrentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/SaveCurrentsResponse" name="SaveCurrentsResponse" message="tns:SaveCurrentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetHistoriesByNamesAndIds">
      <wsdl:documentation>
        <summary>Returns history data for the named entities and the given ids - which may not directly correspond to the current history records in the database.&lt;para/&gt;Use this method if you know exactly which items you need, regardless of whether they are in the current history or not.&lt;para/&gt;The history in the database is not changed or even looked at by this method.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetHistoriesByNamesAndIds" name="GetHistoriesByNamesAndIdsRequest" message="tns:GetHistoriesByNamesAndIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetHistoriesByNamesAndIdsResponse" name="GetHistoriesByNamesAndIdsResponse" message="tns:GetHistoriesByNamesAndIdsResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_ViewState" type="tns:ViewState">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="GetHistory">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetHistory" style="document" />
      <wsdl:input name="GetHistoryRequest">
        <soap:header message="tns:GetHistoryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetHistoryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetHistoryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetHistoryResponse">
        <soap:header message="tns:GetHistoryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetHistoryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetHistoryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetHistoryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCurrent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetCurrent" style="document" />
      <wsdl:input name="GetCurrentRequest">
        <soap:header message="tns:GetCurrentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCurrentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCurrentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCurrentResponse">
        <soap:header message="tns:GetCurrentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCurrentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCurrentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCurrentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveCurrent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/SaveCurrent" style="document" />
      <wsdl:input name="SaveCurrentRequest">
        <soap:header message="tns:SaveCurrentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveCurrentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveCurrentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveCurrentResponse">
        <soap:header message="tns:SaveCurrentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveCurrentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveCurrentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveCurrentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNextCurrent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetNextCurrent" style="document" />
      <wsdl:input name="GetNextCurrentRequest">
        <soap:header message="tns:GetNextCurrentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNextCurrentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNextCurrentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNextCurrentResponse">
        <soap:header message="tns:GetNextCurrentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNextCurrentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNextCurrentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNextCurrentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPreviousCurrent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetPreviousCurrent" style="document" />
      <wsdl:input name="GetPreviousCurrentRequest">
        <soap:header message="tns:GetPreviousCurrentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPreviousCurrentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPreviousCurrentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPreviousCurrentResponse">
        <soap:header message="tns:GetPreviousCurrentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPreviousCurrentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPreviousCurrentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPreviousCurrentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteHistory">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/DeleteHistory" style="document" />
      <wsdl:input name="DeleteHistoryRequest">
        <soap:header message="tns:DeleteHistoryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteHistoryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteHistoryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteHistoryResponse">
        <soap:header message="tns:DeleteHistoryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteHistoryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteHistoryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteHistoryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetHistories">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetHistories" style="document" />
      <wsdl:input name="GetHistoriesRequest">
        <soap:header message="tns:GetHistoriesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetHistoriesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetHistoriesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetHistoriesResponse">
        <soap:header message="tns:GetHistoriesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetHistoriesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetHistoriesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetHistoriesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetHistoriesByName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetHistoriesByName" style="document" />
      <wsdl:input name="GetHistoriesByNameRequest">
        <soap:header message="tns:GetHistoriesByNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetHistoriesByNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetHistoriesByNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetHistoriesByNameResponse">
        <soap:header message="tns:GetHistoriesByNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetHistoriesByNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetHistoriesByNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetHistoriesByNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetHistoriesByNames">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetHistoriesByNames" style="document" />
      <wsdl:input name="GetHistoriesByNamesRequest">
        <soap:header message="tns:GetHistoriesByNamesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetHistoriesByNamesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetHistoriesByNamesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetHistoriesByNamesResponse">
        <soap:header message="tns:GetHistoriesByNamesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetHistoriesByNamesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetHistoriesByNamesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetHistoriesByNamesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveHistories">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/SaveHistories" style="document" />
      <wsdl:input name="SaveHistoriesRequest">
        <soap:header message="tns:SaveHistoriesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveHistoriesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveHistoriesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveHistoriesResponse">
        <soap:header message="tns:SaveHistoriesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveHistoriesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveHistoriesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveHistoriesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetHistoryLengthPrefValue">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetHistoryLengthPrefValue" style="document" />
      <wsdl:input name="GetHistoryLengthPrefValueRequest">
        <soap:header message="tns:GetHistoryLengthPrefValueRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetHistoryLengthPrefValueRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetHistoryLengthPrefValueRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetHistoryLengthPrefValueResponse">
        <soap:header message="tns:GetHistoryLengthPrefValueResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetHistoryLengthPrefValueResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetHistoryLengthPrefValueResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetHistoryLengthPrefValueResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetHistoryLengthPrefValue">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/SetHistoryLengthPrefValue" style="document" />
      <wsdl:input name="SetHistoryLengthPrefValueRequest">
        <soap:header message="tns:SetHistoryLengthPrefValueRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetHistoryLengthPrefValueRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetHistoryLengthPrefValueRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetHistoryLengthPrefValueResponse">
        <soap:header message="tns:SetHistoryLengthPrefValueResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetHistoryLengthPrefValueResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetHistoryLengthPrefValueResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetHistoryLengthPrefValueResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveCurrents">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/SaveCurrents" style="document" />
      <wsdl:input name="SaveCurrentsRequest">
        <soap:header message="tns:SaveCurrentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveCurrentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveCurrentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveCurrentsResponse">
        <soap:header message="tns:SaveCurrentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveCurrentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveCurrentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveCurrentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetHistoriesByNamesAndIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/ViewState/GetHistoriesByNamesAndIds" style="document" />
      <wsdl:input name="GetHistoriesByNamesAndIdsRequest">
        <soap:header message="tns:GetHistoriesByNamesAndIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetHistoriesByNamesAndIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetHistoriesByNamesAndIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetHistoriesByNamesAndIdsResponse">
        <soap:header message="tns:GetHistoriesByNamesAndIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetHistoriesByNamesAndIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetHistoriesByNamesAndIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetHistoriesByNamesAndIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfViewStateService">
    <wsdl:port name="BasicHttpBinding_ViewState" binding="tns:BasicHttpBinding_ViewState">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services81/ViewState.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

