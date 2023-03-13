---
generated: 1
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
              <xs:element minOccurs="0" name="VisibleForAll" type="xs:short" />
              <xs:element minOccurs="0" name="VisibleForAssociates" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="VisibleForGroups" nillable="true" type="q2:ArrayOfint" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="JumpToFinish" type="xs:short" />
              <xs:element minOccurs="0" name="StartOnlyOnce" type="xs:short" />
              <xs:element minOccurs="0" name="Folder" nillable="true" type="tns:HierarchyEntity" />
              <xs:element minOccurs="0" name="Associate" nillable="true" type="tns:Associate" />
              <xs:element minOccurs="0" name="ShipmentType" nillable="true" type="tns:MDOListItem" />
              <xs:element minOccurs="0" name="OverrideConsentSubscription" type="xs:short" />
              <xs:element minOccurs="0" name="Steps" nillable="true" type="tns:ArrayOfWorkflowStep" />
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
      <xs:complexType name="ArrayOfWorkflowStep">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="WorkflowStep" nillable="true" type="tns:WorkflowStep" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfWorkflowStep" nillable="true" type="tns:ArrayOfWorkflowStep" />
      <xs:complexType name="WorkflowStep">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="WorkflowStepId" type="xs:int" />
              <xs:element minOccurs="0" name="StepType" type="tns:WorkflowStepType" />
              <xs:element minOccurs="0" name="SubSteps" nillable="true" type="tns:ArrayOfWorkflowStep" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="WorkflowStep" nillable="true" type="tns:WorkflowStep" />
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
          <xs:enumeration value="UpdateContact" />
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
      <xs:element name="CreateDefaultWorkflowStep">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultWorkflowStepResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowStep" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveWorkflowStep">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WorkflowStep" nillable="true" type="tns:WorkflowStep" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveWorkflowStepResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowStep" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteWorkflowStep">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WorkflowStepId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteWorkflowStepResponse">
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
            <xs:element minOccurs="0" name="PersonIds" nillable="true" type="q3:ArrayOfint" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TryAddPersonsToEmailFlowResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q4:ArrayOfboolean" xmlns:q4="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
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
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowStep" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddAfterWorkflowStep">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="WorkflowStepId" type="xs:int" />
            <xs:element minOccurs="0" name="SubStep" nillable="true" type="tns:WorkflowStep" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddAfterWorkflowStepResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:WorkflowStep" />
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
  <wsdl:message name="CreateDefaultWorkflowStepRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultWorkflowStep" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowStepRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowStepResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultWorkflowStepResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultWorkflowStepResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveWorkflowStepRequest">
    <wsdl:part name="parameters" element="tns:SaveWorkflowStep" />
  </wsdl:message>
  <wsdl:message name="SaveWorkflowStepRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveWorkflowStepResponse">
    <wsdl:part name="parameters" element="tns:SaveWorkflowStepResponse" />
  </wsdl:message>
  <wsdl:message name="SaveWorkflowStepResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteWorkflowStepRequest">
    <wsdl:part name="parameters" element="tns:DeleteWorkflowStep" />
  </wsdl:message>
  <wsdl:message name="DeleteWorkflowStepRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteWorkflowStepResponse">
    <wsdl:part name="parameters" element="tns:DeleteWorkflowStepResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteWorkflowStepResponse_Headers">
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
    <wsdl:operation name="CreateDefaultWorkflowStep">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowStep" name="CreateDefaultWorkflowStepRequest" message="tns:CreateDefaultWorkflowStepRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowStepResponse" name="CreateDefaultWorkflowStepResponse" message="tns:CreateDefaultWorkflowStepResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveWorkflowStep">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/SaveWorkflowStep" name="SaveWorkflowStepRequest" message="tns:SaveWorkflowStepRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/SaveWorkflowStepResponse" name="SaveWorkflowStepResponse" message="tns:SaveWorkflowStepResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteWorkflowStep">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/DeleteWorkflowStep" name="DeleteWorkflowStepRequest" message="tns:DeleteWorkflowStepRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/DeleteWorkflowStepResponse" name="DeleteWorkflowStepResponse" message="tns:DeleteWorkflowStepResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEmailFlow">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetEmailFlow" name="GetEmailFlowRequest" message="tns:GetEmailFlowRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetEmailFlowResponse" name="GetEmailFlowResponse" message="tns:GetEmailFlowResponse" />
    </wsdl:operation>
    <wsdl:operation name="TryAddPersonsToEmailFlow">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/TryAddPersonsToEmailFlow" name="TryAddPersonsToEmailFlowRequest" message="tns:TryAddPersonsToEmailFlowRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/TryAddPersonsToEmailFlowResponse" name="TryAddPersonsToEmailFlowResponse" message="tns:TryAddPersonsToEmailFlowResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetWorkflowStep">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetWorkflowStep" name="GetWorkflowStepRequest" message="tns:GetWorkflowStepRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/GetWorkflowStepResponse" name="GetWorkflowStepResponse" message="tns:GetWorkflowStepResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddAfterWorkflowStep">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/AddAfterWorkflowStep" name="AddAfterWorkflowStepRequest" message="tns:AddAfterWorkflowStepRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/AddAfterWorkflowStepResponse" name="AddAfterWorkflowStepResponse" message="tns:AddAfterWorkflowStepResponse" />
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
    <wsdl:operation name="CreateDefaultWorkflowStep">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/CreateDefaultWorkflowStep" style="document" />
      <wsdl:input name="CreateDefaultWorkflowStepRequest">
        <soap:header message="tns:CreateDefaultWorkflowStepRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowStepRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowStepRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultWorkflowStepResponse">
        <soap:header message="tns:CreateDefaultWorkflowStepResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowStepResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowStepResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultWorkflowStepResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveWorkflowStep">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/SaveWorkflowStep" style="document" />
      <wsdl:input name="SaveWorkflowStepRequest">
        <soap:header message="tns:SaveWorkflowStepRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveWorkflowStepRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveWorkflowStepRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveWorkflowStepResponse">
        <soap:header message="tns:SaveWorkflowStepResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveWorkflowStepResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveWorkflowStepResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveWorkflowStepResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteWorkflowStep">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Workflow/DeleteWorkflowStep" style="document" />
      <wsdl:input name="DeleteWorkflowStepRequest">
        <soap:header message="tns:DeleteWorkflowStepRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteWorkflowStepRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteWorkflowStepRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteWorkflowStepResponse">
        <soap:header message="tns:DeleteWorkflowStepResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteWorkflowStepResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteWorkflowStepResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteWorkflowStepResponse_Headers" part="TimeZone" use="literal" />
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
  </wsdl:binding>
  <wsdl:service name="WcfWorkflowService">
    <wsdl:port name="BasicHttpBinding_Workflow" binding="tns:BasicHttpBinding_Workflow">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/Workflow.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

