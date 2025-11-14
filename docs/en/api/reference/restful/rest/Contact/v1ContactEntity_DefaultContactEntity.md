---
title: GET Contact/default
uid: v1ContactEntity_DefaultContactEntity
generated: true
content_type: reference
---

# GET Contact/default

```http
GET /api/v1/Contact/default
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Contact agent service CreateDefaultContactEntity.
NsApiSlow threshold: 2000 ms.







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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

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

## Sample request

```http!
GET /api/v1/Contact/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 30 May 2018 02:30:52 G5T

{
  "ContactId": 760,
  "Name": "Block LLC",
  "Department": "",
  "OrgNr": "1086234",
  "Number1": "213298",
  "Number2": "515014",
  "UpdatedDate": "2018-05-30T02:30:52.4442929+02:00",
  "CreatedDate": "1999-04-02T02:30:52.4442929+02:00",
  "Emails": [
    {
      "Value": "consequatur",
      "StrippedValue": "corrupti",
      "Description": "Optimized neutral instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 362
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "corrupti",
      "Description": "Optimized neutral instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 362
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 817,
      "Name": "Sanford, Cartwright and Kozey",
      "ToolTip": "A aliquam non.",
      "Deleted": false,
      "Rank": 274,
      "Type": "eum",
      "ColorBlock": 439,
      "IconHint": "nobis",
      "Selected": false,
      "LastChanged": "2023-03-15T02:30:52.4442929+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "libero",
      "StyleHint": "dolores",
      "Hidden": true,
      "FullName": "Prof. Cornelius Chauncey Ullrich",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 978
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "nemo",
      "StrippedValue": "corrupti",
      "Description": "Total directional groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 395
        }
      }
    },
    {
      "Value": "nemo",
      "StrippedValue": "corrupti",
      "Description": "Total directional groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 395
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ipsa",
      "StrippedValue": "consequatur",
      "Description": "Streamlined zero tolerance moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 647
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "consequatur",
      "Description": "Streamlined zero tolerance moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 647
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sit",
      "StrippedValue": "aut",
      "Description": "Sharable optimizing flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 798
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "aut",
      "Description": "Sharable optimizing flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 798
        }
      }
    }
  ],
  "Description": "Programmable methodical methodology",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolorem",
      "PersonId": 217,
      "Mrmrs": "vel",
      "Firstname": "Dolly",
      "Lastname": "Hoppe",
      "MiddleName": "Cruickshank Group",
      "Title": "qui",
      "Description": "Reactive scalable neural-net",
      "Email": "wyman.dickens@jacobi.ca",
      "FullName": "Ahmad Olen Predovic IV",
      "DirectPhone": "(784)479-7447",
      "FormalName": "Koch-Wolf",
      "CountryId": 548,
      "ContactId": 574,
      "ContactName": "Little Inc and Sons",
      "Retired": 375,
      "Rank": 936,
      "ActiveInterests": 243,
      "ContactDepartment": "",
      "ContactCountryId": 921,
      "ContactOrgNr": "504906",
      "FaxPhone": "1-502-271-3573",
      "MobilePhone": "(706)939-2472 x0814",
      "ContactPhone": "644-049-5157 x24802",
      "AssociateName": "Kihn, Oberbrunner and Huels",
      "AssociateId": 52,
      "UsePersonAddress": true,
      "ContactFax": "asperiores",
      "Kanafname": "et",
      "Kanalname": "doloribus",
      "Post1": "omnis",
      "Post2": "error",
      "Post3": "et",
      "EmailName": "margaret@ankunding.us",
      "ContactFullName": "Annabell Dicki",
      "ActiveErpLinks": 218,
      "TicketPriorityId": 370,
      "SupportLanguageId": 115,
      "SupportAssociateId": 436,
      "CategoryName": "VIP Customer",
      "PersonNumber": "940380",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 872
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quis",
  "Xstop": true,
  "ActiveInterests": 15,
  "GroupId": 228,
  "ActiveStatusMonitorId": 155,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 777,
  "DbiAgentId": 950,
  "DbiLastSyncronized": "2007-11-05T02:30:52.4442929+01:00",
  "DbiKey": "nihil",
  "DbiLastModified": "1999-07-24T02:30:52.4442929+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 403,
  "ActiveErpLinks": 675,
  "BounceEmails": [
    "erwin@steuber.ca",
    "aimee_padberg@stracke.name"
  ],
  "Domains": [
    "consequatur",
    "suscipit"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Ms. Barton Murphy Hoppe"
  },
  "ExtraFields": {
    "ExtraFields1": "officiis",
    "ExtraFields2": "saepe"
  },
  "CustomFields": {
    "CustomFields1": "unde",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 845
    }
  }
}
```