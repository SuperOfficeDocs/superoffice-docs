---
title: POST Appointment/UdefLayout/{progidOrLabel}/ChangeTo/{fieldType}
id: v1AppointmentEntity_ChangeFieldType
---

# POST Appointment/UdefLayout/{progidOrLabel}/ChangeTo/{fieldType}

```http
POST /api/v1/Appointment/UdefLayout/{progidOrLabel}/ChangeTo/{fieldType}
```

Change a AppointmentEntity user-defined field's type based on the prog-id or label.






| Path Part | Type | Description |
|-----------|------|-------------|
| progidOrLabel | string | The udef field id, case-sensitive prog-id, or field label. **Required** |
| fieldType | Enum: Number, ShortText, LongText, Date, UnlimitedDate, Checkbox, List, Decimal | The new type of the user defined field. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| isIndexed | bool |  Should we put data in an indexed column for faster access? Default no |

```http
POST /api/v1/Appointment/UdefLayout/{progidOrLabel}/ChangeTo/{fieldType}?isIndexed=False
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

Return information about the user defined fields. The information can be used to mirror the layout of the user-defined fields in the user interface.



Carrier object for UserDefinedFieldInfo.
Services for the UserDefinedFieldInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserDefinedFieldInfoAgent">UserDefinedFieldInfo Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | AppointmentEntity found. |
| 404 | AppointmentEntity not found. |

Response body: object

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
POST /api/v1/Appointment/UdefLayout/{progidOrLabel}/ChangeTo/{fieldType}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 AppointmentEntity found.
Content-Type: application/json; charset=utf-8

{
  "UDefFieldId": 271,
  "ColumnId": 82,
  "FieldDefault": "ut",
  "FieldHeight": 386,
  "FieldLabel": "doloribus",
  "FieldLeft": 151,
  "FieldTop": 693,
  "FieldType": "Checkbox",
  "FieldWidth": 304,
  "FormatMask": "corporis",
  "HideLabel": true,
  "IsIndexed": false,
  "LabelHeight": 555,
  "LabelLeft": 707,
  "LabelTop": 852,
  "LabelWidth": 212,
  "LastVersionId": 772,
  "ListTableId": 533,
  "IsMandatory": false,
  "Type": "Appointment",
  "Page1LineNo": 202,
  "ProgId": "tempora",
  "IsReadOnly": false,
  "ShortLabel": "blanditiis",
  "TabOrder": 948,
  "TextLength": 110,
  "Tooltip": "hic",
  "UdefIdentity": 658,
  "UDListDefinitionId": 79,
  "Justification": "Center",
  "Version": 426,
  "TemplateVariableName": "Lebsack, Rowe and Williamson",
  "HasBeenPublished": false,
  "MdoListName": "Towne Group",
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
      "FieldLength": 70
    }
  }
}
```