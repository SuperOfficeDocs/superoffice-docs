---
uid: help-sv-users-screen
title: Fönstret Användare
description: Fönstret Användare
author: Bergfrid Dias
so.date: 03.27.2023
keywords: user, medarbetare, våra företag
so.topic: reference
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# Fönstret Användare

I fönstret Användare kan du lägga till och redigera olika typer av användare.

![En översikt över fönstret Användare under Inställningar och underhåll -screenshot][img1]

[**Våra företag:**][2] Innan en person kan registreras som SuperOffice CRM-användare måste hen ha registrerats på ett företag som finns med i listan **Företag** i fönstret Användare. Enligt samma princip måste ett företag finnas med i företagslistan på fliken **Våra företag** i fönstret Användare för att visas i listan **Företag**.

> [!NOTE]
> Ändringar som du gör i fönstret Användare träder inte i kraft förrän du klickar på **Spara** längst ned i fönstret eller bekräftar att du vill spara ändringarna i dialogrutan som visas. Om du klickar på **Avbryt** förlorar du alla ändringar som du har gjort i fönstret sedan du sparade sist.

## <a id="associates" />Medarbetarlistan

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

### Användarinformation

På höger sida av fönstret finns detaljerad information om den användare som är markerad i listan över medarbetare.

Fullständigt namn, e-postadress och ägarföretag visas högst upp. Längst ned i det här avsnittet kan du aktivera/inaktivera användaren i SuperOffice med knappen **Kan logga in**. Klicka på knappen **Uppgift** för att komma åt funktioner som **Flytta användare** och för att skicka välkomstmeddelanden och e-postmeddelanden för återställning av lösenord.

I användaröversikten finns olika flikar:

* **Detaljer** – huvudöversikt med användarinformation som **Användar-ID**, **Roll**, **Användarplan**, **Primärgrupp** och **Service-kategorier**.
* **Licenser** – extra licensinformation som **Konfidentiella aktiviteter** som användaren kan använda för att ange **synlig för** för händelser, dokument och urval.
* **Mer** – fliken visar om det finns extrafält för en person.

## <a id="other-users" />Andra användare (lokalt)

På fliken **Andra användare** i fönstret Användare kan du redigera inloggningsrättigheter för och lägga till anonyma användare och systemanvändare.

## <a id="our-companies" />Våra företag

Syftet med företagslistan på fliken **Våra företag** är att specificera följande:

* Vem som kan definieras som användare av SuperOffice CRM. Innan en person kan registreras som SuperOffice CRM-användare måste hen ha registrerats på ett företag som finns med i listrutan **Företag** i fönstret Användare. Enligt samma princip måste ett företag finnas med i företagslistan på fliken **Våra företag** i fönstret Användare för att visas i listrutan **Företag**.

* Vilka företag som kan definieras som ägare av en satellit.

### Kolumner i företagslistan

| Kolumn | Beskrivning |
|---|---|
| Företagsnamn | Företagets namn. |
| Avdelning | Namnet på avdelningen i företaget. |
| Ort | Var företaget ligger. |
| Medarbetare | Hur många medarbetare som har skapats för företaget. |
| Aktiv satellit | Huruvida företaget är registrerat som en aktiv satellit . |

## Användarlicenser

På fliken **Användarlicenser** i fönstret Användare får du en översikt över hur många användarlicenser som är i bruk och vilka användare som använder de olika licenserna.

* Klicka på en licens i listan **Användarlicenser** för att visa en lista över användare som just nu använder licensen i fråga.

* Håll muspekaren över ett licensnamn för att visa detaljerad information om licensen.

## Användargrupper

På fliken **Användargrupper** i fönstret Användare får du en översikt över användare och användargrupper. Klicka på ett gruppnamn i listan **Tillgängliga grupper** för att visa en lista över användare som tillhör gruppen.

## Vad vill du göra nu?

* [Lägga till användare][2]
* [Flytta användare][3]
* [Ta bort användare][1]
* [Importera användare][4]
* [Läs om användartyper][5]
* [Hantera anonyma användare och systemanvändare (lokalt)][11]
* [Lägg till och ta bort företag på fliken Våra företag][8]
* [Filtrera och gruppera användare][6]

<!-- Referenced links -->
[1]: ../delete-user.md
[2]: ../add-associate.md
[3]: ../move-user.md
[4]: ../import-users.md
[5]: ../index.md
[6]: ../associates-filter-group.md
[7]: ../role/index.md
[8]: ../our-companies.md
[11]: ../other-users.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/admin/admin-users-overview.png
