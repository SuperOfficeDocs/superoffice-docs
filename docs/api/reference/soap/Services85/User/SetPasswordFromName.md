---
title: Services85.UserAgent.SetPasswordFromName SOAP
generated: 1
uid: Services85-User-SetPasswordFromName
---

# Services85 User SetPasswordFromName

SOAP request and response examples **Remote/Services85/User.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IUserAgent.SetPasswordFromName">SuperOffice.Services85.IUserAgent.SetPasswordFromName</see> method.

## SetPasswordFromName



* **associateName:** 
* **password:** 



[WSDL file for Services85/User](../Services85-User.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetPasswordFromName Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:SetPasswordFromName>
    <User:AssociateName xsi:type="xsd:string"></User:AssociateName>
    <User:Password xsi:type="xsd:string"></User:Password>
   </User:SetPasswordFromName>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetPasswordFromName Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <User:SetPasswordFromNameResponse>
   <User:Response xsi:type="xsd:boolean">false</User:Response>
  </User:SetPasswordFromNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

