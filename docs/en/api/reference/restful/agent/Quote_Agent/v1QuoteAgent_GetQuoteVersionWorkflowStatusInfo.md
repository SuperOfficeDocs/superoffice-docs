---
title: POST Agents/Quote/GetQuoteVersionWorkflowStatusInfo
uid: v1QuoteAgent_GetQuoteVersionWorkflowStatusInfo
generated: true
---

# POST Agents/Quote/GetQuoteVersionWorkflowStatusInfo

```http
POST /api/v1/Agents/Quote/GetQuoteVersionWorkflowStatusInfo
```

Get status info for the Quote version dialog header.


Collects most important warnings/errors from across all quotelines/alternatives in this quote version.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/GetQuoteVersionWorkflowStatusInfo?$select=name,department,category/id
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

### Response body: QuoteVersionStatusInformation

| Property Name | Type |  Description |
|----------------|------|--------------|
| Status | string | Status information for the quote version: Ok / OkWithInfo / Warn / Error. |
| IconHint | string | Icon hint for the associated message. |
| DisplayMessage | string | Generated error message for the Quote Version. Will check for errors on quote lines, alternatives and the version itself. |
| DisplayTooltip | string | Generated full tooltip for the Quote Version. Will check for errors on quote lines, alternatives and the version itself. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Quote/GetQuoteVersionWorkflowStatusInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 4
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Status": "Error",
  "IconHint": "officiis",
  "DisplayMessage": "nisi",
  "DisplayTooltip": "aliquid",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 962
    }
  }
}
```