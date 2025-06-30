---
uid: help-sv-mail-link-archive-attachment
title: Arkivera bifogade filer
description: Om du vill spara en e-postbilaga men inte själva e-postmeddelandet i SuperOffice CRM kan du arkivera bilagan som ett dokument.
author: SuperOffice RnD
date: 06.29.2022
keywords: Mail Link, e-post, bilaga
content_type: howto
language: sv
---

# Arkivera bifogade filer

Om bilagan är den enda delen av e-postmeddelandet du vill behålla för framtida referens kan du arkivera den till SuperOffice CRM. Följ de här stegen:

![Använd Mail Link i Outlook för att arkivera en e-postbilaga i inkorgen till SuperOffice CRM -screenshot][img1]

## Steg

1. Välj det e-postmeddelande som innehåller bilagan/bilagorna du vill arkivera.

2. Klicka på knappen **Arkivera e-post** i verktygsfältet och välj **Arkivera bifogad fil** i listrutan.

3. Nu händer något av följande:

    * Om det bara finns en bilaga öppnas dialogrutan **Arkivera bifogad(e) fil(er)** omedelbart.
    * Om det finns mer än en bifogad fil visas en dialogruta med en lista över de bifogade filerna. Välj den bifogade filen och klicka på **OK** för att arkivera den. Då öppnas dialogrutan **Arkivera bifogad(e) fil(er)** och proceduren nedan upprepas för varje bilaga.

4. Om e-postmeddelandets avsändare inte är registrerad i SuperOffice CRM visas en varning högst upp i dialogrutan. [Så hanterar du oregistrerade avsändare][1].

5. I fältet **Ämne** infogas filnamnet på den bifogade filen automatiskt. Du kan dock ange vilken ämnestext som helst som du vill ska visas på detaljkortet **Aktiviteter** i SuperOffice CRM.

6. I fältet **Företag** kan du söka efter ett företag genom att börja skriva företagsnamnet och sedan välja bland matchningarna som visas.

7. I fältet **Kontakt** kan du använda listrutan för att välja bland personerna som är registrerade på företaget som du valde i förra steget. Du kan även söka genom att börja skriva in namnet på kontakten.

8. Om du vill länka bilagan till ett visst projekt kan du välja projektet i fältet **Projekt**.

9. Om du vill länka bilagan till en viss försäljning kan du välja försäljning i fältet **Försäljning**.

10. I listrutan **Typ** kan du välja en av de tillgängliga dokumentmallarna.

11. Klicka på pilen bredvid fältet i fältet **Synlig för**. En lista visas där du kan välja om bilagan ska vara synlig för alla användare, privat (bara synlig för den som är definierad som ägare) eller synlig för alla användare i den användargrupp ägaren tillhör.

    > [!NOTE]
    > Fältet **Synlig för** är bara tillgängligt om denna behörighet har tilldelats till dig under Inställningar och underhåll.

12. Klicka på **OK**. Den valda bilagan arkiveras i SuperOffice CRM som ett nytt dokument. Du kan sedan öppna dokumentet genom att dubbelklicka på det under fliken **Aktiviteter** .

## Vad vill du göra nu?

* [Arkivera e-postmeddelanden under företag/kontakter][2]
* [Arkivera e-post som aktiviteter][3]
* [Arkivera e-postmeddelanden som ärenden][4]

<!-- Referenced links -->
[1]: manage-senders.md
[2]: archive-on-contact.md
[3]: archive-as-activity.md
[4]: archive-as-request.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/email/email-maillink-archive-attachment.png
