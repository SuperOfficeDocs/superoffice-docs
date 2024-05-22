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
GET /api/v1/Person/{personId}/Summary?limit=877
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
      "TicketId": 197,
      "TicketStatus": 912,
      "Title": "distinctio",
      "Registered": "2012-02-01T12:57:42.5732274+01:00",
      "IconHint": "dolor"
    },
    {
      "TicketId": 197,
      "TicketStatus": 912,
      "Title": "distinctio",
      "Registered": "2012-02-01T12:57:42.5732274+01:00",
      "IconHint": "dolor"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 838,
      "DocumentId": 68,
      "Date": "2014-01-27T12:57:42.5732274+01:00",
      "Description": "Networked 24/7 analyzer",
      "Completed": "Completed",
      "Registered": "2002-03-07T12:57:42.5732274+01:00"
    },
    {
      "AppointmentId": 838,
      "DocumentId": 68,
      "Date": "2014-01-27T12:57:42.5732274+01:00",
      "Description": "Networked 24/7 analyzer",
      "Completed": "Completed",
      "Registered": "2002-03-07T12:57:42.5732274+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 456,
      "DocumentId": 620,
      "Date": "2004-05-03T12:57:42.5732274+02:00",
      "Description": "Compatible modular complexity",
      "Completed": "Completed",
      "Registered": "2020-08-23T12:57:42.5732274+02:00"
    },
    {
      "AppointmentId": 456,
      "DocumentId": 620,
      "Date": "2004-05-03T12:57:42.5732274+02:00",
      "Description": "Compatible modular complexity",
      "Completed": "Completed",
      "Registered": "2020-08-23T12:57:42.5732274+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 558,
      "SaleDate": "2008-03-28T12:57:42.5732274+01:00",
      "Probability": 963,
      "Heading": "maxime",
      "Amount": 16967.476,
      "Currency": "libero",
      "AmountInBaseCurrency": 6214.722,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2017-08-15T12:57:42.5732274+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 123,
      "Name": "Watsica Inc and Sons",
      "CompanyName": "Lehner-Bartell",
      "FirstMessage": "enim",
      "LastMessage": "ipsa",
      "WhenRequested": "2002-11-16T12:57:42.5732274+01:00",
      "WhenEnded": "1997-05-27T12:57:42.5732274+02:00"
    }
  ]
}
```