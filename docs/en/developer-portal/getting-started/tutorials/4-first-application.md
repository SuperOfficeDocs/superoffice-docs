# Step 4: Creating your first application

Welcome to **tutorial 4** of the **SuperOffice developer onboarding series**! Now that you have selected the right application template, it’s time to **create your first application** in the **SuperOffice developer portal**.

This tutorial will cover:

* **How to access the developer portal**
* **Step-by-step instructions for creating an application**
* **Understanding client IDs and redirect URLs**
* **Setting the technical contact**
* **Verifying your application details**

By the end of this tutorial, your application will be **registered** in the **SuperOffice Online Development (SOD) environment**, and you’ll be ready to configure it for development and testing.

---

## Accessing the developer portal

To create an application, you first need to log in to the **SuperOffice developer portal**.

### **Step-by-step instructions:**

1. **Go to the developer portal**

* Open your browser and navigate to [SuperOffice Developer Portal](https://dev.superoffice.com/)
* Log in with your **developer credentials**

2. **Navigate to your partner page**

* After logging in, go to the **partner page**
* This is where you manage your applications

3. **Click "Create app"**

* In the **applications** section, click **create app**

You are now ready to select an **application template** and enter your application details.

📌 **Reference:** [Registering an app](index.md)

---

## Selecting an application template

At this stage, you need to **choose a template** that matches your application’s functionality.

* Select one of the available templates:
  * **Web app** – for browser-based applications
  * **Native app** – for installed desktop or mobile applications
  * **Server-to-server app** – for background automation without user interaction
  * **Mirroring app** – for database synchronization
  * **ERP sync & quote app** – for ERP system integration
  * **Empty app (DIY)** – for fully custom integrations

* Click **next** to proceed to application details

📌 **Reference:** [Understanding application types](index.md)

---

## Entering application details

Now, you need to **define the basic settings** for your application.

### **Step-by-step instructions:**

1. **Enter a unique application name**

    * Choose a clear and descriptive name
    * Example: *SuperOffice Sales Dashboard*

2. **Add redirect URLs (if required)**

    * Some applications, like **web apps and native apps**, require **redirect URLs**
    * Redirect URLs handle authentication and authorization flows

        Example format:

        ```url
        https://devnet-tools.superoffice.com/openid/callback
        ```

3. **Set the technical contact**

    * The technical contact is the **developer responsible** for maintaining the application
    * Enter their **name and email address**

4. **Confirm application settings**

    * Review all entered details
    * Click **create application**

📌 **Reference:** [Registering a web app](web-app.md)
📌 **Reference:** [Registering a native app](native-app.md)

---

## Understanding client IDs and application credentials

Once your application is created, it is assigned a **unique client ID**. This client ID is **essential** for authentication and API communication.

### **Where to find your client ID**

* After creating the application, go to the **application overview page**
* Locate the **client ID** under the **configuration section**
* The client ID is required for **OAuth authentication and API calls**

📌 **Reference:** [Finding your client ID](index.md)

---

## Verifying your application details

To ensure your application is correctly registered, follow these steps:

1. **Go to the applications section in the developer portal**
2. **Select your newly created application**
3. **Check the following:**
    * Is the **application name correct**?
    * Are the **redirect URLs properly set**?
    * Is the **technical contact information accurate**?

If anything needs updating, you can modify the configuration in the developer portal.

---

## Next steps

✅ **Your application is now registered in the SOD environment!**

In the next tutorial, we’ll walk through **configuring your application**, including setting up API endpoints, authentication, and integration points.

📌 **Next tutorial: [Tutorial 5 - Configuring your application](tutorial-5.md)**

🚀 Keep going—you’re making great progress in developing your SuperOffice integration! 🎉