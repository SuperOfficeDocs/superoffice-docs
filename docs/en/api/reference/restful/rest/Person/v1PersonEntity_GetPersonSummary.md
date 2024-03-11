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
GET /api/v1/Person/{personId}/Summary?limit=474
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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": null,
  "Tickets": [
    {
      "TicketId": 956,
      "TicketStatus": 4,
      "Title": "pariatur",
      "Registered": "2023-01-20T14:23:55.2908369+01:00",
      "IconHint": "provident"
    },
    {
      "TicketId": 956,
      "TicketStatus": 4,
      "Title": "pariatur",
      "Registered": "2023-01-20T14:23:55.2908369+01:00",
      "IconHint": "provident"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 249,
      "DocumentId": 724,
      "Date": "1998-01-20T14:23:55.2908369+01:00",
      "Description": "Compatible optimizing solution",
      "Completed": "Completed",
      "Registered": "2014-09-21T14:23:55.2908369+02:00"
    },
    {
      "AppointmentId": 249,
      "DocumentId": 724,
      "Date": "1998-01-20T14:23:55.2908369+01:00",
      "Description": "Compatible optimizing solution",
      "Completed": "Completed",
      "Registered": "2014-09-21T14:23:55.2908369+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 485,
      "DocumentId": 191,
      "Date": "2013-07-09T14:23:55.2908369+02:00",
      "Description": "Exclusive value-added support",
      "Completed": "Completed",
      "Registered": "2009-06-13T14:23:55.2908369+02:00"
    },
    {
      "AppointmentId": 485,
      "DocumentId": 191,
      "Date": "2013-07-09T14:23:55.2908369+02:00",
      "Description": "Exclusive value-added support",
      "Completed": "Completed",
      "Registered": "2009-06-13T14:23:55.2908369+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 500,
      "SaleDate": "2002-01-10T14:23:55.2908369+01:00",
      "Probability": 812,
      "Heading": "porro",
      "Amount": 31173.897999999997,
      "Currency": "delectus",
      "AmountInBaseCurrency": 14783.078,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2016-04-23T14:23:55.2908369+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 840,
      "Name": "Tremblay LLC",
      "CompanyName": "Stehr Group",
      "FirstMessage": "iste",
      "LastMessage": "laboriosam",
      "WhenRequested": "2008-11-29T14:23:55.2908369+01:00",
      "WhenEnded": "2009-07-01T14:23:55.2908369+02:00"
    }
  ]
}
```