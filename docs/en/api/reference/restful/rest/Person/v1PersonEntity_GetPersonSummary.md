---
title: GET Person/{id}/Summary
uid: v1PersonEntity_GetPersonSummary
generated: true
---

# GET Person/{id}/Summary

```http
GET /api/v1/Person/{personId}/Summary
```

Get summary of person and recent activity.






| Path Part | Type | Description |
|-----------|------|-------------|
| personId | int32 | The person id to summarize. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| limit | int32 |  Max number of items to include in summary lists. |

```http
GET /api/v1/Person/{personId}/Summary?limit=555
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

### Response body: PersonSummary

| Property Name | Type |  Description |
|----------------|------|--------------|
| Person | Person | Simple Person data. |
| Tickets | array | Recent tickets on person |
| Followups | array | Recent follow-ups on person |
| Documents | array | Recent documents on person |
| Sales | array | Recent sales on person |
| Chats | array | Recent chats with person |

## Sample request

```http!
GET /api/v1/Person/{personId}/Summary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": null,
  "Tickets": [
    {
      "TicketId": 184,
      "TicketStatus": 922,
      "Title": "quia",
      "Registered": "2021-12-01T13:38:17.5149376+01:00",
      "IconHint": "nihil"
    },
    {
      "TicketId": 184,
      "TicketStatus": 922,
      "Title": "quia",
      "Registered": "2021-12-01T13:38:17.5149376+01:00",
      "IconHint": "nihil"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 972,
      "DocumentId": 471,
      "Date": "1996-09-03T13:38:17.5149376+02:00",
      "Description": "Down-sized methodical circuit",
      "Completed": "Completed",
      "Registered": "2005-10-26T13:38:17.5149376+02:00"
    },
    {
      "AppointmentId": 972,
      "DocumentId": 471,
      "Date": "1996-09-03T13:38:17.5149376+02:00",
      "Description": "Down-sized methodical circuit",
      "Completed": "Completed",
      "Registered": "2005-10-26T13:38:17.5149376+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 750,
      "DocumentId": 308,
      "Date": "1999-01-08T13:38:17.5149376+01:00",
      "Description": "Realigned needs-based instruction set",
      "Completed": "Completed",
      "Registered": "2000-06-24T13:38:17.5149376+02:00"
    },
    {
      "AppointmentId": 750,
      "DocumentId": 308,
      "Date": "1999-01-08T13:38:17.5149376+01:00",
      "Description": "Realigned needs-based instruction set",
      "Completed": "Completed",
      "Registered": "2000-06-24T13:38:17.5149376+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 605,
      "SaleDate": "2023-07-27T13:38:17.5149376+02:00",
      "Probability": 137,
      "Heading": "nobis",
      "Amount": 3989.582,
      "Currency": "dolorum",
      "AmountInBaseCurrency": 6318.144,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2019-02-14T13:38:17.5149376+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 18,
      "Name": "McLaughlin, Walker and Becker",
      "CompanyName": "Hane LLC",
      "FirstMessage": "sit",
      "LastMessage": "nulla",
      "WhenRequested": "2014-05-23T13:38:17.5149376+02:00",
      "WhenEnded": "2021-07-14T13:38:17.5149376+02:00"
    }
  ]
}
```