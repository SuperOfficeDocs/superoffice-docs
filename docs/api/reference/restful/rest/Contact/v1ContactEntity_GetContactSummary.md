---
title: GET Contact/{id}/Summary
uid: v1ContactEntity_GetContactSummary
---

# GET Contact/{id}/Summary

```http
GET /api/v1/Contact/{contactId}/Summary
```

Get summary of contact and its recent activity.






| Path Part | Type | Description |
|-----------|------|-------------|
| contactId | int32 | The contact id to summarize. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| limit | int32 |  Max number of items to include in summary lists. |

```http
GET /api/v1/Contact/{contactId}/Summary?limit=272
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

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Contact |  | Simple Contact data. |
| Tickets | array | Recent tickets on contact |
| Followups | array | Recent follow-ups on contact |
| Documents | array | Recent documents on contact |
| Sales | array | Recent sales on contact |
| Chats | array | Recent chats with contact |

## Sample request

```http!
GET /api/v1/Contact/{contactId}/Summary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 442,
      "TicketStatus": 72,
      "Title": "modi",
      "Registered": "2016-12-09T11:10:52.7161794+01:00",
      "IconHint": "fugit"
    },
    {
      "TicketId": 442,
      "TicketStatus": 72,
      "Title": "modi",
      "Registered": "2016-12-09T11:10:52.7161794+01:00",
      "IconHint": "fugit"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 231,
      "DocumentId": 975,
      "Date": "2005-01-24T11:10:52.7161794+01:00",
      "Description": "Progressive asynchronous info-mediaries",
      "Completed": "Completed",
      "Registered": "1996-04-20T11:10:52.7161794+02:00"
    },
    {
      "AppointmentId": 231,
      "DocumentId": 975,
      "Date": "2005-01-24T11:10:52.7161794+01:00",
      "Description": "Progressive asynchronous info-mediaries",
      "Completed": "Completed",
      "Registered": "1996-04-20T11:10:52.7161794+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 349,
      "DocumentId": 540,
      "Date": "2014-06-19T11:10:52.7161794+02:00",
      "Description": "Multi-tiered incremental matrix",
      "Completed": "Completed",
      "Registered": "2008-03-02T11:10:52.7161794+01:00"
    },
    {
      "AppointmentId": 349,
      "DocumentId": 540,
      "Date": "2014-06-19T11:10:52.7161794+02:00",
      "Description": "Multi-tiered incremental matrix",
      "Completed": "Completed",
      "Registered": "2008-03-02T11:10:52.7161794+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 126,
      "SaleDate": "2001-11-13T11:10:52.7161794+01:00",
      "Probability": 424,
      "Heading": "quibusdam",
      "Amount": 4174.488,
      "Currency": "quasi",
      "AmountInBaseCurrency": 6590.802,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "1995-05-16T11:10:52.7161794+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 943,
      "Name": "Murray-Harris",
      "CompanyName": "Waelchi, Schoen and Heathcote",
      "FirstMessage": "adipisci",
      "LastMessage": "fugiat",
      "WhenRequested": "2021-05-14T11:10:52.717146+02:00",
      "WhenEnded": "1997-01-13T11:10:52.717146+01:00"
    }
  ]
}
```