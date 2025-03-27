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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 696,
  "Name": "Hirthe, Daugherty and Hirthe",
  "Department": "",
  "OrgNr": "885654",
  "Number1": "1190123",
  "Number2": "981401",
  "UpdatedDate": "2007-02-11T02:38:21.0108341+01:00",
  "CreatedDate": "2010-02-26T02:38:21.0108341+01:00",
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "aperiam",
      "Description": "Open-source optimizing firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 400
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "aperiam",
      "Description": "Open-source optimizing firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 400
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 313,
      "Name": "Gulgowski, Lynch and Deckow",
      "ToolTip": "Tempore eligendi consequatur id ut totam.",
      "Deleted": false,
      "Rank": 826,
      "Type": "illo",
      "ColorBlock": 643,
      "IconHint": "autem",
      "Selected": false,
      "LastChanged": "2020-08-21T02:38:21.0108341+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "temporibus",
      "Hidden": true,
      "FullName": "Kieran Huel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 323
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "quia",
      "Description": "Realigned global website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 181
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "quia",
      "Description": "Realigned global website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 181
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "maxime",
      "StrippedValue": "et",
      "Description": "Centralized national success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 359
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "et",
      "Description": "Centralized national success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 359
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "rerum",
      "StrippedValue": "voluptas",
      "Description": "Future-proofed object-oriented budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 654
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "voluptas",
      "Description": "Future-proofed object-oriented budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 654
        }
      }
    }
  ],
  "Description": "De-engineered mobile open architecture",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "qui",
      "PersonId": 216,
      "Mrmrs": "vero",
      "Firstname": "Hollie",
      "Lastname": "Wiza",
      "MiddleName": "Kiehn, Simonis and Abbott",
      "Title": "sed",
      "Description": "Universal leading edge open system",
      "Email": "aliza_legros@dare.com",
      "FullName": "Nils Pagac",
      "DirectPhone": "380-468-7897 x21213",
      "FormalName": "Parker, Mills and Littel",
      "CountryId": 886,
      "ContactId": 718,
      "ContactName": "Dooley-Cronin",
      "Retired": 450,
      "Rank": 623,
      "ActiveInterests": 654,
      "ContactDepartment": "",
      "ContactCountryId": 503,
      "ContactOrgNr": "456562",
      "FaxPhone": "085.538.8598 x59970",
      "MobilePhone": "559.833.2515",
      "ContactPhone": "1-288-836-3700",
      "AssociateName": "Yundt Group",
      "AssociateId": 990,
      "UsePersonAddress": false,
      "ContactFax": "nihil",
      "Kanafname": "et",
      "Kanalname": "quia",
      "Post1": "nam",
      "Post2": "perspiciatis",
      "Post3": "reprehenderit",
      "EmailName": "lue@binsschimmel.biz",
      "ContactFullName": "Van Kessler DVM",
      "ActiveErpLinks": 853,
      "TicketPriorityId": 721,
      "SupportLanguageId": 775,
      "SupportAssociateId": 244,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1073289",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 970
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "ipsum",
  "Xstop": false,
  "ActiveInterests": 61,
  "GroupId": 933,
  "ActiveStatusMonitorId": 298,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 18,
  "DbiAgentId": 286,
  "DbiLastSyncronized": "2018-06-20T02:38:21.0108341+02:00",
  "DbiKey": "illum",
  "DbiLastModified": "2024-10-17T02:38:21.0108341+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 257,
  "ActiveErpLinks": 424,
  "BounceEmails": [
    "parker_howe@dachwunsch.name",
    "jennings.friesen@white.ca"
  ],
  "Domains": [
    "facilis",
    "omnis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Camylle Daron Kunde DVM",
    "SuperOffice:2": "1930922288"
  },
  "ExtraFields": {
    "ExtraFields1": "quos",
    "ExtraFields2": "natus"
  },
  "CustomFields": {
    "CustomFields1": "sapiente",
    "CustomFields2": "quidem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 780
    }
  }
}
```