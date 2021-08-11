---
uid: crmscript_ref_NSDocumentAgent_SubstituteMergeDocumentTemplateVariablesEx
title: NSStream SubstituteMergeDocumentTemplateVariablesEx(Integer mergeDocumentId, Integer contactId, Integer personId, Integer projectId, Integer selectionId, Integer appointmentId, Integer documentId, Integer saleId, String[] customTags, String[] customValues)
intellisense: NSDocumentAgent.SubstituteMergeDocumentTemplateVariablesEx
keywords: NSDocumentAgent, SubstituteMergeDocumentTemplateVariablesEx
so.topic: reference
---

# NSStream SubstituteMergeDocumentTemplateVariablesEx(Integer mergeDocumentId, Integer contactId, Integer personId, Integer projectId, Integer selectionId, Integer appointmentId, Integer documentId, Integer saleId, String[] customTags, String[] customValues)

Parse the source document, and replace any template variable tags with their values, based on the provided identifiers.<p/> The source document should be of type MergeDraft. This method also takes a pair of arrays specifying custom tags and their values; these tags will be available during substitution in addition to all the existing tags. Custom values will override values otherwise set.

**Parameters:**
 - **mergeDocumentId** The document id that refers to the binary data (document)
 - **contactId** The contact identifier to use for template substitution
 - **personId** The person identifier to use for template substitution
 - **projectId** The project identifier to use for template substitution
 - **selectionId** The selection identifier to use for template substitution
 - **appointmentId** The appointment identifier to use for template substitution
 - **documentId** The document identifier to use for template substitution
 - **saleId** The sale identifier to use for template substitution
 - **customTags** Array of custom tag names. Each name should have exactly four characters. There should be exactly one value for each tag, i.e., the lengths of the customTags and customValues arrays should be the same.
 - **customValues** Array of values for custom tags. There should be exactly one value for each tag, i.e., the lengths of the customTags and customValues arrays should be the same.

**Returns:** NSStream

```crmscript
NSDocumentAgent agent;
Integer mergeDocumentId;
Integer contactId;
Integer personId;
Integer projectId;
Integer selectionId;
Integer appointmentId;
Integer documentId;
Integer saleId;
String[] customTags;
String[] customValues;
NSStream res = agent.SubstituteMergeDocumentTemplateVariablesEx(mergeDocumentId, contactId, personId, projectId, selectionId, appointmentId, documentId, saleId, customTags, customValues);
```

