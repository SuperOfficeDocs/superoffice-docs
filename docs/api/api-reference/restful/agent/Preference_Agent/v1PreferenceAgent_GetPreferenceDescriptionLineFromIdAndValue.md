---
title: POST Agents/Preference/GetPreferenceDescriptionLineFromIdAndValue
id: v1PreferenceAgent_GetPreferenceDescriptionLineFromIdAndValue
---

# POST Agents/Preference/GetPreferenceDescriptionLineFromIdAndValue

```http
POST /api/v1/Agents/Preference/GetPreferenceDescriptionLineFromIdAndValue
```

Get a preference description line from a prefDesc_id and a prefValue







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Preference/GetPreferenceDescriptionLineFromIdAndValue?$select=name,department,category/id
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

PrefDescId, PrefValue 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PrefDescId | int32 |  |
| PrefValue | string |  |


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
POST /api/v1/Agents/Preference/GetPreferenceDescriptionLineFromIdAndValue
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PrefDescId": 140,
  "PrefValue": "doloribus"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PrefDescLineId": 65,
  "PrefDescId": 781,
  "PrefValue": "a",
  "PrefShowValue": "consectetur",
  "Description": "Implemented actuating success",
  "IsBuiltin": true,
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
      "FieldLength": 475
    }
  }
}
```