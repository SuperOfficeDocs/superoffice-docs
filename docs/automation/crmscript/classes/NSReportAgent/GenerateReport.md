---
title: crmscript_ref_NSReportAgent_GenerateReport
description: String GenerateReport(Integer reportId, Integer labelLayoutId, String filename, String language, String fileType, ArchiveRestrictionInfoArray restrictions)
intellisense: NSReportAgent.GenerateReport
keywords: NSReportAgent,GenerateReport
so.topic: reference
---

Generates the report in PDF format

**Parameters:**
 - **reportId** The id of the report.
 - **labelLayoutId** The id of the labellayout. Use 0 if the report isn't of type label.
 - **filename** Filename of the report.
 - **language** Language to use when generating the report.
 - **fileType** 
 - **restrictions** Use restrictions to provide additional restrictions when generating the report.

**Returns:** Batch task id, as string. Used to be path to the generated report, but no more.

```crmscript
NSReportAgent agent;
Integer reportId;
Integer labelLayoutId;
String filename;
String language;
String fileType;
ArchiveRestrictionInfoArray restrictions;
String res = agent.GenerateReport(reportId, labelLayoutId, filename, language, fileType, restrictions);
```

