---
uid: services86-list-saveticketstatusentity
title: Services86.ListAgent.SaveTicketStatusEntity SOAP
Generated: true
---

# Services86 List SaveTicketStatusEntity SOAP

SOAP request and response examples **Remote/Services86/List.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IListAgent.SaveTicketStatusEntity">SuperOffice.Services86.IListAgent.SaveTicketStatusEntity</see> method.

## SaveTicketStatusEntity

Updates the existing TicketStatusEntity or creates a new TicketStatusEntity if the id parameter is 0.

* **ticketStatusEntity:** The TicketStatusEntity that is saved.

**Returns:** New or updated TicketStatusEntity


[WSDL file for Services86/List](../Services86-List.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveTicketStatusEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:SaveTicketStatusEntity>
    <List:TicketStatusEntity xsi:type="List:TicketStatusEntity">
     <List:TicketStatusId xsi:type="xsd:int">0</List:TicketStatusId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:Status xsi:type="List:TicketBaseStatus">Unknown</List:Status>
     <List:TimeCounter xsi:type="List:TicketStatusTimeCounter">None</List:TimeCounter>
     <List:NoEmailReopen xsi:type="xsd:boolean">false</List:NoEmailReopen>
    </List:TicketStatusEntity>
   </List:SaveTicketStatusEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveTicketStatusEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <List:SaveTicketStatusEntityResponse>
   <List:Response xsi:type="List:TicketStatusEntity">
    <List:TicketStatusId xsi:type="xsd:int">0</List:TicketStatusId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Status xsi:type="List:TicketBaseStatus">Unknown</List:Status>
    <List:TimeCounter xsi:type="List:TicketStatusTimeCounter">None</List:TimeCounter>
    <List:NoEmailReopen xsi:type="xsd:boolean">false</List:NoEmailReopen>
   </List:Response>
  </List:SaveTicketStatusEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

