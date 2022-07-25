<!-- markdownlint-disable-file MD041 -->
###  Access restrictions and mandatory status, if any

|---| |
|---|---|
| 0 | Normal field, no particular restrictions |
| 1 | This field is mandatory |
| 2 | This field is read-only |

Describes the different types of controls that can appear in the Configure connection dialog

| MetadataType | Description |
|---|---|
| 0 | Checkbox widget: Boolean value |
| 1 | Single line textbox |
| 2 | Single line edit field with password characters - input is hidden. |
| 3 | Single line integer number field. |
| 4 | Single line decimal number field. |
| 5 | Dropdown listbox. The list name must be provided. The list items are provided by another interface. The default value should be the list key, not the text of the list item. |
| 6 | Date |
| 99 | Static text - has no input widget associated with it. Can be used for spacing/layout. |
