---
uid: services80-list-getdocumenttemplateproperties
title: Services80.ListAgent.GetDocumentTemplateProperties SOAP
Generated: true
---

# Services80 List GetDocumentTemplateProperties SOAP

SOAP request and response examples **Remote/Services80/List.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IListAgent.GetDocumentTemplateProperties">SuperOffice.Services80.IListAgent.GetDocumentTemplateProperties</see> method.

## GetDocumentTemplateProperties

Get document template properties

* **documentTemplateId:** The primary key id of the document template
* **requestedProperties:** An array of properties to get the values for

**Returns:** Dictionary of key=value pairs of requested properties


[WSDL file for Services80/List](../Services80-List.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDocumentTemplateProperties Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetDocumentTemplateProperties>
    <List:DocumentTemplateId xsi:type="xsd:int">0</List:DocumentTemplateId>
    <List:RequestedProperties xsi:type="NetServerServices802:ArrayOfstring">
     <NetServerServices802:string xsi:type="xsd:string"></NetServerServices802:string>
    </List:RequestedProperties>
   </List:GetDocumentTemplateProperties>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDocumentTemplateProperties Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <List:GetDocumentTemplatePropertiesResponse>
   <List:Response xsi:type="List:StringDictionary">
    <List:StringKeyValuePair>
     <List:Key xsi:type="xsd:string"></List:Key>
     <List:Value xsi:type="xsd:string"></List:Value>
    </List:StringKeyValuePair>
   </List:Response>
  </List:GetDocumentTemplatePropertiesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

