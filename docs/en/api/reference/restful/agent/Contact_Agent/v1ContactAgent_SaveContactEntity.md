---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
generated: true
---

# POST Agents/Contact/SaveContactEntity

```http
POST /api/v1/Agents/Contact/SaveContactEntity
```

Updates the existing ContactEntity or creates a new ContactEntity if the id parameter is empty








## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity 

The ContactEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

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
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 166,
  "Name": "Braun, Breitenberg and Adams",
  "Department": "",
  "OrgNr": "1585856",
  "Number1": "539890",
  "Number2": "943606",
  "UpdatedDate": "2003-11-28T14:13:39.7660185+01:00",
  "CreatedDate": "2009-12-22T14:13:39.7660185+01:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "deserunt",
      "Description": "Adaptive analyzing collaboration"
    },
    {
      "Value": "et",
      "StrippedValue": "deserunt",
      "Description": "Adaptive analyzing collaboration"
    }
  ],
  "Interests": [
    {
      "Id": 578,
      "Name": "Abbott LLC",
      "ToolTip": "Aperiam nihil.",
      "Deleted": false,
      "Rank": 420,
      "Type": "alias",
      "ColorBlock": 154,
      "IconHint": "molestias",
      "Selected": false,
      "LastChanged": "2017-11-03T14:13:39.7660185+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "ad",
      "Hidden": true,
      "FullName": "Macey Bogan"
    }
  ],
  "Urls": [
    {
      "Value": "ea",
      "StrippedValue": "et",
      "Description": "Phased 3rd generation capacity"
    },
    {
      "Value": "ea",
      "StrippedValue": "et",
      "Description": "Phased 3rd generation capacity"
    }
  ],
  "Phones": [
    {
      "Value": "quod",
      "StrippedValue": "voluptatem",
      "Description": "Cross-platform 6th generation approach"
    },
    {
      "Value": "quod",
      "StrippedValue": "voluptatem",
      "Description": "Cross-platform 6th generation approach"
    }
  ],
  "Faxes": [
    {
      "Value": "porro",
      "StrippedValue": "asperiores",
      "Description": "De-engineered high-level task-force"
    },
    {
      "Value": "porro",
      "StrippedValue": "asperiores",
      "Description": "De-engineered high-level task-force"
    }
  ],
  "Description": "Robust intermediate open system",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eos",
      "PersonId": 274,
      "Mrmrs": "est",
      "Firstname": "Kenyon",
      "Lastname": "Kunze",
      "MiddleName": "Legros, Smith and Barrows",
      "Title": "et",
      "Description": "Optional full-range utilisation",
      "Email": "natalie@tillman.biz",
      "FullName": "Regan Melody Beatty III",
      "DirectPhone": "933-628-0498",
      "FormalName": "Connelly-Friesen",
      "CountryId": 215,
      "ContactId": 303,
      "ContactName": "Bogan, Mosciski and Cronin",
      "Retired": 707,
      "Rank": 692,
      "ActiveInterests": 514,
      "ContactDepartment": "",
      "ContactCountryId": 638,
      "ContactOrgNr": "1122121",
      "FaxPhone": "238.287.4306",
      "MobilePhone": "1-966-139-5612 x402",
      "ContactPhone": "274.944.9681",
      "AssociateName": "Marquardt-Hammes",
      "AssociateId": 492,
      "UsePersonAddress": true,
      "ContactFax": "voluptate",
      "Kanafname": "tenetur",
      "Kanalname": "aut",
      "Post1": "est",
      "Post2": "necessitatibus",
      "Post3": "ut",
      "EmailName": "hattie@collierdicki.biz",
      "ContactFullName": "Arno Strosin DVM",
      "ActiveErpLinks": 726,
      "TicketPriorityId": 147,
      "SupportLanguageId": 834,
      "SupportAssociateId": 134,
      "CategoryName": "VIP Customer",
      "PersonNumber": "979043"
    }
  ],
  "NoMailing": false,
  "Kananame": "blanditiis",
  "Xstop": true,
  "ActiveInterests": 962,
  "GroupId": 220,
  "ActiveStatusMonitorId": 527,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 86,
  "DbiAgentId": 268,
  "DbiLastSyncronized": "2001-01-10T14:13:39.7660185+01:00",
  "DbiKey": "omnis",
  "DbiLastModified": "2023-04-16T14:13:39.7660185+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 761,
  "ActiveErpLinks": 25,
  "BounceEmails": [
    "theresia.tremblay@deckow.ca",
    "vernice@starkkessler.name"
  ],
  "Domains": [
    "suscipit",
    "inventore"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Jana Gorczany",
    "SuperOffice:2": "Adolf Raynor"
  },
  "ExtraFields": {
    "ExtraFields1": "repellendus",
    "ExtraFields2": "magnam"
  },
  "CustomFields": {
    "CustomFields1": "ex",
    "CustomFields2": "error"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 114,
  "Name": "Hahn LLC",
  "Department": "enable back-end e-business",
  "OrgNr": "546573",
  "Number1": "966659",
  "Number2": "856351",
  "UpdatedDate": "2003-01-03T14:13:39.7816398+01:00",
  "CreatedDate": "2015-09-25T14:13:39.7816398+02:00",
  "Emails": [
    {
      "Value": "saepe",
      "StrippedValue": "reiciendis",
      "Description": "Synergistic responsive data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 615
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "reiciendis",
      "Description": "Synergistic responsive data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 615
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 225,
      "Name": "Hickle Inc and Sons",
      "ToolTip": "Dolor qui.",
      "Deleted": false,
      "Rank": 373,
      "Type": "voluptate",
      "ColorBlock": 432,
      "IconHint": "vel",
      "Selected": false,
      "LastChanged": "2008-12-22T14:13:39.7816398+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptates",
      "StyleHint": "vitae",
      "Hidden": false,
      "FullName": "Lennie Paucek",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 173
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "accusantium",
      "StrippedValue": "fugiat",
      "Description": "Reverse-engineered local analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 479
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "fugiat",
      "Description": "Reverse-engineered local analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 479
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quaerat",
      "StrippedValue": "ut",
      "Description": "Digitized client-driven policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 496
        }
      }
    },
    {
      "Value": "quaerat",
      "StrippedValue": "ut",
      "Description": "Digitized client-driven policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 496
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "deserunt",
      "Description": "Automated disintermediate adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "deserunt",
      "Description": "Automated disintermediate adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    }
  ],
  "Description": "Organized client-driven benchmark",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolorem",
      "PersonId": 607,
      "Mrmrs": "pariatur",
      "Firstname": "Abbey",
      "Lastname": "Nader",
      "MiddleName": "Heidenreich-Shields",
      "Title": "fugit",
      "Description": "Face to face discrete protocol",
      "Email": "cordia@metz.us",
      "FullName": "Dina Marquis Hirthe III",
      "DirectPhone": "556.599.6798 x59208",
      "FormalName": "Ullrich-Murphy",
      "CountryId": 903,
      "ContactId": 234,
      "ContactName": "Ledner, Mayert and Wiza",
      "Retired": 359,
      "Rank": 156,
      "ActiveInterests": 83,
      "ContactDepartment": "",
      "ContactCountryId": 111,
      "ContactOrgNr": "416662",
      "FaxPhone": "(110)025-9859 x68582",
      "MobilePhone": "1-528-081-3427",
      "ContactPhone": "1-614-574-0454",
      "AssociateName": "D'Amore Inc and Sons",
      "AssociateId": 693,
      "UsePersonAddress": false,
      "ContactFax": "ut",
      "Kanafname": "expedita",
      "Kanalname": "et",
      "Post1": "tempore",
      "Post2": "cupiditate",
      "Post3": "reprehenderit",
      "EmailName": "natasha.moore@hills.ca",
      "ContactFullName": "Travon Zemlak",
      "ActiveErpLinks": 956,
      "TicketPriorityId": 526,
      "SupportLanguageId": 231,
      "SupportAssociateId": 493,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1873649",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 968
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "beatae",
  "Xstop": true,
  "ActiveInterests": 256,
  "GroupId": 150,
  "ActiveStatusMonitorId": 190,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 79,
  "DbiAgentId": 333,
  "DbiLastSyncronized": "2002-07-27T14:13:39.7816398+02:00",
  "DbiKey": "facere",
  "DbiLastModified": "2009-05-08T14:13:39.7816398+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 472,
  "ActiveErpLinks": 128,
  "BounceEmails": [
    "karlee@goyette.biz",
    "caitlyn@weimanndenesik.name"
  ],
  "Domains": [
    "quod",
    "non"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Linda Fay",
    "SuperOffice:2": "Laurie Ziemann"
  },
  "ExtraFields": {
    "ExtraFields1": "ullam",
    "ExtraFields2": "similique"
  },
  "CustomFields": {
    "CustomFields1": "corporis",
    "CustomFields2": "mollitia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 469
    }
  }
}
```