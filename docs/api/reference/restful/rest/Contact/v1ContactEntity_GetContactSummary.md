---
title: GET Contact/{id}/Summary
uid: v1ContactEntity_GetContactSummary
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
GET /api/v1/Contact/{contactId}/Summary?limit=99
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

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Contact |  | Simple Contact data. |
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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 725,
      "TicketStatus": 580,
      "Title": "enim",
      "Registered": "2015-09-13T02:49:50.8234127+02:00",
      "IconHint": "quos"
    },
    {
      "TicketId": 725,
      "TicketStatus": 580,
      "Title": "enim",
      "Registered": "2015-09-13T02:49:50.8234127+02:00",
      "IconHint": "quos"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 623,
      "DocumentId": 92,
      "Date": "2013-06-14T02:49:50.8234127+02:00",
      "Description": "Enhanced zero administration array",
      "Completed": "Completed",
      "Registered": "2020-02-19T02:49:50.8234127+01:00"
    },
    {
      "AppointmentId": 623,
      "DocumentId": 92,
      "Date": "2013-06-14T02:49:50.8234127+02:00",
      "Description": "Enhanced zero administration array",
      "Completed": "Completed",
      "Registered": "2020-02-19T02:49:50.8234127+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 251,
      "DocumentId": 557,
      "Date": "2003-11-22T02:49:50.8234127+01:00",
      "Description": "Fundamental content-based paradigm",
      "Completed": "Completed",
      "Registered": "2022-07-13T02:49:50.8234127+02:00"
    },
    {
      "AppointmentId": 251,
      "DocumentId": 557,
      "Date": "2003-11-22T02:49:50.8234127+01:00",
      "Description": "Fundamental content-based paradigm",
      "Completed": "Completed",
      "Registered": "2022-07-13T02:49:50.8234127+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 402,
      "SaleDate": "2022-07-09T02:49:50.8234127+02:00",
      "Probability": 845,
      "Heading": "quos",
      "Amount": 5396.748,
      "Currency": "sunt",
      "AmountInBaseCurrency": 9637.05,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2007-01-23T02:49:50.8234127+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 386,
      "Name": "Eichmann-Hessel",
      "CompanyName": "Halvorson Group",
      "FirstMessage": "ea",
      "LastMessage": "eum",
      "WhenRequested": "2007-11-26T02:49:50.8234127+01:00",
      "WhenEnded": "2018-08-20T02:49:50.8234127+02:00"
    }
  ]
}
```