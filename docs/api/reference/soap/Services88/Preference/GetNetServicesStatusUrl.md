---
title: Services88.PreferenceAgent.GetNetServicesStatusUrl SOAP
generated: 1
uid: Services88-Preference-GetNetServicesStatusUrl
---

# Services88 Preference GetNetServicesStatusUrl

SOAP request and response examples **Remote/Services88/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPreferenceAgent.GetNetServicesStatusUrl">SuperOffice.Services88.IPreferenceAgent.GetNetServicesStatusUrl</see> method.

## GetNetServicesStatusUrl

Returns URL to status service. e.g. 'https://help.superoffice.com/sodispatcher/v1/status' Returns NULL if status does not need to be checked yet.


**Returns:** NULL or URL of the status service that returns an XML or JSON block.


[WSDL file for Services88/Preference](../Services88-Preference.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNetServicesStatusUrl Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Preference:ApplicationToken>1234567-1234-9876</Preference:ApplicationToken>
  <Preference:Credentials>
    <Preference:Ticket>7T:1234abcxyzExample==</Preference:Ticket>
  </Preference:Credentials>
 <SOAP-ENV:Body>
   <Preference:GetNetServicesStatusUrl>
   </Preference:GetNetServicesStatusUrl>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetNetServicesStatusUrl Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Preference:GetNetServicesStatusUrlResponse>
   <Preference:Response xsi:type="xsd:string"></Preference:Response>
  </Preference:GetNetServicesStatusUrlResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

