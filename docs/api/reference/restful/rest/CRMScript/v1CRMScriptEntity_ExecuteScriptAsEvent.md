---
title: POST CRMScript/{id}/ExecuteAsEvent
id: v1CRMScriptEntity_ExecuteScriptAsEvent
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
| Type | string | The type of event we are triggered by |
| InputValues | object | Environment values sent to the event handler |
| BlockExecution | bool | Whether the context should stop what it is doing, e.g. saving a sale |
| NavigateTo | string | Where the context should naviate afterwards |
| Message | string | A message to be presented to the user |
| OutputValues | object | Values sent back to the environment from the event handler |
| StateValues | object | Values kept between event handlers |
| Exception | string | String containing error message from handler system if it failed |


## Response: object

EventData containing data related to event handlers



Carrier object for EventData.
Services for the EventData Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ICustomerServiceAgent">CustomerService Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Type | string | The type of event we are triggered by |
| InputValues | object | Environment values sent to the event handler |
| BlockExecution | bool | Whether the context should stop what it is doing, e.g. saving a sale |
| NavigateTo | string | Where the context should naviate afterwards |
| Message | string | A message to be presented to the user |
| OutputValues | object | Values sent back to the environment from the event handler |
| StateValues | object | Values kept between event handlers |
| Exception | string | String containing error message from handler system if it failed |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/CRMScript/{cRMScriptId}/ExecuteAsEvent
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Type": "ChatAfterSaveNewMessage",
  "InputValues": {
    "InputValues1": "id",
    "InputValues2": "id"
  },
  "BlockExecution": true,
  "NavigateTo": "quo",
  "Message": "earum",
  "OutputValues": {
    "OutputValues1": "natus",
    "OutputValues2": "veritatis"
  },
  "StateValues": {
    "StateValues1": "tempore",
    "StateValues2": "amet"
  },
  "Exception": "maiores"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Type": "ChatAfterSaveNewMessage",
  "InputValues": {
    "InputValues1": "rem",
    "InputValues2": "ullam"
  },
  "BlockExecution": false,
  "NavigateTo": "vero",
  "Message": "nemo",
  "OutputValues": {
    "OutputValues1": "corporis",
    "OutputValues2": "excepturi"
  },
  "StateValues": {
    "StateValues1": "est",
    "StateValues2": "tempora"
  },
  "Exception": "hic",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "seize viral channels"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 526
    }
  }
}
```