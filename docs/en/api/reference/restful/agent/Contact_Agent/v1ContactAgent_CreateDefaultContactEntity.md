---
title: POST Agents/Contact/CreateDefaultContactEntity
uid: v1ContactAgent_CreateDefaultContactEntity
generated: true
---

# POST Agents/Contact/CreateDefaultContactEntity

```http
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 861,
  "Name": "Breitenberg-Durgan",
  "Department": "",
  "OrgNr": "1540273",
  "Number1": "1210004",
  "Number2": "793475",
  "UpdatedDate": "2018-02-16T16:54:54.9092628+01:00",
  "CreatedDate": "2014-10-02T16:54:54.9092628+02:00",
  "Emails": [
    {
      "Value": "explicabo",
      "StrippedValue": "deserunt",
      "Description": "Persistent zero administration encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 40
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "deserunt",
      "Description": "Persistent zero administration encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 40
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 788,
      "Name": "Mohr, Bruen and Dietrich",
      "ToolTip": "Sed aut qui voluptate.",
      "Deleted": true,
      "Rank": 427,
      "Type": "ipsam",
      "ColorBlock": 344,
      "IconHint": "ea",
      "Selected": false,
      "LastChanged": "2021-10-15T16:54:54.9092628+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consectetur",
      "StyleHint": "culpa",
      "Hidden": true,
      "FullName": "Prof. Alisha McLaughlin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 609
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sequi",
      "StrippedValue": "inventore",
      "Description": "Extended non-volatile challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 39
        }
      }
    },
    {
      "Value": "sequi",
      "StrippedValue": "inventore",
      "Description": "Extended non-volatile challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 39
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "dolorem",
      "StrippedValue": "fuga",
      "Description": "Quality-focused full-range strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 196
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "fuga",
      "Description": "Quality-focused full-range strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 196
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "esse",
      "StrippedValue": "sunt",
      "Description": "Ergonomic high-level collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 526
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "sunt",
      "Description": "Ergonomic high-level collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 526
        }
      }
    }
  ],
  "Description": "Distributed needs-based matrices",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "unde",
      "PersonId": 779,
      "Mrmrs": "repellendus",
      "Firstname": "Jovan",
      "Lastname": "Bergstrom",
      "MiddleName": "Haag LLC",
      "Title": "magni",
      "Description": "Business-focused zero tolerance local area network",
      "Email": "jacquelyn@stark.us",
      "FullName": "Nicolas Wisoky",
      "DirectPhone": "(451)892-1382",
      "FormalName": "Parisian, McDermott and Schinner",
      "CountryId": 509,
      "ContactId": 955,
      "ContactName": "Stracke-Little",
      "Retired": 644,
      "Rank": 674,
      "ActiveInterests": 301,
      "ContactDepartment": "",
      "ContactCountryId": 573,
      "ContactOrgNr": "913267",
      "FaxPhone": "(782)409-8107",
      "MobilePhone": "098-493-1562 x5114",
      "ContactPhone": "1-541-908-1499 x22538",
      "AssociateName": "Mraz Group",
      "AssociateId": 591,
      "UsePersonAddress": false,
      "ContactFax": "aliquam",
      "Kanafname": "sit",
      "Kanalname": "voluptatibus",
      "Post1": "velit",
      "Post2": "labore",
      "Post3": "similique",
      "EmailName": "moses.gorczany@kulas.ca",
      "ContactFullName": "Jasmin Esteban Dietrich I",
      "ActiveErpLinks": 232,
      "TicketPriorityId": 354,
      "SupportLanguageId": 436,
      "SupportAssociateId": 183,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 306
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "vitae",
  "Xstop": false,
  "ActiveInterests": 925,
  "GroupId": 995,
  "ActiveStatusMonitorId": 355,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 394,
  "DbiAgentId": 848,
  "DbiLastSyncronized": "2016-08-08T16:54:54.9122636+02:00",
  "DbiKey": "inventore",
  "DbiLastModified": "2004-12-28T16:54:54.9122636+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 429,
  "ActiveErpLinks": 490,
  "BounceEmails": [
    "lily_heidenreich@wuckert.uk",
    "montana_west@wisoky.us"
  ],
  "Domains": [
    "expedita",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "767123088",
    "SuperOffice:2": "1497202496"
  },
  "ExtraFields": {
    "ExtraFields1": "impedit",
    "ExtraFields2": "quasi"
  },
  "CustomFields": {
    "CustomFields1": "nisi",
    "CustomFields2": "minus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 795
    }
  }
}
```