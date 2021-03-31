---
title: crmscript_ref_NSDiagnosticsAgent_WebAppUsageExistsInPeriod
description: Bool WebAppUsageExistsInPeriod(Integer associateId, String viewState, DateTime fromDate)
intellisense: NSDiagnosticsAgent.WebAppUsageExistsInPeriod
keywords: NSDiagnosticsAgent,WebAppUsageExistsInPeriod
so.topic: reference
---

Returns true if viewState has been clicked at least once since FromDate, if asscoiateId < 0 or FromDate is DateTime.MinValue no restriction given for those parameters

**Parameters:**
 - **associateId** The asscoiate id to look for webapp usage
 - **viewState** The viewState to search for
 - **fromDate** The datetime to restrict webapp usage on

**Returns:** Returns true if viewState has been clicked at least once since FromDate

```crmscript
NSDiagnosticsAgent agent;
Integer associateId;
String viewState;
DateTime fromDate;
Bool res = agent.WebAppUsageExistsInPeriod(associateId, viewState, fromDate);
```

