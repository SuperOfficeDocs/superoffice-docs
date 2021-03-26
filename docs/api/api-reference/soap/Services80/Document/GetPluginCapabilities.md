---
uid: services80-document-getplugincapabilities
title: Services80.DocumentAgent.GetPluginCapabilities SOAP
Generated: true
---

# Services80 Document GetPluginCapabilities SOAP

SOAP request and response examples **Remote/Services80/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IDocumentAgent.GetPluginCapabilities">SuperOffice.Services80.IDocumentAgent.GetPluginCapabilities</see> method.

## GetPluginCapabilities

Get a list of plugin-dependent capabilities for a given document archive plugin.&lt;br/&gt;A standard set of properties is defined in SuperOffice.CRM.Documents.Constants.Capabilities.

* **pluginId:** Numeric document plugin id, corresponding to the document.archiveProvider id or doctmpl.autoeventid.

**Returns:** Dictionary mapping capability names=values


[WSDL file for Services80/Document](../Services80-Document.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPluginCapabilities Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:GetPluginCapabilities>
    <Document:PluginId xsi:type="xsd:int">0</Document:PluginId>
   </Document:GetPluginCapabilities>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPluginCapabilities Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Document:GetPluginCapabilitiesResponse>
   <Document:Response xsi:type="Document:StringDictionary">
    <Document:StringKeyValuePair>
     <Document:Key xsi:type="xsd:string"></Document:Key>
     <Document:Value xsi:type="xsd:string"></Document:Value>
    </Document:StringKeyValuePair>
   </Document:Response>
  </Document:GetPluginCapabilitiesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

