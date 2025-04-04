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
GET /api/v1/Person/{personId}/Summary?limit=393
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
      "TicketId": 761,
      "TicketStatus": 412,
      "Title": "maiores",
      "Registered": "2017-11-29T13:14:08.8678966+01:00",
      "IconHint": "veniam"
    },
    {
      "TicketId": 761,
      "TicketStatus": 412,
      "Title": "maiores",
      "Registered": "2017-11-29T13:14:08.8678966+01:00",
      "IconHint": "veniam"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 572,
      "DocumentId": 284,
      "Date": "2009-10-31T13:14:08.8678966+01:00",
      "Description": "Devolved content-based Graphical User Interface",
      "Completed": "Completed",
      "Registered": "2001-10-21T13:14:08.8678966+02:00"
    },
    {
      "AppointmentId": 572,
      "DocumentId": 284,
      "Date": "2009-10-31T13:14:08.8678966+01:00",
      "Description": "Devolved content-based Graphical User Interface",
      "Completed": "Completed",
      "Registered": "2001-10-21T13:14:08.8678966+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 101,
      "DocumentId": 153,
      "Date": "2001-06-29T13:14:08.8678966+02:00",
      "Description": "Visionary fresh-thinking Graphic Interface",
      "Completed": "Completed",
      "Registered": "2004-02-17T13:14:08.8678966+01:00"
    },
    {
      "AppointmentId": 101,
      "DocumentId": 153,
      "Date": "2001-06-29T13:14:08.8678966+02:00",
      "Description": "Visionary fresh-thinking Graphic Interface",
      "Completed": "Completed",
      "Registered": "2004-02-17T13:14:08.8678966+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 761,
      "SaleDate": "2007-05-20T13:14:08.8678966+02:00",
      "Probability": 160,
      "Heading": "tempore",
      "Amount": 21681.012,
      "Currency": "facere",
      "AmountInBaseCurrency": 10827.97,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2024-01-28T13:14:08.8678966+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 554,
      "Name": "Mayert-Kulas",
      "CompanyName": "Rempel Inc and Sons",
      "FirstMessage": "et",
      "LastMessage": "similique",
      "WhenRequested": "2015-10-07T13:14:08.8678966+02:00",
      "WhenEnded": "2013-04-02T13:14:08.8678966+02:00"
    }
  ]
}
```