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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 305,
  "Name": "Stark, Ortiz and Kirlin",
  "Department": "",
  "OrgNr": "574469",
  "Number1": "1460567",
  "Number2": "852492",
  "UpdatedDate": "2020-04-04T13:14:08.5397442+02:00",
  "CreatedDate": "2003-09-02T13:14:08.5397442+02:00",
  "Emails": [
    {
      "Value": "ea",
      "StrippedValue": "impedit",
      "Description": "Re-engineered discrete website"
    },
    {
      "Value": "ea",
      "StrippedValue": "impedit",
      "Description": "Re-engineered discrete website"
    }
  ],
  "Interests": [
    {
      "Id": 865,
      "Name": "Rogahn-Cassin",
      "ToolTip": "Quia neque.",
      "Deleted": false,
      "Rank": 833,
      "Type": "accusamus",
      "ColorBlock": 442,
      "IconHint": "consequatur",
      "Selected": false,
      "LastChanged": "2025-01-09T13:14:08.5397442+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "neque",
      "StyleHint": "nulla",
      "Hidden": false,
      "FullName": "Prof. Frederick Walter"
    }
  ],
  "Urls": [
    {
      "Value": "perferendis",
      "StrippedValue": "nihil",
      "Description": "Object-based object-oriented paradigm"
    },
    {
      "Value": "perferendis",
      "StrippedValue": "nihil",
      "Description": "Object-based object-oriented paradigm"
    }
  ],
  "Phones": [
    {
      "Value": "ipsam",
      "StrippedValue": "nulla",
      "Description": "Multi-layered intangible budgetary management"
    },
    {
      "Value": "ipsam",
      "StrippedValue": "nulla",
      "Description": "Multi-layered intangible budgetary management"
    }
  ],
  "Faxes": [
    {
      "Value": "dolore",
      "StrippedValue": "non",
      "Description": "Self-enabling dedicated middleware"
    },
    {
      "Value": "dolore",
      "StrippedValue": "non",
      "Description": "Self-enabling dedicated middleware"
    }
  ],
  "Description": "Synergistic bottom-line hardware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eligendi",
      "PersonId": 872,
      "Mrmrs": "dolores",
      "Firstname": "Barrett",
      "Lastname": "Lang",
      "MiddleName": "Senger, Muller and Rath",
      "Title": "consequuntur",
      "Description": "Self-enabling assymetric neural-net",
      "Email": "ray_dicki@lehner.name",
      "FullName": "Ms. Sadie Jailyn Cruickshank",
      "DirectPhone": "(101)754-3397 x4379",
      "FormalName": "Cartwright-Wyman",
      "CountryId": 525,
      "ContactId": 824,
      "ContactName": "Rogahn-Huel",
      "Retired": 74,
      "Rank": 192,
      "ActiveInterests": 564,
      "ContactDepartment": "",
      "ContactCountryId": 642,
      "ContactOrgNr": "881271",
      "FaxPhone": "267-670-4504",
      "MobilePhone": "(829)221-7525 x2895",
      "ContactPhone": "764.409.9235 x16113",
      "AssociateName": "Kiehn-Reichel",
      "AssociateId": 161,
      "UsePersonAddress": false,
      "ContactFax": "voluptas",
      "Kanafname": "voluptatem",
      "Kanalname": "voluptas",
      "Post1": "cupiditate",
      "Post2": "fugiat",
      "Post3": "odio",
      "EmailName": "bonita.mcdermott@koelpin.com",
      "ContactFullName": "Jessika McClure",
      "ActiveErpLinks": 845,
      "TicketPriorityId": 19,
      "SupportLanguageId": 9,
      "SupportAssociateId": 346,
      "CategoryName": "VIP Customer",
      "PersonNumber": "820245"
    }
  ],
  "NoMailing": false,
  "Kananame": "veniam",
  "Xstop": false,
  "ActiveInterests": 981,
  "GroupId": 331,
  "ActiveStatusMonitorId": 565,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 401,
  "DbiAgentId": 678,
  "DbiLastSyncronized": "2022-10-28T13:14:08.5553702+02:00",
  "DbiKey": "id",
  "DbiLastModified": "2003-08-11T13:14:08.5553702+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 801,
  "ActiveErpLinks": 545,
  "BounceEmails": [
    "kaden@keebler.us",
    "jovan_rempel@king.us"
  ],
  "Domains": [
    "totam",
    "porro"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Megane Eulalia Fisher V",
    "SuperOffice:2": "Theresia Bruen II"
  },
  "ExtraFields": {
    "ExtraFields1": "nemo",
    "ExtraFields2": "exercitationem"
  },
  "CustomFields": {
    "CustomFields1": "atque",
    "CustomFields2": "iste"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 734,
  "Name": "Schimmel, Cassin and Smitham",
  "Department": "",
  "OrgNr": "1075110",
  "Number1": "678027",
  "Number2": "1587181",
  "UpdatedDate": "2023-02-11T13:14:08.5553702+01:00",
  "CreatedDate": "2019-04-28T13:14:08.5553702+02:00",
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "optio",
      "Description": "Persevering web-enabled interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 152
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "optio",
      "Description": "Persevering web-enabled interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 152
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 196,
      "Name": "Smitham LLC",
      "ToolTip": "Magni voluptatem aut consequuntur officiis.",
      "Deleted": true,
      "Rank": 357,
      "Type": "sequi",
      "ColorBlock": 835,
      "IconHint": "repellendus",
      "Selected": false,
      "LastChanged": "2009-12-08T13:14:08.5553702+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eum",
      "StyleHint": "officiis",
      "Hidden": true,
      "FullName": "Kaleigh Bashirian",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 216
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "velit",
      "StrippedValue": "vel",
      "Description": "Exclusive global project",
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
      "Value": "velit",
      "StrippedValue": "vel",
      "Description": "Exclusive global project",
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
  "Phones": [
    {
      "Value": "architecto",
      "StrippedValue": "itaque",
      "Description": "Organic transitional access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 959
        }
      }
    },
    {
      "Value": "architecto",
      "StrippedValue": "itaque",
      "Description": "Organic transitional access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 959
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatem",
      "StrippedValue": "tempora",
      "Description": "Multi-tiered system-worthy moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 319
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "tempora",
      "Description": "Multi-tiered system-worthy moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 319
        }
      }
    }
  ],
  "Description": "Distributed dynamic implementation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "occaecati",
      "PersonId": 676,
      "Mrmrs": "ut",
      "Firstname": "Anya",
      "Lastname": "Wyman",
      "MiddleName": "Schoen LLC",
      "Title": "inventore",
      "Description": "Business-focused foreground artificial intelligence",
      "Email": "heidi_prohaska@braun.com",
      "FullName": "Raina Reinger",
      "DirectPhone": "1-537-808-3321 x192",
      "FormalName": "Klocko-Metz",
      "CountryId": 99,
      "ContactId": 465,
      "ContactName": "McGlynn-Braun",
      "Retired": 444,
      "Rank": 18,
      "ActiveInterests": 516,
      "ContactDepartment": "",
      "ContactCountryId": 901,
      "ContactOrgNr": "1212061",
      "FaxPhone": "002-501-2750",
      "MobilePhone": "849.957.6055",
      "ContactPhone": "641-229-9086 x46517",
      "AssociateName": "Kassulke Inc and Sons",
      "AssociateId": 911,
      "UsePersonAddress": false,
      "ContactFax": "velit",
      "Kanafname": "et",
      "Kanalname": "tempore",
      "Post1": "rerum",
      "Post2": "maiores",
      "Post3": "temporibus",
      "EmailName": "cecelia@eichmannlarkin.com",
      "ContactFullName": "Mrs. Payton Prosacco Sr.",
      "ActiveErpLinks": 915,
      "TicketPriorityId": 650,
      "SupportLanguageId": 232,
      "SupportAssociateId": 196,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1539443",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 397
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "et",
  "Xstop": true,
  "ActiveInterests": 467,
  "GroupId": 181,
  "ActiveStatusMonitorId": 457,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 368,
  "DbiAgentId": 306,
  "DbiLastSyncronized": "2000-07-29T13:14:08.5553702+02:00",
  "DbiKey": "recusandae",
  "DbiLastModified": "2024-03-31T13:14:08.5553702+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 327,
  "ActiveErpLinks": 83,
  "BounceEmails": [
    "vaughn@little.uk",
    "leila@reilly.biz"
  ],
  "Domains": [
    "eum",
    "sunt"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Judy Abbott V",
    "SuperOffice:2": "Jaron Gorczany"
  },
  "ExtraFields": {
    "ExtraFields1": "eveniet",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "asperiores",
    "CustomFields2": "incidunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 442
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```