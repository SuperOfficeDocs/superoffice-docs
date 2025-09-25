---
uid: help-sv-chat-channel-create
title: Skapa en chattkanal
description: Skapa en chattkanal
keywords: chattkanal, layout för chattwidget, lägg till handläggare, frånkopplat formulär, startformulär för chatt, slutformulär för chatt, aktivera avskrift
author: Bergfrid Dias
date: 09.25.2025
version: 10.5
content_type: howto
license: cep
category: Service
topic: chat
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from: /sv/chat/learn/admin/channel-create
index: true
---

# Skapa en chattkanal

Du kan skapa chattkanaler för särskilda ändamål som teknisk support, produktförfrågningar och säljsupport och tilldela handläggare till varje kanal.

![Skärmen Chattkanaler i Inställningar och underhåll med dialogrutan Redigera chattkanal öppen -screenshot][img1]

## Steg

1. Klicka på <i class="ph ph-chat-teardrop-text" aria-hidden="true"></i> **Chatt** i navigatorn.

2. Klicka på **Lägg till** längst ned i listan över chattkanaler.

3. Ange chattkanalens namn i dialogrutan. Detta ska vara ett unikt namn som används för att identifiera ämne och språk (till exempel *Teknisk support Norge*). Namnet används bara internt.

4. Fyll i fälten på flikarna som beskrivs nedan.

    Ändringarna sparas automatiskt när du går till en ny flik.

5. Klicka på **Spara** när du är klar.

> [!NOTE]
> Fält med röda ramar är obligatoriska. Flikar med ikonen <i class="ph ph-warning-circle" aria-label="Warning icon"></i> innehåller tomma obligatoriska fält.

## Egenskaper

| Egenskap | Beskrivning |
|---|---|
| Språk | Välj språk för chattfönstret. |
| Tagg | Skriv en kort text som ska visas på chattikonen på webbplatsen. |
| Beskrivning | Beskriv chattkanalens syfte. Den här texten visas bara internt. |
| Varning vid ny chatt | Om ingen agent svarar på en ny chatt inom det angivna tidsperioden skickas ett meddelande till agenter med status **Närvarande**. Agenterna måste också ha tillståndet **Varningar** på fliken **Agent**. |
| Varning till chef vid ny chatt | Om ingen agent svarar på en ny chatt inom den angivna tidsperioden skickas ett meddelande till chefen/cheferna. Den här varningen skickas endast om det finns agenter med status **Närvarande**. |
| Aktivera öppettider | Aktivera detta alternativ för att ange öppettider för specifika veckodagar. Du kan även ange din tidszon och lägga till lunchtider när chatten inte är tillgänglig. Kunderna kommer alltid att se sin lokala tid i chatten. |

Förhandsgranskningen till höger visar chattfönstret med de aktuella inställningarna.

## Utseende på chattfönster

På fliken **Utseende på chattfönster** kan du ange utseende och text som ska visas i chattfönstret som används av kunderna.

| Fält | Beskrivning |
|---|---|
| Tema | Välj ett tema för chattfönstret. |
| Färg | Välj grundfärg för chattfönstren. Den här inställningen åsidosätter färgen för det valda temat. |
| Typsnitt | Välj typsnitt för chattfönstret. Den här inställningen åsidosätter typsnittet för det valda temat. |
| Visa logotyp | Välj det här alternativet om du vill visa en bild i rubriken för chattfönstret. Om du vill lägga till en bild klickar du på länken eller drar och släpper en bildfil. |
| Visa handläggarbild | Välj det här alternativet om du vill visa en bild av agenten i chattfönstret. När en handläggare svarar på ett nytt chattsamtal ersätts logotypen och texten i rubriken med handläggarens bild och namn. |
| Sidhuvud | Ange en kort välkomsttext som ska visas i rubriken i chattfönstret. |
| Meddelande | Skriv in ett kort meddelande som ska visas under rubriken. |
| Använd anpassat kömeddelande | Välj det här alternativet om du vill ange ett kundmeddelande för kön. |

Du kan använda variabler för att ange väntetid och plats i kön:

* {cque} = En siffra som anger plats i kön
* {cavw} = Genomsnittlig väntetid i formatet hh:mm

Förhandsgranskningen till höger visar chattfönstret med de aktuella inställningarna.

## Agenter

På fliken **Agent** kan du ge användarna tillgång till en chattkanal och ange vilka behörigheter de ska ha i chatten.

### Lägg till en handläggare

1. Klicka på listan till vänster om **Lägg till**-knappen och välj en användare.
2. Klicka på **Lägg till**. Användaren läggs till i listan över agenter och har tillgång till den valda chattkanalen.
3. Välj en eller flera av följande behörigheter:
    * **Kan besvara**: Agenten kan svara på inkommande chattsamtal i den här kanalen.
    * **Förvarningar**: Handläggaren tar emot varningar om de är på plats.
    * **Kan lyssna**: Agenten kan öppna och övervaka ett pågående chattsamtal som en annan agent för.
    * **Chef**: Agenten får chefsvarningar. Denna behörighet kan användas för exempelvis teamledare.
