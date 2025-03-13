# Step 5: Configuring your application

Welcome to **tutorial 5** of the **SuperOffice developer onboarding series**! Now that you have successfully registered your application in the **SuperOffice developer portal**, it's time to configure it for development and testing.

This tutorial will cover:

* **Understanding application configuration settings**
* **Setting up API endpoints and authentication**
* **Managing environment-specific dependencies**
* **Adding certificates and security settings**
* **Verifying and saving your configuration**

By the end of this tutorial, your application will be properly configured and ready for development in the **SuperOffice Online Development (SOD) environment**.

---

## Understanding application configuration settings

Once you have created your application, you need to configure its **integration points**, **authentication settings**, and **environment dependencies**.

### **Where to find your application configuration**

1. **Log in to the SuperOffice developer portal**
2. **Go to your partner page**
3. **Select your application from the applications list**
4. **Navigate to the "Configuration" tab**

📌 **Reference:** [Managing application configuration](index.md)

---

## Setting up API endpoints and authentication

Depending on your application type, you may need to configure **API endpoints** to allow communication between your app and SuperOffice CRM Online.

### **Configuring API endpoints**

1. **Go to the configuration section of your application**
2. **Enable the necessary API endpoints**
   * **Web API** – for RESTful communication
   * **Services88** – for SOAP-based integrations
   * **Webhook agent** – for event-based integrations

3. **Enter the endpoint URLs (if required)**
   * Some application templates, like ERP sync and mirroring apps, require a service endpoint
   * Example format:

     ```url
     https://yourapp.com/api/superoffice
     ```

📌 **Reference:** [What API to use](what-api-to-use.md)

### **Setting up authentication**

SuperOffice CRM Online uses **OAuth 2.0** and **OpenID Connect** for authentication.

* **For interactive applications (web and native apps)**:
  * Use **SuperID authentication** with OpenID Connect
  * Redirect users to the **SuperOffice login page**

* **For non-interactive applications (server-to-server apps)**:
  * Use **system user authentication** with an access token
  * Store and refresh the token securely

📌 **Reference:** [User authentication](user-contexts.md)

---

## Managing environment-specific dependencies

SuperOffice has **three main environments**:

* **SOD (sandbox environment)** – for development and testing
* **Stage (pre-production)** – for validation before going live
* **Production (live environment)** – for real customers

Each environment requires its own **configuration settings** to ensure smooth transitions from development to production.

### **Configuring environment-specific settings**

1. **Set up client ID and secret**
   * Go to the "Configuration" section in your application settings
   * Ensure you are using the **correct client ID** for each environment

2. **Configure redirect URLs** (if applicable)
   * Example formats:

     ```url
     https://sod.yourapp.com/callback
     https://stage.yourapp.com/callback
     https://yourapp.com/callback
     ```

3. **Enable logging and error reporting**
   * Set up logs to track API requests and responses

📌 **Reference:** [Application environments](app-envir.md)

---

## Adding certificates and security settings

Some applications require **certificates** for secure communication with SuperOffice CRM Online.

### **How to add a certificate**

1. **Navigate to your application’s configuration page**
2. **Locate the "Certificates" section**
3. **Upload or paste the private key (PrivateKey.txt)**
4. **Save and confirm the certificate settings**

📌 **Reference:** [Adding a certificate](versioning.md)

---

## Verifying and saving your configuration

Once all configurations are set, verify the following:

* **Is the client ID correctly assigned?**
* **Are API endpoints properly configured?**
* **Is authentication correctly implemented?**
* **Are environment-specific settings accurate?**

### **Saving your configuration**

1. **Click the "Save settings" button**
2. **Review the changes in the version history**
3. **Test your configuration in the SOD environment**

📌 **Reference:** [Versioning and configuration changes](versioning.md)

---

## Next steps

✅ **Your application is now fully configured!**
In the next tutorial, we’ll walk through **developing and testing your application**, including API calls, debugging, and troubleshooting.

📌 **Next tutorial: [Tutorial 6 - Developing and testing your application](tutorial-6.md)**

🚀 Keep going—you’re making great progress in building your SuperOffice integration! 🎉
