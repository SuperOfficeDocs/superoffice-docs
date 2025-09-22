---
title: POST Agents/Diagnostics/GetWebAppUsagesForPeriod
uid: v1DiagnosticsAgent_GetWebAppUsagesForPeriod
generated: true
content_type: reference
---

# POST Agents/Diagnostics/GetWebAppUsagesForPeriod

```http
POST /api/v1/Agents/Diagnostics/GetWebAppUsagesForPeriod
```

Get all WebAppUsages for a given period, that match an optional search term







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Diagnostics/GetWebAppUsagesForPeriod?$select=name,department,category/id
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

FromDate, ToDate, SearchTerm 

| Property Name | Type |  Description |
|----------------|------|--------------|
| FromDate | String |  |
| ToDate | String |  |
| SearchTerm | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| WebAppUsageId | int32 | Primary Key |
| AssocId | int32 | Associate Id |
| Timestamp | date-time | Which day the usage was logged |
| ViewState | string | The SoProtocol(ViewState) |
| AggregateCount | int32 | Number of times the specific soprotocol is accessed |
| AggregateBin | int32 | ?? |
| Version | int32 | ?? |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Diagnostics/GetWebAppUsagesForPeriod
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "FromDate": "2001-02-08T11:24:47.8751665+01:00",
  "ToDate": "2000-07-19T11:24:47.8751665+02:00",
  "SearchTerm": "officiis"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "WebAppUsageId": 690,
    "AssocId": 850,
    "Timestamp": "2009-02-01T11:24:47.8751665+01:00",
    "ViewState": "voluptatem",
    "AggregateCount": 915,
    "AggregateBin": 234,
    "Version": 435,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 70
      }
    }
  }
]
```