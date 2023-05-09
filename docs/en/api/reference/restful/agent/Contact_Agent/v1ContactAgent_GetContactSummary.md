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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 615,
  "Limit": 628
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
      "TicketId": 349,
      "TicketStatus": 687,
      "Title": "consequatur",
      "Registered": "2004-03-01T03:51:26.9280353+01:00",
      "IconHint": "aperiam"
    },
    {
      "TicketId": 349,
      "TicketStatus": 687,
      "Title": "consequatur",
      "Registered": "2004-03-01T03:51:26.9280353+01:00",
      "IconHint": "aperiam"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 678,
      "DocumentId": 66,
      "Date": "2012-10-14T03:51:26.9280353+02:00",
      "Description": "De-engineered zero tolerance project",
      "Completed": "Completed",
      "Registered": "1998-08-20T03:51:26.9280353+02:00"
    },
    {
      "AppointmentId": 678,
      "DocumentId": 66,
      "Date": "2012-10-14T03:51:26.9280353+02:00",
      "Description": "De-engineered zero tolerance project",
      "Completed": "Completed",
      "Registered": "1998-08-20T03:51:26.9280353+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 908,
      "DocumentId": 858,
      "Date": "2018-09-05T03:51:26.9280353+02:00",
      "Description": "Optional fault-tolerant internet solution",
      "Completed": "Completed",
      "Registered": "1998-12-17T03:51:26.9280353+01:00"
    },
    {
      "AppointmentId": 908,
      "DocumentId": 858,
      "Date": "2018-09-05T03:51:26.9280353+02:00",
      "Description": "Optional fault-tolerant internet solution",
      "Completed": "Completed",
      "Registered": "1998-12-17T03:51:26.9280353+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 837,
      "SaleDate": "2007-03-22T03:51:26.9280353+01:00",
      "Probability": 310,
      "Heading": "inventore",
      "Amount": 17240.134,
      "Currency": "quasi",
      "AmountInBaseCurrency": 25871.17,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2016-09-23T03:51:26.9280353+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 984,
      "Name": "Gulgowski-O'Conner",
      "CompanyName": "Purdy, Harvey and Gutkowski",
      "FirstMessage": "adipisci",
      "LastMessage": "numquam",
      "WhenRequested": "2016-10-16T03:51:26.9280353+02:00",
      "WhenEnded": "2009-01-29T03:51:26.9280353+01:00"
    }
  ]
}
```