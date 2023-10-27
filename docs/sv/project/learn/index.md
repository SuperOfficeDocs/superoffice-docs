---
uid: help-sv-project
title: Projekt
description: Den här guiden visar hur du skapar och använder projekt för att hålla koll på ditt arbete.
author: SuperOffice RnD
so.date: 02.10.2023
keywords: projekt
so.topic: concept
language: sv
---

# Projekt

Du kan länka vilken aktivitet som helst till ett externt företag och till ett projekt. Du kan även jobba med en projektguide som tar dig genom varje steg i projektet, om projekttypen du har valt har en guide. Ett projekt kan vara riktat mot många kontakter och en kontakt kan delta i flera projekt.

![Projektskärm -screenshot][img1]

Projekt hjälper dig att organisera och dokumentera arbetet på ett ställe, så att du och ditt team kan få bättre kontroll och förbättra samarbetet.

Du kan ansluta kontakter, företag, händelser, projektdeltagare och till och med affärsmöjligheter till ett projekt i SuperOffice CRM. Du kan också skapa eller överföra dokument och filer till projektet.

All information du sparar i projektet taggas med ett datum och en ägare, vilket gör det enklare att sortera och filtrera information när det behövs.

Projektskärmen innehåller information om de projekt som lagts in i SuperOffice CRM. Varje projekt visas som ett indexkort som visar all information om projektet.

För att gå bakåt och framåt mellan projekt, klicka på knapparna ![ikon][img2] ![ikon][img3] föregående/nästa nere till höger om korten

Om du har valt en projekttyp för vilken en [projektguide][1] har definierats, visas fliken **Projektguide** på detaljkortet.

## <a id="more-tab" />Fliken Mer

![Fliken Mer (projekt) -screenshot][img4]

På fliken **Mer** visas användardefinierade fält för projektet. Om din organisation behöver fler fält än standardfälten på fliken **Projekt**, kan du i Inställningar och underhåll ange att dessa fält ska infogas här.

Klicka på **Redigera** för att redigera projektinformationen på fliken **Mer**.

Tre av de användardefinierade fälten från fliken **Mer** kan också visas på fliken **Projekt**.

## Fliken Anteckning

[!include[About the Note tab](../../learn/includes/about-note-tab.md)]

## <a id="event-tab" />Fliken Arrangemang

Denna funktion kräver en separat licens.

På fliken **Arrangemang** kan du ange inställningar för publicering av arrangemang.

| Fält | Beskrivning |
|---|---|
| Händelse | Här kontrollerar du att det aktuella projektet är ett arrangemang. |
| Datum för arrangemang | I det här fältet visas datumet för arrangemanget. Klicka på pilen för att välja ett datum för arrangemanget. |
| Publicerad (från-datum och till-datum) | Här kan du ange en exakt tidsperiod under vilken arrangemanget är synligt för Audience-användare (kräver en separat licens). Klicka på pilen bredvid vart och ett av datumfälten för att välja ett start- och slutdatum för publiceringen. Om du inte anger datum i dessa fält, [förblir projektet publicerat][2] tills det antingen avpubliceras eller tas bort från SuperOffice CRM. |
| Synlig för kategori | Markera här om du vill att arrangemanget bara ska vara synligt för specifika kategorier. Klicka på knappen ( ![ikon][img5] ) till höger om fältet för att välja de kategorier som arrangemanget är synligt för. |
| Synligt för kontaktintresse | Markera här om du vill att arrangemanget endast ska vara synligt för kontakter med specifika intressen. Klicka på knappen ( ![ikon][img5] ) till höger om fältet för att välja de intressen som arrangemanget är synligt för. |
| Synlig för projektdeltagare | Om det här alternativet är markerat, visas arrangemanget endast i Audience för de [projektdeltagare][8] som anges på detaljkortet **Projektdeltagare**. |
| Anmälan | Markera här om du vill att det ska vara möjligt att anmäla sig till arrangemanget via Audience. |
| Avanmälan | Markera här om du vill att det ska vara möjligt att avanmäla sig för arrangemanget via Audience. |
| Logga som aktivitet | Om du också markerar **Logga som aktivitet** bredvid **Anmälan** eller **Avanmälan**, skapas en aktivitet åt dig när en Audience-användare anmäler eller avanmäler sig till arrangemanget. |

> [!TIP]
> Om du klickar på knappen ( ![ikon][img5] ) till höger om **Bekräftelse**, kan du ange en bekräftelsetext som ska visas i en dialogruta när en Audience-användare anmäler eller avanmäler sig till arrangemanget. Användaren måste klicka på **Ja** eller **Nej** i denna dialogruta för att fortsätta.

## Lägg till projekt i favoriter

[!include[ALT](../../learn/includes/howto-add-favorite.md)]

## Skriva ut projektinformation

1. [!include[Go to project](includes/goto-project.md)]
2. Klicka på **Uppgift**-knappen och välj **Skriv ut**.
3. I fönstret som visar innehållet som ska skrivas ut klickar du på **Skriv ut**.

## Vad vill du göra nu?

* [Skapa ett projekt][2]
* [Redigera ett projekt][3]
* [Slå ihop projekt][4]
* [Ta bort ett projekt][5]
* [Skicka ett dokument till projektdeltagare][7]
* [Projektguide][1]

<!-- Referenced links -->
[1]: project-guide/index.md
[2]: create.md
[3]: edit.md
[4]: merge-projects.md
[5]: delete.md
[7]: project-members/create-mailing.md
[8]: project-guide/create.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/project/projects.png
[img2]: ../../../media/icons/arrow-left.png
[img3]: ../../../media/icons/arrow-right.png
[img4]: ../../../media/loc/en/project/project-more.png
[img5]: ../../../media/icons/select.png
