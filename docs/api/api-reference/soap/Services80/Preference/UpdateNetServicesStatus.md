---
uid: services80-preference-updatenetservicesstatus
title: Services80.PreferenceAgent.UpdateNetServicesStatus SOAP
Generated: true
---

# Services80 Preference UpdateNetServicesStatus SOAP

SOAP request and response examples **Remote/Services80/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IPreferenceAgent.UpdateNetServicesStatus">SuperOffice.Services80.IPreferenceAgent.UpdateNetServicesStatus</see> method.

## UpdateNetServicesStatus

Update the NetServices preferences with values contained in the content from the Status URL

* **xml_or_json:** The text that was returned by getting the Status URL

**Returns:** This method has no return value


[WSDL file for Services80/Preference](../Services80-Preference.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## UpdateNetServicesStatus Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Preference:ApplicationToken>1234567-1234-9876</Preference:ApplicationToken>
  <Preference:Credentials>
    <Preference:Ticket>7T:1234abcxyzExample==</Preference:Ticket>
  </Preference:Credentials>
 <SOAP-ENV:Body>
   <Preference:UpdateNetServicesStatus>
    <Preference:XmlOrJson xsi:type="xsd:string"></Preference:XmlOrJson>
   </Preference:UpdateNetServicesStatus>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## UpdateNetServicesStatus Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Preference:UpdateNetServicesStatusResponse>
  </Preference:UpdateNetServicesStatusResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

