```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "UniqueIdentifier": "sales-opportunity-scorer",
  "Name": "Sales Opportunity Scorer",
  "Description": "Calculates and assigns a score to sales opportunities based on multiple criteria",
  "IncludeId": "opportunity-scorer",
  "Source": "#setLanguageLevel 3;\nSale sale = getActiveSale();\nInteger score = calculateOpportunityScore(sale);\nsale.setValue(\"score\", score.toString());",
  "Registered": "2024-03-10T14:15:00+01:00",
  "RegisteredBy": "Michael Thompson",
  "Updated": "2024-11-26T11:30:00+01:00",
  "UpdatedBy": "Emily Wilson",
  "Path": "/scripts/sales/opportunity-scorer",
  "BlockedVerbs": "BlockAll",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 954
    }
  }
}
```
