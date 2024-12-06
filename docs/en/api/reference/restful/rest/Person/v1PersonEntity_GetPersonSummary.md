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
GET /api/v1/Person/{personId}/Summary?limit=815
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": null,
  "Tickets": [
    {
      "TicketId": 422,
      "TicketStatus": 810,
      "Title": "iusto",
      "Registered": "2018-07-18T10:18:00.4730845+02:00",
      "IconHint": "nihil"
    },
    {
      "TicketId": 422,
      "TicketStatus": 810,
      "Title": "iusto",
      "Registered": "2018-07-18T10:18:00.4730845+02:00",
      "IconHint": "nihil"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 327,
      "DocumentId": 775,
      "Date": "2010-05-30T10:18:00.4730845+02:00",
      "Description": "Extended 6th generation algorithm",
      "Completed": "Completed",
      "Registered": "2007-03-06T10:18:00.4730845+01:00"
    },
    {
      "AppointmentId": 327,
      "DocumentId": 775,
      "Date": "2010-05-30T10:18:00.4730845+02:00",
      "Description": "Extended 6th generation algorithm",
      "Completed": "Completed",
      "Registered": "2007-03-06T10:18:00.4730845+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 558,
      "DocumentId": 711,
      "Date": "2013-08-11T10:18:00.4730845+02:00",
      "Description": "Monitored clear-thinking matrices",
      "Completed": "Completed",
      "Registered": "2021-07-30T10:18:00.4730845+02:00"
    },
    {
      "AppointmentId": 558,
      "DocumentId": 711,
      "Date": "2013-08-11T10:18:00.4730845+02:00",
      "Description": "Monitored clear-thinking matrices",
      "Completed": "Completed",
      "Registered": "2021-07-30T10:18:00.4730845+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 514,
      "SaleDate": "1999-06-29T10:18:00.4730845+02:00",
      "Probability": 66,
      "Heading": "rerum",
      "Amount": 15801.627999999999,
      "Currency": "tempora",
      "AmountInBaseCurrency": 7462.054,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2003-03-12T10:18:00.4730845+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 962,
      "Name": "Schmitt Group",
      "CompanyName": "Weber-Wilderman",
      "FirstMessage": "omnis",
      "LastMessage": "vero",
      "WhenRequested": "1997-09-20T10:18:00.4730845+02:00",
      "WhenEnded": "2022-07-01T10:18:00.4730845+02:00"
    }
  ]
}
```