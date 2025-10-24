---
uid: help-sv-screen-designer-add-layout
title: Lägg till layout
description: Så här lägger du till en ny layout för en användargrupp.
keywords: lägg till layout, ny layout, skärmlayout, Tilldela layouter till
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
  - /sv/ui/screen-designer/learn/add-new-layout
  - /sv/customization/screen-designer/add-layout
---

# Lägg till layout

[!include[Krav](../../../includes/req-dev-tools.md)]

Oavsett om du lägger till en personlig vy för en utvald användargrupp eller designar en layout optimerad för specifika projekt-, försäljnings-, ärende- och händelsestyper eller dokumentmallar, börjar du med att lägga till en ny layout för en skärm i Skärmdesignern.

Med anpassade skärmlayouter för varje av dina team kommer det att bli enklare än någonsin att hitta kunddata. De mest relevanta uppgifterna kommer alltid att vara tillgängliga och synliga. Ta bort, flytta eller dölj irrelevanta eller mindre viktiga data för att städa upp på skärmarna. Lägg till anpassade arkiv med de mest relevanta uppgifterna för dina team. Resultatet blir en renare och mer organiserad skärm för dina team att arbeta i.

Titta på den här videon och ta reda på hur du lägger till en ny layout eller följ steg-för-steg-guiden nedan (videon börjar vid 5:37):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU?t=337]

## Skapa ny layout

1. Öppna Skärmdesignern (i **Inställningar och underhåll**).

1. Välj en skärm eller dialog högst upp att anpassa.

1. Välj **Huvudkort**.

    För att skapa en layout för ett arkiv, se [Arbeta med detaljkort (arkiv)][2].

1. [Välj tilldelningsmetod][6] (om inte inställt): klicka på texten bredvid **Tilldela layouter till**, och välj grupp, typ eller mall.

1. Under **Layouter**, klicka på **Lägg till**.

    ![Klicka på Lägg till för att skapa en ny layout -screenshot][img1]

1. I dialogrutan **Lägg till ny layout**, välj en layout från listan **Skapa ny baserad på**.

1. Ange ett namn och en beskrivning för den nya layouten.

    ![Ange rätt namn och de användargrupper som ska använda detta layout -screenshot][img2]

1. Klicka på fältet **Tilldela till** och tilldela den nya layouten till en eller flera användargrupper **eller** försäljnings-/projekt-/ärende-/händelsestyper **eller** dokumentmallar.

    > [!NOTE]
    > Endast grupper/typer/mallar som för närvarande använder standardlayouten visas.

1. Klicka på **OK**.

    Den nya layouten läggs till i **Layouter**-listan med status Utkast, vilket innebär att det ännu inte är synligt för användarna. Förhandsgranskningen visas på höger sida av skärmen.

## Anpassa den nya skärmlayouten

1. Med den nya layouten valt i **Layouter**-listan, klicka på knappen **Redigera layout**.

2. Gå igenom flikarna i layouten.

    * [Lägg till, redigera, flytta eller ta bort ett fält][1]
    * [Lägg till kobling eller knapp][5]
    * [Lägg till, ta bort eller återställ en flik][3]
    * [Lägg till eller ta bort ett detaljkort (arkiv)][2]

3. När du är klar, spara eller publicera layouten.

## Relaterat innehåll

* [Hur konfigurerar jag vilken information användarna i vårt företag kan komma åt i SuperOffice CRM?][15]
* [Hur skapar jag en ny användargrupp i SuperOffice CRM?][16]
* [Ta bort layout][4]

<!-- Referenced links -->
[1]: working-with-fields.md
[2]: working-with-archives.md
[3]: working-with-tabs.md
[4]: edit-layout.md#delete
[5]: add-button.md
[6]: assign-layout.md
[15]: ../../../admin/user-management/role/index.md
[16]: ../../../admin/user-management/user-groups.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/add-button-for-new-screen-layout.png
[img2]: ../../../../media/loc/en/customization/add-new-screen-layout.png
