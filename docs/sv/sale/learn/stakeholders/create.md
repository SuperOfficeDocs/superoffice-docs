---
uid: help-sv-stakeholder-create
title: Lägg till intressenter
description: Hur man kopplar en försäljning till en intressent (företag eller kontakt) i SuperOffice.
keywords: försäljning, intressent
author: Bergfrid Dias
date: 11.19.2024
version: 10.3.12
topic: concept
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Lägg till intressenter

När du lägger till intressenter i en försäljning kan du antingen tilldela roller individuellt när du lägger till kontakter/företag, tilldela roller efter att alla intressenter har lagts till, eller använda en kombination av båda metoderna.

Ett företag/en kontakt kan läggas till som en intressent flera gånger, förutsatt att olika roller specificeras varje gång.

## Steg

1. Öppna försäljningen (se [Använd fönstret Sök][1]) och gå till detaljkortet **Intressenter**.

1. Klicka på **Lägg till** under detaljkortet. Dialogrutan **Lägg till/redigera intressenter** öppnas.

1. Klicka på **Företag/Kontakt**-listan för att lägga till intressenter. Du har flera alternativ:

    * **Sök**: Skriv minst två tecken för att söka efter en kontakt eller ett företag.

    * **Historik/Favoriter**: Välj från historiklistan eller favoriter.

      ![Lägg till/redigera intressenter dialog, historik -screenshot][img5]

    * **Användargrupp**: Klicka ![ikon][img2] för att bläddra genom associerade personer efter grupp.

      ![Lägg till/redigera intressenter dialog, grupp -screenshot][img6]

    * **Företag**: Klicka ![ikon][img3] för att bläddra genom kontakter i ett företag eller lägga till ett företag som intressent.

      ![Lägg till/redigera intressenter dialog, företag -screenshot][img7]

1. **Tilldela roller**: Välj en intressent och tilldela en roll. För att tilldela samma roll till flera intressenter samtidigt, använd **Välj alla** eller håll **Ctrl/Shift** medan du väljer.

    ![Lägg till/redigera intressenter dialog, roll -screenshot][img8]

    Valfritt: Lägg till en kommentar för att beskriva intressentens roll mer detaljerat.

1. Klicka på **Spara**.

## Felsökning

* **Saknad detaljkortet**: Om detaljkortet **Intressenter** inte är synlig, se till att denna [försäljningstyp har intressenter][4] aktiverade i Inställningar och underhåll.

* **Saknad person**: Om en intressent inte finns med i listan, måste du först [skapa kontakten][3].

* **Saknade roller**: [Roller][5] definieras i Inställningar och underhåll.

## Tips

* **Lägg till intressenter via företag eller urval**

    Du kan också [lägga till intressenter via detaljkort][2] som innehåller kontakter i fönstren Företag och Urval.

* **Lägg till kommentarer**

    Om en kommentar läggs till visas ett ![ikon][img1] gem bredvid **Säljroll**-kolumnen i **Intressenter**-detaljkortet. Håll muspekaren över gemet för att visa kommentarens tooltip.

<!-- Referenced links -->
[1]: ../../../search-options/learn/find-screen.md
[2]: ../../../project/learn/project-members/add.md
[3]: ../../../contact/learn/create.md
[4]: ../../../admin/lists/learn/sale-type.md
[5]: ../../../admin/lists/learn/editing-items.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/binders.png
[img2]: ../../../../../common/icons/associate-group.png
[img3]: ../../../../../common/icons/singlecolour/contact.png
[img5]: ../../../../media/loc/en/sale/add-stakeholders-from-history.png
[img6]: ../../../../media/loc/en/sale/add-stakeholders-from-group.png
[img7]: ../../../../media/loc/en/sale/add-stakeholders-from-company.png
[img8]: ../../../../media/loc/en/sale/set-stakeholder-role.png
