<!-- markdownlint-disable-file MD041 -->
Caching on the web application may prevent new information from appearing in the client. If that is the case, send a GET request with the flush query string to flush all caches.

```curl
GET https://{{env}}.superoffice.com/{{tenant}}/default.aspx?flush HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
```

Optionally, enter that URL into a browser and navigate to the page with the ´?flush´ query string parameter with an authenticated user.

> [!NOTE]
> Read more about [?flush][1]

<!-- Referenced links -->
[1]: ./flush-details.md
