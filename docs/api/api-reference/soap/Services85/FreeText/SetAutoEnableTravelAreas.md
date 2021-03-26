---
uid: services85-freetext-setautoenabletravelareas
title: Services85.FreeTextAgent.SetAutoEnableTravelAreas SOAP
Generated: true
---

# Services85 FreeText SetAutoEnableTravelAreas SOAP

SOAP request and response examples **Remote/Services85/FreeText.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IFreeTextAgent.SetAutoEnableTravelAreas">SuperOffice.Services85.IFreeTextAgent.SetAutoEnableTravelAreas</see> method.

## SetAutoEnableTravelAreas

Automatically enable freetext search for new travel areas? true or false

* **autoEnable:** If true, auto enable

**Returns:** This method has no return value


[WSDL file for Services85/FreeText](../Services85-FreeText.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetAutoEnableTravelAreas Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <FreeText:ApplicationToken>1234567-1234-9876</FreeText:ApplicationToken>
  <FreeText:Credentials>
    <FreeText:Ticket>7T:1234abcxyzExample==</FreeText:Ticket>
  </FreeText:Credentials>
 <SOAP-ENV:Body>
   <FreeText:SetAutoEnableTravelAreas>
    <FreeText:AutoEnable xsi:type="xsd:boolean">false</FreeText:AutoEnable>
   </FreeText:SetAutoEnableTravelAreas>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetAutoEnableTravelAreas Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <FreeText:SetAutoEnableTravelAreasResponse>
  </FreeText:SetAutoEnableTravelAreasResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

