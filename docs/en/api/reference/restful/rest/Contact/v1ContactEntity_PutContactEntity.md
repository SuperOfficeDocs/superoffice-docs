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
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 768,
  "Name": "Crooks LLC",
  "Department": "",
  "OrgNr": "918614",
  "Number1": "1402741",
  "Number2": "866644",
  "UpdatedDate": "2018-11-10T17:54:08.101208+01:00",
  "CreatedDate": "2016-10-28T17:54:08.101208+02:00",
  "Emails": [
    {
      "Value": "libero",
      "StrippedValue": "sed",
      "Description": "Open-architected context-sensitive service-desk"
    },
    {
      "Value": "libero",
      "StrippedValue": "sed",
      "Description": "Open-architected context-sensitive service-desk"
    }
  ],
  "Interests": [
    {
      "Id": 521,
      "Name": "Nolan, Turcotte and Leannon",
      "ToolTip": "Vel quod tempora quis quas eius laboriosam.",
      "Deleted": false,
      "Rank": 639,
      "Type": "fugiat",
      "ColorBlock": 591,
      "IconHint": "neque",
      "Selected": false,
      "LastChanged": "2014-05-09T17:54:08.101208+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "fugit",
      "StyleHint": "explicabo",
      "Hidden": false,
      "FullName": "Lyric Jamey Bartell IV"
    }
  ],
  "Urls": [
    {
      "Value": "sapiente",
      "StrippedValue": "consequatur",
      "Description": "Synchronised 6th generation initiative"
    },
    {
      "Value": "sapiente",
      "StrippedValue": "consequatur",
      "Description": "Synchronised 6th generation initiative"
    }
  ],
  "Phones": [
    {
      "Value": "voluptatum",
      "StrippedValue": "quia",
      "Description": "Team-oriented object-oriented structure"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "quia",
      "Description": "Team-oriented object-oriented structure"
    }
  ],
  "Faxes": [
    {
      "Value": "sit",
      "StrippedValue": "molestiae",
      "Description": "Intuitive mobile forecast"
    },
    {
      "Value": "sit",
      "StrippedValue": "molestiae",
      "Description": "Intuitive mobile forecast"
    }
  ],
  "Description": "Open-architected contextually-based artificial intelligence",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aperiam",
      "PersonId": 796,
      "Mrmrs": "dolor",
      "Firstname": "Keyshawn",
      "Lastname": "Harvey",
      "MiddleName": "Beier, Leuschke and Gleason",
      "Title": "veniam",
      "Description": "Secured optimal frame",
      "Email": "jillian@carroll.co.uk",
      "FullName": "Jeremie Monahan",
      "DirectPhone": "1-978-917-8462",
      "FormalName": "Lakin, Miller and Schmidt",
      "CountryId": 812,
      "ContactId": 220,
      "ContactName": "Mosciski-Hoeger",
      "Retired": 191,
      "Rank": 56,
      "ActiveInterests": 88,
      "ContactDepartment": "",
      "ContactCountryId": 362,
      "ContactOrgNr": "1158374",
      "FaxPhone": "783.333.5196 x74762",
      "MobilePhone": "1-742-199-8728 x56964",
      "ContactPhone": "318.342.2152 x271",
      "AssociateName": "Maggio, Hudson and Waelchi",
      "AssociateId": 829,
      "UsePersonAddress": false,
      "ContactFax": "cum",
      "Kanafname": "qui",
      "Kanalname": "et",
      "Post1": "dolorum",
      "Post2": "autem",
      "Post3": "in",
      "EmailName": "doris@kuvalis.us",
      "ContactFullName": "Torrey Willms",
      "ActiveErpLinks": 491,
      "TicketPriorityId": 532,
      "SupportLanguageId": 160,
      "SupportAssociateId": 902,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1403539"
    }
  ],
  "NoMailing": false,
  "Kananame": "asperiores",
  "Xstop": false,
  "ActiveInterests": 418,
  "GroupId": 903,
  "ActiveStatusMonitorId": 807,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 422,
  "DbiAgentId": 475,
  "DbiLastSyncronized": "2023-07-17T17:54:08.101208+02:00",
  "DbiKey": "quis",
  "DbiLastModified": "2004-03-23T17:54:08.101208+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 684,
  "ActiveErpLinks": 415,
  "BounceEmails": [
    "jennings_huel@kulas.com",
    "luigi@zieme.name"
  ],
  "Domains": [
    "consequuntur",
    "occaecati"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Genevieve Jewess",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "ad"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "optio"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 674,
  "Name": "Sipes Inc and Sons",
  "Department": "",
  "OrgNr": "890645",
  "Number1": "1128712",
  "Number2": "1088126",
  "UpdatedDate": "2016-09-04T17:54:08.101208+02:00",
  "CreatedDate": "2001-04-09T17:54:08.101208+02:00",
  "Emails": [
    {
      "Value": "velit",
      "StrippedValue": "voluptatem",
      "Description": "Open-architected mission-critical emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 887
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "voluptatem",
      "Description": "Open-architected mission-critical emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 887
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 405,
      "Name": "Frami, Orn and Lubowitz",
      "ToolTip": "Recusandae atque.",
      "Deleted": true,
      "Rank": 421,
      "Type": "nobis",
      "ColorBlock": 720,
      "IconHint": "enim",
      "Selected": false,
      "LastChanged": "2005-06-17T17:54:08.101208+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ipsum",
      "StyleHint": "laborum",
      "Hidden": true,
      "FullName": "Deshaun Will",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 29
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "incidunt",
      "StrippedValue": "occaecati",
      "Description": "Enhanced interactive matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 816
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "occaecati",
      "Description": "Enhanced interactive matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 816
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "totam",
      "StrippedValue": "nesciunt",
      "Description": "Innovative 4th generation framework",
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
      "Value": "totam",
      "StrippedValue": "nesciunt",
      "Description": "Innovative 4th generation framework",
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
  "Faxes": [
    {
      "Value": "iure",
      "StrippedValue": "laborum",
      "Description": "Open-architected bi-directional synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 506
        }
      }
    },
    {
      "Value": "iure",
      "StrippedValue": "laborum",
      "Description": "Open-architected bi-directional synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 506
        }
      }
    }
  ],
  "Description": "Persevering context-sensitive forecast",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quis",
      "PersonId": 614,
      "Mrmrs": "quibusdam",
      "Firstname": "Gaylord",
      "Lastname": "Wilkinson",
      "MiddleName": "Dietrich-Kunze",
      "Title": "rerum",
      "Description": "Implemented 24/7 architecture",
      "Email": "fausto.okuneva@flatleymertz.uk",
      "FullName": "Elaina Crist",
      "DirectPhone": "425-443-0030 x31573",
      "FormalName": "Ward-Stamm",
      "CountryId": 650,
      "ContactId": 492,
      "ContactName": "Gerhold-Corkery",
      "Retired": 237,
      "Rank": 341,
      "ActiveInterests": 55,
      "ContactDepartment": "",
      "ContactCountryId": 799,
      "ContactOrgNr": "985842",
      "FaxPhone": "1-025-180-9235 x15903",
      "MobilePhone": "757.983.0000 x636",
      "ContactPhone": "129.389.4898 x89777",
      "AssociateName": "Rodriguez-Schoen",
      "AssociateId": 671,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "ut",
      "Kanalname": "enim",
      "Post1": "voluptatem",
      "Post2": "omnis",
      "Post3": "reprehenderit",
      "EmailName": "ralph_casper@krajcik.ca",
      "ContactFullName": "Miss Pauline Eleazar Gibson",
      "ActiveErpLinks": 521,
      "TicketPriorityId": 800,
      "SupportLanguageId": 687,
      "SupportAssociateId": 721,
      "CategoryName": "VIP Customer",
      "PersonNumber": "857374",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 767
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "ipsum",
  "Xstop": false,
  "ActiveInterests": 486,
  "GroupId": 775,
  "ActiveStatusMonitorId": 237,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 129,
  "DbiAgentId": 236,
  "DbiLastSyncronized": "2005-12-05T17:54:08.101208+01:00",
  "DbiKey": "et",
  "DbiLastModified": "2017-12-11T17:54:08.101208+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 462,
  "ActiveErpLinks": 948,
  "BounceEmails": [
    "dolores_cremin@emard.info",
    "eric@connelly.com"
  ],
  "Domains": [
    "molestiae",
    "ipsum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Delbert Moore",
    "SuperOffice:2": "275367755"
  },
  "ExtraFields": {
    "ExtraFields1": "nemo",
    "ExtraFields2": "dolorem"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 881
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```