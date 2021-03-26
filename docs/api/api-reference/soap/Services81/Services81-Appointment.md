---
Generated: 1
TOCExclude: 1
title: Services81.AppointmentAgent WSDL
---

# Services81.AppointmentAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfAppointmentService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services81" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services81" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services81" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:ser="http://schemas.microsoft.com/2003/10/Serialization/">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultAppointmentEntity">
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
      <xs:element name="SoCredentials" nillable="true" type="q1:SoCredentials" xmlns:q1="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="Credentials" nillable="true" type="q2:SoCredentials" xmlns:q2="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="SoTimeZone">
        <xs:sequence>
          <xs:element minOccurs="0" name="SoTimeZoneId" type="xs:int" />
          <xs:element minOccurs="0" name="SoTimeZoneLocationCode" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoTimeZone" nillable="true" type="q3:SoTimeZone" xmlns:q3="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="TimeZone" nillable="true" type="q4:SoTimeZone" xmlns:q4="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="CreateDefaultAppointmentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q5:AppointmentEntity" xmlns:q5="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="AppointmentEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q6:Carrier" xmlns:q6="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="Associate" nillable="true" type="q6:Associate" />
              <xs:element minOccurs="0" name="Contact" nillable="true" type="q6:Contact" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="q6:Associate" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="q6:Associate" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="InvitedPerson" nillable="true" type="q6:Person" />
              <xs:element minOccurs="0" name="Person" nillable="true" type="q6:Person" />
              <xs:element minOccurs="0" name="MotherId" type="xs:int" />
              <xs:element minOccurs="0" name="Priority" nillable="true" type="q6:Priority" />
              <xs:element minOccurs="0" name="Private" type="q6:AppointmentPrivate" />
              <xs:element minOccurs="0" name="Project" nillable="true" type="q6:Project" />
              <xs:element minOccurs="0" name="Type" type="q6:AppointmentType" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Completed" type="q6:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveLinks" type="xs:int" />
              <xs:element minOccurs="0" name="Links" nillable="true" type="q6:ArrayOfLink" />
              <xs:element minOccurs="0" name="AlarmLeadTime" type="ser:duration" />
              <xs:element minOccurs="0" name="HasAlarm" type="xs:boolean" />
              <xs:element minOccurs="0" name="ColorIndex" type="xs:short" />
              <xs:element minOccurs="0" name="IsFree" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsAlldayEvent" type="xs:boolean" />
              <xs:element minOccurs="0" name="LagTime" type="ser:duration" />
              <xs:element minOccurs="0" name="LeadTime" type="ser:duration" />
              <xs:element minOccurs="0" name="Location" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RejectCounter" type="xs:short" />
              <xs:element minOccurs="0" name="RejectReason" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Recurrence" nillable="true" type="q6:RecurrenceInfo" />
              <xs:element minOccurs="0" name="Participants" nillable="true" type="q6:ArrayOfParticipantInfo" />
              <xs:element minOccurs="0" name="AssignmentStatus" type="q6:AssignmentStatus" />
              <xs:element minOccurs="0" name="InvitationStatus" type="q6:InvitationStatus" />
              <xs:element minOccurs="0" name="BookingType" type="q6:BookingType" />
              <xs:element minOccurs="0" name="ActiveDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="HasConflict" type="xs:boolean" />
              <xs:element minOccurs="0" name="AssignedBy" nillable="true" type="q6:Associate" />
              <xs:element minOccurs="0" name="MotherAssociate" nillable="true" type="q6:Associate" />
              <xs:element minOccurs="0" name="Task" nillable="true" type="q6:TaskListItem" />
              <xs:element minOccurs="0" name="PreferredTZLocation" type="xs:int" />
              <xs:element minOccurs="0" name="Sale" nillable="true" type="q6:Sale" />
              <xs:element minOccurs="0" name="SuggestedAppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="IsMileStone" type="xs:boolean" />
              <xs:element minOccurs="0" name="UserDefinedFields" nillable="true" type="q6:StringDictionary" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="q6:StringDictionary" />
              <xs:element minOccurs="0" name="PublishEventDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishTo" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishFrom" type="xs:dateTime" />
              <xs:element minOccurs="0" name="IsPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="VisibleFor" nillable="true" type="q6:ArrayOfVisibleFor" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AppointmentEntity" nillable="true" type="q7:AppointmentEntity" xmlns:q7="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Carrier">
        <xs:sequence>
          <xs:element minOccurs="0" name="TableRight" nillable="true" type="q8:TableRight" xmlns:q8="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          <xs:element minOccurs="0" name="FieldProperties" nillable="true" type="q9:FieldPropertyDictionary" xmlns:q9="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="Carrier" nillable="true" type="q10:Carrier" xmlns:q10="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="TableRight">
        <xs:sequence>
          <xs:element minOccurs="0" name="Mask" type="q11:ETableRight" xmlns:q11="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TableRight" nillable="true" type="q12:TableRight" xmlns:q12="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="ETableRight" nillable="true" type="q13:ETableRight" xmlns:q13="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
                <xs:element name="Value" nillable="true" type="q14:FieldProperty" xmlns:q14="http://www.superoffice.net/ws/crm/NetServer/Services81" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldPropertyDictionary" nillable="true" type="q15:FieldPropertyDictionary" xmlns:q15="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="FieldProperty">
        <xs:sequence>
          <xs:element minOccurs="0" name="FieldRight" nillable="true" type="q16:FieldRight" xmlns:q16="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          <xs:element minOccurs="0" name="FieldType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FieldLength" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldProperty" nillable="true" type="q17:FieldProperty" xmlns:q17="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="FieldRight">
        <xs:sequence>
          <xs:element minOccurs="0" name="Mask" type="q18:EFieldRight" xmlns:q18="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldRight" nillable="true" type="q19:FieldRight" xmlns:q19="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="EFieldRight" nillable="true" type="q20:EFieldRight" xmlns:q20="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Associate">
        <xs:complexContent mixed="false">
          <xs:extension base="q21:Carrier" xmlns:q21="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Associate" nillable="true" type="q22:Associate" xmlns:q22="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="UserType" nillable="true" type="q23:UserType" xmlns:q23="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Contact">
        <xs:complexContent mixed="false">
          <xs:extension base="q24:Carrier" xmlns:q24="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
              <xs:element minOccurs="0" name="Address" nillable="true" type="q24:Address" />
              <xs:element minOccurs="0" name="FormattedAddress" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsOwnerContact" type="xs:boolean" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Contact" nillable="true" type="q25:Contact" xmlns:q25="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Address">
        <xs:complexContent mixed="false">
          <xs:extension base="q26:Carrier" xmlns:q26="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="Wgs84Latitude" type="xs:double" />
              <xs:element minOccurs="0" name="Wgs84Longitude" type="xs:double" />
              <xs:element minOccurs="0" name="LocalizedAddress" nillable="true" type="q26:ArrayOfArrayOfLocalizedField" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Address" nillable="true" type="q27:Address" xmlns:q27="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ArrayOfArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArrayOfLocalizedField" nillable="true" type="q28:ArrayOfLocalizedField" xmlns:q28="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArrayOfLocalizedField" nillable="true" type="q29:ArrayOfArrayOfLocalizedField" xmlns:q29="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="LocalizedField" nillable="true" type="q30:LocalizedField" xmlns:q30="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLocalizedField" nillable="true" type="q31:ArrayOfLocalizedField" xmlns:q31="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="LocalizedField">
        <xs:complexContent mixed="false">
          <xs:extension base="q32:Carrier" xmlns:q32="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
      <xs:element name="LocalizedField" nillable="true" type="q33:LocalizedField" xmlns:q33="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Person">
        <xs:complexContent mixed="false">
          <xs:extension base="q34:Carrier" xmlns:q34="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
      <xs:element name="Person" nillable="true" type="q35:Person" xmlns:q35="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Priority">
        <xs:complexContent mixed="false">
          <xs:extension base="q36:Carrier" xmlns:q36="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Priority" nillable="true" type="q37:Priority" xmlns:q37="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="AppointmentPrivate">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Public" />
          <xs:enumeration value="PrivateUser" />
          <xs:enumeration value="PrivateGroup" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="AppointmentPrivate" nillable="true" type="q38:AppointmentPrivate" xmlns:q38="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Project">
        <xs:complexContent mixed="false">
          <xs:extension base="q39:Carrier" xmlns:q39="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
      <xs:element name="Project" nillable="true" type="q40:Project" xmlns:q40="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="AppointmentType" nillable="true" type="q41:AppointmentType" xmlns:q41="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="ActivityStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="NotStarted" />
          <xs:enumeration value="Started" />
          <xs:enumeration value="Completed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ActivityStatus" nillable="true" type="q42:ActivityStatus" xmlns:q42="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ArrayOfLink">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Link" nillable="true" type="q43:Link" xmlns:q43="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLink" nillable="true" type="q44:ArrayOfLink" xmlns:q44="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Link">
        <xs:complexContent mixed="false">
          <xs:extension base="q45:Carrier" xmlns:q45="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
      <xs:element name="Link" nillable="true" type="q46:Link" xmlns:q46="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="RecurrenceInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="RecurrenceId" type="xs:int" />
          <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="RecurrenceEndType" type="q47:RecurrenceEndType" xmlns:q47="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          <xs:element minOccurs="0" name="Pattern" type="q48:RecurrencePattern" xmlns:q48="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          <xs:element minOccurs="0" name="DayPattern" nillable="true" type="q49:RecurrenceDayPattern" xmlns:q49="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          <xs:element minOccurs="0" name="WeekPattern" nillable="true" type="q50:RecurrenceWeekPattern" xmlns:q50="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          <xs:element minOccurs="0" name="MonthPattern" nillable="true" type="q51:RecurrenceMonthPattern" xmlns:q51="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          <xs:element minOccurs="0" name="YearPattern" nillable="true" type="q52:RecurrenceYearPattern" xmlns:q52="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          <xs:element minOccurs="0" name="Dates" nillable="true" type="q53:ArrayOfRecurrenceDate" xmlns:q53="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          <xs:element minOccurs="0" name="RecurrenceCounter" type="xs:int" />
          <xs:element minOccurs="0" name="IsRecurrence" type="xs:boolean" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceInfo" nillable="true" type="q54:RecurrenceInfo" xmlns:q54="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="RecurrenceEndType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="EndDate" />
          <xs:enumeration value="Counter" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrenceEndType" nillable="true" type="q55:RecurrenceEndType" xmlns:q55="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="RecurrencePattern">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Daily" />
          <xs:enumeration value="Weekly" />
          <xs:enumeration value="Monthly" />
          <xs:enumeration value="Yearly" />
          <xs:enumeration value="Custom" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrencePattern" nillable="true" type="q56:RecurrencePattern" xmlns:q56="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="RecurrenceDayPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Pattern" type="q57:RecurrenceDailyPattern" xmlns:q57="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceDayPattern" nillable="true" type="q58:RecurrenceDayPattern" xmlns:q58="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="RecurrenceDailyPattern">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="EveryWorkday" />
          <xs:enumeration value="EveryWeekday" />
          <xs:enumeration value="EveryCyclicDay" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrenceDailyPattern" nillable="true" type="q59:RecurrenceDailyPattern" xmlns:q59="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="RecurrenceWeekPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Weekdays" type="q60:Weekday" xmlns:q60="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceWeekPattern" nillable="true" type="q61:RecurrenceWeekPattern" xmlns:q61="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="Weekday">
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="Monday" />
              <xs:enumeration value="Tuesday" />
              <xs:enumeration value="Wednesday" />
              <xs:enumeration value="Thursday" />
              <xs:enumeration value="Friday" />
              <xs:enumeration value="Saturday" />
              <xs:enumeration value="Sunday" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="Weekday" nillable="true" type="q62:Weekday" xmlns:q62="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="RecurrenceMonthPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Day" type="xs:int" />
          <xs:element minOccurs="0" name="Weekday" type="q63:Weekday" xmlns:q63="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          <xs:element minOccurs="0" name="WeekOfMonth" type="q64:WeekOfMonth" xmlns:q64="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          <xs:element minOccurs="0" name="Pattern" type="q65:RecurrenceMonthlyPattern" xmlns:q65="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceMonthPattern" nillable="true" type="q66:RecurrenceMonthPattern" xmlns:q66="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="WeekOfMonth">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="First" />
          <xs:enumeration value="Second" />
          <xs:enumeration value="Third" />
          <xs:enumeration value="Fourth" />
          <xs:enumeration value="Last" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="WeekOfMonth" nillable="true" type="q67:WeekOfMonth" xmlns:q67="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="RecurrenceMonthlyPattern">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="DayOfMonth">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">4</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="WeekdayOfMonth">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">5</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrenceMonthlyPattern" nillable="true" type="q68:RecurrenceMonthlyPattern" xmlns:q68="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="RecurrenceYearPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Day" type="xs:int" />
          <xs:element minOccurs="0" name="Weekday" type="q69:Weekday" xmlns:q69="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          <xs:element minOccurs="0" name="WeekOfMonth" type="q70:WeekOfMonth" xmlns:q70="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          <xs:element minOccurs="0" name="Pattern" type="q71:RecurrenceYearlyPattern" xmlns:q71="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceYearPattern" nillable="true" type="q72:RecurrenceYearPattern" xmlns:q72="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="RecurrenceYearlyPattern">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="DayOfMonth">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">6</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="WeekdayOfMonth">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">7</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrenceYearlyPattern" nillable="true" type="q73:RecurrenceYearlyPattern" xmlns:q73="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ArrayOfRecurrenceDate">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="RecurrenceDate" nillable="true" type="q74:RecurrenceDate" xmlns:q74="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfRecurrenceDate" nillable="true" type="q75:ArrayOfRecurrenceDate" xmlns:q75="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="RecurrenceDate">
        <xs:sequence>
          <xs:element minOccurs="0" name="Date" type="xs:dateTime" />
          <xs:element minOccurs="0" name="IsConflict" type="xs:boolean" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DescriptionStyleHint" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceDate" nillable="true" type="q76:RecurrenceDate" xmlns:q76="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ArrayOfParticipantInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ParticipantInfo" nillable="true" type="q77:ParticipantInfo" xmlns:q77="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfParticipantInfo" nillable="true" type="q78:ArrayOfParticipantInfo" xmlns:q78="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ParticipantInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          <xs:element minOccurs="0" name="EmailId" type="xs:int" />
          <xs:element minOccurs="0" name="SendEmail" type="xs:boolean" />
          <xs:element minOccurs="0" name="InvitationStatus" type="q79:InvitationStatus" xmlns:q79="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ParticipantInfo" nillable="true" type="q80:ParticipantInfo" xmlns:q80="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="InvitationStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="None" />
          <xs:enumeration value="Accepted" />
          <xs:enumeration value="Hidden">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">4</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Invitation">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">5</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Moved">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">6</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Seen">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">7</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="MovedSeen">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">8</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Declined">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">9</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Cancelled">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">10</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="InvitationStatus" nillable="true" type="q81:InvitationStatus" xmlns:q81="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="AssignmentStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="None" />
          <xs:enumeration value="Assigning">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">11</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Seen">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">12</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Declined">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">13</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="AssignmentStatus" nillable="true" type="q82:AssignmentStatus" xmlns:q82="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="BookingType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="None" />
          <xs:enumeration value="Owner" />
          <xs:enumeration value="Participant" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="BookingType" nillable="true" type="q83:BookingType" xmlns:q83="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="TaskListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q84:Carrier" xmlns:q84="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="TaskListItemId" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Direction" type="q84:TaskDirection" />
              <xs:element minOccurs="0" name="Type" type="q84:TaskType" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="IntentId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="IsDefaultAlldayEvent" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsDefaultFree" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsDefaultPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="ColorIndex" type="q84:ColorIndex" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TaskListItem" nillable="true" type="q85:TaskListItem" xmlns:q85="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="TaskDirection">
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
      <xs:element name="TaskDirection" nillable="true" type="q86:TaskDirection" xmlns:q86="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="TaskType">
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
          <xs:enumeration value="ToDo" />
          <xs:enumeration value="MailMergeDraft" />
          <xs:enumeration value="MailMergeFinal" />
          <xs:enumeration value="Report" />
          <xs:enumeration value="SaintAll" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TaskType" nillable="true" type="q87:TaskType" xmlns:q87="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="ColorIndex">
        <xs:restriction base="xs:string">
          <xs:enumeration value="LightBlue" />
          <xs:enumeration value="DarkBlue" />
          <xs:enumeration value="LightGray" />
          <xs:enumeration value="DarkGray" />
          <xs:enumeration value="LightGreen" />
          <xs:enumeration value="DarkGreen" />
          <xs:enumeration value="LightYellow" />
          <xs:enumeration value="DarkYellow" />
          <xs:enumeration value="LightRed" />
          <xs:enumeration value="DarkRed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ColorIndex" nillable="true" type="q88:ColorIndex" xmlns:q88="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Sale">
        <xs:complexContent mixed="false">
          <xs:extension base="q89:Carrier" xmlns:q89="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
              <xs:element minOccurs="0" name="Status" type="q89:SaleStatus" />
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
              <xs:element minOccurs="0" name="Completed" type="q89:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="NextDueDate" type="xs:dateTime" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Sale" nillable="true" type="q90:Sale" xmlns:q90="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="SaleStatus" nillable="true" type="q91:SaleStatus" xmlns:q91="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="StringDictionary" nillable="true" type="q92:StringDictionary" xmlns:q92="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ArrayOfVisibleFor">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="VisibleFor" nillable="true" type="q93:VisibleFor" xmlns:q93="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfVisibleFor" nillable="true" type="q94:ArrayOfVisibleFor" xmlns:q94="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="VisibleFor">
        <xs:complexContent mixed="false">
          <xs:extension base="q95:Carrier" xmlns:q95="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="VisibleId" type="xs:int" />
              <xs:element minOccurs="0" name="Visibility" type="q95:Visibility" />
              <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="VisibleFor" nillable="true" type="q96:VisibleFor" xmlns:q96="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="Visibility">
        <xs:restriction base="xs:string">
          <xs:enumeration value="All" />
          <xs:enumeration value="Associate" />
          <xs:enumeration value="Group" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="Visibility" nillable="true" type="q97:Visibility" xmlns:q97="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="SoExceptionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="StackTrace" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FriendlyText" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ExceptionType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="InnerException" nillable="true" type="q98:SoExceptionInfo" xmlns:q98="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          <xs:element minOccurs="0" name="Parameters" nillable="true" type="q99:SoExceptionInfoParameters" xmlns:q99="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExceptionInfo" nillable="true" type="q100:SoExceptionInfo" xmlns:q100="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="SoExceptionInfoParameters" nillable="true" type="q101:SoExceptionInfoParameters" xmlns:q101="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="ExceptionInfo" nillable="true" type="q102:SoExceptionInfo" xmlns:q102="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="SoExtraInfo" nillable="true" type="q103:SoExtraInfo" xmlns:q103="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="ExtraInfo" nillable="true" type="q104:SoExtraInfo" xmlns:q104="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="Succeeded" type="xs:boolean" />
      <xs:element name="SaveAppointmentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentEntity" nillable="true" type="q105:AppointmentEntity" xmlns:q105="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveAppointmentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q106:AppointmentEntity" xmlns:q106="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteAppointmentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteAppointmentEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultSuggestedAppointmentEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultSuggestedAppointmentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q107:SuggestedAppointmentEntity" xmlns:q107="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SuggestedAppointmentEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q108:Carrier" xmlns:q108="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="SuggestedAppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="DaysFuture" type="xs:short" />
              <xs:element minOccurs="0" name="Duration" type="ser:duration" />
              <xs:element minOccurs="0" name="AutoSuggest" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsMilestone" type="xs:boolean" />
              <xs:element minOccurs="0" name="AssignToMember" type="xs:boolean" />
              <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjectTypeStatusLink" nillable="true" type="q108:ProjectTypeStatusLink" />
              <xs:element minOccurs="0" name="SaleTypeStageLink" nillable="true" type="q108:SaleTypeStageLink" />
              <xs:element minOccurs="0" name="Type" nillable="true" type="q108:Task" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SuggestedAppointmentEntity" nillable="true" type="q109:SuggestedAppointmentEntity" xmlns:q109="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ProjectTypeStatusLink">
        <xs:complexContent mixed="false">
          <xs:extension base="q110:Carrier" xmlns:q110="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
      <xs:element name="ProjectTypeStatusLink" nillable="true" type="q111:ProjectTypeStatusLink" xmlns:q111="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="SaleTypeStageLink">
        <xs:complexContent mixed="false">
          <xs:extension base="q112:Carrier" xmlns:q112="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
      <xs:element name="SaleTypeStageLink" nillable="true" type="q113:SaleTypeStageLink" xmlns:q113="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Task">
        <xs:complexContent mixed="false">
          <xs:extension base="q114:Carrier" xmlns:q114="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Task" nillable="true" type="q115:Task" xmlns:q115="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="SaveSuggestedAppointmentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SuggestedAppointmentEntity" nillable="true" type="q116:SuggestedAppointmentEntity" xmlns:q116="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveSuggestedAppointmentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q117:SuggestedAppointmentEntity" xmlns:q117="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTaskListItem">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTaskListItemResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q118:TaskListItem" xmlns:q118="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTaskListItem">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TaskListItem" nillable="true" type="q119:TaskListItem" xmlns:q119="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTaskListItemResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q120:TaskListItem" xmlns:q120="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q121:Appointment" xmlns:q121="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Appointment">
        <xs:complexContent mixed="false">
          <xs:extension base="q122:Carrier" xmlns:q122="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Type" type="q122:AppointmentType" />
              <xs:element minOccurs="0" name="Task" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjectName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="ColorIndex" type="xs:short" />
              <xs:element minOccurs="0" name="IsFree" type="xs:boolean" />
              <xs:element minOccurs="0" name="HasAlarm" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsAlldayEvent" type="xs:boolean" />
              <xs:element minOccurs="0" name="Private" type="q122:AppointmentPrivate" />
              <xs:element minOccurs="0" name="PriorityId" type="xs:int" />
              <xs:element minOccurs="0" name="PriorityName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TaskType" type="q122:TaskType" />
              <xs:element minOccurs="0" name="IsBookingMain" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsRecurrence" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsBooking" type="xs:boolean" />
              <xs:element minOccurs="0" name="ActiveDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AssignmentStatus" type="q122:AssignmentStatus" />
              <xs:element minOccurs="0" name="InvitationStatus" type="q122:InvitationStatus" />
              <xs:element minOccurs="0" name="BookingType" type="q122:BookingType" />
              <xs:element minOccurs="0" name="Completed" type="q122:ActivityStatus" />
              <xs:element minOccurs="0" name="RecurringPattern" type="q122:RecurrencePattern" />
              <xs:element minOccurs="0" name="RecurringStartDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RecurringEndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="MotherId" type="xs:int" />
              <xs:element minOccurs="0" name="AssignedBy" type="xs:int" />
              <xs:element minOccurs="0" name="AssignedByFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RejectReason" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Location" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AlarmLeadTime" type="ser:duration" />
              <xs:element minOccurs="0" name="SaleId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CreatedByFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CreatedByAssociateId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Appointment" nillable="true" type="q123:Appointment" xmlns:q123="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="ToggleAppointmentStatus">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleAppointmentStatusResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="q124:AppointmentStatus" xmlns:q124="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="AppointmentStatus">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="UnknownOrPostIt" />
          <xs:enumeration value="NotStarted" />
          <xs:enumeration value="Started" />
          <xs:enumeration value="Completed" />
          <xs:enumeration value="Hidden" />
          <xs:enumeration value="Booking" />
          <xs:enumeration value="BookingMoved" />
          <xs:enumeration value="BookingSeen" />
          <xs:enumeration value="BookingMovedSeen" />
          <xs:enumeration value="BookingDeclined" />
          <xs:enumeration value="BookingDeleted" />
          <xs:enumeration value="Assignment" />
          <xs:enumeration value="AssignmentSeen" />
          <xs:enumeration value="AssignmentDeclined" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="AppointmentStatus" nillable="true" type="q125:AppointmentStatus" xmlns:q125="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="ToggleActivity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ActivityIdentifier" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleActivityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="q126:ActivityStatus" xmlns:q126="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleActivities">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ActivityIdentifier" nillable="true" type="q127:ArrayOfstring" xmlns:q127="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleActivitiesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="q128:ActivityStatus" xmlns:q128="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetActivityStatus">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ActivityIdentifier" nillable="true" type="q129:ArrayOfstring" xmlns:q129="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="ActivityStatus" type="q130:ActivityStatus" xmlns:q130="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetActivityStatusResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleAndSetActivities">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ActivityIdentifiers" nillable="true" type="q131:ArrayOfstring" xmlns:q131="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleAndSetActivitiesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q132:ArrayOfstring" xmlns:q132="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMySyncAppointments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMySyncAppointmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q133:ArrayOfAppointmentSyncData" xmlns:q133="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfAppointmentSyncData">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="AppointmentSyncData" nillable="true" type="q134:AppointmentSyncData" xmlns:q134="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfAppointmentSyncData" nillable="true" type="q135:ArrayOfAppointmentSyncData" xmlns:q135="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="AppointmentSyncData">
        <xs:complexContent mixed="false">
          <xs:extension base="q136:Carrier" xmlns:q136="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="AlarmTime" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="AppointmentText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactDepartment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="HasAlarm" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsAllDay" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsAssignment" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsBusy" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsCompleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsInvitation" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsTentative" type="xs:boolean" />
              <xs:element minOccurs="0" name="Location" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Participants" nillable="true" type="q136:ArrayOfParticipantSyncData" />
              <xs:element minOccurs="0" name="PersonFormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjectName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SaleId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="TaskName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AppointmentSyncData" nillable="true" type="q137:AppointmentSyncData" xmlns:q137="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ArrayOfParticipantSyncData">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ParticipantSyncData" nillable="true" type="q138:ParticipantSyncData" xmlns:q138="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfParticipantSyncData" nillable="true" type="q139:ArrayOfParticipantSyncData" xmlns:q139="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ParticipantSyncData">
        <xs:complexContent mixed="false">
          <xs:extension base="q140:Carrier" xmlns:q140="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonFirstName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonMiddleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonLastname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonMrmrs" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonTitle" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonPosition" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonAcademicTitle" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonFormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactDepartment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactBusiness" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactCountry" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactCategory" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EMail" nillable="true" type="q141:ArrayOfstring" xmlns:q141="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="PhonePrivate" nillable="true" type="q142:ArrayOfstring" xmlns:q142="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="PhoneFax" nillable="true" type="q143:ArrayOfstring" xmlns:q143="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="PhoneMobile" nillable="true" type="q144:ArrayOfstring" xmlns:q144="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="PhoneDirect" nillable="true" type="q145:ArrayOfstring" xmlns:q145="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="PhoneContact" nillable="true" type="q146:ArrayOfstring" xmlns:q146="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="Messenger" nillable="true" type="q147:ArrayOfstring" xmlns:q147="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="Voip" nillable="true" type="q148:ArrayOfstring" xmlns:q148="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="ContactUrl" nillable="true" type="q149:ArrayOfstring" xmlns:q149="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="Url" nillable="true" type="q150:ArrayOfstring" xmlns:q150="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="StreetAddress" nillable="true" type="q140:AddressSyncData" />
              <xs:element minOccurs="0" name="PostalAddress" nillable="true" type="q140:AddressSyncData" />
              <xs:element minOccurs="0" name="Country" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonAddress" nillable="true" type="q140:AddressSyncData" />
              <xs:element minOccurs="0" name="PersonCountry" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ParticipantStatus" type="q140:AppointmentStatus" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ParticipantSyncData" nillable="true" type="q151:ParticipantSyncData" xmlns:q151="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="AddressSyncData">
        <xs:complexContent mixed="false">
          <xs:extension base="q152:Carrier" xmlns:q152="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="AddressId" type="xs:int" />
              <xs:element minOccurs="0" name="AddressType" type="q152:AddressType" />
              <xs:element minOccurs="0" name="Address1" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Address2" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Address3" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="City" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="County" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ZipCode" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="State" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Latitude" type="xs:double" />
              <xs:element minOccurs="0" name="Longitude" type="xs:double" />
              <xs:element minOccurs="0" name="FormattedAddress" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AddressSyncData" nillable="true" type="q153:AddressSyncData" xmlns:q153="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="AddressType" nillable="true" type="q154:AddressType" xmlns:q154="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="GetAppointmentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q155:AppointmentEntity" xmlns:q155="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAppointmentEntityByType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Type" type="q156:TaskType" xmlns:q156="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAppointmentEntityByTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q157:AppointmentEntity" xmlns:q157="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Accept">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="UpdateMode" type="q158:RecurrenceUpdateMode" xmlns:q158="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="RecurrenceUpdateMode">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="OnlyThis" />
          <xs:enumeration value="ThisAndForward" />
          <xs:enumeration value="StopRecurrence">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">9</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrenceUpdateMode" nillable="true" type="q159:RecurrenceUpdateMode" xmlns:q159="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="AcceptResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="Reject">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="RejectReason" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="UpdateMode" type="q160:RecurrenceUpdateMode" xmlns:q160="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RejectResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="Save">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentEntity" nillable="true" type="q161:AppointmentEntity" xmlns:q161="http://www.superoffice.net/ws/crm/NetServer/Services81" />
            <xs:element minOccurs="0" name="UpdateMode" type="q162:RecurrenceUpdateMode" xmlns:q162="http://www.superoffice.net/ws/crm/NetServer/Services81" />
            <xs:element minOccurs="0" name="SendEmailToParticipants" type="xs:boolean" />
            <xs:element minOccurs="0" name="SmtpEMailConnectionInfo" nillable="true" type="q163:EMailConnectionInfo" xmlns:q163="http://www.superoffice.net/ws/crm/NetServer/Services81" />
            <xs:element minOccurs="0" name="ImapEMailConnectionInfo" nillable="true" type="q164:EMailConnectionInfo" xmlns:q164="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="EMailConnectionInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="q165:Carrier" xmlns:q165="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="ServerName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Password" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Folder" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UseSSL" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EMailConnectionInfo" nillable="true" type="q166:EMailConnectionInfo" xmlns:q166="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="SaveResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q167:AppointmentEntity" xmlns:q167="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Delete">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="UpdateMode" type="q168:RecurrenceUpdateMode" xmlns:q168="http://www.superoffice.net/ws/crm/NetServer/Services81" />
            <xs:element minOccurs="0" name="SendEmailToParticipants" type="xs:boolean" />
            <xs:element minOccurs="0" name="SmtpEMailConnectionInfo" nillable="true" type="q169:EMailConnectionInfo" xmlns:q169="http://www.superoffice.net/ws/crm/NetServer/Services81" />
            <xs:element minOccurs="0" name="ImapEMailConnectionInfo" nillable="true" type="q170:EMailConnectionInfo" xmlns:q170="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CalculateDays">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentEntity" nillable="true" type="q171:AppointmentEntity" xmlns:q171="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CalculateDaysResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q172:RecurrenceInfo" xmlns:q172="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateDays">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentEntity" nillable="true" type="q173:AppointmentEntity" xmlns:q173="http://www.superoffice.net/ws/crm/NetServer/Services81" />
            <xs:element minOccurs="0" name="Dates" nillable="true" type="q174:ArrayOfdateTime" xmlns:q174="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateDaysResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q175:ArrayOfRecurrenceDate" xmlns:q175="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultRecurrence">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultRecurrenceResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q176:RecurrenceInfo" xmlns:q176="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AssignTo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="Participant" nillable="true" type="q177:ParticipantInfo" xmlns:q177="http://www.superoffice.net/ws/crm/NetServer/Services81" />
            <xs:element minOccurs="0" name="UpdateMode" type="q178:RecurrenceUpdateMode" xmlns:q178="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AssignToResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q179:AppointmentEntity" xmlns:q179="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetSeen">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="UpdateMode" type="q180:RecurrenceUpdateMode" xmlns:q180="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetSeenResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="Move">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="NewStartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="UpdateMode" type="q181:RecurrenceUpdateMode" xmlns:q181="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MoveResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q182:AppointmentEntity" xmlns:q182="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AcceptRejected">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="UpdateMode" type="q183:RecurrenceUpdateMode" xmlns:q183="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AcceptRejectedResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q184:AppointmentEntity" xmlns:q184="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultRecurrenceByDate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultRecurrenceByDateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q185:RecurrenceInfo" xmlns:q185="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CleanUpBookingDeleted">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentIds" nillable="true" type="q186:ArrayOfint" xmlns:q186="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CleanUpBookingDeletedResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAppointmentEntityByTypeAndAssociate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Type" type="q187:TaskType" xmlns:q187="http://www.superoffice.net/ws/crm/NetServer/Services81" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAppointmentEntityByTypeAndAssociateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q188:AppointmentEntity" xmlns:q188="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCanInsertForAssociates">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateIds" nillable="true" type="q189:ArrayOfint" xmlns:q189="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCanInsertForAssociatesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q190:ArrayOfboolean" xmlns:q190="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentHaveParticipantsWithEmail">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentHaveParticipantsWithEmailResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAppointmentEntityFromSaleSuggestion">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SuggestedAppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="CreateNow" type="xs:boolean" />
            <xs:element minOccurs="0" name="OwnerId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAppointmentEntityFromSaleSuggestionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q191:AppointmentEntity" xmlns:q191="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNextSuggestedAppointmentBySale">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="CurrentAppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="SkipCompleteCheck" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNextSuggestedAppointmentBySaleResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q192:SuggestedAppointment" xmlns:q192="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SuggestedAppointment">
        <xs:complexContent mixed="false">
          <xs:extension base="q193:Carrier" xmlns:q193="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="AutoSuggest" type="xs:short" />
              <xs:element minOccurs="0" name="Deleted" type="xs:short" />
              <xs:element minOccurs="0" name="DaysFuture" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TaskId" type="xs:int" />
              <xs:element minOccurs="0" name="SuggestedAppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleTypeStageLinkId" type="xs:int" />
              <xs:element minOccurs="0" name="RegisteredAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="ProjectTypeStatusLinkId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Duration" type="xs:short" />
              <xs:element minOccurs="0" name="Associate" nillable="true" type="q193:Associate" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SuggestedAppointment" nillable="true" type="q194:SuggestedAppointment" xmlns:q194="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="CreateDefaultReOpenAppointment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultReOpenAppointmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q195:AppointmentEntity" xmlns:q195="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAppointmentEntityFromProjectSuggestion">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SuggestedAppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="CreateNow" type="xs:boolean" />
            <xs:element minOccurs="0" name="OwnerId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAppointmentEntityFromProjectSuggestionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q196:AppointmentEntity" xmlns:q196="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CanAssignToProjectMember">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="SuggestedAppointmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CanAssignToProjectMemberResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentIds" nillable="true" type="q197:ArrayOfint" xmlns:q197="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q198:ArrayOfAppointment" xmlns:q198="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfAppointment">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Appointment" nillable="true" type="q199:Appointment" xmlns:q199="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfAppointment" nillable="true" type="q200:ArrayOfAppointment" xmlns:q200="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="GetMyAppointments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyAppointmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q201:ArrayOfAppointment" xmlns:q201="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeProjectAppointments" type="xs:boolean" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q202:ArrayOfAppointment" xmlns:q202="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyDiary">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyDiaryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q203:ArrayOfAppointment" xmlns:q203="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyTasks">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyTasksResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q204:ArrayOfAppointment" xmlns:q204="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonDiary">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonDiaryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q205:ArrayOfAppointment" xmlns:q205="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonTasks">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonTasksResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q206:ArrayOfAppointment" xmlns:q206="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointmentsByType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeProjectAppointments" type="xs:boolean" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="AppointmentType" type="q207:AppointmentType" xmlns:q207="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointmentsByTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q208:ArrayOfAppointment" xmlns:q208="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q209:ArrayOfAppointment" xmlns:q209="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointmentsByType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="AppointmentType" type="q210:AppointmentType" xmlns:q210="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointmentsByTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q211:ArrayOfAppointment" xmlns:q211="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q212:ArrayOfAppointment" xmlns:q212="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointmentsByType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="AppointmentType" type="q213:AppointmentType" xmlns:q213="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointmentsByTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q214:ArrayOfAppointment" xmlns:q214="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q215:ArrayOfAppointment" xmlns:q215="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointmentsByType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="AppointmentType" type="q216:AppointmentType" xmlns:q216="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointmentsByTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q217:ArrayOfAppointment" xmlns:q217="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointmentsByTask">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeProjectAppointments" type="xs:boolean" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointmentsByTaskResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q218:ArrayOfAppointment" xmlns:q218="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointmentsByTasks">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeProjectAppointments" type="xs:boolean" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskIds" nillable="true" type="q219:ArrayOfint" xmlns:q219="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointmentsByTasksResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q220:ArrayOfAppointment" xmlns:q220="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointmentsByTaskHeading">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeProjectAppointments" type="xs:boolean" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskHeadingId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointmentsByTaskHeadingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q221:ArrayOfAppointment" xmlns:q221="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointmentsByTask">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointmentsByTaskResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q222:ArrayOfAppointment" xmlns:q222="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointmentsByTasks">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskIds" nillable="true" type="q223:ArrayOfint" xmlns:q223="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointmentsByTasksResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q224:ArrayOfAppointment" xmlns:q224="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointmentsByTaskHeading">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskHeadingId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointmentsByTaskHeadingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q225:ArrayOfAppointment" xmlns:q225="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointmentsByTask">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointmentsByTaskResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q226:ArrayOfAppointment" xmlns:q226="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointmentsByTasks">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskIds" nillable="true" type="q227:ArrayOfint" xmlns:q227="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointmentsByTasksResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q228:ArrayOfAppointment" xmlns:q228="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointmentsByTaskHeading">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskHeadingId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointmentsByTaskHeadingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q229:ArrayOfAppointment" xmlns:q229="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointmentsByTask">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointmentsByTaskResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q230:ArrayOfAppointment" xmlns:q230="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointmentsByTasks">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskIds" nillable="true" type="q231:ArrayOfint" xmlns:q231="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointmentsByTasksResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q232:ArrayOfAppointment" xmlns:q232="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointmentsByTaskHeading">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskHeadingId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointmentsByTaskHeadingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q233:ArrayOfAppointment" xmlns:q233="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedAppointment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedAppointmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q234:Appointment" xmlns:q234="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedAppointments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentIds" nillable="true" type="q235:ArrayOfint" xmlns:q235="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedAppointmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q236:ArrayOfAppointment" xmlns:q236="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyPublishedAppointments">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyPublishedAppointmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q237:ArrayOfAppointment" xmlns:q237="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedProjectAppointments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedProjectAppointmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q238:ArrayOfAppointment" xmlns:q238="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentsByTaskHeading">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TaskHeadingId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentsByTaskHeadingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q239:ArrayOfAppointment" xmlns:q239="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAssociateDiary">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAssociateDiaryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q240:ArrayOfAppointment" xmlns:q240="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDiaryByGroup">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="GroupId" type="xs:int" />
            <xs:element minOccurs="0" name="GroupType" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDiaryByGroupResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q241:ArrayOfAppointment" xmlns:q241="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateAppointment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Status" type="xs:int" />
            <xs:element minOccurs="0" name="Type" type="xs:int" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateAppointmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q242:Appointment" xmlns:q242="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAssociatesDiary">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateIds" nillable="true" type="q243:ArrayOfint" xmlns:q243="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAssociatesDiaryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q244:ArrayOfAppointment" xmlns:q244="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentRecords">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MotherId" type="xs:int" />
            <xs:element minOccurs="0" name="RecurrenceRuleId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentRecordsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q245:ArrayOfAppointment" xmlns:q245="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDayInformationListByDatesAndAssociate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDayInformationListByDatesAndAssociateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q246:ArrayOfDayInformationListItem" xmlns:q246="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDayInformationListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DayInformationListItem" nillable="true" type="q247:DayInformationListItem" xmlns:q247="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDayInformationListItem" nillable="true" type="q248:ArrayOfDayInformationListItem" xmlns:q248="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="DayInformationListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q249:Carrier" xmlns:q249="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="ActivityInformation" nillable="true" type="q249:ActivitySummary" />
              <xs:element minOccurs="0" name="RedLetterInformation" nillable="true" type="q249:RedLetterSummary" />
              <xs:element minOccurs="0" name="Date" type="xs:dateTime" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DayInformationListItem" nillable="true" type="q250:DayInformationListItem" xmlns:q250="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ActivitySummary">
        <xs:complexContent mixed="false">
          <xs:extension base="q251:Carrier" xmlns:q251="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="NumBusyActivities" type="xs:int" />
              <xs:element minOccurs="0" name="NumFreeActivities" type="xs:int" />
              <xs:element minOccurs="0" name="PercentageBusy" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ActivitySummary" nillable="true" type="q252:ActivitySummary" xmlns:q252="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="RedLetterSummary">
        <xs:complexContent mixed="false">
          <xs:extension base="q253:Carrier" xmlns:q253="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="IsOwnCountryHoliday" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsOtherCountryHoliday" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="RedLetterSummary" nillable="true" type="q254:RedLetterSummary" xmlns:q254="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="GetActivityInformationListByDatesAndAssociate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetActivityInformationListByDatesAndAssociateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q255:ArrayOfActivityInformationListItem" xmlns:q255="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfActivityInformationListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ActivityInformationListItem" nillable="true" type="q256:ActivityInformationListItem" xmlns:q256="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfActivityInformationListItem" nillable="true" type="q257:ArrayOfActivityInformationListItem" xmlns:q257="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ActivityInformationListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q258:Carrier" xmlns:q258="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="Date" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ActivityInformation" nillable="true" type="q258:ActivitySummary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ActivityInformationListItem" nillable="true" type="q259:ActivityInformationListItem" xmlns:q259="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="GetRedLetterInformationListByDatesAndAssociate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRedLetterInformationListByDatesAndAssociateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q260:ArrayOfRedLetterInformationListItem" xmlns:q260="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfRedLetterInformationListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="RedLetterInformationListItem" nillable="true" type="q261:RedLetterInformationListItem" xmlns:q261="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfRedLetterInformationListItem" nillable="true" type="q262:ArrayOfRedLetterInformationListItem" xmlns:q262="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="RedLetterInformationListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q263:Carrier" xmlns:q263="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="Date" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RedLetterInformation" nillable="true" type="q263:RedLetterSummary" />
              <xs:element minOccurs="0" name="RedLetterDetails" nillable="true" type="q263:RedLetterDetails" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="RedLetterInformationListItem" nillable="true" type="q264:RedLetterInformationListItem" xmlns:q264="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="RedLetterDetails">
        <xs:complexContent mixed="false">
          <xs:extension base="q265:Carrier" xmlns:q265="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="OwnCountryDayTexts" nillable="true" type="q266:ArrayOfstring" xmlns:q266="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="OtherCountryDayTexts" nillable="true" type="q267:ArrayOfstring" xmlns:q267="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="RedLetterDetails" nillable="true" type="q268:RedLetterDetails" xmlns:q268="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="GetAlarms">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="IncludeInvitations" type="xs:boolean" />
            <xs:element minOccurs="0" name="IncludeAllAppointments" type="xs:boolean" />
            <xs:element minOccurs="0" name="DefaultAlarmLeadTimeInMinutes" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAlarmsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q269:MultiAlarmData" xmlns:q269="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="MultiAlarmData">
        <xs:complexContent mixed="false">
          <xs:extension base="q270:Carrier" xmlns:q270="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="Alarms" nillable="true" type="q270:ArrayOfAlarmData" />
              <xs:element minOccurs="0" name="PollingInterval" type="xs:int" />
              <xs:element minOccurs="0" name="SilentAfter" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="MultiAlarmData" nillable="true" type="q271:MultiAlarmData" xmlns:q271="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ArrayOfAlarmData">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="AlarmData" nillable="true" type="q272:AlarmData" xmlns:q272="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfAlarmData" nillable="true" type="q273:ArrayOfAlarmData" xmlns:q273="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="AlarmData">
        <xs:complexContent mixed="false">
          <xs:extension base="q274:Carrier" xmlns:q274="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
              <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AlarmTime" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjectName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AppointmentText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SaleId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Location" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AppointmentType" type="q274:AppointmentType" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="AssignmentStatus" type="q274:AssignmentStatus" />
              <xs:element minOccurs="0" name="InvitationStatus" type="q274:InvitationStatus" />
              <xs:element minOccurs="0" name="BookingType" type="q274:BookingType" />
              <xs:element minOccurs="0" name="FormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TaskName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactDepartment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactFullName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AlarmData" nillable="true" type="q275:AlarmData" xmlns:q275="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="GenerateLead">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateIdForNewContact" type="xs:int" />
            <xs:element minOccurs="0" name="LeadDescription" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Relation" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="RelationId" type="xs:int" />
            <xs:element minOccurs="0" name="LeadContact" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="LeadPersonFirstname" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="LeadPersonLastname" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="LeadPersonEmail" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="LeadPhoneNumber" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="CreatorsContact" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="CreatorsFirstname" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="CreatorsLastname" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GenerateLeadResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q276:SalesActivity" xmlns:q276="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SalesActivity">
        <xs:complexContent mixed="false">
          <xs:extension base="q277:Carrier" xmlns:q277="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="RequestedContacts" nillable="true" type="q277:ArrayOfContact" />
              <xs:element minOccurs="0" name="RequestedPerson" nillable="true" type="q277:Person" />
              <xs:element minOccurs="0" name="SalesRep" nillable="true" type="q277:Person" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SalesActivity" nillable="true" type="q278:SalesActivity" xmlns:q278="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ArrayOfContact">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Contact" nillable="true" type="q279:Contact" xmlns:q279="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfContact" nillable="true" type="q280:ArrayOfContact" xmlns:q280="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="RequestForInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateIdForNewContact" type="xs:int" />
            <xs:element minOccurs="0" name="Channel" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Regarding" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PersonFirstname" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PersonLastname" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PhoneNumber" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RequestForInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q281:SalesActivity" xmlns:q281="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSuggestedAppointment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SuggestedAppointmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSuggestedAppointmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q282:SuggestedAppointment" xmlns:q282="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSuggestedAppointmentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SuggestedAppointmentEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSuggestedAppointmentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q283:SuggestedAppointmentEntity" xmlns:q283="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTaskListItem">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TaskListItemId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTaskListItemResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q284:TaskListItem" xmlns:q284="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTaskListItems">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="IncludeDeleted" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTaskListItemsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q285:ArrayOfTaskListItem" xmlns:q285="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfTaskListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TaskListItem" nillable="true" type="q286:TaskListItem" xmlns:q286="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTaskListItem" nillable="true" type="q287:ArrayOfTaskListItem" xmlns:q287="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:complexType name="ArrayOfdateTime">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="dateTime" type="xs:dateTime" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfdateTime" nillable="true" type="tns:ArrayOfdateTime" />
      <xs:complexType name="ArrayOfint">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="int" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfint" nillable="true" type="tns:ArrayOfint" />
      <xs:complexType name="ArrayOfboolean">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="boolean" type="xs:boolean" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfboolean" nillable="true" type="tns:ArrayOfboolean" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="CreateDefaultAppointmentEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveAppointmentEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveAppointmentEntity" />
  </wsdl:message>
  <wsdl:message name="SaveAppointmentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveAppointmentEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveAppointmentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveAppointmentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteAppointmentEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteAppointmentEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteAppointmentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteAppointmentEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteAppointmentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteAppointmentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSuggestedAppointmentEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultSuggestedAppointmentEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSuggestedAppointmentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSuggestedAppointmentEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultSuggestedAppointmentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSuggestedAppointmentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSuggestedAppointmentEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveSuggestedAppointmentEntity" />
  </wsdl:message>
  <wsdl:message name="SaveSuggestedAppointmentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSuggestedAppointmentEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveSuggestedAppointmentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveSuggestedAppointmentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTaskListItemRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTaskListItem" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTaskListItemRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTaskListItemResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTaskListItemResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTaskListItemResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTaskListItemRequest">
    <wsdl:part name="parameters" element="tns:SaveTaskListItem" />
  </wsdl:message>
  <wsdl:message name="SaveTaskListItemRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTaskListItemResponse">
    <wsdl:part name="parameters" element="tns:SaveTaskListItemResponse" />
  </wsdl:message>
  <wsdl:message name="SaveTaskListItemResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentRequest">
    <wsdl:part name="parameters" element="tns:GetAppointment" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentResponse">
    <wsdl:part name="parameters" element="tns:GetAppointmentResponse" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleAppointmentStatusRequest">
    <wsdl:part name="parameters" element="tns:ToggleAppointmentStatus" />
  </wsdl:message>
  <wsdl:message name="ToggleAppointmentStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleAppointmentStatusResponse">
    <wsdl:part name="parameters" element="tns:ToggleAppointmentStatusResponse" />
  </wsdl:message>
  <wsdl:message name="ToggleAppointmentStatusResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleActivityRequest">
    <wsdl:part name="parameters" element="tns:ToggleActivity" />
  </wsdl:message>
  <wsdl:message name="ToggleActivityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleActivityResponse">
    <wsdl:part name="parameters" element="tns:ToggleActivityResponse" />
  </wsdl:message>
  <wsdl:message name="ToggleActivityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleActivitiesRequest">
    <wsdl:part name="parameters" element="tns:ToggleActivities" />
  </wsdl:message>
  <wsdl:message name="ToggleActivitiesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleActivitiesResponse">
    <wsdl:part name="parameters" element="tns:ToggleActivitiesResponse" />
  </wsdl:message>
  <wsdl:message name="ToggleActivitiesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetActivityStatusRequest">
    <wsdl:part name="parameters" element="tns:SetActivityStatus" />
  </wsdl:message>
  <wsdl:message name="SetActivityStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetActivityStatusResponse">
    <wsdl:part name="parameters" element="tns:SetActivityStatusResponse" />
  </wsdl:message>
  <wsdl:message name="SetActivityStatusResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleAndSetActivitiesRequest">
    <wsdl:part name="parameters" element="tns:ToggleAndSetActivities" />
  </wsdl:message>
  <wsdl:message name="ToggleAndSetActivitiesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleAndSetActivitiesResponse">
    <wsdl:part name="parameters" element="tns:ToggleAndSetActivitiesResponse" />
  </wsdl:message>
  <wsdl:message name="ToggleAndSetActivitiesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMySyncAppointmentsRequest">
    <wsdl:part name="parameters" element="tns:GetMySyncAppointments" />
  </wsdl:message>
  <wsdl:message name="GetMySyncAppointmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMySyncAppointmentsResponse">
    <wsdl:part name="parameters" element="tns:GetMySyncAppointmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetMySyncAppointmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentEntityRequest">
    <wsdl:part name="parameters" element="tns:GetAppointmentEntity" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentEntityResponse">
    <wsdl:part name="parameters" element="tns:GetAppointmentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityByTypeRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntityByType" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityByTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityByTypeResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntityByTypeResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityByTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AcceptRequest">
    <wsdl:part name="parameters" element="tns:Accept" />
  </wsdl:message>
  <wsdl:message name="AcceptRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AcceptResponse">
    <wsdl:part name="parameters" element="tns:AcceptResponse" />
  </wsdl:message>
  <wsdl:message name="AcceptResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RejectRequest">
    <wsdl:part name="parameters" element="tns:Reject" />
  </wsdl:message>
  <wsdl:message name="RejectRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RejectResponse">
    <wsdl:part name="parameters" element="tns:RejectResponse" />
  </wsdl:message>
  <wsdl:message name="RejectResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRequest">
    <wsdl:part name="parameters" element="tns:Save" />
  </wsdl:message>
  <wsdl:message name="SaveRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveResponse">
    <wsdl:part name="parameters" element="tns:SaveResponse" />
  </wsdl:message>
  <wsdl:message name="SaveResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteRequest">
    <wsdl:part name="parameters" element="tns:Delete" />
  </wsdl:message>
  <wsdl:message name="DeleteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteResponse">
    <wsdl:part name="parameters" element="tns:DeleteResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CalculateDaysRequest">
    <wsdl:part name="parameters" element="tns:CalculateDays" />
  </wsdl:message>
  <wsdl:message name="CalculateDaysRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CalculateDaysResponse">
    <wsdl:part name="parameters" element="tns:CalculateDaysResponse" />
  </wsdl:message>
  <wsdl:message name="CalculateDaysResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateDaysRequest">
    <wsdl:part name="parameters" element="tns:ValidateDays" />
  </wsdl:message>
  <wsdl:message name="ValidateDaysRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateDaysResponse">
    <wsdl:part name="parameters" element="tns:ValidateDaysResponse" />
  </wsdl:message>
  <wsdl:message name="ValidateDaysResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRecurrenceRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultRecurrence" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRecurrenceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRecurrenceResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultRecurrenceResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRecurrenceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AssignToRequest">
    <wsdl:part name="parameters" element="tns:AssignTo" />
  </wsdl:message>
  <wsdl:message name="AssignToRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AssignToResponse">
    <wsdl:part name="parameters" element="tns:AssignToResponse" />
  </wsdl:message>
  <wsdl:message name="AssignToResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetSeenRequest">
    <wsdl:part name="parameters" element="tns:SetSeen" />
  </wsdl:message>
  <wsdl:message name="SetSeenRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetSeenResponse">
    <wsdl:part name="parameters" element="tns:SetSeenResponse" />
  </wsdl:message>
  <wsdl:message name="SetSeenResponse_Headers">
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
  <wsdl:message name="AcceptRejectedRequest">
    <wsdl:part name="parameters" element="tns:AcceptRejected" />
  </wsdl:message>
  <wsdl:message name="AcceptRejectedRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AcceptRejectedResponse">
    <wsdl:part name="parameters" element="tns:AcceptRejectedResponse" />
  </wsdl:message>
  <wsdl:message name="AcceptRejectedResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRecurrenceByDateRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultRecurrenceByDate" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRecurrenceByDateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRecurrenceByDateResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultRecurrenceByDateResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRecurrenceByDateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CleanUpBookingDeletedRequest">
    <wsdl:part name="parameters" element="tns:CleanUpBookingDeleted" />
  </wsdl:message>
  <wsdl:message name="CleanUpBookingDeletedRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CleanUpBookingDeletedResponse">
    <wsdl:part name="parameters" element="tns:CleanUpBookingDeletedResponse" />
  </wsdl:message>
  <wsdl:message name="CleanUpBookingDeletedResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityByTypeAndAssociateRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntityByTypeAndAssociate" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityByTypeAndAssociateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityByTypeAndAssociateResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntityByTypeAndAssociateResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityByTypeAndAssociateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCanInsertForAssociatesRequest">
    <wsdl:part name="parameters" element="tns:GetCanInsertForAssociates" />
  </wsdl:message>
  <wsdl:message name="GetCanInsertForAssociatesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCanInsertForAssociatesResponse">
    <wsdl:part name="parameters" element="tns:GetCanInsertForAssociatesResponse" />
  </wsdl:message>
  <wsdl:message name="GetCanInsertForAssociatesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentHaveParticipantsWithEmailRequest">
    <wsdl:part name="parameters" element="tns:GetAppointmentHaveParticipantsWithEmail" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentHaveParticipantsWithEmailRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentHaveParticipantsWithEmailResponse">
    <wsdl:part name="parameters" element="tns:GetAppointmentHaveParticipantsWithEmailResponse" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentHaveParticipantsWithEmailResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityFromSaleSuggestionRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntityFromSaleSuggestion" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityFromSaleSuggestionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityFromSaleSuggestionResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntityFromSaleSuggestionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityFromSaleSuggestionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextSuggestedAppointmentBySaleRequest">
    <wsdl:part name="parameters" element="tns:GetNextSuggestedAppointmentBySale" />
  </wsdl:message>
  <wsdl:message name="GetNextSuggestedAppointmentBySaleRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextSuggestedAppointmentBySaleResponse">
    <wsdl:part name="parameters" element="tns:GetNextSuggestedAppointmentBySaleResponse" />
  </wsdl:message>
  <wsdl:message name="GetNextSuggestedAppointmentBySaleResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultReOpenAppointmentRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultReOpenAppointment" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultReOpenAppointmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultReOpenAppointmentResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultReOpenAppointmentResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultReOpenAppointmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityFromProjectSuggestionRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntityFromProjectSuggestion" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityFromProjectSuggestionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityFromProjectSuggestionResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntityFromProjectSuggestionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityFromProjectSuggestionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CanAssignToProjectMemberRequest">
    <wsdl:part name="parameters" element="tns:CanAssignToProjectMember" />
  </wsdl:message>
  <wsdl:message name="CanAssignToProjectMemberRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CanAssignToProjectMemberResponse">
    <wsdl:part name="parameters" element="tns:CanAssignToProjectMemberResponse" />
  </wsdl:message>
  <wsdl:message name="CanAssignToProjectMemberResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentListRequest">
    <wsdl:part name="parameters" element="tns:GetAppointmentList" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentListResponse">
    <wsdl:part name="parameters" element="tns:GetAppointmentListResponse" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyAppointmentsRequest">
    <wsdl:part name="parameters" element="tns:GetMyAppointments" />
  </wsdl:message>
  <wsdl:message name="GetMyAppointmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyAppointmentsResponse">
    <wsdl:part name="parameters" element="tns:GetMyAppointmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyAppointmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsRequest">
    <wsdl:part name="parameters" element="tns:GetPersonAppointments" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsResponse">
    <wsdl:part name="parameters" element="tns:GetPersonAppointmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyDiaryRequest">
    <wsdl:part name="parameters" element="tns:GetMyDiary" />
  </wsdl:message>
  <wsdl:message name="GetMyDiaryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyDiaryResponse">
    <wsdl:part name="parameters" element="tns:GetMyDiaryResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyDiaryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyTasksRequest">
    <wsdl:part name="parameters" element="tns:GetMyTasks" />
  </wsdl:message>
  <wsdl:message name="GetMyTasksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyTasksResponse">
    <wsdl:part name="parameters" element="tns:GetMyTasksResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyTasksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonDiaryRequest">
    <wsdl:part name="parameters" element="tns:GetPersonDiary" />
  </wsdl:message>
  <wsdl:message name="GetPersonDiaryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonDiaryResponse">
    <wsdl:part name="parameters" element="tns:GetPersonDiaryResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonDiaryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonTasksRequest">
    <wsdl:part name="parameters" element="tns:GetPersonTasks" />
  </wsdl:message>
  <wsdl:message name="GetPersonTasksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonTasksResponse">
    <wsdl:part name="parameters" element="tns:GetPersonTasksResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonTasksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTypeRequest">
    <wsdl:part name="parameters" element="tns:GetPersonAppointmentsByType" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTypeResponse">
    <wsdl:part name="parameters" element="tns:GetPersonAppointmentsByTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsRequest">
    <wsdl:part name="parameters" element="tns:GetProjectAppointments" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsResponse">
    <wsdl:part name="parameters" element="tns:GetProjectAppointmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTypeRequest">
    <wsdl:part name="parameters" element="tns:GetProjectAppointmentsByType" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTypeResponse">
    <wsdl:part name="parameters" element="tns:GetProjectAppointmentsByTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsRequest">
    <wsdl:part name="parameters" element="tns:GetContactAppointments" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsResponse">
    <wsdl:part name="parameters" element="tns:GetContactAppointmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTypeRequest">
    <wsdl:part name="parameters" element="tns:GetContactAppointmentsByType" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTypeResponse">
    <wsdl:part name="parameters" element="tns:GetContactAppointmentsByTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsRequest">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointments" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsResponse">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTypeRequest">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointmentsByType" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTypeResponse">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointmentsByTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTaskRequest">
    <wsdl:part name="parameters" element="tns:GetPersonAppointmentsByTask" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTaskRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTaskResponse">
    <wsdl:part name="parameters" element="tns:GetPersonAppointmentsByTaskResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTaskResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTasksRequest">
    <wsdl:part name="parameters" element="tns:GetPersonAppointmentsByTasks" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTasksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTasksResponse">
    <wsdl:part name="parameters" element="tns:GetPersonAppointmentsByTasksResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTasksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTaskHeadingRequest">
    <wsdl:part name="parameters" element="tns:GetPersonAppointmentsByTaskHeading" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTaskHeadingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTaskHeadingResponse">
    <wsdl:part name="parameters" element="tns:GetPersonAppointmentsByTaskHeadingResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTaskHeadingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTaskRequest">
    <wsdl:part name="parameters" element="tns:GetProjectAppointmentsByTask" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTaskRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTaskResponse">
    <wsdl:part name="parameters" element="tns:GetProjectAppointmentsByTaskResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTaskResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTasksRequest">
    <wsdl:part name="parameters" element="tns:GetProjectAppointmentsByTasks" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTasksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTasksResponse">
    <wsdl:part name="parameters" element="tns:GetProjectAppointmentsByTasksResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTasksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTaskHeadingRequest">
    <wsdl:part name="parameters" element="tns:GetProjectAppointmentsByTaskHeading" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTaskHeadingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTaskHeadingResponse">
    <wsdl:part name="parameters" element="tns:GetProjectAppointmentsByTaskHeadingResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTaskHeadingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTaskRequest">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointmentsByTask" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTaskRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTaskResponse">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointmentsByTaskResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTaskResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTasksRequest">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointmentsByTasks" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTasksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTasksResponse">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointmentsByTasksResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTasksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTaskHeadingRequest">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointmentsByTaskHeading" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTaskHeadingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTaskHeadingResponse">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointmentsByTaskHeadingResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTaskHeadingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTaskRequest">
    <wsdl:part name="parameters" element="tns:GetContactAppointmentsByTask" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTaskRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTaskResponse">
    <wsdl:part name="parameters" element="tns:GetContactAppointmentsByTaskResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTaskResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTasksRequest">
    <wsdl:part name="parameters" element="tns:GetContactAppointmentsByTasks" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTasksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTasksResponse">
    <wsdl:part name="parameters" element="tns:GetContactAppointmentsByTasksResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTasksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTaskHeadingRequest">
    <wsdl:part name="parameters" element="tns:GetContactAppointmentsByTaskHeading" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTaskHeadingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTaskHeadingResponse">
    <wsdl:part name="parameters" element="tns:GetContactAppointmentsByTaskHeadingResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTaskHeadingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedAppointmentRequest">
    <wsdl:part name="parameters" element="tns:GetPublishedAppointment" />
  </wsdl:message>
  <wsdl:message name="GetPublishedAppointmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedAppointmentResponse">
    <wsdl:part name="parameters" element="tns:GetPublishedAppointmentResponse" />
  </wsdl:message>
  <wsdl:message name="GetPublishedAppointmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedAppointmentsRequest">
    <wsdl:part name="parameters" element="tns:GetPublishedAppointments" />
  </wsdl:message>
  <wsdl:message name="GetPublishedAppointmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedAppointmentsResponse">
    <wsdl:part name="parameters" element="tns:GetPublishedAppointmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetPublishedAppointmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyPublishedAppointmentsRequest">
    <wsdl:part name="parameters" element="tns:GetMyPublishedAppointments" />
  </wsdl:message>
  <wsdl:message name="GetMyPublishedAppointmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyPublishedAppointmentsResponse">
    <wsdl:part name="parameters" element="tns:GetMyPublishedAppointmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyPublishedAppointmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectAppointmentsRequest">
    <wsdl:part name="parameters" element="tns:GetPublishedProjectAppointments" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectAppointmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectAppointmentsResponse">
    <wsdl:part name="parameters" element="tns:GetPublishedProjectAppointmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectAppointmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentsByTaskHeadingRequest">
    <wsdl:part name="parameters" element="tns:GetAppointmentsByTaskHeading" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentsByTaskHeadingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentsByTaskHeadingResponse">
    <wsdl:part name="parameters" element="tns:GetAppointmentsByTaskHeadingResponse" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentsByTaskHeadingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAssociateDiaryRequest">
    <wsdl:part name="parameters" element="tns:GetAssociateDiary" />
  </wsdl:message>
  <wsdl:message name="GetAssociateDiaryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAssociateDiaryResponse">
    <wsdl:part name="parameters" element="tns:GetAssociateDiaryResponse" />
  </wsdl:message>
  <wsdl:message name="GetAssociateDiaryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDiaryByGroupRequest">
    <wsdl:part name="parameters" element="tns:GetDiaryByGroup" />
  </wsdl:message>
  <wsdl:message name="GetDiaryByGroupRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDiaryByGroupResponse">
    <wsdl:part name="parameters" element="tns:GetDiaryByGroupResponse" />
  </wsdl:message>
  <wsdl:message name="GetDiaryByGroupResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentRequest">
    <wsdl:part name="parameters" element="tns:UpdateAppointment" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentResponse">
    <wsdl:part name="parameters" element="tns:UpdateAppointmentResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAssociatesDiaryRequest">
    <wsdl:part name="parameters" element="tns:GetAssociatesDiary" />
  </wsdl:message>
  <wsdl:message name="GetAssociatesDiaryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAssociatesDiaryResponse">
    <wsdl:part name="parameters" element="tns:GetAssociatesDiaryResponse" />
  </wsdl:message>
  <wsdl:message name="GetAssociatesDiaryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentRecordsRequest">
    <wsdl:part name="parameters" element="tns:GetAppointmentRecords" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentRecordsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentRecordsResponse">
    <wsdl:part name="parameters" element="tns:GetAppointmentRecordsResponse" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentRecordsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDayInformationListByDatesAndAssociateRequest">
    <wsdl:part name="parameters" element="tns:GetDayInformationListByDatesAndAssociate" />
  </wsdl:message>
  <wsdl:message name="GetDayInformationListByDatesAndAssociateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDayInformationListByDatesAndAssociateResponse">
    <wsdl:part name="parameters" element="tns:GetDayInformationListByDatesAndAssociateResponse" />
  </wsdl:message>
  <wsdl:message name="GetDayInformationListByDatesAndAssociateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetActivityInformationListByDatesAndAssociateRequest">
    <wsdl:part name="parameters" element="tns:GetActivityInformationListByDatesAndAssociate" />
  </wsdl:message>
  <wsdl:message name="GetActivityInformationListByDatesAndAssociateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetActivityInformationListByDatesAndAssociateResponse">
    <wsdl:part name="parameters" element="tns:GetActivityInformationListByDatesAndAssociateResponse" />
  </wsdl:message>
  <wsdl:message name="GetActivityInformationListByDatesAndAssociateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRedLetterInformationListByDatesAndAssociateRequest">
    <wsdl:part name="parameters" element="tns:GetRedLetterInformationListByDatesAndAssociate" />
  </wsdl:message>
  <wsdl:message name="GetRedLetterInformationListByDatesAndAssociateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRedLetterInformationListByDatesAndAssociateResponse">
    <wsdl:part name="parameters" element="tns:GetRedLetterInformationListByDatesAndAssociateResponse" />
  </wsdl:message>
  <wsdl:message name="GetRedLetterInformationListByDatesAndAssociateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAlarmsRequest">
    <wsdl:part name="parameters" element="tns:GetAlarms" />
  </wsdl:message>
  <wsdl:message name="GetAlarmsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAlarmsResponse">
    <wsdl:part name="parameters" element="tns:GetAlarmsResponse" />
  </wsdl:message>
  <wsdl:message name="GetAlarmsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GenerateLeadRequest">
    <wsdl:part name="parameters" element="tns:GenerateLead" />
  </wsdl:message>
  <wsdl:message name="GenerateLeadRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GenerateLeadResponse">
    <wsdl:part name="parameters" element="tns:GenerateLeadResponse" />
  </wsdl:message>
  <wsdl:message name="GenerateLeadResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RequestForInfoRequest">
    <wsdl:part name="parameters" element="tns:RequestForInfo" />
  </wsdl:message>
  <wsdl:message name="RequestForInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RequestForInfoResponse">
    <wsdl:part name="parameters" element="tns:RequestForInfoResponse" />
  </wsdl:message>
  <wsdl:message name="RequestForInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedAppointmentRequest">
    <wsdl:part name="parameters" element="tns:GetSuggestedAppointment" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedAppointmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedAppointmentResponse">
    <wsdl:part name="parameters" element="tns:GetSuggestedAppointmentResponse" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedAppointmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedAppointmentEntityRequest">
    <wsdl:part name="parameters" element="tns:GetSuggestedAppointmentEntity" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedAppointmentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedAppointmentEntityResponse">
    <wsdl:part name="parameters" element="tns:GetSuggestedAppointmentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedAppointmentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTaskListItemRequest">
    <wsdl:part name="parameters" element="tns:GetTaskListItem" />
  </wsdl:message>
  <wsdl:message name="GetTaskListItemRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTaskListItemResponse">
    <wsdl:part name="parameters" element="tns:GetTaskListItemResponse" />
  </wsdl:message>
  <wsdl:message name="GetTaskListItemResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTaskListItemsRequest">
    <wsdl:part name="parameters" element="tns:GetTaskListItems" />
  </wsdl:message>
  <wsdl:message name="GetTaskListItemsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTaskListItemsResponse">
    <wsdl:part name="parameters" element="tns:GetTaskListItemsResponse" />
  </wsdl:message>
  <wsdl:message name="GetTaskListItemsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Appointment">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Appointment</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultAppointmentEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new AppointmentEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultAppointmentEntity" name="CreateDefaultAppointmentEntityRequest" message="tns:CreateDefaultAppointmentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultAppointmentEntityResponse" name="CreateDefaultAppointmentEntityResponse" message="tns:CreateDefaultAppointmentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveAppointmentEntity">
      <wsdl:documentation>
        <summary>Updates the existing AppointmentEntity or creates a new AppointmentEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/SaveAppointmentEntity" name="SaveAppointmentEntityRequest" message="tns:SaveAppointmentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/SaveAppointmentEntityResponse" name="SaveAppointmentEntityResponse" message="tns:SaveAppointmentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteAppointmentEntity">
      <wsdl:documentation>
        <summary>Deletes the AppointmentEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/DeleteAppointmentEntity" name="DeleteAppointmentEntityRequest" message="tns:DeleteAppointmentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/DeleteAppointmentEntityResponse" name="DeleteAppointmentEntityResponse" message="tns:DeleteAppointmentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultSuggestedAppointmentEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new SuggestedAppointmentEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultSuggestedAppointmentEntity" name="CreateDefaultSuggestedAppointmentEntityRequest" message="tns:CreateDefaultSuggestedAppointmentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultSuggestedAppointmentEntityResponse" name="CreateDefaultSuggestedAppointmentEntityResponse" message="tns:CreateDefaultSuggestedAppointmentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveSuggestedAppointmentEntity">
      <wsdl:documentation>
        <summary>Updates the existing SuggestedAppointmentEntity or creates a new SuggestedAppointmentEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/SaveSuggestedAppointmentEntity" name="SaveSuggestedAppointmentEntityRequest" message="tns:SaveSuggestedAppointmentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/SaveSuggestedAppointmentEntityResponse" name="SaveSuggestedAppointmentEntityResponse" message="tns:SaveSuggestedAppointmentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTaskListItem">
      <wsdl:documentation>
        <summary>Loading default values into a new TaskListItem.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultTaskListItem" name="CreateDefaultTaskListItemRequest" message="tns:CreateDefaultTaskListItemRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultTaskListItemResponse" name="CreateDefaultTaskListItemResponse" message="tns:CreateDefaultTaskListItemResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveTaskListItem">
      <wsdl:documentation>
        <summary>Updates the existing TaskListItem or creates a new TaskListItem if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/SaveTaskListItem" name="SaveTaskListItemRequest" message="tns:SaveTaskListItemRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/SaveTaskListItemResponse" name="SaveTaskListItemResponse" message="tns:SaveTaskListItemResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAppointment">
      <wsdl:documentation>
        <summary>Gets a Appointment object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAppointment" name="GetAppointmentRequest" message="tns:GetAppointmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAppointmentResponse" name="GetAppointmentResponse" message="tns:GetAppointmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="ToggleAppointmentStatus">
      <wsdl:documentation>
        <summary>Sets an appointment's status to Completed if the appointment had a different status, or sets the status to started if already set to completed.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/ToggleAppointmentStatus" name="ToggleAppointmentStatusRequest" message="tns:ToggleAppointmentStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/ToggleAppointmentStatusResponse" name="ToggleAppointmentStatusResponse" message="tns:ToggleAppointmentStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="ToggleActivity">
      <wsdl:documentation>
        <summary>Toggle the completed status for an activity. Activity may be sale, document or appointment. The changes are saved immediately. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/ToggleActivity" name="ToggleActivityRequest" message="tns:ToggleActivityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/ToggleActivityResponse" name="ToggleActivityResponse" message="tns:ToggleActivityResponse" />
    </wsdl:operation>
    <wsdl:operation name="ToggleActivities">
      <wsdl:documentation>
        <summary>Toggle the completed status for an array of activities. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/ToggleActivities" name="ToggleActivitiesRequest" message="tns:ToggleActivitiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/ToggleActivitiesResponse" name="ToggleActivitiesResponse" message="tns:ToggleActivitiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetActivityStatus">
      <wsdl:documentation>
        <summary>Sets the completed status for an array of activities. The string activityIdentifier param may contain of a mix of appointment_id, sale_id, document_id and todo_id. The changes are saved immediately. If an invalid id is passed in (nonexistent record), no changes will be made. If there is no write access to the record being changed, a Sentry exception will be thrown in the usual manner.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/SetActivityStatus" name="SetActivityStatusRequest" message="tns:SetActivityStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/SetActivityStatusResponse" name="SetActivityStatusResponse" message="tns:SetActivityStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="ToggleAndSetActivities">
      <wsdl:documentation>
        <summary>Toggles the first activity and sets the rest of the activities to the result of the first toggle. However, there are some special rules for appointments that trigger a suggested appointment when they are completed. If more than one appointment in the set of identifiers triggers a suggestion, we will not toggle those appointments. This rule is only active when changing the status of an appointment to complete. There must be more than one appointment that triggers such an event for this rule to take effect.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/ToggleAndSetActivities" name="ToggleAndSetActivitiesRequest" message="tns:ToggleAndSetActivitiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/ToggleAndSetActivitiesResponse" name="ToggleAndSetActivitiesResponse" message="tns:ToggleAndSetActivitiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMySyncAppointments">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments within a time range. The appointments belong to the currently logged on user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetMySyncAppointments" name="GetMySyncAppointmentsRequest" message="tns:GetMySyncAppointmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetMySyncAppointmentsResponse" name="GetMySyncAppointmentsResponse" message="tns:GetMySyncAppointmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentEntity">
      <wsdl:documentation>
        <summary>Gets a AppointmentEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAppointmentEntity" name="GetAppointmentEntityRequest" message="tns:GetAppointmentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAppointmentEntityResponse" name="GetAppointmentEntityResponse" message="tns:GetAppointmentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAppointmentEntityByType">
      <wsdl:documentation>
        <summary>Creates a AppointmentEntity populated with the default values for the specific type.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultAppointmentEntityByType" name="CreateDefaultAppointmentEntityByTypeRequest" message="tns:CreateDefaultAppointmentEntityByTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultAppointmentEntityByTypeResponse" name="CreateDefaultAppointmentEntityByTypeResponse" message="tns:CreateDefaultAppointmentEntityByTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="Accept">
      <wsdl:documentation>
        <summary>Accepting an appointment invitation.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/Accept" name="AcceptRequest" message="tns:AcceptRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/AcceptResponse" name="AcceptResponse" message="tns:AcceptResponse" />
    </wsdl:operation>
    <wsdl:operation name="Reject">
      <wsdl:documentation>
        <summary>Rejecting an appointment invitation</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/Reject" name="RejectRequest" message="tns:RejectRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/RejectResponse" name="RejectResponse" message="tns:RejectResponse" />
    </wsdl:operation>
    <wsdl:operation name="Save">
      <wsdl:documentation>
        <summary>Saving a booking.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/Save" name="SaveRequest" message="tns:SaveRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/SaveResponse" name="SaveResponse" message="tns:SaveResponse" />
    </wsdl:operation>
    <wsdl:operation name="Delete">
      <wsdl:documentation>
        <summary>Deleting a booking</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/Delete" name="DeleteRequest" message="tns:DeleteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/DeleteResponse" name="DeleteResponse" message="tns:DeleteResponse" />
    </wsdl:operation>
    <wsdl:operation name="CalculateDays">
      <wsdl:documentation>
        <summary>Calculates the set of dates that represents a recurrence pattern. Adds conflict information to each date.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CalculateDays" name="CalculateDaysRequest" message="tns:CalculateDaysRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CalculateDaysResponse" name="CalculateDaysResponse" message="tns:CalculateDaysResponse" />
    </wsdl:operation>
    <wsdl:operation name="ValidateDays">
      <wsdl:documentation>
        <summary>Validates the set of dates to calculate any conflicts.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/ValidateDays" name="ValidateDaysRequest" message="tns:ValidateDaysRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/ValidateDaysResponse" name="ValidateDaysResponse" message="tns:ValidateDaysResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultRecurrence">
      <wsdl:documentation>
        <summary>Creates a RecurrenceInfo object populated with the default values for the specific type.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultRecurrence" name="CreateDefaultRecurrenceRequest" message="tns:CreateDefaultRecurrenceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultRecurrenceResponse" name="CreateDefaultRecurrenceResponse" message="tns:CreateDefaultRecurrenceResponse" />
    </wsdl:operation>
    <wsdl:operation name="AssignTo">
      <wsdl:documentation>
        <summary>Assigning an appointment to another person.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/AssignTo" name="AssignToRequest" message="tns:AssignToRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/AssignToResponse" name="AssignToResponse" message="tns:AssignToResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetSeen">
      <wsdl:documentation>
        <summary>Sets an appointment invitiation to seen.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/SetSeen" name="SetSeenRequest" message="tns:SetSeenRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/SetSeenResponse" name="SetSeenResponse" message="tns:SetSeenResponse" />
    </wsdl:operation>
    <wsdl:operation name="Move">
      <wsdl:documentation>
        <summary>Moving a booking to another start time.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/Move" name="MoveRequest" message="tns:MoveRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/MoveResponse" name="MoveResponse" message="tns:MoveResponse" />
    </wsdl:operation>
    <wsdl:operation name="AcceptRejected">
      <wsdl:documentation>
        <summary>Accept that an invited participant has rejected your invitation or assignment.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/AcceptRejected" name="AcceptRejectedRequest" message="tns:AcceptRejectedRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/AcceptRejectedResponse" name="AcceptRejectedResponse" message="tns:AcceptRejectedResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultRecurrenceByDate">
      <wsdl:documentation>
        <summary>Creates a RecurrenceInfo object populated with the default values for the specific type. Using startDate as start date for the recurreing pattern.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultRecurrenceByDate" name="CreateDefaultRecurrenceByDateRequest" message="tns:CreateDefaultRecurrenceByDateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultRecurrenceByDateResponse" name="CreateDefaultRecurrenceByDateResponse" message="tns:CreateDefaultRecurrenceByDateResponse" />
    </wsdl:operation>
    <wsdl:operation name="CleanUpBookingDeleted">
      <wsdl:documentation>
        <summary>Deletes all appointments(within the appointmentIds array) with status BookingDeleted.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CleanUpBookingDeleted" name="CleanUpBookingDeletedRequest" message="tns:CleanUpBookingDeletedRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CleanUpBookingDeletedResponse" name="CleanUpBookingDeletedResponse" message="tns:CleanUpBookingDeletedResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAppointmentEntityByTypeAndAssociate">
      <wsdl:documentation>
        <summary>Creates a AppointmentEntity populated with the default values for the specific type and owner.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate" name="CreateDefaultAppointmentEntityByTypeAndAssociateRequest" message="tns:CreateDefaultAppointmentEntityByTypeAndAssociateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociateResponse" name="CreateDefaultAppointmentEntityByTypeAndAssociateResponse" message="tns:CreateDefaultAppointmentEntityByTypeAndAssociateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCanInsertForAssociates">
      <wsdl:documentation>
        <summary>Check if current associate can create appointments in the diary of other associates.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetCanInsertForAssociates" name="GetCanInsertForAssociatesRequest" message="tns:GetCanInsertForAssociatesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetCanInsertForAssociatesResponse" name="GetCanInsertForAssociatesResponse" message="tns:GetCanInsertForAssociatesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentHaveParticipantsWithEmail">
      <wsdl:documentation>
        <summary>GetAppointmentHaveParticipantsWithEmail will check if any of the participants is marked to receive emails on this appointment. If no participants are defined, false will be returned.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAppointmentHaveParticipantsWithEmail" name="GetAppointmentHaveParticipantsWithEmailRequest" message="tns:GetAppointmentHaveParticipantsWithEmailRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAppointmentHaveParticipantsWithEmailResponse" name="GetAppointmentHaveParticipantsWithEmailResponse" message="tns:GetAppointmentHaveParticipantsWithEmailResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAppointmentEntityFromSaleSuggestion">
      <wsdl:documentation>
        <summary>Creates an appointment based on a suggested appointment. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultAppointmentEntityFromSaleSuggestion" name="CreateDefaultAppointmentEntityFromSaleSuggestionRequest" message="tns:CreateDefaultAppointmentEntityFromSaleSuggestionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultAppointmentEntityFromSaleSuggestionResponse" name="CreateDefaultAppointmentEntityFromSaleSuggestionResponse" message="tns:CreateDefaultAppointmentEntityFromSaleSuggestionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNextSuggestedAppointmentBySale">
      <wsdl:documentation>
        <summary>Gets the next suggested appointment for a given sale (or rather a given sale's guide).</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetNextSuggestedAppointmentBySale" name="GetNextSuggestedAppointmentBySaleRequest" message="tns:GetNextSuggestedAppointmentBySaleRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetNextSuggestedAppointmentBySaleResponse" name="GetNextSuggestedAppointmentBySaleResponse" message="tns:GetNextSuggestedAppointmentBySaleResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultReOpenAppointment">
      <wsdl:documentation>
        <summary>A re-open appointment should be created as a reminder to re-open the sale at a certain date with information regarding the stalled sale. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultReOpenAppointment" name="CreateDefaultReOpenAppointmentRequest" message="tns:CreateDefaultReOpenAppointmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultReOpenAppointmentResponse" name="CreateDefaultReOpenAppointmentResponse" message="tns:CreateDefaultReOpenAppointmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAppointmentEntityFromProjectSuggestion">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultAppointmentEntityFromProjectSuggestion" name="CreateDefaultAppointmentEntityFromProjectSuggestionRequest" message="tns:CreateDefaultAppointmentEntityFromProjectSuggestionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultAppointmentEntityFromProjectSuggestionResponse" name="CreateDefaultAppointmentEntityFromProjectSuggestionResponse" message="tns:CreateDefaultAppointmentEntityFromProjectSuggestionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CanAssignToProjectMember">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CanAssignToProjectMember" name="CanAssignToProjectMemberRequest" message="tns:CanAssignToProjectMemberRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CanAssignToProjectMemberResponse" name="CanAssignToProjectMemberResponse" message="tns:CanAssignToProjectMemberResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentList">
      <wsdl:documentation>
        <summary>Gets an array of Appointment objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAppointmentList" name="GetAppointmentListRequest" message="tns:GetAppointmentListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAppointmentListResponse" name="GetAppointmentListResponse" message="tns:GetAppointmentListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyAppointments">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments within a time range. The appointments belong to the currently logged on user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetMyAppointments" name="GetMyAppointmentsRequest" message="tns:GetMyAppointmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetMyAppointmentsResponse" name="GetMyAppointmentsResponse" message="tns:GetMyAppointmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointments">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments within a time range. The appointments belong to the person specified. If the person not is a SuperOffice user (associate) or the logged on user is not allowed to view this persons appointments an exception is thrown.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonAppointments" name="GetPersonAppointmentsRequest" message="tns:GetPersonAppointmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonAppointmentsResponse" name="GetPersonAppointmentsResponse" message="tns:GetPersonAppointmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyDiary">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments within a time range. It only returns appointments that would be displayed in the user's diary. The appointments belong to the currently logged on user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetMyDiary" name="GetMyDiaryRequest" message="tns:GetMyDiaryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetMyDiaryResponse" name="GetMyDiaryResponse" message="tns:GetMyDiaryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyTasks">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments within a time range. It only returns appointments that would be displayed in the user's task list. The appointments belong to the currently logged on user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetMyTasks" name="GetMyTasksRequest" message="tns:GetMyTasksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetMyTasksResponse" name="GetMyTasksResponse" message="tns:GetMyTasksResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonDiary">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments within a time range. It only returns appointments that would be displayed in the user's diary. The appointments belong to the person specified. If the person not is a SuperOffice user (associate) or the logged on user is not allowed to view this persons appointments an exception is thrown.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonDiary" name="GetPersonDiaryRequest" message="tns:GetPersonDiaryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonDiaryResponse" name="GetPersonDiaryResponse" message="tns:GetPersonDiaryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonTasks">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments within a time range. It only returns appointments that would be displayed in the user's task list. The appointments belong to the person specified. If the person not is a SuperOffice user (associate) or the logged on user is not allowed to view this persons appointments an exception is thrown.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonTasks" name="GetPersonTasksRequest" message="tns:GetPersonTasksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonTasksResponse" name="GetPersonTasksResponse" message="tns:GetPersonTasksResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointmentsByType">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments of a specific appointment type within a time range. The appointments belong to the person specified.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonAppointmentsByType" name="GetPersonAppointmentsByTypeRequest" message="tns:GetPersonAppointmentsByTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonAppointmentsByTypeResponse" name="GetPersonAppointmentsByTypeResponse" message="tns:GetPersonAppointmentsByTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointments">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments within a time range. The appointments belong to the project specified. If the logged on user is not allowed to view this projects appointments an exception is thrown.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectAppointments" name="GetProjectAppointmentsRequest" message="tns:GetProjectAppointmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectAppointmentsResponse" name="GetProjectAppointmentsResponse" message="tns:GetProjectAppointmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointmentsByType">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments of a specific appointment type within a time range. The appointments belong to the project specified.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectAppointmentsByType" name="GetProjectAppointmentsByTypeRequest" message="tns:GetProjectAppointmentsByTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectAppointmentsByTypeResponse" name="GetProjectAppointmentsByTypeResponse" message="tns:GetProjectAppointmentsByTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointments">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments within a time range. The appointments belong to the contact specified. If the logged on user is not allowed to view this persons appointments an exception is thrown.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetContactAppointments" name="GetContactAppointmentsRequest" message="tns:GetContactAppointmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetContactAppointmentsResponse" name="GetContactAppointmentsResponse" message="tns:GetContactAppointmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointmentsByType">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments of a specific appointment type within a time range. The appointments belong to the contact specified. If the logged on user is not allowed to view this contacts appointments an exception is thrown.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetContactAppointmentsByType" name="GetContactAppointmentsByTypeRequest" message="tns:GetContactAppointmentsByTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetContactAppointmentsByTypeResponse" name="GetContactAppointmentsByTypeResponse" message="tns:GetContactAppointmentsByTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointments">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments within a time range. The appointments belong to the projects where the person specified is member.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectMemberAppointments" name="GetProjectMemberAppointmentsRequest" message="tns:GetProjectMemberAppointmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectMemberAppointmentsResponse" name="GetProjectMemberAppointmentsResponse" message="tns:GetProjectMemberAppointmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointmentsByType">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments of a specific appointment type within a time range. The appointments belong to the projects where the person specified is member.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectMemberAppointmentsByType" name="GetProjectMemberAppointmentsByTypeRequest" message="tns:GetProjectMemberAppointmentsByTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectMemberAppointmentsByTypeResponse" name="GetProjectMemberAppointmentsByTypeResponse" message="tns:GetProjectMemberAppointmentsByTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointmentsByTask">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments of a specific appointment task type within a time range. The appointments belong to the person specified.  Task represents the different types of activities, like “Phone call”, “Meeting” and so on.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonAppointmentsByTask" name="GetPersonAppointmentsByTaskRequest" message="tns:GetPersonAppointmentsByTaskRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonAppointmentsByTaskResponse" name="GetPersonAppointmentsByTaskResponse" message="tns:GetPersonAppointmentsByTaskResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointmentsByTasks">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments from a list of appointment task types within a time range. The appointments belong to the person specified.  Task represents the different types of activities, like “Phone call”, “Meeting” and so on.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonAppointmentsByTasks" name="GetPersonAppointmentsByTasksRequest" message="tns:GetPersonAppointmentsByTasksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonAppointmentsByTasksResponse" name="GetPersonAppointmentsByTasksResponse" message="tns:GetPersonAppointmentsByTasksResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointmentsByTaskHeading">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments of a specific appointment task heading within a time range. The appointments belong to the person specified.  Task represents the different types of activities, like “Phone call”, “Meeting” and so on. The heading represents a grouping or filtering of tasks.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonAppointmentsByTaskHeading" name="GetPersonAppointmentsByTaskHeadingRequest" message="tns:GetPersonAppointmentsByTaskHeadingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonAppointmentsByTaskHeadingResponse" name="GetPersonAppointmentsByTaskHeadingResponse" message="tns:GetPersonAppointmentsByTaskHeadingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointmentsByTask">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments of a specific appointment task type within a time range. The appointments belong to the project specified.  Task represents the different types of activities, like “Phone call”, “Meeting” and so on.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectAppointmentsByTask" name="GetProjectAppointmentsByTaskRequest" message="tns:GetProjectAppointmentsByTaskRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectAppointmentsByTaskResponse" name="GetProjectAppointmentsByTaskResponse" message="tns:GetProjectAppointmentsByTaskResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointmentsByTasks">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments matching the list of appointment task types within a time range. The appointments belong to the project specified.  Task represents the different types of activities, like “Phone call”, “Meeting” and so on.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectAppointmentsByTasks" name="GetProjectAppointmentsByTasksRequest" message="tns:GetProjectAppointmentsByTasksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectAppointmentsByTasksResponse" name="GetProjectAppointmentsByTasksResponse" message="tns:GetProjectAppointmentsByTasksResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointmentsByTaskHeading">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments of a specific appointment task heading within a time range. The appointments belong to the project specified.  Task represents the different types of activities, like “Phone call”, “Meeting” and so on. The heading represents a grouping or filtering of tasks.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectAppointmentsByTaskHeading" name="GetProjectAppointmentsByTaskHeadingRequest" message="tns:GetProjectAppointmentsByTaskHeadingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectAppointmentsByTaskHeadingResponse" name="GetProjectAppointmentsByTaskHeadingResponse" message="tns:GetProjectAppointmentsByTaskHeadingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointmentsByTask">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments of a specific appointment task type within a time range. The appointments belong to the projects where the person specified is member. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectMemberAppointmentsByTask" name="GetProjectMemberAppointmentsByTaskRequest" message="tns:GetProjectMemberAppointmentsByTaskRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectMemberAppointmentsByTaskResponse" name="GetProjectMemberAppointmentsByTaskResponse" message="tns:GetProjectMemberAppointmentsByTaskResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointmentsByTasks">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments matching a set of appointment task types within a time range. The appointments belong to the projects where the person specified is member. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectMemberAppointmentsByTasks" name="GetProjectMemberAppointmentsByTasksRequest" message="tns:GetProjectMemberAppointmentsByTasksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectMemberAppointmentsByTasksResponse" name="GetProjectMemberAppointmentsByTasksResponse" message="tns:GetProjectMemberAppointmentsByTasksResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointmentsByTaskHeading">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments of a specific appointment task heading within a time range. The appointments belong to the projects where the person specified is member. Task represents the different types of activities, like “Phone call”, “Meeting” and so on. The heading represents a grouping or filtering of tasks.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectMemberAppointmentsByTaskHeading" name="GetProjectMemberAppointmentsByTaskHeadingRequest" message="tns:GetProjectMemberAppointmentsByTaskHeadingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectMemberAppointmentsByTaskHeadingResponse" name="GetProjectMemberAppointmentsByTaskHeadingResponse" message="tns:GetProjectMemberAppointmentsByTaskHeadingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointmentsByTask">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments of a specific appointment task type within a time range. The appointments belong to the contact specified. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetContactAppointmentsByTask" name="GetContactAppointmentsByTaskRequest" message="tns:GetContactAppointmentsByTaskRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetContactAppointmentsByTaskResponse" name="GetContactAppointmentsByTaskResponse" message="tns:GetContactAppointmentsByTaskResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointmentsByTasks">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments belonging to an array of appointment task types within a time range. The appointments belong to the contact specified. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetContactAppointmentsByTasks" name="GetContactAppointmentsByTasksRequest" message="tns:GetContactAppointmentsByTasksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetContactAppointmentsByTasksResponse" name="GetContactAppointmentsByTasksResponse" message="tns:GetContactAppointmentsByTasksResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointmentsByTaskHeading">
      <wsdl:documentation>
        <summary>Method that returns a specified number of appointments of a specific appointment task heading within a time range. The appointments belong to the contact specified. Task represents the different types of activities, like “Phone call”, “Meeting” and so on. The heading represents a grouping or filtering of tasks.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetContactAppointmentsByTaskHeading" name="GetContactAppointmentsByTaskHeadingRequest" message="tns:GetContactAppointmentsByTaskHeadingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetContactAppointmentsByTaskHeadingResponse" name="GetContactAppointmentsByTaskHeadingResponse" message="tns:GetContactAppointmentsByTaskHeadingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPublishedAppointment">
      <wsdl:documentation>
        <summary>Get published appointment by appointment id.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPublishedAppointment" name="GetPublishedAppointmentRequest" message="tns:GetPublishedAppointmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPublishedAppointmentResponse" name="GetPublishedAppointmentResponse" message="tns:GetPublishedAppointmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPublishedAppointments">
      <wsdl:documentation>
        <summary>Get published appointments by appointment ids.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPublishedAppointments" name="GetPublishedAppointmentsRequest" message="tns:GetPublishedAppointmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPublishedAppointmentsResponse" name="GetPublishedAppointmentsResponse" message="tns:GetPublishedAppointmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyPublishedAppointments">
      <wsdl:documentation>
        <summary>Get published appointments from the logged in user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetMyPublishedAppointments" name="GetMyPublishedAppointmentsRequest" message="tns:GetMyPublishedAppointmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetMyPublishedAppointmentsResponse" name="GetMyPublishedAppointmentsResponse" message="tns:GetMyPublishedAppointmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPublishedProjectAppointments">
      <wsdl:documentation>
        <summary>Get published appointments by project id.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPublishedProjectAppointments" name="GetPublishedProjectAppointmentsRequest" message="tns:GetPublishedProjectAppointmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPublishedProjectAppointmentsResponse" name="GetPublishedProjectAppointmentsResponse" message="tns:GetPublishedProjectAppointmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentsByTaskHeading">
      <wsdl:documentation>
        <summary>Method that returns appointments of a specific appointment task heading. Task represents the different types of activities, like “Phone call”, “Meeting” and so on. The heading represents a grouping or filtering of tasks.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAppointmentsByTaskHeading" name="GetAppointmentsByTaskHeadingRequest" message="tns:GetAppointmentsByTaskHeadingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAppointmentsByTaskHeadingResponse" name="GetAppointmentsByTaskHeadingResponse" message="tns:GetAppointmentsByTaskHeadingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAssociateDiary">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAssociateDiary" name="GetAssociateDiaryRequest" message="tns:GetAssociateDiaryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAssociateDiaryResponse" name="GetAssociateDiaryResponse" message="tns:GetAssociateDiaryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDiaryByGroup">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetDiaryByGroup" name="GetDiaryByGroupRequest" message="tns:GetDiaryByGroupRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetDiaryByGroupResponse" name="GetDiaryByGroupResponse" message="tns:GetDiaryByGroupResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateAppointment">
      <wsdl:documentation>
        <summary>Updates an appointment record.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/UpdateAppointment" name="UpdateAppointmentRequest" message="tns:UpdateAppointmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/UpdateAppointmentResponse" name="UpdateAppointmentResponse" message="tns:UpdateAppointmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAssociatesDiary">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAssociatesDiary" name="GetAssociatesDiaryRequest" message="tns:GetAssociatesDiaryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAssociatesDiaryResponse" name="GetAssociatesDiaryResponse" message="tns:GetAssociatesDiaryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentRecords">
      <wsdl:documentation>
        <summary>Get all records involved in a booking and/or recurring appointments. MotherId can be zero for repeating appointments or bookings, and recurrenceRuleId can be zero for bookings that are not repeating.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAppointmentRecords" name="GetAppointmentRecordsRequest" message="tns:GetAppointmentRecordsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAppointmentRecordsResponse" name="GetAppointmentRecordsResponse" message="tns:GetAppointmentRecordsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDayInformationListByDatesAndAssociate">
      <wsdl:documentation>
        <summary>Get combined day information (activity + redletter summary) for one or more days according to the given date interval. The time portion of the dates is ignored. Private appointments are counted, but may not be visible through tooltips or other more detailed services.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetDayInformationListByDatesAndAssociate" name="GetDayInformationListByDatesAndAssociateRequest" message="tns:GetDayInformationListByDatesAndAssociateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetDayInformationListByDatesAndAssociateResponse" name="GetDayInformationListByDatesAndAssociateResponse" message="tns:GetDayInformationListByDatesAndAssociateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetActivityInformationListByDatesAndAssociate">
      <wsdl:documentation>
        <summary>Get activity information for one or more days according to the given date interval. The time portion of the dates is ignored. Private appointments are counted, but may not be visible through tooltips or other more detailed services.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetActivityInformationListByDatesAndAssociate" name="GetActivityInformationListByDatesAndAssociateRequest" message="tns:GetActivityInformationListByDatesAndAssociateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetActivityInformationListByDatesAndAssociateResponse" name="GetActivityInformationListByDatesAndAssociateResponse" message="tns:GetActivityInformationListByDatesAndAssociateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetRedLetterInformationListByDatesAndAssociate">
      <wsdl:documentation>
        <summary>Get detailed red letter day information (redletter summary + individual day texts) for one or more days according to the given date interval. The time portion of the dates is ignored. </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetRedLetterInformationListByDatesAndAssociate" name="GetRedLetterInformationListByDatesAndAssociateRequest" message="tns:GetRedLetterInformationListByDatesAndAssociateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetRedLetterInformationListByDatesAndAssociateResponse" name="GetRedLetterInformationListByDatesAndAssociateResponse" message="tns:GetRedLetterInformationListByDatesAndAssociateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAlarms">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAlarms" name="GetAlarmsRequest" message="tns:GetAlarmsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAlarmsResponse" name="GetAlarmsResponse" message="tns:GetAlarmsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GenerateLead">
      <wsdl:documentation>
        <summary>Adds a sales lead (task) to a contact in SuperOffice. If the contact or person is known, the sales lead is added to the current contact. If not, a new contact is created, with the associate with ownerIdForNewContact as responsible (Our Contact). A relation is created between the contact and the person submitting the lead. Based on wether the person the request is made for is found or not, the following happens: If the person is found, the person, person's contact and sales representative is returned. If neither the person nor the contact is found a new person and contact is created (if sufficient data is supplied), and the person, person's contact and sales representative is returned. If the contact and not the person is found a new person is created on this contact, and the contact, salesrep, and person is returned (if there was enough data to return the person). If more than one contact is found a list of contacts is returned.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GenerateLead" name="GenerateLeadRequest" message="tns:GenerateLeadRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GenerateLeadResponse" name="GenerateLeadResponse" message="tns:GenerateLeadResponse" />
    </wsdl:operation>
    <wsdl:operation name="RequestForInfo">
      <wsdl:documentation>
        <summary>Submits a request for information. The request is added to the task list of the user that is responsible for this contact. Based on wether the person the request is made for is found or not, the following happens: If the person is found, the person, person's contact and sales representative is returned. If neither the person nor the contact is found a new person and contact is created (if sufficient data is supplied), and the person, person's contact and sales representative is returned. If the contact and not the person is found a new person is created on this contact, and the contact, salesrep, and person is returned (if there was enough data to return the person). If more than one contact is found a list of contacts is returned.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/RequestForInfo" name="RequestForInfoRequest" message="tns:RequestForInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/RequestForInfoResponse" name="RequestForInfoResponse" message="tns:RequestForInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSuggestedAppointment">
      <wsdl:documentation>
        <summary>Gets a SuggestedAppointment object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetSuggestedAppointment" name="GetSuggestedAppointmentRequest" message="tns:GetSuggestedAppointmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetSuggestedAppointmentResponse" name="GetSuggestedAppointmentResponse" message="tns:GetSuggestedAppointmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSuggestedAppointmentEntity">
      <wsdl:documentation>
        <summary>Gets a SuggestedAppointmentEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetSuggestedAppointmentEntity" name="GetSuggestedAppointmentEntityRequest" message="tns:GetSuggestedAppointmentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetSuggestedAppointmentEntityResponse" name="GetSuggestedAppointmentEntityResponse" message="tns:GetSuggestedAppointmentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTaskListItem">
      <wsdl:documentation>
        <summary>Gets a TaskListItem object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetTaskListItem" name="GetTaskListItemRequest" message="tns:GetTaskListItemRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetTaskListItemResponse" name="GetTaskListItemResponse" message="tns:GetTaskListItemResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTaskListItems">
      <wsdl:documentation>
        <summary>Gets all takslist items</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetTaskListItems" name="GetTaskListItemsRequest" message="tns:GetTaskListItemsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetTaskListItemsResponse" name="GetTaskListItemsResponse" message="tns:GetTaskListItemsResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Appointment" type="tns:Appointment">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultAppointmentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultAppointmentEntity" style="document" />
      <wsdl:input name="CreateDefaultAppointmentEntityRequest">
        <soap:header message="tns:CreateDefaultAppointmentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultAppointmentEntityResponse">
        <soap:header message="tns:CreateDefaultAppointmentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveAppointmentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/SaveAppointmentEntity" style="document" />
      <wsdl:input name="SaveAppointmentEntityRequest">
        <soap:header message="tns:SaveAppointmentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveAppointmentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveAppointmentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveAppointmentEntityResponse">
        <soap:header message="tns:SaveAppointmentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveAppointmentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveAppointmentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveAppointmentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteAppointmentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/DeleteAppointmentEntity" style="document" />
      <wsdl:input name="DeleteAppointmentEntityRequest">
        <soap:header message="tns:DeleteAppointmentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteAppointmentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteAppointmentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteAppointmentEntityResponse">
        <soap:header message="tns:DeleteAppointmentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteAppointmentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteAppointmentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteAppointmentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultSuggestedAppointmentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultSuggestedAppointmentEntity" style="document" />
      <wsdl:input name="CreateDefaultSuggestedAppointmentEntityRequest">
        <soap:header message="tns:CreateDefaultSuggestedAppointmentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultSuggestedAppointmentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultSuggestedAppointmentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultSuggestedAppointmentEntityResponse">
        <soap:header message="tns:CreateDefaultSuggestedAppointmentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSuggestedAppointmentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSuggestedAppointmentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultSuggestedAppointmentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveSuggestedAppointmentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/SaveSuggestedAppointmentEntity" style="document" />
      <wsdl:input name="SaveSuggestedAppointmentEntityRequest">
        <soap:header message="tns:SaveSuggestedAppointmentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveSuggestedAppointmentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveSuggestedAppointmentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveSuggestedAppointmentEntityResponse">
        <soap:header message="tns:SaveSuggestedAppointmentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveSuggestedAppointmentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveSuggestedAppointmentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveSuggestedAppointmentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTaskListItem">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultTaskListItem" style="document" />
      <wsdl:input name="CreateDefaultTaskListItemRequest">
        <soap:header message="tns:CreateDefaultTaskListItemRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTaskListItemRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTaskListItemRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTaskListItemResponse">
        <soap:header message="tns:CreateDefaultTaskListItemResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTaskListItemResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTaskListItemResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTaskListItemResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveTaskListItem">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/SaveTaskListItem" style="document" />
      <wsdl:input name="SaveTaskListItemRequest">
        <soap:header message="tns:SaveTaskListItemRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveTaskListItemRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveTaskListItemRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveTaskListItemResponse">
        <soap:header message="tns:SaveTaskListItemResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveTaskListItemResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveTaskListItemResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveTaskListItemResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAppointment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAppointment" style="document" />
      <wsdl:input name="GetAppointmentRequest">
        <soap:header message="tns:GetAppointmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAppointmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAppointmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAppointmentResponse">
        <soap:header message="tns:GetAppointmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAppointmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAppointmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAppointmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ToggleAppointmentStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/ToggleAppointmentStatus" style="document" />
      <wsdl:input name="ToggleAppointmentStatusRequest">
        <soap:header message="tns:ToggleAppointmentStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ToggleAppointmentStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ToggleAppointmentStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ToggleAppointmentStatusResponse">
        <soap:header message="tns:ToggleAppointmentStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ToggleAppointmentStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ToggleAppointmentStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ToggleAppointmentStatusResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ToggleActivity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/ToggleActivity" style="document" />
      <wsdl:input name="ToggleActivityRequest">
        <soap:header message="tns:ToggleActivityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ToggleActivityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ToggleActivityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ToggleActivityResponse">
        <soap:header message="tns:ToggleActivityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ToggleActivityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ToggleActivityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ToggleActivityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ToggleActivities">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/ToggleActivities" style="document" />
      <wsdl:input name="ToggleActivitiesRequest">
        <soap:header message="tns:ToggleActivitiesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ToggleActivitiesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ToggleActivitiesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ToggleActivitiesResponse">
        <soap:header message="tns:ToggleActivitiesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ToggleActivitiesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ToggleActivitiesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ToggleActivitiesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetActivityStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/SetActivityStatus" style="document" />
      <wsdl:input name="SetActivityStatusRequest">
        <soap:header message="tns:SetActivityStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetActivityStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetActivityStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetActivityStatusResponse">
        <soap:header message="tns:SetActivityStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetActivityStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetActivityStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetActivityStatusResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ToggleAndSetActivities">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/ToggleAndSetActivities" style="document" />
      <wsdl:input name="ToggleAndSetActivitiesRequest">
        <soap:header message="tns:ToggleAndSetActivitiesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ToggleAndSetActivitiesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ToggleAndSetActivitiesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ToggleAndSetActivitiesResponse">
        <soap:header message="tns:ToggleAndSetActivitiesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ToggleAndSetActivitiesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ToggleAndSetActivitiesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ToggleAndSetActivitiesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMySyncAppointments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetMySyncAppointments" style="document" />
      <wsdl:input name="GetMySyncAppointmentsRequest">
        <soap:header message="tns:GetMySyncAppointmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMySyncAppointmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMySyncAppointmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMySyncAppointmentsResponse">
        <soap:header message="tns:GetMySyncAppointmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMySyncAppointmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMySyncAppointmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMySyncAppointmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAppointmentEntity" style="document" />
      <wsdl:input name="GetAppointmentEntityRequest">
        <soap:header message="tns:GetAppointmentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAppointmentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAppointmentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAppointmentEntityResponse">
        <soap:header message="tns:GetAppointmentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAppointmentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAppointmentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAppointmentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAppointmentEntityByType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultAppointmentEntityByType" style="document" />
      <wsdl:input name="CreateDefaultAppointmentEntityByTypeRequest">
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultAppointmentEntityByTypeResponse">
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Accept">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/Accept" style="document" />
      <wsdl:input name="AcceptRequest">
        <soap:header message="tns:AcceptRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AcceptRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AcceptRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AcceptResponse">
        <soap:header message="tns:AcceptResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AcceptResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AcceptResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AcceptResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Reject">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/Reject" style="document" />
      <wsdl:input name="RejectRequest">
        <soap:header message="tns:RejectRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RejectRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RejectRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RejectResponse">
        <soap:header message="tns:RejectResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RejectResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RejectResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RejectResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Save">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/Save" style="document" />
      <wsdl:input name="SaveRequest">
        <soap:header message="tns:SaveRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveResponse">
        <soap:header message="tns:SaveResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Delete">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/Delete" style="document" />
      <wsdl:input name="DeleteRequest">
        <soap:header message="tns:DeleteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteResponse">
        <soap:header message="tns:DeleteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CalculateDays">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CalculateDays" style="document" />
      <wsdl:input name="CalculateDaysRequest">
        <soap:header message="tns:CalculateDaysRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CalculateDaysRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CalculateDaysRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CalculateDaysResponse">
        <soap:header message="tns:CalculateDaysResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CalculateDaysResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CalculateDaysResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CalculateDaysResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ValidateDays">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/ValidateDays" style="document" />
      <wsdl:input name="ValidateDaysRequest">
        <soap:header message="tns:ValidateDaysRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ValidateDaysRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ValidateDaysRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ValidateDaysResponse">
        <soap:header message="tns:ValidateDaysResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ValidateDaysResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ValidateDaysResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ValidateDaysResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultRecurrence">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultRecurrence" style="document" />
      <wsdl:input name="CreateDefaultRecurrenceRequest">
        <soap:header message="tns:CreateDefaultRecurrenceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultRecurrenceResponse">
        <soap:header message="tns:CreateDefaultRecurrenceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AssignTo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/AssignTo" style="document" />
      <wsdl:input name="AssignToRequest">
        <soap:header message="tns:AssignToRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AssignToRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AssignToRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AssignToResponse">
        <soap:header message="tns:AssignToResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AssignToResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AssignToResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AssignToResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetSeen">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/SetSeen" style="document" />
      <wsdl:input name="SetSeenRequest">
        <soap:header message="tns:SetSeenRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetSeenRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetSeenRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetSeenResponse">
        <soap:header message="tns:SetSeenResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetSeenResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetSeenResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetSeenResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Move">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/Move" style="document" />
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
    <wsdl:operation name="AcceptRejected">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/AcceptRejected" style="document" />
      <wsdl:input name="AcceptRejectedRequest">
        <soap:header message="tns:AcceptRejectedRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AcceptRejectedRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AcceptRejectedRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AcceptRejectedResponse">
        <soap:header message="tns:AcceptRejectedResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AcceptRejectedResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AcceptRejectedResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AcceptRejectedResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultRecurrenceByDate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultRecurrenceByDate" style="document" />
      <wsdl:input name="CreateDefaultRecurrenceByDateRequest">
        <soap:header message="tns:CreateDefaultRecurrenceByDateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceByDateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceByDateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultRecurrenceByDateResponse">
        <soap:header message="tns:CreateDefaultRecurrenceByDateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceByDateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceByDateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceByDateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CleanUpBookingDeleted">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CleanUpBookingDeleted" style="document" />
      <wsdl:input name="CleanUpBookingDeletedRequest">
        <soap:header message="tns:CleanUpBookingDeletedRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CleanUpBookingDeletedRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CleanUpBookingDeletedRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CleanUpBookingDeletedResponse">
        <soap:header message="tns:CleanUpBookingDeletedResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CleanUpBookingDeletedResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CleanUpBookingDeletedResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CleanUpBookingDeletedResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAppointmentEntityByTypeAndAssociate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate" style="document" />
      <wsdl:input name="CreateDefaultAppointmentEntityByTypeAndAssociateRequest">
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeAndAssociateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeAndAssociateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeAndAssociateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultAppointmentEntityByTypeAndAssociateResponse">
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeAndAssociateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeAndAssociateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeAndAssociateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeAndAssociateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCanInsertForAssociates">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetCanInsertForAssociates" style="document" />
      <wsdl:input name="GetCanInsertForAssociatesRequest">
        <soap:header message="tns:GetCanInsertForAssociatesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCanInsertForAssociatesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCanInsertForAssociatesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCanInsertForAssociatesResponse">
        <soap:header message="tns:GetCanInsertForAssociatesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCanInsertForAssociatesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCanInsertForAssociatesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCanInsertForAssociatesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentHaveParticipantsWithEmail">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAppointmentHaveParticipantsWithEmail" style="document" />
      <wsdl:input name="GetAppointmentHaveParticipantsWithEmailRequest">
        <soap:header message="tns:GetAppointmentHaveParticipantsWithEmailRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAppointmentHaveParticipantsWithEmailRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAppointmentHaveParticipantsWithEmailRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAppointmentHaveParticipantsWithEmailResponse">
        <soap:header message="tns:GetAppointmentHaveParticipantsWithEmailResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAppointmentHaveParticipantsWithEmailResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAppointmentHaveParticipantsWithEmailResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAppointmentHaveParticipantsWithEmailResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAppointmentEntityFromSaleSuggestion">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultAppointmentEntityFromSaleSuggestion" style="document" />
      <wsdl:input name="CreateDefaultAppointmentEntityFromSaleSuggestionRequest">
        <soap:header message="tns:CreateDefaultAppointmentEntityFromSaleSuggestionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromSaleSuggestionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromSaleSuggestionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultAppointmentEntityFromSaleSuggestionResponse">
        <soap:header message="tns:CreateDefaultAppointmentEntityFromSaleSuggestionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromSaleSuggestionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromSaleSuggestionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromSaleSuggestionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNextSuggestedAppointmentBySale">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetNextSuggestedAppointmentBySale" style="document" />
      <wsdl:input name="GetNextSuggestedAppointmentBySaleRequest">
        <soap:header message="tns:GetNextSuggestedAppointmentBySaleRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNextSuggestedAppointmentBySaleRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNextSuggestedAppointmentBySaleRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNextSuggestedAppointmentBySaleResponse">
        <soap:header message="tns:GetNextSuggestedAppointmentBySaleResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNextSuggestedAppointmentBySaleResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNextSuggestedAppointmentBySaleResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNextSuggestedAppointmentBySaleResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultReOpenAppointment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultReOpenAppointment" style="document" />
      <wsdl:input name="CreateDefaultReOpenAppointmentRequest">
        <soap:header message="tns:CreateDefaultReOpenAppointmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultReOpenAppointmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultReOpenAppointmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultReOpenAppointmentResponse">
        <soap:header message="tns:CreateDefaultReOpenAppointmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultReOpenAppointmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultReOpenAppointmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultReOpenAppointmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAppointmentEntityFromProjectSuggestion">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CreateDefaultAppointmentEntityFromProjectSuggestion" style="document" />
      <wsdl:input name="CreateDefaultAppointmentEntityFromProjectSuggestionRequest">
        <soap:header message="tns:CreateDefaultAppointmentEntityFromProjectSuggestionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromProjectSuggestionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromProjectSuggestionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultAppointmentEntityFromProjectSuggestionResponse">
        <soap:header message="tns:CreateDefaultAppointmentEntityFromProjectSuggestionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromProjectSuggestionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromProjectSuggestionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromProjectSuggestionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CanAssignToProjectMember">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/CanAssignToProjectMember" style="document" />
      <wsdl:input name="CanAssignToProjectMemberRequest">
        <soap:header message="tns:CanAssignToProjectMemberRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CanAssignToProjectMemberRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CanAssignToProjectMemberRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CanAssignToProjectMemberResponse">
        <soap:header message="tns:CanAssignToProjectMemberResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CanAssignToProjectMemberResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CanAssignToProjectMemberResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CanAssignToProjectMemberResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAppointmentList" style="document" />
      <wsdl:input name="GetAppointmentListRequest">
        <soap:header message="tns:GetAppointmentListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAppointmentListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAppointmentListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAppointmentListResponse">
        <soap:header message="tns:GetAppointmentListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAppointmentListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAppointmentListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAppointmentListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyAppointments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetMyAppointments" style="document" />
      <wsdl:input name="GetMyAppointmentsRequest">
        <soap:header message="tns:GetMyAppointmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyAppointmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyAppointmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyAppointmentsResponse">
        <soap:header message="tns:GetMyAppointmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyAppointmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyAppointmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyAppointmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonAppointments" style="document" />
      <wsdl:input name="GetPersonAppointmentsRequest">
        <soap:header message="tns:GetPersonAppointmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonAppointmentsResponse">
        <soap:header message="tns:GetPersonAppointmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyDiary">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetMyDiary" style="document" />
      <wsdl:input name="GetMyDiaryRequest">
        <soap:header message="tns:GetMyDiaryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyDiaryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyDiaryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyDiaryResponse">
        <soap:header message="tns:GetMyDiaryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyDiaryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyDiaryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyDiaryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyTasks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetMyTasks" style="document" />
      <wsdl:input name="GetMyTasksRequest">
        <soap:header message="tns:GetMyTasksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyTasksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyTasksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyTasksResponse">
        <soap:header message="tns:GetMyTasksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyTasksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyTasksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyTasksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonDiary">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonDiary" style="document" />
      <wsdl:input name="GetPersonDiaryRequest">
        <soap:header message="tns:GetPersonDiaryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonDiaryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonDiaryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonDiaryResponse">
        <soap:header message="tns:GetPersonDiaryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonDiaryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonDiaryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonDiaryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonTasks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonTasks" style="document" />
      <wsdl:input name="GetPersonTasksRequest">
        <soap:header message="tns:GetPersonTasksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonTasksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonTasksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonTasksResponse">
        <soap:header message="tns:GetPersonTasksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonTasksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonTasksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonTasksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointmentsByType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonAppointmentsByType" style="document" />
      <wsdl:input name="GetPersonAppointmentsByTypeRequest">
        <soap:header message="tns:GetPersonAppointmentsByTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonAppointmentsByTypeResponse">
        <soap:header message="tns:GetPersonAppointmentsByTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectAppointments" style="document" />
      <wsdl:input name="GetProjectAppointmentsRequest">
        <soap:header message="tns:GetProjectAppointmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectAppointmentsResponse">
        <soap:header message="tns:GetProjectAppointmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointmentsByType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectAppointmentsByType" style="document" />
      <wsdl:input name="GetProjectAppointmentsByTypeRequest">
        <soap:header message="tns:GetProjectAppointmentsByTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectAppointmentsByTypeResponse">
        <soap:header message="tns:GetProjectAppointmentsByTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetContactAppointments" style="document" />
      <wsdl:input name="GetContactAppointmentsRequest">
        <soap:header message="tns:GetContactAppointmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactAppointmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactAppointmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactAppointmentsResponse">
        <soap:header message="tns:GetContactAppointmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactAppointmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointmentsByType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetContactAppointmentsByType" style="document" />
      <wsdl:input name="GetContactAppointmentsByTypeRequest">
        <soap:header message="tns:GetContactAppointmentsByTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactAppointmentsByTypeResponse">
        <soap:header message="tns:GetContactAppointmentsByTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectMemberAppointments" style="document" />
      <wsdl:input name="GetProjectMemberAppointmentsRequest">
        <soap:header message="tns:GetProjectMemberAppointmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectMemberAppointmentsResponse">
        <soap:header message="tns:GetProjectMemberAppointmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointmentsByType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectMemberAppointmentsByType" style="document" />
      <wsdl:input name="GetProjectMemberAppointmentsByTypeRequest">
        <soap:header message="tns:GetProjectMemberAppointmentsByTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectMemberAppointmentsByTypeResponse">
        <soap:header message="tns:GetProjectMemberAppointmentsByTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointmentsByTask">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonAppointmentsByTask" style="document" />
      <wsdl:input name="GetPersonAppointmentsByTaskRequest">
        <soap:header message="tns:GetPersonAppointmentsByTaskRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonAppointmentsByTaskResponse">
        <soap:header message="tns:GetPersonAppointmentsByTaskResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointmentsByTasks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonAppointmentsByTasks" style="document" />
      <wsdl:input name="GetPersonAppointmentsByTasksRequest">
        <soap:header message="tns:GetPersonAppointmentsByTasksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTasksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTasksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonAppointmentsByTasksResponse">
        <soap:header message="tns:GetPersonAppointmentsByTasksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTasksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTasksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTasksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointmentsByTaskHeading">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPersonAppointmentsByTaskHeading" style="document" />
      <wsdl:input name="GetPersonAppointmentsByTaskHeadingRequest">
        <soap:header message="tns:GetPersonAppointmentsByTaskHeadingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskHeadingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskHeadingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonAppointmentsByTaskHeadingResponse">
        <soap:header message="tns:GetPersonAppointmentsByTaskHeadingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskHeadingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskHeadingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskHeadingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointmentsByTask">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectAppointmentsByTask" style="document" />
      <wsdl:input name="GetProjectAppointmentsByTaskRequest">
        <soap:header message="tns:GetProjectAppointmentsByTaskRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectAppointmentsByTaskResponse">
        <soap:header message="tns:GetProjectAppointmentsByTaskResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointmentsByTasks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectAppointmentsByTasks" style="document" />
      <wsdl:input name="GetProjectAppointmentsByTasksRequest">
        <soap:header message="tns:GetProjectAppointmentsByTasksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTasksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTasksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectAppointmentsByTasksResponse">
        <soap:header message="tns:GetProjectAppointmentsByTasksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTasksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTasksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTasksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointmentsByTaskHeading">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectAppointmentsByTaskHeading" style="document" />
      <wsdl:input name="GetProjectAppointmentsByTaskHeadingRequest">
        <soap:header message="tns:GetProjectAppointmentsByTaskHeadingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskHeadingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskHeadingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectAppointmentsByTaskHeadingResponse">
        <soap:header message="tns:GetProjectAppointmentsByTaskHeadingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskHeadingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskHeadingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskHeadingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointmentsByTask">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectMemberAppointmentsByTask" style="document" />
      <wsdl:input name="GetProjectMemberAppointmentsByTaskRequest">
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectMemberAppointmentsByTaskResponse">
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointmentsByTasks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectMemberAppointmentsByTasks" style="document" />
      <wsdl:input name="GetProjectMemberAppointmentsByTasksRequest">
        <soap:header message="tns:GetProjectMemberAppointmentsByTasksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTasksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTasksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectMemberAppointmentsByTasksResponse">
        <soap:header message="tns:GetProjectMemberAppointmentsByTasksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTasksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTasksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTasksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointmentsByTaskHeading">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetProjectMemberAppointmentsByTaskHeading" style="document" />
      <wsdl:input name="GetProjectMemberAppointmentsByTaskHeadingRequest">
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskHeadingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskHeadingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskHeadingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectMemberAppointmentsByTaskHeadingResponse">
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskHeadingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskHeadingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskHeadingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskHeadingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointmentsByTask">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetContactAppointmentsByTask" style="document" />
      <wsdl:input name="GetContactAppointmentsByTaskRequest">
        <soap:header message="tns:GetContactAppointmentsByTaskRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactAppointmentsByTaskResponse">
        <soap:header message="tns:GetContactAppointmentsByTaskResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointmentsByTasks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetContactAppointmentsByTasks" style="document" />
      <wsdl:input name="GetContactAppointmentsByTasksRequest">
        <soap:header message="tns:GetContactAppointmentsByTasksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTasksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTasksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactAppointmentsByTasksResponse">
        <soap:header message="tns:GetContactAppointmentsByTasksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTasksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTasksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTasksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointmentsByTaskHeading">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetContactAppointmentsByTaskHeading" style="document" />
      <wsdl:input name="GetContactAppointmentsByTaskHeadingRequest">
        <soap:header message="tns:GetContactAppointmentsByTaskHeadingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskHeadingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskHeadingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactAppointmentsByTaskHeadingResponse">
        <soap:header message="tns:GetContactAppointmentsByTaskHeadingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskHeadingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskHeadingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskHeadingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPublishedAppointment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPublishedAppointment" style="document" />
      <wsdl:input name="GetPublishedAppointmentRequest">
        <soap:header message="tns:GetPublishedAppointmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPublishedAppointmentResponse">
        <soap:header message="tns:GetPublishedAppointmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPublishedAppointments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPublishedAppointments" style="document" />
      <wsdl:input name="GetPublishedAppointmentsRequest">
        <soap:header message="tns:GetPublishedAppointmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPublishedAppointmentsResponse">
        <soap:header message="tns:GetPublishedAppointmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyPublishedAppointments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetMyPublishedAppointments" style="document" />
      <wsdl:input name="GetMyPublishedAppointmentsRequest">
        <soap:header message="tns:GetMyPublishedAppointmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyPublishedAppointmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyPublishedAppointmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyPublishedAppointmentsResponse">
        <soap:header message="tns:GetMyPublishedAppointmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyPublishedAppointmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyPublishedAppointmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyPublishedAppointmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPublishedProjectAppointments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetPublishedProjectAppointments" style="document" />
      <wsdl:input name="GetPublishedProjectAppointmentsRequest">
        <soap:header message="tns:GetPublishedProjectAppointmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPublishedProjectAppointmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPublishedProjectAppointmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPublishedProjectAppointmentsResponse">
        <soap:header message="tns:GetPublishedProjectAppointmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPublishedProjectAppointmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPublishedProjectAppointmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPublishedProjectAppointmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentsByTaskHeading">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAppointmentsByTaskHeading" style="document" />
      <wsdl:input name="GetAppointmentsByTaskHeadingRequest">
        <soap:header message="tns:GetAppointmentsByTaskHeadingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAppointmentsByTaskHeadingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAppointmentsByTaskHeadingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAppointmentsByTaskHeadingResponse">
        <soap:header message="tns:GetAppointmentsByTaskHeadingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAppointmentsByTaskHeadingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAppointmentsByTaskHeadingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAppointmentsByTaskHeadingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAssociateDiary">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAssociateDiary" style="document" />
      <wsdl:input name="GetAssociateDiaryRequest">
        <soap:header message="tns:GetAssociateDiaryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAssociateDiaryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAssociateDiaryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAssociateDiaryResponse">
        <soap:header message="tns:GetAssociateDiaryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAssociateDiaryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAssociateDiaryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAssociateDiaryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDiaryByGroup">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetDiaryByGroup" style="document" />
      <wsdl:input name="GetDiaryByGroupRequest">
        <soap:header message="tns:GetDiaryByGroupRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDiaryByGroupRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDiaryByGroupRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDiaryByGroupResponse">
        <soap:header message="tns:GetDiaryByGroupResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDiaryByGroupResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDiaryByGroupResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDiaryByGroupResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateAppointment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/UpdateAppointment" style="document" />
      <wsdl:input name="UpdateAppointmentRequest">
        <soap:header message="tns:UpdateAppointmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateAppointmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateAppointmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateAppointmentResponse">
        <soap:header message="tns:UpdateAppointmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateAppointmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateAppointmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateAppointmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAssociatesDiary">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAssociatesDiary" style="document" />
      <wsdl:input name="GetAssociatesDiaryRequest">
        <soap:header message="tns:GetAssociatesDiaryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAssociatesDiaryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAssociatesDiaryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAssociatesDiaryResponse">
        <soap:header message="tns:GetAssociatesDiaryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAssociatesDiaryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAssociatesDiaryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAssociatesDiaryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentRecords">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAppointmentRecords" style="document" />
      <wsdl:input name="GetAppointmentRecordsRequest">
        <soap:header message="tns:GetAppointmentRecordsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAppointmentRecordsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAppointmentRecordsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAppointmentRecordsResponse">
        <soap:header message="tns:GetAppointmentRecordsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAppointmentRecordsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAppointmentRecordsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAppointmentRecordsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDayInformationListByDatesAndAssociate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetDayInformationListByDatesAndAssociate" style="document" />
      <wsdl:input name="GetDayInformationListByDatesAndAssociateRequest">
        <soap:header message="tns:GetDayInformationListByDatesAndAssociateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDayInformationListByDatesAndAssociateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDayInformationListByDatesAndAssociateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDayInformationListByDatesAndAssociateResponse">
        <soap:header message="tns:GetDayInformationListByDatesAndAssociateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDayInformationListByDatesAndAssociateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDayInformationListByDatesAndAssociateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDayInformationListByDatesAndAssociateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetActivityInformationListByDatesAndAssociate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetActivityInformationListByDatesAndAssociate" style="document" />
      <wsdl:input name="GetActivityInformationListByDatesAndAssociateRequest">
        <soap:header message="tns:GetActivityInformationListByDatesAndAssociateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetActivityInformationListByDatesAndAssociateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetActivityInformationListByDatesAndAssociateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetActivityInformationListByDatesAndAssociateResponse">
        <soap:header message="tns:GetActivityInformationListByDatesAndAssociateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetActivityInformationListByDatesAndAssociateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetActivityInformationListByDatesAndAssociateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetActivityInformationListByDatesAndAssociateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetRedLetterInformationListByDatesAndAssociate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetRedLetterInformationListByDatesAndAssociate" style="document" />
      <wsdl:input name="GetRedLetterInformationListByDatesAndAssociateRequest">
        <soap:header message="tns:GetRedLetterInformationListByDatesAndAssociateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetRedLetterInformationListByDatesAndAssociateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetRedLetterInformationListByDatesAndAssociateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetRedLetterInformationListByDatesAndAssociateResponse">
        <soap:header message="tns:GetRedLetterInformationListByDatesAndAssociateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetRedLetterInformationListByDatesAndAssociateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetRedLetterInformationListByDatesAndAssociateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetRedLetterInformationListByDatesAndAssociateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAlarms">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetAlarms" style="document" />
      <wsdl:input name="GetAlarmsRequest">
        <soap:header message="tns:GetAlarmsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAlarmsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAlarmsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAlarmsResponse">
        <soap:header message="tns:GetAlarmsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAlarmsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAlarmsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAlarmsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GenerateLead">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GenerateLead" style="document" />
      <wsdl:input name="GenerateLeadRequest">
        <soap:header message="tns:GenerateLeadRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GenerateLeadRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GenerateLeadRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GenerateLeadResponse">
        <soap:header message="tns:GenerateLeadResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GenerateLeadResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GenerateLeadResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GenerateLeadResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RequestForInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/RequestForInfo" style="document" />
      <wsdl:input name="RequestForInfoRequest">
        <soap:header message="tns:RequestForInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RequestForInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RequestForInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RequestForInfoResponse">
        <soap:header message="tns:RequestForInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RequestForInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RequestForInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RequestForInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSuggestedAppointment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetSuggestedAppointment" style="document" />
      <wsdl:input name="GetSuggestedAppointmentRequest">
        <soap:header message="tns:GetSuggestedAppointmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSuggestedAppointmentResponse">
        <soap:header message="tns:GetSuggestedAppointmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSuggestedAppointmentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetSuggestedAppointmentEntity" style="document" />
      <wsdl:input name="GetSuggestedAppointmentEntityRequest">
        <soap:header message="tns:GetSuggestedAppointmentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSuggestedAppointmentEntityResponse">
        <soap:header message="tns:GetSuggestedAppointmentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTaskListItem">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetTaskListItem" style="document" />
      <wsdl:input name="GetTaskListItemRequest">
        <soap:header message="tns:GetTaskListItemRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTaskListItemRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTaskListItemRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTaskListItemResponse">
        <soap:header message="tns:GetTaskListItemResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTaskListItemResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTaskListItemResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTaskListItemResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTaskListItems">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Appointment/GetTaskListItems" style="document" />
      <wsdl:input name="GetTaskListItemsRequest">
        <soap:header message="tns:GetTaskListItemsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTaskListItemsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTaskListItemsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTaskListItemsResponse">
        <soap:header message="tns:GetTaskListItemsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTaskListItemsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTaskListItemsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTaskListItemsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfAppointmentService">
    <wsdl:port name="BasicHttpBinding_Appointment" binding="tns:BasicHttpBinding_Appointment">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services81/Appointment.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

