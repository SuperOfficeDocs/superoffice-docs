---
uid: listagent-setticketcategoriesforusergroupasync
title: ListAgent.SetTicketCategoriesForUserGroupAsync event method
description: Scripting events called on the SetTicketCategoriesForUserGroupAsync method on the ListAgent service agent.
generated: true
keywords: netserver scripting
content_type: reference
envir: onsite
---
# ListAgent.SetTicketCategoriesForUserGroupAsync

Scripting events called on the <see cref='M:IListAgent.SetTicketCategoriesForUserGroupAsync'>SetTicketCategoriesForUserGroupAsync</see> method on the <see cref='IListAgent'>IListAgent</see>  service agent.

## BeforeSetTicketCategoriesForUserGroupAsync
```cs
    static void BeforeSetTicketCategoriesForUserGroupAsync(
       Int32  userGroupId,
       Int32[]  categoryIds,
       CancellationToken  cancellationToken,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSetTicketCategoriesForUserGroupAsync
```cs
    static void AfterSetTicketCategoriesForUserGroupAsync(
       Int32  userGroupId,
       Int32[]  categoryIds,
       CancellationToken  cancellationToken,
       ref Task  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSetTicketCategoriesForUserGroupAsyncAsync
```cs
    static void AfterSetTicketCategoriesForUserGroupAsyncAsync(
       Int32  userGroupId,
       Int32[]  categoryIds,
       CancellationToken  cancellationToken,
       ref Task  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

