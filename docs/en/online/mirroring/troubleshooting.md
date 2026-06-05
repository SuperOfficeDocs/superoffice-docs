---
title: Troubleshooting Database Mirroring
uid: mirroring_troubleshooting
description: Diagnostic guidance for the Database Mirroring client &mdash; logs, service state, schema, and recovery.
author: SuperOffice Product and Engineering
date: 05.27.2026
keywords: database mirroring, replication, troubleshooting, diagnostics, event log
content_type: howto
deployment: online
platform: web
---

# Troubleshooting Database Mirroring

> [!NOTE]
> This page covers the **new outbound-only client** (`SuperOffice.Online.Replication.Client.exe`). For the [legacy WCF-based mirroring service][1], see the bottom of the page.

## Quick first-aid checklist

When something looks wrong, run through these checks in order:

1. **Is the Windows Service running?** Open **services.msc** and look for `SuperOfficeReplicationClient_<ReplicationId>`. It should show **Running**.

2. **Are there errors in the Windows Event Log?** Open **Event Viewer &rarr; Windows Logs &rarr; Application** and filter for source `SuperOfficeReplicationClient`.

3. **Run `validate`.** Stop the service, run

    ```cmd
    SuperOffice.Online.Replication.Client.exe validate
    ```

    and read the output. It checks configuration, database connectivity, and cloud reachability without starting replication.

4. **Check session state.** Run

    ```cmd
    SuperOffice.Online.Replication.Client.exe info
    ```

    to see the tenant, the Replication ID, token expiry, and the URLs the client is using.

5. **If tokens look invalid or expired**, run

    ```cmd
    SuperOffice.Online.Replication.Client.exe reconnect
    ```

    to re-authenticate without re-provisioning.

## The service will not start

Possible causes and what to check:

* **`appsettings.json` is missing or invalid.** The service logs a startup error in the Event Log; the message normally points at the offending key. Validate the JSON with any editor that supports JSON schema.
* **The replica database is not reachable** with the connection string in `ReplicaDatabase.ConnectionString`. Try connecting from the host with SQL Server Management Studio using the same credentials.
* **The service account lacks `db_owner`** on the replica. The client needs to create tables and update `_ReplicationState`.
* **The session has not been provisioned.** Run `provision` first.

## Connection or token errors

Symptoms in the Event Log: `401 Unauthorized`, `403 Forbidden`, repeated "token refresh failed", or "session not found".

* The refresh token may have been revoked from the SuperOffice side &mdash; for example because the app was reset or the customer subscription changed. Run `reconnect` to re-authenticate. If that fails, run `provision` again.
* The host clock may be skewed. The JWT tokens are short-lived (~20 min) and the cloud rejects tokens with a clock skew of more than a few minutes. Confirm the host time is synced.
* Outbound HTTPS to the SuperOffice Replication endpoints may be blocked. Confirm with a quick `curl` or browser test from the host.

## Data is not arriving (or is delayed)

* Compare timestamps in the Event Log with what you expect. The client logs `Information` entries for each commit cycle.
* If the client has been **offline for more than 7 days**, change events have been purged from Kafka. See [Force re-sync][3].
* If a single table is stale, use `resync-tables`:

    ```cmd
    SuperOffice.Online.Replication.Client.exe resync-tables crm7.<table>
    ```

* If the Windows Service shows **Running** but you see no activity, raise the log level temporarily to `Debug` (see [Logging][4]) and check the next cycle.

## Schema is out of date

If you have added an extra table or field in SuperOffice Service and it has not appeared in the replica:

* By default the client checks for new tables once per hour (`SchemaUpdateIntervalSeconds = 3600`).
* Force an immediate check with:

    ```cmd
    SuperOffice.Online.Replication.Client.exe update-schema
    ```

* New tables are populated on the next sync cycle after they are discovered.

## Multiple instances on the same host

Test and Production clients can coexist on one host. If you see unexpected behaviour:

* Confirm each instance is unzipped into its **own folder** with its own `appsettings.json`.
* Confirm each instance points at a **different replica database** in its connection string.
* Confirm the Windows Service names are distinct &mdash; they are derived from the Replication ID, so two sessions with the same name on the same host will collide.

