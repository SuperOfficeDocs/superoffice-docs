---
uid: help-sv-archive-edit-layout
title: Redigera layout för detaljkort/arkiv
description: ScreenDesigner Redigera layout - Arkiv (avsnittsflikar)
author: SuperOffice RnD
so.date: 02.23.2023
keywords: skärmdesigner, detaljkort, arkiv
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# Redigera layout för detaljkort/arkiv

Du kan redigera layouten genom att lägga till eller ta bort detaljkort/arkiv på de olika huvudkorten för Företag, Kontakt, Försäljning, Projekt, och Ärenden.

## Förtydligande

Avsnittsflikar är flikarna längst ner på de flesta SuperOffice CRM-skärmarna. Exempel: Skärmen Företag har detaljkort som innehåller kontakter, aktiviteter, projekt och försäljning. Dessa kallas också arkiv. Det finns också avsnittsflikar som inte betraktas som arkiv, t.ex. avsnittsflikar som innehåller säljguider, projektguider och offerter. För syftet med det här ämnet kommer vi att kalla dem arkiv eller arkivflikar (när vi hänvisar till fliken som innehåller arkivet).

När du har skapat en ny layout för arkiv (avsnittsflikar) enligt beskrivningen i Lägg till layout är det dags att anpassa den utifrån behoven hos den/de tilldelade användargruppen/-grupperna. Om du anpassar en layout för säljteamet, bör du ha en tydlig plan för vad deras behov är när det gäller layout, formatering och innehåll i arkiven. Behöver de anpassade arkiv med filtrerade data? Vilken information ska visas först och vara enklast att hitta? Behöver de alla arkiv?

## Steg

Du kan lägga till ett nytt detaljkort på valfritt huvudkort. Beroende på vilket huvudkort som valts kan du lägga till en ny flik med innehållet: Dokument, Bokning, Produkt, Projekt, Projektmedlem, Försäljning, Säljintressent, Ärende, Kontakt och Relation.

![Välj vilken typ av innehåll du vill visa på detaljkortet -screenshot][img5]

<!-- markdownlint-disable MD029 -->
[!include[Go to screen designer](includes/goto-screen-designer.md)]
<!-- List starts in the include. Next line MUST be 3. -->
3. Klicka på **Arkiv**.

4. Välj en layout i listan till vänster.

5. Klicka på **Redigera layout** under förhandsgranskningen. Ett nytt fönster öppnas.

6. Se avsnitten nedan för mer information om hur du redigerar layouten.

