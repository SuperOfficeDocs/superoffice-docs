---
title: Creating Your First Application and Connecting to SuperOffice Web Services
uid: quickstart-first-app-and-connect-to-web-services
description: Quickstart to build first online application
author: Tony Yates
date: 03.04.2024
keywords: online, development
content_type: tutorial
deployment: online
platform: web
---

# Create your first application and connect to SuperOffice web services

This guide walks you through creating a new application in SuperOffice Online and using it to authenticate, obtain tokens, and finally make an API call to retrieve data.

---

## Step 1. Create a new application

1. **Navigate to your organization page:**

   When logged in, the default landing page is the home page. This is where widgets can be [added to your home dashboard][0]. In order to create a new application, you must first navigate to your organization page. If you only belong to one organization, you will see the name of the organization at the top of the page in the navigation, between Home and Docs. If you are a member of more than one organization, click the navigation item `Partners`, then select the organization that should own the new application.

   * When the organization overview page is displayed.
   * Notice the app store listing, settings, and your list of existing applications on the right.

2. **Click "Create application":**

   * In the `Applications` area, press the big green **Create Application** button to start the create app wizard.

3. **Select the application template:**

   * Choose from the available templates. For maximum flexibility, select the **Server to Server** template.

     *This option supports both interactive user authentication and back-channel communication via a [`system user flow`][2] (similar to the client credentials flow).*

4. **Select the application type:**

   * You have two choices:
     * **Custom application:** Private, one-off integrations for a single customer.
     * **Standard application:** Applications that will be published in the SuperOffice Online app store.
   * In this tutorial, select **Custom Application**.
   * **Note:** A warning may appear stating that this application type requires a Development Tools license on the tenant you plan to integrate with. This is included in all development tenants, but you may need to purchase it for production tenants.

5. **Click next to proceed.**

---

## Step 2. Configure your application

1. **Enter application name:**

   * For example, name your application **"My Awesome Demo App"** (or any name you prefer).

2. **Specify redirect URLs:**

   * These URLs are required for OAUTH 2.0 and OpenID Connect.
   * They are used after an interactive user authenticates so that the identity provider can send the ID token, access token, and refresh token to your backend.
   * If you don’t have your own backend, you can use the default redirect URL provided (e.g., default tools website `https://devnet-tools.superoffice.com/openid/callback`).

3. **Technical contact:**

   * The system will suggest the logged in user as the default technical contact. You can keep the default or search for another contact.
   * Click **Next** once satisfied.

4. **Create the application:**

   * After reviewing the provided details, click **Create Application**.
   * You are now taken to the **Application Configuration Page**.

---

## Step 3. Application configuration & obtaining credentials

1. **Overview of the configuration page:**

   * On the left, you can view the Overview page (which lists default settings and installed tenants).
   * On the settings page, you can change contact information or error/uninstallation URLs if needed.

2. **Obtain OAUTH/OpenID Connect credentials:**

   * In the configuration area, locate your **Client ID** and *create* a **Client Secret**.

      > [!NOTE]
      > Different client IDs and secrets can be configured for different environments.
      >
      > * **Development (SOD)**
      > * **Stage**
      > * **Production**

   * By default, a client ID is assigned for each environment.
   * If desired, you can toggle the option to use one client ID for all environments; however, here we’ll keep three unique IDs.

3. **Configure client secrets per environment:**

   * Choose the option to **Configure per environment** so you have a unique client secret for each.
   * For the development (SOD) environment, click **Add** to generate a client secret.
   * **Important:** Copy and securely save the client secret immediately because it will not be visible after you save the configuration.

4. **Add a certificate for back-channel communication:**

   * To enable back-channel communication ([System User flow][2]), add a new certificate.
   * This certificate is essentially an RSA XML key.
   * Generate the certificate, then save the private key on your machine (only the public key is stored in SuperOffice).

5. **Save your settings:**

   * Once the client id, secret, and certificate is configured, save the settings.
   * You’ll now see your public key listed for the certificate, and your client secret remains hidden.

By this time, you should have a local file created that contains the following information:

