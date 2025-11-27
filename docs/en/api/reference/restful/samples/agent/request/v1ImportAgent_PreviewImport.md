```http!
POST /api/v1/Agents/Import/PreviewImport
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ImportLines": [
    {
      "Values": [
        "placeat",
        "inventore"
      ],
      "Selected": false,
      "Operation": "ContactAdded",
      "Type": "Contact",
      "ExternalKey": "nobis"
    },
    {
      "Values": [
        "placeat",
        "inventore"
      ],
      "Selected": false,
      "Operation": "ContactAdded",
      "Type": "Contact",
      "ExternalKey": "nobis"
    }
  ],
  "ColumnDefinition": [
    "quis",
    "perferendis"
  ],
  "Culture": "inventore",
  "Context": "excepturi"
}
```