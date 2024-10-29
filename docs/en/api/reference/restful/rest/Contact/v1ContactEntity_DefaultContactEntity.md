---
title: GET Contact/default
uid: v1ContactEntity_DefaultContactEntity
generated: true
---

# GET Contact/default

```http
GET /api/v1/Contact/default
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Contact agent service CreateDefaultContactEntity.







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
GET /api/v1/Contact/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 10 Nov 2015 13:14:10 G11T

{
  "ContactId": 719,
  "Name": "Stanton, Bogan and Marquardt",
  "Department": "",
  "OrgNr": "1333748",
  "Number1": "691084",
  "Number2": "491239",
  "UpdatedDate": "2015-11-10T13:14:10.7110321+01:00",
  "CreatedDate": "2024-04-20T13:14:10.7110321+02:00",
  "Emails": [
    {
      "Value": "architecto",
      "StrippedValue": "voluptatem",
      "Description": "Optimized exuding database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 537
        }
      }
    },
    {
      "Value": "architecto",
      "StrippedValue": "voluptatem",
      "Description": "Optimized exuding database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 537
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 63,
      "Name": "Deckow Group",
      "ToolTip": "Esse eaque aliquam minus aut non dolore.",
      "Deleted": false,
      "Rank": 816,
      "Type": "voluptatem",
      "ColorBlock": 472,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2000-11-21T13:14:10.7110321+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "provident",
      "StyleHint": "reiciendis",
      "Hidden": true,
      "FullName": "Viviane Torp DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "nostrum",
      "StrippedValue": "aut",
      "Description": "Customizable radical toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 46
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "aut",
      "Description": "Customizable radical toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 46
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "dolorum",
      "StrippedValue": "sint",
      "Description": "Secured motivating matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 249
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "sint",
      "Description": "Secured motivating matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 249
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Assimilated responsive emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 336
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Assimilated responsive emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 336
        }
      }
    }
  ],
  "Description": "Configurable dynamic adapter",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quidem",
      "PersonId": 171,
      "Mrmrs": "a",
      "Firstname": "Fredrick",
      "Lastname": "Becker",
      "MiddleName": "Kohler-Kub",
      "Title": "et",
      "Description": "Upgradable neutral internet solution",
      "Email": "adele@grady.ca",
      "FullName": "Crystal Connelly",
      "DirectPhone": "938.312.1809",
      "FormalName": "Price-Lockman",
      "CountryId": 880,
      "ContactId": 873,
      "ContactName": "Jaskolski LLC",
      "Retired": 455,
      "Rank": 416,
      "ActiveInterests": 201,
      "ContactDepartment": "",
      "ContactCountryId": 581,
      "ContactOrgNr": "709765",
      "FaxPhone": "430-603-1051",
      "MobilePhone": "1-469-891-1568 x4179",
      "ContactPhone": "(003)094-0170 x4554",
      "AssociateName": "Little, Rolfson and Collins",
      "AssociateId": 705,
      "UsePersonAddress": false,
      "ContactFax": "suscipit",
      "Kanafname": "dolore",
      "Kanalname": "mollitia",
      "Post1": "dolorem",
      "Post2": "soluta",
      "Post3": "reprehenderit",
      "EmailName": "jaquan.berge@jacobsonpacocha.ca",
      "ContactFullName": "Prof. Tina Corwin PhD",
      "ActiveErpLinks": 52,
      "TicketPriorityId": 775,
      "SupportLanguageId": 486,
      "SupportAssociateId": 536,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 309
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "hic",
  "Xstop": false,
  "ActiveInterests": 917,
  "GroupId": 706,
  "ActiveStatusMonitorId": 801,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 527,
  "DbiAgentId": 897,
  "DbiLastSyncronized": "2003-11-04T13:14:10.7110321+01:00",
  "DbiKey": "laboriosam",
  "DbiLastModified": "2013-04-26T13:14:10.7110321+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 653,
  "ActiveErpLinks": 219,
  "BounceEmails": [
    "talon@windler.co.uk",
    "micheal.collins@mueller.biz"
  ],
  "Domains": [
    "repellat",
    "reiciendis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1008103979",
    "SuperOffice:2": "Otis Connelly"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "impedit",
    "CustomFields2": "earum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 873
    }
  }
}
```