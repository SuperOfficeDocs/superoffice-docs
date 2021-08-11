---
uid: crmscript_ref_NSDocumentAgent_SubstituteMergeDocumentTemplateVariables2
title: NSStream SubstituteMergeDocumentTemplateVariables2(Integer documentId, Integer associateId, StringDictionary customTags)
intellisense: NSDocumentAgent.SubstituteMergeDocumentTemplateVariables2
keywords: NSDocumentAgent, SubstituteMergeDocumentTemplateVariables2
so.topic: reference
---

# NSStream SubstituteMergeDocumentTemplateVariables2(Integer documentId, Integer associateId, StringDictionary customTags)

Parse the source document, and replace any template variable tags with their values, based on the associate Id.<p/> The source document should be of type MergeDraft. This method also takes a pair of arrays specifying custom tags and their values; these tags will be available during substitution in addition to all the existing tags. Custom values will override values otherwise set.

**Parameters:**
 - **documentId** The document id that refers to the binary data (document)
 - **associateId** The associateId used to subsitute tags in the document.
 - **customTags** Dictionary of custom tag names and values. Each name should have exactly four characters. There should be exactly one value for each tag.

**Returns:** NSStream

```crmscript
NSDocumentAgent agent;
Integer documentId;
Integer associateId;
StringDictionary customTags;
NSStream res = agent.SubstituteMergeDocumentTemplateVariables2(documentId, associateId, customTags);
```

