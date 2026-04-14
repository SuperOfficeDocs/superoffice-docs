---
uid: email-service-oauth-microsoft365
title: OAuth 2.0 with Microsoft 365
description: How SuperOffice Service (Onsite) connects to Microsoft 365 mailboxes using OAuth 2.0 — covering connectivity verification, IDP registration, provider detection, token lifecycle, and troubleshooting.
keywords: email, OAuth, Microsoft 365, Exchange Online, IMAP, AccessGateway, MailKit
author: Frode B
date: 14.04.2026
version: 11
content_type: howto
category: email
topic: oauth
language: en
---

# OAuth 2.0 with Microsoft 365

> **Applies to:** SuperOffice Service Onsite 10.0.3+. Not applicable for CRM Online.

How SuperOffice Service (Onsite) connects to Microsoft 365 mailboxes using OAuth 2.0 — covering connectivity verification, IDP registration as a prerequisite, provider detection, the token lifecycle, and troubleshooting.

**In this section:**

| Page | Description |
|---|---|
| [Overview](index.md) | Supported providers and authentication methods |
| OAuth 2.0 with Microsoft 365 (this page) | Full setup guide, how detection works, troubleshooting |
| [Password / basic auth](index.md) | IMAP and SMTP with password authentication |
| [cURL vs NetServer](index.md) | Which mail transport is active and how to check |

---

## Step 0 — Verify server connectivity first

Before changing any configuration in SuperOffice, verify that the server hosting SuperOffice Service can reach Microsoft's mail endpoints and that the required ports are open. Run these commands **on the SO server itself** — not from a workstation.

> **Why start here?** OAuth token exchange completes successfully even when port 993 is blocked — the setup wizard finishes without error, but mail never arrives. A cURL test takes 30 seconds and can save hours of debugging.

### Test IMAP — incoming mail (port 993)

```cmd
curl -v imaps://user%40domain.com:Password@outlook.office365.com:993/Inbox
rem  Use %40 instead of @ in the username
rem  Replace user%40domain.com and Password with real credentials
```

**Results:**

| Output | Meaning | Action |
|---|---|---|
| List of message IDs | Success — connectivity and credentials OK | Proceed to OAuth setup |
| `Failed to connect to outlook.office365.com port 993: Timed out` | Port 993 blocked outbound | Check server firewall and network path — must be resolved before OAuth will work |
| `A001 NO AUTHENTICATE failed` | Network open, credentials wrong — or Basic Auth disabled by Microsoft | Basic Auth discontinued Oct 2022. Use OAuth. |

### Test SMTP — outgoing mail (port 587)

```cmd
curl -v smtps://user%40domain.com:Password@smtp.office365.com:587
```

Success shows `235 2.7.0 Authentication successful`. A timeout means port 587 is blocked outbound.

> **Note:** OAuth for SMTP in Service mailboxes requires 10.1.5+ (PR 39769). Earlier versions send via basic auth on port 587 regardless of IMAP OAuth configuration.

---

## Requirements

All of the following must be in place. Missing any one is the most common cause of setup failures.

| Requirement | Notes |
|---|---|
| SuperOffice 10.0.3 or newer | OAuth GA release. Onsite only. |
| Unique serial number per environment | One serial = one AccessGateway registration. Test and production must have separate serials. |
| Microsoft 365 / Exchange Online | OAuth is supported for Microsoft only. Gmail and other providers use password auth. |
| MX record → Exchange Online | Required for auto-detection. Hybrid setups (Mimecast, Proofpoint, etc.) must use the "Sign in with Microsoft" button instead. |
| **Port 993 open — outbound from SO server** | Must reach Exchange Online directly, even if MX routes through a filter. Verify with cURL test above. |
| NetServer using MailKit | OAuth bypasses `reg_id=320` and always uses NetServer/MailKit. EasyMail and POP3 are not supported for OAuth mailboxes. |

---

## How it works

There are three distinct phases. Failures in each phase look different — knowing which phase you are in saves significant debugging time.

### Phase 1 — IDP registration (one-time admin prerequisite)

A Microsoft **Global Admin or App Admin** must register your Entra domain with SuperOffice once. This authorizes the SuperOffice enterprise app in your tenant and registers your SuperOffice serial number with `accessgateway.superoffice.com`. Without this step, the OAuth flow will fail with `invalid_client_id`.

**Steps:**

1. Go to `https://id.superoffice.com/identityprovider/register`
2. Select **Microsoft** as the identity provider
3. Sign in with a **Global Admin or App Admin** account
   - A regular user account will not work. Admin consent is required to add the SuperOffice enterprise app to your Entra tenant.
