---
uid: help-sv-screen-designer-edit-layout
title: Redigera layouten för ett kort
description: I den här guiden förklarar vi hur du redigerar en layout.
keywords: skärmlayout, redigera layout, ändra layout, ta bort layout, Återställ till fabriksinställningar
author: Bergfrid Dias
date: 10.09.2025
version: 10.3.10
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: sv
index: true
redirect_from:
  - /sv/ui/screen-designer/learn/elements
  - /sv/customization/screen-designer/edit-layout
---

# Redigera layouten för ett kort

[!include[Krav](../../../includes/req-dev-tools.md)]

När du har [skapat en ny layout][6] är det dags att anpassa den. Anpassa layouten för huvudkort och arkiv så att de uppfyller informationsbehoven i din organisation.

## Viktiga överväganden

Innan du anpassar en layout bör du fastställa vem de tilltänkta användarna är.

* Vad behöver de snabbt kunna nå?
* Behöver de alla standardfält och flikar, eller ska du ta bort något?
* Behöver de fler flikar?
* Vad är den logiska ordningen för fälten?

> [!NOTE]
> Du kan redigera **standardlayouten**, men du kan inte redigera standardinställningarna för kontrollerna och du kan inte tilldela layouten till en annan användargrupp.

Titta på den här videon och ta reda på hur du använder skärmdesignern för att konfigurera dina skärmar i SuperOffice CRM eller följ steg-för-steg-guiden nedan (videons längd – 6:41):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU]

## <a id="edit"></a>Redigera kortlayout

1. Öppna Skärmdesignern.
2. Välj högst upp en skärm eller dialog som du vill anpassa.
3. Välj en layout i listan till vänster.
4. Klicka på **Redigera layout** under förhandsgranskningen.
5. I skärmbilden **Redigera kortlayout**, gå igenom flikarna på skärmen.

    * [Lägg till, redigera, flytta eller ta bort ett fält][1]
    * [Lägg till koppling eller knapp][2]
    * [Organisera information i logiska grupper][4]
    * [Lägg till, ta bort eller återställ en flik][3]
    * [Ändra antalet kolumner i en flik][5]<a id="columns"></a>

![Ta bort, lägg till och flytta olika fält i layouten -screenshot][img3]

## <a id="save"></a>Spara, publicera eller avbryt

Efter att ha redigerat en layout, klicka på en av följande knappar:

| Knapp | Beskrivning |
|---|---|
| Spara utkast | Sparar en opublicerad version av layouten, som du kan fortsätta redigera senare eller be någon granska. |
| Spara + Publicera | Tillämpa layouten på de valda användargrupperna **eller** försäljnings-/projekt-/ärende-/händelsestyperna. |
| Avbryt | Tar bort alla ändringar. |

## <a id="undo-changes"></a>Ångra ändringar

Om du behöver återgå till en tidigare version av skärmen kan du använda följande alternativ från knappen **Uppgift**:

* **Återställ till fabriksinställningar**: Detta alternativ tar bort alla ändringar och återställer layouten till standardversionen som levereras av SuperOffice.

* **Återställ flikar**: Detta alternativ återställer alla tidigare borttagna flikar.

* **Ignorera utkast**: Detta alternativ tar bort alla osparade ändringar och återställer layouten till den senast publicerade versionen.

## <a id="delete"></a>Radera layout

När en layout som är baserad på en användargrupp tas bort, ser användare i den gruppen standardlayouten (systemlayout).

För att radera en layout:

1. Välj layouten från listan **Layouts**.
1. Klicka på **Ta bort**.

## Relaterat innehåll

* [Arbeta med detaljkort (arkiv)][7]

<!-- Referenced links -->
[1]: working-with-fields.md
[2]: add-button.md
[3]: working-with-tabs.md
[4]: working-with-tabs.md#label
[5]: working-with-tabs.md#columns
[6]: add-layout.md
[7]: working-with-archives.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/customization/edit-the-screen-layout-of-companies-and-contacts.png
