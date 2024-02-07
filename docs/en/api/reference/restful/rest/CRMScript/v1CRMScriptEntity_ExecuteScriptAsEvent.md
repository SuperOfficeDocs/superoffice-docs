---
title: POST CRMScript/{id}/ExecuteAsEvent
uid: v1CRMScriptEntity_ExecuteScriptAsEvent
generated: true
---

# POST CRMScript/{id}/ExecuteAsEvent

```http
POST /api/v1/CRMScript/{cRMScriptId}/ExecuteAsEvent
```

Execute a CRMScript with event data as input.


Returns event data with output variable values.


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.





| Path Part | Type | Description |
|-----------|------|-------------|
| cRMScriptId | int32 | The id of the CRMScript to execute **Required** |



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

## Request Body: eventData 

The EventData instance sent to the crmscript with input values 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Type | String | The type of event we are triggered by |
| InputValues | Object | Environment values sent to the event handler |
| BlockExecution | Boolean | Whether the context should stop what it is doing, e.g. saving a sale |
| NavigateTo | String | Where the context should naviate afterwards |
| Message | String | A message to be presented to the user |
| ShowDialog | String | JSON structure of dialog to show |
| OutputValues | Object | Values sent back to the environment from the event handler |
| StateValues | Object | Values kept between event handlers |
| Exception | String | String containing error message from handler system if it failed |
| ParserValues | Object | Parser values sent to the event handler |
| CgiVariables | Object | Cgi variables sent by some events |
| CgiContent | String | The Cgi content/body, sent by some events |
| Headers | Object | Incoming headers if sent by the context which the script is executed from |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: EventData

| Property Name | Type |  Description |
|----------------|------|--------------|
| Type | string | The type of event we are triggered by |
| InputValues | object | Environment values sent to the event handler |
| BlockExecution | bool | Whether the context should stop what it is doing, e.g. saving a sale |
| NavigateTo | string | Where the context should naviate afterwards |
| Message | string | A message to be presented to the user |
| ShowDialog | string | JSON structure of dialog to show |
| OutputValues | object | Values sent back to the environment from the event handler |
| StateValues | object | Values kept between event handlers |
| Exception | string | String containing error message from handler system if it failed |
| ParserValues | object | Parser values sent to the event handler |
| CgiVariables | object | Cgi variables sent by some events |
| CgiContent | string | The Cgi content/body, sent by some events |
| Headers | object | Incoming headers if sent by the context which the script is executed from |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/CRMScript/{cRMScriptId}/ExecuteAsEvent
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Type": "ChatAfterSaveNewMessage",
  "InputValues": {
    "InputValues1": "totam",
    "InputValues2": "temporibus"
  },
  "BlockExecution": true,
  "NavigateTo": "consequatur",
  "Message": "non",
  "ShowDialog": "corrupti",
  "OutputValues": {
    "OutputValues1": "iure",
    "OutputValues2": "id"
  },
  "StateValues": {
    "StateValues1": "dolores",
    "StateValues2": "ipsam"
  },
  "Exception": "quisquam",
  "ParserValues": {
    "ParserValues1": "ut",
    "ParserValues2": "eum"
  },
  "CgiVariables": {
    "CgiVariables1": "omnis",
    "CgiVariables2": "aliquid"
  },
  "CgiContent": "illo",
  "Headers": {
    "Headers1": "vitae",
    "Headers2": "veritatis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Type": "ChatAfterSaveNewMessage",
  "InputValues": {
    "InputValues1": "occaecati",
    "InputValues2": "nam"
  },
  "BlockExecution": true,
  "NavigateTo": "recusandae",
  "Message": "ullam",
  "ShowDialog": "temporibus",
  "OutputValues": {
    "OutputValues1": "voluptas",
    "OutputValues2": "quam"
  },
  "StateValues": {
    "StateValues1": "aut",
    "StateValues2": "occaecati"
  },
  "Exception": "ut",
  "ParserValues": {
    "ParserValues1": "beatae",
    "ParserValues2": "et"
  },
  "CgiVariables": {
    "CgiVariables1": "ut",
    "CgiVariables2": "ex"
  },
  "CgiContent": "optio",
  "Headers": {
    "Headers1": "sed",
    "Headers2": "deleniti"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 377
    }
  }
}
```