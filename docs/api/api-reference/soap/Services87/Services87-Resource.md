---
Generated: 1
TOCExclude: 1
title: Services87.ResourceAgent WSDL
---

# Services87.ResourceAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfResourceService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="SetResourceSubstitution">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ResourceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ResourceValues" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Culture" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
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
      <xs:element name="SetResourceSubstitutionResponse">
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
      <xs:element name="DeleteResourceSubstitution">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ResourceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Culture" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteResourceSubstitutionResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ActivateResourceSubstitution">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ResourceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Culture" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ActivateResourceSubstitutionResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetResourceSubstitutions">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ResourceNames" nillable="true" type="q1:ArrayOfstring" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Culture" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ActiveOnly" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetResourceSubstitutionsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfResourceOverride" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfResourceOverride">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ResourceOverride" nillable="true" type="tns:ResourceOverride" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfResourceOverride" nillable="true" type="tns:ArrayOfResourceOverride" />
      <xs:complexType name="ResourceOverride">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ResourceName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ResourceValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Culture" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ResourceOverride" nillable="true" type="tns:ResourceOverride" />
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
      <xs:element name="IsResourceSubstitutionActive">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ResourceNames" nillable="true" type="q2:ArrayOfstring" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Culture" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="IsResourceSubstitutionActiveResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfResourceOverride" />
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
  <wsdl:message name="SetResourceSubstitutionRequest">
    <wsdl:part name="parameters" element="tns:SetResourceSubstitution" />
  </wsdl:message>
  <wsdl:message name="SetResourceSubstitutionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetResourceSubstitutionResponse">
    <wsdl:part name="parameters" element="tns:SetResourceSubstitutionResponse" />
  </wsdl:message>
  <wsdl:message name="SetResourceSubstitutionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteResourceSubstitutionRequest">
    <wsdl:part name="parameters" element="tns:DeleteResourceSubstitution" />
  </wsdl:message>
  <wsdl:message name="DeleteResourceSubstitutionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteResourceSubstitutionResponse">
    <wsdl:part name="parameters" element="tns:DeleteResourceSubstitutionResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteResourceSubstitutionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ActivateResourceSubstitutionRequest">
    <wsdl:part name="parameters" element="tns:ActivateResourceSubstitution" />
  </wsdl:message>
  <wsdl:message name="ActivateResourceSubstitutionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ActivateResourceSubstitutionResponse">
    <wsdl:part name="parameters" element="tns:ActivateResourceSubstitutionResponse" />
  </wsdl:message>
  <wsdl:message name="ActivateResourceSubstitutionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetResourceSubstitutionsRequest">
    <wsdl:part name="parameters" element="tns:GetResourceSubstitutions" />
  </wsdl:message>
  <wsdl:message name="GetResourceSubstitutionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetResourceSubstitutionsResponse">
    <wsdl:part name="parameters" element="tns:GetResourceSubstitutionsResponse" />
  </wsdl:message>
  <wsdl:message name="GetResourceSubstitutionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsResourceSubstitutionActiveRequest">
    <wsdl:part name="parameters" element="tns:IsResourceSubstitutionActive" />
  </wsdl:message>
  <wsdl:message name="IsResourceSubstitutionActiveRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsResourceSubstitutionActiveResponse">
    <wsdl:part name="parameters" element="tns:IsResourceSubstitutionActiveResponse" />
  </wsdl:message>
  <wsdl:message name="IsResourceSubstitutionActiveResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Resource">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Resource</summary>
    </wsdl:documentation>
    <wsdl:operation name="SetResourceSubstitution">
      <wsdl:documentation>
        <summary>Create or update a resource substitution</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Resource/SetResourceSubstitution" name="SetResourceSubstitutionRequest" message="tns:SetResourceSubstitutionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Resource/SetResourceSubstitutionResponse" name="SetResourceSubstitutionResponse" message="tns:SetResourceSubstitutionResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteResourceSubstitution">
      <wsdl:documentation>
        <summary>Permanentely delete a resource substitution for one or more cultures</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Resource/DeleteResourceSubstitution" name="DeleteResourceSubstitutionRequest" message="tns:DeleteResourceSubstitutionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Resource/DeleteResourceSubstitutionResponse" name="DeleteResourceSubstitutionResponse" message="tns:DeleteResourceSubstitutionResponse" />
    </wsdl:operation>
    <wsdl:operation name="ActivateResourceSubstitution">
      <wsdl:documentation>
        <summary>Activate or deactive a resource substitution for one or more cultures</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Resource/ActivateResourceSubstitution" name="ActivateResourceSubstitutionRequest" message="tns:ActivateResourceSubstitutionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Resource/ActivateResourceSubstitutionResponse" name="ActivateResourceSubstitutionResponse" message="tns:ActivateResourceSubstitutionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetResourceSubstitutions">
      <wsdl:documentation>
        <summary>Get substitutions for some or all resources for one culture</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Resource/GetResourceSubstitutions" name="GetResourceSubstitutionsRequest" message="tns:GetResourceSubstitutionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Resource/GetResourceSubstitutionsResponse" name="GetResourceSubstitutionsResponse" message="tns:GetResourceSubstitutionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="IsResourceSubstitutionActive">
      <wsdl:documentation>
        <summary>Determine if resource substitution/override is active, globally or for a subset of resources/cultures</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Resource/IsResourceSubstitutionActive" name="IsResourceSubstitutionActiveRequest" message="tns:IsResourceSubstitutionActiveRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Resource/IsResourceSubstitutionActiveResponse" name="IsResourceSubstitutionActiveResponse" message="tns:IsResourceSubstitutionActiveResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Resource" type="tns:Resource">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="SetResourceSubstitution">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Resource/SetResourceSubstitution" style="document" />
      <wsdl:input name="SetResourceSubstitutionRequest">
        <soap:header message="tns:SetResourceSubstitutionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetResourceSubstitutionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetResourceSubstitutionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetResourceSubstitutionResponse">
        <soap:header message="tns:SetResourceSubstitutionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetResourceSubstitutionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetResourceSubstitutionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetResourceSubstitutionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteResourceSubstitution">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Resource/DeleteResourceSubstitution" style="document" />
      <wsdl:input name="DeleteResourceSubstitutionRequest">
        <soap:header message="tns:DeleteResourceSubstitutionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteResourceSubstitutionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteResourceSubstitutionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteResourceSubstitutionResponse">
        <soap:header message="tns:DeleteResourceSubstitutionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteResourceSubstitutionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteResourceSubstitutionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteResourceSubstitutionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ActivateResourceSubstitution">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Resource/ActivateResourceSubstitution" style="document" />
      <wsdl:input name="ActivateResourceSubstitutionRequest">
        <soap:header message="tns:ActivateResourceSubstitutionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ActivateResourceSubstitutionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ActivateResourceSubstitutionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ActivateResourceSubstitutionResponse">
        <soap:header message="tns:ActivateResourceSubstitutionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ActivateResourceSubstitutionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ActivateResourceSubstitutionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ActivateResourceSubstitutionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetResourceSubstitutions">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Resource/GetResourceSubstitutions" style="document" />
      <wsdl:input name="GetResourceSubstitutionsRequest">
        <soap:header message="tns:GetResourceSubstitutionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetResourceSubstitutionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetResourceSubstitutionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetResourceSubstitutionsResponse">
        <soap:header message="tns:GetResourceSubstitutionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetResourceSubstitutionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetResourceSubstitutionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetResourceSubstitutionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="IsResourceSubstitutionActive">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Resource/IsResourceSubstitutionActive" style="document" />
      <wsdl:input name="IsResourceSubstitutionActiveRequest">
        <soap:header message="tns:IsResourceSubstitutionActiveRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:IsResourceSubstitutionActiveRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:IsResourceSubstitutionActiveRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="IsResourceSubstitutionActiveResponse">
        <soap:header message="tns:IsResourceSubstitutionActiveResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:IsResourceSubstitutionActiveResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:IsResourceSubstitutionActiveResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:IsResourceSubstitutionActiveResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfResourceService">
    <wsdl:port name="BasicHttpBinding_Resource" binding="tns:BasicHttpBinding_Resource">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services87/Resource.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

