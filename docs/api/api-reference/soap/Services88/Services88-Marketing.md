---
Generated: 1
TOCExclude: 1
title: Services88.MarketingAgent WSDL
---

# Services88.MarketingAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfMarketingService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:element name="CreateDefaultFormEntity">
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
      <xs:element name="CreateDefaultFormEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FormEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="FormEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="FormId" type="xs:int" />
              <xs:element minOccurs="0" name="FormKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Config" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FolderId" type="xs:int" />
              <xs:element minOccurs="0" name="ScriptId" type="xs:int" />
              <xs:element minOccurs="0" name="ResponseShipmentId" type="xs:int" />
              <xs:element minOccurs="0" name="Active" type="xs:boolean" />
              <xs:element minOccurs="0" name="Expires" type="xs:dateTime" />
              <xs:element minOccurs="0" name="MaxSubmits" type="xs:int" />
              <xs:element minOccurs="0" name="Type" type="tns:FormType" />
              <xs:element minOccurs="0" name="Recipe" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="GroupId" type="xs:int" />
              <xs:element minOccurs="0" name="NewTicket" type="xs:boolean" />
              <xs:element minOccurs="0" name="RecaptchaMode" type="tns:FormsRecaptchaMode" />
              <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RegisteredAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="UpdatedCount" type="xs:short" />
              <xs:element minOccurs="0" name="FolderName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="FormEntity" nillable="true" type="tns:FormEntity" />
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
      <xs:simpleType name="FormType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Normal" />
          <xs:enumeration value="Template" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="FormType" nillable="true" type="tns:FormType" />
      <xs:simpleType name="FormsRecaptchaMode">
        <xs:restriction base="xs:string">
          <xs:enumeration value="NotAvailable" />
          <xs:enumeration value="GlobalKeysExist" />
          <xs:enumeration value="KeysNeeded" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="FormsRecaptchaMode" nillable="true" type="tns:FormsRecaptchaMode" />
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
      <xs:element name="SaveFormEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FormEntity" nillable="true" type="tns:FormEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveFormEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FormEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteFormEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FormEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteFormEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultFormSubmissionEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultFormSubmissionEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FormSubmissionEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="FormSubmissionEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="FormSubmissionId" type="xs:int" />
              <xs:element minOccurs="0" name="FormId" type="xs:int" />
              <xs:element minOccurs="0" name="WhenSubmitted" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ResponseShipmentAddrId" type="xs:int" />
              <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Status" type="tns:FormSubmissionStatus" />
              <xs:element minOccurs="0" name="ProcessingLog" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="FormSubmissionEntity" nillable="true" type="tns:FormSubmissionEntity" />
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
      <xs:element name="SaveFormSubmissionEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FormSubmissionEntity" nillable="true" type="tns:FormSubmissionEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveFormSubmissionEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FormSubmissionEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteFormSubmissionEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FormSubmissionEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteFormSubmissionEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultShipmentMessageEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultShipmentMessageEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ShipmentMessageEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ShipmentMessageEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ShipmentMessageId" type="xs:int" />
              <xs:element minOccurs="0" name="PlainMessage" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="HtmlMessage" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SmsMessage" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Subject" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FolderId" type="xs:int" />
              <xs:element minOccurs="0" name="HeaderField" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Design" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Designtype" type="tns:DesignType" />
              <xs:element minOccurs="0" name="Flags" type="tns:ShipmentMessageType" />
              <xs:element minOccurs="0" name="RegisterViews" type="xs:boolean" />
              <xs:element minOccurs="0" name="InlineImages" type="xs:boolean" />
              <xs:element minOccurs="0" name="LongDescription" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AccessKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DocumentMessage" type="xs:int" />
              <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RegisteredAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="UpdatedCount" type="xs:short" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ShipmentMessageEntity" nillable="true" type="tns:ShipmentMessageEntity" />
      <xs:simpleType name="DesignType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="SOEditor" />
          <xs:enumeration value="Unlayer" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="DesignType" nillable="true" type="tns:DesignType" />
      <xs:simpleType name="ShipmentMessageType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="Html" />
              <xs:enumeration value="SourceView" />
              <xs:enumeration value="Sms" />
              <xs:enumeration value="Document" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="ShipmentMessageType" nillable="true" type="tns:ShipmentMessageType" />
      <xs:element name="SaveShipmentMessageEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ShipmentMessageEntity" nillable="true" type="tns:ShipmentMessageEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveShipmentMessageEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ShipmentMessageEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteShipmentMessageEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ShipmentMessageEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteShipmentMessageEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultShipmentMessageBlockEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultShipmentMessageBlockEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ShipmentMessageBlockEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ShipmentMessageBlockEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ShipmentMessageBlockId" type="xs:int" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Block" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RegisteredAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="UpdatedCount" type="xs:short" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ShipmentMessageBlockEntity" nillable="true" type="tns:ShipmentMessageBlockEntity" />
      <xs:element name="SaveShipmentMessageBlockEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ShipmentMessageBlockEntity" nillable="true" type="tns:ShipmentMessageBlockEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveShipmentMessageBlockEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ShipmentMessageBlockEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteShipmentMessageBlockEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ShipmentMessageBlockEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteShipmentMessageBlockEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFormEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FormEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFormEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FormEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="VerifyGoogleRecaptcha">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Token" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="OptionalSecretKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="VerifyGoogleRecaptchaResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFormSubmissionEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FormSubmissionEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFormSubmissionEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FormSubmissionEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetShipmentMessageEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ShipmentMessageEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetShipmentMessageEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ShipmentMessageEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetShipmentMessageBlockEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ShipmentMessageBlockEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetShipmentMessageBlockEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ShipmentMessageBlockEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserBlocks">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserBlocksResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfShipmentMessageBlockEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfShipmentMessageBlockEntity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ShipmentMessageBlockEntity" nillable="true" type="tns:ShipmentMessageBlockEntity" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfShipmentMessageBlockEntity" nillable="true" type="tns:ArrayOfShipmentMessageBlockEntity" />
      <xs:element name="GetPreviewMailing">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ShipmentAddrId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreviewMailingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PreviewMailing" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="PreviewMailing">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="SendingTime" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Status" type="tns:ShipmentAddrStatus" />
              <xs:element minOccurs="0" name="ShipmentId" type="xs:int" />
              <xs:element minOccurs="0" name="ShipmentDescription" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FromAddress" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ShipmentType" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MessageId" type="xs:int" />
              <xs:element minOccurs="0" name="MessageSubject" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DocumentMessage" type="xs:int" />
              <xs:element minOccurs="0" name="Opened" type="xs:dateTime" />
              <xs:element minOccurs="0" name="LinkClicks" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PreviewMailing" nillable="true" type="tns:PreviewMailing" />
      <xs:simpleType name="ShipmentAddrStatus">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Ready" />
          <xs:enumeration value="Duplicate" />
          <xs:enumeration value="Blocked" />
          <xs:enumeration value="Sent" />
          <xs:enumeration value="Bounced" />
          <xs:enumeration value="Opened" />
          <xs:enumeration value="Clicked" />
          <xs:enumeration value="SoftBounced" />
          <xs:enumeration value="NoSubscription" />
          <xs:enumeration value="Complained" />
          <xs:enumeration value="TooManyBounces" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ShipmentAddrStatus" nillable="true" type="tns:ShipmentAddrStatus" />
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
  </wsdl:types>
  <wsdl:message name="CreateDefaultFormEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultFormEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultFormEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultFormEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultFormEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultFormEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveFormEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveFormEntity" />
  </wsdl:message>
  <wsdl:message name="SaveFormEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveFormEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveFormEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveFormEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteFormEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteFormEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteFormEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteFormEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteFormEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteFormEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultFormSubmissionEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultFormSubmissionEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultFormSubmissionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultFormSubmissionEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultFormSubmissionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultFormSubmissionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveFormSubmissionEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveFormSubmissionEntity" />
  </wsdl:message>
  <wsdl:message name="SaveFormSubmissionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveFormSubmissionEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveFormSubmissionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveFormSubmissionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteFormSubmissionEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteFormSubmissionEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteFormSubmissionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteFormSubmissionEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteFormSubmissionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteFormSubmissionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultShipmentMessageEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultShipmentMessageEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultShipmentMessageEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultShipmentMessageEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultShipmentMessageEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultShipmentMessageEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveShipmentMessageEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveShipmentMessageEntity" />
  </wsdl:message>
  <wsdl:message name="SaveShipmentMessageEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveShipmentMessageEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveShipmentMessageEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveShipmentMessageEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteShipmentMessageEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteShipmentMessageEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteShipmentMessageEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteShipmentMessageEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteShipmentMessageEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteShipmentMessageEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultShipmentMessageBlockEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultShipmentMessageBlockEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultShipmentMessageBlockEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultShipmentMessageBlockEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultShipmentMessageBlockEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultShipmentMessageBlockEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveShipmentMessageBlockEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveShipmentMessageBlockEntity" />
  </wsdl:message>
  <wsdl:message name="SaveShipmentMessageBlockEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveShipmentMessageBlockEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveShipmentMessageBlockEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveShipmentMessageBlockEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteShipmentMessageBlockEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteShipmentMessageBlockEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteShipmentMessageBlockEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteShipmentMessageBlockEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteShipmentMessageBlockEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteShipmentMessageBlockEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFormEntityRequest">
    <wsdl:part name="parameters" element="tns:GetFormEntity" />
  </wsdl:message>
  <wsdl:message name="GetFormEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFormEntityResponse">
    <wsdl:part name="parameters" element="tns:GetFormEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetFormEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="VerifyGoogleRecaptchaRequest">
    <wsdl:part name="parameters" element="tns:VerifyGoogleRecaptcha" />
  </wsdl:message>
  <wsdl:message name="VerifyGoogleRecaptchaRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="VerifyGoogleRecaptchaResponse">
    <wsdl:part name="parameters" element="tns:VerifyGoogleRecaptchaResponse" />
  </wsdl:message>
  <wsdl:message name="VerifyGoogleRecaptchaResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFormSubmissionEntityRequest">
    <wsdl:part name="parameters" element="tns:GetFormSubmissionEntity" />
  </wsdl:message>
  <wsdl:message name="GetFormSubmissionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFormSubmissionEntityResponse">
    <wsdl:part name="parameters" element="tns:GetFormSubmissionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetFormSubmissionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetShipmentMessageEntityRequest">
    <wsdl:part name="parameters" element="tns:GetShipmentMessageEntity" />
  </wsdl:message>
  <wsdl:message name="GetShipmentMessageEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetShipmentMessageEntityResponse">
    <wsdl:part name="parameters" element="tns:GetShipmentMessageEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetShipmentMessageEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetShipmentMessageBlockEntityRequest">
    <wsdl:part name="parameters" element="tns:GetShipmentMessageBlockEntity" />
  </wsdl:message>
  <wsdl:message name="GetShipmentMessageBlockEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetShipmentMessageBlockEntityResponse">
    <wsdl:part name="parameters" element="tns:GetShipmentMessageBlockEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetShipmentMessageBlockEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserBlocksRequest">
    <wsdl:part name="parameters" element="tns:GetUserBlocks" />
  </wsdl:message>
  <wsdl:message name="GetUserBlocksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserBlocksResponse">
    <wsdl:part name="parameters" element="tns:GetUserBlocksResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserBlocksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreviewMailingRequest">
    <wsdl:part name="parameters" element="tns:GetPreviewMailing" />
  </wsdl:message>
  <wsdl:message name="GetPreviewMailingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreviewMailingResponse">
    <wsdl:part name="parameters" element="tns:GetPreviewMailingResponse" />
  </wsdl:message>
  <wsdl:message name="GetPreviewMailingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Marketing">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Marketing</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultFormEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new FormEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/CreateDefaultFormEntity" name="CreateDefaultFormEntityRequest" message="tns:CreateDefaultFormEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/CreateDefaultFormEntityResponse" name="CreateDefaultFormEntityResponse" message="tns:CreateDefaultFormEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveFormEntity">
      <wsdl:documentation>
        <summary>Updates the existing FormEntity or creates a new FormEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/SaveFormEntity" name="SaveFormEntityRequest" message="tns:SaveFormEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/SaveFormEntityResponse" name="SaveFormEntityResponse" message="tns:SaveFormEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteFormEntity">
      <wsdl:documentation>
        <summary>Deletes the FormEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/DeleteFormEntity" name="DeleteFormEntityRequest" message="tns:DeleteFormEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/DeleteFormEntityResponse" name="DeleteFormEntityResponse" message="tns:DeleteFormEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultFormSubmissionEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new FormSubmissionEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/CreateDefaultFormSubmissionEntity" name="CreateDefaultFormSubmissionEntityRequest" message="tns:CreateDefaultFormSubmissionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/CreateDefaultFormSubmissionEntityResponse" name="CreateDefaultFormSubmissionEntityResponse" message="tns:CreateDefaultFormSubmissionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveFormSubmissionEntity">
      <wsdl:documentation>
        <summary>Updates the existing FormSubmissionEntity or creates a new FormSubmissionEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/SaveFormSubmissionEntity" name="SaveFormSubmissionEntityRequest" message="tns:SaveFormSubmissionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/SaveFormSubmissionEntityResponse" name="SaveFormSubmissionEntityResponse" message="tns:SaveFormSubmissionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteFormSubmissionEntity">
      <wsdl:documentation>
        <summary>Deletes the FormSubmissionEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/DeleteFormSubmissionEntity" name="DeleteFormSubmissionEntityRequest" message="tns:DeleteFormSubmissionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/DeleteFormSubmissionEntityResponse" name="DeleteFormSubmissionEntityResponse" message="tns:DeleteFormSubmissionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultShipmentMessageEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new ShipmentMessageEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/CreateDefaultShipmentMessageEntity" name="CreateDefaultShipmentMessageEntityRequest" message="tns:CreateDefaultShipmentMessageEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/CreateDefaultShipmentMessageEntityResponse" name="CreateDefaultShipmentMessageEntityResponse" message="tns:CreateDefaultShipmentMessageEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveShipmentMessageEntity">
      <wsdl:documentation>
        <summary>Updates the existing ShipmentMessageEntity or creates a new ShipmentMessageEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/SaveShipmentMessageEntity" name="SaveShipmentMessageEntityRequest" message="tns:SaveShipmentMessageEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/SaveShipmentMessageEntityResponse" name="SaveShipmentMessageEntityResponse" message="tns:SaveShipmentMessageEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteShipmentMessageEntity">
      <wsdl:documentation>
        <summary>Deletes the ShipmentMessageEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/DeleteShipmentMessageEntity" name="DeleteShipmentMessageEntityRequest" message="tns:DeleteShipmentMessageEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/DeleteShipmentMessageEntityResponse" name="DeleteShipmentMessageEntityResponse" message="tns:DeleteShipmentMessageEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultShipmentMessageBlockEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new ShipmentMessageBlockEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/CreateDefaultShipmentMessageBlockEntity" name="CreateDefaultShipmentMessageBlockEntityRequest" message="tns:CreateDefaultShipmentMessageBlockEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/CreateDefaultShipmentMessageBlockEntityResponse" name="CreateDefaultShipmentMessageBlockEntityResponse" message="tns:CreateDefaultShipmentMessageBlockEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveShipmentMessageBlockEntity">
      <wsdl:documentation>
        <summary>Updates the existing ShipmentMessageBlockEntity or creates a new ShipmentMessageBlockEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/SaveShipmentMessageBlockEntity" name="SaveShipmentMessageBlockEntityRequest" message="tns:SaveShipmentMessageBlockEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/SaveShipmentMessageBlockEntityResponse" name="SaveShipmentMessageBlockEntityResponse" message="tns:SaveShipmentMessageBlockEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteShipmentMessageBlockEntity">
      <wsdl:documentation>
        <summary>Deletes the ShipmentMessageBlockEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/DeleteShipmentMessageBlockEntity" name="DeleteShipmentMessageBlockEntityRequest" message="tns:DeleteShipmentMessageBlockEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/DeleteShipmentMessageBlockEntityResponse" name="DeleteShipmentMessageBlockEntityResponse" message="tns:DeleteShipmentMessageBlockEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFormEntity">
      <wsdl:documentation>
        <summary>Gets a FormEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/GetFormEntity" name="GetFormEntityRequest" message="tns:GetFormEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/GetFormEntityResponse" name="GetFormEntityResponse" message="tns:GetFormEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="VerifyGoogleRecaptcha">
      <wsdl:documentation>
        <summary>This method will try to verify a Google recaptcha token. The token is gained from the recaptcha frontend component</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/VerifyGoogleRecaptcha" name="VerifyGoogleRecaptchaRequest" message="tns:VerifyGoogleRecaptchaRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/VerifyGoogleRecaptchaResponse" name="VerifyGoogleRecaptchaResponse" message="tns:VerifyGoogleRecaptchaResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFormSubmissionEntity">
      <wsdl:documentation>
        <summary>Gets a FormSubmissionEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/GetFormSubmissionEntity" name="GetFormSubmissionEntityRequest" message="tns:GetFormSubmissionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/GetFormSubmissionEntityResponse" name="GetFormSubmissionEntityResponse" message="tns:GetFormSubmissionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetShipmentMessageEntity">
      <wsdl:documentation>
        <summary>Gets a ShipmentMessageEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/GetShipmentMessageEntity" name="GetShipmentMessageEntityRequest" message="tns:GetShipmentMessageEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/GetShipmentMessageEntityResponse" name="GetShipmentMessageEntityResponse" message="tns:GetShipmentMessageEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetShipmentMessageBlockEntity">
      <wsdl:documentation>
        <summary>Gets a ShipmentMessageBlockEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/GetShipmentMessageBlockEntity" name="GetShipmentMessageBlockEntityRequest" message="tns:GetShipmentMessageBlockEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/GetShipmentMessageBlockEntityResponse" name="GetShipmentMessageBlockEntityResponse" message="tns:GetShipmentMessageBlockEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserBlocks">
      <wsdl:documentation>
        <summary>Get the saved user blocks to be used in a shipment/mailing message</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/GetUserBlocks" name="GetUserBlocksRequest" message="tns:GetUserBlocksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/GetUserBlocksResponse" name="GetUserBlocksResponse" message="tns:GetUserBlocksResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPreviewMailing">
      <wsdl:documentation>
        <summary>Get a shipment message from its shipment address id</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/GetPreviewMailing" name="GetPreviewMailingRequest" message="tns:GetPreviewMailingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/GetPreviewMailingResponse" name="GetPreviewMailingResponse" message="tns:GetPreviewMailingResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Marketing" type="tns:Marketing">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultFormEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/CreateDefaultFormEntity" style="document" />
      <wsdl:input name="CreateDefaultFormEntityRequest">
        <soap:header message="tns:CreateDefaultFormEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultFormEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultFormEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultFormEntityResponse">
        <soap:header message="tns:CreateDefaultFormEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultFormEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultFormEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultFormEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveFormEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/SaveFormEntity" style="document" />
      <wsdl:input name="SaveFormEntityRequest">
        <soap:header message="tns:SaveFormEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveFormEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveFormEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveFormEntityResponse">
        <soap:header message="tns:SaveFormEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveFormEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveFormEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveFormEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteFormEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/DeleteFormEntity" style="document" />
      <wsdl:input name="DeleteFormEntityRequest">
        <soap:header message="tns:DeleteFormEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteFormEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteFormEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteFormEntityResponse">
        <soap:header message="tns:DeleteFormEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteFormEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteFormEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteFormEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultFormSubmissionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/CreateDefaultFormSubmissionEntity" style="document" />
      <wsdl:input name="CreateDefaultFormSubmissionEntityRequest">
        <soap:header message="tns:CreateDefaultFormSubmissionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultFormSubmissionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultFormSubmissionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultFormSubmissionEntityResponse">
        <soap:header message="tns:CreateDefaultFormSubmissionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultFormSubmissionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultFormSubmissionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultFormSubmissionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveFormSubmissionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/SaveFormSubmissionEntity" style="document" />
      <wsdl:input name="SaveFormSubmissionEntityRequest">
        <soap:header message="tns:SaveFormSubmissionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveFormSubmissionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveFormSubmissionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveFormSubmissionEntityResponse">
        <soap:header message="tns:SaveFormSubmissionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveFormSubmissionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveFormSubmissionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveFormSubmissionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteFormSubmissionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/DeleteFormSubmissionEntity" style="document" />
      <wsdl:input name="DeleteFormSubmissionEntityRequest">
        <soap:header message="tns:DeleteFormSubmissionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteFormSubmissionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteFormSubmissionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteFormSubmissionEntityResponse">
        <soap:header message="tns:DeleteFormSubmissionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteFormSubmissionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteFormSubmissionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteFormSubmissionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultShipmentMessageEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/CreateDefaultShipmentMessageEntity" style="document" />
      <wsdl:input name="CreateDefaultShipmentMessageEntityRequest">
        <soap:header message="tns:CreateDefaultShipmentMessageEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultShipmentMessageEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultShipmentMessageEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultShipmentMessageEntityResponse">
        <soap:header message="tns:CreateDefaultShipmentMessageEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultShipmentMessageEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultShipmentMessageEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultShipmentMessageEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveShipmentMessageEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/SaveShipmentMessageEntity" style="document" />
      <wsdl:input name="SaveShipmentMessageEntityRequest">
        <soap:header message="tns:SaveShipmentMessageEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveShipmentMessageEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveShipmentMessageEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveShipmentMessageEntityResponse">
        <soap:header message="tns:SaveShipmentMessageEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveShipmentMessageEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveShipmentMessageEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveShipmentMessageEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteShipmentMessageEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/DeleteShipmentMessageEntity" style="document" />
      <wsdl:input name="DeleteShipmentMessageEntityRequest">
        <soap:header message="tns:DeleteShipmentMessageEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteShipmentMessageEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteShipmentMessageEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteShipmentMessageEntityResponse">
        <soap:header message="tns:DeleteShipmentMessageEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteShipmentMessageEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteShipmentMessageEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteShipmentMessageEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultShipmentMessageBlockEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/CreateDefaultShipmentMessageBlockEntity" style="document" />
      <wsdl:input name="CreateDefaultShipmentMessageBlockEntityRequest">
        <soap:header message="tns:CreateDefaultShipmentMessageBlockEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultShipmentMessageBlockEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultShipmentMessageBlockEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultShipmentMessageBlockEntityResponse">
        <soap:header message="tns:CreateDefaultShipmentMessageBlockEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultShipmentMessageBlockEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultShipmentMessageBlockEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultShipmentMessageBlockEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveShipmentMessageBlockEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/SaveShipmentMessageBlockEntity" style="document" />
      <wsdl:input name="SaveShipmentMessageBlockEntityRequest">
        <soap:header message="tns:SaveShipmentMessageBlockEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveShipmentMessageBlockEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveShipmentMessageBlockEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveShipmentMessageBlockEntityResponse">
        <soap:header message="tns:SaveShipmentMessageBlockEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveShipmentMessageBlockEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveShipmentMessageBlockEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveShipmentMessageBlockEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteShipmentMessageBlockEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/DeleteShipmentMessageBlockEntity" style="document" />
      <wsdl:input name="DeleteShipmentMessageBlockEntityRequest">
        <soap:header message="tns:DeleteShipmentMessageBlockEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteShipmentMessageBlockEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteShipmentMessageBlockEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteShipmentMessageBlockEntityResponse">
        <soap:header message="tns:DeleteShipmentMessageBlockEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteShipmentMessageBlockEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteShipmentMessageBlockEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteShipmentMessageBlockEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFormEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/GetFormEntity" style="document" />
      <wsdl:input name="GetFormEntityRequest">
        <soap:header message="tns:GetFormEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFormEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFormEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFormEntityResponse">
        <soap:header message="tns:GetFormEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFormEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFormEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFormEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="VerifyGoogleRecaptcha">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/VerifyGoogleRecaptcha" style="document" />
      <wsdl:input name="VerifyGoogleRecaptchaRequest">
        <soap:header message="tns:VerifyGoogleRecaptchaRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:VerifyGoogleRecaptchaRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:VerifyGoogleRecaptchaRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="VerifyGoogleRecaptchaResponse">
        <soap:header message="tns:VerifyGoogleRecaptchaResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:VerifyGoogleRecaptchaResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:VerifyGoogleRecaptchaResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:VerifyGoogleRecaptchaResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFormSubmissionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/GetFormSubmissionEntity" style="document" />
      <wsdl:input name="GetFormSubmissionEntityRequest">
        <soap:header message="tns:GetFormSubmissionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFormSubmissionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFormSubmissionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFormSubmissionEntityResponse">
        <soap:header message="tns:GetFormSubmissionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFormSubmissionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFormSubmissionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFormSubmissionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetShipmentMessageEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/GetShipmentMessageEntity" style="document" />
      <wsdl:input name="GetShipmentMessageEntityRequest">
        <soap:header message="tns:GetShipmentMessageEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetShipmentMessageEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetShipmentMessageEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetShipmentMessageEntityResponse">
        <soap:header message="tns:GetShipmentMessageEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetShipmentMessageEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetShipmentMessageEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetShipmentMessageEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetShipmentMessageBlockEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/GetShipmentMessageBlockEntity" style="document" />
      <wsdl:input name="GetShipmentMessageBlockEntityRequest">
        <soap:header message="tns:GetShipmentMessageBlockEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetShipmentMessageBlockEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetShipmentMessageBlockEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetShipmentMessageBlockEntityResponse">
        <soap:header message="tns:GetShipmentMessageBlockEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetShipmentMessageBlockEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetShipmentMessageBlockEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetShipmentMessageBlockEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserBlocks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/GetUserBlocks" style="document" />
      <wsdl:input name="GetUserBlocksRequest">
        <soap:header message="tns:GetUserBlocksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserBlocksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserBlocksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserBlocksResponse">
        <soap:header message="tns:GetUserBlocksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserBlocksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserBlocksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserBlocksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPreviewMailing">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Marketing/GetPreviewMailing" style="document" />
      <wsdl:input name="GetPreviewMailingRequest">
        <soap:header message="tns:GetPreviewMailingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPreviewMailingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPreviewMailingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPreviewMailingResponse">
        <soap:header message="tns:GetPreviewMailingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPreviewMailingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPreviewMailingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPreviewMailingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfMarketingService">
    <wsdl:port name="BasicHttpBinding_Marketing" binding="tns:BasicHttpBinding_Marketing">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/Marketing.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

