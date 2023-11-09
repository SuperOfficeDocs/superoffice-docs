---
title: PUT Appointment/UdefLayout
uid: v1AppointmentEntity_SaveUdefLayout
generated: true
---

# PUT Appointment/UdefLayout

```http
PUT /api/v1/Appointment/UdefLayout
```

Save AppointmentEntity user-defined field layout.








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
PUT /api/v1/Appointment/UdefLayout
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "UDefFieldId": 422,
    "ColumnId": 118,
    "FieldDefault": "repellendus",
    "FieldHeight": 930,
    "FieldLabel": "deleniti",
    "FieldLeft": 827,
    "FieldTop": 48,
    "FieldType": "Checkbox",
    "FieldWidth": 103,
    "FormatMask": "provident",
    "HideLabel": true,
    "IsIndexed": true,
    "LabelHeight": 105,
    "LabelLeft": 248,
    "LabelTop": 316,
    "LabelWidth": 181,
    "LastVersionId": 478,
    "ListTableId": 167,
    "IsMandatory": false,
    "Type": "Appointment",
    "Page1LineNo": 757,
    "ProgId": "culpa",
    "IsReadOnly": true,
    "ShortLabel": "magnam",
    "TabOrder": 852,
    "TextLength": 695,
    "Tooltip": "maiores",
    "UdefIdentity": 653,
    "UDListDefinitionId": 851,
    "Justification": "Center",
    "Version": 699,
    "TemplateVariableName": "Schmidt-Hauck",
    "HasBeenPublished": false,
    "MdoListName": "Ratke Group"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "UDefFieldId": 160,
    "ColumnId": 384,
    "FieldDefault": "totam",
    "FieldHeight": 330,
    "FieldLabel": "exercitationem",
    "FieldLeft": 127,
    "FieldTop": 748,
    "FieldType": "Checkbox",
    "FieldWidth": 112,
    "FormatMask": "neque",
    "HideLabel": true,
    "IsIndexed": false,
    "LabelHeight": 547,
    "LabelLeft": 360,
    "LabelTop": 804,
    "LabelWidth": 277,
    "LastVersionId": 536,
    "ListTableId": 503,
    "IsMandatory": true,
    "Type": "Appointment",
    "Page1LineNo": 387,
    "ProgId": "rerum",
    "IsReadOnly": false,
    "ShortLabel": "voluptatem",
    "TabOrder": 977,
    "TextLength": 242,
    "Tooltip": "aspernatur",
    "UdefIdentity": 170,
    "UDListDefinitionId": 846,
    "Justification": "Center",
    "Version": 631,
    "TemplateVariableName": "Franecki Group",
    "HasBeenPublished": false,
    "MdoListName": "Dooley LLC",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 922
      }
    }
  }
]
```