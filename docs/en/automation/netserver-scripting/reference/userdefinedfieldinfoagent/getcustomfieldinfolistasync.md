---
uid: userdefinedfieldinfoagent-getcustomfieldinfolistasync
title: UserDefinedFieldInfoAgent.GetCustomFieldInfoListAsync event method
description: Scripting events called on the GetCustomFieldInfoListAsync method on the UserDefinedFieldInfoAgent service agent.
so.generated: true
keywords: netserver scripting
so.topic: reference
so.envir: onsite
---
# UserDefinedFieldInfoAgent.GetCustomFieldInfoListAsync

Scripting events called on the <see cref='M:IUserDefinedFieldInfoAgent.GetCustomFieldInfoListAsync'>GetCustomFieldInfoListAsync</see> method on the <see cref='IUserDefinedFieldInfoAgent'>IUserDefinedFieldInfoAgent</see>  service agent.

## BeforeGetCustomFieldInfoListAsync
```cs
    static void BeforeGetCustomFieldInfoListAsync(
       String  tableName,
       Boolean  includeStandard,
       CancellationToken  cancellationToken,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterGetCustomFieldInfoListAsync
```cs
    static void AfterGetCustomFieldInfoListAsync(
       String  tableName,
       Boolean  includeStandard,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterGetCustomFieldInfoListAsyncAsync
```cs
    static void AfterGetCustomFieldInfoListAsyncAsync(
       String  tableName,
       Boolean  includeStandard,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

