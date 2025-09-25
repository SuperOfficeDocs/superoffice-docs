---
uid: help-da-chat-respond
title: Svare på en chatsamtale
description: Når en kunde sender en forespørgsel via chatwidgetten på hjemmesiden, er det ikke kun vigtigt at svare på den, men også at registrere den på deres kontaktkort.
keywords: svar på chat, næste chat i kø, indgående chat, tilstedeværelse
author: Bergfrid Dias
date: 09.25.2025
version: 10.5
content_type: howto
license: cep
category: Service
topic: chat
audience: person
audience_tooltip: SuperOffice CRM
language: da
redirect_from: 
  - /da/chat/learn/send-files
  - /da/chat/learn/send-faq-or-reply-template
  - /da/chat/learn/create-quick-reply
---

# Svare på en chatsamtale

Indgående chatsamtaler indikeres på følgende måder:

* Et talikon på fanen **Dashboard** viser hvor mange indgående chatsamtaler, der ikke er besvaret af en repræsentant.
* På listen **Indgående chat** under fanen **Dashboard**. Du kan dobbeltklikke på en række for at svare på en chat.
* På fanen **Chat-samtaler** viser feltet **I kø** hvor mange chatsamtaler der venter på svar.
* En advarsel vises, hvis en chat ikke bliver besvaret inden for et bestemt tidsrum. Denne advarsel vises kun, hvis din status er **Til stede**.

For at sikre, at du tilbyder hurtige og professionelle svar på dine kunders chatforespørgsler, tilbyder SuperOffice Chat en række muligheder for at fremskynde og forbedre dine chatsvar.

Spar tid ved at bruge foruddefinerede tekster, når du besvarer kundeforespørgsler via chat. Du kan oprette og sende et hurtigt svar på et ofte stillet spørgsmål. I andre situationer, hvor hurtige svar ikke er tilstrækkelige, kan du medtage ofte stillede spørgsmål, tilpassede svarskabeloner, eller filer.

## Angivelse af status (Til stede / Ikke til stede)

Angiv din tilstedeværelse øverst til højre på **Chat**-skærmbilledet.

![ikon][img3]

* **Til stede:** Du modtager advarsler om ubesvarede chatsamtaler.
* **Ikke til stede:** Du modtager ikke advarsler, men kan stadig besvare chatsamtaler. Hvis alle repræsentanter er ikke til stede, ser kunderne det offline skema, når de starter en chat.

## Svare på næste chatsamtale i køen

1. Klik på **Chat** i navigationsmenuen.

1. Sørg for, at din status i øverste højre hjørne er sat til **Tilstede**.

1. Klik på **Hent næste i køen** for at tage den næste ubesvarede chat.

    For at svare en bestemt kunde, skal du gå til fanen **Dashboard**, finde chatten i listen **Indgående chat**, og dobbeltklikke på rækken.

1. Skriv dit svar i beskedfeltet, og tryk på **ENTER** eller klik på **Send** for at chatte.

    * For at tilpasse dit svar, kan du [finde kunden i SuperOffice][1]. Du kan så se relevante oplysninger i sidepanelet.
    * For at tilføje emojis eller klistermærker, klik på <i class="ph ph-smiley" aria-label="Smiley"></i> ved siden af tekstfeltet.

1. For at sende yderligere information under chatten:
    * [Send en FAQ, et svarskabelon eller et hurtigt svar](#insert)
    * [Send en fil](#attach)

1. Hvis du ikke kan hjælpe kunden, gør ét af følgende:
    * [Overfør chatten][2] til en anden agent.
    * [Opret en sag][3] ud fra chatten.

1. Når samtalen er slut, klik på <i class="ph ph-list" aria-label="Task menu"></i> og vælg **Afslut chat**, medmindre kunden lukker chatvinduet først.
    Chatten flyttes til **Seneste chatsessioner**, og en kopi gemmes også under fanen **Aktiviteter** i SuperOffice CRM.

> [!NOTE]
> Hvis slutskemaet for chat er aktiveret for denne chatkanal, kan kunden vælge at vende tilbage til chatsamtalen. Så aktiveres chatsamtalen igen.

## <a id="insert"></a>Indsæt FAQ'er, svarskabeloner eller hurtige svar

For at spare tid skal du indsætte foruddefineret tekst i stedet for at skrive fulde svar.

1. Klik på <i class="ph ph-article" aria-label="Insert"></i> i chatpanelet.
1. Vælg en af følgende:
    * **FAQ:** Indsætter et link til en offentliggjort FAQ i kundecentret.
    * **Svarskabeloner:** Indsætter genbrugelig beskedindhold.
    * **Hurtige svar:** Indsætter et personligt tekstudklip.

    Du kan søge, gennemse mapper eller bruge ikonerne til historik og favoritter.

1. Tryk på **ENTER** eller klik på **Send** for at sende beskeden.

### Opret et nyt hurtigt svar

1. I en igangværende chat skal du klikke på <i class="ph ph-chat-teardrop-text" aria-label="Chat bubble"></i> i den nederste del af chatpanelet.
1. Klik på <i class="ph ph-pencil-simple" aria-label="Edit"></i>.
1. Vinduet **Hurtige svar** åbnes, klik på **Tilføj**. Et nyt svar føjes til listen.
1. Klik på feltet **Ny titel**, og angiv en titel for det hurtige svar. Dette vil ikke være synligt for kunden.
1. Klik på feltet **Nyt indhold**, og indtast den svartekst, du vil sende til kunderne.
1. Klik på **Gem**. Vinduet lukkes, og det nye hurtige svar gemmes. Du kan nu vælge det hurtige svar under en chat.

![Fra knappen for tilføj foruddefineret tekst kan du vælge tekst fra FAQ, Svarskabeloner og Hurtige svar -screenshot][img6]

## <a id="attach"></a>Sende filer i chat

Du kan sende dokumenter eller filer under en chatsession.

1. Klik på <i class="ph ph-paperclip" aria-label="Attachments"></i> i chatpanelet.
1. Vælg en af følgende muligheder:
    * Klik på **Vælg et CRM-dokument**, søg og vælg en fil fra SuperOffice.
    * Klik på **Upload filer**, vælg filen og klik på **Åbn**.
    * Træk og slip en fil direkte på uploadområdet. Sørg for, at **→Flyt** vises ved siden af din markør, når du slipper filen.

Filen sendes med det samme.

## Relateret indhold

* [Anvendelse af chatfunktion fra kundens perspektiv][6]
* [Oprette eller uploade et dokument][7]

<!-- Referenced links -->
[1]: link-to-person.md
[2]: transfer-to-agent.md
[3]: create-request.md
[6]: as-customer.md
[7]: ../../document/learn/create.md

<!-- Referenced images -->
[img3]: ../../../media/loc/en/chat/chat-status-present.png
[img6]: ../../../media/loc/en/chat/chat-quickreply.png
