---
title: crmscript_ref_NSVersionInfo_GetExtraFields
description: StringArray NSVersionInfo.GetExtraFields()
intellisense: NSVersionInfo.GetExtraFields
keywords: NSVersionInfo, GetExtraFields
so.topic: reference
---

Private metadata, owned by the document plugin. This set of metadata is related directly to the version that  this VersioNinfo structure describes; metadata related to the document as a whole is retrieved using the SuperOffice.CRM.Documents.IDocumentPlugin2.LoadMetaData method.  The string should be formatted like a query string, i.e., name1=value1&amp;name2=value2... - this format, instead of a string/string dictionary avoids serialization problems, even though it is somewhat less efficient

**Returns:** StringArray


