---
Generated: 1
TOCExclude: 1
title: Services75.UserDefinedFieldInfoAgent WSDL
---

# Services75.UserDefinedFieldInfoAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfUserDefinedFieldInfoService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services75" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services75" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services75" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultUserDefinedFieldInfo">
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
      <xs:element name="CreateDefaultUserDefinedFieldInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:UserDefinedFieldInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="UserDefinedFieldInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="UDefFieldId" type="xs:int" />
              <xs:element minOccurs="0" name="ColumnId" type="xs:int" />
              <xs:element minOccurs="0" name="FieldDefault" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FieldHeight" type="xs:short" />
              <xs:element minOccurs="0" name="FieldLabel" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FieldLeft" type="xs:short" />
              <xs:element minOccurs="0" name="FieldTop" type="xs:short" />
              <xs:element minOccurs="0" name="FieldType" type="tns:UDefFieldType" />
              <xs:element minOccurs="0" name="FieldWidth" type="xs:short" />
              <xs:element minOccurs="0" name="FormatMask" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="HideLabel" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsIndexed" type="xs:boolean" />
              <xs:element minOccurs="0" name="LabelHeight" type="xs:short" />
              <xs:element minOccurs="0" name="LabelLeft" type="xs:short" />
              <xs:element minOccurs="0" name="LabelTop" type="xs:short" />
              <xs:element minOccurs="0" name="LabelWidth" type="xs:short" />
              <xs:element minOccurs="0" name="LastVersionId" type="xs:int" />
              <xs:element minOccurs="0" name="ListTableId" type="xs:short" />
              <xs:element minOccurs="0" name="IsMandatory" type="xs:boolean" />
              <xs:element minOccurs="0" name="Type" type="tns:UDefType" />
              <xs:element minOccurs="0" name="Page1LineNo" type="xs:short" />
              <xs:element minOccurs="0" name="ProgId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsReadOnly" type="xs:boolean" />
              <xs:element minOccurs="0" name="ShortLabel" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TabOrder" type="xs:short" />
              <xs:element minOccurs="0" name="TextLength" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UdefIdentity" type="xs:int" />
              <xs:element minOccurs="0" name="UDListDefinitionId" type="xs:int" />
              <xs:element minOccurs="0" name="Justification" type="tns:UdefJustification" />
              <xs:element minOccurs="0" name="Version" type="xs:short" />
              <xs:element minOccurs="0" name="TemplateVariableName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="HasBeenPublished" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="UserDefinedFieldInfo" nillable="true" type="tns:UserDefinedFieldInfo" />
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
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="EFieldRight" nillable="true" type="tns:EFieldRight" />
      <xs:simpleType name="UDefFieldType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Number">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ShortText">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">2</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="LongText">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">3</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Date">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">4</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="UnlimitedDate">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">5</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Checkbox">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">6</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="List">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">7</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Decimal">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">8</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="UDefFieldType" nillable="true" type="tns:UDefFieldType" />
      <xs:simpleType name="UDefType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Invalid" />
          <xs:enumeration value="Contact">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">7</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Person">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">8</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Project">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">9</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Sale">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">10</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Temp">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">11</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Appointment">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">12</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Document">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">13</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="None">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">14</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="UDefType" nillable="true" type="tns:UDefType" />
      <xs:simpleType name="UdefJustification">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Default" />
          <xs:enumeration value="Left" />
          <xs:enumeration value="Center" />
          <xs:enumeration value="Right" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="UdefJustification" nillable="true" type="tns:UdefJustification" />
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
      <xs:element name="SaveUserDefinedFieldInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserDefinedFieldInfo" nillable="true" type="tns:UserDefinedFieldInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveUserDefinedFieldInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:UserDefinedFieldInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteUserDefinedFieldInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserDefinedFieldInfoId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteUserDefinedFieldInfoResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserDefinedFieldInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UserDefinedFieldInfoId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserDefinedFieldInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:UserDefinedFieldInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserDefinedFieldList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OwnerType" type="tns:UDefType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserDefinedFieldListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfUserDefinedFieldInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfUserDefinedFieldInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="UserDefinedFieldInfo" nillable="true" type="tns:UserDefinedFieldInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfUserDefinedFieldInfo" nillable="true" type="tns:ArrayOfUserDefinedFieldInfo" />
      <xs:element name="GetUserDefinedFieldFromFieldLabel">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FieldLabel" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="OwnerType" type="tns:UDefType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserDefinedFieldFromFieldLabelResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:UserDefinedFieldInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserDefinedFieldFromProgId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProgId" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="OwnerType" type="tns:UDefType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserDefinedFieldFromProgIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:UserDefinedFieldInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserDefinedFieldFromIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Ids" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserDefinedFieldFromIdsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfUserDefinedFieldInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserDefinedFieldFromProgIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProgIds" nillable="true" type="q2:ArrayOfstring" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="OwnerType" type="tns:UDefType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserDefinedFieldFromProgIdsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfUserDefinedFieldInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateUserDefinedFieldInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OwnerType" type="tns:UDefType" />
            <xs:element minOccurs="0" name="FieldType" type="tns:UDefFieldType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateUserDefinedFieldInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:UserDefinedFieldInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeFieldType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Info" nillable="true" type="tns:UserDefinedFieldInfo" />
            <xs:element minOccurs="0" name="FieldType" type="tns:UDefFieldType" />
            <xs:element minOccurs="0" name="IsIndexed" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeFieldTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:UserDefinedFieldInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserDefinedPageOneFields">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OwnerType" type="tns:UDefType" />
            <xs:element minOccurs="0" name="UserGroupId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUserDefinedPageOneFieldsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfUserDefinedFieldInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Publish">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OwnerType" type="tns:UDefType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="PublishResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="Revert">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OwnerType" type="tns:UDefType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RevertResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveUserDefinedFieldInfos">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Infos" nillable="true" type="tns:ArrayOfUserDefinedFieldInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveUserDefinedFieldInfosResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DetectUnpublishedChanges">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OwnerType" type="tns:UDefType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DetectUnpublishedChangesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DetectColumnIdChanges">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OwnerType" type="tns:UDefType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DetectColumnIdChangesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetUserDefinedPageOneField">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OwnerType" type="tns:UDefType" />
            <xs:element minOccurs="0" name="UdefFieldId" type="xs:int" />
            <xs:element minOccurs="0" name="UserGroupId" type="xs:int" />
            <xs:element minOccurs="0" name="FieldLineNo" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetUserDefinedPageOneFieldResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="IsPublishEventActive">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Type" type="tns:UDefType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="IsPublishEventActiveResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="IsAnyPublishEventActive">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="IsAnyPublishEventActiveResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChangedPageOneFields">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OwnerType" type="tns:UDefType" />
            <xs:element minOccurs="0" name="UserGroupId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChangedPageOneFieldsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q3:ArrayOfboolean" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetPageOneFieldGrouping">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OwnerType" type="tns:UDefType" />
            <xs:element minOccurs="0" name="Active" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetPageOneFieldGroupingResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetListTableIdAndUDListDefinitionIdFromSelectedListId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Info" nillable="true" type="tns:UserDefinedFieldInfo" />
            <xs:element minOccurs="0" name="SelectedListId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetListTableIdAndUDListDefinitionIdFromSelectedListIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:UserDefinedFieldInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FigureOutListIdFromListTableIdAndUDListDefinitionId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Info" nillable="true" type="tns:UserDefinedFieldInfo" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FigureOutListIdFromListTableIdAndUDListDefinitionIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetRankOnFields">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OwnerType" type="tns:UDefType" />
            <xs:element minOccurs="0" name="RankedFieldsIds" nillable="true" type="q4:ArrayOfint" xmlns:q4="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetRankOnFieldsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetPublishStartSystemEvent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OwnerType" type="tns:UDefType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetPublishStartSystemEventResponse">
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
    <xs:schema elementFormDefault="qualified" targetNamespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:tns="http://schemas.microsoft.com/2003/10/Serialization/Arrays">
      <xs:complexType name="ArrayOfint">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="int" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfint" nillable="true" type="tns:ArrayOfint" />
      <xs:complexType name="ArrayOfstring">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="string" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfstring" nillable="true" type="tns:ArrayOfstring" />
      <xs:complexType name="ArrayOfboolean">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="boolean" type="xs:boolean" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfboolean" nillable="true" type="tns:ArrayOfboolean" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="CreateDefaultUserDefinedFieldInfoRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultUserDefinedFieldInfo" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserDefinedFieldInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserDefinedFieldInfoResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultUserDefinedFieldInfoResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultUserDefinedFieldInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveUserDefinedFieldInfoRequest">
    <wsdl:part name="parameters" element="tns:SaveUserDefinedFieldInfo" />
  </wsdl:message>
  <wsdl:message name="SaveUserDefinedFieldInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveUserDefinedFieldInfoResponse">
    <wsdl:part name="parameters" element="tns:SaveUserDefinedFieldInfoResponse" />
  </wsdl:message>
  <wsdl:message name="SaveUserDefinedFieldInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteUserDefinedFieldInfoRequest">
    <wsdl:part name="parameters" element="tns:DeleteUserDefinedFieldInfo" />
  </wsdl:message>
  <wsdl:message name="DeleteUserDefinedFieldInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteUserDefinedFieldInfoResponse">
    <wsdl:part name="parameters" element="tns:DeleteUserDefinedFieldInfoResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteUserDefinedFieldInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldInfoRequest">
    <wsdl:part name="parameters" element="tns:GetUserDefinedFieldInfo" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldInfoResponse">
    <wsdl:part name="parameters" element="tns:GetUserDefinedFieldInfoResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldListRequest">
    <wsdl:part name="parameters" element="tns:GetUserDefinedFieldList" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldListResponse">
    <wsdl:part name="parameters" element="tns:GetUserDefinedFieldListResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldFromFieldLabelRequest">
    <wsdl:part name="parameters" element="tns:GetUserDefinedFieldFromFieldLabel" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldFromFieldLabelRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldFromFieldLabelResponse">
    <wsdl:part name="parameters" element="tns:GetUserDefinedFieldFromFieldLabelResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldFromFieldLabelResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldFromProgIdRequest">
    <wsdl:part name="parameters" element="tns:GetUserDefinedFieldFromProgId" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldFromProgIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldFromProgIdResponse">
    <wsdl:part name="parameters" element="tns:GetUserDefinedFieldFromProgIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldFromProgIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldFromIdsRequest">
    <wsdl:part name="parameters" element="tns:GetUserDefinedFieldFromIds" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldFromIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldFromIdsResponse">
    <wsdl:part name="parameters" element="tns:GetUserDefinedFieldFromIdsResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldFromIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldFromProgIdsRequest">
    <wsdl:part name="parameters" element="tns:GetUserDefinedFieldFromProgIds" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldFromProgIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldFromProgIdsResponse">
    <wsdl:part name="parameters" element="tns:GetUserDefinedFieldFromProgIdsResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedFieldFromProgIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateUserDefinedFieldInfoRequest">
    <wsdl:part name="parameters" element="tns:CreateUserDefinedFieldInfo" />
  </wsdl:message>
  <wsdl:message name="CreateUserDefinedFieldInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateUserDefinedFieldInfoResponse">
    <wsdl:part name="parameters" element="tns:CreateUserDefinedFieldInfoResponse" />
  </wsdl:message>
  <wsdl:message name="CreateUserDefinedFieldInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeFieldTypeRequest">
    <wsdl:part name="parameters" element="tns:ChangeFieldType" />
  </wsdl:message>
  <wsdl:message name="ChangeFieldTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeFieldTypeResponse">
    <wsdl:part name="parameters" element="tns:ChangeFieldTypeResponse" />
  </wsdl:message>
  <wsdl:message name="ChangeFieldTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedPageOneFieldsRequest">
    <wsdl:part name="parameters" element="tns:GetUserDefinedPageOneFields" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedPageOneFieldsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedPageOneFieldsResponse">
    <wsdl:part name="parameters" element="tns:GetUserDefinedPageOneFieldsResponse" />
  </wsdl:message>
  <wsdl:message name="GetUserDefinedPageOneFieldsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PublishRequest">
    <wsdl:part name="parameters" element="tns:Publish" />
  </wsdl:message>
  <wsdl:message name="PublishRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PublishResponse">
    <wsdl:part name="parameters" element="tns:PublishResponse" />
  </wsdl:message>
  <wsdl:message name="PublishResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RevertRequest">
    <wsdl:part name="parameters" element="tns:Revert" />
  </wsdl:message>
  <wsdl:message name="RevertRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RevertResponse">
    <wsdl:part name="parameters" element="tns:RevertResponse" />
  </wsdl:message>
  <wsdl:message name="RevertResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveUserDefinedFieldInfosRequest">
    <wsdl:part name="parameters" element="tns:SaveUserDefinedFieldInfos" />
  </wsdl:message>
  <wsdl:message name="SaveUserDefinedFieldInfosRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveUserDefinedFieldInfosResponse">
    <wsdl:part name="parameters" element="tns:SaveUserDefinedFieldInfosResponse" />
  </wsdl:message>
  <wsdl:message name="SaveUserDefinedFieldInfosResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DetectUnpublishedChangesRequest">
    <wsdl:part name="parameters" element="tns:DetectUnpublishedChanges" />
  </wsdl:message>
  <wsdl:message name="DetectUnpublishedChangesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DetectUnpublishedChangesResponse">
    <wsdl:part name="parameters" element="tns:DetectUnpublishedChangesResponse" />
  </wsdl:message>
  <wsdl:message name="DetectUnpublishedChangesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DetectColumnIdChangesRequest">
    <wsdl:part name="parameters" element="tns:DetectColumnIdChanges" />
  </wsdl:message>
  <wsdl:message name="DetectColumnIdChangesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DetectColumnIdChangesResponse">
    <wsdl:part name="parameters" element="tns:DetectColumnIdChangesResponse" />
  </wsdl:message>
  <wsdl:message name="DetectColumnIdChangesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetUserDefinedPageOneFieldRequest">
    <wsdl:part name="parameters" element="tns:SetUserDefinedPageOneField" />
  </wsdl:message>
  <wsdl:message name="SetUserDefinedPageOneFieldRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetUserDefinedPageOneFieldResponse">
    <wsdl:part name="parameters" element="tns:SetUserDefinedPageOneFieldResponse" />
  </wsdl:message>
  <wsdl:message name="SetUserDefinedPageOneFieldResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsPublishEventActiveRequest">
    <wsdl:part name="parameters" element="tns:IsPublishEventActive" />
  </wsdl:message>
  <wsdl:message name="IsPublishEventActiveRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsPublishEventActiveResponse">
    <wsdl:part name="parameters" element="tns:IsPublishEventActiveResponse" />
  </wsdl:message>
  <wsdl:message name="IsPublishEventActiveResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsAnyPublishEventActiveRequest">
    <wsdl:part name="parameters" element="tns:IsAnyPublishEventActive" />
  </wsdl:message>
  <wsdl:message name="IsAnyPublishEventActiveRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IsAnyPublishEventActiveResponse">
    <wsdl:part name="parameters" element="tns:IsAnyPublishEventActiveResponse" />
  </wsdl:message>
  <wsdl:message name="IsAnyPublishEventActiveResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChangedPageOneFieldsRequest">
    <wsdl:part name="parameters" element="tns:GetChangedPageOneFields" />
  </wsdl:message>
  <wsdl:message name="GetChangedPageOneFieldsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChangedPageOneFieldsResponse">
    <wsdl:part name="parameters" element="tns:GetChangedPageOneFieldsResponse" />
  </wsdl:message>
  <wsdl:message name="GetChangedPageOneFieldsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetPageOneFieldGroupingRequest">
    <wsdl:part name="parameters" element="tns:SetPageOneFieldGrouping" />
  </wsdl:message>
  <wsdl:message name="SetPageOneFieldGroupingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetPageOneFieldGroupingResponse">
    <wsdl:part name="parameters" element="tns:SetPageOneFieldGroupingResponse" />
  </wsdl:message>
  <wsdl:message name="SetPageOneFieldGroupingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetListTableIdAndUDListDefinitionIdFromSelectedListIdRequest">
    <wsdl:part name="parameters" element="tns:SetListTableIdAndUDListDefinitionIdFromSelectedListId" />
  </wsdl:message>
  <wsdl:message name="SetListTableIdAndUDListDefinitionIdFromSelectedListIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetListTableIdAndUDListDefinitionIdFromSelectedListIdResponse">
    <wsdl:part name="parameters" element="tns:SetListTableIdAndUDListDefinitionIdFromSelectedListIdResponse" />
  </wsdl:message>
  <wsdl:message name="SetListTableIdAndUDListDefinitionIdFromSelectedListIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FigureOutListIdFromListTableIdAndUDListDefinitionIdRequest">
    <wsdl:part name="parameters" element="tns:FigureOutListIdFromListTableIdAndUDListDefinitionId" />
  </wsdl:message>
  <wsdl:message name="FigureOutListIdFromListTableIdAndUDListDefinitionIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FigureOutListIdFromListTableIdAndUDListDefinitionIdResponse">
    <wsdl:part name="parameters" element="tns:FigureOutListIdFromListTableIdAndUDListDefinitionIdResponse" />
  </wsdl:message>
  <wsdl:message name="FigureOutListIdFromListTableIdAndUDListDefinitionIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetRankOnFieldsRequest">
    <wsdl:part name="parameters" element="tns:SetRankOnFields" />
  </wsdl:message>
  <wsdl:message name="SetRankOnFieldsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetRankOnFieldsResponse">
    <wsdl:part name="parameters" element="tns:SetRankOnFieldsResponse" />
  </wsdl:message>
  <wsdl:message name="SetRankOnFieldsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetPublishStartSystemEventRequest">
    <wsdl:part name="parameters" element="tns:SetPublishStartSystemEvent" />
  </wsdl:message>
  <wsdl:message name="SetPublishStartSystemEventRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetPublishStartSystemEventResponse">
    <wsdl:part name="parameters" element="tns:SetPublishStartSystemEventResponse" />
  </wsdl:message>
  <wsdl:message name="SetPublishStartSystemEventResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="UserDefinedFieldInfo">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for UserDefinedFieldInfo</summary>
    </wsdl:documentation>
    <wsdl:operation name="CreateDefaultUserDefinedFieldInfo">
      <wsdl:documentation>
        <summary>Loading default values into a new UserDefinedFieldInfo.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/CreateDefaultUserDefinedFieldInfo" name="CreateDefaultUserDefinedFieldInfoRequest" message="tns:CreateDefaultUserDefinedFieldInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/CreateDefaultUserDefinedFieldInfoResponse" name="CreateDefaultUserDefinedFieldInfoResponse" message="tns:CreateDefaultUserDefinedFieldInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveUserDefinedFieldInfo">
      <wsdl:documentation>
        <summary>Updates the existing UserDefinedFieldInfo or creates a new UserDefinedFieldInfo if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SaveUserDefinedFieldInfo" name="SaveUserDefinedFieldInfoRequest" message="tns:SaveUserDefinedFieldInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SaveUserDefinedFieldInfoResponse" name="SaveUserDefinedFieldInfoResponse" message="tns:SaveUserDefinedFieldInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteUserDefinedFieldInfo">
      <wsdl:documentation>
        <summary>Deletes the UserDefinedFieldInfo</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/DeleteUserDefinedFieldInfo" name="DeleteUserDefinedFieldInfoRequest" message="tns:DeleteUserDefinedFieldInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/DeleteUserDefinedFieldInfoResponse" name="DeleteUserDefinedFieldInfoResponse" message="tns:DeleteUserDefinedFieldInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserDefinedFieldInfo">
      <wsdl:documentation>
        <summary>Gets a UserDefinedFieldInfo object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedFieldInfo" name="GetUserDefinedFieldInfoRequest" message="tns:GetUserDefinedFieldInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedFieldInfoResponse" name="GetUserDefinedFieldInfoResponse" message="tns:GetUserDefinedFieldInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserDefinedFieldList">
      <wsdl:documentation>
        <summary>Return information about all the user defined fields on a particular owner type (project, contact, person, etc).</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedFieldList" name="GetUserDefinedFieldListRequest" message="tns:GetUserDefinedFieldListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedFieldListResponse" name="GetUserDefinedFieldListResponse" message="tns:GetUserDefinedFieldListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserDefinedFieldFromFieldLabel">
      <wsdl:documentation>
        <summary>Return information about the given user defined field identified by the owner and the field label. Note that field labels are fuzzy. Leading and trailing spaces and punctuation are ignored.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedFieldFromFieldLabel" name="GetUserDefinedFieldFromFieldLabelRequest" message="tns:GetUserDefinedFieldFromFieldLabelRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedFieldFromFieldLabelResponse" name="GetUserDefinedFieldFromFieldLabelResponse" message="tns:GetUserDefinedFieldFromFieldLabelResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserDefinedFieldFromProgId">
      <wsdl:documentation>
        <summary>Return information about the given user defined field identified by the owner and the prog-id. The prog-id is used as the key in the entity carriers.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedFieldFromProgId" name="GetUserDefinedFieldFromProgIdRequest" message="tns:GetUserDefinedFieldFromProgIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedFieldFromProgIdResponse" name="GetUserDefinedFieldFromProgIdResponse" message="tns:GetUserDefinedFieldFromProgIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserDefinedFieldFromIds">
      <wsdl:documentation>
        <summary>Return an given array of user defined field identified by the ids.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedFieldFromIds" name="GetUserDefinedFieldFromIdsRequest" message="tns:GetUserDefinedFieldFromIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedFieldFromIdsResponse" name="GetUserDefinedFieldFromIdsResponse" message="tns:GetUserDefinedFieldFromIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserDefinedFieldFromProgIds">
      <wsdl:documentation>
        <summary>Return an given array user defined field identified by the owner and the prog-ids. The prog-id is used as the key in the entity carriers.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedFieldFromProgIds" name="GetUserDefinedFieldFromProgIdsRequest" message="tns:GetUserDefinedFieldFromProgIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedFieldFromProgIdsResponse" name="GetUserDefinedFieldFromProgIdsResponse" message="tns:GetUserDefinedFieldFromProgIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateUserDefinedFieldInfo">
      <wsdl:documentation>
        <summary>Create a UserDefinedFieldInfo based on a owner-entity id</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/CreateUserDefinedFieldInfo" name="CreateUserDefinedFieldInfoRequest" message="tns:CreateUserDefinedFieldInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/CreateUserDefinedFieldInfoResponse" name="CreateUserDefinedFieldInfoResponse" message="tns:CreateUserDefinedFieldInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChangeFieldType">
      <wsdl:documentation>
        <summary>Create a UserDefinedFieldInfo based on a owner-entity id</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/ChangeFieldType" name="ChangeFieldTypeRequest" message="tns:ChangeFieldTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/ChangeFieldTypeResponse" name="ChangeFieldTypeResponse" message="tns:ChangeFieldTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUserDefinedPageOneFields">
      <wsdl:documentation>
        <summary>Get a list of page one fields for given Udef type and current user group</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedPageOneFields" name="GetUserDefinedPageOneFieldsRequest" message="tns:GetUserDefinedPageOneFieldsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedPageOneFieldsResponse" name="GetUserDefinedPageOneFieldsResponse" message="tns:GetUserDefinedPageOneFieldsResponse" />
    </wsdl:operation>
    <wsdl:operation name="Publish">
      <wsdl:documentation>
        <summary>Publish changed Udef fields for the given owner type</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/Publish" name="PublishRequest" message="tns:PublishRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/PublishResponse" name="PublishResponse" message="tns:PublishResponse" />
    </wsdl:operation>
    <wsdl:operation name="Revert">
      <wsdl:documentation>
        <summary>Revert changed Udef fields for the given owner type - all unpublished changes will be lost</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/Revert" name="RevertRequest" message="tns:RevertRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/RevertResponse" name="RevertResponse" message="tns:RevertResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveUserDefinedFieldInfos">
      <wsdl:documentation>
        <summary>Save an array of user defined fields</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SaveUserDefinedFieldInfos" name="SaveUserDefinedFieldInfosRequest" message="tns:SaveUserDefinedFieldInfosRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SaveUserDefinedFieldInfosResponse" name="SaveUserDefinedFieldInfosResponse" message="tns:SaveUserDefinedFieldInfosResponse" />
    </wsdl:operation>
    <wsdl:operation name="DetectUnpublishedChanges">
      <wsdl:documentation>
        <summary>Detect changes to the admin version (unpublished)</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/DetectUnpublishedChanges" name="DetectUnpublishedChangesRequest" message="tns:DetectUnpublishedChangesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/DetectUnpublishedChangesResponse" name="DetectUnpublishedChangesResponse" message="tns:DetectUnpublishedChangesResponse" />
    </wsdl:operation>
    <wsdl:operation name="DetectColumnIdChanges">
      <wsdl:documentation>
        <summary>Detect columnid changes to the admin version (for determining publish warning)</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/DetectColumnIdChanges" name="DetectColumnIdChangesRequest" message="tns:DetectColumnIdChangesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/DetectColumnIdChangesResponse" name="DetectColumnIdChangesResponse" message="tns:DetectColumnIdChangesResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetUserDefinedPageOneField">
      <wsdl:documentation>
        <summary>Sets a user defined fields as page one field.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SetUserDefinedPageOneField" name="SetUserDefinedPageOneFieldRequest" message="tns:SetUserDefinedPageOneFieldRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SetUserDefinedPageOneFieldResponse" name="SetUserDefinedPageOneFieldResponse" message="tns:SetUserDefinedPageOneFieldResponse" />
    </wsdl:operation>
    <wsdl:operation name="IsPublishEventActive">
      <wsdl:documentation>
        <summary>Check if the publish event is active for the given type</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/IsPublishEventActive" name="IsPublishEventActiveRequest" message="tns:IsPublishEventActiveRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/IsPublishEventActiveResponse" name="IsPublishEventActiveResponse" message="tns:IsPublishEventActiveResponse" />
    </wsdl:operation>
    <wsdl:operation name="IsAnyPublishEventActive">
      <wsdl:documentation>
        <summary>Check if any publish events are active</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/IsAnyPublishEventActive" name="IsAnyPublishEventActiveRequest" message="tns:IsAnyPublishEventActiveRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/IsAnyPublishEventActiveResponse" name="IsAnyPublishEventActiveResponse" message="tns:IsAnyPublishEventActiveResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetChangedPageOneFields">
      <wsdl:documentation>
        <summary>Gets which page one fields have changed from the current version</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetChangedPageOneFields" name="GetChangedPageOneFieldsRequest" message="tns:GetChangedPageOneFieldsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetChangedPageOneFieldsResponse" name="GetChangedPageOneFieldsResponse" message="tns:GetChangedPageOneFieldsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetPageOneFieldGrouping">
      <wsdl:documentation>
        <summary>Sets the Page One Field grouping for a specific entity</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SetPageOneFieldGrouping" name="SetPageOneFieldGroupingRequest" message="tns:SetPageOneFieldGroupingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SetPageOneFieldGroupingResponse" name="SetPageOneFieldGroupingResponse" message="tns:SetPageOneFieldGroupingResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetListTableIdAndUDListDefinitionIdFromSelectedListId">
      <wsdl:documentation>
        <summary>Make stuff similar to what happens in the win client</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SetListTableIdAndUDListDefinitionIdFromSelectedListId" name="SetListTableIdAndUDListDefinitionIdFromSelectedListIdRequest" message="tns:SetListTableIdAndUDListDefinitionIdFromSelectedListIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SetListTableIdAndUDListDefinitionIdFromSelectedListIdResponse" name="SetListTableIdAndUDListDefinitionIdFromSelectedListIdResponse" message="tns:SetListTableIdAndUDListDefinitionIdFromSelectedListIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="FigureOutListIdFromListTableIdAndUDListDefinitionId">
      <wsdl:documentation>
        <summary>Kind of the reverse of SetListTableIdAndUDListDefinitionIdFromSelectedListId</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/FigureOutListIdFromListTableIdAndUDListDefinitionId" name="FigureOutListIdFromListTableIdAndUDListDefinitionIdRequest" message="tns:FigureOutListIdFromListTableIdAndUDListDefinitionIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/FigureOutListIdFromListTableIdAndUDListDefinitionIdResponse" name="FigureOutListIdFromListTableIdAndUDListDefinitionIdResponse" message="tns:FigureOutListIdFromListTableIdAndUDListDefinitionIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetRankOnFields">
      <wsdl:documentation>
        <summary>Change rank of user defined fields</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SetRankOnFields" name="SetRankOnFieldsRequest" message="tns:SetRankOnFieldsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SetRankOnFieldsResponse" name="SetRankOnFieldsResponse" message="tns:SetRankOnFieldsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetPublishStartSystemEvent">
      <wsdl:documentation>
        <summary>
        </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SetPublishStartSystemEvent" name="SetPublishStartSystemEventRequest" message="tns:SetPublishStartSystemEventRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SetPublishStartSystemEventResponse" name="SetPublishStartSystemEventResponse" message="tns:SetPublishStartSystemEventResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_UserDefinedFieldInfo" type="tns:UserDefinedFieldInfo">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultUserDefinedFieldInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/CreateDefaultUserDefinedFieldInfo" style="document" />
      <wsdl:input name="CreateDefaultUserDefinedFieldInfoRequest">
        <soap:header message="tns:CreateDefaultUserDefinedFieldInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultUserDefinedFieldInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultUserDefinedFieldInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultUserDefinedFieldInfoResponse">
        <soap:header message="tns:CreateDefaultUserDefinedFieldInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultUserDefinedFieldInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultUserDefinedFieldInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultUserDefinedFieldInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveUserDefinedFieldInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SaveUserDefinedFieldInfo" style="document" />
      <wsdl:input name="SaveUserDefinedFieldInfoRequest">
        <soap:header message="tns:SaveUserDefinedFieldInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveUserDefinedFieldInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveUserDefinedFieldInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveUserDefinedFieldInfoResponse">
        <soap:header message="tns:SaveUserDefinedFieldInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveUserDefinedFieldInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveUserDefinedFieldInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveUserDefinedFieldInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteUserDefinedFieldInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/DeleteUserDefinedFieldInfo" style="document" />
      <wsdl:input name="DeleteUserDefinedFieldInfoRequest">
        <soap:header message="tns:DeleteUserDefinedFieldInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteUserDefinedFieldInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteUserDefinedFieldInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteUserDefinedFieldInfoResponse">
        <soap:header message="tns:DeleteUserDefinedFieldInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteUserDefinedFieldInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteUserDefinedFieldInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteUserDefinedFieldInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserDefinedFieldInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedFieldInfo" style="document" />
      <wsdl:input name="GetUserDefinedFieldInfoRequest">
        <soap:header message="tns:GetUserDefinedFieldInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserDefinedFieldInfoResponse">
        <soap:header message="tns:GetUserDefinedFieldInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserDefinedFieldList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedFieldList" style="document" />
      <wsdl:input name="GetUserDefinedFieldListRequest">
        <soap:header message="tns:GetUserDefinedFieldListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserDefinedFieldListResponse">
        <soap:header message="tns:GetUserDefinedFieldListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserDefinedFieldFromFieldLabel">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedFieldFromFieldLabel" style="document" />
      <wsdl:input name="GetUserDefinedFieldFromFieldLabelRequest">
        <soap:header message="tns:GetUserDefinedFieldFromFieldLabelRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromFieldLabelRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromFieldLabelRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserDefinedFieldFromFieldLabelResponse">
        <soap:header message="tns:GetUserDefinedFieldFromFieldLabelResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromFieldLabelResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromFieldLabelResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromFieldLabelResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserDefinedFieldFromProgId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedFieldFromProgId" style="document" />
      <wsdl:input name="GetUserDefinedFieldFromProgIdRequest">
        <soap:header message="tns:GetUserDefinedFieldFromProgIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromProgIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromProgIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserDefinedFieldFromProgIdResponse">
        <soap:header message="tns:GetUserDefinedFieldFromProgIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromProgIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromProgIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromProgIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserDefinedFieldFromIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedFieldFromIds" style="document" />
      <wsdl:input name="GetUserDefinedFieldFromIdsRequest">
        <soap:header message="tns:GetUserDefinedFieldFromIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserDefinedFieldFromIdsResponse">
        <soap:header message="tns:GetUserDefinedFieldFromIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserDefinedFieldFromProgIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedFieldFromProgIds" style="document" />
      <wsdl:input name="GetUserDefinedFieldFromProgIdsRequest">
        <soap:header message="tns:GetUserDefinedFieldFromProgIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromProgIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromProgIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserDefinedFieldFromProgIdsResponse">
        <soap:header message="tns:GetUserDefinedFieldFromProgIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromProgIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromProgIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserDefinedFieldFromProgIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateUserDefinedFieldInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/CreateUserDefinedFieldInfo" style="document" />
      <wsdl:input name="CreateUserDefinedFieldInfoRequest">
        <soap:header message="tns:CreateUserDefinedFieldInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateUserDefinedFieldInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateUserDefinedFieldInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateUserDefinedFieldInfoResponse">
        <soap:header message="tns:CreateUserDefinedFieldInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateUserDefinedFieldInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateUserDefinedFieldInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateUserDefinedFieldInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChangeFieldType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/ChangeFieldType" style="document" />
      <wsdl:input name="ChangeFieldTypeRequest">
        <soap:header message="tns:ChangeFieldTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChangeFieldTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChangeFieldTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChangeFieldTypeResponse">
        <soap:header message="tns:ChangeFieldTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChangeFieldTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChangeFieldTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChangeFieldTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUserDefinedPageOneFields">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetUserDefinedPageOneFields" style="document" />
      <wsdl:input name="GetUserDefinedPageOneFieldsRequest">
        <soap:header message="tns:GetUserDefinedPageOneFieldsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUserDefinedPageOneFieldsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUserDefinedPageOneFieldsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUserDefinedPageOneFieldsResponse">
        <soap:header message="tns:GetUserDefinedPageOneFieldsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUserDefinedPageOneFieldsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUserDefinedPageOneFieldsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUserDefinedPageOneFieldsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Publish">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/Publish" style="document" />
      <wsdl:input name="PublishRequest">
        <soap:header message="tns:PublishRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:PublishRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:PublishRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="PublishResponse">
        <soap:header message="tns:PublishResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:PublishResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:PublishResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:PublishResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Revert">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/Revert" style="document" />
      <wsdl:input name="RevertRequest">
        <soap:header message="tns:RevertRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RevertRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RevertRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RevertResponse">
        <soap:header message="tns:RevertResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RevertResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RevertResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RevertResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveUserDefinedFieldInfos">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SaveUserDefinedFieldInfos" style="document" />
      <wsdl:input name="SaveUserDefinedFieldInfosRequest">
        <soap:header message="tns:SaveUserDefinedFieldInfosRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveUserDefinedFieldInfosRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveUserDefinedFieldInfosRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveUserDefinedFieldInfosResponse">
        <soap:header message="tns:SaveUserDefinedFieldInfosResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveUserDefinedFieldInfosResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveUserDefinedFieldInfosResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveUserDefinedFieldInfosResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DetectUnpublishedChanges">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/DetectUnpublishedChanges" style="document" />
      <wsdl:input name="DetectUnpublishedChangesRequest">
        <soap:header message="tns:DetectUnpublishedChangesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DetectUnpublishedChangesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DetectUnpublishedChangesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DetectUnpublishedChangesResponse">
        <soap:header message="tns:DetectUnpublishedChangesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DetectUnpublishedChangesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DetectUnpublishedChangesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DetectUnpublishedChangesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DetectColumnIdChanges">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/DetectColumnIdChanges" style="document" />
      <wsdl:input name="DetectColumnIdChangesRequest">
        <soap:header message="tns:DetectColumnIdChangesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DetectColumnIdChangesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DetectColumnIdChangesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DetectColumnIdChangesResponse">
        <soap:header message="tns:DetectColumnIdChangesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DetectColumnIdChangesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DetectColumnIdChangesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DetectColumnIdChangesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetUserDefinedPageOneField">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SetUserDefinedPageOneField" style="document" />
      <wsdl:input name="SetUserDefinedPageOneFieldRequest">
        <soap:header message="tns:SetUserDefinedPageOneFieldRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetUserDefinedPageOneFieldRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetUserDefinedPageOneFieldRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetUserDefinedPageOneFieldResponse">
        <soap:header message="tns:SetUserDefinedPageOneFieldResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetUserDefinedPageOneFieldResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetUserDefinedPageOneFieldResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetUserDefinedPageOneFieldResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="IsPublishEventActive">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/IsPublishEventActive" style="document" />
      <wsdl:input name="IsPublishEventActiveRequest">
        <soap:header message="tns:IsPublishEventActiveRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:IsPublishEventActiveRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:IsPublishEventActiveRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="IsPublishEventActiveResponse">
        <soap:header message="tns:IsPublishEventActiveResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:IsPublishEventActiveResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:IsPublishEventActiveResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:IsPublishEventActiveResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="IsAnyPublishEventActive">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/IsAnyPublishEventActive" style="document" />
      <wsdl:input name="IsAnyPublishEventActiveRequest">
        <soap:header message="tns:IsAnyPublishEventActiveRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:IsAnyPublishEventActiveRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:IsAnyPublishEventActiveRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="IsAnyPublishEventActiveResponse">
        <soap:header message="tns:IsAnyPublishEventActiveResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:IsAnyPublishEventActiveResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:IsAnyPublishEventActiveResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:IsAnyPublishEventActiveResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetChangedPageOneFields">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/GetChangedPageOneFields" style="document" />
      <wsdl:input name="GetChangedPageOneFieldsRequest">
        <soap:header message="tns:GetChangedPageOneFieldsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetChangedPageOneFieldsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetChangedPageOneFieldsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetChangedPageOneFieldsResponse">
        <soap:header message="tns:GetChangedPageOneFieldsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetChangedPageOneFieldsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetChangedPageOneFieldsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetChangedPageOneFieldsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetPageOneFieldGrouping">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SetPageOneFieldGrouping" style="document" />
      <wsdl:input name="SetPageOneFieldGroupingRequest">
        <soap:header message="tns:SetPageOneFieldGroupingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetPageOneFieldGroupingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetPageOneFieldGroupingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetPageOneFieldGroupingResponse">
        <soap:header message="tns:SetPageOneFieldGroupingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetPageOneFieldGroupingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetPageOneFieldGroupingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetPageOneFieldGroupingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetListTableIdAndUDListDefinitionIdFromSelectedListId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SetListTableIdAndUDListDefinitionIdFromSelectedListId" style="document" />
      <wsdl:input name="SetListTableIdAndUDListDefinitionIdFromSelectedListIdRequest">
        <soap:header message="tns:SetListTableIdAndUDListDefinitionIdFromSelectedListIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetListTableIdAndUDListDefinitionIdFromSelectedListIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetListTableIdAndUDListDefinitionIdFromSelectedListIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetListTableIdAndUDListDefinitionIdFromSelectedListIdResponse">
        <soap:header message="tns:SetListTableIdAndUDListDefinitionIdFromSelectedListIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetListTableIdAndUDListDefinitionIdFromSelectedListIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetListTableIdAndUDListDefinitionIdFromSelectedListIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetListTableIdAndUDListDefinitionIdFromSelectedListIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FigureOutListIdFromListTableIdAndUDListDefinitionId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/FigureOutListIdFromListTableIdAndUDListDefinitionId" style="document" />
      <wsdl:input name="FigureOutListIdFromListTableIdAndUDListDefinitionIdRequest">
        <soap:header message="tns:FigureOutListIdFromListTableIdAndUDListDefinitionIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FigureOutListIdFromListTableIdAndUDListDefinitionIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FigureOutListIdFromListTableIdAndUDListDefinitionIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FigureOutListIdFromListTableIdAndUDListDefinitionIdResponse">
        <soap:header message="tns:FigureOutListIdFromListTableIdAndUDListDefinitionIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FigureOutListIdFromListTableIdAndUDListDefinitionIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FigureOutListIdFromListTableIdAndUDListDefinitionIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FigureOutListIdFromListTableIdAndUDListDefinitionIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetRankOnFields">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SetRankOnFields" style="document" />
      <wsdl:input name="SetRankOnFieldsRequest">
        <soap:header message="tns:SetRankOnFieldsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetRankOnFieldsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetRankOnFieldsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetRankOnFieldsResponse">
        <soap:header message="tns:SetRankOnFieldsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetRankOnFieldsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetRankOnFieldsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetRankOnFieldsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetPublishStartSystemEvent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services75/UserDefinedFieldInfo/SetPublishStartSystemEvent" style="document" />
      <wsdl:input name="SetPublishStartSystemEventRequest">
        <soap:header message="tns:SetPublishStartSystemEventRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetPublishStartSystemEventRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetPublishStartSystemEventRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetPublishStartSystemEventResponse">
        <soap:header message="tns:SetPublishStartSystemEventResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetPublishStartSystemEventResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetPublishStartSystemEventResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetPublishStartSystemEventResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfUserDefinedFieldInfoService">
    <wsdl:port name="BasicHttpBinding_UserDefinedFieldInfo" binding="tns:BasicHttpBinding_UserDefinedFieldInfo">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services75/UserDefinedFieldInfo.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

