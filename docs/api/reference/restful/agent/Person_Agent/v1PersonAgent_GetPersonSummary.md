---
title: POST Agents/Person/GetPersonSummary
id: v1PersonAgent_GetPersonSummary
---

# POST Agents/Person/GetPersonSummary

```http
POST /api/v1/Agents/Person/GetPersonSummary
```

Get summary of person and recent activity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonSummary?$select=name,department,category/id
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

PersonId, Limit 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 |  |
| Limit | int32 |  |


## Response: object

Summary of person, with recent activities, chats, and requests included.



Carrier object for PersonSummary.
Services for the PersonSummary Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Person |  | Simple Person data. |
| Tickets | array | Recent tickets on person |
| Followups | array | Recent follow-ups on person |
| Documents | array | Recent documents on person |
| Sales | array | Recent sales on person |
| Chats | array | Recent chats with person |

## Sample Request

```http!
POST /api/v1/Agents/Person/GetPersonSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 617,
  "Limit": 678
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": {
    "Position": "quis",
    "PersonId": 237,
    "Mrmrs": "laudantium",
    "Firstname": "Gunnar",
    "Lastname": "Kling",
    "MiddleName": "Upton LLC",
    "Title": "tempora",
    "Description": "Polarised fresh-thinking adapter",
    "Email": "grace@brakus.co.uk",
    "FullName": "Providenci Cassin V",
    "DirectPhone": "528-455-4805 x46362",
    "FormalName": "Zieme, Bartoletti and Jerde",
    "CountryId": 771,
    "ContactId": 810,
    "ContactName": "Bartell-Roberts",
    "Retired": 114,
    "Rank": 566,
    "ActiveInterests": 361,
    "ContactDepartment": "",
    "ContactCountryId": 716,
    "ContactOrgNr": "1253791",
    "FaxPhone": "1-257-104-8265",
    "MobilePhone": "1-385-832-0166",
    "ContactPhone": "811.130.2622 x0336",
    "AssociateName": "Bednar, Streich and Lesch",
    "AssociateId": 100,
    "UsePersonAddress": true,
    "ContactFax": "ratione",
    "Kanafname": "officia",
    "Kanalname": "qui",
    "Post1": "recusandae",
    "Post2": "facilis",
    "Post3": "quo",
    "EmailName": "jerrold@pfannerstill.com",
    "ContactFullName": "Trent Wehner",
    "ActiveErpLinks": 424,
    "TicketPriorityId": 11,
    "SupportLanguageId": 344,
    "SupportAssociateId": 630,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 274
      }
    }
  },
  "Tickets": [
    {
      "TicketId": 204,
      "TicketStatus": 602,
      "Title": "occaecati",
      "Registered": "2002-01-06T18:28:49.4990899+01:00"
    },
    {
      "TicketId": 204,
      "TicketStatus": 602,
      "Title": "occaecati",
      "Registered": "2002-01-06T18:28:49.4990899+01:00"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 846,
      "DocumentId": 983,
      "Date": "2004-10-21T18:28:49.4990899+02:00",
      "Description": "Managed tangible info-mediaries",
      "Completed": "Completed",
      "Registered": "2012-11-10T18:28:49.4990899+01:00"
    },
    {
      "AppointmentId": 846,
      "DocumentId": 983,
      "Date": "2004-10-21T18:28:49.4990899+02:00",
      "Description": "Managed tangible info-mediaries",
      "Completed": "Completed",
      "Registered": "2012-11-10T18:28:49.4990899+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 593,
      "DocumentId": 682,
      "Date": "2011-04-28T18:28:49.4990899+02:00",
      "Description": "User-friendly value-added algorithm",
      "Completed": "Completed",
      "Registered": "2020-05-20T18:28:49.4990899+02:00"
    },
    {
      "AppointmentId": 593,
      "DocumentId": 682,
      "Date": "2011-04-28T18:28:49.4990899+02:00",
      "Description": "User-friendly value-added algorithm",
      "Completed": "Completed",
      "Registered": "2020-05-20T18:28:49.4990899+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 961,
      "SaleDate": "2010-08-25T18:28:49.4990899+02:00",
      "Probability": 264,
      "Heading": "magni",
      "Amount": 22740.304,
      "Currency": "dolore",
      "AmountInBaseCurrency": 4061.6639999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2011-07-14T18:28:49.4990899+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 164,
      "Name": "Bartoletti-Baumbach",
      "CompanyName": "Russel, Senger and Prosacco",
      "FirstMessage": "atque",
      "LastMessage": "ea",
      "WhenRequested": "2005-11-11T18:28:49.4990899+01:00",
      "WhenEnded": "2005-04-10T18:28:49.4990899+02:00"
    }
  ]
}
```