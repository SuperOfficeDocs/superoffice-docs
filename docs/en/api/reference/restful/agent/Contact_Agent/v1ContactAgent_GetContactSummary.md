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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 864,
  "Limit": 225
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
      "TicketId": 907,
      "TicketStatus": 59,
      "Title": "cumque",
      "Registered": "2006-11-25T10:17:55.3008958+01:00",
      "IconHint": "dignissimos"
    },
    {
      "TicketId": 907,
      "TicketStatus": 59,
      "Title": "cumque",
      "Registered": "2006-11-25T10:17:55.3008958+01:00",
      "IconHint": "dignissimos"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 256,
      "DocumentId": 805,
      "Date": "2013-10-02T10:17:55.3008958+02:00",
      "Description": "User-friendly fault-tolerant capability",
      "Completed": "Completed",
      "Registered": "2019-05-13T10:17:55.3008958+02:00"
    },
    {
      "AppointmentId": 256,
      "DocumentId": 805,
      "Date": "2013-10-02T10:17:55.3008958+02:00",
      "Description": "User-friendly fault-tolerant capability",
      "Completed": "Completed",
      "Registered": "2019-05-13T10:17:55.3008958+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 839,
      "DocumentId": 780,
      "Date": "2012-04-15T10:17:55.3008958+02:00",
      "Description": "Assimilated optimal product",
      "Completed": "Completed",
      "Registered": "2003-11-26T10:17:55.3008958+01:00"
    },
    {
      "AppointmentId": 839,
      "DocumentId": 780,
      "Date": "2012-04-15T10:17:55.3008958+02:00",
      "Description": "Assimilated optimal product",
      "Completed": "Completed",
      "Registered": "2003-11-26T10:17:55.3008958+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 768,
      "SaleDate": "2009-09-15T10:17:55.3008958+02:00",
      "Probability": 950,
      "Heading": "id",
      "Amount": 12930.884,
      "Currency": "eum",
      "AmountInBaseCurrency": 6797.646,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2010-05-01T10:17:55.3008958+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 283,
      "Name": "Jacobi, Pfeffer and Lemke",
      "CompanyName": "Funk, Kiehn and Cummerata",
      "FirstMessage": "reprehenderit",
      "LastMessage": "minima",
      "WhenRequested": "2015-11-16T10:17:55.3008958+01:00",
      "WhenEnded": "2017-09-20T10:17:55.3008958+02:00"
    }
  ]
}
```