---
title: POST Agents/Diagnostics/WebAppUsageExistsInPeriod
id: v1DiagnosticsAgent_WebAppUsageExistsInPeriod
---

# POST Agents/Diagnostics/WebAppUsageExistsInPeriod

```http
POST /api/v1/Agents/Diagnostics/WebAppUsageExistsInPeriod
```

Returns true if viewState has been clicked at least once since FromDate, if asscoiateId &lt; 0 or FromDate is DateTime.

MinValue no restriction given for those parameters





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Diagnostics/WebAppUsageExistsInPeriod?$select=name,department,category/id
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

AssociateId, ViewState, FromDate 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | int32 |  |
| ViewState | string |  |
| FromDate | date-time |  |


## Response: bool



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: bool


## Sample Request

```http!
POST /api/v1/Agents/Diagnostics/WebAppUsageExistsInPeriod
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 331,
  "ViewState": "temporibus",
  "FromDate": "1998-01-05T18:28:48.7029564+01:00"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

true
```