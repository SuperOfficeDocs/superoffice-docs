---
title: POST Agents/Contact/GetContactSummary
uid: v1ContactAgent_GetContactSummary
generated: true
---

# POST Agents/Contact/GetContactSummary

```http
POST /api/v1/Agents/Contact/GetContactSummary
```

Get summary of contact and its recent activity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactSummary?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

ContactId, Limit 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |
| Limit | Integer |  |

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
POST /api/v1/Agents/Contact/GetContactSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 837,
  "Limit": 539
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 908,
      "TicketStatus": 199,
      "Title": "pariatur",
      "Registered": "2023-02-01T14:13:39.891097+01:00",
      "IconHint": "sit"
    },
    {
      "TicketId": 908,
      "TicketStatus": 199,
      "Title": "pariatur",
      "Registered": "2023-02-01T14:13:39.891097+01:00",
      "IconHint": "sit"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 23,
      "DocumentId": 1000,
      "Date": "2007-01-21T14:13:39.891097+01:00",
      "Description": "Team-oriented holistic success",
      "Completed": "Completed",
      "Registered": "2006-03-27T14:13:39.891097+02:00"
    },
    {
      "AppointmentId": 23,
      "DocumentId": 1000,
      "Date": "2007-01-21T14:13:39.891097+01:00",
      "Description": "Team-oriented holistic success",
      "Completed": "Completed",
      "Registered": "2006-03-27T14:13:39.891097+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 408,
      "DocumentId": 757,
      "Date": "2005-02-15T14:13:39.891097+01:00",
      "Description": "Reduced foreground workforce",
      "Completed": "Completed",
      "Registered": "2023-08-14T14:13:39.891097+02:00"
    },
    {
      "AppointmentId": 408,
      "DocumentId": 757,
      "Date": "2005-02-15T14:13:39.891097+01:00",
      "Description": "Reduced foreground workforce",
      "Completed": "Completed",
      "Registered": "2023-08-14T14:13:39.891097+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 833,
      "SaleDate": "2010-12-15T14:13:39.891097+01:00",
      "Probability": 301,
      "Heading": "harum",
      "Amount": 2873.8779999999997,
      "Currency": "est",
      "AmountInBaseCurrency": 10417.416,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2013-09-18T14:13:39.891097+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 90,
      "Name": "Prohaska LLC",
      "CompanyName": "Johns Group",
      "FirstMessage": "nihil",
      "LastMessage": "dolores",
      "WhenRequested": "2012-05-09T14:13:39.891097+02:00",
      "WhenEnded": "2025-01-17T14:13:39.891097+01:00"
    }
  ]
}
```