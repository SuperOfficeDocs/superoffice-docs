---
title: crmscript_ref_NSDocumentAgent_SubstituteMergeDocumentTemplateVariablesEx_Integer_p_0_Integer_p_1_Integer_p_2_Integer_p_3_Integer_p_4_Integer_p_5_Integer_p_6_Integer_p_7_String__p_8_String__p_9
description: NSDocumentAgent.SubstituteMergeDocumentTemplateVariablesEx(Integer p_0, Integer p_1, Integer p_2, Integer p_3, Integer p_4, Integer p_5, Integer p_6, Integer p_7, String[] p_8, String[] p_9)
intellisense: NSDocumentAgent.SubstituteMergeDocumentTemplateVariablesEx
sortOrder: 2525
keywords: SubstituteMergeDocumentTemplateVariablesEx(Integer,Integer,Integer,Integer,Integer,Integer,Integer,Integer,String[],String[])
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
* **customTags:** Array of custom tag names. Each name should have exactly four characters. There should be exactly one value for each tag, i.e., the lengths of the customTags and customValues arrays should be the same.
* **customValues:** Array of values for custom tags. There should be exactly one value for each tag, i.e., the lengths of the customTags and customValues arrays should be the same.
* **Returns:** The document as a Stream


