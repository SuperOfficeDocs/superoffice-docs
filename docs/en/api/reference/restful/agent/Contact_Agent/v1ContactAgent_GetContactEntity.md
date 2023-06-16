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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=65
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

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 945,
  "Name": "Price, Ledner and Runolfsdottir",
  "Department": "",
  "OrgNr": "964679",
  "Number1": "367317",
  "Number2": "863118",
  "UpdatedDate": "2018-07-07T16:00:40.3675171+02:00",
  "CreatedDate": "1996-10-30T16:00:40.3675171+01:00",
  "Emails": [
    {
      "Value": "nam",
      "StrippedValue": "porro",
      "Description": "Exclusive impactful benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 543
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "porro",
      "Description": "Exclusive impactful benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 543
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 8,
      "Name": "Metz Group",
      "ToolTip": "Eos deserunt.",
      "Deleted": true,
      "Rank": 494,
      "Type": "consequatur",
      "ColorBlock": 664,
      "IconHint": "quae",
      "Selected": false,
      "LastChanged": "1996-02-10T16:00:40.3675171+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "doloremque",
      "StyleHint": "alias",
      "Hidden": false,
      "FullName": "Jonathon Powlowski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 378
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "deleniti",
      "StrippedValue": "ut",
      "Description": "Organized grid-enabled info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 211
        }
      }
    },
    {
      "Value": "deleniti",
      "StrippedValue": "ut",
      "Description": "Organized grid-enabled info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 211
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "deserunt",
      "StrippedValue": "illo",
      "Description": "Automated high-level adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 57
        }
      }
    },
    {
      "Value": "deserunt",
      "StrippedValue": "illo",
      "Description": "Automated high-level adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 57
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ad",
      "StrippedValue": "facilis",
      "Description": "User-centric explicit Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 670
        }
      }
    },
    {
      "Value": "ad",
      "StrippedValue": "facilis",
      "Description": "User-centric explicit Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 670
        }
      }
    }
  ],
  "Description": "Secured responsive monitoring",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "tempore",
      "PersonId": 780,
      "Mrmrs": "minus",
      "Firstname": "Sophia",
      "Lastname": "Friesen",
      "MiddleName": "Gleichner Group",
      "Title": "hic",
      "Description": "Grass-roots tertiary standardization",
      "Email": "adriana@walker.us",
      "FullName": "Mrs. Buster Gene Wisoky",
      "DirectPhone": "1-908-590-2688 x2251",
      "FormalName": "Jewess, Tillman and Carroll",
      "CountryId": 592,
      "ContactId": 499,
      "ContactName": "Kuphal Inc and Sons",
      "Retired": 100,
      "Rank": 845,
      "ActiveInterests": 701,
      "ContactDepartment": "",
      "ContactCountryId": 721,
      "ContactOrgNr": "1250922",
      "FaxPhone": "294.642.5269 x8377",
      "MobilePhone": "(871)517-8482",
      "ContactPhone": "044-477-3894",
      "AssociateName": "Fritsch Inc and Sons",
      "AssociateId": 1000,
      "UsePersonAddress": true,
      "ContactFax": "ut",
      "Kanafname": "et",
      "Kanalname": "perferendis",
      "Post1": "praesentium",
      "Post2": "rem",
      "Post3": "molestiae",
      "EmailName": "glenda_ward@schultz.biz",
      "ContactFullName": "Annamarie Kub",
      "ActiveErpLinks": 762,
      "TicketPriorityId": 440,
      "SupportLanguageId": 963,
      "SupportAssociateId": 421,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 954
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "modi",
  "Xstop": false,
  "ActiveInterests": 436,
  "GroupId": 265,
  "ActiveStatusMonitorId": 356,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 214,
  "DbiAgentId": 507,
  "DbiLastSyncronized": "1996-11-27T16:00:40.3831405+01:00",
  "DbiKey": "laborum",
  "DbiLastModified": "2007-09-12T16:00:40.3831405+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 391,
  "ActiveErpLinks": 773,
  "BounceEmails": [
    "juana@bernhard.ca",
    "enid.goodwin@gutkowski.info"
  ],
  "Domains": [
    "dolor",
    "asperiores"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Kallie Ines Borer III",
    "SuperOffice:2": "1742615014"
  },
  "ExtraFields": {
    "ExtraFields1": "expedita",
    "ExtraFields2": "distinctio"
  },
  "CustomFields": {
    "CustomFields1": "praesentium",
    "CustomFields2": "aperiam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 454
    }
  }
}
```