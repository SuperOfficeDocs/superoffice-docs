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
GET /api/v1/Person/{personId}/Summary?limit=936
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
      "TicketId": 754,
      "TicketStatus": 160,
      "Title": "ut",
      "Registered": "1998-08-09T13:28:31.8198338+02:00",
      "IconHint": "sint"
    },
    {
      "TicketId": 754,
      "TicketStatus": 160,
      "Title": "ut",
      "Registered": "1998-08-09T13:28:31.8198338+02:00",
      "IconHint": "sint"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 675,
      "DocumentId": 606,
      "Date": "2012-07-15T13:28:31.8198338+02:00",
      "Description": "Distributed secondary knowledge user",
      "Completed": "Completed",
      "Registered": "2006-09-22T13:28:31.8198338+02:00"
    },
    {
      "AppointmentId": 675,
      "DocumentId": 606,
      "Date": "2012-07-15T13:28:31.8198338+02:00",
      "Description": "Distributed secondary knowledge user",
      "Completed": "Completed",
      "Registered": "2006-09-22T13:28:31.8198338+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 32,
      "DocumentId": 199,
      "Date": "2018-10-17T13:28:31.8198338+02:00",
      "Description": "Switchable fault-tolerant interface",
      "Completed": "Completed",
      "Registered": "2000-04-14T13:28:31.8198338+02:00"
    },
    {
      "AppointmentId": 32,
      "DocumentId": 199,
      "Date": "2018-10-17T13:28:31.8198338+02:00",
      "Description": "Switchable fault-tolerant interface",
      "Completed": "Completed",
      "Registered": "2000-04-14T13:28:31.8198338+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 128,
      "SaleDate": "2016-09-30T13:28:31.8198338+02:00",
      "Probability": 574,
      "Heading": "dolorem",
      "Amount": 7593.682,
      "Currency": "accusantium",
      "AmountInBaseCurrency": 26798.834,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2021-12-17T13:28:31.8198338+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 529,
      "Name": "Kuhn-Pacocha",
      "CompanyName": "Krajcik, Luettgen and Batz",
      "FirstMessage": "veritatis",
      "LastMessage": "ut",
      "WhenRequested": "2001-07-07T13:28:31.8198338+02:00",
      "WhenEnded": "2000-10-09T13:28:31.8198338+02:00"
    }
  ]
}
```