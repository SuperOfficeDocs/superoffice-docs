---
title: Services88.ProjectAgent.GetProjectEventEntityFromProjectId SOAP
generated: true
uid: Services88-Project-GetProjectEventEntityFromProjectId
---

# Services88 Project GetProjectEventEntityFromProjectId

SOAP request and response examples **Remote/Services88/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IProjectAgent.GetProjectEventEntityFromProjectId">SuperOffice.Services88.IProjectAgent.GetProjectEventEntityFromProjectId</see> method.

## GetProjectEventEntityFromProjectId





[WSDL file for Services88/Project](../Services88-Project.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProjectEventEntityFromProjectId Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Project:ApplicationToken>1234567-1234-9876</Project:ApplicationToken>
  <Project:Credentials>
    <Project:Ticket>7T:1234abcxyzExample==</Project:Ticket>
  </Project:Credentials>
 <SOAP-ENV:Body>
   <Project:GetProjectEventEntityFromProjectId>
    <Project:ProjectId xsi:type="xsd:int">0</Project:ProjectId>
   </Project:GetProjectEventEntityFromProjectId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetProjectEventEntityFromProjectId Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Project:GetProjectEventEntityFromProjectIdResponse>
   <Project:Response xsi:type="Project:ProjectEventEntity">
    <Project:SignOffConfirmationText xsi:type="xsd:string"></Project:SignOffConfirmationText>
    <Project:SignOffText xsi:type="xsd:string"></Project:SignOffText>
    <Project:SignOnConfirmationText xsi:type="xsd:string"></Project:SignOnConfirmationText>
    <Project:SignOnText xsi:type="xsd:string"></Project:SignOnText>
    <Project:EventDate xsi:type="xsd:dateTime">2025-06-26T01:44:35Z</Project:EventDate>
    <Project:Enabled xsi:type="xsd:boolean">false</Project:Enabled>
    <Project:CreatedDate xsi:type="xsd:dateTime">2025-06-26T01:44:35Z</Project:CreatedDate>
    <Project:SignOff xsi:type="xsd:boolean">false</Project:SignOff>
    <Project:SignOffTaskEnable xsi:type="xsd:boolean">false</Project:SignOffTaskEnable>
    <Project:SignOffTaskId xsi:type="xsd:int">0</Project:SignOffTaskId>
    <Project:SignOffTriggersAssign xsi:type="xsd:boolean">false</Project:SignOffTriggersAssign>
    <Project:SignOn xsi:type="xsd:boolean">false</Project:SignOn>
    <Project:SignOnTaskEnable xsi:type="xsd:boolean">false</Project:SignOnTaskEnable>
    <Project:SignOnTaskId xsi:type="xsd:int">0</Project:SignOnTaskId>
    <Project:SignOnTriggersAssign xsi:type="xsd:boolean">false</Project:SignOnTriggersAssign>
    <Project:UpdatedDate xsi:type="xsd:dateTime">2025-06-26T01:44:35Z</Project:UpdatedDate>
    <Project:CreatedBy xsi:type="Project:Associate">
     <Project:AssociateId xsi:type="xsd:int">0</Project:AssociateId>
     <Project:Name xsi:type="xsd:string"></Project:Name>
     <Project:PersonId xsi:type="xsd:int">0</Project:PersonId>
     <Project:Rank xsi:type="xsd:short">0</Project:Rank>
     <Project:Tooltip xsi:type="xsd:string"></Project:Tooltip>
     <Project:Type xsi:type="Project:UserType">Unknown</Project:Type>
     <Project:GroupIdx xsi:type="xsd:int">0</Project:GroupIdx>
     <Project:FullName xsi:type="xsd:string"></Project:FullName>
     <Project:FormalName xsi:type="xsd:string"></Project:FormalName>
     <Project:Deleted xsi:type="xsd:boolean">false</Project:Deleted>
     <Project:EjUserId xsi:type="xsd:int">0</Project:EjUserId>
     <Project:UserName xsi:type="xsd:string"></Project:UserName>
    </Project:CreatedBy>
    <Project:UpdatedBy xsi:type="Project:Associate">
     <Project:AssociateId xsi:type="xsd:int">0</Project:AssociateId>
     <Project:Name xsi:type="xsd:string"></Project:Name>
     <Project:PersonId xsi:type="xsd:int">0</Project:PersonId>
     <Project:Rank xsi:type="xsd:short">0</Project:Rank>
     <Project:Tooltip xsi:type="xsd:string"></Project:Tooltip>
     <Project:Type xsi:type="Project:UserType">Unknown</Project:Type>
     <Project:GroupIdx xsi:type="xsd:int">0</Project:GroupIdx>
     <Project:FullName xsi:type="xsd:string"></Project:FullName>
     <Project:FormalName xsi:type="xsd:string"></Project:FormalName>
     <Project:Deleted xsi:type="xsd:boolean">false</Project:Deleted>
     <Project:EjUserId xsi:type="xsd:int">0</Project:EjUserId>
     <Project:UserName xsi:type="xsd:string"></Project:UserName>
    </Project:UpdatedBy>
    <Project:ProjectId xsi:type="xsd:int">0</Project:ProjectId>
    <Project:Id xsi:type="xsd:int">0</Project:Id>
    <Project:PublishFrom xsi:type="xsd:dateTime">2025-06-26T01:44:35Z</Project:PublishFrom>
    <Project:PublishType xsi:type="Project:PublishType">Undefined</Project:PublishType>
    <Project:PublishTo xsi:type="xsd:dateTime">2025-06-26T01:44:35Z</Project:PublishTo>
    <Project:VisibleForCategories xsi:type="Project:ArrayOfMDOListItem">
     <Project:MDOListItem xsi:type="Project:MDOListItem">
      <Project:Id xsi:type="xsd:int">0</Project:Id>
      <Project:Name xsi:type="xsd:string"></Project:Name>
      <Project:ToolTip xsi:type="xsd:string"></Project:ToolTip>
      <Project:Deleted xsi:type="xsd:boolean">false</Project:Deleted>
      <Project:Rank xsi:type="xsd:int">0</Project:Rank>
      <Project:Type xsi:type="xsd:string"></Project:Type>
      <Project:ChildItems xsi:type="Project:ArrayOfMDOListItem">
       <Project:MDOListItem xsi:type="Project:MDOListItem">
        <Project:Id xsi:type="xsd:int">0</Project:Id>
        <Project:Name xsi:type="xsd:string"></Project:Name>
        <Project:ToolTip xsi:type="xsd:string"></Project:ToolTip>
        <Project:Deleted xsi:type="xsd:boolean">false</Project:Deleted>
        <Project:Rank xsi:type="xsd:int">0</Project:Rank>
        <Project:Type xsi:type="xsd:string"></Project:Type>
        <Project:ChildItems xsi:type="Project:ArrayOfMDOListItem">
         <Project:MDOListItem xsi:type="Project:MDOListItem">
          <Project:Id xsi:nil="true"></Project:Id>
          <Project:Name xsi:type="xsd:string"></Project:Name>
          <Project:ToolTip xsi:type="xsd:string"></Project:ToolTip>
          <Project:Deleted xsi:nil="true"></Project:Deleted>
          <Project:Rank xsi:nil="true"></Project:Rank>
          <Project:Type xsi:type="xsd:string"></Project:Type>
          <Project:ChildItems xsi:nil="true"></Project:ChildItems>
          <Project:IconHint xsi:type="xsd:string"></Project:IconHint>
          <Project:ColorBlock xsi:nil="true"></Project:ColorBlock>
          <Project:ExtraInfo xsi:type="xsd:string"></Project:ExtraInfo>
          <Project:StyleHint xsi:type="xsd:string"></Project:StyleHint>
          <Project:FullName xsi:type="xsd:string"></Project:FullName>
         </Project:MDOListItem>
        </Project:ChildItems>
        <Project:IconHint xsi:type="xsd:string"></Project:IconHint>
        <Project:ColorBlock xsi:type="xsd:int">0</Project:ColorBlock>
        <Project:ExtraInfo xsi:type="xsd:string"></Project:ExtraInfo>
        <Project:StyleHint xsi:type="xsd:string"></Project:StyleHint>
        <Project:FullName xsi:type="xsd:string"></Project:FullName>
       </Project:MDOListItem>
      </Project:ChildItems>
      <Project:IconHint xsi:type="xsd:string"></Project:IconHint>
      <Project:ColorBlock xsi:type="xsd:int">0</Project:ColorBlock>
      <Project:ExtraInfo xsi:type="xsd:string"></Project:ExtraInfo>
      <Project:StyleHint xsi:type="xsd:string"></Project:StyleHint>
      <Project:FullName xsi:type="xsd:string"></Project:FullName>
     </Project:MDOListItem>
    </Project:VisibleForCategories>
    <Project:VisibleForPersonInterests xsi:type="Project:ArrayOfMDOListItem">
     <Project:MDOListItem xsi:type="Project:MDOListItem">
      <Project:Id xsi:type="xsd:int">0</Project:Id>
      <Project:Name xsi:type="xsd:string"></Project:Name>
      <Project:ToolTip xsi:type="xsd:string"></Project:ToolTip>
      <Project:Deleted xsi:type="xsd:boolean">false</Project:Deleted>
      <Project:Rank xsi:type="xsd:int">0</Project:Rank>
      <Project:Type xsi:type="xsd:string"></Project:Type>
      <Project:ChildItems xsi:type="Project:ArrayOfMDOListItem">
       <Project:MDOListItem xsi:type="Project:MDOListItem">
        <Project:Id xsi:type="xsd:int">0</Project:Id>
        <Project:Name xsi:type="xsd:string"></Project:Name>
        <Project:ToolTip xsi:type="xsd:string"></Project:ToolTip>
        <Project:Deleted xsi:type="xsd:boolean">false</Project:Deleted>
        <Project:Rank xsi:type="xsd:int">0</Project:Rank>
        <Project:Type xsi:type="xsd:string"></Project:Type>
        <Project:ChildItems xsi:type="Project:ArrayOfMDOListItem">
         <Project:MDOListItem xsi:type="Project:MDOListItem">
          <Project:Id xsi:nil="true"></Project:Id>
          <Project:Name xsi:type="xsd:string"></Project:Name>
          <Project:ToolTip xsi:type="xsd:string"></Project:ToolTip>
          <Project:Deleted xsi:nil="true"></Project:Deleted>
          <Project:Rank xsi:nil="true"></Project:Rank>
          <Project:Type xsi:type="xsd:string"></Project:Type>
          <Project:ChildItems xsi:nil="true"></Project:ChildItems>
          <Project:IconHint xsi:type="xsd:string"></Project:IconHint>
          <Project:ColorBlock xsi:nil="true"></Project:ColorBlock>
          <Project:ExtraInfo xsi:type="xsd:string"></Project:ExtraInfo>
          <Project:StyleHint xsi:type="xsd:string"></Project:StyleHint>
          <Project:FullName xsi:type="xsd:string"></Project:FullName>
         </Project:MDOListItem>
        </Project:ChildItems>
        <Project:IconHint xsi:type="xsd:string"></Project:IconHint>
        <Project:ColorBlock xsi:type="xsd:int">0</Project:ColorBlock>
        <Project:ExtraInfo xsi:type="xsd:string"></Project:ExtraInfo>
        <Project:StyleHint xsi:type="xsd:string"></Project:StyleHint>
        <Project:FullName xsi:type="xsd:string"></Project:FullName>
       </Project:MDOListItem>
      </Project:ChildItems>
      <Project:IconHint xsi:type="xsd:string"></Project:IconHint>
      <Project:ColorBlock xsi:type="xsd:int">0</Project:ColorBlock>
      <Project:ExtraInfo xsi:type="xsd:string"></Project:ExtraInfo>
      <Project:StyleHint xsi:type="xsd:string"></Project:StyleHint>
      <Project:FullName xsi:type="xsd:string"></Project:FullName>
     </Project:MDOListItem>
    </Project:VisibleForPersonInterests>
    <Project:IsPublished xsi:type="xsd:boolean">false</Project:IsPublished>
    <Project:IsVisibleForMembers xsi:type="xsd:boolean">false</Project:IsVisibleForMembers>
    <Project:IsVisibleForCategories xsi:type="xsd:boolean">false</Project:IsVisibleForCategories>
    <Project:IsVisibleForPersonInterests xsi:type="xsd:boolean">false</Project:IsVisibleForPersonInterests>
    <Project:ProjectEventId xsi:type="xsd:int">0</Project:ProjectEventId>
   </Project:Response>
  </Project:GetProjectEventEntityFromProjectIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

