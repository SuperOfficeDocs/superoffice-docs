---
title: pb_usercontrols_rights
description: Rights system and controls ControlBase
author: Tony Yates
so.date: 06.24.2016
keywords: sentry
so.topic: concept
so.client: web
so.envir: onsite
---

# Rights system

PageBuilder uses the **ControlBase** to define support for sentry rights as well as data-binding rights. The `ControlBase` class is contained in *SuperOfice.Web.UI.Controls* namespace and the base class for all controls used by the PageBuilder. This concept allows controls to be disabled automatically when a field is read-only. Sentry rights are calculated at the lowest level of NetServer and transported up through the web service to the GUI layer.

> [!NOTE]
> [Sentry][1] acts as the watchdog that keeps an eye on all the access to data in the SuperOffice database.

All sub-classes of the `ControlBase` support AJAX callbacks and declarative configuration and layout via the PageBuilder.

## Sentry right

The following example shows how a sentry right can be used.

```XML
<panel id="Contact" type="SplitterPanel" soprotocol="Contact" paneltype="Main" placeholderid="MainPlaceHolder">
  <!--Some other code-->
  <sentry-rights>
    <sentry-right tableright="HasInsert" type="disable">appointment</sentry-right>
  </sentry-rights>
</panel>
```

If the logged-in user doesn’t have the required rights to insert data, the field, button, or any other relevant item is disabled. Also, if a menu item such as a button or drop down list has been blocked by several sentry rights, it is enough that one of them hits.

## Function right

The following example shows how a function right can be used.

```XML
<panel id="Contact" type="SplitterPanel" soprotocol="Contact" paneltype="Main" placeholderid="MainPlaceHolder">
  <!--Some other code-->
  <function-rights>
    <function-right type="hide">hide-sale</function-right>
  </function-rights>
</panel>
```

The function rights are applied to user roles. In the above code, `hide-sale` means that the users belonging to a role that has the functional right *Hidesale* enabled will not be able to see the **Sale** dialog in the GUI.

<!-- Referenced links -->
[1]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/sentry/index.md

<!-- Referenced images -->