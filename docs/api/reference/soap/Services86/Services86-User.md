---
generated: 1
uid: wsdl-Services86-User
title: Services86.UserAgent WSDL
---

# Services86.UserAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfUserService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services86" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services86" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services86" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultServiceAuth">
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
      <xs:element name="CreateDefaultServiceAuthResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ServiceAuth" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ServiceAuth">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ServiceAuthId" type="xs:int" />
              <xs:element minOccurs="0" name="Server" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Port" type="xs:int" />
              <xs:element minOccurs="0" name="AuthType" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Username" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Password" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ServiceAuth" nillable="true" type="tns:ServiceAuth" />
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
      <xs:element name="SaveServiceAuth">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ServiceAuth" nillable="true" type="tns:ServiceAuth" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveServiceAuthResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ServiceAuth" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteServiceAuth">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ServiceAuthId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteServiceAuthResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultRoleEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultRoleEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:RoleEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="RoleEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="RoleId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RoleType" type="tns:RoleType" />
              <xs:element minOccurs="0" name="Deleted" type="xs:short" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Created" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UseCategories" type="xs:short" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="DataRights" nillable="true" type="tns:DataRights" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="RoleEntity" nillable="true" type="tns:RoleEntity" />
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
              <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
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
      <xs:complexType name="DataRights">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ColumnsInfo" nillable="true" type="tns:ArrayOfRelationToOwner" />
              <xs:element minOccurs="0" name="RowsInfo" nillable="true" type="tns:ArrayOfEntityName" />
              <xs:element minOccurs="0" name="Rights" nillable="true" type="tns:ArrayOfArrayOfDataRight" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DataRights" nillable="true" type="tns:DataRights" />
      <xs:complexType name="ArrayOfRelationToOwner">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="RelationToOwner" nillable="true" type="tns:RelationToOwner" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfRelationToOwner" nillable="true" type="tns:ArrayOfRelationToOwner" />
      <xs:complexType name="RelationToOwner">
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
      <xs:element name="RelationToOwner" nillable="true" type="tns:RelationToOwner" />
      <xs:complexType name="ArrayOfEntityName">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="EntityName" nillable="true" type="tns:EntityName" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfEntityName" nillable="true" type="tns:ArrayOfEntityName" />
      <xs:complexType name="EntityName">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TableDescription" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EntityName" nillable="true" type="tns:EntityName" />
      <xs:complexType name="ArrayOfArrayOfDataRight">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArrayOfDataRight" nillable="true" type="tns:ArrayOfDataRight" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArrayOfDataRight" nillable="true" type="tns:ArrayOfArrayOfDataRight" />
      <xs:complexType name="ArrayOfDataRight">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DataRight" nillable="true" type="tns:DataRight" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDataRight" nillable="true" type="tns:ArrayOfDataRight" />
      <xs:complexType name="DataRight">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DataRight" nillable="true" type="tns:DataRight" />
      <xs:element name="SaveRoleEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RoleEntity" nillable="true" type="tns:RoleEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveRoleEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:RoleEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultUntrustedCredentials">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultUntrustedCredentialsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:UntrustedCredentials" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="UntrustedCredentials">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ValidFrom" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ValidTo" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Comment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SecretValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PublicValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="UntrustedCredentials" nillable="true" type="tns:UntrustedCredentials" />
      <xs:element name="CreateDefaultUser">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultUserResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:User" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="User">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="LicenseOwners" nillable="true" type="tns:ArrayOfLicenseOwner" />
              <xs:element minOccurs="0" name="Role" nillable="true" type="tns:Role" />
              <xs:element minOccurs="0" name="UserGroup" nillable="true" type="tns:UserGroup" />
              <xs:element minOccurs="0" name="OtherGroups" nillable="true" type="tns:ArrayOfUserGroup" />
              <xs:element minOccurs="0" name="Person" nillable="true" type="tns:Person" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="Lastlogin" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Lastlogout" type="xs:dateTime" />
              <xs:element minOccurs="0" name="EjUserId" type="xs:int" />
              <xs:element minOccurs="0" name="Type" type="tns:UserType" />
              <xs:element minOccurs="0" name="IsPersonRetired" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsOnTravel" type="xs:boolean" />
              <xs:element minOccurs="0" name="Credentials" nillable="true" type="tns:ArrayOfCredential" />
              <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PostSaveCommands" nillable="true" type="tns:ArrayOfCustomCommand" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="User" nillable="true" type="tns:User" />
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
      <xs:complexType name="Role">
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
      <xs:element name="Role" nillable="true" type="tns:Role" />
      <xs:complexType name="UserGroup">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Deleted" type="xs:short" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="UserGroup" nillable="true" type="tns:UserGroup" />
      <xs:complexType name="ArrayOfUserGroup">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="UserGroup" nillable="true" type="tns:UserGroup" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfUserGroup" nillable="true" type="tns:ArrayOfUserGroup" />
      <xs:complexType name="Person">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Position" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Mrmrs" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Firstname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Lastname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MiddleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Email" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DirectPhone" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CountryId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Retired" type="xs:short" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="ActiveInterests" type="xs:short" />
              <xs:element minOccurs="0" name="ContactDepartment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactCountryId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactOrgNr" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FaxPhone" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MobilePhone" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactPhone" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="UsePersonAddress" type="xs:boolean" />
              <xs:element minOccurs="0" name="ContactFax" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Kanafname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Kanalname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Post1" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Post2" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Post3" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EmailName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="TicketPriorityId" type="xs:int" />
              <xs:element minOccurs="0" name="SupportLanguageId" type="xs:int" />
              <xs:element minOccurs="0" name="SupportAssociateId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Person" nillable="true" type="tns:Person" />
      <xs:complexType name="ArrayOfCredential">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Credential" nillable="true" type="tns:Credential" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCredential" nillable="true" type="tns:ArrayOfCredential" />
      <xs:complexType name="Credential">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Type" nillable="true" type="tns:CredentialType" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Credential" nillable="true" type="tns:Credential" />
      <xs:complexType name="CredentialType">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="DisplayType" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ValueControl" type="tns:CredentialControlType" />
              <xs:element minOccurs="0" name="CanCreatePerson" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsUserNameSupported" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CredentialType" nillable="true" type="tns:CredentialType" />
      <xs:simpleType name="CredentialControlType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Static" />
          <xs:enumeration value="Edit" />
          <xs:enumeration value="Password" />
          <xs:enumeration value="Link" />
          <xs:enumeration value="Hidden" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="CredentialControlType" nillable="true" type="tns:CredentialControlType" />
      <xs:complexType name="ArrayOfCustomCommand">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="CustomCommand" nillable="true" type="tns:CustomCommand" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCustomCommand" nillable="true" type="tns:ArrayOfCustomCommand" />
      <xs:complexType name="CustomCommand">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ToolTip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Actions" type="tns:CommandAction" />
              <xs:element minOccurs="0" name="ActionData" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CustomCommand" nillable="true" type="tns:CustomCommand" />
      <xs:simpleType name="CommandAction">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Implicit" />
          <xs:enumeration value="YesNo" />
          <xs:enumeration value="OkCancel" />
          <xs:enumeration value="Ok" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="CommandAction" nillable="true" type="tns:CommandAction" />
      <xs:element name="SaveUser">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="User" nillable="true" type="tns:User" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveUserResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:User" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserCommands">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="User" nillable="true" type="tns:User" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserCommandsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCustomCommand" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExecuteUserCommand">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CommandName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="CommandActionResult" type="tns:CommandActionResult" />
            <xs:element minOccurs="0" name="User" nillable="true" type="tns:User" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="CommandActionResult">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Implicit" />
          <xs:enumeration value="Yes" />
          <xs:enumeration value="Ok" />
          <xs:enumeration value="No" />
          <xs:enumeration value="Cancel" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="CommandActionResult" nillable="true" type="tns:CommandActionResult" />
      <xs:element name="ExecuteUserCommandResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CommandResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CommandResult">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Success" type="xs:boolean" />
              <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Result" type="tns:CommandActionResult" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CommandResult" nillable="true" type="tns:CommandResult" />
      <xs:element name="DeleteUser">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteUserResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCredential">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserId" type="xs:int" />
            <xs:element minOccurs="0" name="Credential" nillable="true" type="tns:Credential" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCredentialResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteCredential">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserId" type="xs:int" />
            <xs:element minOccurs="0" name="CredentialType" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteCredentialResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindCredentialsGroups">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="SearchString" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindCredentialsGroupsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCredentialsGroup" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfCredentialsGroup">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="CredentialsGroup" nillable="true" type="tns:CredentialsGroup" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCredentialsGroup" nillable="true" type="tns:ArrayOfCredentialsGroup" />
      <xs:complexType name="CredentialsGroup">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CredentialsGroup" nillable="true" type="tns:CredentialsGroup" />
      <xs:element name="FindCredentialUsers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="SearchString" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindCredentialUsersResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CredentialsGroupUsers" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CredentialsGroupUsers">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Headings" nillable="true" type="q1:ArrayOfstring" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="Users" nillable="true" type="tns:ArrayOfCredentialUser" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CredentialsGroupUsers" nillable="true" type="tns:CredentialsGroupUsers" />
      <xs:complexType name="ArrayOfCredentialUser">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="CredentialUser" nillable="true" type="tns:CredentialUser" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCredentialUser" nillable="true" type="tns:ArrayOfCredentialUser" />
      <xs:complexType name="CredentialUser">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Columns" nillable="true" type="q2:ArrayOfstring" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="CanCreatePerson" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CredentialUser" nillable="true" type="tns:CredentialUser" />
      <xs:element name="GetCredentialUsersInGroup">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="GroupName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCredentialUsersInGroupResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CredentialsGroupUsers" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetServiceAuth">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ServiceAuthId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetServiceAuthResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ServiceAuth" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRole">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RoleId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRoleResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Role" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRoleEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RoleEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRoleEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:RoleEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteRole">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RoleIdToDelete" type="xs:int" />
            <xs:element minOccurs="0" name="ReplacingRoleId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteRoleResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllRoles">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RoleType" type="tns:RoleType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllRolesResponse">
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
      <xs:element name="GetAllFunctionalRights">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RoleType" type="tns:RoleType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllFunctionalRightsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFunctionalRights">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RoleId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFunctionalRightsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetFunctionalRights">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RoleId" type="xs:int" />
            <xs:element minOccurs="0" name="FunctionalRightIds" nillable="true" type="q3:ArrayOfint" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetFunctionalRightsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDataRight">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RoleId" type="xs:int" />
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="RelationToOwner" type="tns:RoleRelationToOwner" />
            <xs:element minOccurs="0" name="DataRightValue" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="RoleRelationToOwner">
        <xs:restriction base="xs:string">
          <xs:enumeration value="MyOwn" />
          <xs:enumeration value="PrimaryGroup" />
          <xs:enumeration value="OtherGroups" />
          <xs:enumeration value="OtherAssociates" />
          <xs:enumeration value="ExternalUser" />
          <xs:enumeration value="Anonymous" />
          <xs:enumeration value="MyCompany" />
          <xs:enumeration value="SameProject" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RoleRelationToOwner" nillable="true" type="tns:RoleRelationToOwner" />
      <xs:element name="SetDataRightResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDataRight">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RoleId" type="xs:int" />
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="RelationToOwner" type="tns:RoleRelationToOwner" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDataRightResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDataRights">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RoleId" type="xs:int" />
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDataRightsResponse">
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
      <xs:element name="CreateDefaultRoleEntityFromType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Type" type="tns:RoleType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultRoleEntityFromTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:RoleEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindRolesWithFunctionalRight">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FunctionalRightName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindRolesWithFunctionalRightResponse">
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
      <xs:element name="FindRolesWithFunctionalRights">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FunctionalRightNames" nillable="true" type="q4:ArrayOfstring" xmlns:q4="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindRolesWithFunctionalRightsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q5:ArrayOfint" xmlns:q5="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindRolesWithoutFunctionalRights">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FunctionalRightNames" nillable="true" type="q6:ArrayOfstring" xmlns:q6="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindRolesWithoutFunctionalRightsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q7:ArrayOfint" xmlns:q7="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUser">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:User" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserFromName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserFromNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:User" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveUserFromName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="User" nillable="true" type="tns:User" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveUserFromNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:User" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteUserFromName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteUserFromNameResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCredentialTypes">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCredentialTypesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCredentialType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfCredentialType">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="CredentialType" nillable="true" type="tns:CredentialType" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCredentialType" nillable="true" type="tns:ArrayOfCredentialType" />
      <xs:element name="GetCredentialTypesForUserType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserType" type="tns:UserType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCredentialTypesForUserTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCredentialType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveUntrustedCredentials">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Credentials" nillable="true" type="tns:UntrustedCredentials" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveUntrustedCredentialsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUntrustedCredentials">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUntrustedCredentialsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfUntrustedCredentials" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfUntrustedCredentials">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="UntrustedCredentials" nillable="true" type="tns:UntrustedCredentials" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfUntrustedCredentials" nillable="true" type="tns:ArrayOfUntrustedCredentials" />
      <xs:element name="GetUntrustedCredentialsForAssociate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUntrustedCredentialsForAssociateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfUntrustedCredentials" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveUntrustedCredentialsForAssociate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Credentials" nillable="true" type="tns:UntrustedCredentials" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveUntrustedCredentialsForAssociateResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveUntrustedCredentials">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PublicValue" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveUntrustedCredentialsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveUntrustedCredentialsForAssociate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PublicValue" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveUntrustedCredentialsForAssociateResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateExternalUser">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Password" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="RoleId" type="xs:int" />
            <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateExternalUserResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteExternalUser">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteExternalUserResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetExternalUserInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Password" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
            <xs:element minOccurs="0" name="RoleId" type="xs:int" />
            <xs:element minOccurs="0" name="ExternalUserInfoModification" type="tns:ExternalUserInfoModification" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="ExternalUserInfoModification">
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="UserName" />
              <xs:enumeration value="Password" />
              <xs:enumeration value="Role" />
              <xs:enumeration value="Active" />
              <xs:enumeration value="UndefinedValue16" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="ExternalUserInfoModification" nillable="true" type="tns:ExternalUserInfoModification" />
      <xs:element name="SetExternalUserInfoResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GenerateNewPasswordForExternalUser">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GenerateNewPasswordForExternalUserResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CanChangePassword">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CanChangePasswordResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangePassword">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="OldPassword" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="NewPassword" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangePasswordResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserFromPersonId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserFromPersonIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfUser" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfUser">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="User" nillable="true" type="tns:User" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfUser" nillable="true" type="tns:ArrayOfUser" />
      <xs:element name="CreateDefaultUserFromUserTypeAndPersonId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserType" type="tns:UserType" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultUserFromUserTypeAndPersonIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:User" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultUserFromUserType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserType" type="tns:UserType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultUserFromUserTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:User" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserFromEjUserId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EjUserId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserFromEjUserIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfUser" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetPasswordFromName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Password" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetPasswordFromNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetPassword">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="Password" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetPasswordResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeOwnPassword">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OldPassword" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="NewPassword" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeOwnPasswordResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangePasswordFromName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="OldPassword" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="NewPassword" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangePasswordFromNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="IsUserNameValid">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="Type" type="tns:UserType" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="IsUserNameValidResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="IsPasswordValid">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="Type" type="tns:UserType" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="Password" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="IsPasswordValidResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetGeneratedPassword">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetGeneratedPasswordResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetGeneratedPasswordFromName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetGeneratedPasswordFromNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="IsPasswordValidWithReason">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="Type" type="tns:UserType" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="Password" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="IsPasswordValidWithReasonResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:UserValidationResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="UserValidationResult">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Result" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="UserValidationResult" nillable="true" type="tns:UserValidationResult" />
      <xs:element name="IsUserNameValidWithReason">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="Type" type="tns:UserType" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="IsUserNameValidWithReasonResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:UserValidationResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeUserType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="User" nillable="true" type="tns:User" />
            <xs:element minOccurs="0" name="UserType" type="tns:UserType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeUserTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:User" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultUserFromUserTypeAndCredential">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserType" type="tns:UserType" />
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="CredentialType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="CredentialValue" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="CredentialDisplayValue" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultUserFromUserTypeAndCredentialResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:User" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetValidUserName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="Type" type="tns:UserType" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetValidUserNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveLicenses">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveLicensesResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="MakeRetired">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="Retired" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MakeRetiredResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="AddOwnerContact">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddOwnerContactResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveOwnerContact">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveOwnerContactResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ResolveUserFromInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="PersonName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PhoneNumbers" nillable="true" type="q8:ArrayOfstring" xmlns:q8="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Emails" nillable="true" type="q9:ArrayOfstring" xmlns:q9="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="UserType" type="tns:UserType" />
            <xs:element minOccurs="0" name="Credential" nillable="true" type="tns:Credential" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ResolveUserFromInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ResolvedUser" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ResolvedUser">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="User" nillable="true" type="tns:User" />
              <xs:element minOccurs="0" name="PersonCreated" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ResolvedUser" nillable="true" type="tns:ResolvedUser" />
      <xs:element name="GetUserGroup">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserGroupId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserGroupResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:UserGroup" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveUserGroup">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserGroup" nillable="true" type="tns:UserGroup" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveUserGroupResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:UserGroup" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllUserGroups">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="IncludeDeleted" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllUserGroupsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfUserGroup" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateUserGroup">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateUserGroupResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:UserGroup" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteUserGroup">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserGroupToDelete" type="xs:int" />
            <xs:element minOccurs="0" name="UserGroupToMoveTo" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteUserGroupResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserGroupList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserGroupIds" nillable="true" type="q10:ArrayOfint" xmlns:q10="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserGroupListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfUserGroup" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserInfoId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:UserInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="UserInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="UserInfoId" type="xs:int" />
              <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserGroupId" type="xs:int" />
              <xs:element minOccurs="0" name="EjUserId" type="xs:int" />
              <xs:element minOccurs="0" name="UserType" type="tns:UserType" />
              <xs:element minOccurs="0" name="GrantedLicenses" nillable="true" type="q11:ArrayOfstring" xmlns:q11="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="CanLogon" type="xs:boolean" />
              <xs:element minOccurs="0" name="RoleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RoleTooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserGroupName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserGroupTooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="UserInfo" nillable="true" type="tns:UserInfo" />
      <xs:element name="GetUserInfoList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserInfoIds" nillable="true" type="q12:ArrayOfint" xmlns:q12="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserInfoListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfUserInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfUserInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="UserInfo" nillable="true" type="tns:UserInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfUserInfo" nillable="true" type="tns:ArrayOfUserInfo" />
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
      <xs:complexType name="ArrayOfint">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="int" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfint" nillable="true" type="tns:ArrayOfint" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="CreateDefaultServiceAuthRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultServiceAuth" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultServiceAuthRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultServiceAuthResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultServiceAuthResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultServiceAuthResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveServiceAuthRequest">
    <wsdl:part name="parameters" element="tns:SaveServiceAuth" />
  </wsdl:message>
  <wsdl:message name="SaveServiceAuthRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveServiceAuthResponse">
    <wsdl:part name="parameters" element="tns:SaveServiceAuthResponse" />
  </wsdl:message>
  <wsdl:message name="SaveServiceAuthResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteServiceAuthRequest">
    <wsdl:part name="parameters" element="tns:DeleteServiceAuth" />
  </wsdl:message>
  <wsdl:message name="DeleteServiceAuthRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteServiceAuthResponse">
    <wsdl:part name="parameters" element="tns:DeleteServiceAuthResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteServiceAuthResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRoleEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultRoleEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRoleEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRoleEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultRoleEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRoleEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRoleEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveRoleEntity" />
  </wsdl:message>
  <wsdl:message name="SaveRoleEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRoleEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveRoleEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveRoleEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUntrustedCredentialsRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultUntrustedCredentials" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUntrustedCredentialsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUntrustedCredentialsResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultUntrustedCredentialsResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUntrustedCredentialsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultUser" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultUserResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveUserRequest">
    <wsdl:part name="parameters" element="tns:SaveUser" />
  </wsdl:message>
  <wsdl:message name="SaveUserRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveUserResponse">
    <wsdl:part name="parameters" element="tns:SaveUserResponse" />
  </wsdl:message>
  <wsdl:message name="SaveUserResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserCommandsRequest">
    <wsdl:part name="parameters" element="tns:GetUserCommands" />
  </wsdl:message>
  <wsdl:message name="GetUserCommandsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserCommandsResponse">
    <wsdl:part name="parameters" element="tns:GetUserCommandsResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserCommandsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExecuteUserCommandRequest">
    <wsdl:part name="parameters" element="tns:ExecuteUserCommand" />
  </wsdl:message>
  <wsdl:message name="ExecuteUserCommandRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExecuteUserCommandResponse">
    <wsdl:part name="parameters" element="tns:ExecuteUserCommandResponse" />
  </wsdl:message>
  <wsdl:message name="ExecuteUserCommandResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteUserRequest">
    <wsdl:part name="parameters" element="tns:DeleteUser" />
  </wsdl:message>
  <wsdl:message name="DeleteUserRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteUserResponse">
    <wsdl:part name="parameters" element="tns:DeleteUserResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteUserResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCredentialRequest">
    <wsdl:part name="parameters" element="tns:SaveCredential" />
  </wsdl:message>
  <wsdl:message name="SaveCredentialRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCredentialResponse">
    <wsdl:part name="parameters" element="tns:SaveCredentialResponse" />
  </wsdl:message>
  <wsdl:message name="SaveCredentialResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteCredentialRequest">
    <wsdl:part name="parameters" element="tns:DeleteCredential" />
  </wsdl:message>
  <wsdl:message name="DeleteCredentialRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteCredentialResponse">
    <wsdl:part name="parameters" element="tns:DeleteCredentialResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteCredentialResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindCredentialsGroupsRequest">
    <wsdl:part name="parameters" element="tns:FindCredentialsGroups" />
  </wsdl:message>
  <wsdl:message name="FindCredentialsGroupsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindCredentialsGroupsResponse">
    <wsdl:part name="parameters" element="tns:FindCredentialsGroupsResponse" />
  </wsdl:message>
  <wsdl:message name="FindCredentialsGroupsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindCredentialUsersRequest">
    <wsdl:part name="parameters" element="tns:FindCredentialUsers" />
  </wsdl:message>
  <wsdl:message name="FindCredentialUsersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindCredentialUsersResponse">
    <wsdl:part name="parameters" element="tns:FindCredentialUsersResponse" />
  </wsdl:message>
  <wsdl:message name="FindCredentialUsersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCredentialUsersInGroupRequest">
    <wsdl:part name="parameters" element="tns:GetCredentialUsersInGroup" />
  </wsdl:message>
  <wsdl:message name="GetCredentialUsersInGroupRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCredentialUsersInGroupResponse">
    <wsdl:part name="parameters" element="tns:GetCredentialUsersInGroupResponse" />
  </wsdl:message>
  <wsdl:message name="GetCredentialUsersInGroupResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetServiceAuthRequest">
    <wsdl:part name="parameters" element="tns:GetServiceAuth" />
  </wsdl:message>
  <wsdl:message name="GetServiceAuthRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetServiceAuthResponse">
    <wsdl:part name="parameters" element="tns:GetServiceAuthResponse" />
  </wsdl:message>
  <wsdl:message name="GetServiceAuthResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRoleRequest">
    <wsdl:part name="parameters" element="tns:GetRole" />
  </wsdl:message>
  <wsdl:message name="GetRoleRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRoleResponse">
    <wsdl:part name="parameters" element="tns:GetRoleResponse" />
  </wsdl:message>
  <wsdl:message name="GetRoleResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRoleEntityRequest">
    <wsdl:part name="parameters" element="tns:GetRoleEntity" />
  </wsdl:message>
  <wsdl:message name="GetRoleEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRoleEntityResponse">
    <wsdl:part name="parameters" element="tns:GetRoleEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetRoleEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteRoleRequest">
    <wsdl:part name="parameters" element="tns:DeleteRole" />
  </wsdl:message>
  <wsdl:message name="DeleteRoleRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteRoleResponse">
    <wsdl:part name="parameters" element="tns:DeleteRoleResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteRoleResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllRolesRequest">
    <wsdl:part name="parameters" element="tns:GetAllRoles" />
  </wsdl:message>
  <wsdl:message name="GetAllRolesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllRolesResponse">
    <wsdl:part name="parameters" element="tns:GetAllRolesResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllRolesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllFunctionalRightsRequest">
    <wsdl:part name="parameters" element="tns:GetAllFunctionalRights" />
  </wsdl:message>
  <wsdl:message name="GetAllFunctionalRightsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllFunctionalRightsResponse">
    <wsdl:part name="parameters" element="tns:GetAllFunctionalRightsResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllFunctionalRightsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFunctionalRightsRequest">
    <wsdl:part name="parameters" element="tns:GetFunctionalRights" />
  </wsdl:message>
  <wsdl:message name="GetFunctionalRightsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFunctionalRightsResponse">
    <wsdl:part name="parameters" element="tns:GetFunctionalRightsResponse" />
  </wsdl:message>
  <wsdl:message name="GetFunctionalRightsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetFunctionalRightsRequest">
    <wsdl:part name="parameters" element="tns:SetFunctionalRights" />
  </wsdl:message>
  <wsdl:message name="SetFunctionalRightsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetFunctionalRightsResponse">
    <wsdl:part name="parameters" element="tns:SetFunctionalRightsResponse" />
  </wsdl:message>
  <wsdl:message name="SetFunctionalRightsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDataRightRequest">
    <wsdl:part name="parameters" element="tns:SetDataRight" />
  </wsdl:message>
  <wsdl:message name="SetDataRightRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDataRightResponse">
    <wsdl:part name="parameters" element="tns:SetDataRightResponse" />
  </wsdl:message>
  <wsdl:message name="SetDataRightResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDataRightRequest">
    <wsdl:part name="parameters" element="tns:GetDataRight" />
  </wsdl:message>
  <wsdl:message name="GetDataRightRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDataRightResponse">
    <wsdl:part name="parameters" element="tns:GetDataRightResponse" />
  </wsdl:message>
  <wsdl:message name="GetDataRightResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDataRightsRequest">
    <wsdl:part name="parameters" element="tns:GetDataRights" />
  </wsdl:message>
  <wsdl:message name="GetDataRightsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDataRightsResponse">
    <wsdl:part name="parameters" element="tns:GetDataRightsResponse" />
  </wsdl:message>
  <wsdl:message name="GetDataRightsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRoleEntityFromTypeRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultRoleEntityFromType" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRoleEntityFromTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRoleEntityFromTypeResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultRoleEntityFromTypeResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRoleEntityFromTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindRolesWithFunctionalRightRequest">
    <wsdl:part name="parameters" element="tns:FindRolesWithFunctionalRight" />
  </wsdl:message>
  <wsdl:message name="FindRolesWithFunctionalRightRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindRolesWithFunctionalRightResponse">
    <wsdl:part name="parameters" element="tns:FindRolesWithFunctionalRightResponse" />
  </wsdl:message>
  <wsdl:message name="FindRolesWithFunctionalRightResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindRolesWithFunctionalRightsRequest">
    <wsdl:part name="parameters" element="tns:FindRolesWithFunctionalRights" />
  </wsdl:message>
  <wsdl:message name="FindRolesWithFunctionalRightsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindRolesWithFunctionalRightsResponse">
    <wsdl:part name="parameters" element="tns:FindRolesWithFunctionalRightsResponse" />
  </wsdl:message>
  <wsdl:message name="FindRolesWithFunctionalRightsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindRolesWithoutFunctionalRightsRequest">
    <wsdl:part name="parameters" element="tns:FindRolesWithoutFunctionalRights" />
  </wsdl:message>
  <wsdl:message name="FindRolesWithoutFunctionalRightsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindRolesWithoutFunctionalRightsResponse">
    <wsdl:part name="parameters" element="tns:FindRolesWithoutFunctionalRightsResponse" />
  </wsdl:message>
  <wsdl:message name="FindRolesWithoutFunctionalRightsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserRequest">
    <wsdl:part name="parameters" element="tns:GetUser" />
  </wsdl:message>
  <wsdl:message name="GetUserRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserResponse">
    <wsdl:part name="parameters" element="tns:GetUserResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserFromNameRequest">
    <wsdl:part name="parameters" element="tns:GetUserFromName" />
  </wsdl:message>
  <wsdl:message name="GetUserFromNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserFromNameResponse">
    <wsdl:part name="parameters" element="tns:GetUserFromNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserFromNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveUserFromNameRequest">
    <wsdl:part name="parameters" element="tns:SaveUserFromName" />
  </wsdl:message>
  <wsdl:message name="SaveUserFromNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveUserFromNameResponse">
    <wsdl:part name="parameters" element="tns:SaveUserFromNameResponse" />
  </wsdl:message>
  <wsdl:message name="SaveUserFromNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteUserFromNameRequest">
    <wsdl:part name="parameters" element="tns:DeleteUserFromName" />
  </wsdl:message>
  <wsdl:message name="DeleteUserFromNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteUserFromNameResponse">
    <wsdl:part name="parameters" element="tns:DeleteUserFromNameResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteUserFromNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCredentialTypesRequest">
    <wsdl:part name="parameters" element="tns:GetCredentialTypes" />
  </wsdl:message>
  <wsdl:message name="GetCredentialTypesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCredentialTypesResponse">
    <wsdl:part name="parameters" element="tns:GetCredentialTypesResponse" />
  </wsdl:message>
  <wsdl:message name="GetCredentialTypesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCredentialTypesForUserTypeRequest">
    <wsdl:part name="parameters" element="tns:GetCredentialTypesForUserType" />
  </wsdl:message>
  <wsdl:message name="GetCredentialTypesForUserTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCredentialTypesForUserTypeResponse">
    <wsdl:part name="parameters" element="tns:GetCredentialTypesForUserTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetCredentialTypesForUserTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveUntrustedCredentialsRequest">
    <wsdl:part name="parameters" element="tns:SaveUntrustedCredentials" />
  </wsdl:message>
  <wsdl:message name="SaveUntrustedCredentialsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveUntrustedCredentialsResponse">
    <wsdl:part name="parameters" element="tns:SaveUntrustedCredentialsResponse" />
  </wsdl:message>
  <wsdl:message name="SaveUntrustedCredentialsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUntrustedCredentialsRequest">
    <wsdl:part name="parameters" element="tns:GetUntrustedCredentials" />
  </wsdl:message>
  <wsdl:message name="GetUntrustedCredentialsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUntrustedCredentialsResponse">
    <wsdl:part name="parameters" element="tns:GetUntrustedCredentialsResponse" />
  </wsdl:message>
  <wsdl:message name="GetUntrustedCredentialsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUntrustedCredentialsForAssociateRequest">
    <wsdl:part name="parameters" element="tns:GetUntrustedCredentialsForAssociate" />
  </wsdl:message>
  <wsdl:message name="GetUntrustedCredentialsForAssociateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUntrustedCredentialsForAssociateResponse">
    <wsdl:part name="parameters" element="tns:GetUntrustedCredentialsForAssociateResponse" />
  </wsdl:message>
  <wsdl:message name="GetUntrustedCredentialsForAssociateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveUntrustedCredentialsForAssociateRequest">
    <wsdl:part name="parameters" element="tns:SaveUntrustedCredentialsForAssociate" />
  </wsdl:message>
  <wsdl:message name="SaveUntrustedCredentialsForAssociateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveUntrustedCredentialsForAssociateResponse">
    <wsdl:part name="parameters" element="tns:SaveUntrustedCredentialsForAssociateResponse" />
  </wsdl:message>
  <wsdl:message name="SaveUntrustedCredentialsForAssociateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveUntrustedCredentialsRequest">
    <wsdl:part name="parameters" element="tns:RemoveUntrustedCredentials" />
  </wsdl:message>
  <wsdl:message name="RemoveUntrustedCredentialsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveUntrustedCredentialsResponse">
    <wsdl:part name="parameters" element="tns:RemoveUntrustedCredentialsResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveUntrustedCredentialsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveUntrustedCredentialsForAssociateRequest">
    <wsdl:part name="parameters" element="tns:RemoveUntrustedCredentialsForAssociate" />
  </wsdl:message>
  <wsdl:message name="RemoveUntrustedCredentialsForAssociateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveUntrustedCredentialsForAssociateResponse">
    <wsdl:part name="parameters" element="tns:RemoveUntrustedCredentialsForAssociateResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveUntrustedCredentialsForAssociateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateExternalUserRequest">
    <wsdl:part name="parameters" element="tns:CreateExternalUser" />
  </wsdl:message>
  <wsdl:message name="CreateExternalUserRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateExternalUserResponse">
    <wsdl:part name="parameters" element="tns:CreateExternalUserResponse" />
  </wsdl:message>
  <wsdl:message name="CreateExternalUserResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteExternalUserRequest">
    <wsdl:part name="parameters" element="tns:DeleteExternalUser" />
  </wsdl:message>
  <wsdl:message name="DeleteExternalUserRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteExternalUserResponse">
    <wsdl:part name="parameters" element="tns:DeleteExternalUserResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteExternalUserResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetExternalUserInfoRequest">
    <wsdl:part name="parameters" element="tns:SetExternalUserInfo" />
  </wsdl:message>
  <wsdl:message name="SetExternalUserInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetExternalUserInfoResponse">
    <wsdl:part name="parameters" element="tns:SetExternalUserInfoResponse" />
  </wsdl:message>
  <wsdl:message name="SetExternalUserInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GenerateNewPasswordForExternalUserRequest">
    <wsdl:part name="parameters" element="tns:GenerateNewPasswordForExternalUser" />
  </wsdl:message>
  <wsdl:message name="GenerateNewPasswordForExternalUserRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GenerateNewPasswordForExternalUserResponse">
    <wsdl:part name="parameters" element="tns:GenerateNewPasswordForExternalUserResponse" />
  </wsdl:message>
  <wsdl:message name="GenerateNewPasswordForExternalUserResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CanChangePasswordRequest">
    <wsdl:part name="parameters" element="tns:CanChangePassword" />
  </wsdl:message>
  <wsdl:message name="CanChangePasswordRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CanChangePasswordResponse">
    <wsdl:part name="parameters" element="tns:CanChangePasswordResponse" />
  </wsdl:message>
  <wsdl:message name="CanChangePasswordResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangePasswordRequest">
    <wsdl:part name="parameters" element="tns:ChangePassword" />
  </wsdl:message>
  <wsdl:message name="ChangePasswordRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangePasswordResponse">
    <wsdl:part name="parameters" element="tns:ChangePasswordResponse" />
  </wsdl:message>
  <wsdl:message name="ChangePasswordResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserFromPersonIdRequest">
    <wsdl:part name="parameters" element="tns:GetUserFromPersonId" />
  </wsdl:message>
  <wsdl:message name="GetUserFromPersonIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserFromPersonIdResponse">
    <wsdl:part name="parameters" element="tns:GetUserFromPersonIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserFromPersonIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserFromUserTypeAndPersonIdRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultUserFromUserTypeAndPersonId" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserFromUserTypeAndPersonIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserFromUserTypeAndPersonIdResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultUserFromUserTypeAndPersonIdResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserFromUserTypeAndPersonIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserFromUserTypeRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultUserFromUserType" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserFromUserTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserFromUserTypeResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultUserFromUserTypeResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserFromUserTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserFromEjUserIdRequest">
    <wsdl:part name="parameters" element="tns:GetUserFromEjUserId" />
  </wsdl:message>
  <wsdl:message name="GetUserFromEjUserIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserFromEjUserIdResponse">
    <wsdl:part name="parameters" element="tns:GetUserFromEjUserIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserFromEjUserIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetPasswordFromNameRequest">
    <wsdl:part name="parameters" element="tns:SetPasswordFromName" />
  </wsdl:message>
  <wsdl:message name="SetPasswordFromNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetPasswordFromNameResponse">
    <wsdl:part name="parameters" element="tns:SetPasswordFromNameResponse" />
  </wsdl:message>
  <wsdl:message name="SetPasswordFromNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetPasswordRequest">
    <wsdl:part name="parameters" element="tns:SetPassword" />
  </wsdl:message>
  <wsdl:message name="SetPasswordRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetPasswordResponse">
    <wsdl:part name="parameters" element="tns:SetPasswordResponse" />
  </wsdl:message>
  <wsdl:message name="SetPasswordResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeOwnPasswordRequest">
    <wsdl:part name="parameters" element="tns:ChangeOwnPassword" />
  </wsdl:message>
  <wsdl:message name="ChangeOwnPasswordRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeOwnPasswordResponse">
    <wsdl:part name="parameters" element="tns:ChangeOwnPasswordResponse" />
  </wsdl:message>
  <wsdl:message name="ChangeOwnPasswordResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangePasswordFromNameRequest">
    <wsdl:part name="parameters" element="tns:ChangePasswordFromName" />
  </wsdl:message>
  <wsdl:message name="ChangePasswordFromNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangePasswordFromNameResponse">
    <wsdl:part name="parameters" element="tns:ChangePasswordFromNameResponse" />
  </wsdl:message>
  <wsdl:message name="ChangePasswordFromNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsUserNameValidRequest">
    <wsdl:part name="parameters" element="tns:IsUserNameValid" />
  </wsdl:message>
  <wsdl:message name="IsUserNameValidRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsUserNameValidResponse">
    <wsdl:part name="parameters" element="tns:IsUserNameValidResponse" />
  </wsdl:message>
  <wsdl:message name="IsUserNameValidResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsPasswordValidRequest">
    <wsdl:part name="parameters" element="tns:IsPasswordValid" />
  </wsdl:message>
  <wsdl:message name="IsPasswordValidRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsPasswordValidResponse">
    <wsdl:part name="parameters" element="tns:IsPasswordValidResponse" />
  </wsdl:message>
  <wsdl:message name="IsPasswordValidResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetGeneratedPasswordRequest">
    <wsdl:part name="parameters" element="tns:SetGeneratedPassword" />
  </wsdl:message>
  <wsdl:message name="SetGeneratedPasswordRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetGeneratedPasswordResponse">
    <wsdl:part name="parameters" element="tns:SetGeneratedPasswordResponse" />
  </wsdl:message>
  <wsdl:message name="SetGeneratedPasswordResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetGeneratedPasswordFromNameRequest">
    <wsdl:part name="parameters" element="tns:SetGeneratedPasswordFromName" />
  </wsdl:message>
  <wsdl:message name="SetGeneratedPasswordFromNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetGeneratedPasswordFromNameResponse">
    <wsdl:part name="parameters" element="tns:SetGeneratedPasswordFromNameResponse" />
  </wsdl:message>
  <wsdl:message name="SetGeneratedPasswordFromNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsPasswordValidWithReasonRequest">
    <wsdl:part name="parameters" element="tns:IsPasswordValidWithReason" />
  </wsdl:message>
  <wsdl:message name="IsPasswordValidWithReasonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsPasswordValidWithReasonResponse">
    <wsdl:part name="parameters" element="tns:IsPasswordValidWithReasonResponse" />
  </wsdl:message>
  <wsdl:message name="IsPasswordValidWithReasonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsUserNameValidWithReasonRequest">
    <wsdl:part name="parameters" element="tns:IsUserNameValidWithReason" />
  </wsdl:message>
  <wsdl:message name="IsUserNameValidWithReasonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsUserNameValidWithReasonResponse">
    <wsdl:part name="parameters" element="tns:IsUserNameValidWithReasonResponse" />
  </wsdl:message>
  <wsdl:message name="IsUserNameValidWithReasonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeUserTypeRequest">
    <wsdl:part name="parameters" element="tns:ChangeUserType" />
  </wsdl:message>
  <wsdl:message name="ChangeUserTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeUserTypeResponse">
    <wsdl:part name="parameters" element="tns:ChangeUserTypeResponse" />
  </wsdl:message>
  <wsdl:message name="ChangeUserTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserFromUserTypeAndCredentialRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultUserFromUserTypeAndCredential" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserFromUserTypeAndCredentialRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserFromUserTypeAndCredentialResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultUserFromUserTypeAndCredentialResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserFromUserTypeAndCredentialResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetValidUserNameRequest">
    <wsdl:part name="parameters" element="tns:GetValidUserName" />
  </wsdl:message>
  <wsdl:message name="GetValidUserNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetValidUserNameResponse">
    <wsdl:part name="parameters" element="tns:GetValidUserNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetValidUserNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveLicensesRequest">
    <wsdl:part name="parameters" element="tns:RemoveLicenses" />
  </wsdl:message>
  <wsdl:message name="RemoveLicensesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveLicensesResponse">
    <wsdl:part name="parameters" element="tns:RemoveLicensesResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveLicensesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MakeRetiredRequest">
    <wsdl:part name="parameters" element="tns:MakeRetired" />
  </wsdl:message>
  <wsdl:message name="MakeRetiredRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MakeRetiredResponse">
    <wsdl:part name="parameters" element="tns:MakeRetiredResponse" />
  </wsdl:message>
  <wsdl:message name="MakeRetiredResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddOwnerContactRequest">
    <wsdl:part name="parameters" element="tns:AddOwnerContact" />
  </wsdl:message>
  <wsdl:message name="AddOwnerContactRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddOwnerContactResponse">
    <wsdl:part name="parameters" element="tns:AddOwnerContactResponse" />
  </wsdl:message>
  <wsdl:message name="AddOwnerContactResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveOwnerContactRequest">
    <wsdl:part name="parameters" element="tns:RemoveOwnerContact" />
  </wsdl:message>
  <wsdl:message name="RemoveOwnerContactRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveOwnerContactResponse">
    <wsdl:part name="parameters" element="tns:RemoveOwnerContactResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveOwnerContactResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ResolveUserFromInfoRequest">
    <wsdl:part name="parameters" element="tns:ResolveUserFromInfo" />
  </wsdl:message>
  <wsdl:message name="ResolveUserFromInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ResolveUserFromInfoResponse">
    <wsdl:part name="parameters" element="tns:ResolveUserFromInfoResponse" />
  </wsdl:message>
  <wsdl:message name="ResolveUserFromInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserGroupRequest">
    <wsdl:part name="parameters" element="tns:GetUserGroup" />
  </wsdl:message>
  <wsdl:message name="GetUserGroupRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserGroupResponse">
    <wsdl:part name="parameters" element="tns:GetUserGroupResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserGroupResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveUserGroupRequest">
    <wsdl:part name="parameters" element="tns:SaveUserGroup" />
  </wsdl:message>
  <wsdl:message name="SaveUserGroupRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveUserGroupResponse">
    <wsdl:part name="parameters" element="tns:SaveUserGroupResponse" />
  </wsdl:message>
  <wsdl:message name="SaveUserGroupResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllUserGroupsRequest">
    <wsdl:part name="parameters" element="tns:GetAllUserGroups" />
  </wsdl:message>
  <wsdl:message name="GetAllUserGroupsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllUserGroupsResponse">
    <wsdl:part name="parameters" element="tns:GetAllUserGroupsResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllUserGroupsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateUserGroupRequest">
    <wsdl:part name="parameters" element="tns:CreateUserGroup" />
  </wsdl:message>
  <wsdl:message name="CreateUserGroupRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateUserGroupResponse">
    <wsdl:part name="parameters" element="tns:CreateUserGroupResponse" />
  </wsdl:message>
  <wsdl:message name="CreateUserGroupResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteUserGroupRequest">
    <wsdl:part name="parameters" element="tns:DeleteUserGroup" />
  </wsdl:message>
  <wsdl:message name="DeleteUserGroupRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteUserGroupResponse">
    <wsdl:part name="parameters" element="tns:DeleteUserGroupResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteUserGroupResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserGroupListRequest">
    <wsdl:part name="parameters" element="tns:GetUserGroupList" />
  </wsdl:message>
  <wsdl:message name="GetUserGroupListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserGroupListResponse">
    <wsdl:part name="parameters" element="tns:GetUserGroupListResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserGroupListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserInfoRequest">
    <wsdl:part name="parameters" element="tns:GetUserInfo" />
  </wsdl:message>
  <wsdl:message name="GetUserInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserInfoResponse">
    <wsdl:part name="parameters" element="tns:GetUserInfoResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserInfoListRequest">
    <wsdl:part name="parameters" element="tns:GetUserInfoList" />
  </wsdl:message>
  <wsdl:message name="GetUserInfoListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserInfoListResponse">
    <wsdl:part name="parameters" element="tns:GetUserInfoListResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserInfoListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="User">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for User</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultServiceAuth">
      <wsdl:documentation>
        <summary>Loading default values into a new ServiceAuth.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultServiceAuth" name="CreateDefaultServiceAuthRequest" message="tns:CreateDefaultServiceAuthRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultServiceAuthResponse" name="CreateDefaultServiceAuthResponse" message="tns:CreateDefaultServiceAuthResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveServiceAuth">
      <wsdl:documentation>
        <summary>Updates the existing ServiceAuth or creates a new ServiceAuth if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveServiceAuth" name="SaveServiceAuthRequest" message="tns:SaveServiceAuthRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveServiceAuthResponse" name="SaveServiceAuthResponse" message="tns:SaveServiceAuthResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteServiceAuth">
      <wsdl:documentation>
        <summary>Deletes the ServiceAuth</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteServiceAuth" name="DeleteServiceAuthRequest" message="tns:DeleteServiceAuthRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteServiceAuthResponse" name="DeleteServiceAuthResponse" message="tns:DeleteServiceAuthResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultRoleEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new RoleEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultRoleEntity" name="CreateDefaultRoleEntityRequest" message="tns:CreateDefaultRoleEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultRoleEntityResponse" name="CreateDefaultRoleEntityResponse" message="tns:CreateDefaultRoleEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveRoleEntity">
      <wsdl:documentation>
        <summary>Updates the existing RoleEntity or creates a new RoleEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveRoleEntity" name="SaveRoleEntityRequest" message="tns:SaveRoleEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveRoleEntityResponse" name="SaveRoleEntityResponse" message="tns:SaveRoleEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultUntrustedCredentials">
      <wsdl:documentation>
        <summary>Loading default values into a new UntrustedCredentials.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultUntrustedCredentials" name="CreateDefaultUntrustedCredentialsRequest" message="tns:CreateDefaultUntrustedCredentialsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultUntrustedCredentialsResponse" name="CreateDefaultUntrustedCredentialsResponse" message="tns:CreateDefaultUntrustedCredentialsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultUser">
      <wsdl:documentation>
        <summary>Loading default values into a new User.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultUser" name="CreateDefaultUserRequest" message="tns:CreateDefaultUserRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultUserResponse" name="CreateDefaultUserResponse" message="tns:CreateDefaultUserResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveUser">
      <wsdl:documentation>
        <summary>Updates the existing User or creates a new User if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveUser" name="SaveUserRequest" message="tns:SaveUserRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveUserResponse" name="SaveUserResponse" message="tns:SaveUserResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserCommands">
      <wsdl:documentation>
        <summary>Get registered custom commands for User</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserCommands" name="GetUserCommandsRequest" message="tns:GetUserCommandsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserCommandsResponse" name="GetUserCommandsResponse" message="tns:GetUserCommandsResponse" />
    </wsdl:operation>
    <wsdl:operation name="ExecuteUserCommand">
      <wsdl:documentation>
        <summary>Executes the custom command for User</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/ExecuteUserCommand" name="ExecuteUserCommandRequest" message="tns:ExecuteUserCommandRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/ExecuteUserCommandResponse" name="ExecuteUserCommandResponse" message="tns:ExecuteUserCommandResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteUser">
      <wsdl:documentation>
        <summary>Deletes the User</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteUser" name="DeleteUserRequest" message="tns:DeleteUserRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteUserResponse" name="DeleteUserResponse" message="tns:DeleteUserResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveCredential">
      <wsdl:documentation>
        <summary>Save (adds/replaces) current credential of the same type for the user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveCredential" name="SaveCredentialRequest" message="tns:SaveCredentialRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveCredentialResponse" name="SaveCredentialResponse" message="tns:SaveCredentialResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteCredential">
      <wsdl:documentation>
        <summary>Remove credential of a specific type for a user</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteCredential" name="DeleteCredentialRequest" message="tns:DeleteCredentialRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteCredentialResponse" name="DeleteCredentialResponse" message="tns:DeleteCredentialResponse" />
    </wsdl:operation>
    <wsdl:operation name="FindCredentialsGroups">
      <wsdl:documentation>
        <summary>Get user groups holding users filtered by the searchString.  This method is only relevant if the CredentialType control is of type link.  There will allways be at least one groups even if the underlying provider does not support groups.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/FindCredentialsGroups" name="FindCredentialsGroupsRequest" message="tns:FindCredentialsGroupsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/FindCredentialsGroupsResponse" name="FindCredentialsGroupsResponse" message="tns:FindCredentialsGroupsResponse" />
    </wsdl:operation>
    <wsdl:operation name="FindCredentialUsers">
      <wsdl:documentation>
        <summary>Find users matching the partial name.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/FindCredentialUsers" name="FindCredentialUsersRequest" message="tns:FindCredentialUsersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/FindCredentialUsersResponse" name="FindCredentialUsersResponse" message="tns:FindCredentialUsersResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCredentialUsersInGroup">
      <wsdl:documentation>
        <summary>Get credential users within a user group</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetCredentialUsersInGroup" name="GetCredentialUsersInGroupRequest" message="tns:GetCredentialUsersInGroupRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetCredentialUsersInGroupResponse" name="GetCredentialUsersInGroupResponse" message="tns:GetCredentialUsersInGroupResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetServiceAuth">
      <wsdl:documentation>
        <summary>Gets a ServiceAuth object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetServiceAuth" name="GetServiceAuthRequest" message="tns:GetServiceAuthRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetServiceAuthResponse" name="GetServiceAuthResponse" message="tns:GetServiceAuthResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetRole">
      <wsdl:documentation>
        <summary>Gets a Role object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetRole" name="GetRoleRequest" message="tns:GetRoleRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetRoleResponse" name="GetRoleResponse" message="tns:GetRoleResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetRoleEntity">
      <wsdl:documentation>
        <summary>Gets a RoleEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetRoleEntity" name="GetRoleEntityRequest" message="tns:GetRoleEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetRoleEntityResponse" name="GetRoleEntityResponse" message="tns:GetRoleEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteRole">
      <wsdl:documentation>
        <summary>Delete the specified role and move all users associated with the role to the replacingRoleId</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteRole" name="DeleteRoleRequest" message="tns:DeleteRoleRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteRoleResponse" name="DeleteRoleResponse" message="tns:DeleteRoleResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllRoles">
      <wsdl:documentation>
        <summary>Get a list of all roles for the given type of role. MDO List name = 'Roles', extra='0' (roleType) </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetAllRoles" name="GetAllRolesRequest" message="tns:GetAllRolesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetAllRolesResponse" name="GetAllRolesResponse" message="tns:GetAllRolesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllFunctionalRights">
      <wsdl:documentation>
        <summary>Get a list of all functional rights for the given type of role. MDO List name = 'FunctionRights', extra='roleType=0' </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetAllFunctionalRights" name="GetAllFunctionalRightsRequest" message="tns:GetAllFunctionalRightsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetAllFunctionalRightsResponse" name="GetAllFunctionalRightsResponse" message="tns:GetAllFunctionalRightsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFunctionalRights">
      <wsdl:documentation>
        <summary>Get all functional rights for the given role. Functional rights not set on the role are not included. MDO List name = 'FunctionRights', extra='role=123'</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetFunctionalRights" name="GetFunctionalRightsRequest" message="tns:GetFunctionalRightsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetFunctionalRightsResponse" name="GetFunctionalRightsResponse" message="tns:GetFunctionalRightsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetFunctionalRights">
      <wsdl:documentation>
        <summary>Set all functional rights for the given role. Functional rights not specified here will be removed from the role. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetFunctionalRights" name="SetFunctionalRightsRequest" message="tns:SetFunctionalRightsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetFunctionalRightsResponse" name="SetFunctionalRightsResponse" message="tns:SetFunctionalRightsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetDataRight">
      <wsdl:documentation>
        <summary>Set one specific data right at the given position. An exception will be thrown if non existing position is specified.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetDataRight" name="SetDataRightRequest" message="tns:SetDataRightRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetDataRightResponse" name="SetDataRightResponse" message="tns:SetDataRightResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDataRight">
      <wsdl:documentation>
        <summary>Read one specific data right at the given position. An exception will be thrown if non existing position is specified.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetDataRight" name="GetDataRightRequest" message="tns:GetDataRightRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetDataRightResponse" name="GetDataRightResponse" message="tns:GetDataRightResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDataRights">
      <wsdl:documentation>
        <summary>Read specific a set of data rights at the given row in the rights matrix. An exception will be thrown if non existing position is specified.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetDataRights" name="GetDataRightsRequest" message="tns:GetDataRightsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetDataRightsResponse" name="GetDataRightsResponse" message="tns:GetDataRightsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultRoleEntityFromType">
      <wsdl:documentation>
        <summary>Create a new role entity of the specified role type. The role type cannot be changed after the entity is created.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultRoleEntityFromType" name="CreateDefaultRoleEntityFromTypeRequest" message="tns:CreateDefaultRoleEntityFromTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultRoleEntityFromTypeResponse" name="CreateDefaultRoleEntityFromTypeResponse" message="tns:CreateDefaultRoleEntityFromTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="FindRolesWithFunctionalRight">
      <wsdl:documentation>
        <summary>Find all roles with a given functional right. The roles matched must contain the specified functional right. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/FindRolesWithFunctionalRight" name="FindRolesWithFunctionalRightRequest" message="tns:FindRolesWithFunctionalRightRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/FindRolesWithFunctionalRightResponse" name="FindRolesWithFunctionalRightResponse" message="tns:FindRolesWithFunctionalRightResponse" />
    </wsdl:operation>
    <wsdl:operation name="FindRolesWithFunctionalRights">
      <wsdl:documentation>
        <summary>Find all roles with a given set of functional rights. The roles matched must contain one or more of the specified functional rights. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/FindRolesWithFunctionalRights" name="FindRolesWithFunctionalRightsRequest" message="tns:FindRolesWithFunctionalRightsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/FindRolesWithFunctionalRightsResponse" name="FindRolesWithFunctionalRightsResponse" message="tns:FindRolesWithFunctionalRightsResponse" />
    </wsdl:operation>
    <wsdl:operation name="FindRolesWithoutFunctionalRights">
      <wsdl:documentation>
        <summary>Find all roles without a given set of functional rights. The roles matched must not contain any of the specified functional rights. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/FindRolesWithoutFunctionalRights" name="FindRolesWithoutFunctionalRightsRequest" message="tns:FindRolesWithoutFunctionalRightsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/FindRolesWithoutFunctionalRightsResponse" name="FindRolesWithoutFunctionalRightsResponse" message="tns:FindRolesWithoutFunctionalRightsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUser">
      <wsdl:documentation>
        <summary>Gets a User object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUser" name="GetUserRequest" message="tns:GetUserRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserResponse" name="GetUserResponse" message="tns:GetUserResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserFromName">
      <wsdl:documentation>
        <summary>Get a user, with lookup based on user name.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserFromName" name="GetUserFromNameRequest" message="tns:GetUserFromNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserFromNameResponse" name="GetUserFromNameResponse" message="tns:GetUserFromNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveUserFromName">
      <wsdl:documentation>
        <summary>Save a user, with lookup based on the user name.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveUserFromName" name="SaveUserFromNameRequest" message="tns:SaveUserFromNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveUserFromNameResponse" name="SaveUserFromNameResponse" message="tns:SaveUserFromNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteUserFromName">
      <wsdl:documentation>
        <summary>Delete a user, with lookup based on the user name.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteUserFromName" name="DeleteUserFromNameRequest" message="tns:DeleteUserFromNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteUserFromNameResponse" name="DeleteUserFromNameResponse" message="tns:DeleteUserFromNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCredentialTypes">
      <wsdl:documentation>
        <summary>Get available credential types that can be used for authentication</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetCredentialTypes" name="GetCredentialTypesRequest" message="tns:GetCredentialTypesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetCredentialTypesResponse" name="GetCredentialTypesResponse" message="tns:GetCredentialTypesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCredentialTypesForUserType">
      <wsdl:documentation>
        <summary>Get available credential types that can be used for the specified user type.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetCredentialTypesForUserType" name="GetCredentialTypesForUserTypeRequest" message="tns:GetCredentialTypesForUserTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetCredentialTypesForUserTypeResponse" name="GetCredentialTypesForUserTypeResponse" message="tns:GetCredentialTypesForUserTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveUntrustedCredentials">
      <wsdl:documentation>
        <summary>Save credentials for authenticated user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveUntrustedCredentials" name="SaveUntrustedCredentialsRequest" message="tns:SaveUntrustedCredentialsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveUntrustedCredentialsResponse" name="SaveUntrustedCredentialsResponse" message="tns:SaveUntrustedCredentialsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUntrustedCredentials">
      <wsdl:documentation>
        <summary>Get a set of credentials of a specified type for authenticated user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUntrustedCredentials" name="GetUntrustedCredentialsRequest" message="tns:GetUntrustedCredentialsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUntrustedCredentialsResponse" name="GetUntrustedCredentialsResponse" message="tns:GetUntrustedCredentialsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUntrustedCredentialsForAssociate">
      <wsdl:documentation>
        <summary>Get a set of credentials of a specified type for a specified user. SecretValue is only populated for authenticated user, and system users.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUntrustedCredentialsForAssociate" name="GetUntrustedCredentialsForAssociateRequest" message="tns:GetUntrustedCredentialsForAssociateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUntrustedCredentialsForAssociateResponse" name="GetUntrustedCredentialsForAssociateResponse" message="tns:GetUntrustedCredentialsForAssociateResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveUntrustedCredentialsForAssociate">
      <wsdl:documentation>
        <summary>Save credentials for a specified user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveUntrustedCredentialsForAssociate" name="SaveUntrustedCredentialsForAssociateRequest" message="tns:SaveUntrustedCredentialsForAssociateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveUntrustedCredentialsForAssociateResponse" name="SaveUntrustedCredentialsForAssociateResponse" message="tns:SaveUntrustedCredentialsForAssociateResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveUntrustedCredentials">
      <wsdl:documentation>
        <summary>Remove a credentials entry for authenticated user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/RemoveUntrustedCredentials" name="RemoveUntrustedCredentialsRequest" message="tns:RemoveUntrustedCredentialsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/RemoveUntrustedCredentialsResponse" name="RemoveUntrustedCredentialsResponse" message="tns:RemoveUntrustedCredentialsResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveUntrustedCredentialsForAssociate">
      <wsdl:documentation>
        <summary>Remove a credentials entry for a specified user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/RemoveUntrustedCredentialsForAssociate" name="RemoveUntrustedCredentialsForAssociateRequest" message="tns:RemoveUntrustedCredentialsForAssociateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/RemoveUntrustedCredentialsForAssociateResponse" name="RemoveUntrustedCredentialsForAssociateResponse" message="tns:RemoveUntrustedCredentialsForAssociateResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateExternalUser">
      <wsdl:documentation>
        <summary>Creates an associate of type external user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateExternalUser" name="CreateExternalUserRequest" message="tns:CreateExternalUserRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateExternalUserResponse" name="CreateExternalUserResponse" message="tns:CreateExternalUserResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteExternalUser">
      <wsdl:documentation>
        <summary>Deletes an associate of type external user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteExternalUser" name="DeleteExternalUserRequest" message="tns:DeleteExternalUserRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteExternalUserResponse" name="DeleteExternalUserResponse" message="tns:DeleteExternalUserResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetExternalUserInfo">
      <wsdl:documentation>
        <summary>Modifies an external user. Changes external users information according to the flags set in  externalUserInfoModification.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetExternalUserInfo" name="SetExternalUserInfoRequest" message="tns:SetExternalUserInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetExternalUserInfoResponse" name="SetExternalUserInfoResponse" message="tns:SetExternalUserInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="GenerateNewPasswordForExternalUser">
      <wsdl:documentation>
        <summary>Generates a new password for an external user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GenerateNewPasswordForExternalUser" name="GenerateNewPasswordForExternalUserRequest" message="tns:GenerateNewPasswordForExternalUserRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GenerateNewPasswordForExternalUserResponse" name="GenerateNewPasswordForExternalUserResponse" message="tns:GenerateNewPasswordForExternalUserResponse" />
    </wsdl:operation>
    <wsdl:operation name="CanChangePassword">
      <wsdl:documentation>
        <summary>Check if the current assoicate can change the password for an associate</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CanChangePassword" name="CanChangePasswordRequest" message="tns:CanChangePasswordRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CanChangePasswordResponse" name="CanChangePasswordResponse" message="tns:CanChangePasswordResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChangePassword">
      <wsdl:documentation>
        <summary>Change password for a user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/ChangePassword" name="ChangePasswordRequest" message="tns:ChangePasswordRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/ChangePasswordResponse" name="ChangePasswordResponse" message="tns:ChangePasswordResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserFromPersonId">
      <wsdl:documentation>
        <summary>Returns the user associated with the supplied person id</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserFromPersonId" name="GetUserFromPersonIdRequest" message="tns:GetUserFromPersonIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserFromPersonIdResponse" name="GetUserFromPersonIdResponse" message="tns:GetUserFromPersonIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultUserFromUserTypeAndPersonId">
      <wsdl:documentation>
        <summary>Create default User providing the associate type and person id.  System and Anonymous users can be created without an exsisting person and permitts person id to be 0.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultUserFromUserTypeAndPersonId" name="CreateDefaultUserFromUserTypeAndPersonIdRequest" message="tns:CreateDefaultUserFromUserTypeAndPersonIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultUserFromUserTypeAndPersonIdResponse" name="CreateDefaultUserFromUserTypeAndPersonIdResponse" message="tns:CreateDefaultUserFromUserTypeAndPersonIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultUserFromUserType">
      <wsdl:documentation>
        <summary>Create default User providing the user type.  Only System and Anonymous users can be created without an exsisting person.  Use CreateDefaultUserFromUserTypeAndPersonId to create internal (i.e. Employee) or external users.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultUserFromUserType" name="CreateDefaultUserFromUserTypeRequest" message="tns:CreateDefaultUserFromUserTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultUserFromUserTypeResponse" name="CreateDefaultUserFromUserTypeResponse" message="tns:CreateDefaultUserFromUserTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserFromEjUserId">
      <wsdl:documentation>
        <summary>Get user from ejUserId - used for eJournal Legacy Support.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserFromEjUserId" name="GetUserFromEjUserIdRequest" message="tns:GetUserFromEjUserIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserFromEjUserIdResponse" name="GetUserFromEjUserIdResponse" message="tns:GetUserFromEjUserIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetPasswordFromName">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetPasswordFromName" name="SetPasswordFromNameRequest" message="tns:SetPasswordFromNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetPasswordFromNameResponse" name="SetPasswordFromNameResponse" message="tns:SetPasswordFromNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetPassword">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetPassword" name="SetPasswordRequest" message="tns:SetPasswordRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetPasswordResponse" name="SetPasswordResponse" message="tns:SetPasswordResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChangeOwnPassword">
      <wsdl:documentation>
        <summary>Change password for a user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/ChangeOwnPassword" name="ChangeOwnPasswordRequest" message="tns:ChangeOwnPasswordRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/ChangeOwnPasswordResponse" name="ChangeOwnPasswordResponse" message="tns:ChangeOwnPasswordResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChangePasswordFromName">
      <wsdl:documentation>
        <summary>Change password for a user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/ChangePasswordFromName" name="ChangePasswordFromNameRequest" message="tns:ChangePasswordFromNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/ChangePasswordFromNameResponse" name="ChangePasswordFromNameResponse" message="tns:ChangePasswordFromNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="IsUserNameValid">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/IsUserNameValid" name="IsUserNameValidRequest" message="tns:IsUserNameValidRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/IsUserNameValidResponse" name="IsUserNameValidResponse" message="tns:IsUserNameValidResponse" />
    </wsdl:operation>
    <wsdl:operation name="IsPasswordValid">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/IsPasswordValid" name="IsPasswordValidRequest" message="tns:IsPasswordValidRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/IsPasswordValidResponse" name="IsPasswordValidResponse" message="tns:IsPasswordValidResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetGeneratedPassword">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetGeneratedPassword" name="SetGeneratedPasswordRequest" message="tns:SetGeneratedPasswordRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetGeneratedPasswordResponse" name="SetGeneratedPasswordResponse" message="tns:SetGeneratedPasswordResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetGeneratedPasswordFromName">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetGeneratedPasswordFromName" name="SetGeneratedPasswordFromNameRequest" message="tns:SetGeneratedPasswordFromNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetGeneratedPasswordFromNameResponse" name="SetGeneratedPasswordFromNameResponse" message="tns:SetGeneratedPasswordFromNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="IsPasswordValidWithReason">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/IsPasswordValidWithReason" name="IsPasswordValidWithReasonRequest" message="tns:IsPasswordValidWithReasonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/IsPasswordValidWithReasonResponse" name="IsPasswordValidWithReasonResponse" message="tns:IsPasswordValidWithReasonResponse" />
    </wsdl:operation>
    <wsdl:operation name="IsUserNameValidWithReason">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/IsUserNameValidWithReason" name="IsUserNameValidWithReasonRequest" message="tns:IsUserNameValidWithReasonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/IsUserNameValidWithReasonResponse" name="IsUserNameValidWithReasonResponse" message="tns:IsUserNameValidWithReasonResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChangeUserType">
      <wsdl:documentation>
        <summary>Get a user from the user name.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/ChangeUserType" name="ChangeUserTypeRequest" message="tns:ChangeUserTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/ChangeUserTypeResponse" name="ChangeUserTypeResponse" message="tns:ChangeUserTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultUserFromUserTypeAndCredential">
      <wsdl:documentation>
        <summary>Creates a PersonEntity with default values based on the contactId and credentials.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultUserFromUserTypeAndCredential" name="CreateDefaultUserFromUserTypeAndCredentialRequest" message="tns:CreateDefaultUserFromUserTypeAndCredentialRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultUserFromUserTypeAndCredentialResponse" name="CreateDefaultUserFromUserTypeAndCredentialResponse" message="tns:CreateDefaultUserFromUserTypeAndCredentialResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetValidUserName">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetValidUserName" name="GetValidUserNameRequest" message="tns:GetValidUserNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetValidUserNameResponse" name="GetValidUserNameResponse" message="tns:GetValidUserNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveLicenses">
      <wsdl:documentation>
        <summary>Remove all user licenses.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/RemoveLicenses" name="RemoveLicensesRequest" message="tns:RemoveLicensesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/RemoveLicensesResponse" name="RemoveLicensesResponse" message="tns:RemoveLicensesResponse" />
    </wsdl:operation>
    <wsdl:operation name="MakeRetired">
      <wsdl:documentation>
        <summary>Retiring a user means to remove all licenses, setting person.retired=1 and associate.deleted=1. Unretiering a user means setting  person.retired=0 and associate.deleted=0</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/MakeRetired" name="MakeRetiredRequest" message="tns:MakeRetiredRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/MakeRetiredResponse" name="MakeRetiredResponse" message="tns:MakeRetiredResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddOwnerContact">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/AddOwnerContact" name="AddOwnerContactRequest" message="tns:AddOwnerContactRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/AddOwnerContactResponse" name="AddOwnerContactResponse" message="tns:AddOwnerContactResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveOwnerContact">
      <wsdl:documentation>
        <summary>Remove a contact from the ownercontactlink table</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/RemoveOwnerContact" name="RemoveOwnerContactRequest" message="tns:RemoveOwnerContactRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/RemoveOwnerContactResponse" name="RemoveOwnerContactResponse" message="tns:RemoveOwnerContactResponse" />
    </wsdl:operation>
    <wsdl:operation name="ResolveUserFromInfo">
      <wsdl:documentation>
        <summary>Get a user from the provided information. If the user or associated person does not exist, it will be created on demand.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/ResolveUserFromInfo" name="ResolveUserFromInfoRequest" message="tns:ResolveUserFromInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/ResolveUserFromInfoResponse" name="ResolveUserFromInfoResponse" message="tns:ResolveUserFromInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserGroup">
      <wsdl:documentation>
        <summary>Gets a UserGroup object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserGroup" name="GetUserGroupRequest" message="tns:GetUserGroupRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserGroupResponse" name="GetUserGroupResponse" message="tns:GetUserGroupResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveUserGroup">
      <wsdl:documentation>
        <summary>Save a user group.  Set UserGroup.Deleted to mark a user group as deleted and invisible in the user interface.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveUserGroup" name="SaveUserGroupRequest" message="tns:SaveUserGroupRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveUserGroupResponse" name="SaveUserGroupResponse" message="tns:SaveUserGroupResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllUserGroups">
      <wsdl:documentation>
        <summary>Get all user groups</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetAllUserGroups" name="GetAllUserGroupsRequest" message="tns:GetAllUserGroupsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetAllUserGroupsResponse" name="GetAllUserGroupsResponse" message="tns:GetAllUserGroupsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateUserGroup">
      <wsdl:documentation>
        <summary>Create UserGroup (Rank is assigned to the highest rank)</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateUserGroup" name="CreateUserGroupRequest" message="tns:CreateUserGroupRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateUserGroupResponse" name="CreateUserGroupResponse" message="tns:CreateUserGroupResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteUserGroup">
      <wsdl:documentation>
        <summary>Delete a usergroup and move its members to another usergroup</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteUserGroup" name="DeleteUserGroupRequest" message="tns:DeleteUserGroupRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteUserGroupResponse" name="DeleteUserGroupResponse" message="tns:DeleteUserGroupResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserGroupList">
      <wsdl:documentation>
        <summary>Gets an array of UserGroup objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserGroupList" name="GetUserGroupListRequest" message="tns:GetUserGroupListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserGroupListResponse" name="GetUserGroupListResponse" message="tns:GetUserGroupListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserInfo">
      <wsdl:documentation>
        <summary>Gets a UserInfo object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserInfo" name="GetUserInfoRequest" message="tns:GetUserInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserInfoResponse" name="GetUserInfoResponse" message="tns:GetUserInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserInfoList">
      <wsdl:documentation>
        <summary>Gets an array of UserInfo objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserInfoList" name="GetUserInfoListRequest" message="tns:GetUserInfoListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserInfoListResponse" name="GetUserInfoListResponse" message="tns:GetUserInfoListResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_User" type="tns:User">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultServiceAuth">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultServiceAuth" style="document" />
      <wsdl:input name="CreateDefaultServiceAuthRequest">
        <soap:header message="tns:CreateDefaultServiceAuthRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultServiceAuthRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultServiceAuthRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultServiceAuthResponse">
        <soap:header message="tns:CreateDefaultServiceAuthResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultServiceAuthResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultServiceAuthResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultServiceAuthResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveServiceAuth">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveServiceAuth" style="document" />
      <wsdl:input name="SaveServiceAuthRequest">
        <soap:header message="tns:SaveServiceAuthRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveServiceAuthRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveServiceAuthRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveServiceAuthResponse">
        <soap:header message="tns:SaveServiceAuthResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveServiceAuthResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveServiceAuthResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveServiceAuthResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteServiceAuth">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteServiceAuth" style="document" />
      <wsdl:input name="DeleteServiceAuthRequest">
        <soap:header message="tns:DeleteServiceAuthRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteServiceAuthRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteServiceAuthRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteServiceAuthResponse">
        <soap:header message="tns:DeleteServiceAuthResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteServiceAuthResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteServiceAuthResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteServiceAuthResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultRoleEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultRoleEntity" style="document" />
      <wsdl:input name="CreateDefaultRoleEntityRequest">
        <soap:header message="tns:CreateDefaultRoleEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultRoleEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultRoleEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultRoleEntityResponse">
        <soap:header message="tns:CreateDefaultRoleEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultRoleEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultRoleEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultRoleEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveRoleEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveRoleEntity" style="document" />
      <wsdl:input name="SaveRoleEntityRequest">
        <soap:header message="tns:SaveRoleEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveRoleEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveRoleEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveRoleEntityResponse">
        <soap:header message="tns:SaveRoleEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveRoleEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveRoleEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveRoleEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultUntrustedCredentials">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultUntrustedCredentials" style="document" />
      <wsdl:input name="CreateDefaultUntrustedCredentialsRequest">
        <soap:header message="tns:CreateDefaultUntrustedCredentialsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultUntrustedCredentialsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultUntrustedCredentialsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultUntrustedCredentialsResponse">
        <soap:header message="tns:CreateDefaultUntrustedCredentialsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultUntrustedCredentialsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultUntrustedCredentialsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultUntrustedCredentialsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultUser">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultUser" style="document" />
      <wsdl:input name="CreateDefaultUserRequest">
        <soap:header message="tns:CreateDefaultUserRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultUserRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultUserRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultUserResponse">
        <soap:header message="tns:CreateDefaultUserResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultUserResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultUserResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultUserResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveUser">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveUser" style="document" />
      <wsdl:input name="SaveUserRequest">
        <soap:header message="tns:SaveUserRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveUserRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveUserRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveUserResponse">
        <soap:header message="tns:SaveUserResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveUserResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveUserResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveUserResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserCommands">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserCommands" style="document" />
      <wsdl:input name="GetUserCommandsRequest">
        <soap:header message="tns:GetUserCommandsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserCommandsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserCommandsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserCommandsResponse">
        <soap:header message="tns:GetUserCommandsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserCommandsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserCommandsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserCommandsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ExecuteUserCommand">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/ExecuteUserCommand" style="document" />
      <wsdl:input name="ExecuteUserCommandRequest">
        <soap:header message="tns:ExecuteUserCommandRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ExecuteUserCommandRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ExecuteUserCommandRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ExecuteUserCommandResponse">
        <soap:header message="tns:ExecuteUserCommandResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ExecuteUserCommandResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ExecuteUserCommandResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ExecuteUserCommandResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteUser">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteUser" style="document" />
      <wsdl:input name="DeleteUserRequest">
        <soap:header message="tns:DeleteUserRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteUserRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteUserRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteUserResponse">
        <soap:header message="tns:DeleteUserResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteUserResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteUserResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteUserResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveCredential">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveCredential" style="document" />
      <wsdl:input name="SaveCredentialRequest">
        <soap:header message="tns:SaveCredentialRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveCredentialRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveCredentialRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveCredentialResponse">
        <soap:header message="tns:SaveCredentialResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveCredentialResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveCredentialResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveCredentialResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteCredential">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteCredential" style="document" />
      <wsdl:input name="DeleteCredentialRequest">
        <soap:header message="tns:DeleteCredentialRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteCredentialRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteCredentialRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteCredentialResponse">
        <soap:header message="tns:DeleteCredentialResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteCredentialResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteCredentialResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteCredentialResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindCredentialsGroups">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/FindCredentialsGroups" style="document" />
      <wsdl:input name="FindCredentialsGroupsRequest">
        <soap:header message="tns:FindCredentialsGroupsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindCredentialsGroupsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindCredentialsGroupsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindCredentialsGroupsResponse">
        <soap:header message="tns:FindCredentialsGroupsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindCredentialsGroupsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindCredentialsGroupsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindCredentialsGroupsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindCredentialUsers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/FindCredentialUsers" style="document" />
      <wsdl:input name="FindCredentialUsersRequest">
        <soap:header message="tns:FindCredentialUsersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindCredentialUsersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindCredentialUsersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindCredentialUsersResponse">
        <soap:header message="tns:FindCredentialUsersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindCredentialUsersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindCredentialUsersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindCredentialUsersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCredentialUsersInGroup">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetCredentialUsersInGroup" style="document" />
      <wsdl:input name="GetCredentialUsersInGroupRequest">
        <soap:header message="tns:GetCredentialUsersInGroupRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCredentialUsersInGroupRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCredentialUsersInGroupRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCredentialUsersInGroupResponse">
        <soap:header message="tns:GetCredentialUsersInGroupResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCredentialUsersInGroupResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCredentialUsersInGroupResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCredentialUsersInGroupResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetServiceAuth">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetServiceAuth" style="document" />
      <wsdl:input name="GetServiceAuthRequest">
        <soap:header message="tns:GetServiceAuthRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetServiceAuthRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetServiceAuthRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetServiceAuthResponse">
        <soap:header message="tns:GetServiceAuthResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetServiceAuthResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetServiceAuthResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetServiceAuthResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetRole">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetRole" style="document" />
      <wsdl:input name="GetRoleRequest">
        <soap:header message="tns:GetRoleRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetRoleRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetRoleRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetRoleResponse">
        <soap:header message="tns:GetRoleResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetRoleResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetRoleResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetRoleResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetRoleEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetRoleEntity" style="document" />
      <wsdl:input name="GetRoleEntityRequest">
        <soap:header message="tns:GetRoleEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetRoleEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetRoleEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetRoleEntityResponse">
        <soap:header message="tns:GetRoleEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetRoleEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetRoleEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetRoleEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteRole">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteRole" style="document" />
      <wsdl:input name="DeleteRoleRequest">
        <soap:header message="tns:DeleteRoleRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteRoleRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteRoleRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteRoleResponse">
        <soap:header message="tns:DeleteRoleResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteRoleResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteRoleResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteRoleResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllRoles">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetAllRoles" style="document" />
      <wsdl:input name="GetAllRolesRequest">
        <soap:header message="tns:GetAllRolesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllRolesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllRolesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllRolesResponse">
        <soap:header message="tns:GetAllRolesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllRolesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllRolesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllRolesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllFunctionalRights">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetAllFunctionalRights" style="document" />
      <wsdl:input name="GetAllFunctionalRightsRequest">
        <soap:header message="tns:GetAllFunctionalRightsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllFunctionalRightsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllFunctionalRightsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllFunctionalRightsResponse">
        <soap:header message="tns:GetAllFunctionalRightsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllFunctionalRightsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllFunctionalRightsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllFunctionalRightsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFunctionalRights">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetFunctionalRights" style="document" />
      <wsdl:input name="GetFunctionalRightsRequest">
        <soap:header message="tns:GetFunctionalRightsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFunctionalRightsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFunctionalRightsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFunctionalRightsResponse">
        <soap:header message="tns:GetFunctionalRightsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFunctionalRightsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFunctionalRightsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFunctionalRightsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetFunctionalRights">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetFunctionalRights" style="document" />
      <wsdl:input name="SetFunctionalRightsRequest">
        <soap:header message="tns:SetFunctionalRightsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetFunctionalRightsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetFunctionalRightsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetFunctionalRightsResponse">
        <soap:header message="tns:SetFunctionalRightsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetFunctionalRightsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetFunctionalRightsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetFunctionalRightsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetDataRight">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetDataRight" style="document" />
      <wsdl:input name="SetDataRightRequest">
        <soap:header message="tns:SetDataRightRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetDataRightRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetDataRightRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetDataRightResponse">
        <soap:header message="tns:SetDataRightResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetDataRightResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetDataRightResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetDataRightResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDataRight">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetDataRight" style="document" />
      <wsdl:input name="GetDataRightRequest">
        <soap:header message="tns:GetDataRightRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDataRightRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDataRightRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDataRightResponse">
        <soap:header message="tns:GetDataRightResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDataRightResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDataRightResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDataRightResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDataRights">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetDataRights" style="document" />
      <wsdl:input name="GetDataRightsRequest">
        <soap:header message="tns:GetDataRightsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDataRightsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDataRightsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDataRightsResponse">
        <soap:header message="tns:GetDataRightsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDataRightsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDataRightsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDataRightsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultRoleEntityFromType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultRoleEntityFromType" style="document" />
      <wsdl:input name="CreateDefaultRoleEntityFromTypeRequest">
        <soap:header message="tns:CreateDefaultRoleEntityFromTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultRoleEntityFromTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultRoleEntityFromTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultRoleEntityFromTypeResponse">
        <soap:header message="tns:CreateDefaultRoleEntityFromTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultRoleEntityFromTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultRoleEntityFromTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultRoleEntityFromTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindRolesWithFunctionalRight">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/FindRolesWithFunctionalRight" style="document" />
      <wsdl:input name="FindRolesWithFunctionalRightRequest">
        <soap:header message="tns:FindRolesWithFunctionalRightRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindRolesWithFunctionalRightRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindRolesWithFunctionalRightRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindRolesWithFunctionalRightResponse">
        <soap:header message="tns:FindRolesWithFunctionalRightResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindRolesWithFunctionalRightResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindRolesWithFunctionalRightResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindRolesWithFunctionalRightResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindRolesWithFunctionalRights">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/FindRolesWithFunctionalRights" style="document" />
      <wsdl:input name="FindRolesWithFunctionalRightsRequest">
        <soap:header message="tns:FindRolesWithFunctionalRightsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindRolesWithFunctionalRightsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindRolesWithFunctionalRightsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindRolesWithFunctionalRightsResponse">
        <soap:header message="tns:FindRolesWithFunctionalRightsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindRolesWithFunctionalRightsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindRolesWithFunctionalRightsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindRolesWithFunctionalRightsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindRolesWithoutFunctionalRights">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/FindRolesWithoutFunctionalRights" style="document" />
      <wsdl:input name="FindRolesWithoutFunctionalRightsRequest">
        <soap:header message="tns:FindRolesWithoutFunctionalRightsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindRolesWithoutFunctionalRightsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindRolesWithoutFunctionalRightsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindRolesWithoutFunctionalRightsResponse">
        <soap:header message="tns:FindRolesWithoutFunctionalRightsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindRolesWithoutFunctionalRightsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindRolesWithoutFunctionalRightsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindRolesWithoutFunctionalRightsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUser">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUser" style="document" />
      <wsdl:input name="GetUserRequest">
        <soap:header message="tns:GetUserRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserResponse">
        <soap:header message="tns:GetUserResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserFromName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserFromName" style="document" />
      <wsdl:input name="GetUserFromNameRequest">
        <soap:header message="tns:GetUserFromNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserFromNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserFromNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserFromNameResponse">
        <soap:header message="tns:GetUserFromNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserFromNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserFromNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserFromNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveUserFromName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveUserFromName" style="document" />
      <wsdl:input name="SaveUserFromNameRequest">
        <soap:header message="tns:SaveUserFromNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveUserFromNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveUserFromNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveUserFromNameResponse">
        <soap:header message="tns:SaveUserFromNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveUserFromNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveUserFromNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveUserFromNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteUserFromName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteUserFromName" style="document" />
      <wsdl:input name="DeleteUserFromNameRequest">
        <soap:header message="tns:DeleteUserFromNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteUserFromNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteUserFromNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteUserFromNameResponse">
        <soap:header message="tns:DeleteUserFromNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteUserFromNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteUserFromNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteUserFromNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCredentialTypes">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetCredentialTypes" style="document" />
      <wsdl:input name="GetCredentialTypesRequest">
        <soap:header message="tns:GetCredentialTypesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCredentialTypesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCredentialTypesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCredentialTypesResponse">
        <soap:header message="tns:GetCredentialTypesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCredentialTypesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCredentialTypesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCredentialTypesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCredentialTypesForUserType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetCredentialTypesForUserType" style="document" />
      <wsdl:input name="GetCredentialTypesForUserTypeRequest">
        <soap:header message="tns:GetCredentialTypesForUserTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCredentialTypesForUserTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCredentialTypesForUserTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCredentialTypesForUserTypeResponse">
        <soap:header message="tns:GetCredentialTypesForUserTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCredentialTypesForUserTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCredentialTypesForUserTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCredentialTypesForUserTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveUntrustedCredentials">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveUntrustedCredentials" style="document" />
      <wsdl:input name="SaveUntrustedCredentialsRequest">
        <soap:header message="tns:SaveUntrustedCredentialsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveUntrustedCredentialsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveUntrustedCredentialsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveUntrustedCredentialsResponse">
        <soap:header message="tns:SaveUntrustedCredentialsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveUntrustedCredentialsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveUntrustedCredentialsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveUntrustedCredentialsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUntrustedCredentials">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUntrustedCredentials" style="document" />
      <wsdl:input name="GetUntrustedCredentialsRequest">
        <soap:header message="tns:GetUntrustedCredentialsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUntrustedCredentialsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUntrustedCredentialsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUntrustedCredentialsResponse">
        <soap:header message="tns:GetUntrustedCredentialsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUntrustedCredentialsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUntrustedCredentialsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUntrustedCredentialsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUntrustedCredentialsForAssociate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUntrustedCredentialsForAssociate" style="document" />
      <wsdl:input name="GetUntrustedCredentialsForAssociateRequest">
        <soap:header message="tns:GetUntrustedCredentialsForAssociateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUntrustedCredentialsForAssociateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUntrustedCredentialsForAssociateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUntrustedCredentialsForAssociateResponse">
        <soap:header message="tns:GetUntrustedCredentialsForAssociateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUntrustedCredentialsForAssociateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUntrustedCredentialsForAssociateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUntrustedCredentialsForAssociateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveUntrustedCredentialsForAssociate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveUntrustedCredentialsForAssociate" style="document" />
      <wsdl:input name="SaveUntrustedCredentialsForAssociateRequest">
        <soap:header message="tns:SaveUntrustedCredentialsForAssociateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveUntrustedCredentialsForAssociateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveUntrustedCredentialsForAssociateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveUntrustedCredentialsForAssociateResponse">
        <soap:header message="tns:SaveUntrustedCredentialsForAssociateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveUntrustedCredentialsForAssociateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveUntrustedCredentialsForAssociateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveUntrustedCredentialsForAssociateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveUntrustedCredentials">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/RemoveUntrustedCredentials" style="document" />
      <wsdl:input name="RemoveUntrustedCredentialsRequest">
        <soap:header message="tns:RemoveUntrustedCredentialsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveUntrustedCredentialsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveUntrustedCredentialsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveUntrustedCredentialsResponse">
        <soap:header message="tns:RemoveUntrustedCredentialsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveUntrustedCredentialsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveUntrustedCredentialsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveUntrustedCredentialsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveUntrustedCredentialsForAssociate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/RemoveUntrustedCredentialsForAssociate" style="document" />
      <wsdl:input name="RemoveUntrustedCredentialsForAssociateRequest">
        <soap:header message="tns:RemoveUntrustedCredentialsForAssociateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveUntrustedCredentialsForAssociateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveUntrustedCredentialsForAssociateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveUntrustedCredentialsForAssociateResponse">
        <soap:header message="tns:RemoveUntrustedCredentialsForAssociateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveUntrustedCredentialsForAssociateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveUntrustedCredentialsForAssociateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveUntrustedCredentialsForAssociateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateExternalUser">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateExternalUser" style="document" />
      <wsdl:input name="CreateExternalUserRequest">
        <soap:header message="tns:CreateExternalUserRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateExternalUserRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateExternalUserRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateExternalUserResponse">
        <soap:header message="tns:CreateExternalUserResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateExternalUserResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateExternalUserResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateExternalUserResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteExternalUser">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteExternalUser" style="document" />
      <wsdl:input name="DeleteExternalUserRequest">
        <soap:header message="tns:DeleteExternalUserRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteExternalUserRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteExternalUserRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteExternalUserResponse">
        <soap:header message="tns:DeleteExternalUserResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteExternalUserResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteExternalUserResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteExternalUserResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetExternalUserInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetExternalUserInfo" style="document" />
      <wsdl:input name="SetExternalUserInfoRequest">
        <soap:header message="tns:SetExternalUserInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetExternalUserInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetExternalUserInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetExternalUserInfoResponse">
        <soap:header message="tns:SetExternalUserInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetExternalUserInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetExternalUserInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetExternalUserInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GenerateNewPasswordForExternalUser">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GenerateNewPasswordForExternalUser" style="document" />
      <wsdl:input name="GenerateNewPasswordForExternalUserRequest">
        <soap:header message="tns:GenerateNewPasswordForExternalUserRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GenerateNewPasswordForExternalUserRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GenerateNewPasswordForExternalUserRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GenerateNewPasswordForExternalUserResponse">
        <soap:header message="tns:GenerateNewPasswordForExternalUserResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GenerateNewPasswordForExternalUserResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GenerateNewPasswordForExternalUserResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GenerateNewPasswordForExternalUserResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CanChangePassword">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CanChangePassword" style="document" />
      <wsdl:input name="CanChangePasswordRequest">
        <soap:header message="tns:CanChangePasswordRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CanChangePasswordRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CanChangePasswordRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CanChangePasswordResponse">
        <soap:header message="tns:CanChangePasswordResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CanChangePasswordResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CanChangePasswordResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CanChangePasswordResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChangePassword">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/ChangePassword" style="document" />
      <wsdl:input name="ChangePasswordRequest">
        <soap:header message="tns:ChangePasswordRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChangePasswordRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChangePasswordRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChangePasswordResponse">
        <soap:header message="tns:ChangePasswordResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChangePasswordResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChangePasswordResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChangePasswordResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserFromPersonId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserFromPersonId" style="document" />
      <wsdl:input name="GetUserFromPersonIdRequest">
        <soap:header message="tns:GetUserFromPersonIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserFromPersonIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserFromPersonIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserFromPersonIdResponse">
        <soap:header message="tns:GetUserFromPersonIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserFromPersonIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserFromPersonIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserFromPersonIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultUserFromUserTypeAndPersonId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultUserFromUserTypeAndPersonId" style="document" />
      <wsdl:input name="CreateDefaultUserFromUserTypeAndPersonIdRequest">
        <soap:header message="tns:CreateDefaultUserFromUserTypeAndPersonIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultUserFromUserTypeAndPersonIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultUserFromUserTypeAndPersonIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultUserFromUserTypeAndPersonIdResponse">
        <soap:header message="tns:CreateDefaultUserFromUserTypeAndPersonIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultUserFromUserTypeAndPersonIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultUserFromUserTypeAndPersonIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultUserFromUserTypeAndPersonIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultUserFromUserType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultUserFromUserType" style="document" />
      <wsdl:input name="CreateDefaultUserFromUserTypeRequest">
        <soap:header message="tns:CreateDefaultUserFromUserTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultUserFromUserTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultUserFromUserTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultUserFromUserTypeResponse">
        <soap:header message="tns:CreateDefaultUserFromUserTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultUserFromUserTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultUserFromUserTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultUserFromUserTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserFromEjUserId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserFromEjUserId" style="document" />
      <wsdl:input name="GetUserFromEjUserIdRequest">
        <soap:header message="tns:GetUserFromEjUserIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserFromEjUserIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserFromEjUserIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserFromEjUserIdResponse">
        <soap:header message="tns:GetUserFromEjUserIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserFromEjUserIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserFromEjUserIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserFromEjUserIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetPasswordFromName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetPasswordFromName" style="document" />
      <wsdl:input name="SetPasswordFromNameRequest">
        <soap:header message="tns:SetPasswordFromNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetPasswordFromNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetPasswordFromNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetPasswordFromNameResponse">
        <soap:header message="tns:SetPasswordFromNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetPasswordFromNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetPasswordFromNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetPasswordFromNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetPassword">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetPassword" style="document" />
      <wsdl:input name="SetPasswordRequest">
        <soap:header message="tns:SetPasswordRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetPasswordRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetPasswordRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetPasswordResponse">
        <soap:header message="tns:SetPasswordResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetPasswordResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetPasswordResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetPasswordResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChangeOwnPassword">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/ChangeOwnPassword" style="document" />
      <wsdl:input name="ChangeOwnPasswordRequest">
        <soap:header message="tns:ChangeOwnPasswordRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChangeOwnPasswordRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChangeOwnPasswordRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChangeOwnPasswordResponse">
        <soap:header message="tns:ChangeOwnPasswordResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChangeOwnPasswordResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChangeOwnPasswordResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChangeOwnPasswordResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChangePasswordFromName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/ChangePasswordFromName" style="document" />
      <wsdl:input name="ChangePasswordFromNameRequest">
        <soap:header message="tns:ChangePasswordFromNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChangePasswordFromNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChangePasswordFromNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChangePasswordFromNameResponse">
        <soap:header message="tns:ChangePasswordFromNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChangePasswordFromNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChangePasswordFromNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChangePasswordFromNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="IsUserNameValid">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/IsUserNameValid" style="document" />
      <wsdl:input name="IsUserNameValidRequest">
        <soap:header message="tns:IsUserNameValidRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:IsUserNameValidRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:IsUserNameValidRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="IsUserNameValidResponse">
        <soap:header message="tns:IsUserNameValidResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:IsUserNameValidResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:IsUserNameValidResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:IsUserNameValidResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="IsPasswordValid">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/IsPasswordValid" style="document" />
      <wsdl:input name="IsPasswordValidRequest">
        <soap:header message="tns:IsPasswordValidRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:IsPasswordValidRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:IsPasswordValidRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="IsPasswordValidResponse">
        <soap:header message="tns:IsPasswordValidResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:IsPasswordValidResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:IsPasswordValidResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:IsPasswordValidResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetGeneratedPassword">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetGeneratedPassword" style="document" />
      <wsdl:input name="SetGeneratedPasswordRequest">
        <soap:header message="tns:SetGeneratedPasswordRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetGeneratedPasswordRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetGeneratedPasswordRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetGeneratedPasswordResponse">
        <soap:header message="tns:SetGeneratedPasswordResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetGeneratedPasswordResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetGeneratedPasswordResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetGeneratedPasswordResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetGeneratedPasswordFromName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SetGeneratedPasswordFromName" style="document" />
      <wsdl:input name="SetGeneratedPasswordFromNameRequest">
        <soap:header message="tns:SetGeneratedPasswordFromNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetGeneratedPasswordFromNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetGeneratedPasswordFromNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetGeneratedPasswordFromNameResponse">
        <soap:header message="tns:SetGeneratedPasswordFromNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetGeneratedPasswordFromNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetGeneratedPasswordFromNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetGeneratedPasswordFromNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="IsPasswordValidWithReason">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/IsPasswordValidWithReason" style="document" />
      <wsdl:input name="IsPasswordValidWithReasonRequest">
        <soap:header message="tns:IsPasswordValidWithReasonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:IsPasswordValidWithReasonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:IsPasswordValidWithReasonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="IsPasswordValidWithReasonResponse">
        <soap:header message="tns:IsPasswordValidWithReasonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:IsPasswordValidWithReasonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:IsPasswordValidWithReasonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:IsPasswordValidWithReasonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="IsUserNameValidWithReason">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/IsUserNameValidWithReason" style="document" />
      <wsdl:input name="IsUserNameValidWithReasonRequest">
        <soap:header message="tns:IsUserNameValidWithReasonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:IsUserNameValidWithReasonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:IsUserNameValidWithReasonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="IsUserNameValidWithReasonResponse">
        <soap:header message="tns:IsUserNameValidWithReasonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:IsUserNameValidWithReasonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:IsUserNameValidWithReasonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:IsUserNameValidWithReasonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChangeUserType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/ChangeUserType" style="document" />
      <wsdl:input name="ChangeUserTypeRequest">
        <soap:header message="tns:ChangeUserTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChangeUserTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChangeUserTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChangeUserTypeResponse">
        <soap:header message="tns:ChangeUserTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChangeUserTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChangeUserTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChangeUserTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultUserFromUserTypeAndCredential">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateDefaultUserFromUserTypeAndCredential" style="document" />
      <wsdl:input name="CreateDefaultUserFromUserTypeAndCredentialRequest">
        <soap:header message="tns:CreateDefaultUserFromUserTypeAndCredentialRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultUserFromUserTypeAndCredentialRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultUserFromUserTypeAndCredentialRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultUserFromUserTypeAndCredentialResponse">
        <soap:header message="tns:CreateDefaultUserFromUserTypeAndCredentialResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultUserFromUserTypeAndCredentialResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultUserFromUserTypeAndCredentialResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultUserFromUserTypeAndCredentialResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetValidUserName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetValidUserName" style="document" />
      <wsdl:input name="GetValidUserNameRequest">
        <soap:header message="tns:GetValidUserNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetValidUserNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetValidUserNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetValidUserNameResponse">
        <soap:header message="tns:GetValidUserNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetValidUserNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetValidUserNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetValidUserNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveLicenses">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/RemoveLicenses" style="document" />
      <wsdl:input name="RemoveLicensesRequest">
        <soap:header message="tns:RemoveLicensesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveLicensesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveLicensesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveLicensesResponse">
        <soap:header message="tns:RemoveLicensesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveLicensesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveLicensesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveLicensesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="MakeRetired">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/MakeRetired" style="document" />
      <wsdl:input name="MakeRetiredRequest">
        <soap:header message="tns:MakeRetiredRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MakeRetiredRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MakeRetiredRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MakeRetiredResponse">
        <soap:header message="tns:MakeRetiredResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MakeRetiredResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MakeRetiredResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MakeRetiredResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddOwnerContact">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/AddOwnerContact" style="document" />
      <wsdl:input name="AddOwnerContactRequest">
        <soap:header message="tns:AddOwnerContactRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddOwnerContactRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddOwnerContactRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddOwnerContactResponse">
        <soap:header message="tns:AddOwnerContactResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddOwnerContactResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddOwnerContactResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddOwnerContactResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveOwnerContact">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/RemoveOwnerContact" style="document" />
      <wsdl:input name="RemoveOwnerContactRequest">
        <soap:header message="tns:RemoveOwnerContactRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveOwnerContactRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveOwnerContactRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveOwnerContactResponse">
        <soap:header message="tns:RemoveOwnerContactResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveOwnerContactResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveOwnerContactResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveOwnerContactResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ResolveUserFromInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/ResolveUserFromInfo" style="document" />
      <wsdl:input name="ResolveUserFromInfoRequest">
        <soap:header message="tns:ResolveUserFromInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ResolveUserFromInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ResolveUserFromInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ResolveUserFromInfoResponse">
        <soap:header message="tns:ResolveUserFromInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ResolveUserFromInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ResolveUserFromInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ResolveUserFromInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserGroup">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserGroup" style="document" />
      <wsdl:input name="GetUserGroupRequest">
        <soap:header message="tns:GetUserGroupRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserGroupRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserGroupRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserGroupResponse">
        <soap:header message="tns:GetUserGroupResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserGroupResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserGroupResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserGroupResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveUserGroup">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/SaveUserGroup" style="document" />
      <wsdl:input name="SaveUserGroupRequest">
        <soap:header message="tns:SaveUserGroupRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveUserGroupRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveUserGroupRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveUserGroupResponse">
        <soap:header message="tns:SaveUserGroupResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveUserGroupResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveUserGroupResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveUserGroupResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllUserGroups">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetAllUserGroups" style="document" />
      <wsdl:input name="GetAllUserGroupsRequest">
        <soap:header message="tns:GetAllUserGroupsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllUserGroupsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllUserGroupsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllUserGroupsResponse">
        <soap:header message="tns:GetAllUserGroupsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllUserGroupsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllUserGroupsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllUserGroupsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateUserGroup">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/CreateUserGroup" style="document" />
      <wsdl:input name="CreateUserGroupRequest">
        <soap:header message="tns:CreateUserGroupRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateUserGroupRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateUserGroupRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateUserGroupResponse">
        <soap:header message="tns:CreateUserGroupResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateUserGroupResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateUserGroupResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateUserGroupResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteUserGroup">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/DeleteUserGroup" style="document" />
      <wsdl:input name="DeleteUserGroupRequest">
        <soap:header message="tns:DeleteUserGroupRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteUserGroupRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteUserGroupRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteUserGroupResponse">
        <soap:header message="tns:DeleteUserGroupResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteUserGroupResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteUserGroupResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteUserGroupResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserGroupList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserGroupList" style="document" />
      <wsdl:input name="GetUserGroupListRequest">
        <soap:header message="tns:GetUserGroupListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserGroupListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserGroupListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserGroupListResponse">
        <soap:header message="tns:GetUserGroupListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserGroupListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserGroupListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserGroupListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserInfo" style="document" />
      <wsdl:input name="GetUserInfoRequest">
        <soap:header message="tns:GetUserInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserInfoResponse">
        <soap:header message="tns:GetUserInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserInfoList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/User/GetUserInfoList" style="document" />
      <wsdl:input name="GetUserInfoListRequest">
        <soap:header message="tns:GetUserInfoListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserInfoListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserInfoListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserInfoListResponse">
        <soap:header message="tns:GetUserInfoListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserInfoListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserInfoListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserInfoListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfUserService">
    <wsdl:port name="BasicHttpBinding_User" binding="tns:BasicHttpBinding_User">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services86/User.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

