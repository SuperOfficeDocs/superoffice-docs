---
title: Services86.UserAgent.IsPasswordValidWithReason SOAP
generated: 1
uid: Services86-User-IsPasswordValidWithReason
---

# Services86 User IsPasswordValidWithReason

SOAP request and response examples **Remote/Services86/User.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IUserAgent.IsPasswordValidWithReason">SuperOffice.Services86.IUserAgent.IsPasswordValidWithReason</see> method.

## IsPasswordValidWithReason

<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **associateId:** 
* **type:** 
* **personId:** 
* **password:** 



[WSDL file for Services86/User](../Services86-User.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## IsPasswordValidWithReason Request

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
   <User:IsPasswordValidWithReason>
    <User:AssociateId xsi:type="xsd:int">0</User:AssociateId>
    <User:Type xsi:type="User:UserType">Unknown</User:Type>
    <User:PersonId xsi:type="xsd:int">0</User:PersonId>
    <User:Password xsi:type="xsd:string"></User:Password>
   </User:IsPasswordValidWithReason>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## IsPasswordValidWithReason Response

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
  <User:IsPasswordValidWithReasonResponse>
   <User:Response xsi:type="User:UserValidationResult">
    <User:Reason xsi:type="xsd:string"></User:Reason>
    <User:Result xsi:type="xsd:boolean">false</User:Result>
   </User:Response>
  </User:IsPasswordValidWithReasonResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

