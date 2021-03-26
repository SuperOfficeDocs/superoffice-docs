---
uid: services88-customerservice-createsession
title: Services88.CustomerServiceAgent.CreateSession SOAP
Generated: true
---

# Services88 CustomerService CreateSession SOAP

SOAP request and response examples **Remote/Services88/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomerServiceAgent.CreateSession">SuperOffice.Services88.ICustomerServiceAgent.CreateSession</see> method.

## CreateSession

Creates a login session for a CS user

* **remoteIp:** The ip of the client creating the session

**Returns:** The session key information


[WSDL file for Services88/CustomerService](../Services88-CustomerService.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateSession Request

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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services88">
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

