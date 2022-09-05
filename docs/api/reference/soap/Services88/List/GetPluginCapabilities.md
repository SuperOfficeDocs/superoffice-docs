---
title: Services88.ListAgent.GetPluginCapabilities SOAP
generated: 1
uid: Services88-List-GetPluginCapabilities
---

# Services88 List GetPluginCapabilities

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.GetPluginCapabilities">SuperOffice.Services88.IListAgent.GetPluginCapabilities</see> method.

## GetPluginCapabilities

Get a list of plugin-dependent capabilities for a given document archive plugin.&lt;br/&gt;A standard set of properties is defined in SuperOffice.CRM.Documents.Constants.Capabilities.

* **pluginId:** Numeric document plugin id, corresponding to the document.archiveProvider id or doctmpl.AutoeventId.

**Returns:** Dictionary mapping capability names=values


[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPluginCapabilities Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetPluginCapabilities>
    <List:PluginId xsi:type="xsd:int">0</List:PluginId>
   </List:GetPluginCapabilities>

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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <List:GetPluginCapabilitiesResponse>
   <List:Response xsi:type="List:StringDictionary">
    <List:StringKeyValuePair>
     <List:Key xsi:type="xsd:string"></List:Key>
     <List:Value xsi:type="xsd:string"></List:Value>
    </List:StringKeyValuePair>
   </List:Response>
  </List:GetPluginCapabilitiesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

