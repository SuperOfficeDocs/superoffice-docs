---
generated: 1
uid: wsdl-Services84-PhoneList
title: Services84.PhoneListAgent WSDL
---

# Services84.PhoneListAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfPhoneListService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services84" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services84" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services84" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:element name="Search">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SearchString" nillable="true" type="xs:string" />
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
      <xs:element name="SearchResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPhoneListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfPhoneListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="PhoneListItem" nillable="true" type="tns:PhoneListItem" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfPhoneListItem" nillable="true" type="tns:ArrayOfPhoneListItem" />
      <xs:complexType name="PhoneListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="PersonDirectPhone" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonCellPhone" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonPrivatePhone" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonFaxNumber" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonPagerNumber" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonEmail" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UniqueId" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PhoneListItem" nillable="true" type="tns:PhoneListItem" />
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
      <xs:element name="SearchWithPreferences">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SearchString" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Preferences" nillable="true" type="tns:PhoneListPreferences" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="PhoneListPreferences">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="SearchCompany" type="xs:boolean" />
              <xs:element minOccurs="0" name="SearchFirstname" type="xs:boolean" />
              <xs:element minOccurs="0" name="SearchLastname" type="xs:boolean" />
              <xs:element minOccurs="0" name="SearchDepartment" type="xs:boolean" />
              <xs:element minOccurs="0" name="SearchModeCompany" type="tns:StringSearchType" />
              <xs:element minOccurs="0" name="SearchModeDepartment" type="tns:StringSearchType" />
              <xs:element minOccurs="0" name="SearchModeFirstname" type="tns:StringSearchType" />
              <xs:element minOccurs="0" name="SearchModeLastname" type="tns:StringSearchType" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PhoneListPreferences" nillable="true" type="tns:PhoneListPreferences" />
      <xs:simpleType name="StringSearchType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Exact" />
          <xs:enumeration value="BeginsWith" />
          <xs:enumeration value="EndsWith" />
          <xs:enumeration value="Contains" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="StringSearchType" nillable="true" type="tns:StringSearchType" />
      <xs:element name="SearchWithPreferencesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPhoneListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDepartmentPhones">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DepartmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDepartmentPhonesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPhoneListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFavoritesPhones">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFavoritesPhonesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPhoneListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactPhones">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactPhonesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPhoneListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddToFavorites">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddToFavoritesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreferences">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreferencesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PhoneListPreferences" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetPreferences">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Preferences" nillable="true" type="tns:PhoneListPreferences" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetPreferencesResponse">
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
  <wsdl:message name="SearchRequest">
    <wsdl:part name="parameters" element="tns:Search" />
  </wsdl:message>
  <wsdl:message name="SearchRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SearchResponse">
    <wsdl:part name="parameters" element="tns:SearchResponse" />
  </wsdl:message>
  <wsdl:message name="SearchResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SearchWithPreferencesRequest">
    <wsdl:part name="parameters" element="tns:SearchWithPreferences" />
  </wsdl:message>
  <wsdl:message name="SearchWithPreferencesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SearchWithPreferencesResponse">
    <wsdl:part name="parameters" element="tns:SearchWithPreferencesResponse" />
  </wsdl:message>
  <wsdl:message name="SearchWithPreferencesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDepartmentPhonesRequest">
    <wsdl:part name="parameters" element="tns:GetDepartmentPhones" />
  </wsdl:message>
  <wsdl:message name="GetDepartmentPhonesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDepartmentPhonesResponse">
    <wsdl:part name="parameters" element="tns:GetDepartmentPhonesResponse" />
  </wsdl:message>
  <wsdl:message name="GetDepartmentPhonesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFavoritesPhonesRequest">
    <wsdl:part name="parameters" element="tns:GetFavoritesPhones" />
  </wsdl:message>
  <wsdl:message name="GetFavoritesPhonesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFavoritesPhonesResponse">
    <wsdl:part name="parameters" element="tns:GetFavoritesPhonesResponse" />
  </wsdl:message>
  <wsdl:message name="GetFavoritesPhonesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactPhonesRequest">
    <wsdl:part name="parameters" element="tns:GetContactPhones" />
  </wsdl:message>
  <wsdl:message name="GetContactPhonesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactPhonesResponse">
    <wsdl:part name="parameters" element="tns:GetContactPhonesResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactPhonesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddToFavoritesRequest">
    <wsdl:part name="parameters" element="tns:AddToFavorites" />
  </wsdl:message>
  <wsdl:message name="AddToFavoritesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddToFavoritesResponse">
    <wsdl:part name="parameters" element="tns:AddToFavoritesResponse" />
  </wsdl:message>
  <wsdl:message name="AddToFavoritesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreferencesRequest">
    <wsdl:part name="parameters" element="tns:GetPreferences" />
  </wsdl:message>
  <wsdl:message name="GetPreferencesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreferencesResponse">
    <wsdl:part name="parameters" element="tns:GetPreferencesResponse" />
  </wsdl:message>
  <wsdl:message name="GetPreferencesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetPreferencesRequest">
    <wsdl:part name="parameters" element="tns:SetPreferences" />
  </wsdl:message>
  <wsdl:message name="SetPreferencesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetPreferencesResponse">
    <wsdl:part name="parameters" element="tns:SetPreferencesResponse" />
  </wsdl:message>
  <wsdl:message name="SetPreferencesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="PhoneList">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for PhoneList</summary>
    </wsdl:documentation>
    <wsdl:operation name="Search">
      <wsdl:documentation>
        <summary>Searching the phone list. Using default search preferences or the preferences already set by the PhoneListPreferences Service</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/Search" name="SearchRequest" message="tns:SearchRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/SearchResponse" name="SearchResponse" message="tns:SearchResponse" />
    </wsdl:operation>
    <wsdl:operation name="SearchWithPreferences">
      <wsdl:documentation>
        <summary>Searching the phone list. Search is based on the supplied preferences.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/SearchWithPreferences" name="SearchWithPreferencesRequest" message="tns:SearchWithPreferencesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/SearchWithPreferencesResponse" name="SearchWithPreferencesResponse" message="tns:SearchWithPreferencesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDepartmentPhones">
      <wsdl:documentation>
        <summary>Returns an array of phone list items with the in-parameter as restriction. The in-parameter must be a valid department id (UserGroupId).</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/GetDepartmentPhones" name="GetDepartmentPhonesRequest" message="tns:GetDepartmentPhonesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/GetDepartmentPhonesResponse" name="GetDepartmentPhonesResponse" message="tns:GetDepartmentPhonesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFavoritesPhones">
      <wsdl:documentation>
        <summary>Returns an array of phone list items with the Contacts in the users favorites dropdown list.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/GetFavoritesPhones" name="GetFavoritesPhonesRequest" message="tns:GetFavoritesPhonesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/GetFavoritesPhonesResponse" name="GetFavoritesPhonesResponse" message="tns:GetFavoritesPhonesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactPhones">
      <wsdl:documentation>
        <summary>Returns an array of phone list items for all the persons belonging to a contact (company). The in-parameter must be a valid contact-id.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/GetContactPhones" name="GetContactPhonesRequest" message="tns:GetContactPhonesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/GetContactPhonesResponse" name="GetContactPhonesResponse" message="tns:GetContactPhonesResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddToFavorites">
      <wsdl:documentation>
        <summary>Adds a new contact to the history/favorites. Returns the rank of the new history item. If the contact already existed in the history, it isn't added but the rank is updated.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/AddToFavorites" name="AddToFavoritesRequest" message="tns:AddToFavoritesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/AddToFavoritesResponse" name="AddToFavoritesResponse" message="tns:AddToFavoritesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPreferences">
      <wsdl:documentation>
        <summary>Getting Phone List Preferences from the CRM 5 user preferences</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/GetPreferences" name="GetPreferencesRequest" message="tns:GetPreferencesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/GetPreferencesResponse" name="GetPreferencesResponse" message="tns:GetPreferencesResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetPreferences">
      <wsdl:documentation>
        <summary>Setting Phone List Preferences to the CRM 5 user preferences</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/SetPreferences" name="SetPreferencesRequest" message="tns:SetPreferencesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/SetPreferencesResponse" name="SetPreferencesResponse" message="tns:SetPreferencesResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_PhoneList" type="tns:PhoneList">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="Search">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/Search" style="document" />
      <wsdl:input name="SearchRequest">
        <soap:header message="tns:SearchRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SearchRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SearchRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SearchResponse">
        <soap:header message="tns:SearchResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SearchResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SearchResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SearchResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SearchWithPreferences">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/SearchWithPreferences" style="document" />
      <wsdl:input name="SearchWithPreferencesRequest">
        <soap:header message="tns:SearchWithPreferencesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SearchWithPreferencesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SearchWithPreferencesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SearchWithPreferencesResponse">
        <soap:header message="tns:SearchWithPreferencesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SearchWithPreferencesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SearchWithPreferencesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SearchWithPreferencesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDepartmentPhones">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/GetDepartmentPhones" style="document" />
      <wsdl:input name="GetDepartmentPhonesRequest">
        <soap:header message="tns:GetDepartmentPhonesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDepartmentPhonesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDepartmentPhonesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDepartmentPhonesResponse">
        <soap:header message="tns:GetDepartmentPhonesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDepartmentPhonesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDepartmentPhonesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDepartmentPhonesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFavoritesPhones">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/GetFavoritesPhones" style="document" />
      <wsdl:input name="GetFavoritesPhonesRequest">
        <soap:header message="tns:GetFavoritesPhonesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFavoritesPhonesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFavoritesPhonesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFavoritesPhonesResponse">
        <soap:header message="tns:GetFavoritesPhonesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFavoritesPhonesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFavoritesPhonesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFavoritesPhonesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactPhones">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/GetContactPhones" style="document" />
      <wsdl:input name="GetContactPhonesRequest">
        <soap:header message="tns:GetContactPhonesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactPhonesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactPhonesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactPhonesResponse">
        <soap:header message="tns:GetContactPhonesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactPhonesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactPhonesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactPhonesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddToFavorites">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/AddToFavorites" style="document" />
      <wsdl:input name="AddToFavoritesRequest">
        <soap:header message="tns:AddToFavoritesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddToFavoritesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddToFavoritesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddToFavoritesResponse">
        <soap:header message="tns:AddToFavoritesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddToFavoritesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddToFavoritesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddToFavoritesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPreferences">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/GetPreferences" style="document" />
      <wsdl:input name="GetPreferencesRequest">
        <soap:header message="tns:GetPreferencesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPreferencesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPreferencesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPreferencesResponse">
        <soap:header message="tns:GetPreferencesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPreferencesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPreferencesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPreferencesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetPreferences">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/PhoneList/SetPreferences" style="document" />
      <wsdl:input name="SetPreferencesRequest">
        <soap:header message="tns:SetPreferencesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetPreferencesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetPreferencesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetPreferencesResponse">
        <soap:header message="tns:SetPreferencesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetPreferencesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetPreferencesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetPreferencesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfPhoneListService">
    <wsdl:port name="BasicHttpBinding_PhoneList" binding="tns:BasicHttpBinding_PhoneList">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services84/PhoneList.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

