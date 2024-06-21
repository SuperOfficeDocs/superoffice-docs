---
uid: help-da-sync-configure-default-values
title: synkroniser konfigurer standardværdier
description: synkroniser konfigurer standardværdier
author: Bergfrid Dias
date: 03.29.2023
keywords: tilbud, sync, henvisning, ERP
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Konfiguration af standardværdier for synkronisering

Ved at definere standardværdier for felter, der typisk kun har én relevant værdi, sparer du brugerne for en masse tid. Du sparer dem for at skulle markere et felt, der altid skal markeres, eller indtaste et nummer i et felt, der altid skal indeholde "30". Dette er især nyttigt, når du skal indtaste store mængder data.

1. [!include[Go to sync](../includes/goto-sync.md)]

1. Marker ERP-linket, og klik på knappen **Standardværdier** nederst.

1. I dialogboksen skal du vælge fanen for den aktør, du vil konfigurere standardværdier for.

1. Klik på **Tilføj** nederst i dialogboksen. Dialogboksen **Tilføj synkroniseringsstandardværdi** vises.

1. **ERP-felt**: Her vælger du, hvilket felt i ERP-systemet du vil definere en standardværdi for.

    * **Angiv standardværdi**: Marker her for at angive en standardværdi for det ERP-felt, du valgte ovenfor. Når du har tjekket her, indstiller du standardværdien nedenfor.

    * **Bed brugeren om værdi**: Tjek her for at give brugeren mulighed for at indtaste en værdi.

    * **Obligatorisk – Brugeren skal udfylde værdi**: Markér her for at kræve, at brugeren indtaster en værdi i feltet. Hvis det valgte ERP-felt er obligatorisk, markeres dette felt som standard.

1. Klik på **OK**.

1. Gentag trin 5-6 for at tilføje flere standardværdier.
