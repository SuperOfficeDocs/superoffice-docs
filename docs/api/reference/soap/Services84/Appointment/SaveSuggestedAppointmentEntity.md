---
title: Services84.AppointmentAgent.SaveSuggestedAppointmentEntity SOAP
generated: 1
uid: Services84-Appointment-SaveSuggestedAppointmentEntity
---

# Services84 Appointment SaveSuggestedAppointmentEntity

SOAP request and response examples **Remote/Services84/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IAppointmentAgent.SaveSuggestedAppointmentEntity">SuperOffice.Services84.IAppointmentAgent.SaveSuggestedAppointmentEntity</see> method.

## SaveSuggestedAppointmentEntity

Updates the existing SuggestedAppointmentEntity or creates a new SuggestedAppointmentEntity if the id parameter is 0.

* **suggestedAppointmentEntity:** The SuggestedAppointmentEntity that is saved.

**Returns:** New or updated SuggestedAppointmentEntity


[WSDL file for Services84/Appointment](../Services84-Appointment.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveSuggestedAppointmentEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:SaveSuggestedAppointmentEntity>
    <Appointment:SuggestedAppointmentEntity xsi:type="Appointment:SuggestedAppointmentEntity">
     <Appointment:SuggestedAppointmentId xsi:type="xsd:int">0</Appointment:SuggestedAppointmentId>
     <Appointment:Name xsi:type="xsd:string"></Appointment:Name>
     <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
     <Appointment:Rank xsi:type="xsd:short">0</Appointment:Rank>
     <Appointment:Deleted xsi:type="xsd:boolean">false</Appointment:Deleted>
     <Appointment:DaysFuture xsi:type="xsd:short">0</Appointment:DaysFuture>
     <Appointment:Duration xsi:type="NetServerServices841:duration"></Appointment:Duration>
     <Appointment:AutoSuggest xsi:type="xsd:boolean">false</Appointment:AutoSuggest>
     <Appointment:IsMilestone xsi:type="xsd:boolean">false</Appointment:IsMilestone>
     <Appointment:AssignToMember xsi:type="xsd:boolean">false</Appointment:AssignToMember>
     <Appointment:Text xsi:type="xsd:string"></Appointment:Text>
     <Appointment:ProjectTypeStatusLink xsi:type="Appointment:ProjectTypeStatusLink">
      <Appointment:ProjectTypeStatusLinkId xsi:type="xsd:int">0</Appointment:ProjectTypeStatusLinkId>
      <Appointment:ProjTypeId xsi:type="xsd:int">0</Appointment:ProjTypeId>
      <Appointment:ProjTypeName xsi:type="xsd:string"></Appointment:ProjTypeName>
      <Appointment:ProjTypeTooltip xsi:type="xsd:string"></Appointment:ProjTypeTooltip>
      <Appointment:ProjStatusId xsi:type="xsd:int">0</Appointment:ProjStatusId>
      <Appointment:ProjStatusName xsi:type="xsd:string"></Appointment:ProjStatusName>
      <Appointment:ProjStatusTooltip xsi:type="xsd:string"></Appointment:ProjStatusTooltip>
     </Appointment:ProjectTypeStatusLink>
     <Appointment:SaleTypeStageLink xsi:type="Appointment:SaleTypeStageLink">
      <Appointment:SaleTypeStageLinkId xsi:type="xsd:int">0</Appointment:SaleTypeStageLinkId>
      <Appointment:SaleTypeId xsi:type="xsd:int">0</Appointment:SaleTypeId>
      <Appointment:SaleTypeName xsi:type="xsd:string"></Appointment:SaleTypeName>
      <Appointment:SaleTypeTooltip xsi:type="xsd:string"></Appointment:SaleTypeTooltip>
      <Appointment:ProbId xsi:type="xsd:int">0</Appointment:ProbId>
      <Appointment:ProbName xsi:type="xsd:string"></Appointment:ProbName>
      <Appointment:ProbTooltip xsi:type="xsd:string"></Appointment:ProbTooltip>
      <Appointment:Probability xsi:type="xsd:short">0</Appointment:Probability>
     </Appointment:SaleTypeStageLink>
     <Appointment:Type xsi:type="Appointment:Task">
      <Appointment:Id xsi:type="xsd:int">0</Appointment:Id>
      <Appointment:Value xsi:type="xsd:string"></Appointment:Value>
      <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
     </Appointment:Type>
    </Appointment:SuggestedAppointmentEntity>
   </Appointment:SaveSuggestedAppointmentEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveSuggestedAppointmentEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Appointment:SaveSuggestedAppointmentEntityResponse>
   <Appointment:Response xsi:type="Appointment:SuggestedAppointmentEntity">
    <Appointment:SuggestedAppointmentId xsi:type="xsd:int">0</Appointment:SuggestedAppointmentId>
    <Appointment:Name xsi:type="xsd:string"></Appointment:Name>
    <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
    <Appointment:Rank xsi:type="xsd:short">0</Appointment:Rank>
    <Appointment:Deleted xsi:type="xsd:boolean">false</Appointment:Deleted>
    <Appointment:DaysFuture xsi:type="xsd:short">0</Appointment:DaysFuture>
    <Appointment:Duration xsi:type="NetServerServices841:duration"></Appointment:Duration>
    <Appointment:AutoSuggest xsi:type="xsd:boolean">false</Appointment:AutoSuggest>
    <Appointment:IsMilestone xsi:type="xsd:boolean">false</Appointment:IsMilestone>
    <Appointment:AssignToMember xsi:type="xsd:boolean">false</Appointment:AssignToMember>
    <Appointment:Text xsi:type="xsd:string"></Appointment:Text>
    <Appointment:ProjectTypeStatusLink xsi:type="Appointment:ProjectTypeStatusLink">
     <Appointment:ProjectTypeStatusLinkId xsi:type="xsd:int">0</Appointment:ProjectTypeStatusLinkId>
     <Appointment:ProjTypeId xsi:type="xsd:int">0</Appointment:ProjTypeId>
     <Appointment:ProjTypeName xsi:type="xsd:string"></Appointment:ProjTypeName>
     <Appointment:ProjTypeTooltip xsi:type="xsd:string"></Appointment:ProjTypeTooltip>
     <Appointment:ProjStatusId xsi:type="xsd:int">0</Appointment:ProjStatusId>
     <Appointment:ProjStatusName xsi:type="xsd:string"></Appointment:ProjStatusName>
     <Appointment:ProjStatusTooltip xsi:type="xsd:string"></Appointment:ProjStatusTooltip>
    </Appointment:ProjectTypeStatusLink>
    <Appointment:SaleTypeStageLink xsi:type="Appointment:SaleTypeStageLink">
     <Appointment:SaleTypeStageLinkId xsi:type="xsd:int">0</Appointment:SaleTypeStageLinkId>
     <Appointment:SaleTypeId xsi:type="xsd:int">0</Appointment:SaleTypeId>
     <Appointment:SaleTypeName xsi:type="xsd:string"></Appointment:SaleTypeName>
     <Appointment:SaleTypeTooltip xsi:type="xsd:string"></Appointment:SaleTypeTooltip>
     <Appointment:ProbId xsi:type="xsd:int">0</Appointment:ProbId>
     <Appointment:ProbName xsi:type="xsd:string"></Appointment:ProbName>
     <Appointment:ProbTooltip xsi:type="xsd:string"></Appointment:ProbTooltip>
     <Appointment:Probability xsi:type="xsd:short">0</Appointment:Probability>
    </Appointment:SaleTypeStageLink>
    <Appointment:Type xsi:type="Appointment:Task">
     <Appointment:Id xsi:type="xsd:int">0</Appointment:Id>
     <Appointment:Value xsi:type="xsd:string"></Appointment:Value>
     <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
    </Appointment:Type>
   </Appointment:Response>
  </Appointment:SaveSuggestedAppointmentEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

