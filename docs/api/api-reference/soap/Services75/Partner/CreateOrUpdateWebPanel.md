---
uid: services75-partner-createorupdatewebpanel
title: Services75.PartnerAgent.CreateOrUpdateWebPanel SOAP
Generated: true
---

# Services75 Partner CreateOrUpdateWebPanel SOAP

SOAP request and response examples **Remote/Services75/Partner.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IPartnerAgent.CreateOrUpdateWebPanel">SuperOffice.Services75.IPartnerAgent.CreateOrUpdateWebPanel</see> method.

## CreateOrUpdateWebPanel

Create a web panel in the logged in users' installation of SuperOffice CRM online. The panel will automatically be registered to the currently authenticated ApplicationId.

* **identifier:** The string constant used by the Partner Application to identify this web panel
* **displayName:** The name of the panel as displayed in the GUI; may be multi-language syntax
* **displayDescription:** The tooltip of the panel as displayed in the GUI; may be multi-language syntax
* **url:** The url (target) of the panel; may contain merge tags
* **visibleIn:** Where should the URL appear
* **urlEncoding:** The encoding of the URL
* **onSalesMarketingWeb:** Is the webpanel visible when user is on the SM Web client
* **onSalesMarketingPocket:** Is the webpanel visible when user is on the SM Pocket client

**Returns:** The 'window name' of the panel, which can be used as part of the soprotocol string to navigate to the web panel


[WSDL file for Services75/Partner](../Services75-Partner.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateOrUpdateWebPanel Request

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
   <Partner:CreateOrUpdateWebPanel>
    <Partner:Identifier xsi:type="xsd:string"></Partner:Identifier>
    <Partner:DisplayName xsi:type="xsd:string"></Partner:DisplayName>
    <Partner:DisplayDescription xsi:type="xsd:string"></Partner:DisplayDescription>
    <Partner:Url xsi:type="xsd:string"></Partner:Url>
    <Partner:VisibleIn xsi:type="Partner:Navigation">Invisible</Partner:VisibleIn>
    <Partner:UrlEncoding xsi:type="Partner:UrlEncoding">Unknown</Partner:UrlEncoding>
    <Partner:OnSalesMarketingWeb xsi:type="xsd:boolean">false</Partner:OnSalesMarketingWeb>
    <Partner:OnSalesMarketingPocket xsi:type="xsd:boolean">false</Partner:OnSalesMarketingPocket>
   </Partner:CreateOrUpdateWebPanel>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateOrUpdateWebPanel Response

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
  <Partner:CreateOrUpdateWebPanelResponse>
   <Partner:Response xsi:type="xsd:string"></Partner:Response>
  </Partner:CreateOrUpdateWebPanelResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

