---
uid: projectagent-updateprojectmembers
title: ProjectAgent.UpdateProjectMembers event method
description: Scripting events called on the UpdateProjectMembers method on the ProjectAgent service agent.
so.generated: true
keywords: netserver scripting
so.topic: reference
so.envir: onsite
---
# ProjectAgent.UpdateProjectMembers

Scripting events called on the <see cref='M:IProjectAgent.UpdateProjectMembers'>UpdateProjectMembers</see> method on the <see cref='IProjectAgent'>IProjectAgent</see>  service agent.

## BeforeUpdateProjectMembers
```cs
    static void BeforeUpdateProjectMembers(
       Int32  projectId,
       ProjectMember[]  projectMembers,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterUpdateProjectMembers
```cs
    static void AfterUpdateProjectMembers(
       Int32  projectId,
       ProjectMember[]  projectMembers,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterUpdateProjectMembersAsync
```cs
    static void AfterUpdateProjectMembersAsync(
       Int32  projectId,
       ProjectMember[]  projectMembers,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