## "Out-of-date client" critical error

If the cloud enforces a minimum client version and yours is older, replication stops and the Event Log shows a critical error.

Plan a periodic upgrade window. Upgrades are a stop / replace binaries / start cycle:

1. `sc stop "SuperOfficeReplicationClient_<ReplicationId>"`
2. Replace the binaries in the install folder.
3. `sc start "SuperOfficeReplicationClient_<ReplicationId>"`

`appsettings.json`, `nlog.config`, and the session state (in `_ReplicationState`) are preserved.

## How to collect diagnostic information for a support case

When opening a support case, include:

* The Replication ID and Tenant ID (from `info`).
* The exact client version (shown by `info` or in the file properties of the executable).
* The relevant Event Log entries (export the filtered view as an `.evtx` or text).
* The output of `validate`.
* Your `appsettings.json` with secrets redacted.

## Legacy (WCF-based) mirroring

> [!IMPORTANT]
> The sections below apply **only** to the legacy WCF-based mirroring service. New deployments use the [outbound-only client][2].

The most common problems during setup and configuration of legacy Database Mirroring were:

* Unavailable service
* Validation error

### Unavailable service

> [!NOTE]
> This section assumes the legacy service is hosted as a WCF service in IIS.

The most common error message observed is the unavailability of a customer mirroring endpoint:

```txt
The HTTP service located at https://{your database mirror url}/Mirroring/MirroringClientService.svc is unavailable.
This could be because the service is too busy or because no endpoint was found listening at the specified address.
Please ensure that the address is correct and try accessing the service again later.
```

This is often observed in the log files as seen here:

![unavailable wcf service error message -screenshot][img1]

This problem is difficult to understand because viewing the web service in IIS delivers the expected WCF service web page:

![iis wcf service page -screenshot][img2]

The error message in this case is misleading. When you view a WCF service in IIS, the page is served as a response to a GET request in the browser. The legacy Mirroring Task, however, sends POST requests to the customer's web server. Therein lies the difference.

You can verify this by issuing a POST request to the legacy mirror URL:

> [!NOTE]
> The following example contains an invalid JWT token and does not affect the point of testing service availability.

```http
POST https://DATABASE-MIRROR-URL/MirroringClientService.svc HTTP/1.1
Content-Type: text/xml;charset=UTF-8
SOAPAction: http://www.superoffice.com/online/mirroring/0.1/IMirroringClientService/Authenticate

<s:Envelope xmlns:s="http://schemas.xmlsoap.org/soap/envelope/">
  <s:Header>
    <SignedToken s:mustUnderstand="1"
       xmlns="http://www.superoffice.com/online/mirroring/0.1">eyJhbsyNmwg</SignedToken>
  </s:Header>
  <s:Body>
    <AuthenticateRequest
       xmlns="http://www.superoffice.com/online/mirroring/0.1">
      <ClientState/>
    </AuthenticateRequest>
  </s:Body>
</s:Envelope>
```

The expected response is an HTTP 404:

![iis 404 response -screenshot][img3]

If you see this, the connectivity issue is likely caused by permissions settings on the IIS server. When the legacy mirroring service is available to GET requests but unavailable to POST requests, the configuration likely requires the additional security element in the `basicHttpBinding` configuration:

```xml
<bindings>
  <basicHttpBinding>
    <binding name="DbMirroring"
             maxBufferPoolSize="2147483647"
             maxReceivedMessageSize="2147483647"
             maxBufferSize="2147483647">

      <!-- Add this following security element -->
      <security mode="Transport">
          <transport clientCredentialType="None" />
      </security>

      <readerQuotas maxDepth="2147483647"
                    maxStringContentLength="2147483647"
                    maxArrayLength="2147483647"
                    maxBytesPerRead="2147483647"
                    maxNameTableCharCount="2147483647" />
    </binding>
  </basicHttpBinding>
</bindings>
```

> [!NOTE]
> If the WCF service returns a 404 when the security element is present, remove the security element from the `basicHttpBinding` binding section and try again.

