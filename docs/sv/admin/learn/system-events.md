---
uid: help-sv-system-events
title: Systemhändelser
description: Systemhändelser
author: SuperOffice RnD
date: 06.29.2022
keywords: arrangemang
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Systemhändelser

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

[!include[Terminate events](includes/note-terminate-event.md)]

## Vad vill du göra nu?

* [Lägga till systemhändelser][1]

<!-- Referenced links -->
[1]: add-system-event.md
[2]: ../../../en/admin/license/index.md

<!-- Referenced images -->
