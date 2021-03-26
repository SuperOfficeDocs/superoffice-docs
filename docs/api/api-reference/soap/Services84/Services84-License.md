---
Generated: 1
TOCExclude: 1
title: Services84.LicenseAgent WSDL
---

# Services84.LicenseAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfLicenseService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services84" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services84" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services84" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.datacontract.org/2004/07/System.Security.Cryptography" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="GetLicenseForAllOwnersFromDB">
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
      <xs:element name="GetLicenseForAllOwnersFromDBResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfExtendedLicenseInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfExtendedLicenseInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ExtendedLicenseInfo" nillable="true" type="tns:ExtendedLicenseInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfExtendedLicenseInfo" nillable="true" type="tns:ArrayOfExtendedLicenseInfo" />
      <xs:complexType name="ExtendedLicenseInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="CanBeActivated" type="xs:boolean" />
          <xs:element minOccurs="0" name="New" nillable="true" type="tns:LicenseInfo" />
          <xs:element minOccurs="0" name="Current" nillable="true" type="tns:LicenseInfo" />
          <xs:element minOccurs="0" name="ExtendedModuleLicenses" nillable="true" type="tns:ArrayOfExtendedModuleLicense" />
          <xs:element minOccurs="0" name="AccumulatedNextCheckDate" type="xs:dateTime" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ExtendedLicenseInfo" nillable="true" type="tns:ExtendedLicenseInfo" />
      <xs:complexType name="LicenseInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="CompanyName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="SerialNr" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="OwnerName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="OwnerDescription" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="NextCheckDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="MaintenanceDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="AdminWarningDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="ExpiryDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="GraceDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="ExtraFlags" type="xs:int" />
          <xs:element minOccurs="0" name="LicenseUrl" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="LicenseVersion" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DeploymentType" type="xs:int" />
          <xs:element minOccurs="0" name="ProductType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ProductDescription" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ModuleLicenses" nillable="true" type="tns:ArrayOfModuleLicense" />
          <xs:element minOccurs="0" name="PublicKey" nillable="true" type="tns:SignedPublicKey" />
          <xs:element minOccurs="0" name="Signature" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="LicenseInfo" nillable="true" type="tns:LicenseInfo" />
      <xs:complexType name="ArrayOfModuleLicense">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ModuleLicense" nillable="true" type="tns:ModuleLicense" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfModuleLicense" nillable="true" type="tns:ArrayOfModuleLicense" />
      <xs:complexType name="ModuleLicense">
        <xs:sequence>
          <xs:element minOccurs="0" name="OwnerName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ModuleName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ModuleDescription" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ModuleTooltip" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ModuleVersion" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="LicenseType" type="tns:LicenseType" />
          <xs:element minOccurs="0" name="Unrestricted" type="xs:boolean" />
          <xs:element minOccurs="0" name="AllowedUserType" type="tns:UserType" />
          <xs:element minOccurs="0" name="NumberOfLicenses" type="xs:int" />
          <xs:element minOccurs="0" name="ExtraFlags" type="xs:int" />
          <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="SortOrder" type="xs:int" />
          <xs:element minOccurs="0" name="IsHidden" type="xs:boolean" />
          <xs:element minOccurs="0" name="PrerequisiteModuleName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Signature" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ModuleLicense" nillable="true" type="tns:ModuleLicense" />
      <xs:simpleType name="LicenseType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="SiteLicense" />
          <xs:enumeration value="SatelliteLicense" />
          <xs:enumeration value="UserLicense" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="LicenseType" nillable="true" type="tns:LicenseType" />
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
      <xs:complexType name="SignedPublicKey">
        <xs:sequence>
          <xs:element minOccurs="0" name="OwnerName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="SignDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="ExpiryDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="Key" type="q1:DSAParameters" xmlns:q1="http://schemas.datacontract.org/2004/07/System.Security.Cryptography" />
          <xs:element minOccurs="0" name="Signature" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SignedPublicKey" nillable="true" type="tns:SignedPublicKey" />
      <xs:complexType name="ArrayOfExtendedModuleLicense">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ExtendedModuleLicense" nillable="true" type="tns:ExtendedModuleLicense" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfExtendedModuleLicense" nillable="true" type="tns:ArrayOfExtendedModuleLicense" />
      <xs:complexType name="ExtendedModuleLicense">
        <xs:sequence>
          <xs:element minOccurs="0" name="New" nillable="true" type="tns:ModuleLicense" />
          <xs:element minOccurs="0" name="Current" nillable="true" type="tns:ModuleLicense" />
          <xs:element minOccurs="0" name="NumberOfLicensesInUse" type="xs:int" />
          <xs:element minOccurs="0" name="NumberOfLicensesFree" type="xs:int" />
          <xs:element minOccurs="0" name="NumberOfLicensesAdded" type="xs:int" />
          <xs:element minOccurs="0" name="NumberOfLicensesNewTotal" type="xs:int" />
          <xs:element minOccurs="0" name="NumberOfLicensesNewFree" type="xs:int" />
          <xs:element minOccurs="0" name="NumberOfLicensesTotal" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ExtendedModuleLicense" nillable="true" type="tns:ExtendedModuleLicense" />
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
      <xs:element name="GetLicenseFromLicenseServer">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OwnerName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLicenseFromLicenseServerResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ExtendedLicenseInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetModuleLicenseHistoryFromLicenseServer">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LicenseInfo" nillable="true" type="tns:ExtendedLicenseInfo" />
            <xs:element minOccurs="0" name="ModuleLicense" nillable="true" type="tns:ExtendedModuleLicense" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetModuleLicenseHistoryFromLicenseServerResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateLicenseInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LicenseInfo" nillable="true" type="tns:ExtendedLicenseInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateLicenseInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:LicenseResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="LicenseResult">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Succeeded" type="xs:boolean" />
              <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="LicenseResult" nillable="true" type="tns:LicenseResult" />
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
      <xs:element name="ActivateLicenseInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NewLicense" nillable="true" type="tns:ExtendedLicenseInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ActivateLicenseInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:LicenseResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLicenseStatusFromLicenseServer">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OwnerName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLicenseStatusFromLicenseServerResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CheckLicenseStatusResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CheckLicenseStatusResult">
        <xs:sequence>
          <xs:element minOccurs="0" name="LicenseStatus" type="tns:LicenseStatus" />
          <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Url" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="CheckLicenseStatusResult" nillable="true" type="tns:CheckLicenseStatusResult" />
      <xs:simpleType name="LicenseStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Ok" />
          <xs:enumeration value="NewLicenseAvailable" />
          <xs:enumeration value="NewCompanyNameAvailable" />
          <xs:enumeration value="NewSerialAvailable" />
          <xs:enumeration value="UseCustomMessage" />
          <xs:enumeration value="UseCustomMessageAndUrl" />
          <xs:enumeration value="ProblemWithLicense">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">100</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="UnknownError">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">5000</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="LicenseStatus" nillable="true" type="tns:LicenseStatus" />
      <xs:element name="GetLicenseFromDB">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OwnerName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLicenseFromDBResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ExtendedLicenseInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeSerialNumber">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NewCompanyName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="NewSerialNumber" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeSerialNumberResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:LicenseResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserLicenses">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserLicensesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfLicenseOwner" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfLicenseOwner">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="LicenseOwner" nillable="true" type="tns:LicenseOwner" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLicenseOwner" nillable="true" type="tns:ArrayOfLicenseOwner" />
      <xs:complexType name="LicenseOwner">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RestrictedModuleLicenses" nillable="true" type="tns:ArrayOfModuleLicenseLink" />
              <xs:element minOccurs="0" name="UnrestrictedModuleLicenses" nillable="true" type="tns:ArrayOfModuleLicenseLink" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="LicenseOwner" nillable="true" type="tns:LicenseOwner" />
      <xs:complexType name="ArrayOfModuleLicenseLink">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ModuleLicenseLink" nillable="true" type="tns:ModuleLicenseLink" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfModuleLicenseLink" nillable="true" type="tns:ArrayOfModuleLicenseLink" />
      <xs:complexType name="ModuleLicenseLink">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Unrestricted" type="xs:boolean" />
              <xs:element minOccurs="0" name="Total" type="xs:int" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CanAssign" type="xs:boolean" />
              <xs:element minOccurs="0" name="Free" type="xs:int" />
              <xs:element minOccurs="0" name="InUse" type="xs:int" />
              <xs:element minOccurs="0" name="Assigned" type="xs:boolean" />
              <xs:element minOccurs="0" name="ModuleLicenseId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PrerequisiteModuleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SortOrder" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ModuleLicenseLink" nillable="true" type="tns:ModuleLicenseLink" />
      <xs:element name="GetSatelliteLicenses">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SatelliteId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSatelliteLicensesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfLicenseOwner" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveLicenseFromDB">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ModuleOwner" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveLicenseFromDBResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:LicenseResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLicenseFromFile">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FileContent" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLicenseFromFileResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ExtendedLicenseInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetShopUrl">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OwnerName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetShopUrlResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserLicensesMDOList">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserLicensesMDOListResponse">
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
      <xs:element name="GetModuleLicenseFromDB">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OwnerName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ModuleName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetModuleLicenseFromDBResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ModuleLicense" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddLicenseFromFile">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FileContent" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddLicenseFromFileResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ExtendedLicenseInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetThirdPartyLicenseAssignments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="ModuleOwner" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetThirdPartyLicenseAssignmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfModuleLicenseLink" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AssignThirdPartyLicenses">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="ModuleOwner" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ModuleLicenseNames" nillable="true" type="q2:ArrayOfstring" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AssignThirdPartyLicensesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfModuleLicenseLink" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UnassignThirdPartyLicenses">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="ModuleOwner" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ModuleLicenseNames" nillable="true" type="q3:ArrayOfstring" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UnassignThirdPartyLicensesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfModuleLicenseLink" />
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
    <xs:schema elementFormDefault="qualified" targetNamespace="http://schemas.datacontract.org/2004/07/System.Security.Cryptography" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:tns="http://schemas.datacontract.org/2004/07/System.Security.Cryptography">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:complexType name="DSAParameters">
        <xs:annotation>
          <xs:appinfo>
            <IsValueType xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsValueType>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element name="Counter" type="xs:int" />
          <xs:element name="G" nillable="true" type="xs:base64Binary" />
          <xs:element name="J" nillable="true" type="xs:base64Binary" />
          <xs:element name="P" nillable="true" type="xs:base64Binary" />
          <xs:element name="Q" nillable="true" type="xs:base64Binary" />
          <xs:element name="Seed" nillable="true" type="xs:base64Binary" />
          <xs:element name="Y" nillable="true" type="xs:base64Binary" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="DSAParameters" nillable="true" type="tns:DSAParameters" />
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
  <wsdl:message name="GetLicenseForAllOwnersFromDBRequest">
    <wsdl:part name="parameters" element="tns:GetLicenseForAllOwnersFromDB" />
  </wsdl:message>
  <wsdl:message name="GetLicenseForAllOwnersFromDBRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLicenseForAllOwnersFromDBResponse">
    <wsdl:part name="parameters" element="tns:GetLicenseForAllOwnersFromDBResponse" />
  </wsdl:message>
  <wsdl:message name="GetLicenseForAllOwnersFromDBResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLicenseFromLicenseServerRequest">
    <wsdl:part name="parameters" element="tns:GetLicenseFromLicenseServer" />
  </wsdl:message>
  <wsdl:message name="GetLicenseFromLicenseServerRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLicenseFromLicenseServerResponse">
    <wsdl:part name="parameters" element="tns:GetLicenseFromLicenseServerResponse" />
  </wsdl:message>
  <wsdl:message name="GetLicenseFromLicenseServerResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetModuleLicenseHistoryFromLicenseServerRequest">
    <wsdl:part name="parameters" element="tns:GetModuleLicenseHistoryFromLicenseServer" />
  </wsdl:message>
  <wsdl:message name="GetModuleLicenseHistoryFromLicenseServerRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetModuleLicenseHistoryFromLicenseServerResponse">
    <wsdl:part name="parameters" element="tns:GetModuleLicenseHistoryFromLicenseServerResponse" />
  </wsdl:message>
  <wsdl:message name="GetModuleLicenseHistoryFromLicenseServerResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateLicenseInfoRequest">
    <wsdl:part name="parameters" element="tns:ValidateLicenseInfo" />
  </wsdl:message>
  <wsdl:message name="ValidateLicenseInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateLicenseInfoResponse">
    <wsdl:part name="parameters" element="tns:ValidateLicenseInfoResponse" />
  </wsdl:message>
  <wsdl:message name="ValidateLicenseInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ActivateLicenseInfoRequest">
    <wsdl:part name="parameters" element="tns:ActivateLicenseInfo" />
  </wsdl:message>
  <wsdl:message name="ActivateLicenseInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ActivateLicenseInfoResponse">
    <wsdl:part name="parameters" element="tns:ActivateLicenseInfoResponse" />
  </wsdl:message>
  <wsdl:message name="ActivateLicenseInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLicenseStatusFromLicenseServerRequest">
    <wsdl:part name="parameters" element="tns:GetLicenseStatusFromLicenseServer" />
  </wsdl:message>
  <wsdl:message name="GetLicenseStatusFromLicenseServerRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLicenseStatusFromLicenseServerResponse">
    <wsdl:part name="parameters" element="tns:GetLicenseStatusFromLicenseServerResponse" />
  </wsdl:message>
  <wsdl:message name="GetLicenseStatusFromLicenseServerResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLicenseFromDBRequest">
    <wsdl:part name="parameters" element="tns:GetLicenseFromDB" />
  </wsdl:message>
  <wsdl:message name="GetLicenseFromDBRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLicenseFromDBResponse">
    <wsdl:part name="parameters" element="tns:GetLicenseFromDBResponse" />
  </wsdl:message>
  <wsdl:message name="GetLicenseFromDBResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeSerialNumberRequest">
    <wsdl:part name="parameters" element="tns:ChangeSerialNumber" />
  </wsdl:message>
  <wsdl:message name="ChangeSerialNumberRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeSerialNumberResponse">
    <wsdl:part name="parameters" element="tns:ChangeSerialNumberResponse" />
  </wsdl:message>
  <wsdl:message name="ChangeSerialNumberResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserLicensesRequest">
    <wsdl:part name="parameters" element="tns:GetUserLicenses" />
  </wsdl:message>
  <wsdl:message name="GetUserLicensesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserLicensesResponse">
    <wsdl:part name="parameters" element="tns:GetUserLicensesResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserLicensesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSatelliteLicensesRequest">
    <wsdl:part name="parameters" element="tns:GetSatelliteLicenses" />
  </wsdl:message>
  <wsdl:message name="GetSatelliteLicensesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSatelliteLicensesResponse">
    <wsdl:part name="parameters" element="tns:GetSatelliteLicensesResponse" />
  </wsdl:message>
  <wsdl:message name="GetSatelliteLicensesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveLicenseFromDBRequest">
    <wsdl:part name="parameters" element="tns:RemoveLicenseFromDB" />
  </wsdl:message>
  <wsdl:message name="RemoveLicenseFromDBRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveLicenseFromDBResponse">
    <wsdl:part name="parameters" element="tns:RemoveLicenseFromDBResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveLicenseFromDBResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLicenseFromFileRequest">
    <wsdl:part name="parameters" element="tns:GetLicenseFromFile" />
  </wsdl:message>
  <wsdl:message name="GetLicenseFromFileRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLicenseFromFileResponse">
    <wsdl:part name="parameters" element="tns:GetLicenseFromFileResponse" />
  </wsdl:message>
  <wsdl:message name="GetLicenseFromFileResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetShopUrlRequest">
    <wsdl:part name="parameters" element="tns:GetShopUrl" />
  </wsdl:message>
  <wsdl:message name="GetShopUrlRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetShopUrlResponse">
    <wsdl:part name="parameters" element="tns:GetShopUrlResponse" />
  </wsdl:message>
  <wsdl:message name="GetShopUrlResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserLicensesMDOListRequest">
    <wsdl:part name="parameters" element="tns:GetUserLicensesMDOList" />
  </wsdl:message>
  <wsdl:message name="GetUserLicensesMDOListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserLicensesMDOListResponse">
    <wsdl:part name="parameters" element="tns:GetUserLicensesMDOListResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserLicensesMDOListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetModuleLicenseFromDBRequest">
    <wsdl:part name="parameters" element="tns:GetModuleLicenseFromDB" />
  </wsdl:message>
  <wsdl:message name="GetModuleLicenseFromDBRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetModuleLicenseFromDBResponse">
    <wsdl:part name="parameters" element="tns:GetModuleLicenseFromDBResponse" />
  </wsdl:message>
  <wsdl:message name="GetModuleLicenseFromDBResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddLicenseFromFileRequest">
    <wsdl:part name="parameters" element="tns:AddLicenseFromFile" />
  </wsdl:message>
  <wsdl:message name="AddLicenseFromFileRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddLicenseFromFileResponse">
    <wsdl:part name="parameters" element="tns:AddLicenseFromFileResponse" />
  </wsdl:message>
  <wsdl:message name="AddLicenseFromFileResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetThirdPartyLicenseAssignmentsRequest">
    <wsdl:part name="parameters" element="tns:GetThirdPartyLicenseAssignments" />
  </wsdl:message>
  <wsdl:message name="GetThirdPartyLicenseAssignmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetThirdPartyLicenseAssignmentsResponse">
    <wsdl:part name="parameters" element="tns:GetThirdPartyLicenseAssignmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetThirdPartyLicenseAssignmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AssignThirdPartyLicensesRequest">
    <wsdl:part name="parameters" element="tns:AssignThirdPartyLicenses" />
  </wsdl:message>
  <wsdl:message name="AssignThirdPartyLicensesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AssignThirdPartyLicensesResponse">
    <wsdl:part name="parameters" element="tns:AssignThirdPartyLicensesResponse" />
  </wsdl:message>
  <wsdl:message name="AssignThirdPartyLicensesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UnassignThirdPartyLicensesRequest">
    <wsdl:part name="parameters" element="tns:UnassignThirdPartyLicenses" />
  </wsdl:message>
  <wsdl:message name="UnassignThirdPartyLicensesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UnassignThirdPartyLicensesResponse">
    <wsdl:part name="parameters" element="tns:UnassignThirdPartyLicensesResponse" />
  </wsdl:message>
  <wsdl:message name="UnassignThirdPartyLicensesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="License">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for License</summary>
    </wsdl:documentation>
    <wsdl:operation name="GetLicenseForAllOwnersFromDB">
      <wsdl:documentation>
        <summary>Get all licenses, with usage, from all module owners as they are stored in the database</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetLicenseForAllOwnersFromDB" name="GetLicenseForAllOwnersFromDBRequest" message="tns:GetLicenseForAllOwnersFromDBRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetLicenseForAllOwnersFromDBResponse" name="GetLicenseForAllOwnersFromDBResponse" message="tns:GetLicenseForAllOwnersFromDBResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLicenseFromLicenseServer">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetLicenseFromLicenseServer" name="GetLicenseFromLicenseServerRequest" message="tns:GetLicenseFromLicenseServerRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetLicenseFromLicenseServerResponse" name="GetLicenseFromLicenseServerResponse" message="tns:GetLicenseFromLicenseServerResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetModuleLicenseHistoryFromLicenseServer">
      <wsdl:documentation>
        <summary>Get details about a license from the license server.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetModuleLicenseHistoryFromLicenseServer" name="GetModuleLicenseHistoryFromLicenseServerRequest" message="tns:GetModuleLicenseHistoryFromLicenseServerRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetModuleLicenseHistoryFromLicenseServerResponse" name="GetModuleLicenseHistoryFromLicenseServerResponse" message="tns:GetModuleLicenseHistoryFromLicenseServerResponse" />
    </wsdl:operation>
    <wsdl:operation name="ValidateLicenseInfo">
      <wsdl:documentation>
        <summary>Validate that a license is consistant.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/ValidateLicenseInfo" name="ValidateLicenseInfoRequest" message="tns:ValidateLicenseInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/ValidateLicenseInfoResponse" name="ValidateLicenseInfoResponse" message="tns:ValidateLicenseInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="ActivateLicenseInfo">
      <wsdl:documentation>
        <summary>Save a new license to the database.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/ActivateLicenseInfo" name="ActivateLicenseInfoRequest" message="tns:ActivateLicenseInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/ActivateLicenseInfoResponse" name="ActivateLicenseInfoResponse" message="tns:ActivateLicenseInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLicenseStatusFromLicenseServer">
      <wsdl:documentation>
        <summary>Get License from the license server for a particular module owner.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetLicenseStatusFromLicenseServer" name="GetLicenseStatusFromLicenseServerRequest" message="tns:GetLicenseStatusFromLicenseServerRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetLicenseStatusFromLicenseServerResponse" name="GetLicenseStatusFromLicenseServerResponse" message="tns:GetLicenseStatusFromLicenseServerResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLicenseFromDB">
      <wsdl:documentation>
        <summary>Get license, with usage, as it is stored in the database for one particular module owner.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetLicenseFromDB" name="GetLicenseFromDBRequest" message="tns:GetLicenseFromDBRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetLicenseFromDBResponse" name="GetLicenseFromDBResponse" message="tns:GetLicenseFromDBResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChangeSerialNumber">
      <wsdl:documentation>
        <summary>Change the new serial number for the installation. Requests a new license from SuperLicense, checks if change is authorized.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/ChangeSerialNumber" name="ChangeSerialNumberRequest" message="tns:ChangeSerialNumberRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/ChangeSerialNumberResponse" name="ChangeSerialNumberResponse" message="tns:ChangeSerialNumberResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserLicenses">
      <wsdl:documentation>
        <summary>Obtain information about associate module licenses</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetUserLicenses" name="GetUserLicensesRequest" message="tns:GetUserLicensesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetUserLicensesResponse" name="GetUserLicensesResponse" message="tns:GetUserLicensesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSatelliteLicenses">
      <wsdl:documentation>
        <summary>Obtain information about satellite module licenses</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetSatelliteLicenses" name="GetSatelliteLicensesRequest" message="tns:GetSatelliteLicensesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetSatelliteLicensesResponse" name="GetSatelliteLicensesResponse" message="tns:GetSatelliteLicensesResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveLicenseFromDB">
      <wsdl:documentation>
        <summary>Remove the license from a particular module owner from the database.  It is not permitted to remove licenses from SuperOffice</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/RemoveLicenseFromDB" name="RemoveLicenseFromDBRequest" message="tns:RemoveLicenseFromDBRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/RemoveLicenseFromDBResponse" name="RemoveLicenseFromDBResponse" message="tns:RemoveLicenseFromDBResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLicenseFromFile">
      <wsdl:documentation>
        <summary>Load a new license from file</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetLicenseFromFile" name="GetLicenseFromFileRequest" message="tns:GetLicenseFromFileRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetLicenseFromFileResponse" name="GetLicenseFromFileResponse" message="tns:GetLicenseFromFileResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetShopUrl">
      <wsdl:documentation>
        <summary>Get the shop URL for the specified module owner. This can be used to redirect user to the web shop.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetShopUrl" name="GetShopUrlRequest" message="tns:GetShopUrlRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetShopUrlResponse" name="GetShopUrlResponse" message="tns:GetShopUrlResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserLicensesMDOList">
      <wsdl:documentation>
        <summary>Get all licenses in a MDOListItem structure.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetUserLicensesMDOList" name="GetUserLicensesMDOListRequest" message="tns:GetUserLicensesMDOListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetUserLicensesMDOListResponse" name="GetUserLicensesMDOListResponse" message="tns:GetUserLicensesMDOListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetModuleLicenseFromDB">
      <wsdl:documentation>
        <summary>Get license information for one particular license module.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetModuleLicenseFromDB" name="GetModuleLicenseFromDBRequest" message="tns:GetModuleLicenseFromDBRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetModuleLicenseFromDBResponse" name="GetModuleLicenseFromDBResponse" message="tns:GetModuleLicenseFromDBResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddLicenseFromFile">
      <wsdl:documentation>
        <summary>Load and activate a new license from file/string if the new license is valid.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/AddLicenseFromFile" name="AddLicenseFromFileRequest" message="tns:AddLicenseFromFileRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/AddLicenseFromFileResponse" name="AddLicenseFromFileResponse" message="tns:AddLicenseFromFileResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetThirdPartyLicenseAssignments">
      <wsdl:documentation>
        <summary>Get license assignments for an associate for licenses belonging to an other module owner than SuperOffice</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetThirdPartyLicenseAssignments" name="GetThirdPartyLicenseAssignmentsRequest" message="tns:GetThirdPartyLicenseAssignmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetThirdPartyLicenseAssignmentsResponse" name="GetThirdPartyLicenseAssignmentsResponse" message="tns:GetThirdPartyLicenseAssignmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="AssignThirdPartyLicenses">
      <wsdl:documentation>
        <summary>Assign third party licenses</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/AssignThirdPartyLicenses" name="AssignThirdPartyLicensesRequest" message="tns:AssignThirdPartyLicensesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/AssignThirdPartyLicensesResponse" name="AssignThirdPartyLicensesResponse" message="tns:AssignThirdPartyLicensesResponse" />
    </wsdl:operation>
    <wsdl:operation name="UnassignThirdPartyLicenses">
      <wsdl:documentation>
        <summary>Unassign (remove) third party licenses</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/UnassignThirdPartyLicenses" name="UnassignThirdPartyLicensesRequest" message="tns:UnassignThirdPartyLicensesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services84/License/UnassignThirdPartyLicensesResponse" name="UnassignThirdPartyLicensesResponse" message="tns:UnassignThirdPartyLicensesResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_License" type="tns:License">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="GetLicenseForAllOwnersFromDB">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetLicenseForAllOwnersFromDB" style="document" />
      <wsdl:input name="GetLicenseForAllOwnersFromDBRequest">
        <soap:header message="tns:GetLicenseForAllOwnersFromDBRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLicenseForAllOwnersFromDBRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLicenseForAllOwnersFromDBRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLicenseForAllOwnersFromDBResponse">
        <soap:header message="tns:GetLicenseForAllOwnersFromDBResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLicenseForAllOwnersFromDBResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLicenseForAllOwnersFromDBResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLicenseForAllOwnersFromDBResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLicenseFromLicenseServer">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetLicenseFromLicenseServer" style="document" />
      <wsdl:input name="GetLicenseFromLicenseServerRequest">
        <soap:header message="tns:GetLicenseFromLicenseServerRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLicenseFromLicenseServerRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLicenseFromLicenseServerRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLicenseFromLicenseServerResponse">
        <soap:header message="tns:GetLicenseFromLicenseServerResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLicenseFromLicenseServerResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLicenseFromLicenseServerResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLicenseFromLicenseServerResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetModuleLicenseHistoryFromLicenseServer">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetModuleLicenseHistoryFromLicenseServer" style="document" />
      <wsdl:input name="GetModuleLicenseHistoryFromLicenseServerRequest">
        <soap:header message="tns:GetModuleLicenseHistoryFromLicenseServerRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetModuleLicenseHistoryFromLicenseServerRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetModuleLicenseHistoryFromLicenseServerRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetModuleLicenseHistoryFromLicenseServerResponse">
        <soap:header message="tns:GetModuleLicenseHistoryFromLicenseServerResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetModuleLicenseHistoryFromLicenseServerResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetModuleLicenseHistoryFromLicenseServerResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetModuleLicenseHistoryFromLicenseServerResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ValidateLicenseInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/ValidateLicenseInfo" style="document" />
      <wsdl:input name="ValidateLicenseInfoRequest">
        <soap:header message="tns:ValidateLicenseInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ValidateLicenseInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ValidateLicenseInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ValidateLicenseInfoResponse">
        <soap:header message="tns:ValidateLicenseInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ValidateLicenseInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ValidateLicenseInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ValidateLicenseInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ActivateLicenseInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/ActivateLicenseInfo" style="document" />
      <wsdl:input name="ActivateLicenseInfoRequest">
        <soap:header message="tns:ActivateLicenseInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ActivateLicenseInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ActivateLicenseInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ActivateLicenseInfoResponse">
        <soap:header message="tns:ActivateLicenseInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ActivateLicenseInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ActivateLicenseInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ActivateLicenseInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLicenseStatusFromLicenseServer">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetLicenseStatusFromLicenseServer" style="document" />
      <wsdl:input name="GetLicenseStatusFromLicenseServerRequest">
        <soap:header message="tns:GetLicenseStatusFromLicenseServerRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLicenseStatusFromLicenseServerRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLicenseStatusFromLicenseServerRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLicenseStatusFromLicenseServerResponse">
        <soap:header message="tns:GetLicenseStatusFromLicenseServerResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLicenseStatusFromLicenseServerResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLicenseStatusFromLicenseServerResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLicenseStatusFromLicenseServerResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLicenseFromDB">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetLicenseFromDB" style="document" />
      <wsdl:input name="GetLicenseFromDBRequest">
        <soap:header message="tns:GetLicenseFromDBRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLicenseFromDBRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLicenseFromDBRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLicenseFromDBResponse">
        <soap:header message="tns:GetLicenseFromDBResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLicenseFromDBResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLicenseFromDBResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLicenseFromDBResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChangeSerialNumber">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/ChangeSerialNumber" style="document" />
      <wsdl:input name="ChangeSerialNumberRequest">
        <soap:header message="tns:ChangeSerialNumberRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChangeSerialNumberRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChangeSerialNumberRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChangeSerialNumberResponse">
        <soap:header message="tns:ChangeSerialNumberResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChangeSerialNumberResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChangeSerialNumberResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChangeSerialNumberResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserLicenses">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetUserLicenses" style="document" />
      <wsdl:input name="GetUserLicensesRequest">
        <soap:header message="tns:GetUserLicensesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserLicensesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserLicensesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserLicensesResponse">
        <soap:header message="tns:GetUserLicensesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserLicensesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserLicensesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserLicensesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSatelliteLicenses">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetSatelliteLicenses" style="document" />
      <wsdl:input name="GetSatelliteLicensesRequest">
        <soap:header message="tns:GetSatelliteLicensesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSatelliteLicensesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSatelliteLicensesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSatelliteLicensesResponse">
        <soap:header message="tns:GetSatelliteLicensesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSatelliteLicensesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSatelliteLicensesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSatelliteLicensesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveLicenseFromDB">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/RemoveLicenseFromDB" style="document" />
      <wsdl:input name="RemoveLicenseFromDBRequest">
        <soap:header message="tns:RemoveLicenseFromDBRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveLicenseFromDBRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveLicenseFromDBRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveLicenseFromDBResponse">
        <soap:header message="tns:RemoveLicenseFromDBResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveLicenseFromDBResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveLicenseFromDBResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveLicenseFromDBResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLicenseFromFile">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetLicenseFromFile" style="document" />
      <wsdl:input name="GetLicenseFromFileRequest">
        <soap:header message="tns:GetLicenseFromFileRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLicenseFromFileRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLicenseFromFileRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLicenseFromFileResponse">
        <soap:header message="tns:GetLicenseFromFileResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLicenseFromFileResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLicenseFromFileResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLicenseFromFileResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetShopUrl">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetShopUrl" style="document" />
      <wsdl:input name="GetShopUrlRequest">
        <soap:header message="tns:GetShopUrlRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetShopUrlRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetShopUrlRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetShopUrlResponse">
        <soap:header message="tns:GetShopUrlResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetShopUrlResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetShopUrlResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetShopUrlResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserLicensesMDOList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetUserLicensesMDOList" style="document" />
      <wsdl:input name="GetUserLicensesMDOListRequest">
        <soap:header message="tns:GetUserLicensesMDOListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserLicensesMDOListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserLicensesMDOListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserLicensesMDOListResponse">
        <soap:header message="tns:GetUserLicensesMDOListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserLicensesMDOListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserLicensesMDOListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserLicensesMDOListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetModuleLicenseFromDB">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetModuleLicenseFromDB" style="document" />
      <wsdl:input name="GetModuleLicenseFromDBRequest">
        <soap:header message="tns:GetModuleLicenseFromDBRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetModuleLicenseFromDBRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetModuleLicenseFromDBRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetModuleLicenseFromDBResponse">
        <soap:header message="tns:GetModuleLicenseFromDBResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetModuleLicenseFromDBResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetModuleLicenseFromDBResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetModuleLicenseFromDBResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddLicenseFromFile">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/AddLicenseFromFile" style="document" />
      <wsdl:input name="AddLicenseFromFileRequest">
        <soap:header message="tns:AddLicenseFromFileRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddLicenseFromFileRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddLicenseFromFileRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddLicenseFromFileResponse">
        <soap:header message="tns:AddLicenseFromFileResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddLicenseFromFileResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddLicenseFromFileResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddLicenseFromFileResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetThirdPartyLicenseAssignments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/GetThirdPartyLicenseAssignments" style="document" />
      <wsdl:input name="GetThirdPartyLicenseAssignmentsRequest">
        <soap:header message="tns:GetThirdPartyLicenseAssignmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetThirdPartyLicenseAssignmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetThirdPartyLicenseAssignmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetThirdPartyLicenseAssignmentsResponse">
        <soap:header message="tns:GetThirdPartyLicenseAssignmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetThirdPartyLicenseAssignmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetThirdPartyLicenseAssignmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetThirdPartyLicenseAssignmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AssignThirdPartyLicenses">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/AssignThirdPartyLicenses" style="document" />
      <wsdl:input name="AssignThirdPartyLicensesRequest">
        <soap:header message="tns:AssignThirdPartyLicensesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AssignThirdPartyLicensesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AssignThirdPartyLicensesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AssignThirdPartyLicensesResponse">
        <soap:header message="tns:AssignThirdPartyLicensesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AssignThirdPartyLicensesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AssignThirdPartyLicensesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AssignThirdPartyLicensesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UnassignThirdPartyLicenses">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services84/License/UnassignThirdPartyLicenses" style="document" />
      <wsdl:input name="UnassignThirdPartyLicensesRequest">
        <soap:header message="tns:UnassignThirdPartyLicensesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UnassignThirdPartyLicensesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UnassignThirdPartyLicensesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UnassignThirdPartyLicensesResponse">
        <soap:header message="tns:UnassignThirdPartyLicensesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UnassignThirdPartyLicensesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UnassignThirdPartyLicensesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UnassignThirdPartyLicensesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfLicenseService">
    <wsdl:port name="BasicHttpBinding_License" binding="tns:BasicHttpBinding_License">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services84/License.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

