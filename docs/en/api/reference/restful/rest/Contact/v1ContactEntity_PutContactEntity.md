---
title: PUT Contact/{id}
uid: v1ContactEntity_PutContactEntity
generated: true
---

# PUT Contact/{id}

```http
PUT /api/v1/Contact/{id}
```

Updates the existing ContactEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Contact/{id}?$select=name,department,category/id
```


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

ContactEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity updated. |
| 412 | Update stopped because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: ContactEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 341,
  "Name": "Reinger-Jacobson",
  "Department": "",
  "OrgNr": "834362",
  "Number1": "977411",
  "Number2": "974992",
  "UpdatedDate": "2021-01-23T16:00:47.7584709+01:00",
  "CreatedDate": "2013-11-22T16:00:47.7584709+01:00",
  "Emails": [
    {
      "Value": "saepe",
      "StrippedValue": "et",
      "Description": "Triple-buffered fault-tolerant encryption"
    },
    {
      "Value": "saepe",
      "StrippedValue": "et",
      "Description": "Triple-buffered fault-tolerant encryption"
    }
  ],
  "Interests": [
    {
      "Id": 633,
      "Name": "Thiel, Stokes and Gottlieb",
      "ToolTip": "Hic a odit rem culpa consequatur in eos.",
      "Deleted": false,
      "Rank": 264,
      "Type": "blanditiis",
      "ColorBlock": 311,
      "IconHint": "debitis",
      "Selected": false,
      "LastChanged": "2003-10-07T16:00:47.7584709+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sequi",
      "StyleHint": "ducimus",
      "Hidden": false,
      "FullName": "Maryam Adams"
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "autem",
      "Description": "Universal system-worthy monitoring"
    },
    {
      "Value": "est",
      "StrippedValue": "autem",
      "Description": "Universal system-worthy monitoring"
    }
  ],
  "Phones": [
    {
      "Value": "aut",
      "StrippedValue": "incidunt",
      "Description": "Versatile radical moderator"
    },
    {
      "Value": "aut",
      "StrippedValue": "incidunt",
      "Description": "Versatile radical moderator"
    }
  ],
  "Faxes": [
    {
      "Value": "voluptas",
      "StrippedValue": "qui",
      "Description": "Stand-alone cohesive middleware"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "qui",
      "Description": "Stand-alone cohesive middleware"
    }
  ],
  "Description": "Progressive tertiary website",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sapiente",
      "PersonId": 528,
      "Mrmrs": "sapiente",
      "Firstname": "Carolyn",
      "Lastname": "Medhurst",
      "MiddleName": "Grimes LLC",
      "Title": "veniam",
      "Description": "Visionary reciprocal neural-net",
      "Email": "hailey@langosh.uk",
      "FullName": "Miss Vaughn Stracke",
      "DirectPhone": "982-513-3931 x51126",
      "FormalName": "Strosin Group",
      "CountryId": 483,
      "ContactId": 646,
      "ContactName": "Rogahn-Gibson",
      "Retired": 887,
      "Rank": 459,
      "ActiveInterests": 841,
      "ContactDepartment": "",
      "ContactCountryId": 347,
      "ContactOrgNr": "949756",
      "FaxPhone": "686.166.6543",
      "MobilePhone": "(629)388-9407 x408",
      "ContactPhone": "(991)539-6999",
      "AssociateName": "Wunsch, Flatley and Gutmann",
      "AssociateId": 441,
      "UsePersonAddress": false,
      "ContactFax": "sint",
      "Kanafname": "voluptatibus",
      "Kanalname": "repudiandae",
      "Post1": "quia",
      "Post2": "molestias",
      "Post3": "delectus",
      "EmailName": "isaiah.champlin@stehr.uk",
      "ContactFullName": "Jaime Batz",
      "ActiveErpLinks": 200,
      "TicketPriorityId": 548,
      "SupportLanguageId": 531,
      "SupportAssociateId": 185,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "quod",
  "Xstop": true,
  "ActiveInterests": 79,
  "GroupId": 666,
  "ActiveStatusMonitorId": 452,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 482,
  "DbiAgentId": 213,
  "DbiLastSyncronized": "2012-10-09T16:00:47.7584709+02:00",
  "DbiKey": "et",
  "DbiLastModified": "2006-12-28T16:00:47.7584709+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 607,
  "ActiveErpLinks": 622,
  "BounceEmails": [
    "ruthie@johnsonabshire.info",
    "anjali_labadie@stiedemanngleason.name"
  ],
  "Domains": [
    "nihil",
    "dolor"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "placeat"
  },
  "CustomFields": {
    "CustomFields1": "inventore",
    "CustomFields2": "qui"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 514,
  "Name": "Kovacek LLC",
  "Department": "",
  "OrgNr": "1062281",
  "Number1": "1105202",
  "Number2": "1088192",
  "UpdatedDate": "2004-02-06T16:00:47.7741025+01:00",
  "CreatedDate": "2002-04-23T16:00:47.7741025+02:00",
  "Emails": [
    {
      "Value": "dolores",
      "StrippedValue": "repellat",
      "Description": "Profit-focused bifurcated workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 801
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "repellat",
      "Description": "Profit-focused bifurcated workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 801
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 717,
      "Name": "McGlynn-Kris",
      "ToolTip": "Quasi consequatur est dolores qui.",
      "Deleted": false,
      "Rank": 742,
      "Type": "vitae",
      "ColorBlock": 55,
      "IconHint": "aspernatur",
      "Selected": false,
      "LastChanged": "2006-08-15T16:00:47.7741025+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "officiis",
      "StyleHint": "corporis",
      "Hidden": true,
      "FullName": "Daisha Padberg",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 814
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "harum",
      "Description": "Robust needs-based conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 602
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "harum",
      "Description": "Robust needs-based conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 602
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "recusandae",
      "StrippedValue": "officia",
      "Description": "Reactive asynchronous emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 517
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "officia",
      "Description": "Reactive asynchronous emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 517
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "delectus",
      "StrippedValue": "rerum",
      "Description": "Reverse-engineered object-oriented extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 331
        }
      }
    },
    {
      "Value": "delectus",
      "StrippedValue": "rerum",
      "Description": "Reverse-engineered object-oriented extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 331
        }
      }
    }
  ],
  "Description": "Decentralized scalable adapter",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sed",
      "PersonId": 708,
      "Mrmrs": "ex",
      "Firstname": "Arielle",
      "Lastname": "Lebsack",
      "MiddleName": "Stoltenberg-Gleason",
      "Title": "totam",
      "Description": "Cloned demand-driven concept",
      "Email": "howard.zemlak@hoppehowell.info",
      "FullName": "Elliot Estelle Mueller II",
      "DirectPhone": "984.585.9326",
      "FormalName": "Skiles Group",
      "CountryId": 241,
      "ContactId": 780,
      "ContactName": "Hartmann-Rogahn",
      "Retired": 819,
      "Rank": 954,
      "ActiveInterests": 923,
      "ContactDepartment": "",
      "ContactCountryId": 273,
      "ContactOrgNr": "442538",
      "FaxPhone": "593-076-8506 x98296",
      "MobilePhone": "700-897-3636",
      "ContactPhone": "1-409-893-2767 x83797",
      "AssociateName": "Satterfield Inc and Sons",
      "AssociateId": 235,
      "UsePersonAddress": true,
      "ContactFax": "et",
      "Kanafname": "excepturi",
      "Kanalname": "harum",
      "Post1": "eius",
      "Post2": "ut",
      "Post3": "accusamus",
      "EmailName": "jaylan@rodrigueznitzsche.biz",
      "ContactFullName": "Prof. Diana Christina Zemlak",
      "ActiveErpLinks": 505,
      "TicketPriorityId": 763,
      "SupportLanguageId": 694,
      "SupportAssociateId": 292,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 674
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "nesciunt",
  "Xstop": true,
  "ActiveInterests": 551,
  "GroupId": 298,
  "ActiveStatusMonitorId": 318,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 480,
  "DbiAgentId": 251,
  "DbiLastSyncronized": "2009-10-10T16:00:47.7741025+02:00",
  "DbiKey": "nihil",
  "DbiLastModified": "2005-09-09T16:00:47.7741025+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 911,
  "ActiveErpLinks": 225,
  "BounceEmails": [
    "crystal@orn.uk",
    "lucie.schmeler@rau.info"
  ],
  "Domains": [
    "qui",
    "adipisci"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Austin Kerluke Sr.",
    "SuperOffice:2": "299258789"
  },
  "ExtraFields": {
    "ExtraFields1": "nihil",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "corporis",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 784
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```