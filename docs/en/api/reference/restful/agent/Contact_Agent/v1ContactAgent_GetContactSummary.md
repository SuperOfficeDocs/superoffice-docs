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
  "ContactId": 909,
  "Limit": 25
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
      "TicketId": 272,
      "TicketStatus": 880,
      "Title": "et",
      "Registered": "2001-09-12T11:06:34.2227051+02:00",
      "IconHint": "qui"
    },
    {
      "TicketId": 272,
      "TicketStatus": 880,
      "Title": "et",
      "Registered": "2001-09-12T11:06:34.2227051+02:00",
      "IconHint": "qui"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 186,
      "DocumentId": 189,
      "Date": "2017-07-14T11:06:34.2227051+02:00",
      "Description": "Face to face full-range product",
      "Completed": "Completed",
      "Registered": "2001-07-31T11:06:34.2227051+02:00"
    },
    {
      "AppointmentId": 186,
      "DocumentId": 189,
      "Date": "2017-07-14T11:06:34.2227051+02:00",
      "Description": "Face to face full-range product",
      "Completed": "Completed",
      "Registered": "2001-07-31T11:06:34.2227051+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 397,
      "DocumentId": 208,
      "Date": "2001-09-25T11:06:34.2227051+02:00",
      "Description": "Networked zero defect contingency",
      "Completed": "Completed",
      "Registered": "2016-01-10T11:06:34.2227051+01:00"
    },
    {
      "AppointmentId": 397,
      "DocumentId": 208,
      "Date": "2001-09-25T11:06:34.2227051+02:00",
      "Description": "Networked zero defect contingency",
      "Completed": "Completed",
      "Registered": "2016-01-10T11:06:34.2227051+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 904,
      "SaleDate": "2014-07-03T11:06:34.2227051+02:00",
      "Probability": 191,
      "Heading": "sunt",
      "Amount": 15290.786,
      "Currency": "dolorem",
      "AmountInBaseCurrency": 24683.384,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2019-11-25T11:06:34.2227051+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 448,
      "Name": "Crona, Satterfield and Miller",
      "CompanyName": "Crooks Group",
      "FirstMessage": "sed",
      "LastMessage": "voluptate",
      "WhenRequested": "2011-03-06T11:06:34.2227051+01:00",
      "WhenEnded": "2000-01-05T11:06:34.2227051+01:00"
    }
  ]
}
```