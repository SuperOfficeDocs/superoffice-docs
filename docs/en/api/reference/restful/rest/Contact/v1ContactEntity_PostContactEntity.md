---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
generated: true
---

# POST Contact

```http
POST /api/v1/Contact
```

Creates a new ContactEntity


Calls the Contact agent service SaveContactEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Contact?$select=name,department,category/id
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

## Request Body: newEntity 

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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

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
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 478,
  "Name": "Stiedemann LLC",
  "Department": "",
  "OrgNr": "477311",
  "Number1": "1871784",
  "Number2": "1266812",
  "UpdatedDate": "2019-04-08T02:38:25.9642073+02:00",
  "CreatedDate": "2017-05-29T02:38:25.9642073+02:00",
  "Emails": [
    {
      "Value": "in",
      "StrippedValue": "blanditiis",
      "Description": "Horizontal client-server neural-net"
    },
    {
      "Value": "in",
      "StrippedValue": "blanditiis",
      "Description": "Horizontal client-server neural-net"
    }
  ],
  "Interests": [
    {
      "Id": 13,
      "Name": "Hettinger Group",
      "ToolTip": "Qui aut sed unde.",
      "Deleted": false,
      "Rank": 335,
      "Type": "explicabo",
      "ColorBlock": 635,
      "IconHint": "facilis",
      "Selected": false,
      "LastChanged": "2022-01-13T02:38:25.9642073+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "minus",
      "StyleHint": "ipsum",
      "Hidden": false,
      "FullName": "Mrs. Kieran Morar"
    }
  ],
  "Urls": [
    {
      "Value": "iure",
      "StrippedValue": "ullam",
      "Description": "Grass-roots bifurcated model"
    },
    {
      "Value": "iure",
      "StrippedValue": "ullam",
      "Description": "Grass-roots bifurcated model"
    }
  ],
  "Phones": [
    {
      "Value": "corrupti",
      "StrippedValue": "ut",
      "Description": "Expanded optimizing toolset"
    },
    {
      "Value": "corrupti",
      "StrippedValue": "ut",
      "Description": "Expanded optimizing toolset"
    }
  ],
  "Faxes": [
    {
      "Value": "rerum",
      "StrippedValue": "molestiae",
      "Description": "Public-key encompassing knowledge base"
    },
    {
      "Value": "rerum",
      "StrippedValue": "molestiae",
      "Description": "Public-key encompassing knowledge base"
    }
  ],
  "Description": "Function-based interactive open architecture",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 205,
      "Mrmrs": "accusamus",
      "Firstname": "Bessie",
      "Lastname": "Schowalter",
      "MiddleName": "Konopelski, Kertzmann and Greenfelder",
      "Title": "mollitia",
      "Description": "Versatile responsive support",
      "Email": "laila@wyman.name",
      "FullName": "Dylan Trisha Jenkins II",
      "DirectPhone": "524.837.3478 x913",
      "FormalName": "Oberbrunner LLC",
      "CountryId": 861,
      "ContactId": 362,
      "ContactName": "Lindgren, Halvorson and Effertz",
      "Retired": 600,
      "Rank": 849,
      "ActiveInterests": 763,
      "ContactDepartment": "",
      "ContactCountryId": 542,
      "ContactOrgNr": "996142",
      "FaxPhone": "1-518-779-7532",
      "MobilePhone": "442.536.2051",
      "ContactPhone": "660.490.5808 x5634",
      "AssociateName": "Runolfsson-Mayert",
      "AssociateId": 515,
      "UsePersonAddress": false,
      "ContactFax": "nesciunt",
      "Kanafname": "dolores",
      "Kanalname": "qui",
      "Post1": "voluptas",
      "Post2": "commodi",
      "Post3": "possimus",
      "EmailName": "everette.dooley@herman.com",
      "ContactFullName": "Mr. Frieda Tromp I",
      "ActiveErpLinks": 785,
      "TicketPriorityId": 281,
      "SupportLanguageId": 837,
      "SupportAssociateId": 266,
      "CategoryName": "VIP Customer",
      "PersonNumber": "652872"
    }
  ],
  "NoMailing": false,
  "Kananame": "consequuntur",
  "Xstop": false,
  "ActiveInterests": 751,
  "GroupId": 224,
  "ActiveStatusMonitorId": 613,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 959,
  "DbiAgentId": 731,
  "DbiLastSyncronized": "2000-12-13T02:38:25.9642073+01:00",
  "DbiKey": "eligendi",
  "DbiLastModified": "2020-10-21T02:38:25.9642073+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 71,
  "ActiveErpLinks": 176,
  "BounceEmails": [
    "ali.bosco@abernathykuhn.us",
    "misty_jast@cremin.uk"
  ],
  "Domains": [
    "possimus",
    "rerum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Greta Johnson"
  },
  "ExtraFields": {
    "ExtraFields1": "maxime",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "voluptatem"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 265,
  "Name": "Ledner LLC",
  "Department": "",
  "OrgNr": "1441500",
  "Number1": "991929",
  "Number2": "913198",
  "UpdatedDate": "1998-09-23T02:38:25.979826+02:00",
  "CreatedDate": "2021-11-22T02:38:25.979826+01:00",
  "Emails": [
    {
      "Value": "corporis",
      "StrippedValue": "aut",
      "Description": "Focused heuristic local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 428
        }
      }
    },
    {
      "Value": "corporis",
      "StrippedValue": "aut",
      "Description": "Focused heuristic local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 428
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 523,
      "Name": "Schmitt Inc and Sons",
      "ToolTip": "Cum rerum dolores quaerat.",
      "Deleted": false,
      "Rank": 977,
      "Type": "vel",
      "ColorBlock": 326,
      "IconHint": "at",
      "Selected": false,
      "LastChanged": "2003-11-25T02:38:25.979826+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repellendus",
      "StyleHint": "debitis",
      "Hidden": false,
      "FullName": "Fae Marquardt",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 480
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quo",
      "StrippedValue": "esse",
      "Description": "Profound maximized support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 594
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "esse",
      "Description": "Profound maximized support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 594
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptate",
      "StrippedValue": "facilis",
      "Description": "Centralized human-resource customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 674
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "facilis",
      "Description": "Centralized human-resource customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 674
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "porro",
      "StrippedValue": "qui",
      "Description": "Synergized local service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 130
        }
      }
    },
    {
      "Value": "porro",
      "StrippedValue": "qui",
      "Description": "Synergized local service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 130
        }
      }
    }
  ],
  "Description": "User-centric maximized monitoring",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "similique",
      "PersonId": 980,
      "Mrmrs": "quo",
      "Firstname": "Antwan",
      "Lastname": "Reilly",
      "MiddleName": "Cartwright, Metz and Hills",
      "Title": "facere",
      "Description": "Configurable disintermediate neural-net",
      "Email": "joan.torp@murazikjacobi.biz",
      "FullName": "Maida Toy",
      "DirectPhone": "1-225-909-4952 x13112",
      "FormalName": "Gorczany-Murray",
      "CountryId": 818,
      "ContactId": 643,
      "ContactName": "Dach, Hyatt and Volkman",
      "Retired": 914,
      "Rank": 907,
      "ActiveInterests": 61,
      "ContactDepartment": "",
      "ContactCountryId": 761,
      "ContactOrgNr": "410040",
      "FaxPhone": "1-101-459-0392 x6275",
      "MobilePhone": "1-457-030-9546",
      "ContactPhone": "(052)567-2647 x38091",
      "AssociateName": "Grant-King",
      "AssociateId": 90,
      "UsePersonAddress": false,
      "ContactFax": "deserunt",
      "Kanafname": "voluptas",
      "Kanalname": "totam",
      "Post1": "natus",
      "Post2": "voluptas",
      "Post3": "ut",
      "EmailName": "lavinia@jonesglover.name",
      "ContactFullName": "Prof. Mabel Becker",
      "ActiveErpLinks": 591,
      "TicketPriorityId": 734,
      "SupportLanguageId": 672,
      "SupportAssociateId": 329,
      "CategoryName": "VIP Customer",
      "PersonNumber": "750837",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 439
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "fuga",
  "Xstop": false,
  "ActiveInterests": 767,
  "GroupId": 631,
  "ActiveStatusMonitorId": 439,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 970,
  "DbiAgentId": 564,
  "DbiLastSyncronized": "2017-06-27T02:38:25.979826+02:00",
  "DbiKey": "assumenda",
  "DbiLastModified": "2009-11-23T02:38:25.979826+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 742,
  "ActiveErpLinks": 739,
  "BounceEmails": [
    "sierra.stark@spinka.uk",
    "hellen@lynch.co.uk"
  ],
  "Domains": [
    "quam",
    "repellat"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Ms. Osborne Oberbrunner"
  },
  "ExtraFields": {
    "ExtraFields1": "cum",
    "ExtraFields2": "consequuntur"
  },
  "CustomFields": {
    "CustomFields1": "rem",
    "CustomFields2": "esse"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 364
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```