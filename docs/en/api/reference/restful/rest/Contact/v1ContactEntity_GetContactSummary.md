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
GET /api/v1/Contact/{contactId}/Summary?limit=283
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 244,
      "TicketStatus": 778,
      "Title": "magnam",
      "Registered": "2017-12-13T15:29:29.5792028+01:00",
      "IconHint": "maiores"
    },
    {
      "TicketId": 244,
      "TicketStatus": 778,
      "Title": "magnam",
      "Registered": "2017-12-13T15:29:29.5792028+01:00",
      "IconHint": "maiores"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 985,
      "DocumentId": 157,
      "Date": "2006-04-01T15:29:29.5792028+02:00",
      "Description": "Business-focused system-worthy access",
      "Completed": "Completed",
      "Registered": "2006-03-29T15:29:29.5792028+02:00"
    },
    {
      "AppointmentId": 985,
      "DocumentId": 157,
      "Date": "2006-04-01T15:29:29.5792028+02:00",
      "Description": "Business-focused system-worthy access",
      "Completed": "Completed",
      "Registered": "2006-03-29T15:29:29.5792028+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 999,
      "DocumentId": 272,
      "Date": "2020-02-10T15:29:29.5792028+01:00",
      "Description": "Object-based explicit conglomeration",
      "Completed": "Completed",
      "Registered": "2001-06-29T15:29:29.5792028+02:00"
    },
    {
      "AppointmentId": 999,
      "DocumentId": 272,
      "Date": "2020-02-10T15:29:29.5792028+01:00",
      "Description": "Object-based explicit conglomeration",
      "Completed": "Completed",
      "Registered": "2001-06-29T15:29:29.5792028+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 450,
      "SaleDate": "2022-09-29T15:29:29.5792028+02:00",
      "Probability": 930,
      "Heading": "molestias",
      "Amount": 26783.164,
      "Currency": "odio",
      "AmountInBaseCurrency": 22865.664,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2001-08-29T15:29:29.5797043+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 919,
      "Name": "Jakubowski, McClure and Wunsch",
      "CompanyName": "Franecki-Nicolas",
      "FirstMessage": "qui",
      "LastMessage": "enim",
      "WhenRequested": "2015-04-24T15:29:29.5797043+02:00",
      "WhenEnded": "2008-03-15T15:29:29.5797043+01:00"
    }
  ]
}
```