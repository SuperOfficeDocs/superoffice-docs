---
uid: services84-document-getpluginlist
title: Services84.DocumentAgent.GetPluginList SOAP
Generated: true
---

# Services84 Document GetPluginList SOAP

SOAP request and response examples **Remote/Services84/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IDocumentAgent.GetPluginList">SuperOffice.Services84.IDocumentAgent.GetPluginList</see> method.

## GetPluginList

Get a list of installed document plugins


**Returns:** Dictionary mapping plugin id=plugin name


[WSDL file for Services84/Document](../Services84-Document.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPluginList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:GetPluginList>
   </Document:GetPluginList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPluginList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Document:GetPluginListResponse>
   <Document:Response xsi:type="Document:StringDictionary">
    <Document:StringKeyValuePair>
     <Document:Key xsi:type="xsd:string"></Document:Key>
     <Document:Value xsi:type="xsd:string"></Document:Value>
    </Document:StringKeyValuePair>
   </Document:Response>
  </Document:GetPluginListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

