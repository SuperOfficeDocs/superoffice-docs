---
title: crmscript_ref_NSDocumentAgent_SubstituteMergeDocumentTemplateVariablesEx2_Integer_p_0_Integer_p_1_Integer_p_2_Integer_p_3_Integer_p_4_Integer_p_5_Integer_p_6_Integer_p_7_StringDictionary_p_8
description: NSDocumentAgent.SubstituteMergeDocumentTemplateVariablesEx2(Integer p_0, Integer p_1, Integer p_2, Integer p_3, Integer p_4, Integer p_5, Integer p_6, Integer p_7, StringDictionary p_8)
intellisense: NSDocumentAgent.SubstituteMergeDocumentTemplateVariablesEx2
sortOrder: 2526
keywords: SubstituteMergeDocumentTemplateVariablesEx2(Integer,Integer,Integer,Integer,Integer,Integer,Integer,Integer,StringDictionary)
so.topic: reference
---


Parse the source document, and replace any template variable tags with their values, based on the provided identifiers.\<p/> The source document should be of type MergeDraft. This method also takes a pair of arrays specifying custom tags and their values; these tags will be available during substitution in addition to all the existing tags. Custom values will override values otherwise set.



* **mergeDocumentId:** The document id that refers to the binary data (document)
* **contactId:** The contact identifier to use for template substitution
* **personId:** The person identifier to use for template substitution
* **projectId:** The project identifier to use for template substitution
* **selectionId:** The selection identifier to use for template substitution
* **appointmentId:** The appointment identifier to use for template substitution
* **documentId:** The document identifier to use for template substitution
* **saleId:** The sale identifier to use for template substitution
* **customTags:** Dictionary of custom tag names and values. Each name should have exactly four characters. There should be exactly one value for each tag
* **Returns:** The document as a Stream


