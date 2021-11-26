---
uid: IDocumentAgent-SubstituteMergeDocumentTemplateVariablesEx2
title: IDocumentAgent.SubstituteMergeDocumentTemplateVariablesEx2 event method
description: Scripting events called on the SubstituteMergeDocumentTemplateVariablesEx2 method on the IDocumentAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IDocumentAgent.SubstituteMergeDocumentTemplateVariablesEx2

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IDocumentAgent.SubstituteMergeDocumentTemplateVariablesEx2'>SubstituteMergeDocumentTemplateVariablesEx2</see> method on the <see cref='IDocumentAgent'>IDocumentAgent</see>  service agent.

## BeforeSubstituteMergeDocumentTemplateVariablesEx2
```cs
    static void BeforeSubstituteMergeDocumentTemplateVariablesEx2(
       Int32  mergeDocumentId,
       Int32  contactId,
       Int32  personId,
       Int32  projectId,
       Int32  selectionId,
       Int32  appointmentId,
       Int32  documentId,
       Int32  saleId,
       StringDictionary  customTags,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSubstituteMergeDocumentTemplateVariablesEx2
```cs
    static void AfterSubstituteMergeDocumentTemplateVariablesEx2(
       Int32  mergeDocumentId,
       Int32  contactId,
       Int32  personId,
       Int32  projectId,
       Int32  selectionId,
       Int32  appointmentId,
       Int32  documentId,
       Int32  saleId,
       StringDictionary  customTags,
       ref Stream  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSubstituteMergeDocumentTemplateVariablesEx2Async
```cs
    static void AfterSubstituteMergeDocumentTemplateVariablesEx2Async(
       Int32  mergeDocumentId,
       Int32  contactId,
       Int32  personId,
       Int32  projectId,
       Int32  selectionId,
       Int32  appointmentId,
       Int32  documentId,
       Int32  saleId,
       StringDictionary  customTags,
       ref Stream  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

