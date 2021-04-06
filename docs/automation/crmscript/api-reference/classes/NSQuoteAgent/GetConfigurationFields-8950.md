---
uid: crmscript_ref_NSQuoteAgent_GetConfigurationFields_Integer_p_0_String_p_1
title: NSQuoteAgent.GetConfigurationFields(Integer p_0, String p_1)
intellisense: NSQuoteAgent.GetConfigurationFields
keywords: GetConfigurationFields(Integer,String)
so.topic: reference
---


Used by ADMIN. Asks for metadata needed to populate admin dialog that takes in the information needed to create a connection to an ERP system. The values entered in the dialog are stored in SuperOffice db and used when InitializeConnector is called by the client.



* **connectionId:** Id of an existing connection, if any. Initializes connection with current config values if non-zero.
* **connectorName:** Name of the connector. Ignored if connectionId is non-zero.
* **Returns:** carriers


