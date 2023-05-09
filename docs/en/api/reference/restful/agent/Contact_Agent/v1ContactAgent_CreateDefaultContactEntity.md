---
title: POST Agents/Contact/CreateDefaultContactEntity
uid: v1ContactAgent_CreateDefaultContactEntity
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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
  "ContactId": 332,
  "Name": "Shanahan-Skiles",
  "Department": "",
  "OrgNr": "1249273",
  "Number1": "1204747",
  "Number2": "1148122",
  "UpdatedDate": "2017-08-04T03:51:26.803073+02:00",
  "CreatedDate": "1997-03-20T03:51:26.803073+01:00",
  "Emails": [
    {
      "Value": "autem",
      "StrippedValue": "quasi",
      "Description": "Decentralized system-worthy Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 429
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "quasi",
      "Description": "Decentralized system-worthy Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 429
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 508,
      "Name": "Turcotte, Von and Becker",
      "ToolTip": "Quam et sit alias.",
      "Deleted": false,
      "Rank": 726,
      "Type": "amet",
      "ColorBlock": 80,
      "IconHint": "nobis",
      "Selected": true,
      "LastChanged": "2004-11-05T03:51:26.803073+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eos",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Walter Quigley",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 359
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "harum",
      "StrippedValue": "officiis",
      "Description": "Persevering content-based complexity",
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
      "Value": "harum",
      "StrippedValue": "officiis",
      "Description": "Persevering content-based complexity",
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
  "Phones": [
    {
      "Value": "odit",
      "StrippedValue": "inventore",
      "Description": "Reverse-engineered local leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 459
        }
      }
    },
    {
      "Value": "odit",
      "StrippedValue": "inventore",
      "Description": "Reverse-engineered local leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 459
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "consequatur",
      "StrippedValue": "culpa",
      "Description": "Cross-platform value-added Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 720
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "culpa",
      "Description": "Cross-platform value-added Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 720
        }
      }
    }
  ],
  "Description": "Mandatory 4th generation emulation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "debitis",
      "PersonId": 41,
      "Mrmrs": "ut",
      "Firstname": "Lesly",
      "Lastname": "Daniel",
      "MiddleName": "Roob Inc and Sons",
      "Title": "veniam",
      "Description": "Synchronised intangible budgetary management",
      "Email": "alverta_kuvalis@howe.name",
      "FullName": "Prof. Timothy Jazmin Prohaska",
      "DirectPhone": "280-674-2461",
      "FormalName": "Stracke, Gorczany and Donnelly",
      "CountryId": 456,
      "ContactId": 359,
      "ContactName": "Braun Group",
      "Retired": 701,
      "Rank": 817,
      "ActiveInterests": 898,
      "ContactDepartment": "",
      "ContactCountryId": 760,
      "ContactOrgNr": "1005262",
      "FaxPhone": "(573)349-4330",
      "MobilePhone": "1-494-938-3240",
      "ContactPhone": "074-982-4073",
      "AssociateName": "Wilkinson, Wunsch and Braun",
      "AssociateId": 468,
      "UsePersonAddress": false,
      "ContactFax": "dolor",
      "Kanafname": "consectetur",
      "Kanalname": "error",
      "Post1": "fuga",
      "Post2": "vel",
      "Post3": "dolorum",
      "EmailName": "vallie@sawayn.co.uk",
      "ContactFullName": "Dr. Petra Alex Purdy PhD",
      "ActiveErpLinks": 71,
      "TicketPriorityId": 325,
      "SupportLanguageId": 31,
      "SupportAssociateId": 923,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 212
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "consectetur",
  "Xstop": false,
  "ActiveInterests": 163,
  "GroupId": 834,
  "ActiveStatusMonitorId": 606,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 789,
  "DbiAgentId": 322,
  "DbiLastSyncronized": "2005-06-29T03:51:26.803073+02:00",
  "DbiKey": "vel",
  "DbiLastModified": "2003-08-19T03:51:26.803073+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 952,
  "ActiveErpLinks": 213,
  "BounceEmails": [
    "jillian_cummings@bailey.us",
    "nathanial@gutmann.co.uk"
  ],
  "Domains": [
    "animi",
    "quia"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Gracie Filomena Crooks",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "accusantium",
    "ExtraFields2": "deserunt"
  },
  "CustomFields": {
    "CustomFields1": "deserunt",
    "CustomFields2": "quisquam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 61
    }
  }
}
```