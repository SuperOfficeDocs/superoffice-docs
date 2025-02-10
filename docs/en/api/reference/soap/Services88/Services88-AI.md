---
generated: true
uid: wsdl-Services88-AI
title: Services88.AIAgent WSDL
---

# Services88.AIAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfAIService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:ser="http://schemas.microsoft.com/2003/10/Serialization/">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="SummarizeText">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PercentSmaller" type="xs:int" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
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
      <xs:element name="SummarizeTextResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SoExceptionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="StackTrace" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FriendlyText" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ExceptionType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="InnerException" nillable="true" type="q5:SoExceptionInfo" xmlns:q5="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Parameters" nillable="true" type="q6:SoExceptionInfoParameters" xmlns:q6="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExceptionInfo" nillable="true" type="q7:SoExceptionInfo" xmlns:q7="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="SoExceptionInfoParameters" nillable="true" type="q8:SoExceptionInfoParameters" xmlns:q8="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ExceptionInfo" nillable="true" type="q9:SoExceptionInfo" xmlns:q9="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="SoExtraInfo" nillable="true" type="q10:SoExtraInfo" xmlns:q10="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ExtraInfo" nillable="true" type="q11:SoExtraInfo" xmlns:q11="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="Succeeded" type="xs:boolean" />
      <xs:element name="ExpandText">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PercentBigger" type="xs:int" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExpandTextResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RephraseText">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Style" type="q12:AiTextStyle" xmlns:q12="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="AiTextStyle">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Rephrase" />
          <xs:enumeration value="Correct" />
          <xs:enumeration value="Casual" />
          <xs:enumeration value="Formal" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="AiTextStyle" nillable="true" type="q13:AiTextStyle" xmlns:q13="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="RephraseTextResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTextForAppointment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Appointment" nillable="true" type="q14:AppointmentEntity" xmlns:q14="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="AppointmentEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q15:Carrier" xmlns:q15="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Associate" nillable="true" type="q15:Associate" />
              <xs:element minOccurs="0" name="Contact" nillable="true" type="q15:Contact" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="q15:Associate" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="q15:Associate" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Agenda" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="InternalNotes" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="InvitedPerson" nillable="true" type="q15:Person" />
              <xs:element minOccurs="0" name="Person" nillable="true" type="q15:Person" />
              <xs:element minOccurs="0" name="MotherId" type="xs:int" />
              <xs:element minOccurs="0" name="Priority" nillable="true" type="q15:Priority" />
              <xs:element minOccurs="0" name="Private" type="q15:AppointmentPrivate" />
              <xs:element minOccurs="0" name="Project" nillable="true" type="q15:Project" />
              <xs:element minOccurs="0" name="Type" type="q15:AppointmentType" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Completed" type="q15:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveLinks" type="xs:int" />
              <xs:element minOccurs="0" name="Links" nillable="true" type="q15:ArrayOfLink" />
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
              <xs:element minOccurs="0" name="Recurrence" nillable="true" type="q15:RecurrenceInfo" />
              <xs:element minOccurs="0" name="Participants" nillable="true" type="q15:ArrayOfParticipantInfo" />
              <xs:element minOccurs="0" name="AssignmentStatus" type="q15:AssignmentStatus" />
              <xs:element minOccurs="0" name="InvitationStatus" type="q15:InvitationStatus" />
              <xs:element minOccurs="0" name="BookingType" type="q15:BookingType" />
              <xs:element minOccurs="0" name="ActiveDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="HasConflict" type="xs:boolean" />
              <xs:element minOccurs="0" name="AssignedBy" nillable="true" type="q15:Associate" />
              <xs:element minOccurs="0" name="MotherAssociate" nillable="true" type="q15:Associate" />
              <xs:element minOccurs="0" name="Task" nillable="true" type="q15:TaskListItem" />
              <xs:element minOccurs="0" name="PreferredTZLocation" type="xs:int" />
              <xs:element minOccurs="0" name="PreferredTZLocationData" nillable="true" type="q15:TimeZoneData" />
              <xs:element minOccurs="0" name="Sale" nillable="true" type="q15:Sale" />
              <xs:element minOccurs="0" name="SuggestedAppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="IsMileStone" type="xs:boolean" />
              <xs:element minOccurs="0" name="CautionWarning" type="q15:AppointmentCautionWarning" />
              <xs:element minOccurs="0" name="JoinVideomeetUrl" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CentralserviceVideomeetId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserDefinedFields" nillable="true" type="q15:StringDictionary" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="q15:StringDictionary" />
              <xs:element minOccurs="0" name="CustomFields" nillable="true" type="q15:StringDictionary" />
              <xs:element minOccurs="0" name="PublishEventDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishTo" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishFrom" type="xs:dateTime" />
              <xs:element minOccurs="0" name="IsPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="VisibleFor" nillable="true" type="q15:ArrayOfVisibleFor" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AppointmentEntity" nillable="true" type="q16:AppointmentEntity" xmlns:q16="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Carrier">
        <xs:sequence>
          <xs:element minOccurs="0" name="TableRight" nillable="true" type="q17:TableRight" xmlns:q17="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="FieldProperties" nillable="true" type="q18:FieldPropertyDictionary" xmlns:q18="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="Carrier" nillable="true" type="q19:Carrier" xmlns:q19="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TableRight">
        <xs:sequence>
          <xs:element minOccurs="0" name="Mask" type="q20:ETableRight" xmlns:q20="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TableRight" nillable="true" type="q21:TableRight" xmlns:q21="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="ETableRight" nillable="true" type="q22:ETableRight" xmlns:q22="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
                <xs:element name="Value" nillable="true" type="q23:FieldProperty" xmlns:q23="http://www.superoffice.net/ws/crm/NetServer/Services88" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldPropertyDictionary" nillable="true" type="q24:FieldPropertyDictionary" xmlns:q24="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="FieldProperty">
        <xs:sequence>
          <xs:element minOccurs="0" name="FieldRight" nillable="true" type="q25:FieldRight" xmlns:q25="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="FieldType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FieldLength" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldProperty" nillable="true" type="q26:FieldProperty" xmlns:q26="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="FieldRight">
        <xs:sequence>
          <xs:element minOccurs="0" name="Mask" type="q27:EFieldRight" xmlns:q27="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldRight" nillable="true" type="q28:FieldRight" xmlns:q28="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="EFieldRight" nillable="true" type="q29:EFieldRight" xmlns:q29="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Associate">
        <xs:complexContent mixed="false">
          <xs:extension base="q30:Carrier" xmlns:q30="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Type" type="q30:UserType" />
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
      <xs:element name="Associate" nillable="true" type="q31:Associate" xmlns:q31="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="UserType" nillable="true" type="q32:UserType" xmlns:q32="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Contact">
        <xs:complexContent mixed="false">
          <xs:extension base="q33:Carrier" xmlns:q33="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
              <xs:element minOccurs="0" name="Address" nillable="true" type="q33:Address" />
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
      <xs:element name="Contact" nillable="true" type="q34:Contact" xmlns:q34="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Address">
        <xs:complexContent mixed="false">
          <xs:extension base="q35:Carrier" xmlns:q35="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Wgs84Latitude" type="xs:double" />
              <xs:element minOccurs="0" name="Wgs84Longitude" type="xs:double" />
              <xs:element minOccurs="0" name="LocalizedAddress" nillable="true" type="q35:ArrayOfArrayOfLocalizedField" />
              <xs:element minOccurs="0" name="Street" nillable="true" type="q35:StructuredAddress" />
              <xs:element minOccurs="0" name="Postal" nillable="true" type="q35:StructuredAddress" />
              <xs:element minOccurs="0" name="Formatted" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Address" nillable="true" type="q36:Address" xmlns:q36="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArrayOfLocalizedField" nillable="true" type="q37:ArrayOfLocalizedField" xmlns:q37="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArrayOfLocalizedField" nillable="true" type="q38:ArrayOfArrayOfLocalizedField" xmlns:q38="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="LocalizedField" nillable="true" type="q39:LocalizedField" xmlns:q39="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLocalizedField" nillable="true" type="q40:ArrayOfLocalizedField" xmlns:q40="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="LocalizedField">
        <xs:complexContent mixed="false">
          <xs:extension base="q41:Carrier" xmlns:q41="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="LocalizedField" nillable="true" type="q42:LocalizedField" xmlns:q42="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="StructuredAddress">
        <xs:sequence>
          <xs:element minOccurs="0" name="AtypeIdx" type="q43:AddressType" xmlns:q43="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="StructuredAddress" nillable="true" type="q44:StructuredAddress" xmlns:q44="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AddressType" nillable="true" type="q45:AddressType" xmlns:q45="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Person">
        <xs:complexContent mixed="false">
          <xs:extension base="q46:Carrier" xmlns:q46="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="Person" nillable="true" type="q47:Person" xmlns:q47="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Priority">
        <xs:complexContent mixed="false">
          <xs:extension base="q48:Carrier" xmlns:q48="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Priority" nillable="true" type="q49:Priority" xmlns:q49="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AppointmentPrivate" nillable="true" type="q50:AppointmentPrivate" xmlns:q50="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Project">
        <xs:complexContent mixed="false">
          <xs:extension base="q51:Carrier" xmlns:q51="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="Project" nillable="true" type="q52:Project" xmlns:q52="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AppointmentType" nillable="true" type="q53:AppointmentType" xmlns:q53="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="ActivityStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="NotStarted" />
          <xs:enumeration value="Started" />
          <xs:enumeration value="Completed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ActivityStatus" nillable="true" type="q54:ActivityStatus" xmlns:q54="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfLink">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Link" nillable="true" type="q55:Link" xmlns:q55="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLink" nillable="true" type="q56:ArrayOfLink" xmlns:q56="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Link">
        <xs:complexContent mixed="false">
          <xs:extension base="q57:Carrier" xmlns:q57="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="Link" nillable="true" type="q58:Link" xmlns:q58="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="RecurrenceId" type="xs:int" />
          <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="RecurrenceEndType" type="q59:RecurrenceEndType" xmlns:q59="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Pattern" type="q60:RecurrencePattern" xmlns:q60="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="DayPattern" nillable="true" type="q61:RecurrenceDayPattern" xmlns:q61="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="WeekPattern" nillable="true" type="q62:RecurrenceWeekPattern" xmlns:q62="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="MonthPattern" nillable="true" type="q63:RecurrenceMonthPattern" xmlns:q63="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="YearPattern" nillable="true" type="q64:RecurrenceYearPattern" xmlns:q64="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Dates" nillable="true" type="q65:ArrayOfRecurrenceDate" xmlns:q65="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="RecurrenceCounter" type="xs:int" />
          <xs:element minOccurs="0" name="IsRecurrence" type="xs:boolean" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceInfo" nillable="true" type="q66:RecurrenceInfo" xmlns:q66="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="RecurrenceEndType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="EndDate" />
          <xs:enumeration value="Counter" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrenceEndType" nillable="true" type="q67:RecurrenceEndType" xmlns:q67="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="RecurrencePattern" nillable="true" type="q68:RecurrencePattern" xmlns:q68="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceDayPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Pattern" type="q69:RecurrenceDailyPattern" xmlns:q69="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceDayPattern" nillable="true" type="q70:RecurrenceDayPattern" xmlns:q70="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="RecurrenceDailyPattern">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="EveryWorkday" />
          <xs:enumeration value="EveryWeekday" />
          <xs:enumeration value="EveryCyclicDay" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrenceDailyPattern" nillable="true" type="q71:RecurrenceDailyPattern" xmlns:q71="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceWeekPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Weekdays" type="q72:Weekday" xmlns:q72="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceWeekPattern" nillable="true" type="q73:RecurrenceWeekPattern" xmlns:q73="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="Weekday">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
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
      <xs:element name="Weekday" nillable="true" type="q74:Weekday" xmlns:q74="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceMonthPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Day" type="xs:int" />
          <xs:element minOccurs="0" name="Weekday" type="q75:Weekday" xmlns:q75="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="WeekOfMonth" type="q76:WeekOfMonth" xmlns:q76="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Pattern" type="q77:RecurrenceMonthlyPattern" xmlns:q77="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceMonthPattern" nillable="true" type="q78:RecurrenceMonthPattern" xmlns:q78="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="WeekOfMonth" nillable="true" type="q79:WeekOfMonth" xmlns:q79="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="RecurrenceMonthlyPattern" nillable="true" type="q80:RecurrenceMonthlyPattern" xmlns:q80="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceYearPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Day" type="xs:int" />
          <xs:element minOccurs="0" name="Weekday" type="q81:Weekday" xmlns:q81="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="WeekOfMonth" type="q82:WeekOfMonth" xmlns:q82="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Pattern" type="q83:RecurrenceYearlyPattern" xmlns:q83="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceYearPattern" nillable="true" type="q84:RecurrenceYearPattern" xmlns:q84="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="RecurrenceYearlyPattern" nillable="true" type="q85:RecurrenceYearlyPattern" xmlns:q85="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfRecurrenceDate">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="RecurrenceDate" nillable="true" type="q86:RecurrenceDate" xmlns:q86="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfRecurrenceDate" nillable="true" type="q87:ArrayOfRecurrenceDate" xmlns:q87="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceDate">
        <xs:sequence>
          <xs:element minOccurs="0" name="Date" type="xs:dateTime" />
          <xs:element minOccurs="0" name="IsConflict" type="xs:boolean" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DescriptionStyleHint" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceDate" nillable="true" type="q88:RecurrenceDate" xmlns:q88="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfParticipantInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ParticipantInfo" nillable="true" type="q89:ParticipantInfo" xmlns:q89="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfParticipantInfo" nillable="true" type="q90:ArrayOfParticipantInfo" xmlns:q90="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ParticipantInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          <xs:element minOccurs="0" name="EmailId" type="xs:int" />
          <xs:element minOccurs="0" name="SendEmail" type="xs:boolean" />
          <xs:element minOccurs="0" name="InvitationStatus" type="q91:InvitationStatus" xmlns:q91="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ParticipantInfo" nillable="true" type="q92:ParticipantInfo" xmlns:q92="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="InvitationStatus" nillable="true" type="q93:InvitationStatus" xmlns:q93="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AssignmentStatus" nillable="true" type="q94:AssignmentStatus" xmlns:q94="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="BookingType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="None" />
          <xs:enumeration value="Owner" />
          <xs:enumeration value="Participant" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="BookingType" nillable="true" type="q95:BookingType" xmlns:q95="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TaskListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q96:Carrier" xmlns:q96="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="TaskListItemId" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Direction" type="q96:TaskDirection" />
              <xs:element minOccurs="0" name="Type" type="q96:TaskType" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="IntentId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="IsDefaultAlldayEvent" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsDefaultFree" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsDefaultPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="ColorIndex" type="q96:ColorIndex" />
              <xs:element minOccurs="0" name="DefaultVideomeetingStatus" type="q96:VideoMeetingStatus" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TaskListItem" nillable="true" type="q97:TaskListItem" xmlns:q97="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="TaskDirection" nillable="true" type="q98:TaskDirection" xmlns:q98="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="TaskType" nillable="true" type="q99:TaskType" xmlns:q99="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
          <xs:enumeration value="BlueAlt1" />
          <xs:enumeration value="BlueAlt2" />
          <xs:enumeration value="BlueAlt3" />
          <xs:enumeration value="GrayAlt1" />
          <xs:enumeration value="GrayAlt2" />
          <xs:enumeration value="GrayAlt3" />
          <xs:enumeration value="GreenAlt1" />
          <xs:enumeration value="GreenAlt2" />
          <xs:enumeration value="GreenAlt3" />
          <xs:enumeration value="YellowAlt1" />
          <xs:enumeration value="YellowAlt2" />
          <xs:enumeration value="YellowAlt3" />
          <xs:enumeration value="RedAlt1" />
          <xs:enumeration value="RedAlt2" />
          <xs:enumeration value="RedAlt3" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ColorIndex" nillable="true" type="q100:ColorIndex" xmlns:q100="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="VideoMeetingStatus">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="NoChange" />
          <xs:enumeration value="VideoMeetingOn" />
          <xs:enumeration value="VideoMeetingOff" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="VideoMeetingStatus" nillable="true" type="q101:VideoMeetingStatus" xmlns:q101="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TimeZoneData">
        <xs:sequence>
          <xs:element minOccurs="0" name="TZLocationID" type="xs:int" />
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="TZLocationCode" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="TZLocationCities" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="IsoNumber" type="xs:int" />
          <xs:element minOccurs="0" name="TimeZoneSTDRules" nillable="true" type="q102:TimeZoneRuleDictionary" xmlns:q102="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="TimeZoneDSTRules" nillable="true" type="q103:TimeZoneRuleDictionary" xmlns:q103="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TimeZoneData" nillable="true" type="q104:TimeZoneData" xmlns:q104="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
                <xs:element name="Value" nillable="true" type="q105:TimeZoneRule" xmlns:q105="http://www.superoffice.net/ws/crm/NetServer/Services88" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TimeZoneRuleDictionary" nillable="true" type="q106:TimeZoneRuleDictionary" xmlns:q106="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="TimeZoneRule" nillable="true" type="q107:TimeZoneRule" xmlns:q107="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Sale">
        <xs:complexContent mixed="false">
          <xs:extension base="q108:Carrier" xmlns:q108="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
              <xs:element minOccurs="0" name="Status" type="q108:SaleStatus" />
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
              <xs:element minOccurs="0" name="Completed" type="q108:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="NextDueDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Number" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Sale" nillable="true" type="q109:Sale" xmlns:q109="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="SaleStatus" nillable="true" type="q110:SaleStatus" xmlns:q110="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="AppointmentCautionWarning">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="OK" />
          <xs:enumeration value="NotInSync" />
          <xs:enumeration value="NotNotifiedByEmail" />
          <xs:enumeration value="RecurrencePatternNotSupported" />
          <xs:enumeration value="IncomingRecurrenceChangeNotSupported" />
          <xs:enumeration value="ExternalParticipantsDateTimeMismatch" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="AppointmentCautionWarning" nillable="true" type="q111:AppointmentCautionWarning" xmlns:q111="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="StringDictionary" nillable="true" type="q112:StringDictionary" xmlns:q112="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfVisibleFor">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="VisibleFor" nillable="true" type="q113:VisibleFor" xmlns:q113="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfVisibleFor" nillable="true" type="q114:ArrayOfVisibleFor" xmlns:q114="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="VisibleFor">
        <xs:complexContent mixed="false">
          <xs:extension base="q115:Carrier" xmlns:q115="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="VisibleId" type="xs:int" />
              <xs:element minOccurs="0" name="Visibility" type="q115:Visibility" />
              <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="VisibleFor" nillable="true" type="q116:VisibleFor" xmlns:q116="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="Visibility">
        <xs:restriction base="xs:string">
          <xs:enumeration value="All" />
          <xs:enumeration value="Associate" />
          <xs:enumeration value="Group" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="Visibility" nillable="true" type="q117:Visibility" xmlns:q117="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="CreateTextForAppointmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTrainingStatus">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTrainingStatusResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q118:CategorizationStatusResponse" xmlns:q118="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CategorizationStatusResponse">
        <xs:complexContent mixed="false">
          <xs:extension base="q119:Carrier" xmlns:q119="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ContextIdentifier" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Status" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CurrentModel" nillable="true" type="q119:CategorizationModelDetails" />
              <xs:element minOccurs="0" name="PreviousModel" nillable="true" type="q119:CategorizationModelDetails" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CategorizationStatusResponse" nillable="true" type="q120:CategorizationStatusResponse" xmlns:q120="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="CategorizationModelDetails">
        <xs:complexContent mixed="false">
          <xs:extension base="q121:Carrier" xmlns:q121="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ModelBuiltDateTime" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Accuracy" type="xs:double" />
              <xs:element minOccurs="0" name="TicketCountForTraining" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CategorizationModelDetails" nillable="true" type="q122:CategorizationModelDetails" xmlns:q122="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GuessCategory">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GuessCategoryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TrainCategoryGuesser">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="MaxItems" type="xs:int" />
            <xs:element minOccurs="0" name="MaxTextLength" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TrainCategoryGuesserResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatbotResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatId" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="UserPrompt" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PreviousTurns" nillable="true" type="q123:ArrayOfChatbotTurn" xmlns:q123="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="ApiUrl" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfChatbotTurn">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ChatbotTurn" nillable="true" type="q124:ChatbotTurn" xmlns:q124="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfChatbotTurn" nillable="true" type="q125:ArrayOfChatbotTurn" xmlns:q125="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ChatbotTurn">
        <xs:sequence>
          <xs:element minOccurs="0" name="Timestamp" type="xs:dateTime" />
          <xs:element minOccurs="0" name="UserPrompt" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="UserDisplayText" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="BotResponse" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="BotActions" nillable="true" type="q126:StringDictionary" xmlns:q126="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Attachments" nillable="true" type="q127:ArrayOfstring" xmlns:q127="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ChatbotTurn" nillable="true" type="q128:ChatbotTurn" xmlns:q128="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetChatbotResponseResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q129:ChatbotTurn" xmlns:q129="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatbotPromptSuggestions">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="SoProtocol" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="CurrentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatbotPromptSuggestionsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q130:ChatbotTurn" xmlns:q130="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatbotTurns">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatbotTurnsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q131:ArrayOfChatbotTurn" xmlns:q131="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ClearChatbotTurns">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ClearChatbotTurnsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DetectLanguage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DetectLanguageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DetectSentiment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DetectSentimentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q132:Sentiment" xmlns:q132="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Sentiment">
        <xs:complexContent mixed="false">
          <xs:extension base="q133:Carrier" xmlns:q133="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Score" type="xs:int" />
              <xs:element minOccurs="0" name="Confidence" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Sentiment" nillable="true" type="q134:Sentiment" xmlns:q134="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="Translate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TargetLanguage" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TranslateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TranslateEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EntityName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="EntityId" type="xs:int" />
            <xs:element minOccurs="0" name="TargetLanguage" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TranslateEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SummarizeTicket">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketId" type="xs:int" />
            <xs:element minOccurs="0" name="NumSentences" type="xs:int" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SummarizeTicketResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSummarizeTicketPrompt">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketId" type="xs:int" />
            <xs:element minOccurs="0" name="NumSentences" type="xs:int" />
            <xs:element minOccurs="0" name="Summary" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSummarizeTicketPromptResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q135:ChatbotTurn" xmlns:q135="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SummarizeContact">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="NumSentences" type="xs:int" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SummarizeContactResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSummarizeContactPrompt">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="NumSentences" type="xs:int" />
            <xs:element minOccurs="0" name="Summary" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSummarizeContactPromptResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q136:ChatbotTurn" xmlns:q136="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SummarizeSale">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="NumSentences" type="xs:int" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SummarizeSaleResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSummarizeSalePrompt">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="NumSentences" type="xs:int" />
            <xs:element minOccurs="0" name="Summary" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSummarizeSalePromptResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q137:ChatbotTurn" xmlns:q137="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="SummarizeTextRequest">
    <wsdl:part name="parameters" element="tns:SummarizeText" />
  </wsdl:message>
  <wsdl:message name="SummarizeTextRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SummarizeTextResponse">
    <wsdl:part name="parameters" element="tns:SummarizeTextResponse" />
  </wsdl:message>
  <wsdl:message name="SummarizeTextResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExpandTextRequest">
    <wsdl:part name="parameters" element="tns:ExpandText" />
  </wsdl:message>
  <wsdl:message name="ExpandTextRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExpandTextResponse">
    <wsdl:part name="parameters" element="tns:ExpandTextResponse" />
  </wsdl:message>
  <wsdl:message name="ExpandTextResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RephraseTextRequest">
    <wsdl:part name="parameters" element="tns:RephraseText" />
  </wsdl:message>
  <wsdl:message name="RephraseTextRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RephraseTextResponse">
    <wsdl:part name="parameters" element="tns:RephraseTextResponse" />
  </wsdl:message>
  <wsdl:message name="RephraseTextResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTextForAppointmentRequest">
    <wsdl:part name="parameters" element="tns:CreateTextForAppointment" />
  </wsdl:message>
  <wsdl:message name="CreateTextForAppointmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTextForAppointmentResponse">
    <wsdl:part name="parameters" element="tns:CreateTextForAppointmentResponse" />
  </wsdl:message>
  <wsdl:message name="CreateTextForAppointmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTrainingStatusRequest">
    <wsdl:part name="parameters" element="tns:GetTrainingStatus" />
  </wsdl:message>
  <wsdl:message name="GetTrainingStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTrainingStatusResponse">
    <wsdl:part name="parameters" element="tns:GetTrainingStatusResponse" />
  </wsdl:message>
  <wsdl:message name="GetTrainingStatusResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GuessCategoryRequest">
    <wsdl:part name="parameters" element="tns:GuessCategory" />
  </wsdl:message>
  <wsdl:message name="GuessCategoryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GuessCategoryResponse">
    <wsdl:part name="parameters" element="tns:GuessCategoryResponse" />
  </wsdl:message>
  <wsdl:message name="GuessCategoryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TrainCategoryGuesserRequest">
    <wsdl:part name="parameters" element="tns:TrainCategoryGuesser" />
  </wsdl:message>
  <wsdl:message name="TrainCategoryGuesserRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TrainCategoryGuesserResponse">
    <wsdl:part name="parameters" element="tns:TrainCategoryGuesserResponse" />
  </wsdl:message>
  <wsdl:message name="TrainCategoryGuesserResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatbotResponseRequest">
    <wsdl:part name="parameters" element="tns:GetChatbotResponse" />
  </wsdl:message>
  <wsdl:message name="GetChatbotResponseRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatbotResponseResponse">
    <wsdl:part name="parameters" element="tns:GetChatbotResponseResponse" />
  </wsdl:message>
  <wsdl:message name="GetChatbotResponseResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatbotPromptSuggestionsRequest">
    <wsdl:part name="parameters" element="tns:GetChatbotPromptSuggestions" />
  </wsdl:message>
  <wsdl:message name="GetChatbotPromptSuggestionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatbotPromptSuggestionsResponse">
    <wsdl:part name="parameters" element="tns:GetChatbotPromptSuggestionsResponse" />
  </wsdl:message>
  <wsdl:message name="GetChatbotPromptSuggestionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatbotTurnsRequest">
    <wsdl:part name="parameters" element="tns:GetChatbotTurns" />
  </wsdl:message>
  <wsdl:message name="GetChatbotTurnsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatbotTurnsResponse">
    <wsdl:part name="parameters" element="tns:GetChatbotTurnsResponse" />
  </wsdl:message>
  <wsdl:message name="GetChatbotTurnsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ClearChatbotTurnsRequest">
    <wsdl:part name="parameters" element="tns:ClearChatbotTurns" />
  </wsdl:message>
  <wsdl:message name="ClearChatbotTurnsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ClearChatbotTurnsResponse">
    <wsdl:part name="parameters" element="tns:ClearChatbotTurnsResponse" />
  </wsdl:message>
  <wsdl:message name="ClearChatbotTurnsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DetectLanguageRequest">
    <wsdl:part name="parameters" element="tns:DetectLanguage" />
  </wsdl:message>
  <wsdl:message name="DetectLanguageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DetectLanguageResponse">
    <wsdl:part name="parameters" element="tns:DetectLanguageResponse" />
  </wsdl:message>
  <wsdl:message name="DetectLanguageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DetectSentimentRequest">
    <wsdl:part name="parameters" element="tns:DetectSentiment" />
  </wsdl:message>
  <wsdl:message name="DetectSentimentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DetectSentimentResponse">
    <wsdl:part name="parameters" element="tns:DetectSentimentResponse" />
  </wsdl:message>
  <wsdl:message name="DetectSentimentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TranslateRequest">
    <wsdl:part name="parameters" element="tns:Translate" />
  </wsdl:message>
  <wsdl:message name="TranslateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TranslateResponse">
    <wsdl:part name="parameters" element="tns:TranslateResponse" />
  </wsdl:message>
  <wsdl:message name="TranslateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TranslateEntityRequest">
    <wsdl:part name="parameters" element="tns:TranslateEntity" />
  </wsdl:message>
  <wsdl:message name="TranslateEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TranslateEntityResponse">
    <wsdl:part name="parameters" element="tns:TranslateEntityResponse" />
  </wsdl:message>
  <wsdl:message name="TranslateEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SummarizeTicketRequest">
    <wsdl:part name="parameters" element="tns:SummarizeTicket" />
  </wsdl:message>
  <wsdl:message name="SummarizeTicketRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SummarizeTicketResponse">
    <wsdl:part name="parameters" element="tns:SummarizeTicketResponse" />
  </wsdl:message>
  <wsdl:message name="SummarizeTicketResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeTicketPromptRequest">
    <wsdl:part name="parameters" element="tns:GetSummarizeTicketPrompt" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeTicketPromptRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeTicketPromptResponse">
    <wsdl:part name="parameters" element="tns:GetSummarizeTicketPromptResponse" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeTicketPromptResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SummarizeContactRequest">
    <wsdl:part name="parameters" element="tns:SummarizeContact" />
  </wsdl:message>
  <wsdl:message name="SummarizeContactRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SummarizeContactResponse">
    <wsdl:part name="parameters" element="tns:SummarizeContactResponse" />
  </wsdl:message>
  <wsdl:message name="SummarizeContactResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeContactPromptRequest">
    <wsdl:part name="parameters" element="tns:GetSummarizeContactPrompt" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeContactPromptRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeContactPromptResponse">
    <wsdl:part name="parameters" element="tns:GetSummarizeContactPromptResponse" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeContactPromptResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SummarizeSaleRequest">
    <wsdl:part name="parameters" element="tns:SummarizeSale" />
  </wsdl:message>
  <wsdl:message name="SummarizeSaleRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SummarizeSaleResponse">
    <wsdl:part name="parameters" element="tns:SummarizeSaleResponse" />
  </wsdl:message>
  <wsdl:message name="SummarizeSaleResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeSalePromptRequest">
    <wsdl:part name="parameters" element="tns:GetSummarizeSalePrompt" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeSalePromptRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeSalePromptResponse">
    <wsdl:part name="parameters" element="tns:GetSummarizeSalePromptResponse" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeSalePromptResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="AI">
    <wsdl:operation name="SummarizeText">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeText" name="SummarizeTextRequest" message="tns:SummarizeTextRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeTextResponse" name="SummarizeTextResponse" message="tns:SummarizeTextResponse" />
    </wsdl:operation>
    <wsdl:operation name="ExpandText">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/ExpandText" name="ExpandTextRequest" message="tns:ExpandTextRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/ExpandTextResponse" name="ExpandTextResponse" message="tns:ExpandTextResponse" />
    </wsdl:operation>
    <wsdl:operation name="RephraseText">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/RephraseText" name="RephraseTextRequest" message="tns:RephraseTextRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/RephraseTextResponse" name="RephraseTextResponse" message="tns:RephraseTextResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateTextForAppointment">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/CreateTextForAppointment" name="CreateTextForAppointmentRequest" message="tns:CreateTextForAppointmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/CreateTextForAppointmentResponse" name="CreateTextForAppointmentResponse" message="tns:CreateTextForAppointmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTrainingStatus">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetTrainingStatus" name="GetTrainingStatusRequest" message="tns:GetTrainingStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetTrainingStatusResponse" name="GetTrainingStatusResponse" message="tns:GetTrainingStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="GuessCategory">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GuessCategory" name="GuessCategoryRequest" message="tns:GuessCategoryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GuessCategoryResponse" name="GuessCategoryResponse" message="tns:GuessCategoryResponse" />
    </wsdl:operation>
    <wsdl:operation name="TrainCategoryGuesser">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/TrainCategoryGuesser" name="TrainCategoryGuesserRequest" message="tns:TrainCategoryGuesserRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/TrainCategoryGuesserResponse" name="TrainCategoryGuesserResponse" message="tns:TrainCategoryGuesserResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetChatbotResponse">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetChatbotResponse" name="GetChatbotResponseRequest" message="tns:GetChatbotResponseRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetChatbotResponseResponse" name="GetChatbotResponseResponse" message="tns:GetChatbotResponseResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetChatbotPromptSuggestions">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetChatbotPromptSuggestions" name="GetChatbotPromptSuggestionsRequest" message="tns:GetChatbotPromptSuggestionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetChatbotPromptSuggestionsResponse" name="GetChatbotPromptSuggestionsResponse" message="tns:GetChatbotPromptSuggestionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetChatbotTurns">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetChatbotTurns" name="GetChatbotTurnsRequest" message="tns:GetChatbotTurnsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetChatbotTurnsResponse" name="GetChatbotTurnsResponse" message="tns:GetChatbotTurnsResponse" />
    </wsdl:operation>
    <wsdl:operation name="ClearChatbotTurns">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/ClearChatbotTurns" name="ClearChatbotTurnsRequest" message="tns:ClearChatbotTurnsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/ClearChatbotTurnsResponse" name="ClearChatbotTurnsResponse" message="tns:ClearChatbotTurnsResponse" />
    </wsdl:operation>
    <wsdl:operation name="DetectLanguage">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DetectLanguage" name="DetectLanguageRequest" message="tns:DetectLanguageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DetectLanguageResponse" name="DetectLanguageResponse" message="tns:DetectLanguageResponse" />
    </wsdl:operation>
    <wsdl:operation name="DetectSentiment">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DetectSentiment" name="DetectSentimentRequest" message="tns:DetectSentimentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DetectSentimentResponse" name="DetectSentimentResponse" message="tns:DetectSentimentResponse" />
    </wsdl:operation>
    <wsdl:operation name="Translate">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/Translate" name="TranslateRequest" message="tns:TranslateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/TranslateResponse" name="TranslateResponse" message="tns:TranslateResponse" />
    </wsdl:operation>
    <wsdl:operation name="TranslateEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/TranslateEntity" name="TranslateEntityRequest" message="tns:TranslateEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/TranslateEntityResponse" name="TranslateEntityResponse" message="tns:TranslateEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SummarizeTicket">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeTicket" name="SummarizeTicketRequest" message="tns:SummarizeTicketRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeTicketResponse" name="SummarizeTicketResponse" message="tns:SummarizeTicketResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSummarizeTicketPrompt">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetSummarizeTicketPrompt" name="GetSummarizeTicketPromptRequest" message="tns:GetSummarizeTicketPromptRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetSummarizeTicketPromptResponse" name="GetSummarizeTicketPromptResponse" message="tns:GetSummarizeTicketPromptResponse" />
    </wsdl:operation>
    <wsdl:operation name="SummarizeContact">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeContact" name="SummarizeContactRequest" message="tns:SummarizeContactRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeContactResponse" name="SummarizeContactResponse" message="tns:SummarizeContactResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSummarizeContactPrompt">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetSummarizeContactPrompt" name="GetSummarizeContactPromptRequest" message="tns:GetSummarizeContactPromptRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetSummarizeContactPromptResponse" name="GetSummarizeContactPromptResponse" message="tns:GetSummarizeContactPromptResponse" />
    </wsdl:operation>
    <wsdl:operation name="SummarizeSale">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeSale" name="SummarizeSaleRequest" message="tns:SummarizeSaleRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeSaleResponse" name="SummarizeSaleResponse" message="tns:SummarizeSaleResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSummarizeSalePrompt">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetSummarizeSalePrompt" name="GetSummarizeSalePromptRequest" message="tns:GetSummarizeSalePromptRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetSummarizeSalePromptResponse" name="GetSummarizeSalePromptResponse" message="tns:GetSummarizeSalePromptResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_AI" type="tns:AI">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="SummarizeText">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeText" style="document" />
      <wsdl:input name="SummarizeTextRequest">
        <soap:header message="tns:SummarizeTextRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SummarizeTextRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SummarizeTextRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SummarizeTextResponse">
        <soap:header message="tns:SummarizeTextResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SummarizeTextResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SummarizeTextResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SummarizeTextResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ExpandText">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/ExpandText" style="document" />
      <wsdl:input name="ExpandTextRequest">
        <soap:header message="tns:ExpandTextRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ExpandTextRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ExpandTextRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ExpandTextResponse">
        <soap:header message="tns:ExpandTextResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ExpandTextResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ExpandTextResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ExpandTextResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RephraseText">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/RephraseText" style="document" />
      <wsdl:input name="RephraseTextRequest">
        <soap:header message="tns:RephraseTextRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RephraseTextRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RephraseTextRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RephraseTextResponse">
        <soap:header message="tns:RephraseTextResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RephraseTextResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RephraseTextResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RephraseTextResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateTextForAppointment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/CreateTextForAppointment" style="document" />
      <wsdl:input name="CreateTextForAppointmentRequest">
        <soap:header message="tns:CreateTextForAppointmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateTextForAppointmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateTextForAppointmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateTextForAppointmentResponse">
        <soap:header message="tns:CreateTextForAppointmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateTextForAppointmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateTextForAppointmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateTextForAppointmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTrainingStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetTrainingStatus" style="document" />
      <wsdl:input name="GetTrainingStatusRequest">
        <soap:header message="tns:GetTrainingStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTrainingStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTrainingStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTrainingStatusResponse">
        <soap:header message="tns:GetTrainingStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTrainingStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTrainingStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTrainingStatusResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GuessCategory">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GuessCategory" style="document" />
      <wsdl:input name="GuessCategoryRequest">
        <soap:header message="tns:GuessCategoryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GuessCategoryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GuessCategoryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GuessCategoryResponse">
        <soap:header message="tns:GuessCategoryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GuessCategoryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GuessCategoryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GuessCategoryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="TrainCategoryGuesser">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/TrainCategoryGuesser" style="document" />
      <wsdl:input name="TrainCategoryGuesserRequest">
        <soap:header message="tns:TrainCategoryGuesserRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TrainCategoryGuesserRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TrainCategoryGuesserRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TrainCategoryGuesserResponse">
        <soap:header message="tns:TrainCategoryGuesserResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TrainCategoryGuesserResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TrainCategoryGuesserResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TrainCategoryGuesserResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetChatbotResponse">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetChatbotResponse" style="document" />
      <wsdl:input name="GetChatbotResponseRequest">
        <soap:header message="tns:GetChatbotResponseRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetChatbotResponseRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetChatbotResponseRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetChatbotResponseResponse">
        <soap:header message="tns:GetChatbotResponseResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetChatbotResponseResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetChatbotResponseResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetChatbotResponseResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetChatbotPromptSuggestions">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetChatbotPromptSuggestions" style="document" />
      <wsdl:input name="GetChatbotPromptSuggestionsRequest">
        <soap:header message="tns:GetChatbotPromptSuggestionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetChatbotPromptSuggestionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetChatbotPromptSuggestionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetChatbotPromptSuggestionsResponse">
        <soap:header message="tns:GetChatbotPromptSuggestionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetChatbotPromptSuggestionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetChatbotPromptSuggestionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetChatbotPromptSuggestionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetChatbotTurns">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetChatbotTurns" style="document" />
      <wsdl:input name="GetChatbotTurnsRequest">
        <soap:header message="tns:GetChatbotTurnsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetChatbotTurnsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetChatbotTurnsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetChatbotTurnsResponse">
        <soap:header message="tns:GetChatbotTurnsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetChatbotTurnsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetChatbotTurnsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetChatbotTurnsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ClearChatbotTurns">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/ClearChatbotTurns" style="document" />
      <wsdl:input name="ClearChatbotTurnsRequest">
        <soap:header message="tns:ClearChatbotTurnsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ClearChatbotTurnsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ClearChatbotTurnsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ClearChatbotTurnsResponse">
        <soap:header message="tns:ClearChatbotTurnsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ClearChatbotTurnsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ClearChatbotTurnsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ClearChatbotTurnsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DetectLanguage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DetectLanguage" style="document" />
      <wsdl:input name="DetectLanguageRequest">
        <soap:header message="tns:DetectLanguageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DetectLanguageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DetectLanguageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DetectLanguageResponse">
        <soap:header message="tns:DetectLanguageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DetectLanguageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DetectLanguageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DetectLanguageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DetectSentiment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DetectSentiment" style="document" />
      <wsdl:input name="DetectSentimentRequest">
        <soap:header message="tns:DetectSentimentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DetectSentimentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DetectSentimentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DetectSentimentResponse">
        <soap:header message="tns:DetectSentimentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DetectSentimentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DetectSentimentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DetectSentimentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Translate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/Translate" style="document" />
      <wsdl:input name="TranslateRequest">
        <soap:header message="tns:TranslateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TranslateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TranslateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TranslateResponse">
        <soap:header message="tns:TranslateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TranslateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TranslateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TranslateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="TranslateEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/TranslateEntity" style="document" />
      <wsdl:input name="TranslateEntityRequest">
        <soap:header message="tns:TranslateEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TranslateEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TranslateEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TranslateEntityResponse">
        <soap:header message="tns:TranslateEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TranslateEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TranslateEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TranslateEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SummarizeTicket">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeTicket" style="document" />
      <wsdl:input name="SummarizeTicketRequest">
        <soap:header message="tns:SummarizeTicketRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SummarizeTicketRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SummarizeTicketRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SummarizeTicketResponse">
        <soap:header message="tns:SummarizeTicketResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SummarizeTicketResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SummarizeTicketResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SummarizeTicketResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSummarizeTicketPrompt">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetSummarizeTicketPrompt" style="document" />
      <wsdl:input name="GetSummarizeTicketPromptRequest">
        <soap:header message="tns:GetSummarizeTicketPromptRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSummarizeTicketPromptRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSummarizeTicketPromptRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSummarizeTicketPromptResponse">
        <soap:header message="tns:GetSummarizeTicketPromptResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSummarizeTicketPromptResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSummarizeTicketPromptResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSummarizeTicketPromptResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SummarizeContact">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeContact" style="document" />
      <wsdl:input name="SummarizeContactRequest">
        <soap:header message="tns:SummarizeContactRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SummarizeContactRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SummarizeContactRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SummarizeContactResponse">
        <soap:header message="tns:SummarizeContactResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SummarizeContactResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SummarizeContactResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SummarizeContactResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSummarizeContactPrompt">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetSummarizeContactPrompt" style="document" />
      <wsdl:input name="GetSummarizeContactPromptRequest">
        <soap:header message="tns:GetSummarizeContactPromptRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSummarizeContactPromptRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSummarizeContactPromptRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSummarizeContactPromptResponse">
        <soap:header message="tns:GetSummarizeContactPromptResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSummarizeContactPromptResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSummarizeContactPromptResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSummarizeContactPromptResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SummarizeSale">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeSale" style="document" />
      <wsdl:input name="SummarizeSaleRequest">
        <soap:header message="tns:SummarizeSaleRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SummarizeSaleRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SummarizeSaleRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SummarizeSaleResponse">
        <soap:header message="tns:SummarizeSaleResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SummarizeSaleResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SummarizeSaleResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SummarizeSaleResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSummarizeSalePrompt">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetSummarizeSalePrompt" style="document" />
      <wsdl:input name="GetSummarizeSalePromptRequest">
        <soap:header message="tns:GetSummarizeSalePromptRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSummarizeSalePromptRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSummarizeSalePromptRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSummarizeSalePromptResponse">
        <soap:header message="tns:GetSummarizeSalePromptResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSummarizeSalePromptResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSummarizeSalePromptResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSummarizeSalePromptResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfAIService">
    <wsdl:port name="BasicHttpBinding_AI" binding="tns:BasicHttpBinding_AI">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/AI.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

