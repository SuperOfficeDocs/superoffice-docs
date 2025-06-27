---
uid: help-sv-mail-link-senders
title: Hantera avsändare
description: Hantera avsändare
author: SuperOffice RnD
date: 06.29.2022
keywords: Mail Link
content_type: howto, sender
language: sv
---

# Hantera avsändare

När du arkiverar ett e-postmeddelande eller en bilaga gör SuperOffice CRM en sökning för att se om avsändaren matchar något/någon av de registrerade företagen eller kontakterna.

## Söka efter ett e-postmeddelandes avsändare

Du kan använda knappen **Sök efter avsändare** för att söka efter avsändarens exakta e-postadress i den [SuperOffice-klient du använder][4].

1. Markera e-postadressen till den avsändare du vill söka efter i SuperOffice i inkorgen i din e-postklient (du kan bara välja en).

2. Klicka på knappen **Sök efter avsändare**.

3. Vad som händer sedan beror på om avsändaren finns i SuperOffice eller inte:
    * Om e-postadressen finns under ett företag/en kontakt öppnas företaget/kontakten i SuperOffice.
    * Om e-postadressen är registrerad på flera företag/kontakter öppnas en dialogruta där du kan välja ett av alternativen.
    * Om e-postadressen inte är registrerad i SuperOffice kan du lägga till den.
    * Endast SuperOffice CRM: Om avsändaren till det valda e-postmeddelandet är markerad som tidigare anställd öppnas fortfarande företaget/kontakten, men avsändaren visas inte i SuperOffice CRM om du inte har valt att visa tidigare anställda.

## Hantera e-postmeddelande från en avsändare med flera poster

Om avsändaren har registrerats flera gånger i SuperOffice CRM visas en dialogruta som informerar dig om detta och låter dig välja rätt post.

## Hantera ett e-postmeddelande från en avsändare som inte finns med i SuperOffice

Om avsändaren inte finns med i SuperOffice CRM kan du lägga till personens e-postadress i SuperOffice CRM.

1. Gör något av följande:
    * [Arkivera e-postmeddelandet under företag/kontakter][1]
    * [Arkivera e-postmeddelandet som en aktivitet][2]
    * [Arkivera bifogade filer][3]

2. Om e-postmeddelandets avsändare inte är registrerad i SuperOffice CRM visas en varning högst upp i dialogrutan för arkivering av e-postmeddelanden när du försöker arkivera: "Avsändarens e-postadress känns inte igen. Klicka här för att uppdatera SuperOffice med den här e-postadressen." Klicka på varningen.

3. Välj någon av följande alternativknappar i dialogrutan **Spara e-postadress**:
    * **Skapa ny kontakt**: Klicka på det här alternativet om du vill [lägga till e-postadressen till en ny kontakt](#new-contact).
    * **Lägg till e-postadressen till befintlig kontakt**: Klicka på det här alternativet om du vill [lägga till e-postadressen till en befintlig kontakt](#existing-contact).

4. Klicka på **OK**. Kontakten och e-postadressen visas på fliken **Kontakter** på det angivna företagskortet.

> [!NOTE]
> Om du försöker arkivera mer än ett e-postmeddelande i taget får du en uppmaning för varje avsändare som inte finns med i SuperOffice CRM.

## <a id="new-contact"></a>Lägg till en e-postadress till en ny kontakt

1. Öppna dialogrutan **Spara e-postadress**.

2. Välj alternativet **Skapa ny kontakt**.

3. Välj det företag du vill spara den nya kontakten under i fältet **Företag**. Du kan söka efter ett företag genom att börja skriva företagsnamnet och sedan välja bland sökträffarna.

4. Ange nödvändiga uppgifter om kontakten, till exempel namn, e-postadress och telefonnummer.

5. Klicka på **OK**. Kontakten och e-postadressen visas på fliken **Kontakter** på det angivna företagskortet.

## <a id="existing-contact"></a>Lägg till en e-postadress till en befintlig kontakt

1. Öppna dialogrutan **Spara e-postadress**.

2. Välj alternativet **Lägg till e-postadressen till befintlig kontakt**.

3. Välj det företag du vill registrera e-postadressen på i fältet **Företag**. Du kan söka efter ett företag genom att börja skriva företagsnamnet och sedan välja bland sökträffarna.

4. I fältet **Kontakt** väljer du bland de kontakter som har registrerats för det aktiva företaget.

5. Markera rutan **Ange som primär e-postadress för den här kontakten** om kontakten har mer än en e-postadress och du vill att den här ska användas som standardadress.

6. Klicka på **OK**. Kontakten och e-postadressen visas på fliken **Kontakter** på det angivna företagskortet.

## Ingen e-postadress i SuperOffice

Du kan arkivera ett e-postmeddelande/en bilaga eller söka efter en avsändare utan att lägga till e-postadressen i SuperOffice CRM.

Om du inte vill lägga till e-postadressen i SuperOffice CRM ska du inte klicka på varningen i dialogrutan **Arkivera e-post**.

<!-- Referenced links -->

[1]: archive-on-contact.md
[2]: archive-as-activity.md
[3]: archive-attachment.md
[4]: settings/superoffice-account.md

<!-- Referenced images -->
