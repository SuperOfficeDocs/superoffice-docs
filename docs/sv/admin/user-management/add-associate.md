---
uid: help-sv-user-add
title: Lägg till användare
description: I den här guiden förklarar vi hur du lägger till en ny användare i SuperOffice CRM.
author: SuperOffice RnD
date: 02.21.2023
keywords: user, medarbetare
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Lägga till användare

När din SuperOffice CRM-lösning har konfigurerats och anpassats är det dags att ge användarna tillgång till deras CRM-lösning.

Administratörerna ansvarar för att ge nya användare en användarplan, ett användarnamn, ett lösenord och den användargrupp användaren tillhör. Du kan lägga till användare i SuperOffice CRM under Inställningar och underhåll.

> [!NOTE]
> Om du har lämnade information om dina användare när du beställde SuperOffice CRM behöver du inte lägga till användare. Användarna ska ha fått inloggningsuppgifter från SuperOffice via e-post. Kontrollera om användarna ligger inne i systemet på menyn Användare under Inställningar och underhåll.
>
> Den här proceduren beskriver hur du lägger till en användare i taget. Om du vill lägga till flera användare kan du se [Importera användare][1].

## Steg

1. Öppna fönstret Användare.
2. Välj fliken **Medarbetare**.
3. Klicka på knappen **Lägg till** under listan.
4. Ange namnet och e-postadressen för den nya användaren på kortets övre del.
5. Om mer än ett ägarföretag är tillgängligt i din SuperOffice-installation kan du välja det under fältet **E-post**.
6. Ange relevanta uppgifter på flikarna **Detaljer** och **Licenser**.

    ![Create user details -screenshot][img7]

7. Klicka på **Spara**. Namnet på den nya användaren visas nu i listan.

    * Om aktiva användare behöver en annan användarplan kan du [tilldela användarplaner][4] under Inställningar och underhåll.

    * I den nedre delen av användarkortet kan du aktivera eller inaktivera inloggningsbehörigheterna för den valda användaren genom att klicka på knappen **Kan logga in**. Alternativet aktiveras som standard när du väljer en användarplan för användaren.

## <a id="fields"></a>Nyckelfält förklarade

<!-- markdownlint-disable-file MD051 -->
### [Fliken Detaljer](#tab/details)

På fliken **Detaljer** finns följande alternativ:

* **Användar-ID**: I fältet **Användar-ID** redigerar du det föreslagna ID:t för användaren (om du inte vill använda det automatiskt genererade ID:t). Du kan inte ange ett användar-ID som redan finns i databasen. Det finns inga begränsningar på vilka tecken som kan användas för ett användar-ID.

    > [!NOTE]
    > Ett användar-ID bör inte innehålla för många tecken eftersom det visas i ID-kolumnerna i SuperOffice CRM och utrymmet i dessa kolumner kan vara begränsat.

* **Smeknamn**: Smeknamnet är det namn som visas för andra användare av SuperOffice. Det används endast för SuperOffice Service-användare. Du kan redigera det föreslagna smeknamnet för användaren (om du inte vill använda det automatiskt genererade namnet).

* **Autentisering**: Om det finns flera autentiseringsmetoder kan du välja en autentiseringsmetod här.

* **Användarnamn**: Ange SuperOffice-användarnamnet. Detta bör vara samma namn som i din identitetsleverantörs system (om du använder Office 365 eller Gmail för autentisering). När du använder SuperOffice för autentisering fyller du bara i din e-postadress. Kontrollera att e-postadressen stämmer eftersom den kommer att användas för kontobekräftelse.

* **Roll**: I listrutan **Roll** väljer du vilken [roll][3] användaren ska ha. Rollen avgör användarens behörighet till olika data och funktioner. Du kan inte ändra din egen roll.

* **Användarplan**: Välj relevant användarplan för användaren. Det här styr vilka SuperOffice-funktioner användaren kan komma åt.

* **Tidigare anställd**: Om en användare inte längre ska ha tillgång till SuperOffice väljer du det här alternativet om du vill ta bort användarens användarplan och inloggningsrättigheter.

* **Primärgrupp**: I listrutan **Primärgrupp** väljer du ett av de fördefinierade alternativen för grupptillhörighet. Grupperna definieras i fönstret **Listor**. Användaren får tillgång till data som ägs av andra användare i samma primärgrupp. Behörigheterna (till exempel behörighet att skriva och ta bort data) definieras i den [roll][3] användaren tillhör. Under [Synlighet][2] finns mer information om hur du delar data med din primärgrupp.

* **Andra grupper**: Klicka i fältet **Andra grupper** och välj vilka andra grupper användaren ska tillhöra. Om listan innehåller många grupper börjar du skriva ett gruppnamn i sökfältet för att filtrera listan.

* **Service-kategorier**: De här kategorierna används för att ge användarna åtkomst till specifika ärendekategorier.

* **Service-kategorier från användargrupper**: Visar de kategorier som användaren får genom att vara med i en användargrupp.

#### Exempel

[!include[Example](includes/example-grouping.md)]

### [Fliken Licenser](#tab/license)

På fliken **Licenser** kan du välja fler licenser utöver de licenser som definieras av den valda användarplanen.

**Konfidentiella aktiviteter**: aktiverar listan **Synlig för** för händelser, dokument och försäljningar så att [posterna bara är synliga för][2] användaren, användarens primärgrupp eller alla.

***

## Video: Lägg till en ny användare i SuperOffice CRM

Se den här demon för att se hur du lägger till en ny användare i SuperOffice CRM.
(Den här videon visar en tidigare version av SuperOffice, så designen kan se annorlunda ut. Stegen är desamma.)

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/oLlfTrCAqCU]

(filmens längd: 1:46)

## Relaterat innhåll

* [Lägg till anonyma användare eller systemanvändare (lokalt)][5]
* [Redigera användare/medarbetare][6]

<!-- Referenced links -->
[1]: onsite/import-users.md
[2]: index.md#visible
[3]: role/index.md
[4]: ../../license/change-user-plan.md
[5]: other-users.md
[6]: update-user.md

<!-- Referenced images -->
[img7]: ../../../../media/loc/en/admin/selected-user-plan.png
