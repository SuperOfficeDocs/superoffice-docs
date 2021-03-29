---
title: crmscript_ref_NSDocumentAgent_SubstituteTemplateVariablesEx_NSTemplateVariablesParameters_p_0
description: NSDocumentAgent.SubstituteTemplateVariablesEx(NSTemplateVariablesParameters p_0)
intellisense: NSDocumentAgent.SubstituteTemplateVariablesEx
sortOrder: 2537
keywords: SubstituteTemplateVariablesEx(NSTemplateVariablesParameters)
so.topic: reference
---


Parse the source string, and replace any template variable tags with their values, based on the identities, custom values and entities specified in the other parameters.



* **parameters:** Name of culture to be used for culture-sensitive data, such as dates or multi-language texts. Use a blank string to accept whatever current culture is set on the server (possibly not a good choice in multinational organizations with a single server).
* **Returns:** Source string with templates substituted, using the same encoding as for the source (binary data will be returned in Base64).


