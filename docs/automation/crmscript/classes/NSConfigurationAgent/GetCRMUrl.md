---
title: crmscript_ref_NSConfigurationAgent_GetCRMUrl
description: String GetCRMUrl(String soProtocol, String currents, Bool frameless)
intellisense: NSConfigurationAgent.GetCRMUrl
keywords: NSConfigurationAgent,GetCRMUrl
so.topic: reference
---

Returns a valid url based in the soprotocol provided

**Parameters:**
 - **soProtocol** SoProtocol to display. Eg. contact.activityarchive.minipreview
 - **currents** currents to set. Eg. contact_id=100&person_id=299
 - **frameless** If true frame is not rendered( Navigationbar, buttonbar and menu )

**Returns:** Url with soprotocol

```crmscript
NSConfigurationAgent agent;
String soProtocol;
String currents;
Bool frameless;
String res = agent.GetCRMUrl(soProtocol, currents, frameless);
```

