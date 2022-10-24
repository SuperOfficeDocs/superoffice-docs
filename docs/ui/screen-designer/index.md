---
uid: screen-designer
title: Screen designer
description: Introduction to the Screen Designer in Settings and maintenance.
author: Bergfrid Dias
so.date: 10.10.2022
keywords: ui, screen, customization
so.topic: concept
so.version: 10
so.envir:
so.client:
---

# The Screen Designer

[!include[Requirement](../../../common/includes/req-dev-tools.md)]

The **Screen Designer** in Settings and maintenance lets you design layouts that make the most sense in your organization. It replaces [PageBuilder][2] and the old way of customizing the UI - screen by screen.

The **Layouts** list displays any existing screen layouts (usually the default layout), with a preview screen on the right.

* Fields: Lists all available data fields for the selected screen layout. Use the filter function to find specific fields.

* Elements: Lists all non-data screen elements such as labels, dividers, links and, buttons.

* Settings: Lists options to customize the appearance and or settings of the selected field.

* Columns: Lists column layout options to contain fields and elements.

* Tabs: Can be added, rearranged, and deleted.

## Where do I start?

To open the Screen Designer, click ![icon][img1], select **Settings and maintenance**, and then select **Screen Designer** from the navigator.

* Drag and drop field into the editor.
* Select a field to move it, or to update its settings.
* Available settings depend on the selected field type.

Learn more about [working with fields][1]

> [!NOTE]
> After you publish a layout, users in groups assigned to it must sign out of SuperOffice and back in to see the changes.

### Undo changes

Use the **Task** button to revert to an earlier version of the screen.

* **Reset to factory settings:** This option discards all changes and resets the screen layout to the default (system) layout delivered by SuperOffice.

* **Discard draft:** Discards all changes and resets to the published version of the screen layout.

## What if I don't use the Screen Designer?

Without the Development Tools license, the **More** tab shows all custom fields, organized in two columns.

<!-- When a customer publishes their first layout from the Screen Designer, page1 admin is gone. However, this ability is preserved you don't use the designer. -->

<!-- Referenced links -->
[1]: configurable-screens/working-with-fields.md
[2]: ../web-app/pagebuilder/index.md

<!-- Referenced images -->
[img1]:../../../common/icons/mainmenu.png