If your network infrastructure has more complex requirements, consult the Microsoft [WCF bindings and security][5] documentation, or review the [security transport][6] documentation.

### Validation errors

The legacy mirroring service initiates synchronization by passing a signed security token to the mirroring endpoint, which the endpoint validates. The endpoint then creates and signs its own security token, and sends it back to SuperOffice. Only after SuperOffice has validated the returned signed token does the mirroring service begin to send data.

Assuming the endpoint uses the [SuperOffice.Crm.Online.Mirroring][7] NuGet library, a token-validation failure returns an error similar to:

```txt
Exception:
Failed validating token
    at SuperOffice.SuperID.Client.Tokens.SuperIdTokenHandler.ValidateJwtToken(
        String token, ClaimsPrincipal&amp; claimsPrincipal)
        in C:\Agent1\_work\3\s\Source\SuperOffice.SuperID.Client\Tokens\SuperIdTokenHandler.cs:line 187&#xD;
    at SuperOffice.Online.Mirroring.MirroringClientService.ValidateSuperOfficeSignedToken(String token) in
        C:\Agent1\_work\3\s\Source\SuperOffice.Online.Mirroring\MirroringClientService.cs:line 137&#xD;
    at SuperOffice.Online.Mirroring.MirroringClientService.Authenticate(AuthenticateRequest request) in
        C:\Agent1\_work\3\s\Source\SuperOffice.Online.Mirroring\MirroringClientService.cs:line 20
```

Token validation is built into the NuGet package libraries but requires the public SuperOffice certificates to be [added to the certificate store][0] on the IIS server.

Alternatively, the endpoint can override `ValidateSuperOfficeSignedToken` and load the `SuperOfficeFederatedLogin.crt` certificate explicitly:

```csharp
protected override SuperIdToken ValidateSuperOfficeSignedToken(string token)
{
    var tokenHandler = new SuperIdTokenHandler();

    tokenHandler.JwtIssuerSigningCertificate = new X509Certificate2(
       HostingEnvironment.MapPath("~/App_Data/") + "SuperOfficeFederatedLogin.crt"
    );

    tokenHandler.ValidIssuer = "SuperOffice AS";
    tokenHandler.CertificateValidator = X509CertificateValidator.None;

    return tokenHandler.ValidateToken(token, TokenType.Jwt);
}
```

### Explicit validation

While extremely rare, it is possible to host a legacy mirroring endpoint by implementing the WSDL directly. Such endpoints must do everything, from validating the JWT to populating the database, on their own. We strongly discourage that approach and do not support it.

The incoming authentication request from SuperOffice contains a signed JWT token in the `SignedToken` header:

```xml
<s:Envelope
    xmlns:s="http://schemas.xmlsoap.org/soap/envelope/">
    <s:Header>
        <h:SignedToken s:mustUnderstand="1"
            xmlns:h="http://www.superoffice.com/online/mirroring/0.1">eyJhbGc...Q03yXZIsy
        </h:SignedToken>
    </s:Header>
    <s:Body>
        <AuthenticateRequest
            xmlns="http://www.superoffice.com/online/mirroring/0.1">
            <ClientState/>
        </AuthenticateRequest>
    </s:Body>
</s:Envelope>
```

The claims of interest are:

* `iss` &mdash; issuer
* `aud` &mdash; audience
* `nonce` &mdash; needed for the signed response

![JWT claims -screenshot][img4]

#### Validate the authentication request token

