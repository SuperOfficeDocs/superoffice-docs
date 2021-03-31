---
title: crmscript_ref_NSCustomerServiceAgent_GetStatistics
description: StatisticsDataSetArray GetStatistics(StatusScreenPanelTypeArray functions)
intellisense: NSCustomerServiceAgent.GetStatistics
keywords: NSCustomerServiceAgent,GetStatistics
so.topic: reference
---

Returns the calculated results for the required statistics for the Customer Service Status Page

**Parameters:**
 - **functions** List of functions to calculate and return
     - Enum: 0 = None 
     - Enum: 1 = OpenRequestsPerCategory 
     - Enum: 2 = OpenRequestsPerTopCategory 
     - Enum: 3 = OpenRequestsPerUser 
     - Enum: 4 = OpenRequestsPerUserGroup 
     - Enum: 5 = OpenRequestsPerPriority 
     - Enum: 6 = OpenRequestsPerStatus 
     - Enum: 7 = OpenRequestsPerOrigin 
     - Enum: 11 = NumberOfCreatedRequestsPerDay 
     - Enum: 12 = NumberOfCreatedRequestsPerWeek 
     - Enum: 13 = NumberOfCreatedRequestsPerMonth 
     - Enum: 21 = UserResponseTimePerDay 
     - Enum: 22 = UserReponseTimePerWeek 
     - Enum: 23 = UserResponseTimePerMonth 
     - Enum: 101 = OwnOpenRequests 
     - Enum: 102 = UnassignedRequests 
     - Enum: 103 = Hotlist 
     - Enum: 111 = StatusScreen 

**Returns:** Array of StatisticsDataSet

```crmscript
NSCustomerServiceAgent agent;
StatusScreenPanelTypeArray functions;
StatisticsDataSetArray res = agent.GetStatistics(functions);
```

