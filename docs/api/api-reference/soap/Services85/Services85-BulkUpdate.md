---
generated: 1
uid: wsdl-Services85-BulkUpdate
title: Services85.BulkUpdateAgent WSDL
---

# Services85.BulkUpdateAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfBulkUpdateService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services85" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services85" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services85" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="GetAvailableFields">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Tablename" nillable="true" type="xs:string" />
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
      <xs:element name="GetAvailableFieldsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfFieldValueInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfFieldValueInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="FieldValueInfo" nillable="true" type="tns:FieldValueInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfFieldValueInfo" nillable="true" type="tns:ArrayOfFieldValueInfo" />
      <xs:complexType name="FieldValueInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="CanSupportMultiUse" type="xs:boolean" />
          <xs:element minOccurs="0" name="DefaultShowInGui" type="xs:boolean" />
          <xs:element minOccurs="0" name="DefaultShowInSelector" type="xs:boolean" />
          <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
          <xs:element minOccurs="0" name="Key" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ValueType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Mandatory" type="xs:boolean" />
          <xs:element minOccurs="0" name="EncodedDisplayName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="EncodedDisplayDescription" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="IconHint" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ControlInfos" nillable="true" type="tns:ArrayOfControlInfo" />
          <xs:element minOccurs="0" name="EncodedDataCaption" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="EncodedDataCaptionDescription" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="CurrentOperationType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Values" nillable="true" type="q1:ArrayOfstring" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="DisplayValues" nillable="true" type="q2:ArrayOfstring" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="OperationInfos" nillable="true" type="tns:ArrayOfOperationInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldValueInfo" nillable="true" type="tns:FieldValueInfo" />
      <xs:complexType name="ArrayOfControlInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ControlInfo" nillable="true" type="tns:ControlInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfControlInfo" nillable="true" type="tns:ArrayOfControlInfo" />
      <xs:complexType name="ControlInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Label" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Dimension" type="xs:int" />
              <xs:element minOccurs="0" name="ListProviderName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ListProviderExtraInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ListProviderPrimaryKeyName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ListLeadText" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ControlInfo" nillable="true" type="tns:ControlInfo" />
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
      <xs:complexType name="ArrayOfOperationInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="OperationInfo" nillable="true" type="tns:OperationInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfOperationInfo" nillable="true" type="tns:ArrayOfOperationInfo" />
      <xs:complexType name="OperationInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Key" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EncodedDisplayName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EncodedLeadTexts" nillable="true" type="q3:ArrayOfstring" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="OperationInfo" nillable="true" type="tns:OperationInfo" />
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
      <xs:element name="GetStoredFields">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Tablename" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetStoredFieldsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfFieldValueInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExecuteBySelectionId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FieldValueInfos" nillable="true" type="tns:ArrayOfFieldValueInfo" />
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="IsShadow" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExecuteBySelectionIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExecuteByEntityIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FieldValueInfos" nillable="true" type="tns:ArrayOfFieldValueInfo" />
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Ids" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExecuteByEntityIdsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetJobResultsFromStorageAsJson">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetJobResultsFromStorageAsJsonResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q4:ArrayOfstring" xmlns:q4="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveStoredFields">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveStoredFieldsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveStoredFieldsAndGetDefaultFields">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveStoredFieldsAndGetDefaultFieldsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfFieldValueInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetJobResultAsJsonFromBinaryObjectId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="BinaryObjectId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetJobResultAsJsonFromBinaryObjectIdResponse">
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
  <wsdl:message name="GetAvailableFieldsRequest">
    <wsdl:part name="parameters" element="tns:GetAvailableFields" />
  </wsdl:message>
  <wsdl:message name="GetAvailableFieldsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAvailableFieldsResponse">
    <wsdl:part name="parameters" element="tns:GetAvailableFieldsResponse" />
  </wsdl:message>
  <wsdl:message name="GetAvailableFieldsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetStoredFieldsRequest">
    <wsdl:part name="parameters" element="tns:GetStoredFields" />
  </wsdl:message>
  <wsdl:message name="GetStoredFieldsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetStoredFieldsResponse">
    <wsdl:part name="parameters" element="tns:GetStoredFieldsResponse" />
  </wsdl:message>
  <wsdl:message name="GetStoredFieldsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExecuteBySelectionIdRequest">
    <wsdl:part name="parameters" element="tns:ExecuteBySelectionId" />
  </wsdl:message>
  <wsdl:message name="ExecuteBySelectionIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExecuteBySelectionIdResponse">
    <wsdl:part name="parameters" element="tns:ExecuteBySelectionIdResponse" />
  </wsdl:message>
  <wsdl:message name="ExecuteBySelectionIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExecuteByEntityIdsRequest">
    <wsdl:part name="parameters" element="tns:ExecuteByEntityIds" />
  </wsdl:message>
  <wsdl:message name="ExecuteByEntityIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExecuteByEntityIdsResponse">
    <wsdl:part name="parameters" element="tns:ExecuteByEntityIdsResponse" />
  </wsdl:message>
  <wsdl:message name="ExecuteByEntityIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetJobResultsFromStorageAsJsonRequest">
    <wsdl:part name="parameters" element="tns:GetJobResultsFromStorageAsJson" />
  </wsdl:message>
  <wsdl:message name="GetJobResultsFromStorageAsJsonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetJobResultsFromStorageAsJsonResponse">
    <wsdl:part name="parameters" element="tns:GetJobResultsFromStorageAsJsonResponse" />
  </wsdl:message>
  <wsdl:message name="GetJobResultsFromStorageAsJsonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveStoredFieldsRequest">
    <wsdl:part name="parameters" element="tns:RemoveStoredFields" />
  </wsdl:message>
  <wsdl:message name="RemoveStoredFieldsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveStoredFieldsResponse">
    <wsdl:part name="parameters" element="tns:RemoveStoredFieldsResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveStoredFieldsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveStoredFieldsAndGetDefaultFieldsRequest">
    <wsdl:part name="parameters" element="tns:RemoveStoredFieldsAndGetDefaultFields" />
  </wsdl:message>
  <wsdl:message name="RemoveStoredFieldsAndGetDefaultFieldsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveStoredFieldsAndGetDefaultFieldsResponse">
    <wsdl:part name="parameters" element="tns:RemoveStoredFieldsAndGetDefaultFieldsResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveStoredFieldsAndGetDefaultFieldsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetJobResultAsJsonFromBinaryObjectIdRequest">
    <wsdl:part name="parameters" element="tns:GetJobResultAsJsonFromBinaryObjectId" />
  </wsdl:message>
  <wsdl:message name="GetJobResultAsJsonFromBinaryObjectIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetJobResultAsJsonFromBinaryObjectIdResponse">
    <wsdl:part name="parameters" element="tns:GetJobResultAsJsonFromBinaryObjectIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetJobResultAsJsonFromBinaryObjectIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="BulkUpdate">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for BulkUpdate</summary>
    </wsdl:documentation>
    <wsdl:operation name="GetAvailableFields">
      <wsdl:documentation>
        <summary>Get all available fields for a given tablename/entity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/GetAvailableFields" name="GetAvailableFieldsRequest" message="tns:GetAvailableFieldsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/GetAvailableFieldsResponse" name="GetAvailableFieldsResponse" message="tns:GetAvailableFieldsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetStoredFields">
      <wsdl:documentation>
        <summary>Get all stored fields for a given tablename/entity and context</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/GetStoredFields" name="GetStoredFieldsRequest" message="tns:GetStoredFieldsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/GetStoredFieldsResponse" name="GetStoredFieldsResponse" message="tns:GetStoredFieldsResponse" />
    </wsdl:operation>
    <wsdl:operation name="ExecuteBySelectionId">
      <wsdl:documentation>
        <summary>Do the batchupdate on this selection</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/ExecuteBySelectionId" name="ExecuteBySelectionIdRequest" message="tns:ExecuteBySelectionIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/ExecuteBySelectionIdResponse" name="ExecuteBySelectionIdResponse" message="tns:ExecuteBySelectionIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="ExecuteByEntityIds">
      <wsdl:documentation>
        <summary>Do the batchupdate on selected</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/ExecuteByEntityIds" name="ExecuteByEntityIdsRequest" message="tns:ExecuteByEntityIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/ExecuteByEntityIdsResponse" name="ExecuteByEntityIdsResponse" message="tns:ExecuteByEntityIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetJobResultsFromStorageAsJson">
      <wsdl:documentation>
        <summary>Get result of the batchupdate job</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/GetJobResultsFromStorageAsJson" name="GetJobResultsFromStorageAsJsonRequest" message="tns:GetJobResultsFromStorageAsJsonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/GetJobResultsFromStorageAsJsonResponse" name="GetJobResultsFromStorageAsJsonResponse" message="tns:GetJobResultsFromStorageAsJsonResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveStoredFields">
      <wsdl:documentation>
        <summary>Remove the stored settings of the bulk update for this table from this context</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/RemoveStoredFields" name="RemoveStoredFieldsRequest" message="tns:RemoveStoredFieldsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/RemoveStoredFieldsResponse" name="RemoveStoredFieldsResponse" message="tns:RemoveStoredFieldsResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveStoredFieldsAndGetDefaultFields">
      <wsdl:documentation>
        <summary>Remove the stored settings of the bulk update for this table from this context, to get the default settings instead</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/RemoveStoredFieldsAndGetDefaultFields" name="RemoveStoredFieldsAndGetDefaultFieldsRequest" message="tns:RemoveStoredFieldsAndGetDefaultFieldsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/RemoveStoredFieldsAndGetDefaultFieldsResponse" name="RemoveStoredFieldsAndGetDefaultFieldsResponse" message="tns:RemoveStoredFieldsAndGetDefaultFieldsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetJobResultAsJsonFromBinaryObjectId">
      <wsdl:documentation>
        <summary>Get result of the batchupdate job</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/GetJobResultAsJsonFromBinaryObjectId" name="GetJobResultAsJsonFromBinaryObjectIdRequest" message="tns:GetJobResultAsJsonFromBinaryObjectIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/GetJobResultAsJsonFromBinaryObjectIdResponse" name="GetJobResultAsJsonFromBinaryObjectIdResponse" message="tns:GetJobResultAsJsonFromBinaryObjectIdResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_BulkUpdate" type="tns:BulkUpdate">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="GetAvailableFields">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/GetAvailableFields" style="document" />
      <wsdl:input name="GetAvailableFieldsRequest">
        <soap:header message="tns:GetAvailableFieldsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAvailableFieldsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAvailableFieldsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAvailableFieldsResponse">
        <soap:header message="tns:GetAvailableFieldsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAvailableFieldsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAvailableFieldsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAvailableFieldsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetStoredFields">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/GetStoredFields" style="document" />
      <wsdl:input name="GetStoredFieldsRequest">
        <soap:header message="tns:GetStoredFieldsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetStoredFieldsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetStoredFieldsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetStoredFieldsResponse">
        <soap:header message="tns:GetStoredFieldsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetStoredFieldsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetStoredFieldsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetStoredFieldsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ExecuteBySelectionId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/ExecuteBySelectionId" style="document" />
      <wsdl:input name="ExecuteBySelectionIdRequest">
        <soap:header message="tns:ExecuteBySelectionIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ExecuteBySelectionIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ExecuteBySelectionIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ExecuteBySelectionIdResponse">
        <soap:header message="tns:ExecuteBySelectionIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ExecuteBySelectionIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ExecuteBySelectionIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ExecuteBySelectionIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ExecuteByEntityIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/ExecuteByEntityIds" style="document" />
      <wsdl:input name="ExecuteByEntityIdsRequest">
        <soap:header message="tns:ExecuteByEntityIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ExecuteByEntityIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ExecuteByEntityIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ExecuteByEntityIdsResponse">
        <soap:header message="tns:ExecuteByEntityIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ExecuteByEntityIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ExecuteByEntityIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ExecuteByEntityIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetJobResultsFromStorageAsJson">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/GetJobResultsFromStorageAsJson" style="document" />
      <wsdl:input name="GetJobResultsFromStorageAsJsonRequest">
        <soap:header message="tns:GetJobResultsFromStorageAsJsonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetJobResultsFromStorageAsJsonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetJobResultsFromStorageAsJsonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetJobResultsFromStorageAsJsonResponse">
        <soap:header message="tns:GetJobResultsFromStorageAsJsonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetJobResultsFromStorageAsJsonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetJobResultsFromStorageAsJsonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetJobResultsFromStorageAsJsonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveStoredFields">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/RemoveStoredFields" style="document" />
      <wsdl:input name="RemoveStoredFieldsRequest">
        <soap:header message="tns:RemoveStoredFieldsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveStoredFieldsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveStoredFieldsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveStoredFieldsResponse">
        <soap:header message="tns:RemoveStoredFieldsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveStoredFieldsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveStoredFieldsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveStoredFieldsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveStoredFieldsAndGetDefaultFields">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/RemoveStoredFieldsAndGetDefaultFields" style="document" />
      <wsdl:input name="RemoveStoredFieldsAndGetDefaultFieldsRequest">
        <soap:header message="tns:RemoveStoredFieldsAndGetDefaultFieldsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveStoredFieldsAndGetDefaultFieldsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveStoredFieldsAndGetDefaultFieldsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveStoredFieldsAndGetDefaultFieldsResponse">
        <soap:header message="tns:RemoveStoredFieldsAndGetDefaultFieldsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveStoredFieldsAndGetDefaultFieldsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveStoredFieldsAndGetDefaultFieldsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveStoredFieldsAndGetDefaultFieldsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetJobResultAsJsonFromBinaryObjectId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/BulkUpdate/GetJobResultAsJsonFromBinaryObjectId" style="document" />
      <wsdl:input name="GetJobResultAsJsonFromBinaryObjectIdRequest">
        <soap:header message="tns:GetJobResultAsJsonFromBinaryObjectIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetJobResultAsJsonFromBinaryObjectIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetJobResultAsJsonFromBinaryObjectIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetJobResultAsJsonFromBinaryObjectIdResponse">
        <soap:header message="tns:GetJobResultAsJsonFromBinaryObjectIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetJobResultAsJsonFromBinaryObjectIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetJobResultAsJsonFromBinaryObjectIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetJobResultAsJsonFromBinaryObjectIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfBulkUpdateService">
    <wsdl:port name="BasicHttpBinding_BulkUpdate" binding="tns:BasicHttpBinding_BulkUpdate">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services85/BulkUpdate.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

