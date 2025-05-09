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
  "ContactId": 310,
  "Name": "Kling-Gutkowski",
  "Department": "",
  "OrgNr": "283261",
  "Number1": "323118",
  "Number2": "1839072",
  "UpdatedDate": "2014-02-20T16:32:47.3215068+01:00",
  "CreatedDate": "2016-11-04T16:32:47.3215068+01:00",
  "Emails": [
    {
      "Value": "nam",
      "StrippedValue": "dolor",
      "Description": "Configurable intermediate product"
    },
    {
      "Value": "nam",
      "StrippedValue": "dolor",
      "Description": "Configurable intermediate product"
    }
  ],
  "Interests": [
    {
      "Id": 728,
      "Name": "Kris-Ruecker",
      "ToolTip": "Rerum repellat excepturi porro omnis quaerat.",
      "Deleted": false,
      "Rank": 146,
      "Type": "quos",
      "ColorBlock": 240,
      "IconHint": "velit",
      "Selected": false,
      "LastChanged": "2017-07-05T16:32:47.3371253+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "saepe",
      "StyleHint": "odio",
      "Hidden": false,
      "FullName": "Jamar Pfeffer IV"
    }
  ],
  "Urls": [
    {
      "Value": "dolor",
      "StrippedValue": "ipsam",
      "Description": "Business-focused coherent adapter"
    },
    {
      "Value": "dolor",
      "StrippedValue": "ipsam",
      "Description": "Business-focused coherent adapter"
    }
  ],
  "Phones": [
    {
      "Value": "iure",
      "StrippedValue": "dignissimos",
      "Description": "Optional responsive contingency"
    },
    {
      "Value": "iure",
      "StrippedValue": "dignissimos",
      "Description": "Optional responsive contingency"
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "incidunt",
      "Description": "Up-sized 6th generation archive"
    },
    {
      "Value": "est",
      "StrippedValue": "incidunt",
      "Description": "Up-sized 6th generation archive"
    }
  ],
  "Description": "Triple-buffered static moderator",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quas",
      "PersonId": 293,
      "Mrmrs": "quae",
      "Firstname": "Halie",
      "Lastname": "Kozey",
      "MiddleName": "Marquardt-Fadel",
      "Title": "necessitatibus",
      "Description": "Open-architected discrete application",
      "Email": "aidan.cremin@kovacek.ca",
      "FullName": "Lonny Adams",
      "DirectPhone": "1-995-232-8307",
      "FormalName": "Luettgen, Murazik and Dooley",
      "CountryId": 852,
      "ContactId": 366,
      "ContactName": "Huels-Batz",
      "Retired": 629,
      "Rank": 592,
      "ActiveInterests": 136,
      "ContactDepartment": "",
      "ContactCountryId": 627,
      "ContactOrgNr": "483552",
      "FaxPhone": "(646)402-9015 x85299",
      "MobilePhone": "718.446.6019",
      "ContactPhone": "(556)986-6210",
      "AssociateName": "Crist Group",
      "AssociateId": 142,
      "UsePersonAddress": false,
      "ContactFax": "nobis",
      "Kanafname": "nisi",
      "Kanalname": "vel",
      "Post1": "blanditiis",
      "Post2": "vel",
      "Post3": "cum",
      "EmailName": "corene.jaskolski@bergnaum.us",
      "ContactFullName": "Ms. Nichole Donnell Fay MD",
      "ActiveErpLinks": 464,
      "TicketPriorityId": 80,
      "SupportLanguageId": 74,
      "SupportAssociateId": 343,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1534185"
    }
  ],
  "NoMailing": false,
  "Kananame": "quia",
  "Xstop": false,
  "ActiveInterests": 311,
  "GroupId": 943,
  "ActiveStatusMonitorId": 291,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 508,
  "DbiAgentId": 218,
  "DbiLastSyncronized": "2000-01-31T16:32:47.3371253+01:00",
  "DbiKey": "deserunt",
  "DbiLastModified": "2015-06-21T16:32:47.3371253+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 624,
  "ActiveErpLinks": 82,
  "BounceEmails": [
    "reese_rosenbaum@collins.com",
    "ernie_shields@murray.uk"
  ],
  "Domains": [
    "excepturi",
    "nam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Corbin Nienow",
    "SuperOffice:2": "Tamara Christian Weimann MD"
  },
  "ExtraFields": {
    "ExtraFields1": "temporibus",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "voluptates",
    "CustomFields2": "dolorem"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 854,
  "Name": "Kertzmann-Watsica",
  "Department": "",
  "OrgNr": "1663876",
  "Number1": "989056",
  "Number2": "690254",
  "UpdatedDate": "2003-09-22T16:32:47.3371253+02:00",
  "CreatedDate": "2020-05-26T16:32:47.3371253+02:00",
  "Emails": [
    {
      "Value": "esse",
      "StrippedValue": "eaque",
      "Description": "Right-sized global database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 869
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "eaque",
      "Description": "Right-sized global database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 869
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 773,
      "Name": "Daugherty Inc and Sons",
      "ToolTip": "Et odio harum doloremque eos aut maxime et.",
      "Deleted": true,
      "Rank": 484,
      "Type": "qui",
      "ColorBlock": 570,
      "IconHint": "nesciunt",
      "Selected": false,
      "LastChanged": "2006-02-21T16:32:47.3371253+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "expedita",
      "Hidden": false,
      "FullName": "Sherman Kuhic",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 396
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "fugiat",
      "StrippedValue": "nemo",
      "Description": "Devolved empowering methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 745
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "nemo",
      "Description": "Devolved empowering methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 745
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "debitis",
      "StrippedValue": "distinctio",
      "Description": "Object-based multi-tasking hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 230
        }
      }
    },
    {
      "Value": "debitis",
      "StrippedValue": "distinctio",
      "Description": "Object-based multi-tasking hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 230
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "natus",
      "StrippedValue": "repudiandae",
      "Description": "Organized impactful help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 328
        }
      }
    },
    {
      "Value": "natus",
      "StrippedValue": "repudiandae",
      "Description": "Organized impactful help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 328
        }
      }
    }
  ],
  "Description": "Self-enabling 5th generation open architecture",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "cupiditate",
      "PersonId": 872,
      "Mrmrs": "iste",
      "Firstname": "Claud",
      "Lastname": "Streich",
      "MiddleName": "Greenfelder-Ankunding",
      "Title": "et",
      "Description": "Ameliorated background interface",
      "Email": "alvina@konopelskiwalker.us",
      "FullName": "Kyler Delores Strosin III",
      "DirectPhone": "525.123.0764",
      "FormalName": "Lakin Inc and Sons",
      "CountryId": 474,
      "ContactId": 373,
      "ContactName": "Hintz-Mraz",
      "Retired": 938,
      "Rank": 849,
      "ActiveInterests": 812,
      "ContactDepartment": "",
      "ContactCountryId": 673,
      "ContactOrgNr": "1832011",
      "FaxPhone": "691.340.0319",
      "MobilePhone": "(022)794-4665 x65533",
      "ContactPhone": "(740)098-4333 x97128",
      "AssociateName": "Ernser, Sporer and Hoppe",
      "AssociateId": 353,
      "UsePersonAddress": false,
      "ContactFax": "quis",
      "Kanafname": "non",
      "Kanalname": "architecto",
      "Post1": "quia",
      "Post2": "quia",
      "Post3": "repudiandae",
      "EmailName": "karlee@breitenberggerhold.co.uk",
      "ContactFullName": "Mr. Ila Grover Connelly",
      "ActiveErpLinks": 45,
      "TicketPriorityId": 677,
      "SupportLanguageId": 298,
      "SupportAssociateId": 787,
      "CategoryName": "VIP Customer",
      "PersonNumber": "701487",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 509
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "dolorum",
  "Xstop": false,
  "ActiveInterests": 734,
  "GroupId": 7,
  "ActiveStatusMonitorId": 275,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 451,
  "DbiAgentId": 213,
  "DbiLastSyncronized": "2005-03-23T16:32:47.3527467+01:00",
  "DbiKey": "pariatur",
  "DbiLastModified": "2020-04-06T16:32:47.3527467+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 449,
  "ActiveErpLinks": 610,
  "BounceEmails": [
    "sheila_wolf@kilback.biz",
    "jewel_morissette@hammes.info"
  ],
  "Domains": [
    "et",
    "voluptas"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1075752671",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "molestias",
    "ExtraFields2": "illo"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "eius"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 583
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```