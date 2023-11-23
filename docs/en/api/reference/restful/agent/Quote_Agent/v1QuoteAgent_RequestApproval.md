---
title: POST Agents/Quote/RequestApproval
uid: v1QuoteAgent_RequestApproval
generated: true
---

# POST Agents/Quote/RequestApproval

```http
POST /api/v1/Agents/Quote/RequestApproval
```

Notifies specified associate that this quote needs approval.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/RequestApproval?$select=name,department,category/id
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

QuoteVersionId, AssociateId, Comment 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteVersionId | Integer |  |
| AssociateId | Integer |  |
| Comment | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PluginResponse

| Property Name | Type |  Description |
|----------------|------|--------------|
| IsOk | bool | Answer to the question / An indication if the operation went well. Equivalent to Status != Error |
| UserExplanation | string | A localized explanation to the answer. Text here is displayed to the user. |
| TechExplanation | string | Always in English |
| ErrorCode | string | An error code, if available. |
| Changes | ChangedData | Tablename/recordid of data changed by this method, that the client may need to reload |
| Status | string | QuoteStatus = Ok / OkWithInfo / Warn / Error. Error implies IsOk = false. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Quote/RequestApproval
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 132,
  "AssociateId": 1000,
  "Comment": "et"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "IsOk": true,
  "UserExplanation": "corporis",
  "TechExplanation": "sit",
  "ErrorCode": "nihil",
  "Changes": null,
  "Status": "Error",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 304
    }
  }
}
```