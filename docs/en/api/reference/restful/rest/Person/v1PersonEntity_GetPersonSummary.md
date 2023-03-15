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
GET /api/v1/Person/{personId}/Summary?limit=112
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
      "TicketId": 382,
      "TicketStatus": 2,
      "Title": "voluptatem",
      "Registered": "1999-03-29T12:15:27.0976335+02:00",
      "IconHint": "quia"
    },
    {
      "TicketId": 382,
      "TicketStatus": 2,
      "Title": "voluptatem",
      "Registered": "1999-03-29T12:15:27.0976335+02:00",
      "IconHint": "quia"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 762,
      "DocumentId": 275,
      "Date": "2000-09-27T12:15:27.0976335+02:00",
      "Description": "Upgradable global open system",
      "Completed": "Completed",
      "Registered": "2016-04-29T12:15:27.0976335+02:00"
    },
    {
      "AppointmentId": 762,
      "DocumentId": 275,
      "Date": "2000-09-27T12:15:27.0976335+02:00",
      "Description": "Upgradable global open system",
      "Completed": "Completed",
      "Registered": "2016-04-29T12:15:27.0976335+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 20,
      "DocumentId": 310,
      "Date": "2013-09-24T12:15:27.0976335+02:00",
      "Description": "Cross-group bifurcated alliance",
      "Completed": "Completed",
      "Registered": "2005-07-24T12:15:27.0976335+02:00"
    },
    {
      "AppointmentId": 20,
      "DocumentId": 310,
      "Date": "2013-09-24T12:15:27.0976335+02:00",
      "Description": "Cross-group bifurcated alliance",
      "Completed": "Completed",
      "Registered": "2005-07-24T12:15:27.0976335+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 993,
      "SaleDate": "2004-01-17T12:15:27.0976335+01:00",
      "Probability": 479,
      "Heading": "sint",
      "Amount": 23420.381999999998,
      "Currency": "impedit",
      "AmountInBaseCurrency": 9480.35,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2008-09-15T12:15:27.0976335+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 589,
      "Name": "Keeling, Schulist and Schneider",
      "CompanyName": "Halvorson Group",
      "FirstMessage": "et",
      "LastMessage": "earum",
      "WhenRequested": "2013-12-07T12:15:27.0976335+01:00",
      "WhenEnded": "2003-11-30T12:15:27.0976335+01:00"
    }
  ]
}
```