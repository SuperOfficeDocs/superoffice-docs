---
title: Services88.ConfigurationAgent.GetCsProgramUrl SOAP
generated: 1
uid: Services88-Configuration-GetCsProgramUrl
---

# Services88 Configuration GetCsProgramUrl

SOAP request and response examples **Remote/Services88/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IConfigurationAgent.GetCsProgramUrl">SuperOffice.Services88.IConfigurationAgent.GetCsProgramUrl</see> method.

## GetCsProgramUrl

This method will convert a module name into a CS URL.

* **language:** By setting this parameter, you can change the CS language for the current user.
* **programName:** In this parameter you must specify which CS program you want to create an URL for. Valid examples are "ticket", "rms", "spm" etc.
* **action:** Here you can optionally specify the action for the current program. This will enable you to go to a specific screen.
* **extraParameters:** If an action is specified, you can specify extra parameters here. This can be used to set specific behaviour for the chosen screen/action. If an empty action is supplied, this parameter will be ignored.

**Returns:** Returns a valid CS URL composed of the give parameters.


[WSDL file for Services88/Configuration](../Services88-Configuration.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCsProgramUrl Request

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
   <Configuration:GetCsProgramUrl>
    <Configuration:Language xsi:type="xsd:string"></Configuration:Language>
    <Configuration:ProgramName xsi:type="xsd:string"></Configuration:ProgramName>
    <Configuration:Action xsi:type="xsd:string"></Configuration:Action>
    <Configuration:ExtraParameters xsi:type="xsd:string"></Configuration:ExtraParameters>
   </Configuration:GetCsProgramUrl>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCsProgramUrl Response

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
  <Configuration:GetCsProgramUrlResponse>
   <Configuration:Response xsi:type="xsd:string"></Configuration:Response>
  </Configuration:GetCsProgramUrlResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

