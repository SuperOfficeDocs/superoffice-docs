---
title: GET Person/{id}/Summary
uid: v1PersonEntity_GetPersonSummary
generated: true
content_type: reference
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
GET /api/v1/Person/{personId}/Summary?limit=126
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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": null,
  "Tickets": [
    {
      "TicketId": 664,
      "TicketStatus": 723,
      "Title": "sint",
      "Registered": "2002-03-18T03:47:00.1443174+01:00",
      "IconHint": "aut"
    },
    {
      "TicketId": 664,
      "TicketStatus": 723,
      "Title": "sint",
      "Registered": "2002-03-18T03:47:00.1443174+01:00",
      "IconHint": "aut"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 534,
      "DocumentId": 751,
      "Date": "2006-11-25T03:47:00.1443174+01:00",
      "Description": "Balanced scalable throughput",
      "Completed": "Completed",
      "Registered": "2009-10-01T03:47:00.1443174+02:00"
    },
    {
      "AppointmentId": 534,
      "DocumentId": 751,
      "Date": "2006-11-25T03:47:00.1443174+01:00",
      "Description": "Balanced scalable throughput",
      "Completed": "Completed",
      "Registered": "2009-10-01T03:47:00.1443174+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 570,
      "DocumentId": 977,
      "Date": "2016-12-27T03:47:00.1443174+01:00",
      "Description": "Persevering even-keeled framework",
      "Completed": "Completed",
      "Registered": "2014-07-28T03:47:00.1443174+02:00"
    },
    {
      "AppointmentId": 570,
      "DocumentId": 977,
      "Date": "2016-12-27T03:47:00.1443174+01:00",
      "Description": "Persevering even-keeled framework",
      "Completed": "Completed",
      "Registered": "2014-07-28T03:47:00.1443174+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 365,
      "SaleDate": "2011-10-13T03:47:00.1443174+02:00",
      "Probability": 352,
      "Heading": "perferendis",
      "Amount": 7546.672,
      "Currency": "praesentium",
      "AmountInBaseCurrency": 20038.796,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2008-08-20T03:47:00.1443174+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 507,
      "Name": "Lubowitz Group",
      "CompanyName": "Nienow, Waters and Block",
      "FirstMessage": "ipsa",
      "LastMessage": "consequatur",
      "WhenRequested": "2000-07-10T03:47:00.1443174+02:00",
      "WhenEnded": "2022-07-04T03:47:00.1443174+02:00"
    }
  ]
}
```