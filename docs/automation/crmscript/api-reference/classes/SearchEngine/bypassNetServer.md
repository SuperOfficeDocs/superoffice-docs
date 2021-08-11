---
uid: crmscript_ref_SearchEngine_bypassNetServer_Bool_p_0
title: SearchEngine.bypassNetServer(Bool p_0)
intellisense: SearchEngine.bypassNetServer
keywords: bypassNetServer(Bool)
so.topic: reference
---

# SearchEngine.bypassNetServer(Bool p_0)

From version 7 all the queries are sent to NetServer instead of directly to the database.

This function will allow you to send the queries directly to the database instead.
The function has no effect if the registry value (reg\_id = 235) is set to 0.

Be aware of any security implications by circumventing the NetServer.

