---
generated: true
uid: wsdl-Services88-Workflow
title: Services88.WorkflowAgent WSDL
---

# Services88.WorkflowAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfWorkflowService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:element name="CreateDefaultEmailFlow">
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
      <xs:element name="CreateDefaultEmailFlowResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:EmailFlow" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="EmailFlow">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="EmailFlowId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Status" type="tns:WorkflowDefinitionStatus" />
              <xs:element minOccurs="0" name="JumpToFinish" type="xs:boolean" />
              <xs:element minOccurs="0" name="StartOnlyOnce" type="xs:boolean" />
              <xs:element minOccurs="0" name="OverrideConsentSubscription" type="xs:boolean" />
              <xs:element minOccurs="0" name="FromType" type="tns:EmailFromType" />
              <xs:element minOccurs="0" name="FromName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FromAddr" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ReplyToType" type="tns:EmailReplyToType" />
              <xs:element minOccurs="0" name="ReplyToAddr" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ReplyToName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SmsSender" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UseGoogleAnalytics" type="xs:boolean" />
              <xs:element minOccurs="0" name="GaSource" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="GaCampaign" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UseTimeframe" type="xs:boolean" />
              <xs:element minOccurs="0" name="SelectedDays" type="tns:Weekday" />
              <xs:element minOccurs="0" name="TimeframeStart" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TimeframeEnd" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UseWorkflowStart" type="xs:boolean" />
              <xs:element minOccurs="0" name="WorkflowStart" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UseEnrollmentEnd" type="xs:boolean" />
              <xs:element minOccurs="0" name="EnrollmentEnd" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RemoveFromFlows" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="TzLocation" nillable="true" type="tns:TimeZoneData" />
              <xs:element minOccurs="0" name="Folder" nillable="true" type="tns:HierarchyEntity" />
              <xs:element minOccurs="0" name="Associate" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="ShipmentType" nillable="true" type="tns:MDOListItem" />
              <xs:element minOccurs="0" name="Steps" nillable="true" type="tns:ArrayOfWorkflowStepBase" />
              <xs:element minOccurs="0" name="Triggers" nillable="true" type="tns:ArrayOfWorkflowTrigger" />
              <xs:element minOccurs="0" name="Goals" nillable="true" type="tns:ArrayOfWorkflowGoal" />
              <xs:element minOccurs="0" name="Filter" nillable="true" type="tns:WorkflowFilter" />
              <xs:element minOccurs="0" name="BlockLists" nillable="true" type="q2:ArrayOfint" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="VisibleFor" nillable="true" type="tns:ArrayOfVisibleFor" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EmailFlow" nillable="true" type="tns:EmailFlow" />
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
      <xs:simpleType name="WorkflowDefinitionStatus">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Stopped" />
          <xs:enumeration value="Paused" />
          <xs:enumeration value="Running" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="WorkflowDefinitionStatus" nillable="true" type="tns:WorkflowDefinitionStatus" />
      <xs:simpleType name="EmailFromType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="FromOnlySpecified" />
          <xs:enumeration value="FromSalesContact" />
          <xs:enumeration value="FromSupportContact" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="EmailFromType" nillable="true" type="tns:EmailFromType" />
      <xs:simpleType name="EmailReplyToType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="ReplyToOnlySpecified" />
          <xs:enumeration value="ReplyToSalesContact" />
          <xs:enumeration value="ReplyToSupportContact" />
          <xs:enumeration value="ReplyToEmpty" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="EmailReplyToType" nillable="true" type="tns:EmailReplyToType" />
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
      <xs:element name="Weekday" nillable="true" type="tns:Weekday" />
      <xs:complexType name="TimeZoneData">
        <xs:sequence>
          <xs:element minOccurs="0" name="TZLocationID" type="xs:int" />
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="TZLocationCode" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="TZLocationCities" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="IsoNumber" type="xs:int" />
          <xs:element minOccurs="0" name="TimeZoneSTDRules" nillable="true" type="tns:TimeZoneRuleDictionary" />
          <xs:element minOccurs="0" name="TimeZoneDSTRules" nillable="true" type="tns:TimeZoneRuleDictionary" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TimeZoneData" nillable="true" type="tns:TimeZoneData" />
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
                <xs:element name="Value" nillable="true" type="tns:TimeZoneRule" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TimeZoneRuleDictionary" nillable="true" type="tns:TimeZoneRuleDictionary" />
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
      <xs:element name="TimeZoneRule" nillable="true" type="tns:TimeZoneRule" />
      <xs:complexType name="HierarchyEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="HierarchyId" type="xs:int" />
              <xs:element minOccurs="0" name="Domain" type="tns:Domain" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Fullname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ParentId" type="xs:int" />
              <xs:element minOccurs="0" name="Children" nillable="true" type="tns:ArrayOfHierarchyEntity" />
              <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RegisteredAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedAssociateId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="HierarchyEntity" nillable="true" type="tns:HierarchyEntity" />
      <xs:simpleType name="Domain">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="ExtraTables" />
          <xs:enumeration value="ScreenDefinitions" />
          <xs:enumeration value="Scripts" />
          <xs:enumeration value="Selections" />
          <xs:enumeration value="ExternalDocuments" />
          <xs:enumeration value="UserGroups" />
          <xs:enumeration value="ExternalDocumentRelatedToSpmMessage" />
          <xs:enumeration value="Dashboards" />
          <xs:enumeration value="EmailFlows" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="Domain" nillable="true" type="tns:Domain" />
      <xs:complexType name="ArrayOfHierarchyEntity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="HierarchyEntity" nillable="true" type="tns:HierarchyEntity" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfHierarchyEntity" nillable="true" type="tns:ArrayOfHierarchyEntity" />
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
      <xs:complexType name="MDOListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ToolTip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ChildItems" nillable="true" type="tns:ArrayOfMDOListItem" />
              <xs:element minOccurs="0" name="IconHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ColorBlock" type="xs:int" />
              <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StyleHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="MDOListItem" nillable="true" type="tns:MDOListItem" />
      <xs:complexType name="ArrayOfMDOListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="MDOListItem" nillable="true" type="tns:MDOListItem" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfMDOListItem" nillable="true" type="tns:ArrayOfMDOListItem" />
      <xs:complexType name="ArrayOfWorkflowStepBase">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="WorkflowStepBase" nillable="true" type="tns:WorkflowStepBase" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfWorkflowStepBase" nillable="true" type="tns:ArrayOfWorkflowStepBase" />
      <xs:complexType name="WorkflowStepBase">
        <xs:sequence>
          <xs:element minOccurs="0" name="WorkflowStepId" type="xs:int" />
          <xs:element minOccurs="0" name="WorkflowId" type="xs:int" />
          <xs:element minOccurs="0" name="StepType" type="tns:WorkflowStepType" />
          <xs:element minOccurs="0" name="Rank" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="WorkflowStepBase" nillable="true" type="tns:WorkflowStepBase" />
      <xs:simpleType name="WorkflowStepType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="SendEmail" />
          <xs:enumeration value="SendSMS" />
          <xs:enumeration value="WaitForTime" />
          <xs:enumeration value="WaitForAction" />
          <xs:enumeration value="Split" />
          <xs:enumeration value="UpdateParticipant" />
          <xs:enumeration value="AddToList" />
          <xs:enumeration value="RemoveFromList" />
          <xs:enumeration value="CreateRequest" />
          <xs:enumeration value="CreateFollowUp" />
          <xs:enumeration value="CreateSale" />
          <xs:enumeration value="NotifyByEmail" />
          <xs:enumeration value="NotifyBySMS" />
          <xs:enumeration value="RunScript" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="WorkflowStepType" nillable="true" type="tns:WorkflowStepType" />
      <xs:complexType name="WorkflowStepAddToList">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepBase">
            <xs:sequence>
              <xs:element minOccurs="0" name="Selection" type="xs:int" />
              <xs:element minOccurs="0" name="Project" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepAddToList" nillable="true" type="tns:WorkflowStepAddToList" />
      <xs:complexType name="WorkflowStepCreateFollowUp">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepBase">
            <xs:sequence>
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FollowUpType" type="xs:int" />
              <xs:element minOccurs="0" name="Project" type="xs:int" />
              <xs:element minOccurs="0" name="Completed" type="xs:boolean" />
              <xs:element minOccurs="0" name="ActionType" type="tns:WorkflowActionType" />
              <xs:element minOccurs="0" name="ActionTime" type="xs:int" />
              <xs:element minOccurs="0" name="ActionTimeUnit" type="tns:WorkflowTimeWaitIntervalType" />
              <xs:element minOccurs="0" name="Duration" type="xs:int" />
              <xs:element minOccurs="0" name="Availability" type="tns:FreeBusy" />
              <xs:element minOccurs="0" name="OwnerType" type="tns:WorkflowOwnerType" />
              <xs:element minOccurs="0" name="Agenda" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Owner" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepCreateFollowUp" nillable="true" type="tns:WorkflowStepCreateFollowUp" />
      <xs:simpleType name="WorkflowActionType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="FirstAvailable" />
          <xs:enumeration value="FirstAvailableAfter" />
          <xs:enumeration value="Today" />
          <xs:enumeration value="After" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="WorkflowActionType" nillable="true" type="tns:WorkflowActionType" />
      <xs:simpleType name="WorkflowTimeWaitIntervalType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Seconds" />
          <xs:enumeration value="Minutes" />
          <xs:enumeration value="Hours" />
          <xs:enumeration value="WorkingDays" />
          <xs:enumeration value="Days" />
          <xs:enumeration value="Weeks" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="WorkflowTimeWaitIntervalType" nillable="true" type="tns:WorkflowTimeWaitIntervalType" />
      <xs:simpleType name="FreeBusy">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Busy" />
          <xs:enumeration value="Free" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="FreeBusy" nillable="true" type="tns:FreeBusy" />
      <xs:simpleType name="WorkflowOwnerType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Specified" />
          <xs:enumeration value="OurContact" />
          <xs:enumeration value="OurSupportContact" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="WorkflowOwnerType" nillable="true" type="tns:WorkflowOwnerType" />
      <xs:complexType name="WorkflowStepCreateRequest">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepBase">
            <xs:sequence>
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RequestType" type="xs:int" />
              <xs:element minOccurs="0" name="Category" type="xs:int" />
              <xs:element minOccurs="0" name="Priority" type="xs:int" />
              <xs:element minOccurs="0" name="Status" type="xs:int" />
              <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Owner" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepCreateRequest" nillable="true" type="tns:WorkflowStepCreateRequest" />
      <xs:complexType name="WorkflowStepCreateSale">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepBase">
            <xs:sequence>
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SaleType" type="xs:int" />
              <xs:element minOccurs="0" name="Stage" type="xs:int" />
              <xs:element minOccurs="0" name="Amount" type="xs:double" />
              <xs:element minOccurs="0" name="Currency" type="xs:int" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Project" type="xs:int" />
              <xs:element minOccurs="0" name="SaleDateType" type="tns:WorkflowSaleDateType" />
              <xs:element minOccurs="0" name="Date" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Owner" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepCreateSale" nillable="true" type="tns:WorkflowStepCreateSale" />
      <xs:simpleType name="WorkflowSaleDateType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Estimated" />
          <xs:enumeration value="Equals" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="WorkflowSaleDateType" nillable="true" type="tns:WorkflowSaleDateType" />
      <xs:complexType name="WorkflowStepNotifyByEmail">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepBase">
            <xs:sequence />
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepNotifyByEmail" nillable="true" type="tns:WorkflowStepNotifyByEmail" />
      <xs:complexType name="WorkflowStepNotifyBySMS">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepBase">
            <xs:sequence />
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepNotifyBySMS" nillable="true" type="tns:WorkflowStepNotifyBySMS" />
      <xs:complexType name="WorkflowStepRemoveFromList">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepBase">
            <xs:sequence>
              <xs:element minOccurs="0" name="Selection" type="xs:int" />
              <xs:element minOccurs="0" name="Project" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepRemoveFromList" nillable="true" type="tns:WorkflowStepRemoveFromList" />
      <xs:complexType name="WorkflowStepRunScript">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepBase">
            <xs:sequence />
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepRunScript" nillable="true" type="tns:WorkflowStepRunScript" />
      <xs:complexType name="WorkflowStepSendEmail">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepBase">
            <xs:sequence>
              <xs:element minOccurs="0" name="Subject" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Attachments" nillable="true" type="q3:ArrayOfint" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="ShipmentId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepSendEmail" nillable="true" type="tns:WorkflowStepSendEmail" />
      <xs:complexType name="WorkflowStepSendSMS">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepBase">
            <xs:sequence />
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepSendSMS" nillable="true" type="tns:WorkflowStepSendSMS" />
      <xs:complexType name="WorkflowStepSplit">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepBase">
            <xs:sequence>
              <xs:element minOccurs="0" name="SplitOptionType" type="tns:WorkflowSplitOptionType" />
              <xs:element minOccurs="0" name="Options" nillable="true" type="tns:ArrayOfWorkflowStepOptionBase" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepSplit" nillable="true" type="tns:WorkflowStepSplit" />
      <xs:simpleType name="WorkflowSplitOptionType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="PersonData" />
          <xs:enumeration value="FormSubmission" />
          <xs:enumeration value="LinkClicked" />
          <xs:enumeration value="ProjectMembership" />
          <xs:enumeration value="SelectionMembership" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="WorkflowSplitOptionType" nillable="true" type="tns:WorkflowSplitOptionType" />
      <xs:complexType name="ArrayOfWorkflowStepOptionBase">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="WorkflowStepOptionBase" nillable="true" type="tns:WorkflowStepOptionBase" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfWorkflowStepOptionBase" nillable="true" type="tns:ArrayOfWorkflowStepOptionBase" />
      <xs:complexType name="WorkflowStepOptionBase">
        <xs:sequence>
          <xs:element minOccurs="0" name="OptionType" type="tns:WorkflowSplitOptionType" />
          <xs:element minOccurs="0" name="WorkflowStepOptionId" type="xs:int" />
          <xs:element minOccurs="0" name="WorkflowStepId" type="xs:int" />
          <xs:element minOccurs="0" name="WorkflowId" type="xs:int" />
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Rank" type="xs:int" />
          <xs:element minOccurs="0" name="Steps" nillable="true" type="tns:ArrayOfWorkflowStepBase" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="WorkflowStepOptionBase" nillable="true" type="tns:WorkflowStepOptionBase" />
      <xs:complexType name="WorkflowStepOptionFormSubmission">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepOptionBase">
            <xs:sequence>
              <xs:element minOccurs="0" name="FormId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepOptionFormSubmission" nillable="true" type="tns:WorkflowStepOptionFormSubmission" />
      <xs:complexType name="WorkflowStepOptionLinkClicked">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepOptionBase">
            <xs:sequence>
              <xs:element minOccurs="0" name="LinkId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepOptionLinkClicked" nillable="true" type="tns:WorkflowStepOptionLinkClicked" />
      <xs:complexType name="WorkflowStepOptionPersonData">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepOptionBase">
            <xs:sequence>
              <xs:element minOccurs="0" name="RestrictionGroups" nillable="true" type="tns:ArrayOfArchiveRestrictionGroup" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepOptionPersonData" nillable="true" type="tns:WorkflowStepOptionPersonData" />
      <xs:complexType name="ArrayOfArchiveRestrictionGroup">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArchiveRestrictionGroup" nillable="true" type="tns:ArchiveRestrictionGroup" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArchiveRestrictionGroup" nillable="true" type="tns:ArrayOfArchiveRestrictionGroup" />
      <xs:complexType name="ArchiveRestrictionGroup">
        <xs:sequence>
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Rank" type="xs:short" />
          <xs:element minOccurs="0" name="Restrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArchiveRestrictionGroup" nillable="true" type="tns:ArchiveRestrictionGroup" />
      <xs:complexType name="ArrayOfArchiveRestrictionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArchiveRestrictionInfo" nillable="true" type="tns:ArchiveRestrictionInfo" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArchiveRestrictionInfo" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
      <xs:complexType name="ArchiveRestrictionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Operator" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Values" nillable="true" type="q4:ArrayOfstring" xmlns:q4="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="DisplayValues" nillable="true" type="q5:ArrayOfstring" xmlns:q5="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          <xs:element minOccurs="0" name="ColumnInfo" nillable="true" type="tns:ArchiveColumnInfo" />
          <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
          <xs:element minOccurs="0" name="SubRestrictions" nillable="true" type="tns:ArrayOfArchiveRestrictionInfo" />
          <xs:element minOccurs="0" name="InterParenthesis" type="xs:int" />
          <xs:element minOccurs="0" name="InterOperator" type="tns:InterRestrictionOperator" />
          <xs:element minOccurs="0" name="UniqueHash" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArchiveRestrictionInfo" nillable="true" type="tns:ArchiveRestrictionInfo" />
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
      <xs:element name="ArchiveColumnInfo" nillable="true" type="tns:ArchiveColumnInfo" />
      <xs:simpleType name="InterRestrictionOperator">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="And" />
          <xs:enumeration value="Or" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="InterRestrictionOperator" nillable="true" type="tns:InterRestrictionOperator" />
      <xs:complexType name="WorkflowStepOptionProjectMembership">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepOptionBase">
            <xs:sequence>
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepOptionProjectMembership" nillable="true" type="tns:WorkflowStepOptionProjectMembership" />
      <xs:complexType name="WorkflowStepOptionSelectionMembership">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepOptionBase">
            <xs:sequence>
              <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepOptionSelectionMembership" nillable="true" type="tns:WorkflowStepOptionSelectionMembership" />
      <xs:complexType name="WorkflowStepUpdateParticipant">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepBase">
            <xs:sequence />
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepUpdateParticipant" nillable="true" type="tns:WorkflowStepUpdateParticipant" />
      <xs:complexType name="WorkflowStepWaitForAction">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepBase">
            <xs:sequence />
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepWaitForAction" nillable="true" type="tns:WorkflowStepWaitForAction" />
      <xs:complexType name="WorkflowStepWaitForTime">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:WorkflowStepBase">
            <xs:sequence>
              <xs:element minOccurs="0" name="TimeWaitAlgorithm" type="tns:WorkflowTimeWaitAlgorithm" />
              <xs:element minOccurs="0" name="NumIntervals" type="xs:int" />
              <xs:element minOccurs="0" name="IntervalType" type="tns:WorkflowTimeWaitIntervalType" />
              <xs:element minOccurs="0" name="Until" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStepWaitForTime" nillable="true" type="tns:WorkflowStepWaitForTime" />
      <xs:simpleType name="WorkflowTimeWaitAlgorithm">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="NumIntervals" />
          <xs:enumeration value="UntilSpecified" />
          <xs:enumeration value="UntilDateField" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="WorkflowTimeWaitAlgorithm" nillable="true" type="tns:WorkflowTimeWaitAlgorithm" />
      <xs:complexType name="ArrayOfWorkflowTrigger">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="WorkflowTrigger" nillable="true" type="tns:WorkflowTrigger" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfWorkflowTrigger" nillable="true" type="tns:ArrayOfWorkflowTrigger" />
      <xs:complexType name="WorkflowTrigger">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="WorkflowTriggerId" type="xs:int" />
              <xs:element minOccurs="0" name="WorkflowId" type="xs:int" />
              <xs:element minOccurs="0" name="TriggerType" type="tns:WorkflowTriggerType" />
              <xs:element minOccurs="0" name="RestrictionGroups" nillable="true" type="tns:ArrayOfArchiveRestrictionGroup" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowTrigger" nillable="true" type="tns:WorkflowTrigger" />
      <xs:simpleType name="WorkflowTriggerType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="PersonCreated" />
          <xs:enumeration value="PersonUpdated" />
          <xs:enumeration value="AddedToProject" />
          <xs:enumeration value="CreatedRequest" />
          <xs:enumeration value="LinkClicked" />
          <xs:enumeration value="AddedToSelection" />
          <xs:enumeration value="FormSubmitted" />
          <xs:enumeration value="AddedMessage" />
          <xs:enumeration value="StartedChat" />
          <xs:enumeration value="OrderPlaced" />
          <xs:enumeration value="SaleCreated" />
          <xs:enumeration value="SaleSold" />
          <xs:enumeration value="SaleLost" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="WorkflowTriggerType" nillable="true" type="tns:WorkflowTriggerType" />
      <xs:complexType name="ArrayOfWorkflowGoal">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="WorkflowGoal" nillable="true" type="tns:WorkflowGoal" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfWorkflowGoal" nillable="true" type="tns:ArrayOfWorkflowGoal" />
      <xs:complexType name="WorkflowGoal">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="WorkflowGoalId" type="xs:int" />
              <xs:element minOccurs="0" name="WorkflowId" type="xs:int" />
              <xs:element minOccurs="0" name="GoalType" type="tns:WorkflowGoalType" />
              <xs:element minOccurs="0" name="RestrictionGroups" nillable="true" type="tns:ArrayOfArchiveRestrictionGroup" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowGoal" nillable="true" type="tns:WorkflowGoal" />
      <xs:simpleType name="WorkflowGoalType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="PersonUpdated" />
          <xs:enumeration value="SaleCreatedOnPerson" />
          <xs:enumeration value="SaleCreatedOnCompany" />
          <xs:enumeration value="AppointmentCreated" />
          <xs:enumeration value="AddedToProject" />
          <xs:enumeration value="AddedToSelection" />
          <xs:enumeration value="FormSubmitted" />
          <xs:enumeration value="HadChat" />
          <xs:enumeration value="LinkClicked" />
          <xs:enumeration value="RequestCreated" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="WorkflowGoalType" nillable="true" type="tns:WorkflowGoalType" />
      <xs:complexType name="WorkflowFilter">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="RestrictionGroups" nillable="true" type="tns:ArrayOfArchiveRestrictionGroup" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowFilter" nillable="true" type="tns:WorkflowFilter" />
      <xs:complexType name="ArrayOfVisibleFor">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="VisibleFor" nillable="true" type="tns:VisibleFor" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfVisibleFor" nillable="true" type="tns:ArrayOfVisibleFor" />
      <xs:complexType name="VisibleFor">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="VisibleId" type="xs:int" />
              <xs:element minOccurs="0" name="Visibility" type="tns:Visibility" />
              <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="VisibleFor" nillable="true" type="tns:VisibleFor" />
      <xs:simpleType name="Visibility">
        <xs:restriction base="xs:string">
          <xs:enumeration value="All" />
          <xs:enumeration value="Associate" />
          <xs:enumeration value="Group" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="Visibility" nillable="true" type="tns:Visibility" />
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
      <xs:element name="SaveEmailFlow">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailFlow" nillable="true" type="tns:EmailFlow" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveEmailFlowResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:EmailFlow" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteEmailFlow">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailFlowId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteEmailFlowResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultWorkflowEvent">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultWorkflowEventResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowEvent" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="WorkflowEvent">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="EventType" type="tns:WorkflowEventType" />
              <xs:element minOccurs="0" name="Attributes" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowEvent" nillable="true" type="tns:WorkflowEvent" />
      <xs:simpleType name="WorkflowEventType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Run" />
          <xs:enumeration value="PersonCreated">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1001</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="PersonUpdated">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1002</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="AddedToProject">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1003</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="CreatedRequest">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1004</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="LinkClicked">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1005</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="AddedToSelection">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1006</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="FormSubmitted">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1007</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="AddedMessage">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1008</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="StartedChat">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1009</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="OrderPlaced">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1010</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SaleCreated">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1011</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SaleSold">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1012</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SaleLost">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1013</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="WorkflowEventType" nillable="true" type="tns:WorkflowEventType" />
      <xs:element name="CreateDefaultWorkflowEventResult">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultWorkflowEventResultResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowEventResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="WorkflowEventResult">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="EventType" type="tns:WorkflowEventType" />
              <xs:element minOccurs="0" name="Attributes" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowEventResult" nillable="true" type="tns:WorkflowEventResult" />
      <xs:element name="CreateDefaultWorkflowFilter">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultWorkflowFilterResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowFilter" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultWorkflowGoal">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultWorkflowGoalResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowGoal" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveWorkflowGoal">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WorkflowGoal" nillable="true" type="tns:WorkflowGoal" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveWorkflowGoalResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowGoal" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteWorkflowGoal">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WorkflowGoalId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteWorkflowGoalResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultWorkflowTrigger">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultWorkflowTriggerResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowTrigger" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveWorkflowTrigger">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WorkflowTrigger" nillable="true" type="tns:WorkflowTrigger" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveWorkflowTriggerResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowTrigger" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteWorkflowTrigger">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WorkflowTriggerId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteWorkflowTriggerResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEmailFlow">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailFlowId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEmailFlowResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:EmailFlow" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TryAddPersonsToEmailFlow">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailFlowId" type="xs:int" />
            <xs:element minOccurs="0" name="PersonIds" nillable="true" type="q6:ArrayOfint" xmlns:q6="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TryAddPersonsToEmailFlowResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q7:ArrayOfboolean" xmlns:q7="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveParticipantsFromEmailFlow">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailFlowId" type="xs:int" />
            <xs:element minOccurs="0" name="WorkflowInstanceIds" nillable="true" type="q8:ArrayOfint" xmlns:q8="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveParticipantsFromEmailFlowResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateEmailFlowContent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailFlowId" type="xs:int" />
            <xs:element minOccurs="0" name="ContentName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateEmailFlowContentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ConnectEmailFlowContent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailFlowId" type="xs:int" />
            <xs:element minOccurs="0" name="MessageId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ConnectEmailFlowContentResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CopyEmailFlowContent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailFlowId" type="xs:int" />
            <xs:element minOccurs="0" name="ShipmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopyEmailFlowContentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Run">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RunResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:dateTime" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SendEvent">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WorkflowEvent" nillable="true" type="tns:WorkflowEvent" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SendEventResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowEventResult" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWorkflowGoal">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WorkflowGoalId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWorkflowGoalResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowGoal" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWorkflowStep">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WorkflowStepId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWorkflowStepResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowStepBase" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddAfterWorkflowStep">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WorkflowStepId" type="xs:int" />
            <xs:element minOccurs="0" name="SubStep" nillable="true" type="tns:WorkflowStepBase" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddAfterWorkflowStepResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowStepBase" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultWorkflowStepFromType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StepType" type="tns:WorkflowStepType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultWorkflowStepFromTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowStepBase" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultWorkflowStepOptionFromType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OptionType" type="tns:WorkflowSplitOptionType" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultWorkflowStepOptionFromTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowStepOptionBase" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWorkflowStepOption">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WorkflowStepOptionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWorkflowStepOptionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowStepOptionBase" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWorkflowTrigger">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WorkflowTriggerId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetWorkflowTriggerResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowTrigger" />
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
      <xs:complexType name="ArrayOfboolean">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="boolean" type="xs:boolean" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfboolean" nillable="true" type="tns:ArrayOfboolean" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="CreateDefaultEmailFlowRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultEmailFlow" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEmailFlowRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEmailFlowResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultEmailFlowResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEmailFlowResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveEmailFlowRequest">
    <wsdl:part name="parameters" element="tns:SaveEmailFlow" />
  </wsdl:message>
  <wsdl:message name="SaveEmailFlowRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveEmailFlowResponse">
    <wsdl:part name="parameters" element="tns:SaveEmailFlowResponse" />
  </wsdl:message>
  <wsdl:message name="SaveEmailFlowResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteEmailFlowRequest">
    <wsdl:part name="parameters" element="tns:DeleteEmailFlow" />
  </wsdl:message>
  <wsdl:message name="DeleteEmailFlowRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteEmailFlowResponse">
    <wsdl:part name="parameters" element="tns:DeleteEmailFlowResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteEmailFlowResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowEventRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultWorkflowEvent" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowEventRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowEventResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultWorkflowEventResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowEventResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowEventResultRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultWorkflowEventResult" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowEventResultRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowEventResultResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultWorkflowEventResultResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowEventResultResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowFilterRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultWorkflowFilter" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowFilterRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowFilterResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultWorkflowFilterResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowFilterResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowGoalRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultWorkflowGoal" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowGoalRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowGoalResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultWorkflowGoalResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowGoalResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveWorkflowGoalRequest">
    <wsdl:part name="parameters" element="tns:SaveWorkflowGoal" />
  </wsdl:message>
  <wsdl:message name="SaveWorkflowGoalRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveWorkflowGoalResponse">
    <wsdl:part name="parameters" element="tns:SaveWorkflowGoalResponse" />
  </wsdl:message>
  <wsdl:message name="SaveWorkflowGoalResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteWorkflowGoalRequest">
    <wsdl:part name="parameters" element="tns:DeleteWorkflowGoal" />
  </wsdl:message>
  <wsdl:message name="DeleteWorkflowGoalRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteWorkflowGoalResponse">
    <wsdl:part name="parameters" element="tns:DeleteWorkflowGoalResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteWorkflowGoalResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowTriggerRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultWorkflowTrigger" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowTriggerRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowTriggerResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultWorkflowTriggerResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowTriggerResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveWorkflowTriggerRequest">
    <wsdl:part name="parameters" element="tns:SaveWorkflowTrigger" />
  </wsdl:message>
  <wsdl:message name="SaveWorkflowTriggerRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveWorkflowTriggerResponse">
    <wsdl:part name="parameters" element="tns:SaveWorkflowTriggerResponse" />
  </wsdl:message>
  <wsdl:message name="SaveWorkflowTriggerResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteWorkflowTriggerRequest">
    <wsdl:part name="parameters" element="tns:DeleteWorkflowTrigger" />
  </wsdl:message>
  <wsdl:message name="DeleteWorkflowTriggerRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteWorkflowTriggerResponse">
    <wsdl:part name="parameters" element="tns:DeleteWorkflowTriggerResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteWorkflowTriggerResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEmailFlowRequest">
    <wsdl:part name="parameters" element="tns:GetEmailFlow" />
  </wsdl:message>
  <wsdl:message name="GetEmailFlowRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEmailFlowResponse">
    <wsdl:part name="parameters" element="tns:GetEmailFlowResponse" />
  </wsdl:message>
  <wsdl:message name="GetEmailFlowResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TryAddPersonsToEmailFlowRequest">
    <wsdl:part name="parameters" element="tns:TryAddPersonsToEmailFlow" />
  </wsdl:message>
  <wsdl:message name="TryAddPersonsToEmailFlowRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TryAddPersonsToEmailFlowResponse">
    <wsdl:part name="parameters" element="tns:TryAddPersonsToEmailFlowResponse" />
  </wsdl:message>
  <wsdl:message name="TryAddPersonsToEmailFlowResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveParticipantsFromEmailFlowRequest">
    <wsdl:part name="parameters" element="tns:RemoveParticipantsFromEmailFlow" />
  </wsdl:message>
  <wsdl:message name="RemoveParticipantsFromEmailFlowRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveParticipantsFromEmailFlowResponse">
    <wsdl:part name="parameters" element="tns:RemoveParticipantsFromEmailFlowResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveParticipantsFromEmailFlowResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateEmailFlowContentRequest">
    <wsdl:part name="parameters" element="tns:CreateEmailFlowContent" />
  </wsdl:message>
  <wsdl:message name="CreateEmailFlowContentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateEmailFlowContentResponse">
    <wsdl:part name="parameters" element="tns:CreateEmailFlowContentResponse" />
  </wsdl:message>
  <wsdl:message name="CreateEmailFlowContentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ConnectEmailFlowContentRequest">
    <wsdl:part name="parameters" element="tns:ConnectEmailFlowContent" />
  </wsdl:message>
  <wsdl:message name="ConnectEmailFlowContentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ConnectEmailFlowContentResponse">
    <wsdl:part name="parameters" element="tns:ConnectEmailFlowContentResponse" />
  </wsdl:message>
  <wsdl:message name="ConnectEmailFlowContentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopyEmailFlowContentRequest">
    <wsdl:part name="parameters" element="tns:CopyEmailFlowContent" />
  </wsdl:message>
  <wsdl:message name="CopyEmailFlowContentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopyEmailFlowContentResponse">
    <wsdl:part name="parameters" element="tns:CopyEmailFlowContentResponse" />
  </wsdl:message>
  <wsdl:message name="CopyEmailFlowContentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RunRequest">
    <wsdl:part name="parameters" element="tns:Run" />
  </wsdl:message>
  <wsdl:message name="RunRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RunResponse">
    <wsdl:part name="parameters" element="tns:RunResponse" />
  </wsdl:message>
  <wsdl:message name="RunResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendEventRequest">
    <wsdl:part name="parameters" element="tns:SendEvent" />
  </wsdl:message>
  <wsdl:message name="SendEventRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendEventResponse">
    <wsdl:part name="parameters" element="tns:SendEventResponse" />
  </wsdl:message>
  <wsdl:message name="SendEventResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWorkflowGoalRequest">
    <wsdl:part name="parameters" element="tns:GetWorkflowGoal" />
  </wsdl:message>
  <wsdl:message name="GetWorkflowGoalRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWorkflowGoalResponse">
    <wsdl:part name="parameters" element="tns:GetWorkflowGoalResponse" />
  </wsdl:message>
  <wsdl:message name="GetWorkflowGoalResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWorkflowStepRequest">
    <wsdl:part name="parameters" element="tns:GetWorkflowStep" />
  </wsdl:message>
  <wsdl:message name="GetWorkflowStepRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWorkflowStepResponse">
    <wsdl:part name="parameters" element="tns:GetWorkflowStepResponse" />
  </wsdl:message>
  <wsdl:message name="GetWorkflowStepResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddAfterWorkflowStepRequest">
    <wsdl:part name="parameters" element="tns:AddAfterWorkflowStep" />
  </wsdl:message>
  <wsdl:message name="AddAfterWorkflowStepRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddAfterWorkflowStepResponse">
    <wsdl:part name="parameters" element="tns:AddAfterWorkflowStepResponse" />
  </wsdl:message>
  <wsdl:message name="AddAfterWorkflowStepResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowStepFromTypeRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultWorkflowStepFromType" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowStepFromTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowStepFromTypeResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultWorkflowStepFromTypeResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowStepFromTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowStepOptionFromTypeRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultWorkflowStepOptionFromType" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowStepOptionFromTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowStepOptionFromTypeResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultWorkflowStepOptionFromTypeResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowStepOptionFromTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWorkflowStepOptionRequest">
    <wsdl:part name="parameters" element="tns:GetWorkflowStepOption" />
  </wsdl:message>
  <wsdl:message name="GetWorkflowStepOptionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWorkflowStepOptionResponse">
    <wsdl:part name="parameters" element="tns:GetWorkflowStepOptionResponse" />
  </wsdl:message>
  <wsdl:message name="GetWorkflowStepOptionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWorkflowTriggerRequest">
    <wsdl:part name="parameters" element="tns:GetWorkflowTrigger" />
  </wsdl:message>
  <wsdl:message name="GetWorkflowTriggerRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetWorkflowTriggerResponse">
    <wsdl:part name="parameters" element="tns:GetWorkflowTriggerResponse" />
  </wsdl:message>
  <wsdl:message name="GetWorkflowTriggerResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Workflow">
    <wsdl:operation name="CreateDefaultEmailFlow">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultEmailFlow" name="CreateDefaultEmailFlowRequest" message="tns:CreateDefaultEmailFlowRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultEmailFlowResponse" name="CreateDefaultEmailFlowResponse" message="tns:CreateDefaultEmailFlowResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveEmailFlow">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/SaveEmailFlow" name="SaveEmailFlowRequest" message="tns:SaveEmailFlowRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/SaveEmailFlowResponse" name="SaveEmailFlowResponse" message="tns:SaveEmailFlowResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteEmailFlow">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/DeleteEmailFlow" name="DeleteEmailFlowRequest" message="tns:DeleteEmailFlowRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/DeleteEmailFlowResponse" name="DeleteEmailFlowResponse" message="tns:DeleteEmailFlowResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultWorkflowEvent">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowEvent" name="CreateDefaultWorkflowEventRequest" message="tns:CreateDefaultWorkflowEventRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowEventResponse" name="CreateDefaultWorkflowEventResponse" message="tns:CreateDefaultWorkflowEventResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultWorkflowEventResult">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowEventResult" name="CreateDefaultWorkflowEventResultRequest" message="tns:CreateDefaultWorkflowEventResultRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowEventResultResponse" name="CreateDefaultWorkflowEventResultResponse" message="tns:CreateDefaultWorkflowEventResultResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultWorkflowFilter">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowFilter" name="CreateDefaultWorkflowFilterRequest" message="tns:CreateDefaultWorkflowFilterRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowFilterResponse" name="CreateDefaultWorkflowFilterResponse" message="tns:CreateDefaultWorkflowFilterResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultWorkflowGoal">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowGoal" name="CreateDefaultWorkflowGoalRequest" message="tns:CreateDefaultWorkflowGoalRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowGoalResponse" name="CreateDefaultWorkflowGoalResponse" message="tns:CreateDefaultWorkflowGoalResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveWorkflowGoal">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/SaveWorkflowGoal" name="SaveWorkflowGoalRequest" message="tns:SaveWorkflowGoalRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/SaveWorkflowGoalResponse" name="SaveWorkflowGoalResponse" message="tns:SaveWorkflowGoalResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteWorkflowGoal">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/DeleteWorkflowGoal" name="DeleteWorkflowGoalRequest" message="tns:DeleteWorkflowGoalRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/DeleteWorkflowGoalResponse" name="DeleteWorkflowGoalResponse" message="tns:DeleteWorkflowGoalResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultWorkflowTrigger">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowTrigger" name="CreateDefaultWorkflowTriggerRequest" message="tns:CreateDefaultWorkflowTriggerRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowTriggerResponse" name="CreateDefaultWorkflowTriggerResponse" message="tns:CreateDefaultWorkflowTriggerResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveWorkflowTrigger">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/SaveWorkflowTrigger" name="SaveWorkflowTriggerRequest" message="tns:SaveWorkflowTriggerRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/SaveWorkflowTriggerResponse" name="SaveWorkflowTriggerResponse" message="tns:SaveWorkflowTriggerResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteWorkflowTrigger">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/DeleteWorkflowTrigger" name="DeleteWorkflowTriggerRequest" message="tns:DeleteWorkflowTriggerRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/DeleteWorkflowTriggerResponse" name="DeleteWorkflowTriggerResponse" message="tns:DeleteWorkflowTriggerResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEmailFlow">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetEmailFlow" name="GetEmailFlowRequest" message="tns:GetEmailFlowRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetEmailFlowResponse" name="GetEmailFlowResponse" message="tns:GetEmailFlowResponse" />
    </wsdl:operation>
    <wsdl:operation name="TryAddPersonsToEmailFlow">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/TryAddPersonsToEmailFlow" name="TryAddPersonsToEmailFlowRequest" message="tns:TryAddPersonsToEmailFlowRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/TryAddPersonsToEmailFlowResponse" name="TryAddPersonsToEmailFlowResponse" message="tns:TryAddPersonsToEmailFlowResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveParticipantsFromEmailFlow">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/RemoveParticipantsFromEmailFlow" name="RemoveParticipantsFromEmailFlowRequest" message="tns:RemoveParticipantsFromEmailFlowRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/RemoveParticipantsFromEmailFlowResponse" name="RemoveParticipantsFromEmailFlowResponse" message="tns:RemoveParticipantsFromEmailFlowResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateEmailFlowContent">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateEmailFlowContent" name="CreateEmailFlowContentRequest" message="tns:CreateEmailFlowContentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateEmailFlowContentResponse" name="CreateEmailFlowContentResponse" message="tns:CreateEmailFlowContentResponse" />
    </wsdl:operation>
    <wsdl:operation name="ConnectEmailFlowContent">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/ConnectEmailFlowContent" name="ConnectEmailFlowContentRequest" message="tns:ConnectEmailFlowContentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/ConnectEmailFlowContentResponse" name="ConnectEmailFlowContentResponse" message="tns:ConnectEmailFlowContentResponse" />
    </wsdl:operation>
    <wsdl:operation name="CopyEmailFlowContent">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CopyEmailFlowContent" name="CopyEmailFlowContentRequest" message="tns:CopyEmailFlowContentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CopyEmailFlowContentResponse" name="CopyEmailFlowContentResponse" message="tns:CopyEmailFlowContentResponse" />
    </wsdl:operation>
    <wsdl:operation name="Run">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/Run" name="RunRequest" message="tns:RunRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/RunResponse" name="RunResponse" message="tns:RunResponse" />
    </wsdl:operation>
    <wsdl:operation name="SendEvent">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/SendEvent" name="SendEventRequest" message="tns:SendEventRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/SendEventResponse" name="SendEventResponse" message="tns:SendEventResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetWorkflowGoal">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetWorkflowGoal" name="GetWorkflowGoalRequest" message="tns:GetWorkflowGoalRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetWorkflowGoalResponse" name="GetWorkflowGoalResponse" message="tns:GetWorkflowGoalResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetWorkflowStep">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetWorkflowStep" name="GetWorkflowStepRequest" message="tns:GetWorkflowStepRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetWorkflowStepResponse" name="GetWorkflowStepResponse" message="tns:GetWorkflowStepResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddAfterWorkflowStep">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/AddAfterWorkflowStep" name="AddAfterWorkflowStepRequest" message="tns:AddAfterWorkflowStepRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/AddAfterWorkflowStepResponse" name="AddAfterWorkflowStepResponse" message="tns:AddAfterWorkflowStepResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultWorkflowStepFromType">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowStepFromType" name="CreateDefaultWorkflowStepFromTypeRequest" message="tns:CreateDefaultWorkflowStepFromTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowStepFromTypeResponse" name="CreateDefaultWorkflowStepFromTypeResponse" message="tns:CreateDefaultWorkflowStepFromTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultWorkflowStepOptionFromType">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowStepOptionFromType" name="CreateDefaultWorkflowStepOptionFromTypeRequest" message="tns:CreateDefaultWorkflowStepOptionFromTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowStepOptionFromTypeResponse" name="CreateDefaultWorkflowStepOptionFromTypeResponse" message="tns:CreateDefaultWorkflowStepOptionFromTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetWorkflowStepOption">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetWorkflowStepOption" name="GetWorkflowStepOptionRequest" message="tns:GetWorkflowStepOptionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetWorkflowStepOptionResponse" name="GetWorkflowStepOptionResponse" message="tns:GetWorkflowStepOptionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetWorkflowTrigger">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetWorkflowTrigger" name="GetWorkflowTriggerRequest" message="tns:GetWorkflowTriggerRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetWorkflowTriggerResponse" name="GetWorkflowTriggerResponse" message="tns:GetWorkflowTriggerResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Workflow" type="tns:Workflow">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="CreateDefaultEmailFlow">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultEmailFlow" style="document" />
      <wsdl:input name="CreateDefaultEmailFlowRequest">
        <soap:header message="tns:CreateDefaultEmailFlowRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultEmailFlowRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultEmailFlowRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultEmailFlowResponse">
        <soap:header message="tns:CreateDefaultEmailFlowResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEmailFlowResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEmailFlowResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultEmailFlowResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveEmailFlow">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/SaveEmailFlow" style="document" />
      <wsdl:input name="SaveEmailFlowRequest">
        <soap:header message="tns:SaveEmailFlowRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveEmailFlowRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveEmailFlowRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveEmailFlowResponse">
        <soap:header message="tns:SaveEmailFlowResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveEmailFlowResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveEmailFlowResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveEmailFlowResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteEmailFlow">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/DeleteEmailFlow" style="document" />
      <wsdl:input name="DeleteEmailFlowRequest">
        <soap:header message="tns:DeleteEmailFlowRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteEmailFlowRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteEmailFlowRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteEmailFlowResponse">
        <soap:header message="tns:DeleteEmailFlowResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteEmailFlowResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteEmailFlowResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteEmailFlowResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultWorkflowEvent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowEvent" style="document" />
      <wsdl:input name="CreateDefaultWorkflowEventRequest">
        <soap:header message="tns:CreateDefaultWorkflowEventRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowEventRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowEventRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultWorkflowEventResponse">
        <soap:header message="tns:CreateDefaultWorkflowEventResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowEventResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowEventResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowEventResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultWorkflowEventResult">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowEventResult" style="document" />
      <wsdl:input name="CreateDefaultWorkflowEventResultRequest">
        <soap:header message="tns:CreateDefaultWorkflowEventResultRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowEventResultRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowEventResultRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultWorkflowEventResultResponse">
        <soap:header message="tns:CreateDefaultWorkflowEventResultResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowEventResultResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowEventResultResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowEventResultResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultWorkflowFilter">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowFilter" style="document" />
      <wsdl:input name="CreateDefaultWorkflowFilterRequest">
        <soap:header message="tns:CreateDefaultWorkflowFilterRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowFilterRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowFilterRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultWorkflowFilterResponse">
        <soap:header message="tns:CreateDefaultWorkflowFilterResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowFilterResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowFilterResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowFilterResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultWorkflowGoal">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowGoal" style="document" />
      <wsdl:input name="CreateDefaultWorkflowGoalRequest">
        <soap:header message="tns:CreateDefaultWorkflowGoalRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowGoalRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowGoalRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultWorkflowGoalResponse">
        <soap:header message="tns:CreateDefaultWorkflowGoalResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowGoalResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowGoalResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowGoalResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveWorkflowGoal">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/SaveWorkflowGoal" style="document" />
      <wsdl:input name="SaveWorkflowGoalRequest">
        <soap:header message="tns:SaveWorkflowGoalRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveWorkflowGoalRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveWorkflowGoalRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveWorkflowGoalResponse">
        <soap:header message="tns:SaveWorkflowGoalResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveWorkflowGoalResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveWorkflowGoalResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveWorkflowGoalResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteWorkflowGoal">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/DeleteWorkflowGoal" style="document" />
      <wsdl:input name="DeleteWorkflowGoalRequest">
        <soap:header message="tns:DeleteWorkflowGoalRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteWorkflowGoalRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteWorkflowGoalRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteWorkflowGoalResponse">
        <soap:header message="tns:DeleteWorkflowGoalResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteWorkflowGoalResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteWorkflowGoalResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteWorkflowGoalResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultWorkflowTrigger">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowTrigger" style="document" />
      <wsdl:input name="CreateDefaultWorkflowTriggerRequest">
        <soap:header message="tns:CreateDefaultWorkflowTriggerRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowTriggerRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowTriggerRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultWorkflowTriggerResponse">
        <soap:header message="tns:CreateDefaultWorkflowTriggerResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowTriggerResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowTriggerResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowTriggerResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveWorkflowTrigger">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/SaveWorkflowTrigger" style="document" />
      <wsdl:input name="SaveWorkflowTriggerRequest">
        <soap:header message="tns:SaveWorkflowTriggerRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveWorkflowTriggerRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveWorkflowTriggerRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveWorkflowTriggerResponse">
        <soap:header message="tns:SaveWorkflowTriggerResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveWorkflowTriggerResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveWorkflowTriggerResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveWorkflowTriggerResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteWorkflowTrigger">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/DeleteWorkflowTrigger" style="document" />
      <wsdl:input name="DeleteWorkflowTriggerRequest">
        <soap:header message="tns:DeleteWorkflowTriggerRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteWorkflowTriggerRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteWorkflowTriggerRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteWorkflowTriggerResponse">
        <soap:header message="tns:DeleteWorkflowTriggerResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteWorkflowTriggerResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteWorkflowTriggerResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteWorkflowTriggerResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEmailFlow">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetEmailFlow" style="document" />
      <wsdl:input name="GetEmailFlowRequest">
        <soap:header message="tns:GetEmailFlowRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEmailFlowRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEmailFlowRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEmailFlowResponse">
        <soap:header message="tns:GetEmailFlowResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEmailFlowResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEmailFlowResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEmailFlowResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="TryAddPersonsToEmailFlow">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/TryAddPersonsToEmailFlow" style="document" />
      <wsdl:input name="TryAddPersonsToEmailFlowRequest">
        <soap:header message="tns:TryAddPersonsToEmailFlowRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TryAddPersonsToEmailFlowRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TryAddPersonsToEmailFlowRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TryAddPersonsToEmailFlowResponse">
        <soap:header message="tns:TryAddPersonsToEmailFlowResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TryAddPersonsToEmailFlowResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TryAddPersonsToEmailFlowResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TryAddPersonsToEmailFlowResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveParticipantsFromEmailFlow">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/RemoveParticipantsFromEmailFlow" style="document" />
      <wsdl:input name="RemoveParticipantsFromEmailFlowRequest">
        <soap:header message="tns:RemoveParticipantsFromEmailFlowRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveParticipantsFromEmailFlowRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveParticipantsFromEmailFlowRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveParticipantsFromEmailFlowResponse">
        <soap:header message="tns:RemoveParticipantsFromEmailFlowResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveParticipantsFromEmailFlowResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveParticipantsFromEmailFlowResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveParticipantsFromEmailFlowResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateEmailFlowContent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateEmailFlowContent" style="document" />
      <wsdl:input name="CreateEmailFlowContentRequest">
        <soap:header message="tns:CreateEmailFlowContentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateEmailFlowContentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateEmailFlowContentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateEmailFlowContentResponse">
        <soap:header message="tns:CreateEmailFlowContentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateEmailFlowContentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateEmailFlowContentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateEmailFlowContentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ConnectEmailFlowContent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/ConnectEmailFlowContent" style="document" />
      <wsdl:input name="ConnectEmailFlowContentRequest">
        <soap:header message="tns:ConnectEmailFlowContentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ConnectEmailFlowContentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ConnectEmailFlowContentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ConnectEmailFlowContentResponse">
        <soap:header message="tns:ConnectEmailFlowContentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ConnectEmailFlowContentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ConnectEmailFlowContentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ConnectEmailFlowContentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CopyEmailFlowContent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CopyEmailFlowContent" style="document" />
      <wsdl:input name="CopyEmailFlowContentRequest">
        <soap:header message="tns:CopyEmailFlowContentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CopyEmailFlowContentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CopyEmailFlowContentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CopyEmailFlowContentResponse">
        <soap:header message="tns:CopyEmailFlowContentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CopyEmailFlowContentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CopyEmailFlowContentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CopyEmailFlowContentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Run">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/Run" style="document" />
      <wsdl:input name="RunRequest">
        <soap:header message="tns:RunRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RunRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RunRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RunResponse">
        <soap:header message="tns:RunResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RunResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RunResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RunResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SendEvent">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/SendEvent" style="document" />
      <wsdl:input name="SendEventRequest">
        <soap:header message="tns:SendEventRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SendEventRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SendEventRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SendEventResponse">
        <soap:header message="tns:SendEventResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SendEventResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SendEventResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SendEventResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetWorkflowGoal">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetWorkflowGoal" style="document" />
      <wsdl:input name="GetWorkflowGoalRequest">
        <soap:header message="tns:GetWorkflowGoalRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetWorkflowGoalRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetWorkflowGoalRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetWorkflowGoalResponse">
        <soap:header message="tns:GetWorkflowGoalResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetWorkflowGoalResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetWorkflowGoalResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetWorkflowGoalResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetWorkflowStep">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetWorkflowStep" style="document" />
      <wsdl:input name="GetWorkflowStepRequest">
        <soap:header message="tns:GetWorkflowStepRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetWorkflowStepRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetWorkflowStepRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetWorkflowStepResponse">
        <soap:header message="tns:GetWorkflowStepResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetWorkflowStepResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetWorkflowStepResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetWorkflowStepResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddAfterWorkflowStep">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/AddAfterWorkflowStep" style="document" />
      <wsdl:input name="AddAfterWorkflowStepRequest">
        <soap:header message="tns:AddAfterWorkflowStepRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddAfterWorkflowStepRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddAfterWorkflowStepRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddAfterWorkflowStepResponse">
        <soap:header message="tns:AddAfterWorkflowStepResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddAfterWorkflowStepResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddAfterWorkflowStepResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddAfterWorkflowStepResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultWorkflowStepFromType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowStepFromType" style="document" />
      <wsdl:input name="CreateDefaultWorkflowStepFromTypeRequest">
        <soap:header message="tns:CreateDefaultWorkflowStepFromTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowStepFromTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowStepFromTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultWorkflowStepFromTypeResponse">
        <soap:header message="tns:CreateDefaultWorkflowStepFromTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowStepFromTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowStepFromTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowStepFromTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultWorkflowStepOptionFromType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowStepOptionFromType" style="document" />
      <wsdl:input name="CreateDefaultWorkflowStepOptionFromTypeRequest">
        <soap:header message="tns:CreateDefaultWorkflowStepOptionFromTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowStepOptionFromTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowStepOptionFromTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultWorkflowStepOptionFromTypeResponse">
        <soap:header message="tns:CreateDefaultWorkflowStepOptionFromTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowStepOptionFromTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowStepOptionFromTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowStepOptionFromTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetWorkflowStepOption">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetWorkflowStepOption" style="document" />
      <wsdl:input name="GetWorkflowStepOptionRequest">
        <soap:header message="tns:GetWorkflowStepOptionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetWorkflowStepOptionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetWorkflowStepOptionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetWorkflowStepOptionResponse">
        <soap:header message="tns:GetWorkflowStepOptionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetWorkflowStepOptionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetWorkflowStepOptionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetWorkflowStepOptionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetWorkflowTrigger">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetWorkflowTrigger" style="document" />
      <wsdl:input name="GetWorkflowTriggerRequest">
        <soap:header message="tns:GetWorkflowTriggerRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetWorkflowTriggerRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetWorkflowTriggerRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetWorkflowTriggerResponse">
        <soap:header message="tns:GetWorkflowTriggerResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetWorkflowTriggerResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetWorkflowTriggerResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetWorkflowTriggerResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfWorkflowService">
    <wsdl:port name="BasicHttpBinding_Workflow" binding="tns:BasicHttpBinding_Workflow">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/Workflow.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

