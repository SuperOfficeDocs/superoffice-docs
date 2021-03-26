---
uid: services75-list-getdocumenttemplateusedinprojectstage
title: Services75.ListAgent.GetDocumentTemplateUsedInProjectStage SOAP
Generated: true
---

# Services75 List GetDocumentTemplateUsedInProjectStage SOAP

SOAP request and response examples **Remote/Services75/List.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IListAgent.GetDocumentTemplateUsedInProjectStage">SuperOffice.Services75.IListAgent.GetDocumentTemplateUsedInProjectStage</see> method.

## GetDocumentTemplateUsedInProjectStage

Get a String array of names in project guide that this template is used in

* **documentTemplateId:** The id of the template

**Returns:** The name of the projectguides that use this template


[WSDL file for Services75/List](../Services75-List.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDocumentTemplateUsedInProjectStage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetDocumentTemplateUsedInProjectStage>
    <List:DocumentTemplateId xsi:type="xsd:int">0</List:DocumentTemplateId>
   </List:GetDocumentTemplateUsedInProjectStage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDocumentTemplateUsedInProjectStage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <List:GetDocumentTemplateUsedInProjectStageResponse>
   <List:Response xsi:type="NetServerServices752:ArrayOfstring">
    <NetServerServices752:string xsi:type="xsd:string"></NetServerServices752:string>
   </List:Response>
  </List:GetDocumentTemplateUsedInProjectStageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

