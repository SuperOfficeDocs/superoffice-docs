---
title: GET Contact/{id}/Summary
uid: v1ContactEntity_GetContactSummary
generated: true
content_type: reference
---

# GET Contact/{id}/Summary

```http
GET /api/v1/Contact/{contactId}/Summary
```

Get summary of contact and its recent activity.






| Path Part | Type | Description |
|-----------|------|-------------|
| contactId | int32 | The contact id to summarize. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| limit | int32 |  Max number of items to include in summary lists. |

```http
GET /api/v1/Contact/{contactId}/Summary?limit=54
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

### Response body: ContactSummary

| Property Name | Type |  Description |
|----------------|------|--------------|
| Contact | Contact | Simple Contact data. |
| Tickets | array | Recent tickets on contact |
| Followups | array | Recent follow-ups on contact |
| Documents | array | Recent documents on contact |
| Sales | array | Recent sales on contact |
| Chats | array | Recent chats with contact |

## Sample request

```http!
GET /api/v1/Contact/{contactId}/Summary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 291,
      "TicketStatus": 788,
      "Title": "tempore",
      "Registered": "2022-01-30T03:41:58.6055208+01:00",
      "IconHint": "ut"
    },
    {
      "TicketId": 291,
      "TicketStatus": 788,
      "Title": "tempore",
      "Registered": "2022-01-30T03:41:58.6055208+01:00",
      "IconHint": "ut"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 455,
      "DocumentId": 414,
      "Date": "2005-12-25T03:41:58.6055208+01:00",
      "Description": "Progressive exuding matrix",
      "Completed": "Completed",
      "Registered": "2004-08-17T03:41:58.6055208+02:00"
    },
    {
      "AppointmentId": 455,
      "DocumentId": 414,
      "Date": "2005-12-25T03:41:58.6055208+01:00",
      "Description": "Progressive exuding matrix",
      "Completed": "Completed",
      "Registered": "2004-08-17T03:41:58.6055208+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 914,
      "DocumentId": 724,
      "Date": "2005-10-31T03:41:58.6055208+01:00",
      "Description": "Switchable optimizing system engine",
      "Completed": "Completed",
      "Registered": "2024-04-04T03:41:58.6055208+02:00"
    },
    {
      "AppointmentId": 914,
      "DocumentId": 724,
      "Date": "2005-10-31T03:41:58.6055208+01:00",
      "Description": "Switchable optimizing system engine",
      "Completed": "Completed",
      "Registered": "2024-04-04T03:41:58.6055208+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 432,
      "SaleDate": "2007-08-06T03:41:58.6055208+02:00",
      "Probability": 15,
      "Heading": "expedita",
      "Amount": 13049.975999999999,
      "Currency": "qui",
      "AmountInBaseCurrency": 23570.814,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2014-07-26T03:41:58.6055208+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 11,
      "Name": "O'Connell, O'Reilly and Medhurst",
      "CompanyName": "Koelpin Inc and Sons",
      "FirstMessage": "dolorem",
      "LastMessage": "ratione",
      "WhenRequested": "1999-04-03T03:41:58.6055208+02:00",
      "WhenEnded": "2005-05-11T03:41:58.6055208+02:00"
    }
  ]
}
```