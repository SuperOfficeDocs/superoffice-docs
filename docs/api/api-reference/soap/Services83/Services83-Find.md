---
Generated: 1
TOCExclude: 1
title: Services83.FindAgent WSDL
---

# Services83.FindAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfFindService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services83" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services83" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services83" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="GetCriteriaInformation">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StaticColumns" nillable="true" type="q1:ArrayOfstring" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
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
      <xs:element name="GetCriteriaInformationResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CriteriaInformation" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CriteriaInformation">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Restrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
              <xs:element minOccurs="0" name="CriteriaArchiveColumns" nillable="true" type="tns:ArrayOfArchiveColumnInfo" />
              <xs:element minOccurs="0" name="CriteriaArchiveRows" nillable="true" type="tns:ArrayOfArchiveListItem" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CriteriaInformation" nillable="true" type="tns:CriteriaInformation" />
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
          <xs:element minOccurs="0" name="Values" nillable="true" type="q2:ArrayOfstring" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="DisplayValues" nillable="true" type="q3:ArrayOfstring" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="ColumnInfo" nillable="true" type="tns:ArchiveColumnInfo" />
          <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
          <xs:element minOccurs="0" name="SubRestrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
          <xs:element minOccurs="0" name="InterParenthesis" type="xs:int" />
          <xs:element minOccurs="0" name="InterOperator" type="tns:InterRestrictionOperator" />
          <xs:element minOccurs="0" name="UniqueHash" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArchiveRestrictionInfo" nillable="true" type="tns:ArchiveRestrictionInfo" />
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
      <xs:simpleType name="InterRestrictionOperator">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="And" />
          <xs:enumeration value="Or" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="InterRestrictionOperator" nillable="true" type="tns:InterRestrictionOperator" />
      <xs:complexType name="ArrayOfArchiveColumnInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArchiveColumnInfo" nillable="true" type="tns:ArchiveColumnInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArchiveColumnInfo" nillable="true" type="tns:ArrayOfArchiveColumnInfo" />
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
      <xs:element name="GetCriteriaInformationWithContext">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StaticColumns" nillable="true" type="q4:ArrayOfstring" xmlns:q4="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCriteriaInformationWithContextResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CriteriaInformation" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveRestrictions">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveRestrictionsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveRestrictionsWithContext">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveRestrictionsWithContextResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveRestrictionsAndGetCriteriaInformation">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
            <xs:element minOccurs="0" name="StaticColumns" nillable="true" type="q5:ArrayOfstring" xmlns:q5="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveRestrictionsAndGetCriteriaInformationResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CriteriaInformation" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Find">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="PageNumber" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FindResults" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="FindResults">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ArchiveColumns" nillable="true" type="tns:ArrayOfArchiveColumnInfo" />
              <xs:element minOccurs="0" name="ArchiveRows" nillable="true" type="tns:ArrayOfArchiveListItem" />
              <xs:element minOccurs="0" name="RowCount" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="FindResults" nillable="true" type="tns:FindResults" />
      <xs:element name="FindFromRestrictions">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="PageNumber" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindFromRestrictionsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FindResults" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindFromRestrictionsColumns">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DesiredColumns" nillable="true" type="q6:ArrayOfstring" xmlns:q6="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="PageNumber" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindFromRestrictionsColumnsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FindResults" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAvailableRestrictionColumns">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAvailableRestrictionColumnsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q7:ArrayOfstring" xmlns:q7="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSpecifiedCriteriaInformationWithDefaults">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DesiredColumnNames" nillable="true" type="q8:ArrayOfstring" xmlns:q8="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="StaticColumns" nillable="true" type="q9:ArrayOfstring" xmlns:q9="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSpecifiedCriteriaInformationWithDefaultsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CriteriaInformation" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSpecifiedCriteriaInformationWithDefaultsWithContext">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DesiredColumnNames" nillable="true" type="q10:ArrayOfstring" xmlns:q10="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="StaticColumns" nillable="true" type="q11:ArrayOfstring" xmlns:q11="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSpecifiedCriteriaInformationWithDefaultsWithContextResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CriteriaInformation" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindFromRestrictionsColumnsOrderBy">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DesiredColumns" nillable="true" type="q12:ArrayOfstring" xmlns:q12="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="OrderBy" nillable="true" type="tns:ArrayOfArchiveOrderByInfo" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="PageNumber" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
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
      <xs:element name="FindFromRestrictionsColumnsOrderByResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FindResults" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultDesiredColumns">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultDesiredColumnsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfArchiveColumnInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultOrderBy">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultOrderByResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfArchiveOrderByInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="PopulateRestrictions">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="PopulateRestrictionsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultDesiredColumnsFromRestrictions">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultDesiredColumnsFromRestrictionsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfArchiveColumnInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultOrderByFromDesiredColumns">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DesiredColumns" nillable="true" type="q13:ArrayOfstring" xmlns:q13="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultOrderByFromDesiredColumnsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfArchiveOrderByInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindOrderBy">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="PageNumber" type="xs:int" />
            <xs:element minOccurs="0" name="OrderBy" nillable="true" type="tns:ArrayOfArchiveOrderByInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindOrderByResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FindResults" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindWithExtraRestrictions">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ExtraRestrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
            <xs:element minOccurs="0" name="OrderBy" nillable="true" type="tns:ArrayOfArchiveOrderByInfo" />
            <xs:element minOccurs="0" name="DesiredColumns" nillable="true" type="q14:ArrayOfstring" xmlns:q14="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="PageNumber" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindWithExtraRestrictionsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FindResults" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindWithColumns">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DesiredColumns" nillable="true" type="q15:ArrayOfstring" xmlns:q15="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="PageNumber" type="xs:int" />
            <xs:element minOccurs="0" name="OrderBy" nillable="true" type="tns:ArrayOfArchiveOrderByInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindWithColumnsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FindResults" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveRestrictions2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveRestrictions2Response">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveRestrictionsWithContext2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Context" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveRestrictionsWithContext2Response">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveRestrictionsAndGetCriteriaInformation2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StaticColumns" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveRestrictionsAndGetCriteriaInformation2Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CriteriaInformation" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindFromRestrictions2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="PageNumber" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindFromRestrictions2Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FindResults" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindFromRestrictionsColumns2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DesiredColumns" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="PageNumber" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindFromRestrictionsColumns2Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FindResults" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindFromRestrictionsColumnsOrderBy2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DesiredColumns" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="OrderBy" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="PageNumber" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindFromRestrictionsColumnsOrderBy2Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FindResults" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultDesiredColumnsFromRestrictions2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultDesiredColumnsFromRestrictions2Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfArchiveColumnInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindOrderBy2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="PageNumber" type="xs:int" />
            <xs:element minOccurs="0" name="OrderBy" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindOrderBy2Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FindResults" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindWithExtraRestrictions2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StorageType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ExtraRestrictions" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="OrderBy" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DesiredColumns" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PageSize" type="xs:int" />
            <xs:element minOccurs="0" name="PageNumber" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindWithExtraRestrictions2Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FindResults" />
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
  <wsdl:message name="GetCriteriaInformationRequest">
    <wsdl:part name="parameters" element="tns:GetCriteriaInformation" />
  </wsdl:message>
  <wsdl:message name="GetCriteriaInformationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCriteriaInformationResponse">
    <wsdl:part name="parameters" element="tns:GetCriteriaInformationResponse" />
  </wsdl:message>
  <wsdl:message name="GetCriteriaInformationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCriteriaInformationWithContextRequest">
    <wsdl:part name="parameters" element="tns:GetCriteriaInformationWithContext" />
  </wsdl:message>
  <wsdl:message name="GetCriteriaInformationWithContextRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCriteriaInformationWithContextResponse">
    <wsdl:part name="parameters" element="tns:GetCriteriaInformationWithContextResponse" />
  </wsdl:message>
  <wsdl:message name="GetCriteriaInformationWithContextResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsRequest">
    <wsdl:part name="parameters" element="tns:SaveRestrictions" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsResponse">
    <wsdl:part name="parameters" element="tns:SaveRestrictionsResponse" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsWithContextRequest">
    <wsdl:part name="parameters" element="tns:SaveRestrictionsWithContext" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsWithContextRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsWithContextResponse">
    <wsdl:part name="parameters" element="tns:SaveRestrictionsWithContextResponse" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsWithContextResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsAndGetCriteriaInformationRequest">
    <wsdl:part name="parameters" element="tns:SaveRestrictionsAndGetCriteriaInformation" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsAndGetCriteriaInformationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsAndGetCriteriaInformationResponse">
    <wsdl:part name="parameters" element="tns:SaveRestrictionsAndGetCriteriaInformationResponse" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsAndGetCriteriaInformationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindRequest">
    <wsdl:part name="parameters" element="tns:Find" />
  </wsdl:message>
  <wsdl:message name="FindRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindResponse">
    <wsdl:part name="parameters" element="tns:FindResponse" />
  </wsdl:message>
  <wsdl:message name="FindResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsRequest">
    <wsdl:part name="parameters" element="tns:FindFromRestrictions" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsResponse">
    <wsdl:part name="parameters" element="tns:FindFromRestrictionsResponse" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsColumnsRequest">
    <wsdl:part name="parameters" element="tns:FindFromRestrictionsColumns" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsColumnsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsColumnsResponse">
    <wsdl:part name="parameters" element="tns:FindFromRestrictionsColumnsResponse" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsColumnsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAvailableRestrictionColumnsRequest">
    <wsdl:part name="parameters" element="tns:GetAvailableRestrictionColumns" />
  </wsdl:message>
  <wsdl:message name="GetAvailableRestrictionColumnsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAvailableRestrictionColumnsResponse">
    <wsdl:part name="parameters" element="tns:GetAvailableRestrictionColumnsResponse" />
  </wsdl:message>
  <wsdl:message name="GetAvailableRestrictionColumnsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSpecifiedCriteriaInformationWithDefaultsRequest">
    <wsdl:part name="parameters" element="tns:GetSpecifiedCriteriaInformationWithDefaults" />
  </wsdl:message>
  <wsdl:message name="GetSpecifiedCriteriaInformationWithDefaultsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSpecifiedCriteriaInformationWithDefaultsResponse">
    <wsdl:part name="parameters" element="tns:GetSpecifiedCriteriaInformationWithDefaultsResponse" />
  </wsdl:message>
  <wsdl:message name="GetSpecifiedCriteriaInformationWithDefaultsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSpecifiedCriteriaInformationWithDefaultsWithContextRequest">
    <wsdl:part name="parameters" element="tns:GetSpecifiedCriteriaInformationWithDefaultsWithContext" />
  </wsdl:message>
  <wsdl:message name="GetSpecifiedCriteriaInformationWithDefaultsWithContextRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSpecifiedCriteriaInformationWithDefaultsWithContextResponse">
    <wsdl:part name="parameters" element="tns:GetSpecifiedCriteriaInformationWithDefaultsWithContextResponse" />
  </wsdl:message>
  <wsdl:message name="GetSpecifiedCriteriaInformationWithDefaultsWithContextResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsColumnsOrderByRequest">
    <wsdl:part name="parameters" element="tns:FindFromRestrictionsColumnsOrderBy" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsColumnsOrderByRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsColumnsOrderByResponse">
    <wsdl:part name="parameters" element="tns:FindFromRestrictionsColumnsOrderByResponse" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsColumnsOrderByResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultDesiredColumnsRequest">
    <wsdl:part name="parameters" element="tns:GetDefaultDesiredColumns" />
  </wsdl:message>
  <wsdl:message name="GetDefaultDesiredColumnsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultDesiredColumnsResponse">
    <wsdl:part name="parameters" element="tns:GetDefaultDesiredColumnsResponse" />
  </wsdl:message>
  <wsdl:message name="GetDefaultDesiredColumnsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultOrderByRequest">
    <wsdl:part name="parameters" element="tns:GetDefaultOrderBy" />
  </wsdl:message>
  <wsdl:message name="GetDefaultOrderByRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultOrderByResponse">
    <wsdl:part name="parameters" element="tns:GetDefaultOrderByResponse" />
  </wsdl:message>
  <wsdl:message name="GetDefaultOrderByResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PopulateRestrictionsRequest">
    <wsdl:part name="parameters" element="tns:PopulateRestrictions" />
  </wsdl:message>
  <wsdl:message name="PopulateRestrictionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PopulateRestrictionsResponse">
    <wsdl:part name="parameters" element="tns:PopulateRestrictionsResponse" />
  </wsdl:message>
  <wsdl:message name="PopulateRestrictionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultDesiredColumnsFromRestrictionsRequest">
    <wsdl:part name="parameters" element="tns:GetDefaultDesiredColumnsFromRestrictions" />
  </wsdl:message>
  <wsdl:message name="GetDefaultDesiredColumnsFromRestrictionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultDesiredColumnsFromRestrictionsResponse">
    <wsdl:part name="parameters" element="tns:GetDefaultDesiredColumnsFromRestrictionsResponse" />
  </wsdl:message>
  <wsdl:message name="GetDefaultDesiredColumnsFromRestrictionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultOrderByFromDesiredColumnsRequest">
    <wsdl:part name="parameters" element="tns:GetDefaultOrderByFromDesiredColumns" />
  </wsdl:message>
  <wsdl:message name="GetDefaultOrderByFromDesiredColumnsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultOrderByFromDesiredColumnsResponse">
    <wsdl:part name="parameters" element="tns:GetDefaultOrderByFromDesiredColumnsResponse" />
  </wsdl:message>
  <wsdl:message name="GetDefaultOrderByFromDesiredColumnsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindOrderByRequest">
    <wsdl:part name="parameters" element="tns:FindOrderBy" />
  </wsdl:message>
  <wsdl:message name="FindOrderByRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindOrderByResponse">
    <wsdl:part name="parameters" element="tns:FindOrderByResponse" />
  </wsdl:message>
  <wsdl:message name="FindOrderByResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindWithExtraRestrictionsRequest">
    <wsdl:part name="parameters" element="tns:FindWithExtraRestrictions" />
  </wsdl:message>
  <wsdl:message name="FindWithExtraRestrictionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindWithExtraRestrictionsResponse">
    <wsdl:part name="parameters" element="tns:FindWithExtraRestrictionsResponse" />
  </wsdl:message>
  <wsdl:message name="FindWithExtraRestrictionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindWithColumnsRequest">
    <wsdl:part name="parameters" element="tns:FindWithColumns" />
  </wsdl:message>
  <wsdl:message name="FindWithColumnsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindWithColumnsResponse">
    <wsdl:part name="parameters" element="tns:FindWithColumnsResponse" />
  </wsdl:message>
  <wsdl:message name="FindWithColumnsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictions2Request">
    <wsdl:part name="parameters" element="tns:SaveRestrictions2" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictions2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictions2Response">
    <wsdl:part name="parameters" element="tns:SaveRestrictions2Response" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictions2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsWithContext2Request">
    <wsdl:part name="parameters" element="tns:SaveRestrictionsWithContext2" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsWithContext2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsWithContext2Response">
    <wsdl:part name="parameters" element="tns:SaveRestrictionsWithContext2Response" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsWithContext2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsAndGetCriteriaInformation2Request">
    <wsdl:part name="parameters" element="tns:SaveRestrictionsAndGetCriteriaInformation2" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsAndGetCriteriaInformation2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsAndGetCriteriaInformation2Response">
    <wsdl:part name="parameters" element="tns:SaveRestrictionsAndGetCriteriaInformation2Response" />
  </wsdl:message>
  <wsdl:message name="SaveRestrictionsAndGetCriteriaInformation2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictions2Request">
    <wsdl:part name="parameters" element="tns:FindFromRestrictions2" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictions2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictions2Response">
    <wsdl:part name="parameters" element="tns:FindFromRestrictions2Response" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictions2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsColumns2Request">
    <wsdl:part name="parameters" element="tns:FindFromRestrictionsColumns2" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsColumns2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsColumns2Response">
    <wsdl:part name="parameters" element="tns:FindFromRestrictionsColumns2Response" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsColumns2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsColumnsOrderBy2Request">
    <wsdl:part name="parameters" element="tns:FindFromRestrictionsColumnsOrderBy2" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsColumnsOrderBy2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsColumnsOrderBy2Response">
    <wsdl:part name="parameters" element="tns:FindFromRestrictionsColumnsOrderBy2Response" />
  </wsdl:message>
  <wsdl:message name="FindFromRestrictionsColumnsOrderBy2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultDesiredColumnsFromRestrictions2Request">
    <wsdl:part name="parameters" element="tns:GetDefaultDesiredColumnsFromRestrictions2" />
  </wsdl:message>
  <wsdl:message name="GetDefaultDesiredColumnsFromRestrictions2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultDesiredColumnsFromRestrictions2Response">
    <wsdl:part name="parameters" element="tns:GetDefaultDesiredColumnsFromRestrictions2Response" />
  </wsdl:message>
  <wsdl:message name="GetDefaultDesiredColumnsFromRestrictions2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindOrderBy2Request">
    <wsdl:part name="parameters" element="tns:FindOrderBy2" />
  </wsdl:message>
  <wsdl:message name="FindOrderBy2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindOrderBy2Response">
    <wsdl:part name="parameters" element="tns:FindOrderBy2Response" />
  </wsdl:message>
  <wsdl:message name="FindOrderBy2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindWithExtraRestrictions2Request">
    <wsdl:part name="parameters" element="tns:FindWithExtraRestrictions2" />
  </wsdl:message>
  <wsdl:message name="FindWithExtraRestrictions2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindWithExtraRestrictions2Response">
    <wsdl:part name="parameters" element="tns:FindWithExtraRestrictions2Response" />
  </wsdl:message>
  <wsdl:message name="FindWithExtraRestrictions2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Find">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Find</summary>
    </wsdl:documentation>
    <wsdl:operation name="GetCriteriaInformation">
      <wsdl:documentation>
        <summary>Get criteria information from a set of saved criteria. The result contains the restrictions in two forms: fully populated ArchiveRestrictionInfo objects, used to display details and for saving changes; and as a list suitable for an Archive control</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetCriteriaInformation" name="GetCriteriaInformationRequest" message="tns:GetCriteriaInformationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetCriteriaInformationResponse" name="GetCriteriaInformationResponse" message="tns:GetCriteriaInformationResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCriteriaInformationWithContext">
      <wsdl:documentation>
        <summary>Get criteria information from a set of saved criteria. The result contains the restrictions in two forms: fully populated ArchiveRestrictionInfo objects, used to display details and for saving changes; and as a list suitable for an Archive control</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetCriteriaInformationWithContext" name="GetCriteriaInformationWithContextRequest" message="tns:GetCriteriaInformationWithContextRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetCriteriaInformationWithContextResponse" name="GetCriteriaInformationWithContextResponse" message="tns:GetCriteriaInformationWithContextResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveRestrictions">
      <wsdl:documentation>
        <summary>Save an array of restrictions for later use as search criteria (including as dynamic selection and Find). </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/SaveRestrictions" name="SaveRestrictionsRequest" message="tns:SaveRestrictionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/SaveRestrictionsResponse" name="SaveRestrictionsResponse" message="tns:SaveRestrictionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveRestrictionsWithContext">
      <wsdl:documentation>
        <summary>Save an array of restrictions for later use as search criteria (including as dynamic selection and Find). </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/SaveRestrictionsWithContext" name="SaveRestrictionsWithContextRequest" message="tns:SaveRestrictionsWithContextRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/SaveRestrictionsWithContextResponse" name="SaveRestrictionsWithContextResponse" message="tns:SaveRestrictionsWithContextResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveRestrictionsAndGetCriteriaInformation">
      <wsdl:documentation>
        <summary>Save an array of restrictions for later use as search criteria (including as dynamic selection and Find). Then, return the same result as a call to GetCriteriaInformation would have done. The purpose is to encapsulate saving and updating of a GUI in one round trip.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/SaveRestrictionsAndGetCriteriaInformation" name="SaveRestrictionsAndGetCriteriaInformationRequest" message="tns:SaveRestrictionsAndGetCriteriaInformationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/SaveRestrictionsAndGetCriteriaInformationResponse" name="SaveRestrictionsAndGetCriteriaInformationResponse" message="tns:SaveRestrictionsAndGetCriteriaInformationResponse" />
    </wsdl:operation>
    <wsdl:operation name="Find">
      <wsdl:documentation>
        <summary>Execute a Find operation and return a page of results. The criteria for the Find are fetched from the restriction storage provider according to the given parameters. The columns of the result are calculated based on the restriction. The orderby columns are also calculated by the system.&lt;para/&gt;The other variants of the Find method allow you greater control over the individual aspects of the process.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/Find" name="FindRequest" message="tns:FindRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindResponse" name="FindResponse" message="tns:FindResponse" />
    </wsdl:operation>
    <wsdl:operation name="FindFromRestrictions">
      <wsdl:documentation>
        <summary>Execute a Find operation and return a page of results. The criteria for the Find are passed in directly, not fetched by a restriction storage provider. The columns of the result are calculated based on the restriction.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindFromRestrictions" name="FindFromRestrictionsRequest" message="tns:FindFromRestrictionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindFromRestrictionsResponse" name="FindFromRestrictionsResponse" message="tns:FindFromRestrictionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="FindFromRestrictionsColumns">
      <wsdl:documentation>
        <summary>Execute a Find operation and return a page of results. &lt;para/&gt;The criteria for the Find are passed in directly, not fetched by a restriction storage provider. &lt;para/&gt;The desired columns of the result set are also passed in directly.&lt;para/&gt;The orderby information is calculated by the system.&lt;para/&gt;Use the GetCriteriaInformation and GetDefaultDesiredColumns service methods to let the system calculate these values, if you want to use or modify them.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindFromRestrictionsColumns" name="FindFromRestrictionsColumnsRequest" message="tns:FindFromRestrictionsColumnsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindFromRestrictionsColumnsResponse" name="FindFromRestrictionsColumnsResponse" message="tns:FindFromRestrictionsColumnsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAvailableRestrictionColumns">
      <wsdl:documentation>
        <summary>Get a list of the column names corresponding to available restrictions for a certain archive provider and restriction storage provider. Such columns have CanRestrict set to true, and are supported by the given restriction storage provider.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetAvailableRestrictionColumns" name="GetAvailableRestrictionColumnsRequest" message="tns:GetAvailableRestrictionColumnsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetAvailableRestrictionColumnsResponse" name="GetAvailableRestrictionColumnsResponse" message="tns:GetAvailableRestrictionColumnsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSpecifiedCriteriaInformationWithDefaults">
      <wsdl:documentation>
        <summary>Get criteria information from a set of saved criteria, for a specific set of columns. The result contains the restrictions in two forms: fully populated ArchiveRestrictionInfo objects, used to display details and for saving changes; and as a list suitable for an Archive control. ALL columns specified in the call will be present in the results; those that do not have corresponding criteria set will have empty values and the default (first) operator, with the IsActive flag set to false.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetSpecifiedCriteriaInformationWithDefaults" name="GetSpecifiedCriteriaInformationWithDefaultsRequest" message="tns:GetSpecifiedCriteriaInformationWithDefaultsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetSpecifiedCriteriaInformationWithDefaultsResponse" name="GetSpecifiedCriteriaInformationWithDefaultsResponse" message="tns:GetSpecifiedCriteriaInformationWithDefaultsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSpecifiedCriteriaInformationWithDefaultsWithContext">
      <wsdl:documentation>
        <summary>Get criteria information from a set of saved criteria, for a specific set of columns. The result contains the restrictions in two forms: fully populated ArchiveRestrictionInfo objects, used to display details and for saving changes; and as a list suitable for an Archive control. ALL columns specified in the call will be present in the results; those that do not have corresponding criteria set will have empty values and the default (first) operator, with the IsActive flag set to false.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetSpecifiedCriteriaInformationWithDefaultsWithContext" name="GetSpecifiedCriteriaInformationWithDefaultsWithContextRequest" message="tns:GetSpecifiedCriteriaInformationWithDefaultsWithContextRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetSpecifiedCriteriaInformationWithDefaultsWithContextResponse" name="GetSpecifiedCriteriaInformationWithDefaultsWithContextResponse" message="tns:GetSpecifiedCriteriaInformationWithDefaultsWithContextResponse" />
    </wsdl:operation>
    <wsdl:operation name="FindFromRestrictionsColumnsOrderBy">
      <wsdl:documentation>
        <summary>Execute a Find operation and return a page of results. &lt;para/&gt;The criteria for the Find are passed in directly, not fetched by a restriction storage provider. &lt;para/&gt;The desired columns of the result set are also passed in directly.&lt;para/&gt;The orderby information is also passed in directly.&lt;para/&gt;Use the GetCriteriaInformation, GetDefaultDesiredColumns and GetDefaultOrderBy service methods to let the system calculate these values, if you want to use or modify them.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindFromRestrictionsColumnsOrderBy" name="FindFromRestrictionsColumnsOrderByRequest" message="tns:FindFromRestrictionsColumnsOrderByRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindFromRestrictionsColumnsOrderByResponse" name="FindFromRestrictionsColumnsOrderByResponse" message="tns:FindFromRestrictionsColumnsOrderByResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDefaultDesiredColumns">
      <wsdl:documentation>
        <summary>Calculate the default desired columns, i.e., the result columns for a given search. The search is defined by a storage type, provider name and storage key, which are used to fetch the corresponding restrictions from the database (in the same way as Find does). If you want to specify the restriction directly, use the GetDefaultDesiredColumnsFromRestrictions method instead. This is the algorithm that is used by the Find service method.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetDefaultDesiredColumns" name="GetDefaultDesiredColumnsRequest" message="tns:GetDefaultDesiredColumnsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetDefaultDesiredColumnsResponse" name="GetDefaultDesiredColumnsResponse" message="tns:GetDefaultDesiredColumnsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDefaultOrderBy">
      <wsdl:documentation>
        <summary>Calculate the default orderby columns for a given provider and a search. The search is specified by a storage type, provider name and storage key, and is fetched from the database. Default desired columns are then calculated for the search, and those columns are then used as the basis for calculating an order by. If you want to specify the desired columns directly, use the GetDefaultOrderByFromDesiredColumns method instead.  This is the same algorithm that is used by the Find service method.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetDefaultOrderBy" name="GetDefaultOrderByRequest" message="tns:GetDefaultOrderByRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetDefaultOrderByResponse" name="GetDefaultOrderByResponse" message="tns:GetDefaultOrderByResponse" />
    </wsdl:operation>
    <wsdl:operation name="PopulateRestrictions">
      <wsdl:documentation>
        <summary>Take an incoming set of minimally populated restrictions (name + operator is required), and populate all the other parts of the ArchiveRestrictionInfo structure. This includes column information, display values (including list value lookup), and calculated/default values where the value hints specify read-only (R).</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/PopulateRestrictions" name="PopulateRestrictionsRequest" message="tns:PopulateRestrictionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/PopulateRestrictionsResponse" name="PopulateRestrictionsResponse" message="tns:PopulateRestrictionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDefaultDesiredColumnsFromRestrictions">
      <wsdl:documentation>
        <summary>Calculate the default desired columns, i.e., the result columns for a given search. The search is defined by a provider name and a set of restrictions. This is the algorithm that is used by the Find service method.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetDefaultDesiredColumnsFromRestrictions" name="GetDefaultDesiredColumnsFromRestrictionsRequest" message="tns:GetDefaultDesiredColumnsFromRestrictionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetDefaultDesiredColumnsFromRestrictionsResponse" name="GetDefaultDesiredColumnsFromRestrictionsResponse" message="tns:GetDefaultDesiredColumnsFromRestrictionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDefaultOrderByFromDesiredColumns">
      <wsdl:documentation>
        <summary>Calculate the default orderby columns for a given provider and a set of desired columns. This is the same algorithm that is used by the Find service method.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetDefaultOrderByFromDesiredColumns" name="GetDefaultOrderByFromDesiredColumnsRequest" message="tns:GetDefaultOrderByFromDesiredColumnsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetDefaultOrderByFromDesiredColumnsResponse" name="GetDefaultOrderByFromDesiredColumnsResponse" message="tns:GetDefaultOrderByFromDesiredColumnsResponse" />
    </wsdl:operation>
    <wsdl:operation name="FindOrderBy">
      <wsdl:documentation>
        <summary>Execute a Find operation and return a page of results. The criteria for the Find are fetched from the restriction storage provider according to the given parameters. The columns of the result are calculated based on the restriction. The orderby parameter is used for sorting the results.&lt;para/&gt;The other variants of the Find method allow you greater control over the individual aspects of the process.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindOrderBy" name="FindOrderByRequest" message="tns:FindOrderByRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindOrderByResponse" name="FindOrderByResponse" message="tns:FindOrderByResponse" />
    </wsdl:operation>
    <wsdl:operation name="FindWithExtraRestrictions">
      <wsdl:documentation>
        <summary>Execute a Find operation and return a page of results. The criteria for the Find are fetched from the restriction storage provider according to the given parameters. In addition an extra set of restrictions can be added to the search. These restrictions will not be saved, they are only valid for the current search. Extra restrictions will override restrictions with the same key already stored on the storagekey.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindWithExtraRestrictions" name="FindWithExtraRestrictionsRequest" message="tns:FindWithExtraRestrictionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindWithExtraRestrictionsResponse" name="FindWithExtraRestrictionsResponse" message="tns:FindWithExtraRestrictionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="FindWithColumns">
      <wsdl:documentation>
        <summary>Execute a Find operation and return a page of results. The criteria for the Find are fetched from the restriction storage provider according to the given parameters.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindWithColumns" name="FindWithColumnsRequest" message="tns:FindWithColumnsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindWithColumnsResponse" name="FindWithColumnsResponse" message="tns:FindWithColumnsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveRestrictions2">
      <wsdl:documentation>
        <summary>Save an array of restrictions for later use as search criteria (including as dynamic selection and Find). </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/SaveRestrictions2" name="SaveRestrictions2Request" message="tns:SaveRestrictions2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/SaveRestrictions2Response" name="SaveRestrictions2Response" message="tns:SaveRestrictions2Response" />
    </wsdl:operation>
    <wsdl:operation name="SaveRestrictionsWithContext2">
      <wsdl:documentation>
        <summary>Save an array of restrictions for later use as search criteria (including as dynamic selection and Find). </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/SaveRestrictionsWithContext2" name="SaveRestrictionsWithContext2Request" message="tns:SaveRestrictionsWithContext2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/SaveRestrictionsWithContext2Response" name="SaveRestrictionsWithContext2Response" message="tns:SaveRestrictionsWithContext2Response" />
    </wsdl:operation>
    <wsdl:operation name="SaveRestrictionsAndGetCriteriaInformation2">
      <wsdl:documentation>
        <summary>Save an array of restrictions for later use as search criteria (including as dynamic selection and Find). Then, return the same result as a call to GetCriteriaInformation would have done. The purpose is to encapsulate saving and updating of a GUI in one round trip.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/SaveRestrictionsAndGetCriteriaInformation2" name="SaveRestrictionsAndGetCriteriaInformation2Request" message="tns:SaveRestrictionsAndGetCriteriaInformation2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/SaveRestrictionsAndGetCriteriaInformation2Response" name="SaveRestrictionsAndGetCriteriaInformation2Response" message="tns:SaveRestrictionsAndGetCriteriaInformation2Response" />
    </wsdl:operation>
    <wsdl:operation name="FindFromRestrictions2">
      <wsdl:documentation>
        <summary>Execute a Find operation and return a page of results. The criteria for the Find are passed in directly, not fetched by a restriction storage provider. The columns of the result are calculated based on the restriction.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindFromRestrictions2" name="FindFromRestrictions2Request" message="tns:FindFromRestrictions2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindFromRestrictions2Response" name="FindFromRestrictions2Response" message="tns:FindFromRestrictions2Response" />
    </wsdl:operation>
    <wsdl:operation name="FindFromRestrictionsColumns2">
      <wsdl:documentation>
        <summary>Execute a Find operation and return a page of results. &lt;para/&gt;The criteria for the Find are passed in directly, not fetched by a restriction storage provider. &lt;para/&gt;The desired columns of the result set are also passed in directly.&lt;para/&gt;The orderby information is calculated by the system.&lt;para/&gt;Use the GetCriteriaInformation and GetDefaultDesiredColumns service methods to let the system calculate these values, if you want to use or modify them.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindFromRestrictionsColumns2" name="FindFromRestrictionsColumns2Request" message="tns:FindFromRestrictionsColumns2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindFromRestrictionsColumns2Response" name="FindFromRestrictionsColumns2Response" message="tns:FindFromRestrictionsColumns2Response" />
    </wsdl:operation>
    <wsdl:operation name="FindFromRestrictionsColumnsOrderBy2">
      <wsdl:documentation>
        <summary>Execute a Find operation and return a page of results. &lt;para/&gt;The criteria for the Find are passed in directly, not fetched by a restriction storage provider. &lt;para/&gt;The desired columns of the result set are also passed in directly.&lt;para/&gt;The orderby information is also passed in directly.&lt;para/&gt;Use the GetCriteriaInformation, GetDefaultDesiredColumns and GetDefaultOrderBy service methods to let the system calculate these values, if you want to use or modify them.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindFromRestrictionsColumnsOrderBy2" name="FindFromRestrictionsColumnsOrderBy2Request" message="tns:FindFromRestrictionsColumnsOrderBy2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindFromRestrictionsColumnsOrderBy2Response" name="FindFromRestrictionsColumnsOrderBy2Response" message="tns:FindFromRestrictionsColumnsOrderBy2Response" />
    </wsdl:operation>
    <wsdl:operation name="GetDefaultDesiredColumnsFromRestrictions2">
      <wsdl:documentation>
        <summary>Calculate the default desired columns, i.e., the result columns for a given search. The search is defined by a provider name and a set of restrictions. This is the algorithm that is used by the Find service method.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetDefaultDesiredColumnsFromRestrictions2" name="GetDefaultDesiredColumnsFromRestrictions2Request" message="tns:GetDefaultDesiredColumnsFromRestrictions2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetDefaultDesiredColumnsFromRestrictions2Response" name="GetDefaultDesiredColumnsFromRestrictions2Response" message="tns:GetDefaultDesiredColumnsFromRestrictions2Response" />
    </wsdl:operation>
    <wsdl:operation name="FindOrderBy2">
      <wsdl:documentation>
        <summary>Execute a Find operation and return a page of results. The criteria for the Find are fetched from the restriction storage provider according to the given parameters. The columns of the result are calculated based on the restriction. The orderby parameter is used for sorting the results.&lt;para/&gt;The other variants of the Find method allow you greater control over the individual aspects of the process.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindOrderBy2" name="FindOrderBy2Request" message="tns:FindOrderBy2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindOrderBy2Response" name="FindOrderBy2Response" message="tns:FindOrderBy2Response" />
    </wsdl:operation>
    <wsdl:operation name="FindWithExtraRestrictions2">
      <wsdl:documentation>
        <summary>Execute a Find operation and return a page of results. The criteria for the Find are fetched from the restriction storage provider according to the given parameters. In addition an extra set of restrictions can be added to the search. These restrictions will not be saved, they are only valid for the current search. Extra restrictions will override restrictions with the same key already stored on the storagekey.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindWithExtraRestrictions2" name="FindWithExtraRestrictions2Request" message="tns:FindWithExtraRestrictions2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindWithExtraRestrictions2Response" name="FindWithExtraRestrictions2Response" message="tns:FindWithExtraRestrictions2Response" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Find" type="tns:Find">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="GetCriteriaInformation">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetCriteriaInformation" style="document" />
      <wsdl:input name="GetCriteriaInformationRequest">
        <soap:header message="tns:GetCriteriaInformationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCriteriaInformationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCriteriaInformationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCriteriaInformationResponse">
        <soap:header message="tns:GetCriteriaInformationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCriteriaInformationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCriteriaInformationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCriteriaInformationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCriteriaInformationWithContext">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetCriteriaInformationWithContext" style="document" />
      <wsdl:input name="GetCriteriaInformationWithContextRequest">
        <soap:header message="tns:GetCriteriaInformationWithContextRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCriteriaInformationWithContextRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCriteriaInformationWithContextRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCriteriaInformationWithContextResponse">
        <soap:header message="tns:GetCriteriaInformationWithContextResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCriteriaInformationWithContextResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCriteriaInformationWithContextResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCriteriaInformationWithContextResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveRestrictions">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/SaveRestrictions" style="document" />
      <wsdl:input name="SaveRestrictionsRequest">
        <soap:header message="tns:SaveRestrictionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveRestrictionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveRestrictionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveRestrictionsResponse">
        <soap:header message="tns:SaveRestrictionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveRestrictionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveRestrictionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveRestrictionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveRestrictionsWithContext">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/SaveRestrictionsWithContext" style="document" />
      <wsdl:input name="SaveRestrictionsWithContextRequest">
        <soap:header message="tns:SaveRestrictionsWithContextRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveRestrictionsWithContextRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveRestrictionsWithContextRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveRestrictionsWithContextResponse">
        <soap:header message="tns:SaveRestrictionsWithContextResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveRestrictionsWithContextResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveRestrictionsWithContextResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveRestrictionsWithContextResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveRestrictionsAndGetCriteriaInformation">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/SaveRestrictionsAndGetCriteriaInformation" style="document" />
      <wsdl:input name="SaveRestrictionsAndGetCriteriaInformationRequest">
        <soap:header message="tns:SaveRestrictionsAndGetCriteriaInformationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveRestrictionsAndGetCriteriaInformationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveRestrictionsAndGetCriteriaInformationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveRestrictionsAndGetCriteriaInformationResponse">
        <soap:header message="tns:SaveRestrictionsAndGetCriteriaInformationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveRestrictionsAndGetCriteriaInformationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveRestrictionsAndGetCriteriaInformationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveRestrictionsAndGetCriteriaInformationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Find">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/Find" style="document" />
      <wsdl:input name="FindRequest">
        <soap:header message="tns:FindRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindResponse">
        <soap:header message="tns:FindResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindFromRestrictions">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindFromRestrictions" style="document" />
      <wsdl:input name="FindFromRestrictionsRequest">
        <soap:header message="tns:FindFromRestrictionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindFromRestrictionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindFromRestrictionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindFromRestrictionsResponse">
        <soap:header message="tns:FindFromRestrictionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindFromRestrictionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindFromRestrictionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindFromRestrictionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindFromRestrictionsColumns">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindFromRestrictionsColumns" style="document" />
      <wsdl:input name="FindFromRestrictionsColumnsRequest">
        <soap:header message="tns:FindFromRestrictionsColumnsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumnsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumnsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindFromRestrictionsColumnsResponse">
        <soap:header message="tns:FindFromRestrictionsColumnsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumnsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumnsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumnsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAvailableRestrictionColumns">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetAvailableRestrictionColumns" style="document" />
      <wsdl:input name="GetAvailableRestrictionColumnsRequest">
        <soap:header message="tns:GetAvailableRestrictionColumnsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAvailableRestrictionColumnsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAvailableRestrictionColumnsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAvailableRestrictionColumnsResponse">
        <soap:header message="tns:GetAvailableRestrictionColumnsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAvailableRestrictionColumnsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAvailableRestrictionColumnsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAvailableRestrictionColumnsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSpecifiedCriteriaInformationWithDefaults">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetSpecifiedCriteriaInformationWithDefaults" style="document" />
      <wsdl:input name="GetSpecifiedCriteriaInformationWithDefaultsRequest">
        <soap:header message="tns:GetSpecifiedCriteriaInformationWithDefaultsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSpecifiedCriteriaInformationWithDefaultsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSpecifiedCriteriaInformationWithDefaultsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSpecifiedCriteriaInformationWithDefaultsResponse">
        <soap:header message="tns:GetSpecifiedCriteriaInformationWithDefaultsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSpecifiedCriteriaInformationWithDefaultsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSpecifiedCriteriaInformationWithDefaultsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSpecifiedCriteriaInformationWithDefaultsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSpecifiedCriteriaInformationWithDefaultsWithContext">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetSpecifiedCriteriaInformationWithDefaultsWithContext" style="document" />
      <wsdl:input name="GetSpecifiedCriteriaInformationWithDefaultsWithContextRequest">
        <soap:header message="tns:GetSpecifiedCriteriaInformationWithDefaultsWithContextRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSpecifiedCriteriaInformationWithDefaultsWithContextRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSpecifiedCriteriaInformationWithDefaultsWithContextRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSpecifiedCriteriaInformationWithDefaultsWithContextResponse">
        <soap:header message="tns:GetSpecifiedCriteriaInformationWithDefaultsWithContextResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSpecifiedCriteriaInformationWithDefaultsWithContextResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSpecifiedCriteriaInformationWithDefaultsWithContextResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSpecifiedCriteriaInformationWithDefaultsWithContextResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindFromRestrictionsColumnsOrderBy">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindFromRestrictionsColumnsOrderBy" style="document" />
      <wsdl:input name="FindFromRestrictionsColumnsOrderByRequest">
        <soap:header message="tns:FindFromRestrictionsColumnsOrderByRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumnsOrderByRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumnsOrderByRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindFromRestrictionsColumnsOrderByResponse">
        <soap:header message="tns:FindFromRestrictionsColumnsOrderByResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumnsOrderByResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumnsOrderByResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumnsOrderByResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDefaultDesiredColumns">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetDefaultDesiredColumns" style="document" />
      <wsdl:input name="GetDefaultDesiredColumnsRequest">
        <soap:header message="tns:GetDefaultDesiredColumnsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDefaultDesiredColumnsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDefaultDesiredColumnsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDefaultDesiredColumnsResponse">
        <soap:header message="tns:GetDefaultDesiredColumnsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDefaultDesiredColumnsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDefaultDesiredColumnsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDefaultDesiredColumnsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDefaultOrderBy">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetDefaultOrderBy" style="document" />
      <wsdl:input name="GetDefaultOrderByRequest">
        <soap:header message="tns:GetDefaultOrderByRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDefaultOrderByRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDefaultOrderByRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDefaultOrderByResponse">
        <soap:header message="tns:GetDefaultOrderByResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDefaultOrderByResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDefaultOrderByResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDefaultOrderByResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="PopulateRestrictions">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/PopulateRestrictions" style="document" />
      <wsdl:input name="PopulateRestrictionsRequest">
        <soap:header message="tns:PopulateRestrictionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:PopulateRestrictionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:PopulateRestrictionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="PopulateRestrictionsResponse">
        <soap:header message="tns:PopulateRestrictionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:PopulateRestrictionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:PopulateRestrictionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:PopulateRestrictionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDefaultDesiredColumnsFromRestrictions">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetDefaultDesiredColumnsFromRestrictions" style="document" />
      <wsdl:input name="GetDefaultDesiredColumnsFromRestrictionsRequest">
        <soap:header message="tns:GetDefaultDesiredColumnsFromRestrictionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDefaultDesiredColumnsFromRestrictionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDefaultDesiredColumnsFromRestrictionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDefaultDesiredColumnsFromRestrictionsResponse">
        <soap:header message="tns:GetDefaultDesiredColumnsFromRestrictionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDefaultDesiredColumnsFromRestrictionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDefaultDesiredColumnsFromRestrictionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDefaultDesiredColumnsFromRestrictionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDefaultOrderByFromDesiredColumns">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetDefaultOrderByFromDesiredColumns" style="document" />
      <wsdl:input name="GetDefaultOrderByFromDesiredColumnsRequest">
        <soap:header message="tns:GetDefaultOrderByFromDesiredColumnsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDefaultOrderByFromDesiredColumnsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDefaultOrderByFromDesiredColumnsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDefaultOrderByFromDesiredColumnsResponse">
        <soap:header message="tns:GetDefaultOrderByFromDesiredColumnsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDefaultOrderByFromDesiredColumnsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDefaultOrderByFromDesiredColumnsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDefaultOrderByFromDesiredColumnsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindOrderBy">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindOrderBy" style="document" />
      <wsdl:input name="FindOrderByRequest">
        <soap:header message="tns:FindOrderByRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindOrderByRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindOrderByRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindOrderByResponse">
        <soap:header message="tns:FindOrderByResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindOrderByResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindOrderByResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindOrderByResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindWithExtraRestrictions">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindWithExtraRestrictions" style="document" />
      <wsdl:input name="FindWithExtraRestrictionsRequest">
        <soap:header message="tns:FindWithExtraRestrictionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindWithExtraRestrictionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindWithExtraRestrictionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindWithExtraRestrictionsResponse">
        <soap:header message="tns:FindWithExtraRestrictionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindWithExtraRestrictionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindWithExtraRestrictionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindWithExtraRestrictionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindWithColumns">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindWithColumns" style="document" />
      <wsdl:input name="FindWithColumnsRequest">
        <soap:header message="tns:FindWithColumnsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindWithColumnsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindWithColumnsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindWithColumnsResponse">
        <soap:header message="tns:FindWithColumnsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindWithColumnsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindWithColumnsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindWithColumnsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveRestrictions2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/SaveRestrictions2" style="document" />
      <wsdl:input name="SaveRestrictions2Request">
        <soap:header message="tns:SaveRestrictions2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveRestrictions2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveRestrictions2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveRestrictions2Response">
        <soap:header message="tns:SaveRestrictions2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveRestrictions2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveRestrictions2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveRestrictions2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveRestrictionsWithContext2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/SaveRestrictionsWithContext2" style="document" />
      <wsdl:input name="SaveRestrictionsWithContext2Request">
        <soap:header message="tns:SaveRestrictionsWithContext2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveRestrictionsWithContext2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveRestrictionsWithContext2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveRestrictionsWithContext2Response">
        <soap:header message="tns:SaveRestrictionsWithContext2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveRestrictionsWithContext2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveRestrictionsWithContext2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveRestrictionsWithContext2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveRestrictionsAndGetCriteriaInformation2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/SaveRestrictionsAndGetCriteriaInformation2" style="document" />
      <wsdl:input name="SaveRestrictionsAndGetCriteriaInformation2Request">
        <soap:header message="tns:SaveRestrictionsAndGetCriteriaInformation2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveRestrictionsAndGetCriteriaInformation2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveRestrictionsAndGetCriteriaInformation2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveRestrictionsAndGetCriteriaInformation2Response">
        <soap:header message="tns:SaveRestrictionsAndGetCriteriaInformation2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveRestrictionsAndGetCriteriaInformation2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveRestrictionsAndGetCriteriaInformation2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveRestrictionsAndGetCriteriaInformation2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindFromRestrictions2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindFromRestrictions2" style="document" />
      <wsdl:input name="FindFromRestrictions2Request">
        <soap:header message="tns:FindFromRestrictions2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindFromRestrictions2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindFromRestrictions2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindFromRestrictions2Response">
        <soap:header message="tns:FindFromRestrictions2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindFromRestrictions2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindFromRestrictions2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindFromRestrictions2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindFromRestrictionsColumns2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindFromRestrictionsColumns2" style="document" />
      <wsdl:input name="FindFromRestrictionsColumns2Request">
        <soap:header message="tns:FindFromRestrictionsColumns2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumns2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumns2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindFromRestrictionsColumns2Response">
        <soap:header message="tns:FindFromRestrictionsColumns2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumns2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumns2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumns2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindFromRestrictionsColumnsOrderBy2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindFromRestrictionsColumnsOrderBy2" style="document" />
      <wsdl:input name="FindFromRestrictionsColumnsOrderBy2Request">
        <soap:header message="tns:FindFromRestrictionsColumnsOrderBy2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumnsOrderBy2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumnsOrderBy2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindFromRestrictionsColumnsOrderBy2Response">
        <soap:header message="tns:FindFromRestrictionsColumnsOrderBy2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumnsOrderBy2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumnsOrderBy2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindFromRestrictionsColumnsOrderBy2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDefaultDesiredColumnsFromRestrictions2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/GetDefaultDesiredColumnsFromRestrictions2" style="document" />
      <wsdl:input name="GetDefaultDesiredColumnsFromRestrictions2Request">
        <soap:header message="tns:GetDefaultDesiredColumnsFromRestrictions2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDefaultDesiredColumnsFromRestrictions2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDefaultDesiredColumnsFromRestrictions2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDefaultDesiredColumnsFromRestrictions2Response">
        <soap:header message="tns:GetDefaultDesiredColumnsFromRestrictions2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDefaultDesiredColumnsFromRestrictions2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDefaultDesiredColumnsFromRestrictions2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDefaultDesiredColumnsFromRestrictions2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindOrderBy2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindOrderBy2" style="document" />
      <wsdl:input name="FindOrderBy2Request">
        <soap:header message="tns:FindOrderBy2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindOrderBy2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindOrderBy2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindOrderBy2Response">
        <soap:header message="tns:FindOrderBy2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindOrderBy2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindOrderBy2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindOrderBy2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindWithExtraRestrictions2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services83/Find/FindWithExtraRestrictions2" style="document" />
      <wsdl:input name="FindWithExtraRestrictions2Request">
        <soap:header message="tns:FindWithExtraRestrictions2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindWithExtraRestrictions2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindWithExtraRestrictions2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindWithExtraRestrictions2Response">
        <soap:header message="tns:FindWithExtraRestrictions2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindWithExtraRestrictions2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindWithExtraRestrictions2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindWithExtraRestrictions2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfFindService">
    <wsdl:port name="BasicHttpBinding_Find" binding="tns:BasicHttpBinding_Find">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services83/Find.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

