---
title: ajax_demo
description: Custom AJAX methods - add functionality for creating a follow-up appointment for a sale
author: Steffan Alte
so.date: 2007
keywords:
so.topic: tutorial
so.client: web
so.envir: onsite
---

# AJAX demo

In this tutorial, we will add functionality for creating a follow-up appointment for a sale. Here is the code from the class we will register as an AjaxMethod called `CreateFollowUp` that creates a follow-up based on a sale.

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
[1]: ../../pagebuilder/config/index.md

<!-- Referenced images -->
[img1]: media/image006.jpg
[img2]: media/image007.jpg
[img3]: media/image008.jpg
[img4]: media/image009.jpg
