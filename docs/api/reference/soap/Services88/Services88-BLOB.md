---
generated: 1
uid: wsdl-Services88-BLOB
title: Services88.BLOBAgent WSDL
---

# Services88.BLOBAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfBLOBService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:element name="CreateDefaultBlobEntity">
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
      <xs:element name="CreateDefaultBlobEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:BlobEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="BlobEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="BlobId" type="xs:int" />
              <xs:element minOccurs="0" name="BlobSize" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsEncrypted" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsZipped" type="xs:boolean" />
              <xs:element minOccurs="0" name="MimeType" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OriginalSize" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="ConceptualType" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="BlobEntity" nillable="true" type="tns:BlobEntity" />
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
      <xs:element name="SaveBlobEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BlobEntity" nillable="true" type="tns:BlobEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveBlobEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:BlobEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteBlobEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BlobEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteBlobEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBlobEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BlobEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBlobEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:BlobEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetBlobStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BlobEntityId" type="xs:int" />
            <xs:element minOccurs="0" name="Stream" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetBlobStreamResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBlobStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BlobEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBlobStreamResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
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
      <xs:element name="GetPersonImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonImageResponse">
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
      <xs:element name="SetPersonImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="Image" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetPersonImageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeProjectImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="BlobId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeProjectImageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveProjectImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Image" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveProjectImageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBlobEntityOnProject">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBlobEntityOnProjectResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:BlobEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBlobEntityOnPerson">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBlobEntityOnPersonResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:BlobEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBlobEntityOnCountry">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CountryId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBlobEntityOnCountryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:BlobEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBlobEntityOnProduct">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProductId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBlobEntityOnProductResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:BlobEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangePersonImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="BlobId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangePersonImageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveImageStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Type" type="tns:BlobLinkType" />
            <xs:element minOccurs="0" name="Image" nillable="true" type="xs:base64Binary" />
            <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="BlobLinkType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="PersonImage">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ProjectImage">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">2</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="EventImage">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">3</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Thumbnail">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">4</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="StatusMonitorImage">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">5</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="BatchTask">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">6</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ProductImage">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">7</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ProductThumbnail">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">8</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="QuoteLineImage">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">9</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="QuoteLineThumbnail">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">10</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="AccessToken">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">11</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="RefreshToken">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">12</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Dashboard">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">13</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="DashboardTile">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">14</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ChatTopicImage">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">15</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="FormsBackgroundImage">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">16</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ContactImage">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">17</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="DashboardHtmlTileData">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">18</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="BlobLinkType" nillable="true" type="tns:BlobLinkType" />
      <xs:element name="SaveImageStreamResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProductImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProductId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProductImageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetProductImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProductId" type="xs:int" />
            <xs:element minOccurs="0" name="Image" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetProductImageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProductThumbnail">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProductId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProductThumbnailResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetProductThumbnail">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProductId" type="xs:int" />
            <xs:element minOccurs="0" name="Image" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetProductThumbnailResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeProductImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProductId" type="xs:int" />
            <xs:element minOccurs="0" name="BlobId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeProductImageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteLineImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteLineId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteLineImageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppData">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Key" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppDataResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetAppData">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Key" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Data" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetAppDataResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonImageWithSize">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="Width" type="xs:int" />
            <xs:element minOccurs="0" name="Height" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonImageWithSizeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectImageWithSize">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="Width" type="xs:int" />
            <xs:element minOccurs="0" name="Height" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectImageWithSizeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatImageWithSize">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ChatTopicId" type="xs:int" />
            <xs:element minOccurs="0" name="Width" type="xs:int" />
            <xs:element minOccurs="0" name="Height" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatImageWithSizeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactImageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetContactImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="Image" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetContactImageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeContactImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="BlobId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeContactImageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBlobEntityOnContact">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBlobEntityOnContactResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:BlobEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactImageWithSize">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="Width" type="xs:int" />
            <xs:element minOccurs="0" name="Height" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactImageWithSizeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetOutputFromBatch">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BatchTaskId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetOutputFromBatchResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CleanupBatchTask">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BatchTaskId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CleanupBatchTaskResponse">
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
  <wsdl:message name="CreateDefaultBlobEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultBlobEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultBlobEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultBlobEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultBlobEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultBlobEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveBlobEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveBlobEntity" />
  </wsdl:message>
  <wsdl:message name="SaveBlobEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveBlobEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveBlobEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveBlobEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteBlobEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteBlobEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteBlobEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteBlobEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteBlobEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteBlobEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityRequest">
    <wsdl:part name="parameters" element="tns:GetBlobEntity" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityResponse">
    <wsdl:part name="parameters" element="tns:GetBlobEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetBlobStreamRequest">
    <wsdl:part name="parameters" element="tns:SetBlobStream" />
  </wsdl:message>
  <wsdl:message name="SetBlobStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetBlobStreamResponse">
    <wsdl:part name="parameters" element="tns:SetBlobStreamResponse" />
  </wsdl:message>
  <wsdl:message name="SetBlobStreamResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBlobStreamRequest">
    <wsdl:part name="parameters" element="tns:GetBlobStream" />
  </wsdl:message>
  <wsdl:message name="GetBlobStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBlobStreamResponse">
    <wsdl:part name="parameters" element="tns:GetBlobStreamResponse" />
  </wsdl:message>
  <wsdl:message name="GetBlobStreamResponse_Headers">
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
  <wsdl:message name="GetPersonImageRequest">
    <wsdl:part name="parameters" element="tns:GetPersonImage" />
  </wsdl:message>
  <wsdl:message name="GetPersonImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonImageResponse">
    <wsdl:part name="parameters" element="tns:GetPersonImageResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonImageResponse_Headers">
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
  <wsdl:message name="SetPersonImageRequest">
    <wsdl:part name="parameters" element="tns:SetPersonImage" />
  </wsdl:message>
  <wsdl:message name="SetPersonImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetPersonImageResponse">
    <wsdl:part name="parameters" element="tns:SetPersonImageResponse" />
  </wsdl:message>
  <wsdl:message name="SetPersonImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeProjectImageRequest">
    <wsdl:part name="parameters" element="tns:ChangeProjectImage" />
  </wsdl:message>
  <wsdl:message name="ChangeProjectImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeProjectImageResponse">
    <wsdl:part name="parameters" element="tns:ChangeProjectImageResponse" />
  </wsdl:message>
  <wsdl:message name="ChangeProjectImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveProjectImageRequest">
    <wsdl:part name="parameters" element="tns:SaveProjectImage" />
  </wsdl:message>
  <wsdl:message name="SaveProjectImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveProjectImageResponse">
    <wsdl:part name="parameters" element="tns:SaveProjectImageResponse" />
  </wsdl:message>
  <wsdl:message name="SaveProjectImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnProjectRequest">
    <wsdl:part name="parameters" element="tns:GetBlobEntityOnProject" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnProjectRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnProjectResponse">
    <wsdl:part name="parameters" element="tns:GetBlobEntityOnProjectResponse" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnProjectResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnPersonRequest">
    <wsdl:part name="parameters" element="tns:GetBlobEntityOnPerson" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnPersonRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnPersonResponse">
    <wsdl:part name="parameters" element="tns:GetBlobEntityOnPersonResponse" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnPersonResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnCountryRequest">
    <wsdl:part name="parameters" element="tns:GetBlobEntityOnCountry" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnCountryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnCountryResponse">
    <wsdl:part name="parameters" element="tns:GetBlobEntityOnCountryResponse" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnCountryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnProductRequest">
    <wsdl:part name="parameters" element="tns:GetBlobEntityOnProduct" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnProductRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnProductResponse">
    <wsdl:part name="parameters" element="tns:GetBlobEntityOnProductResponse" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnProductResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangePersonImageRequest">
    <wsdl:part name="parameters" element="tns:ChangePersonImage" />
  </wsdl:message>
  <wsdl:message name="ChangePersonImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangePersonImageResponse">
    <wsdl:part name="parameters" element="tns:ChangePersonImageResponse" />
  </wsdl:message>
  <wsdl:message name="ChangePersonImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveImageStreamRequest">
    <wsdl:part name="parameters" element="tns:SaveImageStream" />
  </wsdl:message>
  <wsdl:message name="SaveImageStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveImageStreamResponse">
    <wsdl:part name="parameters" element="tns:SaveImageStreamResponse" />
  </wsdl:message>
  <wsdl:message name="SaveImageStreamResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductImageRequest">
    <wsdl:part name="parameters" element="tns:GetProductImage" />
  </wsdl:message>
  <wsdl:message name="GetProductImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductImageResponse">
    <wsdl:part name="parameters" element="tns:GetProductImageResponse" />
  </wsdl:message>
  <wsdl:message name="GetProductImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetProductImageRequest">
    <wsdl:part name="parameters" element="tns:SetProductImage" />
  </wsdl:message>
  <wsdl:message name="SetProductImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetProductImageResponse">
    <wsdl:part name="parameters" element="tns:SetProductImageResponse" />
  </wsdl:message>
  <wsdl:message name="SetProductImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductThumbnailRequest">
    <wsdl:part name="parameters" element="tns:GetProductThumbnail" />
  </wsdl:message>
  <wsdl:message name="GetProductThumbnailRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductThumbnailResponse">
    <wsdl:part name="parameters" element="tns:GetProductThumbnailResponse" />
  </wsdl:message>
  <wsdl:message name="GetProductThumbnailResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetProductThumbnailRequest">
    <wsdl:part name="parameters" element="tns:SetProductThumbnail" />
  </wsdl:message>
  <wsdl:message name="SetProductThumbnailRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetProductThumbnailResponse">
    <wsdl:part name="parameters" element="tns:SetProductThumbnailResponse" />
  </wsdl:message>
  <wsdl:message name="SetProductThumbnailResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeProductImageRequest">
    <wsdl:part name="parameters" element="tns:ChangeProductImage" />
  </wsdl:message>
  <wsdl:message name="ChangeProductImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeProductImageResponse">
    <wsdl:part name="parameters" element="tns:ChangeProductImageResponse" />
  </wsdl:message>
  <wsdl:message name="ChangeProductImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineImageRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteLineImage" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineImageResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteLineImageResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppDataRequest">
    <wsdl:part name="parameters" element="tns:GetAppData" />
  </wsdl:message>
  <wsdl:message name="GetAppDataRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppDataResponse">
    <wsdl:part name="parameters" element="tns:GetAppDataResponse" />
  </wsdl:message>
  <wsdl:message name="GetAppDataResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetAppDataRequest">
    <wsdl:part name="parameters" element="tns:SetAppData" />
  </wsdl:message>
  <wsdl:message name="SetAppDataRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetAppDataResponse">
    <wsdl:part name="parameters" element="tns:SetAppDataResponse" />
  </wsdl:message>
  <wsdl:message name="SetAppDataResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonImageWithSizeRequest">
    <wsdl:part name="parameters" element="tns:GetPersonImageWithSize" />
  </wsdl:message>
  <wsdl:message name="GetPersonImageWithSizeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonImageWithSizeResponse">
    <wsdl:part name="parameters" element="tns:GetPersonImageWithSizeResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonImageWithSizeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectImageWithSizeRequest">
    <wsdl:part name="parameters" element="tns:GetProjectImageWithSize" />
  </wsdl:message>
  <wsdl:message name="GetProjectImageWithSizeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectImageWithSizeResponse">
    <wsdl:part name="parameters" element="tns:GetProjectImageWithSizeResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectImageWithSizeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatImageWithSizeRequest">
    <wsdl:part name="parameters" element="tns:GetChatImageWithSize" />
  </wsdl:message>
  <wsdl:message name="GetChatImageWithSizeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatImageWithSizeResponse">
    <wsdl:part name="parameters" element="tns:GetChatImageWithSizeResponse" />
  </wsdl:message>
  <wsdl:message name="GetChatImageWithSizeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactImageRequest">
    <wsdl:part name="parameters" element="tns:GetContactImage" />
  </wsdl:message>
  <wsdl:message name="GetContactImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactImageResponse">
    <wsdl:part name="parameters" element="tns:GetContactImageResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetContactImageRequest">
    <wsdl:part name="parameters" element="tns:SetContactImage" />
  </wsdl:message>
  <wsdl:message name="SetContactImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetContactImageResponse">
    <wsdl:part name="parameters" element="tns:SetContactImageResponse" />
  </wsdl:message>
  <wsdl:message name="SetContactImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeContactImageRequest">
    <wsdl:part name="parameters" element="tns:ChangeContactImage" />
  </wsdl:message>
  <wsdl:message name="ChangeContactImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeContactImageResponse">
    <wsdl:part name="parameters" element="tns:ChangeContactImageResponse" />
  </wsdl:message>
  <wsdl:message name="ChangeContactImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnContactRequest">
    <wsdl:part name="parameters" element="tns:GetBlobEntityOnContact" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnContactRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnContactResponse">
    <wsdl:part name="parameters" element="tns:GetBlobEntityOnContactResponse" />
  </wsdl:message>
  <wsdl:message name="GetBlobEntityOnContactResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactImageWithSizeRequest">
    <wsdl:part name="parameters" element="tns:GetContactImageWithSize" />
  </wsdl:message>
  <wsdl:message name="GetContactImageWithSizeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactImageWithSizeResponse">
    <wsdl:part name="parameters" element="tns:GetContactImageWithSizeResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactImageWithSizeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetOutputFromBatchRequest">
    <wsdl:part name="parameters" element="tns:GetOutputFromBatch" />
  </wsdl:message>
  <wsdl:message name="GetOutputFromBatchRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetOutputFromBatchResponse">
    <wsdl:part name="parameters" element="tns:GetOutputFromBatchResponse" />
  </wsdl:message>
  <wsdl:message name="GetOutputFromBatchResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CleanupBatchTaskRequest">
    <wsdl:part name="parameters" element="tns:CleanupBatchTask" />
  </wsdl:message>
  <wsdl:message name="CleanupBatchTaskRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CleanupBatchTaskResponse">
    <wsdl:part name="parameters" element="tns:CleanupBatchTaskResponse" />
  </wsdl:message>
  <wsdl:message name="CleanupBatchTaskResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="BLOB">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for BLOB</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultBlobEntity">
      <wsdl:documentation>
        <summary>Loading default values into a new BlobEntity.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/CreateDefaultBlobEntity" name="CreateDefaultBlobEntityRequest" message="tns:CreateDefaultBlobEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/CreateDefaultBlobEntityResponse" name="CreateDefaultBlobEntityResponse" message="tns:CreateDefaultBlobEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveBlobEntity">
      <wsdl:documentation>
        <summary>Updates the existing BlobEntity or creates a new BlobEntity if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SaveBlobEntity" name="SaveBlobEntityRequest" message="tns:SaveBlobEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SaveBlobEntityResponse" name="SaveBlobEntityResponse" message="tns:SaveBlobEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteBlobEntity">
      <wsdl:documentation>
        <summary>Deletes the BlobEntity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/DeleteBlobEntity" name="DeleteBlobEntityRequest" message="tns:DeleteBlobEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/DeleteBlobEntityResponse" name="DeleteBlobEntityResponse" message="tns:DeleteBlobEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBlobEntity">
      <wsdl:documentation>
        <summary>Gets a BlobEntity object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobEntity" name="GetBlobEntityRequest" message="tns:GetBlobEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobEntityResponse" name="GetBlobEntityResponse" message="tns:GetBlobEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetBlobStream">
      <wsdl:documentation>
        <summary>Store a binary object from it's stream</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetBlobStream" name="SetBlobStreamRequest" message="tns:SetBlobStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetBlobStreamResponse" name="SetBlobStreamResponse" message="tns:SetBlobStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBlobStream">
      <wsdl:documentation>
        <summary>Get the binary object as a stream</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobStream" name="GetBlobStreamRequest" message="tns:GetBlobStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobStreamResponse" name="GetBlobStreamResponse" message="tns:GetBlobStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectImage">
      <wsdl:documentation>
        <summary>Returns the project image that is displayed in the CRM application.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetProjectImage" name="GetProjectImageRequest" message="tns:GetProjectImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetProjectImageResponse" name="GetProjectImageResponse" message="tns:GetProjectImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonImage">
      <wsdl:documentation>
        <summary>Returns the person image that is displayed in the CRM application.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetPersonImage" name="GetPersonImageRequest" message="tns:GetPersonImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetPersonImageResponse" name="GetPersonImageResponse" message="tns:GetPersonImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetProjectImage">
      <wsdl:documentation>
        <summary>Stores the project image that is displayed in the CRM application.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetProjectImage" name="SetProjectImageRequest" message="tns:SetProjectImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetProjectImageResponse" name="SetProjectImageResponse" message="tns:SetProjectImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetPersonImage">
      <wsdl:documentation>
        <summary>Stores the person image that is displayed in the CRM application.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetPersonImage" name="SetPersonImageRequest" message="tns:SetPersonImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetPersonImageResponse" name="SetPersonImageResponse" message="tns:SetPersonImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChangeProjectImage">
      <wsdl:documentation>
        <summary>Changes the project image link. If the Binary object id is 0, any image link is removed from the project.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/ChangeProjectImage" name="ChangeProjectImageRequest" message="tns:ChangeProjectImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/ChangeProjectImageResponse" name="ChangeProjectImageResponse" message="tns:ChangeProjectImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveProjectImage">
      <wsdl:documentation>
        <summary>Saves a project image that is displayed in the CRM application's project image selection dialog to the database.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SaveProjectImage" name="SaveProjectImageRequest" message="tns:SaveProjectImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SaveProjectImageResponse" name="SaveProjectImageResponse" message="tns:SaveProjectImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBlobEntityOnProject">
      <wsdl:documentation>
        <summary>Gets the blob entity that represents the project image binary object.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobEntityOnProject" name="GetBlobEntityOnProjectRequest" message="tns:GetBlobEntityOnProjectRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobEntityOnProjectResponse" name="GetBlobEntityOnProjectResponse" message="tns:GetBlobEntityOnProjectResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBlobEntityOnPerson">
      <wsdl:documentation>
        <summary>Gets the blob entity that represents the person image binary object.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobEntityOnPerson" name="GetBlobEntityOnPersonRequest" message="tns:GetBlobEntityOnPersonRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobEntityOnPersonResponse" name="GetBlobEntityOnPersonResponse" message="tns:GetBlobEntityOnPersonResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBlobEntityOnCountry">
      <wsdl:documentation>
        <summary>Gets the blob entity that represents the country flag binary object.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobEntityOnCountry" name="GetBlobEntityOnCountryRequest" message="tns:GetBlobEntityOnCountryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobEntityOnCountryResponse" name="GetBlobEntityOnCountryResponse" message="tns:GetBlobEntityOnCountryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBlobEntityOnProduct">
      <wsdl:documentation>
        <summary>Gets the blob entity that represents the product image binary object.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobEntityOnProduct" name="GetBlobEntityOnProductRequest" message="tns:GetBlobEntityOnProductRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobEntityOnProductResponse" name="GetBlobEntityOnProductResponse" message="tns:GetBlobEntityOnProductResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChangePersonImage">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/ChangePersonImage" name="ChangePersonImageRequest" message="tns:ChangePersonImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/ChangePersonImageResponse" name="ChangePersonImageResponse" message="tns:ChangePersonImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveImageStream">
      <wsdl:documentation>
        <summary>Stores an image in the database without linking it to a project or a person. It is possible to ChangePersonImage or ChangeProjectImage to attach image later.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SaveImageStream" name="SaveImageStreamRequest" message="tns:SaveImageStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SaveImageStreamResponse" name="SaveImageStreamResponse" message="tns:SaveImageStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProductImage">
      <wsdl:documentation>
        <summary>Returns the product image (rank=1) that is displayed in the CRM application.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetProductImage" name="GetProductImageRequest" message="tns:GetProductImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetProductImageResponse" name="GetProductImageResponse" message="tns:GetProductImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetProductImage">
      <wsdl:documentation>
        <summary>Stores the product image that is displayed in the CRM application. The image is scaled down to max 1000x1000. This method operates only the main (rank=1) image; future extensions may support multiple images. A thumbnail of size 75x75 is also automatically set.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetProductImage" name="SetProductImageRequest" message="tns:SetProductImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetProductImageResponse" name="SetProductImageResponse" message="tns:SetProductImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProductThumbnail">
      <wsdl:documentation>
        <summary>Returns the product thumbnail that is displayed in the CRM application.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetProductThumbnail" name="GetProductThumbnailRequest" message="tns:GetProductThumbnailRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetProductThumbnailResponse" name="GetProductThumbnailResponse" message="tns:GetProductThumbnailResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetProductThumbnail">
      <wsdl:documentation>
        <summary>Stores the product thumbnail that is displayed in the CRM application. The image is scaled down to max 200x200 pixels.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetProductThumbnail" name="SetProductThumbnailRequest" message="tns:SetProductThumbnailRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetProductThumbnailResponse" name="SetProductThumbnailResponse" message="tns:SetProductThumbnailResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChangeProductImage">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/ChangeProductImage" name="ChangeProductImageRequest" message="tns:ChangeProductImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/ChangeProductImageResponse" name="ChangeProductImageResponse" message="tns:ChangeProductImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteLineImage">
      <wsdl:documentation>
        <summary>Returns the quoteline image (rank=1) that is displayed in the CRM application.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetQuoteLineImage" name="GetQuoteLineImageRequest" message="tns:GetQuoteLineImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetQuoteLineImageResponse" name="GetQuoteLineImageResponse" message="tns:GetQuoteLineImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAppData">
      <wsdl:documentation>
        <summary>Get a CLOB (limited to a reasonable size by the mechanics of Web Services) according to a string key; ALSO limits to the current ApplicationToken if any</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetAppData" name="GetAppDataRequest" message="tns:GetAppDataRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetAppDataResponse" name="GetAppDataResponse" message="tns:GetAppDataResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetAppData">
      <wsdl:documentation>
        <summary>Get a CLOB (limited to a reasonable size by the mechanics of Web Services) according to a string key; ALSO limits to the current ApplicationToken if any. Existing data, if any, will be overwritten. Overwrite with a blank value to delete.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetAppData" name="SetAppDataRequest" message="tns:SetAppDataRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetAppDataResponse" name="SetAppDataResponse" message="tns:SetAppDataResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonImageWithSize">
      <wsdl:documentation>
        <summary>Returns the person image that is displayed in the CRM application with a specified maximum size.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetPersonImageWithSize" name="GetPersonImageWithSizeRequest" message="tns:GetPersonImageWithSizeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetPersonImageWithSizeResponse" name="GetPersonImageWithSizeResponse" message="tns:GetPersonImageWithSizeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectImageWithSize">
      <wsdl:documentation>
        <summary>Returns the project image that is displayed in the CRM application with a specified maximum size.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetProjectImageWithSize" name="GetProjectImageWithSizeRequest" message="tns:GetProjectImageWithSizeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetProjectImageWithSizeResponse" name="GetProjectImageWithSizeResponse" message="tns:GetProjectImageWithSizeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetChatImageWithSize">
      <wsdl:documentation>
        <summary>Returns the chat image that is displayed in chat with a specified maximum size.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetChatImageWithSize" name="GetChatImageWithSizeRequest" message="tns:GetChatImageWithSizeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetChatImageWithSizeResponse" name="GetChatImageWithSizeResponse" message="tns:GetChatImageWithSizeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactImage">
      <wsdl:documentation>
        <summary>Returns the contact image that is displayed in the CRM application.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetContactImage" name="GetContactImageRequest" message="tns:GetContactImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetContactImageResponse" name="GetContactImageResponse" message="tns:GetContactImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetContactImage">
      <wsdl:documentation>
        <summary>Stores the contact image that is displayed in the CRM application.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetContactImage" name="SetContactImageRequest" message="tns:SetContactImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetContactImageResponse" name="SetContactImageResponse" message="tns:SetContactImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChangeContactImage">
      <wsdl:documentation>
        <summary>Changes the contact image link. If the Binary object id is 0, any image link is removed from the contact.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/ChangeContactImage" name="ChangeContactImageRequest" message="tns:ChangeContactImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/ChangeContactImageResponse" name="ChangeContactImageResponse" message="tns:ChangeContactImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBlobEntityOnContact">
      <wsdl:documentation>
        <summary>Gets the blob entity that represents the contact image binary object.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobEntityOnContact" name="GetBlobEntityOnContactRequest" message="tns:GetBlobEntityOnContactRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobEntityOnContactResponse" name="GetBlobEntityOnContactResponse" message="tns:GetBlobEntityOnContactResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactImageWithSize">
      <wsdl:documentation>
        <summary>Returns the contact image that is displayed in the CRM application with a specified maximum size.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetContactImageWithSize" name="GetContactImageWithSizeRequest" message="tns:GetContactImageWithSizeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetContactImageWithSizeResponse" name="GetContactImageWithSizeResponse" message="tns:GetContactImageWithSizeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetOutputFromBatch">
      <wsdl:documentation>
        <summary>Get the output of a batchtask as a stream</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetOutputFromBatch" name="GetOutputFromBatchRequest" message="tns:GetOutputFromBatchRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetOutputFromBatchResponse" name="GetOutputFromBatchResponse" message="tns:GetOutputFromBatchResponse" />
    </wsdl:operation>
    <wsdl:operation name="CleanupBatchTask">
      <wsdl:documentation>
        <summary>Removes the binary objects linked to the batch task, the links themselves and the batch task.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/CleanupBatchTask" name="CleanupBatchTaskRequest" message="tns:CleanupBatchTaskRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/CleanupBatchTaskResponse" name="CleanupBatchTaskResponse" message="tns:CleanupBatchTaskResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_BLOB" type="tns:BLOB">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultBlobEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/CreateDefaultBlobEntity" style="document" />
      <wsdl:input name="CreateDefaultBlobEntityRequest">
        <soap:header message="tns:CreateDefaultBlobEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultBlobEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultBlobEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultBlobEntityResponse">
        <soap:header message="tns:CreateDefaultBlobEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultBlobEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultBlobEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultBlobEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveBlobEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SaveBlobEntity" style="document" />
      <wsdl:input name="SaveBlobEntityRequest">
        <soap:header message="tns:SaveBlobEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveBlobEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveBlobEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveBlobEntityResponse">
        <soap:header message="tns:SaveBlobEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveBlobEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveBlobEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveBlobEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteBlobEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/DeleteBlobEntity" style="document" />
      <wsdl:input name="DeleteBlobEntityRequest">
        <soap:header message="tns:DeleteBlobEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteBlobEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteBlobEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteBlobEntityResponse">
        <soap:header message="tns:DeleteBlobEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteBlobEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteBlobEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteBlobEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBlobEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobEntity" style="document" />
      <wsdl:input name="GetBlobEntityRequest">
        <soap:header message="tns:GetBlobEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBlobEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBlobEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBlobEntityResponse">
        <soap:header message="tns:GetBlobEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBlobEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBlobEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBlobEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetBlobStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetBlobStream" style="document" />
      <wsdl:input name="SetBlobStreamRequest">
        <soap:header message="tns:SetBlobStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetBlobStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetBlobStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetBlobStreamResponse">
        <soap:header message="tns:SetBlobStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetBlobStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetBlobStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetBlobStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBlobStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobStream" style="document" />
      <wsdl:input name="GetBlobStreamRequest">
        <soap:header message="tns:GetBlobStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBlobStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBlobStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBlobStreamResponse">
        <soap:header message="tns:GetBlobStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBlobStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBlobStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBlobStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetProjectImage" style="document" />
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
    <wsdl:operation name="GetPersonImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetPersonImage" style="document" />
      <wsdl:input name="GetPersonImageRequest">
        <soap:header message="tns:GetPersonImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonImageResponse">
        <soap:header message="tns:GetPersonImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetProjectImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetProjectImage" style="document" />
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
    <wsdl:operation name="SetPersonImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetPersonImage" style="document" />
      <wsdl:input name="SetPersonImageRequest">
        <soap:header message="tns:SetPersonImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetPersonImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetPersonImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetPersonImageResponse">
        <soap:header message="tns:SetPersonImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetPersonImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetPersonImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetPersonImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChangeProjectImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/ChangeProjectImage" style="document" />
      <wsdl:input name="ChangeProjectImageRequest">
        <soap:header message="tns:ChangeProjectImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChangeProjectImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChangeProjectImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChangeProjectImageResponse">
        <soap:header message="tns:ChangeProjectImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChangeProjectImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChangeProjectImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChangeProjectImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveProjectImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SaveProjectImage" style="document" />
      <wsdl:input name="SaveProjectImageRequest">
        <soap:header message="tns:SaveProjectImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveProjectImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveProjectImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveProjectImageResponse">
        <soap:header message="tns:SaveProjectImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveProjectImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveProjectImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveProjectImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBlobEntityOnProject">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobEntityOnProject" style="document" />
      <wsdl:input name="GetBlobEntityOnProjectRequest">
        <soap:header message="tns:GetBlobEntityOnProjectRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBlobEntityOnProjectRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBlobEntityOnProjectRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBlobEntityOnProjectResponse">
        <soap:header message="tns:GetBlobEntityOnProjectResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBlobEntityOnProjectResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBlobEntityOnProjectResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBlobEntityOnProjectResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBlobEntityOnPerson">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobEntityOnPerson" style="document" />
      <wsdl:input name="GetBlobEntityOnPersonRequest">
        <soap:header message="tns:GetBlobEntityOnPersonRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBlobEntityOnPersonRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBlobEntityOnPersonRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBlobEntityOnPersonResponse">
        <soap:header message="tns:GetBlobEntityOnPersonResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBlobEntityOnPersonResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBlobEntityOnPersonResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBlobEntityOnPersonResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBlobEntityOnCountry">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobEntityOnCountry" style="document" />
      <wsdl:input name="GetBlobEntityOnCountryRequest">
        <soap:header message="tns:GetBlobEntityOnCountryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBlobEntityOnCountryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBlobEntityOnCountryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBlobEntityOnCountryResponse">
        <soap:header message="tns:GetBlobEntityOnCountryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBlobEntityOnCountryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBlobEntityOnCountryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBlobEntityOnCountryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBlobEntityOnProduct">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobEntityOnProduct" style="document" />
      <wsdl:input name="GetBlobEntityOnProductRequest">
        <soap:header message="tns:GetBlobEntityOnProductRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBlobEntityOnProductRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBlobEntityOnProductRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBlobEntityOnProductResponse">
        <soap:header message="tns:GetBlobEntityOnProductResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBlobEntityOnProductResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBlobEntityOnProductResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBlobEntityOnProductResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChangePersonImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/ChangePersonImage" style="document" />
      <wsdl:input name="ChangePersonImageRequest">
        <soap:header message="tns:ChangePersonImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChangePersonImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChangePersonImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChangePersonImageResponse">
        <soap:header message="tns:ChangePersonImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChangePersonImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChangePersonImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChangePersonImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveImageStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SaveImageStream" style="document" />
      <wsdl:input name="SaveImageStreamRequest">
        <soap:header message="tns:SaveImageStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveImageStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveImageStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveImageStreamResponse">
        <soap:header message="tns:SaveImageStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveImageStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveImageStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveImageStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProductImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetProductImage" style="document" />
      <wsdl:input name="GetProductImageRequest">
        <soap:header message="tns:GetProductImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProductImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProductImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProductImageResponse">
        <soap:header message="tns:GetProductImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProductImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProductImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProductImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetProductImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetProductImage" style="document" />
      <wsdl:input name="SetProductImageRequest">
        <soap:header message="tns:SetProductImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetProductImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetProductImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetProductImageResponse">
        <soap:header message="tns:SetProductImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetProductImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetProductImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetProductImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProductThumbnail">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetProductThumbnail" style="document" />
      <wsdl:input name="GetProductThumbnailRequest">
        <soap:header message="tns:GetProductThumbnailRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProductThumbnailRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProductThumbnailRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProductThumbnailResponse">
        <soap:header message="tns:GetProductThumbnailResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProductThumbnailResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProductThumbnailResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProductThumbnailResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetProductThumbnail">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetProductThumbnail" style="document" />
      <wsdl:input name="SetProductThumbnailRequest">
        <soap:header message="tns:SetProductThumbnailRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetProductThumbnailRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetProductThumbnailRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetProductThumbnailResponse">
        <soap:header message="tns:SetProductThumbnailResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetProductThumbnailResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetProductThumbnailResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetProductThumbnailResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChangeProductImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/ChangeProductImage" style="document" />
      <wsdl:input name="ChangeProductImageRequest">
        <soap:header message="tns:ChangeProductImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChangeProductImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChangeProductImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChangeProductImageResponse">
        <soap:header message="tns:ChangeProductImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChangeProductImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChangeProductImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChangeProductImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuoteLineImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetQuoteLineImage" style="document" />
      <wsdl:input name="GetQuoteLineImageRequest">
        <soap:header message="tns:GetQuoteLineImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteLineImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteLineImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteLineImageResponse">
        <soap:header message="tns:GetQuoteLineImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteLineImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteLineImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteLineImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAppData">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetAppData" style="document" />
      <wsdl:input name="GetAppDataRequest">
        <soap:header message="tns:GetAppDataRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAppDataRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAppDataRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAppDataResponse">
        <soap:header message="tns:GetAppDataResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAppDataResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAppDataResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAppDataResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetAppData">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetAppData" style="document" />
      <wsdl:input name="SetAppDataRequest">
        <soap:header message="tns:SetAppDataRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetAppDataRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetAppDataRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetAppDataResponse">
        <soap:header message="tns:SetAppDataResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetAppDataResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetAppDataResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetAppDataResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonImageWithSize">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetPersonImageWithSize" style="document" />
      <wsdl:input name="GetPersonImageWithSizeRequest">
        <soap:header message="tns:GetPersonImageWithSizeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonImageWithSizeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonImageWithSizeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonImageWithSizeResponse">
        <soap:header message="tns:GetPersonImageWithSizeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonImageWithSizeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonImageWithSizeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonImageWithSizeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectImageWithSize">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetProjectImageWithSize" style="document" />
      <wsdl:input name="GetProjectImageWithSizeRequest">
        <soap:header message="tns:GetProjectImageWithSizeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectImageWithSizeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectImageWithSizeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectImageWithSizeResponse">
        <soap:header message="tns:GetProjectImageWithSizeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectImageWithSizeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectImageWithSizeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectImageWithSizeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetChatImageWithSize">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetChatImageWithSize" style="document" />
      <wsdl:input name="GetChatImageWithSizeRequest">
        <soap:header message="tns:GetChatImageWithSizeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetChatImageWithSizeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetChatImageWithSizeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetChatImageWithSizeResponse">
        <soap:header message="tns:GetChatImageWithSizeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetChatImageWithSizeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetChatImageWithSizeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetChatImageWithSizeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetContactImage" style="document" />
      <wsdl:input name="GetContactImageRequest">
        <soap:header message="tns:GetContactImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactImageResponse">
        <soap:header message="tns:GetContactImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetContactImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/SetContactImage" style="document" />
      <wsdl:input name="SetContactImageRequest">
        <soap:header message="tns:SetContactImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetContactImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetContactImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetContactImageResponse">
        <soap:header message="tns:SetContactImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetContactImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetContactImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetContactImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChangeContactImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/ChangeContactImage" style="document" />
      <wsdl:input name="ChangeContactImageRequest">
        <soap:header message="tns:ChangeContactImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChangeContactImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChangeContactImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChangeContactImageResponse">
        <soap:header message="tns:ChangeContactImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChangeContactImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChangeContactImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChangeContactImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBlobEntityOnContact">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetBlobEntityOnContact" style="document" />
      <wsdl:input name="GetBlobEntityOnContactRequest">
        <soap:header message="tns:GetBlobEntityOnContactRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBlobEntityOnContactRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBlobEntityOnContactRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBlobEntityOnContactResponse">
        <soap:header message="tns:GetBlobEntityOnContactResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBlobEntityOnContactResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBlobEntityOnContactResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBlobEntityOnContactResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactImageWithSize">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetContactImageWithSize" style="document" />
      <wsdl:input name="GetContactImageWithSizeRequest">
        <soap:header message="tns:GetContactImageWithSizeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactImageWithSizeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactImageWithSizeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactImageWithSizeResponse">
        <soap:header message="tns:GetContactImageWithSizeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactImageWithSizeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactImageWithSizeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactImageWithSizeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetOutputFromBatch">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/GetOutputFromBatch" style="document" />
      <wsdl:input name="GetOutputFromBatchRequest">
        <soap:header message="tns:GetOutputFromBatchRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetOutputFromBatchRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetOutputFromBatchRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetOutputFromBatchResponse">
        <soap:header message="tns:GetOutputFromBatchResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetOutputFromBatchResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetOutputFromBatchResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetOutputFromBatchResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CleanupBatchTask">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/BLOB/CleanupBatchTask" style="document" />
      <wsdl:input name="CleanupBatchTaskRequest">
        <soap:header message="tns:CleanupBatchTaskRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CleanupBatchTaskRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CleanupBatchTaskRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CleanupBatchTaskResponse">
        <soap:header message="tns:CleanupBatchTaskResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CleanupBatchTaskResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CleanupBatchTaskResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CleanupBatchTaskResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfBLOBService">
    <wsdl:port name="BasicHttpBinding_BLOB" binding="tns:BasicHttpBinding_BLOB">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/BLOB.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

