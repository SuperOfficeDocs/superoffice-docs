---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
content_type: reference
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.
NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 694,
  "Name": "Lowe-Langosh",
  "Department": "",
  "OrgNr": "1431408",
  "Number1": "1083716",
  "Number2": "465017",
  "UpdatedDate": "2023-05-19T02:30:46.9913411+02:00",
  "CreatedDate": "2006-06-27T02:30:46.9913411+02:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "quod",
      "Description": "Reduced directional analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 999
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quod",
      "Description": "Reduced directional analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 999
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 666,
      "Name": "Anderson, Nitzsche and Bogan",
      "ToolTip": "Vero ex qui tenetur facilis velit.",
      "Deleted": false,
      "Rank": 919,
      "Type": "suscipit",
      "ColorBlock": 109,
      "IconHint": "facilis",
      "Selected": false,
      "LastChanged": "2000-04-05T02:30:46.9913411+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "reiciendis",
      "StyleHint": "fuga",
      "Hidden": false,
      "FullName": "Marco Bins",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 395
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptate",
      "StrippedValue": "ad",
      "Description": "Programmable didactic capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 471
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "ad",
      "Description": "Programmable didactic capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 471
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "dolorum",
      "StrippedValue": "qui",
      "Description": "Networked context-sensitive artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 742
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "qui",
      "Description": "Networked context-sensitive artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 742
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "cum",
      "StrippedValue": "voluptatem",
      "Description": "Polarised next generation complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    },
    {
      "Value": "cum",
      "StrippedValue": "voluptatem",
      "Description": "Polarised next generation complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    }
  ],
  "Description": "Adaptive analyzing benchmark",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "fugit",
      "PersonId": 704,
      "Mrmrs": "aut",
      "Firstname": "Johnson",
      "Lastname": "Beer",
      "MiddleName": "Lueilwitz, Doyle and Hegmann",
      "Title": "et",
      "Description": "Persistent bi-directional interface",
      "Email": "brenden_boyle@cassin.info",
      "FullName": "Mrs. Oren Kaden Pagac II",
      "DirectPhone": "352.025.5855 x139",
      "FormalName": "Spinka-Schamberger",
      "CountryId": 436,
      "ContactId": 49,
      "ContactName": "Howell Group",
      "Retired": 819,
      "Rank": 679,
      "ActiveInterests": 841,
      "ContactDepartment": "redefine user-centric channels",
      "ContactCountryId": 569,
      "ContactOrgNr": "670108",
      "FaxPhone": "698.194.1324",
      "MobilePhone": "691-047-3806 x253",
      "ContactPhone": "1-253-374-0820",
      "AssociateName": "Mohr, Deckow and Emard",
      "AssociateId": 637,
      "UsePersonAddress": false,
      "ContactFax": "quae",
      "Kanafname": "perspiciatis",
      "Kanalname": "voluptatem",
      "Post1": "corrupti",
      "Post2": "sunt",
      "Post3": "deleniti",
      "EmailName": "reid.cole@runtetillman.biz",
      "ContactFullName": "Ophelia Price",
      "ActiveErpLinks": 70,
      "TicketPriorityId": 887,
      "SupportLanguageId": 515,
      "SupportAssociateId": 377,
      "CategoryName": "VIP Customer",
      "PersonNumber": "432023",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 178
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "veniam",
  "Xstop": true,
  "ActiveInterests": 312,
  "GroupId": 309,
  "ActiveStatusMonitorId": 964,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 150,
  "DbiAgentId": 939,
  "DbiLastSyncronized": "2000-08-12T02:30:46.9913411+02:00",
  "DbiKey": "delectus",
  "DbiLastModified": "2006-11-13T02:30:46.9913411+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 853,
  "ActiveErpLinks": 487,
  "BounceEmails": [
    "rickey_schinner@oconner.uk",
    "virginia.gleason@balistreri.com"
  ],
  "Domains": [
    "vero",
    "molestiae"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "543106276",
    "SuperOffice:2": "Jayson Schimmel"
  },
  "ExtraFields": {
    "ExtraFields1": "quasi",
    "ExtraFields2": "voluptates"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "sed"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 933
    }
  }
}
```