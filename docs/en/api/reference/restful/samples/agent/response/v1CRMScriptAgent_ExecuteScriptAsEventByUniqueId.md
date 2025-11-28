```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Type": "ChatAfterSaveNewMessage",
  "InputValues": {
    "saleId": "54321",
    "amount": "150000"
  },
  "BlockExecution": false,
  "NavigateTo": "sale.main?id=54321",
  "Message": "Sales opportunity score calculated and updated",
  "ShowDialog": "Information",
  "OutputValues": {
    "calculatedScore": "85",
    "scoringCriteria": "Customer value, Deal size, Timeline"
  },
  "StateValues": {
    "saleStatus": "Qualified",
    "lastScored": "2024-11-27T10:15:00Z"
  },
  "Exception": "",
  "ParserValues": {
    "scriptName": "sales-opportunity-scorer",
    "executionTime": "92ms"
  },
  "CgiVariables": {
    "HTTP_USER_AGENT": "SuperOffice/10.3",
    "REMOTE_ADDR": "10.0.1.50"
  },
  "CgiContent": "{\"action\":\"score\",\"entity\":\"sale\"}",
  "Headers": {
    "Content-Type": "application/json",
    "X-Script-Version": "1.2.0"
  },
  "TraceExecution": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 590
    }
  }
}
```
