---
title: Services87.AppointmentAgent.GetSuggestedAppointmentEntity SOAP
generated: 1
uid: Services87-Appointment-GetSuggestedAppointmentEntity
---

# Services87 Appointment GetSuggestedAppointmentEntity

SOAP request and response examples **Remote/Services87/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IAppointmentAgent.GetSuggestedAppointmentEntity">SuperOffice.Services87.IAppointmentAgent.GetSuggestedAppointmentEntity</see> method.

## GetSuggestedAppointmentEntity

Gets a SuggestedAppointmentEntity object.

* **suggestedAppointmentEntityId:** The identifier of the SuggestedAppointmentEntity object

**Returns:** SuggestedAppointmentEntity


[WSDL file for Services87/Appointment](../Services87-Appointment.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSuggestedAppointmentEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:GetSuggestedAppointmentEntity>
    <Appointment:SuggestedAppointmentEntityId xsi:type="xsd:int">0</Appointment:SuggestedAppointmentEntityId>
   </Appointment:GetSuggestedAppointmentEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSuggestedAppointmentEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Appointment:GetSuggestedAppointmentEntityResponse>
   <Appointment:Response xsi:type="Appointment:SuggestedAppointmentEntity">
    <Appointment:SuggestedAppointmentId xsi:type="xsd:int">0</Appointment:SuggestedAppointmentId>
    <Appointment:Name xsi:type="xsd:string"></Appointment:Name>
    <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
    <Appointment:Rank xsi:type="xsd:short">0</Appointment:Rank>
    <Appointment:Deleted xsi:type="xsd:boolean">false</Appointment:Deleted>
    <Appointment:DaysFuture xsi:type="xsd:short">0</Appointment:DaysFuture>
    <Appointment:Duration xsi:type="NetServerServices871:duration"></Appointment:Duration>
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
  </Appointment:GetSuggestedAppointmentEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

