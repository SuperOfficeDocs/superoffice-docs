---
title: crmscript_htmlelement
description: HtmlElement
author:
so.date:
keywords:
so.topic:
---

# HtmlElement

The CRMScript **HtmlElement** class represents HTML elements in the SuperOffice UI.

## Types

### String getTypeName()

Returns the element type.

> [!TIP]
> Look up specific elements in the [bLogic screen element][1] reference.

### Type conversion

You can convert the value of an `HtmlElement` object to a string, number, or boolean:

* Bool toBool()
* Integer toInteger()
* String toString()

## Values

### Void setFromCgi()

Called when the element should find its values from the CGI variables. Commonly used for [screens containing forms][3].

### String getFieldValue(String field)

Returns the value of a specific field.

### Void setFieldValue(String name, Map map)

Sets 1 or more field values on an element.

```crmscript
HtmlElement formPage;

Map m;
m.insert("name", "superButton");
m.insert("label", "Click me!");
m.insert("style", "StyleGreen");

formPage.setFieldValue("addButton", m);
```

### Void setValue(String value)

Sets the value of a specific element.

```crmscript
HtmlElement selectDate;
selectDate.setValue("2020.09.10");
```

**Mark a checkbox:**

```crmscript
HtmlElement t;
t.setValue("x_boolean", "1")
```

### Void clearValue()

This will clear any selected values from elements that support this property.

## Messages

### Void setErrorMessage(String errorMessage)

Sets an error message above the element if the form is posted.

Used to inform users that something went wrong and attempt to help them out.

```crmscript
HtmlElement page = getHtmlElement("HtmlPage");
page.setErrorMessage("This page contains an error");
```

### Void setInfoMessage(String infoMessage)

Sets an info message above the element if the form is posted.

Used to display text of a purely informative nature.

## Element properties

### Bool isEmpty()

That an element is **empty** means different things depending on the element type. For example, a list element should be empty if it has no rows, but a code element should be empty if it contains no text.

### Void setDisabled(Bool invisible)

Toggles whether the element is visible or invisible. Commonly used in combination with role-based access.

### Void setNotEditable(Bool canEdit)

Toggles whether the element can be edited (for those elements that support this property). Commonly used in combination with role-based access.

### Integer getNextTabIndex()

The HTML `tabindex` attribute specifies the tab order of an element. It determines the sequence of entering fields with Tab or Shift+Tab.

`getNextTabIndex()` increments the counter and returns the next valid index.

### String getTabIndexString()

Returns the tabulator index string of the element.

### String getTabIndexString(Bool noId)

A variant of `getTabIndexString()` that omits element ID if it is the 1st element.

<!-- Referenced links -->
[1]: blogic-screen-elements/index.md
[2]: custom-screens/form-elements.md
