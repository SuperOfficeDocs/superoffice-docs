---
title: Void bypassNetServer(Bool p0)
path: /EJScript/Classes/SearchEngine/member functions/Void bypassNetServer(Bool p_0)
intellisense: 1
classref: 1
keywords: bypassNetServer(Bool)
---


From version 7 all the queries are sent to NetServer instead of directly to the database.


This function will allow you to send the queries directly to the database instead.
The function has no effect if the registry value (reg\_id = 235) is set to 0.

Be aware of any security implications by circumventing the NetServer.


