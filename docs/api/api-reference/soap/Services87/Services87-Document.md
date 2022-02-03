---
generated: 1
uid: wsdl-Services87-Document
title: Services87.DocumentAgent WSDL
---

# Services87.DocumentAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfDocumentService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultDocumentEntity">
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
      <xs:element name="CreateDefaultDocumentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="DocumentEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="Attention" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Header" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OurRef" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="YourRef" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DocumentTemplate" nillable="true" type="tns:DocumentTemplate" />
              <xs:element minOccurs="0" name="Person" nillable="true" type="tns:Person" />
              <xs:element minOccurs="0" name="Associate" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="Contact" nillable="true" type="tns:Contact" />
              <xs:element minOccurs="0" name="Project" nillable="true" type="tns:Project" />
              <xs:element minOccurs="0" name="Date" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ExternalRef" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Completed" type="tns:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveLinks" type="xs:int" />
              <xs:element minOccurs="0" name="Type" type="tns:AppointmentType" />
              <xs:element minOccurs="0" name="Links" nillable="true" type="tns:ArrayOfLink" />
              <xs:element minOccurs="0" name="LockSemantics" type="tns:DocumentLockSemantics" />
              <xs:element minOccurs="0" name="Sale" nillable="true" type="tns:Sale" />
              <xs:element minOccurs="0" name="SuggestedDocumentId" type="xs:int" />
              <xs:element minOccurs="0" name="Snum" type="xs:int" />
              <xs:element minOccurs="0" name="UserDefinedFields" nillable="true" type="tns:StringDictionary" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="tns:StringDictionary" />
              <xs:element minOccurs="0" name="CustomFields" nillable="true" type="tns:StringDictionary" />
              <xs:element minOccurs="0" name="PublishEventDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishTo" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishFrom" type="xs:dateTime" />
              <xs:element minOccurs="0" name="IsPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="VisibleFor" nillable="true" type="tns:ArrayOfVisibleFor" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DocumentEntity" nillable="true" type="tns:DocumentEntity" />
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
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Project" nillable="true" type="tns:Project" />
      <xs:simpleType name="ActivityStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="NotStarted" />
          <xs:enumeration value="Started" />
          <xs:enumeration value="Completed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ActivityStatus" nillable="true" type="tns:ActivityStatus" />
      <xs:simpleType name="AppointmentType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="inDiary" />
          <xs:enumeration value="inChecklist" />
          <xs:enumeration value="Note" />
          <xs:enumeration value="Document" />
          <xs:enumeration value="SavedReport" />
          <xs:enumeration value="BookingForDiary" />
          <xs:enumeration value="BookingForChecklist" />
          <xs:enumeration value="MergeDraft" />
          <xs:enumeration value="MergeFinal" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="AppointmentType" nillable="true" type="tns:AppointmentType" />
      <xs:complexType name="ArrayOfLink">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Link" nillable="true" type="tns:Link" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLink" nillable="true" type="tns:ArrayOfLink" />
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
      <xs:simpleType name="DocumentLockSemantics">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Locking" />
          <xs:enumeration value="Versioning" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="DocumentLockSemantics" nillable="true" type="tns:DocumentLockSemantics" />
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
      <xs:complexType name="ArrayOfVisibleFor">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="VisibleFor" nillable="true" type="tns:VisibleFor" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfVisibleFor" nillable="true" type="tns:ArrayOfVisibleFor" />
      <xs:complexType name="VisibleFor">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="VisibleId" type="xs:int" />
              <xs:element minOccurs="0" name="Visibility" type="tns:Visibility" />
              <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="VisibleFor" nillable="true" type="tns:VisibleFor" />
      <xs:simpleType name="Visibility">
        <xs:restriction base="xs:string">
          <xs:enumeration value="All" />
          <xs:enumeration value="Associate" />
          <xs:enumeration value="Group" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="Visibility" nillable="true" type="tns:Visibility" />
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
      <xs:element name="SaveDocumentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentEntity" nillable="true" type="tns:DocumentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDocumentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDocumentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDocumentEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultSuggestedDocumentEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultSuggestedDocumentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SuggestedDocumentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SuggestedDocumentEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="SuggestedDocumentId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="DoctmplId" type="xs:int" />
              <xs:element minOccurs="0" name="Header" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OurRef" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="DocTmpl" nillable="true" type="tns:DocumentTemplate" />
              <xs:element minOccurs="0" name="ProjectTypeStatusLink" nillable="true" type="tns:ProjectTypeStatusLink" />
              <xs:element minOccurs="0" name="SaleTypeStageLink" nillable="true" type="tns:SaleTypeStageLink" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SuggestedDocumentEntity" nillable="true" type="tns:SuggestedDocumentEntity" />
      <xs:complexType name="ProjectTypeStatusLink">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ProjectTypeStatusLinkId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjTypeId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjTypeName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjTypeTooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjStatusId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjStatusName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjStatusTooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ProjectTypeStatusLink" nillable="true" type="tns:ProjectTypeStatusLink" />
      <xs:complexType name="SaleTypeStageLink">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="SaleTypeStageLinkId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleTypeId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleTypeName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SaleTypeTooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProbId" type="xs:int" />
              <xs:element minOccurs="0" name="ProbName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProbTooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Probability" type="xs:short" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SaleTypeStageLink" nillable="true" type="tns:SaleTypeStageLink" />
      <xs:element name="SaveSuggestedDocumentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SuggestedDocumentEntity" nillable="true" type="tns:SuggestedDocumentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveSuggestedDocumentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SuggestedDocumentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTemplateVariablesParameters">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTemplateVariablesParametersResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TemplateVariablesParameters" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="TemplateVariablesParameters">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="SourceInput" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Encoding" type="tns:GeneratorEncoding" />
              <xs:element minOccurs="0" name="CultureName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleId" type="xs:int" />
              <xs:element minOccurs="0" name="QuoteLineId" type="xs:int" />
              <xs:element minOccurs="0" name="QuoteAlternativeId" type="xs:int" />
              <xs:element minOccurs="0" name="ProductKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CustomTags" nillable="true" type="q1:ArrayOfArrayOfstring" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="DocumentEntity" nillable="true" type="tns:DocumentEntity" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TemplateVariablesParameters" nillable="true" type="tns:TemplateVariablesParameters" />
      <xs:simpleType name="GeneratorEncoding">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Text" />
          <xs:enumeration value="Html" />
          <xs:enumeration value="Xml" />
          <xs:enumeration value="MsWord" />
          <xs:enumeration value="MsExcel" />
          <xs:enumeration value="MsPowerpoint" />
          <xs:enumeration value="MsOffice2007" />
          <xs:enumeration value="MsOffice2007Xml" />
          <xs:enumeration value="Url" />
          <xs:enumeration value="UrlUnicode" />
          <xs:enumeration value="Pdf" />
          <xs:enumeration value="Mime" />
          <xs:enumeration value="OpenDocument" />
          <xs:enumeration value="OpenDocumentXml" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="GeneratorEncoding" nillable="true" type="tns:GeneratorEncoding" />
      <xs:element name="GetDocument">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Document" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Document">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
              <xs:element minOccurs="0" name="Attention" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Header" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OurRef" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="YourRef" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DocumentTemplate" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjectName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Snum" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Document" nillable="true" type="tns:Document" />
      <xs:element name="GetDocumentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentStreamFromEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentEntity" nillable="true" type="tns:DocumentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentStreamFromEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDocumentStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentEntity" nillable="true" type="tns:DocumentEntity" />
            <xs:element minOccurs="0" name="Stream" nillable="true" type="xs:base64Binary" />
            <xs:element minOccurs="0" name="OverwriteExistingData" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDocumentStreamResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDocumentStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentEntity" nillable="true" type="tns:DocumentEntity" />
            <xs:element minOccurs="0" name="OverwriteExistingData" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDocumentStreamResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTemplateStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TemplateName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="AllowPersonal" type="xs:boolean" />
            <xs:element minOccurs="0" name="UiCulture" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTemplateStreamResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSanitizedTemplateStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TemplateName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="AllowPersonal" type="xs:boolean" />
            <xs:element minOccurs="0" name="UiCulture" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSanitizedTemplateStreamResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTemplateStreamFromId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TemplateId" type="xs:int" />
            <xs:element minOccurs="0" name="UiCulture" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTemplateStreamFromIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSanitizedTemplateStreamFromId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TemplateId" type="xs:int" />
            <xs:element minOccurs="0" name="UiCulture" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSanitizedTemplateStreamFromIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentStreamResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSanitizedDocumentStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSanitizedDocumentStreamResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateNewPhysicalMailMergeDocumentFromTemplate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="UiCulture" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateNewPhysicalMailMergeDocumentFromTemplateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateNewPhysicalDocumentFromTemplateWithCustomTags">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="CustomTags" nillable="true" type="q2:ArrayOfstring" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="CustomValues" nillable="true" type="q3:ArrayOfstring" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="UiCulture" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateNewPhysicalDocumentFromTemplateWithCustomTagsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateNewPhysicalDocumentFromTemplateWithCustomTags2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="CustomTags" nillable="true" type="tns:StringDictionary" />
            <xs:element minOccurs="0" name="UiCulture" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateNewPhysicalDocumentFromTemplateWithCustomTags2Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SubstituteTemplateVariables">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="GeneratorEncoding" type="tns:GeneratorEncoding" />
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="CultureName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SubstituteTemplateVariablesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SubstituteTemplateVariablesWithCustomTags">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="GeneratorEncoding" type="tns:GeneratorEncoding" />
            <xs:element minOccurs="0" name="CustomTags" nillable="true" type="q4:ArrayOfstring" xmlns:q4="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="CustomValues" nillable="true" type="q5:ArrayOfstring" xmlns:q5="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="CultureName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SubstituteTemplateVariablesWithCustomTagsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SubstituteTemplateVariablesWithCustomTags2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="GeneratorEncoding" type="tns:GeneratorEncoding" />
            <xs:element minOccurs="0" name="CustomTags" nillable="true" type="tns:StringDictionary" />
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="CultureName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SubstituteTemplateVariablesWithCustomTags2Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTempFile">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Filename" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DataStream" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTempFileResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTempFile">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Filename" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTempFileResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteTempFile">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Filename" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteTempFileResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetTemplateStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Filename" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Personal" type="xs:boolean" />
            <xs:element minOccurs="0" name="Stream" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetTemplateStreamResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateNewPhysicalDocumentFromTemplate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="UiCulture" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateNewPhysicalDocumentFromTemplateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SubstituteMergeDocumentTemplateVariables">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="CustomTags" nillable="true" type="q6:ArrayOfstring" xmlns:q6="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="CustomValues" nillable="true" type="q7:ArrayOfstring" xmlns:q7="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SubstituteMergeDocumentTemplateVariablesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SubstituteMergeDocumentTemplateVariables2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="CustomTags" nillable="true" type="tns:StringDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SubstituteMergeDocumentTemplateVariables2Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SubstituteTemplateVariablesEx">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Parameters" nillable="true" type="tns:TemplateVariablesParameters" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SubstituteTemplateVariablesExResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="VerifyGetDocumentStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="VerifyGetDocumentStreamResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SubstituteMergeDocumentTemplateVariablesEx">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MergeDocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="CustomTags" nillable="true" type="q8:ArrayOfstring" xmlns:q8="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="CustomValues" nillable="true" type="q9:ArrayOfstring" xmlns:q9="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SubstituteMergeDocumentTemplateVariablesExResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SubstituteMergeDocumentTemplateVariablesEx2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MergeDocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="CustomTags" nillable="true" type="tns:StringDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SubstituteMergeDocumentTemplateVariablesEx2Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentUrl">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="VersionId" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="WriteableUrl" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentUrlResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeletePhysicalDocument">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="AllowedReturnType" nillable="true" type="q10:ArrayOfstring" xmlns:q10="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeletePhysicalDocumentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReturnInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ReturnInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="ExternalReference" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="VersionId" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Success" type="xs:boolean" />
          <xs:element minOccurs="0" name="Type" type="tns:ReturnType" />
          <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="AdditionalInfo" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ReturnInfo" nillable="true" type="tns:ReturnInfo" />
      <xs:simpleType name="ReturnType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Message" />
          <xs:enumeration value="SoProtocol" />
          <xs:enumeration value="CustomGui" />
          <xs:enumeration value="Other" />
          <xs:enumeration value="URL" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ReturnType" nillable="true" type="tns:ReturnType" />
      <xs:element name="RenameDocument">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="NewFilename" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RenameDocumentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCheckoutState">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCheckoutStateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CheckoutInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CheckoutInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="State" type="tns:CheckoutState" />
          <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="CheckoutInfo" nillable="true" type="tns:CheckoutInfo" />
      <xs:simpleType name="CheckoutState">
        <xs:restriction base="xs:string">
          <xs:enumeration value="NotCheckedOut" />
          <xs:enumeration value="CheckedOutOwn" />
          <xs:enumeration value="CheckedOutOther" />
          <xs:enumeration value="LockingNotSupported" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="CheckoutState" nillable="true" type="tns:CheckoutState" />
      <xs:element name="CheckoutDocument">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="AllowedReturnTypes" nillable="true" type="q11:ArrayOfstring" xmlns:q11="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CheckoutDocumentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReturnInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CheckinDocument">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="AllowedReturnTypes" nillable="true" type="q12:ArrayOfstring" xmlns:q12="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="VersionDescription" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="VersionExtraFields" nillable="true" type="q13:ArrayOfstring" xmlns:q13="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CheckinDocumentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReturnInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UndoCheckoutDocument">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="AllowedReturnTypes" nillable="true" type="q14:ArrayOfstring" xmlns:q14="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UndoCheckoutDocumentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReturnInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetVersionList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetVersionListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfVersionInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfVersionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="VersionInfo" nillable="true" type="tns:VersionInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfVersionInfo" nillable="true" type="tns:ArrayOfVersionInfo" />
      <xs:complexType name="VersionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="ExternalReference" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          <xs:element minOccurs="0" name="VersionId" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="CheckedInDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="CheckedInByName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="CheckedInByAssociateId" type="xs:int" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DisplayText" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="q15:ArrayOfstring" xmlns:q15="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="VersionInfo" nillable="true" type="tns:VersionInfo" />
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
      <xs:element name="GetDocumentProperties">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="RequestedProperties" nillable="true" type="q16:ArrayOfstring" xmlns:q16="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentPropertiesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:StringDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentCommands">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="AllowedReturnTypes" nillable="true" type="q17:ArrayOfstring" xmlns:q17="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentCommandsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCommandInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfCommandInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="CommandInfo" nillable="true" type="tns:CommandInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCommandInfo" nillable="true" type="tns:ArrayOfCommandInfo" />
      <xs:complexType name="CommandInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DisplayTooltip" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="IconHint" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ReturnType" type="tns:ReturnType" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="CommandInfo" nillable="true" type="tns:CommandInfo" />
      <xs:element name="ExecuteDocumentCommand">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="VersionId" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="AllowedReturnTypes" nillable="true" type="q18:ArrayOfstring" xmlns:q18="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Command" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="AdditionalData" nillable="true" type="q19:ArrayOfstring" xmlns:q19="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExecuteDocumentCommandResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReturnInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultDocumentEntityFromSuggestion">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SuggestedDocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultDocumentEntityFromSuggestionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentEntity" />
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
      <xs:element name="SetDocumentStreamFromId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="Stream" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDocumentStreamFromIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SavePrivacyReport">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="HtmlReport" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SavePrivacyReportResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentIds" nillable="true" type="q20:ArrayOfint" xmlns:q20="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDocument">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Document" nillable="true" type="tns:Document" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDocument" nillable="true" type="tns:ArrayOfDocument" />
      <xs:element name="GetAppointmentDocuments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentDocumentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSaleDocuments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSaleDocumentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonDocuments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonDocumentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedDocument">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedDocumentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Document" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedDocuments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentIds" nillable="true" type="q21:ArrayOfint" xmlns:q21="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedDocumentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyPublishedDocuments">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyPublishedDocumentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedDocumentsByDate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeProjectDocuments" type="xs:boolean" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedDocumentsByDateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactDocumentsByTemplateTypes">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentTemplateIds" nillable="true" type="q22:ArrayOfint" xmlns:q22="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactDocumentsByTemplateTypesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactDocumentsByTemplateType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactDocumentsByTemplateTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactDocumentsByTemplateHeading">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TemplateHeadingId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactDocumentsByTemplateHeadingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactDocuments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactDocumentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedPersonDocumentsByDate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeProjectDocuments" type="xs:boolean" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedPersonDocumentsByDateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedProjectDocuments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedProjectDocumentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberDocumentsByTemplateTypes">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentTemplateIds" nillable="true" type="q23:ArrayOfint" xmlns:q23="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberDocumentsByTemplateTypesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberDocumentsByTemplateType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberDocumentsByTemplateTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberDocumentsByTemplateHeading">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TemplateHeadingId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberDocumentsByTemplateHeadingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberDocuments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberDocumentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectDocumentsByTemplateTypes">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentTemplateIds" nillable="true" type="q24:ArrayOfint" xmlns:q24="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectDocumentsByTemplateTypesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectDocumentsByTemplateType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectDocumentsByTemplateTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectDocumentsByTemplateHeading">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TemplateHeadingId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectDocumentsByTemplateHeadingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectDocuments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectDocumentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonDocumentsByTemplateTypes">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeProjectDocuments" type="xs:boolean" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentTemplateIds" nillable="true" type="q25:ArrayOfint" xmlns:q25="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonDocumentsByTemplateTypesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonDocumentsByTemplateType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeProjectDocuments" type="xs:boolean" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonDocumentsByTemplateTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonDocumentsByTemplateHeading">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeProjectDocuments" type="xs:boolean" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TemplateHeadingId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonDocumentsByTemplateHeadingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonDocumentsByDate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeProjectDocuments" type="xs:boolean" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonDocumentsByDateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentsByTemplateHeading">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TemplateHeadingId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDocumentsByTemplateHeadingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfDocument" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSuggestedDocumentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SuggestedDocumentEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSuggestedDocumentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SuggestedDocumentEntity" />
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
      <xs:complexType name="ArrayOfArrayOfstring">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArrayOfstring" nillable="true" type="tns:ArrayOfstring" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArrayOfstring" nillable="true" type="tns:ArrayOfArrayOfstring" />
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
  <wsdl:message name="CreateDefaultDocumentEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultDocumentEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultDocumentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDocumentEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveDocumentEntity" />
  </wsdl:message>
  <wsdl:message name="SaveDocumentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDocumentEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveDocumentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveDocumentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDocumentEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteDocumentEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteDocumentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDocumentEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteDocumentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteDocumentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSuggestedDocumentEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultSuggestedDocumentEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSuggestedDocumentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSuggestedDocumentEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultSuggestedDocumentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSuggestedDocumentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSuggestedDocumentEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveSuggestedDocumentEntity" />
  </wsdl:message>
  <wsdl:message name="SaveSuggestedDocumentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSuggestedDocumentEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveSuggestedDocumentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveSuggestedDocumentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTemplateVariablesParametersRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTemplateVariablesParameters" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTemplateVariablesParametersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTemplateVariablesParametersResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTemplateVariablesParametersResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTemplateVariablesParametersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentRequest">
    <wsdl:part name="parameters" element="tns:GetDocument" />
  </wsdl:message>
  <wsdl:message name="GetDocumentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentEntityRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentEntity" />
  </wsdl:message>
  <wsdl:message name="GetDocumentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentEntityResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentStreamFromEntityRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentStreamFromEntity" />
  </wsdl:message>
  <wsdl:message name="GetDocumentStreamFromEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentStreamFromEntityResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentStreamFromEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentStreamFromEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDocumentStreamRequest">
    <wsdl:part name="parameters" element="tns:SetDocumentStream" />
  </wsdl:message>
  <wsdl:message name="SetDocumentStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDocumentStreamResponse">
    <wsdl:part name="parameters" element="tns:SetDocumentStreamResponse" />
  </wsdl:message>
  <wsdl:message name="SetDocumentStreamResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDocumentStreamRequest">
    <wsdl:part name="parameters" element="tns:CreateDocumentStream" />
  </wsdl:message>
  <wsdl:message name="CreateDocumentStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDocumentStreamResponse">
    <wsdl:part name="parameters" element="tns:CreateDocumentStreamResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDocumentStreamResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTemplateStreamRequest">
    <wsdl:part name="parameters" element="tns:GetTemplateStream" />
  </wsdl:message>
  <wsdl:message name="GetTemplateStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTemplateStreamResponse">
    <wsdl:part name="parameters" element="tns:GetTemplateStreamResponse" />
  </wsdl:message>
  <wsdl:message name="GetTemplateStreamResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSanitizedTemplateStreamRequest">
    <wsdl:part name="parameters" element="tns:GetSanitizedTemplateStream" />
  </wsdl:message>
  <wsdl:message name="GetSanitizedTemplateStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSanitizedTemplateStreamResponse">
    <wsdl:part name="parameters" element="tns:GetSanitizedTemplateStreamResponse" />
  </wsdl:message>
  <wsdl:message name="GetSanitizedTemplateStreamResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTemplateStreamFromIdRequest">
    <wsdl:part name="parameters" element="tns:GetTemplateStreamFromId" />
  </wsdl:message>
  <wsdl:message name="GetTemplateStreamFromIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTemplateStreamFromIdResponse">
    <wsdl:part name="parameters" element="tns:GetTemplateStreamFromIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetTemplateStreamFromIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSanitizedTemplateStreamFromIdRequest">
    <wsdl:part name="parameters" element="tns:GetSanitizedTemplateStreamFromId" />
  </wsdl:message>
  <wsdl:message name="GetSanitizedTemplateStreamFromIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSanitizedTemplateStreamFromIdResponse">
    <wsdl:part name="parameters" element="tns:GetSanitizedTemplateStreamFromIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetSanitizedTemplateStreamFromIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentStreamRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentStream" />
  </wsdl:message>
  <wsdl:message name="GetDocumentStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentStreamResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentStreamResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentStreamResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSanitizedDocumentStreamRequest">
    <wsdl:part name="parameters" element="tns:GetSanitizedDocumentStream" />
  </wsdl:message>
  <wsdl:message name="GetSanitizedDocumentStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSanitizedDocumentStreamResponse">
    <wsdl:part name="parameters" element="tns:GetSanitizedDocumentStreamResponse" />
  </wsdl:message>
  <wsdl:message name="GetSanitizedDocumentStreamResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalMailMergeDocumentFromTemplateRequest">
    <wsdl:part name="parameters" element="tns:CreateNewPhysicalMailMergeDocumentFromTemplate" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalMailMergeDocumentFromTemplateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalMailMergeDocumentFromTemplateResponse">
    <wsdl:part name="parameters" element="tns:CreateNewPhysicalMailMergeDocumentFromTemplateResponse" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalMailMergeDocumentFromTemplateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromTemplateWithCustomTagsRequest">
    <wsdl:part name="parameters" element="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTags" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromTemplateWithCustomTagsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromTemplateWithCustomTagsResponse">
    <wsdl:part name="parameters" element="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTagsResponse" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromTemplateWithCustomTagsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromTemplateWithCustomTags2Request">
    <wsdl:part name="parameters" element="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTags2" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromTemplateWithCustomTags2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromTemplateWithCustomTags2Response">
    <wsdl:part name="parameters" element="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTags2Response" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromTemplateWithCustomTags2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SubstituteTemplateVariablesRequest">
    <wsdl:part name="parameters" element="tns:SubstituteTemplateVariables" />
  </wsdl:message>
  <wsdl:message name="SubstituteTemplateVariablesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SubstituteTemplateVariablesResponse">
    <wsdl:part name="parameters" element="tns:SubstituteTemplateVariablesResponse" />
  </wsdl:message>
  <wsdl:message name="SubstituteTemplateVariablesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SubstituteTemplateVariablesWithCustomTagsRequest">
    <wsdl:part name="parameters" element="tns:SubstituteTemplateVariablesWithCustomTags" />
  </wsdl:message>
  <wsdl:message name="SubstituteTemplateVariablesWithCustomTagsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SubstituteTemplateVariablesWithCustomTagsResponse">
    <wsdl:part name="parameters" element="tns:SubstituteTemplateVariablesWithCustomTagsResponse" />
  </wsdl:message>
  <wsdl:message name="SubstituteTemplateVariablesWithCustomTagsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SubstituteTemplateVariablesWithCustomTags2Request">
    <wsdl:part name="parameters" element="tns:SubstituteTemplateVariablesWithCustomTags2" />
  </wsdl:message>
  <wsdl:message name="SubstituteTemplateVariablesWithCustomTags2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SubstituteTemplateVariablesWithCustomTags2Response">
    <wsdl:part name="parameters" element="tns:SubstituteTemplateVariablesWithCustomTags2Response" />
  </wsdl:message>
  <wsdl:message name="SubstituteTemplateVariablesWithCustomTags2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTempFileRequest">
    <wsdl:part name="parameters" element="tns:CreateTempFile" />
  </wsdl:message>
  <wsdl:message name="CreateTempFileRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTempFileResponse">
    <wsdl:part name="parameters" element="tns:CreateTempFileResponse" />
  </wsdl:message>
  <wsdl:message name="CreateTempFileResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTempFileRequest">
    <wsdl:part name="parameters" element="tns:GetTempFile" />
  </wsdl:message>
  <wsdl:message name="GetTempFileRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTempFileResponse">
    <wsdl:part name="parameters" element="tns:GetTempFileResponse" />
  </wsdl:message>
  <wsdl:message name="GetTempFileResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteTempFileRequest">
    <wsdl:part name="parameters" element="tns:DeleteTempFile" />
  </wsdl:message>
  <wsdl:message name="DeleteTempFileRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteTempFileResponse">
    <wsdl:part name="parameters" element="tns:DeleteTempFileResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteTempFileResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetTemplateStreamRequest">
    <wsdl:part name="parameters" element="tns:SetTemplateStream" />
  </wsdl:message>
  <wsdl:message name="SetTemplateStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetTemplateStreamResponse">
    <wsdl:part name="parameters" element="tns:SetTemplateStreamResponse" />
  </wsdl:message>
  <wsdl:message name="SetTemplateStreamResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromTemplateRequest">
    <wsdl:part name="parameters" element="tns:CreateNewPhysicalDocumentFromTemplate" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromTemplateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromTemplateResponse">
    <wsdl:part name="parameters" element="tns:CreateNewPhysicalDocumentFromTemplateResponse" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromTemplateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SubstituteMergeDocumentTemplateVariablesRequest">
    <wsdl:part name="parameters" element="tns:SubstituteMergeDocumentTemplateVariables" />
  </wsdl:message>
  <wsdl:message name="SubstituteMergeDocumentTemplateVariablesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SubstituteMergeDocumentTemplateVariablesResponse">
    <wsdl:part name="parameters" element="tns:SubstituteMergeDocumentTemplateVariablesResponse" />
  </wsdl:message>
  <wsdl:message name="SubstituteMergeDocumentTemplateVariablesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SubstituteMergeDocumentTemplateVariables2Request">
    <wsdl:part name="parameters" element="tns:SubstituteMergeDocumentTemplateVariables2" />
  </wsdl:message>
  <wsdl:message name="SubstituteMergeDocumentTemplateVariables2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SubstituteMergeDocumentTemplateVariables2Response">
    <wsdl:part name="parameters" element="tns:SubstituteMergeDocumentTemplateVariables2Response" />
  </wsdl:message>
  <wsdl:message name="SubstituteMergeDocumentTemplateVariables2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SubstituteTemplateVariablesExRequest">
    <wsdl:part name="parameters" element="tns:SubstituteTemplateVariablesEx" />
  </wsdl:message>
  <wsdl:message name="SubstituteTemplateVariablesExRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SubstituteTemplateVariablesExResponse">
    <wsdl:part name="parameters" element="tns:SubstituteTemplateVariablesExResponse" />
  </wsdl:message>
  <wsdl:message name="SubstituteTemplateVariablesExResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="VerifyGetDocumentStreamRequest">
    <wsdl:part name="parameters" element="tns:VerifyGetDocumentStream" />
  </wsdl:message>
  <wsdl:message name="VerifyGetDocumentStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="VerifyGetDocumentStreamResponse">
    <wsdl:part name="parameters" element="tns:VerifyGetDocumentStreamResponse" />
  </wsdl:message>
  <wsdl:message name="VerifyGetDocumentStreamResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SubstituteMergeDocumentTemplateVariablesExRequest">
    <wsdl:part name="parameters" element="tns:SubstituteMergeDocumentTemplateVariablesEx" />
  </wsdl:message>
  <wsdl:message name="SubstituteMergeDocumentTemplateVariablesExRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SubstituteMergeDocumentTemplateVariablesExResponse">
    <wsdl:part name="parameters" element="tns:SubstituteMergeDocumentTemplateVariablesExResponse" />
  </wsdl:message>
  <wsdl:message name="SubstituteMergeDocumentTemplateVariablesExResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SubstituteMergeDocumentTemplateVariablesEx2Request">
    <wsdl:part name="parameters" element="tns:SubstituteMergeDocumentTemplateVariablesEx2" />
  </wsdl:message>
  <wsdl:message name="SubstituteMergeDocumentTemplateVariablesEx2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SubstituteMergeDocumentTemplateVariablesEx2Response">
    <wsdl:part name="parameters" element="tns:SubstituteMergeDocumentTemplateVariablesEx2Response" />
  </wsdl:message>
  <wsdl:message name="SubstituteMergeDocumentTemplateVariablesEx2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentUrlRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentUrl" />
  </wsdl:message>
  <wsdl:message name="GetDocumentUrlRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentUrlResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentUrlResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentUrlResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeletePhysicalDocumentRequest">
    <wsdl:part name="parameters" element="tns:DeletePhysicalDocument" />
  </wsdl:message>
  <wsdl:message name="DeletePhysicalDocumentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeletePhysicalDocumentResponse">
    <wsdl:part name="parameters" element="tns:DeletePhysicalDocumentResponse" />
  </wsdl:message>
  <wsdl:message name="DeletePhysicalDocumentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RenameDocumentRequest">
    <wsdl:part name="parameters" element="tns:RenameDocument" />
  </wsdl:message>
  <wsdl:message name="RenameDocumentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RenameDocumentResponse">
    <wsdl:part name="parameters" element="tns:RenameDocumentResponse" />
  </wsdl:message>
  <wsdl:message name="RenameDocumentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCheckoutStateRequest">
    <wsdl:part name="parameters" element="tns:GetCheckoutState" />
  </wsdl:message>
  <wsdl:message name="GetCheckoutStateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCheckoutStateResponse">
    <wsdl:part name="parameters" element="tns:GetCheckoutStateResponse" />
  </wsdl:message>
  <wsdl:message name="GetCheckoutStateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CheckoutDocumentRequest">
    <wsdl:part name="parameters" element="tns:CheckoutDocument" />
  </wsdl:message>
  <wsdl:message name="CheckoutDocumentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CheckoutDocumentResponse">
    <wsdl:part name="parameters" element="tns:CheckoutDocumentResponse" />
  </wsdl:message>
  <wsdl:message name="CheckoutDocumentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CheckinDocumentRequest">
    <wsdl:part name="parameters" element="tns:CheckinDocument" />
  </wsdl:message>
  <wsdl:message name="CheckinDocumentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CheckinDocumentResponse">
    <wsdl:part name="parameters" element="tns:CheckinDocumentResponse" />
  </wsdl:message>
  <wsdl:message name="CheckinDocumentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UndoCheckoutDocumentRequest">
    <wsdl:part name="parameters" element="tns:UndoCheckoutDocument" />
  </wsdl:message>
  <wsdl:message name="UndoCheckoutDocumentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UndoCheckoutDocumentResponse">
    <wsdl:part name="parameters" element="tns:UndoCheckoutDocumentResponse" />
  </wsdl:message>
  <wsdl:message name="UndoCheckoutDocumentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetVersionListRequest">
    <wsdl:part name="parameters" element="tns:GetVersionList" />
  </wsdl:message>
  <wsdl:message name="GetVersionListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetVersionListResponse">
    <wsdl:part name="parameters" element="tns:GetVersionListResponse" />
  </wsdl:message>
  <wsdl:message name="GetVersionListResponse_Headers">
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
  <wsdl:message name="GetDocumentPropertiesRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentProperties" />
  </wsdl:message>
  <wsdl:message name="GetDocumentPropertiesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentPropertiesResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentPropertiesResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentPropertiesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentCommandsRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentCommands" />
  </wsdl:message>
  <wsdl:message name="GetDocumentCommandsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentCommandsResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentCommandsResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentCommandsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExecuteDocumentCommandRequest">
    <wsdl:part name="parameters" element="tns:ExecuteDocumentCommand" />
  </wsdl:message>
  <wsdl:message name="ExecuteDocumentCommandRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExecuteDocumentCommandResponse">
    <wsdl:part name="parameters" element="tns:ExecuteDocumentCommandResponse" />
  </wsdl:message>
  <wsdl:message name="ExecuteDocumentCommandResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentEntityFromSuggestionRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultDocumentEntityFromSuggestion" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentEntityFromSuggestionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentEntityFromSuggestionResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultDocumentEntityFromSuggestionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDocumentEntityFromSuggestionResponse_Headers">
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
  <wsdl:message name="SetDocumentStreamFromIdRequest">
    <wsdl:part name="parameters" element="tns:SetDocumentStreamFromId" />
  </wsdl:message>
  <wsdl:message name="SetDocumentStreamFromIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDocumentStreamFromIdResponse">
    <wsdl:part name="parameters" element="tns:SetDocumentStreamFromIdResponse" />
  </wsdl:message>
  <wsdl:message name="SetDocumentStreamFromIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SavePrivacyReportRequest">
    <wsdl:part name="parameters" element="tns:SavePrivacyReport" />
  </wsdl:message>
  <wsdl:message name="SavePrivacyReportRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SavePrivacyReportResponse">
    <wsdl:part name="parameters" element="tns:SavePrivacyReportResponse" />
  </wsdl:message>
  <wsdl:message name="SavePrivacyReportResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentListRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentList" />
  </wsdl:message>
  <wsdl:message name="GetDocumentListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentListResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentListResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentDocumentsRequest">
    <wsdl:part name="parameters" element="tns:GetAppointmentDocuments" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentDocumentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentDocumentsResponse">
    <wsdl:part name="parameters" element="tns:GetAppointmentDocumentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentDocumentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleDocumentsRequest">
    <wsdl:part name="parameters" element="tns:GetSaleDocuments" />
  </wsdl:message>
  <wsdl:message name="GetSaleDocumentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleDocumentsResponse">
    <wsdl:part name="parameters" element="tns:GetSaleDocumentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetSaleDocumentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsRequest">
    <wsdl:part name="parameters" element="tns:GetPersonDocuments" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsResponse">
    <wsdl:part name="parameters" element="tns:GetPersonDocumentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedDocumentRequest">
    <wsdl:part name="parameters" element="tns:GetPublishedDocument" />
  </wsdl:message>
  <wsdl:message name="GetPublishedDocumentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedDocumentResponse">
    <wsdl:part name="parameters" element="tns:GetPublishedDocumentResponse" />
  </wsdl:message>
  <wsdl:message name="GetPublishedDocumentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedDocumentsRequest">
    <wsdl:part name="parameters" element="tns:GetPublishedDocuments" />
  </wsdl:message>
  <wsdl:message name="GetPublishedDocumentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedDocumentsResponse">
    <wsdl:part name="parameters" element="tns:GetPublishedDocumentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetPublishedDocumentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyPublishedDocumentsRequest">
    <wsdl:part name="parameters" element="tns:GetMyPublishedDocuments" />
  </wsdl:message>
  <wsdl:message name="GetMyPublishedDocumentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyPublishedDocumentsResponse">
    <wsdl:part name="parameters" element="tns:GetMyPublishedDocumentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyPublishedDocumentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedDocumentsByDateRequest">
    <wsdl:part name="parameters" element="tns:GetPublishedDocumentsByDate" />
  </wsdl:message>
  <wsdl:message name="GetPublishedDocumentsByDateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedDocumentsByDateResponse">
    <wsdl:part name="parameters" element="tns:GetPublishedDocumentsByDateResponse" />
  </wsdl:message>
  <wsdl:message name="GetPublishedDocumentsByDateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactDocumentsByTemplateTypesRequest">
    <wsdl:part name="parameters" element="tns:GetContactDocumentsByTemplateTypes" />
  </wsdl:message>
  <wsdl:message name="GetContactDocumentsByTemplateTypesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactDocumentsByTemplateTypesResponse">
    <wsdl:part name="parameters" element="tns:GetContactDocumentsByTemplateTypesResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactDocumentsByTemplateTypesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactDocumentsByTemplateTypeRequest">
    <wsdl:part name="parameters" element="tns:GetContactDocumentsByTemplateType" />
  </wsdl:message>
  <wsdl:message name="GetContactDocumentsByTemplateTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactDocumentsByTemplateTypeResponse">
    <wsdl:part name="parameters" element="tns:GetContactDocumentsByTemplateTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactDocumentsByTemplateTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactDocumentsByTemplateHeadingRequest">
    <wsdl:part name="parameters" element="tns:GetContactDocumentsByTemplateHeading" />
  </wsdl:message>
  <wsdl:message name="GetContactDocumentsByTemplateHeadingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactDocumentsByTemplateHeadingResponse">
    <wsdl:part name="parameters" element="tns:GetContactDocumentsByTemplateHeadingResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactDocumentsByTemplateHeadingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactDocumentsRequest">
    <wsdl:part name="parameters" element="tns:GetContactDocuments" />
  </wsdl:message>
  <wsdl:message name="GetContactDocumentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactDocumentsResponse">
    <wsdl:part name="parameters" element="tns:GetContactDocumentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactDocumentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedPersonDocumentsByDateRequest">
    <wsdl:part name="parameters" element="tns:GetPublishedPersonDocumentsByDate" />
  </wsdl:message>
  <wsdl:message name="GetPublishedPersonDocumentsByDateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedPersonDocumentsByDateResponse">
    <wsdl:part name="parameters" element="tns:GetPublishedPersonDocumentsByDateResponse" />
  </wsdl:message>
  <wsdl:message name="GetPublishedPersonDocumentsByDateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectDocumentsRequest">
    <wsdl:part name="parameters" element="tns:GetPublishedProjectDocuments" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectDocumentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectDocumentsResponse">
    <wsdl:part name="parameters" element="tns:GetPublishedProjectDocumentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectDocumentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberDocumentsByTemplateTypesRequest">
    <wsdl:part name="parameters" element="tns:GetProjectMemberDocumentsByTemplateTypes" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberDocumentsByTemplateTypesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberDocumentsByTemplateTypesResponse">
    <wsdl:part name="parameters" element="tns:GetProjectMemberDocumentsByTemplateTypesResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberDocumentsByTemplateTypesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberDocumentsByTemplateTypeRequest">
    <wsdl:part name="parameters" element="tns:GetProjectMemberDocumentsByTemplateType" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberDocumentsByTemplateTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberDocumentsByTemplateTypeResponse">
    <wsdl:part name="parameters" element="tns:GetProjectMemberDocumentsByTemplateTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberDocumentsByTemplateTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberDocumentsByTemplateHeadingRequest">
    <wsdl:part name="parameters" element="tns:GetProjectMemberDocumentsByTemplateHeading" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberDocumentsByTemplateHeadingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberDocumentsByTemplateHeadingResponse">
    <wsdl:part name="parameters" element="tns:GetProjectMemberDocumentsByTemplateHeadingResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberDocumentsByTemplateHeadingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberDocumentsRequest">
    <wsdl:part name="parameters" element="tns:GetProjectMemberDocuments" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberDocumentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberDocumentsResponse">
    <wsdl:part name="parameters" element="tns:GetProjectMemberDocumentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberDocumentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectDocumentsByTemplateTypesRequest">
    <wsdl:part name="parameters" element="tns:GetProjectDocumentsByTemplateTypes" />
  </wsdl:message>
  <wsdl:message name="GetProjectDocumentsByTemplateTypesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectDocumentsByTemplateTypesResponse">
    <wsdl:part name="parameters" element="tns:GetProjectDocumentsByTemplateTypesResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectDocumentsByTemplateTypesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectDocumentsByTemplateTypeRequest">
    <wsdl:part name="parameters" element="tns:GetProjectDocumentsByTemplateType" />
  </wsdl:message>
  <wsdl:message name="GetProjectDocumentsByTemplateTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectDocumentsByTemplateTypeResponse">
    <wsdl:part name="parameters" element="tns:GetProjectDocumentsByTemplateTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectDocumentsByTemplateTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectDocumentsByTemplateHeadingRequest">
    <wsdl:part name="parameters" element="tns:GetProjectDocumentsByTemplateHeading" />
  </wsdl:message>
  <wsdl:message name="GetProjectDocumentsByTemplateHeadingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectDocumentsByTemplateHeadingResponse">
    <wsdl:part name="parameters" element="tns:GetProjectDocumentsByTemplateHeadingResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectDocumentsByTemplateHeadingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectDocumentsRequest">
    <wsdl:part name="parameters" element="tns:GetProjectDocuments" />
  </wsdl:message>
  <wsdl:message name="GetProjectDocumentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectDocumentsResponse">
    <wsdl:part name="parameters" element="tns:GetProjectDocumentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectDocumentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsByTemplateTypesRequest">
    <wsdl:part name="parameters" element="tns:GetPersonDocumentsByTemplateTypes" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsByTemplateTypesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsByTemplateTypesResponse">
    <wsdl:part name="parameters" element="tns:GetPersonDocumentsByTemplateTypesResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsByTemplateTypesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsByTemplateTypeRequest">
    <wsdl:part name="parameters" element="tns:GetPersonDocumentsByTemplateType" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsByTemplateTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsByTemplateTypeResponse">
    <wsdl:part name="parameters" element="tns:GetPersonDocumentsByTemplateTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsByTemplateTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsByTemplateHeadingRequest">
    <wsdl:part name="parameters" element="tns:GetPersonDocumentsByTemplateHeading" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsByTemplateHeadingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsByTemplateHeadingResponse">
    <wsdl:part name="parameters" element="tns:GetPersonDocumentsByTemplateHeadingResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsByTemplateHeadingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsByDateRequest">
    <wsdl:part name="parameters" element="tns:GetPersonDocumentsByDate" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsByDateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsByDateResponse">
    <wsdl:part name="parameters" element="tns:GetPersonDocumentsByDateResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonDocumentsByDateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentsByTemplateHeadingRequest">
    <wsdl:part name="parameters" element="tns:GetDocumentsByTemplateHeading" />
  </wsdl:message>
  <wsdl:message name="GetDocumentsByTemplateHeadingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDocumentsByTemplateHeadingResponse">
    <wsdl:part name="parameters" element="tns:GetDocumentsByTemplateHeadingResponse" />
  </wsdl:message>
  <wsdl:message name="GetDocumentsByTemplateHeadingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedDocumentEntityRequest">
    <wsdl:part name="parameters" element="tns:GetSuggestedDocumentEntity" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedDocumentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedDocumentEntityResponse">
    <wsdl:part name="parameters" element="tns:GetSuggestedDocumentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedDocumentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Document">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Document</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultDocumentEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new DocumentEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateDefaultDocumentEntity" name="CreateDefaultDocumentEntityRequest" message="tns:CreateDefaultDocumentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateDefaultDocumentEntityResponse" name="CreateDefaultDocumentEntityResponse" message="tns:CreateDefaultDocumentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveDocumentEntity">
      <wsdl:documentation>
        <summary>Updates the existing DocumentEntity or creates a new DocumentEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SaveDocumentEntity" name="SaveDocumentEntityRequest" message="tns:SaveDocumentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SaveDocumentEntityResponse" name="SaveDocumentEntityResponse" message="tns:SaveDocumentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteDocumentEntity">
      <wsdl:documentation>
        <summary>Deletes the DocumentEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/DeleteDocumentEntity" name="DeleteDocumentEntityRequest" message="tns:DeleteDocumentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/DeleteDocumentEntityResponse" name="DeleteDocumentEntityResponse" message="tns:DeleteDocumentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultSuggestedDocumentEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new SuggestedDocumentEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateDefaultSuggestedDocumentEntity" name="CreateDefaultSuggestedDocumentEntityRequest" message="tns:CreateDefaultSuggestedDocumentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateDefaultSuggestedDocumentEntityResponse" name="CreateDefaultSuggestedDocumentEntityResponse" message="tns:CreateDefaultSuggestedDocumentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveSuggestedDocumentEntity">
      <wsdl:documentation>
        <summary>Updates the existing SuggestedDocumentEntity or creates a new SuggestedDocumentEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SaveSuggestedDocumentEntity" name="SaveSuggestedDocumentEntityRequest" message="tns:SaveSuggestedDocumentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SaveSuggestedDocumentEntityResponse" name="SaveSuggestedDocumentEntityResponse" message="tns:SaveSuggestedDocumentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTemplateVariablesParameters">
      <wsdl:documentation>
        <summary>Loading default values into a new TemplateVariablesParameters.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateDefaultTemplateVariablesParameters" name="CreateDefaultTemplateVariablesParametersRequest" message="tns:CreateDefaultTemplateVariablesParametersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateDefaultTemplateVariablesParametersResponse" name="CreateDefaultTemplateVariablesParametersResponse" message="tns:CreateDefaultTemplateVariablesParametersResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocument">
      <wsdl:documentation>
        <summary>Gets a Document object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocument" name="GetDocumentRequest" message="tns:GetDocumentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentResponse" name="GetDocumentResponse" message="tns:GetDocumentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentEntity">
      <wsdl:documentation>
        <summary>Gets a DocumentEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentEntity" name="GetDocumentEntityRequest" message="tns:GetDocumentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentEntityResponse" name="GetDocumentEntityResponse" message="tns:GetDocumentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentStreamFromEntity">
      <wsdl:documentation>
        <summary>Get the document as a stream</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentStreamFromEntity" name="GetDocumentStreamFromEntityRequest" message="tns:GetDocumentStreamFromEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentStreamFromEntityResponse" name="GetDocumentStreamFromEntityResponse" message="tns:GetDocumentStreamFromEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetDocumentStream">
      <wsdl:documentation>
        <summary>Store a document's contents from its stream. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SetDocumentStream" name="SetDocumentStreamRequest" message="tns:SetDocumentStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SetDocumentStreamResponse" name="SetDocumentStreamResponse" message="tns:SetDocumentStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDocumentStream">
      <wsdl:documentation>
        <summary>Creates a new Stream that can be used to store the document in the file archive.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateDocumentStream" name="CreateDocumentStreamRequest" message="tns:CreateDocumentStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateDocumentStreamResponse" name="CreateDocumentStreamResponse" message="tns:CreateDocumentStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTemplateStream">
      <wsdl:documentation>
        <summary>Retrieve a stream to a mail template based on its name</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetTemplateStream" name="GetTemplateStreamRequest" message="tns:GetTemplateStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetTemplateStreamResponse" name="GetTemplateStreamResponse" message="tns:GetTemplateStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSanitizedTemplateStream">
      <wsdl:documentation>
        <summary>Retrieve a stream to a mail template based on its name. Sanitizes the contents if possible.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetSanitizedTemplateStream" name="GetSanitizedTemplateStreamRequest" message="tns:GetSanitizedTemplateStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetSanitizedTemplateStreamResponse" name="GetSanitizedTemplateStreamResponse" message="tns:GetSanitizedTemplateStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTemplateStreamFromId">
      <wsdl:documentation>
        <summary>Retrieve a stream to a document template based on its id</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetTemplateStreamFromId" name="GetTemplateStreamFromIdRequest" message="tns:GetTemplateStreamFromIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetTemplateStreamFromIdResponse" name="GetTemplateStreamFromIdResponse" message="tns:GetTemplateStreamFromIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSanitizedTemplateStreamFromId">
      <wsdl:documentation>
        <summary>Retrieve a stream to a document template based on its id. Sanitizes the contents if possible.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetSanitizedTemplateStreamFromId" name="GetSanitizedTemplateStreamFromIdRequest" message="tns:GetSanitizedTemplateStreamFromIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetSanitizedTemplateStreamFromIdResponse" name="GetSanitizedTemplateStreamFromIdResponse" message="tns:GetSanitizedTemplateStreamFromIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentStream">
      <wsdl:documentation>
        <summary>Get the document content as a stream</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentStream" name="GetDocumentStreamRequest" message="tns:GetDocumentStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentStreamResponse" name="GetDocumentStreamResponse" message="tns:GetDocumentStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSanitizedDocumentStream">
      <wsdl:documentation>
        <summary>Get the document content as a stream. Retrieves a sanitized version if possible</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetSanitizedDocumentStream" name="GetSanitizedDocumentStreamRequest" message="tns:GetSanitizedDocumentStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetSanitizedDocumentStreamResponse" name="GetSanitizedDocumentStreamResponse" message="tns:GetSanitizedDocumentStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateNewPhysicalMailMergeDocumentFromTemplate">
      <wsdl:documentation>
        <summary>Create a new physical document based on the documents template. Do not replace template tags, as the document is going to be used as a mail merge source. Use GetDocumentStream to obtain the created documents. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateNewPhysicalMailMergeDocumentFromTemplate" name="CreateNewPhysicalMailMergeDocumentFromTemplateRequest" message="tns:CreateNewPhysicalMailMergeDocumentFromTemplateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateNewPhysicalMailMergeDocumentFromTemplateResponse" name="CreateNewPhysicalMailMergeDocumentFromTemplateResponse" message="tns:CreateNewPhysicalMailMergeDocumentFromTemplateResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateNewPhysicalDocumentFromTemplateWithCustomTags">
      <wsdl:documentation>
        <summary>Create a new physical document based on a document template and store it in the document archive.  Tags are substituted according to the provided id's.  Use GetDocumentStream to obtain the created document content. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags" name="CreateNewPhysicalDocumentFromTemplateWithCustomTagsRequest" message="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTagsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTagsResponse" name="CreateNewPhysicalDocumentFromTemplateWithCustomTagsResponse" message="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTagsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateNewPhysicalDocumentFromTemplateWithCustomTags2">
      <wsdl:documentation>
        <summary>Create a new physical document based on a document template and store it in the document archive.  Tags are substituted according to the provided id's.  Use GetDocumentStream to obtain the created document content. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags2" name="CreateNewPhysicalDocumentFromTemplateWithCustomTags2Request" message="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTags2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags2Response" name="CreateNewPhysicalDocumentFromTemplateWithCustomTags2Response" message="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTags2Response" />
    </wsdl:operation>
    <wsdl:operation name="SubstituteTemplateVariables">
      <wsdl:documentation>
        <summary>Parse the source string, and replace any template variable tags with their values, based on the ID's given in the other parameters.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteTemplateVariables" name="SubstituteTemplateVariablesRequest" message="tns:SubstituteTemplateVariablesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteTemplateVariablesResponse" name="SubstituteTemplateVariablesResponse" message="tns:SubstituteTemplateVariablesResponse" />
    </wsdl:operation>
    <wsdl:operation name="SubstituteTemplateVariablesWithCustomTags">
      <wsdl:documentation>
        <summary>Parse the source string, and replace any template variable tags with their values, based on the ID's given in the other parameters.&lt;p/&gt;This method also takes a pair of arrays specifying custom tags and their values; these tags will be available during substitution in addition to all the existing tags. Custom values will override values otherwise set.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteTemplateVariablesWithCustomTags" name="SubstituteTemplateVariablesWithCustomTagsRequest" message="tns:SubstituteTemplateVariablesWithCustomTagsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteTemplateVariablesWithCustomTagsResponse" name="SubstituteTemplateVariablesWithCustomTagsResponse" message="tns:SubstituteTemplateVariablesWithCustomTagsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SubstituteTemplateVariablesWithCustomTags2">
      <wsdl:documentation>
        <summary>Parse the source string, and replace any template variable tags with their values, based on the ID's given in the other parameters.&lt;p/&gt;This method also takes a pair of arrays specifying custom tags and their values; these tags will be available during substitution in addition to all the existing tags. Custom values will override values otherwise set.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteTemplateVariablesWithCustomTags2" name="SubstituteTemplateVariablesWithCustomTags2Request" message="tns:SubstituteTemplateVariablesWithCustomTags2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteTemplateVariablesWithCustomTags2Response" name="SubstituteTemplateVariablesWithCustomTags2Response" message="tns:SubstituteTemplateVariablesWithCustomTags2Response" />
    </wsdl:operation>
    <wsdl:operation name="CreateTempFile">
      <wsdl:documentation>
        <summary>Create a new temporary file based on the provided stream.  Specified filename may be overridden, and actual name is returned.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateTempFile" name="CreateTempFileRequest" message="tns:CreateTempFileRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateTempFileResponse" name="CreateTempFileResponse" message="tns:CreateTempFileResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTempFile">
      <wsdl:documentation>
        <summary>Get data stream for temporary file created with CreateTempFile.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetTempFile" name="GetTempFileRequest" message="tns:GetTempFileRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetTempFileResponse" name="GetTempFileResponse" message="tns:GetTempFileResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteTempFile">
      <wsdl:documentation>
        <summary>Delete a temporary file created with CreateTempFile.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/DeleteTempFile" name="DeleteTempFileRequest" message="tns:DeleteTempFileRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/DeleteTempFileResponse" name="DeleteTempFileResponse" message="tns:DeleteTempFileResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetTemplateStream">
      <wsdl:documentation>
        <summary>Save a mail signature template to the document archive</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SetTemplateStream" name="SetTemplateStreamRequest" message="tns:SetTemplateStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SetTemplateStreamResponse" name="SetTemplateStreamResponse" message="tns:SetTemplateStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateNewPhysicalDocumentFromTemplate">
      <wsdl:documentation>
        <summary>Create a new document content based on a document template and store it in the document archive.  Tags are substituted according to the provided id's.  Use GetDocumentStream to obtain the created document. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateNewPhysicalDocumentFromTemplate" name="CreateNewPhysicalDocumentFromTemplateRequest" message="tns:CreateNewPhysicalDocumentFromTemplateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateNewPhysicalDocumentFromTemplateResponse" name="CreateNewPhysicalDocumentFromTemplateResponse" message="tns:CreateNewPhysicalDocumentFromTemplateResponse" />
    </wsdl:operation>
    <wsdl:operation name="SubstituteMergeDocumentTemplateVariables">
      <wsdl:documentation>
        <summary>Parse the source document, and replace any template variable tags with their values, based on the associate Id.&lt;p/&gt; The source document should be of type MergeDraft. This method also takes a pair of arrays specifying custom tags and their values; these tags will be available during substitution in addition to all the existing tags. Custom values will override values otherwise set.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteMergeDocumentTemplateVariables" name="SubstituteMergeDocumentTemplateVariablesRequest" message="tns:SubstituteMergeDocumentTemplateVariablesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteMergeDocumentTemplateVariablesResponse" name="SubstituteMergeDocumentTemplateVariablesResponse" message="tns:SubstituteMergeDocumentTemplateVariablesResponse" />
    </wsdl:operation>
    <wsdl:operation name="SubstituteMergeDocumentTemplateVariables2">
      <wsdl:documentation>
        <summary>Parse the source document, and replace any template variable tags with their values, based on the associate Id.&lt;p/&gt; The source document should be of type MergeDraft. This method also takes a pair of arrays specifying custom tags and their values; these tags will be available during substitution in addition to all the existing tags. Custom values will override values otherwise set.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteMergeDocumentTemplateVariables2" name="SubstituteMergeDocumentTemplateVariables2Request" message="tns:SubstituteMergeDocumentTemplateVariables2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteMergeDocumentTemplateVariables2Response" name="SubstituteMergeDocumentTemplateVariables2Response" message="tns:SubstituteMergeDocumentTemplateVariables2Response" />
    </wsdl:operation>
    <wsdl:operation name="SubstituteTemplateVariablesEx">
      <wsdl:documentation>
        <summary>Parse the source string, and replace any template variable tags with their values, based on the identities, custom values and entities specified in the other parameters.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteTemplateVariablesEx" name="SubstituteTemplateVariablesExRequest" message="tns:SubstituteTemplateVariablesExRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteTemplateVariablesExResponse" name="SubstituteTemplateVariablesExResponse" message="tns:SubstituteTemplateVariablesExResponse" />
    </wsdl:operation>
    <wsdl:operation name="VerifyGetDocumentStream">
      <wsdl:documentation>
        <summary>Verify that the requested document stream exists, and that we can access it, without actually getting the stream.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/VerifyGetDocumentStream" name="VerifyGetDocumentStreamRequest" message="tns:VerifyGetDocumentStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/VerifyGetDocumentStreamResponse" name="VerifyGetDocumentStreamResponse" message="tns:VerifyGetDocumentStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="SubstituteMergeDocumentTemplateVariablesEx">
      <wsdl:documentation>
        <summary>Parse the source document, and replace any template variable tags with their values, based on the provided identifiers.&lt;p/&gt; The source document should be of type MergeDraft. This method also takes a pair of arrays specifying custom tags and their values; these tags will be available during substitution in addition to all the existing tags. Custom values will override values otherwise set.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteMergeDocumentTemplateVariablesEx" name="SubstituteMergeDocumentTemplateVariablesExRequest" message="tns:SubstituteMergeDocumentTemplateVariablesExRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteMergeDocumentTemplateVariablesExResponse" name="SubstituteMergeDocumentTemplateVariablesExResponse" message="tns:SubstituteMergeDocumentTemplateVariablesExResponse" />
    </wsdl:operation>
    <wsdl:operation name="SubstituteMergeDocumentTemplateVariablesEx2">
      <wsdl:documentation>
        <summary>Parse the source document, and replace any template variable tags with their values, based on the provided identifiers.&lt;p/&gt; The source document should be of type MergeDraft. This method also takes a pair of arrays specifying custom tags and their values; these tags will be available during substitution in addition to all the existing tags. Custom values will override values otherwise set.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteMergeDocumentTemplateVariablesEx2" name="SubstituteMergeDocumentTemplateVariablesEx2Request" message="tns:SubstituteMergeDocumentTemplateVariablesEx2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteMergeDocumentTemplateVariablesEx2Response" name="SubstituteMergeDocumentTemplateVariablesEx2Response" message="tns:SubstituteMergeDocumentTemplateVariablesEx2Response" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentUrl">
      <wsdl:documentation>
        <summary>Get a URL referring to the given document content.&lt;para/&gt;This URL may be passed to the ultimate client (text editor of some kind?), which is then responsible for all further operations.&lt;para/&gt;The returned string is a fully qualified URL.&lt;para/&gt;Not all documents and document plugins support this feature.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentUrl" name="GetDocumentUrlRequest" message="tns:GetDocumentUrlRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentUrlResponse" name="GetDocumentUrlResponse" message="tns:GetDocumentUrlResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeletePhysicalDocument">
      <wsdl:documentation>
        <summary>Delete the document contents</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/DeletePhysicalDocument" name="DeletePhysicalDocumentRequest" message="tns:DeletePhysicalDocumentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/DeletePhysicalDocumentResponse" name="DeletePhysicalDocumentResponse" message="tns:DeletePhysicalDocumentResponse" />
    </wsdl:operation>
    <wsdl:operation name="RenameDocument">
      <wsdl:documentation>
        <summary>Rename the physical document, i.e., change the file name or equivalent concept in the document archive.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/RenameDocument" name="RenameDocumentRequest" message="tns:RenameDocumentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/RenameDocumentResponse" name="RenameDocumentResponse" message="tns:RenameDocumentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCheckoutState">
      <wsdl:documentation>
        <summary>Get the current checkout state for a document, relative to the user perforing the call.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetCheckoutState" name="GetCheckoutStateRequest" message="tns:GetCheckoutStateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetCheckoutStateResponse" name="GetCheckoutStateResponse" message="tns:GetCheckoutStateResponse" />
    </wsdl:operation>
    <wsdl:operation name="CheckoutDocument">
      <wsdl:documentation>
        <summary>Check out a document for editing by the current user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CheckoutDocument" name="CheckoutDocumentRequest" message="tns:CheckoutDocumentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CheckoutDocumentResponse" name="CheckoutDocumentResponse" message="tns:CheckoutDocumentResponse" />
    </wsdl:operation>
    <wsdl:operation name="CheckinDocument">
      <wsdl:documentation>
        <summary>Check in a currently checked-out document</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CheckinDocument" name="CheckinDocumentRequest" message="tns:CheckinDocumentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CheckinDocumentResponse" name="CheckinDocumentResponse" message="tns:CheckinDocumentResponse" />
    </wsdl:operation>
    <wsdl:operation name="UndoCheckoutDocument">
      <wsdl:documentation>
        <summary>Undo (abandon) a checkout</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/UndoCheckoutDocument" name="UndoCheckoutDocumentRequest" message="tns:UndoCheckoutDocumentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/UndoCheckoutDocumentResponse" name="UndoCheckoutDocumentResponse" message="tns:UndoCheckoutDocumentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetVersionList">
      <wsdl:documentation>
        <summary>Get a list of existing, committed  versions for a given document</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetVersionList" name="GetVersionListRequest" message="tns:GetVersionListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetVersionListResponse" name="GetVersionListResponse" message="tns:GetVersionListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPluginList">
      <wsdl:documentation>
        <summary>Get a list of installed document plugins</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPluginList" name="GetPluginListRequest" message="tns:GetPluginListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPluginListResponse" name="GetPluginListResponse" message="tns:GetPluginListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPluginCapabilities">
      <wsdl:documentation>
        <summary>Get a list of plugin-dependent capabilities for a given document archive plugin.&lt;br/&gt;A standard set of properties is defined in SuperOffice.CRM.Documents.Constants.Capabilities.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPluginCapabilities" name="GetPluginCapabilitiesRequest" message="tns:GetPluginCapabilitiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPluginCapabilitiesResponse" name="GetPluginCapabilitiesResponse" message="tns:GetPluginCapabilitiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentProperties">
      <wsdl:documentation>
        <summary>Get plugin-dependent properties for the document. A number of standard properties that should be supported by all plugins are defined in SuperOffice.CRM.Documents.Constants.Properties.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentProperties" name="GetDocumentPropertiesRequest" message="tns:GetDocumentPropertiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentPropertiesResponse" name="GetDocumentPropertiesResponse" message="tns:GetDocumentPropertiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentCommands">
      <wsdl:documentation>
        <summary>Get a list of custom commands valid for the specific document at this time. This information should not be cached by clients, as it may change between documents and over time.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentCommands" name="GetDocumentCommandsRequest" message="tns:GetDocumentCommandsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentCommandsResponse" name="GetDocumentCommandsResponse" message="tns:GetDocumentCommandsResponse" />
    </wsdl:operation>
    <wsdl:operation name="ExecuteDocumentCommand">
      <wsdl:documentation>
        <summary>Execute a custom command on a particular document, optionally a particular version</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/ExecuteDocumentCommand" name="ExecuteDocumentCommandRequest" message="tns:ExecuteDocumentCommandRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/ExecuteDocumentCommandResponse" name="ExecuteDocumentCommandResponse" message="tns:ExecuteDocumentCommandResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultDocumentEntityFromSuggestion">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateDefaultDocumentEntityFromSuggestion" name="CreateDefaultDocumentEntityFromSuggestionRequest" message="tns:CreateDefaultDocumentEntityFromSuggestionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateDefaultDocumentEntityFromSuggestionResponse" name="CreateDefaultDocumentEntityFromSuggestionResponse" message="tns:CreateDefaultDocumentEntityFromSuggestionResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveDocumentTemplateStream">
      <wsdl:documentation>
        <summary>Saves content in stream to document template file</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SaveDocumentTemplateStream" name="SaveDocumentTemplateStreamRequest" message="tns:SaveDocumentTemplateStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SaveDocumentTemplateStreamResponse" name="SaveDocumentTemplateStreamResponse" message="tns:SaveDocumentTemplateStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetDocumentStreamFromId">
      <wsdl:documentation>
        <summary>Store document content from stream. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SetDocumentStreamFromId" name="SetDocumentStreamFromIdRequest" message="tns:SetDocumentStreamFromIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SetDocumentStreamFromIdResponse" name="SetDocumentStreamFromIdResponse" message="tns:SetDocumentStreamFromIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="SavePrivacyReport">
      <wsdl:documentation>
        <summary>Generates a Pdf from HTML and makes a document</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SavePrivacyReport" name="SavePrivacyReportRequest" message="tns:SavePrivacyReportRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SavePrivacyReportResponse" name="SavePrivacyReportResponse" message="tns:SavePrivacyReportResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentList">
      <wsdl:documentation>
        <summary>Gets an array of Document objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentList" name="GetDocumentListRequest" message="tns:GetDocumentListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentListResponse" name="GetDocumentListResponse" message="tns:GetDocumentListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentDocuments">
      <wsdl:documentation>
        <summary>Get all documents that are linked to the appointment. I.e. the documents that are listed in the appointment dialog.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetAppointmentDocuments" name="GetAppointmentDocumentsRequest" message="tns:GetAppointmentDocumentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetAppointmentDocumentsResponse" name="GetAppointmentDocumentsResponse" message="tns:GetAppointmentDocumentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSaleDocuments">
      <wsdl:documentation>
        <summary>Get all documents that are linked to the sale. I.e. the documents that are listed in the sale dialog.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetSaleDocuments" name="GetSaleDocumentsRequest" message="tns:GetSaleDocumentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetSaleDocumentsResponse" name="GetSaleDocumentsResponse" message="tns:GetSaleDocumentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonDocuments">
      <wsdl:documentation>
        <summary>Get all documents that are linked to the person. I.e. the documents that are listed in the person dialog.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPersonDocuments" name="GetPersonDocumentsRequest" message="tns:GetPersonDocumentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPersonDocumentsResponse" name="GetPersonDocumentsResponse" message="tns:GetPersonDocumentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPublishedDocument">
      <wsdl:documentation>
        <summary>Get the document if it's published</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPublishedDocument" name="GetPublishedDocumentRequest" message="tns:GetPublishedDocumentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPublishedDocumentResponse" name="GetPublishedDocumentResponse" message="tns:GetPublishedDocumentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPublishedDocuments">
      <wsdl:documentation>
        <summary>Get the published documents from an array of doucment ids.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPublishedDocuments" name="GetPublishedDocumentsRequest" message="tns:GetPublishedDocumentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPublishedDocumentsResponse" name="GetPublishedDocumentsResponse" message="tns:GetPublishedDocumentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyPublishedDocuments">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetMyPublishedDocuments" name="GetMyPublishedDocumentsRequest" message="tns:GetMyPublishedDocumentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetMyPublishedDocumentsResponse" name="GetMyPublishedDocumentsResponse" message="tns:GetMyPublishedDocumentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPublishedDocumentsByDate">
      <wsdl:documentation>
        <summary>Method that returns a specified number of published document appointments within a time range. The document appointments is visible to the person specified or the document is in a project the person belongs to. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPublishedDocumentsByDate" name="GetPublishedDocumentsByDateRequest" message="tns:GetPublishedDocumentsByDateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPublishedDocumentsByDateResponse" name="GetPublishedDocumentsByDateResponse" message="tns:GetPublishedDocumentsByDateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactDocumentsByTemplateTypes">
      <wsdl:documentation>
        <summary>Method that returns a specified number of document appointments within a time range, filtered by document template types. The document appointments belong to the contact specified. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetContactDocumentsByTemplateTypes" name="GetContactDocumentsByTemplateTypesRequest" message="tns:GetContactDocumentsByTemplateTypesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetContactDocumentsByTemplateTypesResponse" name="GetContactDocumentsByTemplateTypesResponse" message="tns:GetContactDocumentsByTemplateTypesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactDocumentsByTemplateType">
      <wsdl:documentation>
        <summary>Method that returns a specified number of document appointments within a time range, filtered by document template type. The document appointments belong to the contact specified. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetContactDocumentsByTemplateType" name="GetContactDocumentsByTemplateTypeRequest" message="tns:GetContactDocumentsByTemplateTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetContactDocumentsByTemplateTypeResponse" name="GetContactDocumentsByTemplateTypeResponse" message="tns:GetContactDocumentsByTemplateTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactDocumentsByTemplateHeading">
      <wsdl:documentation>
        <summary>Method that returns a specified number of document appointments within a time range, filtered by the document template heading. The document appointments belong to the contact specified. The heading represents a grouping or filtering of document templates.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetContactDocumentsByTemplateHeading" name="GetContactDocumentsByTemplateHeadingRequest" message="tns:GetContactDocumentsByTemplateHeadingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetContactDocumentsByTemplateHeadingResponse" name="GetContactDocumentsByTemplateHeadingResponse" message="tns:GetContactDocumentsByTemplateHeadingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactDocuments">
      <wsdl:documentation>
        <summary>Method that returns a specified number of document appointments within a time range. The document appointments belong to the contact specified. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetContactDocuments" name="GetContactDocumentsRequest" message="tns:GetContactDocumentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetContactDocumentsResponse" name="GetContactDocumentsResponse" message="tns:GetContactDocumentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPublishedPersonDocumentsByDate">
      <wsdl:documentation>
        <summary>Method that returns a specified number of published document appointments within a time range. The document appointments belong to the person specified or the document is in a project the person belongs to. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPublishedPersonDocumentsByDate" name="GetPublishedPersonDocumentsByDateRequest" message="tns:GetPublishedPersonDocumentsByDateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPublishedPersonDocumentsByDateResponse" name="GetPublishedPersonDocumentsByDateResponse" message="tns:GetPublishedPersonDocumentsByDateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPublishedProjectDocuments">
      <wsdl:documentation>
        <summary>Get published appointment documents by project id.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPublishedProjectDocuments" name="GetPublishedProjectDocumentsRequest" message="tns:GetPublishedProjectDocumentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPublishedProjectDocumentsResponse" name="GetPublishedProjectDocumentsResponse" message="tns:GetPublishedProjectDocumentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberDocumentsByTemplateTypes">
      <wsdl:documentation>
        <summary>Method that returns a specified number of document appointments within a time range, filtered by document template types. The document appointments belong to the project member specified. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectMemberDocumentsByTemplateTypes" name="GetProjectMemberDocumentsByTemplateTypesRequest" message="tns:GetProjectMemberDocumentsByTemplateTypesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectMemberDocumentsByTemplateTypesResponse" name="GetProjectMemberDocumentsByTemplateTypesResponse" message="tns:GetProjectMemberDocumentsByTemplateTypesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberDocumentsByTemplateType">
      <wsdl:documentation>
        <summary>Method that returns a specified number of document appointments within a time range, filtered by document template type. The document appointments belong to the project member specified. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectMemberDocumentsByTemplateType" name="GetProjectMemberDocumentsByTemplateTypeRequest" message="tns:GetProjectMemberDocumentsByTemplateTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectMemberDocumentsByTemplateTypeResponse" name="GetProjectMemberDocumentsByTemplateTypeResponse" message="tns:GetProjectMemberDocumentsByTemplateTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberDocumentsByTemplateHeading">
      <wsdl:documentation>
        <summary>Method that returns a specified number of document appointments within a time range, filtered by document template heading. The document appointments belong to the project member specified. The heading represents a grouping or filtering of document templates.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectMemberDocumentsByTemplateHeading" name="GetProjectMemberDocumentsByTemplateHeadingRequest" message="tns:GetProjectMemberDocumentsByTemplateHeadingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectMemberDocumentsByTemplateHeadingResponse" name="GetProjectMemberDocumentsByTemplateHeadingResponse" message="tns:GetProjectMemberDocumentsByTemplateHeadingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberDocuments">
      <wsdl:documentation>
        <summary>Method that returns a specified number of document appointments within a time range. The document appointments belong to the project member specified. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectMemberDocuments" name="GetProjectMemberDocumentsRequest" message="tns:GetProjectMemberDocumentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectMemberDocumentsResponse" name="GetProjectMemberDocumentsResponse" message="tns:GetProjectMemberDocumentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectDocumentsByTemplateTypes">
      <wsdl:documentation>
        <summary>Method that returns a specified number of document appointments within a time range, filtered by document template types. The document appointments belong to the project specified. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectDocumentsByTemplateTypes" name="GetProjectDocumentsByTemplateTypesRequest" message="tns:GetProjectDocumentsByTemplateTypesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectDocumentsByTemplateTypesResponse" name="GetProjectDocumentsByTemplateTypesResponse" message="tns:GetProjectDocumentsByTemplateTypesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectDocumentsByTemplateType">
      <wsdl:documentation>
        <summary>Method that returns a specified number of document appointments within a time range, filtered by document template type. The document appointments belong to the project specified. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectDocumentsByTemplateType" name="GetProjectDocumentsByTemplateTypeRequest" message="tns:GetProjectDocumentsByTemplateTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectDocumentsByTemplateTypeResponse" name="GetProjectDocumentsByTemplateTypeResponse" message="tns:GetProjectDocumentsByTemplateTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectDocumentsByTemplateHeading">
      <wsdl:documentation>
        <summary>Method that returns a specified number of document appointments within a time range, filtered by document template heading. The document appointments belong to the project specified. The heading represents a grouping or filtering of document templates.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectDocumentsByTemplateHeading" name="GetProjectDocumentsByTemplateHeadingRequest" message="tns:GetProjectDocumentsByTemplateHeadingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectDocumentsByTemplateHeadingResponse" name="GetProjectDocumentsByTemplateHeadingResponse" message="tns:GetProjectDocumentsByTemplateHeadingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectDocuments">
      <wsdl:documentation>
        <summary>Method that returns a specified number of document appointments within a time range. The document appointments belong to the project specified. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectDocuments" name="GetProjectDocumentsRequest" message="tns:GetProjectDocumentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectDocumentsResponse" name="GetProjectDocumentsResponse" message="tns:GetProjectDocumentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonDocumentsByTemplateTypes">
      <wsdl:documentation>
        <summary>Method that returns a specified number of document appointments within a time range, filtered by document template types. The document appointments belong to the person specified. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPersonDocumentsByTemplateTypes" name="GetPersonDocumentsByTemplateTypesRequest" message="tns:GetPersonDocumentsByTemplateTypesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPersonDocumentsByTemplateTypesResponse" name="GetPersonDocumentsByTemplateTypesResponse" message="tns:GetPersonDocumentsByTemplateTypesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonDocumentsByTemplateType">
      <wsdl:documentation>
        <summary>Method that returns a specified number of document appointments within a time range, filtered by document template type. The document appointments belong to the person specified. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPersonDocumentsByTemplateType" name="GetPersonDocumentsByTemplateTypeRequest" message="tns:GetPersonDocumentsByTemplateTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPersonDocumentsByTemplateTypeResponse" name="GetPersonDocumentsByTemplateTypeResponse" message="tns:GetPersonDocumentsByTemplateTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonDocumentsByTemplateHeading">
      <wsdl:documentation>
        <summary>Method that returns a specified number of document appointments within a time range, filtered by document template heading. The document appointments belong to the person specified. The heading represents a grouping or filtering of document templates.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPersonDocumentsByTemplateHeading" name="GetPersonDocumentsByTemplateHeadingRequest" message="tns:GetPersonDocumentsByTemplateHeadingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPersonDocumentsByTemplateHeadingResponse" name="GetPersonDocumentsByTemplateHeadingResponse" message="tns:GetPersonDocumentsByTemplateHeadingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonDocumentsByDate">
      <wsdl:documentation>
        <summary>Method that returns a specified number of document appointments within a time range. The document appointments belong to the person specified. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPersonDocumentsByDate" name="GetPersonDocumentsByDateRequest" message="tns:GetPersonDocumentsByDateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPersonDocumentsByDateResponse" name="GetPersonDocumentsByDateResponse" message="tns:GetPersonDocumentsByDateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDocumentsByTemplateHeading">
      <wsdl:documentation>
        <summary>Method that returns document appointments, filtered by the document template heading. The heading represents a grouping or filtering of document templates.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentsByTemplateHeading" name="GetDocumentsByTemplateHeadingRequest" message="tns:GetDocumentsByTemplateHeadingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentsByTemplateHeadingResponse" name="GetDocumentsByTemplateHeadingResponse" message="tns:GetDocumentsByTemplateHeadingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSuggestedDocumentEntity">
      <wsdl:documentation>
        <summary>Gets a SuggestedDocumentEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetSuggestedDocumentEntity" name="GetSuggestedDocumentEntityRequest" message="tns:GetSuggestedDocumentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetSuggestedDocumentEntityResponse" name="GetSuggestedDocumentEntityResponse" message="tns:GetSuggestedDocumentEntityResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Document" type="tns:Document">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultDocumentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateDefaultDocumentEntity" style="document" />
      <wsdl:input name="CreateDefaultDocumentEntityRequest">
        <soap:header message="tns:CreateDefaultDocumentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultDocumentEntityResponse">
        <soap:header message="tns:CreateDefaultDocumentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveDocumentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SaveDocumentEntity" style="document" />
      <wsdl:input name="SaveDocumentEntityRequest">
        <soap:header message="tns:SaveDocumentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveDocumentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveDocumentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveDocumentEntityResponse">
        <soap:header message="tns:SaveDocumentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveDocumentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveDocumentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveDocumentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteDocumentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/DeleteDocumentEntity" style="document" />
      <wsdl:input name="DeleteDocumentEntityRequest">
        <soap:header message="tns:DeleteDocumentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteDocumentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteDocumentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteDocumentEntityResponse">
        <soap:header message="tns:DeleteDocumentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteDocumentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteDocumentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteDocumentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultSuggestedDocumentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateDefaultSuggestedDocumentEntity" style="document" />
      <wsdl:input name="CreateDefaultSuggestedDocumentEntityRequest">
        <soap:header message="tns:CreateDefaultSuggestedDocumentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultSuggestedDocumentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultSuggestedDocumentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultSuggestedDocumentEntityResponse">
        <soap:header message="tns:CreateDefaultSuggestedDocumentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSuggestedDocumentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSuggestedDocumentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultSuggestedDocumentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveSuggestedDocumentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SaveSuggestedDocumentEntity" style="document" />
      <wsdl:input name="SaveSuggestedDocumentEntityRequest">
        <soap:header message="tns:SaveSuggestedDocumentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveSuggestedDocumentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveSuggestedDocumentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveSuggestedDocumentEntityResponse">
        <soap:header message="tns:SaveSuggestedDocumentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveSuggestedDocumentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveSuggestedDocumentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveSuggestedDocumentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTemplateVariablesParameters">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateDefaultTemplateVariablesParameters" style="document" />
      <wsdl:input name="CreateDefaultTemplateVariablesParametersRequest">
        <soap:header message="tns:CreateDefaultTemplateVariablesParametersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTemplateVariablesParametersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTemplateVariablesParametersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTemplateVariablesParametersResponse">
        <soap:header message="tns:CreateDefaultTemplateVariablesParametersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTemplateVariablesParametersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTemplateVariablesParametersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTemplateVariablesParametersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocument">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocument" style="document" />
      <wsdl:input name="GetDocumentRequest">
        <soap:header message="tns:GetDocumentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentResponse">
        <soap:header message="tns:GetDocumentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentEntity" style="document" />
      <wsdl:input name="GetDocumentEntityRequest">
        <soap:header message="tns:GetDocumentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentEntityResponse">
        <soap:header message="tns:GetDocumentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentStreamFromEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentStreamFromEntity" style="document" />
      <wsdl:input name="GetDocumentStreamFromEntityRequest">
        <soap:header message="tns:GetDocumentStreamFromEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentStreamFromEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentStreamFromEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentStreamFromEntityResponse">
        <soap:header message="tns:GetDocumentStreamFromEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentStreamFromEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentStreamFromEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentStreamFromEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetDocumentStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SetDocumentStream" style="document" />
      <wsdl:input name="SetDocumentStreamRequest">
        <soap:header message="tns:SetDocumentStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetDocumentStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetDocumentStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetDocumentStreamResponse">
        <soap:header message="tns:SetDocumentStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetDocumentStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetDocumentStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetDocumentStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDocumentStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateDocumentStream" style="document" />
      <wsdl:input name="CreateDocumentStreamRequest">
        <soap:header message="tns:CreateDocumentStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDocumentStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDocumentStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDocumentStreamResponse">
        <soap:header message="tns:CreateDocumentStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDocumentStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDocumentStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDocumentStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTemplateStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetTemplateStream" style="document" />
      <wsdl:input name="GetTemplateStreamRequest">
        <soap:header message="tns:GetTemplateStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTemplateStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTemplateStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTemplateStreamResponse">
        <soap:header message="tns:GetTemplateStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTemplateStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTemplateStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTemplateStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSanitizedTemplateStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetSanitizedTemplateStream" style="document" />
      <wsdl:input name="GetSanitizedTemplateStreamRequest">
        <soap:header message="tns:GetSanitizedTemplateStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSanitizedTemplateStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSanitizedTemplateStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSanitizedTemplateStreamResponse">
        <soap:header message="tns:GetSanitizedTemplateStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSanitizedTemplateStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSanitizedTemplateStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSanitizedTemplateStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTemplateStreamFromId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetTemplateStreamFromId" style="document" />
      <wsdl:input name="GetTemplateStreamFromIdRequest">
        <soap:header message="tns:GetTemplateStreamFromIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTemplateStreamFromIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTemplateStreamFromIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTemplateStreamFromIdResponse">
        <soap:header message="tns:GetTemplateStreamFromIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTemplateStreamFromIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTemplateStreamFromIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTemplateStreamFromIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSanitizedTemplateStreamFromId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetSanitizedTemplateStreamFromId" style="document" />
      <wsdl:input name="GetSanitizedTemplateStreamFromIdRequest">
        <soap:header message="tns:GetSanitizedTemplateStreamFromIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSanitizedTemplateStreamFromIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSanitizedTemplateStreamFromIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSanitizedTemplateStreamFromIdResponse">
        <soap:header message="tns:GetSanitizedTemplateStreamFromIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSanitizedTemplateStreamFromIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSanitizedTemplateStreamFromIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSanitizedTemplateStreamFromIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentStream" style="document" />
      <wsdl:input name="GetDocumentStreamRequest">
        <soap:header message="tns:GetDocumentStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentStreamResponse">
        <soap:header message="tns:GetDocumentStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSanitizedDocumentStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetSanitizedDocumentStream" style="document" />
      <wsdl:input name="GetSanitizedDocumentStreamRequest">
        <soap:header message="tns:GetSanitizedDocumentStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSanitizedDocumentStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSanitizedDocumentStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSanitizedDocumentStreamResponse">
        <soap:header message="tns:GetSanitizedDocumentStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSanitizedDocumentStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSanitizedDocumentStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSanitizedDocumentStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateNewPhysicalMailMergeDocumentFromTemplate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateNewPhysicalMailMergeDocumentFromTemplate" style="document" />
      <wsdl:input name="CreateNewPhysicalMailMergeDocumentFromTemplateRequest">
        <soap:header message="tns:CreateNewPhysicalMailMergeDocumentFromTemplateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateNewPhysicalMailMergeDocumentFromTemplateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateNewPhysicalMailMergeDocumentFromTemplateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateNewPhysicalMailMergeDocumentFromTemplateResponse">
        <soap:header message="tns:CreateNewPhysicalMailMergeDocumentFromTemplateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateNewPhysicalMailMergeDocumentFromTemplateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateNewPhysicalMailMergeDocumentFromTemplateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateNewPhysicalMailMergeDocumentFromTemplateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateNewPhysicalDocumentFromTemplateWithCustomTags">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags" style="document" />
      <wsdl:input name="CreateNewPhysicalDocumentFromTemplateWithCustomTagsRequest">
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTagsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTagsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTagsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateNewPhysicalDocumentFromTemplateWithCustomTagsResponse">
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTagsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTagsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTagsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTagsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateNewPhysicalDocumentFromTemplateWithCustomTags2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags2" style="document" />
      <wsdl:input name="CreateNewPhysicalDocumentFromTemplateWithCustomTags2Request">
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTags2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTags2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTags2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateNewPhysicalDocumentFromTemplateWithCustomTags2Response">
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTags2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTags2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTags2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateWithCustomTags2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SubstituteTemplateVariables">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteTemplateVariables" style="document" />
      <wsdl:input name="SubstituteTemplateVariablesRequest">
        <soap:header message="tns:SubstituteTemplateVariablesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SubstituteTemplateVariablesResponse">
        <soap:header message="tns:SubstituteTemplateVariablesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SubstituteTemplateVariablesWithCustomTags">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteTemplateVariablesWithCustomTags" style="document" />
      <wsdl:input name="SubstituteTemplateVariablesWithCustomTagsRequest">
        <soap:header message="tns:SubstituteTemplateVariablesWithCustomTagsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesWithCustomTagsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesWithCustomTagsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SubstituteTemplateVariablesWithCustomTagsResponse">
        <soap:header message="tns:SubstituteTemplateVariablesWithCustomTagsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesWithCustomTagsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesWithCustomTagsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesWithCustomTagsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SubstituteTemplateVariablesWithCustomTags2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteTemplateVariablesWithCustomTags2" style="document" />
      <wsdl:input name="SubstituteTemplateVariablesWithCustomTags2Request">
        <soap:header message="tns:SubstituteTemplateVariablesWithCustomTags2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesWithCustomTags2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesWithCustomTags2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SubstituteTemplateVariablesWithCustomTags2Response">
        <soap:header message="tns:SubstituteTemplateVariablesWithCustomTags2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesWithCustomTags2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesWithCustomTags2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesWithCustomTags2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateTempFile">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateTempFile" style="document" />
      <wsdl:input name="CreateTempFileRequest">
        <soap:header message="tns:CreateTempFileRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateTempFileRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateTempFileRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateTempFileResponse">
        <soap:header message="tns:CreateTempFileResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateTempFileResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateTempFileResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateTempFileResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTempFile">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetTempFile" style="document" />
      <wsdl:input name="GetTempFileRequest">
        <soap:header message="tns:GetTempFileRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTempFileRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTempFileRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTempFileResponse">
        <soap:header message="tns:GetTempFileResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTempFileResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTempFileResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTempFileResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteTempFile">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/DeleteTempFile" style="document" />
      <wsdl:input name="DeleteTempFileRequest">
        <soap:header message="tns:DeleteTempFileRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteTempFileRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteTempFileRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteTempFileResponse">
        <soap:header message="tns:DeleteTempFileResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteTempFileResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteTempFileResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteTempFileResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetTemplateStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SetTemplateStream" style="document" />
      <wsdl:input name="SetTemplateStreamRequest">
        <soap:header message="tns:SetTemplateStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetTemplateStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetTemplateStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetTemplateStreamResponse">
        <soap:header message="tns:SetTemplateStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetTemplateStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetTemplateStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetTemplateStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateNewPhysicalDocumentFromTemplate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateNewPhysicalDocumentFromTemplate" style="document" />
      <wsdl:input name="CreateNewPhysicalDocumentFromTemplateRequest">
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateNewPhysicalDocumentFromTemplateResponse">
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromTemplateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SubstituteMergeDocumentTemplateVariables">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteMergeDocumentTemplateVariables" style="document" />
      <wsdl:input name="SubstituteMergeDocumentTemplateVariablesRequest">
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SubstituteMergeDocumentTemplateVariablesResponse">
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SubstituteMergeDocumentTemplateVariables2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteMergeDocumentTemplateVariables2" style="document" />
      <wsdl:input name="SubstituteMergeDocumentTemplateVariables2Request">
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariables2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariables2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariables2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SubstituteMergeDocumentTemplateVariables2Response">
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariables2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariables2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariables2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariables2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SubstituteTemplateVariablesEx">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteTemplateVariablesEx" style="document" />
      <wsdl:input name="SubstituteTemplateVariablesExRequest">
        <soap:header message="tns:SubstituteTemplateVariablesExRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesExRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesExRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SubstituteTemplateVariablesExResponse">
        <soap:header message="tns:SubstituteTemplateVariablesExResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesExResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesExResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SubstituteTemplateVariablesExResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="VerifyGetDocumentStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/VerifyGetDocumentStream" style="document" />
      <wsdl:input name="VerifyGetDocumentStreamRequest">
        <soap:header message="tns:VerifyGetDocumentStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:VerifyGetDocumentStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:VerifyGetDocumentStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="VerifyGetDocumentStreamResponse">
        <soap:header message="tns:VerifyGetDocumentStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:VerifyGetDocumentStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:VerifyGetDocumentStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:VerifyGetDocumentStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SubstituteMergeDocumentTemplateVariablesEx">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteMergeDocumentTemplateVariablesEx" style="document" />
      <wsdl:input name="SubstituteMergeDocumentTemplateVariablesExRequest">
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesExRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesExRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesExRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SubstituteMergeDocumentTemplateVariablesExResponse">
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesExResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesExResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesExResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesExResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SubstituteMergeDocumentTemplateVariablesEx2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SubstituteMergeDocumentTemplateVariablesEx2" style="document" />
      <wsdl:input name="SubstituteMergeDocumentTemplateVariablesEx2Request">
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesEx2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesEx2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesEx2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SubstituteMergeDocumentTemplateVariablesEx2Response">
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesEx2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesEx2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesEx2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SubstituteMergeDocumentTemplateVariablesEx2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentUrl">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentUrl" style="document" />
      <wsdl:input name="GetDocumentUrlRequest">
        <soap:header message="tns:GetDocumentUrlRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentUrlRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentUrlRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentUrlResponse">
        <soap:header message="tns:GetDocumentUrlResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentUrlResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentUrlResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentUrlResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeletePhysicalDocument">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/DeletePhysicalDocument" style="document" />
      <wsdl:input name="DeletePhysicalDocumentRequest">
        <soap:header message="tns:DeletePhysicalDocumentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeletePhysicalDocumentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeletePhysicalDocumentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeletePhysicalDocumentResponse">
        <soap:header message="tns:DeletePhysicalDocumentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeletePhysicalDocumentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeletePhysicalDocumentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeletePhysicalDocumentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RenameDocument">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/RenameDocument" style="document" />
      <wsdl:input name="RenameDocumentRequest">
        <soap:header message="tns:RenameDocumentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RenameDocumentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RenameDocumentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RenameDocumentResponse">
        <soap:header message="tns:RenameDocumentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RenameDocumentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RenameDocumentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RenameDocumentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCheckoutState">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetCheckoutState" style="document" />
      <wsdl:input name="GetCheckoutStateRequest">
        <soap:header message="tns:GetCheckoutStateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCheckoutStateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCheckoutStateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCheckoutStateResponse">
        <soap:header message="tns:GetCheckoutStateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCheckoutStateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCheckoutStateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCheckoutStateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CheckoutDocument">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CheckoutDocument" style="document" />
      <wsdl:input name="CheckoutDocumentRequest">
        <soap:header message="tns:CheckoutDocumentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CheckoutDocumentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CheckoutDocumentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CheckoutDocumentResponse">
        <soap:header message="tns:CheckoutDocumentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CheckoutDocumentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CheckoutDocumentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CheckoutDocumentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CheckinDocument">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CheckinDocument" style="document" />
      <wsdl:input name="CheckinDocumentRequest">
        <soap:header message="tns:CheckinDocumentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CheckinDocumentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CheckinDocumentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CheckinDocumentResponse">
        <soap:header message="tns:CheckinDocumentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CheckinDocumentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CheckinDocumentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CheckinDocumentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UndoCheckoutDocument">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/UndoCheckoutDocument" style="document" />
      <wsdl:input name="UndoCheckoutDocumentRequest">
        <soap:header message="tns:UndoCheckoutDocumentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UndoCheckoutDocumentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UndoCheckoutDocumentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UndoCheckoutDocumentResponse">
        <soap:header message="tns:UndoCheckoutDocumentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UndoCheckoutDocumentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UndoCheckoutDocumentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UndoCheckoutDocumentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetVersionList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetVersionList" style="document" />
      <wsdl:input name="GetVersionListRequest">
        <soap:header message="tns:GetVersionListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetVersionListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetVersionListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetVersionListResponse">
        <soap:header message="tns:GetVersionListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetVersionListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetVersionListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetVersionListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPluginList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPluginList" style="document" />
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
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPluginCapabilities" style="document" />
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
    <wsdl:operation name="GetDocumentProperties">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentProperties" style="document" />
      <wsdl:input name="GetDocumentPropertiesRequest">
        <soap:header message="tns:GetDocumentPropertiesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentPropertiesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentPropertiesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentPropertiesResponse">
        <soap:header message="tns:GetDocumentPropertiesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentPropertiesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentPropertiesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentPropertiesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentCommands">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentCommands" style="document" />
      <wsdl:input name="GetDocumentCommandsRequest">
        <soap:header message="tns:GetDocumentCommandsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentCommandsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentCommandsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentCommandsResponse">
        <soap:header message="tns:GetDocumentCommandsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentCommandsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentCommandsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentCommandsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ExecuteDocumentCommand">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/ExecuteDocumentCommand" style="document" />
      <wsdl:input name="ExecuteDocumentCommandRequest">
        <soap:header message="tns:ExecuteDocumentCommandRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ExecuteDocumentCommandRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ExecuteDocumentCommandRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ExecuteDocumentCommandResponse">
        <soap:header message="tns:ExecuteDocumentCommandResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ExecuteDocumentCommandResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ExecuteDocumentCommandResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ExecuteDocumentCommandResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultDocumentEntityFromSuggestion">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/CreateDefaultDocumentEntityFromSuggestion" style="document" />
      <wsdl:input name="CreateDefaultDocumentEntityFromSuggestionRequest">
        <soap:header message="tns:CreateDefaultDocumentEntityFromSuggestionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentEntityFromSuggestionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentEntityFromSuggestionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultDocumentEntityFromSuggestionResponse">
        <soap:header message="tns:CreateDefaultDocumentEntityFromSuggestionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentEntityFromSuggestionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentEntityFromSuggestionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultDocumentEntityFromSuggestionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveDocumentTemplateStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SaveDocumentTemplateStream" style="document" />
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
    <wsdl:operation name="SetDocumentStreamFromId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SetDocumentStreamFromId" style="document" />
      <wsdl:input name="SetDocumentStreamFromIdRequest">
        <soap:header message="tns:SetDocumentStreamFromIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetDocumentStreamFromIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetDocumentStreamFromIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetDocumentStreamFromIdResponse">
        <soap:header message="tns:SetDocumentStreamFromIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetDocumentStreamFromIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetDocumentStreamFromIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetDocumentStreamFromIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SavePrivacyReport">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/SavePrivacyReport" style="document" />
      <wsdl:input name="SavePrivacyReportRequest">
        <soap:header message="tns:SavePrivacyReportRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SavePrivacyReportRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SavePrivacyReportRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SavePrivacyReportResponse">
        <soap:header message="tns:SavePrivacyReportResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SavePrivacyReportResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SavePrivacyReportResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SavePrivacyReportResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentList" style="document" />
      <wsdl:input name="GetDocumentListRequest">
        <soap:header message="tns:GetDocumentListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentListResponse">
        <soap:header message="tns:GetDocumentListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentDocuments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetAppointmentDocuments" style="document" />
      <wsdl:input name="GetAppointmentDocumentsRequest">
        <soap:header message="tns:GetAppointmentDocumentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAppointmentDocumentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAppointmentDocumentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAppointmentDocumentsResponse">
        <soap:header message="tns:GetAppointmentDocumentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAppointmentDocumentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAppointmentDocumentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAppointmentDocumentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSaleDocuments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetSaleDocuments" style="document" />
      <wsdl:input name="GetSaleDocumentsRequest">
        <soap:header message="tns:GetSaleDocumentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSaleDocumentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSaleDocumentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSaleDocumentsResponse">
        <soap:header message="tns:GetSaleDocumentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSaleDocumentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSaleDocumentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSaleDocumentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonDocuments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPersonDocuments" style="document" />
      <wsdl:input name="GetPersonDocumentsRequest">
        <soap:header message="tns:GetPersonDocumentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonDocumentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonDocumentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonDocumentsResponse">
        <soap:header message="tns:GetPersonDocumentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonDocumentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonDocumentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonDocumentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPublishedDocument">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPublishedDocument" style="document" />
      <wsdl:input name="GetPublishedDocumentRequest">
        <soap:header message="tns:GetPublishedDocumentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPublishedDocumentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPublishedDocumentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPublishedDocumentResponse">
        <soap:header message="tns:GetPublishedDocumentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPublishedDocumentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPublishedDocumentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPublishedDocumentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPublishedDocuments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPublishedDocuments" style="document" />
      <wsdl:input name="GetPublishedDocumentsRequest">
        <soap:header message="tns:GetPublishedDocumentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPublishedDocumentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPublishedDocumentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPublishedDocumentsResponse">
        <soap:header message="tns:GetPublishedDocumentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPublishedDocumentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPublishedDocumentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPublishedDocumentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyPublishedDocuments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetMyPublishedDocuments" style="document" />
      <wsdl:input name="GetMyPublishedDocumentsRequest">
        <soap:header message="tns:GetMyPublishedDocumentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyPublishedDocumentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyPublishedDocumentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyPublishedDocumentsResponse">
        <soap:header message="tns:GetMyPublishedDocumentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyPublishedDocumentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyPublishedDocumentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyPublishedDocumentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPublishedDocumentsByDate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPublishedDocumentsByDate" style="document" />
      <wsdl:input name="GetPublishedDocumentsByDateRequest">
        <soap:header message="tns:GetPublishedDocumentsByDateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPublishedDocumentsByDateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPublishedDocumentsByDateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPublishedDocumentsByDateResponse">
        <soap:header message="tns:GetPublishedDocumentsByDateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPublishedDocumentsByDateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPublishedDocumentsByDateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPublishedDocumentsByDateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactDocumentsByTemplateTypes">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetContactDocumentsByTemplateTypes" style="document" />
      <wsdl:input name="GetContactDocumentsByTemplateTypesRequest">
        <soap:header message="tns:GetContactDocumentsByTemplateTypesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactDocumentsByTemplateTypesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactDocumentsByTemplateTypesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactDocumentsByTemplateTypesResponse">
        <soap:header message="tns:GetContactDocumentsByTemplateTypesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactDocumentsByTemplateTypesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactDocumentsByTemplateTypesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactDocumentsByTemplateTypesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactDocumentsByTemplateType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetContactDocumentsByTemplateType" style="document" />
      <wsdl:input name="GetContactDocumentsByTemplateTypeRequest">
        <soap:header message="tns:GetContactDocumentsByTemplateTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactDocumentsByTemplateTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactDocumentsByTemplateTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactDocumentsByTemplateTypeResponse">
        <soap:header message="tns:GetContactDocumentsByTemplateTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactDocumentsByTemplateTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactDocumentsByTemplateTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactDocumentsByTemplateTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactDocumentsByTemplateHeading">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetContactDocumentsByTemplateHeading" style="document" />
      <wsdl:input name="GetContactDocumentsByTemplateHeadingRequest">
        <soap:header message="tns:GetContactDocumentsByTemplateHeadingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactDocumentsByTemplateHeadingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactDocumentsByTemplateHeadingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactDocumentsByTemplateHeadingResponse">
        <soap:header message="tns:GetContactDocumentsByTemplateHeadingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactDocumentsByTemplateHeadingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactDocumentsByTemplateHeadingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactDocumentsByTemplateHeadingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactDocuments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetContactDocuments" style="document" />
      <wsdl:input name="GetContactDocumentsRequest">
        <soap:header message="tns:GetContactDocumentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactDocumentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactDocumentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactDocumentsResponse">
        <soap:header message="tns:GetContactDocumentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactDocumentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactDocumentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactDocumentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPublishedPersonDocumentsByDate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPublishedPersonDocumentsByDate" style="document" />
      <wsdl:input name="GetPublishedPersonDocumentsByDateRequest">
        <soap:header message="tns:GetPublishedPersonDocumentsByDateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPublishedPersonDocumentsByDateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPublishedPersonDocumentsByDateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPublishedPersonDocumentsByDateResponse">
        <soap:header message="tns:GetPublishedPersonDocumentsByDateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPublishedPersonDocumentsByDateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPublishedPersonDocumentsByDateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPublishedPersonDocumentsByDateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPublishedProjectDocuments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPublishedProjectDocuments" style="document" />
      <wsdl:input name="GetPublishedProjectDocumentsRequest">
        <soap:header message="tns:GetPublishedProjectDocumentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPublishedProjectDocumentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPublishedProjectDocumentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPublishedProjectDocumentsResponse">
        <soap:header message="tns:GetPublishedProjectDocumentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPublishedProjectDocumentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPublishedProjectDocumentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPublishedProjectDocumentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberDocumentsByTemplateTypes">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectMemberDocumentsByTemplateTypes" style="document" />
      <wsdl:input name="GetProjectMemberDocumentsByTemplateTypesRequest">
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateTypesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateTypesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateTypesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectMemberDocumentsByTemplateTypesResponse">
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateTypesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateTypesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateTypesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateTypesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberDocumentsByTemplateType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectMemberDocumentsByTemplateType" style="document" />
      <wsdl:input name="GetProjectMemberDocumentsByTemplateTypeRequest">
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectMemberDocumentsByTemplateTypeResponse">
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberDocumentsByTemplateHeading">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectMemberDocumentsByTemplateHeading" style="document" />
      <wsdl:input name="GetProjectMemberDocumentsByTemplateHeadingRequest">
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateHeadingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateHeadingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateHeadingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectMemberDocumentsByTemplateHeadingResponse">
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateHeadingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateHeadingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateHeadingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsByTemplateHeadingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberDocuments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectMemberDocuments" style="document" />
      <wsdl:input name="GetProjectMemberDocumentsRequest">
        <soap:header message="tns:GetProjectMemberDocumentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectMemberDocumentsResponse">
        <soap:header message="tns:GetProjectMemberDocumentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectMemberDocumentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectDocumentsByTemplateTypes">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectDocumentsByTemplateTypes" style="document" />
      <wsdl:input name="GetProjectDocumentsByTemplateTypesRequest">
        <soap:header message="tns:GetProjectDocumentsByTemplateTypesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectDocumentsByTemplateTypesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectDocumentsByTemplateTypesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectDocumentsByTemplateTypesResponse">
        <soap:header message="tns:GetProjectDocumentsByTemplateTypesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectDocumentsByTemplateTypesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectDocumentsByTemplateTypesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectDocumentsByTemplateTypesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectDocumentsByTemplateType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectDocumentsByTemplateType" style="document" />
      <wsdl:input name="GetProjectDocumentsByTemplateTypeRequest">
        <soap:header message="tns:GetProjectDocumentsByTemplateTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectDocumentsByTemplateTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectDocumentsByTemplateTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectDocumentsByTemplateTypeResponse">
        <soap:header message="tns:GetProjectDocumentsByTemplateTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectDocumentsByTemplateTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectDocumentsByTemplateTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectDocumentsByTemplateTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectDocumentsByTemplateHeading">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectDocumentsByTemplateHeading" style="document" />
      <wsdl:input name="GetProjectDocumentsByTemplateHeadingRequest">
        <soap:header message="tns:GetProjectDocumentsByTemplateHeadingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectDocumentsByTemplateHeadingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectDocumentsByTemplateHeadingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectDocumentsByTemplateHeadingResponse">
        <soap:header message="tns:GetProjectDocumentsByTemplateHeadingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectDocumentsByTemplateHeadingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectDocumentsByTemplateHeadingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectDocumentsByTemplateHeadingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectDocuments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetProjectDocuments" style="document" />
      <wsdl:input name="GetProjectDocumentsRequest">
        <soap:header message="tns:GetProjectDocumentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectDocumentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectDocumentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectDocumentsResponse">
        <soap:header message="tns:GetProjectDocumentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectDocumentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectDocumentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectDocumentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonDocumentsByTemplateTypes">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPersonDocumentsByTemplateTypes" style="document" />
      <wsdl:input name="GetPersonDocumentsByTemplateTypesRequest">
        <soap:header message="tns:GetPersonDocumentsByTemplateTypesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByTemplateTypesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByTemplateTypesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonDocumentsByTemplateTypesResponse">
        <soap:header message="tns:GetPersonDocumentsByTemplateTypesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByTemplateTypesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByTemplateTypesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByTemplateTypesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonDocumentsByTemplateType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPersonDocumentsByTemplateType" style="document" />
      <wsdl:input name="GetPersonDocumentsByTemplateTypeRequest">
        <soap:header message="tns:GetPersonDocumentsByTemplateTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByTemplateTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByTemplateTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonDocumentsByTemplateTypeResponse">
        <soap:header message="tns:GetPersonDocumentsByTemplateTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByTemplateTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByTemplateTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByTemplateTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonDocumentsByTemplateHeading">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPersonDocumentsByTemplateHeading" style="document" />
      <wsdl:input name="GetPersonDocumentsByTemplateHeadingRequest">
        <soap:header message="tns:GetPersonDocumentsByTemplateHeadingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByTemplateHeadingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByTemplateHeadingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonDocumentsByTemplateHeadingResponse">
        <soap:header message="tns:GetPersonDocumentsByTemplateHeadingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByTemplateHeadingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByTemplateHeadingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByTemplateHeadingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonDocumentsByDate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetPersonDocumentsByDate" style="document" />
      <wsdl:input name="GetPersonDocumentsByDateRequest">
        <soap:header message="tns:GetPersonDocumentsByDateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByDateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByDateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonDocumentsByDateResponse">
        <soap:header message="tns:GetPersonDocumentsByDateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByDateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByDateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonDocumentsByDateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDocumentsByTemplateHeading">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetDocumentsByTemplateHeading" style="document" />
      <wsdl:input name="GetDocumentsByTemplateHeadingRequest">
        <soap:header message="tns:GetDocumentsByTemplateHeadingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDocumentsByTemplateHeadingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDocumentsByTemplateHeadingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDocumentsByTemplateHeadingResponse">
        <soap:header message="tns:GetDocumentsByTemplateHeadingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDocumentsByTemplateHeadingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDocumentsByTemplateHeadingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDocumentsByTemplateHeadingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSuggestedDocumentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Document/GetSuggestedDocumentEntity" style="document" />
      <wsdl:input name="GetSuggestedDocumentEntityRequest">
        <soap:header message="tns:GetSuggestedDocumentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSuggestedDocumentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSuggestedDocumentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSuggestedDocumentEntityResponse">
        <soap:header message="tns:GetSuggestedDocumentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSuggestedDocumentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSuggestedDocumentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSuggestedDocumentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfDocumentService">
    <wsdl:port name="BasicHttpBinding_Document" binding="tns:BasicHttpBinding_Document">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services87/Document.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

