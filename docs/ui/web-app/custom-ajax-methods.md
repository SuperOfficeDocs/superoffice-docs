---
title: Custom AJAX methods
uid: custom_ajax_methods
description: Custom AJAX methods
author: Steffan Alte
so.date: 2007
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# Custom AJAX methods

Taking a look at how to call server-side methods both asynchronously and synchronously from client-side Javascript inside SuperOffice

When doing development in a web environment, the whole point is doing operations on the web server without having to post the whole page and get back the whole page from the web server again. The key is to use Javascript for calling business logic on server-side objects asynchronously using remote XML or AJAX.

The web version of SuperOffice uses both asynchronous and synchronous server-side method calls from the client using Javascript. Like with all other objects and controls, you are also able to create your own objects that are to be called using the AJAX methodology.

A Javascript object called `AjaxMethodDispatcher` handles all AJAX method calls from the client. There are two functions in this object that are of interest:

* CallSync
* CallASync

## Synchronous calls

To call a server-side method synchronously, meaning that you want your client-side Javascript to wait until the server-side method returns, you want to use the `CallSync` method of the `AjaxMethodDispatcher` object. This circumvents the purpose or definition of AJAX since the first A in AJAX stands for Asynchronous. But the ability to call server-side methods from the client synchronously without having to do a page post-back is still very useful. And, more importantly, it will improve the end-user experience by providing a more responsive webpage.

The signature for the `CallSync` Javascript function:

```Javascript
_this.CallSync=function(ajaxMethod, fnOnTimeout)
```

An example call using `CallSync`:

```Javascript
AjaxMethodDispatcher.CallSync("SuperOffice.CRM.Web.AjaxMethods.DiaryUpdate.ChangeAppointmentToTask", "",appId,"OnlyThis");
```

* **ajaxMethod:** the fully qualified path to the method name in the assembly you want to call, like for example, `SuperOffice.CRM.Web.AjaxMethods.DiaryUpdate.ChangeAppointmentToTask` from the sample call above.

* **fnOnTimeOut:** the name of a Javascript function to be called if the call times out.

You can add as many arguments as the signature expects, and these are passed to the server-side method. You have to make sure you specify all arguments needed by the server-side method, and that you provide the correct data types for these arguments

## Asynchronous calls

To call asynchronously means your client-side Javascript will continue execution and not wait for the server-side method to finish. This is the way to do actual AJAX calls, meaning that the end-user gains back control over the browser even though the server is performing operations, and will return with any result values whenever it finishes, without the user having to wait for a page to refresh.

The signature for the `CallASync` Javascript function is:

```Javascript
CallASync=function(fnCallback, fnError, fnOnTimeout, socontext, ajaxMethod)
```

* **fnCallback:** the client-side Javascript method that is called once the `ajaxMethod` on the server completes, and will be passed the results if there are any, as well as the `socontext` argument.

* **ajaxMethod:** the name of the method you want to call (as for `CallSync`)

* **fnError:** the name of the Javascript function you want to call if an error occurs.

* **fnOnTimeOut:** the name of a Javascript function to call if the call times out.

* **socontext:** a value, if any, that will be passed on to the function defined in `fnCallback`.

## Server-side AJAX method

As with the `CallSync` function, you can add as many arguments as your server-side method requires after the ones from the signature.

You can call any server-side class method using the `AjaxMethodDispatcher`. The only requirement is that the method return must be of type string.

---

[Go to tutorial][1]

<!-- Referenced links -->
[1]: tutorials/ajax-create-followup/index.md
