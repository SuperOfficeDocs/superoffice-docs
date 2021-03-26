---
Generated: 1
TOCExclude: 1
title: Services85.SentryAgent WSDL
---

# Services85.SentryAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfSentryService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services85" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services85" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services85" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="GetNewTableRight">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
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
      <xs:element name="GetNewTableRightResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TableRight" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
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
      <xs:element name="GetTableRightByOwnership">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ContactGroupId" type="xs:int" />
            <xs:element minOccurs="0" name="ContactAssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTableRightByOwnershipResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TableRight" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFunctionRights">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFunctionRightsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q1:ArrayOfstring" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="HasFunctionRight">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FunctionRight" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="HasFunctionRightResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CanCreateAppointmentInAssociateDiaries">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateIds" nillable="true" type="q2:ArrayOfint" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CanCreateAppointmentInAssociateDiariesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CanCreateAppointmentInAllDiaries">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CanCreateAppointmentInAllDiariesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
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
      <xs:complexType name="ArrayOfint">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="int" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfint" nillable="true" type="tns:ArrayOfint" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="GetNewTableRightRequest">
    <wsdl:part name="parameters" element="tns:GetNewTableRight" />
  </wsdl:message>
  <wsdl:message name="GetNewTableRightRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNewTableRightResponse">
    <wsdl:part name="parameters" element="tns:GetNewTableRightResponse" />
  </wsdl:message>
  <wsdl:message name="GetNewTableRightResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTableRightByOwnershipRequest">
    <wsdl:part name="parameters" element="tns:GetTableRightByOwnership" />
  </wsdl:message>
  <wsdl:message name="GetTableRightByOwnershipRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTableRightByOwnershipResponse">
    <wsdl:part name="parameters" element="tns:GetTableRightByOwnershipResponse" />
  </wsdl:message>
  <wsdl:message name="GetTableRightByOwnershipResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFunctionRightsRequest">
    <wsdl:part name="parameters" element="tns:GetFunctionRights" />
  </wsdl:message>
  <wsdl:message name="GetFunctionRightsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFunctionRightsResponse">
    <wsdl:part name="parameters" element="tns:GetFunctionRightsResponse" />
  </wsdl:message>
  <wsdl:message name="GetFunctionRightsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasFunctionRightRequest">
    <wsdl:part name="parameters" element="tns:HasFunctionRight" />
  </wsdl:message>
  <wsdl:message name="HasFunctionRightRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasFunctionRightResponse">
    <wsdl:part name="parameters" element="tns:HasFunctionRightResponse" />
  </wsdl:message>
  <wsdl:message name="HasFunctionRightResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CanCreateAppointmentInAssociateDiariesRequest">
    <wsdl:part name="parameters" element="tns:CanCreateAppointmentInAssociateDiaries" />
  </wsdl:message>
  <wsdl:message name="CanCreateAppointmentInAssociateDiariesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CanCreateAppointmentInAssociateDiariesResponse">
    <wsdl:part name="parameters" element="tns:CanCreateAppointmentInAssociateDiariesResponse" />
  </wsdl:message>
  <wsdl:message name="CanCreateAppointmentInAssociateDiariesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CanCreateAppointmentInAllDiariesRequest">
    <wsdl:part name="parameters" element="tns:CanCreateAppointmentInAllDiaries" />
  </wsdl:message>
  <wsdl:message name="CanCreateAppointmentInAllDiariesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CanCreateAppointmentInAllDiariesResponse">
    <wsdl:part name="parameters" element="tns:CanCreateAppointmentInAllDiariesResponse" />
  </wsdl:message>
  <wsdl:message name="CanCreateAppointmentInAllDiariesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Sentry">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Sentry</summary>
    </wsdl:documentation>
    <wsdl:operation name="GetNewTableRight">
      <wsdl:documentation>
        <summary>Returns a TableRight for a new row based on tableName parameter.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Sentry/GetNewTableRight" name="GetNewTableRightRequest" message="tns:GetNewTableRightRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Sentry/GetNewTableRightResponse" name="GetNewTableRightResponse" message="tns:GetNewTableRightResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTableRightByOwnership">
      <wsdl:documentation>
        <summary>Return the TableRight from the relationship between the current user and the given user and group.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Sentry/GetTableRightByOwnership" name="GetTableRightByOwnershipRequest" message="tns:GetTableRightByOwnershipRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Sentry/GetTableRightByOwnershipResponse" name="GetTableRightByOwnershipResponse" message="tns:GetTableRightByOwnershipResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFunctionRights">
      <wsdl:documentation>
        <summary>Get a string array of all functions rights for the role of the current associate.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Sentry/GetFunctionRights" name="GetFunctionRightsRequest" message="tns:GetFunctionRightsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Sentry/GetFunctionRightsResponse" name="GetFunctionRightsResponse" message="tns:GetFunctionRightsResponse" />
    </wsdl:operation>
    <wsdl:operation name="HasFunctionRight">
      <wsdl:documentation>
        <summary>Get a boolean value indicating if the current user has the functional right.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Sentry/HasFunctionRight" name="HasFunctionRightRequest" message="tns:HasFunctionRightRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Sentry/HasFunctionRightResponse" name="HasFunctionRightResponse" message="tns:HasFunctionRightResponse" />
    </wsdl:operation>
    <wsdl:operation name="CanCreateAppointmentInAssociateDiaries">
      <wsdl:documentation>
        <summary>CanCreateAppointmentInAssociateDiaries will check if the current associate can create appointments in diaries belonging to the associates listed in associateIds. CanCreateAppointmentInAssociateDiaries will only check against associates that are diary owners. If none of the associates listed in the associateIds parameter is a diary owner, the method will return true.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Sentry/CanCreateAppointmentInAssociateDiaries" name="CanCreateAppointmentInAssociateDiariesRequest" message="tns:CanCreateAppointmentInAssociateDiariesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Sentry/CanCreateAppointmentInAssociateDiariesResponse" name="CanCreateAppointmentInAssociateDiariesResponse" message="tns:CanCreateAppointmentInAssociateDiariesResponse" />
    </wsdl:operation>
    <wsdl:operation name="CanCreateAppointmentInAllDiaries">
      <wsdl:documentation>
        <summary>CanCreateAppointmentInAllDiaries will check if the current associate can create appointments in diaries belonging all other associates. CanCreateAppointmentInAssociateDiaries will only check against associates that are diary owners.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Sentry/CanCreateAppointmentInAllDiaries" name="CanCreateAppointmentInAllDiariesRequest" message="tns:CanCreateAppointmentInAllDiariesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/Sentry/CanCreateAppointmentInAllDiariesResponse" name="CanCreateAppointmentInAllDiariesResponse" message="tns:CanCreateAppointmentInAllDiariesResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Sentry" type="tns:Sentry">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="GetNewTableRight">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/Sentry/GetNewTableRight" style="document" />
      <wsdl:input name="GetNewTableRightRequest">
        <soap:header message="tns:GetNewTableRightRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNewTableRightRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNewTableRightRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNewTableRightResponse">
        <soap:header message="tns:GetNewTableRightResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNewTableRightResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNewTableRightResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNewTableRightResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTableRightByOwnership">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/Sentry/GetTableRightByOwnership" style="document" />
      <wsdl:input name="GetTableRightByOwnershipRequest">
        <soap:header message="tns:GetTableRightByOwnershipRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTableRightByOwnershipRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTableRightByOwnershipRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTableRightByOwnershipResponse">
        <soap:header message="tns:GetTableRightByOwnershipResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTableRightByOwnershipResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTableRightByOwnershipResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTableRightByOwnershipResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFunctionRights">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/Sentry/GetFunctionRights" style="document" />
      <wsdl:input name="GetFunctionRightsRequest">
        <soap:header message="tns:GetFunctionRightsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFunctionRightsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFunctionRightsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFunctionRightsResponse">
        <soap:header message="tns:GetFunctionRightsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFunctionRightsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFunctionRightsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFunctionRightsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="HasFunctionRight">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/Sentry/HasFunctionRight" style="document" />
      <wsdl:input name="HasFunctionRightRequest">
        <soap:header message="tns:HasFunctionRightRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:HasFunctionRightRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:HasFunctionRightRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="HasFunctionRightResponse">
        <soap:header message="tns:HasFunctionRightResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:HasFunctionRightResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:HasFunctionRightResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:HasFunctionRightResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CanCreateAppointmentInAssociateDiaries">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/Sentry/CanCreateAppointmentInAssociateDiaries" style="document" />
      <wsdl:input name="CanCreateAppointmentInAssociateDiariesRequest">
        <soap:header message="tns:CanCreateAppointmentInAssociateDiariesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CanCreateAppointmentInAssociateDiariesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CanCreateAppointmentInAssociateDiariesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CanCreateAppointmentInAssociateDiariesResponse">
        <soap:header message="tns:CanCreateAppointmentInAssociateDiariesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CanCreateAppointmentInAssociateDiariesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CanCreateAppointmentInAssociateDiariesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CanCreateAppointmentInAssociateDiariesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CanCreateAppointmentInAllDiaries">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/Sentry/CanCreateAppointmentInAllDiaries" style="document" />
      <wsdl:input name="CanCreateAppointmentInAllDiariesRequest">
        <soap:header message="tns:CanCreateAppointmentInAllDiariesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CanCreateAppointmentInAllDiariesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CanCreateAppointmentInAllDiariesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CanCreateAppointmentInAllDiariesResponse">
        <soap:header message="tns:CanCreateAppointmentInAllDiariesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CanCreateAppointmentInAllDiariesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CanCreateAppointmentInAllDiariesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CanCreateAppointmentInAllDiariesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfSentryService">
    <wsdl:port name="BasicHttpBinding_Sentry" binding="tns:BasicHttpBinding_Sentry">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services85/Sentry.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

