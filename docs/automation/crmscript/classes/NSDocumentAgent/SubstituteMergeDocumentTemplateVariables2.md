---
title: crmscript_ref_NSDocumentAgent_SubstituteMergeDocumentTemplateVariables2_Integer_p_0_Integer_p_1_StringDictionary_p_2
description: NSDocumentAgent.SubstituteMergeDocumentTemplateVariables2(Integer p_0, Integer p_1, StringDictionary p_2)
intellisense: NSDocumentAgent.SubstituteMergeDocumentTemplateVariables2
sortOrder: 2524
keywords: SubstituteMergeDocumentTemplateVariables2(Integer,Integer,StringDictionary)
so.topic: reference
---


Parse the source document, and replace any template variable tags with their values, based on the associate Id.\<p/> The source document should be of type MergeDraft. This method also takes a pair of arrays specifying custom tags and their values; these tags will be available during substitution in addition to all the existing tags. Custom values will override values otherwise set.



* **documentId:** The document id that refers to the binary data (document)
* **associateId:** The associateId used to subsitute tags in the document.
* **customTags:** Dictionary of custom tag names and values. Each name should have exactly four characters. There should be exactly one value for each tag.
* **Returns:** The document as a Stream


