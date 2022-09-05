---
title: Services85.ListAgent.GetDocumentTypesForPlugin SOAP
generated: 1
uid: Services85-List-GetDocumentTypesForPlugin
---

# Services85 List GetDocumentTypesForPlugin

SOAP request and response examples **Remote/Services85/List.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IListAgent.GetDocumentTypesForPlugin">SuperOffice.Services85.IListAgent.GetDocumentTypesForPlugin</see> method.

## GetDocumentTypesForPlugin

Get a list of document types supported by a given document plugin. Use the document template type when creating a new template.

* **pluginId:** Numeric document plugin id, corresponding to the doctmpl.AutoeventId, doctmpl.LoadTemplateFromPlugin.

**Returns:** Dictionary mapping document type id=name


[WSDL file for Services85/List](../Services85-List.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDocumentTypesForPlugin Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetDocumentTypesForPlugin>
    <List:PluginId xsi:type="xsd:int">0</List:PluginId>
   </List:GetDocumentTypesForPlugin>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDocumentTypesForPlugin Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <List:GetDocumentTypesForPluginResponse>
   <List:Response xsi:type="List:IntStringDictionary">
    <List:IntStringKeyValuePair>
     <List:Key xsi:type="xsd:int">0</List:Key>
     <List:Value xsi:type="xsd:string"></List:Value>
    </List:IntStringKeyValuePair>
   </List:Response>
  </List:GetDocumentTypesForPluginResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

