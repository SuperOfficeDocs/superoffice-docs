<!-- markdownlint-disable-file MD041 -->
* Information doesn't leak via web panels (and thus forwarded to others who are not authorized)
* The context identifier template variable (`uctx`) and also the User login associate ID (`usid`) are part of the URL of all web panels you add
* `usec` is **never** passed as a parameter in the URL
