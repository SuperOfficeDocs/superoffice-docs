---
title: crmscript_ref_NSReportAgent_ImportReport
description: Integer ImportReport(String report)
intellisense: NSReportAgent.ImportReport
keywords: NSReportAgent,ImportReport
so.topic: reference
---

Takes the input stream and create a report. This stream must be on a valid xml format

**Parameters:**
 - **report** The report to import in a correct xml format

**Returns:** The id of the newly imported report

```crmscript
NSReportAgent agent;
String report;
Integer res = agent.ImportReport(report);
```

