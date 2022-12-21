---
title: POST Agents/Preference/SavePreferenceDescriptionLines
uid: v1PreferenceAgent_SavePreferenceDescriptionLines
---

# POST Agents/Preference/SavePreferenceDescriptionLines

```http
POST /api/v1/Agents/Preference/SavePreferenceDescriptionLines
```

Saves the PreferenceDescriptionLine array in the SuperOffice database







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Preference/SavePreferenceDescriptionLines?$select=name,department,category/id
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

PreferenceDescriptionLines 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PreferenceDescriptionLines | array |  |


## Response: array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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

## Sample request

```http!
POST /api/v1/Agents/Preference/SavePreferenceDescriptionLines
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PreferenceDescriptionLines": [
    {
      "PrefDescLineId": 624,
      "PrefDescId": 422,
      "PrefValue": "cum",
      "PrefShowValue": "officiis",
      "Description": "Fundamental solution-oriented algorithm",
      "IsBuiltin": false
    },
    {
      "PrefDescLineId": 624,
      "PrefDescId": 422,
      "PrefValue": "cum",
      "PrefShowValue": "officiis",
      "Description": "Fundamental solution-oriented algorithm",
      "IsBuiltin": false
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PrefDescLineId": 253,
    "PrefDescId": 644,
    "PrefValue": "odit",
    "PrefShowValue": "aut",
    "Description": "Right-sized uniform matrices",
    "IsBuiltin": false,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 127
      }
    }
  }
]
```