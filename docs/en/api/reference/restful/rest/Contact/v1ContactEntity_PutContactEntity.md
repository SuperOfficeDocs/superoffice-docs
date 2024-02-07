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
  "ContactId": 372,
  "Name": "O'Connell, Kuhic and Pfannerstill",
  "Department": "",
  "OrgNr": "936014",
  "Number1": "1030266",
  "Number2": "453405",
  "UpdatedDate": "2018-01-13T16:55:29.4463383+01:00",
  "CreatedDate": "2002-02-10T16:55:29.4463383+01:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "aut",
      "Description": "Triple-buffered eco-centric parallelism"
    },
    {
      "Value": "et",
      "StrippedValue": "aut",
      "Description": "Triple-buffered eco-centric parallelism"
    }
  ],
  "Interests": [
    {
      "Id": 690,
      "Name": "Hills-Sauer",
      "ToolTip": "Omnis praesentium.",
      "Deleted": false,
      "Rank": 426,
      "Type": "tempora",
      "ColorBlock": 605,
      "IconHint": "enim",
      "Selected": false,
      "LastChanged": "2022-05-22T16:55:29.4463383+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laudantium",
      "StyleHint": "cupiditate",
      "Hidden": false,
      "FullName": "Mrs. Armani Candice Bashirian"
    }
  ],
  "Urls": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "alias",
      "Description": "Down-sized composite info-mediaries"
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "alias",
      "Description": "Down-sized composite info-mediaries"
    }
  ],
  "Phones": [
    {
      "Value": "sed",
      "StrippedValue": "assumenda",
      "Description": "Fully-configurable intangible concept"
    },
    {
      "Value": "sed",
      "StrippedValue": "assumenda",
      "Description": "Fully-configurable intangible concept"
    }
  ],
  "Faxes": [
    {
      "Value": "quo",
      "StrippedValue": "tempore",
      "Description": "Multi-lateral explicit orchestration"
    },
    {
      "Value": "quo",
      "StrippedValue": "tempore",
      "Description": "Multi-lateral explicit orchestration"
    }
  ],
  "Description": "Synchronised exuding artificial intelligence",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "cum",
      "PersonId": 329,
      "Mrmrs": "laborum",
      "Firstname": "Geovanni",
      "Lastname": "Hintz",
      "MiddleName": "Moen-Hirthe",
      "Title": "eos",
      "Description": "Vision-oriented contextually-based orchestration",
      "Email": "jeromy.willms@vonswift.biz",
      "FullName": "Enrico Corkery",
      "DirectPhone": "1-769-570-6337 x97781",
      "FormalName": "Schuppe LLC",
      "CountryId": 700,
      "ContactId": 450,
      "ContactName": "Grimes, Crona and Osinski",
      "Retired": 85,
      "Rank": 495,
      "ActiveInterests": 140,
      "ContactDepartment": "",
      "ContactCountryId": 840,
      "ContactOrgNr": "1745932",
      "FaxPhone": "262-117-3264",
      "MobilePhone": "059-055-5715 x32868",
      "ContactPhone": "363-684-4387",
      "AssociateName": "O'Reilly, Schuppe and Lang",
      "AssociateId": 312,
      "UsePersonAddress": true,
      "ContactFax": "repudiandae",
      "Kanafname": "delectus",
      "Kanalname": "minima",
      "Post1": "eveniet",
      "Post2": "dignissimos",
      "Post3": "est",
      "EmailName": "nicole@schneiderdooley.biz",
      "ContactFullName": "Rebeca Herzog",
      "ActiveErpLinks": 291,
      "TicketPriorityId": 944,
      "SupportLanguageId": 289,
      "SupportAssociateId": 579,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "veritatis",
  "Xstop": true,
  "ActiveInterests": 559,
  "GroupId": 734,
  "ActiveStatusMonitorId": 382,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 173,
  "DbiAgentId": 902,
  "DbiLastSyncronized": "2002-09-18T16:55:29.4503162+02:00",
  "DbiKey": "sed",
  "DbiLastModified": "2017-12-20T16:55:29.4503162+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 321,
  "ActiveErpLinks": 627,
  "BounceEmails": [
    "waylon_shields@dach.info",
    "emily.hand@bahringerkling.uk"
  ],
  "Domains": [
    "non",
    "qui"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Darren Treutel",
    "SuperOffice:2": "201007685"
  },
  "ExtraFields": {
    "ExtraFields1": "veniam",
    "ExtraFields2": "modi"
  },
  "CustomFields": {
    "CustomFields1": "recusandae",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 495,
  "Name": "Lesch, Kuphal and Farrell",
  "Department": "",
  "OrgNr": "693259",
  "Number1": "1217070",
  "Number2": "411269",
  "UpdatedDate": "2015-11-30T16:55:29.4613381+01:00",
  "CreatedDate": "2005-11-14T16:55:29.4613381+01:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Horizontal modular standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 333
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Horizontal modular standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 333
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 700,
      "Name": "Konopelski-Greenholt",
      "ToolTip": "Expedita consequatur nemo ducimus.",
      "Deleted": false,
      "Rank": 529,
      "Type": "eligendi",
      "ColorBlock": 372,
      "IconHint": "cupiditate",
      "Selected": false,
      "LastChanged": "2006-09-23T16:55:29.4613381+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "reiciendis",
      "StyleHint": "sequi",
      "Hidden": false,
      "FullName": "Lavada Kilback",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 315
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "rerum",
      "Description": "Cross-platform analyzing architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 901
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "rerum",
      "Description": "Cross-platform analyzing architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 901
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "omnis",
      "StrippedValue": "quis",
      "Description": "Switchable 5th generation migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 981
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "quis",
      "Description": "Switchable 5th generation migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 981
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "voluptates",
      "Description": "Digitized methodical project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 832
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "voluptates",
      "Description": "Digitized methodical project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 832
        }
      }
    }
  ],
  "Description": "Cross-group dynamic workforce",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "hic",
      "PersonId": 995,
      "Mrmrs": "voluptas",
      "Firstname": "Jamil",
      "Lastname": "Hand",
      "MiddleName": "Daugherty-West",
      "Title": "rem",
      "Description": "Multi-tiered tangible approach",
      "Email": "myrtis@smitham.com",
      "FullName": "Mr. Sam Daphnee Lindgren",
      "DirectPhone": "154-787-3913 x58161",
      "FormalName": "Gorczany, Dietrich and Bechtelar",
      "CountryId": 672,
      "ContactId": 213,
      "ContactName": "Parker-Graham",
      "Retired": 475,
      "Rank": 415,
      "ActiveInterests": 476,
      "ContactDepartment": "engineer front-end eyeballs",
      "ContactCountryId": 964,
      "ContactOrgNr": "876590",
      "FaxPhone": "552-685-7339 x728",
      "MobilePhone": "881.657.7702 x3067",
      "ContactPhone": "1-975-419-1874",
      "AssociateName": "Frami LLC",
      "AssociateId": 791,
      "UsePersonAddress": false,
      "ContactFax": "corporis",
      "Kanafname": "aut",
      "Kanalname": "id",
      "Post1": "sint",
      "Post2": "officiis",
      "Post3": "id",
      "EmailName": "noble@bartellkirlin.info",
      "ContactFullName": "Amira Durgan",
      "ActiveErpLinks": 373,
      "TicketPriorityId": 36,
      "SupportLanguageId": 917,
      "SupportAssociateId": 696,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 488
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "consequatur",
  "Xstop": true,
  "ActiveInterests": 947,
  "GroupId": 257,
  "ActiveStatusMonitorId": 903,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 456,
  "DbiAgentId": 286,
  "DbiLastSyncronized": "2012-12-05T16:55:29.4653391+01:00",
  "DbiKey": "cumque",
  "DbiLastModified": "2013-07-19T16:55:29.4653391+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 938,
  "ActiveErpLinks": 972,
  "BounceEmails": [
    "freda@koss.com",
    "quentin.oreilly@brekke.co.uk"
  ],
  "Domains": [
    "consectetur",
    "id"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1877628805",
    "SuperOffice:2": "Newell Kovacek"
  },
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "vel"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "sed"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 940
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```