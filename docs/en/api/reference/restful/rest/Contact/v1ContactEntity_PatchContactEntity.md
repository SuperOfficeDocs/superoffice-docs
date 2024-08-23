---
title: PATCH Contact/{id}
uid: v1ContactEntity_PatchContactEntity
generated: true
---

# PATCH Contact/{id}

```http
PATCH /api/v1/Contact/{id}
```

Update a ContactEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.


See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.IContactAgent} service SaveContactEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Contact/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | String | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | String | The property names to modify.  "/users/0/email", "/users/-", |
| value | Object | New/Replaced value - string or object. |

## Response:

ContactEntity  updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity  updated. |
| 404 | ContactEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |

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
PATCH /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "est",
    "value": {}
  },
  {
    "op": "add",
    "path": "est",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 808,
  "Name": "Ankunding, Kuhic and Casper",
  "Department": "",
  "OrgNr": "570659",
  "Number1": "1570451",
  "Number2": "570012",
  "UpdatedDate": "2021-12-05T13:28:31.4917874+01:00",
  "CreatedDate": "2000-11-11T13:28:31.4917874+01:00",
  "Emails": [
    {
      "Value": "nesciunt",
      "StrippedValue": "est",
      "Description": "Assimilated dynamic matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 243
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "est",
      "Description": "Assimilated dynamic matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 243
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 15,
      "Name": "Kling Inc and Sons",
      "ToolTip": "Error facilis non sit.",
      "Deleted": false,
      "Rank": 865,
      "Type": "inventore",
      "ColorBlock": 673,
      "IconHint": "illum",
      "Selected": true,
      "LastChanged": "2017-08-28T13:28:31.4917874+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "amet",
      "StyleHint": "dolore",
      "Hidden": false,
      "FullName": "Nicola Lesch",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 455
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptas",
      "StrippedValue": "quia",
      "Description": "Multi-tiered transitional forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 80
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "quia",
      "Description": "Multi-tiered transitional forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 80
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quae",
      "StrippedValue": "maxime",
      "Description": "Balanced intermediate core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 864
        }
      }
    },
    {
      "Value": "quae",
      "StrippedValue": "maxime",
      "Description": "Balanced intermediate core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 864
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "molestiae",
      "StrippedValue": "in",
      "Description": "Networked 4th generation software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 618
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "in",
      "Description": "Networked 4th generation software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 618
        }
      }
    }
  ],
  "Description": "Progressive real-time migration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dicta",
      "PersonId": 784,
      "Mrmrs": "ipsa",
      "Firstname": "Okey",
      "Lastname": "Bernhard",
      "MiddleName": "Graham, Conroy and Wilkinson",
      "Title": "corrupti",
      "Description": "Stand-alone hybrid strategy",
      "Email": "darren@cassinpaucek.co.uk",
      "FullName": "Mr. Stephen Murray V",
      "DirectPhone": "909.915.4667 x91473",
      "FormalName": "Torp Inc and Sons",
      "CountryId": 967,
      "ContactId": 90,
      "ContactName": "Koch Group",
      "Retired": 627,
      "Rank": 41,
      "ActiveInterests": 249,
      "ContactDepartment": "",
      "ContactCountryId": 742,
      "ContactOrgNr": "824091",
      "FaxPhone": "1-802-437-6374",
      "MobilePhone": "802.329.9201 x045",
      "ContactPhone": "1-380-365-9875 x02874",
      "AssociateName": "Grimes, Pacocha and Schroeder",
      "AssociateId": 462,
      "UsePersonAddress": true,
      "ContactFax": "modi",
      "Kanafname": "cum",
      "Kanalname": "consequuntur",
      "Post1": "nam",
      "Post2": "dolores",
      "Post3": "dolorem",
      "EmailName": "harvey@hamillosinski.us",
      "ContactFullName": "Elissa Reilly",
      "ActiveErpLinks": 740,
      "TicketPriorityId": 677,
      "SupportLanguageId": 56,
      "SupportAssociateId": 768,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 634
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "odit",
  "Xstop": false,
  "ActiveInterests": 205,
  "GroupId": 484,
  "ActiveStatusMonitorId": 869,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 699,
  "DbiAgentId": 478,
  "DbiLastSyncronized": "2011-11-05T13:28:31.4917874+01:00",
  "DbiKey": "aut",
  "DbiLastModified": "2013-03-21T13:28:31.4917874+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 98,
  "ActiveErpLinks": 266,
  "BounceEmails": [
    "laury@jerde.uk",
    "aurelia_oberbrunner@labadie.info"
  ],
  "Domains": [
    "est",
    "cumque"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1451627757",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "dolore"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "quibusdam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 924
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```