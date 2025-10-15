---
uid: help-sv-ui-side-panel
title: Använd sidopanelen för att arbeta mer effektivt
description: Med sidopanelen kan du komma åt information som lagras i andra delar av SuperOffice CRM utan att lämna skärmen du befinner dig på.
keywords: sidopanel
author: Bergfrid Dias
date: 09.01.2025
version: 11.3
content_type: concept
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Sidopanelen

**Sidopanelen** är ett multifunktionellt verktyg som finns längst till höger på varje skärm i SuperOffice CRM (förutom inkorgen). Den ger snabb åtkomst till relevant information och kompletterar huvudskärmen.

Använd sidopanelen för att hantera uppgifter, få översikter eller följa upp aktiviteter, försäljningar eller kontakter. Panelens innehåll anpassas efter den skärm du befinner dig i och kommer ihåg din senaste vy för varje skärm.

![Sidopanelen visas i höger sida av SuperOffice CRM -screenshot][img10]

> [!TIP]
> Minimera sidopanelen för mer arbetsyta genom att klicka på <i class="ph ph-sidebar-simple" aria-label="Sidofältikon"></i> i det övre högra hörnet.

## Ändra vy i sidopanelen

Som standard visar sidopanelen en förhandsgranskning av den valda posten. Du kan växla mellan olika vyer i sidopanelen för att visa den information som är mest relevant för din uppgift.

Till exempel kan du visa månadsvyn samtidigt som du tittar på dagsvyn i fönstret Kalender för en bättre översikt, eller visa deltagare i ett urval som är kopplat till ett projekt du tittar på i fönstret Projekt.

1. Klicka på <i class="ph ph-caret-down" aria-label="Pil ned ikon"></i> bredvid sidopanelens namn.
2. Välj önskad vy från listan.

> [!NOTE]
> Tillgängliga vyer beror på vilken skärm du befinner dig i.

## Standardvyer

Här är de vanligaste vyerna som finns tillgängliga i sidopanelen, anpassade efter den aktiva skärmen.

> [!TIP]
> Om du snabbt vill visa andra poster utan att byta skärm klickar du på pilen (<i class="ph ph-caret-down" aria-hidden="true"></i>) bredvid postens namn i sidopanelen. Detta öppnar [historiklistan][1], där du kan välja en annan post.

### Förhandsgranskning (standard)

Visar en snabb förhandsgranskning av valda poster, som kontakter eller aktiviteter, med länkar till relaterad data. Klicka på en länk för att öppna motsvarande dialog, såsom [Händelse][6] eller [Dokument][5].

### Kalender-vyer

Håll koll på ditt schema med dessa vyer:

* **Dag:** Agenda för idag. Liknar fliken **Dag** i [fönstret Kalender][4].
* **Nästa dag:** Agenda för morgondagen.
* **Vecka:** Veckovy över händelser.
* **Månad:** Månadskalender med verktygstips för aktiviteter och en "rad"-indikator för daglig arbetsbelastning. Expandera sidopanelen för att visa flera månader.

Du kan navigera mellan datum, veckor eller månader med knapparna **Föregående** och **Nästa** (<i class="ph ph-caret-left" aria-hidden="true"></i><i class="ph ph-caret-right" aria-hidden="true"></i>) längst ner i sidopanelen.

När du är i **Kalender**-fönstret uppdateras även kalendervyn om du navigerar till en annan vecka eller månad i sidopanelen, och vice versa.

> [!NOTE]
> Du kan endast visa din egen kalender i sidopanelen. Använd fönstret **Kalender** för att se andras scheman.

### Företag

Visar en sammanfattning av det aktuella företaget i **Företag**-fönstret.

### Kontakt

Visar information om den markerade kontakten i fönstret **Företag** eller **Urval**.

Klicka på kontaktens namn för att öppna [kontaktkortet][2].

### Mina favoriter

Visar alla dina [favoriter][8].

* Markera kryssrutan i sidfot för att filtrera efter skärm (t.ex. **Endast försäljning** i Försäljning-fönstret).
* Ta bort objekt genom att markera dem och klicka på **Ta bort**.
* Klicka på <i class="ph ph-arrow-clockwise" aria-label="Uppdatera"></i> för att uppdatera listan.
* Högerklicka på en favorit för att öppna snabbmenyn.

### Projekt

Visar en översikt över det aktuella projektet i **Projekt**-fönstret.

### Projektdeltagare

Listar deltagare i det aktuella projektet i **Projekt**-fönstret.

Dubbelklicka på en projektdeltagares namn för att öppna deras [kontaktkort][2].

### Försäljning

Visar en sammanfattning av den aktuella försäljningen i **Försäljning**-fönstret.

### Urval

Visar en sammanfattning av det aktuella urvalet i **Urval**-fönstret.

### Urvalsmedlemmar

Listar medlemmar i det aktuella urvalet i **Urval**-fönstret.

## Användardefinierade vyer

Administratörer kan [definiera anpassade vyer][7] för sidopanelen i **Inställningar och underhåll**, vilket gör att panelen kan skräddarsys efter teamets behov.

## Vanliga frågor och tips

* Fäst ofta använda sidopaneler för snabb åtkomst överst i listan genom att klicka på **stjärnikonen**.

    ![Exempel på sidopanelen med favoriter fästa för snabb åtkomst -screenshot][img1]

* Använd sidopanelen för att [förhandsgranska sparade e-post][9], öppna bilagor och svara eller vidarebefordra meddelanden direkt.

* **Varför är sidopanelen tom?**
  Om ingen kontakt är angiven (t.ex. i ett dynamiskt urval utan **Inkludera kontakt**) visas ingen information i Kontakt-vyn i sidopanelen.

* **Varför ser jag "Dokumentet stängt" i sidopanelen?**
  Detta är förväntat beteende för att optimera systemresurser vid användning av InfoBridge Document Viewer. För att visa dokumentet igen, gå tillbaka till dokumentfliken och välj det på nytt. Läs mer i [denna supportartikel][11].

* **Hur kan jag använda sidopanelen effektivt för försäljning?**
  Använd den för att spåra möjligheter, övervaka förfallna aktiviteter och smidigt följa upp försäljningsförslag utan att lämna huvudskärmen. För detaljerade steg, se [Använd sidopanelen för försäljning][10].

<!-- Referenced links -->
[1]: ../../basics/history.md
[2]: ../../../contact/learn/create.md
[4]: ../../../diary/learn/index.md
[5]: ../../../document/learn/create.md#fields
[6]: ../../../diary/learn/create-follow-up.md
[7]: ../../../customization/web-panels/admin/add-web-panel.md
[8]: ../../basics/fav.md
[9]: ../../../email/learn/index.md#preview
[10]: ../../../sale/learn/index.md#side-panel
[11]: https://community.superoffice.com/en/support-faqs/faq/what-to-do-when-i-get-document-closed-in-the-side-panel-of-superoffice-crm-when-document-viewer-is-used/

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/learn/pin-side-panel-favs.png
[img10]: ../../../../media/loc/en/learn/getstarted-sidepanel-companypreview.png
