---
uid: services75-partner-getmywebpanels
title: Services75.PartnerAgent.GetMyWebPanels SOAP
Generated: true
---

# Services75 Partner GetMyWebPanels SOAP

SOAP request and response examples **Remote/Services75/Partner.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IPartnerAgent.GetMyWebPanels">SuperOffice.Services75.IPartnerAgent.GetMyWebPanels</see> method.

## GetMyWebPanels

Get all web panels registered by this ApplicationId


**Returns:** Array of PartnerWebPanel entities


[WSDL file for Services75/Partner](../Services75-Partner.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetMyWebPanels Request

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
   <Partner:GetMyWebPanels>
   </Partner:GetMyWebPanels>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetMyWebPanels Response

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
  <Partner:GetMyWebPanelsResponse>
   <Partner:Response xsi:type="Partner:ArrayOfPartnerWebPanel">
    <Partner:PartnerWebPanel xsi:type="Partner:PartnerWebPanel">
     <Partner:Identifier xsi:type="xsd:string"></Partner:Identifier>
     <Partner:DisplayName xsi:type="xsd:string"></Partner:DisplayName>
     <Partner:DisplayDescription xsi:type="xsd:string"></Partner:DisplayDescription>
     <Partner:Url xsi:type="xsd:string"></Partner:Url>
     <Partner:VisibleIn xsi:type="Partner:Navigation">Invisible</Partner:VisibleIn>
     <Partner:UrlEncoding xsi:type="Partner:UrlEncoding">Unknown</Partner:UrlEncoding>
     <Partner:OnSalesMarketingWeb xsi:type="xsd:boolean">false</Partner:OnSalesMarketingWeb>
     <Partner:OnSalesMarketingPocket xsi:type="xsd:boolean">false</Partner:OnSalesMarketingPocket>
     <Partner:IsSuspended xsi:type="xsd:boolean">false</Partner:IsSuspended>
     <Partner:WindowName xsi:type="xsd:string"></Partner:WindowName>
    </Partner:PartnerWebPanel>
   </Partner:Response>
  </Partner:GetMyWebPanelsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

