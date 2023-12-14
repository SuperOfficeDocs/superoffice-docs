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
GET /api/v1/Contact/{contactId}/Summary?limit=259
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
      "TicketId": 208,
      "TicketStatus": 962,
      "Title": "quae",
      "Registered": "2000-09-11T13:57:18.6534365+02:00",
      "IconHint": "eligendi"
    },
    {
      "TicketId": 208,
      "TicketStatus": 962,
      "Title": "quae",
      "Registered": "2000-09-11T13:57:18.6534365+02:00",
      "IconHint": "eligendi"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 834,
      "DocumentId": 733,
      "Date": "2011-11-25T13:57:18.6534365+01:00",
      "Description": "Balanced background installation",
      "Completed": "Completed",
      "Registered": "2017-08-14T13:57:18.6534365+02:00"
    },
    {
      "AppointmentId": 834,
      "DocumentId": 733,
      "Date": "2011-11-25T13:57:18.6534365+01:00",
      "Description": "Balanced background installation",
      "Completed": "Completed",
      "Registered": "2017-08-14T13:57:18.6534365+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 261,
      "DocumentId": 917,
      "Date": "2021-06-14T13:57:18.6534365+02:00",
      "Description": "Virtual 4th generation ability",
      "Completed": "Completed",
      "Registered": "2015-04-21T13:57:18.6534365+02:00"
    },
    {
      "AppointmentId": 261,
      "DocumentId": 917,
      "Date": "2021-06-14T13:57:18.6534365+02:00",
      "Description": "Virtual 4th generation ability",
      "Completed": "Completed",
      "Registered": "2015-04-21T13:57:18.6534365+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 239,
      "SaleDate": "2011-09-14T13:57:18.6534365+02:00",
      "Probability": 978,
      "Heading": "cumque",
      "Amount": 26949.266,
      "Currency": "a",
      "AmountInBaseCurrency": 16393.953999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2008-11-10T13:57:18.6534365+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 727,
      "Name": "Schneider-Friesen",
      "CompanyName": "Lakin-Schiller",
      "FirstMessage": "deserunt",
      "LastMessage": "quam",
      "WhenRequested": "2007-04-07T13:57:18.6534365+02:00",
      "WhenEnded": "2010-03-28T13:57:18.6534365+02:00"
    }
  ]
}
```