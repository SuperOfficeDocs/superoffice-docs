---
uid: help-sv-screen-designer-add-layout
title: Lägg till ny skärmlayout
description: Så här lägger du till en ny layout för en användargrupp.
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: skärmdesigner, layout, huvudkort, arkiv
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# Lägg till ny skärmlayout

Om standardlayouten inte återspeglar behoven hos en användargrupp kan du skapa en ny layout som matchar användargruppens unika informationsbehov. En anpassad layout för kontakt- och företagskorten och de olika arkiv-/sektionsflikarna gör att dina team och din organisation kan arbeta mer effektivt.

Med anpassade skärmlayouter för vart och ett av dina team blir det enklare än någonsin att hitta kunddata. Den mest relevanta informationen kommer alltid att vara tillgänglig och synlig. Ta bort, flytta eller dölj irrelevanta eller mindre viktiga data så att skärmarna Företag, Kontakt, Försäljning, Projekt, och Ärenden blir mindre röriga. Lägg till anpassade arkiv med de uppgifter som är mest relevanta för dina team. Resultatet blir en renare och prydligare skärm som dina team kan arbeta i.

## Huvudkortslayout

En anpassad layout för fönstret Kontakt och Företag gör att dina team och din organisation kan arbeta mer effektivt, eftersom det eliminerar det distraherande "informationsbruset".

Om ditt supportteam till exempel sällan använder företagsadressen när de kommunicerar med företag och kontakter, vill du kanske göra plats för andra fält som är viktigare på första sidan (fliken Företag). Flytta den genom att klicka på staplarna till vänster i fältet och dra den över till fliken **Mer**.

Titta på den här videon och ta reda på hur du lägger till en ny layout eller följ steg-för-steg-guiden nedan (videon börjar vid 5:37):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU?t=337]

### Steg

<!-- markdownlint-disable-file MD029 -->
[!include[Go to screen designer](includes/goto-screen-designer.md)]
<!-- List starts in the include. Next line MUST be 3. -->
3. Välj **Huvudkort** eller **Arkiv** (även kallade avsnittsflikar).

4. Om det är relevant, klicka på texten bredvid **Tilldela layouter till**.

    Som standard kan layouterna tilldelas användargrupper.
    Om du istället lägger till huvudkortslayouter för skärmarna Försäljning, Projekt, eller Ärende, kan du tilldela layouterna till försäljningstyper, projekttyper, eller ärendetyper.

5. Klicka på **Lägg till** under **Layouter**.

    ![Klicka på Lägg till för att skapa en ny layout -screenshot][img1]

6. I dialogrutan **Lägg till ny layout** väljer du en ny layout i listan **Skapa ny baserad på**.

    Den nya layouten kommer att baseras på den valda layouten.

7. I fältet **Namn** skriver du ett namn på den nya layouten.

    ![Ange rätt namn och användargrupper för att använda den här layouten -screenshot][img2]

8. Klicka på fältet **Tilldela till** och välj användargruppen/-grupperna som ska använda den nya layouten.

    Listan kommer endast visa användargrupper som använder standardlayouten. En användargrupp kan endast tilldelas en layout. Försäljningstyper, projekttyper, eller ärendetyper kommer att bli tillgängliga här om du har valt dessa alternativ i steg 4.

9. Ange en beskrivning av layouten i fältet **Beskrivning**.

10. Klicka på **OK** när du är färdig. Den nya layouten läggs till i listan **Layouter**. Den får status **Utkast**, vilket betyder att den ännu inte är synlig för användarna. Förhandsgranskningen visas till höger på skärmen.

    > [!TIP]
    > Om du senare vill redigera layoutinställningarna dubbelklickar du på layouten i listan för att öppna dialogrutan **Redigera layoutinställningar**. Du kan inte kan redigera inställningarna för standardlayouten.

11. När du har markerat den nya layouten i listan **Layouter** klickar du på **Redigera layout**-knappen för att anpassa skärmlayouten. Se [Redigera layout - Huvudkort][1] eller [Redigera layout - Arkiv (avsnittsflikar)][2].
<!-- markdownlint-restore -->

> [!NOTE]
> Om du vill ta bort en layout, markerar du layouten i listan **Layouter** och klickar på **Ta bort**. Användargrupper som tilldelades den borttagna layouten återgår till standardlayouten.

## Detaljkort/arkivlayout

Anpassning av layouten för de olika detaljkorten/arkiven för ett huvudkort görs normalt när det finns olika behov för de olika användargrupperna.

Du kan skapa en ny layout för de specifika användargrupperna och ställa in de olika detaljkorten så att de visas med olika innehåll.

Skapa en ny layout för en viss användargrupp genom att konfigurera detaljkort med innehåll som är relevant för den användargruppen. Genom att lägga till och ta bort de olika flikarna kan du skapa önskad konfiguration på ett huvudkort för din användargrupp.

![Lägg till namnet i det nya detaljkortet/den nya arkivlayouten och välj de användargrupper som det ska visas för -screenshot][img3]

## Relaterat innehåll

* [Hur konfigurerar jag vilken information användarna av vårt företag kan komma åt i SuperOffice CRM?][3]
* [Hur skapar jag en ny användargrupp i SuperOffice CRM?][4]
* [Användaradministration][5]

<!-- Referenced links -->
[1]: edit-layout.md
[2]: edit-layout-archives.md
[3]: ../../../admin/user-management/learn/role/index.md
[4]: ../../../admin/user-management/learn/user-groups.md
[5]: ../../../admin/user-management/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/ui/add-button-for-new-screen-layout.png
[img2]: ../../../../media/loc/en/ui/add-new-screen-layout.png
[img3]: ../../../../media/loc/en/ui/admin-screendesigner-add-archive-layout.png
