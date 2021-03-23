---
uid: AggregationWrapper2
title: AggregationWrapper2
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "AggregationWrapper2"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "AggregationWrapper2"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.Aggregation.AggregationProvider2">SuperOffice.CRM.ArchiveLists.Aggregation.AggregationProvider2</see> inside NetServer's SODatabase assembly.

This is the main aggregation engine for the Archive Provider system - version 2,
with built-in buffering and recursive evaluation

This class is designed to wrap any other archive provider, and introduce
the concepts of grouping and aggregation. Think of it as a report generator
without the layout part + analytics cube engine.

## Supported Entities
| Name | Description |
| ---- | ----- |

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |

## Sample

```http!
GET /api/v1/archive/AggregationWrapper2?$select=
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

