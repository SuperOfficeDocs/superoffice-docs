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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 677,
  "Name": "Beahan, Wunsch and Romaguera",
  "Department": "",
  "OrgNr": "1124422",
  "Number1": "77970",
  "Number2": "607399",
  "UpdatedDate": "2010-07-04T23:03:55.2631392+02:00",
  "CreatedDate": "2001-04-17T23:03:55.2631392+02:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "minima",
      "Description": "Distributed bi-directional internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 22
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "minima",
      "Description": "Distributed bi-directional internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 22
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 639,
      "Name": "Schaefer Group",
      "ToolTip": "Nobis rerum qui ad expedita quidem omnis.",
      "Deleted": false,
      "Rank": 162,
      "Type": "et",
      "ColorBlock": 926,
      "IconHint": "dolorum",
      "Selected": false,
      "LastChanged": "2004-02-24T23:03:55.2631392+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "laborum",
      "Hidden": false,
      "FullName": "Donnie Ernser",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 545
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "numquam",
      "StrippedValue": "itaque",
      "Description": "Realigned logistical attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 367
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "itaque",
      "Description": "Realigned logistical attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 367
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sit",
      "StrippedValue": "quibusdam",
      "Description": "Multi-channelled tangible interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 797
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "quibusdam",
      "Description": "Multi-channelled tangible interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 797
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "omnis",
      "StrippedValue": "aut",
      "Description": "Ergonomic systemic neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 811
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "aut",
      "Description": "Ergonomic systemic neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 811
        }
      }
    }
  ],
  "Description": "Compatible zero tolerance leverage",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "perspiciatis",
      "PersonId": 614,
      "Mrmrs": "molestiae",
      "Firstname": "Ted",
      "Lastname": "Cole",
      "MiddleName": "Kling, Cummerata and Barton",
      "Title": "sint",
      "Description": "User-centric directional installation",
      "Email": "alek_schumm@hodkiewiczdeckow.name",
      "FullName": "Mrs. Gennaro Huels",
      "DirectPhone": "436.839.1175 x802",
      "FormalName": "Monahan, Moore and Lubowitz",
      "CountryId": 938,
      "ContactId": 864,
      "ContactName": "Tremblay-Nikolaus",
      "Retired": 238,
      "Rank": 601,
      "ActiveInterests": 249,
      "ContactDepartment": "",
      "ContactCountryId": 746,
      "ContactOrgNr": "556543",
      "FaxPhone": "258.415.2547 x2997",
      "MobilePhone": "1-482-635-3113",
      "ContactPhone": "115.602.1171",
      "AssociateName": "DuBuque Group",
      "AssociateId": 966,
      "UsePersonAddress": true,
      "ContactFax": "illum",
      "Kanafname": "omnis",
      "Kanalname": "porro",
      "Post1": "saepe",
      "Post2": "et",
      "Post3": "pariatur",
      "EmailName": "juvenal@watersosinski.uk",
      "ContactFullName": "Kimberly Kemmer V",
      "ActiveErpLinks": 68,
      "TicketPriorityId": 447,
      "SupportLanguageId": 740,
      "SupportAssociateId": 664,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 688
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "et",
  "Xstop": false,
  "ActiveInterests": 2,
  "GroupId": 596,
  "ActiveStatusMonitorId": 908,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 456,
  "DbiAgentId": 789,
  "DbiLastSyncronized": "1997-08-10T23:03:55.2676408+02:00",
  "DbiKey": "id",
  "DbiLastModified": "2009-03-30T23:03:55.2676408+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 872,
  "ActiveErpLinks": 537,
  "BounceEmails": [
    "milan@kreigerharvey.com",
    "myles_altenwerth@greenholt.us"
  ],
  "Domains": [
    "quia",
    "reiciendis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Orpha Nolan"
  },
  "ExtraFields": {
    "ExtraFields1": "molestiae",
    "ExtraFields2": "eaque"
  },
  "CustomFields": {
    "CustomFields1": "debitis",
    "CustomFields2": "hic"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 218
    }
  }
}
```