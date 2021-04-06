---
uid: crmscript_ref_NSPreferenceAgent_GetPreferenceDescriptionLineFromIdAndValue
title: PreferenceDescriptionLine GetPreferenceDescriptionLineFromIdAndValue(Integer prefDescId, String prefValue)
intellisense: NSPreferenceAgent.GetPreferenceDescriptionLineFromIdAndValue
keywords: NSPreferenceAgent, GetPreferenceDescriptionLineFromIdAndValue
so.topic: reference
---

Get a preference description line from a prefDesc_id and a prefValue

**Parameters:**
 - **prefDescId** The id of the preference description this line is connected to
 - **prefValue** The value of the description line to return

**Returns:** The preference description line matching the id and the value

```crmscript
NSPreferenceAgent agent;
Integer prefDescId;
String prefValue;
PreferenceDescriptionLine res = agent.GetPreferenceDescriptionLineFromIdAndValue(prefDescId, prefValue);
```

