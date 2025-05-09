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
GET /api/v1/Person/{personId}/Summary?limit=851
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
      "TicketId": 541,
      "TicketStatus": 508,
      "Title": "temporibus",
      "Registered": "2012-05-17T16:32:47.6651766+02:00",
      "IconHint": "quam"
    },
    {
      "TicketId": 541,
      "TicketStatus": 508,
      "Title": "temporibus",
      "Registered": "2012-05-17T16:32:47.6651766+02:00",
      "IconHint": "quam"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 159,
      "DocumentId": 850,
      "Date": "2001-12-07T16:32:47.6651766+01:00",
      "Description": "Synergized leading edge software",
      "Completed": "Completed",
      "Registered": "2000-09-11T16:32:47.6651766+02:00"
    },
    {
      "AppointmentId": 159,
      "DocumentId": 850,
      "Date": "2001-12-07T16:32:47.6651766+01:00",
      "Description": "Synergized leading edge software",
      "Completed": "Completed",
      "Registered": "2000-09-11T16:32:47.6651766+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 518,
      "DocumentId": 521,
      "Date": "2009-02-07T16:32:47.6651766+01:00",
      "Description": "Horizontal fresh-thinking parallelism",
      "Completed": "Completed",
      "Registered": "1998-03-07T16:32:47.6651766+01:00"
    },
    {
      "AppointmentId": 518,
      "DocumentId": 521,
      "Date": "2009-02-07T16:32:47.6651766+01:00",
      "Description": "Horizontal fresh-thinking parallelism",
      "Completed": "Completed",
      "Registered": "1998-03-07T16:32:47.6651766+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 680,
      "SaleDate": "2010-05-06T16:32:47.6651766+02:00",
      "Probability": 188,
      "Heading": "ut",
      "Amount": 10683.806,
      "Currency": "asperiores",
      "AmountInBaseCurrency": 6289.938,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2021-01-18T16:32:47.6651766+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 280,
      "Name": "Pfannerstill-Reilly",
      "CompanyName": "Yundt-Casper",
      "FirstMessage": "suscipit",
      "LastMessage": "error",
      "WhenRequested": "2021-10-02T16:32:47.6651766+02:00",
      "WhenEnded": "2008-08-28T16:32:47.6651766+02:00"
    }
  ]
}
```