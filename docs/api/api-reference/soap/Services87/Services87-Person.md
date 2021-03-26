---
Generated: 1
TOCExclude: 1
title: Services87.PersonAgent WSDL
---

# Services87.PersonAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfPersonService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultPersonEntity">
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
      <xs:element name="CreateDefaultPersonEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PersonEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="PersonEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Firstname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MiddleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Lastname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Mrmrs" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="BirthDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="Emails" nillable="true" type="tns:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsAssociate" type="xs:boolean" />
              <xs:element minOccurs="0" name="PrivatePhones" nillable="true" type="tns:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Faxes" nillable="true" type="tns:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="MobilePhones" nillable="true" type="tns:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="OfficePhones" nillable="true" type="tns:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="OtherPhones" nillable="true" type="tns:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Position" nillable="true" type="tns:Position" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="Contact" nillable="true" type="tns:Contact" />
              <xs:element minOccurs="0" name="Country" nillable="true" type="tns:Country" />
              <xs:element minOccurs="0" name="Interests" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
              <xs:element minOccurs="0" name="PersonNumber" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="NoMailing" type="xs:boolean" />
              <xs:element minOccurs="0" name="UsePersonAddress" type="xs:boolean" />
              <xs:element minOccurs="0" name="Retired" type="xs:boolean" />
              <xs:element minOccurs="0" name="Urls" nillable="true" type="tns:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="FormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Address" nillable="true" type="tns:Address" />
              <xs:element minOccurs="0" name="Post3" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Post2" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Post1" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Kanalname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Kanafname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CorrespondingAssociate" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="Category" nillable="true" type="tns:Category" />
              <xs:element minOccurs="0" name="Business" nillable="true" type="tns:Business" />
              <xs:element minOccurs="0" name="Associate" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="Salutation" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ActiveInterests" type="xs:int" />
              <xs:element minOccurs="0" name="SupportAssociate" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="TicketPriority" nillable="true" type="tns:TicketPriority" />
              <xs:element minOccurs="0" name="CustomerLanguage" nillable="true" type="tns:CustomerLanguage" />
              <xs:element minOccurs="0" name="DbiAgentId" type="xs:int" />
              <xs:element minOccurs="0" name="DbiKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DbiLastModified" type="xs:dateTime" />
              <xs:element minOccurs="0" name="DbiLastSyncronized" type="xs:dateTime" />
              <xs:element minOccurs="0" name="SentInfo" type="xs:short" />
              <xs:element minOccurs="0" name="ShowContactTickets" type="xs:short" />
              <xs:element minOccurs="0" name="UserInfo" nillable="true" type="tns:UserInfo" />
              <xs:element minOccurs="0" name="ChatEmails" nillable="true" type="tns:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="InternetPhones" nillable="true" type="tns:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Source" type="xs:short" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="ShipmentTypes" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
              <xs:element minOccurs="0" name="Consents" nillable="true" type="tns:ArrayOfConsentInfo" />
              <xs:element minOccurs="0" name="UserDefinedFields" nillable="true" type="tns:StringDictionary" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="tns:StringDictionary" />
              <xs:element minOccurs="0" name="CustomFields" nillable="true" type="tns:StringDictionary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PersonEntity" nillable="true" type="tns:PersonEntity" />
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
      <xs:complexType name="ArrayOfEntityElement">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="EntityElement" nillable="true" type="tns:EntityElement" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfEntityElement" nillable="true" type="tns:ArrayOfEntityElement" />
      <xs:complexType name="EntityElement">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StrippedValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EntityElement" nillable="true" type="tns:EntityElement" />
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
              <xs:element minOccurs="0" name="Formatted" nillable="true" type="xs:string" />
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
          <xs:element minOccurs="0" name="Formatted" nillable="true" type="xs:string" />
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
              <xs:element minOccurs="0" name="GrantedLicenses" nillable="true" type="q1:ArrayOfstring" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
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
      <xs:complexType name="ArrayOfConsentInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ConsentInfo" nillable="true" type="tns:ConsentInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfConsentInfo" nillable="true" type="tns:ArrayOfConsentInfo" />
      <xs:complexType name="ConsentInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ConsentPersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Comment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RegisteredAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="LegalBaseId" type="xs:int" />
              <xs:element minOccurs="0" name="LegalBaseKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="LegalBaseName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ConsentPurposeId" type="xs:int" />
              <xs:element minOccurs="0" name="ConsentPurposeKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ConsentPurposeName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ConsentSourceId" type="xs:int" />
              <xs:element minOccurs="0" name="ConsentSourceKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ConsentSourceName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ConsentInfo" nillable="true" type="tns:ConsentInfo" />
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
      <xs:element name="SavePersonEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonEntity" nillable="true" type="tns:PersonEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SavePersonEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PersonEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeletePersonEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeletePersonEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultConsentPerson">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultConsentPersonResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ConsentPerson" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ConsentPerson">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ConsentPersonId" type="xs:int" />
              <xs:element minOccurs="0" name="ConsentSource" nillable="true" type="tns:ConsentSource" />
              <xs:element minOccurs="0" name="LegalBase" nillable="true" type="tns:LegalBase" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="ConsentPurpose" nillable="true" type="tns:ConsentPurpose" />
              <xs:element minOccurs="0" name="Comment" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ConsentPerson" nillable="true" type="tns:ConsentPerson" />
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
      <xs:element name="SaveConsentPerson">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConsentPerson" nillable="true" type="tns:ConsentPerson" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveConsentPersonResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ConsentPerson" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteConsentPerson">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConsentPersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteConsentPersonResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPerson">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Person" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
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
              <xs:element minOccurs="0" name="CategoryName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Person" nillable="true" type="tns:Person" />
      <xs:element name="GetPersonEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PersonEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Undelete">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UndeleteResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyPerson">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyPersonResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PersonEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSalesRep">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PersonFirstname" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PersonLastname" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PhoneNumber" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSalesRepResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PersonEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPhones">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPhonesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfEntityElement" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeCountry">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonEntity" nillable="true" type="tns:PersonEntity" />
            <xs:element minOccurs="0" name="ToCountryId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeCountryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PersonEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAddress">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAddressResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Address" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAddressByCountry">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="CountryId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAddressByCountryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Address" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonImageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetPersonImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="Image" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetPersonImageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultByContactId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultByContactIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PersonEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Move">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="DestinationContactId" type="xs:int" />
            <xs:element minOccurs="0" name="MoveAfterDate" type="xs:dateTime" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MoveResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="Merge">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SourcePersonId" type="xs:int" />
            <xs:element minOccurs="0" name="DestinationPersonId" type="xs:int" />
            <xs:element minOccurs="0" name="MoveAfterDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="DeleteSource" type="xs:boolean" />
            <xs:element minOccurs="0" name="ReplaceEmptyFieldsOnDestination" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MergeResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultFromCredential">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="CredentialType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="CredentialValue" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="CredentialDisplayValue" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultFromCredentialResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PersonEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="IsNumberValid">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="Number" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="IsNumberValidResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetConsent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="Purpose" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="LegalBase" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Comment" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetConsentResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveConsent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="Purpose" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveConsentResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="HasConsent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="Purpose" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="HasConsentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConsentInfos">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConsentInfosResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfConsentInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SendConsentConfirmationEmail">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="EmailTemplateId" type="xs:int" />
            <xs:element minOccurs="0" name="CultureLcidId" type="xs:int" />
            <xs:element minOccurs="0" name="Subject" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SendConsentConfirmationEmailResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ResolvePersonFromInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="PersonName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PhoneNumbers" nillable="true" type="q2:ArrayOfstring" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Emails" nillable="true" type="q3:ArrayOfstring" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ResolvePersonFromInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ResolvedPerson" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ResolvedPerson">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Person" nillable="true" type="tns:PersonEntity" />
              <xs:element minOccurs="0" name="PersonCreated" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ResolvedPerson" nillable="true" type="tns:ResolvedPerson" />
      <xs:element name="AddEmailAddressToPerson">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="SetAsPrimaryEmail" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddEmailAddressToPersonResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTemporaryKey">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Domain" type="tns:TemporaryKeyDomain" />
            <xs:element minOccurs="0" name="TargetId" type="xs:int" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="Expires" type="xs:dateTime" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="TemporaryKeyDomain">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="MailingRecipient" />
          <xs:enumeration value="FormSubmitterRecipient" />
          <xs:enumeration value="ViewTicketInCustomerCenter" />
          <xs:enumeration value="LoginCustomerCenter" />
          <xs:enumeration value="PublicFaq" />
          <xs:enumeration value="ChangePasswordCustomerCenter" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TemporaryKeyDomain" nillable="true" type="tns:TemporaryKeyDomain" />
      <xs:element name="CreateTemporaryKeyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CheckTemporaryKey">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TemporaryKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CheckTemporaryKeyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TemporaryKeyInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="TemporaryKeyInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Domain" type="tns:TemporaryKeyDomain" />
              <xs:element minOccurs="0" name="TargetId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="IsExpired" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TemporaryKeyInfo" nillable="true" type="tns:TemporaryKeyInfo" />
      <xs:element name="DeleteTemporaryKeysOfDomain">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Domain" type="tns:TemporaryKeyDomain" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteTemporaryKeysOfDomainResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteExpired">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteExpiredResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonSummary">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="Limit" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonSummaryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PersonSummary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="PersonSummary">
        <xs:sequence>
          <xs:element minOccurs="0" name="Person" nillable="true" type="tns:Person" />
          <xs:element minOccurs="0" name="Tickets" nillable="true" type="tns:ArrayOfTicketSummaryItem" />
          <xs:element minOccurs="0" name="Followups" nillable="true" type="tns:ArrayOfActivitySummaryItem" />
          <xs:element minOccurs="0" name="Documents" nillable="true" type="tns:ArrayOfActivitySummaryItem" />
          <xs:element minOccurs="0" name="Sales" nillable="true" type="tns:ArrayOfSaleSummaryItem" />
          <xs:element minOccurs="0" name="Chats" nillable="true" type="tns:ArrayOfChatSummaryItem" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="PersonSummary" nillable="true" type="tns:PersonSummary" />
      <xs:complexType name="ArrayOfTicketSummaryItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TicketSummaryItem" nillable="true" type="tns:TicketSummaryItem" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTicketSummaryItem" nillable="true" type="tns:ArrayOfTicketSummaryItem" />
      <xs:complexType name="TicketSummaryItem">
        <xs:sequence>
          <xs:element minOccurs="0" name="TicketId" type="xs:int" />
          <xs:element minOccurs="0" name="TicketStatus" type="xs:int" />
          <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TicketSummaryItem" nillable="true" type="tns:TicketSummaryItem" />
      <xs:complexType name="ArrayOfActivitySummaryItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ActivitySummaryItem" nillable="true" type="tns:ActivitySummaryItem" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfActivitySummaryItem" nillable="true" type="tns:ArrayOfActivitySummaryItem" />
      <xs:complexType name="ActivitySummaryItem">
        <xs:sequence>
          <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
          <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          <xs:element minOccurs="0" name="Date" type="xs:dateTime" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Completed" type="tns:ActivityStatus" />
          <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ActivitySummaryItem" nillable="true" type="tns:ActivitySummaryItem" />
      <xs:simpleType name="ActivityStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="NotStarted" />
          <xs:enumeration value="Started" />
          <xs:enumeration value="Completed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ActivityStatus" nillable="true" type="tns:ActivityStatus" />
      <xs:complexType name="ArrayOfSaleSummaryItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="SaleSummaryItem" nillable="true" type="tns:SaleSummaryItem" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfSaleSummaryItem" nillable="true" type="tns:ArrayOfSaleSummaryItem" />
      <xs:complexType name="SaleSummaryItem">
        <xs:sequence>
          <xs:element minOccurs="0" name="SaleId" type="xs:int" />
          <xs:element minOccurs="0" name="SaleDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="Probability" type="xs:short" />
          <xs:element minOccurs="0" name="Heading" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Amount" type="xs:double" />
          <xs:element minOccurs="0" name="Currency" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="AmountInBaseCurrency" type="xs:double" />
          <xs:element minOccurs="0" name="Status" type="tns:SaleStatus" />
          <xs:element minOccurs="0" name="Completed" type="tns:ActivityStatus" />
          <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SaleSummaryItem" nillable="true" type="tns:SaleSummaryItem" />
      <xs:simpleType name="SaleStatus">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Open" />
          <xs:enumeration value="Sold" />
          <xs:enumeration value="Lost" />
          <xs:enumeration value="Stalled" />
          <xs:enumeration value="SaintAll">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1000</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="SaleStatus" nillable="true" type="tns:SaleStatus" />
      <xs:complexType name="ArrayOfChatSummaryItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ChatSummaryItem" nillable="true" type="tns:ChatSummaryItem" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfChatSummaryItem" nillable="true" type="tns:ArrayOfChatSummaryItem" />
      <xs:complexType name="ChatSummaryItem">
        <xs:sequence>
          <xs:element minOccurs="0" name="ChatSessionId" type="xs:int" />
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="CompanyName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FirstMessage" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="LastMessage" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="WhenRequested" type="xs:dateTime" />
          <xs:element minOccurs="0" name="WhenEnded" type="xs:dateTime" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ChatSummaryItem" nillable="true" type="tns:ChatSummaryItem" />
      <xs:element name="AddBounce">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddBounceResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonIds" nillable="true" type="q4:ArrayOfint" xmlns:q4="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPerson" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfPerson">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Person" nillable="true" type="tns:Person" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfPerson" nillable="true" type="tns:ArrayOfPerson" />
      <xs:element name="GetPersonsFromContact">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonsFromContactResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPerson" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonsFromProject">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonsFromProjectResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPerson" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetColleagues">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetColleaguesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPerson" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetColleaguesByDepartment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DepartmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetColleaguesByDepartmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPerson" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetColleaguesBySource">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SourceType" type="tns:AssociateSourceType" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="AssociateSourceType">
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="History" />
              <xs:enumeration value="DiaryViewList" />
              <xs:enumeration value="Department" />
              <xs:enumeration value="UndefinedValue8" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="AssociateSourceType" nillable="true" type="tns:AssociateSourceType" />
      <xs:element name="GetColleaguesBySourceResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPerson" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyOwner">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyOwnerResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Person" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetOwnerOnPersonId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetOwnerOnPersonIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Person" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangePersonRank">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="MoveUp" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangePersonRankResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetPersonRank">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="DesiredRank" type="xs:short" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetPersonRankResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="NormalizeRanks">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="NormalizeRanksResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConsentPerson">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConsentPersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConsentPersonResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ConsentPerson" />
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
      <xs:complexType name="ArrayOfint">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="int" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfint" nillable="true" type="tns:ArrayOfint" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="CreateDefaultPersonEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultPersonEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultPersonEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultPersonEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultPersonEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultPersonEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SavePersonEntityRequest">
    <wsdl:part name="parameters" element="tns:SavePersonEntity" />
  </wsdl:message>
  <wsdl:message name="SavePersonEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SavePersonEntityResponse">
    <wsdl:part name="parameters" element="tns:SavePersonEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SavePersonEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeletePersonEntityRequest">
    <wsdl:part name="parameters" element="tns:DeletePersonEntity" />
  </wsdl:message>
  <wsdl:message name="DeletePersonEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeletePersonEntityResponse">
    <wsdl:part name="parameters" element="tns:DeletePersonEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeletePersonEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultConsentPersonRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultConsentPerson" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultConsentPersonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultConsentPersonResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultConsentPersonResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultConsentPersonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveConsentPersonRequest">
    <wsdl:part name="parameters" element="tns:SaveConsentPerson" />
  </wsdl:message>
  <wsdl:message name="SaveConsentPersonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveConsentPersonResponse">
    <wsdl:part name="parameters" element="tns:SaveConsentPersonResponse" />
  </wsdl:message>
  <wsdl:message name="SaveConsentPersonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteConsentPersonRequest">
    <wsdl:part name="parameters" element="tns:DeleteConsentPerson" />
  </wsdl:message>
  <wsdl:message name="DeleteConsentPersonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteConsentPersonResponse">
    <wsdl:part name="parameters" element="tns:DeleteConsentPersonResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteConsentPersonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonRequest">
    <wsdl:part name="parameters" element="tns:GetPerson" />
  </wsdl:message>
  <wsdl:message name="GetPersonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonResponse">
    <wsdl:part name="parameters" element="tns:GetPersonResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonEntityRequest">
    <wsdl:part name="parameters" element="tns:GetPersonEntity" />
  </wsdl:message>
  <wsdl:message name="GetPersonEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonEntityResponse">
    <wsdl:part name="parameters" element="tns:GetPersonEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UndeleteRequest">
    <wsdl:part name="parameters" element="tns:Undelete" />
  </wsdl:message>
  <wsdl:message name="UndeleteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UndeleteResponse">
    <wsdl:part name="parameters" element="tns:UndeleteResponse" />
  </wsdl:message>
  <wsdl:message name="UndeleteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyPersonRequest">
    <wsdl:part name="parameters" element="tns:GetMyPerson" />
  </wsdl:message>
  <wsdl:message name="GetMyPersonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyPersonResponse">
    <wsdl:part name="parameters" element="tns:GetMyPersonResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyPersonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSalesRepRequest">
    <wsdl:part name="parameters" element="tns:GetSalesRep" />
  </wsdl:message>
  <wsdl:message name="GetSalesRepRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSalesRepResponse">
    <wsdl:part name="parameters" element="tns:GetSalesRepResponse" />
  </wsdl:message>
  <wsdl:message name="GetSalesRepResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPhonesRequest">
    <wsdl:part name="parameters" element="tns:GetPhones" />
  </wsdl:message>
  <wsdl:message name="GetPhonesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPhonesResponse">
    <wsdl:part name="parameters" element="tns:GetPhonesResponse" />
  </wsdl:message>
  <wsdl:message name="GetPhonesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeCountryRequest">
    <wsdl:part name="parameters" element="tns:ChangeCountry" />
  </wsdl:message>
  <wsdl:message name="ChangeCountryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeCountryResponse">
    <wsdl:part name="parameters" element="tns:ChangeCountryResponse" />
  </wsdl:message>
  <wsdl:message name="ChangeCountryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAddressRequest">
    <wsdl:part name="parameters" element="tns:GetAddress" />
  </wsdl:message>
  <wsdl:message name="GetAddressRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAddressResponse">
    <wsdl:part name="parameters" element="tns:GetAddressResponse" />
  </wsdl:message>
  <wsdl:message name="GetAddressResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAddressByCountryRequest">
    <wsdl:part name="parameters" element="tns:GetAddressByCountry" />
  </wsdl:message>
  <wsdl:message name="GetAddressByCountryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAddressByCountryResponse">
    <wsdl:part name="parameters" element="tns:GetAddressByCountryResponse" />
  </wsdl:message>
  <wsdl:message name="GetAddressByCountryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonImageRequest">
    <wsdl:part name="parameters" element="tns:GetPersonImage" />
  </wsdl:message>
  <wsdl:message name="GetPersonImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonImageResponse">
    <wsdl:part name="parameters" element="tns:GetPersonImageResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetPersonImageRequest">
    <wsdl:part name="parameters" element="tns:SetPersonImage" />
  </wsdl:message>
  <wsdl:message name="SetPersonImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetPersonImageResponse">
    <wsdl:part name="parameters" element="tns:SetPersonImageResponse" />
  </wsdl:message>
  <wsdl:message name="SetPersonImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultByContactIdRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultByContactId" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultByContactIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultByContactIdResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultByContactIdResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultByContactIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveRequest">
    <wsdl:part name="parameters" element="tns:Move" />
  </wsdl:message>
  <wsdl:message name="MoveRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveResponse">
    <wsdl:part name="parameters" element="tns:MoveResponse" />
  </wsdl:message>
  <wsdl:message name="MoveResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MergeRequest">
    <wsdl:part name="parameters" element="tns:Merge" />
  </wsdl:message>
  <wsdl:message name="MergeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MergeResponse">
    <wsdl:part name="parameters" element="tns:MergeResponse" />
  </wsdl:message>
  <wsdl:message name="MergeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultFromCredentialRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultFromCredential" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultFromCredentialRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultFromCredentialResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultFromCredentialResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultFromCredentialResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsNumberValidRequest">
    <wsdl:part name="parameters" element="tns:IsNumberValid" />
  </wsdl:message>
  <wsdl:message name="IsNumberValidRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsNumberValidResponse">
    <wsdl:part name="parameters" element="tns:IsNumberValidResponse" />
  </wsdl:message>
  <wsdl:message name="IsNumberValidResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetConsentRequest">
    <wsdl:part name="parameters" element="tns:SetConsent" />
  </wsdl:message>
  <wsdl:message name="SetConsentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetConsentResponse">
    <wsdl:part name="parameters" element="tns:SetConsentResponse" />
  </wsdl:message>
  <wsdl:message name="SetConsentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveConsentRequest">
    <wsdl:part name="parameters" element="tns:RemoveConsent" />
  </wsdl:message>
  <wsdl:message name="RemoveConsentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveConsentResponse">
    <wsdl:part name="parameters" element="tns:RemoveConsentResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveConsentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasConsentRequest">
    <wsdl:part name="parameters" element="tns:HasConsent" />
  </wsdl:message>
  <wsdl:message name="HasConsentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasConsentResponse">
    <wsdl:part name="parameters" element="tns:HasConsentResponse" />
  </wsdl:message>
  <wsdl:message name="HasConsentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConsentInfosRequest">
    <wsdl:part name="parameters" element="tns:GetConsentInfos" />
  </wsdl:message>
  <wsdl:message name="GetConsentInfosRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConsentInfosResponse">
    <wsdl:part name="parameters" element="tns:GetConsentInfosResponse" />
  </wsdl:message>
  <wsdl:message name="GetConsentInfosResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendConsentConfirmationEmailRequest">
    <wsdl:part name="parameters" element="tns:SendConsentConfirmationEmail" />
  </wsdl:message>
  <wsdl:message name="SendConsentConfirmationEmailRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendConsentConfirmationEmailResponse">
    <wsdl:part name="parameters" element="tns:SendConsentConfirmationEmailResponse" />
  </wsdl:message>
  <wsdl:message name="SendConsentConfirmationEmailResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ResolvePersonFromInfoRequest">
    <wsdl:part name="parameters" element="tns:ResolvePersonFromInfo" />
  </wsdl:message>
  <wsdl:message name="ResolvePersonFromInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ResolvePersonFromInfoResponse">
    <wsdl:part name="parameters" element="tns:ResolvePersonFromInfoResponse" />
  </wsdl:message>
  <wsdl:message name="ResolvePersonFromInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddEmailAddressToPersonRequest">
    <wsdl:part name="parameters" element="tns:AddEmailAddressToPerson" />
  </wsdl:message>
  <wsdl:message name="AddEmailAddressToPersonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddEmailAddressToPersonResponse">
    <wsdl:part name="parameters" element="tns:AddEmailAddressToPersonResponse" />
  </wsdl:message>
  <wsdl:message name="AddEmailAddressToPersonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryKeyRequest">
    <wsdl:part name="parameters" element="tns:CreateTemporaryKey" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryKeyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryKeyResponse">
    <wsdl:part name="parameters" element="tns:CreateTemporaryKeyResponse" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryKeyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CheckTemporaryKeyRequest">
    <wsdl:part name="parameters" element="tns:CheckTemporaryKey" />
  </wsdl:message>
  <wsdl:message name="CheckTemporaryKeyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CheckTemporaryKeyResponse">
    <wsdl:part name="parameters" element="tns:CheckTemporaryKeyResponse" />
  </wsdl:message>
  <wsdl:message name="CheckTemporaryKeyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteTemporaryKeysOfDomainRequest">
    <wsdl:part name="parameters" element="tns:DeleteTemporaryKeysOfDomain" />
  </wsdl:message>
  <wsdl:message name="DeleteTemporaryKeysOfDomainRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteTemporaryKeysOfDomainResponse">
    <wsdl:part name="parameters" element="tns:DeleteTemporaryKeysOfDomainResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteTemporaryKeysOfDomainResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteExpiredRequest">
    <wsdl:part name="parameters" element="tns:DeleteExpired" />
  </wsdl:message>
  <wsdl:message name="DeleteExpiredRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteExpiredResponse">
    <wsdl:part name="parameters" element="tns:DeleteExpiredResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteExpiredResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonSummaryRequest">
    <wsdl:part name="parameters" element="tns:GetPersonSummary" />
  </wsdl:message>
  <wsdl:message name="GetPersonSummaryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonSummaryResponse">
    <wsdl:part name="parameters" element="tns:GetPersonSummaryResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonSummaryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddBounceRequest">
    <wsdl:part name="parameters" element="tns:AddBounce" />
  </wsdl:message>
  <wsdl:message name="AddBounceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddBounceResponse">
    <wsdl:part name="parameters" element="tns:AddBounceResponse" />
  </wsdl:message>
  <wsdl:message name="AddBounceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonListRequest">
    <wsdl:part name="parameters" element="tns:GetPersonList" />
  </wsdl:message>
  <wsdl:message name="GetPersonListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonListResponse">
    <wsdl:part name="parameters" element="tns:GetPersonListResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonsFromContactRequest">
    <wsdl:part name="parameters" element="tns:GetPersonsFromContact" />
  </wsdl:message>
  <wsdl:message name="GetPersonsFromContactRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonsFromContactResponse">
    <wsdl:part name="parameters" element="tns:GetPersonsFromContactResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonsFromContactResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonsFromProjectRequest">
    <wsdl:part name="parameters" element="tns:GetPersonsFromProject" />
  </wsdl:message>
  <wsdl:message name="GetPersonsFromProjectRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonsFromProjectResponse">
    <wsdl:part name="parameters" element="tns:GetPersonsFromProjectResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonsFromProjectResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetColleaguesRequest">
    <wsdl:part name="parameters" element="tns:GetColleagues" />
  </wsdl:message>
  <wsdl:message name="GetColleaguesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetColleaguesResponse">
    <wsdl:part name="parameters" element="tns:GetColleaguesResponse" />
  </wsdl:message>
  <wsdl:message name="GetColleaguesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetColleaguesByDepartmentRequest">
    <wsdl:part name="parameters" element="tns:GetColleaguesByDepartment" />
  </wsdl:message>
  <wsdl:message name="GetColleaguesByDepartmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetColleaguesByDepartmentResponse">
    <wsdl:part name="parameters" element="tns:GetColleaguesByDepartmentResponse" />
  </wsdl:message>
  <wsdl:message name="GetColleaguesByDepartmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetColleaguesBySourceRequest">
    <wsdl:part name="parameters" element="tns:GetColleaguesBySource" />
  </wsdl:message>
  <wsdl:message name="GetColleaguesBySourceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetColleaguesBySourceResponse">
    <wsdl:part name="parameters" element="tns:GetColleaguesBySourceResponse" />
  </wsdl:message>
  <wsdl:message name="GetColleaguesBySourceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyOwnerRequest">
    <wsdl:part name="parameters" element="tns:GetMyOwner" />
  </wsdl:message>
  <wsdl:message name="GetMyOwnerRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyOwnerResponse">
    <wsdl:part name="parameters" element="tns:GetMyOwnerResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyOwnerResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetOwnerOnPersonIdRequest">
    <wsdl:part name="parameters" element="tns:GetOwnerOnPersonId" />
  </wsdl:message>
  <wsdl:message name="GetOwnerOnPersonIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetOwnerOnPersonIdResponse">
    <wsdl:part name="parameters" element="tns:GetOwnerOnPersonIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetOwnerOnPersonIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangePersonRankRequest">
    <wsdl:part name="parameters" element="tns:ChangePersonRank" />
  </wsdl:message>
  <wsdl:message name="ChangePersonRankRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangePersonRankResponse">
    <wsdl:part name="parameters" element="tns:ChangePersonRankResponse" />
  </wsdl:message>
  <wsdl:message name="ChangePersonRankResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetPersonRankRequest">
    <wsdl:part name="parameters" element="tns:SetPersonRank" />
  </wsdl:message>
  <wsdl:message name="SetPersonRankRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetPersonRankResponse">
    <wsdl:part name="parameters" element="tns:SetPersonRankResponse" />
  </wsdl:message>
  <wsdl:message name="SetPersonRankResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="NormalizeRanksRequest">
    <wsdl:part name="parameters" element="tns:NormalizeRanks" />
  </wsdl:message>
  <wsdl:message name="NormalizeRanksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="NormalizeRanksResponse">
    <wsdl:part name="parameters" element="tns:NormalizeRanksResponse" />
  </wsdl:message>
  <wsdl:message name="NormalizeRanksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConsentPersonRequest">
    <wsdl:part name="parameters" element="tns:GetConsentPerson" />
  </wsdl:message>
  <wsdl:message name="GetConsentPersonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConsentPersonResponse">
    <wsdl:part name="parameters" element="tns:GetConsentPersonResponse" />
  </wsdl:message>
  <wsdl:message name="GetConsentPersonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Person">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Person</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultPersonEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new PersonEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/CreateDefaultPersonEntity" name="CreateDefaultPersonEntityRequest" message="tns:CreateDefaultPersonEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/CreateDefaultPersonEntityResponse" name="CreateDefaultPersonEntityResponse" message="tns:CreateDefaultPersonEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SavePersonEntity">
      <wsdl:documentation>
        <summary>Updates the existing PersonEntity or creates a new PersonEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/SavePersonEntity" name="SavePersonEntityRequest" message="tns:SavePersonEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/SavePersonEntityResponse" name="SavePersonEntityResponse" message="tns:SavePersonEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeletePersonEntity">
      <wsdl:documentation>
        <summary>Deletes the PersonEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/DeletePersonEntity" name="DeletePersonEntityRequest" message="tns:DeletePersonEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/DeletePersonEntityResponse" name="DeletePersonEntityResponse" message="tns:DeletePersonEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultConsentPerson">
      <wsdl:documentation>
        <summary>Loading default values into a new ConsentPerson.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/CreateDefaultConsentPerson" name="CreateDefaultConsentPersonRequest" message="tns:CreateDefaultConsentPersonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/CreateDefaultConsentPersonResponse" name="CreateDefaultConsentPersonResponse" message="tns:CreateDefaultConsentPersonResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveConsentPerson">
      <wsdl:documentation>
        <summary>Updates the existing ConsentPerson or creates a new ConsentPerson if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/SaveConsentPerson" name="SaveConsentPersonRequest" message="tns:SaveConsentPersonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/SaveConsentPersonResponse" name="SaveConsentPersonResponse" message="tns:SaveConsentPersonResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteConsentPerson">
      <wsdl:documentation>
        <summary>Deletes the ConsentPerson</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/DeleteConsentPerson" name="DeleteConsentPersonRequest" message="tns:DeleteConsentPersonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/DeleteConsentPersonResponse" name="DeleteConsentPersonResponse" message="tns:DeleteConsentPersonResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPerson">
      <wsdl:documentation>
        <summary>Gets a Person object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPerson" name="GetPersonRequest" message="tns:GetPersonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonResponse" name="GetPersonResponse" message="tns:GetPersonResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonEntity">
      <wsdl:documentation>
        <summary>Gets a PersonEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonEntity" name="GetPersonEntityRequest" message="tns:GetPersonEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonEntityResponse" name="GetPersonEntityResponse" message="tns:GetPersonEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="Undelete">
      <wsdl:documentation>
        <summary>This entity supports Soft Delete. Call this method to Undelete a previously soft-deleted record</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/Undelete" name="UndeleteRequest" message="tns:UndeleteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/UndeleteResponse" name="UndeleteResponse" message="tns:UndeleteResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyPerson">
      <wsdl:documentation>
        <summary>Gets the person info belonging to the currently logged on user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetMyPerson" name="GetMyPersonRequest" message="tns:GetMyPersonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetMyPersonResponse" name="GetMyPersonResponse" message="tns:GetMyPersonResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSalesRep">
      <wsdl:documentation>
        <summary>Returns the sales representative for an external user. If this method is accessed with anonymous authentication the external user is recognized by contact and name, or by email, or phone number. If the external user is recognized as an CRM5 user (internal or external) the input fields can be left blank.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetSalesRep" name="GetSalesRepRequest" message="tns:GetSalesRepRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetSalesRepResponse" name="GetSalesRepResponse" message="tns:GetSalesRepResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPhones">
      <wsdl:documentation>
        <summary>Returning all phones that belong to a person, ordered by the phone type.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPhones" name="GetPhonesRequest" message="tns:GetPhonesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPhonesResponse" name="GetPhonesResponse" message="tns:GetPhonesResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChangeCountry">
      <wsdl:documentation>
        <summary>Change country regenerates the default values and localized information such as phone number and address format for this entity.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/ChangeCountry" name="ChangeCountryRequest" message="tns:ChangeCountryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/ChangeCountryResponse" name="ChangeCountryResponse" message="tns:ChangeCountryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAddress">
      <wsdl:documentation>
        <summary>Gets the person's localized address.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetAddress" name="GetAddressRequest" message="tns:GetAddressRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetAddressResponse" name="GetAddressResponse" message="tns:GetAddressResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAddressByCountry">
      <wsdl:documentation>
        <summary>Gets the person's localized address.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetAddressByCountry" name="GetAddressByCountryRequest" message="tns:GetAddressByCountryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetAddressByCountryResponse" name="GetAddressByCountryResponse" message="tns:GetAddressByCountryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonImage">
      <wsdl:documentation>
        <summary>Returns the person image that is displayed in the CRM application.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonImage" name="GetPersonImageRequest" message="tns:GetPersonImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonImageResponse" name="GetPersonImageResponse" message="tns:GetPersonImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetPersonImage">
      <wsdl:documentation>
        <summary>Stores the person image that is displayed in the CRM application.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/SetPersonImage" name="SetPersonImageRequest" message="tns:SetPersonImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/SetPersonImageResponse" name="SetPersonImageResponse" message="tns:SetPersonImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultByContactId">
      <wsdl:documentation>
        <summary>Creates a PersonEntity with default values based on the contactId.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/CreateDefaultByContactId" name="CreateDefaultByContactIdRequest" message="tns:CreateDefaultByContactIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/CreateDefaultByContactIdResponse" name="CreateDefaultByContactIdResponse" message="tns:CreateDefaultByContactIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="Move">
      <wsdl:documentation>
        <summary>Move a person to a specified contact. You must specify the date after which activities will be moved along with the person.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/Move" name="MoveRequest" message="tns:MoveRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/MoveResponse" name="MoveResponse" message="tns:MoveResponse" />
    </wsdl:operation>
    <wsdl:operation name="Merge">
      <wsdl:documentation>
        <summary>Merge two persons. The destination person will remain. You must specify the date after which activities will be moved along with the person.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/Merge" name="MergeRequest" message="tns:MergeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/MergeResponse" name="MergeResponse" message="tns:MergeResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultFromCredential">
      <wsdl:documentation>
        <summary>Creates a PersonEntity with default values based on the contactId and credentials.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/CreateDefaultFromCredential" name="CreateDefaultFromCredentialRequest" message="tns:CreateDefaultFromCredentialRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/CreateDefaultFromCredentialResponse" name="CreateDefaultFromCredentialResponse" message="tns:CreateDefaultFromCredentialResponse" />
    </wsdl:operation>
    <wsdl:operation name="IsNumberValid">
      <wsdl:documentation>
        <summary>Checks if the number is unique or required.  The setting is configured from admin under system options.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/IsNumberValid" name="IsNumberValidRequest" message="tns:IsNumberValidRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/IsNumberValidResponse" name="IsNumberValidResponse" message="tns:IsNumberValidResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetConsent">
      <wsdl:documentation>
        <summary>Set a specified type of consent on the person.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/SetConsent" name="SetConsentRequest" message="tns:SetConsentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/SetConsentResponse" name="SetConsentResponse" message="tns:SetConsentResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveConsent">
      <wsdl:documentation>
        <summary>Turn off consent for a specified person and purpose.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/RemoveConsent" name="RemoveConsentRequest" message="tns:RemoveConsentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/RemoveConsentResponse" name="RemoveConsentResponse" message="tns:RemoveConsentResponse" />
    </wsdl:operation>
    <wsdl:operation name="HasConsent">
      <wsdl:documentation>
        <summary>Check if consent has been given by a specified person, for a specific purpose. Withdraw consents return FALSE.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/HasConsent" name="HasConsentRequest" message="tns:HasConsentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/HasConsentResponse" name="HasConsentResponse" message="tns:HasConsentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConsentInfos">
      <wsdl:documentation>
        <summary>Get all consent information for a given person. May include withdrawn consents (check </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetConsentInfos" name="GetConsentInfosRequest" message="tns:GetConsentInfosRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetConsentInfosResponse" name="GetConsentInfosResponse" message="tns:GetConsentInfosResponse" />
    </wsdl:operation>
    <wsdl:operation name="SendConsentConfirmationEmail">
      <wsdl:documentation>
        <summary>Send confirmation email to the provided person, email address (id), using the document template</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/SendConsentConfirmationEmail" name="SendConsentConfirmationEmailRequest" message="tns:SendConsentConfirmationEmailRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/SendConsentConfirmationEmailResponse" name="SendConsentConfirmationEmailResponse" message="tns:SendConsentConfirmationEmailResponse" />
    </wsdl:operation>
    <wsdl:operation name="ResolvePersonFromInfo">
      <wsdl:documentation>
        <summary>Get a person from the provided information. If the person does not exist, it will be created on demand.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/ResolvePersonFromInfo" name="ResolvePersonFromInfoRequest" message="tns:ResolvePersonFromInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/ResolvePersonFromInfoResponse" name="ResolvePersonFromInfoResponse" message="tns:ResolvePersonFromInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddEmailAddressToPerson">
      <wsdl:documentation>
        <summary>Sets the primary email address on person, possibly re-ranking email addresses accordingly.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/AddEmailAddressToPerson" name="AddEmailAddressToPersonRequest" message="tns:AddEmailAddressToPersonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/AddEmailAddressToPersonResponse" name="AddEmailAddressToPersonResponse" message="tns:AddEmailAddressToPersonResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateTemporaryKey">
      <wsdl:documentation>
        <summary>Create a temporary key in the database from the given parameters and return the key string. Used for temporary keys for accessing customer centric functionality, such as UpdateSubscriptions.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/CreateTemporaryKey" name="CreateTemporaryKeyRequest" message="tns:CreateTemporaryKeyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/CreateTemporaryKeyResponse" name="CreateTemporaryKeyResponse" message="tns:CreateTemporaryKeyResponse" />
    </wsdl:operation>
    <wsdl:operation name="CheckTemporaryKey">
      <wsdl:documentation>
        <summary>Check a temporary key for validity, and in case it is valid, return its domain, targetId and personId</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/CheckTemporaryKey" name="CheckTemporaryKeyRequest" message="tns:CheckTemporaryKeyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/CheckTemporaryKeyResponse" name="CheckTemporaryKeyResponse" message="tns:CheckTemporaryKeyResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteTemporaryKeysOfDomain">
      <wsdl:documentation>
        <summary>Delete all temporary keys for a given domain and person</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/DeleteTemporaryKeysOfDomain" name="DeleteTemporaryKeysOfDomainRequest" message="tns:DeleteTemporaryKeysOfDomainRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/DeleteTemporaryKeysOfDomainResponse" name="DeleteTemporaryKeysOfDomainResponse" message="tns:DeleteTemporaryKeysOfDomainResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteExpired">
      <wsdl:documentation>
        <summary>Trigger deletion of persons that has been (soft) deleted and have timed out the expiry period (the SoftDeleteRetention preference).</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/DeleteExpired" name="DeleteExpiredRequest" message="tns:DeleteExpiredRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/DeleteExpiredResponse" name="DeleteExpiredResponse" message="tns:DeleteExpiredResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonSummary">
      <wsdl:documentation>
        <summary>Get summary of person and recent activity.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonSummary" name="GetPersonSummaryRequest" message="tns:GetPersonSummaryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonSummaryResponse" name="GetPersonSummaryResponse" message="tns:GetPersonSummaryResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddBounce">
      <wsdl:documentation>
        <summary>Add a bounce count on the email address if it exists</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/AddBounce" name="AddBounceRequest" message="tns:AddBounceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/AddBounceResponse" name="AddBounceResponse" message="tns:AddBounceResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonList">
      <wsdl:documentation>
        <summary>Gets an array of Person objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonList" name="GetPersonListRequest" message="tns:GetPersonListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonListResponse" name="GetPersonListResponse" message="tns:GetPersonListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonsFromContact">
      <wsdl:documentation>
        <summary>Returns all the persons belonging to a contact.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonsFromContact" name="GetPersonsFromContactRequest" message="tns:GetPersonsFromContactRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonsFromContactResponse" name="GetPersonsFromContactResponse" message="tns:GetPersonsFromContactResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonsFromProject">
      <wsdl:documentation>
        <summary>Returns all the persons belonging to a project.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonsFromProject" name="GetPersonsFromProjectRequest" message="tns:GetPersonsFromProjectRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonsFromProjectResponse" name="GetPersonsFromProjectResponse" message="tns:GetPersonsFromProjectResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetColleagues">
      <wsdl:documentation>
        <summary>Gets the persons working in the same company as the logged on user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetColleagues" name="GetColleaguesRequest" message="tns:GetColleaguesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetColleaguesResponse" name="GetColleaguesResponse" message="tns:GetColleaguesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetColleaguesByDepartment">
      <wsdl:documentation>
        <summary>Gets the persons working in a specific department in the same company as the logged on user. Departments can be retrieved with the PhoneList.DepartmentList service.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetColleaguesByDepartment" name="GetColleaguesByDepartmentRequest" message="tns:GetColleaguesByDepartmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetColleaguesByDepartmentResponse" name="GetColleaguesByDepartmentResponse" message="tns:GetColleaguesByDepartmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetColleaguesBySource">
      <wsdl:documentation>
        <summary>Gets the persons working in the same company as the logged on user. The list of person could be retrieved from the history list, the diary view list, or from all sources.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetColleaguesBySource" name="GetColleaguesBySourceRequest" message="tns:GetColleaguesBySourceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetColleaguesBySourceResponse" name="GetColleaguesBySourceResponse" message="tns:GetColleaguesBySourceResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyOwner">
      <wsdl:documentation>
        <summary>Get the owner of the logged in person.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetMyOwner" name="GetMyOwnerRequest" message="tns:GetMyOwnerRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetMyOwnerResponse" name="GetMyOwnerResponse" message="tns:GetMyOwnerResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetOwnerOnPersonId">
      <wsdl:documentation>
        <summary>Get the owner of the person by id.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetOwnerOnPersonId" name="GetOwnerOnPersonIdRequest" message="tns:GetOwnerOnPersonIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetOwnerOnPersonIdResponse" name="GetOwnerOnPersonIdResponse" message="tns:GetOwnerOnPersonIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChangePersonRank">
      <wsdl:documentation>
        <summary>Move one person up or down in the ranking in the Person Archive, if possible.&lt;para/&gt;The person record that has rank = 1 is the primary contact for a company, and is the one used in situations where no person has been explicitly chosen (such as in selections).&lt;para/&gt;This method corresponds to the move up/move down functions in the person archive in the contact panel.&lt;para/&gt;This method always affects two records.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/ChangePersonRank" name="ChangePersonRankRequest" message="tns:ChangePersonRankRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/ChangePersonRankResponse" name="ChangePersonRankResponse" message="tns:ChangePersonRankResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetPersonRank">
      <wsdl:documentation>
        <summary>Directly set the rank field of a person record, adjusting all other person records under the same contact as needed.&lt;para/&gt;This call may affect multiple records, potentially all person records belonging to one contact.&lt;para/&gt;You must have write access for to affected records for this method to succeed.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/SetPersonRank" name="SetPersonRankRequest" message="tns:SetPersonRankRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/SetPersonRankResponse" name="SetPersonRankResponse" message="tns:SetPersonRankResponse" />
    </wsdl:operation>
    <wsdl:operation name="NormalizeRanks">
      <wsdl:documentation>
        <summary>Nomralize the ranks for all persons that belong to a contact. This means that the persons will be sorted according to their current rank values, and the ranks will be made monotonically increasing from 1.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/NormalizeRanks" name="NormalizeRanksRequest" message="tns:NormalizeRanksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/NormalizeRanksResponse" name="NormalizeRanksResponse" message="tns:NormalizeRanksResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConsentPerson">
      <wsdl:documentation>
        <summary>Gets a ConsentPerson object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetConsentPerson" name="GetConsentPersonRequest" message="tns:GetConsentPersonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetConsentPersonResponse" name="GetConsentPersonResponse" message="tns:GetConsentPersonResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Person" type="tns:Person">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultPersonEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/CreateDefaultPersonEntity" style="document" />
      <wsdl:input name="CreateDefaultPersonEntityRequest">
        <soap:header message="tns:CreateDefaultPersonEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultPersonEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultPersonEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultPersonEntityResponse">
        <soap:header message="tns:CreateDefaultPersonEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultPersonEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultPersonEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultPersonEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SavePersonEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/SavePersonEntity" style="document" />
      <wsdl:input name="SavePersonEntityRequest">
        <soap:header message="tns:SavePersonEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SavePersonEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SavePersonEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SavePersonEntityResponse">
        <soap:header message="tns:SavePersonEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SavePersonEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SavePersonEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SavePersonEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeletePersonEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/DeletePersonEntity" style="document" />
      <wsdl:input name="DeletePersonEntityRequest">
        <soap:header message="tns:DeletePersonEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeletePersonEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeletePersonEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeletePersonEntityResponse">
        <soap:header message="tns:DeletePersonEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeletePersonEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeletePersonEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeletePersonEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultConsentPerson">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/CreateDefaultConsentPerson" style="document" />
      <wsdl:input name="CreateDefaultConsentPersonRequest">
        <soap:header message="tns:CreateDefaultConsentPersonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultConsentPersonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultConsentPersonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultConsentPersonResponse">
        <soap:header message="tns:CreateDefaultConsentPersonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultConsentPersonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultConsentPersonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultConsentPersonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveConsentPerson">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/SaveConsentPerson" style="document" />
      <wsdl:input name="SaveConsentPersonRequest">
        <soap:header message="tns:SaveConsentPersonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveConsentPersonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveConsentPersonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveConsentPersonResponse">
        <soap:header message="tns:SaveConsentPersonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveConsentPersonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveConsentPersonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveConsentPersonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteConsentPerson">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/DeleteConsentPerson" style="document" />
      <wsdl:input name="DeleteConsentPersonRequest">
        <soap:header message="tns:DeleteConsentPersonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteConsentPersonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteConsentPersonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteConsentPersonResponse">
        <soap:header message="tns:DeleteConsentPersonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteConsentPersonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteConsentPersonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteConsentPersonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPerson">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPerson" style="document" />
      <wsdl:input name="GetPersonRequest">
        <soap:header message="tns:GetPersonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonResponse">
        <soap:header message="tns:GetPersonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonEntity" style="document" />
      <wsdl:input name="GetPersonEntityRequest">
        <soap:header message="tns:GetPersonEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonEntityResponse">
        <soap:header message="tns:GetPersonEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Undelete">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/Undelete" style="document" />
      <wsdl:input name="UndeleteRequest">
        <soap:header message="tns:UndeleteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UndeleteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UndeleteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UndeleteResponse">
        <soap:header message="tns:UndeleteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UndeleteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UndeleteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UndeleteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyPerson">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetMyPerson" style="document" />
      <wsdl:input name="GetMyPersonRequest">
        <soap:header message="tns:GetMyPersonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyPersonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyPersonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyPersonResponse">
        <soap:header message="tns:GetMyPersonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyPersonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyPersonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyPersonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSalesRep">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetSalesRep" style="document" />
      <wsdl:input name="GetSalesRepRequest">
        <soap:header message="tns:GetSalesRepRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSalesRepRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSalesRepRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSalesRepResponse">
        <soap:header message="tns:GetSalesRepResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSalesRepResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSalesRepResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSalesRepResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPhones">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPhones" style="document" />
      <wsdl:input name="GetPhonesRequest">
        <soap:header message="tns:GetPhonesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPhonesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPhonesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPhonesResponse">
        <soap:header message="tns:GetPhonesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPhonesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPhonesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPhonesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChangeCountry">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/ChangeCountry" style="document" />
      <wsdl:input name="ChangeCountryRequest">
        <soap:header message="tns:ChangeCountryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChangeCountryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChangeCountryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChangeCountryResponse">
        <soap:header message="tns:ChangeCountryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChangeCountryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChangeCountryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChangeCountryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAddress">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetAddress" style="document" />
      <wsdl:input name="GetAddressRequest">
        <soap:header message="tns:GetAddressRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAddressRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAddressRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAddressResponse">
        <soap:header message="tns:GetAddressResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAddressResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAddressResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAddressResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAddressByCountry">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetAddressByCountry" style="document" />
      <wsdl:input name="GetAddressByCountryRequest">
        <soap:header message="tns:GetAddressByCountryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAddressByCountryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAddressByCountryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAddressByCountryResponse">
        <soap:header message="tns:GetAddressByCountryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAddressByCountryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAddressByCountryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAddressByCountryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonImage" style="document" />
      <wsdl:input name="GetPersonImageRequest">
        <soap:header message="tns:GetPersonImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonImageResponse">
        <soap:header message="tns:GetPersonImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetPersonImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/SetPersonImage" style="document" />
      <wsdl:input name="SetPersonImageRequest">
        <soap:header message="tns:SetPersonImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetPersonImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetPersonImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetPersonImageResponse">
        <soap:header message="tns:SetPersonImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetPersonImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetPersonImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetPersonImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultByContactId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/CreateDefaultByContactId" style="document" />
      <wsdl:input name="CreateDefaultByContactIdRequest">
        <soap:header message="tns:CreateDefaultByContactIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultByContactIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultByContactIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultByContactIdResponse">
        <soap:header message="tns:CreateDefaultByContactIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultByContactIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultByContactIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultByContactIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Move">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/Move" style="document" />
      <wsdl:input name="MoveRequest">
        <soap:header message="tns:MoveRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MoveRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MoveRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MoveResponse">
        <soap:header message="tns:MoveResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MoveResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MoveResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MoveResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Merge">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/Merge" style="document" />
      <wsdl:input name="MergeRequest">
        <soap:header message="tns:MergeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MergeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MergeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MergeResponse">
        <soap:header message="tns:MergeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MergeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MergeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MergeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultFromCredential">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/CreateDefaultFromCredential" style="document" />
      <wsdl:input name="CreateDefaultFromCredentialRequest">
        <soap:header message="tns:CreateDefaultFromCredentialRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultFromCredentialRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultFromCredentialRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultFromCredentialResponse">
        <soap:header message="tns:CreateDefaultFromCredentialResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultFromCredentialResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultFromCredentialResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultFromCredentialResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="IsNumberValid">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/IsNumberValid" style="document" />
      <wsdl:input name="IsNumberValidRequest">
        <soap:header message="tns:IsNumberValidRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:IsNumberValidRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:IsNumberValidRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="IsNumberValidResponse">
        <soap:header message="tns:IsNumberValidResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:IsNumberValidResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:IsNumberValidResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:IsNumberValidResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetConsent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/SetConsent" style="document" />
      <wsdl:input name="SetConsentRequest">
        <soap:header message="tns:SetConsentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetConsentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetConsentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetConsentResponse">
        <soap:header message="tns:SetConsentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetConsentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetConsentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetConsentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveConsent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/RemoveConsent" style="document" />
      <wsdl:input name="RemoveConsentRequest">
        <soap:header message="tns:RemoveConsentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveConsentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveConsentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveConsentResponse">
        <soap:header message="tns:RemoveConsentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveConsentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveConsentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveConsentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="HasConsent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/HasConsent" style="document" />
      <wsdl:input name="HasConsentRequest">
        <soap:header message="tns:HasConsentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:HasConsentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:HasConsentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="HasConsentResponse">
        <soap:header message="tns:HasConsentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:HasConsentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:HasConsentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:HasConsentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConsentInfos">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetConsentInfos" style="document" />
      <wsdl:input name="GetConsentInfosRequest">
        <soap:header message="tns:GetConsentInfosRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConsentInfosRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConsentInfosRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConsentInfosResponse">
        <soap:header message="tns:GetConsentInfosResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConsentInfosResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConsentInfosResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConsentInfosResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SendConsentConfirmationEmail">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/SendConsentConfirmationEmail" style="document" />
      <wsdl:input name="SendConsentConfirmationEmailRequest">
        <soap:header message="tns:SendConsentConfirmationEmailRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SendConsentConfirmationEmailRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SendConsentConfirmationEmailRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SendConsentConfirmationEmailResponse">
        <soap:header message="tns:SendConsentConfirmationEmailResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SendConsentConfirmationEmailResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SendConsentConfirmationEmailResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SendConsentConfirmationEmailResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ResolvePersonFromInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/ResolvePersonFromInfo" style="document" />
      <wsdl:input name="ResolvePersonFromInfoRequest">
        <soap:header message="tns:ResolvePersonFromInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ResolvePersonFromInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ResolvePersonFromInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ResolvePersonFromInfoResponse">
        <soap:header message="tns:ResolvePersonFromInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ResolvePersonFromInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ResolvePersonFromInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ResolvePersonFromInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddEmailAddressToPerson">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/AddEmailAddressToPerson" style="document" />
      <wsdl:input name="AddEmailAddressToPersonRequest">
        <soap:header message="tns:AddEmailAddressToPersonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddEmailAddressToPersonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddEmailAddressToPersonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddEmailAddressToPersonResponse">
        <soap:header message="tns:AddEmailAddressToPersonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddEmailAddressToPersonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddEmailAddressToPersonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddEmailAddressToPersonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateTemporaryKey">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/CreateTemporaryKey" style="document" />
      <wsdl:input name="CreateTemporaryKeyRequest">
        <soap:header message="tns:CreateTemporaryKeyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateTemporaryKeyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateTemporaryKeyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateTemporaryKeyResponse">
        <soap:header message="tns:CreateTemporaryKeyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateTemporaryKeyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateTemporaryKeyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateTemporaryKeyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CheckTemporaryKey">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/CheckTemporaryKey" style="document" />
      <wsdl:input name="CheckTemporaryKeyRequest">
        <soap:header message="tns:CheckTemporaryKeyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CheckTemporaryKeyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CheckTemporaryKeyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CheckTemporaryKeyResponse">
        <soap:header message="tns:CheckTemporaryKeyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CheckTemporaryKeyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CheckTemporaryKeyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CheckTemporaryKeyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteTemporaryKeysOfDomain">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/DeleteTemporaryKeysOfDomain" style="document" />
      <wsdl:input name="DeleteTemporaryKeysOfDomainRequest">
        <soap:header message="tns:DeleteTemporaryKeysOfDomainRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteTemporaryKeysOfDomainRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteTemporaryKeysOfDomainRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteTemporaryKeysOfDomainResponse">
        <soap:header message="tns:DeleteTemporaryKeysOfDomainResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteTemporaryKeysOfDomainResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteTemporaryKeysOfDomainResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteTemporaryKeysOfDomainResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteExpired">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/DeleteExpired" style="document" />
      <wsdl:input name="DeleteExpiredRequest">
        <soap:header message="tns:DeleteExpiredRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteExpiredRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteExpiredRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteExpiredResponse">
        <soap:header message="tns:DeleteExpiredResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteExpiredResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteExpiredResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteExpiredResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonSummary">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonSummary" style="document" />
      <wsdl:input name="GetPersonSummaryRequest">
        <soap:header message="tns:GetPersonSummaryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonSummaryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonSummaryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonSummaryResponse">
        <soap:header message="tns:GetPersonSummaryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonSummaryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonSummaryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonSummaryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddBounce">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/AddBounce" style="document" />
      <wsdl:input name="AddBounceRequest">
        <soap:header message="tns:AddBounceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddBounceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddBounceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddBounceResponse">
        <soap:header message="tns:AddBounceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddBounceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddBounceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddBounceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonList" style="document" />
      <wsdl:input name="GetPersonListRequest">
        <soap:header message="tns:GetPersonListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonListResponse">
        <soap:header message="tns:GetPersonListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonsFromContact">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonsFromContact" style="document" />
      <wsdl:input name="GetPersonsFromContactRequest">
        <soap:header message="tns:GetPersonsFromContactRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonsFromContactRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonsFromContactRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonsFromContactResponse">
        <soap:header message="tns:GetPersonsFromContactResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonsFromContactResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonsFromContactResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonsFromContactResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonsFromProject">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetPersonsFromProject" style="document" />
      <wsdl:input name="GetPersonsFromProjectRequest">
        <soap:header message="tns:GetPersonsFromProjectRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonsFromProjectRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonsFromProjectRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonsFromProjectResponse">
        <soap:header message="tns:GetPersonsFromProjectResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonsFromProjectResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonsFromProjectResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonsFromProjectResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetColleagues">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetColleagues" style="document" />
      <wsdl:input name="GetColleaguesRequest">
        <soap:header message="tns:GetColleaguesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetColleaguesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetColleaguesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetColleaguesResponse">
        <soap:header message="tns:GetColleaguesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetColleaguesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetColleaguesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetColleaguesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetColleaguesByDepartment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetColleaguesByDepartment" style="document" />
      <wsdl:input name="GetColleaguesByDepartmentRequest">
        <soap:header message="tns:GetColleaguesByDepartmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetColleaguesByDepartmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetColleaguesByDepartmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetColleaguesByDepartmentResponse">
        <soap:header message="tns:GetColleaguesByDepartmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetColleaguesByDepartmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetColleaguesByDepartmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetColleaguesByDepartmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetColleaguesBySource">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetColleaguesBySource" style="document" />
      <wsdl:input name="GetColleaguesBySourceRequest">
        <soap:header message="tns:GetColleaguesBySourceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetColleaguesBySourceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetColleaguesBySourceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetColleaguesBySourceResponse">
        <soap:header message="tns:GetColleaguesBySourceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetColleaguesBySourceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetColleaguesBySourceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetColleaguesBySourceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyOwner">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetMyOwner" style="document" />
      <wsdl:input name="GetMyOwnerRequest">
        <soap:header message="tns:GetMyOwnerRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyOwnerRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyOwnerRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyOwnerResponse">
        <soap:header message="tns:GetMyOwnerResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyOwnerResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyOwnerResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyOwnerResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetOwnerOnPersonId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetOwnerOnPersonId" style="document" />
      <wsdl:input name="GetOwnerOnPersonIdRequest">
        <soap:header message="tns:GetOwnerOnPersonIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetOwnerOnPersonIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetOwnerOnPersonIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetOwnerOnPersonIdResponse">
        <soap:header message="tns:GetOwnerOnPersonIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetOwnerOnPersonIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetOwnerOnPersonIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetOwnerOnPersonIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChangePersonRank">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/ChangePersonRank" style="document" />
      <wsdl:input name="ChangePersonRankRequest">
        <soap:header message="tns:ChangePersonRankRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChangePersonRankRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChangePersonRankRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChangePersonRankResponse">
        <soap:header message="tns:ChangePersonRankResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChangePersonRankResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChangePersonRankResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChangePersonRankResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetPersonRank">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/SetPersonRank" style="document" />
      <wsdl:input name="SetPersonRankRequest">
        <soap:header message="tns:SetPersonRankRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetPersonRankRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetPersonRankRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetPersonRankResponse">
        <soap:header message="tns:SetPersonRankResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetPersonRankResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetPersonRankResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetPersonRankResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="NormalizeRanks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/NormalizeRanks" style="document" />
      <wsdl:input name="NormalizeRanksRequest">
        <soap:header message="tns:NormalizeRanksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:NormalizeRanksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:NormalizeRanksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="NormalizeRanksResponse">
        <soap:header message="tns:NormalizeRanksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:NormalizeRanksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:NormalizeRanksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:NormalizeRanksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConsentPerson">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Person/GetConsentPerson" style="document" />
      <wsdl:input name="GetConsentPersonRequest">
        <soap:header message="tns:GetConsentPersonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConsentPersonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConsentPersonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConsentPersonResponse">
        <soap:header message="tns:GetConsentPersonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConsentPersonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConsentPersonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConsentPersonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfPersonService">
    <wsdl:port name="BasicHttpBinding_Person" binding="tns:BasicHttpBinding_Person">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services87/Person.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

