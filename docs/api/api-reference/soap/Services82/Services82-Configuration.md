---
Generated: 1
TOCExclude: 1
title: Services82.ConfigurationAgent WSDL
---

# Services82.ConfigurationAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfConfigurationService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services82" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services82" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services82" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultDiaryViewEntity">
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
      <xs:element name="CreateDefaultDiaryViewEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DiaryViewEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="DiaryViewEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="DiaryViewId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="VisibleColumns" type="xs:short" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="AssocId" type="xs:int" />
              <xs:element minOccurs="0" name="AssociateList" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
              <xs:element minOccurs="0" name="TzLocationId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DiaryViewEntity" nillable="true" type="tns:DiaryViewEntity" />
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
      <xs:complexType name="ArrayOfSelectableMDOListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="SelectableMDOListItem" nillable="true" type="tns:SelectableMDOListItem" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfSelectableMDOListItem" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
      <xs:complexType name="SelectableMDOListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
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
              <xs:element minOccurs="0" name="ChildItems" nillable="true" type="tns:ArrayOfSelectableMDOListItem" />
              <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StyleHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Hidden" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SelectableMDOListItem" nillable="true" type="tns:SelectableMDOListItem" />
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
      <xs:element name="SaveDiaryViewEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DiaryViewEntity" nillable="true" type="tns:DiaryViewEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDiaryViewEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DiaryViewEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDiaryViewEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DiaryViewEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDiaryViewEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultSystemEventEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultSystemEventEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SystemEventEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SystemEventEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="SystemEventId" type="xs:int" />
              <xs:element minOccurs="0" name="Scope" type="tns:SystemEventScope" />
              <xs:element minOccurs="0" name="Eta" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Eventkey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Eventmess" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraInfo" type="xs:int" />
              <xs:element minOccurs="0" name="Owner" type="xs:int" />
              <xs:element minOccurs="0" name="UpdatedCount" type="xs:short" />
              <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ActivatedBy" nillable="true" type="tns:Associate" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SystemEventEntity" nillable="true" type="tns:SystemEventEntity" />
      <xs:simpleType name="SystemEventScope">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Undefined" />
          <xs:enumeration value="SystemWide" />
          <xs:enumeration value="Database" />
          <xs:enumeration value="Group" />
          <xs:enumeration value="User" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="SystemEventScope" nillable="true" type="tns:SystemEventScope" />
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
      <xs:element name="SaveSystemEventEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SystemEventEntity" nillable="true" type="tns:SystemEventEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveSystemEventEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SystemEventEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteSystemEventEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SystemEventEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteSystemEventEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetApplicationConfiguration">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Application" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Instance" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetApplicationConfigurationResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPageConfiguration">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Application" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Instance" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Page" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPageConfigurationResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetObjectMapping">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Application" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Instance" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetObjectMappingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFilterList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Application" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Instance" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFilterListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ClearConfigurationCache">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Application" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Instance" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ForAllAssociates" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ClearConfigurationCacheResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAnyConfiguration">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Application" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Instance" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Item" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAnyConfigurationResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMarketingUrl">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Language" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMarketingUrlResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCsProgramUrl">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Language" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProgramName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Action" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ExtraParameters" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCsProgramUrlResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCSAuthUrl">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Language" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ProgramName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Action" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ExtraParameters" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCSAuthUrlResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRefreshedPageConfiguration">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Application" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Instance" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Page" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRefreshedPageConfigurationResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWwwUrl">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Client" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWwwUrlResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetHelpDispatcherUrl">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetHelpDispatcherUrlResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWwwUrlForSMWeb">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWwwUrlForSMWebResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCsCgiUrlInternal">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCsCgiUrlInternalResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCRMUrl">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SoProtocol" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Currents" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Frameless" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCRMUrlResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDiaryViewEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DiaryViewEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDiaryViewEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:DiaryViewEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWindowPosSize">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WindowPosSizeId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWindowPosSizeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WindowPosSize" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="WindowPosSize">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="OwnerWindow" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="ExtraId" type="xs:int" />
              <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Height" type="xs:int" />
              <xs:element minOccurs="0" name="LeftX" type="xs:int" />
              <xs:element minOccurs="0" name="State" type="tns:ShowWindowState" />
              <xs:element minOccurs="0" name="UpperY" type="xs:int" />
              <xs:element minOccurs="0" name="Width" type="xs:int" />
              <xs:element minOccurs="0" name="WindowPosSizeId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WindowPosSize" nillable="true" type="tns:WindowPosSize" />
      <xs:simpleType name="ShowWindowState">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Normal" />
          <xs:enumeration value="Maximized" />
          <xs:enumeration value="Minimized" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ShowWindowState" nillable="true" type="tns:ShowWindowState" />
      <xs:element name="SaveWindowPosSize">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WindowPosSize" nillable="true" type="tns:WindowPosSize" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveWindowPosSizeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WindowPosSize" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteWindowPosSize">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WindowPosSizeId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteWindowPosSizeResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWindowPosSizeList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WindowPosSizeIds" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWindowPosSizeListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfWindowPosSize" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfWindowPosSize">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="WindowPosSize" nillable="true" type="tns:WindowPosSize" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfWindowPosSize" nillable="true" type="tns:ArrayOfWindowPosSize" />
      <xs:element name="GetMyWindowPosSizes">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyWindowPosSizesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfWindowPosSize" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWindowPosSizesOnPersonId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWindowPosSizesOnPersonIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfWindowPosSize" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWindowPosSizesOnAssociateId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWindowPosSizesOnAssociateIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfWindowPosSize" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveWindowPosSizes">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WindowPosSizes" nillable="true" type="tns:ArrayOfWindowPosSize" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveWindowPosSizesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfWindowPosSize" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSystemEventEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SystemEventEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSystemEventEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:SystemEventEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExistsSystemEvent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Key" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExistsSystemEventResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
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
  <wsdl:message name="CreateDefaultDiaryViewEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultDiaryViewEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDiaryViewEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDiaryViewEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultDiaryViewEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultDiaryViewEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDiaryViewEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveDiaryViewEntity" />
  </wsdl:message>
  <wsdl:message name="SaveDiaryViewEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDiaryViewEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveDiaryViewEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveDiaryViewEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDiaryViewEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteDiaryViewEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteDiaryViewEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDiaryViewEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteDiaryViewEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteDiaryViewEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSystemEventEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultSystemEventEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSystemEventEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSystemEventEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultSystemEventEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSystemEventEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSystemEventEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveSystemEventEntity" />
  </wsdl:message>
  <wsdl:message name="SaveSystemEventEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSystemEventEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveSystemEventEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveSystemEventEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteSystemEventEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteSystemEventEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteSystemEventEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteSystemEventEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteSystemEventEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteSystemEventEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetApplicationConfigurationRequest">
    <wsdl:part name="parameters" element="tns:GetApplicationConfiguration" />
  </wsdl:message>
  <wsdl:message name="GetApplicationConfigurationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetApplicationConfigurationResponse">
    <wsdl:part name="parameters" element="tns:GetApplicationConfigurationResponse" />
  </wsdl:message>
  <wsdl:message name="GetApplicationConfigurationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPageConfigurationRequest">
    <wsdl:part name="parameters" element="tns:GetPageConfiguration" />
  </wsdl:message>
  <wsdl:message name="GetPageConfigurationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPageConfigurationResponse">
    <wsdl:part name="parameters" element="tns:GetPageConfigurationResponse" />
  </wsdl:message>
  <wsdl:message name="GetPageConfigurationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetObjectMappingRequest">
    <wsdl:part name="parameters" element="tns:GetObjectMapping" />
  </wsdl:message>
  <wsdl:message name="GetObjectMappingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetObjectMappingResponse">
    <wsdl:part name="parameters" element="tns:GetObjectMappingResponse" />
  </wsdl:message>
  <wsdl:message name="GetObjectMappingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFilterListRequest">
    <wsdl:part name="parameters" element="tns:GetFilterList" />
  </wsdl:message>
  <wsdl:message name="GetFilterListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFilterListResponse">
    <wsdl:part name="parameters" element="tns:GetFilterListResponse" />
  </wsdl:message>
  <wsdl:message name="GetFilterListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ClearConfigurationCacheRequest">
    <wsdl:part name="parameters" element="tns:ClearConfigurationCache" />
  </wsdl:message>
  <wsdl:message name="ClearConfigurationCacheRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ClearConfigurationCacheResponse">
    <wsdl:part name="parameters" element="tns:ClearConfigurationCacheResponse" />
  </wsdl:message>
  <wsdl:message name="ClearConfigurationCacheResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAnyConfigurationRequest">
    <wsdl:part name="parameters" element="tns:GetAnyConfiguration" />
  </wsdl:message>
  <wsdl:message name="GetAnyConfigurationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAnyConfigurationResponse">
    <wsdl:part name="parameters" element="tns:GetAnyConfigurationResponse" />
  </wsdl:message>
  <wsdl:message name="GetAnyConfigurationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMarketingUrlRequest">
    <wsdl:part name="parameters" element="tns:GetEMarketingUrl" />
  </wsdl:message>
  <wsdl:message name="GetEMarketingUrlRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMarketingUrlResponse">
    <wsdl:part name="parameters" element="tns:GetEMarketingUrlResponse" />
  </wsdl:message>
  <wsdl:message name="GetEMarketingUrlResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCsProgramUrlRequest">
    <wsdl:part name="parameters" element="tns:GetCsProgramUrl" />
  </wsdl:message>
  <wsdl:message name="GetCsProgramUrlRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCsProgramUrlResponse">
    <wsdl:part name="parameters" element="tns:GetCsProgramUrlResponse" />
  </wsdl:message>
  <wsdl:message name="GetCsProgramUrlResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCSAuthUrlRequest">
    <wsdl:part name="parameters" element="tns:GetCSAuthUrl" />
  </wsdl:message>
  <wsdl:message name="GetCSAuthUrlRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCSAuthUrlResponse">
    <wsdl:part name="parameters" element="tns:GetCSAuthUrlResponse" />
  </wsdl:message>
  <wsdl:message name="GetCSAuthUrlResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRefreshedPageConfigurationRequest">
    <wsdl:part name="parameters" element="tns:GetRefreshedPageConfiguration" />
  </wsdl:message>
  <wsdl:message name="GetRefreshedPageConfigurationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRefreshedPageConfigurationResponse">
    <wsdl:part name="parameters" element="tns:GetRefreshedPageConfigurationResponse" />
  </wsdl:message>
  <wsdl:message name="GetRefreshedPageConfigurationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWwwUrlRequest">
    <wsdl:part name="parameters" element="tns:GetWwwUrl" />
  </wsdl:message>
  <wsdl:message name="GetWwwUrlRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWwwUrlResponse">
    <wsdl:part name="parameters" element="tns:GetWwwUrlResponse" />
  </wsdl:message>
  <wsdl:message name="GetWwwUrlResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHelpDispatcherUrlRequest">
    <wsdl:part name="parameters" element="tns:GetHelpDispatcherUrl" />
  </wsdl:message>
  <wsdl:message name="GetHelpDispatcherUrlRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetHelpDispatcherUrlResponse">
    <wsdl:part name="parameters" element="tns:GetHelpDispatcherUrlResponse" />
  </wsdl:message>
  <wsdl:message name="GetHelpDispatcherUrlResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWwwUrlForSMWebRequest">
    <wsdl:part name="parameters" element="tns:GetWwwUrlForSMWeb" />
  </wsdl:message>
  <wsdl:message name="GetWwwUrlForSMWebRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWwwUrlForSMWebResponse">
    <wsdl:part name="parameters" element="tns:GetWwwUrlForSMWebResponse" />
  </wsdl:message>
  <wsdl:message name="GetWwwUrlForSMWebResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCsCgiUrlInternalRequest">
    <wsdl:part name="parameters" element="tns:GetCsCgiUrlInternal" />
  </wsdl:message>
  <wsdl:message name="GetCsCgiUrlInternalRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCsCgiUrlInternalResponse">
    <wsdl:part name="parameters" element="tns:GetCsCgiUrlInternalResponse" />
  </wsdl:message>
  <wsdl:message name="GetCsCgiUrlInternalResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCRMUrlRequest">
    <wsdl:part name="parameters" element="tns:GetCRMUrl" />
  </wsdl:message>
  <wsdl:message name="GetCRMUrlRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCRMUrlResponse">
    <wsdl:part name="parameters" element="tns:GetCRMUrlResponse" />
  </wsdl:message>
  <wsdl:message name="GetCRMUrlResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDiaryViewEntityRequest">
    <wsdl:part name="parameters" element="tns:GetDiaryViewEntity" />
  </wsdl:message>
  <wsdl:message name="GetDiaryViewEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDiaryViewEntityResponse">
    <wsdl:part name="parameters" element="tns:GetDiaryViewEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetDiaryViewEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWindowPosSizeRequest">
    <wsdl:part name="parameters" element="tns:GetWindowPosSize" />
  </wsdl:message>
  <wsdl:message name="GetWindowPosSizeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWindowPosSizeResponse">
    <wsdl:part name="parameters" element="tns:GetWindowPosSizeResponse" />
  </wsdl:message>
  <wsdl:message name="GetWindowPosSizeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveWindowPosSizeRequest">
    <wsdl:part name="parameters" element="tns:SaveWindowPosSize" />
  </wsdl:message>
  <wsdl:message name="SaveWindowPosSizeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveWindowPosSizeResponse">
    <wsdl:part name="parameters" element="tns:SaveWindowPosSizeResponse" />
  </wsdl:message>
  <wsdl:message name="SaveWindowPosSizeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteWindowPosSizeRequest">
    <wsdl:part name="parameters" element="tns:DeleteWindowPosSize" />
  </wsdl:message>
  <wsdl:message name="DeleteWindowPosSizeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteWindowPosSizeResponse">
    <wsdl:part name="parameters" element="tns:DeleteWindowPosSizeResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteWindowPosSizeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWindowPosSizeListRequest">
    <wsdl:part name="parameters" element="tns:GetWindowPosSizeList" />
  </wsdl:message>
  <wsdl:message name="GetWindowPosSizeListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWindowPosSizeListResponse">
    <wsdl:part name="parameters" element="tns:GetWindowPosSizeListResponse" />
  </wsdl:message>
  <wsdl:message name="GetWindowPosSizeListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyWindowPosSizesRequest">
    <wsdl:part name="parameters" element="tns:GetMyWindowPosSizes" />
  </wsdl:message>
  <wsdl:message name="GetMyWindowPosSizesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyWindowPosSizesResponse">
    <wsdl:part name="parameters" element="tns:GetMyWindowPosSizesResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyWindowPosSizesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWindowPosSizesOnPersonIdRequest">
    <wsdl:part name="parameters" element="tns:GetWindowPosSizesOnPersonId" />
  </wsdl:message>
  <wsdl:message name="GetWindowPosSizesOnPersonIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWindowPosSizesOnPersonIdResponse">
    <wsdl:part name="parameters" element="tns:GetWindowPosSizesOnPersonIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetWindowPosSizesOnPersonIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWindowPosSizesOnAssociateIdRequest">
    <wsdl:part name="parameters" element="tns:GetWindowPosSizesOnAssociateId" />
  </wsdl:message>
  <wsdl:message name="GetWindowPosSizesOnAssociateIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWindowPosSizesOnAssociateIdResponse">
    <wsdl:part name="parameters" element="tns:GetWindowPosSizesOnAssociateIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetWindowPosSizesOnAssociateIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveWindowPosSizesRequest">
    <wsdl:part name="parameters" element="tns:SaveWindowPosSizes" />
  </wsdl:message>
  <wsdl:message name="SaveWindowPosSizesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveWindowPosSizesResponse">
    <wsdl:part name="parameters" element="tns:SaveWindowPosSizesResponse" />
  </wsdl:message>
  <wsdl:message name="SaveWindowPosSizesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSystemEventEntityRequest">
    <wsdl:part name="parameters" element="tns:GetSystemEventEntity" />
  </wsdl:message>
  <wsdl:message name="GetSystemEventEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSystemEventEntityResponse">
    <wsdl:part name="parameters" element="tns:GetSystemEventEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetSystemEventEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExistsSystemEventRequest">
    <wsdl:part name="parameters" element="tns:ExistsSystemEvent" />
  </wsdl:message>
  <wsdl:message name="ExistsSystemEventRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExistsSystemEventResponse">
    <wsdl:part name="parameters" element="tns:ExistsSystemEventResponse" />
  </wsdl:message>
  <wsdl:message name="ExistsSystemEventResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Configuration">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Configuration</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultDiaryViewEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new DiaryViewEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/CreateDefaultDiaryViewEntity" name="CreateDefaultDiaryViewEntityRequest" message="tns:CreateDefaultDiaryViewEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/CreateDefaultDiaryViewEntityResponse" name="CreateDefaultDiaryViewEntityResponse" message="tns:CreateDefaultDiaryViewEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveDiaryViewEntity">
      <wsdl:documentation>
        <summary>Updates the existing DiaryViewEntity or creates a new DiaryViewEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/SaveDiaryViewEntity" name="SaveDiaryViewEntityRequest" message="tns:SaveDiaryViewEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/SaveDiaryViewEntityResponse" name="SaveDiaryViewEntityResponse" message="tns:SaveDiaryViewEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteDiaryViewEntity">
      <wsdl:documentation>
        <summary>Deletes the DiaryViewEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/DeleteDiaryViewEntity" name="DeleteDiaryViewEntityRequest" message="tns:DeleteDiaryViewEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/DeleteDiaryViewEntityResponse" name="DeleteDiaryViewEntityResponse" message="tns:DeleteDiaryViewEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultSystemEventEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new SystemEventEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/CreateDefaultSystemEventEntity" name="CreateDefaultSystemEventEntityRequest" message="tns:CreateDefaultSystemEventEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/CreateDefaultSystemEventEntityResponse" name="CreateDefaultSystemEventEntityResponse" message="tns:CreateDefaultSystemEventEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveSystemEventEntity">
      <wsdl:documentation>
        <summary>Updates the existing SystemEventEntity or creates a new SystemEventEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/SaveSystemEventEntity" name="SaveSystemEventEntityRequest" message="tns:SaveSystemEventEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/SaveSystemEventEntityResponse" name="SaveSystemEventEntityResponse" message="tns:SaveSystemEventEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteSystemEventEntity">
      <wsdl:documentation>
        <summary>Deletes the SystemEventEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/DeleteSystemEventEntity" name="DeleteSystemEventEntityRequest" message="tns:DeleteSystemEventEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/DeleteSystemEventEntityResponse" name="DeleteSystemEventEntityResponse" message="tns:DeleteSystemEventEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetApplicationConfiguration">
      <wsdl:documentation>
        <summary>Return the application configuration. This is a list of pages, with information about the name, main panel and preference mappings of each page.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetApplicationConfiguration" name="GetApplicationConfigurationRequest" message="tns:GetApplicationConfigurationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetApplicationConfigurationResponse" name="GetApplicationConfigurationResponse" message="tns:GetApplicationConfigurationResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPageConfiguration">
      <wsdl:documentation>
        <summary>Get the configuration for one whole web page, including all its panels etc.  totally asynchronous items like menus are not included, but all references are resolved and all special processing is applied.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetPageConfiguration" name="GetPageConfigurationRequest" message="tns:GetPageConfigurationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetPageConfigurationResponse" name="GetPageConfigurationResponse" message="tns:GetPageConfigurationResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetObjectMapping">
      <wsdl:documentation>
        <summary>Get the object mappings, i.e., the what code objects should be instantiated to handle the entities of the client configuration.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetObjectMapping" name="GetObjectMappingRequest" message="tns:GetObjectMappingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetObjectMappingResponse" name="GetObjectMappingResponse" message="tns:GetObjectMappingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFilterList">
      <wsdl:documentation>
        <summary>Get the list of filters to be used for processing the configuration data for this application.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetFilterList" name="GetFilterListRequest" message="tns:GetFilterListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetFilterListResponse" name="GetFilterListResponse" message="tns:GetFilterListResponse" />
    </wsdl:operation>
    <wsdl:operation name="ClearConfigurationCache">
      <wsdl:documentation>
        <summary>Configuration XML's may be expensive to build and parse, and are therefore cached to the database. &lt;para/&gt;Cahcing is per application/instance/associate, and can be turned off through the config file. &lt;para/&gt;If caching is on, and the configuration is changed, it is necessary to clear the cached configurations from the database, through this call.&lt;para/&gt;Note that changes to the externalapplication table require cache invalidation. SoAdmin will do so automatically.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/ClearConfigurationCache" name="ClearConfigurationCacheRequest" message="tns:ClearConfigurationCacheRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/ClearConfigurationCacheResponse" name="ClearConfigurationCacheResponse" message="tns:ClearConfigurationCacheResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAnyConfiguration">
      <wsdl:documentation>
        <summary>Get one defined configuration fragment, with full reference resolution and parsing applied. This is essentially the same service as the GetPageConfiguration, except that this service is not locked to objects of type Page.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetAnyConfiguration" name="GetAnyConfigurationRequest" message="tns:GetAnyConfigurationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetAnyConfigurationResponse" name="GetAnyConfigurationResponse" message="tns:GetAnyConfigurationResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEMarketingUrl">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetEMarketingUrl" name="GetEMarketingUrlRequest" message="tns:GetEMarketingUrlRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetEMarketingUrlResponse" name="GetEMarketingUrlResponse" message="tns:GetEMarketingUrlResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCsProgramUrl">
      <wsdl:documentation>
        <summary>This method will convert a module name into a CS URL.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetCsProgramUrl" name="GetCsProgramUrlRequest" message="tns:GetCsProgramUrlRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetCsProgramUrlResponse" name="GetCsProgramUrlResponse" message="tns:GetCsProgramUrlResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCSAuthUrl">
      <wsdl:documentation>
        <summary>Will generate an url to the emarketing module</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetCSAuthUrl" name="GetCSAuthUrlRequest" message="tns:GetCSAuthUrlRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetCSAuthUrlResponse" name="GetCSAuthUrlResponse" message="tns:GetCSAuthUrlResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetRefreshedPageConfiguration">
      <wsdl:documentation>
        <summary>Get the configuration for one whole web page, including all its panels etc.  totally asynchronous items like menus are not included, but all references are resolved and all special processing is applied. Does not use cache for fetching, but updates the cache with refreshed configuration.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetRefreshedPageConfiguration" name="GetRefreshedPageConfigurationRequest" message="tns:GetRefreshedPageConfigurationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetRefreshedPageConfigurationResponse" name="GetRefreshedPageConfigurationResponse" message="tns:GetRefreshedPageConfigurationResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetWwwUrl">
      <wsdl:documentation>
        <summary>Will get the default URL used for the logo, from the [NetServices] PageUrl preferencec, with tags substituted.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetWwwUrl" name="GetWwwUrlRequest" message="tns:GetWwwUrlRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetWwwUrlResponse" name="GetWwwUrlResponse" message="tns:GetWwwUrlResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetHelpDispatcherUrl">
      <wsdl:documentation>
        <summary>Will get the GetHelpDispatcherUrl used by the help system</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetHelpDispatcherUrl" name="GetHelpDispatcherUrlRequest" message="tns:GetHelpDispatcherUrlRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetHelpDispatcherUrlResponse" name="GetHelpDispatcherUrlResponse" message="tns:GetHelpDispatcherUrlResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetWwwUrlForSMWeb">
      <wsdl:documentation>
        <summary>Returns the URL used for the logo by the SM.web client. Uses urldispatch.aspx</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetWwwUrlForSMWeb" name="GetWwwUrlForSMWebRequest" message="tns:GetWwwUrlForSMWebRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetWwwUrlForSMWebResponse" name="GetWwwUrlForSMWebResponse" message="tns:GetWwwUrlForSMWebResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCsCgiUrlInternal">
      <wsdl:documentation>
        <summary>This method will get the host name for CS</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetCsCgiUrlInternal" name="GetCsCgiUrlInternalRequest" message="tns:GetCsCgiUrlInternalRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetCsCgiUrlInternalResponse" name="GetCsCgiUrlInternalResponse" message="tns:GetCsCgiUrlInternalResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCRMUrl">
      <wsdl:documentation>
        <summary>Returns a valid url based in the soprotocol provided</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetCRMUrl" name="GetCRMUrlRequest" message="tns:GetCRMUrlRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetCRMUrlResponse" name="GetCRMUrlResponse" message="tns:GetCRMUrlResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDiaryViewEntity">
      <wsdl:documentation>
        <summary>Gets a DiaryViewEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetDiaryViewEntity" name="GetDiaryViewEntityRequest" message="tns:GetDiaryViewEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetDiaryViewEntityResponse" name="GetDiaryViewEntityResponse" message="tns:GetDiaryViewEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetWindowPosSize">
      <wsdl:documentation>
        <summary>Gets a WindowPosSize object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetWindowPosSize" name="GetWindowPosSizeRequest" message="tns:GetWindowPosSizeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetWindowPosSizeResponse" name="GetWindowPosSizeResponse" message="tns:GetWindowPosSizeResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveWindowPosSize">
      <wsdl:documentation>
        <summary>Saves a window and dialog position and size setting.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/SaveWindowPosSize" name="SaveWindowPosSizeRequest" message="tns:SaveWindowPosSizeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/SaveWindowPosSizeResponse" name="SaveWindowPosSizeResponse" message="tns:SaveWindowPosSizeResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteWindowPosSize">
      <wsdl:documentation>
        <summary>Deletes a window and dialog position and size setting.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/DeleteWindowPosSize" name="DeleteWindowPosSizeRequest" message="tns:DeleteWindowPosSizeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/DeleteWindowPosSizeResponse" name="DeleteWindowPosSizeResponse" message="tns:DeleteWindowPosSizeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetWindowPosSizeList">
      <wsdl:documentation>
        <summary>Gets an array of WindowPosSize objects..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetWindowPosSizeList" name="GetWindowPosSizeListRequest" message="tns:GetWindowPosSizeListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetWindowPosSizeListResponse" name="GetWindowPosSizeListResponse" message="tns:GetWindowPosSizeListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyWindowPosSizes">
      <wsdl:documentation>
        <summary>Gets the window and dialog position and size settings belonging to the currently logged on user</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetMyWindowPosSizes" name="GetMyWindowPosSizesRequest" message="tns:GetMyWindowPosSizesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetMyWindowPosSizesResponse" name="GetMyWindowPosSizesResponse" message="tns:GetMyWindowPosSizesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetWindowPosSizesOnPersonId">
      <wsdl:documentation>
        <summary>Gets the window and dialog position and size settings belonging to the specified person</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetWindowPosSizesOnPersonId" name="GetWindowPosSizesOnPersonIdRequest" message="tns:GetWindowPosSizesOnPersonIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetWindowPosSizesOnPersonIdResponse" name="GetWindowPosSizesOnPersonIdResponse" message="tns:GetWindowPosSizesOnPersonIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetWindowPosSizesOnAssociateId">
      <wsdl:documentation>
        <summary>Gets the window and dialog position and size settings belonging to the specified associate</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetWindowPosSizesOnAssociateId" name="GetWindowPosSizesOnAssociateIdRequest" message="tns:GetWindowPosSizesOnAssociateIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetWindowPosSizesOnAssociateIdResponse" name="GetWindowPosSizesOnAssociateIdResponse" message="tns:GetWindowPosSizesOnAssociateIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveWindowPosSizes">
      <wsdl:documentation>
        <summary>Saves a set of window and dialog position and size settings.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/SaveWindowPosSizes" name="SaveWindowPosSizesRequest" message="tns:SaveWindowPosSizesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/SaveWindowPosSizesResponse" name="SaveWindowPosSizesResponse" message="tns:SaveWindowPosSizesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSystemEventEntity">
      <wsdl:documentation>
        <summary>Gets a SystemEventEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetSystemEventEntity" name="GetSystemEventEntityRequest" message="tns:GetSystemEventEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetSystemEventEntityResponse" name="GetSystemEventEntityResponse" message="tns:GetSystemEventEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="ExistsSystemEvent">
      <wsdl:documentation>
        <summary>Is there a system event with the given key?</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/ExistsSystemEvent" name="ExistsSystemEventRequest" message="tns:ExistsSystemEventRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/ExistsSystemEventResponse" name="ExistsSystemEventResponse" message="tns:ExistsSystemEventResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Configuration" type="tns:Configuration">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultDiaryViewEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/CreateDefaultDiaryViewEntity" style="document" />
      <wsdl:input name="CreateDefaultDiaryViewEntityRequest">
        <soap:header message="tns:CreateDefaultDiaryViewEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultDiaryViewEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultDiaryViewEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultDiaryViewEntityResponse">
        <soap:header message="tns:CreateDefaultDiaryViewEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDiaryViewEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultDiaryViewEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultDiaryViewEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveDiaryViewEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/SaveDiaryViewEntity" style="document" />
      <wsdl:input name="SaveDiaryViewEntityRequest">
        <soap:header message="tns:SaveDiaryViewEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveDiaryViewEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveDiaryViewEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveDiaryViewEntityResponse">
        <soap:header message="tns:SaveDiaryViewEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveDiaryViewEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveDiaryViewEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveDiaryViewEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteDiaryViewEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/DeleteDiaryViewEntity" style="document" />
      <wsdl:input name="DeleteDiaryViewEntityRequest">
        <soap:header message="tns:DeleteDiaryViewEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteDiaryViewEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteDiaryViewEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteDiaryViewEntityResponse">
        <soap:header message="tns:DeleteDiaryViewEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteDiaryViewEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteDiaryViewEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteDiaryViewEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultSystemEventEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/CreateDefaultSystemEventEntity" style="document" />
      <wsdl:input name="CreateDefaultSystemEventEntityRequest">
        <soap:header message="tns:CreateDefaultSystemEventEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultSystemEventEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultSystemEventEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultSystemEventEntityResponse">
        <soap:header message="tns:CreateDefaultSystemEventEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSystemEventEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSystemEventEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultSystemEventEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveSystemEventEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/SaveSystemEventEntity" style="document" />
      <wsdl:input name="SaveSystemEventEntityRequest">
        <soap:header message="tns:SaveSystemEventEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveSystemEventEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveSystemEventEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveSystemEventEntityResponse">
        <soap:header message="tns:SaveSystemEventEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveSystemEventEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveSystemEventEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveSystemEventEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteSystemEventEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/DeleteSystemEventEntity" style="document" />
      <wsdl:input name="DeleteSystemEventEntityRequest">
        <soap:header message="tns:DeleteSystemEventEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteSystemEventEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteSystemEventEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteSystemEventEntityResponse">
        <soap:header message="tns:DeleteSystemEventEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteSystemEventEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteSystemEventEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteSystemEventEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetApplicationConfiguration">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetApplicationConfiguration" style="document" />
      <wsdl:input name="GetApplicationConfigurationRequest">
        <soap:header message="tns:GetApplicationConfigurationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetApplicationConfigurationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetApplicationConfigurationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetApplicationConfigurationResponse">
        <soap:header message="tns:GetApplicationConfigurationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetApplicationConfigurationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetApplicationConfigurationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetApplicationConfigurationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPageConfiguration">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetPageConfiguration" style="document" />
      <wsdl:input name="GetPageConfigurationRequest">
        <soap:header message="tns:GetPageConfigurationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPageConfigurationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPageConfigurationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPageConfigurationResponse">
        <soap:header message="tns:GetPageConfigurationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPageConfigurationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPageConfigurationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPageConfigurationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetObjectMapping">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetObjectMapping" style="document" />
      <wsdl:input name="GetObjectMappingRequest">
        <soap:header message="tns:GetObjectMappingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetObjectMappingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetObjectMappingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetObjectMappingResponse">
        <soap:header message="tns:GetObjectMappingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetObjectMappingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetObjectMappingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetObjectMappingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFilterList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetFilterList" style="document" />
      <wsdl:input name="GetFilterListRequest">
        <soap:header message="tns:GetFilterListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFilterListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFilterListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFilterListResponse">
        <soap:header message="tns:GetFilterListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFilterListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFilterListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFilterListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ClearConfigurationCache">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/ClearConfigurationCache" style="document" />
      <wsdl:input name="ClearConfigurationCacheRequest">
        <soap:header message="tns:ClearConfigurationCacheRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ClearConfigurationCacheRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ClearConfigurationCacheRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ClearConfigurationCacheResponse">
        <soap:header message="tns:ClearConfigurationCacheResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ClearConfigurationCacheResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ClearConfigurationCacheResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ClearConfigurationCacheResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAnyConfiguration">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetAnyConfiguration" style="document" />
      <wsdl:input name="GetAnyConfigurationRequest">
        <soap:header message="tns:GetAnyConfigurationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAnyConfigurationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAnyConfigurationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAnyConfigurationResponse">
        <soap:header message="tns:GetAnyConfigurationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAnyConfigurationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAnyConfigurationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAnyConfigurationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEMarketingUrl">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetEMarketingUrl" style="document" />
      <wsdl:input name="GetEMarketingUrlRequest">
        <soap:header message="tns:GetEMarketingUrlRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEMarketingUrlRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEMarketingUrlRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEMarketingUrlResponse">
        <soap:header message="tns:GetEMarketingUrlResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEMarketingUrlResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEMarketingUrlResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEMarketingUrlResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCsProgramUrl">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetCsProgramUrl" style="document" />
      <wsdl:input name="GetCsProgramUrlRequest">
        <soap:header message="tns:GetCsProgramUrlRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCsProgramUrlRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCsProgramUrlRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCsProgramUrlResponse">
        <soap:header message="tns:GetCsProgramUrlResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCsProgramUrlResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCsProgramUrlResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCsProgramUrlResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCSAuthUrl">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetCSAuthUrl" style="document" />
      <wsdl:input name="GetCSAuthUrlRequest">
        <soap:header message="tns:GetCSAuthUrlRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCSAuthUrlRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCSAuthUrlRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCSAuthUrlResponse">
        <soap:header message="tns:GetCSAuthUrlResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCSAuthUrlResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCSAuthUrlResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCSAuthUrlResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetRefreshedPageConfiguration">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetRefreshedPageConfiguration" style="document" />
      <wsdl:input name="GetRefreshedPageConfigurationRequest">
        <soap:header message="tns:GetRefreshedPageConfigurationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetRefreshedPageConfigurationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetRefreshedPageConfigurationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetRefreshedPageConfigurationResponse">
        <soap:header message="tns:GetRefreshedPageConfigurationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetRefreshedPageConfigurationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetRefreshedPageConfigurationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetRefreshedPageConfigurationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetWwwUrl">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetWwwUrl" style="document" />
      <wsdl:input name="GetWwwUrlRequest">
        <soap:header message="tns:GetWwwUrlRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetWwwUrlRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetWwwUrlRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetWwwUrlResponse">
        <soap:header message="tns:GetWwwUrlResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetWwwUrlResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetWwwUrlResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetWwwUrlResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetHelpDispatcherUrl">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetHelpDispatcherUrl" style="document" />
      <wsdl:input name="GetHelpDispatcherUrlRequest">
        <soap:header message="tns:GetHelpDispatcherUrlRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetHelpDispatcherUrlRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetHelpDispatcherUrlRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetHelpDispatcherUrlResponse">
        <soap:header message="tns:GetHelpDispatcherUrlResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetHelpDispatcherUrlResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetHelpDispatcherUrlResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetHelpDispatcherUrlResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetWwwUrlForSMWeb">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetWwwUrlForSMWeb" style="document" />
      <wsdl:input name="GetWwwUrlForSMWebRequest">
        <soap:header message="tns:GetWwwUrlForSMWebRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetWwwUrlForSMWebRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetWwwUrlForSMWebRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetWwwUrlForSMWebResponse">
        <soap:header message="tns:GetWwwUrlForSMWebResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetWwwUrlForSMWebResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetWwwUrlForSMWebResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetWwwUrlForSMWebResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCsCgiUrlInternal">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetCsCgiUrlInternal" style="document" />
      <wsdl:input name="GetCsCgiUrlInternalRequest">
        <soap:header message="tns:GetCsCgiUrlInternalRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCsCgiUrlInternalRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCsCgiUrlInternalRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCsCgiUrlInternalResponse">
        <soap:header message="tns:GetCsCgiUrlInternalResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCsCgiUrlInternalResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCsCgiUrlInternalResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCsCgiUrlInternalResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCRMUrl">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetCRMUrl" style="document" />
      <wsdl:input name="GetCRMUrlRequest">
        <soap:header message="tns:GetCRMUrlRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCRMUrlRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCRMUrlRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCRMUrlResponse">
        <soap:header message="tns:GetCRMUrlResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCRMUrlResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCRMUrlResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCRMUrlResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDiaryViewEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetDiaryViewEntity" style="document" />
      <wsdl:input name="GetDiaryViewEntityRequest">
        <soap:header message="tns:GetDiaryViewEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDiaryViewEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDiaryViewEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDiaryViewEntityResponse">
        <soap:header message="tns:GetDiaryViewEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDiaryViewEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDiaryViewEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDiaryViewEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetWindowPosSize">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetWindowPosSize" style="document" />
      <wsdl:input name="GetWindowPosSizeRequest">
        <soap:header message="tns:GetWindowPosSizeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetWindowPosSizeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetWindowPosSizeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetWindowPosSizeResponse">
        <soap:header message="tns:GetWindowPosSizeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetWindowPosSizeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetWindowPosSizeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetWindowPosSizeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveWindowPosSize">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/SaveWindowPosSize" style="document" />
      <wsdl:input name="SaveWindowPosSizeRequest">
        <soap:header message="tns:SaveWindowPosSizeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveWindowPosSizeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveWindowPosSizeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveWindowPosSizeResponse">
        <soap:header message="tns:SaveWindowPosSizeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveWindowPosSizeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveWindowPosSizeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveWindowPosSizeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteWindowPosSize">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/DeleteWindowPosSize" style="document" />
      <wsdl:input name="DeleteWindowPosSizeRequest">
        <soap:header message="tns:DeleteWindowPosSizeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteWindowPosSizeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteWindowPosSizeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteWindowPosSizeResponse">
        <soap:header message="tns:DeleteWindowPosSizeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteWindowPosSizeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteWindowPosSizeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteWindowPosSizeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetWindowPosSizeList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetWindowPosSizeList" style="document" />
      <wsdl:input name="GetWindowPosSizeListRequest">
        <soap:header message="tns:GetWindowPosSizeListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetWindowPosSizeListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetWindowPosSizeListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetWindowPosSizeListResponse">
        <soap:header message="tns:GetWindowPosSizeListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetWindowPosSizeListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetWindowPosSizeListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetWindowPosSizeListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyWindowPosSizes">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetMyWindowPosSizes" style="document" />
      <wsdl:input name="GetMyWindowPosSizesRequest">
        <soap:header message="tns:GetMyWindowPosSizesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyWindowPosSizesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyWindowPosSizesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyWindowPosSizesResponse">
        <soap:header message="tns:GetMyWindowPosSizesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyWindowPosSizesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyWindowPosSizesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyWindowPosSizesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetWindowPosSizesOnPersonId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetWindowPosSizesOnPersonId" style="document" />
      <wsdl:input name="GetWindowPosSizesOnPersonIdRequest">
        <soap:header message="tns:GetWindowPosSizesOnPersonIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetWindowPosSizesOnPersonIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetWindowPosSizesOnPersonIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetWindowPosSizesOnPersonIdResponse">
        <soap:header message="tns:GetWindowPosSizesOnPersonIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetWindowPosSizesOnPersonIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetWindowPosSizesOnPersonIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetWindowPosSizesOnPersonIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetWindowPosSizesOnAssociateId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetWindowPosSizesOnAssociateId" style="document" />
      <wsdl:input name="GetWindowPosSizesOnAssociateIdRequest">
        <soap:header message="tns:GetWindowPosSizesOnAssociateIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetWindowPosSizesOnAssociateIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetWindowPosSizesOnAssociateIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetWindowPosSizesOnAssociateIdResponse">
        <soap:header message="tns:GetWindowPosSizesOnAssociateIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetWindowPosSizesOnAssociateIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetWindowPosSizesOnAssociateIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetWindowPosSizesOnAssociateIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveWindowPosSizes">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/SaveWindowPosSizes" style="document" />
      <wsdl:input name="SaveWindowPosSizesRequest">
        <soap:header message="tns:SaveWindowPosSizesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveWindowPosSizesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveWindowPosSizesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveWindowPosSizesResponse">
        <soap:header message="tns:SaveWindowPosSizesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveWindowPosSizesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveWindowPosSizesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveWindowPosSizesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSystemEventEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/GetSystemEventEntity" style="document" />
      <wsdl:input name="GetSystemEventEntityRequest">
        <soap:header message="tns:GetSystemEventEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSystemEventEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSystemEventEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSystemEventEntityResponse">
        <soap:header message="tns:GetSystemEventEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSystemEventEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSystemEventEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSystemEventEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ExistsSystemEvent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services82/Configuration/ExistsSystemEvent" style="document" />
      <wsdl:input name="ExistsSystemEventRequest">
        <soap:header message="tns:ExistsSystemEventRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ExistsSystemEventRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ExistsSystemEventRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ExistsSystemEventResponse">
        <soap:header message="tns:ExistsSystemEventResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ExistsSystemEventResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ExistsSystemEventResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ExistsSystemEventResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfConfigurationService">
    <wsdl:port name="BasicHttpBinding_Configuration" binding="tns:BasicHttpBinding_Configuration">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services82/Configuration.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

