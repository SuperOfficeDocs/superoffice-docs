---
title: PUT Project/UdefLayout
uid: v1ProjectEntity_SaveUdefLayout
---

# PUT Project/UdefLayout

```http
PUT /api/v1/Project/UdefLayout
```

Save ProjectEntity user-defined field layout.








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
| UDefFieldId | Integer | Primary key |
| ColumnId | Integer | The ID of the database column this field corresponds to |
| FieldDefault | String | Optional default value for String fields |
| FieldHeight | Integer | field height in pixels, 0 = 'enough' (from font) |
| FieldLabel | String | The label (lead text) |
| FieldLeft | Integer | X pixel coordinate of field |
| FieldTop | Integer | Y pixel coordinate of field |
| FieldType | String | Field type: 0 = leadtext only, 1 = Edit, 2 = CheckBox, 3 = dropdown, 4 = listbox |
| FieldWidth | Integer | field width in pixels, 0 = 'enough' (from font) |
| FormatMask | String | Formatting mask, can be whatever the controls understand (currently nothing :-)) |
| HideLabel | Boolean | Hide the label if 1 |
| IsIndexed | Boolean | Is this field indexed? 0 if no, index no. if yes |
| LabelHeight | Integer | label height in pixels, 0 = 'enough' (from font) |
| LabelLeft | Integer | X pixel coordinate of label |
| LabelTop | Integer | Y pixel coordinate of label |
| LabelWidth | Integer | label width in pixels, 0 = 'enough' (from font) |
| LastVersionId | Integer | UDefFieldId this field had in the previous version, 0 = field is new in this version |
| ListTableId | Integer | The table ID of the source table for lists: kTableAssoc, kTableContInt or whatever |
| IsMandatory | Boolean | 0 = no, 1 = yes (field must be filled out) |
| Type | String | ID of owning table (contact, person, project) - this is not the actual tableNumber, rather it's an enum |
| Page1LineNo | Integer | Line no on View Page 1, used if MDO flags are OFF. 0 = this field is not visible on page 1 |
| ProgId | String | Programmatic ID, for use by software that needs to find a particular field. Carried over like udefIdentity across generations. Use a Company.Product.Field format to avoid naming conflicts; the Company name SuperOffice is reserved. |
| IsReadOnly | Boolean | 0 = read/write, 1 = readonly (don't combine with mandatory  8-) ) |
| ShortLabel | String | Short name to be used in Archive headings and on page 1. If blank, the fieldLabel will be used everywhere. |
| TabOrder | Integer | Tab order value, sets the field processing sequence |
| TextLength | Integer | Length (in characters) of a text field, 0 for other types |
| Tooltip | String | Optional tooltip text for this field |
| UdefIdentity | Integer | Unique number used to track field identity across layout changes |
| UDListDefinitionId | Integer | List to use for populating dropdown or listbox |
| Justification | String | Justification - 0 = default, left, right, center |
| Version | Integer | Definition version number; ALL fields get new version whenever layout is updated. |
| TemplateVariableName | String | Template variable name |
| HasBeenPublished | Boolean | Has the udef field been published? |
| MdoListName | String | MDO list name used to populate this list. Derived from UDListDefinitionId and ListTableId. (Read-only) |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/Project/UdefLayout
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "UDefFieldId": 657,
    "ColumnId": 639,
    "FieldDefault": "voluptatum",
    "FieldHeight": 29,
    "FieldLabel": "minus",
    "FieldLeft": 236,
    "FieldTop": 980,
    "FieldType": "Checkbox",
    "FieldWidth": 598,
    "FormatMask": "repellendus",
    "HideLabel": false,
    "IsIndexed": false,
    "LabelHeight": 145,
    "LabelLeft": 102,
    "LabelTop": 827,
    "LabelWidth": 535,
    "LastVersionId": 82,
    "ListTableId": 72,
    "IsMandatory": false,
    "Type": "Appointment",
    "Page1LineNo": 444,
    "ProgId": "dicta",
    "IsReadOnly": true,
    "ShortLabel": "sapiente",
    "TabOrder": 910,
    "TextLength": 653,
    "Tooltip": "laboriosam",
    "UdefIdentity": 976,
    "UDListDefinitionId": 387,
    "Justification": "Center",
    "Version": 219,
    "TemplateVariableName": "Kutch LLC",
    "HasBeenPublished": false,
    "MdoListName": "Adams, Jones and Jakubowski"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "UDefFieldId": 290,
    "ColumnId": 949,
    "FieldDefault": "exercitationem",
    "FieldHeight": 386,
    "FieldLabel": "veritatis",
    "FieldLeft": 743,
    "FieldTop": 256,
    "FieldType": "Checkbox",
    "FieldWidth": 1001,
    "FormatMask": "libero",
    "HideLabel": false,
    "IsIndexed": false,
    "LabelHeight": 684,
    "LabelLeft": 121,
    "LabelTop": 168,
    "LabelWidth": 807,
    "LastVersionId": 755,
    "ListTableId": 219,
    "IsMandatory": true,
    "Type": "Appointment",
    "Page1LineNo": 215,
    "ProgId": "laudantium",
    "IsReadOnly": true,
    "ShortLabel": "molestias",
    "TabOrder": 240,
    "TextLength": 101,
    "Tooltip": "sed",
    "UdefIdentity": 690,
    "UDListDefinitionId": 561,
    "Justification": "Center",
    "Version": 764,
    "TemplateVariableName": "Huels, Morar and Harris",
    "HasBeenPublished": false,
    "MdoListName": "Rippin, Hansen and Barton",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 57
      }
    }
  }
]
```