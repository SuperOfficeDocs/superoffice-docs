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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 427,
  "Name": "Crooks LLC",
  "Department": "",
  "OrgNr": "1646414",
  "Number1": "1459988",
  "Number2": "642074",
  "UpdatedDate": "2009-11-07T03:24:47.3770673+01:00",
  "CreatedDate": "1998-05-20T03:24:47.3770673+02:00",
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "quod",
      "Description": "Diverse dedicated software"
    },
    {
      "Value": "quia",
      "StrippedValue": "quod",
      "Description": "Diverse dedicated software"
    }
  ],
  "Interests": [
    {
      "Id": 594,
      "Name": "Hansen-Mayer",
      "ToolTip": "Maxime iusto aspernatur quo.",
      "Deleted": false,
      "Rank": 580,
      "Type": "animi",
      "ColorBlock": 791,
      "IconHint": "repellat",
      "Selected": false,
      "LastChanged": "2015-01-11T03:24:47.3770673+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "esse",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Bailey Simonis"
    }
  ],
  "Urls": [
    {
      "Value": "dignissimos",
      "StrippedValue": "et",
      "Description": "Advanced 4th generation artificial intelligence"
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "et",
      "Description": "Advanced 4th generation artificial intelligence"
    }
  ],
  "Phones": [
    {
      "Value": "iusto",
      "StrippedValue": "ea",
      "Description": "Phased methodical knowledge base"
    },
    {
      "Value": "iusto",
      "StrippedValue": "ea",
      "Description": "Phased methodical knowledge base"
    }
  ],
  "Faxes": [
    {
      "Value": "itaque",
      "StrippedValue": "odit",
      "Description": "Focused bandwidth-monitored product"
    },
    {
      "Value": "itaque",
      "StrippedValue": "odit",
      "Description": "Focused bandwidth-monitored product"
    }
  ],
  "Description": "Cross-group multimedia array",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "magni",
      "PersonId": 830,
      "Mrmrs": "consequuntur",
      "Firstname": "Janae",
      "Lastname": "Schroeder",
      "MiddleName": "Wunsch LLC",
      "Title": "qui",
      "Description": "Stand-alone value-added pricing structure",
      "Email": "fermin.ritchie@weber.co.uk",
      "FullName": "Dr. Ilene Altenwerth",
      "DirectPhone": "1-196-629-7023 x8896",
      "FormalName": "Parker Group",
      "CountryId": 387,
      "ContactId": 264,
      "ContactName": "Sipes, Russel and Ferry",
      "Retired": 868,
      "Rank": 39,
      "ActiveInterests": 15,
      "ContactDepartment": "",
      "ContactCountryId": 857,
      "ContactOrgNr": "599463",
      "FaxPhone": "1-808-151-2006",
      "MobilePhone": "(501)682-2578 x28288",
      "ContactPhone": "418.465.3770 x5390",
      "AssociateName": "Carter LLC",
      "AssociateId": 949,
      "UsePersonAddress": false,
      "ContactFax": "totam",
      "Kanafname": "voluptatem",
      "Kanalname": "voluptates",
      "Post1": "sed",
      "Post2": "labore",
      "Post3": "nobis",
      "EmailName": "adolfo.emard@wunschborer.name",
      "ContactFullName": "Jakob Fay",
      "ActiveErpLinks": 907,
      "TicketPriorityId": 174,
      "SupportLanguageId": 78,
      "SupportAssociateId": 538,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "debitis",
  "Xstop": false,
  "ActiveInterests": 154,
  "GroupId": 537,
  "ActiveStatusMonitorId": 13,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 628,
  "DbiAgentId": 772,
  "DbiLastSyncronized": "2009-02-25T03:24:47.3770673+01:00",
  "DbiKey": "est",
  "DbiLastModified": "2005-06-26T03:24:47.3770673+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 980,
  "ActiveErpLinks": 888,
  "BounceEmails": [
    "karolann_rath@heidenreich.name",
    "jarvis_langosh@huels.name"
  ],
  "Domains": [
    "minus",
    "non"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Jody Macejkovic Jr.",
    "SuperOffice:2": "Triston Walker"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "nobis"
  },
  "CustomFields": {
    "CustomFields1": "totam",
    "CustomFields2": "quasi"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 242,
  "Name": "Zulauf, Abshire and Christiansen",
  "Department": "",
  "OrgNr": "1061088",
  "Number1": "1661948",
  "Number2": "1410802",
  "UpdatedDate": "2014-01-25T03:24:47.3926839+01:00",
  "CreatedDate": "2012-10-05T03:24:47.3926839+02:00",
  "Emails": [
    {
      "Value": "quasi",
      "StrippedValue": "voluptas",
      "Description": "User-centric client-driven knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 86
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "voluptas",
      "Description": "User-centric client-driven knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 86
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 653,
      "Name": "Jakubowski Group",
      "ToolTip": "Cupiditate dolores.",
      "Deleted": false,
      "Rank": 280,
      "Type": "et",
      "ColorBlock": 731,
      "IconHint": "possimus",
      "Selected": true,
      "LastChanged": "1997-05-02T03:24:47.3926839+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "exercitationem",
      "StyleHint": "modi",
      "Hidden": true,
      "FullName": "Aurelio Thiel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 218
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "facere",
      "StrippedValue": "eaque",
      "Description": "Synergized content-based flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 355
        }
      }
    },
    {
      "Value": "facere",
      "StrippedValue": "eaque",
      "Description": "Synergized content-based flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 355
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "nihil",
      "Description": "Advanced tangible open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 693
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "nihil",
      "Description": "Advanced tangible open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 693
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "id",
      "StrippedValue": "quia",
      "Description": "Networked actuating migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 921
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "quia",
      "Description": "Networked actuating migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 921
        }
      }
    }
  ],
  "Description": "Vision-oriented multi-state instruction set",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sapiente",
      "PersonId": 490,
      "Mrmrs": "nemo",
      "Firstname": "Ricardo",
      "Lastname": "Stroman",
      "MiddleName": "Klocko, Cassin and Farrell",
      "Title": "dolorem",
      "Description": "Devolved client-server task-force",
      "Email": "gabe_rutherford@lindgren.com",
      "FullName": "Pearl Hodkiewicz",
      "DirectPhone": "(230)130-3305 x70119",
      "FormalName": "Gerlach Inc and Sons",
      "CountryId": 73,
      "ContactId": 40,
      "ContactName": "Hammes Inc and Sons",
      "Retired": 237,
      "Rank": 587,
      "ActiveInterests": 356,
      "ContactDepartment": "",
      "ContactCountryId": 102,
      "ContactOrgNr": "793546",
      "FaxPhone": "1-696-609-5105 x72823",
      "MobilePhone": "1-180-215-9158 x19946",
      "ContactPhone": "164-768-5318 x0502",
      "AssociateName": "O'Keefe LLC",
      "AssociateId": 887,
      "UsePersonAddress": true,
      "ContactFax": "ut",
      "Kanafname": "amet",
      "Kanalname": "laudantium",
      "Post1": "dolorem",
      "Post2": "aperiam",
      "Post3": "quisquam",
      "EmailName": "jeramy@collins.us",
      "ContactFullName": "Amara Lesch I",
      "ActiveErpLinks": 905,
      "TicketPriorityId": 61,
      "SupportLanguageId": 247,
      "SupportAssociateId": 713,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 908
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "quis",
  "Xstop": false,
  "ActiveInterests": 804,
  "GroupId": 113,
  "ActiveStatusMonitorId": 53,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 680,
  "DbiAgentId": 978,
  "DbiLastSyncronized": "1997-12-08T03:24:47.3926839+01:00",
  "DbiKey": "pariatur",
  "DbiLastModified": "2020-08-05T03:24:47.3926839+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 688,
  "ActiveErpLinks": 592,
  "BounceEmails": [
    "amely.treutel@hermann.com",
    "marvin_greenfelder@mcglynn.us"
  ],
  "Domains": [
    "modi",
    "consequuntur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "423976160",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "provident",
    "ExtraFields2": "assumenda"
  },
  "CustomFields": {
    "CustomFields1": "modi",
    "CustomFields2": "distinctio"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 42
    }
  }
}
```