4. Upprepa steg 1-3 för varje agent du vill lägga till.

## <a id="chatbot"></a>ChatBot

Under fliken **ChatBot** kan du aktivera chatboten. När en chatt initieras i en kanal där en chattbot är aktiv triggas skriptet "on-new-chat-message" och meddelandet skickas till skriptet för bearbetning. Skriptet skickar meddelandet för bearbetning och tar emot meddelandet, publicerar resultaten och markerar eventuellt fför överlämning till en agent.

| Alternativ | Beskrivning |
|---|---|
| Aktivera Chatbot | Välj det här alternativet om du vill aktivera chatboten. |
| Chatbot CRMScript-mapp | Välj mappen som innehåller skripten för chattboten. |
| Chatbot-namn | Vad vill du kalla din chatbot? |

## Frånkopplat formulär

På fliken **Frånkopplat formulär** kan du skriva ett meddelande som ska visas för kunden om ingen agent är på plats (till exempel utanför öppettiderna). Dessutom kan du låta kunden skicka in ett ärende.

| Fält | Beskrivning |
|---|---|
| Sidhuvud | Skriv en kort text som talar om för kunden varför ingen agent är tillgänglig. |
| Meddelande | Skriv in ett meddelande. Exempel: "Vi har öppet mellan 08:00 och 18:00" eller "Fyll i fältet nedan, så kontaktar vi dig så snart som möjligt". |
| Aktivera ärenderegistrering | Välj det här alternativet om du vill att kunden ska kunna skicka in ett ärende om chattfunktionen inte är tillgänglig. |
| Ärendekategori | Välj kategorin som ska tilldelas ärendena. |
| Ärendeprioritet | Välj prioritet som ska tilldelas ärendena. |
| Obligatoriska fält för att skicka in ärende | Välj information som kunden måste ange för att skicka in ett ärende. |

Förhandsgranskningen till höger visar chattfönstret med de aktuella inställningarna.

## Startformulär för chatt

På fliken **Startformulär för chatt** kan du definiera hur kunderna ska identifiera sig (eller inte) i chattsamtalen. Dessutom kan du aktivera automatiska FAQ-förslag från SuperOffice.

| Fält | Beskrivning |
|---|---|
| Aktivera FAQ-förslag för chatt | Om du aktiverar FAQ-förslag kommer de tre översta FAQ-artiklarna som överensstämmer med kundens meddelande att visas i chattfönstret för chattsamtalet. Kunden kan klicka på FAQ-länkarna för att visa hela FAQ-artiklarna i SuperOffice Kundcenter. Om ingen av de föreslagna FAQerna ger dem svar på frågorna kan de välja att starta chattsamtalet. |
| FAQ-mapp | Välj mappen som innehåller de FAQ-artiklar (och undermappar med FAQ-artiklar) som ska visas för kunderna. Bara FAQ-artiklar som har varit publicerade och är tillgängliga för alla (ingen inloggning krävs) visas för kunderna. |
| Aktivera startformulär för chatt för anonyma användare | Välj det här alternativet om kunderna måste identifiera sig innan de startar chattsamtalet. Det här alternativet ska vara omarkerat om kunderna ska kunna starta chattsamtalet direkt. |
| Meddelande | Skriv ett meddelande till kunden. Exempel: "Hej! Tack för att du kontaktar oss. Vad kan vi hjälpa dig med?" |
| Obligatoriska fält för att starta chatt | Välj information som kunden måste ange för att starta chattsamtalet. |

Förhandsgranskningen till höger visar chattfönstret med de aktuella inställningarna.

## Slutformulär för chatt

När kunden eller agenten avslutar chattsamtalet kan du visa ett slutschema för chattsamtalet med ytterligare information och välja att ta emot en logg för samtalet.

| Fält | Beskrivning |
|---|---|
| Aktivera slutformulär för chatt | Välj det här alternativet om du vill visa slutformuläret för chattsamtalet till kunden när samtalet är avslutat. |
| Sidhuvud | Skriv en kort rubrik. |
| Meddelande | Skriv in ett kort meddelande till kunden. |
| Aktivera chattlogg | Välj det här alternativet om du vill aktivera chattloggen. Kunden kan ange en e-postadress som loggen ska skickas till. Svarsmallen för chattloggen finns i SuperOffice. |

Förhandsgranskningen till höger visar chattfönstret med de aktuella inställningarna.

## FAQ

### Kan jag ta bort en chattkanal?

Ja, men se till att chattkanalen inte används på en webbplats. Annars är chattfönstret synligt men fungerar inte.

<!-- Referenced images -->
[img1]: ../../../media/loc/en/chat/admin-chat-channels.png
