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
  "ContactId": 957,
  "Name": "Hills, Dach and O'Conner",
  "Department": "",
  "OrgNr": "352463",
  "Number1": "748236",
  "Number2": "997537",
  "UpdatedDate": "2021-08-06T03:24:51.4899959+02:00",
  "CreatedDate": "2014-01-31T03:24:51.4899959+01:00",
  "Emails": [
    {
      "Value": "ipsam",
      "StrippedValue": "non",
      "Description": "Open-architected static moratorium"
    },
    {
      "Value": "ipsam",
      "StrippedValue": "non",
      "Description": "Open-architected static moratorium"
    }
  ],
  "Interests": [
    {
      "Id": 932,
      "Name": "Bailey, Hintz and Abshire",
      "ToolTip": "Necessitatibus nihil repellendus repellendus.",
      "Deleted": false,
      "Rank": 506,
      "Type": "maxime",
      "ColorBlock": 586,
      "IconHint": "molestiae",
      "Selected": true,
      "LastChanged": "2017-01-08T03:24:51.4899959+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ipsa",
      "StyleHint": "nulla",
      "Hidden": false,
      "FullName": "Prof. Joe Nikolaus"
    }
  ],
  "Urls": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "consectetur",
      "Description": "Distributed needs-based time-frame"
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "consectetur",
      "Description": "Distributed needs-based time-frame"
    }
  ],
  "Phones": [
    {
      "Value": "sunt",
      "StrippedValue": "natus",
      "Description": "Organic reciprocal attitude"
    },
    {
      "Value": "sunt",
      "StrippedValue": "natus",
      "Description": "Organic reciprocal attitude"
    }
  ],
  "Faxes": [
    {
      "Value": "ipsa",
      "StrippedValue": "deserunt",
      "Description": "Customer-focused optimizing forecast"
    },
    {
      "Value": "ipsa",
      "StrippedValue": "deserunt",
      "Description": "Customer-focused optimizing forecast"
    }
  ],
  "Description": "Extended multimedia task-force",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "esse",
      "PersonId": 137,
      "Mrmrs": "autem",
      "Firstname": "Maia",
      "Lastname": "Schumm",
      "MiddleName": "Tillman Group",
      "Title": "ullam",
      "Description": "Managed 4th generation time-frame",
      "Email": "vaughn@ward.us",
      "FullName": "Alisha Hamill",
      "DirectPhone": "(792)432-7489 x05458",
      "FormalName": "Yundt, Gleichner and Douglas",
      "CountryId": 257,
      "ContactId": 708,
      "ContactName": "O'Connell-Ullrich",
      "Retired": 372,
      "Rank": 873,
      "ActiveInterests": 843,
      "ContactDepartment": "",
      "ContactCountryId": 750,
      "ContactOrgNr": "1450512",
      "FaxPhone": "1-730-659-8024",
      "MobilePhone": "(217)824-2495",
      "ContactPhone": "1-316-221-4832 x42572",
      "AssociateName": "Ratke, Erdman and Schulist",
      "AssociateId": 203,
      "UsePersonAddress": false,
      "ContactFax": "quo",
      "Kanafname": "repellat",
      "Kanalname": "quia",
      "Post1": "natus",
      "Post2": "aut",
      "Post3": "rerum",
      "EmailName": "laverne_goodwin@morissette.info",
      "ContactFullName": "Tom Daugherty",
      "ActiveErpLinks": 755,
      "TicketPriorityId": 700,
      "SupportLanguageId": 314,
      "SupportAssociateId": 218,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "necessitatibus",
  "Xstop": false,
  "ActiveInterests": 847,
  "GroupId": 627,
  "ActiveStatusMonitorId": 736,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 168,
  "DbiAgentId": 754,
  "DbiLastSyncronized": "2023-01-27T03:24:51.4899959+01:00",
  "DbiKey": "dolores",
  "DbiLastModified": "2013-03-28T03:24:51.4899959+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 177,
  "ActiveErpLinks": 208,
  "BounceEmails": [
    "sim@anderson.info",
    "marian_botsford@leffler.uk"
  ],
  "Domains": [
    "quia",
    "mollitia"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Chyna Dach",
    "SuperOffice:2": "Angie Doyle V"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "dignissimos"
  },
  "CustomFields": {
    "CustomFields1": "voluptates",
    "CustomFields2": "debitis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 30,
  "Name": "Zboncak, Daugherty and Hilll",
  "Department": "",
  "OrgNr": "720660",
  "Number1": "816777",
  "Number2": "249814",
  "UpdatedDate": "2015-09-12T03:24:51.5056149+02:00",
  "CreatedDate": "2002-12-20T03:24:51.5056149+01:00",
  "Emails": [
    {
      "Value": "praesentium",
      "StrippedValue": "qui",
      "Description": "Optimized 5th generation access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 722
        }
      }
    },
    {
      "Value": "praesentium",
      "StrippedValue": "qui",
      "Description": "Optimized 5th generation access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 722
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 288,
      "Name": "Rolfson, Jaskolski and Dickinson",
      "ToolTip": "Similique quaerat aliquam.",
      "Deleted": true,
      "Rank": 923,
      "Type": "quibusdam",
      "ColorBlock": 872,
      "IconHint": "natus",
      "Selected": false,
      "LastChanged": "2005-03-12T03:24:51.5056149+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "praesentium",
      "Hidden": true,
      "FullName": "Jerry Collins",
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
      "Value": "pariatur",
      "StrippedValue": "ut",
      "Description": "Profound 3rd generation access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 664
        }
      }
    },
    {
      "Value": "pariatur",
      "StrippedValue": "ut",
      "Description": "Profound 3rd generation access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 664
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "error",
      "StrippedValue": "quo",
      "Description": "Intuitive full-range internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 491
        }
      }
    },
    {
      "Value": "error",
      "StrippedValue": "quo",
      "Description": "Intuitive full-range internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 491
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolores",
      "StrippedValue": "quibusdam",
      "Description": "User-centric coherent throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 340
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "quibusdam",
      "Description": "User-centric coherent throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 340
        }
      }
    }
  ],
  "Description": "Networked demand-driven challenge",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "harum",
      "PersonId": 605,
      "Mrmrs": "et",
      "Firstname": "Cali",
      "Lastname": "Swift",
      "MiddleName": "Brakus Group",
      "Title": "eum",
      "Description": "Cross-platform context-sensitive workforce",
      "Email": "brittany@ferry.info",
      "FullName": "Antwon Dickens",
      "DirectPhone": "1-599-598-6695 x128",
      "FormalName": "Hickle-Connelly",
      "CountryId": 578,
      "ContactId": 817,
      "ContactName": "Bayer LLC",
      "Retired": 292,
      "Rank": 956,
      "ActiveInterests": 73,
      "ContactDepartment": "orchestrate cross-platform e-markets",
      "ContactCountryId": 145,
      "ContactOrgNr": "1167931",
      "FaxPhone": "1-942-248-6247 x13412",
      "MobilePhone": "(737)182-1370 x71232",
      "ContactPhone": "271-838-4276",
      "AssociateName": "Dicki, Stanton and Bechtelar",
      "AssociateId": 346,
      "UsePersonAddress": false,
      "ContactFax": "facere",
      "Kanafname": "neque",
      "Kanalname": "magnam",
      "Post1": "minus",
      "Post2": "non",
      "Post3": "distinctio",
      "EmailName": "damian@bins.co.uk",
      "ContactFullName": "Mr. Kaylah Jeanette Maggio",
      "ActiveErpLinks": 393,
      "TicketPriorityId": 470,
      "SupportLanguageId": 652,
      "SupportAssociateId": 12,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 611
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "dicta",
  "Xstop": false,
  "ActiveInterests": 656,
  "GroupId": 274,
  "ActiveStatusMonitorId": 176,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 267,
  "DbiAgentId": 542,
  "DbiLastSyncronized": "2016-01-19T03:24:51.5056149+01:00",
  "DbiKey": "deleniti",
  "DbiLastModified": "2013-06-07T03:24:51.5056149+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 162,
  "ActiveErpLinks": 562,
  "BounceEmails": [
    "marilie@anderson.name",
    "savannah.sporer@romaguera.uk"
  ],
  "Domains": [
    "et",
    "vel"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Kaylee West",
    "SuperOffice:2": "Micaela Gerhold"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "deserunt"
  },
  "CustomFields": {
    "CustomFields1": "distinctio",
    "CustomFields2": "est"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 236
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```