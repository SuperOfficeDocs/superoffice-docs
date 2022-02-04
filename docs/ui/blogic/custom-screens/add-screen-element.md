---
title: Add screen element
uid: blogic_add_screen_element
description: Add screen element
author:
so.date:
keywords:
so.topic: howto
---

# Add screen element

**Screen elements** (controls) are the building blocks of custom screens. They determine the [layout][1], display [read-only info][2], and provide [user interaction][3].

**Element properties** are a combination of settings (simple values) and CRMScripts.

## Adding an element

1. Click **New element**.
2. Select an element type and enter element properties.
3. Add config in the **Simple values** tab.
4. Click **Apply**.
5. Select the **Creation script** tab.
6. Set which data to display by extending the script.
7. Click **Apply**.

> [!TIP]
> Click **Apply** after selecting an element type. This adds information the selected element to the **Help** tab.

## Simple values

Most elements have configuration options. These are specific to the different types of elements (for example, title and name).

> [!TIP]
> You can look up available settings for a specific element under the *Configuration* heading in the [element reference][4].

Each option is written as a **key-value** pair in the **Simple values** tab of the element.

```crmscript
key = value
key2 = value2
key3 = value3
```

Each line is interpreted independently of the other lines. You can use our [line-based query syntax][5] to specify values.

> [!NOTE]
> There's **no semicolon or comma at the end** of simple value lines.

Keys are automatically sorted alphabetically when you save an element.

## Body

Many elements have a **body**, which can be quite long. Settings for the element body are set in the **Body** tab, not the **Simple values** tab.

The body is a CRMScript. It can:

* print any HTML to the screen using `print()`
* retrieve any configuration variable using `getVariable()` (v. 4.11)

## Creation scripts

A **creation script** builds the element and populates it with data. It consists of 2 parts:

* An initial call to `addHtmlElement()` - default
* Your extension, which tailors the element and pulls in data

You'll see the default code when you open the **Creation Script** tab of an element.

```crmscript
addHtmlElement(getScreenElementId(screenElementIndex),
  getScreenElementName(screenElementIndex),
  getScreenElementType(screenElementIndex),
  getScreenElementConfig(screenElementIndex));
```

To extend the default code, you'll be using database queries and the functions supported by that element.

It might look something like this:

1. Get a reference to the element by declaring a variable of type [`HtmlElement`][6] and assigning the object returned by `addHtmlElement()`

2. Create a `SearchEngine` object and [specify your query][7].

3. [Run the query][8].

4. [Loop over the result][9]. For each row:
    * Create a [Map][10].
    * Add key-value pairs to the map.
    * Add the map to the element using one of the element's functions.

> [!TIP]
> You can look up available functions for a specific element under the *Functions* heading in the [element reference][4].

<!-- Referenced links -->
[1]: layout-elements.md
[2]: view-elements.md
[3]: form-elements.md
[4]: ../blogic-screen-elements/index.md
[5]: blogic-query-syntax.md
[6]: <xref:CRMScript.Native.HtmlElement>
[7]: ../../../../crmscript/docs/searchengine/se-select.md
[8]: ../../../../crmscript/docs/searchengine/se-run.md
[9]: ../../../../crmscript/docs/searchengine/se-results.md
[10]: ../../../../crmscript/docs/datatypes/map-type.md