4. Accept the permissions when prompted (read user profile information)
5. Confirm the scope when asked
   - This affects OAuth mail only — it does not change how SuperOffice Onsite users log in.

> This uses the same federated sign-in service as CRM Online. The registration maps your domain so AccessGateway routes OAuth correctly. It needs to be done **once per Microsoft 365 domain** — not once per mailbox.

### Phase 2 — Mailbox setup and provider detection

When you add a mailbox and enter an email address, SuperOffice runs two **local** lookups to decide whether to offer OAuth. Neither contacts SuperOffice infrastructure — AccessGateway is not involved at this stage.

**Detection logic:**

1. **DNS MX lookup** — `DnsMx.GetMXRecords(domain)` via the `DnsClient` NuGet library. Plain local DNS query, no SuperOffice service involved.
2. **Thunderbird autoconfig lookup** — HTTP request to `https://autoconfig.thunderbird.net/v1.1/<domain>`. Most company domains will not be found here; it supplements the MX check.
3. **`GetOAuthContext()` decision** — pure local logic, no network call:
   - If IMAP host ends with `.office365.com` → OAuth
   - If email ends with `@superoffice.com` → OAuth (hardcoded)
   - Otherwise → `null` (password auth)

If the domain is not recognized as Microsoft (e.g. MX points to Mimecast or another filter), the `maybeMicrosoft` flag is set to `true` and the **Sign in with Microsoft** button is shown. This is the recommended path for hybrid setups.

> **AccessGateway is never involved in provider detection.** It is only contacted after OAuth is confirmed — to fetch the discovery document, register the client, and handle token exchange.

> **Hybrid mail setups (Mimecast, Proofpoint, Mailguard, etc.):** If your MX record points to a third-party filter rather than directly to `outlook.microsoft.com`, auto-detection will not recognize the domain. Use the **Sign in with Microsoft** button (10.1.5+), or the `.onmicrosoft.com` address workaround for older versions.

### Phase 3 — Ongoing mail fetch

