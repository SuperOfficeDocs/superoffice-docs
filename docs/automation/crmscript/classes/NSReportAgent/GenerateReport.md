---
title: String GenerateReport(Integer reportId, Integer labelLayoutId, String filename, String language, String p4, NSArchiveRestrictionInfo[] restrictions)
path: /EJScript/Classes/NSReportAgent/Member functions/String GenerateReport(Integer p_0, Integer p_1, String p_2, String p_3, String p_4, NSArchiveRestrictionInfo[] p_5)
intellisense: 1
classref: 1
sortOrder: 6701
keywords: GenerateReport(Integer,Integer,String,String,String,NSArchiveRestrictionInfo[])
---


Generates the report in PDF format



* **reportId:** The id of the report.
* **labelLayoutId:** The id of the labellayout. Use 0 if the report isn't of type label.
* **filename:** Filename of the report.
* **language:** Language to use when generating the report.
* **fileType
\param** p5 restrictions: Use restrictions to provide additional restrictions when generating the report.
* **Returns:** Batch task id, as string. Used to be path to the generated report, but no more.


