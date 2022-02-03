---
title: Services84.DocumentAgent.SubstituteMergeDocumentTemplateVariables SOAP
generated: 1
uid: Services84-Document-SubstituteMergeDocumentTemplateVariables
---

# Services84 Document SubstituteMergeDocumentTemplateVariables

SOAP request and response examples **Remote/Services84/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IDocumentAgent.SubstituteMergeDocumentTemplateVariables">SuperOffice.Services84.IDocumentAgent.SubstituteMergeDocumentTemplateVariables</see> method.

## SubstituteMergeDocumentTemplateVariables

Parse the source document, and replace any template variable tags with their values, based on the associate Id.&lt;p/&gt; The source document should be of type MergeDraft. This method also takes a pair of arrays specifying custom tags and their values; these tags will be available during substitution in addition to all the existing tags. Custom values will override values otherwise set.

* **documentId:** The document id that refers to the binary data (document)
* **associateId:** The associateId used to subsitute tags in the document.
* **customTags:** Array of custom tag names. Each name should have exactly four characters. There should be exactly one value for each tag, i.e., the lengths of the customTags and customValues arrays should be the same.
* **customValues:** Array of values for custom tags. There should be exactly one value for each tag, i.e., the lengths of the customTags and customValues arrays should be the same.

**Returns:** The document as a Stream


[WSDL file for Services84/Document](../Services84-Document.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SubstituteMergeDocumentTemplateVariables Request

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
   <Document:SubstituteMergeDocumentTemplateVariables>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
    <Document:AssociateId xsi:type="xsd:int">0</Document:AssociateId>
    <Document:CustomTags xsi:type="NetServerServices842:ArrayOfstring">
     <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
    </Document:CustomTags>
    <Document:CustomValues xsi:type="NetServerServices842:ArrayOfstring">
     <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
    </Document:CustomValues>
   </Document:SubstituteMergeDocumentTemplateVariables>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SubstituteMergeDocumentTemplateVariables Response

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
  <Document:SubstituteMergeDocumentTemplateVariablesResponse>
   <Document:Response xsi:type="xsd:base64Binary"></Document:Response>
  </Document:SubstituteMergeDocumentTemplateVariablesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

