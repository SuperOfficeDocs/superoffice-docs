---
title: POST Agents/CustomerService/GetSystemTemplateSettings
uid: v1CustomerServiceAgent_GetSystemTemplateSettings
---

# POST Agents/CustomerService/GetSystemTemplateSettings

```http
POST /api/v1/Agents/CustomerService/GetSystemTemplateSettings
```

Returns system template settings







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CustomerService/GetSystemTemplateSettings?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: SystemTemplateSettings

| Property Name | Type |  Description |
|----------------|------|--------------|
| CustomerNewCustomerTemplateId | int32 | Template for new contacts |
| CustomerCustomerReplyTemplateId | int32 | Template for auto-reply |
| CustomerPasswordTemplateId | int32 | Template for sending password to contacts |
| CustomerConfirmEmailTemplateId | int32 | Template for sending confirmation e-mail to contacts |
| CustomerChatLogTemplateId | int32 | Template for customer chat log |
| NewLinkTemplateId | int32 | Template for new link |
| HotlistNewMessageTemplateId | int32 | Template for notification of a new message in the favourites list |
| HotlistTicketActivatedTemplateId | int32 | Template for notification of a activated ticket in the favourites list |
| UserTicketAlarmTemplateId | int32 | Template for notification of escalated request |
| HotlistTicketTakenOverTemplateId | int32 | Template for notification of reassignment of a request in the favourites list |
| UserActiveTicketsTemplateId | int32 | Template for notification of open requests |
| UserNewMessageTemplateId | int32 | Template for notification of new message |
| UserTicketActivatedTemplateId | int32 | Template for notification of activated request |
| UserNewTicketTemplateId | int32 | Template for new ticket notification |
| PublishKbQuestionTemplateId | int32 | Template for formatting FAQ questions |
| PublishKbAnswerTemplateId | int32 | Template for formatting FAQ answers |
| UserTicketTakenOverTemplateId | int32 | Template for ticket reassignment |
| PrintTicketTemplateId | int32 | Template for printing a ticket |
| WeekStatTemplateId | int32 | Template for weekly statistics |
| TicketAlarmHotlistTemplateId | int32 | Template for notification of an escalated request in the favourites list |
| EmailAddresses | string | One or more e-mail addresses (comma-separated) |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/CustomerService/GetSystemTemplateSettings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "CustomerNewCustomerTemplateId": 454,
  "CustomerCustomerReplyTemplateId": 790,
  "CustomerPasswordTemplateId": 208,
  "CustomerConfirmEmailTemplateId": 946,
  "CustomerChatLogTemplateId": 859,
  "NewLinkTemplateId": 206,
  "HotlistNewMessageTemplateId": 655,
  "HotlistTicketActivatedTemplateId": 615,
  "UserTicketAlarmTemplateId": 110,
  "HotlistTicketTakenOverTemplateId": 147,
  "UserActiveTicketsTemplateId": 466,
  "UserNewMessageTemplateId": 516,
  "UserTicketActivatedTemplateId": 16,
  "UserNewTicketTemplateId": 908,
  "PublishKbQuestionTemplateId": 379,
  "PublishKbAnswerTemplateId": 923,
  "UserTicketTakenOverTemplateId": 326,
  "PrintTicketTemplateId": 456,
  "WeekStatTemplateId": 954,
  "TicketAlarmHotlistTemplateId": 194,
  "EmailAddresses": "michel@white.uk",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 839
    }
  }
}
```