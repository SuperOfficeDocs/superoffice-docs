---
Generated: 1
TOCExclude: 1
title: Services75.PartnerAgent WSDL
---

# Services75.PartnerAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfPartnerService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services75" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services75" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services75" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:element name="CreateOrUpdateWebPanel">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Identifier" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DisplayDescription" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Url" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="VisibleIn" type="tns:Navigation" />
            <xs:element minOccurs="0" name="UrlEncoding" type="tns:UrlEncoding" />
            <xs:element minOccurs="0" name="OnSalesMarketingWeb" type="xs:boolean" />
            <xs:element minOccurs="0" name="OnSalesMarketingPocket" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
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
          <xs:enumeration value="PersonDialog" />
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
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="Navigation" nillable="true" type="tns:Navigation" />
      <xs:simpleType name="UrlEncoding">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="None" />
          <xs:enumeration value="ANSI" />
          <xs:enumeration value="Unicode" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="UrlEncoding" nillable="true" type="tns:UrlEncoding" />
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
      <xs:element name="CreateOrUpdateWebPanelResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
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
      <xs:element name="SuspendWebPanel">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Identifier" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SuspendWebPanelResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ResumeWebPanel">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Identifier" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ResumeWebPanelResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyWebPanels">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyWebPanelsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPartnerWebPanel" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfPartnerWebPanel">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="PartnerWebPanel" nillable="true" type="tns:PartnerWebPanel" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfPartnerWebPanel" nillable="true" type="tns:ArrayOfPartnerWebPanel" />
      <xs:complexType name="PartnerWebPanel">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Identifier" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayDescription" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Url" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="VisibleIn" type="tns:Navigation" />
              <xs:element minOccurs="0" name="UrlEncoding" type="tns:UrlEncoding" />
              <xs:element minOccurs="0" name="OnSalesMarketingWeb" type="xs:boolean" />
              <xs:element minOccurs="0" name="OnSalesMarketingPocket" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsSuspended" type="xs:boolean" />
              <xs:element minOccurs="0" name="WindowName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PartnerWebPanel" nillable="true" type="tns:PartnerWebPanel" />
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
      <xs:element name="DeleteWebPanel">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Identifier" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteWebPanelResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteMyWebPanels">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteMyWebPanelsResponse">
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
  <wsdl:message name="CreateOrUpdateWebPanelRequest">
    <wsdl:part name="parameters" element="tns:CreateOrUpdateWebPanel" />
  </wsdl:message>
  <wsdl:message name="CreateOrUpdateWebPanelRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateOrUpdateWebPanelResponse">
    <wsdl:part name="parameters" element="tns:CreateOrUpdateWebPanelResponse" />
  </wsdl:message>
  <wsdl:message name="CreateOrUpdateWebPanelResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SuspendWebPanelRequest">
    <wsdl:part name="parameters" element="tns:SuspendWebPanel" />
  </wsdl:message>
  <wsdl:message name="SuspendWebPanelRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SuspendWebPanelResponse">
    <wsdl:part name="parameters" element="tns:SuspendWebPanelResponse" />
  </wsdl:message>
  <wsdl:message name="SuspendWebPanelResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ResumeWebPanelRequest">
    <wsdl:part name="parameters" element="tns:ResumeWebPanel" />
  </wsdl:message>
  <wsdl:message name="ResumeWebPanelRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ResumeWebPanelResponse">
    <wsdl:part name="parameters" element="tns:ResumeWebPanelResponse" />
  </wsdl:message>
  <wsdl:message name="ResumeWebPanelResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyWebPanelsRequest">
    <wsdl:part name="parameters" element="tns:GetMyWebPanels" />
  </wsdl:message>
  <wsdl:message name="GetMyWebPanelsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyWebPanelsResponse">
    <wsdl:part name="parameters" element="tns:GetMyWebPanelsResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyWebPanelsResponse_Headers">
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
  <wsdl:message name="DeleteMyWebPanelsRequest">
    <wsdl:part name="parameters" element="tns:DeleteMyWebPanels" />
  </wsdl:message>
  <wsdl:message name="DeleteMyWebPanelsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteMyWebPanelsResponse">
    <wsdl:part name="parameters" element="tns:DeleteMyWebPanelsResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteMyWebPanelsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Partner">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Partner</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateOrUpdateWebPanel">
      <wsdl:documentation>
        <summary>Create a web panel in the logged in users' installation of SuperOffice CRM online. The panel will automatically be registered to the currently authenticated ApplicationId.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Partner/CreateOrUpdateWebPanel" name="CreateOrUpdateWebPanelRequest" message="tns:CreateOrUpdateWebPanelRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Partner/CreateOrUpdateWebPanelResponse" name="CreateOrUpdateWebPanelResponse" message="tns:CreateOrUpdateWebPanelResponse" />
    </wsdl:operation>
    <wsdl:operation name="SuspendWebPanel">
      <wsdl:documentation>
        <summary>The web panel is no longer visible to the users, but all settings are kept</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Partner/SuspendWebPanel" name="SuspendWebPanelRequest" message="tns:SuspendWebPanelRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Partner/SuspendWebPanelResponse" name="SuspendWebPanelResponse" message="tns:SuspendWebPanelResponse" />
    </wsdl:operation>
    <wsdl:operation name="ResumeWebPanel">
      <wsdl:documentation>
        <summary>Undo a Suspend, so that the Web Panel is visible to users again</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Partner/ResumeWebPanel" name="ResumeWebPanelRequest" message="tns:ResumeWebPanelRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Partner/ResumeWebPanelResponse" name="ResumeWebPanelResponse" message="tns:ResumeWebPanelResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyWebPanels">
      <wsdl:documentation>
        <summary>Get all web panels registered by this ApplicationId</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Partner/GetMyWebPanels" name="GetMyWebPanelsRequest" message="tns:GetMyWebPanelsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Partner/GetMyWebPanelsResponse" name="GetMyWebPanelsResponse" message="tns:GetMyWebPanelsResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteWebPanel">
      <wsdl:documentation>
        <summary>Irrevocably delete all information related to this web panel; no undo</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Partner/DeleteWebPanel" name="DeleteWebPanelRequest" message="tns:DeleteWebPanelRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Partner/DeleteWebPanelResponse" name="DeleteWebPanelResponse" message="tns:DeleteWebPanelResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteMyWebPanels">
      <wsdl:documentation>
        <summary>Irrevocably delete all web panels registered by this ApplicationId</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Partner/DeleteMyWebPanels" name="DeleteMyWebPanelsRequest" message="tns:DeleteMyWebPanelsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Partner/DeleteMyWebPanelsResponse" name="DeleteMyWebPanelsResponse" message="tns:DeleteMyWebPanelsResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Partner" type="tns:Partner">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateOrUpdateWebPanel">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Partner/CreateOrUpdateWebPanel" style="document" />
      <wsdl:input name="CreateOrUpdateWebPanelRequest">
        <soap:header message="tns:CreateOrUpdateWebPanelRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateOrUpdateWebPanelRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateOrUpdateWebPanelRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateOrUpdateWebPanelResponse">
        <soap:header message="tns:CreateOrUpdateWebPanelResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateOrUpdateWebPanelResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateOrUpdateWebPanelResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateOrUpdateWebPanelResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SuspendWebPanel">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Partner/SuspendWebPanel" style="document" />
      <wsdl:input name="SuspendWebPanelRequest">
        <soap:header message="tns:SuspendWebPanelRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SuspendWebPanelRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SuspendWebPanelRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SuspendWebPanelResponse">
        <soap:header message="tns:SuspendWebPanelResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SuspendWebPanelResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SuspendWebPanelResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SuspendWebPanelResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ResumeWebPanel">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Partner/ResumeWebPanel" style="document" />
      <wsdl:input name="ResumeWebPanelRequest">
        <soap:header message="tns:ResumeWebPanelRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ResumeWebPanelRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ResumeWebPanelRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ResumeWebPanelResponse">
        <soap:header message="tns:ResumeWebPanelResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ResumeWebPanelResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ResumeWebPanelResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ResumeWebPanelResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyWebPanels">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Partner/GetMyWebPanels" style="document" />
      <wsdl:input name="GetMyWebPanelsRequest">
        <soap:header message="tns:GetMyWebPanelsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyWebPanelsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyWebPanelsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyWebPanelsResponse">
        <soap:header message="tns:GetMyWebPanelsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyWebPanelsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyWebPanelsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyWebPanelsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteWebPanel">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Partner/DeleteWebPanel" style="document" />
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
    <wsdl:operation name="DeleteMyWebPanels">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Partner/DeleteMyWebPanels" style="document" />
      <wsdl:input name="DeleteMyWebPanelsRequest">
        <soap:header message="tns:DeleteMyWebPanelsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteMyWebPanelsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteMyWebPanelsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteMyWebPanelsResponse">
        <soap:header message="tns:DeleteMyWebPanelsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteMyWebPanelsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteMyWebPanelsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteMyWebPanelsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfPartnerService">
    <wsdl:port name="BasicHttpBinding_Partner" binding="tns:BasicHttpBinding_Partner">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services75/Partner.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

