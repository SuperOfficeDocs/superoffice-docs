---
title: POST Agents/CRMScript/ExecuteScriptAsEventByUniqueId
uid: v1CRMScriptAgent_ExecuteScriptAsEventByUniqueId
generated: true
---

# POST Agents/CRMScript/ExecuteScriptAsEventByUniqueId

```http
POST /api/v1/Agents/CRMScript/ExecuteScriptAsEventByUniqueId
```

Execute a CRMScript with event data as input.


Returns event data with output variable values.


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CRMScript/ExecuteScriptAsEventByUniqueId?$select=name,department,category/id
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

CRMScriptUniqueId, EventData 

| Property Name | Type |  Description |
|----------------|------|--------------|
| CRMScriptUniqueId | String |  |
| EventData | EventData | EventData containing data related to event handlers <para /> Carrier object for EventData. Services for the EventData Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ICustomerServiceAgent">CustomerService Agent</see>. |

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/CRMScript/ExecuteScriptAsEventByUniqueId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "CRMScriptUniqueId": "blanditiis",
  "EventData": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Type": "ChatAfterSaveNewMessage",
  "InputValues": {
    "InputValues1": "aut",
    "InputValues2": "dicta"
  },
  "BlockExecution": false,
  "NavigateTo": "reprehenderit",
  "Message": "cumque",
  "ShowDialog": "omnis",
  "OutputValues": {
    "OutputValues1": "sed",
    "OutputValues2": "et"
  },
  "StateValues": {
    "StateValues1": "dolor",
    "StateValues2": "et"
  },
  "Exception": "aut",
  "ParserValues": {
    "ParserValues1": "vel",
    "ParserValues2": "incidunt"
  },
  "CgiVariables": {
    "CgiVariables1": "inventore",
    "CgiVariables2": "praesentium"
  },
  "CgiContent": "odio",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 456
    }
  }
}
```