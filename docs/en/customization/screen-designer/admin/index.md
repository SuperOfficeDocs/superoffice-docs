---
uid: help-en-screen-designer
title: Screen designer
description: Learn how to configure your screens and dialogs in this how-to guide.
keywords: Screen designer, layout, UI, screen, customization, configurable screen
author: digitaldiina
date: 11.20.2025
version: 11.6
content_type: concept
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: en
index: true
redirect_from:
  - /en/customization/screen-designer/index
  - /en/ui/screen-designer/index
  - /en/ui/screen-designer/configurable-screens/index
---

# Screen designer <i class="ph ph-squares-four" aria-hidden="true"></i>

The **Screen Designer** in SuperOffice CRM allows you to customize the layout of key screens within the application, ensuring that the interface meets the specific needs of different user groups in your organization. This feature replaces the old [PageBuilder][9] tool, offering a more streamlined and flexible way to configure screens - without coding.

![Screen designer, company card, default field layout -screenshot][img5]

> [!NOTE]
> This feature requires the Development Tools license and the "Field administrator" functional right.

## Why use the Screen Designer?

SuperOffice CRM comes with default layouts for the Contact, Company, Sale, Project, and Request screens and the Follow-up dialog However, different teams often have different information needs. By using the Screen Designer, you can:

* Create custom layouts tailored to the workflows and priorities of specific user groups (such as sales, support, management).

* Improve efficiency by enabling your teams to quickly access the information that matters most to them.

* Remove unnecessary fields, add new ones, and reorganize information into logical groups using tabs, columns, and labels.

For example, if your sales team focuses on client interactions, you can ensure that contact details are prominently displayed, while less relevant fields are moved to secondary tabs.

## What can i customize?

With the Screen Designer, you can:

* Modify the default layout of screens for all users or create custom layouts for specific user groups.

* Design layouts optimized for specific project types, sale types, request types, follow-up types or document templates.

* Hide fields that are never used.

* Emphasize key data by formatting fields (for example, bold or large font).

* Add custom buttons and links to trigger automated processes (CRMScript) or external lookups.

* Organize custom fields within the **More** tab or other custom tabs.

* Add, rearrange, or remove tabs as needed.

## Which screens can i configure?

You can customize the following screens and dialogs:

* Company
* Contact
* Sale
* Project
* Request
* Follow-up dialog
* Document dialog

## How do layouts work?

Layouts in SuperOffice CRM control how information is displayed to users. The default (system) layouts are applied to all users unless a custom layout is created and assigned to a specific user group.

* **Custom layouts**: Create layouts specific to user groups to meet their unique needs.

* **Layout assignment**: Layouts for the Sales, Project, and Request screens can be further refined by assigning them to specific sale types, project types, and request types, respectively. Similarly, the Follow-up dialog can be assigned to follow-up types and the Document dialog can be assigned to document templates.

* **Layout status**: Layouts can be in a *draft* or *published* state. Published layouts are marked with the assigned user groups.

![Screen Designer draft layout -screenshot][img3]

![Screen Designer published layout -screenshot][img4]

The **Layouts** list displays all existing layouts, including a preview screen.

## Working with the Screen Designer

To start customizing screens:

1. Go to **Settings and maintenance** and select **Screen Designer** from the navigator.
2. Drag and drop fields into the editor to add them to your layout.
3. Click on a field to move it or update its settings. The available settings will depend on the type of field selected.

### Layout components

* **Fields**: Lists all data fields available for the selected screen layout. Use filters to find specific fields quickly.

* **Elements**: Contains non-data elements such as labels, dividers, links, and buttons.

* **Settings**: Allows customization of the appearance and behavior of the selected field.

* **Tab layout**: Provides options to arrange fields and elements in columns.

* **Tabs**: Can be added, rearranged, or deleted to organize information logically.

> [!NOTE]
> After publishing a layout, users in the assigned groups must sign out and back in to see the changes.

## What if I do not use the Screen Designer?

If you do not have the Development Tools license, the **More** tab will automatically organize all custom fields into two columns. This default setup still provides a functional interface but without the advanced customization options available through the Screen Designer.

## Summary

By customizing the screen layouts with the Screen Designer, you can eliminate unnecessary information, making the interface cleaner and more efficient for your teams. For example, if your Support team does not need the company address prominently displayed, you can move it to a secondary tab, freeing up space for more relevant fields.

## Related content

* [Add a layout][2]
* [Edit layout - Main cards][1]
* [Working with fields][4]
* [Working with archives (section tabs)][3]

<!-- Referenced links -->
[1]: edit-layout.md
[2]: add-layout.md
[3]: working-with-archives.md
[4]: working-with-fields.md
[9]: ../../../../en/ui/web-app/pagebuilder/index.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/customization/status-draft.png
[img4]: ../../../../media/loc/en/customization/status-published.png
[img5]: ../../../../media/loc/en/customization/edit-card-layout-fields.png
