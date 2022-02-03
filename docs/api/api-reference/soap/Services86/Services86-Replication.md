---
generated: 1
uid: wsdl-Services86-Replication
title: Services86.ReplicationAgent WSDL
---

# Services86.ReplicationAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfReplicationService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services86" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services86" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services86" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultSatellite">
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
      <xs:element name="CreateDefaultSatelliteResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Satellite" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Satellite">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="SatelliteId" type="xs:int" />
              <xs:element minOccurs="0" name="Created" type="xs:dateTime" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="Contact" nillable="true" type="tns:Contact" />
              <xs:element minOccurs="0" name="Area" nillable="true" type="tns:Area" />
              <xs:element minOccurs="0" name="LicenseOwners" nillable="true" type="tns:ArrayOfLicenseOwner" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Satellite" nillable="true" type="tns:Satellite" />
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
      <xs:complexType name="Contact">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OrgNr" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Department" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="URL" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="City" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DirectPhone" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="CountryId" type="xs:int" />
              <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Kananame" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EmailAddressName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="URLName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="BusinessName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CategoryName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CountryName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Address" nillable="true" type="tns:Address" />
              <xs:element minOccurs="0" name="FormattedAddress" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsOwnerContact" type="xs:boolean" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Contact" nillable="true" type="tns:Contact" />
      <xs:complexType name="Address">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Wgs84Latitude" type="xs:double" />
              <xs:element minOccurs="0" name="Wgs84Longitude" type="xs:double" />
              <xs:element minOccurs="0" name="LocalizedAddress" nillable="true" type="tns:ArrayOfArrayOfLocalizedField" />
              <xs:element minOccurs="0" name="Street" nillable="true" type="tns:StructuredAddress" />
              <xs:element minOccurs="0" name="Postal" nillable="true" type="tns:StructuredAddress" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Address" nillable="true" type="tns:Address" />
      <xs:complexType name="ArrayOfArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArrayOfLocalizedField" nillable="true" type="tns:ArrayOfLocalizedField" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArrayOfLocalizedField" nillable="true" type="tns:ArrayOfArrayOfLocalizedField" />
      <xs:complexType name="ArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="LocalizedField" nillable="true" type="tns:LocalizedField" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLocalizedField" nillable="true" type="tns:ArrayOfLocalizedField" />
      <xs:complexType name="LocalizedField">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Label" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ValueLength" type="xs:int" />
              <xs:element minOccurs="0" name="AddressType" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="LocalizedField" nillable="true" type="tns:LocalizedField" />
      <xs:complexType name="StructuredAddress">
        <xs:sequence>
          <xs:element minOccurs="0" name="AtypeIdx" type="tns:AddressType" />
          <xs:element minOccurs="0" name="Address1" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Address2" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Address3" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="City" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="County" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="State" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Zipcode" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="StructuredAddress" nillable="true" type="tns:StructuredAddress" />
      <xs:simpleType name="AddressType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="ContactPostalAddress" />
          <xs:enumeration value="ContactStreetAddress" />
          <xs:enumeration value="PersonPrivateAddress">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">16387</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="QuoteBillingAddress">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">8196</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="QuoteShippingAddress">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">8197</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="AddressType" nillable="true" type="tns:AddressType" />
      <xs:complexType name="Area">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="AreaId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MaxDataAge" type="xs:short" />
              <xs:element minOccurs="0" name="NumberOfUsers" type="xs:int" />
              <xs:element minOccurs="0" name="NumberOfLogins" type="xs:int" />
              <xs:element minOccurs="0" name="FreetextEnabeled" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Area" nillable="true" type="tns:Area" />
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
      <xs:element name="SaveSatellite">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Satellite" nillable="true" type="tns:Satellite" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveSatelliteResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Satellite" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetArea">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AreaId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAreaResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Area" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetFreetextSearchEnabledOnArea">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AreaId" type="xs:int" />
            <xs:element minOccurs="0" name="FreetextEnabled" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetFreetextSearchEnabledOnAreaResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAreaList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AreaIds" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAreaListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfArea" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfArea">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Area" nillable="true" type="tns:Area" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArea" nillable="true" type="tns:ArrayOfArea" />
      <xs:element name="GetSatellite">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SatelliteId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSatelliteResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Satellite" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCentralLicense">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCentralLicenseResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfLicenseOwner" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCentralLicense">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="License" nillable="true" type="tns:ArrayOfLicenseOwner" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCentralLicenseResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfLicenseOwner" />
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
  <wsdl:message name="CreateDefaultSatelliteRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultSatellite" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSatelliteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSatelliteResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultSatelliteResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSatelliteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSatelliteRequest">
    <wsdl:part name="parameters" element="tns:SaveSatellite" />
  </wsdl:message>
  <wsdl:message name="SaveSatelliteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSatelliteResponse">
    <wsdl:part name="parameters" element="tns:SaveSatelliteResponse" />
  </wsdl:message>
  <wsdl:message name="SaveSatelliteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAreaRequest">
    <wsdl:part name="parameters" element="tns:GetArea" />
  </wsdl:message>
  <wsdl:message name="GetAreaRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAreaResponse">
    <wsdl:part name="parameters" element="tns:GetAreaResponse" />
  </wsdl:message>
  <wsdl:message name="GetAreaResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetFreetextSearchEnabledOnAreaRequest">
    <wsdl:part name="parameters" element="tns:SetFreetextSearchEnabledOnArea" />
  </wsdl:message>
  <wsdl:message name="SetFreetextSearchEnabledOnAreaRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetFreetextSearchEnabledOnAreaResponse">
    <wsdl:part name="parameters" element="tns:SetFreetextSearchEnabledOnAreaResponse" />
  </wsdl:message>
  <wsdl:message name="SetFreetextSearchEnabledOnAreaResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAreaListRequest">
    <wsdl:part name="parameters" element="tns:GetAreaList" />
  </wsdl:message>
  <wsdl:message name="GetAreaListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAreaListResponse">
    <wsdl:part name="parameters" element="tns:GetAreaListResponse" />
  </wsdl:message>
  <wsdl:message name="GetAreaListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSatelliteRequest">
    <wsdl:part name="parameters" element="tns:GetSatellite" />
  </wsdl:message>
  <wsdl:message name="GetSatelliteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSatelliteResponse">
    <wsdl:part name="parameters" element="tns:GetSatelliteResponse" />
  </wsdl:message>
  <wsdl:message name="GetSatelliteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCentralLicenseRequest">
    <wsdl:part name="parameters" element="tns:GetCentralLicense" />
  </wsdl:message>
  <wsdl:message name="GetCentralLicenseRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCentralLicenseResponse">
    <wsdl:part name="parameters" element="tns:GetCentralLicenseResponse" />
  </wsdl:message>
  <wsdl:message name="GetCentralLicenseResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCentralLicenseRequest">
    <wsdl:part name="parameters" element="tns:SaveCentralLicense" />
  </wsdl:message>
  <wsdl:message name="SaveCentralLicenseRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCentralLicenseResponse">
    <wsdl:part name="parameters" element="tns:SaveCentralLicenseResponse" />
  </wsdl:message>
  <wsdl:message name="SaveCentralLicenseResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Replication">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Replication</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultSatellite">
      <wsdl:documentation>
        <summary>Loading default values into a new Satellite.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/CreateDefaultSatellite" name="CreateDefaultSatelliteRequest" message="tns:CreateDefaultSatelliteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/CreateDefaultSatelliteResponse" name="CreateDefaultSatelliteResponse" message="tns:CreateDefaultSatelliteResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveSatellite">
      <wsdl:documentation>
        <summary>Updates the existing Satellite or creates a new Satellite if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/SaveSatellite" name="SaveSatelliteRequest" message="tns:SaveSatelliteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/SaveSatelliteResponse" name="SaveSatelliteResponse" message="tns:SaveSatelliteResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetArea">
      <wsdl:documentation>
        <summary>Gets a Area object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/GetArea" name="GetAreaRequest" message="tns:GetAreaRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/GetAreaResponse" name="GetAreaResponse" message="tns:GetAreaResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetFreetextSearchEnabledOnArea">
      <wsdl:documentation>
        <summary>Enable freetext search on this area</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/SetFreetextSearchEnabledOnArea" name="SetFreetextSearchEnabledOnAreaRequest" message="tns:SetFreetextSearchEnabledOnAreaRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/SetFreetextSearchEnabledOnAreaResponse" name="SetFreetextSearchEnabledOnAreaResponse" message="tns:SetFreetextSearchEnabledOnAreaResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAreaList">
      <wsdl:documentation>
        <summary>Gets an array of Area objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/GetAreaList" name="GetAreaListRequest" message="tns:GetAreaListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/GetAreaListResponse" name="GetAreaListResponse" message="tns:GetAreaListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSatellite">
      <wsdl:documentation>
        <summary>Gets a Satellite object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/GetSatellite" name="GetSatelliteRequest" message="tns:GetSatelliteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/GetSatelliteResponse" name="GetSatelliteResponse" message="tns:GetSatelliteResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCentralLicense">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/GetCentralLicense" name="GetCentralLicenseRequest" message="tns:GetCentralLicenseRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/GetCentralLicenseResponse" name="GetCentralLicenseResponse" message="tns:GetCentralLicenseResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveCentralLicense">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/SaveCentralLicense" name="SaveCentralLicenseRequest" message="tns:SaveCentralLicenseRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/SaveCentralLicenseResponse" name="SaveCentralLicenseResponse" message="tns:SaveCentralLicenseResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Replication" type="tns:Replication">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultSatellite">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/CreateDefaultSatellite" style="document" />
      <wsdl:input name="CreateDefaultSatelliteRequest">
        <soap:header message="tns:CreateDefaultSatelliteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultSatelliteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultSatelliteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultSatelliteResponse">
        <soap:header message="tns:CreateDefaultSatelliteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSatelliteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSatelliteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultSatelliteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveSatellite">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/SaveSatellite" style="document" />
      <wsdl:input name="SaveSatelliteRequest">
        <soap:header message="tns:SaveSatelliteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveSatelliteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveSatelliteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveSatelliteResponse">
        <soap:header message="tns:SaveSatelliteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveSatelliteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveSatelliteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveSatelliteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetArea">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/GetArea" style="document" />
      <wsdl:input name="GetAreaRequest">
        <soap:header message="tns:GetAreaRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAreaRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAreaRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAreaResponse">
        <soap:header message="tns:GetAreaResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAreaResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAreaResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAreaResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetFreetextSearchEnabledOnArea">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/SetFreetextSearchEnabledOnArea" style="document" />
      <wsdl:input name="SetFreetextSearchEnabledOnAreaRequest">
        <soap:header message="tns:SetFreetextSearchEnabledOnAreaRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetFreetextSearchEnabledOnAreaRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetFreetextSearchEnabledOnAreaRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetFreetextSearchEnabledOnAreaResponse">
        <soap:header message="tns:SetFreetextSearchEnabledOnAreaResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetFreetextSearchEnabledOnAreaResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetFreetextSearchEnabledOnAreaResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetFreetextSearchEnabledOnAreaResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAreaList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/GetAreaList" style="document" />
      <wsdl:input name="GetAreaListRequest">
        <soap:header message="tns:GetAreaListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAreaListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAreaListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAreaListResponse">
        <soap:header message="tns:GetAreaListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAreaListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAreaListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAreaListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSatellite">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/GetSatellite" style="document" />
      <wsdl:input name="GetSatelliteRequest">
        <soap:header message="tns:GetSatelliteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSatelliteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSatelliteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSatelliteResponse">
        <soap:header message="tns:GetSatelliteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSatelliteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSatelliteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSatelliteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCentralLicense">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/GetCentralLicense" style="document" />
      <wsdl:input name="GetCentralLicenseRequest">
        <soap:header message="tns:GetCentralLicenseRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCentralLicenseRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCentralLicenseRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCentralLicenseResponse">
        <soap:header message="tns:GetCentralLicenseResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCentralLicenseResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCentralLicenseResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCentralLicenseResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveCentralLicense">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Replication/SaveCentralLicense" style="document" />
      <wsdl:input name="SaveCentralLicenseRequest">
        <soap:header message="tns:SaveCentralLicenseRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveCentralLicenseRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveCentralLicenseRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveCentralLicenseResponse">
        <soap:header message="tns:SaveCentralLicenseResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveCentralLicenseResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveCentralLicenseResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveCentralLicenseResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfReplicationService">
    <wsdl:port name="BasicHttpBinding_Replication" binding="tns:BasicHttpBinding_Replication">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services86/Replication.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

