---
Generated: 1
TOCExclude: 1
title: Services84.FavouriteAgent WSDL
---

# Services84.FavouriteAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfFavouriteService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services84" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services84" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services84" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="IsFavourite">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="RecordId" type="xs:int" />
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
      <xs:element name="IsFavouriteResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
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
      <xs:element name="AddFavourite">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="RecordId" type="xs:int" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddFavouriteResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="AddFavourites">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="RecordIds" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddFavouritesResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFavourites">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFavouritesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfFavourite" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfFavourite">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Favourite" nillable="true" type="tns:Favourite" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfFavourite" nillable="true" type="tns:ArrayOfFavourite" />
      <xs:complexType name="Favourite">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RecordId" type="xs:int" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Favourite" nillable="true" type="tns:Favourite" />
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
      <xs:element name="RemoveFavourite">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="RecordId" type="xs:int" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveFavouriteResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveAllFavourites">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveAllFavouritesResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleFavourite">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="RecordId" type="xs:int" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleFavouriteResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveFavouritesById">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FavouriteIds" nillable="true" type="q2:ArrayOfint" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveFavouritesByIdResponse">
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
  <wsdl:message name="IsFavouriteRequest">
    <wsdl:part name="parameters" element="tns:IsFavourite" />
  </wsdl:message>
  <wsdl:message name="IsFavouriteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsFavouriteResponse">
    <wsdl:part name="parameters" element="tns:IsFavouriteResponse" />
  </wsdl:message>
  <wsdl:message name="IsFavouriteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddFavouriteRequest">
    <wsdl:part name="parameters" element="tns:AddFavourite" />
  </wsdl:message>
  <wsdl:message name="AddFavouriteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddFavouriteResponse">
    <wsdl:part name="parameters" element="tns:AddFavouriteResponse" />
  </wsdl:message>
  <wsdl:message name="AddFavouriteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddFavouritesRequest">
    <wsdl:part name="parameters" element="tns:AddFavourites" />
  </wsdl:message>
  <wsdl:message name="AddFavouritesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddFavouritesResponse">
    <wsdl:part name="parameters" element="tns:AddFavouritesResponse" />
  </wsdl:message>
  <wsdl:message name="AddFavouritesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFavouritesRequest">
    <wsdl:part name="parameters" element="tns:GetFavourites" />
  </wsdl:message>
  <wsdl:message name="GetFavouritesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFavouritesResponse">
    <wsdl:part name="parameters" element="tns:GetFavouritesResponse" />
  </wsdl:message>
  <wsdl:message name="GetFavouritesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveFavouriteRequest">
    <wsdl:part name="parameters" element="tns:RemoveFavourite" />
  </wsdl:message>
  <wsdl:message name="RemoveFavouriteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveFavouriteResponse">
    <wsdl:part name="parameters" element="tns:RemoveFavouriteResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveFavouriteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveAllFavouritesRequest">
    <wsdl:part name="parameters" element="tns:RemoveAllFavourites" />
  </wsdl:message>
  <wsdl:message name="RemoveAllFavouritesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveAllFavouritesResponse">
    <wsdl:part name="parameters" element="tns:RemoveAllFavouritesResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveAllFavouritesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleFavouriteRequest">
    <wsdl:part name="parameters" element="tns:ToggleFavourite" />
  </wsdl:message>
  <wsdl:message name="ToggleFavouriteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleFavouriteResponse">
    <wsdl:part name="parameters" element="tns:ToggleFavouriteResponse" />
  </wsdl:message>
  <wsdl:message name="ToggleFavouriteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveFavouritesByIdRequest">
    <wsdl:part name="parameters" element="tns:RemoveFavouritesById" />
  </wsdl:message>
  <wsdl:message name="RemoveFavouritesByIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveFavouritesByIdResponse">
    <wsdl:part name="parameters" element="tns:RemoveFavouritesByIdResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveFavouritesByIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Favourite">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Favourite</summary>
    </wsdl:documentation>
    <wsdl:operation name="IsFavourite">
      <wsdl:documentation>
        <summary>Checks if a record in a table is a favourite for an associate</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/IsFavourite" name="IsFavouriteRequest" message="tns:IsFavouriteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/IsFavouriteResponse" name="IsFavouriteResponse" message="tns:IsFavouriteResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddFavourite">
      <wsdl:documentation>
        <summary>Add a record in a table as a favourite for an associate</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/AddFavourite" name="AddFavouriteRequest" message="tns:AddFavouriteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/AddFavouriteResponse" name="AddFavouriteResponse" message="tns:AddFavouriteResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddFavourites">
      <wsdl:documentation>
        <summary>Add a list of record ids as favourites for an associate</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/AddFavourites" name="AddFavouritesRequest" message="tns:AddFavouritesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/AddFavouritesResponse" name="AddFavouritesResponse" message="tns:AddFavouritesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFavourites">
      <wsdl:documentation>
        <summary>Get all favourites for a table and associate</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/GetFavourites" name="GetFavouritesRequest" message="tns:GetFavouritesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/GetFavouritesResponse" name="GetFavouritesResponse" message="tns:GetFavouritesResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveFavourite">
      <wsdl:documentation>
        <summary>Remove favourite for a table, record id and associate</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/RemoveFavourite" name="RemoveFavouriteRequest" message="tns:RemoveFavouriteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/RemoveFavouriteResponse" name="RemoveFavouriteResponse" message="tns:RemoveFavouriteResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveAllFavourites">
      <wsdl:documentation>
        <summary>Remove all favourites for a table and associate</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/RemoveAllFavourites" name="RemoveAllFavouritesRequest" message="tns:RemoveAllFavouritesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/RemoveAllFavouritesResponse" name="RemoveAllFavouritesResponse" message="tns:RemoveAllFavouritesResponse" />
    </wsdl:operation>
    <wsdl:operation name="ToggleFavourite">
      <wsdl:documentation>
        <summary>Toggle a record in a table as a favourite for an associate</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/ToggleFavourite" name="ToggleFavouriteRequest" message="tns:ToggleFavouriteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/ToggleFavouriteResponse" name="ToggleFavouriteResponse" message="tns:ToggleFavouriteResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveFavouritesById">
      <wsdl:documentation>
        <summary>Remove favourite using favourite id </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/RemoveFavouritesById" name="RemoveFavouritesByIdRequest" message="tns:RemoveFavouritesByIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/RemoveFavouritesByIdResponse" name="RemoveFavouritesByIdResponse" message="tns:RemoveFavouritesByIdResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Favourite" type="tns:Favourite">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="IsFavourite">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/IsFavourite" style="document" />
      <wsdl:input name="IsFavouriteRequest">
        <soap:header message="tns:IsFavouriteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:IsFavouriteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:IsFavouriteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="IsFavouriteResponse">
        <soap:header message="tns:IsFavouriteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:IsFavouriteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:IsFavouriteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:IsFavouriteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddFavourite">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/AddFavourite" style="document" />
      <wsdl:input name="AddFavouriteRequest">
        <soap:header message="tns:AddFavouriteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddFavouriteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddFavouriteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddFavouriteResponse">
        <soap:header message="tns:AddFavouriteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddFavouriteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddFavouriteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddFavouriteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddFavourites">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/AddFavourites" style="document" />
      <wsdl:input name="AddFavouritesRequest">
        <soap:header message="tns:AddFavouritesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddFavouritesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddFavouritesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddFavouritesResponse">
        <soap:header message="tns:AddFavouritesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddFavouritesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddFavouritesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddFavouritesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFavourites">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/GetFavourites" style="document" />
      <wsdl:input name="GetFavouritesRequest">
        <soap:header message="tns:GetFavouritesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFavouritesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFavouritesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFavouritesResponse">
        <soap:header message="tns:GetFavouritesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFavouritesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFavouritesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFavouritesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveFavourite">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/RemoveFavourite" style="document" />
      <wsdl:input name="RemoveFavouriteRequest">
        <soap:header message="tns:RemoveFavouriteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveFavouriteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveFavouriteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveFavouriteResponse">
        <soap:header message="tns:RemoveFavouriteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveFavouriteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveFavouriteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveFavouriteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveAllFavourites">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/RemoveAllFavourites" style="document" />
      <wsdl:input name="RemoveAllFavouritesRequest">
        <soap:header message="tns:RemoveAllFavouritesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveAllFavouritesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveAllFavouritesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveAllFavouritesResponse">
        <soap:header message="tns:RemoveAllFavouritesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveAllFavouritesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveAllFavouritesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveAllFavouritesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ToggleFavourite">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/ToggleFavourite" style="document" />
      <wsdl:input name="ToggleFavouriteRequest">
        <soap:header message="tns:ToggleFavouriteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ToggleFavouriteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ToggleFavouriteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ToggleFavouriteResponse">
        <soap:header message="tns:ToggleFavouriteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ToggleFavouriteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ToggleFavouriteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ToggleFavouriteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveFavouritesById">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/Favourite/RemoveFavouritesById" style="document" />
      <wsdl:input name="RemoveFavouritesByIdRequest">
        <soap:header message="tns:RemoveFavouritesByIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveFavouritesByIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveFavouritesByIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveFavouritesByIdResponse">
        <soap:header message="tns:RemoveFavouritesByIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveFavouritesByIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveFavouritesByIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveFavouritesByIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfFavouriteService">
    <wsdl:port name="BasicHttpBinding_Favourite" binding="tns:BasicHttpBinding_Favourite">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services84/Favourite.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

