---
title: NSStream SubstituteMergeDocumentTemplateVariables(Integer documentId, Integer associateId, String[] customTags, String[] customValues)
path: /EJScript/Classes/NSDocumentAgent/Member functions/NSStream SubstituteMergeDocumentTemplateVariables(Integer p_0, Integer p_1, String[] p_2, String[] p_3)
intellisense: 1
classref: 1
sortOrder: 2523
keywords: SubstituteMergeDocumentTemplateVariables(Integer,Integer,String[],String[])
---


Parse the source document, and replace any template variable tags with their values, based on the associate Id.\<p/> The source document should be of type MergeDraft. This method also takes a pair of arrays specifying custom tags and their values; these tags will be available during substitution in addition to all the existing tags. Custom values will override values otherwise set.



* **documentId:** The document id that refers to the binary data (document)
* **associateId:** The associateId used to subsitute tags in the document.
* **customTags:** Array of custom tag names. Each name should have exactly four characters. There should be exactly one value for each tag, i.e., the lengths of the customTags and customValues arrays should be the same.
* **customValues:** Array of values for custom tags. There should be exactly one value for each tag, i.e., the lengths of the customTags and customValues arrays should be the same.
* **Returns:** The document as a Stream


