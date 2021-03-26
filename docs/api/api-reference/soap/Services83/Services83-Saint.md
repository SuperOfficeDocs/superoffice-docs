---
Generated: 1
TOCExclude: 1
title: Services83.SaintAgent WSDL
---

# Services83.SaintAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfSaintService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services83" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services83" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services83" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultStatusMonitor">
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
      <xs:element name="CreateDefaultStatusMonitorResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:StatusMonitor" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="StatusMonitor">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="OwnerTable" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="DefaultTask" type="xs:int" />
              <xs:element minOccurs="0" name="DefaultTaskText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsVisual" type="xs:boolean" />
              <xs:element minOccurs="0" name="LastGenerated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StatusMonitorId" type="xs:int" />
              <xs:element minOccurs="0" name="PictureId" type="xs:int" />
              <xs:element minOccurs="0" name="NeedsUpdate" type="xs:boolean" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="NumMatches" type="xs:int" />
              <xs:element minOccurs="0" name="NumNeedUpdate" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="StatusMonitor" nillable="true" type="tns:StatusMonitor" />
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
      <xs:element name="SaveStatusMonitor">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StatusMonitor" nillable="true" type="tns:StatusMonitor" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveStatusMonitorResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:StatusMonitor" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultStatusMonitorPeriods">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultStatusMonitorPeriodsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:StatusMonitorPeriods" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="StatusMonitorPeriods">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Period1" type="xs:int" />
              <xs:element minOccurs="0" name="Period2" type="xs:int" />
              <xs:element minOccurs="0" name="Period3" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="StatusMonitorPeriods" nillable="true" type="tns:StatusMonitorPeriods" />
      <xs:element name="SaveStatusMonitorPeriods">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StatusMonitorPeriods" nillable="true" type="tns:StatusMonitorPeriods" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveStatusMonitorPeriodsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:StatusMonitorPeriods" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetStatusMonitors">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetStatusMonitorsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfStatusMonitor" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfStatusMonitor">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="StatusMonitor" nillable="true" type="tns:StatusMonitor" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfStatusMonitor" nillable="true" type="tns:ArrayOfStatusMonitor" />
      <xs:element name="GetStatusMonitor">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetStatusMonitorResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:StatusMonitor" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RegenerateStatusMonitors">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RunAsBatch" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RegenerateStatusMonitorsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:BatchTaskInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="BatchTaskInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="DetailsTable" type="xs:short" />
              <xs:element minOccurs="0" name="DetailsRecord" type="xs:int" />
              <xs:element minOccurs="0" name="IsSystemTask" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsInternalTask" type="xs:boolean" />
              <xs:element minOccurs="0" name="ParameterObject" nillable="true" type="tns:StringDictionary" />
              <xs:element minOccurs="0" name="LastStarted" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Created" type="xs:dateTime" />
              <xs:element minOccurs="0" name="StartCount" type="xs:int" />
              <xs:element minOccurs="0" name="DatabaseSerialNumber" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Result" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="State" type="tns:BatchTaskState" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Request" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProgressDescription" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProgressPercent" type="xs:short" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="BatchTaskInfo" nillable="true" type="tns:BatchTaskInfo" />
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
      <xs:simpleType name="BatchTaskState">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="New" />
          <xs:enumeration value="Aquired" />
          <xs:enumeration value="Started" />
          <xs:enumeration value="Succeeded" />
          <xs:enumeration value="Failed" />
          <xs:enumeration value="All">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">99999</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="BatchTaskState" nillable="true" type="tns:BatchTaskState" />
      <xs:element name="SetRankOnStatusMonitors">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ItemsIds" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetRankOnStatusMonitorsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RegenerateStatusMonitor">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StatusMonitorId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RegenerateStatusMonitorResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RegenerateCounters">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RunAsBatch" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RegenerateCountersResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:BatchTaskInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetStatusMonitorPeriods">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetStatusMonitorPeriodsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:StatusMonitorPeriods" />
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
      <xs:complexType name="ArrayOfint">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="int" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfint" nillable="true" type="tns:ArrayOfint" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="CreateDefaultStatusMonitorRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultStatusMonitor" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultStatusMonitorRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultStatusMonitorResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultStatusMonitorResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultStatusMonitorResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveStatusMonitorRequest">
    <wsdl:part name="parameters" element="tns:SaveStatusMonitor" />
  </wsdl:message>
  <wsdl:message name="SaveStatusMonitorRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveStatusMonitorResponse">
    <wsdl:part name="parameters" element="tns:SaveStatusMonitorResponse" />
  </wsdl:message>
  <wsdl:message name="SaveStatusMonitorResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultStatusMonitorPeriodsRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultStatusMonitorPeriods" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultStatusMonitorPeriodsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultStatusMonitorPeriodsResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultStatusMonitorPeriodsResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultStatusMonitorPeriodsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveStatusMonitorPeriodsRequest">
    <wsdl:part name="parameters" element="tns:SaveStatusMonitorPeriods" />
  </wsdl:message>
  <wsdl:message name="SaveStatusMonitorPeriodsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveStatusMonitorPeriodsResponse">
    <wsdl:part name="parameters" element="tns:SaveStatusMonitorPeriodsResponse" />
  </wsdl:message>
  <wsdl:message name="SaveStatusMonitorPeriodsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetStatusMonitorsRequest">
    <wsdl:part name="parameters" element="tns:GetStatusMonitors" />
  </wsdl:message>
  <wsdl:message name="GetStatusMonitorsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetStatusMonitorsResponse">
    <wsdl:part name="parameters" element="tns:GetStatusMonitorsResponse" />
  </wsdl:message>
  <wsdl:message name="GetStatusMonitorsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetStatusMonitorRequest">
    <wsdl:part name="parameters" element="tns:GetStatusMonitor" />
  </wsdl:message>
  <wsdl:message name="GetStatusMonitorRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetStatusMonitorResponse">
    <wsdl:part name="parameters" element="tns:GetStatusMonitorResponse" />
  </wsdl:message>
  <wsdl:message name="GetStatusMonitorResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RegenerateStatusMonitorsRequest">
    <wsdl:part name="parameters" element="tns:RegenerateStatusMonitors" />
  </wsdl:message>
  <wsdl:message name="RegenerateStatusMonitorsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RegenerateStatusMonitorsResponse">
    <wsdl:part name="parameters" element="tns:RegenerateStatusMonitorsResponse" />
  </wsdl:message>
  <wsdl:message name="RegenerateStatusMonitorsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetRankOnStatusMonitorsRequest">
    <wsdl:part name="parameters" element="tns:SetRankOnStatusMonitors" />
  </wsdl:message>
  <wsdl:message name="SetRankOnStatusMonitorsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetRankOnStatusMonitorsResponse">
    <wsdl:part name="parameters" element="tns:SetRankOnStatusMonitorsResponse" />
  </wsdl:message>
  <wsdl:message name="SetRankOnStatusMonitorsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RegenerateStatusMonitorRequest">
    <wsdl:part name="parameters" element="tns:RegenerateStatusMonitor" />
  </wsdl:message>
  <wsdl:message name="RegenerateStatusMonitorRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RegenerateStatusMonitorResponse">
    <wsdl:part name="parameters" element="tns:RegenerateStatusMonitorResponse" />
  </wsdl:message>
  <wsdl:message name="RegenerateStatusMonitorResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RegenerateCountersRequest">
    <wsdl:part name="parameters" element="tns:RegenerateCounters" />
  </wsdl:message>
  <wsdl:message name="RegenerateCountersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RegenerateCountersResponse">
    <wsdl:part name="parameters" element="tns:RegenerateCountersResponse" />
  </wsdl:message>
  <wsdl:message name="RegenerateCountersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetStatusMonitorPeriodsRequest">
    <wsdl:part name="parameters" element="tns:GetStatusMonitorPeriods" />
  </wsdl:message>
  <wsdl:message name="GetStatusMonitorPeriodsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetStatusMonitorPeriodsResponse">
    <wsdl:part name="parameters" element="tns:GetStatusMonitorPeriodsResponse" />
  </wsdl:message>
  <wsdl:message name="GetStatusMonitorPeriodsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Saint">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Saint</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultStatusMonitor">
      <wsdl:documentation>
        <summary>Loading default values into a new StatusMonitor.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/CreateDefaultStatusMonitor" name="CreateDefaultStatusMonitorRequest" message="tns:CreateDefaultStatusMonitorRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/CreateDefaultStatusMonitorResponse" name="CreateDefaultStatusMonitorResponse" message="tns:CreateDefaultStatusMonitorResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveStatusMonitor">
      <wsdl:documentation>
        <summary>Updates the existing StatusMonitor or creates a new StatusMonitor if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/SaveStatusMonitor" name="SaveStatusMonitorRequest" message="tns:SaveStatusMonitorRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/SaveStatusMonitorResponse" name="SaveStatusMonitorResponse" message="tns:SaveStatusMonitorResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultStatusMonitorPeriods">
      <wsdl:documentation>
        <summary>Loading default values into a new StatusMonitorPeriods.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/CreateDefaultStatusMonitorPeriods" name="CreateDefaultStatusMonitorPeriodsRequest" message="tns:CreateDefaultStatusMonitorPeriodsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/CreateDefaultStatusMonitorPeriodsResponse" name="CreateDefaultStatusMonitorPeriodsResponse" message="tns:CreateDefaultStatusMonitorPeriodsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveStatusMonitorPeriods">
      <wsdl:documentation>
        <summary>Updates the existing StatusMonitorPeriods or creates a new StatusMonitorPeriods if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/SaveStatusMonitorPeriods" name="SaveStatusMonitorPeriodsRequest" message="tns:SaveStatusMonitorPeriodsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/SaveStatusMonitorPeriodsResponse" name="SaveStatusMonitorPeriodsResponse" message="tns:SaveStatusMonitorPeriodsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetStatusMonitors">
      <wsdl:documentation>
        <summary>Get all active status monitors for a specified target</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/GetStatusMonitors" name="GetStatusMonitorsRequest" message="tns:GetStatusMonitorsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/GetStatusMonitorsResponse" name="GetStatusMonitorsResponse" message="tns:GetStatusMonitorsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetStatusMonitor">
      <wsdl:documentation>
        <summary>Get a single status monitor based on its identity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/GetStatusMonitor" name="GetStatusMonitorRequest" message="tns:GetStatusMonitorRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/GetStatusMonitorResponse" name="GetStatusMonitorResponse" message="tns:GetStatusMonitorResponse" />
    </wsdl:operation>
    <wsdl:operation name="RegenerateStatusMonitors">
      <wsdl:documentation>
        <summary>Regenerate status monitors</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/RegenerateStatusMonitors" name="RegenerateStatusMonitorsRequest" message="tns:RegenerateStatusMonitorsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/RegenerateStatusMonitorsResponse" name="RegenerateStatusMonitorsResponse" message="tns:RegenerateStatusMonitorsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetRankOnStatusMonitors">
      <wsdl:documentation>
        <summary>Set rank order on status monitors</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/SetRankOnStatusMonitors" name="SetRankOnStatusMonitorsRequest" message="tns:SetRankOnStatusMonitorsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/SetRankOnStatusMonitorsResponse" name="SetRankOnStatusMonitorsResponse" message="tns:SetRankOnStatusMonitorsResponse" />
    </wsdl:operation>
    <wsdl:operation name="RegenerateStatusMonitor">
      <wsdl:documentation>
        <summary>Regenerate the given status monitor</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/RegenerateStatusMonitor" name="RegenerateStatusMonitorRequest" message="tns:RegenerateStatusMonitorRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/RegenerateStatusMonitorResponse" name="RegenerateStatusMonitorResponse" message="tns:RegenerateStatusMonitorResponse" />
    </wsdl:operation>
    <wsdl:operation name="RegenerateCounters">
      <wsdl:documentation>
        <summary>Regenerate the Saint counters - this can take several minutes</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/RegenerateCounters" name="RegenerateCountersRequest" message="tns:RegenerateCountersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/RegenerateCountersResponse" name="RegenerateCountersResponse" message="tns:RegenerateCountersResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetStatusMonitorPeriods">
      <wsdl:documentation>
        <summary>Returns the StatusMonitorPeriods entity.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/GetStatusMonitorPeriods" name="GetStatusMonitorPeriodsRequest" message="tns:GetStatusMonitorPeriodsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/GetStatusMonitorPeriodsResponse" name="GetStatusMonitorPeriodsResponse" message="tns:GetStatusMonitorPeriodsResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Saint" type="tns:Saint">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultStatusMonitor">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/CreateDefaultStatusMonitor" style="document" />
      <wsdl:input name="CreateDefaultStatusMonitorRequest">
        <soap:header message="tns:CreateDefaultStatusMonitorRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultStatusMonitorRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultStatusMonitorRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultStatusMonitorResponse">
        <soap:header message="tns:CreateDefaultStatusMonitorResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultStatusMonitorResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultStatusMonitorResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultStatusMonitorResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveStatusMonitor">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/SaveStatusMonitor" style="document" />
      <wsdl:input name="SaveStatusMonitorRequest">
        <soap:header message="tns:SaveStatusMonitorRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveStatusMonitorRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveStatusMonitorRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveStatusMonitorResponse">
        <soap:header message="tns:SaveStatusMonitorResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveStatusMonitorResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveStatusMonitorResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveStatusMonitorResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultStatusMonitorPeriods">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/CreateDefaultStatusMonitorPeriods" style="document" />
      <wsdl:input name="CreateDefaultStatusMonitorPeriodsRequest">
        <soap:header message="tns:CreateDefaultStatusMonitorPeriodsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultStatusMonitorPeriodsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultStatusMonitorPeriodsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultStatusMonitorPeriodsResponse">
        <soap:header message="tns:CreateDefaultStatusMonitorPeriodsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultStatusMonitorPeriodsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultStatusMonitorPeriodsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultStatusMonitorPeriodsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveStatusMonitorPeriods">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/SaveStatusMonitorPeriods" style="document" />
      <wsdl:input name="SaveStatusMonitorPeriodsRequest">
        <soap:header message="tns:SaveStatusMonitorPeriodsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveStatusMonitorPeriodsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveStatusMonitorPeriodsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveStatusMonitorPeriodsResponse">
        <soap:header message="tns:SaveStatusMonitorPeriodsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveStatusMonitorPeriodsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveStatusMonitorPeriodsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveStatusMonitorPeriodsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetStatusMonitors">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/GetStatusMonitors" style="document" />
      <wsdl:input name="GetStatusMonitorsRequest">
        <soap:header message="tns:GetStatusMonitorsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetStatusMonitorsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetStatusMonitorsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetStatusMonitorsResponse">
        <soap:header message="tns:GetStatusMonitorsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetStatusMonitorsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetStatusMonitorsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetStatusMonitorsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetStatusMonitor">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/GetStatusMonitor" style="document" />
      <wsdl:input name="GetStatusMonitorRequest">
        <soap:header message="tns:GetStatusMonitorRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetStatusMonitorRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetStatusMonitorRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetStatusMonitorResponse">
        <soap:header message="tns:GetStatusMonitorResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetStatusMonitorResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetStatusMonitorResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetStatusMonitorResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RegenerateStatusMonitors">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/RegenerateStatusMonitors" style="document" />
      <wsdl:input name="RegenerateStatusMonitorsRequest">
        <soap:header message="tns:RegenerateStatusMonitorsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RegenerateStatusMonitorsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RegenerateStatusMonitorsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RegenerateStatusMonitorsResponse">
        <soap:header message="tns:RegenerateStatusMonitorsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RegenerateStatusMonitorsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RegenerateStatusMonitorsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RegenerateStatusMonitorsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetRankOnStatusMonitors">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/SetRankOnStatusMonitors" style="document" />
      <wsdl:input name="SetRankOnStatusMonitorsRequest">
        <soap:header message="tns:SetRankOnStatusMonitorsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetRankOnStatusMonitorsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetRankOnStatusMonitorsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetRankOnStatusMonitorsResponse">
        <soap:header message="tns:SetRankOnStatusMonitorsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetRankOnStatusMonitorsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetRankOnStatusMonitorsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetRankOnStatusMonitorsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RegenerateStatusMonitor">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/RegenerateStatusMonitor" style="document" />
      <wsdl:input name="RegenerateStatusMonitorRequest">
        <soap:header message="tns:RegenerateStatusMonitorRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RegenerateStatusMonitorRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RegenerateStatusMonitorRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RegenerateStatusMonitorResponse">
        <soap:header message="tns:RegenerateStatusMonitorResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RegenerateStatusMonitorResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RegenerateStatusMonitorResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RegenerateStatusMonitorResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RegenerateCounters">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/RegenerateCounters" style="document" />
      <wsdl:input name="RegenerateCountersRequest">
        <soap:header message="tns:RegenerateCountersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RegenerateCountersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RegenerateCountersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RegenerateCountersResponse">
        <soap:header message="tns:RegenerateCountersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RegenerateCountersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RegenerateCountersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RegenerateCountersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetStatusMonitorPeriods">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Saint/GetStatusMonitorPeriods" style="document" />
      <wsdl:input name="GetStatusMonitorPeriodsRequest">
        <soap:header message="tns:GetStatusMonitorPeriodsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetStatusMonitorPeriodsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetStatusMonitorPeriodsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetStatusMonitorPeriodsResponse">
        <soap:header message="tns:GetStatusMonitorPeriodsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetStatusMonitorPeriodsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetStatusMonitorPeriodsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetStatusMonitorPeriodsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfSaintService">
    <wsdl:port name="BasicHttpBinding_Saint" binding="tns:BasicHttpBinding_Saint">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services83/Saint.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

