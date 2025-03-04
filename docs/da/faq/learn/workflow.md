---
uid: help-da-faq-workflow
title: Faser i Workflow
description: Faser i Workflow
keywords: FAQ
author: SuperOffice RnD
date: 02.25.2025
topic: howto
audience: person
audience_tooltip: SuperOffice Service
language: da
---

# Faser i Workflow

I en ny installation har du to standardtrin i workflowet: **Ikke-udgivet** og **Udgivet**. Det er muligt at tilføje flere trin mellem disse. Du kan f.eks. sætte et workflow op, hvor en FAQ-post sendes til korrekturlæsning, således at nogen kontrollerer posten og derefter udgiver den eller sender den ikke-udgivet tilbage til redigering.

## Oprettelse af nye trin

1. Gå til <i class="ph ph-list" aria-label="Main menu"></i> på toplinjen, og vælg **Vidensbase** > **FAQ**.
1. Klik på knappen **Workflow**. Du kommer til skærmbilledet **Vis workflow**.
1. Klik på knappen **Nyt trin**. Du kommer til skærmbilledet **Nyt trin**.
1. Angiv et beskrivende navn på trinnet i feltet **Navn**.
1. I listen **Anbring nyt trin mellem** skal du vælge, hvor i processen du vil sætte det nye trin ind.
1. Klik på **OK**. Du kommer til skærmbilledet **Rediger trin**.
1. I listen **Vælg bruger** nederst i skærmbilledet skal du vælge navnet på en bruger, der skal have adgang til det aktuelle trin i workflowet.
1. Vælg, hvilket adgangsniveau brugeren skal have. Du kan vælge mellem følgende valgmuligheder:
    * **Kan flytte**: Brugeren har lov til at ændre workflows for poster, (udgive eller ophæve udgivelse).
    * **Kan ændre**: Brugeren har rettigheder til at ændre FAQ-poster.
    * **Fuld adgang**: Brugeren har alle rettigheder i forbindelse med workflowet.
1. Klik på **+** for at tilføje brugeren på listen under **Brugeradgang**.
1. Gentag trinnene 7-9 ovenfor, hvis du vil tilføje flere brugere.
1. Klik på **OK**. Trinnet oprettes og er nu tilgængeligt, når du udgiver FAQ-poster.

## Redigering af trin

Du kan både ændre navnet på et trin og justere, hvilke brugere der skal have adgang til det.

1. Gå til <i class="ph ph-list" aria-label="Main menu"></i> på toplinjen, og vælg **Vidensbase** > **FAQ**.
1. Klik på knappen **Workflow**.
1. Klik på selve trinnavnet. Du kommer til skærmbilledet **Rediger trin**.
1. Rediger navnet, hvis der er behov for det.
1. Juster eventuelt, hvilke brugere der skal have adgang til det aktuelle trin:
    * Hvis du vil tilføje brugere, skal du følge den ovenstående fremgangsmåde.
    * Du kan fjerne brugere ved at vælge den eller de relevante brugere, klikke på <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> og vælge knappen **Fjern adgang for valgte brugere**.
1. Klik på **OK**. Ændringerne gemmes.

## Sletning af trin

1. Gå til <i class="ph ph-list" aria-label="Main menu"></i> på toplinjen, og vælg **Vidensbase** > **FAQ**.
1. Klik på knappen **Workflow** (<i class="ph ph-gear" aria-hidden="true"></i>).
1. Klik på selve trinnavnet. Du kommer til skærmbilledet **Rediger trin**.
1. Klik på **Slet**. Hvis trinnet ikke har nogen tilknyttede FAQ-poster, slettes det med det samme.

   > [!NOTE]
   > Du kan ikke slette standardtrinnene**Ikke-udgivet** og **Udgivet**.

1. Hvis trinnet har tilknyttede FAQ-poster, skal du vælge et trin i workflowet, som disse FAQ-poster skal flyttes til. Vælg det ønskede trin på listen **Flyt til workflow**.
1. Klik på **Slet**. Trinnet slettes, og de tilknyttede FAQ-poster flyttes til det valgte trin.

## Udgivelse via workflow

1. [Åbn FAQ-posten][1].
1. Hvis du vil justere noget før udgivelse, kan du følge fremgangsmåden under [Udgivelse af FAQ-poster][2].
1. Klik på knappen **Flyt fremad i workflow**, indtil der står **Udgivet** i feltet **Workflowtrin** under fanen **Detaljer**.

   > [!TIP]
   > Du kan vælge at ophæve udgivelsen af FAQ-posten ved at klikke på knappen **Flyt bagud i workflow**.

<!-- Referenced links -->
[1]: view-entry.md
[2]: publish.md
