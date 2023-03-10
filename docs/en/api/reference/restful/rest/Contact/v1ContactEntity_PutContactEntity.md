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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 302,
  "Name": "Douglas Inc and Sons",
  "Department": "",
  "OrgNr": "656190",
  "Number1": "1139135",
  "Number2": "1096986",
  "UpdatedDate": "2001-12-18T12:15:26.6186402+01:00",
  "CreatedDate": "2005-03-14T12:15:26.6186402+01:00",
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "voluptatem",
      "Description": "Polarised multimedia circuit"
    },
    {
      "Value": "quia",
      "StrippedValue": "voluptatem",
      "Description": "Polarised multimedia circuit"
    }
  ],
  "Interests": [
    {
      "Id": 85,
      "Name": "Gislason-Russel",
      "ToolTip": "Et necessitatibus quibusdam facere.",
      "Deleted": true,
      "Rank": 312,
      "Type": "corrupti",
      "ColorBlock": 632,
      "IconHint": "omnis",
      "Selected": false,
      "LastChanged": "2015-06-28T12:15:26.6186402+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eos",
      "StyleHint": "rerum",
      "Hidden": true,
      "FullName": "Nicolas Jonas Hermann IV"
    }
  ],
  "Urls": [
    {
      "Value": "non",
      "StrippedValue": "mollitia",
      "Description": "Networked national leverage"
    },
    {
      "Value": "non",
      "StrippedValue": "mollitia",
      "Description": "Networked national leverage"
    }
  ],
  "Phones": [
    {
      "Value": "adipisci",
      "StrippedValue": "aut",
      "Description": "Vision-oriented uniform function"
    },
    {
      "Value": "adipisci",
      "StrippedValue": "aut",
      "Description": "Vision-oriented uniform function"
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "quia",
      "Description": "Compatible secondary customer loyalty"
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "quia",
      "Description": "Compatible secondary customer loyalty"
    }
  ],
  "Description": "Cloned coherent synergy",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "placeat",
      "PersonId": 338,
      "Mrmrs": "earum",
      "Firstname": "Modesta",
      "Lastname": "Bosco",
      "MiddleName": "Schimmel, Gleason and Feest",
      "Title": "architecto",
      "Description": "Re-contextualized encompassing help-desk",
      "Email": "junius.collins@lynch.com",
      "FullName": "Frederik Sipes",
      "DirectPhone": "1-610-445-8136 x0471",
      "FormalName": "Von, Price and Wintheiser",
      "CountryId": 535,
      "ContactId": 439,
      "ContactName": "Schmitt Inc and Sons",
      "Retired": 461,
      "Rank": 790,
      "ActiveInterests": 779,
      "ContactDepartment": "",
      "ContactCountryId": 151,
      "ContactOrgNr": "1380111",
      "FaxPhone": "(819)327-5796 x2149",
      "MobilePhone": "720-443-4549",
      "ContactPhone": "172.330.3788 x991",
      "AssociateName": "Johnson, Mante and O'Kon",
      "AssociateId": 553,
      "UsePersonAddress": true,
      "ContactFax": "minima",
      "Kanafname": "non",
      "Kanalname": "nostrum",
      "Post1": "sunt",
      "Post2": "et",
      "Post3": "itaque",
      "EmailName": "estevan@rutherfordberge.ca",
      "ContactFullName": "Mr. Ole Ethyl Wisoky PhD",
      "ActiveErpLinks": 294,
      "TicketPriorityId": 242,
      "SupportLanguageId": 678,
      "SupportAssociateId": 604,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "nam",
  "Xstop": false,
  "ActiveInterests": 707,
  "GroupId": 460,
  "ActiveStatusMonitorId": 668,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 889,
  "DbiAgentId": 547,
  "DbiLastSyncronized": "2008-01-15T12:15:26.6266476+01:00",
  "DbiKey": "consequatur",
  "DbiLastModified": "2022-09-14T12:15:26.6266476+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 139,
  "ActiveErpLinks": 862,
  "BounceEmails": [
    "clarissa@lockman.biz",
    "kyra.greenholt@kovacek.us"
  ],
  "Domains": [
    "vitae",
    "fugit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Terrance Dibbert",
    "SuperOffice:2": "Emie Doyle"
  },
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "exercitationem"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 249,
  "Name": "Ryan, Murphy and Kuvalis",
  "Department": "",
  "OrgNr": "462700",
  "Number1": "1052616",
  "Number2": "906495",
  "UpdatedDate": "2014-04-26T12:15:26.66464+02:00",
  "CreatedDate": "2011-11-19T12:15:26.66464+01:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "quae",
      "Description": "Right-sized stable projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 143
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quae",
      "Description": "Right-sized stable projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 143
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 278,
      "Name": "Sauer, Larson and Cronin",
      "ToolTip": "Odit ad aliquid dignissimos et ea.",
      "Deleted": true,
      "Rank": 335,
      "Type": "rerum",
      "ColorBlock": 319,
      "IconHint": "culpa",
      "Selected": false,
      "LastChanged": "2017-08-23T12:15:26.6686417+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "commodi",
      "Hidden": true,
      "FullName": "Otho Harold Nicolas PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 505
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "accusamus",
      "Description": "Automated 3rd generation workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 518
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "accusamus",
      "Description": "Automated 3rd generation workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 518
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "officiis",
      "Description": "Synergistic client-server budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 229
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "officiis",
      "Description": "Synergistic client-server budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 229
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "totam",
      "StrippedValue": "qui",
      "Description": "Multi-lateral neutral structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 992
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "qui",
      "Description": "Multi-lateral neutral structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 992
        }
      }
    }
  ],
  "Description": "Enterprise-wide global frame",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "autem",
      "PersonId": 886,
      "Mrmrs": "quaerat",
      "Firstname": "Joana",
      "Lastname": "Kutch",
      "MiddleName": "Graham LLC",
      "Title": "dolores",
      "Description": "Seamless upward-trending system engine",
      "Email": "luna.mertz@walker.co.uk",
      "FullName": "Mr. Delmer Zboncak I",
      "DirectPhone": "1-343-327-7632",
      "FormalName": "Grimes LLC",
      "CountryId": 418,
      "ContactId": 340,
      "ContactName": "Simonis, Mante and Mayert",
      "Retired": 337,
      "Rank": 337,
      "ActiveInterests": 789,
      "ContactDepartment": "",
      "ContactCountryId": 40,
      "ContactOrgNr": "1834070",
      "FaxPhone": "1-118-629-9801",
      "MobilePhone": "915-899-7915 x718",
      "ContactPhone": "339-152-4342",
      "AssociateName": "Schaden, Waters and Green",
      "AssociateId": 433,
      "UsePersonAddress": false,
      "ContactFax": "ut",
      "Kanafname": "quia",
      "Kanalname": "qui",
      "Post1": "impedit",
      "Post2": "pariatur",
      "Post3": "ex",
      "EmailName": "bryana@ortiz.com",
      "ContactFullName": "Lloyd Seth Johns V",
      "ActiveErpLinks": 649,
      "TicketPriorityId": 789,
      "SupportLanguageId": 621,
      "SupportAssociateId": 137,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 202
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "voluptatum",
  "Xstop": false,
  "ActiveInterests": 55,
  "GroupId": 236,
  "ActiveStatusMonitorId": 186,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 523,
  "DbiAgentId": 65,
  "DbiLastSyncronized": "2000-07-15T12:15:26.6826398+02:00",
  "DbiKey": "ea",
  "DbiLastModified": "2020-10-25T12:15:26.6826398+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 878,
  "ActiveErpLinks": 662,
  "BounceEmails": [
    "audie.mitchell@blick.us",
    "cloyd_beer@schmidt.name"
  ],
  "Domains": [
    "beatae",
    "delectus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Rylee Streich",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "neque",
    "ExtraFields2": "aspernatur"
  },
  "CustomFields": {
    "CustomFields1": "illum",
    "CustomFields2": "vitae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 994
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```