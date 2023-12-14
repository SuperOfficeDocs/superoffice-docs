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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 92,
  "Name": "Hodkiewicz Group",
  "Department": "",
  "OrgNr": "987831",
  "Number1": "909599",
  "Number2": "272648",
  "UpdatedDate": "2021-12-30T13:57:18.6221857+01:00",
  "CreatedDate": "2010-04-09T13:57:18.6221857+02:00",
  "Emails": [
    {
      "Value": "laboriosam",
      "StrippedValue": "veritatis",
      "Description": "Compatible contextually-based archive"
    },
    {
      "Value": "laboriosam",
      "StrippedValue": "veritatis",
      "Description": "Compatible contextually-based archive"
    }
  ],
  "Interests": [
    {
      "Id": 885,
      "Name": "Dooley, Rohan and Becker",
      "ToolTip": "Minus facere id non totam ullam laboriosam.",
      "Deleted": false,
      "Rank": 156,
      "Type": "eveniet",
      "ColorBlock": 26,
      "IconHint": "consequatur",
      "Selected": false,
      "LastChanged": "2016-03-05T13:57:18.6221857+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "eos",
      "Hidden": false,
      "FullName": "Giovanni Leannon"
    }
  ],
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "iure",
      "Description": "Stand-alone discrete structure"
    },
    {
      "Value": "aut",
      "StrippedValue": "iure",
      "Description": "Stand-alone discrete structure"
    }
  ],
  "Phones": [
    {
      "Value": "velit",
      "StrippedValue": "aut",
      "Description": "Cross-group 3rd generation intranet"
    },
    {
      "Value": "velit",
      "StrippedValue": "aut",
      "Description": "Cross-group 3rd generation intranet"
    }
  ],
  "Faxes": [
    {
      "Value": "commodi",
      "StrippedValue": "ut",
      "Description": "Fundamental optimal installation"
    },
    {
      "Value": "commodi",
      "StrippedValue": "ut",
      "Description": "Fundamental optimal installation"
    }
  ],
  "Description": "Multi-layered national complexity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eum",
      "PersonId": 981,
      "Mrmrs": "aliquam",
      "Firstname": "Kip",
      "Lastname": "Romaguera",
      "MiddleName": "Feil-Stroman",
      "Title": "aliquid",
      "Description": "Visionary bi-directional circuit",
      "Email": "pascale.ullrich@huelsmann.com",
      "FullName": "Mr. Nona Pagac I",
      "DirectPhone": "1-282-882-2803 x872",
      "FormalName": "Gutmann, Kessler and Ferry",
      "CountryId": 167,
      "ContactId": 609,
      "ContactName": "Brekke Inc and Sons",
      "Retired": 419,
      "Rank": 489,
      "ActiveInterests": 754,
      "ContactDepartment": "",
      "ContactCountryId": 432,
      "ContactOrgNr": "964081",
      "FaxPhone": "475.930.9177 x84153",
      "MobilePhone": "426-857-6059",
      "ContactPhone": "1-465-026-0918 x90322",
      "AssociateName": "Gleason, Flatley and Mosciski",
      "AssociateId": 186,
      "UsePersonAddress": true,
      "ContactFax": "voluptatem",
      "Kanafname": "quidem",
      "Kanalname": "dolor",
      "Post1": "nihil",
      "Post2": "molestias",
      "Post3": "voluptatibus",
      "EmailName": "wallace.wiegand@balistrerifeeney.com",
      "ContactFullName": "Lavern Emard",
      "ActiveErpLinks": 870,
      "TicketPriorityId": 398,
      "SupportLanguageId": 615,
      "SupportAssociateId": 419,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "voluptatum",
  "Xstop": false,
  "ActiveInterests": 404,
  "GroupId": 681,
  "ActiveStatusMonitorId": 548,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 461,
  "DbiAgentId": 832,
  "DbiLastSyncronized": "2012-09-28T13:57:18.6221857+02:00",
  "DbiKey": "explicabo",
  "DbiLastModified": "2019-11-13T13:57:18.6221857+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 926,
  "ActiveErpLinks": 560,
  "BounceEmails": [
    "ofelia_nader@schmittboehm.biz",
    "devan@baumbachweimann.info"
  ],
  "Domains": [
    "et",
    "in"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Janice Lucile Klein",
    "SuperOffice:2": "Mrs. Mavis Rice"
  },
  "ExtraFields": {
    "ExtraFields1": "totam",
    "ExtraFields2": "accusantium"
  },
  "CustomFields": {
    "CustomFields1": "molestias",
    "CustomFields2": "aut"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 747,
  "Name": "Gleichner, Johns and Runte",
  "Department": "",
  "OrgNr": "1624495",
  "Number1": "938686",
  "Number2": "10472",
  "UpdatedDate": "2017-08-13T13:57:18.6221857+02:00",
  "CreatedDate": "2002-03-14T13:57:18.6221857+01:00",
  "Emails": [
    {
      "Value": "a",
      "StrippedValue": "minima",
      "Description": "Upgradable stable adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 196
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "minima",
      "Description": "Upgradable stable adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 196
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 221,
      "Name": "Beier, Smith and Tillman",
      "ToolTip": "Eveniet animi ut reprehenderit esse ut eos.",
      "Deleted": false,
      "Rank": 752,
      "Type": "excepturi",
      "ColorBlock": 784,
      "IconHint": "sed",
      "Selected": false,
      "LastChanged": "1998-01-31T13:57:18.6221857+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "ratione",
      "Hidden": true,
      "FullName": "Mikayla Kassulke",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 274
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "expedita",
      "Description": "Polarised bi-directional definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 791
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "expedita",
      "Description": "Polarised bi-directional definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 791
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "minus",
      "StrippedValue": "quisquam",
      "Description": "Mandatory solution-oriented matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 944
        }
      }
    },
    {
      "Value": "minus",
      "StrippedValue": "quisquam",
      "Description": "Mandatory solution-oriented matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 944
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ipsam",
      "StrippedValue": "amet",
      "Description": "Networked stable capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 788
        }
      }
    },
    {
      "Value": "ipsam",
      "StrippedValue": "amet",
      "Description": "Networked stable capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 788
        }
      }
    }
  ],
  "Description": "Grass-roots tangible leverage",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "doloribus",
      "PersonId": 213,
      "Mrmrs": "nihil",
      "Firstname": "Schuyler",
      "Lastname": "Berge",
      "MiddleName": "Ratke, Kunde and Kub",
      "Title": "nulla",
      "Description": "Object-based didactic conglomeration",
      "Email": "rocio@gaylord.uk",
      "FullName": "Nickolas Legros",
      "DirectPhone": "874-460-5304 x789",
      "FormalName": "Cartwright-Breitenberg",
      "CountryId": 974,
      "ContactId": 863,
      "ContactName": "Swift-Bartoletti",
      "Retired": 421,
      "Rank": 976,
      "ActiveInterests": 997,
      "ContactDepartment": "",
      "ContactCountryId": 39,
      "ContactOrgNr": "421435",
      "FaxPhone": "1-342-706-6550 x53260",
      "MobilePhone": "1-932-816-5516",
      "ContactPhone": "(954)207-8061 x820",
      "AssociateName": "Thompson, Mayert and Hintz",
      "AssociateId": 987,
      "UsePersonAddress": true,
      "ContactFax": "laboriosam",
      "Kanafname": "quae",
      "Kanalname": "ipsum",
      "Post1": "aspernatur",
      "Post2": "exercitationem",
      "Post3": "vitae",
      "EmailName": "melba@volkman.com",
      "ContactFullName": "Miss Mckenzie Skye Gottlieb",
      "ActiveErpLinks": 418,
      "TicketPriorityId": 863,
      "SupportLanguageId": 243,
      "SupportAssociateId": 21,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 402
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "vero",
  "Xstop": false,
  "ActiveInterests": 240,
  "GroupId": 769,
  "ActiveStatusMonitorId": 3,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 813,
  "DbiAgentId": 531,
  "DbiLastSyncronized": "1996-12-19T13:57:18.6378144+01:00",
  "DbiKey": "eum",
  "DbiLastModified": "2000-03-04T13:57:18.6378144+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 383,
  "ActiveErpLinks": 220,
  "BounceEmails": [
    "mckenna@sipesswaniawski.com",
    "mitchell.zemlak@mcclure.co.uk"
  ],
  "Domains": [
    "quidem",
    "repellendus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "886415557",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 719
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```