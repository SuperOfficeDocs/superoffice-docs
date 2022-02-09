---
generated: 1
uid: wsdl-Services88-DatabaseTable
title: Services88.DatabaseTableAgent WSDL
---

# Services88.DatabaseTableAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfDatabaseTableService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:element name="ReadRow">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
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
      <xs:element name="ReadRowResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TableRecord" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="TableRecord">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Values" nillable="true" type="tns:StringDictionary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TableRecord" nillable="true" type="tns:TableRecord" />
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
      <xs:element name="InsertRow">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Values" nillable="true" type="tns:StringDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="InsertRowResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateRow">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="Values" nillable="true" type="tns:StringDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateRowResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteRow">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Id" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteRowResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="Insert">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Columns" nillable="true" type="q1:ArrayOfstring" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Data" nillable="true" type="q2:ArrayOfArrayOfstring" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="InsertResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:MassOperationResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="MassOperationResult">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Success" type="xs:boolean" />
              <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Inserts" type="xs:int" />
              <xs:element minOccurs="0" name="Updates" type="xs:int" />
              <xs:element minOccurs="0" name="Deletes" type="xs:int" />
              <xs:element minOccurs="0" name="RowStatus" nillable="true" type="tns:ArrayOfUpsertRowStatus" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="MassOperationResult" nillable="true" type="tns:MassOperationResult" />
      <xs:complexType name="ArrayOfUpsertRowStatus">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="UpsertRowStatus" nillable="true" type="tns:UpsertRowStatus" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfUpsertRowStatus" nillable="true" type="tns:ArrayOfUpsertRowStatus" />
      <xs:complexType name="UpsertRowStatus">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="PrimaryKey" type="xs:int" />
              <xs:element minOccurs="0" name="Action" type="tns:UpsertRowActionStatus" />
              <xs:element minOccurs="0" name="RowKeys" nillable="true" type="q3:ArrayOfstring" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="UpsertRowStatus" nillable="true" type="tns:UpsertRowStatus" />
      <xs:simpleType name="UpsertRowActionStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Inserted">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Updated">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">2</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="NoUpdateNeeded">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">3</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Deleted">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">4</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ColumnsZeroed">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">5</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="UpsertRowActionStatus" nillable="true" type="tns:UpsertRowActionStatus" />
      <xs:element name="Truncate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TruncateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:MassOperationResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Upsert">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Columns" nillable="true" type="q4:ArrayOfstring" xmlns:q4="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Keys" nillable="true" type="q5:ArrayOfstring" xmlns:q5="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Data" nillable="true" type="q6:ArrayOfArrayOfstring" xmlns:q6="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="NomatchAction" type="tns:UpsertNomatchAction" />
            <xs:element minOccurs="0" name="ReturnRowStatus" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="UpsertNomatchAction">
        <xs:restriction base="xs:string">
          <xs:enumeration value="NoChange" />
          <xs:enumeration value="ZeroColumns" />
          <xs:enumeration value="DeleteRow" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="UpsertNomatchAction" nillable="true" type="tns:UpsertNomatchAction" />
      <xs:element name="UpsertResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:MassOperationResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Delete">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="IDs" nillable="true" type="q7:ArrayOfint" xmlns:q7="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:MassOperationResult" />
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
      <xs:complexType name="ArrayOfArrayOfstring">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArrayOfstring" nillable="true" type="tns:ArrayOfstring" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArrayOfstring" nillable="true" type="tns:ArrayOfArrayOfstring" />
      <xs:complexType name="ArrayOfint">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="int" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfint" nillable="true" type="tns:ArrayOfint" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="ReadRowRequest">
    <wsdl:part name="parameters" element="tns:ReadRow" />
  </wsdl:message>
  <wsdl:message name="ReadRowRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ReadRowResponse">
    <wsdl:part name="parameters" element="tns:ReadRowResponse" />
  </wsdl:message>
  <wsdl:message name="ReadRowResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="InsertRowRequest">
    <wsdl:part name="parameters" element="tns:InsertRow" />
  </wsdl:message>
  <wsdl:message name="InsertRowRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="InsertRowResponse">
    <wsdl:part name="parameters" element="tns:InsertRowResponse" />
  </wsdl:message>
  <wsdl:message name="InsertRowResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateRowRequest">
    <wsdl:part name="parameters" element="tns:UpdateRow" />
  </wsdl:message>
  <wsdl:message name="UpdateRowRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateRowResponse">
    <wsdl:part name="parameters" element="tns:UpdateRowResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateRowResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteRowRequest">
    <wsdl:part name="parameters" element="tns:DeleteRow" />
  </wsdl:message>
  <wsdl:message name="DeleteRowRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteRowResponse">
    <wsdl:part name="parameters" element="tns:DeleteRowResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteRowResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="InsertRequest">
    <wsdl:part name="parameters" element="tns:Insert" />
  </wsdl:message>
  <wsdl:message name="InsertRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="InsertResponse">
    <wsdl:part name="parameters" element="tns:InsertResponse" />
  </wsdl:message>
  <wsdl:message name="InsertResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TruncateRequest">
    <wsdl:part name="parameters" element="tns:Truncate" />
  </wsdl:message>
  <wsdl:message name="TruncateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TruncateResponse">
    <wsdl:part name="parameters" element="tns:TruncateResponse" />
  </wsdl:message>
  <wsdl:message name="TruncateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpsertRequest">
    <wsdl:part name="parameters" element="tns:Upsert" />
  </wsdl:message>
  <wsdl:message name="UpsertRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpsertResponse">
    <wsdl:part name="parameters" element="tns:UpsertResponse" />
  </wsdl:message>
  <wsdl:message name="UpsertResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteRequest">
    <wsdl:part name="parameters" element="tns:Delete" />
  </wsdl:message>
  <wsdl:message name="DeleteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteResponse">
    <wsdl:part name="parameters" element="tns:DeleteResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="DatabaseTable">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for DatabaseTable</summary>
    </wsdl:documentation>
    <wsdl:operation name="ReadRow">
      <wsdl:documentation>
        <summary>Read a row from a table</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/ReadRow" name="ReadRowRequest" message="tns:ReadRowRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/ReadRowResponse" name="ReadRowResponse" message="tns:ReadRowResponse" />
    </wsdl:operation>
    <wsdl:operation name="InsertRow">
      <wsdl:documentation>
        <summary>Insert a row into a table</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/InsertRow" name="InsertRowRequest" message="tns:InsertRowRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/InsertRowResponse" name="InsertRowResponse" message="tns:InsertRowResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateRow">
      <wsdl:documentation>
        <summary>Update a row in a table</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/UpdateRow" name="UpdateRowRequest" message="tns:UpdateRowRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/UpdateRowResponse" name="UpdateRowResponse" message="tns:UpdateRowResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteRow">
      <wsdl:documentation>
        <summary>Delete a row from a table</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/DeleteRow" name="DeleteRowRequest" message="tns:DeleteRowRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/DeleteRowResponse" name="DeleteRowResponse" message="tns:DeleteRowResponse" />
    </wsdl:operation>
    <wsdl:operation name="Insert">
      <wsdl:documentation>
        <summary>Mass-insert rows, with or without primary keys specified. Works on physical tables with no special processing for udef etc.; traveltransactionlog and WebHooks are supported</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/Insert" name="InsertRequest" message="tns:InsertRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/InsertResponse" name="InsertResponse" message="tns:InsertResponse" />
    </wsdl:operation>
    <wsdl:operation name="Truncate">
      <wsdl:documentation>
        <summary>Drop all rows in a table. This clearance is not individually logged in TravelTransactionlog or Webhook/script calls</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/Truncate" name="TruncateRequest" message="tns:TruncateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/TruncateResponse" name="TruncateResponse" message="tns:TruncateResponse" />
    </wsdl:operation>
    <wsdl:operation name="Upsert">
      <wsdl:documentation>
        <summary>Insert or update rows, optionally deleting/zeroing 'leftover' rows. Special support for UDEF, as well as optional extensive information return. Traveltransactionlog and WebHooks are supported</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/Upsert" name="UpsertRequest" message="tns:UpsertRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/UpsertResponse" name="UpsertResponse" message="tns:UpsertResponse" />
    </wsdl:operation>
    <wsdl:operation name="Delete">
      <wsdl:documentation>
        <summary>Delete rows, by primary key; traveltransactionlog and WebHooks are supported</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/Delete" name="DeleteRequest" message="tns:DeleteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/DeleteResponse" name="DeleteResponse" message="tns:DeleteResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_DatabaseTable" type="tns:DatabaseTable">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="ReadRow">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/ReadRow" style="document" />
      <wsdl:input name="ReadRowRequest">
        <soap:header message="tns:ReadRowRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ReadRowRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ReadRowRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ReadRowResponse">
        <soap:header message="tns:ReadRowResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ReadRowResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ReadRowResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ReadRowResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="InsertRow">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/InsertRow" style="document" />
      <wsdl:input name="InsertRowRequest">
        <soap:header message="tns:InsertRowRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:InsertRowRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:InsertRowRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="InsertRowResponse">
        <soap:header message="tns:InsertRowResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:InsertRowResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:InsertRowResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:InsertRowResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateRow">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/UpdateRow" style="document" />
      <wsdl:input name="UpdateRowRequest">
        <soap:header message="tns:UpdateRowRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateRowRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateRowRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateRowResponse">
        <soap:header message="tns:UpdateRowResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateRowResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateRowResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateRowResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteRow">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/DeleteRow" style="document" />
      <wsdl:input name="DeleteRowRequest">
        <soap:header message="tns:DeleteRowRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteRowRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteRowRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteRowResponse">
        <soap:header message="tns:DeleteRowResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteRowResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteRowResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteRowResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Insert">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/Insert" style="document" />
      <wsdl:input name="InsertRequest">
        <soap:header message="tns:InsertRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:InsertRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:InsertRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="InsertResponse">
        <soap:header message="tns:InsertResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:InsertResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:InsertResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:InsertResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Truncate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/Truncate" style="document" />
      <wsdl:input name="TruncateRequest">
        <soap:header message="tns:TruncateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TruncateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TruncateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TruncateResponse">
        <soap:header message="tns:TruncateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TruncateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TruncateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TruncateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Upsert">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/Upsert" style="document" />
      <wsdl:input name="UpsertRequest">
        <soap:header message="tns:UpsertRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpsertRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpsertRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpsertResponse">
        <soap:header message="tns:UpsertResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpsertResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpsertResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpsertResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Delete">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/DatabaseTable/Delete" style="document" />
      <wsdl:input name="DeleteRequest">
        <soap:header message="tns:DeleteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteResponse">
        <soap:header message="tns:DeleteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfDatabaseTableService">
    <wsdl:port name="BasicHttpBinding_DatabaseTable" binding="tns:BasicHttpBinding_DatabaseTable">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/DatabaseTable.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

