---
Generated: 1
TOCExclude: 1
title: Services88.MDOAgent WSDL
---

# Services88.MDOAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfMDOService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="GetList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ForceFlatList" type="xs:boolean" />
            <xs:element minOccurs="0" name="AdditionalInfo" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="OnlyHistory" type="xs:boolean" />
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
      <xs:element name="GetListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfMDOListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="MDOListItem" nillable="true" type="tns:MDOListItem" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfMDOListItem" nillable="true" type="tns:ArrayOfMDOListItem" />
      <xs:complexType name="MDOListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ToolTip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ChildItems" nillable="true" type="tns:ArrayOfMDOListItem" />
              <xs:element minOccurs="0" name="IconHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ColorBlock" type="xs:int" />
              <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StyleHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="MDOListItem" nillable="true" type="tns:MDOListItem" />
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
      <xs:element name="GetListWithHistory">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ForceFlatList" type="xs:boolean" />
            <xs:element minOccurs="0" name="AdditionalInfo" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="HistoryItems" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="OnlyHistory" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListWithHistoryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListWithRestriction">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="AdditionalInfo" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="SearchValue" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListWithRestrictionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSimpleList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSimpleListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListItem">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ListName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Id" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListItemResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:MDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListNames">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListNamesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q2:ArrayOfstring" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListIdByListName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListIdByListNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectableSimpleList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectableSimpleListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfSelectableMDOListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="SelectableMDOListItem" nillable="true" type="tns:SelectableMDOListItem" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfSelectableMDOListItem" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
      <xs:complexType name="SelectableMDOListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ToolTip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ColorBlock" type="xs:int" />
              <xs:element minOccurs="0" name="IconHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Selected" type="xs:boolean" />
              <xs:element minOccurs="0" name="LastChanged" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ChildItems" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
              <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StyleHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Hidden" type="xs:boolean" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SelectableMDOListItem" nillable="true" type="tns:SelectableMDOListItem" />
      <xs:element name="GetSelectableListWithRestriction">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="AdditionalInfo" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="SearchValue" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectableListWithRestrictionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectableListWithHistory">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ForceFlatList" type="xs:boolean" />
            <xs:element minOccurs="0" name="AdditionalInfo" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="HistoryItems" nillable="true" type="q3:ArrayOfint" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="OnlyHistory" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectableListWithHistoryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectableList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ForceFlatList" type="xs:boolean" />
            <xs:element minOccurs="0" name="AdditionalInfo" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="OnlyHistory" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectableListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetSelected">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="AdditionalInfo" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="SelectableMDOList" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetSelectedResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
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
      <xs:complexType name="ArrayOfstring">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="string" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfstring" nillable="true" type="tns:ArrayOfstring" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="GetListRequest">
    <wsdl:part name="parameters" element="tns:GetList" />
  </wsdl:message>
  <wsdl:message name="GetListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListResponse">
    <wsdl:part name="parameters" element="tns:GetListResponse" />
  </wsdl:message>
  <wsdl:message name="GetListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListWithHistoryRequest">
    <wsdl:part name="parameters" element="tns:GetListWithHistory" />
  </wsdl:message>
  <wsdl:message name="GetListWithHistoryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListWithHistoryResponse">
    <wsdl:part name="parameters" element="tns:GetListWithHistoryResponse" />
  </wsdl:message>
  <wsdl:message name="GetListWithHistoryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListWithRestrictionRequest">
    <wsdl:part name="parameters" element="tns:GetListWithRestriction" />
  </wsdl:message>
  <wsdl:message name="GetListWithRestrictionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListWithRestrictionResponse">
    <wsdl:part name="parameters" element="tns:GetListWithRestrictionResponse" />
  </wsdl:message>
  <wsdl:message name="GetListWithRestrictionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSimpleListRequest">
    <wsdl:part name="parameters" element="tns:GetSimpleList" />
  </wsdl:message>
  <wsdl:message name="GetSimpleListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSimpleListResponse">
    <wsdl:part name="parameters" element="tns:GetSimpleListResponse" />
  </wsdl:message>
  <wsdl:message name="GetSimpleListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListItemRequest">
    <wsdl:part name="parameters" element="tns:GetListItem" />
  </wsdl:message>
  <wsdl:message name="GetListItemRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListItemResponse">
    <wsdl:part name="parameters" element="tns:GetListItemResponse" />
  </wsdl:message>
  <wsdl:message name="GetListItemResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListNamesRequest">
    <wsdl:part name="parameters" element="tns:GetListNames" />
  </wsdl:message>
  <wsdl:message name="GetListNamesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListNamesResponse">
    <wsdl:part name="parameters" element="tns:GetListNamesResponse" />
  </wsdl:message>
  <wsdl:message name="GetListNamesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListIdByListNameRequest">
    <wsdl:part name="parameters" element="tns:GetListIdByListName" />
  </wsdl:message>
  <wsdl:message name="GetListIdByListNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListIdByListNameResponse">
    <wsdl:part name="parameters" element="tns:GetListIdByListNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetListIdByListNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectableSimpleListRequest">
    <wsdl:part name="parameters" element="tns:GetSelectableSimpleList" />
  </wsdl:message>
  <wsdl:message name="GetSelectableSimpleListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectableSimpleListResponse">
    <wsdl:part name="parameters" element="tns:GetSelectableSimpleListResponse" />
  </wsdl:message>
  <wsdl:message name="GetSelectableSimpleListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectableListWithRestrictionRequest">
    <wsdl:part name="parameters" element="tns:GetSelectableListWithRestriction" />
  </wsdl:message>
  <wsdl:message name="GetSelectableListWithRestrictionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectableListWithRestrictionResponse">
    <wsdl:part name="parameters" element="tns:GetSelectableListWithRestrictionResponse" />
  </wsdl:message>
  <wsdl:message name="GetSelectableListWithRestrictionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectableListWithHistoryRequest">
    <wsdl:part name="parameters" element="tns:GetSelectableListWithHistory" />
  </wsdl:message>
  <wsdl:message name="GetSelectableListWithHistoryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectableListWithHistoryResponse">
    <wsdl:part name="parameters" element="tns:GetSelectableListWithHistoryResponse" />
  </wsdl:message>
  <wsdl:message name="GetSelectableListWithHistoryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectableListRequest">
    <wsdl:part name="parameters" element="tns:GetSelectableList" />
  </wsdl:message>
  <wsdl:message name="GetSelectableListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectableListResponse">
    <wsdl:part name="parameters" element="tns:GetSelectableListResponse" />
  </wsdl:message>
  <wsdl:message name="GetSelectableListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetSelectedRequest">
    <wsdl:part name="parameters" element="tns:SetSelected" />
  </wsdl:message>
  <wsdl:message name="SetSelectedRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetSelectedResponse">
    <wsdl:part name="parameters" element="tns:SetSelectedResponse" />
  </wsdl:message>
  <wsdl:message name="SetSelectedResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="MDO">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for MDO</summary>
    </wsdl:documentation>
    <wsdl:operation name="GetList">
      <wsdl:documentation>
        <summary>Method to get a MDO list.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetList" name="GetListRequest" message="tns:GetListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetListResponse" name="GetListResponse" message="tns:GetListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetListWithHistory">
      <wsdl:documentation>
        <summary>Method to get a MDO list with own history list.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetListWithHistory" name="GetListWithHistoryRequest" message="tns:GetListWithHistoryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetListWithHistoryResponse" name="GetListWithHistoryResponse" message="tns:GetListWithHistoryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetListWithRestriction">
      <wsdl:documentation>
        <summary>Method to get a MDO list with restrictions.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetListWithRestriction" name="GetListWithRestrictionRequest" message="tns:GetListWithRestrictionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetListWithRestrictionResponse" name="GetListWithRestrictionResponse" message="tns:GetListWithRestrictionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSimpleList">
      <wsdl:documentation>
        <summary>Method returns a simple flat MDO List.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetSimpleList" name="GetSimpleListRequest" message="tns:GetSimpleListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetSimpleListResponse" name="GetSimpleListResponse" message="tns:GetSimpleListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetListItem">
      <wsdl:documentation>
        <summary>Returns a single list item</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetListItem" name="GetListItemRequest" message="tns:GetListItemRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetListItemResponse" name="GetListItemResponse" message="tns:GetListItemResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetListNames">
      <wsdl:documentation>
        <summary>Returns a list of all MDO List names. These names can also be used with the Archive agent as ProviderNames.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetListNames" name="GetListNamesRequest" message="tns:GetListNamesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetListNamesResponse" name="GetListNamesResponse" message="tns:GetListNamesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetListIdByListName">
      <wsdl:documentation>
        <summary>Retrieve the UdListDefinition id of a list, by its name. Not all lists have such an ID, but those that are based on tables do (the list name is then the same as the table name)</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetListIdByListName" name="GetListIdByListNameRequest" message="tns:GetListIdByListNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetListIdByListNameResponse" name="GetListIdByListNameResponse" message="tns:GetListIdByListNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSelectableSimpleList">
      <wsdl:documentation>
        <summary>Method returns a flat Selectable MDO List.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetSelectableSimpleList" name="GetSelectableSimpleListRequest" message="tns:GetSelectableSimpleListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetSelectableSimpleListResponse" name="GetSelectableSimpleListResponse" message="tns:GetSelectableSimpleListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSelectableListWithRestriction">
      <wsdl:documentation>
        <summary>Method to get a Selectable MDO list with restrictions.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetSelectableListWithRestriction" name="GetSelectableListWithRestrictionRequest" message="tns:GetSelectableListWithRestrictionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetSelectableListWithRestrictionResponse" name="GetSelectableListWithRestrictionResponse" message="tns:GetSelectableListWithRestrictionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSelectableListWithHistory">
      <wsdl:documentation>
        <summary>Method to get a Selectable MDO list with own history list.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetSelectableListWithHistory" name="GetSelectableListWithHistoryRequest" message="tns:GetSelectableListWithHistoryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetSelectableListWithHistoryResponse" name="GetSelectableListWithHistoryResponse" message="tns:GetSelectableListWithHistoryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSelectableList">
      <wsdl:documentation>
        <summary>Method to get a Selectable MDO list.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetSelectableList" name="GetSelectableListRequest" message="tns:GetSelectableListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetSelectableListResponse" name="GetSelectableListResponse" message="tns:GetSelectableListResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetSelected">
      <wsdl:documentation>
        <summary>Saves the selected values as selected by their given list representation.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/SetSelected" name="SetSelectedRequest" message="tns:SetSelectedRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/SetSelectedResponse" name="SetSelectedResponse" message="tns:SetSelectedResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_MDO" type="tns:MDO">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="GetList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetList" style="document" />
      <wsdl:input name="GetListRequest">
        <soap:header message="tns:GetListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetListResponse">
        <soap:header message="tns:GetListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetListWithHistory">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetListWithHistory" style="document" />
      <wsdl:input name="GetListWithHistoryRequest">
        <soap:header message="tns:GetListWithHistoryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetListWithHistoryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetListWithHistoryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetListWithHistoryResponse">
        <soap:header message="tns:GetListWithHistoryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetListWithHistoryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetListWithHistoryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetListWithHistoryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetListWithRestriction">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetListWithRestriction" style="document" />
      <wsdl:input name="GetListWithRestrictionRequest">
        <soap:header message="tns:GetListWithRestrictionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetListWithRestrictionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetListWithRestrictionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetListWithRestrictionResponse">
        <soap:header message="tns:GetListWithRestrictionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetListWithRestrictionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetListWithRestrictionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetListWithRestrictionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSimpleList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetSimpleList" style="document" />
      <wsdl:input name="GetSimpleListRequest">
        <soap:header message="tns:GetSimpleListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSimpleListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSimpleListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSimpleListResponse">
        <soap:header message="tns:GetSimpleListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSimpleListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSimpleListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSimpleListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetListItem">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetListItem" style="document" />
      <wsdl:input name="GetListItemRequest">
        <soap:header message="tns:GetListItemRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetListItemRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetListItemRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetListItemResponse">
        <soap:header message="tns:GetListItemResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetListItemResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetListItemResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetListItemResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetListNames">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetListNames" style="document" />
      <wsdl:input name="GetListNamesRequest">
        <soap:header message="tns:GetListNamesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetListNamesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetListNamesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetListNamesResponse">
        <soap:header message="tns:GetListNamesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetListNamesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetListNamesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetListNamesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetListIdByListName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetListIdByListName" style="document" />
      <wsdl:input name="GetListIdByListNameRequest">
        <soap:header message="tns:GetListIdByListNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetListIdByListNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetListIdByListNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetListIdByListNameResponse">
        <soap:header message="tns:GetListIdByListNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetListIdByListNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetListIdByListNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetListIdByListNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSelectableSimpleList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetSelectableSimpleList" style="document" />
      <wsdl:input name="GetSelectableSimpleListRequest">
        <soap:header message="tns:GetSelectableSimpleListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSelectableSimpleListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSelectableSimpleListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSelectableSimpleListResponse">
        <soap:header message="tns:GetSelectableSimpleListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSelectableSimpleListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSelectableSimpleListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSelectableSimpleListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSelectableListWithRestriction">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetSelectableListWithRestriction" style="document" />
      <wsdl:input name="GetSelectableListWithRestrictionRequest">
        <soap:header message="tns:GetSelectableListWithRestrictionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSelectableListWithRestrictionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSelectableListWithRestrictionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSelectableListWithRestrictionResponse">
        <soap:header message="tns:GetSelectableListWithRestrictionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSelectableListWithRestrictionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSelectableListWithRestrictionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSelectableListWithRestrictionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSelectableListWithHistory">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetSelectableListWithHistory" style="document" />
      <wsdl:input name="GetSelectableListWithHistoryRequest">
        <soap:header message="tns:GetSelectableListWithHistoryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSelectableListWithHistoryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSelectableListWithHistoryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSelectableListWithHistoryResponse">
        <soap:header message="tns:GetSelectableListWithHistoryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSelectableListWithHistoryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSelectableListWithHistoryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSelectableListWithHistoryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSelectableList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/GetSelectableList" style="document" />
      <wsdl:input name="GetSelectableListRequest">
        <soap:header message="tns:GetSelectableListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSelectableListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSelectableListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSelectableListResponse">
        <soap:header message="tns:GetSelectableListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSelectableListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSelectableListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSelectableListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetSelected">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/MDO/SetSelected" style="document" />
      <wsdl:input name="SetSelectedRequest">
        <soap:header message="tns:SetSelectedRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetSelectedRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetSelectedRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetSelectedResponse">
        <soap:header message="tns:SetSelectedResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetSelectedResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetSelectedResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetSelectedResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfMDOService">
    <wsdl:port name="BasicHttpBinding_MDO" binding="tns:BasicHttpBinding_MDO">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/MDO.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

