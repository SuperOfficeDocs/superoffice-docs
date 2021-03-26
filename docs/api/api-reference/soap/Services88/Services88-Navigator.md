---
Generated: 1
TOCExclude: 1
title: Services88.NavigatorAgent WSDL
---

# Services88.NavigatorAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfNavigatorService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="GetNavigatorCompany">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NavigatorCompanyId" type="xs:int" />
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
      <xs:element name="GetNavigatorCompanyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:NavigatorCompany" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="NavigatorCompany">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="NavigatorCompany" nillable="true" type="tns:NavigatorCompany" />
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
      <xs:element name="GetAllNavigatorCompany">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllNavigatorCompanyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfNavigatorCompany" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfNavigatorCompany">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="NavigatorCompany" nillable="true" type="tns:NavigatorCompany" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfNavigatorCompany" nillable="true" type="tns:ArrayOfNavigatorCompany" />
      <xs:element name="GetNavigatorCompanyList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NavigatorCompanyIds" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNavigatorCompanyListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfNavigatorCompany" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNavigatorCompanies">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNavigatorCompaniesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfNavigatorCompany" />
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
  <wsdl:message name="GetNavigatorCompanyRequest">
    <wsdl:part name="parameters" element="tns:GetNavigatorCompany" />
  </wsdl:message>
  <wsdl:message name="GetNavigatorCompanyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNavigatorCompanyResponse">
    <wsdl:part name="parameters" element="tns:GetNavigatorCompanyResponse" />
  </wsdl:message>
  <wsdl:message name="GetNavigatorCompanyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllNavigatorCompanyRequest">
    <wsdl:part name="parameters" element="tns:GetAllNavigatorCompany" />
  </wsdl:message>
  <wsdl:message name="GetAllNavigatorCompanyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllNavigatorCompanyResponse">
    <wsdl:part name="parameters" element="tns:GetAllNavigatorCompanyResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllNavigatorCompanyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNavigatorCompanyListRequest">
    <wsdl:part name="parameters" element="tns:GetNavigatorCompanyList" />
  </wsdl:message>
  <wsdl:message name="GetNavigatorCompanyListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNavigatorCompanyListResponse">
    <wsdl:part name="parameters" element="tns:GetNavigatorCompanyListResponse" />
  </wsdl:message>
  <wsdl:message name="GetNavigatorCompanyListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNavigatorCompaniesRequest">
    <wsdl:part name="parameters" element="tns:GetNavigatorCompanies" />
  </wsdl:message>
  <wsdl:message name="GetNavigatorCompaniesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNavigatorCompaniesResponse">
    <wsdl:part name="parameters" element="tns:GetNavigatorCompaniesResponse" />
  </wsdl:message>
  <wsdl:message name="GetNavigatorCompaniesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Navigator">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Navigator</summary>
    </wsdl:documentation>
    <wsdl:operation name="GetNavigatorCompany">
      <wsdl:documentation>
        <summary>Gets a NavigatorCompany object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Navigator/GetNavigatorCompany" name="GetNavigatorCompanyRequest" message="tns:GetNavigatorCompanyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Navigator/GetNavigatorCompanyResponse" name="GetNavigatorCompanyResponse" message="tns:GetNavigatorCompanyResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllNavigatorCompany">
      <wsdl:documentation>
        <summary>Gets an array of all NavigatorCompany objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Navigator/GetAllNavigatorCompany" name="GetAllNavigatorCompanyRequest" message="tns:GetAllNavigatorCompanyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Navigator/GetAllNavigatorCompanyResponse" name="GetAllNavigatorCompanyResponse" message="tns:GetAllNavigatorCompanyResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNavigatorCompanyList">
      <wsdl:documentation>
        <summary>Gets an array of NavigatorCompany objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Navigator/GetNavigatorCompanyList" name="GetNavigatorCompanyListRequest" message="tns:GetNavigatorCompanyListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Navigator/GetNavigatorCompanyListResponse" name="GetNavigatorCompanyListResponse" message="tns:GetNavigatorCompanyListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNavigatorCompanies">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Navigator/GetNavigatorCompanies" name="GetNavigatorCompaniesRequest" message="tns:GetNavigatorCompaniesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Navigator/GetNavigatorCompaniesResponse" name="GetNavigatorCompaniesResponse" message="tns:GetNavigatorCompaniesResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Navigator" type="tns:Navigator">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="GetNavigatorCompany">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Navigator/GetNavigatorCompany" style="document" />
      <wsdl:input name="GetNavigatorCompanyRequest">
        <soap:header message="tns:GetNavigatorCompanyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNavigatorCompanyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNavigatorCompanyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNavigatorCompanyResponse">
        <soap:header message="tns:GetNavigatorCompanyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNavigatorCompanyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNavigatorCompanyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNavigatorCompanyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllNavigatorCompany">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Navigator/GetAllNavigatorCompany" style="document" />
      <wsdl:input name="GetAllNavigatorCompanyRequest">
        <soap:header message="tns:GetAllNavigatorCompanyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllNavigatorCompanyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllNavigatorCompanyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllNavigatorCompanyResponse">
        <soap:header message="tns:GetAllNavigatorCompanyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllNavigatorCompanyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllNavigatorCompanyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllNavigatorCompanyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNavigatorCompanyList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Navigator/GetNavigatorCompanyList" style="document" />
      <wsdl:input name="GetNavigatorCompanyListRequest">
        <soap:header message="tns:GetNavigatorCompanyListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNavigatorCompanyListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNavigatorCompanyListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNavigatorCompanyListResponse">
        <soap:header message="tns:GetNavigatorCompanyListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNavigatorCompanyListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNavigatorCompanyListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNavigatorCompanyListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNavigatorCompanies">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Navigator/GetNavigatorCompanies" style="document" />
      <wsdl:input name="GetNavigatorCompaniesRequest">
        <soap:header message="tns:GetNavigatorCompaniesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNavigatorCompaniesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNavigatorCompaniesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNavigatorCompaniesResponse">
        <soap:header message="tns:GetNavigatorCompaniesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNavigatorCompaniesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNavigatorCompaniesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNavigatorCompaniesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfNavigatorService">
    <wsdl:port name="BasicHttpBinding_Navigator" binding="tns:BasicHttpBinding_Navigator">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/Navigator.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

