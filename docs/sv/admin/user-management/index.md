---
uid: help-sv-users
title: Användare
description: Lär dig hur du lägger till nya användare, tilldelar rätt användarroller och grupper och hjälper användarna med konfigurationen och WebTools.
keywords: Fönstret Användare, användare, medarbetare, våra företag, synlighet, tillgängligt
author: SuperOffice Product and Engineering
date: 02.21.2023
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from: 
  - /sv/admin/user-management/learn/screen/index
  - /sv/admin/user-management/learn/visibility
---

# Användare

Som administratör har du till uppgift att lägga till och administrera dina användare. I det här avsnittet lär dig hur du lägger till nya användare, tilldelar rätt användarroller och grupper och hjälper användarna med konfigurationen och WebTools.

## <a id="visible"></a>Synlighet

Huruvida du kan se specifika dokument, försäljningar, händelser och urval beror inte enbart på vilken [roll][1] du har tilldelats. Det kan finnas enskilda informationsposter som du inte har tillgång till. I dialogrutorna dokument och händelser och i fönstren Försäljning och Urval finns en listruta med namnet **Synlig för**. I fönstret Försäljning kan du till exempel välja att göra en försäljning synlig för alla, endast synlig för primärgruppen som ägaren tillhör eller endast synlig för ägaren.

Detta kräver att du har licensen **Konfidentiella aktiviteter**.

Om du vill aktivera den här licensen lokaliserar du önskad användare, klickar på fliken **Licenser** och markerar sedan kryssrutan för **Konfidentiella aktiviteter**.

## Användartyper

* **Medarbetare**: SuperOffice CRM-användare (i ditt företag)

* **Andra användare**: Anonyma användare och systemanvändare (endast lokalt)

* **Anonyma användare**: Användare med begränsad behörighet, som definieras av [rollen för anonyma användare][4]. Anonyma användare kan till exempel få tillgång till webbsidor. På så sätt kan säljare publicera relevant information från SuperOffice CRM på en webbplats som inte kräver inloggning där kunderna enkelt får tillgång till den.

* **Systemanvändare**: [!include[Access rights](includes/def-system-user.md)]

    Systemanvändaren är avsedd för integration och kan bland annat användas för att ge processer fullständig åtkomst till SuperOffice-databasen vid replikering av kalendrar.

## Medarbetare

**Medarbetare** är SuperOffice-användare i ditt företag (eller ett associerat företag, till exempel ett dotterbolag).

På fliken **Medarbetare** i fönstret Användare kan du bland annat lägga till användare av typen **Medarbetare** och tilldela dem roller, grupper och licenser, redigera befintliga användare och ta bort användare.

Innan en person kan registreras som SuperOffice CRM-användare måste hen ha registrerats på ett företag som finns med i listrutan **Företag** i fönstret Användare. Enligt samma princip måste ett företag finnas med i företagslistan på fliken **Våra företag** i fönstret Användare för att visas i listrutan **Företag**.

> [!NOTE]
> I fönstret Användare anger du vilka licenser de olika användarna ska ha. Om du vill lägga till nya systemlicenser eller öka/minska antalet licenser för en eller flera moduler kontaktar du SuperOffice och [uppdaterar licensinformationen][6].

## <a id="screen"></a>Fönstret Användare

I fönstret Användare kan du lägga till och redigera olika typer av användare.

![En översikt över fönstret Användare under Inställningar och underhåll -screenshot][img3]

[**Våra företag:**][2] Innan en person kan registreras som SuperOffice CRM-användare måste hen ha registrerats på ett företag som finns med i listan **Företag** i fönstret Användare. Enligt samma princip måste ett företag finnas med i företagslistan på fliken **Våra företag** i fönstret Användare för att visas i listan **Företag**.

> [!NOTE]
> Ändringar som du gör i fönstret Användare träder inte i kraft förrän du klickar på **Spara** längst ned i fönstret eller bekräftar att du vill spara ändringarna i dialogrutan som visas. Om du klickar på **Avbryt** förlorar du alla ändringar som du har gjort i fönstret sedan du sparade sist.

### <a id="associates"></a>Medarbetarlistan

