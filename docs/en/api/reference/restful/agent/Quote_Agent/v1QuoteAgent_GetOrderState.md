---
title: POST Agents/Quote/GetOrderState
uid: v1QuoteAgent_GetOrderState
generated: true
---

# POST Agents/Quote/GetOrderState

```http
POST /api/v1/Agents/Quote/GetOrderState
```

If there is a problem with a quoteline, the error description shall be placed in the status and reason fields of the quoteline, if there is a problem with the alternative, the error description shall be placed in the status and reason fields of the alternative.


A summary of all the problems (if any) should be placed in the response object. Requires that the Create-Order capability is true.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/GetOrderState?$select=name,department,category/id
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

QuoteVersionId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteVersionId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PluginUrlResponse

| Property Name | Type |  Description |
|----------------|------|--------------|
| IsOk | bool | Answer to the question / An indication if the operation went well.  Equivalent to Status != Error |
| UserExplanation | string | A localized explanation to the answer. |
| TechExplanation | string | Always in English |
| ErrorCode | string | An error code, if available. |
| Changes | ChangedData | Tablename/recordid of data changed by this method, that the client may need to reload |
| Url | string | Url that the GUI should navigato to/open, if non-blank. The GUI cannot enforce any rules subsequent to opening the requested url. |
| Status | string | QuoteStatus = Ok / OkWithInfo / Warn / Error. Error implies IsOk = false. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Quote/GetOrderState
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 219
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "IsOk": false,
  "UserExplanation": "aut",
  "TechExplanation": "temporibus",
  "ErrorCode": "facere",
  "Changes": null,
  "Url": "http://www.example.com/",
  "Status": "Error",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 707
    }
  }
}
```