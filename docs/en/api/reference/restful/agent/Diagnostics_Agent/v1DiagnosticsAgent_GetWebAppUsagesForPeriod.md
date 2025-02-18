---
title: POST Agents/Diagnostics/GetWebAppUsagesForPeriod
uid: v1DiagnosticsAgent_GetWebAppUsagesForPeriod
generated: true
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
  "FromDate": "1998-01-23T14:32:02.6242172+01:00",
  "ToDate": "2019-03-19T14:32:02.6242172+01:00",
  "SearchTerm": "nobis"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "WebAppUsageId": 121,
    "AssocId": 613,
    "Timestamp": "2011-04-28T14:32:02.6242172+02:00",
    "ViewState": "aut",
    "AggregateCount": 146,
    "AggregateBin": 111,
    "Version": 598,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 690
      }
    }
  }
]
```