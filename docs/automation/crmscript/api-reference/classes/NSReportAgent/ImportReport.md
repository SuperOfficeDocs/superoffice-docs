---
uid: crmscript_ref_NSReportAgent_ImportReport
title: Integer ImportReport(String report)
intellisense: NSReportAgent.ImportReport
keywords: NSReportAgent, ImportReport
so.topic: reference
---

# Integer ImportReport(String report)

Takes the input stream and create a report. This stream must be on a valid xml format

**Parameters:**
 - **report** The report to import in a correct xml format

**Returns:** Integer

```crmscript
NSReportAgent agent;
String report;
Integer res = agent.ImportReport(report);
```

