---
uid: crmscript_ref_NSDocumentAgent_SubstituteTemplateVariablesWithCustomTags2
title: String SubstituteTemplateVariablesWithCustomTags2(String source, Integer generatorEncoding, StringDictionary customTags, Integer contactId, Integer personId, Integer appointmentId, Integer documentId, Integer saleId, Integer selectionId, Integer projectId, String cultureName)
intellisense: NSDocumentAgent.SubstituteTemplateVariablesWithCustomTags2
keywords: NSDocumentAgent, SubstituteTemplateVariablesWithCustomTags2
so.topic: reference
---

# String SubstituteTemplateVariablesWithCustomTags2(String source, Integer generatorEncoding, StringDictionary customTags, Integer contactId, Integer personId, Integer appointmentId, Integer documentId, Integer saleId, Integer selectionId, Integer projectId, String cultureName)

Parse the source string, and replace any template variable tags with their values, based on the ID's given in the other parameters.<p/>This method also takes a pair of arrays specifying custom tags and their values; these tags will be available during substitution in addition to all the existing tags. Custom values will override values otherwise set.

**Parameters:**
 - **source** Source string to parse for template variables. Such variables must have delimiters corresponding to the standard for the given generator encoding.<p/>Non-text source data (such as the binary content of a .doc file) should be passed in as Base64.
 - **generatorEncoding** Encoding of source string. Non-text formats such as MsWord or Excel should be Base64 encoded in the source string.
     - Enum: 0 = Text 
     - Enum: 1 = Html 
     - Enum: 2 = Xml 
     - Enum: 3 = MsWord 
     - Enum: 4 = MsExcel 
     - Enum: 5 = MsPowerpoint 
     - Enum: 6 = MsOffice2007 
     - Enum: 7 = MsOffice2007Xml 
     - Enum: 8 = Url 
     - Enum: 9 = UrlUnicode 
     - Enum: 10 = Pdf 
     - Enum: 11 = Mime 
     - Enum: 12 = OpenDocument 
     - Enum: 13 = OpenDocumentXml 
 - **customTags** Dictionary of custom tag names and values. Each name should have exactly four characters. There should be exactly one value for each tag.
 - **contactId** Identifier for a contact
 - **personId** Identifier for a person
 - **appointmentId** Identifier for an appointment
 - **documentId** Identifier for a document
 - **saleId** Identifier for a sale
 - **selectionId** Identifier for a selection
 - **projectId** Identifier for a project
 - **cultureName** Name of culture to be used for culture-sensitive data, such as dates or multi-language texts. Use a blank string to accept whatever current culture is set on the server (possibly not a good choice in multinational organizations with a single server).

**Returns:** String

```crmscript
NSDocumentAgent agent;
String source;
Integer generatorEncoding;
StringDictionary customTags;
Integer contactId;
Integer personId;
Integer appointmentId;
Integer documentId;
Integer saleId;
Integer selectionId;
Integer projectId;
String cultureName;
String res = agent.SubstituteTemplateVariablesWithCustomTags2(source, generatorEncoding, customTags, contactId, personId, appointmentId, documentId, saleId, selectionId, projectId, cultureName);
```

