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
  "ContactId": 474,
  "Name": "Nicolas LLC",
  "Department": "",
  "OrgNr": "1190728",
  "Number1": "1488093",
  "Number2": "761548",
  "UpdatedDate": "2024-04-05T03:45:28.1859455+02:00",
  "CreatedDate": "1998-03-12T03:45:28.1859455+01:00",
  "Emails": [
    {
      "Value": "sit",
      "StrippedValue": "expedita",
      "Description": "Business-focused didactic contingency"
    },
    {
      "Value": "sit",
      "StrippedValue": "expedita",
      "Description": "Business-focused didactic contingency"
    }
  ],
  "Interests": [
    {
      "Id": 806,
      "Name": "Rempel LLC",
      "ToolTip": "Et explicabo.",
      "Deleted": false,
      "Rank": 998,
      "Type": "reprehenderit",
      "ColorBlock": 396,
      "IconHint": "est",
      "Selected": false,
      "LastChanged": "1999-05-07T03:45:28.1859455+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "pariatur",
      "StyleHint": "esse",
      "Hidden": true,
      "FullName": "Abbey Kub"
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "quia",
      "Description": "Synergized impactful encryption"
    },
    {
      "Value": "qui",
      "StrippedValue": "quia",
      "Description": "Synergized impactful encryption"
    }
  ],
  "Phones": [
    {
      "Value": "nulla",
      "StrippedValue": "et",
      "Description": "Persevering bandwidth-monitored analyzer"
    },
    {
      "Value": "nulla",
      "StrippedValue": "et",
      "Description": "Persevering bandwidth-monitored analyzer"
    }
  ],
  "Faxes": [
    {
      "Value": "blanditiis",
      "StrippedValue": "eum",
      "Description": "Business-focused systemic approach"
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "eum",
      "Description": "Business-focused systemic approach"
    }
  ],
  "Description": "User-centric system-worthy emulation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "minus",
      "PersonId": 276,
      "Mrmrs": "vero",
      "Firstname": "Jewel",
      "Lastname": "Hirthe",
      "MiddleName": "Williamson-Schimmel",
      "Title": "praesentium",
      "Description": "Enhanced leading edge hierarchy",
      "Email": "lacy@kiehnlowe.biz",
      "FullName": "Mina Swaniawski",
      "DirectPhone": "(400)927-5145",
      "FormalName": "Wyman-Wisozk",
      "CountryId": 30,
      "ContactId": 938,
      "ContactName": "Parker, Conn and Thiel",
      "Retired": 734,
      "Rank": 411,
      "ActiveInterests": 667,
      "ContactDepartment": "",
      "ContactCountryId": 82,
      "ContactOrgNr": "140207",
      "FaxPhone": "(724)911-5117",
      "MobilePhone": "067-440-0573 x41728",
      "ContactPhone": "1-436-167-2913",
      "AssociateName": "Hills-Hamill",
      "AssociateId": 391,
      "UsePersonAddress": false,
      "ContactFax": "cumque",
      "Kanafname": "aut",
      "Kanalname": "eligendi",
      "Post1": "non",
      "Post2": "non",
      "Post3": "a",
      "EmailName": "alexandre@kirlin.uk",
      "ContactFullName": "Ena Runte",
      "ActiveErpLinks": 886,
      "TicketPriorityId": 826,
      "SupportLanguageId": 795,
      "SupportAssociateId": 119,
      "CategoryName": "VIP Customer",
      "PersonNumber": "939126"
    }
  ],
  "NoMailing": true,
  "Kananame": "alias",
  "Xstop": true,
  "ActiveInterests": 633,
  "GroupId": 498,
  "ActiveStatusMonitorId": 51,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 417,
  "DbiAgentId": 635,
  "DbiLastSyncronized": "2021-12-28T03:45:28.1859455+01:00",
  "DbiKey": "dignissimos",
  "DbiLastModified": "2005-06-22T03:45:28.1859455+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 591,
  "ActiveErpLinks": 492,
  "BounceEmails": [
    "braxton_lehner@kilback.us",
    "osborne@okeefeconroy.us"
  ],
  "Domains": [
    "commodi",
    "numquam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Mrs. Aiyana Bruen III"
  },
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "fugit"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 33,
  "Name": "Altenwerth Inc and Sons",
  "Department": "",
  "OrgNr": "1009979",
  "Number1": "1392350",
  "Number2": "1066931",
  "UpdatedDate": "1998-08-17T03:45:28.2015694+02:00",
  "CreatedDate": "2011-09-09T03:45:28.2015694+02:00",
  "Emails": [
    {
      "Value": "atque",
      "StrippedValue": "nulla",
      "Description": "Implemented reciprocal moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 134
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "nulla",
      "Description": "Implemented reciprocal moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 134
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 209,
      "Name": "Franecki LLC",
      "ToolTip": "Omnis voluptatibus qui laudantium doloribus dolorem.",
      "Deleted": true,
      "Rank": 52,
      "Type": "minima",
      "ColorBlock": 702,
      "IconHint": "iure",
      "Selected": true,
      "LastChanged": "2023-07-10T03:45:28.2015694+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aspernatur",
      "StyleHint": "perferendis",
      "Hidden": false,
      "FullName": "Gregg Lockman",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 519
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quis",
      "StrippedValue": "quia",
      "Description": "Managed full-range knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 207
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "quia",
      "Description": "Managed full-range knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 207
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "eum",
      "StrippedValue": "assumenda",
      "Description": "Assimilated responsive orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 166
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "assumenda",
      "Description": "Assimilated responsive orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 166
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "velit",
      "StrippedValue": "qui",
      "Description": "Compatible neutral throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 290
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "qui",
      "Description": "Compatible neutral throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 290
        }
      }
    }
  ],
  "Description": "Multi-tiered 5th generation moderator",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sunt",
      "PersonId": 807,
      "Mrmrs": "quia",
      "Firstname": "Jeromy",
      "Lastname": "Weber",
      "MiddleName": "Rice, Will and Wisozk",
      "Title": "nihil",
      "Description": "Right-sized zero tolerance encoding",
      "Email": "tevin@marquardt.uk",
      "FullName": "Miss Silas Davon Powlowski",
      "DirectPhone": "302.743.8979 x67167",
      "FormalName": "Jaskolski-McDermott",
      "CountryId": 866,
      "ContactId": 676,
      "ContactName": "Willms LLC",
      "Retired": 191,
      "Rank": 595,
      "ActiveInterests": 958,
      "ContactDepartment": "",
      "ContactCountryId": 598,
      "ContactOrgNr": "1232454",
      "FaxPhone": "(553)250-4374 x2122",
      "MobilePhone": "360-380-0419",
      "ContactPhone": "1-575-929-6107",
      "AssociateName": "Spencer LLC",
      "AssociateId": 19,
      "UsePersonAddress": true,
      "ContactFax": "repellat",
      "Kanafname": "omnis",
      "Kanalname": "praesentium",
      "Post1": "sint",
      "Post2": "dolor",
      "Post3": "aut",
      "EmailName": "neil@stark.uk",
      "ContactFullName": "Rene Lowe",
      "ActiveErpLinks": 348,
      "TicketPriorityId": 672,
      "SupportLanguageId": 146,
      "SupportAssociateId": 515,
      "CategoryName": "VIP Customer",
      "PersonNumber": "324471",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 269
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "aspernatur",
  "Xstop": true,
  "ActiveInterests": 15,
  "GroupId": 754,
  "ActiveStatusMonitorId": 357,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 135,
  "DbiAgentId": 364,
  "DbiLastSyncronized": "1999-01-06T03:45:28.2015694+01:00",
  "DbiKey": "ab",
  "DbiLastModified": "2000-01-06T03:45:28.2015694+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 171,
  "ActiveErpLinks": 783,
  "BounceEmails": [
    "dayana@steuberwisoky.biz",
    "haleigh_kilback@bosco.ca"
  ],
  "Domains": [
    "rerum",
    "culpa"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "422585500",
    "SuperOffice:2": "Doyle Breitenberg"
  },
  "ExtraFields": {
    "ExtraFields1": "harum",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "repellendus",
    "CustomFields2": "sint"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 519
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```