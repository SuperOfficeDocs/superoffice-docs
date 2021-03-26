---
uid: services88-freetext-setenabled
title: Services88.FreeTextAgent.SetEnabled SOAP
Generated: true
---

# Services88 FreeText SetEnabled SOAP

SOAP request and response examples **Remote/Services88/FreeText.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IFreeTextAgent.SetEnabled">SuperOffice.Services88.IFreeTextAgent.SetEnabled</see> method.

## SetEnabled

Sets freetext search to enabled (true) or disabled (false)

* **enabled:** If enabled true, else false

**Returns:** This method has no return value


[WSDL file for Services88/FreeText](../Services88-FreeText.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetEnabled Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <FreeText:ApplicationToken>1234567-1234-9876</FreeText:ApplicationToken>
  <FreeText:Credentials>
    <FreeText:Ticket>7T:1234abcxyzExample==</FreeText:Ticket>
  </FreeText:Credentials>
 <SOAP-ENV:Body>
   <FreeText:SetEnabled>
    <FreeText:Enabled xsi:type="xsd:boolean">false</FreeText:Enabled>
   </FreeText:SetEnabled>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetEnabled Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <FreeText:SetEnabledResponse>
  </FreeText:SetEnabledResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

