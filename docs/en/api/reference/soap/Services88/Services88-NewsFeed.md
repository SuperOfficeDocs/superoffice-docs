---
generated: true
uid: wsdl-Services88-NewsFeed
title: Services88.NewsFeedAgent WSDL
content_type: reference
---

# Services88.NewsFeedAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfNewsFeedService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultNewsFeedItem">
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
      <xs:element name="CreateDefaultNewsFeedItemResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:NewsFeedItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="NewsFeedItem">
        <xs:sequence>
          <xs:element minOccurs="0" name="NewsFeedItemId" type="xs:int" />
          <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Summary" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="tns:StringDictionary" />
          <xs:element minOccurs="0" name="Actions" nillable="true" type="tns:ArrayOfNewsFeedCTA" />
          <xs:element minOccurs="0" name="ImageLink" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="SourceLink" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="PreviewHint" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FromName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FromCategoryName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Priority" type="tns:EMailPriority" />
          <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
          <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
          <xs:element minOccurs="0" name="ExpiresAt" type="xs:dateTime" />
          <xs:element minOccurs="0" name="Status" type="tns:NewsFeedItemStatus" />
          <xs:element minOccurs="0" name="IsRead" type="xs:boolean" />
          <xs:element minOccurs="0" name="ReadAt" type="xs:dateTime" />
          <xs:element minOccurs="0" name="Contact" nillable="true" type="tns:Contact" />
          <xs:element minOccurs="0" name="Person" nillable="true" type="tns:Person" />
          <xs:element minOccurs="0" name="Project" nillable="true" type="tns:Project" />
          <xs:element minOccurs="0" name="Sale" nillable="true" type="tns:Sale" />
          <xs:element minOccurs="0" name="ApplicationId" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="NewsFeedItem" nillable="true" type="tns:NewsFeedItem" />
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
      <xs:complexType name="ArrayOfNewsFeedCTA">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="NewsFeedCTA" nillable="true" type="tns:NewsFeedCTA" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfNewsFeedCTA" nillable="true" type="tns:ArrayOfNewsFeedCTA" />
      <xs:complexType name="NewsFeedCTA">
        <xs:sequence>
          <xs:element minOccurs="0" name="Identifier" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="CtaType" type="tns:CtaType" />
          <xs:element minOccurs="0" name="CtaFlavor" type="tns:CtaFlavor" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="NewsFeedCTA" nillable="true" type="tns:NewsFeedCTA" />
      <xs:simpleType name="CtaType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Primary" />
          <xs:enumeration value="Secondary" />
          <xs:enumeration value="Link" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="CtaType" nillable="true" type="tns:CtaType" />
      <xs:simpleType name="CtaFlavor">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Normal" />
          <xs:enumeration value="Info" />
          <xs:enumeration value="Warning" />
          <xs:enumeration value="Error" />
          <xs:enumeration value="Accept" />
          <xs:enumeration value="Reject" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="CtaFlavor" nillable="true" type="tns:CtaFlavor" />
      <xs:simpleType name="EMailPriority">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="NoPriority" />
          <xs:enumeration value="Highest" />
          <xs:enumeration value="High" />
          <xs:enumeration value="Normal" />
          <xs:enumeration value="Low" />
          <xs:enumeration value="Lowest" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="EMailPriority" nillable="true" type="tns:EMailPriority" />
      <xs:simpleType name="NewsFeedItemStatus">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Normal" />
          <xs:enumeration value="Handling" />
          <xs:enumeration value="Handled" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="NewsFeedItemStatus" nillable="true" type="tns:NewsFeedItemStatus" />
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
              <xs:element minOccurs="0" name="Number1" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Number2" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Contact" nillable="true" type="tns:Contact" />
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
              <xs:enumeration value="R">
                <xs:annotation>
                  <xs:appinfo>
                    <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1</EnumerationValue>
                  </xs:appinfo>
                </xs:annotation>
              </xs:enumeration>
              <xs:enumeration value="F">
                <xs:annotation>
                  <xs:appinfo>
                    <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">16</EnumerationValue>
                  </xs:appinfo>
                </xs:annotation>
              </xs:enumeration>
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
              <xs:enumeration value="Nullable">
                <xs:annotation>
                  <xs:appinfo>
                    <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">32</EnumerationValue>
                  </xs:appinfo>
                </xs:annotation>
              </xs:enumeration>
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="EFieldRight" nillable="true" type="tns:EFieldRight" />
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
              <xs:element minOccurs="0" name="PersonNumber" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Person" nillable="true" type="tns:Person" />
      <xs:complexType name="Project">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="URL" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="AssociateFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TypeId" type="xs:int" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="StatusId" type="xs:int" />
              <xs:element minOccurs="0" name="Status" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TextId" type="xs:int" />
              <xs:element minOccurs="0" name="PublishTo" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishFrom" type="xs:dateTime" />
              <xs:element minOccurs="0" name="IsPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="URLName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjectNumber" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="EventId" type="xs:int" />
              <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Project" nillable="true" type="tns:Project" />
      <xs:complexType name="Sale">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SaleDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="SaleId" type="xs:int" />
              <xs:element minOccurs="0" name="Probability" type="xs:short" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Amount" type="xs:double" />
              <xs:element minOccurs="0" name="Currency" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjectName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Status" type="tns:SaleStatus" />
              <xs:element minOccurs="0" name="WeightedAmount" type="xs:double" />
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="EarningPercent" type="xs:double" />
              <xs:element minOccurs="0" name="Earning" type="xs:double" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleTypeId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleTypeName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Completed" type="tns:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="NextDueDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Number" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Sale" nillable="true" type="tns:Sale" />
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
      <xs:simpleType name="ActivityStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="NotStarted" />
          <xs:enumeration value="Started" />
          <xs:enumeration value="Completed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ActivityStatus" nillable="true" type="tns:ActivityStatus" />
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
      <xs:element name="DeleteNewsFeedItem">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NewsFeedItemId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteNewsFeedItemResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNewsFeedItem">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NewsFeedItemId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNewsFeedItemResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:NewsFeedItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="PostNewsFeedItem">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NewsFeedItem" nillable="true" type="tns:NewsFeedItem" />
            <xs:element minOccurs="0" name="ToAssociateIds" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="ToGroupIds" nillable="true" type="q2:ArrayOfint" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="ToAll" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="PostNewsFeedItemResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:NewsFeedItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNewsFeedItemsById">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NewsFeedItemIds" nillable="true" type="q3:ArrayOfint" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNewsFeedItemsByIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfNewsFeedItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfNewsFeedItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="NewsFeedItem" nillable="true" type="tns:NewsFeedItem" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfNewsFeedItem" nillable="true" type="tns:ArrayOfNewsFeedItem" />
      <xs:element name="GetNewsItemsForUser">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="FromDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="ToDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Top" type="xs:int" />
            <xs:element minOccurs="0" name="Skip" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNewsItemsForUserResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfNewsFeedItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MarkAsRead">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NewsFeedItemId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MarkAsReadResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="StartHandling">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NewsFeedItemId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="StartHandlingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MarkAsHandled">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NewsFeedItemId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MarkAsHandledResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
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
  <wsdl:message name="CreateDefaultNewsFeedItemRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultNewsFeedItem" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultNewsFeedItemRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultNewsFeedItemResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultNewsFeedItemResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultNewsFeedItemResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteNewsFeedItemRequest">
    <wsdl:part name="parameters" element="tns:DeleteNewsFeedItem" />
  </wsdl:message>
  <wsdl:message name="DeleteNewsFeedItemRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteNewsFeedItemResponse">
    <wsdl:part name="parameters" element="tns:DeleteNewsFeedItemResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteNewsFeedItemResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNewsFeedItemRequest">
    <wsdl:part name="parameters" element="tns:GetNewsFeedItem" />
  </wsdl:message>
  <wsdl:message name="GetNewsFeedItemRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNewsFeedItemResponse">
    <wsdl:part name="parameters" element="tns:GetNewsFeedItemResponse" />
  </wsdl:message>
  <wsdl:message name="GetNewsFeedItemResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PostNewsFeedItemRequest">
    <wsdl:part name="parameters" element="tns:PostNewsFeedItem" />
  </wsdl:message>
  <wsdl:message name="PostNewsFeedItemRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PostNewsFeedItemResponse">
    <wsdl:part name="parameters" element="tns:PostNewsFeedItemResponse" />
  </wsdl:message>
  <wsdl:message name="PostNewsFeedItemResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNewsFeedItemsByIdRequest">
    <wsdl:part name="parameters" element="tns:GetNewsFeedItemsById" />
  </wsdl:message>
  <wsdl:message name="GetNewsFeedItemsByIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNewsFeedItemsByIdResponse">
    <wsdl:part name="parameters" element="tns:GetNewsFeedItemsByIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetNewsFeedItemsByIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNewsItemsForUserRequest">
    <wsdl:part name="parameters" element="tns:GetNewsItemsForUser" />
  </wsdl:message>
  <wsdl:message name="GetNewsItemsForUserRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNewsItemsForUserResponse">
    <wsdl:part name="parameters" element="tns:GetNewsItemsForUserResponse" />
  </wsdl:message>
  <wsdl:message name="GetNewsItemsForUserResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MarkAsReadRequest">
    <wsdl:part name="parameters" element="tns:MarkAsRead" />
  </wsdl:message>
  <wsdl:message name="MarkAsReadRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MarkAsReadResponse">
    <wsdl:part name="parameters" element="tns:MarkAsReadResponse" />
  </wsdl:message>
  <wsdl:message name="MarkAsReadResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="StartHandlingRequest">
    <wsdl:part name="parameters" element="tns:StartHandling" />
  </wsdl:message>
  <wsdl:message name="StartHandlingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="StartHandlingResponse">
    <wsdl:part name="parameters" element="tns:StartHandlingResponse" />
  </wsdl:message>
  <wsdl:message name="StartHandlingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MarkAsHandledRequest">
    <wsdl:part name="parameters" element="tns:MarkAsHandled" />
  </wsdl:message>
  <wsdl:message name="MarkAsHandledRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MarkAsHandledResponse">
    <wsdl:part name="parameters" element="tns:MarkAsHandledResponse" />
  </wsdl:message>
  <wsdl:message name="MarkAsHandledResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="NewsFeed">
    <wsdl:operation name="CreateDefaultNewsFeedItem">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/CreateDefaultNewsFeedItem" name="CreateDefaultNewsFeedItemRequest" message="tns:CreateDefaultNewsFeedItemRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/CreateDefaultNewsFeedItemResponse" name="CreateDefaultNewsFeedItemResponse" message="tns:CreateDefaultNewsFeedItemResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteNewsFeedItem">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/DeleteNewsFeedItem" name="DeleteNewsFeedItemRequest" message="tns:DeleteNewsFeedItemRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/DeleteNewsFeedItemResponse" name="DeleteNewsFeedItemResponse" message="tns:DeleteNewsFeedItemResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNewsFeedItem">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/GetNewsFeedItem" name="GetNewsFeedItemRequest" message="tns:GetNewsFeedItemRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/GetNewsFeedItemResponse" name="GetNewsFeedItemResponse" message="tns:GetNewsFeedItemResponse" />
    </wsdl:operation>
    <wsdl:operation name="PostNewsFeedItem">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/PostNewsFeedItem" name="PostNewsFeedItemRequest" message="tns:PostNewsFeedItemRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/PostNewsFeedItemResponse" name="PostNewsFeedItemResponse" message="tns:PostNewsFeedItemResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNewsFeedItemsById">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/GetNewsFeedItemsById" name="GetNewsFeedItemsByIdRequest" message="tns:GetNewsFeedItemsByIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/GetNewsFeedItemsByIdResponse" name="GetNewsFeedItemsByIdResponse" message="tns:GetNewsFeedItemsByIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNewsItemsForUser">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/GetNewsItemsForUser" name="GetNewsItemsForUserRequest" message="tns:GetNewsItemsForUserRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/GetNewsItemsForUserResponse" name="GetNewsItemsForUserResponse" message="tns:GetNewsItemsForUserResponse" />
    </wsdl:operation>
    <wsdl:operation name="MarkAsRead">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/MarkAsRead" name="MarkAsReadRequest" message="tns:MarkAsReadRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/MarkAsReadResponse" name="MarkAsReadResponse" message="tns:MarkAsReadResponse" />
    </wsdl:operation>
    <wsdl:operation name="StartHandling">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/StartHandling" name="StartHandlingRequest" message="tns:StartHandlingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/StartHandlingResponse" name="StartHandlingResponse" message="tns:StartHandlingResponse" />
    </wsdl:operation>
    <wsdl:operation name="MarkAsHandled">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/MarkAsHandled" name="MarkAsHandledRequest" message="tns:MarkAsHandledRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/MarkAsHandledResponse" name="MarkAsHandledResponse" message="tns:MarkAsHandledResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_NewsFeed" type="tns:NewsFeed">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultNewsFeedItem">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/CreateDefaultNewsFeedItem" style="document" />
      <wsdl:input name="CreateDefaultNewsFeedItemRequest">
        <soap:header message="tns:CreateDefaultNewsFeedItemRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultNewsFeedItemRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultNewsFeedItemRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultNewsFeedItemResponse">
        <soap:header message="tns:CreateDefaultNewsFeedItemResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultNewsFeedItemResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultNewsFeedItemResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultNewsFeedItemResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteNewsFeedItem">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/DeleteNewsFeedItem" style="document" />
      <wsdl:input name="DeleteNewsFeedItemRequest">
        <soap:header message="tns:DeleteNewsFeedItemRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteNewsFeedItemRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteNewsFeedItemRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteNewsFeedItemResponse">
        <soap:header message="tns:DeleteNewsFeedItemResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteNewsFeedItemResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteNewsFeedItemResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteNewsFeedItemResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNewsFeedItem">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/GetNewsFeedItem" style="document" />
      <wsdl:input name="GetNewsFeedItemRequest">
        <soap:header message="tns:GetNewsFeedItemRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNewsFeedItemRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNewsFeedItemRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNewsFeedItemResponse">
        <soap:header message="tns:GetNewsFeedItemResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNewsFeedItemResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNewsFeedItemResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNewsFeedItemResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="PostNewsFeedItem">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/PostNewsFeedItem" style="document" />
      <wsdl:input name="PostNewsFeedItemRequest">
        <soap:header message="tns:PostNewsFeedItemRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:PostNewsFeedItemRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:PostNewsFeedItemRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="PostNewsFeedItemResponse">
        <soap:header message="tns:PostNewsFeedItemResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:PostNewsFeedItemResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:PostNewsFeedItemResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:PostNewsFeedItemResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNewsFeedItemsById">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/GetNewsFeedItemsById" style="document" />
      <wsdl:input name="GetNewsFeedItemsByIdRequest">
        <soap:header message="tns:GetNewsFeedItemsByIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNewsFeedItemsByIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNewsFeedItemsByIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNewsFeedItemsByIdResponse">
        <soap:header message="tns:GetNewsFeedItemsByIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNewsFeedItemsByIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNewsFeedItemsByIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNewsFeedItemsByIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNewsItemsForUser">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/GetNewsItemsForUser" style="document" />
      <wsdl:input name="GetNewsItemsForUserRequest">
        <soap:header message="tns:GetNewsItemsForUserRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNewsItemsForUserRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNewsItemsForUserRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNewsItemsForUserResponse">
        <soap:header message="tns:GetNewsItemsForUserResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNewsItemsForUserResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNewsItemsForUserResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNewsItemsForUserResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="MarkAsRead">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/MarkAsRead" style="document" />
      <wsdl:input name="MarkAsReadRequest">
        <soap:header message="tns:MarkAsReadRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MarkAsReadRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MarkAsReadRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MarkAsReadResponse">
        <soap:header message="tns:MarkAsReadResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MarkAsReadResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MarkAsReadResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MarkAsReadResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="StartHandling">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/StartHandling" style="document" />
      <wsdl:input name="StartHandlingRequest">
        <soap:header message="tns:StartHandlingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:StartHandlingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:StartHandlingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="StartHandlingResponse">
        <soap:header message="tns:StartHandlingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:StartHandlingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:StartHandlingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:StartHandlingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="MarkAsHandled">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/NewsFeed/MarkAsHandled" style="document" />
      <wsdl:input name="MarkAsHandledRequest">
        <soap:header message="tns:MarkAsHandledRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MarkAsHandledRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MarkAsHandledRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MarkAsHandledResponse">
        <soap:header message="tns:MarkAsHandledResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MarkAsHandledResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MarkAsHandledResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MarkAsHandledResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfNewsFeedService">
    <wsdl:port name="BasicHttpBinding_NewsFeed" binding="tns:BasicHttpBinding_NewsFeed">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/NewsFeed.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

