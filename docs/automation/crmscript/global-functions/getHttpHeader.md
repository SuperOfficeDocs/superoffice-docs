---
description: String getHttpHeader(String headerName)
path: /EJScript/Global functions/String getHttpHeader(String headerName)
intellisense: 1
langref: 1
keywords: getHttpHeader(String headerName)---

Returns the value of the specified header name.

###Example code:###


    String method = getHttpHeader("REQUEST-METHOD");




###Parameter:###


 - ACCEPT-*
 - ACCESS-CONTROL-REQUEST-METHOD
 - ACCESS-CONTROL-REQUEST-HEADERS
 - CACHE-CONTROL
 - CONTENT-LENGTH
 - CONTENT-TYPE
 - DATE
 - DNT
 - EXPECT
 - IF-*
 - ORIGIN
 - PRAGMA
 - RANGE
 - REFERER
 - REQUEST-METHOD
 - REQUEST-URI
 - TE
 - USER-AGENT
 - X-CRMSCRIPT-*
 - X-FORWARDED-FOR
 - X-REQUESTED-WITH
 - X-SUPEROFFICE-EVENT
 - X-SUPEROFFICE-EVENTID
 - X-SUPEROFFICE-RETRY
 - X-SUPEROFFICE-SIGNATURE

* **headerName:** Name of the header
* **Returns:** The header value
