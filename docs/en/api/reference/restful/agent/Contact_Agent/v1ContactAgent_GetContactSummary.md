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
  "ContactId": 219,
  "Limit": 920
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
      "TicketId": 595,
      "TicketStatus": 87,
      "Title": "architecto",
      "Registered": "2013-05-07T03:45:23.2173332+02:00",
      "IconHint": "maiores"
    },
    {
      "TicketId": 595,
      "TicketStatus": 87,
      "Title": "architecto",
      "Registered": "2013-05-07T03:45:23.2173332+02:00",
      "IconHint": "maiores"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 702,
      "DocumentId": 164,
      "Date": "2022-02-26T03:45:23.2173332+01:00",
      "Description": "Ergonomic cohesive architecture",
      "Completed": "Completed",
      "Registered": "2018-03-12T03:45:23.2173332+01:00"
    },
    {
      "AppointmentId": 702,
      "DocumentId": 164,
      "Date": "2022-02-26T03:45:23.2173332+01:00",
      "Description": "Ergonomic cohesive architecture",
      "Completed": "Completed",
      "Registered": "2018-03-12T03:45:23.2173332+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 769,
      "DocumentId": 839,
      "Date": "2016-11-01T03:45:23.2173332+01:00",
      "Description": "Multi-channelled grid-enabled forecast",
      "Completed": "Completed",
      "Registered": "2023-10-23T03:45:23.2173332+02:00"
    },
    {
      "AppointmentId": 769,
      "DocumentId": 839,
      "Date": "2016-11-01T03:45:23.2173332+01:00",
      "Description": "Multi-channelled grid-enabled forecast",
      "Completed": "Completed",
      "Registered": "2023-10-23T03:45:23.2173332+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 944,
      "SaleDate": "2009-08-21T03:45:23.2173332+02:00",
      "Probability": 672,
      "Heading": "et",
      "Amount": 18117.654,
      "Currency": "est",
      "AmountInBaseCurrency": 21486.703999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2004-06-27T03:45:23.2173332+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 910,
      "Name": "Predovic-Dicki",
      "CompanyName": "Schaefer Group",
      "FirstMessage": "saepe",
      "LastMessage": "vel",
      "WhenRequested": "2015-03-31T03:45:23.2173332+02:00",
      "WhenEnded": "2016-07-05T03:45:23.2173332+02:00"
    }
  ]
}
```