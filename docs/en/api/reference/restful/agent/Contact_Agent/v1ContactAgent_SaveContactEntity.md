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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 584,
  "Name": "Sporer-Trantow",
  "Department": "",
  "OrgNr": "1216394",
  "Number1": "1429858",
  "Number2": "1463982",
  "UpdatedDate": "2013-06-06T14:45:05.0533582+02:00",
  "CreatedDate": "2019-09-17T14:45:05.0533582+02:00",
  "Emails": [
    {
      "Value": "culpa",
      "StrippedValue": "alias",
      "Description": "Synchronised local artificial intelligence"
    },
    {
      "Value": "culpa",
      "StrippedValue": "alias",
      "Description": "Synchronised local artificial intelligence"
    }
  ],
  "Interests": [
    {
      "Id": 872,
      "Name": "Grady, Leuschke and Simonis",
      "ToolTip": "Repellendus eos et.",
      "Deleted": false,
      "Rank": 143,
      "Type": "deleniti",
      "ColorBlock": 324,
      "IconHint": "nisi",
      "Selected": true,
      "LastChanged": "2011-08-08T14:45:05.0533582+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "voluptates",
      "Hidden": true,
      "FullName": "Miss Gail Dibbert"
    }
  ],
  "Urls": [
    {
      "Value": "sint",
      "StrippedValue": "nisi",
      "Description": "Centralized responsive framework"
    },
    {
      "Value": "sint",
      "StrippedValue": "nisi",
      "Description": "Centralized responsive framework"
    }
  ],
  "Phones": [
    {
      "Value": "saepe",
      "StrippedValue": "odit",
      "Description": "Decentralized fresh-thinking pricing structure"
    },
    {
      "Value": "saepe",
      "StrippedValue": "odit",
      "Description": "Decentralized fresh-thinking pricing structure"
    }
  ],
  "Faxes": [
    {
      "Value": "rem",
      "StrippedValue": "blanditiis",
      "Description": "Inverse maximized time-frame"
    },
    {
      "Value": "rem",
      "StrippedValue": "blanditiis",
      "Description": "Inverse maximized time-frame"
    }
  ],
  "Description": "Upgradable global info-mediaries",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "excepturi",
      "PersonId": 263,
      "Mrmrs": "architecto",
      "Firstname": "Braeden",
      "Lastname": "Glover",
      "MiddleName": "Ritchie Inc and Sons",
      "Title": "labore",
      "Description": "Open-architected analyzing toolset",
      "Email": "kennedy_trantow@schoenkonopelski.ca",
      "FullName": "Joyce Pacocha Sr.",
      "DirectPhone": "447.435.4715 x9869",
      "FormalName": "Kilback-Rice",
      "CountryId": 241,
      "ContactId": 656,
      "ContactName": "Parker, Wolf and Koepp",
      "Retired": 807,
      "Rank": 482,
      "ActiveInterests": 625,
      "ContactDepartment": "",
      "ContactCountryId": 599,
      "ContactOrgNr": "1080100",
      "FaxPhone": "1-642-539-8454",
      "MobilePhone": "770.787.4106 x99073",
      "ContactPhone": "1-149-939-9695 x2947",
      "AssociateName": "Abernathy-Lemke",
      "AssociateId": 883,
      "UsePersonAddress": true,
      "ContactFax": "ducimus",
      "Kanafname": "molestiae",
      "Kanalname": "aut",
      "Post1": "ipsam",
      "Post2": "quia",
      "Post3": "vel",
      "EmailName": "colton_bergnaum@wilderman.com",
      "ContactFullName": "Heath Steuber",
      "ActiveErpLinks": 413,
      "TicketPriorityId": 212,
      "SupportLanguageId": 554,
      "SupportAssociateId": 395,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "architecto",
  "Xstop": false,
  "ActiveInterests": 188,
  "GroupId": 91,
  "ActiveStatusMonitorId": 238,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 262,
  "DbiAgentId": 730,
  "DbiLastSyncronized": "2016-07-11T14:45:05.0533582+02:00",
  "DbiKey": "molestiae",
  "DbiLastModified": "1999-05-28T14:45:05.0533582+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 822,
  "ActiveErpLinks": 400,
  "BounceEmails": [
    "marlee.jacobs@fahey.com",
    "eldred@ebert.name"
  ],
  "Domains": [
    "eum",
    "quam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Lucienne Russel",
    "SuperOffice:2": "389482166"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatibus",
    "ExtraFields2": "placeat"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "voluptatibus"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 476,
  "Name": "Hahn, O'Conner and Cole",
  "Department": "embrace e-business interfaces",
  "OrgNr": "670396",
  "Number1": "1580014",
  "Number2": "1021132",
  "UpdatedDate": "1999-06-13T14:45:05.0533582+02:00",
  "CreatedDate": "2017-05-04T14:45:05.0533582+02:00",
  "Emails": [
    {
      "Value": "aspernatur",
      "StrippedValue": "et",
      "Description": "Face to face solution-oriented approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 680
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "et",
      "Description": "Face to face solution-oriented approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 680
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 657,
      "Name": "Yost, Wisoky and Carroll",
      "ToolTip": "Et laborum.",
      "Deleted": false,
      "Rank": 780,
      "Type": "ut",
      "ColorBlock": 509,
      "IconHint": "aperiam",
      "Selected": false,
      "LastChanged": "2007-10-16T14:45:05.0533582+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "quas",
      "Hidden": false,
      "FullName": "Kristoffer Selena Heaney Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 928
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ipsum",
      "StrippedValue": "iure",
      "Description": "Down-sized attitude-oriented product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 617
        }
      }
    },
    {
      "Value": "ipsum",
      "StrippedValue": "iure",
      "Description": "Down-sized attitude-oriented product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 617
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "vel",
      "StrippedValue": "delectus",
      "Description": "Assimilated attitude-oriented task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 490
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "delectus",
      "Description": "Assimilated attitude-oriented task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 490
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "harum",
      "StrippedValue": "provident",
      "Description": "Reduced demand-driven application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 614
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "provident",
      "Description": "Reduced demand-driven application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 614
        }
      }
    }
  ],
  "Description": "Pre-emptive executive concept",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "omnis",
      "PersonId": 178,
      "Mrmrs": "enim",
      "Firstname": "Crawford",
      "Lastname": "Romaguera",
      "MiddleName": "Okuneva-O'Conner",
      "Title": "voluptatibus",
      "Description": "Multi-layered discrete moderator",
      "Email": "lela.turcotte@schroeder.ca",
      "FullName": "Margret Kilback",
      "DirectPhone": "681.869.2009",
      "FormalName": "Conn LLC",
      "CountryId": 682,
      "ContactId": 746,
      "ContactName": "Gutkowski Inc and Sons",
      "Retired": 842,
      "Rank": 847,
      "ActiveInterests": 752,
      "ContactDepartment": "",
      "ContactCountryId": 485,
      "ContactOrgNr": "891737",
      "FaxPhone": "1-556-052-3972",
      "MobilePhone": "650.064.4280",
      "ContactPhone": "1-789-945-6883",
      "AssociateName": "Sipes-Luettgen",
      "AssociateId": 5,
      "UsePersonAddress": false,
      "ContactFax": "dolore",
      "Kanafname": "repellendus",
      "Kanalname": "ullam",
      "Post1": "provident",
      "Post2": "voluptatem",
      "Post3": "ut",
      "EmailName": "al.conn@lockmanconroy.info",
      "ContactFullName": "Minerva Harber",
      "ActiveErpLinks": 594,
      "TicketPriorityId": 280,
      "SupportLanguageId": 780,
      "SupportAssociateId": 184,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 637
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "earum",
  "Xstop": false,
  "ActiveInterests": 386,
  "GroupId": 442,
  "ActiveStatusMonitorId": 287,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 258,
  "DbiAgentId": 599,
  "DbiLastSyncronized": "2009-04-21T14:45:05.0533582+02:00",
  "DbiKey": "quam",
  "DbiLastModified": "2014-10-15T14:45:05.0533582+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 947,
  "ActiveErpLinks": 91,
  "BounceEmails": [
    "orrin.haag@mclaughlinnicolas.name",
    "laurie.bayer@rippin.us"
  ],
  "Domains": [
    "assumenda",
    "quis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Diana Bosco",
    "SuperOffice:2": "Jacynthe Schmitt"
  },
  "ExtraFields": {
    "ExtraFields1": "necessitatibus",
    "ExtraFields2": "magnam"
  },
  "CustomFields": {
    "CustomFields1": "fuga",
    "CustomFields2": "facere"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 369
    }
  }
}
```