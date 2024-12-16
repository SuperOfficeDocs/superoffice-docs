
# Normal User vs. System User

Which User Should I Use for SuperOffice API Integration? Using a normal user versus a System User for API integrations against an online SuperOffice (SO) installation comes with trade-offs. Here's a breakdown of the key points to consider:

## Normal User

A normal user is any user account created in SuperOffice with login rights, specific roles and permissions. When using a normal user for API integrations, the API actions are restricted to what the user account is authorized to do in the GUI. This can help mitigate security risks by limiting access only to the required operations.

### Pros

1. **Granular Permissions**
    * A normal user has explicitly defined roles and rights. This ensures API actions are restricted to what the user account is authorized to do in the GUI.
    * This can help mitigate security risks by limiting access only to the required operations.

2. **Auditability**
    * Actions performed via the API will appear in logs as being executed by the specific user, enabling better traceability.

3. **Seamless Authentication**
    * Normal users integrate naturally with existing authentication mechanisms and licensing models.

4. **Impersonation via the User Token**
    * While a normal user cannot impersonate other users, this can sometimes be advantageous to maintain clearer accountability.

### Cons

1. **License Cost**
    * Each normal user requires a valid SuperOffice license. For a dedicated integration account, this incurs additional costs.

2. **Limited API Scope**
   * A normal user is constrained by their assigned roles. For example:
     * They cannot access system*wide resources unless explicitly granted.
     * They might lack certain permissions required for global administrative or cross-user operations.

---

## System User

A System User is generally used in a background process where no user interactivity exists, sometimes referred to as back-channel communications. This is a dedicated account used for administrative or integration purposes. It provides unrestricted access to the SuperOffice API, regardless of roles or permissions.

### Pros

1. **Unlimited Access**
   * System Users are designed for administrative and integration purposes, providing unrestricted API access regardless of roles.
   * They can access all users' data and perform cross-user operations without requiring additional permissions.

2. **Cost Efficiency**:
   * A System User does not consume a traditional SuperOffice user license, making it a more economical choice for dedicated integrations (Requires Development Tools license).

### Cons

1. **Security Risk**:
   * Unrestricted access and the ability to impersonate other users can pose a significant security risk if the System User credentials are compromised.
   * System Users lack granular access controls, making it harder to limit what the API can do.

2. **Lack of Accountability**
   * Actions performed via a System User are harder to trace back to specific users or processes, as the logs will only show the System User.

3. **Lack of Impersonation Capability**:
   * System Users can not impersonation and perform actions on behalf of any other user.

---

## Use Cases: When to Prefer One Over the Other

This section outlines common scenarios where one user type might be more suitable than the other.

### Use Cases for a Normal User

* **Single-User Operations**: When the API integration only needs to interact with data belonging to a specific user or perform actions within limited rights.
* **Auditability**: When detailed logs tying actions to specific accounts are critical.
* **Security-Conscious Integrations**: When it's essential to minimize risk by granting only the permissions necessary for the integration.

### Use Cases for a System User

* **Administrative or Multi-User Scenarios**: When the integration must access data across all users or perform global operations (e.g., syncing data to/from an external CRM).
* **Cost Optimization**: When a dedicated integration account is needed without consuming a license (requires Development Tools license).

---

## **Summary of Pros and Cons**

| Feature                   | Normal User                    | System User                   |
|---------------------------|--------------------------------|-------------------------------|
| **License Required**      | Yes                            | Yes (Development Tools)       |
| **Granular Permissions**  | Yes                            | No (Full Access)              |
| **Cross-User Access**     | Limited                        | Yes                           |
| **Impersonation**         | Yes (with refresh_token)       | No                            |
| **Auditability**          | High                           | Low                           |
| **Security Risk**         | Low                            | Higher                        |

In summary, the choice depends on your integration's specific requirements. If cost and cross-user access are priorities, a System User is the better choice. For scenarios requiring more controlled and auditable access, a normal user is preferable.

As a side note about impersonation, if you need to perform actions on behalf of other users, you can use a Users' refresh token to obtain a new access token and perform actions on behalf of that user. This can help bridge the gap between the two user types when necessary, but requires the implementation securely save the users refresh token and applications client_secret for the exchange.

I hope this provides more context on which user type to use for your SuperOffice API integration.
