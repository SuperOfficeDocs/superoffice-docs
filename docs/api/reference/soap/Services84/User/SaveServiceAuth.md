---
title: Services84.UserAgent.SaveServiceAuth SOAP
generated: 1
uid: Services84-User-SaveServiceAuth
---

# Services84 User SaveServiceAuth

SOAP request and response examples **Remote/Services84/User.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IUserAgent.SaveServiceAuth">SuperOffice.Services84.IUserAgent.SaveServiceAuth</see> method.

## SaveServiceAuth

Updates the existing ServiceAuth or creates a new ServiceAuth if the id parameter is 0.

* **serviceAuth:** The ServiceAuth that is saved.

**Returns:** New or updated ServiceAuth


[WSDL file for Services84/User](../Services84-User.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveServiceAuth Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services84">
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
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services84">
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

