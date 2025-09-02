---
title: Services88.PreferenceAgent.GetXsrfPaths SOAP
generated: true
uid: Services88-Preference-GetXsrfPaths
content_type: reference
---

# Services88 Preference GetXsrfPaths

SOAP request and response examples **Remote/Services88/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPreferenceAgent.GetXsrfPaths">SuperOffice.Services88.IPreferenceAgent.GetXsrfPaths</see> method.

## GetXsrfPaths





[WSDL file for Services88/Preference](../Services88-Preference.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetXsrfPaths Request

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
   <Preference:GetXsrfPaths>
    <Preference:Hostname xsi:type="xsd:string"></Preference:Hostname>
   </Preference:GetXsrfPaths>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetXsrfPaths Response

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
  <Preference:GetXsrfPathsResponse>
   <Preference:Response xsi:type="NetServerServices882:ArrayOfstring">
    <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
   </Preference:Response>
  </Preference:GetXsrfPathsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

