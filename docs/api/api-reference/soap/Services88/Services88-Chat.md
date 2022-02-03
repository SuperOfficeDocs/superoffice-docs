---
generated: 1
uid: wsdl-Services88-Chat
title: Services88.ChatAgent WSDL
---

# Services88.ChatAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfChatService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:ser="http://schemas.microsoft.com/2003/10/Serialization/">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultChatSessionEntity">
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
      <xs:element name="SoCredentials" nillable="true" type="q1:SoCredentials" xmlns:q1="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="Credentials" nillable="true" type="q2:SoCredentials" xmlns:q2="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SoTimeZone">
        <xs:sequence>
          <xs:element minOccurs="0" name="SoTimeZoneId" type="xs:int" />
          <xs:element minOccurs="0" name="SoTimeZoneLocationCode" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoTimeZone" nillable="true" type="q3:SoTimeZone" xmlns:q3="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="TimeZone" nillable="true" type="q4:SoTimeZone" xmlns:q4="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="CreateDefaultChatSessionEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q5:ChatSessionEntity" xmlns:q5="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ChatSessionEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q6:Carrier" xmlns:q6="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ChatSessionId" type="xs:int" />
              <xs:element minOccurs="0" name="TopicId" type="xs:int" />
              <xs:element minOccurs="0" name="User" nillable="true" type="q6:Associate" />
              <xs:element minOccurs="0" name="Person" nillable="true" type="q6:Person" />
              <xs:element minOccurs="0" name="CustomerAlias" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CustomerHost" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CustomerName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CustomerEmail" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CustomerPhone" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CustomerConsented" type="xs:boolean" />
              <xs:element minOccurs="0" name="CustomerCompanyName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Status" type="q6:ChatSessionStatus" />
              <xs:element minOccurs="0" name="FirstMessage" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="LastMessage" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="WhenRequested" type="xs:dateTime" />
              <xs:element minOccurs="0" name="WhenStarted" type="xs:dateTime" />
              <xs:element minOccurs="0" name="WhenEnded" type="xs:dateTime" />
              <xs:element minOccurs="0" name="WhenIdle" type="xs:dateTime" />
              <xs:element minOccurs="0" name="WhenFetched" type="xs:dateTime" />
              <xs:element minOccurs="0" name="SessionKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="InitialQueuePos" type="xs:int" />
              <xs:element minOccurs="0" name="AlertLevel" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="Flags" type="q6:ChatSessionFlags" />
              <xs:element minOccurs="0" name="Contact" nillable="true" type="q6:Contact" />
              <xs:element minOccurs="0" name="Project" nillable="true" type="q6:Project" />
              <xs:element minOccurs="0" name="Sale" nillable="true" type="q6:Sale" />
              <xs:element minOccurs="0" name="Ticket" nillable="true" type="q6:Ticket" />
              <xs:element minOccurs="0" name="TransferTo" nillable="true" type="q6:Associate" />
              <xs:element minOccurs="0" name="ChatbotIsActive" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ChatSessionEntity" nillable="true" type="q7:ChatSessionEntity" xmlns:q7="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Carrier">
        <xs:sequence>
          <xs:element minOccurs="0" name="TableRight" nillable="true" type="q8:TableRight" xmlns:q8="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="FieldProperties" nillable="true" type="q9:FieldPropertyDictionary" xmlns:q9="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="Carrier" nillable="true" type="q10:Carrier" xmlns:q10="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TableRight">
        <xs:sequence>
          <xs:element minOccurs="0" name="Mask" type="q11:ETableRight" xmlns:q11="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TableRight" nillable="true" type="q12:TableRight" xmlns:q12="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="ETableRight" nillable="true" type="q13:ETableRight" xmlns:q13="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
                <xs:element name="Value" nillable="true" type="q14:FieldProperty" xmlns:q14="http://www.superoffice.net/ws/crm/NetServer/Services88" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldPropertyDictionary" nillable="true" type="q15:FieldPropertyDictionary" xmlns:q15="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="FieldProperty">
        <xs:sequence>
          <xs:element minOccurs="0" name="FieldRight" nillable="true" type="q16:FieldRight" xmlns:q16="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="FieldType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FieldLength" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldProperty" nillable="true" type="q17:FieldProperty" xmlns:q17="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="FieldRight">
        <xs:sequence>
          <xs:element minOccurs="0" name="Mask" type="q18:EFieldRight" xmlns:q18="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldRight" nillable="true" type="q19:FieldRight" xmlns:q19="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="EFieldRight" nillable="true" type="q20:EFieldRight" xmlns:q20="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Associate">
        <xs:complexContent mixed="false">
          <xs:extension base="q21:Carrier" xmlns:q21="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Type" type="q21:UserType" />
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
      <xs:element name="Associate" nillable="true" type="q22:Associate" xmlns:q22="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="UserType" nillable="true" type="q23:UserType" xmlns:q23="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Person">
        <xs:complexContent mixed="false">
          <xs:extension base="q24:Carrier" xmlns:q24="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="Person" nillable="true" type="q25:Person" xmlns:q25="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="ChatSessionStatus">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Invalid" />
          <xs:enumeration value="PreChatForm" />
          <xs:enumeration value="Faq" />
          <xs:enumeration value="OfflineForm" />
          <xs:enumeration value="InQueue" />
          <xs:enumeration value="CustomerLast" />
          <xs:enumeration value="UserLast" />
          <xs:enumeration value="Finished" />
          <xs:enumeration value="Deleted" />
          <xs:enumeration value="Closed" />
          <xs:enumeration value="RequestPosted" />
          <xs:enumeration value="ClosedFromQueue" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ChatSessionStatus" nillable="true" type="q26:ChatSessionStatus" xmlns:q26="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="ChatSessionFlags">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="UserIsTyping" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="ChatSessionFlags" nillable="true" type="q27:ChatSessionFlags" xmlns:q27="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Contact">
        <xs:complexContent mixed="false">
          <xs:extension base="q28:Carrier" xmlns:q28="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
              <xs:element minOccurs="0" name="Address" nillable="true" type="q28:Address" />
              <xs:element minOccurs="0" name="FormattedAddress" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsOwnerContact" type="xs:boolean" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Contact" nillable="true" type="q29:Contact" xmlns:q29="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Address">
        <xs:complexContent mixed="false">
          <xs:extension base="q30:Carrier" xmlns:q30="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Wgs84Latitude" type="xs:double" />
              <xs:element minOccurs="0" name="Wgs84Longitude" type="xs:double" />
              <xs:element minOccurs="0" name="LocalizedAddress" nillable="true" type="q30:ArrayOfArrayOfLocalizedField" />
              <xs:element minOccurs="0" name="Street" nillable="true" type="q30:StructuredAddress" />
              <xs:element minOccurs="0" name="Postal" nillable="true" type="q30:StructuredAddress" />
              <xs:element minOccurs="0" name="Formatted" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Address" nillable="true" type="q31:Address" xmlns:q31="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArrayOfLocalizedField" nillable="true" type="q32:ArrayOfLocalizedField" xmlns:q32="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArrayOfLocalizedField" nillable="true" type="q33:ArrayOfArrayOfLocalizedField" xmlns:q33="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="LocalizedField" nillable="true" type="q34:LocalizedField" xmlns:q34="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLocalizedField" nillable="true" type="q35:ArrayOfLocalizedField" xmlns:q35="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="LocalizedField">
        <xs:complexContent mixed="false">
          <xs:extension base="q36:Carrier" xmlns:q36="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="LocalizedField" nillable="true" type="q37:LocalizedField" xmlns:q37="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="StructuredAddress">
        <xs:sequence>
          <xs:element minOccurs="0" name="AtypeIdx" type="q38:AddressType" xmlns:q38="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="StructuredAddress" nillable="true" type="q39:StructuredAddress" xmlns:q39="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AddressType" nillable="true" type="q40:AddressType" xmlns:q40="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Project">
        <xs:complexContent mixed="false">
          <xs:extension base="q41:Carrier" xmlns:q41="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="Project" nillable="true" type="q42:Project" xmlns:q42="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Sale">
        <xs:complexContent mixed="false">
          <xs:extension base="q43:Carrier" xmlns:q43="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
              <xs:element minOccurs="0" name="Status" type="q43:SaleStatus" />
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
              <xs:element minOccurs="0" name="Completed" type="q43:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="NextDueDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Number" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Sale" nillable="true" type="q44:Sale" xmlns:q44="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="SaleStatus" nillable="true" type="q45:SaleStatus" xmlns:q45="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="ActivityStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="NotStarted" />
          <xs:enumeration value="Started" />
          <xs:enumeration value="Completed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ActivityStatus" nillable="true" type="q46:ActivityStatus" xmlns:q46="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Ticket">
        <xs:complexContent mixed="false">
          <xs:extension base="q47:Carrier" xmlns:q47="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="TicketId" type="xs:int" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CreatedAt" type="xs:dateTime" />
              <xs:element minOccurs="0" name="LastChanged" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ReadByOwner" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ReadByCustomer" type="xs:dateTime" />
              <xs:element minOccurs="0" name="FirstReadByUser" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Activate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ClosedAt" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RepliedAt" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AlertTimeout" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Deadline" type="xs:dateTime" />
              <xs:element minOccurs="0" name="CreatedBy" type="xs:int" />
              <xs:element minOccurs="0" name="CreatedByName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Author" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OwnedBy" type="xs:int" />
              <xs:element minOccurs="0" name="OwnedByName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Category" type="xs:int" />
              <xs:element minOccurs="0" name="CategoryName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CategoryFullname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Slevel" type="q47:TicketSecurityLevel" />
              <xs:element minOccurs="0" name="Priority" type="xs:int" />
              <xs:element minOccurs="0" name="PriorityName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="BaseStatus" type="q47:TicketBaseStatus" />
              <xs:element minOccurs="0" name="TicketStatus" type="xs:int" />
              <xs:element minOccurs="0" name="TicketStatusDisplayValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Origin" type="q47:TicketOrigin" />
              <xs:element minOccurs="0" name="CustId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonFirstname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonMiddleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonLastname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonFullname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AlertLevel" type="xs:short" />
              <xs:element minOccurs="0" name="ConnectId" type="xs:int" />
              <xs:element minOccurs="0" name="ReadStatus" type="q47:TicketReadStatus" />
              <xs:element minOccurs="0" name="TimeToReply" type="xs:int" />
              <xs:element minOccurs="0" name="RealTimeToReply" type="xs:int" />
              <xs:element minOccurs="0" name="TimeToClose" type="xs:int" />
              <xs:element minOccurs="0" name="RealTimeToClose" type="xs:int" />
              <xs:element minOccurs="0" name="TimeSpentInternally" type="xs:int" />
              <xs:element minOccurs="0" name="TimeSpentExternally" type="xs:int" />
              <xs:element minOccurs="0" name="TimeSpentQueue" type="xs:int" />
              <xs:element minOccurs="0" name="RealTimeSpentInternally" type="xs:int" />
              <xs:element minOccurs="0" name="RealTimeSpentExternally" type="xs:int" />
              <xs:element minOccurs="0" name="RealTimeSpentQueue" type="xs:int" />
              <xs:element minOccurs="0" name="HasAttachment" type="xs:boolean" />
              <xs:element minOccurs="0" name="NumReplies" type="xs:int" />
              <xs:element minOccurs="0" name="NumMessages" type="xs:int" />
              <xs:element minOccurs="0" name="FromAddress" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OwnedByAssociateId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Ticket" nillable="true" type="q48:Ticket" xmlns:q48="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="TicketSecurityLevel">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Internal" />
          <xs:enumeration value="External" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TicketSecurityLevel" nillable="true" type="q49:TicketSecurityLevel" xmlns:q49="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="TicketBaseStatus">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Active" />
          <xs:enumeration value="Closed" />
          <xs:enumeration value="Postponed" />
          <xs:enumeration value="Deleted" />
          <xs:enumeration value="Merged" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TicketBaseStatus" nillable="true" type="q50:TicketBaseStatus" xmlns:q50="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="TicketOrigin">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Email" />
          <xs:enumeration value="SMS" />
          <xs:enumeration value="Fax" />
          <xs:enumeration value="Phone" />
          <xs:enumeration value="Facebook" />
          <xs:enumeration value="Twitter" />
          <xs:enumeration value="Internal" />
          <xs:enumeration value="CustomerCentre" />
          <xs:enumeration value="EMarketing" />
          <xs:enumeration value="AutoGenerated" />
          <xs:enumeration value="Chat" />
          <xs:enumeration value="Form" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TicketOrigin" nillable="true" type="q51:TicketOrigin" xmlns:q51="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="TicketReadStatus">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Green" />
          <xs:enumeration value="Yellow" />
          <xs:enumeration value="Red" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TicketReadStatus" nillable="true" type="q52:TicketReadStatus" xmlns:q52="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SoExceptionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="StackTrace" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FriendlyText" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ExceptionType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="InnerException" nillable="true" type="q53:SoExceptionInfo" xmlns:q53="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Parameters" nillable="true" type="q54:SoExceptionInfoParameters" xmlns:q54="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExceptionInfo" nillable="true" type="q55:SoExceptionInfo" xmlns:q55="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="SoExceptionInfoParameters" nillable="true" type="q56:SoExceptionInfoParameters" xmlns:q56="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ExceptionInfo" nillable="true" type="q57:SoExceptionInfo" xmlns:q57="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="SoExtraInfo" nillable="true" type="q58:SoExtraInfo" xmlns:q58="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ExtraInfo" nillable="true" type="q59:SoExtraInfo" xmlns:q59="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="Succeeded" type="xs:boolean" />
      <xs:element name="SaveChatSessionEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatSessionEntity" nillable="true" type="q60:ChatSessionEntity" xmlns:q60="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveChatSessionEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q61:ChatSessionEntity" xmlns:q61="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteChatSessionEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatSessionEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteChatSessionEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultChatTopicAgent">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultChatTopicAgentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q62:ChatTopicAgent" xmlns:q62="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ChatTopicAgent">
        <xs:sequence>
          <xs:element minOccurs="0" name="TopicId" type="xs:int" />
          <xs:element minOccurs="0" name="User" nillable="true" type="q63:Associate" xmlns:q63="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="CanListen" type="xs:boolean" />
          <xs:element minOccurs="0" name="CanRespond" type="xs:boolean" />
          <xs:element minOccurs="0" name="CanManage" type="xs:boolean" />
          <xs:element minOccurs="0" name="CanNotify" type="xs:boolean" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ChatTopicAgent" nillable="true" type="q64:ChatTopicAgent" xmlns:q64="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="CreateDefaultChatTopicEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultChatTopicEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q65:ChatTopicEntity" xmlns:q65="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ChatTopicEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q66:Carrier" xmlns:q66="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ChatTopicId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="WelcomeMessage" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Language" nillable="true" type="q66:CustomerLanguage" />
              <xs:element minOccurs="0" name="LastAccept" type="xs:dateTime" />
              <xs:element minOccurs="0" name="SecondsPrAccept" type="xs:int" />
              <xs:element minOccurs="0" name="AlertRecipient" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AlertTemplate" nillable="true" type="q66:ReplyTemplate" />
              <xs:element minOccurs="0" name="CollectConsent" type="xs:boolean" />
              <xs:element minOccurs="0" name="BadgeHeader" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CustomQueueTextEnabled" type="xs:boolean" />
              <xs:element minOccurs="0" name="CustomQueueText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="WarnNewChatMinutes" type="xs:int" />
              <xs:element minOccurs="0" name="WarnManagerNewChatMinutes" type="xs:int" />
              <xs:element minOccurs="0" name="TicketEnabled" type="xs:boolean" />
              <xs:element minOccurs="0" name="TicketCategory" nillable="true" type="q66:TicketCategory" />
              <xs:element minOccurs="0" name="TicketPriority" nillable="true" type="q66:TicketPriority" />
              <xs:element minOccurs="0" name="OpeningHoursEnabled" type="xs:boolean" />
              <xs:element minOccurs="0" name="OpeningHours" nillable="true" type="q66:ChatOpeningHours" />
              <xs:element minOccurs="0" name="Widget" nillable="true" type="q66:ChatWidgetSettings" />
              <xs:element minOccurs="0" name="BotEnabled" type="xs:boolean" />
              <xs:element minOccurs="0" name="BotSettings" nillable="true" type="q66:ChatBotSettings" />
              <xs:element minOccurs="0" name="OfflineCollectConsent" type="xs:boolean" />
              <xs:element minOccurs="0" name="WarnChatMessageMinutes" type="xs:int" />
              <xs:element minOccurs="0" name="WarnManagerChatMessageMinutes" type="xs:int" />
              <xs:element minOccurs="0" name="UseQueueOfflineForm" type="xs:boolean" />
              <xs:element minOccurs="0" name="OfflineFormTimeLimit" type="xs:int" />
              <xs:element minOccurs="0" name="OfflineFormQueueLength" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ChatTopicEntity" nillable="true" type="q67:ChatTopicEntity" xmlns:q67="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="CustomerLanguage">
        <xs:complexContent mixed="false">
          <xs:extension base="q68:Carrier" xmlns:q68="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CustomerLanguage" nillable="true" type="q69:CustomerLanguage" xmlns:q69="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ReplyTemplate">
        <xs:sequence>
          <xs:element minOccurs="0" name="ReplyTemplateId" type="xs:int" />
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FolderId" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ReplyTemplate" nillable="true" type="q70:ReplyTemplate" xmlns:q70="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TicketCategory">
        <xs:complexContent mixed="false">
          <xs:extension base="q71:Carrier" xmlns:q71="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TicketCategory" nillable="true" type="q72:TicketCategory" xmlns:q72="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TicketPriority">
        <xs:complexContent mixed="false">
          <xs:extension base="q73:Carrier" xmlns:q73="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TicketPriority" nillable="true" type="q74:TicketPriority" xmlns:q74="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ChatOpeningHours">
        <xs:sequence>
          <xs:element minOccurs="0" name="TzLocation" nillable="true" type="q75:TimeZoneData" xmlns:q75="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="MonEnabled" type="xs:boolean" />
          <xs:element minOccurs="0" name="MonStart" type="ser:duration" />
          <xs:element minOccurs="0" name="MonStop" type="ser:duration" />
          <xs:element minOccurs="0" name="TueEnabled" type="xs:boolean" />
          <xs:element minOccurs="0" name="TueStart" type="ser:duration" />
          <xs:element minOccurs="0" name="TueStop" type="ser:duration" />
          <xs:element minOccurs="0" name="WedEnabled" type="xs:boolean" />
          <xs:element minOccurs="0" name="WedStart" type="ser:duration" />
          <xs:element minOccurs="0" name="WedStop" type="ser:duration" />
          <xs:element minOccurs="0" name="ThuEnabled" type="xs:boolean" />
          <xs:element minOccurs="0" name="ThuStart" type="ser:duration" />
          <xs:element minOccurs="0" name="ThuStop" type="ser:duration" />
          <xs:element minOccurs="0" name="FriEnabled" type="xs:boolean" />
          <xs:element minOccurs="0" name="FriStart" type="ser:duration" />
          <xs:element minOccurs="0" name="FriStop" type="ser:duration" />
          <xs:element minOccurs="0" name="SatEnabled" type="xs:boolean" />
          <xs:element minOccurs="0" name="SatStart" type="ser:duration" />
          <xs:element minOccurs="0" name="SatStop" type="ser:duration" />
          <xs:element minOccurs="0" name="SunEnabled" type="xs:boolean" />
          <xs:element minOccurs="0" name="SunStart" type="ser:duration" />
          <xs:element minOccurs="0" name="SunStop" type="ser:duration" />
          <xs:element minOccurs="0" name="UseLunchHours" type="xs:boolean" />
          <xs:element minOccurs="0" name="LunchStart" type="ser:duration" />
          <xs:element minOccurs="0" name="LunchStop" type="ser:duration" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ChatOpeningHours" nillable="true" type="q76:ChatOpeningHours" xmlns:q76="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TimeZoneData">
        <xs:sequence>
          <xs:element minOccurs="0" name="TZLocationID" type="xs:int" />
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="TZLocationCode" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="TZLocationCities" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="IsoNumber" type="xs:int" />
          <xs:element minOccurs="0" name="TimeZoneSTDRules" nillable="true" type="q77:TimeZoneRuleDictionary" xmlns:q77="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="TimeZoneDSTRules" nillable="true" type="q78:TimeZoneRuleDictionary" xmlns:q78="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TimeZoneData" nillable="true" type="q79:TimeZoneData" xmlns:q79="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TimeZoneRuleDictionary">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TimeZoneRuleKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" type="xs:dateTime" />
                <xs:element name="Value" nillable="true" type="q80:TimeZoneRule" xmlns:q80="http://www.superoffice.net/ws/crm/NetServer/Services88" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TimeZoneRuleDictionary" nillable="true" type="q81:TimeZoneRuleDictionary" xmlns:q81="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TimeZoneRule">
        <xs:sequence>
          <xs:element minOccurs="0" name="TZOffset" type="xs:int" />
          <xs:element minOccurs="0" name="StartRulePattern" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="EndRulePattern" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="StartDay" type="xs:int" />
          <xs:element minOccurs="0" name="StartMonth" type="xs:int" />
          <xs:element minOccurs="0" name="EndDay" type="xs:int" />
          <xs:element minOccurs="0" name="EndMonth" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TimeZoneRule" nillable="true" type="q82:TimeZoneRule" xmlns:q82="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ChatWidgetSettings">
        <xs:sequence>
          <xs:element minOccurs="0" name="AutoFaqEnabled" type="xs:boolean" />
          <xs:element minOccurs="0" name="AutoFaqCategory" nillable="true" type="q83:KbCategory" xmlns:q83="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="PreFormEnabled" type="xs:boolean" />
          <xs:element minOccurs="0" name="PreFormMessage" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="RequiredFields" type="q84:WidgetRequiredFields" xmlns:q84="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="PostFormEnabled" type="xs:boolean" />
          <xs:element minOccurs="0" name="PostFormHeader" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="PostFormMessage" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="PostTranscriptEnabled" type="xs:boolean" />
          <xs:element minOccurs="0" name="LanguageIsoCode" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Size" type="q85:ChatWidgetSize" xmlns:q85="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Theme" type="q86:WidgetTheme" xmlns:q86="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Color" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Font" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="LogoEnabled" type="xs:boolean" />
          <xs:element minOccurs="0" name="LogoBlobId" type="xs:int" />
          <xs:element minOccurs="0" name="LogoName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ShowAgentPhoto" type="xs:boolean" />
          <xs:element minOccurs="0" name="WelcomeTitle" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="WelcomeMessage" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="OfflineHeader" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="OfflineMessage" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="OfflineFields" type="q87:WidgetRequiredFields" xmlns:q87="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="UseAgentFirstname" type="xs:boolean" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ChatWidgetSettings" nillable="true" type="q88:ChatWidgetSettings" xmlns:q88="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="KbCategory">
        <xs:sequence>
          <xs:element minOccurs="0" name="KbCategoryId" type="xs:int" />
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Fullname" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ParentId" type="xs:int" />
          <xs:element minOccurs="0" name="SortOrder" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="KbCategory" nillable="true" type="q89:KbCategory" xmlns:q89="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="WidgetRequiredFields">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="Email" />
              <xs:enumeration value="Name" />
              <xs:enumeration value="Company" />
              <xs:enumeration value="Phone" />
              <xs:enumeration value="Country" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="WidgetRequiredFields" nillable="true" type="q90:WidgetRequiredFields" xmlns:q90="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="ChatWidgetSize">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Normal" />
          <xs:enumeration value="Large" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ChatWidgetSize" nillable="true" type="q91:ChatWidgetSize" xmlns:q91="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="WidgetTheme">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Classic" />
          <xs:enumeration value="Modern" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="WidgetTheme" nillable="true" type="q92:WidgetTheme" xmlns:q92="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ChatBotSettings">
        <xs:sequence>
          <xs:element minOccurs="0" name="BotName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="BotRegisterScriptId" type="xs:int" />
          <xs:element minOccurs="0" name="BotSessionCreatedScriptId" type="xs:int" />
          <xs:element minOccurs="0" name="BotSessionChangedScriptId" type="xs:int" />
          <xs:element minOccurs="0" name="BotMessageReceivedScriptId" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ChatBotSettings" nillable="true" type="q93:ChatBotSettings" xmlns:q93="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="SaveChatTopicEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatTopicEntity" nillable="true" type="q94:ChatTopicEntity" xmlns:q94="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveChatTopicEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q95:ChatTopicEntity" xmlns:q95="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteChatTopicEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatTopicEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteChatTopicEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatPresence">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatPresenceResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q96:ArrayOfChatPresence" xmlns:q96="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfChatPresence">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ChatPresence" nillable="true" type="q97:ChatPresence" xmlns:q97="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfChatPresence" nillable="true" type="q98:ArrayOfChatPresence" xmlns:q98="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ChatPresence">
        <xs:complexContent mixed="false">
          <xs:extension base="q99:Carrier" xmlns:q99="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="UserId" type="xs:int" />
              <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OngoingChats" type="xs:int" />
              <xs:element minOccurs="0" name="Present" type="xs:boolean" />
              <xs:element minOccurs="0" name="ChatTopics" nillable="true" type="q100:ArrayOfint" xmlns:q100="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ChatPresence" nillable="true" type="q101:ChatPresence" xmlns:q101="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="SaveChatPresence">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatPresence" nillable="true" type="q102:ArrayOfChatPresence" xmlns:q102="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveChatPresenceResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatSessionEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatSessionEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatSessionEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q103:ChatSessionEntity" xmlns:q103="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChatSessionsForUser">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ChatSessionsForUserResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q104:ArrayOfChatSessionEntity" xmlns:q104="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfChatSessionEntity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ChatSessionEntity" nillable="true" type="q105:ChatSessionEntity" xmlns:q105="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfChatSessionEntity" nillable="true" type="q106:ArrayOfChatSessionEntity" xmlns:q106="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="TransferChatSession">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatSessionId" type="xs:int" />
            <xs:element minOccurs="0" name="ToAssociate" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TransferChatSessionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q107:ChatSessionEntity" xmlns:q107="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AcceptChatSessionTransfer">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatSessionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AcceptChatSessionTransferResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q108:ChatSessionEntity" xmlns:q108="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RejectChatSessionTransfer">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatSessionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RejectChatSessionTransferResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q109:ChatSessionEntity" xmlns:q109="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="PickUpChatSession">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatSessionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="PickUpChatSessionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q110:ChatSessionEntity" xmlns:q110="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="PickUpFirstChatSession">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="PickUpFirstChatSessionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q111:ChatSessionEntity" xmlns:q111="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ResetChatSession">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatSessionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ResetChatSessionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q112:ChatSessionEntity" xmlns:q112="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatTranscript">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatSessionId" type="xs:int" />
            <xs:element minOccurs="0" name="Html" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatTranscriptResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatMessages">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatSessionId" type="xs:int" />
            <xs:element minOccurs="0" name="After" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatMessagesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q113:ArrayOfChatMessage" xmlns:q113="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfChatMessage">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ChatMessage" nillable="true" type="q114:ChatMessage" xmlns:q114="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfChatMessage" nillable="true" type="q115:ArrayOfChatMessage" xmlns:q115="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ChatMessage">
        <xs:sequence>
          <xs:element minOccurs="0" name="ChatMessageId" type="xs:int" />
          <xs:element minOccurs="0" name="ChatSessionId" type="xs:int" />
          <xs:element minOccurs="0" name="Type" type="q116:ChatMessageType" xmlns:q116="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Author" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ReadByCustomer" type="xs:short" />
          <xs:element minOccurs="0" name="SpecialType" type="q117:ChatMessageSpecialType" xmlns:q117="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="SpecialParam" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="WhenPosted" type="xs:dateTime" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ChatMessage" nillable="true" type="q118:ChatMessage" xmlns:q118="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="ChatMessageType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Invalid" />
          <xs:enumeration value="ToCustomer" />
          <xs:enumeration value="ToUser" />
          <xs:enumeration value="Special" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ChatMessageType" nillable="true" type="q119:ChatMessageType" xmlns:q119="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="ChatMessageSpecialType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Welcome" />
          <xs:enumeration value="Url" />
          <xs:enumeration value="Block" />
          <xs:enumeration value="NewSession">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">5</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TransferedSession">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">6</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Error">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">7</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SessionDeleted">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">8</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="FaqSuccessQuestion">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">9</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ClosedByUser">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">10</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ClosedByCustomer">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">11</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ClosedByIdle">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">12</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TransferRejected">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">13</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ReopenedByCustomer">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">14</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ClickedOption">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">15</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="BotMessage">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">16</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Options">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">17</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ChatMessageSpecialType" nillable="true" type="q120:ChatMessageSpecialType" xmlns:q120="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="AddChatMessage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatSessionId" type="xs:int" />
            <xs:element minOccurs="0" name="Message" nillable="true" type="q121:ChatMessage" xmlns:q121="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddChatMessageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q122:ChatMessage" xmlns:q122="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatTopicEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatTopicEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatTopicEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q123:ChatTopicEntity" xmlns:q123="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="IsWithinOpeningHours">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatTopicId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="IsWithinOpeningHoursResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChatTopicsForUser">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ChatTopicsForUserResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q124:ArrayOfChatTopicEntity" xmlns:q124="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfChatTopicEntity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ChatTopicEntity" nillable="true" type="q125:ChatTopicEntity" xmlns:q125="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfChatTopicEntity" nillable="true" type="q126:ArrayOfChatTopicEntity" xmlns:q126="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetUserAgentList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Flat" type="xs:boolean" />
            <xs:element minOccurs="0" name="OnlyPresent" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserAgentListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q127:ArrayOfMDOListItem" xmlns:q127="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfMDOListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="MDOListItem" nillable="true" type="q128:MDOListItem" xmlns:q128="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfMDOListItem" nillable="true" type="q129:ArrayOfMDOListItem" xmlns:q129="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="MDOListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q130:Carrier" xmlns:q130="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ToolTip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ChildItems" nillable="true" type="q130:ArrayOfMDOListItem" />
              <xs:element minOccurs="0" name="IconHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ColorBlock" type="xs:int" />
              <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StyleHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="MDOListItem" nillable="true" type="q131:MDOListItem" xmlns:q131="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetChatTopicUserAgentList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatTopicId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatTopicUserAgentListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q132:ArrayOfChatTopicAgent" xmlns:q132="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfChatTopicAgent">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ChatTopicAgent" nillable="true" type="q133:ChatTopicAgent" xmlns:q133="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfChatTopicAgent" nillable="true" type="q134:ArrayOfChatTopicAgent" xmlns:q134="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetChatTopicUserAgent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatTopicId" type="xs:int" />
            <xs:element minOccurs="0" name="Username" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatTopicUserAgentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q135:ChatTopicAgent" xmlns:q135="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddChatTopicUserAgent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatTopicId" type="xs:int" />
            <xs:element minOccurs="0" name="Useragent" nillable="true" type="q136:ChatTopicAgent" xmlns:q136="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddChatTopicUserAgentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q137:ChatTopicAgent" xmlns:q137="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateChatTopicUserAgent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatTopicId" type="xs:int" />
            <xs:element minOccurs="0" name="Username" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Useragent" nillable="true" type="q138:ChatTopicAgent" xmlns:q138="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateChatTopicUserAgentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q139:ChatTopicAgent" xmlns:q139="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateChatTopicUserAgents">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatTopicId" type="xs:int" />
            <xs:element minOccurs="0" name="Useragents" nillable="true" type="q140:ArrayOfChatTopicAgent" xmlns:q140="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateChatTopicUserAgentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q141:ArrayOfChatTopicAgent" xmlns:q141="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteChatTopicUserAgent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatTopicId" type="xs:int" />
            <xs:element minOccurs="0" name="Username" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteChatTopicUserAgentResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateChatSessionForTopic">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatTopicId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateChatSessionForTopicResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q142:ChatSessionEntity" xmlns:q142="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
  <wsdl:message name="CreateDefaultChatSessionEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultChatSessionEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultChatSessionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultChatSessionEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultChatSessionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultChatSessionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveChatSessionEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveChatSessionEntity" />
  </wsdl:message>
  <wsdl:message name="SaveChatSessionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveChatSessionEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveChatSessionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveChatSessionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteChatSessionEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteChatSessionEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteChatSessionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteChatSessionEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteChatSessionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteChatSessionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultChatTopicAgentRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultChatTopicAgent" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultChatTopicAgentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultChatTopicAgentResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultChatTopicAgentResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultChatTopicAgentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultChatTopicEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultChatTopicEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultChatTopicEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultChatTopicEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultChatTopicEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultChatTopicEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveChatTopicEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveChatTopicEntity" />
  </wsdl:message>
  <wsdl:message name="SaveChatTopicEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveChatTopicEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveChatTopicEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveChatTopicEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteChatTopicEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteChatTopicEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteChatTopicEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteChatTopicEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteChatTopicEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteChatTopicEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatPresenceRequest">
    <wsdl:part name="parameters" element="tns:GetChatPresence" />
  </wsdl:message>
  <wsdl:message name="GetChatPresenceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatPresenceResponse">
    <wsdl:part name="parameters" element="tns:GetChatPresenceResponse" />
  </wsdl:message>
  <wsdl:message name="GetChatPresenceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveChatPresenceRequest">
    <wsdl:part name="parameters" element="tns:SaveChatPresence" />
  </wsdl:message>
  <wsdl:message name="SaveChatPresenceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveChatPresenceResponse">
    <wsdl:part name="parameters" element="tns:SaveChatPresenceResponse" />
  </wsdl:message>
  <wsdl:message name="SaveChatPresenceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatSessionEntityRequest">
    <wsdl:part name="parameters" element="tns:GetChatSessionEntity" />
  </wsdl:message>
  <wsdl:message name="GetChatSessionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatSessionEntityResponse">
    <wsdl:part name="parameters" element="tns:GetChatSessionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetChatSessionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChatSessionsForUserRequest">
    <wsdl:part name="parameters" element="tns:ChatSessionsForUser" />
  </wsdl:message>
  <wsdl:message name="ChatSessionsForUserRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChatSessionsForUserResponse">
    <wsdl:part name="parameters" element="tns:ChatSessionsForUserResponse" />
  </wsdl:message>
  <wsdl:message name="ChatSessionsForUserResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TransferChatSessionRequest">
    <wsdl:part name="parameters" element="tns:TransferChatSession" />
  </wsdl:message>
  <wsdl:message name="TransferChatSessionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TransferChatSessionResponse">
    <wsdl:part name="parameters" element="tns:TransferChatSessionResponse" />
  </wsdl:message>
  <wsdl:message name="TransferChatSessionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AcceptChatSessionTransferRequest">
    <wsdl:part name="parameters" element="tns:AcceptChatSessionTransfer" />
  </wsdl:message>
  <wsdl:message name="AcceptChatSessionTransferRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AcceptChatSessionTransferResponse">
    <wsdl:part name="parameters" element="tns:AcceptChatSessionTransferResponse" />
  </wsdl:message>
  <wsdl:message name="AcceptChatSessionTransferResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RejectChatSessionTransferRequest">
    <wsdl:part name="parameters" element="tns:RejectChatSessionTransfer" />
  </wsdl:message>
  <wsdl:message name="RejectChatSessionTransferRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RejectChatSessionTransferResponse">
    <wsdl:part name="parameters" element="tns:RejectChatSessionTransferResponse" />
  </wsdl:message>
  <wsdl:message name="RejectChatSessionTransferResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PickUpChatSessionRequest">
    <wsdl:part name="parameters" element="tns:PickUpChatSession" />
  </wsdl:message>
  <wsdl:message name="PickUpChatSessionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PickUpChatSessionResponse">
    <wsdl:part name="parameters" element="tns:PickUpChatSessionResponse" />
  </wsdl:message>
  <wsdl:message name="PickUpChatSessionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PickUpFirstChatSessionRequest">
    <wsdl:part name="parameters" element="tns:PickUpFirstChatSession" />
  </wsdl:message>
  <wsdl:message name="PickUpFirstChatSessionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PickUpFirstChatSessionResponse">
    <wsdl:part name="parameters" element="tns:PickUpFirstChatSessionResponse" />
  </wsdl:message>
  <wsdl:message name="PickUpFirstChatSessionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ResetChatSessionRequest">
    <wsdl:part name="parameters" element="tns:ResetChatSession" />
  </wsdl:message>
  <wsdl:message name="ResetChatSessionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ResetChatSessionResponse">
    <wsdl:part name="parameters" element="tns:ResetChatSessionResponse" />
  </wsdl:message>
  <wsdl:message name="ResetChatSessionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatTranscriptRequest">
    <wsdl:part name="parameters" element="tns:GetChatTranscript" />
  </wsdl:message>
  <wsdl:message name="GetChatTranscriptRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatTranscriptResponse">
    <wsdl:part name="parameters" element="tns:GetChatTranscriptResponse" />
  </wsdl:message>
  <wsdl:message name="GetChatTranscriptResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatMessagesRequest">
    <wsdl:part name="parameters" element="tns:GetChatMessages" />
  </wsdl:message>
  <wsdl:message name="GetChatMessagesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatMessagesResponse">
    <wsdl:part name="parameters" element="tns:GetChatMessagesResponse" />
  </wsdl:message>
  <wsdl:message name="GetChatMessagesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddChatMessageRequest">
    <wsdl:part name="parameters" element="tns:AddChatMessage" />
  </wsdl:message>
  <wsdl:message name="AddChatMessageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddChatMessageResponse">
    <wsdl:part name="parameters" element="tns:AddChatMessageResponse" />
  </wsdl:message>
  <wsdl:message name="AddChatMessageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatTopicEntityRequest">
    <wsdl:part name="parameters" element="tns:GetChatTopicEntity" />
  </wsdl:message>
  <wsdl:message name="GetChatTopicEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatTopicEntityResponse">
    <wsdl:part name="parameters" element="tns:GetChatTopicEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetChatTopicEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsWithinOpeningHoursRequest">
    <wsdl:part name="parameters" element="tns:IsWithinOpeningHours" />
  </wsdl:message>
  <wsdl:message name="IsWithinOpeningHoursRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsWithinOpeningHoursResponse">
    <wsdl:part name="parameters" element="tns:IsWithinOpeningHoursResponse" />
  </wsdl:message>
  <wsdl:message name="IsWithinOpeningHoursResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChatTopicsForUserRequest">
    <wsdl:part name="parameters" element="tns:ChatTopicsForUser" />
  </wsdl:message>
  <wsdl:message name="ChatTopicsForUserRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChatTopicsForUserResponse">
    <wsdl:part name="parameters" element="tns:ChatTopicsForUserResponse" />
  </wsdl:message>
  <wsdl:message name="ChatTopicsForUserResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserAgentListRequest">
    <wsdl:part name="parameters" element="tns:GetUserAgentList" />
  </wsdl:message>
  <wsdl:message name="GetUserAgentListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserAgentListResponse">
    <wsdl:part name="parameters" element="tns:GetUserAgentListResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserAgentListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatTopicUserAgentListRequest">
    <wsdl:part name="parameters" element="tns:GetChatTopicUserAgentList" />
  </wsdl:message>
  <wsdl:message name="GetChatTopicUserAgentListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatTopicUserAgentListResponse">
    <wsdl:part name="parameters" element="tns:GetChatTopicUserAgentListResponse" />
  </wsdl:message>
  <wsdl:message name="GetChatTopicUserAgentListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatTopicUserAgentRequest">
    <wsdl:part name="parameters" element="tns:GetChatTopicUserAgent" />
  </wsdl:message>
  <wsdl:message name="GetChatTopicUserAgentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatTopicUserAgentResponse">
    <wsdl:part name="parameters" element="tns:GetChatTopicUserAgentResponse" />
  </wsdl:message>
  <wsdl:message name="GetChatTopicUserAgentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddChatTopicUserAgentRequest">
    <wsdl:part name="parameters" element="tns:AddChatTopicUserAgent" />
  </wsdl:message>
  <wsdl:message name="AddChatTopicUserAgentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddChatTopicUserAgentResponse">
    <wsdl:part name="parameters" element="tns:AddChatTopicUserAgentResponse" />
  </wsdl:message>
  <wsdl:message name="AddChatTopicUserAgentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateChatTopicUserAgentRequest">
    <wsdl:part name="parameters" element="tns:UpdateChatTopicUserAgent" />
  </wsdl:message>
  <wsdl:message name="UpdateChatTopicUserAgentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateChatTopicUserAgentResponse">
    <wsdl:part name="parameters" element="tns:UpdateChatTopicUserAgentResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateChatTopicUserAgentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateChatTopicUserAgentsRequest">
    <wsdl:part name="parameters" element="tns:UpdateChatTopicUserAgents" />
  </wsdl:message>
  <wsdl:message name="UpdateChatTopicUserAgentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateChatTopicUserAgentsResponse">
    <wsdl:part name="parameters" element="tns:UpdateChatTopicUserAgentsResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateChatTopicUserAgentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteChatTopicUserAgentRequest">
    <wsdl:part name="parameters" element="tns:DeleteChatTopicUserAgent" />
  </wsdl:message>
  <wsdl:message name="DeleteChatTopicUserAgentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteChatTopicUserAgentResponse">
    <wsdl:part name="parameters" element="tns:DeleteChatTopicUserAgentResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteChatTopicUserAgentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateChatSessionForTopicRequest">
    <wsdl:part name="parameters" element="tns:CreateChatSessionForTopic" />
  </wsdl:message>
  <wsdl:message name="CreateChatSessionForTopicRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateChatSessionForTopicResponse">
    <wsdl:part name="parameters" element="tns:CreateChatSessionForTopicResponse" />
  </wsdl:message>
  <wsdl:message name="CreateChatSessionForTopicResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Chat">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Chat</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultChatSessionEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new ChatSessionEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/CreateDefaultChatSessionEntity" name="CreateDefaultChatSessionEntityRequest" message="tns:CreateDefaultChatSessionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/CreateDefaultChatSessionEntityResponse" name="CreateDefaultChatSessionEntityResponse" message="tns:CreateDefaultChatSessionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveChatSessionEntity">
      <wsdl:documentation>
        <summary>Updates the existing ChatSessionEntity or creates a new ChatSessionEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/SaveChatSessionEntity" name="SaveChatSessionEntityRequest" message="tns:SaveChatSessionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/SaveChatSessionEntityResponse" name="SaveChatSessionEntityResponse" message="tns:SaveChatSessionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteChatSessionEntity">
      <wsdl:documentation>
        <summary>Deletes the ChatSessionEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/DeleteChatSessionEntity" name="DeleteChatSessionEntityRequest" message="tns:DeleteChatSessionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/DeleteChatSessionEntityResponse" name="DeleteChatSessionEntityResponse" message="tns:DeleteChatSessionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultChatTopicAgent">
      <wsdl:documentation>
        <summary>Loading default values into a new ChatTopicAgent.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/CreateDefaultChatTopicAgent" name="CreateDefaultChatTopicAgentRequest" message="tns:CreateDefaultChatTopicAgentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/CreateDefaultChatTopicAgentResponse" name="CreateDefaultChatTopicAgentResponse" message="tns:CreateDefaultChatTopicAgentResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultChatTopicEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new ChatTopicEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/CreateDefaultChatTopicEntity" name="CreateDefaultChatTopicEntityRequest" message="tns:CreateDefaultChatTopicEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/CreateDefaultChatTopicEntityResponse" name="CreateDefaultChatTopicEntityResponse" message="tns:CreateDefaultChatTopicEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveChatTopicEntity">
      <wsdl:documentation>
        <summary>Updates the existing ChatTopicEntity or creates a new ChatTopicEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/SaveChatTopicEntity" name="SaveChatTopicEntityRequest" message="tns:SaveChatTopicEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/SaveChatTopicEntityResponse" name="SaveChatTopicEntityResponse" message="tns:SaveChatTopicEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteChatTopicEntity">
      <wsdl:documentation>
        <summary>Deletes the ChatTopicEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/DeleteChatTopicEntity" name="DeleteChatTopicEntityRequest" message="tns:DeleteChatTopicEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/DeleteChatTopicEntityResponse" name="DeleteChatTopicEntityResponse" message="tns:DeleteChatTopicEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetChatPresence">
      <wsdl:documentation>
        <summary>Get the chat presence status for all chat users</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatPresence" name="GetChatPresenceRequest" message="tns:GetChatPresenceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatPresenceResponse" name="GetChatPresenceResponse" message="tns:GetChatPresenceResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveChatPresence">
      <wsdl:documentation>
        <summary>Save the chat presence for specified users</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/SaveChatPresence" name="SaveChatPresenceRequest" message="tns:SaveChatPresenceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/SaveChatPresenceResponse" name="SaveChatPresenceResponse" message="tns:SaveChatPresenceResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetChatSessionEntity">
      <wsdl:documentation>
        <summary>Gets a ChatSessionEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatSessionEntity" name="GetChatSessionEntityRequest" message="tns:GetChatSessionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatSessionEntityResponse" name="GetChatSessionEntityResponse" message="tns:GetChatSessionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChatSessionsForUser">
      <wsdl:documentation>
        <summary>Get all chat sessions which this user is a member of. Members means that you have at least one of: Can Respond, Notifications, Listen or Manager</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/ChatSessionsForUser" name="ChatSessionsForUserRequest" message="tns:ChatSessionsForUserRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/ChatSessionsForUserResponse" name="ChatSessionsForUserResponse" message="tns:ChatSessionsForUserResponse" />
    </wsdl:operation>
    <wsdl:operation name="TransferChatSession">
      <wsdl:documentation>
        <summary>Request to send the session to another user. If the session does not belong to the user, nothing happens.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/TransferChatSession" name="TransferChatSessionRequest" message="tns:TransferChatSessionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/TransferChatSessionResponse" name="TransferChatSessionResponse" message="tns:TransferChatSessionResponse" />
    </wsdl:operation>
    <wsdl:operation name="AcceptChatSessionTransfer">
      <wsdl:documentation>
        <summary>Accept the transfer: assign the session to the user. If the session is not being transferred, nothing happens.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/AcceptChatSessionTransfer" name="AcceptChatSessionTransferRequest" message="tns:AcceptChatSessionTransferRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/AcceptChatSessionTransferResponse" name="AcceptChatSessionTransferResponse" message="tns:AcceptChatSessionTransferResponse" />
    </wsdl:operation>
    <wsdl:operation name="RejectChatSessionTransfer">
      <wsdl:documentation>
        <summary>Do not want. Deny the transfer to the user. If the session is not being transferred, nothing happens.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/RejectChatSessionTransfer" name="RejectChatSessionTransferRequest" message="tns:RejectChatSessionTransferRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/RejectChatSessionTransferResponse" name="RejectChatSessionTransferResponse" message="tns:RejectChatSessionTransferResponse" />
    </wsdl:operation>
    <wsdl:operation name="PickUpChatSession">
      <wsdl:documentation>
        <summary>'answer' the session: assign the session to the user. The welcome message is sent to the customer. Returns NULL if session was not in queue.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/PickUpChatSession" name="PickUpChatSessionRequest" message="tns:PickUpChatSessionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/PickUpChatSessionResponse" name="PickUpChatSessionResponse" message="tns:PickUpChatSessionResponse" />
    </wsdl:operation>
    <wsdl:operation name="PickUpFirstChatSession">
      <wsdl:documentation>
        <summary>'answer' the first available session from the queue: assign the session to the user. The welcome message is sent to the customer.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/PickUpFirstChatSession" name="PickUpFirstChatSessionRequest" message="tns:PickUpFirstChatSessionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/PickUpFirstChatSessionResponse" name="PickUpFirstChatSessionResponse" message="tns:PickUpFirstChatSessionResponse" />
    </wsdl:operation>
    <wsdl:operation name="ResetChatSession">
      <wsdl:documentation>
        <summary>Reset chat session, put it back on the queue for pickup. Used by bots to hand off a session to human</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/ResetChatSession" name="ResetChatSessionRequest" message="tns:ResetChatSessionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/ResetChatSessionResponse" name="ResetChatSessionResponse" message="tns:ResetChatSessionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetChatTranscript">
      <wsdl:documentation>
        <summary>Get the chat transcript, formatted as plain text or html</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatTranscript" name="GetChatTranscriptRequest" message="tns:GetChatTranscriptRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatTranscriptResponse" name="GetChatTranscriptResponse" message="tns:GetChatTranscriptResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetChatMessages">
      <wsdl:documentation>
        <summary>Get all or some of the messages in a chat session</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatMessages" name="GetChatMessagesRequest" message="tns:GetChatMessagesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatMessagesResponse" name="GetChatMessagesResponse" message="tns:GetChatMessagesResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddChatMessage">
      <wsdl:documentation>
        <summary>Add a new message to a chat session</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/AddChatMessage" name="AddChatMessageRequest" message="tns:AddChatMessageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/AddChatMessageResponse" name="AddChatMessageResponse" message="tns:AddChatMessageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetChatTopicEntity">
      <wsdl:documentation>
        <summary>Gets a ChatTopicEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatTopicEntity" name="GetChatTopicEntityRequest" message="tns:GetChatTopicEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatTopicEntityResponse" name="GetChatTopicEntityResponse" message="tns:GetChatTopicEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="IsWithinOpeningHours">
      <wsdl:documentation>
        <summary>Check if we are right now within the opening hours of the given topic. Will use timezones to calculate if configured.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/IsWithinOpeningHours" name="IsWithinOpeningHoursRequest" message="tns:IsWithinOpeningHoursRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/IsWithinOpeningHoursResponse" name="IsWithinOpeningHoursResponse" message="tns:IsWithinOpeningHoursResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChatTopicsForUser">
      <wsdl:documentation>
        <summary>Get all chat topics which this user is a member of. Members means that you have at least one of: Can Respond, Notifications, Listen or Manager</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/ChatTopicsForUser" name="ChatTopicsForUserRequest" message="tns:ChatTopicsForUserRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/ChatTopicsForUserResponse" name="ChatTopicsForUserResponse" message="tns:ChatTopicsForUserResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserAgentList">
      <wsdl:documentation>
        <summary>Get list of users that can be assigned to chat topics. Users with Chat-CALs from the MDO list 'chatuser'</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetUserAgentList" name="GetUserAgentListRequest" message="tns:GetUserAgentListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetUserAgentListResponse" name="GetUserAgentListResponse" message="tns:GetUserAgentListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetChatTopicUserAgentList">
      <wsdl:documentation>
        <summary>Get list of users assigned to a chat topic</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatTopicUserAgentList" name="GetChatTopicUserAgentListRequest" message="tns:GetChatTopicUserAgentListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatTopicUserAgentListResponse" name="GetChatTopicUserAgentListResponse" message="tns:GetChatTopicUserAgentListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetChatTopicUserAgent">
      <wsdl:documentation>
        <summary>Get a user assigned to a topic</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatTopicUserAgent" name="GetChatTopicUserAgentRequest" message="tns:GetChatTopicUserAgentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatTopicUserAgentResponse" name="GetChatTopicUserAgentResponse" message="tns:GetChatTopicUserAgentResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddChatTopicUserAgent">
      <wsdl:documentation>
        <summary>Add a user to a chat topic</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/AddChatTopicUserAgent" name="AddChatTopicUserAgentRequest" message="tns:AddChatTopicUserAgentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/AddChatTopicUserAgentResponse" name="AddChatTopicUserAgentResponse" message="tns:AddChatTopicUserAgentResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateChatTopicUserAgent">
      <wsdl:documentation>
        <summary>Update a user's role in a chat topic</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/UpdateChatTopicUserAgent" name="UpdateChatTopicUserAgentRequest" message="tns:UpdateChatTopicUserAgentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/UpdateChatTopicUserAgentResponse" name="UpdateChatTopicUserAgentResponse" message="tns:UpdateChatTopicUserAgentResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateChatTopicUserAgents">
      <wsdl:documentation>
        <summary>Update users roles in a chat topic</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/UpdateChatTopicUserAgents" name="UpdateChatTopicUserAgentsRequest" message="tns:UpdateChatTopicUserAgentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/UpdateChatTopicUserAgentsResponse" name="UpdateChatTopicUserAgentsResponse" message="tns:UpdateChatTopicUserAgentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteChatTopicUserAgent">
      <wsdl:documentation>
        <summary>Remove a user from a topic</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/DeleteChatTopicUserAgent" name="DeleteChatTopicUserAgentRequest" message="tns:DeleteChatTopicUserAgentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/DeleteChatTopicUserAgentResponse" name="DeleteChatTopicUserAgentResponse" message="tns:DeleteChatTopicUserAgentResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateChatSessionForTopic">
      <wsdl:documentation>
        <summary>Create a new session on a chat topic</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/CreateChatSessionForTopic" name="CreateChatSessionForTopicRequest" message="tns:CreateChatSessionForTopicRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/CreateChatSessionForTopicResponse" name="CreateChatSessionForTopicResponse" message="tns:CreateChatSessionForTopicResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Chat" type="tns:Chat">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultChatSessionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/CreateDefaultChatSessionEntity" style="document" />
      <wsdl:input name="CreateDefaultChatSessionEntityRequest">
        <soap:header message="tns:CreateDefaultChatSessionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultChatSessionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultChatSessionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultChatSessionEntityResponse">
        <soap:header message="tns:CreateDefaultChatSessionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultChatSessionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultChatSessionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultChatSessionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveChatSessionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/SaveChatSessionEntity" style="document" />
      <wsdl:input name="SaveChatSessionEntityRequest">
        <soap:header message="tns:SaveChatSessionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveChatSessionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveChatSessionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveChatSessionEntityResponse">
        <soap:header message="tns:SaveChatSessionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveChatSessionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveChatSessionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveChatSessionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteChatSessionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/DeleteChatSessionEntity" style="document" />
      <wsdl:input name="DeleteChatSessionEntityRequest">
        <soap:header message="tns:DeleteChatSessionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteChatSessionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteChatSessionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteChatSessionEntityResponse">
        <soap:header message="tns:DeleteChatSessionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteChatSessionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteChatSessionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteChatSessionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultChatTopicAgent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/CreateDefaultChatTopicAgent" style="document" />
      <wsdl:input name="CreateDefaultChatTopicAgentRequest">
        <soap:header message="tns:CreateDefaultChatTopicAgentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultChatTopicAgentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultChatTopicAgentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultChatTopicAgentResponse">
        <soap:header message="tns:CreateDefaultChatTopicAgentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultChatTopicAgentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultChatTopicAgentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultChatTopicAgentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultChatTopicEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/CreateDefaultChatTopicEntity" style="document" />
      <wsdl:input name="CreateDefaultChatTopicEntityRequest">
        <soap:header message="tns:CreateDefaultChatTopicEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultChatTopicEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultChatTopicEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultChatTopicEntityResponse">
        <soap:header message="tns:CreateDefaultChatTopicEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultChatTopicEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultChatTopicEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultChatTopicEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveChatTopicEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/SaveChatTopicEntity" style="document" />
      <wsdl:input name="SaveChatTopicEntityRequest">
        <soap:header message="tns:SaveChatTopicEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveChatTopicEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveChatTopicEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveChatTopicEntityResponse">
        <soap:header message="tns:SaveChatTopicEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveChatTopicEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveChatTopicEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveChatTopicEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteChatTopicEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/DeleteChatTopicEntity" style="document" />
      <wsdl:input name="DeleteChatTopicEntityRequest">
        <soap:header message="tns:DeleteChatTopicEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteChatTopicEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteChatTopicEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteChatTopicEntityResponse">
        <soap:header message="tns:DeleteChatTopicEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteChatTopicEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteChatTopicEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteChatTopicEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetChatPresence">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatPresence" style="document" />
      <wsdl:input name="GetChatPresenceRequest">
        <soap:header message="tns:GetChatPresenceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetChatPresenceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetChatPresenceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetChatPresenceResponse">
        <soap:header message="tns:GetChatPresenceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetChatPresenceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetChatPresenceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetChatPresenceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveChatPresence">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/SaveChatPresence" style="document" />
      <wsdl:input name="SaveChatPresenceRequest">
        <soap:header message="tns:SaveChatPresenceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveChatPresenceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveChatPresenceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveChatPresenceResponse">
        <soap:header message="tns:SaveChatPresenceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveChatPresenceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveChatPresenceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveChatPresenceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetChatSessionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatSessionEntity" style="document" />
      <wsdl:input name="GetChatSessionEntityRequest">
        <soap:header message="tns:GetChatSessionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetChatSessionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetChatSessionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetChatSessionEntityResponse">
        <soap:header message="tns:GetChatSessionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetChatSessionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetChatSessionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetChatSessionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChatSessionsForUser">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/ChatSessionsForUser" style="document" />
      <wsdl:input name="ChatSessionsForUserRequest">
        <soap:header message="tns:ChatSessionsForUserRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChatSessionsForUserRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChatSessionsForUserRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChatSessionsForUserResponse">
        <soap:header message="tns:ChatSessionsForUserResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChatSessionsForUserResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChatSessionsForUserResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChatSessionsForUserResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="TransferChatSession">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/TransferChatSession" style="document" />
      <wsdl:input name="TransferChatSessionRequest">
        <soap:header message="tns:TransferChatSessionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TransferChatSessionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TransferChatSessionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TransferChatSessionResponse">
        <soap:header message="tns:TransferChatSessionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TransferChatSessionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TransferChatSessionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TransferChatSessionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AcceptChatSessionTransfer">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/AcceptChatSessionTransfer" style="document" />
      <wsdl:input name="AcceptChatSessionTransferRequest">
        <soap:header message="tns:AcceptChatSessionTransferRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AcceptChatSessionTransferRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AcceptChatSessionTransferRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AcceptChatSessionTransferResponse">
        <soap:header message="tns:AcceptChatSessionTransferResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AcceptChatSessionTransferResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AcceptChatSessionTransferResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AcceptChatSessionTransferResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RejectChatSessionTransfer">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/RejectChatSessionTransfer" style="document" />
      <wsdl:input name="RejectChatSessionTransferRequest">
        <soap:header message="tns:RejectChatSessionTransferRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RejectChatSessionTransferRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RejectChatSessionTransferRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RejectChatSessionTransferResponse">
        <soap:header message="tns:RejectChatSessionTransferResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RejectChatSessionTransferResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RejectChatSessionTransferResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RejectChatSessionTransferResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="PickUpChatSession">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/PickUpChatSession" style="document" />
      <wsdl:input name="PickUpChatSessionRequest">
        <soap:header message="tns:PickUpChatSessionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:PickUpChatSessionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:PickUpChatSessionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="PickUpChatSessionResponse">
        <soap:header message="tns:PickUpChatSessionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:PickUpChatSessionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:PickUpChatSessionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:PickUpChatSessionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="PickUpFirstChatSession">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/PickUpFirstChatSession" style="document" />
      <wsdl:input name="PickUpFirstChatSessionRequest">
        <soap:header message="tns:PickUpFirstChatSessionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:PickUpFirstChatSessionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:PickUpFirstChatSessionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="PickUpFirstChatSessionResponse">
        <soap:header message="tns:PickUpFirstChatSessionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:PickUpFirstChatSessionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:PickUpFirstChatSessionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:PickUpFirstChatSessionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ResetChatSession">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/ResetChatSession" style="document" />
      <wsdl:input name="ResetChatSessionRequest">
        <soap:header message="tns:ResetChatSessionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ResetChatSessionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ResetChatSessionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ResetChatSessionResponse">
        <soap:header message="tns:ResetChatSessionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ResetChatSessionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ResetChatSessionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ResetChatSessionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetChatTranscript">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatTranscript" style="document" />
      <wsdl:input name="GetChatTranscriptRequest">
        <soap:header message="tns:GetChatTranscriptRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetChatTranscriptRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetChatTranscriptRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetChatTranscriptResponse">
        <soap:header message="tns:GetChatTranscriptResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetChatTranscriptResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetChatTranscriptResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetChatTranscriptResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetChatMessages">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatMessages" style="document" />
      <wsdl:input name="GetChatMessagesRequest">
        <soap:header message="tns:GetChatMessagesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetChatMessagesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetChatMessagesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetChatMessagesResponse">
        <soap:header message="tns:GetChatMessagesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetChatMessagesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetChatMessagesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetChatMessagesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddChatMessage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/AddChatMessage" style="document" />
      <wsdl:input name="AddChatMessageRequest">
        <soap:header message="tns:AddChatMessageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddChatMessageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddChatMessageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddChatMessageResponse">
        <soap:header message="tns:AddChatMessageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddChatMessageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddChatMessageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddChatMessageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetChatTopicEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatTopicEntity" style="document" />
      <wsdl:input name="GetChatTopicEntityRequest">
        <soap:header message="tns:GetChatTopicEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetChatTopicEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetChatTopicEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetChatTopicEntityResponse">
        <soap:header message="tns:GetChatTopicEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetChatTopicEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetChatTopicEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetChatTopicEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="IsWithinOpeningHours">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/IsWithinOpeningHours" style="document" />
      <wsdl:input name="IsWithinOpeningHoursRequest">
        <soap:header message="tns:IsWithinOpeningHoursRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:IsWithinOpeningHoursRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:IsWithinOpeningHoursRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="IsWithinOpeningHoursResponse">
        <soap:header message="tns:IsWithinOpeningHoursResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:IsWithinOpeningHoursResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:IsWithinOpeningHoursResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:IsWithinOpeningHoursResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChatTopicsForUser">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/ChatTopicsForUser" style="document" />
      <wsdl:input name="ChatTopicsForUserRequest">
        <soap:header message="tns:ChatTopicsForUserRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChatTopicsForUserRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChatTopicsForUserRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChatTopicsForUserResponse">
        <soap:header message="tns:ChatTopicsForUserResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChatTopicsForUserResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChatTopicsForUserResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChatTopicsForUserResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserAgentList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetUserAgentList" style="document" />
      <wsdl:input name="GetUserAgentListRequest">
        <soap:header message="tns:GetUserAgentListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserAgentListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserAgentListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserAgentListResponse">
        <soap:header message="tns:GetUserAgentListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserAgentListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserAgentListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserAgentListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetChatTopicUserAgentList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatTopicUserAgentList" style="document" />
      <wsdl:input name="GetChatTopicUserAgentListRequest">
        <soap:header message="tns:GetChatTopicUserAgentListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetChatTopicUserAgentListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetChatTopicUserAgentListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetChatTopicUserAgentListResponse">
        <soap:header message="tns:GetChatTopicUserAgentListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetChatTopicUserAgentListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetChatTopicUserAgentListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetChatTopicUserAgentListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetChatTopicUserAgent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/GetChatTopicUserAgent" style="document" />
      <wsdl:input name="GetChatTopicUserAgentRequest">
        <soap:header message="tns:GetChatTopicUserAgentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetChatTopicUserAgentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetChatTopicUserAgentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetChatTopicUserAgentResponse">
        <soap:header message="tns:GetChatTopicUserAgentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetChatTopicUserAgentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetChatTopicUserAgentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetChatTopicUserAgentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddChatTopicUserAgent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/AddChatTopicUserAgent" style="document" />
      <wsdl:input name="AddChatTopicUserAgentRequest">
        <soap:header message="tns:AddChatTopicUserAgentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddChatTopicUserAgentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddChatTopicUserAgentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddChatTopicUserAgentResponse">
        <soap:header message="tns:AddChatTopicUserAgentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddChatTopicUserAgentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddChatTopicUserAgentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddChatTopicUserAgentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateChatTopicUserAgent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/UpdateChatTopicUserAgent" style="document" />
      <wsdl:input name="UpdateChatTopicUserAgentRequest">
        <soap:header message="tns:UpdateChatTopicUserAgentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateChatTopicUserAgentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateChatTopicUserAgentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateChatTopicUserAgentResponse">
        <soap:header message="tns:UpdateChatTopicUserAgentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateChatTopicUserAgentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateChatTopicUserAgentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateChatTopicUserAgentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateChatTopicUserAgents">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/UpdateChatTopicUserAgents" style="document" />
      <wsdl:input name="UpdateChatTopicUserAgentsRequest">
        <soap:header message="tns:UpdateChatTopicUserAgentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateChatTopicUserAgentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateChatTopicUserAgentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateChatTopicUserAgentsResponse">
        <soap:header message="tns:UpdateChatTopicUserAgentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateChatTopicUserAgentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateChatTopicUserAgentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateChatTopicUserAgentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteChatTopicUserAgent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/DeleteChatTopicUserAgent" style="document" />
      <wsdl:input name="DeleteChatTopicUserAgentRequest">
        <soap:header message="tns:DeleteChatTopicUserAgentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteChatTopicUserAgentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteChatTopicUserAgentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteChatTopicUserAgentResponse">
        <soap:header message="tns:DeleteChatTopicUserAgentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteChatTopicUserAgentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteChatTopicUserAgentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteChatTopicUserAgentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateChatSessionForTopic">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Chat/CreateChatSessionForTopic" style="document" />
      <wsdl:input name="CreateChatSessionForTopicRequest">
        <soap:header message="tns:CreateChatSessionForTopicRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateChatSessionForTopicRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateChatSessionForTopicRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateChatSessionForTopicResponse">
        <soap:header message="tns:CreateChatSessionForTopicResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateChatSessionForTopicResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateChatSessionForTopicResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateChatSessionForTopicResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfChatService">
    <wsdl:port name="BasicHttpBinding_Chat" binding="tns:BasicHttpBinding_Chat">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/Chat.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

