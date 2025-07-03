---
uid: help-sv-project-type
title: Projekttyp
description: Lär dig hur du skapar en ny projekttyp i SuperOffice CRM. Definiera namn, ställ in beräknad varaktighet, koppla statusar och eventuellt en projektguide för att effektivisera projektstyrningen.
keywords: lägg till projekttyp, projekttyp, projekt, listan Projekt – Typ status
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Inställningar och underhåll
language: sv
redirect_from:
  - /sv/admin/lists/learn/project-type
  - /sv/project/learn/screen/project-type-admin
---

# Projekttyp

[!include[Must be admin](../../learn/includes/req-admin.md)]

Fältet **Typ** i **Projekt**-fönstret kategoriserar projekt och definierar deras arbetsflöden. Dessa typer är fördefinierade i listan **Projekt - Typ, status**, som du hanterar i **Inställningar och underhåll** under **Listor**.

Varje projekt måste ha en typ, och dessa typer kan kopplas till specifika [statusar][1] och, om så önskas, till en [projektguide][4]. Projektguider effektiviserar arbetsflödet genom att vägleda användare genom fördefinierade faser, händelser och dokument.

## Lägg till en projekttyp

1. Välj <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listor** i navigatorn.

1. Välj **Projekt - Typ, status** i rullgardinsmenyn. Fliken **Poster** visar alla befintliga projekttyper.

1. Klicka på **Lägg till** för att öppna dialogrutan **Redigera listpost**.

    ![Dialogrutan redigera listpost som visar fält för konfiguration av projekttyp -screenshot][img1]

1. Ange ett namn för projekttypen i fältet **Namn**. *(Obligatoriskt)*

    Detta namn visas i fältet **Typ** i **Projekt**-fönstret.

1. Ange den typiska varaktigheten för projekten i fältet **Beräknad tid för den här projekttypen** (antal veckor, dagar eller månader).

    Detta bestämmer standardvärdet för slutdatum vid skapandet av ett projekt.

1. Markera de statusar som ska användas för denna projekttyp i listan **Aktiva statusar för den här projekttypen**.

    > [!NOTE]
    > För att koppla projekttypen till en projektguide måste minst två statusar väljas.

1. *(Valfritt)* Markera **Den här projekttypen har kopplats till en guide** om du vill att projekt av denna typ ska följa en projektguide.

1. *(Valfritt)* Markera **Föreslå automatisk flyttning av projektet till nästa status** för att uppmana användare att [gå vidare till nästa status][5] när alla händelser i den aktuella statusen har slutförts.

1. Lägg till en beskrivning av projekttypen i fältet **Beskrivning**, om det behövs.

1. Klicka på **Spara** för att tillämpa ändringarna eller **Avbryt** för att ångra dem.

    Projekttypen läggs nu till i listan **Poster**. Upprepa stegen för att lägga till fler projekttyper.

## Redigera eller ta bort en projekttyp

1. Följ steg 1-2 ovan för att öppna listan **Projekt - Typ, status**.

1. För att redigera:
   * Dubbelklicka på önskad projekttyp för att öppna dialogrutan **Redigera listpost**.
   * Gör nödvändiga ändringar och klicka på **Spara**.

1. För att ta bort:
   * Markera projekttypen i listan och klicka på **Ta bort**.

    > [!CAUTION]
    > Om du tar bort en projekttyp försvinner även dess kopplingar till statusar och projektguider. Kontrollera att den inte används i aktiva projekt innan du fortsätter.

## <a id="restore"></a> Återställ en borttagen projekttyp

Om en projekttyp har tagits bort kan du återställa den från listan **Projekt - Typ, status**. Observera att återställning **inte** automatiskt återställer kopplingar till projektstatusar eller guider. Du måste återskapa dessa länkar manuellt om det behövs.

1. Gå till listan **Projekt - Typ, status**.

1. Markera **Visa borttagna poster och rubriker** längst ned. Borttagna poster visas genomstrukna i fliken **Poster**.

1. Dubbelklicka på den borttagna posten du vill återställa. Dialogrutan **Redigera listpost** öppnas.

1. Klicka på **Återställ**.

1. Uppdatera eventuella nödvändiga fält och klicka på **Spara**. Posten är nu aktiv och visas i fliken **Poster**.

## Relaterat innehåll

* [Lägg till en projektstatus][1]
* [Skapa en projektguide][2]
* [Redigera en projektguide][3]

<!-- Referenced links -->
[1]: project-status.md
[2]: create-project-guide.md
[3]: edit-project-guide.md
[4]: ../learn/project-guides.md
[5]: ../learn/project-guides.md#change-status

<!-- Referenced images -->
[img1]: ../../../media/loc/en/project/edit-project-type.png
