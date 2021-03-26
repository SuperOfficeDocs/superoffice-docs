---
Generated: 1
TOCExclude: 1
title: Services80.ProjectAgent WSDL
---

# Services80.ProjectAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfProjectService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services80" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services80" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services80" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:ser="http://schemas.microsoft.com/2003/10/Serialization/">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:element name="CreateDefaultProjectEntity">
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
      <xs:element name="SoCredentials" nillable="true" type="q1:SoCredentials" xmlns:q1="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:element name="Credentials" nillable="true" type="q2:SoCredentials" xmlns:q2="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="SoTimeZone">
        <xs:sequence>
          <xs:element minOccurs="0" name="SoTimeZoneId" type="xs:int" />
          <xs:element minOccurs="0" name="SoTimeZoneLocationCode" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoTimeZone" nillable="true" type="q3:SoTimeZone" xmlns:q3="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:element name="TimeZone" nillable="true" type="q4:SoTimeZone" xmlns:q4="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:element name="CreateDefaultProjectEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q5:ProjectEntity" xmlns:q5="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ProjectEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q6:Carrier" xmlns:q6="http://www.superoffice.net/ws/crm/NetServer/Services80">
            <xs:sequence>
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjectNumber" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjectMembers" nillable="true" type="q6:ArrayOfProjectMember" />
              <xs:element minOccurs="0" name="Urls" nillable="true" type="q6:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Postit" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="q6:Associate" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="q6:Associate" />
              <xs:element minOccurs="0" name="Associate" nillable="true" type="q6:Associate" />
              <xs:element minOccurs="0" name="ProjectStatus" nillable="true" type="q6:ProjectStatus" />
              <xs:element minOccurs="0" name="ProjectType" nillable="true" type="q6:ProjectType" />
              <xs:element minOccurs="0" name="HasImage" type="xs:boolean" />
              <xs:element minOccurs="0" name="ImageDescription" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ActiveStatusMonitorId" type="xs:int" />
              <xs:element minOccurs="0" name="Links" nillable="true" type="q6:ArrayOfLink" />
              <xs:element minOccurs="0" name="ActiveLinks" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="Completed" type="xs:boolean" />
              <xs:element minOccurs="0" name="NextMilestoneDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="NmdAppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="UserDefinedFields" nillable="true" type="q6:StringDictionary" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="q6:StringDictionary" />
              <xs:element minOccurs="0" name="PublishEventDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishTo" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishFrom" type="xs:dateTime" />
              <xs:element minOccurs="0" name="IsPublished" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ProjectEntity" nillable="true" type="q7:ProjectEntity" xmlns:q7="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="Carrier">
        <xs:sequence>
          <xs:element minOccurs="0" name="TableRight" nillable="true" type="q8:TableRight" xmlns:q8="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          <xs:element minOccurs="0" name="FieldProperties" nillable="true" type="q9:FieldPropertyDictionary" xmlns:q9="http://www.superoffice.net/ws/crm/NetServer/Services80" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="Carrier" nillable="true" type="q10:Carrier" xmlns:q10="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="TableRight">
        <xs:sequence>
          <xs:element minOccurs="0" name="Mask" type="q11:ETableRight" xmlns:q11="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TableRight" nillable="true" type="q12:TableRight" xmlns:q12="http://www.superoffice.net/ws/crm/NetServer/Services80" />
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
      <xs:element name="ETableRight" nillable="true" type="q13:ETableRight" xmlns:q13="http://www.superoffice.net/ws/crm/NetServer/Services80" />
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
                <xs:element name="Value" nillable="true" type="q14:FieldProperty" xmlns:q14="http://www.superoffice.net/ws/crm/NetServer/Services80" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldPropertyDictionary" nillable="true" type="q15:FieldPropertyDictionary" xmlns:q15="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="FieldProperty">
        <xs:sequence>
          <xs:element minOccurs="0" name="FieldRight" nillable="true" type="q16:FieldRight" xmlns:q16="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          <xs:element minOccurs="0" name="FieldType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FieldLength" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldProperty" nillable="true" type="q17:FieldProperty" xmlns:q17="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="FieldRight">
        <xs:sequence>
          <xs:element minOccurs="0" name="Mask" type="q18:EFieldRight" xmlns:q18="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldRight" nillable="true" type="q19:FieldRight" xmlns:q19="http://www.superoffice.net/ws/crm/NetServer/Services80" />
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
      <xs:element name="EFieldRight" nillable="true" type="q20:EFieldRight" xmlns:q20="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="ArrayOfProjectMember">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ProjectMember" nillable="true" type="q21:ProjectMember" xmlns:q21="http://www.superoffice.net/ws/crm/NetServer/Services80" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfProjectMember" nillable="true" type="q22:ArrayOfProjectMember" xmlns:q22="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="ProjectMember">
        <xs:complexContent mixed="false">
          <xs:extension base="q23:Carrier" xmlns:q23="http://www.superoffice.net/ws/crm/NetServer/Services80">
            <xs:sequence>
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EmailId" type="xs:int" />
              <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CountryId" type="xs:int" />
              <xs:element minOccurs="0" name="Firstname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MiddleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Lastname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Mrmrs" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjectMemberTypeName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Phone" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PhoneId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjectMemberTypeId" type="xs:int" />
              <xs:element minOccurs="0" name="EmailAddressName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Comment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjectmemberId" type="xs:int" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ProjectMember" nillable="true" type="q24:ProjectMember" xmlns:q24="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="ArrayOfEntityElement">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="EntityElement" nillable="true" type="q25:EntityElement" xmlns:q25="http://www.superoffice.net/ws/crm/NetServer/Services80" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfEntityElement" nillable="true" type="q26:ArrayOfEntityElement" xmlns:q26="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="EntityElement">
        <xs:complexContent mixed="false">
          <xs:extension base="q27:Carrier" xmlns:q27="http://www.superoffice.net/ws/crm/NetServer/Services80">
            <xs:sequence>
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StrippedValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EntityElement" nillable="true" type="q28:EntityElement" xmlns:q28="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="Associate">
        <xs:complexContent mixed="false">
          <xs:extension base="q29:Carrier" xmlns:q29="http://www.superoffice.net/ws/crm/NetServer/Services80">
            <xs:sequence>
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Type" type="q29:UserType" />
              <xs:element minOccurs="0" name="GroupIdx" type="xs:int" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="EjUserId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Associate" nillable="true" type="q30:Associate" xmlns:q30="http://www.superoffice.net/ws/crm/NetServer/Services80" />
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
      <xs:element name="UserType" nillable="true" type="q31:UserType" xmlns:q31="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="ProjectStatus">
        <xs:complexContent mixed="false">
          <xs:extension base="q32:Carrier" xmlns:q32="http://www.superoffice.net/ws/crm/NetServer/Services80">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ProjectStatus" nillable="true" type="q33:ProjectStatus" xmlns:q33="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="ProjectType">
        <xs:complexContent mixed="false">
          <xs:extension base="q34:Carrier" xmlns:q34="http://www.superoffice.net/ws/crm/NetServer/Services80">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ProjectType" nillable="true" type="q35:ProjectType" xmlns:q35="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="ArrayOfLink">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Link" nillable="true" type="q36:Link" xmlns:q36="http://www.superoffice.net/ws/crm/NetServer/Services80" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLink" nillable="true" type="q37:ArrayOfLink" xmlns:q37="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="Link">
        <xs:complexContent mixed="false">
          <xs:extension base="q38:Carrier" xmlns:q38="http://www.superoffice.net/ws/crm/NetServer/Services80">
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
      <xs:element name="Link" nillable="true" type="q39:Link" xmlns:q39="http://www.superoffice.net/ws/crm/NetServer/Services80" />
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
      <xs:element name="StringDictionary" nillable="true" type="q40:StringDictionary" xmlns:q40="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="SoExceptionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="StackTrace" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FriendlyText" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ExceptionType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="InnerException" nillable="true" type="q41:SoExceptionInfo" xmlns:q41="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          <xs:element minOccurs="0" name="Parameters" nillable="true" type="q42:SoExceptionInfoParameters" xmlns:q42="http://www.superoffice.net/ws/crm/NetServer/Services80" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExceptionInfo" nillable="true" type="q43:SoExceptionInfo" xmlns:q43="http://www.superoffice.net/ws/crm/NetServer/Services80" />
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
      <xs:element name="SoExceptionInfoParameters" nillable="true" type="q44:SoExceptionInfoParameters" xmlns:q44="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:element name="ExceptionInfo" nillable="true" type="q45:SoExceptionInfo" xmlns:q45="http://www.superoffice.net/ws/crm/NetServer/Services80" />
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
      <xs:element name="SoExtraInfo" nillable="true" type="q46:SoExtraInfo" xmlns:q46="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:element name="ExtraInfo" nillable="true" type="q47:SoExtraInfo" xmlns:q47="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:element name="Succeeded" type="xs:boolean" />
      <xs:element name="SaveProjectEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectEntity" nillable="true" type="q48:ProjectEntity" xmlns:q48="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveProjectEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q49:ProjectEntity" xmlns:q49="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteProjectEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteProjectEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultProjectEventEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultProjectEventEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q50:ProjectEventEntity" xmlns:q50="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ProjectEventEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q51:Carrier" xmlns:q51="http://www.superoffice.net/ws/crm/NetServer/Services80">
            <xs:sequence>
              <xs:element minOccurs="0" name="SignOffConfirmationText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SignOffText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SignOnConfirmationText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SignOnText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EventDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Enabled" type="xs:boolean" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="SignOff" type="xs:boolean" />
              <xs:element minOccurs="0" name="SignOffTaskEnable" type="xs:boolean" />
              <xs:element minOccurs="0" name="SignOffTaskId" type="xs:int" />
              <xs:element minOccurs="0" name="SignOffTriggersAssign" type="xs:boolean" />
              <xs:element minOccurs="0" name="SignOn" type="xs:boolean" />
              <xs:element minOccurs="0" name="SignOnTaskEnable" type="xs:boolean" />
              <xs:element minOccurs="0" name="SignOnTaskId" type="xs:int" />
              <xs:element minOccurs="0" name="SignOnTriggersAssign" type="xs:boolean" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="q51:Associate" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="q51:Associate" />
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="PublishFrom" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishType" type="q51:PublishType" />
              <xs:element minOccurs="0" name="PublishTo" type="xs:dateTime" />
              <xs:element minOccurs="0" name="VisibleForCategories" nillable="true" type="q51:ArrayOfMDOListItem" />
              <xs:element minOccurs="0" name="VisibleForPersonInterests" nillable="true" type="q51:ArrayOfMDOListItem" />
              <xs:element minOccurs="0" name="IsPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsVisibleForMembers" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsVisibleForCategories" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsVisibleForPersonInterests" type="xs:boolean" />
              <xs:element minOccurs="0" name="ProjectEventId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ProjectEventEntity" nillable="true" type="q52:ProjectEventEntity" xmlns:q52="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:simpleType name="PublishType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Undefined" />
          <xs:enumeration value="External" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="PublishType" nillable="true" type="q53:PublishType" xmlns:q53="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="ArrayOfMDOListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="MDOListItem" nillable="true" type="q54:MDOListItem" xmlns:q54="http://www.superoffice.net/ws/crm/NetServer/Services80" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfMDOListItem" nillable="true" type="q55:ArrayOfMDOListItem" xmlns:q55="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="MDOListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q56:Carrier" xmlns:q56="http://www.superoffice.net/ws/crm/NetServer/Services80">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ToolTip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ChildItems" nillable="true" type="q56:ArrayOfMDOListItem" />
              <xs:element minOccurs="0" name="IconHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ColorBlock" type="xs:int" />
              <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StyleHint" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="MDOListItem" nillable="true" type="q57:MDOListItem" xmlns:q57="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:element name="SaveProjectEventEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectEventEntity" nillable="true" type="q58:ProjectEventEntity" xmlns:q58="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveProjectEventEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q59:ProjectEventEntity" xmlns:q59="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteProjectEventEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectEventEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteProjectEventEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProject">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q60:Project" xmlns:q60="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Project">
        <xs:complexContent mixed="false">
          <xs:extension base="q61:Carrier" xmlns:q61="http://www.superoffice.net/ws/crm/NetServer/Services80">
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
      <xs:element name="Project" nillable="true" type="q62:Project" xmlns:q62="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:element name="GetProjectEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q63:ProjectEntity" xmlns:q63="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddProjectMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectEntityId" type="xs:int" />
            <xs:element minOccurs="0" name="ProjectMembers" nillable="true" type="q64:ArrayOfProjectMember" xmlns:q64="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddProjectMembersResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteProjectMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectEntityId" type="xs:int" />
            <xs:element minOccurs="0" name="MemberIds" nillable="true" type="q65:ArrayOfint" xmlns:q65="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteProjectMembersResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectImageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetProjectImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="Image" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetProjectImageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteProjectMemberByIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectMemberIds" nillable="true" type="q66:ArrayOfint" xmlns:q66="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteProjectMemberByIdsResponse">
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
            <xs:element minOccurs="0" name="Response" nillable="true" type="q67:ArrayOfDuplicateEntry" xmlns:q67="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDuplicateEntry">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DuplicateEntry" nillable="true" type="q68:DuplicateEntry" xmlns:q68="http://www.superoffice.net/ws/crm/NetServer/Services80" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDuplicateEntry" nillable="true" type="q69:ArrayOfDuplicateEntry" xmlns:q69="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="DuplicateEntry">
        <xs:complexContent mixed="false">
          <xs:extension base="q70:Carrier" xmlns:q70="http://www.superoffice.net/ws/crm/NetServer/Services80">
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
      <xs:element name="DuplicateEntry" nillable="true" type="q71:DuplicateEntry" xmlns:q71="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:element name="CreateNewEntry">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Duplicate" nillable="true" type="q72:DuplicateEntry" xmlns:q72="http://www.superoffice.net/ws/crm/NetServer/Services80" />
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
      <xs:element name="SetDuplicateRulesStatus">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Rules" nillable="true" type="q73:ArrayOfDuplicateRule" xmlns:q73="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDuplicateRule">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DuplicateRule" nillable="true" type="q74:DuplicateRule" xmlns:q74="http://www.superoffice.net/ws/crm/NetServer/Services80" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDuplicateRule" nillable="true" type="q75:ArrayOfDuplicateRule" xmlns:q75="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:complexType name="DuplicateRule">
        <xs:complexContent mixed="false">
          <xs:extension base="q76:Carrier" xmlns:q76="http://www.superoffice.net/ws/crm/NetServer/Services80">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayTooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DuplicateRule" nillable="true" type="q77:DuplicateRule" xmlns:q77="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:element name="SetDuplicateRulesStatusResponse">
        <xs:complexType>
          <xs:sequence />
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
            <xs:element minOccurs="0" name="Response" nillable="true" type="q78:ArrayOfDuplicateRule" xmlns:q78="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Merge">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SourceProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="DestinationProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="ReplaceEmptyFieldsOnDestination" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MergeResponse">
        <xs:complexType>
          <xs:sequence />
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
      <xs:element name="HasGuide">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
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
      <xs:element name="GetNextMilestone">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNextMilestoneResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q79:Appointment" xmlns:q79="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Appointment">
        <xs:complexContent mixed="false">
          <xs:extension base="q80:Carrier" xmlns:q80="http://www.superoffice.net/ws/crm/NetServer/Services80">
            <xs:sequence>
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Type" type="q80:AppointmentType" />
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
              <xs:element minOccurs="0" name="Private" type="q80:AppointmentPrivate" />
              <xs:element minOccurs="0" name="PriorityId" type="xs:int" />
              <xs:element minOccurs="0" name="PriorityName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TaskType" type="q80:TaskType" />
              <xs:element minOccurs="0" name="IsBookingMain" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsRecurrence" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsBooking" type="xs:boolean" />
              <xs:element minOccurs="0" name="ActiveDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AssignmentStatus" type="q80:AssignmentStatus" />
              <xs:element minOccurs="0" name="InvitationStatus" type="q80:InvitationStatus" />
              <xs:element minOccurs="0" name="BookingType" type="q80:BookingType" />
              <xs:element minOccurs="0" name="Completed" type="q80:ActivityStatus" />
              <xs:element minOccurs="0" name="RecurringPattern" type="q80:RecurrencePattern" />
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
      <xs:element name="Appointment" nillable="true" type="q81:Appointment" xmlns:q81="http://www.superoffice.net/ws/crm/NetServer/Services80" />
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
      <xs:element name="AppointmentType" nillable="true" type="q82:AppointmentType" xmlns:q82="http://www.superoffice.net/ws/crm/NetServer/Services80" />
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
      <xs:element name="AppointmentPrivate" nillable="true" type="q83:AppointmentPrivate" xmlns:q83="http://www.superoffice.net/ws/crm/NetServer/Services80" />
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
      <xs:element name="TaskType" nillable="true" type="q84:TaskType" xmlns:q84="http://www.superoffice.net/ws/crm/NetServer/Services80" />
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
      <xs:element name="AssignmentStatus" nillable="true" type="q85:AssignmentStatus" xmlns:q85="http://www.superoffice.net/ws/crm/NetServer/Services80" />
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
      <xs:element name="InvitationStatus" nillable="true" type="q86:InvitationStatus" xmlns:q86="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:simpleType name="BookingType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="None" />
          <xs:enumeration value="Owner" />
          <xs:enumeration value="Participant" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="BookingType" nillable="true" type="q87:BookingType" xmlns:q87="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:simpleType name="ActivityStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="NotStarted" />
          <xs:enumeration value="Started" />
          <xs:enumeration value="Completed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ActivityStatus" nillable="true" type="q88:ActivityStatus" xmlns:q88="http://www.superoffice.net/ws/crm/NetServer/Services80" />
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
      <xs:element name="RecurrencePattern" nillable="true" type="q89:RecurrencePattern" xmlns:q89="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:element name="OfferAutoNextStatusOnApppointmentCompleted">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="OfferAutoNextStatusOnApppointmentCompletedResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNextProjectStatus">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNextProjectStatusResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="HasGuideActivities">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
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
      <xs:element name="GetProjectEvent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectEventId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectEventResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q90:ProjectEvent" xmlns:q90="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ProjectEvent">
        <xs:complexContent mixed="false">
          <xs:extension base="q91:Carrier" xmlns:q91="http://www.superoffice.net/ws/crm/NetServer/Services80">
            <xs:sequence>
              <xs:element minOccurs="0" name="AssociateFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="EventName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="IsSignedOn" type="xs:boolean" />
              <xs:element minOccurs="0" name="SignOffConfirmationText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SignOffText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SignOnConfirmationText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SignOnText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EventDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Enabled" type="xs:boolean" />
              <xs:element minOccurs="0" name="SignOff" type="xs:boolean" />
              <xs:element minOccurs="0" name="SignOffTaskEnable" type="xs:boolean" />
              <xs:element minOccurs="0" name="SignOnTaskEnable" type="xs:boolean" />
              <xs:element minOccurs="0" name="SignOn" type="xs:boolean" />
              <xs:element minOccurs="0" name="SignOffTaskId" type="xs:int" />
              <xs:element minOccurs="0" name="SignOnTaskId" type="xs:int" />
              <xs:element minOccurs="0" name="SignOffTriggersAssign" type="xs:boolean" />
              <xs:element minOccurs="0" name="SignOnTriggersAssign" type="xs:boolean" />
              <xs:element minOccurs="0" name="SignOnPersonId" type="xs:int" />
              <xs:element minOccurs="0" name="SignOffPersonId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ProjectEvent" nillable="true" type="q92:ProjectEvent" xmlns:q92="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:element name="GetProjectEventOnPerson">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectEventOnPersonResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q93:ProjectEvent" xmlns:q93="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectEventEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectEventEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectEventEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q94:ProjectEventEntity" xmlns:q94="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectEventEntityFromProjectId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectEventEntityFromProjectIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q95:ProjectEventEntity" xmlns:q95="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteProjectEventEntityFromProjectId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteProjectEventEntityFromProjectIdResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectEventList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectEventIds" nillable="true" type="q96:ArrayOfint" xmlns:q96="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectEventListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q97:ArrayOfProjectEvent" xmlns:q97="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfProjectEvent">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ProjectEvent" nillable="true" type="q98:ProjectEvent" xmlns:q98="http://www.superoffice.net/ws/crm/NetServer/Services80" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfProjectEvent" nillable="true" type="q99:ArrayOfProjectEvent" xmlns:q99="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:element name="GetMyProjectEvents">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyProjectEventsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q100:ArrayOfProjectEvent" xmlns:q100="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectEventsOnPerson">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectEventsOnPersonResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q101:ArrayOfProjectEvent" xmlns:q101="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectIds" nillable="true" type="q102:ArrayOfint" xmlns:q102="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q103:ArrayOfProject" xmlns:q103="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfProject">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Project" nillable="true" type="q104:Project" xmlns:q104="http://www.superoffice.net/ws/crm/NetServer/Services80" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfProject" nillable="true" type="q105:ArrayOfProject" xmlns:q105="http://www.superoffice.net/ws/crm/NetServer/Services80" />
      <xs:element name="GetMyProjects">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="IncludeMemberProjects" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyProjectsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q106:ArrayOfProject" xmlns:q106="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyMemberProjects">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyMemberProjectsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q107:ArrayOfProject" xmlns:q107="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectsFromPerson">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectsFromPersonResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q108:ArrayOfProject" xmlns:q108="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectsFromContact">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectsFromContactResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q109:ArrayOfProject" xmlns:q109="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedProject">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedProjectResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q110:Project" xmlns:q110="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedProjects">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectIds" nillable="true" type="q111:ArrayOfint" xmlns:q111="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedProjectsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q112:ArrayOfProject" xmlns:q112="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyPublishedProjects">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyPublishedProjectsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q113:ArrayOfProject" xmlns:q113="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedProjectsOnPersonId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedProjectsOnPersonIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q114:ArrayOfProject" xmlns:q114="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMembersResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q115:ArrayOfProjectMember" xmlns:q115="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMember">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectMemberId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q116:ProjectMember" xmlns:q116="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateProjectMember">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectMember" nillable="true" type="q117:ProjectMember" xmlns:q117="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateProjectMemberResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q118:ProjectMember" xmlns:q118="http://www.superoffice.net/ws/crm/NetServer/Services80" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMembersById">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectMemberIds" nillable="true" type="q119:ArrayOfint" xmlns:q119="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMembersByIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q120:ArrayOfProjectMember" xmlns:q120="http://www.superoffice.net/ws/crm/NetServer/Services80" />
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
  <wsdl:message name="CreateDefaultProjectEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultProjectEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultProjectEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultProjectEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultProjectEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultProjectEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveProjectEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveProjectEntity" />
  </wsdl:message>
  <wsdl:message name="SaveProjectEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveProjectEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveProjectEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveProjectEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteProjectEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteProjectEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultProjectEventEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultProjectEventEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultProjectEventEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultProjectEventEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultProjectEventEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultProjectEventEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveProjectEventEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveProjectEventEntity" />
  </wsdl:message>
  <wsdl:message name="SaveProjectEventEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveProjectEventEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveProjectEventEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveProjectEventEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectEventEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteProjectEventEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectEventEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectEventEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteProjectEventEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectEventEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectRequest">
    <wsdl:part name="parameters" element="tns:GetProject" />
  </wsdl:message>
  <wsdl:message name="GetProjectRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectResponse">
    <wsdl:part name="parameters" element="tns:GetProjectResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectEntityRequest">
    <wsdl:part name="parameters" element="tns:GetProjectEntity" />
  </wsdl:message>
  <wsdl:message name="GetProjectEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectEntityResponse">
    <wsdl:part name="parameters" element="tns:GetProjectEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddProjectMembersRequest">
    <wsdl:part name="parameters" element="tns:AddProjectMembers" />
  </wsdl:message>
  <wsdl:message name="AddProjectMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddProjectMembersResponse">
    <wsdl:part name="parameters" element="tns:AddProjectMembersResponse" />
  </wsdl:message>
  <wsdl:message name="AddProjectMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectMembersRequest">
    <wsdl:part name="parameters" element="tns:DeleteProjectMembers" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectMembersResponse">
    <wsdl:part name="parameters" element="tns:DeleteProjectMembersResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectImageRequest">
    <wsdl:part name="parameters" element="tns:GetProjectImage" />
  </wsdl:message>
  <wsdl:message name="GetProjectImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectImageResponse">
    <wsdl:part name="parameters" element="tns:GetProjectImageResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetProjectImageRequest">
    <wsdl:part name="parameters" element="tns:SetProjectImage" />
  </wsdl:message>
  <wsdl:message name="SetProjectImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetProjectImageResponse">
    <wsdl:part name="parameters" element="tns:SetProjectImageResponse" />
  </wsdl:message>
  <wsdl:message name="SetProjectImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectMemberByIdsRequest">
    <wsdl:part name="parameters" element="tns:DeleteProjectMemberByIds" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectMemberByIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectMemberByIdsResponse">
    <wsdl:part name="parameters" element="tns:DeleteProjectMemberByIdsResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectMemberByIdsResponse_Headers">
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
  <wsdl:message name="GetNextMilestoneRequest">
    <wsdl:part name="parameters" element="tns:GetNextMilestone" />
  </wsdl:message>
  <wsdl:message name="GetNextMilestoneRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextMilestoneResponse">
    <wsdl:part name="parameters" element="tns:GetNextMilestoneResponse" />
  </wsdl:message>
  <wsdl:message name="GetNextMilestoneResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="OfferAutoNextStatusOnApppointmentCompletedRequest">
    <wsdl:part name="parameters" element="tns:OfferAutoNextStatusOnApppointmentCompleted" />
  </wsdl:message>
  <wsdl:message name="OfferAutoNextStatusOnApppointmentCompletedRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="OfferAutoNextStatusOnApppointmentCompletedResponse">
    <wsdl:part name="parameters" element="tns:OfferAutoNextStatusOnApppointmentCompletedResponse" />
  </wsdl:message>
  <wsdl:message name="OfferAutoNextStatusOnApppointmentCompletedResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextProjectStatusRequest">
    <wsdl:part name="parameters" element="tns:GetNextProjectStatus" />
  </wsdl:message>
  <wsdl:message name="GetNextProjectStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextProjectStatusResponse">
    <wsdl:part name="parameters" element="tns:GetNextProjectStatusResponse" />
  </wsdl:message>
  <wsdl:message name="GetNextProjectStatusResponse_Headers">
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
  <wsdl:message name="GetProjectEventRequest">
    <wsdl:part name="parameters" element="tns:GetProjectEvent" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventResponse">
    <wsdl:part name="parameters" element="tns:GetProjectEventResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventOnPersonRequest">
    <wsdl:part name="parameters" element="tns:GetProjectEventOnPerson" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventOnPersonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventOnPersonResponse">
    <wsdl:part name="parameters" element="tns:GetProjectEventOnPersonResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventOnPersonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventEntityRequest">
    <wsdl:part name="parameters" element="tns:GetProjectEventEntity" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventEntityResponse">
    <wsdl:part name="parameters" element="tns:GetProjectEventEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventEntityFromProjectIdRequest">
    <wsdl:part name="parameters" element="tns:GetProjectEventEntityFromProjectId" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventEntityFromProjectIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventEntityFromProjectIdResponse">
    <wsdl:part name="parameters" element="tns:GetProjectEventEntityFromProjectIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventEntityFromProjectIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectEventEntityFromProjectIdRequest">
    <wsdl:part name="parameters" element="tns:DeleteProjectEventEntityFromProjectId" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectEventEntityFromProjectIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectEventEntityFromProjectIdResponse">
    <wsdl:part name="parameters" element="tns:DeleteProjectEventEntityFromProjectIdResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteProjectEventEntityFromProjectIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventListRequest">
    <wsdl:part name="parameters" element="tns:GetProjectEventList" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventListResponse">
    <wsdl:part name="parameters" element="tns:GetProjectEventListResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyProjectEventsRequest">
    <wsdl:part name="parameters" element="tns:GetMyProjectEvents" />
  </wsdl:message>
  <wsdl:message name="GetMyProjectEventsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyProjectEventsResponse">
    <wsdl:part name="parameters" element="tns:GetMyProjectEventsResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyProjectEventsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventsOnPersonRequest">
    <wsdl:part name="parameters" element="tns:GetProjectEventsOnPerson" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventsOnPersonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventsOnPersonResponse">
    <wsdl:part name="parameters" element="tns:GetProjectEventsOnPersonResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectEventsOnPersonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectListRequest">
    <wsdl:part name="parameters" element="tns:GetProjectList" />
  </wsdl:message>
  <wsdl:message name="GetProjectListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectListResponse">
    <wsdl:part name="parameters" element="tns:GetProjectListResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyProjectsRequest">
    <wsdl:part name="parameters" element="tns:GetMyProjects" />
  </wsdl:message>
  <wsdl:message name="GetMyProjectsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyProjectsResponse">
    <wsdl:part name="parameters" element="tns:GetMyProjectsResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyProjectsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyMemberProjectsRequest">
    <wsdl:part name="parameters" element="tns:GetMyMemberProjects" />
  </wsdl:message>
  <wsdl:message name="GetMyMemberProjectsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyMemberProjectsResponse">
    <wsdl:part name="parameters" element="tns:GetMyMemberProjectsResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyMemberProjectsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectsFromPersonRequest">
    <wsdl:part name="parameters" element="tns:GetProjectsFromPerson" />
  </wsdl:message>
  <wsdl:message name="GetProjectsFromPersonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectsFromPersonResponse">
    <wsdl:part name="parameters" element="tns:GetProjectsFromPersonResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectsFromPersonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectsFromContactRequest">
    <wsdl:part name="parameters" element="tns:GetProjectsFromContact" />
  </wsdl:message>
  <wsdl:message name="GetProjectsFromContactRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectsFromContactResponse">
    <wsdl:part name="parameters" element="tns:GetProjectsFromContactResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectsFromContactResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectRequest">
    <wsdl:part name="parameters" element="tns:GetPublishedProject" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectResponse">
    <wsdl:part name="parameters" element="tns:GetPublishedProjectResponse" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectsRequest">
    <wsdl:part name="parameters" element="tns:GetPublishedProjects" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectsResponse">
    <wsdl:part name="parameters" element="tns:GetPublishedProjectsResponse" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyPublishedProjectsRequest">
    <wsdl:part name="parameters" element="tns:GetMyPublishedProjects" />
  </wsdl:message>
  <wsdl:message name="GetMyPublishedProjectsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyPublishedProjectsResponse">
    <wsdl:part name="parameters" element="tns:GetMyPublishedProjectsResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyPublishedProjectsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectsOnPersonIdRequest">
    <wsdl:part name="parameters" element="tns:GetPublishedProjectsOnPersonId" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectsOnPersonIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectsOnPersonIdResponse">
    <wsdl:part name="parameters" element="tns:GetPublishedProjectsOnPersonIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectsOnPersonIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMembersRequest">
    <wsdl:part name="parameters" element="tns:GetProjectMembers" />
  </wsdl:message>
  <wsdl:message name="GetProjectMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMembersResponse">
    <wsdl:part name="parameters" element="tns:GetProjectMembersResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberRequest">
    <wsdl:part name="parameters" element="tns:GetProjectMember" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberResponse">
    <wsdl:part name="parameters" element="tns:GetProjectMemberResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateProjectMemberRequest">
    <wsdl:part name="parameters" element="tns:UpdateProjectMember" />
  </wsdl:message>
  <wsdl:message name="UpdateProjectMemberRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateProjectMemberResponse">
    <wsdl:part name="parameters" element="tns:UpdateProjectMemberResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateProjectMemberResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMembersByIdRequest">
    <wsdl:part name="parameters" element="tns:GetProjectMembersById" />
  </wsdl:message>
  <wsdl:message name="GetProjectMembersByIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMembersByIdResponse">
    <wsdl:part name="parameters" element="tns:GetProjectMembersByIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectMembersByIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Project">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Project</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultProjectEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new ProjectEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/CreateDefaultProjectEntity" name="CreateDefaultProjectEntityRequest" message="tns:CreateDefaultProjectEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/CreateDefaultProjectEntityResponse" name="CreateDefaultProjectEntityResponse" message="tns:CreateDefaultProjectEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveProjectEntity">
      <wsdl:documentation>
        <summary>Updates the existing ProjectEntity or creates a new ProjectEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/SaveProjectEntity" name="SaveProjectEntityRequest" message="tns:SaveProjectEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/SaveProjectEntityResponse" name="SaveProjectEntityResponse" message="tns:SaveProjectEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteProjectEntity">
      <wsdl:documentation>
        <summary>Deletes the ProjectEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/DeleteProjectEntity" name="DeleteProjectEntityRequest" message="tns:DeleteProjectEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/DeleteProjectEntityResponse" name="DeleteProjectEntityResponse" message="tns:DeleteProjectEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultProjectEventEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new ProjectEventEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/CreateDefaultProjectEventEntity" name="CreateDefaultProjectEventEntityRequest" message="tns:CreateDefaultProjectEventEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/CreateDefaultProjectEventEntityResponse" name="CreateDefaultProjectEventEntityResponse" message="tns:CreateDefaultProjectEventEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveProjectEventEntity">
      <wsdl:documentation>
        <summary>Updates the existing ProjectEventEntity or creates a new ProjectEventEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/SaveProjectEventEntity" name="SaveProjectEventEntityRequest" message="tns:SaveProjectEventEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/SaveProjectEventEntityResponse" name="SaveProjectEventEntityResponse" message="tns:SaveProjectEventEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteProjectEventEntity">
      <wsdl:documentation>
        <summary>Deletes the ProjectEventEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/DeleteProjectEventEntity" name="DeleteProjectEventEntityRequest" message="tns:DeleteProjectEventEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/DeleteProjectEventEntityResponse" name="DeleteProjectEventEntityResponse" message="tns:DeleteProjectEventEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProject">
      <wsdl:documentation>
        <summary>Gets a Project object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProject" name="GetProjectRequest" message="tns:GetProjectRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectResponse" name="GetProjectResponse" message="tns:GetProjectResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectEntity">
      <wsdl:documentation>
        <summary>Gets a ProjectEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEntity" name="GetProjectEntityRequest" message="tns:GetProjectEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEntityResponse" name="GetProjectEntityResponse" message="tns:GetProjectEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddProjectMembers">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/AddProjectMembers" name="AddProjectMembersRequest" message="tns:AddProjectMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/AddProjectMembersResponse" name="AddProjectMembersResponse" message="tns:AddProjectMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteProjectMembers">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/DeleteProjectMembers" name="DeleteProjectMembersRequest" message="tns:DeleteProjectMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/DeleteProjectMembersResponse" name="DeleteProjectMembersResponse" message="tns:DeleteProjectMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectImage">
      <wsdl:documentation>
        <summary>Returns the project image that is displayed in the CRM application.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectImage" name="GetProjectImageRequest" message="tns:GetProjectImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectImageResponse" name="GetProjectImageResponse" message="tns:GetProjectImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetProjectImage">
      <wsdl:documentation>
        <summary>Stores the project image that is displayed in the CRM application.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/SetProjectImage" name="SetProjectImageRequest" message="tns:SetProjectImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/SetProjectImageResponse" name="SetProjectImageResponse" message="tns:SetProjectImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteProjectMemberByIds">
      <wsdl:documentation>
        <summary>Deletes projectmembers rows.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/DeleteProjectMemberByIds" name="DeleteProjectMemberByIdsRequest" message="tns:DeleteProjectMemberByIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/DeleteProjectMemberByIdsResponse" name="DeleteProjectMemberByIdsResponse" message="tns:DeleteProjectMemberByIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDuplicates">
      <wsdl:documentation>
        <summary>Get duplicates(exact or similar in the database) based on the name</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetDuplicates" name="GetDuplicatesRequest" message="tns:GetDuplicatesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetDuplicatesResponse" name="GetDuplicatesResponse" message="tns:GetDuplicatesResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateNewEntry">
      <wsdl:documentation>
        <summary>Creates a new project based on external duplicate</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/CreateNewEntry" name="CreateNewEntryRequest" message="tns:CreateNewEntryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/CreateNewEntryResponse" name="CreateNewEntryResponse" message="tns:CreateNewEntryResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetDuplicateRulesStatus">
      <wsdl:documentation>
        <summary>Set which duplicate rules should be active or not</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/SetDuplicateRulesStatus" name="SetDuplicateRulesStatusRequest" message="tns:SetDuplicateRulesStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/SetDuplicateRulesStatusResponse" name="SetDuplicateRulesStatusResponse" message="tns:SetDuplicateRulesStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDuplicateRules">
      <wsdl:documentation>
        <summary>Retrieve all available duplicate rules for project</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetDuplicateRules" name="GetDuplicateRulesRequest" message="tns:GetDuplicateRulesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetDuplicateRulesResponse" name="GetDuplicateRulesResponse" message="tns:GetDuplicateRulesResponse" />
    </wsdl:operation>
    <wsdl:operation name="Merge">
      <wsdl:documentation>
        <summary>Merge two projects</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/Merge" name="MergeRequest" message="tns:MergeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/MergeResponse" name="MergeResponse" message="tns:MergeResponse" />
    </wsdl:operation>
    <wsdl:operation name="IsNumberValid">
      <wsdl:documentation>
        <summary>Checks if the number is unique or required.  The setting is configured from admin under system options.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/IsNumberValid" name="IsNumberValidRequest" message="tns:IsNumberValidRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/IsNumberValidResponse" name="IsNumberValidResponse" message="tns:IsNumberValidResponse" />
    </wsdl:operation>
    <wsdl:operation name="HasGuide">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/HasGuide" name="HasGuideRequest" message="tns:HasGuideRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/HasGuideResponse" name="HasGuideResponse" message="tns:HasGuideResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNextMilestone">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetNextMilestone" name="GetNextMilestoneRequest" message="tns:GetNextMilestoneRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetNextMilestoneResponse" name="GetNextMilestoneResponse" message="tns:GetNextMilestoneResponse" />
    </wsdl:operation>
    <wsdl:operation name="OfferAutoNextStatusOnApppointmentCompleted">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/OfferAutoNextStatusOnApppointmentCompleted" name="OfferAutoNextStatusOnApppointmentCompletedRequest" message="tns:OfferAutoNextStatusOnApppointmentCompletedRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/OfferAutoNextStatusOnApppointmentCompletedResponse" name="OfferAutoNextStatusOnApppointmentCompletedResponse" message="tns:OfferAutoNextStatusOnApppointmentCompletedResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNextProjectStatus">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetNextProjectStatus" name="GetNextProjectStatusRequest" message="tns:GetNextProjectStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetNextProjectStatusResponse" name="GetNextProjectStatusResponse" message="tns:GetNextProjectStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="HasGuideActivities">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/HasGuideActivities" name="HasGuideActivitiesRequest" message="tns:HasGuideActivitiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/HasGuideActivitiesResponse" name="HasGuideActivitiesResponse" message="tns:HasGuideActivitiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectEvent">
      <wsdl:documentation>
        <summary>Gets a ProjectEvent object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEvent" name="GetProjectEventRequest" message="tns:GetProjectEventRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEventResponse" name="GetProjectEventResponse" message="tns:GetProjectEventResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectEventOnPerson">
      <wsdl:documentation>
        <summary>Gets a ProjectEvent object from a project and a person.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEventOnPerson" name="GetProjectEventOnPersonRequest" message="tns:GetProjectEventOnPersonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEventOnPersonResponse" name="GetProjectEventOnPersonResponse" message="tns:GetProjectEventOnPersonResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectEventEntity">
      <wsdl:documentation>
        <summary>Gets a ProjectEventEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEventEntity" name="GetProjectEventEntityRequest" message="tns:GetProjectEventEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEventEntityResponse" name="GetProjectEventEntityResponse" message="tns:GetProjectEventEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectEventEntityFromProjectId">
      <wsdl:documentation>
        <summary>Get a ProjectEventEntity based on a projectId.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEventEntityFromProjectId" name="GetProjectEventEntityFromProjectIdRequest" message="tns:GetProjectEventEntityFromProjectIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEventEntityFromProjectIdResponse" name="GetProjectEventEntityFromProjectIdResponse" message="tns:GetProjectEventEntityFromProjectIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteProjectEventEntityFromProjectId">
      <wsdl:documentation>
        <summary>Delete a project event based on a project id. Does not delete the project, but does delete the published and ExternalEvent and AudienceVisibility records.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/DeleteProjectEventEntityFromProjectId" name="DeleteProjectEventEntityFromProjectIdRequest" message="tns:DeleteProjectEventEntityFromProjectIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/DeleteProjectEventEntityFromProjectIdResponse" name="DeleteProjectEventEntityFromProjectIdResponse" message="tns:DeleteProjectEventEntityFromProjectIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectEventList">
      <wsdl:documentation>
        <summary>Gets an array of ProjectEvent objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEventList" name="GetProjectEventListRequest" message="tns:GetProjectEventListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEventListResponse" name="GetProjectEventListResponse" message="tns:GetProjectEventListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyProjectEvents">
      <wsdl:documentation>
        <summary>Gets all project events that belongs to the currently logged on user. The list of events are filtered by the Audience Visibility restrictions set when the project event is created.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetMyProjectEvents" name="GetMyProjectEventsRequest" message="tns:GetMyProjectEventsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetMyProjectEventsResponse" name="GetMyProjectEventsResponse" message="tns:GetMyProjectEventsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectEventsOnPerson">
      <wsdl:documentation>
        <summary>Gets all project events that belongs to the person specified. The list of events are filtered by the Audience Visibility restrictions set when the project event is created.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEventsOnPerson" name="GetProjectEventsOnPersonRequest" message="tns:GetProjectEventsOnPersonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEventsOnPersonResponse" name="GetProjectEventsOnPersonResponse" message="tns:GetProjectEventsOnPersonResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectList">
      <wsdl:documentation>
        <summary>Gets an array of Project objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectList" name="GetProjectListRequest" message="tns:GetProjectListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectListResponse" name="GetProjectListResponse" message="tns:GetProjectListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyProjects">
      <wsdl:documentation>
        <summary>Returning the projects belonging to an associate. If memberProjects is false only the projects where the associate is project responsible is returned, otherwise both the projects where the associate is project responsible and project member is returned.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetMyProjects" name="GetMyProjectsRequest" message="tns:GetMyProjectsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetMyProjectsResponse" name="GetMyProjectsResponse" message="tns:GetMyProjectsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyMemberProjects">
      <wsdl:documentation>
        <summary>Returning the projects where an user is project member.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetMyMemberProjects" name="GetMyMemberProjectsRequest" message="tns:GetMyMemberProjectsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetMyMemberProjectsResponse" name="GetMyMemberProjectsResponse" message="tns:GetMyMemberProjectsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectsFromPerson">
      <wsdl:documentation>
        <summary>Return all projects where the person is project member.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectsFromPerson" name="GetProjectsFromPersonRequest" message="tns:GetProjectsFromPersonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectsFromPersonResponse" name="GetProjectsFromPersonResponse" message="tns:GetProjectsFromPersonResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectsFromContact">
      <wsdl:documentation>
        <summary>Returns all projects where the given contact has projectmembers.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectsFromContact" name="GetProjectsFromContactRequest" message="tns:GetProjectsFromContactRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectsFromContactResponse" name="GetProjectsFromContactResponse" message="tns:GetProjectsFromContactResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPublishedProject">
      <wsdl:documentation>
        <summary>Get published project by project id.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetPublishedProject" name="GetPublishedProjectRequest" message="tns:GetPublishedProjectRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetPublishedProjectResponse" name="GetPublishedProjectResponse" message="tns:GetPublishedProjectResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPublishedProjects">
      <wsdl:documentation>
        <summary>Get published projects by project ids.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetPublishedProjects" name="GetPublishedProjectsRequest" message="tns:GetPublishedProjectsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetPublishedProjectsResponse" name="GetPublishedProjectsResponse" message="tns:GetPublishedProjectsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyPublishedProjects">
      <wsdl:documentation>
        <summary>Get published projects from the logged in user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetMyPublishedProjects" name="GetMyPublishedProjectsRequest" message="tns:GetMyPublishedProjectsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetMyPublishedProjectsResponse" name="GetMyPublishedProjectsResponse" message="tns:GetMyPublishedProjectsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPublishedProjectsOnPersonId">
      <wsdl:documentation>
        <summary>Get published projects where person  is a member</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetPublishedProjectsOnPersonId" name="GetPublishedProjectsOnPersonIdRequest" message="tns:GetPublishedProjectsOnPersonIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetPublishedProjectsOnPersonIdResponse" name="GetPublishedProjectsOnPersonIdResponse" message="tns:GetPublishedProjectsOnPersonIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectMembers">
      <wsdl:documentation>
        <summary>Returns an array of project members</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectMembers" name="GetProjectMembersRequest" message="tns:GetProjectMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectMembersResponse" name="GetProjectMembersResponse" message="tns:GetProjectMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectMember">
      <wsdl:documentation>
        <summary>Get single ProjectMember row.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectMember" name="GetProjectMemberRequest" message="tns:GetProjectMemberRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectMemberResponse" name="GetProjectMemberResponse" message="tns:GetProjectMemberResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateProjectMember">
      <wsdl:documentation>
        <summary>Updates a ProjectMember row.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/UpdateProjectMember" name="UpdateProjectMemberRequest" message="tns:UpdateProjectMemberRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/UpdateProjectMemberResponse" name="UpdateProjectMemberResponse" message="tns:UpdateProjectMemberResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectMembersById">
      <wsdl:documentation>
        <summary>Returns an array of project members</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectMembersById" name="GetProjectMembersByIdRequest" message="tns:GetProjectMembersByIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectMembersByIdResponse" name="GetProjectMembersByIdResponse" message="tns:GetProjectMembersByIdResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Project" type="tns:Project">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultProjectEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/CreateDefaultProjectEntity" style="document" />
      <wsdl:input name="CreateDefaultProjectEntityRequest">
        <soap:header message="tns:CreateDefaultProjectEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultProjectEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultProjectEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultProjectEntityResponse">
        <soap:header message="tns:CreateDefaultProjectEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultProjectEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultProjectEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultProjectEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveProjectEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/SaveProjectEntity" style="document" />
      <wsdl:input name="SaveProjectEntityRequest">
        <soap:header message="tns:SaveProjectEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveProjectEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveProjectEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveProjectEntityResponse">
        <soap:header message="tns:SaveProjectEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveProjectEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveProjectEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveProjectEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteProjectEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/DeleteProjectEntity" style="document" />
      <wsdl:input name="DeleteProjectEntityRequest">
        <soap:header message="tns:DeleteProjectEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteProjectEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteProjectEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteProjectEntityResponse">
        <soap:header message="tns:DeleteProjectEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteProjectEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteProjectEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteProjectEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultProjectEventEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/CreateDefaultProjectEventEntity" style="document" />
      <wsdl:input name="CreateDefaultProjectEventEntityRequest">
        <soap:header message="tns:CreateDefaultProjectEventEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultProjectEventEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultProjectEventEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultProjectEventEntityResponse">
        <soap:header message="tns:CreateDefaultProjectEventEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultProjectEventEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultProjectEventEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultProjectEventEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveProjectEventEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/SaveProjectEventEntity" style="document" />
      <wsdl:input name="SaveProjectEventEntityRequest">
        <soap:header message="tns:SaveProjectEventEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveProjectEventEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveProjectEventEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveProjectEventEntityResponse">
        <soap:header message="tns:SaveProjectEventEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveProjectEventEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveProjectEventEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveProjectEventEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteProjectEventEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/DeleteProjectEventEntity" style="document" />
      <wsdl:input name="DeleteProjectEventEntityRequest">
        <soap:header message="tns:DeleteProjectEventEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteProjectEventEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteProjectEventEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteProjectEventEntityResponse">
        <soap:header message="tns:DeleteProjectEventEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteProjectEventEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteProjectEventEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteProjectEventEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProject">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProject" style="document" />
      <wsdl:input name="GetProjectRequest">
        <soap:header message="tns:GetProjectRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectResponse">
        <soap:header message="tns:GetProjectResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEntity" style="document" />
      <wsdl:input name="GetProjectEntityRequest">
        <soap:header message="tns:GetProjectEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectEntityResponse">
        <soap:header message="tns:GetProjectEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddProjectMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/AddProjectMembers" style="document" />
      <wsdl:input name="AddProjectMembersRequest">
        <soap:header message="tns:AddProjectMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddProjectMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddProjectMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddProjectMembersResponse">
        <soap:header message="tns:AddProjectMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddProjectMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddProjectMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddProjectMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteProjectMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/DeleteProjectMembers" style="document" />
      <wsdl:input name="DeleteProjectMembersRequest">
        <soap:header message="tns:DeleteProjectMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteProjectMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteProjectMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteProjectMembersResponse">
        <soap:header message="tns:DeleteProjectMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteProjectMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteProjectMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteProjectMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectImage" style="document" />
      <wsdl:input name="GetProjectImageRequest">
        <soap:header message="tns:GetProjectImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectImageResponse">
        <soap:header message="tns:GetProjectImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetProjectImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/SetProjectImage" style="document" />
      <wsdl:input name="SetProjectImageRequest">
        <soap:header message="tns:SetProjectImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetProjectImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetProjectImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetProjectImageResponse">
        <soap:header message="tns:SetProjectImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetProjectImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetProjectImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetProjectImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteProjectMemberByIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/DeleteProjectMemberByIds" style="document" />
      <wsdl:input name="DeleteProjectMemberByIdsRequest">
        <soap:header message="tns:DeleteProjectMemberByIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteProjectMemberByIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteProjectMemberByIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteProjectMemberByIdsResponse">
        <soap:header message="tns:DeleteProjectMemberByIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteProjectMemberByIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteProjectMemberByIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteProjectMemberByIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDuplicates">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetDuplicates" style="document" />
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
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/CreateNewEntry" style="document" />
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
    <wsdl:operation name="SetDuplicateRulesStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/SetDuplicateRulesStatus" style="document" />
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
    <wsdl:operation name="GetDuplicateRules">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetDuplicateRules" style="document" />
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
    <wsdl:operation name="Merge">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/Merge" style="document" />
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
    <wsdl:operation name="IsNumberValid">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/IsNumberValid" style="document" />
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
    <wsdl:operation name="HasGuide">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/HasGuide" style="document" />
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
    <wsdl:operation name="GetNextMilestone">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetNextMilestone" style="document" />
      <wsdl:input name="GetNextMilestoneRequest">
        <soap:header message="tns:GetNextMilestoneRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNextMilestoneRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNextMilestoneRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNextMilestoneResponse">
        <soap:header message="tns:GetNextMilestoneResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNextMilestoneResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNextMilestoneResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNextMilestoneResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="OfferAutoNextStatusOnApppointmentCompleted">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/OfferAutoNextStatusOnApppointmentCompleted" style="document" />
      <wsdl:input name="OfferAutoNextStatusOnApppointmentCompletedRequest">
        <soap:header message="tns:OfferAutoNextStatusOnApppointmentCompletedRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:OfferAutoNextStatusOnApppointmentCompletedRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:OfferAutoNextStatusOnApppointmentCompletedRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="OfferAutoNextStatusOnApppointmentCompletedResponse">
        <soap:header message="tns:OfferAutoNextStatusOnApppointmentCompletedResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:OfferAutoNextStatusOnApppointmentCompletedResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:OfferAutoNextStatusOnApppointmentCompletedResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:OfferAutoNextStatusOnApppointmentCompletedResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNextProjectStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetNextProjectStatus" style="document" />
      <wsdl:input name="GetNextProjectStatusRequest">
        <soap:header message="tns:GetNextProjectStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNextProjectStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNextProjectStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNextProjectStatusResponse">
        <soap:header message="tns:GetNextProjectStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNextProjectStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNextProjectStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNextProjectStatusResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="HasGuideActivities">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/HasGuideActivities" style="document" />
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
    <wsdl:operation name="GetProjectEvent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEvent" style="document" />
      <wsdl:input name="GetProjectEventRequest">
        <soap:header message="tns:GetProjectEventRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectEventRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectEventRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectEventResponse">
        <soap:header message="tns:GetProjectEventResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectEventResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectEventResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectEventResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectEventOnPerson">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEventOnPerson" style="document" />
      <wsdl:input name="GetProjectEventOnPersonRequest">
        <soap:header message="tns:GetProjectEventOnPersonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectEventOnPersonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectEventOnPersonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectEventOnPersonResponse">
        <soap:header message="tns:GetProjectEventOnPersonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectEventOnPersonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectEventOnPersonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectEventOnPersonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectEventEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEventEntity" style="document" />
      <wsdl:input name="GetProjectEventEntityRequest">
        <soap:header message="tns:GetProjectEventEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectEventEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectEventEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectEventEntityResponse">
        <soap:header message="tns:GetProjectEventEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectEventEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectEventEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectEventEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectEventEntityFromProjectId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEventEntityFromProjectId" style="document" />
      <wsdl:input name="GetProjectEventEntityFromProjectIdRequest">
        <soap:header message="tns:GetProjectEventEntityFromProjectIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectEventEntityFromProjectIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectEventEntityFromProjectIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectEventEntityFromProjectIdResponse">
        <soap:header message="tns:GetProjectEventEntityFromProjectIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectEventEntityFromProjectIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectEventEntityFromProjectIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectEventEntityFromProjectIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteProjectEventEntityFromProjectId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/DeleteProjectEventEntityFromProjectId" style="document" />
      <wsdl:input name="DeleteProjectEventEntityFromProjectIdRequest">
        <soap:header message="tns:DeleteProjectEventEntityFromProjectIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteProjectEventEntityFromProjectIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteProjectEventEntityFromProjectIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteProjectEventEntityFromProjectIdResponse">
        <soap:header message="tns:DeleteProjectEventEntityFromProjectIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteProjectEventEntityFromProjectIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteProjectEventEntityFromProjectIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteProjectEventEntityFromProjectIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectEventList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEventList" style="document" />
      <wsdl:input name="GetProjectEventListRequest">
        <soap:header message="tns:GetProjectEventListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectEventListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectEventListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectEventListResponse">
        <soap:header message="tns:GetProjectEventListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectEventListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectEventListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectEventListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyProjectEvents">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetMyProjectEvents" style="document" />
      <wsdl:input name="GetMyProjectEventsRequest">
        <soap:header message="tns:GetMyProjectEventsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyProjectEventsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyProjectEventsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyProjectEventsResponse">
        <soap:header message="tns:GetMyProjectEventsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyProjectEventsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyProjectEventsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyProjectEventsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectEventsOnPerson">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectEventsOnPerson" style="document" />
      <wsdl:input name="GetProjectEventsOnPersonRequest">
        <soap:header message="tns:GetProjectEventsOnPersonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectEventsOnPersonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectEventsOnPersonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectEventsOnPersonResponse">
        <soap:header message="tns:GetProjectEventsOnPersonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectEventsOnPersonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectEventsOnPersonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectEventsOnPersonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectList" style="document" />
      <wsdl:input name="GetProjectListRequest">
        <soap:header message="tns:GetProjectListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectListResponse">
        <soap:header message="tns:GetProjectListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyProjects">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetMyProjects" style="document" />
      <wsdl:input name="GetMyProjectsRequest">
        <soap:header message="tns:GetMyProjectsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyProjectsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyProjectsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyProjectsResponse">
        <soap:header message="tns:GetMyProjectsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyProjectsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyProjectsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyProjectsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyMemberProjects">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetMyMemberProjects" style="document" />
      <wsdl:input name="GetMyMemberProjectsRequest">
        <soap:header message="tns:GetMyMemberProjectsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyMemberProjectsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyMemberProjectsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyMemberProjectsResponse">
        <soap:header message="tns:GetMyMemberProjectsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyMemberProjectsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyMemberProjectsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyMemberProjectsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectsFromPerson">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectsFromPerson" style="document" />
      <wsdl:input name="GetProjectsFromPersonRequest">
        <soap:header message="tns:GetProjectsFromPersonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectsFromPersonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectsFromPersonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectsFromPersonResponse">
        <soap:header message="tns:GetProjectsFromPersonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectsFromPersonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectsFromPersonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectsFromPersonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectsFromContact">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectsFromContact" style="document" />
      <wsdl:input name="GetProjectsFromContactRequest">
        <soap:header message="tns:GetProjectsFromContactRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectsFromContactRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectsFromContactRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectsFromContactResponse">
        <soap:header message="tns:GetProjectsFromContactResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectsFromContactResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectsFromContactResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectsFromContactResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPublishedProject">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetPublishedProject" style="document" />
      <wsdl:input name="GetPublishedProjectRequest">
        <soap:header message="tns:GetPublishedProjectRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPublishedProjectRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPublishedProjectRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPublishedProjectResponse">
        <soap:header message="tns:GetPublishedProjectResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPublishedProjectResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPublishedProjectResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPublishedProjectResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPublishedProjects">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetPublishedProjects" style="document" />
      <wsdl:input name="GetPublishedProjectsRequest">
        <soap:header message="tns:GetPublishedProjectsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPublishedProjectsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPublishedProjectsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPublishedProjectsResponse">
        <soap:header message="tns:GetPublishedProjectsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPublishedProjectsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPublishedProjectsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPublishedProjectsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyPublishedProjects">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetMyPublishedProjects" style="document" />
      <wsdl:input name="GetMyPublishedProjectsRequest">
        <soap:header message="tns:GetMyPublishedProjectsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyPublishedProjectsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyPublishedProjectsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyPublishedProjectsResponse">
        <soap:header message="tns:GetMyPublishedProjectsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyPublishedProjectsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyPublishedProjectsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyPublishedProjectsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPublishedProjectsOnPersonId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetPublishedProjectsOnPersonId" style="document" />
      <wsdl:input name="GetPublishedProjectsOnPersonIdRequest">
        <soap:header message="tns:GetPublishedProjectsOnPersonIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPublishedProjectsOnPersonIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPublishedProjectsOnPersonIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPublishedProjectsOnPersonIdResponse">
        <soap:header message="tns:GetPublishedProjectsOnPersonIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPublishedProjectsOnPersonIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPublishedProjectsOnPersonIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPublishedProjectsOnPersonIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectMembers" style="document" />
      <wsdl:input name="GetProjectMembersRequest">
        <soap:header message="tns:GetProjectMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectMembersResponse">
        <soap:header message="tns:GetProjectMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectMember">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectMember" style="document" />
      <wsdl:input name="GetProjectMemberRequest">
        <soap:header message="tns:GetProjectMemberRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectMemberRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectMemberRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectMemberResponse">
        <soap:header message="tns:GetProjectMemberResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectMemberResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateProjectMember">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/UpdateProjectMember" style="document" />
      <wsdl:input name="UpdateProjectMemberRequest">
        <soap:header message="tns:UpdateProjectMemberRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateProjectMemberRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateProjectMemberRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateProjectMemberResponse">
        <soap:header message="tns:UpdateProjectMemberResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateProjectMemberResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateProjectMemberResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateProjectMemberResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectMembersById">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services80/Project/GetProjectMembersById" style="document" />
      <wsdl:input name="GetProjectMembersByIdRequest">
        <soap:header message="tns:GetProjectMembersByIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectMembersByIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectMembersByIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectMembersByIdResponse">
        <soap:header message="tns:GetProjectMembersByIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectMembersByIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectMembersByIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectMembersByIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfProjectService">
    <wsdl:port name="BasicHttpBinding_Project" binding="tns:BasicHttpBinding_Project">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services80/Project.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

