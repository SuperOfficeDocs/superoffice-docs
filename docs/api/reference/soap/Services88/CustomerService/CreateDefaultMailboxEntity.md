---
title: Services88.CustomerServiceAgent.CreateDefaultMailboxEntity SOAP
generated: 1
uid: Services88-CustomerService-CreateDefaultMailboxEntity
---

# Services88 CustomerService CreateDefaultMailboxEntity

SOAP request and response examples **Remote/Services88/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomerServiceAgent.CreateDefaultMailboxEntity">SuperOffice.Services88.ICustomerServiceAgent.CreateDefaultMailboxEntity</see> method.

## CreateDefaultMailboxEntity

Loading default values into a new MailboxEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New MailboxEntity with default values


[WSDL file for Services88/CustomerService](../Services88-CustomerService.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultMailboxEntity Request

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
   <CustomerService:CreateDefaultMailboxEntity>
   </CustomerService:CreateDefaultMailboxEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultMailboxEntity Response

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
  <CustomerService:CreateDefaultMailboxEntityResponse>
   <CustomerService:Response xsi:type="CustomerService:MailboxEntity">
    <CustomerService:MailInFilterId xsi:type="xsd:int">0</CustomerService:MailInFilterId>
    <CustomerService:ServerType xsi:type="CustomerService:MailboxType">Unknown</CustomerService:ServerType>
    <CustomerService:Address xsi:type="xsd:string"></CustomerService:Address>
    <CustomerService:Username xsi:type="xsd:string"></CustomerService:Username>
    <CustomerService:Password xsi:type="xsd:string"></CustomerService:Password>
    <CustomerService:Server xsi:type="xsd:string"></CustomerService:Server>
    <CustomerService:Port xsi:type="xsd:int">0</CustomerService:Port>
   </CustomerService:Response>
  </CustomerService:CreateDefaultMailboxEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

