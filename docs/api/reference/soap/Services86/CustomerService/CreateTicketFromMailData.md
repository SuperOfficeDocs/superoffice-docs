---
title: Services86.CustomerServiceAgent.CreateTicketFromMailData SOAP
generated: 1
uid: Services86-CustomerService-CreateTicketFromMailData
---

# Services86 CustomerService CreateTicketFromMailData

SOAP request and response examples **Remote/Services86/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ICustomerServiceAgent.CreateTicketFromMailData">SuperOffice.Services86.ICustomerServiceAgent.CreateTicketFromMailData</see> method.

## CreateTicketFromMailData

This method create a new ticket in the same way as importMail would import an email. It accepts RFC822 formatted data

* **mailboxId:** The id of the Service mailbox
* **data:** RFC822 formatted data to import as a ticket

**Returns:** An object containing some meta data for the created ticket


[WSDL file for Services86/CustomerService](../Services86-CustomerService.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateTicketFromMailData Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <CustomerService:ApplicationToken>1234567-1234-9876</CustomerService:ApplicationToken>
  <CustomerService:Credentials>
    <CustomerService:Ticket>7T:1234abcxyzExample==</CustomerService:Ticket>
  </CustomerService:Credentials>
 <SOAP-ENV:Body>
   <CustomerService:CreateTicketFromMailData>
    <CustomerService:MailboxId xsi:type="xsd:int">0</CustomerService:MailboxId>
    <CustomerService:Data xsi:type="xsd:string"></CustomerService:Data>
   </CustomerService:CreateTicketFromMailData>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateTicketFromMailData Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <CustomerService:CreateTicketFromMailDataResponse>
   <CustomerService:Response xsi:type="CustomerService:TicketInfo">
    <CustomerService:TicketId xsi:type="xsd:int">0</CustomerService:TicketId>
    <CustomerService:Title xsi:type="xsd:string"></CustomerService:Title>
    <CustomerService:OwnerName xsi:type="xsd:string"></CustomerService:OwnerName>
    <CustomerService:CategoryName xsi:type="xsd:string"></CustomerService:CategoryName>
    <CustomerService:PriorityName xsi:type="xsd:string"></CustomerService:PriorityName>
    <CustomerService:TicketUrl xsi:type="xsd:string"></CustomerService:TicketUrl>
    <CustomerService:PersonName xsi:type="xsd:string"></CustomerService:PersonName>
    <CustomerService:ContactName xsi:type="xsd:string"></CustomerService:ContactName>
   </CustomerService:Response>
  </CustomerService:CreateTicketFromMailDataResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

