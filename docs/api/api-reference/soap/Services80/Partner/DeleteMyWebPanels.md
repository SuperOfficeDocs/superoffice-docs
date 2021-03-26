---
uid: services80-partner-deletemywebpanels
title: Services80.PartnerAgent.DeleteMyWebPanels SOAP
Generated: true
---

# Services80 Partner DeleteMyWebPanels SOAP

SOAP request and response examples **Remote/Services80/Partner.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IPartnerAgent.DeleteMyWebPanels">SuperOffice.Services80.IPartnerAgent.DeleteMyWebPanels</see> method.

## DeleteMyWebPanels

Irrevocably delete all web panels registered by this ApplicationId


**Returns:** This method has no return value


[WSDL file for Services80/Partner](../Services80-Partner.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteMyWebPanels Request

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
   <Partner:DeleteMyWebPanels>
   </Partner:DeleteMyWebPanels>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteMyWebPanels Response

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
  <Partner:DeleteMyWebPanelsResponse>
  </Partner:DeleteMyWebPanelsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

