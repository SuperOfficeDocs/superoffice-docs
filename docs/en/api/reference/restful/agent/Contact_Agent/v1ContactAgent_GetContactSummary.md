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
  "ContactId": 882,
  "Limit": 529
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
      "TicketId": 633,
      "TicketStatus": 263,
      "Title": "laboriosam",
      "Registered": "2001-08-26T13:14:05.710145+02:00",
      "IconHint": "numquam"
    },
    {
      "TicketId": 633,
      "TicketStatus": 263,
      "Title": "laboriosam",
      "Registered": "2001-08-26T13:14:05.710145+02:00",
      "IconHint": "numquam"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 463,
      "DocumentId": 84,
      "Date": "2024-04-20T13:14:05.710145+02:00",
      "Description": "Profound bi-directional installation",
      "Completed": "Completed",
      "Registered": "2019-11-10T13:14:05.710145+01:00"
    },
    {
      "AppointmentId": 463,
      "DocumentId": 84,
      "Date": "2024-04-20T13:14:05.710145+02:00",
      "Description": "Profound bi-directional installation",
      "Completed": "Completed",
      "Registered": "2019-11-10T13:14:05.710145+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 443,
      "DocumentId": 499,
      "Date": "2007-04-17T13:14:05.710145+02:00",
      "Description": "Total holistic forecast",
      "Completed": "Completed",
      "Registered": "2012-12-15T13:14:05.710145+01:00"
    },
    {
      "AppointmentId": 443,
      "DocumentId": 499,
      "Date": "2007-04-17T13:14:05.710145+02:00",
      "Description": "Total holistic forecast",
      "Completed": "Completed",
      "Registered": "2012-12-15T13:14:05.710145+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 590,
      "SaleDate": "2007-12-11T13:14:05.710145+01:00",
      "Probability": 584,
      "Heading": "nam",
      "Amount": 3177.8759999999997,
      "Currency": "dolor",
      "AmountInBaseCurrency": 25325.854,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2003-06-10T13:14:05.710145+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 484,
      "Name": "Bashirian-Bailey",
      "CompanyName": "Sawayn, Funk and Erdman",
      "FirstMessage": "natus",
      "LastMessage": "et",
      "WhenRequested": "2014-03-28T13:14:05.710145+01:00",
      "WhenEnded": "2024-10-17T13:14:05.710145+02:00"
    }
  ]
}
```