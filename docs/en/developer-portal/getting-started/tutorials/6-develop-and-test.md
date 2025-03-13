# Step 6: Developing and testing your application

Welcome to **tutorial 6** of the **SuperOffice developer onboarding series**! Now that your application is registered and configured, it’s time to begin **developing and testing** to ensure it works as expected before moving to production.

This tutorial will cover:

* **Setting up your development environment**  
* **Using authentication for API requests**  
* **Making API calls and handling responses**  
* **Debugging and troubleshooting common issues**  
* **Testing in the SOD environment**  

By the end of this tutorial, you will have a **fully functioning application** that can interact with SuperOffice CRM Online.  

---

## Setting up your development environment  

Before writing code, ensure that your development environment is properly set up.  

### **Required tools**  

* **Integrated development environment (IDE)**  
  * Examples: Visual Studio Code, JetBrains Rider, or any preferred IDE  
* **REST API testing tool**  
  * Postman or cURL for testing API calls  
* **SuperOffice developer portal access**  
  * Required for retrieving client credentials and API keys  

📌 **Reference:** [SuperOffice APIs and authentication](what-api-to-use.md)  

### **Retrieving application credentials**  

1. **Log in to the SuperOffice developer portal**  
2. **Navigate to your application page**  
3. **Locate the client ID and secret**  
4. **Save these credentials securely** for API authentication  

📌 **Reference:** [Finding your client ID](index.md)  

---

## Using authentication for API requests  

SuperOffice CRM Online uses **OAuth 2.0** and **OpenID Connect** for authentication.  

### **For interactive applications (web and native apps)**  

* Redirect users to the **SuperOffice login page** for authentication  
* Receive an **ID token** and **access token** upon successful login  
* Use the **access token** to make API calls  

Example of obtaining an access token using Postman:  

```
POST https://sod.superoffice.com/login/common/oauth/tokens  
Content-Type: application/x-www-form-urlencoded  

client_id=your-client-id  
&client_secret=your-client-secret  
&grant_type=authorization_code  
&redirect_uri=https://yourapp.com/callback  
&code=authorization_code_received
```

### **For non-interactive applications (server-to-server apps)**  

* Use **system user authentication**  
* Exchange the **system user token** for an **access token**  

📌 **Reference:** [User authentication](user-contexts.md)  

---

## Making API calls and handling responses  

Once authenticated, your application can interact with the SuperOffice API.  

### **Example: Retrieving a contact using REST API**  

```http
GET https://sod.superoffice.com/api/v1/Contact/123
Authorization: Bearer your-access-token
Accept: application/json
```

### **Example: Creating a new company using REST API**  

```http
POST https://sod.superoffice.com/api/v1/Contact
Authorization: Bearer your-access-token
Content-Type: application/json

{
  "name": "New Company",
  "category": "Customer"
}
```

### **Handling API responses**  

* **200 OK** – Request was successful  
* **201 Created** – New resource was successfully created  
* **400 Bad Request** – Invalid request format or missing parameters  
* **401 Unauthorized** – Invalid or expired access token  
* **500 Internal Server Error** – Unexpected error on the server  

📌 **Reference:** [API documentation](what-api-to-use.md)  

---

## Debugging and troubleshooting common issues  

### **1. Authentication errors (401 Unauthorized)**  

* Verify that you are using a **valid access token**  
* Ensure the token has not **expired**  
* Check that your **client ID and secret** are correct  

### **2. API request errors (400 Bad Request, 500 Internal Server Error)**  

* Review the **API documentation** to ensure correct parameters  
* Use **Postman** or **cURL** to test raw API calls  
* Check **SuperOffice logs** for error messages  

### **3. Redirect issues in authentication flows**  

* Ensure that your **redirect URL is correctly registered** in the developer portal  
* Use a **localhost URL** for local testing, if necessary  

📌 **Reference:** [Debugging authentication issues](helper-application.md)  

---

## Testing in the SOD environment  

The **SuperOffice Online Development (SOD) environment** allows you to safely test your application before deployment.  

### **How to test your application**  

1. **Deploy your application to a test server**  
2. **Simulate user interactions** and verify authentication flows  
3. **Test API calls** using Postman or automated scripts  
4. **Check logs for errors** and troubleshoot as needed  

### **Using the messaging center for support**  

If you encounter issues that cannot be resolved, use the **SuperOffice messaging center** to track support tickets.  

📌 **Reference:** [Using the messaging center](message-center.md)  

---

## Next steps  

✅ **Your application is now functional and tested in the SOD environment!**  
In the next tutorial, we’ll walk through **requesting to publish your application**, including the approval process and preparing for production deployment.  

📌 **Next tutorial: [Tutorial 7 - Requesting to publish your application](tutorial-7.md)**  npm

🚀 Keep going—your SuperOffice integration is almost ready for deployment! 🎉
