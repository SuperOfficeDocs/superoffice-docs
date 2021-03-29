---
title: crmscript_ref_NSQuoteAgent_TestConnection_String_p_0_StringDictionary_p_1
description: NSQuoteAgent.TestConnection(String p_0, StringDictionary p_1)
intellisense: NSQuoteAgent.TestConnection
keywords: TestConnection(String,StringDictionary)
so.topic: reference
---


Used by the Admin clients. Testing if the connection data is sufficient to get a connection with the ERP system. The Connector should try to do some operations to check if the connection has sufficient rights to run. The connection has not been created yet. TestConnection is called without InitializeConnector being called first.



* **connectorName:** Name of the connector.
* **connectionData:** Basically the name/value collection of the configuration data requested to create a connection
* **Returns:** How the test went


