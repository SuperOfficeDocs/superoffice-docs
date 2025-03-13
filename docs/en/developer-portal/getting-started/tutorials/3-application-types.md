# Step 3: Understanding application types and choosing a template

Welcome to **tutorial 3** of the **SuperOffice developer onboarding series**! Now that you have access to the **SuperOffice Online Development (SOD) environment**, it’s time to understand the different **application types** and how to choose the right **template** for your integration.

This tutorial will cover:

* **Standard vs. custom applications**
* **Different types of application templates**
* **Choosing the right template for your project**

By the end of this tutorial, you’ll be ready to register your first application in the **SuperOffice developer portal**!

---

## Standard vs. custom applications

SuperOffice applications fall into two main categories:

### **Standard applications**

* These apps are **built for multiple customers**.
* They are **published in the SuperOffice App Store**.
* Customers can **install them directly** from the App Store.
* They must go through a **certification process** before deployment.

**Examples of standard apps:**

* ERP sync and quote integration
* Email marketing add-ons
* Document management systems

📌 **Reference:** [Building standard apps](apps-get-started.md)

### **Custom (one-off) applications**

* These apps are designed for **a single customer**.
* They are **not available in the App Store**.
* They must be manually installed for the **specific customer’s tenant**.
* They require **approval** before deployment.

**Examples of custom apps:**

* Internal business automation tools
* Company-specific data synchronization services

📌 **Reference:** [Application environments](app-envir.md)

---

## Available application templates

When registering a new application in the **SuperOffice developer portal**, you will choose from one of the following templates:

| **Application type** | **Use case** | **Best for** |
|---------------------|-------------|-------------|
| **Web app** | Interactive browser-based applications | Web-based integrations (OAuth 2.0) |
| **Native app** | Installed software with a local client | Desktop or mobile apps (PKCE flow) |
| **Server-to-server app** | Background services that don’t require user interaction | Automated processes, API integrations |
| **Mirroring app** | Database replication for offline access | Syncing SuperOffice data to an external database |
| **ERP sync & quote app** | Connecting SuperOffice to an ERP system | Integrating with ERP and quote services |
| **Empty app (DIY)** | A blank template for advanced users | Fully custom integrations |

Each template comes with **pre-configured API settings**, but you can **modify** them after creation.

📌 **Reference:** [Application registration](index.md)

---

## Choosing the right template

To determine the best template for your application, answer the following questions:

1️⃣ **Will your app require users to interact with it in a web browser?**

* If **yes**, choose a **web app** or **native app**.
* If **no**, consider a **server-to-server app** for automation.

2️⃣ **Will your app need access to SuperOffice without a logged-in user?**

* If **yes**, use **server-to-server app** (system-user authentication). Good for **web applications** that also need **back-channel** communications.

* If **no**, use **web app** (interactive login).

3️⃣ **Is your app syncing SuperOffice data to another system?**

* If **yes**, consider **ERP sync & quote** or **mirroring app**.

4️⃣ **Are you building a unique solution that doesn’t fit a template?**

* If **yes**, start with the **empty app (DIY)** template and configure it manually.

---

## Registering your application

Once you have selected the right application type, you are ready to **create your first app** in the **SuperOffice developer portal**.

### **Step-by-step instructions:**

1. **Go to the developer portal**

* Navigate to **[SuperOffice Developer Portal](https://dev.superoffice.com/)**
* Log in with your **developer credentials**

2. Click "Create app"**

* Go to your **partner page**
* In the **applications** section, click **create app**

3. **Choose a template**

* Select the template that **best fits your project**
* Click **next**

4. **Enter application details**

* Provide a **name** for your app
* Define one or more **redirect URLs** (if applicable)
* Set the **technical contact**

5. **Confirm and create the application**

* Click **create application**
* Your application is now registered in the **SOD environment**! 🎉

📌 **Reference:** [Registering a web app](web-app.md)
📌 **Reference:** [Registering a native app](native-app.md)

---

## Next steps

✅ **You have now chosen the right application template and registered your first app!**
In the next tutorial, we’ll walk through **configuring your application**, including setting up API endpoints, authentication, and integration points.

📌 **Next tutorial: [Tutorial 4 - Creating your first application](tutorial-4.md)**

🚀 Keep going—you’re on your way to launching your first SuperOffice integration! 🎉
