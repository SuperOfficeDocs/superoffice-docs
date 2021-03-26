---
Generated: 1
TOCExclude: 1
title: Services81.SaleAgent WSDL
---

# Services81.SaleAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfSaleService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services81" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services81" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services81" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:ser="http://schemas.microsoft.com/2003/10/Serialization/">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultSaleEntity">
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
      <xs:element name="CreateDefaultSaleEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q5:SaleEntity" xmlns:q5="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SaleEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q6:Carrier" xmlns:q6="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="Appointment" nillable="true" type="q6:Appointment" />
              <xs:element minOccurs="0" name="Associate" nillable="true" type="q6:Associate" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="q6:Associate" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="q6:Associate" />
              <xs:element minOccurs="0" name="Contact" nillable="true" type="q6:Contact" />
              <xs:element minOccurs="0" name="Project" nillable="true" type="q6:Project" />
              <xs:element minOccurs="0" name="SaleText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Person" nillable="true" type="q6:Person" />
              <xs:element minOccurs="0" name="Currency" nillable="true" type="q6:Currency" />
              <xs:element minOccurs="0" name="Competitor" nillable="true" type="q6:Competitor" />
              <xs:element minOccurs="0" name="Credited" nillable="true" type="q6:Credited" />
              <xs:element minOccurs="0" name="Rating" nillable="true" type="q6:Rating" />
              <xs:element minOccurs="0" name="Reason" nillable="true" type="q6:Reason" />
              <xs:element minOccurs="0" name="Source" nillable="true" type="q6:Source" />
              <xs:element minOccurs="0" name="Status" type="q6:SaleStatus" />
              <xs:element minOccurs="0" name="Saledate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Amount" type="xs:double" />
              <xs:element minOccurs="0" name="SaleId" type="xs:int" />
              <xs:element minOccurs="0" name="Earning" type="xs:double" />
              <xs:element minOccurs="0" name="EarningPercent" type="xs:double" />
              <xs:element minOccurs="0" name="Heading" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Number" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Probability" type="xs:short" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Completed" type="q6:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveLinks" type="xs:int" />
              <xs:element minOccurs="0" name="Links" nillable="true" type="q6:ArrayOfLink" />
              <xs:element minOccurs="0" name="NextDueDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Postit" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SaleType" nillable="true" type="q6:SaleType" />
              <xs:element minOccurs="0" name="ReasonSold" nillable="true" type="q6:ReasonSold" />
              <xs:element minOccurs="0" name="ReasonStalled" nillable="true" type="q6:ReasonStalled" />
              <xs:element minOccurs="0" name="ReopenDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="SaleStakeholders" nillable="true" type="q6:ArrayOfSaleStakeholder" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
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
      <xs:element name="SaleEntity" nillable="true" type="q7:SaleEntity" xmlns:q7="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:complexType name="Appointment">
        <xs:complexContent mixed="false">
          <xs:extension base="q21:Carrier" xmlns:q21="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Type" type="q21:AppointmentType" />
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
              <xs:element minOccurs="0" name="Private" type="q21:AppointmentPrivate" />
              <xs:element minOccurs="0" name="PriorityId" type="xs:int" />
              <xs:element minOccurs="0" name="PriorityName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TaskType" type="q21:TaskType" />
              <xs:element minOccurs="0" name="IsBookingMain" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsRecurrence" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsBooking" type="xs:boolean" />
              <xs:element minOccurs="0" name="ActiveDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AssignmentStatus" type="q21:AssignmentStatus" />
              <xs:element minOccurs="0" name="InvitationStatus" type="q21:InvitationStatus" />
              <xs:element minOccurs="0" name="BookingType" type="q21:BookingType" />
              <xs:element minOccurs="0" name="Completed" type="q21:ActivityStatus" />
              <xs:element minOccurs="0" name="RecurringPattern" type="q21:RecurrencePattern" />
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
      <xs:element name="Appointment" nillable="true" type="q22:Appointment" xmlns:q22="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="AppointmentType" nillable="true" type="q23:AppointmentType" xmlns:q23="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="AppointmentPrivate" nillable="true" type="q24:AppointmentPrivate" xmlns:q24="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="TaskType" nillable="true" type="q25:TaskType" xmlns:q25="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="AssignmentStatus" nillable="true" type="q26:AssignmentStatus" xmlns:q26="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="InvitationStatus" nillable="true" type="q27:InvitationStatus" xmlns:q27="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="BookingType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="None" />
          <xs:enumeration value="Owner" />
          <xs:enumeration value="Participant" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="BookingType" nillable="true" type="q28:BookingType" xmlns:q28="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="ActivityStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="NotStarted" />
          <xs:enumeration value="Started" />
          <xs:enumeration value="Completed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ActivityStatus" nillable="true" type="q29:ActivityStatus" xmlns:q29="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="RecurrencePattern" nillable="true" type="q30:RecurrencePattern" xmlns:q30="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Associate">
        <xs:complexContent mixed="false">
          <xs:extension base="q31:Carrier" xmlns:q31="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Type" type="q31:UserType" />
              <xs:element minOccurs="0" name="GroupIdx" type="xs:int" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="EjUserId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Associate" nillable="true" type="q32:Associate" xmlns:q32="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="UserType" nillable="true" type="q33:UserType" xmlns:q33="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Contact">
        <xs:complexContent mixed="false">
          <xs:extension base="q34:Carrier" xmlns:q34="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
              <xs:element minOccurs="0" name="Address" nillable="true" type="q34:Address" />
              <xs:element minOccurs="0" name="FormattedAddress" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsOwnerContact" type="xs:boolean" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Contact" nillable="true" type="q35:Contact" xmlns:q35="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Address">
        <xs:complexContent mixed="false">
          <xs:extension base="q36:Carrier" xmlns:q36="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="Wgs84Latitude" type="xs:double" />
              <xs:element minOccurs="0" name="Wgs84Longitude" type="xs:double" />
              <xs:element minOccurs="0" name="LocalizedAddress" nillable="true" type="q36:ArrayOfArrayOfLocalizedField" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Address" nillable="true" type="q37:Address" xmlns:q37="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ArrayOfArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArrayOfLocalizedField" nillable="true" type="q38:ArrayOfLocalizedField" xmlns:q38="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArrayOfLocalizedField" nillable="true" type="q39:ArrayOfArrayOfLocalizedField" xmlns:q39="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="LocalizedField" nillable="true" type="q40:LocalizedField" xmlns:q40="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLocalizedField" nillable="true" type="q41:ArrayOfLocalizedField" xmlns:q41="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="LocalizedField">
        <xs:complexContent mixed="false">
          <xs:extension base="q42:Carrier" xmlns:q42="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
      <xs:element name="LocalizedField" nillable="true" type="q43:LocalizedField" xmlns:q43="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Project">
        <xs:complexContent mixed="false">
          <xs:extension base="q44:Carrier" xmlns:q44="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
      <xs:element name="Project" nillable="true" type="q45:Project" xmlns:q45="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Person">
        <xs:complexContent mixed="false">
          <xs:extension base="q46:Carrier" xmlns:q46="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
      <xs:element name="Person" nillable="true" type="q47:Person" xmlns:q47="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Currency">
        <xs:complexContent mixed="false">
          <xs:extension base="q48:Carrier" xmlns:q48="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Currency" nillable="true" type="q49:Currency" xmlns:q49="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Competitor">
        <xs:complexContent mixed="false">
          <xs:extension base="q50:Carrier" xmlns:q50="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Competitor" nillable="true" type="q51:Competitor" xmlns:q51="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Credited">
        <xs:complexContent mixed="false">
          <xs:extension base="q52:Carrier" xmlns:q52="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Credited" nillable="true" type="q53:Credited" xmlns:q53="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Rating">
        <xs:complexContent mixed="false">
          <xs:extension base="q54:Carrier" xmlns:q54="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Rating" nillable="true" type="q55:Rating" xmlns:q55="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Reason">
        <xs:complexContent mixed="false">
          <xs:extension base="q56:Carrier" xmlns:q56="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Reason" nillable="true" type="q57:Reason" xmlns:q57="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Source">
        <xs:complexContent mixed="false">
          <xs:extension base="q58:Carrier" xmlns:q58="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Source" nillable="true" type="q59:Source" xmlns:q59="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="SaleStatus" nillable="true" type="q60:SaleStatus" xmlns:q60="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ArrayOfLink">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Link" nillable="true" type="q61:Link" xmlns:q61="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLink" nillable="true" type="q62:ArrayOfLink" xmlns:q62="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="Link">
        <xs:complexContent mixed="false">
          <xs:extension base="q63:Carrier" xmlns:q63="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
      <xs:element name="Link" nillable="true" type="q64:Link" xmlns:q64="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="SaleType">
        <xs:complexContent mixed="false">
          <xs:extension base="q65:Carrier" xmlns:q65="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SaleType" nillable="true" type="q66:SaleType" xmlns:q66="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ReasonSold">
        <xs:complexContent mixed="false">
          <xs:extension base="q67:Carrier" xmlns:q67="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ReasonSold" nillable="true" type="q68:ReasonSold" xmlns:q68="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ReasonStalled">
        <xs:complexContent mixed="false">
          <xs:extension base="q69:Carrier" xmlns:q69="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ReasonStalled" nillable="true" type="q70:ReasonStalled" xmlns:q70="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ArrayOfSaleStakeholder">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="SaleStakeholder" nillable="true" type="q71:SaleStakeholder" xmlns:q71="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfSaleStakeholder" nillable="true" type="q72:ArrayOfSaleStakeholder" xmlns:q72="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="SaleStakeholder">
        <xs:complexContent mixed="false">
          <xs:extension base="q73:Carrier" xmlns:q73="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="StakeholderRoleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Comment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StakeholderRoleId" type="xs:int" />
              <xs:element minOccurs="0" name="CountryId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="EmailDescription" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EmailId" type="xs:int" />
              <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PhoneId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleId" type="xs:int" />
              <xs:element minOccurs="0" name="Mrmrs" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Firstname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MiddleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Lastname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SaleStakeholderId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Phone" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SaleStakeholder" nillable="true" type="q74:SaleStakeholder" xmlns:q74="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="StringDictionary" nillable="true" type="q75:StringDictionary" xmlns:q75="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="ArrayOfVisibleFor">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="VisibleFor" nillable="true" type="q76:VisibleFor" xmlns:q76="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfVisibleFor" nillable="true" type="q77:ArrayOfVisibleFor" xmlns:q77="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="VisibleFor">
        <xs:complexContent mixed="false">
          <xs:extension base="q78:Carrier" xmlns:q78="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="VisibleId" type="xs:int" />
              <xs:element minOccurs="0" name="Visibility" type="q78:Visibility" />
              <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="VisibleFor" nillable="true" type="q79:VisibleFor" xmlns:q79="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:simpleType name="Visibility">
        <xs:restriction base="xs:string">
          <xs:enumeration value="All" />
          <xs:enumeration value="Associate" />
          <xs:enumeration value="Group" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="Visibility" nillable="true" type="q80:Visibility" xmlns:q80="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:complexType name="SoExceptionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="StackTrace" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FriendlyText" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ExceptionType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="InnerException" nillable="true" type="q81:SoExceptionInfo" xmlns:q81="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          <xs:element minOccurs="0" name="Parameters" nillable="true" type="q82:SoExceptionInfoParameters" xmlns:q82="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExceptionInfo" nillable="true" type="q83:SoExceptionInfo" xmlns:q83="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="SoExceptionInfoParameters" nillable="true" type="q84:SoExceptionInfoParameters" xmlns:q84="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="ExceptionInfo" nillable="true" type="q85:SoExceptionInfo" xmlns:q85="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
      <xs:element name="SoExtraInfo" nillable="true" type="q86:SoExtraInfo" xmlns:q86="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="ExtraInfo" nillable="true" type="q87:SoExtraInfo" xmlns:q87="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="Succeeded" type="xs:boolean" />
      <xs:element name="SaveSaleEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleEntity" nillable="true" type="q88:SaleEntity" xmlns:q88="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveSaleEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q89:SaleEntity" xmlns:q89="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteSaleEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteSaleEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultSaleSummary">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultSaleSummaryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q90:SaleSummary" xmlns:q90="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SaleSummary">
        <xs:complexContent mixed="false">
          <xs:extension base="q91:Carrier" xmlns:q91="http://www.superoffice.net/ws/crm/NetServer/Services81">
            <xs:sequence>
              <xs:element minOccurs="0" name="BaseCurrency" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OwnCurrency" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SoldTotalBaseCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="Sold" type="xs:int" />
              <xs:element minOccurs="0" name="SoldTotalOwnCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="Lost" type="xs:int" />
              <xs:element minOccurs="0" name="LostTotalBaseCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="LostTotalOwnCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="Open" type="xs:int" />
              <xs:element minOccurs="0" name="OpenTotalBaseCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="OpenTotalOwnCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="OpenWeightedBaseCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="OpenWeightedOwnCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="PreviousOverdue" type="xs:int" />
              <xs:element minOccurs="0" name="PreviousOverdueTotalBaseCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="PreviousOverdueTotalOwnCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="PreviousOverdueWeightedBaseCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="PreviousOverdueWeightedOwnCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="CurrentOverdue" type="xs:int" />
              <xs:element minOccurs="0" name="CurrentOverdueTotalBaseCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="CurrentOverdueTotalOwnCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="CurrentOverdueWeightedBaseCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="CurrentOverdueWeightedOwnCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="FutureOpen" type="xs:int" />
              <xs:element minOccurs="0" name="FutureOpenTotalBaseCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="FutureOpenTotalOwnCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="FutureOpenWeightedBaseCurrency" type="xs:double" />
              <xs:element minOccurs="0" name="FutureOpenWeightedOwnCurrency" type="xs:double" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SaleSummary" nillable="true" type="q92:SaleSummary" xmlns:q92="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="GetSale">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSaleResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q93:Sale" xmlns:q93="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Sale">
        <xs:complexContent mixed="false">
          <xs:extension base="q94:Carrier" xmlns:q94="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
              <xs:element minOccurs="0" name="Status" type="q94:SaleStatus" />
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
              <xs:element minOccurs="0" name="Completed" type="q94:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="NextDueDate" type="xs:dateTime" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Sale" nillable="true" type="q95:Sale" xmlns:q95="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="GetSaleEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSaleEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q96:SaleEntity" xmlns:q96="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="HasGuide">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="HasGuideResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNextDueDate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNextDueDateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:dateTime" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="BatchUpdateNextDueDate">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="BatchUpdateNextDueDateResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNextSaleStage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeCurrentStage" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNextSaleStageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="HasGuideActivities">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="HasGuideActivitiesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="OfferAutoNextStageOnApppointmentCompleted">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="OfferAutoNextStageOnApppointmentCompletedResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProbabilityFromStage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StageId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProbabilityFromStageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
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
      <xs:element name="AddSaleStakeholders">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="SaleStakeholders" nillable="true" type="q97:ArrayOfSaleStakeholder" xmlns:q97="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddSaleStakeholdersResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteSaleStakeholders">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleStakeholderIds" nillable="true" type="q98:ArrayOfint" xmlns:q98="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteSaleStakeholdersResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="HasStakeholderSetting">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="HasStakeholderSettingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSaleList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleIds" nillable="true" type="q99:ArrayOfint" xmlns:q99="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSaleListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q100:ArrayOfSale" xmlns:q100="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfSale">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Sale" nillable="true" type="q101:Sale" xmlns:q101="http://www.superoffice.net/ws/crm/NetServer/Services81" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfSale" nillable="true" type="q102:ArrayOfSale" xmlns:q102="http://www.superoffice.net/ws/crm/NetServer/Services81" />
      <xs:element name="GetMyOpportunities">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyOpportunitiesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q103:ArrayOfSale" xmlns:q103="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRecentSales">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AmountLimit" type="xs:int" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRecentSalesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q104:ArrayOfSale" xmlns:q104="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUpcomingSales">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WeightedAmountLimit" type="xs:int" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUpcomingSalesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q105:ArrayOfSale" xmlns:q105="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSalesByDate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FromDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="ToDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="AmountLimit" type="xs:int" />
            <xs:element minOccurs="0" name="Status" type="q106:SaleStatus" xmlns:q106="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSalesByDateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q107:ArrayOfSale" xmlns:q107="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetOpenSalesForContact">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetOpenSalesForContactResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q108:ArrayOfSale" xmlns:q108="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetAsSold">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleIds" nillable="true" type="q109:ArrayOfint" xmlns:q109="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetAsSoldResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetAsLost">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleIds" nillable="true" type="q110:ArrayOfint" xmlns:q110="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetAsLostResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSaleStakeholder">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleStakeholderId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSaleStakeholderResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q111:SaleStakeholder" xmlns:q111="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSaleStakeholderList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleStakeholderIds" nillable="true" type="q112:ArrayOfint" xmlns:q112="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSaleStakeholderListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q113:ArrayOfSaleStakeholder" xmlns:q113="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSaleStakeholders">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSaleStakeholdersResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q114:ArrayOfSaleStakeholder" xmlns:q114="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateSaleStakeholders">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Stakeholders" nillable="true" type="q115:ArrayOfSaleStakeholder" xmlns:q115="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateSaleStakeholdersResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q116:ArrayOfSaleStakeholder" xmlns:q116="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSaleStakeholderById">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleStakeholderIds" nillable="true" type="q117:ArrayOfint" xmlns:q117="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSaleStakeholderByIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q118:ArrayOfSaleStakeholder" xmlns:q118="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSummaryByAssociate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="FromDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="ToDate" type="xs:dateTime" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSummaryByAssociateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q119:SaleSummary" xmlns:q119="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSummaryByGroup">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="GroupId" type="xs:int" />
            <xs:element minOccurs="0" name="FromDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="ToDate" type="xs:dateTime" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSummaryByGroupResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q120:SaleSummary" xmlns:q120="http://www.superoffice.net/ws/crm/NetServer/Services81" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSummaryByContact">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="FromDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="ToDate" type="xs:dateTime" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSummaryByContactResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q121:SaleSummary" xmlns:q121="http://www.superoffice.net/ws/crm/NetServer/Services81" />
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
  <wsdl:message name="CreateDefaultSaleEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultSaleEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSaleEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSaleEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultSaleEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSaleEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSaleEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveSaleEntity" />
  </wsdl:message>
  <wsdl:message name="SaveSaleEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSaleEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveSaleEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveSaleEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteSaleEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteSaleEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteSaleEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteSaleEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteSaleEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteSaleEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSaleSummaryRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultSaleSummary" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSaleSummaryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSaleSummaryResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultSaleSummaryResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSaleSummaryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleRequest">
    <wsdl:part name="parameters" element="tns:GetSale" />
  </wsdl:message>
  <wsdl:message name="GetSaleRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleResponse">
    <wsdl:part name="parameters" element="tns:GetSaleResponse" />
  </wsdl:message>
  <wsdl:message name="GetSaleResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleEntityRequest">
    <wsdl:part name="parameters" element="tns:GetSaleEntity" />
  </wsdl:message>
  <wsdl:message name="GetSaleEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleEntityResponse">
    <wsdl:part name="parameters" element="tns:GetSaleEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetSaleEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasGuideRequest">
    <wsdl:part name="parameters" element="tns:HasGuide" />
  </wsdl:message>
  <wsdl:message name="HasGuideRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasGuideResponse">
    <wsdl:part name="parameters" element="tns:HasGuideResponse" />
  </wsdl:message>
  <wsdl:message name="HasGuideResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextDueDateRequest">
    <wsdl:part name="parameters" element="tns:GetNextDueDate" />
  </wsdl:message>
  <wsdl:message name="GetNextDueDateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextDueDateResponse">
    <wsdl:part name="parameters" element="tns:GetNextDueDateResponse" />
  </wsdl:message>
  <wsdl:message name="GetNextDueDateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="BatchUpdateNextDueDateRequest">
    <wsdl:part name="parameters" element="tns:BatchUpdateNextDueDate" />
  </wsdl:message>
  <wsdl:message name="BatchUpdateNextDueDateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="BatchUpdateNextDueDateResponse">
    <wsdl:part name="parameters" element="tns:BatchUpdateNextDueDateResponse" />
  </wsdl:message>
  <wsdl:message name="BatchUpdateNextDueDateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextSaleStageRequest">
    <wsdl:part name="parameters" element="tns:GetNextSaleStage" />
  </wsdl:message>
  <wsdl:message name="GetNextSaleStageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextSaleStageResponse">
    <wsdl:part name="parameters" element="tns:GetNextSaleStageResponse" />
  </wsdl:message>
  <wsdl:message name="GetNextSaleStageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasGuideActivitiesRequest">
    <wsdl:part name="parameters" element="tns:HasGuideActivities" />
  </wsdl:message>
  <wsdl:message name="HasGuideActivitiesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasGuideActivitiesResponse">
    <wsdl:part name="parameters" element="tns:HasGuideActivitiesResponse" />
  </wsdl:message>
  <wsdl:message name="HasGuideActivitiesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="OfferAutoNextStageOnApppointmentCompletedRequest">
    <wsdl:part name="parameters" element="tns:OfferAutoNextStageOnApppointmentCompleted" />
  </wsdl:message>
  <wsdl:message name="OfferAutoNextStageOnApppointmentCompletedRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="OfferAutoNextStageOnApppointmentCompletedResponse">
    <wsdl:part name="parameters" element="tns:OfferAutoNextStageOnApppointmentCompletedResponse" />
  </wsdl:message>
  <wsdl:message name="OfferAutoNextStageOnApppointmentCompletedResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProbabilityFromStageRequest">
    <wsdl:part name="parameters" element="tns:GetProbabilityFromStage" />
  </wsdl:message>
  <wsdl:message name="GetProbabilityFromStageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProbabilityFromStageResponse">
    <wsdl:part name="parameters" element="tns:GetProbabilityFromStageResponse" />
  </wsdl:message>
  <wsdl:message name="GetProbabilityFromStageResponse_Headers">
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
  <wsdl:message name="AddSaleStakeholdersRequest">
    <wsdl:part name="parameters" element="tns:AddSaleStakeholders" />
  </wsdl:message>
  <wsdl:message name="AddSaleStakeholdersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddSaleStakeholdersResponse">
    <wsdl:part name="parameters" element="tns:AddSaleStakeholdersResponse" />
  </wsdl:message>
  <wsdl:message name="AddSaleStakeholdersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteSaleStakeholdersRequest">
    <wsdl:part name="parameters" element="tns:DeleteSaleStakeholders" />
  </wsdl:message>
  <wsdl:message name="DeleteSaleStakeholdersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteSaleStakeholdersResponse">
    <wsdl:part name="parameters" element="tns:DeleteSaleStakeholdersResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteSaleStakeholdersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasStakeholderSettingRequest">
    <wsdl:part name="parameters" element="tns:HasStakeholderSetting" />
  </wsdl:message>
  <wsdl:message name="HasStakeholderSettingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasStakeholderSettingResponse">
    <wsdl:part name="parameters" element="tns:HasStakeholderSettingResponse" />
  </wsdl:message>
  <wsdl:message name="HasStakeholderSettingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleListRequest">
    <wsdl:part name="parameters" element="tns:GetSaleList" />
  </wsdl:message>
  <wsdl:message name="GetSaleListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleListResponse">
    <wsdl:part name="parameters" element="tns:GetSaleListResponse" />
  </wsdl:message>
  <wsdl:message name="GetSaleListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyOpportunitiesRequest">
    <wsdl:part name="parameters" element="tns:GetMyOpportunities" />
  </wsdl:message>
  <wsdl:message name="GetMyOpportunitiesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyOpportunitiesResponse">
    <wsdl:part name="parameters" element="tns:GetMyOpportunitiesResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyOpportunitiesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRecentSalesRequest">
    <wsdl:part name="parameters" element="tns:GetRecentSales" />
  </wsdl:message>
  <wsdl:message name="GetRecentSalesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRecentSalesResponse">
    <wsdl:part name="parameters" element="tns:GetRecentSalesResponse" />
  </wsdl:message>
  <wsdl:message name="GetRecentSalesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUpcomingSalesRequest">
    <wsdl:part name="parameters" element="tns:GetUpcomingSales" />
  </wsdl:message>
  <wsdl:message name="GetUpcomingSalesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUpcomingSalesResponse">
    <wsdl:part name="parameters" element="tns:GetUpcomingSalesResponse" />
  </wsdl:message>
  <wsdl:message name="GetUpcomingSalesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSalesByDateRequest">
    <wsdl:part name="parameters" element="tns:GetSalesByDate" />
  </wsdl:message>
  <wsdl:message name="GetSalesByDateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSalesByDateResponse">
    <wsdl:part name="parameters" element="tns:GetSalesByDateResponse" />
  </wsdl:message>
  <wsdl:message name="GetSalesByDateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetOpenSalesForContactRequest">
    <wsdl:part name="parameters" element="tns:GetOpenSalesForContact" />
  </wsdl:message>
  <wsdl:message name="GetOpenSalesForContactRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetOpenSalesForContactResponse">
    <wsdl:part name="parameters" element="tns:GetOpenSalesForContactResponse" />
  </wsdl:message>
  <wsdl:message name="GetOpenSalesForContactResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetAsSoldRequest">
    <wsdl:part name="parameters" element="tns:SetAsSold" />
  </wsdl:message>
  <wsdl:message name="SetAsSoldRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetAsSoldResponse">
    <wsdl:part name="parameters" element="tns:SetAsSoldResponse" />
  </wsdl:message>
  <wsdl:message name="SetAsSoldResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetAsLostRequest">
    <wsdl:part name="parameters" element="tns:SetAsLost" />
  </wsdl:message>
  <wsdl:message name="SetAsLostRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetAsLostResponse">
    <wsdl:part name="parameters" element="tns:SetAsLostResponse" />
  </wsdl:message>
  <wsdl:message name="SetAsLostResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleStakeholderRequest">
    <wsdl:part name="parameters" element="tns:GetSaleStakeholder" />
  </wsdl:message>
  <wsdl:message name="GetSaleStakeholderRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleStakeholderResponse">
    <wsdl:part name="parameters" element="tns:GetSaleStakeholderResponse" />
  </wsdl:message>
  <wsdl:message name="GetSaleStakeholderResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleStakeholderListRequest">
    <wsdl:part name="parameters" element="tns:GetSaleStakeholderList" />
  </wsdl:message>
  <wsdl:message name="GetSaleStakeholderListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleStakeholderListResponse">
    <wsdl:part name="parameters" element="tns:GetSaleStakeholderListResponse" />
  </wsdl:message>
  <wsdl:message name="GetSaleStakeholderListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleStakeholdersRequest">
    <wsdl:part name="parameters" element="tns:GetSaleStakeholders" />
  </wsdl:message>
  <wsdl:message name="GetSaleStakeholdersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleStakeholdersResponse">
    <wsdl:part name="parameters" element="tns:GetSaleStakeholdersResponse" />
  </wsdl:message>
  <wsdl:message name="GetSaleStakeholdersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateSaleStakeholdersRequest">
    <wsdl:part name="parameters" element="tns:UpdateSaleStakeholders" />
  </wsdl:message>
  <wsdl:message name="UpdateSaleStakeholdersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateSaleStakeholdersResponse">
    <wsdl:part name="parameters" element="tns:UpdateSaleStakeholdersResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateSaleStakeholdersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleStakeholderByIdRequest">
    <wsdl:part name="parameters" element="tns:GetSaleStakeholderById" />
  </wsdl:message>
  <wsdl:message name="GetSaleStakeholderByIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSaleStakeholderByIdResponse">
    <wsdl:part name="parameters" element="tns:GetSaleStakeholderByIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetSaleStakeholderByIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSummaryByAssociateRequest">
    <wsdl:part name="parameters" element="tns:GetSummaryByAssociate" />
  </wsdl:message>
  <wsdl:message name="GetSummaryByAssociateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSummaryByAssociateResponse">
    <wsdl:part name="parameters" element="tns:GetSummaryByAssociateResponse" />
  </wsdl:message>
  <wsdl:message name="GetSummaryByAssociateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSummaryByGroupRequest">
    <wsdl:part name="parameters" element="tns:GetSummaryByGroup" />
  </wsdl:message>
  <wsdl:message name="GetSummaryByGroupRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSummaryByGroupResponse">
    <wsdl:part name="parameters" element="tns:GetSummaryByGroupResponse" />
  </wsdl:message>
  <wsdl:message name="GetSummaryByGroupResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSummaryByContactRequest">
    <wsdl:part name="parameters" element="tns:GetSummaryByContact" />
  </wsdl:message>
  <wsdl:message name="GetSummaryByContactRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSummaryByContactResponse">
    <wsdl:part name="parameters" element="tns:GetSummaryByContactResponse" />
  </wsdl:message>
  <wsdl:message name="GetSummaryByContactResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Sale">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Sale</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultSaleEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new SaleEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/CreateDefaultSaleEntity" name="CreateDefaultSaleEntityRequest" message="tns:CreateDefaultSaleEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/CreateDefaultSaleEntityResponse" name="CreateDefaultSaleEntityResponse" message="tns:CreateDefaultSaleEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveSaleEntity">
      <wsdl:documentation>
        <summary>Updates the existing SaleEntity or creates a new SaleEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/SaveSaleEntity" name="SaveSaleEntityRequest" message="tns:SaveSaleEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/SaveSaleEntityResponse" name="SaveSaleEntityResponse" message="tns:SaveSaleEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteSaleEntity">
      <wsdl:documentation>
        <summary>Deletes the SaleEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/DeleteSaleEntity" name="DeleteSaleEntityRequest" message="tns:DeleteSaleEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/DeleteSaleEntityResponse" name="DeleteSaleEntityResponse" message="tns:DeleteSaleEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultSaleSummary">
      <wsdl:documentation>
        <summary>Loading default values into a new SaleSummary.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/CreateDefaultSaleSummary" name="CreateDefaultSaleSummaryRequest" message="tns:CreateDefaultSaleSummaryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/CreateDefaultSaleSummaryResponse" name="CreateDefaultSaleSummaryResponse" message="tns:CreateDefaultSaleSummaryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSale">
      <wsdl:documentation>
        <summary>Gets a Sale object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSale" name="GetSaleRequest" message="tns:GetSaleRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleResponse" name="GetSaleResponse" message="tns:GetSaleResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSaleEntity">
      <wsdl:documentation>
        <summary>Gets a SaleEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleEntity" name="GetSaleEntityRequest" message="tns:GetSaleEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleEntityResponse" name="GetSaleEntityResponse" message="tns:GetSaleEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="HasGuide">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/HasGuide" name="HasGuideRequest" message="tns:HasGuideRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/HasGuideResponse" name="HasGuideResponse" message="tns:HasGuideResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNextDueDate">
      <wsdl:documentation>
        <summary>Gets the next due date for a sale. The next due date is the a </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetNextDueDate" name="GetNextDueDateRequest" message="tns:GetNextDueDateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetNextDueDateResponse" name="GetNextDueDateResponse" message="tns:GetNextDueDateResponse" />
    </wsdl:operation>
    <wsdl:operation name="BatchUpdateNextDueDate">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/BatchUpdateNextDueDate" name="BatchUpdateNextDueDateRequest" message="tns:BatchUpdateNextDueDateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/BatchUpdateNextDueDateResponse" name="BatchUpdateNextDueDateResponse" message="tns:BatchUpdateNextDueDateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNextSaleStage">
      <wsdl:documentation>
        <summary>Gets the next (not deleted) sale stage id if the current stage is deleted. If the current stage is not deleted, the CurrentStageId is returned</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetNextSaleStage" name="GetNextSaleStageRequest" message="tns:GetNextSaleStageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetNextSaleStageResponse" name="GetNextSaleStageResponse" message="tns:GetNextSaleStageResponse" />
    </wsdl:operation>
    <wsdl:operation name="HasGuideActivities">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/HasGuideActivities" name="HasGuideActivitiesRequest" message="tns:HasGuideActivitiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/HasGuideActivitiesResponse" name="HasGuideActivitiesResponse" message="tns:HasGuideActivitiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="OfferAutoNextStageOnApppointmentCompleted">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/OfferAutoNextStageOnApppointmentCompleted" name="OfferAutoNextStageOnApppointmentCompletedRequest" message="tns:OfferAutoNextStageOnApppointmentCompletedRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/OfferAutoNextStageOnApppointmentCompletedResponse" name="OfferAutoNextStageOnApppointmentCompletedResponse" message="tns:OfferAutoNextStageOnApppointmentCompletedResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProbabilityFromStage">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetProbabilityFromStage" name="GetProbabilityFromStageRequest" message="tns:GetProbabilityFromStageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetProbabilityFromStageResponse" name="GetProbabilityFromStageResponse" message="tns:GetProbabilityFromStageResponse" />
    </wsdl:operation>
    <wsdl:operation name="IsNumberValid">
      <wsdl:documentation>
        <summary>Checks if the number is unique or required.  The setting is configured from admin under system options.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/IsNumberValid" name="IsNumberValidRequest" message="tns:IsNumberValidRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/IsNumberValidResponse" name="IsNumberValidResponse" message="tns:IsNumberValidResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddSaleStakeholders">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/AddSaleStakeholders" name="AddSaleStakeholdersRequest" message="tns:AddSaleStakeholdersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/AddSaleStakeholdersResponse" name="AddSaleStakeholdersResponse" message="tns:AddSaleStakeholdersResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteSaleStakeholders">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/DeleteSaleStakeholders" name="DeleteSaleStakeholdersRequest" message="tns:DeleteSaleStakeholdersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/DeleteSaleStakeholdersResponse" name="DeleteSaleStakeholdersResponse" message="tns:DeleteSaleStakeholdersResponse" />
    </wsdl:operation>
    <wsdl:operation name="HasStakeholderSetting">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/HasStakeholderSetting" name="HasStakeholderSettingRequest" message="tns:HasStakeholderSettingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/HasStakeholderSettingResponse" name="HasStakeholderSettingResponse" message="tns:HasStakeholderSettingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSaleList">
      <wsdl:documentation>
        <summary>Gets an array of Sale objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleList" name="GetSaleListRequest" message="tns:GetSaleListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleListResponse" name="GetSaleListResponse" message="tns:GetSaleListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyOpportunities">
      <wsdl:documentation>
        <summary>Returning the opportunities (open sales) belonging to the user currently logged on</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetMyOpportunities" name="GetMyOpportunitiesRequest" message="tns:GetMyOpportunitiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetMyOpportunitiesResponse" name="GetMyOpportunitiesResponse" message="tns:GetMyOpportunitiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetRecentSales">
      <wsdl:documentation>
        <summary>Returns the latest sales (that are sold) limited by their amount. The result is sorted descending with the latest first. If the amount is -1, the amount restriction is omitted.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetRecentSales" name="GetRecentSalesRequest" message="tns:GetRecentSalesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetRecentSalesResponse" name="GetRecentSalesResponse" message="tns:GetRecentSalesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUpcomingSales">
      <wsdl:documentation>
        <summary>Returns all open sales, sorted descending with the latest first.  If the weigthed amount is -1, the amount restriction is omitted.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetUpcomingSales" name="GetUpcomingSalesRequest" message="tns:GetUpcomingSalesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetUpcomingSalesResponse" name="GetUpcomingSalesResponse" message="tns:GetUpcomingSalesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSalesByDate">
      <wsdl:documentation>
        <summary>Returns all sales within a time period. The sales array can be limited by amount and status.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSalesByDate" name="GetSalesByDateRequest" message="tns:GetSalesByDateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSalesByDateResponse" name="GetSalesByDateResponse" message="tns:GetSalesByDateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetOpenSalesForContact">
      <wsdl:documentation>
        <summary>Returns all open sales for the contact provided.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetOpenSalesForContact" name="GetOpenSalesForContactRequest" message="tns:GetOpenSalesForContactRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetOpenSalesForContactResponse" name="GetOpenSalesForContactResponse" message="tns:GetOpenSalesForContactResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetAsSold">
      <wsdl:documentation>
        <summary>Change the status of one or more Sales to Sold. Note that this does not mark them as Completed.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/SetAsSold" name="SetAsSoldRequest" message="tns:SetAsSoldRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/SetAsSoldResponse" name="SetAsSoldResponse" message="tns:SetAsSoldResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetAsLost">
      <wsdl:documentation>
        <summary>Change the status of one or more sales to Lost. Note that this does not affect the Completed state of the sale.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/SetAsLost" name="SetAsLostRequest" message="tns:SetAsLostRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/SetAsLostResponse" name="SetAsLostResponse" message="tns:SetAsLostResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSaleStakeholder">
      <wsdl:documentation>
        <summary>Gets a SaleStakeholder object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleStakeholder" name="GetSaleStakeholderRequest" message="tns:GetSaleStakeholderRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleStakeholderResponse" name="GetSaleStakeholderResponse" message="tns:GetSaleStakeholderResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSaleStakeholderList">
      <wsdl:documentation>
        <summary>Gets an array of SaleStakeholder objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleStakeholderList" name="GetSaleStakeholderListRequest" message="tns:GetSaleStakeholderListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleStakeholderListResponse" name="GetSaleStakeholderListResponse" message="tns:GetSaleStakeholderListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSaleStakeholders">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleStakeholders" name="GetSaleStakeholdersRequest" message="tns:GetSaleStakeholdersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleStakeholdersResponse" name="GetSaleStakeholdersResponse" message="tns:GetSaleStakeholdersResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateSaleStakeholders">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/UpdateSaleStakeholders" name="UpdateSaleStakeholdersRequest" message="tns:UpdateSaleStakeholdersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/UpdateSaleStakeholdersResponse" name="UpdateSaleStakeholdersResponse" message="tns:UpdateSaleStakeholdersResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSaleStakeholderById">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleStakeholderById" name="GetSaleStakeholderByIdRequest" message="tns:GetSaleStakeholderByIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleStakeholderByIdResponse" name="GetSaleStakeholderByIdResponse" message="tns:GetSaleStakeholderByIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSummaryByAssociate">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSummaryByAssociate" name="GetSummaryByAssociateRequest" message="tns:GetSummaryByAssociateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSummaryByAssociateResponse" name="GetSummaryByAssociateResponse" message="tns:GetSummaryByAssociateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSummaryByGroup">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSummaryByGroup" name="GetSummaryByGroupRequest" message="tns:GetSummaryByGroupRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSummaryByGroupResponse" name="GetSummaryByGroupResponse" message="tns:GetSummaryByGroupResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSummaryByContact">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSummaryByContact" name="GetSummaryByContactRequest" message="tns:GetSummaryByContactRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSummaryByContactResponse" name="GetSummaryByContactResponse" message="tns:GetSummaryByContactResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Sale" type="tns:Sale">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultSaleEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/CreateDefaultSaleEntity" style="document" />
      <wsdl:input name="CreateDefaultSaleEntityRequest">
        <soap:header message="tns:CreateDefaultSaleEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultSaleEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultSaleEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultSaleEntityResponse">
        <soap:header message="tns:CreateDefaultSaleEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSaleEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSaleEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultSaleEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveSaleEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/SaveSaleEntity" style="document" />
      <wsdl:input name="SaveSaleEntityRequest">
        <soap:header message="tns:SaveSaleEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveSaleEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveSaleEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveSaleEntityResponse">
        <soap:header message="tns:SaveSaleEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveSaleEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveSaleEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveSaleEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteSaleEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/DeleteSaleEntity" style="document" />
      <wsdl:input name="DeleteSaleEntityRequest">
        <soap:header message="tns:DeleteSaleEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteSaleEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteSaleEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteSaleEntityResponse">
        <soap:header message="tns:DeleteSaleEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteSaleEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteSaleEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteSaleEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultSaleSummary">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/CreateDefaultSaleSummary" style="document" />
      <wsdl:input name="CreateDefaultSaleSummaryRequest">
        <soap:header message="tns:CreateDefaultSaleSummaryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultSaleSummaryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultSaleSummaryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultSaleSummaryResponse">
        <soap:header message="tns:CreateDefaultSaleSummaryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSaleSummaryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSaleSummaryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultSaleSummaryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSale">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSale" style="document" />
      <wsdl:input name="GetSaleRequest">
        <soap:header message="tns:GetSaleRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSaleRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSaleRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSaleResponse">
        <soap:header message="tns:GetSaleResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSaleResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSaleResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSaleResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSaleEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleEntity" style="document" />
      <wsdl:input name="GetSaleEntityRequest">
        <soap:header message="tns:GetSaleEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSaleEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSaleEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSaleEntityResponse">
        <soap:header message="tns:GetSaleEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSaleEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSaleEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSaleEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="HasGuide">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/HasGuide" style="document" />
      <wsdl:input name="HasGuideRequest">
        <soap:header message="tns:HasGuideRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:HasGuideRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:HasGuideRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="HasGuideResponse">
        <soap:header message="tns:HasGuideResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:HasGuideResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:HasGuideResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:HasGuideResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNextDueDate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetNextDueDate" style="document" />
      <wsdl:input name="GetNextDueDateRequest">
        <soap:header message="tns:GetNextDueDateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNextDueDateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNextDueDateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNextDueDateResponse">
        <soap:header message="tns:GetNextDueDateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNextDueDateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNextDueDateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNextDueDateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="BatchUpdateNextDueDate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/BatchUpdateNextDueDate" style="document" />
      <wsdl:input name="BatchUpdateNextDueDateRequest">
        <soap:header message="tns:BatchUpdateNextDueDateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:BatchUpdateNextDueDateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:BatchUpdateNextDueDateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="BatchUpdateNextDueDateResponse">
        <soap:header message="tns:BatchUpdateNextDueDateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:BatchUpdateNextDueDateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:BatchUpdateNextDueDateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:BatchUpdateNextDueDateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNextSaleStage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetNextSaleStage" style="document" />
      <wsdl:input name="GetNextSaleStageRequest">
        <soap:header message="tns:GetNextSaleStageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNextSaleStageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNextSaleStageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNextSaleStageResponse">
        <soap:header message="tns:GetNextSaleStageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNextSaleStageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNextSaleStageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNextSaleStageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="HasGuideActivities">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/HasGuideActivities" style="document" />
      <wsdl:input name="HasGuideActivitiesRequest">
        <soap:header message="tns:HasGuideActivitiesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:HasGuideActivitiesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:HasGuideActivitiesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="HasGuideActivitiesResponse">
        <soap:header message="tns:HasGuideActivitiesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:HasGuideActivitiesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:HasGuideActivitiesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:HasGuideActivitiesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="OfferAutoNextStageOnApppointmentCompleted">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/OfferAutoNextStageOnApppointmentCompleted" style="document" />
      <wsdl:input name="OfferAutoNextStageOnApppointmentCompletedRequest">
        <soap:header message="tns:OfferAutoNextStageOnApppointmentCompletedRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:OfferAutoNextStageOnApppointmentCompletedRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:OfferAutoNextStageOnApppointmentCompletedRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="OfferAutoNextStageOnApppointmentCompletedResponse">
        <soap:header message="tns:OfferAutoNextStageOnApppointmentCompletedResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:OfferAutoNextStageOnApppointmentCompletedResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:OfferAutoNextStageOnApppointmentCompletedResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:OfferAutoNextStageOnApppointmentCompletedResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProbabilityFromStage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetProbabilityFromStage" style="document" />
      <wsdl:input name="GetProbabilityFromStageRequest">
        <soap:header message="tns:GetProbabilityFromStageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProbabilityFromStageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProbabilityFromStageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProbabilityFromStageResponse">
        <soap:header message="tns:GetProbabilityFromStageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProbabilityFromStageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProbabilityFromStageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProbabilityFromStageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="IsNumberValid">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/IsNumberValid" style="document" />
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
    <wsdl:operation name="AddSaleStakeholders">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/AddSaleStakeholders" style="document" />
      <wsdl:input name="AddSaleStakeholdersRequest">
        <soap:header message="tns:AddSaleStakeholdersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddSaleStakeholdersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddSaleStakeholdersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddSaleStakeholdersResponse">
        <soap:header message="tns:AddSaleStakeholdersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddSaleStakeholdersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddSaleStakeholdersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddSaleStakeholdersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteSaleStakeholders">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/DeleteSaleStakeholders" style="document" />
      <wsdl:input name="DeleteSaleStakeholdersRequest">
        <soap:header message="tns:DeleteSaleStakeholdersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteSaleStakeholdersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteSaleStakeholdersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteSaleStakeholdersResponse">
        <soap:header message="tns:DeleteSaleStakeholdersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteSaleStakeholdersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteSaleStakeholdersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteSaleStakeholdersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="HasStakeholderSetting">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/HasStakeholderSetting" style="document" />
      <wsdl:input name="HasStakeholderSettingRequest">
        <soap:header message="tns:HasStakeholderSettingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:HasStakeholderSettingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:HasStakeholderSettingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="HasStakeholderSettingResponse">
        <soap:header message="tns:HasStakeholderSettingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:HasStakeholderSettingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:HasStakeholderSettingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:HasStakeholderSettingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSaleList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleList" style="document" />
      <wsdl:input name="GetSaleListRequest">
        <soap:header message="tns:GetSaleListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSaleListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSaleListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSaleListResponse">
        <soap:header message="tns:GetSaleListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSaleListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSaleListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSaleListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyOpportunities">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetMyOpportunities" style="document" />
      <wsdl:input name="GetMyOpportunitiesRequest">
        <soap:header message="tns:GetMyOpportunitiesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyOpportunitiesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyOpportunitiesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyOpportunitiesResponse">
        <soap:header message="tns:GetMyOpportunitiesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyOpportunitiesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyOpportunitiesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyOpportunitiesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetRecentSales">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetRecentSales" style="document" />
      <wsdl:input name="GetRecentSalesRequest">
        <soap:header message="tns:GetRecentSalesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetRecentSalesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetRecentSalesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetRecentSalesResponse">
        <soap:header message="tns:GetRecentSalesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetRecentSalesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetRecentSalesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetRecentSalesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUpcomingSales">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetUpcomingSales" style="document" />
      <wsdl:input name="GetUpcomingSalesRequest">
        <soap:header message="tns:GetUpcomingSalesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUpcomingSalesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUpcomingSalesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUpcomingSalesResponse">
        <soap:header message="tns:GetUpcomingSalesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUpcomingSalesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUpcomingSalesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUpcomingSalesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSalesByDate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSalesByDate" style="document" />
      <wsdl:input name="GetSalesByDateRequest">
        <soap:header message="tns:GetSalesByDateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSalesByDateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSalesByDateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSalesByDateResponse">
        <soap:header message="tns:GetSalesByDateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSalesByDateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSalesByDateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSalesByDateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetOpenSalesForContact">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetOpenSalesForContact" style="document" />
      <wsdl:input name="GetOpenSalesForContactRequest">
        <soap:header message="tns:GetOpenSalesForContactRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetOpenSalesForContactRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetOpenSalesForContactRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetOpenSalesForContactResponse">
        <soap:header message="tns:GetOpenSalesForContactResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetOpenSalesForContactResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetOpenSalesForContactResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetOpenSalesForContactResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetAsSold">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/SetAsSold" style="document" />
      <wsdl:input name="SetAsSoldRequest">
        <soap:header message="tns:SetAsSoldRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetAsSoldRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetAsSoldRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetAsSoldResponse">
        <soap:header message="tns:SetAsSoldResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetAsSoldResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetAsSoldResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetAsSoldResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetAsLost">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/SetAsLost" style="document" />
      <wsdl:input name="SetAsLostRequest">
        <soap:header message="tns:SetAsLostRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetAsLostRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetAsLostRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetAsLostResponse">
        <soap:header message="tns:SetAsLostResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetAsLostResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetAsLostResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetAsLostResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSaleStakeholder">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleStakeholder" style="document" />
      <wsdl:input name="GetSaleStakeholderRequest">
        <soap:header message="tns:GetSaleStakeholderRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSaleStakeholderRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSaleStakeholderRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSaleStakeholderResponse">
        <soap:header message="tns:GetSaleStakeholderResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSaleStakeholderResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSaleStakeholderResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSaleStakeholderResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSaleStakeholderList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleStakeholderList" style="document" />
      <wsdl:input name="GetSaleStakeholderListRequest">
        <soap:header message="tns:GetSaleStakeholderListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSaleStakeholderListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSaleStakeholderListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSaleStakeholderListResponse">
        <soap:header message="tns:GetSaleStakeholderListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSaleStakeholderListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSaleStakeholderListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSaleStakeholderListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSaleStakeholders">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleStakeholders" style="document" />
      <wsdl:input name="GetSaleStakeholdersRequest">
        <soap:header message="tns:GetSaleStakeholdersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSaleStakeholdersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSaleStakeholdersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSaleStakeholdersResponse">
        <soap:header message="tns:GetSaleStakeholdersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSaleStakeholdersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSaleStakeholdersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSaleStakeholdersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateSaleStakeholders">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/UpdateSaleStakeholders" style="document" />
      <wsdl:input name="UpdateSaleStakeholdersRequest">
        <soap:header message="tns:UpdateSaleStakeholdersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateSaleStakeholdersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateSaleStakeholdersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateSaleStakeholdersResponse">
        <soap:header message="tns:UpdateSaleStakeholdersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateSaleStakeholdersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateSaleStakeholdersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateSaleStakeholdersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSaleStakeholderById">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSaleStakeholderById" style="document" />
      <wsdl:input name="GetSaleStakeholderByIdRequest">
        <soap:header message="tns:GetSaleStakeholderByIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSaleStakeholderByIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSaleStakeholderByIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSaleStakeholderByIdResponse">
        <soap:header message="tns:GetSaleStakeholderByIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSaleStakeholderByIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSaleStakeholderByIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSaleStakeholderByIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSummaryByAssociate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSummaryByAssociate" style="document" />
      <wsdl:input name="GetSummaryByAssociateRequest">
        <soap:header message="tns:GetSummaryByAssociateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSummaryByAssociateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSummaryByAssociateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSummaryByAssociateResponse">
        <soap:header message="tns:GetSummaryByAssociateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSummaryByAssociateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSummaryByAssociateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSummaryByAssociateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSummaryByGroup">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSummaryByGroup" style="document" />
      <wsdl:input name="GetSummaryByGroupRequest">
        <soap:header message="tns:GetSummaryByGroupRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSummaryByGroupRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSummaryByGroupRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSummaryByGroupResponse">
        <soap:header message="tns:GetSummaryByGroupResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSummaryByGroupResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSummaryByGroupResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSummaryByGroupResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSummaryByContact">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services81/Sale/GetSummaryByContact" style="document" />
      <wsdl:input name="GetSummaryByContactRequest">
        <soap:header message="tns:GetSummaryByContactRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSummaryByContactRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSummaryByContactRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSummaryByContactResponse">
        <soap:header message="tns:GetSummaryByContactResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSummaryByContactResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSummaryByContactResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSummaryByContactResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfSaleService">
    <wsdl:port name="BasicHttpBinding_Sale" binding="tns:BasicHttpBinding_Sale">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services81/Sale.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

