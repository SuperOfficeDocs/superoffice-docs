---
title: GET Person/{id}/Summary
uid: v1PersonEntity_GetPersonSummary
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
GET /api/v1/Person/{personId}/Summary?limit=721
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
      "TicketId": 579,
      "TicketStatus": 538,
      "Title": "deleniti",
      "Registered": "2004-02-19T15:29:29.9021992+01:00",
      "IconHint": "voluptatem"
    },
    {
      "TicketId": 579,
      "TicketStatus": 538,
      "Title": "deleniti",
      "Registered": "2004-02-19T15:29:29.9021992+01:00",
      "IconHint": "voluptatem"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 345,
      "DocumentId": 195,
      "Date": "2005-05-12T15:29:29.9021992+02:00",
      "Description": "Synergized explicit website",
      "Completed": "Completed",
      "Registered": "2017-05-01T15:29:29.9021992+02:00"
    },
    {
      "AppointmentId": 345,
      "DocumentId": 195,
      "Date": "2005-05-12T15:29:29.9021992+02:00",
      "Description": "Synergized explicit website",
      "Completed": "Completed",
      "Registered": "2017-05-01T15:29:29.9021992+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 77,
      "DocumentId": 852,
      "Date": "1996-10-17T15:29:29.9021992+02:00",
      "Description": "Upgradable upward-trending website",
      "Completed": "Completed",
      "Registered": "2014-06-10T15:29:29.9021992+02:00"
    },
    {
      "AppointmentId": 77,
      "DocumentId": 852,
      "Date": "1996-10-17T15:29:29.9021992+02:00",
      "Description": "Upgradable upward-trending website",
      "Completed": "Completed",
      "Registered": "2014-06-10T15:29:29.9021992+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 424,
      "SaleDate": "2011-05-05T15:29:29.9021992+02:00",
      "Probability": 450,
      "Heading": "officiis",
      "Amount": 27325.345999999998,
      "Currency": "et",
      "AmountInBaseCurrency": 3077.5879999999997,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2021-10-08T15:29:29.9021992+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 462,
      "Name": "Schmidt, Kuhn and Baumbach",
      "CompanyName": "Stroman Group",
      "FirstMessage": "nesciunt",
      "LastMessage": "magnam",
      "WhenRequested": "1996-07-03T15:29:29.9026969+02:00",
      "WhenEnded": "2022-11-13T15:29:29.9026969+01:00"
    }
  ]
}
```