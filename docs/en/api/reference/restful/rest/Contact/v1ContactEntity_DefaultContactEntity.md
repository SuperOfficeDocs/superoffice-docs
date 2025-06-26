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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Thu, 23 Oct 2003 03:45:28 G10T

{
  "ContactId": 802,
  "Name": "Huel, Hansen and Howe",
  "Department": "",
  "OrgNr": "1080757",
  "Number1": "676154",
  "Number2": "1846056",
  "UpdatedDate": "2003-10-23T03:45:28.1703207+02:00",
  "CreatedDate": "2023-07-27T03:45:28.1703207+02:00",
  "Emails": [
    {
      "Value": "animi",
      "StrippedValue": "qui",
      "Description": "Ameliorated maximized hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 22
        }
      }
    },
    {
      "Value": "animi",
      "StrippedValue": "qui",
      "Description": "Ameliorated maximized hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 22
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 115,
      "Name": "Hackett LLC",
      "ToolTip": "Soluta nihil minima quia iure quam.",
      "Deleted": true,
      "Rank": 36,
      "Type": "et",
      "ColorBlock": 935,
      "IconHint": "eos",
      "Selected": true,
      "LastChanged": "2007-08-20T03:45:28.1703207+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "autem",
      "StyleHint": "non",
      "Hidden": false,
      "FullName": "Rosamond Bartoletti",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 19
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "odio",
      "Description": "Secured systematic neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 106
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "odio",
      "Description": "Secured systematic neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 106
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quia",
      "StrippedValue": "officiis",
      "Description": "Digitized attitude-oriented knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "officiis",
      "Description": "Digitized attitude-oriented knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "magni",
      "StrippedValue": "est",
      "Description": "Ameliorated dynamic support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 454
        }
      }
    },
    {
      "Value": "magni",
      "StrippedValue": "est",
      "Description": "Ameliorated dynamic support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 454
        }
      }
    }
  ],
  "Description": "Right-sized background secured line",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nisi",
      "PersonId": 439,
      "Mrmrs": "beatae",
      "Firstname": "Karelle",
      "Lastname": "Homenick",
      "MiddleName": "Klein, Thompson and Cremin",
      "Title": "dolores",
      "Description": "Synergized hybrid toolset",
      "Email": "herta@gibsonbreitenberg.com",
      "FullName": "Caesar Crist",
      "DirectPhone": "1-957-124-3506 x186",
      "FormalName": "Corkery-Larson",
      "CountryId": 410,
      "ContactId": 131,
      "ContactName": "Towne Inc and Sons",
      "Retired": 107,
      "Rank": 632,
      "ActiveInterests": 182,
      "ContactDepartment": "",
      "ContactCountryId": 302,
      "ContactOrgNr": "694551",
      "FaxPhone": "1-750-865-9392",
      "MobilePhone": "1-488-200-1538",
      "ContactPhone": "(820)498-3637",
      "AssociateName": "Daugherty Inc and Sons",
      "AssociateId": 532,
      "UsePersonAddress": false,
      "ContactFax": "sed",
      "Kanafname": "aspernatur",
      "Kanalname": "officiis",
      "Post1": "quia",
      "Post2": "eaque",
      "Post3": "et",
      "EmailName": "stella_haag@beattyschimmel.uk",
      "ContactFullName": "Jovany Kautzer",
      "ActiveErpLinks": 953,
      "TicketPriorityId": 934,
      "SupportLanguageId": 148,
      "SupportAssociateId": 271,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1229928",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 810
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "placeat",
  "Xstop": true,
  "ActiveInterests": 50,
  "GroupId": 433,
  "ActiveStatusMonitorId": 98,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 149,
  "DbiAgentId": 418,
  "DbiLastSyncronized": "2025-05-06T03:45:28.1703207+02:00",
  "DbiKey": "distinctio",
  "DbiLastModified": "2021-09-19T03:45:28.1703207+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 328,
  "ActiveErpLinks": 368,
  "BounceEmails": [
    "godfrey.runolfsson@green.info",
    "kailey@ferrykris.ca"
  ],
  "Domains": [
    "harum",
    "officia"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Nash Nienow",
    "SuperOffice:2": "Ruth Braun"
  },
  "ExtraFields": {
    "ExtraFields1": "itaque",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "a",
    "CustomFields2": "consequatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 27
    }
  }
}
```