<!-- markdownlint-disable-file MD041 -->
SuperOffice CRM Online is a cloud platform serving thousands of customers. Like any serious distributed and federated platform service, it requires several phases for development, testing, and production.

SuperOffice provides three environments: development, stage, and production.

**Environment matrix:**

| Environment | Authentication / login | OpenID Connect Discovery Endpoint | Example WebAPI tenant URL |
|---|---|---|---|
| Development | `https://sod.superoffice.com` | `https://sod.superoffice.com/login/.well-known/openid-configuration` | `https://sod2.superoffice.com/cust1234/api/` / `https://app-sod.superoffice.com/cust1234/api/` |
| Stage (QA) | `https://qaonline.superoffice.com` | `https://qaonline.superoffice.com/login/.well-known/openid-configuration` | `https://stage.superoffice.com/cust1234/api/` / `https://app-stage.superoffice.com/cust1234/api/` |
| Production | `https://online.superoffice.com` | `https://online.superoffice.com/login/.well-known/openid-configuration` | `https://online2.superoffice.com/cust1234/api/` / `https://app.superoffice.com/cust1234/api/` |

> [!NOTE]
> Use State URL to get tenant URL.

![SuperOffice provides three environments: development, stage, and production -screenshot][img1]

<!-- Referenced images -->
[img1]: ../media/online-environments.png
