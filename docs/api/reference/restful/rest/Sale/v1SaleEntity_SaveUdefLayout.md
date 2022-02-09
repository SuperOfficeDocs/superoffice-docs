---
title: PUT Sale/UdefLayout
id: v1SaleEntity_SaveUdefLayout
---

# PUT Sale/UdefLayout

```http
PUT /api/v1/Sale/UdefLayout
```

Save SaleEntity user-defined field layout.








## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: fields  

 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UDefFieldId | int32 | Primary key |
| ColumnId | int32 | The ID of the database column this field corresponds to |
| FieldDefault | string | Optional default value for String fields |
| FieldHeight | int32 | field height in pixels, 0 = 'enough' (from font) |
| FieldLabel | string | The label (lead text) |
| FieldLeft | int32 | X pixel coordinate of field |
| FieldTop | int32 | Y pixel coordinate of field |
| FieldType | string | Field type: 0 = leadtext only, 1 = Edit, 2 = CheckBox, 3 = dropdown, 4 = listbox |
| FieldWidth | int32 | field width in pixels, 0 = 'enough' (from font) |
| FormatMask | string | Formatting mask, can be whatever the controls understand (currently nothing :-)) |
| HideLabel | bool | Hide the label if 1 |
| IsIndexed | bool | Is this field indexed? 0 if no, index no. if yes |
| LabelHeight | int32 | label height in pixels, 0 = 'enough' (from font) |
| LabelLeft | int32 | X pixel coordinate of label |
| LabelTop | int32 | Y pixel coordinate of label |
| LabelWidth | int32 | label width in pixels, 0 = 'enough' (from font) |
| LastVersionId | int32 | UDefFieldId this field had in the previous version, 0 = field is new in this version |
| ListTableId | int32 | The table ID of the source table for lists: kTableAssoc, kTableContInt or whatever |
| IsMandatory | bool | 0 = no, 1 = yes (field must be filled out) |
| Type | string | ID of owning table (contact, person, project) - this is not the actual tableNumber, rather it's an enum |
| Page1LineNo | int32 | Line no on View Page 1, used if MDO flags are OFF. 0 = this field is not visible on page 1 |
| ProgId | string | Programmatic ID, for use by software that needs to find a particular field. Carried over like udefIdentity across generations. Use a Company.Product.Field format to avoid naming conflicts; the Company name SuperOffice is reserved. |
| IsReadOnly | bool | 0 = read/write, 1 = readonly (don't combine with mandatory  8-) ) |
| ShortLabel | string | Short name to be used in Archive headings and on page 1. If blank, the fieldLabel will be used everywhere. |
| TabOrder | int32 | Tab order value, sets the field processing sequence |
| TextLength | int32 | Length (in characters) of a text field, 0 for other types |
| Tooltip | string | Optional tooltip text for this field |
| UdefIdentity | int32 | Unique number used to track field identity across layout changes |
| UDListDefinitionId | int32 | List to use for populating dropdown or listbox |
| Justification | string | Justification - 0 = default, left, right, center |
| Version | int32 | Definition version number; ALL fields get new version whenever layout is updated. |
| TemplateVariableName | string | Template variable name |
| HasBeenPublished | bool | Has the udef field been published? |
| MdoListName | string | MDO list name used to populate this list. Derived from UDListDefinitionId and ListTableId. (Read-only) |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| UDefFieldId | int32 | Primary key |
| ColumnId | int32 | The ID of the database column this field corresponds to |
| FieldDefault | string | Optional default value for String fields |
| FieldHeight | int32 | field height in pixels, 0 = 'enough' (from font) |
| FieldLabel | string | The label (lead text) |
| FieldLeft | int32 | X pixel coordinate of field |
| FieldTop | int32 | Y pixel coordinate of field |
| FieldType | string | Field type: 0 = leadtext only, 1 = Edit, 2 = CheckBox, 3 = dropdown, 4 = listbox |
| FieldWidth | int32 | field width in pixels, 0 = 'enough' (from font) |
| FormatMask | string | Formatting mask, can be whatever the controls understand (currently nothing :-)) |
| HideLabel | bool | Hide the label if 1 |
| IsIndexed | bool | Is this field indexed? 0 if no, index no. if yes |
| LabelHeight | int32 | label height in pixels, 0 = 'enough' (from font) |
| LabelLeft | int32 | X pixel coordinate of label |
| LabelTop | int32 | Y pixel coordinate of label |
| LabelWidth | int32 | label width in pixels, 0 = 'enough' (from font) |
| LastVersionId | int32 | UDefFieldId this field had in the previous version, 0 = field is new in this version |
| ListTableId | int32 | The table ID of the source table for lists: kTableAssoc, kTableContInt or whatever |
| IsMandatory | bool | 0 = no, 1 = yes (field must be filled out) |
| Type | string | ID of owning table (contact, person, project) - this is not the actual tableNumber, rather it's an enum |
| Page1LineNo | int32 | Line no on View Page 1, used if MDO flags are OFF. 0 = this field is not visible on page 1 |
| ProgId | string | Programmatic ID, for use by software that needs to find a particular field. Carried over like udefIdentity across generations. Use a Company.Product.Field format to avoid naming conflicts; the Company name SuperOffice is reserved. |
| IsReadOnly | bool | 0 = read/write, 1 = readonly (don't combine with mandatory  8-) ) |
| ShortLabel | string | Short name to be used in Archive headings and on page 1. If blank, the fieldLabel will be used everywhere. |
| TabOrder | int32 | Tab order value, sets the field processing sequence |
| TextLength | int32 | Length (in characters) of a text field, 0 for other types |
| Tooltip | string | Optional tooltip text for this field |
| UdefIdentity | int32 | Unique number used to track field identity across layout changes |
| UDListDefinitionId | int32 | List to use for populating dropdown or listbox |
| Justification | string | Justification - 0 = default, left, right, center |
| Version | int32 | Definition version number; ALL fields get new version whenever layout is updated. |
| TemplateVariableName | string | Template variable name |
| HasBeenPublished | bool | Has the udef field been published? |
| MdoListName | string | MDO list name used to populate this list. Derived from UDListDefinitionId and ListTableId. (Read-only) |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
PUT /api/v1/Sale/UdefLayout
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "UDefFieldId": 432,
    "ColumnId": 323,
    "FieldDefault": "velit",
    "FieldHeight": 191,
    "FieldLabel": "quod",
    "FieldLeft": 478,
    "FieldTop": 941,
    "FieldType": "Checkbox",
    "FieldWidth": 567,
    "FormatMask": "eaque",
    "HideLabel": true,
    "IsIndexed": true,
    "LabelHeight": 486,
    "LabelLeft": 784,
    "LabelTop": 159,
    "LabelWidth": 152,
    "LastVersionId": 118,
    "ListTableId": 768,
    "IsMandatory": true,
    "Type": "Appointment",
    "Page1LineNo": 10,
    "ProgId": "non",
    "IsReadOnly": true,
    "ShortLabel": "cumque",
    "TabOrder": 417,
    "TextLength": 365,
    "Tooltip": "dignissimos",
    "UdefIdentity": 708,
    "UDListDefinitionId": 802,
    "Justification": "Center",
    "Version": 174,
    "TemplateVariableName": "Mayert-Flatley",
    "HasBeenPublished": true,
    "MdoListName": "Mraz, Nader and Lockman"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "UDefFieldId": 112,
    "ColumnId": 99,
    "FieldDefault": "corrupti",
    "FieldHeight": 6,
    "FieldLabel": "officiis",
    "FieldLeft": 437,
    "FieldTop": 955,
    "FieldType": "Checkbox",
    "FieldWidth": 741,
    "FormatMask": "hic",
    "HideLabel": true,
    "IsIndexed": true,
    "LabelHeight": 562,
    "LabelLeft": 345,
    "LabelTop": 248,
    "LabelWidth": 555,
    "LastVersionId": 261,
    "ListTableId": 23,
    "IsMandatory": true,
    "Type": "Appointment",
    "Page1LineNo": 494,
    "ProgId": "amet",
    "IsReadOnly": false,
    "ShortLabel": "sed",
    "TabOrder": 944,
    "TextLength": 380,
    "Tooltip": "quis",
    "UdefIdentity": 396,
    "UDListDefinitionId": 773,
    "Justification": "Center",
    "Version": 970,
    "TemplateVariableName": "Mueller, Schroeder and Kuhlman",
    "HasBeenPublished": true,
    "MdoListName": "Powlowski-Haag",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 27
      }
    }
  }
]
```