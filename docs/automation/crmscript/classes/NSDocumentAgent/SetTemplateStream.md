---
title: crmscript_ref_NSDocumentAgent_SetTemplateStream
description: Void SetTemplateStream(String filename, Bool personal, Stream stream)
intellisense: NSDocumentAgent.SetTemplateStream
keywords: NSDocumentAgent,SetTemplateStream
so.topic: reference
---

Save a mail signature template to the document archive

**Parameters:**
 - **filename** Filename of template.
 - **personal** If true, save the template in the user area, instead of in shared template area.
 - **stream** The signature template content as a stream.

**Returns:** This method has no return value

```crmscript
NSDocumentAgent agent;
String filename;
Bool personal;
Stream stream;
Void res = agent.SetTemplateStream(filename, personal, stream);
```

