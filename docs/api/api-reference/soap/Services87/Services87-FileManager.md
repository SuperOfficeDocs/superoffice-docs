---
Generated: 1
TOCExclude: 1
title: Services87.FileManagerAgent WSDL
---

# Services87.FileManagerAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfFileManagerService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:element name="CreateFile">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="OverwriteExistingStream" type="xs:boolean" />
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
      <xs:element name="CreateFileResponse">
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
      <xs:element name="ReadFile">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ReadFileResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FileName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Length" type="xs:int" />
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="WriteFile">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="Document" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="WriteFileResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="BeginReadFilePart">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="BeginReadFilePartResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FileName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Length" type="xs:long" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ReadFilePart">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="FilePosition" type="xs:long" />
            <xs:element minOccurs="0" name="Length" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ReadFilePartResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Length" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="EndReadFilePart">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="EndReadFilePartResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="BeginWriteFilePart">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="BeginWriteFilePartResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="WriteFilePart">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="FilePosition" type="xs:long" />
            <xs:element minOccurs="0" name="DocumentData" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="WriteFilePartResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="EndWriteFilePart">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="EndWriteFilePartResponse">
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
  <wsdl:message name="CreateFileRequest">
    <wsdl:part name="parameters" element="tns:CreateFile" />
  </wsdl:message>
  <wsdl:message name="CreateFileRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateFileResponse">
    <wsdl:part name="parameters" element="tns:CreateFileResponse" />
  </wsdl:message>
  <wsdl:message name="CreateFileResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ReadFileRequest">
    <wsdl:part name="parameters" element="tns:ReadFile" />
  </wsdl:message>
  <wsdl:message name="ReadFileRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ReadFileResponse">
    <wsdl:part name="parameters" element="tns:ReadFileResponse" />
  </wsdl:message>
  <wsdl:message name="ReadFileResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="WriteFileRequest">
    <wsdl:part name="parameters" element="tns:WriteFile" />
  </wsdl:message>
  <wsdl:message name="WriteFileRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="WriteFileResponse">
    <wsdl:part name="parameters" element="tns:WriteFileResponse" />
  </wsdl:message>
  <wsdl:message name="WriteFileResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="BeginReadFilePartRequest">
    <wsdl:part name="parameters" element="tns:BeginReadFilePart" />
  </wsdl:message>
  <wsdl:message name="BeginReadFilePartRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="BeginReadFilePartResponse">
    <wsdl:part name="parameters" element="tns:BeginReadFilePartResponse" />
  </wsdl:message>
  <wsdl:message name="BeginReadFilePartResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ReadFilePartRequest">
    <wsdl:part name="parameters" element="tns:ReadFilePart" />
  </wsdl:message>
  <wsdl:message name="ReadFilePartRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ReadFilePartResponse">
    <wsdl:part name="parameters" element="tns:ReadFilePartResponse" />
  </wsdl:message>
  <wsdl:message name="ReadFilePartResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="EndReadFilePartRequest">
    <wsdl:part name="parameters" element="tns:EndReadFilePart" />
  </wsdl:message>
  <wsdl:message name="EndReadFilePartRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="EndReadFilePartResponse">
    <wsdl:part name="parameters" element="tns:EndReadFilePartResponse" />
  </wsdl:message>
  <wsdl:message name="EndReadFilePartResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="BeginWriteFilePartRequest">
    <wsdl:part name="parameters" element="tns:BeginWriteFilePart" />
  </wsdl:message>
  <wsdl:message name="BeginWriteFilePartRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="BeginWriteFilePartResponse">
    <wsdl:part name="parameters" element="tns:BeginWriteFilePartResponse" />
  </wsdl:message>
  <wsdl:message name="BeginWriteFilePartResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="WriteFilePartRequest">
    <wsdl:part name="parameters" element="tns:WriteFilePart" />
  </wsdl:message>
  <wsdl:message name="WriteFilePartRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="WriteFilePartResponse">
    <wsdl:part name="parameters" element="tns:WriteFilePartResponse" />
  </wsdl:message>
  <wsdl:message name="WriteFilePartResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="EndWriteFilePartRequest">
    <wsdl:part name="parameters" element="tns:EndWriteFilePart" />
  </wsdl:message>
  <wsdl:message name="EndWriteFilePartRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="EndWriteFilePartResponse">
    <wsdl:part name="parameters" element="tns:EndWriteFilePartResponse" />
  </wsdl:message>
  <wsdl:message name="EndWriteFilePartResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="FileManager">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for custom File streaming</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateFile">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/CreateFile" name="CreateFileRequest" message="tns:CreateFileRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/CreateFileResponse" name="CreateFileResponse" message="tns:CreateFileResponse" />
    </wsdl:operation>
    <wsdl:operation name="ReadFile">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/ReadFile" name="ReadFileRequest" message="tns:ReadFileRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/ReadFileResponse" name="ReadFileResponse" message="tns:ReadFileResponse" />
    </wsdl:operation>
    <wsdl:operation name="WriteFile">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/WriteFile" name="WriteFileRequest" message="tns:WriteFileRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/WriteFileResponse" name="WriteFileResponse" message="tns:WriteFileResponse" />
    </wsdl:operation>
    <wsdl:operation name="BeginReadFilePart">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/BeginReadFilePart" name="BeginReadFilePartRequest" message="tns:BeginReadFilePartRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/BeginReadFilePartResponse" name="BeginReadFilePartResponse" message="tns:BeginReadFilePartResponse" />
    </wsdl:operation>
    <wsdl:operation name="ReadFilePart">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/ReadFilePart" name="ReadFilePartRequest" message="tns:ReadFilePartRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/ReadFilePartResponse" name="ReadFilePartResponse" message="tns:ReadFilePartResponse" />
    </wsdl:operation>
    <wsdl:operation name="EndReadFilePart">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/EndReadFilePart" name="EndReadFilePartRequest" message="tns:EndReadFilePartRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/EndReadFilePartResponse" name="EndReadFilePartResponse" message="tns:EndReadFilePartResponse" />
    </wsdl:operation>
    <wsdl:operation name="BeginWriteFilePart">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/BeginWriteFilePart" name="BeginWriteFilePartRequest" message="tns:BeginWriteFilePartRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/BeginWriteFilePartResponse" name="BeginWriteFilePartResponse" message="tns:BeginWriteFilePartResponse" />
    </wsdl:operation>
    <wsdl:operation name="WriteFilePart">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/WriteFilePart" name="WriteFilePartRequest" message="tns:WriteFilePartRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/WriteFilePartResponse" name="WriteFilePartResponse" message="tns:WriteFilePartResponse" />
    </wsdl:operation>
    <wsdl:operation name="EndWriteFilePart">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/EndWriteFilePart" name="EndWriteFilePartRequest" message="tns:EndWriteFilePartRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/EndWriteFilePartResponse" name="EndWriteFilePartResponse" message="tns:EndWriteFilePartResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_FileManager" type="tns:FileManager">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateFile">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/CreateFile" style="document" />
      <wsdl:input name="CreateFileRequest">
        <soap:header message="tns:CreateFileRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateFileRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateFileRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateFileResponse">
        <soap:header message="tns:CreateFileResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateFileResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateFileResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateFileResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ReadFile">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/ReadFile" style="document" />
      <wsdl:input name="ReadFileRequest">
        <soap:header message="tns:ReadFileRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ReadFileRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ReadFileRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ReadFileResponse">
        <soap:header message="tns:ReadFileResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ReadFileResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ReadFileResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ReadFileResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="WriteFile">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/WriteFile" style="document" />
      <wsdl:input name="WriteFileRequest">
        <soap:header message="tns:WriteFileRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:WriteFileRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:WriteFileRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="WriteFileResponse">
        <soap:header message="tns:WriteFileResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:WriteFileResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:WriteFileResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:WriteFileResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="BeginReadFilePart">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/BeginReadFilePart" style="document" />
      <wsdl:input name="BeginReadFilePartRequest">
        <soap:header message="tns:BeginReadFilePartRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:BeginReadFilePartRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:BeginReadFilePartRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="BeginReadFilePartResponse">
        <soap:header message="tns:BeginReadFilePartResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:BeginReadFilePartResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:BeginReadFilePartResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:BeginReadFilePartResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ReadFilePart">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/ReadFilePart" style="document" />
      <wsdl:input name="ReadFilePartRequest">
        <soap:header message="tns:ReadFilePartRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ReadFilePartRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ReadFilePartRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ReadFilePartResponse">
        <soap:header message="tns:ReadFilePartResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ReadFilePartResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ReadFilePartResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ReadFilePartResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="EndReadFilePart">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/EndReadFilePart" style="document" />
      <wsdl:input name="EndReadFilePartRequest">
        <soap:header message="tns:EndReadFilePartRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:EndReadFilePartRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:EndReadFilePartRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="EndReadFilePartResponse">
        <soap:header message="tns:EndReadFilePartResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:EndReadFilePartResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:EndReadFilePartResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:EndReadFilePartResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="BeginWriteFilePart">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/BeginWriteFilePart" style="document" />
      <wsdl:input name="BeginWriteFilePartRequest">
        <soap:header message="tns:BeginWriteFilePartRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:BeginWriteFilePartRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:BeginWriteFilePartRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="BeginWriteFilePartResponse">
        <soap:header message="tns:BeginWriteFilePartResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:BeginWriteFilePartResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:BeginWriteFilePartResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:BeginWriteFilePartResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="WriteFilePart">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/WriteFilePart" style="document" />
      <wsdl:input name="WriteFilePartRequest">
        <soap:header message="tns:WriteFilePartRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:WriteFilePartRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:WriteFilePartRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="WriteFilePartResponse">
        <soap:header message="tns:WriteFilePartResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:WriteFilePartResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:WriteFilePartResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:WriteFilePartResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="EndWriteFilePart">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/FileManager/EndWriteFilePart" style="document" />
      <wsdl:input name="EndWriteFilePartRequest">
        <soap:header message="tns:EndWriteFilePartRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:EndWriteFilePartRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:EndWriteFilePartRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="EndWriteFilePartResponse">
        <soap:header message="tns:EndWriteFilePartResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:EndWriteFilePartResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:EndWriteFilePartResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:EndWriteFilePartResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfFileManagerService">
    <wsdl:port name="BasicHttpBinding_FileManager" binding="tns:BasicHttpBinding_FileManager">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services87/FileManager.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

