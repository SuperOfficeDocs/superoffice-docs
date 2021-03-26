---
uid: services75-document-substitutetemplatevariableswithcustomtags
title: Services75.DocumentAgent.SubstituteTemplateVariablesWithCustomTags SOAP
Generated: true
---

# Services75 Document SubstituteTemplateVariablesWithCustomTags SOAP

SOAP request and response examples **Remote/Services75/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IDocumentAgent.SubstituteTemplateVariablesWithCustomTags">SuperOffice.Services75.IDocumentAgent.SubstituteTemplateVariablesWithCustomTags</see> method.

## SubstituteTemplateVariablesWithCustomTags

Parse the source string, and replace any template variable tags with their values, based on the ID's given in the other parameters.<p />This method also takes a pair of arrays specifying custom tags and their values; these tags will be available during substitution in addition to all the existing tags. Custom values will override values otherwise set.

* **source:** Source string to parse for template variables. Such variables must have delimiters corresponding to the standard for the given generator encoding.<p />Non-text source data (such as the binary content of a .doc file) should be passed in as Base64.
* **generatorEncoding:** Encoding of source string. Non-text formats such as MsWord or Excel should be Base64 encoded in the source string.
* **customTags:** Array of custom tag names. Each name should have exactly four characters. There should be exactly one value for each tag, i.e., the lengths of the customTags and customValues arrays should be the same.
* **customValues:** Array of values for custom tags. There should be exactly one value for each tag, i.e., the lengths of the customTags and customValues arrays should be the same.
* **contactId:** Identifier for a contact
* **personId:** Identifier for a person
* **appointmentId:** Identifier for an appointment
* **documentId:** Identifier for a document
* **saleId:** Identifier for a sale
* **selectionId:** Identifier for a selection
* **projectId:** Identifier for a project
* **cultureName:** Name of culture to be used for culture-sensitive data, such as dates or multi-language texts. Use a blank string to accept whatever current culture is set on the server (possibly not a good choice in multinational organizations with a single server).

**Returns:** Source string with templates substituted, using the same encoding as for the source (binary data will be returned in Base64).


[WSDL file for Services75/Document](../Services75-Document.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SubstituteTemplateVariablesWithCustomTags Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:SubstituteTemplateVariablesWithCustomTags>
    <Document:Source xsi:type="xsd:string"></Document:Source>
    <Document:GeneratorEncoding xsi:type="Document:GeneratorEncoding">Text</Document:GeneratorEncoding>
    <Document:CustomTags xsi:type="NetServerServices752:ArrayOfstring">
     <NetServerServices752:string xsi:type="xsd:string"></NetServerServices752:string>
    </Document:CustomTags>
    <Document:CustomValues xsi:type="NetServerServices752:ArrayOfstring">
     <NetServerServices752:string xsi:type="xsd:string"></NetServerServices752:string>
    </Document:CustomValues>
    <Document:ContactId xsi:type="xsd:int">0</Document:ContactId>
    <Document:PersonId xsi:type="xsd:int">0</Document:PersonId>
    <Document:AppointmentId xsi:type="xsd:int">0</Document:AppointmentId>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
    <Document:SaleId xsi:type="xsd:int">0</Document:SaleId>
    <Document:SelectionId xsi:type="xsd:int">0</Document:SelectionId>
    <Document:ProjectId xsi:type="xsd:int">0</Document:ProjectId>
    <Document:CultureName xsi:type="xsd:string"></Document:CultureName>
   </Document:SubstituteTemplateVariablesWithCustomTags>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SubstituteTemplateVariablesWithCustomTags Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Document:SubstituteTemplateVariablesWithCustomTagsResponse>
   <Document:Response xsi:type="xsd:string"></Document:Response>
  </Document:SubstituteTemplateVariablesWithCustomTagsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

