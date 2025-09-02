---
uid: documentagent-substitutetemplatevariableswithcustomtagsasync
title: DocumentAgent.SubstituteTemplateVariablesWithCustomTagsAsync event method
description: Scripting events called on the SubstituteTemplateVariablesWithCustomTagsAsync method on the DocumentAgent service agent.
generated: true
keywords: netserver scripting
content_type: reference
envir: onsite
---
# DocumentAgent.SubstituteTemplateVariablesWithCustomTagsAsync

Scripting events called on the <see cref='M:IDocumentAgent.SubstituteTemplateVariablesWithCustomTagsAsync'>SubstituteTemplateVariablesWithCustomTagsAsync</see> method on the <see cref='IDocumentAgent'>IDocumentAgent</see>  service agent.

## BeforeSubstituteTemplateVariablesWithCustomTagsAsync
```cs
    static void BeforeSubstituteTemplateVariablesWithCustomTagsAsync(
       String  source,
       GeneratorEncoding  generatorEncoding,
       String[]  customTags,
       String[]  customValues,
       Int32  contactId,
       Int32  personId,
       Int32  appointmentId,
       Int32  documentId,
       Int32  saleId,
       Int32  selectionId,
       Int32  projectId,
       String  cultureName,
       CancellationToken  cancellationToken,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSubstituteTemplateVariablesWithCustomTagsAsync
```cs
    static void AfterSubstituteTemplateVariablesWithCustomTagsAsync(
       String  source,
       GeneratorEncoding  generatorEncoding,
       String[]  customTags,
       String[]  customValues,
       Int32  contactId,
       Int32  personId,
       Int32  appointmentId,
       Int32  documentId,
       Int32  saleId,
       Int32  selectionId,
       Int32  projectId,
       String  cultureName,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSubstituteTemplateVariablesWithCustomTagsAsyncAsync
```cs
    static void AfterSubstituteTemplateVariablesWithCustomTagsAsyncAsync(
       String  source,
       GeneratorEncoding  generatorEncoding,
       String[]  customTags,
       String[]  customValues,
       Int32  contactId,
       Int32  personId,
       Int32  appointmentId,
       Int32  documentId,
       Int32  saleId,
       Int32  selectionId,
       Int32  projectId,
       String  cultureName,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

