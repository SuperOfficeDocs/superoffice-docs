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
  "ContactId": 292,
  "Name": "Dickinson Inc and Sons",
  "Department": "",
  "OrgNr": "1237553",
  "Number1": "1242268",
  "Number2": "479967",
  "UpdatedDate": "2022-08-11T03:51:26.803073+02:00",
  "CreatedDate": "2003-09-10T03:51:26.803073+02:00",
  "Emails": [
    {
      "Value": "autem",
      "StrippedValue": "atque",
      "Description": "Universal cohesive focus group"
    },
    {
      "Value": "autem",
      "StrippedValue": "atque",
      "Description": "Universal cohesive focus group"
    }
  ],
  "Interests": [
    {
      "Id": 428,
      "Name": "Brown-Lind",
      "ToolTip": "Nihil incidunt.",
      "Deleted": false,
      "Rank": 696,
      "Type": "aut",
      "ColorBlock": 631,
      "IconHint": "dolore",
      "Selected": false,
      "LastChanged": "2002-03-16T03:51:26.803073+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vel",
      "StyleHint": "enim",
      "Hidden": true,
      "FullName": "Misty Schmeler"
    }
  ],
  "Urls": [
    {
      "Value": "dolor",
      "StrippedValue": "ipsa",
      "Description": "Team-oriented intermediate architecture"
    },
    {
      "Value": "dolor",
      "StrippedValue": "ipsa",
      "Description": "Team-oriented intermediate architecture"
    }
  ],
  "Phones": [
    {
      "Value": "quis",
      "StrippedValue": "illo",
      "Description": "Reverse-engineered 24 hour ability"
    },
    {
      "Value": "quis",
      "StrippedValue": "illo",
      "Description": "Reverse-engineered 24 hour ability"
    }
  ],
  "Faxes": [
    {
      "Value": "tempora",
      "StrippedValue": "accusamus",
      "Description": "Phased methodical alliance"
    },
    {
      "Value": "tempora",
      "StrippedValue": "accusamus",
      "Description": "Phased methodical alliance"
    }
  ],
  "Description": "Balanced intangible database",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "non",
      "PersonId": 117,
      "Mrmrs": "quae",
      "Firstname": "Estell",
      "Lastname": "McGlynn",
      "MiddleName": "Gutmann-Gaylord",
      "Title": "omnis",
      "Description": "Reverse-engineered user-facing flexibility",
      "Email": "randi@hane.ca",
      "FullName": "Watson Anderson",
      "DirectPhone": "123-585-9621",
      "FormalName": "Turner, Hayes and Lang",
      "CountryId": 224,
      "ContactId": 935,
      "ContactName": "Graham, Blick and McCullough",
      "Retired": 396,
      "Rank": 973,
      "ActiveInterests": 782,
      "ContactDepartment": "",
      "ContactCountryId": 39,
      "ContactOrgNr": "1345610",
      "FaxPhone": "(091)094-1577",
      "MobilePhone": "(311)187-9127 x04163",
      "ContactPhone": "1-427-927-1462",
      "AssociateName": "Stoltenberg LLC",
      "AssociateId": 178,
      "UsePersonAddress": false,
      "ContactFax": "at",
      "Kanafname": "odit",
      "Kanalname": "velit",
      "Post1": "iusto",
      "Post2": "optio",
      "Post3": "et",
      "EmailName": "jane_friesen@hegmann.co.uk",
      "ContactFullName": "Mrs. Tristian Cremin MD",
      "ActiveErpLinks": 960,
      "TicketPriorityId": 389,
      "SupportLanguageId": 48,
      "SupportAssociateId": 633,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "quasi",
  "Xstop": false,
  "ActiveInterests": 931,
  "GroupId": 941,
  "ActiveStatusMonitorId": 736,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 425,
  "DbiAgentId": 99,
  "DbiLastSyncronized": "2022-08-02T03:51:26.803073+02:00",
  "DbiKey": "ad",
  "DbiLastModified": "2002-09-14T03:51:26.8186949+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 27,
  "ActiveErpLinks": 298,
  "BounceEmails": [
    "timmy_prohaska@lueilwitzskiles.us",
    "stewart.hermiston@prosaccostehr.biz"
  ],
  "Domains": [
    "aut",
    "sed"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Dr. Eugene Ruthe Pollich"
  },
  "ExtraFields": {
    "ExtraFields1": "ex",
    "ExtraFields2": "pariatur"
  },
  "CustomFields": {
    "CustomFields1": "iure",
    "CustomFields2": "saepe"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 595,
  "Name": "Hettinger Group",
  "Department": "",
  "OrgNr": "403497",
  "Number1": "952186",
  "Number2": "1015493",
  "UpdatedDate": "1998-01-24T03:51:26.8186949+01:00",
  "CreatedDate": "1998-09-26T03:51:26.8186949+02:00",
  "Emails": [
    {
      "Value": "velit",
      "StrippedValue": "ut",
      "Description": "Total web-enabled moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 500
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "ut",
      "Description": "Total web-enabled moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 500
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 190,
      "Name": "Waelchi Inc and Sons",
      "ToolTip": "Ut mollitia accusamus consequuntur ducimus velit sunt.",
      "Deleted": true,
      "Rank": 488,
      "Type": "fugiat",
      "ColorBlock": 971,
      "IconHint": "ad",
      "Selected": false,
      "LastChanged": "2015-04-10T03:51:26.8186949+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aperiam",
      "StyleHint": "ducimus",
      "Hidden": true,
      "FullName": "Mr. Amparo Hirthe",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 111
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eaque",
      "StrippedValue": "ut",
      "Description": "Reactive national adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 626
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "ut",
      "Description": "Reactive national adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 626
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "totam",
      "StrippedValue": "rerum",
      "Description": "Multi-layered fault-tolerant info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 651
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "rerum",
      "Description": "Multi-layered fault-tolerant info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 651
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "distinctio",
      "StrippedValue": "omnis",
      "Description": "Cross-platform full-range framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 955
        }
      }
    },
    {
      "Value": "distinctio",
      "StrippedValue": "omnis",
      "Description": "Cross-platform full-range framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 955
        }
      }
    }
  ],
  "Description": "Virtual bandwidth-monitored challenge",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "cum",
      "PersonId": 333,
      "Mrmrs": "deserunt",
      "Firstname": "Mya",
      "Lastname": "Robel",
      "MiddleName": "Kuhn-Langworth",
      "Title": "rerum",
      "Description": "Secured scalable portal",
      "Email": "winston_abbott@altenwerth.co.uk",
      "FullName": "Tristin Kathryne Wisozk II",
      "DirectPhone": "1-103-733-4472 x6815",
      "FormalName": "Hauck, Zboncak and Block",
      "CountryId": 344,
      "ContactId": 857,
      "ContactName": "Jast-Hoppe",
      "Retired": 304,
      "Rank": 407,
      "ActiveInterests": 476,
      "ContactDepartment": "",
      "ContactCountryId": 283,
      "ContactOrgNr": "1139820",
      "FaxPhone": "1-428-866-9771 x13747",
      "MobilePhone": "606-328-9131",
      "ContactPhone": "029.630.6701",
      "AssociateName": "Yost Inc and Sons",
      "AssociateId": 658,
      "UsePersonAddress": false,
      "ContactFax": "odio",
      "Kanafname": "laborum",
      "Kanalname": "omnis",
      "Post1": "inventore",
      "Post2": "officiis",
      "Post3": "saepe",
      "EmailName": "vivien@collinsprohaska.uk",
      "ContactFullName": "Prof. Mustafa Priscilla Cronin",
      "ActiveErpLinks": 262,
      "TicketPriorityId": 46,
      "SupportLanguageId": 26,
      "SupportAssociateId": 499,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 61
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "dicta",
  "Xstop": false,
  "ActiveInterests": 814,
  "GroupId": 649,
  "ActiveStatusMonitorId": 134,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 945,
  "DbiAgentId": 93,
  "DbiLastSyncronized": "2015-06-19T03:51:26.8186949+02:00",
  "DbiKey": "odio",
  "DbiLastModified": "1996-04-28T03:51:26.8186949+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 951,
  "ActiveErpLinks": 793,
  "BounceEmails": [
    "karli@webermedhurst.uk",
    "jeffry@schroedergutkowski.biz"
  ],
  "Domains": [
    "atque",
    "animi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ben Schowalter",
    "SuperOffice:2": "1960214828"
  },
  "ExtraFields": {
    "ExtraFields1": "aspernatur",
    "ExtraFields2": "sint"
  },
  "CustomFields": {
    "CustomFields1": "fugiat",
    "CustomFields2": "iure"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 204
    }
  }
}
```