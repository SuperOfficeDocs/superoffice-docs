---
uid: IDashboardAgent-GetDashboardTiles
title: IDashboardAgent.GetDashboardTiles event method
description: Scripting events called on the GetDashboardTiles method on the IDashboardAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IDashboardAgent.GetDashboardTiles

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IDashboardAgent.GetDashboardTiles'>GetDashboardTiles</see> method on the <see cref='IDashboardAgent'>IDashboardAgent</see>  service agent.

## BeforeGetDashboardTiles
```cs
    static void BeforeGetDashboardTiles(
       Int32[]  dashboardTileIds,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterGetDashboardTiles
```cs
    static void AfterGetDashboardTiles(
       Int32[]  dashboardTileIds,
       ref DashboardTile[]  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterGetDashboardTilesAsync
```cs
    static void AfterGetDashboardTilesAsync(
       Int32[]  dashboardTileIds,
       ref DashboardTile[]  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

