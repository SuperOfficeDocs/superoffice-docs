---
uid: help-sv-request-reply
title: Svara kontakt
description: I den här guiden får du lära dig hur du svarar på alla inkommande ärenden i SuperOffice.
keywords: ärende, svara på ärende, svara, svara alla, lägga till meddelande, lägga till kommentar, kommentar, internt, externt, ärende,
author: Bergfrid Dias
date: 03.11.2025
version: 10.5.3
content_type: howto
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: sv
---

# Svara kontakt

Vid ärendehantering är din viktigaste uppgift att besvara förfrågningar. Du kan svara på ett enskilt ärende eller flera ärenden samtidigt.

När du öppnar ett ärende och väljer **Svara**, visas automatiskt den [e-postsignatur][7] du har ställt in. Därefter kan du lägga till ditt meddelande till kontakten med svaret på deras fråga eller lösningen på deras problem.

![Svara på ett ärende -screenshot][img4]

> [!TIP]
> Ställ in *Antal expanderade meddelanden*-inställningen (under <i class="ph ph-user-circle" aria-hidden="true"></i> **Personliga inställningar** > **Preferenser** > **Ärende**) för att bestämma hur många meddelanden som visas när du visar ett ärende.

## Svara på ett ärende

1. [Öppna ärendet][1].

1. Klicka på <i class="ph ph-arrow-bend-up-left" aria-label="Svara"></i> eller <i class="ph ph-arrow-bend-double-up-left" aria-label="Svara alla"></i>.
    * Alternativt kan du klicka på <i class="ph ph-dots-three-circle-vertical" aria-label="Uppgiftsmeny"></i> och välja **Svara** eller **Svara alla**.

1. Kontakten läggs automatiskt till som mottagare i fältet **Till**. Du kan lägga till eller ta bort mottagare vid behov.

1. [Skriv ditt meddelande][2] i fliken **Meddelande**.
    * Använd [svarsmallar][8] för att spara tid. Om mallen finns på flera språk kan du välja språk genom att klicka på <i class="ph ph-globe" aria-label="Språk"></i>.
    * Kontrollera att **Externt** är valt i fältet **Åtkomstnivå** om kontakten ska kunna se meddelandet.

    ![Svara på ett ärende -screenshot][img3]

1. Klicka på <i class="ph ph-paperclip" aria-label="Bilagor"></i> för att bifoga relevanta dokument.

1. Klicka på **Spara** för att skicka meddelandet.

## <a id="reply-templ"></a>Lägga till svarsmallar i meddelanden

Du kan spara tid genom att använda [svarsmallar][8] som utgångspunkt för ditt svar.

1. Placera markören i meddelandefältet där du vill infoga svarsmallen.
1. Klicka på <i class="ph ph-article" aria-label="Insert"></i> och välj **Svarsmall**.
1. Välj en mall från listan. Håll markören över en mall för att förhandsgranska den innan du infogar den.
1. Redigera texten vid behov och bifoga filer om det behövs.

## Lägga till ett meddelande till flera ärenden

Du kan svara på flera ärenden samtidigt, exempelvis om du fått flera förfrågningar om samma problem.

1. Välj de ärenden du vill besvara:
    * Använd ett **sparat urval** i urvalsskärmen.
    * Använd sökresultaten från skärmen **Sök ärenden**.

1. Klicka på **Uppgift**-knappen <i class="ph ph-list" aria-hidden="true"></i> och välj **Svara kunder**.

1. I dialogrutan **Svara kunder**:
    * **Skicka kopia till kunder (bara externa ärenden)**: Markera denna ruta för att skicka meddelandet via e-post.
    * **Avsluta ärende**: Markera denna ruta om du vill avsluta ärendena efter att meddelandet har skickats.
    * Lägg till ditt meddelande i textfältet. Använd [svarsmallar][8] för att spara tid.

    Meddelandet läggs till i de valda ärendena och skickas som e-post till kontakterna för de externa ärendena.

1. Klicka på **Svara** för att skicka meddelandet.

## Lägga till en kommentar

Du kan lägga till interna kommentarer i ett ärende utan att de skickas till kunden, exempelvis för att dokumentera vad som har gjorts hittills.

1. [Öppna ärendet][1].
1. Klicka på <i class="ph ph-chat-text" aria-hidden="true"></i> **Lägg till kommentar** ovanför meddelandetråden.
1. Skriv in din kommentar i textfältet.
    * Välj **Internt** i verktygsfältet för att säkerställa att kommentaren endast är synlig för dina kollegor.
1. Klicka på **Spara**.

> [!TIP]
> Använd kommentarer för att ge kontext när du [överför ärenden][10] till kollegor.

## <a id="time-spent"></a>Registrera tidsåtgång

När du svarar på ett ärende kan du registrera den tid du lägger på att besvara det.

1. I verktygsfältet längst ner på fliken **Meddelande**, kontrollera timern:
   * Klicka på <i class="ph ph-play" aria-label="Play"></i> för att starta tidsregistreringen.
   * Klicka på <i class="ph ph-pause" aria-label="Pause"></i> för att stoppa timern.
1. Justera tiden manuellt om det behövs.
1. Spara ärendet för att logga tidsåtgången.

Den registrerade tiden visas i varje meddelandehuvud, och svarstiden finns tillgänglig i fliken **Ändringslogg**.

## Relaterat innehåll

* [Vidarebefordra ärende][10]
* [Stänga ärende][3]
* [Hålla koll på meddelanden][4]
* [Skapa svarsmall][8]
* [Skapa ny språkversion av svarsmall][5]
* [Redigera e-postsignatur][7]

<!-- Referenced links -->
[1]: index.md#open
[2]: create.md#fields
[3]: close.md
[4]: flag-message.md
[5]: ../reply-templates/learn/new-language.md
[7]: ../../learn/getting-started/edit-email-signature.md
[8]: ../reply-templates/learn/index.md
[10]: forward.md

<!-- Referenced images -->
[img3]: ../../../media/loc/en/request/message-to-external.png
[img4]: ../../../media/loc/en/request/reply-to-a-customer.png
