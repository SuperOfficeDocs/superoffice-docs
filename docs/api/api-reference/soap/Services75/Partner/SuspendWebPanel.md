---
uid: services75-partner-suspendwebpanel
title: Services75.PartnerAgent.SuspendWebPanel SOAP
Generated: true
---

# Services75 Partner SuspendWebPanel SOAP

SOAP request and response examples **Remote/Services75/Partner.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IPartnerAgent.SuspendWebPanel">SuperOffice.Services75.IPartnerAgent.SuspendWebPanel</see> method.

## SuspendWebPanel

The web panel is no longer visible to the users, but all settings are kept

* **identifier:** The string constant used by the Partner Application to identify this web panel

**Returns:** This method has no return value


[WSDL file for Services75/Partner](../Services75-Partner.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SuspendWebPanel Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Partner="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Partner:ApplicationToken>1234567-1234-9876</Partner:ApplicationToken>
  <Partner:Credentials>
    <Partner:Ticket>7T:1234abcxyzExample==</Partner:Ticket>
  </Partner:Credentials>
 <SOAP-ENV:Body>
   <Partner:SuspendWebPanel>
    <Partner:Identifier xsi:type="xsd:string"></Partner:Identifier>
   </Partner:SuspendWebPanel>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SuspendWebPanel Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Partner="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Partner:SuspendWebPanelResponse>
  </Partner:SuspendWebPanelResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

