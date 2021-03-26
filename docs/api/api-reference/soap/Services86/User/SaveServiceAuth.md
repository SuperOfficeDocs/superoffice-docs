---
uid: services86-user-saveserviceauth
title: Services86.UserAgent.SaveServiceAuth SOAP
Generated: true
---

# Services86 User SaveServiceAuth SOAP

SOAP request and response examples **Remote/Services86/User.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IUserAgent.SaveServiceAuth">SuperOffice.Services86.IUserAgent.SaveServiceAuth</see> method.

## SaveServiceAuth

Updates the existing ServiceAuth or creates a new ServiceAuth if the id parameter is 0.
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **serviceAuth:** The ServiceAuth that is saved.

**Returns:** New or updated ServiceAuth


[WSDL file for Services86/User](../Services86-User.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveServiceAuth Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:SaveServiceAuth>
    <User:ServiceAuth xsi:type="User:ServiceAuth">
     <User:ServiceAuthId xsi:type="xsd:int">0</User:ServiceAuthId>
     <User:Server xsi:type="xsd:string"></User:Server>
     <User:Port xsi:type="xsd:int">0</User:Port>
     <User:AuthType xsi:type="xsd:string"></User:AuthType>
     <User:Username xsi:type="xsd:string"></User:Username>
     <User:Password xsi:type="xsd:string"></User:Password>
    </User:ServiceAuth>
   </User:SaveServiceAuth>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveServiceAuth Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <User:SaveServiceAuthResponse>
   <User:Response xsi:type="User:ServiceAuth">
    <User:ServiceAuthId xsi:type="xsd:int">0</User:ServiceAuthId>
    <User:Server xsi:type="xsd:string"></User:Server>
    <User:Port xsi:type="xsd:int">0</User:Port>
    <User:AuthType xsi:type="xsd:string"></User:AuthType>
    <User:Username xsi:type="xsd:string"></User:Username>
    <User:Password xsi:type="xsd:string"></User:Password>
   </User:Response>
  </User:SaveServiceAuthResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

