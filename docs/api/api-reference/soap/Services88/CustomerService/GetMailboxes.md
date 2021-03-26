---
uid: services88-customerservice-getmailboxes
title: Services88.CustomerServiceAgent.GetMailboxes SOAP
Generated: true
---

# Services88 CustomerService GetMailboxes SOAP

SOAP request and response examples **Remote/Services88/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomerServiceAgent.GetMailboxes">SuperOffice.Services88.ICustomerServiceAgent.GetMailboxes</see> method.

## GetMailboxes

This method will get all registered mailboxes in Service


**Returns:** An array of Mailbox objects


[WSDL file for Services88/CustomerService](../Services88-CustomerService.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetMailboxes Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <CustomerService:ApplicationToken>1234567-1234-9876</CustomerService:ApplicationToken>
  <CustomerService:Credentials>
    <CustomerService:Ticket>7T:1234abcxyzExample==</CustomerService:Ticket>
  </CustomerService:Credentials>
 <SOAP-ENV:Body>
   <CustomerService:GetMailboxes>
   </CustomerService:GetMailboxes>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetMailboxes Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <CustomerService:GetMailboxesResponse>
   <CustomerService:Response xsi:type="CustomerService:ArrayOfMailbox">
    <CustomerService:Mailbox xsi:type="CustomerService:Mailbox">
     <CustomerService:MailInFilterId xsi:type="xsd:int">0</CustomerService:MailInFilterId>
     <CustomerService:Address xsi:type="xsd:string"></CustomerService:Address>
     <CustomerService:CategoryName xsi:type="xsd:string"></CustomerService:CategoryName>
     <CustomerService:PriorityName xsi:type="xsd:string"></CustomerService:PriorityName>
    </CustomerService:Mailbox>
   </CustomerService:Response>
  </CustomerService:GetMailboxesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

