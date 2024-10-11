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
GET /api/v1/Person/{personId}/Summary?limit=381
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
      "TicketId": 70,
      "TicketStatus": 74,
      "Title": "ipsam",
      "Registered": "2000-09-20T03:44:57.4378894+02:00",
      "IconHint": "eos"
    },
    {
      "TicketId": 70,
      "TicketStatus": 74,
      "Title": "ipsam",
      "Registered": "2000-09-20T03:44:57.4378894+02:00",
      "IconHint": "eos"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 900,
      "DocumentId": 219,
      "Date": "2008-04-03T03:44:57.4378894+02:00",
      "Description": "Expanded value-added orchestration",
      "Completed": "Completed",
      "Registered": "2022-12-27T03:44:57.4378894+01:00"
    },
    {
      "AppointmentId": 900,
      "DocumentId": 219,
      "Date": "2008-04-03T03:44:57.4378894+02:00",
      "Description": "Expanded value-added orchestration",
      "Completed": "Completed",
      "Registered": "2022-12-27T03:44:57.4378894+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 528,
      "DocumentId": 512,
      "Date": "2010-09-22T03:44:57.4378894+02:00",
      "Description": "Focused even-keeled installation",
      "Completed": "Completed",
      "Registered": "2000-09-26T03:44:57.4378894+02:00"
    },
    {
      "AppointmentId": 528,
      "DocumentId": 512,
      "Date": "2010-09-22T03:44:57.4378894+02:00",
      "Description": "Focused even-keeled installation",
      "Completed": "Completed",
      "Registered": "2000-09-26T03:44:57.4378894+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 513,
      "SaleDate": "2009-08-06T03:44:57.4378894+02:00",
      "Probability": 520,
      "Heading": "repudiandae",
      "Amount": 21386.416,
      "Currency": "quos",
      "AmountInBaseCurrency": 19452.737999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2023-07-27T03:44:57.4378894+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 706,
      "Name": "Medhurst, Raynor and Bailey",
      "CompanyName": "Rutherford Group",
      "FirstMessage": "hic",
      "LastMessage": "iusto",
      "WhenRequested": "2001-11-07T03:44:57.4378894+01:00",
      "WhenEnded": "1997-07-06T03:44:57.4378894+02:00"
    }
  ]
}
```