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
GET /api/v1/Person/{personId}/Summary?limit=91
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
      "TicketId": 752,
      "TicketStatus": 823,
      "Title": "dolorum",
      "Registered": "1998-01-09T14:45:12.9275431+01:00",
      "IconHint": "error"
    },
    {
      "TicketId": 752,
      "TicketStatus": 823,
      "Title": "dolorum",
      "Registered": "1998-01-09T14:45:12.9275431+01:00",
      "IconHint": "error"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 53,
      "DocumentId": 141,
      "Date": "2021-07-13T14:45:12.9275431+02:00",
      "Description": "Exclusive secondary concept",
      "Completed": "Completed",
      "Registered": "2004-12-31T14:45:12.9275431+01:00"
    },
    {
      "AppointmentId": 53,
      "DocumentId": 141,
      "Date": "2021-07-13T14:45:12.9275431+02:00",
      "Description": "Exclusive secondary concept",
      "Completed": "Completed",
      "Registered": "2004-12-31T14:45:12.9275431+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 294,
      "DocumentId": 118,
      "Date": "2003-12-09T14:45:12.9275431+01:00",
      "Description": "Customizable uniform encryption",
      "Completed": "Completed",
      "Registered": "2012-12-05T14:45:12.9275431+01:00"
    },
    {
      "AppointmentId": 294,
      "DocumentId": 118,
      "Date": "2003-12-09T14:45:12.9275431+01:00",
      "Description": "Customizable uniform encryption",
      "Completed": "Completed",
      "Registered": "2012-12-05T14:45:12.9275431+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 402,
      "SaleDate": "2007-07-02T14:45:12.9275431+02:00",
      "Probability": 797,
      "Heading": "nulla",
      "Amount": 22129.174,
      "Currency": "officia",
      "AmountInBaseCurrency": 2347.366,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2021-06-11T14:45:12.9275431+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 57,
      "Name": "Schamberger Inc and Sons",
      "CompanyName": "Rippin LLC",
      "FirstMessage": "ut",
      "LastMessage": "nostrum",
      "WhenRequested": "2020-03-25T14:45:12.9275431+01:00",
      "WhenEnded": "2017-03-18T14:45:12.9275431+01:00"
    }
  ]
}
```