```csharp
using Microsoft.IdentityModel.JsonWebTokens; //Nuget Package 5.6.0

public override async Task<TokenValidationResult> ValidateAsync(string token)
{
    this.SecurityTokenHandler = new JsonWebTokenHandler();

    string issuer;
    string audience;

    var securityToken = SecurityTokenHandler.ReadJsonWebToken(token);

    if (!securityToken.TryGetPayloadValue<string>("aud", out audience))
        throw new SecurityTokenException("Unable to read ValidAudience from System User token.");

    if (!securityToken.TryGetPayloadValue<string>("iss", out issuer))
        throw new SecurityTokenException("Unable to read ValidIssuer from System User token.");

    var validationParameters = new TokenValidationParameters();
    validationParameters.ValidAudience = audience;
    validationParameters.ValidIssuer = issuer;

    var path = server.MapPath("~/App_Data/") + "SOD_SuperOfficeFederatedLogin.crt";
    validationParameters.IssuerSigningKeys = new X509SecurityKey(new X509Certificate2(path));

    var result = SecurityTokenHandler.ValidateToken(token, validationParameters);

    if (result.Exception != null || !result.IsValid)
        throw new SecurityTokenValidationException("Failed to validate the token", result.Exception);

    return result;
}
```

Read more about, and/or download, the SuperOffice public certificates on the [certificates page][0].

#### Sign the response

Using the `nonce` from the JWT and the private certificate key, build a string that contains the `nonce`, the date/time, and a signed representation of those, separated by periods:

```text
12345A558F193123458E50E741656789.YYYYMMDDHHMM.mwhpYcNBfFqEaL0uLkCwXB99sM/Wo7DOnhjRwsmwNAd2EmBM1z+Co=
```

Example response:

```xml
<s:Envelope
    xmlns:s="http://schemas.xmlsoap.org/soap/envelope/">
    <s:Body>
        <AuthenticateResponse
            xmlns="http://www.superoffice.com/online/mirroring/0.1">
            <IsSuccessful>true</IsSuccessful>
            <ErrorMessage/>
            <SignedApplicationToken>12345A558F193123458E50E741656789.202109161125.OKNE8l9Y...BREVITY...1hT3a4/Q=</SignedApplicationToken>
            <SupportedInterfaces>1</SupportedInterfaces>
            <SuperOfficeMirroringBuild>4.0.0.0/Release_1</SuperOfficeMirroringBuild>
            <ClientState/>
            <AdditionalInformationJson/>
        </AuthenticateResponse>
    </s:Body>
</s:Envelope>
```

Sign with:

```csharp
public string Sign(string nonce, string privateKey)
{
    var utcNow = DateTime.UtcNow.ToString("yyyyMMddHHmm");
    var signThis = nonce + "." + utcNow;
    using (var rsaCryptoProvider = new RSACryptoServiceProvider())
    {
        rsaCryptoProvider.FromXmlString(privateKey);
        var signature = rsaCryptoProvider.SignData(Encoding.UTF8.GetBytes(signThis), "SHA256");
        return signThis + "." + Convert.ToBase64String(signature);
    }
}
```

Once the `AuthenticateResponse` is sent back to SuperOffice and validated, the data flow cycle begins.

### Could not establish trust relationship

> Could not establish trust relationship for the SSL/TLS secure channel with authority `<website of their mirror client>`.

This indicates that the legacy SuperOffice mirroring service cannot validate the SSL certificate presented by the customer mirror client website. Common causes:

* The website uses a self-signed certificate. Install the certificate in the **Trusted Root Certification Authorities** store on the SuperOffice mirroring server.
* The website uses a certificate issued by a CA that is not trusted by the SuperOffice mirroring server. Install the CA's root certificate in the same store.
* The website's certificate has expired or is not yet valid. Renew or replace it.

<!-- reference links -->
[0]: ../../api/authentication/online/certificates/index.md
[1]: #legacy-wcf-based-mirroring
[2]: setup-guide.md
[3]: force-resync.md#recover-from-extended-downtime-longer-than-7-days
[4]: setup-guide.md#logging-and-diagnostics
[5]: https://docs.microsoft.com/en-us/dotnet/framework/wcf/feature-details/bindings-and-security
[6]: https://docs.microsoft.com/en-us/dotnet/framework/configure-apps/file-schema/wcf/transport-of-basichttpbinding
[7]: https://www.nuget.org/packages/SuperOffice.Crm.Online.Mirroring

<!-- reference images -->
[img1]: media/database-mirror-unavailable.png
[img2]: media/database-mirror-service-iis-page.png
[img3]: media/database-mirror-404.png
[img4]: media/database-mirror-authenticate-jwt-claims.png
