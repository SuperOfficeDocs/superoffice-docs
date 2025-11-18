---
uid: help-sv-dashboard-tiles
title: Arbeta med paneler
description: Lär dig hur du lägger till, anpassar och hanterar paneler i dina dashboards i SuperOffice CRM.
keywords: dashboard, panel, lägga till panel, redigera panel, kopiera panel, ta bort panel, dataset, layout
author: digitaldiina
date: 11.21.2025
version: 11.6
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from:
  - /sv/dashboard/learn/add-tile
  - /sv/dashboard/learn/edit-tile
  - /sv/dashboard/learn/remove-tile
---

# Arbeta med paneler

Lär dig hur du lägger till, anpassar och hanterar paneler i dina dashboards i SuperOffice CRM. Paneler är visuella sammanfattningar baserade på CRM-data – perfekta för att följa upp ärenden, försäljning, aktiviteter eller marknadsföringsresultat.

Du kan använda fördefinierade paneler eller skapa egna.

## Förutsättning: växla till layoutläge

För att kunna hantera paneler måste du först gå in i layoutläge:

1. Öppna den dashboard du vill anpassa.

2. Klicka på **Uppgift**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i>) i dashboardens rubrik och välj **Redigera dashboard-paneler**.

    Dashboarden öppnas nu i layoutläge:
    * Sidopanelen **Redigera dashboard-paneler** visas till höger.
    * Varje panel visar en redigeringsikon (<i class="ph ph-pencil" aria-hidden="true"></i>).
    * Du kan lägga till, flytta, ändra storlek på eller redigera paneler.

## <a id="add"></a>Lägg till en panel

1. I sidopanelen **Redigera dashboard-paneler**, välj datatyp (till exempel företag, försäljning eller ärende) i listan **Visa paneler för**.

    ![Redigera dashboard-paneler -screenshot][img1]

2. Välj en panel från antingen **Bibliotek** (fördefinierade paneler) eller **Urval** (paneler baserade på dina egna dynamiska urval).

    * Använd **sökfältet** för att snabbt hitta paneler.
    * Varje panel har en ikon som visar paneltypen – till exempel diagram, lista eller stora siffror.

3. Lägg till panelen på dashboarden:
    * **Dra och släpp** panelen till en ledig plats.
    * Eller klicka på ikonen <i class="ph ph-plus" aria-label="+"></i> som visas när du håller muspekaren över panelnamnet.

    Panelen anpassas automatiskt till det tillgängliga utrymmet och justeras enligt dashboardens layout.

4. Justera storlek eller position vid behov.

5. Klicka på **Klar** för att lämna layoutläget.

### Skapa en panel från grunden

1. Välj alternativet **Tom panel** för den typ av data du vill visualisera.
2. Lägg till panelen i dashboarden.
3. I dialogrutan **Redigera panel**, ange ett beskrivande namn.
4. Gå till fliken **Dataset** och [definiera kriterier][4] för att styra vilken data panelen ska visa.

    ![Redigera panel: Dataset -screenshot][img2]

    Denna flik fungerar som [sökfönstret][5]. Använd den för att ange filter som ägare, datumintervall eller kategori.

5. Gå till fliken **Layout** för att konfigurera panelens utseende. Välj [diagramtyp][3], etiketter, sortering och andra formateringsalternativ.

    ![Redigera panel: Layout -screenshot][img3]

6. Klicka på **Spara**, sedan på **Klar** för att lämna layoutläget.

### <a id="selection-chart"></a>Om paneler baserade på urval

När du lägger till en panel från fliken **Urval**, länkar du inte till ett aktivt urval. I stället kopieras datasetet och layouten från [diagrammet som definierats i urvalet][6]. Därefter är panelen och urvalet oberoende av varandra.

Fliken **Urval** visar endast:

* Dynamiska urval
* Urval som matchar typen vald i **Visa paneler för**
* Urval där ett diagram har sparats på fliken **Diagram**

Om ett urval saknas i listan, kontrollera följande:

* Är det ett statiskt urval? Statisk urval stöds inte här.
* Matchar posttypen (till exempel företag, försäljning) den valda typen?
* Har ett diagram definierats och sparats på fliken **Diagram**?

