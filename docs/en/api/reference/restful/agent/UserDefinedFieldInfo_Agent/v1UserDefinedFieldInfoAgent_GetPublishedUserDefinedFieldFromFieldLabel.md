---
title: POST Agents/UserDefinedFieldInfo/GetPublishedUserDefinedFieldFromFieldLabel
uid: v1UserDefinedFieldInfoAgent_GetPublishedUserDefinedFieldFromFieldLabel
generated: true
---

# POST Agents/UserDefinedFieldInfo/GetPublishedUserDefinedFieldFromFieldLabel

```http
POST /api/v1/Agents/UserDefinedFieldInfo/GetPublishedUserDefinedFieldFromFieldLabel
```

Return information about the given user defined field identified by the owner and the field label.


Note that field labels are fuzzy. Leading and trailing spaces and punctuation are ignored.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/UserDefinedFieldInfo/GetPublishedUserDefinedFieldFromFieldLabel?$select=name,department,category/id
```


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

## Request Body: request 

FieldLabel, OwnerType 

| Property Name | Type |  Description |
|----------------|------|--------------|
| FieldLabel | String |  |
| OwnerType | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: UserDefinedFieldInfo

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
POST /api/v1/Agents/UserDefinedFieldInfo/GetPublishedUserDefinedFieldFromFieldLabel
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "FieldLabel": "molestiae",
  "OwnerType": "Appointment"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "UDefFieldId": 682,
  "ColumnId": 907,
  "FieldDefault": "omnis",
  "FieldHeight": 132,
  "FieldLabel": "voluptatem",
  "FieldLeft": 664,
  "FieldTop": 90,
  "FieldType": "Checkbox",
  "FieldWidth": 348,
  "FormatMask": "quia",
  "HideLabel": false,
  "IsIndexed": true,
  "LabelHeight": 128,
  "LabelLeft": 666,
  "LabelTop": 978,
  "LabelWidth": 649,
  "LastVersionId": 800,
  "ListTableId": 957,
  "IsMandatory": false,
  "Type": "Appointment",
  "Page1LineNo": 806,
  "ProgId": "dicta",
  "IsReadOnly": false,
  "ShortLabel": "perferendis",
  "TabOrder": 516,
  "TextLength": 553,
  "Tooltip": "voluptas",
  "UdefIdentity": 767,
  "UDListDefinitionId": 481,
  "Justification": "Center",
  "Version": 378,
  "TemplateVariableName": "Dooley-Block",
  "HasBeenPublished": true,
  "MdoListName": "Simonis, Von and Prohaska",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 239
    }
  }
}
```