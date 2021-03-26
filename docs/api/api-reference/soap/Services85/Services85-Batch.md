---
Generated: 1
TOCExclude: 1
title: Services85.BatchAgent WSDL
---

# Services85.BatchAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfBatchService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services85" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services85" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services85" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="GetBatchTaskInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
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
      <xs:element name="GetBatchTaskInfoResponse">
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
      <xs:element name="GetBatchTaskInfosByAssociates">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateIds" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBatchTaskInfosByAssociatesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfBatchTaskInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfBatchTaskInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="BatchTaskInfo" nillable="true" type="tns:BatchTaskInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfBatchTaskInfo" nillable="true" type="tns:ArrayOfBatchTaskInfo" />
      <xs:element name="StartBatchJob">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BatchTaskInfo" nillable="true" type="tns:BatchTaskInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="StartBatchJobResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="StopBatchJob">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="StopBatchJobResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBatchTaskInfosByState">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="State" type="tns:BatchTaskState" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBatchTaskInfosByStateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfBatchTaskInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateBatchTask">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BatchTaskInfo" nillable="true" type="tns:BatchTaskInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateBatchTaskResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:BatchTaskInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBatchTaskInfosByNameAndState">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="State" type="tns:BatchTaskState" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBatchTaskInfosByNameAndStateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfBatchTaskInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBatchTaskInfosByNameAndAssociates">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="AssociateIds" nillable="true" type="q2:ArrayOfint" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBatchTaskInfosByNameAndAssociatesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfBatchTaskInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBatchTaskInfosByAssociatesAndState">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateIds" nillable="true" type="q3:ArrayOfint" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="State" type="tns:BatchTaskState" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBatchTaskInfosByAssociatesAndStateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfBatchTaskInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteBatchTasks">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BatchTaskIds" nillable="true" type="q4:ArrayOfint" xmlns:q4="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteBatchTasksResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteBatchTask">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BatchTaskId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteBatchTaskResponse">
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
  <wsdl:message name="GetBatchTaskInfoRequest">
    <wsdl:part name="parameters" element="tns:GetBatchTaskInfo" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfoResponse">
    <wsdl:part name="parameters" element="tns:GetBatchTaskInfoResponse" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByAssociatesRequest">
    <wsdl:part name="parameters" element="tns:GetBatchTaskInfosByAssociates" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByAssociatesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByAssociatesResponse">
    <wsdl:part name="parameters" element="tns:GetBatchTaskInfosByAssociatesResponse" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByAssociatesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="StartBatchJobRequest">
    <wsdl:part name="parameters" element="tns:StartBatchJob" />
  </wsdl:message>
  <wsdl:message name="StartBatchJobRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="StartBatchJobResponse">
    <wsdl:part name="parameters" element="tns:StartBatchJobResponse" />
  </wsdl:message>
  <wsdl:message name="StartBatchJobResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="StopBatchJobRequest">
    <wsdl:part name="parameters" element="tns:StopBatchJob" />
  </wsdl:message>
  <wsdl:message name="StopBatchJobRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="StopBatchJobResponse">
    <wsdl:part name="parameters" element="tns:StopBatchJobResponse" />
  </wsdl:message>
  <wsdl:message name="StopBatchJobResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByStateRequest">
    <wsdl:part name="parameters" element="tns:GetBatchTaskInfosByState" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByStateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByStateResponse">
    <wsdl:part name="parameters" element="tns:GetBatchTaskInfosByStateResponse" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByStateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateBatchTaskRequest">
    <wsdl:part name="parameters" element="tns:UpdateBatchTask" />
  </wsdl:message>
  <wsdl:message name="UpdateBatchTaskRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateBatchTaskResponse">
    <wsdl:part name="parameters" element="tns:UpdateBatchTaskResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateBatchTaskResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByNameAndStateRequest">
    <wsdl:part name="parameters" element="tns:GetBatchTaskInfosByNameAndState" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByNameAndStateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByNameAndStateResponse">
    <wsdl:part name="parameters" element="tns:GetBatchTaskInfosByNameAndStateResponse" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByNameAndStateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByNameAndAssociatesRequest">
    <wsdl:part name="parameters" element="tns:GetBatchTaskInfosByNameAndAssociates" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByNameAndAssociatesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByNameAndAssociatesResponse">
    <wsdl:part name="parameters" element="tns:GetBatchTaskInfosByNameAndAssociatesResponse" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByNameAndAssociatesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByAssociatesAndStateRequest">
    <wsdl:part name="parameters" element="tns:GetBatchTaskInfosByAssociatesAndState" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByAssociatesAndStateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByAssociatesAndStateResponse">
    <wsdl:part name="parameters" element="tns:GetBatchTaskInfosByAssociatesAndStateResponse" />
  </wsdl:message>
  <wsdl:message name="GetBatchTaskInfosByAssociatesAndStateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteBatchTasksRequest">
    <wsdl:part name="parameters" element="tns:DeleteBatchTasks" />
  </wsdl:message>
  <wsdl:message name="DeleteBatchTasksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteBatchTasksResponse">
    <wsdl:part name="parameters" element="tns:DeleteBatchTasksResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteBatchTasksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteBatchTaskRequest">
    <wsdl:part name="parameters" element="tns:DeleteBatchTask" />
  </wsdl:message>
  <wsdl:message name="DeleteBatchTaskRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteBatchTaskResponse">
    <wsdl:part name="parameters" element="tns:DeleteBatchTaskResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteBatchTaskResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Batch">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Batch</summary>
    </wsdl:documentation>
    <wsdl:operation name="GetBatchTaskInfo">
      <wsdl:documentation>
        <summary>Get a single BatchTaskInfo based on Id.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/GetBatchTaskInfo" name="GetBatchTaskInfoRequest" message="tns:GetBatchTaskInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/GetBatchTaskInfoResponse" name="GetBatchTaskInfoResponse" message="tns:GetBatchTaskInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBatchTaskInfosByAssociates">
      <wsdl:documentation>
        <summary>Get an array of BatchTaskInfo for the provided associate id's.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/GetBatchTaskInfosByAssociates" name="GetBatchTaskInfosByAssociatesRequest" message="tns:GetBatchTaskInfosByAssociatesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/GetBatchTaskInfosByAssociatesResponse" name="GetBatchTaskInfosByAssociatesResponse" message="tns:GetBatchTaskInfosByAssociatesResponse" />
    </wsdl:operation>
    <wsdl:operation name="StartBatchJob">
      <wsdl:documentation>
        <summary>Start a batch job based on BatchTaskInfo.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/StartBatchJob" name="StartBatchJobRequest" message="tns:StartBatchJobRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/StartBatchJobResponse" name="StartBatchJobResponse" message="tns:StartBatchJobResponse" />
    </wsdl:operation>
    <wsdl:operation name="StopBatchJob">
      <wsdl:documentation>
        <summary>Stop a batch job based on Id.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/StopBatchJob" name="StopBatchJobRequest" message="tns:StopBatchJobRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/StopBatchJobResponse" name="StopBatchJobResponse" message="tns:StopBatchJobResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBatchTaskInfosByState">
      <wsdl:documentation>
        <summary>Gets an array of BatchTaskInfo with state defined by a BatchTaskState.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/GetBatchTaskInfosByState" name="GetBatchTaskInfosByStateRequest" message="tns:GetBatchTaskInfosByStateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/GetBatchTaskInfosByStateResponse" name="GetBatchTaskInfosByStateResponse" message="tns:GetBatchTaskInfosByStateResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateBatchTask">
      <wsdl:documentation>
        <summary>Update information about a BatchTask. Only the following properties can be updated: State, Description, Response and Request.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/UpdateBatchTask" name="UpdateBatchTaskRequest" message="tns:UpdateBatchTaskRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/UpdateBatchTaskResponse" name="UpdateBatchTaskResponse" message="tns:UpdateBatchTaskResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBatchTaskInfosByNameAndState">
      <wsdl:documentation>
        <summary>Gets an array of BatchTaskInfo with state defined by a BatchTaskState and the batchtask definition name.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/GetBatchTaskInfosByNameAndState" name="GetBatchTaskInfosByNameAndStateRequest" message="tns:GetBatchTaskInfosByNameAndStateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/GetBatchTaskInfosByNameAndStateResponse" name="GetBatchTaskInfosByNameAndStateResponse" message="tns:GetBatchTaskInfosByNameAndStateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBatchTaskInfosByNameAndAssociates">
      <wsdl:documentation>
        <summary>Get an array of BatchTaskInfo for the provided associate id's and batch task definition name.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/GetBatchTaskInfosByNameAndAssociates" name="GetBatchTaskInfosByNameAndAssociatesRequest" message="tns:GetBatchTaskInfosByNameAndAssociatesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/GetBatchTaskInfosByNameAndAssociatesResponse" name="GetBatchTaskInfosByNameAndAssociatesResponse" message="tns:GetBatchTaskInfosByNameAndAssociatesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBatchTaskInfosByAssociatesAndState">
      <wsdl:documentation>
        <summary>Get an array of BatchTaskInfo for the provided associate id's and batch task state.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/GetBatchTaskInfosByAssociatesAndState" name="GetBatchTaskInfosByAssociatesAndStateRequest" message="tns:GetBatchTaskInfosByAssociatesAndStateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/GetBatchTaskInfosByAssociatesAndStateResponse" name="GetBatchTaskInfosByAssociatesAndStateResponse" message="tns:GetBatchTaskInfosByAssociatesAndStateResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteBatchTasks">
      <wsdl:documentation>
        <summary>Delete batch tasks from the database.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/DeleteBatchTasks" name="DeleteBatchTasksRequest" message="tns:DeleteBatchTasksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/DeleteBatchTasksResponse" name="DeleteBatchTasksResponse" message="tns:DeleteBatchTasksResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteBatchTask">
      <wsdl:documentation>
        <summary>Delete a batch task from the database.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/DeleteBatchTask" name="DeleteBatchTaskRequest" message="tns:DeleteBatchTaskRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/DeleteBatchTaskResponse" name="DeleteBatchTaskResponse" message="tns:DeleteBatchTaskResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Batch" type="tns:Batch">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="GetBatchTaskInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/GetBatchTaskInfo" style="document" />
      <wsdl:input name="GetBatchTaskInfoRequest">
        <soap:header message="tns:GetBatchTaskInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBatchTaskInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBatchTaskInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBatchTaskInfoResponse">
        <soap:header message="tns:GetBatchTaskInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBatchTaskInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBatchTaskInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBatchTaskInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBatchTaskInfosByAssociates">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/GetBatchTaskInfosByAssociates" style="document" />
      <wsdl:input name="GetBatchTaskInfosByAssociatesRequest">
        <soap:header message="tns:GetBatchTaskInfosByAssociatesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByAssociatesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByAssociatesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBatchTaskInfosByAssociatesResponse">
        <soap:header message="tns:GetBatchTaskInfosByAssociatesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByAssociatesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByAssociatesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByAssociatesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="StartBatchJob">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/StartBatchJob" style="document" />
      <wsdl:input name="StartBatchJobRequest">
        <soap:header message="tns:StartBatchJobRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:StartBatchJobRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:StartBatchJobRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="StartBatchJobResponse">
        <soap:header message="tns:StartBatchJobResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:StartBatchJobResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:StartBatchJobResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:StartBatchJobResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="StopBatchJob">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/StopBatchJob" style="document" />
      <wsdl:input name="StopBatchJobRequest">
        <soap:header message="tns:StopBatchJobRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:StopBatchJobRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:StopBatchJobRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="StopBatchJobResponse">
        <soap:header message="tns:StopBatchJobResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:StopBatchJobResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:StopBatchJobResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:StopBatchJobResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBatchTaskInfosByState">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/GetBatchTaskInfosByState" style="document" />
      <wsdl:input name="GetBatchTaskInfosByStateRequest">
        <soap:header message="tns:GetBatchTaskInfosByStateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByStateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByStateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBatchTaskInfosByStateResponse">
        <soap:header message="tns:GetBatchTaskInfosByStateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByStateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByStateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByStateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateBatchTask">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/UpdateBatchTask" style="document" />
      <wsdl:input name="UpdateBatchTaskRequest">
        <soap:header message="tns:UpdateBatchTaskRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateBatchTaskRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateBatchTaskRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateBatchTaskResponse">
        <soap:header message="tns:UpdateBatchTaskResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateBatchTaskResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateBatchTaskResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateBatchTaskResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBatchTaskInfosByNameAndState">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/GetBatchTaskInfosByNameAndState" style="document" />
      <wsdl:input name="GetBatchTaskInfosByNameAndStateRequest">
        <soap:header message="tns:GetBatchTaskInfosByNameAndStateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByNameAndStateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByNameAndStateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBatchTaskInfosByNameAndStateResponse">
        <soap:header message="tns:GetBatchTaskInfosByNameAndStateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByNameAndStateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByNameAndStateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByNameAndStateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBatchTaskInfosByNameAndAssociates">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/GetBatchTaskInfosByNameAndAssociates" style="document" />
      <wsdl:input name="GetBatchTaskInfosByNameAndAssociatesRequest">
        <soap:header message="tns:GetBatchTaskInfosByNameAndAssociatesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByNameAndAssociatesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByNameAndAssociatesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBatchTaskInfosByNameAndAssociatesResponse">
        <soap:header message="tns:GetBatchTaskInfosByNameAndAssociatesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByNameAndAssociatesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByNameAndAssociatesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByNameAndAssociatesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBatchTaskInfosByAssociatesAndState">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/GetBatchTaskInfosByAssociatesAndState" style="document" />
      <wsdl:input name="GetBatchTaskInfosByAssociatesAndStateRequest">
        <soap:header message="tns:GetBatchTaskInfosByAssociatesAndStateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByAssociatesAndStateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByAssociatesAndStateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBatchTaskInfosByAssociatesAndStateResponse">
        <soap:header message="tns:GetBatchTaskInfosByAssociatesAndStateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByAssociatesAndStateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByAssociatesAndStateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBatchTaskInfosByAssociatesAndStateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteBatchTasks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/DeleteBatchTasks" style="document" />
      <wsdl:input name="DeleteBatchTasksRequest">
        <soap:header message="tns:DeleteBatchTasksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteBatchTasksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteBatchTasksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteBatchTasksResponse">
        <soap:header message="tns:DeleteBatchTasksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteBatchTasksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteBatchTasksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteBatchTasksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteBatchTask">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/Batch/DeleteBatchTask" style="document" />
      <wsdl:input name="DeleteBatchTaskRequest">
        <soap:header message="tns:DeleteBatchTaskRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteBatchTaskRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteBatchTaskRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteBatchTaskResponse">
        <soap:header message="tns:DeleteBatchTaskResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteBatchTaskResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteBatchTaskResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteBatchTaskResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfBatchService">
    <wsdl:port name="BasicHttpBinding_Batch" binding="tns:BasicHttpBinding_Batch">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services85/Batch.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

