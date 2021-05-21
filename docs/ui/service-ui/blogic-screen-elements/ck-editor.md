---
title: CK editor
uid: blogic_ck_editor
description: CK editor
author:
so.date:
keywords:
so.topic: reference
---

# CK editor

This element allows you to create HTML-formatted messages. You can insert images, tables, paragraphs, and so on.

Learn more:

* See the [CK editor user guide][1] for how to work with this editor.
* See the [CK editor API reference][2] for available config values.

## Configuration

| Setting               | Default | Description                                                        |
|:----------------------|:--------|:-------------------------------------------------------------------|
| label                 |         | UI label                                                           |
| CKConfig              |         | Passes config values to the editor                                 |
| actionType            |         | 0 = new request<br>1 = add message<br> 2 = edit request          |
| valueId               |         | Whether ticket ID is set to entry ID (Bool)                        |
| verticalSpace         |         | Must be set to *rest* for the editor to fill the screen vertically |
| attachmentName        |         | The name of the attachment element                                 |
| contactRecipientsName |         | The name of the contact-recipients elements.<br>Ensure that parser variables in reply templates use the customer selected with the radio button. |
| showInsertText        | true    | Whether to show the control for inserting reply templates, FAQ entries, or previous messages below the editor |
| hasAttachments        | true    | Whether the editor may add attachments                             |
| hasSlevel             | true    | Whether access level may be set for editor entry                   |
| hasTimeSpent          | true    | Whether to shows time spent on editor entry                        |
| noBorder              | true    | Whether to hide the border of the editor.<br>Useful if the editor is in an element table with other elements. |
| plainText             | false   | Whether to shows a simple text area with no options                |

**A word about attachments:**
Naming the attachment element ensures that if `showInsertText` is **true**, the attachments will be shown in an [`Attachments`][3] element.

### Vertical space

For the editor to fill out the screen vertically, the config variable **verticalSpace = rest** must be set.

If the editor is inside a pane, the [`Panes`][4] element must also have this config variable.

## Example

Hide the CK editor toolbar on start-up:

```crmscript
CKConfig.toolbarStartupExpanded = true
```

## Functions

### getFieldValue("plainText")

Returns **true** if the editor has been set up as a plain-text editor.

### setValue(String field)

Sets the content of the editor to value.

### setFieldValue(String action, Map values)

| Action                 | Map keys | Description                                              |
|:-----------------------|:---------|:---------------------------------------------------------|
| selectInsertTextValues |          | Passes config values to the selected insert text element |
| startupFocus           | focus    | Whether to show or hide the toolbar on start-up (Bool)   |

### toString()

Returns the contents of the editor.

## Nesting

The `CK editor` element must be inside an [`Element table`][5]. Otherwise, it will not fill out the width of the page.
This is especially important when the editor is located inside a `Pane` element together with other elements.

**Correct nesting:**

All elements inside the pane are "wrapped" in the element table.

```xml
<ElementTable>
  <Panes>
    <Pane>
      <ElementTable>
        <CKEditor>
        <ContactAndRecipient>
      <GroupEnd>
    <GroupEnd>
  <GroupEnd>
<GroupEnd>
```

<!-- Referenced links -->
[1]: http://docs.cksource.com/CKEditor_3.x/Users_Guide
[2]: http://docs.cksource.com/ckeditor_api/symbols/CKEDITOR.config.html
[3]: attachment.md
[4]: panes.md
[5]: element-table.md
