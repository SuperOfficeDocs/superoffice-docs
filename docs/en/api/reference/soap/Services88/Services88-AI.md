---
generated: true
uid: wsdl-Services88-AI
title: Services88.AIAgent WSDL
content_type: reference
---

# Services88.AIAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfAIService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:ser="http://schemas.microsoft.com/2003/10/Serialization/">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultCopilotDataSourceEntity">
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
      <xs:element name="CreateDefaultCopilotDataSourceEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q5:CopilotDataSourceEntity" xmlns:q5="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CopilotDataSourceEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q6:Carrier" xmlns:q6="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="CopilotDataSourceId" type="xs:int" />
              <xs:element minOccurs="0" name="CopilotDataSourceType" type="q6:CopilotDataSourceType" />
              <xs:element minOccurs="0" name="CopilotId" type="xs:int" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Settings" nillable="true" type="q6:ArrayOfCopilotDataSourceSetting" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CopilotDataSourceEntity" nillable="true" type="q7:CopilotDataSourceEntity" xmlns:q7="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="EFieldRight" nillable="true" type="q20:EFieldRight" xmlns:q20="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="CopilotDataSourceType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Requests" />
          <xs:enumeration value="FAQs" />
          <xs:enumeration value="ReplyTemplates" />
          <xs:enumeration value="Documents" />
          <xs:enumeration value="Products" />
          <xs:enumeration value="WebContent" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="CopilotDataSourceType" nillable="true" type="q21:CopilotDataSourceType" xmlns:q21="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfCopilotDataSourceSetting">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="CopilotDataSourceSetting" nillable="true" type="q22:CopilotDataSourceSetting" xmlns:q22="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCopilotDataSourceSetting" nillable="true" type="q23:ArrayOfCopilotDataSourceSetting" xmlns:q23="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="CopilotDataSourceSetting">
        <xs:complexContent mixed="false">
          <xs:extension base="q24:Carrier" xmlns:q24="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="CopilotDataSourceSettingId" type="xs:int" />
              <xs:element minOccurs="0" name="CopilotDataSourceId" type="xs:int" />
              <xs:element minOccurs="0" name="Key" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CopilotDataSourceSetting" nillable="true" type="q25:CopilotDataSourceSetting" xmlns:q25="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SoExceptionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="StackTrace" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FriendlyText" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ExceptionType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="InnerException" nillable="true" type="q26:SoExceptionInfo" xmlns:q26="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Parameters" nillable="true" type="q27:SoExceptionInfoParameters" xmlns:q27="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExceptionInfo" nillable="true" type="q28:SoExceptionInfo" xmlns:q28="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="SoExceptionInfoParameters" nillable="true" type="q29:SoExceptionInfoParameters" xmlns:q29="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ExceptionInfo" nillable="true" type="q30:SoExceptionInfo" xmlns:q30="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="SoExtraInfo" nillable="true" type="q31:SoExtraInfo" xmlns:q31="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ExtraInfo" nillable="true" type="q32:SoExtraInfo" xmlns:q32="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="Succeeded" type="xs:boolean" />
      <xs:element name="SaveCopilotDataSourceEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CopilotDataSourceEntity" nillable="true" type="q33:CopilotDataSourceEntity" xmlns:q33="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCopilotDataSourceEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q34:CopilotDataSourceEntity" xmlns:q34="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteCopilotDataSourceEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CopilotDataSourceEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteCopilotDataSourceEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultCopilotEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultCopilotEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q35:CopilotEntity" xmlns:q35="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CopilotEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q36:Carrier" xmlns:q36="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="CopilotId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CopilotDataSources" nillable="true" type="q36:ArrayOfCopilotDataSourceEntity" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CopilotEntity" nillable="true" type="q37:CopilotEntity" xmlns:q37="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfCopilotDataSourceEntity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="CopilotDataSourceEntity" nillable="true" type="q38:CopilotDataSourceEntity" xmlns:q38="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCopilotDataSourceEntity" nillable="true" type="q39:ArrayOfCopilotDataSourceEntity" xmlns:q39="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="SaveCopilotEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CopilotEntity" nillable="true" type="q40:CopilotEntity" xmlns:q40="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCopilotEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q41:CopilotEntity" xmlns:q41="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteCopilotEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CopilotEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteCopilotEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SummarizeText">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PercentSmaller" type="xs:int" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SummarizeTextResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
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
            <xs:element minOccurs="0" name="Style" type="q42:AiTextStyle" xmlns:q42="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AiTextStyle" nillable="true" type="q43:AiTextStyle" xmlns:q43="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
            <xs:element minOccurs="0" name="Appointment" nillable="true" type="q44:AppointmentEntity" xmlns:q44="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="AppointmentEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q45:Carrier" xmlns:q45="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Associate" nillable="true" type="q45:Associate" />
              <xs:element minOccurs="0" name="Contact" nillable="true" type="q45:Contact" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="q45:Associate" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="q45:Associate" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Agenda" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="InternalNotes" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="InvitedPerson" nillable="true" type="q45:Person" />
              <xs:element minOccurs="0" name="Person" nillable="true" type="q45:Person" />
              <xs:element minOccurs="0" name="MotherId" type="xs:int" />
              <xs:element minOccurs="0" name="Priority" nillable="true" type="q45:Priority" />
              <xs:element minOccurs="0" name="Private" type="q45:AppointmentPrivate" />
              <xs:element minOccurs="0" name="Project" nillable="true" type="q45:Project" />
              <xs:element minOccurs="0" name="Type" type="q45:AppointmentType" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Completed" type="q45:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveLinks" type="xs:int" />
              <xs:element minOccurs="0" name="Links" nillable="true" type="q45:ArrayOfLink" />
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
              <xs:element minOccurs="0" name="Recurrence" nillable="true" type="q45:RecurrenceInfo" />
              <xs:element minOccurs="0" name="Participants" nillable="true" type="q45:ArrayOfParticipantInfo" />
              <xs:element minOccurs="0" name="AssignmentStatus" type="q45:AssignmentStatus" />
              <xs:element minOccurs="0" name="InvitationStatus" type="q45:InvitationStatus" />
              <xs:element minOccurs="0" name="BookingType" type="q45:BookingType" />
              <xs:element minOccurs="0" name="ActiveDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="HasConflict" type="xs:boolean" />
              <xs:element minOccurs="0" name="AssignedBy" nillable="true" type="q45:Associate" />
              <xs:element minOccurs="0" name="MotherAssociate" nillable="true" type="q45:Associate" />
              <xs:element minOccurs="0" name="Task" nillable="true" type="q45:TaskListItem" />
              <xs:element minOccurs="0" name="PreferredTZLocation" type="xs:int" />
              <xs:element minOccurs="0" name="PreferredTZLocationData" nillable="true" type="q45:TimeZoneData" />
              <xs:element minOccurs="0" name="Sale" nillable="true" type="q45:Sale" />
              <xs:element minOccurs="0" name="SuggestedAppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="IsMileStone" type="xs:boolean" />
              <xs:element minOccurs="0" name="CautionWarning" type="q45:AppointmentCautionWarning" />
              <xs:element minOccurs="0" name="OwnedExternally" type="q45:AppointmentExternalOwner" />
              <xs:element minOccurs="0" name="JoinVideomeetUrl" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CentralserviceVideomeetId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserDefinedFields" nillable="true" type="q45:StringDictionary" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="q45:StringDictionary" />
              <xs:element minOccurs="0" name="CustomFields" nillable="true" type="q45:StringDictionary" />
              <xs:element minOccurs="0" name="PublishEventDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishTo" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishFrom" type="xs:dateTime" />
              <xs:element minOccurs="0" name="IsPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="VisibleFor" nillable="true" type="q45:ArrayOfVisibleFor" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AppointmentEntity" nillable="true" type="q46:AppointmentEntity" xmlns:q46="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Associate">
        <xs:complexContent mixed="false">
          <xs:extension base="q47:Carrier" xmlns:q47="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Type" type="q47:UserType" />
              <xs:element minOccurs="0" name="GroupIdx" type="xs:int" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="EjUserId" type="xs:int" />
              <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="q47:StringDictionary" />
              <xs:element minOccurs="0" name="CustomFields" nillable="true" type="q47:StringDictionary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Associate" nillable="true" type="q48:Associate" xmlns:q48="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="UserType" nillable="true" type="q49:UserType" xmlns:q49="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="StringDictionary" nillable="true" type="q50:StringDictionary" xmlns:q50="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Contact">
        <xs:complexContent mixed="false">
          <xs:extension base="q51:Carrier" xmlns:q51="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
              <xs:element minOccurs="0" name="Address" nillable="true" type="q51:Address" />
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
      <xs:element name="Contact" nillable="true" type="q52:Contact" xmlns:q52="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Address">
        <xs:complexContent mixed="false">
          <xs:extension base="q53:Carrier" xmlns:q53="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Wgs84Latitude" type="xs:double" />
              <xs:element minOccurs="0" name="Wgs84Longitude" type="xs:double" />
              <xs:element minOccurs="0" name="LocalizedAddress" nillable="true" type="q53:ArrayOfArrayOfLocalizedField" />
              <xs:element minOccurs="0" name="Street" nillable="true" type="q53:StructuredAddress" />
              <xs:element minOccurs="0" name="Postal" nillable="true" type="q53:StructuredAddress" />
              <xs:element minOccurs="0" name="Formatted" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Address" nillable="true" type="q54:Address" xmlns:q54="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArrayOfLocalizedField" nillable="true" type="q55:ArrayOfLocalizedField" xmlns:q55="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArrayOfLocalizedField" nillable="true" type="q56:ArrayOfArrayOfLocalizedField" xmlns:q56="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="LocalizedField" nillable="true" type="q57:LocalizedField" xmlns:q57="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLocalizedField" nillable="true" type="q58:ArrayOfLocalizedField" xmlns:q58="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="LocalizedField">
        <xs:complexContent mixed="false">
          <xs:extension base="q59:Carrier" xmlns:q59="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="LocalizedField" nillable="true" type="q60:LocalizedField" xmlns:q60="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="StructuredAddress">
        <xs:sequence>
          <xs:element minOccurs="0" name="AtypeIdx" type="q61:AddressType" xmlns:q61="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="StructuredAddress" nillable="true" type="q62:StructuredAddress" xmlns:q62="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AddressType" nillable="true" type="q63:AddressType" xmlns:q63="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Person">
        <xs:complexContent mixed="false">
          <xs:extension base="q64:Carrier" xmlns:q64="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="Person" nillable="true" type="q65:Person" xmlns:q65="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Priority">
        <xs:complexContent mixed="false">
          <xs:extension base="q66:Carrier" xmlns:q66="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Priority" nillable="true" type="q67:Priority" xmlns:q67="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AppointmentPrivate" nillable="true" type="q68:AppointmentPrivate" xmlns:q68="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Project">
        <xs:complexContent mixed="false">
          <xs:extension base="q69:Carrier" xmlns:q69="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="Project" nillable="true" type="q70:Project" xmlns:q70="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AppointmentType" nillable="true" type="q71:AppointmentType" xmlns:q71="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="ActivityStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="NotStarted" />
          <xs:enumeration value="Started" />
          <xs:enumeration value="Completed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ActivityStatus" nillable="true" type="q72:ActivityStatus" xmlns:q72="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfLink">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Link" nillable="true" type="q73:Link" xmlns:q73="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLink" nillable="true" type="q74:ArrayOfLink" xmlns:q74="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Link">
        <xs:complexContent mixed="false">
          <xs:extension base="q75:Carrier" xmlns:q75="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="Link" nillable="true" type="q76:Link" xmlns:q76="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="RecurrenceId" type="xs:int" />
          <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="RecurrenceEndType" type="q77:RecurrenceEndType" xmlns:q77="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Pattern" type="q78:RecurrencePattern" xmlns:q78="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="DayPattern" nillable="true" type="q79:RecurrenceDayPattern" xmlns:q79="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="WeekPattern" nillable="true" type="q80:RecurrenceWeekPattern" xmlns:q80="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="MonthPattern" nillable="true" type="q81:RecurrenceMonthPattern" xmlns:q81="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="YearPattern" nillable="true" type="q82:RecurrenceYearPattern" xmlns:q82="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Dates" nillable="true" type="q83:ArrayOfRecurrenceDate" xmlns:q83="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="RecurrenceCounter" type="xs:int" />
          <xs:element minOccurs="0" name="IsRecurrence" type="xs:boolean" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceInfo" nillable="true" type="q84:RecurrenceInfo" xmlns:q84="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="RecurrenceEndType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="EndDate" />
          <xs:enumeration value="Counter" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrenceEndType" nillable="true" type="q85:RecurrenceEndType" xmlns:q85="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="RecurrencePattern" nillable="true" type="q86:RecurrencePattern" xmlns:q86="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceDayPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Pattern" type="q87:RecurrenceDailyPattern" xmlns:q87="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceDayPattern" nillable="true" type="q88:RecurrenceDayPattern" xmlns:q88="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="RecurrenceDailyPattern">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="EveryWorkday" />
          <xs:enumeration value="EveryWeekday" />
          <xs:enumeration value="EveryCyclicDay" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrenceDailyPattern" nillable="true" type="q89:RecurrenceDailyPattern" xmlns:q89="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceWeekPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Weekdays" type="q90:Weekday" xmlns:q90="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceWeekPattern" nillable="true" type="q91:RecurrenceWeekPattern" xmlns:q91="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="Weekday" nillable="true" type="q92:Weekday" xmlns:q92="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceMonthPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Day" type="xs:int" />
          <xs:element minOccurs="0" name="Weekday" type="q93:Weekday" xmlns:q93="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="WeekOfMonth" type="q94:WeekOfMonth" xmlns:q94="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Pattern" type="q95:RecurrenceMonthlyPattern" xmlns:q95="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceMonthPattern" nillable="true" type="q96:RecurrenceMonthPattern" xmlns:q96="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="WeekOfMonth" nillable="true" type="q97:WeekOfMonth" xmlns:q97="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="RecurrenceMonthlyPattern" nillable="true" type="q98:RecurrenceMonthlyPattern" xmlns:q98="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceYearPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Day" type="xs:int" />
          <xs:element minOccurs="0" name="Weekday" type="q99:Weekday" xmlns:q99="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="WeekOfMonth" type="q100:WeekOfMonth" xmlns:q100="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Pattern" type="q101:RecurrenceYearlyPattern" xmlns:q101="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceYearPattern" nillable="true" type="q102:RecurrenceYearPattern" xmlns:q102="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="RecurrenceYearlyPattern" nillable="true" type="q103:RecurrenceYearlyPattern" xmlns:q103="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfRecurrenceDate">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="RecurrenceDate" nillable="true" type="q104:RecurrenceDate" xmlns:q104="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfRecurrenceDate" nillable="true" type="q105:ArrayOfRecurrenceDate" xmlns:q105="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceDate">
        <xs:sequence>
          <xs:element minOccurs="0" name="Date" type="xs:dateTime" />
          <xs:element minOccurs="0" name="IsConflict" type="xs:boolean" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DescriptionStyleHint" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceDate" nillable="true" type="q106:RecurrenceDate" xmlns:q106="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfParticipantInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ParticipantInfo" nillable="true" type="q107:ParticipantInfo" xmlns:q107="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfParticipantInfo" nillable="true" type="q108:ArrayOfParticipantInfo" xmlns:q108="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ParticipantInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          <xs:element minOccurs="0" name="EmailId" type="xs:int" />
          <xs:element minOccurs="0" name="SendEmail" type="xs:boolean" />
          <xs:element minOccurs="0" name="InvitationStatus" type="q109:InvitationStatus" xmlns:q109="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ExternallyOwnedType" type="q110:ExternallyOwnedType" xmlns:q110="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="ExternallyOwnedStatus" type="q111:ExternallyOwnedStatus" xmlns:q111="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ParticipantInfo" nillable="true" type="q112:ParticipantInfo" xmlns:q112="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="InvitationStatus" nillable="true" type="q113:InvitationStatus" xmlns:q113="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="ExternallyOwnedType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Organizer" />
          <xs:enumeration value="Required" />
          <xs:enumeration value="Optional" />
          <xs:enumeration value="Resource" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ExternallyOwnedType" nillable="true" type="q114:ExternallyOwnedType" xmlns:q114="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="ExternallyOwnedStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="TentativelyAccepted" />
          <xs:enumeration value="Accepted" />
          <xs:enumeration value="Declined" />
          <xs:enumeration value="NotResponded" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ExternallyOwnedStatus" nillable="true" type="q115:ExternallyOwnedStatus" xmlns:q115="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AssignmentStatus" nillable="true" type="q116:AssignmentStatus" xmlns:q116="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="BookingType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="None" />
          <xs:enumeration value="Owner" />
          <xs:enumeration value="Participant" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="BookingType" nillable="true" type="q117:BookingType" xmlns:q117="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TaskListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q118:Carrier" xmlns:q118="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="TaskListItemId" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Direction" type="q118:TaskDirection" />
              <xs:element minOccurs="0" name="Type" type="q118:TaskType" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="IntentId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="IsDefaultAlldayEvent" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsDefaultFree" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsDefaultPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="ColorIndex" type="q118:ColorIndex" />
              <xs:element minOccurs="0" name="DefaultVideomeetingStatus" type="q118:VideoMeetingStatus" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TaskListItem" nillable="true" type="q119:TaskListItem" xmlns:q119="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="TaskDirection" nillable="true" type="q120:TaskDirection" xmlns:q120="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="TaskType" nillable="true" type="q121:TaskType" xmlns:q121="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="ColorIndex" nillable="true" type="q122:ColorIndex" xmlns:q122="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="VideoMeetingStatus" nillable="true" type="q123:VideoMeetingStatus" xmlns:q123="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TimeZoneData">
        <xs:sequence>
          <xs:element minOccurs="0" name="TZLocationID" type="xs:int" />
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="TZLocationCode" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="TZLocationCities" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="IsoNumber" type="xs:int" />
          <xs:element minOccurs="0" name="TimeZoneSTDRules" nillable="true" type="q124:TimeZoneRuleDictionary" xmlns:q124="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="TimeZoneDSTRules" nillable="true" type="q125:TimeZoneRuleDictionary" xmlns:q125="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TimeZoneData" nillable="true" type="q126:TimeZoneData" xmlns:q126="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
                <xs:element name="Value" nillable="true" type="q127:TimeZoneRule" xmlns:q127="http://www.superoffice.net/ws/crm/NetServer/Services88" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TimeZoneRuleDictionary" nillable="true" type="q128:TimeZoneRuleDictionary" xmlns:q128="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="TimeZoneRule" nillable="true" type="q129:TimeZoneRule" xmlns:q129="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Sale">
        <xs:complexContent mixed="false">
          <xs:extension base="q130:Carrier" xmlns:q130="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
              <xs:element minOccurs="0" name="Status" type="q130:SaleStatus" />
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
              <xs:element minOccurs="0" name="Completed" type="q130:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="NextDueDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Number" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Sale" nillable="true" type="q131:Sale" xmlns:q131="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="SaleStatus" nillable="true" type="q132:SaleStatus" xmlns:q132="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AppointmentCautionWarning" nillable="true" type="q133:AppointmentCautionWarning" xmlns:q133="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="AppointmentExternalOwner">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Other" />
          <xs:enumeration value="Outlook" />
          <xs:enumeration value="Google" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="AppointmentExternalOwner" nillable="true" type="q134:AppointmentExternalOwner" xmlns:q134="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfVisibleFor">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="VisibleFor" nillable="true" type="q135:VisibleFor" xmlns:q135="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfVisibleFor" nillable="true" type="q136:ArrayOfVisibleFor" xmlns:q136="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="VisibleFor">
        <xs:complexContent mixed="false">
          <xs:extension base="q137:Carrier" xmlns:q137="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="VisibleId" type="xs:int" />
              <xs:element minOccurs="0" name="Visibility" type="q137:Visibility" />
              <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="VisibleFor" nillable="true" type="q138:VisibleFor" xmlns:q138="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="Visibility">
        <xs:restriction base="xs:string">
          <xs:enumeration value="All" />
          <xs:enumeration value="Associate" />
          <xs:enumeration value="Group" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="Visibility" nillable="true" type="q139:Visibility" xmlns:q139="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="CreateTextForAppointmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AnalyzeBizCardImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Image" nillable="true" type="xs:base64Binary" />
            <xs:element minOccurs="0" name="MergeWithDatabase" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AnalyzeBizCardImageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q140:BizCard" xmlns:q140="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="BizCard">
        <xs:sequence>
          <xs:element minOccurs="0" name="Contact" nillable="true" type="q141:ContactEntity" xmlns:q141="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Person" nillable="true" type="q142:PersonEntity" xmlns:q142="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="LogoImage" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="PhotoImage" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="BizCard" nillable="true" type="q143:BizCard" xmlns:q143="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ContactEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q144:Carrier" xmlns:q144="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Department" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OrgNr" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Number1" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Number2" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Emails" nillable="true" type="q144:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Interests" nillable="true" type="q144:ArrayOfSelectableMDOListItem" />
              <xs:element minOccurs="0" name="Urls" nillable="true" type="q144:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Phones" nillable="true" type="q144:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Faxes" nillable="true" type="q144:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="q144:Associate" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="q144:Associate" />
              <xs:element minOccurs="0" name="Associate" nillable="true" type="q144:Associate" />
              <xs:element minOccurs="0" name="Business" nillable="true" type="q144:Business" />
              <xs:element minOccurs="0" name="Category" nillable="true" type="q144:Category" />
              <xs:element minOccurs="0" name="Country" nillable="true" type="q144:Country" />
              <xs:element minOccurs="0" name="Persons" nillable="true" type="q144:ArrayOfPerson" />
              <xs:element minOccurs="0" name="NoMailing" type="xs:boolean" />
              <xs:element minOccurs="0" name="Kananame" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Xstop" type="xs:boolean" />
              <xs:element minOccurs="0" name="ActiveInterests" type="xs:int" />
              <xs:element minOccurs="0" name="GroupId" type="xs:int" />
              <xs:element minOccurs="0" name="ActiveStatusMonitorId" type="xs:int" />
              <xs:element minOccurs="0" name="SupportAssociate" nillable="true" type="q144:Associate" />
              <xs:element minOccurs="0" name="TicketPriority" nillable="true" type="q144:TicketPriority" />
              <xs:element minOccurs="0" name="CustomerLanguage" nillable="true" type="q144:CustomerLanguage" />
              <xs:element minOccurs="0" name="Deleted" type="xs:short" />
              <xs:element minOccurs="0" name="DbiAgentId" type="xs:int" />
              <xs:element minOccurs="0" name="DbiLastSyncronized" type="xs:dateTime" />
              <xs:element minOccurs="0" name="DbiKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DbiLastModified" type="xs:dateTime" />
              <xs:element minOccurs="0" name="SupportPerson" nillable="true" type="q144:Person" />
              <xs:element minOccurs="0" name="Address" nillable="true" type="q144:Address" />
              <xs:element minOccurs="0" name="Source" type="xs:short" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="BounceEmails" nillable="true" type="q145:ArrayOfstring" xmlns:q145="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="Domains" nillable="true" type="q146:ArrayOfstring" xmlns:q146="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="UtmParameters" nillable="true" type="q144:SavedUtmParameters" />
              <xs:element minOccurs="0" name="UserDefinedFields" nillable="true" type="q144:StringDictionary" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="q144:StringDictionary" />
              <xs:element minOccurs="0" name="CustomFields" nillable="true" type="q144:StringDictionary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ContactEntity" nillable="true" type="q147:ContactEntity" xmlns:q147="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfEntityElement">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="EntityElement" nillable="true" type="q148:EntityElement" xmlns:q148="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfEntityElement" nillable="true" type="q149:ArrayOfEntityElement" xmlns:q149="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="EntityElement">
        <xs:complexContent mixed="false">
          <xs:extension base="q150:Carrier" xmlns:q150="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StrippedValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EntityElement" nillable="true" type="q151:EntityElement" xmlns:q151="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfSelectableMDOListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="SelectableMDOListItem" nillable="true" type="q152:SelectableMDOListItem" xmlns:q152="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfSelectableMDOListItem" nillable="true" type="q153:ArrayOfSelectableMDOListItem" xmlns:q153="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SelectableMDOListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q154:Carrier" xmlns:q154="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
              <xs:element minOccurs="0" name="ChildItems" nillable="true" type="q154:ArrayOfSelectableMDOListItem" />
              <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StyleHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Hidden" type="xs:boolean" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SelectableMDOListItem" nillable="true" type="q155:SelectableMDOListItem" xmlns:q155="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Business">
        <xs:complexContent mixed="false">
          <xs:extension base="q156:Carrier" xmlns:q156="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Business" nillable="true" type="q157:Business" xmlns:q157="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Category">
        <xs:complexContent mixed="false">
          <xs:extension base="q158:Carrier" xmlns:q158="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CategoryGroup" type="q158:CategoryGroup" />
              <xs:element minOccurs="0" name="EnableLeadStatus" type="xs:boolean" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Category" nillable="true" type="q159:Category" xmlns:q159="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="CategoryGroup">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Customer" />
          <xs:enumeration value="PotentialCustomer" />
          <xs:enumeration value="Partner" />
          <xs:enumeration value="Lost" />
          <xs:enumeration value="Other" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="CategoryGroup" nillable="true" type="q160:CategoryGroup" xmlns:q160="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Country">
        <xs:complexContent mixed="false">
          <xs:extension base="q161:Carrier" xmlns:q161="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="Country" nillable="true" type="q162:Country" xmlns:q162="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfPerson">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Person" nillable="true" type="q163:Person" xmlns:q163="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfPerson" nillable="true" type="q164:ArrayOfPerson" xmlns:q164="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TicketPriority">
        <xs:complexContent mixed="false">
          <xs:extension base="q165:Carrier" xmlns:q165="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TicketPriority" nillable="true" type="q166:TicketPriority" xmlns:q166="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="CustomerLanguage">
        <xs:complexContent mixed="false">
          <xs:extension base="q167:Carrier" xmlns:q167="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CustomerLanguage" nillable="true" type="q168:CustomerLanguage" xmlns:q168="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SavedUtmParameters">
        <xs:complexContent mixed="false">
          <xs:extension base="q169:Carrier" xmlns:q169="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="FormName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FirsttouchSource" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FirsttouchMedium" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FirsttouchCampaign" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FirsttouchTerm" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FirsttouchContent" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FirsttouchReferrerDomain" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Medium" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Campaign" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Term" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Content" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ReferrerDomain" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SavedUtmParameters" nillable="true" type="q170:SavedUtmParameters" xmlns:q170="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="PersonEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q171:Carrier" xmlns:q171="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="q171:Associate" />
              <xs:element minOccurs="0" name="Emails" nillable="true" type="q171:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsAssociate" type="xs:boolean" />
              <xs:element minOccurs="0" name="PrivatePhones" nillable="true" type="q171:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Faxes" nillable="true" type="q171:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="MobilePhones" nillable="true" type="q171:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="OfficePhones" nillable="true" type="q171:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="OtherPhones" nillable="true" type="q171:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Position" nillable="true" type="q171:Position" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="q171:Associate" />
              <xs:element minOccurs="0" name="Contact" nillable="true" type="q171:Contact" />
              <xs:element minOccurs="0" name="Country" nillable="true" type="q171:Country" />
              <xs:element minOccurs="0" name="Interests" nillable="true" type="q171:ArrayOfSelectableMDOListItem" />
              <xs:element minOccurs="0" name="PersonNumber" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="NoMailing" type="xs:boolean" />
              <xs:element minOccurs="0" name="UsePersonAddress" type="xs:boolean" />
              <xs:element minOccurs="0" name="Retired" type="xs:boolean" />
              <xs:element minOccurs="0" name="Urls" nillable="true" type="q171:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="FormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Address" nillable="true" type="q171:Address" />
              <xs:element minOccurs="0" name="Post3" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Post2" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Post1" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Kanalname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Kanafname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CorrespondingAssociate" nillable="true" type="q171:Associate" />
              <xs:element minOccurs="0" name="Category" nillable="true" type="q171:Category" />
              <xs:element minOccurs="0" name="Business" nillable="true" type="q171:Business" />
              <xs:element minOccurs="0" name="Associate" nillable="true" type="q171:Associate" />
              <xs:element minOccurs="0" name="Salutation" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ActiveInterests" type="xs:int" />
              <xs:element minOccurs="0" name="SupportAssociate" nillable="true" type="q171:Associate" />
              <xs:element minOccurs="0" name="TicketPriority" nillable="true" type="q171:TicketPriority" />
              <xs:element minOccurs="0" name="CustomerLanguage" nillable="true" type="q171:CustomerLanguage" />
              <xs:element minOccurs="0" name="DbiAgentId" type="xs:int" />
              <xs:element minOccurs="0" name="DbiKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DbiLastModified" type="xs:dateTime" />
              <xs:element minOccurs="0" name="DbiLastSyncronized" type="xs:dateTime" />
              <xs:element minOccurs="0" name="SentInfo" type="xs:short" />
              <xs:element minOccurs="0" name="ShowContactTickets" type="xs:short" />
              <xs:element minOccurs="0" name="UserInfo" nillable="true" type="q171:UserInfo" />
              <xs:element minOccurs="0" name="ChatEmails" nillable="true" type="q171:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="InternetPhones" nillable="true" type="q171:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Source" type="xs:short" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="ShipmentTypes" nillable="true" type="q171:ArrayOfSelectableMDOListItem" />
              <xs:element minOccurs="0" name="Consents" nillable="true" type="q171:ArrayOfConsentInfo" />
              <xs:element minOccurs="0" name="BounceEmails" nillable="true" type="q172:ArrayOfstring" xmlns:q172="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="ActiveStatusMonitorId" type="xs:int" />
              <xs:element minOccurs="0" name="CreatedByFormId" type="xs:int" />
              <xs:element minOccurs="0" name="UtmParameters" nillable="true" type="q171:SavedUtmParameters" />
              <xs:element minOccurs="0" name="LeadstatusId" type="xs:int" />
              <xs:element minOccurs="0" name="Leadstatus" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserDefinedFields" nillable="true" type="q171:StringDictionary" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="q171:StringDictionary" />
              <xs:element minOccurs="0" name="CustomFields" nillable="true" type="q171:StringDictionary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PersonEntity" nillable="true" type="q173:PersonEntity" xmlns:q173="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Position">
        <xs:complexContent mixed="false">
          <xs:extension base="q174:Carrier" xmlns:q174="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Position" nillable="true" type="q175:Position" xmlns:q175="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="UserInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="q176:Carrier" xmlns:q176="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="UserInfoId" type="xs:int" />
              <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserGroupId" type="xs:int" />
              <xs:element minOccurs="0" name="EjUserId" type="xs:int" />
              <xs:element minOccurs="0" name="UserType" type="q176:UserType" />
              <xs:element minOccurs="0" name="GrantedLicenses" nillable="true" type="q177:ArrayOfstring" xmlns:q177="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="CanLogon" type="xs:boolean" />
              <xs:element minOccurs="0" name="RoleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RoleTooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserGroupName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserGroupTooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="UserInfo" nillable="true" type="q178:UserInfo" xmlns:q178="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfConsentInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ConsentInfo" nillable="true" type="q179:ConsentInfo" xmlns:q179="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfConsentInfo" nillable="true" type="q180:ArrayOfConsentInfo" xmlns:q180="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ConsentInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="q181:Carrier" xmlns:q181="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ConsentPersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Comment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RegisteredAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="LegalBaseId" type="xs:int" />
              <xs:element minOccurs="0" name="LegalBaseKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="LegalBaseName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ConsentPurposeId" type="xs:int" />
              <xs:element minOccurs="0" name="ConsentPurposeKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ConsentPurposeName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ConsentSourceId" type="xs:int" />
              <xs:element minOccurs="0" name="ConsentSourceKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ConsentSourceName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ConsentInfo" nillable="true" type="q182:ConsentInfo" xmlns:q182="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="AnalyzeBizCardText">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="MergeWithDatabase" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AnalyzeBizCardTextResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q183:BizCard" xmlns:q183="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
            <xs:element minOccurs="0" name="Response" nillable="true" type="q184:CategorizationStatusResponse" xmlns:q184="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CategorizationStatusResponse">
        <xs:complexContent mixed="false">
          <xs:extension base="q185:Carrier" xmlns:q185="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ContextIdentifier" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Status" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CurrentModel" nillable="true" type="q185:CategorizationModelDetails" />
              <xs:element minOccurs="0" name="PreviousModel" nillable="true" type="q185:CategorizationModelDetails" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CategorizationStatusResponse" nillable="true" type="q186:CategorizationStatusResponse" xmlns:q186="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="CategorizationModelDetails">
        <xs:complexContent mixed="false">
          <xs:extension base="q187:Carrier" xmlns:q187="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ModelBuiltDateTime" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Accuracy" type="xs:double" />
              <xs:element minOccurs="0" name="TicketCountForTraining" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CategorizationModelDetails" nillable="true" type="q188:CategorizationModelDetails" xmlns:q188="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
            <xs:element minOccurs="0" name="PreviousTurns" nillable="true" type="q189:ArrayOfChatbotTurn" xmlns:q189="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="ApiUrl" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfChatbotTurn">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ChatbotTurn" nillable="true" type="q190:ChatbotTurn" xmlns:q190="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfChatbotTurn" nillable="true" type="q191:ArrayOfChatbotTurn" xmlns:q191="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ChatbotTurn">
        <xs:sequence>
          <xs:element minOccurs="0" name="Timestamp" type="xs:dateTime" />
          <xs:element minOccurs="0" name="UserPrompt" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="UserDisplayText" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="BotResponse" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="BotActions" nillable="true" type="q192:StringDictionary" xmlns:q192="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Attachments" nillable="true" type="q193:ArrayOfstring" xmlns:q193="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ChatbotTurn" nillable="true" type="q194:ChatbotTurn" xmlns:q194="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetChatbotResponseResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q195:ChatbotTurn" xmlns:q195="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
            <xs:element minOccurs="0" name="Response" nillable="true" type="q196:ChatbotTurn" xmlns:q196="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
            <xs:element minOccurs="0" name="Response" nillable="true" type="q197:ArrayOfChatbotTurn" xmlns:q197="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="GetCopilotDataSourceEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CopilotDataSourceEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCopilotDataSourceEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q198:CopilotDataSourceEntity" xmlns:q198="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCopilotEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CopilotEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCopilotEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q199:CopilotEntity" xmlns:q199="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFormDesignFromImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Image" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFormDesignFromImageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q200:StringDictionary" xmlns:q200="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFormDesignFromUrl">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Url" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFormDesignFromUrlResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q201:StringDictionary" xmlns:q201="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
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
            <xs:element minOccurs="0" name="Response" nillable="true" type="q202:Sentiment" xmlns:q202="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Sentiment">
        <xs:complexContent mixed="false">
          <xs:extension base="q203:Carrier" xmlns:q203="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Score" type="xs:int" />
              <xs:element minOccurs="0" name="Confidence" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Sentiment" nillable="true" type="q204:Sentiment" xmlns:q204="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="ParseQueryIntoRestrictions">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Query" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Currents" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PreviousQuery" nillable="true" type="q205:NaturalLanguageSearch" xmlns:q205="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="NaturalLanguageSearch">
        <xs:sequence>
          <xs:element minOccurs="0" name="Query" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ResponseMarkdown" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Entity" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ODataQuery" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Restrictions" nillable="true" type="q206:ArrayOfArchiveRestrictionInfo" xmlns:q206="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="InternalContext" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="NaturalLanguageSearch" nillable="true" type="q207:NaturalLanguageSearch" xmlns:q207="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfArchiveRestrictionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArchiveRestrictionInfo" nillable="true" type="q208:ArchiveRestrictionInfo" xmlns:q208="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArchiveRestrictionInfo" nillable="true" type="q209:ArrayOfArchiveRestrictionInfo" xmlns:q209="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArchiveRestrictionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Operator" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Values" nillable="true" type="q210:ArrayOfstring" xmlns:q210="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="DisplayValues" nillable="true" type="q211:ArrayOfstring" xmlns:q211="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="ColumnInfo" nillable="true" type="q212:ArchiveColumnInfo" xmlns:q212="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
          <xs:element minOccurs="0" name="SubRestrictions" nillable="true" type="q213:ArrayOfArchiveRestrictionInfo" xmlns:q213="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="InterParenthesis" type="xs:int" />
          <xs:element minOccurs="0" name="InterOperator" type="q214:InterRestrictionOperator" xmlns:q214="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="UniqueHash" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArchiveRestrictionInfo" nillable="true" type="q215:ArchiveRestrictionInfo" xmlns:q215="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="ArchiveColumnInfo" nillable="true" type="q216:ArchiveColumnInfo" xmlns:q216="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="InterRestrictionOperator">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="And" />
          <xs:enumeration value="Or" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="InterRestrictionOperator" nillable="true" type="q217:InterRestrictionOperator" xmlns:q217="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ParseQueryIntoRestrictionsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q218:NaturalLanguageSearch" xmlns:q218="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemovePhotoBackground">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Image" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemovePhotoBackgroundResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Answer">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NamespaceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Query" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Type" type="q219:RagType" xmlns:q219="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="Top" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="RagType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Ticket" />
          <xs:enumeration value="Webpage" />
          <xs:enumeration value="Document" />
          <xs:enumeration value="FAQ" />
          <xs:enumeration value="Product" />
          <xs:enumeration value="Website" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RagType" nillable="true" type="q220:RagType" xmlns:q220="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="AnswerResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q221:RagAnswer" xmlns:q221="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="RagAnswer">
        <xs:sequence>
          <xs:element minOccurs="0" name="Answer" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Source" nillable="true" type="q222:ArrayOfRagResult" xmlns:q222="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="TrackingId" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RagAnswer" nillable="true" type="q223:RagAnswer" xmlns:q223="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfRagResult">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="RagResult" nillable="true" type="q224:RagResult" xmlns:q224="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfRagResult" nillable="true" type="q225:ArrayOfRagResult" xmlns:q225="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RagResult">
        <xs:sequence>
          <xs:element minOccurs="0" name="Chunk" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Id" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Type" type="q226:RagType" xmlns:q226="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Score" type="xs:double" />
          <xs:element minOccurs="0" name="Metadata" nillable="true" type="q227:StringObjectDictionary" xmlns:q227="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RagResult" nillable="true" type="q228:RagResult" xmlns:q228="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="StringObjectDictionary">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="StringObjectKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="xs:anyType" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="StringObjectDictionary" nillable="true" type="q229:StringObjectDictionary" xmlns:q229="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="AnswerFeedback">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TrackingId" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="IsThumbsUp" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AnswerFeedbackResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="AnswerAccepted">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TrackingId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AnswerAcceptedResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="Search">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NamespaceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Query" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Type" type="q230:RagType" xmlns:q230="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="Top" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SearchResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q231:ArrayOfRagResult" xmlns:q231="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="StartRagIndexing">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NamespaceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="SourceId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="StartRagIndexingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetIndexingStatus">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NamespaceName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetIndexingStatusResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q232:RagStatus" xmlns:q232="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="RagStatus">
        <xs:sequence>
          <xs:element minOccurs="0" name="StartedAt" type="xs:dateTime" />
          <xs:element minOccurs="0" name="CompletedAt" type="xs:dateTime" />
          <xs:element minOccurs="0" name="NamespaceName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="CurrentRunTag" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="IsCompleted" type="xs:boolean" />
          <xs:element minOccurs="0" name="IsCancelled" type="xs:boolean" />
          <xs:element minOccurs="0" name="LastIndexed" type="xs:dateTime" />
          <xs:element minOccurs="0" name="StatusAll" nillable="true" type="q233:RagStatusChunks" xmlns:q233="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="StatusDocuments" nillable="true" type="q234:RagStatusChunks" xmlns:q234="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="StatusFAQ" nillable="true" type="q235:RagStatusChunks" xmlns:q235="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="StatusNone" nillable="true" type="q236:RagStatusChunks" xmlns:q236="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="StatusProduct" nillable="true" type="q237:RagStatusChunks" xmlns:q237="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="StatusTicket" nillable="true" type="q238:RagStatusChunks" xmlns:q238="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="StatusWebpage" nillable="true" type="q239:RagStatusChunks" xmlns:q239="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="StatusWebsite" nillable="true" type="q240:RagStatusChunks" xmlns:q240="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RagStatus" nillable="true" type="q241:RagStatus" xmlns:q241="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RagStatusChunks">
        <xs:sequence>
          <xs:element minOccurs="0" name="NumberOfChunks" type="xs:int" />
          <xs:element minOccurs="0" name="NumberOfDocuments" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RagStatusChunks" nillable="true" type="q242:RagStatusChunks" xmlns:q242="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="CancelIndexing">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="NamespaceName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CancelIndexingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q243:RagStatus" xmlns:q243="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
            <xs:element minOccurs="0" name="Response" nillable="true" type="q244:ChatbotTurn" xmlns:q244="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
            <xs:element minOccurs="0" name="Response" nillable="true" type="q245:ChatbotTurn" xmlns:q245="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
            <xs:element minOccurs="0" name="Response" nillable="true" type="q246:ChatbotTurn" xmlns:q246="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
  <wsdl:message name="CreateDefaultCopilotDataSourceEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultCopilotDataSourceEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCopilotDataSourceEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCopilotDataSourceEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultCopilotDataSourceEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCopilotDataSourceEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCopilotDataSourceEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveCopilotDataSourceEntity" />
  </wsdl:message>
  <wsdl:message name="SaveCopilotDataSourceEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCopilotDataSourceEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveCopilotDataSourceEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveCopilotDataSourceEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteCopilotDataSourceEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteCopilotDataSourceEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteCopilotDataSourceEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteCopilotDataSourceEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteCopilotDataSourceEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteCopilotDataSourceEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCopilotEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultCopilotEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCopilotEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCopilotEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultCopilotEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCopilotEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCopilotEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveCopilotEntity" />
  </wsdl:message>
  <wsdl:message name="SaveCopilotEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCopilotEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveCopilotEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveCopilotEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteCopilotEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteCopilotEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteCopilotEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteCopilotEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteCopilotEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteCopilotEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
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
  <wsdl:message name="AnalyzeBizCardImageRequest">
    <wsdl:part name="parameters" element="tns:AnalyzeBizCardImage" />
  </wsdl:message>
  <wsdl:message name="AnalyzeBizCardImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AnalyzeBizCardImageResponse">
    <wsdl:part name="parameters" element="tns:AnalyzeBizCardImageResponse" />
  </wsdl:message>
  <wsdl:message name="AnalyzeBizCardImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AnalyzeBizCardTextRequest">
    <wsdl:part name="parameters" element="tns:AnalyzeBizCardText" />
  </wsdl:message>
  <wsdl:message name="AnalyzeBizCardTextRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AnalyzeBizCardTextResponse">
    <wsdl:part name="parameters" element="tns:AnalyzeBizCardTextResponse" />
  </wsdl:message>
  <wsdl:message name="AnalyzeBizCardTextResponse_Headers">
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
  <wsdl:message name="GetCopilotDataSourceEntityRequest">
    <wsdl:part name="parameters" element="tns:GetCopilotDataSourceEntity" />
  </wsdl:message>
  <wsdl:message name="GetCopilotDataSourceEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCopilotDataSourceEntityResponse">
    <wsdl:part name="parameters" element="tns:GetCopilotDataSourceEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetCopilotDataSourceEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCopilotEntityRequest">
    <wsdl:part name="parameters" element="tns:GetCopilotEntity" />
  </wsdl:message>
  <wsdl:message name="GetCopilotEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCopilotEntityResponse">
    <wsdl:part name="parameters" element="tns:GetCopilotEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetCopilotEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFormDesignFromImageRequest">
    <wsdl:part name="parameters" element="tns:GetFormDesignFromImage" />
  </wsdl:message>
  <wsdl:message name="GetFormDesignFromImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFormDesignFromImageResponse">
    <wsdl:part name="parameters" element="tns:GetFormDesignFromImageResponse" />
  </wsdl:message>
  <wsdl:message name="GetFormDesignFromImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFormDesignFromUrlRequest">
    <wsdl:part name="parameters" element="tns:GetFormDesignFromUrl" />
  </wsdl:message>
  <wsdl:message name="GetFormDesignFromUrlRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFormDesignFromUrlResponse">
    <wsdl:part name="parameters" element="tns:GetFormDesignFromUrlResponse" />
  </wsdl:message>
  <wsdl:message name="GetFormDesignFromUrlResponse_Headers">
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
  <wsdl:message name="ParseQueryIntoRestrictionsRequest">
    <wsdl:part name="parameters" element="tns:ParseQueryIntoRestrictions" />
  </wsdl:message>
  <wsdl:message name="ParseQueryIntoRestrictionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ParseQueryIntoRestrictionsResponse">
    <wsdl:part name="parameters" element="tns:ParseQueryIntoRestrictionsResponse" />
  </wsdl:message>
  <wsdl:message name="ParseQueryIntoRestrictionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemovePhotoBackgroundRequest">
    <wsdl:part name="parameters" element="tns:RemovePhotoBackground" />
  </wsdl:message>
  <wsdl:message name="RemovePhotoBackgroundRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemovePhotoBackgroundResponse">
    <wsdl:part name="parameters" element="tns:RemovePhotoBackgroundResponse" />
  </wsdl:message>
  <wsdl:message name="RemovePhotoBackgroundResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AnswerRequest">
    <wsdl:part name="parameters" element="tns:Answer" />
  </wsdl:message>
  <wsdl:message name="AnswerRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AnswerResponse">
    <wsdl:part name="parameters" element="tns:AnswerResponse" />
  </wsdl:message>
  <wsdl:message name="AnswerResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AnswerFeedbackRequest">
    <wsdl:part name="parameters" element="tns:AnswerFeedback" />
  </wsdl:message>
  <wsdl:message name="AnswerFeedbackRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AnswerFeedbackResponse">
    <wsdl:part name="parameters" element="tns:AnswerFeedbackResponse" />
  </wsdl:message>
  <wsdl:message name="AnswerFeedbackResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AnswerAcceptedRequest">
    <wsdl:part name="parameters" element="tns:AnswerAccepted" />
  </wsdl:message>
  <wsdl:message name="AnswerAcceptedRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AnswerAcceptedResponse">
    <wsdl:part name="parameters" element="tns:AnswerAcceptedResponse" />
  </wsdl:message>
  <wsdl:message name="AnswerAcceptedResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SearchRequest">
    <wsdl:part name="parameters" element="tns:Search" />
  </wsdl:message>
  <wsdl:message name="SearchRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SearchResponse">
    <wsdl:part name="parameters" element="tns:SearchResponse" />
  </wsdl:message>
  <wsdl:message name="SearchResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="StartRagIndexingRequest">
    <wsdl:part name="parameters" element="tns:StartRagIndexing" />
  </wsdl:message>
  <wsdl:message name="StartRagIndexingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="StartRagIndexingResponse">
    <wsdl:part name="parameters" element="tns:StartRagIndexingResponse" />
  </wsdl:message>
  <wsdl:message name="StartRagIndexingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetIndexingStatusRequest">
    <wsdl:part name="parameters" element="tns:GetIndexingStatus" />
  </wsdl:message>
  <wsdl:message name="GetIndexingStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetIndexingStatusResponse">
    <wsdl:part name="parameters" element="tns:GetIndexingStatusResponse" />
  </wsdl:message>
  <wsdl:message name="GetIndexingStatusResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CancelIndexingRequest">
    <wsdl:part name="parameters" element="tns:CancelIndexing" />
  </wsdl:message>
  <wsdl:message name="CancelIndexingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CancelIndexingResponse">
    <wsdl:part name="parameters" element="tns:CancelIndexingResponse" />
  </wsdl:message>
  <wsdl:message name="CancelIndexingResponse_Headers">
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
    <wsdl:operation name="CreateDefaultCopilotDataSourceEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/CreateDefaultCopilotDataSourceEntity" name="CreateDefaultCopilotDataSourceEntityRequest" message="tns:CreateDefaultCopilotDataSourceEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/CreateDefaultCopilotDataSourceEntityResponse" name="CreateDefaultCopilotDataSourceEntityResponse" message="tns:CreateDefaultCopilotDataSourceEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveCopilotDataSourceEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SaveCopilotDataSourceEntity" name="SaveCopilotDataSourceEntityRequest" message="tns:SaveCopilotDataSourceEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SaveCopilotDataSourceEntityResponse" name="SaveCopilotDataSourceEntityResponse" message="tns:SaveCopilotDataSourceEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteCopilotDataSourceEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DeleteCopilotDataSourceEntity" name="DeleteCopilotDataSourceEntityRequest" message="tns:DeleteCopilotDataSourceEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DeleteCopilotDataSourceEntityResponse" name="DeleteCopilotDataSourceEntityResponse" message="tns:DeleteCopilotDataSourceEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultCopilotEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/CreateDefaultCopilotEntity" name="CreateDefaultCopilotEntityRequest" message="tns:CreateDefaultCopilotEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/CreateDefaultCopilotEntityResponse" name="CreateDefaultCopilotEntityResponse" message="tns:CreateDefaultCopilotEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveCopilotEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SaveCopilotEntity" name="SaveCopilotEntityRequest" message="tns:SaveCopilotEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SaveCopilotEntityResponse" name="SaveCopilotEntityResponse" message="tns:SaveCopilotEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteCopilotEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DeleteCopilotEntity" name="DeleteCopilotEntityRequest" message="tns:DeleteCopilotEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DeleteCopilotEntityResponse" name="DeleteCopilotEntityResponse" message="tns:DeleteCopilotEntityResponse" />
    </wsdl:operation>
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
    <wsdl:operation name="AnalyzeBizCardImage">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/AnalyzeBizCardImage" name="AnalyzeBizCardImageRequest" message="tns:AnalyzeBizCardImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/AnalyzeBizCardImageResponse" name="AnalyzeBizCardImageResponse" message="tns:AnalyzeBizCardImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="AnalyzeBizCardText">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/AnalyzeBizCardText" name="AnalyzeBizCardTextRequest" message="tns:AnalyzeBizCardTextRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/AnalyzeBizCardTextResponse" name="AnalyzeBizCardTextResponse" message="tns:AnalyzeBizCardTextResponse" />
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
    <wsdl:operation name="GetCopilotDataSourceEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetCopilotDataSourceEntity" name="GetCopilotDataSourceEntityRequest" message="tns:GetCopilotDataSourceEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetCopilotDataSourceEntityResponse" name="GetCopilotDataSourceEntityResponse" message="tns:GetCopilotDataSourceEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCopilotEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetCopilotEntity" name="GetCopilotEntityRequest" message="tns:GetCopilotEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetCopilotEntityResponse" name="GetCopilotEntityResponse" message="tns:GetCopilotEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFormDesignFromImage">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetFormDesignFromImage" name="GetFormDesignFromImageRequest" message="tns:GetFormDesignFromImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetFormDesignFromImageResponse" name="GetFormDesignFromImageResponse" message="tns:GetFormDesignFromImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFormDesignFromUrl">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetFormDesignFromUrl" name="GetFormDesignFromUrlRequest" message="tns:GetFormDesignFromUrlRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetFormDesignFromUrlResponse" name="GetFormDesignFromUrlResponse" message="tns:GetFormDesignFromUrlResponse" />
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
    <wsdl:operation name="ParseQueryIntoRestrictions">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/ParseQueryIntoRestrictions" name="ParseQueryIntoRestrictionsRequest" message="tns:ParseQueryIntoRestrictionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/ParseQueryIntoRestrictionsResponse" name="ParseQueryIntoRestrictionsResponse" message="tns:ParseQueryIntoRestrictionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemovePhotoBackground">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/RemovePhotoBackground" name="RemovePhotoBackgroundRequest" message="tns:RemovePhotoBackgroundRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/RemovePhotoBackgroundResponse" name="RemovePhotoBackgroundResponse" message="tns:RemovePhotoBackgroundResponse" />
    </wsdl:operation>
    <wsdl:operation name="Answer">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/Answer" name="AnswerRequest" message="tns:AnswerRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/AnswerResponse" name="AnswerResponse" message="tns:AnswerResponse" />
    </wsdl:operation>
    <wsdl:operation name="AnswerFeedback">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/AnswerFeedback" name="AnswerFeedbackRequest" message="tns:AnswerFeedbackRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/AnswerFeedbackResponse" name="AnswerFeedbackResponse" message="tns:AnswerFeedbackResponse" />
    </wsdl:operation>
    <wsdl:operation name="AnswerAccepted">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/AnswerAccepted" name="AnswerAcceptedRequest" message="tns:AnswerAcceptedRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/AnswerAcceptedResponse" name="AnswerAcceptedResponse" message="tns:AnswerAcceptedResponse" />
    </wsdl:operation>
    <wsdl:operation name="Search">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/Search" name="SearchRequest" message="tns:SearchRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SearchResponse" name="SearchResponse" message="tns:SearchResponse" />
    </wsdl:operation>
    <wsdl:operation name="StartRagIndexing">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/StartRagIndexing" name="StartRagIndexingRequest" message="tns:StartRagIndexingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/StartRagIndexingResponse" name="StartRagIndexingResponse" message="tns:StartRagIndexingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetIndexingStatus">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetIndexingStatus" name="GetIndexingStatusRequest" message="tns:GetIndexingStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetIndexingStatusResponse" name="GetIndexingStatusResponse" message="tns:GetIndexingStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="CancelIndexing">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/CancelIndexing" name="CancelIndexingRequest" message="tns:CancelIndexingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/CancelIndexingResponse" name="CancelIndexingResponse" message="tns:CancelIndexingResponse" />
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
    <wsdl:operation name="CreateDefaultCopilotDataSourceEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/CreateDefaultCopilotDataSourceEntity" style="document" />
      <wsdl:input name="CreateDefaultCopilotDataSourceEntityRequest">
        <soap:header message="tns:CreateDefaultCopilotDataSourceEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultCopilotDataSourceEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultCopilotDataSourceEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultCopilotDataSourceEntityResponse">
        <soap:header message="tns:CreateDefaultCopilotDataSourceEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultCopilotDataSourceEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultCopilotDataSourceEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultCopilotDataSourceEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveCopilotDataSourceEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SaveCopilotDataSourceEntity" style="document" />
      <wsdl:input name="SaveCopilotDataSourceEntityRequest">
        <soap:header message="tns:SaveCopilotDataSourceEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveCopilotDataSourceEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveCopilotDataSourceEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveCopilotDataSourceEntityResponse">
        <soap:header message="tns:SaveCopilotDataSourceEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveCopilotDataSourceEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveCopilotDataSourceEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveCopilotDataSourceEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteCopilotDataSourceEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DeleteCopilotDataSourceEntity" style="document" />
      <wsdl:input name="DeleteCopilotDataSourceEntityRequest">
        <soap:header message="tns:DeleteCopilotDataSourceEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteCopilotDataSourceEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteCopilotDataSourceEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteCopilotDataSourceEntityResponse">
        <soap:header message="tns:DeleteCopilotDataSourceEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteCopilotDataSourceEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteCopilotDataSourceEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteCopilotDataSourceEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultCopilotEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/CreateDefaultCopilotEntity" style="document" />
      <wsdl:input name="CreateDefaultCopilotEntityRequest">
        <soap:header message="tns:CreateDefaultCopilotEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultCopilotEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultCopilotEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultCopilotEntityResponse">
        <soap:header message="tns:CreateDefaultCopilotEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultCopilotEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultCopilotEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultCopilotEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveCopilotEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SaveCopilotEntity" style="document" />
      <wsdl:input name="SaveCopilotEntityRequest">
        <soap:header message="tns:SaveCopilotEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveCopilotEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveCopilotEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveCopilotEntityResponse">
        <soap:header message="tns:SaveCopilotEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveCopilotEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveCopilotEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveCopilotEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteCopilotEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DeleteCopilotEntity" style="document" />
      <wsdl:input name="DeleteCopilotEntityRequest">
        <soap:header message="tns:DeleteCopilotEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteCopilotEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteCopilotEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteCopilotEntityResponse">
        <soap:header message="tns:DeleteCopilotEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteCopilotEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteCopilotEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteCopilotEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
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
    <wsdl:operation name="AnalyzeBizCardImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/AnalyzeBizCardImage" style="document" />
      <wsdl:input name="AnalyzeBizCardImageRequest">
        <soap:header message="tns:AnalyzeBizCardImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AnalyzeBizCardImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AnalyzeBizCardImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AnalyzeBizCardImageResponse">
        <soap:header message="tns:AnalyzeBizCardImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AnalyzeBizCardImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AnalyzeBizCardImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AnalyzeBizCardImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AnalyzeBizCardText">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/AnalyzeBizCardText" style="document" />
      <wsdl:input name="AnalyzeBizCardTextRequest">
        <soap:header message="tns:AnalyzeBizCardTextRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AnalyzeBizCardTextRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AnalyzeBizCardTextRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AnalyzeBizCardTextResponse">
        <soap:header message="tns:AnalyzeBizCardTextResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AnalyzeBizCardTextResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AnalyzeBizCardTextResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AnalyzeBizCardTextResponse_Headers" part="TimeZone" use="literal" />
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
    <wsdl:operation name="GetCopilotDataSourceEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetCopilotDataSourceEntity" style="document" />
      <wsdl:input name="GetCopilotDataSourceEntityRequest">
        <soap:header message="tns:GetCopilotDataSourceEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCopilotDataSourceEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCopilotDataSourceEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCopilotDataSourceEntityResponse">
        <soap:header message="tns:GetCopilotDataSourceEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCopilotDataSourceEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCopilotDataSourceEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCopilotDataSourceEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCopilotEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetCopilotEntity" style="document" />
      <wsdl:input name="GetCopilotEntityRequest">
        <soap:header message="tns:GetCopilotEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCopilotEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCopilotEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCopilotEntityResponse">
        <soap:header message="tns:GetCopilotEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCopilotEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCopilotEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCopilotEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFormDesignFromImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetFormDesignFromImage" style="document" />
      <wsdl:input name="GetFormDesignFromImageRequest">
        <soap:header message="tns:GetFormDesignFromImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFormDesignFromImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFormDesignFromImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFormDesignFromImageResponse">
        <soap:header message="tns:GetFormDesignFromImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFormDesignFromImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFormDesignFromImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFormDesignFromImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFormDesignFromUrl">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetFormDesignFromUrl" style="document" />
      <wsdl:input name="GetFormDesignFromUrlRequest">
        <soap:header message="tns:GetFormDesignFromUrlRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFormDesignFromUrlRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFormDesignFromUrlRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFormDesignFromUrlResponse">
        <soap:header message="tns:GetFormDesignFromUrlResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFormDesignFromUrlResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFormDesignFromUrlResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFormDesignFromUrlResponse_Headers" part="TimeZone" use="literal" />
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
    <wsdl:operation name="ParseQueryIntoRestrictions">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/ParseQueryIntoRestrictions" style="document" />
      <wsdl:input name="ParseQueryIntoRestrictionsRequest">
        <soap:header message="tns:ParseQueryIntoRestrictionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ParseQueryIntoRestrictionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ParseQueryIntoRestrictionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ParseQueryIntoRestrictionsResponse">
        <soap:header message="tns:ParseQueryIntoRestrictionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ParseQueryIntoRestrictionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ParseQueryIntoRestrictionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ParseQueryIntoRestrictionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemovePhotoBackground">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/RemovePhotoBackground" style="document" />
      <wsdl:input name="RemovePhotoBackgroundRequest">
        <soap:header message="tns:RemovePhotoBackgroundRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemovePhotoBackgroundRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemovePhotoBackgroundRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemovePhotoBackgroundResponse">
        <soap:header message="tns:RemovePhotoBackgroundResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemovePhotoBackgroundResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemovePhotoBackgroundResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemovePhotoBackgroundResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Answer">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/Answer" style="document" />
      <wsdl:input name="AnswerRequest">
        <soap:header message="tns:AnswerRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AnswerRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AnswerRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AnswerResponse">
        <soap:header message="tns:AnswerResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AnswerResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AnswerResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AnswerResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AnswerFeedback">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/AnswerFeedback" style="document" />
      <wsdl:input name="AnswerFeedbackRequest">
        <soap:header message="tns:AnswerFeedbackRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AnswerFeedbackRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AnswerFeedbackRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AnswerFeedbackResponse">
        <soap:header message="tns:AnswerFeedbackResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AnswerFeedbackResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AnswerFeedbackResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AnswerFeedbackResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AnswerAccepted">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/AnswerAccepted" style="document" />
      <wsdl:input name="AnswerAcceptedRequest">
        <soap:header message="tns:AnswerAcceptedRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AnswerAcceptedRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AnswerAcceptedRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AnswerAcceptedResponse">
        <soap:header message="tns:AnswerAcceptedResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AnswerAcceptedResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AnswerAcceptedResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AnswerAcceptedResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Search">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/Search" style="document" />
      <wsdl:input name="SearchRequest">
        <soap:header message="tns:SearchRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SearchRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SearchRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SearchResponse">
        <soap:header message="tns:SearchResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SearchResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SearchResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SearchResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="StartRagIndexing">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/StartRagIndexing" style="document" />
      <wsdl:input name="StartRagIndexingRequest">
        <soap:header message="tns:StartRagIndexingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:StartRagIndexingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:StartRagIndexingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="StartRagIndexingResponse">
        <soap:header message="tns:StartRagIndexingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:StartRagIndexingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:StartRagIndexingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:StartRagIndexingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetIndexingStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetIndexingStatus" style="document" />
      <wsdl:input name="GetIndexingStatusRequest">
        <soap:header message="tns:GetIndexingStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetIndexingStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetIndexingStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetIndexingStatusResponse">
        <soap:header message="tns:GetIndexingStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetIndexingStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetIndexingStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetIndexingStatusResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CancelIndexing">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/CancelIndexing" style="document" />
      <wsdl:input name="CancelIndexingRequest">
        <soap:header message="tns:CancelIndexingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CancelIndexingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CancelIndexingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CancelIndexingResponse">
        <soap:header message="tns:CancelIndexingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CancelIndexingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CancelIndexingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CancelIndexingResponse_Headers" part="TimeZone" use="literal" />
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

