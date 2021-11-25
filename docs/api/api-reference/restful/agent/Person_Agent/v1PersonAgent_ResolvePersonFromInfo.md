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
  "ContactId": 570,
  "PersonName": "Labadie Inc and Sons",
  "PhoneNumbers": [
    "711680",
    "1240443"
  ],
  "Emails": [
    "emmett@turcotte.com",
    "gina.rohan@rolfson.com"
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": {
    "PersonId": 230,
    "Firstname": "Lupe",
    "MiddleName": "Little-Wisozk",
    "Lastname": "McKenzie",
    "Mrmrs": "expedita",
    "Title": "alias",
    "UpdatedDate": "2004-06-09T18:28:49.7391402+02:00",
    "CreatedDate": "2018-10-02T18:28:49.7401396+02:00",
    "BirthDate": "2018-07-06T18:28:49.7401396+02:00",
    "CreatedBy": {},
    "Emails": [
      {},
      {}
    ],
    "Description": "Persistent radical orchestration",
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
    "PersonNumber": "1222953",
    "FullName": "Cooper Kirlin IV",
    "NoMailing": false,
    "UsePersonAddress": true,
    "Retired": true,
    "Urls": [
      {},
      {}
    ],
    "FormalName": "Carter, Gottlieb and Dooley",
    "Address": {},
    "Post3": "aliquam",
    "Post2": "perspiciatis",
    "Post1": "corrupti",
    "Kanalname": "velit",
    "Kanafname": "ut",
    "CorrespondingAssociate": {},
    "Category": {},
    "Business": {},
    "Associate": {},
    "Salutation": "quam",
    "ActiveInterests": 616,
    "SupportAssociate": {},
    "TicketPriority": {},
    "CustomerLanguage": {},
    "DbiAgentId": 645,
    "DbiKey": "libero",
    "DbiLastModified": "2016-09-26T18:28:49.7401396+02:00",
    "DbiLastSyncronized": "2016-02-21T18:28:49.7401396+01:00",
    "SentInfo": 11,
    "ShowContactTickets": 291,
    "UserInfo": {},
    "ChatEmails": [
      {},
      {}
    ],
    "InternetPhones": [
      {},
      {}
    ],
    "Source": 722,
    "ActiveErpLinks": 40,
    "ShipmentTypes": [
      {},
      {}
    ],
    "Consents": [
      {},
      {}
    ],
    "BounceEmails": [
      "vilma.ryan@hessel.name",
      "rocio.treutel@homenick.ca"
    ],
    "ActiveStatusMonitorId": 254,
    "UserDefinedFields": {
      "SuperOffice:1": "True",
      "SuperOffice:2": "1092687044"
    },
    "ExtraFields": {
      "ExtraFields1": "temporibus",
      "ExtraFields2": "rerum"
    },
    "CustomFields": {
      "CustomFields1": "quam",
      "CustomFields2": "similique"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 848
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
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 956
    }
  }
}
```