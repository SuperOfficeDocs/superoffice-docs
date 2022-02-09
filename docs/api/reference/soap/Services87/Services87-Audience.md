---
generated: 1
uid: wsdl-Services87-Audience
title: Services87.AudienceAgent WSDL
---

# Services87.AudienceAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfAudienceService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services87" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:element name="CreateDefaultAudienceLayoutEntity">
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
      <xs:element name="CreateDefaultAudienceLayoutEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:AudienceLayoutEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="AudienceLayoutEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="AudienceLayoutId" type="xs:int" />
              <xs:element minOccurs="0" name="InstanceLayout" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="InstanceName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="tns:Associate" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AudienceLayoutEntity" nillable="true" type="tns:AudienceLayoutEntity" />
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
      <xs:element name="SaveAudienceLayoutEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AudienceLayoutEntity" nillable="true" type="tns:AudienceLayoutEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveAudienceLayoutEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:AudienceLayoutEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteAudienceLayoutEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AudienceLayoutEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteAudienceLayoutEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveConfigParameter">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LayoutName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ConfigParameter" nillable="true" type="tns:AudienceConfigParameter" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="AudienceConfigParameter">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="AudienceLayoutId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AudienceConfigParameter" nillable="true" type="tns:AudienceConfigParameter" />
      <xs:element name="SaveConfigParameterResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:AudienceConfigParameter" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConfigParameterValue">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LayoutName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ParameterName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConfigParameterValueResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConfigParameter">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LayoutName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ParameterName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConfigParameterResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:AudienceConfigParameter" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteConfigParameter">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LayoutName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ParameterName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteConfigParameterResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyConfigParameter">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ParameterName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyConfigParameterResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:AudienceConfigParameter" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyConfigParameterValue">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ParameterName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyConfigParameterValueResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConfigParameterValueOnPerson">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ParameterName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConfigParameterValueOnPersonResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConfigParameterOnPerson">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ParameterName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConfigParameterOnPersonResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:AudienceConfigParameter" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConfigParametersByLayoutName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LayoutName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConfigParametersByLayoutNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfAudienceConfigParameter" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfAudienceConfigParameter">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="AudienceConfigParameter" nillable="true" type="tns:AudienceConfigParameter" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfAudienceConfigParameter" nillable="true" type="tns:ArrayOfAudienceConfigParameter" />
      <xs:element name="GetMyConfigParameters">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyConfigParametersResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfAudienceConfigParameter" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConfigParametersOnPerson">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConfigParametersOnPersonResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfAudienceConfigParameter" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAudienceLayoutEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AudienceLayoutEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAudienceLayoutEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:AudienceLayoutEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAudienceLayoutByName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LayoutName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAudienceLayoutByNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:AudienceLayoutEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyAudienceLayout">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyAudienceLayoutResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:AudienceLayoutEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAudienceLayoutOnPerson">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAudienceLayoutOnPersonResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:AudienceLayoutEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultProjectImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LayoutName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultProjectImageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDefaultProjectImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LayoutName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Image" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDefaultProjectImageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDefaultPersonImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LayoutName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Image" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDefaultPersonImageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultPersonImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LayoutName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultPersonImageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDefaultCountryFlag">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LayoutName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Image" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDefaultCountryFlagResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultCountryFlag">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LayoutName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDefaultCountryFlagResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLogoImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LayoutName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetLogoImageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetLogoImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LayoutName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Image" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetLogoImageResponse">
        <xs:complexType>
          <xs:sequence />
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
  <wsdl:message name="CreateDefaultAudienceLayoutEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultAudienceLayoutEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAudienceLayoutEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAudienceLayoutEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultAudienceLayoutEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAudienceLayoutEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveAudienceLayoutEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveAudienceLayoutEntity" />
  </wsdl:message>
  <wsdl:message name="SaveAudienceLayoutEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveAudienceLayoutEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveAudienceLayoutEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveAudienceLayoutEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteAudienceLayoutEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteAudienceLayoutEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteAudienceLayoutEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteAudienceLayoutEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteAudienceLayoutEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteAudienceLayoutEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveConfigParameterRequest">
    <wsdl:part name="parameters" element="tns:SaveConfigParameter" />
  </wsdl:message>
  <wsdl:message name="SaveConfigParameterRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveConfigParameterResponse">
    <wsdl:part name="parameters" element="tns:SaveConfigParameterResponse" />
  </wsdl:message>
  <wsdl:message name="SaveConfigParameterResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConfigParameterValueRequest">
    <wsdl:part name="parameters" element="tns:GetConfigParameterValue" />
  </wsdl:message>
  <wsdl:message name="GetConfigParameterValueRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConfigParameterValueResponse">
    <wsdl:part name="parameters" element="tns:GetConfigParameterValueResponse" />
  </wsdl:message>
  <wsdl:message name="GetConfigParameterValueResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConfigParameterRequest">
    <wsdl:part name="parameters" element="tns:GetConfigParameter" />
  </wsdl:message>
  <wsdl:message name="GetConfigParameterRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConfigParameterResponse">
    <wsdl:part name="parameters" element="tns:GetConfigParameterResponse" />
  </wsdl:message>
  <wsdl:message name="GetConfigParameterResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteConfigParameterRequest">
    <wsdl:part name="parameters" element="tns:DeleteConfigParameter" />
  </wsdl:message>
  <wsdl:message name="DeleteConfigParameterRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteConfigParameterResponse">
    <wsdl:part name="parameters" element="tns:DeleteConfigParameterResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteConfigParameterResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyConfigParameterRequest">
    <wsdl:part name="parameters" element="tns:GetMyConfigParameter" />
  </wsdl:message>
  <wsdl:message name="GetMyConfigParameterRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyConfigParameterResponse">
    <wsdl:part name="parameters" element="tns:GetMyConfigParameterResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyConfigParameterResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyConfigParameterValueRequest">
    <wsdl:part name="parameters" element="tns:GetMyConfigParameterValue" />
  </wsdl:message>
  <wsdl:message name="GetMyConfigParameterValueRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyConfigParameterValueResponse">
    <wsdl:part name="parameters" element="tns:GetMyConfigParameterValueResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyConfigParameterValueResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConfigParameterValueOnPersonRequest">
    <wsdl:part name="parameters" element="tns:GetConfigParameterValueOnPerson" />
  </wsdl:message>
  <wsdl:message name="GetConfigParameterValueOnPersonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConfigParameterValueOnPersonResponse">
    <wsdl:part name="parameters" element="tns:GetConfigParameterValueOnPersonResponse" />
  </wsdl:message>
  <wsdl:message name="GetConfigParameterValueOnPersonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConfigParameterOnPersonRequest">
    <wsdl:part name="parameters" element="tns:GetConfigParameterOnPerson" />
  </wsdl:message>
  <wsdl:message name="GetConfigParameterOnPersonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConfigParameterOnPersonResponse">
    <wsdl:part name="parameters" element="tns:GetConfigParameterOnPersonResponse" />
  </wsdl:message>
  <wsdl:message name="GetConfigParameterOnPersonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConfigParametersByLayoutNameRequest">
    <wsdl:part name="parameters" element="tns:GetConfigParametersByLayoutName" />
  </wsdl:message>
  <wsdl:message name="GetConfigParametersByLayoutNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConfigParametersByLayoutNameResponse">
    <wsdl:part name="parameters" element="tns:GetConfigParametersByLayoutNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetConfigParametersByLayoutNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyConfigParametersRequest">
    <wsdl:part name="parameters" element="tns:GetMyConfigParameters" />
  </wsdl:message>
  <wsdl:message name="GetMyConfigParametersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyConfigParametersResponse">
    <wsdl:part name="parameters" element="tns:GetMyConfigParametersResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyConfigParametersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConfigParametersOnPersonRequest">
    <wsdl:part name="parameters" element="tns:GetConfigParametersOnPerson" />
  </wsdl:message>
  <wsdl:message name="GetConfigParametersOnPersonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConfigParametersOnPersonResponse">
    <wsdl:part name="parameters" element="tns:GetConfigParametersOnPersonResponse" />
  </wsdl:message>
  <wsdl:message name="GetConfigParametersOnPersonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAudienceLayoutEntityRequest">
    <wsdl:part name="parameters" element="tns:GetAudienceLayoutEntity" />
  </wsdl:message>
  <wsdl:message name="GetAudienceLayoutEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAudienceLayoutEntityResponse">
    <wsdl:part name="parameters" element="tns:GetAudienceLayoutEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetAudienceLayoutEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAudienceLayoutByNameRequest">
    <wsdl:part name="parameters" element="tns:GetAudienceLayoutByName" />
  </wsdl:message>
  <wsdl:message name="GetAudienceLayoutByNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAudienceLayoutByNameResponse">
    <wsdl:part name="parameters" element="tns:GetAudienceLayoutByNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetAudienceLayoutByNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyAudienceLayoutRequest">
    <wsdl:part name="parameters" element="tns:GetMyAudienceLayout" />
  </wsdl:message>
  <wsdl:message name="GetMyAudienceLayoutRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyAudienceLayoutResponse">
    <wsdl:part name="parameters" element="tns:GetMyAudienceLayoutResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyAudienceLayoutResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAudienceLayoutOnPersonRequest">
    <wsdl:part name="parameters" element="tns:GetAudienceLayoutOnPerson" />
  </wsdl:message>
  <wsdl:message name="GetAudienceLayoutOnPersonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAudienceLayoutOnPersonResponse">
    <wsdl:part name="parameters" element="tns:GetAudienceLayoutOnPersonResponse" />
  </wsdl:message>
  <wsdl:message name="GetAudienceLayoutOnPersonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultProjectImageRequest">
    <wsdl:part name="parameters" element="tns:GetDefaultProjectImage" />
  </wsdl:message>
  <wsdl:message name="GetDefaultProjectImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultProjectImageResponse">
    <wsdl:part name="parameters" element="tns:GetDefaultProjectImageResponse" />
  </wsdl:message>
  <wsdl:message name="GetDefaultProjectImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDefaultProjectImageRequest">
    <wsdl:part name="parameters" element="tns:SetDefaultProjectImage" />
  </wsdl:message>
  <wsdl:message name="SetDefaultProjectImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDefaultProjectImageResponse">
    <wsdl:part name="parameters" element="tns:SetDefaultProjectImageResponse" />
  </wsdl:message>
  <wsdl:message name="SetDefaultProjectImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDefaultPersonImageRequest">
    <wsdl:part name="parameters" element="tns:SetDefaultPersonImage" />
  </wsdl:message>
  <wsdl:message name="SetDefaultPersonImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDefaultPersonImageResponse">
    <wsdl:part name="parameters" element="tns:SetDefaultPersonImageResponse" />
  </wsdl:message>
  <wsdl:message name="SetDefaultPersonImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultPersonImageRequest">
    <wsdl:part name="parameters" element="tns:GetDefaultPersonImage" />
  </wsdl:message>
  <wsdl:message name="GetDefaultPersonImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultPersonImageResponse">
    <wsdl:part name="parameters" element="tns:GetDefaultPersonImageResponse" />
  </wsdl:message>
  <wsdl:message name="GetDefaultPersonImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDefaultCountryFlagRequest">
    <wsdl:part name="parameters" element="tns:SetDefaultCountryFlag" />
  </wsdl:message>
  <wsdl:message name="SetDefaultCountryFlagRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDefaultCountryFlagResponse">
    <wsdl:part name="parameters" element="tns:SetDefaultCountryFlagResponse" />
  </wsdl:message>
  <wsdl:message name="SetDefaultCountryFlagResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultCountryFlagRequest">
    <wsdl:part name="parameters" element="tns:GetDefaultCountryFlag" />
  </wsdl:message>
  <wsdl:message name="GetDefaultCountryFlagRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDefaultCountryFlagResponse">
    <wsdl:part name="parameters" element="tns:GetDefaultCountryFlagResponse" />
  </wsdl:message>
  <wsdl:message name="GetDefaultCountryFlagResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLogoImageRequest">
    <wsdl:part name="parameters" element="tns:GetLogoImage" />
  </wsdl:message>
  <wsdl:message name="GetLogoImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetLogoImageResponse">
    <wsdl:part name="parameters" element="tns:GetLogoImageResponse" />
  </wsdl:message>
  <wsdl:message name="GetLogoImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetLogoImageRequest">
    <wsdl:part name="parameters" element="tns:SetLogoImage" />
  </wsdl:message>
  <wsdl:message name="SetLogoImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetLogoImageResponse">
    <wsdl:part name="parameters" element="tns:SetLogoImageResponse" />
  </wsdl:message>
  <wsdl:message name="SetLogoImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Audience">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Audience</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultAudienceLayoutEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new AudienceLayoutEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/CreateDefaultAudienceLayoutEntity" name="CreateDefaultAudienceLayoutEntityRequest" message="tns:CreateDefaultAudienceLayoutEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/CreateDefaultAudienceLayoutEntityResponse" name="CreateDefaultAudienceLayoutEntityResponse" message="tns:CreateDefaultAudienceLayoutEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveAudienceLayoutEntity">
      <wsdl:documentation>
        <summary>Updates the existing AudienceLayoutEntity or creates a new AudienceLayoutEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/SaveAudienceLayoutEntity" name="SaveAudienceLayoutEntityRequest" message="tns:SaveAudienceLayoutEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/SaveAudienceLayoutEntityResponse" name="SaveAudienceLayoutEntityResponse" message="tns:SaveAudienceLayoutEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteAudienceLayoutEntity">
      <wsdl:documentation>
        <summary>Deletes the AudienceLayoutEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/DeleteAudienceLayoutEntity" name="DeleteAudienceLayoutEntityRequest" message="tns:DeleteAudienceLayoutEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/DeleteAudienceLayoutEntityResponse" name="DeleteAudienceLayoutEntityResponse" message="tns:DeleteAudienceLayoutEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveConfigParameter">
      <wsdl:documentation>
        <summary>Saves an Audience configuration parameter belonging to a Audience layout</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/SaveConfigParameter" name="SaveConfigParameterRequest" message="tns:SaveConfigParameterRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/SaveConfigParameterResponse" name="SaveConfigParameterResponse" message="tns:SaveConfigParameterResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConfigParameterValue">
      <wsdl:documentation>
        <summary>Gets the string value of an Audience configuration parameter belonging to a given Audience layout with the specified configuration parameter name</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetConfigParameterValue" name="GetConfigParameterValueRequest" message="tns:GetConfigParameterValueRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetConfigParameterValueResponse" name="GetConfigParameterValueResponse" message="tns:GetConfigParameterValueResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConfigParameter">
      <wsdl:documentation>
        <summary>Gets an Audience configuration parameter belonging to a given Audience layout with the specified configuration parameter name</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetConfigParameter" name="GetConfigParameterRequest" message="tns:GetConfigParameterRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetConfigParameterResponse" name="GetConfigParameterResponse" message="tns:GetConfigParameterResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteConfigParameter">
      <wsdl:documentation>
        <summary>Deletes an Audience configuration parameter belonging to a Audience layout</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/DeleteConfigParameter" name="DeleteConfigParameterRequest" message="tns:DeleteConfigParameterRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/DeleteConfigParameterResponse" name="DeleteConfigParameterResponse" message="tns:DeleteConfigParameterResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyConfigParameter">
      <wsdl:documentation>
        <summary>Gets an Audience configuration parameter belonging to the currently logged on user with the specified configuration parameter name.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetMyConfigParameter" name="GetMyConfigParameterRequest" message="tns:GetMyConfigParameterRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetMyConfigParameterResponse" name="GetMyConfigParameterResponse" message="tns:GetMyConfigParameterResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyConfigParameterValue">
      <wsdl:documentation>
        <summary>Gets the string value of an Audience configuration parameter belonging to the currently logged on user with the specified configuration parameter name.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetMyConfigParameterValue" name="GetMyConfigParameterValueRequest" message="tns:GetMyConfigParameterValueRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetMyConfigParameterValueResponse" name="GetMyConfigParameterValueResponse" message="tns:GetMyConfigParameterValueResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConfigParameterValueOnPerson">
      <wsdl:documentation>
        <summary>Gets the string value of an Audience configuration parameter with the specified configuration parameter name on the person specified</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetConfigParameterValueOnPerson" name="GetConfigParameterValueOnPersonRequest" message="tns:GetConfigParameterValueOnPersonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetConfigParameterValueOnPersonResponse" name="GetConfigParameterValueOnPersonResponse" message="tns:GetConfigParameterValueOnPersonResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConfigParameterOnPerson">
      <wsdl:documentation>
        <summary>Gets an Audience configuration parameter with the specified configuration parameter name on the person specified</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetConfigParameterOnPerson" name="GetConfigParameterOnPersonRequest" message="tns:GetConfigParameterOnPersonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetConfigParameterOnPersonResponse" name="GetConfigParameterOnPersonResponse" message="tns:GetConfigParameterOnPersonResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConfigParametersByLayoutName">
      <wsdl:documentation>
        <summary>Gets the Audience configuration parameters belonging to a given Audience layout.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetConfigParametersByLayoutName" name="GetConfigParametersByLayoutNameRequest" message="tns:GetConfigParametersByLayoutNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetConfigParametersByLayoutNameResponse" name="GetConfigParametersByLayoutNameResponse" message="tns:GetConfigParametersByLayoutNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyConfigParameters">
      <wsdl:documentation>
        <summary>Gets the Audience configuration parameters belonging to the currently logged on user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetMyConfigParameters" name="GetMyConfigParametersRequest" message="tns:GetMyConfigParametersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetMyConfigParametersResponse" name="GetMyConfigParametersResponse" message="tns:GetMyConfigParametersResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConfigParametersOnPerson">
      <wsdl:documentation>
        <summary>Gets the Audience configuration parameters belonging to the person specified</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetConfigParametersOnPerson" name="GetConfigParametersOnPersonRequest" message="tns:GetConfigParametersOnPersonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetConfigParametersOnPersonResponse" name="GetConfigParametersOnPersonResponse" message="tns:GetConfigParametersOnPersonResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAudienceLayoutEntity">
      <wsdl:documentation>
        <summary>Gets a AudienceLayoutEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetAudienceLayoutEntity" name="GetAudienceLayoutEntityRequest" message="tns:GetAudienceLayoutEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetAudienceLayoutEntityResponse" name="GetAudienceLayoutEntityResponse" message="tns:GetAudienceLayoutEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAudienceLayoutByName">
      <wsdl:documentation>
        <summary>Gets an Audience layout by it's instance name</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetAudienceLayoutByName" name="GetAudienceLayoutByNameRequest" message="tns:GetAudienceLayoutByNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetAudienceLayoutByNameResponse" name="GetAudienceLayoutByNameResponse" message="tns:GetAudienceLayoutByNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyAudienceLayout">
      <wsdl:documentation>
        <summary>Gets the Audience layout belonging to the currently logged on user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetMyAudienceLayout" name="GetMyAudienceLayoutRequest" message="tns:GetMyAudienceLayoutRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetMyAudienceLayoutResponse" name="GetMyAudienceLayoutResponse" message="tns:GetMyAudienceLayoutResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAudienceLayoutOnPerson">
      <wsdl:documentation>
        <summary>Gets the Audience layout belonging to the person specified.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetAudienceLayoutOnPerson" name="GetAudienceLayoutOnPersonRequest" message="tns:GetAudienceLayoutOnPersonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetAudienceLayoutOnPersonResponse" name="GetAudienceLayoutOnPersonResponse" message="tns:GetAudienceLayoutOnPersonResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDefaultProjectImage">
      <wsdl:documentation>
        <summary>Returns the default project or event image that is displayed in Audience when no project/event image is found. The image belongs to a specific Audience layout instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetDefaultProjectImage" name="GetDefaultProjectImageRequest" message="tns:GetDefaultProjectImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetDefaultProjectImageResponse" name="GetDefaultProjectImageResponse" message="tns:GetDefaultProjectImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetDefaultProjectImage">
      <wsdl:documentation>
        <summary>Stores the default project or event image that is displayed in Audience when no project/event image is found. The image is set on a specific Audience layout instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/SetDefaultProjectImage" name="SetDefaultProjectImageRequest" message="tns:SetDefaultProjectImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/SetDefaultProjectImageResponse" name="SetDefaultProjectImageResponse" message="tns:SetDefaultProjectImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetDefaultPersonImage">
      <wsdl:documentation>
        <summary>Stores the default person (sales rep) image that is displayed in Audience when no person image is found. The image is set on a specific Audience layout instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/SetDefaultPersonImage" name="SetDefaultPersonImageRequest" message="tns:SetDefaultPersonImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/SetDefaultPersonImageResponse" name="SetDefaultPersonImageResponse" message="tns:SetDefaultPersonImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDefaultPersonImage">
      <wsdl:documentation>
        <summary>Returns the default person (sales rep) image that is displayed in Audience when no person image is found. The image belongs to a specific Audience layout instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetDefaultPersonImage" name="GetDefaultPersonImageRequest" message="tns:GetDefaultPersonImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetDefaultPersonImageResponse" name="GetDefaultPersonImageResponse" message="tns:GetDefaultPersonImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetDefaultCountryFlag">
      <wsdl:documentation>
        <summary>Stores the default country flag image that is displayed in Audience when no person image is found. The image is set on a specific Audience layout instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/SetDefaultCountryFlag" name="SetDefaultCountryFlagRequest" message="tns:SetDefaultCountryFlagRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/SetDefaultCountryFlagResponse" name="SetDefaultCountryFlagResponse" message="tns:SetDefaultCountryFlagResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDefaultCountryFlag">
      <wsdl:documentation>
        <summary>Returns the default country flag image that is displayed in Audience when no person image is found. The image belongs to a specific Audience layout instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetDefaultCountryFlag" name="GetDefaultCountryFlagRequest" message="tns:GetDefaultCountryFlagRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetDefaultCountryFlagResponse" name="GetDefaultCountryFlagResponse" message="tns:GetDefaultCountryFlagResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetLogoImage">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetLogoImage" name="GetLogoImageRequest" message="tns:GetLogoImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetLogoImageResponse" name="GetLogoImageResponse" message="tns:GetLogoImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetLogoImage">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/SetLogoImage" name="SetLogoImageRequest" message="tns:SetLogoImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/SetLogoImageResponse" name="SetLogoImageResponse" message="tns:SetLogoImageResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Audience" type="tns:Audience">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultAudienceLayoutEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/CreateDefaultAudienceLayoutEntity" style="document" />
      <wsdl:input name="CreateDefaultAudienceLayoutEntityRequest">
        <soap:header message="tns:CreateDefaultAudienceLayoutEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultAudienceLayoutEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultAudienceLayoutEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultAudienceLayoutEntityResponse">
        <soap:header message="tns:CreateDefaultAudienceLayoutEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAudienceLayoutEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAudienceLayoutEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultAudienceLayoutEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveAudienceLayoutEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/SaveAudienceLayoutEntity" style="document" />
      <wsdl:input name="SaveAudienceLayoutEntityRequest">
        <soap:header message="tns:SaveAudienceLayoutEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveAudienceLayoutEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveAudienceLayoutEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveAudienceLayoutEntityResponse">
        <soap:header message="tns:SaveAudienceLayoutEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveAudienceLayoutEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveAudienceLayoutEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveAudienceLayoutEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteAudienceLayoutEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/DeleteAudienceLayoutEntity" style="document" />
      <wsdl:input name="DeleteAudienceLayoutEntityRequest">
        <soap:header message="tns:DeleteAudienceLayoutEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteAudienceLayoutEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteAudienceLayoutEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteAudienceLayoutEntityResponse">
        <soap:header message="tns:DeleteAudienceLayoutEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteAudienceLayoutEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteAudienceLayoutEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteAudienceLayoutEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveConfigParameter">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/SaveConfigParameter" style="document" />
      <wsdl:input name="SaveConfigParameterRequest">
        <soap:header message="tns:SaveConfigParameterRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveConfigParameterRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveConfigParameterRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveConfigParameterResponse">
        <soap:header message="tns:SaveConfigParameterResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveConfigParameterResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveConfigParameterResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveConfigParameterResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConfigParameterValue">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetConfigParameterValue" style="document" />
      <wsdl:input name="GetConfigParameterValueRequest">
        <soap:header message="tns:GetConfigParameterValueRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConfigParameterValueRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConfigParameterValueRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConfigParameterValueResponse">
        <soap:header message="tns:GetConfigParameterValueResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConfigParameterValueResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConfigParameterValueResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConfigParameterValueResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConfigParameter">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetConfigParameter" style="document" />
      <wsdl:input name="GetConfigParameterRequest">
        <soap:header message="tns:GetConfigParameterRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConfigParameterRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConfigParameterRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConfigParameterResponse">
        <soap:header message="tns:GetConfigParameterResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConfigParameterResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConfigParameterResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConfigParameterResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteConfigParameter">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/DeleteConfigParameter" style="document" />
      <wsdl:input name="DeleteConfigParameterRequest">
        <soap:header message="tns:DeleteConfigParameterRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteConfigParameterRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteConfigParameterRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteConfigParameterResponse">
        <soap:header message="tns:DeleteConfigParameterResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteConfigParameterResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteConfigParameterResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteConfigParameterResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyConfigParameter">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetMyConfigParameter" style="document" />
      <wsdl:input name="GetMyConfigParameterRequest">
        <soap:header message="tns:GetMyConfigParameterRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyConfigParameterRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyConfigParameterRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyConfigParameterResponse">
        <soap:header message="tns:GetMyConfigParameterResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyConfigParameterResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyConfigParameterResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyConfigParameterResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyConfigParameterValue">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetMyConfigParameterValue" style="document" />
      <wsdl:input name="GetMyConfigParameterValueRequest">
        <soap:header message="tns:GetMyConfigParameterValueRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyConfigParameterValueRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyConfigParameterValueRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyConfigParameterValueResponse">
        <soap:header message="tns:GetMyConfigParameterValueResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyConfigParameterValueResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyConfigParameterValueResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyConfigParameterValueResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConfigParameterValueOnPerson">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetConfigParameterValueOnPerson" style="document" />
      <wsdl:input name="GetConfigParameterValueOnPersonRequest">
        <soap:header message="tns:GetConfigParameterValueOnPersonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConfigParameterValueOnPersonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConfigParameterValueOnPersonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConfigParameterValueOnPersonResponse">
        <soap:header message="tns:GetConfigParameterValueOnPersonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConfigParameterValueOnPersonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConfigParameterValueOnPersonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConfigParameterValueOnPersonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConfigParameterOnPerson">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetConfigParameterOnPerson" style="document" />
      <wsdl:input name="GetConfigParameterOnPersonRequest">
        <soap:header message="tns:GetConfigParameterOnPersonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConfigParameterOnPersonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConfigParameterOnPersonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConfigParameterOnPersonResponse">
        <soap:header message="tns:GetConfigParameterOnPersonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConfigParameterOnPersonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConfigParameterOnPersonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConfigParameterOnPersonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConfigParametersByLayoutName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetConfigParametersByLayoutName" style="document" />
      <wsdl:input name="GetConfigParametersByLayoutNameRequest">
        <soap:header message="tns:GetConfigParametersByLayoutNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConfigParametersByLayoutNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConfigParametersByLayoutNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConfigParametersByLayoutNameResponse">
        <soap:header message="tns:GetConfigParametersByLayoutNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConfigParametersByLayoutNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConfigParametersByLayoutNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConfigParametersByLayoutNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyConfigParameters">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetMyConfigParameters" style="document" />
      <wsdl:input name="GetMyConfigParametersRequest">
        <soap:header message="tns:GetMyConfigParametersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyConfigParametersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyConfigParametersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyConfigParametersResponse">
        <soap:header message="tns:GetMyConfigParametersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyConfigParametersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyConfigParametersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyConfigParametersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConfigParametersOnPerson">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetConfigParametersOnPerson" style="document" />
      <wsdl:input name="GetConfigParametersOnPersonRequest">
        <soap:header message="tns:GetConfigParametersOnPersonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConfigParametersOnPersonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConfigParametersOnPersonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConfigParametersOnPersonResponse">
        <soap:header message="tns:GetConfigParametersOnPersonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConfigParametersOnPersonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConfigParametersOnPersonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConfigParametersOnPersonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAudienceLayoutEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetAudienceLayoutEntity" style="document" />
      <wsdl:input name="GetAudienceLayoutEntityRequest">
        <soap:header message="tns:GetAudienceLayoutEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAudienceLayoutEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAudienceLayoutEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAudienceLayoutEntityResponse">
        <soap:header message="tns:GetAudienceLayoutEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAudienceLayoutEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAudienceLayoutEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAudienceLayoutEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAudienceLayoutByName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetAudienceLayoutByName" style="document" />
      <wsdl:input name="GetAudienceLayoutByNameRequest">
        <soap:header message="tns:GetAudienceLayoutByNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAudienceLayoutByNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAudienceLayoutByNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAudienceLayoutByNameResponse">
        <soap:header message="tns:GetAudienceLayoutByNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAudienceLayoutByNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAudienceLayoutByNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAudienceLayoutByNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyAudienceLayout">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetMyAudienceLayout" style="document" />
      <wsdl:input name="GetMyAudienceLayoutRequest">
        <soap:header message="tns:GetMyAudienceLayoutRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyAudienceLayoutRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyAudienceLayoutRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyAudienceLayoutResponse">
        <soap:header message="tns:GetMyAudienceLayoutResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyAudienceLayoutResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyAudienceLayoutResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyAudienceLayoutResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAudienceLayoutOnPerson">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetAudienceLayoutOnPerson" style="document" />
      <wsdl:input name="GetAudienceLayoutOnPersonRequest">
        <soap:header message="tns:GetAudienceLayoutOnPersonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAudienceLayoutOnPersonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAudienceLayoutOnPersonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAudienceLayoutOnPersonResponse">
        <soap:header message="tns:GetAudienceLayoutOnPersonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAudienceLayoutOnPersonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAudienceLayoutOnPersonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAudienceLayoutOnPersonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDefaultProjectImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetDefaultProjectImage" style="document" />
      <wsdl:input name="GetDefaultProjectImageRequest">
        <soap:header message="tns:GetDefaultProjectImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDefaultProjectImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDefaultProjectImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDefaultProjectImageResponse">
        <soap:header message="tns:GetDefaultProjectImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDefaultProjectImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDefaultProjectImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDefaultProjectImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetDefaultProjectImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/SetDefaultProjectImage" style="document" />
      <wsdl:input name="SetDefaultProjectImageRequest">
        <soap:header message="tns:SetDefaultProjectImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetDefaultProjectImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetDefaultProjectImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetDefaultProjectImageResponse">
        <soap:header message="tns:SetDefaultProjectImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetDefaultProjectImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetDefaultProjectImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetDefaultProjectImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetDefaultPersonImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/SetDefaultPersonImage" style="document" />
      <wsdl:input name="SetDefaultPersonImageRequest">
        <soap:header message="tns:SetDefaultPersonImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetDefaultPersonImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetDefaultPersonImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetDefaultPersonImageResponse">
        <soap:header message="tns:SetDefaultPersonImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetDefaultPersonImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetDefaultPersonImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetDefaultPersonImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDefaultPersonImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetDefaultPersonImage" style="document" />
      <wsdl:input name="GetDefaultPersonImageRequest">
        <soap:header message="tns:GetDefaultPersonImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDefaultPersonImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDefaultPersonImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDefaultPersonImageResponse">
        <soap:header message="tns:GetDefaultPersonImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDefaultPersonImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDefaultPersonImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDefaultPersonImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetDefaultCountryFlag">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/SetDefaultCountryFlag" style="document" />
      <wsdl:input name="SetDefaultCountryFlagRequest">
        <soap:header message="tns:SetDefaultCountryFlagRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetDefaultCountryFlagRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetDefaultCountryFlagRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetDefaultCountryFlagResponse">
        <soap:header message="tns:SetDefaultCountryFlagResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetDefaultCountryFlagResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetDefaultCountryFlagResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetDefaultCountryFlagResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDefaultCountryFlag">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetDefaultCountryFlag" style="document" />
      <wsdl:input name="GetDefaultCountryFlagRequest">
        <soap:header message="tns:GetDefaultCountryFlagRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDefaultCountryFlagRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDefaultCountryFlagRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDefaultCountryFlagResponse">
        <soap:header message="tns:GetDefaultCountryFlagResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDefaultCountryFlagResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDefaultCountryFlagResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDefaultCountryFlagResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetLogoImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/GetLogoImage" style="document" />
      <wsdl:input name="GetLogoImageRequest">
        <soap:header message="tns:GetLogoImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetLogoImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetLogoImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetLogoImageResponse">
        <soap:header message="tns:GetLogoImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetLogoImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetLogoImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetLogoImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetLogoImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services87/Audience/SetLogoImage" style="document" />
      <wsdl:input name="SetLogoImageRequest">
        <soap:header message="tns:SetLogoImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetLogoImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetLogoImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetLogoImageResponse">
        <soap:header message="tns:SetLogoImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetLogoImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetLogoImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetLogoImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfAudienceService">
    <wsdl:port name="BasicHttpBinding_Audience" binding="tns:BasicHttpBinding_Audience">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services87/Audience.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

