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
GET /api/v1/Contact/{contactId}/Summary?limit=646
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
      "TicketId": 504,
      "TicketStatus": 683,
      "Title": "asperiores",
      "Registered": "2017-05-19T17:54:08.1168303+02:00",
      "IconHint": "nihil"
    },
    {
      "TicketId": 504,
      "TicketStatus": 683,
      "Title": "asperiores",
      "Registered": "2017-05-19T17:54:08.1168303+02:00",
      "IconHint": "nihil"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 884,
      "DocumentId": 589,
      "Date": "2015-12-29T17:54:08.1168303+01:00",
      "Description": "Mandatory multimedia projection",
      "Completed": "Completed",
      "Registered": "2003-01-11T17:54:08.1168303+01:00"
    },
    {
      "AppointmentId": 884,
      "DocumentId": 589,
      "Date": "2015-12-29T17:54:08.1168303+01:00",
      "Description": "Mandatory multimedia projection",
      "Completed": "Completed",
      "Registered": "2003-01-11T17:54:08.1168303+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 989,
      "DocumentId": 36,
      "Date": "2002-11-10T17:54:08.1168303+01:00",
      "Description": "Switchable empowering process improvement",
      "Completed": "Completed",
      "Registered": "2013-07-26T17:54:08.1168303+02:00"
    },
    {
      "AppointmentId": 989,
      "DocumentId": 36,
      "Date": "2002-11-10T17:54:08.1168303+01:00",
      "Description": "Switchable empowering process improvement",
      "Completed": "Completed",
      "Registered": "2013-07-26T17:54:08.1168303+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 375,
      "SaleDate": "2024-03-17T17:54:08.1168303+01:00",
      "Probability": 306,
      "Heading": "in",
      "Amount": 9890.904,
      "Currency": "autem",
      "AmountInBaseCurrency": 18.804,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2007-12-13T17:54:08.1168303+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 306,
      "Name": "Terry, Morar and Kautzer",
      "CompanyName": "Koch, Schoen and Toy",
      "FirstMessage": "excepturi",
      "LastMessage": "aut",
      "WhenRequested": "2022-06-14T17:54:08.1168303+02:00",
      "WhenEnded": "1999-11-21T17:54:08.1168303+01:00"
    }
  ]
}
```