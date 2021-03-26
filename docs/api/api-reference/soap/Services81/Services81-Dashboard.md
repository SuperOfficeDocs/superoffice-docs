---
Generated: 1
TOCExclude: 1
title: Services81.DashboardAgent WSDL
---

# Services81.DashboardAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfDashboardService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services81" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services81" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services81" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:element name="CreateDefaultDashboard">
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
      <xs:element name="CreateDefaultDashboardResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Dashboard" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Dashboard">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="DashboardId" type="xs:int" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Caption" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Layout" type="tns:DashboardLayout" />
              <xs:element minOccurs="0" name="Tiles" nillable="true" type="tns:ArrayOfDashboardTile" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Dashboard" nillable="true" type="tns:Dashboard" />
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
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="EFieldRight" nillable="true" type="tns:EFieldRight" />
      <xs:simpleType name="DashboardLayout">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="One" />
          <xs:enumeration value="TwoVerticalSplit" />
          <xs:enumeration value="ThreeESplit" />
          <xs:enumeration value="TwoHorizontalSplit" />
          <xs:enumeration value="ThreeTSplit" />
          <xs:enumeration value="Four">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">7</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="DashboardLayout" nillable="true" type="tns:DashboardLayout" />
      <xs:complexType name="ArrayOfDashboardTile">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DashboardTile" nillable="true" type="tns:DashboardTile" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDashboardTile" nillable="true" type="tns:ArrayOfDashboardTile" />
      <xs:complexType name="DashboardTile">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="DashboardTileId" type="xs:int" />
              <xs:element minOccurs="0" name="Caption" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Config" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Type" type="tns:DashboardTileType" />
              <xs:element minOccurs="0" name="EntityType" type="tns:DashboardTileEntityType" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DashboardTile" nillable="true" type="tns:DashboardTile" />
      <xs:simpleType name="DashboardTileType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Chart" />
          <xs:enumeration value="Web" />
          <xs:enumeration value="List" />
          <xs:enumeration value="Bignum" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="DashboardTileType" nillable="true" type="tns:DashboardTileType" />
      <xs:simpleType name="DashboardTileEntityType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Company" />
          <xs:enumeration value="Project" />
          <xs:enumeration value="Sale" />
          <xs:enumeration value="Product" />
          <xs:enumeration value="Activity" />
          <xs:enumeration value="Document" />
          <xs:enumeration value="WebPanel" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="DashboardTileEntityType" nillable="true" type="tns:DashboardTileEntityType" />
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
      <xs:element name="SaveDashboard">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Dashboard" nillable="true" type="tns:Dashboard" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDashboardResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Dashboard" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDashboard">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashboardId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDashboardResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultDashboardTile">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultDashboardTileResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashboardTile" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDashboardTile">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashboardTile" nillable="true" type="tns:DashboardTile" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDashboardTileResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashboardTile" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDashboardTile">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashboardTileId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDashboardTileResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashboard">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashboardId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashboardResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Dashboard" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashboards">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashboardsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDashboard" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDashboard">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Dashboard" nillable="true" type="tns:Dashboard" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDashboard" nillable="true" type="tns:ArrayOfDashboard" />
      <xs:element name="GetDashboardTile">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashboardTileId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashboardTileResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashboardTile" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetData">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashboardTileId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDataResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTileData" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfTileData">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TileData" nillable="true" type="tns:TileData" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTileData" nillable="true" type="tns:ArrayOfTileData" />
      <xs:complexType name="TileData">
        <xs:sequence>
          <xs:element minOccurs="0" name="Columns" nillable="true" type="tns:ArrayOfArchiveColumnInfo" />
          <xs:element minOccurs="0" name="Result" nillable="true" type="tns:ArchiveListResult" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TileData" nillable="true" type="tns:TileData" />
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
  <wsdl:message name="CreateDefaultDashboardRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultDashboard" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashboardRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashboardResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultDashboardResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashboardResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDashboardRequest">
    <wsdl:part name="parameters" element="tns:SaveDashboard" />
  </wsdl:message>
  <wsdl:message name="SaveDashboardRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDashboardResponse">
    <wsdl:part name="parameters" element="tns:SaveDashboardResponse" />
  </wsdl:message>
  <wsdl:message name="SaveDashboardResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDashboardRequest">
    <wsdl:part name="parameters" element="tns:DeleteDashboard" />
  </wsdl:message>
  <wsdl:message name="DeleteDashboardRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDashboardResponse">
    <wsdl:part name="parameters" element="tns:DeleteDashboardResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteDashboardResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashboardTileRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultDashboardTile" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashboardTileRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashboardTileResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultDashboardTileResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashboardTileResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDashboardTileRequest">
    <wsdl:part name="parameters" element="tns:SaveDashboardTile" />
  </wsdl:message>
  <wsdl:message name="SaveDashboardTileRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDashboardTileResponse">
    <wsdl:part name="parameters" element="tns:SaveDashboardTileResponse" />
  </wsdl:message>
  <wsdl:message name="SaveDashboardTileResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDashboardTileRequest">
    <wsdl:part name="parameters" element="tns:DeleteDashboardTile" />
  </wsdl:message>
  <wsdl:message name="DeleteDashboardTileRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDashboardTileResponse">
    <wsdl:part name="parameters" element="tns:DeleteDashboardTileResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteDashboardTileResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashboardRequest">
    <wsdl:part name="parameters" element="tns:GetDashboard" />
  </wsdl:message>
  <wsdl:message name="GetDashboardRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashboardResponse">
    <wsdl:part name="parameters" element="tns:GetDashboardResponse" />
  </wsdl:message>
  <wsdl:message name="GetDashboardResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashboardsRequest">
    <wsdl:part name="parameters" element="tns:GetDashboards" />
  </wsdl:message>
  <wsdl:message name="GetDashboardsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashboardsResponse">
    <wsdl:part name="parameters" element="tns:GetDashboardsResponse" />
  </wsdl:message>
  <wsdl:message name="GetDashboardsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashboardTileRequest">
    <wsdl:part name="parameters" element="tns:GetDashboardTile" />
  </wsdl:message>
  <wsdl:message name="GetDashboardTileRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashboardTileResponse">
    <wsdl:part name="parameters" element="tns:GetDashboardTileResponse" />
  </wsdl:message>
  <wsdl:message name="GetDashboardTileResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDataRequest">
    <wsdl:part name="parameters" element="tns:GetData" />
  </wsdl:message>
  <wsdl:message name="GetDataRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDataResponse">
    <wsdl:part name="parameters" element="tns:GetDataResponse" />
  </wsdl:message>
  <wsdl:message name="GetDataResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Dashboard">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Dashboard</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultDashboard">
      <wsdl:documentation>
        <summary>Loading default values into a new Dashboard.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/CreateDefaultDashboard" name="CreateDefaultDashboardRequest" message="tns:CreateDefaultDashboardRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/CreateDefaultDashboardResponse" name="CreateDefaultDashboardResponse" message="tns:CreateDefaultDashboardResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveDashboard">
      <wsdl:documentation>
        <summary>Updates the existing Dashboard or creates a new Dashboard if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/SaveDashboard" name="SaveDashboardRequest" message="tns:SaveDashboardRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/SaveDashboardResponse" name="SaveDashboardResponse" message="tns:SaveDashboardResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteDashboard">
      <wsdl:documentation>
        <summary>Deletes the Dashboard</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/DeleteDashboard" name="DeleteDashboardRequest" message="tns:DeleteDashboardRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/DeleteDashboardResponse" name="DeleteDashboardResponse" message="tns:DeleteDashboardResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultDashboardTile">
      <wsdl:documentation>
        <summary>Loading default values into a new DashboardTile.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/CreateDefaultDashboardTile" name="CreateDefaultDashboardTileRequest" message="tns:CreateDefaultDashboardTileRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/CreateDefaultDashboardTileResponse" name="CreateDefaultDashboardTileResponse" message="tns:CreateDefaultDashboardTileResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveDashboardTile">
      <wsdl:documentation>
        <summary>Updates the existing DashboardTile or creates a new DashboardTile if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/SaveDashboardTile" name="SaveDashboardTileRequest" message="tns:SaveDashboardTileRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/SaveDashboardTileResponse" name="SaveDashboardTileResponse" message="tns:SaveDashboardTileResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteDashboardTile">
      <wsdl:documentation>
        <summary>Deletes the DashboardTile</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/DeleteDashboardTile" name="DeleteDashboardTileRequest" message="tns:DeleteDashboardTileRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/DeleteDashboardTileResponse" name="DeleteDashboardTileResponse" message="tns:DeleteDashboardTileResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDashboard">
      <wsdl:documentation>
        <summary>Gets a Dashboard object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/GetDashboard" name="GetDashboardRequest" message="tns:GetDashboardRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/GetDashboardResponse" name="GetDashboardResponse" message="tns:GetDashboardResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDashboards">
      <wsdl:documentation>
        <summary>Gets all dashboards for an associate</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/GetDashboards" name="GetDashboardsRequest" message="tns:GetDashboardsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/GetDashboardsResponse" name="GetDashboardsResponse" message="tns:GetDashboardsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDashboardTile">
      <wsdl:documentation>
        <summary>Gets a DashboardTile object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/GetDashboardTile" name="GetDashboardTileRequest" message="tns:GetDashboardTileRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/GetDashboardTileResponse" name="GetDashboardTileResponse" message="tns:GetDashboardTileResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetData">
      <wsdl:documentation>
        <summary>Get data for this tile</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/GetData" name="GetDataRequest" message="tns:GetDataRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/GetDataResponse" name="GetDataResponse" message="tns:GetDataResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Dashboard" type="tns:Dashboard">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultDashboard">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/CreateDefaultDashboard" style="document" />
      <wsdl:input name="CreateDefaultDashboardRequest">
        <soap:header message="tns:CreateDefaultDashboardRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultDashboardRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultDashboardRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultDashboardResponse">
        <soap:header message="tns:CreateDefaultDashboardResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDashboardResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDashboardResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultDashboardResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveDashboard">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/SaveDashboard" style="document" />
      <wsdl:input name="SaveDashboardRequest">
        <soap:header message="tns:SaveDashboardRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveDashboardRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveDashboardRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveDashboardResponse">
        <soap:header message="tns:SaveDashboardResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveDashboardResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveDashboardResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveDashboardResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteDashboard">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/DeleteDashboard" style="document" />
      <wsdl:input name="DeleteDashboardRequest">
        <soap:header message="tns:DeleteDashboardRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteDashboardRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteDashboardRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteDashboardResponse">
        <soap:header message="tns:DeleteDashboardResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteDashboardResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteDashboardResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteDashboardResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultDashboardTile">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/CreateDefaultDashboardTile" style="document" />
      <wsdl:input name="CreateDefaultDashboardTileRequest">
        <soap:header message="tns:CreateDefaultDashboardTileRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultDashboardTileRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultDashboardTileRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultDashboardTileResponse">
        <soap:header message="tns:CreateDefaultDashboardTileResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDashboardTileResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDashboardTileResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultDashboardTileResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveDashboardTile">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/SaveDashboardTile" style="document" />
      <wsdl:input name="SaveDashboardTileRequest">
        <soap:header message="tns:SaveDashboardTileRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveDashboardTileRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveDashboardTileRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveDashboardTileResponse">
        <soap:header message="tns:SaveDashboardTileResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveDashboardTileResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveDashboardTileResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveDashboardTileResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteDashboardTile">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/DeleteDashboardTile" style="document" />
      <wsdl:input name="DeleteDashboardTileRequest">
        <soap:header message="tns:DeleteDashboardTileRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteDashboardTileRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteDashboardTileRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteDashboardTileResponse">
        <soap:header message="tns:DeleteDashboardTileResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteDashboardTileResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteDashboardTileResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteDashboardTileResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDashboard">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/GetDashboard" style="document" />
      <wsdl:input name="GetDashboardRequest">
        <soap:header message="tns:GetDashboardRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDashboardRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDashboardRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDashboardResponse">
        <soap:header message="tns:GetDashboardResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDashboardResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDashboardResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDashboardResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDashboards">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/GetDashboards" style="document" />
      <wsdl:input name="GetDashboardsRequest">
        <soap:header message="tns:GetDashboardsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDashboardsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDashboardsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDashboardsResponse">
        <soap:header message="tns:GetDashboardsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDashboardsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDashboardsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDashboardsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDashboardTile">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/GetDashboardTile" style="document" />
      <wsdl:input name="GetDashboardTileRequest">
        <soap:header message="tns:GetDashboardTileRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDashboardTileRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDashboardTileRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDashboardTileResponse">
        <soap:header message="tns:GetDashboardTileResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDashboardTileResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDashboardTileResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDashboardTileResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetData">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Dashboard/GetData" style="document" />
      <wsdl:input name="GetDataRequest">
        <soap:header message="tns:GetDataRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDataRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDataRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDataResponse">
        <soap:header message="tns:GetDataResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDataResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDataResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDataResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfDashboardService">
    <wsdl:port name="BasicHttpBinding_Dashboard" binding="tns:BasicHttpBinding_Dashboard">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services81/Dashboard.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

