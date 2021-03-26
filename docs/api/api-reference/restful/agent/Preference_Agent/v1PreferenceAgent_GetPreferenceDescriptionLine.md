---
title: POST Agents/Preference/GetPreferenceDescriptionLine
id: v1PreferenceAgent_GetPreferenceDescriptionLine
---

# POST Agents/Preference/GetPreferenceDescriptionLine

```http
POST /api/v1/Agents/Preference/GetPreferenceDescriptionLine
```

Gets a PreferenceDescriptionLine object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| preferenceDescriptionLineId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Preference/GetPreferenceDescriptionLine?preferenceDescriptionLineId=438
POST /api/v1/Agents/Preference/GetPreferenceDescriptionLine?$select=name,department,category/id
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

Preference description line, contains information about a single item in a preference description list.



Carrier object for PreferenceDescriptionLine.
Services for the PreferenceDescriptionLine Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPreferenceAgent">Preference Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| PrefDescLineId | int32 | Primary key |
| PrefDescId | int32 | Preference description (parent) |
| PrefValue | string | Possible value |
| PrefShowValue | string | Descriptive value, multilang-parsed, to put in list |
| Description | string | Description of preference value, multi-language parsed |
| IsBuiltin | bool | 1 = This row populated and maintained by SuperOffice |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Preference/GetPreferenceDescriptionLine
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PrefDescLineId": 623,
  "PrefDescId": 785,
  "PrefValue": "modi",
  "PrefShowValue": "velit",
  "Description": "Exclusive clear-thinking product",
  "IsBuiltin": false,
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
      "FieldType": "System.Int32",
      "FieldLength": 773
    }
  }
}
```