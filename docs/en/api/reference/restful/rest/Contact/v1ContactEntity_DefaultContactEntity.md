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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 05 Apr 2008 12:01:32 G4T

{
  "ContactId": 205,
  "Name": "Nader-Legros",
  "Department": "",
  "OrgNr": "532805",
  "Number1": "1631086",
  "Number2": "150072",
  "UpdatedDate": "2008-04-05T12:01:32.7769271+02:00",
  "CreatedDate": "2012-09-09T12:01:32.7769271+02:00",
  "Emails": [
    {
      "Value": "doloribus",
      "StrippedValue": "doloribus",
      "Description": "Ameliorated zero administration success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 973
        }
      }
    },
    {
      "Value": "doloribus",
      "StrippedValue": "doloribus",
      "Description": "Ameliorated zero administration success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 973
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 175,
      "Name": "Deckow, Miller and McClure",
      "ToolTip": "Nobis provident.",
      "Deleted": false,
      "Rank": 963,
      "Type": "neque",
      "ColorBlock": 26,
      "IconHint": "sit",
      "Selected": false,
      "LastChanged": "2022-09-12T12:01:32.7769271+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "ad",
      "Hidden": false,
      "FullName": "Bernardo Bartell",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 80
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aspernatur",
      "StrippedValue": "eum",
      "Description": "Cross-platform regional capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 411
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "eum",
      "Description": "Cross-platform regional capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 411
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "magni",
      "StrippedValue": "magnam",
      "Description": "Cloned grid-enabled hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 374
        }
      }
    },
    {
      "Value": "magni",
      "StrippedValue": "magnam",
      "Description": "Cloned grid-enabled hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 374
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "inventore",
      "StrippedValue": "voluptatem",
      "Description": "Mandatory explicit archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 919
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "voluptatem",
      "Description": "Mandatory explicit archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 919
        }
      }
    }
  ],
  "Description": "Phased interactive projection",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sit",
      "PersonId": 615,
      "Mrmrs": "quibusdam",
      "Firstname": "Marjorie",
      "Lastname": "Kling",
      "MiddleName": "Lang LLC",
      "Title": "illum",
      "Description": "Profound zero tolerance emulation",
      "Email": "gail@wehner.info",
      "FullName": "Angela Oberbrunner",
      "DirectPhone": "(652)183-6830",
      "FormalName": "Harvey, Kertzmann and Hettinger",
      "CountryId": 196,
      "ContactId": 168,
      "ContactName": "Bernier LLC",
      "Retired": 535,
      "Rank": 853,
      "ActiveInterests": 328,
      "ContactDepartment": "evolve mission-critical technologies",
      "ContactCountryId": 33,
      "ContactOrgNr": "1471438",
      "FaxPhone": "1-392-258-8600",
      "MobilePhone": "818-071-8750",
      "ContactPhone": "916.121.8709 x72904",
      "AssociateName": "Mraz, Crist and Gibson",
      "AssociateId": 605,
      "UsePersonAddress": true,
      "ContactFax": "sit",
      "Kanafname": "enim",
      "Kanalname": "corrupti",
      "Post1": "officia",
      "Post2": "eveniet",
      "Post3": "eaque",
      "EmailName": "toney@schillercruickshank.com",
      "ContactFullName": "Dr. Bailee Lee Cremin I",
      "ActiveErpLinks": 989,
      "TicketPriorityId": 949,
      "SupportLanguageId": 532,
      "SupportAssociateId": 429,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1666133",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 170
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "harum",
  "Xstop": false,
  "ActiveInterests": 385,
  "GroupId": 778,
  "ActiveStatusMonitorId": 269,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 738,
  "DbiAgentId": 380,
  "DbiLastSyncronized": "1998-03-15T12:01:32.7769271+01:00",
  "DbiKey": "non",
  "DbiLastModified": "2010-08-20T12:01:32.7769271+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 859,
  "ActiveErpLinks": 179,
  "BounceEmails": [
    "dayne_lakin@hauck.us",
    "kira@mayer.us"
  ],
  "Domains": [
    "a",
    "asperiores"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1302514046",
    "SuperOffice:2": "Rey Kassulke"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "cumque"
  },
  "CustomFields": {
    "CustomFields1": "saepe",
    "CustomFields2": "corrupti"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 31
    }
  }
}
```