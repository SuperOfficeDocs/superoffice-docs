---
title: PUT Contact/{id}
uid: v1ContactEntity_PutContactEntity
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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 588,
  "Name": "Price-Spencer",
  "Department": "",
  "OrgNr": "1310390",
  "Number1": "1686783",
  "Number2": "1182584",
  "UpdatedDate": "2010-09-20T15:29:29.528205+02:00",
  "CreatedDate": "1998-12-31T15:29:29.528205+01:00",
  "Emails": [
    {
      "Value": "sint",
      "StrippedValue": "nisi",
      "Description": "Pre-emptive real-time circuit"
    },
    {
      "Value": "sint",
      "StrippedValue": "nisi",
      "Description": "Pre-emptive real-time circuit"
    }
  ],
  "Interests": [
    {
      "Id": 964,
      "Name": "Lowe-Beatty",
      "ToolTip": "Velit aut et eligendi magnam quas suscipit.",
      "Deleted": false,
      "Rank": 875,
      "Type": "omnis",
      "ColorBlock": 793,
      "IconHint": "eum",
      "Selected": false,
      "LastChanged": "2020-03-13T15:29:29.528205+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "ullam",
      "Hidden": false,
      "FullName": "Darrell Kuvalis"
    }
  ],
  "Urls": [
    {
      "Value": "hic",
      "StrippedValue": "qui",
      "Description": "Fundamental modular archive"
    },
    {
      "Value": "hic",
      "StrippedValue": "qui",
      "Description": "Fundamental modular archive"
    }
  ],
  "Phones": [
    {
      "Value": "est",
      "StrippedValue": "expedita",
      "Description": "Managed uniform strategy"
    },
    {
      "Value": "est",
      "StrippedValue": "expedita",
      "Description": "Managed uniform strategy"
    }
  ],
  "Faxes": [
    {
      "Value": "ea",
      "StrippedValue": "amet",
      "Description": "Synergistic human-resource productivity"
    },
    {
      "Value": "ea",
      "StrippedValue": "amet",
      "Description": "Synergistic human-resource productivity"
    }
  ],
  "Description": "Customer-focused fresh-thinking core",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "vitae",
      "PersonId": 455,
      "Mrmrs": "aut",
      "Firstname": "Georgette",
      "Lastname": "Daugherty",
      "MiddleName": "Streich, Von and Koepp",
      "Title": "repellendus",
      "Description": "Fully-configurable fresh-thinking benchmark",
      "Email": "dallin_ferry@damoreyost.name",
      "FullName": "Dylan Stroman PhD",
      "DirectPhone": "906.903.9227 x11702",
      "FormalName": "Koepp LLC",
      "CountryId": 734,
      "ContactId": 632,
      "ContactName": "Treutel, Reichel and Mosciski",
      "Retired": 254,
      "Rank": 832,
      "ActiveInterests": 652,
      "ContactDepartment": "",
      "ContactCountryId": 599,
      "ContactOrgNr": "776617",
      "FaxPhone": "1-052-139-1091",
      "MobilePhone": "745.776.9857 x5519",
      "ContactPhone": "695-214-4415",
      "AssociateName": "White Group",
      "AssociateId": 853,
      "UsePersonAddress": true,
      "ContactFax": "ullam",
      "Kanafname": "similique",
      "Kanalname": "voluptatibus",
      "Post1": "dolores",
      "Post2": "et",
      "Post3": "fugiat",
      "EmailName": "adelia_rodriguez@johnston.info",
      "ContactFullName": "Aryanna Hamill",
      "ActiveErpLinks": 151,
      "TicketPriorityId": 884,
      "SupportLanguageId": 522,
      "SupportAssociateId": 611,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "sed",
  "Xstop": true,
  "ActiveInterests": 668,
  "GroupId": 786,
  "ActiveStatusMonitorId": 467,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 445,
  "DbiAgentId": 385,
  "DbiLastSyncronized": "2006-01-13T15:29:29.533702+01:00",
  "DbiKey": "vel",
  "DbiLastModified": "2017-11-14T15:29:29.533702+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 653,
  "ActiveErpLinks": 43,
  "BounceEmails": [
    "dannie@gulgowski.ca",
    "nicolette_okon@jenkinsgottlieb.ca"
  ],
  "Domains": [
    "corrupti",
    "quae"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Braden Wisoky",
    "SuperOffice:2": "257103805"
  },
  "ExtraFields": {
    "ExtraFields1": "quidem",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "est"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 816,
  "Name": "Schimmel-Marquardt",
  "Department": "",
  "OrgNr": "714406",
  "Number1": "129014",
  "Number2": "711131",
  "UpdatedDate": "2003-09-07T15:29:29.5442045+02:00",
  "CreatedDate": "2009-12-04T15:29:29.5442045+01:00",
  "Emails": [
    {
      "Value": "ipsam",
      "StrippedValue": "ut",
      "Description": "Optional empowering ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 182
        }
      }
    },
    {
      "Value": "ipsam",
      "StrippedValue": "ut",
      "Description": "Optional empowering ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 182
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 58,
      "Name": "Turcotte-Bins",
      "ToolTip": "Ratione ipsam qui ut quo voluptatibus.",
      "Deleted": false,
      "Rank": 448,
      "Type": "id",
      "ColorBlock": 317,
      "IconHint": "amet",
      "Selected": false,
      "LastChanged": "1996-02-06T15:29:29.5442045+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "necessitatibus",
      "StyleHint": "voluptate",
      "Hidden": false,
      "FullName": "Alexis Hoppe IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 93
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "accusantium",
      "StrippedValue": "non",
      "Description": "Customer-focused client-server success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 711
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "non",
      "Description": "Customer-focused client-server success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 711
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sequi",
      "StrippedValue": "illo",
      "Description": "Implemented clear-thinking budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 495
        }
      }
    },
    {
      "Value": "sequi",
      "StrippedValue": "illo",
      "Description": "Implemented clear-thinking budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 495
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eveniet",
      "StrippedValue": "excepturi",
      "Description": "Persistent leading edge support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 754
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "excepturi",
      "Description": "Persistent leading edge support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 754
        }
      }
    }
  ],
  "Description": "Assimilated full-range time-frame",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "rerum",
      "PersonId": 827,
      "Mrmrs": "error",
      "Firstname": "Lincoln",
      "Lastname": "VonRueden",
      "MiddleName": "Weber-Turner",
      "Title": "facere",
      "Description": "Re-engineered well-modulated help-desk",
      "Email": "eloise@king.info",
      "FullName": "Deangelo Lockman PhD",
      "DirectPhone": "458-014-2115 x02612",
      "FormalName": "Ritchie-Bashirian",
      "CountryId": 297,
      "ContactId": 110,
      "ContactName": "Fritsch-Wunsch",
      "Retired": 979,
      "Rank": 39,
      "ActiveInterests": 768,
      "ContactDepartment": "",
      "ContactCountryId": 129,
      "ContactOrgNr": "815568",
      "FaxPhone": "202.595.2296",
      "MobilePhone": "707-379-9638",
      "ContactPhone": "552.769.8109",
      "AssociateName": "Sipes, Kertzmann and Funk",
      "AssociateId": 803,
      "UsePersonAddress": false,
      "ContactFax": "exercitationem",
      "Kanafname": "consectetur",
      "Kanalname": "vel",
      "Post1": "eum",
      "Post2": "eum",
      "Post3": "occaecati",
      "EmailName": "judy@hane.com",
      "ContactFullName": "Elva Mitchell",
      "ActiveErpLinks": 300,
      "TicketPriorityId": 277,
      "SupportLanguageId": 290,
      "SupportAssociateId": 738,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 547
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "sed",
  "Xstop": false,
  "ActiveInterests": 569,
  "GroupId": 69,
  "ActiveStatusMonitorId": 905,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 81,
  "DbiAgentId": 790,
  "DbiLastSyncronized": "2011-09-29T15:29:29.5487024+02:00",
  "DbiKey": "veritatis",
  "DbiLastModified": "1999-04-15T15:29:29.5487024+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 964,
  "ActiveErpLinks": 907,
  "BounceEmails": [
    "brandi.sanford@hayeswatsica.com",
    "ana@lebsackreilly.us"
  ],
  "Domains": [
    "vitae",
    "ab"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Andreanne Keebler",
    "SuperOffice:2": "Dr. Aron Hyatt I"
  },
  "ExtraFields": {
    "ExtraFields1": "autem",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 523
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```