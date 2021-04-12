---
uid: UsageStats
title: UsageStats
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "UsageStats"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "UsageStats"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.UsageStatsProvider">SuperOffice.CRM.ArchiveLists.UsageStatsProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"usageStats"|[usageStats]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|usageStats\_id|int|UsageStats Id: Db Id of UsageStats row| x |
|dateAndAssocId|int|Date &amp; Associate: Encoded Week number since 2003 and Associate Id| x |
|date| *None* |Date: Stored as number of weeks since 2003 in Hi-Word of usagestats.associate\_id column|  |
|associateId| *None* |Associate id|  |
|functionId|int|Function Id: Function Id is an action identifier e.g. Window Shown, Menu Item Selected| x |
|functionHiWord| *None* |Func Hi-Word: Hight-Word (16 Bit) of FunctionId|  |
|functionLoWord| *None* |Func Lo-Word: Low-Word (16 Bit) of FunctionId|  |
|subId|int|Sub Id: Sub Id is the key context for the action e.g a Window or MenuItem identifier| x |
|uses|int|Use count: Number of times this action was registered for the context identified by the subId key| x |
|subHiWord| *None* |Sub Hi-Word: Hight-Word (16 Bit) of SubId|  |
|SubLoWord| *None* |Sub Lo-Word: Low-Word (16 Bit) of SubId|  |
|subHiByte| *None* |Sub Hi-Byte: Hight-Byte (8 Bit) of SubId's Low Word|  |
|subLoByte| *None* |Sub Lo-Byte: Low-Byte (8 Bit) of SubId's Low Word|  |
|data1|int|Data 1: The Data 1 field is known to contain the encoded Build info of the Win client| x |
|data2|int|Data 2: Currently unused| x |
|data3|int|Data 3: Undefined use...| x |
|data4|int|Data 4: Undefined use...| x |
|data5|int|Data 5: Undefined use...| x |
|version| *None* |File version: Decoded Build info of client version number as Revision.Build|  |

## Sample

```http!
GET /api/v1/archive/UsageStats?$select=functionHiWord,uses
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

