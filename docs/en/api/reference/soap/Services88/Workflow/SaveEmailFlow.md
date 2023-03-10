---
title: Services88.WorkflowAgent.SaveEmailFlow SOAP
generated: 1
uid: Services88-Workflow-SaveEmailFlow
---

# Services88 Workflow SaveEmailFlow

SOAP request and response examples **Remote/Services88/Workflow.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IWorkflowAgent.SaveEmailFlow">SuperOffice.Services88.IWorkflowAgent.SaveEmailFlow</see> method.

## SaveEmailFlow





[WSDL file for Services88/Workflow](../Services88-Workflow.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveEmailFlow Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Workflow="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Workflow:ApplicationToken>1234567-1234-9876</Workflow:ApplicationToken>
  <Workflow:Credentials>
    <Workflow:Ticket>7T:1234abcxyzExample==</Workflow:Ticket>
  </Workflow:Credentials>
 <SOAP-ENV:Body>
   <Workflow:SaveEmailFlow>
    <Workflow:EmailFlow xsi:type="Workflow:EmailFlow">
     <Workflow:EmailFlowId xsi:type="xsd:int">0</Workflow:EmailFlowId>
     <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
     <Workflow:Description xsi:type="xsd:string"></Workflow:Description>
     <Workflow:Status xsi:type="Workflow:WorkflowDefinitionStatus">None</Workflow:Status>
     <Workflow:VisibleForAll xsi:type="xsd:short">0</Workflow:VisibleForAll>
     <Workflow:VisibleForAssociates xsi:type="NetServerServices882:ArrayOfint">
      <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
     </Workflow:VisibleForAssociates>
     <Workflow:VisibleForGroups xsi:type="NetServerServices882:ArrayOfint">
      <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
     </Workflow:VisibleForGroups>
     <Workflow:JumpToFinish xsi:type="xsd:short">0</Workflow:JumpToFinish>
     <Workflow:StartOnlyOnce xsi:type="xsd:short">0</Workflow:StartOnlyOnce>
     <Workflow:Folder xsi:type="Workflow:HierarchyEntity">
      <Workflow:HierarchyId xsi:type="xsd:int">0</Workflow:HierarchyId>
      <Workflow:Domain xsi:type="Workflow:Domain">Unknown</Workflow:Domain>
      <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
      <Workflow:Fullname xsi:type="xsd:string"></Workflow:Fullname>
      <Workflow:ParentId xsi:type="xsd:int">0</Workflow:ParentId>
      <Workflow:Children xsi:type="Workflow:ArrayOfHierarchyEntity">
       <Workflow:HierarchyEntity xsi:type="Workflow:HierarchyEntity">
        <Workflow:HierarchyId xsi:type="xsd:int">0</Workflow:HierarchyId>
        <Workflow:Domain xsi:type="Workflow:Domain">Unknown</Workflow:Domain>
        <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
        <Workflow:Fullname xsi:type="xsd:string"></Workflow:Fullname>
        <Workflow:ParentId xsi:type="xsd:int">0</Workflow:ParentId>
        <Workflow:Children xsi:type="Workflow:ArrayOfHierarchyEntity">
         <Workflow:HierarchyEntity xsi:type="Workflow:HierarchyEntity">
          <Workflow:HierarchyId xsi:nil="true"></Workflow:HierarchyId>
          <Workflow:Domain xsi:nil="true"></Workflow:Domain>
          <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
          <Workflow:Fullname xsi:type="xsd:string"></Workflow:Fullname>
          <Workflow:ParentId xsi:nil="true"></Workflow:ParentId>
          <Workflow:Children xsi:nil="true"></Workflow:Children>
          <Workflow:Registered xsi:nil="true"></Workflow:Registered>
          <Workflow:RegisteredAssociateId xsi:nil="true"></Workflow:RegisteredAssociateId>
          <Workflow:Updated xsi:nil="true"></Workflow:Updated>
          <Workflow:UpdatedAssociateId xsi:nil="true"></Workflow:UpdatedAssociateId>
         </Workflow:HierarchyEntity>
        </Workflow:Children>
        <Workflow:Registered xsi:type="xsd:dateTime">2023-03-01T11:15:06Z</Workflow:Registered>
        <Workflow:RegisteredAssociateId xsi:type="xsd:int">0</Workflow:RegisteredAssociateId>
        <Workflow:Updated xsi:type="xsd:dateTime">2023-03-01T11:15:06Z</Workflow:Updated>
        <Workflow:UpdatedAssociateId xsi:type="xsd:int">0</Workflow:UpdatedAssociateId>
       </Workflow:HierarchyEntity>
      </Workflow:Children>
      <Workflow:Registered xsi:type="xsd:dateTime">2023-03-01T11:15:06Z</Workflow:Registered>
      <Workflow:RegisteredAssociateId xsi:type="xsd:int">0</Workflow:RegisteredAssociateId>
      <Workflow:Updated xsi:type="xsd:dateTime">2023-03-01T11:15:06Z</Workflow:Updated>
      <Workflow:UpdatedAssociateId xsi:type="xsd:int">0</Workflow:UpdatedAssociateId>
     </Workflow:Folder>
     <Workflow:Associate xsi:type="Workflow:Associate">
      <Workflow:AssociateId xsi:type="xsd:int">0</Workflow:AssociateId>
      <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
      <Workflow:PersonId xsi:type="xsd:int">0</Workflow:PersonId>
      <Workflow:Rank xsi:type="xsd:short">0</Workflow:Rank>
      <Workflow:Tooltip xsi:type="xsd:string"></Workflow:Tooltip>
      <Workflow:Type xsi:type="Workflow:UserType">Unknown</Workflow:Type>
      <Workflow:GroupIdx xsi:type="xsd:int">0</Workflow:GroupIdx>
      <Workflow:FullName xsi:type="xsd:string"></Workflow:FullName>
      <Workflow:FormalName xsi:type="xsd:string"></Workflow:FormalName>
      <Workflow:Deleted xsi:type="xsd:boolean">false</Workflow:Deleted>
      <Workflow:EjUserId xsi:type="xsd:int">0</Workflow:EjUserId>
      <Workflow:UserName xsi:type="xsd:string"></Workflow:UserName>
     </Workflow:Associate>
     <Workflow:ShipmentType xsi:type="Workflow:MDOListItem">
      <Workflow:Id xsi:type="xsd:int">0</Workflow:Id>
      <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
      <Workflow:ToolTip xsi:type="xsd:string"></Workflow:ToolTip>
      <Workflow:Deleted xsi:type="xsd:boolean">false</Workflow:Deleted>
      <Workflow:Rank xsi:type="xsd:int">0</Workflow:Rank>
      <Workflow:Type xsi:type="xsd:string"></Workflow:Type>
      <Workflow:ChildItems xsi:type="Workflow:ArrayOfMDOListItem">
       <Workflow:MDOListItem xsi:type="Workflow:MDOListItem">
        <Workflow:Id xsi:type="xsd:int">0</Workflow:Id>
        <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
        <Workflow:ToolTip xsi:type="xsd:string"></Workflow:ToolTip>
        <Workflow:Deleted xsi:type="xsd:boolean">false</Workflow:Deleted>
        <Workflow:Rank xsi:type="xsd:int">0</Workflow:Rank>
        <Workflow:Type xsi:type="xsd:string"></Workflow:Type>
        <Workflow:ChildItems xsi:type="Workflow:ArrayOfMDOListItem">
         <Workflow:MDOListItem xsi:type="Workflow:MDOListItem">
          <Workflow:Id xsi:nil="true"></Workflow:Id>
          <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
          <Workflow:ToolTip xsi:type="xsd:string"></Workflow:ToolTip>
          <Workflow:Deleted xsi:nil="true"></Workflow:Deleted>
          <Workflow:Rank xsi:nil="true"></Workflow:Rank>
          <Workflow:Type xsi:type="xsd:string"></Workflow:Type>
          <Workflow:ChildItems xsi:nil="true"></Workflow:ChildItems>
          <Workflow:IconHint xsi:type="xsd:string"></Workflow:IconHint>
          <Workflow:ColorBlock xsi:nil="true"></Workflow:ColorBlock>
          <Workflow:ExtraInfo xsi:type="xsd:string"></Workflow:ExtraInfo>
          <Workflow:StyleHint xsi:type="xsd:string"></Workflow:StyleHint>
          <Workflow:FullName xsi:type="xsd:string"></Workflow:FullName>
         </Workflow:MDOListItem>
        </Workflow:ChildItems>
        <Workflow:IconHint xsi:type="xsd:string"></Workflow:IconHint>
        <Workflow:ColorBlock xsi:type="xsd:int">0</Workflow:ColorBlock>
        <Workflow:ExtraInfo xsi:type="xsd:string"></Workflow:ExtraInfo>
        <Workflow:StyleHint xsi:type="xsd:string"></Workflow:StyleHint>
        <Workflow:FullName xsi:type="xsd:string"></Workflow:FullName>
       </Workflow:MDOListItem>
      </Workflow:ChildItems>
      <Workflow:IconHint xsi:type="xsd:string"></Workflow:IconHint>
      <Workflow:ColorBlock xsi:type="xsd:int">0</Workflow:ColorBlock>
      <Workflow:ExtraInfo xsi:type="xsd:string"></Workflow:ExtraInfo>
      <Workflow:StyleHint xsi:type="xsd:string"></Workflow:StyleHint>
      <Workflow:FullName xsi:type="xsd:string"></Workflow:FullName>
     </Workflow:ShipmentType>
     <Workflow:OverrideConsentSubscription xsi:type="xsd:short">0</Workflow:OverrideConsentSubscription>
     <Workflow:Steps xsi:type="Workflow:ArrayOfWorkflowStep">
      <Workflow:WorkflowStep xsi:type="Workflow:WorkflowStep">
       <Workflow:WorkflowStepId xsi:type="xsd:int">0</Workflow:WorkflowStepId>
       <Workflow:StepType xsi:type="Workflow:WorkflowStepType">None</Workflow:StepType>
       <Workflow:SubSteps xsi:type="Workflow:ArrayOfWorkflowStep">
        <Workflow:WorkflowStep xsi:type="Workflow:WorkflowStep">
         <Workflow:WorkflowStepId xsi:type="xsd:int">0</Workflow:WorkflowStepId>
         <Workflow:StepType xsi:type="Workflow:WorkflowStepType">None</Workflow:StepType>
         <Workflow:SubSteps xsi:type="Workflow:ArrayOfWorkflowStep">
          <Workflow:WorkflowStep xsi:nil="true"></Workflow:WorkflowStep>
         </Workflow:SubSteps>
        </Workflow:WorkflowStep>
       </Workflow:SubSteps>
      </Workflow:WorkflowStep>
     </Workflow:Steps>
    </Workflow:EmailFlow>
   </Workflow:SaveEmailFlow>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveEmailFlow Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Workflow="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Workflow:SaveEmailFlowResponse>
   <Workflow:Response xsi:type="Workflow:EmailFlow">
    <Workflow:EmailFlowId xsi:type="xsd:int">0</Workflow:EmailFlowId>
    <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
    <Workflow:Description xsi:type="xsd:string"></Workflow:Description>
    <Workflow:Status xsi:type="Workflow:WorkflowDefinitionStatus">None</Workflow:Status>
    <Workflow:VisibleForAll xsi:type="xsd:short">0</Workflow:VisibleForAll>
    <Workflow:VisibleForAssociates xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Workflow:VisibleForAssociates>
    <Workflow:VisibleForGroups xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Workflow:VisibleForGroups>
    <Workflow:JumpToFinish xsi:type="xsd:short">0</Workflow:JumpToFinish>
    <Workflow:StartOnlyOnce xsi:type="xsd:short">0</Workflow:StartOnlyOnce>
    <Workflow:Folder xsi:type="Workflow:HierarchyEntity">
     <Workflow:HierarchyId xsi:type="xsd:int">0</Workflow:HierarchyId>
     <Workflow:Domain xsi:type="Workflow:Domain">Unknown</Workflow:Domain>
     <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
     <Workflow:Fullname xsi:type="xsd:string"></Workflow:Fullname>
     <Workflow:ParentId xsi:type="xsd:int">0</Workflow:ParentId>
     <Workflow:Children xsi:type="Workflow:ArrayOfHierarchyEntity">
      <Workflow:HierarchyEntity xsi:type="Workflow:HierarchyEntity">
       <Workflow:HierarchyId xsi:type="xsd:int">0</Workflow:HierarchyId>
       <Workflow:Domain xsi:type="Workflow:Domain">Unknown</Workflow:Domain>
       <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
       <Workflow:Fullname xsi:type="xsd:string"></Workflow:Fullname>
       <Workflow:ParentId xsi:type="xsd:int">0</Workflow:ParentId>
       <Workflow:Children xsi:type="Workflow:ArrayOfHierarchyEntity">
        <Workflow:HierarchyEntity xsi:type="Workflow:HierarchyEntity">
         <Workflow:HierarchyId xsi:type="xsd:int">0</Workflow:HierarchyId>
         <Workflow:Domain xsi:type="Workflow:Domain">Unknown</Workflow:Domain>
         <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
         <Workflow:Fullname xsi:type="xsd:string"></Workflow:Fullname>
         <Workflow:ParentId xsi:type="xsd:int">0</Workflow:ParentId>
         <Workflow:Children xsi:type="Workflow:ArrayOfHierarchyEntity">
          <Workflow:HierarchyEntity xsi:nil="true"></Workflow:HierarchyEntity>
         </Workflow:Children>
         <Workflow:Registered xsi:type="xsd:dateTime">2023-03-01T11:15:06Z</Workflow:Registered>
         <Workflow:RegisteredAssociateId xsi:type="xsd:int">0</Workflow:RegisteredAssociateId>
         <Workflow:Updated xsi:type="xsd:dateTime">2023-03-01T11:15:06Z</Workflow:Updated>
         <Workflow:UpdatedAssociateId xsi:type="xsd:int">0</Workflow:UpdatedAssociateId>
        </Workflow:HierarchyEntity>
       </Workflow:Children>
       <Workflow:Registered xsi:type="xsd:dateTime">2023-03-01T11:15:06Z</Workflow:Registered>
       <Workflow:RegisteredAssociateId xsi:type="xsd:int">0</Workflow:RegisteredAssociateId>
       <Workflow:Updated xsi:type="xsd:dateTime">2023-03-01T11:15:06Z</Workflow:Updated>
       <Workflow:UpdatedAssociateId xsi:type="xsd:int">0</Workflow:UpdatedAssociateId>
      </Workflow:HierarchyEntity>
     </Workflow:Children>
     <Workflow:Registered xsi:type="xsd:dateTime">2023-03-01T11:15:06Z</Workflow:Registered>
     <Workflow:RegisteredAssociateId xsi:type="xsd:int">0</Workflow:RegisteredAssociateId>
     <Workflow:Updated xsi:type="xsd:dateTime">2023-03-01T11:15:06Z</Workflow:Updated>
     <Workflow:UpdatedAssociateId xsi:type="xsd:int">0</Workflow:UpdatedAssociateId>
    </Workflow:Folder>
    <Workflow:Associate xsi:type="Workflow:Associate">
     <Workflow:AssociateId xsi:type="xsd:int">0</Workflow:AssociateId>
     <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
     <Workflow:PersonId xsi:type="xsd:int">0</Workflow:PersonId>
     <Workflow:Rank xsi:type="xsd:short">0</Workflow:Rank>
     <Workflow:Tooltip xsi:type="xsd:string"></Workflow:Tooltip>
     <Workflow:Type xsi:type="Workflow:UserType">Unknown</Workflow:Type>
     <Workflow:GroupIdx xsi:type="xsd:int">0</Workflow:GroupIdx>
     <Workflow:FullName xsi:type="xsd:string"></Workflow:FullName>
     <Workflow:FormalName xsi:type="xsd:string"></Workflow:FormalName>
     <Workflow:Deleted xsi:type="xsd:boolean">false</Workflow:Deleted>
     <Workflow:EjUserId xsi:type="xsd:int">0</Workflow:EjUserId>
     <Workflow:UserName xsi:type="xsd:string"></Workflow:UserName>
    </Workflow:Associate>
    <Workflow:ShipmentType xsi:type="Workflow:MDOListItem">
     <Workflow:Id xsi:type="xsd:int">0</Workflow:Id>
     <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
     <Workflow:ToolTip xsi:type="xsd:string"></Workflow:ToolTip>
     <Workflow:Deleted xsi:type="xsd:boolean">false</Workflow:Deleted>
     <Workflow:Rank xsi:type="xsd:int">0</Workflow:Rank>
     <Workflow:Type xsi:type="xsd:string"></Workflow:Type>
     <Workflow:ChildItems xsi:type="Workflow:ArrayOfMDOListItem">
      <Workflow:MDOListItem xsi:type="Workflow:MDOListItem">
       <Workflow:Id xsi:type="xsd:int">0</Workflow:Id>
       <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
       <Workflow:ToolTip xsi:type="xsd:string"></Workflow:ToolTip>
       <Workflow:Deleted xsi:type="xsd:boolean">false</Workflow:Deleted>
       <Workflow:Rank xsi:type="xsd:int">0</Workflow:Rank>
       <Workflow:Type xsi:type="xsd:string"></Workflow:Type>
       <Workflow:ChildItems xsi:type="Workflow:ArrayOfMDOListItem">
        <Workflow:MDOListItem xsi:type="Workflow:MDOListItem">
         <Workflow:Id xsi:type="xsd:int">0</Workflow:Id>
         <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
         <Workflow:ToolTip xsi:type="xsd:string"></Workflow:ToolTip>
         <Workflow:Deleted xsi:type="xsd:boolean">false</Workflow:Deleted>
         <Workflow:Rank xsi:type="xsd:int">0</Workflow:Rank>
         <Workflow:Type xsi:type="xsd:string"></Workflow:Type>
         <Workflow:ChildItems xsi:type="Workflow:ArrayOfMDOListItem">
          <Workflow:MDOListItem xsi:nil="true"></Workflow:MDOListItem>
         </Workflow:ChildItems>
         <Workflow:IconHint xsi:type="xsd:string"></Workflow:IconHint>
         <Workflow:ColorBlock xsi:type="xsd:int">0</Workflow:ColorBlock>
         <Workflow:ExtraInfo xsi:type="xsd:string"></Workflow:ExtraInfo>
         <Workflow:StyleHint xsi:type="xsd:string"></Workflow:StyleHint>
         <Workflow:FullName xsi:type="xsd:string"></Workflow:FullName>
        </Workflow:MDOListItem>
       </Workflow:ChildItems>
       <Workflow:IconHint xsi:type="xsd:string"></Workflow:IconHint>
       <Workflow:ColorBlock xsi:type="xsd:int">0</Workflow:ColorBlock>
       <Workflow:ExtraInfo xsi:type="xsd:string"></Workflow:ExtraInfo>
       <Workflow:StyleHint xsi:type="xsd:string"></Workflow:StyleHint>
       <Workflow:FullName xsi:type="xsd:string"></Workflow:FullName>
      </Workflow:MDOListItem>
     </Workflow:ChildItems>
     <Workflow:IconHint xsi:type="xsd:string"></Workflow:IconHint>
     <Workflow:ColorBlock xsi:type="xsd:int">0</Workflow:ColorBlock>
     <Workflow:ExtraInfo xsi:type="xsd:string"></Workflow:ExtraInfo>
     <Workflow:StyleHint xsi:type="xsd:string"></Workflow:StyleHint>
     <Workflow:FullName xsi:type="xsd:string"></Workflow:FullName>
    </Workflow:ShipmentType>
    <Workflow:OverrideConsentSubscription xsi:type="xsd:short">0</Workflow:OverrideConsentSubscription>
    <Workflow:Steps xsi:type="Workflow:ArrayOfWorkflowStep">
     <Workflow:WorkflowStep xsi:type="Workflow:WorkflowStep">
      <Workflow:WorkflowStepId xsi:type="xsd:int">0</Workflow:WorkflowStepId>
      <Workflow:StepType xsi:type="Workflow:WorkflowStepType">None</Workflow:StepType>
      <Workflow:SubSteps xsi:type="Workflow:ArrayOfWorkflowStep">
       <Workflow:WorkflowStep xsi:type="Workflow:WorkflowStep">
        <Workflow:WorkflowStepId xsi:type="xsd:int">0</Workflow:WorkflowStepId>
        <Workflow:StepType xsi:type="Workflow:WorkflowStepType">None</Workflow:StepType>
        <Workflow:SubSteps xsi:type="Workflow:ArrayOfWorkflowStep">
         <Workflow:WorkflowStep xsi:type="Workflow:WorkflowStep">
          <Workflow:WorkflowStepId xsi:nil="true"></Workflow:WorkflowStepId>
          <Workflow:StepType xsi:nil="true"></Workflow:StepType>
          <Workflow:SubSteps xsi:nil="true"></Workflow:SubSteps>
         </Workflow:WorkflowStep>
        </Workflow:SubSteps>
       </Workflow:WorkflowStep>
      </Workflow:SubSteps>
     </Workflow:WorkflowStep>
    </Workflow:Steps>
   </Workflow:Response>
  </Workflow:SaveEmailFlowResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

