---
generated: 1
uid: wsdl-Services87-Archive
title: Services87.ArchiveAgent WSDL
---

# Services87.ArchiveAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfArchiveService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultArchiveListResult">
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
      <xs:element name="CreateDefaultArchiveListResultResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArchiveListResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArchiveListResult">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="RowCount" type="xs:int" />
              <xs:element minOccurs="0" name="Rows" nillable="true" type="tns:ArrayOfArchiveListItem" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ArchiveListResult" nillable="true" type="tns:ArchiveListResult" />
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
      <xs:complexType name="ArrayOfArchiveListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArchiveListItem" nillable="true" type="tns:ArchiveListItem" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArchiveListItem" nillable="true" type="tns:ArrayOfArchiveListItem" />
      <xs:complexType name="ArchiveListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="EntityName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PrimaryKey" type="xs:int" />
              <xs:element minOccurs="0" name="ColumnData" nillable="true" type="tns:ColumnDataDictionary" />
              <xs:element minOccurs="0" name="LinkHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StyleHint" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ArchiveListItem" nillable="true" type="tns:ArchiveListItem" />
      <xs:complexType name="ColumnDataDictionary">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ColumnDataKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="tns:ArchiveColumnData" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ColumnDataDictionary" nillable="true" type="tns:ColumnDataDictionary" />
      <xs:complexType name="ArchiveColumnData">
        <xs:sequence>
          <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="TooltipHint" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="LinkHint" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArchiveColumnData" nillable="true" type="tns:ArchiveColumnData" />
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
      <xs:element name="GetActivityFilter">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetActivityFilterResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ActivityFilter" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ActivityFilter">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="FromDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ToDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AssociateList" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
              <xs:element minOccurs="0" name="GroupList" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
              <xs:element minOccurs="0" name="FutureDateList" nillable="true" type="tns:ArrayOfMDOListItem" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ActivityFilter" nillable="true" type="tns:ActivityFilter" />
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
      <xs:element name="SetActivityFilter">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ActivityFilter" nillable="true" type="tns:ActivityFilter" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetActivityFilterResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetGroupAssociateIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="GroupIds" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetGroupAssociateIdsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q2:ArrayOfint" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveConfiguration">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="GuiName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveConfigurationResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArchiveConfiguration" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArchiveConfiguration">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ArchiveColumnInfo" nillable="true" type="tns:ArrayOfArchiveColumnInfo" />
              <xs:element minOccurs="0" name="ArchiveEntityInfo" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
              <xs:element minOccurs="0" name="ArchiveOrderByInfo" nillable="true" type="tns:ArrayOfArchiveOrderByInfo" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ArchiveConfiguration" nillable="true" type="tns:ArchiveConfiguration" />
      <xs:complexType name="ArrayOfArchiveColumnInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArchiveColumnInfo" nillable="true" type="tns:ArchiveColumnInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArchiveColumnInfo" nillable="true" type="tns:ArrayOfArchiveColumnInfo" />
      <xs:complexType name="ArchiveColumnInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DisplayTooltip" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DisplayType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="CanOrderBy" type="xs:boolean" />
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="CanRestrictBy" type="xs:boolean" />
          <xs:element minOccurs="0" name="RestrictionType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="RestrictionListName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="IsVisible" type="xs:boolean" />
          <xs:element minOccurs="0" name="Width" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="IconHint" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="HeadingIconHint" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArchiveColumnInfo" nillable="true" type="tns:ArchiveColumnInfo" />
      <xs:complexType name="ArrayOfArchiveOrderByInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArchiveOrderByInfo" nillable="true" type="tns:ArchiveOrderByInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArchiveOrderByInfo" nillable="true" type="tns:ArrayOfArchiveOrderByInfo" />
      <xs:complexType name="ArchiveOrderByInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Direction" type="tns:OrderBySortType" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArchiveOrderByInfo" nillable="true" type="tns:ArchiveOrderByInfo" />
      <xs:simpleType name="OrderBySortType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="ASC" />
          <xs:enumeration value="DESC" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="OrderBySortType" nillable="true" type="tns:OrderBySortType" />
      <xs:element name="GetArchiveConfigurationWithContext">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="GuiName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveConfigurationWithContextResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArchiveConfiguration" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetColumnWidths">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="GuiName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ColumnWidths" nillable="true" type="q3:ArrayOfstring" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetColumnWidthsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetChosenEntities">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="GuiName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Entities" nillable="true" type="q4:ArrayOfstring" xmlns:q4="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetChosenEntitiesResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetChosenColumns">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="GuiName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ChosenColumns" nillable="true" type="q5:ArrayOfstring" xmlns:q5="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetChosenColumnsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListByColumns">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Columns" nillable="true" type="q6:ArrayOfstring" xmlns:q6="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="SortOrder" nillable="true" type="tns:ArrayOfArchiveOrderByInfo" />
            <xs:element minOccurs="0" name="Restriction" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
            <xs:element minOccurs="0" name="Entities" nillable="true" type="q7:ArrayOfstring" xmlns:q7="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Page" type="xs:int" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfArchiveRestrictionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArchiveRestrictionInfo" nillable="true" type="tns:ArchiveRestrictionInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArchiveRestrictionInfo" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
      <xs:complexType name="ArchiveRestrictionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Operator" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Values" nillable="true" type="q8:ArrayOfstring" xmlns:q8="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="DisplayValues" nillable="true" type="q9:ArrayOfstring" xmlns:q9="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="ColumnInfo" nillable="true" type="tns:ArchiveColumnInfo" />
          <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
          <xs:element minOccurs="0" name="SubRestrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
          <xs:element minOccurs="0" name="InterParenthesis" type="xs:int" />
          <xs:element minOccurs="0" name="InterOperator" type="tns:InterRestrictionOperator" />
          <xs:element minOccurs="0" name="UniqueHash" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArchiveRestrictionInfo" nillable="true" type="tns:ArchiveRestrictionInfo" />
      <xs:simpleType name="InterRestrictionOperator">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="And" />
          <xs:enumeration value="Or" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="InterRestrictionOperator" nillable="true" type="tns:InterRestrictionOperator" />
      <xs:element name="GetArchiveListByColumnsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfArchiveListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListByColumnsWithContext">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Columns" nillable="true" type="q10:ArrayOfstring" xmlns:q10="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="SortOrder" nillable="true" type="tns:ArrayOfArchiveOrderByInfo" />
            <xs:element minOccurs="0" name="Restriction" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
            <xs:element minOccurs="0" name="Entities" nillable="true" type="q11:ArrayOfstring" xmlns:q11="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Page" type="xs:int" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListByColumnsWithContextResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfArchiveListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="GuiName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="SortOrder" nillable="true" type="tns:ArrayOfArchiveOrderByInfo" />
            <xs:element minOccurs="0" name="Restriction" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
            <xs:element minOccurs="0" name="Entities" nillable="true" type="q12:ArrayOfstring" xmlns:q12="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Page" type="xs:int" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfArchiveListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListWithContext">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="GuiName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="SortOrder" nillable="true" type="tns:ArrayOfArchiveOrderByInfo" />
            <xs:element minOccurs="0" name="Restriction" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
            <xs:element minOccurs="0" name="Entities" nillable="true" type="q13:ArrayOfstring" xmlns:q13="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Page" type="xs:int" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListWithContextResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfArchiveListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListByColumnsWithHeader">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Columns" nillable="true" type="q14:ArrayOfstring" xmlns:q14="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="SortOrder" nillable="true" type="tns:ArrayOfArchiveOrderByInfo" />
            <xs:element minOccurs="0" name="Restriction" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
            <xs:element minOccurs="0" name="Entities" nillable="true" type="q15:ArrayOfstring" xmlns:q15="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Page" type="xs:int" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="Options" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListByColumnsWithHeaderResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArchiveListResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProviderNames">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProviderNamesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q16:ArrayOfstring" xmlns:q16="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListByColumnsWithHeaderWithContext">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Columns" nillable="true" type="q17:ArrayOfstring" xmlns:q17="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="SortOrder" nillable="true" type="tns:ArrayOfArchiveOrderByInfo" />
            <xs:element minOccurs="0" name="Restriction" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
            <xs:element minOccurs="0" name="Entities" nillable="true" type="q18:ArrayOfstring" xmlns:q18="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Page" type="xs:int" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="Options" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListByColumnsWithHeaderWithContextResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArchiveListResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAvailableColumns">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAvailableColumnsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfArchiveColumnInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAvailableEntities">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAvailableEntitiesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListByColumns2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Columns" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="SortOrder" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Entities" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Page" type="xs:int" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListByColumns2Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfArchiveListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListByColumnsWithContext2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Columns" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="SortOrder" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Restriction" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Entities" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Page" type="xs:int" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListByColumnsWithContext2Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfArchiveListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveList2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="GuiName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="SortOrder" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Restriction" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Entities" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Page" type="xs:int" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveList2Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfArchiveListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListWithContext2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="GuiName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="SortOrder" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Restriction" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Entities" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Page" type="xs:int" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListWithContext2Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfArchiveListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListByColumnsWithHeader2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Columns" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="SortOrder" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Restriction" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Entities" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Page" type="xs:int" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="Options" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListByColumnsWithHeader2Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArchiveListResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListByColumnsWithHeaderWithContext2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Columns" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="SortOrder" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Restriction" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Entities" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Page" type="xs:int" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="Options" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArchiveListByColumnsWithHeaderWithContext2Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArchiveListResult" />
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
  <wsdl:message name="CreateDefaultArchiveListResultRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultArchiveListResult" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultArchiveListResultRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultArchiveListResultResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultArchiveListResultResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultArchiveListResultResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetActivityFilterRequest">
    <wsdl:part name="parameters" element="tns:GetActivityFilter" />
  </wsdl:message>
  <wsdl:message name="GetActivityFilterRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetActivityFilterResponse">
    <wsdl:part name="parameters" element="tns:GetActivityFilterResponse" />
  </wsdl:message>
  <wsdl:message name="GetActivityFilterResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetActivityFilterRequest">
    <wsdl:part name="parameters" element="tns:SetActivityFilter" />
  </wsdl:message>
  <wsdl:message name="SetActivityFilterRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetActivityFilterResponse">
    <wsdl:part name="parameters" element="tns:SetActivityFilterResponse" />
  </wsdl:message>
  <wsdl:message name="SetActivityFilterResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetGroupAssociateIdsRequest">
    <wsdl:part name="parameters" element="tns:GetGroupAssociateIds" />
  </wsdl:message>
  <wsdl:message name="GetGroupAssociateIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetGroupAssociateIdsResponse">
    <wsdl:part name="parameters" element="tns:GetGroupAssociateIdsResponse" />
  </wsdl:message>
  <wsdl:message name="GetGroupAssociateIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveConfigurationRequest">
    <wsdl:part name="parameters" element="tns:GetArchiveConfiguration" />
  </wsdl:message>
  <wsdl:message name="GetArchiveConfigurationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveConfigurationResponse">
    <wsdl:part name="parameters" element="tns:GetArchiveConfigurationResponse" />
  </wsdl:message>
  <wsdl:message name="GetArchiveConfigurationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveConfigurationWithContextRequest">
    <wsdl:part name="parameters" element="tns:GetArchiveConfigurationWithContext" />
  </wsdl:message>
  <wsdl:message name="GetArchiveConfigurationWithContextRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveConfigurationWithContextResponse">
    <wsdl:part name="parameters" element="tns:GetArchiveConfigurationWithContextResponse" />
  </wsdl:message>
  <wsdl:message name="GetArchiveConfigurationWithContextResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetColumnWidthsRequest">
    <wsdl:part name="parameters" element="tns:SetColumnWidths" />
  </wsdl:message>
  <wsdl:message name="SetColumnWidthsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetColumnWidthsResponse">
    <wsdl:part name="parameters" element="tns:SetColumnWidthsResponse" />
  </wsdl:message>
  <wsdl:message name="SetColumnWidthsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetChosenEntitiesRequest">
    <wsdl:part name="parameters" element="tns:SetChosenEntities" />
  </wsdl:message>
  <wsdl:message name="SetChosenEntitiesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetChosenEntitiesResponse">
    <wsdl:part name="parameters" element="tns:SetChosenEntitiesResponse" />
  </wsdl:message>
  <wsdl:message name="SetChosenEntitiesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetChosenColumnsRequest">
    <wsdl:part name="parameters" element="tns:SetChosenColumns" />
  </wsdl:message>
  <wsdl:message name="SetChosenColumnsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetChosenColumnsResponse">
    <wsdl:part name="parameters" element="tns:SetChosenColumnsResponse" />
  </wsdl:message>
  <wsdl:message name="SetChosenColumnsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsRequest">
    <wsdl:part name="parameters" element="tns:GetArchiveListByColumns" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsResponse">
    <wsdl:part name="parameters" element="tns:GetArchiveListByColumnsResponse" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithContextRequest">
    <wsdl:part name="parameters" element="tns:GetArchiveListByColumnsWithContext" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithContextRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithContextResponse">
    <wsdl:part name="parameters" element="tns:GetArchiveListByColumnsWithContextResponse" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithContextResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListRequest">
    <wsdl:part name="parameters" element="tns:GetArchiveList" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListResponse">
    <wsdl:part name="parameters" element="tns:GetArchiveListResponse" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListWithContextRequest">
    <wsdl:part name="parameters" element="tns:GetArchiveListWithContext" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListWithContextRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListWithContextResponse">
    <wsdl:part name="parameters" element="tns:GetArchiveListWithContextResponse" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListWithContextResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithHeaderRequest">
    <wsdl:part name="parameters" element="tns:GetArchiveListByColumnsWithHeader" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithHeaderRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithHeaderResponse">
    <wsdl:part name="parameters" element="tns:GetArchiveListByColumnsWithHeaderResponse" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithHeaderResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProviderNamesRequest">
    <wsdl:part name="parameters" element="tns:GetProviderNames" />
  </wsdl:message>
  <wsdl:message name="GetProviderNamesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProviderNamesResponse">
    <wsdl:part name="parameters" element="tns:GetProviderNamesResponse" />
  </wsdl:message>
  <wsdl:message name="GetProviderNamesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithHeaderWithContextRequest">
    <wsdl:part name="parameters" element="tns:GetArchiveListByColumnsWithHeaderWithContext" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithHeaderWithContextRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithHeaderWithContextResponse">
    <wsdl:part name="parameters" element="tns:GetArchiveListByColumnsWithHeaderWithContextResponse" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithHeaderWithContextResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAvailableColumnsRequest">
    <wsdl:part name="parameters" element="tns:GetAvailableColumns" />
  </wsdl:message>
  <wsdl:message name="GetAvailableColumnsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAvailableColumnsResponse">
    <wsdl:part name="parameters" element="tns:GetAvailableColumnsResponse" />
  </wsdl:message>
  <wsdl:message name="GetAvailableColumnsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAvailableEntitiesRequest">
    <wsdl:part name="parameters" element="tns:GetAvailableEntities" />
  </wsdl:message>
  <wsdl:message name="GetAvailableEntitiesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAvailableEntitiesResponse">
    <wsdl:part name="parameters" element="tns:GetAvailableEntitiesResponse" />
  </wsdl:message>
  <wsdl:message name="GetAvailableEntitiesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumns2Request">
    <wsdl:part name="parameters" element="tns:GetArchiveListByColumns2" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumns2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumns2Response">
    <wsdl:part name="parameters" element="tns:GetArchiveListByColumns2Response" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumns2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithContext2Request">
    <wsdl:part name="parameters" element="tns:GetArchiveListByColumnsWithContext2" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithContext2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithContext2Response">
    <wsdl:part name="parameters" element="tns:GetArchiveListByColumnsWithContext2Response" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithContext2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveList2Request">
    <wsdl:part name="parameters" element="tns:GetArchiveList2" />
  </wsdl:message>
  <wsdl:message name="GetArchiveList2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveList2Response">
    <wsdl:part name="parameters" element="tns:GetArchiveList2Response" />
  </wsdl:message>
  <wsdl:message name="GetArchiveList2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListWithContext2Request">
    <wsdl:part name="parameters" element="tns:GetArchiveListWithContext2" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListWithContext2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListWithContext2Response">
    <wsdl:part name="parameters" element="tns:GetArchiveListWithContext2Response" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListWithContext2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithHeader2Request">
    <wsdl:part name="parameters" element="tns:GetArchiveListByColumnsWithHeader2" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithHeader2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithHeader2Response">
    <wsdl:part name="parameters" element="tns:GetArchiveListByColumnsWithHeader2Response" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithHeader2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithHeaderWithContext2Request">
    <wsdl:part name="parameters" element="tns:GetArchiveListByColumnsWithHeaderWithContext2" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithHeaderWithContext2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithHeaderWithContext2Response">
    <wsdl:part name="parameters" element="tns:GetArchiveListByColumnsWithHeaderWithContext2Response" />
  </wsdl:message>
  <wsdl:message name="GetArchiveListByColumnsWithHeaderWithContext2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Archive">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Archive</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultArchiveListResult">
      <wsdl:documentation>
        <summary>Loading default values into a new ArchiveListResult.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/CreateDefaultArchiveListResult" name="CreateDefaultArchiveListResultRequest" message="tns:CreateDefaultArchiveListResultRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/CreateDefaultArchiveListResultResponse" name="CreateDefaultArchiveListResultResponse" message="tns:CreateDefaultArchiveListResultResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetActivityFilter">
      <wsdl:documentation>
        <summary>Get activity filter for the specified list.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetActivityFilter" name="GetActivityFilterRequest" message="tns:GetActivityFilterRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetActivityFilterResponse" name="GetActivityFilterResponse" message="tns:GetActivityFilterResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetActivityFilter">
      <wsdl:documentation>
        <summary>Set activity filter for the specified list.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/SetActivityFilter" name="SetActivityFilterRequest" message="tns:SetActivityFilterRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/SetActivityFilterResponse" name="SetActivityFilterResponse" message="tns:SetActivityFilterResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetGroupAssociateIds">
      <wsdl:documentation>
        <summary>Returns the  associate ids that belongs to the given groups</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetGroupAssociateIds" name="GetGroupAssociateIdsRequest" message="tns:GetGroupAssociateIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetGroupAssociateIdsResponse" name="GetGroupAssociateIdsResponse" message="tns:GetGroupAssociateIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetArchiveConfiguration">
      <wsdl:documentation>
        <summary>Get the configuration for one archive. The configuration is keyed by a combination of archive provider name and gui name. The archive provider name must match an archive provider plugin; the gui name is an arbitrary string used to distinguish multiple occurrences of the same underlying provider in a gui.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveConfiguration" name="GetArchiveConfigurationRequest" message="tns:GetArchiveConfigurationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveConfigurationResponse" name="GetArchiveConfigurationResponse" message="tns:GetArchiveConfigurationResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetArchiveConfigurationWithContext">
      <wsdl:documentation>
        <summary>Get the configuration for one archive, with context parameter. The configuration is keyed by a combination of archive provider name and gui name. The archive provider name must match an archive provider plugin; the gui name is an arbitrary string used to distinguish multiple occurrences of the same underlying provider in a gui.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveConfigurationWithContext" name="GetArchiveConfigurationWithContextRequest" message="tns:GetArchiveConfigurationWithContextRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveConfigurationWithContextResponse" name="GetArchiveConfigurationWithContextResponse" message="tns:GetArchiveConfigurationWithContextResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetColumnWidths">
      <wsdl:documentation>
        <summary>Set the column widths for the given set of columns and GUI name. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/SetColumnWidths" name="SetColumnWidthsRequest" message="tns:SetColumnWidthsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/SetColumnWidthsResponse" name="SetColumnWidthsResponse" message="tns:SetColumnWidthsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetChosenEntities">
      <wsdl:documentation>
        <summary>Set the currently chosen entities for the given gui name/provider name combination. This service corresponds to the SetSelected method of the SelectableMDOList service, for a list called archiveEntities: plus the archive provider name and gui name as its additionalInfo.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/SetChosenEntities" name="SetChosenEntitiesRequest" message="tns:SetChosenEntitiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/SetChosenEntitiesResponse" name="SetChosenEntitiesResponse" message="tns:SetChosenEntitiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetChosenColumns">
      <wsdl:documentation>
        <summary>Set the currently chosen columns for the given gui name/provider name combination. This service corresponds to the SetSelected method of the SelectableMDOList service, for a list called archiveColumns: plus the archive provider name and gui name as its additionalInfo.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/SetChosenColumns" name="SetChosenColumnsRequest" message="tns:SetChosenColumnsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/SetChosenColumnsResponse" name="SetChosenColumnsResponse" message="tns:SetChosenColumnsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListByColumns">
      <wsdl:documentation>
        <summary>Get a page of results for an archive list, explicitly specifying the restrictions, orderby and chosen columns.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumns" name="GetArchiveListByColumnsRequest" message="tns:GetArchiveListByColumnsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsResponse" name="GetArchiveListByColumnsResponse" message="tns:GetArchiveListByColumnsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListByColumnsWithContext">
      <wsdl:documentation>
        <summary>Get a page of results for an archive list with context parameter, explicitly specifying the restrictions, orderby and chosen columns.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsWithContext" name="GetArchiveListByColumnsWithContextRequest" message="tns:GetArchiveListByColumnsWithContextRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsWithContextResponse" name="GetArchiveListByColumnsWithContextResponse" message="tns:GetArchiveListByColumnsWithContextResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetArchiveList">
      <wsdl:documentation>
        <summary>Get a page of data for an archive. The columns returned will be those set as chosen columns, using either the SetChosenColumns service or the corresponding SelectableMDOList.SetSelected.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveList" name="GetArchiveListRequest" message="tns:GetArchiveListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListResponse" name="GetArchiveListResponse" message="tns:GetArchiveListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListWithContext">
      <wsdl:documentation>
        <summary>Get a page of data for an archive, with context parameter. The columns returned will be those set as chosen columns, using either the SetChosenColumns service or the corresponding SelectableMDOList.SetSelected.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListWithContext" name="GetArchiveListWithContextRequest" message="tns:GetArchiveListWithContextRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListWithContextResponse" name="GetArchiveListWithContextResponse" message="tns:GetArchiveListWithContextResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListByColumnsWithHeader">
      <wsdl:documentation>
        <summary>Get a page of results for an archive list, explicitly specifying the restrictions, orderby and chosen columns; as well as a name/value string formatted set of options. The return value includes a header that has various extra information, in addition to the actual rows.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsWithHeader" name="GetArchiveListByColumnsWithHeaderRequest" message="tns:GetArchiveListByColumnsWithHeaderRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsWithHeaderResponse" name="GetArchiveListByColumnsWithHeaderResponse" message="tns:GetArchiveListByColumnsWithHeaderResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProviderNames">
      <wsdl:documentation>
        <summary>Return list of all archive provider names</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetProviderNames" name="GetProviderNamesRequest" message="tns:GetProviderNamesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetProviderNamesResponse" name="GetProviderNamesResponse" message="tns:GetProviderNamesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListByColumnsWithHeaderWithContext">
      <wsdl:documentation>
        <summary>Get a page of results for an archive list, with context parameter, explicitly specifying the restrictions, orderby and chosen columns; as well as a name/value string formatted set of options. The return value includes a header that has various extra information, in addition to the actual rows.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsWithHeaderWithContext" name="GetArchiveListByColumnsWithHeaderWithContextRequest" message="tns:GetArchiveListByColumnsWithHeaderWithContextRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsWithHeaderWithContextResponse" name="GetArchiveListByColumnsWithHeaderWithContextResponse" message="tns:GetArchiveListByColumnsWithHeaderWithContextResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAvailableColumns">
      <wsdl:documentation>
        <summary>Return list of all columns supported by an archive provider. See also GetArchiveConfiguration.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetAvailableColumns" name="GetAvailableColumnsRequest" message="tns:GetAvailableColumnsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetAvailableColumnsResponse" name="GetAvailableColumnsResponse" message="tns:GetAvailableColumnsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAvailableEntities">
      <wsdl:documentation>
        <summary>Return list of all entities supported by an archive provider. See also GetArchiveConfiguration.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetAvailableEntities" name="GetAvailableEntitiesRequest" message="tns:GetAvailableEntitiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetAvailableEntitiesResponse" name="GetAvailableEntitiesResponse" message="tns:GetAvailableEntitiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListByColumns2">
      <wsdl:documentation>
        <summary>Get a page of results for an archive list, explicitly specifying the restrictions as a string, orderby and chosen columns.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumns2" name="GetArchiveListByColumns2Request" message="tns:GetArchiveListByColumns2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumns2Response" name="GetArchiveListByColumns2Response" message="tns:GetArchiveListByColumns2Response" />
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListByColumnsWithContext2">
      <wsdl:documentation>
        <summary>Get a page of results for an archive list with context parameter, explicitly specifying the restrictions as a string, orderby and chosen columns.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsWithContext2" name="GetArchiveListByColumnsWithContext2Request" message="tns:GetArchiveListByColumnsWithContext2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsWithContext2Response" name="GetArchiveListByColumnsWithContext2Response" message="tns:GetArchiveListByColumnsWithContext2Response" />
    </wsdl:operation>
    <wsdl:operation name="GetArchiveList2">
      <wsdl:documentation>
        <summary>Get a page of data for an archive using a restriction string. The columns returned will be those set as chosen columns, using either the SetChosenColumns service or the corresponding SelectableMDOList.SetSelected.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveList2" name="GetArchiveList2Request" message="tns:GetArchiveList2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveList2Response" name="GetArchiveList2Response" message="tns:GetArchiveList2Response" />
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListWithContext2">
      <wsdl:documentation>
        <summary>Get a page of data for an archive using restrictions as strings, with context parameter. The columns returned will be those set as chosen columns, using either the SetChosenColumns service or the corresponding SelectableMDOList.SetSelected.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListWithContext2" name="GetArchiveListWithContext2Request" message="tns:GetArchiveListWithContext2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListWithContext2Response" name="GetArchiveListWithContext2Response" message="tns:GetArchiveListWithContext2Response" />
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListByColumnsWithHeader2">
      <wsdl:documentation>
        <summary>Get a page of results for an archive list, explicitly specifying the restrictions as strings, orderby and chosen columns; as well as a name/value string formatted set of options. The return value includes a header that has various extra information, in addition to the actual rows.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsWithHeader2" name="GetArchiveListByColumnsWithHeader2Request" message="tns:GetArchiveListByColumnsWithHeader2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsWithHeader2Response" name="GetArchiveListByColumnsWithHeader2Response" message="tns:GetArchiveListByColumnsWithHeader2Response" />
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListByColumnsWithHeaderWithContext2">
      <wsdl:documentation>
        <summary>Get a page of results for an archive list, with context parameter, explicitly specifying the restrictions as strings, orderby and chosen columns; as well as a name/value string formatted set of options. The return value includes a header that has various extra information, in addition to the actual rows.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsWithHeaderWithContext2" name="GetArchiveListByColumnsWithHeaderWithContext2Request" message="tns:GetArchiveListByColumnsWithHeaderWithContext2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsWithHeaderWithContext2Response" name="GetArchiveListByColumnsWithHeaderWithContext2Response" message="tns:GetArchiveListByColumnsWithHeaderWithContext2Response" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Archive" type="tns:Archive">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultArchiveListResult">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/CreateDefaultArchiveListResult" style="document" />
      <wsdl:input name="CreateDefaultArchiveListResultRequest">
        <soap:header message="tns:CreateDefaultArchiveListResultRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultArchiveListResultRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultArchiveListResultRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultArchiveListResultResponse">
        <soap:header message="tns:CreateDefaultArchiveListResultResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultArchiveListResultResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultArchiveListResultResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultArchiveListResultResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetActivityFilter">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetActivityFilter" style="document" />
      <wsdl:input name="GetActivityFilterRequest">
        <soap:header message="tns:GetActivityFilterRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetActivityFilterRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetActivityFilterRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetActivityFilterResponse">
        <soap:header message="tns:GetActivityFilterResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetActivityFilterResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetActivityFilterResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetActivityFilterResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetActivityFilter">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/SetActivityFilter" style="document" />
      <wsdl:input name="SetActivityFilterRequest">
        <soap:header message="tns:SetActivityFilterRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetActivityFilterRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetActivityFilterRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetActivityFilterResponse">
        <soap:header message="tns:SetActivityFilterResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetActivityFilterResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetActivityFilterResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetActivityFilterResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetGroupAssociateIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetGroupAssociateIds" style="document" />
      <wsdl:input name="GetGroupAssociateIdsRequest">
        <soap:header message="tns:GetGroupAssociateIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetGroupAssociateIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetGroupAssociateIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetGroupAssociateIdsResponse">
        <soap:header message="tns:GetGroupAssociateIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetGroupAssociateIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetGroupAssociateIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetGroupAssociateIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetArchiveConfiguration">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveConfiguration" style="document" />
      <wsdl:input name="GetArchiveConfigurationRequest">
        <soap:header message="tns:GetArchiveConfigurationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetArchiveConfigurationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetArchiveConfigurationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetArchiveConfigurationResponse">
        <soap:header message="tns:GetArchiveConfigurationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetArchiveConfigurationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetArchiveConfigurationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetArchiveConfigurationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetArchiveConfigurationWithContext">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveConfigurationWithContext" style="document" />
      <wsdl:input name="GetArchiveConfigurationWithContextRequest">
        <soap:header message="tns:GetArchiveConfigurationWithContextRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetArchiveConfigurationWithContextRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetArchiveConfigurationWithContextRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetArchiveConfigurationWithContextResponse">
        <soap:header message="tns:GetArchiveConfigurationWithContextResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetArchiveConfigurationWithContextResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetArchiveConfigurationWithContextResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetArchiveConfigurationWithContextResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetColumnWidths">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/SetColumnWidths" style="document" />
      <wsdl:input name="SetColumnWidthsRequest">
        <soap:header message="tns:SetColumnWidthsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetColumnWidthsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetColumnWidthsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetColumnWidthsResponse">
        <soap:header message="tns:SetColumnWidthsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetColumnWidthsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetColumnWidthsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetColumnWidthsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetChosenEntities">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/SetChosenEntities" style="document" />
      <wsdl:input name="SetChosenEntitiesRequest">
        <soap:header message="tns:SetChosenEntitiesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetChosenEntitiesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetChosenEntitiesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetChosenEntitiesResponse">
        <soap:header message="tns:SetChosenEntitiesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetChosenEntitiesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetChosenEntitiesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetChosenEntitiesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetChosenColumns">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/SetChosenColumns" style="document" />
      <wsdl:input name="SetChosenColumnsRequest">
        <soap:header message="tns:SetChosenColumnsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetChosenColumnsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetChosenColumnsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetChosenColumnsResponse">
        <soap:header message="tns:SetChosenColumnsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetChosenColumnsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetChosenColumnsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetChosenColumnsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListByColumns">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumns" style="document" />
      <wsdl:input name="GetArchiveListByColumnsRequest">
        <soap:header message="tns:GetArchiveListByColumnsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetArchiveListByColumnsResponse">
        <soap:header message="tns:GetArchiveListByColumnsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListByColumnsWithContext">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsWithContext" style="document" />
      <wsdl:input name="GetArchiveListByColumnsWithContextRequest">
        <soap:header message="tns:GetArchiveListByColumnsWithContextRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithContextRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithContextRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetArchiveListByColumnsWithContextResponse">
        <soap:header message="tns:GetArchiveListByColumnsWithContextResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithContextResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithContextResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithContextResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetArchiveList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveList" style="document" />
      <wsdl:input name="GetArchiveListRequest">
        <soap:header message="tns:GetArchiveListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetArchiveListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetArchiveListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetArchiveListResponse">
        <soap:header message="tns:GetArchiveListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetArchiveListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetArchiveListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetArchiveListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListWithContext">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListWithContext" style="document" />
      <wsdl:input name="GetArchiveListWithContextRequest">
        <soap:header message="tns:GetArchiveListWithContextRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetArchiveListWithContextRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetArchiveListWithContextRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetArchiveListWithContextResponse">
        <soap:header message="tns:GetArchiveListWithContextResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetArchiveListWithContextResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetArchiveListWithContextResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetArchiveListWithContextResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListByColumnsWithHeader">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsWithHeader" style="document" />
      <wsdl:input name="GetArchiveListByColumnsWithHeaderRequest">
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetArchiveListByColumnsWithHeaderResponse">
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProviderNames">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetProviderNames" style="document" />
      <wsdl:input name="GetProviderNamesRequest">
        <soap:header message="tns:GetProviderNamesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProviderNamesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProviderNamesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProviderNamesResponse">
        <soap:header message="tns:GetProviderNamesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProviderNamesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProviderNamesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProviderNamesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListByColumnsWithHeaderWithContext">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsWithHeaderWithContext" style="document" />
      <wsdl:input name="GetArchiveListByColumnsWithHeaderWithContextRequest">
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderWithContextRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderWithContextRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderWithContextRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetArchiveListByColumnsWithHeaderWithContextResponse">
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderWithContextResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderWithContextResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderWithContextResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderWithContextResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAvailableColumns">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetAvailableColumns" style="document" />
      <wsdl:input name="GetAvailableColumnsRequest">
        <soap:header message="tns:GetAvailableColumnsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAvailableColumnsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAvailableColumnsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAvailableColumnsResponse">
        <soap:header message="tns:GetAvailableColumnsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAvailableColumnsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAvailableColumnsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAvailableColumnsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAvailableEntities">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetAvailableEntities" style="document" />
      <wsdl:input name="GetAvailableEntitiesRequest">
        <soap:header message="tns:GetAvailableEntitiesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAvailableEntitiesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAvailableEntitiesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAvailableEntitiesResponse">
        <soap:header message="tns:GetAvailableEntitiesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAvailableEntitiesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAvailableEntitiesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAvailableEntitiesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListByColumns2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumns2" style="document" />
      <wsdl:input name="GetArchiveListByColumns2Request">
        <soap:header message="tns:GetArchiveListByColumns2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetArchiveListByColumns2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetArchiveListByColumns2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetArchiveListByColumns2Response">
        <soap:header message="tns:GetArchiveListByColumns2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetArchiveListByColumns2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetArchiveListByColumns2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetArchiveListByColumns2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListByColumnsWithContext2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsWithContext2" style="document" />
      <wsdl:input name="GetArchiveListByColumnsWithContext2Request">
        <soap:header message="tns:GetArchiveListByColumnsWithContext2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithContext2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithContext2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetArchiveListByColumnsWithContext2Response">
        <soap:header message="tns:GetArchiveListByColumnsWithContext2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithContext2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithContext2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithContext2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetArchiveList2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveList2" style="document" />
      <wsdl:input name="GetArchiveList2Request">
        <soap:header message="tns:GetArchiveList2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetArchiveList2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetArchiveList2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetArchiveList2Response">
        <soap:header message="tns:GetArchiveList2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetArchiveList2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetArchiveList2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetArchiveList2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListWithContext2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListWithContext2" style="document" />
      <wsdl:input name="GetArchiveListWithContext2Request">
        <soap:header message="tns:GetArchiveListWithContext2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetArchiveListWithContext2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetArchiveListWithContext2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetArchiveListWithContext2Response">
        <soap:header message="tns:GetArchiveListWithContext2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetArchiveListWithContext2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetArchiveListWithContext2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetArchiveListWithContext2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListByColumnsWithHeader2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsWithHeader2" style="document" />
      <wsdl:input name="GetArchiveListByColumnsWithHeader2Request">
        <soap:header message="tns:GetArchiveListByColumnsWithHeader2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeader2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeader2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetArchiveListByColumnsWithHeader2Response">
        <soap:header message="tns:GetArchiveListByColumnsWithHeader2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeader2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeader2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeader2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetArchiveListByColumnsWithHeaderWithContext2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Archive/GetArchiveListByColumnsWithHeaderWithContext2" style="document" />
      <wsdl:input name="GetArchiveListByColumnsWithHeaderWithContext2Request">
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderWithContext2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderWithContext2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderWithContext2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetArchiveListByColumnsWithHeaderWithContext2Response">
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderWithContext2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderWithContext2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderWithContext2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetArchiveListByColumnsWithHeaderWithContext2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfArchiveService">
    <wsdl:port name="BasicHttpBinding_Archive" binding="tns:BasicHttpBinding_Archive">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services87/Archive.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

