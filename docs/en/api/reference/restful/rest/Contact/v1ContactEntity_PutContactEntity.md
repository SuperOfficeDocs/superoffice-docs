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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 855,
  "Name": "Mayert Inc and Sons",
  "Department": "",
  "OrgNr": "638017",
  "Number1": "812163",
  "Number2": "1750591",
  "UpdatedDate": "1998-01-29T10:30:31.8855621+01:00",
  "CreatedDate": "2010-10-01T10:30:31.8855621+02:00",
  "Emails": [
    {
      "Value": "ipsa",
      "StrippedValue": "nisi",
      "Description": "Optimized object-oriented portal"
    },
    {
      "Value": "ipsa",
      "StrippedValue": "nisi",
      "Description": "Optimized object-oriented portal"
    }
  ],
  "Interests": [
    {
      "Id": 194,
      "Name": "Leffler, Cummings and Halvorson",
      "ToolTip": "Odio et.",
      "Deleted": false,
      "Rank": 527,
      "Type": "ad",
      "ColorBlock": 644,
      "IconHint": "voluptatem",
      "Selected": true,
      "LastChanged": "1997-06-03T10:30:31.8855621+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "cumque",
      "StyleHint": "labore",
      "Hidden": false,
      "FullName": "Johnpaul Koepp"
    }
  ],
  "Urls": [
    {
      "Value": "nihil",
      "StrippedValue": "culpa",
      "Description": "Horizontal heuristic definition"
    },
    {
      "Value": "nihil",
      "StrippedValue": "culpa",
      "Description": "Horizontal heuristic definition"
    }
  ],
  "Phones": [
    {
      "Value": "vero",
      "StrippedValue": "dolorum",
      "Description": "Upgradable attitude-oriented artificial intelligence"
    },
    {
      "Value": "vero",
      "StrippedValue": "dolorum",
      "Description": "Upgradable attitude-oriented artificial intelligence"
    }
  ],
  "Faxes": [
    {
      "Value": "eligendi",
      "StrippedValue": "molestiae",
      "Description": "Seamless secondary structure"
    },
    {
      "Value": "eligendi",
      "StrippedValue": "molestiae",
      "Description": "Seamless secondary structure"
    }
  ],
  "Description": "Organic composite internet solution",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ad",
      "PersonId": 254,
      "Mrmrs": "et",
      "Firstname": "Jaunita",
      "Lastname": "Dietrich",
      "MiddleName": "Kohler, McClure and Kuhic",
      "Title": "omnis",
      "Description": "Innovative grid-enabled software",
      "Email": "misty@johns.us",
      "FullName": "Prof. Lamont Glen Beier DDS",
      "DirectPhone": "1-411-215-4543 x7507",
      "FormalName": "Will Inc and Sons",
      "CountryId": 875,
      "ContactId": 330,
      "ContactName": "Paucek, Conroy and Jacobs",
      "Retired": 614,
      "Rank": 767,
      "ActiveInterests": 281,
      "ContactDepartment": "",
      "ContactCountryId": 791,
      "ContactOrgNr": "1296471",
      "FaxPhone": "1-819-416-1305",
      "MobilePhone": "741.185.7568 x3549",
      "ContactPhone": "706.101.9955",
      "AssociateName": "Marks, Lockman and Kuvalis",
      "AssociateId": 430,
      "UsePersonAddress": false,
      "ContactFax": "hic",
      "Kanafname": "voluptates",
      "Kanalname": "animi",
      "Post1": "ut",
      "Post2": "tempore",
      "Post3": "nulla",
      "EmailName": "mose@cruickshank.info",
      "ContactFullName": "Odell Lockman",
      "ActiveErpLinks": 116,
      "TicketPriorityId": 790,
      "SupportLanguageId": 145,
      "SupportAssociateId": 269,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "perspiciatis",
  "Xstop": false,
  "ActiveInterests": 737,
  "GroupId": 971,
  "ActiveStatusMonitorId": 467,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 512,
  "DbiAgentId": 374,
  "DbiLastSyncronized": "2013-04-28T10:30:31.9011816+02:00",
  "DbiKey": "et",
  "DbiLastModified": "2021-05-23T10:30:31.9011816+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 226,
  "ActiveErpLinks": 356,
  "BounceEmails": [
    "pinkie@schiller.com",
    "cathryn.rodriguez@eichmann.info"
  ],
  "Domains": [
    "sed",
    "ab"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Lenny Ceasar Stark PhD",
    "SuperOffice:2": "Mrs. Herta Sophia Huels"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "ipsum"
  },
  "CustomFields": {
    "CustomFields1": "perferendis",
    "CustomFields2": "magni"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 71,
  "Name": "Fahey Group",
  "Department": "",
  "OrgNr": "1377951",
  "Number1": "660819",
  "Number2": "1712960",
  "UpdatedDate": "1999-01-21T10:30:31.9011816+01:00",
  "CreatedDate": "2012-02-15T10:30:31.9011816+01:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "aperiam",
      "Description": "Function-based regional flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 285
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "aperiam",
      "Description": "Function-based regional flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 285
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 972,
      "Name": "Wisozk-Bosco",
      "ToolTip": "Eveniet repellendus omnis.",
      "Deleted": true,
      "Rank": 659,
      "Type": "inventore",
      "ColorBlock": 532,
      "IconHint": "reprehenderit",
      "Selected": true,
      "LastChanged": "2018-01-01T10:30:31.9011816+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aperiam",
      "StyleHint": "odio",
      "Hidden": false,
      "FullName": "Janae Botsford",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 233
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "error",
      "StrippedValue": "ipsam",
      "Description": "Profit-focused solution-oriented secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 96
        }
      }
    },
    {
      "Value": "error",
      "StrippedValue": "ipsam",
      "Description": "Profit-focused solution-oriented secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 96
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "fugit",
      "StrippedValue": "omnis",
      "Description": "Team-oriented tertiary adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "omnis",
      "Description": "Team-oriented tertiary adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "officiis",
      "Description": "De-engineered next generation Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 735
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "officiis",
      "Description": "De-engineered next generation Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 735
        }
      }
    }
  ],
  "Description": "Customizable didactic matrices",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "repellat",
      "PersonId": 681,
      "Mrmrs": "blanditiis",
      "Firstname": "Alfredo",
      "Lastname": "Boyer",
      "MiddleName": "Hegmann, Kling and King",
      "Title": "sit",
      "Description": "Persevering transitional adapter",
      "Email": "giovanny@feil.ca",
      "FullName": "Gwen Aaliyah Wintheiser IV",
      "DirectPhone": "312.722.7778 x9197",
      "FormalName": "King-Howell",
      "CountryId": 62,
      "ContactId": 748,
      "ContactName": "Watsica, Ernser and Bode",
      "Retired": 637,
      "Rank": 374,
      "ActiveInterests": 878,
      "ContactDepartment": "",
      "ContactCountryId": 358,
      "ContactOrgNr": "1802987",
      "FaxPhone": "883.240.1978 x8098",
      "MobilePhone": "1-769-426-5564",
      "ContactPhone": "1-111-027-1898 x7833",
      "AssociateName": "Friesen-Cassin",
      "AssociateId": 724,
      "UsePersonAddress": false,
      "ContactFax": "ipsam",
      "Kanafname": "voluptatem",
      "Kanalname": "commodi",
      "Post1": "quae",
      "Post2": "pariatur",
      "Post3": "laudantium",
      "EmailName": "jonathan.koepp@dickinson.name",
      "ContactFullName": "Kian Cremin",
      "ActiveErpLinks": 958,
      "TicketPriorityId": 340,
      "SupportLanguageId": 873,
      "SupportAssociateId": 822,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 964
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "laborum",
  "Xstop": false,
  "ActiveInterests": 796,
  "GroupId": 585,
  "ActiveStatusMonitorId": 321,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 74,
  "DbiAgentId": 328,
  "DbiLastSyncronized": "2000-02-21T10:30:31.9011816+01:00",
  "DbiKey": "voluptates",
  "DbiLastModified": "2004-07-14T10:30:31.9011816+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 397,
  "ActiveErpLinks": 581,
  "BounceEmails": [
    "quinton@rolfson.biz",
    "clotilde@grant.co.uk"
  ],
  "Domains": [
    "deserunt",
    "aspernatur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Heloise Nikolaus",
    "SuperOffice:2": "Mrs. Austin Leda Haag V"
  },
  "ExtraFields": {
    "ExtraFields1": "dolor",
    "ExtraFields2": "molestias"
  },
  "CustomFields": {
    "CustomFields1": "placeat",
    "CustomFields2": "dolor"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 330
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```