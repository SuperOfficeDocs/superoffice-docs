---
Generated: 1
TOCExclude: 1
title: Services81.ContactAgent WSDL
---

# Services81.ContactAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfContactService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services81" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services81" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services81" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:element name="CreateDefaultContactEntity">
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
      <xs:element name="CreateDefaultContactEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ContactEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ContactEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Department" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OrgNr" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Number1" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Number2" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Emails" nillable="true" type="tns:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Interests" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
              <xs:element minOccurs="0" name="Urls" nillable="true" type="tns:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Phones" nillable="true" type="tns:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Faxes" nillable="true" type="tns:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="Associate" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="Business" nillable="true" type="tns:Business" />
              <xs:element minOccurs="0" name="Category" nillable="true" type="tns:Category" />
              <xs:element minOccurs="0" name="Country" nillable="true" type="tns:Country" />
              <xs:element minOccurs="0" name="Persons" nillable="true" type="tns:ArrayOfPerson" />
              <xs:element minOccurs="0" name="NoMailing" type="xs:boolean" />
              <xs:element minOccurs="0" name="Kananame" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Xstop" type="xs:boolean" />
              <xs:element minOccurs="0" name="ActiveInterests" type="xs:int" />
              <xs:element minOccurs="0" name="GroupId" type="xs:int" />
              <xs:element minOccurs="0" name="ActiveStatusMonitorId" type="xs:int" />
              <xs:element minOccurs="0" name="SupportAssociate" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="TicketPriority" nillable="true" type="tns:TicketPriority" />
              <xs:element minOccurs="0" name="CustomerLanguage" nillable="true" type="tns:CustomerLanguage" />
              <xs:element minOccurs="0" name="Deleted" type="xs:short" />
              <xs:element minOccurs="0" name="DbiAgentId" type="xs:int" />
              <xs:element minOccurs="0" name="DbiLastSyncronized" type="xs:dateTime" />
              <xs:element minOccurs="0" name="DbiKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DbiLastModified" type="xs:dateTime" />
              <xs:element minOccurs="0" name="SupportPerson" nillable="true" type="tns:Person" />
              <xs:element minOccurs="0" name="Address" nillable="true" type="tns:Address" />
              <xs:element minOccurs="0" name="Source" type="xs:short" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="UserDefinedFields" nillable="true" type="tns:StringDictionary" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="tns:StringDictionary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ContactEntity" nillable="true" type="tns:ContactEntity" />
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
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SelectableMDOListItem" nillable="true" type="tns:SelectableMDOListItem" />
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
      <xs:complexType name="ArrayOfPerson">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Person" nillable="true" type="tns:Person" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfPerson" nillable="true" type="tns:ArrayOfPerson" />
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
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Person" nillable="true" type="tns:Person" />
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
      <xs:complexType name="Address">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Wgs84Latitude" type="xs:double" />
              <xs:element minOccurs="0" name="Wgs84Longitude" type="xs:double" />
              <xs:element minOccurs="0" name="LocalizedAddress" nillable="true" type="tns:ArrayOfArrayOfLocalizedField" />
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
      <xs:element name="SaveContactEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactEntity" nillable="true" type="tns:ContactEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveContactEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ContactEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteContactEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteContactEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContact">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Contact" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
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
      <xs:element name="GetMyActiveContacts">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ActivityStartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="ContactCategories" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="ActionType" type="tns:ContactAction" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="ContactAction">
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="Created" />
              <xs:enumeration value="Updated" />
              <xs:enumeration value="NewActivity" />
              <xs:enumeration value="ActivityCompleted" />
              <xs:enumeration value="PersonAdded" />
              <xs:enumeration value="PersonUpdated" />
              <xs:enumeration value="DocumentAdded" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="ContactAction" nillable="true" type="tns:ContactAction" />
      <xs:element name="GetMyActiveContactsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfContactActivity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfContactActivity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ContactActivity" nillable="true" type="tns:ContactActivity" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfContactActivity" nillable="true" type="tns:ArrayOfContactActivity" />
      <xs:complexType name="ContactActivity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="Department" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OrgNr" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="URL" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Action" type="tns:ContactAction" />
              <xs:element minOccurs="0" name="ActionTime" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Category" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ActivityPersonName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ActionId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="ActivityPersonId" type="xs:int" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ContactActivity" nillable="true" type="tns:ContactActivity" />
      <xs:element name="GetContactEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ContactEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersons">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPerson" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactWithPersons">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactWithPersonsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ContactEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyContact">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyContactResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ContactEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyBizCard">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyBizCardResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ContactEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeCountry">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactEntity" nillable="true" type="tns:ContactEntity" />
            <xs:element minOccurs="0" name="ToCountryId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeCountryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ContactEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAddress">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
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
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
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
      <xs:element name="AddPerson">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="NewPersonEntity" nillable="true" type="tns:PersonEntity" />
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
              <xs:element minOccurs="0" name="UserDefinedFields" nillable="true" type="tns:StringDictionary" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="tns:StringDictionary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PersonEntity" nillable="true" type="tns:PersonEntity" />
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
              <xs:element minOccurs="0" name="GrantedLicenses" nillable="true" type="q2:ArrayOfstring" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
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
      <xs:element name="AddPersonResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PersonEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDuplicates">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDuplicatesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDuplicateEntry" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDuplicateEntry">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DuplicateEntry" nillable="true" type="tns:DuplicateEntry" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDuplicateEntry" nillable="true" type="tns:ArrayOfDuplicateEntry" />
      <xs:complexType name="DuplicateEntry">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="RuleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SoPrimaryKey" type="xs:int" />
              <xs:element minOccurs="0" name="EntryName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EntryIdentifier" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RuleDisplayName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DuplicateEntry" nillable="true" type="tns:DuplicateEntry" />
      <xs:element name="CreateNewEntry">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Duplicate" nillable="true" type="tns:DuplicateEntry" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateNewEntryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDuplicateRules">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDuplicateRulesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDuplicateRule" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDuplicateRule">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DuplicateRule" nillable="true" type="tns:DuplicateRule" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDuplicateRule" nillable="true" type="tns:ArrayOfDuplicateRule" />
      <xs:complexType name="DuplicateRule">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayTooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DuplicateRule" nillable="true" type="tns:DuplicateRule" />
      <xs:element name="SetDuplicateRulesStatus">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Rules" nillable="true" type="tns:ArrayOfDuplicateRule" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDuplicateRulesStatusResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="Merge">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SourceContactId" type="xs:int" />
            <xs:element minOccurs="0" name="DestinationContactId" type="xs:int" />
            <xs:element minOccurs="0" name="MergeIdenticalPersons" type="xs:boolean" />
            <xs:element minOccurs="0" name="ReplaceEmptyFieldsOnDestination" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MergeResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="Copy">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SourceContactId" type="xs:int" />
            <xs:element minOccurs="0" name="DestinationContactName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DestinationContactDepartment" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="CopyPersons" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNameDepartmentDuplicates">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Department" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNameDepartmentDuplicatesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDuplicateEntry" />
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
      <xs:element name="GetQuoteVersionAddresses">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteVersionAddressesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfAddress" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfAddress">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Address" nillable="true" type="tns:Address" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfAddress" nillable="true" type="tns:ArrayOfAddress" />
      <xs:element name="SaveQuoteVersionAddress">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
            <xs:element minOccurs="0" name="Address" nillable="true" type="tns:Address" />
            <xs:element minOccurs="0" name="AddressType" type="tns:AddressType" />
            <xs:element minOccurs="0" name="CountryId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
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
      <xs:element name="SaveQuoteVersionAddressResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Address" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactIds" nillable="true" type="q3:ArrayOfint" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfContact" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfContact">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Contact" nillable="true" type="tns:Contact" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfContact" nillable="true" type="tns:ArrayOfContact" />
      <xs:element name="GetMyContacts">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyContactsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfContact" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyRecentContacts">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SourceType" type="tns:ContactSourceType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="ContactSourceType">
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="History" />
              <xs:enumeration value="Diary" />
              <xs:enumeration value="Favorites" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="ContactSourceType" nillable="true" type="tns:ContactSourceType" />
      <xs:element name="GetMyRecentContactsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfContact" />
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
      <xs:complexType name="ArrayOfstring">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="string" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfstring" nillable="true" type="tns:ArrayOfstring" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="CreateDefaultContactEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultContactEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultContactEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultContactEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultContactEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultContactEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveContactEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveContactEntity" />
  </wsdl:message>
  <wsdl:message name="SaveContactEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveContactEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveContactEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveContactEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteContactEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteContactEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteContactEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteContactEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteContactEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteContactEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactRequest">
    <wsdl:part name="parameters" element="tns:GetContact" />
  </wsdl:message>
  <wsdl:message name="GetContactRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactResponse">
    <wsdl:part name="parameters" element="tns:GetContactResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyActiveContactsRequest">
    <wsdl:part name="parameters" element="tns:GetMyActiveContacts" />
  </wsdl:message>
  <wsdl:message name="GetMyActiveContactsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyActiveContactsResponse">
    <wsdl:part name="parameters" element="tns:GetMyActiveContactsResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyActiveContactsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactEntityRequest">
    <wsdl:part name="parameters" element="tns:GetContactEntity" />
  </wsdl:message>
  <wsdl:message name="GetContactEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactEntityResponse">
    <wsdl:part name="parameters" element="tns:GetContactEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonsRequest">
    <wsdl:part name="parameters" element="tns:GetPersons" />
  </wsdl:message>
  <wsdl:message name="GetPersonsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonsResponse">
    <wsdl:part name="parameters" element="tns:GetPersonsResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactWithPersonsRequest">
    <wsdl:part name="parameters" element="tns:GetContactWithPersons" />
  </wsdl:message>
  <wsdl:message name="GetContactWithPersonsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactWithPersonsResponse">
    <wsdl:part name="parameters" element="tns:GetContactWithPersonsResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactWithPersonsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyContactRequest">
    <wsdl:part name="parameters" element="tns:GetMyContact" />
  </wsdl:message>
  <wsdl:message name="GetMyContactRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyContactResponse">
    <wsdl:part name="parameters" element="tns:GetMyContactResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyContactResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyBizCardRequest">
    <wsdl:part name="parameters" element="tns:GetMyBizCard" />
  </wsdl:message>
  <wsdl:message name="GetMyBizCardRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyBizCardResponse">
    <wsdl:part name="parameters" element="tns:GetMyBizCardResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyBizCardResponse_Headers">
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
  <wsdl:message name="AddPersonRequest">
    <wsdl:part name="parameters" element="tns:AddPerson" />
  </wsdl:message>
  <wsdl:message name="AddPersonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddPersonResponse">
    <wsdl:part name="parameters" element="tns:AddPersonResponse" />
  </wsdl:message>
  <wsdl:message name="AddPersonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDuplicatesRequest">
    <wsdl:part name="parameters" element="tns:GetDuplicates" />
  </wsdl:message>
  <wsdl:message name="GetDuplicatesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDuplicatesResponse">
    <wsdl:part name="parameters" element="tns:GetDuplicatesResponse" />
  </wsdl:message>
  <wsdl:message name="GetDuplicatesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateNewEntryRequest">
    <wsdl:part name="parameters" element="tns:CreateNewEntry" />
  </wsdl:message>
  <wsdl:message name="CreateNewEntryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateNewEntryResponse">
    <wsdl:part name="parameters" element="tns:CreateNewEntryResponse" />
  </wsdl:message>
  <wsdl:message name="CreateNewEntryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDuplicateRulesRequest">
    <wsdl:part name="parameters" element="tns:GetDuplicateRules" />
  </wsdl:message>
  <wsdl:message name="GetDuplicateRulesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDuplicateRulesResponse">
    <wsdl:part name="parameters" element="tns:GetDuplicateRulesResponse" />
  </wsdl:message>
  <wsdl:message name="GetDuplicateRulesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDuplicateRulesStatusRequest">
    <wsdl:part name="parameters" element="tns:SetDuplicateRulesStatus" />
  </wsdl:message>
  <wsdl:message name="SetDuplicateRulesStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDuplicateRulesStatusResponse">
    <wsdl:part name="parameters" element="tns:SetDuplicateRulesStatusResponse" />
  </wsdl:message>
  <wsdl:message name="SetDuplicateRulesStatusResponse_Headers">
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
  <wsdl:message name="CopyRequest">
    <wsdl:part name="parameters" element="tns:Copy" />
  </wsdl:message>
  <wsdl:message name="CopyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopyResponse">
    <wsdl:part name="parameters" element="tns:CopyResponse" />
  </wsdl:message>
  <wsdl:message name="CopyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNameDepartmentDuplicatesRequest">
    <wsdl:part name="parameters" element="tns:GetNameDepartmentDuplicates" />
  </wsdl:message>
  <wsdl:message name="GetNameDepartmentDuplicatesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNameDepartmentDuplicatesResponse">
    <wsdl:part name="parameters" element="tns:GetNameDepartmentDuplicatesResponse" />
  </wsdl:message>
  <wsdl:message name="GetNameDepartmentDuplicatesResponse_Headers">
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
  <wsdl:message name="GetQuoteVersionAddressesRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteVersionAddresses" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionAddressesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionAddressesResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteVersionAddressesResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionAddressesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteVersionAddressRequest">
    <wsdl:part name="parameters" element="tns:SaveQuoteVersionAddress" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteVersionAddressRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteVersionAddressResponse">
    <wsdl:part name="parameters" element="tns:SaveQuoteVersionAddressResponse" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteVersionAddressResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactListRequest">
    <wsdl:part name="parameters" element="tns:GetContactList" />
  </wsdl:message>
  <wsdl:message name="GetContactListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactListResponse">
    <wsdl:part name="parameters" element="tns:GetContactListResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyContactsRequest">
    <wsdl:part name="parameters" element="tns:GetMyContacts" />
  </wsdl:message>
  <wsdl:message name="GetMyContactsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyContactsResponse">
    <wsdl:part name="parameters" element="tns:GetMyContactsResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyContactsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyRecentContactsRequest">
    <wsdl:part name="parameters" element="tns:GetMyRecentContacts" />
  </wsdl:message>
  <wsdl:message name="GetMyRecentContactsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyRecentContactsResponse">
    <wsdl:part name="parameters" element="tns:GetMyRecentContactsResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyRecentContactsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Contact">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Contact</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultContactEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new ContactEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/CreateDefaultContactEntity" name="CreateDefaultContactEntityRequest" message="tns:CreateDefaultContactEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/CreateDefaultContactEntityResponse" name="CreateDefaultContactEntityResponse" message="tns:CreateDefaultContactEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveContactEntity">
      <wsdl:documentation>
        <summary>Updates the existing ContactEntity or creates a new ContactEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/SaveContactEntity" name="SaveContactEntityRequest" message="tns:SaveContactEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/SaveContactEntityResponse" name="SaveContactEntityResponse" message="tns:SaveContactEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteContactEntity">
      <wsdl:documentation>
        <summary>Deletes the ContactEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/DeleteContactEntity" name="DeleteContactEntityRequest" message="tns:DeleteContactEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/DeleteContactEntityResponse" name="DeleteContactEntityResponse" message="tns:DeleteContactEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContact">
      <wsdl:documentation>
        <summary>Gets a Contact object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetContact" name="GetContactRequest" message="tns:GetContactRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetContactResponse" name="GetContactResponse" message="tns:GetContactResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyActiveContacts">
      <wsdl:documentation>
        <summary>Returns the contacts where there has been activity since activityStartTime. If activityStartTime is larger than the current date, all contacts with activity since last log-out are returned. The result set can be filtered by category and action type.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetMyActiveContacts" name="GetMyActiveContactsRequest" message="tns:GetMyActiveContactsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetMyActiveContactsResponse" name="GetMyActiveContactsResponse" message="tns:GetMyActiveContactsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactEntity">
      <wsdl:documentation>
        <summary>Gets a ContactEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetContactEntity" name="GetContactEntityRequest" message="tns:GetContactEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetContactEntityResponse" name="GetContactEntityResponse" message="tns:GetContactEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersons">
      <wsdl:documentation>
        <summary>Returns an array of all the contact persons for the company card.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetPersons" name="GetPersonsRequest" message="tns:GetPersonsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetPersonsResponse" name="GetPersonsResponse" message="tns:GetPersonsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactWithPersons">
      <wsdl:documentation>
        <summary>Returns the contact with all the contact persons belonging to the contact</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetContactWithPersons" name="GetContactWithPersonsRequest" message="tns:GetContactWithPersonsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetContactWithPersonsResponse" name="GetContactWithPersonsResponse" message="tns:GetContactWithPersonsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyContact">
      <wsdl:documentation>
        <summary>Gets the contact belonging to the currently logged on user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetMyContact" name="GetMyContactRequest" message="tns:GetMyContactRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetMyContactResponse" name="GetMyContactResponse" message="tns:GetMyContactResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyBizCard">
      <wsdl:documentation>
        <summary>Returns all data needed to display the logged on person's business card. That is company, person, and company interest data.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetMyBizCard" name="GetMyBizCardRequest" message="tns:GetMyBizCardRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetMyBizCardResponse" name="GetMyBizCardResponse" message="tns:GetMyBizCardResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChangeCountry">
      <wsdl:documentation>
        <summary>Change country regenerates the default values and localized information such as phone number and address format</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/ChangeCountry" name="ChangeCountryRequest" message="tns:ChangeCountryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/ChangeCountryResponse" name="ChangeCountryResponse" message="tns:ChangeCountryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAddress">
      <wsdl:documentation>
        <summary>Gets the contact's localized address.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetAddress" name="GetAddressRequest" message="tns:GetAddressRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetAddressResponse" name="GetAddressResponse" message="tns:GetAddressResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAddressByCountry">
      <wsdl:documentation>
        <summary>Gets the contact's localized address.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetAddressByCountry" name="GetAddressByCountryRequest" message="tns:GetAddressByCountryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetAddressByCountryResponse" name="GetAddressByCountryResponse" message="tns:GetAddressByCountryResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddPerson">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/AddPerson" name="AddPersonRequest" message="tns:AddPersonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/AddPersonResponse" name="AddPersonResponse" message="tns:AddPersonResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDuplicates">
      <wsdl:documentation>
        <summary>Get duplicates(exact or similar in the database) based on the name</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetDuplicates" name="GetDuplicatesRequest" message="tns:GetDuplicatesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetDuplicatesResponse" name="GetDuplicatesResponse" message="tns:GetDuplicatesResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateNewEntry">
      <wsdl:documentation>
        <summary>Creates a new contact based on external duplicate</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/CreateNewEntry" name="CreateNewEntryRequest" message="tns:CreateNewEntryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/CreateNewEntryResponse" name="CreateNewEntryResponse" message="tns:CreateNewEntryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDuplicateRules">
      <wsdl:documentation>
        <summary>Retrieve all available duplicate rules for contact</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetDuplicateRules" name="GetDuplicateRulesRequest" message="tns:GetDuplicateRulesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetDuplicateRulesResponse" name="GetDuplicateRulesResponse" message="tns:GetDuplicateRulesResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetDuplicateRulesStatus">
      <wsdl:documentation>
        <summary>Set which duplicate rules should be active or not</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/SetDuplicateRulesStatus" name="SetDuplicateRulesStatusRequest" message="tns:SetDuplicateRulesStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/SetDuplicateRulesStatusResponse" name="SetDuplicateRulesStatusResponse" message="tns:SetDuplicateRulesStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="Merge">
      <wsdl:documentation>
        <summary>Merge two contacts. The destination contact will remain.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/Merge" name="MergeRequest" message="tns:MergeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/MergeResponse" name="MergeResponse" message="tns:MergeResponse" />
    </wsdl:operation>
    <wsdl:operation name="Copy">
      <wsdl:documentation>
        <summary>Copy a contact. Activities and related data will be ignored</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/Copy" name="CopyRequest" message="tns:CopyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/CopyResponse" name="CopyResponse" message="tns:CopyResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNameDepartmentDuplicates">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetNameDepartmentDuplicates" name="GetNameDepartmentDuplicatesRequest" message="tns:GetNameDepartmentDuplicatesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetNameDepartmentDuplicatesResponse" name="GetNameDepartmentDuplicatesResponse" message="tns:GetNameDepartmentDuplicatesResponse" />
    </wsdl:operation>
    <wsdl:operation name="IsNumberValid">
      <wsdl:documentation>
        <summary>Checks if the number is unique or required.  The setting is configured from admin under system options.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/IsNumberValid" name="IsNumberValidRequest" message="tns:IsNumberValidRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/IsNumberValidResponse" name="IsNumberValidResponse" message="tns:IsNumberValidResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteVersionAddresses">
      <wsdl:documentation>
        <summary>Get the associated billing and invoice quote version addresses. These addresses might be address on the contact, or a custom address.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetQuoteVersionAddresses" name="GetQuoteVersionAddressesRequest" message="tns:GetQuoteVersionAddressesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetQuoteVersionAddressesResponse" name="GetQuoteVersionAddressesResponse" message="tns:GetQuoteVersionAddressesResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveQuoteVersionAddress">
      <wsdl:documentation>
        <summary>Save a custom quote version address.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/SaveQuoteVersionAddress" name="SaveQuoteVersionAddressRequest" message="tns:SaveQuoteVersionAddressRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/SaveQuoteVersionAddressResponse" name="SaveQuoteVersionAddressResponse" message="tns:SaveQuoteVersionAddressResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactList">
      <wsdl:documentation>
        <summary>Gets an array of Contact objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetContactList" name="GetContactListRequest" message="tns:GetContactListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetContactListResponse" name="GetContactListResponse" message="tns:GetContactListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyContacts">
      <wsdl:documentation>
        <summary>Getting the contacts where the user currently logged in is set as contact owner.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetMyContacts" name="GetMyContactsRequest" message="tns:GetMyContactsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetMyContactsResponse" name="GetMyContactsResponse" message="tns:GetMyContactsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyRecentContacts">
      <wsdl:documentation>
        <summary>Method that returns a set of initial contacts. This could be the contacts in a favorites selection, the history list, the diary, or from all sources. If retrieved from the diary it will get appointments for the current and the next day.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetMyRecentContacts" name="GetMyRecentContactsRequest" message="tns:GetMyRecentContactsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetMyRecentContactsResponse" name="GetMyRecentContactsResponse" message="tns:GetMyRecentContactsResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Contact" type="tns:Contact">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultContactEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/CreateDefaultContactEntity" style="document" />
      <wsdl:input name="CreateDefaultContactEntityRequest">
        <soap:header message="tns:CreateDefaultContactEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultContactEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultContactEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultContactEntityResponse">
        <soap:header message="tns:CreateDefaultContactEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultContactEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultContactEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultContactEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveContactEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/SaveContactEntity" style="document" />
      <wsdl:input name="SaveContactEntityRequest">
        <soap:header message="tns:SaveContactEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveContactEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveContactEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveContactEntityResponse">
        <soap:header message="tns:SaveContactEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveContactEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveContactEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveContactEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteContactEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/DeleteContactEntity" style="document" />
      <wsdl:input name="DeleteContactEntityRequest">
        <soap:header message="tns:DeleteContactEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteContactEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteContactEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteContactEntityResponse">
        <soap:header message="tns:DeleteContactEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteContactEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteContactEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteContactEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContact">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetContact" style="document" />
      <wsdl:input name="GetContactRequest">
        <soap:header message="tns:GetContactRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactResponse">
        <soap:header message="tns:GetContactResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyActiveContacts">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetMyActiveContacts" style="document" />
      <wsdl:input name="GetMyActiveContactsRequest">
        <soap:header message="tns:GetMyActiveContactsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyActiveContactsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyActiveContactsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyActiveContactsResponse">
        <soap:header message="tns:GetMyActiveContactsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyActiveContactsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyActiveContactsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyActiveContactsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetContactEntity" style="document" />
      <wsdl:input name="GetContactEntityRequest">
        <soap:header message="tns:GetContactEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactEntityResponse">
        <soap:header message="tns:GetContactEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersons">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetPersons" style="document" />
      <wsdl:input name="GetPersonsRequest">
        <soap:header message="tns:GetPersonsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonsResponse">
        <soap:header message="tns:GetPersonsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactWithPersons">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetContactWithPersons" style="document" />
      <wsdl:input name="GetContactWithPersonsRequest">
        <soap:header message="tns:GetContactWithPersonsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactWithPersonsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactWithPersonsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactWithPersonsResponse">
        <soap:header message="tns:GetContactWithPersonsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactWithPersonsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactWithPersonsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactWithPersonsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyContact">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetMyContact" style="document" />
      <wsdl:input name="GetMyContactRequest">
        <soap:header message="tns:GetMyContactRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyContactRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyContactRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyContactResponse">
        <soap:header message="tns:GetMyContactResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyContactResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyContactResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyContactResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyBizCard">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetMyBizCard" style="document" />
      <wsdl:input name="GetMyBizCardRequest">
        <soap:header message="tns:GetMyBizCardRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyBizCardRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyBizCardRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyBizCardResponse">
        <soap:header message="tns:GetMyBizCardResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyBizCardResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyBizCardResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyBizCardResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChangeCountry">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/ChangeCountry" style="document" />
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
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetAddress" style="document" />
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
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetAddressByCountry" style="document" />
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
    <wsdl:operation name="AddPerson">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/AddPerson" style="document" />
      <wsdl:input name="AddPersonRequest">
        <soap:header message="tns:AddPersonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddPersonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddPersonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddPersonResponse">
        <soap:header message="tns:AddPersonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddPersonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddPersonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddPersonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDuplicates">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetDuplicates" style="document" />
      <wsdl:input name="GetDuplicatesRequest">
        <soap:header message="tns:GetDuplicatesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDuplicatesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDuplicatesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDuplicatesResponse">
        <soap:header message="tns:GetDuplicatesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDuplicatesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDuplicatesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDuplicatesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateNewEntry">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/CreateNewEntry" style="document" />
      <wsdl:input name="CreateNewEntryRequest">
        <soap:header message="tns:CreateNewEntryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateNewEntryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateNewEntryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateNewEntryResponse">
        <soap:header message="tns:CreateNewEntryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateNewEntryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateNewEntryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateNewEntryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDuplicateRules">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetDuplicateRules" style="document" />
      <wsdl:input name="GetDuplicateRulesRequest">
        <soap:header message="tns:GetDuplicateRulesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDuplicateRulesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDuplicateRulesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDuplicateRulesResponse">
        <soap:header message="tns:GetDuplicateRulesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDuplicateRulesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDuplicateRulesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDuplicateRulesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetDuplicateRulesStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/SetDuplicateRulesStatus" style="document" />
      <wsdl:input name="SetDuplicateRulesStatusRequest">
        <soap:header message="tns:SetDuplicateRulesStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetDuplicateRulesStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetDuplicateRulesStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetDuplicateRulesStatusResponse">
        <soap:header message="tns:SetDuplicateRulesStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetDuplicateRulesStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetDuplicateRulesStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetDuplicateRulesStatusResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Merge">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/Merge" style="document" />
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
    <wsdl:operation name="Copy">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/Copy" style="document" />
      <wsdl:input name="CopyRequest">
        <soap:header message="tns:CopyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CopyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CopyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CopyResponse">
        <soap:header message="tns:CopyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CopyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CopyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CopyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNameDepartmentDuplicates">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetNameDepartmentDuplicates" style="document" />
      <wsdl:input name="GetNameDepartmentDuplicatesRequest">
        <soap:header message="tns:GetNameDepartmentDuplicatesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNameDepartmentDuplicatesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNameDepartmentDuplicatesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNameDepartmentDuplicatesResponse">
        <soap:header message="tns:GetNameDepartmentDuplicatesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNameDepartmentDuplicatesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNameDepartmentDuplicatesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNameDepartmentDuplicatesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="IsNumberValid">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/IsNumberValid" style="document" />
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
    <wsdl:operation name="GetQuoteVersionAddresses">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetQuoteVersionAddresses" style="document" />
      <wsdl:input name="GetQuoteVersionAddressesRequest">
        <soap:header message="tns:GetQuoteVersionAddressesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteVersionAddressesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteVersionAddressesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteVersionAddressesResponse">
        <soap:header message="tns:GetQuoteVersionAddressesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteVersionAddressesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteVersionAddressesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteVersionAddressesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveQuoteVersionAddress">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/SaveQuoteVersionAddress" style="document" />
      <wsdl:input name="SaveQuoteVersionAddressRequest">
        <soap:header message="tns:SaveQuoteVersionAddressRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveQuoteVersionAddressRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveQuoteVersionAddressRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveQuoteVersionAddressResponse">
        <soap:header message="tns:SaveQuoteVersionAddressResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveQuoteVersionAddressResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveQuoteVersionAddressResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveQuoteVersionAddressResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetContactList" style="document" />
      <wsdl:input name="GetContactListRequest">
        <soap:header message="tns:GetContactListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactListResponse">
        <soap:header message="tns:GetContactListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyContacts">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetMyContacts" style="document" />
      <wsdl:input name="GetMyContactsRequest">
        <soap:header message="tns:GetMyContactsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyContactsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyContactsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyContactsResponse">
        <soap:header message="tns:GetMyContactsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyContactsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyContactsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyContactsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyRecentContacts">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Contact/GetMyRecentContacts" style="document" />
      <wsdl:input name="GetMyRecentContactsRequest">
        <soap:header message="tns:GetMyRecentContactsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyRecentContactsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyRecentContactsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyRecentContactsResponse">
        <soap:header message="tns:GetMyRecentContactsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyRecentContactsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyRecentContactsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyRecentContactsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfContactService">
    <wsdl:port name="BasicHttpBinding_Contact" binding="tns:BasicHttpBinding_Contact">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services81/Contact.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

