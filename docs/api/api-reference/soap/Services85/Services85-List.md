---
Generated: 1
TOCExclude: 1
title: Services85.ListAgent WSDL
---

# Services85.ListAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfListService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services85" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services85" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services85" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:element name="GetAllReasonSold">
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
      <xs:element name="GetAllReasonSoldResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfReasonSold" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfReasonSold">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ReasonSold" nillable="true" type="tns:ReasonSold" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfReasonSold" nillable="true" type="tns:ArrayOfReasonSold" />
      <xs:complexType name="ReasonSold">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ReasonSold" nillable="true" type="tns:ReasonSold" />
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
      <xs:element name="GetReasonSoldList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReasonSoldIds" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetReasonSoldListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfReasonSold" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetReasonStalled">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReasonStalledId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetReasonStalledResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReasonStalled" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ReasonStalled">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ReasonStalled" nillable="true" type="tns:ReasonStalled" />
      <xs:element name="GetAllReasonStalled">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllReasonStalledResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfReasonStalled" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfReasonStalled">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ReasonStalled" nillable="true" type="tns:ReasonStalled" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfReasonStalled" nillable="true" type="tns:ArrayOfReasonStalled" />
      <xs:element name="GetReasonStalledList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReasonStalledIds" nillable="true" type="q2:ArrayOfint" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetReasonStalledListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfReasonStalled" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetResourceEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ResourceEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetResourceEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ResourceEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ResourceEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ResourceId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsLocation" type="xs:boolean" />
              <xs:element minOccurs="0" name="LocationAddress" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ResourceEntity" nillable="true" type="tns:ResourceEntity" />
      <xs:element name="GetSaleStageEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleStageEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSaleStageEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SaleStageEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SaleStageEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="SaleStageId" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Probability" type="xs:short" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SaleStageEntity" nillable="true" type="tns:SaleStageEntity" />
      <xs:element name="GetSaleType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleTypeId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSaleTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SaleType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SaleType">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SaleType" nillable="true" type="tns:SaleType" />
      <xs:element name="GetSaleTypeEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleTypeEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSaleTypeEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SaleTypeEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SaleTypeEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="SaleTypeId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="DurationUnit" type="tns:DurationUnit" />
              <xs:element minOccurs="0" name="SaleDuration" type="xs:int" />
              <xs:element minOccurs="0" name="SaleTypeCatId" type="xs:int" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="HasGuide" type="xs:boolean" />
              <xs:element minOccurs="0" name="HasStakeholders" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsAutoAdvance" type="xs:boolean" />
              <xs:element minOccurs="0" name="AllowQuoteAlternatives" type="xs:boolean" />
              <xs:element minOccurs="0" name="DefaultQuoteValidity" type="xs:int" />
              <xs:element minOccurs="0" name="QuoteLinesTemplate" type="xs:int" />
              <xs:element minOccurs="0" name="ConfirmationLinesTemplate" type="xs:int" />
              <xs:element minOccurs="0" name="MaxDiscountPercentSet" type="xs:boolean" />
              <xs:element minOccurs="0" name="MinEarningPercentSet" type="xs:boolean" />
              <xs:element minOccurs="0" name="MaxDiscountPercent" type="xs:int" />
              <xs:element minOccurs="0" name="MinEarningPercent" type="xs:int" />
              <xs:element minOccurs="0" name="GroupQuoteLinesBy" type="xs:int" />
              <xs:element minOccurs="0" name="SortGroupLinesBy" type="xs:int" />
              <xs:element minOccurs="0" name="Stages" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SaleTypeEntity" nillable="true" type="tns:SaleTypeEntity" />
      <xs:simpleType name="DurationUnit">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Second" />
          <xs:enumeration value="Minute" />
          <xs:enumeration value="Hour" />
          <xs:enumeration value="Day" />
          <xs:enumeration value="Week" />
          <xs:enumeration value="Month" />
          <xs:enumeration value="Quarter" />
          <xs:enumeration value="HalfYear" />
          <xs:enumeration value="Year" />
          <xs:enumeration value="Decade" />
          <xs:enumeration value="Century" />
          <xs:enumeration value="Millenium" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="DurationUnit" nillable="true" type="tns:DurationUnit" />
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
      <xs:element name="GetAllSaleType">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllSaleTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSaleType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfSaleType">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="SaleType" nillable="true" type="tns:SaleType" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfSaleType" nillable="true" type="tns:ArrayOfSaleType" />
      <xs:element name="GetSaleTypeList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleTypeIds" nillable="true" type="q3:ArrayOfint" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSaleTypeListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSaleType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectionCategory">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionCategoryId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectionCategoryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SelectionCategory" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SelectionCategory">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SelectionCategory" nillable="true" type="tns:SelectionCategory" />
      <xs:element name="GetAllSelectionCategory">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllSelectionCategoryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectionCategory" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfSelectionCategory">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="SelectionCategory" nillable="true" type="tns:SelectionCategory" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfSelectionCategory" nillable="true" type="tns:ArrayOfSelectionCategory" />
      <xs:element name="GetSelectionCategoryList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionCategoryIds" nillable="true" type="q4:ArrayOfint" xmlns:q4="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectionCategoryListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectionCategory" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSource">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SourceId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSourceResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Source" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Source">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Source" nillable="true" type="tns:Source" />
      <xs:element name="GetSourceList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SourceIds" nillable="true" type="q5:ArrayOfint" xmlns:q5="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSourceListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSource" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfSource">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Source" nillable="true" type="tns:Source" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfSource" nillable="true" type="tns:ArrayOfSource" />
      <xs:element name="GetSources">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSourcesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSource" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTask">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TaskId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTaskResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Task" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Task">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Task" nillable="true" type="tns:Task" />
      <xs:element name="GetDocumentTemplateTask">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplateTaskResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Task" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTaskList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TaskIds" nillable="true" type="q6:ArrayOfint" xmlns:q6="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTaskListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTask" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfTask">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Task" nillable="true" type="tns:Task" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTask" nillable="true" type="tns:ArrayOfTask" />
      <xs:element name="GetTasks">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTasksResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTask" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplatesTasks">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplatesTasksResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTask" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllTasks">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="IncludeDeleted" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllTasksResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTaskListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfTaskListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TaskListItem" nillable="true" type="tns:TaskListItem" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTaskListItem" nillable="true" type="tns:ArrayOfTaskListItem" />
      <xs:complexType name="TaskListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="TaskListItemId" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Direction" type="tns:TaskDirection" />
              <xs:element minOccurs="0" name="Type" type="tns:TaskType" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="IntentId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="IsDefaultAlldayEvent" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsDefaultFree" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsDefaultPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="ColorIndex" type="tns:ColorIndex" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TaskListItem" nillable="true" type="tns:TaskListItem" />
      <xs:simpleType name="TaskDirection">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Incoming" />
          <xs:enumeration value="Outgoing" />
          <xs:enumeration value="SaintAll" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TaskDirection" nillable="true" type="tns:TaskDirection" />
      <xs:simpleType name="TaskType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Appointment" />
          <xs:enumeration value="Document" />
          <xs:enumeration value="Email" />
          <xs:enumeration value="Fax" />
          <xs:enumeration value="Phone" />
          <xs:enumeration value="ToDo" />
          <xs:enumeration value="MailMergeDraft" />
          <xs:enumeration value="MailMergeFinal" />
          <xs:enumeration value="Report" />
          <xs:enumeration value="SaintAll" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TaskType" nillable="true" type="tns:TaskType" />
      <xs:simpleType name="ColorIndex">
        <xs:restriction base="xs:string">
          <xs:enumeration value="LightBlue" />
          <xs:enumeration value="DarkBlue" />
          <xs:enumeration value="LightGray" />
          <xs:enumeration value="DarkGray" />
          <xs:enumeration value="LightGreen" />
          <xs:enumeration value="DarkGreen" />
          <xs:enumeration value="LightYellow" />
          <xs:enumeration value="DarkYellow" />
          <xs:enumeration value="LightRed" />
          <xs:enumeration value="DarkRed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ColorIndex" nillable="true" type="tns:ColorIndex" />
      <xs:element name="GetTicketPriority">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketPriorityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTicketPriorityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketPriority" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="TicketPriority">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TicketPriority" nillable="true" type="tns:TicketPriority" />
      <xs:element name="GetTicketPriorityList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketPriorityIds" nillable="true" type="q7:ArrayOfint" xmlns:q7="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTicketPriorityListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTicketPriority" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfTicketPriority">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TicketPriority" nillable="true" type="tns:TicketPriority" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTicketPriority" nillable="true" type="tns:ArrayOfTicketPriority" />
      <xs:element name="GetTicketPriorities">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTicketPrioritiesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTicketPriority" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWebPanelEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WebPanelEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWebPanelEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WebPanelEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="WebPanelEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="WebPanelId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="UrlEncoding" type="tns:UrlEncoding" />
              <xs:element minOccurs="0" name="VisibleIn" type="tns:Navigation" />
              <xs:element minOccurs="0" name="OnCentral" type="xs:boolean" />
              <xs:element minOccurs="0" name="OnSatellite" type="xs:boolean" />
              <xs:element minOccurs="0" name="OnTravel" type="xs:boolean" />
              <xs:element minOccurs="0" name="OnSalesMarketingWeb" type="xs:boolean" />
              <xs:element minOccurs="0" name="OnSalesMarketingPocket" type="xs:boolean" />
              <xs:element minOccurs="0" name="ShowInMenuBar" type="xs:boolean" />
              <xs:element minOccurs="0" name="ShowInToolBar" type="xs:boolean" />
              <xs:element minOccurs="0" name="ShowInAddressBar" type="xs:boolean" />
              <xs:element minOccurs="0" name="ShowInStatusBar" type="xs:boolean" />
              <xs:element minOccurs="0" name="WindowName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Url" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProgId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Icon" type="xs:short" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WebPanelEntity" nillable="true" type="tns:WebPanelEntity" />
      <xs:simpleType name="UrlEncoding">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="None" />
          <xs:enumeration value="ANSI" />
          <xs:enumeration value="Unicode" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="UrlEncoding" nillable="true" type="tns:UrlEncoding" />
      <xs:simpleType name="Navigation">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Invisible" />
          <xs:enumeration value="ToolboxMenu" />
          <xs:enumeration value="NavigatorButton" />
          <xs:enumeration value="ViewMenu" />
          <xs:enumeration value="SelectionTaskCard" />
          <xs:enumeration value="ContactCard" />
          <xs:enumeration value="ContactArchive" />
          <xs:enumeration value="ProjectCard" />
          <xs:enumeration value="ProjectArchive" />
          <xs:enumeration value="SaleCard" />
          <xs:enumeration value="PersonCard" />
          <xs:enumeration value="ActivityDialog" />
          <xs:enumeration value="DocumentDialog" />
          <xs:enumeration value="BrowserPanel" />
          <xs:enumeration value="ContSelectionTask" />
          <xs:enumeration value="AppntSelectionTask" />
          <xs:enumeration value="SaleSelectionTask" />
          <xs:enumeration value="DocSelectionTask" />
          <xs:enumeration value="ProjSelectionTask" />
          <xs:enumeration value="CompanyMinicard" />
          <xs:enumeration value="ProjectMinicard" />
          <xs:enumeration value="DiaryMinicard" />
          <xs:enumeration value="SelectionMinicard" />
          <xs:enumeration value="ButtonPanelTask" />
          <xs:enumeration value="AppointmentDialogTask" />
          <xs:enumeration value="SaleDialogTask" />
          <xs:enumeration value="DocumentDialogTask" />
          <xs:enumeration value="PersonDialogTask" />
          <xs:enumeration value="SaleMinicard" />
          <xs:enumeration value="SaleArchive" />
          <xs:enumeration value="AppntSelectionShadowTask" />
          <xs:enumeration value="SaleSelectionShadowTask" />
          <xs:enumeration value="DocSelectionShadowTask" />
          <xs:enumeration value="ProjSelectionShadowTask" />
          <xs:enumeration value="DiaryArchive" />
          <xs:enumeration value="SelectionContactArchive" />
          <xs:enumeration value="SelectionProjectArchive" />
          <xs:enumeration value="SelectionSaleArchive" />
          <xs:enumeration value="SelectionAppointmentArchive" />
          <xs:enumeration value="SelectionDocumentArchive" />
          <xs:enumeration value="ContSelectionCustomTask" />
          <xs:enumeration value="AppntSelectionCustomTask" />
          <xs:enumeration value="SaleSelectionCustomTask" />
          <xs:enumeration value="DocSelectionCustomTask" />
          <xs:enumeration value="ProjSelectionCustomTask" />
          <xs:enumeration value="CustomArchiveMiniCard" />
          <xs:enumeration value="SelectionCard" />
          <xs:enumeration value="ReportMinicard" />
          <xs:enumeration value="QuoteDialog" />
          <xs:enumeration value="QuoteDialogTask" />
          <xs:enumeration value="QuoteDialogArchive" />
          <xs:enumeration value="QuoteLineDialogTask" />
          <xs:enumeration value="QuoteLineDialog" />
          <xs:enumeration value="QuoteLineSelectionMainTask" />
          <xs:enumeration value="QuoteLineSelectionShadowTask" />
          <xs:enumeration value="SelectionQuoteLineArchive" />
          <xs:enumeration value="QuoteLineSelectionCustomTask" />
          <xs:enumeration value="FindSystem" />
          <xs:enumeration value="MailingSelectionTask" />
          <xs:enumeration value="ContactSelectionMailingsTask" />
          <xs:enumeration value="AppointmentSelectionMailingsTask" />
          <xs:enumeration value="SaleSelectionMailingsTask" />
          <xs:enumeration value="DocumentSelectionMailingsTask" />
          <xs:enumeration value="ProjectSelectionMailingsTask" />
          <xs:enumeration value="QuoteLineSelectionMailingsTask" />
          <xs:enumeration value="TopPanelNewMenu" />
          <xs:enumeration value="Dashboard" />
          <xs:enumeration value="PersonArchive" />
          <xs:enumeration value="PersonMinicard" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="Navigation" nillable="true" type="tns:Navigation" />
      <xs:element name="GenerateNavigationUrl">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="VisibleIn" type="tns:Navigation" />
            <xs:element minOccurs="0" name="WindowName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GenerateNavigationUrlResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWebPanelList">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWebPanelListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfWebPanelEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfWebPanelEntity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="WebPanelEntity" nillable="true" type="tns:WebPanelEntity" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfWebPanelEntity" nillable="true" type="tns:ArrayOfWebPanelEntity" />
      <xs:element name="DeleteWebPanel">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteWebPanelResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppWebPanels">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppWebPanelsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfWebPanelEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteAppWebPanels">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteAppWebPanelsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWebPanelByProgId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProgId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWebPanelByProgIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WebPanelEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetExtAppEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ExtAppEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetExtAppEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ExtAppEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ExtAppEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ExtAppId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="Filename" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Parameters" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Workdir" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ShowState" type="tns:ShowState" />
              <xs:element minOccurs="0" name="VisibleIn" type="tns:Navigation" />
              <xs:element minOccurs="0" name="OnCentral" type="xs:boolean" />
              <xs:element minOccurs="0" name="OnSatellite" type="xs:boolean" />
              <xs:element minOccurs="0" name="OnTravel" type="xs:boolean" />
              <xs:element minOccurs="0" name="OnSalesMarketingPocket" type="xs:boolean" />
              <xs:element minOccurs="0" name="ShowInMenuBar" type="xs:boolean" />
              <xs:element minOccurs="0" name="ShowInToolBar" type="xs:boolean" />
              <xs:element minOccurs="0" name="ShowInAddressBar" type="xs:boolean" />
              <xs:element minOccurs="0" name="ShowInStatusBar" type="xs:boolean" />
              <xs:element minOccurs="0" name="Icon" type="xs:short" />
              <xs:element minOccurs="0" name="WaitToFinish" type="xs:boolean" />
              <xs:element minOccurs="0" name="ExecuteOnEvent" type="tns:ExecuteOnEvent" />
              <xs:element minOccurs="0" name="Path" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ExtAppEntity" nillable="true" type="tns:ExtAppEntity" />
      <xs:simpleType name="ShowState">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="Maximized" />
              <xs:enumeration value="Default" />
              <xs:enumeration value="UndefinedValue4" />
              <xs:enumeration value="UndefinedValue8" />
              <xs:enumeration value="UndefinedValue16" />
              <xs:enumeration value="UndefinedValue32" />
              <xs:enumeration value="UndefinedValue64" />
              <xs:enumeration value="UndefinedValue128" />
              <xs:enumeration value="ToolBar" />
              <xs:enumeration value="AddressBar" />
              <xs:enumeration value="StatusBar" />
              <xs:enumeration value="MenuBar" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="ShowState" nillable="true" type="tns:ShowState" />
      <xs:simpleType name="ExecuteOnEvent">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Never" />
          <xs:enumeration value="Logon" />
          <xs:enumeration value="Logoff" />
          <xs:enumeration value="LocalUpdate" />
          <xs:enumeration value="Wait">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">16384</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ExecuteOnEvent" nillable="true" type="tns:ExecuteOnEvent" />
      <xs:element name="GetDocumentTemplateEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentTemplateEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplateEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentTemplateEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="DocumentTemplateEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SaveInDb" type="xs:short" />
              <xs:element minOccurs="0" name="Filename" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DefaultOref" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RecordType" type="tns:DocTmplType" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="Direction" type="tns:DocTmplDirection" />
              <xs:element minOccurs="0" name="AutoeventId" type="xs:int" />
              <xs:element minOccurs="0" name="IntentId" type="xs:int" />
              <xs:element minOccurs="0" name="IsDefaultPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="LoadTemplateFromPlugin" type="xs:int" />
              <xs:element minOccurs="0" name="MimeType" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsInUseInGuides" type="xs:boolean" />
              <xs:element minOccurs="0" name="DocumentTypeKey" type="xs:int" />
              <xs:element minOccurs="0" name="QuoteDocType" type="tns:DocTmplQuoteType" />
              <xs:element minOccurs="0" name="PrivacyDocType" type="tns:DocTmplPrivacyType" />
              <xs:element minOccurs="0" name="EmailSubject" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DocumentTemplateEntity" nillable="true" type="tns:DocumentTemplateEntity" />
      <xs:simpleType name="DocTmplType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Appointment" />
          <xs:enumeration value="Document" />
          <xs:enumeration value="Email" />
          <xs:enumeration value="Fax" />
          <xs:enumeration value="Phone" />
          <xs:enumeration value="Todo" />
          <xs:enumeration value="MergeDraft" />
          <xs:enumeration value="MergeFinal" />
          <xs:enumeration value="SavedReport" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="DocTmplType" nillable="true" type="tns:DocTmplType" />
      <xs:simpleType name="DocTmplDirection">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Incoming" />
          <xs:enumeration value="Outgoing" />
          <xs:enumeration value="SaintAll" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="DocTmplDirection" nillable="true" type="tns:DocTmplDirection" />
      <xs:simpleType name="DocTmplQuoteType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="MailBody" />
          <xs:enumeration value="MainDocument" />
          <xs:enumeration value="QuoteLines" />
          <xs:enumeration value="ConfirmationMailBody" />
          <xs:enumeration value="ConfirmationLines" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="DocTmplQuoteType" nillable="true" type="tns:DocTmplQuoteType" />
      <xs:simpleType name="DocTmplPrivacyType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="PersonRegistered" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="DocTmplPrivacyType" nillable="true" type="tns:DocTmplPrivacyType" />
      <xs:element name="SetDocumentTemplateStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentTemplateEntity" nillable="true" type="tns:DocumentTemplateEntity" />
            <xs:element minOccurs="0" name="Stream" nillable="true" type="xs:base64Binary" />
            <xs:element minOccurs="0" name="LanguageCode" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PluginId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDocumentTemplateStreamResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentTemplateEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplateUsedInSalesStage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplateUsedInSalesStageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q8:ArrayOfstring" xmlns:q8="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplateUsedInProjectStage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplateUsedInProjectStageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q9:ArrayOfstring" xmlns:q9="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplateUrl">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
            <xs:element minOccurs="0" name="WritableUrl" type="xs:boolean" />
            <xs:element minOccurs="0" name="LanguageCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplateUrlResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplateProperties">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
            <xs:element minOccurs="0" name="RequestedProperties" nillable="true" type="q10:ArrayOfstring" xmlns:q10="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplatePropertiesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:StringDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="StringDictionary">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="StringKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="xs:string" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="StringDictionary" nillable="true" type="tns:StringDictionary" />
      <xs:element name="GetDocumentTemplateLanguages">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplateLanguagesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q11:ArrayOfstring" xmlns:q11="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultDocumentTemplateLanguage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
            <xs:element minOccurs="0" name="LanguageCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultDocumentTemplateLanguageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDocumentTemplateLanguage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
            <xs:element minOccurs="0" name="LanguageCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDocumentTemplateLanguageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplateExtension">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplateExtensionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDocumentTemplateFromDocumentTemplate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SourceDocumentTemplateId" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentTemplateEntity" nillable="true" type="tns:DocumentTemplateEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDocumentTemplateFromDocumentTemplateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentTemplateEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplateStreamFromId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
            <xs:element minOccurs="0" name="LanguageCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplateStreamFromIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDocumentTemplateStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
            <xs:element minOccurs="0" name="Content" nillable="true" type="xs:base64Binary" />
            <xs:element minOccurs="0" name="LanguageCode" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PluginId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDocumentTemplateStreamResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TemplateInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="TemplateInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ExternalReference" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="PluginId" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TemplateInfo" nillable="true" type="tns:TemplateInfo" />
      <xs:element name="GetPluginList">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPluginListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:StringDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPluginCapabilities">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PluginId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPluginCapabilitiesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:StringDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTypesForPlugin">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PluginId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTypesForPluginResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:IntStringDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="IntStringDictionary">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="IntStringKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" type="xs:int" />
                <xs:element name="Value" nillable="true" type="xs:string" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="IntStringDictionary" nillable="true" type="tns:IntStringDictionary" />
      <xs:element name="GetRelationDefinitionEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RelationDefinitionEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRelationDefinitionEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:RelationDefinitionEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="RelationDefinitionEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ReldefId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PassiveText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Source" type="tns:RelationTarget" />
              <xs:element minOccurs="0" name="Destination" type="tns:RelationTarget" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="RelationDefinitionEntity" nillable="true" type="tns:RelationDefinitionEntity" />
      <xs:simpleType name="RelationTarget">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Contact" />
          <xs:enumeration value="Person" />
          <xs:enumeration value="Both" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RelationTarget" nillable="true" type="tns:RelationTarget" />
      <xs:element name="SaveQuickReplies">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuickReplies" nillable="true" type="tns:ArrayOfQuickReply" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfQuickReply">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="QuickReply" nillable="true" type="tns:QuickReply" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfQuickReply" nillable="true" type="tns:ArrayOfQuickReply" />
      <xs:complexType name="QuickReply">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="QuickReplyId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="HtmlBody" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="QuickReply" nillable="true" type="tns:QuickReply" />
      <xs:element name="SaveQuickRepliesResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuickReplies">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuickRepliesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfQuickReply" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConsentPurpose">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConsentPurposeId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConsentPurposeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ConsentPurpose" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ConsentPurpose">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ConsentPurposeId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ConsentText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FormText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Key" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Active" type="xs:short" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="PrivacyStatementDesc" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PrivacyStatementUrl" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ConsentPurpose" nillable="true" type="tns:ConsentPurpose" />
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
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Associate" nillable="true" type="tns:Associate" />
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
      <xs:element name="SaveConsentPurpose">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConsentPurpose" nillable="true" type="tns:ConsentPurpose" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveConsentPurposeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ConsentPurpose" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetEmarketingStrictMode">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Enable" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetEmarketingStrictModeResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEmarketingStrictMode">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEmarketingStrictModeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConsentPurposeList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConsentPurposeIds" nillable="true" type="q12:ArrayOfint" xmlns:q12="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConsentPurposeListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfConsentPurpose" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfConsentPurpose">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ConsentPurpose" nillable="true" type="tns:ConsentPurpose" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfConsentPurpose" nillable="true" type="tns:ArrayOfConsentPurpose" />
      <xs:element name="GetConsentPurposes">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConsentPurposesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfConsentPurpose" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConsentSource">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConsentSourceId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConsentSourceResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ConsentSource" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ConsentSource">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ConsentSourceId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Key" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MailTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ConsentSource" nillable="true" type="tns:ConsentSource" />
      <xs:element name="SaveConsentSource">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConsentSource" nillable="true" type="tns:ConsentSource" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveConsentSourceResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ConsentSource" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllConsentSource">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllConsentSourceResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfConsentSource" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfConsentSource">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ConsentSource" nillable="true" type="tns:ConsentSource" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfConsentSource" nillable="true" type="tns:ArrayOfConsentSource" />
      <xs:element name="GetConsentSourceList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConsentSourceIds" nillable="true" type="q13:ArrayOfint" xmlns:q13="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConsentSourceListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfConsentSource" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConsentSources">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConsentSourcesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfConsentSource" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLegalBase">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LegalBaseId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLegalBaseResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:LegalBase" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="LegalBase">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="LegalBaseId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Key" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="LegalBase" nillable="true" type="tns:LegalBase" />
      <xs:element name="SaveLegalBase">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LegalBase" nillable="true" type="tns:LegalBase" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveLegalBaseResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:LegalBase" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllLegalBase">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllLegalBaseResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfLegalBase" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfLegalBase">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="LegalBase" nillable="true" type="tns:LegalBase" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLegalBase" nillable="true" type="tns:ArrayOfLegalBase" />
      <xs:element name="GetLegalBaseList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LegalBaseIds" nillable="true" type="q14:ArrayOfint" xmlns:q14="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLegalBaseListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfLegalBase" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLegalBases">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLegalBasesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfLegalBase" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveListItemEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ListItemEntity" nillable="true" type="tns:ListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ListItemEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ListItemEntity" nillable="true" type="tns:ListItemEntity" />
      <xs:element name="SaveListItemEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SortListItems">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="CultureName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SortListItemsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="MoveListItem">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="ListItemId" type="xs:int" />
            <xs:element minOccurs="0" name="Direction" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MoveListItemResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetVisibleForUserGroups">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="ListItemId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetVisibleForUserGroupsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetVisibleForUserGroupsFromListName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ListItemId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetVisibleForUserGroupsFromListNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetVisibleForUserGroups">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="ListItemId" type="xs:int" />
            <xs:element minOccurs="0" name="UserGroups" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetVisibleForUserGroupsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetVisibleForUserGroupsFromListName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ListItemId" type="xs:int" />
            <xs:element minOccurs="0" name="UserGroups" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetVisibleForUserGroupsFromListNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetVisibleForUserGroup">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="ListItemId" type="xs:int" />
            <xs:element minOccurs="0" name="UserGroupId" nillable="true" type="q15:ArrayOfint" xmlns:q15="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Enable" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetVisibleForUserGroupResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListItemsForUserGroup">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="GroupId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListItemsForUserGroupResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListItemsForUserGroupFromListName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="GroupId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListItemsForUserGroupFromListNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetListItemsForUserGroup">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="UsergroupId" type="xs:int" />
            <xs:element minOccurs="0" name="ListItemIds" nillable="true" type="q16:ArrayOfint" xmlns:q16="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Enable" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetListItemsForUserGroupResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetListItemsForUserGroupFromListName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="UsergroupId" type="xs:int" />
            <xs:element minOccurs="0" name="ListItemsID" nillable="true" type="q17:ArrayOfint" xmlns:q17="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Enable" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetListItemsForUserGroupFromListNameResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetHeadings">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="ListItemId" type="xs:int" />
            <xs:element minOccurs="0" name="ShowDeleted" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetHeadingsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetHeadingsForListItemFromListName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ListItemId" type="xs:int" />
            <xs:element minOccurs="0" name="ShowDeleted" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetHeadingsForListItemFromListNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveHeadingsForListItemFromListDefinition">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="ListItemId" type="xs:int" />
            <xs:element minOccurs="0" name="Headings" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveHeadingsForListItemFromListDefinitionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveHeadingsForListItemFromListName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ListItemId" type="xs:int" />
            <xs:element minOccurs="0" name="Headings" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveHeadingsForListItemFromListNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListItemsForHeading">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="HeadingId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListItemsForHeadingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListItemsForHeadingFromListName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="HeadingId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListItemsForHeadingFromListNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetListItemsForHeading">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="HeadingId" type="xs:int" />
            <xs:element minOccurs="0" name="ListItemIds" nillable="true" type="q18:ArrayOfint" xmlns:q18="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Enable" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetListItemsForHeadingResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetListItemsForHeadingFromListName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="HeadingId" type="xs:int" />
            <xs:element minOccurs="0" name="ListItemIds" nillable="true" type="q19:ArrayOfint" xmlns:q19="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Enable" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetListItemsForHeadingFromListNameResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetHeadingsForListItem">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="ListItemId" type="xs:int" />
            <xs:element minOccurs="0" name="HeadingIds" nillable="true" type="q20:ArrayOfint" xmlns:q20="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Enable" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetHeadingsForListItemResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetRankOnHeadings">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="HeadingIds" nillable="true" type="q21:ArrayOfint" xmlns:q21="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetRankOnHeadingsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetRankOnSaleActivity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleTypeStageLinkId" type="xs:int" />
            <xs:element minOccurs="0" name="ItemsIds" nillable="true" type="q22:ArrayOfint" xmlns:q22="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetRankOnSaleActivityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetRankOnSaleDocument">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleTypeStageLinkId" type="xs:int" />
            <xs:element minOccurs="0" name="ItemsIds" nillable="true" type="q23:ArrayOfint" xmlns:q23="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetRankOnSaleDocumentResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetRankOnProjectActivity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectTypeStatusLinkId" type="xs:int" />
            <xs:element minOccurs="0" name="ItemsIds" nillable="true" type="q24:ArrayOfint" xmlns:q24="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetRankOnProjectActivityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetRankOnProjectDocument">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectTypeStatusLinkId" type="xs:int" />
            <xs:element minOccurs="0" name="ItemsIds" nillable="true" type="q25:ArrayOfint" xmlns:q25="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetRankOnProjectDocumentResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllFromListDefinition">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeDeleted" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllFromListDefinitionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfListItemEntity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ListItemEntity" nillable="true" type="tns:ListItemEntity" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfListItemEntity" nillable="true" type="tns:ArrayOfListItemEntity" />
      <xs:element name="GetAllFromListName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="IncludeDeleted" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllFromListNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveAllFromListDefinition">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="Items" nillable="true" type="tns:ArrayOfListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveAllFromListDefinitionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveAllFromListName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Items" nillable="true" type="tns:ArrayOfListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveAllFromListNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddFromListDefinition">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="Item" nillable="true" type="tns:ListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddFromListDefinitionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddFromListName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Item" nillable="true" type="tns:ListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddFromListNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteAllFromListDefinition">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteAllFromListDefinitionResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteAllFromListName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteAllFromListNameResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFromListDefinition">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFromListDefinitionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFromListName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="UdListDefinitionName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFromListNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveFromListDefinition">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
            <xs:element minOccurs="0" name="Item" nillable="true" type="tns:ListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveFromListDefinitionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveFromListName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="UdListDefinitionName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Item" nillable="true" type="tns:ListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveFromListNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteFromListDefinition">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteFromListDefinitionResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteFromListName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="UdListDefinitionName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteFromListNameResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetHeadingsFromName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetHeadingsFromNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfHeadingEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfHeadingEntity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="HeadingEntity" nillable="true" type="tns:HeadingEntity" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfHeadingEntity" nillable="true" type="tns:ArrayOfHeadingEntity" />
      <xs:complexType name="HeadingEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="HeadingId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="HeadingEntity" nillable="true" type="tns:HeadingEntity" />
      <xs:element name="GetHeadingsFromListDefinition">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetHeadingsFromListDefinitionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfHeadingEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveHeadingsFromName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Entities" nillable="true" type="tns:ArrayOfHeadingEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveHeadingsFromNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfHeadingEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveHeadingsFromListDefinition">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="Entities" nillable="true" type="tns:ArrayOfHeadingEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveHeadingsFromListDefinitionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfHeadingEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveHeadingFromName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Entity" nillable="true" type="tns:HeadingEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveHeadingFromNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:HeadingEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveHeadingFromListDefinition">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="Entity" nillable="true" type="tns:HeadingEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveHeadingFromListDefinitionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:HeadingEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteAllHeadingsFromName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteAllHeadingsFromNameResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteAllHeadingsFromListDefinition">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteAllHeadingsFromListDefinitionResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLocalizedText">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LocalizedTextId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLocalizedTextResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:LocalizedText" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="LocalizedText">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="LanguageId" type="xs:int" />
              <xs:element minOccurs="0" name="ResourceId" type="xs:int" />
              <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Type" type="tns:LocalizedTextType" />
              <xs:element minOccurs="0" name="LocalizedTextId" type="xs:int" />
              <xs:element minOccurs="0" name="IsBuiltIn" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="LocalizedText" nillable="true" type="tns:LocalizedText" />
      <xs:simpleType name="LocalizedTextType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Label" />
          <xs:enumeration value="Table" />
          <xs:enumeration value="Column" />
          <xs:enumeration value="ImportField" />
          <xs:enumeration value="ImportObject" />
          <xs:enumeration value="ImportGUICategory" />
          <xs:enumeration value="StartupHints" />
          <xs:enumeration value="FunctionRightLabel">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">11</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="FunctionRightDesc">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">12</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="StatusMonitorName">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">16</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="UdefContactLabel">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">19</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="UdefPersonLabel">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">20</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="UdefProjectLabel">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">21</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="UdefSaleLabel">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">22</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="UdefAppointmentLabel">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">23</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="UdefDocumentLabel">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">24</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="PushNotificationText">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">41</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="LocalizedTextType" nillable="true" type="tns:LocalizedTextType" />
      <xs:element name="GetLocalizedTextByType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TextType" type="tns:LocalizedTextType" />
            <xs:element minOccurs="0" name="ResourceId" type="xs:int" />
            <xs:element minOccurs="0" name="LanguageId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLocalizedTextByTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:LocalizedText" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLocalizedTextList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LocalizedTextIds" nillable="true" type="q26:ArrayOfint" xmlns:q26="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLocalizedTextListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfLocalizedText" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfLocalizedText">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="LocalizedText" nillable="true" type="tns:LocalizedText" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLocalizedText" nillable="true" type="tns:ArrayOfLocalizedText" />
      <xs:element name="GetLocalizedTexts">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLocalizedTextsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfLocalizedText" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLocalizedTextsByLanguageId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LanguageId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLocalizedTextsByLanguageIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfLocalizedText" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLocalizedTextsByType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TextTypes" nillable="true" type="tns:ArrayOfLocalizedTextType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfLocalizedTextType">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="LocalizedTextType" type="tns:LocalizedTextType" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLocalizedTextType" nillable="true" type="tns:ArrayOfLocalizedTextType" />
      <xs:element name="GetLocalizedTextsByTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfLocalizedText" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMrMrs">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MrMrsId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMrMrsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:MrMrs" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="MrMrs">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="MrMrs" nillable="true" type="tns:MrMrs" />
      <xs:element name="GetMrMrsList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MrMrsIds" nillable="true" type="q27:ArrayOfint" xmlns:q27="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMrMrsListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfMrMrs" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfMrMrs">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="MrMrs" nillable="true" type="tns:MrMrs" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfMrMrs" nillable="true" type="tns:ArrayOfMrMrs" />
      <xs:element name="GetMrMrses">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMrMrsesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfMrMrs" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPosition">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PositionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPositionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Position" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Position">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Position" nillable="true" type="tns:Position" />
      <xs:element name="GetPositionList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PositionIds" nillable="true" type="q28:ArrayOfint" xmlns:q28="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPositionListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPosition" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfPosition">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Position" nillable="true" type="tns:Position" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfPosition" nillable="true" type="tns:ArrayOfPosition" />
      <xs:element name="GetPositions">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPositionsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPosition" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPriority">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PriorityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPriorityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Priority" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Priority">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Priority" nillable="true" type="tns:Priority" />
      <xs:element name="GetPriorityList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PriorityIds" nillable="true" type="q29:ArrayOfint" xmlns:q29="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPriorityListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPriority" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfPriority">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Priority" nillable="true" type="tns:Priority" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfPriority" nillable="true" type="tns:ArrayOfPriority" />
      <xs:element name="GetPriorities">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPrioritiesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPriority" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProductCategory">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProductCategoryId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProductCategoryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ProductCategory" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ProductCategory">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ProductCategory" nillable="true" type="tns:ProductCategory" />
      <xs:element name="GetProductCategories">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProductCategoriesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfProductCategory" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfProductCategory">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ProductCategory" nillable="true" type="tns:ProductCategory" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfProductCategory" nillable="true" type="tns:ArrayOfProductCategory" />
      <xs:element name="GetProductFamily">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProductFamilyId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProductFamilyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ProductFamily" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ProductFamily">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ProductFamily" nillable="true" type="tns:ProductFamily" />
      <xs:element name="GetProductFamilies">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProductFamiliesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfProductFamily" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfProductFamily">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ProductFamily" nillable="true" type="tns:ProductFamily" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfProductFamily" nillable="true" type="tns:ArrayOfProductFamily" />
      <xs:element name="GetProductType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProductTypeId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProductTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ProductType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ProductType">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ProductType" nillable="true" type="tns:ProductType" />
      <xs:element name="GetProductTypes">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProductTypesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfProductType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfProductType">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ProductType" nillable="true" type="tns:ProductType" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfProductType" nillable="true" type="tns:ArrayOfProductType" />
      <xs:element name="GetProjectStatus">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectStatusId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectStatusResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ProjectStatus" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ProjectStatus">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ProjectStatus" nillable="true" type="tns:ProjectStatus" />
      <xs:element name="DeleteProjectStatus">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectStatusId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteProjectStatusResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectStatusList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectStatusIds" nillable="true" type="q30:ArrayOfint" xmlns:q30="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectStatusListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfProjectStatus" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfProjectStatus">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ProjectStatus" nillable="true" type="tns:ProjectStatus" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfProjectStatus" nillable="true" type="tns:ArrayOfProjectStatus" />
      <xs:element name="GetProjectStatuses">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectStatusesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfProjectStatus" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectTypeId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ProjectType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ProjectType">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ProjectType" nillable="true" type="tns:ProjectType" />
      <xs:element name="GetProjectTypeEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectTypeEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectTypeEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ProjectTypeEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ProjectTypeEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ProjTypeId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="DurationUnit" type="tns:DurationUnit" />
              <xs:element minOccurs="0" name="ProjectDuration" type="xs:int" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="HasGuide" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsAutoAdvance" type="xs:boolean" />
              <xs:element minOccurs="0" name="Stages" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ProjectTypeEntity" nillable="true" type="tns:ProjectTypeEntity" />
      <xs:element name="GetProjectTypeList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectTypeIds" nillable="true" type="q31:ArrayOfint" xmlns:q31="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectTypeListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfProjectType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfProjectType">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ProjectType" nillable="true" type="tns:ProjectType" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfProjectType" nillable="true" type="tns:ArrayOfProjectType" />
      <xs:element name="GetProjectTypes">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectTypesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfProjectType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRating">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RatingId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRatingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Rating" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Rating">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Rating" nillable="true" type="tns:Rating" />
      <xs:element name="GetRatingList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RatingIds" nillable="true" type="q32:ArrayOfint" xmlns:q32="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRatingListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfRating" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfRating">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Rating" nillable="true" type="tns:Rating" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfRating" nillable="true" type="tns:ArrayOfRating" />
      <xs:element name="GetRatings">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRatingsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfRating" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllSaleStages">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="IncludeDeleted" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllSaleStagesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSaleStageEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfSaleStageEntity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="SaleStageEntity" nillable="true" type="tns:SaleStageEntity" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfSaleStageEntity" nillable="true" type="tns:ArrayOfSaleStageEntity" />
      <xs:element name="GetReason">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReasonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetReasonResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Reason" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Reason">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Reason" nillable="true" type="tns:Reason" />
      <xs:element name="GetReasonList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReasonIds" nillable="true" type="q33:ArrayOfint" xmlns:q33="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetReasonListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfReason" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfReason">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Reason" nillable="true" type="tns:Reason" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfReason" nillable="true" type="tns:ArrayOfReason" />
      <xs:element name="GetReasons">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetReasonsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfReason" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetReasonSold">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReasonSoldId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetReasonSoldResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReasonSold" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultCurrencyEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultCurrencyEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CurrencyEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CurrencyEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="CurrencyId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Rate" type="xs:double" />
              <xs:element minOccurs="0" name="Units" type="xs:double" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CurrencyEntity" nillable="true" type="tns:CurrencyEntity" />
      <xs:element name="SaveCurrencyEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CurrencyEntity" nillable="true" type="tns:CurrencyEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCurrencyEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CurrencyEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAmountClassEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAmountClassEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:AmountClassEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="AmountClassEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="AmountClassId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="AmountFrom" type="xs:double" />
              <xs:element minOccurs="0" name="AmountTo" type="xs:double" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="CurrencyId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AmountClassEntity" nillable="true" type="tns:AmountClassEntity" />
      <xs:element name="SaveAmountClassEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AmountClassEntity" nillable="true" type="tns:AmountClassEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveAmountClassEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:AmountClassEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultHeadingEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultHeadingEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:HeadingEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveHeadingEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="HeadingEntity" nillable="true" type="tns:HeadingEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveHeadingEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:HeadingEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultListEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultListEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ListEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ListEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="IsCustomList" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsMDOList" type="xs:boolean" />
              <xs:element minOccurs="0" name="UseGroupsAndHeadings" type="xs:boolean" />
              <xs:element minOccurs="0" name="ListType" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="InUseByUserDefinedFields" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ListEntity" nillable="true" type="tns:ListEntity" />
      <xs:element name="SaveListEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ListEntity" nillable="true" type="tns:ListEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveListEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ListEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteListEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ListEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteListEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultListItemEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultListItemEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ListItemEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultProjectTypeEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultProjectTypeEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ProjectTypeEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveProjectTypeEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectTypeEntity" nillable="true" type="tns:ProjectTypeEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveProjectTypeEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ProjectTypeEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultResourceEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultResourceEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ResourceEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveResourceEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ResourceEntity" nillable="true" type="tns:ResourceEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveResourceEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ResourceEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteResourceEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ResourceEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteResourceEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultSaleStageEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultSaleStageEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SaleStageEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveSaleStageEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleStageEntity" nillable="true" type="tns:SaleStageEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveSaleStageEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SaleStageEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultSaleTypeEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultSaleTypeEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SaleTypeEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveSaleTypeEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleTypeEntity" nillable="true" type="tns:SaleTypeEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveSaleTypeEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SaleTypeEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultWebPanelEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultWebPanelEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WebPanelEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveWebPanelEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WebPanelEntity" nillable="true" type="tns:WebPanelEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveWebPanelEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WebPanelEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultExtAppEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultExtAppEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ExtAppEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveExtAppEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ExtAppEntity" nillable="true" type="tns:ExtAppEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveExtAppEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ExtAppEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultDocumentTemplateEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultDocumentTemplateEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentTemplateEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDocumentTemplateEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentTemplateEntity" nillable="true" type="tns:DocumentTemplateEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDocumentTemplateEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentTemplateEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultRelationDefinitionEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultRelationDefinitionEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:RelationDefinitionEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveRelationDefinitionEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RelationDefinitionEntity" nillable="true" type="tns:RelationDefinitionEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveRelationDefinitionEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:RelationDefinitionEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBusiness">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BusinessId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBusinessResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Business" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Business">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Business" nillable="true" type="tns:Business" />
      <xs:element name="GetBusinessList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BusinessIds" nillable="true" type="q34:ArrayOfint" xmlns:q34="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBusinessListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfBusiness" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfBusiness">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Business" nillable="true" type="tns:Business" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfBusiness" nillable="true" type="tns:ArrayOfBusiness" />
      <xs:element name="GetBusinesses">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBusinessesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfBusiness" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCategory">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CategoryId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCategoryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Category" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Category">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Category" nillable="true" type="tns:Category" />
      <xs:element name="GetCategoryList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CategoryIds" nillable="true" type="q35:ArrayOfint" xmlns:q35="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCategoryListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCategory" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfCategory">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Category" nillable="true" type="tns:Category" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCategory" nillable="true" type="tns:ArrayOfCategory" />
      <xs:element name="GetCategories">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCategoriesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCategory" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCompetitor">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CompetitorId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCompetitorResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Competitor" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Competitor">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Competitor" nillable="true" type="tns:Competitor" />
      <xs:element name="GetCompetitorList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CompetitorIds" nillable="true" type="q36:ArrayOfint" xmlns:q36="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCompetitorListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCompetitor" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfCompetitor">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Competitor" nillable="true" type="tns:Competitor" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCompetitor" nillable="true" type="tns:ArrayOfCompetitor" />
      <xs:element name="GetCompetitors">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCompetitorsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCompetitor" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCountry">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CountryId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCountryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Country" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Country">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="CountryId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CurrencyId" type="xs:int" />
              <xs:element minOccurs="0" name="EnglishName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TwoLetterISOCountry" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ThreeLetterISOCountry" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ImageDescription" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OrgNrText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="InterAreaPrefix" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DialInPrefix" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ZipPrefix" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DomainName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AddressLayoutId" type="xs:int" />
              <xs:element minOccurs="0" name="DomesticAddressLayoutId" type="xs:int" />
              <xs:element minOccurs="0" name="ForeignAddressLayoutId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Country" nillable="true" type="tns:Country" />
      <xs:element name="SaveCountry">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Country" nillable="true" type="tns:Country" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCountryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Country" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultCountry">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultCountryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Country" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCountryList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CountryIds" nillable="true" type="q37:ArrayOfint" xmlns:q37="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCountryListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCountry" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfCountry">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Country" nillable="true" type="tns:Country" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCountry" nillable="true" type="tns:ArrayOfCountry" />
      <xs:element name="GetCountries">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCountriesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCountry" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllCountries">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="IncludeDeleted" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllCountriesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCountry" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCredited">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CreditedId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCreditedResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Credited" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Credited">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Credited" nillable="true" type="tns:Credited" />
      <xs:element name="GetCreditedList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CreditedIds" nillable="true" type="q38:ArrayOfint" xmlns:q38="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCreditedListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCredited" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfCredited">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Credited" nillable="true" type="tns:Credited" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCredited" nillable="true" type="tns:ArrayOfCredited" />
      <xs:element name="GetCrediteds">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCreditedsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCredited" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCurrency">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CurrencyId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCurrencyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Currency" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Currency">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Currency" nillable="true" type="tns:Currency" />
      <xs:element name="GetOurCurrency">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetOurCurrencyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Currency" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeCurrency">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Amount" type="xs:double" />
            <xs:element minOccurs="0" name="FromCurrency" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ToCurrency" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeCurrencyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:double" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetOwnerCompanysCurrency">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetOwnerCompanysCurrencyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Currency" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCurrencyEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CurrencyEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCurrencyEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CurrencyEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBaseCurrency">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBaseCurrencyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CurrencyEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAmountClassEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AmountClassEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAmountClassEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:AmountClassEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCurrencyList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CurrencyIds" nillable="true" type="q39:ArrayOfint" xmlns:q39="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCurrencyListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCurrency" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfCurrency">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Currency" nillable="true" type="tns:Currency" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCurrency" nillable="true" type="tns:ArrayOfCurrency" />
      <xs:element name="GetCurrencies">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCurrenciesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCurrency" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllCurrencies">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="IncludeDeleted" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllCurrenciesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCurrencyEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfCurrencyEntity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="CurrencyEntity" nillable="true" type="tns:CurrencyEntity" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCurrencyEntity" nillable="true" type="tns:ArrayOfCurrencyEntity" />
      <xs:element name="GetCustomerLanguage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CustomerLanguageId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCustomerLanguageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CustomerLanguage" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CustomerLanguage">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CustomerLanguage" nillable="true" type="tns:CustomerLanguage" />
      <xs:element name="GetCustomerLanguageList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CustomerLanguageIds" nillable="true" type="q40:ArrayOfint" xmlns:q40="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCustomerLanguageListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCustomerLanguage" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfCustomerLanguage">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="CustomerLanguage" nillable="true" type="tns:CustomerLanguage" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCustomerLanguage" nillable="true" type="tns:ArrayOfCustomerLanguage" />
      <xs:element name="GetCustomerLanguages">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCustomerLanguagesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCustomerLanguage" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDeliveryTerm">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DeliveryTermId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDeliveryTermResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DeliveryTerm" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="DeliveryTerm">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DeliveryTerm" nillable="true" type="tns:DeliveryTerm" />
      <xs:element name="GetDeliveryTerms">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDeliveryTermsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDeliveryTerm" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDeliveryTerm">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DeliveryTerm" nillable="true" type="tns:DeliveryTerm" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDeliveryTerm" nillable="true" type="tns:ArrayOfDeliveryTerm" />
      <xs:element name="GetDeliveryType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DeliveryTypeId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDeliveryTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DeliveryType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="DeliveryType">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DeliveryType" nillable="true" type="tns:DeliveryType" />
      <xs:element name="GetDeliveryTypes">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDeliveryTypesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDeliveryType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDeliveryType">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DeliveryType" nillable="true" type="tns:DeliveryType" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDeliveryType" nillable="true" type="tns:ArrayOfDeliveryType" />
      <xs:element name="GetPaymentTerm">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PaymentTermId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPaymentTermResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PaymentTerm" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="PaymentTerm">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PaymentTerm" nillable="true" type="tns:PaymentTerm" />
      <xs:element name="GetPaymentTerms">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPaymentTermsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPaymentTerm" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfPaymentTerm">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="PaymentTerm" nillable="true" type="tns:PaymentTerm" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfPaymentTerm" nillable="true" type="tns:ArrayOfPaymentTerm" />
      <xs:element name="GetPaymentType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PaymentTypeId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPaymentTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PaymentType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="PaymentType">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PaymentType" nillable="true" type="tns:PaymentType" />
      <xs:element name="GetPaymentTypes">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPaymentTypesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPaymentType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfPaymentType">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="PaymentType" nillable="true" type="tns:PaymentType" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfPaymentType" nillable="true" type="tns:ArrayOfPaymentType" />
      <xs:element name="GetDepartment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DepartmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDepartmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Department" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Department">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Department" nillable="true" type="tns:Department" />
      <xs:element name="GetDepartmentList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DepartmentIds" nillable="true" type="q41:ArrayOfint" xmlns:q41="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDepartmentListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDepartment" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDepartment">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Department" nillable="true" type="tns:Department" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDepartment" nillable="true" type="tns:ArrayOfDepartment" />
      <xs:element name="GetDepartments">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDepartmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDepartment" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentTemplate" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="DocumentTemplate">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SaveInDb" type="xs:short" />
              <xs:element minOccurs="0" name="Filename" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DefaultOref" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RecordType" type="tns:DocTmplType" />
              <xs:element minOccurs="0" name="Deleted" type="xs:short" />
              <xs:element minOccurs="0" name="Direction" type="tns:DocTmplDirection" />
              <xs:element minOccurs="0" name="AutoeventId" type="xs:int" />
              <xs:element minOccurs="0" name="QuoteDocType" type="tns:DocTmplQuoteType" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DocumentTemplate" nillable="true" type="tns:DocumentTemplate" />
      <xs:element name="GetDocumentTemplateList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentTemplateIds" nillable="true" type="q42:ArrayOfint" xmlns:q42="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplateListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocumentTemplate" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDocumentTemplate">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DocumentTemplate" nillable="true" type="tns:DocumentTemplate" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDocumentTemplate" nillable="true" type="tns:ArrayOfDocumentTemplate" />
      <xs:element name="GetDocumentTemplates">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentTemplatesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocumentTemplate" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllDocumentTemplates">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="IncludeDeleted" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllDocumentTemplatesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocumentTemplateEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDocumentTemplateEntity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DocumentTemplateEntity" nillable="true" type="tns:DocumentTemplateEntity" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDocumentTemplateEntity" nillable="true" type="tns:ArrayOfDocumentTemplateEntity" />
      <xs:element name="GetHeadingEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="HeadingEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetHeadingEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:HeadingEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultHeadingFromListDefinition">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UdListDefinitionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultHeadingFromListDefinitionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:HeadingEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLanguageInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LanguageInfoId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLanguageInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:LanguageInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="LanguageInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="LanguageInfoId" type="xs:int" />
              <xs:element minOccurs="0" name="LCID" type="xs:int" />
              <xs:element minOccurs="0" name="EnglishName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="NativeName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ThreeLetterISOLanguageName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TwoLetterISOLanguageName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsBuiltIn" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="LanguageInfo" nillable="true" type="tns:LanguageInfo" />
      <xs:element name="GetLanguageInfoList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LanguageInfoIds" nillable="true" type="q43:ArrayOfint" xmlns:q43="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLanguageInfoListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfLanguageInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfLanguageInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="LanguageInfo" nillable="true" type="tns:LanguageInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLanguageInfo" nillable="true" type="tns:ArrayOfLanguageInfo" />
      <xs:element name="GetInstalledLanguages">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetInstalledLanguagesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfLanguageInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLink">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LinkId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLinkResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Link" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Link">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="EntityName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="LinkId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Link" nillable="true" type="tns:Link" />
      <xs:element name="GetLinkList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LinkIds" nillable="true" type="q44:ArrayOfint" xmlns:q44="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLinkListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfLink" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfLink">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Link" nillable="true" type="tns:Link" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLink" nillable="true" type="tns:ArrayOfLink" />
      <xs:element name="GetListEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ListEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ListEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListDefinitions">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="IncludeDeleted" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListDefinitionsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfListEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfListEntity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ListEntity" nillable="true" type="tns:ListEntity" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfListEntity" nillable="true" type="tns:ArrayOfListEntity" />
      <xs:element name="GetListEntityByName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetListEntityByNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ListEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveListEntityByName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ListEntity" nillable="true" type="tns:ListEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveListEntityByNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ListEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteListEntityByName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteListEntityByNameResponse">
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
      <xs:complexType name="ArrayOfstring">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="string" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfstring" nillable="true" type="tns:ArrayOfstring" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="GetAllReasonSoldRequest">
    <wsdl:part name="parameters" element="tns:GetAllReasonSold" />
  </wsdl:message>
  <wsdl:message name="GetAllReasonSoldRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllReasonSoldResponse">
    <wsdl:part name="parameters" element="tns:GetAllReasonSoldResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllReasonSoldResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReasonSoldListRequest">
    <wsdl:part name="parameters" element="tns:GetReasonSoldList" />
  </wsdl:message>
  <wsdl:message name="GetReasonSoldListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReasonSoldListResponse">
    <wsdl:part name="parameters" element="tns:GetReasonSoldListResponse" />
  </wsdl:message>
  <wsdl:message name="GetReasonSoldListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReasonStalledRequest">
    <wsdl:part name="parameters" element="tns:GetReasonStalled" />
  </wsdl:message>
  <wsdl:message name="GetReasonStalledRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReasonStalledResponse">
    <wsdl:part name="parameters" element="tns:GetReasonStalledResponse" />
  </wsdl:message>
  <wsdl:message name="GetReasonStalledResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllReasonStalledRequest">
    <wsdl:part name="parameters" element="tns:GetAllReasonStalled" />
  </wsdl:message>
  <wsdl:message name="GetAllReasonStalledRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllReasonStalledResponse">
    <wsdl:part name="parameters" element="tns:GetAllReasonStalledResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllReasonStalledResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReasonStalledListRequest">
    <wsdl:part name="parameters" element="tns:GetReasonStalledList" />
  </wsdl:message>
  <wsdl:message name="GetReasonStalledListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReasonStalledListResponse">
    <wsdl:part name="parameters" element="tns:GetReasonStalledListResponse" />
  </wsdl:message>
  <wsdl:message name="GetReasonStalledListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetResourceEntityRequest">
    <wsdl:part name="parameters" element="tns:GetResourceEntity" />
  </wsdl:message>
  <wsdl:message name="GetResourceEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetResourceEntityResponse">
    <wsdl:part name="parameters" element="tns:GetResourceEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetResourceEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleStageEntityRequest">
    <wsdl:part name="parameters" element="tns:GetSaleStageEntity" />
  </wsdl:message>
  <wsdl:message name="GetSaleStageEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleStageEntityResponse">
    <wsdl:part name="parameters" element="tns:GetSaleStageEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetSaleStageEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleTypeRequest">
    <wsdl:part name="parameters" element="tns:GetSaleType" />
  </wsdl:message>
  <wsdl:message name="GetSaleTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleTypeResponse">
    <wsdl:part name="parameters" element="tns:GetSaleTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetSaleTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleTypeEntityRequest">
    <wsdl:part name="parameters" element="tns:GetSaleTypeEntity" />
  </wsdl:message>
  <wsdl:message name="GetSaleTypeEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleTypeEntityResponse">
    <wsdl:part name="parameters" element="tns:GetSaleTypeEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetSaleTypeEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllSaleTypeRequest">
    <wsdl:part name="parameters" element="tns:GetAllSaleType" />
  </wsdl:message>
  <wsdl:message name="GetAllSaleTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllSaleTypeResponse">
    <wsdl:part name="parameters" element="tns:GetAllSaleTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllSaleTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleTypeListRequest">
    <wsdl:part name="parameters" element="tns:GetSaleTypeList" />
  </wsdl:message>
  <wsdl:message name="GetSaleTypeListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleTypeListResponse">
    <wsdl:part name="parameters" element="tns:GetSaleTypeListResponse" />
  </wsdl:message>
  <wsdl:message name="GetSaleTypeListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectionCategoryRequest">
    <wsdl:part name="parameters" element="tns:GetSelectionCategory" />
  </wsdl:message>
  <wsdl:message name="GetSelectionCategoryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectionCategoryResponse">
    <wsdl:part name="parameters" element="tns:GetSelectionCategoryResponse" />
  </wsdl:message>
  <wsdl:message name="GetSelectionCategoryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllSelectionCategoryRequest">
    <wsdl:part name="parameters" element="tns:GetAllSelectionCategory" />
  </wsdl:message>
  <wsdl:message name="GetAllSelectionCategoryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllSelectionCategoryResponse">
    <wsdl:part name="parameters" element="tns:GetAllSelectionCategoryResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllSelectionCategoryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectionCategoryListRequest">
    <wsdl:part name="parameters" element="tns:GetSelectionCategoryList" />
  </wsdl:message>
  <wsdl:message name="GetSelectionCategoryListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectionCategoryListResponse">
    <wsdl:part name="parameters" element="tns:GetSelectionCategoryListResponse" />
  </wsdl:message>
  <wsdl:message name="GetSelectionCategoryListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSourceRequest">
    <wsdl:part name="parameters" element="tns:GetSource" />
  </wsdl:message>
  <wsdl:message name="GetSourceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSourceResponse">
    <wsdl:part name="parameters" element="tns:GetSourceResponse" />
  </wsdl:message>
  <wsdl:message name="GetSourceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSourceListRequest">
    <wsdl:part name="parameters" element="tns:GetSourceList" />
  </wsdl:message>
  <wsdl:message name="GetSourceListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSourceListResponse">
    <wsdl:part name="parameters" element="tns:GetSourceListResponse" />
  </wsdl:message>
  <wsdl:message name="GetSourceListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSourcesRequest">
    <wsdl:part name="parameters" element="tns:GetSources" />
  </wsdl:message>
  <wsdl:message name="GetSourcesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSourcesResponse">
    <wsdl:part name="parameters" element="tns:GetSourcesResponse" />
  </wsdl:message>
  <wsdl:message name="GetSourcesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTaskRequest">
    <wsdl:part name="parameters" element="tns:GetTask" />
  </wsdl:message>
  <wsdl:message name="GetTaskRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTaskResponse">
    <wsdl:part name="parameters" element="tns:GetTaskResponse" />
  </wsdl:message>
  <wsdl:message name="GetTaskResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateTaskRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateTask" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateTaskRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateTaskResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateTaskResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateTaskResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTaskListRequest">
    <wsdl:part name="parameters" element="tns:GetTaskList" />
  </wsdl:message>
  <wsdl:message name="GetTaskListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTaskListResponse">
    <wsdl:part name="parameters" element="tns:GetTaskListResponse" />
  </wsdl:message>
  <wsdl:message name="GetTaskListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTasksRequest">
    <wsdl:part name="parameters" element="tns:GetTasks" />
  </wsdl:message>
  <wsdl:message name="GetTasksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTasksResponse">
    <wsdl:part name="parameters" element="tns:GetTasksResponse" />
  </wsdl:message>
  <wsdl:message name="GetTasksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplatesTasksRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplatesTasks" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplatesTasksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplatesTasksResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplatesTasksResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplatesTasksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllTasksRequest">
    <wsdl:part name="parameters" element="tns:GetAllTasks" />
  </wsdl:message>
  <wsdl:message name="GetAllTasksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllTasksResponse">
    <wsdl:part name="parameters" element="tns:GetAllTasksResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllTasksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketPriorityRequest">
    <wsdl:part name="parameters" element="tns:GetTicketPriority" />
  </wsdl:message>
  <wsdl:message name="GetTicketPriorityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketPriorityResponse">
    <wsdl:part name="parameters" element="tns:GetTicketPriorityResponse" />
  </wsdl:message>
  <wsdl:message name="GetTicketPriorityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketPriorityListRequest">
    <wsdl:part name="parameters" element="tns:GetTicketPriorityList" />
  </wsdl:message>
  <wsdl:message name="GetTicketPriorityListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketPriorityListResponse">
    <wsdl:part name="parameters" element="tns:GetTicketPriorityListResponse" />
  </wsdl:message>
  <wsdl:message name="GetTicketPriorityListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketPrioritiesRequest">
    <wsdl:part name="parameters" element="tns:GetTicketPriorities" />
  </wsdl:message>
  <wsdl:message name="GetTicketPrioritiesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketPrioritiesResponse">
    <wsdl:part name="parameters" element="tns:GetTicketPrioritiesResponse" />
  </wsdl:message>
  <wsdl:message name="GetTicketPrioritiesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWebPanelEntityRequest">
    <wsdl:part name="parameters" element="tns:GetWebPanelEntity" />
  </wsdl:message>
  <wsdl:message name="GetWebPanelEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWebPanelEntityResponse">
    <wsdl:part name="parameters" element="tns:GetWebPanelEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetWebPanelEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GenerateNavigationUrlRequest">
    <wsdl:part name="parameters" element="tns:GenerateNavigationUrl" />
  </wsdl:message>
  <wsdl:message name="GenerateNavigationUrlRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GenerateNavigationUrlResponse">
    <wsdl:part name="parameters" element="tns:GenerateNavigationUrlResponse" />
  </wsdl:message>
  <wsdl:message name="GenerateNavigationUrlResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWebPanelListRequest">
    <wsdl:part name="parameters" element="tns:GetWebPanelList" />
  </wsdl:message>
  <wsdl:message name="GetWebPanelListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWebPanelListResponse">
    <wsdl:part name="parameters" element="tns:GetWebPanelListResponse" />
  </wsdl:message>
  <wsdl:message name="GetWebPanelListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteWebPanelRequest">
    <wsdl:part name="parameters" element="tns:DeleteWebPanel" />
  </wsdl:message>
  <wsdl:message name="DeleteWebPanelRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteWebPanelResponse">
    <wsdl:part name="parameters" element="tns:DeleteWebPanelResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteWebPanelResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppWebPanelsRequest">
    <wsdl:part name="parameters" element="tns:GetAppWebPanels" />
  </wsdl:message>
  <wsdl:message name="GetAppWebPanelsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppWebPanelsResponse">
    <wsdl:part name="parameters" element="tns:GetAppWebPanelsResponse" />
  </wsdl:message>
  <wsdl:message name="GetAppWebPanelsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteAppWebPanelsRequest">
    <wsdl:part name="parameters" element="tns:DeleteAppWebPanels" />
  </wsdl:message>
  <wsdl:message name="DeleteAppWebPanelsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteAppWebPanelsResponse">
    <wsdl:part name="parameters" element="tns:DeleteAppWebPanelsResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteAppWebPanelsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWebPanelByProgIdRequest">
    <wsdl:part name="parameters" element="tns:GetWebPanelByProgId" />
  </wsdl:message>
  <wsdl:message name="GetWebPanelByProgIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWebPanelByProgIdResponse">
    <wsdl:part name="parameters" element="tns:GetWebPanelByProgIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetWebPanelByProgIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetExtAppEntityRequest">
    <wsdl:part name="parameters" element="tns:GetExtAppEntity" />
  </wsdl:message>
  <wsdl:message name="GetExtAppEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetExtAppEntityResponse">
    <wsdl:part name="parameters" element="tns:GetExtAppEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetExtAppEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateEntityRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateEntity" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateEntityResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDocumentTemplateStreamRequest">
    <wsdl:part name="parameters" element="tns:SetDocumentTemplateStream" />
  </wsdl:message>
  <wsdl:message name="SetDocumentTemplateStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDocumentTemplateStreamResponse">
    <wsdl:part name="parameters" element="tns:SetDocumentTemplateStreamResponse" />
  </wsdl:message>
  <wsdl:message name="SetDocumentTemplateStreamResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateUsedInSalesStageRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateUsedInSalesStage" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateUsedInSalesStageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateUsedInSalesStageResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateUsedInSalesStageResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateUsedInSalesStageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateUsedInProjectStageRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateUsedInProjectStage" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateUsedInProjectStageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateUsedInProjectStageResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateUsedInProjectStageResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateUsedInProjectStageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateUrlRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateUrl" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateUrlRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateUrlResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateUrlResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateUrlResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplatePropertiesRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateProperties" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplatePropertiesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplatePropertiesResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplatePropertiesResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplatePropertiesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateLanguagesRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateLanguages" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateLanguagesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateLanguagesResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateLanguagesResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateLanguagesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentTemplateLanguageRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultDocumentTemplateLanguage" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentTemplateLanguageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentTemplateLanguageResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultDocumentTemplateLanguageResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentTemplateLanguageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDocumentTemplateLanguageRequest">
    <wsdl:part name="parameters" element="tns:DeleteDocumentTemplateLanguage" />
  </wsdl:message>
  <wsdl:message name="DeleteDocumentTemplateLanguageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDocumentTemplateLanguageResponse">
    <wsdl:part name="parameters" element="tns:DeleteDocumentTemplateLanguageResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteDocumentTemplateLanguageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateExtensionRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateExtension" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateExtensionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateExtensionResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateExtensionResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateExtensionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDocumentTemplateFromDocumentTemplateRequest">
    <wsdl:part name="parameters" element="tns:SetDocumentTemplateFromDocumentTemplate" />
  </wsdl:message>
  <wsdl:message name="SetDocumentTemplateFromDocumentTemplateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDocumentTemplateFromDocumentTemplateResponse">
    <wsdl:part name="parameters" element="tns:SetDocumentTemplateFromDocumentTemplateResponse" />
  </wsdl:message>
  <wsdl:message name="SetDocumentTemplateFromDocumentTemplateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateStreamFromIdRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateStreamFromId" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateStreamFromIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateStreamFromIdResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateStreamFromIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateStreamFromIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDocumentTemplateStreamRequest">
    <wsdl:part name="parameters" element="tns:SaveDocumentTemplateStream" />
  </wsdl:message>
  <wsdl:message name="SaveDocumentTemplateStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDocumentTemplateStreamResponse">
    <wsdl:part name="parameters" element="tns:SaveDocumentTemplateStreamResponse" />
  </wsdl:message>
  <wsdl:message name="SaveDocumentTemplateStreamResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPluginListRequest">
    <wsdl:part name="parameters" element="tns:GetPluginList" />
  </wsdl:message>
  <wsdl:message name="GetPluginListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPluginListResponse">
    <wsdl:part name="parameters" element="tns:GetPluginListResponse" />
  </wsdl:message>
  <wsdl:message name="GetPluginListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPluginCapabilitiesRequest">
    <wsdl:part name="parameters" element="tns:GetPluginCapabilities" />
  </wsdl:message>
  <wsdl:message name="GetPluginCapabilitiesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPluginCapabilitiesResponse">
    <wsdl:part name="parameters" element="tns:GetPluginCapabilitiesResponse" />
  </wsdl:message>
  <wsdl:message name="GetPluginCapabilitiesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTypesForPluginRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentTypesForPlugin" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTypesForPluginRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTypesForPluginResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentTypesForPluginResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTypesForPluginResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRelationDefinitionEntityRequest">
    <wsdl:part name="parameters" element="tns:GetRelationDefinitionEntity" />
  </wsdl:message>
  <wsdl:message name="GetRelationDefinitionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRelationDefinitionEntityResponse">
    <wsdl:part name="parameters" element="tns:GetRelationDefinitionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetRelationDefinitionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuickRepliesRequest">
    <wsdl:part name="parameters" element="tns:SaveQuickReplies" />
  </wsdl:message>
  <wsdl:message name="SaveQuickRepliesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuickRepliesResponse">
    <wsdl:part name="parameters" element="tns:SaveQuickRepliesResponse" />
  </wsdl:message>
  <wsdl:message name="SaveQuickRepliesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuickRepliesRequest">
    <wsdl:part name="parameters" element="tns:GetQuickReplies" />
  </wsdl:message>
  <wsdl:message name="GetQuickRepliesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuickRepliesResponse">
    <wsdl:part name="parameters" element="tns:GetQuickRepliesResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuickRepliesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConsentPurposeRequest">
    <wsdl:part name="parameters" element="tns:GetConsentPurpose" />
  </wsdl:message>
  <wsdl:message name="GetConsentPurposeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConsentPurposeResponse">
    <wsdl:part name="parameters" element="tns:GetConsentPurposeResponse" />
  </wsdl:message>
  <wsdl:message name="GetConsentPurposeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveConsentPurposeRequest">
    <wsdl:part name="parameters" element="tns:SaveConsentPurpose" />
  </wsdl:message>
  <wsdl:message name="SaveConsentPurposeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveConsentPurposeResponse">
    <wsdl:part name="parameters" element="tns:SaveConsentPurposeResponse" />
  </wsdl:message>
  <wsdl:message name="SaveConsentPurposeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetEmarketingStrictModeRequest">
    <wsdl:part name="parameters" element="tns:SetEmarketingStrictMode" />
  </wsdl:message>
  <wsdl:message name="SetEmarketingStrictModeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetEmarketingStrictModeResponse">
    <wsdl:part name="parameters" element="tns:SetEmarketingStrictModeResponse" />
  </wsdl:message>
  <wsdl:message name="SetEmarketingStrictModeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEmarketingStrictModeRequest">
    <wsdl:part name="parameters" element="tns:GetEmarketingStrictMode" />
  </wsdl:message>
  <wsdl:message name="GetEmarketingStrictModeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEmarketingStrictModeResponse">
    <wsdl:part name="parameters" element="tns:GetEmarketingStrictModeResponse" />
  </wsdl:message>
  <wsdl:message name="GetEmarketingStrictModeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConsentPurposeListRequest">
    <wsdl:part name="parameters" element="tns:GetConsentPurposeList" />
  </wsdl:message>
  <wsdl:message name="GetConsentPurposeListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConsentPurposeListResponse">
    <wsdl:part name="parameters" element="tns:GetConsentPurposeListResponse" />
  </wsdl:message>
  <wsdl:message name="GetConsentPurposeListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConsentPurposesRequest">
    <wsdl:part name="parameters" element="tns:GetConsentPurposes" />
  </wsdl:message>
  <wsdl:message name="GetConsentPurposesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConsentPurposesResponse">
    <wsdl:part name="parameters" element="tns:GetConsentPurposesResponse" />
  </wsdl:message>
  <wsdl:message name="GetConsentPurposesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConsentSourceRequest">
    <wsdl:part name="parameters" element="tns:GetConsentSource" />
  </wsdl:message>
  <wsdl:message name="GetConsentSourceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConsentSourceResponse">
    <wsdl:part name="parameters" element="tns:GetConsentSourceResponse" />
  </wsdl:message>
  <wsdl:message name="GetConsentSourceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveConsentSourceRequest">
    <wsdl:part name="parameters" element="tns:SaveConsentSource" />
  </wsdl:message>
  <wsdl:message name="SaveConsentSourceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveConsentSourceResponse">
    <wsdl:part name="parameters" element="tns:SaveConsentSourceResponse" />
  </wsdl:message>
  <wsdl:message name="SaveConsentSourceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllConsentSourceRequest">
    <wsdl:part name="parameters" element="tns:GetAllConsentSource" />
  </wsdl:message>
  <wsdl:message name="GetAllConsentSourceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllConsentSourceResponse">
    <wsdl:part name="parameters" element="tns:GetAllConsentSourceResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllConsentSourceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConsentSourceListRequest">
    <wsdl:part name="parameters" element="tns:GetConsentSourceList" />
  </wsdl:message>
  <wsdl:message name="GetConsentSourceListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConsentSourceListResponse">
    <wsdl:part name="parameters" element="tns:GetConsentSourceListResponse" />
  </wsdl:message>
  <wsdl:message name="GetConsentSourceListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConsentSourcesRequest">
    <wsdl:part name="parameters" element="tns:GetConsentSources" />
  </wsdl:message>
  <wsdl:message name="GetConsentSourcesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConsentSourcesResponse">
    <wsdl:part name="parameters" element="tns:GetConsentSourcesResponse" />
  </wsdl:message>
  <wsdl:message name="GetConsentSourcesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLegalBaseRequest">
    <wsdl:part name="parameters" element="tns:GetLegalBase" />
  </wsdl:message>
  <wsdl:message name="GetLegalBaseRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLegalBaseResponse">
    <wsdl:part name="parameters" element="tns:GetLegalBaseResponse" />
  </wsdl:message>
  <wsdl:message name="GetLegalBaseResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveLegalBaseRequest">
    <wsdl:part name="parameters" element="tns:SaveLegalBase" />
  </wsdl:message>
  <wsdl:message name="SaveLegalBaseRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveLegalBaseResponse">
    <wsdl:part name="parameters" element="tns:SaveLegalBaseResponse" />
  </wsdl:message>
  <wsdl:message name="SaveLegalBaseResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllLegalBaseRequest">
    <wsdl:part name="parameters" element="tns:GetAllLegalBase" />
  </wsdl:message>
  <wsdl:message name="GetAllLegalBaseRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllLegalBaseResponse">
    <wsdl:part name="parameters" element="tns:GetAllLegalBaseResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllLegalBaseResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLegalBaseListRequest">
    <wsdl:part name="parameters" element="tns:GetLegalBaseList" />
  </wsdl:message>
  <wsdl:message name="GetLegalBaseListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLegalBaseListResponse">
    <wsdl:part name="parameters" element="tns:GetLegalBaseListResponse" />
  </wsdl:message>
  <wsdl:message name="GetLegalBaseListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLegalBasesRequest">
    <wsdl:part name="parameters" element="tns:GetLegalBases" />
  </wsdl:message>
  <wsdl:message name="GetLegalBasesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLegalBasesResponse">
    <wsdl:part name="parameters" element="tns:GetLegalBasesResponse" />
  </wsdl:message>
  <wsdl:message name="GetLegalBasesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveListItemEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveListItemEntity" />
  </wsdl:message>
  <wsdl:message name="SaveListItemEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveListItemEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveListItemEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveListItemEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SortListItemsRequest">
    <wsdl:part name="parameters" element="tns:SortListItems" />
  </wsdl:message>
  <wsdl:message name="SortListItemsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SortListItemsResponse">
    <wsdl:part name="parameters" element="tns:SortListItemsResponse" />
  </wsdl:message>
  <wsdl:message name="SortListItemsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveListItemRequest">
    <wsdl:part name="parameters" element="tns:MoveListItem" />
  </wsdl:message>
  <wsdl:message name="MoveListItemRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveListItemResponse">
    <wsdl:part name="parameters" element="tns:MoveListItemResponse" />
  </wsdl:message>
  <wsdl:message name="MoveListItemResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetVisibleForUserGroupsRequest">
    <wsdl:part name="parameters" element="tns:GetVisibleForUserGroups" />
  </wsdl:message>
  <wsdl:message name="GetVisibleForUserGroupsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetVisibleForUserGroupsResponse">
    <wsdl:part name="parameters" element="tns:GetVisibleForUserGroupsResponse" />
  </wsdl:message>
  <wsdl:message name="GetVisibleForUserGroupsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetVisibleForUserGroupsFromListNameRequest">
    <wsdl:part name="parameters" element="tns:GetVisibleForUserGroupsFromListName" />
  </wsdl:message>
  <wsdl:message name="GetVisibleForUserGroupsFromListNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetVisibleForUserGroupsFromListNameResponse">
    <wsdl:part name="parameters" element="tns:GetVisibleForUserGroupsFromListNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetVisibleForUserGroupsFromListNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetVisibleForUserGroupsRequest">
    <wsdl:part name="parameters" element="tns:SetVisibleForUserGroups" />
  </wsdl:message>
  <wsdl:message name="SetVisibleForUserGroupsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetVisibleForUserGroupsResponse">
    <wsdl:part name="parameters" element="tns:SetVisibleForUserGroupsResponse" />
  </wsdl:message>
  <wsdl:message name="SetVisibleForUserGroupsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetVisibleForUserGroupsFromListNameRequest">
    <wsdl:part name="parameters" element="tns:SetVisibleForUserGroupsFromListName" />
  </wsdl:message>
  <wsdl:message name="SetVisibleForUserGroupsFromListNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetVisibleForUserGroupsFromListNameResponse">
    <wsdl:part name="parameters" element="tns:SetVisibleForUserGroupsFromListNameResponse" />
  </wsdl:message>
  <wsdl:message name="SetVisibleForUserGroupsFromListNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetVisibleForUserGroupRequest">
    <wsdl:part name="parameters" element="tns:SetVisibleForUserGroup" />
  </wsdl:message>
  <wsdl:message name="SetVisibleForUserGroupRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetVisibleForUserGroupResponse">
    <wsdl:part name="parameters" element="tns:SetVisibleForUserGroupResponse" />
  </wsdl:message>
  <wsdl:message name="SetVisibleForUserGroupResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListItemsForUserGroupRequest">
    <wsdl:part name="parameters" element="tns:GetListItemsForUserGroup" />
  </wsdl:message>
  <wsdl:message name="GetListItemsForUserGroupRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListItemsForUserGroupResponse">
    <wsdl:part name="parameters" element="tns:GetListItemsForUserGroupResponse" />
  </wsdl:message>
  <wsdl:message name="GetListItemsForUserGroupResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListItemsForUserGroupFromListNameRequest">
    <wsdl:part name="parameters" element="tns:GetListItemsForUserGroupFromListName" />
  </wsdl:message>
  <wsdl:message name="GetListItemsForUserGroupFromListNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListItemsForUserGroupFromListNameResponse">
    <wsdl:part name="parameters" element="tns:GetListItemsForUserGroupFromListNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetListItemsForUserGroupFromListNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetListItemsForUserGroupRequest">
    <wsdl:part name="parameters" element="tns:SetListItemsForUserGroup" />
  </wsdl:message>
  <wsdl:message name="SetListItemsForUserGroupRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetListItemsForUserGroupResponse">
    <wsdl:part name="parameters" element="tns:SetListItemsForUserGroupResponse" />
  </wsdl:message>
  <wsdl:message name="SetListItemsForUserGroupResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetListItemsForUserGroupFromListNameRequest">
    <wsdl:part name="parameters" element="tns:SetListItemsForUserGroupFromListName" />
  </wsdl:message>
  <wsdl:message name="SetListItemsForUserGroupFromListNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetListItemsForUserGroupFromListNameResponse">
    <wsdl:part name="parameters" element="tns:SetListItemsForUserGroupFromListNameResponse" />
  </wsdl:message>
  <wsdl:message name="SetListItemsForUserGroupFromListNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHeadingsRequest">
    <wsdl:part name="parameters" element="tns:GetHeadings" />
  </wsdl:message>
  <wsdl:message name="GetHeadingsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHeadingsResponse">
    <wsdl:part name="parameters" element="tns:GetHeadingsResponse" />
  </wsdl:message>
  <wsdl:message name="GetHeadingsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHeadingsForListItemFromListNameRequest">
    <wsdl:part name="parameters" element="tns:GetHeadingsForListItemFromListName" />
  </wsdl:message>
  <wsdl:message name="GetHeadingsForListItemFromListNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHeadingsForListItemFromListNameResponse">
    <wsdl:part name="parameters" element="tns:GetHeadingsForListItemFromListNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetHeadingsForListItemFromListNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingsForListItemFromListDefinitionRequest">
    <wsdl:part name="parameters" element="tns:SaveHeadingsForListItemFromListDefinition" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingsForListItemFromListDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingsForListItemFromListDefinitionResponse">
    <wsdl:part name="parameters" element="tns:SaveHeadingsForListItemFromListDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingsForListItemFromListDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingsForListItemFromListNameRequest">
    <wsdl:part name="parameters" element="tns:SaveHeadingsForListItemFromListName" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingsForListItemFromListNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingsForListItemFromListNameResponse">
    <wsdl:part name="parameters" element="tns:SaveHeadingsForListItemFromListNameResponse" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingsForListItemFromListNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListItemsForHeadingRequest">
    <wsdl:part name="parameters" element="tns:GetListItemsForHeading" />
  </wsdl:message>
  <wsdl:message name="GetListItemsForHeadingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListItemsForHeadingResponse">
    <wsdl:part name="parameters" element="tns:GetListItemsForHeadingResponse" />
  </wsdl:message>
  <wsdl:message name="GetListItemsForHeadingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListItemsForHeadingFromListNameRequest">
    <wsdl:part name="parameters" element="tns:GetListItemsForHeadingFromListName" />
  </wsdl:message>
  <wsdl:message name="GetListItemsForHeadingFromListNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListItemsForHeadingFromListNameResponse">
    <wsdl:part name="parameters" element="tns:GetListItemsForHeadingFromListNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetListItemsForHeadingFromListNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetListItemsForHeadingRequest">
    <wsdl:part name="parameters" element="tns:SetListItemsForHeading" />
  </wsdl:message>
  <wsdl:message name="SetListItemsForHeadingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetListItemsForHeadingResponse">
    <wsdl:part name="parameters" element="tns:SetListItemsForHeadingResponse" />
  </wsdl:message>
  <wsdl:message name="SetListItemsForHeadingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetListItemsForHeadingFromListNameRequest">
    <wsdl:part name="parameters" element="tns:SetListItemsForHeadingFromListName" />
  </wsdl:message>
  <wsdl:message name="SetListItemsForHeadingFromListNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetListItemsForHeadingFromListNameResponse">
    <wsdl:part name="parameters" element="tns:SetListItemsForHeadingFromListNameResponse" />
  </wsdl:message>
  <wsdl:message name="SetListItemsForHeadingFromListNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetHeadingsForListItemRequest">
    <wsdl:part name="parameters" element="tns:SetHeadingsForListItem" />
  </wsdl:message>
  <wsdl:message name="SetHeadingsForListItemRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetHeadingsForListItemResponse">
    <wsdl:part name="parameters" element="tns:SetHeadingsForListItemResponse" />
  </wsdl:message>
  <wsdl:message name="SetHeadingsForListItemResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetRankOnHeadingsRequest">
    <wsdl:part name="parameters" element="tns:SetRankOnHeadings" />
  </wsdl:message>
  <wsdl:message name="SetRankOnHeadingsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetRankOnHeadingsResponse">
    <wsdl:part name="parameters" element="tns:SetRankOnHeadingsResponse" />
  </wsdl:message>
  <wsdl:message name="SetRankOnHeadingsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetRankOnSaleActivityRequest">
    <wsdl:part name="parameters" element="tns:SetRankOnSaleActivity" />
  </wsdl:message>
  <wsdl:message name="SetRankOnSaleActivityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetRankOnSaleActivityResponse">
    <wsdl:part name="parameters" element="tns:SetRankOnSaleActivityResponse" />
  </wsdl:message>
  <wsdl:message name="SetRankOnSaleActivityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetRankOnSaleDocumentRequest">
    <wsdl:part name="parameters" element="tns:SetRankOnSaleDocument" />
  </wsdl:message>
  <wsdl:message name="SetRankOnSaleDocumentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetRankOnSaleDocumentResponse">
    <wsdl:part name="parameters" element="tns:SetRankOnSaleDocumentResponse" />
  </wsdl:message>
  <wsdl:message name="SetRankOnSaleDocumentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetRankOnProjectActivityRequest">
    <wsdl:part name="parameters" element="tns:SetRankOnProjectActivity" />
  </wsdl:message>
  <wsdl:message name="SetRankOnProjectActivityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetRankOnProjectActivityResponse">
    <wsdl:part name="parameters" element="tns:SetRankOnProjectActivityResponse" />
  </wsdl:message>
  <wsdl:message name="SetRankOnProjectActivityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetRankOnProjectDocumentRequest">
    <wsdl:part name="parameters" element="tns:SetRankOnProjectDocument" />
  </wsdl:message>
  <wsdl:message name="SetRankOnProjectDocumentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetRankOnProjectDocumentResponse">
    <wsdl:part name="parameters" element="tns:SetRankOnProjectDocumentResponse" />
  </wsdl:message>
  <wsdl:message name="SetRankOnProjectDocumentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllFromListDefinitionRequest">
    <wsdl:part name="parameters" element="tns:GetAllFromListDefinition" />
  </wsdl:message>
  <wsdl:message name="GetAllFromListDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllFromListDefinitionResponse">
    <wsdl:part name="parameters" element="tns:GetAllFromListDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllFromListDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllFromListNameRequest">
    <wsdl:part name="parameters" element="tns:GetAllFromListName" />
  </wsdl:message>
  <wsdl:message name="GetAllFromListNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllFromListNameResponse">
    <wsdl:part name="parameters" element="tns:GetAllFromListNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllFromListNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveAllFromListDefinitionRequest">
    <wsdl:part name="parameters" element="tns:SaveAllFromListDefinition" />
  </wsdl:message>
  <wsdl:message name="SaveAllFromListDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveAllFromListDefinitionResponse">
    <wsdl:part name="parameters" element="tns:SaveAllFromListDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="SaveAllFromListDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveAllFromListNameRequest">
    <wsdl:part name="parameters" element="tns:SaveAllFromListName" />
  </wsdl:message>
  <wsdl:message name="SaveAllFromListNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveAllFromListNameResponse">
    <wsdl:part name="parameters" element="tns:SaveAllFromListNameResponse" />
  </wsdl:message>
  <wsdl:message name="SaveAllFromListNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddFromListDefinitionRequest">
    <wsdl:part name="parameters" element="tns:AddFromListDefinition" />
  </wsdl:message>
  <wsdl:message name="AddFromListDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddFromListDefinitionResponse">
    <wsdl:part name="parameters" element="tns:AddFromListDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="AddFromListDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddFromListNameRequest">
    <wsdl:part name="parameters" element="tns:AddFromListName" />
  </wsdl:message>
  <wsdl:message name="AddFromListNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddFromListNameResponse">
    <wsdl:part name="parameters" element="tns:AddFromListNameResponse" />
  </wsdl:message>
  <wsdl:message name="AddFromListNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteAllFromListDefinitionRequest">
    <wsdl:part name="parameters" element="tns:DeleteAllFromListDefinition" />
  </wsdl:message>
  <wsdl:message name="DeleteAllFromListDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteAllFromListDefinitionResponse">
    <wsdl:part name="parameters" element="tns:DeleteAllFromListDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteAllFromListDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteAllFromListNameRequest">
    <wsdl:part name="parameters" element="tns:DeleteAllFromListName" />
  </wsdl:message>
  <wsdl:message name="DeleteAllFromListNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteAllFromListNameResponse">
    <wsdl:part name="parameters" element="tns:DeleteAllFromListNameResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteAllFromListNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFromListDefinitionRequest">
    <wsdl:part name="parameters" element="tns:GetFromListDefinition" />
  </wsdl:message>
  <wsdl:message name="GetFromListDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFromListDefinitionResponse">
    <wsdl:part name="parameters" element="tns:GetFromListDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="GetFromListDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFromListNameRequest">
    <wsdl:part name="parameters" element="tns:GetFromListName" />
  </wsdl:message>
  <wsdl:message name="GetFromListNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFromListNameResponse">
    <wsdl:part name="parameters" element="tns:GetFromListNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetFromListNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveFromListDefinitionRequest">
    <wsdl:part name="parameters" element="tns:SaveFromListDefinition" />
  </wsdl:message>
  <wsdl:message name="SaveFromListDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveFromListDefinitionResponse">
    <wsdl:part name="parameters" element="tns:SaveFromListDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="SaveFromListDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveFromListNameRequest">
    <wsdl:part name="parameters" element="tns:SaveFromListName" />
  </wsdl:message>
  <wsdl:message name="SaveFromListNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveFromListNameResponse">
    <wsdl:part name="parameters" element="tns:SaveFromListNameResponse" />
  </wsdl:message>
  <wsdl:message name="SaveFromListNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteFromListDefinitionRequest">
    <wsdl:part name="parameters" element="tns:DeleteFromListDefinition" />
  </wsdl:message>
  <wsdl:message name="DeleteFromListDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteFromListDefinitionResponse">
    <wsdl:part name="parameters" element="tns:DeleteFromListDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteFromListDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteFromListNameRequest">
    <wsdl:part name="parameters" element="tns:DeleteFromListName" />
  </wsdl:message>
  <wsdl:message name="DeleteFromListNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteFromListNameResponse">
    <wsdl:part name="parameters" element="tns:DeleteFromListNameResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteFromListNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHeadingsFromNameRequest">
    <wsdl:part name="parameters" element="tns:GetHeadingsFromName" />
  </wsdl:message>
  <wsdl:message name="GetHeadingsFromNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHeadingsFromNameResponse">
    <wsdl:part name="parameters" element="tns:GetHeadingsFromNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetHeadingsFromNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHeadingsFromListDefinitionRequest">
    <wsdl:part name="parameters" element="tns:GetHeadingsFromListDefinition" />
  </wsdl:message>
  <wsdl:message name="GetHeadingsFromListDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHeadingsFromListDefinitionResponse">
    <wsdl:part name="parameters" element="tns:GetHeadingsFromListDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="GetHeadingsFromListDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingsFromNameRequest">
    <wsdl:part name="parameters" element="tns:SaveHeadingsFromName" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingsFromNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingsFromNameResponse">
    <wsdl:part name="parameters" element="tns:SaveHeadingsFromNameResponse" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingsFromNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingsFromListDefinitionRequest">
    <wsdl:part name="parameters" element="tns:SaveHeadingsFromListDefinition" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingsFromListDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingsFromListDefinitionResponse">
    <wsdl:part name="parameters" element="tns:SaveHeadingsFromListDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingsFromListDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingFromNameRequest">
    <wsdl:part name="parameters" element="tns:SaveHeadingFromName" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingFromNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingFromNameResponse">
    <wsdl:part name="parameters" element="tns:SaveHeadingFromNameResponse" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingFromNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingFromListDefinitionRequest">
    <wsdl:part name="parameters" element="tns:SaveHeadingFromListDefinition" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingFromListDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingFromListDefinitionResponse">
    <wsdl:part name="parameters" element="tns:SaveHeadingFromListDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingFromListDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteAllHeadingsFromNameRequest">
    <wsdl:part name="parameters" element="tns:DeleteAllHeadingsFromName" />
  </wsdl:message>
  <wsdl:message name="DeleteAllHeadingsFromNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteAllHeadingsFromNameResponse">
    <wsdl:part name="parameters" element="tns:DeleteAllHeadingsFromNameResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteAllHeadingsFromNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteAllHeadingsFromListDefinitionRequest">
    <wsdl:part name="parameters" element="tns:DeleteAllHeadingsFromListDefinition" />
  </wsdl:message>
  <wsdl:message name="DeleteAllHeadingsFromListDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteAllHeadingsFromListDefinitionResponse">
    <wsdl:part name="parameters" element="tns:DeleteAllHeadingsFromListDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteAllHeadingsFromListDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextRequest">
    <wsdl:part name="parameters" element="tns:GetLocalizedText" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextResponse">
    <wsdl:part name="parameters" element="tns:GetLocalizedTextResponse" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextByTypeRequest">
    <wsdl:part name="parameters" element="tns:GetLocalizedTextByType" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextByTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextByTypeResponse">
    <wsdl:part name="parameters" element="tns:GetLocalizedTextByTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextByTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextListRequest">
    <wsdl:part name="parameters" element="tns:GetLocalizedTextList" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextListResponse">
    <wsdl:part name="parameters" element="tns:GetLocalizedTextListResponse" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextsRequest">
    <wsdl:part name="parameters" element="tns:GetLocalizedTexts" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextsResponse">
    <wsdl:part name="parameters" element="tns:GetLocalizedTextsResponse" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextsByLanguageIdRequest">
    <wsdl:part name="parameters" element="tns:GetLocalizedTextsByLanguageId" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextsByLanguageIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextsByLanguageIdResponse">
    <wsdl:part name="parameters" element="tns:GetLocalizedTextsByLanguageIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextsByLanguageIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextsByTypeRequest">
    <wsdl:part name="parameters" element="tns:GetLocalizedTextsByType" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextsByTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextsByTypeResponse">
    <wsdl:part name="parameters" element="tns:GetLocalizedTextsByTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetLocalizedTextsByTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMrMrsRequest">
    <wsdl:part name="parameters" element="tns:GetMrMrs" />
  </wsdl:message>
  <wsdl:message name="GetMrMrsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMrMrsResponse">
    <wsdl:part name="parameters" element="tns:GetMrMrsResponse" />
  </wsdl:message>
  <wsdl:message name="GetMrMrsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMrMrsListRequest">
    <wsdl:part name="parameters" element="tns:GetMrMrsList" />
  </wsdl:message>
  <wsdl:message name="GetMrMrsListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMrMrsListResponse">
    <wsdl:part name="parameters" element="tns:GetMrMrsListResponse" />
  </wsdl:message>
  <wsdl:message name="GetMrMrsListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMrMrsesRequest">
    <wsdl:part name="parameters" element="tns:GetMrMrses" />
  </wsdl:message>
  <wsdl:message name="GetMrMrsesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMrMrsesResponse">
    <wsdl:part name="parameters" element="tns:GetMrMrsesResponse" />
  </wsdl:message>
  <wsdl:message name="GetMrMrsesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPositionRequest">
    <wsdl:part name="parameters" element="tns:GetPosition" />
  </wsdl:message>
  <wsdl:message name="GetPositionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPositionResponse">
    <wsdl:part name="parameters" element="tns:GetPositionResponse" />
  </wsdl:message>
  <wsdl:message name="GetPositionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPositionListRequest">
    <wsdl:part name="parameters" element="tns:GetPositionList" />
  </wsdl:message>
  <wsdl:message name="GetPositionListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPositionListResponse">
    <wsdl:part name="parameters" element="tns:GetPositionListResponse" />
  </wsdl:message>
  <wsdl:message name="GetPositionListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPositionsRequest">
    <wsdl:part name="parameters" element="tns:GetPositions" />
  </wsdl:message>
  <wsdl:message name="GetPositionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPositionsResponse">
    <wsdl:part name="parameters" element="tns:GetPositionsResponse" />
  </wsdl:message>
  <wsdl:message name="GetPositionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPriorityRequest">
    <wsdl:part name="parameters" element="tns:GetPriority" />
  </wsdl:message>
  <wsdl:message name="GetPriorityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPriorityResponse">
    <wsdl:part name="parameters" element="tns:GetPriorityResponse" />
  </wsdl:message>
  <wsdl:message name="GetPriorityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPriorityListRequest">
    <wsdl:part name="parameters" element="tns:GetPriorityList" />
  </wsdl:message>
  <wsdl:message name="GetPriorityListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPriorityListResponse">
    <wsdl:part name="parameters" element="tns:GetPriorityListResponse" />
  </wsdl:message>
  <wsdl:message name="GetPriorityListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPrioritiesRequest">
    <wsdl:part name="parameters" element="tns:GetPriorities" />
  </wsdl:message>
  <wsdl:message name="GetPrioritiesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPrioritiesResponse">
    <wsdl:part name="parameters" element="tns:GetPrioritiesResponse" />
  </wsdl:message>
  <wsdl:message name="GetPrioritiesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductCategoryRequest">
    <wsdl:part name="parameters" element="tns:GetProductCategory" />
  </wsdl:message>
  <wsdl:message name="GetProductCategoryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductCategoryResponse">
    <wsdl:part name="parameters" element="tns:GetProductCategoryResponse" />
  </wsdl:message>
  <wsdl:message name="GetProductCategoryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductCategoriesRequest">
    <wsdl:part name="parameters" element="tns:GetProductCategories" />
  </wsdl:message>
  <wsdl:message name="GetProductCategoriesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductCategoriesResponse">
    <wsdl:part name="parameters" element="tns:GetProductCategoriesResponse" />
  </wsdl:message>
  <wsdl:message name="GetProductCategoriesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductFamilyRequest">
    <wsdl:part name="parameters" element="tns:GetProductFamily" />
  </wsdl:message>
  <wsdl:message name="GetProductFamilyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductFamilyResponse">
    <wsdl:part name="parameters" element="tns:GetProductFamilyResponse" />
  </wsdl:message>
  <wsdl:message name="GetProductFamilyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductFamiliesRequest">
    <wsdl:part name="parameters" element="tns:GetProductFamilies" />
  </wsdl:message>
  <wsdl:message name="GetProductFamiliesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductFamiliesResponse">
    <wsdl:part name="parameters" element="tns:GetProductFamiliesResponse" />
  </wsdl:message>
  <wsdl:message name="GetProductFamiliesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductTypeRequest">
    <wsdl:part name="parameters" element="tns:GetProductType" />
  </wsdl:message>
  <wsdl:message name="GetProductTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductTypeResponse">
    <wsdl:part name="parameters" element="tns:GetProductTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetProductTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductTypesRequest">
    <wsdl:part name="parameters" element="tns:GetProductTypes" />
  </wsdl:message>
  <wsdl:message name="GetProductTypesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductTypesResponse">
    <wsdl:part name="parameters" element="tns:GetProductTypesResponse" />
  </wsdl:message>
  <wsdl:message name="GetProductTypesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectStatusRequest">
    <wsdl:part name="parameters" element="tns:GetProjectStatus" />
  </wsdl:message>
  <wsdl:message name="GetProjectStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectStatusResponse">
    <wsdl:part name="parameters" element="tns:GetProjectStatusResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectStatusResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectStatusRequest">
    <wsdl:part name="parameters" element="tns:DeleteProjectStatus" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectStatusResponse">
    <wsdl:part name="parameters" element="tns:DeleteProjectStatusResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectStatusResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectStatusListRequest">
    <wsdl:part name="parameters" element="tns:GetProjectStatusList" />
  </wsdl:message>
  <wsdl:message name="GetProjectStatusListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectStatusListResponse">
    <wsdl:part name="parameters" element="tns:GetProjectStatusListResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectStatusListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectStatusesRequest">
    <wsdl:part name="parameters" element="tns:GetProjectStatuses" />
  </wsdl:message>
  <wsdl:message name="GetProjectStatusesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectStatusesResponse">
    <wsdl:part name="parameters" element="tns:GetProjectStatusesResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectStatusesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectTypeRequest">
    <wsdl:part name="parameters" element="tns:GetProjectType" />
  </wsdl:message>
  <wsdl:message name="GetProjectTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectTypeResponse">
    <wsdl:part name="parameters" element="tns:GetProjectTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectTypeEntityRequest">
    <wsdl:part name="parameters" element="tns:GetProjectTypeEntity" />
  </wsdl:message>
  <wsdl:message name="GetProjectTypeEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectTypeEntityResponse">
    <wsdl:part name="parameters" element="tns:GetProjectTypeEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectTypeEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectTypeListRequest">
    <wsdl:part name="parameters" element="tns:GetProjectTypeList" />
  </wsdl:message>
  <wsdl:message name="GetProjectTypeListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectTypeListResponse">
    <wsdl:part name="parameters" element="tns:GetProjectTypeListResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectTypeListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectTypesRequest">
    <wsdl:part name="parameters" element="tns:GetProjectTypes" />
  </wsdl:message>
  <wsdl:message name="GetProjectTypesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectTypesResponse">
    <wsdl:part name="parameters" element="tns:GetProjectTypesResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectTypesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRatingRequest">
    <wsdl:part name="parameters" element="tns:GetRating" />
  </wsdl:message>
  <wsdl:message name="GetRatingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRatingResponse">
    <wsdl:part name="parameters" element="tns:GetRatingResponse" />
  </wsdl:message>
  <wsdl:message name="GetRatingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRatingListRequest">
    <wsdl:part name="parameters" element="tns:GetRatingList" />
  </wsdl:message>
  <wsdl:message name="GetRatingListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRatingListResponse">
    <wsdl:part name="parameters" element="tns:GetRatingListResponse" />
  </wsdl:message>
  <wsdl:message name="GetRatingListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRatingsRequest">
    <wsdl:part name="parameters" element="tns:GetRatings" />
  </wsdl:message>
  <wsdl:message name="GetRatingsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRatingsResponse">
    <wsdl:part name="parameters" element="tns:GetRatingsResponse" />
  </wsdl:message>
  <wsdl:message name="GetRatingsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllSaleStagesRequest">
    <wsdl:part name="parameters" element="tns:GetAllSaleStages" />
  </wsdl:message>
  <wsdl:message name="GetAllSaleStagesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllSaleStagesResponse">
    <wsdl:part name="parameters" element="tns:GetAllSaleStagesResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllSaleStagesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReasonRequest">
    <wsdl:part name="parameters" element="tns:GetReason" />
  </wsdl:message>
  <wsdl:message name="GetReasonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReasonResponse">
    <wsdl:part name="parameters" element="tns:GetReasonResponse" />
  </wsdl:message>
  <wsdl:message name="GetReasonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReasonListRequest">
    <wsdl:part name="parameters" element="tns:GetReasonList" />
  </wsdl:message>
  <wsdl:message name="GetReasonListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReasonListResponse">
    <wsdl:part name="parameters" element="tns:GetReasonListResponse" />
  </wsdl:message>
  <wsdl:message name="GetReasonListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReasonsRequest">
    <wsdl:part name="parameters" element="tns:GetReasons" />
  </wsdl:message>
  <wsdl:message name="GetReasonsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReasonsResponse">
    <wsdl:part name="parameters" element="tns:GetReasonsResponse" />
  </wsdl:message>
  <wsdl:message name="GetReasonsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReasonSoldRequest">
    <wsdl:part name="parameters" element="tns:GetReasonSold" />
  </wsdl:message>
  <wsdl:message name="GetReasonSoldRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReasonSoldResponse">
    <wsdl:part name="parameters" element="tns:GetReasonSoldResponse" />
  </wsdl:message>
  <wsdl:message name="GetReasonSoldResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCurrencyEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultCurrencyEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCurrencyEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCurrencyEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultCurrencyEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCurrencyEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCurrencyEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveCurrencyEntity" />
  </wsdl:message>
  <wsdl:message name="SaveCurrencyEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCurrencyEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveCurrencyEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveCurrencyEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAmountClassEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultAmountClassEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAmountClassEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAmountClassEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultAmountClassEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAmountClassEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveAmountClassEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveAmountClassEntity" />
  </wsdl:message>
  <wsdl:message name="SaveAmountClassEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveAmountClassEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveAmountClassEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveAmountClassEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultHeadingEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultHeadingEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultHeadingEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultHeadingEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultHeadingEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultHeadingEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveHeadingEntity" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveHeadingEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveHeadingEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultListEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultListEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultListEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultListEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultListEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultListEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveListEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveListEntity" />
  </wsdl:message>
  <wsdl:message name="SaveListEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveListEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveListEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveListEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteListEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteListEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteListEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteListEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteListEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteListEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultListItemEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultListItemEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultListItemEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultListItemEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultListItemEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultListItemEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultProjectTypeEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultProjectTypeEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultProjectTypeEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultProjectTypeEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultProjectTypeEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultProjectTypeEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveProjectTypeEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveProjectTypeEntity" />
  </wsdl:message>
  <wsdl:message name="SaveProjectTypeEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveProjectTypeEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveProjectTypeEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveProjectTypeEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultResourceEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultResourceEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultResourceEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultResourceEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultResourceEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultResourceEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveResourceEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveResourceEntity" />
  </wsdl:message>
  <wsdl:message name="SaveResourceEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveResourceEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveResourceEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveResourceEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteResourceEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteResourceEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteResourceEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteResourceEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteResourceEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteResourceEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSaleStageEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultSaleStageEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSaleStageEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSaleStageEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultSaleStageEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSaleStageEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSaleStageEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveSaleStageEntity" />
  </wsdl:message>
  <wsdl:message name="SaveSaleStageEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSaleStageEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveSaleStageEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveSaleStageEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSaleTypeEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultSaleTypeEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSaleTypeEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSaleTypeEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultSaleTypeEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSaleTypeEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSaleTypeEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveSaleTypeEntity" />
  </wsdl:message>
  <wsdl:message name="SaveSaleTypeEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSaleTypeEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveSaleTypeEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveSaleTypeEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWebPanelEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultWebPanelEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWebPanelEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWebPanelEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultWebPanelEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWebPanelEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveWebPanelEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveWebPanelEntity" />
  </wsdl:message>
  <wsdl:message name="SaveWebPanelEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveWebPanelEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveWebPanelEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveWebPanelEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultExtAppEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultExtAppEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultExtAppEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultExtAppEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultExtAppEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultExtAppEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveExtAppEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveExtAppEntity" />
  </wsdl:message>
  <wsdl:message name="SaveExtAppEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveExtAppEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveExtAppEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveExtAppEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentTemplateEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultDocumentTemplateEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentTemplateEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentTemplateEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultDocumentTemplateEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentTemplateEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDocumentTemplateEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveDocumentTemplateEntity" />
  </wsdl:message>
  <wsdl:message name="SaveDocumentTemplateEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDocumentTemplateEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveDocumentTemplateEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveDocumentTemplateEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRelationDefinitionEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultRelationDefinitionEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRelationDefinitionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRelationDefinitionEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultRelationDefinitionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRelationDefinitionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRelationDefinitionEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveRelationDefinitionEntity" />
  </wsdl:message>
  <wsdl:message name="SaveRelationDefinitionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRelationDefinitionEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveRelationDefinitionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveRelationDefinitionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBusinessRequest">
    <wsdl:part name="parameters" element="tns:GetBusiness" />
  </wsdl:message>
  <wsdl:message name="GetBusinessRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBusinessResponse">
    <wsdl:part name="parameters" element="tns:GetBusinessResponse" />
  </wsdl:message>
  <wsdl:message name="GetBusinessResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBusinessListRequest">
    <wsdl:part name="parameters" element="tns:GetBusinessList" />
  </wsdl:message>
  <wsdl:message name="GetBusinessListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBusinessListResponse">
    <wsdl:part name="parameters" element="tns:GetBusinessListResponse" />
  </wsdl:message>
  <wsdl:message name="GetBusinessListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBusinessesRequest">
    <wsdl:part name="parameters" element="tns:GetBusinesses" />
  </wsdl:message>
  <wsdl:message name="GetBusinessesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBusinessesResponse">
    <wsdl:part name="parameters" element="tns:GetBusinessesResponse" />
  </wsdl:message>
  <wsdl:message name="GetBusinessesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCategoryRequest">
    <wsdl:part name="parameters" element="tns:GetCategory" />
  </wsdl:message>
  <wsdl:message name="GetCategoryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCategoryResponse">
    <wsdl:part name="parameters" element="tns:GetCategoryResponse" />
  </wsdl:message>
  <wsdl:message name="GetCategoryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCategoryListRequest">
    <wsdl:part name="parameters" element="tns:GetCategoryList" />
  </wsdl:message>
  <wsdl:message name="GetCategoryListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCategoryListResponse">
    <wsdl:part name="parameters" element="tns:GetCategoryListResponse" />
  </wsdl:message>
  <wsdl:message name="GetCategoryListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCategoriesRequest">
    <wsdl:part name="parameters" element="tns:GetCategories" />
  </wsdl:message>
  <wsdl:message name="GetCategoriesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCategoriesResponse">
    <wsdl:part name="parameters" element="tns:GetCategoriesResponse" />
  </wsdl:message>
  <wsdl:message name="GetCategoriesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCompetitorRequest">
    <wsdl:part name="parameters" element="tns:GetCompetitor" />
  </wsdl:message>
  <wsdl:message name="GetCompetitorRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCompetitorResponse">
    <wsdl:part name="parameters" element="tns:GetCompetitorResponse" />
  </wsdl:message>
  <wsdl:message name="GetCompetitorResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCompetitorListRequest">
    <wsdl:part name="parameters" element="tns:GetCompetitorList" />
  </wsdl:message>
  <wsdl:message name="GetCompetitorListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCompetitorListResponse">
    <wsdl:part name="parameters" element="tns:GetCompetitorListResponse" />
  </wsdl:message>
  <wsdl:message name="GetCompetitorListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCompetitorsRequest">
    <wsdl:part name="parameters" element="tns:GetCompetitors" />
  </wsdl:message>
  <wsdl:message name="GetCompetitorsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCompetitorsResponse">
    <wsdl:part name="parameters" element="tns:GetCompetitorsResponse" />
  </wsdl:message>
  <wsdl:message name="GetCompetitorsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCountryRequest">
    <wsdl:part name="parameters" element="tns:GetCountry" />
  </wsdl:message>
  <wsdl:message name="GetCountryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCountryResponse">
    <wsdl:part name="parameters" element="tns:GetCountryResponse" />
  </wsdl:message>
  <wsdl:message name="GetCountryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCountryRequest">
    <wsdl:part name="parameters" element="tns:SaveCountry" />
  </wsdl:message>
  <wsdl:message name="SaveCountryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCountryResponse">
    <wsdl:part name="parameters" element="tns:SaveCountryResponse" />
  </wsdl:message>
  <wsdl:message name="SaveCountryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCountryRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultCountry" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCountryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCountryResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultCountryResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCountryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCountryListRequest">
    <wsdl:part name="parameters" element="tns:GetCountryList" />
  </wsdl:message>
  <wsdl:message name="GetCountryListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCountryListResponse">
    <wsdl:part name="parameters" element="tns:GetCountryListResponse" />
  </wsdl:message>
  <wsdl:message name="GetCountryListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCountriesRequest">
    <wsdl:part name="parameters" element="tns:GetCountries" />
  </wsdl:message>
  <wsdl:message name="GetCountriesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCountriesResponse">
    <wsdl:part name="parameters" element="tns:GetCountriesResponse" />
  </wsdl:message>
  <wsdl:message name="GetCountriesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllCountriesRequest">
    <wsdl:part name="parameters" element="tns:GetAllCountries" />
  </wsdl:message>
  <wsdl:message name="GetAllCountriesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllCountriesResponse">
    <wsdl:part name="parameters" element="tns:GetAllCountriesResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllCountriesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCreditedRequest">
    <wsdl:part name="parameters" element="tns:GetCredited" />
  </wsdl:message>
  <wsdl:message name="GetCreditedRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCreditedResponse">
    <wsdl:part name="parameters" element="tns:GetCreditedResponse" />
  </wsdl:message>
  <wsdl:message name="GetCreditedResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCreditedListRequest">
    <wsdl:part name="parameters" element="tns:GetCreditedList" />
  </wsdl:message>
  <wsdl:message name="GetCreditedListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCreditedListResponse">
    <wsdl:part name="parameters" element="tns:GetCreditedListResponse" />
  </wsdl:message>
  <wsdl:message name="GetCreditedListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCreditedsRequest">
    <wsdl:part name="parameters" element="tns:GetCrediteds" />
  </wsdl:message>
  <wsdl:message name="GetCreditedsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCreditedsResponse">
    <wsdl:part name="parameters" element="tns:GetCreditedsResponse" />
  </wsdl:message>
  <wsdl:message name="GetCreditedsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCurrencyRequest">
    <wsdl:part name="parameters" element="tns:GetCurrency" />
  </wsdl:message>
  <wsdl:message name="GetCurrencyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCurrencyResponse">
    <wsdl:part name="parameters" element="tns:GetCurrencyResponse" />
  </wsdl:message>
  <wsdl:message name="GetCurrencyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetOurCurrencyRequest">
    <wsdl:part name="parameters" element="tns:GetOurCurrency" />
  </wsdl:message>
  <wsdl:message name="GetOurCurrencyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetOurCurrencyResponse">
    <wsdl:part name="parameters" element="tns:GetOurCurrencyResponse" />
  </wsdl:message>
  <wsdl:message name="GetOurCurrencyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeCurrencyRequest">
    <wsdl:part name="parameters" element="tns:ChangeCurrency" />
  </wsdl:message>
  <wsdl:message name="ChangeCurrencyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeCurrencyResponse">
    <wsdl:part name="parameters" element="tns:ChangeCurrencyResponse" />
  </wsdl:message>
  <wsdl:message name="ChangeCurrencyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetOwnerCompanysCurrencyRequest">
    <wsdl:part name="parameters" element="tns:GetOwnerCompanysCurrency" />
  </wsdl:message>
  <wsdl:message name="GetOwnerCompanysCurrencyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetOwnerCompanysCurrencyResponse">
    <wsdl:part name="parameters" element="tns:GetOwnerCompanysCurrencyResponse" />
  </wsdl:message>
  <wsdl:message name="GetOwnerCompanysCurrencyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCurrencyEntityRequest">
    <wsdl:part name="parameters" element="tns:GetCurrencyEntity" />
  </wsdl:message>
  <wsdl:message name="GetCurrencyEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCurrencyEntityResponse">
    <wsdl:part name="parameters" element="tns:GetCurrencyEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetCurrencyEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBaseCurrencyRequest">
    <wsdl:part name="parameters" element="tns:GetBaseCurrency" />
  </wsdl:message>
  <wsdl:message name="GetBaseCurrencyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBaseCurrencyResponse">
    <wsdl:part name="parameters" element="tns:GetBaseCurrencyResponse" />
  </wsdl:message>
  <wsdl:message name="GetBaseCurrencyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAmountClassEntityRequest">
    <wsdl:part name="parameters" element="tns:GetAmountClassEntity" />
  </wsdl:message>
  <wsdl:message name="GetAmountClassEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAmountClassEntityResponse">
    <wsdl:part name="parameters" element="tns:GetAmountClassEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetAmountClassEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCurrencyListRequest">
    <wsdl:part name="parameters" element="tns:GetCurrencyList" />
  </wsdl:message>
  <wsdl:message name="GetCurrencyListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCurrencyListResponse">
    <wsdl:part name="parameters" element="tns:GetCurrencyListResponse" />
  </wsdl:message>
  <wsdl:message name="GetCurrencyListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCurrenciesRequest">
    <wsdl:part name="parameters" element="tns:GetCurrencies" />
  </wsdl:message>
  <wsdl:message name="GetCurrenciesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCurrenciesResponse">
    <wsdl:part name="parameters" element="tns:GetCurrenciesResponse" />
  </wsdl:message>
  <wsdl:message name="GetCurrenciesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllCurrenciesRequest">
    <wsdl:part name="parameters" element="tns:GetAllCurrencies" />
  </wsdl:message>
  <wsdl:message name="GetAllCurrenciesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllCurrenciesResponse">
    <wsdl:part name="parameters" element="tns:GetAllCurrenciesResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllCurrenciesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomerLanguageRequest">
    <wsdl:part name="parameters" element="tns:GetCustomerLanguage" />
  </wsdl:message>
  <wsdl:message name="GetCustomerLanguageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomerLanguageResponse">
    <wsdl:part name="parameters" element="tns:GetCustomerLanguageResponse" />
  </wsdl:message>
  <wsdl:message name="GetCustomerLanguageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomerLanguageListRequest">
    <wsdl:part name="parameters" element="tns:GetCustomerLanguageList" />
  </wsdl:message>
  <wsdl:message name="GetCustomerLanguageListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomerLanguageListResponse">
    <wsdl:part name="parameters" element="tns:GetCustomerLanguageListResponse" />
  </wsdl:message>
  <wsdl:message name="GetCustomerLanguageListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomerLanguagesRequest">
    <wsdl:part name="parameters" element="tns:GetCustomerLanguages" />
  </wsdl:message>
  <wsdl:message name="GetCustomerLanguagesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomerLanguagesResponse">
    <wsdl:part name="parameters" element="tns:GetCustomerLanguagesResponse" />
  </wsdl:message>
  <wsdl:message name="GetCustomerLanguagesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryTermRequest">
    <wsdl:part name="parameters" element="tns:GetDeliveryTerm" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryTermRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryTermResponse">
    <wsdl:part name="parameters" element="tns:GetDeliveryTermResponse" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryTermResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryTermsRequest">
    <wsdl:part name="parameters" element="tns:GetDeliveryTerms" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryTermsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryTermsResponse">
    <wsdl:part name="parameters" element="tns:GetDeliveryTermsResponse" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryTermsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryTypeRequest">
    <wsdl:part name="parameters" element="tns:GetDeliveryType" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryTypeResponse">
    <wsdl:part name="parameters" element="tns:GetDeliveryTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryTypesRequest">
    <wsdl:part name="parameters" element="tns:GetDeliveryTypes" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryTypesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryTypesResponse">
    <wsdl:part name="parameters" element="tns:GetDeliveryTypesResponse" />
  </wsdl:message>
  <wsdl:message name="GetDeliveryTypesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPaymentTermRequest">
    <wsdl:part name="parameters" element="tns:GetPaymentTerm" />
  </wsdl:message>
  <wsdl:message name="GetPaymentTermRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPaymentTermResponse">
    <wsdl:part name="parameters" element="tns:GetPaymentTermResponse" />
  </wsdl:message>
  <wsdl:message name="GetPaymentTermResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPaymentTermsRequest">
    <wsdl:part name="parameters" element="tns:GetPaymentTerms" />
  </wsdl:message>
  <wsdl:message name="GetPaymentTermsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPaymentTermsResponse">
    <wsdl:part name="parameters" element="tns:GetPaymentTermsResponse" />
  </wsdl:message>
  <wsdl:message name="GetPaymentTermsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPaymentTypeRequest">
    <wsdl:part name="parameters" element="tns:GetPaymentType" />
  </wsdl:message>
  <wsdl:message name="GetPaymentTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPaymentTypeResponse">
    <wsdl:part name="parameters" element="tns:GetPaymentTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetPaymentTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPaymentTypesRequest">
    <wsdl:part name="parameters" element="tns:GetPaymentTypes" />
  </wsdl:message>
  <wsdl:message name="GetPaymentTypesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPaymentTypesResponse">
    <wsdl:part name="parameters" element="tns:GetPaymentTypesResponse" />
  </wsdl:message>
  <wsdl:message name="GetPaymentTypesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDepartmentRequest">
    <wsdl:part name="parameters" element="tns:GetDepartment" />
  </wsdl:message>
  <wsdl:message name="GetDepartmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDepartmentResponse">
    <wsdl:part name="parameters" element="tns:GetDepartmentResponse" />
  </wsdl:message>
  <wsdl:message name="GetDepartmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDepartmentListRequest">
    <wsdl:part name="parameters" element="tns:GetDepartmentList" />
  </wsdl:message>
  <wsdl:message name="GetDepartmentListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDepartmentListResponse">
    <wsdl:part name="parameters" element="tns:GetDepartmentListResponse" />
  </wsdl:message>
  <wsdl:message name="GetDepartmentListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDepartmentsRequest">
    <wsdl:part name="parameters" element="tns:GetDepartments" />
  </wsdl:message>
  <wsdl:message name="GetDepartmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDepartmentsResponse">
    <wsdl:part name="parameters" element="tns:GetDepartmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetDepartmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplate" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateListRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateList" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateListResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplateListResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplateListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplatesRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplates" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplatesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplatesResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentTemplatesResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentTemplatesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllDocumentTemplatesRequest">
    <wsdl:part name="parameters" element="tns:GetAllDocumentTemplates" />
  </wsdl:message>
  <wsdl:message name="GetAllDocumentTemplatesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllDocumentTemplatesResponse">
    <wsdl:part name="parameters" element="tns:GetAllDocumentTemplatesResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllDocumentTemplatesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHeadingEntityRequest">
    <wsdl:part name="parameters" element="tns:GetHeadingEntity" />
  </wsdl:message>
  <wsdl:message name="GetHeadingEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHeadingEntityResponse">
    <wsdl:part name="parameters" element="tns:GetHeadingEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetHeadingEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultHeadingFromListDefinitionRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultHeadingFromListDefinition" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultHeadingFromListDefinitionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultHeadingFromListDefinitionResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultHeadingFromListDefinitionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultHeadingFromListDefinitionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLanguageInfoRequest">
    <wsdl:part name="parameters" element="tns:GetLanguageInfo" />
  </wsdl:message>
  <wsdl:message name="GetLanguageInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLanguageInfoResponse">
    <wsdl:part name="parameters" element="tns:GetLanguageInfoResponse" />
  </wsdl:message>
  <wsdl:message name="GetLanguageInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLanguageInfoListRequest">
    <wsdl:part name="parameters" element="tns:GetLanguageInfoList" />
  </wsdl:message>
  <wsdl:message name="GetLanguageInfoListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLanguageInfoListResponse">
    <wsdl:part name="parameters" element="tns:GetLanguageInfoListResponse" />
  </wsdl:message>
  <wsdl:message name="GetLanguageInfoListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetInstalledLanguagesRequest">
    <wsdl:part name="parameters" element="tns:GetInstalledLanguages" />
  </wsdl:message>
  <wsdl:message name="GetInstalledLanguagesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetInstalledLanguagesResponse">
    <wsdl:part name="parameters" element="tns:GetInstalledLanguagesResponse" />
  </wsdl:message>
  <wsdl:message name="GetInstalledLanguagesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLinkRequest">
    <wsdl:part name="parameters" element="tns:GetLink" />
  </wsdl:message>
  <wsdl:message name="GetLinkRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLinkResponse">
    <wsdl:part name="parameters" element="tns:GetLinkResponse" />
  </wsdl:message>
  <wsdl:message name="GetLinkResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLinkListRequest">
    <wsdl:part name="parameters" element="tns:GetLinkList" />
  </wsdl:message>
  <wsdl:message name="GetLinkListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLinkListResponse">
    <wsdl:part name="parameters" element="tns:GetLinkListResponse" />
  </wsdl:message>
  <wsdl:message name="GetLinkListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListEntityRequest">
    <wsdl:part name="parameters" element="tns:GetListEntity" />
  </wsdl:message>
  <wsdl:message name="GetListEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListEntityResponse">
    <wsdl:part name="parameters" element="tns:GetListEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetListEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListDefinitionsRequest">
    <wsdl:part name="parameters" element="tns:GetListDefinitions" />
  </wsdl:message>
  <wsdl:message name="GetListDefinitionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListDefinitionsResponse">
    <wsdl:part name="parameters" element="tns:GetListDefinitionsResponse" />
  </wsdl:message>
  <wsdl:message name="GetListDefinitionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListEntityByNameRequest">
    <wsdl:part name="parameters" element="tns:GetListEntityByName" />
  </wsdl:message>
  <wsdl:message name="GetListEntityByNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetListEntityByNameResponse">
    <wsdl:part name="parameters" element="tns:GetListEntityByNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetListEntityByNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveListEntityByNameRequest">
    <wsdl:part name="parameters" element="tns:SaveListEntityByName" />
  </wsdl:message>
  <wsdl:message name="SaveListEntityByNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveListEntityByNameResponse">
    <wsdl:part name="parameters" element="tns:SaveListEntityByNameResponse" />
  </wsdl:message>
  <wsdl:message name="SaveListEntityByNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteListEntityByNameRequest">
    <wsdl:part name="parameters" element="tns:DeleteListEntityByName" />
  </wsdl:message>
  <wsdl:message name="DeleteListEntityByNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteListEntityByNameResponse">
    <wsdl:part name="parameters" element="tns:DeleteListEntityByNameResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteListEntityByNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="List">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for List</summary>
    </wsdl:documentation>
    <wsdl:operation name="GetAllReasonSold">
      <wsdl:documentation>
        <summary>Gets an array of all ReasonSold objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllReasonSold" name="GetAllReasonSoldRequest" message="tns:GetAllReasonSoldRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllReasonSoldResponse" name="GetAllReasonSoldResponse" message="tns:GetAllReasonSoldResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetReasonSoldList">
      <wsdl:documentation>
        <summary>Gets an array of ReasonSold objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasonSoldList" name="GetReasonSoldListRequest" message="tns:GetReasonSoldListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasonSoldListResponse" name="GetReasonSoldListResponse" message="tns:GetReasonSoldListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetReasonStalled">
      <wsdl:documentation>
        <summary>Gets a ReasonStalled object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasonStalled" name="GetReasonStalledRequest" message="tns:GetReasonStalledRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasonStalledResponse" name="GetReasonStalledResponse" message="tns:GetReasonStalledResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllReasonStalled">
      <wsdl:documentation>
        <summary>Gets an array of all ReasonStalled objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllReasonStalled" name="GetAllReasonStalledRequest" message="tns:GetAllReasonStalledRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllReasonStalledResponse" name="GetAllReasonStalledResponse" message="tns:GetAllReasonStalledResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetReasonStalledList">
      <wsdl:documentation>
        <summary>Gets an array of ReasonStalled objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasonStalledList" name="GetReasonStalledListRequest" message="tns:GetReasonStalledListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasonStalledListResponse" name="GetReasonStalledListResponse" message="tns:GetReasonStalledListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetResourceEntity">
      <wsdl:documentation>
        <summary>Gets a ResourceEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetResourceEntity" name="GetResourceEntityRequest" message="tns:GetResourceEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetResourceEntityResponse" name="GetResourceEntityResponse" message="tns:GetResourceEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSaleStageEntity">
      <wsdl:documentation>
        <summary>Gets a SaleStageEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSaleStageEntity" name="GetSaleStageEntityRequest" message="tns:GetSaleStageEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSaleStageEntityResponse" name="GetSaleStageEntityResponse" message="tns:GetSaleStageEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSaleType">
      <wsdl:documentation>
        <summary>Gets a SaleType object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSaleType" name="GetSaleTypeRequest" message="tns:GetSaleTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSaleTypeResponse" name="GetSaleTypeResponse" message="tns:GetSaleTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSaleTypeEntity">
      <wsdl:documentation>
        <summary>Gets a SaleTypeEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSaleTypeEntity" name="GetSaleTypeEntityRequest" message="tns:GetSaleTypeEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSaleTypeEntityResponse" name="GetSaleTypeEntityResponse" message="tns:GetSaleTypeEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllSaleType">
      <wsdl:documentation>
        <summary>Gets an array of all SaleType objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllSaleType" name="GetAllSaleTypeRequest" message="tns:GetAllSaleTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllSaleTypeResponse" name="GetAllSaleTypeResponse" message="tns:GetAllSaleTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSaleTypeList">
      <wsdl:documentation>
        <summary>Gets an array of SaleType objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSaleTypeList" name="GetSaleTypeListRequest" message="tns:GetSaleTypeListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSaleTypeListResponse" name="GetSaleTypeListResponse" message="tns:GetSaleTypeListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSelectionCategory">
      <wsdl:documentation>
        <summary>Gets a SelectionCategory object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSelectionCategory" name="GetSelectionCategoryRequest" message="tns:GetSelectionCategoryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSelectionCategoryResponse" name="GetSelectionCategoryResponse" message="tns:GetSelectionCategoryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllSelectionCategory">
      <wsdl:documentation>
        <summary>Gets an array of all SelectionCategory objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllSelectionCategory" name="GetAllSelectionCategoryRequest" message="tns:GetAllSelectionCategoryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllSelectionCategoryResponse" name="GetAllSelectionCategoryResponse" message="tns:GetAllSelectionCategoryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSelectionCategoryList">
      <wsdl:documentation>
        <summary>Gets an array of SelectionCategory objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSelectionCategoryList" name="GetSelectionCategoryListRequest" message="tns:GetSelectionCategoryListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSelectionCategoryListResponse" name="GetSelectionCategoryListResponse" message="tns:GetSelectionCategoryListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSource">
      <wsdl:documentation>
        <summary>Gets a Source object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSource" name="GetSourceRequest" message="tns:GetSourceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSourceResponse" name="GetSourceResponse" message="tns:GetSourceResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSourceList">
      <wsdl:documentation>
        <summary>Gets an array of Source objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSourceList" name="GetSourceListRequest" message="tns:GetSourceListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSourceListResponse" name="GetSourceListResponse" message="tns:GetSourceListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSources">
      <wsdl:documentation>
        <summary>Returns all sources</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSources" name="GetSourcesRequest" message="tns:GetSourcesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSourcesResponse" name="GetSourcesResponse" message="tns:GetSourcesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTask">
      <wsdl:documentation>
        <summary>Gets a Task object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetTask" name="GetTaskRequest" message="tns:GetTaskRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetTaskResponse" name="GetTaskResponse" message="tns:GetTaskResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateTask">
      <wsdl:documentation>
        <summary>Returns a Document Template list item as a TaskListItem. The appointment's task is a Document template item when the appointment is a document.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateTask" name="GetDocumentTemplateTaskRequest" message="tns:GetDocumentTemplateTaskRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateTaskResponse" name="GetDocumentTemplateTaskResponse" message="tns:GetDocumentTemplateTaskResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTaskList">
      <wsdl:documentation>
        <summary>Gets an array of Task objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetTaskList" name="GetTaskListRequest" message="tns:GetTaskListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetTaskListResponse" name="GetTaskListResponse" message="tns:GetTaskListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTasks">
      <wsdl:documentation>
        <summary>Returns all appointment tasks</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetTasks" name="GetTasksRequest" message="tns:GetTasksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetTasksResponse" name="GetTasksResponse" message="tns:GetTasksResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplatesTasks">
      <wsdl:documentation>
        <summary>The appointment's task is a Document template item when the appointment is a document.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplatesTasks" name="GetDocumentTemplatesTasksRequest" message="tns:GetDocumentTemplatesTasksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplatesTasksResponse" name="GetDocumentTemplatesTasksResponse" message="tns:GetDocumentTemplatesTasksResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllTasks">
      <wsdl:documentation>
        <summary>Returns all appointment tasks</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllTasks" name="GetAllTasksRequest" message="tns:GetAllTasksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllTasksResponse" name="GetAllTasksResponse" message="tns:GetAllTasksResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTicketPriority">
      <wsdl:documentation>
        <summary>Gets a TicketPriority object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetTicketPriority" name="GetTicketPriorityRequest" message="tns:GetTicketPriorityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetTicketPriorityResponse" name="GetTicketPriorityResponse" message="tns:GetTicketPriorityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTicketPriorityList">
      <wsdl:documentation>
        <summary>Gets an array of TicketPriority objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetTicketPriorityList" name="GetTicketPriorityListRequest" message="tns:GetTicketPriorityListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetTicketPriorityListResponse" name="GetTicketPriorityListResponse" message="tns:GetTicketPriorityListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTicketPriorities">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetTicketPriorities" name="GetTicketPrioritiesRequest" message="tns:GetTicketPrioritiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetTicketPrioritiesResponse" name="GetTicketPrioritiesResponse" message="tns:GetTicketPrioritiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetWebPanelEntity">
      <wsdl:documentation>
        <summary>Gets a WebPanelEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetWebPanelEntity" name="GetWebPanelEntityRequest" message="tns:GetWebPanelEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetWebPanelEntityResponse" name="GetWebPanelEntityResponse" message="tns:GetWebPanelEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GenerateNavigationUrl">
      <wsdl:documentation>
        <summary>This methods generates the navigation URL to be used to navigate to the panel</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GenerateNavigationUrl" name="GenerateNavigationUrlRequest" message="tns:GenerateNavigationUrlRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GenerateNavigationUrlResponse" name="GenerateNavigationUrlResponse" message="tns:GenerateNavigationUrlResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetWebPanelList">
      <wsdl:documentation>
        <summary>Return a list of all web panels. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetWebPanelList" name="GetWebPanelListRequest" message="tns:GetWebPanelListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetWebPanelListResponse" name="GetWebPanelListResponse" message="tns:GetWebPanelListResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteWebPanel">
      <wsdl:documentation>
        <summary>Hard-delete (real, permanent DELETE in the database) the given web panel. Use with care!</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteWebPanel" name="DeleteWebPanelRequest" message="tns:DeleteWebPanelRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteWebPanelResponse" name="DeleteWebPanelResponse" message="tns:DeleteWebPanelResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAppWebPanels">
      <wsdl:documentation>
        <summary>Get all web panels owned by your app; works in Online only, for registered Apps that send a valid ApplicationToken</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAppWebPanels" name="GetAppWebPanelsRequest" message="tns:GetAppWebPanelsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAppWebPanelsResponse" name="GetAppWebPanelsResponse" message="tns:GetAppWebPanelsResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteAppWebPanels">
      <wsdl:documentation>
        <summary>Permanentely delete all web panels owned by your app; works in Online only, for registered Apps that send a valid ApplicationToken; otherwise nothing happens</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteAppWebPanels" name="DeleteAppWebPanelsRequest" message="tns:DeleteAppWebPanelsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteAppWebPanelsResponse" name="DeleteAppWebPanelsResponse" message="tns:DeleteAppWebPanelsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetWebPanelByProgId">
      <wsdl:documentation>
        <summary>Get a web panel using the ProgId key that was specified when it was created</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetWebPanelByProgId" name="GetWebPanelByProgIdRequest" message="tns:GetWebPanelByProgIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetWebPanelByProgIdResponse" name="GetWebPanelByProgIdResponse" message="tns:GetWebPanelByProgIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetExtAppEntity">
      <wsdl:documentation>
        <summary>Gets a ExtAppEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetExtAppEntity" name="GetExtAppEntityRequest" message="tns:GetExtAppEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetExtAppEntityResponse" name="GetExtAppEntityResponse" message="tns:GetExtAppEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateEntity">
      <wsdl:documentation>
        <summary>Gets a DocumentTemplateEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateEntity" name="GetDocumentTemplateEntityRequest" message="tns:GetDocumentTemplateEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateEntityResponse" name="GetDocumentTemplateEntityResponse" message="tns:GetDocumentTemplateEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetDocumentTemplateStream">
      <wsdl:documentation>
        <summary>Store a document template from its stream. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetDocumentTemplateStream" name="SetDocumentTemplateStreamRequest" message="tns:SetDocumentTemplateStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetDocumentTemplateStreamResponse" name="SetDocumentTemplateStreamResponse" message="tns:SetDocumentTemplateStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateUsedInSalesStage">
      <wsdl:documentation>
        <summary>Get a String array of names in sales guide that this template is used in</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateUsedInSalesStage" name="GetDocumentTemplateUsedInSalesStageRequest" message="tns:GetDocumentTemplateUsedInSalesStageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateUsedInSalesStageResponse" name="GetDocumentTemplateUsedInSalesStageResponse" message="tns:GetDocumentTemplateUsedInSalesStageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateUsedInProjectStage">
      <wsdl:documentation>
        <summary>Get a String array of names in project guide that this template is used in</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateUsedInProjectStage" name="GetDocumentTemplateUsedInProjectStageRequest" message="tns:GetDocumentTemplateUsedInProjectStageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateUsedInProjectStageResponse" name="GetDocumentTemplateUsedInProjectStageResponse" message="tns:GetDocumentTemplateUsedInProjectStageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateUrl">
      <wsdl:documentation>
        <summary>Get a url to the document template</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateUrl" name="GetDocumentTemplateUrlRequest" message="tns:GetDocumentTemplateUrlRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateUrlResponse" name="GetDocumentTemplateUrlResponse" message="tns:GetDocumentTemplateUrlResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateProperties">
      <wsdl:documentation>
        <summary>Get document template properties</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateProperties" name="GetDocumentTemplatePropertiesRequest" message="tns:GetDocumentTemplatePropertiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplatePropertiesResponse" name="GetDocumentTemplatePropertiesResponse" message="tns:GetDocumentTemplatePropertiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateLanguages">
      <wsdl:documentation>
        <summary>Get the supported language variations for a document template</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateLanguages" name="GetDocumentTemplateLanguagesRequest" message="tns:GetDocumentTemplateLanguagesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateLanguagesResponse" name="GetDocumentTemplateLanguagesResponse" message="tns:GetDocumentTemplateLanguagesResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultDocumentTemplateLanguage">
      <wsdl:documentation>
        <summary>Create a new document template language based on an existing template</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultDocumentTemplateLanguage" name="CreateDefaultDocumentTemplateLanguageRequest" message="tns:CreateDefaultDocumentTemplateLanguageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultDocumentTemplateLanguageResponse" name="CreateDefaultDocumentTemplateLanguageResponse" message="tns:CreateDefaultDocumentTemplateLanguageResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteDocumentTemplateLanguage">
      <wsdl:documentation>
        <summary>Deletes language variant of the document template</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteDocumentTemplateLanguage" name="DeleteDocumentTemplateLanguageRequest" message="tns:DeleteDocumentTemplateLanguageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteDocumentTemplateLanguageResponse" name="DeleteDocumentTemplateLanguageResponse" message="tns:DeleteDocumentTemplateLanguageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateExtension">
      <wsdl:documentation>
        <summary>Get the file extension for the document template</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateExtension" name="GetDocumentTemplateExtensionRequest" message="tns:GetDocumentTemplateExtensionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateExtensionResponse" name="GetDocumentTemplateExtensionResponse" message="tns:GetDocumentTemplateExtensionResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetDocumentTemplateFromDocumentTemplate">
      <wsdl:documentation>
        <summary>Create a new document template based on another template</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetDocumentTemplateFromDocumentTemplate" name="SetDocumentTemplateFromDocumentTemplateRequest" message="tns:SetDocumentTemplateFromDocumentTemplateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetDocumentTemplateFromDocumentTemplateResponse" name="SetDocumentTemplateFromDocumentTemplateResponse" message="tns:SetDocumentTemplateFromDocumentTemplateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateStreamFromId">
      <wsdl:documentation>
        <summary>Retrieve a stream to a document template based on its id</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateStreamFromId" name="GetDocumentTemplateStreamFromIdRequest" message="tns:GetDocumentTemplateStreamFromIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateStreamFromIdResponse" name="GetDocumentTemplateStreamFromIdResponse" message="tns:GetDocumentTemplateStreamFromIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveDocumentTemplateStream">
      <wsdl:documentation>
        <summary>Writes content in stream to document template file</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveDocumentTemplateStream" name="SaveDocumentTemplateStreamRequest" message="tns:SaveDocumentTemplateStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveDocumentTemplateStreamResponse" name="SaveDocumentTemplateStreamResponse" message="tns:SaveDocumentTemplateStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPluginList">
      <wsdl:documentation>
        <summary>Get a list of installed document plugins</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPluginList" name="GetPluginListRequest" message="tns:GetPluginListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPluginListResponse" name="GetPluginListResponse" message="tns:GetPluginListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPluginCapabilities">
      <wsdl:documentation>
        <summary>Get a list of plugin-dependent capabilities for a given document archive plugin.&lt;br/&gt;A standard set of properties is defined in SuperOffice.CRM.Documents.Constants.Capabilities.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPluginCapabilities" name="GetPluginCapabilitiesRequest" message="tns:GetPluginCapabilitiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPluginCapabilitiesResponse" name="GetPluginCapabilitiesResponse" message="tns:GetPluginCapabilitiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTypesForPlugin">
      <wsdl:documentation>
        <summary>Get a list of document types supported by a given document plugin. Use the document template type when creating a new template.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTypesForPlugin" name="GetDocumentTypesForPluginRequest" message="tns:GetDocumentTypesForPluginRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTypesForPluginResponse" name="GetDocumentTypesForPluginResponse" message="tns:GetDocumentTypesForPluginResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetRelationDefinitionEntity">
      <wsdl:documentation>
        <summary>Gets a RelationDefinitionEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetRelationDefinitionEntity" name="GetRelationDefinitionEntityRequest" message="tns:GetRelationDefinitionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetRelationDefinitionEntityResponse" name="GetRelationDefinitionEntityResponse" message="tns:GetRelationDefinitionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveQuickReplies">
      <wsdl:documentation>
        <summary>Method to save all quick replies for a given associate</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveQuickReplies" name="SaveQuickRepliesRequest" message="tns:SaveQuickRepliesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveQuickRepliesResponse" name="SaveQuickRepliesResponse" message="tns:SaveQuickRepliesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuickReplies">
      <wsdl:documentation>
        <summary>Method to return all quick replies for a given associate</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetQuickReplies" name="GetQuickRepliesRequest" message="tns:GetQuickRepliesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetQuickRepliesResponse" name="GetQuickRepliesResponse" message="tns:GetQuickRepliesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConsentPurpose">
      <wsdl:documentation>
        <summary>Gets a ConsentPurpose object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetConsentPurpose" name="GetConsentPurposeRequest" message="tns:GetConsentPurposeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetConsentPurposeResponse" name="GetConsentPurposeResponse" message="tns:GetConsentPurposeResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveConsentPurpose">
      <wsdl:documentation>
        <summary>Save a ConsentPurpose object</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveConsentPurpose" name="SaveConsentPurposeRequest" message="tns:SaveConsentPurposeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveConsentPurposeResponse" name="SaveConsentPurposeResponse" message="tns:SaveConsentPurposeResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetEmarketingStrictMode">
      <wsdl:documentation>
        <summary>Turn on the Emarketing strict mode, which will enable full GDPR rules concerning Emarketing consents and subscriptions</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetEmarketingStrictMode" name="SetEmarketingStrictModeRequest" message="tns:SetEmarketingStrictModeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetEmarketingStrictModeResponse" name="SetEmarketingStrictModeResponse" message="tns:SetEmarketingStrictModeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEmarketingStrictMode">
      <wsdl:documentation>
        <summary>Get the value of the Emarketing strict mode setting</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetEmarketingStrictMode" name="GetEmarketingStrictModeRequest" message="tns:GetEmarketingStrictModeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetEmarketingStrictModeResponse" name="GetEmarketingStrictModeResponse" message="tns:GetEmarketingStrictModeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConsentPurposeList">
      <wsdl:documentation>
        <summary>Gets an array of ConsentPurpose objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetConsentPurposeList" name="GetConsentPurposeListRequest" message="tns:GetConsentPurposeListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetConsentPurposeListResponse" name="GetConsentPurposeListResponse" message="tns:GetConsentPurposeListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConsentPurposes">
      <wsdl:documentation>
        <summary>Returns all defined purposes.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetConsentPurposes" name="GetConsentPurposesRequest" message="tns:GetConsentPurposesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetConsentPurposesResponse" name="GetConsentPurposesResponse" message="tns:GetConsentPurposesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConsentSource">
      <wsdl:documentation>
        <summary>Gets a ConsentSource object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetConsentSource" name="GetConsentSourceRequest" message="tns:GetConsentSourceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetConsentSourceResponse" name="GetConsentSourceResponse" message="tns:GetConsentSourceResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveConsentSource">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveConsentSource" name="SaveConsentSourceRequest" message="tns:SaveConsentSourceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveConsentSourceResponse" name="SaveConsentSourceResponse" message="tns:SaveConsentSourceResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllConsentSource">
      <wsdl:documentation>
        <summary>Gets an array of all ConsentSource objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllConsentSource" name="GetAllConsentSourceRequest" message="tns:GetAllConsentSourceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllConsentSourceResponse" name="GetAllConsentSourceResponse" message="tns:GetAllConsentSourceResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConsentSourceList">
      <wsdl:documentation>
        <summary>Gets an array of ConsentSource objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetConsentSourceList" name="GetConsentSourceListRequest" message="tns:GetConsentSourceListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetConsentSourceListResponse" name="GetConsentSourceListResponse" message="tns:GetConsentSourceListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConsentSources">
      <wsdl:documentation>
        <summary>Returns all defined Sources.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetConsentSources" name="GetConsentSourcesRequest" message="tns:GetConsentSourcesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetConsentSourcesResponse" name="GetConsentSourcesResponse" message="tns:GetConsentSourcesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLegalBase">
      <wsdl:documentation>
        <summary>Gets a LegalBase object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLegalBase" name="GetLegalBaseRequest" message="tns:GetLegalBaseRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLegalBaseResponse" name="GetLegalBaseResponse" message="tns:GetLegalBaseResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveLegalBase">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveLegalBase" name="SaveLegalBaseRequest" message="tns:SaveLegalBaseRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveLegalBaseResponse" name="SaveLegalBaseResponse" message="tns:SaveLegalBaseResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllLegalBase">
      <wsdl:documentation>
        <summary>Gets an array of all LegalBase objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllLegalBase" name="GetAllLegalBaseRequest" message="tns:GetAllLegalBaseRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllLegalBaseResponse" name="GetAllLegalBaseResponse" message="tns:GetAllLegalBaseResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLegalBaseList">
      <wsdl:documentation>
        <summary>Gets an array of LegalBase objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLegalBaseList" name="GetLegalBaseListRequest" message="tns:GetLegalBaseListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLegalBaseListResponse" name="GetLegalBaseListResponse" message="tns:GetLegalBaseListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLegalBases">
      <wsdl:documentation>
        <summary>Returns all defined bases.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLegalBases" name="GetLegalBasesRequest" message="tns:GetLegalBasesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLegalBasesResponse" name="GetLegalBasesResponse" message="tns:GetLegalBasesResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveListItemEntity">
      <wsdl:documentation>
        <summary>Save the ListItemEntity.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveListItemEntity" name="SaveListItemEntityRequest" message="tns:SaveListItemEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveListItemEntityResponse" name="SaveListItemEntityResponse" message="tns:SaveListItemEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SortListItems">
      <wsdl:documentation>
        <summary>Sort the list items in a given list alphabetically</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SortListItems" name="SortListItemsRequest" message="tns:SortListItemsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SortListItemsResponse" name="SortListItemsResponse" message="tns:SortListItemsResponse" />
    </wsdl:operation>
    <wsdl:operation name="MoveListItem">
      <wsdl:documentation>
        <summary>Move a list item up or down in the list based on rank</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/MoveListItem" name="MoveListItemRequest" message="tns:MoveListItemRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/MoveListItemResponse" name="MoveListItemResponse" message="tns:MoveListItemResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetVisibleForUserGroups">
      <wsdl:documentation>
        <summary>List of User groups that this list item is visible for</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetVisibleForUserGroups" name="GetVisibleForUserGroupsRequest" message="tns:GetVisibleForUserGroupsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetVisibleForUserGroupsResponse" name="GetVisibleForUserGroupsResponse" message="tns:GetVisibleForUserGroupsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetVisibleForUserGroupsFromListName">
      <wsdl:documentation>
        <summary>List of User groups that this list item is visible for</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetVisibleForUserGroupsFromListName" name="GetVisibleForUserGroupsFromListNameRequest" message="tns:GetVisibleForUserGroupsFromListNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetVisibleForUserGroupsFromListNameResponse" name="GetVisibleForUserGroupsFromListNameResponse" message="tns:GetVisibleForUserGroupsFromListNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetVisibleForUserGroups">
      <wsdl:documentation>
        <summary>Update User groups that this list item is visible for</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetVisibleForUserGroups" name="SetVisibleForUserGroupsRequest" message="tns:SetVisibleForUserGroupsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetVisibleForUserGroupsResponse" name="SetVisibleForUserGroupsResponse" message="tns:SetVisibleForUserGroupsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetVisibleForUserGroupsFromListName">
      <wsdl:documentation>
        <summary>Update User groups that this list item is visible for</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetVisibleForUserGroupsFromListName" name="SetVisibleForUserGroupsFromListNameRequest" message="tns:SetVisibleForUserGroupsFromListNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetVisibleForUserGroupsFromListNameResponse" name="SetVisibleForUserGroupsFromListNameResponse" message="tns:SetVisibleForUserGroupsFromListNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetVisibleForUserGroup">
      <wsdl:documentation>
        <summary>Set a group which this list item should be visible for</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetVisibleForUserGroup" name="SetVisibleForUserGroupRequest" message="tns:SetVisibleForUserGroupRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetVisibleForUserGroupResponse" name="SetVisibleForUserGroupResponse" message="tns:SetVisibleForUserGroupResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetListItemsForUserGroup">
      <wsdl:documentation>
        <summary>List of list items that is visible in the usergroup</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListItemsForUserGroup" name="GetListItemsForUserGroupRequest" message="tns:GetListItemsForUserGroupRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListItemsForUserGroupResponse" name="GetListItemsForUserGroupResponse" message="tns:GetListItemsForUserGroupResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetListItemsForUserGroupFromListName">
      <wsdl:documentation>
        <summary>List of list items that is visible in the usergroup</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListItemsForUserGroupFromListName" name="GetListItemsForUserGroupFromListNameRequest" message="tns:GetListItemsForUserGroupFromListNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListItemsForUserGroupFromListNameResponse" name="GetListItemsForUserGroupFromListNameResponse" message="tns:GetListItemsForUserGroupFromListNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetListItemsForUserGroup">
      <wsdl:documentation>
        <summary>Update listItems that will be visible for this usergroup</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetListItemsForUserGroup" name="SetListItemsForUserGroupRequest" message="tns:SetListItemsForUserGroupRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetListItemsForUserGroupResponse" name="SetListItemsForUserGroupResponse" message="tns:SetListItemsForUserGroupResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetListItemsForUserGroupFromListName">
      <wsdl:documentation>
        <summary>Update listItems that will be visible for this usergroup</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetListItemsForUserGroupFromListName" name="SetListItemsForUserGroupFromListNameRequest" message="tns:SetListItemsForUserGroupFromListNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetListItemsForUserGroupFromListNameResponse" name="SetListItemsForUserGroupFromListNameResponse" message="tns:SetListItemsForUserGroupFromListNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetHeadings">
      <wsdl:documentation>
        <summary>Gets a selectable MDO list of the headings for this list item</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetHeadings" name="GetHeadingsRequest" message="tns:GetHeadingsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetHeadingsResponse" name="GetHeadingsResponse" message="tns:GetHeadingsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetHeadingsForListItemFromListName">
      <wsdl:documentation>
        <summary>Gets a selectable MDO list of the headings for this list item</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetHeadingsForListItemFromListName" name="GetHeadingsForListItemFromListNameRequest" message="tns:GetHeadingsForListItemFromListNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetHeadingsForListItemFromListNameResponse" name="GetHeadingsForListItemFromListNameResponse" message="tns:GetHeadingsForListItemFromListNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveHeadingsForListItemFromListDefinition">
      <wsdl:documentation>
        <summary>Saves the active headings for the list item.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingsForListItemFromListDefinition" name="SaveHeadingsForListItemFromListDefinitionRequest" message="tns:SaveHeadingsForListItemFromListDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingsForListItemFromListDefinitionResponse" name="SaveHeadingsForListItemFromListDefinitionResponse" message="tns:SaveHeadingsForListItemFromListDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveHeadingsForListItemFromListName">
      <wsdl:documentation>
        <summary>Saves the headings for the list item.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingsForListItemFromListName" name="SaveHeadingsForListItemFromListNameRequest" message="tns:SaveHeadingsForListItemFromListNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingsForListItemFromListNameResponse" name="SaveHeadingsForListItemFromListNameResponse" message="tns:SaveHeadingsForListItemFromListNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetListItemsForHeading">
      <wsdl:documentation>
        <summary>List of list items that is selected if under this heading</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListItemsForHeading" name="GetListItemsForHeadingRequest" message="tns:GetListItemsForHeadingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListItemsForHeadingResponse" name="GetListItemsForHeadingResponse" message="tns:GetListItemsForHeadingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetListItemsForHeadingFromListName">
      <wsdl:documentation>
        <summary>List of list items that is selected if under this heading</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListItemsForHeadingFromListName" name="GetListItemsForHeadingFromListNameRequest" message="tns:GetListItemsForHeadingFromListNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListItemsForHeadingFromListNameResponse" name="GetListItemsForHeadingFromListNameResponse" message="tns:GetListItemsForHeadingFromListNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetListItemsForHeading">
      <wsdl:documentation>
        <summary>Update listItems that will be visible for this usergroup</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetListItemsForHeading" name="SetListItemsForHeadingRequest" message="tns:SetListItemsForHeadingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetListItemsForHeadingResponse" name="SetListItemsForHeadingResponse" message="tns:SetListItemsForHeadingResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetListItemsForHeadingFromListName">
      <wsdl:documentation>
        <summary>Update listItems under this heading</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetListItemsForHeadingFromListName" name="SetListItemsForHeadingFromListNameRequest" message="tns:SetListItemsForHeadingFromListNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetListItemsForHeadingFromListNameResponse" name="SetListItemsForHeadingFromListNameResponse" message="tns:SetListItemsForHeadingFromListNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetHeadingsForListItem">
      <wsdl:documentation>
        <summary>Set headings which this list item should be listed under</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetHeadingsForListItem" name="SetHeadingsForListItemRequest" message="tns:SetHeadingsForListItemRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetHeadingsForListItemResponse" name="SetHeadingsForListItemResponse" message="tns:SetHeadingsForListItemResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetRankOnHeadings">
      <wsdl:documentation>
        <summary>Set rank order on headings</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetRankOnHeadings" name="SetRankOnHeadingsRequest" message="tns:SetRankOnHeadingsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetRankOnHeadingsResponse" name="SetRankOnHeadingsResponse" message="tns:SetRankOnHeadingsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetRankOnSaleActivity">
      <wsdl:documentation>
        <summary>Set rank order on sale activity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetRankOnSaleActivity" name="SetRankOnSaleActivityRequest" message="tns:SetRankOnSaleActivityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetRankOnSaleActivityResponse" name="SetRankOnSaleActivityResponse" message="tns:SetRankOnSaleActivityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetRankOnSaleDocument">
      <wsdl:documentation>
        <summary>Set rank order on project document</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetRankOnSaleDocument" name="SetRankOnSaleDocumentRequest" message="tns:SetRankOnSaleDocumentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetRankOnSaleDocumentResponse" name="SetRankOnSaleDocumentResponse" message="tns:SetRankOnSaleDocumentResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetRankOnProjectActivity">
      <wsdl:documentation>
        <summary>Set rank order on project activity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetRankOnProjectActivity" name="SetRankOnProjectActivityRequest" message="tns:SetRankOnProjectActivityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetRankOnProjectActivityResponse" name="SetRankOnProjectActivityResponse" message="tns:SetRankOnProjectActivityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetRankOnProjectDocument">
      <wsdl:documentation>
        <summary>Set rank order on project document</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetRankOnProjectDocument" name="SetRankOnProjectDocumentRequest" message="tns:SetRankOnProjectDocumentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetRankOnProjectDocumentResponse" name="SetRankOnProjectDocumentResponse" message="tns:SetRankOnProjectDocumentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllFromListDefinition">
      <wsdl:documentation>
        <summary>Get all list items for the specified list defintion</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllFromListDefinition" name="GetAllFromListDefinitionRequest" message="tns:GetAllFromListDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllFromListDefinitionResponse" name="GetAllFromListDefinitionResponse" message="tns:GetAllFromListDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllFromListName">
      <wsdl:documentation>
        <summary>Get all list items for the specified list defintion</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllFromListName" name="GetAllFromListNameRequest" message="tns:GetAllFromListNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllFromListNameResponse" name="GetAllFromListNameResponse" message="tns:GetAllFromListNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveAllFromListDefinition">
      <wsdl:documentation>
        <summary>Save all list items for the specified list defintion</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveAllFromListDefinition" name="SaveAllFromListDefinitionRequest" message="tns:SaveAllFromListDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveAllFromListDefinitionResponse" name="SaveAllFromListDefinitionResponse" message="tns:SaveAllFromListDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveAllFromListName">
      <wsdl:documentation>
        <summary>Save all list items for the specified list defintion</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveAllFromListName" name="SaveAllFromListNameRequest" message="tns:SaveAllFromListNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveAllFromListNameResponse" name="SaveAllFromListNameResponse" message="tns:SaveAllFromListNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddFromListDefinition">
      <wsdl:documentation>
        <summary>Save a new list item for the specified list defintion</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/AddFromListDefinition" name="AddFromListDefinitionRequest" message="tns:AddFromListDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/AddFromListDefinitionResponse" name="AddFromListDefinitionResponse" message="tns:AddFromListDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddFromListName">
      <wsdl:documentation>
        <summary>Save a new list item for the specified list defintion</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/AddFromListName" name="AddFromListNameRequest" message="tns:AddFromListNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/AddFromListNameResponse" name="AddFromListNameResponse" message="tns:AddFromListNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteAllFromListDefinition">
      <wsdl:documentation>
        <summary>Marks all items in the list deleted</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteAllFromListDefinition" name="DeleteAllFromListDefinitionRequest" message="tns:DeleteAllFromListDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteAllFromListDefinitionResponse" name="DeleteAllFromListDefinitionResponse" message="tns:DeleteAllFromListDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteAllFromListName">
      <wsdl:documentation>
        <summary>Marks all items in the list deleted</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteAllFromListName" name="DeleteAllFromListNameRequest" message="tns:DeleteAllFromListNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteAllFromListNameResponse" name="DeleteAllFromListNameResponse" message="tns:DeleteAllFromListNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFromListDefinition">
      <wsdl:documentation>
        <summary>Get a list item for the specified list defintion</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetFromListDefinition" name="GetFromListDefinitionRequest" message="tns:GetFromListDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetFromListDefinitionResponse" name="GetFromListDefinitionResponse" message="tns:GetFromListDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFromListName">
      <wsdl:documentation>
        <summary>Get a list item for the specified list defintion</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetFromListName" name="GetFromListNameRequest" message="tns:GetFromListNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetFromListNameResponse" name="GetFromListNameResponse" message="tns:GetFromListNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveFromListDefinition">
      <wsdl:documentation>
        <summary>Save a list item for the specified list defintion</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveFromListDefinition" name="SaveFromListDefinitionRequest" message="tns:SaveFromListDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveFromListDefinitionResponse" name="SaveFromListDefinitionResponse" message="tns:SaveFromListDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveFromListName">
      <wsdl:documentation>
        <summary>Save a list item for the specified list defintion</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveFromListName" name="SaveFromListNameRequest" message="tns:SaveFromListNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveFromListNameResponse" name="SaveFromListNameResponse" message="tns:SaveFromListNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteFromListDefinition">
      <wsdl:documentation>
        <summary>Delete a list item from the specified list defintion</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteFromListDefinition" name="DeleteFromListDefinitionRequest" message="tns:DeleteFromListDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteFromListDefinitionResponse" name="DeleteFromListDefinitionResponse" message="tns:DeleteFromListDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteFromListName">
      <wsdl:documentation>
        <summary>Delete a list item from the specified list defintion</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteFromListName" name="DeleteFromListNameRequest" message="tns:DeleteFromListNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteFromListNameResponse" name="DeleteFromListNameResponse" message="tns:DeleteFromListNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetHeadingsFromName">
      <wsdl:documentation>
        <summary>Gets headings for list resolved by the provided name.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetHeadingsFromName" name="GetHeadingsFromNameRequest" message="tns:GetHeadingsFromNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetHeadingsFromNameResponse" name="GetHeadingsFromNameResponse" message="tns:GetHeadingsFromNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetHeadingsFromListDefinition">
      <wsdl:documentation>
        <summary>Gets headings for list resolved by the provided id.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetHeadingsFromListDefinition" name="GetHeadingsFromListDefinitionRequest" message="tns:GetHeadingsFromListDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetHeadingsFromListDefinitionResponse" name="GetHeadingsFromListDefinitionResponse" message="tns:GetHeadingsFromListDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveHeadingsFromName">
      <wsdl:documentation>
        <summary>Save headings for list resolved by the provided name.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingsFromName" name="SaveHeadingsFromNameRequest" message="tns:SaveHeadingsFromNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingsFromNameResponse" name="SaveHeadingsFromNameResponse" message="tns:SaveHeadingsFromNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveHeadingsFromListDefinition">
      <wsdl:documentation>
        <summary>Save headings for list resolved by the provided id.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingsFromListDefinition" name="SaveHeadingsFromListDefinitionRequest" message="tns:SaveHeadingsFromListDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingsFromListDefinitionResponse" name="SaveHeadingsFromListDefinitionResponse" message="tns:SaveHeadingsFromListDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveHeadingFromName">
      <wsdl:documentation>
        <summary>Save new heading for list resolved by the provided name.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingFromName" name="SaveHeadingFromNameRequest" message="tns:SaveHeadingFromNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingFromNameResponse" name="SaveHeadingFromNameResponse" message="tns:SaveHeadingFromNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveHeadingFromListDefinition">
      <wsdl:documentation>
        <summary>Save new heading for list resolved by the provided id.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingFromListDefinition" name="SaveHeadingFromListDefinitionRequest" message="tns:SaveHeadingFromListDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingFromListDefinitionResponse" name="SaveHeadingFromListDefinitionResponse" message="tns:SaveHeadingFromListDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteAllHeadingsFromName">
      <wsdl:documentation>
        <summary>Delete all headings for list resolved by the provided name.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteAllHeadingsFromName" name="DeleteAllHeadingsFromNameRequest" message="tns:DeleteAllHeadingsFromNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteAllHeadingsFromNameResponse" name="DeleteAllHeadingsFromNameResponse" message="tns:DeleteAllHeadingsFromNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteAllHeadingsFromListDefinition">
      <wsdl:documentation>
        <summary>Delete all headings for list resolved by the provided id.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteAllHeadingsFromListDefinition" name="DeleteAllHeadingsFromListDefinitionRequest" message="tns:DeleteAllHeadingsFromListDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteAllHeadingsFromListDefinitionResponse" name="DeleteAllHeadingsFromListDefinitionResponse" message="tns:DeleteAllHeadingsFromListDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLocalizedText">
      <wsdl:documentation>
        <summary>Gets a LocalizedText object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLocalizedText" name="GetLocalizedTextRequest" message="tns:GetLocalizedTextRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLocalizedTextResponse" name="GetLocalizedTextResponse" message="tns:GetLocalizedTextResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLocalizedTextByType">
      <wsdl:documentation>
        <summary>Returns a localized text based on the resource id for the selected language.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLocalizedTextByType" name="GetLocalizedTextByTypeRequest" message="tns:GetLocalizedTextByTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLocalizedTextByTypeResponse" name="GetLocalizedTextByTypeResponse" message="tns:GetLocalizedTextByTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLocalizedTextList">
      <wsdl:documentation>
        <summary>Gets an array of LocalizedText objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLocalizedTextList" name="GetLocalizedTextListRequest" message="tns:GetLocalizedTextListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLocalizedTextListResponse" name="GetLocalizedTextListResponse" message="tns:GetLocalizedTextListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLocalizedTexts">
      <wsdl:documentation>
        <summary>Gets all localized texts in the CRM database.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLocalizedTexts" name="GetLocalizedTextsRequest" message="tns:GetLocalizedTextsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLocalizedTextsResponse" name="GetLocalizedTextsResponse" message="tns:GetLocalizedTextsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLocalizedTextsByLanguageId">
      <wsdl:documentation>
        <summary>Gets all localized text belonging to a specific language.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLocalizedTextsByLanguageId" name="GetLocalizedTextsByLanguageIdRequest" message="tns:GetLocalizedTextsByLanguageIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLocalizedTextsByLanguageIdResponse" name="GetLocalizedTextsByLanguageIdResponse" message="tns:GetLocalizedTextsByLanguageIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLocalizedTextsByType">
      <wsdl:documentation>
        <summary>Gets localized text by their type</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLocalizedTextsByType" name="GetLocalizedTextsByTypeRequest" message="tns:GetLocalizedTextsByTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLocalizedTextsByTypeResponse" name="GetLocalizedTextsByTypeResponse" message="tns:GetLocalizedTextsByTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMrMrs">
      <wsdl:documentation>
        <summary>Gets a MrMrs object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetMrMrs" name="GetMrMrsRequest" message="tns:GetMrMrsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetMrMrsResponse" name="GetMrMrsResponse" message="tns:GetMrMrsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMrMrsList">
      <wsdl:documentation>
        <summary>Gets an array of MrMrs objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetMrMrsList" name="GetMrMrsListRequest" message="tns:GetMrMrsListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetMrMrsListResponse" name="GetMrMrsListResponse" message="tns:GetMrMrsListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMrMrses">
      <wsdl:documentation>
        <summary>Returns all Items from the MrMrs table sorted by their value.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetMrMrses" name="GetMrMrsesRequest" message="tns:GetMrMrsesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetMrMrsesResponse" name="GetMrMrsesResponse" message="tns:GetMrMrsesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPosition">
      <wsdl:documentation>
        <summary>Gets a Position object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPosition" name="GetPositionRequest" message="tns:GetPositionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPositionResponse" name="GetPositionResponse" message="tns:GetPositionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPositionList">
      <wsdl:documentation>
        <summary>Gets an array of Position objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPositionList" name="GetPositionListRequest" message="tns:GetPositionListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPositionListResponse" name="GetPositionListResponse" message="tns:GetPositionListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPositions">
      <wsdl:documentation>
        <summary>Returns all the positions a person could have.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPositions" name="GetPositionsRequest" message="tns:GetPositionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPositionsResponse" name="GetPositionsResponse" message="tns:GetPositionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPriority">
      <wsdl:documentation>
        <summary>Gets a Priority object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPriority" name="GetPriorityRequest" message="tns:GetPriorityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPriorityResponse" name="GetPriorityResponse" message="tns:GetPriorityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPriorityList">
      <wsdl:documentation>
        <summary>Gets an array of Priority objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPriorityList" name="GetPriorityListRequest" message="tns:GetPriorityListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPriorityListResponse" name="GetPriorityListResponse" message="tns:GetPriorityListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPriorities">
      <wsdl:documentation>
        <summary>Returns all priorities an appointment could have.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPriorities" name="GetPrioritiesRequest" message="tns:GetPrioritiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPrioritiesResponse" name="GetPrioritiesResponse" message="tns:GetPrioritiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProductCategory">
      <wsdl:documentation>
        <summary>Gets a ProductCategory object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProductCategory" name="GetProductCategoryRequest" message="tns:GetProductCategoryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProductCategoryResponse" name="GetProductCategoryResponse" message="tns:GetProductCategoryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProductCategories">
      <wsdl:documentation>
        <summary>Returns all ProductCategories in SuperOffice list.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProductCategories" name="GetProductCategoriesRequest" message="tns:GetProductCategoriesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProductCategoriesResponse" name="GetProductCategoriesResponse" message="tns:GetProductCategoriesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProductFamily">
      <wsdl:documentation>
        <summary>Gets a ProductFamily object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProductFamily" name="GetProductFamilyRequest" message="tns:GetProductFamilyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProductFamilyResponse" name="GetProductFamilyResponse" message="tns:GetProductFamilyResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProductFamilies">
      <wsdl:documentation>
        <summary>Returns all ProductFamily in SuperOffice list.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProductFamilies" name="GetProductFamiliesRequest" message="tns:GetProductFamiliesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProductFamiliesResponse" name="GetProductFamiliesResponse" message="tns:GetProductFamiliesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProductType">
      <wsdl:documentation>
        <summary>Gets a ProductType object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProductType" name="GetProductTypeRequest" message="tns:GetProductTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProductTypeResponse" name="GetProductTypeResponse" message="tns:GetProductTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProductTypes">
      <wsdl:documentation>
        <summary>Returns all ProductTypes in SuperOffice list.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProductTypes" name="GetProductTypesRequest" message="tns:GetProductTypesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProductTypesResponse" name="GetProductTypesResponse" message="tns:GetProductTypesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectStatus">
      <wsdl:documentation>
        <summary>Gets a ProjectStatus object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectStatus" name="GetProjectStatusRequest" message="tns:GetProjectStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectStatusResponse" name="GetProjectStatusResponse" message="tns:GetProjectStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteProjectStatus">
      <wsdl:documentation>
        <summary>Deletes a project status</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteProjectStatus" name="DeleteProjectStatusRequest" message="tns:DeleteProjectStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteProjectStatusResponse" name="DeleteProjectStatusResponse" message="tns:DeleteProjectStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectStatusList">
      <wsdl:documentation>
        <summary>Gets an array of ProjectStatus objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectStatusList" name="GetProjectStatusListRequest" message="tns:GetProjectStatusListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectStatusListResponse" name="GetProjectStatusListResponse" message="tns:GetProjectStatusListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectStatuses">
      <wsdl:documentation>
        <summary>Gets all items from the Project Status (ProjStatus) table.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectStatuses" name="GetProjectStatusesRequest" message="tns:GetProjectStatusesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectStatusesResponse" name="GetProjectStatusesResponse" message="tns:GetProjectStatusesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectType">
      <wsdl:documentation>
        <summary>Gets a ProjectType object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectType" name="GetProjectTypeRequest" message="tns:GetProjectTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectTypeResponse" name="GetProjectTypeResponse" message="tns:GetProjectTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectTypeEntity">
      <wsdl:documentation>
        <summary>Gets a ProjectTypeEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectTypeEntity" name="GetProjectTypeEntityRequest" message="tns:GetProjectTypeEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectTypeEntityResponse" name="GetProjectTypeEntityResponse" message="tns:GetProjectTypeEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectTypeList">
      <wsdl:documentation>
        <summary>Gets an array of ProjectType objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectTypeList" name="GetProjectTypeListRequest" message="tns:GetProjectTypeListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectTypeListResponse" name="GetProjectTypeListResponse" message="tns:GetProjectTypeListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectTypes">
      <wsdl:documentation>
        <summary>Gets all items from the Project Type (ProjType) table.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectTypes" name="GetProjectTypesRequest" message="tns:GetProjectTypesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectTypesResponse" name="GetProjectTypesResponse" message="tns:GetProjectTypesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetRating">
      <wsdl:documentation>
        <summary>Gets a Rating object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetRating" name="GetRatingRequest" message="tns:GetRatingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetRatingResponse" name="GetRatingResponse" message="tns:GetRatingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetRatingList">
      <wsdl:documentation>
        <summary>Gets an array of Rating objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetRatingList" name="GetRatingListRequest" message="tns:GetRatingListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetRatingListResponse" name="GetRatingListResponse" message="tns:GetRatingListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetRatings">
      <wsdl:documentation>
        <summary>Returns all ratings</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetRatings" name="GetRatingsRequest" message="tns:GetRatingsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetRatingsResponse" name="GetRatingsResponse" message="tns:GetRatingsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllSaleStages">
      <wsdl:documentation>
        <summary>Returns all ratings</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllSaleStages" name="GetAllSaleStagesRequest" message="tns:GetAllSaleStagesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllSaleStagesResponse" name="GetAllSaleStagesResponse" message="tns:GetAllSaleStagesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetReason">
      <wsdl:documentation>
        <summary>Gets a Reason object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReason" name="GetReasonRequest" message="tns:GetReasonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasonResponse" name="GetReasonResponse" message="tns:GetReasonResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetReasonList">
      <wsdl:documentation>
        <summary>Gets an array of Reason objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasonList" name="GetReasonListRequest" message="tns:GetReasonListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasonListResponse" name="GetReasonListResponse" message="tns:GetReasonListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetReasons">
      <wsdl:documentation>
        <summary>Returns all reasons</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasons" name="GetReasonsRequest" message="tns:GetReasonsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasonsResponse" name="GetReasonsResponse" message="tns:GetReasonsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetReasonSold">
      <wsdl:documentation>
        <summary>Gets a ReasonSold object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasonSold" name="GetReasonSoldRequest" message="tns:GetReasonSoldRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasonSoldResponse" name="GetReasonSoldResponse" message="tns:GetReasonSoldResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultCurrencyEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new CurrencyEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultCurrencyEntity" name="CreateDefaultCurrencyEntityRequest" message="tns:CreateDefaultCurrencyEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultCurrencyEntityResponse" name="CreateDefaultCurrencyEntityResponse" message="tns:CreateDefaultCurrencyEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveCurrencyEntity">
      <wsdl:documentation>
        <summary>Updates the existing CurrencyEntity or creates a new CurrencyEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveCurrencyEntity" name="SaveCurrencyEntityRequest" message="tns:SaveCurrencyEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveCurrencyEntityResponse" name="SaveCurrencyEntityResponse" message="tns:SaveCurrencyEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAmountClassEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new AmountClassEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultAmountClassEntity" name="CreateDefaultAmountClassEntityRequest" message="tns:CreateDefaultAmountClassEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultAmountClassEntityResponse" name="CreateDefaultAmountClassEntityResponse" message="tns:CreateDefaultAmountClassEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveAmountClassEntity">
      <wsdl:documentation>
        <summary>Updates the existing AmountClassEntity or creates a new AmountClassEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveAmountClassEntity" name="SaveAmountClassEntityRequest" message="tns:SaveAmountClassEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveAmountClassEntityResponse" name="SaveAmountClassEntityResponse" message="tns:SaveAmountClassEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultHeadingEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new HeadingEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultHeadingEntity" name="CreateDefaultHeadingEntityRequest" message="tns:CreateDefaultHeadingEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultHeadingEntityResponse" name="CreateDefaultHeadingEntityResponse" message="tns:CreateDefaultHeadingEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveHeadingEntity">
      <wsdl:documentation>
        <summary>Updates the existing HeadingEntity or creates a new HeadingEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingEntity" name="SaveHeadingEntityRequest" message="tns:SaveHeadingEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingEntityResponse" name="SaveHeadingEntityResponse" message="tns:SaveHeadingEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultListEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new ListEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultListEntity" name="CreateDefaultListEntityRequest" message="tns:CreateDefaultListEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultListEntityResponse" name="CreateDefaultListEntityResponse" message="tns:CreateDefaultListEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveListEntity">
      <wsdl:documentation>
        <summary>Updates the existing ListEntity or creates a new ListEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveListEntity" name="SaveListEntityRequest" message="tns:SaveListEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveListEntityResponse" name="SaveListEntityResponse" message="tns:SaveListEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteListEntity">
      <wsdl:documentation>
        <summary>Deletes the ListEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteListEntity" name="DeleteListEntityRequest" message="tns:DeleteListEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteListEntityResponse" name="DeleteListEntityResponse" message="tns:DeleteListEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultListItemEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new ListItemEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultListItemEntity" name="CreateDefaultListItemEntityRequest" message="tns:CreateDefaultListItemEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultListItemEntityResponse" name="CreateDefaultListItemEntityResponse" message="tns:CreateDefaultListItemEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultProjectTypeEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new ProjectTypeEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultProjectTypeEntity" name="CreateDefaultProjectTypeEntityRequest" message="tns:CreateDefaultProjectTypeEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultProjectTypeEntityResponse" name="CreateDefaultProjectTypeEntityResponse" message="tns:CreateDefaultProjectTypeEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveProjectTypeEntity">
      <wsdl:documentation>
        <summary>Updates the existing ProjectTypeEntity or creates a new ProjectTypeEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveProjectTypeEntity" name="SaveProjectTypeEntityRequest" message="tns:SaveProjectTypeEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveProjectTypeEntityResponse" name="SaveProjectTypeEntityResponse" message="tns:SaveProjectTypeEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultResourceEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new ResourceEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultResourceEntity" name="CreateDefaultResourceEntityRequest" message="tns:CreateDefaultResourceEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultResourceEntityResponse" name="CreateDefaultResourceEntityResponse" message="tns:CreateDefaultResourceEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveResourceEntity">
      <wsdl:documentation>
        <summary>Updates the existing ResourceEntity or creates a new ResourceEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveResourceEntity" name="SaveResourceEntityRequest" message="tns:SaveResourceEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveResourceEntityResponse" name="SaveResourceEntityResponse" message="tns:SaveResourceEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteResourceEntity">
      <wsdl:documentation>
        <summary>Deletes the ResourceEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteResourceEntity" name="DeleteResourceEntityRequest" message="tns:DeleteResourceEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteResourceEntityResponse" name="DeleteResourceEntityResponse" message="tns:DeleteResourceEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultSaleStageEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new SaleStageEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultSaleStageEntity" name="CreateDefaultSaleStageEntityRequest" message="tns:CreateDefaultSaleStageEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultSaleStageEntityResponse" name="CreateDefaultSaleStageEntityResponse" message="tns:CreateDefaultSaleStageEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveSaleStageEntity">
      <wsdl:documentation>
        <summary>Updates the existing SaleStageEntity or creates a new SaleStageEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveSaleStageEntity" name="SaveSaleStageEntityRequest" message="tns:SaveSaleStageEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveSaleStageEntityResponse" name="SaveSaleStageEntityResponse" message="tns:SaveSaleStageEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultSaleTypeEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new SaleTypeEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultSaleTypeEntity" name="CreateDefaultSaleTypeEntityRequest" message="tns:CreateDefaultSaleTypeEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultSaleTypeEntityResponse" name="CreateDefaultSaleTypeEntityResponse" message="tns:CreateDefaultSaleTypeEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveSaleTypeEntity">
      <wsdl:documentation>
        <summary>Updates the existing SaleTypeEntity or creates a new SaleTypeEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveSaleTypeEntity" name="SaveSaleTypeEntityRequest" message="tns:SaveSaleTypeEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveSaleTypeEntityResponse" name="SaveSaleTypeEntityResponse" message="tns:SaveSaleTypeEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultWebPanelEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new WebPanelEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultWebPanelEntity" name="CreateDefaultWebPanelEntityRequest" message="tns:CreateDefaultWebPanelEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultWebPanelEntityResponse" name="CreateDefaultWebPanelEntityResponse" message="tns:CreateDefaultWebPanelEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveWebPanelEntity">
      <wsdl:documentation>
        <summary>Updates the existing WebPanelEntity or creates a new WebPanelEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveWebPanelEntity" name="SaveWebPanelEntityRequest" message="tns:SaveWebPanelEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveWebPanelEntityResponse" name="SaveWebPanelEntityResponse" message="tns:SaveWebPanelEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultExtAppEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new ExtAppEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultExtAppEntity" name="CreateDefaultExtAppEntityRequest" message="tns:CreateDefaultExtAppEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultExtAppEntityResponse" name="CreateDefaultExtAppEntityResponse" message="tns:CreateDefaultExtAppEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveExtAppEntity">
      <wsdl:documentation>
        <summary>Updates the existing ExtAppEntity or creates a new ExtAppEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveExtAppEntity" name="SaveExtAppEntityRequest" message="tns:SaveExtAppEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveExtAppEntityResponse" name="SaveExtAppEntityResponse" message="tns:SaveExtAppEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultDocumentTemplateEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new DocumentTemplateEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultDocumentTemplateEntity" name="CreateDefaultDocumentTemplateEntityRequest" message="tns:CreateDefaultDocumentTemplateEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultDocumentTemplateEntityResponse" name="CreateDefaultDocumentTemplateEntityResponse" message="tns:CreateDefaultDocumentTemplateEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveDocumentTemplateEntity">
      <wsdl:documentation>
        <summary>Updates the existing DocumentTemplateEntity or creates a new DocumentTemplateEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveDocumentTemplateEntity" name="SaveDocumentTemplateEntityRequest" message="tns:SaveDocumentTemplateEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveDocumentTemplateEntityResponse" name="SaveDocumentTemplateEntityResponse" message="tns:SaveDocumentTemplateEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultRelationDefinitionEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new RelationDefinitionEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultRelationDefinitionEntity" name="CreateDefaultRelationDefinitionEntityRequest" message="tns:CreateDefaultRelationDefinitionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultRelationDefinitionEntityResponse" name="CreateDefaultRelationDefinitionEntityResponse" message="tns:CreateDefaultRelationDefinitionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveRelationDefinitionEntity">
      <wsdl:documentation>
        <summary>Updates the existing RelationDefinitionEntity or creates a new RelationDefinitionEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveRelationDefinitionEntity" name="SaveRelationDefinitionEntityRequest" message="tns:SaveRelationDefinitionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveRelationDefinitionEntityResponse" name="SaveRelationDefinitionEntityResponse" message="tns:SaveRelationDefinitionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBusiness">
      <wsdl:documentation>
        <summary>Gets a Business object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetBusiness" name="GetBusinessRequest" message="tns:GetBusinessRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetBusinessResponse" name="GetBusinessResponse" message="tns:GetBusinessResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBusinessList">
      <wsdl:documentation>
        <summary>Gets an array of Business objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetBusinessList" name="GetBusinessListRequest" message="tns:GetBusinessListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetBusinessListResponse" name="GetBusinessListResponse" message="tns:GetBusinessListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBusinesses">
      <wsdl:documentation>
        <summary>Returns all available businesses that a contact could have.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetBusinesses" name="GetBusinessesRequest" message="tns:GetBusinessesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetBusinessesResponse" name="GetBusinessesResponse" message="tns:GetBusinessesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCategory">
      <wsdl:documentation>
        <summary>Gets a Category object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCategory" name="GetCategoryRequest" message="tns:GetCategoryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCategoryResponse" name="GetCategoryResponse" message="tns:GetCategoryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCategoryList">
      <wsdl:documentation>
        <summary>Gets an array of Category objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCategoryList" name="GetCategoryListRequest" message="tns:GetCategoryListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCategoryListResponse" name="GetCategoryListResponse" message="tns:GetCategoryListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCategories">
      <wsdl:documentation>
        <summary>Returns all categories a contact could belong to</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCategories" name="GetCategoriesRequest" message="tns:GetCategoriesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCategoriesResponse" name="GetCategoriesResponse" message="tns:GetCategoriesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCompetitor">
      <wsdl:documentation>
        <summary>Gets a Competitor object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCompetitor" name="GetCompetitorRequest" message="tns:GetCompetitorRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCompetitorResponse" name="GetCompetitorResponse" message="tns:GetCompetitorResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCompetitorList">
      <wsdl:documentation>
        <summary>Gets an array of Competitor objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCompetitorList" name="GetCompetitorListRequest" message="tns:GetCompetitorListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCompetitorListResponse" name="GetCompetitorListResponse" message="tns:GetCompetitorListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCompetitors">
      <wsdl:documentation>
        <summary>Returns all competitors</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCompetitors" name="GetCompetitorsRequest" message="tns:GetCompetitorsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCompetitorsResponse" name="GetCompetitorsResponse" message="tns:GetCompetitorsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCountry">
      <wsdl:documentation>
        <summary>Gets a Country object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCountry" name="GetCountryRequest" message="tns:GetCountryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCountryResponse" name="GetCountryResponse" message="tns:GetCountryResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveCountry">
      <wsdl:documentation>
        <summary>Saves a country</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveCountry" name="SaveCountryRequest" message="tns:SaveCountryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveCountryResponse" name="SaveCountryResponse" message="tns:SaveCountryResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultCountry">
      <wsdl:documentation>
        <summary>Gets a new country</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultCountry" name="CreateDefaultCountryRequest" message="tns:CreateDefaultCountryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultCountryResponse" name="CreateDefaultCountryResponse" message="tns:CreateDefaultCountryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCountryList">
      <wsdl:documentation>
        <summary>Gets an array of Country objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCountryList" name="GetCountryListRequest" message="tns:GetCountryListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCountryListResponse" name="GetCountryListResponse" message="tns:GetCountryListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCountries">
      <wsdl:documentation>
        <summary>Returns all available countries a contact or person could belong to.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCountries" name="GetCountriesRequest" message="tns:GetCountriesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCountriesResponse" name="GetCountriesResponse" message="tns:GetCountriesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllCountries">
      <wsdl:documentation>
        <summary>Returns all available countries a contact or person could belong to.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllCountries" name="GetAllCountriesRequest" message="tns:GetAllCountriesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllCountriesResponse" name="GetAllCountriesResponse" message="tns:GetAllCountriesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCredited">
      <wsdl:documentation>
        <summary>Gets a Credited object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCredited" name="GetCreditedRequest" message="tns:GetCreditedRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCreditedResponse" name="GetCreditedResponse" message="tns:GetCreditedResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCreditedList">
      <wsdl:documentation>
        <summary>Gets an array of Credited objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCreditedList" name="GetCreditedListRequest" message="tns:GetCreditedListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCreditedListResponse" name="GetCreditedListResponse" message="tns:GetCreditedListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCrediteds">
      <wsdl:documentation>
        <summary>Returns all credited</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCrediteds" name="GetCreditedsRequest" message="tns:GetCreditedsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCreditedsResponse" name="GetCreditedsResponse" message="tns:GetCreditedsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCurrency">
      <wsdl:documentation>
        <summary>Gets a Currency object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCurrency" name="GetCurrencyRequest" message="tns:GetCurrencyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCurrencyResponse" name="GetCurrencyResponse" message="tns:GetCurrencyResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetOurCurrency">
      <wsdl:documentation>
        <summary>Gets the Our currency object if currency is enabled</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetOurCurrency" name="GetOurCurrencyRequest" message="tns:GetOurCurrencyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetOurCurrencyResponse" name="GetOurCurrencyResponse" message="tns:GetOurCurrencyResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChangeCurrency">
      <wsdl:documentation>
        <summary>Recalculates the amount to the new currency.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/ChangeCurrency" name="ChangeCurrencyRequest" message="tns:ChangeCurrencyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/ChangeCurrencyResponse" name="ChangeCurrencyResponse" message="tns:ChangeCurrencyResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetOwnerCompanysCurrency">
      <wsdl:documentation>
        <summary>Get the currency of the user's owner company</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetOwnerCompanysCurrency" name="GetOwnerCompanysCurrencyRequest" message="tns:GetOwnerCompanysCurrencyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetOwnerCompanysCurrencyResponse" name="GetOwnerCompanysCurrencyResponse" message="tns:GetOwnerCompanysCurrencyResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCurrencyEntity">
      <wsdl:documentation>
        <summary>Gets a CurrencyEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCurrencyEntity" name="GetCurrencyEntityRequest" message="tns:GetCurrencyEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCurrencyEntityResponse" name="GetCurrencyEntityResponse" message="tns:GetCurrencyEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBaseCurrency">
      <wsdl:documentation>
        <summary>Get the base currency, used for calculating exchange rates</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetBaseCurrency" name="GetBaseCurrencyRequest" message="tns:GetBaseCurrencyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetBaseCurrencyResponse" name="GetBaseCurrencyResponse" message="tns:GetBaseCurrencyResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAmountClassEntity">
      <wsdl:documentation>
        <summary>Gets a AmountClassEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAmountClassEntity" name="GetAmountClassEntityRequest" message="tns:GetAmountClassEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAmountClassEntityResponse" name="GetAmountClassEntityResponse" message="tns:GetAmountClassEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCurrencyList">
      <wsdl:documentation>
        <summary>Gets an array of Currency objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCurrencyList" name="GetCurrencyListRequest" message="tns:GetCurrencyListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCurrencyListResponse" name="GetCurrencyListResponse" message="tns:GetCurrencyListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCurrencies">
      <wsdl:documentation>
        <summary>Returns all currencies</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCurrencies" name="GetCurrenciesRequest" message="tns:GetCurrenciesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCurrenciesResponse" name="GetCurrenciesResponse" message="tns:GetCurrenciesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllCurrencies">
      <wsdl:documentation>
        <summary>Returns all currencies</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllCurrencies" name="GetAllCurrenciesRequest" message="tns:GetAllCurrenciesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllCurrenciesResponse" name="GetAllCurrenciesResponse" message="tns:GetAllCurrenciesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCustomerLanguage">
      <wsdl:documentation>
        <summary>Gets a CustomerLanguage object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCustomerLanguage" name="GetCustomerLanguageRequest" message="tns:GetCustomerLanguageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCustomerLanguageResponse" name="GetCustomerLanguageResponse" message="tns:GetCustomerLanguageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCustomerLanguageList">
      <wsdl:documentation>
        <summary>Gets an array of CustomerLanguage objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCustomerLanguageList" name="GetCustomerLanguageListRequest" message="tns:GetCustomerLanguageListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCustomerLanguageListResponse" name="GetCustomerLanguageListResponse" message="tns:GetCustomerLanguageListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCustomerLanguages">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCustomerLanguages" name="GetCustomerLanguagesRequest" message="tns:GetCustomerLanguagesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCustomerLanguagesResponse" name="GetCustomerLanguagesResponse" message="tns:GetCustomerLanguagesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDeliveryTerm">
      <wsdl:documentation>
        <summary>Gets a DeliveryTerm object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDeliveryTerm" name="GetDeliveryTermRequest" message="tns:GetDeliveryTermRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDeliveryTermResponse" name="GetDeliveryTermResponse" message="tns:GetDeliveryTermResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDeliveryTerms">
      <wsdl:documentation>
        <summary>Returns all DeliveryTerms in SuperOffice db.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDeliveryTerms" name="GetDeliveryTermsRequest" message="tns:GetDeliveryTermsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDeliveryTermsResponse" name="GetDeliveryTermsResponse" message="tns:GetDeliveryTermsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDeliveryType">
      <wsdl:documentation>
        <summary>Gets a DeliveryType object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDeliveryType" name="GetDeliveryTypeRequest" message="tns:GetDeliveryTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDeliveryTypeResponse" name="GetDeliveryTypeResponse" message="tns:GetDeliveryTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDeliveryTypes">
      <wsdl:documentation>
        <summary>Returns all DeliveryTypes in SuperOffice db.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDeliveryTypes" name="GetDeliveryTypesRequest" message="tns:GetDeliveryTypesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDeliveryTypesResponse" name="GetDeliveryTypesResponse" message="tns:GetDeliveryTypesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPaymentTerm">
      <wsdl:documentation>
        <summary>Gets a PaymentTerm object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPaymentTerm" name="GetPaymentTermRequest" message="tns:GetPaymentTermRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPaymentTermResponse" name="GetPaymentTermResponse" message="tns:GetPaymentTermResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPaymentTerms">
      <wsdl:documentation>
        <summary>Returns all PaymentTerms in SuperOffice db.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPaymentTerms" name="GetPaymentTermsRequest" message="tns:GetPaymentTermsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPaymentTermsResponse" name="GetPaymentTermsResponse" message="tns:GetPaymentTermsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPaymentType">
      <wsdl:documentation>
        <summary>Gets a PaymentType object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPaymentType" name="GetPaymentTypeRequest" message="tns:GetPaymentTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPaymentTypeResponse" name="GetPaymentTypeResponse" message="tns:GetPaymentTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPaymentTypes">
      <wsdl:documentation>
        <summary>Returns all PaymentTypes in SuperOffice db.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPaymentTypes" name="GetPaymentTypesRequest" message="tns:GetPaymentTypesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPaymentTypesResponse" name="GetPaymentTypesResponse" message="tns:GetPaymentTypesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDepartment">
      <wsdl:documentation>
        <summary>Gets a Department object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDepartment" name="GetDepartmentRequest" message="tns:GetDepartmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDepartmentResponse" name="GetDepartmentResponse" message="tns:GetDepartmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDepartmentList">
      <wsdl:documentation>
        <summary>Gets an array of Department objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDepartmentList" name="GetDepartmentListRequest" message="tns:GetDepartmentListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDepartmentListResponse" name="GetDepartmentListResponse" message="tns:GetDepartmentListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDepartments">
      <wsdl:documentation>
        <summary>Getting all departments/user groups for the internal phone list with the user's colleagues.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDepartments" name="GetDepartmentsRequest" message="tns:GetDepartmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDepartmentsResponse" name="GetDepartmentsResponse" message="tns:GetDepartmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplate">
      <wsdl:documentation>
        <summary>Gets a DocumentTemplate object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplate" name="GetDocumentTemplateRequest" message="tns:GetDocumentTemplateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateResponse" name="GetDocumentTemplateResponse" message="tns:GetDocumentTemplateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateList">
      <wsdl:documentation>
        <summary>Gets an array of DocumentTemplate objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateList" name="GetDocumentTemplateListRequest" message="tns:GetDocumentTemplateListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateListResponse" name="GetDocumentTemplateListResponse" message="tns:GetDocumentTemplateListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplates">
      <wsdl:documentation>
        <summary>Returns all available document templates</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplates" name="GetDocumentTemplatesRequest" message="tns:GetDocumentTemplatesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplatesResponse" name="GetDocumentTemplatesResponse" message="tns:GetDocumentTemplatesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllDocumentTemplates">
      <wsdl:documentation>
        <summary>Returns all templates</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllDocumentTemplates" name="GetAllDocumentTemplatesRequest" message="tns:GetAllDocumentTemplatesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllDocumentTemplatesResponse" name="GetAllDocumentTemplatesResponse" message="tns:GetAllDocumentTemplatesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetHeadingEntity">
      <wsdl:documentation>
        <summary>Gets a HeadingEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetHeadingEntity" name="GetHeadingEntityRequest" message="tns:GetHeadingEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetHeadingEntityResponse" name="GetHeadingEntityResponse" message="tns:GetHeadingEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultHeadingFromListDefinition">
      <wsdl:documentation>
        <summary>Get a heading for the specified list defintion</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultHeadingFromListDefinition" name="CreateDefaultHeadingFromListDefinitionRequest" message="tns:CreateDefaultHeadingFromListDefinitionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultHeadingFromListDefinitionResponse" name="CreateDefaultHeadingFromListDefinitionResponse" message="tns:CreateDefaultHeadingFromListDefinitionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLanguageInfo">
      <wsdl:documentation>
        <summary>Gets a LanguageInfo object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLanguageInfo" name="GetLanguageInfoRequest" message="tns:GetLanguageInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLanguageInfoResponse" name="GetLanguageInfoResponse" message="tns:GetLanguageInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLanguageInfoList">
      <wsdl:documentation>
        <summary>Gets an array of LanguageInfo objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLanguageInfoList" name="GetLanguageInfoListRequest" message="tns:GetLanguageInfoListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLanguageInfoListResponse" name="GetLanguageInfoListResponse" message="tns:GetLanguageInfoListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetInstalledLanguages">
      <wsdl:documentation>
        <summary>Returns the list of all languages installed in this database.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetInstalledLanguages" name="GetInstalledLanguagesRequest" message="tns:GetInstalledLanguagesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetInstalledLanguagesResponse" name="GetInstalledLanguagesResponse" message="tns:GetInstalledLanguagesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLink">
      <wsdl:documentation>
        <summary>Gets a Link object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLink" name="GetLinkRequest" message="tns:GetLinkRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLinkResponse" name="GetLinkResponse" message="tns:GetLinkResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLinkList">
      <wsdl:documentation>
        <summary>Gets an array of Link objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLinkList" name="GetLinkListRequest" message="tns:GetLinkListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLinkListResponse" name="GetLinkListResponse" message="tns:GetLinkListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetListEntity">
      <wsdl:documentation>
        <summary>Gets a ListEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListEntity" name="GetListEntityRequest" message="tns:GetListEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListEntityResponse" name="GetListEntityResponse" message="tns:GetListEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetListDefinitions">
      <wsdl:documentation>
        <summary>Get a list of the lists - built-in and user-defined.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListDefinitions" name="GetListDefinitionsRequest" message="tns:GetListDefinitionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListDefinitionsResponse" name="GetListDefinitionsResponse" message="tns:GetListDefinitionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetListEntityByName">
      <wsdl:documentation>
        <summary>Gets a ListEntity resolved by the provided name.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListEntityByName" name="GetListEntityByNameRequest" message="tns:GetListEntityByNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListEntityByNameResponse" name="GetListEntityByNameResponse" message="tns:GetListEntityByNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveListEntityByName">
      <wsdl:documentation>
        <summary>Save a ListEntity resolved by the provided name.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveListEntityByName" name="SaveListEntityByNameRequest" message="tns:SaveListEntityByNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveListEntityByNameResponse" name="SaveListEntityByNameResponse" message="tns:SaveListEntityByNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteListEntityByName">
      <wsdl:documentation>
        <summary>Delete a ListEntity resolved by the provided name.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteListEntityByName" name="DeleteListEntityByNameRequest" message="tns:DeleteListEntityByNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteListEntityByNameResponse" name="DeleteListEntityByNameResponse" message="tns:DeleteListEntityByNameResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_List" type="tns:List">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="GetAllReasonSold">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllReasonSold" style="document" />
      <wsdl:input name="GetAllReasonSoldRequest">
        <soap:header message="tns:GetAllReasonSoldRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllReasonSoldRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllReasonSoldRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllReasonSoldResponse">
        <soap:header message="tns:GetAllReasonSoldResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllReasonSoldResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllReasonSoldResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllReasonSoldResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetReasonSoldList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasonSoldList" style="document" />
      <wsdl:input name="GetReasonSoldListRequest">
        <soap:header message="tns:GetReasonSoldListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetReasonSoldListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetReasonSoldListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetReasonSoldListResponse">
        <soap:header message="tns:GetReasonSoldListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetReasonSoldListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetReasonSoldListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetReasonSoldListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetReasonStalled">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasonStalled" style="document" />
      <wsdl:input name="GetReasonStalledRequest">
        <soap:header message="tns:GetReasonStalledRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetReasonStalledRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetReasonStalledRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetReasonStalledResponse">
        <soap:header message="tns:GetReasonStalledResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetReasonStalledResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetReasonStalledResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetReasonStalledResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllReasonStalled">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllReasonStalled" style="document" />
      <wsdl:input name="GetAllReasonStalledRequest">
        <soap:header message="tns:GetAllReasonStalledRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllReasonStalledRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllReasonStalledRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllReasonStalledResponse">
        <soap:header message="tns:GetAllReasonStalledResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllReasonStalledResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllReasonStalledResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllReasonStalledResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetReasonStalledList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasonStalledList" style="document" />
      <wsdl:input name="GetReasonStalledListRequest">
        <soap:header message="tns:GetReasonStalledListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetReasonStalledListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetReasonStalledListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetReasonStalledListResponse">
        <soap:header message="tns:GetReasonStalledListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetReasonStalledListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetReasonStalledListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetReasonStalledListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetResourceEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetResourceEntity" style="document" />
      <wsdl:input name="GetResourceEntityRequest">
        <soap:header message="tns:GetResourceEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetResourceEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetResourceEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetResourceEntityResponse">
        <soap:header message="tns:GetResourceEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetResourceEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetResourceEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetResourceEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSaleStageEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSaleStageEntity" style="document" />
      <wsdl:input name="GetSaleStageEntityRequest">
        <soap:header message="tns:GetSaleStageEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSaleStageEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSaleStageEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSaleStageEntityResponse">
        <soap:header message="tns:GetSaleStageEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSaleStageEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSaleStageEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSaleStageEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSaleType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSaleType" style="document" />
      <wsdl:input name="GetSaleTypeRequest">
        <soap:header message="tns:GetSaleTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSaleTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSaleTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSaleTypeResponse">
        <soap:header message="tns:GetSaleTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSaleTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSaleTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSaleTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSaleTypeEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSaleTypeEntity" style="document" />
      <wsdl:input name="GetSaleTypeEntityRequest">
        <soap:header message="tns:GetSaleTypeEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSaleTypeEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSaleTypeEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSaleTypeEntityResponse">
        <soap:header message="tns:GetSaleTypeEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSaleTypeEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSaleTypeEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSaleTypeEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllSaleType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllSaleType" style="document" />
      <wsdl:input name="GetAllSaleTypeRequest">
        <soap:header message="tns:GetAllSaleTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllSaleTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllSaleTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllSaleTypeResponse">
        <soap:header message="tns:GetAllSaleTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllSaleTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllSaleTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllSaleTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSaleTypeList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSaleTypeList" style="document" />
      <wsdl:input name="GetSaleTypeListRequest">
        <soap:header message="tns:GetSaleTypeListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSaleTypeListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSaleTypeListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSaleTypeListResponse">
        <soap:header message="tns:GetSaleTypeListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSaleTypeListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSaleTypeListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSaleTypeListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSelectionCategory">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSelectionCategory" style="document" />
      <wsdl:input name="GetSelectionCategoryRequest">
        <soap:header message="tns:GetSelectionCategoryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSelectionCategoryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSelectionCategoryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSelectionCategoryResponse">
        <soap:header message="tns:GetSelectionCategoryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSelectionCategoryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSelectionCategoryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSelectionCategoryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllSelectionCategory">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllSelectionCategory" style="document" />
      <wsdl:input name="GetAllSelectionCategoryRequest">
        <soap:header message="tns:GetAllSelectionCategoryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllSelectionCategoryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllSelectionCategoryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllSelectionCategoryResponse">
        <soap:header message="tns:GetAllSelectionCategoryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllSelectionCategoryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllSelectionCategoryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllSelectionCategoryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSelectionCategoryList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSelectionCategoryList" style="document" />
      <wsdl:input name="GetSelectionCategoryListRequest">
        <soap:header message="tns:GetSelectionCategoryListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSelectionCategoryListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSelectionCategoryListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSelectionCategoryListResponse">
        <soap:header message="tns:GetSelectionCategoryListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSelectionCategoryListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSelectionCategoryListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSelectionCategoryListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSource">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSource" style="document" />
      <wsdl:input name="GetSourceRequest">
        <soap:header message="tns:GetSourceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSourceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSourceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSourceResponse">
        <soap:header message="tns:GetSourceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSourceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSourceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSourceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSourceList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSourceList" style="document" />
      <wsdl:input name="GetSourceListRequest">
        <soap:header message="tns:GetSourceListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSourceListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSourceListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSourceListResponse">
        <soap:header message="tns:GetSourceListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSourceListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSourceListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSourceListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSources">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetSources" style="document" />
      <wsdl:input name="GetSourcesRequest">
        <soap:header message="tns:GetSourcesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSourcesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSourcesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSourcesResponse">
        <soap:header message="tns:GetSourcesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSourcesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSourcesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSourcesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTask">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetTask" style="document" />
      <wsdl:input name="GetTaskRequest">
        <soap:header message="tns:GetTaskRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTaskRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTaskRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTaskResponse">
        <soap:header message="tns:GetTaskResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTaskResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTaskResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTaskResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateTask">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateTask" style="document" />
      <wsdl:input name="GetDocumentTemplateTaskRequest">
        <soap:header message="tns:GetDocumentTemplateTaskRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentTemplateTaskRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentTemplateTaskRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentTemplateTaskResponse">
        <soap:header message="tns:GetDocumentTemplateTaskResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateTaskResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateTaskResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentTemplateTaskResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTaskList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetTaskList" style="document" />
      <wsdl:input name="GetTaskListRequest">
        <soap:header message="tns:GetTaskListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTaskListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTaskListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTaskListResponse">
        <soap:header message="tns:GetTaskListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTaskListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTaskListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTaskListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTasks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetTasks" style="document" />
      <wsdl:input name="GetTasksRequest">
        <soap:header message="tns:GetTasksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTasksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTasksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTasksResponse">
        <soap:header message="tns:GetTasksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTasksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTasksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTasksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplatesTasks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplatesTasks" style="document" />
      <wsdl:input name="GetDocumentTemplatesTasksRequest">
        <soap:header message="tns:GetDocumentTemplatesTasksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentTemplatesTasksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentTemplatesTasksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentTemplatesTasksResponse">
        <soap:header message="tns:GetDocumentTemplatesTasksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplatesTasksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplatesTasksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentTemplatesTasksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllTasks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllTasks" style="document" />
      <wsdl:input name="GetAllTasksRequest">
        <soap:header message="tns:GetAllTasksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllTasksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllTasksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllTasksResponse">
        <soap:header message="tns:GetAllTasksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllTasksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllTasksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllTasksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTicketPriority">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetTicketPriority" style="document" />
      <wsdl:input name="GetTicketPriorityRequest">
        <soap:header message="tns:GetTicketPriorityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTicketPriorityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTicketPriorityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTicketPriorityResponse">
        <soap:header message="tns:GetTicketPriorityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTicketPriorityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTicketPriorityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTicketPriorityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTicketPriorityList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetTicketPriorityList" style="document" />
      <wsdl:input name="GetTicketPriorityListRequest">
        <soap:header message="tns:GetTicketPriorityListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTicketPriorityListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTicketPriorityListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTicketPriorityListResponse">
        <soap:header message="tns:GetTicketPriorityListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTicketPriorityListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTicketPriorityListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTicketPriorityListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTicketPriorities">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetTicketPriorities" style="document" />
      <wsdl:input name="GetTicketPrioritiesRequest">
        <soap:header message="tns:GetTicketPrioritiesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTicketPrioritiesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTicketPrioritiesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTicketPrioritiesResponse">
        <soap:header message="tns:GetTicketPrioritiesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTicketPrioritiesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTicketPrioritiesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTicketPrioritiesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetWebPanelEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetWebPanelEntity" style="document" />
      <wsdl:input name="GetWebPanelEntityRequest">
        <soap:header message="tns:GetWebPanelEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetWebPanelEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetWebPanelEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetWebPanelEntityResponse">
        <soap:header message="tns:GetWebPanelEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetWebPanelEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetWebPanelEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetWebPanelEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GenerateNavigationUrl">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GenerateNavigationUrl" style="document" />
      <wsdl:input name="GenerateNavigationUrlRequest">
        <soap:header message="tns:GenerateNavigationUrlRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GenerateNavigationUrlRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GenerateNavigationUrlRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GenerateNavigationUrlResponse">
        <soap:header message="tns:GenerateNavigationUrlResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GenerateNavigationUrlResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GenerateNavigationUrlResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GenerateNavigationUrlResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetWebPanelList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetWebPanelList" style="document" />
      <wsdl:input name="GetWebPanelListRequest">
        <soap:header message="tns:GetWebPanelListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetWebPanelListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetWebPanelListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetWebPanelListResponse">
        <soap:header message="tns:GetWebPanelListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetWebPanelListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetWebPanelListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetWebPanelListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteWebPanel">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteWebPanel" style="document" />
      <wsdl:input name="DeleteWebPanelRequest">
        <soap:header message="tns:DeleteWebPanelRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteWebPanelRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteWebPanelRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteWebPanelResponse">
        <soap:header message="tns:DeleteWebPanelResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteWebPanelResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteWebPanelResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteWebPanelResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAppWebPanels">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAppWebPanels" style="document" />
      <wsdl:input name="GetAppWebPanelsRequest">
        <soap:header message="tns:GetAppWebPanelsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAppWebPanelsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAppWebPanelsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAppWebPanelsResponse">
        <soap:header message="tns:GetAppWebPanelsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAppWebPanelsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAppWebPanelsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAppWebPanelsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteAppWebPanels">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteAppWebPanels" style="document" />
      <wsdl:input name="DeleteAppWebPanelsRequest">
        <soap:header message="tns:DeleteAppWebPanelsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteAppWebPanelsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteAppWebPanelsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteAppWebPanelsResponse">
        <soap:header message="tns:DeleteAppWebPanelsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteAppWebPanelsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteAppWebPanelsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteAppWebPanelsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetWebPanelByProgId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetWebPanelByProgId" style="document" />
      <wsdl:input name="GetWebPanelByProgIdRequest">
        <soap:header message="tns:GetWebPanelByProgIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetWebPanelByProgIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetWebPanelByProgIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetWebPanelByProgIdResponse">
        <soap:header message="tns:GetWebPanelByProgIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetWebPanelByProgIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetWebPanelByProgIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetWebPanelByProgIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetExtAppEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetExtAppEntity" style="document" />
      <wsdl:input name="GetExtAppEntityRequest">
        <soap:header message="tns:GetExtAppEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetExtAppEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetExtAppEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetExtAppEntityResponse">
        <soap:header message="tns:GetExtAppEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetExtAppEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetExtAppEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetExtAppEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateEntity" style="document" />
      <wsdl:input name="GetDocumentTemplateEntityRequest">
        <soap:header message="tns:GetDocumentTemplateEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentTemplateEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentTemplateEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentTemplateEntityResponse">
        <soap:header message="tns:GetDocumentTemplateEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentTemplateEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetDocumentTemplateStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetDocumentTemplateStream" style="document" />
      <wsdl:input name="SetDocumentTemplateStreamRequest">
        <soap:header message="tns:SetDocumentTemplateStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetDocumentTemplateStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetDocumentTemplateStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetDocumentTemplateStreamResponse">
        <soap:header message="tns:SetDocumentTemplateStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetDocumentTemplateStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetDocumentTemplateStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetDocumentTemplateStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateUsedInSalesStage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateUsedInSalesStage" style="document" />
      <wsdl:input name="GetDocumentTemplateUsedInSalesStageRequest">
        <soap:header message="tns:GetDocumentTemplateUsedInSalesStageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentTemplateUsedInSalesStageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentTemplateUsedInSalesStageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentTemplateUsedInSalesStageResponse">
        <soap:header message="tns:GetDocumentTemplateUsedInSalesStageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateUsedInSalesStageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateUsedInSalesStageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentTemplateUsedInSalesStageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateUsedInProjectStage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateUsedInProjectStage" style="document" />
      <wsdl:input name="GetDocumentTemplateUsedInProjectStageRequest">
        <soap:header message="tns:GetDocumentTemplateUsedInProjectStageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentTemplateUsedInProjectStageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentTemplateUsedInProjectStageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentTemplateUsedInProjectStageResponse">
        <soap:header message="tns:GetDocumentTemplateUsedInProjectStageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateUsedInProjectStageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateUsedInProjectStageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentTemplateUsedInProjectStageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateUrl">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateUrl" style="document" />
      <wsdl:input name="GetDocumentTemplateUrlRequest">
        <soap:header message="tns:GetDocumentTemplateUrlRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentTemplateUrlRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentTemplateUrlRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentTemplateUrlResponse">
        <soap:header message="tns:GetDocumentTemplateUrlResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateUrlResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateUrlResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentTemplateUrlResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateProperties">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateProperties" style="document" />
      <wsdl:input name="GetDocumentTemplatePropertiesRequest">
        <soap:header message="tns:GetDocumentTemplatePropertiesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentTemplatePropertiesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentTemplatePropertiesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentTemplatePropertiesResponse">
        <soap:header message="tns:GetDocumentTemplatePropertiesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplatePropertiesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplatePropertiesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentTemplatePropertiesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateLanguages">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateLanguages" style="document" />
      <wsdl:input name="GetDocumentTemplateLanguagesRequest">
        <soap:header message="tns:GetDocumentTemplateLanguagesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentTemplateLanguagesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentTemplateLanguagesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentTemplateLanguagesResponse">
        <soap:header message="tns:GetDocumentTemplateLanguagesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateLanguagesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateLanguagesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentTemplateLanguagesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultDocumentTemplateLanguage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultDocumentTemplateLanguage" style="document" />
      <wsdl:input name="CreateDefaultDocumentTemplateLanguageRequest">
        <soap:header message="tns:CreateDefaultDocumentTemplateLanguageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentTemplateLanguageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentTemplateLanguageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultDocumentTemplateLanguageResponse">
        <soap:header message="tns:CreateDefaultDocumentTemplateLanguageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentTemplateLanguageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentTemplateLanguageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentTemplateLanguageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteDocumentTemplateLanguage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteDocumentTemplateLanguage" style="document" />
      <wsdl:input name="DeleteDocumentTemplateLanguageRequest">
        <soap:header message="tns:DeleteDocumentTemplateLanguageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteDocumentTemplateLanguageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteDocumentTemplateLanguageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteDocumentTemplateLanguageResponse">
        <soap:header message="tns:DeleteDocumentTemplateLanguageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteDocumentTemplateLanguageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteDocumentTemplateLanguageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteDocumentTemplateLanguageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateExtension">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateExtension" style="document" />
      <wsdl:input name="GetDocumentTemplateExtensionRequest">
        <soap:header message="tns:GetDocumentTemplateExtensionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentTemplateExtensionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentTemplateExtensionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentTemplateExtensionResponse">
        <soap:header message="tns:GetDocumentTemplateExtensionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateExtensionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateExtensionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentTemplateExtensionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetDocumentTemplateFromDocumentTemplate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetDocumentTemplateFromDocumentTemplate" style="document" />
      <wsdl:input name="SetDocumentTemplateFromDocumentTemplateRequest">
        <soap:header message="tns:SetDocumentTemplateFromDocumentTemplateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetDocumentTemplateFromDocumentTemplateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetDocumentTemplateFromDocumentTemplateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetDocumentTemplateFromDocumentTemplateResponse">
        <soap:header message="tns:SetDocumentTemplateFromDocumentTemplateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetDocumentTemplateFromDocumentTemplateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetDocumentTemplateFromDocumentTemplateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetDocumentTemplateFromDocumentTemplateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateStreamFromId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateStreamFromId" style="document" />
      <wsdl:input name="GetDocumentTemplateStreamFromIdRequest">
        <soap:header message="tns:GetDocumentTemplateStreamFromIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentTemplateStreamFromIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentTemplateStreamFromIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentTemplateStreamFromIdResponse">
        <soap:header message="tns:GetDocumentTemplateStreamFromIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateStreamFromIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateStreamFromIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentTemplateStreamFromIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveDocumentTemplateStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveDocumentTemplateStream" style="document" />
      <wsdl:input name="SaveDocumentTemplateStreamRequest">
        <soap:header message="tns:SaveDocumentTemplateStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveDocumentTemplateStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveDocumentTemplateStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveDocumentTemplateStreamResponse">
        <soap:header message="tns:SaveDocumentTemplateStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveDocumentTemplateStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveDocumentTemplateStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveDocumentTemplateStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPluginList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPluginList" style="document" />
      <wsdl:input name="GetPluginListRequest">
        <soap:header message="tns:GetPluginListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPluginListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPluginListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPluginListResponse">
        <soap:header message="tns:GetPluginListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPluginListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPluginListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPluginListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPluginCapabilities">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPluginCapabilities" style="document" />
      <wsdl:input name="GetPluginCapabilitiesRequest">
        <soap:header message="tns:GetPluginCapabilitiesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPluginCapabilitiesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPluginCapabilitiesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPluginCapabilitiesResponse">
        <soap:header message="tns:GetPluginCapabilitiesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPluginCapabilitiesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPluginCapabilitiesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPluginCapabilitiesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTypesForPlugin">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTypesForPlugin" style="document" />
      <wsdl:input name="GetDocumentTypesForPluginRequest">
        <soap:header message="tns:GetDocumentTypesForPluginRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentTypesForPluginRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentTypesForPluginRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentTypesForPluginResponse">
        <soap:header message="tns:GetDocumentTypesForPluginResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentTypesForPluginResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentTypesForPluginResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentTypesForPluginResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetRelationDefinitionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetRelationDefinitionEntity" style="document" />
      <wsdl:input name="GetRelationDefinitionEntityRequest">
        <soap:header message="tns:GetRelationDefinitionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetRelationDefinitionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetRelationDefinitionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetRelationDefinitionEntityResponse">
        <soap:header message="tns:GetRelationDefinitionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetRelationDefinitionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetRelationDefinitionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetRelationDefinitionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveQuickReplies">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveQuickReplies" style="document" />
      <wsdl:input name="SaveQuickRepliesRequest">
        <soap:header message="tns:SaveQuickRepliesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveQuickRepliesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveQuickRepliesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveQuickRepliesResponse">
        <soap:header message="tns:SaveQuickRepliesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveQuickRepliesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveQuickRepliesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveQuickRepliesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuickReplies">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetQuickReplies" style="document" />
      <wsdl:input name="GetQuickRepliesRequest">
        <soap:header message="tns:GetQuickRepliesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuickRepliesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuickRepliesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuickRepliesResponse">
        <soap:header message="tns:GetQuickRepliesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuickRepliesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuickRepliesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuickRepliesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConsentPurpose">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetConsentPurpose" style="document" />
      <wsdl:input name="GetConsentPurposeRequest">
        <soap:header message="tns:GetConsentPurposeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConsentPurposeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConsentPurposeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConsentPurposeResponse">
        <soap:header message="tns:GetConsentPurposeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConsentPurposeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConsentPurposeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConsentPurposeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveConsentPurpose">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveConsentPurpose" style="document" />
      <wsdl:input name="SaveConsentPurposeRequest">
        <soap:header message="tns:SaveConsentPurposeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveConsentPurposeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveConsentPurposeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveConsentPurposeResponse">
        <soap:header message="tns:SaveConsentPurposeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveConsentPurposeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveConsentPurposeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveConsentPurposeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetEmarketingStrictMode">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetEmarketingStrictMode" style="document" />
      <wsdl:input name="SetEmarketingStrictModeRequest">
        <soap:header message="tns:SetEmarketingStrictModeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetEmarketingStrictModeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetEmarketingStrictModeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetEmarketingStrictModeResponse">
        <soap:header message="tns:SetEmarketingStrictModeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetEmarketingStrictModeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetEmarketingStrictModeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetEmarketingStrictModeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEmarketingStrictMode">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetEmarketingStrictMode" style="document" />
      <wsdl:input name="GetEmarketingStrictModeRequest">
        <soap:header message="tns:GetEmarketingStrictModeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEmarketingStrictModeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEmarketingStrictModeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEmarketingStrictModeResponse">
        <soap:header message="tns:GetEmarketingStrictModeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEmarketingStrictModeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEmarketingStrictModeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEmarketingStrictModeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConsentPurposeList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetConsentPurposeList" style="document" />
      <wsdl:input name="GetConsentPurposeListRequest">
        <soap:header message="tns:GetConsentPurposeListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConsentPurposeListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConsentPurposeListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConsentPurposeListResponse">
        <soap:header message="tns:GetConsentPurposeListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConsentPurposeListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConsentPurposeListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConsentPurposeListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConsentPurposes">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetConsentPurposes" style="document" />
      <wsdl:input name="GetConsentPurposesRequest">
        <soap:header message="tns:GetConsentPurposesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConsentPurposesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConsentPurposesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConsentPurposesResponse">
        <soap:header message="tns:GetConsentPurposesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConsentPurposesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConsentPurposesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConsentPurposesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConsentSource">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetConsentSource" style="document" />
      <wsdl:input name="GetConsentSourceRequest">
        <soap:header message="tns:GetConsentSourceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConsentSourceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConsentSourceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConsentSourceResponse">
        <soap:header message="tns:GetConsentSourceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConsentSourceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConsentSourceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConsentSourceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveConsentSource">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveConsentSource" style="document" />
      <wsdl:input name="SaveConsentSourceRequest">
        <soap:header message="tns:SaveConsentSourceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveConsentSourceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveConsentSourceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveConsentSourceResponse">
        <soap:header message="tns:SaveConsentSourceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveConsentSourceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveConsentSourceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveConsentSourceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllConsentSource">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllConsentSource" style="document" />
      <wsdl:input name="GetAllConsentSourceRequest">
        <soap:header message="tns:GetAllConsentSourceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllConsentSourceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllConsentSourceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllConsentSourceResponse">
        <soap:header message="tns:GetAllConsentSourceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllConsentSourceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllConsentSourceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllConsentSourceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConsentSourceList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetConsentSourceList" style="document" />
      <wsdl:input name="GetConsentSourceListRequest">
        <soap:header message="tns:GetConsentSourceListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConsentSourceListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConsentSourceListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConsentSourceListResponse">
        <soap:header message="tns:GetConsentSourceListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConsentSourceListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConsentSourceListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConsentSourceListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConsentSources">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetConsentSources" style="document" />
      <wsdl:input name="GetConsentSourcesRequest">
        <soap:header message="tns:GetConsentSourcesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConsentSourcesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConsentSourcesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConsentSourcesResponse">
        <soap:header message="tns:GetConsentSourcesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConsentSourcesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConsentSourcesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConsentSourcesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLegalBase">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLegalBase" style="document" />
      <wsdl:input name="GetLegalBaseRequest">
        <soap:header message="tns:GetLegalBaseRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLegalBaseRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLegalBaseRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLegalBaseResponse">
        <soap:header message="tns:GetLegalBaseResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLegalBaseResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLegalBaseResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLegalBaseResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveLegalBase">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveLegalBase" style="document" />
      <wsdl:input name="SaveLegalBaseRequest">
        <soap:header message="tns:SaveLegalBaseRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveLegalBaseRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveLegalBaseRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveLegalBaseResponse">
        <soap:header message="tns:SaveLegalBaseResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveLegalBaseResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveLegalBaseResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveLegalBaseResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllLegalBase">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllLegalBase" style="document" />
      <wsdl:input name="GetAllLegalBaseRequest">
        <soap:header message="tns:GetAllLegalBaseRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllLegalBaseRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllLegalBaseRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllLegalBaseResponse">
        <soap:header message="tns:GetAllLegalBaseResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllLegalBaseResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllLegalBaseResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllLegalBaseResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLegalBaseList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLegalBaseList" style="document" />
      <wsdl:input name="GetLegalBaseListRequest">
        <soap:header message="tns:GetLegalBaseListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLegalBaseListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLegalBaseListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLegalBaseListResponse">
        <soap:header message="tns:GetLegalBaseListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLegalBaseListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLegalBaseListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLegalBaseListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLegalBases">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLegalBases" style="document" />
      <wsdl:input name="GetLegalBasesRequest">
        <soap:header message="tns:GetLegalBasesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLegalBasesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLegalBasesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLegalBasesResponse">
        <soap:header message="tns:GetLegalBasesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLegalBasesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLegalBasesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLegalBasesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveListItemEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveListItemEntity" style="document" />
      <wsdl:input name="SaveListItemEntityRequest">
        <soap:header message="tns:SaveListItemEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveListItemEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveListItemEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveListItemEntityResponse">
        <soap:header message="tns:SaveListItemEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveListItemEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveListItemEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveListItemEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SortListItems">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SortListItems" style="document" />
      <wsdl:input name="SortListItemsRequest">
        <soap:header message="tns:SortListItemsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SortListItemsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SortListItemsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SortListItemsResponse">
        <soap:header message="tns:SortListItemsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SortListItemsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SortListItemsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SortListItemsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="MoveListItem">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/MoveListItem" style="document" />
      <wsdl:input name="MoveListItemRequest">
        <soap:header message="tns:MoveListItemRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MoveListItemRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MoveListItemRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MoveListItemResponse">
        <soap:header message="tns:MoveListItemResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MoveListItemResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MoveListItemResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MoveListItemResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetVisibleForUserGroups">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetVisibleForUserGroups" style="document" />
      <wsdl:input name="GetVisibleForUserGroupsRequest">
        <soap:header message="tns:GetVisibleForUserGroupsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetVisibleForUserGroupsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetVisibleForUserGroupsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetVisibleForUserGroupsResponse">
        <soap:header message="tns:GetVisibleForUserGroupsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetVisibleForUserGroupsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetVisibleForUserGroupsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetVisibleForUserGroupsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetVisibleForUserGroupsFromListName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetVisibleForUserGroupsFromListName" style="document" />
      <wsdl:input name="GetVisibleForUserGroupsFromListNameRequest">
        <soap:header message="tns:GetVisibleForUserGroupsFromListNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetVisibleForUserGroupsFromListNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetVisibleForUserGroupsFromListNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetVisibleForUserGroupsFromListNameResponse">
        <soap:header message="tns:GetVisibleForUserGroupsFromListNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetVisibleForUserGroupsFromListNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetVisibleForUserGroupsFromListNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetVisibleForUserGroupsFromListNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetVisibleForUserGroups">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetVisibleForUserGroups" style="document" />
      <wsdl:input name="SetVisibleForUserGroupsRequest">
        <soap:header message="tns:SetVisibleForUserGroupsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetVisibleForUserGroupsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetVisibleForUserGroupsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetVisibleForUserGroupsResponse">
        <soap:header message="tns:SetVisibleForUserGroupsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetVisibleForUserGroupsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetVisibleForUserGroupsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetVisibleForUserGroupsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetVisibleForUserGroupsFromListName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetVisibleForUserGroupsFromListName" style="document" />
      <wsdl:input name="SetVisibleForUserGroupsFromListNameRequest">
        <soap:header message="tns:SetVisibleForUserGroupsFromListNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetVisibleForUserGroupsFromListNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetVisibleForUserGroupsFromListNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetVisibleForUserGroupsFromListNameResponse">
        <soap:header message="tns:SetVisibleForUserGroupsFromListNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetVisibleForUserGroupsFromListNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetVisibleForUserGroupsFromListNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetVisibleForUserGroupsFromListNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetVisibleForUserGroup">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetVisibleForUserGroup" style="document" />
      <wsdl:input name="SetVisibleForUserGroupRequest">
        <soap:header message="tns:SetVisibleForUserGroupRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetVisibleForUserGroupRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetVisibleForUserGroupRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetVisibleForUserGroupResponse">
        <soap:header message="tns:SetVisibleForUserGroupResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetVisibleForUserGroupResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetVisibleForUserGroupResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetVisibleForUserGroupResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetListItemsForUserGroup">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListItemsForUserGroup" style="document" />
      <wsdl:input name="GetListItemsForUserGroupRequest">
        <soap:header message="tns:GetListItemsForUserGroupRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetListItemsForUserGroupRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetListItemsForUserGroupRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetListItemsForUserGroupResponse">
        <soap:header message="tns:GetListItemsForUserGroupResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetListItemsForUserGroupResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetListItemsForUserGroupResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetListItemsForUserGroupResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetListItemsForUserGroupFromListName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListItemsForUserGroupFromListName" style="document" />
      <wsdl:input name="GetListItemsForUserGroupFromListNameRequest">
        <soap:header message="tns:GetListItemsForUserGroupFromListNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetListItemsForUserGroupFromListNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetListItemsForUserGroupFromListNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetListItemsForUserGroupFromListNameResponse">
        <soap:header message="tns:GetListItemsForUserGroupFromListNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetListItemsForUserGroupFromListNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetListItemsForUserGroupFromListNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetListItemsForUserGroupFromListNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetListItemsForUserGroup">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetListItemsForUserGroup" style="document" />
      <wsdl:input name="SetListItemsForUserGroupRequest">
        <soap:header message="tns:SetListItemsForUserGroupRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetListItemsForUserGroupRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetListItemsForUserGroupRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetListItemsForUserGroupResponse">
        <soap:header message="tns:SetListItemsForUserGroupResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetListItemsForUserGroupResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetListItemsForUserGroupResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetListItemsForUserGroupResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetListItemsForUserGroupFromListName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetListItemsForUserGroupFromListName" style="document" />
      <wsdl:input name="SetListItemsForUserGroupFromListNameRequest">
        <soap:header message="tns:SetListItemsForUserGroupFromListNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetListItemsForUserGroupFromListNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetListItemsForUserGroupFromListNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetListItemsForUserGroupFromListNameResponse">
        <soap:header message="tns:SetListItemsForUserGroupFromListNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetListItemsForUserGroupFromListNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetListItemsForUserGroupFromListNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetListItemsForUserGroupFromListNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetHeadings">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetHeadings" style="document" />
      <wsdl:input name="GetHeadingsRequest">
        <soap:header message="tns:GetHeadingsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetHeadingsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetHeadingsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetHeadingsResponse">
        <soap:header message="tns:GetHeadingsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetHeadingsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetHeadingsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetHeadingsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetHeadingsForListItemFromListName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetHeadingsForListItemFromListName" style="document" />
      <wsdl:input name="GetHeadingsForListItemFromListNameRequest">
        <soap:header message="tns:GetHeadingsForListItemFromListNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetHeadingsForListItemFromListNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetHeadingsForListItemFromListNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetHeadingsForListItemFromListNameResponse">
        <soap:header message="tns:GetHeadingsForListItemFromListNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetHeadingsForListItemFromListNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetHeadingsForListItemFromListNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetHeadingsForListItemFromListNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveHeadingsForListItemFromListDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingsForListItemFromListDefinition" style="document" />
      <wsdl:input name="SaveHeadingsForListItemFromListDefinitionRequest">
        <soap:header message="tns:SaveHeadingsForListItemFromListDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveHeadingsForListItemFromListDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveHeadingsForListItemFromListDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveHeadingsForListItemFromListDefinitionResponse">
        <soap:header message="tns:SaveHeadingsForListItemFromListDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveHeadingsForListItemFromListDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveHeadingsForListItemFromListDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveHeadingsForListItemFromListDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveHeadingsForListItemFromListName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingsForListItemFromListName" style="document" />
      <wsdl:input name="SaveHeadingsForListItemFromListNameRequest">
        <soap:header message="tns:SaveHeadingsForListItemFromListNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveHeadingsForListItemFromListNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveHeadingsForListItemFromListNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveHeadingsForListItemFromListNameResponse">
        <soap:header message="tns:SaveHeadingsForListItemFromListNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveHeadingsForListItemFromListNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveHeadingsForListItemFromListNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveHeadingsForListItemFromListNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetListItemsForHeading">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListItemsForHeading" style="document" />
      <wsdl:input name="GetListItemsForHeadingRequest">
        <soap:header message="tns:GetListItemsForHeadingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetListItemsForHeadingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetListItemsForHeadingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetListItemsForHeadingResponse">
        <soap:header message="tns:GetListItemsForHeadingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetListItemsForHeadingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetListItemsForHeadingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetListItemsForHeadingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetListItemsForHeadingFromListName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListItemsForHeadingFromListName" style="document" />
      <wsdl:input name="GetListItemsForHeadingFromListNameRequest">
        <soap:header message="tns:GetListItemsForHeadingFromListNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetListItemsForHeadingFromListNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetListItemsForHeadingFromListNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetListItemsForHeadingFromListNameResponse">
        <soap:header message="tns:GetListItemsForHeadingFromListNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetListItemsForHeadingFromListNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetListItemsForHeadingFromListNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetListItemsForHeadingFromListNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetListItemsForHeading">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetListItemsForHeading" style="document" />
      <wsdl:input name="SetListItemsForHeadingRequest">
        <soap:header message="tns:SetListItemsForHeadingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetListItemsForHeadingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetListItemsForHeadingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetListItemsForHeadingResponse">
        <soap:header message="tns:SetListItemsForHeadingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetListItemsForHeadingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetListItemsForHeadingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetListItemsForHeadingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetListItemsForHeadingFromListName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetListItemsForHeadingFromListName" style="document" />
      <wsdl:input name="SetListItemsForHeadingFromListNameRequest">
        <soap:header message="tns:SetListItemsForHeadingFromListNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetListItemsForHeadingFromListNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetListItemsForHeadingFromListNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetListItemsForHeadingFromListNameResponse">
        <soap:header message="tns:SetListItemsForHeadingFromListNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetListItemsForHeadingFromListNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetListItemsForHeadingFromListNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetListItemsForHeadingFromListNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetHeadingsForListItem">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetHeadingsForListItem" style="document" />
      <wsdl:input name="SetHeadingsForListItemRequest">
        <soap:header message="tns:SetHeadingsForListItemRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetHeadingsForListItemRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetHeadingsForListItemRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetHeadingsForListItemResponse">
        <soap:header message="tns:SetHeadingsForListItemResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetHeadingsForListItemResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetHeadingsForListItemResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetHeadingsForListItemResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetRankOnHeadings">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetRankOnHeadings" style="document" />
      <wsdl:input name="SetRankOnHeadingsRequest">
        <soap:header message="tns:SetRankOnHeadingsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetRankOnHeadingsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetRankOnHeadingsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetRankOnHeadingsResponse">
        <soap:header message="tns:SetRankOnHeadingsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetRankOnHeadingsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetRankOnHeadingsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetRankOnHeadingsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetRankOnSaleActivity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetRankOnSaleActivity" style="document" />
      <wsdl:input name="SetRankOnSaleActivityRequest">
        <soap:header message="tns:SetRankOnSaleActivityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetRankOnSaleActivityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetRankOnSaleActivityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetRankOnSaleActivityResponse">
        <soap:header message="tns:SetRankOnSaleActivityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetRankOnSaleActivityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetRankOnSaleActivityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetRankOnSaleActivityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetRankOnSaleDocument">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetRankOnSaleDocument" style="document" />
      <wsdl:input name="SetRankOnSaleDocumentRequest">
        <soap:header message="tns:SetRankOnSaleDocumentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetRankOnSaleDocumentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetRankOnSaleDocumentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetRankOnSaleDocumentResponse">
        <soap:header message="tns:SetRankOnSaleDocumentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetRankOnSaleDocumentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetRankOnSaleDocumentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetRankOnSaleDocumentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetRankOnProjectActivity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetRankOnProjectActivity" style="document" />
      <wsdl:input name="SetRankOnProjectActivityRequest">
        <soap:header message="tns:SetRankOnProjectActivityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetRankOnProjectActivityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetRankOnProjectActivityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetRankOnProjectActivityResponse">
        <soap:header message="tns:SetRankOnProjectActivityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetRankOnProjectActivityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetRankOnProjectActivityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetRankOnProjectActivityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetRankOnProjectDocument">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SetRankOnProjectDocument" style="document" />
      <wsdl:input name="SetRankOnProjectDocumentRequest">
        <soap:header message="tns:SetRankOnProjectDocumentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetRankOnProjectDocumentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetRankOnProjectDocumentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetRankOnProjectDocumentResponse">
        <soap:header message="tns:SetRankOnProjectDocumentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetRankOnProjectDocumentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetRankOnProjectDocumentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetRankOnProjectDocumentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllFromListDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllFromListDefinition" style="document" />
      <wsdl:input name="GetAllFromListDefinitionRequest">
        <soap:header message="tns:GetAllFromListDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllFromListDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllFromListDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllFromListDefinitionResponse">
        <soap:header message="tns:GetAllFromListDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllFromListDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllFromListDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllFromListDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllFromListName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllFromListName" style="document" />
      <wsdl:input name="GetAllFromListNameRequest">
        <soap:header message="tns:GetAllFromListNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllFromListNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllFromListNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllFromListNameResponse">
        <soap:header message="tns:GetAllFromListNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllFromListNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllFromListNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllFromListNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveAllFromListDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveAllFromListDefinition" style="document" />
      <wsdl:input name="SaveAllFromListDefinitionRequest">
        <soap:header message="tns:SaveAllFromListDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveAllFromListDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveAllFromListDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveAllFromListDefinitionResponse">
        <soap:header message="tns:SaveAllFromListDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveAllFromListDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveAllFromListDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveAllFromListDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveAllFromListName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveAllFromListName" style="document" />
      <wsdl:input name="SaveAllFromListNameRequest">
        <soap:header message="tns:SaveAllFromListNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveAllFromListNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveAllFromListNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveAllFromListNameResponse">
        <soap:header message="tns:SaveAllFromListNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveAllFromListNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveAllFromListNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveAllFromListNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddFromListDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/AddFromListDefinition" style="document" />
      <wsdl:input name="AddFromListDefinitionRequest">
        <soap:header message="tns:AddFromListDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddFromListDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddFromListDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddFromListDefinitionResponse">
        <soap:header message="tns:AddFromListDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddFromListDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddFromListDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddFromListDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddFromListName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/AddFromListName" style="document" />
      <wsdl:input name="AddFromListNameRequest">
        <soap:header message="tns:AddFromListNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddFromListNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddFromListNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddFromListNameResponse">
        <soap:header message="tns:AddFromListNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddFromListNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddFromListNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddFromListNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteAllFromListDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteAllFromListDefinition" style="document" />
      <wsdl:input name="DeleteAllFromListDefinitionRequest">
        <soap:header message="tns:DeleteAllFromListDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteAllFromListDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteAllFromListDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteAllFromListDefinitionResponse">
        <soap:header message="tns:DeleteAllFromListDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteAllFromListDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteAllFromListDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteAllFromListDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteAllFromListName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteAllFromListName" style="document" />
      <wsdl:input name="DeleteAllFromListNameRequest">
        <soap:header message="tns:DeleteAllFromListNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteAllFromListNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteAllFromListNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteAllFromListNameResponse">
        <soap:header message="tns:DeleteAllFromListNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteAllFromListNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteAllFromListNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteAllFromListNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFromListDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetFromListDefinition" style="document" />
      <wsdl:input name="GetFromListDefinitionRequest">
        <soap:header message="tns:GetFromListDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFromListDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFromListDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFromListDefinitionResponse">
        <soap:header message="tns:GetFromListDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFromListDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFromListDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFromListDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFromListName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetFromListName" style="document" />
      <wsdl:input name="GetFromListNameRequest">
        <soap:header message="tns:GetFromListNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFromListNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFromListNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFromListNameResponse">
        <soap:header message="tns:GetFromListNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFromListNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFromListNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFromListNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveFromListDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveFromListDefinition" style="document" />
      <wsdl:input name="SaveFromListDefinitionRequest">
        <soap:header message="tns:SaveFromListDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveFromListDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveFromListDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveFromListDefinitionResponse">
        <soap:header message="tns:SaveFromListDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveFromListDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveFromListDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveFromListDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveFromListName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveFromListName" style="document" />
      <wsdl:input name="SaveFromListNameRequest">
        <soap:header message="tns:SaveFromListNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveFromListNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveFromListNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveFromListNameResponse">
        <soap:header message="tns:SaveFromListNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveFromListNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveFromListNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveFromListNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteFromListDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteFromListDefinition" style="document" />
      <wsdl:input name="DeleteFromListDefinitionRequest">
        <soap:header message="tns:DeleteFromListDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteFromListDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteFromListDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteFromListDefinitionResponse">
        <soap:header message="tns:DeleteFromListDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteFromListDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteFromListDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteFromListDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteFromListName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteFromListName" style="document" />
      <wsdl:input name="DeleteFromListNameRequest">
        <soap:header message="tns:DeleteFromListNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteFromListNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteFromListNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteFromListNameResponse">
        <soap:header message="tns:DeleteFromListNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteFromListNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteFromListNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteFromListNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetHeadingsFromName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetHeadingsFromName" style="document" />
      <wsdl:input name="GetHeadingsFromNameRequest">
        <soap:header message="tns:GetHeadingsFromNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetHeadingsFromNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetHeadingsFromNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetHeadingsFromNameResponse">
        <soap:header message="tns:GetHeadingsFromNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetHeadingsFromNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetHeadingsFromNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetHeadingsFromNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetHeadingsFromListDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetHeadingsFromListDefinition" style="document" />
      <wsdl:input name="GetHeadingsFromListDefinitionRequest">
        <soap:header message="tns:GetHeadingsFromListDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetHeadingsFromListDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetHeadingsFromListDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetHeadingsFromListDefinitionResponse">
        <soap:header message="tns:GetHeadingsFromListDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetHeadingsFromListDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetHeadingsFromListDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetHeadingsFromListDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveHeadingsFromName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingsFromName" style="document" />
      <wsdl:input name="SaveHeadingsFromNameRequest">
        <soap:header message="tns:SaveHeadingsFromNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveHeadingsFromNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveHeadingsFromNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveHeadingsFromNameResponse">
        <soap:header message="tns:SaveHeadingsFromNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveHeadingsFromNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveHeadingsFromNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveHeadingsFromNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveHeadingsFromListDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingsFromListDefinition" style="document" />
      <wsdl:input name="SaveHeadingsFromListDefinitionRequest">
        <soap:header message="tns:SaveHeadingsFromListDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveHeadingsFromListDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveHeadingsFromListDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveHeadingsFromListDefinitionResponse">
        <soap:header message="tns:SaveHeadingsFromListDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveHeadingsFromListDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveHeadingsFromListDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveHeadingsFromListDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveHeadingFromName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingFromName" style="document" />
      <wsdl:input name="SaveHeadingFromNameRequest">
        <soap:header message="tns:SaveHeadingFromNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveHeadingFromNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveHeadingFromNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveHeadingFromNameResponse">
        <soap:header message="tns:SaveHeadingFromNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveHeadingFromNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveHeadingFromNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveHeadingFromNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveHeadingFromListDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingFromListDefinition" style="document" />
      <wsdl:input name="SaveHeadingFromListDefinitionRequest">
        <soap:header message="tns:SaveHeadingFromListDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveHeadingFromListDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveHeadingFromListDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveHeadingFromListDefinitionResponse">
        <soap:header message="tns:SaveHeadingFromListDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveHeadingFromListDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveHeadingFromListDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveHeadingFromListDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteAllHeadingsFromName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteAllHeadingsFromName" style="document" />
      <wsdl:input name="DeleteAllHeadingsFromNameRequest">
        <soap:header message="tns:DeleteAllHeadingsFromNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteAllHeadingsFromNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteAllHeadingsFromNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteAllHeadingsFromNameResponse">
        <soap:header message="tns:DeleteAllHeadingsFromNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteAllHeadingsFromNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteAllHeadingsFromNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteAllHeadingsFromNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteAllHeadingsFromListDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteAllHeadingsFromListDefinition" style="document" />
      <wsdl:input name="DeleteAllHeadingsFromListDefinitionRequest">
        <soap:header message="tns:DeleteAllHeadingsFromListDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteAllHeadingsFromListDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteAllHeadingsFromListDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteAllHeadingsFromListDefinitionResponse">
        <soap:header message="tns:DeleteAllHeadingsFromListDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteAllHeadingsFromListDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteAllHeadingsFromListDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteAllHeadingsFromListDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLocalizedText">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLocalizedText" style="document" />
      <wsdl:input name="GetLocalizedTextRequest">
        <soap:header message="tns:GetLocalizedTextRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLocalizedTextRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLocalizedTextRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLocalizedTextResponse">
        <soap:header message="tns:GetLocalizedTextResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLocalizedTextResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLocalizedTextResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLocalizedTextResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLocalizedTextByType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLocalizedTextByType" style="document" />
      <wsdl:input name="GetLocalizedTextByTypeRequest">
        <soap:header message="tns:GetLocalizedTextByTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLocalizedTextByTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLocalizedTextByTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLocalizedTextByTypeResponse">
        <soap:header message="tns:GetLocalizedTextByTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLocalizedTextByTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLocalizedTextByTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLocalizedTextByTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLocalizedTextList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLocalizedTextList" style="document" />
      <wsdl:input name="GetLocalizedTextListRequest">
        <soap:header message="tns:GetLocalizedTextListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLocalizedTextListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLocalizedTextListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLocalizedTextListResponse">
        <soap:header message="tns:GetLocalizedTextListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLocalizedTextListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLocalizedTextListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLocalizedTextListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLocalizedTexts">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLocalizedTexts" style="document" />
      <wsdl:input name="GetLocalizedTextsRequest">
        <soap:header message="tns:GetLocalizedTextsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLocalizedTextsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLocalizedTextsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLocalizedTextsResponse">
        <soap:header message="tns:GetLocalizedTextsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLocalizedTextsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLocalizedTextsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLocalizedTextsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLocalizedTextsByLanguageId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLocalizedTextsByLanguageId" style="document" />
      <wsdl:input name="GetLocalizedTextsByLanguageIdRequest">
        <soap:header message="tns:GetLocalizedTextsByLanguageIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLocalizedTextsByLanguageIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLocalizedTextsByLanguageIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLocalizedTextsByLanguageIdResponse">
        <soap:header message="tns:GetLocalizedTextsByLanguageIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLocalizedTextsByLanguageIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLocalizedTextsByLanguageIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLocalizedTextsByLanguageIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLocalizedTextsByType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLocalizedTextsByType" style="document" />
      <wsdl:input name="GetLocalizedTextsByTypeRequest">
        <soap:header message="tns:GetLocalizedTextsByTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLocalizedTextsByTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLocalizedTextsByTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLocalizedTextsByTypeResponse">
        <soap:header message="tns:GetLocalizedTextsByTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLocalizedTextsByTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLocalizedTextsByTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLocalizedTextsByTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMrMrs">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetMrMrs" style="document" />
      <wsdl:input name="GetMrMrsRequest">
        <soap:header message="tns:GetMrMrsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMrMrsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMrMrsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMrMrsResponse">
        <soap:header message="tns:GetMrMrsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMrMrsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMrMrsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMrMrsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMrMrsList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetMrMrsList" style="document" />
      <wsdl:input name="GetMrMrsListRequest">
        <soap:header message="tns:GetMrMrsListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMrMrsListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMrMrsListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMrMrsListResponse">
        <soap:header message="tns:GetMrMrsListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMrMrsListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMrMrsListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMrMrsListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMrMrses">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetMrMrses" style="document" />
      <wsdl:input name="GetMrMrsesRequest">
        <soap:header message="tns:GetMrMrsesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMrMrsesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMrMrsesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMrMrsesResponse">
        <soap:header message="tns:GetMrMrsesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMrMrsesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMrMrsesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMrMrsesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPosition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPosition" style="document" />
      <wsdl:input name="GetPositionRequest">
        <soap:header message="tns:GetPositionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPositionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPositionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPositionResponse">
        <soap:header message="tns:GetPositionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPositionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPositionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPositionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPositionList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPositionList" style="document" />
      <wsdl:input name="GetPositionListRequest">
        <soap:header message="tns:GetPositionListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPositionListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPositionListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPositionListResponse">
        <soap:header message="tns:GetPositionListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPositionListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPositionListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPositionListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPositions">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPositions" style="document" />
      <wsdl:input name="GetPositionsRequest">
        <soap:header message="tns:GetPositionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPositionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPositionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPositionsResponse">
        <soap:header message="tns:GetPositionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPositionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPositionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPositionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPriority">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPriority" style="document" />
      <wsdl:input name="GetPriorityRequest">
        <soap:header message="tns:GetPriorityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPriorityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPriorityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPriorityResponse">
        <soap:header message="tns:GetPriorityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPriorityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPriorityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPriorityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPriorityList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPriorityList" style="document" />
      <wsdl:input name="GetPriorityListRequest">
        <soap:header message="tns:GetPriorityListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPriorityListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPriorityListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPriorityListResponse">
        <soap:header message="tns:GetPriorityListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPriorityListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPriorityListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPriorityListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPriorities">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPriorities" style="document" />
      <wsdl:input name="GetPrioritiesRequest">
        <soap:header message="tns:GetPrioritiesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPrioritiesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPrioritiesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPrioritiesResponse">
        <soap:header message="tns:GetPrioritiesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPrioritiesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPrioritiesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPrioritiesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProductCategory">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProductCategory" style="document" />
      <wsdl:input name="GetProductCategoryRequest">
        <soap:header message="tns:GetProductCategoryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProductCategoryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProductCategoryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProductCategoryResponse">
        <soap:header message="tns:GetProductCategoryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProductCategoryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProductCategoryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProductCategoryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProductCategories">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProductCategories" style="document" />
      <wsdl:input name="GetProductCategoriesRequest">
        <soap:header message="tns:GetProductCategoriesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProductCategoriesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProductCategoriesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProductCategoriesResponse">
        <soap:header message="tns:GetProductCategoriesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProductCategoriesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProductCategoriesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProductCategoriesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProductFamily">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProductFamily" style="document" />
      <wsdl:input name="GetProductFamilyRequest">
        <soap:header message="tns:GetProductFamilyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProductFamilyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProductFamilyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProductFamilyResponse">
        <soap:header message="tns:GetProductFamilyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProductFamilyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProductFamilyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProductFamilyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProductFamilies">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProductFamilies" style="document" />
      <wsdl:input name="GetProductFamiliesRequest">
        <soap:header message="tns:GetProductFamiliesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProductFamiliesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProductFamiliesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProductFamiliesResponse">
        <soap:header message="tns:GetProductFamiliesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProductFamiliesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProductFamiliesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProductFamiliesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProductType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProductType" style="document" />
      <wsdl:input name="GetProductTypeRequest">
        <soap:header message="tns:GetProductTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProductTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProductTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProductTypeResponse">
        <soap:header message="tns:GetProductTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProductTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProductTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProductTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProductTypes">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProductTypes" style="document" />
      <wsdl:input name="GetProductTypesRequest">
        <soap:header message="tns:GetProductTypesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProductTypesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProductTypesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProductTypesResponse">
        <soap:header message="tns:GetProductTypesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProductTypesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProductTypesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProductTypesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectStatus" style="document" />
      <wsdl:input name="GetProjectStatusRequest">
        <soap:header message="tns:GetProjectStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectStatusResponse">
        <soap:header message="tns:GetProjectStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectStatusResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteProjectStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteProjectStatus" style="document" />
      <wsdl:input name="DeleteProjectStatusRequest">
        <soap:header message="tns:DeleteProjectStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteProjectStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteProjectStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteProjectStatusResponse">
        <soap:header message="tns:DeleteProjectStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteProjectStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteProjectStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteProjectStatusResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectStatusList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectStatusList" style="document" />
      <wsdl:input name="GetProjectStatusListRequest">
        <soap:header message="tns:GetProjectStatusListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectStatusListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectStatusListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectStatusListResponse">
        <soap:header message="tns:GetProjectStatusListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectStatusListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectStatusListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectStatusListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectStatuses">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectStatuses" style="document" />
      <wsdl:input name="GetProjectStatusesRequest">
        <soap:header message="tns:GetProjectStatusesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectStatusesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectStatusesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectStatusesResponse">
        <soap:header message="tns:GetProjectStatusesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectStatusesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectStatusesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectStatusesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectType" style="document" />
      <wsdl:input name="GetProjectTypeRequest">
        <soap:header message="tns:GetProjectTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectTypeResponse">
        <soap:header message="tns:GetProjectTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectTypeEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectTypeEntity" style="document" />
      <wsdl:input name="GetProjectTypeEntityRequest">
        <soap:header message="tns:GetProjectTypeEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectTypeEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectTypeEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectTypeEntityResponse">
        <soap:header message="tns:GetProjectTypeEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectTypeEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectTypeEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectTypeEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectTypeList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectTypeList" style="document" />
      <wsdl:input name="GetProjectTypeListRequest">
        <soap:header message="tns:GetProjectTypeListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectTypeListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectTypeListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectTypeListResponse">
        <soap:header message="tns:GetProjectTypeListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectTypeListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectTypeListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectTypeListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectTypes">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetProjectTypes" style="document" />
      <wsdl:input name="GetProjectTypesRequest">
        <soap:header message="tns:GetProjectTypesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectTypesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectTypesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectTypesResponse">
        <soap:header message="tns:GetProjectTypesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectTypesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectTypesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectTypesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetRating">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetRating" style="document" />
      <wsdl:input name="GetRatingRequest">
        <soap:header message="tns:GetRatingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetRatingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetRatingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetRatingResponse">
        <soap:header message="tns:GetRatingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetRatingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetRatingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetRatingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetRatingList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetRatingList" style="document" />
      <wsdl:input name="GetRatingListRequest">
        <soap:header message="tns:GetRatingListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetRatingListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetRatingListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetRatingListResponse">
        <soap:header message="tns:GetRatingListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetRatingListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetRatingListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetRatingListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetRatings">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetRatings" style="document" />
      <wsdl:input name="GetRatingsRequest">
        <soap:header message="tns:GetRatingsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetRatingsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetRatingsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetRatingsResponse">
        <soap:header message="tns:GetRatingsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetRatingsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetRatingsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetRatingsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllSaleStages">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllSaleStages" style="document" />
      <wsdl:input name="GetAllSaleStagesRequest">
        <soap:header message="tns:GetAllSaleStagesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllSaleStagesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllSaleStagesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllSaleStagesResponse">
        <soap:header message="tns:GetAllSaleStagesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllSaleStagesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllSaleStagesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllSaleStagesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetReason">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReason" style="document" />
      <wsdl:input name="GetReasonRequest">
        <soap:header message="tns:GetReasonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetReasonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetReasonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetReasonResponse">
        <soap:header message="tns:GetReasonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetReasonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetReasonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetReasonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetReasonList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasonList" style="document" />
      <wsdl:input name="GetReasonListRequest">
        <soap:header message="tns:GetReasonListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetReasonListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetReasonListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetReasonListResponse">
        <soap:header message="tns:GetReasonListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetReasonListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetReasonListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetReasonListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetReasons">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasons" style="document" />
      <wsdl:input name="GetReasonsRequest">
        <soap:header message="tns:GetReasonsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetReasonsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetReasonsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetReasonsResponse">
        <soap:header message="tns:GetReasonsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetReasonsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetReasonsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetReasonsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetReasonSold">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetReasonSold" style="document" />
      <wsdl:input name="GetReasonSoldRequest">
        <soap:header message="tns:GetReasonSoldRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetReasonSoldRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetReasonSoldRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetReasonSoldResponse">
        <soap:header message="tns:GetReasonSoldResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetReasonSoldResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetReasonSoldResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetReasonSoldResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultCurrencyEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultCurrencyEntity" style="document" />
      <wsdl:input name="CreateDefaultCurrencyEntityRequest">
        <soap:header message="tns:CreateDefaultCurrencyEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultCurrencyEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultCurrencyEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultCurrencyEntityResponse">
        <soap:header message="tns:CreateDefaultCurrencyEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultCurrencyEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultCurrencyEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultCurrencyEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveCurrencyEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveCurrencyEntity" style="document" />
      <wsdl:input name="SaveCurrencyEntityRequest">
        <soap:header message="tns:SaveCurrencyEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveCurrencyEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveCurrencyEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveCurrencyEntityResponse">
        <soap:header message="tns:SaveCurrencyEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveCurrencyEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveCurrencyEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveCurrencyEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAmountClassEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultAmountClassEntity" style="document" />
      <wsdl:input name="CreateDefaultAmountClassEntityRequest">
        <soap:header message="tns:CreateDefaultAmountClassEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultAmountClassEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultAmountClassEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultAmountClassEntityResponse">
        <soap:header message="tns:CreateDefaultAmountClassEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAmountClassEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAmountClassEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultAmountClassEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveAmountClassEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveAmountClassEntity" style="document" />
      <wsdl:input name="SaveAmountClassEntityRequest">
        <soap:header message="tns:SaveAmountClassEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveAmountClassEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveAmountClassEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveAmountClassEntityResponse">
        <soap:header message="tns:SaveAmountClassEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveAmountClassEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveAmountClassEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveAmountClassEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultHeadingEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultHeadingEntity" style="document" />
      <wsdl:input name="CreateDefaultHeadingEntityRequest">
        <soap:header message="tns:CreateDefaultHeadingEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultHeadingEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultHeadingEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultHeadingEntityResponse">
        <soap:header message="tns:CreateDefaultHeadingEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultHeadingEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultHeadingEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultHeadingEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveHeadingEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveHeadingEntity" style="document" />
      <wsdl:input name="SaveHeadingEntityRequest">
        <soap:header message="tns:SaveHeadingEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveHeadingEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveHeadingEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveHeadingEntityResponse">
        <soap:header message="tns:SaveHeadingEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveHeadingEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveHeadingEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveHeadingEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultListEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultListEntity" style="document" />
      <wsdl:input name="CreateDefaultListEntityRequest">
        <soap:header message="tns:CreateDefaultListEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultListEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultListEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultListEntityResponse">
        <soap:header message="tns:CreateDefaultListEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultListEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultListEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultListEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveListEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveListEntity" style="document" />
      <wsdl:input name="SaveListEntityRequest">
        <soap:header message="tns:SaveListEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveListEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveListEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveListEntityResponse">
        <soap:header message="tns:SaveListEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveListEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveListEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveListEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteListEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteListEntity" style="document" />
      <wsdl:input name="DeleteListEntityRequest">
        <soap:header message="tns:DeleteListEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteListEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteListEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteListEntityResponse">
        <soap:header message="tns:DeleteListEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteListEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteListEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteListEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultListItemEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultListItemEntity" style="document" />
      <wsdl:input name="CreateDefaultListItemEntityRequest">
        <soap:header message="tns:CreateDefaultListItemEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultListItemEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultListItemEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultListItemEntityResponse">
        <soap:header message="tns:CreateDefaultListItemEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultListItemEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultListItemEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultListItemEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultProjectTypeEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultProjectTypeEntity" style="document" />
      <wsdl:input name="CreateDefaultProjectTypeEntityRequest">
        <soap:header message="tns:CreateDefaultProjectTypeEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultProjectTypeEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultProjectTypeEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultProjectTypeEntityResponse">
        <soap:header message="tns:CreateDefaultProjectTypeEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultProjectTypeEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultProjectTypeEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultProjectTypeEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveProjectTypeEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveProjectTypeEntity" style="document" />
      <wsdl:input name="SaveProjectTypeEntityRequest">
        <soap:header message="tns:SaveProjectTypeEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveProjectTypeEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveProjectTypeEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveProjectTypeEntityResponse">
        <soap:header message="tns:SaveProjectTypeEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveProjectTypeEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveProjectTypeEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveProjectTypeEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultResourceEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultResourceEntity" style="document" />
      <wsdl:input name="CreateDefaultResourceEntityRequest">
        <soap:header message="tns:CreateDefaultResourceEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultResourceEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultResourceEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultResourceEntityResponse">
        <soap:header message="tns:CreateDefaultResourceEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultResourceEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultResourceEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultResourceEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveResourceEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveResourceEntity" style="document" />
      <wsdl:input name="SaveResourceEntityRequest">
        <soap:header message="tns:SaveResourceEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveResourceEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveResourceEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveResourceEntityResponse">
        <soap:header message="tns:SaveResourceEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveResourceEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveResourceEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveResourceEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteResourceEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteResourceEntity" style="document" />
      <wsdl:input name="DeleteResourceEntityRequest">
        <soap:header message="tns:DeleteResourceEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteResourceEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteResourceEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteResourceEntityResponse">
        <soap:header message="tns:DeleteResourceEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteResourceEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteResourceEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteResourceEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultSaleStageEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultSaleStageEntity" style="document" />
      <wsdl:input name="CreateDefaultSaleStageEntityRequest">
        <soap:header message="tns:CreateDefaultSaleStageEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultSaleStageEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultSaleStageEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultSaleStageEntityResponse">
        <soap:header message="tns:CreateDefaultSaleStageEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSaleStageEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSaleStageEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultSaleStageEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveSaleStageEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveSaleStageEntity" style="document" />
      <wsdl:input name="SaveSaleStageEntityRequest">
        <soap:header message="tns:SaveSaleStageEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveSaleStageEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveSaleStageEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveSaleStageEntityResponse">
        <soap:header message="tns:SaveSaleStageEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveSaleStageEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveSaleStageEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveSaleStageEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultSaleTypeEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultSaleTypeEntity" style="document" />
      <wsdl:input name="CreateDefaultSaleTypeEntityRequest">
        <soap:header message="tns:CreateDefaultSaleTypeEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultSaleTypeEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultSaleTypeEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultSaleTypeEntityResponse">
        <soap:header message="tns:CreateDefaultSaleTypeEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSaleTypeEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSaleTypeEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultSaleTypeEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveSaleTypeEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveSaleTypeEntity" style="document" />
      <wsdl:input name="SaveSaleTypeEntityRequest">
        <soap:header message="tns:SaveSaleTypeEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveSaleTypeEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveSaleTypeEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveSaleTypeEntityResponse">
        <soap:header message="tns:SaveSaleTypeEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveSaleTypeEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveSaleTypeEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveSaleTypeEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultWebPanelEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultWebPanelEntity" style="document" />
      <wsdl:input name="CreateDefaultWebPanelEntityRequest">
        <soap:header message="tns:CreateDefaultWebPanelEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultWebPanelEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultWebPanelEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultWebPanelEntityResponse">
        <soap:header message="tns:CreateDefaultWebPanelEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWebPanelEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWebPanelEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultWebPanelEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveWebPanelEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveWebPanelEntity" style="document" />
      <wsdl:input name="SaveWebPanelEntityRequest">
        <soap:header message="tns:SaveWebPanelEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveWebPanelEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveWebPanelEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveWebPanelEntityResponse">
        <soap:header message="tns:SaveWebPanelEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveWebPanelEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveWebPanelEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveWebPanelEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultExtAppEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultExtAppEntity" style="document" />
      <wsdl:input name="CreateDefaultExtAppEntityRequest">
        <soap:header message="tns:CreateDefaultExtAppEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultExtAppEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultExtAppEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultExtAppEntityResponse">
        <soap:header message="tns:CreateDefaultExtAppEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultExtAppEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultExtAppEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultExtAppEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveExtAppEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveExtAppEntity" style="document" />
      <wsdl:input name="SaveExtAppEntityRequest">
        <soap:header message="tns:SaveExtAppEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveExtAppEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveExtAppEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveExtAppEntityResponse">
        <soap:header message="tns:SaveExtAppEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveExtAppEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveExtAppEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveExtAppEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultDocumentTemplateEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultDocumentTemplateEntity" style="document" />
      <wsdl:input name="CreateDefaultDocumentTemplateEntityRequest">
        <soap:header message="tns:CreateDefaultDocumentTemplateEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentTemplateEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentTemplateEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultDocumentTemplateEntityResponse">
        <soap:header message="tns:CreateDefaultDocumentTemplateEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentTemplateEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentTemplateEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentTemplateEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveDocumentTemplateEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveDocumentTemplateEntity" style="document" />
      <wsdl:input name="SaveDocumentTemplateEntityRequest">
        <soap:header message="tns:SaveDocumentTemplateEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveDocumentTemplateEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveDocumentTemplateEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveDocumentTemplateEntityResponse">
        <soap:header message="tns:SaveDocumentTemplateEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveDocumentTemplateEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveDocumentTemplateEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveDocumentTemplateEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultRelationDefinitionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultRelationDefinitionEntity" style="document" />
      <wsdl:input name="CreateDefaultRelationDefinitionEntityRequest">
        <soap:header message="tns:CreateDefaultRelationDefinitionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultRelationDefinitionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultRelationDefinitionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultRelationDefinitionEntityResponse">
        <soap:header message="tns:CreateDefaultRelationDefinitionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultRelationDefinitionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultRelationDefinitionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultRelationDefinitionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveRelationDefinitionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveRelationDefinitionEntity" style="document" />
      <wsdl:input name="SaveRelationDefinitionEntityRequest">
        <soap:header message="tns:SaveRelationDefinitionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveRelationDefinitionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveRelationDefinitionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveRelationDefinitionEntityResponse">
        <soap:header message="tns:SaveRelationDefinitionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveRelationDefinitionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveRelationDefinitionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveRelationDefinitionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBusiness">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetBusiness" style="document" />
      <wsdl:input name="GetBusinessRequest">
        <soap:header message="tns:GetBusinessRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBusinessRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBusinessRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBusinessResponse">
        <soap:header message="tns:GetBusinessResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBusinessResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBusinessResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBusinessResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBusinessList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetBusinessList" style="document" />
      <wsdl:input name="GetBusinessListRequest">
        <soap:header message="tns:GetBusinessListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBusinessListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBusinessListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBusinessListResponse">
        <soap:header message="tns:GetBusinessListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBusinessListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBusinessListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBusinessListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBusinesses">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetBusinesses" style="document" />
      <wsdl:input name="GetBusinessesRequest">
        <soap:header message="tns:GetBusinessesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBusinessesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBusinessesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBusinessesResponse">
        <soap:header message="tns:GetBusinessesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBusinessesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBusinessesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBusinessesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCategory">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCategory" style="document" />
      <wsdl:input name="GetCategoryRequest">
        <soap:header message="tns:GetCategoryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCategoryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCategoryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCategoryResponse">
        <soap:header message="tns:GetCategoryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCategoryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCategoryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCategoryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCategoryList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCategoryList" style="document" />
      <wsdl:input name="GetCategoryListRequest">
        <soap:header message="tns:GetCategoryListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCategoryListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCategoryListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCategoryListResponse">
        <soap:header message="tns:GetCategoryListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCategoryListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCategoryListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCategoryListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCategories">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCategories" style="document" />
      <wsdl:input name="GetCategoriesRequest">
        <soap:header message="tns:GetCategoriesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCategoriesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCategoriesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCategoriesResponse">
        <soap:header message="tns:GetCategoriesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCategoriesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCategoriesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCategoriesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCompetitor">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCompetitor" style="document" />
      <wsdl:input name="GetCompetitorRequest">
        <soap:header message="tns:GetCompetitorRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCompetitorRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCompetitorRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCompetitorResponse">
        <soap:header message="tns:GetCompetitorResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCompetitorResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCompetitorResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCompetitorResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCompetitorList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCompetitorList" style="document" />
      <wsdl:input name="GetCompetitorListRequest">
        <soap:header message="tns:GetCompetitorListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCompetitorListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCompetitorListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCompetitorListResponse">
        <soap:header message="tns:GetCompetitorListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCompetitorListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCompetitorListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCompetitorListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCompetitors">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCompetitors" style="document" />
      <wsdl:input name="GetCompetitorsRequest">
        <soap:header message="tns:GetCompetitorsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCompetitorsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCompetitorsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCompetitorsResponse">
        <soap:header message="tns:GetCompetitorsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCompetitorsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCompetitorsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCompetitorsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCountry">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCountry" style="document" />
      <wsdl:input name="GetCountryRequest">
        <soap:header message="tns:GetCountryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCountryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCountryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCountryResponse">
        <soap:header message="tns:GetCountryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCountryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCountryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCountryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveCountry">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveCountry" style="document" />
      <wsdl:input name="SaveCountryRequest">
        <soap:header message="tns:SaveCountryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveCountryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveCountryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveCountryResponse">
        <soap:header message="tns:SaveCountryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveCountryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveCountryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveCountryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultCountry">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultCountry" style="document" />
      <wsdl:input name="CreateDefaultCountryRequest">
        <soap:header message="tns:CreateDefaultCountryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultCountryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultCountryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultCountryResponse">
        <soap:header message="tns:CreateDefaultCountryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultCountryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultCountryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultCountryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCountryList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCountryList" style="document" />
      <wsdl:input name="GetCountryListRequest">
        <soap:header message="tns:GetCountryListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCountryListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCountryListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCountryListResponse">
        <soap:header message="tns:GetCountryListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCountryListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCountryListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCountryListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCountries">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCountries" style="document" />
      <wsdl:input name="GetCountriesRequest">
        <soap:header message="tns:GetCountriesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCountriesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCountriesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCountriesResponse">
        <soap:header message="tns:GetCountriesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCountriesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCountriesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCountriesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllCountries">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllCountries" style="document" />
      <wsdl:input name="GetAllCountriesRequest">
        <soap:header message="tns:GetAllCountriesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllCountriesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllCountriesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllCountriesResponse">
        <soap:header message="tns:GetAllCountriesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllCountriesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllCountriesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllCountriesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCredited">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCredited" style="document" />
      <wsdl:input name="GetCreditedRequest">
        <soap:header message="tns:GetCreditedRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCreditedRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCreditedRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCreditedResponse">
        <soap:header message="tns:GetCreditedResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCreditedResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCreditedResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCreditedResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCreditedList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCreditedList" style="document" />
      <wsdl:input name="GetCreditedListRequest">
        <soap:header message="tns:GetCreditedListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCreditedListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCreditedListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCreditedListResponse">
        <soap:header message="tns:GetCreditedListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCreditedListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCreditedListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCreditedListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCrediteds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCrediteds" style="document" />
      <wsdl:input name="GetCreditedsRequest">
        <soap:header message="tns:GetCreditedsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCreditedsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCreditedsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCreditedsResponse">
        <soap:header message="tns:GetCreditedsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCreditedsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCreditedsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCreditedsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCurrency">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCurrency" style="document" />
      <wsdl:input name="GetCurrencyRequest">
        <soap:header message="tns:GetCurrencyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCurrencyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCurrencyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCurrencyResponse">
        <soap:header message="tns:GetCurrencyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCurrencyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCurrencyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCurrencyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetOurCurrency">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetOurCurrency" style="document" />
      <wsdl:input name="GetOurCurrencyRequest">
        <soap:header message="tns:GetOurCurrencyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetOurCurrencyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetOurCurrencyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetOurCurrencyResponse">
        <soap:header message="tns:GetOurCurrencyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetOurCurrencyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetOurCurrencyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetOurCurrencyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChangeCurrency">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/ChangeCurrency" style="document" />
      <wsdl:input name="ChangeCurrencyRequest">
        <soap:header message="tns:ChangeCurrencyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChangeCurrencyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChangeCurrencyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChangeCurrencyResponse">
        <soap:header message="tns:ChangeCurrencyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChangeCurrencyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChangeCurrencyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChangeCurrencyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetOwnerCompanysCurrency">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetOwnerCompanysCurrency" style="document" />
      <wsdl:input name="GetOwnerCompanysCurrencyRequest">
        <soap:header message="tns:GetOwnerCompanysCurrencyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetOwnerCompanysCurrencyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetOwnerCompanysCurrencyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetOwnerCompanysCurrencyResponse">
        <soap:header message="tns:GetOwnerCompanysCurrencyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetOwnerCompanysCurrencyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetOwnerCompanysCurrencyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetOwnerCompanysCurrencyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCurrencyEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCurrencyEntity" style="document" />
      <wsdl:input name="GetCurrencyEntityRequest">
        <soap:header message="tns:GetCurrencyEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCurrencyEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCurrencyEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCurrencyEntityResponse">
        <soap:header message="tns:GetCurrencyEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCurrencyEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCurrencyEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCurrencyEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBaseCurrency">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetBaseCurrency" style="document" />
      <wsdl:input name="GetBaseCurrencyRequest">
        <soap:header message="tns:GetBaseCurrencyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBaseCurrencyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBaseCurrencyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBaseCurrencyResponse">
        <soap:header message="tns:GetBaseCurrencyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBaseCurrencyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBaseCurrencyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBaseCurrencyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAmountClassEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAmountClassEntity" style="document" />
      <wsdl:input name="GetAmountClassEntityRequest">
        <soap:header message="tns:GetAmountClassEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAmountClassEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAmountClassEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAmountClassEntityResponse">
        <soap:header message="tns:GetAmountClassEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAmountClassEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAmountClassEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAmountClassEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCurrencyList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCurrencyList" style="document" />
      <wsdl:input name="GetCurrencyListRequest">
        <soap:header message="tns:GetCurrencyListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCurrencyListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCurrencyListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCurrencyListResponse">
        <soap:header message="tns:GetCurrencyListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCurrencyListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCurrencyListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCurrencyListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCurrencies">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCurrencies" style="document" />
      <wsdl:input name="GetCurrenciesRequest">
        <soap:header message="tns:GetCurrenciesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCurrenciesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCurrenciesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCurrenciesResponse">
        <soap:header message="tns:GetCurrenciesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCurrenciesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCurrenciesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCurrenciesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllCurrencies">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllCurrencies" style="document" />
      <wsdl:input name="GetAllCurrenciesRequest">
        <soap:header message="tns:GetAllCurrenciesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllCurrenciesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllCurrenciesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllCurrenciesResponse">
        <soap:header message="tns:GetAllCurrenciesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllCurrenciesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllCurrenciesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllCurrenciesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCustomerLanguage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCustomerLanguage" style="document" />
      <wsdl:input name="GetCustomerLanguageRequest">
        <soap:header message="tns:GetCustomerLanguageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCustomerLanguageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCustomerLanguageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCustomerLanguageResponse">
        <soap:header message="tns:GetCustomerLanguageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCustomerLanguageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCustomerLanguageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCustomerLanguageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCustomerLanguageList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCustomerLanguageList" style="document" />
      <wsdl:input name="GetCustomerLanguageListRequest">
        <soap:header message="tns:GetCustomerLanguageListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCustomerLanguageListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCustomerLanguageListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCustomerLanguageListResponse">
        <soap:header message="tns:GetCustomerLanguageListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCustomerLanguageListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCustomerLanguageListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCustomerLanguageListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCustomerLanguages">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetCustomerLanguages" style="document" />
      <wsdl:input name="GetCustomerLanguagesRequest">
        <soap:header message="tns:GetCustomerLanguagesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCustomerLanguagesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCustomerLanguagesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCustomerLanguagesResponse">
        <soap:header message="tns:GetCustomerLanguagesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCustomerLanguagesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCustomerLanguagesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCustomerLanguagesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDeliveryTerm">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDeliveryTerm" style="document" />
      <wsdl:input name="GetDeliveryTermRequest">
        <soap:header message="tns:GetDeliveryTermRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDeliveryTermRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDeliveryTermRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDeliveryTermResponse">
        <soap:header message="tns:GetDeliveryTermResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDeliveryTermResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDeliveryTermResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDeliveryTermResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDeliveryTerms">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDeliveryTerms" style="document" />
      <wsdl:input name="GetDeliveryTermsRequest">
        <soap:header message="tns:GetDeliveryTermsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDeliveryTermsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDeliveryTermsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDeliveryTermsResponse">
        <soap:header message="tns:GetDeliveryTermsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDeliveryTermsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDeliveryTermsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDeliveryTermsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDeliveryType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDeliveryType" style="document" />
      <wsdl:input name="GetDeliveryTypeRequest">
        <soap:header message="tns:GetDeliveryTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDeliveryTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDeliveryTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDeliveryTypeResponse">
        <soap:header message="tns:GetDeliveryTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDeliveryTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDeliveryTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDeliveryTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDeliveryTypes">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDeliveryTypes" style="document" />
      <wsdl:input name="GetDeliveryTypesRequest">
        <soap:header message="tns:GetDeliveryTypesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDeliveryTypesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDeliveryTypesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDeliveryTypesResponse">
        <soap:header message="tns:GetDeliveryTypesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDeliveryTypesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDeliveryTypesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDeliveryTypesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPaymentTerm">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPaymentTerm" style="document" />
      <wsdl:input name="GetPaymentTermRequest">
        <soap:header message="tns:GetPaymentTermRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPaymentTermRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPaymentTermRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPaymentTermResponse">
        <soap:header message="tns:GetPaymentTermResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPaymentTermResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPaymentTermResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPaymentTermResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPaymentTerms">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPaymentTerms" style="document" />
      <wsdl:input name="GetPaymentTermsRequest">
        <soap:header message="tns:GetPaymentTermsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPaymentTermsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPaymentTermsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPaymentTermsResponse">
        <soap:header message="tns:GetPaymentTermsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPaymentTermsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPaymentTermsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPaymentTermsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPaymentType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPaymentType" style="document" />
      <wsdl:input name="GetPaymentTypeRequest">
        <soap:header message="tns:GetPaymentTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPaymentTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPaymentTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPaymentTypeResponse">
        <soap:header message="tns:GetPaymentTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPaymentTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPaymentTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPaymentTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPaymentTypes">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetPaymentTypes" style="document" />
      <wsdl:input name="GetPaymentTypesRequest">
        <soap:header message="tns:GetPaymentTypesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPaymentTypesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPaymentTypesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPaymentTypesResponse">
        <soap:header message="tns:GetPaymentTypesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPaymentTypesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPaymentTypesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPaymentTypesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDepartment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDepartment" style="document" />
      <wsdl:input name="GetDepartmentRequest">
        <soap:header message="tns:GetDepartmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDepartmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDepartmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDepartmentResponse">
        <soap:header message="tns:GetDepartmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDepartmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDepartmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDepartmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDepartmentList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDepartmentList" style="document" />
      <wsdl:input name="GetDepartmentListRequest">
        <soap:header message="tns:GetDepartmentListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDepartmentListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDepartmentListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDepartmentListResponse">
        <soap:header message="tns:GetDepartmentListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDepartmentListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDepartmentListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDepartmentListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDepartments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDepartments" style="document" />
      <wsdl:input name="GetDepartmentsRequest">
        <soap:header message="tns:GetDepartmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDepartmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDepartmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDepartmentsResponse">
        <soap:header message="tns:GetDepartmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDepartmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDepartmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDepartmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplate" style="document" />
      <wsdl:input name="GetDocumentTemplateRequest">
        <soap:header message="tns:GetDocumentTemplateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentTemplateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentTemplateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentTemplateResponse">
        <soap:header message="tns:GetDocumentTemplateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentTemplateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplateList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplateList" style="document" />
      <wsdl:input name="GetDocumentTemplateListRequest">
        <soap:header message="tns:GetDocumentTemplateListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentTemplateListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentTemplateListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentTemplateListResponse">
        <soap:header message="tns:GetDocumentTemplateListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplateListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentTemplateListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentTemplates">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetDocumentTemplates" style="document" />
      <wsdl:input name="GetDocumentTemplatesRequest">
        <soap:header message="tns:GetDocumentTemplatesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentTemplatesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentTemplatesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentTemplatesResponse">
        <soap:header message="tns:GetDocumentTemplatesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplatesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentTemplatesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentTemplatesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllDocumentTemplates">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetAllDocumentTemplates" style="document" />
      <wsdl:input name="GetAllDocumentTemplatesRequest">
        <soap:header message="tns:GetAllDocumentTemplatesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllDocumentTemplatesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllDocumentTemplatesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllDocumentTemplatesResponse">
        <soap:header message="tns:GetAllDocumentTemplatesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllDocumentTemplatesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllDocumentTemplatesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllDocumentTemplatesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetHeadingEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetHeadingEntity" style="document" />
      <wsdl:input name="GetHeadingEntityRequest">
        <soap:header message="tns:GetHeadingEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetHeadingEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetHeadingEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetHeadingEntityResponse">
        <soap:header message="tns:GetHeadingEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetHeadingEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetHeadingEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetHeadingEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultHeadingFromListDefinition">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/CreateDefaultHeadingFromListDefinition" style="document" />
      <wsdl:input name="CreateDefaultHeadingFromListDefinitionRequest">
        <soap:header message="tns:CreateDefaultHeadingFromListDefinitionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultHeadingFromListDefinitionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultHeadingFromListDefinitionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultHeadingFromListDefinitionResponse">
        <soap:header message="tns:CreateDefaultHeadingFromListDefinitionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultHeadingFromListDefinitionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultHeadingFromListDefinitionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultHeadingFromListDefinitionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLanguageInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLanguageInfo" style="document" />
      <wsdl:input name="GetLanguageInfoRequest">
        <soap:header message="tns:GetLanguageInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLanguageInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLanguageInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLanguageInfoResponse">
        <soap:header message="tns:GetLanguageInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLanguageInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLanguageInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLanguageInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLanguageInfoList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLanguageInfoList" style="document" />
      <wsdl:input name="GetLanguageInfoListRequest">
        <soap:header message="tns:GetLanguageInfoListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLanguageInfoListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLanguageInfoListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLanguageInfoListResponse">
        <soap:header message="tns:GetLanguageInfoListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLanguageInfoListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLanguageInfoListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLanguageInfoListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetInstalledLanguages">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetInstalledLanguages" style="document" />
      <wsdl:input name="GetInstalledLanguagesRequest">
        <soap:header message="tns:GetInstalledLanguagesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetInstalledLanguagesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetInstalledLanguagesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetInstalledLanguagesResponse">
        <soap:header message="tns:GetInstalledLanguagesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetInstalledLanguagesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetInstalledLanguagesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetInstalledLanguagesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLink">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLink" style="document" />
      <wsdl:input name="GetLinkRequest">
        <soap:header message="tns:GetLinkRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLinkRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLinkRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLinkResponse">
        <soap:header message="tns:GetLinkResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLinkResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLinkResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLinkResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLinkList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetLinkList" style="document" />
      <wsdl:input name="GetLinkListRequest">
        <soap:header message="tns:GetLinkListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLinkListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLinkListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLinkListResponse">
        <soap:header message="tns:GetLinkListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLinkListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLinkListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLinkListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetListEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListEntity" style="document" />
      <wsdl:input name="GetListEntityRequest">
        <soap:header message="tns:GetListEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetListEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetListEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetListEntityResponse">
        <soap:header message="tns:GetListEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetListEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetListEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetListEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetListDefinitions">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListDefinitions" style="document" />
      <wsdl:input name="GetListDefinitionsRequest">
        <soap:header message="tns:GetListDefinitionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetListDefinitionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetListDefinitionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetListDefinitionsResponse">
        <soap:header message="tns:GetListDefinitionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetListDefinitionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetListDefinitionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetListDefinitionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetListEntityByName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/GetListEntityByName" style="document" />
      <wsdl:input name="GetListEntityByNameRequest">
        <soap:header message="tns:GetListEntityByNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetListEntityByNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetListEntityByNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetListEntityByNameResponse">
        <soap:header message="tns:GetListEntityByNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetListEntityByNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetListEntityByNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetListEntityByNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveListEntityByName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/SaveListEntityByName" style="document" />
      <wsdl:input name="SaveListEntityByNameRequest">
        <soap:header message="tns:SaveListEntityByNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveListEntityByNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveListEntityByNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveListEntityByNameResponse">
        <soap:header message="tns:SaveListEntityByNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveListEntityByNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveListEntityByNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveListEntityByNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteListEntityByName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/List/DeleteListEntityByName" style="document" />
      <wsdl:input name="DeleteListEntityByNameRequest">
        <soap:header message="tns:DeleteListEntityByNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteListEntityByNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteListEntityByNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteListEntityByNameResponse">
        <soap:header message="tns:DeleteListEntityByNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteListEntityByNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteListEntityByNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteListEntityByNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfListService">
    <wsdl:port name="BasicHttpBinding_List" binding="tns:BasicHttpBinding_List">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services85/List.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

