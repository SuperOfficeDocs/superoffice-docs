---
generated: true
uid: wsdl-Services88-Diagnostics
title: Services88.DiagnosticsAgent WSDL
content_type: reference
---

# Services88.DiagnosticsAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfDiagnosticsService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:element name="GetAnalyticsData">
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
      <xs:element name="GetAnalyticsDataResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:AnalyticsData" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="AnalyticsData">
        <xs:sequence>
          <xs:element minOccurs="0" name="AmplitudeApiKey" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="UserflowToken" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Email" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Company" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="LicenseStatus" nillable="true" type="tns:UserAndInstallationLicenceStatus" />
          <xs:element minOccurs="0" name="HasLicensce" nillable="true" type="tns:StringBoolDictionary" />
          <xs:element minOccurs="0" name="SystemLicenseNames" nillable="true" type="q1:ArrayOfstring" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="UserSignedUpAt" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="NumContact" type="xs:int" />
          <xs:element minOccurs="0" name="NumPerson" type="xs:int" />
          <xs:element minOccurs="0" name="NumAppointment" type="xs:int" />
          <xs:element minOccurs="0" name="NumSale" type="xs:int" />
          <xs:element minOccurs="0" name="NumProject" type="xs:int" />
          <xs:element minOccurs="0" name="NumSelection" type="xs:int" />
          <xs:element minOccurs="0" name="NumEmailItem" type="xs:int" />
          <xs:element minOccurs="0" name="NumTicketLogAction" type="xs:int" />
          <xs:element minOccurs="0" name="NumDashboard" type="xs:int" />
          <xs:element minOccurs="0" name="NumQuote" type="xs:int" />
          <xs:element minOccurs="0" name="NumQuoteLine" type="xs:int" />
          <xs:element minOccurs="0" name="NumDocument" type="xs:int" />
          <xs:element minOccurs="0" name="NumTargetAssignmentInfo" type="xs:int" />
          <xs:element minOccurs="0" name="NumMailing" type="xs:int" />
          <xs:element minOccurs="0" name="NumForm" type="xs:int" />
          <xs:element minOccurs="0" name="NumWorkflow" type="xs:int" />
          <xs:element minOccurs="0" name="TotContact" type="xs:int" />
          <xs:element minOccurs="0" name="TotPerson" type="xs:int" />
          <xs:element minOccurs="0" name="TotAppointment" type="xs:int" />
          <xs:element minOccurs="0" name="TotSale" type="xs:int" />
          <xs:element minOccurs="0" name="TotProject" type="xs:int" />
          <xs:element minOccurs="0" name="TotSelection" type="xs:int" />
          <xs:element minOccurs="0" name="TotEmailItem" type="xs:int" />
          <xs:element minOccurs="0" name="TotTicketLogAction" type="xs:int" />
          <xs:element minOccurs="0" name="TotDashboard" type="xs:int" />
          <xs:element minOccurs="0" name="TotQuote" type="xs:int" />
          <xs:element minOccurs="0" name="TotQuoteLine" type="xs:int" />
          <xs:element minOccurs="0" name="TotDocument" type="xs:int" />
          <xs:element minOccurs="0" name="TotTargetAssignmentInfo" type="xs:int" />
          <xs:element minOccurs="0" name="TotMailing" type="xs:int" />
          <xs:element minOccurs="0" name="TotForm" type="xs:int" />
          <xs:element minOccurs="0" name="TotWorkflow" type="xs:int" />
          <xs:element minOccurs="0" name="UserRegisteredAgeDays" type="xs:int" />
          <xs:element minOccurs="0" name="UserCountryName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="UserCountryCode" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Preferences" nillable="true" type="tns:StringBoolDictionary" />
          <xs:element minOccurs="0" name="TotWebUsers" type="xs:int" />
          <xs:element minOccurs="0" name="GroupCountryName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="GroupCountryCode" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="GroupRegisteredDate" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="GroupRegisteredAgeDays" type="xs:int" />
          <xs:element minOccurs="0" name="FeatureToggles" nillable="true" type="tns:StringBoolDictionary" />
          <xs:element minOccurs="0" name="FileVersion" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FileVersionNumber" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="AnalyticsData" nillable="true" type="tns:AnalyticsData" />
      <xs:complexType name="UserAndInstallationLicenceStatus">
        <xs:sequence>
          <xs:element minOccurs="0" name="AdminWarningDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="ExpiryDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="GraceDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="CompanyName" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="SerialNr" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="UserLicenses" nillable="true" type="q2:ArrayOfstring" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="UserAndInstallationLicenceStatus" nillable="true" type="tns:UserAndInstallationLicenceStatus" />
      <xs:complexType name="StringBoolDictionary">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="StringBoolKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" type="xs:boolean" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="StringBoolDictionary" nillable="true" type="tns:StringBoolDictionary" />
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
      <xs:element name="FlushCaches">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="FlushCachesResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCacheNames">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCacheNamesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q3:ArrayOfstring" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FlushCachesByName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CacheNames" nillable="true" type="q4:ArrayOfstring" xmlns:q4="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FlushCachesByNameResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCacheState">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CacheNames" nillable="true" type="q5:ArrayOfstring" xmlns:q5="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCacheStateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCacheInvalidationGenerations">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Names" nillable="true" type="q6:ArrayOfstring" xmlns:q6="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCacheInvalidationGenerationsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfCacheInvalidation" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfCacheInvalidation">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="CacheInvalidation" nillable="true" type="tns:CacheInvalidation" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfCacheInvalidation" nillable="true" type="tns:ArrayOfCacheInvalidation" />
      <xs:complexType name="CacheInvalidation">
        <xs:sequence>
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Generation" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="CacheInvalidation" nillable="true" type="tns:CacheInvalidation" />
      <xs:element name="GetEntityCountsForCurrentUser">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEntityCountsForCurrentUserResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfEntityCounts" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfEntityCounts">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="EntityCounts" nillable="true" type="tns:EntityCounts" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfEntityCounts" nillable="true" type="tns:ArrayOfEntityCounts" />
      <xs:complexType name="EntityCounts">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="EntityName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Records" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EntityCounts" nillable="true" type="tns:EntityCounts" />
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
      <xs:element name="GetEntityCountsForAllUsers">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEntityCountsForAllUsersResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfEntityCounts" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="LogViewState">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ViewState" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="LogViewStateResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeLogSettings">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="LogWarning" type="xs:boolean" />
            <xs:element minOccurs="0" name="LogInformation" type="xs:boolean" />
            <xs:element minOccurs="0" name="LogSuccessAudit" type="xs:boolean" />
            <xs:element minOccurs="0" name="LogFailureAudit" type="xs:boolean" />
            <xs:element minOccurs="0" name="LogToEventLog" type="xs:boolean" />
            <xs:element minOccurs="0" name="LogToSuperOffice" type="xs:boolean" />
            <xs:element minOccurs="0" name="LogToFile" type="xs:boolean" />
            <xs:element minOccurs="0" name="LogToTrace" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ChangeLogSettingsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="TrackEvent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TrackEventName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="EventProperties" nillable="true" type="tns:StringDictionary" />
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
      <xs:element name="TrackEventResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CollectDataAdditions">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CollectDataAdditionsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CollectWinUsage">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CollectWinUsageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CollectWebUsage">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CollectWebUsageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CollectTableSizes">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CollectTableSizesResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ResyncUsers">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ResyncUsersResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SendSystemMessage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SystemMessageId" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="MarkdownMessage" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Expire" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Type" type="tns:SystemMessageType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="SystemMessageType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="Info" />
              <xs:enumeration value="Warning" />
              <xs:enumeration value="UndefinedValue4" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="SystemMessageType" nillable="true" type="tns:SystemMessageType" />
      <xs:element name="SendSystemMessageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveSystemMessage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OnlineappId" type="xs:int" />
            <xs:element minOccurs="0" name="SystemMessageId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveSystemMessageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveSystemMessageForAssociate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OnlineappId" type="xs:int" />
            <xs:element minOccurs="0" name="SystemMessageId" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveSystemMessageForAssociateResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSystemMessages">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSystemMessagesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfSystemMessage" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfSystemMessage">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="SystemMessage" nillable="true" type="tns:SystemMessage" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfSystemMessage" nillable="true" type="tns:ArrayOfSystemMessage" />
      <xs:complexType name="SystemMessage">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="MessageId" type="xs:int" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="OnlineappId" type="xs:int" />
              <xs:element minOccurs="0" name="SystemMessageId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MarkdownMessage" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Expire" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Type" type="tns:SystemMessageType" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SystemMessage" nillable="true" type="tns:SystemMessage" />
      <xs:element name="RemoveExpiredSystemMessages">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveExpiredSystemMessagesResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNextTableNumber">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNextTableNumberResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="PerformTasksAfterUpgrade">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="PerformTasksAfterUpgradeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="PerformTasksAfterCustomObjectTableCreated">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="PerformTasksAfterCustomObjectTableCreatedResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="PerformTasksAfterCustomObjectTableDeleted">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TableName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="PerformTasksAfterCustomObjectTableDeletedResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="AddWebAppUsage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WebAppUsages" nillable="true" type="tns:ArrayOfWebAppUsage" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfWebAppUsage">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="WebAppUsage" nillable="true" type="tns:WebAppUsage" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfWebAppUsage" nillable="true" type="tns:ArrayOfWebAppUsage" />
      <xs:complexType name="WebAppUsage">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="WebAppUsageId" type="xs:int" />
              <xs:element minOccurs="0" name="AssocId" type="xs:int" />
              <xs:element minOccurs="0" name="Timestamp" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ViewState" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AggregateCount" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="AggregateBin" type="xs:unsignedInt" />
              <xs:element minOccurs="0" name="Version" type="xs:unsignedInt" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WebAppUsage" nillable="true" type="tns:WebAppUsage" />
      <xs:element name="AddWebAppUsageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="WebAppUsageExistsInPeriod">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="ViewState" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="FromDate" type="xs:dateTime" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="WebAppUsageExistsInPeriodResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWebAppUsagesForPeriod">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FromDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="ToDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="SearchTerm" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWebAppUsagesForPeriodResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfWebAppUsage" />
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
      <xs:complexType name="ArrayOfstring">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="string" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfstring" nillable="true" type="tns:ArrayOfstring" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="GetAnalyticsDataRequest">
    <wsdl:part name="parameters" element="tns:GetAnalyticsData" />
  </wsdl:message>
  <wsdl:message name="GetAnalyticsDataRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAnalyticsDataResponse">
    <wsdl:part name="parameters" element="tns:GetAnalyticsDataResponse" />
  </wsdl:message>
  <wsdl:message name="GetAnalyticsDataResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FlushCachesRequest">
    <wsdl:part name="parameters" element="tns:FlushCaches" />
  </wsdl:message>
  <wsdl:message name="FlushCachesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FlushCachesResponse">
    <wsdl:part name="parameters" element="tns:FlushCachesResponse" />
  </wsdl:message>
  <wsdl:message name="FlushCachesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCacheNamesRequest">
    <wsdl:part name="parameters" element="tns:GetCacheNames" />
  </wsdl:message>
  <wsdl:message name="GetCacheNamesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCacheNamesResponse">
    <wsdl:part name="parameters" element="tns:GetCacheNamesResponse" />
  </wsdl:message>
  <wsdl:message name="GetCacheNamesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FlushCachesByNameRequest">
    <wsdl:part name="parameters" element="tns:FlushCachesByName" />
  </wsdl:message>
  <wsdl:message name="FlushCachesByNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FlushCachesByNameResponse">
    <wsdl:part name="parameters" element="tns:FlushCachesByNameResponse" />
  </wsdl:message>
  <wsdl:message name="FlushCachesByNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCacheStateRequest">
    <wsdl:part name="parameters" element="tns:GetCacheState" />
  </wsdl:message>
  <wsdl:message name="GetCacheStateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCacheStateResponse">
    <wsdl:part name="parameters" element="tns:GetCacheStateResponse" />
  </wsdl:message>
  <wsdl:message name="GetCacheStateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCacheInvalidationGenerationsRequest">
    <wsdl:part name="parameters" element="tns:GetCacheInvalidationGenerations" />
  </wsdl:message>
  <wsdl:message name="GetCacheInvalidationGenerationsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCacheInvalidationGenerationsResponse">
    <wsdl:part name="parameters" element="tns:GetCacheInvalidationGenerationsResponse" />
  </wsdl:message>
  <wsdl:message name="GetCacheInvalidationGenerationsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEntityCountsForCurrentUserRequest">
    <wsdl:part name="parameters" element="tns:GetEntityCountsForCurrentUser" />
  </wsdl:message>
  <wsdl:message name="GetEntityCountsForCurrentUserRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEntityCountsForCurrentUserResponse">
    <wsdl:part name="parameters" element="tns:GetEntityCountsForCurrentUserResponse" />
  </wsdl:message>
  <wsdl:message name="GetEntityCountsForCurrentUserResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEntityCountsForAllUsersRequest">
    <wsdl:part name="parameters" element="tns:GetEntityCountsForAllUsers" />
  </wsdl:message>
  <wsdl:message name="GetEntityCountsForAllUsersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEntityCountsForAllUsersResponse">
    <wsdl:part name="parameters" element="tns:GetEntityCountsForAllUsersResponse" />
  </wsdl:message>
  <wsdl:message name="GetEntityCountsForAllUsersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="LogViewStateRequest">
    <wsdl:part name="parameters" element="tns:LogViewState" />
  </wsdl:message>
  <wsdl:message name="LogViewStateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="LogViewStateResponse">
    <wsdl:part name="parameters" element="tns:LogViewStateResponse" />
  </wsdl:message>
  <wsdl:message name="LogViewStateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeLogSettingsRequest">
    <wsdl:part name="parameters" element="tns:ChangeLogSettings" />
  </wsdl:message>
  <wsdl:message name="ChangeLogSettingsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ChangeLogSettingsResponse">
    <wsdl:part name="parameters" element="tns:ChangeLogSettingsResponse" />
  </wsdl:message>
  <wsdl:message name="ChangeLogSettingsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TrackEventRequest">
    <wsdl:part name="parameters" element="tns:TrackEvent" />
  </wsdl:message>
  <wsdl:message name="TrackEventRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TrackEventResponse">
    <wsdl:part name="parameters" element="tns:TrackEventResponse" />
  </wsdl:message>
  <wsdl:message name="TrackEventResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CollectDataAdditionsRequest">
    <wsdl:part name="parameters" element="tns:CollectDataAdditions" />
  </wsdl:message>
  <wsdl:message name="CollectDataAdditionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CollectDataAdditionsResponse">
    <wsdl:part name="parameters" element="tns:CollectDataAdditionsResponse" />
  </wsdl:message>
  <wsdl:message name="CollectDataAdditionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CollectWinUsageRequest">
    <wsdl:part name="parameters" element="tns:CollectWinUsage" />
  </wsdl:message>
  <wsdl:message name="CollectWinUsageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CollectWinUsageResponse">
    <wsdl:part name="parameters" element="tns:CollectWinUsageResponse" />
  </wsdl:message>
  <wsdl:message name="CollectWinUsageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CollectWebUsageRequest">
    <wsdl:part name="parameters" element="tns:CollectWebUsage" />
  </wsdl:message>
  <wsdl:message name="CollectWebUsageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CollectWebUsageResponse">
    <wsdl:part name="parameters" element="tns:CollectWebUsageResponse" />
  </wsdl:message>
  <wsdl:message name="CollectWebUsageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CollectTableSizesRequest">
    <wsdl:part name="parameters" element="tns:CollectTableSizes" />
  </wsdl:message>
  <wsdl:message name="CollectTableSizesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CollectTableSizesResponse">
    <wsdl:part name="parameters" element="tns:CollectTableSizesResponse" />
  </wsdl:message>
  <wsdl:message name="CollectTableSizesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ResyncUsersRequest">
    <wsdl:part name="parameters" element="tns:ResyncUsers" />
  </wsdl:message>
  <wsdl:message name="ResyncUsersRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ResyncUsersResponse">
    <wsdl:part name="parameters" element="tns:ResyncUsersResponse" />
  </wsdl:message>
  <wsdl:message name="ResyncUsersResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendSystemMessageRequest">
    <wsdl:part name="parameters" element="tns:SendSystemMessage" />
  </wsdl:message>
  <wsdl:message name="SendSystemMessageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendSystemMessageResponse">
    <wsdl:part name="parameters" element="tns:SendSystemMessageResponse" />
  </wsdl:message>
  <wsdl:message name="SendSystemMessageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveSystemMessageRequest">
    <wsdl:part name="parameters" element="tns:RemoveSystemMessage" />
  </wsdl:message>
  <wsdl:message name="RemoveSystemMessageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveSystemMessageResponse">
    <wsdl:part name="parameters" element="tns:RemoveSystemMessageResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveSystemMessageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveSystemMessageForAssociateRequest">
    <wsdl:part name="parameters" element="tns:RemoveSystemMessageForAssociate" />
  </wsdl:message>
  <wsdl:message name="RemoveSystemMessageForAssociateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveSystemMessageForAssociateResponse">
    <wsdl:part name="parameters" element="tns:RemoveSystemMessageForAssociateResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveSystemMessageForAssociateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSystemMessagesRequest">
    <wsdl:part name="parameters" element="tns:GetSystemMessages" />
  </wsdl:message>
  <wsdl:message name="GetSystemMessagesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSystemMessagesResponse">
    <wsdl:part name="parameters" element="tns:GetSystemMessagesResponse" />
  </wsdl:message>
  <wsdl:message name="GetSystemMessagesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveExpiredSystemMessagesRequest">
    <wsdl:part name="parameters" element="tns:RemoveExpiredSystemMessages" />
  </wsdl:message>
  <wsdl:message name="RemoveExpiredSystemMessagesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveExpiredSystemMessagesResponse">
    <wsdl:part name="parameters" element="tns:RemoveExpiredSystemMessagesResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveExpiredSystemMessagesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextTableNumberRequest">
    <wsdl:part name="parameters" element="tns:GetNextTableNumber" />
  </wsdl:message>
  <wsdl:message name="GetNextTableNumberRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextTableNumberResponse">
    <wsdl:part name="parameters" element="tns:GetNextTableNumberResponse" />
  </wsdl:message>
  <wsdl:message name="GetNextTableNumberResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PerformTasksAfterUpgradeRequest">
    <wsdl:part name="parameters" element="tns:PerformTasksAfterUpgrade" />
  </wsdl:message>
  <wsdl:message name="PerformTasksAfterUpgradeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PerformTasksAfterUpgradeResponse">
    <wsdl:part name="parameters" element="tns:PerformTasksAfterUpgradeResponse" />
  </wsdl:message>
  <wsdl:message name="PerformTasksAfterUpgradeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PerformTasksAfterCustomObjectTableCreatedRequest">
    <wsdl:part name="parameters" element="tns:PerformTasksAfterCustomObjectTableCreated" />
  </wsdl:message>
  <wsdl:message name="PerformTasksAfterCustomObjectTableCreatedRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PerformTasksAfterCustomObjectTableCreatedResponse">
    <wsdl:part name="parameters" element="tns:PerformTasksAfterCustomObjectTableCreatedResponse" />
  </wsdl:message>
  <wsdl:message name="PerformTasksAfterCustomObjectTableCreatedResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PerformTasksAfterCustomObjectTableDeletedRequest">
    <wsdl:part name="parameters" element="tns:PerformTasksAfterCustomObjectTableDeleted" />
  </wsdl:message>
  <wsdl:message name="PerformTasksAfterCustomObjectTableDeletedRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PerformTasksAfterCustomObjectTableDeletedResponse">
    <wsdl:part name="parameters" element="tns:PerformTasksAfterCustomObjectTableDeletedResponse" />
  </wsdl:message>
  <wsdl:message name="PerformTasksAfterCustomObjectTableDeletedResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddWebAppUsageRequest">
    <wsdl:part name="parameters" element="tns:AddWebAppUsage" />
  </wsdl:message>
  <wsdl:message name="AddWebAppUsageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddWebAppUsageResponse">
    <wsdl:part name="parameters" element="tns:AddWebAppUsageResponse" />
  </wsdl:message>
  <wsdl:message name="AddWebAppUsageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="WebAppUsageExistsInPeriodRequest">
    <wsdl:part name="parameters" element="tns:WebAppUsageExistsInPeriod" />
  </wsdl:message>
  <wsdl:message name="WebAppUsageExistsInPeriodRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="WebAppUsageExistsInPeriodResponse">
    <wsdl:part name="parameters" element="tns:WebAppUsageExistsInPeriodResponse" />
  </wsdl:message>
  <wsdl:message name="WebAppUsageExistsInPeriodResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWebAppUsagesForPeriodRequest">
    <wsdl:part name="parameters" element="tns:GetWebAppUsagesForPeriod" />
  </wsdl:message>
  <wsdl:message name="GetWebAppUsagesForPeriodRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWebAppUsagesForPeriodResponse">
    <wsdl:part name="parameters" element="tns:GetWebAppUsagesForPeriodResponse" />
  </wsdl:message>
  <wsdl:message name="GetWebAppUsagesForPeriodResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Diagnostics">
    <wsdl:operation name="GetAnalyticsData">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetAnalyticsData" name="GetAnalyticsDataRequest" message="tns:GetAnalyticsDataRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetAnalyticsDataResponse" name="GetAnalyticsDataResponse" message="tns:GetAnalyticsDataResponse" />
    </wsdl:operation>
    <wsdl:operation name="FlushCaches">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/FlushCaches" name="FlushCachesRequest" message="tns:FlushCachesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/FlushCachesResponse" name="FlushCachesResponse" message="tns:FlushCachesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCacheNames">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetCacheNames" name="GetCacheNamesRequest" message="tns:GetCacheNamesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetCacheNamesResponse" name="GetCacheNamesResponse" message="tns:GetCacheNamesResponse" />
    </wsdl:operation>
    <wsdl:operation name="FlushCachesByName">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/FlushCachesByName" name="FlushCachesByNameRequest" message="tns:FlushCachesByNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/FlushCachesByNameResponse" name="FlushCachesByNameResponse" message="tns:FlushCachesByNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCacheState">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetCacheState" name="GetCacheStateRequest" message="tns:GetCacheStateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetCacheStateResponse" name="GetCacheStateResponse" message="tns:GetCacheStateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCacheInvalidationGenerations">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetCacheInvalidationGenerations" name="GetCacheInvalidationGenerationsRequest" message="tns:GetCacheInvalidationGenerationsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetCacheInvalidationGenerationsResponse" name="GetCacheInvalidationGenerationsResponse" message="tns:GetCacheInvalidationGenerationsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEntityCountsForCurrentUser">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetEntityCountsForCurrentUser" name="GetEntityCountsForCurrentUserRequest" message="tns:GetEntityCountsForCurrentUserRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetEntityCountsForCurrentUserResponse" name="GetEntityCountsForCurrentUserResponse" message="tns:GetEntityCountsForCurrentUserResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEntityCountsForAllUsers">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetEntityCountsForAllUsers" name="GetEntityCountsForAllUsersRequest" message="tns:GetEntityCountsForAllUsersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetEntityCountsForAllUsersResponse" name="GetEntityCountsForAllUsersResponse" message="tns:GetEntityCountsForAllUsersResponse" />
    </wsdl:operation>
    <wsdl:operation name="LogViewState">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/LogViewState" name="LogViewStateRequest" message="tns:LogViewStateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/LogViewStateResponse" name="LogViewStateResponse" message="tns:LogViewStateResponse" />
    </wsdl:operation>
    <wsdl:operation name="ChangeLogSettings">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/ChangeLogSettings" name="ChangeLogSettingsRequest" message="tns:ChangeLogSettingsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/ChangeLogSettingsResponse" name="ChangeLogSettingsResponse" message="tns:ChangeLogSettingsResponse" />
    </wsdl:operation>
    <wsdl:operation name="TrackEvent">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/TrackEvent" name="TrackEventRequest" message="tns:TrackEventRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/TrackEventResponse" name="TrackEventResponse" message="tns:TrackEventResponse" />
    </wsdl:operation>
    <wsdl:operation name="CollectDataAdditions">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectDataAdditions" name="CollectDataAdditionsRequest" message="tns:CollectDataAdditionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectDataAdditionsResponse" name="CollectDataAdditionsResponse" message="tns:CollectDataAdditionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CollectWinUsage">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectWinUsage" name="CollectWinUsageRequest" message="tns:CollectWinUsageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectWinUsageResponse" name="CollectWinUsageResponse" message="tns:CollectWinUsageResponse" />
    </wsdl:operation>
    <wsdl:operation name="CollectWebUsage">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectWebUsage" name="CollectWebUsageRequest" message="tns:CollectWebUsageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectWebUsageResponse" name="CollectWebUsageResponse" message="tns:CollectWebUsageResponse" />
    </wsdl:operation>
    <wsdl:operation name="CollectTableSizes">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectTableSizes" name="CollectTableSizesRequest" message="tns:CollectTableSizesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectTableSizesResponse" name="CollectTableSizesResponse" message="tns:CollectTableSizesResponse" />
    </wsdl:operation>
    <wsdl:operation name="ResyncUsers">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/ResyncUsers" name="ResyncUsersRequest" message="tns:ResyncUsersRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/ResyncUsersResponse" name="ResyncUsersResponse" message="tns:ResyncUsersResponse" />
    </wsdl:operation>
    <wsdl:operation name="SendSystemMessage">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/SendSystemMessage" name="SendSystemMessageRequest" message="tns:SendSystemMessageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/SendSystemMessageResponse" name="SendSystemMessageResponse" message="tns:SendSystemMessageResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveSystemMessage">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/RemoveSystemMessage" name="RemoveSystemMessageRequest" message="tns:RemoveSystemMessageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/RemoveSystemMessageResponse" name="RemoveSystemMessageResponse" message="tns:RemoveSystemMessageResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveSystemMessageForAssociate">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/RemoveSystemMessageForAssociate" name="RemoveSystemMessageForAssociateRequest" message="tns:RemoveSystemMessageForAssociateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/RemoveSystemMessageForAssociateResponse" name="RemoveSystemMessageForAssociateResponse" message="tns:RemoveSystemMessageForAssociateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSystemMessages">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetSystemMessages" name="GetSystemMessagesRequest" message="tns:GetSystemMessagesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetSystemMessagesResponse" name="GetSystemMessagesResponse" message="tns:GetSystemMessagesResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveExpiredSystemMessages">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/RemoveExpiredSystemMessages" name="RemoveExpiredSystemMessagesRequest" message="tns:RemoveExpiredSystemMessagesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/RemoveExpiredSystemMessagesResponse" name="RemoveExpiredSystemMessagesResponse" message="tns:RemoveExpiredSystemMessagesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNextTableNumber">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetNextTableNumber" name="GetNextTableNumberRequest" message="tns:GetNextTableNumberRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetNextTableNumberResponse" name="GetNextTableNumberResponse" message="tns:GetNextTableNumberResponse" />
    </wsdl:operation>
    <wsdl:operation name="PerformTasksAfterUpgrade">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/PerformTasksAfterUpgrade" name="PerformTasksAfterUpgradeRequest" message="tns:PerformTasksAfterUpgradeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/PerformTasksAfterUpgradeResponse" name="PerformTasksAfterUpgradeResponse" message="tns:PerformTasksAfterUpgradeResponse" />
    </wsdl:operation>
    <wsdl:operation name="PerformTasksAfterCustomObjectTableCreated">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/PerformTasksAfterCustomObjectTableCreated" name="PerformTasksAfterCustomObjectTableCreatedRequest" message="tns:PerformTasksAfterCustomObjectTableCreatedRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/PerformTasksAfterCustomObjectTableCreatedResponse" name="PerformTasksAfterCustomObjectTableCreatedResponse" message="tns:PerformTasksAfterCustomObjectTableCreatedResponse" />
    </wsdl:operation>
    <wsdl:operation name="PerformTasksAfterCustomObjectTableDeleted">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/PerformTasksAfterCustomObjectTableDeleted" name="PerformTasksAfterCustomObjectTableDeletedRequest" message="tns:PerformTasksAfterCustomObjectTableDeletedRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/PerformTasksAfterCustomObjectTableDeletedResponse" name="PerformTasksAfterCustomObjectTableDeletedResponse" message="tns:PerformTasksAfterCustomObjectTableDeletedResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddWebAppUsage">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/AddWebAppUsage" name="AddWebAppUsageRequest" message="tns:AddWebAppUsageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/AddWebAppUsageResponse" name="AddWebAppUsageResponse" message="tns:AddWebAppUsageResponse" />
    </wsdl:operation>
    <wsdl:operation name="WebAppUsageExistsInPeriod">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/WebAppUsageExistsInPeriod" name="WebAppUsageExistsInPeriodRequest" message="tns:WebAppUsageExistsInPeriodRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/WebAppUsageExistsInPeriodResponse" name="WebAppUsageExistsInPeriodResponse" message="tns:WebAppUsageExistsInPeriodResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetWebAppUsagesForPeriod">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetWebAppUsagesForPeriod" name="GetWebAppUsagesForPeriodRequest" message="tns:GetWebAppUsagesForPeriodRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetWebAppUsagesForPeriodResponse" name="GetWebAppUsagesForPeriodResponse" message="tns:GetWebAppUsagesForPeriodResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Diagnostics" type="tns:Diagnostics">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="GetAnalyticsData">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetAnalyticsData" style="document" />
      <wsdl:input name="GetAnalyticsDataRequest">
        <soap:header message="tns:GetAnalyticsDataRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAnalyticsDataRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAnalyticsDataRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAnalyticsDataResponse">
        <soap:header message="tns:GetAnalyticsDataResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAnalyticsDataResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAnalyticsDataResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAnalyticsDataResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FlushCaches">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/FlushCaches" style="document" />
      <wsdl:input name="FlushCachesRequest">
        <soap:header message="tns:FlushCachesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FlushCachesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FlushCachesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FlushCachesResponse">
        <soap:header message="tns:FlushCachesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FlushCachesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FlushCachesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FlushCachesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCacheNames">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetCacheNames" style="document" />
      <wsdl:input name="GetCacheNamesRequest">
        <soap:header message="tns:GetCacheNamesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCacheNamesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCacheNamesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCacheNamesResponse">
        <soap:header message="tns:GetCacheNamesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCacheNamesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCacheNamesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCacheNamesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FlushCachesByName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/FlushCachesByName" style="document" />
      <wsdl:input name="FlushCachesByNameRequest">
        <soap:header message="tns:FlushCachesByNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FlushCachesByNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FlushCachesByNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FlushCachesByNameResponse">
        <soap:header message="tns:FlushCachesByNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FlushCachesByNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FlushCachesByNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FlushCachesByNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCacheState">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetCacheState" style="document" />
      <wsdl:input name="GetCacheStateRequest">
        <soap:header message="tns:GetCacheStateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCacheStateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCacheStateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCacheStateResponse">
        <soap:header message="tns:GetCacheStateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCacheStateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCacheStateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCacheStateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCacheInvalidationGenerations">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetCacheInvalidationGenerations" style="document" />
      <wsdl:input name="GetCacheInvalidationGenerationsRequest">
        <soap:header message="tns:GetCacheInvalidationGenerationsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCacheInvalidationGenerationsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCacheInvalidationGenerationsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCacheInvalidationGenerationsResponse">
        <soap:header message="tns:GetCacheInvalidationGenerationsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCacheInvalidationGenerationsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCacheInvalidationGenerationsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCacheInvalidationGenerationsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEntityCountsForCurrentUser">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetEntityCountsForCurrentUser" style="document" />
      <wsdl:input name="GetEntityCountsForCurrentUserRequest">
        <soap:header message="tns:GetEntityCountsForCurrentUserRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEntityCountsForCurrentUserRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEntityCountsForCurrentUserRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEntityCountsForCurrentUserResponse">
        <soap:header message="tns:GetEntityCountsForCurrentUserResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEntityCountsForCurrentUserResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEntityCountsForCurrentUserResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEntityCountsForCurrentUserResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEntityCountsForAllUsers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetEntityCountsForAllUsers" style="document" />
      <wsdl:input name="GetEntityCountsForAllUsersRequest">
        <soap:header message="tns:GetEntityCountsForAllUsersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEntityCountsForAllUsersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEntityCountsForAllUsersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEntityCountsForAllUsersResponse">
        <soap:header message="tns:GetEntityCountsForAllUsersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEntityCountsForAllUsersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEntityCountsForAllUsersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEntityCountsForAllUsersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="LogViewState">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/LogViewState" style="document" />
      <wsdl:input name="LogViewStateRequest">
        <soap:header message="tns:LogViewStateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:LogViewStateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:LogViewStateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="LogViewStateResponse">
        <soap:header message="tns:LogViewStateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:LogViewStateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:LogViewStateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:LogViewStateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ChangeLogSettings">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/ChangeLogSettings" style="document" />
      <wsdl:input name="ChangeLogSettingsRequest">
        <soap:header message="tns:ChangeLogSettingsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ChangeLogSettingsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ChangeLogSettingsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ChangeLogSettingsResponse">
        <soap:header message="tns:ChangeLogSettingsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ChangeLogSettingsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ChangeLogSettingsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ChangeLogSettingsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="TrackEvent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/TrackEvent" style="document" />
      <wsdl:input name="TrackEventRequest">
        <soap:header message="tns:TrackEventRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TrackEventRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TrackEventRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TrackEventResponse">
        <soap:header message="tns:TrackEventResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TrackEventResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TrackEventResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TrackEventResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CollectDataAdditions">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectDataAdditions" style="document" />
      <wsdl:input name="CollectDataAdditionsRequest">
        <soap:header message="tns:CollectDataAdditionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CollectDataAdditionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CollectDataAdditionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CollectDataAdditionsResponse">
        <soap:header message="tns:CollectDataAdditionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CollectDataAdditionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CollectDataAdditionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CollectDataAdditionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CollectWinUsage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectWinUsage" style="document" />
      <wsdl:input name="CollectWinUsageRequest">
        <soap:header message="tns:CollectWinUsageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CollectWinUsageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CollectWinUsageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CollectWinUsageResponse">
        <soap:header message="tns:CollectWinUsageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CollectWinUsageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CollectWinUsageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CollectWinUsageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CollectWebUsage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectWebUsage" style="document" />
      <wsdl:input name="CollectWebUsageRequest">
        <soap:header message="tns:CollectWebUsageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CollectWebUsageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CollectWebUsageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CollectWebUsageResponse">
        <soap:header message="tns:CollectWebUsageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CollectWebUsageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CollectWebUsageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CollectWebUsageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CollectTableSizes">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/CollectTableSizes" style="document" />
      <wsdl:input name="CollectTableSizesRequest">
        <soap:header message="tns:CollectTableSizesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CollectTableSizesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CollectTableSizesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CollectTableSizesResponse">
        <soap:header message="tns:CollectTableSizesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CollectTableSizesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CollectTableSizesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CollectTableSizesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ResyncUsers">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/ResyncUsers" style="document" />
      <wsdl:input name="ResyncUsersRequest">
        <soap:header message="tns:ResyncUsersRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ResyncUsersRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ResyncUsersRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ResyncUsersResponse">
        <soap:header message="tns:ResyncUsersResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ResyncUsersResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ResyncUsersResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ResyncUsersResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SendSystemMessage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/SendSystemMessage" style="document" />
      <wsdl:input name="SendSystemMessageRequest">
        <soap:header message="tns:SendSystemMessageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SendSystemMessageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SendSystemMessageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SendSystemMessageResponse">
        <soap:header message="tns:SendSystemMessageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SendSystemMessageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SendSystemMessageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SendSystemMessageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveSystemMessage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/RemoveSystemMessage" style="document" />
      <wsdl:input name="RemoveSystemMessageRequest">
        <soap:header message="tns:RemoveSystemMessageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveSystemMessageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveSystemMessageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveSystemMessageResponse">
        <soap:header message="tns:RemoveSystemMessageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveSystemMessageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveSystemMessageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveSystemMessageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveSystemMessageForAssociate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/RemoveSystemMessageForAssociate" style="document" />
      <wsdl:input name="RemoveSystemMessageForAssociateRequest">
        <soap:header message="tns:RemoveSystemMessageForAssociateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveSystemMessageForAssociateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveSystemMessageForAssociateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveSystemMessageForAssociateResponse">
        <soap:header message="tns:RemoveSystemMessageForAssociateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveSystemMessageForAssociateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveSystemMessageForAssociateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveSystemMessageForAssociateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSystemMessages">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetSystemMessages" style="document" />
      <wsdl:input name="GetSystemMessagesRequest">
        <soap:header message="tns:GetSystemMessagesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSystemMessagesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSystemMessagesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSystemMessagesResponse">
        <soap:header message="tns:GetSystemMessagesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSystemMessagesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSystemMessagesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSystemMessagesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveExpiredSystemMessages">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/RemoveExpiredSystemMessages" style="document" />
      <wsdl:input name="RemoveExpiredSystemMessagesRequest">
        <soap:header message="tns:RemoveExpiredSystemMessagesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveExpiredSystemMessagesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveExpiredSystemMessagesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveExpiredSystemMessagesResponse">
        <soap:header message="tns:RemoveExpiredSystemMessagesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveExpiredSystemMessagesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveExpiredSystemMessagesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveExpiredSystemMessagesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNextTableNumber">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetNextTableNumber" style="document" />
      <wsdl:input name="GetNextTableNumberRequest">
        <soap:header message="tns:GetNextTableNumberRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNextTableNumberRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNextTableNumberRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNextTableNumberResponse">
        <soap:header message="tns:GetNextTableNumberResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNextTableNumberResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNextTableNumberResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNextTableNumberResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="PerformTasksAfterUpgrade">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/PerformTasksAfterUpgrade" style="document" />
      <wsdl:input name="PerformTasksAfterUpgradeRequest">
        <soap:header message="tns:PerformTasksAfterUpgradeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:PerformTasksAfterUpgradeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:PerformTasksAfterUpgradeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="PerformTasksAfterUpgradeResponse">
        <soap:header message="tns:PerformTasksAfterUpgradeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:PerformTasksAfterUpgradeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:PerformTasksAfterUpgradeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:PerformTasksAfterUpgradeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="PerformTasksAfterCustomObjectTableCreated">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/PerformTasksAfterCustomObjectTableCreated" style="document" />
      <wsdl:input name="PerformTasksAfterCustomObjectTableCreatedRequest">
        <soap:header message="tns:PerformTasksAfterCustomObjectTableCreatedRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:PerformTasksAfterCustomObjectTableCreatedRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:PerformTasksAfterCustomObjectTableCreatedRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="PerformTasksAfterCustomObjectTableCreatedResponse">
        <soap:header message="tns:PerformTasksAfterCustomObjectTableCreatedResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:PerformTasksAfterCustomObjectTableCreatedResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:PerformTasksAfterCustomObjectTableCreatedResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:PerformTasksAfterCustomObjectTableCreatedResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="PerformTasksAfterCustomObjectTableDeleted">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/PerformTasksAfterCustomObjectTableDeleted" style="document" />
      <wsdl:input name="PerformTasksAfterCustomObjectTableDeletedRequest">
        <soap:header message="tns:PerformTasksAfterCustomObjectTableDeletedRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:PerformTasksAfterCustomObjectTableDeletedRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:PerformTasksAfterCustomObjectTableDeletedRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="PerformTasksAfterCustomObjectTableDeletedResponse">
        <soap:header message="tns:PerformTasksAfterCustomObjectTableDeletedResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:PerformTasksAfterCustomObjectTableDeletedResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:PerformTasksAfterCustomObjectTableDeletedResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:PerformTasksAfterCustomObjectTableDeletedResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddWebAppUsage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/AddWebAppUsage" style="document" />
      <wsdl:input name="AddWebAppUsageRequest">
        <soap:header message="tns:AddWebAppUsageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddWebAppUsageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddWebAppUsageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddWebAppUsageResponse">
        <soap:header message="tns:AddWebAppUsageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddWebAppUsageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddWebAppUsageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddWebAppUsageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="WebAppUsageExistsInPeriod">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/WebAppUsageExistsInPeriod" style="document" />
      <wsdl:input name="WebAppUsageExistsInPeriodRequest">
        <soap:header message="tns:WebAppUsageExistsInPeriodRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:WebAppUsageExistsInPeriodRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:WebAppUsageExistsInPeriodRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="WebAppUsageExistsInPeriodResponse">
        <soap:header message="tns:WebAppUsageExistsInPeriodResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:WebAppUsageExistsInPeriodResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:WebAppUsageExistsInPeriodResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:WebAppUsageExistsInPeriodResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetWebAppUsagesForPeriod">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Diagnostics/GetWebAppUsagesForPeriod" style="document" />
      <wsdl:input name="GetWebAppUsagesForPeriodRequest">
        <soap:header message="tns:GetWebAppUsagesForPeriodRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetWebAppUsagesForPeriodRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetWebAppUsagesForPeriodRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetWebAppUsagesForPeriodResponse">
        <soap:header message="tns:GetWebAppUsagesForPeriodResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetWebAppUsagesForPeriodResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetWebAppUsagesForPeriodResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetWebAppUsagesForPeriodResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfDiagnosticsService">
    <wsdl:port name="BasicHttpBinding_Diagnostics" binding="tns:BasicHttpBinding_Diagnostics">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/Diagnostics.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

