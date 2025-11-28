```http!
POST /api/v1/CRMScript/{cRMScriptUniqueId}/ExecuteAsEvent
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Type": "ChatAfterSaveNewMessage",
  "InputValues": {
    "InputValues1": "itaque",
    "InputValues2": "architecto"
  },
  "BlockExecution": false,
  "NavigateTo": "eius",
  "Message": "veritatis",
  "ShowDialog": "expedita",
  "OutputValues": {
    "OutputValues1": "est",
    "OutputValues2": "numquam"
  },
  "StateValues": {
    "StateValues1": "voluptatem",
    "StateValues2": "architecto"
  },
  "Exception": "temporibus",
  "ParserValues": {
    "ParserValues1": "impedit",
    "ParserValues2": "vero"
  },
  "CgiVariables": {
    "CgiVariables1": "numquam",
    "CgiVariables2": "et"
  },
  "CgiContent": "et",
  "Headers": {
    "Headers1": "et",
    "Headers2": "consequatur"
  },
  "TraceExecution": true
}
```