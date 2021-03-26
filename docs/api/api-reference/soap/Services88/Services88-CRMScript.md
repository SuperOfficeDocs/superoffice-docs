---
Generated: 1
TOCExclude: 1
title: Services88.CRMScriptAgent WSDL
---

# Services88.CRMScriptAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfCRMScriptService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:element name="CreateDefaultCRMScriptEntity">
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
      <xs:element name="CreateDefaultCRMScriptEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CRMScriptEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CRMScriptEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="EjscriptId" type="xs:int" />
              <xs:element minOccurs="0" name="UniqueIdentifier" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IncludeId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="HierarchyId" type="xs:int" />
              <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RegisteredAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedAssociateId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CRMScriptEntity" nillable="true" type="tns:CRMScriptEntity" />
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
      <xs:element name="SaveCRMScriptEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CRMScriptEntity" nillable="true" type="tns:CRMScriptEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCRMScriptEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CRMScriptEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteCRMScriptEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CRMScriptEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteCRMScriptEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTriggerScriptEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTriggerScriptEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TriggerScriptEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="TriggerScriptEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ScreenChooserId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ScreenType" type="tns:EventHandlerType" />
              <xs:element minOccurs="0" name="Enabled" type="xs:boolean" />
              <xs:element minOccurs="0" name="UniqueIdentifier" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RegisteredAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedAssociateId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TriggerScriptEntity" nillable="true" type="tns:TriggerScriptEntity" />
      <xs:simpleType name="EventHandlerType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="NewTicket">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">100</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="NewTicketFromCustomerCenter">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">101</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="NewTicketFromEmail">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">102</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="NewTicketFromCustomerCenterBeforeSave">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">103</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="NewTicketFromSpmLink">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">104</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="NewNotifyTicketFromForm">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">105</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="NewTicketFromForm">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">106</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TicketSave">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">109</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TicketClosed">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">110</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TicketPostponed">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">111</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TicketDeleted">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">112</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TicketActivated">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">113</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TicketReopened">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">120</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TicketReopenedFromCustomerCenter">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">121</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TicketReopenedFromEmail">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">122</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TicketChangedPriority">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">140</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TicketChangedCategory">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">141</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TicketChangedOwnedBy">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">142</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TicketChangedPrimaryCustomer">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">143</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TicketChangedTicketStatus">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">144</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TicketChangedSlevel">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">145</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TicketMessageAdded">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">150</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TicketInternalMessageAdded">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">151</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TicketExternalMessageAdded">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">152</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="TicketMessageSentimentCalculated">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">153</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="CompactModeInjection">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">200</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="CustomerCenterAuthentication">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">210</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ScheduledTaskFailed">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">300</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="DbiTaskFailed">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">301</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="CustomerSetSubscriptions">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">302</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ImportMailBeforeProcessing">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">303</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ImportMailAfterProcessing">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">304</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="MainMenu">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">305</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ChatNewSession">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">400</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ChatSessionChangedStatus">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">401</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ChatBeforeSaveNewMessage">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">402</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ChatAfterSaveNewMessage">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">403</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenNewTicketLoad">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">500</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenNewQuickTicketLoad">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">501</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenListTicketMessagesLoad">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">502</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenAddMessageLoad">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">503</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenEditTicketLoad">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">504</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenViewCustomerLoad">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">505</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenEditCustomerLoad">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">506</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenViewCompanyLoad">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">507</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenEditCompanyLoad">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">508</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenForwardLoad">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">509</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenEditExtraTableLoad">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">510</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenNewTicketBeforeSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">600</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenNewQuickTicketBeforeSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">601</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenListTicketMessagesBeforeSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">602</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenAddMessageBeforeSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">603</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenEditTicketBeforeSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">604</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenViewCustomerBeforeSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">605</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenEditCustomerBeforeSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">606</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenViewCompanyBeforeSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">607</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenEditCompanyBeforeSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">608</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenForwardBeforeSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">609</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenEditExtraTableBeforeSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">610</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenNewTicketAfterSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">700</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenNewQuickTicketAfterSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">701</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenListTicketMessagesAfterSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">702</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenAddMessageAfterSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">703</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenEditTicketAfterSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">704</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenViewCustomerAfterSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">705</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenEditCustomerAfterSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">706</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenViewCompanyAfterSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">707</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenEditCompanyAfterSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">708</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenForwardAfterSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">709</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ServiceScreenEditExtraTableAfterSubmit">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">710</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveAppointment">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1001</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveStakeholder">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1002</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveQuote">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1003</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveDocument">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1004</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveContact">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1005</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSavePerson">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1006</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveRelation">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1007</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveSale">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1008</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveProject">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1009</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveSelection">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1010</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveProjectMember">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1011</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveSelectionMember">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1012</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveQuoteLine">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1013</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveAppointment">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1101</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveStakeholder">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1102</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveQuote">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1103</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveDocument">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1104</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveContact">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1105</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSavePerson">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1106</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveRelation">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1107</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveSale">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1108</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveProject">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1109</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveSelection">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1110</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveProjectMember">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1111</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveSelectionMember">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1112</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveQuoteLine">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1113</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="EventHandlerType" nillable="true" type="tns:EventHandlerType" />
      <xs:element name="SaveTriggerScriptEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TriggerScriptEntity" nillable="true" type="tns:TriggerScriptEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTriggerScriptEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TriggerScriptEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteTriggerScriptEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TriggerScriptEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteTriggerScriptEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCRMScriptEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CRMScriptEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCRMScriptEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CRMScriptEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExecuteScript">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CRMScriptId" type="xs:int" />
            <xs:element minOccurs="0" name="Parameters" nillable="true" type="tns:StringDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
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
      <xs:element name="ExecuteScriptResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExecuteScriptByIncludeId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CRMScriptIncludeId" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Parameters" nillable="true" type="tns:StringDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExecuteScriptByIncludeIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateScript">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CRMScriptId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateScriptResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CRMScriptResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CRMScriptResult">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Valid" type="xs:boolean" />
              <xs:element minOccurs="0" name="ErrorMessage" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CRMScriptResult" nillable="true" type="tns:CRMScriptResult" />
      <xs:element name="ValidateScriptByIncludeId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CRMScriptIncludeId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateScriptByIncludeIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CRMScriptResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCRMScriptByUniqueIdentifier">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UniqueIdentifier" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCRMScriptByUniqueIdentifierResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Script" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Script">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="UniqueIdentifier" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IncludeId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RegisteredBy" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Path" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Script" nillable="true" type="tns:Script" />
      <xs:element name="SaveCRMScriptByUniqueIdentifier">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UniqueIdentifier" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Crmscript" nillable="true" type="tns:Script" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCRMScriptByUniqueIdentifierResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Script" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteCRMScriptByUniqueIdentifier">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UniqueIdentifier" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteCRMScriptByUniqueIdentifierResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTriggerScriptEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TriggerScriptEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTriggerScriptEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TriggerScriptEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTriggerScriptByUniqueId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TriggerScriptUniqueId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTriggerScriptByUniqueIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TriggerScriptEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTriggerScriptByUniqueId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TriggerScriptUniqueId" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Entity" nillable="true" type="tns:TriggerScriptEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTriggerScriptByUniqueIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TriggerScriptEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteTriggerScriptByUniqueId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TriggerScriptUniqueId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteTriggerScriptByUniqueIdResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateTriggerScript">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TriggerScriptId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateTriggerScriptResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CRMScriptResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateTriggerScriptByUniqueId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TriggerScriptUniqueId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateTriggerScriptByUniqueIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CRMScriptResult" />
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
  </wsdl:types>
  <wsdl:message name="CreateDefaultCRMScriptEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultCRMScriptEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCRMScriptEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCRMScriptEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultCRMScriptEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCRMScriptEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCRMScriptEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveCRMScriptEntity" />
  </wsdl:message>
  <wsdl:message name="SaveCRMScriptEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCRMScriptEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveCRMScriptEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveCRMScriptEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteCRMScriptEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteCRMScriptEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteCRMScriptEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteCRMScriptEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteCRMScriptEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteCRMScriptEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTriggerScriptEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTriggerScriptEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTriggerScriptEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTriggerScriptEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTriggerScriptEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTriggerScriptEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTriggerScriptEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveTriggerScriptEntity" />
  </wsdl:message>
  <wsdl:message name="SaveTriggerScriptEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTriggerScriptEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveTriggerScriptEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveTriggerScriptEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteTriggerScriptEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteTriggerScriptEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteTriggerScriptEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteTriggerScriptEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteTriggerScriptEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteTriggerScriptEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCRMScriptEntityRequest">
    <wsdl:part name="parameters" element="tns:GetCRMScriptEntity" />
  </wsdl:message>
  <wsdl:message name="GetCRMScriptEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCRMScriptEntityResponse">
    <wsdl:part name="parameters" element="tns:GetCRMScriptEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetCRMScriptEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExecuteScriptRequest">
    <wsdl:part name="parameters" element="tns:ExecuteScript" />
  </wsdl:message>
  <wsdl:message name="ExecuteScriptRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExecuteScriptResponse">
    <wsdl:part name="parameters" element="tns:ExecuteScriptResponse" />
  </wsdl:message>
  <wsdl:message name="ExecuteScriptResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExecuteScriptByIncludeIdRequest">
    <wsdl:part name="parameters" element="tns:ExecuteScriptByIncludeId" />
  </wsdl:message>
  <wsdl:message name="ExecuteScriptByIncludeIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExecuteScriptByIncludeIdResponse">
    <wsdl:part name="parameters" element="tns:ExecuteScriptByIncludeIdResponse" />
  </wsdl:message>
  <wsdl:message name="ExecuteScriptByIncludeIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateScriptRequest">
    <wsdl:part name="parameters" element="tns:ValidateScript" />
  </wsdl:message>
  <wsdl:message name="ValidateScriptRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateScriptResponse">
    <wsdl:part name="parameters" element="tns:ValidateScriptResponse" />
  </wsdl:message>
  <wsdl:message name="ValidateScriptResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateScriptByIncludeIdRequest">
    <wsdl:part name="parameters" element="tns:ValidateScriptByIncludeId" />
  </wsdl:message>
  <wsdl:message name="ValidateScriptByIncludeIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateScriptByIncludeIdResponse">
    <wsdl:part name="parameters" element="tns:ValidateScriptByIncludeIdResponse" />
  </wsdl:message>
  <wsdl:message name="ValidateScriptByIncludeIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCRMScriptByUniqueIdentifierRequest">
    <wsdl:part name="parameters" element="tns:GetCRMScriptByUniqueIdentifier" />
  </wsdl:message>
  <wsdl:message name="GetCRMScriptByUniqueIdentifierRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCRMScriptByUniqueIdentifierResponse">
    <wsdl:part name="parameters" element="tns:GetCRMScriptByUniqueIdentifierResponse" />
  </wsdl:message>
  <wsdl:message name="GetCRMScriptByUniqueIdentifierResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCRMScriptByUniqueIdentifierRequest">
    <wsdl:part name="parameters" element="tns:SaveCRMScriptByUniqueIdentifier" />
  </wsdl:message>
  <wsdl:message name="SaveCRMScriptByUniqueIdentifierRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCRMScriptByUniqueIdentifierResponse">
    <wsdl:part name="parameters" element="tns:SaveCRMScriptByUniqueIdentifierResponse" />
  </wsdl:message>
  <wsdl:message name="SaveCRMScriptByUniqueIdentifierResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteCRMScriptByUniqueIdentifierRequest">
    <wsdl:part name="parameters" element="tns:DeleteCRMScriptByUniqueIdentifier" />
  </wsdl:message>
  <wsdl:message name="DeleteCRMScriptByUniqueIdentifierRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteCRMScriptByUniqueIdentifierResponse">
    <wsdl:part name="parameters" element="tns:DeleteCRMScriptByUniqueIdentifierResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteCRMScriptByUniqueIdentifierResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTriggerScriptEntityRequest">
    <wsdl:part name="parameters" element="tns:GetTriggerScriptEntity" />
  </wsdl:message>
  <wsdl:message name="GetTriggerScriptEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTriggerScriptEntityResponse">
    <wsdl:part name="parameters" element="tns:GetTriggerScriptEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetTriggerScriptEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTriggerScriptByUniqueIdRequest">
    <wsdl:part name="parameters" element="tns:GetTriggerScriptByUniqueId" />
  </wsdl:message>
  <wsdl:message name="GetTriggerScriptByUniqueIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTriggerScriptByUniqueIdResponse">
    <wsdl:part name="parameters" element="tns:GetTriggerScriptByUniqueIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetTriggerScriptByUniqueIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTriggerScriptByUniqueIdRequest">
    <wsdl:part name="parameters" element="tns:SaveTriggerScriptByUniqueId" />
  </wsdl:message>
  <wsdl:message name="SaveTriggerScriptByUniqueIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTriggerScriptByUniqueIdResponse">
    <wsdl:part name="parameters" element="tns:SaveTriggerScriptByUniqueIdResponse" />
  </wsdl:message>
  <wsdl:message name="SaveTriggerScriptByUniqueIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteTriggerScriptByUniqueIdRequest">
    <wsdl:part name="parameters" element="tns:DeleteTriggerScriptByUniqueId" />
  </wsdl:message>
  <wsdl:message name="DeleteTriggerScriptByUniqueIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteTriggerScriptByUniqueIdResponse">
    <wsdl:part name="parameters" element="tns:DeleteTriggerScriptByUniqueIdResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteTriggerScriptByUniqueIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateTriggerScriptRequest">
    <wsdl:part name="parameters" element="tns:ValidateTriggerScript" />
  </wsdl:message>
  <wsdl:message name="ValidateTriggerScriptRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateTriggerScriptResponse">
    <wsdl:part name="parameters" element="tns:ValidateTriggerScriptResponse" />
  </wsdl:message>
  <wsdl:message name="ValidateTriggerScriptResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateTriggerScriptByUniqueIdRequest">
    <wsdl:part name="parameters" element="tns:ValidateTriggerScriptByUniqueId" />
  </wsdl:message>
  <wsdl:message name="ValidateTriggerScriptByUniqueIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateTriggerScriptByUniqueIdResponse">
    <wsdl:part name="parameters" element="tns:ValidateTriggerScriptByUniqueIdResponse" />
  </wsdl:message>
  <wsdl:message name="ValidateTriggerScriptByUniqueIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="CRMScript">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for CRMScript</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultCRMScriptEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new CRMScriptEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/CreateDefaultCRMScriptEntity" name="CreateDefaultCRMScriptEntityRequest" message="tns:CreateDefaultCRMScriptEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/CreateDefaultCRMScriptEntityResponse" name="CreateDefaultCRMScriptEntityResponse" message="tns:CreateDefaultCRMScriptEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveCRMScriptEntity">
      <wsdl:documentation>
        <summary>Updates the existing CRMScriptEntity or creates a new CRMScriptEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/SaveCRMScriptEntity" name="SaveCRMScriptEntityRequest" message="tns:SaveCRMScriptEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/SaveCRMScriptEntityResponse" name="SaveCRMScriptEntityResponse" message="tns:SaveCRMScriptEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteCRMScriptEntity">
      <wsdl:documentation>
        <summary>Deletes the CRMScriptEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/DeleteCRMScriptEntity" name="DeleteCRMScriptEntityRequest" message="tns:DeleteCRMScriptEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/DeleteCRMScriptEntityResponse" name="DeleteCRMScriptEntityResponse" message="tns:DeleteCRMScriptEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTriggerScriptEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new TriggerScriptEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/CreateDefaultTriggerScriptEntity" name="CreateDefaultTriggerScriptEntityRequest" message="tns:CreateDefaultTriggerScriptEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/CreateDefaultTriggerScriptEntityResponse" name="CreateDefaultTriggerScriptEntityResponse" message="tns:CreateDefaultTriggerScriptEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveTriggerScriptEntity">
      <wsdl:documentation>
        <summary>Updates the existing TriggerScriptEntity or creates a new TriggerScriptEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/SaveTriggerScriptEntity" name="SaveTriggerScriptEntityRequest" message="tns:SaveTriggerScriptEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/SaveTriggerScriptEntityResponse" name="SaveTriggerScriptEntityResponse" message="tns:SaveTriggerScriptEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteTriggerScriptEntity">
      <wsdl:documentation>
        <summary>Deletes the TriggerScriptEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/DeleteTriggerScriptEntity" name="DeleteTriggerScriptEntityRequest" message="tns:DeleteTriggerScriptEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/DeleteTriggerScriptEntityResponse" name="DeleteTriggerScriptEntityResponse" message="tns:DeleteTriggerScriptEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCRMScriptEntity">
      <wsdl:documentation>
        <summary>Gets a CRMScriptEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/GetCRMScriptEntity" name="GetCRMScriptEntityRequest" message="tns:GetCRMScriptEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/GetCRMScriptEntityResponse" name="GetCRMScriptEntityResponse" message="tns:GetCRMScriptEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="ExecuteScript">
      <wsdl:documentation>
        <summary>Execute a CRMScript with parameters</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/ExecuteScript" name="ExecuteScriptRequest" message="tns:ExecuteScriptRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/ExecuteScriptResponse" name="ExecuteScriptResponse" message="tns:ExecuteScriptResponse" />
    </wsdl:operation>
    <wsdl:operation name="ExecuteScriptByIncludeId">
      <wsdl:documentation>
        <summary>Execute a CRMScript with parameters</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/ExecuteScriptByIncludeId" name="ExecuteScriptByIncludeIdRequest" message="tns:ExecuteScriptByIncludeIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/ExecuteScriptByIncludeIdResponse" name="ExecuteScriptByIncludeIdResponse" message="tns:ExecuteScriptByIncludeIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="ValidateScript">
      <wsdl:documentation>
        <summary>Validate a CRMScript. This will check that the syntax is correct</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/ValidateScript" name="ValidateScriptRequest" message="tns:ValidateScriptRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/ValidateScriptResponse" name="ValidateScriptResponse" message="tns:ValidateScriptResponse" />
    </wsdl:operation>
    <wsdl:operation name="ValidateScriptByIncludeId">
      <wsdl:documentation>
        <summary>Validate a CRMScript. This will check that the syntax is correct</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/ValidateScriptByIncludeId" name="ValidateScriptByIncludeIdRequest" message="tns:ValidateScriptByIncludeIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/ValidateScriptByIncludeIdResponse" name="ValidateScriptByIncludeIdResponse" message="tns:ValidateScriptByIncludeIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCRMScriptByUniqueIdentifier">
      <wsdl:documentation>
        <summary>Get information about a script from a unique identifier</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/GetCRMScriptByUniqueIdentifier" name="GetCRMScriptByUniqueIdentifierRequest" message="tns:GetCRMScriptByUniqueIdentifierRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/GetCRMScriptByUniqueIdentifierResponse" name="GetCRMScriptByUniqueIdentifierResponse" message="tns:GetCRMScriptByUniqueIdentifierResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveCRMScriptByUniqueIdentifier">
      <wsdl:documentation>
        <summary>Create or Update the CRMScript information</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/SaveCRMScriptByUniqueIdentifier" name="SaveCRMScriptByUniqueIdentifierRequest" message="tns:SaveCRMScriptByUniqueIdentifierRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/SaveCRMScriptByUniqueIdentifierResponse" name="SaveCRMScriptByUniqueIdentifierResponse" message="tns:SaveCRMScriptByUniqueIdentifierResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteCRMScriptByUniqueIdentifier">
      <wsdl:documentation>
        <summary>Delete the CRMScript</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/DeleteCRMScriptByUniqueIdentifier" name="DeleteCRMScriptByUniqueIdentifierRequest" message="tns:DeleteCRMScriptByUniqueIdentifierRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/DeleteCRMScriptByUniqueIdentifierResponse" name="DeleteCRMScriptByUniqueIdentifierResponse" message="tns:DeleteCRMScriptByUniqueIdentifierResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTriggerScriptEntity">
      <wsdl:documentation>
        <summary>Gets a TriggerScriptEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/GetTriggerScriptEntity" name="GetTriggerScriptEntityRequest" message="tns:GetTriggerScriptEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/GetTriggerScriptEntityResponse" name="GetTriggerScriptEntityResponse" message="tns:GetTriggerScriptEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTriggerScriptByUniqueId">
      <wsdl:documentation>
        <summary>Get a trigger CRMScript.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/GetTriggerScriptByUniqueId" name="GetTriggerScriptByUniqueIdRequest" message="tns:GetTriggerScriptByUniqueIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/GetTriggerScriptByUniqueIdResponse" name="GetTriggerScriptByUniqueIdResponse" message="tns:GetTriggerScriptByUniqueIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveTriggerScriptByUniqueId">
      <wsdl:documentation>
        <summary>Validate a CRMScript. This will check that the syntax is correct</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/SaveTriggerScriptByUniqueId" name="SaveTriggerScriptByUniqueIdRequest" message="tns:SaveTriggerScriptByUniqueIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/SaveTriggerScriptByUniqueIdResponse" name="SaveTriggerScriptByUniqueIdResponse" message="tns:SaveTriggerScriptByUniqueIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteTriggerScriptByUniqueId">
      <wsdl:documentation>
        <summary>Delete a trigger CRMScript.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/DeleteTriggerScriptByUniqueId" name="DeleteTriggerScriptByUniqueIdRequest" message="tns:DeleteTriggerScriptByUniqueIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/DeleteTriggerScriptByUniqueIdResponse" name="DeleteTriggerScriptByUniqueIdResponse" message="tns:DeleteTriggerScriptByUniqueIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="ValidateTriggerScript">
      <wsdl:documentation>
        <summary>Validate a Trigger CRMScript. This will check that the syntax is correct, but not execute the script.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/ValidateTriggerScript" name="ValidateTriggerScriptRequest" message="tns:ValidateTriggerScriptRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/ValidateTriggerScriptResponse" name="ValidateTriggerScriptResponse" message="tns:ValidateTriggerScriptResponse" />
    </wsdl:operation>
    <wsdl:operation name="ValidateTriggerScriptByUniqueId">
      <wsdl:documentation>
        <summary>Validate a Trigger CRMScript. This will check that the syntax is correct, but not execute the script.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/ValidateTriggerScriptByUniqueId" name="ValidateTriggerScriptByUniqueIdRequest" message="tns:ValidateTriggerScriptByUniqueIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/ValidateTriggerScriptByUniqueIdResponse" name="ValidateTriggerScriptByUniqueIdResponse" message="tns:ValidateTriggerScriptByUniqueIdResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_CRMScript" type="tns:CRMScript">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultCRMScriptEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/CreateDefaultCRMScriptEntity" style="document" />
      <wsdl:input name="CreateDefaultCRMScriptEntityRequest">
        <soap:header message="tns:CreateDefaultCRMScriptEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultCRMScriptEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultCRMScriptEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultCRMScriptEntityResponse">
        <soap:header message="tns:CreateDefaultCRMScriptEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultCRMScriptEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultCRMScriptEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultCRMScriptEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveCRMScriptEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/SaveCRMScriptEntity" style="document" />
      <wsdl:input name="SaveCRMScriptEntityRequest">
        <soap:header message="tns:SaveCRMScriptEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveCRMScriptEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveCRMScriptEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveCRMScriptEntityResponse">
        <soap:header message="tns:SaveCRMScriptEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveCRMScriptEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveCRMScriptEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveCRMScriptEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteCRMScriptEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/DeleteCRMScriptEntity" style="document" />
      <wsdl:input name="DeleteCRMScriptEntityRequest">
        <soap:header message="tns:DeleteCRMScriptEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteCRMScriptEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteCRMScriptEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteCRMScriptEntityResponse">
        <soap:header message="tns:DeleteCRMScriptEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteCRMScriptEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteCRMScriptEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteCRMScriptEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTriggerScriptEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/CreateDefaultTriggerScriptEntity" style="document" />
      <wsdl:input name="CreateDefaultTriggerScriptEntityRequest">
        <soap:header message="tns:CreateDefaultTriggerScriptEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTriggerScriptEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTriggerScriptEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTriggerScriptEntityResponse">
        <soap:header message="tns:CreateDefaultTriggerScriptEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTriggerScriptEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTriggerScriptEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTriggerScriptEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveTriggerScriptEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/SaveTriggerScriptEntity" style="document" />
      <wsdl:input name="SaveTriggerScriptEntityRequest">
        <soap:header message="tns:SaveTriggerScriptEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveTriggerScriptEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveTriggerScriptEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveTriggerScriptEntityResponse">
        <soap:header message="tns:SaveTriggerScriptEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveTriggerScriptEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveTriggerScriptEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveTriggerScriptEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteTriggerScriptEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/DeleteTriggerScriptEntity" style="document" />
      <wsdl:input name="DeleteTriggerScriptEntityRequest">
        <soap:header message="tns:DeleteTriggerScriptEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteTriggerScriptEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteTriggerScriptEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteTriggerScriptEntityResponse">
        <soap:header message="tns:DeleteTriggerScriptEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteTriggerScriptEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteTriggerScriptEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteTriggerScriptEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCRMScriptEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/GetCRMScriptEntity" style="document" />
      <wsdl:input name="GetCRMScriptEntityRequest">
        <soap:header message="tns:GetCRMScriptEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCRMScriptEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCRMScriptEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCRMScriptEntityResponse">
        <soap:header message="tns:GetCRMScriptEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCRMScriptEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCRMScriptEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCRMScriptEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ExecuteScript">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/ExecuteScript" style="document" />
      <wsdl:input name="ExecuteScriptRequest">
        <soap:header message="tns:ExecuteScriptRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ExecuteScriptRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ExecuteScriptRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ExecuteScriptResponse">
        <soap:header message="tns:ExecuteScriptResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ExecuteScriptResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ExecuteScriptResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ExecuteScriptResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ExecuteScriptByIncludeId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/ExecuteScriptByIncludeId" style="document" />
      <wsdl:input name="ExecuteScriptByIncludeIdRequest">
        <soap:header message="tns:ExecuteScriptByIncludeIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ExecuteScriptByIncludeIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ExecuteScriptByIncludeIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ExecuteScriptByIncludeIdResponse">
        <soap:header message="tns:ExecuteScriptByIncludeIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ExecuteScriptByIncludeIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ExecuteScriptByIncludeIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ExecuteScriptByIncludeIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ValidateScript">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/ValidateScript" style="document" />
      <wsdl:input name="ValidateScriptRequest">
        <soap:header message="tns:ValidateScriptRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ValidateScriptRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ValidateScriptRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ValidateScriptResponse">
        <soap:header message="tns:ValidateScriptResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ValidateScriptResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ValidateScriptResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ValidateScriptResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ValidateScriptByIncludeId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/ValidateScriptByIncludeId" style="document" />
      <wsdl:input name="ValidateScriptByIncludeIdRequest">
        <soap:header message="tns:ValidateScriptByIncludeIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ValidateScriptByIncludeIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ValidateScriptByIncludeIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ValidateScriptByIncludeIdResponse">
        <soap:header message="tns:ValidateScriptByIncludeIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ValidateScriptByIncludeIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ValidateScriptByIncludeIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ValidateScriptByIncludeIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCRMScriptByUniqueIdentifier">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/GetCRMScriptByUniqueIdentifier" style="document" />
      <wsdl:input name="GetCRMScriptByUniqueIdentifierRequest">
        <soap:header message="tns:GetCRMScriptByUniqueIdentifierRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCRMScriptByUniqueIdentifierRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCRMScriptByUniqueIdentifierRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCRMScriptByUniqueIdentifierResponse">
        <soap:header message="tns:GetCRMScriptByUniqueIdentifierResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCRMScriptByUniqueIdentifierResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCRMScriptByUniqueIdentifierResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCRMScriptByUniqueIdentifierResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveCRMScriptByUniqueIdentifier">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/SaveCRMScriptByUniqueIdentifier" style="document" />
      <wsdl:input name="SaveCRMScriptByUniqueIdentifierRequest">
        <soap:header message="tns:SaveCRMScriptByUniqueIdentifierRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveCRMScriptByUniqueIdentifierRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveCRMScriptByUniqueIdentifierRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveCRMScriptByUniqueIdentifierResponse">
        <soap:header message="tns:SaveCRMScriptByUniqueIdentifierResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveCRMScriptByUniqueIdentifierResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveCRMScriptByUniqueIdentifierResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveCRMScriptByUniqueIdentifierResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteCRMScriptByUniqueIdentifier">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/DeleteCRMScriptByUniqueIdentifier" style="document" />
      <wsdl:input name="DeleteCRMScriptByUniqueIdentifierRequest">
        <soap:header message="tns:DeleteCRMScriptByUniqueIdentifierRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteCRMScriptByUniqueIdentifierRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteCRMScriptByUniqueIdentifierRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteCRMScriptByUniqueIdentifierResponse">
        <soap:header message="tns:DeleteCRMScriptByUniqueIdentifierResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteCRMScriptByUniqueIdentifierResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteCRMScriptByUniqueIdentifierResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteCRMScriptByUniqueIdentifierResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTriggerScriptEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/GetTriggerScriptEntity" style="document" />
      <wsdl:input name="GetTriggerScriptEntityRequest">
        <soap:header message="tns:GetTriggerScriptEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTriggerScriptEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTriggerScriptEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTriggerScriptEntityResponse">
        <soap:header message="tns:GetTriggerScriptEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTriggerScriptEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTriggerScriptEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTriggerScriptEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTriggerScriptByUniqueId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/GetTriggerScriptByUniqueId" style="document" />
      <wsdl:input name="GetTriggerScriptByUniqueIdRequest">
        <soap:header message="tns:GetTriggerScriptByUniqueIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTriggerScriptByUniqueIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTriggerScriptByUniqueIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTriggerScriptByUniqueIdResponse">
        <soap:header message="tns:GetTriggerScriptByUniqueIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTriggerScriptByUniqueIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTriggerScriptByUniqueIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTriggerScriptByUniqueIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveTriggerScriptByUniqueId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/SaveTriggerScriptByUniqueId" style="document" />
      <wsdl:input name="SaveTriggerScriptByUniqueIdRequest">
        <soap:header message="tns:SaveTriggerScriptByUniqueIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveTriggerScriptByUniqueIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveTriggerScriptByUniqueIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveTriggerScriptByUniqueIdResponse">
        <soap:header message="tns:SaveTriggerScriptByUniqueIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveTriggerScriptByUniqueIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveTriggerScriptByUniqueIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveTriggerScriptByUniqueIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteTriggerScriptByUniqueId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/DeleteTriggerScriptByUniqueId" style="document" />
      <wsdl:input name="DeleteTriggerScriptByUniqueIdRequest">
        <soap:header message="tns:DeleteTriggerScriptByUniqueIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteTriggerScriptByUniqueIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteTriggerScriptByUniqueIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteTriggerScriptByUniqueIdResponse">
        <soap:header message="tns:DeleteTriggerScriptByUniqueIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteTriggerScriptByUniqueIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteTriggerScriptByUniqueIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteTriggerScriptByUniqueIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ValidateTriggerScript">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/ValidateTriggerScript" style="document" />
      <wsdl:input name="ValidateTriggerScriptRequest">
        <soap:header message="tns:ValidateTriggerScriptRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ValidateTriggerScriptRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ValidateTriggerScriptRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ValidateTriggerScriptResponse">
        <soap:header message="tns:ValidateTriggerScriptResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ValidateTriggerScriptResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ValidateTriggerScriptResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ValidateTriggerScriptResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ValidateTriggerScriptByUniqueId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CRMScript/ValidateTriggerScriptByUniqueId" style="document" />
      <wsdl:input name="ValidateTriggerScriptByUniqueIdRequest">
        <soap:header message="tns:ValidateTriggerScriptByUniqueIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ValidateTriggerScriptByUniqueIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ValidateTriggerScriptByUniqueIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ValidateTriggerScriptByUniqueIdResponse">
        <soap:header message="tns:ValidateTriggerScriptByUniqueIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ValidateTriggerScriptByUniqueIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ValidateTriggerScriptByUniqueIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ValidateTriggerScriptByUniqueIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfCRMScriptService">
    <wsdl:port name="BasicHttpBinding_CRMScript" binding="tns:BasicHttpBinding_CRMScript">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/CRMScript.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

