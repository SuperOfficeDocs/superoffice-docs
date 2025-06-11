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
GET /api/v1/Person/{personId}/Summary?limit=949
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
      "TicketId": 59,
      "TicketStatus": 219,
      "Title": "ut",
      "Registered": "2022-10-19T17:54:08.3668296+02:00",
      "IconHint": "voluptatum"
    },
    {
      "TicketId": 59,
      "TicketStatus": 219,
      "Title": "ut",
      "Registered": "2022-10-19T17:54:08.3668296+02:00",
      "IconHint": "voluptatum"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 782,
      "DocumentId": 136,
      "Date": "2014-11-07T17:54:08.3668296+01:00",
      "Description": "Centralized stable array",
      "Completed": "Completed",
      "Registered": "2008-12-11T17:54:08.3668296+01:00"
    },
    {
      "AppointmentId": 782,
      "DocumentId": 136,
      "Date": "2014-11-07T17:54:08.3668296+01:00",
      "Description": "Centralized stable array",
      "Completed": "Completed",
      "Registered": "2008-12-11T17:54:08.3668296+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 965,
      "DocumentId": 330,
      "Date": "1998-12-16T17:54:08.3668296+01:00",
      "Description": "Streamlined foreground initiative",
      "Completed": "Completed",
      "Registered": "2011-01-07T17:54:08.3668296+01:00"
    },
    {
      "AppointmentId": 965,
      "DocumentId": 330,
      "Date": "1998-12-16T17:54:08.3668296+01:00",
      "Description": "Streamlined foreground initiative",
      "Completed": "Completed",
      "Registered": "2011-01-07T17:54:08.3668296+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 588,
      "SaleDate": "2012-10-02T17:54:08.3668296+02:00",
      "Probability": 669,
      "Heading": "ipsam",
      "Amount": 1347.62,
      "Currency": "quidem",
      "AmountInBaseCurrency": 15867.442,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2023-05-12T17:54:08.3668296+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 773,
      "Name": "Hackett, Jaskolski and Reilly",
      "CompanyName": "Green-Williamson",
      "FirstMessage": "perferendis",
      "LastMessage": "provident",
      "WhenRequested": "2016-02-13T17:54:08.3668296+01:00",
      "WhenEnded": "1999-08-01T17:54:08.3668296+02:00"
    }
  ]
}
```