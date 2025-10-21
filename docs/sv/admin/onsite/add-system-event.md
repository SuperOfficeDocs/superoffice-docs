---
uid: help-sv-system-event-add
title: Lägga till systemhändelser
description: Lägga till systemhändelser
keywords: arrangemang, avisering, systemhändelse, status, Service
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: howto
deployment: onsite
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: 
  - /sv/admin/learn/system-events
  - /sv/admin/learn/add-system-events
language: sv
---

# Lägga till systemhändelser (lokalt)

Du kan initiera vissa systemhändelser från listan **Systemmeddelanden** på **Status**-fliken.

1. Öppna fönstret Licenser.

2. Gå till fliken **Status**.

3. Klicka på **Lägg till**-knappen under **Systemmeddelanden**.

4. Välj en [systemhändelse](#types) från listrutan **Händelsetyp** i dialogrutan **Lägg till händelse**.

5. Ange datum och klockslag för när du förväntar dig att händelsen kommer att avslutas i fälten **Avslutad**.

    > [!NOTE]
    > Händelser avslutas inte automatiskt. Du måste ta bort dem från fliken **Systemhändelser** för att avsluta dem.

6. Lägg in mer detaljerad information om händelsen i fältet **Beskrivning**.

    > [!NOTE]
    > Om du lägger till en händelse av typen **Dagens meddelande** (meddelande till alla användare) är det texten i fältet **Beskrivning** som skickas till användarna tillsammans med den beräknade sluttiden.

7. Klicka på **Spara** för att skapa händelsen. Den visas nu i listan **Systemhändelser** på **Status**-fliken.

> [!TIP]
> Om du vill redigera en händelse dubbelklickar du på den i listan.
>
> Om du vill ta bort en händelse markerar du den i listan och klickar på knappen **Ta bort**.

## <a id="types"></a>Typer

Följande händelsetyper startas från de olika skärmbilderna under Inställningar och underhåll:

* **UDefRebuild**, som det finns flera typer av: de användardefinierade fältens layout uppdateras och de användardefinierade fälten är inte åtkomliga så länge händelsen pågår.

    > [!NOTE]
    > Du får inte avbryta den här händelsen från listan **Systemmeddelanden**.

* **FreetextRebuild**: fritextindexet skapas och användarna kan inte använda fritext medan detta pågår.

* **PrototypeRebuild**: En Travel-prototyp skapas. Travel-funktionerna är inte åtkomliga medan denna händelse pågår.

    > [!NOTE]
    > I nödfall kan du avbryta både **FreetextRebuild** och **PrototypeRebuild** från listan **Systemmeddelanden**.

* **ROURebuild**: räknare eller statusövervakning återskapas. Statusbilder, fliken **Statistik** och räknarna är otillgängliga medan händelsen pågår. (Statusövervakning kräver [separat licens][2].)

På **Status**-fliken på skärmbilden Licenser kan du starta följande typer av händelser:

* **Utan inloggning**: Välj den här händelsen om du vill förhindra inloggning vid uppgradering av servrar eller databaser, schemalagt underhåll etc.
* **Utan fritext**: Välj den här händelsen om du vill begränsa den utgående Travel-databasens storlek.
* **Utan Travel**: Välj den här händelsen om du vill inaktivera Travel. Det kan vara bra precis före stora systemuppgraderingar för att förhindra synkroniseringsproblem för återkommande Travel-användare.
* **Dagens meddelande**: Välj den här händelsen om du vill skapa viktiga meddelanden som visas för alla som loggar in i SuperOffice CRM (efter några minuter visas meddelandet även för dem som redan är inloggade).

<!-- Referenced links -->
[2]: ../../../en/admin/license/index.md

<!-- Referenced images -->
