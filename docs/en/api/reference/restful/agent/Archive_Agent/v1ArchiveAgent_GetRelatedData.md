---
title: POST Agents/Archive/GetRelatedData
uid: v1ArchiveAgent_GetRelatedData
generated: true
---

# POST Agents/Archive/GetRelatedData

```http
POST /api/v1/Agents/Archive/GetRelatedData
```

Get data for fields related to a table record.


While this method /can/ be used to fetch plain fields, that is not the intended usage and it does not replace the Entity.Get methods available for that purpose. Nor does it replace the generic DotSyntax/Dynamic archive provider.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Archive/GetRelatedData?$select=name,department,category/id
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

Table, RecordId, Fields 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Table | String |  |
| RecordId | Integer |  |
| Fields | Array |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Field | string | The name of a 'related field'. This must be a valid column name in the DotSyntax/Dynamic system, implicitly starting with the given root table |
| FieldValue | ArchiveColumnData | The value for the Field, expressed as an archive column data cell |

## Sample request

```http!
POST /api/v1/Agents/Archive/GetRelatedData
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Table": "quis",
  "RecordId": 835,
  "Fields": [
    "quibusdam",
    "quibusdam"
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Field": "consequatur",
    "FieldValue": null
  },
  {
    "Field": "consequatur",
    "FieldValue": null
  }
]
```