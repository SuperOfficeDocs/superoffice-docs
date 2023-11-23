---
title: GET Contact/{id}/Summary
uid: v1ContactEntity_GetContactSummary
generated: true
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
GET /api/v1/Contact/{contactId}/Summary?limit=961
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

### Response body: ContactSummary

| Property Name | Type |  Description |
|----------------|------|--------------|
| Contact | Contact | Simple Contact data. |
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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 264,
      "TicketStatus": 670,
      "Title": "totam",
      "Registered": "2022-04-07T13:38:17.2649715+02:00",
      "IconHint": "accusamus"
    },
    {
      "TicketId": 264,
      "TicketStatus": 670,
      "Title": "totam",
      "Registered": "2022-04-07T13:38:17.2649715+02:00",
      "IconHint": "accusamus"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 462,
      "DocumentId": 173,
      "Date": "2016-04-12T13:38:17.2649715+02:00",
      "Description": "Visionary leading edge parallelism",
      "Completed": "Completed",
      "Registered": "2023-09-05T13:38:17.2649715+02:00"
    },
    {
      "AppointmentId": 462,
      "DocumentId": 173,
      "Date": "2016-04-12T13:38:17.2649715+02:00",
      "Description": "Visionary leading edge parallelism",
      "Completed": "Completed",
      "Registered": "2023-09-05T13:38:17.2649715+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 985,
      "DocumentId": 873,
      "Date": "2022-03-19T13:38:17.2649715+01:00",
      "Description": "Re-contextualized holistic encoding",
      "Completed": "Completed",
      "Registered": "2006-05-29T13:38:17.2649715+02:00"
    },
    {
      "AppointmentId": 985,
      "DocumentId": 873,
      "Date": "2022-03-19T13:38:17.2649715+01:00",
      "Description": "Re-contextualized holistic encoding",
      "Completed": "Completed",
      "Registered": "2006-05-29T13:38:17.2649715+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 6,
      "SaleDate": "2000-07-04T13:38:17.2649715+02:00",
      "Probability": 963,
      "Heading": "quaerat",
      "Amount": 29152.468,
      "Currency": "placeat",
      "AmountInBaseCurrency": 8775.1999999999989,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2020-04-25T13:38:17.2649715+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 607,
      "Name": "Schmeler-Johnston",
      "CompanyName": "Jaskolski LLC",
      "FirstMessage": "nobis",
      "LastMessage": "aut",
      "WhenRequested": "2010-09-18T13:38:17.2649715+02:00",
      "WhenEnded": "2000-02-12T13:38:17.2649715+01:00"
    }
  ]
}
```