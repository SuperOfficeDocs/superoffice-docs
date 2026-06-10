---
uid: help-sv-user-add
title: Lägg till användare
description: I den här guiden förklarar vi hur du lägger till en ny användare i SuperOffice CRM.
keywords: lägg till användare, medarbetare
author: digitaldiina
date: 06.10.2026
version: 12.0
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
index: true
tier: starter
redirect_from: /sv/admin/user-management/learn/add-associate
language: sv
---

# Lägga till användare

När din SuperOffice CRM-lösning har konfigurerats och anpassats är det dags att ge användarna tillgång. I den här guiden förklarar vi hur du lägger till en användare i taget.

Administratörerna ansvarar för att ge varje ny användare ett användarnamn, ett lösenord och en primärgrupp. I **SuperOffice CRM Online** inkluderar detta även val av en användarplan. I **SuperOffice CRM Suite**-abonnemang gäller företagets plan för alla användare — aktivera bara alternativet **Kan logga in** för att ge åtkomst.

> [!NOTE]
> Om du lämnade information om dina användare när du beställde SuperOffice CRM kan dessa användare redan finnas i systemet och ha fått inloggningsuppgifter via e-post. Kontrollera fönstret **Användare** innan du lägger till någon manuellt.

## Steg

1. Öppna fönstret Användare.
1. Välj fliken **Medarbetare**.
1. Klicka på knappen **Lägg till** under listan.
1. Ange namnet och e-postadressen för den nya användaren på kortets övre del.
1. Om mer än ett ägarföretag är tillgängligt i din SuperOffice-tenant kan du välja ägaren under fältet **E-post**.
1. Ange relevanta uppgifter på flikarna **Detaljer** och **Licenser**.

    ![Create user details -screenshot][img7]

1. Klicka på **Spara**. Namnet på den nya användaren visas nu i listan.

    * **SuperOffice CRM Online:** Om aktiva användare behöver en annan användarplan kan du [tilldela användarplaner][4] under Inställningar och underhåll.
    * **SuperOffice CRM Suite:** Hantera användaråtkomst genom att aktivera eller inaktivera alternativet **Kan logga in**. Företagets plan bestämmer vilka funktioner alla användare kan komma åt. Se [CRM Suite-planer][5].

## <a id="fields"></a>Nyckelfält förklarade

<!-- markdownlint-disable-file MD051 -->
### [Fliken Detaljer](#tab/details)

På fliken **Detaljer** finns följande alternativ:

* **Användar-ID:** I fältet **Användar-ID** redigerar du det föreslagna ID:t för användaren (om du inte vill använda det automatiskt genererade ID:t). Du kan inte ange ett användar-ID som redan finns i databasen. Det finns inga begränsningar på vilka tecken som kan användas för ett användar-ID.

    > [!NOTE]
    > Ett användar-ID bör inte innehålla för många tecken eftersom det visas i ID-kolumnerna i SuperOffice CRM och utrymmet i dessa kolumner kan vara begränsat.

* **Smeknamn:** Smeknamnet är det namn som visas för andra användare av SuperOffice. Det används endast för SuperOffice Service-användare. Du kan redigera det föreslagna smeknamnet för användaren (om du inte vill använda det automatiskt genererade namnet).

* **Autentisering:** Om det finns flera autentiseringsmetoder kan du välja en autentiseringsmetod här.

* **Användarnamn:** Ange SuperOffice-användarnamnet. Detta bör vara samma namn som i din identitetsleverantörs system (om du använder Office 365 eller Gmail för autentisering). När du använder SuperOffice för autentisering fyller du bara i din e-postadress. Kontrollera att e-postadressen stämmer eftersom den kommer att användas för kontobekräftelse.

* **Roll:** I listrutan **Roll** väljer du vilken [roll][3] användaren ska ha. Rollen avgör användarens behörighet till olika data och funktioner. Du kan inte ändra din egen roll.

* **Användarplan:** Välj relevant användarplan för användaren. Det här styr vilka SuperOffice-funktioner användaren kan komma åt. (Endast SuperOffice CRM Online. I SuperOffice CRM Suite-abonnemang gäller företagets plan för alla användare.)

