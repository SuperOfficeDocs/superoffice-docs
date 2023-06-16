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
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 443,
  "Name": "Senger, Casper and Upton",
  "Department": "",
  "OrgNr": "1481486",
  "Number1": "646764",
  "Number2": "672947",
  "UpdatedDate": "2003-11-29T16:00:40.3362702+01:00",
  "CreatedDate": "2006-07-30T16:00:40.3362702+02:00",
  "Emails": [
    {
      "Value": "molestias",
      "StrippedValue": "voluptates",
      "Description": "Secured grid-enabled Graphic Interface"
    },
    {
      "Value": "molestias",
      "StrippedValue": "voluptates",
      "Description": "Secured grid-enabled Graphic Interface"
    }
  ],
  "Interests": [
    {
      "Id": 604,
      "Name": "Welch LLC",
      "ToolTip": "Ut et explicabo repudiandae veniam nostrum voluptas.",
      "Deleted": true,
      "Rank": 377,
      "Type": "adipisci",
      "ColorBlock": 891,
      "IconHint": "deleniti",
      "Selected": false,
      "LastChanged": "2009-09-29T16:00:40.3362702+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "labore",
      "StyleHint": "reprehenderit",
      "Hidden": false,
      "FullName": "Alysson Clint Berge DVM"
    }
  ],
  "Urls": [
    {
      "Value": "officiis",
      "StrippedValue": "omnis",
      "Description": "Distributed foreground concept"
    },
    {
      "Value": "officiis",
      "StrippedValue": "omnis",
      "Description": "Distributed foreground concept"
    }
  ],
  "Phones": [
    {
      "Value": "debitis",
      "StrippedValue": "id",
      "Description": "Organic real-time framework"
    },
    {
      "Value": "debitis",
      "StrippedValue": "id",
      "Description": "Organic real-time framework"
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatum",
      "StrippedValue": "ad",
      "Description": "Digitized holistic protocol"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "ad",
      "Description": "Digitized holistic protocol"
    }
  ],
  "Description": "Extended mission-critical extranet",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "rerum",
      "PersonId": 464,
      "Mrmrs": "sequi",
      "Firstname": "Elva",
      "Lastname": "Mills",
      "MiddleName": "McGlynn-Tromp",
      "Title": "sit",
      "Description": "Optimized methodical throughput",
      "Email": "vance@daniel.us",
      "FullName": "Jerald Haag",
      "DirectPhone": "(939)803-7108 x81839",
      "FormalName": "Mertz LLC",
      "CountryId": 193,
      "ContactId": 494,
      "ContactName": "Greenholt LLC",
      "Retired": 19,
      "Rank": 664,
      "ActiveInterests": 811,
      "ContactDepartment": "",
      "ContactCountryId": 139,
      "ContactOrgNr": "1272173",
      "FaxPhone": "1-225-721-5559 x64957",
      "MobilePhone": "1-113-646-6581 x9095",
      "ContactPhone": "(151)190-6282 x72091",
      "AssociateName": "Krajcik-DuBuque",
      "AssociateId": 426,
      "UsePersonAddress": false,
      "ContactFax": "quod",
      "Kanafname": "voluptatem",
      "Kanalname": "aperiam",
      "Post1": "dicta",
      "Post2": "cumque",
      "Post3": "doloribus",
      "EmailName": "reynold@lednerhahn.us",
      "ContactFullName": "Tiffany Schoen",
      "ActiveErpLinks": 730,
      "TicketPriorityId": 343,
      "SupportLanguageId": 948,
      "SupportAssociateId": 595,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "qui",
  "Xstop": false,
  "ActiveInterests": 201,
  "GroupId": 630,
  "ActiveStatusMonitorId": 806,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 855,
  "DbiAgentId": 289,
  "DbiLastSyncronized": "2007-02-17T16:00:40.3362702+01:00",
  "DbiKey": "est",
  "DbiLastModified": "2008-06-24T16:00:40.3362702+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 733,
  "ActiveErpLinks": 600,
  "BounceEmails": [
    "kamren@kohler.co.uk",
    "kellie.feil@mcglynnmertz.biz"
  ],
  "Domains": [
    "et",
    "a"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "519146466",
    "SuperOffice:2": "88286187"
  },
  "ExtraFields": {
    "ExtraFields1": "eaque",
    "ExtraFields2": "veritatis"
  },
  "CustomFields": {
    "CustomFields1": "neque",
    "CustomFields2": "quaerat"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 438,
  "Name": "Abbott, Larson and Gerlach",
  "Department": "",
  "OrgNr": "1006272",
  "Number1": "1075006",
  "Number2": "617446",
  "UpdatedDate": "2014-04-11T16:00:40.3518971+02:00",
  "CreatedDate": "1996-06-18T16:00:40.3518971+02:00",
  "Emails": [
    {
      "Value": "sequi",
      "StrippedValue": "quia",
      "Description": "Extended tangible model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 536
        }
      }
    },
    {
      "Value": "sequi",
      "StrippedValue": "quia",
      "Description": "Extended tangible model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 536
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 887,
      "Name": "Nader-Johns",
      "ToolTip": "Architecto consectetur cupiditate.",
      "Deleted": true,
      "Rank": 742,
      "Type": "eveniet",
      "ColorBlock": 41,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2003-11-07T16:00:40.3518971+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "iste",
      "StyleHint": "officia",
      "Hidden": false,
      "FullName": "Kamille Zachary Pfannerstill III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 184
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "doloremque",
      "StrippedValue": "perferendis",
      "Description": "Up-sized regional database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 137
        }
      }
    },
    {
      "Value": "doloremque",
      "StrippedValue": "perferendis",
      "Description": "Up-sized regional database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 137
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "nihil",
      "Description": "Self-enabling impactful hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "nihil",
      "Description": "Self-enabling impactful hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quod",
      "StrippedValue": "illo",
      "Description": "Universal 3rd generation parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 219
        }
      }
    },
    {
      "Value": "quod",
      "StrippedValue": "illo",
      "Description": "Universal 3rd generation parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 219
        }
      }
    }
  ],
  "Description": "Devolved 4th generation moratorium",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "harum",
      "PersonId": 347,
      "Mrmrs": "in",
      "Firstname": "Kyleigh",
      "Lastname": "Carroll",
      "MiddleName": "Morissette, Hauck and Maggio",
      "Title": "qui",
      "Description": "Proactive tertiary policy",
      "Email": "mckayla_thiel@gaylord.info",
      "FullName": "Miss Verna Bins",
      "DirectPhone": "(352)247-7534",
      "FormalName": "Bode-Friesen",
      "CountryId": 447,
      "ContactId": 365,
      "ContactName": "Berge Inc and Sons",
      "Retired": 925,
      "Rank": 240,
      "ActiveInterests": 51,
      "ContactDepartment": "",
      "ContactCountryId": 514,
      "ContactOrgNr": "829427",
      "FaxPhone": "1-006-365-0945 x729",
      "MobilePhone": "(073)057-1822 x244",
      "ContactPhone": "(231)319-6906 x98176",
      "AssociateName": "Funk Group",
      "AssociateId": 76,
      "UsePersonAddress": false,
      "ContactFax": "est",
      "Kanafname": "quaerat",
      "Kanalname": "sed",
      "Post1": "et",
      "Post2": "rerum",
      "Post3": "tempora",
      "EmailName": "darian@deckow.co.uk",
      "ContactFullName": "Brice Stamm",
      "ActiveErpLinks": 628,
      "TicketPriorityId": 436,
      "SupportLanguageId": 471,
      "SupportAssociateId": 440,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 879
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "inventore",
  "Xstop": true,
  "ActiveInterests": 491,
  "GroupId": 988,
  "ActiveStatusMonitorId": 663,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 991,
  "DbiAgentId": 55,
  "DbiLastSyncronized": "2019-09-14T16:00:40.3518971+02:00",
  "DbiKey": "fugit",
  "DbiLastModified": "1999-07-12T16:00:40.3518971+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 874,
  "ActiveErpLinks": 975,
  "BounceEmails": [
    "elisha@boehmcrooks.com",
    "mertie_braun@smith.info"
  ],
  "Domains": [
    "qui",
    "dignissimos"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Jenifer Theodora Okuneva III",
    "SuperOffice:2": "Antwon Kallie Rowe II"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "nisi"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 493
    }
  }
}
```