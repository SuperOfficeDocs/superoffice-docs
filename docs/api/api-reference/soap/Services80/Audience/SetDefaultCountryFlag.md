---
uid: services80-audience-setdefaultcountryflag
title: Services80.AudienceAgent.SetDefaultCountryFlag SOAP
Generated: true
---

# Services80 Audience SetDefaultCountryFlag SOAP

SOAP request and response examples **Remote/Services80/Audience.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IAudienceAgent.SetDefaultCountryFlag">SuperOffice.Services80.IAudienceAgent.SetDefaultCountryFlag</see> method.

## SetDefaultCountryFlag

Stores the default country flag image that is displayed in Audience when no person image is found. The image is set on a specific Audience layout instance.

* **layoutName:** Name of the Audience layout instance
* **image:** The default country image to be stored for this Audience layout instance (System.Drawing.Image)



[WSDL file for Services80/Audience](../Services80-Audience.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetDefaultCountryFlag Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Audience:ApplicationToken>1234567-1234-9876</Audience:ApplicationToken>
  <Audience:Credentials>
    <Audience:Ticket>7T:1234abcxyzExample==</Audience:Ticket>
  </Audience:Credentials>
 <SOAP-ENV:Body>
   <Audience:SetDefaultCountryFlag>
    <Audience:LayoutName xsi:type="xsd:string"></Audience:LayoutName>
    <Audience:Image xsi:type="xsd:base64Binary"></Audience:Image>
   </Audience:SetDefaultCountryFlag>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetDefaultCountryFlag Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Audience:SetDefaultCountryFlagResponse>
  </Audience:SetDefaultCountryFlagResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

