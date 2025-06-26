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
GET /api/v1/Contact/{contactId}/Summary?limit=990
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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 224,
      "TicketStatus": 318,
      "Title": "quia",
      "Registered": "2021-08-07T03:45:28.2171945+02:00",
      "IconHint": "odio"
    },
    {
      "TicketId": 224,
      "TicketStatus": 318,
      "Title": "quia",
      "Registered": "2021-08-07T03:45:28.2171945+02:00",
      "IconHint": "odio"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 242,
      "DocumentId": 479,
      "Date": "2002-12-27T03:45:28.2171945+01:00",
      "Description": "Customer-focused logistical website",
      "Completed": "Completed",
      "Registered": "2008-12-30T03:45:28.2171945+01:00"
    },
    {
      "AppointmentId": 242,
      "DocumentId": 479,
      "Date": "2002-12-27T03:45:28.2171945+01:00",
      "Description": "Customer-focused logistical website",
      "Completed": "Completed",
      "Registered": "2008-12-30T03:45:28.2171945+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 471,
      "DocumentId": 884,
      "Date": "2004-07-19T03:45:28.2171945+02:00",
      "Description": "Object-based leading edge solution",
      "Completed": "Completed",
      "Registered": "2019-04-18T03:45:28.2171945+02:00"
    },
    {
      "AppointmentId": 471,
      "DocumentId": 884,
      "Date": "2004-07-19T03:45:28.2171945+02:00",
      "Description": "Object-based leading edge solution",
      "Completed": "Completed",
      "Registered": "2019-04-18T03:45:28.2171945+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 615,
      "SaleDate": "2007-02-13T03:45:28.2171945+01:00",
      "Probability": 865,
      "Heading": "laboriosam",
      "Amount": 12604.948,
      "Currency": "quam",
      "AmountInBaseCurrency": 2732.848,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2006-01-05T03:45:28.2171945+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 349,
      "Name": "Deckow LLC",
      "CompanyName": "Schroeder Group",
      "FirstMessage": "harum",
      "LastMessage": "reprehenderit",
      "WhenRequested": "2000-03-09T03:45:28.2171945+01:00",
      "WhenEnded": "2006-01-15T03:45:28.2171945+01:00"
    }
  ]
}
```