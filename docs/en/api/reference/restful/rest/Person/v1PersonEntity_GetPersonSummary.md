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
GET /api/v1/Person/{personId}/Summary?limit=657
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
      "TicketId": 674,
      "TicketStatus": 758,
      "Title": "commodi",
      "Registered": "2013-05-21T04:02:06.6816417+02:00",
      "IconHint": "facere"
    },
    {
      "TicketId": 674,
      "TicketStatus": 758,
      "Title": "commodi",
      "Registered": "2013-05-21T04:02:06.6816417+02:00",
      "IconHint": "facere"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 110,
      "DocumentId": 735,
      "Date": "2010-10-11T04:02:06.6816417+02:00",
      "Description": "Open-architected impactful matrices",
      "Completed": "Completed",
      "Registered": "2009-01-20T04:02:06.6816417+01:00"
    },
    {
      "AppointmentId": 110,
      "DocumentId": 735,
      "Date": "2010-10-11T04:02:06.6816417+02:00",
      "Description": "Open-architected impactful matrices",
      "Completed": "Completed",
      "Registered": "2009-01-20T04:02:06.6816417+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 83,
      "DocumentId": 869,
      "Date": "2015-07-10T04:02:06.6816417+02:00",
      "Description": "Stand-alone reciprocal adapter",
      "Completed": "Completed",
      "Registered": "1998-09-04T04:02:06.6816417+02:00"
    },
    {
      "AppointmentId": 83,
      "DocumentId": 869,
      "Date": "2015-07-10T04:02:06.6816417+02:00",
      "Description": "Stand-alone reciprocal adapter",
      "Completed": "Completed",
      "Registered": "1998-09-04T04:02:06.6816417+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 199,
      "SaleDate": "2013-01-12T04:02:06.6816417+01:00",
      "Probability": 554,
      "Heading": "non",
      "Amount": 6788.244,
      "Currency": "consequatur",
      "AmountInBaseCurrency": 14457.142,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2005-12-18T04:02:06.6816417+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 426,
      "Name": "Vandervort-Lakin",
      "CompanyName": "Doyle-Hansen",
      "FirstMessage": "ex",
      "LastMessage": "reprehenderit",
      "WhenRequested": "2001-08-31T04:02:06.6816417+02:00",
      "WhenEnded": "2023-01-24T04:02:06.6816417+01:00"
    }
  ]
}
```