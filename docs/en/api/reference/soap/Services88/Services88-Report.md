---
generated: true
uid: wsdl-Services88-Report
title: Services88.ReportAgent WSDL
content_type: reference
---

# Services88.ReportAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfReportService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:element name="CreateDefaultReportLabelLayoutEntity">
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
      <xs:element name="CreateDefaultReportLabelLayoutEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReportLabelLayoutEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ReportLabelLayoutEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ReportLabelLayoutId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Orientation" type="tns:ReportPaperOrientation" />
              <xs:element minOccurs="0" name="PaperWidth" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="PaperHeight" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="LeftMargin" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="RightMargin" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="TopMargin" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="BottomMargin" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="CountColumns" type="xs:short" />
              <xs:element minOccurs="0" name="CountRows" type="xs:short" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ReportLabelLayoutEntity" nillable="true" type="tns:ReportLabelLayoutEntity" />
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
      <xs:simpleType name="ReportPaperOrientation">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Portrait" />
          <xs:enumeration value="Landscape" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ReportPaperOrientation" nillable="true" type="tns:ReportPaperOrientation" />
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
      <xs:element name="SaveReportLabelLayoutEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReportLabelLayoutEntity" nillable="true" type="tns:ReportLabelLayoutEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveReportLabelLayoutEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReportLabelLayoutEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteReportLabelLayoutEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReportLabelLayoutEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteReportLabelLayoutEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetReportLabelLayoutEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReportLabelLayoutEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetReportLabelLayoutEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReportLabelLayoutEntity" />
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
  </wsdl:types>
  <wsdl:message name="CreateDefaultReportLabelLayoutEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultReportLabelLayoutEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultReportLabelLayoutEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultReportLabelLayoutEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultReportLabelLayoutEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultReportLabelLayoutEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveReportLabelLayoutEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveReportLabelLayoutEntity" />
  </wsdl:message>
  <wsdl:message name="SaveReportLabelLayoutEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveReportLabelLayoutEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveReportLabelLayoutEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveReportLabelLayoutEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteReportLabelLayoutEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteReportLabelLayoutEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteReportLabelLayoutEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteReportLabelLayoutEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteReportLabelLayoutEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteReportLabelLayoutEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReportLabelLayoutEntityRequest">
    <wsdl:part name="parameters" element="tns:GetReportLabelLayoutEntity" />
  </wsdl:message>
  <wsdl:message name="GetReportLabelLayoutEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReportLabelLayoutEntityResponse">
    <wsdl:part name="parameters" element="tns:GetReportLabelLayoutEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetReportLabelLayoutEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Report">
    <wsdl:operation name="CreateDefaultReportLabelLayoutEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Report/CreateDefaultReportLabelLayoutEntity" name="CreateDefaultReportLabelLayoutEntityRequest" message="tns:CreateDefaultReportLabelLayoutEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Report/CreateDefaultReportLabelLayoutEntityResponse" name="CreateDefaultReportLabelLayoutEntityResponse" message="tns:CreateDefaultReportLabelLayoutEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveReportLabelLayoutEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Report/SaveReportLabelLayoutEntity" name="SaveReportLabelLayoutEntityRequest" message="tns:SaveReportLabelLayoutEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Report/SaveReportLabelLayoutEntityResponse" name="SaveReportLabelLayoutEntityResponse" message="tns:SaveReportLabelLayoutEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteReportLabelLayoutEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Report/DeleteReportLabelLayoutEntity" name="DeleteReportLabelLayoutEntityRequest" message="tns:DeleteReportLabelLayoutEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Report/DeleteReportLabelLayoutEntityResponse" name="DeleteReportLabelLayoutEntityResponse" message="tns:DeleteReportLabelLayoutEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetReportLabelLayoutEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Report/GetReportLabelLayoutEntity" name="GetReportLabelLayoutEntityRequest" message="tns:GetReportLabelLayoutEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Report/GetReportLabelLayoutEntityResponse" name="GetReportLabelLayoutEntityResponse" message="tns:GetReportLabelLayoutEntityResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Report" type="tns:Report">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultReportLabelLayoutEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Report/CreateDefaultReportLabelLayoutEntity" style="document" />
      <wsdl:input name="CreateDefaultReportLabelLayoutEntityRequest">
        <soap:header message="tns:CreateDefaultReportLabelLayoutEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultReportLabelLayoutEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultReportLabelLayoutEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultReportLabelLayoutEntityResponse">
        <soap:header message="tns:CreateDefaultReportLabelLayoutEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultReportLabelLayoutEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultReportLabelLayoutEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultReportLabelLayoutEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveReportLabelLayoutEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Report/SaveReportLabelLayoutEntity" style="document" />
      <wsdl:input name="SaveReportLabelLayoutEntityRequest">
        <soap:header message="tns:SaveReportLabelLayoutEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveReportLabelLayoutEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveReportLabelLayoutEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveReportLabelLayoutEntityResponse">
        <soap:header message="tns:SaveReportLabelLayoutEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveReportLabelLayoutEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveReportLabelLayoutEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveReportLabelLayoutEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteReportLabelLayoutEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Report/DeleteReportLabelLayoutEntity" style="document" />
      <wsdl:input name="DeleteReportLabelLayoutEntityRequest">
        <soap:header message="tns:DeleteReportLabelLayoutEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteReportLabelLayoutEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteReportLabelLayoutEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteReportLabelLayoutEntityResponse">
        <soap:header message="tns:DeleteReportLabelLayoutEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteReportLabelLayoutEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteReportLabelLayoutEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteReportLabelLayoutEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetReportLabelLayoutEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Report/GetReportLabelLayoutEntity" style="document" />
      <wsdl:input name="GetReportLabelLayoutEntityRequest">
        <soap:header message="tns:GetReportLabelLayoutEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetReportLabelLayoutEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetReportLabelLayoutEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetReportLabelLayoutEntityResponse">
        <soap:header message="tns:GetReportLabelLayoutEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetReportLabelLayoutEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetReportLabelLayoutEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetReportLabelLayoutEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfReportService">
    <wsdl:port name="BasicHttpBinding_Report" binding="tns:BasicHttpBinding_Report">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/Report.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

