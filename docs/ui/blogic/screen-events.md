---
title: Screen events and hook scripts
uid: screen_events
description: Screen events and hook scripts
author:
so.date:
keywords:
so.topic: concept
---

# Screen events and hook scripts

Screen events represent **steps in the process of loading Service screens** and displaying them to a user. By hooking into 1 of these events, you can do stuff at a specific point during loading. CRMScripts responding to screen events are called **hook scripts**, and they don't require changes to the standard screens.

> [!TIP]
> Triggers are another way to handle events and support both CRM and Service screens.

## Hook scripts

Hook scripts are **event-driven** - they're run because some action took place. Specifically, 1 of the screen events was raised. Hook scripts are sometimes referred to as **event scripts**.

### Include-ID

To ensure that your script is run when you intend to, you must incorporate the event name in the include-ID of the script:

`HtmlPage.SCREEN.EVENT`

For example, *HtmlPage.lang_ticket_editCompany.afterSetFromCgi*.

### When to use a hook script

Hook scripts are useful when you want to tweak a standard SuperOffice Service screen, but [building a custom screen][1] is overkill for your minor modifications.

> [!NOTE]
> Hook scripts are run **every single time a particular screen loads!** Carefully consider the overhead you are introducing.

### When NOT to use a hook script

* You need to [add or remove elements][2] (controls) on the screen
* You need to [change the layout][3] of elements
* You're tailoring SuperOffice CRM

## Screen names and HTML elements

All screens in the system have a **unique name (ID)**, for example, `lang_ticket_editCompany`. It can easily be identified by looking at the source of the page.

You can interact with standard SuperOffice Service screens using [HtmlElement][4] methods. To access an element, call `getHtmlElement()`.

> [!CAUTION]
> The names of screens as well as HTML elements **might change over time**. Stay up to date with UI changes to prevent your scripts from breaking. If you call `getHtmlElement()` with an unknown name, it returns a dummy element not used on that screen.

### Find the screen name

1. Open the page you want to hook into.
2. Select **View source** in your browser.
3. In the source, look for a line starting with *eventName*. This line tells you the unique name of this screen.

For example, *eventName: "HtmlPage.lang_ticket_editCompany"*

### List available elements

To find out which element to get, combine `getNumHtmlElements()` and `getHtmlElementName()`:

1. Create (and save) a script with include-ID `HtmlPage.SCREEN.afterSetFromCgi`.
    * For example, *HtmlPage.lang_ticket_editCompany.afterSetFromCgi*.

2. Load the screen you specified. You should now get a list of all the elements used on the screen (including any hidden elements).

```crmscript
for (Integer i = 0; i < getNumHtmlElements(); i++) {
  printDebug("Element: " + getHtmlElementName(i) + "\r\n");
}
```

> [!TIP]
> Read more about [using printDebug()][5].

## beforeSetFromCgi event

Event to hook into to do stuff **before** all elements on the screen set their values from the CGI-data.

Normally called only for [screens containing forms][6].

**Include-ID:** *HtmlPage.SCREEN.beforeSetFromCgi*

## afterSetFromCgi event

Event to hook into to do stuff **after** all elements on the screen have set their values from the CGI-data.

Normally called only for [screens containing forms][6].

**Include-ID:** *HtmlPage.SCREEN.afterSetFromCgi*

### Set global error messages

You can access the page itself through the **HtmlPage** element and then set global error messages. For example, to avoid posting a form if the values in the elements don't pass your validation.

```crmscript
HtmlElement page = getHtmlElement("HtmlPage");
page.setErrorMessage("This page contains an error");
```

### Validation

This example shows hot to validate the format of a phone number when editing a company. Specifically, we want to make sure that the phone number includes a country code (starts with + or 00).

```crmscript
HtmlElement page = getHtmlElement("HtmlPage");
String phone = getHtmlElement("phone").toString();

if (phone != "" && phone.beginsWith("+") == false && phone.beginsWith("00") == false) {
  page.setErrorMessage("Phone numbers must have an international prefix");
}
```

## beforePrint event

Event to hook into to do stuff **just before a screen is printed** (displayed). For example, to deny access based on a condition.

Works for screens both with and without forms.

**Include-ID:** *HtmlPage.SCREEN.beforePrint*

### Denying access to a screen

```crmscript
if (getVariable("activeUser") != "42") {
  exitWithMessage("This page is only available to the oracle");
}
```

### Activate a specific tab

This example shows how to activate a tab on the ticket screen.

```crmscript
String activeTab = getCgiVariable("activePane");

if (activeTab.toInteger() > 0) {
  HtmlElement panes = getHtmlElement("panes");
  panes.setFieldValue("selected", Map("pane = " + activeTab));
}
```

This lets you go to the standard screen with `&action=viewTableEntry&table=ticket&id=123&activePane=2`.

<!-- Referenced links -->
[1]: custom-screens/index.md
[2]: custom-screens/add-screen-element.md
[3]: custom-screens/layout-elements.md
[4]: <xref:CRMScript.Native.HtmlElement>
[5]: ../../../crmscript/docs/debugging/print-debug.md
[6]: custom-screens/form-elements.md
