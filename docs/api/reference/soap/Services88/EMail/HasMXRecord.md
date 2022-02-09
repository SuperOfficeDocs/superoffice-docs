---
title: Services88.EMailAgent.HasMXRecord SOAP
generated: 1
uid: Services88-EMail-HasMXRecord
---

# Services88 EMail HasMXRecord

SOAP request and response examples **Remote/Services88/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IEMailAgent.HasMXRecord">SuperOffice.Services88.IEMailAgent.HasMXRecord</see> method.

## HasMXRecord

Return true if there is one or more MX records in DNS for the given mail domain
<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.

* **mailDomain:** The mail domain to check. Normally this is the part after @ in an email address

**Returns:** True if there is at least one MX record


[WSDL file for Services88/EMail](../Services88-EMail.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## HasMXRecord Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:HasMXRecord>
    <EMail:MailDomain xsi:type="xsd:string"></EMail:MailDomain>
   </EMail:HasMXRecord>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## HasMXRecord Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <EMail:HasMXRecordResponse>
   <EMail:Response xsi:type="xsd:boolean">false</EMail:Response>
  </EMail:HasMXRecordResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

