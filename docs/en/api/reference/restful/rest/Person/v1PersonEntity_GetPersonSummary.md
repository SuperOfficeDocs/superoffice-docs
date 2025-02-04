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
GET /api/v1/Person/{personId}/Summary?limit=684
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
      "TicketId": 691,
      "TicketStatus": 635,
      "Title": "in",
      "Registered": "1999-01-02T13:13:31.8707+01:00",
      "IconHint": "iure"
    },
    {
      "TicketId": 691,
      "TicketStatus": 635,
      "Title": "in",
      "Registered": "1999-01-02T13:13:31.8707+01:00",
      "IconHint": "iure"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 94,
      "DocumentId": 512,
      "Date": "2006-07-05T13:13:31.8707+02:00",
      "Description": "Reactive disintermediate functionalities",
      "Completed": "Completed",
      "Registered": "2000-04-04T13:13:31.8707+02:00"
    },
    {
      "AppointmentId": 94,
      "DocumentId": 512,
      "Date": "2006-07-05T13:13:31.8707+02:00",
      "Description": "Reactive disintermediate functionalities",
      "Completed": "Completed",
      "Registered": "2000-04-04T13:13:31.8707+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 378,
      "DocumentId": 399,
      "Date": "2009-01-10T13:13:31.8707+01:00",
      "Description": "Synergistic full-range installation",
      "Completed": "Completed",
      "Registered": "2002-04-01T13:13:31.8707+02:00"
    },
    {
      "AppointmentId": 378,
      "DocumentId": 399,
      "Date": "2009-01-10T13:13:31.8707+01:00",
      "Description": "Synergistic full-range installation",
      "Completed": "Completed",
      "Registered": "2002-04-01T13:13:31.8707+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 398,
      "SaleDate": "2023-08-19T13:13:31.8707+02:00",
      "Probability": 984,
      "Heading": "praesentium",
      "Amount": 29183.807999999997,
      "Currency": "et",
      "AmountInBaseCurrency": 9220.228,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2008-05-15T13:13:31.8707+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 643,
      "Name": "Hodkiewicz-Funk",
      "CompanyName": "Ruecker, Koss and Osinski",
      "FirstMessage": "nihil",
      "LastMessage": "quasi",
      "WhenRequested": "2016-10-03T13:13:31.8707+02:00",
      "WhenEnded": "2007-11-06T13:13:31.8707+01:00"
    }
  ]
}
```