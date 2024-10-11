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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 416,
  "Name": "Mayer-Koelpin",
  "Department": "visualize rich infomediaries",
  "OrgNr": "536523",
  "Number1": "1739502",
  "Number2": "1327667",
  "UpdatedDate": "2015-01-07T03:44:57.1558996+01:00",
  "CreatedDate": "2023-08-18T03:44:57.1558996+02:00",
  "Emails": [
    {
      "Value": "eum",
      "StrippedValue": "explicabo",
      "Description": "Self-enabling assymetric complexity"
    },
    {
      "Value": "eum",
      "StrippedValue": "explicabo",
      "Description": "Self-enabling assymetric complexity"
    }
  ],
  "Interests": [
    {
      "Id": 813,
      "Name": "Schaden, Lowe and Steuber",
      "ToolTip": "Est quo quos dolorem dignissimos.",
      "Deleted": true,
      "Rank": 655,
      "Type": "cumque",
      "ColorBlock": 871,
      "IconHint": "deserunt",
      "Selected": false,
      "LastChanged": "2020-07-12T03:44:57.1558996+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "itaque",
      "StyleHint": "sed",
      "Hidden": false,
      "FullName": "Deja Bauch"
    }
  ],
  "Urls": [
    {
      "Value": "ex",
      "StrippedValue": "ut",
      "Description": "Programmable bifurcated challenge"
    },
    {
      "Value": "ex",
      "StrippedValue": "ut",
      "Description": "Programmable bifurcated challenge"
    }
  ],
  "Phones": [
    {
      "Value": "eius",
      "StrippedValue": "officiis",
      "Description": "Focused methodical product"
    },
    {
      "Value": "eius",
      "StrippedValue": "officiis",
      "Description": "Focused methodical product"
    }
  ],
  "Faxes": [
    {
      "Value": "id",
      "StrippedValue": "nesciunt",
      "Description": "Virtual content-based toolset"
    },
    {
      "Value": "id",
      "StrippedValue": "nesciunt",
      "Description": "Virtual content-based toolset"
    }
  ],
  "Description": "Function-based 5th generation array",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ab",
      "PersonId": 489,
      "Mrmrs": "voluptatum",
      "Firstname": "Hollie",
      "Lastname": "Schneider",
      "MiddleName": "Nitzsche, O'Connell and Durgan",
      "Title": "quis",
      "Description": "Synergistic analyzing access",
      "Email": "friedrich@yost.biz",
      "FullName": "Nicholaus Jolie Carter II",
      "DirectPhone": "(579)917-2110",
      "FormalName": "Dare-Moen",
      "CountryId": 206,
      "ContactId": 161,
      "ContactName": "Oberbrunner Group",
      "Retired": 768,
      "Rank": 355,
      "ActiveInterests": 882,
      "ContactDepartment": "",
      "ContactCountryId": 724,
      "ContactOrgNr": "1188259",
      "FaxPhone": "(949)541-1360 x229",
      "MobilePhone": "637-116-5368 x914",
      "ContactPhone": "1-637-765-3889 x229",
      "AssociateName": "Yundt-Bode",
      "AssociateId": 788,
      "UsePersonAddress": false,
      "ContactFax": "expedita",
      "Kanafname": "libero",
      "Kanalname": "quis",
      "Post1": "sint",
      "Post2": "omnis",
      "Post3": "maxime",
      "EmailName": "jaqueline@langosh.name",
      "ContactFullName": "Prof. Kadin Tomas Hilll Jr.",
      "ActiveErpLinks": 523,
      "TicketPriorityId": 498,
      "SupportLanguageId": 811,
      "SupportAssociateId": 805,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "ab",
  "Xstop": true,
  "ActiveInterests": 85,
  "GroupId": 131,
  "ActiveStatusMonitorId": 697,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 651,
  "DbiAgentId": 505,
  "DbiLastSyncronized": "2016-08-03T03:44:57.1558996+02:00",
  "DbiKey": "corrupti",
  "DbiLastModified": "1998-10-18T03:44:57.1558996+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 659,
  "ActiveErpLinks": 812,
  "BounceEmails": [
    "verdie@lemkecarroll.info",
    "richie.kihn@feest.us"
  ],
  "Domains": [
    "assumenda",
    "rerum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Hector Wyman V",
    "SuperOffice:2": "1029126604"
  },
  "ExtraFields": {
    "ExtraFields1": "assumenda",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "non"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 806,
  "Name": "Howe-Tillman",
  "Department": "",
  "OrgNr": "589215",
  "Number1": "1751565",
  "Number2": "1319873",
  "UpdatedDate": "1998-07-08T03:44:57.1558996+02:00",
  "CreatedDate": "2008-08-16T03:44:57.1558996+02:00",
  "Emails": [
    {
      "Value": "aliquid",
      "StrippedValue": "molestiae",
      "Description": "Digitized dedicated monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 962
        }
      }
    },
    {
      "Value": "aliquid",
      "StrippedValue": "molestiae",
      "Description": "Digitized dedicated monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 962
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 662,
      "Name": "Carter-Goodwin",
      "ToolTip": "Minus iure harum hic maxime possimus odit.",
      "Deleted": false,
      "Rank": 968,
      "Type": "in",
      "ColorBlock": 742,
      "IconHint": "magni",
      "Selected": false,
      "LastChanged": "2016-07-08T03:44:57.1558996+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolore",
      "StyleHint": "corrupti",
      "Hidden": false,
      "FullName": "Prof. Kaleigh Monahan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 608
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quibusdam",
      "StrippedValue": "ratione",
      "Description": "Business-focused bi-directional product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "ratione",
      "Description": "Business-focused bi-directional product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "consequatur",
      "StrippedValue": "aliquid",
      "Description": "Managed discrete workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 827
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "aliquid",
      "Description": "Managed discrete workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 827
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatum",
      "StrippedValue": "eum",
      "Description": "Innovative discrete moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 672
        }
      }
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "eum",
      "Description": "Innovative discrete moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 672
        }
      }
    }
  ],
  "Description": "Reverse-engineered intangible implementation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eum",
      "PersonId": 554,
      "Mrmrs": "qui",
      "Firstname": "Keven",
      "Lastname": "Ruecker",
      "MiddleName": "Hayes LLC",
      "Title": "asperiores",
      "Description": "Horizontal leading edge support",
      "Email": "albert.kunde@wuckert.uk",
      "FullName": "Bianka Lynch",
      "DirectPhone": "180-514-2507",
      "FormalName": "VonRueden, Gerhold and Hane",
      "CountryId": 193,
      "ContactId": 548,
      "ContactName": "Mraz, Kulas and Barton",
      "Retired": 214,
      "Rank": 4,
      "ActiveInterests": 161,
      "ContactDepartment": "",
      "ContactCountryId": 507,
      "ContactOrgNr": "154547",
      "FaxPhone": "627-631-0700",
      "MobilePhone": "1-883-235-5966 x93049",
      "ContactPhone": "(644)964-8205 x284",
      "AssociateName": "Pacocha Group",
      "AssociateId": 85,
      "UsePersonAddress": false,
      "ContactFax": "iste",
      "Kanafname": "eveniet",
      "Kanalname": "est",
      "Post1": "reiciendis",
      "Post2": "similique",
      "Post3": "sint",
      "EmailName": "alicia.predovic@stamm.co.uk",
      "ContactFullName": "Ophelia Tromp",
      "ActiveErpLinks": 893,
      "TicketPriorityId": 284,
      "SupportLanguageId": 522,
      "SupportAssociateId": 936,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 911
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptatibus",
  "Xstop": true,
  "ActiveInterests": 159,
  "GroupId": 829,
  "ActiveStatusMonitorId": 482,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 445,
  "DbiAgentId": 63,
  "DbiLastSyncronized": "2019-05-05T03:44:57.1558996+02:00",
  "DbiKey": "optio",
  "DbiLastModified": "2021-10-25T03:44:57.1558996+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 751,
  "ActiveErpLinks": 304,
  "BounceEmails": [
    "julien@okeefebayer.com",
    "louisa.king@collier.uk"
  ],
  "Domains": [
    "quae",
    "quis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1774376129",
    "SuperOffice:2": "60570387"
  },
  "ExtraFields": {
    "ExtraFields1": "blanditiis",
    "ExtraFields2": "facere"
  },
  "CustomFields": {
    "CustomFields1": "a",
    "CustomFields2": "voluptatibus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 814
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```