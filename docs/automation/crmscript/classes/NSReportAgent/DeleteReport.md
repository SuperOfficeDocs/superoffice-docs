---
title: crmscript_ref_NSReportAgent_DeleteReport
description: Bool DeleteReport(Integer reportId)
intellisense: NSReportAgent.DeleteReport
keywords: NSReportAgent,DeleteReport
so.topic: reference
---

Delete the report with the given id

**Parameters:**
 - **reportId** The id of the report to delete

**Returns:** Delete ok?

```crmscript
NSReportAgent agent;
Integer reportId;
Bool res = agent.DeleteReport(reportId);
```