After setup, NetServer/MailKit handles email retrieval silently using stored tokens. No user interaction is needed unless a token is invalidated — see [Token lifecycle](#token-lifecycle-and-re-authentication) below.

---

## Setting up a mailbox

### Add a new mailbox (10.1.5+)

1. Go to **System settings → E-mail → Mailboxes tab**
2. Click **New mailbox** — the "Set up e-mail account" dialog appears
3. Click **Sign in with Microsoft**
   - This bypasses MX/Thunderbird detection and goes directly to OAuth. You are redirected to Microsoft.
4. Authenticate with the **UPN that directly owns the mailbox**
   - Not an admin with delegated/shared access, and not an alias address.
   - If the UPN differs from the email address, use `user@tenant.mail.onmicrosoft.com` to trigger the redirect — you can change the address field back to the primary domain after saving.
5. You return to the Mailboxes tab. Click **OK** to save.

### Change an existing mailbox to OAuth

1. Go to **System settings → E-mail → Mailboxes tab**
2. Click the mailbox you want to change
3. Click **Change OAuth** and complete the Microsoft sign-in
4. Click **OK**

---

## Token lifecycle and re-authentication

| Token | Lifetime | Purpose |
|---|---|---|
| Access token | ~60 min | Used directly for IMAP AUTHENTICATE OAUTHBEARER on port 993 |
| Refresh token | Long-lived | NetServer silently exchanges this for a new access token. Stored encrypted in SO database. |

> **Microsoft password change = token invalidation.** When a Microsoft 365 user changes their password, Microsoft invalidates all existing refresh tokens for that account. The token stored in SuperOffice becomes immediately invalid. NetServer cannot refresh it, and IMAP on port 993 will fail. The only fix is **System settings → E-mail → mailbox → Change OAuth** and re-authenticate with the new credentials.

---

## Troubleshooting

Start with the [cURL connectivity test](#step-0--verify-server-connectivity-first) before investigating OAuth-specific issues — a blocked port 993 produces the same symptoms as a revoked token.

### Error log reference

Open the log: **System settings → E-mail → Inbox for email** (or Outbox) → click a failed item.

| Error in log | Likely cause and action |
|---|---|
| `EMail.GetEmailMessageIds Error while connecting to server` | Token invalidated (password change) — run "Change OAuth". Or port 993 blocked — verify with cURL test. |
| `AUTHENTICATE OAUTHBEARER failed` | Access token expired and refresh failed — re-auth via "Change OAuth". |
| `Failed to connect … port 993: Timed out` | Port 993 blocked outbound from SO server. Firewall issue. |
| `invalid_request / Invalid client_id` | Duplicate serial number — see below. |
| `A001 NO AUTHENTICATE failed` (cURL test) | Wrong UPN/password, or Basic Auth disabled by Microsoft. Use OAuth. |
| `An error occurred while attempting to establish an SSL or TLS connection` | Certificate issue on the SO server — see MailKit SSL FAQ. |

### Mail stops after Microsoft password change

**Symptom:** Mail was working, now stops. Service log shows `EMail.GetEmailMessageIds Error while connecting to server`.

**Cause:** The Microsoft user's password was changed or admin-reset. Microsoft invalidated the refresh token stored in SuperOffice.

**Fix:**

1. Go to **System settings → E-mail → Mailboxes**
2. Click the affected mailbox → **Change OAuth**
3. Sign in with the mailbox UPN using the new password
4. Click OK. Mail resumes on next poll.

> Use an incognito window if Microsoft auto-signs in with a cached session and returns you without a password prompt.

### "Could not log in" / credential not recognized

**Cause:** The account is not the direct owner of the mailbox. Delegated access and shared mailboxes are not supported — OAuth requires the UPN with direct ownership.

**Fix:** Use the exact UPN of the mailbox owner. If the UPN differs from the email address, use:

```
user@tenant.mail.onmicrosoft.com
```

After authentication completes and the mailbox is saved, change the address field back to the primary domain address.

To find the UPN: Microsoft 365 Admin Center → Users → Active users → click the user → Username field.

### OAuth button does nothing / no redirect to Microsoft

**Cause:** MX/Thunderbird detection did not recognize the domain as Microsoft 365 — common when MX points to a spam filter (Mimecast, Proofpoint, Mailguard).

**Fix for 10.1.5+:** Use the **Sign in with Microsoft** button — bypasses detection entirely.

**Fix for 10.1.4 and older — onmicrosoft.com workaround:**

1. In mailbox properties, temporarily change **Address** and **Username** to `user@tenant.mail.onmicrosoft.com`
2. Click **Change OAuth**. The system now recognizes it as Microsoft and redirects correctly.
3. Complete authentication.
4. Change **Address** and **Username** back to the primary domain address and save.

> You can verify what SuperOffice sees for your domain: `https://autoconfig.thunderbird.net/v1.1/yourdomain.com` — a 404 means Thunderbird detection will fail for this domain.

### Error: invalid_request / Invalid client_id

**Cause:** Two SuperOffice environments share the same serial number. AccessGateway allows one registration per serial — the second environment gets this error. Common when a test environment is cloned from production.

**Option A** — Assign a new serial number to the test environment and re-register OAuth for it.

**Option B** — Contact SuperOffice support, provide the serial number, and request deletion of the existing registration. The old environment will stop working immediately. Once confirmed, the serial can be reused for the new environment.

---

## Older versions

### Setup in 10.1.4 and older

No "Sign in with Microsoft" button exists. OAuth is triggered only when auto-detection recognizes the domain via MX or Thunderbird. If MX does not resolve to `office365.com`, use the `.onmicrosoft.com` workaround described above.

1. System settings → E-mail → New mailbox → Mailbox properties screen
2. Enter the M365 UPN in the Address field. If recognized, you are redirected to Microsoft automatically.
3. If not redirected: use `user@tenant.mail.onmicrosoft.com` to force recognition.

### Enabling OAuth via feature toggle (G9 9.2 R10 – 10.0.3)

OAuth must be enabled manually in `web.config` for these versions:

```xml
<FeatureToggles>
  <State>
    <add key="NewAuthentication" value="True" />
  </State>
</FeatureToggles>
```

A `FeatureToggles` sectionGroup must also be added to `configSections`. Contact your technical installation partner.

### cURL vs NetServer and reg_id=320

SuperOffice Service historically used cURL (libcurl) or NetServer for IMAP/SMTP, controlled by `reg_id = 320` in the `registry` table (`0` = cURL, `2` = NetServer).

When a mailbox uses OAuth 2.0, **this setting is ignored entirely**. OAuth always uses NetServer with MailKit. POP3 and EasyMail are not supported for OAuth mailboxes. For non-OAuth mailboxes, cURL remains the default.

### App Passwords (discontinued)

> Microsoft discontinued Basic Authentication for Exchange Online in **October 2022**. App Passwords no longer work. OAuth 2.0 is the only supported authentication method for Microsoft 365 mailboxes in SuperOffice Service.

