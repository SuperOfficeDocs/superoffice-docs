---
title: Services88.ConfigurationAgent.GetAllFeatureToggles SOAP
generated: true
uid: Services88-Configuration-GetAllFeatureToggles
content_type: reference
---

# Services88 Configuration GetAllFeatureToggles

SOAP request and response examples **Remote/Services88/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IConfigurationAgent.GetAllFeatureToggles">SuperOffice.Services88.IConfigurationAgent.GetAllFeatureToggles</see> method.

## GetAllFeatureToggles





[WSDL file for Services88/Configuration](../Services88-Configuration.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAllFeatureToggles Request

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
   <Configuration:GetAllFeatureToggles>
   </Configuration:GetAllFeatureToggles>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAllFeatureToggles Response

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
  <Configuration:GetAllFeatureTogglesResponse>
   <Configuration:Response xsi:type="Configuration:StringBoolDictionary">
    <Configuration:StringBoolKeyValuePair>
     <Configuration:Key xsi:type="xsd:string"></Configuration:Key>
     <Configuration:Value xsi:type="xsd:boolean">false</Configuration:Value>
    </Configuration:StringBoolKeyValuePair>
   </Configuration:Response>
  </Configuration:GetAllFeatureTogglesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

