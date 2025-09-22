---
title: PUT Contact/{id}
uid: v1ContactEntity_PutContactEntity
generated: true
content_type: reference
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
  "ContactId": 66,
  "Name": "O'Hara Inc and Sons",
  "Department": "",
  "OrgNr": "577651",
  "Number1": "525982",
  "Number2": "1661497",
  "UpdatedDate": "2018-05-30T11:24:53.1093279+02:00",
  "CreatedDate": "2019-04-12T11:24:53.1093279+02:00",
  "Emails": [
    {
      "Value": "a",
      "StrippedValue": "tempore",
      "Description": "Enterprise-wide static access"
    },
    {
      "Value": "a",
      "StrippedValue": "tempore",
      "Description": "Enterprise-wide static access"
    }
  ],
  "Interests": [
    {
      "Id": 777,
      "Name": "Altenwerth, Vandervort and Kiehn",
      "ToolTip": "Consectetur quos praesentium quo.",
      "Deleted": true,
      "Rank": 125,
      "Type": "voluptas",
      "ColorBlock": 534,
      "IconHint": "ratione",
      "Selected": false,
      "LastChanged": "2023-09-10T11:24:53.1093279+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "velit",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Myra Klein"
    }
  ],
  "Urls": [
    {
      "Value": "nesciunt",
      "StrippedValue": "dicta",
      "Description": "Vision-oriented fault-tolerant attitude"
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "dicta",
      "Description": "Vision-oriented fault-tolerant attitude"
    }
  ],
  "Phones": [
    {
      "Value": "iure",
      "StrippedValue": "ut",
      "Description": "Fully-configurable modular intranet"
    },
    {
      "Value": "iure",
      "StrippedValue": "ut",
      "Description": "Fully-configurable modular intranet"
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "consequatur",
      "Description": "Organized 4th generation infrastructure"
    },
    {
      "Value": "qui",
      "StrippedValue": "consequatur",
      "Description": "Organized 4th generation infrastructure"
    }
  ],
  "Description": "Front-line intangible array",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "enim",
      "PersonId": 314,
      "Mrmrs": "voluptates",
      "Firstname": "Raymond",
      "Lastname": "Toy",
      "MiddleName": "Schultz-Monahan",
      "Title": "et",
      "Description": "Virtual even-keeled methodology",
      "Email": "cecilia@turner.name",
      "FullName": "Sheridan Zackary Jones I",
      "DirectPhone": "1-701-519-5896 x8697",
      "FormalName": "Emard, Mante and Skiles",
      "CountryId": 630,
      "ContactId": 928,
      "ContactName": "Morissette Group",
      "Retired": 889,
      "Rank": 117,
      "ActiveInterests": 59,
      "ContactDepartment": "",
      "ContactCountryId": 703,
      "ContactOrgNr": "1013134",
      "FaxPhone": "671.580.5560",
      "MobilePhone": "274-852-1167",
      "ContactPhone": "670-391-6294 x64410",
      "AssociateName": "Berge-Kuvalis",
      "AssociateId": 925,
      "UsePersonAddress": false,
      "ContactFax": "qui",
      "Kanafname": "et",
      "Kanalname": "perspiciatis",
      "Post1": "architecto",
      "Post2": "assumenda",
      "Post3": "consequatur",
      "EmailName": "alec@satterfield.co.uk",
      "ContactFullName": "Patrick Rohan",
      "ActiveErpLinks": 775,
      "TicketPriorityId": 685,
      "SupportLanguageId": 201,
      "SupportAssociateId": 437,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1133959"
    }
  ],
  "NoMailing": false,
  "Kananame": "dignissimos",
  "Xstop": false,
  "ActiveInterests": 800,
  "GroupId": 17,
  "ActiveStatusMonitorId": 183,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 408,
  "DbiAgentId": 767,
  "DbiLastSyncronized": "2012-12-03T11:24:53.1093279+01:00",
  "DbiKey": "accusantium",
  "DbiLastModified": "2024-11-28T11:24:53.1093279+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 542,
  "ActiveErpLinks": 372,
  "BounceEmails": [
    "antonina_barton@veum.uk",
    "torrey@terry.us"
  ],
  "Domains": [
    "fugiat",
    "ratione"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Roosevelt Kautzer"
  },
  "ExtraFields": {
    "ExtraFields1": "fugit",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "quidem",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 893,
  "Name": "Goldner Group",
  "Department": "",
  "OrgNr": "980150",
  "Number1": "729609",
  "Number2": "1183007",
  "UpdatedDate": "2018-11-22T11:24:53.1093279+01:00",
  "CreatedDate": "2018-09-08T11:24:53.1093279+02:00",
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "ex",
      "Description": "Implemented object-oriented migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 629
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "ex",
      "Description": "Implemented object-oriented migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 629
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 3,
      "Name": "Wiegand-Stanton",
      "ToolTip": "Ipsum nisi similique sint.",
      "Deleted": false,
      "Rank": 917,
      "Type": "dignissimos",
      "ColorBlock": 662,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2019-06-13T11:24:53.1093279+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "exercitationem",
      "StyleHint": "temporibus",
      "Hidden": true,
      "FullName": "Dr. Jaclyn Richmond Doyle MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 813
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "culpa",
      "StrippedValue": "nulla",
      "Description": "Reverse-engineered homogeneous neural-net",
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
      "Value": "culpa",
      "StrippedValue": "nulla",
      "Description": "Reverse-engineered homogeneous neural-net",
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
      "Value": "molestiae",
      "StrippedValue": "ipsum",
      "Description": "Enterprise-wide intangible focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 116
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "ipsum",
      "Description": "Enterprise-wide intangible focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 116
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sunt",
      "StrippedValue": "excepturi",
      "Description": "Organic global monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 895
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "excepturi",
      "Description": "Organic global monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 895
        }
      }
    }
  ],
  "Description": "Front-line empowering collaboration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ea",
      "PersonId": 888,
      "Mrmrs": "sed",
      "Firstname": "Hobart",
      "Lastname": "Schmitt",
      "MiddleName": "Runolfsdottir Group",
      "Title": "voluptatem",
      "Description": "Fully-configurable local knowledge user",
      "Email": "lucio_pfeffer@brekkereichert.info",
      "FullName": "Annabell Brekke",
      "DirectPhone": "297.761.6014 x80293",
      "FormalName": "Koepp-Raynor",
      "CountryId": 185,
      "ContactId": 900,
      "ContactName": "Raynor-Hauck",
      "Retired": 418,
      "Rank": 814,
      "ActiveInterests": 946,
      "ContactDepartment": "",
      "ContactCountryId": 780,
      "ContactOrgNr": "1065895",
      "FaxPhone": "925-432-7908 x1705",
      "MobilePhone": "206.097.8690",
      "ContactPhone": "(970)049-6073 x6616",
      "AssociateName": "Hoppe Group",
      "AssociateId": 675,
      "UsePersonAddress": false,
      "ContactFax": "dolores",
      "Kanafname": "odio",
      "Kanalname": "adipisci",
      "Post1": "autem",
      "Post2": "porro",
      "Post3": "maiores",
      "EmailName": "christopher@schmidt.info",
      "ContactFullName": "Haylee Kreiger",
      "ActiveErpLinks": 740,
      "TicketPriorityId": 628,
      "SupportLanguageId": 325,
      "SupportAssociateId": 252,
      "CategoryName": "VIP Customer",
      "PersonNumber": "950329",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 323
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "praesentium",
  "Xstop": true,
  "ActiveInterests": 60,
  "GroupId": 474,
  "ActiveStatusMonitorId": 508,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 54,
  "DbiAgentId": 691,
  "DbiLastSyncronized": "2020-02-16T11:24:53.1093279+01:00",
  "DbiKey": "tempora",
  "DbiLastModified": "2020-06-22T11:24:53.1093279+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 618,
  "ActiveErpLinks": 762,
  "BounceEmails": [
    "bill_renner@waters.co.uk",
    "elroy.hudson@christiansen.com"
  ],
  "Domains": [
    "sed",
    "fugit"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Candida Noelia Spencer IV"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "facilis"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "nam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 529
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```