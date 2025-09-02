---
generated: true
uid: wsdl-Services88-DocumentMigration
title: Services88.DocumentMigrationAgent WSDL
content_type: reference
---

# Services88.DocumentMigrationAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfDocumentMigrationService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultDocumentMigrationItemList">
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
      <xs:element name="CreateDefaultDocumentMigrationItemListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentMigrationItemList" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="DocumentMigrationItemList">
        <xs:sequence>
          <xs:element minOccurs="0" name="NumDocumentsOmitted" type="xs:int" />
          <xs:element minOccurs="0" name="NumDocumentsAlreadyMigrated" type="xs:int" />
          <xs:element minOccurs="0" name="Documents" nillable="true" type="tns:ArrayOfDocumentMigrationItem" />
          <xs:element minOccurs="0" name="Associates" nillable="true" type="tns:ArrayOfDocumentMigrationAssociate" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="DocumentMigrationItemList" nillable="true" type="tns:DocumentMigrationItemList" />
      <xs:complexType name="ArrayOfDocumentMigrationItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DocumentMigrationItem" nillable="true" type="tns:DocumentMigrationItem" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDocumentMigrationItem" nillable="true" type="tns:ArrayOfDocumentMigrationItem" />
      <xs:complexType name="DocumentMigrationItem">
        <xs:sequence>
          <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          <xs:element minOccurs="0" name="SaleId" type="xs:int" />
          <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
          <xs:element minOccurs="0" name="DocTmplId" type="xs:int" />
          <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          <xs:element minOccurs="0" name="UserGroupId" type="xs:int" />
          <xs:element minOccurs="0" name="VisibleForId" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="DocumentMigrationItem" nillable="true" type="tns:DocumentMigrationItem" />
      <xs:complexType name="ArrayOfDocumentMigrationAssociate">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DocumentMigrationAssociate" nillable="true" type="tns:DocumentMigrationAssociate" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDocumentMigrationAssociate" nillable="true" type="tns:ArrayOfDocumentMigrationAssociate" />
      <xs:complexType name="DocumentMigrationAssociate">
        <xs:sequence>
          <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="DocumentMigrationAssociate" nillable="true" type="tns:DocumentMigrationAssociate" />
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
      <xs:element name="CreateDefaultDocumentTemplateMigrationList">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultDocumentTemplateMigrationListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentTemplateMigrationList" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="DocumentTemplateMigrationList">
        <xs:sequence>
          <xs:element minOccurs="0" name="NumTemplatesOmitted" type="xs:int" />
          <xs:element minOccurs="0" name="NumTemplatesAlreadyMigrated" type="xs:int" />
          <xs:element minOccurs="0" name="TemplateIds" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="DocumentTemplateMigrationList" nillable="true" type="tns:DocumentTemplateMigrationList" />
      <xs:element name="GetForAllDocuments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentPluginId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeEmails" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetForAllDocumentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentMigrationItemList" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetForDateRange">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentPluginId" type="xs:int" />
            <xs:element minOccurs="0" name="MinDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="MaxDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="IncludeEmails" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetForDateRangeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentMigrationItemList" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetForSelection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentPluginId" type="xs:int" />
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeEmails" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetForSelectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentMigrationItemList" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MigrateDocumentToNewDocPlugin">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentPluginId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MigrateDocumentToNewDocPluginResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="HasDocumentsToMigrate">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="HasDocumentsToMigrateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNumberOfConfidentialDocuments">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNumberOfConfidentialDocumentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetForTemplates">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TargetDocumentPluginId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeEmails" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetForTemplatesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentTemplateMigrationList" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MigrateTemplateToNewDocPlugin">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
            <xs:element minOccurs="0" name="TargetDocumentPluginId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MigrateTemplateToNewDocPluginResponse">
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
  <wsdl:message name="CreateDefaultDocumentMigrationItemListRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultDocumentMigrationItemList" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentMigrationItemListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentMigrationItemListResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultDocumentMigrationItemListResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentMigrationItemListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentTemplateMigrationListRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultDocumentTemplateMigrationList" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentTemplateMigrationListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentTemplateMigrationListResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultDocumentTemplateMigrationListResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentTemplateMigrationListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetForAllDocumentsRequest">
    <wsdl:part name="parameters" element="tns:GetForAllDocuments" />
  </wsdl:message>
  <wsdl:message name="GetForAllDocumentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetForAllDocumentsResponse">
    <wsdl:part name="parameters" element="tns:GetForAllDocumentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetForAllDocumentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetForDateRangeRequest">
    <wsdl:part name="parameters" element="tns:GetForDateRange" />
  </wsdl:message>
  <wsdl:message name="GetForDateRangeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetForDateRangeResponse">
    <wsdl:part name="parameters" element="tns:GetForDateRangeResponse" />
  </wsdl:message>
  <wsdl:message name="GetForDateRangeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetForSelectionRequest">
    <wsdl:part name="parameters" element="tns:GetForSelection" />
  </wsdl:message>
  <wsdl:message name="GetForSelectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetForSelectionResponse">
    <wsdl:part name="parameters" element="tns:GetForSelectionResponse" />
  </wsdl:message>
  <wsdl:message name="GetForSelectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MigrateDocumentToNewDocPluginRequest">
    <wsdl:part name="parameters" element="tns:MigrateDocumentToNewDocPlugin" />
  </wsdl:message>
  <wsdl:message name="MigrateDocumentToNewDocPluginRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MigrateDocumentToNewDocPluginResponse">
    <wsdl:part name="parameters" element="tns:MigrateDocumentToNewDocPluginResponse" />
  </wsdl:message>
  <wsdl:message name="MigrateDocumentToNewDocPluginResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasDocumentsToMigrateRequest">
    <wsdl:part name="parameters" element="tns:HasDocumentsToMigrate" />
  </wsdl:message>
  <wsdl:message name="HasDocumentsToMigrateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasDocumentsToMigrateResponse">
    <wsdl:part name="parameters" element="tns:HasDocumentsToMigrateResponse" />
  </wsdl:message>
  <wsdl:message name="HasDocumentsToMigrateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNumberOfConfidentialDocumentsRequest">
    <wsdl:part name="parameters" element="tns:GetNumberOfConfidentialDocuments" />
  </wsdl:message>
  <wsdl:message name="GetNumberOfConfidentialDocumentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNumberOfConfidentialDocumentsResponse">
    <wsdl:part name="parameters" element="tns:GetNumberOfConfidentialDocumentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetNumberOfConfidentialDocumentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetForTemplatesRequest">
    <wsdl:part name="parameters" element="tns:GetForTemplates" />
  </wsdl:message>
  <wsdl:message name="GetForTemplatesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetForTemplatesResponse">
    <wsdl:part name="parameters" element="tns:GetForTemplatesResponse" />
  </wsdl:message>
  <wsdl:message name="GetForTemplatesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MigrateTemplateToNewDocPluginRequest">
    <wsdl:part name="parameters" element="tns:MigrateTemplateToNewDocPlugin" />
  </wsdl:message>
  <wsdl:message name="MigrateTemplateToNewDocPluginRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MigrateTemplateToNewDocPluginResponse">
    <wsdl:part name="parameters" element="tns:MigrateTemplateToNewDocPluginResponse" />
  </wsdl:message>
  <wsdl:message name="MigrateTemplateToNewDocPluginResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="DocumentMigration">
    <wsdl:operation name="CreateDefaultDocumentMigrationItemList">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/CreateDefaultDocumentMigrationItemList" name="CreateDefaultDocumentMigrationItemListRequest" message="tns:CreateDefaultDocumentMigrationItemListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/CreateDefaultDocumentMigrationItemListResponse" name="CreateDefaultDocumentMigrationItemListResponse" message="tns:CreateDefaultDocumentMigrationItemListResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultDocumentTemplateMigrationList">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/CreateDefaultDocumentTemplateMigrationList" name="CreateDefaultDocumentTemplateMigrationListRequest" message="tns:CreateDefaultDocumentTemplateMigrationListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/CreateDefaultDocumentTemplateMigrationListResponse" name="CreateDefaultDocumentTemplateMigrationListResponse" message="tns:CreateDefaultDocumentTemplateMigrationListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetForAllDocuments">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/GetForAllDocuments" name="GetForAllDocumentsRequest" message="tns:GetForAllDocumentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/GetForAllDocumentsResponse" name="GetForAllDocumentsResponse" message="tns:GetForAllDocumentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetForDateRange">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/GetForDateRange" name="GetForDateRangeRequest" message="tns:GetForDateRangeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/GetForDateRangeResponse" name="GetForDateRangeResponse" message="tns:GetForDateRangeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetForSelection">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/GetForSelection" name="GetForSelectionRequest" message="tns:GetForSelectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/GetForSelectionResponse" name="GetForSelectionResponse" message="tns:GetForSelectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="MigrateDocumentToNewDocPlugin">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/MigrateDocumentToNewDocPlugin" name="MigrateDocumentToNewDocPluginRequest" message="tns:MigrateDocumentToNewDocPluginRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/MigrateDocumentToNewDocPluginResponse" name="MigrateDocumentToNewDocPluginResponse" message="tns:MigrateDocumentToNewDocPluginResponse" />
    </wsdl:operation>
    <wsdl:operation name="HasDocumentsToMigrate">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/HasDocumentsToMigrate" name="HasDocumentsToMigrateRequest" message="tns:HasDocumentsToMigrateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/HasDocumentsToMigrateResponse" name="HasDocumentsToMigrateResponse" message="tns:HasDocumentsToMigrateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNumberOfConfidentialDocuments">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/GetNumberOfConfidentialDocuments" name="GetNumberOfConfidentialDocumentsRequest" message="tns:GetNumberOfConfidentialDocumentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/GetNumberOfConfidentialDocumentsResponse" name="GetNumberOfConfidentialDocumentsResponse" message="tns:GetNumberOfConfidentialDocumentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetForTemplates">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/GetForTemplates" name="GetForTemplatesRequest" message="tns:GetForTemplatesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/GetForTemplatesResponse" name="GetForTemplatesResponse" message="tns:GetForTemplatesResponse" />
    </wsdl:operation>
    <wsdl:operation name="MigrateTemplateToNewDocPlugin">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/MigrateTemplateToNewDocPlugin" name="MigrateTemplateToNewDocPluginRequest" message="tns:MigrateTemplateToNewDocPluginRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/MigrateTemplateToNewDocPluginResponse" name="MigrateTemplateToNewDocPluginResponse" message="tns:MigrateTemplateToNewDocPluginResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_DocumentMigration" type="tns:DocumentMigration">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultDocumentMigrationItemList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/CreateDefaultDocumentMigrationItemList" style="document" />
      <wsdl:input name="CreateDefaultDocumentMigrationItemListRequest">
        <soap:header message="tns:CreateDefaultDocumentMigrationItemListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentMigrationItemListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentMigrationItemListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultDocumentMigrationItemListResponse">
        <soap:header message="tns:CreateDefaultDocumentMigrationItemListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentMigrationItemListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentMigrationItemListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentMigrationItemListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultDocumentTemplateMigrationList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/CreateDefaultDocumentTemplateMigrationList" style="document" />
      <wsdl:input name="CreateDefaultDocumentTemplateMigrationListRequest">
        <soap:header message="tns:CreateDefaultDocumentTemplateMigrationListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentTemplateMigrationListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentTemplateMigrationListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultDocumentTemplateMigrationListResponse">
        <soap:header message="tns:CreateDefaultDocumentTemplateMigrationListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentTemplateMigrationListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentTemplateMigrationListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentTemplateMigrationListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetForAllDocuments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/GetForAllDocuments" style="document" />
      <wsdl:input name="GetForAllDocumentsRequest">
        <soap:header message="tns:GetForAllDocumentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetForAllDocumentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetForAllDocumentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetForAllDocumentsResponse">
        <soap:header message="tns:GetForAllDocumentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetForAllDocumentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetForAllDocumentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetForAllDocumentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetForDateRange">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/GetForDateRange" style="document" />
      <wsdl:input name="GetForDateRangeRequest">
        <soap:header message="tns:GetForDateRangeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetForDateRangeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetForDateRangeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetForDateRangeResponse">
        <soap:header message="tns:GetForDateRangeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetForDateRangeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetForDateRangeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetForDateRangeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetForSelection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/GetForSelection" style="document" />
      <wsdl:input name="GetForSelectionRequest">
        <soap:header message="tns:GetForSelectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetForSelectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetForSelectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetForSelectionResponse">
        <soap:header message="tns:GetForSelectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetForSelectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetForSelectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetForSelectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="MigrateDocumentToNewDocPlugin">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/MigrateDocumentToNewDocPlugin" style="document" />
      <wsdl:input name="MigrateDocumentToNewDocPluginRequest">
        <soap:header message="tns:MigrateDocumentToNewDocPluginRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MigrateDocumentToNewDocPluginRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MigrateDocumentToNewDocPluginRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MigrateDocumentToNewDocPluginResponse">
        <soap:header message="tns:MigrateDocumentToNewDocPluginResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MigrateDocumentToNewDocPluginResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MigrateDocumentToNewDocPluginResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MigrateDocumentToNewDocPluginResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="HasDocumentsToMigrate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/HasDocumentsToMigrate" style="document" />
      <wsdl:input name="HasDocumentsToMigrateRequest">
        <soap:header message="tns:HasDocumentsToMigrateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:HasDocumentsToMigrateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:HasDocumentsToMigrateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="HasDocumentsToMigrateResponse">
        <soap:header message="tns:HasDocumentsToMigrateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:HasDocumentsToMigrateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:HasDocumentsToMigrateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:HasDocumentsToMigrateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNumberOfConfidentialDocuments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/GetNumberOfConfidentialDocuments" style="document" />
      <wsdl:input name="GetNumberOfConfidentialDocumentsRequest">
        <soap:header message="tns:GetNumberOfConfidentialDocumentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNumberOfConfidentialDocumentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNumberOfConfidentialDocumentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNumberOfConfidentialDocumentsResponse">
        <soap:header message="tns:GetNumberOfConfidentialDocumentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNumberOfConfidentialDocumentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNumberOfConfidentialDocumentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNumberOfConfidentialDocumentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetForTemplates">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/GetForTemplates" style="document" />
      <wsdl:input name="GetForTemplatesRequest">
        <soap:header message="tns:GetForTemplatesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetForTemplatesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetForTemplatesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetForTemplatesResponse">
        <soap:header message="tns:GetForTemplatesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetForTemplatesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetForTemplatesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetForTemplatesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="MigrateTemplateToNewDocPlugin">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/DocumentMigration/MigrateTemplateToNewDocPlugin" style="document" />
      <wsdl:input name="MigrateTemplateToNewDocPluginRequest">
        <soap:header message="tns:MigrateTemplateToNewDocPluginRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MigrateTemplateToNewDocPluginRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MigrateTemplateToNewDocPluginRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MigrateTemplateToNewDocPluginResponse">
        <soap:header message="tns:MigrateTemplateToNewDocPluginResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MigrateTemplateToNewDocPluginResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MigrateTemplateToNewDocPluginResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MigrateTemplateToNewDocPluginResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfDocumentMigrationService">
    <wsdl:port name="BasicHttpBinding_DocumentMigration" binding="tns:BasicHttpBinding_DocumentMigration">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/DocumentMigration.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

