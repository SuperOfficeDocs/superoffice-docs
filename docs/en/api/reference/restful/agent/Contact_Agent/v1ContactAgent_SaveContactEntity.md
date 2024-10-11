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
  "ContactId": 926,
  "Name": "Turner-Parisian",
  "Department": "",
  "OrgNr": "1254268",
  "Number1": "819245",
  "Number2": "1158219",
  "UpdatedDate": "2022-10-09T03:44:52.2927719+02:00",
  "CreatedDate": "2016-09-27T03:44:52.2927719+02:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "cumque",
      "Description": "Switchable composite monitoring"
    },
    {
      "Value": "et",
      "StrippedValue": "cumque",
      "Description": "Switchable composite monitoring"
    }
  ],
  "Interests": [
    {
      "Id": 570,
      "Name": "Boyle, Kutch and Rice",
      "ToolTip": "Ut atque eos est labore tempore et repellat.",
      "Deleted": true,
      "Rank": 955,
      "Type": "voluptas",
      "ColorBlock": 42,
      "IconHint": "perferendis",
      "Selected": true,
      "LastChanged": "1999-02-25T03:44:52.2927719+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quod",
      "StyleHint": "eaque",
      "Hidden": true,
      "FullName": "Mr. Carolyn Erik Maggio I"
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "nihil",
      "Description": "Reduced 4th generation framework"
    },
    {
      "Value": "qui",
      "StrippedValue": "nihil",
      "Description": "Reduced 4th generation framework"
    }
  ],
  "Phones": [
    {
      "Value": "hic",
      "StrippedValue": "accusantium",
      "Description": "Universal methodical protocol"
    },
    {
      "Value": "hic",
      "StrippedValue": "accusantium",
      "Description": "Universal methodical protocol"
    }
  ],
  "Faxes": [
    {
      "Value": "ex",
      "StrippedValue": "nisi",
      "Description": "Cross-group discrete knowledge base"
    },
    {
      "Value": "ex",
      "StrippedValue": "nisi",
      "Description": "Cross-group discrete knowledge base"
    }
  ],
  "Description": "Mandatory object-oriented groupware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "veritatis",
      "PersonId": 758,
      "Mrmrs": "pariatur",
      "Firstname": "Candelario",
      "Lastname": "Morar",
      "MiddleName": "Pouros-Hagenes",
      "Title": "sequi",
      "Description": "Exclusive tangible array",
      "Email": "ressie@tremblay.co.uk",
      "FullName": "Brycen Quigley",
      "DirectPhone": "(173)988-0468",
      "FormalName": "Kunze Inc and Sons",
      "CountryId": 624,
      "ContactId": 413,
      "ContactName": "Abshire-Johns",
      "Retired": 89,
      "Rank": 862,
      "ActiveInterests": 896,
      "ContactDepartment": "",
      "ContactCountryId": 407,
      "ContactOrgNr": "1175273",
      "FaxPhone": "349-501-8368",
      "MobilePhone": "(676)537-1376",
      "ContactPhone": "095-730-6018",
      "AssociateName": "Zboncak-Johns",
      "AssociateId": 777,
      "UsePersonAddress": true,
      "ContactFax": "velit",
      "Kanafname": "asperiores",
      "Kanalname": "iusto",
      "Post1": "quia",
      "Post2": "vel",
      "Post3": "temporibus",
      "EmailName": "julia.runte@koelpin.biz",
      "ContactFullName": "Mr. Nelle Brionna Corkery IV",
      "ActiveErpLinks": 590,
      "TicketPriorityId": 571,
      "SupportLanguageId": 285,
      "SupportAssociateId": 517,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "qui",
  "Xstop": false,
  "ActiveInterests": 928,
  "GroupId": 285,
  "ActiveStatusMonitorId": 914,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 938,
  "DbiAgentId": 727,
  "DbiLastSyncronized": "2019-08-26T03:44:52.2927719+02:00",
  "DbiKey": "eius",
  "DbiLastModified": "2014-11-07T03:44:52.2927719+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 702,
  "ActiveErpLinks": 312,
  "BounceEmails": [
    "juliana_king@ondrickaolson.ca",
    "jackson_rowe@tillmanpredovic.co.uk"
  ],
  "Domains": [
    "repellendus",
    "nobis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1011103158",
    "SuperOffice:2": "813505063"
  },
  "ExtraFields": {
    "ExtraFields1": "tempora",
    "ExtraFields2": "odit"
  },
  "CustomFields": {
    "CustomFields1": "asperiores",
    "CustomFields2": "est"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 248,
  "Name": "Hyatt, Ortiz and Nikolaus",
  "Department": "",
  "OrgNr": "679860",
  "Number1": "1400615",
  "Number2": "1119872",
  "UpdatedDate": "2005-03-12T03:44:52.2927719+01:00",
  "CreatedDate": "2005-10-02T03:44:52.2927719+02:00",
  "Emails": [
    {
      "Value": "ducimus",
      "StrippedValue": "facilis",
      "Description": "Multi-channelled bi-directional frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 120
        }
      }
    },
    {
      "Value": "ducimus",
      "StrippedValue": "facilis",
      "Description": "Multi-channelled bi-directional frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 120
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 170,
      "Name": "Ferry, Kutch and Pfeffer",
      "ToolTip": "Tenetur quae provident illum.",
      "Deleted": false,
      "Rank": 813,
      "Type": "dicta",
      "ColorBlock": 914,
      "IconHint": "beatae",
      "Selected": false,
      "LastChanged": "2013-03-01T03:44:52.2927719+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "odio",
      "StyleHint": "quibusdam",
      "Hidden": true,
      "FullName": "Ms. Polly Kali Prohaska",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 205
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptatum",
      "StrippedValue": "voluptatem",
      "Description": "Monitored mobile paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 452
        }
      }
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "voluptatem",
      "Description": "Monitored mobile paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 452
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "possimus",
      "StrippedValue": "recusandae",
      "Description": "Reactive encompassing archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 475
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "recusandae",
      "Description": "Reactive encompassing archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 475
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "doloribus",
      "Description": "Customizable bifurcated emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 299
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "doloribus",
      "Description": "Customizable bifurcated emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 299
        }
      }
    }
  ],
  "Description": "Ameliorated neutral solution",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "non",
      "PersonId": 507,
      "Mrmrs": "sunt",
      "Firstname": "Abigale",
      "Lastname": "Rippin",
      "MiddleName": "Stehr, Sanford and Langosh",
      "Title": "laudantium",
      "Description": "Multi-tiered 6th generation support",
      "Email": "theron.mann@lemke.uk",
      "FullName": "Mr. Nels Ernser V",
      "DirectPhone": "1-212-368-9967 x07569",
      "FormalName": "Blanda-Crooks",
      "CountryId": 446,
      "ContactId": 903,
      "ContactName": "Funk LLC",
      "Retired": 305,
      "Rank": 546,
      "ActiveInterests": 337,
      "ContactDepartment": "",
      "ContactCountryId": 507,
      "ContactOrgNr": "1004026",
      "FaxPhone": "1-867-953-7329 x266",
      "MobilePhone": "1-710-609-9592 x757",
      "ContactPhone": "1-711-742-2392 x24600",
      "AssociateName": "Brown Inc and Sons",
      "AssociateId": 20,
      "UsePersonAddress": false,
      "ContactFax": "neque",
      "Kanafname": "vel",
      "Kanalname": "mollitia",
      "Post1": "ullam",
      "Post2": "iure",
      "Post3": "sit",
      "EmailName": "noble_marks@turner.uk",
      "ContactFullName": "Jeanette Bogisich",
      "ActiveErpLinks": 149,
      "TicketPriorityId": 686,
      "SupportLanguageId": 580,
      "SupportAssociateId": 221,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 907
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quia",
  "Xstop": true,
  "ActiveInterests": 852,
  "GroupId": 915,
  "ActiveStatusMonitorId": 75,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 114,
  "DbiAgentId": 828,
  "DbiLastSyncronized": "2008-11-01T03:44:52.2927719+01:00",
  "DbiKey": "et",
  "DbiLastModified": "2017-05-07T03:44:52.2927719+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 146,
  "ActiveErpLinks": 70,
  "BounceEmails": [
    "kelsie_harris@raynornitzsche.uk",
    "skylar.emard@hilpert.name"
  ],
  "Domains": [
    "fugiat",
    "ipsa"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Alanna Maximillian Denesik",
    "SuperOffice:2": "1440678843"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "veniam"
  },
  "CustomFields": {
    "CustomFields1": "maiores",
    "CustomFields2": "fugiat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 265
    }
  }
}
```