---
title: POST Agents/Preference/SavePreferenceDescriptionLine
uid: v1PreferenceAgent_SavePreferenceDescriptionLine
generated: true
---

# POST Agents/Preference/SavePreferenceDescriptionLine

```http
POST /api/v1/Agents/Preference/SavePreferenceDescriptionLine
```

Updates the existing PreferenceDescriptionLine or creates a new PreferenceDescriptionLine if the id parameter is empty








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

## Request Body: entity 

The PreferenceDescriptionLine to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PrefDescLineId | Integer | Primary key |
| PrefDescId | Integer | Preference description (parent) |
| PrefValue | String | Possible value |
| PrefShowValue | String | Descriptive value, multilang-parsed, to put in list |
| Description | String | Description of preference value, multi-language parsed |
| IsBuiltin | Boolean | 1 = This row populated and maintained by SuperOffice |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PreferenceDescriptionLine

| Property Name | Type |  Description |
|----------------|------|--------------|
| PrefDescLineId | int32 | Primary key |
| PrefDescId | int32 | Preference description (parent) |
| PrefValue | string | Possible value |
| PrefShowValue | string | Descriptive value, multilang-parsed, to put in list |
| Description | string | Description of preference value, multi-language parsed |
| IsBuiltin | bool | 1 = This row populated and maintained by SuperOffice |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Preference/SavePreferenceDescriptionLine
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PrefDescLineId": 307,
  "PrefDescId": 29,
  "PrefValue": "nihil",
  "PrefShowValue": "id",
  "Description": "Digitized client-server monitoring",
  "IsBuiltin": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PrefDescLineId": 147,
  "PrefDescId": 820,
  "PrefValue": "illo",
  "PrefShowValue": "ipsam",
  "Description": "Triple-buffered discrete matrix",
  "IsBuiltin": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 406
    }
  }
}
```