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
GET /api/v1/Person/{personId}/Summary?limit=113
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
      "TicketId": 141,
      "TicketStatus": 253,
      "Title": "sapiente",
      "Registered": "2018-08-06T14:32:11.6304179+02:00",
      "IconHint": "voluptatum"
    },
    {
      "TicketId": 141,
      "TicketStatus": 253,
      "Title": "sapiente",
      "Registered": "2018-08-06T14:32:11.6304179+02:00",
      "IconHint": "voluptatum"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 423,
      "DocumentId": 121,
      "Date": "2002-07-09T14:32:11.6304179+02:00",
      "Description": "Diverse bottom-line contingency",
      "Completed": "Completed",
      "Registered": "2008-02-03T14:32:11.6304179+01:00"
    },
    {
      "AppointmentId": 423,
      "DocumentId": 121,
      "Date": "2002-07-09T14:32:11.6304179+02:00",
      "Description": "Diverse bottom-line contingency",
      "Completed": "Completed",
      "Registered": "2008-02-03T14:32:11.6304179+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 950,
      "DocumentId": 213,
      "Date": "2015-11-07T14:32:11.6304179+01:00",
      "Description": "Multi-channelled encompassing standardization",
      "Completed": "Completed",
      "Registered": "2004-09-23T14:32:11.6304179+02:00"
    },
    {
      "AppointmentId": 950,
      "DocumentId": 213,
      "Date": "2015-11-07T14:32:11.6304179+01:00",
      "Description": "Multi-channelled encompassing standardization",
      "Completed": "Completed",
      "Registered": "2004-09-23T14:32:11.6304179+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 303,
      "SaleDate": "2008-07-31T14:32:11.6304179+02:00",
      "Probability": 810,
      "Heading": "voluptatem",
      "Amount": 21204.644,
      "Currency": "voluptatem",
      "AmountInBaseCurrency": 20722.007999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2020-12-08T14:32:11.6304179+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 863,
      "Name": "Weimann-Prosacco",
      "CompanyName": "Gutmann-Romaguera",
      "FirstMessage": "natus",
      "LastMessage": "impedit",
      "WhenRequested": "2006-02-11T14:32:11.6304179+01:00",
      "WhenEnded": "2009-01-02T14:32:11.6304179+01:00"
    }
  ]
}
```