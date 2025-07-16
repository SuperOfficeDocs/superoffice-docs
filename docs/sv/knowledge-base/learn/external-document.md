---
uid: help-sv-document-external
title: Arbeta med externa dokument
description: Arbeta med externa dokument
keywords: ärende, dokument
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
category: service
topic: knowledge base
license: servicepremium
functional_right: knowledge-base
audience: person
audience_tooltip: SuperOffice Service
language: sv
redirect_from: /sv/request/learn/external-document
---

# Arbeta med externa dokument (kunskapsbas)

Du kan du lägga till dokument (inkl. bilder och andra filer) så att de blir tillgängliga för alla som använder SuperOffice Service, även oregistrerade kunder. De dokument som du laddar upp i kunskapsbasen blir tillgängliga när du skriver innehållet i ett meddelande till en kund.

Detta gäller t.ex. när du använder fliken **Meddelande** när du [svarar på ett ärende][1]. Här kan du skriva text på samma sätt som i ett ordbehandlingsprogram. Du kan även infoga bilder genom att klicka på knappen **Bild** i verktygsfältet men då måste bilden redan vara uppladdad till **Externa dokument**. När meddelandet skickas skapas länkar till filer under **Externa dokument**. Samma sak gäller när du t.ex. skapar svarsmallar och meddelanden i SuperOffice Marketing.

> [!NOTE]
> Den här funktionen kräver användarlicensen Service-Premium.

## Visa dokument

1. Gå till <i class="ph ph-list" aria-label="Main menu"></i> i det övre fältet och välj **Kunskapsbas** > **Externa dokument**.

1. Gå till önskad mapp.

1. Gör något av följande:
    * Klicka på dokumentets namn för att komma till skärmen **Egenskaper för dokument**. Här kan du också visa och redigera innehållet i vissa dokumenttyper, t.ex. html, txt och det interna ejr-formatet.
    * Klicka på <i class="ph ph-download-simple" aria-label="Hämta"></i> för att ladda ned dokument som inte kan visas i webbläsaren, som PDF- och Microsoft Office-filer. En ikon i dokumentlistan anger typen av dokument.

## Lägg till dokument

> [!NOTE]
> Du måste skapa det faktiska fysiska dokumentet innan du kan lägga till det i SuperOffice. När du till exempel skapar en prislista kan du t.ex. skriva innehållet i Microsoft Word eller Excel.

1. Gå till <i class="ph ph-list" aria-label="Main menu"></i> i det övre fältet och välj **Kunskapsbas** > **Externa dokument**.

1. Gå till mappen som du vill lägga in dokumentet i. Om den inte finns än, kan du skapa en ny mapp enligt beskrivningen nedan.

1. Klicka på knappen **Nytt dokument**. Du kommer då till skärmen **Egenskaper för dokument**.

1. Ange ett beskrivande namn på dokumentet i fältet **Namn**.

1. I fältet **I mapp** visas automatiskt namnet på den mapp som du har valt. Om du ändrar dig kan du klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> och välja en annan mapp i den lista som visas.

1. I fältet **Åtkomst** väljer du vem som ska ha behörighet att läsa och redigera dokumentet.

1. För att använda dokumentet i ett webbaserat kundcenter kan du lägga in en valbar unik identifieringssträng i fältet **ID-sträng**.

1. I fältet **Beskrivning** kan du lägga in en kort beskrivning av vad dokumentet innehåller.

1. Klicka på knappen **Bläddra** bredvid **Fil** och välj det nya dokumentet i dialogrutan som visas.

1. Klicka på **Spara**. Om dokumenttypen kan redigeras i webbläsaren visas dokumentets innehåll i fältet **Innehåll**.

1. Klicka på **OK**. Dokumentet läggs i angiven mapp.

> [!NOTE]
> Vissa filtyper är som standard blockerade från att laddas upp som externa dokument i Service. Om du behöver tillåta uppladdning av någon av dessa typer, såsom **js**, kan en administratör uppdatera [systeminställningen **osäkra filtyper**][9] i Inställningar och underhåll.

## Redigera dokumentinnehåll

Vissa dokumenttyper, t.ex. html, txt och det interna ejr-formatet, kan redigeras direkt på skärmen **Egenskaper för dokument**. För andra typer, som PDF, behöver du det program som dokumentet ursprungligen skapades i.

1. Gå till <i class="ph ph-list" aria-label="Main menu"></i> i det övre fältet och välj **Kunskapsbas** > **Externa dokument**.
1. Gå till den mapp som dokumentet ligger i.
1. Klicka på <i class="ph ph-download-simple" aria-label="Hämta"></i> för att ladda ner ett dokument.
1. Redigera och spara dokumentet i det program som dokumentet ursprungligen skapades i.
1. Klicka på dokumentets namn för att komma till skärmen **Egenskaper för dokument**.
1. Klicka på knappen **Bläddra** bredvid fältet **Fil** och välj det dokument som du skapade i den dialogruta som visas.
1. Klicka på **OK** för att ladda upp dokumentet.

## Redigera dokumentegenskaper

Genom att redigera dokumentegenskaperna kan du t.ex. justera vem som ska ha åtkomst till dokumentet.

1. Gå till <i class="ph ph-list" aria-label="Main menu"></i> i det övre fältet och välj **Kunskapsbas** > **Externa dokument**.
1. Gå till den mapp som dokumentet ligger i.
1. Klicka på dokumentets namn för att komma till skärmen **Egenskaper för dokument**.
1. Gör de ändringar som behövs (se ovan).
1. Klicka på **OK**. Ändringarna sparas.

> [!TIP]
> För att flytta dokumentet till en annan mapp, väljer du en ny mapp i fältet **I mapp**.

## Ta bort dokument

1. Gå till <i class="ph ph-list" aria-label="Main menu"></i> i det övre fältet och välj **Kunskapsbas** > **Externa dokument**.
1. Gå till den mapp som dokumentet ligger i.
1. Klicka på dokumentets namn för att komma till skärmen **Egenskaper för dokument**.
1. Klicka på knappen **Ta bort** längst ned på skärmen.
1. Bekräfta genom att klicka på **OK**. Dokumentet tas bort från SuperOffice Service.

## Relaterat innehåll

* [Skapa och ta bort mappar][2]

<!-- Referenced links -->
[1]: ../../request/learn/reply.md
[2]: manage-folders.md
[9]: ../../../../release-notes/10.3/service/10.3.11-update.md
