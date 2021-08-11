---
uid: crmscript_ref_NSReportAgent_GenerateReport
title: String GenerateReport(Integer reportId, Integer labelLayoutId, String filename, String language, String fileType, NSArchiveRestrictionInfo[] restrictions)
intellisense: NSReportAgent.GenerateReport
keywords: NSReportAgent, GenerateReport
so.topic: reference
---

# String GenerateReport(Integer reportId, Integer labelLayoutId, String filename, String language, String fileType, NSArchiveRestrictionInfo[] restrictions)

Generates the report in PDF format

**Parameters:**
 - **reportId** The id of the report.
 - **labelLayoutId** The id of the labellayout. Use 0 if the report isn't of type label.
 - **filename** Filename of the report.
 - **language** Language to use when generating the report.
 - **fileType** 
 - **restrictions** Use restrictions to provide additional restrictions when generating the report.

**Returns:** String

```crmscript
NSReportAgent agent;
Integer reportId;
Integer labelLayoutId;
String filename;
String language;
String fileType;
NSArchiveRestrictionInfo[] restrictions;
String res = agent.GenerateReport(reportId, labelLayoutId, filename, language, fileType, restrictions);
```

