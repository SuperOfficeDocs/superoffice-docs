---
uid: services86-user-ispasswordvalid
title: Services86.UserAgent.IsPasswordValid SOAP
Generated: true
---

# Services86 User IsPasswordValid SOAP

SOAP request and response examples **Remote/Services86/User.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IUserAgent.IsPasswordValid">SuperOffice.Services86.IUserAgent.IsPasswordValid</see> method.

## IsPasswordValid

<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **associateId:** 
* **type:** 
* **personId:** 
* **password:** 



[WSDL file for Services86/User](../Services86-User.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## IsPasswordValid Request

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
   <User:IsPasswordValid>
    <User:AssociateId xsi:type="xsd:int">0</User:AssociateId>
    <User:Type xsi:type="User:UserType">Unknown</User:Type>
    <User:PersonId xsi:type="xsd:int">0</User:PersonId>
    <User:Password xsi:type="xsd:string"></User:Password>
   </User:IsPasswordValid>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## IsPasswordValid Response

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
  <User:IsPasswordValidResponse>
   <User:Response xsi:type="xsd:boolean">false</User:Response>
  </User:IsPasswordValidResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

