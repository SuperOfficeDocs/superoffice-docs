---
title: POST Agents/Contact/GetContactSummary
uid: v1ContactAgent_GetContactSummary
generated: true
content_type: reference
---

# POST Agents/Contact/GetContactSummary

```http
POST /api/v1/Agents/Contact/GetContactSummary
```

Get summary of contact and its recent activity.


NsApiSlow threshold: 2000 ms.






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
  "ContactId": 328,
  "Limit": 634
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
      "TicketId": 461,
      "TicketStatus": 795,
      "Title": "illo",
      "Registered": "2008-09-16T02:30:47.0225898+02:00",
      "IconHint": "tenetur"
    },
    {
      "TicketId": 461,
      "TicketStatus": 795,
      "Title": "illo",
      "Registered": "2008-09-16T02:30:47.0225898+02:00",
      "IconHint": "tenetur"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 328,
      "DocumentId": 30,
      "Date": "1998-11-20T02:30:47.0225898+01:00",
      "Description": "Synchronised hybrid leverage",
      "Completed": "Completed",
      "Registered": "2015-09-20T02:30:47.0225898+02:00"
    },
    {
      "AppointmentId": 328,
      "DocumentId": 30,
      "Date": "1998-11-20T02:30:47.0225898+01:00",
      "Description": "Synchronised hybrid leverage",
      "Completed": "Completed",
      "Registered": "2015-09-20T02:30:47.0225898+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 346,
      "DocumentId": 224,
      "Date": "2007-12-25T02:30:47.0225898+01:00",
      "Description": "Organized zero tolerance encryption",
      "Completed": "Completed",
      "Registered": "2007-06-08T02:30:47.0225898+02:00"
    },
    {
      "AppointmentId": 346,
      "DocumentId": 224,
      "Date": "2007-12-25T02:30:47.0225898+01:00",
      "Description": "Organized zero tolerance encryption",
      "Completed": "Completed",
      "Registered": "2007-06-08T02:30:47.0225898+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 413,
      "SaleDate": "2006-11-26T02:30:47.0225898+01:00",
      "Probability": 232,
      "Heading": "est",
      "Amount": 1184.652,
      "Currency": "sit",
      "AmountInBaseCurrency": 21276.726,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2020-09-06T02:30:47.0225898+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 153,
      "Name": "Yundt, Stanton and Koelpin",
      "CompanyName": "Koelpin, Swaniawski and Runolfsson",
      "FirstMessage": "qui",
      "LastMessage": "dolores",
      "WhenRequested": "2010-08-24T02:30:47.0225898+02:00",
      "WhenEnded": "2018-12-15T02:30:47.0225898+01:00"
    }
  ]
}
```