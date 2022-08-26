---
title: Services88.ListAgent.SaveTicketStatusEntity SOAP
generated: 1
uid: Services88-List-SaveTicketStatusEntity
---

# Services88 List SaveTicketStatusEntity

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.SaveTicketStatusEntity">SuperOffice.Services88.IListAgent.SaveTicketStatusEntity</see> method.

## SaveTicketStatusEntity

Updates the existing TicketStatusEntity or creates a new TicketStatusEntity if the id parameter is 0.

* **ticketStatusEntity:** The TicketStatusEntity that is saved.

**Returns:** New or updated TicketStatusEntity


[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveTicketStatusEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
     <List:IsDefault xsi:type="xsd:boolean">false</List:IsDefault>
     <List:UsedInQueue xsi:type="xsd:boolean">false</List:UsedInQueue>
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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <List:SaveTicketStatusEntityResponse>
   <List:Response xsi:type="List:TicketStatusEntity">
    <List:TicketStatusId xsi:type="xsd:int">0</List:TicketStatusId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Status xsi:type="List:TicketBaseStatus">Unknown</List:Status>
    <List:TimeCounter xsi:type="List:TicketStatusTimeCounter">None</List:TimeCounter>
    <List:NoEmailReopen xsi:type="xsd:boolean">false</List:NoEmailReopen>
    <List:IsDefault xsi:type="xsd:boolean">false</List:IsDefault>
    <List:UsedInQueue xsi:type="xsd:boolean">false</List:UsedInQueue>
   </List:Response>
  </List:SaveTicketStatusEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

