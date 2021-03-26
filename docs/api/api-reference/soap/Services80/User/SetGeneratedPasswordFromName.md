---
uid: services80-user-setgeneratedpasswordfromname
title: Services80.UserAgent.SetGeneratedPasswordFromName SOAP
Generated: true
---

# Services80 User SetGeneratedPasswordFromName SOAP

SOAP request and response examples **Remote/Services80/User.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IUserAgent.SetGeneratedPasswordFromName">SuperOffice.Services80.IUserAgent.SetGeneratedPasswordFromName</see> method.

## SetGeneratedPasswordFromName



* **associateName:** 



[WSDL file for Services80/User](../Services80-User.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetGeneratedPasswordFromName Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:SetGeneratedPasswordFromName>
    <User:AssociateName xsi:type="xsd:string"></User:AssociateName>
   </User:SetGeneratedPasswordFromName>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetGeneratedPasswordFromName Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <User:SetGeneratedPasswordFromNameResponse>
   <User:Response xsi:type="xsd:string"></User:Response>
  </User:SetGeneratedPasswordFromNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

