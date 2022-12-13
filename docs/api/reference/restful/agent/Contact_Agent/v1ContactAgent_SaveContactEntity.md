---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
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
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 467,
  "Name": "Jacobs Inc and Sons",
  "Department": "",
  "OrgNr": "1540479",
  "Number1": "106466",
  "Number2": "905204",
  "UpdatedDate": "2005-01-13T02:49:43.8879031+01:00",
  "CreatedDate": "1996-01-14T02:49:43.8879031+01:00",
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "nihil",
      "Description": "Profit-focused real-time flexibility"
    },
    {
      "Value": "ut",
      "StrippedValue": "nihil",
      "Description": "Profit-focused real-time flexibility"
    }
  ],
  "Interests": [
    {
      "Id": 642,
      "Name": "Keebler-Frami",
      "ToolTip": "Veniam est et modi officia.",
      "Deleted": true,
      "Rank": 255,
      "Type": "dignissimos",
      "ColorBlock": 158,
      "IconHint": "eos",
      "Selected": false,
      "LastChanged": "2003-03-08T02:49:43.8879031+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "minus",
      "StyleHint": "omnis",
      "Hidden": false,
      "FullName": "Jayson Schowalter"
    }
  ],
  "Urls": [
    {
      "Value": "iure",
      "StrippedValue": "asperiores",
      "Description": "Total disintermediate migration"
    },
    {
      "Value": "iure",
      "StrippedValue": "asperiores",
      "Description": "Total disintermediate migration"
    }
  ],
  "Phones": [
    {
      "Value": "sed",
      "StrippedValue": "voluptas",
      "Description": "Networked 24 hour portal"
    },
    {
      "Value": "sed",
      "StrippedValue": "voluptas",
      "Description": "Networked 24 hour portal"
    }
  ],
  "Faxes": [
    {
      "Value": "minima",
      "StrippedValue": "dolor",
      "Description": "Fully-configurable regional standardization"
    },
    {
      "Value": "minima",
      "StrippedValue": "dolor",
      "Description": "Fully-configurable regional standardization"
    }
  ],
  "Description": "Extended optimizing capability",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sed",
      "PersonId": 998,
      "Mrmrs": "fugiat",
      "Firstname": "Dan",
      "Lastname": "Pfeffer",
      "MiddleName": "Pfeffer Group",
      "Title": "perspiciatis",
      "Description": "Visionary client-server intranet",
      "Email": "jules.konopelski@heaney.info",
      "FullName": "Shanelle Steuber",
      "DirectPhone": "1-774-156-6948",
      "FormalName": "Grady, Schowalter and O'Keefe",
      "CountryId": 136,
      "ContactId": 954,
      "ContactName": "Cassin-Buckridge",
      "Retired": 513,
      "Rank": 292,
      "ActiveInterests": 815,
      "ContactDepartment": "",
      "ContactCountryId": 999,
      "ContactOrgNr": "768043",
      "FaxPhone": "1-743-877-1539 x8672",
      "MobilePhone": "(787)476-0660 x92262",
      "ContactPhone": "(484)169-1877",
      "AssociateName": "Krajcik LLC",
      "AssociateId": 288,
      "UsePersonAddress": true,
      "ContactFax": "in",
      "Kanafname": "minima",
      "Kanalname": "nostrum",
      "Post1": "ipsum",
      "Post2": "neque",
      "Post3": "recusandae",
      "EmailName": "prudence@kris.biz",
      "ContactFullName": "Hoyt Blanda",
      "ActiveErpLinks": 17,
      "TicketPriorityId": 642,
      "SupportLanguageId": 387,
      "SupportAssociateId": 160,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "sed",
  "Xstop": false,
  "ActiveInterests": 623,
  "GroupId": 717,
  "ActiveStatusMonitorId": 827,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 359,
  "DbiAgentId": 341,
  "DbiLastSyncronized": "2019-12-02T02:49:43.8879031+01:00",
  "DbiKey": "architecto",
  "DbiLastModified": "2014-03-31T02:49:43.8879031+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 330,
  "ActiveErpLinks": 506,
  "BounceEmails": [
    "pietro_gleason@simonis.com",
    "asha@russel.us"
  ],
  "Domains": [
    "repudiandae",
    "in"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "236520054",
    "SuperOffice:2": "Giles Simonis"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "consequatur"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 875,
  "Name": "Bogisich-Wiegand",
  "Department": "",
  "OrgNr": "957892",
  "Number1": "351468",
  "Number2": "961357",
  "UpdatedDate": "2014-02-01T02:49:43.9035284+01:00",
  "CreatedDate": "2011-01-23T02:49:43.9035284+01:00",
  "Emails": [
    {
      "Value": "nulla",
      "StrippedValue": "tempore",
      "Description": "Realigned zero administration challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 146
        }
      }
    },
    {
      "Value": "nulla",
      "StrippedValue": "tempore",
      "Description": "Realigned zero administration challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 146
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 671,
      "Name": "Murphy-Wiza",
      "ToolTip": "Debitis est rem exercitationem et.",
      "Deleted": false,
      "Rank": 724,
      "Type": "nihil",
      "ColorBlock": 53,
      "IconHint": "omnis",
      "Selected": true,
      "LastChanged": "2005-03-14T02:49:43.9035284+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "cumque",
      "StyleHint": "commodi",
      "Hidden": false,
      "FullName": "Mr. Layne Carleton Heller II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 347
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "esse",
      "StrippedValue": "et",
      "Description": "Grass-roots bandwidth-monitored archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 759
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "et",
      "Description": "Grass-roots bandwidth-monitored archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 759
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quia",
      "StrippedValue": "sed",
      "Description": "Sharable 3rd generation core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 868
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "sed",
      "Description": "Sharable 3rd generation core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 868
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dicta",
      "StrippedValue": "dolores",
      "Description": "Multi-tiered tertiary installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 971
        }
      }
    },
    {
      "Value": "dicta",
      "StrippedValue": "dolores",
      "Description": "Multi-tiered tertiary installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 971
        }
      }
    }
  ],
  "Description": "Optional 6th generation moratorium",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "doloremque",
      "PersonId": 863,
      "Mrmrs": "eveniet",
      "Firstname": "Karelle",
      "Lastname": "Quitzon",
      "MiddleName": "Leffler Group",
      "Title": "a",
      "Description": "Profit-focused bottom-line flexibility",
      "Email": "cyril_wuckert@schroederhalvorson.name",
      "FullName": "Mr. Malinda Vicente Streich MD",
      "DirectPhone": "1-791-542-7777 x7253",
      "FormalName": "Sporer Group",
      "CountryId": 941,
      "ContactId": 113,
      "ContactName": "Carter, Lang and Bahringer",
      "Retired": 33,
      "Rank": 115,
      "ActiveInterests": 749,
      "ContactDepartment": "",
      "ContactCountryId": 570,
      "ContactOrgNr": "1186755",
      "FaxPhone": "281.810.3217 x700",
      "MobilePhone": "594.396.8152",
      "ContactPhone": "574.117.8162 x0154",
      "AssociateName": "Vandervort-VonRueden",
      "AssociateId": 742,
      "UsePersonAddress": false,
      "ContactFax": "repellendus",
      "Kanafname": "quis",
      "Kanalname": "fugiat",
      "Post1": "fuga",
      "Post2": "est",
      "Post3": "vero",
      "EmailName": "jadon@pfeffer.us",
      "ContactFullName": "Kaylin Hahn",
      "ActiveErpLinks": 413,
      "TicketPriorityId": 578,
      "SupportLanguageId": 641,
      "SupportAssociateId": 578,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 266
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "nisi",
  "Xstop": true,
  "ActiveInterests": 712,
  "GroupId": 704,
  "ActiveStatusMonitorId": 25,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 926,
  "DbiAgentId": 182,
  "DbiLastSyncronized": "2020-06-04T02:49:43.9035284+02:00",
  "DbiKey": "ex",
  "DbiLastModified": "2016-11-29T02:49:43.9035284+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 431,
  "ActiveErpLinks": 834,
  "BounceEmails": [
    "ben_green@murrayhoeger.info",
    "jayde_rempel@fadel.uk"
  ],
  "Domains": [
    "eveniet",
    "molestiae"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Destin Flatley",
    "SuperOffice:2": "Marguerite Weimann"
  },
  "ExtraFields": {
    "ExtraFields1": "sint",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "accusamus",
    "CustomFields2": "mollitia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 684
    }
  }
}
```