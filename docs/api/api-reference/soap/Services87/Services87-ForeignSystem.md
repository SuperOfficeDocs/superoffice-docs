---
generated: 1
uid: wsdl-Services87-ForeignSystem
title: Services87.ForeignSystemAgent WSDL
---

# Services87.ForeignSystemAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfForeignSystemService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:element name="CreateDefaultForeignAppEntity">
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
      <xs:element name="CreateDefaultForeignAppEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ForeignAppEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ForeignAppEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ForeignAppId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="Devices" nillable="true" type="tns:ArrayOfForeignDevice" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ForeignAppEntity" nillable="true" type="tns:ForeignAppEntity" />
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
      <xs:complexType name="ArrayOfForeignDevice">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ForeignDevice" nillable="true" type="tns:ForeignDevice" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfForeignDevice" nillable="true" type="tns:ArrayOfForeignDevice" />
      <xs:complexType name="ForeignDevice">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ForeignDeviceId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AssociateFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DeviceIdentifier" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ForeignAppId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ForeignDevice" nillable="true" type="tns:ForeignDevice" />
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
      <xs:element name="SaveForeignAppEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ForeignAppEntity" nillable="true" type="tns:ForeignAppEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveForeignAppEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ForeignAppEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteForeignAppEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ForeignAppEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteForeignAppEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetForeignAppEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ForeignAppEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetForeignAppEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ForeignAppEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppByName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppByNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ForeignAppEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetApplicationDevices">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetApplicationDevicesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfForeignDevice" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDeviceByName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDeviceByNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ForeignDevice" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDeviceByIdentifier">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceIdentifier" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDeviceByIdentifierResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ForeignDevice" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddDeviceByIdentifier">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceIdentifier" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddDeviceByIdentifierResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ForeignDevice" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDeviceByIdentifier">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceIdentifier" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ForeignDevice" nillable="true" type="tns:ForeignDevice" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDeviceByIdentifierResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ForeignDevice" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDeviceByIdentifier">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceIdentifier" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteDeviceByIdentifierResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetKey">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="KeyName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="RecordId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetKeyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ForeignKey" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ForeignKey">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Key" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RecordId" type="xs:int" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ForeignKey" nillable="true" type="tns:ForeignKey" />
      <xs:element name="GetKeyValue">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="KeyName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="RecordId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetKeyValueResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetKeyOnDeviceIdentifier">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceIdentifier" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="KeyName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="RecordId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetKeyOnDeviceIdentifierResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ForeignKey" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetKeyValueOnDeviceIdentifier">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceIdentifier" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="KeyName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="RecordId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetKeyValueOnDeviceIdentifierResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddForeignKey">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ForeignKey" nillable="true" type="tns:ForeignKey" />
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceIdentifier" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddForeignKeyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ForeignKey" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveForeignKey">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ForeignKey" nillable="true" type="tns:ForeignKey" />
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceIdentifier" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveForeignKeyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ForeignKey" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteForeignKeyOnName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceIdentifier" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="KeyName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="RecordId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteForeignKeyOnNameResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetKeyByValue">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="KeyName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="KeyValue" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetKeyByValueResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ForeignKey" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetKeyByValueAndIdentifier">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceIdentifier" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="KeyName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="KeyValue" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetKeyByValueAndIdentifierResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ForeignKey" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetForeignDevice">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ForeignDeviceId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetForeignDeviceResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ForeignDevice" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveForeignDevice">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ForeignDevice" nillable="true" type="tns:ForeignDevice" />
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveForeignDeviceResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ForeignDevice" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteForeignDevice">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ForeignDevice" nillable="true" type="tns:ForeignDevice" />
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteForeignDeviceResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteForeignKey">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ForeignKey" nillable="true" type="tns:ForeignKey" />
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceIdentifier" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="RecordId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteForeignKeyResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDeviceKeys">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDeviceKeysResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfForeignKey" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfForeignKey">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ForeignKey" nillable="true" type="tns:ForeignKey" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfForeignKey" nillable="true" type="tns:ArrayOfForeignKey" />
      <xs:element name="GetApplicationKeys">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetApplicationKeysResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfForeignKey" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDeviceKeysOnDeviceIdentifier">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceIdentifier" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDeviceKeysOnDeviceIdentifierResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfForeignKey" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDeviceKeysOnDeviceIdentifierTable">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceIdentifier" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDeviceKeysOnDeviceIdentifierTableResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfForeignKey" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDeviceKeysOnDeviceIdentifierTableRecordId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ApplicationName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DeviceIdentifier" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="RecordId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDeviceKeysOnDeviceIdentifierTableRecordIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfForeignKey" />
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
  <wsdl:message name="CreateDefaultForeignAppEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultForeignAppEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultForeignAppEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultForeignAppEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultForeignAppEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultForeignAppEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveForeignAppEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveForeignAppEntity" />
  </wsdl:message>
  <wsdl:message name="SaveForeignAppEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveForeignAppEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveForeignAppEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveForeignAppEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteForeignAppEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteForeignAppEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteForeignAppEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteForeignAppEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteForeignAppEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteForeignAppEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetForeignAppEntityRequest">
    <wsdl:part name="parameters" element="tns:GetForeignAppEntity" />
  </wsdl:message>
  <wsdl:message name="GetForeignAppEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetForeignAppEntityResponse">
    <wsdl:part name="parameters" element="tns:GetForeignAppEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetForeignAppEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppByNameRequest">
    <wsdl:part name="parameters" element="tns:GetAppByName" />
  </wsdl:message>
  <wsdl:message name="GetAppByNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppByNameResponse">
    <wsdl:part name="parameters" element="tns:GetAppByNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetAppByNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetApplicationDevicesRequest">
    <wsdl:part name="parameters" element="tns:GetApplicationDevices" />
  </wsdl:message>
  <wsdl:message name="GetApplicationDevicesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetApplicationDevicesResponse">
    <wsdl:part name="parameters" element="tns:GetApplicationDevicesResponse" />
  </wsdl:message>
  <wsdl:message name="GetApplicationDevicesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeviceByNameRequest">
    <wsdl:part name="parameters" element="tns:GetDeviceByName" />
  </wsdl:message>
  <wsdl:message name="GetDeviceByNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeviceByNameResponse">
    <wsdl:part name="parameters" element="tns:GetDeviceByNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetDeviceByNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeviceByIdentifierRequest">
    <wsdl:part name="parameters" element="tns:GetDeviceByIdentifier" />
  </wsdl:message>
  <wsdl:message name="GetDeviceByIdentifierRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeviceByIdentifierResponse">
    <wsdl:part name="parameters" element="tns:GetDeviceByIdentifierResponse" />
  </wsdl:message>
  <wsdl:message name="GetDeviceByIdentifierResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddDeviceByIdentifierRequest">
    <wsdl:part name="parameters" element="tns:AddDeviceByIdentifier" />
  </wsdl:message>
  <wsdl:message name="AddDeviceByIdentifierRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddDeviceByIdentifierResponse">
    <wsdl:part name="parameters" element="tns:AddDeviceByIdentifierResponse" />
  </wsdl:message>
  <wsdl:message name="AddDeviceByIdentifierResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDeviceByIdentifierRequest">
    <wsdl:part name="parameters" element="tns:SaveDeviceByIdentifier" />
  </wsdl:message>
  <wsdl:message name="SaveDeviceByIdentifierRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDeviceByIdentifierResponse">
    <wsdl:part name="parameters" element="tns:SaveDeviceByIdentifierResponse" />
  </wsdl:message>
  <wsdl:message name="SaveDeviceByIdentifierResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDeviceByIdentifierRequest">
    <wsdl:part name="parameters" element="tns:DeleteDeviceByIdentifier" />
  </wsdl:message>
  <wsdl:message name="DeleteDeviceByIdentifierRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteDeviceByIdentifierResponse">
    <wsdl:part name="parameters" element="tns:DeleteDeviceByIdentifierResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteDeviceByIdentifierResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetKeyRequest">
    <wsdl:part name="parameters" element="tns:GetKey" />
  </wsdl:message>
  <wsdl:message name="GetKeyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetKeyResponse">
    <wsdl:part name="parameters" element="tns:GetKeyResponse" />
  </wsdl:message>
  <wsdl:message name="GetKeyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetKeyValueRequest">
    <wsdl:part name="parameters" element="tns:GetKeyValue" />
  </wsdl:message>
  <wsdl:message name="GetKeyValueRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetKeyValueResponse">
    <wsdl:part name="parameters" element="tns:GetKeyValueResponse" />
  </wsdl:message>
  <wsdl:message name="GetKeyValueResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetKeyOnDeviceIdentifierRequest">
    <wsdl:part name="parameters" element="tns:GetKeyOnDeviceIdentifier" />
  </wsdl:message>
  <wsdl:message name="GetKeyOnDeviceIdentifierRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetKeyOnDeviceIdentifierResponse">
    <wsdl:part name="parameters" element="tns:GetKeyOnDeviceIdentifierResponse" />
  </wsdl:message>
  <wsdl:message name="GetKeyOnDeviceIdentifierResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetKeyValueOnDeviceIdentifierRequest">
    <wsdl:part name="parameters" element="tns:GetKeyValueOnDeviceIdentifier" />
  </wsdl:message>
  <wsdl:message name="GetKeyValueOnDeviceIdentifierRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetKeyValueOnDeviceIdentifierResponse">
    <wsdl:part name="parameters" element="tns:GetKeyValueOnDeviceIdentifierResponse" />
  </wsdl:message>
  <wsdl:message name="GetKeyValueOnDeviceIdentifierResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddForeignKeyRequest">
    <wsdl:part name="parameters" element="tns:AddForeignKey" />
  </wsdl:message>
  <wsdl:message name="AddForeignKeyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddForeignKeyResponse">
    <wsdl:part name="parameters" element="tns:AddForeignKeyResponse" />
  </wsdl:message>
  <wsdl:message name="AddForeignKeyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveForeignKeyRequest">
    <wsdl:part name="parameters" element="tns:SaveForeignKey" />
  </wsdl:message>
  <wsdl:message name="SaveForeignKeyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveForeignKeyResponse">
    <wsdl:part name="parameters" element="tns:SaveForeignKeyResponse" />
  </wsdl:message>
  <wsdl:message name="SaveForeignKeyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteForeignKeyOnNameRequest">
    <wsdl:part name="parameters" element="tns:DeleteForeignKeyOnName" />
  </wsdl:message>
  <wsdl:message name="DeleteForeignKeyOnNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteForeignKeyOnNameResponse">
    <wsdl:part name="parameters" element="tns:DeleteForeignKeyOnNameResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteForeignKeyOnNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetKeyByValueRequest">
    <wsdl:part name="parameters" element="tns:GetKeyByValue" />
  </wsdl:message>
  <wsdl:message name="GetKeyByValueRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetKeyByValueResponse">
    <wsdl:part name="parameters" element="tns:GetKeyByValueResponse" />
  </wsdl:message>
  <wsdl:message name="GetKeyByValueResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetKeyByValueAndIdentifierRequest">
    <wsdl:part name="parameters" element="tns:GetKeyByValueAndIdentifier" />
  </wsdl:message>
  <wsdl:message name="GetKeyByValueAndIdentifierRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetKeyByValueAndIdentifierResponse">
    <wsdl:part name="parameters" element="tns:GetKeyByValueAndIdentifierResponse" />
  </wsdl:message>
  <wsdl:message name="GetKeyByValueAndIdentifierResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetForeignDeviceRequest">
    <wsdl:part name="parameters" element="tns:GetForeignDevice" />
  </wsdl:message>
  <wsdl:message name="GetForeignDeviceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetForeignDeviceResponse">
    <wsdl:part name="parameters" element="tns:GetForeignDeviceResponse" />
  </wsdl:message>
  <wsdl:message name="GetForeignDeviceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveForeignDeviceRequest">
    <wsdl:part name="parameters" element="tns:SaveForeignDevice" />
  </wsdl:message>
  <wsdl:message name="SaveForeignDeviceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveForeignDeviceResponse">
    <wsdl:part name="parameters" element="tns:SaveForeignDeviceResponse" />
  </wsdl:message>
  <wsdl:message name="SaveForeignDeviceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteForeignDeviceRequest">
    <wsdl:part name="parameters" element="tns:DeleteForeignDevice" />
  </wsdl:message>
  <wsdl:message name="DeleteForeignDeviceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteForeignDeviceResponse">
    <wsdl:part name="parameters" element="tns:DeleteForeignDeviceResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteForeignDeviceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteForeignKeyRequest">
    <wsdl:part name="parameters" element="tns:DeleteForeignKey" />
  </wsdl:message>
  <wsdl:message name="DeleteForeignKeyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteForeignKeyResponse">
    <wsdl:part name="parameters" element="tns:DeleteForeignKeyResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteForeignKeyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeviceKeysRequest">
    <wsdl:part name="parameters" element="tns:GetDeviceKeys" />
  </wsdl:message>
  <wsdl:message name="GetDeviceKeysRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeviceKeysResponse">
    <wsdl:part name="parameters" element="tns:GetDeviceKeysResponse" />
  </wsdl:message>
  <wsdl:message name="GetDeviceKeysResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetApplicationKeysRequest">
    <wsdl:part name="parameters" element="tns:GetApplicationKeys" />
  </wsdl:message>
  <wsdl:message name="GetApplicationKeysRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetApplicationKeysResponse">
    <wsdl:part name="parameters" element="tns:GetApplicationKeysResponse" />
  </wsdl:message>
  <wsdl:message name="GetApplicationKeysResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeviceKeysOnDeviceIdentifierRequest">
    <wsdl:part name="parameters" element="tns:GetDeviceKeysOnDeviceIdentifier" />
  </wsdl:message>
  <wsdl:message name="GetDeviceKeysOnDeviceIdentifierRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeviceKeysOnDeviceIdentifierResponse">
    <wsdl:part name="parameters" element="tns:GetDeviceKeysOnDeviceIdentifierResponse" />
  </wsdl:message>
  <wsdl:message name="GetDeviceKeysOnDeviceIdentifierResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeviceKeysOnDeviceIdentifierTableRequest">
    <wsdl:part name="parameters" element="tns:GetDeviceKeysOnDeviceIdentifierTable" />
  </wsdl:message>
  <wsdl:message name="GetDeviceKeysOnDeviceIdentifierTableRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeviceKeysOnDeviceIdentifierTableResponse">
    <wsdl:part name="parameters" element="tns:GetDeviceKeysOnDeviceIdentifierTableResponse" />
  </wsdl:message>
  <wsdl:message name="GetDeviceKeysOnDeviceIdentifierTableResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeviceKeysOnDeviceIdentifierTableRecordIdRequest">
    <wsdl:part name="parameters" element="tns:GetDeviceKeysOnDeviceIdentifierTableRecordId" />
  </wsdl:message>
  <wsdl:message name="GetDeviceKeysOnDeviceIdentifierTableRecordIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDeviceKeysOnDeviceIdentifierTableRecordIdResponse">
    <wsdl:part name="parameters" element="tns:GetDeviceKeysOnDeviceIdentifierTableRecordIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetDeviceKeysOnDeviceIdentifierTableRecordIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="ForeignSystem">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for ForeignSystem</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultForeignAppEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new ForeignAppEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/CreateDefaultForeignAppEntity" name="CreateDefaultForeignAppEntityRequest" message="tns:CreateDefaultForeignAppEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/CreateDefaultForeignAppEntityResponse" name="CreateDefaultForeignAppEntityResponse" message="tns:CreateDefaultForeignAppEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveForeignAppEntity">
      <wsdl:documentation>
        <summary>Updates the existing ForeignAppEntity or creates a new ForeignAppEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/SaveForeignAppEntity" name="SaveForeignAppEntityRequest" message="tns:SaveForeignAppEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/SaveForeignAppEntityResponse" name="SaveForeignAppEntityResponse" message="tns:SaveForeignAppEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteForeignAppEntity">
      <wsdl:documentation>
        <summary>Deletes the ForeignAppEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/DeleteForeignAppEntity" name="DeleteForeignAppEntityRequest" message="tns:DeleteForeignAppEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/DeleteForeignAppEntityResponse" name="DeleteForeignAppEntityResponse" message="tns:DeleteForeignAppEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetForeignAppEntity">
      <wsdl:documentation>
        <summary>Gets a ForeignAppEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetForeignAppEntity" name="GetForeignAppEntityRequest" message="tns:GetForeignAppEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetForeignAppEntityResponse" name="GetForeignAppEntityResponse" message="tns:GetForeignAppEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAppByName">
      <wsdl:documentation>
        <summary>Gets the ForeignApp with the given name.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetAppByName" name="GetAppByNameRequest" message="tns:GetAppByNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetAppByNameResponse" name="GetAppByNameResponse" message="tns:GetAppByNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetApplicationDevices">
      <wsdl:documentation>
        <summary>Gets all devices that belong to a foreign application.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetApplicationDevices" name="GetApplicationDevicesRequest" message="tns:GetApplicationDevicesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetApplicationDevicesResponse" name="GetApplicationDevicesResponse" message="tns:GetApplicationDevicesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDeviceByName">
      <wsdl:documentation>
        <summary>Gets a ForeignDevice with deviceName that belongs to the application with applicationName.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetDeviceByName" name="GetDeviceByNameRequest" message="tns:GetDeviceByNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetDeviceByNameResponse" name="GetDeviceByNameResponse" message="tns:GetDeviceByNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDeviceByIdentifier">
      <wsdl:documentation>
        <summary>Gets a ForeignDevice with deviceName and deviceIdentifier that belongs to the application with applicationName.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetDeviceByIdentifier" name="GetDeviceByIdentifierRequest" message="tns:GetDeviceByIdentifierRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetDeviceByIdentifierResponse" name="GetDeviceByIdentifierResponse" message="tns:GetDeviceByIdentifierResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddDeviceByIdentifier">
      <wsdl:documentation>
        <summary>Adds a new ForeignDevice with deviceName that belongs to the application with applicationName, with an optional device-specific identifier.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/AddDeviceByIdentifier" name="AddDeviceByIdentifierRequest" message="tns:AddDeviceByIdentifierRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/AddDeviceByIdentifierResponse" name="AddDeviceByIdentifierResponse" message="tns:AddDeviceByIdentifierResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveDeviceByIdentifier">
      <wsdl:documentation>
        <summary>Updates a ForeignDevice with deviceName that belongs to the application with applicationName.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/SaveDeviceByIdentifier" name="SaveDeviceByIdentifierRequest" message="tns:SaveDeviceByIdentifierRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/SaveDeviceByIdentifierResponse" name="SaveDeviceByIdentifierResponse" message="tns:SaveDeviceByIdentifierResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteDeviceByIdentifier">
      <wsdl:documentation>
        <summary>Delete a ForeignDevice with deviceName and deviceIdentifier that belongs to the application with applicationName.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/DeleteDeviceByIdentifier" name="DeleteDeviceByIdentifierRequest" message="tns:DeleteDeviceByIdentifierRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/DeleteDeviceByIdentifierResponse" name="DeleteDeviceByIdentifierResponse" message="tns:DeleteDeviceByIdentifierResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetKey">
      <wsdl:documentation>
        <summary>Returning a foreign key by its key name, that belongs to the specified device and application. A table name and record ID can also be specified.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetKey" name="GetKeyRequest" message="tns:GetKeyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetKeyResponse" name="GetKeyResponse" message="tns:GetKeyResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetKeyValue">
      <wsdl:documentation>
        <summary>Gets the string value of a ForeignKey, that belongs to the specified device and application. The table name and record ID must also be specified.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetKeyValue" name="GetKeyValueRequest" message="tns:GetKeyValueRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetKeyValueResponse" name="GetKeyValueResponse" message="tns:GetKeyValueResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetKeyOnDeviceIdentifier">
      <wsdl:documentation>
        <summary>Returning a foreign key by its key name and device identifier, that belongs to the specified device and application. A table name and record ID can also be specified.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetKeyOnDeviceIdentifier" name="GetKeyOnDeviceIdentifierRequest" message="tns:GetKeyOnDeviceIdentifierRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetKeyOnDeviceIdentifierResponse" name="GetKeyOnDeviceIdentifierResponse" message="tns:GetKeyOnDeviceIdentifierResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetKeyValueOnDeviceIdentifier">
      <wsdl:documentation>
        <summary>Returning a foreign key string value by its key name and device identifier, that belongs to the specified device and application. A table name and record ID can also be specified.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetKeyValueOnDeviceIdentifier" name="GetKeyValueOnDeviceIdentifierRequest" message="tns:GetKeyValueOnDeviceIdentifierRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetKeyValueOnDeviceIdentifierResponse" name="GetKeyValueOnDeviceIdentifierResponse" message="tns:GetKeyValueOnDeviceIdentifierResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddForeignKey">
      <wsdl:documentation>
        <summary>Add a new key belonging to the ForeignApp and ForeignDevice specified.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/AddForeignKey" name="AddForeignKeyRequest" message="tns:AddForeignKeyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/AddForeignKeyResponse" name="AddForeignKeyResponse" message="tns:AddForeignKeyResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveForeignKey">
      <wsdl:documentation>
        <summary>Saves a key belonging to the ForeignApp and ForeignDevice specified.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/SaveForeignKey" name="SaveForeignKeyRequest" message="tns:SaveForeignKeyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/SaveForeignKeyResponse" name="SaveForeignKeyResponse" message="tns:SaveForeignKeyResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteForeignKeyOnName">
      <wsdl:documentation>
        <summary>Deletes all specified occurrences of a key, belonging to the ForeignApp and ForeignDevice, table and record specified. Specifying a blank table name will delete ALL keys of the given name; specifying a recordId of 0 will delete ALL keys of the given name for the given table.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/DeleteForeignKeyOnName" name="DeleteForeignKeyOnNameRequest" message="tns:DeleteForeignKeyOnNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/DeleteForeignKeyOnNameResponse" name="DeleteForeignKeyOnNameResponse" message="tns:DeleteForeignKeyOnNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetKeyByValue">
      <wsdl:documentation>
        <summary>Get a foreignkey based on its name and value, that belongs to the specified device and application.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetKeyByValue" name="GetKeyByValueRequest" message="tns:GetKeyByValueRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetKeyByValueResponse" name="GetKeyByValueResponse" message="tns:GetKeyByValueResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetKeyByValueAndIdentifier">
      <wsdl:documentation>
        <summary>Get a foreignkey based on its name and value, that belongs to the specified deviceId, device, and application.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetKeyByValueAndIdentifier" name="GetKeyByValueAndIdentifierRequest" message="tns:GetKeyByValueAndIdentifierRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetKeyByValueAndIdentifierResponse" name="GetKeyByValueAndIdentifierResponse" message="tns:GetKeyByValueAndIdentifierResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetForeignDevice">
      <wsdl:documentation>
        <summary>Gets a ForeignDevice object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetForeignDevice" name="GetForeignDeviceRequest" message="tns:GetForeignDeviceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetForeignDeviceResponse" name="GetForeignDeviceResponse" message="tns:GetForeignDeviceResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveForeignDevice">
      <wsdl:documentation>
        <summary>Saves a foreign device for an foreign application</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/SaveForeignDevice" name="SaveForeignDeviceRequest" message="tns:SaveForeignDeviceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/SaveForeignDeviceResponse" name="SaveForeignDeviceResponse" message="tns:SaveForeignDeviceResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteForeignDevice">
      <wsdl:documentation>
        <summary>Deletes a foreign device from an application</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/DeleteForeignDevice" name="DeleteForeignDeviceRequest" message="tns:DeleteForeignDeviceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/DeleteForeignDeviceResponse" name="DeleteForeignDeviceResponse" message="tns:DeleteForeignDeviceResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteForeignKey">
      <wsdl:documentation>
        <summary>Deletes all specified occurrences of a key, belonging to the ForeignApp and ForeignDevice, table and record specified. Specifying a blank table name will delete ALL keys of the given name; specifying a recordId of 0 will delete ALL keys of the given name for the given table.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/DeleteForeignKey" name="DeleteForeignKeyRequest" message="tns:DeleteForeignKeyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/DeleteForeignKeyResponse" name="DeleteForeignKeyResponse" message="tns:DeleteForeignKeyResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDeviceKeys">
      <wsdl:documentation>
        <summary>Returns all ForeignKeys that belong to a device.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetDeviceKeys" name="GetDeviceKeysRequest" message="tns:GetDeviceKeysRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetDeviceKeysResponse" name="GetDeviceKeysResponse" message="tns:GetDeviceKeysResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetApplicationKeys">
      <wsdl:documentation>
        <summary>Returns all ForeignKeys that belong to an application.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetApplicationKeys" name="GetApplicationKeysRequest" message="tns:GetApplicationKeysRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetApplicationKeysResponse" name="GetApplicationKeysResponse" message="tns:GetApplicationKeysResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDeviceKeysOnDeviceIdentifier">
      <wsdl:documentation>
        <summary>Returns all ForeignKeys that belong to a device with a given deviceIdentifier.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetDeviceKeysOnDeviceIdentifier" name="GetDeviceKeysOnDeviceIdentifierRequest" message="tns:GetDeviceKeysOnDeviceIdentifierRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetDeviceKeysOnDeviceIdentifierResponse" name="GetDeviceKeysOnDeviceIdentifierResponse" message="tns:GetDeviceKeysOnDeviceIdentifierResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDeviceKeysOnDeviceIdentifierTable">
      <wsdl:documentation>
        <summary>Returns all ForeignKeys that belong to a device with a given deviceIdentifier and table name.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetDeviceKeysOnDeviceIdentifierTable" name="GetDeviceKeysOnDeviceIdentifierTableRequest" message="tns:GetDeviceKeysOnDeviceIdentifierTableRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetDeviceKeysOnDeviceIdentifierTableResponse" name="GetDeviceKeysOnDeviceIdentifierTableResponse" message="tns:GetDeviceKeysOnDeviceIdentifierTableResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDeviceKeysOnDeviceIdentifierTableRecordId">
      <wsdl:documentation>
        <summary>Returns all ForeignKeys that belong to a device with a given deviceIdentifier and table name, as well as record id.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetDeviceKeysOnDeviceIdentifierTableRecordId" name="GetDeviceKeysOnDeviceIdentifierTableRecordIdRequest" message="tns:GetDeviceKeysOnDeviceIdentifierTableRecordIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetDeviceKeysOnDeviceIdentifierTableRecordIdResponse" name="GetDeviceKeysOnDeviceIdentifierTableRecordIdResponse" message="tns:GetDeviceKeysOnDeviceIdentifierTableRecordIdResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_ForeignSystem" type="tns:ForeignSystem">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultForeignAppEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/CreateDefaultForeignAppEntity" style="document" />
      <wsdl:input name="CreateDefaultForeignAppEntityRequest">
        <soap:header message="tns:CreateDefaultForeignAppEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultForeignAppEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultForeignAppEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultForeignAppEntityResponse">
        <soap:header message="tns:CreateDefaultForeignAppEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultForeignAppEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultForeignAppEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultForeignAppEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveForeignAppEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/SaveForeignAppEntity" style="document" />
      <wsdl:input name="SaveForeignAppEntityRequest">
        <soap:header message="tns:SaveForeignAppEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveForeignAppEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveForeignAppEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveForeignAppEntityResponse">
        <soap:header message="tns:SaveForeignAppEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveForeignAppEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveForeignAppEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveForeignAppEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteForeignAppEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/DeleteForeignAppEntity" style="document" />
      <wsdl:input name="DeleteForeignAppEntityRequest">
        <soap:header message="tns:DeleteForeignAppEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteForeignAppEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteForeignAppEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteForeignAppEntityResponse">
        <soap:header message="tns:DeleteForeignAppEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteForeignAppEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteForeignAppEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteForeignAppEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetForeignAppEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetForeignAppEntity" style="document" />
      <wsdl:input name="GetForeignAppEntityRequest">
        <soap:header message="tns:GetForeignAppEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetForeignAppEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetForeignAppEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetForeignAppEntityResponse">
        <soap:header message="tns:GetForeignAppEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetForeignAppEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetForeignAppEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetForeignAppEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAppByName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetAppByName" style="document" />
      <wsdl:input name="GetAppByNameRequest">
        <soap:header message="tns:GetAppByNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAppByNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAppByNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAppByNameResponse">
        <soap:header message="tns:GetAppByNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAppByNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAppByNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAppByNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetApplicationDevices">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetApplicationDevices" style="document" />
      <wsdl:input name="GetApplicationDevicesRequest">
        <soap:header message="tns:GetApplicationDevicesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetApplicationDevicesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetApplicationDevicesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetApplicationDevicesResponse">
        <soap:header message="tns:GetApplicationDevicesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetApplicationDevicesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetApplicationDevicesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetApplicationDevicesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDeviceByName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetDeviceByName" style="document" />
      <wsdl:input name="GetDeviceByNameRequest">
        <soap:header message="tns:GetDeviceByNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDeviceByNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDeviceByNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDeviceByNameResponse">
        <soap:header message="tns:GetDeviceByNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDeviceByNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDeviceByNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDeviceByNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDeviceByIdentifier">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetDeviceByIdentifier" style="document" />
      <wsdl:input name="GetDeviceByIdentifierRequest">
        <soap:header message="tns:GetDeviceByIdentifierRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDeviceByIdentifierRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDeviceByIdentifierRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDeviceByIdentifierResponse">
        <soap:header message="tns:GetDeviceByIdentifierResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDeviceByIdentifierResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDeviceByIdentifierResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDeviceByIdentifierResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddDeviceByIdentifier">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/AddDeviceByIdentifier" style="document" />
      <wsdl:input name="AddDeviceByIdentifierRequest">
        <soap:header message="tns:AddDeviceByIdentifierRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddDeviceByIdentifierRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddDeviceByIdentifierRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddDeviceByIdentifierResponse">
        <soap:header message="tns:AddDeviceByIdentifierResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddDeviceByIdentifierResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddDeviceByIdentifierResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddDeviceByIdentifierResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveDeviceByIdentifier">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/SaveDeviceByIdentifier" style="document" />
      <wsdl:input name="SaveDeviceByIdentifierRequest">
        <soap:header message="tns:SaveDeviceByIdentifierRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveDeviceByIdentifierRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveDeviceByIdentifierRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveDeviceByIdentifierResponse">
        <soap:header message="tns:SaveDeviceByIdentifierResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveDeviceByIdentifierResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveDeviceByIdentifierResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveDeviceByIdentifierResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteDeviceByIdentifier">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/DeleteDeviceByIdentifier" style="document" />
      <wsdl:input name="DeleteDeviceByIdentifierRequest">
        <soap:header message="tns:DeleteDeviceByIdentifierRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteDeviceByIdentifierRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteDeviceByIdentifierRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteDeviceByIdentifierResponse">
        <soap:header message="tns:DeleteDeviceByIdentifierResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteDeviceByIdentifierResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteDeviceByIdentifierResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteDeviceByIdentifierResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetKey">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetKey" style="document" />
      <wsdl:input name="GetKeyRequest">
        <soap:header message="tns:GetKeyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetKeyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetKeyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetKeyResponse">
        <soap:header message="tns:GetKeyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetKeyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetKeyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetKeyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetKeyValue">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetKeyValue" style="document" />
      <wsdl:input name="GetKeyValueRequest">
        <soap:header message="tns:GetKeyValueRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetKeyValueRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetKeyValueRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetKeyValueResponse">
        <soap:header message="tns:GetKeyValueResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetKeyValueResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetKeyValueResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetKeyValueResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetKeyOnDeviceIdentifier">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetKeyOnDeviceIdentifier" style="document" />
      <wsdl:input name="GetKeyOnDeviceIdentifierRequest">
        <soap:header message="tns:GetKeyOnDeviceIdentifierRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetKeyOnDeviceIdentifierRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetKeyOnDeviceIdentifierRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetKeyOnDeviceIdentifierResponse">
        <soap:header message="tns:GetKeyOnDeviceIdentifierResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetKeyOnDeviceIdentifierResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetKeyOnDeviceIdentifierResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetKeyOnDeviceIdentifierResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetKeyValueOnDeviceIdentifier">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetKeyValueOnDeviceIdentifier" style="document" />
      <wsdl:input name="GetKeyValueOnDeviceIdentifierRequest">
        <soap:header message="tns:GetKeyValueOnDeviceIdentifierRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetKeyValueOnDeviceIdentifierRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetKeyValueOnDeviceIdentifierRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetKeyValueOnDeviceIdentifierResponse">
        <soap:header message="tns:GetKeyValueOnDeviceIdentifierResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetKeyValueOnDeviceIdentifierResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetKeyValueOnDeviceIdentifierResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetKeyValueOnDeviceIdentifierResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddForeignKey">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/AddForeignKey" style="document" />
      <wsdl:input name="AddForeignKeyRequest">
        <soap:header message="tns:AddForeignKeyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddForeignKeyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddForeignKeyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddForeignKeyResponse">
        <soap:header message="tns:AddForeignKeyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddForeignKeyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddForeignKeyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddForeignKeyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveForeignKey">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/SaveForeignKey" style="document" />
      <wsdl:input name="SaveForeignKeyRequest">
        <soap:header message="tns:SaveForeignKeyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveForeignKeyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveForeignKeyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveForeignKeyResponse">
        <soap:header message="tns:SaveForeignKeyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveForeignKeyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveForeignKeyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveForeignKeyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteForeignKeyOnName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/DeleteForeignKeyOnName" style="document" />
      <wsdl:input name="DeleteForeignKeyOnNameRequest">
        <soap:header message="tns:DeleteForeignKeyOnNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteForeignKeyOnNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteForeignKeyOnNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteForeignKeyOnNameResponse">
        <soap:header message="tns:DeleteForeignKeyOnNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteForeignKeyOnNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteForeignKeyOnNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteForeignKeyOnNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetKeyByValue">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetKeyByValue" style="document" />
      <wsdl:input name="GetKeyByValueRequest">
        <soap:header message="tns:GetKeyByValueRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetKeyByValueRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetKeyByValueRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetKeyByValueResponse">
        <soap:header message="tns:GetKeyByValueResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetKeyByValueResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetKeyByValueResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetKeyByValueResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetKeyByValueAndIdentifier">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetKeyByValueAndIdentifier" style="document" />
      <wsdl:input name="GetKeyByValueAndIdentifierRequest">
        <soap:header message="tns:GetKeyByValueAndIdentifierRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetKeyByValueAndIdentifierRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetKeyByValueAndIdentifierRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetKeyByValueAndIdentifierResponse">
        <soap:header message="tns:GetKeyByValueAndIdentifierResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetKeyByValueAndIdentifierResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetKeyByValueAndIdentifierResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetKeyByValueAndIdentifierResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetForeignDevice">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetForeignDevice" style="document" />
      <wsdl:input name="GetForeignDeviceRequest">
        <soap:header message="tns:GetForeignDeviceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetForeignDeviceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetForeignDeviceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetForeignDeviceResponse">
        <soap:header message="tns:GetForeignDeviceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetForeignDeviceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetForeignDeviceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetForeignDeviceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveForeignDevice">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/SaveForeignDevice" style="document" />
      <wsdl:input name="SaveForeignDeviceRequest">
        <soap:header message="tns:SaveForeignDeviceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveForeignDeviceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveForeignDeviceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveForeignDeviceResponse">
        <soap:header message="tns:SaveForeignDeviceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveForeignDeviceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveForeignDeviceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveForeignDeviceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteForeignDevice">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/DeleteForeignDevice" style="document" />
      <wsdl:input name="DeleteForeignDeviceRequest">
        <soap:header message="tns:DeleteForeignDeviceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteForeignDeviceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteForeignDeviceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteForeignDeviceResponse">
        <soap:header message="tns:DeleteForeignDeviceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteForeignDeviceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteForeignDeviceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteForeignDeviceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteForeignKey">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/DeleteForeignKey" style="document" />
      <wsdl:input name="DeleteForeignKeyRequest">
        <soap:header message="tns:DeleteForeignKeyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteForeignKeyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteForeignKeyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteForeignKeyResponse">
        <soap:header message="tns:DeleteForeignKeyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteForeignKeyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteForeignKeyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteForeignKeyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDeviceKeys">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetDeviceKeys" style="document" />
      <wsdl:input name="GetDeviceKeysRequest">
        <soap:header message="tns:GetDeviceKeysRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDeviceKeysRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDeviceKeysRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDeviceKeysResponse">
        <soap:header message="tns:GetDeviceKeysResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDeviceKeysResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDeviceKeysResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDeviceKeysResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetApplicationKeys">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetApplicationKeys" style="document" />
      <wsdl:input name="GetApplicationKeysRequest">
        <soap:header message="tns:GetApplicationKeysRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetApplicationKeysRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetApplicationKeysRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetApplicationKeysResponse">
        <soap:header message="tns:GetApplicationKeysResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetApplicationKeysResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetApplicationKeysResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetApplicationKeysResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDeviceKeysOnDeviceIdentifier">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetDeviceKeysOnDeviceIdentifier" style="document" />
      <wsdl:input name="GetDeviceKeysOnDeviceIdentifierRequest">
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDeviceKeysOnDeviceIdentifierResponse">
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDeviceKeysOnDeviceIdentifierTable">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetDeviceKeysOnDeviceIdentifierTable" style="document" />
      <wsdl:input name="GetDeviceKeysOnDeviceIdentifierTableRequest">
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierTableRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierTableRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierTableRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDeviceKeysOnDeviceIdentifierTableResponse">
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierTableResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierTableResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierTableResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierTableResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDeviceKeysOnDeviceIdentifierTableRecordId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/ForeignSystem/GetDeviceKeysOnDeviceIdentifierTableRecordId" style="document" />
      <wsdl:input name="GetDeviceKeysOnDeviceIdentifierTableRecordIdRequest">
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierTableRecordIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierTableRecordIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierTableRecordIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDeviceKeysOnDeviceIdentifierTableRecordIdResponse">
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierTableRecordIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierTableRecordIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierTableRecordIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDeviceKeysOnDeviceIdentifierTableRecordIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfForeignSystemService">
    <wsdl:port name="BasicHttpBinding_ForeignSystem" binding="tns:BasicHttpBinding_ForeignSystem">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services87/ForeignSystem.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

