---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 822,
  "Name": "Rohan, Gleichner and Kessler",
  "Department": "",
  "OrgNr": "1168865",
  "Number1": "940343",
  "Number2": "381143",
  "UpdatedDate": "2017-09-23T12:19:44.9298363+02:00",
  "CreatedDate": "2017-09-23T12:19:44.9298363+02:00",
  "Emails": [
    {
      "Value": "non",
      "StrippedValue": "dolorum",
      "Description": "Object-based bifurcated contingency",
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
      "Value": "non",
      "StrippedValue": "dolorum",
      "Description": "Object-based bifurcated contingency",
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
  "Interests": [
    {
      "Id": 83,
      "Name": "Medhurst, Dicki and Ward",
      "ToolTip": "In alias.",
      "Deleted": false,
      "Rank": 979,
      "Type": "qui",
      "ColorBlock": 825,
      "IconHint": "dolor",
      "Selected": true,
      "LastChanged": "2022-09-22T12:19:44.9298363+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "officiis",
      "Hidden": false,
      "FullName": "Miss Jacey Jorge Sporer IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 435
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ipsa",
      "StrippedValue": "possimus",
      "Description": "Virtual leading edge ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 796
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "possimus",
      "Description": "Virtual leading edge ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 796
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptas",
      "StrippedValue": "ut",
      "Description": "Open-architected assymetric time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "ut",
      "Description": "Open-architected assymetric time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatum",
      "StrippedValue": "id",
      "Description": "Cross-group multimedia success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 239
        }
      }
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "id",
      "Description": "Cross-group multimedia success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 239
        }
      }
    }
  ],
  "Description": "Distributed object-oriented conglomeration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nostrum",
      "PersonId": 959,
      "Mrmrs": "ipsam",
      "Firstname": "Javon",
      "Lastname": "Wisozk",
      "MiddleName": "Rau-Lesch",
      "Title": "corporis",
      "Description": "Streamlined disintermediate knowledge user",
      "Email": "milford@hammesrodriguez.uk",
      "FullName": "Nickolas Hansen",
      "DirectPhone": "485-526-3101",
      "FormalName": "Friesen-Homenick",
      "CountryId": 77,
      "ContactId": 854,
      "ContactName": "Ward Inc and Sons",
      "Retired": 786,
      "Rank": 769,
      "ActiveInterests": 183,
      "ContactDepartment": "",
      "ContactCountryId": 132,
      "ContactOrgNr": "1527197",
      "FaxPhone": "735-155-6062 x159",
      "MobilePhone": "678.468.5592 x3599",
      "ContactPhone": "734-703-3992 x3416",
      "AssociateName": "Glover, Fahey and Turner",
      "AssociateId": 428,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "quisquam",
      "Kanalname": "et",
      "Post1": "enim",
      "Post2": "recusandae",
      "Post3": "eligendi",
      "EmailName": "alverta@strosin.name",
      "ContactFullName": "Prof. Nels Cloyd Bosco I",
      "ActiveErpLinks": 55,
      "TicketPriorityId": 425,
      "SupportLanguageId": 392,
      "SupportAssociateId": 60,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 96
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "eum",
  "Xstop": false,
  "ActiveInterests": 732,
  "GroupId": 374,
  "ActiveStatusMonitorId": 295,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 983,
  "DbiAgentId": 972,
  "DbiLastSyncronized": "2000-05-22T12:19:44.9454565+02:00",
  "DbiKey": "nihil",
  "DbiLastModified": "2023-12-04T12:19:44.9454565+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 995,
  "ActiveErpLinks": 706,
  "BounceEmails": [
    "bobby_zieme@handortiz.info",
    "allie.rolfson@kunde.com"
  ],
  "Domains": [
    "aut",
    "ut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Judah Zulauf",
    "SuperOffice:2": "Demetrius Jakubowski"
  },
  "ExtraFields": {
    "ExtraFields1": "repudiandae",
    "ExtraFields2": "rem"
  },
  "CustomFields": {
    "CustomFields1": "distinctio",
    "CustomFields2": "nesciunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 915
    }
  }
}
```