Listan på fliken **Medarbetare** har som standard följande kolumner:

| Kolumn | Beskrivning |
|---|---|
| Användar-ID | Användarnamnet som medarbetaren har tilldelats. |
| Förnamn | Användarens förnamn. |
| Efternamn | Användarens efternamn. |
| Primärgrupp | Användarens primära grupp. |
| Roll | [Rollen][7] som användaren har tilldelats. Rollen definierar vilka databehörigheter användaren har i SuperOffice CRM. |
| Användarplan | Användarplanen som användaren har tilldelats. |
| Ägarföretag | Namn på det företag som användaren tillhör (definieras som databasägare). |

> [!TIP]
> Du kan välja vilka kolumner som ska visas i listan. Högerklicka bara på en kolumnrubrik och markera relevanta kolumner i kolumnlistan. Du kan ändra ordningen på kolumnerna genom att klicka och dra i kolumnrubrikerna.

#### Användarinformation

På höger sida av fönstret finns detaljerad information om den användare som är markerad i listan över medarbetare.

Fullständigt namn, e-postadress och ägarföretag visas högst upp. Längst ned i det här avsnittet kan du aktivera/inaktivera användaren i SuperOffice med knappen **Kan logga in**. Klicka på knappen **Uppgift** för att komma åt funktioner som **Flytta användare** och för att skicka välkomstmeddelanden och e-postmeddelanden för återställning av lösenord.

I användaröversikten finns olika flikar:

* **Detaljer** – huvudöversikt med användarinformation som **Användar-ID**, **Roll**, **Användarplan**, **Primärgrupp** och **Service-kategorier**.
* **Licenser** – extra licensinformation som **Konfidentiella aktiviteter** som användaren kan använda för att ange **synlig för** för händelser, dokument och urval.
* **Mer** – fliken visar om det finns extrafält för en person.

### <a id="other-users"></a>Andra användare (lokalt)

På fliken **Andra användare** i fönstret Användare kan du redigera inloggningsrättigheter för och lägga till anonyma användare och systemanvändare.

### <a id="our-companies"></a>Våra företag

Syftet med företagslistan på fliken **Våra företag** är att specificera följande:

* Vem som kan definieras som användare av SuperOffice CRM. Innan en person kan registreras som SuperOffice CRM-användare måste hen ha registrerats på ett företag som finns med i listrutan **Företag** i fönstret Användare. Enligt samma princip måste ett företag finnas med i företagslistan på fliken **Våra företag** i fönstret Användare för att visas i listrutan **Företag**.

* Vilka företag som kan definieras som ägare av en satellit.

#### Kolumner i företagslistan

| Kolumn | Beskrivning |
|---|---|
| Företagsnamn | Företagets namn. |
| Avdelning | Namnet på avdelningen i företaget. |
| Ort | Var företaget ligger. |
| Medarbetare | Hur många medarbetare som har skapats för företaget. |
| Aktiv satellit | Huruvida företaget är registrerat som en aktiv satellit . |

### Användarlicenser

På fliken **Användarlicenser** i fönstret Användare får du en översikt över hur många användarlicenser som är i bruk och vilka användare som använder de olika licenserna.

* Klicka på en licens i listan **Användarlicenser** för att visa en lista över användare som just nu använder licensen i fråga.

* Håll muspekaren över ett licensnamn för att visa detaljerad information om licensen.

### Användargrupper

På fliken **Användargrupper** i fönstret Användare får du en översikt över användare och användargrupper. Klicka på ett gruppnamn i listan **Tillgängliga grupper** för att visa en lista över användare som tillhör gruppen.

## Relaterat innehåll

* [Hantera dina roller][1]
* [Lägg till en ny användare][2]
* [Ändra användarplaner för aktiva användare][3]
* [Installera WebTools för dina användare][7]

<!-- Referenced links -->
[1]: role/index.md
[2]: add-associate.md
[3]: ../../license/change-user-plan.md
[4]: onsite/other-users.md#rights
[6]: ../../license/learn/activate.md
[7]: ../../../../../integrations/webtools/install.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/admin/admin-users-overview.png
