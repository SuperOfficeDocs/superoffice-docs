---
title: How to override default save button
uid: pb_tutorial_override_default_save_button
description: This sample discusses overriding the default behavior when clicking a button in the web client.
author: Tony Yates
so.date: 06.19.2009
keywords: pagebuilder
so.topic: tutorial
so.client: web
so.envir: onsite
---

# How to override the default behavior when clicking a button

Sometimes you may want to just override the default functionality of the button events. Here is how to do that for the **Save** button in the **Sale** dialog.

Let's look at the controlgroup that contains the Save button logic. Opening the **Sale** dialog, scroll down to the `DlgButtonBar` controlgroup. I'm going to trim all the fat out of it and focus on the key, and that is the `okonclick` element in the `config` element.

```XML
<control group id="DlgButtonBar" type="OkCancelButtonBar" bottom="10px" height… >
  <datasource>EntityDataHandler.SaleEntity</datasource>
    <controls>
      ...
    </control>
  </controls>
  <config>
    ...
    <okonclick>javascript:Dialog.closeWithCallback();<okonclick>
    ...
  </config>
</controlgroup>
```

Changing this changes the behavior of the save operation. For example, you can, instead of calling the `closeWithCallback` method, you can replace it with your own JavaScript method. However, doing it this way will have unexpected results, i.e. the **Sale** dialog will not close, the archives in the main page will not refresh, and so on.

So, what’s the correct way to do this? Modify the `okonclick` element by adding the callback attribute and setting it to false, and then specify your JavaScript method to call.

```XML
<controlgroup id="DlgButtonBar" type="OkCancelButtonBar" bottom="10px" height="30px" … >
  <datasource>EntityDataHandler.SaleEntity<datasource>
  <controls>
    ...
  <controls>
  <config>
    <okonclick callback="false">yourJSMethod();</okonclick>
    ...
  </config>
</controlgroup>
```

This all depends on your JavaScript method, which you can seed through an `SoScriptControl` (place this before the first control in the first view (SaleCommonView) in the page config:

```XML
<control id="CustomSaleScript" type="SoScriptControl">
  <config>
    <switch value="1" binding="none">
      <case operator="equal" value="1">
      </case>
    </switch>
  </config>
</control>
```

Hope this helps.
