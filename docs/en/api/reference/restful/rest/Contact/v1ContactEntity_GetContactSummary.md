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
GET /api/v1/Contact/{contactId}/Summary?limit=788
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
      "TicketId": 869,
      "TicketStatus": 339,
      "Title": "eveniet",
      "Registered": "2015-03-23T12:01:32.8238054+01:00",
      "IconHint": "consequatur"
    },
    {
      "TicketId": 869,
      "TicketStatus": 339,
      "Title": "eveniet",
      "Registered": "2015-03-23T12:01:32.8238054+01:00",
      "IconHint": "consequatur"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 442,
      "DocumentId": 282,
      "Date": "2003-06-15T12:01:32.8238054+02:00",
      "Description": "Diverse stable array",
      "Completed": "Completed",
      "Registered": "2024-08-15T12:01:32.8238054+02:00"
    },
    {
      "AppointmentId": 442,
      "DocumentId": 282,
      "Date": "2003-06-15T12:01:32.8238054+02:00",
      "Description": "Diverse stable array",
      "Completed": "Completed",
      "Registered": "2024-08-15T12:01:32.8238054+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 736,
      "DocumentId": 613,
      "Date": "2008-10-23T12:01:32.8238054+02:00",
      "Description": "Mandatory 4th generation standardization",
      "Completed": "Completed",
      "Registered": "1999-12-28T12:01:32.8238054+01:00"
    },
    {
      "AppointmentId": 736,
      "DocumentId": 613,
      "Date": "2008-10-23T12:01:32.8238054+02:00",
      "Description": "Mandatory 4th generation standardization",
      "Completed": "Completed",
      "Registered": "1999-12-28T12:01:32.8238054+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 434,
      "SaleDate": "2007-12-10T12:01:32.8238054+01:00",
      "Probability": 325,
      "Heading": "exercitationem",
      "Amount": 19919.703999999998,
      "Currency": "dolorum",
      "AmountInBaseCurrency": 17384.298,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2023-03-04T12:01:32.8238054+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 339,
      "Name": "Kertzmann, Runolfsdottir and Johnson",
      "CompanyName": "Cronin, Bergnaum and Shields",
      "FirstMessage": "nemo",
      "LastMessage": "aut",
      "WhenRequested": "2002-07-03T12:01:32.8238054+02:00",
      "WhenEnded": "2004-08-01T12:01:32.8238054+02:00"
    }
  ]
}
```