---
title: crmscript_ref_NSDocumentAgent_SubstituteTemplateVariables_String_p_0_Integer_p_1_Integer_p_2_Integer_p_3_Integer_p_4_Integer_p_5_Integer_p_6_Integer_p_7_Integer_p_8_String_p_9
description: NSDocumentAgent.SubstituteTemplateVariables(String p_0, Integer p_1, Integer p_2, Integer p_3, Integer p_4, Integer p_5, Integer p_6, Integer p_7, Integer p_8, String p_9)
intellisense: NSDocumentAgent.SubstituteTemplateVariables
sortOrder: 2536
keywords: SubstituteTemplateVariables(String,Integer,Integer,Integer,Integer,Integer,Integer,Integer,Integer,String)
so.topic: reference
---


Parse the source string, and replace any template variable tags with their values, based on the ID's given in the other parameters.



* **source:** Source string to parse for template variables. Such variables must have delimiters corresponding to the standard for the given generator encoding.\<p/>Non-text source data (such as the binary content of a .doc file) should be passed in as Base64.
* **generatorEncoding:** Encoding of source string. Non-text formats such as MsWord or Excel should be Base64 encoded in the source string.
* **contactId:** Identifier for a contact
* **personId:** Identifier for a person
* **appointmentId:** Identifier for an appointment
* **documentId:** Identifier for a document
* **saleId:** Identifier for a sale
* **selectionId:** Identifier for a selection
* **projectId:** Identifier for a project
* **cultureName:** Name of culture to be used for culture-sensitive data, such as dates or multi-language texts. Use a blank string to accept whatever current culture is set on the server (possibly not a good choice in multinational organizations with a single server).
* **Returns:** Source string with templates substituted, using the same encoding as for the source (binary data will be returned in Base64).