När du har lagt till panelen:

* Ändringar i **kriterier** eller **diagram** i urvalet påverkar **inte** panelen.
* Ändringar i **dataset** eller **layout** i panelen påverkar **inte** urvalet.
* **Panelen synkroniseras inte** med urvalet, men uppdateras fortfarande dynamiskt baserat på sitt eget dataset.

Om du vill att panelen ska återspegla ändringar i ett urval, kan du antingen justera panelen manuellt eller ta bort den och lägga till den igen från det uppdaterade urvalet.

### Lägg till en webbpanels-panel

Använd den här panelen för att bädda in en webbsida i dashboarden:

1. Ställ in **Visa paneler för** på **Annat**.
1. Gå till fliken **Bibliotek** och välj **Webbpanel**.
1. Ange den URL som du vill visa.
1. Om URL:en använder HTTP (inte HTTPS), aktivera **Tillåt osäker adress**.
1. Klicka på **Spara** och sedan på **Klar** för att avsluta layoutläget.

### Lägg till en HTML-panel

Använd den här panelen för att visa formaterad text i dashboarden. Exempelvis ett välkomstmeddelande, en förklaring eller en beskrivning.

1. Ställ in **Visa paneler för** på **Annat**.
1. Gå till fliken **Bibliotek** och välj **HTML**.
1. Klicka på **Lägg till** för att välja minst ett språk för innehållet.
1. Använd redigeraren för att lägga till och formatera innehållet.

    Du kan använda samma formateringsalternativ som i Chat och Formulär. Lägg till innehåll på flera språk för att säkerställa att panelen visas korrekt för alla användare.

1. Klicka på **Spara** och sedan på **Klar** för att avsluta layoutläget.

## <a id="edit"></a>Redigera en panel

1. När du är i layoutläge, klicka på ikonen **Redigera** (<i class="ph ph-pencil" aria-hidden="true"></i>) på panelen.
1. På fliken **Dataset**, justera filtren vid behov.
1. Gå till fliken **Layout** och välj diagramtyp och visuella inställningar.
1. Uppdatera panelens namn för att spegla uppdaterade data eller layout.
1. Klicka på <i class="ph ph-translate" aria-label="Translate"></i> för att [lägga till en översättning][7] för panelens titel och etiketter.
1. Klicka på **Spara**.

## <a id="copy"></a>Duplicera eller kopiera en panel

Du kan återanvända en befintlig panel genom att antingen duplicera den i samma dashboard eller kopiera den till en annan dashboard. Du måste ha **redigeringsbehörighet till mål-dashboarden** för att kunna kopiera en panel dit.

1. Klicka på <i class="ph ph-dots-three-vertical" aria-label="Task menu"></i> på panelen och välj alternativet för duplicering eller kopiering.

| Alternativ | Vad det gör | Vad du gör sedan | Exempel på användning |
|---|---|---|---|
| **Duplicera panel** | Skapar en kopia av panelen i samma dashboard. Namnet uppdateras (till exempel *Panelnamn2*). | Redigera panelen: byt namn, uppdatera dataset eller layout. | Visa samma typ av data i en annan layout eller visa liknande data i samma layout. |
| **Kopiera panel till dashboard** | Lägger till panelen i en annan dashboard. Välj en måldashboard från listan. Håll muspekaren över ett dashboardnamn för att förhandsgranska dess aktuella paneler innan kopiering. | Öppna måldashboarden om du vill. Redigera panelen där vid behov. | Återanvänd en användbar panel du hittat i en kollegas dashboard. Lägg till den i en av dina egna dashboards. |

**Kopiera till dashboard** är även tillgängligt utanför layoutläget (normal visning).

## <a id="move"></a>Ordna om eller ändra storlek på paneler

När du är i layoutläge:

* **Dra en panel via rubriken** för att flytta den till en ny plats.
* **Ändra storlek på en panel** genom att dra dess nederkant, högra kant eller nedre högra hörn.

Panelerna snäpps automatiskt in i dashboardens rutnätslayout.

För att ändra antalet kolumner, avsluta layoutläget och redigera dashboardinställningarna.

## <a id="remove"></a>Ta bort en panel

Du kan ta bort paneler från en dashboard, så länge du har behörighet att redigera.

