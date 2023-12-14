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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 574,
  "Name": "Kassulke-Rempel",
  "Department": "",
  "OrgNr": "661021",
  "Number1": "1100350",
  "Number2": "1513127",
  "UpdatedDate": "2020-12-10T13:57:11.8705616+01:00",
  "CreatedDate": "2010-11-27T13:57:11.8705616+01:00",
  "Emails": [
    {
      "Value": "sed",
      "StrippedValue": "quisquam",
      "Description": "Open-architected background project"
    },
    {
      "Value": "sed",
      "StrippedValue": "quisquam",
      "Description": "Open-architected background project"
    }
  ],
  "Interests": [
    {
      "Id": 145,
      "Name": "Pfannerstill, Jacobs and Greenfelder",
      "ToolTip": "Laborum inventore et dolorem quia et sed ea.",
      "Deleted": false,
      "Rank": 427,
      "Type": "rerum",
      "ColorBlock": 855,
      "IconHint": "quod",
      "Selected": false,
      "LastChanged": "1998-02-05T13:57:11.8705616+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "officiis",
      "Hidden": true,
      "FullName": "Johnpaul Crist"
    }
  ],
  "Urls": [
    {
      "Value": "temporibus",
      "StrippedValue": "architecto",
      "Description": "Horizontal modular interface"
    },
    {
      "Value": "temporibus",
      "StrippedValue": "architecto",
      "Description": "Horizontal modular interface"
    }
  ],
  "Phones": [
    {
      "Value": "explicabo",
      "StrippedValue": "excepturi",
      "Description": "Future-proofed tangible instruction set"
    },
    {
      "Value": "explicabo",
      "StrippedValue": "excepturi",
      "Description": "Future-proofed tangible instruction set"
    }
  ],
  "Faxes": [
    {
      "Value": "eligendi",
      "StrippedValue": "explicabo",
      "Description": "Ameliorated human-resource standardization"
    },
    {
      "Value": "eligendi",
      "StrippedValue": "explicabo",
      "Description": "Ameliorated human-resource standardization"
    }
  ],
  "Description": "Function-based homogeneous leverage",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aperiam",
      "PersonId": 842,
      "Mrmrs": "nam",
      "Firstname": "Freida",
      "Lastname": "Purdy",
      "MiddleName": "Bartell, Kulas and Stiedemann",
      "Title": "ut",
      "Description": "Pre-emptive multi-state moderator",
      "Email": "sonia.emmerich@maggio.ca",
      "FullName": "Prof. Ines Schumm V",
      "DirectPhone": "840-811-1612",
      "FormalName": "Ondricka-Huel",
      "CountryId": 851,
      "ContactId": 862,
      "ContactName": "Quigley LLC",
      "Retired": 176,
      "Rank": 911,
      "ActiveInterests": 18,
      "ContactDepartment": "",
      "ContactCountryId": 124,
      "ContactOrgNr": "1436471",
      "FaxPhone": "361-231-1735 x487",
      "MobilePhone": "1-883-884-8448",
      "ContactPhone": "(149)336-1288 x58197",
      "AssociateName": "Ortiz, Hoppe and Hilll",
      "AssociateId": 415,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "omnis",
      "Kanalname": "aut",
      "Post1": "eaque",
      "Post2": "itaque",
      "Post3": "voluptatibus",
      "EmailName": "aric.stoltenberg@gutkowskiwehner.us",
      "ContactFullName": "Loy Price",
      "ActiveErpLinks": 505,
      "TicketPriorityId": 482,
      "SupportLanguageId": 221,
      "SupportAssociateId": 386,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "sit",
  "Xstop": false,
  "ActiveInterests": 316,
  "GroupId": 533,
  "ActiveStatusMonitorId": 610,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 252,
  "DbiAgentId": 918,
  "DbiLastSyncronized": "2014-09-19T13:57:11.8705616+02:00",
  "DbiKey": "veritatis",
  "DbiLastModified": "2001-11-24T13:57:11.8705616+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 767,
  "ActiveErpLinks": 258,
  "BounceEmails": [
    "tiffany_conn@leuschkestreich.com",
    "lourdes_breitenberg@luettgen.biz"
  ],
  "Domains": [
    "et",
    "quo"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Melisa Lemke",
    "SuperOffice:2": "1036760653"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "vel"
  },
  "CustomFields": {
    "CustomFields1": "impedit",
    "CustomFields2": "facilis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 582,
  "Name": "Lemke Group",
  "Department": "",
  "OrgNr": "1479148",
  "Number1": "1825120",
  "Number2": "1422329",
  "UpdatedDate": "2003-12-10T13:57:11.8861856+01:00",
  "CreatedDate": "2019-02-05T13:57:11.8861856+01:00",
  "Emails": [
    {
      "Value": "porro",
      "StrippedValue": "ut",
      "Description": "Switchable encompassing knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 73
        }
      }
    },
    {
      "Value": "porro",
      "StrippedValue": "ut",
      "Description": "Switchable encompassing knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 73
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 16,
      "Name": "Collins-Torp",
      "ToolTip": "Consequatur quibusdam aut sit.",
      "Deleted": false,
      "Rank": 760,
      "Type": "aut",
      "ColorBlock": 420,
      "IconHint": "assumenda",
      "Selected": false,
      "LastChanged": "2018-05-10T13:57:11.8861856+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "earum",
      "StyleHint": "asperiores",
      "Hidden": true,
      "FullName": "Daija Lesch",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 620
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "officiis",
      "StrippedValue": "quisquam",
      "Description": "Integrated solution-oriented orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 749
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "quisquam",
      "Description": "Integrated solution-oriented orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 749
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "dolorem",
      "StrippedValue": "aperiam",
      "Description": "Public-key exuding policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 98
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "aperiam",
      "Description": "Public-key exuding policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 98
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "illo",
      "StrippedValue": "eos",
      "Description": "Cross-group clear-thinking leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 812
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "eos",
      "Description": "Cross-group clear-thinking leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 812
        }
      }
    }
  ],
  "Description": "Upgradable client-driven synergy",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptatem",
      "PersonId": 657,
      "Mrmrs": "praesentium",
      "Firstname": "Andre",
      "Lastname": "Torphy",
      "MiddleName": "Langworth, Hamill and Lind",
      "Title": "consequuntur",
      "Description": "Future-proofed heuristic challenge",
      "Email": "charlie.hackett@casper.name",
      "FullName": "Ms. Ulices Huel",
      "DirectPhone": "383.340.7311 x87602",
      "FormalName": "Turcotte Inc and Sons",
      "CountryId": 464,
      "ContactId": 277,
      "ContactName": "Schowalter, Fahey and Ziemann",
      "Retired": 770,
      "Rank": 40,
      "ActiveInterests": 124,
      "ContactDepartment": "",
      "ContactCountryId": 907,
      "ContactOrgNr": "942071",
      "FaxPhone": "641-088-1251 x4296",
      "MobilePhone": "915.155.9702 x31971",
      "ContactPhone": "423.935.1119 x25798",
      "AssociateName": "Rippin-Nader",
      "AssociateId": 599,
      "UsePersonAddress": false,
      "ContactFax": "sint",
      "Kanafname": "veritatis",
      "Kanalname": "sequi",
      "Post1": "eius",
      "Post2": "quaerat",
      "Post3": "sed",
      "EmailName": "samanta@mcclure.us",
      "ContactFullName": "Kylee Skiles",
      "ActiveErpLinks": 588,
      "TicketPriorityId": 409,
      "SupportLanguageId": 291,
      "SupportAssociateId": 247,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 119
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "neque",
  "Xstop": true,
  "ActiveInterests": 1002,
  "GroupId": 809,
  "ActiveStatusMonitorId": 104,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 947,
  "DbiAgentId": 524,
  "DbiLastSyncronized": "2000-01-03T13:57:11.8861856+01:00",
  "DbiKey": "deleniti",
  "DbiLastModified": "2020-07-18T13:57:11.8861856+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 115,
  "ActiveErpLinks": 384,
  "BounceEmails": [
    "erica_gusikowski@bartolettikihn.biz",
    "kaitlyn_mayer@lebsack.com"
  ],
  "Domains": [
    "natus",
    "fugiat"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Nelda Weimann"
  },
  "ExtraFields": {
    "ExtraFields1": "eum",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "architecto",
    "CustomFields2": "consequatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 641
    }
  }
}
```