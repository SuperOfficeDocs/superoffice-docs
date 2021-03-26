---
title: POST Agents/Person/ResolvePersonFromInfo
id: v1PersonAgent_ResolvePersonFromInfo
---

# POST Agents/Person/ResolvePersonFromInfo

```http
POST /api/v1/Agents/Person/ResolvePersonFromInfo
```

Get a person from the provided information.

If the person does not exist, it will be created on demand.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/ResolvePersonFromInfo?$select=name,department,category/id
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

ContactId, PersonName, PhoneNumbers, Emails 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |
| PersonName | string |  |
| PhoneNumbers | array |  |
| Emails | array |  |


## Response: object

The Person Service. The service implements all services working with the Person object.



Carrier object for ResolvedPerson.
Services for the ResolvedPerson Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Person |  | The resolved PersonEntity instance. |
| PersonCreated | bool | Indicates if the resolved person was created or not. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Person/ResolvePersonFromInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 73,
  "PersonName": "Runolfsdottir Inc and Sons",
  "PhoneNumbers": [
    "1024364",
    "1573245"
  ],
  "Emails": [
    "elmer_rohan@lemke.uk",
    "libby@doyleshields.com"
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": {
    "PersonId": 878,
    "Firstname": "Malachi",
    "MiddleName": "Tillman Group",
    "Lastname": "Rolfson",
    "Mrmrs": "quam",
    "Title": "eaque",
    "UpdatedDate": "1999-06-19T16:48:30.1929358+02:00",
    "CreatedDate": "2017-04-02T16:48:30.1929358+02:00",
    "BirthDate": "2006-05-21T16:48:30.1929358+02:00",
    "CreatedBy": {},
    "Emails": [
      {},
      {}
    ],
    "Description": "Function-based actuating access",
    "IsAssociate": true,
    "PrivatePhones": [
      {},
      {}
    ],
    "Faxes": [
      {},
      {}
    ],
    "MobilePhones": [
      {},
      {}
    ],
    "OfficePhones": [
      {},
      {}
    ],
    "OtherPhones": [
      {},
      {}
    ],
    "Position": {},
    "UpdatedBy": {},
    "Contact": {},
    "Country": {},
    "Interests": [
      {},
      {}
    ],
    "PersonNumber": "1554551",
    "FullName": "Reyes Lehner",
    "NoMailing": true,
    "UsePersonAddress": true,
    "Retired": false,
    "Urls": [
      {},
      {}
    ],
    "FormalName": "Kemmer, Wisozk and Cassin",
    "Address": {},
    "Post3": "qui",
    "Post2": "est",
    "Post1": "porro",
    "Kanalname": "esse",
    "Kanafname": "laborum",
    "CorrespondingAssociate": {},
    "Category": {},
    "Business": {},
    "Associate": {},
    "Salutation": "voluptas",
    "ActiveInterests": 384,
    "SupportAssociate": {},
    "TicketPriority": {},
    "CustomerLanguage": {},
    "DbiAgentId": 357,
    "DbiKey": "eaque",
    "DbiLastModified": "1996-08-29T16:48:30.1939355+02:00",
    "DbiLastSyncronized": "2009-04-17T16:48:30.1939355+02:00",
    "SentInfo": 28,
    "ShowContactTickets": 741,
    "UserInfo": {},
    "ChatEmails": [
      {},
      {}
    ],
    "InternetPhones": [
      {},
      {}
    ],
    "Source": 496,
    "ActiveErpLinks": 992,
    "ShipmentTypes": [
      {},
      {}
    ],
    "Consents": [
      {},
      {}
    ],
    "BounceEmails": [
      "jesus.schuster@kozeyfarrell.name",
      "emely@greenholt.com"
    ],
    "UserDefinedFields": {
      "SuperOffice:1": "True",
      "SuperOffice:2": "114414436"
    },
    "ExtraFields": {
      "ExtraFields1": "odit",
      "ExtraFields2": "similique"
    },
    "CustomFields": {
      "CustomFields1": "dignissimos",
      "CustomFields2": "aut"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 411
      }
    }
  },
  "PersonCreated": true,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "facilitate frictionless portals"
      },
      "FieldType": "System.String",
      "FieldLength": 190
    }
  }
}
```