---
title: POST Agents/CustomerService/ExecuteEventHandlers
id: v1CustomerServiceAgent_ExecuteEventHandlers
---

# POST Agents/CustomerService/ExecuteEventHandlers

```http
POST /api/v1/Agents/CustomerService/ExecuteEventHandlers
```

This method will execute event handlers in CRMScript for a given event.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CustomerService/ExecuteEventHandlers?$select=name,department,category/id
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

EventData 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EventData |  | EventData containing data related to event handlers <para /> Carrier object for EventData. Services for the EventData Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ICustomerServiceAgent">CustomerService Agent</see>. |


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
POST /api/v1/Agents/CustomerService/ExecuteEventHandlers
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EventData": {
    "Type": "ChatAfterSaveNewMessage",
    "InputValues": {
      "InputValues1": "aspernatur",
      "InputValues2": "earum"
    },
    "BlockExecution": true,
    "NavigateTo": "laborum",
    "Message": "et",
    "OutputValues": {
      "OutputValues1": "mollitia",
      "OutputValues2": "ut"
    },
    "StateValues": {
      "StateValues1": "reprehenderit",
      "StateValues2": "recusandae"
    },
    "Exception": "repellat"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Type": "ChatAfterSaveNewMessage",
  "InputValues": {
    "InputValues1": "qui",
    "InputValues2": "cupiditate"
  },
  "BlockExecution": true,
  "NavigateTo": "odit",
  "Message": "totam",
  "OutputValues": {
    "OutputValues1": "molestias",
    "OutputValues2": "unde"
  },
  "StateValues": {
    "StateValues1": "non",
    "StateValues2": "blanditiis"
  },
  "Exception": "aut",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 888
    }
  }
}
```