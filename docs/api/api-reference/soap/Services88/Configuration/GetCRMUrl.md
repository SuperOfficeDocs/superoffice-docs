---
uid: services88-configuration-getcrmurl
title: Services88.ConfigurationAgent.GetCRMUrl SOAP
Generated: true
---

# Services88 Configuration GetCRMUrl SOAP

SOAP request and response examples **Remote/Services88/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IConfigurationAgent.GetCRMUrl">SuperOffice.Services88.IConfigurationAgent.GetCRMUrl</see> method.

## GetCRMUrl

Returns a valid url based in the soprotocol provided

* **soProtocol:** SoProtocol to display. Eg. contact.activityarchive.minipreview
* **currents:** currents to set. Eg. contact\_id=100&amp;person\_id=299
* **frameless:** If true frame is not rendered( Navigationbar, buttonbar and menu )

**Returns:** Url with soprotocol


[WSDL file for Services88/Configuration](../Services88-Configuration.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCRMUrl Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:GetCRMUrl>
    <Configuration:SoProtocol xsi:type="xsd:string"></Configuration:SoProtocol>
    <Configuration:Currents xsi:type="xsd:string"></Configuration:Currents>
    <Configuration:Frameless xsi:type="xsd:boolean">false</Configuration:Frameless>
   </Configuration:GetCRMUrl>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCRMUrl Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Configuration:GetCRMUrlResponse>
   <Configuration:Response xsi:type="xsd:string"></Configuration:Response>
  </Configuration:GetCRMUrlResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

