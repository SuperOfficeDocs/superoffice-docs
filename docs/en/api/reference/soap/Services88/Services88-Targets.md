---
generated: true
uid: wsdl-Services88-Targets
title: Services88.TargetsAgent WSDL
content_type: reference
---

# Services88.TargetsAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfTargetsService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:element name="CreateDefaultTargetAssignment">
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
      <xs:element name="CreateDefaultTargetAssignmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TargetAssignment" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="TargetAssignment">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="TargetAssignmentInfoId" type="xs:int" />
              <xs:element minOccurs="0" name="Values" nillable="true" type="q1:ArrayOfdouble" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="Locked" type="xs:boolean" />
              <xs:element minOccurs="0" name="TargetAssociate" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="TargetContact" nillable="true" type="tns:Contact" />
              <xs:element minOccurs="0" name="TargetUserGroup" nillable="true" type="tns:UserGroup" />
              <xs:element minOccurs="0" name="Currency" nillable="true" type="tns:Currency" />
              <xs:element minOccurs="0" name="DimensionListItem" type="xs:int" />
              <xs:element minOccurs="0" name="DimensionListItemDisplayName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TargetAssignment" nillable="true" type="tns:TargetAssignment" />
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
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="tns:StringDictionary" />
              <xs:element minOccurs="0" name="CustomFields" nillable="true" type="tns:StringDictionary" />
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
      <xs:complexType name="Contact">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
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
              <xs:element minOccurs="0" name="Address" nillable="true" type="tns:Address" />
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
      <xs:element name="Contact" nillable="true" type="tns:Contact" />
      <xs:complexType name="Address">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Wgs84Latitude" type="xs:double" />
              <xs:element minOccurs="0" name="Wgs84Longitude" type="xs:double" />
              <xs:element minOccurs="0" name="LocalizedAddress" nillable="true" type="tns:ArrayOfArrayOfLocalizedField" />
              <xs:element minOccurs="0" name="Street" nillable="true" type="tns:StructuredAddress" />
              <xs:element minOccurs="0" name="Postal" nillable="true" type="tns:StructuredAddress" />
              <xs:element minOccurs="0" name="Formatted" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Address" nillable="true" type="tns:Address" />
      <xs:complexType name="ArrayOfArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArrayOfLocalizedField" nillable="true" type="tns:ArrayOfLocalizedField" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArrayOfLocalizedField" nillable="true" type="tns:ArrayOfArrayOfLocalizedField" />
      <xs:complexType name="ArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="LocalizedField" nillable="true" type="tns:LocalizedField" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLocalizedField" nillable="true" type="tns:ArrayOfLocalizedField" />
      <xs:complexType name="LocalizedField">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
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
      <xs:element name="LocalizedField" nillable="true" type="tns:LocalizedField" />
      <xs:complexType name="StructuredAddress">
        <xs:sequence>
          <xs:element minOccurs="0" name="AtypeIdx" type="tns:AddressType" />
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
      <xs:element name="StructuredAddress" nillable="true" type="tns:StructuredAddress" />
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
      <xs:element name="AddressType" nillable="true" type="tns:AddressType" />
      <xs:complexType name="UserGroup">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="UserGroup" nillable="true" type="tns:UserGroup" />
      <xs:complexType name="Currency">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Currency" nillable="true" type="tns:Currency" />
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
      <xs:element name="CreateDefaultTargetDimension">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTargetDimensionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TargetDimension" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="TargetDimension">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="TargetDimensionId" type="xs:int" />
              <xs:element minOccurs="0" name="AssignmentLevel" type="tns:TargetAssignementLevel" />
              <xs:element minOccurs="0" name="EntityType" type="tns:TargetEntityType" />
              <xs:element minOccurs="0" name="MeasurementUnit" type="tns:TargetMeasurementUnit" />
              <xs:element minOccurs="0" name="DimensionListField" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DimensionListName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DimensionListId" type="xs:int" />
              <xs:element minOccurs="0" name="DimensionListLabel" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SelectedDimensions" nillable="true" type="q2:ArrayOfint" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TargetDimension" nillable="true" type="tns:TargetDimension" />
      <xs:simpleType name="TargetAssignementLevel">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="Company" />
              <xs:enumeration value="Group" />
              <xs:enumeration value="Associate" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="TargetAssignementLevel" nillable="true" type="tns:TargetAssignementLevel" />
      <xs:simpleType name="TargetEntityType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Sale" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TargetEntityType" nillable="true" type="tns:TargetEntityType" />
      <xs:simpleType name="TargetMeasurementUnit">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Amount" />
          <xs:enumeration value="Count" />
          <xs:enumeration value="Profit" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TargetMeasurementUnit" nillable="true" type="tns:TargetMeasurementUnit" />
      <xs:element name="SaveTargetDimension">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TargetDimension" nillable="true" type="tns:TargetDimension" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTargetDimensionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TargetDimension" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteTargetDimension">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TargetDimensionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteTargetDimensionResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTargetGroup">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTargetGroupResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TargetGroup" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="TargetGroup">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="TargetGroupId" type="xs:int" />
              <xs:element minOccurs="0" name="Year" type="xs:int" />
              <xs:element minOccurs="0" name="EntityType" type="tns:TargetEntityType" />
              <xs:element minOccurs="0" name="PeriodType" type="tns:TargetPeriodType" />
              <xs:element minOccurs="0" name="TargetAssignments" nillable="true" type="tns:ArrayOfTargetAssignment" />
              <xs:element minOccurs="0" name="TargetDimension" nillable="true" type="tns:TargetDimension" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TargetGroup" nillable="true" type="tns:TargetGroup" />
      <xs:simpleType name="TargetPeriodType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Year" />
          <xs:enumeration value="HalfYear" />
          <xs:enumeration value="Quarter" />
          <xs:enumeration value="Month" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TargetPeriodType" nillable="true" type="tns:TargetPeriodType" />
      <xs:complexType name="ArrayOfTargetAssignment">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TargetAssignment" nillable="true" type="tns:TargetAssignment" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTargetAssignment" nillable="true" type="tns:ArrayOfTargetAssignment" />
      <xs:element name="SaveTargetGroup">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TargetGroup" nillable="true" type="tns:TargetGroup" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTargetGroupResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TargetGroup" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteTargetGroup">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TargetGroupId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteTargetGroupResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTargetRevision">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTargetRevisionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TargetRevision" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="TargetRevision">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="LogEvent" type="tns:LogEvent" />
              <xs:element minOccurs="0" name="Who" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="When" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Changes" nillable="true" type="tns:ArrayOfTargetChange" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TargetRevision" nillable="true" type="tns:TargetRevision" />
      <xs:simpleType name="LogEvent">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Create" />
          <xs:enumeration value="Edit" />
          <xs:enumeration value="Delete" />
          <xs:enumeration value="Lock" />
          <xs:enumeration value="Unlock" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="LogEvent" nillable="true" type="tns:LogEvent" />
      <xs:complexType name="ArrayOfTargetChange">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TargetChange" nillable="true" type="tns:TargetChange" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTargetChange" nillable="true" type="tns:ArrayOfTargetChange" />
      <xs:complexType name="TargetChange">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="FieldIdentifier" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ValueChangeFrom" type="xs:double" />
              <xs:element minOccurs="0" name="ValueChangeTo" type="xs:double" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TargetChange" nillable="true" type="tns:TargetChange" />
      <xs:element name="CreateDefaultTargetRevisionHistory">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTargetRevisionHistoryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TargetRevisionHistory" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="TargetRevisionHistory">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="TargetGroupId" type="xs:int" />
              <xs:element minOccurs="0" name="Year" type="xs:int" />
              <xs:element minOccurs="0" name="Revisions" nillable="true" type="tns:ArrayOfTargetRevision" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TargetRevisionHistory" nillable="true" type="tns:TargetRevisionHistory" />
      <xs:complexType name="ArrayOfTargetRevision">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TargetRevision" nillable="true" type="tns:TargetRevision" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTargetRevision" nillable="true" type="tns:ArrayOfTargetRevision" />
      <xs:element name="CreateDefaultTargetAssignmentForCompany">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTargetAssignmentForCompanyResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TargetAssignment" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTargetAssignmentForUserGroup">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserGroupId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTargetAssignmentForUserGroupResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTargetAssignment" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTargetAssignmentForYear">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TargetYear" type="xs:int" />
            <xs:element minOccurs="0" name="EntityType" type="tns:TargetEntityType" />
            <xs:element minOccurs="0" name="TargetLevel" type="tns:TargetLevel" />
            <xs:element minOccurs="0" name="Id" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="TargetLevel">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Global" />
          <xs:enumeration value="Company" />
          <xs:enumeration value="UserGroup" />
          <xs:enumeration value="Associate" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TargetLevel" nillable="true" type="tns:TargetLevel" />
      <xs:element name="GetTargetAssignmentForYearResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TargetAssignment" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTargetAssignmentForCompanyWithDimension">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TargetDimensionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTargetAssignmentForCompanyWithDimensionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTargetAssignment" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTargetAssignmentForUserGroupWithDimension">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserGroupId" type="xs:int" />
            <xs:element minOccurs="0" name="TargetDimensionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTargetAssignmentForUserGroupWithDimensionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTargetAssignment" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTargetAssignmentForYearAndDimension">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TargetYear" type="xs:int" />
            <xs:element minOccurs="0" name="EntityType" type="tns:TargetEntityType" />
            <xs:element minOccurs="0" name="TargetLevel" type="tns:TargetLevel" />
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="DimensionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTargetAssignmentForYearAndDimensionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TargetAssignment" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTargetAssignmentForCompanyWithYearAndDimension">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Year" type="xs:int" />
            <xs:element minOccurs="0" name="TargetDimensionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTargetAssignment" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTargetAssignmentForUserGroupWithYearAndDimension">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserGroupId" type="xs:int" />
            <xs:element minOccurs="0" name="Year" type="xs:int" />
            <xs:element minOccurs="0" name="TargetDimensionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTargetAssignment" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTargetDimension">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TargetDimensionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTargetDimensionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TargetDimension" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTargetDimensionsForEntityType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EntityType" type="tns:TargetEntityType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTargetDimensionsForEntityTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfTargetDimension" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfTargetDimension">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TargetDimension" nillable="true" type="tns:TargetDimension" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTargetDimension" nillable="true" type="tns:ArrayOfTargetDimension" />
      <xs:element name="GetTargetGroupIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TargetDimensionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTargetGroupIdsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q3:ArrayOfint" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTargetGroup">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TargetGroupId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTargetGroupResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TargetGroup" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTargetGroupForYear">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TargetYear" type="xs:int" />
            <xs:element minOccurs="0" name="EntityType" type="tns:TargetEntityType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTargetGroupForYearResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TargetGroup" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExportTargetGroupToExcel">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TargetGroupId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExportTargetGroupToExcelResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ExportArchiveResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ExportArchiveResult">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="BatchTaskId" type="xs:int" />
              <xs:element minOccurs="0" name="FileName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ExportArchiveResult" nillable="true" type="tns:ExportArchiveResult" />
      <xs:element name="GetTargetGroupForYearAndDimension">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TargetYear" type="xs:int" />
            <xs:element minOccurs="0" name="DimensionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTargetGroupForYearAndDimensionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TargetGroup" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTargetRevisionHistory">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TargetAssignmentInfoId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTargetRevisionHistoryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:TargetRevisionHistory" />
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
      <xs:complexType name="ArrayOfdouble">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="double" type="xs:double" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfdouble" nillable="true" type="tns:ArrayOfdouble" />
      <xs:complexType name="ArrayOfint">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="int" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfint" nillable="true" type="tns:ArrayOfint" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="CreateDefaultTargetAssignmentRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetAssignment" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetAssignmentResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetDimensionRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetDimension" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetDimensionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetDimensionResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetDimensionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetDimensionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTargetDimensionRequest">
    <wsdl:part name="parameters" element="tns:SaveTargetDimension" />
  </wsdl:message>
  <wsdl:message name="SaveTargetDimensionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTargetDimensionResponse">
    <wsdl:part name="parameters" element="tns:SaveTargetDimensionResponse" />
  </wsdl:message>
  <wsdl:message name="SaveTargetDimensionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteTargetDimensionRequest">
    <wsdl:part name="parameters" element="tns:DeleteTargetDimension" />
  </wsdl:message>
  <wsdl:message name="DeleteTargetDimensionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteTargetDimensionResponse">
    <wsdl:part name="parameters" element="tns:DeleteTargetDimensionResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteTargetDimensionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetGroupRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetGroup" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetGroupRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetGroupResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetGroupResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetGroupResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTargetGroupRequest">
    <wsdl:part name="parameters" element="tns:SaveTargetGroup" />
  </wsdl:message>
  <wsdl:message name="SaveTargetGroupRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTargetGroupResponse">
    <wsdl:part name="parameters" element="tns:SaveTargetGroupResponse" />
  </wsdl:message>
  <wsdl:message name="SaveTargetGroupResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteTargetGroupRequest">
    <wsdl:part name="parameters" element="tns:DeleteTargetGroup" />
  </wsdl:message>
  <wsdl:message name="DeleteTargetGroupRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteTargetGroupResponse">
    <wsdl:part name="parameters" element="tns:DeleteTargetGroupResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteTargetGroupResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetRevisionRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetRevision" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetRevisionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetRevisionResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetRevisionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetRevisionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetRevisionHistoryRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetRevisionHistory" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetRevisionHistoryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetRevisionHistoryResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetRevisionHistoryResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetRevisionHistoryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForCompanyRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetAssignmentForCompany" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForCompanyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForCompanyResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetAssignmentForCompanyResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForCompanyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForUserGroupRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetAssignmentForUserGroup" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForUserGroupRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForUserGroupResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetAssignmentForUserGroupResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForUserGroupResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTargetAssignmentForYearRequest">
    <wsdl:part name="parameters" element="tns:GetTargetAssignmentForYear" />
  </wsdl:message>
  <wsdl:message name="GetTargetAssignmentForYearRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTargetAssignmentForYearResponse">
    <wsdl:part name="parameters" element="tns:GetTargetAssignmentForYearResponse" />
  </wsdl:message>
  <wsdl:message name="GetTargetAssignmentForYearResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForCompanyWithDimensionRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetAssignmentForCompanyWithDimension" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForCompanyWithDimensionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForCompanyWithDimensionResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetAssignmentForCompanyWithDimensionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForCompanyWithDimensionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForUserGroupWithDimensionRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetAssignmentForUserGroupWithDimension" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForUserGroupWithDimensionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForUserGroupWithDimensionResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetAssignmentForUserGroupWithDimensionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForUserGroupWithDimensionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTargetAssignmentForYearAndDimensionRequest">
    <wsdl:part name="parameters" element="tns:GetTargetAssignmentForYearAndDimension" />
  </wsdl:message>
  <wsdl:message name="GetTargetAssignmentForYearAndDimensionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTargetAssignmentForYearAndDimensionResponse">
    <wsdl:part name="parameters" element="tns:GetTargetAssignmentForYearAndDimensionResponse" />
  </wsdl:message>
  <wsdl:message name="GetTargetAssignmentForYearAndDimensionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetAssignmentForCompanyWithYearAndDimension" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetAssignmentForUserGroupWithYearAndDimension" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTargetDimensionRequest">
    <wsdl:part name="parameters" element="tns:GetTargetDimension" />
  </wsdl:message>
  <wsdl:message name="GetTargetDimensionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTargetDimensionResponse">
    <wsdl:part name="parameters" element="tns:GetTargetDimensionResponse" />
  </wsdl:message>
  <wsdl:message name="GetTargetDimensionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTargetDimensionsForEntityTypeRequest">
    <wsdl:part name="parameters" element="tns:GetTargetDimensionsForEntityType" />
  </wsdl:message>
  <wsdl:message name="GetTargetDimensionsForEntityTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTargetDimensionsForEntityTypeResponse">
    <wsdl:part name="parameters" element="tns:GetTargetDimensionsForEntityTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetTargetDimensionsForEntityTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTargetGroupIdsRequest">
    <wsdl:part name="parameters" element="tns:GetTargetGroupIds" />
  </wsdl:message>
  <wsdl:message name="GetTargetGroupIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTargetGroupIdsResponse">
    <wsdl:part name="parameters" element="tns:GetTargetGroupIdsResponse" />
  </wsdl:message>
  <wsdl:message name="GetTargetGroupIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTargetGroupRequest">
    <wsdl:part name="parameters" element="tns:GetTargetGroup" />
  </wsdl:message>
  <wsdl:message name="GetTargetGroupRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTargetGroupResponse">
    <wsdl:part name="parameters" element="tns:GetTargetGroupResponse" />
  </wsdl:message>
  <wsdl:message name="GetTargetGroupResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTargetGroupForYearRequest">
    <wsdl:part name="parameters" element="tns:GetTargetGroupForYear" />
  </wsdl:message>
  <wsdl:message name="GetTargetGroupForYearRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTargetGroupForYearResponse">
    <wsdl:part name="parameters" element="tns:GetTargetGroupForYearResponse" />
  </wsdl:message>
  <wsdl:message name="GetTargetGroupForYearResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExportTargetGroupToExcelRequest">
    <wsdl:part name="parameters" element="tns:ExportTargetGroupToExcel" />
  </wsdl:message>
  <wsdl:message name="ExportTargetGroupToExcelRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExportTargetGroupToExcelResponse">
    <wsdl:part name="parameters" element="tns:ExportTargetGroupToExcelResponse" />
  </wsdl:message>
  <wsdl:message name="ExportTargetGroupToExcelResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTargetGroupForYearAndDimensionRequest">
    <wsdl:part name="parameters" element="tns:GetTargetGroupForYearAndDimension" />
  </wsdl:message>
  <wsdl:message name="GetTargetGroupForYearAndDimensionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTargetGroupForYearAndDimensionResponse">
    <wsdl:part name="parameters" element="tns:GetTargetGroupForYearAndDimensionResponse" />
  </wsdl:message>
  <wsdl:message name="GetTargetGroupForYearAndDimensionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTargetRevisionHistoryRequest">
    <wsdl:part name="parameters" element="tns:GetTargetRevisionHistory" />
  </wsdl:message>
  <wsdl:message name="GetTargetRevisionHistoryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTargetRevisionHistoryResponse">
    <wsdl:part name="parameters" element="tns:GetTargetRevisionHistoryResponse" />
  </wsdl:message>
  <wsdl:message name="GetTargetRevisionHistoryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Targets">
    <wsdl:operation name="CreateDefaultTargetAssignment">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignment" name="CreateDefaultTargetAssignmentRequest" message="tns:CreateDefaultTargetAssignmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentResponse" name="CreateDefaultTargetAssignmentResponse" message="tns:CreateDefaultTargetAssignmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetDimension">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetDimension" name="CreateDefaultTargetDimensionRequest" message="tns:CreateDefaultTargetDimensionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetDimensionResponse" name="CreateDefaultTargetDimensionResponse" message="tns:CreateDefaultTargetDimensionResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveTargetDimension">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/SaveTargetDimension" name="SaveTargetDimensionRequest" message="tns:SaveTargetDimensionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/SaveTargetDimensionResponse" name="SaveTargetDimensionResponse" message="tns:SaveTargetDimensionResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteTargetDimension">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/DeleteTargetDimension" name="DeleteTargetDimensionRequest" message="tns:DeleteTargetDimensionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/DeleteTargetDimensionResponse" name="DeleteTargetDimensionResponse" message="tns:DeleteTargetDimensionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetGroup">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetGroup" name="CreateDefaultTargetGroupRequest" message="tns:CreateDefaultTargetGroupRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetGroupResponse" name="CreateDefaultTargetGroupResponse" message="tns:CreateDefaultTargetGroupResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveTargetGroup">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/SaveTargetGroup" name="SaveTargetGroupRequest" message="tns:SaveTargetGroupRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/SaveTargetGroupResponse" name="SaveTargetGroupResponse" message="tns:SaveTargetGroupResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteTargetGroup">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/DeleteTargetGroup" name="DeleteTargetGroupRequest" message="tns:DeleteTargetGroupRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/DeleteTargetGroupResponse" name="DeleteTargetGroupResponse" message="tns:DeleteTargetGroupResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetRevision">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetRevision" name="CreateDefaultTargetRevisionRequest" message="tns:CreateDefaultTargetRevisionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetRevisionResponse" name="CreateDefaultTargetRevisionResponse" message="tns:CreateDefaultTargetRevisionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetRevisionHistory">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetRevisionHistory" name="CreateDefaultTargetRevisionHistoryRequest" message="tns:CreateDefaultTargetRevisionHistoryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetRevisionHistoryResponse" name="CreateDefaultTargetRevisionHistoryResponse" message="tns:CreateDefaultTargetRevisionHistoryResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetAssignmentForCompany">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentForCompany" name="CreateDefaultTargetAssignmentForCompanyRequest" message="tns:CreateDefaultTargetAssignmentForCompanyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentForCompanyResponse" name="CreateDefaultTargetAssignmentForCompanyResponse" message="tns:CreateDefaultTargetAssignmentForCompanyResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetAssignmentForUserGroup">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentForUserGroup" name="CreateDefaultTargetAssignmentForUserGroupRequest" message="tns:CreateDefaultTargetAssignmentForUserGroupRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentForUserGroupResponse" name="CreateDefaultTargetAssignmentForUserGroupResponse" message="tns:CreateDefaultTargetAssignmentForUserGroupResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTargetAssignmentForYear">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetAssignmentForYear" name="GetTargetAssignmentForYearRequest" message="tns:GetTargetAssignmentForYearRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetAssignmentForYearResponse" name="GetTargetAssignmentForYearResponse" message="tns:GetTargetAssignmentForYearResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetAssignmentForCompanyWithDimension">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentForCompanyWithDimension" name="CreateDefaultTargetAssignmentForCompanyWithDimensionRequest" message="tns:CreateDefaultTargetAssignmentForCompanyWithDimensionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentForCompanyWithDimensionResponse" name="CreateDefaultTargetAssignmentForCompanyWithDimensionResponse" message="tns:CreateDefaultTargetAssignmentForCompanyWithDimensionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetAssignmentForUserGroupWithDimension">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentForUserGroupWithDimension" name="CreateDefaultTargetAssignmentForUserGroupWithDimensionRequest" message="tns:CreateDefaultTargetAssignmentForUserGroupWithDimensionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentForUserGroupWithDimensionResponse" name="CreateDefaultTargetAssignmentForUserGroupWithDimensionResponse" message="tns:CreateDefaultTargetAssignmentForUserGroupWithDimensionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTargetAssignmentForYearAndDimension">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetAssignmentForYearAndDimension" name="GetTargetAssignmentForYearAndDimensionRequest" message="tns:GetTargetAssignmentForYearAndDimensionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetAssignmentForYearAndDimensionResponse" name="GetTargetAssignmentForYearAndDimensionResponse" message="tns:GetTargetAssignmentForYearAndDimensionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetAssignmentForCompanyWithYearAndDimension">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentForCompanyWithYearAndDimension" name="CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionRequest" message="tns:CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionResponse" name="CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionResponse" message="tns:CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetAssignmentForUserGroupWithYearAndDimension">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentForUserGroupWithYearAndDimension" name="CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionRequest" message="tns:CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionResponse" name="CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionResponse" message="tns:CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTargetDimension">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetDimension" name="GetTargetDimensionRequest" message="tns:GetTargetDimensionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetDimensionResponse" name="GetTargetDimensionResponse" message="tns:GetTargetDimensionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTargetDimensionsForEntityType">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetDimensionsForEntityType" name="GetTargetDimensionsForEntityTypeRequest" message="tns:GetTargetDimensionsForEntityTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetDimensionsForEntityTypeResponse" name="GetTargetDimensionsForEntityTypeResponse" message="tns:GetTargetDimensionsForEntityTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTargetGroupIds">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetGroupIds" name="GetTargetGroupIdsRequest" message="tns:GetTargetGroupIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetGroupIdsResponse" name="GetTargetGroupIdsResponse" message="tns:GetTargetGroupIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTargetGroup">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetGroup" name="GetTargetGroupRequest" message="tns:GetTargetGroupRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetGroupResponse" name="GetTargetGroupResponse" message="tns:GetTargetGroupResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTargetGroupForYear">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetGroupForYear" name="GetTargetGroupForYearRequest" message="tns:GetTargetGroupForYearRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetGroupForYearResponse" name="GetTargetGroupForYearResponse" message="tns:GetTargetGroupForYearResponse" />
    </wsdl:operation>
    <wsdl:operation name="ExportTargetGroupToExcel">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/ExportTargetGroupToExcel" name="ExportTargetGroupToExcelRequest" message="tns:ExportTargetGroupToExcelRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/ExportTargetGroupToExcelResponse" name="ExportTargetGroupToExcelResponse" message="tns:ExportTargetGroupToExcelResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTargetGroupForYearAndDimension">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetGroupForYearAndDimension" name="GetTargetGroupForYearAndDimensionRequest" message="tns:GetTargetGroupForYearAndDimensionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetGroupForYearAndDimensionResponse" name="GetTargetGroupForYearAndDimensionResponse" message="tns:GetTargetGroupForYearAndDimensionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTargetRevisionHistory">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetRevisionHistory" name="GetTargetRevisionHistoryRequest" message="tns:GetTargetRevisionHistoryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetRevisionHistoryResponse" name="GetTargetRevisionHistoryResponse" message="tns:GetTargetRevisionHistoryResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Targets" type="tns:Targets">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultTargetAssignment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignment" style="document" />
      <wsdl:input name="CreateDefaultTargetAssignmentRequest">
        <soap:header message="tns:CreateDefaultTargetAssignmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTargetAssignmentResponse">
        <soap:header message="tns:CreateDefaultTargetAssignmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetDimension">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetDimension" style="document" />
      <wsdl:input name="CreateDefaultTargetDimensionRequest">
        <soap:header message="tns:CreateDefaultTargetDimensionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTargetDimensionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTargetDimensionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTargetDimensionResponse">
        <soap:header message="tns:CreateDefaultTargetDimensionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetDimensionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetDimensionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTargetDimensionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveTargetDimension">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/SaveTargetDimension" style="document" />
      <wsdl:input name="SaveTargetDimensionRequest">
        <soap:header message="tns:SaveTargetDimensionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveTargetDimensionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveTargetDimensionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveTargetDimensionResponse">
        <soap:header message="tns:SaveTargetDimensionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveTargetDimensionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveTargetDimensionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveTargetDimensionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteTargetDimension">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/DeleteTargetDimension" style="document" />
      <wsdl:input name="DeleteTargetDimensionRequest">
        <soap:header message="tns:DeleteTargetDimensionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteTargetDimensionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteTargetDimensionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteTargetDimensionResponse">
        <soap:header message="tns:DeleteTargetDimensionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteTargetDimensionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteTargetDimensionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteTargetDimensionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetGroup">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetGroup" style="document" />
      <wsdl:input name="CreateDefaultTargetGroupRequest">
        <soap:header message="tns:CreateDefaultTargetGroupRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTargetGroupRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTargetGroupRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTargetGroupResponse">
        <soap:header message="tns:CreateDefaultTargetGroupResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetGroupResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetGroupResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTargetGroupResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveTargetGroup">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/SaveTargetGroup" style="document" />
      <wsdl:input name="SaveTargetGroupRequest">
        <soap:header message="tns:SaveTargetGroupRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveTargetGroupRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveTargetGroupRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveTargetGroupResponse">
        <soap:header message="tns:SaveTargetGroupResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveTargetGroupResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveTargetGroupResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveTargetGroupResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteTargetGroup">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/DeleteTargetGroup" style="document" />
      <wsdl:input name="DeleteTargetGroupRequest">
        <soap:header message="tns:DeleteTargetGroupRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteTargetGroupRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteTargetGroupRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteTargetGroupResponse">
        <soap:header message="tns:DeleteTargetGroupResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteTargetGroupResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteTargetGroupResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteTargetGroupResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetRevision">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetRevision" style="document" />
      <wsdl:input name="CreateDefaultTargetRevisionRequest">
        <soap:header message="tns:CreateDefaultTargetRevisionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTargetRevisionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTargetRevisionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTargetRevisionResponse">
        <soap:header message="tns:CreateDefaultTargetRevisionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetRevisionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetRevisionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTargetRevisionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetRevisionHistory">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetRevisionHistory" style="document" />
      <wsdl:input name="CreateDefaultTargetRevisionHistoryRequest">
        <soap:header message="tns:CreateDefaultTargetRevisionHistoryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTargetRevisionHistoryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTargetRevisionHistoryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTargetRevisionHistoryResponse">
        <soap:header message="tns:CreateDefaultTargetRevisionHistoryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetRevisionHistoryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetRevisionHistoryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTargetRevisionHistoryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetAssignmentForCompany">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentForCompany" style="document" />
      <wsdl:input name="CreateDefaultTargetAssignmentForCompanyRequest">
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTargetAssignmentForCompanyResponse">
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetAssignmentForUserGroup">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentForUserGroup" style="document" />
      <wsdl:input name="CreateDefaultTargetAssignmentForUserGroupRequest">
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTargetAssignmentForUserGroupResponse">
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTargetAssignmentForYear">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetAssignmentForYear" style="document" />
      <wsdl:input name="GetTargetAssignmentForYearRequest">
        <soap:header message="tns:GetTargetAssignmentForYearRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTargetAssignmentForYearRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTargetAssignmentForYearRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTargetAssignmentForYearResponse">
        <soap:header message="tns:GetTargetAssignmentForYearResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTargetAssignmentForYearResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTargetAssignmentForYearResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTargetAssignmentForYearResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetAssignmentForCompanyWithDimension">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentForCompanyWithDimension" style="document" />
      <wsdl:input name="CreateDefaultTargetAssignmentForCompanyWithDimensionRequest">
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyWithDimensionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyWithDimensionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyWithDimensionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTargetAssignmentForCompanyWithDimensionResponse">
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyWithDimensionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyWithDimensionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyWithDimensionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyWithDimensionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetAssignmentForUserGroupWithDimension">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentForUserGroupWithDimension" style="document" />
      <wsdl:input name="CreateDefaultTargetAssignmentForUserGroupWithDimensionRequest">
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupWithDimensionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupWithDimensionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupWithDimensionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTargetAssignmentForUserGroupWithDimensionResponse">
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupWithDimensionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupWithDimensionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupWithDimensionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupWithDimensionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTargetAssignmentForYearAndDimension">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetAssignmentForYearAndDimension" style="document" />
      <wsdl:input name="GetTargetAssignmentForYearAndDimensionRequest">
        <soap:header message="tns:GetTargetAssignmentForYearAndDimensionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTargetAssignmentForYearAndDimensionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTargetAssignmentForYearAndDimensionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTargetAssignmentForYearAndDimensionResponse">
        <soap:header message="tns:GetTargetAssignmentForYearAndDimensionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTargetAssignmentForYearAndDimensionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTargetAssignmentForYearAndDimensionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTargetAssignmentForYearAndDimensionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetAssignmentForCompanyWithYearAndDimension">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentForCompanyWithYearAndDimension" style="document" />
      <wsdl:input name="CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionRequest">
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionResponse">
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTargetAssignmentForUserGroupWithYearAndDimension">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/CreateDefaultTargetAssignmentForUserGroupWithYearAndDimension" style="document" />
      <wsdl:input name="CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionRequest">
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionResponse">
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTargetAssignmentForUserGroupWithYearAndDimensionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTargetDimension">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetDimension" style="document" />
      <wsdl:input name="GetTargetDimensionRequest">
        <soap:header message="tns:GetTargetDimensionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTargetDimensionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTargetDimensionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTargetDimensionResponse">
        <soap:header message="tns:GetTargetDimensionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTargetDimensionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTargetDimensionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTargetDimensionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTargetDimensionsForEntityType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetDimensionsForEntityType" style="document" />
      <wsdl:input name="GetTargetDimensionsForEntityTypeRequest">
        <soap:header message="tns:GetTargetDimensionsForEntityTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTargetDimensionsForEntityTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTargetDimensionsForEntityTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTargetDimensionsForEntityTypeResponse">
        <soap:header message="tns:GetTargetDimensionsForEntityTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTargetDimensionsForEntityTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTargetDimensionsForEntityTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTargetDimensionsForEntityTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTargetGroupIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetGroupIds" style="document" />
      <wsdl:input name="GetTargetGroupIdsRequest">
        <soap:header message="tns:GetTargetGroupIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTargetGroupIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTargetGroupIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTargetGroupIdsResponse">
        <soap:header message="tns:GetTargetGroupIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTargetGroupIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTargetGroupIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTargetGroupIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTargetGroup">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetGroup" style="document" />
      <wsdl:input name="GetTargetGroupRequest">
        <soap:header message="tns:GetTargetGroupRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTargetGroupRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTargetGroupRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTargetGroupResponse">
        <soap:header message="tns:GetTargetGroupResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTargetGroupResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTargetGroupResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTargetGroupResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTargetGroupForYear">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetGroupForYear" style="document" />
      <wsdl:input name="GetTargetGroupForYearRequest">
        <soap:header message="tns:GetTargetGroupForYearRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTargetGroupForYearRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTargetGroupForYearRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTargetGroupForYearResponse">
        <soap:header message="tns:GetTargetGroupForYearResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTargetGroupForYearResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTargetGroupForYearResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTargetGroupForYearResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ExportTargetGroupToExcel">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/ExportTargetGroupToExcel" style="document" />
      <wsdl:input name="ExportTargetGroupToExcelRequest">
        <soap:header message="tns:ExportTargetGroupToExcelRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ExportTargetGroupToExcelRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ExportTargetGroupToExcelRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ExportTargetGroupToExcelResponse">
        <soap:header message="tns:ExportTargetGroupToExcelResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ExportTargetGroupToExcelResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ExportTargetGroupToExcelResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ExportTargetGroupToExcelResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTargetGroupForYearAndDimension">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetGroupForYearAndDimension" style="document" />
      <wsdl:input name="GetTargetGroupForYearAndDimensionRequest">
        <soap:header message="tns:GetTargetGroupForYearAndDimensionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTargetGroupForYearAndDimensionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTargetGroupForYearAndDimensionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTargetGroupForYearAndDimensionResponse">
        <soap:header message="tns:GetTargetGroupForYearAndDimensionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTargetGroupForYearAndDimensionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTargetGroupForYearAndDimensionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTargetGroupForYearAndDimensionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTargetRevisionHistory">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Targets/GetTargetRevisionHistory" style="document" />
      <wsdl:input name="GetTargetRevisionHistoryRequest">
        <soap:header message="tns:GetTargetRevisionHistoryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTargetRevisionHistoryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTargetRevisionHistoryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTargetRevisionHistoryResponse">
        <soap:header message="tns:GetTargetRevisionHistoryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTargetRevisionHistoryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTargetRevisionHistoryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTargetRevisionHistoryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfTargetsService">
    <wsdl:port name="BasicHttpBinding_Targets" binding="tns:BasicHttpBinding_Targets">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/Targets.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

