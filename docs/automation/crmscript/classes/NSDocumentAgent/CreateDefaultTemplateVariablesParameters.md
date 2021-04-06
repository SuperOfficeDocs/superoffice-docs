---
uid: crmscript_ref_NSDocumentAgent_CreateDefaultTemplateVariablesParameters
title: NSTemplateVariablesParameters CreateDefaultTemplateVariablesParameters()
intellisense: NSDocumentAgent.CreateDefaultTemplateVariablesParameters
keywords: NSDocumentAgent, CreateDefaultTemplateVariablesParameters
so.topic: reference
---
	  
Set default values into a new NSTemplateVariablesParameters.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSTemplateVariablesParameters with default values.

```crmscript
NSDocumentAgent agent;
NSTemplateVariablesParameters thing = agent.CreateDefaultTemplateVariablesParameters();
thing = agent.SaveTemplateVariablesParameters(thing);
```

