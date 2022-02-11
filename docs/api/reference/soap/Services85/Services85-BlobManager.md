---
generated: 1
uid: wsdl-Services85-BlobManager
title: Services85.BlobManagerAgent WSDL
---

# Services85.BlobManagerAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfBlobManagerService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services85" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services85" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services85" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:element name="ReadBlob">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BlobId" type="xs:int" />
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
      <xs:element name="ReadBlobResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Length" type="xs:int" />
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
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
      <xs:element name="WriteBlob">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BlobId" type="xs:int" />
            <xs:element minOccurs="0" name="Blob" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="WriteBlobResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="BeginReadBlobPart">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BlobId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="BeginReadBlobPartResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:long" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ReadBlobPart">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BlobId" type="xs:int" />
            <xs:element minOccurs="0" name="BlobPosition" type="xs:long" />
            <xs:element minOccurs="0" name="Length" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ReadBlobPartResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Length" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="EndReadBlobPart">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BlobId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="EndReadBlobPartResponse">
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
  <wsdl:message name="ReadBlobRequest">
    <wsdl:part name="parameters" element="tns:ReadBlob" />
  </wsdl:message>
  <wsdl:message name="ReadBlobRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ReadBlobResponse">
    <wsdl:part name="parameters" element="tns:ReadBlobResponse" />
  </wsdl:message>
  <wsdl:message name="ReadBlobResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="WriteBlobRequest">
    <wsdl:part name="parameters" element="tns:WriteBlob" />
  </wsdl:message>
  <wsdl:message name="WriteBlobRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="WriteBlobResponse">
    <wsdl:part name="parameters" element="tns:WriteBlobResponse" />
  </wsdl:message>
  <wsdl:message name="WriteBlobResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="BeginReadBlobPartRequest">
    <wsdl:part name="parameters" element="tns:BeginReadBlobPart" />
  </wsdl:message>
  <wsdl:message name="BeginReadBlobPartRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="BeginReadBlobPartResponse">
    <wsdl:part name="parameters" element="tns:BeginReadBlobPartResponse" />
  </wsdl:message>
  <wsdl:message name="BeginReadBlobPartResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ReadBlobPartRequest">
    <wsdl:part name="parameters" element="tns:ReadBlobPart" />
  </wsdl:message>
  <wsdl:message name="ReadBlobPartRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ReadBlobPartResponse">
    <wsdl:part name="parameters" element="tns:ReadBlobPartResponse" />
  </wsdl:message>
  <wsdl:message name="ReadBlobPartResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="EndReadBlobPartRequest">
    <wsdl:part name="parameters" element="tns:EndReadBlobPart" />
  </wsdl:message>
  <wsdl:message name="EndReadBlobPartRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="EndReadBlobPartResponse">
    <wsdl:part name="parameters" element="tns:EndReadBlobPartResponse" />
  </wsdl:message>
  <wsdl:message name="EndReadBlobPartResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="BlobManager">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for custom blob streaming</summary>
    </wsdl:documentation>
    <wsdl:operation name="ReadBlob">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BlobManager/ReadBlob" name="ReadBlobRequest" message="tns:ReadBlobRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BlobManager/ReadBlobResponse" name="ReadBlobResponse" message="tns:ReadBlobResponse" />
    </wsdl:operation>
    <wsdl:operation name="WriteBlob">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BlobManager/WriteBlob" name="WriteBlobRequest" message="tns:WriteBlobRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BlobManager/WriteBlobResponse" name="WriteBlobResponse" message="tns:WriteBlobResponse" />
    </wsdl:operation>
    <wsdl:operation name="BeginReadBlobPart">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BlobManager/BeginReadBlobPart" name="BeginReadBlobPartRequest" message="tns:BeginReadBlobPartRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BlobManager/BeginReadBlobPartResponse" name="BeginReadBlobPartResponse" message="tns:BeginReadBlobPartResponse" />
    </wsdl:operation>
    <wsdl:operation name="ReadBlobPart">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BlobManager/ReadBlobPart" name="ReadBlobPartRequest" message="tns:ReadBlobPartRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BlobManager/ReadBlobPartResponse" name="ReadBlobPartResponse" message="tns:ReadBlobPartResponse" />
    </wsdl:operation>
    <wsdl:operation name="EndReadBlobPart">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BlobManager/EndReadBlobPart" name="EndReadBlobPartRequest" message="tns:EndReadBlobPartRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/BlobManager/EndReadBlobPartResponse" name="EndReadBlobPartResponse" message="tns:EndReadBlobPartResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_BlobManager" type="tns:BlobManager">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="ReadBlob">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/BlobManager/ReadBlob" style="document" />
      <wsdl:input name="ReadBlobRequest">
        <soap:header message="tns:ReadBlobRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ReadBlobRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ReadBlobRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ReadBlobResponse">
        <soap:header message="tns:ReadBlobResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ReadBlobResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ReadBlobResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ReadBlobResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="WriteBlob">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/BlobManager/WriteBlob" style="document" />
      <wsdl:input name="WriteBlobRequest">
        <soap:header message="tns:WriteBlobRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:WriteBlobRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:WriteBlobRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="WriteBlobResponse">
        <soap:header message="tns:WriteBlobResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:WriteBlobResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:WriteBlobResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:WriteBlobResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="BeginReadBlobPart">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/BlobManager/BeginReadBlobPart" style="document" />
      <wsdl:input name="BeginReadBlobPartRequest">
        <soap:header message="tns:BeginReadBlobPartRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:BeginReadBlobPartRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:BeginReadBlobPartRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="BeginReadBlobPartResponse">
        <soap:header message="tns:BeginReadBlobPartResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:BeginReadBlobPartResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:BeginReadBlobPartResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:BeginReadBlobPartResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ReadBlobPart">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/BlobManager/ReadBlobPart" style="document" />
      <wsdl:input name="ReadBlobPartRequest">
        <soap:header message="tns:ReadBlobPartRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ReadBlobPartRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ReadBlobPartRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ReadBlobPartResponse">
        <soap:header message="tns:ReadBlobPartResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ReadBlobPartResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ReadBlobPartResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ReadBlobPartResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="EndReadBlobPart">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/BlobManager/EndReadBlobPart" style="document" />
      <wsdl:input name="EndReadBlobPartRequest">
        <soap:header message="tns:EndReadBlobPartRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:EndReadBlobPartRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:EndReadBlobPartRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="EndReadBlobPartResponse">
        <soap:header message="tns:EndReadBlobPartResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:EndReadBlobPartResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:EndReadBlobPartResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:EndReadBlobPartResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfBlobManagerService">
    <wsdl:port name="BasicHttpBinding_BlobManager" binding="tns:BasicHttpBinding_BlobManager">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services85/BlobManager.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