7. När du är klar med att redigera layouten klickar du på någon av följande knappar:

    * **Spara utkast**: Klicka på den här knappen om layouten inte är klar ännu.
    * **Spara + publicera**: Klicka på den här knappen för att publicera layouten till de valda användargrupperna.
    * **Avbryt**: Klicka på den här knappen för att [ta bort alla ändringar](#undo-changes).
<!-- markdownlint-restore -->

## Lägg till detaljkort

1. Klicka på ![ikon][img2] **Lägg till**. Avsnittet **Flik** öppnas till vänster.

2. Under **Namn** ersätter du texten **Ny flik** med arkivets namn. Du kan också lägga till namnet på [andra språk][1] genom att klicka på ![ikon][img3].

3. Om det är relevant, redigera **Unikt namn för fliken (soprotocol)**. Namnet kan inte ändras senare.

4. Ange en beskrivning av arkivet i fältet **Beskrivning**. Du kan också lägga till beskrivningen på [andra språk][1] genom att klicka på ![ikon][img3].

5. Välj avsnittet **Inställningar**.

6. I listan **Innehåll** väljer du vilken typ av data som du vill visa i arkivet. Data i arkivet kommer att begränsas till data för den aktuella skärmen.

    Exempel: Om du lägger till ett arkiv på skärmen Företag visas endast data som är kopplade till företaget i fråga.

7. Så gör du för att lägga till/redigera relevanta kriterier under **Filter**:

    * [Redigera ett kriterium][2].

        Exempel: Välj **Bokning** på listan **Innehåll** och lägg till kriterier för att endast visa interna och externa möten denna och nästa vecka.

    * Klicka på **Lägg till** för att ange fler villkor. Då läggs en ny rad till i kriterielistan.

    * Om du vill flytta sökkriterier, klickar du och drar .

    * Klicka på **Eller** för att lägga till en annan uppsättning kriterier.

8. Klicka på **Uppdatera förhandsgranskning** för att visa data för de aktuella kriterierna i förhandsgranskningen till höger. Använd listan **Förhandsgranskning av företag** för att välja företaget som ska förhandsgranskas.

9. Klicka på **Avancerade alternativ** för att ändra standardåtgärderna för enkelklick och dubbelklick i arkivet. Du kan se exempel på hur du ställer in detta under **Exempel på syntax** och genom att hålla muspekaren över ikonen( ![ikon][img4] ).

    > [!NOTE]
    > Som standard markerar du en rad med ett enkelklick, medan ett dubbelklick öppnar en post/entitet i SuperOffice. Om ditt företag däremot använder anpassade arkiv för att visa data från andra system, kan du ändra dessa inställningar för att öppna en post i ett externt system.

10. Klicka och dra det nyskapade arkivet i förhandsgranskningen och flytta det till önskad position.

11. Spara beskrivningarna enligt beskrivningen ovan.

## Redigera befintliga avsnittsflikar

Om du vill redigera ett befintligt arkiv, markerar du det och redigerar de tillgängliga fälten och inställningarna i avsnitten **Flik** och **Inställningar**. Du kan även klicka och dra det till en ny position.

## Begränsningar

* Standardflikar kan inte redigeras.

* Vissa flikar som **Offert**, **Säljguide** och **Projektguide**, kan inte redigeras eftersom de har specifika funktioner.

## Ta bort ett arkiv

1. Välj arkivet (eller någon annan avsnittsflik) och klicka på **Uppgift** &gt; **Ta bort flik**.

1. Klicka på **OK** i dialogrutan som visas. Fliken tas bort (dold men inte raderad).

![Klicka på Uppgift och sedan på Ta bort fliken för att ta bort oönskade flikar på detaljkortet (arkiv) -screenshot][img1]

Du kan alltid klicka på **Återställ flikar** för att ångra dessa ändringar.

## <a id="undo-changes" />Ångra ändringar

Om du behöver återgå till en tidigare version av skärmen, kommer du åt följande alternativ från **Uppgift**-knappen:

* **Återställ till fabriksinställningar**: Det här alternativet tar bort alla ändringar och återställer layouten till den standardlayout som levereras av SuperOffice.

* **Återställ flikar**: Detta alternativ återställer alla flikar som har tagits bort.

* **Ignorera utkast**: Tar bort alla ändringar och återställer till den publicerade versionen av layouten.

## Relaterat

* [Hur omorganiserar jag fälten på fliken Mer in fönstret Företag och Kontakt efter uppgraderingen till SuperOffice version 10?][3] - FAQ
* [Skapa ny layout][4]

<!-- Referenced links -->
[1]: ../../../globalization-and-localization/learn/translate-fields.md
[2]: ../../../search-options/learn/using-search-criteria.md
[3]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-reorganize-the-fields-in-the-more-tab-in-company-and-contact-screenscards-after-the-upgrade-to-superoffice-version-10/
[4]: add-new-layout.md

<!-- Referenced images -->
[img2]: ../../../../../common/icons/add-icon.png
[img3]: ../../../../../common/icons/az.png
[img4]: ../../../../../common/icons/info-ball.png
[img1]: ../../../../media/loc/en/ui/admin-screendesigner-edit-archive.png
[img5]: ../../../../media/loc/en/ui/admin-screendesigner-edit-archive-add-tab.png
