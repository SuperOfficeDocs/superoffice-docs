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
  "ContactId": 326,
  "Limit": 809
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
      "TicketId": 752,
      "TicketStatus": 128,
      "Title": "non",
      "Registered": "2015-09-19T17:37:17.3072425+02:00",
      "IconHint": "placeat"
    },
    {
      "TicketId": 752,
      "TicketStatus": 128,
      "Title": "non",
      "Registered": "2015-09-19T17:37:17.3072425+02:00",
      "IconHint": "placeat"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 683,
      "DocumentId": 795,
      "Date": "2015-03-27T17:37:17.3072425+01:00",
      "Description": "Multi-channelled background moderator",
      "Completed": "Completed",
      "Registered": "2008-02-16T17:37:17.3072425+01:00"
    },
    {
      "AppointmentId": 683,
      "DocumentId": 795,
      "Date": "2015-03-27T17:37:17.3072425+01:00",
      "Description": "Multi-channelled background moderator",
      "Completed": "Completed",
      "Registered": "2008-02-16T17:37:17.3072425+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 805,
      "DocumentId": 794,
      "Date": "2016-02-04T17:37:17.3072425+01:00",
      "Description": "Focused 5th generation methodology",
      "Completed": "Completed",
      "Registered": "2009-07-01T17:37:17.3072425+02:00"
    },
    {
      "AppointmentId": 805,
      "DocumentId": 794,
      "Date": "2016-02-04T17:37:17.3072425+01:00",
      "Description": "Focused 5th generation methodology",
      "Completed": "Completed",
      "Registered": "2009-07-01T17:37:17.3072425+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 300,
      "SaleDate": "2019-06-03T17:37:17.3072425+02:00",
      "Probability": 394,
      "Heading": "enim",
      "Amount": 17446.978,
      "Currency": "fuga",
      "AmountInBaseCurrency": 4741.742,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "1998-07-12T17:37:17.3072425+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 591,
      "Name": "Runolfsson-Bednar",
      "CompanyName": "Wyman-Jacobi",
      "FirstMessage": "dolor",
      "LastMessage": "nisi",
      "WhenRequested": "2011-10-26T17:37:17.3072425+02:00",
      "WhenEnded": "2021-11-14T17:37:17.3072425+01:00"
    }
  ]
}
```