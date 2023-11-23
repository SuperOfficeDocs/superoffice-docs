---
title: Services88.WorkflowAgent.SaveEmailFlow SOAP
generated: true
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
     <Workflow:JumpToFinish xsi:type="xsd:boolean">false</Workflow:JumpToFinish>
     <Workflow:StartOnlyOnce xsi:type="xsd:boolean">false</Workflow:StartOnlyOnce>
     <Workflow:OverrideConsentSubscription xsi:type="xsd:boolean">false</Workflow:OverrideConsentSubscription>
     <Workflow:FromType xsi:type="Workflow:EmailFromType">FromOnlySpecified</Workflow:FromType>
     <Workflow:FromName xsi:type="xsd:string"></Workflow:FromName>
     <Workflow:FromAddr xsi:type="xsd:string"></Workflow:FromAddr>
     <Workflow:ReplyToType xsi:type="Workflow:EmailReplyToType">ReplyToOnlySpecified</Workflow:ReplyToType>
     <Workflow:ReplyToAddr xsi:type="xsd:string"></Workflow:ReplyToAddr>
     <Workflow:ReplyToName xsi:type="xsd:string"></Workflow:ReplyToName>
     <Workflow:SmsSender xsi:type="xsd:string"></Workflow:SmsSender>
     <Workflow:UseGoogleAnalytics xsi:type="xsd:boolean">false</Workflow:UseGoogleAnalytics>
     <Workflow:GaSource xsi:type="xsd:string"></Workflow:GaSource>
     <Workflow:GaCampaign xsi:type="xsd:string"></Workflow:GaCampaign>
     <Workflow:UseTimeframe xsi:type="xsd:boolean">false</Workflow:UseTimeframe>
     <Workflow:SelectedDays xsi:type="Workflow:Weekday">Monday</Workflow:SelectedDays>
     <Workflow:TimeframeStart xsi:type="xsd:string"></Workflow:TimeframeStart>
     <Workflow:TimeframeEnd xsi:type="xsd:string"></Workflow:TimeframeEnd>
     <Workflow:UseWorkflowStart xsi:type="xsd:boolean">false</Workflow:UseWorkflowStart>
     <Workflow:WorkflowStart xsi:type="xsd:string"></Workflow:WorkflowStart>
     <Workflow:UseEnrollmentEnd xsi:type="xsd:boolean">false</Workflow:UseEnrollmentEnd>
     <Workflow:EnrollmentEnd xsi:type="xsd:string"></Workflow:EnrollmentEnd>
     <Workflow:RemoveFromFlows xsi:type="NetServerServices882:ArrayOfint">
      <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
     </Workflow:RemoveFromFlows>
     <Workflow:TzLocation xsi:type="Workflow:TimeZoneData">
      <Workflow:TZLocationID xsi:type="xsd:int">0</Workflow:TZLocationID>
      <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
      <Workflow:TZLocationCode xsi:type="xsd:string"></Workflow:TZLocationCode>
      <Workflow:TZLocationCities xsi:type="xsd:string"></Workflow:TZLocationCities>
      <Workflow:IsoNumber xsi:type="xsd:int">0</Workflow:IsoNumber>
      <Workflow:TimeZoneSTDRules xsi:type="Workflow:TimeZoneRuleDictionary">
       <Workflow:TimeZoneRuleKeyValuePair>
        <Workflow:Key xsi:type="xsd:dateTime"></Workflow:Key>
        <Workflow:Value xsi:type="Workflow:TimeZoneRule">
         <Workflow:TZOffset xsi:type="xsd:int">0</Workflow:TZOffset>
         <Workflow:StartRulePattern xsi:type="xsd:string"></Workflow:StartRulePattern>
         <Workflow:EndRulePattern xsi:type="xsd:string"></Workflow:EndRulePattern>
         <Workflow:StartDay xsi:type="xsd:int">0</Workflow:StartDay>
         <Workflow:StartMonth xsi:type="xsd:int">0</Workflow:StartMonth>
         <Workflow:EndDay xsi:type="xsd:int">0</Workflow:EndDay>
         <Workflow:EndMonth xsi:type="xsd:int">0</Workflow:EndMonth>
        </Workflow:Value>
       </Workflow:TimeZoneRuleKeyValuePair>
      </Workflow:TimeZoneSTDRules>
      <Workflow:TimeZoneDSTRules xsi:type="Workflow:TimeZoneRuleDictionary">
       <Workflow:TimeZoneRuleKeyValuePair>
        <Workflow:Key xsi:type="xsd:dateTime"></Workflow:Key>
        <Workflow:Value xsi:type="Workflow:TimeZoneRule">
         <Workflow:TZOffset xsi:type="xsd:int">0</Workflow:TZOffset>
         <Workflow:StartRulePattern xsi:type="xsd:string"></Workflow:StartRulePattern>
         <Workflow:EndRulePattern xsi:type="xsd:string"></Workflow:EndRulePattern>
         <Workflow:StartDay xsi:type="xsd:int">0</Workflow:StartDay>
         <Workflow:StartMonth xsi:type="xsd:int">0</Workflow:StartMonth>
         <Workflow:EndDay xsi:type="xsd:int">0</Workflow:EndDay>
         <Workflow:EndMonth xsi:type="xsd:int">0</Workflow:EndMonth>
        </Workflow:Value>
       </Workflow:TimeZoneRuleKeyValuePair>
      </Workflow:TimeZoneDSTRules>
     </Workflow:TzLocation>
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
        <Workflow:Registered xsi:type="xsd:dateTime">2023-11-10T12:38:03Z</Workflow:Registered>
        <Workflow:RegisteredAssociateId xsi:type="xsd:int">0</Workflow:RegisteredAssociateId>
        <Workflow:Updated xsi:type="xsd:dateTime">2023-11-10T12:38:03Z</Workflow:Updated>
        <Workflow:UpdatedAssociateId xsi:type="xsd:int">0</Workflow:UpdatedAssociateId>
       </Workflow:HierarchyEntity>
      </Workflow:Children>
      <Workflow:Registered xsi:type="xsd:dateTime">2023-11-10T12:38:03Z</Workflow:Registered>
      <Workflow:RegisteredAssociateId xsi:type="xsd:int">0</Workflow:RegisteredAssociateId>
      <Workflow:Updated xsi:type="xsd:dateTime">2023-11-10T12:38:03Z</Workflow:Updated>
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
     <Workflow:Steps xsi:type="Workflow:ArrayOfWorkflowStepBase">
      <Workflow:WorkflowStepBase xsi:type="Workflow:WorkflowStepBase">
       <Workflow:WorkflowStepId xsi:type="xsd:int">0</Workflow:WorkflowStepId>
       <Workflow:WorkflowId xsi:type="xsd:int">0</Workflow:WorkflowId>
       <Workflow:StepType xsi:type="Workflow:WorkflowStepType">None</Workflow:StepType>
       <Workflow:Rank xsi:type="xsd:int">0</Workflow:Rank>
      </Workflow:WorkflowStepBase>
     </Workflow:Steps>
     <Workflow:Triggers xsi:type="Workflow:ArrayOfWorkflowTrigger">
      <Workflow:WorkflowTrigger xsi:type="Workflow:WorkflowTrigger">
       <Workflow:WorkflowTriggerId xsi:type="xsd:int">0</Workflow:WorkflowTriggerId>
       <Workflow:WorkflowId xsi:type="xsd:int">0</Workflow:WorkflowId>
       <Workflow:TriggerType xsi:type="Workflow:WorkflowTriggerType">None</Workflow:TriggerType>
       <Workflow:RestrictionGroups xsi:type="Workflow:ArrayOfArchiveRestrictionGroup">
        <Workflow:ArchiveRestrictionGroup xsi:type="Workflow:ArchiveRestrictionGroup">
         <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
         <Workflow:Description xsi:type="xsd:string"></Workflow:Description>
         <Workflow:Rank xsi:type="xsd:short">0</Workflow:Rank>
         <Workflow:Restrictions xsi:type="Workflow:ArrayOfArchiveRestrictionInfo">
          <Workflow:ArchiveRestrictionInfo xsi:nil="true"></Workflow:ArchiveRestrictionInfo>
         </Workflow:Restrictions>
        </Workflow:ArchiveRestrictionGroup>
       </Workflow:RestrictionGroups>
      </Workflow:WorkflowTrigger>
     </Workflow:Triggers>
     <Workflow:Goals xsi:type="Workflow:ArrayOfWorkflowGoal">
      <Workflow:WorkflowGoal xsi:type="Workflow:WorkflowGoal">
       <Workflow:WorkflowGoalId xsi:type="xsd:int">0</Workflow:WorkflowGoalId>
       <Workflow:WorkflowId xsi:type="xsd:int">0</Workflow:WorkflowId>
       <Workflow:GoalType xsi:type="Workflow:WorkflowGoalType">None</Workflow:GoalType>
       <Workflow:RestrictionGroups xsi:type="Workflow:ArrayOfArchiveRestrictionGroup">
        <Workflow:ArchiveRestrictionGroup xsi:type="Workflow:ArchiveRestrictionGroup">
         <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
         <Workflow:Description xsi:type="xsd:string"></Workflow:Description>
         <Workflow:Rank xsi:type="xsd:short">0</Workflow:Rank>
         <Workflow:Restrictions xsi:type="Workflow:ArrayOfArchiveRestrictionInfo">
          <Workflow:ArchiveRestrictionInfo xsi:nil="true"></Workflow:ArchiveRestrictionInfo>
         </Workflow:Restrictions>
        </Workflow:ArchiveRestrictionGroup>
       </Workflow:RestrictionGroups>
      </Workflow:WorkflowGoal>
     </Workflow:Goals>
     <Workflow:Filter xsi:type="Workflow:WorkflowFilter">
      <Workflow:RestrictionGroups xsi:type="Workflow:ArrayOfArchiveRestrictionGroup">
       <Workflow:ArchiveRestrictionGroup xsi:type="Workflow:ArchiveRestrictionGroup">
        <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
        <Workflow:Description xsi:type="xsd:string"></Workflow:Description>
        <Workflow:Rank xsi:type="xsd:short">0</Workflow:Rank>
        <Workflow:Restrictions xsi:type="Workflow:ArrayOfArchiveRestrictionInfo">
         <Workflow:ArchiveRestrictionInfo xsi:type="Workflow:ArchiveRestrictionInfo">
          <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
          <Workflow:Operator xsi:type="xsd:string"></Workflow:Operator>
          <Workflow:Values xsi:nil="true"></Workflow:Values>
          <Workflow:DisplayValues xsi:nil="true"></Workflow:DisplayValues>
          <Workflow:ColumnInfo xsi:nil="true"></Workflow:ColumnInfo>
          <Workflow:IsActive xsi:nil="true"></Workflow:IsActive>
          <Workflow:SubRestrictions xsi:nil="true"></Workflow:SubRestrictions>
          <Workflow:InterParenthesis xsi:nil="true"></Workflow:InterParenthesis>
          <Workflow:InterOperator xsi:nil="true"></Workflow:InterOperator>
          <Workflow:UniqueHash xsi:nil="true"></Workflow:UniqueHash>
         </Workflow:ArchiveRestrictionInfo>
        </Workflow:Restrictions>
       </Workflow:ArchiveRestrictionGroup>
      </Workflow:RestrictionGroups>
     </Workflow:Filter>
     <Workflow:BlockLists xsi:type="NetServerServices882:ArrayOfint">
      <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
     </Workflow:BlockLists>
     <Workflow:CreatedBy xsi:type="Workflow:Associate">
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
     </Workflow:CreatedBy>
     <Workflow:UpdatedBy xsi:type="Workflow:Associate">
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
     </Workflow:UpdatedBy>
     <Workflow:CreatedDate xsi:type="xsd:dateTime">2023-11-10T12:38:03Z</Workflow:CreatedDate>
     <Workflow:UpdatedDate xsi:type="xsd:dateTime">2023-11-10T12:38:03Z</Workflow:UpdatedDate>
     <Workflow:VisibleFor xsi:type="Workflow:ArrayOfVisibleFor">
      <Workflow:VisibleFor xsi:type="Workflow:VisibleFor">
       <Workflow:VisibleId xsi:type="xsd:int">0</Workflow:VisibleId>
       <Workflow:Visibility xsi:type="Workflow:Visibility">All</Workflow:Visibility>
       <Workflow:DisplayValue xsi:type="xsd:string"></Workflow:DisplayValue>
      </Workflow:VisibleFor>
     </Workflow:VisibleFor>
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
    <Workflow:JumpToFinish xsi:type="xsd:boolean">false</Workflow:JumpToFinish>
    <Workflow:StartOnlyOnce xsi:type="xsd:boolean">false</Workflow:StartOnlyOnce>
    <Workflow:OverrideConsentSubscription xsi:type="xsd:boolean">false</Workflow:OverrideConsentSubscription>
    <Workflow:FromType xsi:type="Workflow:EmailFromType">FromOnlySpecified</Workflow:FromType>
    <Workflow:FromName xsi:type="xsd:string"></Workflow:FromName>
    <Workflow:FromAddr xsi:type="xsd:string"></Workflow:FromAddr>
    <Workflow:ReplyToType xsi:type="Workflow:EmailReplyToType">ReplyToOnlySpecified</Workflow:ReplyToType>
    <Workflow:ReplyToAddr xsi:type="xsd:string"></Workflow:ReplyToAddr>
    <Workflow:ReplyToName xsi:type="xsd:string"></Workflow:ReplyToName>
    <Workflow:SmsSender xsi:type="xsd:string"></Workflow:SmsSender>
    <Workflow:UseGoogleAnalytics xsi:type="xsd:boolean">false</Workflow:UseGoogleAnalytics>
    <Workflow:GaSource xsi:type="xsd:string"></Workflow:GaSource>
    <Workflow:GaCampaign xsi:type="xsd:string"></Workflow:GaCampaign>
    <Workflow:UseTimeframe xsi:type="xsd:boolean">false</Workflow:UseTimeframe>
    <Workflow:SelectedDays xsi:type="Workflow:Weekday">Monday</Workflow:SelectedDays>
    <Workflow:TimeframeStart xsi:type="xsd:string"></Workflow:TimeframeStart>
    <Workflow:TimeframeEnd xsi:type="xsd:string"></Workflow:TimeframeEnd>
    <Workflow:UseWorkflowStart xsi:type="xsd:boolean">false</Workflow:UseWorkflowStart>
    <Workflow:WorkflowStart xsi:type="xsd:string"></Workflow:WorkflowStart>
    <Workflow:UseEnrollmentEnd xsi:type="xsd:boolean">false</Workflow:UseEnrollmentEnd>
    <Workflow:EnrollmentEnd xsi:type="xsd:string"></Workflow:EnrollmentEnd>
    <Workflow:RemoveFromFlows xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Workflow:RemoveFromFlows>
    <Workflow:TzLocation xsi:type="Workflow:TimeZoneData">
     <Workflow:TZLocationID xsi:type="xsd:int">0</Workflow:TZLocationID>
     <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
     <Workflow:TZLocationCode xsi:type="xsd:string"></Workflow:TZLocationCode>
     <Workflow:TZLocationCities xsi:type="xsd:string"></Workflow:TZLocationCities>
     <Workflow:IsoNumber xsi:type="xsd:int">0</Workflow:IsoNumber>
     <Workflow:TimeZoneSTDRules xsi:type="Workflow:TimeZoneRuleDictionary">
      <Workflow:TimeZoneRuleKeyValuePair>
       <Workflow:Key xsi:type="xsd:dateTime"></Workflow:Key>
       <Workflow:Value xsi:type="Workflow:TimeZoneRule">
        <Workflow:TZOffset xsi:type="xsd:int">0</Workflow:TZOffset>
        <Workflow:StartRulePattern xsi:type="xsd:string"></Workflow:StartRulePattern>
        <Workflow:EndRulePattern xsi:type="xsd:string"></Workflow:EndRulePattern>
        <Workflow:StartDay xsi:type="xsd:int">0</Workflow:StartDay>
        <Workflow:StartMonth xsi:type="xsd:int">0</Workflow:StartMonth>
        <Workflow:EndDay xsi:type="xsd:int">0</Workflow:EndDay>
        <Workflow:EndMonth xsi:type="xsd:int">0</Workflow:EndMonth>
       </Workflow:Value>
      </Workflow:TimeZoneRuleKeyValuePair>
     </Workflow:TimeZoneSTDRules>
     <Workflow:TimeZoneDSTRules xsi:type="Workflow:TimeZoneRuleDictionary">
      <Workflow:TimeZoneRuleKeyValuePair>
       <Workflow:Key xsi:type="xsd:dateTime"></Workflow:Key>
       <Workflow:Value xsi:type="Workflow:TimeZoneRule">
        <Workflow:TZOffset xsi:type="xsd:int">0</Workflow:TZOffset>
        <Workflow:StartRulePattern xsi:type="xsd:string"></Workflow:StartRulePattern>
        <Workflow:EndRulePattern xsi:type="xsd:string"></Workflow:EndRulePattern>
        <Workflow:StartDay xsi:type="xsd:int">0</Workflow:StartDay>
        <Workflow:StartMonth xsi:type="xsd:int">0</Workflow:StartMonth>
        <Workflow:EndDay xsi:type="xsd:int">0</Workflow:EndDay>
        <Workflow:EndMonth xsi:type="xsd:int">0</Workflow:EndMonth>
       </Workflow:Value>
      </Workflow:TimeZoneRuleKeyValuePair>
     </Workflow:TimeZoneDSTRules>
    </Workflow:TzLocation>
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
         <Workflow:Registered xsi:type="xsd:dateTime">2023-11-10T12:38:03Z</Workflow:Registered>
         <Workflow:RegisteredAssociateId xsi:type="xsd:int">0</Workflow:RegisteredAssociateId>
         <Workflow:Updated xsi:type="xsd:dateTime">2023-11-10T12:38:03Z</Workflow:Updated>
         <Workflow:UpdatedAssociateId xsi:type="xsd:int">0</Workflow:UpdatedAssociateId>
        </Workflow:HierarchyEntity>
       </Workflow:Children>
       <Workflow:Registered xsi:type="xsd:dateTime">2023-11-10T12:38:03Z</Workflow:Registered>
       <Workflow:RegisteredAssociateId xsi:type="xsd:int">0</Workflow:RegisteredAssociateId>
       <Workflow:Updated xsi:type="xsd:dateTime">2023-11-10T12:38:03Z</Workflow:Updated>
       <Workflow:UpdatedAssociateId xsi:type="xsd:int">0</Workflow:UpdatedAssociateId>
      </Workflow:HierarchyEntity>
     </Workflow:Children>
     <Workflow:Registered xsi:type="xsd:dateTime">2023-11-10T12:38:03Z</Workflow:Registered>
     <Workflow:RegisteredAssociateId xsi:type="xsd:int">0</Workflow:RegisteredAssociateId>
     <Workflow:Updated xsi:type="xsd:dateTime">2023-11-10T12:38:03Z</Workflow:Updated>
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
    <Workflow:Steps xsi:type="Workflow:ArrayOfWorkflowStepBase">
     <Workflow:WorkflowStepBase xsi:type="Workflow:WorkflowStepBase">
      <Workflow:WorkflowStepId xsi:type="xsd:int">0</Workflow:WorkflowStepId>
      <Workflow:WorkflowId xsi:type="xsd:int">0</Workflow:WorkflowId>
      <Workflow:StepType xsi:type="Workflow:WorkflowStepType">None</Workflow:StepType>
      <Workflow:Rank xsi:type="xsd:int">0</Workflow:Rank>
     </Workflow:WorkflowStepBase>
    </Workflow:Steps>
    <Workflow:Triggers xsi:type="Workflow:ArrayOfWorkflowTrigger">
     <Workflow:WorkflowTrigger xsi:type="Workflow:WorkflowTrigger">
      <Workflow:WorkflowTriggerId xsi:type="xsd:int">0</Workflow:WorkflowTriggerId>
      <Workflow:WorkflowId xsi:type="xsd:int">0</Workflow:WorkflowId>
      <Workflow:TriggerType xsi:type="Workflow:WorkflowTriggerType">None</Workflow:TriggerType>
      <Workflow:RestrictionGroups xsi:type="Workflow:ArrayOfArchiveRestrictionGroup">
       <Workflow:ArchiveRestrictionGroup xsi:type="Workflow:ArchiveRestrictionGroup">
        <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
        <Workflow:Description xsi:type="xsd:string"></Workflow:Description>
        <Workflow:Rank xsi:type="xsd:short">0</Workflow:Rank>
        <Workflow:Restrictions xsi:type="Workflow:ArrayOfArchiveRestrictionInfo">
         <Workflow:ArchiveRestrictionInfo xsi:type="Workflow:ArchiveRestrictionInfo">
          <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
          <Workflow:Operator xsi:type="xsd:string"></Workflow:Operator>
          <Workflow:Values xsi:nil="true"></Workflow:Values>
          <Workflow:DisplayValues xsi:nil="true"></Workflow:DisplayValues>
          <Workflow:ColumnInfo xsi:nil="true"></Workflow:ColumnInfo>
          <Workflow:IsActive xsi:nil="true"></Workflow:IsActive>
          <Workflow:SubRestrictions xsi:nil="true"></Workflow:SubRestrictions>
          <Workflow:InterParenthesis xsi:nil="true"></Workflow:InterParenthesis>
          <Workflow:InterOperator xsi:nil="true"></Workflow:InterOperator>
          <Workflow:UniqueHash xsi:nil="true"></Workflow:UniqueHash>
         </Workflow:ArchiveRestrictionInfo>
        </Workflow:Restrictions>
       </Workflow:ArchiveRestrictionGroup>
      </Workflow:RestrictionGroups>
     </Workflow:WorkflowTrigger>
    </Workflow:Triggers>
    <Workflow:Goals xsi:type="Workflow:ArrayOfWorkflowGoal">
     <Workflow:WorkflowGoal xsi:type="Workflow:WorkflowGoal">
      <Workflow:WorkflowGoalId xsi:type="xsd:int">0</Workflow:WorkflowGoalId>
      <Workflow:WorkflowId xsi:type="xsd:int">0</Workflow:WorkflowId>
      <Workflow:GoalType xsi:type="Workflow:WorkflowGoalType">None</Workflow:GoalType>
      <Workflow:RestrictionGroups xsi:type="Workflow:ArrayOfArchiveRestrictionGroup">
       <Workflow:ArchiveRestrictionGroup xsi:type="Workflow:ArchiveRestrictionGroup">
        <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
        <Workflow:Description xsi:type="xsd:string"></Workflow:Description>
        <Workflow:Rank xsi:type="xsd:short">0</Workflow:Rank>
        <Workflow:Restrictions xsi:type="Workflow:ArrayOfArchiveRestrictionInfo">
         <Workflow:ArchiveRestrictionInfo xsi:type="Workflow:ArchiveRestrictionInfo">
          <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
          <Workflow:Operator xsi:type="xsd:string"></Workflow:Operator>
          <Workflow:Values xsi:nil="true"></Workflow:Values>
          <Workflow:DisplayValues xsi:nil="true"></Workflow:DisplayValues>
          <Workflow:ColumnInfo xsi:nil="true"></Workflow:ColumnInfo>
          <Workflow:IsActive xsi:nil="true"></Workflow:IsActive>
          <Workflow:SubRestrictions xsi:nil="true"></Workflow:SubRestrictions>
          <Workflow:InterParenthesis xsi:nil="true"></Workflow:InterParenthesis>
          <Workflow:InterOperator xsi:nil="true"></Workflow:InterOperator>
          <Workflow:UniqueHash xsi:nil="true"></Workflow:UniqueHash>
         </Workflow:ArchiveRestrictionInfo>
        </Workflow:Restrictions>
       </Workflow:ArchiveRestrictionGroup>
      </Workflow:RestrictionGroups>
     </Workflow:WorkflowGoal>
    </Workflow:Goals>
    <Workflow:Filter xsi:type="Workflow:WorkflowFilter">
     <Workflow:RestrictionGroups xsi:type="Workflow:ArrayOfArchiveRestrictionGroup">
      <Workflow:ArchiveRestrictionGroup xsi:type="Workflow:ArchiveRestrictionGroup">
       <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
       <Workflow:Description xsi:type="xsd:string"></Workflow:Description>
       <Workflow:Rank xsi:type="xsd:short">0</Workflow:Rank>
       <Workflow:Restrictions xsi:type="Workflow:ArrayOfArchiveRestrictionInfo">
        <Workflow:ArchiveRestrictionInfo xsi:type="Workflow:ArchiveRestrictionInfo">
         <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
         <Workflow:Operator xsi:type="xsd:string"></Workflow:Operator>
         <Workflow:Values xsi:type="NetServerServices882:ArrayOfstring">
          <NetServerServices882:string xsi:nil="true"></NetServerServices882:string>
         </Workflow:Values>
         <Workflow:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
          <NetServerServices882:string xsi:nil="true"></NetServerServices882:string>
         </Workflow:DisplayValues>
         <Workflow:ColumnInfo xsi:type="Workflow:ArchiveColumnInfo">
          <Workflow:DisplayName xsi:type="xsd:string"></Workflow:DisplayName>
          <Workflow:DisplayTooltip xsi:type="xsd:string"></Workflow:DisplayTooltip>
          <Workflow:DisplayType xsi:type="xsd:string"></Workflow:DisplayType>
          <Workflow:CanOrderBy xsi:nil="true"></Workflow:CanOrderBy>
          <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
          <Workflow:CanRestrictBy xsi:nil="true"></Workflow:CanRestrictBy>
          <Workflow:RestrictionType xsi:type="xsd:string"></Workflow:RestrictionType>
          <Workflow:RestrictionListName xsi:type="xsd:string"></Workflow:RestrictionListName>
          <Workflow:IsVisible xsi:nil="true"></Workflow:IsVisible>
          <Workflow:Width xsi:type="xsd:string"></Workflow:Width>
          <Workflow:IconHint xsi:type="xsd:string"></Workflow:IconHint>
          <Workflow:HeadingIconHint xsi:type="xsd:string"></Workflow:HeadingIconHint>
          <Workflow:ExtraInfo xsi:type="xsd:string"></Workflow:ExtraInfo>
         </Workflow:ColumnInfo>
         <Workflow:IsActive xsi:type="xsd:boolean">false</Workflow:IsActive>
         <Workflow:SubRestrictions xsi:type="Workflow:ArrayOfArchiveRestrictionInfo">
          <Workflow:ArchiveRestrictionInfo xsi:nil="true"></Workflow:ArchiveRestrictionInfo>
         </Workflow:SubRestrictions>
         <Workflow:InterParenthesis xsi:type="xsd:int">0</Workflow:InterParenthesis>
         <Workflow:InterOperator xsi:type="Workflow:InterRestrictionOperator">None</Workflow:InterOperator>
         <Workflow:UniqueHash xsi:type="xsd:int">0</Workflow:UniqueHash>
        </Workflow:ArchiveRestrictionInfo>
       </Workflow:Restrictions>
      </Workflow:ArchiveRestrictionGroup>
     </Workflow:RestrictionGroups>
    </Workflow:Filter>
    <Workflow:BlockLists xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Workflow:BlockLists>
    <Workflow:CreatedBy xsi:type="Workflow:Associate">
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
    </Workflow:CreatedBy>
    <Workflow:UpdatedBy xsi:type="Workflow:Associate">
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
    </Workflow:UpdatedBy>
    <Workflow:CreatedDate xsi:type="xsd:dateTime">2023-11-10T12:38:03Z</Workflow:CreatedDate>
    <Workflow:UpdatedDate xsi:type="xsd:dateTime">2023-11-10T12:38:03Z</Workflow:UpdatedDate>
    <Workflow:VisibleFor xsi:type="Workflow:ArrayOfVisibleFor">
     <Workflow:VisibleFor xsi:type="Workflow:VisibleFor">
      <Workflow:VisibleId xsi:type="xsd:int">0</Workflow:VisibleId>
      <Workflow:Visibility xsi:type="Workflow:Visibility">All</Workflow:Visibility>
      <Workflow:DisplayValue xsi:type="xsd:string"></Workflow:DisplayValue>
     </Workflow:VisibleFor>
    </Workflow:VisibleFor>
   </Workflow:Response>
  </Workflow:SaveEmailFlowResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

