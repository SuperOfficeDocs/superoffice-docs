---
title: Services85.CustomerServiceAgent.CreateSession SOAP
generated: 1
uid: Services85-CustomerService-CreateSession
---

# Services85 CustomerService CreateSession

SOAP request and response examples **Remote/Services85/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ICustomerServiceAgent.CreateSession">SuperOffice.Services85.ICustomerServiceAgent.CreateSession</see> method.

## CreateSession

Creates a login session for a CS user

* **remoteIp:** The ip of the client creating the session

**Returns:** The session key information


[WSDL file for Services85/CustomerService](../Services85-CustomerService.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateSession Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <CustomerService:ApplicationToken>1234567-1234-9876</CustomerService:ApplicationToken>
  <CustomerService:Credentials>
    <CustomerService:Ticket>7T:1234abcxyzExample==</CustomerService:Ticket>
  </CustomerService:Credentials>
 <SOAP-ENV:Body>
   <CustomerService:CreateSession>
    <CustomerService:RemoteIp xsi:type="xsd:string"></CustomerService:RemoteIp>
   </CustomerService:CreateSession>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateSession Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <CustomerService:CreateSessionResponse>
   <CustomerService:Response xsi:type="CustomerService:CsSessionKey">
    <CustomerService:Key xsi:type="xsd:string"></CustomerService:Key>
    <CustomerService:LoginId xsi:type="xsd:int">0</CustomerService:LoginId>
    <CustomerService:UserId xsi:type="xsd:int">0</CustomerService:UserId>
   </CustomerService:Response>
  </CustomerService:CreateSessionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

