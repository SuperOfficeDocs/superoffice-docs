---
generated: true
uid: wsdl-Services88-Ticket
title: Services88.TicketAgent WSDL
---

# Services88.TicketAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfTicketService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultAttachmentEntity">
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
      <xs:element name="CreateDefaultAttachmentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:AttachmentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="AttachmentEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="AttachmentId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContentType" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AttSize" type="xs:int" />
              <xs:element minOccurs="0" name="InlineImage" type="xs:boolean" />
              <xs:element minOccurs="0" name="ContentId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AuthKey" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AttachmentEntity" nillable="true" type="tns:AttachmentEntity" />
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
      <xs:element name="SaveAttachmentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AttachmentEntity" nillable="true" type="tns:AttachmentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveAttachmentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:AttachmentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTicketEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTicketEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="TicketEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="TicketId" type="xs:int" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CreatedAt" type="xs:dateTime" />
              <xs:element minOccurs="0" name="LastChanged" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ReadByOwner" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ReadByCustomer" type="xs:dateTime" />
              <xs:element minOccurs="0" name="FirstReadByOwner" type="xs:dateTime" />
              <xs:element minOccurs="0" name="FirstReadByUser" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Activate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ClosedAt" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RepliedAt" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AlertTimeout" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Deadline" type="xs:dateTime" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="Author" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OwnedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="Category" nillable="true" type="tns:TicketCategoryEntity" />
              <xs:element minOccurs="0" name="Slevel" type="tns:TicketSecurityLevel" />
              <xs:element minOccurs="0" name="Priority" nillable="true" type="tns:TicketPriorityEntity" />
              <xs:element minOccurs="0" name="BaseStatus" type="tns:TicketBaseStatus" />
              <xs:element minOccurs="0" name="Status" nillable="true" type="tns:TicketStatusEntity" />
              <xs:element minOccurs="0" name="Origin" type="tns:TicketOrigin" />
              <xs:element minOccurs="0" name="Person" nillable="true" type="tns:Person" />
              <xs:element minOccurs="0" name="SecondaryPersons" nillable="true" type="tns:ArrayOfPerson" />
              <xs:element minOccurs="0" name="AlertLevel" type="xs:short" />
              <xs:element minOccurs="0" name="ConnectId" type="xs:int" />
              <xs:element minOccurs="0" name="ReadStatus" type="tns:TicketReadStatus" />
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
              <xs:element minOccurs="0" name="TimeSpent" type="xs:int" />
              <xs:element minOccurs="0" name="HasAttachment" type="xs:boolean" />
              <xs:element minOccurs="0" name="NumReplies" type="xs:int" />
              <xs:element minOccurs="0" name="NumMessages" type="xs:int" />
              <xs:element minOccurs="0" name="FromAddress" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Messages" nillable="true" type="tns:ArrayOfTicketMessage" />
              <xs:element minOccurs="0" name="Tags" nillable="true" type="tns:ArrayOfTag" />
              <xs:element minOccurs="0" name="Language" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Sentiment" type="xs:int" />
              <xs:element minOccurs="0" name="SentimentConfidence" type="xs:int" />
              <xs:element minOccurs="0" name="SuggestedCategoryId" type="xs:int" />
              <xs:element minOccurs="0" name="SuggestedCategoryName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OrigHumanCategoryId" type="xs:int" />
              <xs:element minOccurs="0" name="IconHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Sale" nillable="true" type="tns:Sale" />
              <xs:element minOccurs="0" name="Project" nillable="true" type="tns:Project" />
              <xs:element minOccurs="0" name="FormSubmission" nillable="true" type="tns:TicketFormSubmission" />
              <xs:element minOccurs="0" name="TicketType" nillable="true" type="tns:TicketTypeEntity" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="tns:StringDictionary" />
              <xs:element minOccurs="0" name="CustomFields" nillable="true" type="tns:StringDictionary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TicketEntity" nillable="true" type="tns:TicketEntity" />
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
      <xs:complexType name="TicketCategoryEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="TicketCategoryId" type="xs:int" />
              <xs:element minOccurs="0" name="ParentId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Fullname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CategoryMaster" type="xs:int" />
              <xs:element minOccurs="0" name="Flags" type="tns:TicketCategoryFlags" />
              <xs:element minOccurs="0" name="DelegateMethod" type="tns:TicketCategoryDelegateMethod" />
              <xs:element minOccurs="0" name="ExternalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ClosingStatus" type="tns:TicketCategoryClosingStatus" />
              <xs:element minOccurs="0" name="MsgClosingStatus" type="tns:TicketCategoryClosingStatus" />
              <xs:element minOccurs="0" name="AssignmentLag" type="xs:int" />
              <xs:element minOccurs="0" name="ReplyTemplate" type="xs:int" />
              <xs:element minOccurs="0" name="NotificationEmail" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DefaultTicketStatus" nillable="true" type="tns:TicketStatusEntity" />
              <xs:element minOccurs="0" name="DefaultMessageStatus" nillable="true" type="tns:TicketStatusEntity" />
              <xs:element minOccurs="0" name="EffectiveReplyTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="tns:StringDictionary" />
              <xs:element minOccurs="0" name="CustomFields" nillable="true" type="tns:StringDictionary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TicketCategoryEntity" nillable="true" type="tns:TicketCategoryEntity" />
      <xs:simpleType name="TicketCategoryFlags">
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="Internal" />
              <xs:enumeration value="OnlyLoggedInUsers" />
              <xs:enumeration value="DefaultToCategoryMaster" />
              <xs:enumeration value="ListInMain" />
              <xs:enumeration value="RedelegateNewMsg" />
              <xs:enumeration value="DelegateToOurContact" />
              <xs:enumeration value="PropagateReplyTemplate" />
              <xs:enumeration value="MembersOnly" />
              <xs:enumeration value="NotifyMembers" />
              <xs:enumeration value="AcceptWhenReplying" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="TicketCategoryFlags" nillable="true" type="tns:TicketCategoryFlags" />
      <xs:simpleType name="TicketCategoryDelegateMethod">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Even" />
          <xs:enumeration value="Weighted" />
          <xs:enumeration value="Unfair" />
          <xs:enumeration value="Not" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TicketCategoryDelegateMethod" nillable="true" type="tns:TicketCategoryDelegateMethod" />
      <xs:simpleType name="TicketCategoryClosingStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="UserDefined" />
          <xs:enumeration value="Active" />
          <xs:enumeration value="Closed" />
          <xs:enumeration value="Postponed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TicketCategoryClosingStatus" nillable="true" type="tns:TicketCategoryClosingStatus" />
      <xs:complexType name="TicketStatusEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="TicketStatusId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Status" type="tns:TicketBaseStatus" />
              <xs:element minOccurs="0" name="TimeCounter" type="tns:TicketStatusTimeCounter" />
              <xs:element minOccurs="0" name="NoEmailReopen" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsDefault" type="xs:boolean" />
              <xs:element minOccurs="0" name="UsedInQueue" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TicketStatusEntity" nillable="true" type="tns:TicketStatusEntity" />
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
          <xs:enumeration value="PostponedSpecific">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1001</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Postponed1Hour">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1002</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Postponed2Hours">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1003</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Postponed3Hours">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1004</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Postponed4Hours">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1005</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="PostponedDay">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1006</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="PostponedWeek">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1007</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="PostponedMonth">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1008</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TicketBaseStatus" nillable="true" type="tns:TicketBaseStatus" />
      <xs:simpleType name="TicketStatusTimeCounter">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Internally" />
          <xs:enumeration value="Externally" />
          <xs:enumeration value="Queue" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TicketStatusTimeCounter" nillable="true" type="tns:TicketStatusTimeCounter" />
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
      <xs:element name="TicketSecurityLevel" nillable="true" type="tns:TicketSecurityLevel" />
      <xs:complexType name="TicketPriorityEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="TicketPriorityId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Status" type="tns:TicketPriorityStatus" />
              <xs:element minOccurs="0" name="Flags" type="tns:TicketPriorityFlags" />
              <xs:element minOccurs="0" name="SortOrder" type="xs:int" />
              <xs:element minOccurs="0" name="TicketRead" type="tns:TicketPriorityEscalateEvent" />
              <xs:element minOccurs="0" name="ChangedOwner" type="tns:TicketPriorityEscalateEvent" />
              <xs:element minOccurs="0" name="TicketNewinfo" type="tns:TicketPriorityEscalateEvent" />
              <xs:element minOccurs="0" name="TicketClosed" type="tns:TicketPriorityEscalateEvent" />
              <xs:element minOccurs="0" name="TicketChangedPriority" type="tns:TicketPriorityEscalateEvent" />
              <xs:element minOccurs="0" name="TicketNew" type="tns:TicketPriorityEscalateEvent" />
              <xs:element minOccurs="0" name="Deadline" type="xs:int" />
              <xs:element minOccurs="0" name="MonStart" type="xs:dateTime" />
              <xs:element minOccurs="0" name="MonStop" type="xs:dateTime" />
              <xs:element minOccurs="0" name="TueStart" type="xs:dateTime" />
              <xs:element minOccurs="0" name="TueStop" type="xs:dateTime" />
              <xs:element minOccurs="0" name="WedStart" type="xs:dateTime" />
              <xs:element minOccurs="0" name="WedStop" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ThuStart" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ThuStop" type="xs:dateTime" />
              <xs:element minOccurs="0" name="FriStart" type="xs:dateTime" />
              <xs:element minOccurs="0" name="FriStop" type="xs:dateTime" />
              <xs:element minOccurs="0" name="SatStart" type="xs:dateTime" />
              <xs:element minOccurs="0" name="SatStop" type="xs:dateTime" />
              <xs:element minOccurs="0" name="SunStart" type="xs:dateTime" />
              <xs:element minOccurs="0" name="SunStop" type="xs:dateTime" />
              <xs:element minOccurs="0" name="NonDates" nillable="true" type="q1:ArrayOfdateTime" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="EscalationLevels" nillable="true" type="tns:ArrayOfTicketPriorityEscalationLevelEntity" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TicketPriorityEntity" nillable="true" type="tns:TicketPriorityEntity" />
      <xs:simpleType name="TicketPriorityStatus">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Normal" />
          <xs:enumeration value="Deleted" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TicketPriorityStatus" nillable="true" type="tns:TicketPriorityStatus" />
      <xs:simpleType name="TicketPriorityFlags">
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="External" />
              <xs:enumeration value="Default" />
              <xs:enumeration value="AlertSchedule" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="TicketPriorityFlags" nillable="true" type="tns:TicketPriorityFlags" />
      <xs:simpleType name="TicketPriorityEscalateEvent">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">-1</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Stop">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">0</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Continue">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Restart">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">2</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TicketPriorityEscalateEvent" nillable="true" type="tns:TicketPriorityEscalateEvent" />
      <xs:complexType name="ArrayOfTicketPriorityEscalationLevelEntity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TicketPriorityEscalationLevelEntity" nillable="true" type="tns:TicketPriorityEscalationLevelEntity" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTicketPriorityEscalationLevelEntity" nillable="true" type="tns:ArrayOfTicketPriorityEscalationLevelEntity" />
      <xs:complexType name="TicketPriorityEscalationLevelEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="TicketAlertId" type="xs:int" />
              <xs:element minOccurs="0" name="AlertLevel" type="xs:short" />
              <xs:element minOccurs="0" name="AlertTimeout" type="xs:int" />
              <xs:element minOccurs="0" name="Action" type="xs:int" />
              <xs:element minOccurs="0" name="DelegateTo" type="xs:int" />
              <xs:element minOccurs="0" name="ScriptId" type="xs:int" />
              <xs:element minOccurs="0" name="EmailTo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SmsTo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ReplyTemplateIdCustomer" type="xs:int" />
              <xs:element minOccurs="0" name="ReplyTemplateIdUser" type="xs:int" />
              <xs:element minOccurs="0" name="ReplyTemplateIdCatmast" type="xs:int" />
              <xs:element minOccurs="0" name="ReplyTemplateIdEmail" type="xs:int" />
              <xs:element minOccurs="0" name="RtiCustomerSms" type="xs:int" />
              <xs:element minOccurs="0" name="ReplyTemplateIdUserSms" type="xs:int" />
              <xs:element minOccurs="0" name="ReplyTemplateIdCatmastSms" type="xs:int" />
              <xs:element minOccurs="0" name="ReplyTemplateIdSms" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TicketPriorityEscalationLevelEntity" nillable="true" type="tns:TicketPriorityEscalationLevelEntity" />
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
      <xs:element name="TicketOrigin" nillable="true" type="tns:TicketOrigin" />
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
      <xs:complexType name="ArrayOfPerson">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Person" nillable="true" type="tns:Person" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfPerson" nillable="true" type="tns:ArrayOfPerson" />
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
      <xs:element name="TicketReadStatus" nillable="true" type="tns:TicketReadStatus" />
      <xs:complexType name="ArrayOfTicketMessage">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TicketMessage" nillable="true" type="tns:TicketMessage" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTicketMessage" nillable="true" type="tns:ArrayOfTicketMessage" />
      <xs:complexType name="TicketMessage">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="TicketMessageId" type="xs:int" />
              <xs:element minOccurs="0" name="CreatedAt" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Slevel" type="tns:TicketSecurityLevel" />
              <xs:element minOccurs="0" name="Important" type="xs:boolean" />
              <xs:element minOccurs="0" name="Author" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactDepartment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="NumAttachments" type="xs:int" />
              <xs:element minOccurs="0" name="EmailHeader" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MessageHeaders" nillable="true" type="tns:ArrayOfTicketMessageHeader" />
              <xs:element minOccurs="0" name="Language" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Sentiment" type="xs:int" />
              <xs:element minOccurs="0" name="SentimentConfidence" type="xs:int" />
              <xs:element minOccurs="0" name="CreatedBy" type="xs:int" />
              <xs:element minOccurs="0" name="ChangedAt" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Badge" type="tns:BadgeType" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TicketMessage" nillable="true" type="tns:TicketMessage" />
      <xs:complexType name="ArrayOfTicketMessageHeader">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TicketMessageHeader" nillable="true" type="tns:TicketMessageHeader" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTicketMessageHeader" nillable="true" type="tns:ArrayOfTicketMessageHeader" />
      <xs:complexType name="TicketMessageHeader">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StdItem" type="tns:MessageHeaderStdItem" />
              <xs:element minOccurs="0" name="StdItemCol" type="tns:MessageHeaderStdItemCol" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TicketMessageHeader" nillable="true" type="tns:TicketMessageHeader" />
      <xs:simpleType name="MessageHeaderStdItem">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Forward" />
          <xs:enumeration value="UnnamedAttachmentBlocked" />
          <xs:enumeration value="NoAutoReply" />
          <xs:enumeration value="SentAutoReplyToCustomersA" />
          <xs:enumeration value="SentAutoReplyToCustomersB" />
          <xs:enumeration value="CustomerReadFAQ" />
          <xs:enumeration value="ReplyTemplate" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="MessageHeaderStdItem" nillable="true" type="tns:MessageHeaderStdItem" />
      <xs:simpleType name="MessageHeaderStdItemCol">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Name" />
          <xs:enumeration value="Value" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="MessageHeaderStdItemCol" nillable="true" type="tns:MessageHeaderStdItemCol" />
      <xs:simpleType name="BadgeType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Reply" />
          <xs:enumeration value="Forward" />
          <xs:enumeration value="Comment" />
          <xs:enumeration value="Incoming" />
          <xs:enumeration value="Outgoing" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="BadgeType" nillable="true" type="tns:BadgeType" />
      <xs:complexType name="ArrayOfTag">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Tag" nillable="true" type="tns:Tag" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTag" nillable="true" type="tns:ArrayOfTag" />
      <xs:complexType name="Tag">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ToolTip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Tag" nillable="true" type="tns:Tag" />
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
      <xs:complexType name="TicketFormSubmission">
        <xs:sequence>
          <xs:element minOccurs="0" name="FormSubmissionId" type="xs:int" />
          <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Status" type="tns:FormSubmissionStatus" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TicketFormSubmission" nillable="true" type="tns:TicketFormSubmission" />
      <xs:simpleType name="FormSubmissionStatus">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="InProgress" />
          <xs:enumeration value="EmailVerification" />
          <xs:enumeration value="Submitted" />
          <xs:enumeration value="Processed" />
          <xs:enumeration value="Failed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="FormSubmissionStatus" nillable="true" type="tns:FormSubmissionStatus" />
      <xs:complexType name="TicketTypeEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="TicketTypeId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Icon" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DefaultTicketStatus" type="xs:int" />
              <xs:element minOccurs="0" name="TicketStatuses" nillable="true" type="q2:ArrayOfint" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="DefaultTicketPriority" type="xs:int" />
              <xs:element minOccurs="0" name="TicketPriorities" nillable="true" type="q3:ArrayOfint" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="ReplyTemplate" type="xs:int" />
              <xs:element minOccurs="0" name="IsExternalVisible" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsDefault" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TicketTypeEntity" nillable="true" type="tns:TicketTypeEntity" />
      <xs:element name="SaveTicketEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketEntity" nillable="true" type="tns:TicketEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTicketEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTicketMessageEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTicketMessageEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketMessageEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="TicketMessageEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="EjMessageId" type="xs:int" />
              <xs:element minOccurs="0" name="Ticket" nillable="true" type="tns:Ticket" />
              <xs:element minOccurs="0" name="CreatedAt" type="xs:dateTime" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="Author" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Slevel" type="tns:TicketSecurityLevel" />
              <xs:element minOccurs="0" name="Type" type="tns:TicketMessageType" />
              <xs:element minOccurs="0" name="MessageId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TimeSpent" type="xs:int" />
              <xs:element minOccurs="0" name="Body" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="HtmlBody" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EmailHeader" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DebugInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MailSorter" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MessageCategory" type="tns:TicketMessageCategory" />
              <xs:element minOccurs="0" name="Person" nillable="true" type="tns:Person" />
              <xs:element minOccurs="0" name="SearchTitle" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MessageHeaders" nillable="true" type="tns:ArrayOfTicketMessageHeader" />
              <xs:element minOccurs="0" name="Important" type="xs:boolean" />
              <xs:element minOccurs="0" name="Language" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Sentiment" type="xs:int" />
              <xs:element minOccurs="0" name="SentimentConfidence" type="xs:int" />
              <xs:element minOccurs="0" name="Badge" type="tns:BadgeType" />
              <xs:element minOccurs="0" name="AttachmentsInfo" nillable="true" type="tns:ArrayOfAttachmentEntity" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="tns:StringDictionary" />
              <xs:element minOccurs="0" name="CustomFields" nillable="true" type="tns:StringDictionary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TicketMessageEntity" nillable="true" type="tns:TicketMessageEntity" />
      <xs:complexType name="Ticket">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
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
              <xs:element minOccurs="0" name="Slevel" type="tns:TicketSecurityLevel" />
              <xs:element minOccurs="0" name="Priority" type="xs:int" />
              <xs:element minOccurs="0" name="PriorityName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="BaseStatus" type="tns:TicketBaseStatus" />
              <xs:element minOccurs="0" name="TicketStatus" type="xs:int" />
              <xs:element minOccurs="0" name="TicketStatusDisplayValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Origin" type="tns:TicketOrigin" />
              <xs:element minOccurs="0" name="CustId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonFirstname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonMiddleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonLastname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonFullname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AlertLevel" type="xs:short" />
              <xs:element minOccurs="0" name="ConnectId" type="xs:int" />
              <xs:element minOccurs="0" name="ReadStatus" type="tns:TicketReadStatus" />
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
              <xs:element minOccurs="0" name="TimeSpent" type="xs:int" />
              <xs:element minOccurs="0" name="HasAttachment" type="xs:boolean" />
              <xs:element minOccurs="0" name="NumReplies" type="xs:int" />
              <xs:element minOccurs="0" name="NumMessages" type="xs:int" />
              <xs:element minOccurs="0" name="FromAddress" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OwnedByAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Language" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Sentiment" type="xs:int" />
              <xs:element minOccurs="0" name="SentimentConfidence" type="xs:int" />
              <xs:element minOccurs="0" name="SaleId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleHeading" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjectName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FormSubmissionId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Ticket" nillable="true" type="tns:Ticket" />
      <xs:simpleType name="TicketMessageType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Plain" />
          <xs:enumeration value="Html" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TicketMessageType" nillable="true" type="tns:TicketMessageType" />
      <xs:simpleType name="TicketMessageCategory">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Message" />
          <xs:enumeration value="Bounce" />
          <xs:enumeration value="OutboxFailed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TicketMessageCategory" nillable="true" type="tns:TicketMessageCategory" />
      <xs:complexType name="ArrayOfAttachmentEntity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="AttachmentEntity" nillable="true" type="tns:AttachmentEntity" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfAttachmentEntity" nillable="true" type="tns:ArrayOfAttachmentEntity" />
      <xs:element name="SaveTicketMessageEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketMessageEntity" nillable="true" type="tns:TicketMessageEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTicketMessageEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketMessageEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAttachmentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AttachmentEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAttachmentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:AttachmentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopyFromCRMDocument">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopyFromCRMDocumentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:AttachmentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopyToTempFile">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Filename" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="AttachmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopyToTempFileResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UploadAttachment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AttachmentId" type="xs:int" />
            <xs:element minOccurs="0" name="Content" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UploadAttachmentResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAttachmentStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AttachmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAttachmentStreamResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTicket">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTicketResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Ticket" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTickets">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketIds" nillable="true" type="q4:ArrayOfint" xmlns:q4="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTicketsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTicket" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfTicket">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Ticket" nillable="true" type="tns:Ticket" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTicket" nillable="true" type="tns:ArrayOfTicket" />
      <xs:element name="GetTicketEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTicketEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetForRmUi">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetForRmUiResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteTicketEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteTicketEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="NotifyNewTicket">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="NotifyNewTicketResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="NotifyNewTicketMessage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="NotifyNewTicketMessageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTicketAttachments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTicketAttachmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfAttachmentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateAttachments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AttachmentIds" nillable="true" type="q5:ArrayOfint" xmlns:q5="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateAttachmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfAttachmentValidationResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfAttachmentValidationResult">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="AttachmentValidationResult" nillable="true" type="tns:AttachmentValidationResult" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfAttachmentValidationResult" nillable="true" type="tns:ArrayOfAttachmentValidationResult" />
      <xs:complexType name="AttachmentValidationResult">
        <xs:sequence>
          <xs:element minOccurs="0" name="AttachmentId" type="xs:int" />
          <xs:element minOccurs="0" name="IsValid" type="xs:boolean" />
          <xs:element minOccurs="0" name="ErrorMessage" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="AttachmentValidationResult" nillable="true" type="tns:AttachmentValidationResult" />
      <xs:element name="SetTicketReadByOwner">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketEntityId" type="xs:int" />
            <xs:element minOccurs="0" name="ReadStatus" type="tns:TicketReadStatus" />
            <xs:element minOccurs="0" name="CheckEscalating" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetTicketReadByOwnerResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTicketEntityWithNotify">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NewEntity" nillable="true" type="tns:TicketEntity" />
            <xs:element minOccurs="0" name="Notify" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTicketEntityWithNotifyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNextInQueue">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNextInQueueResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ProcessTicketWhenRead">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ProcessTicketWhenReadResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SplitTicket">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SourceTicketEntityId" type="xs:int" />
            <xs:element minOccurs="0" name="SourceTicketEntityStatusId" type="xs:int" />
            <xs:element minOccurs="0" name="SourceTicketEntityActivate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="TransferMessageIds" nillable="true" type="q6:ArrayOfint" xmlns:q6="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="NewTicketEntity" nillable="true" type="tns:TicketEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SplitTicketResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SplitTicketMessage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SourceTicketMessage" nillable="true" type="tns:TicketMessageEntity" />
            <xs:element minOccurs="0" name="NewTicketEntity" nillable="true" type="tns:TicketEntity" />
            <xs:element minOccurs="0" name="NewTicketMessage" nillable="true" type="tns:TicketMessageEntity" />
            <xs:element minOccurs="0" name="TransferAttachmentsIds" nillable="true" type="q7:ArrayOfint" xmlns:q7="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SplitTicketMessageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateTicketsReadStatus">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketIds" nillable="true" type="q8:ArrayOfint" xmlns:q8="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="NewStatus" type="tns:TicketReadStatus" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateTicketsReadStatusResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q9:ArrayOfint" xmlns:q9="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateTicketsReadStatusByProvider">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Provider" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
            <xs:element minOccurs="0" name="NewStatus" type="tns:TicketReadStatus" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfArchiveRestrictionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArchiveRestrictionInfo" nillable="true" type="tns:ArchiveRestrictionInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArchiveRestrictionInfo" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
      <xs:complexType name="ArchiveRestrictionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Operator" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Values" nillable="true" type="q10:ArrayOfstring" xmlns:q10="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="DisplayValues" nillable="true" type="q11:ArrayOfstring" xmlns:q11="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="ColumnInfo" nillable="true" type="tns:ArchiveColumnInfo" />
          <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
          <xs:element minOccurs="0" name="SubRestrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
          <xs:element minOccurs="0" name="InterParenthesis" type="xs:int" />
          <xs:element minOccurs="0" name="InterOperator" type="tns:InterRestrictionOperator" />
          <xs:element minOccurs="0" name="UniqueHash" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArchiveRestrictionInfo" nillable="true" type="tns:ArchiveRestrictionInfo" />
      <xs:complexType name="ArchiveColumnInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DisplayTooltip" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DisplayType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="CanOrderBy" type="xs:boolean" />
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="CanRestrictBy" type="xs:boolean" />
          <xs:element minOccurs="0" name="RestrictionType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="RestrictionListName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="IsVisible" type="xs:boolean" />
          <xs:element minOccurs="0" name="Width" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="IconHint" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="HeadingIconHint" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArchiveColumnInfo" nillable="true" type="tns:ArchiveColumnInfo" />
      <xs:simpleType name="InterRestrictionOperator">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="And" />
          <xs:enumeration value="Or" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="InterRestrictionOperator" nillable="true" type="tns:InterRestrictionOperator" />
      <xs:element name="UpdateTicketsReadStatusByProviderResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q12:ArrayOfint" xmlns:q12="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MergeTickets">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MergedTicketEntity" nillable="true" type="tns:TicketEntity" />
            <xs:element minOccurs="0" name="SecondaryTicketIds" nillable="true" type="q13:ArrayOfint" xmlns:q13="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MergeTicketsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDeletedStatusByIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketIds" nillable="true" type="q14:ArrayOfint" xmlns:q14="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDeletedStatusByIdsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q15:ArrayOfint" xmlns:q15="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDeletedStatusByProvider">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Restrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDeletedStatusByProviderResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q16:ArrayOfint" xmlns:q16="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UndeleteByIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketIds" nillable="true" type="q17:ArrayOfint" xmlns:q17="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UndeleteByIdsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ResolveTicketId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ResolveTicketIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="BatchForward">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketIds" nillable="true" type="q18:ArrayOfint" xmlns:q18="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="To" nillable="true" type="q19:ArrayOfstring" xmlns:q19="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Cc" nillable="true" type="q20:ArrayOfstring" xmlns:q20="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Bcc" nillable="true" type="q21:ArrayOfstring" xmlns:q21="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Comment" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="CloseTicket" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="BatchForwardResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="BatchReply">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BatchReplyData" nillable="true" type="tns:TicketBatchReplyData" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="TicketBatchReplyData">
        <xs:sequence>
          <xs:element minOccurs="0" name="TicketIds" nillable="true" type="q22:ArrayOfint" xmlns:q22="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="CloseTickets" type="xs:boolean" />
          <xs:element minOccurs="0" name="AttachmentIds" nillable="true" type="q23:ArrayOfint" xmlns:q23="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="HtmlBody" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Slevel" type="tns:TicketSecurityLevel" />
          <xs:element minOccurs="0" name="TimeSpent" type="xs:int" />
          <xs:element minOccurs="0" name="SendCopyToCustomer" type="xs:boolean" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TicketBatchReplyData" nillable="true" type="tns:TicketBatchReplyData" />
      <xs:element name="BatchReplyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ClearNotify">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Ids" nillable="true" type="q24:ArrayOfint" xmlns:q24="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ClearNotifyResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTicketMessageEntities">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketId" type="xs:int" />
            <xs:element minOccurs="0" name="MessageIds" nillable="true" type="q25:ArrayOfint" xmlns:q25="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTicketMessageEntitiesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTicketMessageEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfTicketMessageEntity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TicketMessageEntity" nillable="true" type="tns:TicketMessageEntity" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTicketMessageEntity" nillable="true" type="tns:ArrayOfTicketMessageEntity" />
      <xs:element name="GetTicketMessage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketMessageId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTicketMessageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketMessage" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTicketMessageEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketMessageEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTicketMessageEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketMessageEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteTicketMessageEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketMessageEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteTicketMessageEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SanitizeMailContent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Content" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SanitizeMailContentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SanitizeMailContents">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Contents" nillable="true" type="q26:ArrayOfstring" xmlns:q26="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SanitizeMailContentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q27:ArrayOfstring" xmlns:q27="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Html2Text">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Content" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Html2TextResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAttachmentInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketMessageEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAttachmentInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfAttachmentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAttachmentInfoNonInline">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketMessageEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAttachmentInfoNonInlineResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfAttachmentEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddAttachments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketMessageEntityId" type="xs:int" />
            <xs:element minOccurs="0" name="AttachmentIds" nillable="true" type="q28:ArrayOfint" xmlns:q28="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddAttachmentsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveMessageAttachments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketMessageEntityId" type="xs:int" />
            <xs:element minOccurs="0" name="AttachmentIds" nillable="true" type="q29:ArrayOfint" xmlns:q29="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveMessageAttachmentsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreviewAttachmentStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AttachmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreviewAttachmentStreamResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DocumentPreview" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="DocumentPreview">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Size" type="xs:int" />
              <xs:element minOccurs="0" name="Stream" nillable="true" type="xs:base64Binary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DocumentPreview" nillable="true" type="tns:DocumentPreview" />
      <xs:element name="SendTicketMessage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketMessageEntityId" type="xs:int" />
            <xs:element minOccurs="0" name="To" nillable="true" type="q30:ArrayOfstring" xmlns:q30="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Cc" nillable="true" type="q31:ArrayOfstring" xmlns:q31="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Bcc" nillable="true" type="q32:ArrayOfstring" xmlns:q32="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Subject" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ReplyTemplateId" type="xs:int" />
            <xs:element minOccurs="0" name="GdprSource" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SendTicketMessageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SendTicketMessageSms">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketMessageEntityId" type="xs:int" />
            <xs:element minOccurs="0" name="ReplyTemplateId" type="xs:int" />
            <xs:element minOccurs="0" name="Sms" nillable="true" type="q33:ArrayOfstring" xmlns:q33="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SendTicketMessageSmsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetTicketMessageImportant">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketMessageId" type="xs:int" />
            <xs:element minOccurs="0" name="Important" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetTicketMessageImportantResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CalculateMessageRecipients">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketId" type="xs:int" />
            <xs:element minOccurs="0" name="ActionType" type="tns:MessageActionType" />
            <xs:element minOccurs="0" name="MessageId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="MessageActionType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Reply" />
          <xs:enumeration value="ReplyAll" />
          <xs:enumeration value="Forward" />
          <xs:enumeration value="InternalComment" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="MessageActionType" nillable="true" type="tns:MessageActionType" />
      <xs:element name="CalculateMessageRecipientsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfRecipient" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfRecipient">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Recipient" nillable="true" type="tns:Recipient" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfRecipient" nillable="true" type="tns:ArrayOfRecipient" />
      <xs:complexType name="Recipient">
        <xs:sequence>
          <xs:element minOccurs="0" name="Type" type="tns:RecipientType" />
          <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="Recipient" nillable="true" type="tns:Recipient" />
      <xs:simpleType name="RecipientType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="To" />
          <xs:enumeration value="CC" />
          <xs:enumeration value="BCC">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">3</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Sms">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">4</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecipientType" nillable="true" type="tns:RecipientType" />
      <xs:element name="SaveTicketMessageEntityWithNotify">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NewEntity" nillable="true" type="tns:TicketMessageEntity" />
            <xs:element minOccurs="0" name="Notify" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTicketMessageEntityWithNotifyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketMessageEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTicketMessageEntityWithOptions">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Entity" nillable="true" type="tns:TicketMessageEntity" />
            <xs:element minOccurs="0" name="Notify" type="xs:boolean" />
            <xs:element minOccurs="0" name="AttachmentIds" nillable="true" type="q34:ArrayOfint" xmlns:q34="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="UpdateRepliedAt" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTicketMessageEntityWithOptionsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketMessageEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultMessageContent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketId" type="xs:int" />
            <xs:element minOccurs="0" name="MessageActionType" type="tns:MessageActionType" />
            <xs:element minOccurs="0" name="TicketMessageId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultMessageContentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultMessageContentFull">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketId" type="xs:int" />
            <xs:element minOccurs="0" name="MessageActionType" type="tns:MessageActionType" />
            <xs:element minOccurs="0" name="TicketMessageId" type="xs:int" />
            <xs:element minOccurs="0" name="TicketTypeId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultMessageContentFullResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketMessageContent" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="TicketMessageContent">
        <xs:sequence>
          <xs:element minOccurs="0" name="Body" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="AttachmentsInfo" nillable="true" type="tns:ArrayOfAttachmentEntity" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TicketMessageContent" nillable="true" type="tns:TicketMessageContent" />
      <xs:element name="GetTicketMessageWithEmbeddedData">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="EmbedImages" type="tns:ImageEmbedType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="ImageEmbedType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Link" />
          <xs:enumeration value="Inline" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ImageEmbedType" nillable="true" type="tns:ImageEmbedType" />
      <xs:element name="GetTicketMessageWithEmbeddedDataResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketMessageEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteMessageHeaders">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="HeaderIds" nillable="true" type="q35:ArrayOfint" xmlns:q35="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteMessageHeadersResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTicketMessageWithOptions">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketMessageEntityId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeNonInlineAttachmentsInfo" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTicketMessageWithOptionsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketMessageEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTicketSummaries">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketIds" nillable="true" type="q36:ArrayOfint" xmlns:q36="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTicketSummariesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTicketSummaryItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
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
          <xs:element minOccurs="0" name="IconHint" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TicketSummaryItem" nillable="true" type="tns:TicketSummaryItem" />
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
      <xs:complexType name="ArrayOfstring">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="string" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfstring" nillable="true" type="tns:ArrayOfstring" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="CreateDefaultAttachmentEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultAttachmentEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAttachmentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAttachmentEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultAttachmentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAttachmentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveAttachmentEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveAttachmentEntity" />
  </wsdl:message>
  <wsdl:message name="SaveAttachmentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveAttachmentEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveAttachmentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveAttachmentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTicketEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTicketEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTicketEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTicketEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTicketEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTicketEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTicketEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveTicketEntity" />
  </wsdl:message>
  <wsdl:message name="SaveTicketEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTicketEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveTicketEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveTicketEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTicketMessageEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTicketMessageEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTicketMessageEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTicketMessageEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTicketMessageEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTicketMessageEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTicketMessageEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveTicketMessageEntity" />
  </wsdl:message>
  <wsdl:message name="SaveTicketMessageEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTicketMessageEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveTicketMessageEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveTicketMessageEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentEntityRequest">
    <wsdl:part name="parameters" element="tns:GetAttachmentEntity" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentEntityResponse">
    <wsdl:part name="parameters" element="tns:GetAttachmentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopyFromCRMDocumentRequest">
    <wsdl:part name="parameters" element="tns:CopyFromCRMDocument" />
  </wsdl:message>
  <wsdl:message name="CopyFromCRMDocumentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopyFromCRMDocumentResponse">
    <wsdl:part name="parameters" element="tns:CopyFromCRMDocumentResponse" />
  </wsdl:message>
  <wsdl:message name="CopyFromCRMDocumentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopyToTempFileRequest">
    <wsdl:part name="parameters" element="tns:CopyToTempFile" />
  </wsdl:message>
  <wsdl:message name="CopyToTempFileRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopyToTempFileResponse">
    <wsdl:part name="parameters" element="tns:CopyToTempFileResponse" />
  </wsdl:message>
  <wsdl:message name="CopyToTempFileResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UploadAttachmentRequest">
    <wsdl:part name="parameters" element="tns:UploadAttachment" />
  </wsdl:message>
  <wsdl:message name="UploadAttachmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UploadAttachmentResponse">
    <wsdl:part name="parameters" element="tns:UploadAttachmentResponse" />
  </wsdl:message>
  <wsdl:message name="UploadAttachmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentStreamRequest">
    <wsdl:part name="parameters" element="tns:GetAttachmentStream" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentStreamResponse">
    <wsdl:part name="parameters" element="tns:GetAttachmentStreamResponse" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentStreamResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketRequest">
    <wsdl:part name="parameters" element="tns:GetTicket" />
  </wsdl:message>
  <wsdl:message name="GetTicketRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketResponse">
    <wsdl:part name="parameters" element="tns:GetTicketResponse" />
  </wsdl:message>
  <wsdl:message name="GetTicketResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketsRequest">
    <wsdl:part name="parameters" element="tns:GetTickets" />
  </wsdl:message>
  <wsdl:message name="GetTicketsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketsResponse">
    <wsdl:part name="parameters" element="tns:GetTicketsResponse" />
  </wsdl:message>
  <wsdl:message name="GetTicketsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketEntityRequest">
    <wsdl:part name="parameters" element="tns:GetTicketEntity" />
  </wsdl:message>
  <wsdl:message name="GetTicketEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketEntityResponse">
    <wsdl:part name="parameters" element="tns:GetTicketEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetTicketEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetForRmUiRequest">
    <wsdl:part name="parameters" element="tns:GetForRmUi" />
  </wsdl:message>
  <wsdl:message name="GetForRmUiRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetForRmUiResponse">
    <wsdl:part name="parameters" element="tns:GetForRmUiResponse" />
  </wsdl:message>
  <wsdl:message name="GetForRmUiResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteTicketEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteTicketEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteTicketEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteTicketEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteTicketEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteTicketEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="NotifyNewTicketRequest">
    <wsdl:part name="parameters" element="tns:NotifyNewTicket" />
  </wsdl:message>
  <wsdl:message name="NotifyNewTicketRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="NotifyNewTicketResponse">
    <wsdl:part name="parameters" element="tns:NotifyNewTicketResponse" />
  </wsdl:message>
  <wsdl:message name="NotifyNewTicketResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="NotifyNewTicketMessageRequest">
    <wsdl:part name="parameters" element="tns:NotifyNewTicketMessage" />
  </wsdl:message>
  <wsdl:message name="NotifyNewTicketMessageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="NotifyNewTicketMessageResponse">
    <wsdl:part name="parameters" element="tns:NotifyNewTicketMessageResponse" />
  </wsdl:message>
  <wsdl:message name="NotifyNewTicketMessageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketAttachmentsRequest">
    <wsdl:part name="parameters" element="tns:GetTicketAttachments" />
  </wsdl:message>
  <wsdl:message name="GetTicketAttachmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketAttachmentsResponse">
    <wsdl:part name="parameters" element="tns:GetTicketAttachmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetTicketAttachmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateAttachmentsRequest">
    <wsdl:part name="parameters" element="tns:ValidateAttachments" />
  </wsdl:message>
  <wsdl:message name="ValidateAttachmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateAttachmentsResponse">
    <wsdl:part name="parameters" element="tns:ValidateAttachmentsResponse" />
  </wsdl:message>
  <wsdl:message name="ValidateAttachmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetTicketReadByOwnerRequest">
    <wsdl:part name="parameters" element="tns:SetTicketReadByOwner" />
  </wsdl:message>
  <wsdl:message name="SetTicketReadByOwnerRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetTicketReadByOwnerResponse">
    <wsdl:part name="parameters" element="tns:SetTicketReadByOwnerResponse" />
  </wsdl:message>
  <wsdl:message name="SetTicketReadByOwnerResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTicketEntityWithNotifyRequest">
    <wsdl:part name="parameters" element="tns:SaveTicketEntityWithNotify" />
  </wsdl:message>
  <wsdl:message name="SaveTicketEntityWithNotifyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTicketEntityWithNotifyResponse">
    <wsdl:part name="parameters" element="tns:SaveTicketEntityWithNotifyResponse" />
  </wsdl:message>
  <wsdl:message name="SaveTicketEntityWithNotifyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextInQueueRequest">
    <wsdl:part name="parameters" element="tns:GetNextInQueue" />
  </wsdl:message>
  <wsdl:message name="GetNextInQueueRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextInQueueResponse">
    <wsdl:part name="parameters" element="tns:GetNextInQueueResponse" />
  </wsdl:message>
  <wsdl:message name="GetNextInQueueResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ProcessTicketWhenReadRequest">
    <wsdl:part name="parameters" element="tns:ProcessTicketWhenRead" />
  </wsdl:message>
  <wsdl:message name="ProcessTicketWhenReadRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ProcessTicketWhenReadResponse">
    <wsdl:part name="parameters" element="tns:ProcessTicketWhenReadResponse" />
  </wsdl:message>
  <wsdl:message name="ProcessTicketWhenReadResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SplitTicketRequest">
    <wsdl:part name="parameters" element="tns:SplitTicket" />
  </wsdl:message>
  <wsdl:message name="SplitTicketRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SplitTicketResponse">
    <wsdl:part name="parameters" element="tns:SplitTicketResponse" />
  </wsdl:message>
  <wsdl:message name="SplitTicketResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SplitTicketMessageRequest">
    <wsdl:part name="parameters" element="tns:SplitTicketMessage" />
  </wsdl:message>
  <wsdl:message name="SplitTicketMessageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SplitTicketMessageResponse">
    <wsdl:part name="parameters" element="tns:SplitTicketMessageResponse" />
  </wsdl:message>
  <wsdl:message name="SplitTicketMessageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateTicketsReadStatusRequest">
    <wsdl:part name="parameters" element="tns:UpdateTicketsReadStatus" />
  </wsdl:message>
  <wsdl:message name="UpdateTicketsReadStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateTicketsReadStatusResponse">
    <wsdl:part name="parameters" element="tns:UpdateTicketsReadStatusResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateTicketsReadStatusResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateTicketsReadStatusByProviderRequest">
    <wsdl:part name="parameters" element="tns:UpdateTicketsReadStatusByProvider" />
  </wsdl:message>
  <wsdl:message name="UpdateTicketsReadStatusByProviderRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateTicketsReadStatusByProviderResponse">
    <wsdl:part name="parameters" element="tns:UpdateTicketsReadStatusByProviderResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateTicketsReadStatusByProviderResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MergeTicketsRequest">
    <wsdl:part name="parameters" element="tns:MergeTickets" />
  </wsdl:message>
  <wsdl:message name="MergeTicketsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MergeTicketsResponse">
    <wsdl:part name="parameters" element="tns:MergeTicketsResponse" />
  </wsdl:message>
  <wsdl:message name="MergeTicketsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDeletedStatusByIdsRequest">
    <wsdl:part name="parameters" element="tns:SetDeletedStatusByIds" />
  </wsdl:message>
  <wsdl:message name="SetDeletedStatusByIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDeletedStatusByIdsResponse">
    <wsdl:part name="parameters" element="tns:SetDeletedStatusByIdsResponse" />
  </wsdl:message>
  <wsdl:message name="SetDeletedStatusByIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDeletedStatusByProviderRequest">
    <wsdl:part name="parameters" element="tns:SetDeletedStatusByProvider" />
  </wsdl:message>
  <wsdl:message name="SetDeletedStatusByProviderRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDeletedStatusByProviderResponse">
    <wsdl:part name="parameters" element="tns:SetDeletedStatusByProviderResponse" />
  </wsdl:message>
  <wsdl:message name="SetDeletedStatusByProviderResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UndeleteByIdsRequest">
    <wsdl:part name="parameters" element="tns:UndeleteByIds" />
  </wsdl:message>
  <wsdl:message name="UndeleteByIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UndeleteByIdsResponse">
    <wsdl:part name="parameters" element="tns:UndeleteByIdsResponse" />
  </wsdl:message>
  <wsdl:message name="UndeleteByIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ResolveTicketIdRequest">
    <wsdl:part name="parameters" element="tns:ResolveTicketId" />
  </wsdl:message>
  <wsdl:message name="ResolveTicketIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ResolveTicketIdResponse">
    <wsdl:part name="parameters" element="tns:ResolveTicketIdResponse" />
  </wsdl:message>
  <wsdl:message name="ResolveTicketIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="BatchForwardRequest">
    <wsdl:part name="parameters" element="tns:BatchForward" />
  </wsdl:message>
  <wsdl:message name="BatchForwardRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="BatchForwardResponse">
    <wsdl:part name="parameters" element="tns:BatchForwardResponse" />
  </wsdl:message>
  <wsdl:message name="BatchForwardResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="BatchReplyRequest">
    <wsdl:part name="parameters" element="tns:BatchReply" />
  </wsdl:message>
  <wsdl:message name="BatchReplyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="BatchReplyResponse">
    <wsdl:part name="parameters" element="tns:BatchReplyResponse" />
  </wsdl:message>
  <wsdl:message name="BatchReplyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ClearNotifyRequest">
    <wsdl:part name="parameters" element="tns:ClearNotify" />
  </wsdl:message>
  <wsdl:message name="ClearNotifyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ClearNotifyResponse">
    <wsdl:part name="parameters" element="tns:ClearNotifyResponse" />
  </wsdl:message>
  <wsdl:message name="ClearNotifyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageEntitiesRequest">
    <wsdl:part name="parameters" element="tns:GetTicketMessageEntities" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageEntitiesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageEntitiesResponse">
    <wsdl:part name="parameters" element="tns:GetTicketMessageEntitiesResponse" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageEntitiesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageRequest">
    <wsdl:part name="parameters" element="tns:GetTicketMessage" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageResponse">
    <wsdl:part name="parameters" element="tns:GetTicketMessageResponse" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageEntityRequest">
    <wsdl:part name="parameters" element="tns:GetTicketMessageEntity" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageEntityResponse">
    <wsdl:part name="parameters" element="tns:GetTicketMessageEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteTicketMessageEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteTicketMessageEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteTicketMessageEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteTicketMessageEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteTicketMessageEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteTicketMessageEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SanitizeMailContentRequest">
    <wsdl:part name="parameters" element="tns:SanitizeMailContent" />
  </wsdl:message>
  <wsdl:message name="SanitizeMailContentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SanitizeMailContentResponse">
    <wsdl:part name="parameters" element="tns:SanitizeMailContentResponse" />
  </wsdl:message>
  <wsdl:message name="SanitizeMailContentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SanitizeMailContentsRequest">
    <wsdl:part name="parameters" element="tns:SanitizeMailContents" />
  </wsdl:message>
  <wsdl:message name="SanitizeMailContentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SanitizeMailContentsResponse">
    <wsdl:part name="parameters" element="tns:SanitizeMailContentsResponse" />
  </wsdl:message>
  <wsdl:message name="SanitizeMailContentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="Html2TextRequest">
    <wsdl:part name="parameters" element="tns:Html2Text" />
  </wsdl:message>
  <wsdl:message name="Html2TextRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="Html2TextResponse">
    <wsdl:part name="parameters" element="tns:Html2TextResponse" />
  </wsdl:message>
  <wsdl:message name="Html2TextResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentInfoRequest">
    <wsdl:part name="parameters" element="tns:GetAttachmentInfo" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentInfoResponse">
    <wsdl:part name="parameters" element="tns:GetAttachmentInfoResponse" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentInfoNonInlineRequest">
    <wsdl:part name="parameters" element="tns:GetAttachmentInfoNonInline" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentInfoNonInlineRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentInfoNonInlineResponse">
    <wsdl:part name="parameters" element="tns:GetAttachmentInfoNonInlineResponse" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentInfoNonInlineResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddAttachmentsRequest">
    <wsdl:part name="parameters" element="tns:AddAttachments" />
  </wsdl:message>
  <wsdl:message name="AddAttachmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddAttachmentsResponse">
    <wsdl:part name="parameters" element="tns:AddAttachmentsResponse" />
  </wsdl:message>
  <wsdl:message name="AddAttachmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveMessageAttachmentsRequest">
    <wsdl:part name="parameters" element="tns:RemoveMessageAttachments" />
  </wsdl:message>
  <wsdl:message name="RemoveMessageAttachmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveMessageAttachmentsResponse">
    <wsdl:part name="parameters" element="tns:RemoveMessageAttachmentsResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveMessageAttachmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreviewAttachmentStreamRequest">
    <wsdl:part name="parameters" element="tns:GetPreviewAttachmentStream" />
  </wsdl:message>
  <wsdl:message name="GetPreviewAttachmentStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreviewAttachmentStreamResponse">
    <wsdl:part name="parameters" element="tns:GetPreviewAttachmentStreamResponse" />
  </wsdl:message>
  <wsdl:message name="GetPreviewAttachmentStreamResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendTicketMessageRequest">
    <wsdl:part name="parameters" element="tns:SendTicketMessage" />
  </wsdl:message>
  <wsdl:message name="SendTicketMessageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendTicketMessageResponse">
    <wsdl:part name="parameters" element="tns:SendTicketMessageResponse" />
  </wsdl:message>
  <wsdl:message name="SendTicketMessageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendTicketMessageSmsRequest">
    <wsdl:part name="parameters" element="tns:SendTicketMessageSms" />
  </wsdl:message>
  <wsdl:message name="SendTicketMessageSmsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendTicketMessageSmsResponse">
    <wsdl:part name="parameters" element="tns:SendTicketMessageSmsResponse" />
  </wsdl:message>
  <wsdl:message name="SendTicketMessageSmsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetTicketMessageImportantRequest">
    <wsdl:part name="parameters" element="tns:SetTicketMessageImportant" />
  </wsdl:message>
  <wsdl:message name="SetTicketMessageImportantRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetTicketMessageImportantResponse">
    <wsdl:part name="parameters" element="tns:SetTicketMessageImportantResponse" />
  </wsdl:message>
  <wsdl:message name="SetTicketMessageImportantResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CalculateMessageRecipientsRequest">
    <wsdl:part name="parameters" element="tns:CalculateMessageRecipients" />
  </wsdl:message>
  <wsdl:message name="CalculateMessageRecipientsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CalculateMessageRecipientsResponse">
    <wsdl:part name="parameters" element="tns:CalculateMessageRecipientsResponse" />
  </wsdl:message>
  <wsdl:message name="CalculateMessageRecipientsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTicketMessageEntityWithNotifyRequest">
    <wsdl:part name="parameters" element="tns:SaveTicketMessageEntityWithNotify" />
  </wsdl:message>
  <wsdl:message name="SaveTicketMessageEntityWithNotifyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTicketMessageEntityWithNotifyResponse">
    <wsdl:part name="parameters" element="tns:SaveTicketMessageEntityWithNotifyResponse" />
  </wsdl:message>
  <wsdl:message name="SaveTicketMessageEntityWithNotifyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTicketMessageEntityWithOptionsRequest">
    <wsdl:part name="parameters" element="tns:SaveTicketMessageEntityWithOptions" />
  </wsdl:message>
  <wsdl:message name="SaveTicketMessageEntityWithOptionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTicketMessageEntityWithOptionsResponse">
    <wsdl:part name="parameters" element="tns:SaveTicketMessageEntityWithOptionsResponse" />
  </wsdl:message>
  <wsdl:message name="SaveTicketMessageEntityWithOptionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultMessageContentRequest">
    <wsdl:part name="parameters" element="tns:GetDefaultMessageContent" />
  </wsdl:message>
  <wsdl:message name="GetDefaultMessageContentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultMessageContentResponse">
    <wsdl:part name="parameters" element="tns:GetDefaultMessageContentResponse" />
  </wsdl:message>
  <wsdl:message name="GetDefaultMessageContentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultMessageContentFullRequest">
    <wsdl:part name="parameters" element="tns:GetDefaultMessageContentFull" />
  </wsdl:message>
  <wsdl:message name="GetDefaultMessageContentFullRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultMessageContentFullResponse">
    <wsdl:part name="parameters" element="tns:GetDefaultMessageContentFullResponse" />
  </wsdl:message>
  <wsdl:message name="GetDefaultMessageContentFullResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageWithEmbeddedDataRequest">
    <wsdl:part name="parameters" element="tns:GetTicketMessageWithEmbeddedData" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageWithEmbeddedDataRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageWithEmbeddedDataResponse">
    <wsdl:part name="parameters" element="tns:GetTicketMessageWithEmbeddedDataResponse" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageWithEmbeddedDataResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteMessageHeadersRequest">
    <wsdl:part name="parameters" element="tns:DeleteMessageHeaders" />
  </wsdl:message>
  <wsdl:message name="DeleteMessageHeadersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteMessageHeadersResponse">
    <wsdl:part name="parameters" element="tns:DeleteMessageHeadersResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteMessageHeadersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageWithOptionsRequest">
    <wsdl:part name="parameters" element="tns:GetTicketMessageWithOptions" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageWithOptionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageWithOptionsResponse">
    <wsdl:part name="parameters" element="tns:GetTicketMessageWithOptionsResponse" />
  </wsdl:message>
  <wsdl:message name="GetTicketMessageWithOptionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketSummariesRequest">
    <wsdl:part name="parameters" element="tns:GetTicketSummaries" />
  </wsdl:message>
  <wsdl:message name="GetTicketSummariesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTicketSummariesResponse">
    <wsdl:part name="parameters" element="tns:GetTicketSummariesResponse" />
  </wsdl:message>
  <wsdl:message name="GetTicketSummariesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Ticket">
    <wsdl:operation name="CreateDefaultAttachmentEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/CreateDefaultAttachmentEntity" name="CreateDefaultAttachmentEntityRequest" message="tns:CreateDefaultAttachmentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/CreateDefaultAttachmentEntityResponse" name="CreateDefaultAttachmentEntityResponse" message="tns:CreateDefaultAttachmentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveAttachmentEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SaveAttachmentEntity" name="SaveAttachmentEntityRequest" message="tns:SaveAttachmentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SaveAttachmentEntityResponse" name="SaveAttachmentEntityResponse" message="tns:SaveAttachmentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTicketEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/CreateDefaultTicketEntity" name="CreateDefaultTicketEntityRequest" message="tns:CreateDefaultTicketEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/CreateDefaultTicketEntityResponse" name="CreateDefaultTicketEntityResponse" message="tns:CreateDefaultTicketEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveTicketEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SaveTicketEntity" name="SaveTicketEntityRequest" message="tns:SaveTicketEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SaveTicketEntityResponse" name="SaveTicketEntityResponse" message="tns:SaveTicketEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTicketMessageEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/CreateDefaultTicketMessageEntity" name="CreateDefaultTicketMessageEntityRequest" message="tns:CreateDefaultTicketMessageEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/CreateDefaultTicketMessageEntityResponse" name="CreateDefaultTicketMessageEntityResponse" message="tns:CreateDefaultTicketMessageEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveTicketMessageEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SaveTicketMessageEntity" name="SaveTicketMessageEntityRequest" message="tns:SaveTicketMessageEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SaveTicketMessageEntityResponse" name="SaveTicketMessageEntityResponse" message="tns:SaveTicketMessageEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAttachmentEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetAttachmentEntity" name="GetAttachmentEntityRequest" message="tns:GetAttachmentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetAttachmentEntityResponse" name="GetAttachmentEntityResponse" message="tns:GetAttachmentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CopyFromCRMDocument">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/CopyFromCRMDocument" name="CopyFromCRMDocumentRequest" message="tns:CopyFromCRMDocumentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/CopyFromCRMDocumentResponse" name="CopyFromCRMDocumentResponse" message="tns:CopyFromCRMDocumentResponse" />
    </wsdl:operation>
    <wsdl:operation name="CopyToTempFile">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/CopyToTempFile" name="CopyToTempFileRequest" message="tns:CopyToTempFileRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/CopyToTempFileResponse" name="CopyToTempFileResponse" message="tns:CopyToTempFileResponse" />
    </wsdl:operation>
    <wsdl:operation name="UploadAttachment">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/UploadAttachment" name="UploadAttachmentRequest" message="tns:UploadAttachmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/UploadAttachmentResponse" name="UploadAttachmentResponse" message="tns:UploadAttachmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAttachmentStream">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetAttachmentStream" name="GetAttachmentStreamRequest" message="tns:GetAttachmentStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetAttachmentStreamResponse" name="GetAttachmentStreamResponse" message="tns:GetAttachmentStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTicket">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicket" name="GetTicketRequest" message="tns:GetTicketRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketResponse" name="GetTicketResponse" message="tns:GetTicketResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTickets">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTickets" name="GetTicketsRequest" message="tns:GetTicketsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketsResponse" name="GetTicketsResponse" message="tns:GetTicketsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTicketEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketEntity" name="GetTicketEntityRequest" message="tns:GetTicketEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketEntityResponse" name="GetTicketEntityResponse" message="tns:GetTicketEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetForRmUi">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetForRmUi" name="GetForRmUiRequest" message="tns:GetForRmUiRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetForRmUiResponse" name="GetForRmUiResponse" message="tns:GetForRmUiResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteTicketEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/DeleteTicketEntity" name="DeleteTicketEntityRequest" message="tns:DeleteTicketEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/DeleteTicketEntityResponse" name="DeleteTicketEntityResponse" message="tns:DeleteTicketEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="NotifyNewTicket">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/NotifyNewTicket" name="NotifyNewTicketRequest" message="tns:NotifyNewTicketRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/NotifyNewTicketResponse" name="NotifyNewTicketResponse" message="tns:NotifyNewTicketResponse" />
    </wsdl:operation>
    <wsdl:operation name="NotifyNewTicketMessage">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/NotifyNewTicketMessage" name="NotifyNewTicketMessageRequest" message="tns:NotifyNewTicketMessageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/NotifyNewTicketMessageResponse" name="NotifyNewTicketMessageResponse" message="tns:NotifyNewTicketMessageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTicketAttachments">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketAttachments" name="GetTicketAttachmentsRequest" message="tns:GetTicketAttachmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketAttachmentsResponse" name="GetTicketAttachmentsResponse" message="tns:GetTicketAttachmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="ValidateAttachments">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/ValidateAttachments" name="ValidateAttachmentsRequest" message="tns:ValidateAttachmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/ValidateAttachmentsResponse" name="ValidateAttachmentsResponse" message="tns:ValidateAttachmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetTicketReadByOwner">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SetTicketReadByOwner" name="SetTicketReadByOwnerRequest" message="tns:SetTicketReadByOwnerRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SetTicketReadByOwnerResponse" name="SetTicketReadByOwnerResponse" message="tns:SetTicketReadByOwnerResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveTicketEntityWithNotify">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SaveTicketEntityWithNotify" name="SaveTicketEntityWithNotifyRequest" message="tns:SaveTicketEntityWithNotifyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SaveTicketEntityWithNotifyResponse" name="SaveTicketEntityWithNotifyResponse" message="tns:SaveTicketEntityWithNotifyResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNextInQueue">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetNextInQueue" name="GetNextInQueueRequest" message="tns:GetNextInQueueRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetNextInQueueResponse" name="GetNextInQueueResponse" message="tns:GetNextInQueueResponse" />
    </wsdl:operation>
    <wsdl:operation name="ProcessTicketWhenRead">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/ProcessTicketWhenRead" name="ProcessTicketWhenReadRequest" message="tns:ProcessTicketWhenReadRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/ProcessTicketWhenReadResponse" name="ProcessTicketWhenReadResponse" message="tns:ProcessTicketWhenReadResponse" />
    </wsdl:operation>
    <wsdl:operation name="SplitTicket">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SplitTicket" name="SplitTicketRequest" message="tns:SplitTicketRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SplitTicketResponse" name="SplitTicketResponse" message="tns:SplitTicketResponse" />
    </wsdl:operation>
    <wsdl:operation name="SplitTicketMessage">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SplitTicketMessage" name="SplitTicketMessageRequest" message="tns:SplitTicketMessageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SplitTicketMessageResponse" name="SplitTicketMessageResponse" message="tns:SplitTicketMessageResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateTicketsReadStatus">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/UpdateTicketsReadStatus" name="UpdateTicketsReadStatusRequest" message="tns:UpdateTicketsReadStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/UpdateTicketsReadStatusResponse" name="UpdateTicketsReadStatusResponse" message="tns:UpdateTicketsReadStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateTicketsReadStatusByProvider">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/UpdateTicketsReadStatusByProvider" name="UpdateTicketsReadStatusByProviderRequest" message="tns:UpdateTicketsReadStatusByProviderRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/UpdateTicketsReadStatusByProviderResponse" name="UpdateTicketsReadStatusByProviderResponse" message="tns:UpdateTicketsReadStatusByProviderResponse" />
    </wsdl:operation>
    <wsdl:operation name="MergeTickets">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/MergeTickets" name="MergeTicketsRequest" message="tns:MergeTicketsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/MergeTicketsResponse" name="MergeTicketsResponse" message="tns:MergeTicketsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetDeletedStatusByIds">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SetDeletedStatusByIds" name="SetDeletedStatusByIdsRequest" message="tns:SetDeletedStatusByIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SetDeletedStatusByIdsResponse" name="SetDeletedStatusByIdsResponse" message="tns:SetDeletedStatusByIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetDeletedStatusByProvider">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SetDeletedStatusByProvider" name="SetDeletedStatusByProviderRequest" message="tns:SetDeletedStatusByProviderRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SetDeletedStatusByProviderResponse" name="SetDeletedStatusByProviderResponse" message="tns:SetDeletedStatusByProviderResponse" />
    </wsdl:operation>
    <wsdl:operation name="UndeleteByIds">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/UndeleteByIds" name="UndeleteByIdsRequest" message="tns:UndeleteByIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/UndeleteByIdsResponse" name="UndeleteByIdsResponse" message="tns:UndeleteByIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="ResolveTicketId">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/ResolveTicketId" name="ResolveTicketIdRequest" message="tns:ResolveTicketIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/ResolveTicketIdResponse" name="ResolveTicketIdResponse" message="tns:ResolveTicketIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="BatchForward">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/BatchForward" name="BatchForwardRequest" message="tns:BatchForwardRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/BatchForwardResponse" name="BatchForwardResponse" message="tns:BatchForwardResponse" />
    </wsdl:operation>
    <wsdl:operation name="BatchReply">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/BatchReply" name="BatchReplyRequest" message="tns:BatchReplyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/BatchReplyResponse" name="BatchReplyResponse" message="tns:BatchReplyResponse" />
    </wsdl:operation>
    <wsdl:operation name="ClearNotify">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/ClearNotify" name="ClearNotifyRequest" message="tns:ClearNotifyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/ClearNotifyResponse" name="ClearNotifyResponse" message="tns:ClearNotifyResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTicketMessageEntities">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketMessageEntities" name="GetTicketMessageEntitiesRequest" message="tns:GetTicketMessageEntitiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketMessageEntitiesResponse" name="GetTicketMessageEntitiesResponse" message="tns:GetTicketMessageEntitiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTicketMessage">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketMessage" name="GetTicketMessageRequest" message="tns:GetTicketMessageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketMessageResponse" name="GetTicketMessageResponse" message="tns:GetTicketMessageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTicketMessageEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketMessageEntity" name="GetTicketMessageEntityRequest" message="tns:GetTicketMessageEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketMessageEntityResponse" name="GetTicketMessageEntityResponse" message="tns:GetTicketMessageEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteTicketMessageEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/DeleteTicketMessageEntity" name="DeleteTicketMessageEntityRequest" message="tns:DeleteTicketMessageEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/DeleteTicketMessageEntityResponse" name="DeleteTicketMessageEntityResponse" message="tns:DeleteTicketMessageEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SanitizeMailContent">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SanitizeMailContent" name="SanitizeMailContentRequest" message="tns:SanitizeMailContentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SanitizeMailContentResponse" name="SanitizeMailContentResponse" message="tns:SanitizeMailContentResponse" />
    </wsdl:operation>
    <wsdl:operation name="SanitizeMailContents">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SanitizeMailContents" name="SanitizeMailContentsRequest" message="tns:SanitizeMailContentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SanitizeMailContentsResponse" name="SanitizeMailContentsResponse" message="tns:SanitizeMailContentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="Html2Text">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/Html2Text" name="Html2TextRequest" message="tns:Html2TextRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/Html2TextResponse" name="Html2TextResponse" message="tns:Html2TextResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAttachmentInfo">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetAttachmentInfo" name="GetAttachmentInfoRequest" message="tns:GetAttachmentInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetAttachmentInfoResponse" name="GetAttachmentInfoResponse" message="tns:GetAttachmentInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAttachmentInfoNonInline">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetAttachmentInfoNonInline" name="GetAttachmentInfoNonInlineRequest" message="tns:GetAttachmentInfoNonInlineRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetAttachmentInfoNonInlineResponse" name="GetAttachmentInfoNonInlineResponse" message="tns:GetAttachmentInfoNonInlineResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddAttachments">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/AddAttachments" name="AddAttachmentsRequest" message="tns:AddAttachmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/AddAttachmentsResponse" name="AddAttachmentsResponse" message="tns:AddAttachmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveMessageAttachments">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/RemoveMessageAttachments" name="RemoveMessageAttachmentsRequest" message="tns:RemoveMessageAttachmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/RemoveMessageAttachmentsResponse" name="RemoveMessageAttachmentsResponse" message="tns:RemoveMessageAttachmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPreviewAttachmentStream">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetPreviewAttachmentStream" name="GetPreviewAttachmentStreamRequest" message="tns:GetPreviewAttachmentStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetPreviewAttachmentStreamResponse" name="GetPreviewAttachmentStreamResponse" message="tns:GetPreviewAttachmentStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="SendTicketMessage">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SendTicketMessage" name="SendTicketMessageRequest" message="tns:SendTicketMessageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SendTicketMessageResponse" name="SendTicketMessageResponse" message="tns:SendTicketMessageResponse" />
    </wsdl:operation>
    <wsdl:operation name="SendTicketMessageSms">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SendTicketMessageSms" name="SendTicketMessageSmsRequest" message="tns:SendTicketMessageSmsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SendTicketMessageSmsResponse" name="SendTicketMessageSmsResponse" message="tns:SendTicketMessageSmsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetTicketMessageImportant">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SetTicketMessageImportant" name="SetTicketMessageImportantRequest" message="tns:SetTicketMessageImportantRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SetTicketMessageImportantResponse" name="SetTicketMessageImportantResponse" message="tns:SetTicketMessageImportantResponse" />
    </wsdl:operation>
    <wsdl:operation name="CalculateMessageRecipients">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/CalculateMessageRecipients" name="CalculateMessageRecipientsRequest" message="tns:CalculateMessageRecipientsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/CalculateMessageRecipientsResponse" name="CalculateMessageRecipientsResponse" message="tns:CalculateMessageRecipientsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveTicketMessageEntityWithNotify">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SaveTicketMessageEntityWithNotify" name="SaveTicketMessageEntityWithNotifyRequest" message="tns:SaveTicketMessageEntityWithNotifyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SaveTicketMessageEntityWithNotifyResponse" name="SaveTicketMessageEntityWithNotifyResponse" message="tns:SaveTicketMessageEntityWithNotifyResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveTicketMessageEntityWithOptions">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SaveTicketMessageEntityWithOptions" name="SaveTicketMessageEntityWithOptionsRequest" message="tns:SaveTicketMessageEntityWithOptionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SaveTicketMessageEntityWithOptionsResponse" name="SaveTicketMessageEntityWithOptionsResponse" message="tns:SaveTicketMessageEntityWithOptionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDefaultMessageContent">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetDefaultMessageContent" name="GetDefaultMessageContentRequest" message="tns:GetDefaultMessageContentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetDefaultMessageContentResponse" name="GetDefaultMessageContentResponse" message="tns:GetDefaultMessageContentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDefaultMessageContentFull">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetDefaultMessageContentFull" name="GetDefaultMessageContentFullRequest" message="tns:GetDefaultMessageContentFullRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetDefaultMessageContentFullResponse" name="GetDefaultMessageContentFullResponse" message="tns:GetDefaultMessageContentFullResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTicketMessageWithEmbeddedData">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketMessageWithEmbeddedData" name="GetTicketMessageWithEmbeddedDataRequest" message="tns:GetTicketMessageWithEmbeddedDataRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketMessageWithEmbeddedDataResponse" name="GetTicketMessageWithEmbeddedDataResponse" message="tns:GetTicketMessageWithEmbeddedDataResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteMessageHeaders">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/DeleteMessageHeaders" name="DeleteMessageHeadersRequest" message="tns:DeleteMessageHeadersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/DeleteMessageHeadersResponse" name="DeleteMessageHeadersResponse" message="tns:DeleteMessageHeadersResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTicketMessageWithOptions">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketMessageWithOptions" name="GetTicketMessageWithOptionsRequest" message="tns:GetTicketMessageWithOptionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketMessageWithOptionsResponse" name="GetTicketMessageWithOptionsResponse" message="tns:GetTicketMessageWithOptionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTicketSummaries">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketSummaries" name="GetTicketSummariesRequest" message="tns:GetTicketSummariesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketSummariesResponse" name="GetTicketSummariesResponse" message="tns:GetTicketSummariesResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Ticket" type="tns:Ticket">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultAttachmentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/CreateDefaultAttachmentEntity" style="document" />
      <wsdl:input name="CreateDefaultAttachmentEntityRequest">
        <soap:header message="tns:CreateDefaultAttachmentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultAttachmentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultAttachmentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultAttachmentEntityResponse">
        <soap:header message="tns:CreateDefaultAttachmentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAttachmentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAttachmentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultAttachmentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveAttachmentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SaveAttachmentEntity" style="document" />
      <wsdl:input name="SaveAttachmentEntityRequest">
        <soap:header message="tns:SaveAttachmentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveAttachmentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveAttachmentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveAttachmentEntityResponse">
        <soap:header message="tns:SaveAttachmentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveAttachmentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveAttachmentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveAttachmentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTicketEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/CreateDefaultTicketEntity" style="document" />
      <wsdl:input name="CreateDefaultTicketEntityRequest">
        <soap:header message="tns:CreateDefaultTicketEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTicketEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTicketEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTicketEntityResponse">
        <soap:header message="tns:CreateDefaultTicketEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTicketEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTicketEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTicketEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveTicketEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SaveTicketEntity" style="document" />
      <wsdl:input name="SaveTicketEntityRequest">
        <soap:header message="tns:SaveTicketEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveTicketEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveTicketEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveTicketEntityResponse">
        <soap:header message="tns:SaveTicketEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveTicketEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveTicketEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveTicketEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTicketMessageEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/CreateDefaultTicketMessageEntity" style="document" />
      <wsdl:input name="CreateDefaultTicketMessageEntityRequest">
        <soap:header message="tns:CreateDefaultTicketMessageEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTicketMessageEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTicketMessageEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTicketMessageEntityResponse">
        <soap:header message="tns:CreateDefaultTicketMessageEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTicketMessageEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTicketMessageEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTicketMessageEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveTicketMessageEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SaveTicketMessageEntity" style="document" />
      <wsdl:input name="SaveTicketMessageEntityRequest">
        <soap:header message="tns:SaveTicketMessageEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveTicketMessageEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveTicketMessageEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveTicketMessageEntityResponse">
        <soap:header message="tns:SaveTicketMessageEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveTicketMessageEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveTicketMessageEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveTicketMessageEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAttachmentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetAttachmentEntity" style="document" />
      <wsdl:input name="GetAttachmentEntityRequest">
        <soap:header message="tns:GetAttachmentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAttachmentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAttachmentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAttachmentEntityResponse">
        <soap:header message="tns:GetAttachmentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAttachmentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAttachmentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAttachmentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CopyFromCRMDocument">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/CopyFromCRMDocument" style="document" />
      <wsdl:input name="CopyFromCRMDocumentRequest">
        <soap:header message="tns:CopyFromCRMDocumentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CopyFromCRMDocumentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CopyFromCRMDocumentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CopyFromCRMDocumentResponse">
        <soap:header message="tns:CopyFromCRMDocumentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CopyFromCRMDocumentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CopyFromCRMDocumentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CopyFromCRMDocumentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CopyToTempFile">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/CopyToTempFile" style="document" />
      <wsdl:input name="CopyToTempFileRequest">
        <soap:header message="tns:CopyToTempFileRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CopyToTempFileRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CopyToTempFileRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CopyToTempFileResponse">
        <soap:header message="tns:CopyToTempFileResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CopyToTempFileResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CopyToTempFileResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CopyToTempFileResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UploadAttachment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/UploadAttachment" style="document" />
      <wsdl:input name="UploadAttachmentRequest">
        <soap:header message="tns:UploadAttachmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UploadAttachmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UploadAttachmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UploadAttachmentResponse">
        <soap:header message="tns:UploadAttachmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UploadAttachmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UploadAttachmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UploadAttachmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAttachmentStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetAttachmentStream" style="document" />
      <wsdl:input name="GetAttachmentStreamRequest">
        <soap:header message="tns:GetAttachmentStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAttachmentStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAttachmentStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAttachmentStreamResponse">
        <soap:header message="tns:GetAttachmentStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAttachmentStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAttachmentStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAttachmentStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTicket">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicket" style="document" />
      <wsdl:input name="GetTicketRequest">
        <soap:header message="tns:GetTicketRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTicketRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTicketRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTicketResponse">
        <soap:header message="tns:GetTicketResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTicketResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTicketResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTicketResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTickets">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTickets" style="document" />
      <wsdl:input name="GetTicketsRequest">
        <soap:header message="tns:GetTicketsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTicketsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTicketsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTicketsResponse">
        <soap:header message="tns:GetTicketsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTicketsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTicketsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTicketsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTicketEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketEntity" style="document" />
      <wsdl:input name="GetTicketEntityRequest">
        <soap:header message="tns:GetTicketEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTicketEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTicketEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTicketEntityResponse">
        <soap:header message="tns:GetTicketEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTicketEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTicketEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTicketEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetForRmUi">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetForRmUi" style="document" />
      <wsdl:input name="GetForRmUiRequest">
        <soap:header message="tns:GetForRmUiRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetForRmUiRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetForRmUiRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetForRmUiResponse">
        <soap:header message="tns:GetForRmUiResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetForRmUiResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetForRmUiResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetForRmUiResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteTicketEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/DeleteTicketEntity" style="document" />
      <wsdl:input name="DeleteTicketEntityRequest">
        <soap:header message="tns:DeleteTicketEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteTicketEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteTicketEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteTicketEntityResponse">
        <soap:header message="tns:DeleteTicketEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteTicketEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteTicketEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteTicketEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="NotifyNewTicket">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/NotifyNewTicket" style="document" />
      <wsdl:input name="NotifyNewTicketRequest">
        <soap:header message="tns:NotifyNewTicketRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:NotifyNewTicketRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:NotifyNewTicketRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="NotifyNewTicketResponse">
        <soap:header message="tns:NotifyNewTicketResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:NotifyNewTicketResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:NotifyNewTicketResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:NotifyNewTicketResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="NotifyNewTicketMessage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/NotifyNewTicketMessage" style="document" />
      <wsdl:input name="NotifyNewTicketMessageRequest">
        <soap:header message="tns:NotifyNewTicketMessageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:NotifyNewTicketMessageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:NotifyNewTicketMessageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="NotifyNewTicketMessageResponse">
        <soap:header message="tns:NotifyNewTicketMessageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:NotifyNewTicketMessageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:NotifyNewTicketMessageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:NotifyNewTicketMessageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTicketAttachments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketAttachments" style="document" />
      <wsdl:input name="GetTicketAttachmentsRequest">
        <soap:header message="tns:GetTicketAttachmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTicketAttachmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTicketAttachmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTicketAttachmentsResponse">
        <soap:header message="tns:GetTicketAttachmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTicketAttachmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTicketAttachmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTicketAttachmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ValidateAttachments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/ValidateAttachments" style="document" />
      <wsdl:input name="ValidateAttachmentsRequest">
        <soap:header message="tns:ValidateAttachmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ValidateAttachmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ValidateAttachmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ValidateAttachmentsResponse">
        <soap:header message="tns:ValidateAttachmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ValidateAttachmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ValidateAttachmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ValidateAttachmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetTicketReadByOwner">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SetTicketReadByOwner" style="document" />
      <wsdl:input name="SetTicketReadByOwnerRequest">
        <soap:header message="tns:SetTicketReadByOwnerRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetTicketReadByOwnerRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetTicketReadByOwnerRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetTicketReadByOwnerResponse">
        <soap:header message="tns:SetTicketReadByOwnerResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetTicketReadByOwnerResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetTicketReadByOwnerResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetTicketReadByOwnerResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveTicketEntityWithNotify">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SaveTicketEntityWithNotify" style="document" />
      <wsdl:input name="SaveTicketEntityWithNotifyRequest">
        <soap:header message="tns:SaveTicketEntityWithNotifyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveTicketEntityWithNotifyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveTicketEntityWithNotifyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveTicketEntityWithNotifyResponse">
        <soap:header message="tns:SaveTicketEntityWithNotifyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveTicketEntityWithNotifyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveTicketEntityWithNotifyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveTicketEntityWithNotifyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNextInQueue">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetNextInQueue" style="document" />
      <wsdl:input name="GetNextInQueueRequest">
        <soap:header message="tns:GetNextInQueueRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNextInQueueRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNextInQueueRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNextInQueueResponse">
        <soap:header message="tns:GetNextInQueueResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNextInQueueResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNextInQueueResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNextInQueueResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ProcessTicketWhenRead">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/ProcessTicketWhenRead" style="document" />
      <wsdl:input name="ProcessTicketWhenReadRequest">
        <soap:header message="tns:ProcessTicketWhenReadRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ProcessTicketWhenReadRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ProcessTicketWhenReadRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ProcessTicketWhenReadResponse">
        <soap:header message="tns:ProcessTicketWhenReadResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ProcessTicketWhenReadResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ProcessTicketWhenReadResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ProcessTicketWhenReadResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SplitTicket">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SplitTicket" style="document" />
      <wsdl:input name="SplitTicketRequest">
        <soap:header message="tns:SplitTicketRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SplitTicketRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SplitTicketRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SplitTicketResponse">
        <soap:header message="tns:SplitTicketResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SplitTicketResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SplitTicketResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SplitTicketResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SplitTicketMessage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SplitTicketMessage" style="document" />
      <wsdl:input name="SplitTicketMessageRequest">
        <soap:header message="tns:SplitTicketMessageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SplitTicketMessageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SplitTicketMessageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SplitTicketMessageResponse">
        <soap:header message="tns:SplitTicketMessageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SplitTicketMessageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SplitTicketMessageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SplitTicketMessageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateTicketsReadStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/UpdateTicketsReadStatus" style="document" />
      <wsdl:input name="UpdateTicketsReadStatusRequest">
        <soap:header message="tns:UpdateTicketsReadStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateTicketsReadStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateTicketsReadStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateTicketsReadStatusResponse">
        <soap:header message="tns:UpdateTicketsReadStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateTicketsReadStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateTicketsReadStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateTicketsReadStatusResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateTicketsReadStatusByProvider">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/UpdateTicketsReadStatusByProvider" style="document" />
      <wsdl:input name="UpdateTicketsReadStatusByProviderRequest">
        <soap:header message="tns:UpdateTicketsReadStatusByProviderRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateTicketsReadStatusByProviderRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateTicketsReadStatusByProviderRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateTicketsReadStatusByProviderResponse">
        <soap:header message="tns:UpdateTicketsReadStatusByProviderResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateTicketsReadStatusByProviderResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateTicketsReadStatusByProviderResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateTicketsReadStatusByProviderResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="MergeTickets">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/MergeTickets" style="document" />
      <wsdl:input name="MergeTicketsRequest">
        <soap:header message="tns:MergeTicketsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MergeTicketsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MergeTicketsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MergeTicketsResponse">
        <soap:header message="tns:MergeTicketsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MergeTicketsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MergeTicketsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MergeTicketsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetDeletedStatusByIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SetDeletedStatusByIds" style="document" />
      <wsdl:input name="SetDeletedStatusByIdsRequest">
        <soap:header message="tns:SetDeletedStatusByIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetDeletedStatusByIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetDeletedStatusByIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetDeletedStatusByIdsResponse">
        <soap:header message="tns:SetDeletedStatusByIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetDeletedStatusByIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetDeletedStatusByIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetDeletedStatusByIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetDeletedStatusByProvider">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SetDeletedStatusByProvider" style="document" />
      <wsdl:input name="SetDeletedStatusByProviderRequest">
        <soap:header message="tns:SetDeletedStatusByProviderRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetDeletedStatusByProviderRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetDeletedStatusByProviderRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetDeletedStatusByProviderResponse">
        <soap:header message="tns:SetDeletedStatusByProviderResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetDeletedStatusByProviderResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetDeletedStatusByProviderResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetDeletedStatusByProviderResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UndeleteByIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/UndeleteByIds" style="document" />
      <wsdl:input name="UndeleteByIdsRequest">
        <soap:header message="tns:UndeleteByIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UndeleteByIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UndeleteByIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UndeleteByIdsResponse">
        <soap:header message="tns:UndeleteByIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UndeleteByIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UndeleteByIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UndeleteByIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ResolveTicketId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/ResolveTicketId" style="document" />
      <wsdl:input name="ResolveTicketIdRequest">
        <soap:header message="tns:ResolveTicketIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ResolveTicketIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ResolveTicketIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ResolveTicketIdResponse">
        <soap:header message="tns:ResolveTicketIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ResolveTicketIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ResolveTicketIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ResolveTicketIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="BatchForward">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/BatchForward" style="document" />
      <wsdl:input name="BatchForwardRequest">
        <soap:header message="tns:BatchForwardRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:BatchForwardRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:BatchForwardRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="BatchForwardResponse">
        <soap:header message="tns:BatchForwardResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:BatchForwardResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:BatchForwardResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:BatchForwardResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="BatchReply">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/BatchReply" style="document" />
      <wsdl:input name="BatchReplyRequest">
        <soap:header message="tns:BatchReplyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:BatchReplyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:BatchReplyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="BatchReplyResponse">
        <soap:header message="tns:BatchReplyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:BatchReplyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:BatchReplyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:BatchReplyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ClearNotify">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/ClearNotify" style="document" />
      <wsdl:input name="ClearNotifyRequest">
        <soap:header message="tns:ClearNotifyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ClearNotifyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ClearNotifyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ClearNotifyResponse">
        <soap:header message="tns:ClearNotifyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ClearNotifyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ClearNotifyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ClearNotifyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTicketMessageEntities">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketMessageEntities" style="document" />
      <wsdl:input name="GetTicketMessageEntitiesRequest">
        <soap:header message="tns:GetTicketMessageEntitiesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTicketMessageEntitiesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTicketMessageEntitiesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTicketMessageEntitiesResponse">
        <soap:header message="tns:GetTicketMessageEntitiesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTicketMessageEntitiesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTicketMessageEntitiesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTicketMessageEntitiesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTicketMessage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketMessage" style="document" />
      <wsdl:input name="GetTicketMessageRequest">
        <soap:header message="tns:GetTicketMessageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTicketMessageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTicketMessageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTicketMessageResponse">
        <soap:header message="tns:GetTicketMessageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTicketMessageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTicketMessageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTicketMessageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTicketMessageEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketMessageEntity" style="document" />
      <wsdl:input name="GetTicketMessageEntityRequest">
        <soap:header message="tns:GetTicketMessageEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTicketMessageEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTicketMessageEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTicketMessageEntityResponse">
        <soap:header message="tns:GetTicketMessageEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTicketMessageEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTicketMessageEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTicketMessageEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteTicketMessageEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/DeleteTicketMessageEntity" style="document" />
      <wsdl:input name="DeleteTicketMessageEntityRequest">
        <soap:header message="tns:DeleteTicketMessageEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteTicketMessageEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteTicketMessageEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteTicketMessageEntityResponse">
        <soap:header message="tns:DeleteTicketMessageEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteTicketMessageEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteTicketMessageEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteTicketMessageEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SanitizeMailContent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SanitizeMailContent" style="document" />
      <wsdl:input name="SanitizeMailContentRequest">
        <soap:header message="tns:SanitizeMailContentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SanitizeMailContentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SanitizeMailContentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SanitizeMailContentResponse">
        <soap:header message="tns:SanitizeMailContentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SanitizeMailContentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SanitizeMailContentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SanitizeMailContentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SanitizeMailContents">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SanitizeMailContents" style="document" />
      <wsdl:input name="SanitizeMailContentsRequest">
        <soap:header message="tns:SanitizeMailContentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SanitizeMailContentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SanitizeMailContentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SanitizeMailContentsResponse">
        <soap:header message="tns:SanitizeMailContentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SanitizeMailContentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SanitizeMailContentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SanitizeMailContentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Html2Text">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/Html2Text" style="document" />
      <wsdl:input name="Html2TextRequest">
        <soap:header message="tns:Html2TextRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:Html2TextRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:Html2TextRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="Html2TextResponse">
        <soap:header message="tns:Html2TextResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:Html2TextResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:Html2TextResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:Html2TextResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAttachmentInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetAttachmentInfo" style="document" />
      <wsdl:input name="GetAttachmentInfoRequest">
        <soap:header message="tns:GetAttachmentInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAttachmentInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAttachmentInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAttachmentInfoResponse">
        <soap:header message="tns:GetAttachmentInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAttachmentInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAttachmentInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAttachmentInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAttachmentInfoNonInline">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetAttachmentInfoNonInline" style="document" />
      <wsdl:input name="GetAttachmentInfoNonInlineRequest">
        <soap:header message="tns:GetAttachmentInfoNonInlineRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAttachmentInfoNonInlineRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAttachmentInfoNonInlineRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAttachmentInfoNonInlineResponse">
        <soap:header message="tns:GetAttachmentInfoNonInlineResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAttachmentInfoNonInlineResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAttachmentInfoNonInlineResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAttachmentInfoNonInlineResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddAttachments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/AddAttachments" style="document" />
      <wsdl:input name="AddAttachmentsRequest">
        <soap:header message="tns:AddAttachmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddAttachmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddAttachmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddAttachmentsResponse">
        <soap:header message="tns:AddAttachmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddAttachmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddAttachmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddAttachmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveMessageAttachments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/RemoveMessageAttachments" style="document" />
      <wsdl:input name="RemoveMessageAttachmentsRequest">
        <soap:header message="tns:RemoveMessageAttachmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveMessageAttachmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveMessageAttachmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveMessageAttachmentsResponse">
        <soap:header message="tns:RemoveMessageAttachmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveMessageAttachmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveMessageAttachmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveMessageAttachmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPreviewAttachmentStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetPreviewAttachmentStream" style="document" />
      <wsdl:input name="GetPreviewAttachmentStreamRequest">
        <soap:header message="tns:GetPreviewAttachmentStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPreviewAttachmentStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPreviewAttachmentStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPreviewAttachmentStreamResponse">
        <soap:header message="tns:GetPreviewAttachmentStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPreviewAttachmentStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPreviewAttachmentStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPreviewAttachmentStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SendTicketMessage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SendTicketMessage" style="document" />
      <wsdl:input name="SendTicketMessageRequest">
        <soap:header message="tns:SendTicketMessageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SendTicketMessageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SendTicketMessageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SendTicketMessageResponse">
        <soap:header message="tns:SendTicketMessageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SendTicketMessageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SendTicketMessageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SendTicketMessageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SendTicketMessageSms">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SendTicketMessageSms" style="document" />
      <wsdl:input name="SendTicketMessageSmsRequest">
        <soap:header message="tns:SendTicketMessageSmsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SendTicketMessageSmsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SendTicketMessageSmsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SendTicketMessageSmsResponse">
        <soap:header message="tns:SendTicketMessageSmsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SendTicketMessageSmsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SendTicketMessageSmsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SendTicketMessageSmsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetTicketMessageImportant">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SetTicketMessageImportant" style="document" />
      <wsdl:input name="SetTicketMessageImportantRequest">
        <soap:header message="tns:SetTicketMessageImportantRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetTicketMessageImportantRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetTicketMessageImportantRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetTicketMessageImportantResponse">
        <soap:header message="tns:SetTicketMessageImportantResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetTicketMessageImportantResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetTicketMessageImportantResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetTicketMessageImportantResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CalculateMessageRecipients">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/CalculateMessageRecipients" style="document" />
      <wsdl:input name="CalculateMessageRecipientsRequest">
        <soap:header message="tns:CalculateMessageRecipientsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CalculateMessageRecipientsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CalculateMessageRecipientsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CalculateMessageRecipientsResponse">
        <soap:header message="tns:CalculateMessageRecipientsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CalculateMessageRecipientsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CalculateMessageRecipientsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CalculateMessageRecipientsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveTicketMessageEntityWithNotify">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SaveTicketMessageEntityWithNotify" style="document" />
      <wsdl:input name="SaveTicketMessageEntityWithNotifyRequest">
        <soap:header message="tns:SaveTicketMessageEntityWithNotifyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveTicketMessageEntityWithNotifyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveTicketMessageEntityWithNotifyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveTicketMessageEntityWithNotifyResponse">
        <soap:header message="tns:SaveTicketMessageEntityWithNotifyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveTicketMessageEntityWithNotifyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveTicketMessageEntityWithNotifyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveTicketMessageEntityWithNotifyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveTicketMessageEntityWithOptions">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/SaveTicketMessageEntityWithOptions" style="document" />
      <wsdl:input name="SaveTicketMessageEntityWithOptionsRequest">
        <soap:header message="tns:SaveTicketMessageEntityWithOptionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveTicketMessageEntityWithOptionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveTicketMessageEntityWithOptionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveTicketMessageEntityWithOptionsResponse">
        <soap:header message="tns:SaveTicketMessageEntityWithOptionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveTicketMessageEntityWithOptionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveTicketMessageEntityWithOptionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveTicketMessageEntityWithOptionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDefaultMessageContent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetDefaultMessageContent" style="document" />
      <wsdl:input name="GetDefaultMessageContentRequest">
        <soap:header message="tns:GetDefaultMessageContentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDefaultMessageContentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDefaultMessageContentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDefaultMessageContentResponse">
        <soap:header message="tns:GetDefaultMessageContentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDefaultMessageContentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDefaultMessageContentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDefaultMessageContentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDefaultMessageContentFull">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetDefaultMessageContentFull" style="document" />
      <wsdl:input name="GetDefaultMessageContentFullRequest">
        <soap:header message="tns:GetDefaultMessageContentFullRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDefaultMessageContentFullRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDefaultMessageContentFullRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDefaultMessageContentFullResponse">
        <soap:header message="tns:GetDefaultMessageContentFullResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDefaultMessageContentFullResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDefaultMessageContentFullResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDefaultMessageContentFullResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTicketMessageWithEmbeddedData">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketMessageWithEmbeddedData" style="document" />
      <wsdl:input name="GetTicketMessageWithEmbeddedDataRequest">
        <soap:header message="tns:GetTicketMessageWithEmbeddedDataRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTicketMessageWithEmbeddedDataRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTicketMessageWithEmbeddedDataRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTicketMessageWithEmbeddedDataResponse">
        <soap:header message="tns:GetTicketMessageWithEmbeddedDataResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTicketMessageWithEmbeddedDataResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTicketMessageWithEmbeddedDataResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTicketMessageWithEmbeddedDataResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteMessageHeaders">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/DeleteMessageHeaders" style="document" />
      <wsdl:input name="DeleteMessageHeadersRequest">
        <soap:header message="tns:DeleteMessageHeadersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteMessageHeadersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteMessageHeadersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteMessageHeadersResponse">
        <soap:header message="tns:DeleteMessageHeadersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteMessageHeadersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteMessageHeadersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteMessageHeadersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTicketMessageWithOptions">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketMessageWithOptions" style="document" />
      <wsdl:input name="GetTicketMessageWithOptionsRequest">
        <soap:header message="tns:GetTicketMessageWithOptionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTicketMessageWithOptionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTicketMessageWithOptionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTicketMessageWithOptionsResponse">
        <soap:header message="tns:GetTicketMessageWithOptionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTicketMessageWithOptionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTicketMessageWithOptionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTicketMessageWithOptionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTicketSummaries">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Ticket/GetTicketSummaries" style="document" />
      <wsdl:input name="GetTicketSummariesRequest">
        <soap:header message="tns:GetTicketSummariesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTicketSummariesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTicketSummariesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTicketSummariesResponse">
        <soap:header message="tns:GetTicketSummariesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTicketSummariesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTicketSummariesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTicketSummariesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfTicketService">
    <wsdl:port name="BasicHttpBinding_Ticket" binding="tns:BasicHttpBinding_Ticket">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/Ticket.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

