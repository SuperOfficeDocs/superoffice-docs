---
uid: workflowagent-deleteemailflow
title: WorkflowAgent.DeleteEmailFlow event method
description: Scripting events called on the DeleteEmailFlow method on the WorkflowAgent service agent.
so.generated: true
keywords: netserver scripting
so.topic: reference
so.envir: onsite
---
# WorkflowAgent.DeleteEmailFlow

Scripting events called on the <see cref='M:IWorkflowAgent.DeleteEmailFlow'>DeleteEmailFlow</see> method on the <see cref='IWorkflowAgent'>IWorkflowAgent</see>  service agent.

## BeforeDeleteEmailFlow
```cs
    static void BeforeDeleteEmailFlow(
       Int32  emailFlowId,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterDeleteEmailFlow
```cs
    static void AfterDeleteEmailFlow(
       Int32  emailFlowId,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterDeleteEmailFlowAsync
```cs
    static void AfterDeleteEmailFlowAsync(
       Int32  emailFlowId,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

