---
title: Services88.ContactAgent.UpdateInterests SOAP
generated: true
uid: Services88-Contact-UpdateInterests
content_type: reference
---

# Services88 Contact UpdateInterests

SOAP request and response examples **Remote/Services88/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IContactAgent.UpdateInterests">SuperOffice.Services88.IContactAgent.UpdateInterests</see> method.

## UpdateInterests





[WSDL file for Services88/Contact](../Services88-Contact.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## UpdateInterests Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:UpdateInterests>
    <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
    <Contact:EnableInterestIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Contact:EnableInterestIds>
    <Contact:DisableInterestIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Contact:DisableInterestIds>
   </Contact:UpdateInterests>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## UpdateInterests Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Contact:UpdateInterestsResponse>
  </Contact:UpdateInterestsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

