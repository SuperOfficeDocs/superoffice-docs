---
title: ResolvePersonFromInfo
id: v1PersonAgent_ResolvePersonFromInfo
---

# ResolvePersonFromInfo

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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 477,
  "PersonName": "Nicolas, Grady and Cummings",
  "PhoneNumbers": [
    "1406863",
    "1515516"
  ],
  "Emails": [
    "micah.rohan@okon.com",
    "carissa_sporer@hermann.biz"
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": {
    "PersonId": 895,
    "Firstname": "Kari",
    "MiddleName": "Torphy-Vandervort",
    "Lastname": "Green",
    "Mrmrs": "nam",
    "Title": "dicta",
    "UpdatedDate": "2018-04-18T14:58:04.8154622+02:00",
    "CreatedDate": "1999-08-22T14:58:04.8154622+02:00",
    "BirthDate": "2005-06-16T14:58:04.8154622+02:00",
    "CreatedBy": {},
    "Emails": [
      {},
      {}
    ],
    "Description": "Enhanced zero defect customer loyalty",
    "IsAssociate": false,
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
    "PersonNumber": "1099825",
    "FullName": "Gabe Brakus",
    "NoMailing": false,
    "UsePersonAddress": true,
    "Retired": true,
    "Urls": [
      {},
      {}
    ],
    "FormalName": "Stamm, Olson and Murray",
    "Address": {},
    "Post3": "placeat",
    "Post2": "et",
    "Post1": "nihil",
    "Kanalname": "et",
    "Kanafname": "facere",
    "CorrespondingAssociate": {},
    "Category": {},
    "Business": {},
    "Associate": {},
    "Salutation": "aut",
    "ActiveInterests": 626,
    "SupportAssociate": {},
    "TicketPriority": {},
    "CustomerLanguage": {},
    "DbiAgentId": 110,
    "DbiKey": "ut",
    "DbiLastModified": "1998-12-23T14:58:04.8154622+01:00",
    "DbiLastSyncronized": "1995-02-24T14:58:04.8154622+01:00",
    "SentInfo": 410,
    "ShowContactTickets": 88,
    "UserInfo": {},
    "ChatEmails": [
      {},
      {}
    ],
    "InternetPhones": [
      {},
      {}
    ],
    "Source": 240,
    "ActiveErpLinks": 929,
    "ShipmentTypes": [
      {},
      {}
    ],
    "Consents": [
      {},
      {}
    ],
    "BounceEmails": [
      "rocky.jacobs@bahringer.com",
      "julie@blanda.biz"
    ],
    "UserDefinedFields": {
      "SuperOffice:1": "583178232",
      "SuperOffice:2": "1793781235"
    },
    "ExtraFields": {
      "ExtraFields1": "minus",
      "ExtraFields2": "voluptatem"
    },
    "CustomFields": {
      "CustomFields1": "maxime",
      "CustomFields2": "aut"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 440
      }
    }
  },
  "PersonCreated": false,
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
      "FieldLength": 919
    }
  }
}
```