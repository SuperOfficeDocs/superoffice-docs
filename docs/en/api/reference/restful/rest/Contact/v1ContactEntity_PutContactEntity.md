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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 153,
  "Name": "Pfeffer-Durgan",
  "Department": "",
  "OrgNr": "1129138",
  "Number1": "1454333",
  "Number2": "1470451",
  "UpdatedDate": "1999-11-12T17:37:38.3978598+01:00",
  "CreatedDate": "2013-09-11T17:37:38.3978598+02:00",
  "Emails": [
    {
      "Value": "quo",
      "StrippedValue": "delectus",
      "Description": "Synergistic system-worthy service-desk"
    },
    {
      "Value": "quo",
      "StrippedValue": "delectus",
      "Description": "Synergistic system-worthy service-desk"
    }
  ],
  "Interests": [
    {
      "Id": 674,
      "Name": "Lynch-Jewess",
      "ToolTip": "Ab incidunt qui est veniam.",
      "Deleted": false,
      "Rank": 200,
      "Type": "vero",
      "ColorBlock": 221,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2013-01-06T17:37:38.3988595+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repudiandae",
      "StyleHint": "quos",
      "Hidden": false,
      "FullName": "Joshuah Lemke"
    }
  ],
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "ducimus",
      "Description": "Focused logistical Graphic Interface"
    },
    {
      "Value": "sed",
      "StrippedValue": "ducimus",
      "Description": "Focused logistical Graphic Interface"
    }
  ],
  "Phones": [
    {
      "Value": "veritatis",
      "StrippedValue": "autem",
      "Description": "Synergistic 24/7 circuit"
    },
    {
      "Value": "veritatis",
      "StrippedValue": "autem",
      "Description": "Synergistic 24/7 circuit"
    }
  ],
  "Faxes": [
    {
      "Value": "eos",
      "StrippedValue": "autem",
      "Description": "Switchable discrete complexity"
    },
    {
      "Value": "eos",
      "StrippedValue": "autem",
      "Description": "Switchable discrete complexity"
    }
  ],
  "Description": "Public-key analyzing toolset",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "laboriosam",
      "PersonId": 959,
      "Mrmrs": "dolore",
      "Firstname": "Jeffery",
      "Lastname": "Feeney",
      "MiddleName": "Morissette-Hills",
      "Title": "necessitatibus",
      "Description": "Future-proofed executive contingency",
      "Email": "jodie@nitzschepfeffer.name",
      "FullName": "Nicole Schuster",
      "DirectPhone": "(259)816-9290 x9249",
      "FormalName": "Carter, Hills and Paucek",
      "CountryId": 535,
      "ContactId": 670,
      "ContactName": "Hessel-McLaughlin",
      "Retired": 339,
      "Rank": 503,
      "ActiveInterests": 217,
      "ContactDepartment": "",
      "ContactCountryId": 329,
      "ContactOrgNr": "1616788",
      "FaxPhone": "072-567-8527 x6929",
      "MobilePhone": "(283)815-3895 x198",
      "ContactPhone": "025-341-2252",
      "AssociateName": "Gibson-Ledner",
      "AssociateId": 976,
      "UsePersonAddress": true,
      "ContactFax": "dolorem",
      "Kanafname": "qui",
      "Kanalname": "placeat",
      "Post1": "accusamus",
      "Post2": "in",
      "Post3": "velit",
      "EmailName": "vivien@gradyrunte.biz",
      "ContactFullName": "Adah Kozey",
      "ActiveErpLinks": 421,
      "TicketPriorityId": 862,
      "SupportLanguageId": 953,
      "SupportAssociateId": 498,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "suscipit",
  "Xstop": false,
  "ActiveInterests": 467,
  "GroupId": 867,
  "ActiveStatusMonitorId": 418,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 434,
  "DbiAgentId": 37,
  "DbiLastSyncronized": "2006-04-28T17:37:38.4028599+02:00",
  "DbiKey": "praesentium",
  "DbiLastModified": "2005-12-04T17:37:38.4028599+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 243,
  "ActiveErpLinks": 235,
  "BounceEmails": [
    "fausto.kuhic@brekkeparisian.us",
    "giovanny@gerlach.name"
  ],
  "Domains": [
    "quibusdam",
    "libero"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Sven Gislason",
    "SuperOffice:2": "Dylan Collier"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "aliquam"
  },
  "CustomFields": {
    "CustomFields1": "quam",
    "CustomFields2": "perspiciatis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 217,
  "Name": "Hills, Jewess and Schowalter",
  "Department": "",
  "OrgNr": "1864110",
  "Number1": "645197",
  "Number2": "591057",
  "UpdatedDate": "2012-10-25T17:37:38.4128594+02:00",
  "CreatedDate": "2012-10-23T17:37:38.4128594+02:00",
  "Emails": [
    {
      "Value": "quod",
      "StrippedValue": "similique",
      "Description": "Synchronised encompassing Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 488
        }
      }
    },
    {
      "Value": "quod",
      "StrippedValue": "similique",
      "Description": "Synchronised encompassing Graphical User Interface",
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
  "Interests": [
    {
      "Id": 345,
      "Name": "Jast-Ankunding",
      "ToolTip": "Sed non dolor.",
      "Deleted": false,
      "Rank": 652,
      "Type": "temporibus",
      "ColorBlock": 653,
      "IconHint": "tempore",
      "Selected": false,
      "LastChanged": "2021-07-04T17:37:38.4128594+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aliquam",
      "StyleHint": "doloribus",
      "Hidden": true,
      "FullName": "Lysanne Shanahan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 631
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "cupiditate",
      "StrippedValue": "eos",
      "Description": "Multi-lateral grid-enabled extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 642
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "eos",
      "Description": "Multi-lateral grid-enabled extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 642
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "repudiandae",
      "StrippedValue": "et",
      "Description": "Distributed fault-tolerant encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 789
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "et",
      "Description": "Distributed fault-tolerant encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 789
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "natus",
      "StrippedValue": "quis",
      "Description": "Polarised composite moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    },
    {
      "Value": "natus",
      "StrippedValue": "quis",
      "Description": "Polarised composite moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    }
  ],
  "Description": "Visionary bandwidth-monitored parallelism",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "praesentium",
      "PersonId": 809,
      "Mrmrs": "ea",
      "Firstname": "Zakary",
      "Lastname": "Boehm",
      "MiddleName": "Ullrich Inc and Sons",
      "Title": "nisi",
      "Description": "Right-sized zero administration installation",
      "Email": "lizeth.schamberger@heathcote.name",
      "FullName": "Miss Dagmar Stephan Kirlin PhD",
      "DirectPhone": "1-451-456-3654 x44358",
      "FormalName": "Hilll-Rutherford",
      "CountryId": 170,
      "ContactId": 533,
      "ContactName": "Mayer Group",
      "Retired": 195,
      "Rank": 787,
      "ActiveInterests": 633,
      "ContactDepartment": "",
      "ContactCountryId": 203,
      "ContactOrgNr": "1337606",
      "FaxPhone": "592-147-0218 x937",
      "MobilePhone": "720-036-1862 x194",
      "ContactPhone": "(950)422-7377",
      "AssociateName": "Brakus, Gibson and Thompson",
      "AssociateId": 457,
      "UsePersonAddress": false,
      "ContactFax": "dignissimos",
      "Kanafname": "voluptas",
      "Kanalname": "laudantium",
      "Post1": "optio",
      "Post2": "vel",
      "Post3": "non",
      "EmailName": "kendall@abshire.us",
      "ContactFullName": "Arnold Mertz",
      "ActiveErpLinks": 633,
      "TicketPriorityId": 9,
      "SupportLanguageId": 237,
      "SupportAssociateId": 815,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 393
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "dolores",
  "Xstop": false,
  "ActiveInterests": 28,
  "GroupId": 769,
  "ActiveStatusMonitorId": 991,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 613,
  "DbiAgentId": 523,
  "DbiLastSyncronized": "2018-03-22T17:37:38.4168596+01:00",
  "DbiKey": "dolor",
  "DbiLastModified": "2006-06-11T17:37:38.4168596+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 137,
  "ActiveErpLinks": 161,
  "BounceEmails": [
    "abner@runolfssoncummings.ca",
    "america.williamson@mclaughlin.us"
  ],
  "Domains": [
    "labore",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Ms. Marjory Jones III"
  },
  "ExtraFields": {
    "ExtraFields1": "labore",
    "ExtraFields2": "aliquam"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "quia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 551
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```