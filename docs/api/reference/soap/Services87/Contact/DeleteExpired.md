---
title: Services87.ContactAgent.DeleteExpired SOAP
generated: 1
uid: Services87-Contact-DeleteExpired
---

# Services87 Contact DeleteExpired

SOAP request and response examples **Remote/Services87/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IContactAgent.DeleteExpired">SuperOffice.Services87.IContactAgent.DeleteExpired</see> method.

## DeleteExpired

Trigger deletion of contacts (companies) that has been (soft) deleted and have timed out the expiry period (the SoftDeleteRetention preference).




[WSDL file for Services87/Contact](../Services87-Contact.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteExpired Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:DeleteExpired>
   </Contact:DeleteExpired>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteExpired Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Contact:DeleteExpiredResponse>
  </Contact:DeleteExpiredResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

