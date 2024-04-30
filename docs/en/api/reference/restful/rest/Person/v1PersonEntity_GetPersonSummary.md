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
GET /api/v1/Person/{personId}/Summary?limit=581
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
      "TicketId": 255,
      "TicketStatus": 141,
      "Title": "qui",
      "Registered": "2008-06-30T11:44:42.1171231+02:00",
      "IconHint": "iure"
    },
    {
      "TicketId": 255,
      "TicketStatus": 141,
      "Title": "qui",
      "Registered": "2008-06-30T11:44:42.1171231+02:00",
      "IconHint": "iure"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 58,
      "DocumentId": 735,
      "Date": "2017-06-03T11:44:42.1171231+02:00",
      "Description": "Business-focused tertiary data-warehouse",
      "Completed": "Completed",
      "Registered": "2002-05-22T11:44:42.1171231+02:00"
    },
    {
      "AppointmentId": 58,
      "DocumentId": 735,
      "Date": "2017-06-03T11:44:42.1171231+02:00",
      "Description": "Business-focused tertiary data-warehouse",
      "Completed": "Completed",
      "Registered": "2002-05-22T11:44:42.1171231+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 76,
      "DocumentId": 543,
      "Date": "2020-09-22T11:44:42.1171231+02:00",
      "Description": "Streamlined even-keeled algorithm",
      "Completed": "Completed",
      "Registered": "2007-07-09T11:44:42.1171231+02:00"
    },
    {
      "AppointmentId": 76,
      "DocumentId": 543,
      "Date": "2020-09-22T11:44:42.1171231+02:00",
      "Description": "Streamlined even-keeled algorithm",
      "Completed": "Completed",
      "Registered": "2007-07-09T11:44:42.1171231+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 737,
      "SaleDate": "2008-02-26T11:44:42.1171231+01:00",
      "Probability": 603,
      "Heading": "qui",
      "Amount": 5064.544,
      "Currency": "exercitationem",
      "AmountInBaseCurrency": 22339.152,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2018-11-06T11:44:42.1171231+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 463,
      "Name": "Frami, Bechtelar and Macejkovic",
      "CompanyName": "Leannon Group",
      "FirstMessage": "aperiam",
      "LastMessage": "repellat",
      "WhenRequested": "2018-12-28T11:44:42.1171231+01:00",
      "WhenEnded": "2013-01-05T11:44:42.1171231+01:00"
    }
  ]
}
```