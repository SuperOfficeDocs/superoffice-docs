---
title: POST Agents/FreeText/GetStatus
id: v1FreeTextAgent_GetStatus
---

# POST Agents/FreeText/GetStatus

```http
POST /api/v1/Agents/FreeText/GetStatus
```

Returns status for the freetext search words







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/FreeText/GetStatus?$select=name,department,category/id
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

Used to manage freetext search.



Carrier object for FreeText.
Services for the FreeText Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IFreeTextAgent">FreeText Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| FreeTextEnabled | bool | True if freetext search enabled |
| SingleWordOperator | string | Starts with, contains or exact match |
| MultiWordOperator | string | Starts with, contains or exact match |
| CountWords | int32 | Count of unique search words |
| Occurrences | int32 | Total count of search words |
| LastGenerated | date-time | Last time search has been generated |
| AutoEnableTravelAreas | bool | Automatically enable freetext search for new travel areas |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/FreeText/GetStatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FreeTextEnabled": false,
  "SingleWordOperator": "Contains",
  "MultiWordOperator": "Contains",
  "CountWords": 83,
  "Occurrences": 520,
  "LastGenerated": "2000-01-05T18:28:49.2250903+01:00",
  "AutoEnableTravelAreas": true,
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
      "FieldLength": 110
    }
  }
}
```