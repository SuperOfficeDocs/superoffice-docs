---
title: GET Contact/{id}
uid: v1ContactEntity_GetContactEntity
generated: true
content_type: reference
---

# GET Contact/{id}

```http
GET /api/v1/Contact/{id}
```

Gets a ContactEntity object.


Calls the Contact agent service GetContactEntity.
NsApiSlow threshold: 2000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ContactEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Contact/{id}?$select=name,department,category/id
GET /api/v1/Contact/{id}?fk=False
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

ContactEntity found.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity found. |
| 304 | ContactEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

### Response body: ContactEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 19 Jan 2013 02:30:52 G1T

{
  "ContactId": 141,
  "Name": "McLaughlin LLC",
  "Department": "",
  "OrgNr": "545212",
  "Number1": "1038594",
  "Number2": "1071033",
  "UpdatedDate": "2013-01-19T02:30:52.4599175+01:00",
  "CreatedDate": "2014-01-06T02:30:52.4599175+01:00",
  "Emails": [
    {
      "Value": "ullam",
      "StrippedValue": "voluptatem",
      "Description": "Balanced motivating structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 214
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "voluptatem",
      "Description": "Balanced motivating structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 214
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 818,
      "Name": "Hammes-McLaughlin",
      "ToolTip": "Doloremque omnis.",
      "Deleted": false,
      "Rank": 894,
      "Type": "sapiente",
      "ColorBlock": 610,
      "IconHint": "laborum",
      "Selected": false,
      "LastChanged": "2013-01-28T02:30:52.4599175+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ex",
      "StyleHint": "aliquid",
      "Hidden": false,
      "FullName": "Derek Monique D'Amore V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 986
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "a",
      "StrippedValue": "vitae",
      "Description": "Expanded incremental algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 961
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "vitae",
      "Description": "Expanded incremental algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 961
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Secured intermediate knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 668
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Secured intermediate knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 668
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "autem",
      "StrippedValue": "hic",
      "Description": "Secured mobile extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 337
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "hic",
      "Description": "Secured mobile extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 337
        }
      }
    }
  ],
  "Description": "Ameliorated methodical protocol",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "illum",
      "PersonId": 688,
      "Mrmrs": "eaque",
      "Firstname": "Madie",
      "Lastname": "Emard",
      "MiddleName": "Durgan-Corkery",
      "Title": "rerum",
      "Description": "Ergonomic maximized knowledge user",
      "Email": "elyse_krajcik@jenkins.biz",
      "FullName": "Alexanne Haley",
      "DirectPhone": "1-692-787-6163 x29578",
      "FormalName": "Runte Group",
      "CountryId": 904,
      "ContactId": 509,
      "ContactName": "Kling-Mayer",
      "Retired": 853,
      "Rank": 940,
      "ActiveInterests": 147,
      "ContactDepartment": "harness 24/7 paradigms",
      "ContactCountryId": 721,
      "ContactOrgNr": "1188036",
      "FaxPhone": "1-102-132-4916 x006",
      "MobilePhone": "401-507-5928",
      "ContactPhone": "1-930-764-3422",
      "AssociateName": "Stoltenberg LLC",
      "AssociateId": 49,
      "UsePersonAddress": false,
      "ContactFax": "vel",
      "Kanafname": "in",
      "Kanalname": "similique",
      "Post1": "voluptas",
      "Post2": "repudiandae",
      "Post3": "perspiciatis",
      "EmailName": "bert@ankunding.co.uk",
      "ContactFullName": "Marshall Mosciski",
      "ActiveErpLinks": 633,
      "TicketPriorityId": 346,
      "SupportLanguageId": 652,
      "SupportAssociateId": 631,
      "CategoryName": "VIP Customer",
      "PersonNumber": "342262",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 793
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "veritatis",
  "Xstop": true,
  "ActiveInterests": 546,
  "GroupId": 127,
  "ActiveStatusMonitorId": 984,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 625,
  "DbiAgentId": 354,
  "DbiLastSyncronized": "2020-12-22T02:30:52.4755423+01:00",
  "DbiKey": "fugit",
  "DbiLastModified": "2010-06-17T02:30:52.4755423+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 362,
  "ActiveErpLinks": 621,
  "BounceEmails": [
    "laila@kuphalweber.name",
    "buck_gleason@purdy.ca"
  ],
  "Domains": [
    "doloribus",
    "non"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "deleniti"
  },
  "CustomFields": {
    "CustomFields1": "fuga",
    "CustomFields2": "labore"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 613
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```