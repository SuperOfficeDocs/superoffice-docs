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
  "ContactId": 917,
  "Name": "Wolff LLC",
  "Department": "",
  "OrgNr": "655220",
  "Number1": "651199",
  "Number2": "1317156",
  "UpdatedDate": "2014-10-26T13:14:10.726658+01:00",
  "CreatedDate": "2015-07-28T13:14:10.726658+02:00",
  "Emails": [
    {
      "Value": "maxime",
      "StrippedValue": "laboriosam",
      "Description": "Reduced 24 hour conglomeration"
    },
    {
      "Value": "maxime",
      "StrippedValue": "laboriosam",
      "Description": "Reduced 24 hour conglomeration"
    }
  ],
  "Interests": [
    {
      "Id": 902,
      "Name": "Walsh, Gutmann and Emard",
      "ToolTip": "Itaque aut ipsum quibusdam aut.",
      "Deleted": false,
      "Rank": 344,
      "Type": "maiores",
      "ColorBlock": 927,
      "IconHint": "vero",
      "Selected": false,
      "LastChanged": "2012-09-20T13:14:10.726658+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vel",
      "StyleHint": "consequatur",
      "Hidden": true,
      "FullName": "Corbin Stark"
    }
  ],
  "Urls": [
    {
      "Value": "cumque",
      "StrippedValue": "et",
      "Description": "Reverse-engineered encompassing methodology"
    },
    {
      "Value": "cumque",
      "StrippedValue": "et",
      "Description": "Reverse-engineered encompassing methodology"
    }
  ],
  "Phones": [
    {
      "Value": "aut",
      "StrippedValue": "laboriosam",
      "Description": "Realigned neutral migration"
    },
    {
      "Value": "aut",
      "StrippedValue": "laboriosam",
      "Description": "Realigned neutral migration"
    }
  ],
  "Faxes": [
    {
      "Value": "officiis",
      "StrippedValue": "magni",
      "Description": "Synergized tangible success"
    },
    {
      "Value": "officiis",
      "StrippedValue": "magni",
      "Description": "Synergized tangible success"
    }
  ],
  "Description": "Focused even-keeled adapter",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "distinctio",
      "PersonId": 715,
      "Mrmrs": "adipisci",
      "Firstname": "Margarete",
      "Lastname": "Cummings",
      "MiddleName": "Ziemann LLC",
      "Title": "sit",
      "Description": "Open-source zero tolerance installation",
      "Email": "kobe_romaguera@halvorson.name",
      "FullName": "Piper Boyer",
      "DirectPhone": "006.663.4412",
      "FormalName": "Bergnaum, Jast and Ritchie",
      "CountryId": 81,
      "ContactId": 130,
      "ContactName": "Zboncak, Leannon and Lebsack",
      "Retired": 6,
      "Rank": 686,
      "ActiveInterests": 698,
      "ContactDepartment": "",
      "ContactCountryId": 576,
      "ContactOrgNr": "1650364",
      "FaxPhone": "458.601.4130 x5160",
      "MobilePhone": "(167)730-5444 x603",
      "ContactPhone": "407.253.3313",
      "AssociateName": "Boehm-Herzog",
      "AssociateId": 420,
      "UsePersonAddress": false,
      "ContactFax": "minima",
      "Kanafname": "qui",
      "Kanalname": "temporibus",
      "Post1": "dolores",
      "Post2": "temporibus",
      "Post3": "velit",
      "EmailName": "dasia.ritchie@fadelmcclure.uk",
      "ContactFullName": "Olen Quigley",
      "ActiveErpLinks": 5,
      "TicketPriorityId": 863,
      "SupportLanguageId": 407,
      "SupportAssociateId": 196,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "enim",
  "Xstop": false,
  "ActiveInterests": 426,
  "GroupId": 337,
  "ActiveStatusMonitorId": 615,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 595,
  "DbiAgentId": 710,
  "DbiLastSyncronized": "2018-02-18T13:14:10.726658+01:00",
  "DbiKey": "deleniti",
  "DbiLastModified": "2021-11-21T13:14:10.726658+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 274,
  "ActiveErpLinks": 291,
  "BounceEmails": [
    "cruz@cruickshank.uk",
    "hershel.jakubowski@kulas.biz"
  ],
  "Domains": [
    "officia",
    "est"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "maxime",
    "CustomFields2": "culpa"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 173,
  "Name": "Bins LLC",
  "Department": "",
  "OrgNr": "1078830",
  "Number1": "416365",
  "Number2": "1014091",
  "UpdatedDate": "2001-02-21T13:14:10.726658+01:00",
  "CreatedDate": "2008-10-06T13:14:10.726658+02:00",
  "Emails": [
    {
      "Value": "nemo",
      "StrippedValue": "sit",
      "Description": "Team-oriented motivating migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 588
        }
      }
    },
    {
      "Value": "nemo",
      "StrippedValue": "sit",
      "Description": "Team-oriented motivating migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 588
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 193,
      "Name": "Powlowski-Cartwright",
      "ToolTip": "Officiis rerum accusantium delectus omnis.",
      "Deleted": false,
      "Rank": 898,
      "Type": "rem",
      "ColorBlock": 745,
      "IconHint": "in",
      "Selected": false,
      "LastChanged": "2017-07-25T13:14:10.726658+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quo",
      "StyleHint": "vitae",
      "Hidden": false,
      "FullName": "Hanna Satterfield",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 418
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "saepe",
      "StrippedValue": "aliquam",
      "Description": "Automated eco-centric superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 219
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "aliquam",
      "Description": "Automated eco-centric superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 219
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "molestias",
      "StrippedValue": "accusamus",
      "Description": "Automated well-modulated model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 871
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "accusamus",
      "Description": "Automated well-modulated model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 871
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quasi",
      "StrippedValue": "saepe",
      "Description": "Automated encompassing extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 183
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "saepe",
      "Description": "Automated encompassing extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 183
        }
      }
    }
  ],
  "Description": "Public-key background toolset",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "magni",
      "PersonId": 359,
      "Mrmrs": "adipisci",
      "Firstname": "Vita",
      "Lastname": "Dicki",
      "MiddleName": "Mayer-Boyle",
      "Title": "quia",
      "Description": "Quality-focused multimedia solution",
      "Email": "roberta@farrell.co.uk",
      "FullName": "Prof. Sydnie Florida Moen",
      "DirectPhone": "1-540-299-4718 x32918",
      "FormalName": "O'Conner, Vandervort and Homenick",
      "CountryId": 452,
      "ContactId": 587,
      "ContactName": "Kub, Purdy and Wilkinson",
      "Retired": 262,
      "Rank": 181,
      "ActiveInterests": 460,
      "ContactDepartment": "expedite B2C bandwidth",
      "ContactCountryId": 37,
      "ContactOrgNr": "1868438",
      "FaxPhone": "(190)750-1685",
      "MobilePhone": "(711)290-8312",
      "ContactPhone": "(191)146-7836",
      "AssociateName": "Boyer, Halvorson and Crist",
      "AssociateId": 665,
      "UsePersonAddress": true,
      "ContactFax": "ratione",
      "Kanafname": "ut",
      "Kanalname": "dolor",
      "Post1": "harum",
      "Post2": "est",
      "Post3": "voluptas",
      "EmailName": "fay.ziemann@legrosmedhurst.info",
      "ContactFullName": "Dr. Cornelius Celia Gulgowski",
      "ActiveErpLinks": 15,
      "TicketPriorityId": 979,
      "SupportLanguageId": 589,
      "SupportAssociateId": 398,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 334
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "similique",
  "Xstop": false,
  "ActiveInterests": 5,
  "GroupId": 751,
  "ActiveStatusMonitorId": 4,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 925,
  "DbiAgentId": 511,
  "DbiLastSyncronized": "2015-02-17T13:14:10.742284+01:00",
  "DbiKey": "sed",
  "DbiLastModified": "2008-10-29T13:14:10.742284+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 803,
  "ActiveErpLinks": 254,
  "BounceEmails": [
    "rex.abshire@daniel.us",
    "neva.sporer@kuhlman.com"
  ],
  "Domains": [
    "in",
    "in"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Chauncey Stark",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "nam"
  },
  "CustomFields": {
    "CustomFields1": "magnam",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 433
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```