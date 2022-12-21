---
uid: help-en-document-template-defaults
title: Default values for new document templates
description: Default values for new document templates
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Default values for new document templates

You can specify default values for new document templates if required. For SuperOffice CRM users, this means that the value in the **Our Ref.** field in the **Document** dialog increases by 1 each time this exact template is used. If you do not check **Automatically create new counters for new document templates**, the same counter will be used for all document templates, so that the value in the **Our Ref.** field increases by 1 each time any template is used.

> [!NOTE]
> If the **Our Ref.** field in the **Document** dialog functions as a counter field depends on if the {snum} template variable is specified for the template in question. This is defined in the **Lists** screen > **Document template** by double-clicking the document template under **Items** and editing the **Our reference (default)** field in the **Edit list item** dialog.

## Specify that new document templates will have their own counter

1. Open the **Options** screen.

2. Select the **Number allocation** tab.

3. At the bottom of the tab, select **Automatically create new counters for new document templates**.

4. Click **Defaults**.

5. Check **Unique** if you want the counter values in the **Our Ref**. field to be unique. Useful when SuperOffice CRM users allocate values themselves.

6. Check **Allow blank** to permit empty counter fields. Useful when the counter values must be unique. If **Allow blank** is checked, this means that the requirement for unique values does not apply to empty fields.

7. Check **Read only** if you do not want SuperOffice CRM users to type values into the **Our Ref.** field themselves.

8. Check **Allocate** to use the automatic counter function, so that the system enters values in the **Our Ref.** field for you.

    [See the results of different combinations of these values][1].

9. Enter the value you want the counter to start at in the **Next number** field.

10. Click **Save**.

<!-- Referenced links -->
[1]: index.md

<!-- Referenced images -->
