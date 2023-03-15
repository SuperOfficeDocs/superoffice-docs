---
title: POST Agents/Contact/GetContactSummary
uid: v1ContactAgent_GetContactSummary
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 200,
  "Limit": 308
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
      "TicketId": 210,
      "TicketStatus": 206,
      "Title": "est",
      "Registered": "2001-09-06T12:15:18.6037569+02:00",
      "IconHint": "minima"
    },
    {
      "TicketId": 210,
      "TicketStatus": 206,
      "Title": "est",
      "Registered": "2001-09-06T12:15:18.6037569+02:00",
      "IconHint": "minima"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 622,
      "DocumentId": 944,
      "Date": "2013-06-12T12:15:18.6037569+02:00",
      "Description": "Inverse needs-based success",
      "Completed": "Completed",
      "Registered": "2008-05-24T12:15:18.6037569+02:00"
    },
    {
      "AppointmentId": 622,
      "DocumentId": 944,
      "Date": "2013-06-12T12:15:18.6037569+02:00",
      "Description": "Inverse needs-based success",
      "Completed": "Completed",
      "Registered": "2008-05-24T12:15:18.6037569+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 921,
      "DocumentId": 452,
      "Date": "2014-06-26T12:15:18.6037569+02:00",
      "Description": "Innovative hybrid array",
      "Completed": "Completed",
      "Registered": "2010-05-31T12:15:18.6037569+02:00"
    },
    {
      "AppointmentId": 921,
      "DocumentId": 452,
      "Date": "2014-06-26T12:15:18.6037569+02:00",
      "Description": "Innovative hybrid array",
      "Completed": "Completed",
      "Registered": "2010-05-31T12:15:18.6037569+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 766,
      "SaleDate": "2020-07-17T12:15:18.6037569+02:00",
      "Probability": 949,
      "Heading": "qui",
      "Amount": 11244.792,
      "Currency": "eveniet",
      "AmountInBaseCurrency": 22893.87,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "1998-02-02T12:15:18.6037569+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 152,
      "Name": "Shanahan Inc and Sons",
      "CompanyName": "Hermiston, Gaylord and DuBuque",
      "FirstMessage": "velit",
      "LastMessage": "magni",
      "WhenRequested": "2011-12-31T12:15:18.6037569+01:00",
      "WhenEnded": "2016-03-12T12:15:18.6037569+01:00"
    }
  ]
}
```