---
title: custom_ajax_methods
description: Custom AJAX methods
author: Steffan Alte
so.date: 2007
keywords:
so.topic: tutorial
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

* fnCallback:** the client-side Javascript method that is called once the `ajaxMethod` on the server completes, and will be passed the results if there are any, as well as the `socontext` argument.

* **ajaxMethod:** the name of the method you want to call (as for `CallSync`)

* **fnError:** the name of the Javascript function you want to call if an error occurs.

* **fnOnTimeOut:** the name of a Javascript function to call if the call times out.

* **socontext:** a value, if any, that will be passed on to the function defined in `fnCallback`.

## Server-side AJAX method

As with the `CallSync` function, you can add as many arguments as your server-side method requires after the ones from the signature.

You can call any server-side class method using the `AjaxMethodDispatcher`. The only requirement is that the method return must be of type string.

In this article, we will add functionality for creating a follow-up appointment for a sale. Here is the code from the class we will register as an AjaxMethod called `CreateFollowUp` that creates a follow-up based on a sale.

[!code-csharp[CS](includes/class-ajaxdemo.cs)]

After you have registered the class in SuperOffice, you will have access to all its web classes, such as `SuperStateManager`. So, as you can see from the code, we use the SuperStateManager to get the current sale ID. If there is a current sale, the method will create a new appointment for the contact, person, and associate from the sale, with a start date one week from today.

The new appointment is saved using the NetServer Appointment service agent.

The ID of the new appointment is finally returned from the method in a string.

## Register AjaxMethod

Like with all objects and control you want to add to SuperOffice, you will have to register classes that are to be used by the `AjaxMethodDispatcher` in the *SoObjectMapping.config* file.

The object type is *AjaxMethod* and the `MappingName`, `AssemblyName`, and `ObjectName` properties refer to the name you want to reference the object in SuperOffice, the name of the assembly (DLL), and the fully qualified name of the class, respectively.

You also need to set the `xusing_ajaxnet` property to true.

```xml
<object type="AjaxMethod"
        mappingname="AjaxDemo"
        assemblyname="CustomizingSIXwebPart6"
        objectname="CustomizingSIXwebPart6.AjaxDemo"
        xusing_ajaxnet="true"></object>
```

Alternatively, you can use implicit object mapping by decorating the Ajax class with the `SoWebObject` attribute and inheriting the `IWebObject` interface. Read more about [implicit object mapping][1]

## Using AJAX method

When the configuration is done and the class is ready, use the `AjaxMethodDispatcher` from anywhere in the application to invoke the method.

> [!NOTE]
> Make sure the ClientConfigurationProvider/CacheConfigurations key in *web.config* is set to false for any configuration file changes to take effect immediately. If you do not have that set to true, you must restart IIS (do an iisreset) for your changes to take effect and be observed.

Since we wanted to create a follow-up appointment for a sale, we'll add a new button to the Sale page that calls our new server-side method from Javascript.

Here is the declaration of the button in *SoSalePage.config*:

``` xml
<control id="DevNetDemoButton" type="SoButton">
  <caption>Create Follow-Up</caption>
  <config>
    <onclick>Javascript:var appId = AjaxMethodDispatcher.CallSync('CustomizingSIXwebPart6.AjaxDemo.CreateFollowUp'); if (appId > 0) { Dialog.open('appointment''appointment[dialog=stop]?appointment_id='+ appId,''); } else { Dialog.Information('Error', 'Failed to create new appointment', 'error'); }</onclick>
    <width>100</width>
  </config>
</control>
```

The button is of type `SoButton`, the caption can be set to whatever you want, and you can set a whole range of properties in the config section. We are only using the onclick and width properties in this example.

Here you can see the new button added to the **Sale** page;

![Sale dialog][img1]

The Javascript inside the onclick property is what performs the magic here; it uses the CallSync Javascript function of the AjaxMethodDispatcher object to call the CreateFollowUp method of our server-side class.

> [!NOTE]
> You need to supply the fully-qualified name. You cannot use the `MappingName` as supplied in *SoObjectMapping* directly.

The Javascript stores the value returned from the `CallSync` method in a local variable. Depending on that value, either the appointment dialog will be opened with the new appointment, or if the method fails for some reason, an error message will be displayed in a SuperOffice message box.

Here are both results as displayed by the Display Javascript object;

![Sale dialog][img2]

![Sale dialog][img3]

And finally, here's the appointment shown in the activity archive of the contact card;

![Sale dialog][img4]

## Conclusion

In this tutorial, we have gone through how you can call your own server-side classes from Javascript using the `AjaxMethodDispatcher` Javascript object.

The use of the display Javascript object was there mainly to show you more of the Javascript objects that are available to you in SuperOffice.

Take a look inside the Scripts folder of your installation, it's a huge library there ready for you to use and also extend to your own purpose!

If you take a look at for example *Scripts/Dialog.js*, you will find there are a whole set of ways to display message boxes with various sets of buttons and so on.

<!-- Referenced links -->
[1]: ../Page%20Configuration/System%20Configuration%20Files/SoObjectMapping.config.md

<!-- Referenced images -->
[img1]: media/image006.jpg
[img2]: media/image007.jpg
[img3]: media/image008.jpg
[img4]: media/image009.jpg
