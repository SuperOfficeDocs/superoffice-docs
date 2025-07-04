---
generated: true
uid: wsdl-Services88-CustomerService
title: Services88.CustomerServiceAgent WSDL
---

# Services88.CustomerServiceAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfCustomerServiceService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultCustomerCenterConfig">
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
      <xs:element name="CreateDefaultCustomerCenterConfigResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CustomerCenterConfig" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CustomerCenterConfig">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="CustConfigId" type="xs:int" />
              <xs:element minOccurs="0" name="Type" type="tns:ConfigType" />
              <xs:element minOccurs="0" name="Config" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CustLangId" type="xs:int" />
              <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RegisteredAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedAssociateId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CustomerCenterConfig" nillable="true" type="tns:CustomerCenterConfig" />
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
      <xs:simpleType name="ConfigType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Style" />
          <xs:enumeration value="Options" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ConfigType" nillable="true" type="tns:ConfigType" />
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
      <xs:element name="SaveCustomerCenterConfig">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CustomerCenterConfig" nillable="true" type="tns:CustomerCenterConfig" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveCustomerCenterConfigResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CustomerCenterConfig" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteCustomerCenterConfig">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CustomerCenterConfigId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteCustomerCenterConfigResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultMailboxEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultMailboxEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:MailboxEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="MailboxEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="MailInFilterId" type="xs:int" />
              <xs:element minOccurs="0" name="ServerType" type="tns:MailboxType" />
              <xs:element minOccurs="0" name="Address" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Username" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Password" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Server" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Port" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="MailboxEntity" nillable="true" type="tns:MailboxEntity" />
      <xs:simpleType name="MailboxType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Pop" />
          <xs:enumeration value="Imap" />
          <xs:enumeration value="Mapi" />
          <xs:enumeration value="Facebook" />
          <xs:enumeration value="Pops" />
          <xs:enumeration value="Imaps" />
          <xs:enumeration value="SmsPlugin" />
          <xs:enumeration value="Mailgun" />
          <xs:enumeration value="ImapOAuth" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="MailboxType" nillable="true" type="tns:MailboxType" />
      <xs:element name="SaveMailboxEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MailboxEntity" nillable="true" type="tns:MailboxEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveMailboxEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:MailboxEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteChatSessions">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Ids" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteChatSessionsResponse">
        <xs:complexType>
          <xs:sequence />
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
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfChatSession" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfChatSession">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ChatSession" nillable="true" type="tns:ChatSession" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfChatSession" nillable="true" type="tns:ArrayOfChatSession" />
      <xs:complexType name="ChatSession">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ChatSessionId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ChatSession" nillable="true" type="tns:ChatSession" />
      <xs:element name="UpdateFeatureToggles">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FeatureToggles" nillable="true" type="tns:ArrayOfCsFeatureToggle" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfCsFeatureToggle">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="CsFeatureToggle" nillable="true" type="tns:CsFeatureToggle" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCsFeatureToggle" nillable="true" type="tns:ArrayOfCsFeatureToggle" />
      <xs:complexType name="CsFeatureToggle">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="State" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CsFeatureToggle" nillable="true" type="tns:CsFeatureToggle" />
      <xs:element name="UpdateFeatureTogglesResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="EventHandlerExists">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EventHandlerType" type="tns:EventHandlerType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
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
          <xs:enumeration value="SalesBeforeSaveApproveQuote">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1014</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveRejectQuote">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1015</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveTicket">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1016</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesLoadCustomObject">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1017</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesBeforeSaveCustomObject">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1018</EnumerationValue>
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
          <xs:enumeration value="SalesAfterSaveApproveQuote">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1114</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveRejectQuote">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1115</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveTicket">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1116</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesAfterSaveCustomObject">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1117</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SalesSplitTicket">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1019</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="EventHandlerType" nillable="true" type="tns:EventHandlerType" />
      <xs:element name="EventHandlerExistsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="EventHandlersExists">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EventHandlerTypes" nillable="true" type="tns:ArrayOfEventHandlerType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfEventHandlerType">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="EventHandlerType" type="tns:EventHandlerType" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfEventHandlerType" nillable="true" type="tns:ArrayOfEventHandlerType" />
      <xs:element name="EventHandlersExistsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfEventHandlerType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateSession">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="RemoteIp" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateSessionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CsSessionKey" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CsSessionKey">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Key" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="LoginId" type="xs:int" />
              <xs:element minOccurs="0" name="UserId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CsSessionKey" nillable="true" type="tns:CsSessionKey" />
      <xs:element name="RemoveSession">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LoginId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveSessionResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SessionIsValid">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CsSessionKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SessionIsValidResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="HasChatNotify">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="HasChatNotifyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CheckSymmetricEncryption">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EncryptedString" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CheckSymmetricEncryptionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ReportSessionActive">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SessionKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ReportSessionActiveResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCustomerCenterConfig">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CustomerCenterConfigId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCustomerCenterConfigResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CustomerCenterConfig" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllCustomerCenterConfigs">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllCustomerCenterConfigsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCustomerCenterConfig" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfCustomerCenterConfig">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="CustomerCenterConfig" nillable="true" type="tns:CustomerCenterConfig" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCustomerCenterConfig" nillable="true" type="tns:ArrayOfCustomerCenterConfig" />
      <xs:element name="SaveAllCustomerCenterConfigs">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CustConfigs" nillable="true" type="tns:ArrayOfCustomerCenterConfig" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveAllCustomerCenterConfigsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CheckIfCustomizedTemplates">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CheckIfCustomizedTemplatesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProgramUrl">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProgramName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="External" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProgramUrlResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFaqForCustomer">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FaqEntryId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFaqForCustomerResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCustomerServiceStartup">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCustomerServiceStartupResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CustomerServiceStartup" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CustomerServiceStartup">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="TimezoneEnabled" type="xs:boolean" />
              <xs:element minOccurs="0" name="TZOffset" type="xs:int" />
              <xs:element minOccurs="0" name="RecaptchaSiteKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SelectedPreferences" nillable="true" type="tns:ArrayOfPreference" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CustomerServiceStartup" nillable="true" type="tns:CustomerServiceStartup" />
      <xs:complexType name="ArrayOfPreference">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Preference" nillable="true" type="tns:Preference" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfPreference" nillable="true" type="tns:ArrayOfPreference" />
      <xs:complexType name="Preference">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Level" type="tns:PreferenceLevel" />
              <xs:element minOccurs="0" name="RawValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Specification" nillable="true" type="tns:PreferenceSpec" />
              <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayTooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayType" type="tns:PrefDescValueType" />
              <xs:element minOccurs="0" name="TabOrder" nillable="true" type="tns:TabOrder" />
              <xs:element minOccurs="0" name="TargetId" type="xs:int" />
              <xs:element minOccurs="0" name="PrefDescId" type="xs:int" />
              <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserPreferenceId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Preference" nillable="true" type="tns:Preference" />
      <xs:simpleType name="PreferenceLevel">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Undefined" />
          <xs:enumeration value="HardDefault" />
          <xs:enumeration value="SystemWide" />
          <xs:enumeration value="Database" />
          <xs:enumeration value="Group" />
          <xs:enumeration value="Individual" />
          <xs:enumeration value="PC" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="PreferenceLevel" nillable="true" type="tns:PreferenceLevel" />
      <xs:complexType name="PreferenceSpec">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Section" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Key" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PreferenceSpec" nillable="true" type="tns:PreferenceSpec" />
      <xs:simpleType name="PrefDescValueType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Number" />
          <xs:enumeration value="Text" />
          <xs:enumeration value="Bool" />
          <xs:enumeration value="ListOfValues" />
          <xs:enumeration value="ListTableRef" />
          <xs:enumeration value="TimeList" />
          <xs:enumeration value="ContactID" />
          <xs:enumeration value="PersonID" />
          <xs:enumeration value="ProjectID" />
          <xs:enumeration value="SelectionID" />
          <xs:enumeration value="PosSize" />
          <xs:enumeration value="TimeZone" />
          <xs:enumeration value="Time" />
          <xs:enumeration value="Password" />
          <xs:enumeration value="MultiLineText" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="PrefDescValueType" nillable="true" type="tns:PrefDescValueType" />
      <xs:complexType name="TabOrder">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="TabOrderId" type="xs:int" />
              <xs:element minOccurs="0" name="TabName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Order" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TabOrder" nillable="true" type="tns:TabOrder" />
      <xs:element name="GetCustomerServiceStartupByOwner">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCustomerServiceStartupByOwnerResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CustomerServiceStartup" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExecuteEventHandlers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EventData" nillable="true" type="tns:EventData" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="EventData">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Type" type="tns:EventHandlerType" />
              <xs:element minOccurs="0" name="InputValues" nillable="true" type="tns:StringDictionary" />
              <xs:element minOccurs="0" name="BlockExecution" type="xs:boolean" />
              <xs:element minOccurs="0" name="NavigateTo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ShowDialog" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OutputValues" nillable="true" type="tns:StringDictionary" />
              <xs:element minOccurs="0" name="StateValues" nillable="true" type="tns:StringDictionary" />
              <xs:element minOccurs="0" name="Exception" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ParserValues" nillable="true" type="tns:StringDictionary" />
              <xs:element minOccurs="0" name="CgiVariables" nillable="true" type="tns:StringDictionary" />
              <xs:element minOccurs="0" name="CgiContent" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Headers" nillable="true" type="tns:StringDictionary" />
              <xs:element minOccurs="0" name="TraceExecution" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EventData" nillable="true" type="tns:EventData" />
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
      <xs:element name="ExecuteEventHandlersResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:EventData" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMailboxes">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMailboxesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfMailbox" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfMailbox">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Mailbox" nillable="true" type="tns:Mailbox" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfMailbox" nillable="true" type="tns:ArrayOfMailbox" />
      <xs:complexType name="Mailbox">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="MailInFilterId" type="xs:int" />
              <xs:element minOccurs="0" name="Address" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CategoryName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PriorityName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Mailbox" nillable="true" type="tns:Mailbox" />
      <xs:element name="GetMailboxEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MailboxEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMailboxEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:MailboxEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreviewFaqEntry">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="KbEntryId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreviewFaqEntryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PreviewFaqEntry" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="PreviewFaqEntry">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RegisteredByFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Question" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Answer" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PreviewFaqEntry" nillable="true" type="tns:PreviewFaqEntry" />
      <xs:element name="GetPreviewQuickReply">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuickReplyId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreviewQuickReplyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PreviewQuickReply" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="PreviewQuickReply">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UpdatedByFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="HtmlBody" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PreviewQuickReply" nillable="true" type="tns:PreviewQuickReply" />
      <xs:element name="GetPreviewReplyTemplate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReplyTemplateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreviewReplyTemplateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PreviewReplyTemplate" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="PreviewReplyTemplate">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OwnedByFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Body" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsHtml" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PreviewReplyTemplate" nillable="true" type="tns:PreviewReplyTemplate" />
      <xs:element name="GetParsedTemplate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReplyTemplateId" type="xs:int" />
            <xs:element minOccurs="0" name="LanguageId" type="xs:int" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="TicketId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetParsedTemplateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReplyTemplateParsed" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ReplyTemplateParsed">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ReplyTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="PlainParsed" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="HtmlParsed" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Attachments" nillable="true" type="tns:ArrayOfAttachmentEntity" />
              <xs:element minOccurs="0" name="Subject" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ReplyTemplateParsed" nillable="true" type="tns:ReplyTemplateParsed" />
      <xs:complexType name="ArrayOfAttachmentEntity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="AttachmentEntity" nillable="true" type="tns:AttachmentEntity" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfAttachmentEntity" nillable="true" type="tns:ArrayOfAttachmentEntity" />
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
              <xs:element minOccurs="0" name="IsSafeFileExtension" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AttachmentEntity" nillable="true" type="tns:AttachmentEntity" />
      <xs:element name="GetUnparsedTemplate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ReplyTemplateId" type="xs:int" />
            <xs:element minOccurs="0" name="LanguageId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUnparsedTemplateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ReplyTemplateParsed" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSmsConfig">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSmsConfigResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SmsConfig" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SmsConfig">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="DefaultSmsCountry" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="NetServerSmsProvider" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="NsPluginSender" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="NsPluginConfig" nillable="true" type="tns:StringDictionary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SmsConfig" nillable="true" type="tns:SmsConfig" />
      <xs:element name="TestSmtpServer">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SmtpUri" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="From" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="UseStoredPassword" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TestSmtpServerResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SmtpTestResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SmtpTestResult">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Success" type="xs:boolean" />
              <xs:element minOccurs="0" name="ErrorMessage" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SmtpTestResult" nillable="true" type="tns:SmtpTestResult" />
      <xs:element name="GetStatistics">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Functions" nillable="true" type="tns:ArrayOfStatusScreenPanelType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfStatusScreenPanelType">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="StatusScreenPanelType" type="tns:StatusScreenPanelType" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfStatusScreenPanelType" nillable="true" type="tns:ArrayOfStatusScreenPanelType" />
      <xs:simpleType name="StatusScreenPanelType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="OpenRequestsPerCategory" />
          <xs:enumeration value="OpenRequestsPerTopCategory" />
          <xs:enumeration value="OpenRequestsPerUser" />
          <xs:enumeration value="OpenRequestsPerUserGroup" />
          <xs:enumeration value="OpenRequestsPerPriority" />
          <xs:enumeration value="OpenRequestsPerStatus" />
          <xs:enumeration value="OpenRequestsPerOrigin" />
          <xs:enumeration value="NumberOfCreatedRequestsPerDay">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">11</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="NumberOfCreatedRequestsPerWeek">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">12</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="NumberOfCreatedRequestsPerMonth">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">13</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="UserResponseTimePerDay">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">21</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="UserReponseTimePerWeek">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">22</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="UserResponseTimePerMonth">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">23</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="OwnOpenRequests">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">101</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="UnassignedRequests">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">102</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Hotlist">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">103</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="StatusScreen">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">111</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="StatusScreenPanelType" nillable="true" type="tns:StatusScreenPanelType" />
      <xs:element name="GetStatisticsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfStatisticsDataSet" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfStatisticsDataSet">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="StatisticsDataSet" nillable="true" type="tns:StatisticsDataSet" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfStatisticsDataSet" nillable="true" type="tns:ArrayOfStatisticsDataSet" />
      <xs:complexType name="StatisticsDataSet">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Label" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Values" nillable="true" type="tns:ArrayOfStatisticsDataValue" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="StatisticsDataSet" nillable="true" type="tns:StatisticsDataSet" />
      <xs:complexType name="ArrayOfStatisticsDataValue">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="StatisticsDataValue" nillable="true" type="tns:StatisticsDataValue" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfStatisticsDataValue" nillable="true" type="tns:ArrayOfStatisticsDataValue" />
      <xs:complexType name="StatisticsDataValue">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Label" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Value" type="xs:double" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="StatisticsDataValue" nillable="true" type="tns:StatisticsDataValue" />
      <xs:element name="GetSystemTemplateSettings">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSystemTemplateSettingsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SystemTemplateSettings" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SystemTemplateSettings">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="CustomerNewCustomerTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="CustomerCustomerReplyTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="CustomerPasswordTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="CustomerConfirmEmailTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="CustomerChatLogTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="NewLinkTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="HotlistNewMessageTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="HotlistTicketActivatedTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="UserTicketAlarmTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="HotlistTicketTakenOverTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="UserActiveTicketsTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="UserNewMessageTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="UserTicketActivatedTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="UserNewTicketTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="PublishKbQuestionTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="PublishKbAnswerTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="UserTicketTakenOverTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="PrintTicketTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="WeekStatTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="TicketAlarmHotlistTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="EmailAddresses" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SystemTemplateSettings" nillable="true" type="tns:SystemTemplateSettings" />
      <xs:element name="SaveSystemTemplateSettings">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SystemTemplateSettings" nillable="true" type="tns:SystemTemplateSettings" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveSystemTemplateSettingsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SystemTemplateSettings" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTicketFromMailData">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MailboxId" type="xs:int" />
            <xs:element minOccurs="0" name="Data" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTicketFromMailDataResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="TicketInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="TicketId" type="xs:int" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OwnerName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CategoryName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PriorityName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TicketUrl" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TicketInfo" nillable="true" type="tns:TicketInfo" />
      <xs:element name="AddMessageFromMailData">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketId" type="xs:int" />
            <xs:element minOccurs="0" name="Data" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddMessageFromMailDataResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TicketInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindTicketsByTitleOrId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TitleOrId" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="MaxRows" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindTicketsByTitleOrIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTicketInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfTicketInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TicketInfo" nillable="true" type="tns:TicketInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTicketInfo" nillable="true" type="tns:ArrayOfTicketInfo" />
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
  <wsdl:message name="CreateDefaultCustomerCenterConfigRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultCustomerCenterConfig" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCustomerCenterConfigRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCustomerCenterConfigResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultCustomerCenterConfigResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultCustomerCenterConfigResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCustomerCenterConfigRequest">
    <wsdl:part name="parameters" element="tns:SaveCustomerCenterConfig" />
  </wsdl:message>
  <wsdl:message name="SaveCustomerCenterConfigRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveCustomerCenterConfigResponse">
    <wsdl:part name="parameters" element="tns:SaveCustomerCenterConfigResponse" />
  </wsdl:message>
  <wsdl:message name="SaveCustomerCenterConfigResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteCustomerCenterConfigRequest">
    <wsdl:part name="parameters" element="tns:DeleteCustomerCenterConfig" />
  </wsdl:message>
  <wsdl:message name="DeleteCustomerCenterConfigRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteCustomerCenterConfigResponse">
    <wsdl:part name="parameters" element="tns:DeleteCustomerCenterConfigResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteCustomerCenterConfigResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultMailboxEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultMailboxEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultMailboxEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultMailboxEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultMailboxEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultMailboxEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveMailboxEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveMailboxEntity" />
  </wsdl:message>
  <wsdl:message name="SaveMailboxEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveMailboxEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveMailboxEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveMailboxEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteChatSessionsRequest">
    <wsdl:part name="parameters" element="tns:DeleteChatSessions" />
  </wsdl:message>
  <wsdl:message name="DeleteChatSessionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteChatSessionsResponse">
    <wsdl:part name="parameters" element="tns:DeleteChatSessionsResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteChatSessionsResponse_Headers">
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
  <wsdl:message name="UpdateFeatureTogglesRequest">
    <wsdl:part name="parameters" element="tns:UpdateFeatureToggles" />
  </wsdl:message>
  <wsdl:message name="UpdateFeatureTogglesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateFeatureTogglesResponse">
    <wsdl:part name="parameters" element="tns:UpdateFeatureTogglesResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateFeatureTogglesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="EventHandlerExistsRequest">
    <wsdl:part name="parameters" element="tns:EventHandlerExists" />
  </wsdl:message>
  <wsdl:message name="EventHandlerExistsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="EventHandlerExistsResponse">
    <wsdl:part name="parameters" element="tns:EventHandlerExistsResponse" />
  </wsdl:message>
  <wsdl:message name="EventHandlerExistsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="EventHandlersExistsRequest">
    <wsdl:part name="parameters" element="tns:EventHandlersExists" />
  </wsdl:message>
  <wsdl:message name="EventHandlersExistsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="EventHandlersExistsResponse">
    <wsdl:part name="parameters" element="tns:EventHandlersExistsResponse" />
  </wsdl:message>
  <wsdl:message name="EventHandlersExistsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateSessionRequest">
    <wsdl:part name="parameters" element="tns:CreateSession" />
  </wsdl:message>
  <wsdl:message name="CreateSessionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateSessionResponse">
    <wsdl:part name="parameters" element="tns:CreateSessionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateSessionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveSessionRequest">
    <wsdl:part name="parameters" element="tns:RemoveSession" />
  </wsdl:message>
  <wsdl:message name="RemoveSessionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveSessionResponse">
    <wsdl:part name="parameters" element="tns:RemoveSessionResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveSessionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SessionIsValidRequest">
    <wsdl:part name="parameters" element="tns:SessionIsValid" />
  </wsdl:message>
  <wsdl:message name="SessionIsValidRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SessionIsValidResponse">
    <wsdl:part name="parameters" element="tns:SessionIsValidResponse" />
  </wsdl:message>
  <wsdl:message name="SessionIsValidResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasChatNotifyRequest">
    <wsdl:part name="parameters" element="tns:HasChatNotify" />
  </wsdl:message>
  <wsdl:message name="HasChatNotifyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasChatNotifyResponse">
    <wsdl:part name="parameters" element="tns:HasChatNotifyResponse" />
  </wsdl:message>
  <wsdl:message name="HasChatNotifyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CheckSymmetricEncryptionRequest">
    <wsdl:part name="parameters" element="tns:CheckSymmetricEncryption" />
  </wsdl:message>
  <wsdl:message name="CheckSymmetricEncryptionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CheckSymmetricEncryptionResponse">
    <wsdl:part name="parameters" element="tns:CheckSymmetricEncryptionResponse" />
  </wsdl:message>
  <wsdl:message name="CheckSymmetricEncryptionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ReportSessionActiveRequest">
    <wsdl:part name="parameters" element="tns:ReportSessionActive" />
  </wsdl:message>
  <wsdl:message name="ReportSessionActiveRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ReportSessionActiveResponse">
    <wsdl:part name="parameters" element="tns:ReportSessionActiveResponse" />
  </wsdl:message>
  <wsdl:message name="ReportSessionActiveResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomerCenterConfigRequest">
    <wsdl:part name="parameters" element="tns:GetCustomerCenterConfig" />
  </wsdl:message>
  <wsdl:message name="GetCustomerCenterConfigRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomerCenterConfigResponse">
    <wsdl:part name="parameters" element="tns:GetCustomerCenterConfigResponse" />
  </wsdl:message>
  <wsdl:message name="GetCustomerCenterConfigResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllCustomerCenterConfigsRequest">
    <wsdl:part name="parameters" element="tns:GetAllCustomerCenterConfigs" />
  </wsdl:message>
  <wsdl:message name="GetAllCustomerCenterConfigsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllCustomerCenterConfigsResponse">
    <wsdl:part name="parameters" element="tns:GetAllCustomerCenterConfigsResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllCustomerCenterConfigsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveAllCustomerCenterConfigsRequest">
    <wsdl:part name="parameters" element="tns:SaveAllCustomerCenterConfigs" />
  </wsdl:message>
  <wsdl:message name="SaveAllCustomerCenterConfigsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveAllCustomerCenterConfigsResponse">
    <wsdl:part name="parameters" element="tns:SaveAllCustomerCenterConfigsResponse" />
  </wsdl:message>
  <wsdl:message name="SaveAllCustomerCenterConfigsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CheckIfCustomizedTemplatesRequest">
    <wsdl:part name="parameters" element="tns:CheckIfCustomizedTemplates" />
  </wsdl:message>
  <wsdl:message name="CheckIfCustomizedTemplatesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CheckIfCustomizedTemplatesResponse">
    <wsdl:part name="parameters" element="tns:CheckIfCustomizedTemplatesResponse" />
  </wsdl:message>
  <wsdl:message name="CheckIfCustomizedTemplatesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProgramUrlRequest">
    <wsdl:part name="parameters" element="tns:GetProgramUrl" />
  </wsdl:message>
  <wsdl:message name="GetProgramUrlRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProgramUrlResponse">
    <wsdl:part name="parameters" element="tns:GetProgramUrlResponse" />
  </wsdl:message>
  <wsdl:message name="GetProgramUrlResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFaqForCustomerRequest">
    <wsdl:part name="parameters" element="tns:GetFaqForCustomer" />
  </wsdl:message>
  <wsdl:message name="GetFaqForCustomerRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFaqForCustomerResponse">
    <wsdl:part name="parameters" element="tns:GetFaqForCustomerResponse" />
  </wsdl:message>
  <wsdl:message name="GetFaqForCustomerResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomerServiceStartupRequest">
    <wsdl:part name="parameters" element="tns:GetCustomerServiceStartup" />
  </wsdl:message>
  <wsdl:message name="GetCustomerServiceStartupRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomerServiceStartupResponse">
    <wsdl:part name="parameters" element="tns:GetCustomerServiceStartupResponse" />
  </wsdl:message>
  <wsdl:message name="GetCustomerServiceStartupResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomerServiceStartupByOwnerRequest">
    <wsdl:part name="parameters" element="tns:GetCustomerServiceStartupByOwner" />
  </wsdl:message>
  <wsdl:message name="GetCustomerServiceStartupByOwnerRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCustomerServiceStartupByOwnerResponse">
    <wsdl:part name="parameters" element="tns:GetCustomerServiceStartupByOwnerResponse" />
  </wsdl:message>
  <wsdl:message name="GetCustomerServiceStartupByOwnerResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExecuteEventHandlersRequest">
    <wsdl:part name="parameters" element="tns:ExecuteEventHandlers" />
  </wsdl:message>
  <wsdl:message name="ExecuteEventHandlersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExecuteEventHandlersResponse">
    <wsdl:part name="parameters" element="tns:ExecuteEventHandlersResponse" />
  </wsdl:message>
  <wsdl:message name="ExecuteEventHandlersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMailboxesRequest">
    <wsdl:part name="parameters" element="tns:GetMailboxes" />
  </wsdl:message>
  <wsdl:message name="GetMailboxesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMailboxesResponse">
    <wsdl:part name="parameters" element="tns:GetMailboxesResponse" />
  </wsdl:message>
  <wsdl:message name="GetMailboxesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMailboxEntityRequest">
    <wsdl:part name="parameters" element="tns:GetMailboxEntity" />
  </wsdl:message>
  <wsdl:message name="GetMailboxEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMailboxEntityResponse">
    <wsdl:part name="parameters" element="tns:GetMailboxEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetMailboxEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreviewFaqEntryRequest">
    <wsdl:part name="parameters" element="tns:GetPreviewFaqEntry" />
  </wsdl:message>
  <wsdl:message name="GetPreviewFaqEntryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreviewFaqEntryResponse">
    <wsdl:part name="parameters" element="tns:GetPreviewFaqEntryResponse" />
  </wsdl:message>
  <wsdl:message name="GetPreviewFaqEntryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreviewQuickReplyRequest">
    <wsdl:part name="parameters" element="tns:GetPreviewQuickReply" />
  </wsdl:message>
  <wsdl:message name="GetPreviewQuickReplyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreviewQuickReplyResponse">
    <wsdl:part name="parameters" element="tns:GetPreviewQuickReplyResponse" />
  </wsdl:message>
  <wsdl:message name="GetPreviewQuickReplyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreviewReplyTemplateRequest">
    <wsdl:part name="parameters" element="tns:GetPreviewReplyTemplate" />
  </wsdl:message>
  <wsdl:message name="GetPreviewReplyTemplateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreviewReplyTemplateResponse">
    <wsdl:part name="parameters" element="tns:GetPreviewReplyTemplateResponse" />
  </wsdl:message>
  <wsdl:message name="GetPreviewReplyTemplateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetParsedTemplateRequest">
    <wsdl:part name="parameters" element="tns:GetParsedTemplate" />
  </wsdl:message>
  <wsdl:message name="GetParsedTemplateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetParsedTemplateResponse">
    <wsdl:part name="parameters" element="tns:GetParsedTemplateResponse" />
  </wsdl:message>
  <wsdl:message name="GetParsedTemplateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUnparsedTemplateRequest">
    <wsdl:part name="parameters" element="tns:GetUnparsedTemplate" />
  </wsdl:message>
  <wsdl:message name="GetUnparsedTemplateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUnparsedTemplateResponse">
    <wsdl:part name="parameters" element="tns:GetUnparsedTemplateResponse" />
  </wsdl:message>
  <wsdl:message name="GetUnparsedTemplateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSmsConfigRequest">
    <wsdl:part name="parameters" element="tns:GetSmsConfig" />
  </wsdl:message>
  <wsdl:message name="GetSmsConfigRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSmsConfigResponse">
    <wsdl:part name="parameters" element="tns:GetSmsConfigResponse" />
  </wsdl:message>
  <wsdl:message name="GetSmsConfigResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TestSmtpServerRequest">
    <wsdl:part name="parameters" element="tns:TestSmtpServer" />
  </wsdl:message>
  <wsdl:message name="TestSmtpServerRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TestSmtpServerResponse">
    <wsdl:part name="parameters" element="tns:TestSmtpServerResponse" />
  </wsdl:message>
  <wsdl:message name="TestSmtpServerResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetStatisticsRequest">
    <wsdl:part name="parameters" element="tns:GetStatistics" />
  </wsdl:message>
  <wsdl:message name="GetStatisticsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetStatisticsResponse">
    <wsdl:part name="parameters" element="tns:GetStatisticsResponse" />
  </wsdl:message>
  <wsdl:message name="GetStatisticsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSystemTemplateSettingsRequest">
    <wsdl:part name="parameters" element="tns:GetSystemTemplateSettings" />
  </wsdl:message>
  <wsdl:message name="GetSystemTemplateSettingsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSystemTemplateSettingsResponse">
    <wsdl:part name="parameters" element="tns:GetSystemTemplateSettingsResponse" />
  </wsdl:message>
  <wsdl:message name="GetSystemTemplateSettingsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSystemTemplateSettingsRequest">
    <wsdl:part name="parameters" element="tns:SaveSystemTemplateSettings" />
  </wsdl:message>
  <wsdl:message name="SaveSystemTemplateSettingsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSystemTemplateSettingsResponse">
    <wsdl:part name="parameters" element="tns:SaveSystemTemplateSettingsResponse" />
  </wsdl:message>
  <wsdl:message name="SaveSystemTemplateSettingsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTicketFromMailDataRequest">
    <wsdl:part name="parameters" element="tns:CreateTicketFromMailData" />
  </wsdl:message>
  <wsdl:message name="CreateTicketFromMailDataRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTicketFromMailDataResponse">
    <wsdl:part name="parameters" element="tns:CreateTicketFromMailDataResponse" />
  </wsdl:message>
  <wsdl:message name="CreateTicketFromMailDataResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddMessageFromMailDataRequest">
    <wsdl:part name="parameters" element="tns:AddMessageFromMailData" />
  </wsdl:message>
  <wsdl:message name="AddMessageFromMailDataRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddMessageFromMailDataResponse">
    <wsdl:part name="parameters" element="tns:AddMessageFromMailDataResponse" />
  </wsdl:message>
  <wsdl:message name="AddMessageFromMailDataResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindTicketsByTitleOrIdRequest">
    <wsdl:part name="parameters" element="tns:FindTicketsByTitleOrId" />
  </wsdl:message>
  <wsdl:message name="FindTicketsByTitleOrIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindTicketsByTitleOrIdResponse">
    <wsdl:part name="parameters" element="tns:FindTicketsByTitleOrIdResponse" />
  </wsdl:message>
  <wsdl:message name="FindTicketsByTitleOrIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="CustomerService">
    <wsdl:operation name="CreateDefaultCustomerCenterConfig">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/CreateDefaultCustomerCenterConfig" name="CreateDefaultCustomerCenterConfigRequest" message="tns:CreateDefaultCustomerCenterConfigRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/CreateDefaultCustomerCenterConfigResponse" name="CreateDefaultCustomerCenterConfigResponse" message="tns:CreateDefaultCustomerCenterConfigResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveCustomerCenterConfig">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/SaveCustomerCenterConfig" name="SaveCustomerCenterConfigRequest" message="tns:SaveCustomerCenterConfigRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/SaveCustomerCenterConfigResponse" name="SaveCustomerCenterConfigResponse" message="tns:SaveCustomerCenterConfigResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteCustomerCenterConfig">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/DeleteCustomerCenterConfig" name="DeleteCustomerCenterConfigRequest" message="tns:DeleteCustomerCenterConfigRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/DeleteCustomerCenterConfigResponse" name="DeleteCustomerCenterConfigResponse" message="tns:DeleteCustomerCenterConfigResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultMailboxEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/CreateDefaultMailboxEntity" name="CreateDefaultMailboxEntityRequest" message="tns:CreateDefaultMailboxEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/CreateDefaultMailboxEntityResponse" name="CreateDefaultMailboxEntityResponse" message="tns:CreateDefaultMailboxEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveMailboxEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/SaveMailboxEntity" name="SaveMailboxEntityRequest" message="tns:SaveMailboxEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/SaveMailboxEntityResponse" name="SaveMailboxEntityResponse" message="tns:SaveMailboxEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteChatSessions">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/DeleteChatSessions" name="DeleteChatSessionsRequest" message="tns:DeleteChatSessionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/DeleteChatSessionsResponse" name="DeleteChatSessionsResponse" message="tns:DeleteChatSessionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChatSessionsForUser">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/ChatSessionsForUser" name="ChatSessionsForUserRequest" message="tns:ChatSessionsForUserRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/ChatSessionsForUserResponse" name="ChatSessionsForUserResponse" message="tns:ChatSessionsForUserResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateFeatureToggles">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/UpdateFeatureToggles" name="UpdateFeatureTogglesRequest" message="tns:UpdateFeatureTogglesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/UpdateFeatureTogglesResponse" name="UpdateFeatureTogglesResponse" message="tns:UpdateFeatureTogglesResponse" />
    </wsdl:operation>
    <wsdl:operation name="EventHandlerExists">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/EventHandlerExists" name="EventHandlerExistsRequest" message="tns:EventHandlerExistsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/EventHandlerExistsResponse" name="EventHandlerExistsResponse" message="tns:EventHandlerExistsResponse" />
    </wsdl:operation>
    <wsdl:operation name="EventHandlersExists">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/EventHandlersExists" name="EventHandlersExistsRequest" message="tns:EventHandlersExistsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/EventHandlersExistsResponse" name="EventHandlersExistsResponse" message="tns:EventHandlersExistsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateSession">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/CreateSession" name="CreateSessionRequest" message="tns:CreateSessionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/CreateSessionResponse" name="CreateSessionResponse" message="tns:CreateSessionResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveSession">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/RemoveSession" name="RemoveSessionRequest" message="tns:RemoveSessionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/RemoveSessionResponse" name="RemoveSessionResponse" message="tns:RemoveSessionResponse" />
    </wsdl:operation>
    <wsdl:operation name="SessionIsValid">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/SessionIsValid" name="SessionIsValidRequest" message="tns:SessionIsValidRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/SessionIsValidResponse" name="SessionIsValidResponse" message="tns:SessionIsValidResponse" />
    </wsdl:operation>
    <wsdl:operation name="HasChatNotify">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/HasChatNotify" name="HasChatNotifyRequest" message="tns:HasChatNotifyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/HasChatNotifyResponse" name="HasChatNotifyResponse" message="tns:HasChatNotifyResponse" />
    </wsdl:operation>
    <wsdl:operation name="CheckSymmetricEncryption">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/CheckSymmetricEncryption" name="CheckSymmetricEncryptionRequest" message="tns:CheckSymmetricEncryptionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/CheckSymmetricEncryptionResponse" name="CheckSymmetricEncryptionResponse" message="tns:CheckSymmetricEncryptionResponse" />
    </wsdl:operation>
    <wsdl:operation name="ReportSessionActive">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/ReportSessionActive" name="ReportSessionActiveRequest" message="tns:ReportSessionActiveRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/ReportSessionActiveResponse" name="ReportSessionActiveResponse" message="tns:ReportSessionActiveResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCustomerCenterConfig">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetCustomerCenterConfig" name="GetCustomerCenterConfigRequest" message="tns:GetCustomerCenterConfigRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetCustomerCenterConfigResponse" name="GetCustomerCenterConfigResponse" message="tns:GetCustomerCenterConfigResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllCustomerCenterConfigs">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetAllCustomerCenterConfigs" name="GetAllCustomerCenterConfigsRequest" message="tns:GetAllCustomerCenterConfigsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetAllCustomerCenterConfigsResponse" name="GetAllCustomerCenterConfigsResponse" message="tns:GetAllCustomerCenterConfigsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveAllCustomerCenterConfigs">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/SaveAllCustomerCenterConfigs" name="SaveAllCustomerCenterConfigsRequest" message="tns:SaveAllCustomerCenterConfigsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/SaveAllCustomerCenterConfigsResponse" name="SaveAllCustomerCenterConfigsResponse" message="tns:SaveAllCustomerCenterConfigsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CheckIfCustomizedTemplates">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/CheckIfCustomizedTemplates" name="CheckIfCustomizedTemplatesRequest" message="tns:CheckIfCustomizedTemplatesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/CheckIfCustomizedTemplatesResponse" name="CheckIfCustomizedTemplatesResponse" message="tns:CheckIfCustomizedTemplatesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProgramUrl">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetProgramUrl" name="GetProgramUrlRequest" message="tns:GetProgramUrlRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetProgramUrlResponse" name="GetProgramUrlResponse" message="tns:GetProgramUrlResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFaqForCustomer">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetFaqForCustomer" name="GetFaqForCustomerRequest" message="tns:GetFaqForCustomerRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetFaqForCustomerResponse" name="GetFaqForCustomerResponse" message="tns:GetFaqForCustomerResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCustomerServiceStartup">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetCustomerServiceStartup" name="GetCustomerServiceStartupRequest" message="tns:GetCustomerServiceStartupRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetCustomerServiceStartupResponse" name="GetCustomerServiceStartupResponse" message="tns:GetCustomerServiceStartupResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCustomerServiceStartupByOwner">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetCustomerServiceStartupByOwner" name="GetCustomerServiceStartupByOwnerRequest" message="tns:GetCustomerServiceStartupByOwnerRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetCustomerServiceStartupByOwnerResponse" name="GetCustomerServiceStartupByOwnerResponse" message="tns:GetCustomerServiceStartupByOwnerResponse" />
    </wsdl:operation>
    <wsdl:operation name="ExecuteEventHandlers">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/ExecuteEventHandlers" name="ExecuteEventHandlersRequest" message="tns:ExecuteEventHandlersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/ExecuteEventHandlersResponse" name="ExecuteEventHandlersResponse" message="tns:ExecuteEventHandlersResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMailboxes">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetMailboxes" name="GetMailboxesRequest" message="tns:GetMailboxesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetMailboxesResponse" name="GetMailboxesResponse" message="tns:GetMailboxesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMailboxEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetMailboxEntity" name="GetMailboxEntityRequest" message="tns:GetMailboxEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetMailboxEntityResponse" name="GetMailboxEntityResponse" message="tns:GetMailboxEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPreviewFaqEntry">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetPreviewFaqEntry" name="GetPreviewFaqEntryRequest" message="tns:GetPreviewFaqEntryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetPreviewFaqEntryResponse" name="GetPreviewFaqEntryResponse" message="tns:GetPreviewFaqEntryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPreviewQuickReply">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetPreviewQuickReply" name="GetPreviewQuickReplyRequest" message="tns:GetPreviewQuickReplyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetPreviewQuickReplyResponse" name="GetPreviewQuickReplyResponse" message="tns:GetPreviewQuickReplyResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPreviewReplyTemplate">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetPreviewReplyTemplate" name="GetPreviewReplyTemplateRequest" message="tns:GetPreviewReplyTemplateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetPreviewReplyTemplateResponse" name="GetPreviewReplyTemplateResponse" message="tns:GetPreviewReplyTemplateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetParsedTemplate">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetParsedTemplate" name="GetParsedTemplateRequest" message="tns:GetParsedTemplateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetParsedTemplateResponse" name="GetParsedTemplateResponse" message="tns:GetParsedTemplateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUnparsedTemplate">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetUnparsedTemplate" name="GetUnparsedTemplateRequest" message="tns:GetUnparsedTemplateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetUnparsedTemplateResponse" name="GetUnparsedTemplateResponse" message="tns:GetUnparsedTemplateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSmsConfig">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetSmsConfig" name="GetSmsConfigRequest" message="tns:GetSmsConfigRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetSmsConfigResponse" name="GetSmsConfigResponse" message="tns:GetSmsConfigResponse" />
    </wsdl:operation>
    <wsdl:operation name="TestSmtpServer">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/TestSmtpServer" name="TestSmtpServerRequest" message="tns:TestSmtpServerRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/TestSmtpServerResponse" name="TestSmtpServerResponse" message="tns:TestSmtpServerResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetStatistics">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetStatistics" name="GetStatisticsRequest" message="tns:GetStatisticsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetStatisticsResponse" name="GetStatisticsResponse" message="tns:GetStatisticsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSystemTemplateSettings">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetSystemTemplateSettings" name="GetSystemTemplateSettingsRequest" message="tns:GetSystemTemplateSettingsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetSystemTemplateSettingsResponse" name="GetSystemTemplateSettingsResponse" message="tns:GetSystemTemplateSettingsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveSystemTemplateSettings">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/SaveSystemTemplateSettings" name="SaveSystemTemplateSettingsRequest" message="tns:SaveSystemTemplateSettingsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/SaveSystemTemplateSettingsResponse" name="SaveSystemTemplateSettingsResponse" message="tns:SaveSystemTemplateSettingsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateTicketFromMailData">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/CreateTicketFromMailData" name="CreateTicketFromMailDataRequest" message="tns:CreateTicketFromMailDataRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/CreateTicketFromMailDataResponse" name="CreateTicketFromMailDataResponse" message="tns:CreateTicketFromMailDataResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddMessageFromMailData">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/AddMessageFromMailData" name="AddMessageFromMailDataRequest" message="tns:AddMessageFromMailDataRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/AddMessageFromMailDataResponse" name="AddMessageFromMailDataResponse" message="tns:AddMessageFromMailDataResponse" />
    </wsdl:operation>
    <wsdl:operation name="FindTicketsByTitleOrId">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/FindTicketsByTitleOrId" name="FindTicketsByTitleOrIdRequest" message="tns:FindTicketsByTitleOrIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/FindTicketsByTitleOrIdResponse" name="FindTicketsByTitleOrIdResponse" message="tns:FindTicketsByTitleOrIdResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_CustomerService" type="tns:CustomerService">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultCustomerCenterConfig">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/CreateDefaultCustomerCenterConfig" style="document" />
      <wsdl:input name="CreateDefaultCustomerCenterConfigRequest">
        <soap:header message="tns:CreateDefaultCustomerCenterConfigRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultCustomerCenterConfigRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultCustomerCenterConfigRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultCustomerCenterConfigResponse">
        <soap:header message="tns:CreateDefaultCustomerCenterConfigResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultCustomerCenterConfigResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultCustomerCenterConfigResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultCustomerCenterConfigResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveCustomerCenterConfig">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/SaveCustomerCenterConfig" style="document" />
      <wsdl:input name="SaveCustomerCenterConfigRequest">
        <soap:header message="tns:SaveCustomerCenterConfigRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveCustomerCenterConfigRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveCustomerCenterConfigRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveCustomerCenterConfigResponse">
        <soap:header message="tns:SaveCustomerCenterConfigResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveCustomerCenterConfigResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveCustomerCenterConfigResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveCustomerCenterConfigResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteCustomerCenterConfig">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/DeleteCustomerCenterConfig" style="document" />
      <wsdl:input name="DeleteCustomerCenterConfigRequest">
        <soap:header message="tns:DeleteCustomerCenterConfigRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteCustomerCenterConfigRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteCustomerCenterConfigRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteCustomerCenterConfigResponse">
        <soap:header message="tns:DeleteCustomerCenterConfigResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteCustomerCenterConfigResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteCustomerCenterConfigResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteCustomerCenterConfigResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultMailboxEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/CreateDefaultMailboxEntity" style="document" />
      <wsdl:input name="CreateDefaultMailboxEntityRequest">
        <soap:header message="tns:CreateDefaultMailboxEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultMailboxEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultMailboxEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultMailboxEntityResponse">
        <soap:header message="tns:CreateDefaultMailboxEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultMailboxEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultMailboxEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultMailboxEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveMailboxEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/SaveMailboxEntity" style="document" />
      <wsdl:input name="SaveMailboxEntityRequest">
        <soap:header message="tns:SaveMailboxEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveMailboxEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveMailboxEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveMailboxEntityResponse">
        <soap:header message="tns:SaveMailboxEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveMailboxEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveMailboxEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveMailboxEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteChatSessions">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/DeleteChatSessions" style="document" />
      <wsdl:input name="DeleteChatSessionsRequest">
        <soap:header message="tns:DeleteChatSessionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteChatSessionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteChatSessionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteChatSessionsResponse">
        <soap:header message="tns:DeleteChatSessionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteChatSessionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteChatSessionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteChatSessionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChatSessionsForUser">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/ChatSessionsForUser" style="document" />
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
    <wsdl:operation name="UpdateFeatureToggles">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/UpdateFeatureToggles" style="document" />
      <wsdl:input name="UpdateFeatureTogglesRequest">
        <soap:header message="tns:UpdateFeatureTogglesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateFeatureTogglesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateFeatureTogglesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateFeatureTogglesResponse">
        <soap:header message="tns:UpdateFeatureTogglesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateFeatureTogglesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateFeatureTogglesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateFeatureTogglesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="EventHandlerExists">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/EventHandlerExists" style="document" />
      <wsdl:input name="EventHandlerExistsRequest">
        <soap:header message="tns:EventHandlerExistsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:EventHandlerExistsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:EventHandlerExistsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="EventHandlerExistsResponse">
        <soap:header message="tns:EventHandlerExistsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:EventHandlerExistsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:EventHandlerExistsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:EventHandlerExistsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="EventHandlersExists">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/EventHandlersExists" style="document" />
      <wsdl:input name="EventHandlersExistsRequest">
        <soap:header message="tns:EventHandlersExistsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:EventHandlersExistsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:EventHandlersExistsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="EventHandlersExistsResponse">
        <soap:header message="tns:EventHandlersExistsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:EventHandlersExistsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:EventHandlersExistsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:EventHandlersExistsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateSession">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/CreateSession" style="document" />
      <wsdl:input name="CreateSessionRequest">
        <soap:header message="tns:CreateSessionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateSessionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateSessionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateSessionResponse">
        <soap:header message="tns:CreateSessionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateSessionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateSessionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateSessionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveSession">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/RemoveSession" style="document" />
      <wsdl:input name="RemoveSessionRequest">
        <soap:header message="tns:RemoveSessionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveSessionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveSessionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveSessionResponse">
        <soap:header message="tns:RemoveSessionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveSessionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveSessionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveSessionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SessionIsValid">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/SessionIsValid" style="document" />
      <wsdl:input name="SessionIsValidRequest">
        <soap:header message="tns:SessionIsValidRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SessionIsValidRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SessionIsValidRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SessionIsValidResponse">
        <soap:header message="tns:SessionIsValidResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SessionIsValidResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SessionIsValidResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SessionIsValidResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="HasChatNotify">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/HasChatNotify" style="document" />
      <wsdl:input name="HasChatNotifyRequest">
        <soap:header message="tns:HasChatNotifyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:HasChatNotifyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:HasChatNotifyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="HasChatNotifyResponse">
        <soap:header message="tns:HasChatNotifyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:HasChatNotifyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:HasChatNotifyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:HasChatNotifyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CheckSymmetricEncryption">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/CheckSymmetricEncryption" style="document" />
      <wsdl:input name="CheckSymmetricEncryptionRequest">
        <soap:header message="tns:CheckSymmetricEncryptionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CheckSymmetricEncryptionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CheckSymmetricEncryptionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CheckSymmetricEncryptionResponse">
        <soap:header message="tns:CheckSymmetricEncryptionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CheckSymmetricEncryptionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CheckSymmetricEncryptionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CheckSymmetricEncryptionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ReportSessionActive">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/ReportSessionActive" style="document" />
      <wsdl:input name="ReportSessionActiveRequest">
        <soap:header message="tns:ReportSessionActiveRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ReportSessionActiveRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ReportSessionActiveRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ReportSessionActiveResponse">
        <soap:header message="tns:ReportSessionActiveResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ReportSessionActiveResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ReportSessionActiveResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ReportSessionActiveResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCustomerCenterConfig">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetCustomerCenterConfig" style="document" />
      <wsdl:input name="GetCustomerCenterConfigRequest">
        <soap:header message="tns:GetCustomerCenterConfigRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCustomerCenterConfigRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCustomerCenterConfigRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCustomerCenterConfigResponse">
        <soap:header message="tns:GetCustomerCenterConfigResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCustomerCenterConfigResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCustomerCenterConfigResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCustomerCenterConfigResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllCustomerCenterConfigs">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetAllCustomerCenterConfigs" style="document" />
      <wsdl:input name="GetAllCustomerCenterConfigsRequest">
        <soap:header message="tns:GetAllCustomerCenterConfigsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllCustomerCenterConfigsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllCustomerCenterConfigsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllCustomerCenterConfigsResponse">
        <soap:header message="tns:GetAllCustomerCenterConfigsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllCustomerCenterConfigsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllCustomerCenterConfigsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllCustomerCenterConfigsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveAllCustomerCenterConfigs">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/SaveAllCustomerCenterConfigs" style="document" />
      <wsdl:input name="SaveAllCustomerCenterConfigsRequest">
        <soap:header message="tns:SaveAllCustomerCenterConfigsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveAllCustomerCenterConfigsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveAllCustomerCenterConfigsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveAllCustomerCenterConfigsResponse">
        <soap:header message="tns:SaveAllCustomerCenterConfigsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveAllCustomerCenterConfigsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveAllCustomerCenterConfigsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveAllCustomerCenterConfigsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CheckIfCustomizedTemplates">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/CheckIfCustomizedTemplates" style="document" />
      <wsdl:input name="CheckIfCustomizedTemplatesRequest">
        <soap:header message="tns:CheckIfCustomizedTemplatesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CheckIfCustomizedTemplatesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CheckIfCustomizedTemplatesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CheckIfCustomizedTemplatesResponse">
        <soap:header message="tns:CheckIfCustomizedTemplatesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CheckIfCustomizedTemplatesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CheckIfCustomizedTemplatesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CheckIfCustomizedTemplatesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProgramUrl">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetProgramUrl" style="document" />
      <wsdl:input name="GetProgramUrlRequest">
        <soap:header message="tns:GetProgramUrlRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProgramUrlRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProgramUrlRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProgramUrlResponse">
        <soap:header message="tns:GetProgramUrlResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProgramUrlResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProgramUrlResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProgramUrlResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFaqForCustomer">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetFaqForCustomer" style="document" />
      <wsdl:input name="GetFaqForCustomerRequest">
        <soap:header message="tns:GetFaqForCustomerRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFaqForCustomerRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFaqForCustomerRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFaqForCustomerResponse">
        <soap:header message="tns:GetFaqForCustomerResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFaqForCustomerResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFaqForCustomerResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFaqForCustomerResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCustomerServiceStartup">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetCustomerServiceStartup" style="document" />
      <wsdl:input name="GetCustomerServiceStartupRequest">
        <soap:header message="tns:GetCustomerServiceStartupRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCustomerServiceStartupRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCustomerServiceStartupRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCustomerServiceStartupResponse">
        <soap:header message="tns:GetCustomerServiceStartupResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCustomerServiceStartupResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCustomerServiceStartupResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCustomerServiceStartupResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCustomerServiceStartupByOwner">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetCustomerServiceStartupByOwner" style="document" />
      <wsdl:input name="GetCustomerServiceStartupByOwnerRequest">
        <soap:header message="tns:GetCustomerServiceStartupByOwnerRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCustomerServiceStartupByOwnerRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCustomerServiceStartupByOwnerRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCustomerServiceStartupByOwnerResponse">
        <soap:header message="tns:GetCustomerServiceStartupByOwnerResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCustomerServiceStartupByOwnerResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCustomerServiceStartupByOwnerResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCustomerServiceStartupByOwnerResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ExecuteEventHandlers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/ExecuteEventHandlers" style="document" />
      <wsdl:input name="ExecuteEventHandlersRequest">
        <soap:header message="tns:ExecuteEventHandlersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ExecuteEventHandlersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ExecuteEventHandlersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ExecuteEventHandlersResponse">
        <soap:header message="tns:ExecuteEventHandlersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ExecuteEventHandlersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ExecuteEventHandlersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ExecuteEventHandlersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMailboxes">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetMailboxes" style="document" />
      <wsdl:input name="GetMailboxesRequest">
        <soap:header message="tns:GetMailboxesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMailboxesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMailboxesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMailboxesResponse">
        <soap:header message="tns:GetMailboxesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMailboxesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMailboxesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMailboxesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMailboxEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetMailboxEntity" style="document" />
      <wsdl:input name="GetMailboxEntityRequest">
        <soap:header message="tns:GetMailboxEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMailboxEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMailboxEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMailboxEntityResponse">
        <soap:header message="tns:GetMailboxEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMailboxEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMailboxEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMailboxEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPreviewFaqEntry">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetPreviewFaqEntry" style="document" />
      <wsdl:input name="GetPreviewFaqEntryRequest">
        <soap:header message="tns:GetPreviewFaqEntryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPreviewFaqEntryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPreviewFaqEntryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPreviewFaqEntryResponse">
        <soap:header message="tns:GetPreviewFaqEntryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPreviewFaqEntryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPreviewFaqEntryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPreviewFaqEntryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPreviewQuickReply">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetPreviewQuickReply" style="document" />
      <wsdl:input name="GetPreviewQuickReplyRequest">
        <soap:header message="tns:GetPreviewQuickReplyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPreviewQuickReplyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPreviewQuickReplyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPreviewQuickReplyResponse">
        <soap:header message="tns:GetPreviewQuickReplyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPreviewQuickReplyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPreviewQuickReplyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPreviewQuickReplyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPreviewReplyTemplate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetPreviewReplyTemplate" style="document" />
      <wsdl:input name="GetPreviewReplyTemplateRequest">
        <soap:header message="tns:GetPreviewReplyTemplateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPreviewReplyTemplateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPreviewReplyTemplateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPreviewReplyTemplateResponse">
        <soap:header message="tns:GetPreviewReplyTemplateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPreviewReplyTemplateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPreviewReplyTemplateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPreviewReplyTemplateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetParsedTemplate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetParsedTemplate" style="document" />
      <wsdl:input name="GetParsedTemplateRequest">
        <soap:header message="tns:GetParsedTemplateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetParsedTemplateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetParsedTemplateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetParsedTemplateResponse">
        <soap:header message="tns:GetParsedTemplateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetParsedTemplateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetParsedTemplateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetParsedTemplateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUnparsedTemplate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetUnparsedTemplate" style="document" />
      <wsdl:input name="GetUnparsedTemplateRequest">
        <soap:header message="tns:GetUnparsedTemplateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUnparsedTemplateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUnparsedTemplateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUnparsedTemplateResponse">
        <soap:header message="tns:GetUnparsedTemplateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUnparsedTemplateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUnparsedTemplateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUnparsedTemplateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSmsConfig">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetSmsConfig" style="document" />
      <wsdl:input name="GetSmsConfigRequest">
        <soap:header message="tns:GetSmsConfigRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSmsConfigRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSmsConfigRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSmsConfigResponse">
        <soap:header message="tns:GetSmsConfigResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSmsConfigResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSmsConfigResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSmsConfigResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="TestSmtpServer">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/TestSmtpServer" style="document" />
      <wsdl:input name="TestSmtpServerRequest">
        <soap:header message="tns:TestSmtpServerRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TestSmtpServerRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TestSmtpServerRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TestSmtpServerResponse">
        <soap:header message="tns:TestSmtpServerResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TestSmtpServerResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TestSmtpServerResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TestSmtpServerResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetStatistics">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetStatistics" style="document" />
      <wsdl:input name="GetStatisticsRequest">
        <soap:header message="tns:GetStatisticsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetStatisticsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetStatisticsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetStatisticsResponse">
        <soap:header message="tns:GetStatisticsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetStatisticsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetStatisticsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetStatisticsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSystemTemplateSettings">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/GetSystemTemplateSettings" style="document" />
      <wsdl:input name="GetSystemTemplateSettingsRequest">
        <soap:header message="tns:GetSystemTemplateSettingsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSystemTemplateSettingsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSystemTemplateSettingsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSystemTemplateSettingsResponse">
        <soap:header message="tns:GetSystemTemplateSettingsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSystemTemplateSettingsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSystemTemplateSettingsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSystemTemplateSettingsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveSystemTemplateSettings">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/SaveSystemTemplateSettings" style="document" />
      <wsdl:input name="SaveSystemTemplateSettingsRequest">
        <soap:header message="tns:SaveSystemTemplateSettingsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveSystemTemplateSettingsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveSystemTemplateSettingsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveSystemTemplateSettingsResponse">
        <soap:header message="tns:SaveSystemTemplateSettingsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveSystemTemplateSettingsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveSystemTemplateSettingsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveSystemTemplateSettingsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateTicketFromMailData">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/CreateTicketFromMailData" style="document" />
      <wsdl:input name="CreateTicketFromMailDataRequest">
        <soap:header message="tns:CreateTicketFromMailDataRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateTicketFromMailDataRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateTicketFromMailDataRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateTicketFromMailDataResponse">
        <soap:header message="tns:CreateTicketFromMailDataResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateTicketFromMailDataResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateTicketFromMailDataResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateTicketFromMailDataResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddMessageFromMailData">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/AddMessageFromMailData" style="document" />
      <wsdl:input name="AddMessageFromMailDataRequest">
        <soap:header message="tns:AddMessageFromMailDataRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddMessageFromMailDataRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddMessageFromMailDataRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddMessageFromMailDataResponse">
        <soap:header message="tns:AddMessageFromMailDataResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddMessageFromMailDataResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddMessageFromMailDataResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddMessageFromMailDataResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindTicketsByTitleOrId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/CustomerService/FindTicketsByTitleOrId" style="document" />
      <wsdl:input name="FindTicketsByTitleOrIdRequest">
        <soap:header message="tns:FindTicketsByTitleOrIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindTicketsByTitleOrIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindTicketsByTitleOrIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindTicketsByTitleOrIdResponse">
        <soap:header message="tns:FindTicketsByTitleOrIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindTicketsByTitleOrIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindTicketsByTitleOrIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindTicketsByTitleOrIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfCustomerServiceService">
    <wsdl:port name="BasicHttpBinding_CustomerService" binding="tns:BasicHttpBinding_CustomerService">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/CustomerService.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

