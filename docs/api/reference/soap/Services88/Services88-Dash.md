---
generated: 1
uid: wsdl-Services88-Dash
title: Services88.DashAgent WSDL
---

# Services88.DashAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfDashService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultDash">
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
      <xs:element name="CreateDefaultDashResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Dash" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Dash">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="DashboardId" type="xs:int" />
              <xs:element minOccurs="0" name="UniqueId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Columns" type="xs:int" />
              <xs:element minOccurs="0" name="Theme" nillable="true" type="tns:DashTheme" />
              <xs:element minOccurs="0" name="VisibleForAll" type="xs:short" />
              <xs:element minOccurs="0" name="VisibleForAssociates" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="VisibleForGroups" nillable="true" type="q2:ArrayOfint" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="PinForAll" type="xs:short" />
              <xs:element minOccurs="0" name="PinForAssociates" nillable="true" type="q3:ArrayOfint" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="PinForGroups" nillable="true" type="q4:ArrayOfint" xmlns:q4="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Dash" nillable="true" type="tns:Dash" />
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
      <xs:complexType name="DashTheme">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="DashboardThemeId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Config" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Client" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Style" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DashTheme" nillable="true" type="tns:DashTheme" />
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
      <xs:element name="SaveDash">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Dash" nillable="true" type="tns:Dash" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDashResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Dash" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDash">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDashResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultDashCollection">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultDashCollectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashCollection" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="DashCollection">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Pinned" nillable="true" type="tns:ArrayOfDash" />
              <xs:element minOccurs="0" name="Favourites" nillable="true" type="tns:ArrayOfDash" />
              <xs:element minOccurs="0" name="Other" nillable="true" type="tns:ArrayOfDash" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DashCollection" nillable="true" type="tns:DashCollection" />
      <xs:complexType name="ArrayOfDash">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Dash" nillable="true" type="tns:Dash" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDash" nillable="true" type="tns:ArrayOfDash" />
      <xs:element name="CreateDefaultDashTheme">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultDashThemeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashTheme" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDashTheme">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashTheme" nillable="true" type="tns:DashTheme" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDashThemeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashTheme" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDashTheme">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashThemeId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDashThemeResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultDashTile">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultDashTileResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashTile" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="DashTile">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="DashboardTileId" type="xs:int" />
              <xs:element minOccurs="0" name="DashboardId" type="xs:int" />
              <xs:element minOccurs="0" name="Height" type="xs:int" />
              <xs:element minOccurs="0" name="Width" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="DashTileDefinition" nillable="true" type="tns:DashTileDefinition" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DashTile" nillable="true" type="tns:DashTile" />
      <xs:complexType name="DashTileDefinition">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="DashboardTileDefinitionId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DefaultHeight" type="xs:int" />
              <xs:element minOccurs="0" name="DefaultWidth" type="xs:int" />
              <xs:element minOccurs="0" name="TileType" type="tns:DashTileType" />
              <xs:element minOccurs="0" name="EntityType" type="tns:DashTileEntityType" />
              <xs:element minOccurs="0" name="EntityName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
              <xs:element minOccurs="0" name="CurrencyMode" type="tns:DashTileCurrencyMode" />
              <xs:element minOccurs="0" name="CurrencyCode" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Measure" type="tns:DashTileMeasure" />
              <xs:element minOccurs="0" name="MeasureField" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SortBy" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="LayoutConfig" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SecondarySelectionId" type="xs:int" />
              <xs:element minOccurs="0" name="MeasureByField" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DashTileDefinition" nillable="true" type="tns:DashTileDefinition" />
      <xs:simpleType name="DashTileType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Pie" />
          <xs:enumeration value="List" />
          <xs:enumeration value="BigNum" />
          <xs:enumeration value="Bar" />
          <xs:enumeration value="Line" />
          <xs:enumeration value="Area" />
          <xs:enumeration value="Column" />
          <xs:enumeration value="CombinedBarLine" />
          <xs:enumeration value="CombinedColumnLine" />
          <xs:enumeration value="WebPanel" />
          <xs:enumeration value="HTML" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="DashTileType" nillable="true" type="tns:DashTileType" />
      <xs:simpleType name="DashTileEntityType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Contact" />
          <xs:enumeration value="Sale" />
          <xs:enumeration value="Project" />
          <xs:enumeration value="Appointment" />
          <xs:enumeration value="Person" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="DashTileEntityType" nillable="true" type="tns:DashTileEntityType" />
      <xs:simpleType name="DashTileCurrencyMode">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Base" />
          <xs:enumeration value="Own" />
          <xs:enumeration value="Specified" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="DashTileCurrencyMode" nillable="true" type="tns:DashTileCurrencyMode" />
      <xs:simpleType name="DashTileMeasure">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="CountAll" />
          <xs:enumeration value="Sum" />
          <xs:enumeration value="Average" />
          <xs:enumeration value="Max" />
          <xs:enumeration value="Min" />
          <xs:enumeration value="Count" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="DashTileMeasure" nillable="true" type="tns:DashTileMeasure" />
      <xs:element name="SaveDashTile">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashTile" nillable="true" type="tns:DashTile" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDashTileResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashTile" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDashTile">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashTileId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDashTileResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultDashTileDefinition">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultDashTileDefinitionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashTileDefinition" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDashTileDefinition">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashTileDefinition" nillable="true" type="tns:DashTileDefinition" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDashTileDefinitionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashTileDefinition" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDashTileDefinition">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashTileDefinitionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDashTileDefinitionResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDash">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Dash" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddTileToDashboard">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashboardId" type="xs:int" />
            <xs:element minOccurs="0" name="DashTileDefinitionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddTileToDashboardResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashTile" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddNewTileToDashboard">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashboardId" type="xs:int" />
            <xs:element minOccurs="0" name="DashTileDefinition" nillable="true" type="tns:DashTileDefinition" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddNewTileToDashboardResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashTile" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DuplicateDashboard">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashboardId" type="xs:int" />
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DuplicateDashboardResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Dash" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Dashboards" nillable="true" type="q5:ArrayOfint" xmlns:q5="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDash" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashCollection">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashCollectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashCollection" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashTheme">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashThemeId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashThemeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashTheme" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashTile">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashTileId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashTileResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashTile" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashTiles">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashboardId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashTilesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDashTile" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDashTile">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DashTile" nillable="true" type="tns:DashTile" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDashTile" nillable="true" type="tns:ArrayOfDashTile" />
      <xs:element name="SaveDashTiles">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashboardId" type="xs:int" />
            <xs:element minOccurs="0" name="DashTiles" nillable="true" type="tns:ArrayOfDashTile" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDashTilesResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDashTileSelectionFromEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EntityName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDashTileSelectionFromEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopyTileSelection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopyTileSelectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTempTileSelection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTempTileSelectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSecondaryTempTileSelection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSecondaryTempTileSelectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTileForEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EntityName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTileForEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashTile" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DuplicateTile">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashTileId" type="xs:int" />
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DuplicateTileResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashTile" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashTileDefinition">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashTileDefinitionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashTileDefinitionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashTileDefinition" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTileDefinitionForEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EntityName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTileDefinitionForEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashTileDefinition" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashTileHtml">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashboardTileDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="LanguageCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashTileHtmlResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DashTileHtml" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="DashTileHtml">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="LanguageCode" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Html" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DashTileHtml" nillable="true" type="tns:DashTileHtml" />
      <xs:element name="GetDashTileHtmlList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashboardTileDefinitionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDashTileHtmlListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDashTileHtml" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDashTileHtml">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DashTileHtml" nillable="true" type="tns:DashTileHtml" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDashTileHtml" nillable="true" type="tns:ArrayOfDashTileHtml" />
      <xs:element name="SaveDashTileHtmlList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DashboardTileDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="Languages" nillable="true" type="tns:ArrayOfDashTileHtml" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDashTileHtmlListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDashTileHtml" />
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
  <wsdl:message name="CreateDefaultDashRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultDash" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultDashResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDashRequest">
    <wsdl:part name="parameters" element="tns:SaveDash" />
  </wsdl:message>
  <wsdl:message name="SaveDashRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDashResponse">
    <wsdl:part name="parameters" element="tns:SaveDashResponse" />
  </wsdl:message>
  <wsdl:message name="SaveDashResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDashRequest">
    <wsdl:part name="parameters" element="tns:DeleteDash" />
  </wsdl:message>
  <wsdl:message name="DeleteDashRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDashResponse">
    <wsdl:part name="parameters" element="tns:DeleteDashResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteDashResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashCollectionRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultDashCollection" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashCollectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashCollectionResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultDashCollectionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashCollectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashThemeRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultDashTheme" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashThemeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashThemeResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultDashThemeResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashThemeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDashThemeRequest">
    <wsdl:part name="parameters" element="tns:SaveDashTheme" />
  </wsdl:message>
  <wsdl:message name="SaveDashThemeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDashThemeResponse">
    <wsdl:part name="parameters" element="tns:SaveDashThemeResponse" />
  </wsdl:message>
  <wsdl:message name="SaveDashThemeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDashThemeRequest">
    <wsdl:part name="parameters" element="tns:DeleteDashTheme" />
  </wsdl:message>
  <wsdl:message name="DeleteDashThemeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDashThemeResponse">
    <wsdl:part name="parameters" element="tns:DeleteDashThemeResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteDashThemeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashTileRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultDashTile" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashTileRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashTileResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultDashTileResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashTileResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDashTileRequest">
    <wsdl:part name="parameters" element="tns:SaveDashTile" />
  </wsdl:message>
  <wsdl:message name="SaveDashTileRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDashTileResponse">
    <wsdl:part name="parameters" element="tns:SaveDashTileResponse" />
  </wsdl:message>
  <wsdl:message name="SaveDashTileResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDashTileRequest">
    <wsdl:part name="parameters" element="tns:DeleteDashTile" />
  </wsdl:message>
  <wsdl:message name="DeleteDashTileRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDashTileResponse">
    <wsdl:part name="parameters" element="tns:DeleteDashTileResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteDashTileResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashTileDefinitionRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultDashTileDefinition" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashTileDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashTileDefinitionResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultDashTileDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDashTileDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDashTileDefinitionRequest">
    <wsdl:part name="parameters" element="tns:SaveDashTileDefinition" />
  </wsdl:message>
  <wsdl:message name="SaveDashTileDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDashTileDefinitionResponse">
    <wsdl:part name="parameters" element="tns:SaveDashTileDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="SaveDashTileDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDashTileDefinitionRequest">
    <wsdl:part name="parameters" element="tns:DeleteDashTileDefinition" />
  </wsdl:message>
  <wsdl:message name="DeleteDashTileDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDashTileDefinitionResponse">
    <wsdl:part name="parameters" element="tns:DeleteDashTileDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteDashTileDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashRequest">
    <wsdl:part name="parameters" element="tns:GetDash" />
  </wsdl:message>
  <wsdl:message name="GetDashRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashResponse">
    <wsdl:part name="parameters" element="tns:GetDashResponse" />
  </wsdl:message>
  <wsdl:message name="GetDashResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddTileToDashboardRequest">
    <wsdl:part name="parameters" element="tns:AddTileToDashboard" />
  </wsdl:message>
  <wsdl:message name="AddTileToDashboardRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddTileToDashboardResponse">
    <wsdl:part name="parameters" element="tns:AddTileToDashboardResponse" />
  </wsdl:message>
  <wsdl:message name="AddTileToDashboardResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddNewTileToDashboardRequest">
    <wsdl:part name="parameters" element="tns:AddNewTileToDashboard" />
  </wsdl:message>
  <wsdl:message name="AddNewTileToDashboardRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddNewTileToDashboardResponse">
    <wsdl:part name="parameters" element="tns:AddNewTileToDashboardResponse" />
  </wsdl:message>
  <wsdl:message name="AddNewTileToDashboardResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DuplicateDashboardRequest">
    <wsdl:part name="parameters" element="tns:DuplicateDashboard" />
  </wsdl:message>
  <wsdl:message name="DuplicateDashboardRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DuplicateDashboardResponse">
    <wsdl:part name="parameters" element="tns:DuplicateDashboardResponse" />
  </wsdl:message>
  <wsdl:message name="DuplicateDashboardResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashListRequest">
    <wsdl:part name="parameters" element="tns:GetDashList" />
  </wsdl:message>
  <wsdl:message name="GetDashListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashListResponse">
    <wsdl:part name="parameters" element="tns:GetDashListResponse" />
  </wsdl:message>
  <wsdl:message name="GetDashListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashCollectionRequest">
    <wsdl:part name="parameters" element="tns:GetDashCollection" />
  </wsdl:message>
  <wsdl:message name="GetDashCollectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashCollectionResponse">
    <wsdl:part name="parameters" element="tns:GetDashCollectionResponse" />
  </wsdl:message>
  <wsdl:message name="GetDashCollectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashThemeRequest">
    <wsdl:part name="parameters" element="tns:GetDashTheme" />
  </wsdl:message>
  <wsdl:message name="GetDashThemeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashThemeResponse">
    <wsdl:part name="parameters" element="tns:GetDashThemeResponse" />
  </wsdl:message>
  <wsdl:message name="GetDashThemeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashTileRequest">
    <wsdl:part name="parameters" element="tns:GetDashTile" />
  </wsdl:message>
  <wsdl:message name="GetDashTileRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashTileResponse">
    <wsdl:part name="parameters" element="tns:GetDashTileResponse" />
  </wsdl:message>
  <wsdl:message name="GetDashTileResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashTilesRequest">
    <wsdl:part name="parameters" element="tns:GetDashTiles" />
  </wsdl:message>
  <wsdl:message name="GetDashTilesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashTilesResponse">
    <wsdl:part name="parameters" element="tns:GetDashTilesResponse" />
  </wsdl:message>
  <wsdl:message name="GetDashTilesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDashTilesRequest">
    <wsdl:part name="parameters" element="tns:SaveDashTiles" />
  </wsdl:message>
  <wsdl:message name="SaveDashTilesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDashTilesResponse">
    <wsdl:part name="parameters" element="tns:SaveDashTilesResponse" />
  </wsdl:message>
  <wsdl:message name="SaveDashTilesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDashTileSelectionFromEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDashTileSelectionFromEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDashTileSelectionFromEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDashTileSelectionFromEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDashTileSelectionFromEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDashTileSelectionFromEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopyTileSelectionRequest">
    <wsdl:part name="parameters" element="tns:CopyTileSelection" />
  </wsdl:message>
  <wsdl:message name="CopyTileSelectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopyTileSelectionResponse">
    <wsdl:part name="parameters" element="tns:CopyTileSelectionResponse" />
  </wsdl:message>
  <wsdl:message name="CopyTileSelectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTempTileSelectionRequest">
    <wsdl:part name="parameters" element="tns:GetTempTileSelection" />
  </wsdl:message>
  <wsdl:message name="GetTempTileSelectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTempTileSelectionResponse">
    <wsdl:part name="parameters" element="tns:GetTempTileSelectionResponse" />
  </wsdl:message>
  <wsdl:message name="GetTempTileSelectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSecondaryTempTileSelectionRequest">
    <wsdl:part name="parameters" element="tns:GetSecondaryTempTileSelection" />
  </wsdl:message>
  <wsdl:message name="GetSecondaryTempTileSelectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSecondaryTempTileSelectionResponse">
    <wsdl:part name="parameters" element="tns:GetSecondaryTempTileSelectionResponse" />
  </wsdl:message>
  <wsdl:message name="GetSecondaryTempTileSelectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTileForEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTileForEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTileForEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTileForEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTileForEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTileForEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DuplicateTileRequest">
    <wsdl:part name="parameters" element="tns:DuplicateTile" />
  </wsdl:message>
  <wsdl:message name="DuplicateTileRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DuplicateTileResponse">
    <wsdl:part name="parameters" element="tns:DuplicateTileResponse" />
  </wsdl:message>
  <wsdl:message name="DuplicateTileResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashTileDefinitionRequest">
    <wsdl:part name="parameters" element="tns:GetDashTileDefinition" />
  </wsdl:message>
  <wsdl:message name="GetDashTileDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashTileDefinitionResponse">
    <wsdl:part name="parameters" element="tns:GetDashTileDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="GetDashTileDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTileDefinitionForEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTileDefinitionForEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTileDefinitionForEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTileDefinitionForEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTileDefinitionForEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTileDefinitionForEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashTileHtmlRequest">
    <wsdl:part name="parameters" element="tns:GetDashTileHtml" />
  </wsdl:message>
  <wsdl:message name="GetDashTileHtmlRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashTileHtmlResponse">
    <wsdl:part name="parameters" element="tns:GetDashTileHtmlResponse" />
  </wsdl:message>
  <wsdl:message name="GetDashTileHtmlResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashTileHtmlListRequest">
    <wsdl:part name="parameters" element="tns:GetDashTileHtmlList" />
  </wsdl:message>
  <wsdl:message name="GetDashTileHtmlListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDashTileHtmlListResponse">
    <wsdl:part name="parameters" element="tns:GetDashTileHtmlListResponse" />
  </wsdl:message>
  <wsdl:message name="GetDashTileHtmlListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDashTileHtmlListRequest">
    <wsdl:part name="parameters" element="tns:SaveDashTileHtmlList" />
  </wsdl:message>
  <wsdl:message name="SaveDashTileHtmlListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDashTileHtmlListResponse">
    <wsdl:part name="parameters" element="tns:SaveDashTileHtmlListResponse" />
  </wsdl:message>
  <wsdl:message name="SaveDashTileHtmlListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Dash">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Dash</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultDash">
      <wsdl:documentation>
        <summary>Loading default values into a new Dash.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultDash" name="CreateDefaultDashRequest" message="tns:CreateDefaultDashRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultDashResponse" name="CreateDefaultDashResponse" message="tns:CreateDefaultDashResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveDash">
      <wsdl:documentation>
        <summary>Updates the existing Dash or creates a new Dash if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/SaveDash" name="SaveDashRequest" message="tns:SaveDashRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/SaveDashResponse" name="SaveDashResponse" message="tns:SaveDashResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteDash">
      <wsdl:documentation>
        <summary>Deletes the Dash</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/DeleteDash" name="DeleteDashRequest" message="tns:DeleteDashRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/DeleteDashResponse" name="DeleteDashResponse" message="tns:DeleteDashResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultDashCollection">
      <wsdl:documentation>
        <summary>Loading default values into a new DashCollection.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultDashCollection" name="CreateDefaultDashCollectionRequest" message="tns:CreateDefaultDashCollectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultDashCollectionResponse" name="CreateDefaultDashCollectionResponse" message="tns:CreateDefaultDashCollectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultDashTheme">
      <wsdl:documentation>
        <summary>Loading default values into a new DashTheme.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultDashTheme" name="CreateDefaultDashThemeRequest" message="tns:CreateDefaultDashThemeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultDashThemeResponse" name="CreateDefaultDashThemeResponse" message="tns:CreateDefaultDashThemeResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveDashTheme">
      <wsdl:documentation>
        <summary>Updates the existing DashTheme or creates a new DashTheme if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/SaveDashTheme" name="SaveDashThemeRequest" message="tns:SaveDashThemeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/SaveDashThemeResponse" name="SaveDashThemeResponse" message="tns:SaveDashThemeResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteDashTheme">
      <wsdl:documentation>
        <summary>Deletes the DashTheme</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/DeleteDashTheme" name="DeleteDashThemeRequest" message="tns:DeleteDashThemeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/DeleteDashThemeResponse" name="DeleteDashThemeResponse" message="tns:DeleteDashThemeResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultDashTile">
      <wsdl:documentation>
        <summary>Loading default values into a new DashTile.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultDashTile" name="CreateDefaultDashTileRequest" message="tns:CreateDefaultDashTileRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultDashTileResponse" name="CreateDefaultDashTileResponse" message="tns:CreateDefaultDashTileResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveDashTile">
      <wsdl:documentation>
        <summary>Updates the existing DashTile or creates a new DashTile if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/SaveDashTile" name="SaveDashTileRequest" message="tns:SaveDashTileRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/SaveDashTileResponse" name="SaveDashTileResponse" message="tns:SaveDashTileResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteDashTile">
      <wsdl:documentation>
        <summary>Deletes the DashTile</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/DeleteDashTile" name="DeleteDashTileRequest" message="tns:DeleteDashTileRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/DeleteDashTileResponse" name="DeleteDashTileResponse" message="tns:DeleteDashTileResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultDashTileDefinition">
      <wsdl:documentation>
        <summary>Loading default values into a new DashTileDefinition.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultDashTileDefinition" name="CreateDefaultDashTileDefinitionRequest" message="tns:CreateDefaultDashTileDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultDashTileDefinitionResponse" name="CreateDefaultDashTileDefinitionResponse" message="tns:CreateDefaultDashTileDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveDashTileDefinition">
      <wsdl:documentation>
        <summary>Updates the existing DashTileDefinition or creates a new DashTileDefinition if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/SaveDashTileDefinition" name="SaveDashTileDefinitionRequest" message="tns:SaveDashTileDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/SaveDashTileDefinitionResponse" name="SaveDashTileDefinitionResponse" message="tns:SaveDashTileDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteDashTileDefinition">
      <wsdl:documentation>
        <summary>Deletes the DashTileDefinition</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/DeleteDashTileDefinition" name="DeleteDashTileDefinitionRequest" message="tns:DeleteDashTileDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/DeleteDashTileDefinitionResponse" name="DeleteDashTileDefinitionResponse" message="tns:DeleteDashTileDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDash">
      <wsdl:documentation>
        <summary>Gets a Dash object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDash" name="GetDashRequest" message="tns:GetDashRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashResponse" name="GetDashResponse" message="tns:GetDashResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddTileToDashboard">
      <wsdl:documentation>
        <summary>Add a tile to a dashboard with next rank</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/AddTileToDashboard" name="AddTileToDashboardRequest" message="tns:AddTileToDashboardRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/AddTileToDashboardResponse" name="AddTileToDashboardResponse" message="tns:AddTileToDashboardResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddNewTileToDashboard">
      <wsdl:documentation>
        <summary>Add a new tile to a dashboard with next rank</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/AddNewTileToDashboard" name="AddNewTileToDashboardRequest" message="tns:AddNewTileToDashboardRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/AddNewTileToDashboardResponse" name="AddNewTileToDashboardResponse" message="tns:AddNewTileToDashboardResponse" />
    </wsdl:operation>
    <wsdl:operation name="DuplicateDashboard">
      <wsdl:documentation>
        <summary>Duplicate for the dashboard and all the sub elements</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/DuplicateDashboard" name="DuplicateDashboardRequest" message="tns:DuplicateDashboardRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/DuplicateDashboardResponse" name="DuplicateDashboardResponse" message="tns:DuplicateDashboardResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDashList">
      <wsdl:documentation>
        <summary>Gets the ordered list of dashboards</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashList" name="GetDashListRequest" message="tns:GetDashListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashListResponse" name="GetDashListResponse" message="tns:GetDashListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDashCollection">
      <wsdl:documentation>
        <summary>Gets a collection of dashboards for the current associate</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashCollection" name="GetDashCollectionRequest" message="tns:GetDashCollectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashCollectionResponse" name="GetDashCollectionResponse" message="tns:GetDashCollectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDashTheme">
      <wsdl:documentation>
        <summary>Gets a DashTheme object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashTheme" name="GetDashThemeRequest" message="tns:GetDashThemeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashThemeResponse" name="GetDashThemeResponse" message="tns:GetDashThemeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDashTile">
      <wsdl:documentation>
        <summary>Gets a DashTile object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashTile" name="GetDashTileRequest" message="tns:GetDashTileRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashTileResponse" name="GetDashTileResponse" message="tns:GetDashTileResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDashTiles">
      <wsdl:documentation>
        <summary>Gets the ordered list of tiles for a dashboard</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashTiles" name="GetDashTilesRequest" message="tns:GetDashTilesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashTilesResponse" name="GetDashTilesResponse" message="tns:GetDashTilesResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveDashTiles">
      <wsdl:documentation>
        <summary>Saves the ordered list of tiles for a dashboard</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/SaveDashTiles" name="SaveDashTilesRequest" message="tns:SaveDashTilesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/SaveDashTilesResponse" name="SaveDashTilesResponse" message="tns:SaveDashTilesResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDashTileSelectionFromEntity">
      <wsdl:documentation>
        <summary>Returns the id to a dashboard tile selection</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDashTileSelectionFromEntity" name="CreateDashTileSelectionFromEntityRequest" message="tns:CreateDashTileSelectionFromEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDashTileSelectionFromEntityResponse" name="CreateDashTileSelectionFromEntityResponse" message="tns:CreateDashTileSelectionFromEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CopyTileSelection">
      <wsdl:documentation>
        <summary>Copy Tile Selection for the dashboard</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CopyTileSelection" name="CopyTileSelectionRequest" message="tns:CopyTileSelectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CopyTileSelectionResponse" name="CopyTileSelectionResponse" message="tns:CopyTileSelectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTempTileSelection">
      <wsdl:documentation>
        <summary>Copy selection to temporary personal tile selection</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetTempTileSelection" name="GetTempTileSelectionRequest" message="tns:GetTempTileSelectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetTempTileSelectionResponse" name="GetTempTileSelectionResponse" message="tns:GetTempTileSelectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSecondaryTempTileSelection">
      <wsdl:documentation>
        <summary>Copy selection to secondary temporary personal tile selection</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetSecondaryTempTileSelection" name="GetSecondaryTempTileSelectionRequest" message="tns:GetSecondaryTempTileSelectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetSecondaryTempTileSelectionResponse" name="GetSecondaryTempTileSelectionResponse" message="tns:GetSecondaryTempTileSelectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTileForEntity">
      <wsdl:documentation>
        <summary>Set Measure to CountAll and MeasureField to primary key field</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultTileForEntity" name="CreateDefaultTileForEntityRequest" message="tns:CreateDefaultTileForEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultTileForEntityResponse" name="CreateDefaultTileForEntityResponse" message="tns:CreateDefaultTileForEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DuplicateTile">
      <wsdl:documentation>
        <summary>Duplicate for the tile and all the sub elements</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/DuplicateTile" name="DuplicateTileRequest" message="tns:DuplicateTileRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/DuplicateTileResponse" name="DuplicateTileResponse" message="tns:DuplicateTileResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDashTileDefinition">
      <wsdl:documentation>
        <summary>Gets a DashTileDefinition object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashTileDefinition" name="GetDashTileDefinitionRequest" message="tns:GetDashTileDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashTileDefinitionResponse" name="GetDashTileDefinitionResponse" message="tns:GetDashTileDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTileDefinitionForEntity">
      <wsdl:documentation>
        <summary>Set Measure to CountAll and MeasureField to primary key field</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultTileDefinitionForEntity" name="CreateDefaultTileDefinitionForEntityRequest" message="tns:CreateDefaultTileDefinitionForEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultTileDefinitionForEntityResponse" name="CreateDefaultTileDefinitionForEntityResponse" message="tns:CreateDefaultTileDefinitionForEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDashTileHtml">
      <wsdl:documentation>
        <summary>Get HTML for a dashboard tile definition with TileType = HTML</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashTileHtml" name="GetDashTileHtmlRequest" message="tns:GetDashTileHtmlRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashTileHtmlResponse" name="GetDashTileHtmlResponse" message="tns:GetDashTileHtmlResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDashTileHtmlList">
      <wsdl:documentation>
        <summary>Get HTML for a dashboard tile definition with TileType = HTML. Retrieve a list with all registered languages.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashTileHtmlList" name="GetDashTileHtmlListRequest" message="tns:GetDashTileHtmlListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashTileHtmlListResponse" name="GetDashTileHtmlListResponse" message="tns:GetDashTileHtmlListResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveDashTileHtmlList">
      <wsdl:documentation>
        <summary>Set the HTML data for a tile with TileType = HTML.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/SaveDashTileHtmlList" name="SaveDashTileHtmlListRequest" message="tns:SaveDashTileHtmlListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/SaveDashTileHtmlListResponse" name="SaveDashTileHtmlListResponse" message="tns:SaveDashTileHtmlListResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Dash" type="tns:Dash">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultDash">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultDash" style="document" />
      <wsdl:input name="CreateDefaultDashRequest">
        <soap:header message="tns:CreateDefaultDashRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultDashRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultDashRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultDashResponse">
        <soap:header message="tns:CreateDefaultDashResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDashResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDashResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultDashResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveDash">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/SaveDash" style="document" />
      <wsdl:input name="SaveDashRequest">
        <soap:header message="tns:SaveDashRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveDashRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveDashRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveDashResponse">
        <soap:header message="tns:SaveDashResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveDashResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveDashResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveDashResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteDash">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/DeleteDash" style="document" />
      <wsdl:input name="DeleteDashRequest">
        <soap:header message="tns:DeleteDashRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteDashRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteDashRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteDashResponse">
        <soap:header message="tns:DeleteDashResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteDashResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteDashResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteDashResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultDashCollection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultDashCollection" style="document" />
      <wsdl:input name="CreateDefaultDashCollectionRequest">
        <soap:header message="tns:CreateDefaultDashCollectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultDashCollectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultDashCollectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultDashCollectionResponse">
        <soap:header message="tns:CreateDefaultDashCollectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDashCollectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDashCollectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultDashCollectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultDashTheme">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultDashTheme" style="document" />
      <wsdl:input name="CreateDefaultDashThemeRequest">
        <soap:header message="tns:CreateDefaultDashThemeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultDashThemeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultDashThemeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultDashThemeResponse">
        <soap:header message="tns:CreateDefaultDashThemeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDashThemeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDashThemeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultDashThemeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveDashTheme">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/SaveDashTheme" style="document" />
      <wsdl:input name="SaveDashThemeRequest">
        <soap:header message="tns:SaveDashThemeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveDashThemeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveDashThemeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveDashThemeResponse">
        <soap:header message="tns:SaveDashThemeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveDashThemeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveDashThemeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveDashThemeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteDashTheme">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/DeleteDashTheme" style="document" />
      <wsdl:input name="DeleteDashThemeRequest">
        <soap:header message="tns:DeleteDashThemeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteDashThemeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteDashThemeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteDashThemeResponse">
        <soap:header message="tns:DeleteDashThemeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteDashThemeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteDashThemeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteDashThemeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultDashTile">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultDashTile" style="document" />
      <wsdl:input name="CreateDefaultDashTileRequest">
        <soap:header message="tns:CreateDefaultDashTileRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultDashTileRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultDashTileRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultDashTileResponse">
        <soap:header message="tns:CreateDefaultDashTileResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDashTileResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDashTileResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultDashTileResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveDashTile">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/SaveDashTile" style="document" />
      <wsdl:input name="SaveDashTileRequest">
        <soap:header message="tns:SaveDashTileRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveDashTileRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveDashTileRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveDashTileResponse">
        <soap:header message="tns:SaveDashTileResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveDashTileResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveDashTileResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveDashTileResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteDashTile">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/DeleteDashTile" style="document" />
      <wsdl:input name="DeleteDashTileRequest">
        <soap:header message="tns:DeleteDashTileRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteDashTileRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteDashTileRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteDashTileResponse">
        <soap:header message="tns:DeleteDashTileResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteDashTileResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteDashTileResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteDashTileResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultDashTileDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultDashTileDefinition" style="document" />
      <wsdl:input name="CreateDefaultDashTileDefinitionRequest">
        <soap:header message="tns:CreateDefaultDashTileDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultDashTileDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultDashTileDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultDashTileDefinitionResponse">
        <soap:header message="tns:CreateDefaultDashTileDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDashTileDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDashTileDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultDashTileDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveDashTileDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/SaveDashTileDefinition" style="document" />
      <wsdl:input name="SaveDashTileDefinitionRequest">
        <soap:header message="tns:SaveDashTileDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveDashTileDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveDashTileDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveDashTileDefinitionResponse">
        <soap:header message="tns:SaveDashTileDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveDashTileDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveDashTileDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveDashTileDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteDashTileDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/DeleteDashTileDefinition" style="document" />
      <wsdl:input name="DeleteDashTileDefinitionRequest">
        <soap:header message="tns:DeleteDashTileDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteDashTileDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteDashTileDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteDashTileDefinitionResponse">
        <soap:header message="tns:DeleteDashTileDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteDashTileDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteDashTileDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteDashTileDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDash">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDash" style="document" />
      <wsdl:input name="GetDashRequest">
        <soap:header message="tns:GetDashRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDashRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDashRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDashResponse">
        <soap:header message="tns:GetDashResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDashResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDashResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDashResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddTileToDashboard">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/AddTileToDashboard" style="document" />
      <wsdl:input name="AddTileToDashboardRequest">
        <soap:header message="tns:AddTileToDashboardRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddTileToDashboardRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddTileToDashboardRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddTileToDashboardResponse">
        <soap:header message="tns:AddTileToDashboardResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddTileToDashboardResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddTileToDashboardResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddTileToDashboardResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddNewTileToDashboard">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/AddNewTileToDashboard" style="document" />
      <wsdl:input name="AddNewTileToDashboardRequest">
        <soap:header message="tns:AddNewTileToDashboardRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddNewTileToDashboardRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddNewTileToDashboardRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddNewTileToDashboardResponse">
        <soap:header message="tns:AddNewTileToDashboardResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddNewTileToDashboardResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddNewTileToDashboardResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddNewTileToDashboardResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DuplicateDashboard">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/DuplicateDashboard" style="document" />
      <wsdl:input name="DuplicateDashboardRequest">
        <soap:header message="tns:DuplicateDashboardRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DuplicateDashboardRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DuplicateDashboardRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DuplicateDashboardResponse">
        <soap:header message="tns:DuplicateDashboardResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DuplicateDashboardResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DuplicateDashboardResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DuplicateDashboardResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDashList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashList" style="document" />
      <wsdl:input name="GetDashListRequest">
        <soap:header message="tns:GetDashListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDashListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDashListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDashListResponse">
        <soap:header message="tns:GetDashListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDashListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDashListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDashListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDashCollection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashCollection" style="document" />
      <wsdl:input name="GetDashCollectionRequest">
        <soap:header message="tns:GetDashCollectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDashCollectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDashCollectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDashCollectionResponse">
        <soap:header message="tns:GetDashCollectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDashCollectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDashCollectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDashCollectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDashTheme">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashTheme" style="document" />
      <wsdl:input name="GetDashThemeRequest">
        <soap:header message="tns:GetDashThemeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDashThemeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDashThemeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDashThemeResponse">
        <soap:header message="tns:GetDashThemeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDashThemeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDashThemeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDashThemeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDashTile">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashTile" style="document" />
      <wsdl:input name="GetDashTileRequest">
        <soap:header message="tns:GetDashTileRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDashTileRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDashTileRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDashTileResponse">
        <soap:header message="tns:GetDashTileResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDashTileResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDashTileResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDashTileResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDashTiles">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashTiles" style="document" />
      <wsdl:input name="GetDashTilesRequest">
        <soap:header message="tns:GetDashTilesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDashTilesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDashTilesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDashTilesResponse">
        <soap:header message="tns:GetDashTilesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDashTilesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDashTilesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDashTilesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveDashTiles">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/SaveDashTiles" style="document" />
      <wsdl:input name="SaveDashTilesRequest">
        <soap:header message="tns:SaveDashTilesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveDashTilesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveDashTilesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveDashTilesResponse">
        <soap:header message="tns:SaveDashTilesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveDashTilesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveDashTilesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveDashTilesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDashTileSelectionFromEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDashTileSelectionFromEntity" style="document" />
      <wsdl:input name="CreateDashTileSelectionFromEntityRequest">
        <soap:header message="tns:CreateDashTileSelectionFromEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDashTileSelectionFromEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDashTileSelectionFromEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDashTileSelectionFromEntityResponse">
        <soap:header message="tns:CreateDashTileSelectionFromEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDashTileSelectionFromEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDashTileSelectionFromEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDashTileSelectionFromEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CopyTileSelection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CopyTileSelection" style="document" />
      <wsdl:input name="CopyTileSelectionRequest">
        <soap:header message="tns:CopyTileSelectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CopyTileSelectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CopyTileSelectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CopyTileSelectionResponse">
        <soap:header message="tns:CopyTileSelectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CopyTileSelectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CopyTileSelectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CopyTileSelectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTempTileSelection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetTempTileSelection" style="document" />
      <wsdl:input name="GetTempTileSelectionRequest">
        <soap:header message="tns:GetTempTileSelectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTempTileSelectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTempTileSelectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTempTileSelectionResponse">
        <soap:header message="tns:GetTempTileSelectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTempTileSelectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTempTileSelectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTempTileSelectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSecondaryTempTileSelection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetSecondaryTempTileSelection" style="document" />
      <wsdl:input name="GetSecondaryTempTileSelectionRequest">
        <soap:header message="tns:GetSecondaryTempTileSelectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSecondaryTempTileSelectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSecondaryTempTileSelectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSecondaryTempTileSelectionResponse">
        <soap:header message="tns:GetSecondaryTempTileSelectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSecondaryTempTileSelectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSecondaryTempTileSelectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSecondaryTempTileSelectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTileForEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultTileForEntity" style="document" />
      <wsdl:input name="CreateDefaultTileForEntityRequest">
        <soap:header message="tns:CreateDefaultTileForEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTileForEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTileForEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTileForEntityResponse">
        <soap:header message="tns:CreateDefaultTileForEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTileForEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTileForEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTileForEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DuplicateTile">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/DuplicateTile" style="document" />
      <wsdl:input name="DuplicateTileRequest">
        <soap:header message="tns:DuplicateTileRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DuplicateTileRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DuplicateTileRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DuplicateTileResponse">
        <soap:header message="tns:DuplicateTileResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DuplicateTileResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DuplicateTileResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DuplicateTileResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDashTileDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashTileDefinition" style="document" />
      <wsdl:input name="GetDashTileDefinitionRequest">
        <soap:header message="tns:GetDashTileDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDashTileDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDashTileDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDashTileDefinitionResponse">
        <soap:header message="tns:GetDashTileDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDashTileDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDashTileDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDashTileDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTileDefinitionForEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/CreateDefaultTileDefinitionForEntity" style="document" />
      <wsdl:input name="CreateDefaultTileDefinitionForEntityRequest">
        <soap:header message="tns:CreateDefaultTileDefinitionForEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTileDefinitionForEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTileDefinitionForEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTileDefinitionForEntityResponse">
        <soap:header message="tns:CreateDefaultTileDefinitionForEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTileDefinitionForEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTileDefinitionForEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTileDefinitionForEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDashTileHtml">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashTileHtml" style="document" />
      <wsdl:input name="GetDashTileHtmlRequest">
        <soap:header message="tns:GetDashTileHtmlRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDashTileHtmlRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDashTileHtmlRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDashTileHtmlResponse">
        <soap:header message="tns:GetDashTileHtmlResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDashTileHtmlResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDashTileHtmlResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDashTileHtmlResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDashTileHtmlList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/GetDashTileHtmlList" style="document" />
      <wsdl:input name="GetDashTileHtmlListRequest">
        <soap:header message="tns:GetDashTileHtmlListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDashTileHtmlListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDashTileHtmlListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDashTileHtmlListResponse">
        <soap:header message="tns:GetDashTileHtmlListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDashTileHtmlListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDashTileHtmlListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDashTileHtmlListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveDashTileHtmlList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Dash/SaveDashTileHtmlList" style="document" />
      <wsdl:input name="SaveDashTileHtmlListRequest">
        <soap:header message="tns:SaveDashTileHtmlListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveDashTileHtmlListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveDashTileHtmlListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveDashTileHtmlListResponse">
        <soap:header message="tns:SaveDashTileHtmlListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveDashTileHtmlListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveDashTileHtmlListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveDashTileHtmlListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfDashService">
    <wsdl:port name="BasicHttpBinding_Dash" binding="tns:BasicHttpBinding_Dash">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/Dash.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

