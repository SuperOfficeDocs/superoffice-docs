---
title: Services88.WorkflowAgent.SaveWorkflowGoal SOAP
generated: true
uid: Services88-Workflow-SaveWorkflowGoal
content_type: reference
---

# Services88 Workflow SaveWorkflowGoal

SOAP request and response examples **Remote/Services88/Workflow.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IWorkflowAgent.SaveWorkflowGoal">SuperOffice.Services88.IWorkflowAgent.SaveWorkflowGoal</see> method.

## SaveWorkflowGoal





[WSDL file for Services88/Workflow](../Services88-Workflow.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveWorkflowGoal Request

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
   <Workflow:SaveWorkflowGoal>
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
    </Workflow:WorkflowGoal>
   </Workflow:SaveWorkflowGoal>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveWorkflowGoal Response

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
  <Workflow:SaveWorkflowGoalResponse>
   <Workflow:Response xsi:type="Workflow:WorkflowGoal">
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
        <Workflow:Values xsi:type="NetServerServices882:ArrayOfstring">
         <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
        </Workflow:Values>
        <Workflow:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
         <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
        </Workflow:DisplayValues>
        <Workflow:ColumnInfo xsi:type="Workflow:ArchiveColumnInfo">
         <Workflow:DisplayName xsi:type="xsd:string"></Workflow:DisplayName>
         <Workflow:DisplayTooltip xsi:type="xsd:string"></Workflow:DisplayTooltip>
         <Workflow:DisplayType xsi:type="xsd:string"></Workflow:DisplayType>
         <Workflow:CanOrderBy xsi:type="xsd:boolean">false</Workflow:CanOrderBy>
         <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
         <Workflow:CanRestrictBy xsi:type="xsd:boolean">false</Workflow:CanRestrictBy>
         <Workflow:RestrictionType xsi:type="xsd:string"></Workflow:RestrictionType>
         <Workflow:RestrictionListName xsi:type="xsd:string"></Workflow:RestrictionListName>
         <Workflow:IsVisible xsi:type="xsd:boolean">false</Workflow:IsVisible>
         <Workflow:Width xsi:type="xsd:string"></Workflow:Width>
         <Workflow:IconHint xsi:type="xsd:string"></Workflow:IconHint>
         <Workflow:HeadingIconHint xsi:type="xsd:string"></Workflow:HeadingIconHint>
         <Workflow:ExtraInfo xsi:type="xsd:string"></Workflow:ExtraInfo>
        </Workflow:ColumnInfo>
        <Workflow:IsActive xsi:type="xsd:boolean">false</Workflow:IsActive>
        <Workflow:SubRestrictions xsi:type="Workflow:ArrayOfArchiveRestrictionInfo">
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
        </Workflow:SubRestrictions>
        <Workflow:InterParenthesis xsi:type="xsd:int">0</Workflow:InterParenthesis>
        <Workflow:InterOperator xsi:type="Workflow:InterRestrictionOperator">None</Workflow:InterOperator>
        <Workflow:UniqueHash xsi:type="xsd:int">0</Workflow:UniqueHash>
       </Workflow:ArchiveRestrictionInfo>
      </Workflow:Restrictions>
     </Workflow:ArchiveRestrictionGroup>
    </Workflow:RestrictionGroups>
   </Workflow:Response>
  </Workflow:SaveWorkflowGoalResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

