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
GET /api/v1/Person/{personId}/Summary?limit=7
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
      "TicketId": 270,
      "TicketStatus": 121,
      "Title": "laudantium",
      "Registered": "1999-01-16T02:38:26.1829353+01:00",
      "IconHint": "similique"
    },
    {
      "TicketId": 270,
      "TicketStatus": 121,
      "Title": "laudantium",
      "Registered": "1999-01-16T02:38:26.1829353+01:00",
      "IconHint": "similique"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 638,
      "DocumentId": 879,
      "Date": "2016-04-06T02:38:26.1829353+02:00",
      "Description": "Configurable system-worthy alliance",
      "Completed": "Completed",
      "Registered": "2014-06-17T02:38:26.1829353+02:00"
    },
    {
      "AppointmentId": 638,
      "DocumentId": 879,
      "Date": "2016-04-06T02:38:26.1829353+02:00",
      "Description": "Configurable system-worthy alliance",
      "Completed": "Completed",
      "Registered": "2014-06-17T02:38:26.1829353+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 918,
      "DocumentId": 168,
      "Date": "2002-12-18T02:38:26.1829353+01:00",
      "Description": "Virtual bifurcated info-mediaries",
      "Completed": "Completed",
      "Registered": "2019-08-20T02:38:26.1829353+02:00"
    },
    {
      "AppointmentId": 918,
      "DocumentId": 168,
      "Date": "2002-12-18T02:38:26.1829353+01:00",
      "Description": "Virtual bifurcated info-mediaries",
      "Completed": "Completed",
      "Registered": "2019-08-20T02:38:26.1829353+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 251,
      "SaleDate": "2006-09-07T02:38:26.1829353+02:00",
      "Probability": 18,
      "Heading": "totam",
      "Amount": 6252.33,
      "Currency": "dolores",
      "AmountInBaseCurrency": 827.376,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2006-08-07T02:38:26.1829353+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 732,
      "Name": "Goyette Inc and Sons",
      "CompanyName": "Franecki-Lehner",
      "FirstMessage": "sunt",
      "LastMessage": "sed",
      "WhenRequested": "1999-09-28T02:38:26.1829353+02:00",
      "WhenEnded": "2016-01-10T02:38:26.1829353+01:00"
    }
  ]
}
```