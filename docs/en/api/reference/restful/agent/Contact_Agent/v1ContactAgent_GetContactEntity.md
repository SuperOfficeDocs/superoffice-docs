---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
generated: true
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=694
POST /api/v1/Agents/Contact/GetContactEntity?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

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

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 809,
  "Name": "Monahan Group",
  "Department": "",
  "OrgNr": "1076194",
  "Number1": "840951",
  "Number2": "832839",
  "UpdatedDate": "2022-02-09T14:23:46.1105841+01:00",
  "CreatedDate": "2020-11-22T14:23:46.1105841+01:00",
  "Emails": [
    {
      "Value": "ea",
      "StrippedValue": "qui",
      "Description": "Enterprise-wide methodical workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 49
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "qui",
      "Description": "Enterprise-wide methodical workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 49
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 242,
      "Name": "Kozey, Bailey and Streich",
      "ToolTip": "Velit sunt eum labore illum provident.",
      "Deleted": false,
      "Rank": 947,
      "Type": "provident",
      "ColorBlock": 554,
      "IconHint": "in",
      "Selected": false,
      "LastChanged": "2021-05-24T14:23:46.1105841+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "velit",
      "Hidden": false,
      "FullName": "Ms. Eleanora Sigmund Daniel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 361
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "odio",
      "Description": "Team-oriented tangible firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 128
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "odio",
      "Description": "Team-oriented tangible firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 128
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "veritatis",
      "StrippedValue": "rerum",
      "Description": "Profound impactful synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 354
        }
      }
    },
    {
      "Value": "veritatis",
      "StrippedValue": "rerum",
      "Description": "Profound impactful synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 354
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "maxime",
      "StrippedValue": "fugit",
      "Description": "Triple-buffered content-based task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 75
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "fugit",
      "Description": "Triple-buffered content-based task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 75
        }
      }
    }
  ],
  "Description": "Managed hybrid local area network",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eius",
      "PersonId": 554,
      "Mrmrs": "ab",
      "Firstname": "Logan",
      "Lastname": "Fisher",
      "MiddleName": "Beatty-Reichel",
      "Title": "quod",
      "Description": "Synergistic national installation",
      "Email": "hilario@mckenzie.com",
      "FullName": "Alberta Torp",
      "DirectPhone": "(491)440-2860",
      "FormalName": "Altenwerth Inc and Sons",
      "CountryId": 942,
      "ContactId": 435,
      "ContactName": "Schamberger LLC",
      "Retired": 380,
      "Rank": 863,
      "ActiveInterests": 285,
      "ContactDepartment": "",
      "ContactCountryId": 930,
      "ContactOrgNr": "925984",
      "FaxPhone": "528.237.2370 x6598",
      "MobilePhone": "723-296-3496 x08446",
      "ContactPhone": "(021)516-0177 x65403",
      "AssociateName": "Ebert, Mills and Pouros",
      "AssociateId": 969,
      "UsePersonAddress": true,
      "ContactFax": "eum",
      "Kanafname": "a",
      "Kanalname": "rerum",
      "Post1": "quis",
      "Post2": "et",
      "Post3": "voluptates",
      "EmailName": "zena_hackett@gulgowskibins.ca",
      "ContactFullName": "Ewald Champlin",
      "ActiveErpLinks": 311,
      "TicketPriorityId": 256,
      "SupportLanguageId": 106,
      "SupportAssociateId": 502,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 104
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "nulla",
  "Xstop": true,
  "ActiveInterests": 821,
  "GroupId": 671,
  "ActiveStatusMonitorId": 30,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 847,
  "DbiAgentId": 287,
  "DbiLastSyncronized": "2008-05-01T14:23:46.1105841+02:00",
  "DbiKey": "aut",
  "DbiLastModified": "2006-01-07T14:23:46.1105841+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 854,
  "ActiveErpLinks": 734,
  "BounceEmails": [
    "bill@murazik.us",
    "kailyn.roberts@bartolettinienow.ca"
  ],
  "Domains": [
    "aperiam",
    "esse"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Matt Zulauf",
    "SuperOffice:2": "Christa Bernhard"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "quisquam"
  },
  "CustomFields": {
    "CustomFields1": "doloribus",
    "CustomFields2": "necessitatibus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 347
    }
  }
}
```