1. När du är i layoutläge, klicka på <i class="ph ph-dots-three-vertical" aria-label="Tile task menu"></i> på panelen.
1. Välj **Ta bort panel**.
1. Bekräfta borttagningen.

> [!CAUTION]
> Anpassade paneler, som HTML-, webbpanel- och urvalsbaserade paneler, tas bort permanent när de tas bort. Endast fördefinierade paneler från biblioteket kan läggas till igen senare.

## <a id="export"></a>Exportera paneler

### Ladda ner eller skriv ut panelrapporten

Klicka på <i class="ph ph-dots-three-vertical" aria-label="Task menu"></i> i panelens rubrik för att öppna följande alternativ:

* **Ladda ner PDF-dokument** / **Ladda ner PNG-dokument**: Ladda ner panelen i PDF- eller PNG-format. Exportfilerna sparas i din webbläsares mapp **Nedladdningar**.

    För andra format (**SVG, CSV och XLS**) väljer du **Visa i helskärm** i menyn.

* **Skriv ut**: Öppna panelen i dialogrutan för utskrift.

> [!TIP]
> För att dölja specifika data innan du exporterar eller skriver ut en panel klickar du på datamärkningarna (förklaringar) bredvid eller under panelen.

### Exportera ALLA rader i ett dataset till Excel

1. Klicka på en datapunkt i panelen för att visa detaljerade data.

    Ett nytt fönster öppnas med relaterade poster.

1. Klicka på <i class="ph ph-download-simple" aria-label="Download"></i> **Exportera** under listan.

1. Klicka på **Ja** för att bekräfta.

    Den här åtgärden kan ta en stund. Du kan fortsätta arbeta i SuperOffice medan du väntar. Du får ett meddelande när exporten är klar.

## Tips

* **Dölj valutamärkning:** Om du vill spara utrymme i paneler som visar belopp, kan du ställa in **Valuta** till **Dölj** i fliken Layout.

* **Jämför med mål:** I dashboards för försäljning kan du aktivera **Jämför med mål** i fliken Layout för att visualisera framsteg mot försäljningsmål. Alternativet beror på diagramtyp och dataset.

* **Använd korta tal för bättre läsbarhet:** För paneler med stora värden kan du aktivera formatet **Korta tal** för att visa värden i miljoner (t.ex. *1,2M*).

* **Paneler med stora tal:** Använd dessa för nyckeltal, som intäkter eller öppna ärenden. Håll panelnamnet kort så att siffran blir tydlig.

* **Visa varaktighet i uppföljningspaneler:** När du använder uppföljningspaneler, ställ in **Mätvärde** till **Varaktighet** för att spåra tidsanvändning mer effektivt.

## Felsökning

* **Jag ser inte redigeringsikonen i panelen**
  * Är dashboarden i layoutläge?

* **Jag hittar inte alternativet i uppgiftsmenyn**
  * Klickade du på rätt Uppgift-knapp? (dashboard vs. panel)
  * Är dashboarden i layoutläge?

* **Jag har inte tillgång till layoutfliken eller fälten**
  * Du har kanske inte rätt funktionsbehörigheter. Kontakta administratören.

* **Ett urval saknas i fliken Urval**
  * Se [Om paneler baserade på urval](#selection-chart)

* **Jag råkade ta bort en anpassad panel**
  * Dessa paneler kan inte återställas. Kopiera dem till en privat dashboard (t.ex. "Arkiverade paneler") innan du tar bort dem.

## Relaterat innehåll

* [Lägg till en ny dashboard][1]
* [Använd dashboards för att hantera din säljpipeline][2]

<!-- Referenced links -->
[1]: create.md
[2]: show-sales-targets.md
[3]: index.md#charts
[4]: ../../search-options/learn/search-criteria.md
[5]: ../../search-options/learn/find-screen.md
[6]: ../../search-options/selection/learn/howto/display-as-charts.md
[7]: ../../localization/learn/translate-fields.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/dashboard/edit-dashboard-tiles-sidebar.png
[img2]: ../../../media/loc/en/dashboard/edit-tile-dataset.png
[img3]: ../../../media/loc/en/dashboard/edit-tile-layout.png
