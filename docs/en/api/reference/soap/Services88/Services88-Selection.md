---
generated: true
uid: wsdl-Services88-Selection
title: Services88.SelectionAgent WSDL
content_type: reference
---

# Services88.SelectionAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfSelectionService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:ser="http://schemas.microsoft.com/2003/10/Serialization/">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="CreateDefaultSelectionEntity">
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
      <xs:element name="CreateDefaultSelectionEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q5:SelectionEntity" xmlns:q5="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SelectionEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q6:Carrier" xmlns:q6="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Postit" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Associate" nillable="true" type="q6:Associate" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="q6:Associate" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="q6:Associate" />
              <xs:element minOccurs="0" name="SelectionCategory" nillable="true" type="q6:SelectionCategory" />
              <xs:element minOccurs="0" name="GroupIdx" type="xs:int" />
              <xs:element minOccurs="0" name="IncludePerson" type="xs:int" />
              <xs:element minOccurs="0" name="MemberCount" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PostitTextId" type="xs:int" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
              <xs:element minOccurs="0" name="SoundEx" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Source" type="xs:short" />
              <xs:element minOccurs="0" name="TextId" type="xs:int" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedCount" type="xs:short" />
              <xs:element minOccurs="0" name="Visibility" type="xs:short" />
              <xs:element minOccurs="0" name="SelectionType" type="q6:SelectionType" />
              <xs:element minOccurs="0" name="CompanyUnique" type="xs:boolean" />
              <xs:element minOccurs="0" name="TargetTableNumber" type="xs:int" />
              <xs:element minOccurs="0" name="TargetTableName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Completed" type="xs:boolean" />
              <xs:element minOccurs="0" name="LeftSelectionId" type="xs:int" />
              <xs:element minOccurs="0" name="RightSelectionId" type="xs:int" />
              <xs:element minOccurs="0" name="SelectionUnionType" type="q6:SelectionUnionType" />
              <xs:element minOccurs="0" name="MainProviderName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ShadowProviderName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ChartKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="LastLoaded" type="xs:dateTime" />
              <xs:element minOccurs="0" name="LastLoadedBy" type="xs:int" />
              <xs:element minOccurs="0" name="LastLoadedByAssociate" nillable="true" type="q6:Associate" />
              <xs:element minOccurs="0" name="LastMembershipChange" type="xs:dateTime" />
              <xs:element minOccurs="0" name="LastMembershipChangeBy" type="xs:int" />
              <xs:element minOccurs="0" name="LastMembershipChangeByAssociate" nillable="true" type="q6:Associate" />
              <xs:element minOccurs="0" name="MainHeading" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MemberTabHeading" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MailingsProviderName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DashboardTileDefinitionId" type="xs:int" />
              <xs:element minOccurs="0" name="VisibleFor" nillable="true" type="q6:ArrayOfVisibleFor" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SelectionEntity" nillable="true" type="q7:SelectionEntity" xmlns:q7="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:complexType name="Associate">
        <xs:complexContent mixed="false">
          <xs:extension base="q21:Carrier" xmlns:q21="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Type" type="q21:UserType" />
              <xs:element minOccurs="0" name="GroupIdx" type="xs:int" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="EjUserId" type="xs:int" />
              <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="q21:StringDictionary" />
              <xs:element minOccurs="0" name="CustomFields" nillable="true" type="q21:StringDictionary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Associate" nillable="true" type="q22:Associate" xmlns:q22="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="UserType" nillable="true" type="q23:UserType" xmlns:q23="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="StringDictionary" nillable="true" type="q24:StringDictionary" xmlns:q24="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SelectionCategory">
        <xs:complexContent mixed="false">
          <xs:extension base="q25:Carrier" xmlns:q25="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SelectionCategory" nillable="true" type="q26:SelectionCategory" xmlns:q26="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="SelectionType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Static" />
          <xs:enumeration value="Dynamic" />
          <xs:enumeration value="Combined" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="SelectionType" nillable="true" type="q27:SelectionType" xmlns:q27="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="SelectionUnionType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="SubtractRightFromLeft" />
          <xs:enumeration value="SubtractLeftFromRight" />
          <xs:enumeration value="Intersect" />
          <xs:enumeration value="XOR" />
          <xs:enumeration value="Union" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="SelectionUnionType" nillable="true" type="q28:SelectionUnionType" xmlns:q28="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfVisibleFor">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="VisibleFor" nillable="true" type="q29:VisibleFor" xmlns:q29="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfVisibleFor" nillable="true" type="q30:ArrayOfVisibleFor" xmlns:q30="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="VisibleFor">
        <xs:complexContent mixed="false">
          <xs:extension base="q31:Carrier" xmlns:q31="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="VisibleId" type="xs:int" />
              <xs:element minOccurs="0" name="Visibility" type="q31:Visibility" />
              <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="VisibleFor" nillable="true" type="q32:VisibleFor" xmlns:q32="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="Visibility">
        <xs:restriction base="xs:string">
          <xs:enumeration value="All" />
          <xs:enumeration value="Associate" />
          <xs:enumeration value="Group" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="Visibility" nillable="true" type="q33:Visibility" xmlns:q33="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SoExceptionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="StackTrace" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FriendlyText" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ExceptionType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="InnerException" nillable="true" type="q34:SoExceptionInfo" xmlns:q34="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Parameters" nillable="true" type="q35:SoExceptionInfoParameters" xmlns:q35="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExceptionInfo" nillable="true" type="q36:SoExceptionInfo" xmlns:q36="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="SoExceptionInfoParameters" nillable="true" type="q37:SoExceptionInfoParameters" xmlns:q37="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ExceptionInfo" nillable="true" type="q38:SoExceptionInfo" xmlns:q38="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="SoExtraInfo" nillable="true" type="q39:SoExtraInfo" xmlns:q39="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ExtraInfo" nillable="true" type="q40:SoExtraInfo" xmlns:q40="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="Succeeded" type="xs:boolean" />
      <xs:element name="SaveSelectionEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionEntity" nillable="true" type="q41:SelectionEntity" xmlns:q41="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveSelectionEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q42:SelectionEntity" xmlns:q42="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultBoardViewSettingsFromEntityType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EntityType" type="q43:BoardViewEntityType" xmlns:q43="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="BoardViewEntityType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Sale" />
          <xs:enumeration value="Project" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="BoardViewEntityType" nillable="true" type="q44:BoardViewEntityType" xmlns:q44="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="CreateDefaultBoardViewSettingsFromEntityTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q45:BoardViewSettingsBase" xmlns:q45="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="BoardViewSettingsBase">
        <xs:sequence>
          <xs:element minOccurs="0" name="BoardViewSettingsId" type="xs:int" />
          <xs:element minOccurs="0" name="EntityType" type="q46:BoardViewEntityType" xmlns:q46="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
          <xs:element minOccurs="0" name="HideEmptyGroups" type="xs:boolean" />
          <xs:element minOccurs="0" name="GroupBy" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="SubGroupBy" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="SortBy" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="SortDesc" type="xs:boolean" />
          <xs:element minOccurs="0" name="SumBy" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ColorBy" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Filters" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="BoardViewSettingsBase" nillable="true" type="q47:BoardViewSettingsBase" xmlns:q47="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ProjectBoardViewSettings">
        <xs:complexContent mixed="false">
          <xs:extension base="q48:BoardViewSettingsBase" xmlns:q48="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="HideCompletedProjects" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ProjectBoardViewSettings" nillable="true" type="q49:ProjectBoardViewSettings" xmlns:q49="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SaleBoardViewSettings">
        <xs:complexContent mixed="false">
          <xs:extension base="q50:BoardViewSettingsBase" xmlns:q50="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="HideClosedSales" type="xs:boolean" />
              <xs:element minOccurs="0" name="BadgeType" type="q50:BoardViewBadgeType" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SaleBoardViewSettings" nillable="true" type="q51:SaleBoardViewSettings" xmlns:q51="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="BoardViewBadgeType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="DaysSinceRegistered" />
          <xs:enumeration value="DaysInStage" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="BoardViewBadgeType" nillable="true" type="q52:BoardViewBadgeType" xmlns:q52="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetBoardViewSettings">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BoardViewSettingsId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBoardViewSettingsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q53:BoardViewSettingsBase" xmlns:q53="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBoardViewSettingsForSelection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetBoardViewSettingsForSelectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q54:BoardViewSettingsBase" xmlns:q54="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveBoardViewSettings">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BoardViewSettings" nillable="true" type="q55:BoardViewSettingsBase" xmlns:q55="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveBoardViewSettingsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q56:BoardViewSettingsBase" xmlns:q56="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveBoardViewSettingsForSelectionAndAssociate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BoardViewSettings" nillable="true" type="q57:BoardViewSettingsBase" xmlns:q57="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveBoardViewSettingsForSelectionAndAssociateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q58:BoardViewSettingsBase" xmlns:q58="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteBoardViewSettings">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="BoardViewSettingsId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteBoardViewSettingsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectionEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectionEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q59:SelectionEntity" xmlns:q59="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateSelectionEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TargetTableName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateSelectionEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q60:SelectionEntity" xmlns:q60="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateContactSelectionFromSelection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TargetSelectionType" type="q61:SelectionType" xmlns:q61="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="CopyMembers" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateContactSelectionFromSelectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q62:SelectionEntity" xmlns:q62="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTemporaryContactSelectionFromContactPersonIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactPersonIds" nillable="true" type="q63:ArrayOfContactPersonId" xmlns:q63="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfContactPersonId">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ContactPersonId" nillable="true" type="q64:ContactPersonId" xmlns:q64="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfContactPersonId" nillable="true" type="q65:ArrayOfContactPersonId" xmlns:q65="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ContactPersonId">
        <xs:complexContent mixed="false">
          <xs:extension base="q66:Carrier" xmlns:q66="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ContactPersonId" nillable="true" type="q67:ContactPersonId" xmlns:q67="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="CreateTemporaryContactSelectionFromContactPersonIdsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q68:SelectionEntity" xmlns:q68="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopyContactSelectionMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FromSelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ToSelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopyContactSelectionMembersResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRecipientStatistics">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRecipientStatisticsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q69:RecipientStatistics" xmlns:q69="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="RecipientStatistics">
        <xs:complexContent mixed="false">
          <xs:extension base="q70:Carrier" xmlns:q70="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Total" type="xs:int" />
              <xs:element minOccurs="0" name="ValidPostalAddresses" type="xs:int" />
              <xs:element minOccurs="0" name="ValidEmailAddresses" type="xs:int" />
              <xs:element minOccurs="0" name="ValidFaxNumbers" type="xs:int" />
              <xs:element minOccurs="0" name="NoAddresses" type="xs:int" />
              <xs:element minOccurs="0" name="NoFaxOrEmails" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="RecipientStatistics" nillable="true" type="q71:RecipientStatistics" xmlns:q71="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetRecipientStatisticsFromProjectMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRecipientStatisticsFromProjectMembersResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q72:RecipientStatistics" xmlns:q72="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRecipientStatisticsFromContactPersonIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactPersonIds" nillable="true" type="q73:ArrayOfContactPersonId" xmlns:q73="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRecipientStatisticsFromContactPersonIdsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q74:RecipientStatistics" xmlns:q74="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddContactSelectionMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ContactPersonIds" nillable="true" type="q75:ArrayOfContactPersonId" xmlns:q75="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddContactSelectionMembersResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveContactSelectionMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ContactPersonIds" nillable="true" type="q76:ArrayOfContactPersonId" xmlns:q76="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveContactSelectionMembersResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveContactSelectionMembersFromIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="SelectionMembersIds" nillable="true" type="q77:ArrayOfint" xmlns:q77="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveContactSelectionMembersFromIdsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="AddContactSelectionMembersFromSearch">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddContactSelectionMembersFromSearchResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveContactSelectionMembersFromSearch">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveContactSelectionMembersFromSearchResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTemporaryContactSelection">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTemporaryContactSelectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q78:SelectionEntity" xmlns:q78="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTemporaryContactSelectionFromSelectionMemberIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="SelectionMemberIds" nillable="true" type="q79:ArrayOfint" xmlns:q79="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTemporaryContactSelectionFromSelectionMemberIdsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q80:SelectionEntity" xmlns:q80="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddRemoveContactSelectionMemberInterests">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="AddCompanyInterests" nillable="true" type="q81:ArrayOfint" xmlns:q81="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="RemoveCompanyInterests" nillable="true" type="q82:ArrayOfint" xmlns:q82="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="AddContactInterests" nillable="true" type="q83:ArrayOfint" xmlns:q83="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="RemoveContactInterests" nillable="true" type="q84:ArrayOfint" xmlns:q84="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddRemoveContactSelectionMemberInterestsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="EditContactSelectionMemberDetails">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="SelectionMemberEditValues" nillable="true" type="q85:SelectionMemberEditValues" xmlns:q85="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SelectionMemberEditValues">
        <xs:complexContent mixed="false">
          <xs:extension base="q86:Carrier" xmlns:q86="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="CompanyCategory" type="xs:int" />
              <xs:element minOccurs="0" name="CompanyBusiness" type="xs:int" />
              <xs:element minOccurs="0" name="CompanyOurContact" type="xs:int" />
              <xs:element minOccurs="0" name="CompanyName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CompanyDepartment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CompanyNumber" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CompanyCode" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactPosition" type="xs:int" />
              <xs:element minOccurs="0" name="ChangeCompanyCategory" type="xs:boolean" />
              <xs:element minOccurs="0" name="ChangeCompanyBusiness" type="xs:boolean" />
              <xs:element minOccurs="0" name="ChangeCompanyOurContact" type="xs:boolean" />
              <xs:element minOccurs="0" name="ChangeCompanyName" type="xs:boolean" />
              <xs:element minOccurs="0" name="ChangeCompanyDepartment" type="xs:boolean" />
              <xs:element minOccurs="0" name="ChangeCompanyNumber" type="xs:boolean" />
              <xs:element minOccurs="0" name="ChangeCompanyCode" type="xs:boolean" />
              <xs:element minOccurs="0" name="ChangeContactPosition" type="xs:boolean" />
              <xs:element minOccurs="0" name="CompanyCountry" type="xs:int" />
              <xs:element minOccurs="0" name="ChangeCompanyCountry" type="xs:boolean" />
              <xs:element minOccurs="0" name="ContactJobTitle" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ChangeContactJobTitle" type="xs:boolean" />
              <xs:element minOccurs="0" name="CompanyOrgNr" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ChangeCompanyOrgNr" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SelectionMemberEditValues" nillable="true" type="q87:SelectionMemberEditValues" xmlns:q87="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="EditContactSelectionMemberDetailsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GenerateFollowUps">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="AppointmentEntity" nillable="true" type="q88:AppointmentEntity" xmlns:q88="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="SaveOnContactOwner" type="xs:boolean" />
            <xs:element minOccurs="0" name="UniqueContact" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="AppointmentEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q89:Carrier" xmlns:q89="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Associate" nillable="true" type="q89:Associate" />
              <xs:element minOccurs="0" name="Contact" nillable="true" type="q89:Contact" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="q89:Associate" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="q89:Associate" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Agenda" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="InternalNotes" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="InvitedPerson" nillable="true" type="q89:Person" />
              <xs:element minOccurs="0" name="Person" nillable="true" type="q89:Person" />
              <xs:element minOccurs="0" name="MotherId" type="xs:int" />
              <xs:element minOccurs="0" name="Priority" nillable="true" type="q89:Priority" />
              <xs:element minOccurs="0" name="Private" type="q89:AppointmentPrivate" />
              <xs:element minOccurs="0" name="Project" nillable="true" type="q89:Project" />
              <xs:element minOccurs="0" name="Type" type="q89:AppointmentType" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Completed" type="q89:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveLinks" type="xs:int" />
              <xs:element minOccurs="0" name="Links" nillable="true" type="q89:ArrayOfLink" />
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
              <xs:element minOccurs="0" name="Recurrence" nillable="true" type="q89:RecurrenceInfo" />
              <xs:element minOccurs="0" name="Participants" nillable="true" type="q89:ArrayOfParticipantInfo" />
              <xs:element minOccurs="0" name="AssignmentStatus" type="q89:AssignmentStatus" />
              <xs:element minOccurs="0" name="InvitationStatus" type="q89:InvitationStatus" />
              <xs:element minOccurs="0" name="BookingType" type="q89:BookingType" />
              <xs:element minOccurs="0" name="ActiveDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="HasConflict" type="xs:boolean" />
              <xs:element minOccurs="0" name="AssignedBy" nillable="true" type="q89:Associate" />
              <xs:element minOccurs="0" name="MotherAssociate" nillable="true" type="q89:Associate" />
              <xs:element minOccurs="0" name="Task" nillable="true" type="q89:TaskListItem" />
              <xs:element minOccurs="0" name="PreferredTZLocation" type="xs:int" />
              <xs:element minOccurs="0" name="PreferredTZLocationData" nillable="true" type="q89:TimeZoneData" />
              <xs:element minOccurs="0" name="Sale" nillable="true" type="q89:Sale" />
              <xs:element minOccurs="0" name="SuggestedAppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="IsMileStone" type="xs:boolean" />
              <xs:element minOccurs="0" name="CautionWarning" type="q89:AppointmentCautionWarning" />
              <xs:element minOccurs="0" name="OwnedExternally" type="q89:AppointmentExternalOwner" />
              <xs:element minOccurs="0" name="JoinVideomeetUrl" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CentralserviceVideomeetId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserDefinedFields" nillable="true" type="q89:StringDictionary" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="q89:StringDictionary" />
              <xs:element minOccurs="0" name="CustomFields" nillable="true" type="q89:StringDictionary" />
              <xs:element minOccurs="0" name="PublishEventDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishTo" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishFrom" type="xs:dateTime" />
              <xs:element minOccurs="0" name="IsPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="VisibleFor" nillable="true" type="q89:ArrayOfVisibleFor" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AppointmentEntity" nillable="true" type="q90:AppointmentEntity" xmlns:q90="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Contact">
        <xs:complexContent mixed="false">
          <xs:extension base="q91:Carrier" xmlns:q91="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
              <xs:element minOccurs="0" name="Address" nillable="true" type="q91:Address" />
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
      <xs:element name="Contact" nillable="true" type="q92:Contact" xmlns:q92="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Address">
        <xs:complexContent mixed="false">
          <xs:extension base="q93:Carrier" xmlns:q93="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Wgs84Latitude" type="xs:double" />
              <xs:element minOccurs="0" name="Wgs84Longitude" type="xs:double" />
              <xs:element minOccurs="0" name="LocalizedAddress" nillable="true" type="q93:ArrayOfArrayOfLocalizedField" />
              <xs:element minOccurs="0" name="Street" nillable="true" type="q93:StructuredAddress" />
              <xs:element minOccurs="0" name="Postal" nillable="true" type="q93:StructuredAddress" />
              <xs:element minOccurs="0" name="Formatted" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Address" nillable="true" type="q94:Address" xmlns:q94="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArrayOfLocalizedField" nillable="true" type="q95:ArrayOfLocalizedField" xmlns:q95="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArrayOfLocalizedField" nillable="true" type="q96:ArrayOfArrayOfLocalizedField" xmlns:q96="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="LocalizedField" nillable="true" type="q97:LocalizedField" xmlns:q97="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLocalizedField" nillable="true" type="q98:ArrayOfLocalizedField" xmlns:q98="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="LocalizedField">
        <xs:complexContent mixed="false">
          <xs:extension base="q99:Carrier" xmlns:q99="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="LocalizedField" nillable="true" type="q100:LocalizedField" xmlns:q100="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="StructuredAddress">
        <xs:sequence>
          <xs:element minOccurs="0" name="AtypeIdx" type="q101:AddressType" xmlns:q101="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="StructuredAddress" nillable="true" type="q102:StructuredAddress" xmlns:q102="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AddressType" nillable="true" type="q103:AddressType" xmlns:q103="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Person">
        <xs:complexContent mixed="false">
          <xs:extension base="q104:Carrier" xmlns:q104="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="Person" nillable="true" type="q105:Person" xmlns:q105="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Priority">
        <xs:complexContent mixed="false">
          <xs:extension base="q106:Carrier" xmlns:q106="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Priority" nillable="true" type="q107:Priority" xmlns:q107="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AppointmentPrivate" nillable="true" type="q108:AppointmentPrivate" xmlns:q108="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Project">
        <xs:complexContent mixed="false">
          <xs:extension base="q109:Carrier" xmlns:q109="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="Project" nillable="true" type="q110:Project" xmlns:q110="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AppointmentType" nillable="true" type="q111:AppointmentType" xmlns:q111="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="ActivityStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="NotStarted" />
          <xs:enumeration value="Started" />
          <xs:enumeration value="Completed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ActivityStatus" nillable="true" type="q112:ActivityStatus" xmlns:q112="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfLink">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Link" nillable="true" type="q113:Link" xmlns:q113="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLink" nillable="true" type="q114:ArrayOfLink" xmlns:q114="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Link">
        <xs:complexContent mixed="false">
          <xs:extension base="q115:Carrier" xmlns:q115="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="Link" nillable="true" type="q116:Link" xmlns:q116="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="RecurrenceId" type="xs:int" />
          <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="RecurrenceEndType" type="q117:RecurrenceEndType" xmlns:q117="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Pattern" type="q118:RecurrencePattern" xmlns:q118="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="DayPattern" nillable="true" type="q119:RecurrenceDayPattern" xmlns:q119="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="WeekPattern" nillable="true" type="q120:RecurrenceWeekPattern" xmlns:q120="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="MonthPattern" nillable="true" type="q121:RecurrenceMonthPattern" xmlns:q121="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="YearPattern" nillable="true" type="q122:RecurrenceYearPattern" xmlns:q122="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Dates" nillable="true" type="q123:ArrayOfRecurrenceDate" xmlns:q123="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="RecurrenceCounter" type="xs:int" />
          <xs:element minOccurs="0" name="IsRecurrence" type="xs:boolean" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceInfo" nillable="true" type="q124:RecurrenceInfo" xmlns:q124="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="RecurrenceEndType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="EndDate" />
          <xs:enumeration value="Counter" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrenceEndType" nillable="true" type="q125:RecurrenceEndType" xmlns:q125="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="RecurrencePattern" nillable="true" type="q126:RecurrencePattern" xmlns:q126="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceDayPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Pattern" type="q127:RecurrenceDailyPattern" xmlns:q127="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceDayPattern" nillable="true" type="q128:RecurrenceDayPattern" xmlns:q128="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="RecurrenceDailyPattern">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="EveryWorkday" />
          <xs:enumeration value="EveryWeekday" />
          <xs:enumeration value="EveryCyclicDay" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrenceDailyPattern" nillable="true" type="q129:RecurrenceDailyPattern" xmlns:q129="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceWeekPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Weekdays" type="q130:Weekday" xmlns:q130="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceWeekPattern" nillable="true" type="q131:RecurrenceWeekPattern" xmlns:q131="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="Weekday" nillable="true" type="q132:Weekday" xmlns:q132="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceMonthPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Day" type="xs:int" />
          <xs:element minOccurs="0" name="Weekday" type="q133:Weekday" xmlns:q133="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="WeekOfMonth" type="q134:WeekOfMonth" xmlns:q134="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Pattern" type="q135:RecurrenceMonthlyPattern" xmlns:q135="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceMonthPattern" nillable="true" type="q136:RecurrenceMonthPattern" xmlns:q136="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="WeekOfMonth" nillable="true" type="q137:WeekOfMonth" xmlns:q137="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="RecurrenceMonthlyPattern" nillable="true" type="q138:RecurrenceMonthlyPattern" xmlns:q138="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceYearPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Day" type="xs:int" />
          <xs:element minOccurs="0" name="Weekday" type="q139:Weekday" xmlns:q139="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="WeekOfMonth" type="q140:WeekOfMonth" xmlns:q140="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Pattern" type="q141:RecurrenceYearlyPattern" xmlns:q141="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceYearPattern" nillable="true" type="q142:RecurrenceYearPattern" xmlns:q142="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="RecurrenceYearlyPattern" nillable="true" type="q143:RecurrenceYearlyPattern" xmlns:q143="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfRecurrenceDate">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="RecurrenceDate" nillable="true" type="q144:RecurrenceDate" xmlns:q144="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfRecurrenceDate" nillable="true" type="q145:ArrayOfRecurrenceDate" xmlns:q145="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceDate">
        <xs:sequence>
          <xs:element minOccurs="0" name="Date" type="xs:dateTime" />
          <xs:element minOccurs="0" name="IsConflict" type="xs:boolean" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DescriptionStyleHint" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceDate" nillable="true" type="q146:RecurrenceDate" xmlns:q146="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfParticipantInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ParticipantInfo" nillable="true" type="q147:ParticipantInfo" xmlns:q147="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfParticipantInfo" nillable="true" type="q148:ArrayOfParticipantInfo" xmlns:q148="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ParticipantInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          <xs:element minOccurs="0" name="EmailId" type="xs:int" />
          <xs:element minOccurs="0" name="SendEmail" type="xs:boolean" />
          <xs:element minOccurs="0" name="InvitationStatus" type="q149:InvitationStatus" xmlns:q149="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ParticipantInfo" nillable="true" type="q150:ParticipantInfo" xmlns:q150="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="InvitationStatus" nillable="true" type="q151:InvitationStatus" xmlns:q151="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AssignmentStatus" nillable="true" type="q152:AssignmentStatus" xmlns:q152="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="BookingType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="None" />
          <xs:enumeration value="Owner" />
          <xs:enumeration value="Participant" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="BookingType" nillable="true" type="q153:BookingType" xmlns:q153="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TaskListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q154:Carrier" xmlns:q154="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="TaskListItemId" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Direction" type="q154:TaskDirection" />
              <xs:element minOccurs="0" name="Type" type="q154:TaskType" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="IntentId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="IsDefaultAlldayEvent" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsDefaultFree" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsDefaultPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="ColorIndex" type="q154:ColorIndex" />
              <xs:element minOccurs="0" name="DefaultVideomeetingStatus" type="q154:VideoMeetingStatus" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TaskListItem" nillable="true" type="q155:TaskListItem" xmlns:q155="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="TaskDirection" nillable="true" type="q156:TaskDirection" xmlns:q156="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="TaskType" nillable="true" type="q157:TaskType" xmlns:q157="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="ColorIndex" nillable="true" type="q158:ColorIndex" xmlns:q158="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="VideoMeetingStatus" nillable="true" type="q159:VideoMeetingStatus" xmlns:q159="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TimeZoneData">
        <xs:sequence>
          <xs:element minOccurs="0" name="TZLocationID" type="xs:int" />
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="TZLocationCode" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="TZLocationCities" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="IsoNumber" type="xs:int" />
          <xs:element minOccurs="0" name="TimeZoneSTDRules" nillable="true" type="q160:TimeZoneRuleDictionary" xmlns:q160="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="TimeZoneDSTRules" nillable="true" type="q161:TimeZoneRuleDictionary" xmlns:q161="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TimeZoneData" nillable="true" type="q162:TimeZoneData" xmlns:q162="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
                <xs:element name="Value" nillable="true" type="q163:TimeZoneRule" xmlns:q163="http://www.superoffice.net/ws/crm/NetServer/Services88" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TimeZoneRuleDictionary" nillable="true" type="q164:TimeZoneRuleDictionary" xmlns:q164="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="TimeZoneRule" nillable="true" type="q165:TimeZoneRule" xmlns:q165="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Sale">
        <xs:complexContent mixed="false">
          <xs:extension base="q166:Carrier" xmlns:q166="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
              <xs:element minOccurs="0" name="Status" type="q166:SaleStatus" />
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
              <xs:element minOccurs="0" name="Completed" type="q166:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="NextDueDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Number" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Sale" nillable="true" type="q167:Sale" xmlns:q167="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="SaleStatus" nillable="true" type="q168:SaleStatus" xmlns:q168="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AppointmentCautionWarning" nillable="true" type="q169:AppointmentCautionWarning" xmlns:q169="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AppointmentExternalOwner" nillable="true" type="q170:AppointmentExternalOwner" xmlns:q170="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GenerateFollowUpsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ExportSelectionMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="TemplateName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="UseContacts" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExportSelectionMembersResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExportSelectionMembersWithOrderBy">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="TemplateName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="UseContacts" type="xs:boolean" />
            <xs:element minOccurs="0" name="OrderBy" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExportSelectionMembersWithOrderByResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDuplicateRulesStatus">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Rules" nillable="true" type="q171:ArrayOfDuplicateRule" xmlns:q171="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDuplicateRule">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DuplicateRule" nillable="true" type="q172:DuplicateRule" xmlns:q172="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDuplicateRule" nillable="true" type="q173:ArrayOfDuplicateRule" xmlns:q173="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="DuplicateRule">
        <xs:complexContent mixed="false">
          <xs:extension base="q174:Carrier" xmlns:q174="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayTooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DuplicateRule" nillable="true" type="q175:DuplicateRule" xmlns:q175="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="SetDuplicateRulesStatusResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDuplicates">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDuplicatesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q176:ArrayOfDuplicateEntry" xmlns:q176="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDuplicateEntry">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DuplicateEntry" nillable="true" type="q177:DuplicateEntry" xmlns:q177="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDuplicateEntry" nillable="true" type="q178:ArrayOfDuplicateEntry" xmlns:q178="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="DuplicateEntry">
        <xs:complexContent mixed="false">
          <xs:extension base="q179:Carrier" xmlns:q179="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="RuleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SoPrimaryKey" type="xs:int" />
              <xs:element minOccurs="0" name="EntryName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EntryIdentifier" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RuleDisplayName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DuplicateEntry" nillable="true" type="q180:DuplicateEntry" xmlns:q180="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetDuplicateRules">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDuplicateRulesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q181:ArrayOfDuplicateRule" xmlns:q181="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateNewEntry">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Duplicate" nillable="true" type="q182:DuplicateEntry" xmlns:q182="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateNewEntryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteContacts">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteContactsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="AddSelectionMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="Ids" nillable="true" type="q183:ArrayOfint" xmlns:q183="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddSelectionMembersResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveSelectionMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="SelectionMemberIds" nillable="true" type="q184:ArrayOfint" xmlns:q184="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveSelectionMembersResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveSelectionMembersById">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="Ids" nillable="true" type="q185:ArrayOfint" xmlns:q185="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveSelectionMembersByIdResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="AddSelectionMembersFromSearch">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddSelectionMembersFromSearchResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveSelectionMembersFromSearch">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="StorageKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveSelectionMembersFromSearchResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopySelectionMembers">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FromSelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ToSelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopySelectionMembersResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTemporarySelectionFromIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Ids" nillable="true" type="q186:ArrayOfint" xmlns:q186="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="TargetTableNumber" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateTemporarySelectionFromIdsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q187:SelectionEntity" xmlns:q187="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateSelectionFromSelection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TargetSelectionType" type="q188:SelectionType" xmlns:q188="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="CopyMembers" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateSelectionFromSelectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q189:SelectionEntity" xmlns:q189="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateContactSelectionFromShadowSelection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateContactSelectionFromShadowSelectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q190:SelectionEntity" xmlns:q190="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteEntities">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteEntitiesResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetParentCombinedSelections">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetParentCombinedSelectionsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q191:ArrayOfint" xmlns:q191="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectionMembersArchiveRows">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="Select" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectionMembersArchiveRowsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q192:ArrayOfArchiveListItem" xmlns:q192="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfArchiveListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArchiveListItem" nillable="true" type="q193:ArchiveListItem" xmlns:q193="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArchiveListItem" nillable="true" type="q194:ArrayOfArchiveListItem" xmlns:q194="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArchiveListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q195:Carrier" xmlns:q195="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="EntityName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PrimaryKey" type="xs:int" />
              <xs:element minOccurs="0" name="ColumnData" nillable="true" type="q195:ColumnDataDictionary" />
              <xs:element minOccurs="0" name="LinkHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StyleHint" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ArchiveListItem" nillable="true" type="q196:ArchiveListItem" xmlns:q196="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ColumnDataDictionary">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ColumnDataKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="q197:ArchiveColumnData" xmlns:q197="http://www.superoffice.net/ws/crm/NetServer/Services88" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ColumnDataDictionary" nillable="true" type="q198:ColumnDataDictionary" xmlns:q198="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArchiveColumnData">
        <xs:sequence>
          <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="TooltipHint" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="LinkHint" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArchiveColumnData" nillable="true" type="q199:ArchiveColumnData" xmlns:q199="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetSelectionShadowMembersArchiveRows">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="Select" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectionShadowMembersArchiveRowsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q200:ArrayOfArchiveListItem" xmlns:q200="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDynamicSelectionCriteria">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDynamicSelectionCriteriaResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q201:ArrayOfArchiveRestrictionInfo" xmlns:q201="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfArchiveRestrictionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArchiveRestrictionInfo" nillable="true" type="q202:ArchiveRestrictionInfo" xmlns:q202="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArchiveRestrictionInfo" nillable="true" type="q203:ArrayOfArchiveRestrictionInfo" xmlns:q203="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArchiveRestrictionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Operator" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Values" nillable="true" type="q204:ArrayOfstring" xmlns:q204="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="DisplayValues" nillable="true" type="q205:ArrayOfstring" xmlns:q205="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="ColumnInfo" nillable="true" type="q206:ArchiveColumnInfo" xmlns:q206="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
          <xs:element minOccurs="0" name="SubRestrictions" nillable="true" type="q207:ArrayOfArchiveRestrictionInfo" xmlns:q207="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="InterParenthesis" type="xs:int" />
          <xs:element minOccurs="0" name="InterOperator" type="q208:InterRestrictionOperator" xmlns:q208="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="UniqueHash" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArchiveRestrictionInfo" nillable="true" type="q209:ArchiveRestrictionInfo" xmlns:q209="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="ArchiveColumnInfo" nillable="true" type="q210:ArchiveColumnInfo" xmlns:q210="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="InterRestrictionOperator">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="And" />
          <xs:enumeration value="Or" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="InterRestrictionOperator" nillable="true" type="q211:InterRestrictionOperator" xmlns:q211="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="SetDynamicSelectionCriteria">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="Criteria" nillable="true" type="q212:ArrayOfArchiveRestrictionInfo" xmlns:q212="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDynamicSelectionCriteriaResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q213:ArrayOfArchiveRestrictionInfo" xmlns:q213="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDynamicSelectionCriteria2">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="Filter" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDynamicSelectionCriteria2Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q214:ArrayOfArchiveRestrictionInfo" xmlns:q214="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDynamicSelectionCriteria3">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="Criteria" nillable="true" type="q215:ArrayOfArchiveRestrictionInfo" xmlns:q215="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="Filter" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDynamicSelectionCriteria3Response">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q216:ArrayOfArchiveRestrictionInfo" xmlns:q216="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeletePersons">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeletePersonsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDynamicSelectionCriteriaGroups">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDynamicSelectionCriteriaGroupsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q217:ArrayOfArchiveRestrictionGroup" xmlns:q217="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfArchiveRestrictionGroup">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArchiveRestrictionGroup" nillable="true" type="q218:ArchiveRestrictionGroup" xmlns:q218="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArchiveRestrictionGroup" nillable="true" type="q219:ArrayOfArchiveRestrictionGroup" xmlns:q219="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArchiveRestrictionGroup">
        <xs:sequence>
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Rank" type="xs:short" />
          <xs:element minOccurs="0" name="Restrictions" nillable="true" type="q220:ArrayOfArchiveRestrictionInfo" xmlns:q220="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArchiveRestrictionGroup" nillable="true" type="q221:ArchiveRestrictionGroup" xmlns:q221="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="SetDynamicSelectionCriteriaGroups">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="Criteria" nillable="true" type="q222:ArrayOfArchiveRestrictionGroup" xmlns:q222="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetDynamicSelectionCriteriaGroupsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q223:ArrayOfArchiveRestrictionGroup" xmlns:q223="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteSelectionEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteSelectionEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectionForFind">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EntityName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TypicalSearchId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectionForFindResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q224:SelectionForFind" xmlns:q224="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SelectionForFind">
        <xs:complexContent mixed="false">
          <xs:extension base="q225:Carrier" xmlns:q225="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
              <xs:element minOccurs="0" name="CanSaveAsSelection" type="xs:boolean" />
              <xs:element minOccurs="0" name="MainHeading" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FilterScreenHeading" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SelectionEntityHeading" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SelectionForFind" nillable="true" type="q226:SelectionForFind" xmlns:q226="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetSelectionSummaries">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionIds" nillable="true" type="q227:ArrayOfint" xmlns:q227="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSelectionSummariesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q228:ArrayOfSelectionSummaryItem" xmlns:q228="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfSelectionSummaryItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="SelectionSummaryItem" nillable="true" type="q229:SelectionSummaryItem" xmlns:q229="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfSelectionSummaryItem" nillable="true" type="q230:ArrayOfSelectionSummaryItem" xmlns:q230="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SelectionSummaryItem">
        <xs:sequence>
          <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="TargetTable" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
          <xs:element minOccurs="0" name="ProviderName" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SelectionSummaryItem" nillable="true" type="q231:SelectionSummaryItem" xmlns:q231="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="UpdateTypicalSearch">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Searches" nillable="true" type="q232:TypicalSearches" xmlns:q232="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="TypicalSearches">
        <xs:complexContent mixed="false">
          <xs:extension base="q233:Carrier" xmlns:q233="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MasterVersion" type="xs:int" />
              <xs:element minOccurs="0" name="DeleteLeftovers" type="xs:boolean" />
              <xs:element minOccurs="0" name="Searches" nillable="true" type="q233:ArrayOfTypicalSearch" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TypicalSearches" nillable="true" type="q234:TypicalSearches" xmlns:q234="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfTypicalSearch">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TypicalSearch" nillable="true" type="q235:TypicalSearch" xmlns:q235="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTypicalSearch" nillable="true" type="q236:ArrayOfTypicalSearch" xmlns:q236="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TypicalSearch">
        <xs:complexContent mixed="false">
          <xs:extension base="q237:Carrier" xmlns:q237="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="TypicalSearchId" type="xs:int" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EntityName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsEntityDefault" type="xs:short" />
              <xs:element minOccurs="0" name="IncludePerson" type="xs:short" />
              <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="VersionNumber" type="xs:int" />
              <xs:element minOccurs="0" name="RestrictionGroups" nillable="true" type="q237:ArrayOfArchiveRestrictionGroup" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TypicalSearch" nillable="true" type="q238:TypicalSearch" xmlns:q238="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="UpdateTypicalSearchResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
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
      <xs:complexType name="ArrayOfstring">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="string" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfstring" nillable="true" type="tns:ArrayOfstring" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="CreateDefaultSelectionEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultSelectionEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSelectionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSelectionEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultSelectionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSelectionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSelectionEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveSelectionEntity" />
  </wsdl:message>
  <wsdl:message name="SaveSelectionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSelectionEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveSelectionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveSelectionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultBoardViewSettingsFromEntityTypeRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultBoardViewSettingsFromEntityType" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultBoardViewSettingsFromEntityTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultBoardViewSettingsFromEntityTypeResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultBoardViewSettingsFromEntityTypeResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultBoardViewSettingsFromEntityTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBoardViewSettingsRequest">
    <wsdl:part name="parameters" element="tns:GetBoardViewSettings" />
  </wsdl:message>
  <wsdl:message name="GetBoardViewSettingsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBoardViewSettingsResponse">
    <wsdl:part name="parameters" element="tns:GetBoardViewSettingsResponse" />
  </wsdl:message>
  <wsdl:message name="GetBoardViewSettingsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBoardViewSettingsForSelectionRequest">
    <wsdl:part name="parameters" element="tns:GetBoardViewSettingsForSelection" />
  </wsdl:message>
  <wsdl:message name="GetBoardViewSettingsForSelectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetBoardViewSettingsForSelectionResponse">
    <wsdl:part name="parameters" element="tns:GetBoardViewSettingsForSelectionResponse" />
  </wsdl:message>
  <wsdl:message name="GetBoardViewSettingsForSelectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveBoardViewSettingsRequest">
    <wsdl:part name="parameters" element="tns:SaveBoardViewSettings" />
  </wsdl:message>
  <wsdl:message name="SaveBoardViewSettingsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveBoardViewSettingsResponse">
    <wsdl:part name="parameters" element="tns:SaveBoardViewSettingsResponse" />
  </wsdl:message>
  <wsdl:message name="SaveBoardViewSettingsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveBoardViewSettingsForSelectionAndAssociateRequest">
    <wsdl:part name="parameters" element="tns:SaveBoardViewSettingsForSelectionAndAssociate" />
  </wsdl:message>
  <wsdl:message name="SaveBoardViewSettingsForSelectionAndAssociateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveBoardViewSettingsForSelectionAndAssociateResponse">
    <wsdl:part name="parameters" element="tns:SaveBoardViewSettingsForSelectionAndAssociateResponse" />
  </wsdl:message>
  <wsdl:message name="SaveBoardViewSettingsForSelectionAndAssociateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteBoardViewSettingsRequest">
    <wsdl:part name="parameters" element="tns:DeleteBoardViewSettings" />
  </wsdl:message>
  <wsdl:message name="DeleteBoardViewSettingsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteBoardViewSettingsResponse">
    <wsdl:part name="parameters" element="tns:DeleteBoardViewSettingsResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteBoardViewSettingsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectionEntityRequest">
    <wsdl:part name="parameters" element="tns:GetSelectionEntity" />
  </wsdl:message>
  <wsdl:message name="GetSelectionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectionEntityResponse">
    <wsdl:part name="parameters" element="tns:GetSelectionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetSelectionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateSelectionEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateSelectionEntity" />
  </wsdl:message>
  <wsdl:message name="CreateSelectionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateSelectionEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateSelectionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateSelectionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateContactSelectionFromSelectionRequest">
    <wsdl:part name="parameters" element="tns:CreateContactSelectionFromSelection" />
  </wsdl:message>
  <wsdl:message name="CreateContactSelectionFromSelectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateContactSelectionFromSelectionResponse">
    <wsdl:part name="parameters" element="tns:CreateContactSelectionFromSelectionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateContactSelectionFromSelectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromContactPersonIdsRequest">
    <wsdl:part name="parameters" element="tns:CreateTemporaryContactSelectionFromContactPersonIds" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromContactPersonIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromContactPersonIdsResponse">
    <wsdl:part name="parameters" element="tns:CreateTemporaryContactSelectionFromContactPersonIdsResponse" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromContactPersonIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopyContactSelectionMembersRequest">
    <wsdl:part name="parameters" element="tns:CopyContactSelectionMembers" />
  </wsdl:message>
  <wsdl:message name="CopyContactSelectionMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopyContactSelectionMembersResponse">
    <wsdl:part name="parameters" element="tns:CopyContactSelectionMembersResponse" />
  </wsdl:message>
  <wsdl:message name="CopyContactSelectionMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsRequest">
    <wsdl:part name="parameters" element="tns:GetRecipientStatistics" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsResponse">
    <wsdl:part name="parameters" element="tns:GetRecipientStatisticsResponse" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsFromProjectMembersRequest">
    <wsdl:part name="parameters" element="tns:GetRecipientStatisticsFromProjectMembers" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsFromProjectMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsFromProjectMembersResponse">
    <wsdl:part name="parameters" element="tns:GetRecipientStatisticsFromProjectMembersResponse" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsFromProjectMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsFromContactPersonIdsRequest">
    <wsdl:part name="parameters" element="tns:GetRecipientStatisticsFromContactPersonIds" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsFromContactPersonIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsFromContactPersonIdsResponse">
    <wsdl:part name="parameters" element="tns:GetRecipientStatisticsFromContactPersonIdsResponse" />
  </wsdl:message>
  <wsdl:message name="GetRecipientStatisticsFromContactPersonIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddContactSelectionMembersRequest">
    <wsdl:part name="parameters" element="tns:AddContactSelectionMembers" />
  </wsdl:message>
  <wsdl:message name="AddContactSelectionMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddContactSelectionMembersResponse">
    <wsdl:part name="parameters" element="tns:AddContactSelectionMembersResponse" />
  </wsdl:message>
  <wsdl:message name="AddContactSelectionMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersRequest">
    <wsdl:part name="parameters" element="tns:RemoveContactSelectionMembers" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersResponse">
    <wsdl:part name="parameters" element="tns:RemoveContactSelectionMembersResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersFromIdsRequest">
    <wsdl:part name="parameters" element="tns:RemoveContactSelectionMembersFromIds" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersFromIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersFromIdsResponse">
    <wsdl:part name="parameters" element="tns:RemoveContactSelectionMembersFromIdsResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersFromIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddContactSelectionMembersFromSearchRequest">
    <wsdl:part name="parameters" element="tns:AddContactSelectionMembersFromSearch" />
  </wsdl:message>
  <wsdl:message name="AddContactSelectionMembersFromSearchRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddContactSelectionMembersFromSearchResponse">
    <wsdl:part name="parameters" element="tns:AddContactSelectionMembersFromSearchResponse" />
  </wsdl:message>
  <wsdl:message name="AddContactSelectionMembersFromSearchResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersFromSearchRequest">
    <wsdl:part name="parameters" element="tns:RemoveContactSelectionMembersFromSearch" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersFromSearchRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersFromSearchResponse">
    <wsdl:part name="parameters" element="tns:RemoveContactSelectionMembersFromSearchResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveContactSelectionMembersFromSearchResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionRequest">
    <wsdl:part name="parameters" element="tns:CreateTemporaryContactSelection" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionResponse">
    <wsdl:part name="parameters" element="tns:CreateTemporaryContactSelectionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromSelectionMemberIdsRequest">
    <wsdl:part name="parameters" element="tns:CreateTemporaryContactSelectionFromSelectionMemberIds" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromSelectionMemberIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromSelectionMemberIdsResponse">
    <wsdl:part name="parameters" element="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsResponse" />
  </wsdl:message>
  <wsdl:message name="CreateTemporaryContactSelectionFromSelectionMemberIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddRemoveContactSelectionMemberInterestsRequest">
    <wsdl:part name="parameters" element="tns:AddRemoveContactSelectionMemberInterests" />
  </wsdl:message>
  <wsdl:message name="AddRemoveContactSelectionMemberInterestsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddRemoveContactSelectionMemberInterestsResponse">
    <wsdl:part name="parameters" element="tns:AddRemoveContactSelectionMemberInterestsResponse" />
  </wsdl:message>
  <wsdl:message name="AddRemoveContactSelectionMemberInterestsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="EditContactSelectionMemberDetailsRequest">
    <wsdl:part name="parameters" element="tns:EditContactSelectionMemberDetails" />
  </wsdl:message>
  <wsdl:message name="EditContactSelectionMemberDetailsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="EditContactSelectionMemberDetailsResponse">
    <wsdl:part name="parameters" element="tns:EditContactSelectionMemberDetailsResponse" />
  </wsdl:message>
  <wsdl:message name="EditContactSelectionMemberDetailsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GenerateFollowUpsRequest">
    <wsdl:part name="parameters" element="tns:GenerateFollowUps" />
  </wsdl:message>
  <wsdl:message name="GenerateFollowUpsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GenerateFollowUpsResponse">
    <wsdl:part name="parameters" element="tns:GenerateFollowUpsResponse" />
  </wsdl:message>
  <wsdl:message name="GenerateFollowUpsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExportSelectionMembersRequest">
    <wsdl:part name="parameters" element="tns:ExportSelectionMembers" />
  </wsdl:message>
  <wsdl:message name="ExportSelectionMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExportSelectionMembersResponse">
    <wsdl:part name="parameters" element="tns:ExportSelectionMembersResponse" />
  </wsdl:message>
  <wsdl:message name="ExportSelectionMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExportSelectionMembersWithOrderByRequest">
    <wsdl:part name="parameters" element="tns:ExportSelectionMembersWithOrderBy" />
  </wsdl:message>
  <wsdl:message name="ExportSelectionMembersWithOrderByRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExportSelectionMembersWithOrderByResponse">
    <wsdl:part name="parameters" element="tns:ExportSelectionMembersWithOrderByResponse" />
  </wsdl:message>
  <wsdl:message name="ExportSelectionMembersWithOrderByResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDuplicateRulesStatusRequest">
    <wsdl:part name="parameters" element="tns:SetDuplicateRulesStatus" />
  </wsdl:message>
  <wsdl:message name="SetDuplicateRulesStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDuplicateRulesStatusResponse">
    <wsdl:part name="parameters" element="tns:SetDuplicateRulesStatusResponse" />
  </wsdl:message>
  <wsdl:message name="SetDuplicateRulesStatusResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDuplicatesRequest">
    <wsdl:part name="parameters" element="tns:GetDuplicates" />
  </wsdl:message>
  <wsdl:message name="GetDuplicatesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDuplicatesResponse">
    <wsdl:part name="parameters" element="tns:GetDuplicatesResponse" />
  </wsdl:message>
  <wsdl:message name="GetDuplicatesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDuplicateRulesRequest">
    <wsdl:part name="parameters" element="tns:GetDuplicateRules" />
  </wsdl:message>
  <wsdl:message name="GetDuplicateRulesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDuplicateRulesResponse">
    <wsdl:part name="parameters" element="tns:GetDuplicateRulesResponse" />
  </wsdl:message>
  <wsdl:message name="GetDuplicateRulesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateNewEntryRequest">
    <wsdl:part name="parameters" element="tns:CreateNewEntry" />
  </wsdl:message>
  <wsdl:message name="CreateNewEntryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateNewEntryResponse">
    <wsdl:part name="parameters" element="tns:CreateNewEntryResponse" />
  </wsdl:message>
  <wsdl:message name="CreateNewEntryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteContactsRequest">
    <wsdl:part name="parameters" element="tns:DeleteContacts" />
  </wsdl:message>
  <wsdl:message name="DeleteContactsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteContactsResponse">
    <wsdl:part name="parameters" element="tns:DeleteContactsResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteContactsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddSelectionMembersRequest">
    <wsdl:part name="parameters" element="tns:AddSelectionMembers" />
  </wsdl:message>
  <wsdl:message name="AddSelectionMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddSelectionMembersResponse">
    <wsdl:part name="parameters" element="tns:AddSelectionMembersResponse" />
  </wsdl:message>
  <wsdl:message name="AddSelectionMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersRequest">
    <wsdl:part name="parameters" element="tns:RemoveSelectionMembers" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersResponse">
    <wsdl:part name="parameters" element="tns:RemoveSelectionMembersResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersByIdRequest">
    <wsdl:part name="parameters" element="tns:RemoveSelectionMembersById" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersByIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersByIdResponse">
    <wsdl:part name="parameters" element="tns:RemoveSelectionMembersByIdResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersByIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddSelectionMembersFromSearchRequest">
    <wsdl:part name="parameters" element="tns:AddSelectionMembersFromSearch" />
  </wsdl:message>
  <wsdl:message name="AddSelectionMembersFromSearchRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddSelectionMembersFromSearchResponse">
    <wsdl:part name="parameters" element="tns:AddSelectionMembersFromSearchResponse" />
  </wsdl:message>
  <wsdl:message name="AddSelectionMembersFromSearchResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersFromSearchRequest">
    <wsdl:part name="parameters" element="tns:RemoveSelectionMembersFromSearch" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersFromSearchRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersFromSearchResponse">
    <wsdl:part name="parameters" element="tns:RemoveSelectionMembersFromSearchResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveSelectionMembersFromSearchResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopySelectionMembersRequest">
    <wsdl:part name="parameters" element="tns:CopySelectionMembers" />
  </wsdl:message>
  <wsdl:message name="CopySelectionMembersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopySelectionMembersResponse">
    <wsdl:part name="parameters" element="tns:CopySelectionMembersResponse" />
  </wsdl:message>
  <wsdl:message name="CopySelectionMembersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporarySelectionFromIdsRequest">
    <wsdl:part name="parameters" element="tns:CreateTemporarySelectionFromIds" />
  </wsdl:message>
  <wsdl:message name="CreateTemporarySelectionFromIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateTemporarySelectionFromIdsResponse">
    <wsdl:part name="parameters" element="tns:CreateTemporarySelectionFromIdsResponse" />
  </wsdl:message>
  <wsdl:message name="CreateTemporarySelectionFromIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateSelectionFromSelectionRequest">
    <wsdl:part name="parameters" element="tns:CreateSelectionFromSelection" />
  </wsdl:message>
  <wsdl:message name="CreateSelectionFromSelectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateSelectionFromSelectionResponse">
    <wsdl:part name="parameters" element="tns:CreateSelectionFromSelectionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateSelectionFromSelectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateContactSelectionFromShadowSelectionRequest">
    <wsdl:part name="parameters" element="tns:CreateContactSelectionFromShadowSelection" />
  </wsdl:message>
  <wsdl:message name="CreateContactSelectionFromShadowSelectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateContactSelectionFromShadowSelectionResponse">
    <wsdl:part name="parameters" element="tns:CreateContactSelectionFromShadowSelectionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateContactSelectionFromShadowSelectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteEntitiesRequest">
    <wsdl:part name="parameters" element="tns:DeleteEntities" />
  </wsdl:message>
  <wsdl:message name="DeleteEntitiesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteEntitiesResponse">
    <wsdl:part name="parameters" element="tns:DeleteEntitiesResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteEntitiesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetParentCombinedSelectionsRequest">
    <wsdl:part name="parameters" element="tns:GetParentCombinedSelections" />
  </wsdl:message>
  <wsdl:message name="GetParentCombinedSelectionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetParentCombinedSelectionsResponse">
    <wsdl:part name="parameters" element="tns:GetParentCombinedSelectionsResponse" />
  </wsdl:message>
  <wsdl:message name="GetParentCombinedSelectionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectionMembersArchiveRowsRequest">
    <wsdl:part name="parameters" element="tns:GetSelectionMembersArchiveRows" />
  </wsdl:message>
  <wsdl:message name="GetSelectionMembersArchiveRowsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectionMembersArchiveRowsResponse">
    <wsdl:part name="parameters" element="tns:GetSelectionMembersArchiveRowsResponse" />
  </wsdl:message>
  <wsdl:message name="GetSelectionMembersArchiveRowsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectionShadowMembersArchiveRowsRequest">
    <wsdl:part name="parameters" element="tns:GetSelectionShadowMembersArchiveRows" />
  </wsdl:message>
  <wsdl:message name="GetSelectionShadowMembersArchiveRowsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectionShadowMembersArchiveRowsResponse">
    <wsdl:part name="parameters" element="tns:GetSelectionShadowMembersArchiveRowsResponse" />
  </wsdl:message>
  <wsdl:message name="GetSelectionShadowMembersArchiveRowsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDynamicSelectionCriteriaRequest">
    <wsdl:part name="parameters" element="tns:GetDynamicSelectionCriteria" />
  </wsdl:message>
  <wsdl:message name="GetDynamicSelectionCriteriaRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDynamicSelectionCriteriaResponse">
    <wsdl:part name="parameters" element="tns:GetDynamicSelectionCriteriaResponse" />
  </wsdl:message>
  <wsdl:message name="GetDynamicSelectionCriteriaResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDynamicSelectionCriteriaRequest">
    <wsdl:part name="parameters" element="tns:SetDynamicSelectionCriteria" />
  </wsdl:message>
  <wsdl:message name="SetDynamicSelectionCriteriaRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDynamicSelectionCriteriaResponse">
    <wsdl:part name="parameters" element="tns:SetDynamicSelectionCriteriaResponse" />
  </wsdl:message>
  <wsdl:message name="SetDynamicSelectionCriteriaResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDynamicSelectionCriteria2Request">
    <wsdl:part name="parameters" element="tns:SetDynamicSelectionCriteria2" />
  </wsdl:message>
  <wsdl:message name="SetDynamicSelectionCriteria2Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDynamicSelectionCriteria2Response">
    <wsdl:part name="parameters" element="tns:SetDynamicSelectionCriteria2Response" />
  </wsdl:message>
  <wsdl:message name="SetDynamicSelectionCriteria2Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDynamicSelectionCriteria3Request">
    <wsdl:part name="parameters" element="tns:SetDynamicSelectionCriteria3" />
  </wsdl:message>
  <wsdl:message name="SetDynamicSelectionCriteria3Request_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDynamicSelectionCriteria3Response">
    <wsdl:part name="parameters" element="tns:SetDynamicSelectionCriteria3Response" />
  </wsdl:message>
  <wsdl:message name="SetDynamicSelectionCriteria3Response_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeletePersonsRequest">
    <wsdl:part name="parameters" element="tns:DeletePersons" />
  </wsdl:message>
  <wsdl:message name="DeletePersonsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeletePersonsResponse">
    <wsdl:part name="parameters" element="tns:DeletePersonsResponse" />
  </wsdl:message>
  <wsdl:message name="DeletePersonsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDynamicSelectionCriteriaGroupsRequest">
    <wsdl:part name="parameters" element="tns:GetDynamicSelectionCriteriaGroups" />
  </wsdl:message>
  <wsdl:message name="GetDynamicSelectionCriteriaGroupsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDynamicSelectionCriteriaGroupsResponse">
    <wsdl:part name="parameters" element="tns:GetDynamicSelectionCriteriaGroupsResponse" />
  </wsdl:message>
  <wsdl:message name="GetDynamicSelectionCriteriaGroupsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDynamicSelectionCriteriaGroupsRequest">
    <wsdl:part name="parameters" element="tns:SetDynamicSelectionCriteriaGroups" />
  </wsdl:message>
  <wsdl:message name="SetDynamicSelectionCriteriaGroupsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetDynamicSelectionCriteriaGroupsResponse">
    <wsdl:part name="parameters" element="tns:SetDynamicSelectionCriteriaGroupsResponse" />
  </wsdl:message>
  <wsdl:message name="SetDynamicSelectionCriteriaGroupsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteSelectionEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteSelectionEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteSelectionEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteSelectionEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteSelectionEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteSelectionEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectionForFindRequest">
    <wsdl:part name="parameters" element="tns:GetSelectionForFind" />
  </wsdl:message>
  <wsdl:message name="GetSelectionForFindRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectionForFindResponse">
    <wsdl:part name="parameters" element="tns:GetSelectionForFindResponse" />
  </wsdl:message>
  <wsdl:message name="GetSelectionForFindResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectionSummariesRequest">
    <wsdl:part name="parameters" element="tns:GetSelectionSummaries" />
  </wsdl:message>
  <wsdl:message name="GetSelectionSummariesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSelectionSummariesResponse">
    <wsdl:part name="parameters" element="tns:GetSelectionSummariesResponse" />
  </wsdl:message>
  <wsdl:message name="GetSelectionSummariesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateTypicalSearchRequest">
    <wsdl:part name="parameters" element="tns:UpdateTypicalSearch" />
  </wsdl:message>
  <wsdl:message name="UpdateTypicalSearchRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateTypicalSearchResponse">
    <wsdl:part name="parameters" element="tns:UpdateTypicalSearchResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateTypicalSearchResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Selection">
    <wsdl:operation name="CreateDefaultSelectionEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateDefaultSelectionEntity" name="CreateDefaultSelectionEntityRequest" message="tns:CreateDefaultSelectionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateDefaultSelectionEntityResponse" name="CreateDefaultSelectionEntityResponse" message="tns:CreateDefaultSelectionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveSelectionEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SaveSelectionEntity" name="SaveSelectionEntityRequest" message="tns:SaveSelectionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SaveSelectionEntityResponse" name="SaveSelectionEntityResponse" message="tns:SaveSelectionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultBoardViewSettingsFromEntityType">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateDefaultBoardViewSettingsFromEntityType" name="CreateDefaultBoardViewSettingsFromEntityTypeRequest" message="tns:CreateDefaultBoardViewSettingsFromEntityTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateDefaultBoardViewSettingsFromEntityTypeResponse" name="CreateDefaultBoardViewSettingsFromEntityTypeResponse" message="tns:CreateDefaultBoardViewSettingsFromEntityTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBoardViewSettings">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetBoardViewSettings" name="GetBoardViewSettingsRequest" message="tns:GetBoardViewSettingsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetBoardViewSettingsResponse" name="GetBoardViewSettingsResponse" message="tns:GetBoardViewSettingsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetBoardViewSettingsForSelection">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetBoardViewSettingsForSelection" name="GetBoardViewSettingsForSelectionRequest" message="tns:GetBoardViewSettingsForSelectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetBoardViewSettingsForSelectionResponse" name="GetBoardViewSettingsForSelectionResponse" message="tns:GetBoardViewSettingsForSelectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveBoardViewSettings">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SaveBoardViewSettings" name="SaveBoardViewSettingsRequest" message="tns:SaveBoardViewSettingsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SaveBoardViewSettingsResponse" name="SaveBoardViewSettingsResponse" message="tns:SaveBoardViewSettingsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveBoardViewSettingsForSelectionAndAssociate">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SaveBoardViewSettingsForSelectionAndAssociate" name="SaveBoardViewSettingsForSelectionAndAssociateRequest" message="tns:SaveBoardViewSettingsForSelectionAndAssociateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SaveBoardViewSettingsForSelectionAndAssociateResponse" name="SaveBoardViewSettingsForSelectionAndAssociateResponse" message="tns:SaveBoardViewSettingsForSelectionAndAssociateResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteBoardViewSettings">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/DeleteBoardViewSettings" name="DeleteBoardViewSettingsRequest" message="tns:DeleteBoardViewSettingsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/DeleteBoardViewSettingsResponse" name="DeleteBoardViewSettingsResponse" message="tns:DeleteBoardViewSettingsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSelectionEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetSelectionEntity" name="GetSelectionEntityRequest" message="tns:GetSelectionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetSelectionEntityResponse" name="GetSelectionEntityResponse" message="tns:GetSelectionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateSelectionEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateSelectionEntity" name="CreateSelectionEntityRequest" message="tns:CreateSelectionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateSelectionEntityResponse" name="CreateSelectionEntityResponse" message="tns:CreateSelectionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateContactSelectionFromSelection">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateContactSelectionFromSelection" name="CreateContactSelectionFromSelectionRequest" message="tns:CreateContactSelectionFromSelectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateContactSelectionFromSelectionResponse" name="CreateContactSelectionFromSelectionResponse" message="tns:CreateContactSelectionFromSelectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateTemporaryContactSelectionFromContactPersonIds">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateTemporaryContactSelectionFromContactPersonIds" name="CreateTemporaryContactSelectionFromContactPersonIdsRequest" message="tns:CreateTemporaryContactSelectionFromContactPersonIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateTemporaryContactSelectionFromContactPersonIdsResponse" name="CreateTemporaryContactSelectionFromContactPersonIdsResponse" message="tns:CreateTemporaryContactSelectionFromContactPersonIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CopyContactSelectionMembers">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CopyContactSelectionMembers" name="CopyContactSelectionMembersRequest" message="tns:CopyContactSelectionMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CopyContactSelectionMembersResponse" name="CopyContactSelectionMembersResponse" message="tns:CopyContactSelectionMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetRecipientStatistics">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetRecipientStatistics" name="GetRecipientStatisticsRequest" message="tns:GetRecipientStatisticsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetRecipientStatisticsResponse" name="GetRecipientStatisticsResponse" message="tns:GetRecipientStatisticsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetRecipientStatisticsFromProjectMembers">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetRecipientStatisticsFromProjectMembers" name="GetRecipientStatisticsFromProjectMembersRequest" message="tns:GetRecipientStatisticsFromProjectMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetRecipientStatisticsFromProjectMembersResponse" name="GetRecipientStatisticsFromProjectMembersResponse" message="tns:GetRecipientStatisticsFromProjectMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetRecipientStatisticsFromContactPersonIds">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetRecipientStatisticsFromContactPersonIds" name="GetRecipientStatisticsFromContactPersonIdsRequest" message="tns:GetRecipientStatisticsFromContactPersonIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetRecipientStatisticsFromContactPersonIdsResponse" name="GetRecipientStatisticsFromContactPersonIdsResponse" message="tns:GetRecipientStatisticsFromContactPersonIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddContactSelectionMembers">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/AddContactSelectionMembers" name="AddContactSelectionMembersRequest" message="tns:AddContactSelectionMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/AddContactSelectionMembersResponse" name="AddContactSelectionMembersResponse" message="tns:AddContactSelectionMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveContactSelectionMembers">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/RemoveContactSelectionMembers" name="RemoveContactSelectionMembersRequest" message="tns:RemoveContactSelectionMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/RemoveContactSelectionMembersResponse" name="RemoveContactSelectionMembersResponse" message="tns:RemoveContactSelectionMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveContactSelectionMembersFromIds">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/RemoveContactSelectionMembersFromIds" name="RemoveContactSelectionMembersFromIdsRequest" message="tns:RemoveContactSelectionMembersFromIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/RemoveContactSelectionMembersFromIdsResponse" name="RemoveContactSelectionMembersFromIdsResponse" message="tns:RemoveContactSelectionMembersFromIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddContactSelectionMembersFromSearch">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/AddContactSelectionMembersFromSearch" name="AddContactSelectionMembersFromSearchRequest" message="tns:AddContactSelectionMembersFromSearchRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/AddContactSelectionMembersFromSearchResponse" name="AddContactSelectionMembersFromSearchResponse" message="tns:AddContactSelectionMembersFromSearchResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveContactSelectionMembersFromSearch">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/RemoveContactSelectionMembersFromSearch" name="RemoveContactSelectionMembersFromSearchRequest" message="tns:RemoveContactSelectionMembersFromSearchRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/RemoveContactSelectionMembersFromSearchResponse" name="RemoveContactSelectionMembersFromSearchResponse" message="tns:RemoveContactSelectionMembersFromSearchResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateTemporaryContactSelection">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateTemporaryContactSelection" name="CreateTemporaryContactSelectionRequest" message="tns:CreateTemporaryContactSelectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateTemporaryContactSelectionResponse" name="CreateTemporaryContactSelectionResponse" message="tns:CreateTemporaryContactSelectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateTemporaryContactSelectionFromSelectionMemberIds">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateTemporaryContactSelectionFromSelectionMemberIds" name="CreateTemporaryContactSelectionFromSelectionMemberIdsRequest" message="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateTemporaryContactSelectionFromSelectionMemberIdsResponse" name="CreateTemporaryContactSelectionFromSelectionMemberIdsResponse" message="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddRemoveContactSelectionMemberInterests">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/AddRemoveContactSelectionMemberInterests" name="AddRemoveContactSelectionMemberInterestsRequest" message="tns:AddRemoveContactSelectionMemberInterestsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/AddRemoveContactSelectionMemberInterestsResponse" name="AddRemoveContactSelectionMemberInterestsResponse" message="tns:AddRemoveContactSelectionMemberInterestsResponse" />
    </wsdl:operation>
    <wsdl:operation name="EditContactSelectionMemberDetails">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/EditContactSelectionMemberDetails" name="EditContactSelectionMemberDetailsRequest" message="tns:EditContactSelectionMemberDetailsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/EditContactSelectionMemberDetailsResponse" name="EditContactSelectionMemberDetailsResponse" message="tns:EditContactSelectionMemberDetailsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GenerateFollowUps">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GenerateFollowUps" name="GenerateFollowUpsRequest" message="tns:GenerateFollowUpsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GenerateFollowUpsResponse" name="GenerateFollowUpsResponse" message="tns:GenerateFollowUpsResponse" />
    </wsdl:operation>
    <wsdl:operation name="ExportSelectionMembers">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/ExportSelectionMembers" name="ExportSelectionMembersRequest" message="tns:ExportSelectionMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/ExportSelectionMembersResponse" name="ExportSelectionMembersResponse" message="tns:ExportSelectionMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="ExportSelectionMembersWithOrderBy">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/ExportSelectionMembersWithOrderBy" name="ExportSelectionMembersWithOrderByRequest" message="tns:ExportSelectionMembersWithOrderByRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/ExportSelectionMembersWithOrderByResponse" name="ExportSelectionMembersWithOrderByResponse" message="tns:ExportSelectionMembersWithOrderByResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetDuplicateRulesStatus">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SetDuplicateRulesStatus" name="SetDuplicateRulesStatusRequest" message="tns:SetDuplicateRulesStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SetDuplicateRulesStatusResponse" name="SetDuplicateRulesStatusResponse" message="tns:SetDuplicateRulesStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDuplicates">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetDuplicates" name="GetDuplicatesRequest" message="tns:GetDuplicatesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetDuplicatesResponse" name="GetDuplicatesResponse" message="tns:GetDuplicatesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDuplicateRules">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetDuplicateRules" name="GetDuplicateRulesRequest" message="tns:GetDuplicateRulesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetDuplicateRulesResponse" name="GetDuplicateRulesResponse" message="tns:GetDuplicateRulesResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateNewEntry">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateNewEntry" name="CreateNewEntryRequest" message="tns:CreateNewEntryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateNewEntryResponse" name="CreateNewEntryResponse" message="tns:CreateNewEntryResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteContacts">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/DeleteContacts" name="DeleteContactsRequest" message="tns:DeleteContactsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/DeleteContactsResponse" name="DeleteContactsResponse" message="tns:DeleteContactsResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddSelectionMembers">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/AddSelectionMembers" name="AddSelectionMembersRequest" message="tns:AddSelectionMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/AddSelectionMembersResponse" name="AddSelectionMembersResponse" message="tns:AddSelectionMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveSelectionMembers">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/RemoveSelectionMembers" name="RemoveSelectionMembersRequest" message="tns:RemoveSelectionMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/RemoveSelectionMembersResponse" name="RemoveSelectionMembersResponse" message="tns:RemoveSelectionMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveSelectionMembersById">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/RemoveSelectionMembersById" name="RemoveSelectionMembersByIdRequest" message="tns:RemoveSelectionMembersByIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/RemoveSelectionMembersByIdResponse" name="RemoveSelectionMembersByIdResponse" message="tns:RemoveSelectionMembersByIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddSelectionMembersFromSearch">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/AddSelectionMembersFromSearch" name="AddSelectionMembersFromSearchRequest" message="tns:AddSelectionMembersFromSearchRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/AddSelectionMembersFromSearchResponse" name="AddSelectionMembersFromSearchResponse" message="tns:AddSelectionMembersFromSearchResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveSelectionMembersFromSearch">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/RemoveSelectionMembersFromSearch" name="RemoveSelectionMembersFromSearchRequest" message="tns:RemoveSelectionMembersFromSearchRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/RemoveSelectionMembersFromSearchResponse" name="RemoveSelectionMembersFromSearchResponse" message="tns:RemoveSelectionMembersFromSearchResponse" />
    </wsdl:operation>
    <wsdl:operation name="CopySelectionMembers">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CopySelectionMembers" name="CopySelectionMembersRequest" message="tns:CopySelectionMembersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CopySelectionMembersResponse" name="CopySelectionMembersResponse" message="tns:CopySelectionMembersResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateTemporarySelectionFromIds">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateTemporarySelectionFromIds" name="CreateTemporarySelectionFromIdsRequest" message="tns:CreateTemporarySelectionFromIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateTemporarySelectionFromIdsResponse" name="CreateTemporarySelectionFromIdsResponse" message="tns:CreateTemporarySelectionFromIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateSelectionFromSelection">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateSelectionFromSelection" name="CreateSelectionFromSelectionRequest" message="tns:CreateSelectionFromSelectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateSelectionFromSelectionResponse" name="CreateSelectionFromSelectionResponse" message="tns:CreateSelectionFromSelectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateContactSelectionFromShadowSelection">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateContactSelectionFromShadowSelection" name="CreateContactSelectionFromShadowSelectionRequest" message="tns:CreateContactSelectionFromShadowSelectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateContactSelectionFromShadowSelectionResponse" name="CreateContactSelectionFromShadowSelectionResponse" message="tns:CreateContactSelectionFromShadowSelectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteEntities">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/DeleteEntities" name="DeleteEntitiesRequest" message="tns:DeleteEntitiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/DeleteEntitiesResponse" name="DeleteEntitiesResponse" message="tns:DeleteEntitiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetParentCombinedSelections">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetParentCombinedSelections" name="GetParentCombinedSelectionsRequest" message="tns:GetParentCombinedSelectionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetParentCombinedSelectionsResponse" name="GetParentCombinedSelectionsResponse" message="tns:GetParentCombinedSelectionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSelectionMembersArchiveRows">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetSelectionMembersArchiveRows" name="GetSelectionMembersArchiveRowsRequest" message="tns:GetSelectionMembersArchiveRowsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetSelectionMembersArchiveRowsResponse" name="GetSelectionMembersArchiveRowsResponse" message="tns:GetSelectionMembersArchiveRowsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSelectionShadowMembersArchiveRows">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetSelectionShadowMembersArchiveRows" name="GetSelectionShadowMembersArchiveRowsRequest" message="tns:GetSelectionShadowMembersArchiveRowsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetSelectionShadowMembersArchiveRowsResponse" name="GetSelectionShadowMembersArchiveRowsResponse" message="tns:GetSelectionShadowMembersArchiveRowsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDynamicSelectionCriteria">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetDynamicSelectionCriteria" name="GetDynamicSelectionCriteriaRequest" message="tns:GetDynamicSelectionCriteriaRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetDynamicSelectionCriteriaResponse" name="GetDynamicSelectionCriteriaResponse" message="tns:GetDynamicSelectionCriteriaResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetDynamicSelectionCriteria">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SetDynamicSelectionCriteria" name="SetDynamicSelectionCriteriaRequest" message="tns:SetDynamicSelectionCriteriaRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SetDynamicSelectionCriteriaResponse" name="SetDynamicSelectionCriteriaResponse" message="tns:SetDynamicSelectionCriteriaResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetDynamicSelectionCriteria2">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SetDynamicSelectionCriteria2" name="SetDynamicSelectionCriteria2Request" message="tns:SetDynamicSelectionCriteria2Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SetDynamicSelectionCriteria2Response" name="SetDynamicSelectionCriteria2Response" message="tns:SetDynamicSelectionCriteria2Response" />
    </wsdl:operation>
    <wsdl:operation name="SetDynamicSelectionCriteria3">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SetDynamicSelectionCriteria3" name="SetDynamicSelectionCriteria3Request" message="tns:SetDynamicSelectionCriteria3Request" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SetDynamicSelectionCriteria3Response" name="SetDynamicSelectionCriteria3Response" message="tns:SetDynamicSelectionCriteria3Response" />
    </wsdl:operation>
    <wsdl:operation name="DeletePersons">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/DeletePersons" name="DeletePersonsRequest" message="tns:DeletePersonsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/DeletePersonsResponse" name="DeletePersonsResponse" message="tns:DeletePersonsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDynamicSelectionCriteriaGroups">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetDynamicSelectionCriteriaGroups" name="GetDynamicSelectionCriteriaGroupsRequest" message="tns:GetDynamicSelectionCriteriaGroupsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetDynamicSelectionCriteriaGroupsResponse" name="GetDynamicSelectionCriteriaGroupsResponse" message="tns:GetDynamicSelectionCriteriaGroupsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetDynamicSelectionCriteriaGroups">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SetDynamicSelectionCriteriaGroups" name="SetDynamicSelectionCriteriaGroupsRequest" message="tns:SetDynamicSelectionCriteriaGroupsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SetDynamicSelectionCriteriaGroupsResponse" name="SetDynamicSelectionCriteriaGroupsResponse" message="tns:SetDynamicSelectionCriteriaGroupsResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteSelectionEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/DeleteSelectionEntity" name="DeleteSelectionEntityRequest" message="tns:DeleteSelectionEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/DeleteSelectionEntityResponse" name="DeleteSelectionEntityResponse" message="tns:DeleteSelectionEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSelectionForFind">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetSelectionForFind" name="GetSelectionForFindRequest" message="tns:GetSelectionForFindRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetSelectionForFindResponse" name="GetSelectionForFindResponse" message="tns:GetSelectionForFindResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSelectionSummaries">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetSelectionSummaries" name="GetSelectionSummariesRequest" message="tns:GetSelectionSummariesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetSelectionSummariesResponse" name="GetSelectionSummariesResponse" message="tns:GetSelectionSummariesResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateTypicalSearch">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/UpdateTypicalSearch" name="UpdateTypicalSearchRequest" message="tns:UpdateTypicalSearchRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/UpdateTypicalSearchResponse" name="UpdateTypicalSearchResponse" message="tns:UpdateTypicalSearchResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Selection" type="tns:Selection">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultSelectionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateDefaultSelectionEntity" style="document" />
      <wsdl:input name="CreateDefaultSelectionEntityRequest">
        <soap:header message="tns:CreateDefaultSelectionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultSelectionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultSelectionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultSelectionEntityResponse">
        <soap:header message="tns:CreateDefaultSelectionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSelectionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSelectionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultSelectionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveSelectionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SaveSelectionEntity" style="document" />
      <wsdl:input name="SaveSelectionEntityRequest">
        <soap:header message="tns:SaveSelectionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveSelectionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveSelectionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveSelectionEntityResponse">
        <soap:header message="tns:SaveSelectionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveSelectionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveSelectionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveSelectionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultBoardViewSettingsFromEntityType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateDefaultBoardViewSettingsFromEntityType" style="document" />
      <wsdl:input name="CreateDefaultBoardViewSettingsFromEntityTypeRequest">
        <soap:header message="tns:CreateDefaultBoardViewSettingsFromEntityTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultBoardViewSettingsFromEntityTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultBoardViewSettingsFromEntityTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultBoardViewSettingsFromEntityTypeResponse">
        <soap:header message="tns:CreateDefaultBoardViewSettingsFromEntityTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultBoardViewSettingsFromEntityTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultBoardViewSettingsFromEntityTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultBoardViewSettingsFromEntityTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBoardViewSettings">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetBoardViewSettings" style="document" />
      <wsdl:input name="GetBoardViewSettingsRequest">
        <soap:header message="tns:GetBoardViewSettingsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBoardViewSettingsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBoardViewSettingsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBoardViewSettingsResponse">
        <soap:header message="tns:GetBoardViewSettingsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBoardViewSettingsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBoardViewSettingsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBoardViewSettingsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetBoardViewSettingsForSelection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetBoardViewSettingsForSelection" style="document" />
      <wsdl:input name="GetBoardViewSettingsForSelectionRequest">
        <soap:header message="tns:GetBoardViewSettingsForSelectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetBoardViewSettingsForSelectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetBoardViewSettingsForSelectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetBoardViewSettingsForSelectionResponse">
        <soap:header message="tns:GetBoardViewSettingsForSelectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetBoardViewSettingsForSelectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetBoardViewSettingsForSelectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetBoardViewSettingsForSelectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveBoardViewSettings">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SaveBoardViewSettings" style="document" />
      <wsdl:input name="SaveBoardViewSettingsRequest">
        <soap:header message="tns:SaveBoardViewSettingsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveBoardViewSettingsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveBoardViewSettingsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveBoardViewSettingsResponse">
        <soap:header message="tns:SaveBoardViewSettingsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveBoardViewSettingsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveBoardViewSettingsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveBoardViewSettingsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveBoardViewSettingsForSelectionAndAssociate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SaveBoardViewSettingsForSelectionAndAssociate" style="document" />
      <wsdl:input name="SaveBoardViewSettingsForSelectionAndAssociateRequest">
        <soap:header message="tns:SaveBoardViewSettingsForSelectionAndAssociateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveBoardViewSettingsForSelectionAndAssociateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveBoardViewSettingsForSelectionAndAssociateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveBoardViewSettingsForSelectionAndAssociateResponse">
        <soap:header message="tns:SaveBoardViewSettingsForSelectionAndAssociateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveBoardViewSettingsForSelectionAndAssociateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveBoardViewSettingsForSelectionAndAssociateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveBoardViewSettingsForSelectionAndAssociateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteBoardViewSettings">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/DeleteBoardViewSettings" style="document" />
      <wsdl:input name="DeleteBoardViewSettingsRequest">
        <soap:header message="tns:DeleteBoardViewSettingsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteBoardViewSettingsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteBoardViewSettingsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteBoardViewSettingsResponse">
        <soap:header message="tns:DeleteBoardViewSettingsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteBoardViewSettingsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteBoardViewSettingsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteBoardViewSettingsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSelectionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetSelectionEntity" style="document" />
      <wsdl:input name="GetSelectionEntityRequest">
        <soap:header message="tns:GetSelectionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSelectionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSelectionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSelectionEntityResponse">
        <soap:header message="tns:GetSelectionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSelectionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSelectionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSelectionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateSelectionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateSelectionEntity" style="document" />
      <wsdl:input name="CreateSelectionEntityRequest">
        <soap:header message="tns:CreateSelectionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateSelectionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateSelectionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateSelectionEntityResponse">
        <soap:header message="tns:CreateSelectionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateSelectionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateSelectionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateSelectionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateContactSelectionFromSelection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateContactSelectionFromSelection" style="document" />
      <wsdl:input name="CreateContactSelectionFromSelectionRequest">
        <soap:header message="tns:CreateContactSelectionFromSelectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromSelectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromSelectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateContactSelectionFromSelectionResponse">
        <soap:header message="tns:CreateContactSelectionFromSelectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromSelectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromSelectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromSelectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateTemporaryContactSelectionFromContactPersonIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateTemporaryContactSelectionFromContactPersonIds" style="document" />
      <wsdl:input name="CreateTemporaryContactSelectionFromContactPersonIdsRequest">
        <soap:header message="tns:CreateTemporaryContactSelectionFromContactPersonIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromContactPersonIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromContactPersonIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateTemporaryContactSelectionFromContactPersonIdsResponse">
        <soap:header message="tns:CreateTemporaryContactSelectionFromContactPersonIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromContactPersonIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromContactPersonIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromContactPersonIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CopyContactSelectionMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CopyContactSelectionMembers" style="document" />
      <wsdl:input name="CopyContactSelectionMembersRequest">
        <soap:header message="tns:CopyContactSelectionMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CopyContactSelectionMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CopyContactSelectionMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CopyContactSelectionMembersResponse">
        <soap:header message="tns:CopyContactSelectionMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CopyContactSelectionMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CopyContactSelectionMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CopyContactSelectionMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetRecipientStatistics">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetRecipientStatistics" style="document" />
      <wsdl:input name="GetRecipientStatisticsRequest">
        <soap:header message="tns:GetRecipientStatisticsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetRecipientStatisticsResponse">
        <soap:header message="tns:GetRecipientStatisticsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetRecipientStatisticsFromProjectMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetRecipientStatisticsFromProjectMembers" style="document" />
      <wsdl:input name="GetRecipientStatisticsFromProjectMembersRequest">
        <soap:header message="tns:GetRecipientStatisticsFromProjectMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromProjectMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromProjectMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetRecipientStatisticsFromProjectMembersResponse">
        <soap:header message="tns:GetRecipientStatisticsFromProjectMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromProjectMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromProjectMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromProjectMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetRecipientStatisticsFromContactPersonIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetRecipientStatisticsFromContactPersonIds" style="document" />
      <wsdl:input name="GetRecipientStatisticsFromContactPersonIdsRequest">
        <soap:header message="tns:GetRecipientStatisticsFromContactPersonIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromContactPersonIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromContactPersonIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetRecipientStatisticsFromContactPersonIdsResponse">
        <soap:header message="tns:GetRecipientStatisticsFromContactPersonIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromContactPersonIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromContactPersonIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetRecipientStatisticsFromContactPersonIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddContactSelectionMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/AddContactSelectionMembers" style="document" />
      <wsdl:input name="AddContactSelectionMembersRequest">
        <soap:header message="tns:AddContactSelectionMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddContactSelectionMembersResponse">
        <soap:header message="tns:AddContactSelectionMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveContactSelectionMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/RemoveContactSelectionMembers" style="document" />
      <wsdl:input name="RemoveContactSelectionMembersRequest">
        <soap:header message="tns:RemoveContactSelectionMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveContactSelectionMembersResponse">
        <soap:header message="tns:RemoveContactSelectionMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveContactSelectionMembersFromIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/RemoveContactSelectionMembersFromIds" style="document" />
      <wsdl:input name="RemoveContactSelectionMembersFromIdsRequest">
        <soap:header message="tns:RemoveContactSelectionMembersFromIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveContactSelectionMembersFromIdsResponse">
        <soap:header message="tns:RemoveContactSelectionMembersFromIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddContactSelectionMembersFromSearch">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/AddContactSelectionMembersFromSearch" style="document" />
      <wsdl:input name="AddContactSelectionMembersFromSearchRequest">
        <soap:header message="tns:AddContactSelectionMembersFromSearchRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersFromSearchRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersFromSearchRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddContactSelectionMembersFromSearchResponse">
        <soap:header message="tns:AddContactSelectionMembersFromSearchResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersFromSearchResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersFromSearchResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddContactSelectionMembersFromSearchResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveContactSelectionMembersFromSearch">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/RemoveContactSelectionMembersFromSearch" style="document" />
      <wsdl:input name="RemoveContactSelectionMembersFromSearchRequest">
        <soap:header message="tns:RemoveContactSelectionMembersFromSearchRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromSearchRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromSearchRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveContactSelectionMembersFromSearchResponse">
        <soap:header message="tns:RemoveContactSelectionMembersFromSearchResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromSearchResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromSearchResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveContactSelectionMembersFromSearchResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateTemporaryContactSelection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateTemporaryContactSelection" style="document" />
      <wsdl:input name="CreateTemporaryContactSelectionRequest">
        <soap:header message="tns:CreateTemporaryContactSelectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateTemporaryContactSelectionResponse">
        <soap:header message="tns:CreateTemporaryContactSelectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateTemporaryContactSelectionFromSelectionMemberIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateTemporaryContactSelectionFromSelectionMemberIds" style="document" />
      <wsdl:input name="CreateTemporaryContactSelectionFromSelectionMemberIdsRequest">
        <soap:header message="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateTemporaryContactSelectionFromSelectionMemberIdsResponse">
        <soap:header message="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateTemporaryContactSelectionFromSelectionMemberIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddRemoveContactSelectionMemberInterests">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/AddRemoveContactSelectionMemberInterests" style="document" />
      <wsdl:input name="AddRemoveContactSelectionMemberInterestsRequest">
        <soap:header message="tns:AddRemoveContactSelectionMemberInterestsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddRemoveContactSelectionMemberInterestsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddRemoveContactSelectionMemberInterestsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddRemoveContactSelectionMemberInterestsResponse">
        <soap:header message="tns:AddRemoveContactSelectionMemberInterestsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddRemoveContactSelectionMemberInterestsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddRemoveContactSelectionMemberInterestsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddRemoveContactSelectionMemberInterestsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="EditContactSelectionMemberDetails">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/EditContactSelectionMemberDetails" style="document" />
      <wsdl:input name="EditContactSelectionMemberDetailsRequest">
        <soap:header message="tns:EditContactSelectionMemberDetailsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:EditContactSelectionMemberDetailsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:EditContactSelectionMemberDetailsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="EditContactSelectionMemberDetailsResponse">
        <soap:header message="tns:EditContactSelectionMemberDetailsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:EditContactSelectionMemberDetailsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:EditContactSelectionMemberDetailsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:EditContactSelectionMemberDetailsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GenerateFollowUps">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GenerateFollowUps" style="document" />
      <wsdl:input name="GenerateFollowUpsRequest">
        <soap:header message="tns:GenerateFollowUpsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GenerateFollowUpsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GenerateFollowUpsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GenerateFollowUpsResponse">
        <soap:header message="tns:GenerateFollowUpsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GenerateFollowUpsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GenerateFollowUpsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GenerateFollowUpsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ExportSelectionMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/ExportSelectionMembers" style="document" />
      <wsdl:input name="ExportSelectionMembersRequest">
        <soap:header message="tns:ExportSelectionMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ExportSelectionMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ExportSelectionMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ExportSelectionMembersResponse">
        <soap:header message="tns:ExportSelectionMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ExportSelectionMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ExportSelectionMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ExportSelectionMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ExportSelectionMembersWithOrderBy">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/ExportSelectionMembersWithOrderBy" style="document" />
      <wsdl:input name="ExportSelectionMembersWithOrderByRequest">
        <soap:header message="tns:ExportSelectionMembersWithOrderByRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ExportSelectionMembersWithOrderByRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ExportSelectionMembersWithOrderByRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ExportSelectionMembersWithOrderByResponse">
        <soap:header message="tns:ExportSelectionMembersWithOrderByResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ExportSelectionMembersWithOrderByResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ExportSelectionMembersWithOrderByResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ExportSelectionMembersWithOrderByResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetDuplicateRulesStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SetDuplicateRulesStatus" style="document" />
      <wsdl:input name="SetDuplicateRulesStatusRequest">
        <soap:header message="tns:SetDuplicateRulesStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetDuplicateRulesStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetDuplicateRulesStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetDuplicateRulesStatusResponse">
        <soap:header message="tns:SetDuplicateRulesStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetDuplicateRulesStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetDuplicateRulesStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetDuplicateRulesStatusResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDuplicates">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetDuplicates" style="document" />
      <wsdl:input name="GetDuplicatesRequest">
        <soap:header message="tns:GetDuplicatesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDuplicatesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDuplicatesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDuplicatesResponse">
        <soap:header message="tns:GetDuplicatesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDuplicatesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDuplicatesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDuplicatesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDuplicateRules">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetDuplicateRules" style="document" />
      <wsdl:input name="GetDuplicateRulesRequest">
        <soap:header message="tns:GetDuplicateRulesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDuplicateRulesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDuplicateRulesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDuplicateRulesResponse">
        <soap:header message="tns:GetDuplicateRulesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDuplicateRulesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDuplicateRulesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDuplicateRulesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateNewEntry">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateNewEntry" style="document" />
      <wsdl:input name="CreateNewEntryRequest">
        <soap:header message="tns:CreateNewEntryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateNewEntryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateNewEntryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateNewEntryResponse">
        <soap:header message="tns:CreateNewEntryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateNewEntryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateNewEntryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateNewEntryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteContacts">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/DeleteContacts" style="document" />
      <wsdl:input name="DeleteContactsRequest">
        <soap:header message="tns:DeleteContactsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteContactsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteContactsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteContactsResponse">
        <soap:header message="tns:DeleteContactsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteContactsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteContactsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteContactsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddSelectionMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/AddSelectionMembers" style="document" />
      <wsdl:input name="AddSelectionMembersRequest">
        <soap:header message="tns:AddSelectionMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddSelectionMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddSelectionMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddSelectionMembersResponse">
        <soap:header message="tns:AddSelectionMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddSelectionMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddSelectionMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddSelectionMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveSelectionMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/RemoveSelectionMembers" style="document" />
      <wsdl:input name="RemoveSelectionMembersRequest">
        <soap:header message="tns:RemoveSelectionMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveSelectionMembersResponse">
        <soap:header message="tns:RemoveSelectionMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveSelectionMembersById">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/RemoveSelectionMembersById" style="document" />
      <wsdl:input name="RemoveSelectionMembersByIdRequest">
        <soap:header message="tns:RemoveSelectionMembersByIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersByIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersByIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveSelectionMembersByIdResponse">
        <soap:header message="tns:RemoveSelectionMembersByIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersByIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersByIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersByIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddSelectionMembersFromSearch">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/AddSelectionMembersFromSearch" style="document" />
      <wsdl:input name="AddSelectionMembersFromSearchRequest">
        <soap:header message="tns:AddSelectionMembersFromSearchRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddSelectionMembersFromSearchRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddSelectionMembersFromSearchRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddSelectionMembersFromSearchResponse">
        <soap:header message="tns:AddSelectionMembersFromSearchResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddSelectionMembersFromSearchResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddSelectionMembersFromSearchResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddSelectionMembersFromSearchResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveSelectionMembersFromSearch">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/RemoveSelectionMembersFromSearch" style="document" />
      <wsdl:input name="RemoveSelectionMembersFromSearchRequest">
        <soap:header message="tns:RemoveSelectionMembersFromSearchRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersFromSearchRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersFromSearchRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveSelectionMembersFromSearchResponse">
        <soap:header message="tns:RemoveSelectionMembersFromSearchResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersFromSearchResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersFromSearchResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveSelectionMembersFromSearchResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CopySelectionMembers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CopySelectionMembers" style="document" />
      <wsdl:input name="CopySelectionMembersRequest">
        <soap:header message="tns:CopySelectionMembersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CopySelectionMembersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CopySelectionMembersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CopySelectionMembersResponse">
        <soap:header message="tns:CopySelectionMembersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CopySelectionMembersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CopySelectionMembersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CopySelectionMembersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateTemporarySelectionFromIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateTemporarySelectionFromIds" style="document" />
      <wsdl:input name="CreateTemporarySelectionFromIdsRequest">
        <soap:header message="tns:CreateTemporarySelectionFromIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateTemporarySelectionFromIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateTemporarySelectionFromIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateTemporarySelectionFromIdsResponse">
        <soap:header message="tns:CreateTemporarySelectionFromIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateTemporarySelectionFromIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateTemporarySelectionFromIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateTemporarySelectionFromIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateSelectionFromSelection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateSelectionFromSelection" style="document" />
      <wsdl:input name="CreateSelectionFromSelectionRequest">
        <soap:header message="tns:CreateSelectionFromSelectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateSelectionFromSelectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateSelectionFromSelectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateSelectionFromSelectionResponse">
        <soap:header message="tns:CreateSelectionFromSelectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateSelectionFromSelectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateSelectionFromSelectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateSelectionFromSelectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateContactSelectionFromShadowSelection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/CreateContactSelectionFromShadowSelection" style="document" />
      <wsdl:input name="CreateContactSelectionFromShadowSelectionRequest">
        <soap:header message="tns:CreateContactSelectionFromShadowSelectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromShadowSelectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromShadowSelectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateContactSelectionFromShadowSelectionResponse">
        <soap:header message="tns:CreateContactSelectionFromShadowSelectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromShadowSelectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromShadowSelectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateContactSelectionFromShadowSelectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteEntities">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/DeleteEntities" style="document" />
      <wsdl:input name="DeleteEntitiesRequest">
        <soap:header message="tns:DeleteEntitiesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteEntitiesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteEntitiesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteEntitiesResponse">
        <soap:header message="tns:DeleteEntitiesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteEntitiesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteEntitiesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteEntitiesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetParentCombinedSelections">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetParentCombinedSelections" style="document" />
      <wsdl:input name="GetParentCombinedSelectionsRequest">
        <soap:header message="tns:GetParentCombinedSelectionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetParentCombinedSelectionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetParentCombinedSelectionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetParentCombinedSelectionsResponse">
        <soap:header message="tns:GetParentCombinedSelectionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetParentCombinedSelectionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetParentCombinedSelectionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetParentCombinedSelectionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSelectionMembersArchiveRows">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetSelectionMembersArchiveRows" style="document" />
      <wsdl:input name="GetSelectionMembersArchiveRowsRequest">
        <soap:header message="tns:GetSelectionMembersArchiveRowsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSelectionMembersArchiveRowsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSelectionMembersArchiveRowsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSelectionMembersArchiveRowsResponse">
        <soap:header message="tns:GetSelectionMembersArchiveRowsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSelectionMembersArchiveRowsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSelectionMembersArchiveRowsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSelectionMembersArchiveRowsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSelectionShadowMembersArchiveRows">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetSelectionShadowMembersArchiveRows" style="document" />
      <wsdl:input name="GetSelectionShadowMembersArchiveRowsRequest">
        <soap:header message="tns:GetSelectionShadowMembersArchiveRowsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSelectionShadowMembersArchiveRowsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSelectionShadowMembersArchiveRowsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSelectionShadowMembersArchiveRowsResponse">
        <soap:header message="tns:GetSelectionShadowMembersArchiveRowsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSelectionShadowMembersArchiveRowsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSelectionShadowMembersArchiveRowsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSelectionShadowMembersArchiveRowsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDynamicSelectionCriteria">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetDynamicSelectionCriteria" style="document" />
      <wsdl:input name="GetDynamicSelectionCriteriaRequest">
        <soap:header message="tns:GetDynamicSelectionCriteriaRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDynamicSelectionCriteriaRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDynamicSelectionCriteriaRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDynamicSelectionCriteriaResponse">
        <soap:header message="tns:GetDynamicSelectionCriteriaResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDynamicSelectionCriteriaResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDynamicSelectionCriteriaResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDynamicSelectionCriteriaResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetDynamicSelectionCriteria">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SetDynamicSelectionCriteria" style="document" />
      <wsdl:input name="SetDynamicSelectionCriteriaRequest">
        <soap:header message="tns:SetDynamicSelectionCriteriaRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteriaRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteriaRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetDynamicSelectionCriteriaResponse">
        <soap:header message="tns:SetDynamicSelectionCriteriaResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteriaResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteriaResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteriaResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetDynamicSelectionCriteria2">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SetDynamicSelectionCriteria2" style="document" />
      <wsdl:input name="SetDynamicSelectionCriteria2Request">
        <soap:header message="tns:SetDynamicSelectionCriteria2Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteria2Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteria2Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetDynamicSelectionCriteria2Response">
        <soap:header message="tns:SetDynamicSelectionCriteria2Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteria2Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteria2Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteria2Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetDynamicSelectionCriteria3">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SetDynamicSelectionCriteria3" style="document" />
      <wsdl:input name="SetDynamicSelectionCriteria3Request">
        <soap:header message="tns:SetDynamicSelectionCriteria3Request_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteria3Request_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteria3Request_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetDynamicSelectionCriteria3Response">
        <soap:header message="tns:SetDynamicSelectionCriteria3Response_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteria3Response_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteria3Response_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteria3Response_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeletePersons">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/DeletePersons" style="document" />
      <wsdl:input name="DeletePersonsRequest">
        <soap:header message="tns:DeletePersonsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeletePersonsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeletePersonsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeletePersonsResponse">
        <soap:header message="tns:DeletePersonsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeletePersonsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeletePersonsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeletePersonsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDynamicSelectionCriteriaGroups">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetDynamicSelectionCriteriaGroups" style="document" />
      <wsdl:input name="GetDynamicSelectionCriteriaGroupsRequest">
        <soap:header message="tns:GetDynamicSelectionCriteriaGroupsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDynamicSelectionCriteriaGroupsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDynamicSelectionCriteriaGroupsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDynamicSelectionCriteriaGroupsResponse">
        <soap:header message="tns:GetDynamicSelectionCriteriaGroupsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDynamicSelectionCriteriaGroupsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDynamicSelectionCriteriaGroupsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDynamicSelectionCriteriaGroupsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetDynamicSelectionCriteriaGroups">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/SetDynamicSelectionCriteriaGroups" style="document" />
      <wsdl:input name="SetDynamicSelectionCriteriaGroupsRequest">
        <soap:header message="tns:SetDynamicSelectionCriteriaGroupsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteriaGroupsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteriaGroupsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetDynamicSelectionCriteriaGroupsResponse">
        <soap:header message="tns:SetDynamicSelectionCriteriaGroupsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteriaGroupsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteriaGroupsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetDynamicSelectionCriteriaGroupsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteSelectionEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/DeleteSelectionEntity" style="document" />
      <wsdl:input name="DeleteSelectionEntityRequest">
        <soap:header message="tns:DeleteSelectionEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteSelectionEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteSelectionEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteSelectionEntityResponse">
        <soap:header message="tns:DeleteSelectionEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteSelectionEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteSelectionEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteSelectionEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSelectionForFind">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetSelectionForFind" style="document" />
      <wsdl:input name="GetSelectionForFindRequest">
        <soap:header message="tns:GetSelectionForFindRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSelectionForFindRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSelectionForFindRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSelectionForFindResponse">
        <soap:header message="tns:GetSelectionForFindResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSelectionForFindResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSelectionForFindResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSelectionForFindResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSelectionSummaries">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/GetSelectionSummaries" style="document" />
      <wsdl:input name="GetSelectionSummariesRequest">
        <soap:header message="tns:GetSelectionSummariesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSelectionSummariesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSelectionSummariesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSelectionSummariesResponse">
        <soap:header message="tns:GetSelectionSummariesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSelectionSummariesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSelectionSummariesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSelectionSummariesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateTypicalSearch">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Selection/UpdateTypicalSearch" style="document" />
      <wsdl:input name="UpdateTypicalSearchRequest">
        <soap:header message="tns:UpdateTypicalSearchRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateTypicalSearchRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateTypicalSearchRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateTypicalSearchResponse">
        <soap:header message="tns:UpdateTypicalSearchResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateTypicalSearchResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateTypicalSearchResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateTypicalSearchResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfSelectionService">
    <wsdl:port name="BasicHttpBinding_Selection" binding="tns:BasicHttpBinding_Selection">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/Selection.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

