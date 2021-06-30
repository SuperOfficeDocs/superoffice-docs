---
uid: crmscript_class_nscustomerserviceagent_getstatistics
title: StatisticsDataSet[] GetStatistics()
description: CRMScript method in the NSCustomerServiceAgent class that returns the calculated results for the required statistics for the Service Status page
intellisense: NSCustomerServiceAgent.GetStatistics
keywords: NSCustomerServiceAgent, GetStatistics, GetStatistics(NSStatusScreenPanelType[])
so.topic: reference
---

# GetStatistics()

Returns the calculated results for the required statistics for the Customer Service **Status** page.

Returns an array of `StatisticsDataSet`.

`NSCustomerServiceAgent.GetStatistics(NSStatusScreenPanelType[] functions)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| functions | NSStatusScreenPanelType[] | List of functions to calculate and return |

### Functions

| Enum | Function |
|---|---|
| 0 | None |
| 1 | OpenRequestsPerCategory |
| 2 | OpenRequestsPerTopCategory |
| 3 | OpenRequestsPerUser |
| 4 | OpenRequestsPerUserGroup |
| 5 | OpenRequestsPerPriority |
| 6 | OpenRequestsPerStatus |
| 7 | OpenRequestsPerOrigin |
| 11 | NumberOfCreatedRequestsPerDay |
| 12 | NumberOfCreatedRequestsPerWeek |
| 13 | NumberOfCreatedRequestsPerMonth |
| 21 | UserResponseTimePerDay |
| 22 | UserReponseTimePerWeek |
| 23 | UserResponseTimePerMonth |
| 101 | OwnOpenRequests |
| 102 | UnassignedRequests |
| 103 | Hotlist |
| 111 | StatusScreen |

## Examples

```crmscript
NSCustomerServiceAgent agent;
StatusScreenPanelType[] functions;
StatisticsDataSet[] res = agent.GetStatistics(functions);
```
