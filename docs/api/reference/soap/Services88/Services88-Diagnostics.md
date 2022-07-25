---
generated: 1
uid: wsdl-Services88-Diagnostics
title: Services88.DiagnosticsAgent WSDL
---

# Services88.DiagnosticsAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfDiagnosticsService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="FlushCaches">
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
      <xs:element name="FlushCachesResponse">
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
      <xs:element name="GetCacheNames">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCacheNamesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q1:ArrayOfstring" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FlushCachesByName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CacheNames" nillable="true" type="q2:ArrayOfstring" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FlushCachesByNameResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="LogViewState">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ViewState" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="LogViewStateResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeLogSettings">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LogWarning" type="xs:boolean" />
            <xs:element minOccurs="0" name="LogInformation" type="xs:boolean" />
            <xs:element minOccurs="0" name="LogSuccessAudit" type="xs:boolean" />
            <xs:element minOccurs="0" name="LogFailureAudit" type="xs:boolean" />
            <xs:element minOccurs="0" name="LogToEventLog" type="xs:boolean" />
            <xs:element minOccurs="0" name="LogToSuperOffice" type="xs:boolean" />
            <xs:element minOccurs="0" name="LogToFile" type="xs:boolean" />
            <xs:element minOccurs="0" name="LogToTrace" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeLogSettingsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CollectDataAdditions">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CollectDataAdditionsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CollectWinUsage">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CollectWinUsageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CollectWebUsage">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CollectWebUsageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CollectTableSizes">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CollectTableSizesResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ResyncUsers">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ResyncUsersResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="PerformTasksAfterUpgrade">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="PerformTasksAfterUpgradeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddWebAppUsage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WebAppUsages" nillable="true" type="tns:ArrayOfWebAppUsage" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfWebAppUsage">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="WebAppUsage" nillable="true" type="tns:WebAppUsage" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfWebAppUsage" nillable="true" type="tns:ArrayOfWebAppUsage" />
      <xs:complexType name="WebAppUsage">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="WebAppUsageId" type="xs:int" />
              <xs:element minOccurs="0" name="AssocId" type="xs:int" />
              <xs:element minOccurs="0" name="Timestamp" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ViewState" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AggregateCount" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="AggregateBin" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="Version" type="xs:unsignedInt" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WebAppUsage" nillable="true" type="tns:WebAppUsage" />
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
      <xs:element name="AddWebAppUsageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="WebAppUsageExistsInPeriod">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="ViewState" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="FromDate" type="xs:dateTime" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="WebAppUsageExistsInPeriodResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWebAppUsagesForPeriod">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FromDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="ToDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="SearchTerm" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWebAppUsagesForPeriodResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfWebAppUsage" />
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
  <wsdl:message name="FlushCachesRequest">
    <wsdl:part name="parameters" element="tns:FlushCaches" />
  </wsdl:message>
  <wsdl:message name="FlushCachesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FlushCachesResponse">
    <wsdl:part name="parameters" element="tns:FlushCachesResponse" />
  </wsdl:message>
  <wsdl:message name="FlushCachesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCacheNamesRequest">
    <wsdl:part name="parameters" element="tns:GetCacheNames" />
  </wsdl:message>
  <wsdl:message name="GetCacheNamesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCacheNamesResponse">
    <wsdl:part name="parameters" element="tns:GetCacheNamesResponse" />
  </wsdl:message>
  <wsdl:message name="GetCacheNamesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FlushCachesByNameRequest">
    <wsdl:part name="parameters" element="tns:FlushCachesByName" />
  </wsdl:message>
  <wsdl:message name="FlushCachesByNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FlushCachesByNameResponse">
    <wsdl:part name="parameters" element="tns:FlushCachesByNameResponse" />
  </wsdl:message>
  <wsdl:message name="FlushCachesByNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="LogViewStateRequest">
    <wsdl:part name="parameters" element="tns:LogViewState" />
  </wsdl:message>
  <wsdl:message name="LogViewStateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="LogViewStateResponse">
    <wsdl:part name="parameters" element="tns:LogViewStateResponse" />
  </wsdl:message>
  <wsdl:message name="LogViewStateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeLogSettingsRequest">
    <wsdl:part name="parameters" element="tns:ChangeLogSettings" />
  </wsdl:message>
  <wsdl:message name="ChangeLogSettingsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeLogSettingsResponse">
    <wsdl:part name="parameters" element="tns:ChangeLogSettingsResponse" />
  </wsdl:message>
  <wsdl:message name="ChangeLogSettingsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CollectDataAdditionsRequest">
    <wsdl:part name="parameters" element="tns:CollectDataAdditions" />
  </wsdl:message>
  <wsdl:message name="CollectDataAdditionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CollectDataAdditionsResponse">
    <wsdl:part name="parameters" element="tns:CollectDataAdditionsResponse" />
  </wsdl:message>
  <wsdl:message name="CollectDataAdditionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CollectWinUsageRequest">
    <wsdl:part name="parameters" element="tns:CollectWinUsage" />
  </wsdl:message>
  <wsdl:message name="CollectWinUsageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CollectWinUsageResponse">
    <wsdl:part name="parameters" element="tns:CollectWinUsageResponse" />
  </wsdl:message>
  <wsdl:message name="CollectWinUsageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CollectWebUsageRequest">
    <wsdl:part name="parameters" element="tns:CollectWebUsage" />
  </wsdl:message>
  <wsdl:message name="CollectWebUsageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CollectWebUsageResponse">
    <wsdl:part name="parameters" element="tns:CollectWebUsageResponse" />
  </wsdl:message>
  <wsdl:message name="CollectWebUsageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CollectTableSizesRequest">
    <wsdl:part name="parameters" element="tns:CollectTableSizes" />
  </wsdl:message>
  <wsdl:message name="CollectTableSizesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CollectTableSizesResponse">
    <wsdl:part name="parameters" element="tns:CollectTableSizesResponse" />
  </wsdl:message>
  <wsdl:message name="CollectTableSizesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ResyncUsersRequest">
    <wsdl:part name="parameters" element="tns:ResyncUsers" />
  </wsdl:message>
  <wsdl:message name="ResyncUsersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ResyncUsersResponse">
    <wsdl:part name="parameters" element="tns:ResyncUsersResponse" />
  </wsdl:message>
  <wsdl:message name="ResyncUsersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PerformTasksAfterUpgradeRequest">
    <wsdl:part name="parameters" element="tns:PerformTasksAfterUpgrade" />
  </wsdl:message>
  <wsdl:message name="PerformTasksAfterUpgradeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PerformTasksAfterUpgradeResponse">
    <wsdl:part name="parameters" element="tns:PerformTasksAfterUpgradeResponse" />
  </wsdl:message>
  <wsdl:message name="PerformTasksAfterUpgradeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddWebAppUsageRequest">
    <wsdl:part name="parameters" element="tns:AddWebAppUsage" />
  </wsdl:message>
  <wsdl:message name="AddWebAppUsageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddWebAppUsageResponse">
    <wsdl:part name="parameters" element="tns:AddWebAppUsageResponse" />
  </wsdl:message>
  <wsdl:message name="AddWebAppUsageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="WebAppUsageExistsInPeriodRequest">
    <wsdl:part name="parameters" element="tns:WebAppUsageExistsInPeriod" />
  </wsdl:message>
  <wsdl:message name="WebAppUsageExistsInPeriodRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="WebAppUsageExistsInPeriodResponse">
    <wsdl:part name="parameters" element="tns:WebAppUsageExistsInPeriodResponse" />
  </wsdl:message>
  <wsdl:message name="WebAppUsageExistsInPeriodResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWebAppUsagesForPeriodRequest">
    <wsdl:part name="parameters" element="tns:GetWebAppUsagesForPeriod" />
  </wsdl:message>
  <wsdl:message name="GetWebAppUsagesForPeriodRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWebAppUsagesForPeriodResponse">
    <wsdl:part name="parameters" element="tns:GetWebAppUsagesForPeriodResponse" />
  </wsdl:message>
  <wsdl:message name="GetWebAppUsagesForPeriodResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Diagnostics">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Diagnostics</summary>
    </wsdl:documentation>
    <wsdl:operation name="FlushCaches">
      <wsdl:documentation>
        <summary>Flushes all NetServer caches</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/FlushCaches" name="FlushCachesRequest" message="tns:FlushCachesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/FlushCachesResponse" name="FlushCachesResponse" message="tns:FlushCachesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCacheNames">
      <wsdl:documentation>
        <summary>Get the name of the caches that can be flushed</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetCacheNames" name="GetCacheNamesRequest" message="tns:GetCacheNamesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetCacheNamesResponse" name="GetCacheNamesResponse" message="tns:GetCacheNamesResponse" />
    </wsdl:operation>
    <wsdl:operation name="FlushCachesByName">
      <wsdl:documentation>
        <summary>Flushes all NetServer caches named</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/FlushCachesByName" name="FlushCachesByNameRequest" message="tns:FlushCachesByNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/FlushCachesByNameResponse" name="FlushCachesByNameResponse" message="tns:FlushCachesByNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="LogViewState">
      <wsdl:documentation>
        <summary>Log a change in view state. The granularity of the logging depends on the current configuration. This call returns asynchronously, leaving the server to finish processing later on.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/LogViewState" name="LogViewStateRequest" message="tns:LogViewStateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/LogViewStateResponse" name="LogViewStateResponse" message="tns:LogViewStateResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChangeLogSettings">
      <wsdl:documentation>
        <summary>Change NetServer log settings.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/ChangeLogSettings" name="ChangeLogSettingsRequest" message="tns:ChangeLogSettingsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/ChangeLogSettingsResponse" name="ChangeLogSettingsResponse" message="tns:ChangeLogSettingsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CollectDataAdditions">
      <wsdl:documentation>
        <summary>Collect and transmit usage statistics: Database Additions. If opted-out then this call does nothing. The call returns immediately (starting a background thread), and updates CS scheduler table to set the next run time.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectDataAdditions" name="CollectDataAdditionsRequest" message="tns:CollectDataAdditionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectDataAdditionsResponse" name="CollectDataAdditionsResponse" message="tns:CollectDataAdditionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CollectWinUsage">
      <wsdl:documentation>
        <summary>Collect and transmit usage statistics: Windows CRM Client Usage. If opted-out then this call does nothing. The call returns immediately (starting a background thread), and updates CS scheduler table to set the next run time.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectWinUsage" name="CollectWinUsageRequest" message="tns:CollectWinUsageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectWinUsageResponse" name="CollectWinUsageResponse" message="tns:CollectWinUsageResponse" />
    </wsdl:operation>
    <wsdl:operation name="CollectWebUsage">
      <wsdl:documentation>
        <summary>Collect and transmit usage statistics: Web-based clients Usage. If opted-out then this call does nothing. The call returns immediately (starting a background thread), and updates CS scheduler table to set the next run time.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectWebUsage" name="CollectWebUsageRequest" message="tns:CollectWebUsageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectWebUsageResponse" name="CollectWebUsageResponse" message="tns:CollectWebUsageResponse" />
    </wsdl:operation>
    <wsdl:operation name="CollectTableSizes">
      <wsdl:documentation>
        <summary>Collect and transmit usage statistics: Table Sizes. If opted-out then this call does nothing. The call returns immediately (starting a background thread), and updates CS scheduler table to set the next run time.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectTableSizes" name="CollectTableSizesRequest" message="tns:CollectTableSizesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectTableSizesResponse" name="CollectTableSizesResponse" message="tns:CollectTableSizesResponse" />
    </wsdl:operation>
    <wsdl:operation name="ResyncUsers">
      <wsdl:documentation>
        <summary>Resynchronize user information with SuperOffice Community, if opted-out then this call does nothing. The call returns immediately (starting a background thread), and updates CS scheduler table to set the next run time.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/ResyncUsers" name="ResyncUsersRequest" message="tns:ResyncUsersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/ResyncUsersResponse" name="ResyncUsersResponse" message="tns:ResyncUsersResponse" />
    </wsdl:operation>
    <wsdl:operation name="PerformTasksAfterUpgrade">
      <wsdl:documentation>
        <summary>After upgrading to a new fileset, there may be tasks that need to be done. Examples - import new TypicalSearches, if present. Tasks performed here need to be idempotent and independent of the actual upgrade jump (what was the previous version). They should complete in a reasonable time, not more than a few minutes maximum.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/PerformTasksAfterUpgrade" name="PerformTasksAfterUpgradeRequest" message="tns:PerformTasksAfterUpgradeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/PerformTasksAfterUpgradeResponse" name="PerformTasksAfterUpgradeResponse" message="tns:PerformTasksAfterUpgradeResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddWebAppUsage">
      <wsdl:documentation>
        <summary>Adds WebApp usage to existing log</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/AddWebAppUsage" name="AddWebAppUsageRequest" message="tns:AddWebAppUsageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/AddWebAppUsageResponse" name="AddWebAppUsageResponse" message="tns:AddWebAppUsageResponse" />
    </wsdl:operation>
    <wsdl:operation name="WebAppUsageExistsInPeriod">
      <wsdl:documentation>
        <summary>Returns true if viewState has been clicked at least once since FromDate, if asscoiateId &lt; 0 or FromDate is DateTime.MinValue no restriction given for those parameters</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/WebAppUsageExistsInPeriod" name="WebAppUsageExistsInPeriodRequest" message="tns:WebAppUsageExistsInPeriodRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/WebAppUsageExistsInPeriodResponse" name="WebAppUsageExistsInPeriodResponse" message="tns:WebAppUsageExistsInPeriodResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetWebAppUsagesForPeriod">
      <wsdl:documentation>
        <summary>Get all WebAppUsages for a given period, that match an optional search term</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetWebAppUsagesForPeriod" name="GetWebAppUsagesForPeriodRequest" message="tns:GetWebAppUsagesForPeriodRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetWebAppUsagesForPeriodResponse" name="GetWebAppUsagesForPeriodResponse" message="tns:GetWebAppUsagesForPeriodResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Diagnostics" type="tns:Diagnostics">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="FlushCaches">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/FlushCaches" style="document" />
      <wsdl:input name="FlushCachesRequest">
        <soap:header message="tns:FlushCachesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FlushCachesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FlushCachesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FlushCachesResponse">
        <soap:header message="tns:FlushCachesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FlushCachesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FlushCachesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FlushCachesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCacheNames">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetCacheNames" style="document" />
      <wsdl:input name="GetCacheNamesRequest">
        <soap:header message="tns:GetCacheNamesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCacheNamesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCacheNamesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCacheNamesResponse">
        <soap:header message="tns:GetCacheNamesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCacheNamesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCacheNamesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCacheNamesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FlushCachesByName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/FlushCachesByName" style="document" />
      <wsdl:input name="FlushCachesByNameRequest">
        <soap:header message="tns:FlushCachesByNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FlushCachesByNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FlushCachesByNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FlushCachesByNameResponse">
        <soap:header message="tns:FlushCachesByNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FlushCachesByNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FlushCachesByNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FlushCachesByNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="LogViewState">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/LogViewState" style="document" />
      <wsdl:input name="LogViewStateRequest">
        <soap:header message="tns:LogViewStateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:LogViewStateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:LogViewStateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="LogViewStateResponse">
        <soap:header message="tns:LogViewStateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:LogViewStateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:LogViewStateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:LogViewStateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChangeLogSettings">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/ChangeLogSettings" style="document" />
      <wsdl:input name="ChangeLogSettingsRequest">
        <soap:header message="tns:ChangeLogSettingsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChangeLogSettingsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChangeLogSettingsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChangeLogSettingsResponse">
        <soap:header message="tns:ChangeLogSettingsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChangeLogSettingsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChangeLogSettingsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChangeLogSettingsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CollectDataAdditions">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectDataAdditions" style="document" />
      <wsdl:input name="CollectDataAdditionsRequest">
        <soap:header message="tns:CollectDataAdditionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CollectDataAdditionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CollectDataAdditionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CollectDataAdditionsResponse">
        <soap:header message="tns:CollectDataAdditionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CollectDataAdditionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CollectDataAdditionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CollectDataAdditionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CollectWinUsage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectWinUsage" style="document" />
      <wsdl:input name="CollectWinUsageRequest">
        <soap:header message="tns:CollectWinUsageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CollectWinUsageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CollectWinUsageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CollectWinUsageResponse">
        <soap:header message="tns:CollectWinUsageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CollectWinUsageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CollectWinUsageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CollectWinUsageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CollectWebUsage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectWebUsage" style="document" />
      <wsdl:input name="CollectWebUsageRequest">
        <soap:header message="tns:CollectWebUsageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CollectWebUsageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CollectWebUsageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CollectWebUsageResponse">
        <soap:header message="tns:CollectWebUsageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CollectWebUsageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CollectWebUsageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CollectWebUsageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CollectTableSizes">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectTableSizes" style="document" />
      <wsdl:input name="CollectTableSizesRequest">
        <soap:header message="tns:CollectTableSizesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CollectTableSizesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CollectTableSizesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CollectTableSizesResponse">
        <soap:header message="tns:CollectTableSizesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CollectTableSizesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CollectTableSizesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CollectTableSizesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ResyncUsers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/ResyncUsers" style="document" />
      <wsdl:input name="ResyncUsersRequest">
        <soap:header message="tns:ResyncUsersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ResyncUsersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ResyncUsersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ResyncUsersResponse">
        <soap:header message="tns:ResyncUsersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ResyncUsersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ResyncUsersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ResyncUsersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="PerformTasksAfterUpgrade">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/PerformTasksAfterUpgrade" style="document" />
      <wsdl:input name="PerformTasksAfterUpgradeRequest">
        <soap:header message="tns:PerformTasksAfterUpgradeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:PerformTasksAfterUpgradeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:PerformTasksAfterUpgradeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="PerformTasksAfterUpgradeResponse">
        <soap:header message="tns:PerformTasksAfterUpgradeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:PerformTasksAfterUpgradeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:PerformTasksAfterUpgradeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:PerformTasksAfterUpgradeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddWebAppUsage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/AddWebAppUsage" style="document" />
      <wsdl:input name="AddWebAppUsageRequest">
        <soap:header message="tns:AddWebAppUsageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddWebAppUsageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddWebAppUsageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddWebAppUsageResponse">
        <soap:header message="tns:AddWebAppUsageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddWebAppUsageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddWebAppUsageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddWebAppUsageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="WebAppUsageExistsInPeriod">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/WebAppUsageExistsInPeriod" style="document" />
      <wsdl:input name="WebAppUsageExistsInPeriodRequest">
        <soap:header message="tns:WebAppUsageExistsInPeriodRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:WebAppUsageExistsInPeriodRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:WebAppUsageExistsInPeriodRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="WebAppUsageExistsInPeriodResponse">
        <soap:header message="tns:WebAppUsageExistsInPeriodResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:WebAppUsageExistsInPeriodResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:WebAppUsageExistsInPeriodResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:WebAppUsageExistsInPeriodResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetWebAppUsagesForPeriod">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetWebAppUsagesForPeriod" style="document" />
      <wsdl:input name="GetWebAppUsagesForPeriodRequest">
        <soap:header message="tns:GetWebAppUsagesForPeriodRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetWebAppUsagesForPeriodRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetWebAppUsagesForPeriodRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetWebAppUsagesForPeriodResponse">
        <soap:header message="tns:GetWebAppUsagesForPeriodResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetWebAppUsagesForPeriodResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetWebAppUsagesForPeriodResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetWebAppUsagesForPeriodResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfDiagnosticsService">
    <wsdl:port name="BasicHttpBinding_Diagnostics" binding="tns:BasicHttpBinding_Diagnostics">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/Diagnostics.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```
