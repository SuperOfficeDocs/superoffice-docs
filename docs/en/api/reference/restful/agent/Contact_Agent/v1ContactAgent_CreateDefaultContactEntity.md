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
  "ContactId": 100,
  "Name": "Cummerata Inc and Sons",
  "Department": "",
  "OrgNr": "667019",
  "Number1": "950210",
  "Number2": "1106691",
  "UpdatedDate": "2015-06-30T11:16:08.8659714+02:00",
  "CreatedDate": "2021-09-28T11:16:08.8659714+02:00",
  "Emails": [
    {
      "Value": "hic",
      "StrippedValue": "voluptatem",
      "Description": "Enterprise-wide encompassing extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    },
    {
      "Value": "hic",
      "StrippedValue": "voluptatem",
      "Description": "Enterprise-wide encompassing extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 290,
      "Name": "McGlynn, Greenfelder and Kovacek",
      "ToolTip": "Et facilis necessitatibus corporis.",
      "Deleted": false,
      "Rank": 752,
      "Type": "odio",
      "ColorBlock": 430,
      "IconHint": "ad",
      "Selected": false,
      "LastChanged": "2023-10-10T11:16:08.8659714+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sed",
      "StyleHint": "excepturi",
      "Hidden": false,
      "FullName": "Hardy Crist",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 312
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "placeat",
      "StrippedValue": "odit",
      "Description": "Persistent uniform neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 619
        }
      }
    },
    {
      "Value": "placeat",
      "StrippedValue": "odit",
      "Description": "Persistent uniform neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 619
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "excepturi",
      "StrippedValue": "sit",
      "Description": "Front-line regional core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 495
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "sit",
      "Description": "Front-line regional core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 495
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "modi",
      "StrippedValue": "saepe",
      "Description": "Stand-alone modular standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 264
        }
      }
    },
    {
      "Value": "modi",
      "StrippedValue": "saepe",
      "Description": "Stand-alone modular standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 264
        }
      }
    }
  ],
  "Description": "Centralized upward-trending circuit",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nihil",
      "PersonId": 905,
      "Mrmrs": "qui",
      "Firstname": "Jacinto",
      "Lastname": "Koss",
      "MiddleName": "Kohler-Quigley",
      "Title": "beatae",
      "Description": "Reactive responsive analyzer",
      "Email": "jerod.greenholt@dietrichbeatty.uk",
      "FullName": "Kiara Hahn",
      "DirectPhone": "1-079-260-6796 x1819",
      "FormalName": "Aufderhar-McCullough",
      "CountryId": 917,
      "ContactId": 450,
      "ContactName": "Feil, Dicki and Kerluke",
      "Retired": 433,
      "Rank": 601,
      "ActiveInterests": 641,
      "ContactDepartment": "architect turn-key paradigms",
      "ContactCountryId": 476,
      "ContactOrgNr": "795030",
      "FaxPhone": "1-294-234-6304 x6923",
      "MobilePhone": "074-323-6891 x6156",
      "ContactPhone": "318.927.0750",
      "AssociateName": "Emard-Kuphal",
      "AssociateId": 389,
      "UsePersonAddress": true,
      "ContactFax": "dolorem",
      "Kanafname": "voluptates",
      "Kanalname": "autem",
      "Post1": "aut",
      "Post2": "rerum",
      "Post3": "rerum",
      "EmailName": "stephanie@durgan.us",
      "ContactFullName": "Wilbert Thiel DDS",
      "ActiveErpLinks": 668,
      "TicketPriorityId": 985,
      "SupportLanguageId": 602,
      "SupportAssociateId": 463,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 280
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "labore",
  "Xstop": false,
  "ActiveInterests": 357,
  "GroupId": 802,
  "ActiveStatusMonitorId": 384,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 851,
  "DbiAgentId": 51,
  "DbiLastSyncronized": "2001-02-15T11:16:08.8659714+01:00",
  "DbiKey": "doloribus",
  "DbiLastModified": "2020-05-25T11:16:08.8659714+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 995,
  "ActiveErpLinks": 691,
  "BounceEmails": [
    "stuart_ebert@oconnell.com",
    "berta@kling.com"
  ],
  "Domains": [
    "laudantium",
    "blanditiis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Jonatan Waters",
    "SuperOffice:2": "313266177"
  },
  "ExtraFields": {
    "ExtraFields1": "cumque",
    "ExtraFields2": "excepturi"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "praesentium"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 984
    }
  }
}
```