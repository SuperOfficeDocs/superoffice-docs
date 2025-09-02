---
generated: true
uid: wsdl-Services88-FreeText
title: Services88.FreeTextAgent WSDL
content_type: reference
---

# Services88.FreeTextAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfFreeTextService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="GetStatus">
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
      <xs:element name="GetStatusResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FreeText" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="FreeText">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="FreeTextEnabled" type="xs:boolean" />
              <xs:element minOccurs="0" name="SingleWordOperator" type="tns:FreeTextOperator" />
              <xs:element minOccurs="0" name="MultiWordOperator" type="tns:FreeTextOperator" />
              <xs:element minOccurs="0" name="CountWords" type="xs:int" />
              <xs:element minOccurs="0" name="Occurrences" type="xs:int" />
              <xs:element minOccurs="0" name="LastGenerated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AutoEnableTravelAreas" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="FreeText" nillable="true" type="tns:FreeText" />
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
              <xs:enumeration value="R">
                <xs:annotation>
                  <xs:appinfo>
                    <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1</EnumerationValue>
                  </xs:appinfo>
                </xs:annotation>
              </xs:enumeration>
              <xs:enumeration value="F">
                <xs:annotation>
                  <xs:appinfo>
                    <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">16</EnumerationValue>
                  </xs:appinfo>
                </xs:annotation>
              </xs:enumeration>
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
              <xs:enumeration value="Nullable">
                <xs:annotation>
                  <xs:appinfo>
                    <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">32</EnumerationValue>
                  </xs:appinfo>
                </xs:annotation>
              </xs:enumeration>
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="EFieldRight" nillable="true" type="tns:EFieldRight" />
      <xs:simpleType name="FreeTextOperator">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Contains">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="StartsWith">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">2</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ExactMatch">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">3</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="FreeTextOperator" nillable="true" type="tns:FreeTextOperator" />
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
      <xs:element name="SetEnabled">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Enabled" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetEnabledResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetSingleWordOperator">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FreeTextOperator" type="tns:FreeTextOperator" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetSingleWordOperatorResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetMultiWordOperator">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FreeTextOperator" type="tns:FreeTextOperator" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetMultiWordOperatorResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RegenerateIndex">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RunAsBatch" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RegenerateIndexResponse">
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
              <xs:element minOccurs="0" name="FileName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CancellationBehaviour" type="tns:BatchTaskCancellationBehaviour" />
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
          <xs:enumeration value="SucceededManualCleanup" />
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
      <xs:simpleType name="BatchTaskCancellationBehaviour">
        <xs:restriction base="xs:string">
          <xs:enumeration value="CanCancel" />
          <xs:enumeration value="CancelWithWarning" />
          <xs:enumeration value="CannotCancel" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="BatchTaskCancellationBehaviour" nillable="true" type="tns:BatchTaskCancellationBehaviour" />
      <xs:element name="FreetextIndexRows">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="IDs" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FreetextIndexRowsResponse">
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
  <wsdl:message name="GetStatusRequest">
    <wsdl:part name="parameters" element="tns:GetStatus" />
  </wsdl:message>
  <wsdl:message name="GetStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetStatusResponse">
    <wsdl:part name="parameters" element="tns:GetStatusResponse" />
  </wsdl:message>
  <wsdl:message name="GetStatusResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetEnabledRequest">
    <wsdl:part name="parameters" element="tns:SetEnabled" />
  </wsdl:message>
  <wsdl:message name="SetEnabledRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetEnabledResponse">
    <wsdl:part name="parameters" element="tns:SetEnabledResponse" />
  </wsdl:message>
  <wsdl:message name="SetEnabledResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetSingleWordOperatorRequest">
    <wsdl:part name="parameters" element="tns:SetSingleWordOperator" />
  </wsdl:message>
  <wsdl:message name="SetSingleWordOperatorRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetSingleWordOperatorResponse">
    <wsdl:part name="parameters" element="tns:SetSingleWordOperatorResponse" />
  </wsdl:message>
  <wsdl:message name="SetSingleWordOperatorResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetMultiWordOperatorRequest">
    <wsdl:part name="parameters" element="tns:SetMultiWordOperator" />
  </wsdl:message>
  <wsdl:message name="SetMultiWordOperatorRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetMultiWordOperatorResponse">
    <wsdl:part name="parameters" element="tns:SetMultiWordOperatorResponse" />
  </wsdl:message>
  <wsdl:message name="SetMultiWordOperatorResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RegenerateIndexRequest">
    <wsdl:part name="parameters" element="tns:RegenerateIndex" />
  </wsdl:message>
  <wsdl:message name="RegenerateIndexRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RegenerateIndexResponse">
    <wsdl:part name="parameters" element="tns:RegenerateIndexResponse" />
  </wsdl:message>
  <wsdl:message name="RegenerateIndexResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FreetextIndexRowsRequest">
    <wsdl:part name="parameters" element="tns:FreetextIndexRows" />
  </wsdl:message>
  <wsdl:message name="FreetextIndexRowsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FreetextIndexRowsResponse">
    <wsdl:part name="parameters" element="tns:FreetextIndexRowsResponse" />
  </wsdl:message>
  <wsdl:message name="FreetextIndexRowsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="FreeText">
    <wsdl:operation name="GetStatus">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/FreeText/GetStatus" name="GetStatusRequest" message="tns:GetStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/FreeText/GetStatusResponse" name="GetStatusResponse" message="tns:GetStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetEnabled">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/FreeText/SetEnabled" name="SetEnabledRequest" message="tns:SetEnabledRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/FreeText/SetEnabledResponse" name="SetEnabledResponse" message="tns:SetEnabledResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetSingleWordOperator">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/FreeText/SetSingleWordOperator" name="SetSingleWordOperatorRequest" message="tns:SetSingleWordOperatorRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/FreeText/SetSingleWordOperatorResponse" name="SetSingleWordOperatorResponse" message="tns:SetSingleWordOperatorResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetMultiWordOperator">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/FreeText/SetMultiWordOperator" name="SetMultiWordOperatorRequest" message="tns:SetMultiWordOperatorRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/FreeText/SetMultiWordOperatorResponse" name="SetMultiWordOperatorResponse" message="tns:SetMultiWordOperatorResponse" />
    </wsdl:operation>
    <wsdl:operation name="RegenerateIndex">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/FreeText/RegenerateIndex" name="RegenerateIndexRequest" message="tns:RegenerateIndexRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/FreeText/RegenerateIndexResponse" name="RegenerateIndexResponse" message="tns:RegenerateIndexResponse" />
    </wsdl:operation>
    <wsdl:operation name="FreetextIndexRows">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/FreeText/FreetextIndexRows" name="FreetextIndexRowsRequest" message="tns:FreetextIndexRowsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/FreeText/FreetextIndexRowsResponse" name="FreetextIndexRowsResponse" message="tns:FreetextIndexRowsResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_FreeText" type="tns:FreeText">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="GetStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/FreeText/GetStatus" style="document" />
      <wsdl:input name="GetStatusRequest">
        <soap:header message="tns:GetStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetStatusResponse">
        <soap:header message="tns:GetStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetStatusResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetEnabled">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/FreeText/SetEnabled" style="document" />
      <wsdl:input name="SetEnabledRequest">
        <soap:header message="tns:SetEnabledRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetEnabledRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetEnabledRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetEnabledResponse">
        <soap:header message="tns:SetEnabledResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetEnabledResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetEnabledResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetEnabledResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetSingleWordOperator">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/FreeText/SetSingleWordOperator" style="document" />
      <wsdl:input name="SetSingleWordOperatorRequest">
        <soap:header message="tns:SetSingleWordOperatorRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetSingleWordOperatorRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetSingleWordOperatorRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetSingleWordOperatorResponse">
        <soap:header message="tns:SetSingleWordOperatorResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetSingleWordOperatorResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetSingleWordOperatorResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetSingleWordOperatorResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetMultiWordOperator">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/FreeText/SetMultiWordOperator" style="document" />
      <wsdl:input name="SetMultiWordOperatorRequest">
        <soap:header message="tns:SetMultiWordOperatorRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetMultiWordOperatorRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetMultiWordOperatorRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetMultiWordOperatorResponse">
        <soap:header message="tns:SetMultiWordOperatorResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetMultiWordOperatorResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetMultiWordOperatorResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetMultiWordOperatorResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RegenerateIndex">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/FreeText/RegenerateIndex" style="document" />
      <wsdl:input name="RegenerateIndexRequest">
        <soap:header message="tns:RegenerateIndexRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RegenerateIndexRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RegenerateIndexRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RegenerateIndexResponse">
        <soap:header message="tns:RegenerateIndexResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RegenerateIndexResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RegenerateIndexResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RegenerateIndexResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FreetextIndexRows">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/FreeText/FreetextIndexRows" style="document" />
      <wsdl:input name="FreetextIndexRowsRequest">
        <soap:header message="tns:FreetextIndexRowsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FreetextIndexRowsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FreetextIndexRowsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FreetextIndexRowsResponse">
        <soap:header message="tns:FreetextIndexRowsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FreetextIndexRowsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FreetextIndexRowsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FreetextIndexRowsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfFreeTextService">
    <wsdl:port name="BasicHttpBinding_FreeText" binding="tns:BasicHttpBinding_FreeText">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/FreeText.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

