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
GET /api/v1/Person/{personId}/Summary?limit=492
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
      "TicketId": 265,
      "TicketStatus": 865,
      "Title": "qui",
      "Registered": "2009-08-28T03:40:55.8980286+02:00",
      "IconHint": "sit"
    },
    {
      "TicketId": 265,
      "TicketStatus": 865,
      "Title": "qui",
      "Registered": "2009-08-28T03:40:55.8980286+02:00",
      "IconHint": "sit"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 710,
      "DocumentId": 892,
      "Date": "2023-11-23T03:40:55.8980286+01:00",
      "Description": "Upgradable cohesive success",
      "Completed": "Completed",
      "Registered": "2024-05-05T03:40:55.8980286+02:00"
    },
    {
      "AppointmentId": 710,
      "DocumentId": 892,
      "Date": "2023-11-23T03:40:55.8980286+01:00",
      "Description": "Upgradable cohesive success",
      "Completed": "Completed",
      "Registered": "2024-05-05T03:40:55.8980286+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 206,
      "DocumentId": 134,
      "Date": "2013-05-17T03:40:55.8980286+02:00",
      "Description": "Upgradable reciprocal secured line",
      "Completed": "Completed",
      "Registered": "2018-08-07T03:40:55.8980286+02:00"
    },
    {
      "AppointmentId": 206,
      "DocumentId": 134,
      "Date": "2013-05-17T03:40:55.8980286+02:00",
      "Description": "Upgradable reciprocal secured line",
      "Completed": "Completed",
      "Registered": "2018-08-07T03:40:55.8980286+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 873,
      "SaleDate": "2012-08-26T03:40:55.8980286+02:00",
      "Probability": 944,
      "Heading": "natus",
      "Amount": 20856.77,
      "Currency": "cumque",
      "AmountInBaseCurrency": 12846.266,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2006-09-07T03:40:55.8980286+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 206,
      "Name": "Romaguera LLC",
      "CompanyName": "Vandervort LLC",
      "FirstMessage": "sit",
      "LastMessage": "rerum",
      "WhenRequested": "2007-09-06T03:40:55.8980286+02:00",
      "WhenEnded": "2023-06-05T03:40:55.8980286+02:00"
    }
  ]
}
```