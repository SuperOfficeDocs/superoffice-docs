---
uid: services86-customerservice-removesession
title: Services86.CustomerServiceAgent.RemoveSession SOAP
Generated: true
---

# Services86 CustomerService RemoveSession SOAP

SOAP request and response examples **Remote/Services86/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ICustomerServiceAgent.RemoveSession">SuperOffice.Services86.ICustomerServiceAgent.RemoveSession</see> method.

## RemoveSession

Remove a login session for a CS user

* **loginId:** The login id to remove



[WSDL file for Services86/CustomerService](../Services86-CustomerService.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RemoveSession Request

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
   <CustomerService:RemoveSession>
    <CustomerService:LoginId xsi:type="xsd:int">0</CustomerService:LoginId>
   </CustomerService:RemoveSession>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RemoveSession Response

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
  <CustomerService:RemoveSessionResponse>
  </CustomerService:RemoveSessionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

