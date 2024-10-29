---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
generated: true
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=768
POST /api/v1/Agents/Contact/GetContactEntity?$select=name,department,category/id
```


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
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 14,
  "Name": "Walker-Dibbert",
  "Department": "",
  "OrgNr": "703252",
  "Number1": "607416",
  "Number2": "749157",
  "UpdatedDate": "2015-10-24T13:14:05.6632674+02:00",
  "CreatedDate": "2016-07-07T13:14:05.6632674+02:00",
  "Emails": [
    {
      "Value": "sunt",
      "StrippedValue": "praesentium",
      "Description": "Vision-oriented regional neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 836
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "praesentium",
      "Description": "Vision-oriented regional neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 836
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 822,
      "Name": "Kovacek LLC",
      "ToolTip": "Labore dolor aliquid saepe.",
      "Deleted": false,
      "Rank": 593,
      "Type": "blanditiis",
      "ColorBlock": 248,
      "IconHint": "natus",
      "Selected": false,
      "LastChanged": "2018-02-24T13:14:05.6632674+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "necessitatibus",
      "StyleHint": "amet",
      "Hidden": true,
      "FullName": "Dr. Pamela Kennith Runte",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 249
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "dolorem",
      "StrippedValue": "omnis",
      "Description": "Phased multi-tasking moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 870
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "omnis",
      "Description": "Phased multi-tasking moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 870
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ducimus",
      "StrippedValue": "voluptatibus",
      "Description": "Expanded eco-centric hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 594
        }
      }
    },
    {
      "Value": "ducimus",
      "StrippedValue": "voluptatibus",
      "Description": "Expanded eco-centric hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 594
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nesciunt",
      "StrippedValue": "ullam",
      "Description": "Mandatory radical frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 417
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "ullam",
      "Description": "Mandatory radical frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 417
        }
      }
    }
  ],
  "Description": "Mandatory exuding concept",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolorem",
      "PersonId": 938,
      "Mrmrs": "id",
      "Firstname": "Ruthie",
      "Lastname": "Collier",
      "MiddleName": "Davis LLC",
      "Title": "totam",
      "Description": "Realigned local task-force",
      "Email": "irving@bogisich.info",
      "FullName": "Jadon Nikolaus",
      "DirectPhone": "636.371.9742 x7205",
      "FormalName": "Jacobs-Cormier",
      "CountryId": 566,
      "ContactId": 667,
      "ContactName": "Klein, Dooley and Casper",
      "Retired": 149,
      "Rank": 381,
      "ActiveInterests": 549,
      "ContactDepartment": "",
      "ContactCountryId": 659,
      "ContactOrgNr": "909513",
      "FaxPhone": "(246)653-0711 x80927",
      "MobilePhone": "1-413-044-2141 x9127",
      "ContactPhone": "(168)691-3208",
      "AssociateName": "Harber-Kuvalis",
      "AssociateId": 857,
      "UsePersonAddress": true,
      "ContactFax": "exercitationem",
      "Kanafname": "voluptas",
      "Kanalname": "et",
      "Post1": "sit",
      "Post2": "soluta",
      "Post3": "modi",
      "EmailName": "maribel@okeefe.com",
      "ContactFullName": "Prof. Damon Leffler",
      "ActiveErpLinks": 176,
      "TicketPriorityId": 680,
      "SupportLanguageId": 477,
      "SupportAssociateId": 443,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 933
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quia",
  "Xstop": false,
  "ActiveInterests": 11,
  "GroupId": 306,
  "ActiveStatusMonitorId": 28,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 763,
  "DbiAgentId": 68,
  "DbiLastSyncronized": "2009-06-24T13:14:05.6632674+02:00",
  "DbiKey": "voluptates",
  "DbiLastModified": "2010-02-01T13:14:05.6632674+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 545,
  "ActiveErpLinks": 591,
  "BounceEmails": [
    "jamison_wyman@bernhard.uk",
    "kelsi@gleasonschaefer.com"
  ],
  "Domains": [
    "et",
    "fugiat"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Reed Ferry",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "itaque",
    "ExtraFields2": "earum"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "iusto"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 880
    }
  }
}
```