---
generated: 1
uid: wsdl-Services85-SoPrincipal
title: Services85.SoPrincipalAgent WSDL
---

# Services85.SoPrincipalAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfSoPrincipalService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services85" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services85" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services85" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.datacontract.org/2004/07/System.Security.Cryptography" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:element name="GetSystemInfo">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ApplicationToken" nillable="true" type="xs:string" />
      <xs:element name="GetSystemInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SystemInfo" nillable="true" type="tns:SoSystemInfoCarrier" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SoSystemInfoCarrier">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="License" nillable="true" type="tns:LicenseInfo" />
              <xs:element minOccurs="0" name="WarningEnglish" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="WarningResource" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="BranchName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="BuildLabel" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssemblyVersion" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AccumulatedNextCheckDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="FileVersion" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DaysUntilNetServerExpiry" type="xs:int" />
              <xs:element minOccurs="0" name="BuildType" type="tns:NetServerBuildType" />
              <xs:element minOccurs="0" name="DatabaseVersion" type="xs:int" />
              <xs:element minOccurs="0" name="IsUnicode" type="xs:boolean" />
              <xs:element minOccurs="0" name="CompanyName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CompanyId" type="xs:int" />
              <xs:element minOccurs="0" name="DatabaseType" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DatabaseMinor" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DatabaseName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsOnTravel" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsSatellite" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SoSystemInfoCarrier" nillable="true" type="tns:SoSystemInfoCarrier" />
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
      <xs:simpleType name="NetServerBuildType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Feature" />
          <xs:enumeration value="Stable" />
          <xs:enumeration value="Alpha" />
          <xs:enumeration value="Beta" />
          <xs:enumeration value="ReleaseCandidate" />
          <xs:enumeration value="Release" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="NetServerBuildType" nillable="true" type="tns:NetServerBuildType" />
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
      <xs:complexType name="SoTimeZone">
        <xs:sequence>
          <xs:element minOccurs="0" name="SoTimeZoneId" type="xs:int" />
          <xs:element minOccurs="0" name="SoTimeZoneLocationCode" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoTimeZone" nillable="true" type="tns:SoTimeZone" />
      <xs:element name="TimeZone" nillable="true" type="tns:SoTimeZone" />
      <xs:element name="AuthenticateImplicit">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="AuthenticateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SoPrincipalCarrier" />
            <xs:element minOccurs="0" name="Credentials" nillable="true" type="tns:SoCredentials" />
            <xs:element minOccurs="0" name="AuthenticationSucceeded" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SoPrincipalCarrier">
        <xs:sequence>
          <xs:element minOccurs="0" name="UserType" type="tns:UserType" />
          <xs:element minOccurs="0" name="Associate" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          <xs:element minOccurs="0" name="IsPerson" type="xs:boolean" />
          <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          <xs:element minOccurs="0" name="CountryId" type="xs:int" />
          <xs:element minOccurs="0" name="HomeCountryId" type="xs:int" />
          <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          <xs:element minOccurs="0" name="GroupId" type="xs:int" />
          <xs:element minOccurs="0" name="BusinessId" type="xs:int" />
          <xs:element minOccurs="0" name="CategoryId" type="xs:int" />
          <xs:element minOccurs="0" name="ContactOwner" type="xs:int" />
          <xs:element minOccurs="0" name="RoleId" type="xs:int" />
          <xs:element minOccurs="0" name="RoleName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="RoleDescription" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="RoleType" type="tns:RoleType" />
          <xs:element minOccurs="0" name="Licenses" nillable="true" type="tns:ArrayOfGrantedModuleLicense" />
          <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="EMailAddress" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FunctionRights" nillable="true" type="q2:ArrayOfstring" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="EjUserId" type="xs:int" />
          <xs:element minOccurs="0" name="EjAccessLevel" type="xs:int" />
          <xs:element minOccurs="0" name="EjUserStatus" type="tns:EjUserStatus" />
          <xs:element minOccurs="0" name="ProvidedCredentials" nillable="true" type="tns:ArrayOfProvidedCredential" />
          <xs:element minOccurs="0" name="SecondaryGroups" nillable="true" type="q3:ArrayOfint" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="DatabaseContextIdentifier" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoPrincipalCarrier" nillable="true" type="tns:SoPrincipalCarrier" />
      <xs:simpleType name="RoleType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Employee" />
          <xs:enumeration value="ExternalUser" />
          <xs:enumeration value="Anonymous" />
          <xs:enumeration value="System" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RoleType" nillable="true" type="tns:RoleType" />
      <xs:complexType name="ArrayOfGrantedModuleLicense">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="GrantedModuleLicense" nillable="true" type="tns:GrantedModuleLicense" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfGrantedModuleLicense" nillable="true" type="tns:ArrayOfGrantedModuleLicense" />
      <xs:complexType name="GrantedModuleLicense">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="OwnerId" type="xs:int" />
              <xs:element minOccurs="0" name="OwnerName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OwnerDescription" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ModuleId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Version" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="LicenseType" type="tns:LicenseType" />
              <xs:element minOccurs="0" name="ExtraFlags" type="xs:int" />
              <xs:element minOccurs="0" name="SortOrder" type="xs:int" />
              <xs:element minOccurs="0" name="LicenseNumber" type="xs:int" />
              <xs:element minOccurs="0" name="IsHidden" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsUnrestricted" type="xs:boolean" />
              <xs:element minOccurs="0" name="ExpiryDate" type="xs:dateTime" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="GrantedModuleLicense" nillable="true" type="tns:GrantedModuleLicense" />
      <xs:simpleType name="EjUserStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="StatusNone" />
          <xs:enumeration value="StatusNormal" />
          <xs:enumeration value="StatusNotAvailable" />
          <xs:enumeration value="StatusDeleted" />
          <xs:enumeration value="StatusReadOnly" />
          <xs:enumeration value="StatusSpm" />
          <xs:enumeration value="StatusSystem">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">127</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="EjUserStatus" nillable="true" type="tns:EjUserStatus" />
      <xs:complexType name="ArrayOfProvidedCredential">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ProvidedCredential" nillable="true" type="tns:ProvidedCredential" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfProvidedCredential" nillable="true" type="tns:ArrayOfProvidedCredential" />
      <xs:complexType name="ProvidedCredential">
        <xs:sequence>
          <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="SearchName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="CredentialId" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ProvidedCredential" nillable="true" type="tns:ProvidedCredential" />
      <xs:complexType name="SoCredentials">
        <xs:sequence>
          <xs:element minOccurs="0" name="Ticket" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoCredentials" nillable="true" type="tns:SoCredentials" />
      <xs:element name="AuthenticateUsernamePassword">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Password" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AuthenticateGeneric">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AuthenticationData" nillable="true" type="tns:AuthenticationGenericData" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="AuthenticationGenericData">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="AuthenticationGenericDataKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="xs:string" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="AuthenticationGenericData" nillable="true" type="tns:AuthenticationGenericData" />
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
      <xs:complexType name="ArrayOfint">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="int" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfint" nillable="true" type="tns:ArrayOfint" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="GetSystemInfoRequest">
    <wsdl:part name="parameters" element="tns:GetSystemInfo" />
  </wsdl:message>
  <wsdl:message name="GetSystemInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
  </wsdl:message>
  <wsdl:message name="GetSystemInfoResponse">
    <wsdl:part name="parameters" element="tns:GetSystemInfoResponse" />
  </wsdl:message>
  <wsdl:message name="GetSystemInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AuthenticateImplicitRequest">
    <wsdl:part name="parameters" element="tns:AuthenticateImplicit" />
  </wsdl:message>
  <wsdl:message name="AuthenticateImplicitRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
  </wsdl:message>
  <wsdl:message name="AuthenticateResponse">
    <wsdl:part name="parameters" element="tns:AuthenticateResponse" />
  </wsdl:message>
  <wsdl:message name="AuthenticateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AuthenticateUsernamePasswordRequest">
    <wsdl:part name="parameters" element="tns:AuthenticateUsernamePassword" />
  </wsdl:message>
  <wsdl:message name="AuthenticateUsernamePasswordRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
  </wsdl:message>
  <wsdl:message name="AuthenticateGenericRequest">
    <wsdl:part name="parameters" element="tns:AuthenticateGeneric" />
  </wsdl:message>
  <wsdl:message name="AuthenticateGenericRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
  </wsdl:message>
  <wsdl:portType name="SoPrincipal">
    <wsdl:documentation>
      <summary>Testing interface documentation</summary>
    </wsdl:documentation>
    <wsdl:operation name="GetSystemInfo">
      <wsdl:documentation>
        <summary>Get System information about the currently running NetServer and Database</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/SoPrincipal/GetSystemInfo" name="GetSystemInfoRequest" message="tns:GetSystemInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/SoPrincipal/GetSystemInfoResponse" name="GetSystemInfoResponse" message="tns:GetSystemInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="AuthenticateImplicit">
      <wsdl:documentation>
        <summary>Authenticate using (implicit) Wcf credentials, such as Windows Identity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/SoPrincipal/AuthenticateImplicit" name="AuthenticateImplicitRequest" message="tns:AuthenticateImplicitRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/SoPrincipal/AuthenticateImplicitResponse" name="AuthenticateResponse" message="tns:AuthenticateResponse" />
    </wsdl:operation>
    <wsdl:operation name="AuthenticateUsernamePassword">
      <wsdl:documentation>
        <summary>Authenticate using a SuperOffice user name and password</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/SoPrincipal/AuthenticateUsernamePassword" name="AuthenticateUsernamePasswordRequest" message="tns:AuthenticateUsernamePasswordRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/SoPrincipal/AuthenticateUsernamePasswordResponse" name="AuthenticateResponse" message="tns:AuthenticateResponse" />
    </wsdl:operation>
    <wsdl:operation name="AuthenticateGeneric">
      <wsdl:documentation>
        <summary>Authenticate using a pile of name/value pairs that hopefully an authentication plugin will understand</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/SoPrincipal/AuthenticateGeneric" name="AuthenticateGenericRequest" message="tns:AuthenticateGenericRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services85/SoPrincipal/AuthenticateGenericResponse" name="AuthenticateResponse" message="tns:AuthenticateResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_SoPrincipal" type="tns:SoPrincipal">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="GetSystemInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/SoPrincipal/GetSystemInfo" style="document" />
      <wsdl:input name="GetSystemInfoRequest">
        <soap:header message="tns:GetSystemInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSystemInfoResponse">
        <soap:header message="tns:GetSystemInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSystemInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSystemInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSystemInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AuthenticateImplicit">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/SoPrincipal/AuthenticateImplicit" style="document" />
      <wsdl:input name="AuthenticateImplicitRequest">
        <soap:header message="tns:AuthenticateImplicitRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AuthenticateResponse">
        <soap:header message="tns:AuthenticateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AuthenticateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AuthenticateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AuthenticateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AuthenticateUsernamePassword">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/SoPrincipal/AuthenticateUsernamePassword" style="document" />
      <wsdl:input name="AuthenticateUsernamePasswordRequest">
        <soap:header message="tns:AuthenticateUsernamePasswordRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AuthenticateResponse">
        <soap:header message="tns:AuthenticateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AuthenticateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AuthenticateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AuthenticateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AuthenticateGeneric">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services85/SoPrincipal/AuthenticateGeneric" style="document" />
      <wsdl:input name="AuthenticateGenericRequest">
        <soap:header message="tns:AuthenticateGenericRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AuthenticateResponse">
        <soap:header message="tns:AuthenticateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AuthenticateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AuthenticateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AuthenticateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfSoPrincipalService">
    <wsdl:port name="BasicHttpBinding_SoPrincipal" binding="tns:BasicHttpBinding_SoPrincipal">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services85/SoPrincipal.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