* **Tidigare anställd:** Om en användare inte längre ska ha tillgång till SuperOffice väljer du det här alternativet om du vill ta bort användarens användarplan och inloggningsrättigheter.

* **Primärgrupp:** I listrutan **Primärgrupp** väljer du ett av de fördefinierade alternativen för grupptillhörighet. Grupperna definieras i fönstret **Listor**. Användaren får tillgång till data som ägs av andra användare i samma primärgrupp. Behörigheterna (till exempel behörighet att skriva och ta bort data) definieras i den [roll][3] användaren tillhör. Under [Synlighet][2] finns mer information om hur du delar data med din primärgrupp.

* **Andra grupper:** Klicka i fältet **Andra grupper** och välj vilka andra grupper användaren ska tillhöra. Om listan innehåller många grupper börjar du skriva ett gruppnamn i sökfältet för att filtrera listan.

* **Service-kategorier:** De här kategorierna används för att ge användarna åtkomst till specifika ärendekategorier.

* **Service-kategorier från användargrupper:** Visar de kategorier som användaren får genom att vara med i en användargrupp.

#### Exempel

Joe Johnson jobbar på säljavdelningen på ett stort företag. Primärgruppen "Försäljning" har valts vilket innebär att Joe har åtkomstbehörighet till data som skapas av användare på säljavdelningen. Primärgruppens åtkomstbehörigheter definieras i den roll Joe tillhör. Rollen avgör om Joe kan redigera eller ta bort data som skapas av andra användare på säljavdelningen (se [Definiera databehörigheter för en roll][8]).

Joe behöver också begränsad åtkomst till dokument från marknadsavdelningen och utvecklingsavdelningen. Dessa två avdelningar läggs till under **Andra grupper**. Rollen som Joe tillhör har bara läsbehörighet för dessa data.

### [Fliken Licenser](#tab/license)

På fliken **Licenser** kan du välja ytterligare licenser.

**Konfidentiella aktiviteter:** aktiverar listan **Synlig för** för händelser, dokument och försäljningar så att [posterna bara är synliga för][2] användaren, användarens primärgrupp eller alla.

***

## Video: Lägg till en ny användare i SuperOffice CRM

Se den här demon för att se hur du lägger till en ny användare i SuperOffice CRM.
(Den här videon visar en tidigare version av SuperOffice, så designen kan se annorlunda ut. Stegen är desamma.)

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/oLlfTrCAqCU]

(filmens längd: 1:46)

## Felsökning

### En nyskapad användare kan inte logga in på SuperOffice

Det finns två vanliga situationer när en ny användare inte kan logga in:

* Användarnamnet är inte en e-postadress, eller e-postadressen är inte giltig
* Den nya användarens konto är inte aktiverat

1. [!include[Klicka på Användare](includes/goto-users.md)]

1. Välj den användare som inte kan logga in i listan över användare.

1. Kontrollera att användaren har angett en giltig e-postadress, eftersom aktiveringsmeddelandet skickas till den adressen.

    ![Verifiera användarens e-postadress -screenshot][img2]

1. Kontrollera att användaren har fått aktiveringsmeddelandet och att aktiveringsländken klickades inom 48 timmar.

    ![Aktiveringsmeddelande -screenshot][img3]

    Om du vill skicka välkomstmeddelandet igen går du till **Inställningar och underhåll** > **Användare**, väljer din användare, klickar på knappen **Uppgift** och väljer **Skicka välkomstmeddelande**.

1. Kontrollera att användaren har följt [instruktionerna för att logga in på SuperOffice CRM][7].

## Relaterat innhåll

* [Redigera användare/medarbetare][6]
* [Onsite-användarhantering][10]

<!-- Referenced links -->

[2]: index.md#visible
[3]: role/index.md
[4]: ../license/user-plans.md#change
[5]: ../license/crm-suite.md
[6]: update-user.md
[7]: ../../learn/getting-started/login.md
[8]: role/set-data-rights-for-role.md
[10]: https://help.superoffice.com/docs/11/sv/admin/user-management/add-associate.html

<!-- Referenced images -->
[img2]: ../../../media/loc/en/admin/filled-in-email.png
[img3]: ../../../media/loc/en/admin/activation-email.png
[img7]: ../../../media/loc/en/admin/selected-user-plan.png
