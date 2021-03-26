---
Generated: 1
TOCExclude: 1
title: Services75.SelectionAgent WSDL
---

# Services75.SelectionAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfSelectionService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services75" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services75" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services75" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:ser="http://schemas.microsoft.com/2003/10/Serialization/">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:element name="CreateDefaultMailMergeSettings">
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
      <xs:element name="SoCredentials" nillable="true" type="q1:SoCredentials" xmlns:q1="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:element name="Credentials" nillable="true" type="q2:SoCredentials" xmlns:q2="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="SoTimeZone">
        <xs:sequence>
          <xs:element minOccurs="0" name="SoTimeZoneId" type="xs:int" />
          <xs:element minOccurs="0" name="SoTimeZoneLocationCode" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoTimeZone" nillable="true" type="q3:SoTimeZone" xmlns:q3="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:element name="TimeZone" nillable="true" type="q4:SoTimeZone" xmlns:q4="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:element name="CreateDefaultMailMergeSettingsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q5:MailMergeSettings" xmlns:q5="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="MailMergeSettings">
        <xs:complexContent mixed="false">
          <xs:extension base="q6:Carrier" xmlns:q6="http://www.superoffice.net/ws/crm/NetServer/Services75">
            <xs:sequence>
              <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
              <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
              <xs:element minOccurs="0" name="MailMergeDeliveryType" type="q6:EMailMergeTargetType" />
              <xs:element minOccurs="0" name="CustomAttention" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AlwaysUseCustomAttention" type="xs:boolean" />
              <xs:element minOccurs="0" name="SaveDocument" type="xs:boolean" />
              <xs:element minOccurs="0" name="CustomMailBody" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TaskEntity" nillable="true" type="q6:MailMergeTask" />
              <xs:element minOccurs="0" name="AddCompanyInterest" type="xs:int" />
              <xs:element minOccurs="0" name="AddPersonInterest" type="xs:int" />
              <xs:element minOccurs="0" name="RemoveCompanyInterest" type="xs:int" />
              <xs:element minOccurs="0" name="RemovePersonInterest" type="xs:int" />
              <xs:element minOccurs="0" name="IncludeNoMailingsRecipient" type="xs:boolean" />
              <xs:element minOccurs="0" name="TestOnly" type="xs:boolean" />
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="IncludeRetiredRecipients" type="xs:boolean" />
              <xs:element minOccurs="0" name="IncludeStoppedRecipients" type="xs:boolean" />
              <xs:element minOccurs="0" name="CustomMailSubject" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Synchronous" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsTemporarySelection" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="MailMergeSettings" nillable="true" type="q7:MailMergeSettings" xmlns:q7="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="Carrier">
        <xs:sequence>
          <xs:element minOccurs="0" name="TableRight" nillable="true" type="q8:TableRight" xmlns:q8="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          <xs:element minOccurs="0" name="FieldProperties" nillable="true" type="q9:FieldPropertyDictionary" xmlns:q9="http://www.superoffice.net/ws/crm/NetServer/Services75" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="Carrier" nillable="true" type="q10:Carrier" xmlns:q10="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="TableRight">
        <xs:sequence>
          <xs:element minOccurs="0" name="Mask" type="q11:ETableRight" xmlns:q11="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TableRight" nillable="true" type="q12:TableRight" xmlns:q12="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="ETableRight" nillable="true" type="q13:ETableRight" xmlns:q13="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
                <xs:element name="Value" nillable="true" type="q14:FieldProperty" xmlns:q14="http://www.superoffice.net/ws/crm/NetServer/Services75" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldPropertyDictionary" nillable="true" type="q15:FieldPropertyDictionary" xmlns:q15="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="FieldProperty">
        <xs:sequence>
          <xs:element minOccurs="0" name="FieldRight" nillable="true" type="q16:FieldRight" xmlns:q16="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          <xs:element minOccurs="0" name="FieldType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FieldLength" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldProperty" nillable="true" type="q17:FieldProperty" xmlns:q17="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="FieldRight">
        <xs:sequence>
          <xs:element minOccurs="0" name="Mask" type="q18:EFieldRight" xmlns:q18="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldRight" nillable="true" type="q19:FieldRight" xmlns:q19="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="EFieldRight" nillable="true" type="q20:EFieldRight" xmlns:q20="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:simpleType name="EMailMergeTargetType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="BestFit" />
          <xs:enumeration value="Electronic" />
          <xs:enumeration value="Mail" />
          <xs:enumeration value="Fax" />
          <xs:enumeration value="Printer" />
          <xs:enumeration value="Xml" />
          <xs:enumeration value="XmlFax" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="EMailMergeTargetType" nillable="true" type="q21:EMailMergeTargetType" xmlns:q21="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="MailMergeTask">
        <xs:complexContent mixed="false">
          <xs:extension base="q22:Carrier" xmlns:q22="http://www.superoffice.net/ws/crm/NetServer/Services75">
            <xs:sequence>
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="TypeId" type="xs:int" />
              <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Duration" type="xs:int" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PriorityId" type="xs:int" />
              <xs:element minOccurs="0" name="VisibleFor" nillable="true" type="q22:VisibleFor" />
              <xs:element minOccurs="0" name="Completed" type="q22:ActivityStatus" />
              <xs:element minOccurs="0" name="OwnerAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="SingleEntryOnEachCompany" type="xs:boolean" />
              <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="MailMergeTask" nillable="true" type="q23:MailMergeTask" xmlns:q23="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="VisibleFor">
        <xs:complexContent mixed="false">
          <xs:extension base="q24:Carrier" xmlns:q24="http://www.superoffice.net/ws/crm/NetServer/Services75">
            <xs:sequence>
              <xs:element minOccurs="0" name="VisibleId" type="xs:int" />
              <xs:element minOccurs="0" name="Visibility" type="q24:Visibility" />
              <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="VisibleFor" nillable="true" type="q25:VisibleFor" xmlns:q25="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:simpleType name="Visibility">
        <xs:restriction base="xs:string">
          <xs:enumeration value="All" />
          <xs:enumeration value="Associate" />
          <xs:enumeration value="Group" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="Visibility" nillable="true" type="q26:Visibility" xmlns:q26="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:simpleType name="ActivityStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="NotStarted" />
          <xs:enumeration value="Started" />
          <xs:enumeration value="Completed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ActivityStatus" nillable="true" type="q27:ActivityStatus" xmlns:q27="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="SoExceptionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="StackTrace" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FriendlyText" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ExceptionType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="InnerException" nillable="true" type="q28:SoExceptionInfo" xmlns:q28="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          <xs:element minOccurs="0" name="Parameters" nillable="true" type="q29:SoExceptionInfoParameters" xmlns:q29="http://www.superoffice.net/ws/crm/NetServer/Services75" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExceptionInfo" nillable="true" type="q30:SoExceptionInfo" xmlns:q30="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="SoExceptionInfoParameters" nillable="true" type="q31:SoExceptionInfoParameters" xmlns:q31="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:element name="ExceptionInfo" nillable="true" type="q32:SoExceptionInfo" xmlns:q32="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="SoExtraInfo" nillable="true" type="q33:SoExtraInfo" xmlns:q33="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:element name="ExtraInfo" nillable="true" type="q34:SoExtraInfo" xmlns:q34="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:element name="Succeeded" type="xs:boolean" />
      <xs:element name="CreateDefaultMailMergeTask">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultMailMergeTaskResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q35:MailMergeTask" xmlns:q35="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultSelectionEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultSelectionEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q36:SelectionEntity" xmlns:q36="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SelectionEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q37:Carrier" xmlns:q37="http://www.superoffice.net/ws/crm/NetServer/Services75">
            <xs:sequence>
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Postit" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Associate" nillable="true" type="q37:Associate" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="q37:Associate" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="q37:Associate" />
              <xs:element minOccurs="0" name="SelectionCategory" nillable="true" type="q37:SelectionCategory" />
              <xs:element minOccurs="0" name="GroupIdx" type="xs:int" />
              <xs:element minOccurs="0" name="IncludePerson" type="xs:int" />
              <xs:element minOccurs="0" name="MemberCount" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PostitTextId" type="xs:int" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
              <xs:element minOccurs="0" name="SoundEx" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Source" type="xs:short" />
              <xs:element minOccurs="0" name="TextId" type="xs:int" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedCount" type="xs:short" />
              <xs:element minOccurs="0" name="Visibility" type="xs:short" />
              <xs:element minOccurs="0" name="SelectionType" type="q37:SelectionType" />
              <xs:element minOccurs="0" name="CompanyUnique" type="xs:boolean" />
              <xs:element minOccurs="0" name="TargetTableNumber" type="xs:int" />
              <xs:element minOccurs="0" name="TargetTableName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Completed" type="xs:boolean" />
              <xs:element minOccurs="0" name="LeftSelectionId" type="xs:int" />
              <xs:element minOccurs="0" name="RightSelectionId" type="xs:int" />
              <xs:element minOccurs="0" name="SelectionUnionType" type="q37:SelectionUnionType" />
              <xs:element minOccurs="0" name="VisibleFor" nillable="true" type="q37:ArrayOfVisibleFor" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SelectionEntity" nillable="true" type="q38:SelectionEntity" xmlns:q38="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="Associate">
        <xs:complexContent mixed="false">
          <xs:extension base="q39:Carrier" xmlns:q39="http://www.superoffice.net/ws/crm/NetServer/Services75">
            <xs:sequence>
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Type" type="q39:UserType" />
              <xs:element minOccurs="0" name="GroupIdx" type="xs:int" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="EjUserId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Associate" nillable="true" type="q40:Associate" xmlns:q40="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="UserType" nillable="true" type="q41:UserType" xmlns:q41="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="SelectionCategory">
        <xs:complexContent mixed="false">
          <xs:extension base="q42:Carrier" xmlns:q42="http://www.superoffice.net/ws/crm/NetServer/Services75">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SelectionCategory" nillable="true" type="q43:SelectionCategory" xmlns:q43="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:simpleType name="SelectionType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Static" />
          <xs:enumeration value="Dynamic" />
          <xs:enumeration value="Combined" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="SelectionType" nillable="true" type="q44:SelectionType" xmlns:q44="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:simpleType name="SelectionUnionType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="SubtractRightFromLeft" />
          <xs:enumeration value="SubtractLeftFromRight" />
          <xs:enumeration value="Intersect" />
          <xs:enumeration value="XOR" />
          <xs:enumeration value="Union" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="SelectionUnionType" nillable="true" type="q45:SelectionUnionType" xmlns:q45="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="ArrayOfVisibleFor">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="VisibleFor" nillable="true" type="q46:VisibleFor" xmlns:q46="http://www.superoffice.net/ws/crm/NetServer/Services75" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfVisibleFor" nillable="true" type="q47:ArrayOfVisibleFor" xmlns:q47="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:element name="SaveSelectionEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionEntity" nillable="true" type="q48:SelectionEntity" xmlns:q48="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveSelectionEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q49:SelectionEntity" xmlns:q49="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteSelectionEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteSelectionEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectionEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectionEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q50:SelectionEntity" xmlns:q50="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateContactSelectionFromSelection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TargetSelectionType" type="q51:SelectionType" xmlns:q51="http://www.superoffice.net/ws/crm/NetServer/Services75" />
            <xs:element minOccurs="0" name="CopyMembers" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateContactSelectionFromSelectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q52:SelectionEntity" xmlns:q52="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTemporaryContactSelectionFromContactPersonIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactPersonIds" nillable="true" type="q53:ArrayOfContactPersonId" xmlns:q53="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfContactPersonId">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ContactPersonId" nillable="true" type="q54:ContactPersonId" xmlns:q54="http://www.superoffice.net/ws/crm/NetServer/Services75" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfContactPersonId" nillable="true" type="q55:ArrayOfContactPersonId" xmlns:q55="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="ContactPersonId">
        <xs:complexContent mixed="false">
          <xs:extension base="q56:Carrier" xmlns:q56="http://www.superoffice.net/ws/crm/NetServer/Services75">
            <xs:sequence>
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ContactPersonId" nillable="true" type="q57:ContactPersonId" xmlns:q57="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:element name="CreateTemporaryContactSelectionFromContactPersonIdsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q58:SelectionEntity" xmlns:q58="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTemporaryContactSelectionFromProjectMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTemporaryContactSelectionFromProjectMembersResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q59:SelectionEntity" xmlns:q59="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopyContactSelectionMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FromSelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ToSelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopyContactSelectionMembersResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRecipientStatistics">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRecipientStatisticsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q60:RecipientStatistics" xmlns:q60="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="RecipientStatistics">
        <xs:complexContent mixed="false">
          <xs:extension base="q61:Carrier" xmlns:q61="http://www.superoffice.net/ws/crm/NetServer/Services75">
            <xs:sequence>
              <xs:element minOccurs="0" name="Total" type="xs:int" />
              <xs:element minOccurs="0" name="ValidPostalAddresses" type="xs:int" />
              <xs:element minOccurs="0" name="ValidEmailAddresses" type="xs:int" />
              <xs:element minOccurs="0" name="ValidFaxNumbers" type="xs:int" />
              <xs:element minOccurs="0" name="NoAddresses" type="xs:int" />
              <xs:element minOccurs="0" name="NoFaxOrEmails" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="RecipientStatistics" nillable="true" type="q62:RecipientStatistics" xmlns:q62="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:element name="GetRecipientStatisticsFromProjectMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRecipientStatisticsFromProjectMembersResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q63:RecipientStatistics" xmlns:q63="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRecipientStatisticsFromContactPersonIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactPersonIds" nillable="true" type="q64:ArrayOfContactPersonId" xmlns:q64="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRecipientStatisticsFromContactPersonIdsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q65:RecipientStatistics" xmlns:q65="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddContactSelectionMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ContactPersonIds" nillable="true" type="q66:ArrayOfContactPersonId" xmlns:q66="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddContactSelectionMembersResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveContactSelectionMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ContactPersonIds" nillable="true" type="q67:ArrayOfContactPersonId" xmlns:q67="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveContactSelectionMembersResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveContactSelectionMembersFromIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="SelectionMembersIds" nillable="true" type="q68:ArrayOfint" xmlns:q68="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveContactSelectionMembersFromIdsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="AddContactSelectionMembersFromSearch">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddContactSelectionMembersFromSearchResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveContactSelectionMembersFromSearch">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveContactSelectionMembersFromSearchResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTemporaryContactSelection">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTemporaryContactSelectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q69:SelectionEntity" xmlns:q69="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTemporaryContactSelectionFromSelectionMemberIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="SelectionMemberIds" nillable="true" type="q70:ArrayOfint" xmlns:q70="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTemporaryContactSelectionFromSelectionMemberIdsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q71:SelectionEntity" xmlns:q71="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddRemoveContactSelectionMemberInterests">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="AddCompanyInterests" nillable="true" type="q72:ArrayOfint" xmlns:q72="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="RemoveCompanyInterests" nillable="true" type="q73:ArrayOfint" xmlns:q73="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="AddContactInterests" nillable="true" type="q74:ArrayOfint" xmlns:q74="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="RemoveContactInterests" nillable="true" type="q75:ArrayOfint" xmlns:q75="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddRemoveContactSelectionMemberInterestsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="EditContactSelectionMemberDetails">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="SelectionMemberEditValues" nillable="true" type="q76:SelectionMemberEditValues" xmlns:q76="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SelectionMemberEditValues">
        <xs:complexContent mixed="false">
          <xs:extension base="q77:Carrier" xmlns:q77="http://www.superoffice.net/ws/crm/NetServer/Services75">
            <xs:sequence>
              <xs:element minOccurs="0" name="CompanyCategory" type="xs:int" />
              <xs:element minOccurs="0" name="CompanyBusiness" type="xs:int" />
              <xs:element minOccurs="0" name="CompanyOurContact" type="xs:int" />
              <xs:element minOccurs="0" name="CompanyName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CompanyDepartment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CompanyNumber" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CompanyCode" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactPosition" type="xs:int" />
              <xs:element minOccurs="0" name="ChangeCompanyCategory" type="xs:boolean" />
              <xs:element minOccurs="0" name="ChangeCompanyBusiness" type="xs:boolean" />
              <xs:element minOccurs="0" name="ChangeCompanyOurContact" type="xs:boolean" />
              <xs:element minOccurs="0" name="ChangeCompanyName" type="xs:boolean" />
              <xs:element minOccurs="0" name="ChangeCompanyDepartment" type="xs:boolean" />
              <xs:element minOccurs="0" name="ChangeCompanyNumber" type="xs:boolean" />
              <xs:element minOccurs="0" name="ChangeCompanyCode" type="xs:boolean" />
              <xs:element minOccurs="0" name="ChangeContactPosition" type="xs:boolean" />
              <xs:element minOccurs="0" name="CompanyCountry" type="xs:int" />
              <xs:element minOccurs="0" name="ChangeCompanyCountry" type="xs:boolean" />
              <xs:element minOccurs="0" name="ContactJobTitle" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ChangeContactJobTitle" type="xs:boolean" />
              <xs:element minOccurs="0" name="CompanyOrgNr" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ChangeCompanyOrgNr" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SelectionMemberEditValues" nillable="true" type="q78:SelectionMemberEditValues" xmlns:q78="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:element name="EditContactSelectionMemberDetailsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GenerateFollowUps">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="AppointmentEntity" nillable="true" type="q79:AppointmentEntity" xmlns:q79="http://www.superoffice.net/ws/crm/NetServer/Services75" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="SaveOnContactOwner" type="xs:boolean" />
            <xs:element minOccurs="0" name="UniqueContact" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="AppointmentEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q80:Carrier" xmlns:q80="http://www.superoffice.net/ws/crm/NetServer/Services75">
            <xs:sequence>
              <xs:element minOccurs="0" name="Associate" nillable="true" type="q80:Associate" />
              <xs:element minOccurs="0" name="Contact" nillable="true" type="q80:Contact" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="q80:Associate" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="q80:Associate" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="InvitedPerson" nillable="true" type="q80:Person" />
              <xs:element minOccurs="0" name="Person" nillable="true" type="q80:Person" />
              <xs:element minOccurs="0" name="MotherId" type="xs:int" />
              <xs:element minOccurs="0" name="Priority" nillable="true" type="q80:Priority" />
              <xs:element minOccurs="0" name="Private" type="q80:AppointmentPrivate" />
              <xs:element minOccurs="0" name="Project" nillable="true" type="q80:Project" />
              <xs:element minOccurs="0" name="Type" type="q80:AppointmentType" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Completed" type="q80:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveLinks" type="xs:int" />
              <xs:element minOccurs="0" name="Links" nillable="true" type="q80:ArrayOfLink" />
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
              <xs:element minOccurs="0" name="Recurrence" nillable="true" type="q80:RecurrenceInfo" />
              <xs:element minOccurs="0" name="Participants" nillable="true" type="q80:ArrayOfParticipantInfo" />
              <xs:element minOccurs="0" name="AssignmentStatus" type="q80:AssignmentStatus" />
              <xs:element minOccurs="0" name="InvitationStatus" type="q80:InvitationStatus" />
              <xs:element minOccurs="0" name="BookingType" type="q80:BookingType" />
              <xs:element minOccurs="0" name="ActiveDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="HasConflict" type="xs:boolean" />
              <xs:element minOccurs="0" name="AssignedBy" nillable="true" type="q80:Associate" />
              <xs:element minOccurs="0" name="MotherAssociate" nillable="true" type="q80:Associate" />
              <xs:element minOccurs="0" name="Task" nillable="true" type="q80:TaskListItem" />
              <xs:element minOccurs="0" name="PreferredTZLocation" type="xs:int" />
              <xs:element minOccurs="0" name="Sale" nillable="true" type="q80:Sale" />
              <xs:element minOccurs="0" name="SuggestedAppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="IsMileStone" type="xs:boolean" />
              <xs:element minOccurs="0" name="UserDefinedFields" nillable="true" type="q80:StringDictionary" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="q80:StringDictionary" />
              <xs:element minOccurs="0" name="PublishEventDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishTo" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishFrom" type="xs:dateTime" />
              <xs:element minOccurs="0" name="IsPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="VisibleFor" nillable="true" type="q80:ArrayOfVisibleFor" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AppointmentEntity" nillable="true" type="q81:AppointmentEntity" xmlns:q81="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="Contact">
        <xs:complexContent mixed="false">
          <xs:extension base="q82:Carrier" xmlns:q82="http://www.superoffice.net/ws/crm/NetServer/Services75">
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
              <xs:element minOccurs="0" name="Address" nillable="true" type="q82:Address" />
              <xs:element minOccurs="0" name="FormattedAddress" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsOwnerContact" type="xs:boolean" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Contact" nillable="true" type="q83:Contact" xmlns:q83="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="Address">
        <xs:complexContent mixed="false">
          <xs:extension base="q84:Carrier" xmlns:q84="http://www.superoffice.net/ws/crm/NetServer/Services75">
            <xs:sequence>
              <xs:element minOccurs="0" name="Wgs84Latitude" type="xs:double" />
              <xs:element minOccurs="0" name="Wgs84Longitude" type="xs:double" />
              <xs:element minOccurs="0" name="LocalizedAddress" nillable="true" type="q84:ArrayOfArrayOfLocalizedField" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Address" nillable="true" type="q85:Address" xmlns:q85="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="ArrayOfArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArrayOfLocalizedField" nillable="true" type="q86:ArrayOfLocalizedField" xmlns:q86="http://www.superoffice.net/ws/crm/NetServer/Services75" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArrayOfLocalizedField" nillable="true" type="q87:ArrayOfArrayOfLocalizedField" xmlns:q87="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="ArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="LocalizedField" nillable="true" type="q88:LocalizedField" xmlns:q88="http://www.superoffice.net/ws/crm/NetServer/Services75" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLocalizedField" nillable="true" type="q89:ArrayOfLocalizedField" xmlns:q89="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="LocalizedField">
        <xs:complexContent mixed="false">
          <xs:extension base="q90:Carrier" xmlns:q90="http://www.superoffice.net/ws/crm/NetServer/Services75">
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
      <xs:element name="LocalizedField" nillable="true" type="q91:LocalizedField" xmlns:q91="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="Person">
        <xs:complexContent mixed="false">
          <xs:extension base="q92:Carrier" xmlns:q92="http://www.superoffice.net/ws/crm/NetServer/Services75">
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
      <xs:element name="Person" nillable="true" type="q93:Person" xmlns:q93="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="Priority">
        <xs:complexContent mixed="false">
          <xs:extension base="q94:Carrier" xmlns:q94="http://www.superoffice.net/ws/crm/NetServer/Services75">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Priority" nillable="true" type="q95:Priority" xmlns:q95="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="AppointmentPrivate" nillable="true" type="q96:AppointmentPrivate" xmlns:q96="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="Project">
        <xs:complexContent mixed="false">
          <xs:extension base="q97:Carrier" xmlns:q97="http://www.superoffice.net/ws/crm/NetServer/Services75">
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
      <xs:element name="Project" nillable="true" type="q98:Project" xmlns:q98="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="AppointmentType" nillable="true" type="q99:AppointmentType" xmlns:q99="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="ArrayOfLink">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Link" nillable="true" type="q100:Link" xmlns:q100="http://www.superoffice.net/ws/crm/NetServer/Services75" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLink" nillable="true" type="q101:ArrayOfLink" xmlns:q101="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="Link">
        <xs:complexContent mixed="false">
          <xs:extension base="q102:Carrier" xmlns:q102="http://www.superoffice.net/ws/crm/NetServer/Services75">
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
      <xs:element name="Link" nillable="true" type="q103:Link" xmlns:q103="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="RecurrenceInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="RecurrenceId" type="xs:int" />
          <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="RecurrenceEndType" type="q104:RecurrenceEndType" xmlns:q104="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          <xs:element minOccurs="0" name="Pattern" type="q105:RecurrencePattern" xmlns:q105="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          <xs:element minOccurs="0" name="DayPattern" nillable="true" type="q106:RecurrenceDayPattern" xmlns:q106="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          <xs:element minOccurs="0" name="WeekPattern" nillable="true" type="q107:RecurrenceWeekPattern" xmlns:q107="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          <xs:element minOccurs="0" name="MonthPattern" nillable="true" type="q108:RecurrenceMonthPattern" xmlns:q108="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          <xs:element minOccurs="0" name="YearPattern" nillable="true" type="q109:RecurrenceYearPattern" xmlns:q109="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          <xs:element minOccurs="0" name="Dates" nillable="true" type="q110:ArrayOfRecurrenceDate" xmlns:q110="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          <xs:element minOccurs="0" name="RecurrenceCounter" type="xs:int" />
          <xs:element minOccurs="0" name="IsRecurrence" type="xs:boolean" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceInfo" nillable="true" type="q111:RecurrenceInfo" xmlns:q111="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:simpleType name="RecurrenceEndType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="EndDate" />
          <xs:enumeration value="Counter" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrenceEndType" nillable="true" type="q112:RecurrenceEndType" xmlns:q112="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="RecurrencePattern" nillable="true" type="q113:RecurrencePattern" xmlns:q113="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="RecurrenceDayPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Pattern" type="q114:RecurrenceDailyPattern" xmlns:q114="http://www.superoffice.net/ws/crm/NetServer/Services75" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceDayPattern" nillable="true" type="q115:RecurrenceDayPattern" xmlns:q115="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:simpleType name="RecurrenceDailyPattern">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="EveryWorkday" />
          <xs:enumeration value="EveryWeekday" />
          <xs:enumeration value="EveryCyclicDay" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrenceDailyPattern" nillable="true" type="q116:RecurrenceDailyPattern" xmlns:q116="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="RecurrenceWeekPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Weekdays" type="q117:Weekday" xmlns:q117="http://www.superoffice.net/ws/crm/NetServer/Services75" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceWeekPattern" nillable="true" type="q118:RecurrenceWeekPattern" xmlns:q118="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="Weekday" nillable="true" type="q119:Weekday" xmlns:q119="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="RecurrenceMonthPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Day" type="xs:int" />
          <xs:element minOccurs="0" name="Weekday" type="q120:Weekday" xmlns:q120="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          <xs:element minOccurs="0" name="WeekOfMonth" type="q121:WeekOfMonth" xmlns:q121="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          <xs:element minOccurs="0" name="Pattern" type="q122:RecurrenceMonthlyPattern" xmlns:q122="http://www.superoffice.net/ws/crm/NetServer/Services75" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceMonthPattern" nillable="true" type="q123:RecurrenceMonthPattern" xmlns:q123="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="WeekOfMonth" nillable="true" type="q124:WeekOfMonth" xmlns:q124="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="RecurrenceMonthlyPattern" nillable="true" type="q125:RecurrenceMonthlyPattern" xmlns:q125="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="RecurrenceYearPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Day" type="xs:int" />
          <xs:element minOccurs="0" name="Weekday" type="q126:Weekday" xmlns:q126="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          <xs:element minOccurs="0" name="WeekOfMonth" type="q127:WeekOfMonth" xmlns:q127="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          <xs:element minOccurs="0" name="Pattern" type="q128:RecurrenceYearlyPattern" xmlns:q128="http://www.superoffice.net/ws/crm/NetServer/Services75" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceYearPattern" nillable="true" type="q129:RecurrenceYearPattern" xmlns:q129="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="RecurrenceYearlyPattern" nillable="true" type="q130:RecurrenceYearlyPattern" xmlns:q130="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="ArrayOfRecurrenceDate">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="RecurrenceDate" nillable="true" type="q131:RecurrenceDate" xmlns:q131="http://www.superoffice.net/ws/crm/NetServer/Services75" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfRecurrenceDate" nillable="true" type="q132:ArrayOfRecurrenceDate" xmlns:q132="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="RecurrenceDate">
        <xs:sequence>
          <xs:element minOccurs="0" name="Date" type="xs:dateTime" />
          <xs:element minOccurs="0" name="IsConflict" type="xs:boolean" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DescriptionStyleHint" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceDate" nillable="true" type="q133:RecurrenceDate" xmlns:q133="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="ArrayOfParticipantInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ParticipantInfo" nillable="true" type="q134:ParticipantInfo" xmlns:q134="http://www.superoffice.net/ws/crm/NetServer/Services75" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfParticipantInfo" nillable="true" type="q135:ArrayOfParticipantInfo" xmlns:q135="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="ParticipantInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          <xs:element minOccurs="0" name="EmailId" type="xs:int" />
          <xs:element minOccurs="0" name="SendEmail" type="xs:boolean" />
          <xs:element minOccurs="0" name="InvitationStatus" type="q136:InvitationStatus" xmlns:q136="http://www.superoffice.net/ws/crm/NetServer/Services75" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ParticipantInfo" nillable="true" type="q137:ParticipantInfo" xmlns:q137="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="InvitationStatus" nillable="true" type="q138:InvitationStatus" xmlns:q138="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="AssignmentStatus" nillable="true" type="q139:AssignmentStatus" xmlns:q139="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:simpleType name="BookingType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="None" />
          <xs:enumeration value="Owner" />
          <xs:enumeration value="Participant" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="BookingType" nillable="true" type="q140:BookingType" xmlns:q140="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="TaskListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q141:Carrier" xmlns:q141="http://www.superoffice.net/ws/crm/NetServer/Services75">
            <xs:sequence>
              <xs:element minOccurs="0" name="TaskListItemId" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Direction" type="q141:TaskDirection" />
              <xs:element minOccurs="0" name="Type" type="q141:TaskType" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="IntentId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="IsDefaultAlldayEvent" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsDefaultFree" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsDefaultPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="ColorIndex" type="q141:ColorIndex" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TaskListItem" nillable="true" type="q142:TaskListItem" xmlns:q142="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="TaskDirection" nillable="true" type="q143:TaskDirection" xmlns:q143="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="TaskType" nillable="true" type="q144:TaskType" xmlns:q144="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="ColorIndex" nillable="true" type="q145:ColorIndex" xmlns:q145="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="Sale">
        <xs:complexContent mixed="false">
          <xs:extension base="q146:Carrier" xmlns:q146="http://www.superoffice.net/ws/crm/NetServer/Services75">
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
              <xs:element minOccurs="0" name="Status" type="q146:SaleStatus" />
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
              <xs:element minOccurs="0" name="Completed" type="q146:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Sale" nillable="true" type="q147:Sale" xmlns:q147="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="SaleStatus" nillable="true" type="q148:SaleStatus" xmlns:q148="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="StringDictionary" nillable="true" type="q149:StringDictionary" xmlns:q149="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:element name="GenerateFollowUpsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ExportSelectionMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="TemplateName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="UseContacts" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExportSelectionMembersResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="StartMailMerge">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Settings" nillable="true" type="q150:MailMergeSettings" xmlns:q150="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="StartMailMergeResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDuplicateRulesStatus">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Rules" nillable="true" type="q151:ArrayOfDuplicateRule" xmlns:q151="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDuplicateRule">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DuplicateRule" nillable="true" type="q152:DuplicateRule" xmlns:q152="http://www.superoffice.net/ws/crm/NetServer/Services75" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDuplicateRule" nillable="true" type="q153:ArrayOfDuplicateRule" xmlns:q153="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="DuplicateRule">
        <xs:complexContent mixed="false">
          <xs:extension base="q154:Carrier" xmlns:q154="http://www.superoffice.net/ws/crm/NetServer/Services75">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayTooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DuplicateRule" nillable="true" type="q155:DuplicateRule" xmlns:q155="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:element name="SetDuplicateRulesStatusResponse">
        <xs:complexType>
          <xs:sequence />
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
            <xs:element minOccurs="0" name="Response" nillable="true" type="q156:ArrayOfDuplicateEntry" xmlns:q156="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDuplicateEntry">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DuplicateEntry" nillable="true" type="q157:DuplicateEntry" xmlns:q157="http://www.superoffice.net/ws/crm/NetServer/Services75" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDuplicateEntry" nillable="true" type="q158:ArrayOfDuplicateEntry" xmlns:q158="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:complexType name="DuplicateEntry">
        <xs:complexContent mixed="false">
          <xs:extension base="q159:Carrier" xmlns:q159="http://www.superoffice.net/ws/crm/NetServer/Services75">
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
      <xs:element name="DuplicateEntry" nillable="true" type="q160:DuplicateEntry" xmlns:q160="http://www.superoffice.net/ws/crm/NetServer/Services75" />
      <xs:element name="GetDuplicateRules">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDuplicateRulesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q161:ArrayOfDuplicateRule" xmlns:q161="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateNewEntry">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Duplicate" nillable="true" type="q162:DuplicateEntry" xmlns:q162="http://www.superoffice.net/ws/crm/NetServer/Services75" />
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
      <xs:element name="DeleteContacts">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteContactsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="AddSelectionMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="Ids" nillable="true" type="q163:ArrayOfint" xmlns:q163="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddSelectionMembersResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveSelectionMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="Ids" nillable="true" type="q164:ArrayOfint" xmlns:q164="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveSelectionMembersResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="AddSelectionMembersFromSearch">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddSelectionMembersFromSearchResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveSelectionMembersFromSearch">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveSelectionMembersFromSearchResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopySelectionMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FromSelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ToSelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopySelectionMembersResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTemporarySelectionFromIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Ids" nillable="true" type="q165:ArrayOfint" xmlns:q165="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="TargetTableNumber" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTemporarySelectionFromIdsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q166:SelectionEntity" xmlns:q166="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateSelectionFromSelection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TargetSelectionType" type="q167:SelectionType" xmlns:q167="http://www.superoffice.net/ws/crm/NetServer/Services75" />
            <xs:element minOccurs="0" name="CopyMembers" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateSelectionFromSelectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q168:SelectionEntity" xmlns:q168="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateContactSelectionFromShadowSelection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateContactSelectionFromShadowSelectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q169:SelectionEntity" xmlns:q169="http://www.superoffice.net/ws/crm/NetServer/Services75" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteEntities">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteEntitiesResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetParentCombinedSelections">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetParentCombinedSelectionsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q170:ArrayOfint" xmlns:q170="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
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
  <wsdl:message name="CreateDefaultMailMergeSettingsRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultMailMergeSettings" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultMailMergeSettingsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultMailMergeSettingsResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultMailMergeSettingsResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultMailMergeSettingsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultMailMergeTaskRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultMailMergeTask" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultMailMergeTaskRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultMailMergeTaskResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultMailMergeTaskResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultMailMergeTaskResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSelectionEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultSelectionEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSelectionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSelectionEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultSelectionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSelectionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSelectionEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveSelectionEntity" />
  </wsdl:message>
  <wsdl:message name="SaveSelectionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSelectionEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveSelectionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveSelectionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteSelectionEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteSelectionEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteSelectionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteSelectionEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteSelectionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteSelectionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectionEntityRequest">
    <wsdl:part name="parameters" element="tns:GetSelectionEntity" />
  </wsdl:message>
  <wsdl:message name="GetSelectionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectionEntityResponse">
    <wsdl:part name="parameters" element="tns:GetSelectionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetSelectionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateContactSelectionFromSelectionRequest">
    <wsdl:part name="parameters" element="tns:CreateContactSelectionFromSelection" />
  </wsdl:message>
  <wsdl:message name="CreateContactSelectionFromSelectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateContactSelectionFromSelectionResponse">
    <wsdl:part name="parameters" element="tns:CreateContactSelectionFromSelectionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateContactSelectionFromSelectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromContactPersonIdsRequest">
    <wsdl:part name="parameters" element="tns:CreateTemporaryContactSelectionFromContactPersonIds" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromContactPersonIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromContactPersonIdsResponse">
    <wsdl:part name="parameters" element="tns:CreateTemporaryContactSelectionFromContactPersonIdsResponse" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromContactPersonIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromProjectMembersRequest">
    <wsdl:part name="parameters" element="tns:CreateTemporaryContactSelectionFromProjectMembers" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromProjectMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromProjectMembersResponse">
    <wsdl:part name="parameters" element="tns:CreateTemporaryContactSelectionFromProjectMembersResponse" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromProjectMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopyContactSelectionMembersRequest">
    <wsdl:part name="parameters" element="tns:CopyContactSelectionMembers" />
  </wsdl:message>
  <wsdl:message name="CopyContactSelectionMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopyContactSelectionMembersResponse">
    <wsdl:part name="parameters" element="tns:CopyContactSelectionMembersResponse" />
  </wsdl:message>
  <wsdl:message name="CopyContactSelectionMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsRequest">
    <wsdl:part name="parameters" element="tns:GetRecipientStatistics" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsResponse">
    <wsdl:part name="parameters" element="tns:GetRecipientStatisticsResponse" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsFromProjectMembersRequest">
    <wsdl:part name="parameters" element="tns:GetRecipientStatisticsFromProjectMembers" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsFromProjectMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsFromProjectMembersResponse">
    <wsdl:part name="parameters" element="tns:GetRecipientStatisticsFromProjectMembersResponse" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsFromProjectMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsFromContactPersonIdsRequest">
    <wsdl:part name="parameters" element="tns:GetRecipientStatisticsFromContactPersonIds" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsFromContactPersonIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsFromContactPersonIdsResponse">
    <wsdl:part name="parameters" element="tns:GetRecipientStatisticsFromContactPersonIdsResponse" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsFromContactPersonIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddContactSelectionMembersRequest">
    <wsdl:part name="parameters" element="tns:AddContactSelectionMembers" />
  </wsdl:message>
  <wsdl:message name="AddContactSelectionMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddContactSelectionMembersResponse">
    <wsdl:part name="parameters" element="tns:AddContactSelectionMembersResponse" />
  </wsdl:message>
  <wsdl:message name="AddContactSelectionMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersRequest">
    <wsdl:part name="parameters" element="tns:RemoveContactSelectionMembers" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersResponse">
    <wsdl:part name="parameters" element="tns:RemoveContactSelectionMembersResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersFromIdsRequest">
    <wsdl:part name="parameters" element="tns:RemoveContactSelectionMembersFromIds" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersFromIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersFromIdsResponse">
    <wsdl:part name="parameters" element="tns:RemoveContactSelectionMembersFromIdsResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersFromIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddContactSelectionMembersFromSearchRequest">
    <wsdl:part name="parameters" element="tns:AddContactSelectionMembersFromSearch" />
  </wsdl:message>
  <wsdl:message name="AddContactSelectionMembersFromSearchRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddContactSelectionMembersFromSearchResponse">
    <wsdl:part name="parameters" element="tns:AddContactSelectionMembersFromSearchResponse" />
  </wsdl:message>
  <wsdl:message name="AddContactSelectionMembersFromSearchResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersFromSearchRequest">
    <wsdl:part name="parameters" element="tns:RemoveContactSelectionMembersFromSearch" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersFromSearchRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersFromSearchResponse">
    <wsdl:part name="parameters" element="tns:RemoveContactSelectionMembersFromSearchResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersFromSearchResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionRequest">
    <wsdl:part name="parameters" element="tns:CreateTemporaryContactSelection" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionResponse">
    <wsdl:part name="parameters" element="tns:CreateTemporaryContactSelectionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromSelectionMemberIdsRequest">
    <wsdl:part name="parameters" element="tns:CreateTemporaryContactSelectionFromSelectionMemberIds" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromSelectionMemberIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromSelectionMemberIdsResponse">
    <wsdl:part name="parameters" element="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsResponse" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromSelectionMemberIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddRemoveContactSelectionMemberInterestsRequest">
    <wsdl:part name="parameters" element="tns:AddRemoveContactSelectionMemberInterests" />
  </wsdl:message>
  <wsdl:message name="AddRemoveContactSelectionMemberInterestsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddRemoveContactSelectionMemberInterestsResponse">
    <wsdl:part name="parameters" element="tns:AddRemoveContactSelectionMemberInterestsResponse" />
  </wsdl:message>
  <wsdl:message name="AddRemoveContactSelectionMemberInterestsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="EditContactSelectionMemberDetailsRequest">
    <wsdl:part name="parameters" element="tns:EditContactSelectionMemberDetails" />
  </wsdl:message>
  <wsdl:message name="EditContactSelectionMemberDetailsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="EditContactSelectionMemberDetailsResponse">
    <wsdl:part name="parameters" element="tns:EditContactSelectionMemberDetailsResponse" />
  </wsdl:message>
  <wsdl:message name="EditContactSelectionMemberDetailsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GenerateFollowUpsRequest">
    <wsdl:part name="parameters" element="tns:GenerateFollowUps" />
  </wsdl:message>
  <wsdl:message name="GenerateFollowUpsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GenerateFollowUpsResponse">
    <wsdl:part name="parameters" element="tns:GenerateFollowUpsResponse" />
  </wsdl:message>
  <wsdl:message name="GenerateFollowUpsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExportSelectionMembersRequest">
    <wsdl:part name="parameters" element="tns:ExportSelectionMembers" />
  </wsdl:message>
  <wsdl:message name="ExportSelectionMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExportSelectionMembersResponse">
    <wsdl:part name="parameters" element="tns:ExportSelectionMembersResponse" />
  </wsdl:message>
  <wsdl:message name="ExportSelectionMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="StartMailMergeRequest">
    <wsdl:part name="parameters" element="tns:StartMailMerge" />
  </wsdl:message>
  <wsdl:message name="StartMailMergeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="StartMailMergeResponse">
    <wsdl:part name="parameters" element="tns:StartMailMergeResponse" />
  </wsdl:message>
  <wsdl:message name="StartMailMergeResponse_Headers">
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
  <wsdl:message name="DeleteContactsRequest">
    <wsdl:part name="parameters" element="tns:DeleteContacts" />
  </wsdl:message>
  <wsdl:message name="DeleteContactsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteContactsResponse">
    <wsdl:part name="parameters" element="tns:DeleteContactsResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteContactsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddSelectionMembersRequest">
    <wsdl:part name="parameters" element="tns:AddSelectionMembers" />
  </wsdl:message>
  <wsdl:message name="AddSelectionMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddSelectionMembersResponse">
    <wsdl:part name="parameters" element="tns:AddSelectionMembersResponse" />
  </wsdl:message>
  <wsdl:message name="AddSelectionMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersRequest">
    <wsdl:part name="parameters" element="tns:RemoveSelectionMembers" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersResponse">
    <wsdl:part name="parameters" element="tns:RemoveSelectionMembersResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddSelectionMembersFromSearchRequest">
    <wsdl:part name="parameters" element="tns:AddSelectionMembersFromSearch" />
  </wsdl:message>
  <wsdl:message name="AddSelectionMembersFromSearchRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddSelectionMembersFromSearchResponse">
    <wsdl:part name="parameters" element="tns:AddSelectionMembersFromSearchResponse" />
  </wsdl:message>
  <wsdl:message name="AddSelectionMembersFromSearchResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersFromSearchRequest">
    <wsdl:part name="parameters" element="tns:RemoveSelectionMembersFromSearch" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersFromSearchRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersFromSearchResponse">
    <wsdl:part name="parameters" element="tns:RemoveSelectionMembersFromSearchResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersFromSearchResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopySelectionMembersRequest">
    <wsdl:part name="parameters" element="tns:CopySelectionMembers" />
  </wsdl:message>
  <wsdl:message name="CopySelectionMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopySelectionMembersResponse">
    <wsdl:part name="parameters" element="tns:CopySelectionMembersResponse" />
  </wsdl:message>
  <wsdl:message name="CopySelectionMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporarySelectionFromIdsRequest">
    <wsdl:part name="parameters" element="tns:CreateTemporarySelectionFromIds" />
  </wsdl:message>
  <wsdl:message name="CreateTemporarySelectionFromIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporarySelectionFromIdsResponse">
    <wsdl:part name="parameters" element="tns:CreateTemporarySelectionFromIdsResponse" />
  </wsdl:message>
  <wsdl:message name="CreateTemporarySelectionFromIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateSelectionFromSelectionRequest">
    <wsdl:part name="parameters" element="tns:CreateSelectionFromSelection" />
  </wsdl:message>
  <wsdl:message name="CreateSelectionFromSelectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateSelectionFromSelectionResponse">
    <wsdl:part name="parameters" element="tns:CreateSelectionFromSelectionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateSelectionFromSelectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateContactSelectionFromShadowSelectionRequest">
    <wsdl:part name="parameters" element="tns:CreateContactSelectionFromShadowSelection" />
  </wsdl:message>
  <wsdl:message name="CreateContactSelectionFromShadowSelectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateContactSelectionFromShadowSelectionResponse">
    <wsdl:part name="parameters" element="tns:CreateContactSelectionFromShadowSelectionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateContactSelectionFromShadowSelectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteEntitiesRequest">
    <wsdl:part name="parameters" element="tns:DeleteEntities" />
  </wsdl:message>
  <wsdl:message name="DeleteEntitiesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteEntitiesResponse">
    <wsdl:part name="parameters" element="tns:DeleteEntitiesResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteEntitiesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetParentCombinedSelectionsRequest">
    <wsdl:part name="parameters" element="tns:GetParentCombinedSelections" />
  </wsdl:message>
  <wsdl:message name="GetParentCombinedSelectionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetParentCombinedSelectionsResponse">
    <wsdl:part name="parameters" element="tns:GetParentCombinedSelectionsResponse" />
  </wsdl:message>
  <wsdl:message name="GetParentCombinedSelectionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Selection">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Selection</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultMailMergeSettings">
      <wsdl:documentation>
        <summary>Loading default values into a new MailMergeSettings.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateDefaultMailMergeSettings" name="CreateDefaultMailMergeSettingsRequest" message="tns:CreateDefaultMailMergeSettingsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateDefaultMailMergeSettingsResponse" name="CreateDefaultMailMergeSettingsResponse" message="tns:CreateDefaultMailMergeSettingsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultMailMergeTask">
      <wsdl:documentation>
        <summary>Loading default values into a new MailMergeTask.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateDefaultMailMergeTask" name="CreateDefaultMailMergeTaskRequest" message="tns:CreateDefaultMailMergeTaskRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateDefaultMailMergeTaskResponse" name="CreateDefaultMailMergeTaskResponse" message="tns:CreateDefaultMailMergeTaskResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultSelectionEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new SelectionEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateDefaultSelectionEntity" name="CreateDefaultSelectionEntityRequest" message="tns:CreateDefaultSelectionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateDefaultSelectionEntityResponse" name="CreateDefaultSelectionEntityResponse" message="tns:CreateDefaultSelectionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveSelectionEntity">
      <wsdl:documentation>
        <summary>Updates the existing SelectionEntity or creates a new SelectionEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/SaveSelectionEntity" name="SaveSelectionEntityRequest" message="tns:SaveSelectionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/SaveSelectionEntityResponse" name="SaveSelectionEntityResponse" message="tns:SaveSelectionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteSelectionEntity">
      <wsdl:documentation>
        <summary>Deletes the SelectionEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/DeleteSelectionEntity" name="DeleteSelectionEntityRequest" message="tns:DeleteSelectionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/DeleteSelectionEntityResponse" name="DeleteSelectionEntityResponse" message="tns:DeleteSelectionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSelectionEntity">
      <wsdl:documentation>
        <summary>Gets a SelectionEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetSelectionEntity" name="GetSelectionEntityRequest" message="tns:GetSelectionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetSelectionEntityResponse" name="GetSelectionEntityResponse" message="tns:GetSelectionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateContactSelectionFromSelection">
      <wsdl:documentation>
        <summary>Creates a new selection based on selection members from an existing selection.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateContactSelectionFromSelection" name="CreateContactSelectionFromSelectionRequest" message="tns:CreateContactSelectionFromSelectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateContactSelectionFromSelectionResponse" name="CreateContactSelectionFromSelectionResponse" message="tns:CreateContactSelectionFromSelectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateTemporaryContactSelectionFromContactPersonIds">
      <wsdl:documentation>
        <summary>Creates a temporary selection with members from a collection of ContactPerson id's.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateTemporaryContactSelectionFromContactPersonIds" name="CreateTemporaryContactSelectionFromContactPersonIdsRequest" message="tns:CreateTemporaryContactSelectionFromContactPersonIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateTemporaryContactSelectionFromContactPersonIdsResponse" name="CreateTemporaryContactSelectionFromContactPersonIdsResponse" message="tns:CreateTemporaryContactSelectionFromContactPersonIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateTemporaryContactSelectionFromProjectMembers">
      <wsdl:documentation>
        <summary>Creates a temporary selection with members from an existing project.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateTemporaryContactSelectionFromProjectMembers" name="CreateTemporaryContactSelectionFromProjectMembersRequest" message="tns:CreateTemporaryContactSelectionFromProjectMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateTemporaryContactSelectionFromProjectMembersResponse" name="CreateTemporaryContactSelectionFromProjectMembersResponse" message="tns:CreateTemporaryContactSelectionFromProjectMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="CopyContactSelectionMembers">
      <wsdl:documentation>
        <summary>Copy contact selection members from selection into an existing selection.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CopyContactSelectionMembers" name="CopyContactSelectionMembersRequest" message="tns:CopyContactSelectionMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CopyContactSelectionMembersResponse" name="CopyContactSelectionMembersResponse" message="tns:CopyContactSelectionMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetRecipientStatistics">
      <wsdl:documentation>
        <summary>Returns a RecipientStatistics object with a count of addresses, emailaddresses and emailaddresses.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetRecipientStatistics" name="GetRecipientStatisticsRequest" message="tns:GetRecipientStatisticsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetRecipientStatisticsResponse" name="GetRecipientStatisticsResponse" message="tns:GetRecipientStatisticsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetRecipientStatisticsFromProjectMembers">
      <wsdl:documentation>
        <summary>Returns a RecipientStatistics object with a count of addresses, emailaddresses and emailaddresses based on members in a project.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetRecipientStatisticsFromProjectMembers" name="GetRecipientStatisticsFromProjectMembersRequest" message="tns:GetRecipientStatisticsFromProjectMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetRecipientStatisticsFromProjectMembersResponse" name="GetRecipientStatisticsFromProjectMembersResponse" message="tns:GetRecipientStatisticsFromProjectMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetRecipientStatisticsFromContactPersonIds">
      <wsdl:documentation>
        <summary>Returns a RecipientStatistics object with a count of addresses, emailaddresses and emailaddresses based on contact and persons in a collection of ContactPersonId.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetRecipientStatisticsFromContactPersonIds" name="GetRecipientStatisticsFromContactPersonIdsRequest" message="tns:GetRecipientStatisticsFromContactPersonIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetRecipientStatisticsFromContactPersonIdsResponse" name="GetRecipientStatisticsFromContactPersonIdsResponse" message="tns:GetRecipientStatisticsFromContactPersonIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddContactSelectionMembers">
      <wsdl:documentation>
        <summary>Adds members to the selection as  specified in the collection of ContactPersonId.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/AddContactSelectionMembers" name="AddContactSelectionMembersRequest" message="tns:AddContactSelectionMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/AddContactSelectionMembersResponse" name="AddContactSelectionMembersResponse" message="tns:AddContactSelectionMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveContactSelectionMembers">
      <wsdl:documentation>
        <summary>Removes members from the selection as  specified in the collection of ContactPersonId.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/RemoveContactSelectionMembers" name="RemoveContactSelectionMembersRequest" message="tns:RemoveContactSelectionMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/RemoveContactSelectionMembersResponse" name="RemoveContactSelectionMembersResponse" message="tns:RemoveContactSelectionMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveContactSelectionMembersFromIds">
      <wsdl:documentation>
        <summary>Removes members from the selection using a collection a selectionmember id's. Members can only be removed from single selection.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/RemoveContactSelectionMembersFromIds" name="RemoveContactSelectionMembersFromIdsRequest" message="tns:RemoveContactSelectionMembersFromIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/RemoveContactSelectionMembersFromIdsResponse" name="RemoveContactSelectionMembersFromIdsResponse" message="tns:RemoveContactSelectionMembersFromIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddContactSelectionMembersFromSearch">
      <wsdl:documentation>
        <summary>Adds members to the selection from the search result.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/AddContactSelectionMembersFromSearch" name="AddContactSelectionMembersFromSearchRequest" message="tns:AddContactSelectionMembersFromSearchRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/AddContactSelectionMembersFromSearchResponse" name="AddContactSelectionMembersFromSearchResponse" message="tns:AddContactSelectionMembersFromSearchResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveContactSelectionMembersFromSearch">
      <wsdl:documentation>
        <summary>Removes members from the selection using the search result.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/RemoveContactSelectionMembersFromSearch" name="RemoveContactSelectionMembersFromSearchRequest" message="tns:RemoveContactSelectionMembersFromSearchRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/RemoveContactSelectionMembersFromSearchResponse" name="RemoveContactSelectionMembersFromSearchResponse" message="tns:RemoveContactSelectionMembersFromSearchResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateTemporaryContactSelection">
      <wsdl:documentation>
        <summary>Creates a temporary selection.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateTemporaryContactSelection" name="CreateTemporaryContactSelectionRequest" message="tns:CreateTemporaryContactSelectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateTemporaryContactSelectionResponse" name="CreateTemporaryContactSelectionResponse" message="tns:CreateTemporaryContactSelectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateTemporaryContactSelectionFromSelectionMemberIds">
      <wsdl:documentation>
        <summary>Creates a temporary selection with members from a collection of selectionmember id's.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateTemporaryContactSelectionFromSelectionMemberIds" name="CreateTemporaryContactSelectionFromSelectionMemberIdsRequest" message="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateTemporaryContactSelectionFromSelectionMemberIdsResponse" name="CreateTemporaryContactSelectionFromSelectionMemberIdsResponse" message="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddRemoveContactSelectionMemberInterests">
      <wsdl:documentation>
        <summary>Adds or removes interests on companies and persons in a selection.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/AddRemoveContactSelectionMemberInterests" name="AddRemoveContactSelectionMemberInterestsRequest" message="tns:AddRemoveContactSelectionMemberInterestsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/AddRemoveContactSelectionMemberInterestsResponse" name="AddRemoveContactSelectionMemberInterestsResponse" message="tns:AddRemoveContactSelectionMemberInterestsResponse" />
    </wsdl:operation>
    <wsdl:operation name="EditContactSelectionMemberDetails">
      <wsdl:documentation>
        <summary>Edit company and contact details in a selection based on contents in selectionMemberEditValues.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/EditContactSelectionMemberDetails" name="EditContactSelectionMemberDetailsRequest" message="tns:EditContactSelectionMemberDetailsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/EditContactSelectionMemberDetailsResponse" name="EditContactSelectionMemberDetailsResponse" message="tns:EditContactSelectionMemberDetailsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GenerateFollowUps">
      <wsdl:documentation>
        <summary>Generate follow-ups for members in the selection.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GenerateFollowUps" name="GenerateFollowUpsRequest" message="tns:GenerateFollowUpsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GenerateFollowUpsResponse" name="GenerateFollowUpsResponse" message="tns:GenerateFollowUpsResponse" />
    </wsdl:operation>
    <wsdl:operation name="ExportSelectionMembers">
      <wsdl:documentation>
        <summary>ExportSelectionMembers will generate a string that is the result of substituting the template variables with values from selectionmembers.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/ExportSelectionMembers" name="ExportSelectionMembersRequest" message="tns:ExportSelectionMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/ExportSelectionMembersResponse" name="ExportSelectionMembersResponse" message="tns:ExportSelectionMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="StartMailMerge">
      <wsdl:documentation>
        <summary>Start a mailmerge operation with specified settings.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/StartMailMerge" name="StartMailMergeRequest" message="tns:StartMailMergeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/StartMailMergeResponse" name="StartMailMergeResponse" message="tns:StartMailMergeResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetDuplicateRulesStatus">
      <wsdl:documentation>
        <summary>Set which duplicate rules should be active or not</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/SetDuplicateRulesStatus" name="SetDuplicateRulesStatusRequest" message="tns:SetDuplicateRulesStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/SetDuplicateRulesStatusResponse" name="SetDuplicateRulesStatusResponse" message="tns:SetDuplicateRulesStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDuplicates">
      <wsdl:documentation>
        <summary>Get duplicates(exact or similar in the database) based on the name</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetDuplicates" name="GetDuplicatesRequest" message="tns:GetDuplicatesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetDuplicatesResponse" name="GetDuplicatesResponse" message="tns:GetDuplicatesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDuplicateRules">
      <wsdl:documentation>
        <summary>Retrieve all available duplicate rules for selection</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetDuplicateRules" name="GetDuplicateRulesRequest" message="tns:GetDuplicateRulesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetDuplicateRulesResponse" name="GetDuplicateRulesResponse" message="tns:GetDuplicateRulesResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateNewEntry">
      <wsdl:documentation>
        <summary>Creates a new selection based on external duplicate</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateNewEntry" name="CreateNewEntryRequest" message="tns:CreateNewEntryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateNewEntryResponse" name="CreateNewEntryResponse" message="tns:CreateNewEntryResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteContacts">
      <wsdl:documentation>
        <summary>Deletes all contacts from a selection. If a contact does not have delete rights, it will be skipped.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/DeleteContacts" name="DeleteContactsRequest" message="tns:DeleteContactsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/DeleteContactsResponse" name="DeleteContactsResponse" message="tns:DeleteContactsResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddSelectionMembers">
      <wsdl:documentation>
        <summary>Add selection members to a static selection of type others than contacts.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/AddSelectionMembers" name="AddSelectionMembersRequest" message="tns:AddSelectionMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/AddSelectionMembersResponse" name="AddSelectionMembersResponse" message="tns:AddSelectionMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveSelectionMembers">
      <wsdl:documentation>
        <summary>Removes members from the selection as  specified in the collection of entity ids. The ids can be a collection of sale ids, or other supported types.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/RemoveSelectionMembers" name="RemoveSelectionMembersRequest" message="tns:RemoveSelectionMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/RemoveSelectionMembersResponse" name="RemoveSelectionMembersResponse" message="tns:RemoveSelectionMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddSelectionMembersFromSearch">
      <wsdl:documentation>
        <summary>Removes members from the selection using the search result.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/AddSelectionMembersFromSearch" name="AddSelectionMembersFromSearchRequest" message="tns:AddSelectionMembersFromSearchRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/AddSelectionMembersFromSearchResponse" name="AddSelectionMembersFromSearchResponse" message="tns:AddSelectionMembersFromSearchResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveSelectionMembersFromSearch">
      <wsdl:documentation>
        <summary>Removes members from the selection using the search result.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/RemoveSelectionMembersFromSearch" name="RemoveSelectionMembersFromSearchRequest" message="tns:RemoveSelectionMembersFromSearchRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/RemoveSelectionMembersFromSearchResponse" name="RemoveSelectionMembersFromSearchResponse" message="tns:RemoveSelectionMembersFromSearchResponse" />
    </wsdl:operation>
    <wsdl:operation name="CopySelectionMembers">
      <wsdl:documentation>
        <summary>Copy selection members from selection into an existing selection.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CopySelectionMembers" name="CopySelectionMembersRequest" message="tns:CopySelectionMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CopySelectionMembersResponse" name="CopySelectionMembersResponse" message="tns:CopySelectionMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateTemporarySelectionFromIds">
      <wsdl:documentation>
        <summary>Creates a temporary selection with members from a collection of entity id's.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateTemporarySelectionFromIds" name="CreateTemporarySelectionFromIdsRequest" message="tns:CreateTemporarySelectionFromIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateTemporarySelectionFromIdsResponse" name="CreateTemporarySelectionFromIdsResponse" message="tns:CreateTemporarySelectionFromIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateSelectionFromSelection">
      <wsdl:documentation>
        <summary>Creates a new selection based on selection members from an existing selection.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateSelectionFromSelection" name="CreateSelectionFromSelectionRequest" message="tns:CreateSelectionFromSelectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateSelectionFromSelectionResponse" name="CreateSelectionFromSelectionResponse" message="tns:CreateSelectionFromSelectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateContactSelectionFromShadowSelection">
      <wsdl:documentation>
        <summary>Creates a new contact selection based on contact selection members from an existing shadow sale, appointment, project or document selection. The new selection will always be static even if the original selection is dynamic.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateContactSelectionFromShadowSelection" name="CreateContactSelectionFromShadowSelectionRequest" message="tns:CreateContactSelectionFromShadowSelectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateContactSelectionFromShadowSelectionResponse" name="CreateContactSelectionFromShadowSelectionResponse" message="tns:CreateContactSelectionFromShadowSelectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteEntities">
      <wsdl:documentation>
        <summary>Deletes all entities from a selection. If an entity does not have delete rights, it will be skipped.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/DeleteEntities" name="DeleteEntitiesRequest" message="tns:DeleteEntitiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/DeleteEntitiesResponse" name="DeleteEntitiesResponse" message="tns:DeleteEntitiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetParentCombinedSelections">
      <wsdl:documentation>
        <summary>Get a list of all selection ids where the given selection is used to create a combined selection.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetParentCombinedSelections" name="GetParentCombinedSelectionsRequest" message="tns:GetParentCombinedSelectionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetParentCombinedSelectionsResponse" name="GetParentCombinedSelectionsResponse" message="tns:GetParentCombinedSelectionsResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Selection" type="tns:Selection">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultMailMergeSettings">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateDefaultMailMergeSettings" style="document" />
      <wsdl:input name="CreateDefaultMailMergeSettingsRequest">
        <soap:header message="tns:CreateDefaultMailMergeSettingsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultMailMergeSettingsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultMailMergeSettingsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultMailMergeSettingsResponse">
        <soap:header message="tns:CreateDefaultMailMergeSettingsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultMailMergeSettingsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultMailMergeSettingsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultMailMergeSettingsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultMailMergeTask">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateDefaultMailMergeTask" style="document" />
      <wsdl:input name="CreateDefaultMailMergeTaskRequest">
        <soap:header message="tns:CreateDefaultMailMergeTaskRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultMailMergeTaskRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultMailMergeTaskRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultMailMergeTaskResponse">
        <soap:header message="tns:CreateDefaultMailMergeTaskResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultMailMergeTaskResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultMailMergeTaskResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultMailMergeTaskResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultSelectionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateDefaultSelectionEntity" style="document" />
      <wsdl:input name="CreateDefaultSelectionEntityRequest">
        <soap:header message="tns:CreateDefaultSelectionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultSelectionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultSelectionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultSelectionEntityResponse">
        <soap:header message="tns:CreateDefaultSelectionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSelectionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSelectionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultSelectionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveSelectionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/SaveSelectionEntity" style="document" />
      <wsdl:input name="SaveSelectionEntityRequest">
        <soap:header message="tns:SaveSelectionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveSelectionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveSelectionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveSelectionEntityResponse">
        <soap:header message="tns:SaveSelectionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveSelectionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveSelectionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveSelectionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteSelectionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/DeleteSelectionEntity" style="document" />
      <wsdl:input name="DeleteSelectionEntityRequest">
        <soap:header message="tns:DeleteSelectionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteSelectionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteSelectionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteSelectionEntityResponse">
        <soap:header message="tns:DeleteSelectionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteSelectionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteSelectionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteSelectionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSelectionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetSelectionEntity" style="document" />
      <wsdl:input name="GetSelectionEntityRequest">
        <soap:header message="tns:GetSelectionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSelectionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSelectionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSelectionEntityResponse">
        <soap:header message="tns:GetSelectionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSelectionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSelectionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSelectionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateContactSelectionFromSelection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateContactSelectionFromSelection" style="document" />
      <wsdl:input name="CreateContactSelectionFromSelectionRequest">
        <soap:header message="tns:CreateContactSelectionFromSelectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromSelectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromSelectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateContactSelectionFromSelectionResponse">
        <soap:header message="tns:CreateContactSelectionFromSelectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromSelectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromSelectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromSelectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateTemporaryContactSelectionFromContactPersonIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateTemporaryContactSelectionFromContactPersonIds" style="document" />
      <wsdl:input name="CreateTemporaryContactSelectionFromContactPersonIdsRequest">
        <soap:header message="tns:CreateTemporaryContactSelectionFromContactPersonIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromContactPersonIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromContactPersonIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateTemporaryContactSelectionFromContactPersonIdsResponse">
        <soap:header message="tns:CreateTemporaryContactSelectionFromContactPersonIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromContactPersonIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromContactPersonIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromContactPersonIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateTemporaryContactSelectionFromProjectMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateTemporaryContactSelectionFromProjectMembers" style="document" />
      <wsdl:input name="CreateTemporaryContactSelectionFromProjectMembersRequest">
        <soap:header message="tns:CreateTemporaryContactSelectionFromProjectMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromProjectMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromProjectMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateTemporaryContactSelectionFromProjectMembersResponse">
        <soap:header message="tns:CreateTemporaryContactSelectionFromProjectMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromProjectMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromProjectMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromProjectMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CopyContactSelectionMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CopyContactSelectionMembers" style="document" />
      <wsdl:input name="CopyContactSelectionMembersRequest">
        <soap:header message="tns:CopyContactSelectionMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CopyContactSelectionMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CopyContactSelectionMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CopyContactSelectionMembersResponse">
        <soap:header message="tns:CopyContactSelectionMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CopyContactSelectionMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CopyContactSelectionMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CopyContactSelectionMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetRecipientStatistics">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetRecipientStatistics" style="document" />
      <wsdl:input name="GetRecipientStatisticsRequest">
        <soap:header message="tns:GetRecipientStatisticsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetRecipientStatisticsResponse">
        <soap:header message="tns:GetRecipientStatisticsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetRecipientStatisticsFromProjectMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetRecipientStatisticsFromProjectMembers" style="document" />
      <wsdl:input name="GetRecipientStatisticsFromProjectMembersRequest">
        <soap:header message="tns:GetRecipientStatisticsFromProjectMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromProjectMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromProjectMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetRecipientStatisticsFromProjectMembersResponse">
        <soap:header message="tns:GetRecipientStatisticsFromProjectMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromProjectMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromProjectMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromProjectMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetRecipientStatisticsFromContactPersonIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetRecipientStatisticsFromContactPersonIds" style="document" />
      <wsdl:input name="GetRecipientStatisticsFromContactPersonIdsRequest">
        <soap:header message="tns:GetRecipientStatisticsFromContactPersonIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromContactPersonIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromContactPersonIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetRecipientStatisticsFromContactPersonIdsResponse">
        <soap:header message="tns:GetRecipientStatisticsFromContactPersonIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromContactPersonIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromContactPersonIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromContactPersonIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddContactSelectionMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/AddContactSelectionMembers" style="document" />
      <wsdl:input name="AddContactSelectionMembersRequest">
        <soap:header message="tns:AddContactSelectionMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddContactSelectionMembersResponse">
        <soap:header message="tns:AddContactSelectionMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveContactSelectionMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/RemoveContactSelectionMembers" style="document" />
      <wsdl:input name="RemoveContactSelectionMembersRequest">
        <soap:header message="tns:RemoveContactSelectionMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveContactSelectionMembersResponse">
        <soap:header message="tns:RemoveContactSelectionMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveContactSelectionMembersFromIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/RemoveContactSelectionMembersFromIds" style="document" />
      <wsdl:input name="RemoveContactSelectionMembersFromIdsRequest">
        <soap:header message="tns:RemoveContactSelectionMembersFromIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveContactSelectionMembersFromIdsResponse">
        <soap:header message="tns:RemoveContactSelectionMembersFromIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddContactSelectionMembersFromSearch">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/AddContactSelectionMembersFromSearch" style="document" />
      <wsdl:input name="AddContactSelectionMembersFromSearchRequest">
        <soap:header message="tns:AddContactSelectionMembersFromSearchRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersFromSearchRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersFromSearchRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddContactSelectionMembersFromSearchResponse">
        <soap:header message="tns:AddContactSelectionMembersFromSearchResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersFromSearchResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersFromSearchResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersFromSearchResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveContactSelectionMembersFromSearch">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/RemoveContactSelectionMembersFromSearch" style="document" />
      <wsdl:input name="RemoveContactSelectionMembersFromSearchRequest">
        <soap:header message="tns:RemoveContactSelectionMembersFromSearchRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromSearchRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromSearchRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveContactSelectionMembersFromSearchResponse">
        <soap:header message="tns:RemoveContactSelectionMembersFromSearchResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromSearchResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromSearchResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromSearchResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateTemporaryContactSelection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateTemporaryContactSelection" style="document" />
      <wsdl:input name="CreateTemporaryContactSelectionRequest">
        <soap:header message="tns:CreateTemporaryContactSelectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateTemporaryContactSelectionResponse">
        <soap:header message="tns:CreateTemporaryContactSelectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateTemporaryContactSelectionFromSelectionMemberIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateTemporaryContactSelectionFromSelectionMemberIds" style="document" />
      <wsdl:input name="CreateTemporaryContactSelectionFromSelectionMemberIdsRequest">
        <soap:header message="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateTemporaryContactSelectionFromSelectionMemberIdsResponse">
        <soap:header message="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddRemoveContactSelectionMemberInterests">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/AddRemoveContactSelectionMemberInterests" style="document" />
      <wsdl:input name="AddRemoveContactSelectionMemberInterestsRequest">
        <soap:header message="tns:AddRemoveContactSelectionMemberInterestsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddRemoveContactSelectionMemberInterestsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddRemoveContactSelectionMemberInterestsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddRemoveContactSelectionMemberInterestsResponse">
        <soap:header message="tns:AddRemoveContactSelectionMemberInterestsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddRemoveContactSelectionMemberInterestsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddRemoveContactSelectionMemberInterestsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddRemoveContactSelectionMemberInterestsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="EditContactSelectionMemberDetails">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/EditContactSelectionMemberDetails" style="document" />
      <wsdl:input name="EditContactSelectionMemberDetailsRequest">
        <soap:header message="tns:EditContactSelectionMemberDetailsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:EditContactSelectionMemberDetailsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:EditContactSelectionMemberDetailsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="EditContactSelectionMemberDetailsResponse">
        <soap:header message="tns:EditContactSelectionMemberDetailsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:EditContactSelectionMemberDetailsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:EditContactSelectionMemberDetailsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:EditContactSelectionMemberDetailsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GenerateFollowUps">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GenerateFollowUps" style="document" />
      <wsdl:input name="GenerateFollowUpsRequest">
        <soap:header message="tns:GenerateFollowUpsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GenerateFollowUpsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GenerateFollowUpsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GenerateFollowUpsResponse">
        <soap:header message="tns:GenerateFollowUpsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GenerateFollowUpsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GenerateFollowUpsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GenerateFollowUpsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ExportSelectionMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/ExportSelectionMembers" style="document" />
      <wsdl:input name="ExportSelectionMembersRequest">
        <soap:header message="tns:ExportSelectionMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ExportSelectionMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ExportSelectionMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ExportSelectionMembersResponse">
        <soap:header message="tns:ExportSelectionMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ExportSelectionMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ExportSelectionMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ExportSelectionMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="StartMailMerge">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/StartMailMerge" style="document" />
      <wsdl:input name="StartMailMergeRequest">
        <soap:header message="tns:StartMailMergeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:StartMailMergeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:StartMailMergeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="StartMailMergeResponse">
        <soap:header message="tns:StartMailMergeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:StartMailMergeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:StartMailMergeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:StartMailMergeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetDuplicateRulesStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/SetDuplicateRulesStatus" style="document" />
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
    <wsdl:operation name="GetDuplicates">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetDuplicates" style="document" />
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
    <wsdl:operation name="GetDuplicateRules">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetDuplicateRules" style="document" />
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
    <wsdl:operation name="CreateNewEntry">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateNewEntry" style="document" />
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
    <wsdl:operation name="DeleteContacts">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/DeleteContacts" style="document" />
      <wsdl:input name="DeleteContactsRequest">
        <soap:header message="tns:DeleteContactsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteContactsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteContactsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteContactsResponse">
        <soap:header message="tns:DeleteContactsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteContactsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteContactsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteContactsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddSelectionMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/AddSelectionMembers" style="document" />
      <wsdl:input name="AddSelectionMembersRequest">
        <soap:header message="tns:AddSelectionMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddSelectionMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddSelectionMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddSelectionMembersResponse">
        <soap:header message="tns:AddSelectionMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddSelectionMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddSelectionMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddSelectionMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveSelectionMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/RemoveSelectionMembers" style="document" />
      <wsdl:input name="RemoveSelectionMembersRequest">
        <soap:header message="tns:RemoveSelectionMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveSelectionMembersResponse">
        <soap:header message="tns:RemoveSelectionMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddSelectionMembersFromSearch">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/AddSelectionMembersFromSearch" style="document" />
      <wsdl:input name="AddSelectionMembersFromSearchRequest">
        <soap:header message="tns:AddSelectionMembersFromSearchRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddSelectionMembersFromSearchRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddSelectionMembersFromSearchRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddSelectionMembersFromSearchResponse">
        <soap:header message="tns:AddSelectionMembersFromSearchResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddSelectionMembersFromSearchResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddSelectionMembersFromSearchResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddSelectionMembersFromSearchResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveSelectionMembersFromSearch">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/RemoveSelectionMembersFromSearch" style="document" />
      <wsdl:input name="RemoveSelectionMembersFromSearchRequest">
        <soap:header message="tns:RemoveSelectionMembersFromSearchRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersFromSearchRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersFromSearchRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveSelectionMembersFromSearchResponse">
        <soap:header message="tns:RemoveSelectionMembersFromSearchResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersFromSearchResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersFromSearchResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersFromSearchResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CopySelectionMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CopySelectionMembers" style="document" />
      <wsdl:input name="CopySelectionMembersRequest">
        <soap:header message="tns:CopySelectionMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CopySelectionMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CopySelectionMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CopySelectionMembersResponse">
        <soap:header message="tns:CopySelectionMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CopySelectionMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CopySelectionMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CopySelectionMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateTemporarySelectionFromIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateTemporarySelectionFromIds" style="document" />
      <wsdl:input name="CreateTemporarySelectionFromIdsRequest">
        <soap:header message="tns:CreateTemporarySelectionFromIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateTemporarySelectionFromIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateTemporarySelectionFromIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateTemporarySelectionFromIdsResponse">
        <soap:header message="tns:CreateTemporarySelectionFromIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateTemporarySelectionFromIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateTemporarySelectionFromIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateTemporarySelectionFromIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateSelectionFromSelection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateSelectionFromSelection" style="document" />
      <wsdl:input name="CreateSelectionFromSelectionRequest">
        <soap:header message="tns:CreateSelectionFromSelectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateSelectionFromSelectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateSelectionFromSelectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateSelectionFromSelectionResponse">
        <soap:header message="tns:CreateSelectionFromSelectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateSelectionFromSelectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateSelectionFromSelectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateSelectionFromSelectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateContactSelectionFromShadowSelection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/CreateContactSelectionFromShadowSelection" style="document" />
      <wsdl:input name="CreateContactSelectionFromShadowSelectionRequest">
        <soap:header message="tns:CreateContactSelectionFromShadowSelectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromShadowSelectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromShadowSelectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateContactSelectionFromShadowSelectionResponse">
        <soap:header message="tns:CreateContactSelectionFromShadowSelectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromShadowSelectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromShadowSelectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromShadowSelectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteEntities">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/DeleteEntities" style="document" />
      <wsdl:input name="DeleteEntitiesRequest">
        <soap:header message="tns:DeleteEntitiesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteEntitiesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteEntitiesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteEntitiesResponse">
        <soap:header message="tns:DeleteEntitiesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteEntitiesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteEntitiesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteEntitiesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetParentCombinedSelections">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/Selection/GetParentCombinedSelections" style="document" />
      <wsdl:input name="GetParentCombinedSelectionsRequest">
        <soap:header message="tns:GetParentCombinedSelectionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetParentCombinedSelectionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetParentCombinedSelectionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetParentCombinedSelectionsResponse">
        <soap:header message="tns:GetParentCombinedSelectionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetParentCombinedSelectionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetParentCombinedSelectionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetParentCombinedSelectionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfSelectionService">
    <wsdl:port name="BasicHttpBinding_Selection" binding="tns:BasicHttpBinding_Selection">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services75/Selection.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

