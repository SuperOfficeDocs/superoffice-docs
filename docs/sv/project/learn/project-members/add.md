---
uid: help-sv-project-member-add
title: Lägg till projektmedlem
description: Så lägger du till en projektdeltagare i SuperOffice
keywords: lägg till projektdeltagare, ny projektdeltagare, dialogrutan Lägg till/redigera projektdeltagare, projektdeltagare, projekt
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Lägga till projektdeltagare

För att länka ett projekt till ett företag måste minst en projektdeltagare specificeras. Detta kan göras på Projektskärmen eller [via detaljkorterna](#from-section-tab) för kontakter i Företag-, Urval- eller Försäljningsskärmarna.

När du lägger till deltagare i ett projekt kan du tilldela funktioner individuellt när du lägger till kontakter/företag, tilldela funktioner efteråt, eller använda en kombination av båda metoderna.

## Steg

1. Öppna projektet (se [Använd sökskärmen][1]) och gå till detaljkortet **Projektdeltagare**.

1. Klicka på **Lägg till** under detaljkortet. Dialogrutan **Lägg till/redigera projektdeltagare** öppnas.

1. Klicka på listan **Företag/kontakt** för att lägga till deltagare. Du har flera alternativ:

    * **Sök**: Skriv minst två tecken för att söka efter en kontakt eller ett företag.

    * **Historik/Favoriter**: Välj från historiklistan eller favoriter.

      ![Lägg till/redigera projektdeltagare dialog, historik -screenshot][img5]

    * **Användargrupp**: Klicka på <i class="ph ph-users" aria-label="Associate icon"></i> för att bläddra bland medarbetare efter grupp.

      ![Lägg till/redigera projektdeltagare dialog, grupp -screenshot][img6]

    * **Företag**: Klicka på <i class="ph ph-arrow-circle-right" aria-label="Arrow right"></i> för att bläddra bland kontakter i ett företag eller lägga till ett företag som deltagare.

      ![Lägg till/redigera projektdeltagare dialog, företag -screenshot][img7]

1. **Tilldela funktioner**: Välj en projektdeltagare och tilldela en funktion. För att tilldela samma funktion till flera deltagare samtidigt, använd **Markera alla** eller håll **Ctrl/Shift** nedtryckt medan du väljer.

    ![Lägg till/redigera projektdeltagare dialog, funktion -screenshot][img8]

    Valfritt: Lägg till en kommentar för att beskriva projektdeltagarens funktion i mer detalj.

1. Klicka på **OK**.

## <a id="from-section-tab"></a>Lägga till projektdeltagare och intressenter från detaljkort

Du kan lägga till projektdeltagare och intressenter från kontaktöversikterna på olika detaljkort, till exempel **Företag** (**Kontakter**), **Urval** (**Företag/Kontakt**), **Försäljning** (**Intressenter**) och **Projekt** (**Projektdeltagare**). Proceduren nedan kan med andra ord även utföras från fliken **Resultat** i fönstret [Sök][1].

**Steg:**

1. Välj detaljkort eller fönstret **Sök**.

2. Välj önskad kontakt från listan.

    > [!NOTE]
    > För att lägga till flera kontakter som intressenter/projektdeltagare, använder du **Shift** eller **Ctrl** + klick.

3. Högerklicka på kontakter och välj **Lägg till försäljning** eller **Lägg till projekt** i menyn som visas.

4. I fältet **Försäljning** eller **Projekt** anger du vilken försäljning/vilket projekt som kontakterna ska läggas till i. Du gör detta antingen genom att klicka på pilen och välja en försäljning/ett projekt i listrutan som visas, genom att skriva in hela eller början på namnet på försäljningen/projektet.

5. I fältet **Säljroll** eller **Funktion** anger du vilken säljroll/funktion varje person har i försäljningen/projektet. Klicka på pilen om du vill se en lista över fördefinierade alternativ som du kan välja.

6. Klicka på **Spara**.

## Felsökning

* **Saknad person:** Om en person inte är listad, måste du först [skapa kontakten][3].

* **Saknade roller:** Tillgängliga [funktioner][5] definieras i Inställningar och underhåll.

## Tips

* **Lägg till kommentarer**

    Om en kommentar har lagts till, visas ett gem (<i class="ph ph-paperclip" aria-hidden="true"></i>) bredvid kolumnen **Information om projektdeltagare** i detaljkortet **Projektdeltagare**. Håll muspekaren över gemet för att se kommentartipset.

<!-- Referenced links -->
[1]: ../../../search-options/learn/find-screen.md
[3]: ../../../contact/learn/create.md
[5]: ../../../admin/lists/update-items.md

<!-- Referenced images -->
[img5]: ../../../../media/loc/en/project/add-project-member-from-history.png
[img6]: ../../../../media/loc/en/project/add-project-member-from-group.png
[img7]: ../../../../media/loc/en/project/add-project-member-from-company.png
[img8]: ../../../../media/loc/en/project/set-project-member-function.png
