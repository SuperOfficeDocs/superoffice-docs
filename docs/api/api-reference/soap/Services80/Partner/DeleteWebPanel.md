---
uid: services80-partner-deletewebpanel
title: Services80.PartnerAgent.DeleteWebPanel SOAP
Generated: true
---

# Services80 Partner DeleteWebPanel SOAP

SOAP request and response examples **Remote/Services80/Partner.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IPartnerAgent.DeleteWebPanel">SuperOffice.Services80.IPartnerAgent.DeleteWebPanel</see> method.

## DeleteWebPanel

Irrevocably delete all information related to this web panel; no undo

* **identifier:** The string constant used by the Partner Application to identify this web panel

**Returns:** This method has no return value


[WSDL file for Services80/Partner](../Services80-Partner.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteWebPanel Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Partner="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Partner:ApplicationToken>1234567-1234-9876</Partner:ApplicationToken>
  <Partner:Credentials>
    <Partner:Ticket>7T:1234abcxyzExample==</Partner:Ticket>
  </Partner:Credentials>
 <SOAP-ENV:Body>
   <Partner:DeleteWebPanel>
    <Partner:Identifier xsi:type="xsd:string"></Partner:Identifier>
   </Partner:DeleteWebPanel>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteWebPanel Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Partner="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Partner:DeleteWebPanelResponse>
  </Partner:DeleteWebPanelResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

