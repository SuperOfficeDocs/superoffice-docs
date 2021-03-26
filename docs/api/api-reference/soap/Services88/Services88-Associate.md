---
Generated: 1
TOCExclude: 1
title: Services88.AssociateAgent WSDL
---

# Services88.AssociateAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfAssociateService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="GetAssociate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
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
      <xs:element name="GetAssociateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Associate" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Associate">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Type" type="tns:UserType" />
              <xs:element minOccurs="0" name="GroupIdx" type="xs:int" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="EjUserId" type="xs:int" />
              <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Associate" nillable="true" type="tns:Associate" />
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
      <xs:simpleType name="UserType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="InternalAssociate" />
          <xs:enumeration value="ResourceAssociate" />
          <xs:enumeration value="ExternalAssociate" />
          <xs:enumeration value="AnonymousAssociate" />
          <xs:enumeration value="SystemAssociate" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="UserType" nillable="true" type="tns:UserType" />
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
      <xs:element name="GetAssociateByPersonId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAssociateByPersonIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Associate" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNote">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNoteResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q1:ArrayOfstring" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveNote">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="Note" nillable="true" type="q2:ArrayOfstring" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveNoteResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAssociateList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateIds" nillable="true" type="q3:ArrayOfint" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAssociateListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfAssociate" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfAssociate">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Associate" nillable="true" type="tns:Associate" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfAssociate" nillable="true" type="tns:ArrayOfAssociate" />
      <xs:element name="GetAssociatesByGroup">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="GroupId" type="xs:int" />
            <xs:element minOccurs="0" name="Type" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAssociatesByGroupResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfAssociate" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="LogOffWindowsUsers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateIds" nillable="true" type="q4:ArrayOfint" xmlns:q4="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="LogOffWindowsUsersResponse">
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
  <wsdl:message name="GetAssociateRequest">
    <wsdl:part name="parameters" element="tns:GetAssociate" />
  </wsdl:message>
  <wsdl:message name="GetAssociateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAssociateResponse">
    <wsdl:part name="parameters" element="tns:GetAssociateResponse" />
  </wsdl:message>
  <wsdl:message name="GetAssociateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAssociateByPersonIdRequest">
    <wsdl:part name="parameters" element="tns:GetAssociateByPersonId" />
  </wsdl:message>
  <wsdl:message name="GetAssociateByPersonIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAssociateByPersonIdResponse">
    <wsdl:part name="parameters" element="tns:GetAssociateByPersonIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetAssociateByPersonIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNoteRequest">
    <wsdl:part name="parameters" element="tns:GetNote" />
  </wsdl:message>
  <wsdl:message name="GetNoteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNoteResponse">
    <wsdl:part name="parameters" element="tns:GetNoteResponse" />
  </wsdl:message>
  <wsdl:message name="GetNoteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveNoteRequest">
    <wsdl:part name="parameters" element="tns:SaveNote" />
  </wsdl:message>
  <wsdl:message name="SaveNoteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveNoteResponse">
    <wsdl:part name="parameters" element="tns:SaveNoteResponse" />
  </wsdl:message>
  <wsdl:message name="SaveNoteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAssociateListRequest">
    <wsdl:part name="parameters" element="tns:GetAssociateList" />
  </wsdl:message>
  <wsdl:message name="GetAssociateListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAssociateListResponse">
    <wsdl:part name="parameters" element="tns:GetAssociateListResponse" />
  </wsdl:message>
  <wsdl:message name="GetAssociateListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAssociatesByGroupRequest">
    <wsdl:part name="parameters" element="tns:GetAssociatesByGroup" />
  </wsdl:message>
  <wsdl:message name="GetAssociatesByGroupRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAssociatesByGroupResponse">
    <wsdl:part name="parameters" element="tns:GetAssociatesByGroupResponse" />
  </wsdl:message>
  <wsdl:message name="GetAssociatesByGroupResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="LogOffWindowsUsersRequest">
    <wsdl:part name="parameters" element="tns:LogOffWindowsUsers" />
  </wsdl:message>
  <wsdl:message name="LogOffWindowsUsersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="LogOffWindowsUsersResponse">
    <wsdl:part name="parameters" element="tns:LogOffWindowsUsersResponse" />
  </wsdl:message>
  <wsdl:message name="LogOffWindowsUsersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Associate">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Associate</summary>
    </wsdl:documentation>
    <wsdl:operation name="GetAssociate">
      <wsdl:documentation>
        <summary>Gets a Associate object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/GetAssociate" name="GetAssociateRequest" message="tns:GetAssociateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/GetAssociateResponse" name="GetAssociateResponse" message="tns:GetAssociateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAssociateByPersonId">
      <wsdl:documentation>
        <summary>Returns the associate that belongs to this person if the person is an associate.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/GetAssociateByPersonId" name="GetAssociateByPersonIdRequest" message="tns:GetAssociateByPersonIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/GetAssociateByPersonIdResponse" name="GetAssociateByPersonIdResponse" message="tns:GetAssociateByPersonIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNote">
      <wsdl:documentation>
        <summary>Returns an array of strings(notepad pages).</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/GetNote" name="GetNoteRequest" message="tns:GetNoteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/GetNoteResponse" name="GetNoteResponse" message="tns:GetNoteResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveNote">
      <wsdl:documentation>
        <summary>Saves an array of strings(notepad pages).</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/SaveNote" name="SaveNoteRequest" message="tns:SaveNoteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/SaveNoteResponse" name="SaveNoteResponse" message="tns:SaveNoteResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAssociateList">
      <wsdl:documentation>
        <summary>Gets an array of Associate objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/GetAssociateList" name="GetAssociateListRequest" message="tns:GetAssociateListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/GetAssociateListResponse" name="GetAssociateListResponse" message="tns:GetAssociateListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAssociatesByGroup">
      <wsdl:documentation>
        <summary>Method that returns a array of associate , based on DiaryGroupType and groupId. The differernt types are, Userdefined, Usergroup and ResourceHeadings</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/GetAssociatesByGroup" name="GetAssociatesByGroupRequest" message="tns:GetAssociatesByGroupRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/GetAssociatesByGroupResponse" name="GetAssociatesByGroupResponse" message="tns:GetAssociatesByGroupResponse" />
    </wsdl:operation>
    <wsdl:operation name="LogOffWindowsUsers">
      <wsdl:documentation>
        <summary>Method that logs off associates that are logged on to the win client</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/LogOffWindowsUsers" name="LogOffWindowsUsersRequest" message="tns:LogOffWindowsUsersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/LogOffWindowsUsersResponse" name="LogOffWindowsUsersResponse" message="tns:LogOffWindowsUsersResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Associate" type="tns:Associate">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="GetAssociate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/GetAssociate" style="document" />
      <wsdl:input name="GetAssociateRequest">
        <soap:header message="tns:GetAssociateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAssociateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAssociateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAssociateResponse">
        <soap:header message="tns:GetAssociateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAssociateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAssociateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAssociateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAssociateByPersonId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/GetAssociateByPersonId" style="document" />
      <wsdl:input name="GetAssociateByPersonIdRequest">
        <soap:header message="tns:GetAssociateByPersonIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAssociateByPersonIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAssociateByPersonIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAssociateByPersonIdResponse">
        <soap:header message="tns:GetAssociateByPersonIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAssociateByPersonIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAssociateByPersonIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAssociateByPersonIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNote">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/GetNote" style="document" />
      <wsdl:input name="GetNoteRequest">
        <soap:header message="tns:GetNoteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNoteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNoteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNoteResponse">
        <soap:header message="tns:GetNoteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNoteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNoteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNoteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveNote">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/SaveNote" style="document" />
      <wsdl:input name="SaveNoteRequest">
        <soap:header message="tns:SaveNoteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveNoteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveNoteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveNoteResponse">
        <soap:header message="tns:SaveNoteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveNoteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveNoteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveNoteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAssociateList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/GetAssociateList" style="document" />
      <wsdl:input name="GetAssociateListRequest">
        <soap:header message="tns:GetAssociateListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAssociateListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAssociateListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAssociateListResponse">
        <soap:header message="tns:GetAssociateListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAssociateListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAssociateListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAssociateListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAssociatesByGroup">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/GetAssociatesByGroup" style="document" />
      <wsdl:input name="GetAssociatesByGroupRequest">
        <soap:header message="tns:GetAssociatesByGroupRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAssociatesByGroupRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAssociatesByGroupRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAssociatesByGroupResponse">
        <soap:header message="tns:GetAssociatesByGroupResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAssociatesByGroupResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAssociatesByGroupResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAssociatesByGroupResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="LogOffWindowsUsers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Associate/LogOffWindowsUsers" style="document" />
      <wsdl:input name="LogOffWindowsUsersRequest">
        <soap:header message="tns:LogOffWindowsUsersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:LogOffWindowsUsersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:LogOffWindowsUsersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="LogOffWindowsUsersResponse">
        <soap:header message="tns:LogOffWindowsUsersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:LogOffWindowsUsersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:LogOffWindowsUsersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:LogOffWindowsUsersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfAssociateService">
    <wsdl:port name="BasicHttpBinding_Associate" binding="tns:BasicHttpBinding_Associate">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/Associate.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

