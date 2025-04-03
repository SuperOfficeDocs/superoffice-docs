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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 565,
  "Limit": 126
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
      "TicketId": 343,
      "TicketStatus": 60,
      "Title": "officia",
      "Registered": "2014-06-17T14:28:21.6647824+02:00",
      "IconHint": "doloremque"
    },
    {
      "TicketId": 343,
      "TicketStatus": 60,
      "Title": "officia",
      "Registered": "2014-06-17T14:28:21.6647824+02:00",
      "IconHint": "doloremque"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 558,
      "DocumentId": 537,
      "Date": "2001-05-24T14:28:21.6647824+02:00",
      "Description": "Sharable value-added toolset",
      "Completed": "Completed",
      "Registered": "2013-10-03T14:28:21.6647824+02:00"
    },
    {
      "AppointmentId": 558,
      "DocumentId": 537,
      "Date": "2001-05-24T14:28:21.6647824+02:00",
      "Description": "Sharable value-added toolset",
      "Completed": "Completed",
      "Registered": "2013-10-03T14:28:21.6647824+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 758,
      "DocumentId": 814,
      "Date": "2000-12-21T14:28:21.6647824+01:00",
      "Description": "Reduced analyzing intranet",
      "Completed": "Completed",
      "Registered": "2022-11-05T14:28:21.6647824+01:00"
    },
    {
      "AppointmentId": 758,
      "DocumentId": 814,
      "Date": "2000-12-21T14:28:21.6647824+01:00",
      "Description": "Reduced analyzing intranet",
      "Completed": "Completed",
      "Registered": "2022-11-05T14:28:21.6647824+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 152,
      "SaleDate": "2000-02-04T14:28:21.6647824+01:00",
      "Probability": 23,
      "Heading": "qui",
      "Amount": 21637.136,
      "Currency": "non",
      "AmountInBaseCurrency": 2676.4359999999997,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2001-09-30T14:28:21.6647824+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 444,
      "Name": "Kautzer, Rippin and Baumbach",
      "CompanyName": "Macejkovic LLC",
      "FirstMessage": "ea",
      "LastMessage": "quam",
      "WhenRequested": "2023-11-02T14:28:21.6647824+01:00",
      "WhenEnded": "2002-01-14T14:28:21.6647824+01:00"
    }
  ]
}
```