```plaintext
App Name: My Awesome Demo App
Client ID: 1234567890abcdef1234567890abcdef
Client Secret: 1234567890abcdef1234567890abcdef
Certificate: 
<RSAKeyValue>
  Remainder removed for brevity
</RSAKeyValue>
```

* The `Client ID` and `Client Secret` are used for OAUTH or OpenIDConnect.
* The `Certificate` is used for secure [back-channel communication][2].

---

## Step 4. Testing the application with the authentication flow

1. **Return to the Overview page:**

   * Verify that no tenants have yet authorized this application.

2. **Navigate to the Allowed redirect URL:**

   * Click on the default redirect URL (e.g., [DevNet-Tools](https://devnet-tools.superoffice.com)) to initiate the authentication flow.

      ```plaintext
      https://devnet-tools.superoffice.com
      ```
   * This URL is where the identity provider will redirect after authentication.
   * If you have your own backend, you can use that URL instead.

3. **Sign In using your client id and secret:**

   * On the DevNet-Tools landing page, click the **Sign In** button.
   * Select the environment (development by default) and enter your **Client ID** and **Client Secret**.
   * This begins the OAUTH authentication code flow.

4. **Authenticate with SuperID:**

   * You will be directed to the SuperID identity provider login page.
   * Log in with your credentials.
   * If you have multiple tenants, you will be prompted to choose which tenant to sign into. Select the desired tenant.
   * Approve the consent dialogue to authorize your application.

5. **Receive tokens via redirect:**

   * After approval, the identity provider sends a POST request containing:
     * **ID Token** (which includes claims like the system user token)
     * **Access Token**
     * **Refresh Token**
   * The redirect page validates the ID token and displays key claims (such as your context identifier, email, and system user token).

6. Update the local file with the following information:

   ```plaintext
   webapi_url: https://sod2.superoffice.com/api/v1/Cust12345
   System User token: My Awesome Demo App-1234567890abcdef
   ```

   * The `webapi_url` is the base URL for making API calls to SuperOffice Web Services.
   * The `System User token` is used for back-channel communication.

---

## Step 5. Making an API call to SuperOffice web services

1. **Copy the access token:**

   * From the DevNet-Tools account page, copy your access token for use in API calls.

2. **Prepare your API request:**

   * Open your preferred HTTP client (for example, using Visual Studio Code with the `REST Client` extension).
   * Paste the access token into the **Authorization** header.
   * Specify the tenant ID (e.g., Cust12345) in your request.
   * Use the appropriate subdomain as indicated in the token claims (for example, `sod2` rather than the default subdomain).

   ```plaintext
   GET https://sod2.superoffice.com/Cust12345/api/v1/contact/3 HTTP/1.1
   Authorization: Bearer 8A:Cust12345.AQeN6...removed for brevity
   Accept: application/json
   ```

3. **Test the API request:**

   * Make a GET request to retrieve a contact by ID (e.g., contact ID 3).
   * If you use the wrong subdomain, you may receive a 421 status code. Update the subdomain to match the one provided in the `webapi_url` claim and try again.
   * Once corrected, you should receive a valid response with details for the requested contact.

4. **Experiment with additional requests:**

   * Change the contact ID in your API call to test with different entities (e.g., contact ID 4) to see varied responses from SuperOffice.

   Check out the [RESTful HTTP Queries][1] library for more API examples to SuperOffice Web Services.

## Summary

In this tutorial, you learned how to:

* **Create a custom server-to-server application** in SuperOffice Developer Portal.
* **Configure the application** by setting its name, redirect URLs, technical contact, and obtaining OAUTH settings in the configuration.
* **Add a certificate** for secure back-channel communications.
* **Test the authentication flow** using the provided client ID and client secret.
* **Make an API call** using the access token to retrieve data from SuperOffice Web Services.

By following these steps, you now have a basic but complete understanding of how to integrate with SuperOffice Web Services and set up the foundation for further development.

<!-- links and media reference -->

[0]: ../widgets/index.md
[1]: https://github.com/SuperOffice/RESTful-HTTP-Queries
[2]: ../../api/authentication/online/auth-application/index.md
