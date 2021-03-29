---
title: crmscript_ref_HtmlElement_setErrorMessage_String_errormessage
description: HtmlElement.setErrorMessage(String errormessage)
intellisense: HtmlElement.setErrorMessage
sortOrder: 390
keywords: setErrorMessage(String)
so.topic: reference
---

# Void setErrorMessage(String errorMessage)

Sets an error message above the element if the form is posted.

Used to inform users that something went wrong and attempt to help them out.

```crmscript
HtmlElement page = getHtmlElement("HtmlPage");
page.setErrorMessage("This page contains an error");
```

## Parameters

* String: the error message
