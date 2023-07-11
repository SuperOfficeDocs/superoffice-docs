---
uid: help-sv-role
title: Roll
description: Roll
author: Kirsti Aakerholt
so.date: 04.19.2023
keywords: roll, dataobjekt, användarnivå
so.topic: concept
so.topic: admin
language: sv
---

# Roller

[!include[Requirement](../includes/note-anon-req.md)]

Genom att använda rollbaserad säkerhet i SuperOffice CRM kan du anpassa roller för olika åtkomstnivåer i företaget. Rollerna styr vilka behörigheter olika användare har i SuperOffice CRM-modulerna.

En roll beskriver två saker:

* Vilka **dataobjekt** (företag, kontakt, projekt, projektdeltagare, urval, försäljning, intressent, händelse, dokument, relation, dashboards och mål) som ska vara tillgängliga för användare med den här rollen.

    Tillgänglighet anges med hjälp av behörigheter: inga, läs, skapa, uppdatera och ta bort.

* Vilka **funktioner** (till exempel administratörsåtkomst under Inställningar och underhåll, tillåta massuppdatering, godkännande, massbrevsmall, exporturval och publicering) som ska vara tillgängliga för användare med den här rollen.

## Fördefinierade roller

Det finns ett antal fördefinierade roller i SuperOffice CRM. **Användarrollerna 0-5** motsvarar användarnivåerna i tidigare versioner av SuperOffice, där användarnivå 0 är en administratör. Ni kan ändra rollerna efter eget behov.

| Roll | Förklaring |
|---|---|
| Användarnivå 0 | Administratör: Har full tillgång till alla data. Kan underhålla alla delar av systemet. |
| Användarnivå 1 | Superuser: Har full tillgång till alla data, men kan inte underhålla systemet. |
| Användarnivå 2 | Har full tillgång inom den egna användargruppen, men begränsad tillgång utöver det. |
| Användarnivå 3 | Har full tillgång till egna data och kan läsa data i den egna användargruppen, men har begränsad tillgång utöver det. |
| Användarnivå 4 | Har full tillgång till egna data, men begränsad tillgång inom den egna användargruppen och utöver det. |
| Användarnivå 5 | Har läsåtkomst till de flesta data, men begränsad tillgång till andras data. Kan skapa aktiviteter. |
| Listadministratör | Har fullständig åtkomst till data i SuperOffice CRM-klienten. Kan använda Inställningar och underhåll för att redigera listor i systemet (till exempel listor med dokumentmallar och kategorier). |
| Användaradministratör | Har full tillgång till data. Kan använda Inställningar och underhåll för att skapa och redigera användare i systemet. |
| Lokal användare | Har fullständigt tillgång till egna, men ingen tillgång till data som tillhör användare som är kopplade till andra företag. |
| Extern användare | Konsult eller partner med begränsad tillgång till företags- och projektdata. Kommer bara åt publicerade data. |
| Anonym användare | Anonym användare |
| Systemanvändare | Systemintegrationsanvändare. Åsidosätter alla säkerhetskontroller. Den här rollen är inte synlig och kan inte redigeras. |

### Användar- eller Administratörsroll

När du ger åtkomst till en ny person måste du definiera personens roll: användare eller administratör.

Administratörer har åtkomst till sektionen Inställningar och underhåll. Där kan du skapa användare, justera behörigheter och anpassa CRM-lösningen efter dina behov. Om du vill att användaren ska ha denna åtkomst ger du honom eller henne behörighet 0.

Om du inte vill att användaren ska ha tillgång till Inställningar och underhåll tilldelar du behörighet 1 eller högre beroende på vilken åtkomst han/hon behöver.

## Hantera dina roller

I sektionen Roller kan du [definiera vilken typ av åtkomst][6] dina användare har till olika delar av SuperOffice CRM. Du kan också anpassa varje användarnivå genom att ändra databehörigheter och/eller funktionella behörigheter.

![I sektionen Roller kan du avgöra vilken typ av åtkomst dina användare ska ha till olika delar av SuperOffice CRM -screenshot][img1]

Du kan till exempel bestämma om en person ska kunna ta bort, uppdatera, skapa eller läsa information på fliken Databehörigheter. På fliken Funktionella behörigheter kan du tilldela olika funktionella behörigheter (till exempel Tillåt massuppdatering eller Listadministratör) till olika roller genom att flytta dem till den högra kolumnen för "Denna roll kan".

| Roll | Förklaring | Ingen | Läsa | Skapa | Uppdatera | Radera |
|---|---|:-:|:-:|:-:|:-:|:-:|
| Ingen | Inga behörigheter och kan inte se | X |  |  |  |  |
| Läsa | Kan läsa |  | X |  |  |  |
| Skapa | Kan skapa |  | X | X |  |  |
| Uppdatera | Kan uppdatera |  | X | X | X |  |
| Radera | Kan ta bort |  | X | X | X | X |

## Vad vill du göra nu?

* [Skapa en roll][1]
* [Redigera en roll][2]
* [Ange behörighet för roll][3]
* [Redigera behörigheter för anonyma användare][4]
* [Ta bort en roll][5]
* [Ange databehörigheter för en roll – tekniska dokument][6]

<!-- Referenced links -->
[1]: create-role.md
[2]: editing-role.md
[3]: set-data-rights-for-role.md
[4]: edit-rights-for-anonymous-users.md
[5]: deleting-role.md
[6]: ../role/set-data-rights-for-role.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/admin/manage-user-levels.png
