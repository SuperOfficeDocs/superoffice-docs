---
title: FCK Editor
uid: blogic_fck_editor
description: FCK Editor
author:
so.date:
keywords:
so.topic: reference
---

# FCK Editor

This element allows you to create HTML-formatted messages. You can insert images, tables, paragraphs, and so on.

Consider using the newer [CK editor][1].

Learn more:

* See the [FCK editor user guide][2] for how to work with this editor.
* See the [FCK editor API reference][3] for available config values.

## Configuration

| Setting               | Default | Description                                               |
|:----------------------|:--------|:----------------------------------------------------------|
| label                 |         | UI label                                                  |
| FCKConfig             |         | Passes config values to the editor                        |
| actionType            |         | 0 = new request<br>1 = add message<br> 2 = edit request |
| valueId               |         | Whether ticket ID is set to entry ID (Bool)               |
| verticalSpace         |         | Must be set to *rest* for the editor to fill the screen vertically |
| contactRecipientsName |         | The name of the contact-recipients elements.<br>Ensure that parser variables in reply templates use the customer selected with the radio button. |
| showInsertText        | true    | Whether to show the control for inserting reply templates, FAQ entries, or previous messages below the editor |
| width                 | 100%    |                                                           |
| height                | 100%    |                                                           |
| plainText             | false   | Whether to shows a simple textarea with no options        |
| notEmpty              |         |                                                           |
| toolbar               |         |                                                           |

> [!NOTE]
> Browsers that don't support the FCK editor (Opera) must have `plaintext = true`.

### Vertical space

For the editor to fill out the screen vertically, the config variable **verticalSpace = rest** must be set.

If the editor is inside a pane, the `Panes` element must also have this config variable.

## Functions

### getFieldValue(String field)

| Field         | Description                                  |
|:--------------|:---------------------------------------------|
| attachmentIds | IDs of attachments as a comma-separated list |
| plainText     | Whether the editor runs in plain-text mode   |

### setValue(String value)

Sets the content of the editor to value.

### setFieldValue(String action, Map values)

| Action                 | Map keys               | Description   |
|:-----------------------|:-----------------------|:--------------|
| config                 |                        | Semicolon-separated config values for the editor<br>Will overwrite existing config! |
| selectInsertTextValues | ticketId<br>faqAccess<br>customerId<br>userId<br>attachmentIds | Passes config to element "Select Insert Text". |

**faqAccess:**

* 1 KB_ACCESS_PRIVATE
* 2 KB_ACCESS_INTERNAL
* 3 KB_ACCESS_PUBLIC_AUTHENTICATED (default)
* 4 KB_ACCESS_PUBLIC

### toString()

Returns the contents of the editor.

## Nesting

The `FCK editor` element must be inside an `Element table`. Otherwise, it will not fill out the width of the page. This is especially important when the editor is located inside a `Pane` element together with other elements.

**Correct nesting:**

All elements inside the pane are "wrapped" in the element table.

```xml
<ElementTable>
  <Panes>
    <Pane>
      <ElementTable>
        <FCKEditor>
        <ContactAndRecipient>
      <GroupEnd>
    <GroupEnd>
  <GroupEnd>
<GroupEnd>
```

<!-- Referenced links -->
[1]: ck-editor.md
[2]: http://docs.fckeditor.net/FCKeditor_2.x/Users_Guide
[3]: http://docs.fckeditor.net/FCKeditor\_2.x/Developers\_Guide/Configuration/Configuration\_Options
