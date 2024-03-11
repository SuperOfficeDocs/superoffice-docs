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
  "ContactId": 291,
  "Name": "Ritchie-Wisozk",
  "Department": "aggregate sexy e-business",
  "OrgNr": "923584",
  "Number1": "811937",
  "Number2": "1577842",
  "UpdatedDate": "2018-03-24T14:23:46.0793329+01:00",
  "CreatedDate": "2015-08-13T14:23:46.0793329+02:00",
  "Emails": [
    {
      "Value": "veniam",
      "StrippedValue": "et",
      "Description": "Inverse context-sensitive customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 828
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "et",
      "Description": "Inverse context-sensitive customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 828
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 675,
      "Name": "Corwin Group",
      "ToolTip": "Ea rerum sed saepe ut.",
      "Deleted": false,
      "Rank": 207,
      "Type": "quis",
      "ColorBlock": 537,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2015-06-01T14:23:46.0793329+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "similique",
      "Hidden": false,
      "FullName": "Miss Cleveland Tyrell Krajcik",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 410
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "praesentium",
      "StrippedValue": "et",
      "Description": "Balanced disintermediate hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 808
        }
      }
    },
    {
      "Value": "praesentium",
      "StrippedValue": "et",
      "Description": "Balanced disintermediate hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 808
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "itaque",
      "StrippedValue": "illo",
      "Description": "Ameliorated system-worthy knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 271
        }
      }
    },
    {
      "Value": "itaque",
      "StrippedValue": "illo",
      "Description": "Ameliorated system-worthy knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 271
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "fugit",
      "StrippedValue": "odio",
      "Description": "Cross-platform solution-oriented task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 531
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "odio",
      "Description": "Cross-platform solution-oriented task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 531
        }
      }
    }
  ],
  "Description": "Switchable composite initiative",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ab",
      "PersonId": 223,
      "Mrmrs": "neque",
      "Firstname": "Ova",
      "Lastname": "Olson",
      "MiddleName": "Hyatt LLC",
      "Title": "a",
      "Description": "Visionary grid-enabled adapter",
      "Email": "norwood_krajcik@luettgen.ca",
      "FullName": "Arnold Wisoky DDS",
      "DirectPhone": "1-375-296-3214 x44924",
      "FormalName": "Becker-Nader",
      "CountryId": 945,
      "ContactId": 481,
      "ContactName": "Nikolaus-Hoeger",
      "Retired": 519,
      "Rank": 591,
      "ActiveInterests": 790,
      "ContactDepartment": "",
      "ContactCountryId": 640,
      "ContactOrgNr": "234258",
      "FaxPhone": "1-098-440-1300 x06212",
      "MobilePhone": "1-840-635-9656 x31251",
      "ContactPhone": "(041)672-9938 x1771",
      "AssociateName": "Heidenreich, Kovacek and McClure",
      "AssociateId": 742,
      "UsePersonAddress": false,
      "ContactFax": "accusamus",
      "Kanafname": "ut",
      "Kanalname": "consectetur",
      "Post1": "aut",
      "Post2": "dolor",
      "Post3": "repellendus",
      "EmailName": "dominic.lang@corwinledner.co.uk",
      "ContactFullName": "Danyka Kulas",
      "ActiveErpLinks": 46,
      "TicketPriorityId": 33,
      "SupportLanguageId": 475,
      "SupportAssociateId": 860,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 164
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "alias",
  "Xstop": false,
  "ActiveInterests": 542,
  "GroupId": 449,
  "ActiveStatusMonitorId": 33,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 414,
  "DbiAgentId": 752,
  "DbiLastSyncronized": "2000-11-20T14:23:46.0793329+01:00",
  "DbiKey": "et",
  "DbiLastModified": "2008-07-02T14:23:46.0793329+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 385,
  "ActiveErpLinks": 275,
  "BounceEmails": [
    "ara@bergstromanderson.co.uk",
    "kiara_koss@nader.info"
  ],
  "Domains": [
    "pariatur",
    "quo"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Billy Nader",
    "SuperOffice:2": "Mrs. Adrien Lebsack Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "facilis",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "harum",
    "CustomFields2": "ducimus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 165
    }
  }
}
```