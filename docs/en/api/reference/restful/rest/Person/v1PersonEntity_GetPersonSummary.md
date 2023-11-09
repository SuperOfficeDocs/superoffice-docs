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
GET /api/v1/Person/{personId}/Summary?limit=235
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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": null,
  "Tickets": [
    {
      "TicketId": 757,
      "TicketStatus": 882,
      "Title": "ipsum",
      "Registered": "2020-07-18T11:06:41.9884754+02:00",
      "IconHint": "est"
    },
    {
      "TicketId": 757,
      "TicketStatus": 882,
      "Title": "ipsum",
      "Registered": "2020-07-18T11:06:41.9884754+02:00",
      "IconHint": "est"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 660,
      "DocumentId": 136,
      "Date": "1997-01-23T11:06:41.9884754+01:00",
      "Description": "Automated 6th generation approach",
      "Completed": "Completed",
      "Registered": "1997-05-30T11:06:41.9884754+02:00"
    },
    {
      "AppointmentId": 660,
      "DocumentId": 136,
      "Date": "1997-01-23T11:06:41.9884754+01:00",
      "Description": "Automated 6th generation approach",
      "Completed": "Completed",
      "Registered": "1997-05-30T11:06:41.9884754+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 203,
      "DocumentId": 421,
      "Date": "2002-01-02T11:06:41.9884754+01:00",
      "Description": "Front-line foreground contingency",
      "Completed": "Completed",
      "Registered": "2011-09-06T11:06:41.9884754+02:00"
    },
    {
      "AppointmentId": 203,
      "DocumentId": 421,
      "Date": "2002-01-02T11:06:41.9884754+01:00",
      "Description": "Front-line foreground contingency",
      "Completed": "Completed",
      "Registered": "2011-09-06T11:06:41.9884754+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 499,
      "SaleDate": "2002-09-15T11:06:41.9884754+02:00",
      "Probability": 295,
      "Heading": "maiores",
      "Amount": 17359.226,
      "Currency": "minima",
      "AmountInBaseCurrency": 216.24599999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2004-09-16T11:06:41.9884754+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 638,
      "Name": "Reynolds-Bailey",
      "CompanyName": "Heaney, Bernier and Dooley",
      "FirstMessage": "voluptas",
      "LastMessage": "facere",
      "WhenRequested": "1998-08-17T11:06:41.9884754+02:00",
      "WhenEnded": "2021-01-29T11:06:41.9884754+01:00"
    }
  ]
}
```