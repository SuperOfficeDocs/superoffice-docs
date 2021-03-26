---
uid: services75-appointment-createdefaulttasklistitem
title: Services75.AppointmentAgent.CreateDefaultTaskListItem SOAP
Generated: true
---

# Services75 Appointment CreateDefaultTaskListItem SOAP

SOAP request and response examples **Remote/Services75/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IAppointmentAgent.CreateDefaultTaskListItem">SuperOffice.Services75.IAppointmentAgent.CreateDefaultTaskListItem</see> method.

## CreateDefaultTaskListItem

Loading default values into a new TaskListItem.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New TaskListItem with default values


[WSDL file for Services75/Appointment](../Services75-Appointment.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultTaskListItem Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:CreateDefaultTaskListItem>
   </Appointment:CreateDefaultTaskListItem>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultTaskListItem Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Appointment:CreateDefaultTaskListItemResponse>
   <Appointment:Response xsi:type="Appointment:TaskListItem">
    <Appointment:TaskListItemId xsi:type="xsd:int">0</Appointment:TaskListItemId>
    <Appointment:Value xsi:type="xsd:string"></Appointment:Value>
    <Appointment:Direction xsi:type="Appointment:TaskDirection">Unknown</Appointment:Direction>
    <Appointment:Type xsi:type="Appointment:TaskType">Unknown</Appointment:Type>
    <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
    <Appointment:Deleted xsi:type="xsd:boolean">false</Appointment:Deleted>
    <Appointment:IntentId xsi:type="xsd:int">0</Appointment:IntentId>
    <Appointment:Rank xsi:type="xsd:short">0</Appointment:Rank>
    <Appointment:IsDefaultAlldayEvent xsi:type="xsd:boolean">false</Appointment:IsDefaultAlldayEvent>
    <Appointment:IsDefaultFree xsi:type="xsd:boolean">false</Appointment:IsDefaultFree>
    <Appointment:IsDefaultPublished xsi:type="xsd:boolean">false</Appointment:IsDefaultPublished>
    <Appointment:ColorIndex xsi:type="Appointment:ColorIndex">LightBlue</Appointment:ColorIndex>
   </Appointment:Response>
  </Appointment:CreateDefaultTaskListItemResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

